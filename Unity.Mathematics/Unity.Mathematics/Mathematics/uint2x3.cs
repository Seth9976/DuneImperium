using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x02000041 RID: 65
	[Serializable]
	[StructLayout(2)]
	public struct uint2x3
	{
		// Token: 0x06002047 RID: 8263 RVA: 0x000A7E64 File Offset: 0x000A6064
		// Note: this type is marked as 'beforefieldinit'.
		static uint2x3()
		{
			Il2CppClassPointerStore<uint2x3>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "uint2x3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<uint2x3>.NativeClassPtr);
			uint2x3.NativeFieldInfoPtr_c0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, "c0");
			uint2x3.NativeFieldInfoPtr_c1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, "c1");
			uint2x3.NativeFieldInfoPtr_c2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, "c2");
			uint2x3.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, "zero");
			uint2x3.NativeMethodInfoPtr__ctor_Public_Void_uint2_uint2_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671310);
			uint2x3.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671311);
			uint2x3.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671312);
			uint2x3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671313);
			uint2x3.NativeMethodInfoPtr__ctor_Public_Void_bool2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671314);
			uint2x3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671315);
			uint2x3.NativeMethodInfoPtr__ctor_Public_Void_int2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671316);
			uint2x3.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671317);
			uint2x3.NativeMethodInfoPtr__ctor_Public_Void_float2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671318);
			uint2x3.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671319);
			uint2x3.NativeMethodInfoPtr__ctor_Public_Void_double2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671320);
			uint2x3.NativeMethodInfoPtr_op_Implicit_Public_Static_uint2x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671321);
			uint2x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671322);
			uint2x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x3_bool2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671323);
			uint2x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671324);
			uint2x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x3_int2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671325);
			uint2x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671326);
			uint2x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x3_float2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671327);
			uint2x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671328);
			uint2x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x3_double2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671329);
			uint2x3.NativeMethodInfoPtr_op_Multiply_Public_Static_uint2x3_uint2x3_uint2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671330);
			uint2x3.NativeMethodInfoPtr_op_Multiply_Public_Static_uint2x3_uint2x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671331);
			uint2x3.NativeMethodInfoPtr_op_Multiply_Public_Static_uint2x3_UInt32_uint2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671332);
			uint2x3.NativeMethodInfoPtr_op_Addition_Public_Static_uint2x3_uint2x3_uint2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671333);
			uint2x3.NativeMethodInfoPtr_op_Addition_Public_Static_uint2x3_uint2x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671334);
			uint2x3.NativeMethodInfoPtr_op_Addition_Public_Static_uint2x3_UInt32_uint2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671335);
			uint2x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint2x3_uint2x3_uint2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671336);
			uint2x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint2x3_uint2x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671337);
			uint2x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint2x3_UInt32_uint2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671338);
			uint2x3.NativeMethodInfoPtr_op_Division_Public_Static_uint2x3_uint2x3_uint2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671339);
			uint2x3.NativeMethodInfoPtr_op_Division_Public_Static_uint2x3_uint2x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671340);
			uint2x3.NativeMethodInfoPtr_op_Division_Public_Static_uint2x3_UInt32_uint2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671341);
			uint2x3.NativeMethodInfoPtr_op_Modulus_Public_Static_uint2x3_uint2x3_uint2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671342);
			uint2x3.NativeMethodInfoPtr_op_Modulus_Public_Static_uint2x3_uint2x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671343);
			uint2x3.NativeMethodInfoPtr_op_Modulus_Public_Static_uint2x3_UInt32_uint2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671344);
			uint2x3.NativeMethodInfoPtr_op_Increment_Public_Static_uint2x3_uint2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671345);
			uint2x3.NativeMethodInfoPtr_op_Decrement_Public_Static_uint2x3_uint2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671346);
			uint2x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x3_uint2x3_uint2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671347);
			uint2x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x3_uint2x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671348);
			uint2x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x3_UInt32_uint2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671349);
			uint2x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x3_uint2x3_uint2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671350);
			uint2x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x3_uint2x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671351);
			uint2x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x3_UInt32_uint2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671352);
			uint2x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x3_uint2x3_uint2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671353);
			uint2x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x3_uint2x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671354);
			uint2x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x3_UInt32_uint2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671355);
			uint2x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x3_uint2x3_uint2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671356);
			uint2x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x3_uint2x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671357);
			uint2x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x3_UInt32_uint2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671358);
			uint2x3.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_uint2x3_uint2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671359);
			uint2x3.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_uint2x3_uint2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671360);
			uint2x3.NativeMethodInfoPtr_op_LeftShift_Public_Static_uint2x3_uint2x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671361);
			uint2x3.NativeMethodInfoPtr_op_RightShift_Public_Static_uint2x3_uint2x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671362);
			uint2x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x3_uint2x3_uint2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671363);
			uint2x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x3_uint2x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671364);
			uint2x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x3_UInt32_uint2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671365);
			uint2x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x3_uint2x3_uint2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671366);
			uint2x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x3_uint2x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671367);
			uint2x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x3_UInt32_uint2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671368);
			uint2x3.NativeMethodInfoPtr_op_OnesComplement_Public_Static_uint2x3_uint2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671369);
			uint2x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint2x3_uint2x3_uint2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671370);
			uint2x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint2x3_uint2x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671371);
			uint2x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint2x3_UInt32_uint2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671372);
			uint2x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint2x3_uint2x3_uint2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671373);
			uint2x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint2x3_uint2x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671374);
			uint2x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint2x3_UInt32_uint2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671375);
			uint2x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint2x3_uint2x3_uint2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671376);
			uint2x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint2x3_uint2x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671377);
			uint2x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint2x3_UInt32_uint2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671378);
			uint2x3.NativeMethodInfoPtr_get_Item_Public_get_byref_uint2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671379);
			uint2x3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_uint2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671380);
			uint2x3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671381);
			uint2x3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671382);
			uint2x3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671383);
			uint2x3.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, 100671384);
		}

		// Token: 0x06002048 RID: 8264 RVA: 0x000A84C0 File Offset: 0x000A66C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 636842, RefRangeEnd = 636843, XrefRangeStart = 636842, XrefRangeEnd = 636843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint2x3(uint2 c0, uint2 c1, uint2 c2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr__ctor_Public_Void_uint2_uint2_uint2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002049 RID: 8265 RVA: 0x000A8510 File Offset: 0x000A6710
		[CallerCount(0)]
		public unsafe uint2x3(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref m00;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m01;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m02;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m10;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m11;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m12;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600204A RID: 8266 RVA: 0x000A8588 File Offset: 0x000A6788
		[CallerCount(0)]
		public unsafe uint2x3(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600204B RID: 8267 RVA: 0x000A85BC File Offset: 0x000A67BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 639218, RefRangeEnd = 639220, XrefRangeStart = 639218, XrefRangeEnd = 639220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint2x3(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600204C RID: 8268 RVA: 0x000A85F0 File Offset: 0x000A67F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 639220, RefRangeEnd = 639222, XrefRangeStart = 639220, XrefRangeEnd = 639222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint2x3(bool2x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr__ctor_Public_Void_bool2x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600204D RID: 8269 RVA: 0x000A8624 File Offset: 0x000A6824
		[CallerCount(0)]
		public unsafe uint2x3(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600204E RID: 8270 RVA: 0x000A8658 File Offset: 0x000A6858
		[CallerCount(0)]
		public unsafe uint2x3(int2x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr__ctor_Public_Void_int2x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600204F RID: 8271 RVA: 0x000A868C File Offset: 0x000A688C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 641527, RefRangeEnd = 641528, XrefRangeStart = 641522, XrefRangeEnd = 641527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint2x3(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002050 RID: 8272 RVA: 0x000A86C0 File Offset: 0x000A68C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 641533, RefRangeEnd = 641534, XrefRangeStart = 641528, XrefRangeEnd = 641533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint2x3(float2x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr__ctor_Public_Void_float2x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002051 RID: 8273 RVA: 0x000A86F4 File Offset: 0x000A68F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 641539, RefRangeEnd = 641540, XrefRangeStart = 641534, XrefRangeEnd = 641539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint2x3(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002052 RID: 8274 RVA: 0x000A8728 File Offset: 0x000A6928
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 641545, RefRangeEnd = 641546, XrefRangeStart = 641540, XrefRangeEnd = 641545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint2x3(double2x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr__ctor_Public_Void_double2x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002053 RID: 8275 RVA: 0x000A875C File Offset: 0x000A695C
		[CallerCount(0)]
		public unsafe static implicit operator uint2x3(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_Implicit_Public_Static_uint2x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002054 RID: 8276 RVA: 0x000A879C File Offset: 0x000A699C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint2x3(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x3_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002055 RID: 8277 RVA: 0x000A87DC File Offset: 0x000A69DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint2x3(bool2x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x3_bool2x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002056 RID: 8278 RVA: 0x000A881C File Offset: 0x000A6A1C
		[CallerCount(0)]
		public unsafe static explicit operator uint2x3(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x3_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002057 RID: 8279 RVA: 0x000A885C File Offset: 0x000A6A5C
		[CallerCount(0)]
		public unsafe static explicit operator uint2x3(int2x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x3_int2x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002058 RID: 8280 RVA: 0x000A889C File Offset: 0x000A6A9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641546, XrefRangeEnd = 641547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint2x3(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x3_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002059 RID: 8281 RVA: 0x000A88DC File Offset: 0x000A6ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641547, XrefRangeEnd = 641548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint2x3(float2x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x3_float2x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600205A RID: 8282 RVA: 0x000A891C File Offset: 0x000A6B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641548, XrefRangeEnd = 641549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint2x3(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x3_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600205B RID: 8283 RVA: 0x000A895C File Offset: 0x000A6B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641549, XrefRangeEnd = 641550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint2x3(double2x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x3_double2x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600205C RID: 8284 RVA: 0x000A899C File Offset: 0x000A6B9C
		[CallerCount(0)]
		public unsafe static uint2x3 operator *(uint2x3 lhs, uint2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_Multiply_Public_Static_uint2x3_uint2x3_uint2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600205D RID: 8285 RVA: 0x000A89E8 File Offset: 0x000A6BE8
		[CallerCount(0)]
		public unsafe static uint2x3 operator *(uint2x3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_Multiply_Public_Static_uint2x3_uint2x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600205E RID: 8286 RVA: 0x000A8A34 File Offset: 0x000A6C34
		[CallerCount(0)]
		public unsafe static uint2x3 operator *(uint lhs, uint2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_Multiply_Public_Static_uint2x3_UInt32_uint2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600205F RID: 8287 RVA: 0x000A8A80 File Offset: 0x000A6C80
		[CallerCount(0)]
		public unsafe static uint2x3 operator +(uint2x3 lhs, uint2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_Addition_Public_Static_uint2x3_uint2x3_uint2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002060 RID: 8288 RVA: 0x000A8ACC File Offset: 0x000A6CCC
		[CallerCount(0)]
		public unsafe static uint2x3 operator +(uint2x3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_Addition_Public_Static_uint2x3_uint2x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002061 RID: 8289 RVA: 0x000A8B18 File Offset: 0x000A6D18
		[CallerCount(0)]
		public unsafe static uint2x3 operator +(uint lhs, uint2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_Addition_Public_Static_uint2x3_UInt32_uint2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002062 RID: 8290 RVA: 0x000A8B64 File Offset: 0x000A6D64
		[CallerCount(0)]
		public unsafe static uint2x3 operator -(uint2x3 lhs, uint2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint2x3_uint2x3_uint2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002063 RID: 8291 RVA: 0x000A8BB0 File Offset: 0x000A6DB0
		[CallerCount(0)]
		public unsafe static uint2x3 operator -(uint2x3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint2x3_uint2x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002064 RID: 8292 RVA: 0x000A8BFC File Offset: 0x000A6DFC
		[CallerCount(0)]
		public unsafe static uint2x3 operator -(uint lhs, uint2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint2x3_UInt32_uint2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002065 RID: 8293 RVA: 0x000A8C48 File Offset: 0x000A6E48
		[CallerCount(0)]
		public unsafe static uint2x3 operator /(uint2x3 lhs, uint2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_Division_Public_Static_uint2x3_uint2x3_uint2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002066 RID: 8294 RVA: 0x000A8C94 File Offset: 0x000A6E94
		[CallerCount(0)]
		public unsafe static uint2x3 operator /(uint2x3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_Division_Public_Static_uint2x3_uint2x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x000A8CE0 File Offset: 0x000A6EE0
		[CallerCount(0)]
		public unsafe static uint2x3 operator /(uint lhs, uint2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_Division_Public_Static_uint2x3_UInt32_uint2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002068 RID: 8296 RVA: 0x000A8D2C File Offset: 0x000A6F2C
		[CallerCount(0)]
		public unsafe static uint2x3 operator %(uint2x3 lhs, uint2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_Modulus_Public_Static_uint2x3_uint2x3_uint2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002069 RID: 8297 RVA: 0x000A8D78 File Offset: 0x000A6F78
		[CallerCount(0)]
		public unsafe static uint2x3 operator %(uint2x3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_Modulus_Public_Static_uint2x3_uint2x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600206A RID: 8298 RVA: 0x000A8DC4 File Offset: 0x000A6FC4
		[CallerCount(0)]
		public unsafe static uint2x3 operator %(uint lhs, uint2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_Modulus_Public_Static_uint2x3_UInt32_uint2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600206B RID: 8299 RVA: 0x000A8E10 File Offset: 0x000A7010
		[CallerCount(0)]
		public unsafe static uint2x3 operator ++(uint2x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_Increment_Public_Static_uint2x3_uint2x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600206C RID: 8300 RVA: 0x000A8E50 File Offset: 0x000A7050
		[CallerCount(0)]
		public unsafe static uint2x3 operator --(uint2x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_Decrement_Public_Static_uint2x3_uint2x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600206D RID: 8301 RVA: 0x000A8E90 File Offset: 0x000A7090
		[CallerCount(0)]
		public unsafe static bool2x3 operator <(uint2x3 lhs, uint2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x3_uint2x3_uint2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600206E RID: 8302 RVA: 0x000A8EDC File Offset: 0x000A70DC
		[CallerCount(0)]
		public unsafe static bool2x3 operator <(uint2x3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x3_uint2x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600206F RID: 8303 RVA: 0x000A8F28 File Offset: 0x000A7128
		[CallerCount(0)]
		public unsafe static bool2x3 operator <(uint lhs, uint2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x3_UInt32_uint2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002070 RID: 8304 RVA: 0x000A8F74 File Offset: 0x000A7174
		[CallerCount(0)]
		public unsafe static bool2x3 operator <=(uint2x3 lhs, uint2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x3_uint2x3_uint2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002071 RID: 8305 RVA: 0x000A8FC0 File Offset: 0x000A71C0
		[CallerCount(0)]
		public unsafe static bool2x3 operator <=(uint2x3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x3_uint2x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002072 RID: 8306 RVA: 0x000A900C File Offset: 0x000A720C
		[CallerCount(0)]
		public unsafe static bool2x3 operator <=(uint lhs, uint2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x3_UInt32_uint2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002073 RID: 8307 RVA: 0x000A9058 File Offset: 0x000A7258
		[CallerCount(0)]
		public unsafe static bool2x3 operator >(uint2x3 lhs, uint2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x3_uint2x3_uint2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002074 RID: 8308 RVA: 0x000A90A4 File Offset: 0x000A72A4
		[CallerCount(0)]
		public unsafe static bool2x3 operator >(uint2x3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x3_uint2x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002075 RID: 8309 RVA: 0x000A90F0 File Offset: 0x000A72F0
		[CallerCount(0)]
		public unsafe static bool2x3 operator >(uint lhs, uint2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x3_UInt32_uint2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002076 RID: 8310 RVA: 0x000A913C File Offset: 0x000A733C
		[CallerCount(0)]
		public unsafe static bool2x3 operator >=(uint2x3 lhs, uint2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x3_uint2x3_uint2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002077 RID: 8311 RVA: 0x000A9188 File Offset: 0x000A7388
		[CallerCount(0)]
		public unsafe static bool2x3 operator >=(uint2x3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x3_uint2x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002078 RID: 8312 RVA: 0x000A91D4 File Offset: 0x000A73D4
		[CallerCount(0)]
		public unsafe static bool2x3 operator >=(uint lhs, uint2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x3_UInt32_uint2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002079 RID: 8313 RVA: 0x000A9220 File Offset: 0x000A7420
		[CallerCount(0)]
		public unsafe static uint2x3 operator -(uint2x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_uint2x3_uint2x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600207A RID: 8314 RVA: 0x000A9260 File Offset: 0x000A7460
		[CallerCount(0)]
		public unsafe static uint2x3 operator +(uint2x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_uint2x3_uint2x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600207B RID: 8315 RVA: 0x000A92A0 File Offset: 0x000A74A0
		[CallerCount(0)]
		public unsafe static uint2x3 operator <<(uint2x3 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_LeftShift_Public_Static_uint2x3_uint2x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600207C RID: 8316 RVA: 0x000A92EC File Offset: 0x000A74EC
		[CallerCount(0)]
		public unsafe static uint2x3 operator >>(uint2x3 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_RightShift_Public_Static_uint2x3_uint2x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600207D RID: 8317 RVA: 0x000A9338 File Offset: 0x000A7538
		[CallerCount(0)]
		public unsafe static bool2x3 operator ==(uint2x3 lhs, uint2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x3_uint2x3_uint2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600207E RID: 8318 RVA: 0x000A9384 File Offset: 0x000A7584
		[CallerCount(0)]
		public unsafe static bool2x3 operator ==(uint2x3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x3_uint2x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600207F RID: 8319 RVA: 0x000A93D0 File Offset: 0x000A75D0
		[CallerCount(0)]
		public unsafe static bool2x3 operator ==(uint lhs, uint2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x3_UInt32_uint2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002080 RID: 8320 RVA: 0x000A941C File Offset: 0x000A761C
		[CallerCount(0)]
		public unsafe static bool2x3 operator !=(uint2x3 lhs, uint2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x3_uint2x3_uint2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002081 RID: 8321 RVA: 0x000A9468 File Offset: 0x000A7668
		[CallerCount(0)]
		public unsafe static bool2x3 operator !=(uint2x3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x3_uint2x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002082 RID: 8322 RVA: 0x000A94B4 File Offset: 0x000A76B4
		[CallerCount(0)]
		public unsafe static bool2x3 operator !=(uint lhs, uint2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x3_UInt32_uint2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002083 RID: 8323 RVA: 0x000A9500 File Offset: 0x000A7700
		[CallerCount(0)]
		public unsafe static uint2x3 operator ~(uint2x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_OnesComplement_Public_Static_uint2x3_uint2x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002084 RID: 8324 RVA: 0x000A9540 File Offset: 0x000A7740
		[CallerCount(0)]
		public unsafe static uint2x3 operator &(uint2x3 lhs, uint2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint2x3_uint2x3_uint2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002085 RID: 8325 RVA: 0x000A958C File Offset: 0x000A778C
		[CallerCount(0)]
		public unsafe static uint2x3 operator &(uint2x3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint2x3_uint2x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002086 RID: 8326 RVA: 0x000A95D8 File Offset: 0x000A77D8
		[CallerCount(0)]
		public unsafe static uint2x3 operator &(uint lhs, uint2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint2x3_UInt32_uint2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002087 RID: 8327 RVA: 0x000A9624 File Offset: 0x000A7824
		[CallerCount(0)]
		public unsafe static uint2x3 operator |(uint2x3 lhs, uint2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint2x3_uint2x3_uint2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002088 RID: 8328 RVA: 0x000A9670 File Offset: 0x000A7870
		[CallerCount(0)]
		public unsafe static uint2x3 operator |(uint2x3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint2x3_uint2x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002089 RID: 8329 RVA: 0x000A96BC File Offset: 0x000A78BC
		[CallerCount(0)]
		public unsafe static uint2x3 operator |(uint lhs, uint2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint2x3_UInt32_uint2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600208A RID: 8330 RVA: 0x000A9708 File Offset: 0x000A7908
		[CallerCount(0)]
		public unsafe static uint2x3 operator ^(uint2x3 lhs, uint2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint2x3_uint2x3_uint2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600208B RID: 8331 RVA: 0x000A9754 File Offset: 0x000A7954
		[CallerCount(0)]
		public unsafe static uint2x3 operator ^(uint2x3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint2x3_uint2x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600208C RID: 8332 RVA: 0x000A97A0 File Offset: 0x000A79A0
		[CallerCount(0)]
		public unsafe static uint2x3 operator ^(uint lhs, uint2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint2x3_UInt32_uint2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000A08 RID: 2568
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_get_Item_Public_get_byref_uint2_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x0600208E RID: 8334 RVA: 0x000A9820 File Offset: 0x000A7A20
		[CallerCount(0)]
		public unsafe bool Equals(uint2x3 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_uint2x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600208F RID: 8335 RVA: 0x000A9860 File Offset: 0x000A7A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641550, XrefRangeEnd = 641553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002090 RID: 8336 RVA: 0x000A98A4 File Offset: 0x000A7AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641553, XrefRangeEnd = 641554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002091 RID: 8337 RVA: 0x000A98D4 File Offset: 0x000A7AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641554, XrefRangeEnd = 641585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002092 RID: 8338 RVA: 0x000A9900 File Offset: 0x000A7B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641585, XrefRangeEnd = 641623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x3.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002093 RID: 8339 RVA: 0x0000295B File Offset: 0x00000B5B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<uint2x3>.NativeClassPtr, ref this));
		}

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x06002094 RID: 8340 RVA: 0x000A9950 File Offset: 0x000A7B50
		// (set) Token: 0x06002095 RID: 8341 RVA: 0x0000296D File Offset: 0x00000B6D
		public unsafe static uint2x3 zero
		{
			get
			{
				uint2x3 uint2x;
				IL2CPP.il2cpp_field_static_get_value(uint2x3.NativeFieldInfoPtr_zero, (void*)(&uint2x));
				return uint2x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(uint2x3.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x040020C1 RID: 8385
		private static readonly IntPtr NativeFieldInfoPtr_c0;

		// Token: 0x040020C2 RID: 8386
		private static readonly IntPtr NativeFieldInfoPtr_c1;

		// Token: 0x040020C3 RID: 8387
		private static readonly IntPtr NativeFieldInfoPtr_c2;

		// Token: 0x040020C4 RID: 8388
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x040020C5 RID: 8389
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint2_uint2_uint2_0;

		// Token: 0x040020C6 RID: 8390
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_0;

		// Token: 0x040020C7 RID: 8391
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x040020C8 RID: 8392
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x040020C9 RID: 8393
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool2x3_0;

		// Token: 0x040020CA RID: 8394
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040020CB RID: 8395
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int2x3_0;

		// Token: 0x040020CC RID: 8396
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x040020CD RID: 8397
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float2x3_0;

		// Token: 0x040020CE RID: 8398
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x040020CF RID: 8399
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double2x3_0;

		// Token: 0x040020D0 RID: 8400
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_uint2x3_UInt32_0;

		// Token: 0x040020D1 RID: 8401
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x3_Boolean_0;

		// Token: 0x040020D2 RID: 8402
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x3_bool2x3_0;

		// Token: 0x040020D3 RID: 8403
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x3_Int32_0;

		// Token: 0x040020D4 RID: 8404
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x3_int2x3_0;

		// Token: 0x040020D5 RID: 8405
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x3_Single_0;

		// Token: 0x040020D6 RID: 8406
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x3_float2x3_0;

		// Token: 0x040020D7 RID: 8407
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x3_Double_0;

		// Token: 0x040020D8 RID: 8408
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x3_double2x3_0;

		// Token: 0x040020D9 RID: 8409
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_uint2x3_uint2x3_uint2x3_0;

		// Token: 0x040020DA RID: 8410
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_uint2x3_uint2x3_UInt32_0;

		// Token: 0x040020DB RID: 8411
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_uint2x3_UInt32_uint2x3_0;

		// Token: 0x040020DC RID: 8412
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_uint2x3_uint2x3_uint2x3_0;

		// Token: 0x040020DD RID: 8413
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_uint2x3_uint2x3_UInt32_0;

		// Token: 0x040020DE RID: 8414
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_uint2x3_UInt32_uint2x3_0;

		// Token: 0x040020DF RID: 8415
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_uint2x3_uint2x3_uint2x3_0;

		// Token: 0x040020E0 RID: 8416
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_uint2x3_uint2x3_UInt32_0;

		// Token: 0x040020E1 RID: 8417
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_uint2x3_UInt32_uint2x3_0;

		// Token: 0x040020E2 RID: 8418
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_uint2x3_uint2x3_uint2x3_0;

		// Token: 0x040020E3 RID: 8419
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_uint2x3_uint2x3_UInt32_0;

		// Token: 0x040020E4 RID: 8420
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_uint2x3_UInt32_uint2x3_0;

		// Token: 0x040020E5 RID: 8421
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_uint2x3_uint2x3_uint2x3_0;

		// Token: 0x040020E6 RID: 8422
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_uint2x3_uint2x3_UInt32_0;

		// Token: 0x040020E7 RID: 8423
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_uint2x3_UInt32_uint2x3_0;

		// Token: 0x040020E8 RID: 8424
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_uint2x3_uint2x3_0;

		// Token: 0x040020E9 RID: 8425
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_uint2x3_uint2x3_0;

		// Token: 0x040020EA RID: 8426
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x3_uint2x3_uint2x3_0;

		// Token: 0x040020EB RID: 8427
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x3_uint2x3_UInt32_0;

		// Token: 0x040020EC RID: 8428
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x3_UInt32_uint2x3_0;

		// Token: 0x040020ED RID: 8429
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x3_uint2x3_uint2x3_0;

		// Token: 0x040020EE RID: 8430
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x3_uint2x3_UInt32_0;

		// Token: 0x040020EF RID: 8431
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x3_UInt32_uint2x3_0;

		// Token: 0x040020F0 RID: 8432
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x3_uint2x3_uint2x3_0;

		// Token: 0x040020F1 RID: 8433
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x3_uint2x3_UInt32_0;

		// Token: 0x040020F2 RID: 8434
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x3_UInt32_uint2x3_0;

		// Token: 0x040020F3 RID: 8435
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x3_uint2x3_uint2x3_0;

		// Token: 0x040020F4 RID: 8436
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x3_uint2x3_UInt32_0;

		// Token: 0x040020F5 RID: 8437
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x3_UInt32_uint2x3_0;

		// Token: 0x040020F6 RID: 8438
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_uint2x3_uint2x3_0;

		// Token: 0x040020F7 RID: 8439
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryPlus_Public_Static_uint2x3_uint2x3_0;

		// Token: 0x040020F8 RID: 8440
		private static readonly IntPtr NativeMethodInfoPtr_op_LeftShift_Public_Static_uint2x3_uint2x3_Int32_0;

		// Token: 0x040020F9 RID: 8441
		private static readonly IntPtr NativeMethodInfoPtr_op_RightShift_Public_Static_uint2x3_uint2x3_Int32_0;

		// Token: 0x040020FA RID: 8442
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2x3_uint2x3_uint2x3_0;

		// Token: 0x040020FB RID: 8443
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2x3_uint2x3_UInt32_0;

		// Token: 0x040020FC RID: 8444
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2x3_UInt32_uint2x3_0;

		// Token: 0x040020FD RID: 8445
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x3_uint2x3_uint2x3_0;

		// Token: 0x040020FE RID: 8446
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x3_uint2x3_UInt32_0;

		// Token: 0x040020FF RID: 8447
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x3_UInt32_uint2x3_0;

		// Token: 0x04002100 RID: 8448
		private static readonly IntPtr NativeMethodInfoPtr_op_OnesComplement_Public_Static_uint2x3_uint2x3_0;

		// Token: 0x04002101 RID: 8449
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint2x3_uint2x3_uint2x3_0;

		// Token: 0x04002102 RID: 8450
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint2x3_uint2x3_UInt32_0;

		// Token: 0x04002103 RID: 8451
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint2x3_UInt32_uint2x3_0;

		// Token: 0x04002104 RID: 8452
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint2x3_uint2x3_uint2x3_0;

		// Token: 0x04002105 RID: 8453
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint2x3_uint2x3_UInt32_0;

		// Token: 0x04002106 RID: 8454
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint2x3_UInt32_uint2x3_0;

		// Token: 0x04002107 RID: 8455
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint2x3_uint2x3_uint2x3_0;

		// Token: 0x04002108 RID: 8456
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint2x3_uint2x3_UInt32_0;

		// Token: 0x04002109 RID: 8457
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint2x3_UInt32_uint2x3_0;

		// Token: 0x0400210A RID: 8458
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_uint2_Int32_0;

		// Token: 0x0400210B RID: 8459
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_uint2x3_0;

		// Token: 0x0400210C RID: 8460
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400210D RID: 8461
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400210E RID: 8462
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400210F RID: 8463
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04002110 RID: 8464
		[FieldOffset(0)]
		public uint2 c0;

		// Token: 0x04002111 RID: 8465
		[FieldOffset(8)]
		public uint2 c1;

		// Token: 0x04002112 RID: 8466
		[FieldOffset(16)]
		public uint2 c2;
	}
}
