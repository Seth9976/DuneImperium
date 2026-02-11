using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x02000044 RID: 68
	[Serializable]
	[StructLayout(2)]
	public struct uint3x2
	{
		// Token: 0x060021B8 RID: 8632 RVA: 0x000AF2F0 File Offset: 0x000AD4F0
		// Note: this type is marked as 'beforefieldinit'.
		static uint3x2()
		{
			Il2CppClassPointerStore<uint3x2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "uint3x2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<uint3x2>.NativeClassPtr);
			uint3x2.NativeFieldInfoPtr_c0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, "c0");
			uint3x2.NativeFieldInfoPtr_c1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, "c1");
			uint3x2.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, "zero");
			uint3x2.NativeMethodInfoPtr__ctor_Public_Void_uint3_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671668);
			uint3x2.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671669);
			uint3x2.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671670);
			uint3x2.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671671);
			uint3x2.NativeMethodInfoPtr__ctor_Public_Void_bool3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671672);
			uint3x2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671673);
			uint3x2.NativeMethodInfoPtr__ctor_Public_Void_int3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671674);
			uint3x2.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671675);
			uint3x2.NativeMethodInfoPtr__ctor_Public_Void_float3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671676);
			uint3x2.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671677);
			uint3x2.NativeMethodInfoPtr__ctor_Public_Void_double3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671678);
			uint3x2.NativeMethodInfoPtr_op_Implicit_Public_Static_uint3x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671679);
			uint3x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671680);
			uint3x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x2_bool3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671681);
			uint3x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671682);
			uint3x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x2_int3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671683);
			uint3x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671684);
			uint3x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x2_float3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671685);
			uint3x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x2_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671686);
			uint3x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x2_double3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671687);
			uint3x2.NativeMethodInfoPtr_op_Multiply_Public_Static_uint3x2_uint3x2_uint3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671688);
			uint3x2.NativeMethodInfoPtr_op_Multiply_Public_Static_uint3x2_uint3x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671689);
			uint3x2.NativeMethodInfoPtr_op_Multiply_Public_Static_uint3x2_UInt32_uint3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671690);
			uint3x2.NativeMethodInfoPtr_op_Addition_Public_Static_uint3x2_uint3x2_uint3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671691);
			uint3x2.NativeMethodInfoPtr_op_Addition_Public_Static_uint3x2_uint3x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671692);
			uint3x2.NativeMethodInfoPtr_op_Addition_Public_Static_uint3x2_UInt32_uint3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671693);
			uint3x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint3x2_uint3x2_uint3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671694);
			uint3x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint3x2_uint3x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671695);
			uint3x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint3x2_UInt32_uint3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671696);
			uint3x2.NativeMethodInfoPtr_op_Division_Public_Static_uint3x2_uint3x2_uint3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671697);
			uint3x2.NativeMethodInfoPtr_op_Division_Public_Static_uint3x2_uint3x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671698);
			uint3x2.NativeMethodInfoPtr_op_Division_Public_Static_uint3x2_UInt32_uint3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671699);
			uint3x2.NativeMethodInfoPtr_op_Modulus_Public_Static_uint3x2_uint3x2_uint3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671700);
			uint3x2.NativeMethodInfoPtr_op_Modulus_Public_Static_uint3x2_uint3x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671701);
			uint3x2.NativeMethodInfoPtr_op_Modulus_Public_Static_uint3x2_UInt32_uint3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671702);
			uint3x2.NativeMethodInfoPtr_op_Increment_Public_Static_uint3x2_uint3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671703);
			uint3x2.NativeMethodInfoPtr_op_Decrement_Public_Static_uint3x2_uint3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671704);
			uint3x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x2_uint3x2_uint3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671705);
			uint3x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x2_uint3x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671706);
			uint3x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x2_UInt32_uint3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671707);
			uint3x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x2_uint3x2_uint3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671708);
			uint3x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x2_uint3x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671709);
			uint3x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x2_UInt32_uint3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671710);
			uint3x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x2_uint3x2_uint3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671711);
			uint3x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x2_uint3x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671712);
			uint3x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x2_UInt32_uint3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671713);
			uint3x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x2_uint3x2_uint3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671714);
			uint3x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x2_uint3x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671715);
			uint3x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x2_UInt32_uint3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671716);
			uint3x2.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_uint3x2_uint3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671717);
			uint3x2.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_uint3x2_uint3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671718);
			uint3x2.NativeMethodInfoPtr_op_LeftShift_Public_Static_uint3x2_uint3x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671719);
			uint3x2.NativeMethodInfoPtr_op_RightShift_Public_Static_uint3x2_uint3x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671720);
			uint3x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x2_uint3x2_uint3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671721);
			uint3x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x2_uint3x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671722);
			uint3x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x2_UInt32_uint3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671723);
			uint3x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x2_uint3x2_uint3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671724);
			uint3x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x2_uint3x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671725);
			uint3x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x2_UInt32_uint3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671726);
			uint3x2.NativeMethodInfoPtr_op_OnesComplement_Public_Static_uint3x2_uint3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671727);
			uint3x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint3x2_uint3x2_uint3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671728);
			uint3x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint3x2_uint3x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671729);
			uint3x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint3x2_UInt32_uint3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671730);
			uint3x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint3x2_uint3x2_uint3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671731);
			uint3x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint3x2_uint3x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671732);
			uint3x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint3x2_UInt32_uint3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671733);
			uint3x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint3x2_uint3x2_uint3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671734);
			uint3x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint3x2_uint3x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671735);
			uint3x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint3x2_UInt32_uint3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671736);
			uint3x2.NativeMethodInfoPtr_get_Item_Public_get_byref_uint3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671737);
			uint3x2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_uint3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671738);
			uint3x2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671739);
			uint3x2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671740);
			uint3x2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671741);
			uint3x2.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, 100671742);
		}

		// Token: 0x060021B9 RID: 8633 RVA: 0x000AF938 File Offset: 0x000ADB38
		[CallerCount(0)]
		public unsafe uint3x2(uint3 c0, uint3 c1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr__ctor_Public_Void_uint3_uint3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021BA RID: 8634 RVA: 0x000AF978 File Offset: 0x000ADB78
		[CallerCount(0)]
		public unsafe uint3x2(uint m00, uint m01, uint m10, uint m11, uint m20, uint m21)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref m00;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m01;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m10;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m11;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m20;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m21;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021BB RID: 8635 RVA: 0x000AF9F0 File Offset: 0x000ADBF0
		[CallerCount(0)]
		public unsafe uint3x2(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021BC RID: 8636 RVA: 0x000AFA24 File Offset: 0x000ADC24
		[CallerCount(0)]
		public unsafe uint3x2(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021BD RID: 8637 RVA: 0x000AFA58 File Offset: 0x000ADC58
		[CallerCount(0)]
		public unsafe uint3x2(bool3x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr__ctor_Public_Void_bool3x2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021BE RID: 8638 RVA: 0x000AFA8C File Offset: 0x000ADC8C
		[CallerCount(0)]
		public unsafe uint3x2(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021BF RID: 8639 RVA: 0x000AFAC0 File Offset: 0x000ADCC0
		[CallerCount(0)]
		public unsafe uint3x2(int3x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr__ctor_Public_Void_int3x2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021C0 RID: 8640 RVA: 0x000AFAF4 File Offset: 0x000ADCF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 641782, RefRangeEnd = 641783, XrefRangeStart = 641777, XrefRangeEnd = 641782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint3x2(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021C1 RID: 8641 RVA: 0x000AFB28 File Offset: 0x000ADD28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 641788, RefRangeEnd = 641789, XrefRangeStart = 641783, XrefRangeEnd = 641788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint3x2(float3x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr__ctor_Public_Void_float3x2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021C2 RID: 8642 RVA: 0x000AFB5C File Offset: 0x000ADD5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 641794, RefRangeEnd = 641795, XrefRangeStart = 641789, XrefRangeEnd = 641794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint3x2(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021C3 RID: 8643 RVA: 0x000AFB90 File Offset: 0x000ADD90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 641800, RefRangeEnd = 641801, XrefRangeStart = 641795, XrefRangeEnd = 641800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint3x2(double3x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr__ctor_Public_Void_double3x2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021C4 RID: 8644 RVA: 0x000AFBC4 File Offset: 0x000ADDC4
		[CallerCount(0)]
		public unsafe static implicit operator uint3x2(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_Implicit_Public_Static_uint3x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021C5 RID: 8645 RVA: 0x000AFC04 File Offset: 0x000ADE04
		[CallerCount(0)]
		public unsafe static explicit operator uint3x2(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x2_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021C6 RID: 8646 RVA: 0x000AFC44 File Offset: 0x000ADE44
		[CallerCount(0)]
		public unsafe static explicit operator uint3x2(bool3x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x2_bool3x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021C7 RID: 8647 RVA: 0x000AFC84 File Offset: 0x000ADE84
		[CallerCount(0)]
		public unsafe static explicit operator uint3x2(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x2_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021C8 RID: 8648 RVA: 0x000AFCC4 File Offset: 0x000ADEC4
		[CallerCount(0)]
		public unsafe static explicit operator uint3x2(int3x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x2_int3x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021C9 RID: 8649 RVA: 0x000AFD04 File Offset: 0x000ADF04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641801, XrefRangeEnd = 641802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint3x2(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x2_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021CA RID: 8650 RVA: 0x000AFD44 File Offset: 0x000ADF44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641802, XrefRangeEnd = 641803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint3x2(float3x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x2_float3x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x000AFD84 File Offset: 0x000ADF84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641803, XrefRangeEnd = 641804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint3x2(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x2_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021CC RID: 8652 RVA: 0x000AFDC4 File Offset: 0x000ADFC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641804, XrefRangeEnd = 641805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint3x2(double3x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x2_double3x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021CD RID: 8653 RVA: 0x000AFE04 File Offset: 0x000AE004
		[CallerCount(0)]
		public unsafe static uint3x2 operator *(uint3x2 lhs, uint3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_Multiply_Public_Static_uint3x2_uint3x2_uint3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021CE RID: 8654 RVA: 0x000AFE50 File Offset: 0x000AE050
		[CallerCount(0)]
		public unsafe static uint3x2 operator *(uint3x2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_Multiply_Public_Static_uint3x2_uint3x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021CF RID: 8655 RVA: 0x000AFE9C File Offset: 0x000AE09C
		[CallerCount(0)]
		public unsafe static uint3x2 operator *(uint lhs, uint3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_Multiply_Public_Static_uint3x2_UInt32_uint3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021D0 RID: 8656 RVA: 0x000AFEE8 File Offset: 0x000AE0E8
		[CallerCount(0)]
		public unsafe static uint3x2 operator +(uint3x2 lhs, uint3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_Addition_Public_Static_uint3x2_uint3x2_uint3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021D1 RID: 8657 RVA: 0x000AFF34 File Offset: 0x000AE134
		[CallerCount(0)]
		public unsafe static uint3x2 operator +(uint3x2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_Addition_Public_Static_uint3x2_uint3x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021D2 RID: 8658 RVA: 0x000AFF80 File Offset: 0x000AE180
		[CallerCount(0)]
		public unsafe static uint3x2 operator +(uint lhs, uint3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_Addition_Public_Static_uint3x2_UInt32_uint3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021D3 RID: 8659 RVA: 0x000AFFCC File Offset: 0x000AE1CC
		[CallerCount(0)]
		public unsafe static uint3x2 operator -(uint3x2 lhs, uint3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint3x2_uint3x2_uint3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021D4 RID: 8660 RVA: 0x000B0018 File Offset: 0x000AE218
		[CallerCount(0)]
		public unsafe static uint3x2 operator -(uint3x2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint3x2_uint3x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021D5 RID: 8661 RVA: 0x000B0064 File Offset: 0x000AE264
		[CallerCount(0)]
		public unsafe static uint3x2 operator -(uint lhs, uint3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint3x2_UInt32_uint3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021D6 RID: 8662 RVA: 0x000B00B0 File Offset: 0x000AE2B0
		[CallerCount(0)]
		public unsafe static uint3x2 operator /(uint3x2 lhs, uint3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_Division_Public_Static_uint3x2_uint3x2_uint3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021D7 RID: 8663 RVA: 0x000B00FC File Offset: 0x000AE2FC
		[CallerCount(0)]
		public unsafe static uint3x2 operator /(uint3x2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_Division_Public_Static_uint3x2_uint3x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021D8 RID: 8664 RVA: 0x000B0148 File Offset: 0x000AE348
		[CallerCount(0)]
		public unsafe static uint3x2 operator /(uint lhs, uint3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_Division_Public_Static_uint3x2_UInt32_uint3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021D9 RID: 8665 RVA: 0x000B0194 File Offset: 0x000AE394
		[CallerCount(0)]
		public unsafe static uint3x2 operator %(uint3x2 lhs, uint3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_Modulus_Public_Static_uint3x2_uint3x2_uint3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021DA RID: 8666 RVA: 0x000B01E0 File Offset: 0x000AE3E0
		[CallerCount(0)]
		public unsafe static uint3x2 operator %(uint3x2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_Modulus_Public_Static_uint3x2_uint3x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021DB RID: 8667 RVA: 0x000B022C File Offset: 0x000AE42C
		[CallerCount(0)]
		public unsafe static uint3x2 operator %(uint lhs, uint3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_Modulus_Public_Static_uint3x2_UInt32_uint3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021DC RID: 8668 RVA: 0x000B0278 File Offset: 0x000AE478
		[CallerCount(0)]
		public unsafe static uint3x2 operator ++(uint3x2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_Increment_Public_Static_uint3x2_uint3x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021DD RID: 8669 RVA: 0x000B02B8 File Offset: 0x000AE4B8
		[CallerCount(0)]
		public unsafe static uint3x2 operator --(uint3x2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_Decrement_Public_Static_uint3x2_uint3x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021DE RID: 8670 RVA: 0x000B02F8 File Offset: 0x000AE4F8
		[CallerCount(0)]
		public unsafe static bool3x2 operator <(uint3x2 lhs, uint3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x2_uint3x2_uint3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021DF RID: 8671 RVA: 0x000B0344 File Offset: 0x000AE544
		[CallerCount(0)]
		public unsafe static bool3x2 operator <(uint3x2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x2_uint3x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021E0 RID: 8672 RVA: 0x000B0390 File Offset: 0x000AE590
		[CallerCount(0)]
		public unsafe static bool3x2 operator <(uint lhs, uint3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x2_UInt32_uint3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021E1 RID: 8673 RVA: 0x000B03DC File Offset: 0x000AE5DC
		[CallerCount(0)]
		public unsafe static bool3x2 operator <=(uint3x2 lhs, uint3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x2_uint3x2_uint3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021E2 RID: 8674 RVA: 0x000B0428 File Offset: 0x000AE628
		[CallerCount(0)]
		public unsafe static bool3x2 operator <=(uint3x2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x2_uint3x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021E3 RID: 8675 RVA: 0x000B0474 File Offset: 0x000AE674
		[CallerCount(0)]
		public unsafe static bool3x2 operator <=(uint lhs, uint3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x2_UInt32_uint3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021E4 RID: 8676 RVA: 0x000B04C0 File Offset: 0x000AE6C0
		[CallerCount(0)]
		public unsafe static bool3x2 operator >(uint3x2 lhs, uint3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x2_uint3x2_uint3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021E5 RID: 8677 RVA: 0x000B050C File Offset: 0x000AE70C
		[CallerCount(0)]
		public unsafe static bool3x2 operator >(uint3x2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x2_uint3x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021E6 RID: 8678 RVA: 0x000B0558 File Offset: 0x000AE758
		[CallerCount(0)]
		public unsafe static bool3x2 operator >(uint lhs, uint3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x2_UInt32_uint3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021E7 RID: 8679 RVA: 0x000B05A4 File Offset: 0x000AE7A4
		[CallerCount(0)]
		public unsafe static bool3x2 operator >=(uint3x2 lhs, uint3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x2_uint3x2_uint3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021E8 RID: 8680 RVA: 0x000B05F0 File Offset: 0x000AE7F0
		[CallerCount(0)]
		public unsafe static bool3x2 operator >=(uint3x2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x2_uint3x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021E9 RID: 8681 RVA: 0x000B063C File Offset: 0x000AE83C
		[CallerCount(0)]
		public unsafe static bool3x2 operator >=(uint lhs, uint3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x2_UInt32_uint3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021EA RID: 8682 RVA: 0x000B0688 File Offset: 0x000AE888
		[CallerCount(0)]
		public unsafe static uint3x2 operator -(uint3x2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_uint3x2_uint3x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021EB RID: 8683 RVA: 0x000B06C8 File Offset: 0x000AE8C8
		[CallerCount(0)]
		public unsafe static uint3x2 operator +(uint3x2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_uint3x2_uint3x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021EC RID: 8684 RVA: 0x000B0708 File Offset: 0x000AE908
		[CallerCount(0)]
		public unsafe static uint3x2 operator <<(uint3x2 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_LeftShift_Public_Static_uint3x2_uint3x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021ED RID: 8685 RVA: 0x000B0754 File Offset: 0x000AE954
		[CallerCount(0)]
		public unsafe static uint3x2 operator >>(uint3x2 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_RightShift_Public_Static_uint3x2_uint3x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021EE RID: 8686 RVA: 0x000B07A0 File Offset: 0x000AE9A0
		[CallerCount(0)]
		public unsafe static bool3x2 operator ==(uint3x2 lhs, uint3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x2_uint3x2_uint3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021EF RID: 8687 RVA: 0x000B07EC File Offset: 0x000AE9EC
		[CallerCount(0)]
		public unsafe static bool3x2 operator ==(uint3x2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x2_uint3x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021F0 RID: 8688 RVA: 0x000B0838 File Offset: 0x000AEA38
		[CallerCount(0)]
		public unsafe static bool3x2 operator ==(uint lhs, uint3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x2_UInt32_uint3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021F1 RID: 8689 RVA: 0x000B0884 File Offset: 0x000AEA84
		[CallerCount(0)]
		public unsafe static bool3x2 operator !=(uint3x2 lhs, uint3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x2_uint3x2_uint3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021F2 RID: 8690 RVA: 0x000B08D0 File Offset: 0x000AEAD0
		[CallerCount(0)]
		public unsafe static bool3x2 operator !=(uint3x2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x2_uint3x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021F3 RID: 8691 RVA: 0x000B091C File Offset: 0x000AEB1C
		[CallerCount(0)]
		public unsafe static bool3x2 operator !=(uint lhs, uint3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x2_UInt32_uint3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021F4 RID: 8692 RVA: 0x000B0968 File Offset: 0x000AEB68
		[CallerCount(0)]
		public unsafe static uint3x2 operator ~(uint3x2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_OnesComplement_Public_Static_uint3x2_uint3x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021F5 RID: 8693 RVA: 0x000B09A8 File Offset: 0x000AEBA8
		[CallerCount(0)]
		public unsafe static uint3x2 operator &(uint3x2 lhs, uint3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint3x2_uint3x2_uint3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021F6 RID: 8694 RVA: 0x000B09F4 File Offset: 0x000AEBF4
		[CallerCount(0)]
		public unsafe static uint3x2 operator &(uint3x2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint3x2_uint3x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021F7 RID: 8695 RVA: 0x000B0A40 File Offset: 0x000AEC40
		[CallerCount(0)]
		public unsafe static uint3x2 operator &(uint lhs, uint3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint3x2_UInt32_uint3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021F8 RID: 8696 RVA: 0x000B0A8C File Offset: 0x000AEC8C
		[CallerCount(0)]
		public unsafe static uint3x2 operator |(uint3x2 lhs, uint3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint3x2_uint3x2_uint3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021F9 RID: 8697 RVA: 0x000B0AD8 File Offset: 0x000AECD8
		[CallerCount(0)]
		public unsafe static uint3x2 operator |(uint3x2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint3x2_uint3x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021FA RID: 8698 RVA: 0x000B0B24 File Offset: 0x000AED24
		[CallerCount(0)]
		public unsafe static uint3x2 operator |(uint lhs, uint3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint3x2_UInt32_uint3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021FB RID: 8699 RVA: 0x000B0B70 File Offset: 0x000AED70
		[CallerCount(0)]
		public unsafe static uint3x2 operator ^(uint3x2 lhs, uint3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint3x2_uint3x2_uint3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021FC RID: 8700 RVA: 0x000B0BBC File Offset: 0x000AEDBC
		[CallerCount(0)]
		public unsafe static uint3x2 operator ^(uint3x2 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint3x2_uint3x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021FD RID: 8701 RVA: 0x000B0C08 File Offset: 0x000AEE08
		[CallerCount(0)]
		public unsafe static uint3x2 operator ^(uint lhs, uint3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint3x2_UInt32_uint3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000A83 RID: 2691
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_get_Item_Public_get_byref_uint3_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x060021FF RID: 8703 RVA: 0x000B0C88 File Offset: 0x000AEE88
		[CallerCount(0)]
		public unsafe bool Equals(uint3x2 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_uint3x2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002200 RID: 8704 RVA: 0x000B0CC8 File Offset: 0x000AEEC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641805, XrefRangeEnd = 641808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002201 RID: 8705 RVA: 0x000B0D0C File Offset: 0x000AEF0C
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002202 RID: 8706 RVA: 0x000B0D3C File Offset: 0x000AEF3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641808, XrefRangeEnd = 641839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002203 RID: 8707 RVA: 0x000B0D68 File Offset: 0x000AEF68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641839, XrefRangeEnd = 641877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3x2.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002204 RID: 8708 RVA: 0x000029BB File Offset: 0x00000BBB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<uint3x2>.NativeClassPtr, ref this));
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x06002205 RID: 8709 RVA: 0x000B0DB8 File Offset: 0x000AEFB8
		// (set) Token: 0x06002206 RID: 8710 RVA: 0x000029CD File Offset: 0x00000BCD
		public unsafe static uint3x2 zero
		{
			get
			{
				uint3x2 uint3x;
				IL2CPP.il2cpp_field_static_get_value(uint3x2.NativeFieldInfoPtr_zero, (void*)(&uint3x));
				return uint3x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(uint3x2.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x0400223D RID: 8765
		private static readonly IntPtr NativeFieldInfoPtr_c0;

		// Token: 0x0400223E RID: 8766
		private static readonly IntPtr NativeFieldInfoPtr_c1;

		// Token: 0x0400223F RID: 8767
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x04002240 RID: 8768
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint3_uint3_0;

		// Token: 0x04002241 RID: 8769
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_0;

		// Token: 0x04002242 RID: 8770
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04002243 RID: 8771
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04002244 RID: 8772
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool3x2_0;

		// Token: 0x04002245 RID: 8773
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04002246 RID: 8774
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int3x2_0;

		// Token: 0x04002247 RID: 8775
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x04002248 RID: 8776
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float3x2_0;

		// Token: 0x04002249 RID: 8777
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x0400224A RID: 8778
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double3x2_0;

		// Token: 0x0400224B RID: 8779
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_uint3x2_UInt32_0;

		// Token: 0x0400224C RID: 8780
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x2_Boolean_0;

		// Token: 0x0400224D RID: 8781
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x2_bool3x2_0;

		// Token: 0x0400224E RID: 8782
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x2_Int32_0;

		// Token: 0x0400224F RID: 8783
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x2_int3x2_0;

		// Token: 0x04002250 RID: 8784
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x2_Single_0;

		// Token: 0x04002251 RID: 8785
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x2_float3x2_0;

		// Token: 0x04002252 RID: 8786
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x2_Double_0;

		// Token: 0x04002253 RID: 8787
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint3x2_double3x2_0;

		// Token: 0x04002254 RID: 8788
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_uint3x2_uint3x2_uint3x2_0;

		// Token: 0x04002255 RID: 8789
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_uint3x2_uint3x2_UInt32_0;

		// Token: 0x04002256 RID: 8790
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_uint3x2_UInt32_uint3x2_0;

		// Token: 0x04002257 RID: 8791
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_uint3x2_uint3x2_uint3x2_0;

		// Token: 0x04002258 RID: 8792
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_uint3x2_uint3x2_UInt32_0;

		// Token: 0x04002259 RID: 8793
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_uint3x2_UInt32_uint3x2_0;

		// Token: 0x0400225A RID: 8794
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_uint3x2_uint3x2_uint3x2_0;

		// Token: 0x0400225B RID: 8795
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_uint3x2_uint3x2_UInt32_0;

		// Token: 0x0400225C RID: 8796
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_uint3x2_UInt32_uint3x2_0;

		// Token: 0x0400225D RID: 8797
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_uint3x2_uint3x2_uint3x2_0;

		// Token: 0x0400225E RID: 8798
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_uint3x2_uint3x2_UInt32_0;

		// Token: 0x0400225F RID: 8799
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_uint3x2_UInt32_uint3x2_0;

		// Token: 0x04002260 RID: 8800
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_uint3x2_uint3x2_uint3x2_0;

		// Token: 0x04002261 RID: 8801
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_uint3x2_uint3x2_UInt32_0;

		// Token: 0x04002262 RID: 8802
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_uint3x2_UInt32_uint3x2_0;

		// Token: 0x04002263 RID: 8803
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_uint3x2_uint3x2_0;

		// Token: 0x04002264 RID: 8804
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_uint3x2_uint3x2_0;

		// Token: 0x04002265 RID: 8805
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x2_uint3x2_uint3x2_0;

		// Token: 0x04002266 RID: 8806
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x2_uint3x2_UInt32_0;

		// Token: 0x04002267 RID: 8807
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x2_UInt32_uint3x2_0;

		// Token: 0x04002268 RID: 8808
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x2_uint3x2_uint3x2_0;

		// Token: 0x04002269 RID: 8809
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x2_uint3x2_UInt32_0;

		// Token: 0x0400226A RID: 8810
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x2_UInt32_uint3x2_0;

		// Token: 0x0400226B RID: 8811
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x2_uint3x2_uint3x2_0;

		// Token: 0x0400226C RID: 8812
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x2_uint3x2_UInt32_0;

		// Token: 0x0400226D RID: 8813
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x2_UInt32_uint3x2_0;

		// Token: 0x0400226E RID: 8814
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x2_uint3x2_uint3x2_0;

		// Token: 0x0400226F RID: 8815
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x2_uint3x2_UInt32_0;

		// Token: 0x04002270 RID: 8816
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x2_UInt32_uint3x2_0;

		// Token: 0x04002271 RID: 8817
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_uint3x2_uint3x2_0;

		// Token: 0x04002272 RID: 8818
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryPlus_Public_Static_uint3x2_uint3x2_0;

		// Token: 0x04002273 RID: 8819
		private static readonly IntPtr NativeMethodInfoPtr_op_LeftShift_Public_Static_uint3x2_uint3x2_Int32_0;

		// Token: 0x04002274 RID: 8820
		private static readonly IntPtr NativeMethodInfoPtr_op_RightShift_Public_Static_uint3x2_uint3x2_Int32_0;

		// Token: 0x04002275 RID: 8821
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3x2_uint3x2_uint3x2_0;

		// Token: 0x04002276 RID: 8822
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3x2_uint3x2_UInt32_0;

		// Token: 0x04002277 RID: 8823
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3x2_UInt32_uint3x2_0;

		// Token: 0x04002278 RID: 8824
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x2_uint3x2_uint3x2_0;

		// Token: 0x04002279 RID: 8825
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x2_uint3x2_UInt32_0;

		// Token: 0x0400227A RID: 8826
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x2_UInt32_uint3x2_0;

		// Token: 0x0400227B RID: 8827
		private static readonly IntPtr NativeMethodInfoPtr_op_OnesComplement_Public_Static_uint3x2_uint3x2_0;

		// Token: 0x0400227C RID: 8828
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint3x2_uint3x2_uint3x2_0;

		// Token: 0x0400227D RID: 8829
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint3x2_uint3x2_UInt32_0;

		// Token: 0x0400227E RID: 8830
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint3x2_UInt32_uint3x2_0;

		// Token: 0x0400227F RID: 8831
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint3x2_uint3x2_uint3x2_0;

		// Token: 0x04002280 RID: 8832
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint3x2_uint3x2_UInt32_0;

		// Token: 0x04002281 RID: 8833
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint3x2_UInt32_uint3x2_0;

		// Token: 0x04002282 RID: 8834
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint3x2_uint3x2_uint3x2_0;

		// Token: 0x04002283 RID: 8835
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint3x2_uint3x2_UInt32_0;

		// Token: 0x04002284 RID: 8836
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint3x2_UInt32_uint3x2_0;

		// Token: 0x04002285 RID: 8837
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_uint3_Int32_0;

		// Token: 0x04002286 RID: 8838
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_uint3x2_0;

		// Token: 0x04002287 RID: 8839
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002288 RID: 8840
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002289 RID: 8841
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400228A RID: 8842
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x0400228B RID: 8843
		[FieldOffset(0)]
		public uint3 c0;

		// Token: 0x0400228C RID: 8844
		[FieldOffset(12)]
		public uint3 c1;
	}
}
