using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x02000033 RID: 51
	[Serializable]
	[StructLayout(2)]
	public struct int3x3
	{
		// Token: 0x06001B60 RID: 7008 RVA: 0x0008F680 File Offset: 0x0008D880
		// Note: this type is marked as 'beforefieldinit'.
		static int3x3()
		{
			Il2CppClassPointerStore<int3x3>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "int3x3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<int3x3>.NativeClassPtr);
			int3x3.NativeFieldInfoPtr_c0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int3x3>.NativeClassPtr, "c0");
			int3x3.NativeFieldInfoPtr_c1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int3x3>.NativeClassPtr, "c1");
			int3x3.NativeFieldInfoPtr_c2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int3x3>.NativeClassPtr, "c2");
			int3x3.NativeFieldInfoPtr_identity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int3x3>.NativeClassPtr, "identity");
			int3x3.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int3x3>.NativeClassPtr, "zero");
			int3x3.NativeMethodInfoPtr__ctor_Public_Void_int3_int3_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670102);
			int3x3.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670103);
			int3x3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670104);
			int3x3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670105);
			int3x3.NativeMethodInfoPtr__ctor_Public_Void_bool3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670106);
			int3x3.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670107);
			int3x3.NativeMethodInfoPtr__ctor_Public_Void_uint3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670108);
			int3x3.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670109);
			int3x3.NativeMethodInfoPtr__ctor_Public_Void_float3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670110);
			int3x3.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670111);
			int3x3.NativeMethodInfoPtr__ctor_Public_Void_double3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670112);
			int3x3.NativeMethodInfoPtr_op_Implicit_Public_Static_int3x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670113);
			int3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670114);
			int3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x3_bool3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670115);
			int3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670116);
			int3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x3_uint3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670117);
			int3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670118);
			int3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x3_float3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670119);
			int3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670120);
			int3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x3_double3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670121);
			int3x3.NativeMethodInfoPtr_op_Multiply_Public_Static_int3x3_int3x3_int3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670122);
			int3x3.NativeMethodInfoPtr_op_Multiply_Public_Static_int3x3_int3x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670123);
			int3x3.NativeMethodInfoPtr_op_Multiply_Public_Static_int3x3_Int32_int3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670124);
			int3x3.NativeMethodInfoPtr_op_Addition_Public_Static_int3x3_int3x3_int3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670125);
			int3x3.NativeMethodInfoPtr_op_Addition_Public_Static_int3x3_int3x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670126);
			int3x3.NativeMethodInfoPtr_op_Addition_Public_Static_int3x3_Int32_int3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670127);
			int3x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_int3x3_int3x3_int3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670128);
			int3x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_int3x3_int3x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670129);
			int3x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_int3x3_Int32_int3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670130);
			int3x3.NativeMethodInfoPtr_op_Division_Public_Static_int3x3_int3x3_int3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670131);
			int3x3.NativeMethodInfoPtr_op_Division_Public_Static_int3x3_int3x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670132);
			int3x3.NativeMethodInfoPtr_op_Division_Public_Static_int3x3_Int32_int3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670133);
			int3x3.NativeMethodInfoPtr_op_Modulus_Public_Static_int3x3_int3x3_int3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670134);
			int3x3.NativeMethodInfoPtr_op_Modulus_Public_Static_int3x3_int3x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670135);
			int3x3.NativeMethodInfoPtr_op_Modulus_Public_Static_int3x3_Int32_int3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670136);
			int3x3.NativeMethodInfoPtr_op_Increment_Public_Static_int3x3_int3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670137);
			int3x3.NativeMethodInfoPtr_op_Decrement_Public_Static_int3x3_int3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670138);
			int3x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x3_int3x3_int3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670139);
			int3x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x3_int3x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670140);
			int3x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x3_Int32_int3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670141);
			int3x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x3_int3x3_int3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670142);
			int3x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x3_int3x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670143);
			int3x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x3_Int32_int3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670144);
			int3x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x3_int3x3_int3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670145);
			int3x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x3_int3x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670146);
			int3x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x3_Int32_int3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670147);
			int3x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x3_int3x3_int3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670148);
			int3x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x3_int3x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670149);
			int3x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x3_Int32_int3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670150);
			int3x3.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_int3x3_int3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670151);
			int3x3.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_int3x3_int3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670152);
			int3x3.NativeMethodInfoPtr_op_LeftShift_Public_Static_int3x3_int3x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670153);
			int3x3.NativeMethodInfoPtr_op_RightShift_Public_Static_int3x3_int3x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670154);
			int3x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_int3x3_int3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670155);
			int3x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_int3x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670156);
			int3x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_Int32_int3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670157);
			int3x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_int3x3_int3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670158);
			int3x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_int3x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670159);
			int3x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_Int32_int3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670160);
			int3x3.NativeMethodInfoPtr_op_OnesComplement_Public_Static_int3x3_int3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670161);
			int3x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int3x3_int3x3_int3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670162);
			int3x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int3x3_int3x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670163);
			int3x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int3x3_Int32_int3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670164);
			int3x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int3x3_int3x3_int3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670165);
			int3x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int3x3_int3x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670166);
			int3x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int3x3_Int32_int3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670167);
			int3x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int3x3_int3x3_int3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670168);
			int3x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int3x3_int3x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670169);
			int3x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int3x3_Int32_int3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670170);
			int3x3.NativeMethodInfoPtr_get_Item_Public_get_byref_int3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670171);
			int3x3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_int3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670172);
			int3x3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670173);
			int3x3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670174);
			int3x3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670175);
			int3x3.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x3>.NativeClassPtr, 100670176);
		}

		// Token: 0x06001B61 RID: 7009 RVA: 0x0008FCF0 File Offset: 0x0008DEF0
		[CallerCount(0)]
		public unsafe int3x3(int3 c0, int3 c1, int3 c2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr__ctor_Public_Void_int3_int3_int3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B62 RID: 7010 RVA: 0x0008FD40 File Offset: 0x0008DF40
		[CallerCount(0)]
		public unsafe int3x3(int m00, int m01, int m02, int m10, int m11, int m12, int m20, int m21, int m22)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref m00;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m01;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m02;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m10;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m11;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m12;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m20;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m21;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m22;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x0008FDE4 File Offset: 0x0008DFE4
		[CallerCount(0)]
		public unsafe int3x3(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B64 RID: 7012 RVA: 0x0008FE18 File Offset: 0x0008E018
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 639486, RefRangeEnd = 639488, XrefRangeStart = 639486, XrefRangeEnd = 639486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int3x3(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x0008FE4C File Offset: 0x0008E04C
		[CallerCount(0)]
		public unsafe int3x3(bool3x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr__ctor_Public_Void_bool3x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x0008FE80 File Offset: 0x0008E080
		[CallerCount(0)]
		public unsafe int3x3(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B67 RID: 7015 RVA: 0x0008FEB4 File Offset: 0x0008E0B4
		[CallerCount(0)]
		public unsafe int3x3(uint3x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr__ctor_Public_Void_uint3x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B68 RID: 7016 RVA: 0x0008FEE8 File Offset: 0x0008E0E8
		[CallerCount(0)]
		public unsafe int3x3(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B69 RID: 7017 RVA: 0x0008FF1C File Offset: 0x0008E11C
		[CallerCount(0)]
		public unsafe int3x3(float3x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr__ctor_Public_Void_float3x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B6A RID: 7018 RVA: 0x0008FF50 File Offset: 0x0008E150
		[CallerCount(0)]
		public unsafe int3x3(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B6B RID: 7019 RVA: 0x0008FF84 File Offset: 0x0008E184
		[CallerCount(0)]
		public unsafe int3x3(double3x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr__ctor_Public_Void_double3x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B6C RID: 7020 RVA: 0x0008FFB8 File Offset: 0x0008E1B8
		[CallerCount(0)]
		public unsafe static implicit operator int3x3(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_Implicit_Public_Static_int3x3_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B6D RID: 7021 RVA: 0x0008FFF8 File Offset: 0x0008E1F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639488, XrefRangeEnd = 639489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator int3x3(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x3_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B6E RID: 7022 RVA: 0x00090038 File Offset: 0x0008E238
		[CallerCount(0)]
		public unsafe static explicit operator int3x3(bool3x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x3_bool3x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B6F RID: 7023 RVA: 0x00090078 File Offset: 0x0008E278
		[CallerCount(0)]
		public unsafe static explicit operator int3x3(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B70 RID: 7024 RVA: 0x000900B8 File Offset: 0x0008E2B8
		[CallerCount(0)]
		public unsafe static explicit operator int3x3(uint3x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x3_uint3x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x000900F8 File Offset: 0x0008E2F8
		[CallerCount(0)]
		public unsafe static explicit operator int3x3(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x3_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B72 RID: 7026 RVA: 0x00090138 File Offset: 0x0008E338
		[CallerCount(0)]
		public unsafe static explicit operator int3x3(float3x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x3_float3x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B73 RID: 7027 RVA: 0x00090178 File Offset: 0x0008E378
		[CallerCount(0)]
		public unsafe static explicit operator int3x3(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x3_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x000901B8 File Offset: 0x0008E3B8
		[CallerCount(0)]
		public unsafe static explicit operator int3x3(double3x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x3_double3x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x000901F8 File Offset: 0x0008E3F8
		[CallerCount(0)]
		public unsafe static int3x3 operator *(int3x3 lhs, int3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_Multiply_Public_Static_int3x3_int3x3_int3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B76 RID: 7030 RVA: 0x00090244 File Offset: 0x0008E444
		[CallerCount(0)]
		public unsafe static int3x3 operator *(int3x3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_Multiply_Public_Static_int3x3_int3x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B77 RID: 7031 RVA: 0x00090290 File Offset: 0x0008E490
		[CallerCount(0)]
		public unsafe static int3x3 operator *(int lhs, int3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_Multiply_Public_Static_int3x3_Int32_int3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B78 RID: 7032 RVA: 0x000902DC File Offset: 0x0008E4DC
		[CallerCount(0)]
		public unsafe static int3x3 operator +(int3x3 lhs, int3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_Addition_Public_Static_int3x3_int3x3_int3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B79 RID: 7033 RVA: 0x00090328 File Offset: 0x0008E528
		[CallerCount(0)]
		public unsafe static int3x3 operator +(int3x3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_Addition_Public_Static_int3x3_int3x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B7A RID: 7034 RVA: 0x00090374 File Offset: 0x0008E574
		[CallerCount(0)]
		public unsafe static int3x3 operator +(int lhs, int3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_Addition_Public_Static_int3x3_Int32_int3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B7B RID: 7035 RVA: 0x000903C0 File Offset: 0x0008E5C0
		[CallerCount(0)]
		public unsafe static int3x3 operator -(int3x3 lhs, int3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_int3x3_int3x3_int3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B7C RID: 7036 RVA: 0x0009040C File Offset: 0x0008E60C
		[CallerCount(0)]
		public unsafe static int3x3 operator -(int3x3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_int3x3_int3x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B7D RID: 7037 RVA: 0x00090458 File Offset: 0x0008E658
		[CallerCount(0)]
		public unsafe static int3x3 operator -(int lhs, int3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_int3x3_Int32_int3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B7E RID: 7038 RVA: 0x000904A4 File Offset: 0x0008E6A4
		[CallerCount(0)]
		public unsafe static int3x3 operator /(int3x3 lhs, int3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_Division_Public_Static_int3x3_int3x3_int3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B7F RID: 7039 RVA: 0x000904F0 File Offset: 0x0008E6F0
		[CallerCount(0)]
		public unsafe static int3x3 operator /(int3x3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_Division_Public_Static_int3x3_int3x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x0009053C File Offset: 0x0008E73C
		[CallerCount(0)]
		public unsafe static int3x3 operator /(int lhs, int3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_Division_Public_Static_int3x3_Int32_int3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B81 RID: 7041 RVA: 0x00090588 File Offset: 0x0008E788
		[CallerCount(0)]
		public unsafe static int3x3 operator %(int3x3 lhs, int3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_Modulus_Public_Static_int3x3_int3x3_int3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x000905D4 File Offset: 0x0008E7D4
		[CallerCount(0)]
		public unsafe static int3x3 operator %(int3x3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_Modulus_Public_Static_int3x3_int3x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x00090620 File Offset: 0x0008E820
		[CallerCount(0)]
		public unsafe static int3x3 operator %(int lhs, int3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_Modulus_Public_Static_int3x3_Int32_int3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B84 RID: 7044 RVA: 0x0009066C File Offset: 0x0008E86C
		[CallerCount(0)]
		public unsafe static int3x3 operator ++(int3x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_Increment_Public_Static_int3x3_int3x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x000906AC File Offset: 0x0008E8AC
		[CallerCount(0)]
		public unsafe static int3x3 operator --(int3x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_Decrement_Public_Static_int3x3_int3x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x000906EC File Offset: 0x0008E8EC
		[CallerCount(0)]
		public unsafe static bool3x3 operator <(int3x3 lhs, int3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x3_int3x3_int3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x00090738 File Offset: 0x0008E938
		[CallerCount(0)]
		public unsafe static bool3x3 operator <(int3x3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x3_int3x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x00090784 File Offset: 0x0008E984
		[CallerCount(0)]
		public unsafe static bool3x3 operator <(int lhs, int3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x3_Int32_int3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x000907D0 File Offset: 0x0008E9D0
		[CallerCount(0)]
		public unsafe static bool3x3 operator <=(int3x3 lhs, int3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x3_int3x3_int3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x0009081C File Offset: 0x0008EA1C
		[CallerCount(0)]
		public unsafe static bool3x3 operator <=(int3x3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x3_int3x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x00090868 File Offset: 0x0008EA68
		[CallerCount(0)]
		public unsafe static bool3x3 operator <=(int lhs, int3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x3_Int32_int3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x000908B4 File Offset: 0x0008EAB4
		[CallerCount(0)]
		public unsafe static bool3x3 operator >(int3x3 lhs, int3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x3_int3x3_int3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x00090900 File Offset: 0x0008EB00
		[CallerCount(0)]
		public unsafe static bool3x3 operator >(int3x3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x3_int3x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x0009094C File Offset: 0x0008EB4C
		[CallerCount(0)]
		public unsafe static bool3x3 operator >(int lhs, int3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x3_Int32_int3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x00090998 File Offset: 0x0008EB98
		[CallerCount(0)]
		public unsafe static bool3x3 operator >=(int3x3 lhs, int3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x3_int3x3_int3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x000909E4 File Offset: 0x0008EBE4
		[CallerCount(0)]
		public unsafe static bool3x3 operator >=(int3x3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x3_int3x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x00090A30 File Offset: 0x0008EC30
		[CallerCount(0)]
		public unsafe static bool3x3 operator >=(int lhs, int3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x3_Int32_int3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x00090A7C File Offset: 0x0008EC7C
		[CallerCount(0)]
		public unsafe static int3x3 operator -(int3x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_int3x3_int3x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x00090ABC File Offset: 0x0008ECBC
		[CallerCount(0)]
		public unsafe static int3x3 operator +(int3x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_int3x3_int3x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B94 RID: 7060 RVA: 0x00090AFC File Offset: 0x0008ECFC
		[CallerCount(0)]
		public unsafe static int3x3 operator <<(int3x3 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_LeftShift_Public_Static_int3x3_int3x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B95 RID: 7061 RVA: 0x00090B48 File Offset: 0x0008ED48
		[CallerCount(0)]
		public unsafe static int3x3 operator >>(int3x3 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_RightShift_Public_Static_int3x3_int3x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B96 RID: 7062 RVA: 0x00090B94 File Offset: 0x0008ED94
		[CallerCount(0)]
		public unsafe static bool3x3 operator ==(int3x3 lhs, int3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_int3x3_int3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B97 RID: 7063 RVA: 0x00090BE0 File Offset: 0x0008EDE0
		[CallerCount(0)]
		public unsafe static bool3x3 operator ==(int3x3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_int3x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x00090C2C File Offset: 0x0008EE2C
		[CallerCount(0)]
		public unsafe static bool3x3 operator ==(int lhs, int3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_Int32_int3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B99 RID: 7065 RVA: 0x00090C78 File Offset: 0x0008EE78
		[CallerCount(0)]
		public unsafe static bool3x3 operator !=(int3x3 lhs, int3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_int3x3_int3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B9A RID: 7066 RVA: 0x00090CC4 File Offset: 0x0008EEC4
		[CallerCount(0)]
		public unsafe static bool3x3 operator !=(int3x3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_int3x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B9B RID: 7067 RVA: 0x00090D10 File Offset: 0x0008EF10
		[CallerCount(0)]
		public unsafe static bool3x3 operator !=(int lhs, int3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_Int32_int3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B9C RID: 7068 RVA: 0x00090D5C File Offset: 0x0008EF5C
		[CallerCount(0)]
		public unsafe static int3x3 operator ~(int3x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_OnesComplement_Public_Static_int3x3_int3x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B9D RID: 7069 RVA: 0x00090D9C File Offset: 0x0008EF9C
		[CallerCount(0)]
		public unsafe static int3x3 operator &(int3x3 lhs, int3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int3x3_int3x3_int3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B9E RID: 7070 RVA: 0x00090DE8 File Offset: 0x0008EFE8
		[CallerCount(0)]
		public unsafe static int3x3 operator &(int3x3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int3x3_int3x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B9F RID: 7071 RVA: 0x00090E34 File Offset: 0x0008F034
		[CallerCount(0)]
		public unsafe static int3x3 operator &(int lhs, int3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int3x3_Int32_int3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BA0 RID: 7072 RVA: 0x00090E80 File Offset: 0x0008F080
		[CallerCount(0)]
		public unsafe static int3x3 operator |(int3x3 lhs, int3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int3x3_int3x3_int3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BA1 RID: 7073 RVA: 0x00090ECC File Offset: 0x0008F0CC
		[CallerCount(0)]
		public unsafe static int3x3 operator |(int3x3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int3x3_int3x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BA2 RID: 7074 RVA: 0x00090F18 File Offset: 0x0008F118
		[CallerCount(0)]
		public unsafe static int3x3 operator |(int lhs, int3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int3x3_Int32_int3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BA3 RID: 7075 RVA: 0x00090F64 File Offset: 0x0008F164
		[CallerCount(0)]
		public unsafe static int3x3 operator ^(int3x3 lhs, int3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int3x3_int3x3_int3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x00090FB0 File Offset: 0x0008F1B0
		[CallerCount(0)]
		public unsafe static int3x3 operator ^(int3x3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int3x3_int3x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BA5 RID: 7077 RVA: 0x00090FFC File Offset: 0x0008F1FC
		[CallerCount(0)]
		public unsafe static int3x3 operator ^(int lhs, int3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int3x3_Int32_int3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000888 RID: 2184
		public unsafe ref int3 this[int index]
		{
			[CallerCount(0)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_get_Item_Public_get_byref_int3_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x0009107C File Offset: 0x0008F27C
		[CallerCount(0)]
		public unsafe bool Equals(int3x3 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_int3x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BA8 RID: 7080 RVA: 0x000910BC File Offset: 0x0008F2BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639489, XrefRangeEnd = 639492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BA9 RID: 7081 RVA: 0x00091100 File Offset: 0x0008F300
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BAA RID: 7082 RVA: 0x00091130 File Offset: 0x0008F330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639492, XrefRangeEnd = 639535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001BAB RID: 7083 RVA: 0x0009115C File Offset: 0x0008F35C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639535, XrefRangeEnd = 639588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x3.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x00002752 File Offset: 0x00000952
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<int3x3>.NativeClassPtr, ref this));
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06001BAD RID: 7085 RVA: 0x000911AC File Offset: 0x0008F3AC
		// (set) Token: 0x06001BAE RID: 7086 RVA: 0x00002764 File Offset: 0x00000964
		public unsafe static int3x3 identity
		{
			get
			{
				int3x3 int3x;
				IL2CPP.il2cpp_field_static_get_value(int3x3.NativeFieldInfoPtr_identity, (void*)(&int3x));
				return int3x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(int3x3.NativeFieldInfoPtr_identity, (void*)(&value));
			}
		}

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x06001BAF RID: 7087 RVA: 0x000911C8 File Offset: 0x0008F3C8
		// (set) Token: 0x06001BB0 RID: 7088 RVA: 0x00002772 File Offset: 0x00000972
		public unsafe static int3x3 zero
		{
			get
			{
				int3x3 int3x;
				IL2CPP.il2cpp_field_static_get_value(int3x3.NativeFieldInfoPtr_zero, (void*)(&int3x));
				return int3x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(int3x3.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x04001BCB RID: 7115
		private static readonly IntPtr NativeFieldInfoPtr_c0;

		// Token: 0x04001BCC RID: 7116
		private static readonly IntPtr NativeFieldInfoPtr_c1;

		// Token: 0x04001BCD RID: 7117
		private static readonly IntPtr NativeFieldInfoPtr_c2;

		// Token: 0x04001BCE RID: 7118
		private static readonly IntPtr NativeFieldInfoPtr_identity;

		// Token: 0x04001BCF RID: 7119
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x04001BD0 RID: 7120
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int3_int3_int3_0;

		// Token: 0x04001BD1 RID: 7121
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x04001BD2 RID: 7122
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001BD3 RID: 7123
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04001BD4 RID: 7124
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool3x3_0;

		// Token: 0x04001BD5 RID: 7125
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04001BD6 RID: 7126
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint3x3_0;

		// Token: 0x04001BD7 RID: 7127
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x04001BD8 RID: 7128
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float3x3_0;

		// Token: 0x04001BD9 RID: 7129
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x04001BDA RID: 7130
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double3x3_0;

		// Token: 0x04001BDB RID: 7131
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_int3x3_Int32_0;

		// Token: 0x04001BDC RID: 7132
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int3x3_Boolean_0;

		// Token: 0x04001BDD RID: 7133
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int3x3_bool3x3_0;

		// Token: 0x04001BDE RID: 7134
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int3x3_UInt32_0;

		// Token: 0x04001BDF RID: 7135
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int3x3_uint3x3_0;

		// Token: 0x04001BE0 RID: 7136
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int3x3_Single_0;

		// Token: 0x04001BE1 RID: 7137
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int3x3_float3x3_0;

		// Token: 0x04001BE2 RID: 7138
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int3x3_Double_0;

		// Token: 0x04001BE3 RID: 7139
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int3x3_double3x3_0;

		// Token: 0x04001BE4 RID: 7140
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_int3x3_int3x3_int3x3_0;

		// Token: 0x04001BE5 RID: 7141
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_int3x3_int3x3_Int32_0;

		// Token: 0x04001BE6 RID: 7142
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_int3x3_Int32_int3x3_0;

		// Token: 0x04001BE7 RID: 7143
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_int3x3_int3x3_int3x3_0;

		// Token: 0x04001BE8 RID: 7144
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_int3x3_int3x3_Int32_0;

		// Token: 0x04001BE9 RID: 7145
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_int3x3_Int32_int3x3_0;

		// Token: 0x04001BEA RID: 7146
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_int3x3_int3x3_int3x3_0;

		// Token: 0x04001BEB RID: 7147
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_int3x3_int3x3_Int32_0;

		// Token: 0x04001BEC RID: 7148
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_int3x3_Int32_int3x3_0;

		// Token: 0x04001BED RID: 7149
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_int3x3_int3x3_int3x3_0;

		// Token: 0x04001BEE RID: 7150
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_int3x3_int3x3_Int32_0;

		// Token: 0x04001BEF RID: 7151
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_int3x3_Int32_int3x3_0;

		// Token: 0x04001BF0 RID: 7152
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_int3x3_int3x3_int3x3_0;

		// Token: 0x04001BF1 RID: 7153
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_int3x3_int3x3_Int32_0;

		// Token: 0x04001BF2 RID: 7154
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_int3x3_Int32_int3x3_0;

		// Token: 0x04001BF3 RID: 7155
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_int3x3_int3x3_0;

		// Token: 0x04001BF4 RID: 7156
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_int3x3_int3x3_0;

		// Token: 0x04001BF5 RID: 7157
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x3_int3x3_int3x3_0;

		// Token: 0x04001BF6 RID: 7158
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x3_int3x3_Int32_0;

		// Token: 0x04001BF7 RID: 7159
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x3_Int32_int3x3_0;

		// Token: 0x04001BF8 RID: 7160
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x3_int3x3_int3x3_0;

		// Token: 0x04001BF9 RID: 7161
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x3_int3x3_Int32_0;

		// Token: 0x04001BFA RID: 7162
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x3_Int32_int3x3_0;

		// Token: 0x04001BFB RID: 7163
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x3_int3x3_int3x3_0;

		// Token: 0x04001BFC RID: 7164
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x3_int3x3_Int32_0;

		// Token: 0x04001BFD RID: 7165
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x3_Int32_int3x3_0;

		// Token: 0x04001BFE RID: 7166
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x3_int3x3_int3x3_0;

		// Token: 0x04001BFF RID: 7167
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x3_int3x3_Int32_0;

		// Token: 0x04001C00 RID: 7168
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x3_Int32_int3x3_0;

		// Token: 0x04001C01 RID: 7169
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_int3x3_int3x3_0;

		// Token: 0x04001C02 RID: 7170
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryPlus_Public_Static_int3x3_int3x3_0;

		// Token: 0x04001C03 RID: 7171
		private static readonly IntPtr NativeMethodInfoPtr_op_LeftShift_Public_Static_int3x3_int3x3_Int32_0;

		// Token: 0x04001C04 RID: 7172
		private static readonly IntPtr NativeMethodInfoPtr_op_RightShift_Public_Static_int3x3_int3x3_Int32_0;

		// Token: 0x04001C05 RID: 7173
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_int3x3_int3x3_0;

		// Token: 0x04001C06 RID: 7174
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_int3x3_Int32_0;

		// Token: 0x04001C07 RID: 7175
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_Int32_int3x3_0;

		// Token: 0x04001C08 RID: 7176
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_int3x3_int3x3_0;

		// Token: 0x04001C09 RID: 7177
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_int3x3_Int32_0;

		// Token: 0x04001C0A RID: 7178
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_Int32_int3x3_0;

		// Token: 0x04001C0B RID: 7179
		private static readonly IntPtr NativeMethodInfoPtr_op_OnesComplement_Public_Static_int3x3_int3x3_0;

		// Token: 0x04001C0C RID: 7180
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int3x3_int3x3_int3x3_0;

		// Token: 0x04001C0D RID: 7181
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int3x3_int3x3_Int32_0;

		// Token: 0x04001C0E RID: 7182
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int3x3_Int32_int3x3_0;

		// Token: 0x04001C0F RID: 7183
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int3x3_int3x3_int3x3_0;

		// Token: 0x04001C10 RID: 7184
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int3x3_int3x3_Int32_0;

		// Token: 0x04001C11 RID: 7185
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int3x3_Int32_int3x3_0;

		// Token: 0x04001C12 RID: 7186
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int3x3_int3x3_int3x3_0;

		// Token: 0x04001C13 RID: 7187
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int3x3_int3x3_Int32_0;

		// Token: 0x04001C14 RID: 7188
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int3x3_Int32_int3x3_0;

		// Token: 0x04001C15 RID: 7189
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_int3_Int32_0;

		// Token: 0x04001C16 RID: 7190
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_int3x3_0;

		// Token: 0x04001C17 RID: 7191
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001C18 RID: 7192
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001C19 RID: 7193
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001C1A RID: 7194
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04001C1B RID: 7195
		[FieldOffset(0)]
		public int3 c0;

		// Token: 0x04001C1C RID: 7196
		[FieldOffset(12)]
		public int3 c1;

		// Token: 0x04001C1D RID: 7197
		[FieldOffset(24)]
		public int3 c2;
	}
}
