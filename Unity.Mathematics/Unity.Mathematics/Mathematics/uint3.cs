using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x02000043 RID: 67
	[Serializable]
	[StructLayout(2)]
	public struct uint3
	{
		// Token: 0x060020E5 RID: 8421 RVA: 0x000AB4B0 File Offset: 0x000A96B0
		// Note: this type is marked as 'beforefieldinit'.
		static uint3()
		{
			Il2CppClassPointerStore<uint3>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "uint3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<uint3>.NativeClassPtr);
			uint3.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint3>.NativeClassPtr, "x");
			uint3.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint3>.NativeClassPtr, "y");
			uint3.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint3>.NativeClassPtr, "z");
			uint3.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint3>.NativeClassPtr, "zero");
			uint3.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671460);
			uint3.NativeMethodInfoPtr__ctor_Public_Void_UInt32_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671461);
			uint3.NativeMethodInfoPtr__ctor_Public_Void_uint2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671462);
			uint3.NativeMethodInfoPtr__ctor_Public_Void_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671463);
			uint3.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671464);
			uint3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671465);
			uint3.NativeMethodInfoPtr__ctor_Public_Void_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671466);
			uint3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671467);
			uint3.NativeMethodInfoPtr__ctor_Public_Void_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671468);
			uint3.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671469);
			uint3.NativeMethodInfoPtr__ctor_Public_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671470);
			uint3.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671471);
			uint3.NativeMethodInfoPtr__ctor_Public_Void_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671472);
			uint3.NativeMethodInfoPtr_op_Implicit_Public_Static_uint3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671473);
			uint3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671474);
			uint3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671475);
			uint3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671476);
			uint3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671477);
			uint3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671478);
			uint3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671479);
			uint3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671480);
			uint3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671481);
			uint3.NativeMethodInfoPtr_op_Multiply_Public_Static_uint3_uint3_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671482);
			uint3.NativeMethodInfoPtr_op_Multiply_Public_Static_uint3_uint3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671483);
			uint3.NativeMethodInfoPtr_op_Multiply_Public_Static_uint3_UInt32_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671484);
			uint3.NativeMethodInfoPtr_op_Addition_Public_Static_uint3_uint3_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671485);
			uint3.NativeMethodInfoPtr_op_Addition_Public_Static_uint3_uint3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671486);
			uint3.NativeMethodInfoPtr_op_Addition_Public_Static_uint3_UInt32_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671487);
			uint3.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint3_uint3_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671488);
			uint3.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint3_uint3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671489);
			uint3.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint3_UInt32_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671490);
			uint3.NativeMethodInfoPtr_op_Division_Public_Static_uint3_uint3_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671491);
			uint3.NativeMethodInfoPtr_op_Division_Public_Static_uint3_uint3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671492);
			uint3.NativeMethodInfoPtr_op_Division_Public_Static_uint3_UInt32_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671493);
			uint3.NativeMethodInfoPtr_op_Modulus_Public_Static_uint3_uint3_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671494);
			uint3.NativeMethodInfoPtr_op_Modulus_Public_Static_uint3_uint3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671495);
			uint3.NativeMethodInfoPtr_op_Modulus_Public_Static_uint3_UInt32_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671496);
			uint3.NativeMethodInfoPtr_op_Increment_Public_Static_uint3_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671497);
			uint3.NativeMethodInfoPtr_op_Decrement_Public_Static_uint3_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671498);
			uint3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3_uint3_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671499);
			uint3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3_uint3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671500);
			uint3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3_UInt32_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671501);
			uint3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3_uint3_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671502);
			uint3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3_uint3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671503);
			uint3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3_UInt32_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671504);
			uint3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3_uint3_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671505);
			uint3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3_uint3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671506);
			uint3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3_UInt32_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671507);
			uint3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3_uint3_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671508);
			uint3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3_uint3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671509);
			uint3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3_UInt32_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671510);
			uint3.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_uint3_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671511);
			uint3.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_uint3_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671512);
			uint3.NativeMethodInfoPtr_op_LeftShift_Public_Static_uint3_uint3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671513);
			uint3.NativeMethodInfoPtr_op_RightShift_Public_Static_uint3_uint3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671514);
			uint3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3_uint3_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671515);
			uint3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3_uint3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671516);
			uint3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3_UInt32_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671517);
			uint3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_uint3_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671518);
			uint3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_uint3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671519);
			uint3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_UInt32_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671520);
			uint3.NativeMethodInfoPtr_op_OnesComplement_Public_Static_uint3_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671521);
			uint3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint3_uint3_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671522);
			uint3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint3_uint3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671523);
			uint3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint3_UInt32_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671524);
			uint3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint3_uint3_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671525);
			uint3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint3_uint3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671526);
			uint3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint3_UInt32_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671527);
			uint3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint3_uint3_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671528);
			uint3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint3_uint3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671529);
			uint3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint3_UInt32_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671530);
			uint3.NativeMethodInfoPtr_get_xxxx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671531);
			uint3.NativeMethodInfoPtr_get_xxxy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671532);
			uint3.NativeMethodInfoPtr_get_xxxz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671533);
			uint3.NativeMethodInfoPtr_get_xxyx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671534);
			uint3.NativeMethodInfoPtr_get_xxyy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671535);
			uint3.NativeMethodInfoPtr_get_xxyz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671536);
			uint3.NativeMethodInfoPtr_get_xxzx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671537);
			uint3.NativeMethodInfoPtr_get_xxzy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671538);
			uint3.NativeMethodInfoPtr_get_xxzz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671539);
			uint3.NativeMethodInfoPtr_get_xyxx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671540);
			uint3.NativeMethodInfoPtr_get_xyxy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671541);
			uint3.NativeMethodInfoPtr_get_xyxz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671542);
			uint3.NativeMethodInfoPtr_get_xyyx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671543);
			uint3.NativeMethodInfoPtr_get_xyyy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671544);
			uint3.NativeMethodInfoPtr_get_xyyz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671545);
			uint3.NativeMethodInfoPtr_get_xyzx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671546);
			uint3.NativeMethodInfoPtr_get_xyzy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671547);
			uint3.NativeMethodInfoPtr_get_xyzz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671548);
			uint3.NativeMethodInfoPtr_get_xzxx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671549);
			uint3.NativeMethodInfoPtr_get_xzxy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671550);
			uint3.NativeMethodInfoPtr_get_xzxz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671551);
			uint3.NativeMethodInfoPtr_get_xzyx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671552);
			uint3.NativeMethodInfoPtr_get_xzyy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671553);
			uint3.NativeMethodInfoPtr_get_xzyz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671554);
			uint3.NativeMethodInfoPtr_get_xzzx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671555);
			uint3.NativeMethodInfoPtr_get_xzzy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671556);
			uint3.NativeMethodInfoPtr_get_xzzz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671557);
			uint3.NativeMethodInfoPtr_get_yxxx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671558);
			uint3.NativeMethodInfoPtr_get_yxxy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671559);
			uint3.NativeMethodInfoPtr_get_yxxz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671560);
			uint3.NativeMethodInfoPtr_get_yxyx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671561);
			uint3.NativeMethodInfoPtr_get_yxyy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671562);
			uint3.NativeMethodInfoPtr_get_yxyz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671563);
			uint3.NativeMethodInfoPtr_get_yxzx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671564);
			uint3.NativeMethodInfoPtr_get_yxzy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671565);
			uint3.NativeMethodInfoPtr_get_yxzz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671566);
			uint3.NativeMethodInfoPtr_get_yyxx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671567);
			uint3.NativeMethodInfoPtr_get_yyxy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671568);
			uint3.NativeMethodInfoPtr_get_yyxz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671569);
			uint3.NativeMethodInfoPtr_get_yyyx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671570);
			uint3.NativeMethodInfoPtr_get_yyyy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671571);
			uint3.NativeMethodInfoPtr_get_yyyz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671572);
			uint3.NativeMethodInfoPtr_get_yyzx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671573);
			uint3.NativeMethodInfoPtr_get_yyzy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671574);
			uint3.NativeMethodInfoPtr_get_yyzz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671575);
			uint3.NativeMethodInfoPtr_get_yzxx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671576);
			uint3.NativeMethodInfoPtr_get_yzxy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671577);
			uint3.NativeMethodInfoPtr_get_yzxz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671578);
			uint3.NativeMethodInfoPtr_get_yzyx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671579);
			uint3.NativeMethodInfoPtr_get_yzyy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671580);
			uint3.NativeMethodInfoPtr_get_yzyz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671581);
			uint3.NativeMethodInfoPtr_get_yzzx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671582);
			uint3.NativeMethodInfoPtr_get_yzzy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671583);
			uint3.NativeMethodInfoPtr_get_yzzz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671584);
			uint3.NativeMethodInfoPtr_get_zxxx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671585);
			uint3.NativeMethodInfoPtr_get_zxxy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671586);
			uint3.NativeMethodInfoPtr_get_zxxz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671587);
			uint3.NativeMethodInfoPtr_get_zxyx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671588);
			uint3.NativeMethodInfoPtr_get_zxyy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671589);
			uint3.NativeMethodInfoPtr_get_zxyz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671590);
			uint3.NativeMethodInfoPtr_get_zxzx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671591);
			uint3.NativeMethodInfoPtr_get_zxzy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671592);
			uint3.NativeMethodInfoPtr_get_zxzz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671593);
			uint3.NativeMethodInfoPtr_get_zyxx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671594);
			uint3.NativeMethodInfoPtr_get_zyxy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671595);
			uint3.NativeMethodInfoPtr_get_zyxz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671596);
			uint3.NativeMethodInfoPtr_get_zyyx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671597);
			uint3.NativeMethodInfoPtr_get_zyyy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671598);
			uint3.NativeMethodInfoPtr_get_zyyz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671599);
			uint3.NativeMethodInfoPtr_get_zyzx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671600);
			uint3.NativeMethodInfoPtr_get_zyzy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671601);
			uint3.NativeMethodInfoPtr_get_zyzz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671602);
			uint3.NativeMethodInfoPtr_get_zzxx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671603);
			uint3.NativeMethodInfoPtr_get_zzxy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671604);
			uint3.NativeMethodInfoPtr_get_zzxz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671605);
			uint3.NativeMethodInfoPtr_get_zzyx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671606);
			uint3.NativeMethodInfoPtr_get_zzyy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671607);
			uint3.NativeMethodInfoPtr_get_zzyz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671608);
			uint3.NativeMethodInfoPtr_get_zzzx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671609);
			uint3.NativeMethodInfoPtr_get_zzzy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671610);
			uint3.NativeMethodInfoPtr_get_zzzz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671611);
			uint3.NativeMethodInfoPtr_get_xxx_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671612);
			uint3.NativeMethodInfoPtr_get_xxy_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671613);
			uint3.NativeMethodInfoPtr_get_xxz_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671614);
			uint3.NativeMethodInfoPtr_get_xyx_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671615);
			uint3.NativeMethodInfoPtr_get_xyy_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671616);
			uint3.NativeMethodInfoPtr_get_xyz_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671617);
			uint3.NativeMethodInfoPtr_set_xyz_Public_set_Void_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671618);
			uint3.NativeMethodInfoPtr_get_xzx_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671619);
			uint3.NativeMethodInfoPtr_get_xzy_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671620);
			uint3.NativeMethodInfoPtr_set_xzy_Public_set_Void_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671621);
			uint3.NativeMethodInfoPtr_get_xzz_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671622);
			uint3.NativeMethodInfoPtr_get_yxx_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671623);
			uint3.NativeMethodInfoPtr_get_yxy_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671624);
			uint3.NativeMethodInfoPtr_get_yxz_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671625);
			uint3.NativeMethodInfoPtr_set_yxz_Public_set_Void_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671626);
			uint3.NativeMethodInfoPtr_get_yyx_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671627);
			uint3.NativeMethodInfoPtr_get_yyy_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671628);
			uint3.NativeMethodInfoPtr_get_yyz_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671629);
			uint3.NativeMethodInfoPtr_get_yzx_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671630);
			uint3.NativeMethodInfoPtr_set_yzx_Public_set_Void_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671631);
			uint3.NativeMethodInfoPtr_get_yzy_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671632);
			uint3.NativeMethodInfoPtr_get_yzz_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671633);
			uint3.NativeMethodInfoPtr_get_zxx_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671634);
			uint3.NativeMethodInfoPtr_get_zxy_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671635);
			uint3.NativeMethodInfoPtr_set_zxy_Public_set_Void_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671636);
			uint3.NativeMethodInfoPtr_get_zxz_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671637);
			uint3.NativeMethodInfoPtr_get_zyx_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671638);
			uint3.NativeMethodInfoPtr_set_zyx_Public_set_Void_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671639);
			uint3.NativeMethodInfoPtr_get_zyy_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671640);
			uint3.NativeMethodInfoPtr_get_zyz_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671641);
			uint3.NativeMethodInfoPtr_get_zzx_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671642);
			uint3.NativeMethodInfoPtr_get_zzy_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671643);
			uint3.NativeMethodInfoPtr_get_zzz_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671644);
			uint3.NativeMethodInfoPtr_get_xx_Public_get_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671645);
			uint3.NativeMethodInfoPtr_get_xy_Public_get_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671646);
			uint3.NativeMethodInfoPtr_set_xy_Public_set_Void_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671647);
			uint3.NativeMethodInfoPtr_get_xz_Public_get_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671648);
			uint3.NativeMethodInfoPtr_set_xz_Public_set_Void_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671649);
			uint3.NativeMethodInfoPtr_get_yx_Public_get_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671650);
			uint3.NativeMethodInfoPtr_set_yx_Public_set_Void_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671651);
			uint3.NativeMethodInfoPtr_get_yy_Public_get_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671652);
			uint3.NativeMethodInfoPtr_get_yz_Public_get_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671653);
			uint3.NativeMethodInfoPtr_set_yz_Public_set_Void_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671654);
			uint3.NativeMethodInfoPtr_get_zx_Public_get_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671655);
			uint3.NativeMethodInfoPtr_set_zx_Public_set_Void_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671656);
			uint3.NativeMethodInfoPtr_get_zy_Public_get_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671657);
			uint3.NativeMethodInfoPtr_set_zy_Public_set_Void_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671658);
			uint3.NativeMethodInfoPtr_get_zz_Public_get_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671659);
			uint3.NativeMethodInfoPtr_get_Item_Public_get_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671660);
			uint3.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671661);
			uint3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671662);
			uint3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671663);
			uint3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671664);
			uint3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671665);
			uint3.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3>.NativeClassPtr, 100671666);
		}

		// Token: 0x060020E6 RID: 8422 RVA: 0x000AC55C File Offset: 0x000AA75C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 556229, RefRangeEnd = 556238, XrefRangeStart = 556229, XrefRangeEnd = 556238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint3(uint x, uint y, uint z)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020E7 RID: 8423 RVA: 0x000AC5AC File Offset: 0x000AA7AC
		[CallerCount(0)]
		public unsafe uint3(uint x, uint2 yz)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yz;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr__ctor_Public_Void_UInt32_uint2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020E8 RID: 8424 RVA: 0x000AC5EC File Offset: 0x000AA7EC
		[CallerCount(0)]
		public unsafe uint3(uint2 xy, uint z)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xy;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr__ctor_Public_Void_uint2_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020E9 RID: 8425 RVA: 0x000AC62C File Offset: 0x000AA82C
		[CallerCount(0)]
		public unsafe uint3(uint3 xyz)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyz;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr__ctor_Public_Void_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060020EA RID: 8426 RVA: 0x000AC660 File Offset: 0x000AA860
		[CallerCount(0)]
		public unsafe uint3(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060020EB RID: 8427 RVA: 0x000AC694 File Offset: 0x000AA894
		[CallerCount(0)]
		public unsafe uint3(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060020EC RID: 8428 RVA: 0x000AC6C8 File Offset: 0x000AA8C8
		[CallerCount(0)]
		public unsafe uint3(bool3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr__ctor_Public_Void_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060020ED RID: 8429 RVA: 0x000AC6FC File Offset: 0x000AA8FC
		[CallerCount(0)]
		public unsafe uint3(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060020EE RID: 8430 RVA: 0x000AC730 File Offset: 0x000AA930
		[CallerCount(0)]
		public unsafe uint3(int3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr__ctor_Public_Void_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060020EF RID: 8431 RVA: 0x000AC764 File Offset: 0x000AA964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641750, XrefRangeEnd = 641752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint3(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060020F0 RID: 8432 RVA: 0x000AC798 File Offset: 0x000AA998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641752, XrefRangeEnd = 641754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint3(float3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr__ctor_Public_Void_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060020F1 RID: 8433 RVA: 0x000AC7CC File Offset: 0x000AA9CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641754, XrefRangeEnd = 641756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint3(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060020F2 RID: 8434 RVA: 0x000AC800 File Offset: 0x000AAA00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641756, XrefRangeEnd = 641758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint3(double3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr__ctor_Public_Void_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060020F3 RID: 8435 RVA: 0x000AC834 File Offset: 0x000AAA34
		[CallerCount(0)]
		public unsafe static implicit operator uint3(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_Implicit_Public_Static_uint3_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020F4 RID: 8436 RVA: 0x000AC874 File Offset: 0x000AAA74
		[CallerCount(0)]
		public unsafe static explicit operator uint3(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020F5 RID: 8437 RVA: 0x000AC8B4 File Offset: 0x000AAAB4
		[CallerCount(0)]
		public unsafe static explicit operator uint3(bool3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3_bool3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020F6 RID: 8438 RVA: 0x000AC8F4 File Offset: 0x000AAAF4
		[CallerCount(0)]
		public unsafe static explicit operator uint3(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020F7 RID: 8439 RVA: 0x000AC934 File Offset: 0x000AAB34
		[CallerCount(0)]
		public unsafe static explicit operator uint3(int3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3_int3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020F8 RID: 8440 RVA: 0x000AC974 File Offset: 0x000AAB74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint3(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020F9 RID: 8441 RVA: 0x000AC9B4 File Offset: 0x000AABB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint3(float3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020FA RID: 8442 RVA: 0x000AC9F4 File Offset: 0x000AABF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint3(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020FB RID: 8443 RVA: 0x000ACA34 File Offset: 0x000AAC34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint3(double3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint3_double3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020FC RID: 8444 RVA: 0x000ACA74 File Offset: 0x000AAC74
		[CallerCount(0)]
		public unsafe static uint3 operator *(uint3 lhs, uint3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_Multiply_Public_Static_uint3_uint3_uint3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020FD RID: 8445 RVA: 0x000ACAC0 File Offset: 0x000AACC0
		[CallerCount(0)]
		public unsafe static uint3 operator *(uint3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_Multiply_Public_Static_uint3_uint3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020FE RID: 8446 RVA: 0x000ACB0C File Offset: 0x000AAD0C
		[CallerCount(0)]
		public unsafe static uint3 operator *(uint lhs, uint3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_Multiply_Public_Static_uint3_UInt32_uint3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020FF RID: 8447 RVA: 0x000ACB58 File Offset: 0x000AAD58
		[CallerCount(0)]
		public unsafe static uint3 operator +(uint3 lhs, uint3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_Addition_Public_Static_uint3_uint3_uint3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002100 RID: 8448 RVA: 0x000ACBA4 File Offset: 0x000AADA4
		[CallerCount(0)]
		public unsafe static uint3 operator +(uint3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_Addition_Public_Static_uint3_uint3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002101 RID: 8449 RVA: 0x000ACBF0 File Offset: 0x000AADF0
		[CallerCount(0)]
		public unsafe static uint3 operator +(uint lhs, uint3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_Addition_Public_Static_uint3_UInt32_uint3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002102 RID: 8450 RVA: 0x000ACC3C File Offset: 0x000AAE3C
		[CallerCount(0)]
		public unsafe static uint3 operator -(uint3 lhs, uint3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint3_uint3_uint3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002103 RID: 8451 RVA: 0x000ACC88 File Offset: 0x000AAE88
		[CallerCount(0)]
		public unsafe static uint3 operator -(uint3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint3_uint3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002104 RID: 8452 RVA: 0x000ACCD4 File Offset: 0x000AAED4
		[CallerCount(0)]
		public unsafe static uint3 operator -(uint lhs, uint3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint3_UInt32_uint3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002105 RID: 8453 RVA: 0x000ACD20 File Offset: 0x000AAF20
		[CallerCount(0)]
		public unsafe static uint3 operator /(uint3 lhs, uint3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_Division_Public_Static_uint3_uint3_uint3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002106 RID: 8454 RVA: 0x000ACD6C File Offset: 0x000AAF6C
		[CallerCount(0)]
		public unsafe static uint3 operator /(uint3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_Division_Public_Static_uint3_uint3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002107 RID: 8455 RVA: 0x000ACDB8 File Offset: 0x000AAFB8
		[CallerCount(0)]
		public unsafe static uint3 operator /(uint lhs, uint3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_Division_Public_Static_uint3_UInt32_uint3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002108 RID: 8456 RVA: 0x000ACE04 File Offset: 0x000AB004
		[CallerCount(0)]
		public unsafe static uint3 operator %(uint3 lhs, uint3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_Modulus_Public_Static_uint3_uint3_uint3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002109 RID: 8457 RVA: 0x000ACE50 File Offset: 0x000AB050
		[CallerCount(0)]
		public unsafe static uint3 operator %(uint3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_Modulus_Public_Static_uint3_uint3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600210A RID: 8458 RVA: 0x000ACE9C File Offset: 0x000AB09C
		[CallerCount(0)]
		public unsafe static uint3 operator %(uint lhs, uint3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_Modulus_Public_Static_uint3_UInt32_uint3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600210B RID: 8459 RVA: 0x000ACEE8 File Offset: 0x000AB0E8
		[CallerCount(0)]
		public unsafe static uint3 operator ++(uint3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_Increment_Public_Static_uint3_uint3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600210C RID: 8460 RVA: 0x000ACF28 File Offset: 0x000AB128
		[CallerCount(0)]
		public unsafe static uint3 operator --(uint3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_Decrement_Public_Static_uint3_uint3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600210D RID: 8461 RVA: 0x000ACF68 File Offset: 0x000AB168
		[CallerCount(0)]
		public unsafe static bool3 operator <(uint3 lhs, uint3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3_uint3_uint3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600210E RID: 8462 RVA: 0x000ACFB4 File Offset: 0x000AB1B4
		[CallerCount(0)]
		public unsafe static bool3 operator <(uint3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3_uint3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600210F RID: 8463 RVA: 0x000AD000 File Offset: 0x000AB200
		[CallerCount(0)]
		public unsafe static bool3 operator <(uint lhs, uint3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3_UInt32_uint3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002110 RID: 8464 RVA: 0x000AD04C File Offset: 0x000AB24C
		[CallerCount(0)]
		public unsafe static bool3 operator <=(uint3 lhs, uint3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3_uint3_uint3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002111 RID: 8465 RVA: 0x000AD098 File Offset: 0x000AB298
		[CallerCount(0)]
		public unsafe static bool3 operator <=(uint3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3_uint3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002112 RID: 8466 RVA: 0x000AD0E4 File Offset: 0x000AB2E4
		[CallerCount(0)]
		public unsafe static bool3 operator <=(uint lhs, uint3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3_UInt32_uint3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002113 RID: 8467 RVA: 0x000AD130 File Offset: 0x000AB330
		[CallerCount(0)]
		public unsafe static bool3 operator >(uint3 lhs, uint3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3_uint3_uint3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002114 RID: 8468 RVA: 0x000AD17C File Offset: 0x000AB37C
		[CallerCount(0)]
		public unsafe static bool3 operator >(uint3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3_uint3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002115 RID: 8469 RVA: 0x000AD1C8 File Offset: 0x000AB3C8
		[CallerCount(0)]
		public unsafe static bool3 operator >(uint lhs, uint3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3_UInt32_uint3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002116 RID: 8470 RVA: 0x000AD214 File Offset: 0x000AB414
		[CallerCount(0)]
		public unsafe static bool3 operator >=(uint3 lhs, uint3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3_uint3_uint3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002117 RID: 8471 RVA: 0x000AD260 File Offset: 0x000AB460
		[CallerCount(0)]
		public unsafe static bool3 operator >=(uint3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3_uint3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002118 RID: 8472 RVA: 0x000AD2AC File Offset: 0x000AB4AC
		[CallerCount(0)]
		public unsafe static bool3 operator >=(uint lhs, uint3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3_UInt32_uint3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002119 RID: 8473 RVA: 0x000AD2F8 File Offset: 0x000AB4F8
		[CallerCount(0)]
		public unsafe static uint3 operator -(uint3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_uint3_uint3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600211A RID: 8474 RVA: 0x000AD338 File Offset: 0x000AB538
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 637161, RefRangeEnd = 637182, XrefRangeStart = 637161, XrefRangeEnd = 637182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint3 operator +(uint3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_uint3_uint3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600211B RID: 8475 RVA: 0x000AD378 File Offset: 0x000AB578
		[CallerCount(0)]
		public unsafe static uint3 operator <<(uint3 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_LeftShift_Public_Static_uint3_uint3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600211C RID: 8476 RVA: 0x000AD3C4 File Offset: 0x000AB5C4
		[CallerCount(0)]
		public unsafe static uint3 operator >>(uint3 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_RightShift_Public_Static_uint3_uint3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600211D RID: 8477 RVA: 0x000AD410 File Offset: 0x000AB610
		[CallerCount(0)]
		public unsafe static bool3 operator ==(uint3 lhs, uint3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3_uint3_uint3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600211E RID: 8478 RVA: 0x000AD45C File Offset: 0x000AB65C
		[CallerCount(0)]
		public unsafe static bool3 operator ==(uint3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3_uint3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600211F RID: 8479 RVA: 0x000AD4A8 File Offset: 0x000AB6A8
		[CallerCount(0)]
		public unsafe static bool3 operator ==(uint lhs, uint3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3_UInt32_uint3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002120 RID: 8480 RVA: 0x000AD4F4 File Offset: 0x000AB6F4
		[CallerCount(0)]
		public unsafe static bool3 operator !=(uint3 lhs, uint3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_uint3_uint3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002121 RID: 8481 RVA: 0x000AD540 File Offset: 0x000AB740
		[CallerCount(0)]
		public unsafe static bool3 operator !=(uint3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_uint3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002122 RID: 8482 RVA: 0x000AD58C File Offset: 0x000AB78C
		[CallerCount(0)]
		public unsafe static bool3 operator !=(uint lhs, uint3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_UInt32_uint3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002123 RID: 8483 RVA: 0x000AD5D8 File Offset: 0x000AB7D8
		[CallerCount(0)]
		public unsafe static uint3 operator ~(uint3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_OnesComplement_Public_Static_uint3_uint3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002124 RID: 8484 RVA: 0x000AD618 File Offset: 0x000AB818
		[CallerCount(0)]
		public unsafe static uint3 operator &(uint3 lhs, uint3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint3_uint3_uint3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002125 RID: 8485 RVA: 0x000AD664 File Offset: 0x000AB864
		[CallerCount(0)]
		public unsafe static uint3 operator &(uint3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint3_uint3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002126 RID: 8486 RVA: 0x000AD6B0 File Offset: 0x000AB8B0
		[CallerCount(0)]
		public unsafe static uint3 operator &(uint lhs, uint3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint3_UInt32_uint3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002127 RID: 8487 RVA: 0x000AD6FC File Offset: 0x000AB8FC
		[CallerCount(0)]
		public unsafe static uint3 operator |(uint3 lhs, uint3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint3_uint3_uint3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002128 RID: 8488 RVA: 0x000AD748 File Offset: 0x000AB948
		[CallerCount(0)]
		public unsafe static uint3 operator |(uint3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint3_uint3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002129 RID: 8489 RVA: 0x000AD794 File Offset: 0x000AB994
		[CallerCount(0)]
		public unsafe static uint3 operator |(uint lhs, uint3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint3_UInt32_uint3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600212A RID: 8490 RVA: 0x000AD7E0 File Offset: 0x000AB9E0
		[CallerCount(0)]
		public unsafe static uint3 operator ^(uint3 lhs, uint3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint3_uint3_uint3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600212B RID: 8491 RVA: 0x000AD82C File Offset: 0x000ABA2C
		[CallerCount(0)]
		public unsafe static uint3 operator ^(uint3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint3_uint3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600212C RID: 8492 RVA: 0x000AD878 File Offset: 0x000ABA78
		[CallerCount(0)]
		public unsafe static uint3 operator ^(uint lhs, uint3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint3_UInt32_uint3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x0600212D RID: 8493 RVA: 0x000AD8C4 File Offset: 0x000ABAC4
		public unsafe uint4 xxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_xxxx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x0600212E RID: 8494 RVA: 0x000AD8F4 File Offset: 0x000ABAF4
		public unsafe uint4 xxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_xxxy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x0600212F RID: 8495 RVA: 0x000AD924 File Offset: 0x000ABB24
		public unsafe uint4 xxxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_xxxz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x06002130 RID: 8496 RVA: 0x000AD954 File Offset: 0x000ABB54
		public unsafe uint4 xxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_xxyx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x06002131 RID: 8497 RVA: 0x000AD984 File Offset: 0x000ABB84
		public unsafe uint4 xxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_xxyy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x06002132 RID: 8498 RVA: 0x000AD9B4 File Offset: 0x000ABBB4
		public unsafe uint4 xxyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_xxyz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x06002133 RID: 8499 RVA: 0x000AD9E4 File Offset: 0x000ABBE4
		public unsafe uint4 xxzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_xxzx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x06002134 RID: 8500 RVA: 0x000ADA14 File Offset: 0x000ABC14
		public unsafe uint4 xxzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_xxzy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x06002135 RID: 8501 RVA: 0x000ADA44 File Offset: 0x000ABC44
		public unsafe uint4 xxzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_xxzz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x06002136 RID: 8502 RVA: 0x000ADA74 File Offset: 0x000ABC74
		public unsafe uint4 xyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_xyxx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x06002137 RID: 8503 RVA: 0x000ADAA4 File Offset: 0x000ABCA4
		public unsafe uint4 xyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_xyxy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x06002138 RID: 8504 RVA: 0x000ADAD4 File Offset: 0x000ABCD4
		public unsafe uint4 xyxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_xyxz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06002139 RID: 8505 RVA: 0x000ADB04 File Offset: 0x000ABD04
		public unsafe uint4 xyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_xyyx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x0600213A RID: 8506 RVA: 0x000ADB34 File Offset: 0x000ABD34
		public unsafe uint4 xyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_xyyy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x0600213B RID: 8507 RVA: 0x000ADB64 File Offset: 0x000ABD64
		public unsafe uint4 xyyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_xyyz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x0600213C RID: 8508 RVA: 0x000ADB94 File Offset: 0x000ABD94
		public unsafe uint4 xyzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_xyzx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x0600213D RID: 8509 RVA: 0x000ADBC4 File Offset: 0x000ABDC4
		public unsafe uint4 xyzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_xyzy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x0600213E RID: 8510 RVA: 0x000ADBF4 File Offset: 0x000ABDF4
		public unsafe uint4 xyzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_xyzz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x0600213F RID: 8511 RVA: 0x000ADC24 File Offset: 0x000ABE24
		public unsafe uint4 xzxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_xzxx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x06002140 RID: 8512 RVA: 0x000ADC54 File Offset: 0x000ABE54
		public unsafe uint4 xzxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_xzxy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x06002141 RID: 8513 RVA: 0x000ADC84 File Offset: 0x000ABE84
		public unsafe uint4 xzxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_xzxz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x06002142 RID: 8514 RVA: 0x000ADCB4 File Offset: 0x000ABEB4
		public unsafe uint4 xzyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_xzyx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x06002143 RID: 8515 RVA: 0x000ADCE4 File Offset: 0x000ABEE4
		public unsafe uint4 xzyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_xzyy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x06002144 RID: 8516 RVA: 0x000ADD14 File Offset: 0x000ABF14
		public unsafe uint4 xzyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_xzyz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x06002145 RID: 8517 RVA: 0x000ADD44 File Offset: 0x000ABF44
		public unsafe uint4 xzzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_xzzx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x06002146 RID: 8518 RVA: 0x000ADD74 File Offset: 0x000ABF74
		public unsafe uint4 xzzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_xzzy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x06002147 RID: 8519 RVA: 0x000ADDA4 File Offset: 0x000ABFA4
		public unsafe uint4 xzzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_xzzz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x06002148 RID: 8520 RVA: 0x000ADDD4 File Offset: 0x000ABFD4
		public unsafe uint4 yxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_yxxx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06002149 RID: 8521 RVA: 0x000ADE04 File Offset: 0x000AC004
		public unsafe uint4 yxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_yxxy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x0600214A RID: 8522 RVA: 0x000ADE34 File Offset: 0x000AC034
		public unsafe uint4 yxxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_yxxz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x0600214B RID: 8523 RVA: 0x000ADE64 File Offset: 0x000AC064
		public unsafe uint4 yxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_yxyx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x0600214C RID: 8524 RVA: 0x000ADE94 File Offset: 0x000AC094
		public unsafe uint4 yxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_yxyy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x0600214D RID: 8525 RVA: 0x000ADEC4 File Offset: 0x000AC0C4
		public unsafe uint4 yxyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_yxyz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x0600214E RID: 8526 RVA: 0x000ADEF4 File Offset: 0x000AC0F4
		public unsafe uint4 yxzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_yxzx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x0600214F RID: 8527 RVA: 0x000ADF24 File Offset: 0x000AC124
		public unsafe uint4 yxzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_yxzy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x06002150 RID: 8528 RVA: 0x000ADF54 File Offset: 0x000AC154
		public unsafe uint4 yxzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_yxzz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x06002151 RID: 8529 RVA: 0x000ADF84 File Offset: 0x000AC184
		public unsafe uint4 yyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_yyxx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x06002152 RID: 8530 RVA: 0x000ADFB4 File Offset: 0x000AC1B4
		public unsafe uint4 yyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_yyxy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x06002153 RID: 8531 RVA: 0x000ADFE4 File Offset: 0x000AC1E4
		public unsafe uint4 yyxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_yyxz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x06002154 RID: 8532 RVA: 0x000AE014 File Offset: 0x000AC214
		public unsafe uint4 yyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_yyyx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x06002155 RID: 8533 RVA: 0x000AE044 File Offset: 0x000AC244
		public unsafe uint4 yyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_yyyy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x06002156 RID: 8534 RVA: 0x000AE074 File Offset: 0x000AC274
		public unsafe uint4 yyyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_yyyz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x06002157 RID: 8535 RVA: 0x000AE0A4 File Offset: 0x000AC2A4
		public unsafe uint4 yyzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_yyzx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x06002158 RID: 8536 RVA: 0x000AE0D4 File Offset: 0x000AC2D4
		public unsafe uint4 yyzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_yyzy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x06002159 RID: 8537 RVA: 0x000AE104 File Offset: 0x000AC304
		public unsafe uint4 yyzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_yyzz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x0600215A RID: 8538 RVA: 0x000AE134 File Offset: 0x000AC334
		public unsafe uint4 yzxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_yzxx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x0600215B RID: 8539 RVA: 0x000AE164 File Offset: 0x000AC364
		public unsafe uint4 yzxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_yzxy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x0600215C RID: 8540 RVA: 0x000AE194 File Offset: 0x000AC394
		public unsafe uint4 yzxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_yzxz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x0600215D RID: 8541 RVA: 0x000AE1C4 File Offset: 0x000AC3C4
		public unsafe uint4 yzyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_yzyx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x0600215E RID: 8542 RVA: 0x000AE1F4 File Offset: 0x000AC3F4
		public unsafe uint4 yzyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_yzyy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x0600215F RID: 8543 RVA: 0x000AE224 File Offset: 0x000AC424
		public unsafe uint4 yzyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_yzyz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x06002160 RID: 8544 RVA: 0x000AE254 File Offset: 0x000AC454
		public unsafe uint4 yzzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_yzzx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x06002161 RID: 8545 RVA: 0x000AE284 File Offset: 0x000AC484
		public unsafe uint4 yzzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_yzzy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x06002162 RID: 8546 RVA: 0x000AE2B4 File Offset: 0x000AC4B4
		public unsafe uint4 yzzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_yzzz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x06002163 RID: 8547 RVA: 0x000AE2E4 File Offset: 0x000AC4E4
		public unsafe uint4 zxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_zxxx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x06002164 RID: 8548 RVA: 0x000AE314 File Offset: 0x000AC514
		public unsafe uint4 zxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_zxxy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x06002165 RID: 8549 RVA: 0x000AE344 File Offset: 0x000AC544
		public unsafe uint4 zxxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_zxxz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x06002166 RID: 8550 RVA: 0x000AE374 File Offset: 0x000AC574
		public unsafe uint4 zxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_zxyx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x06002167 RID: 8551 RVA: 0x000AE3A4 File Offset: 0x000AC5A4
		public unsafe uint4 zxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_zxyy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x06002168 RID: 8552 RVA: 0x000AE3D4 File Offset: 0x000AC5D4
		public unsafe uint4 zxyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_zxyz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x06002169 RID: 8553 RVA: 0x000AE404 File Offset: 0x000AC604
		public unsafe uint4 zxzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_zxzx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x0600216A RID: 8554 RVA: 0x000AE434 File Offset: 0x000AC634
		public unsafe uint4 zxzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_zxzy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x0600216B RID: 8555 RVA: 0x000AE464 File Offset: 0x000AC664
		public unsafe uint4 zxzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_zxzz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x0600216C RID: 8556 RVA: 0x000AE494 File Offset: 0x000AC694
		public unsafe uint4 zyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_zyxx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x0600216D RID: 8557 RVA: 0x000AE4C4 File Offset: 0x000AC6C4
		public unsafe uint4 zyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_zyxy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x0600216E RID: 8558 RVA: 0x000AE4F4 File Offset: 0x000AC6F4
		public unsafe uint4 zyxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_zyxz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x0600216F RID: 8559 RVA: 0x000AE524 File Offset: 0x000AC724
		public unsafe uint4 zyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_zyyx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x06002170 RID: 8560 RVA: 0x000AE554 File Offset: 0x000AC754
		public unsafe uint4 zyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_zyyy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x06002171 RID: 8561 RVA: 0x000AE584 File Offset: 0x000AC784
		public unsafe uint4 zyyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_zyyz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x06002172 RID: 8562 RVA: 0x000AE5B4 File Offset: 0x000AC7B4
		public unsafe uint4 zyzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_zyzx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x06002173 RID: 8563 RVA: 0x000AE5E4 File Offset: 0x000AC7E4
		public unsafe uint4 zyzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_zyzy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x06002174 RID: 8564 RVA: 0x000AE614 File Offset: 0x000AC814
		public unsafe uint4 zyzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_zyzz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x06002175 RID: 8565 RVA: 0x000AE644 File Offset: 0x000AC844
		public unsafe uint4 zzxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_zzxx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x06002176 RID: 8566 RVA: 0x000AE674 File Offset: 0x000AC874
		public unsafe uint4 zzxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_zzxy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x06002177 RID: 8567 RVA: 0x000AE6A4 File Offset: 0x000AC8A4
		public unsafe uint4 zzxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_zzxz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x06002178 RID: 8568 RVA: 0x000AE6D4 File Offset: 0x000AC8D4
		public unsafe uint4 zzyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_zzyx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x06002179 RID: 8569 RVA: 0x000AE704 File Offset: 0x000AC904
		public unsafe uint4 zzyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_zzyy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x0600217A RID: 8570 RVA: 0x000AE734 File Offset: 0x000AC934
		public unsafe uint4 zzyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_zzyz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x0600217B RID: 8571 RVA: 0x000AE764 File Offset: 0x000AC964
		public unsafe uint4 zzzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_zzzx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x0600217C RID: 8572 RVA: 0x000AE794 File Offset: 0x000AC994
		public unsafe uint4 zzzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_zzzy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x0600217D RID: 8573 RVA: 0x000AE7C4 File Offset: 0x000AC9C4
		public unsafe uint4 zzzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_zzzz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x0600217E RID: 8574 RVA: 0x000AE7F4 File Offset: 0x000AC9F4
		public unsafe uint3 xxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_xxx_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x0600217F RID: 8575 RVA: 0x000AE824 File Offset: 0x000ACA24
		public unsafe uint3 xxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_xxy_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x06002180 RID: 8576 RVA: 0x000AE854 File Offset: 0x000ACA54
		public unsafe uint3 xxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_xxz_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x06002181 RID: 8577 RVA: 0x000AE884 File Offset: 0x000ACA84
		public unsafe uint3 xyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_xyx_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x06002182 RID: 8578 RVA: 0x000AE8B4 File Offset: 0x000ACAB4
		public unsafe uint3 xyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_xyy_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x06002183 RID: 8579 RVA: 0x000AE8E4 File Offset: 0x000ACAE4
		// (set) Token: 0x06002184 RID: 8580 RVA: 0x000AE914 File Offset: 0x000ACB14
		public unsafe uint3 xyz
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 637161, RefRangeEnd = 637182, XrefRangeStart = 637161, XrefRangeEnd = 637182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_xyz_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_set_xyz_Public_set_Void_uint3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x06002185 RID: 8581 RVA: 0x000AE948 File Offset: 0x000ACB48
		public unsafe uint3 xzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_xzx_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06002186 RID: 8582 RVA: 0x000AE978 File Offset: 0x000ACB78
		// (set) Token: 0x06002187 RID: 8583 RVA: 0x000AE9A8 File Offset: 0x000ACBA8
		public unsafe uint3 xzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_xzy_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_set_xzy_Public_set_Void_uint3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x06002188 RID: 8584 RVA: 0x000AE9DC File Offset: 0x000ACBDC
		public unsafe uint3 xzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_xzz_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x06002189 RID: 8585 RVA: 0x000AEA0C File Offset: 0x000ACC0C
		public unsafe uint3 yxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_yxx_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x0600218A RID: 8586 RVA: 0x000AEA3C File Offset: 0x000ACC3C
		public unsafe uint3 yxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_yxy_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x0600218B RID: 8587 RVA: 0x000AEA6C File Offset: 0x000ACC6C
		// (set) Token: 0x0600218C RID: 8588 RVA: 0x000AEA9C File Offset: 0x000ACC9C
		public unsafe uint3 yxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_yxz_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_set_yxz_Public_set_Void_uint3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x0600218D RID: 8589 RVA: 0x000AEAD0 File Offset: 0x000ACCD0
		public unsafe uint3 yyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_yyx_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x0600218E RID: 8590 RVA: 0x000AEB00 File Offset: 0x000ACD00
		public unsafe uint3 yyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_yyy_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x0600218F RID: 8591 RVA: 0x000AEB30 File Offset: 0x000ACD30
		public unsafe uint3 yyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_yyz_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x06002190 RID: 8592 RVA: 0x000AEB60 File Offset: 0x000ACD60
		// (set) Token: 0x06002191 RID: 8593 RVA: 0x000AEB90 File Offset: 0x000ACD90
		public unsafe uint3 yzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_yzx_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_set_yzx_Public_set_Void_uint3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x06002192 RID: 8594 RVA: 0x000AEBC4 File Offset: 0x000ACDC4
		public unsafe uint3 yzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_yzy_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x06002193 RID: 8595 RVA: 0x000AEBF4 File Offset: 0x000ACDF4
		public unsafe uint3 yzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_yzz_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x06002194 RID: 8596 RVA: 0x000AEC24 File Offset: 0x000ACE24
		public unsafe uint3 zxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_zxx_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x06002195 RID: 8597 RVA: 0x000AEC54 File Offset: 0x000ACE54
		// (set) Token: 0x06002196 RID: 8598 RVA: 0x000AEC84 File Offset: 0x000ACE84
		public unsafe uint3 zxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_zxy_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_set_zxy_Public_set_Void_uint3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x06002197 RID: 8599 RVA: 0x000AECB8 File Offset: 0x000ACEB8
		public unsafe uint3 zxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_zxz_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x06002198 RID: 8600 RVA: 0x000AECE8 File Offset: 0x000ACEE8
		// (set) Token: 0x06002199 RID: 8601 RVA: 0x000AED18 File Offset: 0x000ACF18
		public unsafe uint3 zyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_zyx_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_set_zyx_Public_set_Void_uint3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x0600219A RID: 8602 RVA: 0x000AED4C File Offset: 0x000ACF4C
		public unsafe uint3 zyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_zyy_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x0600219B RID: 8603 RVA: 0x000AED7C File Offset: 0x000ACF7C
		public unsafe uint3 zyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_zyz_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x0600219C RID: 8604 RVA: 0x000AEDAC File Offset: 0x000ACFAC
		public unsafe uint3 zzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_zzx_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x0600219D RID: 8605 RVA: 0x000AEDDC File Offset: 0x000ACFDC
		public unsafe uint3 zzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_zzy_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x0600219E RID: 8606 RVA: 0x000AEE0C File Offset: 0x000AD00C
		public unsafe uint3 zzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_zzz_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x0600219F RID: 8607 RVA: 0x000AEE3C File Offset: 0x000AD03C
		public unsafe uint2 xx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_xx_Public_get_uint2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x060021A0 RID: 8608 RVA: 0x000AEE6C File Offset: 0x000AD06C
		// (set) Token: 0x060021A1 RID: 8609 RVA: 0x000AEE9C File Offset: 0x000AD09C
		public unsafe uint2 xy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_xy_Public_get_uint2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_set_xy_Public_set_Void_uint2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x060021A2 RID: 8610 RVA: 0x000AEED0 File Offset: 0x000AD0D0
		// (set) Token: 0x060021A3 RID: 8611 RVA: 0x000AEF00 File Offset: 0x000AD100
		public unsafe uint2 xz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_xz_Public_get_uint2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_set_xz_Public_set_Void_uint2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x060021A4 RID: 8612 RVA: 0x000AEF34 File Offset: 0x000AD134
		// (set) Token: 0x060021A5 RID: 8613 RVA: 0x000AEF64 File Offset: 0x000AD164
		public unsafe uint2 yx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_yx_Public_get_uint2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_set_yx_Public_set_Void_uint2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x060021A6 RID: 8614 RVA: 0x000AEF98 File Offset: 0x000AD198
		public unsafe uint2 yy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_yy_Public_get_uint2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x060021A7 RID: 8615 RVA: 0x000AEFC8 File Offset: 0x000AD1C8
		// (set) Token: 0x060021A8 RID: 8616 RVA: 0x000AEFF8 File Offset: 0x000AD1F8
		public unsafe uint2 yz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_yz_Public_get_uint2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_set_yz_Public_set_Void_uint2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x060021A9 RID: 8617 RVA: 0x000AF02C File Offset: 0x000AD22C
		// (set) Token: 0x060021AA RID: 8618 RVA: 0x000AF05C File Offset: 0x000AD25C
		public unsafe uint2 zx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_zx_Public_get_uint2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_set_zx_Public_set_Void_uint2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x060021AB RID: 8619 RVA: 0x000AF090 File Offset: 0x000AD290
		// (set) Token: 0x060021AC RID: 8620 RVA: 0x000AF0C0 File Offset: 0x000AD2C0
		public unsafe uint2 zy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_zy_Public_get_uint2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_set_zy_Public_set_Void_uint2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x060021AD RID: 8621 RVA: 0x000AF0F4 File Offset: 0x000AD2F4
		public unsafe uint2 zz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_zz_Public_get_uint2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A81 RID: 2689
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_get_Item_Public_get_UInt32_Int32_0, ref this, (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021B0 RID: 8624 RVA: 0x000AF1A4 File Offset: 0x000AD3A4
		[CallerCount(0)]
		public unsafe bool Equals(uint3 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021B1 RID: 8625 RVA: 0x000AF1E4 File Offset: 0x000AD3E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641758, XrefRangeEnd = 641761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021B2 RID: 8626 RVA: 0x000AF228 File Offset: 0x000AD428
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021B3 RID: 8627 RVA: 0x000AF258 File Offset: 0x000AD458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641761, XrefRangeEnd = 641771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060021B4 RID: 8628 RVA: 0x000AF284 File Offset: 0x000AD484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641771, XrefRangeEnd = 641777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060021B5 RID: 8629 RVA: 0x0000299B File Offset: 0x00000B9B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<uint3>.NativeClassPtr, ref this));
		}

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x060021B6 RID: 8630 RVA: 0x000AF2D4 File Offset: 0x000AD4D4
		// (set) Token: 0x060021B7 RID: 8631 RVA: 0x000029AD File Offset: 0x00000BAD
		public unsafe static uint3 zero
		{
			get
			{
				uint3 @uint;
				IL2CPP.il2cpp_field_static_get_value(uint3.NativeFieldInfoPtr_zero, (void*)(&@uint));
				return @uint;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(uint3.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x04002167 RID: 8551
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x04002168 RID: 8552
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04002169 RID: 8553
		private static readonly IntPtr NativeFieldInfoPtr_z;

		// Token: 0x0400216A RID: 8554
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x0400216B RID: 8555
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_0;

		// Token: 0x0400216C RID: 8556
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_uint2_0;

		// Token: 0x0400216D RID: 8557
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint2_UInt32_0;

		// Token: 0x0400216E RID: 8558
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint3_0;

		// Token: 0x0400216F RID: 8559
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04002170 RID: 8560
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04002171 RID: 8561
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool3_0;

		// Token: 0x04002172 RID: 8562
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04002173 RID: 8563
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int3_0;

		// Token: 0x04002174 RID: 8564
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x04002175 RID: 8565
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float3_0;

		// Token: 0x04002176 RID: 8566
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x04002177 RID: 8567
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double3_0;

		// Token: 0x04002178 RID: 8568
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_uint3_UInt32_0;

		// Token: 0x04002179 RID: 8569
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint3_Boolean_0;

		// Token: 0x0400217A RID: 8570
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint3_bool3_0;

		// Token: 0x0400217B RID: 8571
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint3_Int32_0;

		// Token: 0x0400217C RID: 8572
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint3_int3_0;

		// Token: 0x0400217D RID: 8573
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint3_Single_0;

		// Token: 0x0400217E RID: 8574
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint3_float3_0;

		// Token: 0x0400217F RID: 8575
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint3_Double_0;

		// Token: 0x04002180 RID: 8576
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint3_double3_0;

		// Token: 0x04002181 RID: 8577
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_uint3_uint3_uint3_0;

		// Token: 0x04002182 RID: 8578
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_uint3_uint3_UInt32_0;

		// Token: 0x04002183 RID: 8579
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_uint3_UInt32_uint3_0;

		// Token: 0x04002184 RID: 8580
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_uint3_uint3_uint3_0;

		// Token: 0x04002185 RID: 8581
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_uint3_uint3_UInt32_0;

		// Token: 0x04002186 RID: 8582
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_uint3_UInt32_uint3_0;

		// Token: 0x04002187 RID: 8583
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_uint3_uint3_uint3_0;

		// Token: 0x04002188 RID: 8584
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_uint3_uint3_UInt32_0;

		// Token: 0x04002189 RID: 8585
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_uint3_UInt32_uint3_0;

		// Token: 0x0400218A RID: 8586
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_uint3_uint3_uint3_0;

		// Token: 0x0400218B RID: 8587
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_uint3_uint3_UInt32_0;

		// Token: 0x0400218C RID: 8588
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_uint3_UInt32_uint3_0;

		// Token: 0x0400218D RID: 8589
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_uint3_uint3_uint3_0;

		// Token: 0x0400218E RID: 8590
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_uint3_uint3_UInt32_0;

		// Token: 0x0400218F RID: 8591
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_uint3_UInt32_uint3_0;

		// Token: 0x04002190 RID: 8592
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_uint3_uint3_0;

		// Token: 0x04002191 RID: 8593
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_uint3_uint3_0;

		// Token: 0x04002192 RID: 8594
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool3_uint3_uint3_0;

		// Token: 0x04002193 RID: 8595
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool3_uint3_UInt32_0;

		// Token: 0x04002194 RID: 8596
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool3_UInt32_uint3_0;

		// Token: 0x04002195 RID: 8597
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3_uint3_uint3_0;

		// Token: 0x04002196 RID: 8598
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3_uint3_UInt32_0;

		// Token: 0x04002197 RID: 8599
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3_UInt32_uint3_0;

		// Token: 0x04002198 RID: 8600
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3_uint3_uint3_0;

		// Token: 0x04002199 RID: 8601
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3_uint3_UInt32_0;

		// Token: 0x0400219A RID: 8602
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3_UInt32_uint3_0;

		// Token: 0x0400219B RID: 8603
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3_uint3_uint3_0;

		// Token: 0x0400219C RID: 8604
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3_uint3_UInt32_0;

		// Token: 0x0400219D RID: 8605
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3_UInt32_uint3_0;

		// Token: 0x0400219E RID: 8606
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_uint3_uint3_0;

		// Token: 0x0400219F RID: 8607
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryPlus_Public_Static_uint3_uint3_0;

		// Token: 0x040021A0 RID: 8608
		private static readonly IntPtr NativeMethodInfoPtr_op_LeftShift_Public_Static_uint3_uint3_Int32_0;

		// Token: 0x040021A1 RID: 8609
		private static readonly IntPtr NativeMethodInfoPtr_op_RightShift_Public_Static_uint3_uint3_Int32_0;

		// Token: 0x040021A2 RID: 8610
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3_uint3_uint3_0;

		// Token: 0x040021A3 RID: 8611
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3_uint3_UInt32_0;

		// Token: 0x040021A4 RID: 8612
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3_UInt32_uint3_0;

		// Token: 0x040021A5 RID: 8613
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_uint3_uint3_0;

		// Token: 0x040021A6 RID: 8614
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_uint3_UInt32_0;

		// Token: 0x040021A7 RID: 8615
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_UInt32_uint3_0;

		// Token: 0x040021A8 RID: 8616
		private static readonly IntPtr NativeMethodInfoPtr_op_OnesComplement_Public_Static_uint3_uint3_0;

		// Token: 0x040021A9 RID: 8617
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint3_uint3_uint3_0;

		// Token: 0x040021AA RID: 8618
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint3_uint3_UInt32_0;

		// Token: 0x040021AB RID: 8619
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint3_UInt32_uint3_0;

		// Token: 0x040021AC RID: 8620
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint3_uint3_uint3_0;

		// Token: 0x040021AD RID: 8621
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint3_uint3_UInt32_0;

		// Token: 0x040021AE RID: 8622
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint3_UInt32_uint3_0;

		// Token: 0x040021AF RID: 8623
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint3_uint3_uint3_0;

		// Token: 0x040021B0 RID: 8624
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint3_uint3_UInt32_0;

		// Token: 0x040021B1 RID: 8625
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint3_UInt32_uint3_0;

		// Token: 0x040021B2 RID: 8626
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxx_Public_get_uint4_0;

		// Token: 0x040021B3 RID: 8627
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxy_Public_get_uint4_0;

		// Token: 0x040021B4 RID: 8628
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxz_Public_get_uint4_0;

		// Token: 0x040021B5 RID: 8629
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyx_Public_get_uint4_0;

		// Token: 0x040021B6 RID: 8630
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyy_Public_get_uint4_0;

		// Token: 0x040021B7 RID: 8631
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyz_Public_get_uint4_0;

		// Token: 0x040021B8 RID: 8632
		private static readonly IntPtr NativeMethodInfoPtr_get_xxzx_Public_get_uint4_0;

		// Token: 0x040021B9 RID: 8633
		private static readonly IntPtr NativeMethodInfoPtr_get_xxzy_Public_get_uint4_0;

		// Token: 0x040021BA RID: 8634
		private static readonly IntPtr NativeMethodInfoPtr_get_xxzz_Public_get_uint4_0;

		// Token: 0x040021BB RID: 8635
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxx_Public_get_uint4_0;

		// Token: 0x040021BC RID: 8636
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxy_Public_get_uint4_0;

		// Token: 0x040021BD RID: 8637
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxz_Public_get_uint4_0;

		// Token: 0x040021BE RID: 8638
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyx_Public_get_uint4_0;

		// Token: 0x040021BF RID: 8639
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyy_Public_get_uint4_0;

		// Token: 0x040021C0 RID: 8640
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyz_Public_get_uint4_0;

		// Token: 0x040021C1 RID: 8641
		private static readonly IntPtr NativeMethodInfoPtr_get_xyzx_Public_get_uint4_0;

		// Token: 0x040021C2 RID: 8642
		private static readonly IntPtr NativeMethodInfoPtr_get_xyzy_Public_get_uint4_0;

		// Token: 0x040021C3 RID: 8643
		private static readonly IntPtr NativeMethodInfoPtr_get_xyzz_Public_get_uint4_0;

		// Token: 0x040021C4 RID: 8644
		private static readonly IntPtr NativeMethodInfoPtr_get_xzxx_Public_get_uint4_0;

		// Token: 0x040021C5 RID: 8645
		private static readonly IntPtr NativeMethodInfoPtr_get_xzxy_Public_get_uint4_0;

		// Token: 0x040021C6 RID: 8646
		private static readonly IntPtr NativeMethodInfoPtr_get_xzxz_Public_get_uint4_0;

		// Token: 0x040021C7 RID: 8647
		private static readonly IntPtr NativeMethodInfoPtr_get_xzyx_Public_get_uint4_0;

		// Token: 0x040021C8 RID: 8648
		private static readonly IntPtr NativeMethodInfoPtr_get_xzyy_Public_get_uint4_0;

		// Token: 0x040021C9 RID: 8649
		private static readonly IntPtr NativeMethodInfoPtr_get_xzyz_Public_get_uint4_0;

		// Token: 0x040021CA RID: 8650
		private static readonly IntPtr NativeMethodInfoPtr_get_xzzx_Public_get_uint4_0;

		// Token: 0x040021CB RID: 8651
		private static readonly IntPtr NativeMethodInfoPtr_get_xzzy_Public_get_uint4_0;

		// Token: 0x040021CC RID: 8652
		private static readonly IntPtr NativeMethodInfoPtr_get_xzzz_Public_get_uint4_0;

		// Token: 0x040021CD RID: 8653
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxx_Public_get_uint4_0;

		// Token: 0x040021CE RID: 8654
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxy_Public_get_uint4_0;

		// Token: 0x040021CF RID: 8655
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxz_Public_get_uint4_0;

		// Token: 0x040021D0 RID: 8656
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyx_Public_get_uint4_0;

		// Token: 0x040021D1 RID: 8657
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyy_Public_get_uint4_0;

		// Token: 0x040021D2 RID: 8658
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyz_Public_get_uint4_0;

		// Token: 0x040021D3 RID: 8659
		private static readonly IntPtr NativeMethodInfoPtr_get_yxzx_Public_get_uint4_0;

		// Token: 0x040021D4 RID: 8660
		private static readonly IntPtr NativeMethodInfoPtr_get_yxzy_Public_get_uint4_0;

		// Token: 0x040021D5 RID: 8661
		private static readonly IntPtr NativeMethodInfoPtr_get_yxzz_Public_get_uint4_0;

		// Token: 0x040021D6 RID: 8662
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxx_Public_get_uint4_0;

		// Token: 0x040021D7 RID: 8663
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxy_Public_get_uint4_0;

		// Token: 0x040021D8 RID: 8664
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxz_Public_get_uint4_0;

		// Token: 0x040021D9 RID: 8665
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyx_Public_get_uint4_0;

		// Token: 0x040021DA RID: 8666
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyy_Public_get_uint4_0;

		// Token: 0x040021DB RID: 8667
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyz_Public_get_uint4_0;

		// Token: 0x040021DC RID: 8668
		private static readonly IntPtr NativeMethodInfoPtr_get_yyzx_Public_get_uint4_0;

		// Token: 0x040021DD RID: 8669
		private static readonly IntPtr NativeMethodInfoPtr_get_yyzy_Public_get_uint4_0;

		// Token: 0x040021DE RID: 8670
		private static readonly IntPtr NativeMethodInfoPtr_get_yyzz_Public_get_uint4_0;

		// Token: 0x040021DF RID: 8671
		private static readonly IntPtr NativeMethodInfoPtr_get_yzxx_Public_get_uint4_0;

		// Token: 0x040021E0 RID: 8672
		private static readonly IntPtr NativeMethodInfoPtr_get_yzxy_Public_get_uint4_0;

		// Token: 0x040021E1 RID: 8673
		private static readonly IntPtr NativeMethodInfoPtr_get_yzxz_Public_get_uint4_0;

		// Token: 0x040021E2 RID: 8674
		private static readonly IntPtr NativeMethodInfoPtr_get_yzyx_Public_get_uint4_0;

		// Token: 0x040021E3 RID: 8675
		private static readonly IntPtr NativeMethodInfoPtr_get_yzyy_Public_get_uint4_0;

		// Token: 0x040021E4 RID: 8676
		private static readonly IntPtr NativeMethodInfoPtr_get_yzyz_Public_get_uint4_0;

		// Token: 0x040021E5 RID: 8677
		private static readonly IntPtr NativeMethodInfoPtr_get_yzzx_Public_get_uint4_0;

		// Token: 0x040021E6 RID: 8678
		private static readonly IntPtr NativeMethodInfoPtr_get_yzzy_Public_get_uint4_0;

		// Token: 0x040021E7 RID: 8679
		private static readonly IntPtr NativeMethodInfoPtr_get_yzzz_Public_get_uint4_0;

		// Token: 0x040021E8 RID: 8680
		private static readonly IntPtr NativeMethodInfoPtr_get_zxxx_Public_get_uint4_0;

		// Token: 0x040021E9 RID: 8681
		private static readonly IntPtr NativeMethodInfoPtr_get_zxxy_Public_get_uint4_0;

		// Token: 0x040021EA RID: 8682
		private static readonly IntPtr NativeMethodInfoPtr_get_zxxz_Public_get_uint4_0;

		// Token: 0x040021EB RID: 8683
		private static readonly IntPtr NativeMethodInfoPtr_get_zxyx_Public_get_uint4_0;

		// Token: 0x040021EC RID: 8684
		private static readonly IntPtr NativeMethodInfoPtr_get_zxyy_Public_get_uint4_0;

		// Token: 0x040021ED RID: 8685
		private static readonly IntPtr NativeMethodInfoPtr_get_zxyz_Public_get_uint4_0;

		// Token: 0x040021EE RID: 8686
		private static readonly IntPtr NativeMethodInfoPtr_get_zxzx_Public_get_uint4_0;

		// Token: 0x040021EF RID: 8687
		private static readonly IntPtr NativeMethodInfoPtr_get_zxzy_Public_get_uint4_0;

		// Token: 0x040021F0 RID: 8688
		private static readonly IntPtr NativeMethodInfoPtr_get_zxzz_Public_get_uint4_0;

		// Token: 0x040021F1 RID: 8689
		private static readonly IntPtr NativeMethodInfoPtr_get_zyxx_Public_get_uint4_0;

		// Token: 0x040021F2 RID: 8690
		private static readonly IntPtr NativeMethodInfoPtr_get_zyxy_Public_get_uint4_0;

		// Token: 0x040021F3 RID: 8691
		private static readonly IntPtr NativeMethodInfoPtr_get_zyxz_Public_get_uint4_0;

		// Token: 0x040021F4 RID: 8692
		private static readonly IntPtr NativeMethodInfoPtr_get_zyyx_Public_get_uint4_0;

		// Token: 0x040021F5 RID: 8693
		private static readonly IntPtr NativeMethodInfoPtr_get_zyyy_Public_get_uint4_0;

		// Token: 0x040021F6 RID: 8694
		private static readonly IntPtr NativeMethodInfoPtr_get_zyyz_Public_get_uint4_0;

		// Token: 0x040021F7 RID: 8695
		private static readonly IntPtr NativeMethodInfoPtr_get_zyzx_Public_get_uint4_0;

		// Token: 0x040021F8 RID: 8696
		private static readonly IntPtr NativeMethodInfoPtr_get_zyzy_Public_get_uint4_0;

		// Token: 0x040021F9 RID: 8697
		private static readonly IntPtr NativeMethodInfoPtr_get_zyzz_Public_get_uint4_0;

		// Token: 0x040021FA RID: 8698
		private static readonly IntPtr NativeMethodInfoPtr_get_zzxx_Public_get_uint4_0;

		// Token: 0x040021FB RID: 8699
		private static readonly IntPtr NativeMethodInfoPtr_get_zzxy_Public_get_uint4_0;

		// Token: 0x040021FC RID: 8700
		private static readonly IntPtr NativeMethodInfoPtr_get_zzxz_Public_get_uint4_0;

		// Token: 0x040021FD RID: 8701
		private static readonly IntPtr NativeMethodInfoPtr_get_zzyx_Public_get_uint4_0;

		// Token: 0x040021FE RID: 8702
		private static readonly IntPtr NativeMethodInfoPtr_get_zzyy_Public_get_uint4_0;

		// Token: 0x040021FF RID: 8703
		private static readonly IntPtr NativeMethodInfoPtr_get_zzyz_Public_get_uint4_0;

		// Token: 0x04002200 RID: 8704
		private static readonly IntPtr NativeMethodInfoPtr_get_zzzx_Public_get_uint4_0;

		// Token: 0x04002201 RID: 8705
		private static readonly IntPtr NativeMethodInfoPtr_get_zzzy_Public_get_uint4_0;

		// Token: 0x04002202 RID: 8706
		private static readonly IntPtr NativeMethodInfoPtr_get_zzzz_Public_get_uint4_0;

		// Token: 0x04002203 RID: 8707
		private static readonly IntPtr NativeMethodInfoPtr_get_xxx_Public_get_uint3_0;

		// Token: 0x04002204 RID: 8708
		private static readonly IntPtr NativeMethodInfoPtr_get_xxy_Public_get_uint3_0;

		// Token: 0x04002205 RID: 8709
		private static readonly IntPtr NativeMethodInfoPtr_get_xxz_Public_get_uint3_0;

		// Token: 0x04002206 RID: 8710
		private static readonly IntPtr NativeMethodInfoPtr_get_xyx_Public_get_uint3_0;

		// Token: 0x04002207 RID: 8711
		private static readonly IntPtr NativeMethodInfoPtr_get_xyy_Public_get_uint3_0;

		// Token: 0x04002208 RID: 8712
		private static readonly IntPtr NativeMethodInfoPtr_get_xyz_Public_get_uint3_0;

		// Token: 0x04002209 RID: 8713
		private static readonly IntPtr NativeMethodInfoPtr_set_xyz_Public_set_Void_uint3_0;

		// Token: 0x0400220A RID: 8714
		private static readonly IntPtr NativeMethodInfoPtr_get_xzx_Public_get_uint3_0;

		// Token: 0x0400220B RID: 8715
		private static readonly IntPtr NativeMethodInfoPtr_get_xzy_Public_get_uint3_0;

		// Token: 0x0400220C RID: 8716
		private static readonly IntPtr NativeMethodInfoPtr_set_xzy_Public_set_Void_uint3_0;

		// Token: 0x0400220D RID: 8717
		private static readonly IntPtr NativeMethodInfoPtr_get_xzz_Public_get_uint3_0;

		// Token: 0x0400220E RID: 8718
		private static readonly IntPtr NativeMethodInfoPtr_get_yxx_Public_get_uint3_0;

		// Token: 0x0400220F RID: 8719
		private static readonly IntPtr NativeMethodInfoPtr_get_yxy_Public_get_uint3_0;

		// Token: 0x04002210 RID: 8720
		private static readonly IntPtr NativeMethodInfoPtr_get_yxz_Public_get_uint3_0;

		// Token: 0x04002211 RID: 8721
		private static readonly IntPtr NativeMethodInfoPtr_set_yxz_Public_set_Void_uint3_0;

		// Token: 0x04002212 RID: 8722
		private static readonly IntPtr NativeMethodInfoPtr_get_yyx_Public_get_uint3_0;

		// Token: 0x04002213 RID: 8723
		private static readonly IntPtr NativeMethodInfoPtr_get_yyy_Public_get_uint3_0;

		// Token: 0x04002214 RID: 8724
		private static readonly IntPtr NativeMethodInfoPtr_get_yyz_Public_get_uint3_0;

		// Token: 0x04002215 RID: 8725
		private static readonly IntPtr NativeMethodInfoPtr_get_yzx_Public_get_uint3_0;

		// Token: 0x04002216 RID: 8726
		private static readonly IntPtr NativeMethodInfoPtr_set_yzx_Public_set_Void_uint3_0;

		// Token: 0x04002217 RID: 8727
		private static readonly IntPtr NativeMethodInfoPtr_get_yzy_Public_get_uint3_0;

		// Token: 0x04002218 RID: 8728
		private static readonly IntPtr NativeMethodInfoPtr_get_yzz_Public_get_uint3_0;

		// Token: 0x04002219 RID: 8729
		private static readonly IntPtr NativeMethodInfoPtr_get_zxx_Public_get_uint3_0;

		// Token: 0x0400221A RID: 8730
		private static readonly IntPtr NativeMethodInfoPtr_get_zxy_Public_get_uint3_0;

		// Token: 0x0400221B RID: 8731
		private static readonly IntPtr NativeMethodInfoPtr_set_zxy_Public_set_Void_uint3_0;

		// Token: 0x0400221C RID: 8732
		private static readonly IntPtr NativeMethodInfoPtr_get_zxz_Public_get_uint3_0;

		// Token: 0x0400221D RID: 8733
		private static readonly IntPtr NativeMethodInfoPtr_get_zyx_Public_get_uint3_0;

		// Token: 0x0400221E RID: 8734
		private static readonly IntPtr NativeMethodInfoPtr_set_zyx_Public_set_Void_uint3_0;

		// Token: 0x0400221F RID: 8735
		private static readonly IntPtr NativeMethodInfoPtr_get_zyy_Public_get_uint3_0;

		// Token: 0x04002220 RID: 8736
		private static readonly IntPtr NativeMethodInfoPtr_get_zyz_Public_get_uint3_0;

		// Token: 0x04002221 RID: 8737
		private static readonly IntPtr NativeMethodInfoPtr_get_zzx_Public_get_uint3_0;

		// Token: 0x04002222 RID: 8738
		private static readonly IntPtr NativeMethodInfoPtr_get_zzy_Public_get_uint3_0;

		// Token: 0x04002223 RID: 8739
		private static readonly IntPtr NativeMethodInfoPtr_get_zzz_Public_get_uint3_0;

		// Token: 0x04002224 RID: 8740
		private static readonly IntPtr NativeMethodInfoPtr_get_xx_Public_get_uint2_0;

		// Token: 0x04002225 RID: 8741
		private static readonly IntPtr NativeMethodInfoPtr_get_xy_Public_get_uint2_0;

		// Token: 0x04002226 RID: 8742
		private static readonly IntPtr NativeMethodInfoPtr_set_xy_Public_set_Void_uint2_0;

		// Token: 0x04002227 RID: 8743
		private static readonly IntPtr NativeMethodInfoPtr_get_xz_Public_get_uint2_0;

		// Token: 0x04002228 RID: 8744
		private static readonly IntPtr NativeMethodInfoPtr_set_xz_Public_set_Void_uint2_0;

		// Token: 0x04002229 RID: 8745
		private static readonly IntPtr NativeMethodInfoPtr_get_yx_Public_get_uint2_0;

		// Token: 0x0400222A RID: 8746
		private static readonly IntPtr NativeMethodInfoPtr_set_yx_Public_set_Void_uint2_0;

		// Token: 0x0400222B RID: 8747
		private static readonly IntPtr NativeMethodInfoPtr_get_yy_Public_get_uint2_0;

		// Token: 0x0400222C RID: 8748
		private static readonly IntPtr NativeMethodInfoPtr_get_yz_Public_get_uint2_0;

		// Token: 0x0400222D RID: 8749
		private static readonly IntPtr NativeMethodInfoPtr_set_yz_Public_set_Void_uint2_0;

		// Token: 0x0400222E RID: 8750
		private static readonly IntPtr NativeMethodInfoPtr_get_zx_Public_get_uint2_0;

		// Token: 0x0400222F RID: 8751
		private static readonly IntPtr NativeMethodInfoPtr_set_zx_Public_set_Void_uint2_0;

		// Token: 0x04002230 RID: 8752
		private static readonly IntPtr NativeMethodInfoPtr_get_zy_Public_get_uint2_0;

		// Token: 0x04002231 RID: 8753
		private static readonly IntPtr NativeMethodInfoPtr_set_zy_Public_set_Void_uint2_0;

		// Token: 0x04002232 RID: 8754
		private static readonly IntPtr NativeMethodInfoPtr_get_zz_Public_get_uint2_0;

		// Token: 0x04002233 RID: 8755
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_UInt32_Int32_0;

		// Token: 0x04002234 RID: 8756
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_UInt32_0;

		// Token: 0x04002235 RID: 8757
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_uint3_0;

		// Token: 0x04002236 RID: 8758
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002237 RID: 8759
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002238 RID: 8760
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002239 RID: 8761
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x0400223A RID: 8762
		[FieldOffset(0)]
		public uint x;

		// Token: 0x0400223B RID: 8763
		[FieldOffset(4)]
		public uint y;

		// Token: 0x0400223C RID: 8764
		[FieldOffset(8)]
		public uint z;

		// Token: 0x02000064 RID: 100
		public sealed class DebuggerProxy : Object
		{
			// Token: 0x06002647 RID: 9799 RVA: 0x000C40E0 File Offset: 0x000C22E0
			// Note: this type is marked as 'beforefieldinit'.
			static DebuggerProxy()
			{
				Il2CppClassPointerStore<uint3.DebuggerProxy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<uint3>.NativeClassPtr, "DebuggerProxy");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<uint3.DebuggerProxy>.NativeClassPtr);
				uint3.DebuggerProxy.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint3.DebuggerProxy>.NativeClassPtr, "x");
				uint3.DebuggerProxy.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint3.DebuggerProxy>.NativeClassPtr, "y");
				uint3.DebuggerProxy.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint3.DebuggerProxy>.NativeClassPtr, "z");
				uint3.DebuggerProxy.NativeMethodInfoPtr__ctor_Public_Void_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint3.DebuggerProxy>.NativeClassPtr, 100671667);
			}

			// Token: 0x06002648 RID: 9800 RVA: 0x000C415C File Offset: 0x000C235C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DebuggerProxy(uint3 v)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<uint3.DebuggerProxy>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint3.DebuggerProxy.NativeMethodInfoPtr__ctor_Public_Void_uint3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002649 RID: 9801 RVA: 0x0000315C File Offset: 0x0000135C
			public DebuggerProxy(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C20 RID: 3104
			// (get) Token: 0x0600264A RID: 9802 RVA: 0x000C41A4 File Offset: 0x000C23A4
			// (set) Token: 0x0600264B RID: 9803 RVA: 0x00003165 File Offset: 0x00001365
			public unsafe uint x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(uint3.DebuggerProxy.NativeFieldInfoPtr_x);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(uint3.DebuggerProxy.NativeFieldInfoPtr_x)) = value;
				}
			}

			// Token: 0x17000C21 RID: 3105
			// (get) Token: 0x0600264C RID: 9804 RVA: 0x000C41CC File Offset: 0x000C23CC
			// (set) Token: 0x0600264D RID: 9805 RVA: 0x00003180 File Offset: 0x00001380
			public unsafe uint y
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(uint3.DebuggerProxy.NativeFieldInfoPtr_y);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(uint3.DebuggerProxy.NativeFieldInfoPtr_y)) = value;
				}
			}

			// Token: 0x17000C22 RID: 3106
			// (get) Token: 0x0600264E RID: 9806 RVA: 0x000C41F4 File Offset: 0x000C23F4
			// (set) Token: 0x0600264F RID: 9807 RVA: 0x0000319B File Offset: 0x0000139B
			public unsafe uint z
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(uint3.DebuggerProxy.NativeFieldInfoPtr_z);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(uint3.DebuggerProxy.NativeFieldInfoPtr_z)) = value;
				}
			}

			// Token: 0x0400269B RID: 9883
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x0400269C RID: 9884
			private static readonly IntPtr NativeFieldInfoPtr_y;

			// Token: 0x0400269D RID: 9885
			private static readonly IntPtr NativeFieldInfoPtr_z;

			// Token: 0x0400269E RID: 9886
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint3_0;
		}
	}
}
