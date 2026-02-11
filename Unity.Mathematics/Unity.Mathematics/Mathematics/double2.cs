using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x02000011 RID: 17
	[Serializable]
	[StructLayout(2)]
	public struct double2
	{
		// Token: 0x06000B24 RID: 2852 RVA: 0x0003FED4 File Offset: 0x0003E0D4
		// Note: this type is marked as 'beforefieldinit'.
		static double2()
		{
			Il2CppClassPointerStore<double2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "double2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<double2>.NativeClassPtr);
			double2.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double2>.NativeClassPtr, "x");
			double2.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double2>.NativeClassPtr, "y");
			double2.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double2>.NativeClassPtr, "zero");
			double2.NativeMethodInfoPtr__ctor_Public_Void_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666077);
			double2.NativeMethodInfoPtr__ctor_Public_Void_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666078);
			double2.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666079);
			double2.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666080);
			double2.NativeMethodInfoPtr__ctor_Public_Void_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666081);
			double2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666082);
			double2.NativeMethodInfoPtr__ctor_Public_Void_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666083);
			double2.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666084);
			double2.NativeMethodInfoPtr__ctor_Public_Void_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666085);
			double2.NativeMethodInfoPtr__ctor_Public_Void_half_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666086);
			double2.NativeMethodInfoPtr__ctor_Public_Void_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666087);
			double2.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666088);
			double2.NativeMethodInfoPtr__ctor_Public_Void_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666089);
			double2.NativeMethodInfoPtr_op_Implicit_Public_Static_double2_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666090);
			double2.NativeMethodInfoPtr_op_Explicit_Public_Static_double2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666091);
			double2.NativeMethodInfoPtr_op_Explicit_Public_Static_double2_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666092);
			double2.NativeMethodInfoPtr_op_Implicit_Public_Static_double2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666093);
			double2.NativeMethodInfoPtr_op_Implicit_Public_Static_double2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666094);
			double2.NativeMethodInfoPtr_op_Implicit_Public_Static_double2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666095);
			double2.NativeMethodInfoPtr_op_Implicit_Public_Static_double2_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666096);
			double2.NativeMethodInfoPtr_op_Implicit_Public_Static_double2_half_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666097);
			double2.NativeMethodInfoPtr_op_Implicit_Public_Static_double2_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666098);
			double2.NativeMethodInfoPtr_op_Implicit_Public_Static_double2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666099);
			double2.NativeMethodInfoPtr_op_Implicit_Public_Static_double2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666100);
			double2.NativeMethodInfoPtr_op_Multiply_Public_Static_double2_double2_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666101);
			double2.NativeMethodInfoPtr_op_Multiply_Public_Static_double2_double2_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666102);
			double2.NativeMethodInfoPtr_op_Multiply_Public_Static_double2_Double_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666103);
			double2.NativeMethodInfoPtr_op_Addition_Public_Static_double2_double2_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666104);
			double2.NativeMethodInfoPtr_op_Addition_Public_Static_double2_double2_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666105);
			double2.NativeMethodInfoPtr_op_Addition_Public_Static_double2_Double_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666106);
			double2.NativeMethodInfoPtr_op_Subtraction_Public_Static_double2_double2_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666107);
			double2.NativeMethodInfoPtr_op_Subtraction_Public_Static_double2_double2_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666108);
			double2.NativeMethodInfoPtr_op_Subtraction_Public_Static_double2_Double_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666109);
			double2.NativeMethodInfoPtr_op_Division_Public_Static_double2_double2_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666110);
			double2.NativeMethodInfoPtr_op_Division_Public_Static_double2_double2_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666111);
			double2.NativeMethodInfoPtr_op_Division_Public_Static_double2_Double_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666112);
			double2.NativeMethodInfoPtr_op_Modulus_Public_Static_double2_double2_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666113);
			double2.NativeMethodInfoPtr_op_Modulus_Public_Static_double2_double2_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666114);
			double2.NativeMethodInfoPtr_op_Modulus_Public_Static_double2_Double_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666115);
			double2.NativeMethodInfoPtr_op_Increment_Public_Static_double2_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666116);
			double2.NativeMethodInfoPtr_op_Decrement_Public_Static_double2_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666117);
			double2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2_double2_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666118);
			double2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2_double2_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666119);
			double2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2_Double_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666120);
			double2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2_double2_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666121);
			double2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2_double2_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666122);
			double2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2_Double_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666123);
			double2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2_double2_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666124);
			double2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2_double2_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666125);
			double2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2_Double_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666126);
			double2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2_double2_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666127);
			double2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2_double2_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666128);
			double2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2_Double_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666129);
			double2.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_double2_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666130);
			double2.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_double2_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666131);
			double2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2_double2_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666132);
			double2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2_double2_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666133);
			double2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2_Double_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666134);
			double2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_double2_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666135);
			double2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_double2_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666136);
			double2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_Double_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666137);
			double2.NativeMethodInfoPtr_get_xxxx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666138);
			double2.NativeMethodInfoPtr_get_xxxy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666139);
			double2.NativeMethodInfoPtr_get_xxyx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666140);
			double2.NativeMethodInfoPtr_get_xxyy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666141);
			double2.NativeMethodInfoPtr_get_xyxx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666142);
			double2.NativeMethodInfoPtr_get_xyxy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666143);
			double2.NativeMethodInfoPtr_get_xyyx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666144);
			double2.NativeMethodInfoPtr_get_xyyy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666145);
			double2.NativeMethodInfoPtr_get_yxxx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666146);
			double2.NativeMethodInfoPtr_get_yxxy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666147);
			double2.NativeMethodInfoPtr_get_yxyx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666148);
			double2.NativeMethodInfoPtr_get_yxyy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666149);
			double2.NativeMethodInfoPtr_get_yyxx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666150);
			double2.NativeMethodInfoPtr_get_yyxy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666151);
			double2.NativeMethodInfoPtr_get_yyyx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666152);
			double2.NativeMethodInfoPtr_get_yyyy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666153);
			double2.NativeMethodInfoPtr_get_xxx_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666154);
			double2.NativeMethodInfoPtr_get_xxy_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666155);
			double2.NativeMethodInfoPtr_get_xyx_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666156);
			double2.NativeMethodInfoPtr_get_xyy_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666157);
			double2.NativeMethodInfoPtr_get_yxx_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666158);
			double2.NativeMethodInfoPtr_get_yxy_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666159);
			double2.NativeMethodInfoPtr_get_yyx_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666160);
			double2.NativeMethodInfoPtr_get_yyy_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666161);
			double2.NativeMethodInfoPtr_get_xx_Public_get_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666162);
			double2.NativeMethodInfoPtr_get_xy_Public_get_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666163);
			double2.NativeMethodInfoPtr_set_xy_Public_set_Void_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666164);
			double2.NativeMethodInfoPtr_get_yx_Public_get_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666165);
			double2.NativeMethodInfoPtr_set_yx_Public_set_Void_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666166);
			double2.NativeMethodInfoPtr_get_yy_Public_get_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666167);
			double2.NativeMethodInfoPtr_get_Item_Public_get_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666168);
			double2.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666169);
			double2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666170);
			double2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666171);
			double2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666172);
			double2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666173);
			double2.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2>.NativeClassPtr, 100666174);
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x000406E8 File Offset: 0x0003E8E8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 596903, RefRangeEnd = 596910, XrefRangeStart = 596903, XrefRangeEnd = 596910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double2(double x, double y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr__ctor_Public_Void_Double_Double_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x00040728 File Offset: 0x0003E928
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 596910, RefRangeEnd = 596911, XrefRangeStart = 596910, XrefRangeEnd = 596911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double2(double2 xy)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xy;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr__ctor_Public_Void_double2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x0004075C File Offset: 0x0003E95C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 634777, RefRangeEnd = 634779, XrefRangeStart = 634777, XrefRangeEnd = 634777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double2(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x00040790 File Offset: 0x0003E990
		[CallerCount(0)]
		public unsafe double2(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x000407C4 File Offset: 0x0003E9C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634779, XrefRangeEnd = 634780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double2(bool2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr__ctor_Public_Void_bool2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x000407F8 File Offset: 0x0003E9F8
		[CallerCount(0)]
		public unsafe double2(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x0004082C File Offset: 0x0003EA2C
		[CallerCount(0)]
		public unsafe double2(int2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr__ctor_Public_Void_int2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x00040860 File Offset: 0x0003EA60
		[CallerCount(0)]
		public unsafe double2(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x00040894 File Offset: 0x0003EA94
		[CallerCount(0)]
		public unsafe double2(uint2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr__ctor_Public_Void_uint2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x000408C8 File Offset: 0x0003EAC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 634780, RefRangeEnd = 634781, XrefRangeStart = 634780, XrefRangeEnd = 634780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double2(half v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr__ctor_Public_Void_half_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x000408FC File Offset: 0x0003EAFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 634781, RefRangeEnd = 634782, XrefRangeStart = 634781, XrefRangeEnd = 634781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double2(half2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr__ctor_Public_Void_half2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x00040930 File Offset: 0x0003EB30
		[CallerCount(0)]
		public unsafe double2(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x00040964 File Offset: 0x0003EB64
		[CallerCount(0)]
		public unsafe double2(float2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr__ctor_Public_Void_float2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x00040998 File Offset: 0x0003EB98
		[CallerCount(0)]
		public unsafe static implicit operator double2(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_Implicit_Public_Static_double2_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x000409D8 File Offset: 0x0003EBD8
		[CallerCount(0)]
		public unsafe static explicit operator double2(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_Explicit_Public_Static_double2_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x00040A18 File Offset: 0x0003EC18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator double2(bool2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_Explicit_Public_Static_double2_bool2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x00040A58 File Offset: 0x0003EC58
		[CallerCount(0)]
		public unsafe static implicit operator double2(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_Implicit_Public_Static_double2_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x00040A98 File Offset: 0x0003EC98
		[CallerCount(0)]
		public unsafe static implicit operator double2(int2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_Implicit_Public_Static_double2_int2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x00040AD8 File Offset: 0x0003ECD8
		[CallerCount(0)]
		public unsafe static implicit operator double2(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_Implicit_Public_Static_double2_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x00040B18 File Offset: 0x0003ED18
		[CallerCount(0)]
		public unsafe static implicit operator double2(uint2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_Implicit_Public_Static_double2_uint2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x00040B58 File Offset: 0x0003ED58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634782, XrefRangeEnd = 634783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator double2(half v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_Implicit_Public_Static_double2_half_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x00040B98 File Offset: 0x0003ED98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634783, XrefRangeEnd = 634784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator double2(half2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_Implicit_Public_Static_double2_half2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x00040BD8 File Offset: 0x0003EDD8
		[CallerCount(0)]
		public unsafe static implicit operator double2(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_Implicit_Public_Static_double2_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x00040C18 File Offset: 0x0003EE18
		[CallerCount(0)]
		public unsafe static implicit operator double2(float2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_Implicit_Public_Static_double2_float2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x00040C58 File Offset: 0x0003EE58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 634784, RefRangeEnd = 634786, XrefRangeStart = 634784, XrefRangeEnd = 634784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double2 operator *(double2 lhs, double2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_Multiply_Public_Static_double2_double2_double2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x00040CA4 File Offset: 0x0003EEA4
		[CallerCount(0)]
		public unsafe static double2 operator *(double2 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_Multiply_Public_Static_double2_double2_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x00040CF0 File Offset: 0x0003EEF0
		[CallerCount(0)]
		public unsafe static double2 operator *(double lhs, double2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_Multiply_Public_Static_double2_Double_double2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x00040D3C File Offset: 0x0003EF3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 634786, RefRangeEnd = 634788, XrefRangeStart = 634786, XrefRangeEnd = 634786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double2 operator +(double2 lhs, double2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_Addition_Public_Static_double2_double2_double2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x00040D88 File Offset: 0x0003EF88
		[CallerCount(0)]
		public unsafe static double2 operator +(double2 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_Addition_Public_Static_double2_double2_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x00040DD4 File Offset: 0x0003EFD4
		[CallerCount(0)]
		public unsafe static double2 operator +(double lhs, double2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_Addition_Public_Static_double2_Double_double2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x00040E20 File Offset: 0x0003F020
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 634788, RefRangeEnd = 634790, XrefRangeStart = 634788, XrefRangeEnd = 634788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double2 operator -(double2 lhs, double2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_Subtraction_Public_Static_double2_double2_double2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x00040E6C File Offset: 0x0003F06C
		[CallerCount(0)]
		public unsafe static double2 operator -(double2 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_Subtraction_Public_Static_double2_double2_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x00040EB8 File Offset: 0x0003F0B8
		[CallerCount(0)]
		public unsafe static double2 operator -(double lhs, double2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_Subtraction_Public_Static_double2_Double_double2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x00040F04 File Offset: 0x0003F104
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 634790, RefRangeEnd = 634792, XrefRangeStart = 634790, XrefRangeEnd = 634790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double2 operator /(double2 lhs, double2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_Division_Public_Static_double2_double2_double2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x00040F50 File Offset: 0x0003F150
		[CallerCount(0)]
		public unsafe static double2 operator /(double2 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_Division_Public_Static_double2_double2_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x00040F9C File Offset: 0x0003F19C
		[CallerCount(0)]
		public unsafe static double2 operator /(double lhs, double2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_Division_Public_Static_double2_Double_double2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x00040FE8 File Offset: 0x0003F1E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double2 operator %(double2 lhs, double2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_Modulus_Public_Static_double2_double2_double2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x00041034 File Offset: 0x0003F234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634792, XrefRangeEnd = 634794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double2 operator %(double2 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_Modulus_Public_Static_double2_double2_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x00041080 File Offset: 0x0003F280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634794, XrefRangeEnd = 634796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double2 operator %(double lhs, double2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_Modulus_Public_Static_double2_Double_double2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x000410CC File Offset: 0x0003F2CC
		[CallerCount(0)]
		public unsafe static double2 operator ++(double2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_Increment_Public_Static_double2_double2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x0004110C File Offset: 0x0003F30C
		[CallerCount(0)]
		public unsafe static double2 operator --(double2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_Decrement_Public_Static_double2_double2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x0004114C File Offset: 0x0003F34C
		[CallerCount(0)]
		public unsafe static bool2 operator <(double2 lhs, double2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2_double2_double2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x00041198 File Offset: 0x0003F398
		[CallerCount(0)]
		public unsafe static bool2 operator <(double2 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2_double2_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x000411E4 File Offset: 0x0003F3E4
		[CallerCount(0)]
		public unsafe static bool2 operator <(double lhs, double2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2_Double_double2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x00041230 File Offset: 0x0003F430
		[CallerCount(0)]
		public unsafe static bool2 operator <=(double2 lhs, double2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2_double2_double2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x0004127C File Offset: 0x0003F47C
		[CallerCount(0)]
		public unsafe static bool2 operator <=(double2 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2_double2_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x000412C8 File Offset: 0x0003F4C8
		[CallerCount(0)]
		public unsafe static bool2 operator <=(double lhs, double2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2_Double_double2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x00041314 File Offset: 0x0003F514
		[CallerCount(0)]
		public unsafe static bool2 operator >(double2 lhs, double2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2_double2_double2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x00041360 File Offset: 0x0003F560
		[CallerCount(0)]
		public unsafe static bool2 operator >(double2 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2_double2_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x000413AC File Offset: 0x0003F5AC
		[CallerCount(0)]
		public unsafe static bool2 operator >(double lhs, double2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2_Double_double2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x000413F8 File Offset: 0x0003F5F8
		[CallerCount(0)]
		public unsafe static bool2 operator >=(double2 lhs, double2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2_double2_double2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x00041444 File Offset: 0x0003F644
		[CallerCount(0)]
		public unsafe static bool2 operator >=(double2 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2_double2_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x00041490 File Offset: 0x0003F690
		[CallerCount(0)]
		public unsafe static bool2 operator >=(double lhs, double2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2_Double_double2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x000414DC File Offset: 0x0003F6DC
		[CallerCount(0)]
		public unsafe static double2 operator -(double2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_double2_double2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x0004151C File Offset: 0x0003F71C
		[CallerCount(0)]
		public unsafe static double2 operator +(double2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_double2_double2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x0004155C File Offset: 0x0003F75C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634796, XrefRangeEnd = 634797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool2 operator ==(double2 lhs, double2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2_double2_double2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x000415A8 File Offset: 0x0003F7A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634797, XrefRangeEnd = 634798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool2 operator ==(double2 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2_double2_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x000415F4 File Offset: 0x0003F7F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634798, XrefRangeEnd = 634799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool2 operator ==(double lhs, double2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2_Double_double2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x00041640 File Offset: 0x0003F840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634799, XrefRangeEnd = 634800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool2 operator !=(double2 lhs, double2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_double2_double2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x0004168C File Offset: 0x0003F88C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634800, XrefRangeEnd = 634801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool2 operator !=(double2 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_double2_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x000416D8 File Offset: 0x0003F8D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634801, XrefRangeEnd = 634802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool2 operator !=(double lhs, double2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_Double_double2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000B62 RID: 2914 RVA: 0x00041724 File Offset: 0x0003F924
		public unsafe double4 xxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_get_xxxx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000B63 RID: 2915 RVA: 0x00041754 File Offset: 0x0003F954
		public unsafe double4 xxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_get_xxxy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000B64 RID: 2916 RVA: 0x00041784 File Offset: 0x0003F984
		public unsafe double4 xxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_get_xxyx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000B65 RID: 2917 RVA: 0x000417B4 File Offset: 0x0003F9B4
		public unsafe double4 xxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_get_xxyy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000B66 RID: 2918 RVA: 0x000417E4 File Offset: 0x0003F9E4
		public unsafe double4 xyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_get_xyxx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000B67 RID: 2919 RVA: 0x00041814 File Offset: 0x0003FA14
		public unsafe double4 xyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_get_xyxy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000B68 RID: 2920 RVA: 0x00041844 File Offset: 0x0003FA44
		public unsafe double4 xyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_get_xyyx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000B69 RID: 2921 RVA: 0x00041874 File Offset: 0x0003FA74
		public unsafe double4 xyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_get_xyyy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000B6A RID: 2922 RVA: 0x000418A4 File Offset: 0x0003FAA4
		public unsafe double4 yxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_get_yxxx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000B6B RID: 2923 RVA: 0x000418D4 File Offset: 0x0003FAD4
		public unsafe double4 yxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_get_yxxy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000B6C RID: 2924 RVA: 0x00041904 File Offset: 0x0003FB04
		public unsafe double4 yxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_get_yxyx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000B6D RID: 2925 RVA: 0x00041934 File Offset: 0x0003FB34
		public unsafe double4 yxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_get_yxyy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000B6E RID: 2926 RVA: 0x00041964 File Offset: 0x0003FB64
		public unsafe double4 yyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_get_yyxx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000B6F RID: 2927 RVA: 0x00041994 File Offset: 0x0003FB94
		public unsafe double4 yyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_get_yyxy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000B70 RID: 2928 RVA: 0x000419C4 File Offset: 0x0003FBC4
		public unsafe double4 yyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_get_yyyx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000B71 RID: 2929 RVA: 0x000419F4 File Offset: 0x0003FBF4
		public unsafe double4 yyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_get_yyyy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000B72 RID: 2930 RVA: 0x00041A24 File Offset: 0x0003FC24
		public unsafe double3 xxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_get_xxx_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000B73 RID: 2931 RVA: 0x00041A54 File Offset: 0x0003FC54
		public unsafe double3 xxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_get_xxy_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000B74 RID: 2932 RVA: 0x00041A84 File Offset: 0x0003FC84
		public unsafe double3 xyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_get_xyx_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000B75 RID: 2933 RVA: 0x00041AB4 File Offset: 0x0003FCB4
		public unsafe double3 xyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_get_xyy_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000B76 RID: 2934 RVA: 0x00041AE4 File Offset: 0x0003FCE4
		public unsafe double3 yxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_get_yxx_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000B77 RID: 2935 RVA: 0x00041B14 File Offset: 0x0003FD14
		public unsafe double3 yxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_get_yxy_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000B78 RID: 2936 RVA: 0x00041B44 File Offset: 0x0003FD44
		public unsafe double3 yyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_get_yyx_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000B79 RID: 2937 RVA: 0x00041B74 File Offset: 0x0003FD74
		public unsafe double3 yyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_get_yyy_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000B7A RID: 2938 RVA: 0x00041BA4 File Offset: 0x0003FDA4
		public unsafe double2 xx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_get_xx_Public_get_double2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000B7B RID: 2939 RVA: 0x00041BD4 File Offset: 0x0003FDD4
		// (set) Token: 0x06000B7C RID: 2940 RVA: 0x00041C04 File Offset: 0x0003FE04
		public unsafe double2 xy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_get_xy_Public_get_double2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 596910, RefRangeEnd = 596911, XrefRangeStart = 596910, XrefRangeEnd = 596911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_set_xy_Public_set_Void_double2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000B7D RID: 2941 RVA: 0x00041C38 File Offset: 0x0003FE38
		// (set) Token: 0x06000B7E RID: 2942 RVA: 0x00041C68 File Offset: 0x0003FE68
		public unsafe double2 yx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_get_yx_Public_get_double2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_set_yx_Public_set_Void_double2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000B7F RID: 2943 RVA: 0x00041C9C File Offset: 0x0003FE9C
		public unsafe double2 yy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_get_yy_Public_get_double2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000221 RID: 545
		public unsafe double this[int index]
		{
			[CallerCount(0)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_get_Item_Public_get_Double_Int32_0, ref this, (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x00041D4C File Offset: 0x0003FF4C
		[CallerCount(0)]
		public unsafe bool Equals(double2 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_double2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x00041D8C File Offset: 0x0003FF8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634802, XrefRangeEnd = 634805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x00041DD0 File Offset: 0x0003FFD0
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x00041E00 File Offset: 0x00040000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634805, XrefRangeEnd = 634813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x00041E2C File Offset: 0x0004002C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634813, XrefRangeEnd = 634818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x000022B0 File Offset: 0x000004B0
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<double2>.NativeClassPtr, ref this));
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000B88 RID: 2952 RVA: 0x00041E7C File Offset: 0x0004007C
		// (set) Token: 0x06000B89 RID: 2953 RVA: 0x000022C2 File Offset: 0x000004C2
		public unsafe static double2 zero
		{
			get
			{
				double2 @double;
				IL2CPP.il2cpp_field_static_get_value(double2.NativeFieldInfoPtr_zero, (void*)(&@double));
				return @double;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(double2.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x04000B38 RID: 2872
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x04000B39 RID: 2873
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04000B3A RID: 2874
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x04000B3B RID: 2875
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_Double_0;

		// Token: 0x04000B3C RID: 2876
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double2_0;

		// Token: 0x04000B3D RID: 2877
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x04000B3E RID: 2878
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04000B3F RID: 2879
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool2_0;

		// Token: 0x04000B40 RID: 2880
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000B41 RID: 2881
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int2_0;

		// Token: 0x04000B42 RID: 2882
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04000B43 RID: 2883
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint2_0;

		// Token: 0x04000B44 RID: 2884
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_half_0;

		// Token: 0x04000B45 RID: 2885
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_half2_0;

		// Token: 0x04000B46 RID: 2886
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x04000B47 RID: 2887
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float2_0;

		// Token: 0x04000B48 RID: 2888
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double2_Double_0;

		// Token: 0x04000B49 RID: 2889
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_double2_Boolean_0;

		// Token: 0x04000B4A RID: 2890
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_double2_bool2_0;

		// Token: 0x04000B4B RID: 2891
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double2_Int32_0;

		// Token: 0x04000B4C RID: 2892
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double2_int2_0;

		// Token: 0x04000B4D RID: 2893
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double2_UInt32_0;

		// Token: 0x04000B4E RID: 2894
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double2_uint2_0;

		// Token: 0x04000B4F RID: 2895
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double2_half_0;

		// Token: 0x04000B50 RID: 2896
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double2_half2_0;

		// Token: 0x04000B51 RID: 2897
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double2_Single_0;

		// Token: 0x04000B52 RID: 2898
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double2_float2_0;

		// Token: 0x04000B53 RID: 2899
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_double2_double2_double2_0;

		// Token: 0x04000B54 RID: 2900
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_double2_double2_Double_0;

		// Token: 0x04000B55 RID: 2901
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_double2_Double_double2_0;

		// Token: 0x04000B56 RID: 2902
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_double2_double2_double2_0;

		// Token: 0x04000B57 RID: 2903
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_double2_double2_Double_0;

		// Token: 0x04000B58 RID: 2904
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_double2_Double_double2_0;

		// Token: 0x04000B59 RID: 2905
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_double2_double2_double2_0;

		// Token: 0x04000B5A RID: 2906
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_double2_double2_Double_0;

		// Token: 0x04000B5B RID: 2907
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_double2_Double_double2_0;

		// Token: 0x04000B5C RID: 2908
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_double2_double2_double2_0;

		// Token: 0x04000B5D RID: 2909
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_double2_double2_Double_0;

		// Token: 0x04000B5E RID: 2910
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_double2_Double_double2_0;

		// Token: 0x04000B5F RID: 2911
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_double2_double2_double2_0;

		// Token: 0x04000B60 RID: 2912
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_double2_double2_Double_0;

		// Token: 0x04000B61 RID: 2913
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_double2_Double_double2_0;

		// Token: 0x04000B62 RID: 2914
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_double2_double2_0;

		// Token: 0x04000B63 RID: 2915
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_double2_double2_0;

		// Token: 0x04000B64 RID: 2916
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2_double2_double2_0;

		// Token: 0x04000B65 RID: 2917
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2_double2_Double_0;

		// Token: 0x04000B66 RID: 2918
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2_Double_double2_0;

		// Token: 0x04000B67 RID: 2919
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2_double2_double2_0;

		// Token: 0x04000B68 RID: 2920
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2_double2_Double_0;

		// Token: 0x04000B69 RID: 2921
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2_Double_double2_0;

		// Token: 0x04000B6A RID: 2922
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2_double2_double2_0;

		// Token: 0x04000B6B RID: 2923
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2_double2_Double_0;

		// Token: 0x04000B6C RID: 2924
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2_Double_double2_0;

		// Token: 0x04000B6D RID: 2925
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2_double2_double2_0;

		// Token: 0x04000B6E RID: 2926
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2_double2_Double_0;

		// Token: 0x04000B6F RID: 2927
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2_Double_double2_0;

		// Token: 0x04000B70 RID: 2928
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_double2_double2_0;

		// Token: 0x04000B71 RID: 2929
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryPlus_Public_Static_double2_double2_0;

		// Token: 0x04000B72 RID: 2930
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2_double2_double2_0;

		// Token: 0x04000B73 RID: 2931
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2_double2_Double_0;

		// Token: 0x04000B74 RID: 2932
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2_Double_double2_0;

		// Token: 0x04000B75 RID: 2933
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_double2_double2_0;

		// Token: 0x04000B76 RID: 2934
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_double2_Double_0;

		// Token: 0x04000B77 RID: 2935
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_Double_double2_0;

		// Token: 0x04000B78 RID: 2936
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxx_Public_get_double4_0;

		// Token: 0x04000B79 RID: 2937
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxy_Public_get_double4_0;

		// Token: 0x04000B7A RID: 2938
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyx_Public_get_double4_0;

		// Token: 0x04000B7B RID: 2939
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyy_Public_get_double4_0;

		// Token: 0x04000B7C RID: 2940
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxx_Public_get_double4_0;

		// Token: 0x04000B7D RID: 2941
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxy_Public_get_double4_0;

		// Token: 0x04000B7E RID: 2942
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyx_Public_get_double4_0;

		// Token: 0x04000B7F RID: 2943
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyy_Public_get_double4_0;

		// Token: 0x04000B80 RID: 2944
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxx_Public_get_double4_0;

		// Token: 0x04000B81 RID: 2945
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxy_Public_get_double4_0;

		// Token: 0x04000B82 RID: 2946
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyx_Public_get_double4_0;

		// Token: 0x04000B83 RID: 2947
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyy_Public_get_double4_0;

		// Token: 0x04000B84 RID: 2948
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxx_Public_get_double4_0;

		// Token: 0x04000B85 RID: 2949
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxy_Public_get_double4_0;

		// Token: 0x04000B86 RID: 2950
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyx_Public_get_double4_0;

		// Token: 0x04000B87 RID: 2951
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyy_Public_get_double4_0;

		// Token: 0x04000B88 RID: 2952
		private static readonly IntPtr NativeMethodInfoPtr_get_xxx_Public_get_double3_0;

		// Token: 0x04000B89 RID: 2953
		private static readonly IntPtr NativeMethodInfoPtr_get_xxy_Public_get_double3_0;

		// Token: 0x04000B8A RID: 2954
		private static readonly IntPtr NativeMethodInfoPtr_get_xyx_Public_get_double3_0;

		// Token: 0x04000B8B RID: 2955
		private static readonly IntPtr NativeMethodInfoPtr_get_xyy_Public_get_double3_0;

		// Token: 0x04000B8C RID: 2956
		private static readonly IntPtr NativeMethodInfoPtr_get_yxx_Public_get_double3_0;

		// Token: 0x04000B8D RID: 2957
		private static readonly IntPtr NativeMethodInfoPtr_get_yxy_Public_get_double3_0;

		// Token: 0x04000B8E RID: 2958
		private static readonly IntPtr NativeMethodInfoPtr_get_yyx_Public_get_double3_0;

		// Token: 0x04000B8F RID: 2959
		private static readonly IntPtr NativeMethodInfoPtr_get_yyy_Public_get_double3_0;

		// Token: 0x04000B90 RID: 2960
		private static readonly IntPtr NativeMethodInfoPtr_get_xx_Public_get_double2_0;

		// Token: 0x04000B91 RID: 2961
		private static readonly IntPtr NativeMethodInfoPtr_get_xy_Public_get_double2_0;

		// Token: 0x04000B92 RID: 2962
		private static readonly IntPtr NativeMethodInfoPtr_set_xy_Public_set_Void_double2_0;

		// Token: 0x04000B93 RID: 2963
		private static readonly IntPtr NativeMethodInfoPtr_get_yx_Public_get_double2_0;

		// Token: 0x04000B94 RID: 2964
		private static readonly IntPtr NativeMethodInfoPtr_set_yx_Public_set_Void_double2_0;

		// Token: 0x04000B95 RID: 2965
		private static readonly IntPtr NativeMethodInfoPtr_get_yy_Public_get_double2_0;

		// Token: 0x04000B96 RID: 2966
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Double_Int32_0;

		// Token: 0x04000B97 RID: 2967
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Double_0;

		// Token: 0x04000B98 RID: 2968
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_double2_0;

		// Token: 0x04000B99 RID: 2969
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000B9A RID: 2970
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000B9B RID: 2971
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000B9C RID: 2972
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04000B9D RID: 2973
		[FieldOffset(0)]
		public double x;

		// Token: 0x04000B9E RID: 2974
		[FieldOffset(8)]
		public double y;

		// Token: 0x02000057 RID: 87
		public sealed class DebuggerProxy : Object
		{
			// Token: 0x060025D4 RID: 9684 RVA: 0x000C3110 File Offset: 0x000C1310
			// Note: this type is marked as 'beforefieldinit'.
			static DebuggerProxy()
			{
				Il2CppClassPointerStore<double2.DebuggerProxy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<double2>.NativeClassPtr, "DebuggerProxy");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<double2.DebuggerProxy>.NativeClassPtr);
				double2.DebuggerProxy.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double2.DebuggerProxy>.NativeClassPtr, "x");
				double2.DebuggerProxy.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double2.DebuggerProxy>.NativeClassPtr, "y");
				double2.DebuggerProxy.NativeMethodInfoPtr__ctor_Public_Void_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2.DebuggerProxy>.NativeClassPtr, 100666175);
			}

			// Token: 0x060025D5 RID: 9685 RVA: 0x000C3178 File Offset: 0x000C1378
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634776, XrefRangeEnd = 634777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DebuggerProxy(double2 v)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<double2.DebuggerProxy>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2.DebuggerProxy.NativeMethodInfoPtr__ctor_Public_Void_double2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060025D6 RID: 9686 RVA: 0x00002CE5 File Offset: 0x00000EE5
			public DebuggerProxy(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BFA RID: 3066
			// (get) Token: 0x060025D7 RID: 9687 RVA: 0x000C31C0 File Offset: 0x000C13C0
			// (set) Token: 0x060025D8 RID: 9688 RVA: 0x00002CEE File Offset: 0x00000EEE
			public unsafe double x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(double2.DebuggerProxy.NativeFieldInfoPtr_x);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(double2.DebuggerProxy.NativeFieldInfoPtr_x)) = value;
				}
			}

			// Token: 0x17000BFB RID: 3067
			// (get) Token: 0x060025D9 RID: 9689 RVA: 0x000C31E8 File Offset: 0x000C13E8
			// (set) Token: 0x060025DA RID: 9690 RVA: 0x00002D09 File Offset: 0x00000F09
			public unsafe double y
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(double2.DebuggerProxy.NativeFieldInfoPtr_y);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(double2.DebuggerProxy.NativeFieldInfoPtr_y)) = value;
				}
			}

			// Token: 0x04002668 RID: 9832
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04002669 RID: 9833
			private static readonly IntPtr NativeFieldInfoPtr_y;

			// Token: 0x0400266A RID: 9834
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double2_0;
		}
	}
}
