using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x02000046 RID: 70
	[Serializable]
	[StructLayout(2)]
	public struct uint3x4
	{
		// Token: 0x06002258 RID: 8792 RVA: 0x000B2938 File Offset: 0x000B0B38
		// Note: this type is marked as 'beforefieldinit'.
		static uint3x4()
		{
			Il2CppClassPointerStore<uint3x4>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "uint3x4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<uint3x4>.NativeClassPtr);
			uint3x4.NativeFieldInfoPtr_c0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, "c0");
			uint3x4.NativeFieldInfoPtr_c1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, "c1");
			uint3x4.NativeFieldInfoPtr_c2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, "c2");
			uint3x4.NativeFieldInfoPtr_c3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, "c3");
			uint3x4.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, "zero");
			uint3x4.NativeMethodInfoPtr__ctor_Public_Void_uint3_uint3_uint3_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671819);
			uint3x4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671820);
			uint3x4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671821);
			uint3x4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671822);
			uint3x4.NativeMethodInfoPtr__ctor_Public_Void_bool3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671823);
			uint3x4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671824);
			uint3x4.NativeMethodInfoPtr__ctor_Public_Void_int3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671825);
			uint3x4.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671826);
			uint3x4.NativeMethodInfoPtr__ctor_Public_Void_float3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671827);
			uint3x4.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671828);
			uint3x4.NativeMethodInfoPtr__ctor_Public_Void_double3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671829);
			uint3x4.NativeMethodInfoPtr_op_Implicit_Public_Static_uint3x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671830);
			uint3x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671831);
			uint3x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x4_bool3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671832);
			uint3x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671833);
			uint3x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x4_int3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671834);
			uint3x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671835);
			uint3x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x4_float3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671836);
			uint3x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671837);
			uint3x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x4_double3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671838);
			uint3x4.NativeMethodInfoPtr_op_Multiply_Public_Static_uint3x4_uint3x4_uint3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671839);
			uint3x4.NativeMethodInfoPtr_op_Multiply_Public_Static_uint3x4_uint3x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671840);
			uint3x4.NativeMethodInfoPtr_op_Multiply_Public_Static_uint3x4_UInt32_uint3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671841);
			uint3x4.NativeMethodInfoPtr_op_Addition_Public_Static_uint3x4_uint3x4_uint3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671842);
			uint3x4.NativeMethodInfoPtr_op_Addition_Public_Static_uint3x4_uint3x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671843);
			uint3x4.NativeMethodInfoPtr_op_Addition_Public_Static_uint3x4_UInt32_uint3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671844);
			uint3x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint3x4_uint3x4_uint3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671845);
			uint3x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint3x4_uint3x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671846);
			uint3x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint3x4_UInt32_uint3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671847);
			uint3x4.NativeMethodInfoPtr_op_Division_Public_Static_uint3x4_uint3x4_uint3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671848);
			uint3x4.NativeMethodInfoPtr_op_Division_Public_Static_uint3x4_uint3x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671849);
			uint3x4.NativeMethodInfoPtr_op_Division_Public_Static_uint3x4_UInt32_uint3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671850);
			uint3x4.NativeMethodInfoPtr_op_Modulus_Public_Static_uint3x4_uint3x4_uint3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671851);
			uint3x4.NativeMethodInfoPtr_op_Modulus_Public_Static_uint3x4_uint3x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671852);
			uint3x4.NativeMethodInfoPtr_op_Modulus_Public_Static_uint3x4_UInt32_uint3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671853);
			uint3x4.NativeMethodInfoPtr_op_Increment_Public_Static_uint3x4_uint3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671854);
			uint3x4.NativeMethodInfoPtr_op_Decrement_Public_Static_uint3x4_uint3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671855);
			uint3x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x4_uint3x4_uint3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671856);
			uint3x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x4_uint3x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671857);
			uint3x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x4_UInt32_uint3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671858);
			uint3x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x4_uint3x4_uint3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671859);
			uint3x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x4_uint3x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671860);
			uint3x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x4_UInt32_uint3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671861);
			uint3x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x4_uint3x4_uint3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671862);
			uint3x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x4_uint3x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671863);
			uint3x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x4_UInt32_uint3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671864);
			uint3x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x4_uint3x4_uint3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671865);
			uint3x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x4_uint3x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671866);
			uint3x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x4_UInt32_uint3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671867);
			uint3x4.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_uint3x4_uint3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671868);
			uint3x4.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_uint3x4_uint3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671869);
			uint3x4.NativeMethodInfoPtr_op_LeftShift_Public_Static_uint3x4_uint3x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671870);
			uint3x4.NativeMethodInfoPtr_op_RightShift_Public_Static_uint3x4_uint3x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671871);
			uint3x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x4_uint3x4_uint3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671872);
			uint3x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x4_uint3x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671873);
			uint3x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x4_UInt32_uint3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671874);
			uint3x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x4_uint3x4_uint3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671875);
			uint3x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x4_uint3x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671876);
			uint3x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x4_UInt32_uint3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671877);
			uint3x4.NativeMethodInfoPtr_op_OnesComplement_Public_Static_uint3x4_uint3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671878);
			uint3x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint3x4_uint3x4_uint3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671879);
			uint3x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint3x4_uint3x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671880);
			uint3x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint3x4_UInt32_uint3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671881);
			uint3x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint3x4_uint3x4_uint3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671882);
			uint3x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint3x4_uint3x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671883);
			uint3x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint3x4_UInt32_uint3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671884);
			uint3x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint3x4_uint3x4_uint3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671885);
			uint3x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint3x4_uint3x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671886);
			uint3x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint3x4_UInt32_uint3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671887);
			uint3x4.NativeMethodInfoPtr_get_Item_Public_get_byref_uint3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671888);
			uint3x4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_uint3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671889);
			uint3x4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671890);
			uint3x4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671891);
			uint3x4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671892);
			uint3x4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, 100671893);
		}

		// Token: 0x06002259 RID: 8793 RVA: 0x000B2FA8 File Offset: 0x000B11A8
		[CallerCount(0)]
		public unsafe uint3x4(uint3 c0, uint3 c1, uint3 c2, uint3 c3)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr__ctor_Public_Void_uint3_uint3_uint3_uint3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600225A RID: 8794 RVA: 0x000B3004 File Offset: 0x000B1204
		[CallerCount(0)]
		public unsafe uint3x4(uint m00, uint m01, uint m02, uint m03, uint m10, uint m11, uint m12, uint m13, uint m20, uint m21, uint m22, uint m23)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600225B RID: 8795 RVA: 0x000B30D4 File Offset: 0x000B12D4
		[CallerCount(0)]
		public unsafe uint3x4(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600225C RID: 8796 RVA: 0x000B3108 File Offset: 0x000B1308
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 639588, RefRangeEnd = 639590, XrefRangeStart = 639588, XrefRangeEnd = 639590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint3x4(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600225D RID: 8797 RVA: 0x000B313C File Offset: 0x000B133C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 639590, RefRangeEnd = 639592, XrefRangeStart = 639590, XrefRangeEnd = 639592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint3x4(bool3x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr__ctor_Public_Void_bool3x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600225E RID: 8798 RVA: 0x000B3170 File Offset: 0x000B1370
		[CallerCount(0)]
		public unsafe uint3x4(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600225F RID: 8799 RVA: 0x000B31A4 File Offset: 0x000B13A4
		[CallerCount(0)]
		public unsafe uint3x4(int3x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr__ctor_Public_Void_int3x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002260 RID: 8800 RVA: 0x000B31D8 File Offset: 0x000B13D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 642029, RefRangeEnd = 642030, XrefRangeStart = 642018, XrefRangeEnd = 642029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint3x4(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002261 RID: 8801 RVA: 0x000B320C File Offset: 0x000B140C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 642041, RefRangeEnd = 642043, XrefRangeStart = 642030, XrefRangeEnd = 642041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint3x4(float3x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr__ctor_Public_Void_float3x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002262 RID: 8802 RVA: 0x000B3240 File Offset: 0x000B1440
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 642054, RefRangeEnd = 642055, XrefRangeStart = 642043, XrefRangeEnd = 642054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint3x4(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002263 RID: 8803 RVA: 0x000B3274 File Offset: 0x000B1474
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 642066, RefRangeEnd = 642068, XrefRangeStart = 642055, XrefRangeEnd = 642066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint3x4(double3x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr__ctor_Public_Void_double3x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002264 RID: 8804 RVA: 0x000B32A8 File Offset: 0x000B14A8
		[CallerCount(0)]
		public unsafe static implicit operator uint3x4(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_Implicit_Public_Static_uint3x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002265 RID: 8805 RVA: 0x000B32E8 File Offset: 0x000B14E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint3x4(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x4_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002266 RID: 8806 RVA: 0x000B3328 File Offset: 0x000B1528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint3x4(bool3x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x4_bool3x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002267 RID: 8807 RVA: 0x000B3368 File Offset: 0x000B1568
		[CallerCount(0)]
		public unsafe static explicit operator uint3x4(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x4_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002268 RID: 8808 RVA: 0x000B33A8 File Offset: 0x000B15A8
		[CallerCount(0)]
		public unsafe static explicit operator uint3x4(int3x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x4_int3x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002269 RID: 8809 RVA: 0x000B33E8 File Offset: 0x000B15E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642068, XrefRangeEnd = 642069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint3x4(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x4_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600226A RID: 8810 RVA: 0x000B3428 File Offset: 0x000B1628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint3x4(float3x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x4_float3x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600226B RID: 8811 RVA: 0x000B3468 File Offset: 0x000B1668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642069, XrefRangeEnd = 642070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint3x4(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x4_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600226C RID: 8812 RVA: 0x000B34A8 File Offset: 0x000B16A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint3x4(double3x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x4_double3x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600226D RID: 8813 RVA: 0x000B34E8 File Offset: 0x000B16E8
		[CallerCount(0)]
		public unsafe static uint3x4 operator *(uint3x4 lhs, uint3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_Multiply_Public_Static_uint3x4_uint3x4_uint3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600226E RID: 8814 RVA: 0x000B3534 File Offset: 0x000B1734
		[CallerCount(0)]
		public unsafe static uint3x4 operator *(uint3x4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_Multiply_Public_Static_uint3x4_uint3x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600226F RID: 8815 RVA: 0x000B3580 File Offset: 0x000B1780
		[CallerCount(0)]
		public unsafe static uint3x4 operator *(uint lhs, uint3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_Multiply_Public_Static_uint3x4_UInt32_uint3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002270 RID: 8816 RVA: 0x000B35CC File Offset: 0x000B17CC
		[CallerCount(0)]
		public unsafe static uint3x4 operator +(uint3x4 lhs, uint3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_Addition_Public_Static_uint3x4_uint3x4_uint3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002271 RID: 8817 RVA: 0x000B3618 File Offset: 0x000B1818
		[CallerCount(0)]
		public unsafe static uint3x4 operator +(uint3x4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_Addition_Public_Static_uint3x4_uint3x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002272 RID: 8818 RVA: 0x000B3664 File Offset: 0x000B1864
		[CallerCount(0)]
		public unsafe static uint3x4 operator +(uint lhs, uint3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_Addition_Public_Static_uint3x4_UInt32_uint3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002273 RID: 8819 RVA: 0x000B36B0 File Offset: 0x000B18B0
		[CallerCount(0)]
		public unsafe static uint3x4 operator -(uint3x4 lhs, uint3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint3x4_uint3x4_uint3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002274 RID: 8820 RVA: 0x000B36FC File Offset: 0x000B18FC
		[CallerCount(0)]
		public unsafe static uint3x4 operator -(uint3x4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint3x4_uint3x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002275 RID: 8821 RVA: 0x000B3748 File Offset: 0x000B1948
		[CallerCount(0)]
		public unsafe static uint3x4 operator -(uint lhs, uint3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint3x4_UInt32_uint3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002276 RID: 8822 RVA: 0x000B3794 File Offset: 0x000B1994
		[CallerCount(0)]
		public unsafe static uint3x4 operator /(uint3x4 lhs, uint3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_Division_Public_Static_uint3x4_uint3x4_uint3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002277 RID: 8823 RVA: 0x000B37E0 File Offset: 0x000B19E0
		[CallerCount(0)]
		public unsafe static uint3x4 operator /(uint3x4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_Division_Public_Static_uint3x4_uint3x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002278 RID: 8824 RVA: 0x000B382C File Offset: 0x000B1A2C
		[CallerCount(0)]
		public unsafe static uint3x4 operator /(uint lhs, uint3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_Division_Public_Static_uint3x4_UInt32_uint3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002279 RID: 8825 RVA: 0x000B3878 File Offset: 0x000B1A78
		[CallerCount(0)]
		public unsafe static uint3x4 operator %(uint3x4 lhs, uint3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_Modulus_Public_Static_uint3x4_uint3x4_uint3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600227A RID: 8826 RVA: 0x000B38C4 File Offset: 0x000B1AC4
		[CallerCount(0)]
		public unsafe static uint3x4 operator %(uint3x4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_Modulus_Public_Static_uint3x4_uint3x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600227B RID: 8827 RVA: 0x000B3910 File Offset: 0x000B1B10
		[CallerCount(0)]
		public unsafe static uint3x4 operator %(uint lhs, uint3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_Modulus_Public_Static_uint3x4_UInt32_uint3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600227C RID: 8828 RVA: 0x000B395C File Offset: 0x000B1B5C
		[CallerCount(0)]
		public unsafe static uint3x4 operator ++(uint3x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_Increment_Public_Static_uint3x4_uint3x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600227D RID: 8829 RVA: 0x000B399C File Offset: 0x000B1B9C
		[CallerCount(0)]
		public unsafe static uint3x4 operator --(uint3x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_Decrement_Public_Static_uint3x4_uint3x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600227E RID: 8830 RVA: 0x000B39DC File Offset: 0x000B1BDC
		[CallerCount(0)]
		public unsafe static bool3x4 operator <(uint3x4 lhs, uint3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x4_uint3x4_uint3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600227F RID: 8831 RVA: 0x000B3A28 File Offset: 0x000B1C28
		[CallerCount(0)]
		public unsafe static bool3x4 operator <(uint3x4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x4_uint3x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002280 RID: 8832 RVA: 0x000B3A74 File Offset: 0x000B1C74
		[CallerCount(0)]
		public unsafe static bool3x4 operator <(uint lhs, uint3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x4_UInt32_uint3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002281 RID: 8833 RVA: 0x000B3AC0 File Offset: 0x000B1CC0
		[CallerCount(0)]
		public unsafe static bool3x4 operator <=(uint3x4 lhs, uint3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x4_uint3x4_uint3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002282 RID: 8834 RVA: 0x000B3B0C File Offset: 0x000B1D0C
		[CallerCount(0)]
		public unsafe static bool3x4 operator <=(uint3x4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x4_uint3x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002283 RID: 8835 RVA: 0x000B3B58 File Offset: 0x000B1D58
		[CallerCount(0)]
		public unsafe static bool3x4 operator <=(uint lhs, uint3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x4_UInt32_uint3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002284 RID: 8836 RVA: 0x000B3BA4 File Offset: 0x000B1DA4
		[CallerCount(0)]
		public unsafe static bool3x4 operator >(uint3x4 lhs, uint3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x4_uint3x4_uint3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002285 RID: 8837 RVA: 0x000B3BF0 File Offset: 0x000B1DF0
		[CallerCount(0)]
		public unsafe static bool3x4 operator >(uint3x4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x4_uint3x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002286 RID: 8838 RVA: 0x000B3C3C File Offset: 0x000B1E3C
		[CallerCount(0)]
		public unsafe static bool3x4 operator >(uint lhs, uint3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x4_UInt32_uint3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002287 RID: 8839 RVA: 0x000B3C88 File Offset: 0x000B1E88
		[CallerCount(0)]
		public unsafe static bool3x4 operator >=(uint3x4 lhs, uint3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x4_uint3x4_uint3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002288 RID: 8840 RVA: 0x000B3CD4 File Offset: 0x000B1ED4
		[CallerCount(0)]
		public unsafe static bool3x4 operator >=(uint3x4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x4_uint3x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002289 RID: 8841 RVA: 0x000B3D20 File Offset: 0x000B1F20
		[CallerCount(0)]
		public unsafe static bool3x4 operator >=(uint lhs, uint3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x4_UInt32_uint3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600228A RID: 8842 RVA: 0x000B3D6C File Offset: 0x000B1F6C
		[CallerCount(0)]
		public unsafe static uint3x4 operator -(uint3x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_uint3x4_uint3x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600228B RID: 8843 RVA: 0x000B3DAC File Offset: 0x000B1FAC
		[CallerCount(0)]
		public unsafe static uint3x4 operator +(uint3x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_uint3x4_uint3x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600228C RID: 8844 RVA: 0x000B3DEC File Offset: 0x000B1FEC
		[CallerCount(0)]
		public unsafe static uint3x4 operator <<(uint3x4 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_LeftShift_Public_Static_uint3x4_uint3x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600228D RID: 8845 RVA: 0x000B3E38 File Offset: 0x000B2038
		[CallerCount(0)]
		public unsafe static uint3x4 operator >>(uint3x4 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_RightShift_Public_Static_uint3x4_uint3x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600228E RID: 8846 RVA: 0x000B3E84 File Offset: 0x000B2084
		[CallerCount(0)]
		public unsafe static bool3x4 operator ==(uint3x4 lhs, uint3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x4_uint3x4_uint3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600228F RID: 8847 RVA: 0x000B3ED0 File Offset: 0x000B20D0
		[CallerCount(0)]
		public unsafe static bool3x4 operator ==(uint3x4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x4_uint3x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002290 RID: 8848 RVA: 0x000B3F1C File Offset: 0x000B211C
		[CallerCount(0)]
		public unsafe static bool3x4 operator ==(uint lhs, uint3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x4_UInt32_uint3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002291 RID: 8849 RVA: 0x000B3F68 File Offset: 0x000B2168
		[CallerCount(0)]
		public unsafe static bool3x4 operator !=(uint3x4 lhs, uint3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x4_uint3x4_uint3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002292 RID: 8850 RVA: 0x000B3FB4 File Offset: 0x000B21B4
		[CallerCount(0)]
		public unsafe static bool3x4 operator !=(uint3x4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x4_uint3x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002293 RID: 8851 RVA: 0x000B4000 File Offset: 0x000B2200
		[CallerCount(0)]
		public unsafe static bool3x4 operator !=(uint lhs, uint3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x4_UInt32_uint3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002294 RID: 8852 RVA: 0x000B404C File Offset: 0x000B224C
		[CallerCount(0)]
		public unsafe static uint3x4 operator ~(uint3x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_OnesComplement_Public_Static_uint3x4_uint3x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002295 RID: 8853 RVA: 0x000B408C File Offset: 0x000B228C
		[CallerCount(0)]
		public unsafe static uint3x4 operator &(uint3x4 lhs, uint3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint3x4_uint3x4_uint3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002296 RID: 8854 RVA: 0x000B40D8 File Offset: 0x000B22D8
		[CallerCount(0)]
		public unsafe static uint3x4 operator &(uint3x4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint3x4_uint3x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002297 RID: 8855 RVA: 0x000B4124 File Offset: 0x000B2324
		[CallerCount(0)]
		public unsafe static uint3x4 operator &(uint lhs, uint3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint3x4_UInt32_uint3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002298 RID: 8856 RVA: 0x000B4170 File Offset: 0x000B2370
		[CallerCount(0)]
		public unsafe static uint3x4 operator |(uint3x4 lhs, uint3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint3x4_uint3x4_uint3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002299 RID: 8857 RVA: 0x000B41BC File Offset: 0x000B23BC
		[CallerCount(0)]
		public unsafe static uint3x4 operator |(uint3x4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint3x4_uint3x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600229A RID: 8858 RVA: 0x000B4208 File Offset: 0x000B2408
		[CallerCount(0)]
		public unsafe static uint3x4 operator |(uint lhs, uint3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint3x4_UInt32_uint3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600229B RID: 8859 RVA: 0x000B4254 File Offset: 0x000B2454
		[CallerCount(0)]
		public unsafe static uint3x4 operator ^(uint3x4 lhs, uint3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint3x4_uint3x4_uint3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600229C RID: 8860 RVA: 0x000B42A0 File Offset: 0x000B24A0
		[CallerCount(0)]
		public unsafe static uint3x4 operator ^(uint3x4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint3x4_uint3x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600229D RID: 8861 RVA: 0x000B42EC File Offset: 0x000B24EC
		[CallerCount(0)]
		public unsafe static uint3x4 operator ^(uint lhs, uint3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint3x4_UInt32_uint3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000A88 RID: 2696
		public unsafe ref uint3 this[int index]
		{
			[CallerCount(0)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_get_Item_Public_get_byref_uint3_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x0600229F RID: 8863 RVA: 0x000B436C File Offset: 0x000B256C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 639594, RefRangeEnd = 639596, XrefRangeStart = 639594, XrefRangeEnd = 639596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(uint3x4 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_uint3x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060022A0 RID: 8864 RVA: 0x000B43AC File Offset: 0x000B25AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642070, XrefRangeEnd = 642074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060022A1 RID: 8865 RVA: 0x000B43F0 File Offset: 0x000B25F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642074, XrefRangeEnd = 642075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022A2 RID: 8866 RVA: 0x000B4420 File Offset: 0x000B2620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642075, XrefRangeEnd = 642130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060022A3 RID: 8867 RVA: 0x000B444C File Offset: 0x000B264C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642130, XrefRangeEnd = 642198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060022A4 RID: 8868 RVA: 0x00002A09 File Offset: 0x00000C09
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<uint3x4>.NativeClassPtr, ref this));
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x060022A5 RID: 8869 RVA: 0x000B449C File Offset: 0x000B269C
		// (set) Token: 0x060022A6 RID: 8870 RVA: 0x00002A1B File Offset: 0x00000C1B
		public unsafe static uint3x4 zero
		{
			get
			{
				uint3x4 uint3x;
				IL2CPP.il2cpp_field_static_get_value(uint3x4.NativeFieldInfoPtr_zero, (void*)(&uint3x));
				return uint3x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(uint3x4.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x040022E0 RID: 8928
		private static readonly IntPtr NativeFieldInfoPtr_c0;

		// Token: 0x040022E1 RID: 8929
		private static readonly IntPtr NativeFieldInfoPtr_c1;

		// Token: 0x040022E2 RID: 8930
		private static readonly IntPtr NativeFieldInfoPtr_c2;

		// Token: 0x040022E3 RID: 8931
		private static readonly IntPtr NativeFieldInfoPtr_c3;

		// Token: 0x040022E4 RID: 8932
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x040022E5 RID: 8933
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint3_uint3_uint3_uint3_0;

		// Token: 0x040022E6 RID: 8934
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_0;

		// Token: 0x040022E7 RID: 8935
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x040022E8 RID: 8936
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x040022E9 RID: 8937
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool3x4_0;

		// Token: 0x040022EA RID: 8938
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040022EB RID: 8939
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int3x4_0;

		// Token: 0x040022EC RID: 8940
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x040022ED RID: 8941
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float3x4_0;

		// Token: 0x040022EE RID: 8942
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x040022EF RID: 8943
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double3x4_0;

		// Token: 0x040022F0 RID: 8944
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_uint3x4_UInt32_0;

		// Token: 0x040022F1 RID: 8945
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x4_Boolean_0;

		// Token: 0x040022F2 RID: 8946
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x4_bool3x4_0;

		// Token: 0x040022F3 RID: 8947
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x4_Int32_0;

		// Token: 0x040022F4 RID: 8948
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x4_int3x4_0;

		// Token: 0x040022F5 RID: 8949
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x4_Single_0;

		// Token: 0x040022F6 RID: 8950
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x4_float3x4_0;

		// Token: 0x040022F7 RID: 8951
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x4_Double_0;

		// Token: 0x040022F8 RID: 8952
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x4_double3x4_0;

		// Token: 0x040022F9 RID: 8953
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_uint3x4_uint3x4_uint3x4_0;

		// Token: 0x040022FA RID: 8954
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_uint3x4_uint3x4_UInt32_0;

		// Token: 0x040022FB RID: 8955
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_uint3x4_UInt32_uint3x4_0;

		// Token: 0x040022FC RID: 8956
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_uint3x4_uint3x4_uint3x4_0;

		// Token: 0x040022FD RID: 8957
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_uint3x4_uint3x4_UInt32_0;

		// Token: 0x040022FE RID: 8958
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_uint3x4_UInt32_uint3x4_0;

		// Token: 0x040022FF RID: 8959
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_uint3x4_uint3x4_uint3x4_0;

		// Token: 0x04002300 RID: 8960
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_uint3x4_uint3x4_UInt32_0;

		// Token: 0x04002301 RID: 8961
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_uint3x4_UInt32_uint3x4_0;

		// Token: 0x04002302 RID: 8962
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_uint3x4_uint3x4_uint3x4_0;

		// Token: 0x04002303 RID: 8963
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_uint3x4_uint3x4_UInt32_0;

		// Token: 0x04002304 RID: 8964
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_uint3x4_UInt32_uint3x4_0;

		// Token: 0x04002305 RID: 8965
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_uint3x4_uint3x4_uint3x4_0;

		// Token: 0x04002306 RID: 8966
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_uint3x4_uint3x4_UInt32_0;

		// Token: 0x04002307 RID: 8967
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_uint3x4_UInt32_uint3x4_0;

		// Token: 0x04002308 RID: 8968
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_uint3x4_uint3x4_0;

		// Token: 0x04002309 RID: 8969
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_uint3x4_uint3x4_0;

		// Token: 0x0400230A RID: 8970
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x4_uint3x4_uint3x4_0;

		// Token: 0x0400230B RID: 8971
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x4_uint3x4_UInt32_0;

		// Token: 0x0400230C RID: 8972
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x4_UInt32_uint3x4_0;

		// Token: 0x0400230D RID: 8973
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x4_uint3x4_uint3x4_0;

		// Token: 0x0400230E RID: 8974
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x4_uint3x4_UInt32_0;

		// Token: 0x0400230F RID: 8975
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x4_UInt32_uint3x4_0;

		// Token: 0x04002310 RID: 8976
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x4_uint3x4_uint3x4_0;

		// Token: 0x04002311 RID: 8977
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x4_uint3x4_UInt32_0;

		// Token: 0x04002312 RID: 8978
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x4_UInt32_uint3x4_0;

		// Token: 0x04002313 RID: 8979
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x4_uint3x4_uint3x4_0;

		// Token: 0x04002314 RID: 8980
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x4_uint3x4_UInt32_0;

		// Token: 0x04002315 RID: 8981
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x4_UInt32_uint3x4_0;

		// Token: 0x04002316 RID: 8982
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_uint3x4_uint3x4_0;

		// Token: 0x04002317 RID: 8983
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryPlus_Public_Static_uint3x4_uint3x4_0;

		// Token: 0x04002318 RID: 8984
		private static readonly IntPtr NativeMethodInfoPtr_op_LeftShift_Public_Static_uint3x4_uint3x4_Int32_0;

		// Token: 0x04002319 RID: 8985
		private static readonly IntPtr NativeMethodInfoPtr_op_RightShift_Public_Static_uint3x4_uint3x4_Int32_0;

		// Token: 0x0400231A RID: 8986
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3x4_uint3x4_uint3x4_0;

		// Token: 0x0400231B RID: 8987
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3x4_uint3x4_UInt32_0;

		// Token: 0x0400231C RID: 8988
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3x4_UInt32_uint3x4_0;

		// Token: 0x0400231D RID: 8989
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x4_uint3x4_uint3x4_0;

		// Token: 0x0400231E RID: 8990
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x4_uint3x4_UInt32_0;

		// Token: 0x0400231F RID: 8991
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x4_UInt32_uint3x4_0;

		// Token: 0x04002320 RID: 8992
		private static readonly IntPtr NativeMethodInfoPtr_op_OnesComplement_Public_Static_uint3x4_uint3x4_0;

		// Token: 0x04002321 RID: 8993
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint3x4_uint3x4_uint3x4_0;

		// Token: 0x04002322 RID: 8994
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint3x4_uint3x4_UInt32_0;

		// Token: 0x04002323 RID: 8995
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint3x4_UInt32_uint3x4_0;

		// Token: 0x04002324 RID: 8996
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint3x4_uint3x4_uint3x4_0;

		// Token: 0x04002325 RID: 8997
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint3x4_uint3x4_UInt32_0;

		// Token: 0x04002326 RID: 8998
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint3x4_UInt32_uint3x4_0;

		// Token: 0x04002327 RID: 8999
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint3x4_uint3x4_uint3x4_0;

		// Token: 0x04002328 RID: 9000
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint3x4_uint3x4_UInt32_0;

		// Token: 0x04002329 RID: 9001
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint3x4_UInt32_uint3x4_0;

		// Token: 0x0400232A RID: 9002
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_uint3_Int32_0;

		// Token: 0x0400232B RID: 9003
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_uint3x4_0;

		// Token: 0x0400232C RID: 9004
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400232D RID: 9005
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400232E RID: 9006
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400232F RID: 9007
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04002330 RID: 9008
		[FieldOffset(0)]
		public uint3 c0;

		// Token: 0x04002331 RID: 9009
		[FieldOffset(12)]
		public uint3 c1;

		// Token: 0x04002332 RID: 9010
		[FieldOffset(24)]
		public uint3 c2;

		// Token: 0x04002333 RID: 9011
		[FieldOffset(36)]
		public uint3 c3;
	}
}
