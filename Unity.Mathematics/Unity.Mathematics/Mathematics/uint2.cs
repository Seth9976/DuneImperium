using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x0200003F RID: 63
	[Serializable]
	[StructLayout(2)]
	public struct uint2
	{
		// Token: 0x06001F88 RID: 8072 RVA: 0x000A406C File Offset: 0x000A226C
		// Note: this type is marked as 'beforefieldinit'.
		static uint2()
		{
			Il2CppClassPointerStore<uint2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "uint2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<uint2>.NativeClassPtr);
			uint2.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint2>.NativeClassPtr, "x");
			uint2.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint2>.NativeClassPtr, "y");
			uint2.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint2>.NativeClassPtr, "zero");
			uint2.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671127);
			uint2.NativeMethodInfoPtr__ctor_Public_Void_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671128);
			uint2.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671129);
			uint2.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671130);
			uint2.NativeMethodInfoPtr__ctor_Public_Void_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671131);
			uint2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671132);
			uint2.NativeMethodInfoPtr__ctor_Public_Void_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671133);
			uint2.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671134);
			uint2.NativeMethodInfoPtr__ctor_Public_Void_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671135);
			uint2.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671136);
			uint2.NativeMethodInfoPtr__ctor_Public_Void_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671137);
			uint2.NativeMethodInfoPtr_op_Implicit_Public_Static_uint2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671138);
			uint2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671139);
			uint2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671140);
			uint2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671141);
			uint2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671142);
			uint2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671143);
			uint2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671144);
			uint2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671145);
			uint2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671146);
			uint2.NativeMethodInfoPtr_op_Multiply_Public_Static_uint2_uint2_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671147);
			uint2.NativeMethodInfoPtr_op_Multiply_Public_Static_uint2_uint2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671148);
			uint2.NativeMethodInfoPtr_op_Multiply_Public_Static_uint2_UInt32_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671149);
			uint2.NativeMethodInfoPtr_op_Addition_Public_Static_uint2_uint2_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671150);
			uint2.NativeMethodInfoPtr_op_Addition_Public_Static_uint2_uint2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671151);
			uint2.NativeMethodInfoPtr_op_Addition_Public_Static_uint2_UInt32_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671152);
			uint2.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint2_uint2_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671153);
			uint2.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint2_uint2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671154);
			uint2.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint2_UInt32_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671155);
			uint2.NativeMethodInfoPtr_op_Division_Public_Static_uint2_uint2_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671156);
			uint2.NativeMethodInfoPtr_op_Division_Public_Static_uint2_uint2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671157);
			uint2.NativeMethodInfoPtr_op_Division_Public_Static_uint2_UInt32_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671158);
			uint2.NativeMethodInfoPtr_op_Modulus_Public_Static_uint2_uint2_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671159);
			uint2.NativeMethodInfoPtr_op_Modulus_Public_Static_uint2_uint2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671160);
			uint2.NativeMethodInfoPtr_op_Modulus_Public_Static_uint2_UInt32_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671161);
			uint2.NativeMethodInfoPtr_op_Increment_Public_Static_uint2_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671162);
			uint2.NativeMethodInfoPtr_op_Decrement_Public_Static_uint2_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671163);
			uint2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2_uint2_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671164);
			uint2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2_uint2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671165);
			uint2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2_UInt32_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671166);
			uint2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2_uint2_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671167);
			uint2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2_uint2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671168);
			uint2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2_UInt32_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671169);
			uint2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2_uint2_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671170);
			uint2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2_uint2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671171);
			uint2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2_UInt32_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671172);
			uint2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2_uint2_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671173);
			uint2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2_uint2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671174);
			uint2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2_UInt32_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671175);
			uint2.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_uint2_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671176);
			uint2.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_uint2_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671177);
			uint2.NativeMethodInfoPtr_op_LeftShift_Public_Static_uint2_uint2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671178);
			uint2.NativeMethodInfoPtr_op_RightShift_Public_Static_uint2_uint2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671179);
			uint2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2_uint2_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671180);
			uint2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2_uint2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671181);
			uint2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2_UInt32_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671182);
			uint2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_uint2_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671183);
			uint2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_uint2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671184);
			uint2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_UInt32_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671185);
			uint2.NativeMethodInfoPtr_op_OnesComplement_Public_Static_uint2_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671186);
			uint2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint2_uint2_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671187);
			uint2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint2_uint2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671188);
			uint2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint2_UInt32_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671189);
			uint2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint2_uint2_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671190);
			uint2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint2_uint2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671191);
			uint2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint2_UInt32_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671192);
			uint2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint2_uint2_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671193);
			uint2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint2_uint2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671194);
			uint2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint2_UInt32_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671195);
			uint2.NativeMethodInfoPtr_get_xxxx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671196);
			uint2.NativeMethodInfoPtr_get_xxxy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671197);
			uint2.NativeMethodInfoPtr_get_xxyx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671198);
			uint2.NativeMethodInfoPtr_get_xxyy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671199);
			uint2.NativeMethodInfoPtr_get_xyxx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671200);
			uint2.NativeMethodInfoPtr_get_xyxy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671201);
			uint2.NativeMethodInfoPtr_get_xyyx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671202);
			uint2.NativeMethodInfoPtr_get_xyyy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671203);
			uint2.NativeMethodInfoPtr_get_yxxx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671204);
			uint2.NativeMethodInfoPtr_get_yxxy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671205);
			uint2.NativeMethodInfoPtr_get_yxyx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671206);
			uint2.NativeMethodInfoPtr_get_yxyy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671207);
			uint2.NativeMethodInfoPtr_get_yyxx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671208);
			uint2.NativeMethodInfoPtr_get_yyxy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671209);
			uint2.NativeMethodInfoPtr_get_yyyx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671210);
			uint2.NativeMethodInfoPtr_get_yyyy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671211);
			uint2.NativeMethodInfoPtr_get_xxx_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671212);
			uint2.NativeMethodInfoPtr_get_xxy_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671213);
			uint2.NativeMethodInfoPtr_get_xyx_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671214);
			uint2.NativeMethodInfoPtr_get_xyy_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671215);
			uint2.NativeMethodInfoPtr_get_yxx_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671216);
			uint2.NativeMethodInfoPtr_get_yxy_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671217);
			uint2.NativeMethodInfoPtr_get_yyx_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671218);
			uint2.NativeMethodInfoPtr_get_yyy_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671219);
			uint2.NativeMethodInfoPtr_get_xx_Public_get_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671220);
			uint2.NativeMethodInfoPtr_get_xy_Public_get_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671221);
			uint2.NativeMethodInfoPtr_set_xy_Public_set_Void_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671222);
			uint2.NativeMethodInfoPtr_get_yx_Public_get_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671223);
			uint2.NativeMethodInfoPtr_set_yx_Public_set_Void_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671224);
			uint2.NativeMethodInfoPtr_get_yy_Public_get_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671225);
			uint2.NativeMethodInfoPtr_get_Item_Public_get_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671226);
			uint2.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671227);
			uint2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671228);
			uint2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671229);
			uint2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671230);
			uint2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671231);
			uint2.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2>.NativeClassPtr, 100671232);
		}

		// Token: 0x06001F89 RID: 8073 RVA: 0x000A4920 File Offset: 0x000A2B20
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 283577, RefRangeEnd = 283616, XrefRangeStart = 283577, XrefRangeEnd = 283616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint2(uint x, uint y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F8A RID: 8074 RVA: 0x000A4960 File Offset: 0x000A2B60
		[CallerCount(0)]
		public unsafe uint2(uint2 xy)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xy;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr__ctor_Public_Void_uint2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F8B RID: 8075 RVA: 0x000A4994 File Offset: 0x000A2B94
		[CallerCount(0)]
		public unsafe uint2(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F8C RID: 8076 RVA: 0x000A49C8 File Offset: 0x000A2BC8
		[CallerCount(0)]
		public unsafe uint2(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F8D RID: 8077 RVA: 0x000A49FC File Offset: 0x000A2BFC
		[CallerCount(0)]
		public unsafe uint2(bool2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr__ctor_Public_Void_bool2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F8E RID: 8078 RVA: 0x000A4A30 File Offset: 0x000A2C30
		[CallerCount(0)]
		public unsafe uint2(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F8F RID: 8079 RVA: 0x000A4A64 File Offset: 0x000A2C64
		[CallerCount(0)]
		public unsafe uint2(int2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr__ctor_Public_Void_int2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F90 RID: 8080 RVA: 0x000A4A98 File Offset: 0x000A2C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641436, XrefRangeEnd = 641437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint2(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F91 RID: 8081 RVA: 0x000A4ACC File Offset: 0x000A2CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641437, XrefRangeEnd = 641438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint2(float2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr__ctor_Public_Void_float2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F92 RID: 8082 RVA: 0x000A4B00 File Offset: 0x000A2D00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641438, XrefRangeEnd = 641439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint2(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F93 RID: 8083 RVA: 0x000A4B34 File Offset: 0x000A2D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641439, XrefRangeEnd = 641440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint2(double2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr__ctor_Public_Void_double2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F94 RID: 8084 RVA: 0x000A4B68 File Offset: 0x000A2D68
		[CallerCount(0)]
		public unsafe static implicit operator uint2(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_Implicit_Public_Static_uint2_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F95 RID: 8085 RVA: 0x000A4BA8 File Offset: 0x000A2DA8
		[CallerCount(0)]
		public unsafe static explicit operator uint2(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F96 RID: 8086 RVA: 0x000A4BE8 File Offset: 0x000A2DE8
		[CallerCount(0)]
		public unsafe static explicit operator uint2(bool2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2_bool2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F97 RID: 8087 RVA: 0x000A4C28 File Offset: 0x000A2E28
		[CallerCount(0)]
		public unsafe static explicit operator uint2(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F98 RID: 8088 RVA: 0x000A4C68 File Offset: 0x000A2E68
		[CallerCount(0)]
		public unsafe static explicit operator uint2(int2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2_int2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F99 RID: 8089 RVA: 0x000A4CA8 File Offset: 0x000A2EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint2(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F9A RID: 8090 RVA: 0x000A4CE8 File Offset: 0x000A2EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint2(float2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2_float2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F9B RID: 8091 RVA: 0x000A4D28 File Offset: 0x000A2F28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint2(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F9C RID: 8092 RVA: 0x000A4D68 File Offset: 0x000A2F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint2(double2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2_double2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F9D RID: 8093 RVA: 0x000A4DA8 File Offset: 0x000A2FA8
		[CallerCount(0)]
		public unsafe static uint2 operator *(uint2 lhs, uint2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_Multiply_Public_Static_uint2_uint2_uint2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F9E RID: 8094 RVA: 0x000A4DF4 File Offset: 0x000A2FF4
		[CallerCount(0)]
		public unsafe static uint2 operator *(uint2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_Multiply_Public_Static_uint2_uint2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F9F RID: 8095 RVA: 0x000A4E40 File Offset: 0x000A3040
		[CallerCount(0)]
		public unsafe static uint2 operator *(uint lhs, uint2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_Multiply_Public_Static_uint2_UInt32_uint2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FA0 RID: 8096 RVA: 0x000A4E8C File Offset: 0x000A308C
		[CallerCount(0)]
		public unsafe static uint2 operator +(uint2 lhs, uint2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_Addition_Public_Static_uint2_uint2_uint2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FA1 RID: 8097 RVA: 0x000A4ED8 File Offset: 0x000A30D8
		[CallerCount(0)]
		public unsafe static uint2 operator +(uint2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_Addition_Public_Static_uint2_uint2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FA2 RID: 8098 RVA: 0x000A4F24 File Offset: 0x000A3124
		[CallerCount(0)]
		public unsafe static uint2 operator +(uint lhs, uint2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_Addition_Public_Static_uint2_UInt32_uint2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FA3 RID: 8099 RVA: 0x000A4F70 File Offset: 0x000A3170
		[CallerCount(0)]
		public unsafe static uint2 operator -(uint2 lhs, uint2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint2_uint2_uint2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FA4 RID: 8100 RVA: 0x000A4FBC File Offset: 0x000A31BC
		[CallerCount(0)]
		public unsafe static uint2 operator -(uint2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint2_uint2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FA5 RID: 8101 RVA: 0x000A5008 File Offset: 0x000A3208
		[CallerCount(0)]
		public unsafe static uint2 operator -(uint lhs, uint2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint2_UInt32_uint2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FA6 RID: 8102 RVA: 0x000A5054 File Offset: 0x000A3254
		[CallerCount(0)]
		public unsafe static uint2 operator /(uint2 lhs, uint2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_Division_Public_Static_uint2_uint2_uint2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FA7 RID: 8103 RVA: 0x000A50A0 File Offset: 0x000A32A0
		[CallerCount(0)]
		public unsafe static uint2 operator /(uint2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_Division_Public_Static_uint2_uint2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FA8 RID: 8104 RVA: 0x000A50EC File Offset: 0x000A32EC
		[CallerCount(0)]
		public unsafe static uint2 operator /(uint lhs, uint2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_Division_Public_Static_uint2_UInt32_uint2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FA9 RID: 8105 RVA: 0x000A5138 File Offset: 0x000A3338
		[CallerCount(0)]
		public unsafe static uint2 operator %(uint2 lhs, uint2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_Modulus_Public_Static_uint2_uint2_uint2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FAA RID: 8106 RVA: 0x000A5184 File Offset: 0x000A3384
		[CallerCount(0)]
		public unsafe static uint2 operator %(uint2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_Modulus_Public_Static_uint2_uint2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FAB RID: 8107 RVA: 0x000A51D0 File Offset: 0x000A33D0
		[CallerCount(0)]
		public unsafe static uint2 operator %(uint lhs, uint2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_Modulus_Public_Static_uint2_UInt32_uint2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FAC RID: 8108 RVA: 0x000A521C File Offset: 0x000A341C
		[CallerCount(0)]
		public unsafe static uint2 operator ++(uint2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_Increment_Public_Static_uint2_uint2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001FAD RID: 8109 RVA: 0x000A525C File Offset: 0x000A345C
		[CallerCount(0)]
		public unsafe static uint2 operator --(uint2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_Decrement_Public_Static_uint2_uint2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001FAE RID: 8110 RVA: 0x000A529C File Offset: 0x000A349C
		[CallerCount(0)]
		public unsafe static bool2 operator <(uint2 lhs, uint2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2_uint2_uint2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FAF RID: 8111 RVA: 0x000A52E8 File Offset: 0x000A34E8
		[CallerCount(0)]
		public unsafe static bool2 operator <(uint2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2_uint2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FB0 RID: 8112 RVA: 0x000A5334 File Offset: 0x000A3534
		[CallerCount(0)]
		public unsafe static bool2 operator <(uint lhs, uint2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2_UInt32_uint2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FB1 RID: 8113 RVA: 0x000A5380 File Offset: 0x000A3580
		[CallerCount(0)]
		public unsafe static bool2 operator <=(uint2 lhs, uint2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2_uint2_uint2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FB2 RID: 8114 RVA: 0x000A53CC File Offset: 0x000A35CC
		[CallerCount(0)]
		public unsafe static bool2 operator <=(uint2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2_uint2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FB3 RID: 8115 RVA: 0x000A5418 File Offset: 0x000A3618
		[CallerCount(0)]
		public unsafe static bool2 operator <=(uint lhs, uint2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2_UInt32_uint2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FB4 RID: 8116 RVA: 0x000A5464 File Offset: 0x000A3664
		[CallerCount(0)]
		public unsafe static bool2 operator >(uint2 lhs, uint2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2_uint2_uint2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FB5 RID: 8117 RVA: 0x000A54B0 File Offset: 0x000A36B0
		[CallerCount(0)]
		public unsafe static bool2 operator >(uint2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2_uint2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FB6 RID: 8118 RVA: 0x000A54FC File Offset: 0x000A36FC
		[CallerCount(0)]
		public unsafe static bool2 operator >(uint lhs, uint2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2_UInt32_uint2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FB7 RID: 8119 RVA: 0x000A5548 File Offset: 0x000A3748
		[CallerCount(0)]
		public unsafe static bool2 operator >=(uint2 lhs, uint2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2_uint2_uint2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FB8 RID: 8120 RVA: 0x000A5594 File Offset: 0x000A3794
		[CallerCount(0)]
		public unsafe static bool2 operator >=(uint2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2_uint2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FB9 RID: 8121 RVA: 0x000A55E0 File Offset: 0x000A37E0
		[CallerCount(0)]
		public unsafe static bool2 operator >=(uint lhs, uint2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2_UInt32_uint2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FBA RID: 8122 RVA: 0x000A562C File Offset: 0x000A382C
		[CallerCount(0)]
		public unsafe static uint2 operator -(uint2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_uint2_uint2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001FBB RID: 8123 RVA: 0x000A566C File Offset: 0x000A386C
		[CallerCount(0)]
		public unsafe static uint2 operator +(uint2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_uint2_uint2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001FBC RID: 8124 RVA: 0x000A56AC File Offset: 0x000A38AC
		[CallerCount(0)]
		public unsafe static uint2 operator <<(uint2 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_LeftShift_Public_Static_uint2_uint2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FBD RID: 8125 RVA: 0x000A56F8 File Offset: 0x000A38F8
		[CallerCount(0)]
		public unsafe static uint2 operator >>(uint2 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_RightShift_Public_Static_uint2_uint2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FBE RID: 8126 RVA: 0x000A5744 File Offset: 0x000A3944
		[CallerCount(0)]
		public unsafe static bool2 operator ==(uint2 lhs, uint2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2_uint2_uint2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FBF RID: 8127 RVA: 0x000A5790 File Offset: 0x000A3990
		[CallerCount(0)]
		public unsafe static bool2 operator ==(uint2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2_uint2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FC0 RID: 8128 RVA: 0x000A57DC File Offset: 0x000A39DC
		[CallerCount(0)]
		public unsafe static bool2 operator ==(uint lhs, uint2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2_UInt32_uint2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FC1 RID: 8129 RVA: 0x000A5828 File Offset: 0x000A3A28
		[CallerCount(0)]
		public unsafe static bool2 operator !=(uint2 lhs, uint2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_uint2_uint2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FC2 RID: 8130 RVA: 0x000A5874 File Offset: 0x000A3A74
		[CallerCount(0)]
		public unsafe static bool2 operator !=(uint2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_uint2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FC3 RID: 8131 RVA: 0x000A58C0 File Offset: 0x000A3AC0
		[CallerCount(0)]
		public unsafe static bool2 operator !=(uint lhs, uint2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_UInt32_uint2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FC4 RID: 8132 RVA: 0x000A590C File Offset: 0x000A3B0C
		[CallerCount(0)]
		public unsafe static uint2 operator ~(uint2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_OnesComplement_Public_Static_uint2_uint2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001FC5 RID: 8133 RVA: 0x000A594C File Offset: 0x000A3B4C
		[CallerCount(0)]
		public unsafe static uint2 operator &(uint2 lhs, uint2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint2_uint2_uint2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FC6 RID: 8134 RVA: 0x000A5998 File Offset: 0x000A3B98
		[CallerCount(0)]
		public unsafe static uint2 operator &(uint2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint2_uint2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FC7 RID: 8135 RVA: 0x000A59E4 File Offset: 0x000A3BE4
		[CallerCount(0)]
		public unsafe static uint2 operator &(uint lhs, uint2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint2_UInt32_uint2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FC8 RID: 8136 RVA: 0x000A5A30 File Offset: 0x000A3C30
		[CallerCount(0)]
		public unsafe static uint2 operator |(uint2 lhs, uint2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint2_uint2_uint2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FC9 RID: 8137 RVA: 0x000A5A7C File Offset: 0x000A3C7C
		[CallerCount(0)]
		public unsafe static uint2 operator |(uint2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint2_uint2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FCA RID: 8138 RVA: 0x000A5AC8 File Offset: 0x000A3CC8
		[CallerCount(0)]
		public unsafe static uint2 operator |(uint lhs, uint2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint2_UInt32_uint2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FCB RID: 8139 RVA: 0x000A5B14 File Offset: 0x000A3D14
		[CallerCount(0)]
		public unsafe static uint2 operator ^(uint2 lhs, uint2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint2_uint2_uint2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FCC RID: 8140 RVA: 0x000A5B60 File Offset: 0x000A3D60
		[CallerCount(0)]
		public unsafe static uint2 operator ^(uint2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint2_uint2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FCD RID: 8141 RVA: 0x000A5BAC File Offset: 0x000A3DAC
		[CallerCount(0)]
		public unsafe static uint2 operator ^(uint lhs, uint2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint2_UInt32_uint2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x06001FCE RID: 8142 RVA: 0x000A5BF8 File Offset: 0x000A3DF8
		public unsafe uint4 xxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_get_xxxx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x06001FCF RID: 8143 RVA: 0x000A5C28 File Offset: 0x000A3E28
		public unsafe uint4 xxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_get_xxxy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x06001FD0 RID: 8144 RVA: 0x000A5C58 File Offset: 0x000A3E58
		public unsafe uint4 xxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_get_xxyx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x06001FD1 RID: 8145 RVA: 0x000A5C88 File Offset: 0x000A3E88
		public unsafe uint4 xxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_get_xxyy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x06001FD2 RID: 8146 RVA: 0x000A5CB8 File Offset: 0x000A3EB8
		public unsafe uint4 xyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_get_xyxx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x06001FD3 RID: 8147 RVA: 0x000A5CE8 File Offset: 0x000A3EE8
		public unsafe uint4 xyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_get_xyxy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x06001FD4 RID: 8148 RVA: 0x000A5D18 File Offset: 0x000A3F18
		public unsafe uint4 xyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_get_xyyx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x06001FD5 RID: 8149 RVA: 0x000A5D48 File Offset: 0x000A3F48
		public unsafe uint4 xyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_get_xyyy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x06001FD6 RID: 8150 RVA: 0x000A5D78 File Offset: 0x000A3F78
		public unsafe uint4 yxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_get_yxxx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x06001FD7 RID: 8151 RVA: 0x000A5DA8 File Offset: 0x000A3FA8
		public unsafe uint4 yxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_get_yxxy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x06001FD8 RID: 8152 RVA: 0x000A5DD8 File Offset: 0x000A3FD8
		public unsafe uint4 yxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_get_yxyx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x06001FD9 RID: 8153 RVA: 0x000A5E08 File Offset: 0x000A4008
		public unsafe uint4 yxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_get_yxyy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x06001FDA RID: 8154 RVA: 0x000A5E38 File Offset: 0x000A4038
		public unsafe uint4 yyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_get_yyxx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x06001FDB RID: 8155 RVA: 0x000A5E68 File Offset: 0x000A4068
		public unsafe uint4 yyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_get_yyxy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x06001FDC RID: 8156 RVA: 0x000A5E98 File Offset: 0x000A4098
		public unsafe uint4 yyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_get_yyyx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x06001FDD RID: 8157 RVA: 0x000A5EC8 File Offset: 0x000A40C8
		public unsafe uint4 yyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_get_yyyy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x06001FDE RID: 8158 RVA: 0x000A5EF8 File Offset: 0x000A40F8
		public unsafe uint3 xxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_get_xxx_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x06001FDF RID: 8159 RVA: 0x000A5F28 File Offset: 0x000A4128
		public unsafe uint3 xxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_get_xxy_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x06001FE0 RID: 8160 RVA: 0x000A5F58 File Offset: 0x000A4158
		public unsafe uint3 xyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_get_xyx_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x06001FE1 RID: 8161 RVA: 0x000A5F88 File Offset: 0x000A4188
		public unsafe uint3 xyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_get_xyy_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x06001FE2 RID: 8162 RVA: 0x000A5FB8 File Offset: 0x000A41B8
		public unsafe uint3 yxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_get_yxx_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x06001FE3 RID: 8163 RVA: 0x000A5FE8 File Offset: 0x000A41E8
		public unsafe uint3 yxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_get_yxy_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x06001FE4 RID: 8164 RVA: 0x000A6018 File Offset: 0x000A4218
		public unsafe uint3 yyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_get_yyx_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x06001FE5 RID: 8165 RVA: 0x000A6048 File Offset: 0x000A4248
		public unsafe uint3 yyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_get_yyy_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x06001FE6 RID: 8166 RVA: 0x000A6078 File Offset: 0x000A4278
		public unsafe uint2 xx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_get_xx_Public_get_uint2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x06001FE7 RID: 8167 RVA: 0x000A60A8 File Offset: 0x000A42A8
		// (set) Token: 0x06001FE8 RID: 8168 RVA: 0x000A60D8 File Offset: 0x000A42D8
		public unsafe uint2 xy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_get_xy_Public_get_uint2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_set_xy_Public_set_Void_uint2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x06001FE9 RID: 8169 RVA: 0x000A610C File Offset: 0x000A430C
		// (set) Token: 0x06001FEA RID: 8170 RVA: 0x000A613C File Offset: 0x000A433C
		public unsafe uint2 yx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_get_yx_Public_get_uint2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_set_yx_Public_set_Void_uint2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x06001FEB RID: 8171 RVA: 0x000A6170 File Offset: 0x000A4370
		public unsafe uint2 yy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_get_yy_Public_get_uint2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A03 RID: 2563
		public unsafe uint this[int index]
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 639142, RefRangeEnd = 639143, XrefRangeStart = 639142, XrefRangeEnd = 639143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_get_Item_Public_get_UInt32_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
			[CallerCount(0)]
			set
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FEE RID: 8174 RVA: 0x000A6220 File Offset: 0x000A4420
		[CallerCount(0)]
		public unsafe bool Equals(uint2 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_uint2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001FEF RID: 8175 RVA: 0x000A6260 File Offset: 0x000A4460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641440, XrefRangeEnd = 641443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001FF0 RID: 8176 RVA: 0x000A62A4 File Offset: 0x000A44A4
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FF1 RID: 8177 RVA: 0x000A62D4 File Offset: 0x000A44D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641443, XrefRangeEnd = 641451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001FF2 RID: 8178 RVA: 0x000A6300 File Offset: 0x000A4500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641451, XrefRangeEnd = 641456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001FF3 RID: 8179 RVA: 0x0000290D File Offset: 0x00000B0D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<uint2>.NativeClassPtr, ref this));
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x06001FF4 RID: 8180 RVA: 0x000A6350 File Offset: 0x000A4550
		// (set) Token: 0x06001FF5 RID: 8181 RVA: 0x0000291F File Offset: 0x00000B1F
		public unsafe static uint2 zero
		{
			get
			{
				uint2 @uint;
				IL2CPP.il2cpp_field_static_get_value(uint2.NativeFieldInfoPtr_zero, (void*)(&@uint));
				return @uint;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(uint2.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x04002001 RID: 8193
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x04002002 RID: 8194
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04002003 RID: 8195
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x04002004 RID: 8196
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_0;

		// Token: 0x04002005 RID: 8197
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint2_0;

		// Token: 0x04002006 RID: 8198
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04002007 RID: 8199
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04002008 RID: 8200
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool2_0;

		// Token: 0x04002009 RID: 8201
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400200A RID: 8202
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int2_0;

		// Token: 0x0400200B RID: 8203
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x0400200C RID: 8204
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float2_0;

		// Token: 0x0400200D RID: 8205
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x0400200E RID: 8206
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double2_0;

		// Token: 0x0400200F RID: 8207
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_uint2_UInt32_0;

		// Token: 0x04002010 RID: 8208
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint2_Boolean_0;

		// Token: 0x04002011 RID: 8209
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint2_bool2_0;

		// Token: 0x04002012 RID: 8210
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint2_Int32_0;

		// Token: 0x04002013 RID: 8211
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint2_int2_0;

		// Token: 0x04002014 RID: 8212
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint2_Single_0;

		// Token: 0x04002015 RID: 8213
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint2_float2_0;

		// Token: 0x04002016 RID: 8214
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint2_Double_0;

		// Token: 0x04002017 RID: 8215
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint2_double2_0;

		// Token: 0x04002018 RID: 8216
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_uint2_uint2_uint2_0;

		// Token: 0x04002019 RID: 8217
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_uint2_uint2_UInt32_0;

		// Token: 0x0400201A RID: 8218
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_uint2_UInt32_uint2_0;

		// Token: 0x0400201B RID: 8219
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_uint2_uint2_uint2_0;

		// Token: 0x0400201C RID: 8220
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_uint2_uint2_UInt32_0;

		// Token: 0x0400201D RID: 8221
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_uint2_UInt32_uint2_0;

		// Token: 0x0400201E RID: 8222
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_uint2_uint2_uint2_0;

		// Token: 0x0400201F RID: 8223
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_uint2_uint2_UInt32_0;

		// Token: 0x04002020 RID: 8224
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_uint2_UInt32_uint2_0;

		// Token: 0x04002021 RID: 8225
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_uint2_uint2_uint2_0;

		// Token: 0x04002022 RID: 8226
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_uint2_uint2_UInt32_0;

		// Token: 0x04002023 RID: 8227
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_uint2_UInt32_uint2_0;

		// Token: 0x04002024 RID: 8228
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_uint2_uint2_uint2_0;

		// Token: 0x04002025 RID: 8229
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_uint2_uint2_UInt32_0;

		// Token: 0x04002026 RID: 8230
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_uint2_UInt32_uint2_0;

		// Token: 0x04002027 RID: 8231
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_uint2_uint2_0;

		// Token: 0x04002028 RID: 8232
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_uint2_uint2_0;

		// Token: 0x04002029 RID: 8233
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2_uint2_uint2_0;

		// Token: 0x0400202A RID: 8234
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2_uint2_UInt32_0;

		// Token: 0x0400202B RID: 8235
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2_UInt32_uint2_0;

		// Token: 0x0400202C RID: 8236
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2_uint2_uint2_0;

		// Token: 0x0400202D RID: 8237
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2_uint2_UInt32_0;

		// Token: 0x0400202E RID: 8238
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2_UInt32_uint2_0;

		// Token: 0x0400202F RID: 8239
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2_uint2_uint2_0;

		// Token: 0x04002030 RID: 8240
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2_uint2_UInt32_0;

		// Token: 0x04002031 RID: 8241
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2_UInt32_uint2_0;

		// Token: 0x04002032 RID: 8242
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2_uint2_uint2_0;

		// Token: 0x04002033 RID: 8243
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2_uint2_UInt32_0;

		// Token: 0x04002034 RID: 8244
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2_UInt32_uint2_0;

		// Token: 0x04002035 RID: 8245
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_uint2_uint2_0;

		// Token: 0x04002036 RID: 8246
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryPlus_Public_Static_uint2_uint2_0;

		// Token: 0x04002037 RID: 8247
		private static readonly IntPtr NativeMethodInfoPtr_op_LeftShift_Public_Static_uint2_uint2_Int32_0;

		// Token: 0x04002038 RID: 8248
		private static readonly IntPtr NativeMethodInfoPtr_op_RightShift_Public_Static_uint2_uint2_Int32_0;

		// Token: 0x04002039 RID: 8249
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2_uint2_uint2_0;

		// Token: 0x0400203A RID: 8250
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2_uint2_UInt32_0;

		// Token: 0x0400203B RID: 8251
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2_UInt32_uint2_0;

		// Token: 0x0400203C RID: 8252
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_uint2_uint2_0;

		// Token: 0x0400203D RID: 8253
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_uint2_UInt32_0;

		// Token: 0x0400203E RID: 8254
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_UInt32_uint2_0;

		// Token: 0x0400203F RID: 8255
		private static readonly IntPtr NativeMethodInfoPtr_op_OnesComplement_Public_Static_uint2_uint2_0;

		// Token: 0x04002040 RID: 8256
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint2_uint2_uint2_0;

		// Token: 0x04002041 RID: 8257
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint2_uint2_UInt32_0;

		// Token: 0x04002042 RID: 8258
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint2_UInt32_uint2_0;

		// Token: 0x04002043 RID: 8259
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint2_uint2_uint2_0;

		// Token: 0x04002044 RID: 8260
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint2_uint2_UInt32_0;

		// Token: 0x04002045 RID: 8261
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint2_UInt32_uint2_0;

		// Token: 0x04002046 RID: 8262
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint2_uint2_uint2_0;

		// Token: 0x04002047 RID: 8263
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint2_uint2_UInt32_0;

		// Token: 0x04002048 RID: 8264
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint2_UInt32_uint2_0;

		// Token: 0x04002049 RID: 8265
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxx_Public_get_uint4_0;

		// Token: 0x0400204A RID: 8266
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxy_Public_get_uint4_0;

		// Token: 0x0400204B RID: 8267
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyx_Public_get_uint4_0;

		// Token: 0x0400204C RID: 8268
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyy_Public_get_uint4_0;

		// Token: 0x0400204D RID: 8269
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxx_Public_get_uint4_0;

		// Token: 0x0400204E RID: 8270
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxy_Public_get_uint4_0;

		// Token: 0x0400204F RID: 8271
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyx_Public_get_uint4_0;

		// Token: 0x04002050 RID: 8272
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyy_Public_get_uint4_0;

		// Token: 0x04002051 RID: 8273
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxx_Public_get_uint4_0;

		// Token: 0x04002052 RID: 8274
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxy_Public_get_uint4_0;

		// Token: 0x04002053 RID: 8275
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyx_Public_get_uint4_0;

		// Token: 0x04002054 RID: 8276
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyy_Public_get_uint4_0;

		// Token: 0x04002055 RID: 8277
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxx_Public_get_uint4_0;

		// Token: 0x04002056 RID: 8278
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxy_Public_get_uint4_0;

		// Token: 0x04002057 RID: 8279
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyx_Public_get_uint4_0;

		// Token: 0x04002058 RID: 8280
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyy_Public_get_uint4_0;

		// Token: 0x04002059 RID: 8281
		private static readonly IntPtr NativeMethodInfoPtr_get_xxx_Public_get_uint3_0;

		// Token: 0x0400205A RID: 8282
		private static readonly IntPtr NativeMethodInfoPtr_get_xxy_Public_get_uint3_0;

		// Token: 0x0400205B RID: 8283
		private static readonly IntPtr NativeMethodInfoPtr_get_xyx_Public_get_uint3_0;

		// Token: 0x0400205C RID: 8284
		private static readonly IntPtr NativeMethodInfoPtr_get_xyy_Public_get_uint3_0;

		// Token: 0x0400205D RID: 8285
		private static readonly IntPtr NativeMethodInfoPtr_get_yxx_Public_get_uint3_0;

		// Token: 0x0400205E RID: 8286
		private static readonly IntPtr NativeMethodInfoPtr_get_yxy_Public_get_uint3_0;

		// Token: 0x0400205F RID: 8287
		private static readonly IntPtr NativeMethodInfoPtr_get_yyx_Public_get_uint3_0;

		// Token: 0x04002060 RID: 8288
		private static readonly IntPtr NativeMethodInfoPtr_get_yyy_Public_get_uint3_0;

		// Token: 0x04002061 RID: 8289
		private static readonly IntPtr NativeMethodInfoPtr_get_xx_Public_get_uint2_0;

		// Token: 0x04002062 RID: 8290
		private static readonly IntPtr NativeMethodInfoPtr_get_xy_Public_get_uint2_0;

		// Token: 0x04002063 RID: 8291
		private static readonly IntPtr NativeMethodInfoPtr_set_xy_Public_set_Void_uint2_0;

		// Token: 0x04002064 RID: 8292
		private static readonly IntPtr NativeMethodInfoPtr_get_yx_Public_get_uint2_0;

		// Token: 0x04002065 RID: 8293
		private static readonly IntPtr NativeMethodInfoPtr_set_yx_Public_set_Void_uint2_0;

		// Token: 0x04002066 RID: 8294
		private static readonly IntPtr NativeMethodInfoPtr_get_yy_Public_get_uint2_0;

		// Token: 0x04002067 RID: 8295
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_UInt32_Int32_0;

		// Token: 0x04002068 RID: 8296
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_UInt32_0;

		// Token: 0x04002069 RID: 8297
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_uint2_0;

		// Token: 0x0400206A RID: 8298
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400206B RID: 8299
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400206C RID: 8300
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400206D RID: 8301
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x0400206E RID: 8302
		[FieldOffset(0)]
		public uint x;

		// Token: 0x0400206F RID: 8303
		[FieldOffset(4)]
		public uint y;

		// Token: 0x02000063 RID: 99
		public sealed class DebuggerProxy : Object
		{
			// Token: 0x06002640 RID: 9792 RVA: 0x000C3FE0 File Offset: 0x000C21E0
			// Note: this type is marked as 'beforefieldinit'.
			static DebuggerProxy()
			{
				Il2CppClassPointerStore<uint2.DebuggerProxy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<uint2>.NativeClassPtr, "DebuggerProxy");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<uint2.DebuggerProxy>.NativeClassPtr);
				uint2.DebuggerProxy.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint2.DebuggerProxy>.NativeClassPtr, "x");
				uint2.DebuggerProxy.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint2.DebuggerProxy>.NativeClassPtr, "y");
				uint2.DebuggerProxy.NativeMethodInfoPtr__ctor_Public_Void_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2.DebuggerProxy>.NativeClassPtr, 100671233);
			}

			// Token: 0x06002641 RID: 9793 RVA: 0x000C4048 File Offset: 0x000C2248
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DebuggerProxy(uint2 v)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<uint2.DebuggerProxy>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2.DebuggerProxy.NativeMethodInfoPtr__ctor_Public_Void_uint2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002642 RID: 9794 RVA: 0x0000311D File Offset: 0x0000131D
			public DebuggerProxy(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C1E RID: 3102
			// (get) Token: 0x06002643 RID: 9795 RVA: 0x000C4090 File Offset: 0x000C2290
			// (set) Token: 0x06002644 RID: 9796 RVA: 0x00003126 File Offset: 0x00001326
			public unsafe uint x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(uint2.DebuggerProxy.NativeFieldInfoPtr_x);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(uint2.DebuggerProxy.NativeFieldInfoPtr_x)) = value;
				}
			}

			// Token: 0x17000C1F RID: 3103
			// (get) Token: 0x06002645 RID: 9797 RVA: 0x000C40B8 File Offset: 0x000C22B8
			// (set) Token: 0x06002646 RID: 9798 RVA: 0x00003141 File Offset: 0x00001341
			public unsafe uint y
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(uint2.DebuggerProxy.NativeFieldInfoPtr_y);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(uint2.DebuggerProxy.NativeFieldInfoPtr_y)) = value;
				}
			}

			// Token: 0x04002698 RID: 9880
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04002699 RID: 9881
			private static readonly IntPtr NativeFieldInfoPtr_y;

			// Token: 0x0400269A RID: 9882
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint2_0;
		}
	}
}
