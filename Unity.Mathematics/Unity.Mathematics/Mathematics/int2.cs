using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x0200002D RID: 45
	[Serializable]
	[StructLayout(2)]
	public struct int2
	{
		// Token: 0x060018E1 RID: 6369 RVA: 0x00082918 File Offset: 0x00080B18
		// Note: this type is marked as 'beforefieldinit'.
		static int2()
		{
			Il2CppClassPointerStore<int2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "int2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<int2>.NativeClassPtr);
			int2.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int2>.NativeClassPtr, "x");
			int2.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int2>.NativeClassPtr, "y");
			int2.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int2>.NativeClassPtr, "zero");
			int2.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669486);
			int2.NativeMethodInfoPtr__ctor_Public_Void_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669487);
			int2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669488);
			int2.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669489);
			int2.NativeMethodInfoPtr__ctor_Public_Void_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669490);
			int2.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669491);
			int2.NativeMethodInfoPtr__ctor_Public_Void_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669492);
			int2.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669493);
			int2.NativeMethodInfoPtr__ctor_Public_Void_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669494);
			int2.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669495);
			int2.NativeMethodInfoPtr__ctor_Public_Void_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669496);
			int2.NativeMethodInfoPtr_op_Implicit_Public_Static_int2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669497);
			int2.NativeMethodInfoPtr_op_Explicit_Public_Static_int2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669498);
			int2.NativeMethodInfoPtr_op_Explicit_Public_Static_int2_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669499);
			int2.NativeMethodInfoPtr_op_Explicit_Public_Static_int2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669500);
			int2.NativeMethodInfoPtr_op_Explicit_Public_Static_int2_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669501);
			int2.NativeMethodInfoPtr_op_Explicit_Public_Static_int2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669502);
			int2.NativeMethodInfoPtr_op_Explicit_Public_Static_int2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669503);
			int2.NativeMethodInfoPtr_op_Explicit_Public_Static_int2_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669504);
			int2.NativeMethodInfoPtr_op_Explicit_Public_Static_int2_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669505);
			int2.NativeMethodInfoPtr_op_Multiply_Public_Static_int2_int2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669506);
			int2.NativeMethodInfoPtr_op_Multiply_Public_Static_int2_int2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669507);
			int2.NativeMethodInfoPtr_op_Multiply_Public_Static_int2_Int32_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669508);
			int2.NativeMethodInfoPtr_op_Addition_Public_Static_int2_int2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669509);
			int2.NativeMethodInfoPtr_op_Addition_Public_Static_int2_int2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669510);
			int2.NativeMethodInfoPtr_op_Addition_Public_Static_int2_Int32_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669511);
			int2.NativeMethodInfoPtr_op_Subtraction_Public_Static_int2_int2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669512);
			int2.NativeMethodInfoPtr_op_Subtraction_Public_Static_int2_int2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669513);
			int2.NativeMethodInfoPtr_op_Subtraction_Public_Static_int2_Int32_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669514);
			int2.NativeMethodInfoPtr_op_Division_Public_Static_int2_int2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669515);
			int2.NativeMethodInfoPtr_op_Division_Public_Static_int2_int2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669516);
			int2.NativeMethodInfoPtr_op_Division_Public_Static_int2_Int32_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669517);
			int2.NativeMethodInfoPtr_op_Modulus_Public_Static_int2_int2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669518);
			int2.NativeMethodInfoPtr_op_Modulus_Public_Static_int2_int2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669519);
			int2.NativeMethodInfoPtr_op_Modulus_Public_Static_int2_Int32_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669520);
			int2.NativeMethodInfoPtr_op_Increment_Public_Static_int2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669521);
			int2.NativeMethodInfoPtr_op_Decrement_Public_Static_int2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669522);
			int2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2_int2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669523);
			int2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2_int2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669524);
			int2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2_Int32_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669525);
			int2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2_int2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669526);
			int2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2_int2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669527);
			int2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2_Int32_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669528);
			int2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2_int2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669529);
			int2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2_int2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669530);
			int2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2_Int32_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669531);
			int2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2_int2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669532);
			int2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2_int2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669533);
			int2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2_Int32_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669534);
			int2.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_int2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669535);
			int2.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_int2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669536);
			int2.NativeMethodInfoPtr_op_LeftShift_Public_Static_int2_int2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669537);
			int2.NativeMethodInfoPtr_op_RightShift_Public_Static_int2_int2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669538);
			int2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2_int2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669539);
			int2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2_int2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669540);
			int2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2_Int32_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669541);
			int2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_int2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669542);
			int2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_int2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669543);
			int2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_Int32_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669544);
			int2.NativeMethodInfoPtr_op_OnesComplement_Public_Static_int2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669545);
			int2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int2_int2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669546);
			int2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int2_int2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669547);
			int2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int2_Int32_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669548);
			int2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int2_int2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669549);
			int2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int2_int2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669550);
			int2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int2_Int32_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669551);
			int2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int2_int2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669552);
			int2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int2_int2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669553);
			int2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int2_Int32_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669554);
			int2.NativeMethodInfoPtr_get_xxxx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669555);
			int2.NativeMethodInfoPtr_get_xxxy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669556);
			int2.NativeMethodInfoPtr_get_xxyx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669557);
			int2.NativeMethodInfoPtr_get_xxyy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669558);
			int2.NativeMethodInfoPtr_get_xyxx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669559);
			int2.NativeMethodInfoPtr_get_xyxy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669560);
			int2.NativeMethodInfoPtr_get_xyyx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669561);
			int2.NativeMethodInfoPtr_get_xyyy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669562);
			int2.NativeMethodInfoPtr_get_yxxx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669563);
			int2.NativeMethodInfoPtr_get_yxxy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669564);
			int2.NativeMethodInfoPtr_get_yxyx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669565);
			int2.NativeMethodInfoPtr_get_yxyy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669566);
			int2.NativeMethodInfoPtr_get_yyxx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669567);
			int2.NativeMethodInfoPtr_get_yyxy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669568);
			int2.NativeMethodInfoPtr_get_yyyx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669569);
			int2.NativeMethodInfoPtr_get_yyyy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669570);
			int2.NativeMethodInfoPtr_get_xxx_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669571);
			int2.NativeMethodInfoPtr_get_xxy_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669572);
			int2.NativeMethodInfoPtr_get_xyx_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669573);
			int2.NativeMethodInfoPtr_get_xyy_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669574);
			int2.NativeMethodInfoPtr_get_yxx_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669575);
			int2.NativeMethodInfoPtr_get_yxy_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669576);
			int2.NativeMethodInfoPtr_get_yyx_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669577);
			int2.NativeMethodInfoPtr_get_yyy_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669578);
			int2.NativeMethodInfoPtr_get_xx_Public_get_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669579);
			int2.NativeMethodInfoPtr_get_xy_Public_get_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669580);
			int2.NativeMethodInfoPtr_set_xy_Public_set_Void_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669581);
			int2.NativeMethodInfoPtr_get_yx_Public_get_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669582);
			int2.NativeMethodInfoPtr_set_yx_Public_set_Void_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669583);
			int2.NativeMethodInfoPtr_get_yy_Public_get_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669584);
			int2.NativeMethodInfoPtr_get_Item_Public_get_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669585);
			int2.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669586);
			int2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669587);
			int2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669588);
			int2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669589);
			int2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669590);
			int2.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2>.NativeClassPtr, 100669591);
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x000831CC File Offset: 0x000813CC
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 283577, RefRangeEnd = 283616, XrefRangeStart = 283577, XrefRangeEnd = 283616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int2(int x, int y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x0008320C File Offset: 0x0008140C
		[CallerCount(0)]
		public unsafe int2(int2 xy)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xy;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr__ctor_Public_Void_int2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x00083240 File Offset: 0x00081440
		[CallerCount(0)]
		public unsafe int2(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018E5 RID: 6373 RVA: 0x00083274 File Offset: 0x00081474
		[CallerCount(0)]
		public unsafe int2(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x000832A8 File Offset: 0x000814A8
		[CallerCount(0)]
		public unsafe int2(bool2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr__ctor_Public_Void_bool2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x000832DC File Offset: 0x000814DC
		[CallerCount(0)]
		public unsafe int2(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x00083310 File Offset: 0x00081510
		[CallerCount(0)]
		public unsafe int2(uint2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr__ctor_Public_Void_uint2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x00083344 File Offset: 0x00081544
		[CallerCount(0)]
		public unsafe int2(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x00083378 File Offset: 0x00081578
		[CallerCount(0)]
		public unsafe int2(float2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr__ctor_Public_Void_float2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018EB RID: 6379 RVA: 0x000833AC File Offset: 0x000815AC
		[CallerCount(0)]
		public unsafe int2(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018EC RID: 6380 RVA: 0x000833E0 File Offset: 0x000815E0
		[CallerCount(0)]
		public unsafe int2(double2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr__ctor_Public_Void_double2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018ED RID: 6381 RVA: 0x00083414 File Offset: 0x00081614
		[CallerCount(0)]
		public unsafe static implicit operator int2(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_Implicit_Public_Static_int2_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018EE RID: 6382 RVA: 0x00083454 File Offset: 0x00081654
		[CallerCount(0)]
		public unsafe static explicit operator int2(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_Explicit_Public_Static_int2_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018EF RID: 6383 RVA: 0x00083494 File Offset: 0x00081694
		[CallerCount(0)]
		public unsafe static explicit operator int2(bool2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_Explicit_Public_Static_int2_bool2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018F0 RID: 6384 RVA: 0x000834D4 File Offset: 0x000816D4
		[CallerCount(0)]
		public unsafe static explicit operator int2(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_Explicit_Public_Static_int2_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018F1 RID: 6385 RVA: 0x00083514 File Offset: 0x00081714
		[CallerCount(0)]
		public unsafe static explicit operator int2(uint2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_Explicit_Public_Static_int2_uint2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x00083554 File Offset: 0x00081754
		[CallerCount(0)]
		public unsafe static explicit operator int2(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_Explicit_Public_Static_int2_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018F3 RID: 6387 RVA: 0x00083594 File Offset: 0x00081794
		[CallerCount(0)]
		public unsafe static explicit operator int2(float2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_Explicit_Public_Static_int2_float2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018F4 RID: 6388 RVA: 0x000835D4 File Offset: 0x000817D4
		[CallerCount(0)]
		public unsafe static explicit operator int2(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_Explicit_Public_Static_int2_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x00083614 File Offset: 0x00081814
		[CallerCount(0)]
		public unsafe static explicit operator int2(double2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_Explicit_Public_Static_int2_double2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018F6 RID: 6390 RVA: 0x00083654 File Offset: 0x00081854
		[CallerCount(0)]
		public unsafe static int2 operator *(int2 lhs, int2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_Multiply_Public_Static_int2_int2_int2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018F7 RID: 6391 RVA: 0x000836A0 File Offset: 0x000818A0
		[CallerCount(0)]
		public unsafe static int2 operator *(int2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_Multiply_Public_Static_int2_int2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018F8 RID: 6392 RVA: 0x000836EC File Offset: 0x000818EC
		[CallerCount(0)]
		public unsafe static int2 operator *(int lhs, int2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_Multiply_Public_Static_int2_Int32_int2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018F9 RID: 6393 RVA: 0x00083738 File Offset: 0x00081938
		[CallerCount(0)]
		public unsafe static int2 operator +(int2 lhs, int2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_Addition_Public_Static_int2_int2_int2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018FA RID: 6394 RVA: 0x00083784 File Offset: 0x00081984
		[CallerCount(0)]
		public unsafe static int2 operator +(int2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_Addition_Public_Static_int2_int2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018FB RID: 6395 RVA: 0x000837D0 File Offset: 0x000819D0
		[CallerCount(0)]
		public unsafe static int2 operator +(int lhs, int2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_Addition_Public_Static_int2_Int32_int2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018FC RID: 6396 RVA: 0x0008381C File Offset: 0x00081A1C
		[CallerCount(0)]
		public unsafe static int2 operator -(int2 lhs, int2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_Subtraction_Public_Static_int2_int2_int2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x00083868 File Offset: 0x00081A68
		[CallerCount(0)]
		public unsafe static int2 operator -(int2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_Subtraction_Public_Static_int2_int2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x000838B4 File Offset: 0x00081AB4
		[CallerCount(0)]
		public unsafe static int2 operator -(int lhs, int2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_Subtraction_Public_Static_int2_Int32_int2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x00083900 File Offset: 0x00081B00
		[CallerCount(0)]
		public unsafe static int2 operator /(int2 lhs, int2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_Division_Public_Static_int2_int2_int2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x0008394C File Offset: 0x00081B4C
		[CallerCount(0)]
		public unsafe static int2 operator /(int2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_Division_Public_Static_int2_int2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001901 RID: 6401 RVA: 0x00083998 File Offset: 0x00081B98
		[CallerCount(0)]
		public unsafe static int2 operator /(int lhs, int2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_Division_Public_Static_int2_Int32_int2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001902 RID: 6402 RVA: 0x000839E4 File Offset: 0x00081BE4
		[CallerCount(0)]
		public unsafe static int2 operator %(int2 lhs, int2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_Modulus_Public_Static_int2_int2_int2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001903 RID: 6403 RVA: 0x00083A30 File Offset: 0x00081C30
		[CallerCount(0)]
		public unsafe static int2 operator %(int2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_Modulus_Public_Static_int2_int2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001904 RID: 6404 RVA: 0x00083A7C File Offset: 0x00081C7C
		[CallerCount(0)]
		public unsafe static int2 operator %(int lhs, int2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_Modulus_Public_Static_int2_Int32_int2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001905 RID: 6405 RVA: 0x00083AC8 File Offset: 0x00081CC8
		[CallerCount(0)]
		public unsafe static int2 operator ++(int2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_Increment_Public_Static_int2_int2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001906 RID: 6406 RVA: 0x00083B08 File Offset: 0x00081D08
		[CallerCount(0)]
		public unsafe static int2 operator --(int2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_Decrement_Public_Static_int2_int2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001907 RID: 6407 RVA: 0x00083B48 File Offset: 0x00081D48
		[CallerCount(0)]
		public unsafe static bool2 operator <(int2 lhs, int2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2_int2_int2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001908 RID: 6408 RVA: 0x00083B94 File Offset: 0x00081D94
		[CallerCount(0)]
		public unsafe static bool2 operator <(int2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2_int2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001909 RID: 6409 RVA: 0x00083BE0 File Offset: 0x00081DE0
		[CallerCount(0)]
		public unsafe static bool2 operator <(int lhs, int2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2_Int32_int2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600190A RID: 6410 RVA: 0x00083C2C File Offset: 0x00081E2C
		[CallerCount(0)]
		public unsafe static bool2 operator <=(int2 lhs, int2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2_int2_int2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600190B RID: 6411 RVA: 0x00083C78 File Offset: 0x00081E78
		[CallerCount(0)]
		public unsafe static bool2 operator <=(int2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2_int2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600190C RID: 6412 RVA: 0x00083CC4 File Offset: 0x00081EC4
		[CallerCount(0)]
		public unsafe static bool2 operator <=(int lhs, int2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2_Int32_int2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600190D RID: 6413 RVA: 0x00083D10 File Offset: 0x00081F10
		[CallerCount(0)]
		public unsafe static bool2 operator >(int2 lhs, int2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2_int2_int2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600190E RID: 6414 RVA: 0x00083D5C File Offset: 0x00081F5C
		[CallerCount(0)]
		public unsafe static bool2 operator >(int2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2_int2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600190F RID: 6415 RVA: 0x00083DA8 File Offset: 0x00081FA8
		[CallerCount(0)]
		public unsafe static bool2 operator >(int lhs, int2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2_Int32_int2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001910 RID: 6416 RVA: 0x00083DF4 File Offset: 0x00081FF4
		[CallerCount(0)]
		public unsafe static bool2 operator >=(int2 lhs, int2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2_int2_int2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001911 RID: 6417 RVA: 0x00083E40 File Offset: 0x00082040
		[CallerCount(0)]
		public unsafe static bool2 operator >=(int2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2_int2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001912 RID: 6418 RVA: 0x00083E8C File Offset: 0x0008208C
		[CallerCount(0)]
		public unsafe static bool2 operator >=(int lhs, int2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2_Int32_int2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001913 RID: 6419 RVA: 0x00083ED8 File Offset: 0x000820D8
		[CallerCount(0)]
		public unsafe static int2 operator -(int2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_int2_int2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001914 RID: 6420 RVA: 0x00083F18 File Offset: 0x00082118
		[CallerCount(0)]
		public unsafe static int2 operator +(int2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_int2_int2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001915 RID: 6421 RVA: 0x00083F58 File Offset: 0x00082158
		[CallerCount(0)]
		public unsafe static int2 operator <<(int2 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_LeftShift_Public_Static_int2_int2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x00083FA4 File Offset: 0x000821A4
		[CallerCount(0)]
		public unsafe static int2 operator >>(int2 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_RightShift_Public_Static_int2_int2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x00083FF0 File Offset: 0x000821F0
		[CallerCount(0)]
		public unsafe static bool2 operator ==(int2 lhs, int2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2_int2_int2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x0008403C File Offset: 0x0008223C
		[CallerCount(0)]
		public unsafe static bool2 operator ==(int2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2_int2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001919 RID: 6425 RVA: 0x00084088 File Offset: 0x00082288
		[CallerCount(0)]
		public unsafe static bool2 operator ==(int lhs, int2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2_Int32_int2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x000840D4 File Offset: 0x000822D4
		[CallerCount(0)]
		public unsafe static bool2 operator !=(int2 lhs, int2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_int2_int2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600191B RID: 6427 RVA: 0x00084120 File Offset: 0x00082320
		[CallerCount(0)]
		public unsafe static bool2 operator !=(int2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_int2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600191C RID: 6428 RVA: 0x0008416C File Offset: 0x0008236C
		[CallerCount(0)]
		public unsafe static bool2 operator !=(int lhs, int2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_Int32_int2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600191D RID: 6429 RVA: 0x000841B8 File Offset: 0x000823B8
		[CallerCount(0)]
		public unsafe static int2 operator ~(int2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_OnesComplement_Public_Static_int2_int2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x000841F8 File Offset: 0x000823F8
		[CallerCount(0)]
		public unsafe static int2 operator &(int2 lhs, int2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int2_int2_int2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600191F RID: 6431 RVA: 0x00084244 File Offset: 0x00082444
		[CallerCount(0)]
		public unsafe static int2 operator &(int2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int2_int2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001920 RID: 6432 RVA: 0x00084290 File Offset: 0x00082490
		[CallerCount(0)]
		public unsafe static int2 operator &(int lhs, int2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int2_Int32_int2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x000842DC File Offset: 0x000824DC
		[CallerCount(0)]
		public unsafe static int2 operator |(int2 lhs, int2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int2_int2_int2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x00084328 File Offset: 0x00082528
		[CallerCount(0)]
		public unsafe static int2 operator |(int2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int2_int2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x00084374 File Offset: 0x00082574
		[CallerCount(0)]
		public unsafe static int2 operator |(int lhs, int2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int2_Int32_int2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001924 RID: 6436 RVA: 0x000843C0 File Offset: 0x000825C0
		[CallerCount(0)]
		public unsafe static int2 operator ^(int2 lhs, int2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int2_int2_int2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001925 RID: 6437 RVA: 0x0008440C File Offset: 0x0008260C
		[CallerCount(0)]
		public unsafe static int2 operator ^(int2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int2_int2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001926 RID: 6438 RVA: 0x00084458 File Offset: 0x00082658
		[CallerCount(0)]
		public unsafe static int2 operator ^(int lhs, int2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int2_Int32_int2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x06001927 RID: 6439 RVA: 0x000844A4 File Offset: 0x000826A4
		public unsafe int4 xxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_get_xxxx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x06001928 RID: 6440 RVA: 0x000844D4 File Offset: 0x000826D4
		public unsafe int4 xxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_get_xxxy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x06001929 RID: 6441 RVA: 0x00084504 File Offset: 0x00082704
		public unsafe int4 xxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_get_xxyx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x0600192A RID: 6442 RVA: 0x00084534 File Offset: 0x00082734
		public unsafe int4 xxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_get_xxyy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x0600192B RID: 6443 RVA: 0x00084564 File Offset: 0x00082764
		public unsafe int4 xyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_get_xyxx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x0600192C RID: 6444 RVA: 0x00084594 File Offset: 0x00082794
		public unsafe int4 xyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_get_xyxy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x0600192D RID: 6445 RVA: 0x000845C4 File Offset: 0x000827C4
		public unsafe int4 xyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_get_xyyx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x0600192E RID: 6446 RVA: 0x000845F4 File Offset: 0x000827F4
		public unsafe int4 xyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_get_xyyy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x0600192F RID: 6447 RVA: 0x00084624 File Offset: 0x00082824
		public unsafe int4 yxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_get_yxxx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06001930 RID: 6448 RVA: 0x00084654 File Offset: 0x00082854
		public unsafe int4 yxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_get_yxxy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x06001931 RID: 6449 RVA: 0x00084684 File Offset: 0x00082884
		public unsafe int4 yxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_get_yxyx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x06001932 RID: 6450 RVA: 0x000846B4 File Offset: 0x000828B4
		public unsafe int4 yxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_get_yxyy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x06001933 RID: 6451 RVA: 0x000846E4 File Offset: 0x000828E4
		public unsafe int4 yyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_get_yyxx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x06001934 RID: 6452 RVA: 0x00084714 File Offset: 0x00082914
		public unsafe int4 yyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_get_yyxy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x06001935 RID: 6453 RVA: 0x00084744 File Offset: 0x00082944
		public unsafe int4 yyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_get_yyyx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x06001936 RID: 6454 RVA: 0x00084774 File Offset: 0x00082974
		public unsafe int4 yyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_get_yyyy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x06001937 RID: 6455 RVA: 0x000847A4 File Offset: 0x000829A4
		public unsafe int3 xxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_get_xxx_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x06001938 RID: 6456 RVA: 0x000847D4 File Offset: 0x000829D4
		public unsafe int3 xxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_get_xxy_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x06001939 RID: 6457 RVA: 0x00084804 File Offset: 0x00082A04
		public unsafe int3 xyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_get_xyx_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x0600193A RID: 6458 RVA: 0x00084834 File Offset: 0x00082A34
		public unsafe int3 xyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_get_xyy_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x0600193B RID: 6459 RVA: 0x00084864 File Offset: 0x00082A64
		public unsafe int3 yxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_get_yxx_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x0600193C RID: 6460 RVA: 0x00084894 File Offset: 0x00082A94
		public unsafe int3 yxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_get_yxy_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x0600193D RID: 6461 RVA: 0x000848C4 File Offset: 0x00082AC4
		public unsafe int3 yyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_get_yyx_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x0600193E RID: 6462 RVA: 0x000848F4 File Offset: 0x00082AF4
		public unsafe int3 yyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_get_yyy_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x0600193F RID: 6463 RVA: 0x00084924 File Offset: 0x00082B24
		public unsafe int2 xx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_get_xx_Public_get_int2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x06001940 RID: 6464 RVA: 0x00084954 File Offset: 0x00082B54
		// (set) Token: 0x06001941 RID: 6465 RVA: 0x00084984 File Offset: 0x00082B84
		public unsafe int2 xy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_get_xy_Public_get_int2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_set_xy_Public_set_Void_int2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x06001942 RID: 6466 RVA: 0x000849B8 File Offset: 0x00082BB8
		// (set) Token: 0x06001943 RID: 6467 RVA: 0x000849E8 File Offset: 0x00082BE8
		public unsafe int2 yx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_get_yx_Public_get_int2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_set_yx_Public_set_Void_int2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x06001944 RID: 6468 RVA: 0x00084A1C File Offset: 0x00082C1C
		public unsafe int2 yy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_get_yy_Public_get_int2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000805 RID: 2053
		public unsafe int this[int index]
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 639142, RefRangeEnd = 639143, XrefRangeStart = 639142, XrefRangeEnd = 639142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_get_Item_Public_get_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x00084ACC File Offset: 0x00082CCC
		[CallerCount(0)]
		public unsafe bool Equals(int2 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_int2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x00084B0C File Offset: 0x00082D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639143, XrefRangeEnd = 639146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x00084B50 File Offset: 0x00082D50
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x00084B80 File Offset: 0x00082D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639146, XrefRangeEnd = 639154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x00084BAC File Offset: 0x00082DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639154, XrefRangeEnd = 639159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x00002684 File Offset: 0x00000884
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<int2>.NativeClassPtr, ref this));
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x0600194D RID: 6477 RVA: 0x00084BFC File Offset: 0x00082DFC
		// (set) Token: 0x0600194E RID: 6478 RVA: 0x00002696 File Offset: 0x00000896
		public unsafe static int2 zero
		{
			get
			{
				int2 @int;
				IL2CPP.il2cpp_field_static_get_value(int2.NativeFieldInfoPtr_zero, (void*)(&@int));
				return @int;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(int2.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x0400193F RID: 6463
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x04001940 RID: 6464
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04001941 RID: 6465
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x04001942 RID: 6466
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x04001943 RID: 6467
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int2_0;

		// Token: 0x04001944 RID: 6468
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001945 RID: 6469
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04001946 RID: 6470
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool2_0;

		// Token: 0x04001947 RID: 6471
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04001948 RID: 6472
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint2_0;

		// Token: 0x04001949 RID: 6473
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x0400194A RID: 6474
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float2_0;

		// Token: 0x0400194B RID: 6475
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x0400194C RID: 6476
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double2_0;

		// Token: 0x0400194D RID: 6477
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_int2_Int32_0;

		// Token: 0x0400194E RID: 6478
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int2_Boolean_0;

		// Token: 0x0400194F RID: 6479
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int2_bool2_0;

		// Token: 0x04001950 RID: 6480
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int2_UInt32_0;

		// Token: 0x04001951 RID: 6481
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int2_uint2_0;

		// Token: 0x04001952 RID: 6482
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int2_Single_0;

		// Token: 0x04001953 RID: 6483
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int2_float2_0;

		// Token: 0x04001954 RID: 6484
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int2_Double_0;

		// Token: 0x04001955 RID: 6485
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int2_double2_0;

		// Token: 0x04001956 RID: 6486
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_int2_int2_int2_0;

		// Token: 0x04001957 RID: 6487
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_int2_int2_Int32_0;

		// Token: 0x04001958 RID: 6488
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_int2_Int32_int2_0;

		// Token: 0x04001959 RID: 6489
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_int2_int2_int2_0;

		// Token: 0x0400195A RID: 6490
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_int2_int2_Int32_0;

		// Token: 0x0400195B RID: 6491
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_int2_Int32_int2_0;

		// Token: 0x0400195C RID: 6492
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_int2_int2_int2_0;

		// Token: 0x0400195D RID: 6493
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_int2_int2_Int32_0;

		// Token: 0x0400195E RID: 6494
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_int2_Int32_int2_0;

		// Token: 0x0400195F RID: 6495
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_int2_int2_int2_0;

		// Token: 0x04001960 RID: 6496
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_int2_int2_Int32_0;

		// Token: 0x04001961 RID: 6497
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_int2_Int32_int2_0;

		// Token: 0x04001962 RID: 6498
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_int2_int2_int2_0;

		// Token: 0x04001963 RID: 6499
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_int2_int2_Int32_0;

		// Token: 0x04001964 RID: 6500
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_int2_Int32_int2_0;

		// Token: 0x04001965 RID: 6501
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_int2_int2_0;

		// Token: 0x04001966 RID: 6502
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_int2_int2_0;

		// Token: 0x04001967 RID: 6503
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2_int2_int2_0;

		// Token: 0x04001968 RID: 6504
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2_int2_Int32_0;

		// Token: 0x04001969 RID: 6505
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2_Int32_int2_0;

		// Token: 0x0400196A RID: 6506
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2_int2_int2_0;

		// Token: 0x0400196B RID: 6507
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2_int2_Int32_0;

		// Token: 0x0400196C RID: 6508
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2_Int32_int2_0;

		// Token: 0x0400196D RID: 6509
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2_int2_int2_0;

		// Token: 0x0400196E RID: 6510
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2_int2_Int32_0;

		// Token: 0x0400196F RID: 6511
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2_Int32_int2_0;

		// Token: 0x04001970 RID: 6512
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2_int2_int2_0;

		// Token: 0x04001971 RID: 6513
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2_int2_Int32_0;

		// Token: 0x04001972 RID: 6514
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2_Int32_int2_0;

		// Token: 0x04001973 RID: 6515
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_int2_int2_0;

		// Token: 0x04001974 RID: 6516
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryPlus_Public_Static_int2_int2_0;

		// Token: 0x04001975 RID: 6517
		private static readonly IntPtr NativeMethodInfoPtr_op_LeftShift_Public_Static_int2_int2_Int32_0;

		// Token: 0x04001976 RID: 6518
		private static readonly IntPtr NativeMethodInfoPtr_op_RightShift_Public_Static_int2_int2_Int32_0;

		// Token: 0x04001977 RID: 6519
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2_int2_int2_0;

		// Token: 0x04001978 RID: 6520
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2_int2_Int32_0;

		// Token: 0x04001979 RID: 6521
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2_Int32_int2_0;

		// Token: 0x0400197A RID: 6522
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_int2_int2_0;

		// Token: 0x0400197B RID: 6523
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_int2_Int32_0;

		// Token: 0x0400197C RID: 6524
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_Int32_int2_0;

		// Token: 0x0400197D RID: 6525
		private static readonly IntPtr NativeMethodInfoPtr_op_OnesComplement_Public_Static_int2_int2_0;

		// Token: 0x0400197E RID: 6526
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int2_int2_int2_0;

		// Token: 0x0400197F RID: 6527
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int2_int2_Int32_0;

		// Token: 0x04001980 RID: 6528
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int2_Int32_int2_0;

		// Token: 0x04001981 RID: 6529
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int2_int2_int2_0;

		// Token: 0x04001982 RID: 6530
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int2_int2_Int32_0;

		// Token: 0x04001983 RID: 6531
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int2_Int32_int2_0;

		// Token: 0x04001984 RID: 6532
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int2_int2_int2_0;

		// Token: 0x04001985 RID: 6533
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int2_int2_Int32_0;

		// Token: 0x04001986 RID: 6534
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int2_Int32_int2_0;

		// Token: 0x04001987 RID: 6535
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxx_Public_get_int4_0;

		// Token: 0x04001988 RID: 6536
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxy_Public_get_int4_0;

		// Token: 0x04001989 RID: 6537
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyx_Public_get_int4_0;

		// Token: 0x0400198A RID: 6538
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyy_Public_get_int4_0;

		// Token: 0x0400198B RID: 6539
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxx_Public_get_int4_0;

		// Token: 0x0400198C RID: 6540
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxy_Public_get_int4_0;

		// Token: 0x0400198D RID: 6541
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyx_Public_get_int4_0;

		// Token: 0x0400198E RID: 6542
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyy_Public_get_int4_0;

		// Token: 0x0400198F RID: 6543
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxx_Public_get_int4_0;

		// Token: 0x04001990 RID: 6544
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxy_Public_get_int4_0;

		// Token: 0x04001991 RID: 6545
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyx_Public_get_int4_0;

		// Token: 0x04001992 RID: 6546
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyy_Public_get_int4_0;

		// Token: 0x04001993 RID: 6547
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxx_Public_get_int4_0;

		// Token: 0x04001994 RID: 6548
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxy_Public_get_int4_0;

		// Token: 0x04001995 RID: 6549
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyx_Public_get_int4_0;

		// Token: 0x04001996 RID: 6550
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyy_Public_get_int4_0;

		// Token: 0x04001997 RID: 6551
		private static readonly IntPtr NativeMethodInfoPtr_get_xxx_Public_get_int3_0;

		// Token: 0x04001998 RID: 6552
		private static readonly IntPtr NativeMethodInfoPtr_get_xxy_Public_get_int3_0;

		// Token: 0x04001999 RID: 6553
		private static readonly IntPtr NativeMethodInfoPtr_get_xyx_Public_get_int3_0;

		// Token: 0x0400199A RID: 6554
		private static readonly IntPtr NativeMethodInfoPtr_get_xyy_Public_get_int3_0;

		// Token: 0x0400199B RID: 6555
		private static readonly IntPtr NativeMethodInfoPtr_get_yxx_Public_get_int3_0;

		// Token: 0x0400199C RID: 6556
		private static readonly IntPtr NativeMethodInfoPtr_get_yxy_Public_get_int3_0;

		// Token: 0x0400199D RID: 6557
		private static readonly IntPtr NativeMethodInfoPtr_get_yyx_Public_get_int3_0;

		// Token: 0x0400199E RID: 6558
		private static readonly IntPtr NativeMethodInfoPtr_get_yyy_Public_get_int3_0;

		// Token: 0x0400199F RID: 6559
		private static readonly IntPtr NativeMethodInfoPtr_get_xx_Public_get_int2_0;

		// Token: 0x040019A0 RID: 6560
		private static readonly IntPtr NativeMethodInfoPtr_get_xy_Public_get_int2_0;

		// Token: 0x040019A1 RID: 6561
		private static readonly IntPtr NativeMethodInfoPtr_set_xy_Public_set_Void_int2_0;

		// Token: 0x040019A2 RID: 6562
		private static readonly IntPtr NativeMethodInfoPtr_get_yx_Public_get_int2_0;

		// Token: 0x040019A3 RID: 6563
		private static readonly IntPtr NativeMethodInfoPtr_set_yx_Public_set_Void_int2_0;

		// Token: 0x040019A4 RID: 6564
		private static readonly IntPtr NativeMethodInfoPtr_get_yy_Public_get_int2_0;

		// Token: 0x040019A5 RID: 6565
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Int32_Int32_0;

		// Token: 0x040019A6 RID: 6566
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_0;

		// Token: 0x040019A7 RID: 6567
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_int2_0;

		// Token: 0x040019A8 RID: 6568
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040019A9 RID: 6569
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040019AA RID: 6570
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040019AB RID: 6571
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x040019AC RID: 6572
		[FieldOffset(0)]
		public int x;

		// Token: 0x040019AD RID: 6573
		[FieldOffset(4)]
		public int y;

		// Token: 0x02000060 RID: 96
		public sealed class DebuggerProxy : Object
		{
			// Token: 0x06002625 RID: 9765 RVA: 0x000C3C2C File Offset: 0x000C1E2C
			// Note: this type is marked as 'beforefieldinit'.
			static DebuggerProxy()
			{
				Il2CppClassPointerStore<int2.DebuggerProxy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<int2>.NativeClassPtr, "DebuggerProxy");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<int2.DebuggerProxy>.NativeClassPtr);
				int2.DebuggerProxy.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int2.DebuggerProxy>.NativeClassPtr, "x");
				int2.DebuggerProxy.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int2.DebuggerProxy>.NativeClassPtr, "y");
				int2.DebuggerProxy.NativeMethodInfoPtr__ctor_Public_Void_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2.DebuggerProxy>.NativeClassPtr, 100669592);
			}

			// Token: 0x06002626 RID: 9766 RVA: 0x000C3C94 File Offset: 0x000C1E94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639141, XrefRangeEnd = 639142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DebuggerProxy(int2 v)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<int2.DebuggerProxy>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2.DebuggerProxy.NativeMethodInfoPtr__ctor_Public_Void_int2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002627 RID: 9767 RVA: 0x0000300F File Offset: 0x0000120F
			public DebuggerProxy(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C15 RID: 3093
			// (get) Token: 0x06002628 RID: 9768 RVA: 0x000C3CDC File Offset: 0x000C1EDC
			// (set) Token: 0x06002629 RID: 9769 RVA: 0x00003018 File Offset: 0x00001218
			public unsafe int x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(int2.DebuggerProxy.NativeFieldInfoPtr_x);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(int2.DebuggerProxy.NativeFieldInfoPtr_x)) = value;
				}
			}

			// Token: 0x17000C16 RID: 3094
			// (get) Token: 0x0600262A RID: 9770 RVA: 0x000C3D04 File Offset: 0x000C1F04
			// (set) Token: 0x0600262B RID: 9771 RVA: 0x00003033 File Offset: 0x00001233
			public unsafe int y
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(int2.DebuggerProxy.NativeFieldInfoPtr_y);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(int2.DebuggerProxy.NativeFieldInfoPtr_y)) = value;
				}
			}

			// Token: 0x0400268C RID: 9868
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x0400268D RID: 9869
			private static readonly IntPtr NativeFieldInfoPtr_y;

			// Token: 0x0400268E RID: 9870
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int2_0;
		}
	}
}
