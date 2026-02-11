using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x02000040 RID: 64
	[Serializable]
	[StructLayout(2)]
	public struct uint2x2
	{
		// Token: 0x06001FF6 RID: 8182 RVA: 0x000A636C File Offset: 0x000A456C
		// Note: this type is marked as 'beforefieldinit'.
		static uint2x2()
		{
			Il2CppClassPointerStore<uint2x2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "uint2x2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<uint2x2>.NativeClassPtr);
			uint2x2.NativeFieldInfoPtr_c0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, "c0");
			uint2x2.NativeFieldInfoPtr_c1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, "c1");
			uint2x2.NativeFieldInfoPtr_identity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, "identity");
			uint2x2.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, "zero");
			uint2x2.NativeMethodInfoPtr__ctor_Public_Void_uint2_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671234);
			uint2x2.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671235);
			uint2x2.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671236);
			uint2x2.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671237);
			uint2x2.NativeMethodInfoPtr__ctor_Public_Void_bool2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671238);
			uint2x2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671239);
			uint2x2.NativeMethodInfoPtr__ctor_Public_Void_int2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671240);
			uint2x2.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671241);
			uint2x2.NativeMethodInfoPtr__ctor_Public_Void_float2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671242);
			uint2x2.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671243);
			uint2x2.NativeMethodInfoPtr__ctor_Public_Void_double2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671244);
			uint2x2.NativeMethodInfoPtr_op_Implicit_Public_Static_uint2x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671245);
			uint2x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671246);
			uint2x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x2_bool2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671247);
			uint2x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671248);
			uint2x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x2_int2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671249);
			uint2x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671250);
			uint2x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x2_float2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671251);
			uint2x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x2_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671252);
			uint2x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x2_double2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671253);
			uint2x2.NativeMethodInfoPtr_op_Multiply_Public_Static_uint2x2_uint2x2_uint2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671254);
			uint2x2.NativeMethodInfoPtr_op_Multiply_Public_Static_uint2x2_uint2x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671255);
			uint2x2.NativeMethodInfoPtr_op_Multiply_Public_Static_uint2x2_UInt32_uint2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671256);
			uint2x2.NativeMethodInfoPtr_op_Addition_Public_Static_uint2x2_uint2x2_uint2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671257);
			uint2x2.NativeMethodInfoPtr_op_Addition_Public_Static_uint2x2_uint2x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671258);
			uint2x2.NativeMethodInfoPtr_op_Addition_Public_Static_uint2x2_UInt32_uint2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671259);
			uint2x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint2x2_uint2x2_uint2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671260);
			uint2x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint2x2_uint2x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671261);
			uint2x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint2x2_UInt32_uint2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671262);
			uint2x2.NativeMethodInfoPtr_op_Division_Public_Static_uint2x2_uint2x2_uint2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671263);
			uint2x2.NativeMethodInfoPtr_op_Division_Public_Static_uint2x2_uint2x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671264);
			uint2x2.NativeMethodInfoPtr_op_Division_Public_Static_uint2x2_UInt32_uint2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671265);
			uint2x2.NativeMethodInfoPtr_op_Modulus_Public_Static_uint2x2_uint2x2_uint2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671266);
			uint2x2.NativeMethodInfoPtr_op_Modulus_Public_Static_uint2x2_uint2x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671267);
			uint2x2.NativeMethodInfoPtr_op_Modulus_Public_Static_uint2x2_UInt32_uint2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671268);
			uint2x2.NativeMethodInfoPtr_op_Increment_Public_Static_uint2x2_uint2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671269);
			uint2x2.NativeMethodInfoPtr_op_Decrement_Public_Static_uint2x2_uint2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671270);
			uint2x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x2_uint2x2_uint2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671271);
			uint2x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x2_uint2x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671272);
			uint2x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x2_UInt32_uint2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671273);
			uint2x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x2_uint2x2_uint2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671274);
			uint2x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x2_uint2x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671275);
			uint2x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x2_UInt32_uint2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671276);
			uint2x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x2_uint2x2_uint2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671277);
			uint2x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x2_uint2x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671278);
			uint2x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x2_UInt32_uint2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671279);
			uint2x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x2_uint2x2_uint2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671280);
			uint2x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x2_uint2x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671281);
			uint2x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x2_UInt32_uint2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671282);
			uint2x2.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_uint2x2_uint2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671283);
			uint2x2.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_uint2x2_uint2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671284);
			uint2x2.NativeMethodInfoPtr_op_LeftShift_Public_Static_uint2x2_uint2x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671285);
			uint2x2.NativeMethodInfoPtr_op_RightShift_Public_Static_uint2x2_uint2x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671286);
			uint2x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_uint2x2_uint2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671287);
			uint2x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_uint2x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671288);
			uint2x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_UInt32_uint2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671289);
			uint2x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_uint2x2_uint2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671290);
			uint2x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_uint2x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671291);
			uint2x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_UInt32_uint2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671292);
			uint2x2.NativeMethodInfoPtr_op_OnesComplement_Public_Static_uint2x2_uint2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671293);
			uint2x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint2x2_uint2x2_uint2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671294);
			uint2x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint2x2_uint2x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671295);
			uint2x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint2x2_UInt32_uint2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671296);
			uint2x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint2x2_uint2x2_uint2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671297);
			uint2x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint2x2_uint2x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671298);
			uint2x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint2x2_UInt32_uint2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671299);
			uint2x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint2x2_uint2x2_uint2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671300);
			uint2x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint2x2_uint2x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671301);
			uint2x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint2x2_UInt32_uint2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671302);
			uint2x2.NativeMethodInfoPtr_get_Item_Public_get_byref_uint2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671303);
			uint2x2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_uint2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671304);
			uint2x2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671305);
			uint2x2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671306);
			uint2x2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671307);
			uint2x2.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, 100671308);
		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x000A69C8 File Offset: 0x000A4BC8
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 636721, RefRangeEnd = 636742, XrefRangeStart = 636721, XrefRangeEnd = 636742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint2x2(uint2 c0, uint2 c1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr__ctor_Public_Void_uint2_uint2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FF8 RID: 8184 RVA: 0x000A6A08 File Offset: 0x000A4C08
		[CallerCount(0)]
		public unsafe uint2x2(uint m00, uint m01, uint m10, uint m11)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FF9 RID: 8185 RVA: 0x000A6A64 File Offset: 0x000A4C64
		[CallerCount(0)]
		public unsafe uint2x2(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FFA RID: 8186 RVA: 0x000A6A98 File Offset: 0x000A4C98
		[CallerCount(0)]
		public unsafe uint2x2(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FFB RID: 8187 RVA: 0x000A6ACC File Offset: 0x000A4CCC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 639159, RefRangeEnd = 639161, XrefRangeStart = 639159, XrefRangeEnd = 639161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint2x2(bool2x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr__ctor_Public_Void_bool2x2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FFC RID: 8188 RVA: 0x000A6B00 File Offset: 0x000A4D00
		[CallerCount(0)]
		public unsafe uint2x2(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FFD RID: 8189 RVA: 0x000A6B34 File Offset: 0x000A4D34
		[CallerCount(0)]
		public unsafe uint2x2(int2x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr__ctor_Public_Void_int2x2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FFE RID: 8190 RVA: 0x000A6B68 File Offset: 0x000A4D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641456, XrefRangeEnd = 641459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint2x2(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FFF RID: 8191 RVA: 0x000A6B9C File Offset: 0x000A4D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641459, XrefRangeEnd = 641462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint2x2(float2x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr__ctor_Public_Void_float2x2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002000 RID: 8192 RVA: 0x000A6BD0 File Offset: 0x000A4DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641462, XrefRangeEnd = 641465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint2x2(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002001 RID: 8193 RVA: 0x000A6C04 File Offset: 0x000A4E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641465, XrefRangeEnd = 641468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint2x2(double2x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr__ctor_Public_Void_double2x2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002002 RID: 8194 RVA: 0x000A6C38 File Offset: 0x000A4E38
		[CallerCount(0)]
		public unsafe static implicit operator uint2x2(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_Implicit_Public_Static_uint2x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002003 RID: 8195 RVA: 0x000A6C78 File Offset: 0x000A4E78
		[CallerCount(0)]
		public unsafe static explicit operator uint2x2(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x2_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002004 RID: 8196 RVA: 0x000A6CB8 File Offset: 0x000A4EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint2x2(bool2x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x2_bool2x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002005 RID: 8197 RVA: 0x000A6CF8 File Offset: 0x000A4EF8
		[CallerCount(0)]
		public unsafe static explicit operator uint2x2(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x2_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002006 RID: 8198 RVA: 0x000A6D38 File Offset: 0x000A4F38
		[CallerCount(0)]
		public unsafe static explicit operator uint2x2(int2x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x2_int2x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002007 RID: 8199 RVA: 0x000A6D78 File Offset: 0x000A4F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint2x2(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x2_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002008 RID: 8200 RVA: 0x000A6DB8 File Offset: 0x000A4FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint2x2(float2x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x2_float2x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002009 RID: 8201 RVA: 0x000A6DF8 File Offset: 0x000A4FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint2x2(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x2_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600200A RID: 8202 RVA: 0x000A6E38 File Offset: 0x000A5038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint2x2(double2x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x2_double2x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600200B RID: 8203 RVA: 0x000A6E78 File Offset: 0x000A5078
		[CallerCount(0)]
		public unsafe static uint2x2 operator *(uint2x2 lhs, uint2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_Multiply_Public_Static_uint2x2_uint2x2_uint2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600200C RID: 8204 RVA: 0x000A6EC4 File Offset: 0x000A50C4
		[CallerCount(0)]
		public unsafe static uint2x2 operator *(uint2x2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_Multiply_Public_Static_uint2x2_uint2x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600200D RID: 8205 RVA: 0x000A6F10 File Offset: 0x000A5110
		[CallerCount(0)]
		public unsafe static uint2x2 operator *(uint lhs, uint2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_Multiply_Public_Static_uint2x2_UInt32_uint2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600200E RID: 8206 RVA: 0x000A6F5C File Offset: 0x000A515C
		[CallerCount(0)]
		public unsafe static uint2x2 operator +(uint2x2 lhs, uint2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_Addition_Public_Static_uint2x2_uint2x2_uint2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600200F RID: 8207 RVA: 0x000A6FA8 File Offset: 0x000A51A8
		[CallerCount(0)]
		public unsafe static uint2x2 operator +(uint2x2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_Addition_Public_Static_uint2x2_uint2x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002010 RID: 8208 RVA: 0x000A6FF4 File Offset: 0x000A51F4
		[CallerCount(0)]
		public unsafe static uint2x2 operator +(uint lhs, uint2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_Addition_Public_Static_uint2x2_UInt32_uint2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002011 RID: 8209 RVA: 0x000A7040 File Offset: 0x000A5240
		[CallerCount(0)]
		public unsafe static uint2x2 operator -(uint2x2 lhs, uint2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint2x2_uint2x2_uint2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002012 RID: 8210 RVA: 0x000A708C File Offset: 0x000A528C
		[CallerCount(0)]
		public unsafe static uint2x2 operator -(uint2x2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint2x2_uint2x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002013 RID: 8211 RVA: 0x000A70D8 File Offset: 0x000A52D8
		[CallerCount(0)]
		public unsafe static uint2x2 operator -(uint lhs, uint2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint2x2_UInt32_uint2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002014 RID: 8212 RVA: 0x000A7124 File Offset: 0x000A5324
		[CallerCount(0)]
		public unsafe static uint2x2 operator /(uint2x2 lhs, uint2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_Division_Public_Static_uint2x2_uint2x2_uint2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002015 RID: 8213 RVA: 0x000A7170 File Offset: 0x000A5370
		[CallerCount(0)]
		public unsafe static uint2x2 operator /(uint2x2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_Division_Public_Static_uint2x2_uint2x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002016 RID: 8214 RVA: 0x000A71BC File Offset: 0x000A53BC
		[CallerCount(0)]
		public unsafe static uint2x2 operator /(uint lhs, uint2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_Division_Public_Static_uint2x2_UInt32_uint2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002017 RID: 8215 RVA: 0x000A7208 File Offset: 0x000A5408
		[CallerCount(0)]
		public unsafe static uint2x2 operator %(uint2x2 lhs, uint2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_Modulus_Public_Static_uint2x2_uint2x2_uint2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002018 RID: 8216 RVA: 0x000A7254 File Offset: 0x000A5454
		[CallerCount(0)]
		public unsafe static uint2x2 operator %(uint2x2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_Modulus_Public_Static_uint2x2_uint2x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002019 RID: 8217 RVA: 0x000A72A0 File Offset: 0x000A54A0
		[CallerCount(0)]
		public unsafe static uint2x2 operator %(uint lhs, uint2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_Modulus_Public_Static_uint2x2_UInt32_uint2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600201A RID: 8218 RVA: 0x000A72EC File Offset: 0x000A54EC
		[CallerCount(0)]
		public unsafe static uint2x2 operator ++(uint2x2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_Increment_Public_Static_uint2x2_uint2x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600201B RID: 8219 RVA: 0x000A732C File Offset: 0x000A552C
		[CallerCount(0)]
		public unsafe static uint2x2 operator --(uint2x2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_Decrement_Public_Static_uint2x2_uint2x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600201C RID: 8220 RVA: 0x000A736C File Offset: 0x000A556C
		[CallerCount(0)]
		public unsafe static bool2x2 operator <(uint2x2 lhs, uint2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x2_uint2x2_uint2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600201D RID: 8221 RVA: 0x000A73B8 File Offset: 0x000A55B8
		[CallerCount(0)]
		public unsafe static bool2x2 operator <(uint2x2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x2_uint2x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600201E RID: 8222 RVA: 0x000A7404 File Offset: 0x000A5604
		[CallerCount(0)]
		public unsafe static bool2x2 operator <(uint lhs, uint2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x2_UInt32_uint2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600201F RID: 8223 RVA: 0x000A7450 File Offset: 0x000A5650
		[CallerCount(0)]
		public unsafe static bool2x2 operator <=(uint2x2 lhs, uint2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x2_uint2x2_uint2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002020 RID: 8224 RVA: 0x000A749C File Offset: 0x000A569C
		[CallerCount(0)]
		public unsafe static bool2x2 operator <=(uint2x2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x2_uint2x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002021 RID: 8225 RVA: 0x000A74E8 File Offset: 0x000A56E8
		[CallerCount(0)]
		public unsafe static bool2x2 operator <=(uint lhs, uint2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x2_UInt32_uint2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002022 RID: 8226 RVA: 0x000A7534 File Offset: 0x000A5734
		[CallerCount(0)]
		public unsafe static bool2x2 operator >(uint2x2 lhs, uint2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x2_uint2x2_uint2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002023 RID: 8227 RVA: 0x000A7580 File Offset: 0x000A5780
		[CallerCount(0)]
		public unsafe static bool2x2 operator >(uint2x2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x2_uint2x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002024 RID: 8228 RVA: 0x000A75CC File Offset: 0x000A57CC
		[CallerCount(0)]
		public unsafe static bool2x2 operator >(uint lhs, uint2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x2_UInt32_uint2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002025 RID: 8229 RVA: 0x000A7618 File Offset: 0x000A5818
		[CallerCount(0)]
		public unsafe static bool2x2 operator >=(uint2x2 lhs, uint2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x2_uint2x2_uint2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002026 RID: 8230 RVA: 0x000A7664 File Offset: 0x000A5864
		[CallerCount(0)]
		public unsafe static bool2x2 operator >=(uint2x2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x2_uint2x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002027 RID: 8231 RVA: 0x000A76B0 File Offset: 0x000A58B0
		[CallerCount(0)]
		public unsafe static bool2x2 operator >=(uint lhs, uint2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x2_UInt32_uint2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002028 RID: 8232 RVA: 0x000A76FC File Offset: 0x000A58FC
		[CallerCount(0)]
		public unsafe static uint2x2 operator -(uint2x2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_uint2x2_uint2x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002029 RID: 8233 RVA: 0x000A773C File Offset: 0x000A593C
		[CallerCount(0)]
		public unsafe static uint2x2 operator +(uint2x2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_uint2x2_uint2x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600202A RID: 8234 RVA: 0x000A777C File Offset: 0x000A597C
		[CallerCount(0)]
		public unsafe static uint2x2 operator <<(uint2x2 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_LeftShift_Public_Static_uint2x2_uint2x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600202B RID: 8235 RVA: 0x000A77C8 File Offset: 0x000A59C8
		[CallerCount(0)]
		public unsafe static uint2x2 operator >>(uint2x2 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_RightShift_Public_Static_uint2x2_uint2x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600202C RID: 8236 RVA: 0x000A7814 File Offset: 0x000A5A14
		[CallerCount(0)]
		public unsafe static bool2x2 operator ==(uint2x2 lhs, uint2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_uint2x2_uint2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600202D RID: 8237 RVA: 0x000A7860 File Offset: 0x000A5A60
		[CallerCount(0)]
		public unsafe static bool2x2 operator ==(uint2x2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_uint2x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600202E RID: 8238 RVA: 0x000A78AC File Offset: 0x000A5AAC
		[CallerCount(0)]
		public unsafe static bool2x2 operator ==(uint lhs, uint2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_UInt32_uint2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600202F RID: 8239 RVA: 0x000A78F8 File Offset: 0x000A5AF8
		[CallerCount(0)]
		public unsafe static bool2x2 operator !=(uint2x2 lhs, uint2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_uint2x2_uint2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002030 RID: 8240 RVA: 0x000A7944 File Offset: 0x000A5B44
		[CallerCount(0)]
		public unsafe static bool2x2 operator !=(uint2x2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_uint2x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002031 RID: 8241 RVA: 0x000A7990 File Offset: 0x000A5B90
		[CallerCount(0)]
		public unsafe static bool2x2 operator !=(uint lhs, uint2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_UInt32_uint2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002032 RID: 8242 RVA: 0x000A79DC File Offset: 0x000A5BDC
		[CallerCount(0)]
		public unsafe static uint2x2 operator ~(uint2x2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_OnesComplement_Public_Static_uint2x2_uint2x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002033 RID: 8243 RVA: 0x000A7A1C File Offset: 0x000A5C1C
		[CallerCount(0)]
		public unsafe static uint2x2 operator &(uint2x2 lhs, uint2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint2x2_uint2x2_uint2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002034 RID: 8244 RVA: 0x000A7A68 File Offset: 0x000A5C68
		[CallerCount(0)]
		public unsafe static uint2x2 operator &(uint2x2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint2x2_uint2x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002035 RID: 8245 RVA: 0x000A7AB4 File Offset: 0x000A5CB4
		[CallerCount(0)]
		public unsafe static uint2x2 operator &(uint lhs, uint2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint2x2_UInt32_uint2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002036 RID: 8246 RVA: 0x000A7B00 File Offset: 0x000A5D00
		[CallerCount(0)]
		public unsafe static uint2x2 operator |(uint2x2 lhs, uint2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint2x2_uint2x2_uint2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002037 RID: 8247 RVA: 0x000A7B4C File Offset: 0x000A5D4C
		[CallerCount(0)]
		public unsafe static uint2x2 operator |(uint2x2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint2x2_uint2x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002038 RID: 8248 RVA: 0x000A7B98 File Offset: 0x000A5D98
		[CallerCount(0)]
		public unsafe static uint2x2 operator |(uint lhs, uint2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint2x2_UInt32_uint2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002039 RID: 8249 RVA: 0x000A7BE4 File Offset: 0x000A5DE4
		[CallerCount(0)]
		public unsafe static uint2x2 operator ^(uint2x2 lhs, uint2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint2x2_uint2x2_uint2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600203A RID: 8250 RVA: 0x000A7C30 File Offset: 0x000A5E30
		[CallerCount(0)]
		public unsafe static uint2x2 operator ^(uint2x2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint2x2_uint2x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600203B RID: 8251 RVA: 0x000A7C7C File Offset: 0x000A5E7C
		[CallerCount(0)]
		public unsafe static uint2x2 operator ^(uint lhs, uint2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint2x2_UInt32_uint2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000A06 RID: 2566
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_get_Item_Public_get_byref_uint2_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x000A7CFC File Offset: 0x000A5EFC
		[CallerCount(0)]
		public unsafe bool Equals(uint2x2 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_uint2x2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600203E RID: 8254 RVA: 0x000A7D3C File Offset: 0x000A5F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641468, XrefRangeEnd = 641471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600203F RID: 8255 RVA: 0x000A7D80 File Offset: 0x000A5F80
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002040 RID: 8256 RVA: 0x000A7DB0 File Offset: 0x000A5FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641471, XrefRangeEnd = 641494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002041 RID: 8257 RVA: 0x000A7DDC File Offset: 0x000A5FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641494, XrefRangeEnd = 641522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x2.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002042 RID: 8258 RVA: 0x0000292D File Offset: 0x00000B2D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<uint2x2>.NativeClassPtr, ref this));
		}

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x06002043 RID: 8259 RVA: 0x000A7E2C File Offset: 0x000A602C
		// (set) Token: 0x06002044 RID: 8260 RVA: 0x0000293F File Offset: 0x00000B3F
		public unsafe static uint2x2 identity
		{
			get
			{
				uint2x2 uint2x;
				IL2CPP.il2cpp_field_static_get_value(uint2x2.NativeFieldInfoPtr_identity, (void*)(&uint2x));
				return uint2x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(uint2x2.NativeFieldInfoPtr_identity, (void*)(&value));
			}
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x06002045 RID: 8261 RVA: 0x000A7E48 File Offset: 0x000A6048
		// (set) Token: 0x06002046 RID: 8262 RVA: 0x0000294D File Offset: 0x00000B4D
		public unsafe static uint2x2 zero
		{
			get
			{
				uint2x2 uint2x;
				IL2CPP.il2cpp_field_static_get_value(uint2x2.NativeFieldInfoPtr_zero, (void*)(&uint2x));
				return uint2x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(uint2x2.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x04002070 RID: 8304
		private static readonly IntPtr NativeFieldInfoPtr_c0;

		// Token: 0x04002071 RID: 8305
		private static readonly IntPtr NativeFieldInfoPtr_c1;

		// Token: 0x04002072 RID: 8306
		private static readonly IntPtr NativeFieldInfoPtr_identity;

		// Token: 0x04002073 RID: 8307
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x04002074 RID: 8308
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint2_uint2_0;

		// Token: 0x04002075 RID: 8309
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_0;

		// Token: 0x04002076 RID: 8310
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04002077 RID: 8311
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04002078 RID: 8312
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool2x2_0;

		// Token: 0x04002079 RID: 8313
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400207A RID: 8314
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int2x2_0;

		// Token: 0x0400207B RID: 8315
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x0400207C RID: 8316
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float2x2_0;

		// Token: 0x0400207D RID: 8317
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x0400207E RID: 8318
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double2x2_0;

		// Token: 0x0400207F RID: 8319
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_uint2x2_UInt32_0;

		// Token: 0x04002080 RID: 8320
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x2_Boolean_0;

		// Token: 0x04002081 RID: 8321
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x2_bool2x2_0;

		// Token: 0x04002082 RID: 8322
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x2_Int32_0;

		// Token: 0x04002083 RID: 8323
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x2_int2x2_0;

		// Token: 0x04002084 RID: 8324
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x2_Single_0;

		// Token: 0x04002085 RID: 8325
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x2_float2x2_0;

		// Token: 0x04002086 RID: 8326
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x2_Double_0;

		// Token: 0x04002087 RID: 8327
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x2_double2x2_0;

		// Token: 0x04002088 RID: 8328
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_uint2x2_uint2x2_uint2x2_0;

		// Token: 0x04002089 RID: 8329
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_uint2x2_uint2x2_UInt32_0;

		// Token: 0x0400208A RID: 8330
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_uint2x2_UInt32_uint2x2_0;

		// Token: 0x0400208B RID: 8331
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_uint2x2_uint2x2_uint2x2_0;

		// Token: 0x0400208C RID: 8332
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_uint2x2_uint2x2_UInt32_0;

		// Token: 0x0400208D RID: 8333
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_uint2x2_UInt32_uint2x2_0;

		// Token: 0x0400208E RID: 8334
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_uint2x2_uint2x2_uint2x2_0;

		// Token: 0x0400208F RID: 8335
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_uint2x2_uint2x2_UInt32_0;

		// Token: 0x04002090 RID: 8336
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_uint2x2_UInt32_uint2x2_0;

		// Token: 0x04002091 RID: 8337
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_uint2x2_uint2x2_uint2x2_0;

		// Token: 0x04002092 RID: 8338
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_uint2x2_uint2x2_UInt32_0;

		// Token: 0x04002093 RID: 8339
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_uint2x2_UInt32_uint2x2_0;

		// Token: 0x04002094 RID: 8340
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_uint2x2_uint2x2_uint2x2_0;

		// Token: 0x04002095 RID: 8341
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_uint2x2_uint2x2_UInt32_0;

		// Token: 0x04002096 RID: 8342
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_uint2x2_UInt32_uint2x2_0;

		// Token: 0x04002097 RID: 8343
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_uint2x2_uint2x2_0;

		// Token: 0x04002098 RID: 8344
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_uint2x2_uint2x2_0;

		// Token: 0x04002099 RID: 8345
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x2_uint2x2_uint2x2_0;

		// Token: 0x0400209A RID: 8346
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x2_uint2x2_UInt32_0;

		// Token: 0x0400209B RID: 8347
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x2_UInt32_uint2x2_0;

		// Token: 0x0400209C RID: 8348
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x2_uint2x2_uint2x2_0;

		// Token: 0x0400209D RID: 8349
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x2_uint2x2_UInt32_0;

		// Token: 0x0400209E RID: 8350
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x2_UInt32_uint2x2_0;

		// Token: 0x0400209F RID: 8351
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x2_uint2x2_uint2x2_0;

		// Token: 0x040020A0 RID: 8352
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x2_uint2x2_UInt32_0;

		// Token: 0x040020A1 RID: 8353
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x2_UInt32_uint2x2_0;

		// Token: 0x040020A2 RID: 8354
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x2_uint2x2_uint2x2_0;

		// Token: 0x040020A3 RID: 8355
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x2_uint2x2_UInt32_0;

		// Token: 0x040020A4 RID: 8356
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x2_UInt32_uint2x2_0;

		// Token: 0x040020A5 RID: 8357
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_uint2x2_uint2x2_0;

		// Token: 0x040020A6 RID: 8358
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryPlus_Public_Static_uint2x2_uint2x2_0;

		// Token: 0x040020A7 RID: 8359
		private static readonly IntPtr NativeMethodInfoPtr_op_LeftShift_Public_Static_uint2x2_uint2x2_Int32_0;

		// Token: 0x040020A8 RID: 8360
		private static readonly IntPtr NativeMethodInfoPtr_op_RightShift_Public_Static_uint2x2_uint2x2_Int32_0;

		// Token: 0x040020A9 RID: 8361
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_uint2x2_uint2x2_0;

		// Token: 0x040020AA RID: 8362
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_uint2x2_UInt32_0;

		// Token: 0x040020AB RID: 8363
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_UInt32_uint2x2_0;

		// Token: 0x040020AC RID: 8364
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_uint2x2_uint2x2_0;

		// Token: 0x040020AD RID: 8365
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_uint2x2_UInt32_0;

		// Token: 0x040020AE RID: 8366
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_UInt32_uint2x2_0;

		// Token: 0x040020AF RID: 8367
		private static readonly IntPtr NativeMethodInfoPtr_op_OnesComplement_Public_Static_uint2x2_uint2x2_0;

		// Token: 0x040020B0 RID: 8368
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint2x2_uint2x2_uint2x2_0;

		// Token: 0x040020B1 RID: 8369
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint2x2_uint2x2_UInt32_0;

		// Token: 0x040020B2 RID: 8370
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint2x2_UInt32_uint2x2_0;

		// Token: 0x040020B3 RID: 8371
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint2x2_uint2x2_uint2x2_0;

		// Token: 0x040020B4 RID: 8372
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint2x2_uint2x2_UInt32_0;

		// Token: 0x040020B5 RID: 8373
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint2x2_UInt32_uint2x2_0;

		// Token: 0x040020B6 RID: 8374
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint2x2_uint2x2_uint2x2_0;

		// Token: 0x040020B7 RID: 8375
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint2x2_uint2x2_UInt32_0;

		// Token: 0x040020B8 RID: 8376
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint2x2_UInt32_uint2x2_0;

		// Token: 0x040020B9 RID: 8377
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_uint2_Int32_0;

		// Token: 0x040020BA RID: 8378
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_uint2x2_0;

		// Token: 0x040020BB RID: 8379
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040020BC RID: 8380
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040020BD RID: 8381
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040020BE RID: 8382
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x040020BF RID: 8383
		[FieldOffset(0)]
		public uint2 c0;

		// Token: 0x040020C0 RID: 8384
		[FieldOffset(8)]
		public uint2 c1;
	}
}
