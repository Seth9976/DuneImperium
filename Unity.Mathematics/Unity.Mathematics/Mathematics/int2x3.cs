using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x0200002F RID: 47
	[Serializable]
	[StructLayout(2)]
	public struct int2x3
	{
		// Token: 0x060019A0 RID: 6560 RVA: 0x00086710 File Offset: 0x00084910
		// Note: this type is marked as 'beforefieldinit'.
		static int2x3()
		{
			Il2CppClassPointerStore<int2x3>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "int2x3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<int2x3>.NativeClassPtr);
			int2x3.NativeFieldInfoPtr_c0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int2x3>.NativeClassPtr, "c0");
			int2x3.NativeFieldInfoPtr_c1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int2x3>.NativeClassPtr, "c1");
			int2x3.NativeFieldInfoPtr_c2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int2x3>.NativeClassPtr, "c2");
			int2x3.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int2x3>.NativeClassPtr, "zero");
			int2x3.NativeMethodInfoPtr__ctor_Public_Void_int2_int2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669669);
			int2x3.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669670);
			int2x3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669671);
			int2x3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669672);
			int2x3.NativeMethodInfoPtr__ctor_Public_Void_bool2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669673);
			int2x3.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669674);
			int2x3.NativeMethodInfoPtr__ctor_Public_Void_uint2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669675);
			int2x3.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669676);
			int2x3.NativeMethodInfoPtr__ctor_Public_Void_float2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669677);
			int2x3.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669678);
			int2x3.NativeMethodInfoPtr__ctor_Public_Void_double2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669679);
			int2x3.NativeMethodInfoPtr_op_Implicit_Public_Static_int2x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669680);
			int2x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669681);
			int2x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x3_bool2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669682);
			int2x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669683);
			int2x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x3_uint2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669684);
			int2x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669685);
			int2x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x3_float2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669686);
			int2x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669687);
			int2x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x3_double2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669688);
			int2x3.NativeMethodInfoPtr_op_Multiply_Public_Static_int2x3_int2x3_int2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669689);
			int2x3.NativeMethodInfoPtr_op_Multiply_Public_Static_int2x3_int2x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669690);
			int2x3.NativeMethodInfoPtr_op_Multiply_Public_Static_int2x3_Int32_int2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669691);
			int2x3.NativeMethodInfoPtr_op_Addition_Public_Static_int2x3_int2x3_int2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669692);
			int2x3.NativeMethodInfoPtr_op_Addition_Public_Static_int2x3_int2x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669693);
			int2x3.NativeMethodInfoPtr_op_Addition_Public_Static_int2x3_Int32_int2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669694);
			int2x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_int2x3_int2x3_int2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669695);
			int2x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_int2x3_int2x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669696);
			int2x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_int2x3_Int32_int2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669697);
			int2x3.NativeMethodInfoPtr_op_Division_Public_Static_int2x3_int2x3_int2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669698);
			int2x3.NativeMethodInfoPtr_op_Division_Public_Static_int2x3_int2x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669699);
			int2x3.NativeMethodInfoPtr_op_Division_Public_Static_int2x3_Int32_int2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669700);
			int2x3.NativeMethodInfoPtr_op_Modulus_Public_Static_int2x3_int2x3_int2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669701);
			int2x3.NativeMethodInfoPtr_op_Modulus_Public_Static_int2x3_int2x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669702);
			int2x3.NativeMethodInfoPtr_op_Modulus_Public_Static_int2x3_Int32_int2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669703);
			int2x3.NativeMethodInfoPtr_op_Increment_Public_Static_int2x3_int2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669704);
			int2x3.NativeMethodInfoPtr_op_Decrement_Public_Static_int2x3_int2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669705);
			int2x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x3_int2x3_int2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669706);
			int2x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x3_int2x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669707);
			int2x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x3_Int32_int2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669708);
			int2x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x3_int2x3_int2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669709);
			int2x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x3_int2x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669710);
			int2x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x3_Int32_int2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669711);
			int2x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x3_int2x3_int2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669712);
			int2x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x3_int2x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669713);
			int2x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x3_Int32_int2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669714);
			int2x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x3_int2x3_int2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669715);
			int2x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x3_int2x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669716);
			int2x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x3_Int32_int2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669717);
			int2x3.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_int2x3_int2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669718);
			int2x3.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_int2x3_int2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669719);
			int2x3.NativeMethodInfoPtr_op_LeftShift_Public_Static_int2x3_int2x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669720);
			int2x3.NativeMethodInfoPtr_op_RightShift_Public_Static_int2x3_int2x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669721);
			int2x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x3_int2x3_int2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669722);
			int2x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x3_int2x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669723);
			int2x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x3_Int32_int2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669724);
			int2x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x3_int2x3_int2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669725);
			int2x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x3_int2x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669726);
			int2x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x3_Int32_int2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669727);
			int2x3.NativeMethodInfoPtr_op_OnesComplement_Public_Static_int2x3_int2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669728);
			int2x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int2x3_int2x3_int2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669729);
			int2x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int2x3_int2x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669730);
			int2x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int2x3_Int32_int2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669731);
			int2x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int2x3_int2x3_int2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669732);
			int2x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int2x3_int2x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669733);
			int2x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int2x3_Int32_int2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669734);
			int2x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int2x3_int2x3_int2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669735);
			int2x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int2x3_int2x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669736);
			int2x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int2x3_Int32_int2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669737);
			int2x3.NativeMethodInfoPtr_get_Item_Public_get_byref_int2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669738);
			int2x3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_int2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669739);
			int2x3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669740);
			int2x3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669741);
			int2x3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669742);
			int2x3.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x3>.NativeClassPtr, 100669743);
		}

		// Token: 0x060019A1 RID: 6561 RVA: 0x00086D6C File Offset: 0x00084F6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 636842, RefRangeEnd = 636843, XrefRangeStart = 636842, XrefRangeEnd = 636843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int2x3(int2 c0, int2 c1, int2 c2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr__ctor_Public_Void_int2_int2_int2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019A2 RID: 6562 RVA: 0x00086DBC File Offset: 0x00084FBC
		[CallerCount(0)]
		public unsafe int2x3(int m00, int m01, int m02, int m10, int m11, int m12)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019A3 RID: 6563 RVA: 0x00086E34 File Offset: 0x00085034
		[CallerCount(0)]
		public unsafe int2x3(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019A4 RID: 6564 RVA: 0x00086E68 File Offset: 0x00085068
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 639218, RefRangeEnd = 639220, XrefRangeStart = 639218, XrefRangeEnd = 639218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int2x3(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x00086E9C File Offset: 0x0008509C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 639220, RefRangeEnd = 639222, XrefRangeStart = 639220, XrefRangeEnd = 639220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int2x3(bool2x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr__ctor_Public_Void_bool2x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019A6 RID: 6566 RVA: 0x00086ED0 File Offset: 0x000850D0
		[CallerCount(0)]
		public unsafe int2x3(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019A7 RID: 6567 RVA: 0x00086F04 File Offset: 0x00085104
		[CallerCount(0)]
		public unsafe int2x3(uint2x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr__ctor_Public_Void_uint2x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019A8 RID: 6568 RVA: 0x00086F38 File Offset: 0x00085138
		[CallerCount(0)]
		public unsafe int2x3(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019A9 RID: 6569 RVA: 0x00086F6C File Offset: 0x0008516C
		[CallerCount(0)]
		public unsafe int2x3(float2x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr__ctor_Public_Void_float2x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019AA RID: 6570 RVA: 0x00086FA0 File Offset: 0x000851A0
		[CallerCount(0)]
		public unsafe int2x3(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019AB RID: 6571 RVA: 0x00086FD4 File Offset: 0x000851D4
		[CallerCount(0)]
		public unsafe int2x3(double2x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr__ctor_Public_Void_double2x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019AC RID: 6572 RVA: 0x00087008 File Offset: 0x00085208
		[CallerCount(0)]
		public unsafe static implicit operator int2x3(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_Implicit_Public_Static_int2x3_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019AD RID: 6573 RVA: 0x00087048 File Offset: 0x00085248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639222, XrefRangeEnd = 639223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator int2x3(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x3_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019AE RID: 6574 RVA: 0x00087088 File Offset: 0x00085288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639223, XrefRangeEnd = 639224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator int2x3(bool2x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x3_bool2x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019AF RID: 6575 RVA: 0x000870C8 File Offset: 0x000852C8
		[CallerCount(0)]
		public unsafe static explicit operator int2x3(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x00087108 File Offset: 0x00085308
		[CallerCount(0)]
		public unsafe static explicit operator int2x3(uint2x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x3_uint2x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019B1 RID: 6577 RVA: 0x00087148 File Offset: 0x00085348
		[CallerCount(0)]
		public unsafe static explicit operator int2x3(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x3_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019B2 RID: 6578 RVA: 0x00087188 File Offset: 0x00085388
		[CallerCount(0)]
		public unsafe static explicit operator int2x3(float2x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x3_float2x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019B3 RID: 6579 RVA: 0x000871C8 File Offset: 0x000853C8
		[CallerCount(0)]
		public unsafe static explicit operator int2x3(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x3_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019B4 RID: 6580 RVA: 0x00087208 File Offset: 0x00085408
		[CallerCount(0)]
		public unsafe static explicit operator int2x3(double2x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x3_double2x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019B5 RID: 6581 RVA: 0x00087248 File Offset: 0x00085448
		[CallerCount(0)]
		public unsafe static int2x3 operator *(int2x3 lhs, int2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_Multiply_Public_Static_int2x3_int2x3_int2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019B6 RID: 6582 RVA: 0x00087294 File Offset: 0x00085494
		[CallerCount(0)]
		public unsafe static int2x3 operator *(int2x3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_Multiply_Public_Static_int2x3_int2x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019B7 RID: 6583 RVA: 0x000872E0 File Offset: 0x000854E0
		[CallerCount(0)]
		public unsafe static int2x3 operator *(int lhs, int2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_Multiply_Public_Static_int2x3_Int32_int2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019B8 RID: 6584 RVA: 0x0008732C File Offset: 0x0008552C
		[CallerCount(0)]
		public unsafe static int2x3 operator +(int2x3 lhs, int2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_Addition_Public_Static_int2x3_int2x3_int2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019B9 RID: 6585 RVA: 0x00087378 File Offset: 0x00085578
		[CallerCount(0)]
		public unsafe static int2x3 operator +(int2x3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_Addition_Public_Static_int2x3_int2x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019BA RID: 6586 RVA: 0x000873C4 File Offset: 0x000855C4
		[CallerCount(0)]
		public unsafe static int2x3 operator +(int lhs, int2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_Addition_Public_Static_int2x3_Int32_int2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019BB RID: 6587 RVA: 0x00087410 File Offset: 0x00085610
		[CallerCount(0)]
		public unsafe static int2x3 operator -(int2x3 lhs, int2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_int2x3_int2x3_int2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x0008745C File Offset: 0x0008565C
		[CallerCount(0)]
		public unsafe static int2x3 operator -(int2x3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_int2x3_int2x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019BD RID: 6589 RVA: 0x000874A8 File Offset: 0x000856A8
		[CallerCount(0)]
		public unsafe static int2x3 operator -(int lhs, int2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_int2x3_Int32_int2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019BE RID: 6590 RVA: 0x000874F4 File Offset: 0x000856F4
		[CallerCount(0)]
		public unsafe static int2x3 operator /(int2x3 lhs, int2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_Division_Public_Static_int2x3_int2x3_int2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019BF RID: 6591 RVA: 0x00087540 File Offset: 0x00085740
		[CallerCount(0)]
		public unsafe static int2x3 operator /(int2x3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_Division_Public_Static_int2x3_int2x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019C0 RID: 6592 RVA: 0x0008758C File Offset: 0x0008578C
		[CallerCount(0)]
		public unsafe static int2x3 operator /(int lhs, int2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_Division_Public_Static_int2x3_Int32_int2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019C1 RID: 6593 RVA: 0x000875D8 File Offset: 0x000857D8
		[CallerCount(0)]
		public unsafe static int2x3 operator %(int2x3 lhs, int2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_Modulus_Public_Static_int2x3_int2x3_int2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019C2 RID: 6594 RVA: 0x00087624 File Offset: 0x00085824
		[CallerCount(0)]
		public unsafe static int2x3 operator %(int2x3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_Modulus_Public_Static_int2x3_int2x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019C3 RID: 6595 RVA: 0x00087670 File Offset: 0x00085870
		[CallerCount(0)]
		public unsafe static int2x3 operator %(int lhs, int2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_Modulus_Public_Static_int2x3_Int32_int2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019C4 RID: 6596 RVA: 0x000876BC File Offset: 0x000858BC
		[CallerCount(0)]
		public unsafe static int2x3 operator ++(int2x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_Increment_Public_Static_int2x3_int2x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019C5 RID: 6597 RVA: 0x000876FC File Offset: 0x000858FC
		[CallerCount(0)]
		public unsafe static int2x3 operator --(int2x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_Decrement_Public_Static_int2x3_int2x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019C6 RID: 6598 RVA: 0x0008773C File Offset: 0x0008593C
		[CallerCount(0)]
		public unsafe static bool2x3 operator <(int2x3 lhs, int2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x3_int2x3_int2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019C7 RID: 6599 RVA: 0x00087788 File Offset: 0x00085988
		[CallerCount(0)]
		public unsafe static bool2x3 operator <(int2x3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x3_int2x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019C8 RID: 6600 RVA: 0x000877D4 File Offset: 0x000859D4
		[CallerCount(0)]
		public unsafe static bool2x3 operator <(int lhs, int2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x3_Int32_int2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019C9 RID: 6601 RVA: 0x00087820 File Offset: 0x00085A20
		[CallerCount(0)]
		public unsafe static bool2x3 operator <=(int2x3 lhs, int2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x3_int2x3_int2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019CA RID: 6602 RVA: 0x0008786C File Offset: 0x00085A6C
		[CallerCount(0)]
		public unsafe static bool2x3 operator <=(int2x3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x3_int2x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019CB RID: 6603 RVA: 0x000878B8 File Offset: 0x00085AB8
		[CallerCount(0)]
		public unsafe static bool2x3 operator <=(int lhs, int2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x3_Int32_int2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019CC RID: 6604 RVA: 0x00087904 File Offset: 0x00085B04
		[CallerCount(0)]
		public unsafe static bool2x3 operator >(int2x3 lhs, int2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x3_int2x3_int2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019CD RID: 6605 RVA: 0x00087950 File Offset: 0x00085B50
		[CallerCount(0)]
		public unsafe static bool2x3 operator >(int2x3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x3_int2x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019CE RID: 6606 RVA: 0x0008799C File Offset: 0x00085B9C
		[CallerCount(0)]
		public unsafe static bool2x3 operator >(int lhs, int2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x3_Int32_int2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019CF RID: 6607 RVA: 0x000879E8 File Offset: 0x00085BE8
		[CallerCount(0)]
		public unsafe static bool2x3 operator >=(int2x3 lhs, int2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x3_int2x3_int2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019D0 RID: 6608 RVA: 0x00087A34 File Offset: 0x00085C34
		[CallerCount(0)]
		public unsafe static bool2x3 operator >=(int2x3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x3_int2x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019D1 RID: 6609 RVA: 0x00087A80 File Offset: 0x00085C80
		[CallerCount(0)]
		public unsafe static bool2x3 operator >=(int lhs, int2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x3_Int32_int2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019D2 RID: 6610 RVA: 0x00087ACC File Offset: 0x00085CCC
		[CallerCount(0)]
		public unsafe static int2x3 operator -(int2x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_int2x3_int2x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x00087B0C File Offset: 0x00085D0C
		[CallerCount(0)]
		public unsafe static int2x3 operator +(int2x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_int2x3_int2x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019D4 RID: 6612 RVA: 0x00087B4C File Offset: 0x00085D4C
		[CallerCount(0)]
		public unsafe static int2x3 operator <<(int2x3 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_LeftShift_Public_Static_int2x3_int2x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019D5 RID: 6613 RVA: 0x00087B98 File Offset: 0x00085D98
		[CallerCount(0)]
		public unsafe static int2x3 operator >>(int2x3 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_RightShift_Public_Static_int2x3_int2x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019D6 RID: 6614 RVA: 0x00087BE4 File Offset: 0x00085DE4
		[CallerCount(0)]
		public unsafe static bool2x3 operator ==(int2x3 lhs, int2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x3_int2x3_int2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019D7 RID: 6615 RVA: 0x00087C30 File Offset: 0x00085E30
		[CallerCount(0)]
		public unsafe static bool2x3 operator ==(int2x3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x3_int2x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019D8 RID: 6616 RVA: 0x00087C7C File Offset: 0x00085E7C
		[CallerCount(0)]
		public unsafe static bool2x3 operator ==(int lhs, int2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x3_Int32_int2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019D9 RID: 6617 RVA: 0x00087CC8 File Offset: 0x00085EC8
		[CallerCount(0)]
		public unsafe static bool2x3 operator !=(int2x3 lhs, int2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x3_int2x3_int2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019DA RID: 6618 RVA: 0x00087D14 File Offset: 0x00085F14
		[CallerCount(0)]
		public unsafe static bool2x3 operator !=(int2x3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x3_int2x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019DB RID: 6619 RVA: 0x00087D60 File Offset: 0x00085F60
		[CallerCount(0)]
		public unsafe static bool2x3 operator !=(int lhs, int2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x3_Int32_int2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019DC RID: 6620 RVA: 0x00087DAC File Offset: 0x00085FAC
		[CallerCount(0)]
		public unsafe static int2x3 operator ~(int2x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_OnesComplement_Public_Static_int2x3_int2x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019DD RID: 6621 RVA: 0x00087DEC File Offset: 0x00085FEC
		[CallerCount(0)]
		public unsafe static int2x3 operator &(int2x3 lhs, int2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int2x3_int2x3_int2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019DE RID: 6622 RVA: 0x00087E38 File Offset: 0x00086038
		[CallerCount(0)]
		public unsafe static int2x3 operator &(int2x3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int2x3_int2x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x00087E84 File Offset: 0x00086084
		[CallerCount(0)]
		public unsafe static int2x3 operator &(int lhs, int2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int2x3_Int32_int2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019E0 RID: 6624 RVA: 0x00087ED0 File Offset: 0x000860D0
		[CallerCount(0)]
		public unsafe static int2x3 operator |(int2x3 lhs, int2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int2x3_int2x3_int2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x00087F1C File Offset: 0x0008611C
		[CallerCount(0)]
		public unsafe static int2x3 operator |(int2x3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int2x3_int2x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019E2 RID: 6626 RVA: 0x00087F68 File Offset: 0x00086168
		[CallerCount(0)]
		public unsafe static int2x3 operator |(int lhs, int2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int2x3_Int32_int2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019E3 RID: 6627 RVA: 0x00087FB4 File Offset: 0x000861B4
		[CallerCount(0)]
		public unsafe static int2x3 operator ^(int2x3 lhs, int2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int2x3_int2x3_int2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019E4 RID: 6628 RVA: 0x00088000 File Offset: 0x00086200
		[CallerCount(0)]
		public unsafe static int2x3 operator ^(int2x3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int2x3_int2x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019E5 RID: 6629 RVA: 0x0008804C File Offset: 0x0008624C
		[CallerCount(0)]
		public unsafe static int2x3 operator ^(int lhs, int2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int2x3_Int32_int2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700080A RID: 2058
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_get_Item_Public_get_byref_int2_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x060019E7 RID: 6631 RVA: 0x000880CC File Offset: 0x000862CC
		[CallerCount(0)]
		public unsafe bool Equals(int2x3 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_int2x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019E8 RID: 6632 RVA: 0x0008810C File Offset: 0x0008630C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639224, XrefRangeEnd = 639227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019E9 RID: 6633 RVA: 0x00088150 File Offset: 0x00086350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639227, XrefRangeEnd = 639228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019EA RID: 6634 RVA: 0x00088180 File Offset: 0x00086380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639228, XrefRangeEnd = 639259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060019EB RID: 6635 RVA: 0x000881AC File Offset: 0x000863AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639259, XrefRangeEnd = 639297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x3.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060019EC RID: 6636 RVA: 0x000026D2 File Offset: 0x000008D2
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<int2x3>.NativeClassPtr, ref this));
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x060019ED RID: 6637 RVA: 0x000881FC File Offset: 0x000863FC
		// (set) Token: 0x060019EE RID: 6638 RVA: 0x000026E4 File Offset: 0x000008E4
		public unsafe static int2x3 zero
		{
			get
			{
				int2x3 int2x;
				IL2CPP.il2cpp_field_static_get_value(int2x3.NativeFieldInfoPtr_zero, (void*)(&int2x));
				return int2x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(int2x3.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x040019FF RID: 6655
		private static readonly IntPtr NativeFieldInfoPtr_c0;

		// Token: 0x04001A00 RID: 6656
		private static readonly IntPtr NativeFieldInfoPtr_c1;

		// Token: 0x04001A01 RID: 6657
		private static readonly IntPtr NativeFieldInfoPtr_c2;

		// Token: 0x04001A02 RID: 6658
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x04001A03 RID: 6659
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int2_int2_int2_0;

		// Token: 0x04001A04 RID: 6660
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x04001A05 RID: 6661
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001A06 RID: 6662
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04001A07 RID: 6663
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool2x3_0;

		// Token: 0x04001A08 RID: 6664
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04001A09 RID: 6665
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint2x3_0;

		// Token: 0x04001A0A RID: 6666
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x04001A0B RID: 6667
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float2x3_0;

		// Token: 0x04001A0C RID: 6668
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x04001A0D RID: 6669
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double2x3_0;

		// Token: 0x04001A0E RID: 6670
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_int2x3_Int32_0;

		// Token: 0x04001A0F RID: 6671
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int2x3_Boolean_0;

		// Token: 0x04001A10 RID: 6672
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int2x3_bool2x3_0;

		// Token: 0x04001A11 RID: 6673
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int2x3_UInt32_0;

		// Token: 0x04001A12 RID: 6674
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int2x3_uint2x3_0;

		// Token: 0x04001A13 RID: 6675
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int2x3_Single_0;

		// Token: 0x04001A14 RID: 6676
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int2x3_float2x3_0;

		// Token: 0x04001A15 RID: 6677
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int2x3_Double_0;

		// Token: 0x04001A16 RID: 6678
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int2x3_double2x3_0;

		// Token: 0x04001A17 RID: 6679
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_int2x3_int2x3_int2x3_0;

		// Token: 0x04001A18 RID: 6680
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_int2x3_int2x3_Int32_0;

		// Token: 0x04001A19 RID: 6681
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_int2x3_Int32_int2x3_0;

		// Token: 0x04001A1A RID: 6682
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_int2x3_int2x3_int2x3_0;

		// Token: 0x04001A1B RID: 6683
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_int2x3_int2x3_Int32_0;

		// Token: 0x04001A1C RID: 6684
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_int2x3_Int32_int2x3_0;

		// Token: 0x04001A1D RID: 6685
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_int2x3_int2x3_int2x3_0;

		// Token: 0x04001A1E RID: 6686
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_int2x3_int2x3_Int32_0;

		// Token: 0x04001A1F RID: 6687
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_int2x3_Int32_int2x3_0;

		// Token: 0x04001A20 RID: 6688
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_int2x3_int2x3_int2x3_0;

		// Token: 0x04001A21 RID: 6689
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_int2x3_int2x3_Int32_0;

		// Token: 0x04001A22 RID: 6690
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_int2x3_Int32_int2x3_0;

		// Token: 0x04001A23 RID: 6691
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_int2x3_int2x3_int2x3_0;

		// Token: 0x04001A24 RID: 6692
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_int2x3_int2x3_Int32_0;

		// Token: 0x04001A25 RID: 6693
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_int2x3_Int32_int2x3_0;

		// Token: 0x04001A26 RID: 6694
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_int2x3_int2x3_0;

		// Token: 0x04001A27 RID: 6695
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_int2x3_int2x3_0;

		// Token: 0x04001A28 RID: 6696
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x3_int2x3_int2x3_0;

		// Token: 0x04001A29 RID: 6697
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x3_int2x3_Int32_0;

		// Token: 0x04001A2A RID: 6698
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x3_Int32_int2x3_0;

		// Token: 0x04001A2B RID: 6699
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x3_int2x3_int2x3_0;

		// Token: 0x04001A2C RID: 6700
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x3_int2x3_Int32_0;

		// Token: 0x04001A2D RID: 6701
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x3_Int32_int2x3_0;

		// Token: 0x04001A2E RID: 6702
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x3_int2x3_int2x3_0;

		// Token: 0x04001A2F RID: 6703
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x3_int2x3_Int32_0;

		// Token: 0x04001A30 RID: 6704
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x3_Int32_int2x3_0;

		// Token: 0x04001A31 RID: 6705
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x3_int2x3_int2x3_0;

		// Token: 0x04001A32 RID: 6706
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x3_int2x3_Int32_0;

		// Token: 0x04001A33 RID: 6707
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x3_Int32_int2x3_0;

		// Token: 0x04001A34 RID: 6708
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_int2x3_int2x3_0;

		// Token: 0x04001A35 RID: 6709
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryPlus_Public_Static_int2x3_int2x3_0;

		// Token: 0x04001A36 RID: 6710
		private static readonly IntPtr NativeMethodInfoPtr_op_LeftShift_Public_Static_int2x3_int2x3_Int32_0;

		// Token: 0x04001A37 RID: 6711
		private static readonly IntPtr NativeMethodInfoPtr_op_RightShift_Public_Static_int2x3_int2x3_Int32_0;

		// Token: 0x04001A38 RID: 6712
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2x3_int2x3_int2x3_0;

		// Token: 0x04001A39 RID: 6713
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2x3_int2x3_Int32_0;

		// Token: 0x04001A3A RID: 6714
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2x3_Int32_int2x3_0;

		// Token: 0x04001A3B RID: 6715
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x3_int2x3_int2x3_0;

		// Token: 0x04001A3C RID: 6716
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x3_int2x3_Int32_0;

		// Token: 0x04001A3D RID: 6717
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x3_Int32_int2x3_0;

		// Token: 0x04001A3E RID: 6718
		private static readonly IntPtr NativeMethodInfoPtr_op_OnesComplement_Public_Static_int2x3_int2x3_0;

		// Token: 0x04001A3F RID: 6719
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int2x3_int2x3_int2x3_0;

		// Token: 0x04001A40 RID: 6720
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int2x3_int2x3_Int32_0;

		// Token: 0x04001A41 RID: 6721
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int2x3_Int32_int2x3_0;

		// Token: 0x04001A42 RID: 6722
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int2x3_int2x3_int2x3_0;

		// Token: 0x04001A43 RID: 6723
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int2x3_int2x3_Int32_0;

		// Token: 0x04001A44 RID: 6724
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int2x3_Int32_int2x3_0;

		// Token: 0x04001A45 RID: 6725
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int2x3_int2x3_int2x3_0;

		// Token: 0x04001A46 RID: 6726
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int2x3_int2x3_Int32_0;

		// Token: 0x04001A47 RID: 6727
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int2x3_Int32_int2x3_0;

		// Token: 0x04001A48 RID: 6728
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_int2_Int32_0;

		// Token: 0x04001A49 RID: 6729
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_int2x3_0;

		// Token: 0x04001A4A RID: 6730
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001A4B RID: 6731
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001A4C RID: 6732
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001A4D RID: 6733
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04001A4E RID: 6734
		[FieldOffset(0)]
		public int2 c0;

		// Token: 0x04001A4F RID: 6735
		[FieldOffset(8)]
		public int2 c1;

		// Token: 0x04001A50 RID: 6736
		[FieldOffset(16)]
		public int2 c2;
	}
}
