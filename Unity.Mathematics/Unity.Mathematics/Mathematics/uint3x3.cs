using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x02000045 RID: 69
	[Serializable]
	[StructLayout(2)]
	public struct uint3x3
	{
		// Token: 0x06002207 RID: 8711 RVA: 0x000B0DD4 File Offset: 0x000AEFD4
		// Note: this type is marked as 'beforefieldinit'.
		static uint3x3()
		{
			Il2CppClassPointerStore<uint3x3>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "uint3x3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<uint3x3>.NativeClassPtr);
			uint3x3.NativeFieldInfoPtr_c0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, "c0");
			uint3x3.NativeFieldInfoPtr_c1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, "c1");
			uint3x3.NativeFieldInfoPtr_c2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, "c2");
			uint3x3.NativeFieldInfoPtr_identity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, "identity");
			uint3x3.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, "zero");
			uint3x3.NativeMethodInfoPtr__ctor_Public_Void_uint3_uint3_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671743);
			uint3x3.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671744);
			uint3x3.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671745);
			uint3x3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671746);
			uint3x3.NativeMethodInfoPtr__ctor_Public_Void_bool3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671747);
			uint3x3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671748);
			uint3x3.NativeMethodInfoPtr__ctor_Public_Void_int3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671749);
			uint3x3.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671750);
			uint3x3.NativeMethodInfoPtr__ctor_Public_Void_float3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671751);
			uint3x3.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671752);
			uint3x3.NativeMethodInfoPtr__ctor_Public_Void_double3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671753);
			uint3x3.NativeMethodInfoPtr_op_Implicit_Public_Static_uint3x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671754);
			uint3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671755);
			uint3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x3_bool3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671756);
			uint3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671757);
			uint3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x3_int3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671758);
			uint3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671759);
			uint3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x3_float3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671760);
			uint3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671761);
			uint3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x3_double3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671762);
			uint3x3.NativeMethodInfoPtr_op_Multiply_Public_Static_uint3x3_uint3x3_uint3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671763);
			uint3x3.NativeMethodInfoPtr_op_Multiply_Public_Static_uint3x3_uint3x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671764);
			uint3x3.NativeMethodInfoPtr_op_Multiply_Public_Static_uint3x3_UInt32_uint3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671765);
			uint3x3.NativeMethodInfoPtr_op_Addition_Public_Static_uint3x3_uint3x3_uint3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671766);
			uint3x3.NativeMethodInfoPtr_op_Addition_Public_Static_uint3x3_uint3x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671767);
			uint3x3.NativeMethodInfoPtr_op_Addition_Public_Static_uint3x3_UInt32_uint3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671768);
			uint3x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint3x3_uint3x3_uint3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671769);
			uint3x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint3x3_uint3x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671770);
			uint3x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint3x3_UInt32_uint3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671771);
			uint3x3.NativeMethodInfoPtr_op_Division_Public_Static_uint3x3_uint3x3_uint3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671772);
			uint3x3.NativeMethodInfoPtr_op_Division_Public_Static_uint3x3_uint3x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671773);
			uint3x3.NativeMethodInfoPtr_op_Division_Public_Static_uint3x3_UInt32_uint3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671774);
			uint3x3.NativeMethodInfoPtr_op_Modulus_Public_Static_uint3x3_uint3x3_uint3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671775);
			uint3x3.NativeMethodInfoPtr_op_Modulus_Public_Static_uint3x3_uint3x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671776);
			uint3x3.NativeMethodInfoPtr_op_Modulus_Public_Static_uint3x3_UInt32_uint3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671777);
			uint3x3.NativeMethodInfoPtr_op_Increment_Public_Static_uint3x3_uint3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671778);
			uint3x3.NativeMethodInfoPtr_op_Decrement_Public_Static_uint3x3_uint3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671779);
			uint3x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x3_uint3x3_uint3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671780);
			uint3x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x3_uint3x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671781);
			uint3x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x3_UInt32_uint3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671782);
			uint3x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x3_uint3x3_uint3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671783);
			uint3x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x3_uint3x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671784);
			uint3x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x3_UInt32_uint3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671785);
			uint3x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x3_uint3x3_uint3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671786);
			uint3x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x3_uint3x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671787);
			uint3x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x3_UInt32_uint3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671788);
			uint3x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x3_uint3x3_uint3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671789);
			uint3x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x3_uint3x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671790);
			uint3x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x3_UInt32_uint3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671791);
			uint3x3.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_uint3x3_uint3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671792);
			uint3x3.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_uint3x3_uint3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671793);
			uint3x3.NativeMethodInfoPtr_op_LeftShift_Public_Static_uint3x3_uint3x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671794);
			uint3x3.NativeMethodInfoPtr_op_RightShift_Public_Static_uint3x3_uint3x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671795);
			uint3x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_uint3x3_uint3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671796);
			uint3x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_uint3x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671797);
			uint3x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_UInt32_uint3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671798);
			uint3x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_uint3x3_uint3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671799);
			uint3x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_uint3x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671800);
			uint3x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_UInt32_uint3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671801);
			uint3x3.NativeMethodInfoPtr_op_OnesComplement_Public_Static_uint3x3_uint3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671802);
			uint3x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint3x3_uint3x3_uint3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671803);
			uint3x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint3x3_uint3x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671804);
			uint3x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint3x3_UInt32_uint3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671805);
			uint3x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint3x3_uint3x3_uint3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671806);
			uint3x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint3x3_uint3x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671807);
			uint3x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint3x3_UInt32_uint3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671808);
			uint3x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint3x3_uint3x3_uint3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671809);
			uint3x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint3x3_uint3x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671810);
			uint3x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint3x3_UInt32_uint3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671811);
			uint3x3.NativeMethodInfoPtr_get_Item_Public_get_byref_uint3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671812);
			uint3x3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_uint3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671813);
			uint3x3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671814);
			uint3x3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671815);
			uint3x3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671816);
			uint3x3.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, 100671817);
		}

		// Token: 0x06002208 RID: 8712 RVA: 0x000B1444 File Offset: 0x000AF644
		[CallerCount(0)]
		public unsafe uint3x3(uint3 c0, uint3 c1, uint3 c2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr__ctor_Public_Void_uint3_uint3_uint3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002209 RID: 8713 RVA: 0x000B1494 File Offset: 0x000AF694
		[CallerCount(0)]
		public unsafe uint3x3(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12, uint m20, uint m21, uint m22)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600220A RID: 8714 RVA: 0x000B1538 File Offset: 0x000AF738
		[CallerCount(0)]
		public unsafe uint3x3(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600220B RID: 8715 RVA: 0x000B156C File Offset: 0x000AF76C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 639486, RefRangeEnd = 639488, XrefRangeStart = 639486, XrefRangeEnd = 639488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint3x3(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600220C RID: 8716 RVA: 0x000B15A0 File Offset: 0x000AF7A0
		[CallerCount(0)]
		public unsafe uint3x3(bool3x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr__ctor_Public_Void_bool3x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600220D RID: 8717 RVA: 0x000B15D4 File Offset: 0x000AF7D4
		[CallerCount(0)]
		public unsafe uint3x3(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600220E RID: 8718 RVA: 0x000B1608 File Offset: 0x000AF808
		[CallerCount(0)]
		public unsafe uint3x3(int3x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr__ctor_Public_Void_int3x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600220F RID: 8719 RVA: 0x000B163C File Offset: 0x000AF83C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 641885, RefRangeEnd = 641886, XrefRangeStart = 641877, XrefRangeEnd = 641885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint3x3(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002210 RID: 8720 RVA: 0x000B1670 File Offset: 0x000AF870
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 641894, RefRangeEnd = 641895, XrefRangeStart = 641886, XrefRangeEnd = 641894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint3x3(float3x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr__ctor_Public_Void_float3x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002211 RID: 8721 RVA: 0x000B16A4 File Offset: 0x000AF8A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 641903, RefRangeEnd = 641904, XrefRangeStart = 641895, XrefRangeEnd = 641903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint3x3(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002212 RID: 8722 RVA: 0x000B16D8 File Offset: 0x000AF8D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 641912, RefRangeEnd = 641913, XrefRangeStart = 641904, XrefRangeEnd = 641912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint3x3(double3x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr__ctor_Public_Void_double3x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002213 RID: 8723 RVA: 0x000B170C File Offset: 0x000AF90C
		[CallerCount(0)]
		public unsafe static implicit operator uint3x3(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_Implicit_Public_Static_uint3x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002214 RID: 8724 RVA: 0x000B174C File Offset: 0x000AF94C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint3x3(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x3_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002215 RID: 8725 RVA: 0x000B178C File Offset: 0x000AF98C
		[CallerCount(0)]
		public unsafe static explicit operator uint3x3(bool3x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x3_bool3x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002216 RID: 8726 RVA: 0x000B17CC File Offset: 0x000AF9CC
		[CallerCount(0)]
		public unsafe static explicit operator uint3x3(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x3_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002217 RID: 8727 RVA: 0x000B180C File Offset: 0x000AFA0C
		[CallerCount(0)]
		public unsafe static explicit operator uint3x3(int3x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x3_int3x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002218 RID: 8728 RVA: 0x000B184C File Offset: 0x000AFA4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641913, XrefRangeEnd = 641914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint3x3(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x3_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002219 RID: 8729 RVA: 0x000B188C File Offset: 0x000AFA8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641914, XrefRangeEnd = 641915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint3x3(float3x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x3_float3x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600221A RID: 8730 RVA: 0x000B18CC File Offset: 0x000AFACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641915, XrefRangeEnd = 641916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint3x3(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x3_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600221B RID: 8731 RVA: 0x000B190C File Offset: 0x000AFB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641916, XrefRangeEnd = 641917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint3x3(double3x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x3_double3x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600221C RID: 8732 RVA: 0x000B194C File Offset: 0x000AFB4C
		[CallerCount(0)]
		public unsafe static uint3x3 operator *(uint3x3 lhs, uint3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_Multiply_Public_Static_uint3x3_uint3x3_uint3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600221D RID: 8733 RVA: 0x000B1998 File Offset: 0x000AFB98
		[CallerCount(0)]
		public unsafe static uint3x3 operator *(uint3x3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_Multiply_Public_Static_uint3x3_uint3x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600221E RID: 8734 RVA: 0x000B19E4 File Offset: 0x000AFBE4
		[CallerCount(0)]
		public unsafe static uint3x3 operator *(uint lhs, uint3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_Multiply_Public_Static_uint3x3_UInt32_uint3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600221F RID: 8735 RVA: 0x000B1A30 File Offset: 0x000AFC30
		[CallerCount(0)]
		public unsafe static uint3x3 operator +(uint3x3 lhs, uint3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_Addition_Public_Static_uint3x3_uint3x3_uint3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002220 RID: 8736 RVA: 0x000B1A7C File Offset: 0x000AFC7C
		[CallerCount(0)]
		public unsafe static uint3x3 operator +(uint3x3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_Addition_Public_Static_uint3x3_uint3x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002221 RID: 8737 RVA: 0x000B1AC8 File Offset: 0x000AFCC8
		[CallerCount(0)]
		public unsafe static uint3x3 operator +(uint lhs, uint3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_Addition_Public_Static_uint3x3_UInt32_uint3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002222 RID: 8738 RVA: 0x000B1B14 File Offset: 0x000AFD14
		[CallerCount(0)]
		public unsafe static uint3x3 operator -(uint3x3 lhs, uint3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint3x3_uint3x3_uint3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002223 RID: 8739 RVA: 0x000B1B60 File Offset: 0x000AFD60
		[CallerCount(0)]
		public unsafe static uint3x3 operator -(uint3x3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint3x3_uint3x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002224 RID: 8740 RVA: 0x000B1BAC File Offset: 0x000AFDAC
		[CallerCount(0)]
		public unsafe static uint3x3 operator -(uint lhs, uint3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint3x3_UInt32_uint3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002225 RID: 8741 RVA: 0x000B1BF8 File Offset: 0x000AFDF8
		[CallerCount(0)]
		public unsafe static uint3x3 operator /(uint3x3 lhs, uint3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_Division_Public_Static_uint3x3_uint3x3_uint3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002226 RID: 8742 RVA: 0x000B1C44 File Offset: 0x000AFE44
		[CallerCount(0)]
		public unsafe static uint3x3 operator /(uint3x3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_Division_Public_Static_uint3x3_uint3x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002227 RID: 8743 RVA: 0x000B1C90 File Offset: 0x000AFE90
		[CallerCount(0)]
		public unsafe static uint3x3 operator /(uint lhs, uint3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_Division_Public_Static_uint3x3_UInt32_uint3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002228 RID: 8744 RVA: 0x000B1CDC File Offset: 0x000AFEDC
		[CallerCount(0)]
		public unsafe static uint3x3 operator %(uint3x3 lhs, uint3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_Modulus_Public_Static_uint3x3_uint3x3_uint3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002229 RID: 8745 RVA: 0x000B1D28 File Offset: 0x000AFF28
		[CallerCount(0)]
		public unsafe static uint3x3 operator %(uint3x3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_Modulus_Public_Static_uint3x3_uint3x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600222A RID: 8746 RVA: 0x000B1D74 File Offset: 0x000AFF74
		[CallerCount(0)]
		public unsafe static uint3x3 operator %(uint lhs, uint3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_Modulus_Public_Static_uint3x3_UInt32_uint3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600222B RID: 8747 RVA: 0x000B1DC0 File Offset: 0x000AFFC0
		[CallerCount(0)]
		public unsafe static uint3x3 operator ++(uint3x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_Increment_Public_Static_uint3x3_uint3x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600222C RID: 8748 RVA: 0x000B1E00 File Offset: 0x000B0000
		[CallerCount(0)]
		public unsafe static uint3x3 operator --(uint3x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_Decrement_Public_Static_uint3x3_uint3x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600222D RID: 8749 RVA: 0x000B1E40 File Offset: 0x000B0040
		[CallerCount(0)]
		public unsafe static bool3x3 operator <(uint3x3 lhs, uint3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x3_uint3x3_uint3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600222E RID: 8750 RVA: 0x000B1E8C File Offset: 0x000B008C
		[CallerCount(0)]
		public unsafe static bool3x3 operator <(uint3x3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x3_uint3x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600222F RID: 8751 RVA: 0x000B1ED8 File Offset: 0x000B00D8
		[CallerCount(0)]
		public unsafe static bool3x3 operator <(uint lhs, uint3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x3_UInt32_uint3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002230 RID: 8752 RVA: 0x000B1F24 File Offset: 0x000B0124
		[CallerCount(0)]
		public unsafe static bool3x3 operator <=(uint3x3 lhs, uint3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x3_uint3x3_uint3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002231 RID: 8753 RVA: 0x000B1F70 File Offset: 0x000B0170
		[CallerCount(0)]
		public unsafe static bool3x3 operator <=(uint3x3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x3_uint3x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002232 RID: 8754 RVA: 0x000B1FBC File Offset: 0x000B01BC
		[CallerCount(0)]
		public unsafe static bool3x3 operator <=(uint lhs, uint3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x3_UInt32_uint3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002233 RID: 8755 RVA: 0x000B2008 File Offset: 0x000B0208
		[CallerCount(0)]
		public unsafe static bool3x3 operator >(uint3x3 lhs, uint3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x3_uint3x3_uint3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002234 RID: 8756 RVA: 0x000B2054 File Offset: 0x000B0254
		[CallerCount(0)]
		public unsafe static bool3x3 operator >(uint3x3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x3_uint3x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002235 RID: 8757 RVA: 0x000B20A0 File Offset: 0x000B02A0
		[CallerCount(0)]
		public unsafe static bool3x3 operator >(uint lhs, uint3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x3_UInt32_uint3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002236 RID: 8758 RVA: 0x000B20EC File Offset: 0x000B02EC
		[CallerCount(0)]
		public unsafe static bool3x3 operator >=(uint3x3 lhs, uint3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x3_uint3x3_uint3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002237 RID: 8759 RVA: 0x000B2138 File Offset: 0x000B0338
		[CallerCount(0)]
		public unsafe static bool3x3 operator >=(uint3x3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x3_uint3x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002238 RID: 8760 RVA: 0x000B2184 File Offset: 0x000B0384
		[CallerCount(0)]
		public unsafe static bool3x3 operator >=(uint lhs, uint3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x3_UInt32_uint3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002239 RID: 8761 RVA: 0x000B21D0 File Offset: 0x000B03D0
		[CallerCount(0)]
		public unsafe static uint3x3 operator -(uint3x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_uint3x3_uint3x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600223A RID: 8762 RVA: 0x000B2210 File Offset: 0x000B0410
		[CallerCount(0)]
		public unsafe static uint3x3 operator +(uint3x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_uint3x3_uint3x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600223B RID: 8763 RVA: 0x000B2250 File Offset: 0x000B0450
		[CallerCount(0)]
		public unsafe static uint3x3 operator <<(uint3x3 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_LeftShift_Public_Static_uint3x3_uint3x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600223C RID: 8764 RVA: 0x000B229C File Offset: 0x000B049C
		[CallerCount(0)]
		public unsafe static uint3x3 operator >>(uint3x3 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_RightShift_Public_Static_uint3x3_uint3x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600223D RID: 8765 RVA: 0x000B22E8 File Offset: 0x000B04E8
		[CallerCount(0)]
		public unsafe static bool3x3 operator ==(uint3x3 lhs, uint3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_uint3x3_uint3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600223E RID: 8766 RVA: 0x000B2334 File Offset: 0x000B0534
		[CallerCount(0)]
		public unsafe static bool3x3 operator ==(uint3x3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_uint3x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600223F RID: 8767 RVA: 0x000B2380 File Offset: 0x000B0580
		[CallerCount(0)]
		public unsafe static bool3x3 operator ==(uint lhs, uint3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_UInt32_uint3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002240 RID: 8768 RVA: 0x000B23CC File Offset: 0x000B05CC
		[CallerCount(0)]
		public unsafe static bool3x3 operator !=(uint3x3 lhs, uint3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_uint3x3_uint3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002241 RID: 8769 RVA: 0x000B2418 File Offset: 0x000B0618
		[CallerCount(0)]
		public unsafe static bool3x3 operator !=(uint3x3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_uint3x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002242 RID: 8770 RVA: 0x000B2464 File Offset: 0x000B0664
		[CallerCount(0)]
		public unsafe static bool3x3 operator !=(uint lhs, uint3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_UInt32_uint3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002243 RID: 8771 RVA: 0x000B24B0 File Offset: 0x000B06B0
		[CallerCount(0)]
		public unsafe static uint3x3 operator ~(uint3x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_OnesComplement_Public_Static_uint3x3_uint3x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002244 RID: 8772 RVA: 0x000B24F0 File Offset: 0x000B06F0
		[CallerCount(0)]
		public unsafe static uint3x3 operator &(uint3x3 lhs, uint3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint3x3_uint3x3_uint3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002245 RID: 8773 RVA: 0x000B253C File Offset: 0x000B073C
		[CallerCount(0)]
		public unsafe static uint3x3 operator &(uint3x3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint3x3_uint3x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002246 RID: 8774 RVA: 0x000B2588 File Offset: 0x000B0788
		[CallerCount(0)]
		public unsafe static uint3x3 operator &(uint lhs, uint3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint3x3_UInt32_uint3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002247 RID: 8775 RVA: 0x000B25D4 File Offset: 0x000B07D4
		[CallerCount(0)]
		public unsafe static uint3x3 operator |(uint3x3 lhs, uint3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint3x3_uint3x3_uint3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002248 RID: 8776 RVA: 0x000B2620 File Offset: 0x000B0820
		[CallerCount(0)]
		public unsafe static uint3x3 operator |(uint3x3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint3x3_uint3x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002249 RID: 8777 RVA: 0x000B266C File Offset: 0x000B086C
		[CallerCount(0)]
		public unsafe static uint3x3 operator |(uint lhs, uint3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint3x3_UInt32_uint3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600224A RID: 8778 RVA: 0x000B26B8 File Offset: 0x000B08B8
		[CallerCount(0)]
		public unsafe static uint3x3 operator ^(uint3x3 lhs, uint3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint3x3_uint3x3_uint3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600224B RID: 8779 RVA: 0x000B2704 File Offset: 0x000B0904
		[CallerCount(0)]
		public unsafe static uint3x3 operator ^(uint3x3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint3x3_uint3x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600224C RID: 8780 RVA: 0x000B2750 File Offset: 0x000B0950
		[CallerCount(0)]
		public unsafe static uint3x3 operator ^(uint lhs, uint3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint3x3_UInt32_uint3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000A86 RID: 2694
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_get_Item_Public_get_byref_uint3_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x0600224E RID: 8782 RVA: 0x000B27D0 File Offset: 0x000B09D0
		[CallerCount(0)]
		public unsafe bool Equals(uint3x3 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_uint3x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600224F RID: 8783 RVA: 0x000B2810 File Offset: 0x000B0A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641917, XrefRangeEnd = 641920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002250 RID: 8784 RVA: 0x000B2854 File Offset: 0x000B0A54
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002251 RID: 8785 RVA: 0x000B2884 File Offset: 0x000B0A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641920, XrefRangeEnd = 641963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002252 RID: 8786 RVA: 0x000B28B0 File Offset: 0x000B0AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641963, XrefRangeEnd = 642018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x3.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002253 RID: 8787 RVA: 0x000029DB File Offset: 0x00000BDB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<uint3x3>.NativeClassPtr, ref this));
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x06002254 RID: 8788 RVA: 0x000B2900 File Offset: 0x000B0B00
		// (set) Token: 0x06002255 RID: 8789 RVA: 0x000029ED File Offset: 0x00000BED
		public unsafe static uint3x3 identity
		{
			get
			{
				uint3x3 uint3x;
				IL2CPP.il2cpp_field_static_get_value(uint3x3.NativeFieldInfoPtr_identity, (void*)(&uint3x));
				return uint3x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(uint3x3.NativeFieldInfoPtr_identity, (void*)(&value));
			}
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x06002256 RID: 8790 RVA: 0x000B291C File Offset: 0x000B0B1C
		// (set) Token: 0x06002257 RID: 8791 RVA: 0x000029FB File Offset: 0x00000BFB
		public unsafe static uint3x3 zero
		{
			get
			{
				uint3x3 uint3x;
				IL2CPP.il2cpp_field_static_get_value(uint3x3.NativeFieldInfoPtr_zero, (void*)(&uint3x));
				return uint3x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(uint3x3.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x0400228D RID: 8845
		private static readonly IntPtr NativeFieldInfoPtr_c0;

		// Token: 0x0400228E RID: 8846
		private static readonly IntPtr NativeFieldInfoPtr_c1;

		// Token: 0x0400228F RID: 8847
		private static readonly IntPtr NativeFieldInfoPtr_c2;

		// Token: 0x04002290 RID: 8848
		private static readonly IntPtr NativeFieldInfoPtr_identity;

		// Token: 0x04002291 RID: 8849
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x04002292 RID: 8850
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint3_uint3_uint3_0;

		// Token: 0x04002293 RID: 8851
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_0;

		// Token: 0x04002294 RID: 8852
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04002295 RID: 8853
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04002296 RID: 8854
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool3x3_0;

		// Token: 0x04002297 RID: 8855
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04002298 RID: 8856
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int3x3_0;

		// Token: 0x04002299 RID: 8857
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x0400229A RID: 8858
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float3x3_0;

		// Token: 0x0400229B RID: 8859
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x0400229C RID: 8860
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double3x3_0;

		// Token: 0x0400229D RID: 8861
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_uint3x3_UInt32_0;

		// Token: 0x0400229E RID: 8862
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x3_Boolean_0;

		// Token: 0x0400229F RID: 8863
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x3_bool3x3_0;

		// Token: 0x040022A0 RID: 8864
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x3_Int32_0;

		// Token: 0x040022A1 RID: 8865
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x3_int3x3_0;

		// Token: 0x040022A2 RID: 8866
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x3_Single_0;

		// Token: 0x040022A3 RID: 8867
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x3_float3x3_0;

		// Token: 0x040022A4 RID: 8868
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x3_Double_0;

		// Token: 0x040022A5 RID: 8869
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x3_double3x3_0;

		// Token: 0x040022A6 RID: 8870
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_uint3x3_uint3x3_uint3x3_0;

		// Token: 0x040022A7 RID: 8871
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_uint3x3_uint3x3_UInt32_0;

		// Token: 0x040022A8 RID: 8872
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_uint3x3_UInt32_uint3x3_0;

		// Token: 0x040022A9 RID: 8873
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_uint3x3_uint3x3_uint3x3_0;

		// Token: 0x040022AA RID: 8874
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_uint3x3_uint3x3_UInt32_0;

		// Token: 0x040022AB RID: 8875
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_uint3x3_UInt32_uint3x3_0;

		// Token: 0x040022AC RID: 8876
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_uint3x3_uint3x3_uint3x3_0;

		// Token: 0x040022AD RID: 8877
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_uint3x3_uint3x3_UInt32_0;

		// Token: 0x040022AE RID: 8878
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_uint3x3_UInt32_uint3x3_0;

		// Token: 0x040022AF RID: 8879
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_uint3x3_uint3x3_uint3x3_0;

		// Token: 0x040022B0 RID: 8880
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_uint3x3_uint3x3_UInt32_0;

		// Token: 0x040022B1 RID: 8881
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_uint3x3_UInt32_uint3x3_0;

		// Token: 0x040022B2 RID: 8882
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_uint3x3_uint3x3_uint3x3_0;

		// Token: 0x040022B3 RID: 8883
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_uint3x3_uint3x3_UInt32_0;

		// Token: 0x040022B4 RID: 8884
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_uint3x3_UInt32_uint3x3_0;

		// Token: 0x040022B5 RID: 8885
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_uint3x3_uint3x3_0;

		// Token: 0x040022B6 RID: 8886
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_uint3x3_uint3x3_0;

		// Token: 0x040022B7 RID: 8887
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x3_uint3x3_uint3x3_0;

		// Token: 0x040022B8 RID: 8888
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x3_uint3x3_UInt32_0;

		// Token: 0x040022B9 RID: 8889
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x3_UInt32_uint3x3_0;

		// Token: 0x040022BA RID: 8890
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x3_uint3x3_uint3x3_0;

		// Token: 0x040022BB RID: 8891
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x3_uint3x3_UInt32_0;

		// Token: 0x040022BC RID: 8892
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x3_UInt32_uint3x3_0;

		// Token: 0x040022BD RID: 8893
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x3_uint3x3_uint3x3_0;

		// Token: 0x040022BE RID: 8894
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x3_uint3x3_UInt32_0;

		// Token: 0x040022BF RID: 8895
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x3_UInt32_uint3x3_0;

		// Token: 0x040022C0 RID: 8896
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x3_uint3x3_uint3x3_0;

		// Token: 0x040022C1 RID: 8897
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x3_uint3x3_UInt32_0;

		// Token: 0x040022C2 RID: 8898
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x3_UInt32_uint3x3_0;

		// Token: 0x040022C3 RID: 8899
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_uint3x3_uint3x3_0;

		// Token: 0x040022C4 RID: 8900
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryPlus_Public_Static_uint3x3_uint3x3_0;

		// Token: 0x040022C5 RID: 8901
		private static readonly IntPtr NativeMethodInfoPtr_op_LeftShift_Public_Static_uint3x3_uint3x3_Int32_0;

		// Token: 0x040022C6 RID: 8902
		private static readonly IntPtr NativeMethodInfoPtr_op_RightShift_Public_Static_uint3x3_uint3x3_Int32_0;

		// Token: 0x040022C7 RID: 8903
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_uint3x3_uint3x3_0;

		// Token: 0x040022C8 RID: 8904
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_uint3x3_UInt32_0;

		// Token: 0x040022C9 RID: 8905
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_UInt32_uint3x3_0;

		// Token: 0x040022CA RID: 8906
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_uint3x3_uint3x3_0;

		// Token: 0x040022CB RID: 8907
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_uint3x3_UInt32_0;

		// Token: 0x040022CC RID: 8908
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_UInt32_uint3x3_0;

		// Token: 0x040022CD RID: 8909
		private static readonly IntPtr NativeMethodInfoPtr_op_OnesComplement_Public_Static_uint3x3_uint3x3_0;

		// Token: 0x040022CE RID: 8910
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint3x3_uint3x3_uint3x3_0;

		// Token: 0x040022CF RID: 8911
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint3x3_uint3x3_UInt32_0;

		// Token: 0x040022D0 RID: 8912
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint3x3_UInt32_uint3x3_0;

		// Token: 0x040022D1 RID: 8913
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint3x3_uint3x3_uint3x3_0;

		// Token: 0x040022D2 RID: 8914
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint3x3_uint3x3_UInt32_0;

		// Token: 0x040022D3 RID: 8915
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint3x3_UInt32_uint3x3_0;

		// Token: 0x040022D4 RID: 8916
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint3x3_uint3x3_uint3x3_0;

		// Token: 0x040022D5 RID: 8917
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint3x3_uint3x3_UInt32_0;

		// Token: 0x040022D6 RID: 8918
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint3x3_UInt32_uint3x3_0;

		// Token: 0x040022D7 RID: 8919
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_uint3_Int32_0;

		// Token: 0x040022D8 RID: 8920
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_uint3x3_0;

		// Token: 0x040022D9 RID: 8921
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040022DA RID: 8922
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040022DB RID: 8923
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040022DC RID: 8924
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x040022DD RID: 8925
		[FieldOffset(0)]
		public uint3 c0;

		// Token: 0x040022DE RID: 8926
		[FieldOffset(12)]
		public uint3 c1;

		// Token: 0x040022DF RID: 8927
		[FieldOffset(24)]
		public uint3 c2;
	}
}
