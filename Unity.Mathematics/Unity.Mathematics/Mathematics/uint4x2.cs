using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x02000048 RID: 72
	[Serializable]
	[StructLayout(2)]
	public struct uint4x2
	{
		// Token: 0x06002489 RID: 9353 RVA: 0x000BCC44 File Offset: 0x000BAE44
		// Note: this type is marked as 'beforefieldinit'.
		static uint4x2()
		{
			Il2CppClassPointerStore<uint4x2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "uint4x2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<uint4x2>.NativeClassPtr);
			uint4x2.NativeFieldInfoPtr_c0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, "c0");
			uint4x2.NativeFieldInfoPtr_c1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, "c1");
			uint4x2.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, "zero");
			uint4x2.NativeMethodInfoPtr__ctor_Public_Void_uint4_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672373);
			uint4x2.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672374);
			uint4x2.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672375);
			uint4x2.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672376);
			uint4x2.NativeMethodInfoPtr__ctor_Public_Void_bool4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672377);
			uint4x2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672378);
			uint4x2.NativeMethodInfoPtr__ctor_Public_Void_int4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672379);
			uint4x2.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672380);
			uint4x2.NativeMethodInfoPtr__ctor_Public_Void_float4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672381);
			uint4x2.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672382);
			uint4x2.NativeMethodInfoPtr__ctor_Public_Void_double4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672383);
			uint4x2.NativeMethodInfoPtr_op_Implicit_Public_Static_uint4x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672384);
			uint4x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672385);
			uint4x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x2_bool4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672386);
			uint4x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672387);
			uint4x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x2_int4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672388);
			uint4x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672389);
			uint4x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x2_float4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672390);
			uint4x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x2_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672391);
			uint4x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x2_double4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672392);
			uint4x2.NativeMethodInfoPtr_op_Multiply_Public_Static_uint4x2_uint4x2_uint4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672393);
			uint4x2.NativeMethodInfoPtr_op_Multiply_Public_Static_uint4x2_uint4x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672394);
			uint4x2.NativeMethodInfoPtr_op_Multiply_Public_Static_uint4x2_UInt32_uint4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672395);
			uint4x2.NativeMethodInfoPtr_op_Addition_Public_Static_uint4x2_uint4x2_uint4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672396);
			uint4x2.NativeMethodInfoPtr_op_Addition_Public_Static_uint4x2_uint4x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672397);
			uint4x2.NativeMethodInfoPtr_op_Addition_Public_Static_uint4x2_UInt32_uint4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672398);
			uint4x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint4x2_uint4x2_uint4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672399);
			uint4x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint4x2_uint4x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672400);
			uint4x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint4x2_UInt32_uint4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672401);
			uint4x2.NativeMethodInfoPtr_op_Division_Public_Static_uint4x2_uint4x2_uint4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672402);
			uint4x2.NativeMethodInfoPtr_op_Division_Public_Static_uint4x2_uint4x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672403);
			uint4x2.NativeMethodInfoPtr_op_Division_Public_Static_uint4x2_UInt32_uint4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672404);
			uint4x2.NativeMethodInfoPtr_op_Modulus_Public_Static_uint4x2_uint4x2_uint4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672405);
			uint4x2.NativeMethodInfoPtr_op_Modulus_Public_Static_uint4x2_uint4x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672406);
			uint4x2.NativeMethodInfoPtr_op_Modulus_Public_Static_uint4x2_UInt32_uint4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672407);
			uint4x2.NativeMethodInfoPtr_op_Increment_Public_Static_uint4x2_uint4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672408);
			uint4x2.NativeMethodInfoPtr_op_Decrement_Public_Static_uint4x2_uint4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672409);
			uint4x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x2_uint4x2_uint4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672410);
			uint4x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x2_uint4x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672411);
			uint4x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x2_UInt32_uint4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672412);
			uint4x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x2_uint4x2_uint4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672413);
			uint4x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x2_uint4x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672414);
			uint4x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x2_UInt32_uint4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672415);
			uint4x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x2_uint4x2_uint4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672416);
			uint4x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x2_uint4x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672417);
			uint4x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x2_UInt32_uint4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672418);
			uint4x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x2_uint4x2_uint4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672419);
			uint4x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x2_uint4x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672420);
			uint4x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x2_UInt32_uint4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672421);
			uint4x2.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_uint4x2_uint4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672422);
			uint4x2.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_uint4x2_uint4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672423);
			uint4x2.NativeMethodInfoPtr_op_LeftShift_Public_Static_uint4x2_uint4x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672424);
			uint4x2.NativeMethodInfoPtr_op_RightShift_Public_Static_uint4x2_uint4x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672425);
			uint4x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x2_uint4x2_uint4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672426);
			uint4x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x2_uint4x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672427);
			uint4x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x2_UInt32_uint4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672428);
			uint4x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x2_uint4x2_uint4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672429);
			uint4x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x2_uint4x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672430);
			uint4x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x2_UInt32_uint4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672431);
			uint4x2.NativeMethodInfoPtr_op_OnesComplement_Public_Static_uint4x2_uint4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672432);
			uint4x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint4x2_uint4x2_uint4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672433);
			uint4x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint4x2_uint4x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672434);
			uint4x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint4x2_UInt32_uint4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672435);
			uint4x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint4x2_uint4x2_uint4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672436);
			uint4x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint4x2_uint4x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672437);
			uint4x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint4x2_UInt32_uint4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672438);
			uint4x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint4x2_uint4x2_uint4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672439);
			uint4x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint4x2_uint4x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672440);
			uint4x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint4x2_UInt32_uint4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672441);
			uint4x2.NativeMethodInfoPtr_get_Item_Public_get_byref_uint4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672442);
			uint4x2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_uint4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672443);
			uint4x2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672444);
			uint4x2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672445);
			uint4x2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672446);
			uint4x2.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, 100672447);
		}

		// Token: 0x0600248A RID: 9354 RVA: 0x000BD28C File Offset: 0x000BB48C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 599697, RefRangeEnd = 599699, XrefRangeStart = 599697, XrefRangeEnd = 599699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint4x2(uint4 c0, uint4 c1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr__ctor_Public_Void_uint4_uint4_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600248B RID: 9355 RVA: 0x000BD2CC File Offset: 0x000BB4CC
		[CallerCount(0)]
		public unsafe uint4x2(uint m00, uint m01, uint m10, uint m11, uint m20, uint m21, uint m30, uint m31)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600248C RID: 9356 RVA: 0x000BD360 File Offset: 0x000BB560
		[CallerCount(0)]
		public unsafe uint4x2(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600248D RID: 9357 RVA: 0x000BD394 File Offset: 0x000BB594
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 642265, RefRangeEnd = 642266, XrefRangeStart = 642264, XrefRangeEnd = 642265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint4x2(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600248E RID: 9358 RVA: 0x000BD3C8 File Offset: 0x000BB5C8
		[CallerCount(0)]
		public unsafe uint4x2(bool4x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr__ctor_Public_Void_bool4x2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600248F RID: 9359 RVA: 0x000BD3FC File Offset: 0x000BB5FC
		[CallerCount(0)]
		public unsafe uint4x2(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002490 RID: 9360 RVA: 0x000BD430 File Offset: 0x000BB630
		[CallerCount(0)]
		public unsafe uint4x2(int4x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr__ctor_Public_Void_int4x2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002491 RID: 9361 RVA: 0x000BD464 File Offset: 0x000BB664
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 642273, RefRangeEnd = 642274, XrefRangeStart = 642266, XrefRangeEnd = 642273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint4x2(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002492 RID: 9362 RVA: 0x000BD498 File Offset: 0x000BB698
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 642281, RefRangeEnd = 642282, XrefRangeStart = 642274, XrefRangeEnd = 642281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint4x2(float4x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr__ctor_Public_Void_float4x2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002493 RID: 9363 RVA: 0x000BD4CC File Offset: 0x000BB6CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 642289, RefRangeEnd = 642290, XrefRangeStart = 642282, XrefRangeEnd = 642289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint4x2(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002494 RID: 9364 RVA: 0x000BD500 File Offset: 0x000BB700
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 642297, RefRangeEnd = 642298, XrefRangeStart = 642290, XrefRangeEnd = 642297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint4x2(double4x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr__ctor_Public_Void_double4x2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002495 RID: 9365 RVA: 0x000BD534 File Offset: 0x000BB734
		[CallerCount(0)]
		public unsafe static implicit operator uint4x2(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_Implicit_Public_Static_uint4x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002496 RID: 9366 RVA: 0x000BD574 File Offset: 0x000BB774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642298, XrefRangeEnd = 642299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint4x2(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x2_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002497 RID: 9367 RVA: 0x000BD5B4 File Offset: 0x000BB7B4
		[CallerCount(0)]
		public unsafe static explicit operator uint4x2(bool4x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x2_bool4x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002498 RID: 9368 RVA: 0x000BD5F4 File Offset: 0x000BB7F4
		[CallerCount(0)]
		public unsafe static explicit operator uint4x2(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x2_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002499 RID: 9369 RVA: 0x000BD634 File Offset: 0x000BB834
		[CallerCount(0)]
		public unsafe static explicit operator uint4x2(int4x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x2_int4x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600249A RID: 9370 RVA: 0x000BD674 File Offset: 0x000BB874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642299, XrefRangeEnd = 642300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint4x2(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x2_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600249B RID: 9371 RVA: 0x000BD6B4 File Offset: 0x000BB8B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642300, XrefRangeEnd = 642301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint4x2(float4x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x2_float4x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600249C RID: 9372 RVA: 0x000BD6F4 File Offset: 0x000BB8F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642301, XrefRangeEnd = 642302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint4x2(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x2_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600249D RID: 9373 RVA: 0x000BD734 File Offset: 0x000BB934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642302, XrefRangeEnd = 642303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint4x2(double4x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x2_double4x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600249E RID: 9374 RVA: 0x000BD774 File Offset: 0x000BB974
		[CallerCount(0)]
		public unsafe static uint4x2 operator *(uint4x2 lhs, uint4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_Multiply_Public_Static_uint4x2_uint4x2_uint4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600249F RID: 9375 RVA: 0x000BD7C0 File Offset: 0x000BB9C0
		[CallerCount(0)]
		public unsafe static uint4x2 operator *(uint4x2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_Multiply_Public_Static_uint4x2_uint4x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024A0 RID: 9376 RVA: 0x000BD80C File Offset: 0x000BBA0C
		[CallerCount(0)]
		public unsafe static uint4x2 operator *(uint lhs, uint4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_Multiply_Public_Static_uint4x2_UInt32_uint4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024A1 RID: 9377 RVA: 0x000BD858 File Offset: 0x000BBA58
		[CallerCount(0)]
		public unsafe static uint4x2 operator +(uint4x2 lhs, uint4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_Addition_Public_Static_uint4x2_uint4x2_uint4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024A2 RID: 9378 RVA: 0x000BD8A4 File Offset: 0x000BBAA4
		[CallerCount(0)]
		public unsafe static uint4x2 operator +(uint4x2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_Addition_Public_Static_uint4x2_uint4x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024A3 RID: 9379 RVA: 0x000BD8F0 File Offset: 0x000BBAF0
		[CallerCount(0)]
		public unsafe static uint4x2 operator +(uint lhs, uint4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_Addition_Public_Static_uint4x2_UInt32_uint4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024A4 RID: 9380 RVA: 0x000BD93C File Offset: 0x000BBB3C
		[CallerCount(0)]
		public unsafe static uint4x2 operator -(uint4x2 lhs, uint4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint4x2_uint4x2_uint4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024A5 RID: 9381 RVA: 0x000BD988 File Offset: 0x000BBB88
		[CallerCount(0)]
		public unsafe static uint4x2 operator -(uint4x2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint4x2_uint4x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024A6 RID: 9382 RVA: 0x000BD9D4 File Offset: 0x000BBBD4
		[CallerCount(0)]
		public unsafe static uint4x2 operator -(uint lhs, uint4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint4x2_UInt32_uint4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024A7 RID: 9383 RVA: 0x000BDA20 File Offset: 0x000BBC20
		[CallerCount(0)]
		public unsafe static uint4x2 operator /(uint4x2 lhs, uint4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_Division_Public_Static_uint4x2_uint4x2_uint4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024A8 RID: 9384 RVA: 0x000BDA6C File Offset: 0x000BBC6C
		[CallerCount(0)]
		public unsafe static uint4x2 operator /(uint4x2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_Division_Public_Static_uint4x2_uint4x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024A9 RID: 9385 RVA: 0x000BDAB8 File Offset: 0x000BBCB8
		[CallerCount(0)]
		public unsafe static uint4x2 operator /(uint lhs, uint4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_Division_Public_Static_uint4x2_UInt32_uint4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024AA RID: 9386 RVA: 0x000BDB04 File Offset: 0x000BBD04
		[CallerCount(0)]
		public unsafe static uint4x2 operator %(uint4x2 lhs, uint4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_Modulus_Public_Static_uint4x2_uint4x2_uint4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024AB RID: 9387 RVA: 0x000BDB50 File Offset: 0x000BBD50
		[CallerCount(0)]
		public unsafe static uint4x2 operator %(uint4x2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_Modulus_Public_Static_uint4x2_uint4x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024AC RID: 9388 RVA: 0x000BDB9C File Offset: 0x000BBD9C
		[CallerCount(0)]
		public unsafe static uint4x2 operator %(uint lhs, uint4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_Modulus_Public_Static_uint4x2_UInt32_uint4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024AD RID: 9389 RVA: 0x000BDBE8 File Offset: 0x000BBDE8
		[CallerCount(0)]
		public unsafe static uint4x2 operator ++(uint4x2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_Increment_Public_Static_uint4x2_uint4x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060024AE RID: 9390 RVA: 0x000BDC28 File Offset: 0x000BBE28
		[CallerCount(0)]
		public unsafe static uint4x2 operator --(uint4x2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_Decrement_Public_Static_uint4x2_uint4x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060024AF RID: 9391 RVA: 0x000BDC68 File Offset: 0x000BBE68
		[CallerCount(0)]
		public unsafe static bool4x2 operator <(uint4x2 lhs, uint4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x2_uint4x2_uint4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024B0 RID: 9392 RVA: 0x000BDCB4 File Offset: 0x000BBEB4
		[CallerCount(0)]
		public unsafe static bool4x2 operator <(uint4x2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x2_uint4x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024B1 RID: 9393 RVA: 0x000BDD00 File Offset: 0x000BBF00
		[CallerCount(0)]
		public unsafe static bool4x2 operator <(uint lhs, uint4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x2_UInt32_uint4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024B2 RID: 9394 RVA: 0x000BDD4C File Offset: 0x000BBF4C
		[CallerCount(0)]
		public unsafe static bool4x2 operator <=(uint4x2 lhs, uint4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x2_uint4x2_uint4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024B3 RID: 9395 RVA: 0x000BDD98 File Offset: 0x000BBF98
		[CallerCount(0)]
		public unsafe static bool4x2 operator <=(uint4x2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x2_uint4x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024B4 RID: 9396 RVA: 0x000BDDE4 File Offset: 0x000BBFE4
		[CallerCount(0)]
		public unsafe static bool4x2 operator <=(uint lhs, uint4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x2_UInt32_uint4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024B5 RID: 9397 RVA: 0x000BDE30 File Offset: 0x000BC030
		[CallerCount(0)]
		public unsafe static bool4x2 operator >(uint4x2 lhs, uint4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x2_uint4x2_uint4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024B6 RID: 9398 RVA: 0x000BDE7C File Offset: 0x000BC07C
		[CallerCount(0)]
		public unsafe static bool4x2 operator >(uint4x2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x2_uint4x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024B7 RID: 9399 RVA: 0x000BDEC8 File Offset: 0x000BC0C8
		[CallerCount(0)]
		public unsafe static bool4x2 operator >(uint lhs, uint4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x2_UInt32_uint4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024B8 RID: 9400 RVA: 0x000BDF14 File Offset: 0x000BC114
		[CallerCount(0)]
		public unsafe static bool4x2 operator >=(uint4x2 lhs, uint4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x2_uint4x2_uint4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024B9 RID: 9401 RVA: 0x000BDF60 File Offset: 0x000BC160
		[CallerCount(0)]
		public unsafe static bool4x2 operator >=(uint4x2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x2_uint4x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024BA RID: 9402 RVA: 0x000BDFAC File Offset: 0x000BC1AC
		[CallerCount(0)]
		public unsafe static bool4x2 operator >=(uint lhs, uint4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x2_UInt32_uint4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024BB RID: 9403 RVA: 0x000BDFF8 File Offset: 0x000BC1F8
		[CallerCount(0)]
		public unsafe static uint4x2 operator -(uint4x2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_uint4x2_uint4x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060024BC RID: 9404 RVA: 0x000BE038 File Offset: 0x000BC238
		[CallerCount(0)]
		public unsafe static uint4x2 operator +(uint4x2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_uint4x2_uint4x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060024BD RID: 9405 RVA: 0x000BE078 File Offset: 0x000BC278
		[CallerCount(0)]
		public unsafe static uint4x2 operator <<(uint4x2 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_LeftShift_Public_Static_uint4x2_uint4x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024BE RID: 9406 RVA: 0x000BE0C4 File Offset: 0x000BC2C4
		[CallerCount(0)]
		public unsafe static uint4x2 operator >>(uint4x2 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_RightShift_Public_Static_uint4x2_uint4x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024BF RID: 9407 RVA: 0x000BE110 File Offset: 0x000BC310
		[CallerCount(0)]
		public unsafe static bool4x2 operator ==(uint4x2 lhs, uint4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x2_uint4x2_uint4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024C0 RID: 9408 RVA: 0x000BE15C File Offset: 0x000BC35C
		[CallerCount(0)]
		public unsafe static bool4x2 operator ==(uint4x2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x2_uint4x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024C1 RID: 9409 RVA: 0x000BE1A8 File Offset: 0x000BC3A8
		[CallerCount(0)]
		public unsafe static bool4x2 operator ==(uint lhs, uint4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x2_UInt32_uint4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024C2 RID: 9410 RVA: 0x000BE1F4 File Offset: 0x000BC3F4
		[CallerCount(0)]
		public unsafe static bool4x2 operator !=(uint4x2 lhs, uint4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x2_uint4x2_uint4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024C3 RID: 9411 RVA: 0x000BE240 File Offset: 0x000BC440
		[CallerCount(0)]
		public unsafe static bool4x2 operator !=(uint4x2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x2_uint4x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024C4 RID: 9412 RVA: 0x000BE28C File Offset: 0x000BC48C
		[CallerCount(0)]
		public unsafe static bool4x2 operator !=(uint lhs, uint4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x2_UInt32_uint4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024C5 RID: 9413 RVA: 0x000BE2D8 File Offset: 0x000BC4D8
		[CallerCount(0)]
		public unsafe static uint4x2 operator ~(uint4x2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_OnesComplement_Public_Static_uint4x2_uint4x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060024C6 RID: 9414 RVA: 0x000BE318 File Offset: 0x000BC518
		[CallerCount(0)]
		public unsafe static uint4x2 operator &(uint4x2 lhs, uint4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint4x2_uint4x2_uint4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024C7 RID: 9415 RVA: 0x000BE364 File Offset: 0x000BC564
		[CallerCount(0)]
		public unsafe static uint4x2 operator &(uint4x2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint4x2_uint4x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024C8 RID: 9416 RVA: 0x000BE3B0 File Offset: 0x000BC5B0
		[CallerCount(0)]
		public unsafe static uint4x2 operator &(uint lhs, uint4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint4x2_UInt32_uint4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024C9 RID: 9417 RVA: 0x000BE3FC File Offset: 0x000BC5FC
		[CallerCount(0)]
		public unsafe static uint4x2 operator |(uint4x2 lhs, uint4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint4x2_uint4x2_uint4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024CA RID: 9418 RVA: 0x000BE448 File Offset: 0x000BC648
		[CallerCount(0)]
		public unsafe static uint4x2 operator |(uint4x2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint4x2_uint4x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024CB RID: 9419 RVA: 0x000BE494 File Offset: 0x000BC694
		[CallerCount(0)]
		public unsafe static uint4x2 operator |(uint lhs, uint4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint4x2_UInt32_uint4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024CC RID: 9420 RVA: 0x000BE4E0 File Offset: 0x000BC6E0
		[CallerCount(0)]
		public unsafe static uint4x2 operator ^(uint4x2 lhs, uint4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint4x2_uint4x2_uint4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024CD RID: 9421 RVA: 0x000BE52C File Offset: 0x000BC72C
		[CallerCount(0)]
		public unsafe static uint4x2 operator ^(uint4x2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint4x2_uint4x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024CE RID: 9422 RVA: 0x000BE578 File Offset: 0x000BC778
		[CallerCount(0)]
		public unsafe static uint4x2 operator ^(uint lhs, uint4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint4x2_UInt32_uint4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000BDC RID: 3036
		public unsafe ref uint4 this[int index]
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_get_Item_Public_get_byref_uint4_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x060024D0 RID: 9424 RVA: 0x000BE5F8 File Offset: 0x000BC7F8
		[CallerCount(0)]
		public unsafe bool Equals(uint4x2 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_uint4x2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060024D1 RID: 9425 RVA: 0x000BE638 File Offset: 0x000BC838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642303, XrefRangeEnd = 642306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060024D2 RID: 9426 RVA: 0x000BE67C File Offset: 0x000BC87C
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024D3 RID: 9427 RVA: 0x000BE6AC File Offset: 0x000BC8AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642306, XrefRangeEnd = 642345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060024D4 RID: 9428 RVA: 0x000BE6D8 File Offset: 0x000BC8D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642345, XrefRangeEnd = 642393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x2.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060024D5 RID: 9429 RVA: 0x00002A49 File Offset: 0x00000C49
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<uint4x2>.NativeClassPtr, ref this));
		}

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x060024D6 RID: 9430 RVA: 0x000BE728 File Offset: 0x000BC928
		// (set) Token: 0x060024D7 RID: 9431 RVA: 0x00002A5B File Offset: 0x00000C5B
		public unsafe static uint4x2 zero
		{
			get
			{
				uint4x2 uint4x;
				IL2CPP.il2cpp_field_static_get_value(uint4x2.NativeFieldInfoPtr_zero, (void*)(&uint4x));
				return uint4x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(uint4x2.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x0400251B RID: 9499
		private static readonly IntPtr NativeFieldInfoPtr_c0;

		// Token: 0x0400251C RID: 9500
		private static readonly IntPtr NativeFieldInfoPtr_c1;

		// Token: 0x0400251D RID: 9501
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x0400251E RID: 9502
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint4_uint4_0;

		// Token: 0x0400251F RID: 9503
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_0;

		// Token: 0x04002520 RID: 9504
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04002521 RID: 9505
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04002522 RID: 9506
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool4x2_0;

		// Token: 0x04002523 RID: 9507
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04002524 RID: 9508
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int4x2_0;

		// Token: 0x04002525 RID: 9509
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x04002526 RID: 9510
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float4x2_0;

		// Token: 0x04002527 RID: 9511
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x04002528 RID: 9512
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double4x2_0;

		// Token: 0x04002529 RID: 9513
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_uint4x2_UInt32_0;

		// Token: 0x0400252A RID: 9514
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x2_Boolean_0;

		// Token: 0x0400252B RID: 9515
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x2_bool4x2_0;

		// Token: 0x0400252C RID: 9516
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x2_Int32_0;

		// Token: 0x0400252D RID: 9517
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x2_int4x2_0;

		// Token: 0x0400252E RID: 9518
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x2_Single_0;

		// Token: 0x0400252F RID: 9519
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x2_float4x2_0;

		// Token: 0x04002530 RID: 9520
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x2_Double_0;

		// Token: 0x04002531 RID: 9521
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x2_double4x2_0;

		// Token: 0x04002532 RID: 9522
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_uint4x2_uint4x2_uint4x2_0;

		// Token: 0x04002533 RID: 9523
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_uint4x2_uint4x2_UInt32_0;

		// Token: 0x04002534 RID: 9524
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_uint4x2_UInt32_uint4x2_0;

		// Token: 0x04002535 RID: 9525
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_uint4x2_uint4x2_uint4x2_0;

		// Token: 0x04002536 RID: 9526
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_uint4x2_uint4x2_UInt32_0;

		// Token: 0x04002537 RID: 9527
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_uint4x2_UInt32_uint4x2_0;

		// Token: 0x04002538 RID: 9528
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_uint4x2_uint4x2_uint4x2_0;

		// Token: 0x04002539 RID: 9529
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_uint4x2_uint4x2_UInt32_0;

		// Token: 0x0400253A RID: 9530
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_uint4x2_UInt32_uint4x2_0;

		// Token: 0x0400253B RID: 9531
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_uint4x2_uint4x2_uint4x2_0;

		// Token: 0x0400253C RID: 9532
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_uint4x2_uint4x2_UInt32_0;

		// Token: 0x0400253D RID: 9533
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_uint4x2_UInt32_uint4x2_0;

		// Token: 0x0400253E RID: 9534
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_uint4x2_uint4x2_uint4x2_0;

		// Token: 0x0400253F RID: 9535
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_uint4x2_uint4x2_UInt32_0;

		// Token: 0x04002540 RID: 9536
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_uint4x2_UInt32_uint4x2_0;

		// Token: 0x04002541 RID: 9537
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_uint4x2_uint4x2_0;

		// Token: 0x04002542 RID: 9538
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_uint4x2_uint4x2_0;

		// Token: 0x04002543 RID: 9539
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x2_uint4x2_uint4x2_0;

		// Token: 0x04002544 RID: 9540
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x2_uint4x2_UInt32_0;

		// Token: 0x04002545 RID: 9541
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x2_UInt32_uint4x2_0;

		// Token: 0x04002546 RID: 9542
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x2_uint4x2_uint4x2_0;

		// Token: 0x04002547 RID: 9543
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x2_uint4x2_UInt32_0;

		// Token: 0x04002548 RID: 9544
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x2_UInt32_uint4x2_0;

		// Token: 0x04002549 RID: 9545
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x2_uint4x2_uint4x2_0;

		// Token: 0x0400254A RID: 9546
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x2_uint4x2_UInt32_0;

		// Token: 0x0400254B RID: 9547
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x2_UInt32_uint4x2_0;

		// Token: 0x0400254C RID: 9548
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x2_uint4x2_uint4x2_0;

		// Token: 0x0400254D RID: 9549
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x2_uint4x2_UInt32_0;

		// Token: 0x0400254E RID: 9550
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x2_UInt32_uint4x2_0;

		// Token: 0x0400254F RID: 9551
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_uint4x2_uint4x2_0;

		// Token: 0x04002550 RID: 9552
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryPlus_Public_Static_uint4x2_uint4x2_0;

		// Token: 0x04002551 RID: 9553
		private static readonly IntPtr NativeMethodInfoPtr_op_LeftShift_Public_Static_uint4x2_uint4x2_Int32_0;

		// Token: 0x04002552 RID: 9554
		private static readonly IntPtr NativeMethodInfoPtr_op_RightShift_Public_Static_uint4x2_uint4x2_Int32_0;

		// Token: 0x04002553 RID: 9555
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4x2_uint4x2_uint4x2_0;

		// Token: 0x04002554 RID: 9556
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4x2_uint4x2_UInt32_0;

		// Token: 0x04002555 RID: 9557
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4x2_UInt32_uint4x2_0;

		// Token: 0x04002556 RID: 9558
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x2_uint4x2_uint4x2_0;

		// Token: 0x04002557 RID: 9559
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x2_uint4x2_UInt32_0;

		// Token: 0x04002558 RID: 9560
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x2_UInt32_uint4x2_0;

		// Token: 0x04002559 RID: 9561
		private static readonly IntPtr NativeMethodInfoPtr_op_OnesComplement_Public_Static_uint4x2_uint4x2_0;

		// Token: 0x0400255A RID: 9562
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint4x2_uint4x2_uint4x2_0;

		// Token: 0x0400255B RID: 9563
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint4x2_uint4x2_UInt32_0;

		// Token: 0x0400255C RID: 9564
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint4x2_UInt32_uint4x2_0;

		// Token: 0x0400255D RID: 9565
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint4x2_uint4x2_uint4x2_0;

		// Token: 0x0400255E RID: 9566
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint4x2_uint4x2_UInt32_0;

		// Token: 0x0400255F RID: 9567
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint4x2_UInt32_uint4x2_0;

		// Token: 0x04002560 RID: 9568
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint4x2_uint4x2_uint4x2_0;

		// Token: 0x04002561 RID: 9569
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint4x2_uint4x2_UInt32_0;

		// Token: 0x04002562 RID: 9570
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint4x2_UInt32_uint4x2_0;

		// Token: 0x04002563 RID: 9571
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_uint4_Int32_0;

		// Token: 0x04002564 RID: 9572
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_uint4x2_0;

		// Token: 0x04002565 RID: 9573
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002566 RID: 9574
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002567 RID: 9575
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002568 RID: 9576
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04002569 RID: 9577
		[FieldOffset(0)]
		public uint4 c0;

		// Token: 0x0400256A RID: 9578
		[FieldOffset(16)]
		public uint4 c1;
	}
}
