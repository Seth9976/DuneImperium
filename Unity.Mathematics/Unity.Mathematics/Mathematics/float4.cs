using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Unity.Mathematics
{
	// Token: 0x02000025 RID: 37
	[Serializable]
	[StructLayout(2)]
	public struct float4
	{
		// Token: 0x06001379 RID: 4985 RVA: 0x00069A84 File Offset: 0x00067C84
		// Note: this type is marked as 'beforefieldinit'.
		static float4()
		{
			Il2CppClassPointerStore<float4>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "float4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<float4>.NativeClassPtr);
			float4.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float4>.NativeClassPtr, "x");
			float4.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float4>.NativeClassPtr, "y");
			float4.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float4>.NativeClassPtr, "z");
			float4.NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float4>.NativeClassPtr, "w");
			float4.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float4>.NativeClassPtr, "zero");
			float4.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668130);
			float4.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668131);
			float4.NativeMethodInfoPtr__ctor_Public_Void_Single_float2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668132);
			float4.NativeMethodInfoPtr__ctor_Public_Void_Single_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668133);
			float4.NativeMethodInfoPtr__ctor_Public_Void_float2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668134);
			float4.NativeMethodInfoPtr__ctor_Public_Void_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668135);
			float4.NativeMethodInfoPtr__ctor_Public_Void_float3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668136);
			float4.NativeMethodInfoPtr__ctor_Public_Void_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668137);
			float4.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668138);
			float4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668139);
			float4.NativeMethodInfoPtr__ctor_Public_Void_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668140);
			float4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668141);
			float4.NativeMethodInfoPtr__ctor_Public_Void_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668142);
			float4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668143);
			float4.NativeMethodInfoPtr__ctor_Public_Void_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668144);
			float4.NativeMethodInfoPtr__ctor_Public_Void_half_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668145);
			float4.NativeMethodInfoPtr__ctor_Public_Void_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668146);
			float4.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668147);
			float4.NativeMethodInfoPtr__ctor_Public_Void_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668148);
			float4.NativeMethodInfoPtr_op_Implicit_Public_Static_float4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668149);
			float4.NativeMethodInfoPtr_op_Explicit_Public_Static_float4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668150);
			float4.NativeMethodInfoPtr_op_Explicit_Public_Static_float4_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668151);
			float4.NativeMethodInfoPtr_op_Implicit_Public_Static_float4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668152);
			float4.NativeMethodInfoPtr_op_Implicit_Public_Static_float4_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668153);
			float4.NativeMethodInfoPtr_op_Implicit_Public_Static_float4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668154);
			float4.NativeMethodInfoPtr_op_Implicit_Public_Static_float4_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668155);
			float4.NativeMethodInfoPtr_op_Implicit_Public_Static_float4_half_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668156);
			float4.NativeMethodInfoPtr_op_Implicit_Public_Static_float4_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668157);
			float4.NativeMethodInfoPtr_op_Explicit_Public_Static_float4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668158);
			float4.NativeMethodInfoPtr_op_Explicit_Public_Static_float4_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668159);
			float4.NativeMethodInfoPtr_op_Multiply_Public_Static_float4_float4_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668160);
			float4.NativeMethodInfoPtr_op_Multiply_Public_Static_float4_float4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668161);
			float4.NativeMethodInfoPtr_op_Multiply_Public_Static_float4_Single_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668162);
			float4.NativeMethodInfoPtr_op_Addition_Public_Static_float4_float4_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668163);
			float4.NativeMethodInfoPtr_op_Addition_Public_Static_float4_float4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668164);
			float4.NativeMethodInfoPtr_op_Addition_Public_Static_float4_Single_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668165);
			float4.NativeMethodInfoPtr_op_Subtraction_Public_Static_float4_float4_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668166);
			float4.NativeMethodInfoPtr_op_Subtraction_Public_Static_float4_float4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668167);
			float4.NativeMethodInfoPtr_op_Subtraction_Public_Static_float4_Single_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668168);
			float4.NativeMethodInfoPtr_op_Division_Public_Static_float4_float4_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668169);
			float4.NativeMethodInfoPtr_op_Division_Public_Static_float4_float4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668170);
			float4.NativeMethodInfoPtr_op_Division_Public_Static_float4_Single_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668171);
			float4.NativeMethodInfoPtr_op_Modulus_Public_Static_float4_float4_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668172);
			float4.NativeMethodInfoPtr_op_Modulus_Public_Static_float4_float4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668173);
			float4.NativeMethodInfoPtr_op_Modulus_Public_Static_float4_Single_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668174);
			float4.NativeMethodInfoPtr_op_Increment_Public_Static_float4_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668175);
			float4.NativeMethodInfoPtr_op_Decrement_Public_Static_float4_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668176);
			float4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4_float4_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668177);
			float4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4_float4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668178);
			float4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4_Single_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668179);
			float4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4_float4_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668180);
			float4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4_float4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668181);
			float4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4_Single_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668182);
			float4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4_float4_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668183);
			float4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4_float4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668184);
			float4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4_Single_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668185);
			float4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4_float4_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668186);
			float4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4_float4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668187);
			float4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4_Single_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668188);
			float4.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_float4_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668189);
			float4.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_float4_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668190);
			float4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4_float4_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668191);
			float4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4_float4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668192);
			float4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4_Single_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668193);
			float4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_float4_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668194);
			float4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_float4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668195);
			float4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_Single_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668196);
			float4.NativeMethodInfoPtr_get_xxxx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668197);
			float4.NativeMethodInfoPtr_get_xxxy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668198);
			float4.NativeMethodInfoPtr_get_xxxz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668199);
			float4.NativeMethodInfoPtr_get_xxxw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668200);
			float4.NativeMethodInfoPtr_get_xxyx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668201);
			float4.NativeMethodInfoPtr_get_xxyy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668202);
			float4.NativeMethodInfoPtr_get_xxyz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668203);
			float4.NativeMethodInfoPtr_get_xxyw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668204);
			float4.NativeMethodInfoPtr_get_xxzx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668205);
			float4.NativeMethodInfoPtr_get_xxzy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668206);
			float4.NativeMethodInfoPtr_get_xxzz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668207);
			float4.NativeMethodInfoPtr_get_xxzw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668208);
			float4.NativeMethodInfoPtr_get_xxwx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668209);
			float4.NativeMethodInfoPtr_get_xxwy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668210);
			float4.NativeMethodInfoPtr_get_xxwz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668211);
			float4.NativeMethodInfoPtr_get_xxww_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668212);
			float4.NativeMethodInfoPtr_get_xyxx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668213);
			float4.NativeMethodInfoPtr_get_xyxy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668214);
			float4.NativeMethodInfoPtr_get_xyxz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668215);
			float4.NativeMethodInfoPtr_get_xyxw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668216);
			float4.NativeMethodInfoPtr_get_xyyx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668217);
			float4.NativeMethodInfoPtr_get_xyyy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668218);
			float4.NativeMethodInfoPtr_get_xyyz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668219);
			float4.NativeMethodInfoPtr_get_xyyw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668220);
			float4.NativeMethodInfoPtr_get_xyzx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668221);
			float4.NativeMethodInfoPtr_get_xyzy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668222);
			float4.NativeMethodInfoPtr_get_xyzz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668223);
			float4.NativeMethodInfoPtr_get_xyzw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668224);
			float4.NativeMethodInfoPtr_set_xyzw_Public_set_Void_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668225);
			float4.NativeMethodInfoPtr_get_xywx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668226);
			float4.NativeMethodInfoPtr_get_xywy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668227);
			float4.NativeMethodInfoPtr_get_xywz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668228);
			float4.NativeMethodInfoPtr_set_xywz_Public_set_Void_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668229);
			float4.NativeMethodInfoPtr_get_xyww_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668230);
			float4.NativeMethodInfoPtr_get_xzxx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668231);
			float4.NativeMethodInfoPtr_get_xzxy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668232);
			float4.NativeMethodInfoPtr_get_xzxz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668233);
			float4.NativeMethodInfoPtr_get_xzxw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668234);
			float4.NativeMethodInfoPtr_get_xzyx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668235);
			float4.NativeMethodInfoPtr_get_xzyy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668236);
			float4.NativeMethodInfoPtr_get_xzyz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668237);
			float4.NativeMethodInfoPtr_get_xzyw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668238);
			float4.NativeMethodInfoPtr_set_xzyw_Public_set_Void_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668239);
			float4.NativeMethodInfoPtr_get_xzzx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668240);
			float4.NativeMethodInfoPtr_get_xzzy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668241);
			float4.NativeMethodInfoPtr_get_xzzz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668242);
			float4.NativeMethodInfoPtr_get_xzzw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668243);
			float4.NativeMethodInfoPtr_get_xzwx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668244);
			float4.NativeMethodInfoPtr_get_xzwy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668245);
			float4.NativeMethodInfoPtr_set_xzwy_Public_set_Void_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668246);
			float4.NativeMethodInfoPtr_get_xzwz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668247);
			float4.NativeMethodInfoPtr_get_xzww_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668248);
			float4.NativeMethodInfoPtr_get_xwxx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668249);
			float4.NativeMethodInfoPtr_get_xwxy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668250);
			float4.NativeMethodInfoPtr_get_xwxz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668251);
			float4.NativeMethodInfoPtr_get_xwxw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668252);
			float4.NativeMethodInfoPtr_get_xwyx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668253);
			float4.NativeMethodInfoPtr_get_xwyy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668254);
			float4.NativeMethodInfoPtr_get_xwyz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668255);
			float4.NativeMethodInfoPtr_set_xwyz_Public_set_Void_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668256);
			float4.NativeMethodInfoPtr_get_xwyw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668257);
			float4.NativeMethodInfoPtr_get_xwzx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668258);
			float4.NativeMethodInfoPtr_get_xwzy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668259);
			float4.NativeMethodInfoPtr_set_xwzy_Public_set_Void_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668260);
			float4.NativeMethodInfoPtr_get_xwzz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668261);
			float4.NativeMethodInfoPtr_get_xwzw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668262);
			float4.NativeMethodInfoPtr_get_xwwx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668263);
			float4.NativeMethodInfoPtr_get_xwwy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668264);
			float4.NativeMethodInfoPtr_get_xwwz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668265);
			float4.NativeMethodInfoPtr_get_xwww_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668266);
			float4.NativeMethodInfoPtr_get_yxxx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668267);
			float4.NativeMethodInfoPtr_get_yxxy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668268);
			float4.NativeMethodInfoPtr_get_yxxz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668269);
			float4.NativeMethodInfoPtr_get_yxxw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668270);
			float4.NativeMethodInfoPtr_get_yxyx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668271);
			float4.NativeMethodInfoPtr_get_yxyy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668272);
			float4.NativeMethodInfoPtr_get_yxyz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668273);
			float4.NativeMethodInfoPtr_get_yxyw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668274);
			float4.NativeMethodInfoPtr_get_yxzx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668275);
			float4.NativeMethodInfoPtr_get_yxzy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668276);
			float4.NativeMethodInfoPtr_get_yxzz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668277);
			float4.NativeMethodInfoPtr_get_yxzw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668278);
			float4.NativeMethodInfoPtr_set_yxzw_Public_set_Void_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668279);
			float4.NativeMethodInfoPtr_get_yxwx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668280);
			float4.NativeMethodInfoPtr_get_yxwy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668281);
			float4.NativeMethodInfoPtr_get_yxwz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668282);
			float4.NativeMethodInfoPtr_set_yxwz_Public_set_Void_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668283);
			float4.NativeMethodInfoPtr_get_yxww_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668284);
			float4.NativeMethodInfoPtr_get_yyxx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668285);
			float4.NativeMethodInfoPtr_get_yyxy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668286);
			float4.NativeMethodInfoPtr_get_yyxz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668287);
			float4.NativeMethodInfoPtr_get_yyxw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668288);
			float4.NativeMethodInfoPtr_get_yyyx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668289);
			float4.NativeMethodInfoPtr_get_yyyy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668290);
			float4.NativeMethodInfoPtr_get_yyyz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668291);
			float4.NativeMethodInfoPtr_get_yyyw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668292);
			float4.NativeMethodInfoPtr_get_yyzx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668293);
			float4.NativeMethodInfoPtr_get_yyzy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668294);
			float4.NativeMethodInfoPtr_get_yyzz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668295);
			float4.NativeMethodInfoPtr_get_yyzw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668296);
			float4.NativeMethodInfoPtr_get_yywx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668297);
			float4.NativeMethodInfoPtr_get_yywy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668298);
			float4.NativeMethodInfoPtr_get_yywz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668299);
			float4.NativeMethodInfoPtr_get_yyww_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668300);
			float4.NativeMethodInfoPtr_get_yzxx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668301);
			float4.NativeMethodInfoPtr_get_yzxy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668302);
			float4.NativeMethodInfoPtr_get_yzxz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668303);
			float4.NativeMethodInfoPtr_get_yzxw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668304);
			float4.NativeMethodInfoPtr_set_yzxw_Public_set_Void_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668305);
			float4.NativeMethodInfoPtr_get_yzyx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668306);
			float4.NativeMethodInfoPtr_get_yzyy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668307);
			float4.NativeMethodInfoPtr_get_yzyz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668308);
			float4.NativeMethodInfoPtr_get_yzyw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668309);
			float4.NativeMethodInfoPtr_get_yzzx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668310);
			float4.NativeMethodInfoPtr_get_yzzy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668311);
			float4.NativeMethodInfoPtr_get_yzzz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668312);
			float4.NativeMethodInfoPtr_get_yzzw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668313);
			float4.NativeMethodInfoPtr_get_yzwx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668314);
			float4.NativeMethodInfoPtr_set_yzwx_Public_set_Void_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668315);
			float4.NativeMethodInfoPtr_get_yzwy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668316);
			float4.NativeMethodInfoPtr_get_yzwz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668317);
			float4.NativeMethodInfoPtr_get_yzww_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668318);
			float4.NativeMethodInfoPtr_get_ywxx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668319);
			float4.NativeMethodInfoPtr_get_ywxy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668320);
			float4.NativeMethodInfoPtr_get_ywxz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668321);
			float4.NativeMethodInfoPtr_set_ywxz_Public_set_Void_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668322);
			float4.NativeMethodInfoPtr_get_ywxw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668323);
			float4.NativeMethodInfoPtr_get_ywyx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668324);
			float4.NativeMethodInfoPtr_get_ywyy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668325);
			float4.NativeMethodInfoPtr_get_ywyz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668326);
			float4.NativeMethodInfoPtr_get_ywyw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668327);
			float4.NativeMethodInfoPtr_get_ywzx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668328);
			float4.NativeMethodInfoPtr_set_ywzx_Public_set_Void_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668329);
			float4.NativeMethodInfoPtr_get_ywzy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668330);
			float4.NativeMethodInfoPtr_get_ywzz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668331);
			float4.NativeMethodInfoPtr_get_ywzw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668332);
			float4.NativeMethodInfoPtr_get_ywwx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668333);
			float4.NativeMethodInfoPtr_get_ywwy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668334);
			float4.NativeMethodInfoPtr_get_ywwz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668335);
			float4.NativeMethodInfoPtr_get_ywww_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668336);
			float4.NativeMethodInfoPtr_get_zxxx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668337);
			float4.NativeMethodInfoPtr_get_zxxy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668338);
			float4.NativeMethodInfoPtr_get_zxxz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668339);
			float4.NativeMethodInfoPtr_get_zxxw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668340);
			float4.NativeMethodInfoPtr_get_zxyx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668341);
			float4.NativeMethodInfoPtr_get_zxyy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668342);
			float4.NativeMethodInfoPtr_get_zxyz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668343);
			float4.NativeMethodInfoPtr_get_zxyw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668344);
			float4.NativeMethodInfoPtr_set_zxyw_Public_set_Void_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668345);
			float4.NativeMethodInfoPtr_get_zxzx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668346);
			float4.NativeMethodInfoPtr_get_zxzy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668347);
			float4.NativeMethodInfoPtr_get_zxzz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668348);
			float4.NativeMethodInfoPtr_get_zxzw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668349);
			float4.NativeMethodInfoPtr_get_zxwx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668350);
			float4.NativeMethodInfoPtr_get_zxwy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668351);
			float4.NativeMethodInfoPtr_set_zxwy_Public_set_Void_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668352);
			float4.NativeMethodInfoPtr_get_zxwz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668353);
			float4.NativeMethodInfoPtr_get_zxww_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668354);
			float4.NativeMethodInfoPtr_get_zyxx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668355);
			float4.NativeMethodInfoPtr_get_zyxy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668356);
			float4.NativeMethodInfoPtr_get_zyxz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668357);
			float4.NativeMethodInfoPtr_get_zyxw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668358);
			float4.NativeMethodInfoPtr_set_zyxw_Public_set_Void_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668359);
			float4.NativeMethodInfoPtr_get_zyyx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668360);
			float4.NativeMethodInfoPtr_get_zyyy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668361);
			float4.NativeMethodInfoPtr_get_zyyz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668362);
			float4.NativeMethodInfoPtr_get_zyyw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668363);
			float4.NativeMethodInfoPtr_get_zyzx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668364);
			float4.NativeMethodInfoPtr_get_zyzy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668365);
			float4.NativeMethodInfoPtr_get_zyzz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668366);
			float4.NativeMethodInfoPtr_get_zyzw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668367);
			float4.NativeMethodInfoPtr_get_zywx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668368);
			float4.NativeMethodInfoPtr_set_zywx_Public_set_Void_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668369);
			float4.NativeMethodInfoPtr_get_zywy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668370);
			float4.NativeMethodInfoPtr_get_zywz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668371);
			float4.NativeMethodInfoPtr_get_zyww_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668372);
			float4.NativeMethodInfoPtr_get_zzxx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668373);
			float4.NativeMethodInfoPtr_get_zzxy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668374);
			float4.NativeMethodInfoPtr_get_zzxz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668375);
			float4.NativeMethodInfoPtr_get_zzxw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668376);
			float4.NativeMethodInfoPtr_get_zzyx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668377);
			float4.NativeMethodInfoPtr_get_zzyy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668378);
			float4.NativeMethodInfoPtr_get_zzyz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668379);
			float4.NativeMethodInfoPtr_get_zzyw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668380);
			float4.NativeMethodInfoPtr_get_zzzx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668381);
			float4.NativeMethodInfoPtr_get_zzzy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668382);
			float4.NativeMethodInfoPtr_get_zzzz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668383);
			float4.NativeMethodInfoPtr_get_zzzw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668384);
			float4.NativeMethodInfoPtr_get_zzwx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668385);
			float4.NativeMethodInfoPtr_get_zzwy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668386);
			float4.NativeMethodInfoPtr_get_zzwz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668387);
			float4.NativeMethodInfoPtr_get_zzww_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668388);
			float4.NativeMethodInfoPtr_get_zwxx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668389);
			float4.NativeMethodInfoPtr_get_zwxy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668390);
			float4.NativeMethodInfoPtr_set_zwxy_Public_set_Void_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668391);
			float4.NativeMethodInfoPtr_get_zwxz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668392);
			float4.NativeMethodInfoPtr_get_zwxw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668393);
			float4.NativeMethodInfoPtr_get_zwyx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668394);
			float4.NativeMethodInfoPtr_set_zwyx_Public_set_Void_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668395);
			float4.NativeMethodInfoPtr_get_zwyy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668396);
			float4.NativeMethodInfoPtr_get_zwyz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668397);
			float4.NativeMethodInfoPtr_get_zwyw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668398);
			float4.NativeMethodInfoPtr_get_zwzx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668399);
			float4.NativeMethodInfoPtr_get_zwzy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668400);
			float4.NativeMethodInfoPtr_get_zwzz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668401);
			float4.NativeMethodInfoPtr_get_zwzw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668402);
			float4.NativeMethodInfoPtr_get_zwwx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668403);
			float4.NativeMethodInfoPtr_get_zwwy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668404);
			float4.NativeMethodInfoPtr_get_zwwz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668405);
			float4.NativeMethodInfoPtr_get_zwww_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668406);
			float4.NativeMethodInfoPtr_get_wxxx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668407);
			float4.NativeMethodInfoPtr_get_wxxy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668408);
			float4.NativeMethodInfoPtr_get_wxxz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668409);
			float4.NativeMethodInfoPtr_get_wxxw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668410);
			float4.NativeMethodInfoPtr_get_wxyx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668411);
			float4.NativeMethodInfoPtr_get_wxyy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668412);
			float4.NativeMethodInfoPtr_get_wxyz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668413);
			float4.NativeMethodInfoPtr_set_wxyz_Public_set_Void_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668414);
			float4.NativeMethodInfoPtr_get_wxyw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668415);
			float4.NativeMethodInfoPtr_get_wxzx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668416);
			float4.NativeMethodInfoPtr_get_wxzy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668417);
			float4.NativeMethodInfoPtr_set_wxzy_Public_set_Void_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668418);
			float4.NativeMethodInfoPtr_get_wxzz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668419);
			float4.NativeMethodInfoPtr_get_wxzw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668420);
			float4.NativeMethodInfoPtr_get_wxwx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668421);
			float4.NativeMethodInfoPtr_get_wxwy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668422);
			float4.NativeMethodInfoPtr_get_wxwz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668423);
			float4.NativeMethodInfoPtr_get_wxww_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668424);
			float4.NativeMethodInfoPtr_get_wyxx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668425);
			float4.NativeMethodInfoPtr_get_wyxy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668426);
			float4.NativeMethodInfoPtr_get_wyxz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668427);
			float4.NativeMethodInfoPtr_set_wyxz_Public_set_Void_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668428);
			float4.NativeMethodInfoPtr_get_wyxw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668429);
			float4.NativeMethodInfoPtr_get_wyyx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668430);
			float4.NativeMethodInfoPtr_get_wyyy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668431);
			float4.NativeMethodInfoPtr_get_wyyz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668432);
			float4.NativeMethodInfoPtr_get_wyyw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668433);
			float4.NativeMethodInfoPtr_get_wyzx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668434);
			float4.NativeMethodInfoPtr_set_wyzx_Public_set_Void_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668435);
			float4.NativeMethodInfoPtr_get_wyzy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668436);
			float4.NativeMethodInfoPtr_get_wyzz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668437);
			float4.NativeMethodInfoPtr_get_wyzw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668438);
			float4.NativeMethodInfoPtr_get_wywx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668439);
			float4.NativeMethodInfoPtr_get_wywy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668440);
			float4.NativeMethodInfoPtr_get_wywz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668441);
			float4.NativeMethodInfoPtr_get_wyww_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668442);
			float4.NativeMethodInfoPtr_get_wzxx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668443);
			float4.NativeMethodInfoPtr_get_wzxy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668444);
			float4.NativeMethodInfoPtr_set_wzxy_Public_set_Void_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668445);
			float4.NativeMethodInfoPtr_get_wzxz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668446);
			float4.NativeMethodInfoPtr_get_wzxw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668447);
			float4.NativeMethodInfoPtr_get_wzyx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668448);
			float4.NativeMethodInfoPtr_set_wzyx_Public_set_Void_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668449);
			float4.NativeMethodInfoPtr_get_wzyy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668450);
			float4.NativeMethodInfoPtr_get_wzyz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668451);
			float4.NativeMethodInfoPtr_get_wzyw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668452);
			float4.NativeMethodInfoPtr_get_wzzx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668453);
			float4.NativeMethodInfoPtr_get_wzzy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668454);
			float4.NativeMethodInfoPtr_get_wzzz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668455);
			float4.NativeMethodInfoPtr_get_wzzw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668456);
			float4.NativeMethodInfoPtr_get_wzwx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668457);
			float4.NativeMethodInfoPtr_get_wzwy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668458);
			float4.NativeMethodInfoPtr_get_wzwz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668459);
			float4.NativeMethodInfoPtr_get_wzww_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668460);
			float4.NativeMethodInfoPtr_get_wwxx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668461);
			float4.NativeMethodInfoPtr_get_wwxy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668462);
			float4.NativeMethodInfoPtr_get_wwxz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668463);
			float4.NativeMethodInfoPtr_get_wwxw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668464);
			float4.NativeMethodInfoPtr_get_wwyx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668465);
			float4.NativeMethodInfoPtr_get_wwyy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668466);
			float4.NativeMethodInfoPtr_get_wwyz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668467);
			float4.NativeMethodInfoPtr_get_wwyw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668468);
			float4.NativeMethodInfoPtr_get_wwzx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668469);
			float4.NativeMethodInfoPtr_get_wwzy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668470);
			float4.NativeMethodInfoPtr_get_wwzz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668471);
			float4.NativeMethodInfoPtr_get_wwzw_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668472);
			float4.NativeMethodInfoPtr_get_wwwx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668473);
			float4.NativeMethodInfoPtr_get_wwwy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668474);
			float4.NativeMethodInfoPtr_get_wwwz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668475);
			float4.NativeMethodInfoPtr_get_wwww_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668476);
			float4.NativeMethodInfoPtr_get_xxx_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668477);
			float4.NativeMethodInfoPtr_get_xxy_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668478);
			float4.NativeMethodInfoPtr_get_xxz_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668479);
			float4.NativeMethodInfoPtr_get_xxw_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668480);
			float4.NativeMethodInfoPtr_get_xyx_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668481);
			float4.NativeMethodInfoPtr_get_xyy_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668482);
			float4.NativeMethodInfoPtr_get_xyz_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668483);
			float4.NativeMethodInfoPtr_set_xyz_Public_set_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668484);
			float4.NativeMethodInfoPtr_get_xyw_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668485);
			float4.NativeMethodInfoPtr_set_xyw_Public_set_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668486);
			float4.NativeMethodInfoPtr_get_xzx_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668487);
			float4.NativeMethodInfoPtr_get_xzy_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668488);
			float4.NativeMethodInfoPtr_set_xzy_Public_set_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668489);
			float4.NativeMethodInfoPtr_get_xzz_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668490);
			float4.NativeMethodInfoPtr_get_xzw_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668491);
			float4.NativeMethodInfoPtr_set_xzw_Public_set_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668492);
			float4.NativeMethodInfoPtr_get_xwx_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668493);
			float4.NativeMethodInfoPtr_get_xwy_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668494);
			float4.NativeMethodInfoPtr_set_xwy_Public_set_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668495);
			float4.NativeMethodInfoPtr_get_xwz_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668496);
			float4.NativeMethodInfoPtr_set_xwz_Public_set_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668497);
			float4.NativeMethodInfoPtr_get_xww_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668498);
			float4.NativeMethodInfoPtr_get_yxx_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668499);
			float4.NativeMethodInfoPtr_get_yxy_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668500);
			float4.NativeMethodInfoPtr_get_yxz_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668501);
			float4.NativeMethodInfoPtr_set_yxz_Public_set_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668502);
			float4.NativeMethodInfoPtr_get_yxw_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668503);
			float4.NativeMethodInfoPtr_set_yxw_Public_set_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668504);
			float4.NativeMethodInfoPtr_get_yyx_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668505);
			float4.NativeMethodInfoPtr_get_yyy_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668506);
			float4.NativeMethodInfoPtr_get_yyz_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668507);
			float4.NativeMethodInfoPtr_get_yyw_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668508);
			float4.NativeMethodInfoPtr_get_yzx_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668509);
			float4.NativeMethodInfoPtr_set_yzx_Public_set_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668510);
			float4.NativeMethodInfoPtr_get_yzy_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668511);
			float4.NativeMethodInfoPtr_get_yzz_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668512);
			float4.NativeMethodInfoPtr_get_yzw_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668513);
			float4.NativeMethodInfoPtr_set_yzw_Public_set_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668514);
			float4.NativeMethodInfoPtr_get_ywx_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668515);
			float4.NativeMethodInfoPtr_set_ywx_Public_set_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668516);
			float4.NativeMethodInfoPtr_get_ywy_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668517);
			float4.NativeMethodInfoPtr_get_ywz_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668518);
			float4.NativeMethodInfoPtr_set_ywz_Public_set_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668519);
			float4.NativeMethodInfoPtr_get_yww_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668520);
			float4.NativeMethodInfoPtr_get_zxx_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668521);
			float4.NativeMethodInfoPtr_get_zxy_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668522);
			float4.NativeMethodInfoPtr_set_zxy_Public_set_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668523);
			float4.NativeMethodInfoPtr_get_zxz_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668524);
			float4.NativeMethodInfoPtr_get_zxw_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668525);
			float4.NativeMethodInfoPtr_set_zxw_Public_set_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668526);
			float4.NativeMethodInfoPtr_get_zyx_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668527);
			float4.NativeMethodInfoPtr_set_zyx_Public_set_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668528);
			float4.NativeMethodInfoPtr_get_zyy_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668529);
			float4.NativeMethodInfoPtr_get_zyz_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668530);
			float4.NativeMethodInfoPtr_get_zyw_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668531);
			float4.NativeMethodInfoPtr_set_zyw_Public_set_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668532);
			float4.NativeMethodInfoPtr_get_zzx_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668533);
			float4.NativeMethodInfoPtr_get_zzy_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668534);
			float4.NativeMethodInfoPtr_get_zzz_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668535);
			float4.NativeMethodInfoPtr_get_zzw_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668536);
			float4.NativeMethodInfoPtr_get_zwx_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668537);
			float4.NativeMethodInfoPtr_set_zwx_Public_set_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668538);
			float4.NativeMethodInfoPtr_get_zwy_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668539);
			float4.NativeMethodInfoPtr_set_zwy_Public_set_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668540);
			float4.NativeMethodInfoPtr_get_zwz_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668541);
			float4.NativeMethodInfoPtr_get_zww_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668542);
			float4.NativeMethodInfoPtr_get_wxx_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668543);
			float4.NativeMethodInfoPtr_get_wxy_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668544);
			float4.NativeMethodInfoPtr_set_wxy_Public_set_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668545);
			float4.NativeMethodInfoPtr_get_wxz_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668546);
			float4.NativeMethodInfoPtr_set_wxz_Public_set_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668547);
			float4.NativeMethodInfoPtr_get_wxw_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668548);
			float4.NativeMethodInfoPtr_get_wyx_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668549);
			float4.NativeMethodInfoPtr_set_wyx_Public_set_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668550);
			float4.NativeMethodInfoPtr_get_wyy_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668551);
			float4.NativeMethodInfoPtr_get_wyz_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668552);
			float4.NativeMethodInfoPtr_set_wyz_Public_set_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668553);
			float4.NativeMethodInfoPtr_get_wyw_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668554);
			float4.NativeMethodInfoPtr_get_wzx_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668555);
			float4.NativeMethodInfoPtr_set_wzx_Public_set_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668556);
			float4.NativeMethodInfoPtr_get_wzy_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668557);
			float4.NativeMethodInfoPtr_set_wzy_Public_set_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668558);
			float4.NativeMethodInfoPtr_get_wzz_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668559);
			float4.NativeMethodInfoPtr_get_wzw_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668560);
			float4.NativeMethodInfoPtr_get_wwx_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668561);
			float4.NativeMethodInfoPtr_get_wwy_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668562);
			float4.NativeMethodInfoPtr_get_wwz_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668563);
			float4.NativeMethodInfoPtr_get_www_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668564);
			float4.NativeMethodInfoPtr_get_xx_Public_get_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668565);
			float4.NativeMethodInfoPtr_get_xy_Public_get_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668566);
			float4.NativeMethodInfoPtr_set_xy_Public_set_Void_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668567);
			float4.NativeMethodInfoPtr_get_xz_Public_get_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668568);
			float4.NativeMethodInfoPtr_set_xz_Public_set_Void_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668569);
			float4.NativeMethodInfoPtr_get_xw_Public_get_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668570);
			float4.NativeMethodInfoPtr_set_xw_Public_set_Void_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668571);
			float4.NativeMethodInfoPtr_get_yx_Public_get_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668572);
			float4.NativeMethodInfoPtr_set_yx_Public_set_Void_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668573);
			float4.NativeMethodInfoPtr_get_yy_Public_get_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668574);
			float4.NativeMethodInfoPtr_get_yz_Public_get_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668575);
			float4.NativeMethodInfoPtr_set_yz_Public_set_Void_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668576);
			float4.NativeMethodInfoPtr_get_yw_Public_get_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668577);
			float4.NativeMethodInfoPtr_set_yw_Public_set_Void_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668578);
			float4.NativeMethodInfoPtr_get_zx_Public_get_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668579);
			float4.NativeMethodInfoPtr_set_zx_Public_set_Void_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668580);
			float4.NativeMethodInfoPtr_get_zy_Public_get_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668581);
			float4.NativeMethodInfoPtr_set_zy_Public_set_Void_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668582);
			float4.NativeMethodInfoPtr_get_zz_Public_get_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668583);
			float4.NativeMethodInfoPtr_get_zw_Public_get_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668584);
			float4.NativeMethodInfoPtr_set_zw_Public_set_Void_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668585);
			float4.NativeMethodInfoPtr_get_wx_Public_get_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668586);
			float4.NativeMethodInfoPtr_set_wx_Public_set_Void_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668587);
			float4.NativeMethodInfoPtr_get_wy_Public_get_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668588);
			float4.NativeMethodInfoPtr_set_wy_Public_set_Void_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668589);
			float4.NativeMethodInfoPtr_get_wz_Public_get_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668590);
			float4.NativeMethodInfoPtr_set_wz_Public_set_Void_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668591);
			float4.NativeMethodInfoPtr_get_ww_Public_get_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668592);
			float4.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668593);
			float4.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668594);
			float4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668595);
			float4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668596);
			float4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668597);
			float4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668598);
			float4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668599);
			float4.NativeMethodInfoPtr_op_Implicit_Public_Static_float4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668600);
			float4.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4>.NativeClassPtr, 100668601);
		}

		// Token: 0x0600137A RID: 4986 RVA: 0x0006BFF8 File Offset: 0x0006A1F8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 323501, RefRangeEnd = 323508, XrefRangeStart = 323501, XrefRangeEnd = 323508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float4(float x, float y, float z, float w)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600137B RID: 4987 RVA: 0x0006C054 File Offset: 0x0006A254
		[CallerCount(0)]
		public unsafe float4(float x, float y, float2 zw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_float2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600137C RID: 4988 RVA: 0x0006C0A4 File Offset: 0x0006A2A4
		[CallerCount(0)]
		public unsafe float4(float x, float2 yz, float w)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yz;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr__ctor_Public_Void_Single_float2_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x0006C0F4 File Offset: 0x0006A2F4
		[CallerCount(0)]
		public unsafe float4(float x, float3 yzw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yzw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr__ctor_Public_Void_Single_float3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600137E RID: 4990 RVA: 0x0006C134 File Offset: 0x0006A334
		[CallerCount(0)]
		public unsafe float4(float2 xy, float z, float w)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xy;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr__ctor_Public_Void_float2_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x0006C184 File Offset: 0x0006A384
		[CallerCount(0)]
		public unsafe float4(float2 xy, float2 zw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xy;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr__ctor_Public_Void_float2_float2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x0006C1C4 File Offset: 0x0006A3C4
		[CallerCount(0)]
		public unsafe float4(float3 xyz, float w)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr__ctor_Public_Void_float3_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x0006C204 File Offset: 0x0006A404
		[CallerCount(0)]
		public unsafe float4(float4 xyzw)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyzw;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr__ctor_Public_Void_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001382 RID: 4994 RVA: 0x0006C238 File Offset: 0x0006A438
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 637906, RefRangeEnd = 637908, XrefRangeStart = 637906, XrefRangeEnd = 637906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float4(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001383 RID: 4995 RVA: 0x0006C26C File Offset: 0x0006A46C
		[CallerCount(0)]
		public unsafe float4(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001384 RID: 4996 RVA: 0x0006C2A0 File Offset: 0x0006A4A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637908, XrefRangeEnd = 637911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float4(bool4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr__ctor_Public_Void_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001385 RID: 4997 RVA: 0x0006C2D4 File Offset: 0x0006A4D4
		[CallerCount(0)]
		public unsafe float4(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x0006C308 File Offset: 0x0006A508
		[CallerCount(0)]
		public unsafe float4(int4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr__ctor_Public_Void_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001387 RID: 4999 RVA: 0x0006C33C File Offset: 0x0006A53C
		[CallerCount(0)]
		public unsafe float4(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x0006C370 File Offset: 0x0006A570
		[CallerCount(0)]
		public unsafe float4(uint4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr__ctor_Public_Void_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x0006C3A4 File Offset: 0x0006A5A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 637911, RefRangeEnd = 637913, XrefRangeStart = 637911, XrefRangeEnd = 637911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float4(half v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr__ctor_Public_Void_half_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600138A RID: 5002 RVA: 0x0006C3D8 File Offset: 0x0006A5D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 637913, RefRangeEnd = 637915, XrefRangeStart = 637913, XrefRangeEnd = 637913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float4(half4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr__ctor_Public_Void_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600138B RID: 5003 RVA: 0x0006C40C File Offset: 0x0006A60C
		[CallerCount(0)]
		public unsafe float4(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600138C RID: 5004 RVA: 0x0006C440 File Offset: 0x0006A640
		[CallerCount(0)]
		public unsafe float4(double4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr__ctor_Public_Void_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600138D RID: 5005 RVA: 0x0006C474 File Offset: 0x0006A674
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 630702, RefRangeEnd = 630709, XrefRangeStart = 630702, XrefRangeEnd = 630709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator float4(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_Implicit_Public_Static_float4_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x0006C4B4 File Offset: 0x0006A6B4
		[CallerCount(0)]
		public unsafe static explicit operator float4(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_Explicit_Public_Static_float4_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600138F RID: 5007 RVA: 0x0006C4F4 File Offset: 0x0006A6F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator float4(bool4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_Explicit_Public_Static_float4_bool4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001390 RID: 5008 RVA: 0x0006C534 File Offset: 0x0006A734
		[CallerCount(0)]
		public unsafe static implicit operator float4(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_Implicit_Public_Static_float4_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001391 RID: 5009 RVA: 0x0006C574 File Offset: 0x0006A774
		[CallerCount(0)]
		public unsafe static implicit operator float4(int4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_Implicit_Public_Static_float4_int4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001392 RID: 5010 RVA: 0x0006C5B4 File Offset: 0x0006A7B4
		[CallerCount(0)]
		public unsafe static implicit operator float4(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_Implicit_Public_Static_float4_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001393 RID: 5011 RVA: 0x0006C5F4 File Offset: 0x0006A7F4
		[CallerCount(0)]
		public unsafe static implicit operator float4(uint4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_Implicit_Public_Static_float4_uint4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001394 RID: 5012 RVA: 0x0006C634 File Offset: 0x0006A834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator float4(half v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_Implicit_Public_Static_float4_half_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x0006C674 File Offset: 0x0006A874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator float4(half4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_Implicit_Public_Static_float4_half4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001396 RID: 5014 RVA: 0x0006C6B4 File Offset: 0x0006A8B4
		[CallerCount(0)]
		public unsafe static explicit operator float4(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_Explicit_Public_Static_float4_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001397 RID: 5015 RVA: 0x0006C6F4 File Offset: 0x0006A8F4
		[CallerCount(0)]
		public unsafe static explicit operator float4(double4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_Explicit_Public_Static_float4_double4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001398 RID: 5016 RVA: 0x0006C734 File Offset: 0x0006A934
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 637915, RefRangeEnd = 637919, XrefRangeStart = 637915, XrefRangeEnd = 637915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4 operator *(float4 lhs, float4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_Multiply_Public_Static_float4_float4_float4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x0006C780 File Offset: 0x0006A980
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 637919, RefRangeEnd = 637951, XrefRangeStart = 637919, XrefRangeEnd = 637919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4 operator *(float4 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_Multiply_Public_Static_float4_float4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600139A RID: 5018 RVA: 0x0006C7CC File Offset: 0x0006A9CC
		[CallerCount(0)]
		public unsafe static float4 operator *(float lhs, float4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_Multiply_Public_Static_float4_Single_float4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600139B RID: 5019 RVA: 0x0006C818 File Offset: 0x0006AA18
		[CallerCount(0)]
		public unsafe static float4 operator +(float4 lhs, float4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_Addition_Public_Static_float4_float4_float4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600139C RID: 5020 RVA: 0x0006C864 File Offset: 0x0006AA64
		[CallerCount(0)]
		public unsafe static float4 operator +(float4 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_Addition_Public_Static_float4_float4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600139D RID: 5021 RVA: 0x0006C8B0 File Offset: 0x0006AAB0
		[CallerCount(0)]
		public unsafe static float4 operator +(float lhs, float4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_Addition_Public_Static_float4_Single_float4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x0006C8FC File Offset: 0x0006AAFC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 637951, RefRangeEnd = 637961, XrefRangeStart = 637951, XrefRangeEnd = 637951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4 operator -(float4 lhs, float4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_Subtraction_Public_Static_float4_float4_float4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x0006C948 File Offset: 0x0006AB48
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 637961, RefRangeEnd = 637966, XrefRangeStart = 637961, XrefRangeEnd = 637961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4 operator -(float4 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_Subtraction_Public_Static_float4_float4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x0006C994 File Offset: 0x0006AB94
		[CallerCount(0)]
		public unsafe static float4 operator -(float lhs, float4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_Subtraction_Public_Static_float4_Single_float4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x0006C9E0 File Offset: 0x0006ABE0
		[CallerCount(0)]
		public unsafe static float4 operator /(float4 lhs, float4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_Division_Public_Static_float4_float4_float4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x0006CA2C File Offset: 0x0006AC2C
		[CallerCount(0)]
		public unsafe static float4 operator /(float4 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_Division_Public_Static_float4_float4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013A3 RID: 5027 RVA: 0x0006CA78 File Offset: 0x0006AC78
		[CallerCount(0)]
		public unsafe static float4 operator /(float lhs, float4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_Division_Public_Static_float4_Single_float4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x0006CAC4 File Offset: 0x0006ACC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4 operator %(float4 lhs, float4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_Modulus_Public_Static_float4_float4_float4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x0006CB10 File Offset: 0x0006AD10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637966, XrefRangeEnd = 637970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4 operator %(float4 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_Modulus_Public_Static_float4_float4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x0006CB5C File Offset: 0x0006AD5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637970, XrefRangeEnd = 637974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4 operator %(float lhs, float4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_Modulus_Public_Static_float4_Single_float4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x0006CBA8 File Offset: 0x0006ADA8
		[CallerCount(0)]
		public unsafe static float4 operator ++(float4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_Increment_Public_Static_float4_float4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013A8 RID: 5032 RVA: 0x0006CBE8 File Offset: 0x0006ADE8
		[CallerCount(0)]
		public unsafe static float4 operator --(float4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_Decrement_Public_Static_float4_float4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013A9 RID: 5033 RVA: 0x0006CC28 File Offset: 0x0006AE28
		[CallerCount(0)]
		public unsafe static bool4 operator <(float4 lhs, float4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4_float4_float4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x0006CC74 File Offset: 0x0006AE74
		[CallerCount(0)]
		public unsafe static bool4 operator <(float4 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4_float4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x0006CCC0 File Offset: 0x0006AEC0
		[CallerCount(0)]
		public unsafe static bool4 operator <(float lhs, float4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4_Single_float4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013AC RID: 5036 RVA: 0x0006CD0C File Offset: 0x0006AF0C
		[CallerCount(0)]
		public unsafe static bool4 operator <=(float4 lhs, float4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4_float4_float4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x0006CD58 File Offset: 0x0006AF58
		[CallerCount(0)]
		public unsafe static bool4 operator <=(float4 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4_float4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x0006CDA4 File Offset: 0x0006AFA4
		[CallerCount(0)]
		public unsafe static bool4 operator <=(float lhs, float4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4_Single_float4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x0006CDF0 File Offset: 0x0006AFF0
		[CallerCount(0)]
		public unsafe static bool4 operator >(float4 lhs, float4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4_float4_float4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x0006CE3C File Offset: 0x0006B03C
		[CallerCount(0)]
		public unsafe static bool4 operator >(float4 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4_float4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x0006CE88 File Offset: 0x0006B088
		[CallerCount(0)]
		public unsafe static bool4 operator >(float lhs, float4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4_Single_float4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x0006CED4 File Offset: 0x0006B0D4
		[CallerCount(0)]
		public unsafe static bool4 operator >=(float4 lhs, float4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4_float4_float4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x0006CF20 File Offset: 0x0006B120
		[CallerCount(0)]
		public unsafe static bool4 operator >=(float4 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4_float4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x0006CF6C File Offset: 0x0006B16C
		[CallerCount(0)]
		public unsafe static bool4 operator >=(float lhs, float4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4_Single_float4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x0006CFB8 File Offset: 0x0006B1B8
		[CallerCount(0)]
		public unsafe static float4 operator -(float4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_float4_float4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x0006CFF8 File Offset: 0x0006B1F8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 637974, RefRangeEnd = 637984, XrefRangeStart = 637974, XrefRangeEnd = 637974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4 operator +(float4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_float4_float4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013B7 RID: 5047 RVA: 0x0006D038 File Offset: 0x0006B238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637984, XrefRangeEnd = 637988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool4 operator ==(float4 lhs, float4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4_float4_float4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x0006D084 File Offset: 0x0006B284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637988, XrefRangeEnd = 637991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool4 operator ==(float4 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4_float4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x0006D0D0 File Offset: 0x0006B2D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637991, XrefRangeEnd = 637995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool4 operator ==(float lhs, float4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4_Single_float4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x0006D11C File Offset: 0x0006B31C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637995, XrefRangeEnd = 637999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool4 operator !=(float4 lhs, float4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_float4_float4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x0006D168 File Offset: 0x0006B368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637999, XrefRangeEnd = 638002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool4 operator !=(float4 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_float4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013BC RID: 5052 RVA: 0x0006D1B4 File Offset: 0x0006B3B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638002, XrefRangeEnd = 638006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool4 operator !=(float lhs, float4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_Single_float4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x060013BD RID: 5053 RVA: 0x0006D200 File Offset: 0x0006B400
		public unsafe float4 xxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xxxx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x060013BE RID: 5054 RVA: 0x0006D230 File Offset: 0x0006B430
		public unsafe float4 xxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xxxy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x060013BF RID: 5055 RVA: 0x0006D260 File Offset: 0x0006B460
		public unsafe float4 xxxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xxxz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x060013C0 RID: 5056 RVA: 0x0006D290 File Offset: 0x0006B490
		public unsafe float4 xxxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xxxw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x060013C1 RID: 5057 RVA: 0x0006D2C0 File Offset: 0x0006B4C0
		public unsafe float4 xxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xxyx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x060013C2 RID: 5058 RVA: 0x0006D2F0 File Offset: 0x0006B4F0
		public unsafe float4 xxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xxyy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x060013C3 RID: 5059 RVA: 0x0006D320 File Offset: 0x0006B520
		public unsafe float4 xxyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xxyz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x060013C4 RID: 5060 RVA: 0x0006D350 File Offset: 0x0006B550
		public unsafe float4 xxyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xxyw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x060013C5 RID: 5061 RVA: 0x0006D380 File Offset: 0x0006B580
		public unsafe float4 xxzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xxzx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x060013C6 RID: 5062 RVA: 0x0006D3B0 File Offset: 0x0006B5B0
		public unsafe float4 xxzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xxzy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x060013C7 RID: 5063 RVA: 0x0006D3E0 File Offset: 0x0006B5E0
		public unsafe float4 xxzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xxzz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x060013C8 RID: 5064 RVA: 0x0006D410 File Offset: 0x0006B610
		public unsafe float4 xxzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xxzw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x060013C9 RID: 5065 RVA: 0x0006D440 File Offset: 0x0006B640
		public unsafe float4 xxwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xxwx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x060013CA RID: 5066 RVA: 0x0006D470 File Offset: 0x0006B670
		public unsafe float4 xxwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xxwy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x060013CB RID: 5067 RVA: 0x0006D4A0 File Offset: 0x0006B6A0
		public unsafe float4 xxwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xxwz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x060013CC RID: 5068 RVA: 0x0006D4D0 File Offset: 0x0006B6D0
		public unsafe float4 xxww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xxww_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x060013CD RID: 5069 RVA: 0x0006D500 File Offset: 0x0006B700
		public unsafe float4 xyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xyxx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x060013CE RID: 5070 RVA: 0x0006D530 File Offset: 0x0006B730
		public unsafe float4 xyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xyxy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x060013CF RID: 5071 RVA: 0x0006D560 File Offset: 0x0006B760
		public unsafe float4 xyxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xyxz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x060013D0 RID: 5072 RVA: 0x0006D590 File Offset: 0x0006B790
		public unsafe float4 xyxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xyxw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x060013D1 RID: 5073 RVA: 0x0006D5C0 File Offset: 0x0006B7C0
		public unsafe float4 xyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xyyx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x060013D2 RID: 5074 RVA: 0x0006D5F0 File Offset: 0x0006B7F0
		public unsafe float4 xyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xyyy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x060013D3 RID: 5075 RVA: 0x0006D620 File Offset: 0x0006B820
		public unsafe float4 xyyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xyyz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x060013D4 RID: 5076 RVA: 0x0006D650 File Offset: 0x0006B850
		public unsafe float4 xyyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xyyw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x060013D5 RID: 5077 RVA: 0x0006D680 File Offset: 0x0006B880
		public unsafe float4 xyzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xyzx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x060013D6 RID: 5078 RVA: 0x0006D6B0 File Offset: 0x0006B8B0
		public unsafe float4 xyzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xyzy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x060013D7 RID: 5079 RVA: 0x0006D6E0 File Offset: 0x0006B8E0
		public unsafe float4 xyzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xyzz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x060013D8 RID: 5080 RVA: 0x0006D710 File Offset: 0x0006B910
		// (set) Token: 0x060013D9 RID: 5081 RVA: 0x0006D740 File Offset: 0x0006B940
		public unsafe float4 xyzw
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 637974, RefRangeEnd = 637984, XrefRangeStart = 637974, XrefRangeEnd = 637984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xyzw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_xyzw_Public_set_Void_float4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x060013DA RID: 5082 RVA: 0x0006D774 File Offset: 0x0006B974
		public unsafe float4 xywx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xywx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x060013DB RID: 5083 RVA: 0x0006D7A4 File Offset: 0x0006B9A4
		public unsafe float4 xywy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xywy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x060013DC RID: 5084 RVA: 0x0006D7D4 File Offset: 0x0006B9D4
		// (set) Token: 0x060013DD RID: 5085 RVA: 0x0006D804 File Offset: 0x0006BA04
		public unsafe float4 xywz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xywz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_xywz_Public_set_Void_float4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x060013DE RID: 5086 RVA: 0x0006D838 File Offset: 0x0006BA38
		public unsafe float4 xyww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xyww_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x060013DF RID: 5087 RVA: 0x0006D868 File Offset: 0x0006BA68
		public unsafe float4 xzxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xzxx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x060013E0 RID: 5088 RVA: 0x0006D898 File Offset: 0x0006BA98
		public unsafe float4 xzxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xzxy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x060013E1 RID: 5089 RVA: 0x0006D8C8 File Offset: 0x0006BAC8
		public unsafe float4 xzxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xzxz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x060013E2 RID: 5090 RVA: 0x0006D8F8 File Offset: 0x0006BAF8
		public unsafe float4 xzxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xzxw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x060013E3 RID: 5091 RVA: 0x0006D928 File Offset: 0x0006BB28
		public unsafe float4 xzyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xzyx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x060013E4 RID: 5092 RVA: 0x0006D958 File Offset: 0x0006BB58
		public unsafe float4 xzyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xzyy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x060013E5 RID: 5093 RVA: 0x0006D988 File Offset: 0x0006BB88
		public unsafe float4 xzyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xzyz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x060013E6 RID: 5094 RVA: 0x0006D9B8 File Offset: 0x0006BBB8
		// (set) Token: 0x060013E7 RID: 5095 RVA: 0x0006D9E8 File Offset: 0x0006BBE8
		public unsafe float4 xzyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xzyw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_xzyw_Public_set_Void_float4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x060013E8 RID: 5096 RVA: 0x0006DA1C File Offset: 0x0006BC1C
		public unsafe float4 xzzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xzzx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x060013E9 RID: 5097 RVA: 0x0006DA4C File Offset: 0x0006BC4C
		public unsafe float4 xzzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xzzy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x060013EA RID: 5098 RVA: 0x0006DA7C File Offset: 0x0006BC7C
		public unsafe float4 xzzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xzzz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x060013EB RID: 5099 RVA: 0x0006DAAC File Offset: 0x0006BCAC
		public unsafe float4 xzzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xzzw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x060013EC RID: 5100 RVA: 0x0006DADC File Offset: 0x0006BCDC
		public unsafe float4 xzwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xzwx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x060013ED RID: 5101 RVA: 0x0006DB0C File Offset: 0x0006BD0C
		// (set) Token: 0x060013EE RID: 5102 RVA: 0x0006DB3C File Offset: 0x0006BD3C
		public unsafe float4 xzwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xzwy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_xzwy_Public_set_Void_float4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x060013EF RID: 5103 RVA: 0x0006DB70 File Offset: 0x0006BD70
		public unsafe float4 xzwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xzwz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x060013F0 RID: 5104 RVA: 0x0006DBA0 File Offset: 0x0006BDA0
		public unsafe float4 xzww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xzww_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x060013F1 RID: 5105 RVA: 0x0006DBD0 File Offset: 0x0006BDD0
		public unsafe float4 xwxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xwxx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x060013F2 RID: 5106 RVA: 0x0006DC00 File Offset: 0x0006BE00
		public unsafe float4 xwxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xwxy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x060013F3 RID: 5107 RVA: 0x0006DC30 File Offset: 0x0006BE30
		public unsafe float4 xwxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xwxz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x060013F4 RID: 5108 RVA: 0x0006DC60 File Offset: 0x0006BE60
		public unsafe float4 xwxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xwxw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x060013F5 RID: 5109 RVA: 0x0006DC90 File Offset: 0x0006BE90
		public unsafe float4 xwyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xwyx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x060013F6 RID: 5110 RVA: 0x0006DCC0 File Offset: 0x0006BEC0
		public unsafe float4 xwyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xwyy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x060013F7 RID: 5111 RVA: 0x0006DCF0 File Offset: 0x0006BEF0
		// (set) Token: 0x060013F8 RID: 5112 RVA: 0x0006DD20 File Offset: 0x0006BF20
		public unsafe float4 xwyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xwyz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_xwyz_Public_set_Void_float4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x060013F9 RID: 5113 RVA: 0x0006DD54 File Offset: 0x0006BF54
		public unsafe float4 xwyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xwyw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x060013FA RID: 5114 RVA: 0x0006DD84 File Offset: 0x0006BF84
		public unsafe float4 xwzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xwzx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x060013FB RID: 5115 RVA: 0x0006DDB4 File Offset: 0x0006BFB4
		// (set) Token: 0x060013FC RID: 5116 RVA: 0x0006DDE4 File Offset: 0x0006BFE4
		public unsafe float4 xwzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xwzy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_xwzy_Public_set_Void_float4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x060013FD RID: 5117 RVA: 0x0006DE18 File Offset: 0x0006C018
		public unsafe float4 xwzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xwzz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x060013FE RID: 5118 RVA: 0x0006DE48 File Offset: 0x0006C048
		public unsafe float4 xwzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xwzw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x060013FF RID: 5119 RVA: 0x0006DE78 File Offset: 0x0006C078
		public unsafe float4 xwwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xwwx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06001400 RID: 5120 RVA: 0x0006DEA8 File Offset: 0x0006C0A8
		public unsafe float4 xwwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xwwy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06001401 RID: 5121 RVA: 0x0006DED8 File Offset: 0x0006C0D8
		public unsafe float4 xwwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xwwz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06001402 RID: 5122 RVA: 0x0006DF08 File Offset: 0x0006C108
		public unsafe float4 xwww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xwww_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06001403 RID: 5123 RVA: 0x0006DF38 File Offset: 0x0006C138
		public unsafe float4 yxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yxxx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06001404 RID: 5124 RVA: 0x0006DF68 File Offset: 0x0006C168
		public unsafe float4 yxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yxxy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06001405 RID: 5125 RVA: 0x0006DF98 File Offset: 0x0006C198
		public unsafe float4 yxxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yxxz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06001406 RID: 5126 RVA: 0x0006DFC8 File Offset: 0x0006C1C8
		public unsafe float4 yxxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yxxw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06001407 RID: 5127 RVA: 0x0006DFF8 File Offset: 0x0006C1F8
		public unsafe float4 yxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yxyx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06001408 RID: 5128 RVA: 0x0006E028 File Offset: 0x0006C228
		public unsafe float4 yxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yxyy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06001409 RID: 5129 RVA: 0x0006E058 File Offset: 0x0006C258
		public unsafe float4 yxyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yxyz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x0600140A RID: 5130 RVA: 0x0006E088 File Offset: 0x0006C288
		public unsafe float4 yxyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yxyw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x0600140B RID: 5131 RVA: 0x0006E0B8 File Offset: 0x0006C2B8
		public unsafe float4 yxzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yxzx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x0600140C RID: 5132 RVA: 0x0006E0E8 File Offset: 0x0006C2E8
		public unsafe float4 yxzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yxzy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x0600140D RID: 5133 RVA: 0x0006E118 File Offset: 0x0006C318
		public unsafe float4 yxzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yxzz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x0600140E RID: 5134 RVA: 0x0006E148 File Offset: 0x0006C348
		// (set) Token: 0x0600140F RID: 5135 RVA: 0x0006E178 File Offset: 0x0006C378
		public unsafe float4 yxzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yxzw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_yxzw_Public_set_Void_float4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06001410 RID: 5136 RVA: 0x0006E1AC File Offset: 0x0006C3AC
		public unsafe float4 yxwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yxwx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06001411 RID: 5137 RVA: 0x0006E1DC File Offset: 0x0006C3DC
		public unsafe float4 yxwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yxwy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06001412 RID: 5138 RVA: 0x0006E20C File Offset: 0x0006C40C
		// (set) Token: 0x06001413 RID: 5139 RVA: 0x0006E23C File Offset: 0x0006C43C
		public unsafe float4 yxwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yxwz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_yxwz_Public_set_Void_float4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06001414 RID: 5140 RVA: 0x0006E270 File Offset: 0x0006C470
		public unsafe float4 yxww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yxww_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06001415 RID: 5141 RVA: 0x0006E2A0 File Offset: 0x0006C4A0
		public unsafe float4 yyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yyxx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06001416 RID: 5142 RVA: 0x0006E2D0 File Offset: 0x0006C4D0
		public unsafe float4 yyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yyxy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06001417 RID: 5143 RVA: 0x0006E300 File Offset: 0x0006C500
		public unsafe float4 yyxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yyxz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06001418 RID: 5144 RVA: 0x0006E330 File Offset: 0x0006C530
		public unsafe float4 yyxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yyxw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06001419 RID: 5145 RVA: 0x0006E360 File Offset: 0x0006C560
		public unsafe float4 yyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yyyx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x0600141A RID: 5146 RVA: 0x0006E390 File Offset: 0x0006C590
		public unsafe float4 yyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yyyy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x0600141B RID: 5147 RVA: 0x0006E3C0 File Offset: 0x0006C5C0
		public unsafe float4 yyyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yyyz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x0600141C RID: 5148 RVA: 0x0006E3F0 File Offset: 0x0006C5F0
		public unsafe float4 yyyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yyyw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x0600141D RID: 5149 RVA: 0x0006E420 File Offset: 0x0006C620
		public unsafe float4 yyzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yyzx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x0600141E RID: 5150 RVA: 0x0006E450 File Offset: 0x0006C650
		public unsafe float4 yyzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yyzy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x0600141F RID: 5151 RVA: 0x0006E480 File Offset: 0x0006C680
		public unsafe float4 yyzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yyzz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06001420 RID: 5152 RVA: 0x0006E4B0 File Offset: 0x0006C6B0
		public unsafe float4 yyzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yyzw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06001421 RID: 5153 RVA: 0x0006E4E0 File Offset: 0x0006C6E0
		public unsafe float4 yywx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yywx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06001422 RID: 5154 RVA: 0x0006E510 File Offset: 0x0006C710
		public unsafe float4 yywy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yywy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06001423 RID: 5155 RVA: 0x0006E540 File Offset: 0x0006C740
		public unsafe float4 yywz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yywz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06001424 RID: 5156 RVA: 0x0006E570 File Offset: 0x0006C770
		public unsafe float4 yyww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yyww_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06001425 RID: 5157 RVA: 0x0006E5A0 File Offset: 0x0006C7A0
		public unsafe float4 yzxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yzxx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06001426 RID: 5158 RVA: 0x0006E5D0 File Offset: 0x0006C7D0
		public unsafe float4 yzxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yzxy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06001427 RID: 5159 RVA: 0x0006E600 File Offset: 0x0006C800
		public unsafe float4 yzxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yzxz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06001428 RID: 5160 RVA: 0x0006E630 File Offset: 0x0006C830
		// (set) Token: 0x06001429 RID: 5161 RVA: 0x0006E660 File Offset: 0x0006C860
		public unsafe float4 yzxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yzxw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_yzxw_Public_set_Void_float4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x0600142A RID: 5162 RVA: 0x0006E694 File Offset: 0x0006C894
		public unsafe float4 yzyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yzyx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x0600142B RID: 5163 RVA: 0x0006E6C4 File Offset: 0x0006C8C4
		public unsafe float4 yzyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yzyy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x0600142C RID: 5164 RVA: 0x0006E6F4 File Offset: 0x0006C8F4
		public unsafe float4 yzyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yzyz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x0600142D RID: 5165 RVA: 0x0006E724 File Offset: 0x0006C924
		public unsafe float4 yzyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yzyw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x0600142E RID: 5166 RVA: 0x0006E754 File Offset: 0x0006C954
		public unsafe float4 yzzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yzzx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x0600142F RID: 5167 RVA: 0x0006E784 File Offset: 0x0006C984
		public unsafe float4 yzzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yzzy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06001430 RID: 5168 RVA: 0x0006E7B4 File Offset: 0x0006C9B4
		public unsafe float4 yzzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yzzz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06001431 RID: 5169 RVA: 0x0006E7E4 File Offset: 0x0006C9E4
		public unsafe float4 yzzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yzzw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06001432 RID: 5170 RVA: 0x0006E814 File Offset: 0x0006CA14
		// (set) Token: 0x06001433 RID: 5171 RVA: 0x0006E844 File Offset: 0x0006CA44
		public unsafe float4 yzwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yzwx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_yzwx_Public_set_Void_float4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06001434 RID: 5172 RVA: 0x0006E878 File Offset: 0x0006CA78
		public unsafe float4 yzwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yzwy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06001435 RID: 5173 RVA: 0x0006E8A8 File Offset: 0x0006CAA8
		public unsafe float4 yzwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yzwz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06001436 RID: 5174 RVA: 0x0006E8D8 File Offset: 0x0006CAD8
		public unsafe float4 yzww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yzww_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06001437 RID: 5175 RVA: 0x0006E908 File Offset: 0x0006CB08
		public unsafe float4 ywxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_ywxx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06001438 RID: 5176 RVA: 0x0006E938 File Offset: 0x0006CB38
		public unsafe float4 ywxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_ywxy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06001439 RID: 5177 RVA: 0x0006E968 File Offset: 0x0006CB68
		// (set) Token: 0x0600143A RID: 5178 RVA: 0x0006E998 File Offset: 0x0006CB98
		public unsafe float4 ywxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_ywxz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_ywxz_Public_set_Void_float4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x0600143B RID: 5179 RVA: 0x0006E9CC File Offset: 0x0006CBCC
		public unsafe float4 ywxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_ywxw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x0600143C RID: 5180 RVA: 0x0006E9FC File Offset: 0x0006CBFC
		public unsafe float4 ywyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_ywyx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x0600143D RID: 5181 RVA: 0x0006EA2C File Offset: 0x0006CC2C
		public unsafe float4 ywyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_ywyy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x0600143E RID: 5182 RVA: 0x0006EA5C File Offset: 0x0006CC5C
		public unsafe float4 ywyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_ywyz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x0600143F RID: 5183 RVA: 0x0006EA8C File Offset: 0x0006CC8C
		public unsafe float4 ywyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_ywyw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06001440 RID: 5184 RVA: 0x0006EABC File Offset: 0x0006CCBC
		// (set) Token: 0x06001441 RID: 5185 RVA: 0x0006EAEC File Offset: 0x0006CCEC
		public unsafe float4 ywzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_ywzx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_ywzx_Public_set_Void_float4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06001442 RID: 5186 RVA: 0x0006EB20 File Offset: 0x0006CD20
		public unsafe float4 ywzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_ywzy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06001443 RID: 5187 RVA: 0x0006EB50 File Offset: 0x0006CD50
		public unsafe float4 ywzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_ywzz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06001444 RID: 5188 RVA: 0x0006EB80 File Offset: 0x0006CD80
		public unsafe float4 ywzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_ywzw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06001445 RID: 5189 RVA: 0x0006EBB0 File Offset: 0x0006CDB0
		public unsafe float4 ywwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_ywwx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06001446 RID: 5190 RVA: 0x0006EBE0 File Offset: 0x0006CDE0
		public unsafe float4 ywwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_ywwy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06001447 RID: 5191 RVA: 0x0006EC10 File Offset: 0x0006CE10
		public unsafe float4 ywwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_ywwz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06001448 RID: 5192 RVA: 0x0006EC40 File Offset: 0x0006CE40
		public unsafe float4 ywww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_ywww_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06001449 RID: 5193 RVA: 0x0006EC70 File Offset: 0x0006CE70
		public unsafe float4 zxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zxxx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x0600144A RID: 5194 RVA: 0x0006ECA0 File Offset: 0x0006CEA0
		public unsafe float4 zxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zxxy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x0600144B RID: 5195 RVA: 0x0006ECD0 File Offset: 0x0006CED0
		public unsafe float4 zxxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zxxz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x0600144C RID: 5196 RVA: 0x0006ED00 File Offset: 0x0006CF00
		public unsafe float4 zxxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zxxw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x0600144D RID: 5197 RVA: 0x0006ED30 File Offset: 0x0006CF30
		public unsafe float4 zxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zxyx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x0600144E RID: 5198 RVA: 0x0006ED60 File Offset: 0x0006CF60
		public unsafe float4 zxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zxyy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x0600144F RID: 5199 RVA: 0x0006ED90 File Offset: 0x0006CF90
		public unsafe float4 zxyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zxyz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06001450 RID: 5200 RVA: 0x0006EDC0 File Offset: 0x0006CFC0
		// (set) Token: 0x06001451 RID: 5201 RVA: 0x0006EDF0 File Offset: 0x0006CFF0
		public unsafe float4 zxyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zxyw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_zxyw_Public_set_Void_float4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06001452 RID: 5202 RVA: 0x0006EE24 File Offset: 0x0006D024
		public unsafe float4 zxzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zxzx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06001453 RID: 5203 RVA: 0x0006EE54 File Offset: 0x0006D054
		public unsafe float4 zxzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zxzy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06001454 RID: 5204 RVA: 0x0006EE84 File Offset: 0x0006D084
		public unsafe float4 zxzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zxzz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06001455 RID: 5205 RVA: 0x0006EEB4 File Offset: 0x0006D0B4
		public unsafe float4 zxzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zxzw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06001456 RID: 5206 RVA: 0x0006EEE4 File Offset: 0x0006D0E4
		public unsafe float4 zxwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zxwx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06001457 RID: 5207 RVA: 0x0006EF14 File Offset: 0x0006D114
		// (set) Token: 0x06001458 RID: 5208 RVA: 0x0006EF44 File Offset: 0x0006D144
		public unsafe float4 zxwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zxwy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_zxwy_Public_set_Void_float4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06001459 RID: 5209 RVA: 0x0006EF78 File Offset: 0x0006D178
		public unsafe float4 zxwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zxwz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x0600145A RID: 5210 RVA: 0x0006EFA8 File Offset: 0x0006D1A8
		public unsafe float4 zxww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zxww_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x0600145B RID: 5211 RVA: 0x0006EFD8 File Offset: 0x0006D1D8
		public unsafe float4 zyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zyxx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x0600145C RID: 5212 RVA: 0x0006F008 File Offset: 0x0006D208
		public unsafe float4 zyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zyxy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x0600145D RID: 5213 RVA: 0x0006F038 File Offset: 0x0006D238
		public unsafe float4 zyxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zyxz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x0600145E RID: 5214 RVA: 0x0006F068 File Offset: 0x0006D268
		// (set) Token: 0x0600145F RID: 5215 RVA: 0x0006F098 File Offset: 0x0006D298
		public unsafe float4 zyxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zyxw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_zyxw_Public_set_Void_float4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06001460 RID: 5216 RVA: 0x0006F0CC File Offset: 0x0006D2CC
		public unsafe float4 zyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zyyx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06001461 RID: 5217 RVA: 0x0006F0FC File Offset: 0x0006D2FC
		public unsafe float4 zyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zyyy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06001462 RID: 5218 RVA: 0x0006F12C File Offset: 0x0006D32C
		public unsafe float4 zyyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zyyz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06001463 RID: 5219 RVA: 0x0006F15C File Offset: 0x0006D35C
		public unsafe float4 zyyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zyyw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06001464 RID: 5220 RVA: 0x0006F18C File Offset: 0x0006D38C
		public unsafe float4 zyzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zyzx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06001465 RID: 5221 RVA: 0x0006F1BC File Offset: 0x0006D3BC
		public unsafe float4 zyzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zyzy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06001466 RID: 5222 RVA: 0x0006F1EC File Offset: 0x0006D3EC
		public unsafe float4 zyzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zyzz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06001467 RID: 5223 RVA: 0x0006F21C File Offset: 0x0006D41C
		public unsafe float4 zyzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zyzw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06001468 RID: 5224 RVA: 0x0006F24C File Offset: 0x0006D44C
		// (set) Token: 0x06001469 RID: 5225 RVA: 0x0006F27C File Offset: 0x0006D47C
		public unsafe float4 zywx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zywx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_zywx_Public_set_Void_float4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x0600146A RID: 5226 RVA: 0x0006F2B0 File Offset: 0x0006D4B0
		public unsafe float4 zywy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zywy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x0600146B RID: 5227 RVA: 0x0006F2E0 File Offset: 0x0006D4E0
		public unsafe float4 zywz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zywz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x0600146C RID: 5228 RVA: 0x0006F310 File Offset: 0x0006D510
		public unsafe float4 zyww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zyww_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x0600146D RID: 5229 RVA: 0x0006F340 File Offset: 0x0006D540
		public unsafe float4 zzxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zzxx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x0600146E RID: 5230 RVA: 0x0006F370 File Offset: 0x0006D570
		public unsafe float4 zzxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zzxy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x0600146F RID: 5231 RVA: 0x0006F3A0 File Offset: 0x0006D5A0
		public unsafe float4 zzxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zzxz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06001470 RID: 5232 RVA: 0x0006F3D0 File Offset: 0x0006D5D0
		public unsafe float4 zzxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zzxw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06001471 RID: 5233 RVA: 0x0006F400 File Offset: 0x0006D600
		public unsafe float4 zzyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zzyx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06001472 RID: 5234 RVA: 0x0006F430 File Offset: 0x0006D630
		public unsafe float4 zzyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zzyy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06001473 RID: 5235 RVA: 0x0006F460 File Offset: 0x0006D660
		public unsafe float4 zzyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zzyz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06001474 RID: 5236 RVA: 0x0006F490 File Offset: 0x0006D690
		public unsafe float4 zzyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zzyw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06001475 RID: 5237 RVA: 0x0006F4C0 File Offset: 0x0006D6C0
		public unsafe float4 zzzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zzzx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06001476 RID: 5238 RVA: 0x0006F4F0 File Offset: 0x0006D6F0
		public unsafe float4 zzzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zzzy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06001477 RID: 5239 RVA: 0x0006F520 File Offset: 0x0006D720
		public unsafe float4 zzzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zzzz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06001478 RID: 5240 RVA: 0x0006F550 File Offset: 0x0006D750
		public unsafe float4 zzzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zzzw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06001479 RID: 5241 RVA: 0x0006F580 File Offset: 0x0006D780
		public unsafe float4 zzwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zzwx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x0600147A RID: 5242 RVA: 0x0006F5B0 File Offset: 0x0006D7B0
		public unsafe float4 zzwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zzwy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x0600147B RID: 5243 RVA: 0x0006F5E0 File Offset: 0x0006D7E0
		public unsafe float4 zzwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zzwz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x0600147C RID: 5244 RVA: 0x0006F610 File Offset: 0x0006D810
		public unsafe float4 zzww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zzww_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x0600147D RID: 5245 RVA: 0x0006F640 File Offset: 0x0006D840
		public unsafe float4 zwxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zwxx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x0600147E RID: 5246 RVA: 0x0006F670 File Offset: 0x0006D870
		// (set) Token: 0x0600147F RID: 5247 RVA: 0x0006F6A0 File Offset: 0x0006D8A0
		public unsafe float4 zwxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zwxy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_zwxy_Public_set_Void_float4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06001480 RID: 5248 RVA: 0x0006F6D4 File Offset: 0x0006D8D4
		public unsafe float4 zwxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zwxz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06001481 RID: 5249 RVA: 0x0006F704 File Offset: 0x0006D904
		public unsafe float4 zwxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zwxw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06001482 RID: 5250 RVA: 0x0006F734 File Offset: 0x0006D934
		// (set) Token: 0x06001483 RID: 5251 RVA: 0x0006F764 File Offset: 0x0006D964
		public unsafe float4 zwyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zwyx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_zwyx_Public_set_Void_float4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06001484 RID: 5252 RVA: 0x0006F798 File Offset: 0x0006D998
		public unsafe float4 zwyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zwyy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06001485 RID: 5253 RVA: 0x0006F7C8 File Offset: 0x0006D9C8
		public unsafe float4 zwyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zwyz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06001486 RID: 5254 RVA: 0x0006F7F8 File Offset: 0x0006D9F8
		public unsafe float4 zwyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zwyw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06001487 RID: 5255 RVA: 0x0006F828 File Offset: 0x0006DA28
		public unsafe float4 zwzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zwzx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06001488 RID: 5256 RVA: 0x0006F858 File Offset: 0x0006DA58
		public unsafe float4 zwzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zwzy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06001489 RID: 5257 RVA: 0x0006F888 File Offset: 0x0006DA88
		public unsafe float4 zwzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zwzz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x0600148A RID: 5258 RVA: 0x0006F8B8 File Offset: 0x0006DAB8
		public unsafe float4 zwzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zwzw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x0600148B RID: 5259 RVA: 0x0006F8E8 File Offset: 0x0006DAE8
		public unsafe float4 zwwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zwwx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x0600148C RID: 5260 RVA: 0x0006F918 File Offset: 0x0006DB18
		public unsafe float4 zwwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zwwy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x0600148D RID: 5261 RVA: 0x0006F948 File Offset: 0x0006DB48
		public unsafe float4 zwwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zwwz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x0600148E RID: 5262 RVA: 0x0006F978 File Offset: 0x0006DB78
		public unsafe float4 zwww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zwww_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x0600148F RID: 5263 RVA: 0x0006F9A8 File Offset: 0x0006DBA8
		public unsafe float4 wxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wxxx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06001490 RID: 5264 RVA: 0x0006F9D8 File Offset: 0x0006DBD8
		public unsafe float4 wxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wxxy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06001491 RID: 5265 RVA: 0x0006FA08 File Offset: 0x0006DC08
		public unsafe float4 wxxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wxxz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06001492 RID: 5266 RVA: 0x0006FA38 File Offset: 0x0006DC38
		public unsafe float4 wxxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wxxw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06001493 RID: 5267 RVA: 0x0006FA68 File Offset: 0x0006DC68
		public unsafe float4 wxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wxyx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06001494 RID: 5268 RVA: 0x0006FA98 File Offset: 0x0006DC98
		public unsafe float4 wxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wxyy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06001495 RID: 5269 RVA: 0x0006FAC8 File Offset: 0x0006DCC8
		// (set) Token: 0x06001496 RID: 5270 RVA: 0x0006FAF8 File Offset: 0x0006DCF8
		public unsafe float4 wxyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wxyz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_wxyz_Public_set_Void_float4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06001497 RID: 5271 RVA: 0x0006FB2C File Offset: 0x0006DD2C
		public unsafe float4 wxyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wxyw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06001498 RID: 5272 RVA: 0x0006FB5C File Offset: 0x0006DD5C
		public unsafe float4 wxzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wxzx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06001499 RID: 5273 RVA: 0x0006FB8C File Offset: 0x0006DD8C
		// (set) Token: 0x0600149A RID: 5274 RVA: 0x0006FBBC File Offset: 0x0006DDBC
		public unsafe float4 wxzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wxzy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_wxzy_Public_set_Void_float4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x0600149B RID: 5275 RVA: 0x0006FBF0 File Offset: 0x0006DDF0
		public unsafe float4 wxzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wxzz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x0600149C RID: 5276 RVA: 0x0006FC20 File Offset: 0x0006DE20
		public unsafe float4 wxzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wxzw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x0600149D RID: 5277 RVA: 0x0006FC50 File Offset: 0x0006DE50
		public unsafe float4 wxwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wxwx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x0600149E RID: 5278 RVA: 0x0006FC80 File Offset: 0x0006DE80
		public unsafe float4 wxwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wxwy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x0600149F RID: 5279 RVA: 0x0006FCB0 File Offset: 0x0006DEB0
		public unsafe float4 wxwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wxwz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x060014A0 RID: 5280 RVA: 0x0006FCE0 File Offset: 0x0006DEE0
		public unsafe float4 wxww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wxww_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x060014A1 RID: 5281 RVA: 0x0006FD10 File Offset: 0x0006DF10
		public unsafe float4 wyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wyxx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x060014A2 RID: 5282 RVA: 0x0006FD40 File Offset: 0x0006DF40
		public unsafe float4 wyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wyxy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x060014A3 RID: 5283 RVA: 0x0006FD70 File Offset: 0x0006DF70
		// (set) Token: 0x060014A4 RID: 5284 RVA: 0x0006FDA0 File Offset: 0x0006DFA0
		public unsafe float4 wyxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wyxz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_wyxz_Public_set_Void_float4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x060014A5 RID: 5285 RVA: 0x0006FDD4 File Offset: 0x0006DFD4
		public unsafe float4 wyxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wyxw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x060014A6 RID: 5286 RVA: 0x0006FE04 File Offset: 0x0006E004
		public unsafe float4 wyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wyyx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x060014A7 RID: 5287 RVA: 0x0006FE34 File Offset: 0x0006E034
		public unsafe float4 wyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wyyy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x060014A8 RID: 5288 RVA: 0x0006FE64 File Offset: 0x0006E064
		public unsafe float4 wyyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wyyz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x060014A9 RID: 5289 RVA: 0x0006FE94 File Offset: 0x0006E094
		public unsafe float4 wyyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wyyw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x060014AA RID: 5290 RVA: 0x0006FEC4 File Offset: 0x0006E0C4
		// (set) Token: 0x060014AB RID: 5291 RVA: 0x0006FEF4 File Offset: 0x0006E0F4
		public unsafe float4 wyzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wyzx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_wyzx_Public_set_Void_float4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x060014AC RID: 5292 RVA: 0x0006FF28 File Offset: 0x0006E128
		public unsafe float4 wyzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wyzy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x060014AD RID: 5293 RVA: 0x0006FF58 File Offset: 0x0006E158
		public unsafe float4 wyzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wyzz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x060014AE RID: 5294 RVA: 0x0006FF88 File Offset: 0x0006E188
		public unsafe float4 wyzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wyzw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x060014AF RID: 5295 RVA: 0x0006FFB8 File Offset: 0x0006E1B8
		public unsafe float4 wywx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wywx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x060014B0 RID: 5296 RVA: 0x0006FFE8 File Offset: 0x0006E1E8
		public unsafe float4 wywy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wywy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x060014B1 RID: 5297 RVA: 0x00070018 File Offset: 0x0006E218
		public unsafe float4 wywz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wywz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x060014B2 RID: 5298 RVA: 0x00070048 File Offset: 0x0006E248
		public unsafe float4 wyww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wyww_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x060014B3 RID: 5299 RVA: 0x00070078 File Offset: 0x0006E278
		public unsafe float4 wzxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wzxx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x060014B4 RID: 5300 RVA: 0x000700A8 File Offset: 0x0006E2A8
		// (set) Token: 0x060014B5 RID: 5301 RVA: 0x000700D8 File Offset: 0x0006E2D8
		public unsafe float4 wzxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wzxy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_wzxy_Public_set_Void_float4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x060014B6 RID: 5302 RVA: 0x0007010C File Offset: 0x0006E30C
		public unsafe float4 wzxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wzxz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x060014B7 RID: 5303 RVA: 0x0007013C File Offset: 0x0006E33C
		public unsafe float4 wzxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wzxw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x060014B8 RID: 5304 RVA: 0x0007016C File Offset: 0x0006E36C
		// (set) Token: 0x060014B9 RID: 5305 RVA: 0x0007019C File Offset: 0x0006E39C
		public unsafe float4 wzyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wzyx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_wzyx_Public_set_Void_float4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x060014BA RID: 5306 RVA: 0x000701D0 File Offset: 0x0006E3D0
		public unsafe float4 wzyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wzyy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x060014BB RID: 5307 RVA: 0x00070200 File Offset: 0x0006E400
		public unsafe float4 wzyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wzyz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x060014BC RID: 5308 RVA: 0x00070230 File Offset: 0x0006E430
		public unsafe float4 wzyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wzyw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x060014BD RID: 5309 RVA: 0x00070260 File Offset: 0x0006E460
		public unsafe float4 wzzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wzzx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x060014BE RID: 5310 RVA: 0x00070290 File Offset: 0x0006E490
		public unsafe float4 wzzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wzzy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x060014BF RID: 5311 RVA: 0x000702C0 File Offset: 0x0006E4C0
		public unsafe float4 wzzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wzzz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x060014C0 RID: 5312 RVA: 0x000702F0 File Offset: 0x0006E4F0
		public unsafe float4 wzzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wzzw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x060014C1 RID: 5313 RVA: 0x00070320 File Offset: 0x0006E520
		public unsafe float4 wzwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wzwx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x060014C2 RID: 5314 RVA: 0x00070350 File Offset: 0x0006E550
		public unsafe float4 wzwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wzwy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x060014C3 RID: 5315 RVA: 0x00070380 File Offset: 0x0006E580
		public unsafe float4 wzwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wzwz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x060014C4 RID: 5316 RVA: 0x000703B0 File Offset: 0x0006E5B0
		public unsafe float4 wzww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wzww_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x060014C5 RID: 5317 RVA: 0x000703E0 File Offset: 0x0006E5E0
		public unsafe float4 wwxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wwxx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x060014C6 RID: 5318 RVA: 0x00070410 File Offset: 0x0006E610
		public unsafe float4 wwxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wwxy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x060014C7 RID: 5319 RVA: 0x00070440 File Offset: 0x0006E640
		public unsafe float4 wwxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wwxz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x060014C8 RID: 5320 RVA: 0x00070470 File Offset: 0x0006E670
		public unsafe float4 wwxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wwxw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x060014C9 RID: 5321 RVA: 0x000704A0 File Offset: 0x0006E6A0
		public unsafe float4 wwyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wwyx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x060014CA RID: 5322 RVA: 0x000704D0 File Offset: 0x0006E6D0
		public unsafe float4 wwyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wwyy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x060014CB RID: 5323 RVA: 0x00070500 File Offset: 0x0006E700
		public unsafe float4 wwyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wwyz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x060014CC RID: 5324 RVA: 0x00070530 File Offset: 0x0006E730
		public unsafe float4 wwyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wwyw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x060014CD RID: 5325 RVA: 0x00070560 File Offset: 0x0006E760
		public unsafe float4 wwzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wwzx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x060014CE RID: 5326 RVA: 0x00070590 File Offset: 0x0006E790
		public unsafe float4 wwzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wwzy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x060014CF RID: 5327 RVA: 0x000705C0 File Offset: 0x0006E7C0
		public unsafe float4 wwzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wwzz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x060014D0 RID: 5328 RVA: 0x000705F0 File Offset: 0x0006E7F0
		public unsafe float4 wwzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wwzw_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x060014D1 RID: 5329 RVA: 0x00070620 File Offset: 0x0006E820
		public unsafe float4 wwwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wwwx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x060014D2 RID: 5330 RVA: 0x00070650 File Offset: 0x0006E850
		public unsafe float4 wwwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wwwy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x060014D3 RID: 5331 RVA: 0x00070680 File Offset: 0x0006E880
		public unsafe float4 wwwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wwwz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x060014D4 RID: 5332 RVA: 0x000706B0 File Offset: 0x0006E8B0
		public unsafe float4 wwww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wwww_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x060014D5 RID: 5333 RVA: 0x000706E0 File Offset: 0x0006E8E0
		public unsafe float3 xxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xxx_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x060014D6 RID: 5334 RVA: 0x00070710 File Offset: 0x0006E910
		public unsafe float3 xxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xxy_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x060014D7 RID: 5335 RVA: 0x00070740 File Offset: 0x0006E940
		public unsafe float3 xxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xxz_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x060014D8 RID: 5336 RVA: 0x00070770 File Offset: 0x0006E970
		public unsafe float3 xxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xxw_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x060014D9 RID: 5337 RVA: 0x000707A0 File Offset: 0x0006E9A0
		public unsafe float3 xyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xyx_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x060014DA RID: 5338 RVA: 0x000707D0 File Offset: 0x0006E9D0
		public unsafe float3 xyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xyy_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x060014DB RID: 5339 RVA: 0x00070800 File Offset: 0x0006EA00
		// (set) Token: 0x060014DC RID: 5340 RVA: 0x00070830 File Offset: 0x0006EA30
		public unsafe float3 xyz
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 637161, RefRangeEnd = 637182, XrefRangeStart = 637161, XrefRangeEnd = 637182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xyz_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_xyz_Public_set_Void_float3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x060014DD RID: 5341 RVA: 0x00070864 File Offset: 0x0006EA64
		// (set) Token: 0x060014DE RID: 5342 RVA: 0x00070894 File Offset: 0x0006EA94
		public unsafe float3 xyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xyw_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_xyw_Public_set_Void_float3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x060014DF RID: 5343 RVA: 0x000708C8 File Offset: 0x0006EAC8
		public unsafe float3 xzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xzx_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x060014E0 RID: 5344 RVA: 0x000708F8 File Offset: 0x0006EAF8
		// (set) Token: 0x060014E1 RID: 5345 RVA: 0x00070928 File Offset: 0x0006EB28
		public unsafe float3 xzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xzy_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_xzy_Public_set_Void_float3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x060014E2 RID: 5346 RVA: 0x0007095C File Offset: 0x0006EB5C
		public unsafe float3 xzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xzz_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x060014E3 RID: 5347 RVA: 0x0007098C File Offset: 0x0006EB8C
		// (set) Token: 0x060014E4 RID: 5348 RVA: 0x000709BC File Offset: 0x0006EBBC
		public unsafe float3 xzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xzw_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_xzw_Public_set_Void_float3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x060014E5 RID: 5349 RVA: 0x000709F0 File Offset: 0x0006EBF0
		public unsafe float3 xwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xwx_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x060014E6 RID: 5350 RVA: 0x00070A20 File Offset: 0x0006EC20
		// (set) Token: 0x060014E7 RID: 5351 RVA: 0x00070A50 File Offset: 0x0006EC50
		public unsafe float3 xwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xwy_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_xwy_Public_set_Void_float3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x060014E8 RID: 5352 RVA: 0x00070A84 File Offset: 0x0006EC84
		// (set) Token: 0x060014E9 RID: 5353 RVA: 0x00070AB4 File Offset: 0x0006ECB4
		public unsafe float3 xwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xwz_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_xwz_Public_set_Void_float3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x060014EA RID: 5354 RVA: 0x00070AE8 File Offset: 0x0006ECE8
		public unsafe float3 xww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xww_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x060014EB RID: 5355 RVA: 0x00070B18 File Offset: 0x0006ED18
		public unsafe float3 yxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yxx_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x060014EC RID: 5356 RVA: 0x00070B48 File Offset: 0x0006ED48
		public unsafe float3 yxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yxy_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x060014ED RID: 5357 RVA: 0x00070B78 File Offset: 0x0006ED78
		// (set) Token: 0x060014EE RID: 5358 RVA: 0x00070BA8 File Offset: 0x0006EDA8
		public unsafe float3 yxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yxz_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_yxz_Public_set_Void_float3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x060014EF RID: 5359 RVA: 0x00070BDC File Offset: 0x0006EDDC
		// (set) Token: 0x060014F0 RID: 5360 RVA: 0x00070C0C File Offset: 0x0006EE0C
		public unsafe float3 yxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yxw_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_yxw_Public_set_Void_float3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x060014F1 RID: 5361 RVA: 0x00070C40 File Offset: 0x0006EE40
		public unsafe float3 yyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yyx_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x060014F2 RID: 5362 RVA: 0x00070C70 File Offset: 0x0006EE70
		public unsafe float3 yyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yyy_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x060014F3 RID: 5363 RVA: 0x00070CA0 File Offset: 0x0006EEA0
		public unsafe float3 yyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yyz_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x060014F4 RID: 5364 RVA: 0x00070CD0 File Offset: 0x0006EED0
		public unsafe float3 yyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yyw_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x060014F5 RID: 5365 RVA: 0x00070D00 File Offset: 0x0006EF00
		// (set) Token: 0x060014F6 RID: 5366 RVA: 0x00070D30 File Offset: 0x0006EF30
		public unsafe float3 yzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yzx_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_yzx_Public_set_Void_float3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x060014F7 RID: 5367 RVA: 0x00070D64 File Offset: 0x0006EF64
		public unsafe float3 yzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yzy_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x060014F8 RID: 5368 RVA: 0x00070D94 File Offset: 0x0006EF94
		public unsafe float3 yzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yzz_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x060014F9 RID: 5369 RVA: 0x00070DC4 File Offset: 0x0006EFC4
		// (set) Token: 0x060014FA RID: 5370 RVA: 0x00070DF4 File Offset: 0x0006EFF4
		public unsafe float3 yzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yzw_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_yzw_Public_set_Void_float3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x060014FB RID: 5371 RVA: 0x00070E28 File Offset: 0x0006F028
		// (set) Token: 0x060014FC RID: 5372 RVA: 0x00070E58 File Offset: 0x0006F058
		public unsafe float3 ywx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_ywx_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_ywx_Public_set_Void_float3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x060014FD RID: 5373 RVA: 0x00070E8C File Offset: 0x0006F08C
		public unsafe float3 ywy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_ywy_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x060014FE RID: 5374 RVA: 0x00070EBC File Offset: 0x0006F0BC
		// (set) Token: 0x060014FF RID: 5375 RVA: 0x00070EEC File Offset: 0x0006F0EC
		public unsafe float3 ywz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_ywz_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_ywz_Public_set_Void_float3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06001500 RID: 5376 RVA: 0x00070F20 File Offset: 0x0006F120
		public unsafe float3 yww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yww_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06001501 RID: 5377 RVA: 0x00070F50 File Offset: 0x0006F150
		public unsafe float3 zxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zxx_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06001502 RID: 5378 RVA: 0x00070F80 File Offset: 0x0006F180
		// (set) Token: 0x06001503 RID: 5379 RVA: 0x00070FB0 File Offset: 0x0006F1B0
		public unsafe float3 zxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zxy_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_zxy_Public_set_Void_float3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06001504 RID: 5380 RVA: 0x00070FE4 File Offset: 0x0006F1E4
		public unsafe float3 zxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zxz_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06001505 RID: 5381 RVA: 0x00071014 File Offset: 0x0006F214
		// (set) Token: 0x06001506 RID: 5382 RVA: 0x00071044 File Offset: 0x0006F244
		public unsafe float3 zxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zxw_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_zxw_Public_set_Void_float3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06001507 RID: 5383 RVA: 0x00071078 File Offset: 0x0006F278
		// (set) Token: 0x06001508 RID: 5384 RVA: 0x000710A8 File Offset: 0x0006F2A8
		public unsafe float3 zyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zyx_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_zyx_Public_set_Void_float3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06001509 RID: 5385 RVA: 0x000710DC File Offset: 0x0006F2DC
		public unsafe float3 zyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zyy_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x0600150A RID: 5386 RVA: 0x0007110C File Offset: 0x0006F30C
		public unsafe float3 zyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zyz_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x0600150B RID: 5387 RVA: 0x0007113C File Offset: 0x0006F33C
		// (set) Token: 0x0600150C RID: 5388 RVA: 0x0007116C File Offset: 0x0006F36C
		public unsafe float3 zyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zyw_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_zyw_Public_set_Void_float3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x0600150D RID: 5389 RVA: 0x000711A0 File Offset: 0x0006F3A0
		public unsafe float3 zzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zzx_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x0600150E RID: 5390 RVA: 0x000711D0 File Offset: 0x0006F3D0
		public unsafe float3 zzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zzy_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x0600150F RID: 5391 RVA: 0x00071200 File Offset: 0x0006F400
		public unsafe float3 zzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zzz_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06001510 RID: 5392 RVA: 0x00071230 File Offset: 0x0006F430
		public unsafe float3 zzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zzw_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06001511 RID: 5393 RVA: 0x00071260 File Offset: 0x0006F460
		// (set) Token: 0x06001512 RID: 5394 RVA: 0x00071290 File Offset: 0x0006F490
		public unsafe float3 zwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zwx_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_zwx_Public_set_Void_float3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06001513 RID: 5395 RVA: 0x000712C4 File Offset: 0x0006F4C4
		// (set) Token: 0x06001514 RID: 5396 RVA: 0x000712F4 File Offset: 0x0006F4F4
		public unsafe float3 zwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zwy_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_zwy_Public_set_Void_float3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06001515 RID: 5397 RVA: 0x00071328 File Offset: 0x0006F528
		public unsafe float3 zwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zwz_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06001516 RID: 5398 RVA: 0x00071358 File Offset: 0x0006F558
		public unsafe float3 zww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zww_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06001517 RID: 5399 RVA: 0x00071388 File Offset: 0x0006F588
		public unsafe float3 wxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wxx_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06001518 RID: 5400 RVA: 0x000713B8 File Offset: 0x0006F5B8
		// (set) Token: 0x06001519 RID: 5401 RVA: 0x000713E8 File Offset: 0x0006F5E8
		public unsafe float3 wxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wxy_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_wxy_Public_set_Void_float3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x0600151A RID: 5402 RVA: 0x0007141C File Offset: 0x0006F61C
		// (set) Token: 0x0600151B RID: 5403 RVA: 0x0007144C File Offset: 0x0006F64C
		public unsafe float3 wxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wxz_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_wxz_Public_set_Void_float3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x0600151C RID: 5404 RVA: 0x00071480 File Offset: 0x0006F680
		public unsafe float3 wxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wxw_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x0600151D RID: 5405 RVA: 0x000714B0 File Offset: 0x0006F6B0
		// (set) Token: 0x0600151E RID: 5406 RVA: 0x000714E0 File Offset: 0x0006F6E0
		public unsafe float3 wyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wyx_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_wyx_Public_set_Void_float3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x0600151F RID: 5407 RVA: 0x00071514 File Offset: 0x0006F714
		public unsafe float3 wyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wyy_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06001520 RID: 5408 RVA: 0x00071544 File Offset: 0x0006F744
		// (set) Token: 0x06001521 RID: 5409 RVA: 0x00071574 File Offset: 0x0006F774
		public unsafe float3 wyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wyz_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_wyz_Public_set_Void_float3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06001522 RID: 5410 RVA: 0x000715A8 File Offset: 0x0006F7A8
		public unsafe float3 wyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wyw_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06001523 RID: 5411 RVA: 0x000715D8 File Offset: 0x0006F7D8
		// (set) Token: 0x06001524 RID: 5412 RVA: 0x00071608 File Offset: 0x0006F808
		public unsafe float3 wzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wzx_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_wzx_Public_set_Void_float3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06001525 RID: 5413 RVA: 0x0007163C File Offset: 0x0006F83C
		// (set) Token: 0x06001526 RID: 5414 RVA: 0x0007166C File Offset: 0x0006F86C
		public unsafe float3 wzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wzy_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_wzy_Public_set_Void_float3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06001527 RID: 5415 RVA: 0x000716A0 File Offset: 0x0006F8A0
		public unsafe float3 wzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wzz_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06001528 RID: 5416 RVA: 0x000716D0 File Offset: 0x0006F8D0
		public unsafe float3 wzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wzw_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06001529 RID: 5417 RVA: 0x00071700 File Offset: 0x0006F900
		public unsafe float3 wwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wwx_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x0600152A RID: 5418 RVA: 0x00071730 File Offset: 0x0006F930
		public unsafe float3 wwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wwy_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x0600152B RID: 5419 RVA: 0x00071760 File Offset: 0x0006F960
		public unsafe float3 wwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wwz_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x0600152C RID: 5420 RVA: 0x00071790 File Offset: 0x0006F990
		public unsafe float3 www
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_www_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x0600152D RID: 5421 RVA: 0x000717C0 File Offset: 0x0006F9C0
		public unsafe float2 xx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xx_Public_get_float2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x0600152E RID: 5422 RVA: 0x000717F0 File Offset: 0x0006F9F0
		// (set) Token: 0x0600152F RID: 5423 RVA: 0x00071820 File Offset: 0x0006FA20
		public unsafe float2 xy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xy_Public_get_float2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_xy_Public_set_Void_float2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06001530 RID: 5424 RVA: 0x00071854 File Offset: 0x0006FA54
		// (set) Token: 0x06001531 RID: 5425 RVA: 0x00071884 File Offset: 0x0006FA84
		public unsafe float2 xz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xz_Public_get_float2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_xz_Public_set_Void_float2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06001532 RID: 5426 RVA: 0x000718B8 File Offset: 0x0006FAB8
		// (set) Token: 0x06001533 RID: 5427 RVA: 0x000718E8 File Offset: 0x0006FAE8
		public unsafe float2 xw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_xw_Public_get_float2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_xw_Public_set_Void_float2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06001534 RID: 5428 RVA: 0x0007191C File Offset: 0x0006FB1C
		// (set) Token: 0x06001535 RID: 5429 RVA: 0x0007194C File Offset: 0x0006FB4C
		public unsafe float2 yx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yx_Public_get_float2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_yx_Public_set_Void_float2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06001536 RID: 5430 RVA: 0x00071980 File Offset: 0x0006FB80
		public unsafe float2 yy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yy_Public_get_float2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06001537 RID: 5431 RVA: 0x000719B0 File Offset: 0x0006FBB0
		// (set) Token: 0x06001538 RID: 5432 RVA: 0x000719E0 File Offset: 0x0006FBE0
		public unsafe float2 yz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yz_Public_get_float2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_yz_Public_set_Void_float2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06001539 RID: 5433 RVA: 0x00071A14 File Offset: 0x0006FC14
		// (set) Token: 0x0600153A RID: 5434 RVA: 0x00071A44 File Offset: 0x0006FC44
		public unsafe float2 yw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_yw_Public_get_float2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_yw_Public_set_Void_float2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x0600153B RID: 5435 RVA: 0x00071A78 File Offset: 0x0006FC78
		// (set) Token: 0x0600153C RID: 5436 RVA: 0x00071AA8 File Offset: 0x0006FCA8
		public unsafe float2 zx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zx_Public_get_float2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_zx_Public_set_Void_float2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x0600153D RID: 5437 RVA: 0x00071ADC File Offset: 0x0006FCDC
		// (set) Token: 0x0600153E RID: 5438 RVA: 0x00071B0C File Offset: 0x0006FD0C
		public unsafe float2 zy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zy_Public_get_float2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_zy_Public_set_Void_float2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x0600153F RID: 5439 RVA: 0x00071B40 File Offset: 0x0006FD40
		public unsafe float2 zz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zz_Public_get_float2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06001540 RID: 5440 RVA: 0x00071B70 File Offset: 0x0006FD70
		// (set) Token: 0x06001541 RID: 5441 RVA: 0x00071BA0 File Offset: 0x0006FDA0
		public unsafe float2 zw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_zw_Public_get_float2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_zw_Public_set_Void_float2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06001542 RID: 5442 RVA: 0x00071BD4 File Offset: 0x0006FDD4
		// (set) Token: 0x06001543 RID: 5443 RVA: 0x00071C04 File Offset: 0x0006FE04
		public unsafe float2 wx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wx_Public_get_float2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_wx_Public_set_Void_float2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06001544 RID: 5444 RVA: 0x00071C38 File Offset: 0x0006FE38
		// (set) Token: 0x06001545 RID: 5445 RVA: 0x00071C68 File Offset: 0x0006FE68
		public unsafe float2 wy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wy_Public_get_float2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_wy_Public_set_Void_float2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06001546 RID: 5446 RVA: 0x00071C9C File Offset: 0x0006FE9C
		// (set) Token: 0x06001547 RID: 5447 RVA: 0x00071CCC File Offset: 0x0006FECC
		public unsafe float2 wz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_wz_Public_get_float2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_wz_Public_set_Void_float2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06001548 RID: 5448 RVA: 0x00071D00 File Offset: 0x0006FF00
		public unsafe float2 ww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_ww_Public_get_float2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005F4 RID: 1524
		public unsafe float this[int index]
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 611804, RefRangeEnd = 611820, XrefRangeStart = 611804, XrefRangeEnd = 611820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0, ref this, (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600154B RID: 5451 RVA: 0x00071DB0 File Offset: 0x0006FFB0
		[CallerCount(0)]
		public unsafe bool Equals(float4 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600154C RID: 5452 RVA: 0x00071DF0 File Offset: 0x0006FFF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638006, XrefRangeEnd = 638009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(global::Il2CppSystem.Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600154D RID: 5453 RVA: 0x00071E34 File Offset: 0x00070034
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600154E RID: 5454 RVA: 0x00071E64 File Offset: 0x00070064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638009, XrefRangeEnd = 638032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x00071E90 File Offset: 0x00070090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638032, XrefRangeEnd = 638060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001550 RID: 5456 RVA: 0x00071EE0 File Offset: 0x000700E0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 637974, RefRangeEnd = 637984, XrefRangeStart = 637974, XrefRangeEnd = 637984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator float4(Vector4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_Implicit_Public_Static_float4_Vector4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x00071F20 File Offset: 0x00070120
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 637974, RefRangeEnd = 637984, XrefRangeStart = 637974, XrefRangeEnd = 637984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Vector4(float4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_float4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x00002576 File Offset: 0x00000776
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<float4>.NativeClassPtr, ref this));
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06001553 RID: 5459 RVA: 0x00071F60 File Offset: 0x00070160
		// (set) Token: 0x06001554 RID: 5460 RVA: 0x00002588 File Offset: 0x00000788
		public unsafe static float4 zero
		{
			get
			{
				float4 @float;
				IL2CPP.il2cpp_field_static_get_value(float4.NativeFieldInfoPtr_zero, (void*)(&@float));
				return @float;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(float4.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x040013C2 RID: 5058
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x040013C3 RID: 5059
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x040013C4 RID: 5060
		private static readonly IntPtr NativeFieldInfoPtr_z;

		// Token: 0x040013C5 RID: 5061
		private static readonly IntPtr NativeFieldInfoPtr_w;

		// Token: 0x040013C6 RID: 5062
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x040013C7 RID: 5063
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;

		// Token: 0x040013C8 RID: 5064
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_float2_0;

		// Token: 0x040013C9 RID: 5065
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_float2_Single_0;

		// Token: 0x040013CA RID: 5066
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_float3_0;

		// Token: 0x040013CB RID: 5067
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float2_Single_Single_0;

		// Token: 0x040013CC RID: 5068
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float2_float2_0;

		// Token: 0x040013CD RID: 5069
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float3_Single_0;

		// Token: 0x040013CE RID: 5070
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float4_0;

		// Token: 0x040013CF RID: 5071
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x040013D0 RID: 5072
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x040013D1 RID: 5073
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool4_0;

		// Token: 0x040013D2 RID: 5074
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040013D3 RID: 5075
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int4_0;

		// Token: 0x040013D4 RID: 5076
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x040013D5 RID: 5077
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint4_0;

		// Token: 0x040013D6 RID: 5078
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_half_0;

		// Token: 0x040013D7 RID: 5079
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_half4_0;

		// Token: 0x040013D8 RID: 5080
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x040013D9 RID: 5081
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double4_0;

		// Token: 0x040013DA RID: 5082
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float4_Single_0;

		// Token: 0x040013DB RID: 5083
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_float4_Boolean_0;

		// Token: 0x040013DC RID: 5084
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_float4_bool4_0;

		// Token: 0x040013DD RID: 5085
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float4_Int32_0;

		// Token: 0x040013DE RID: 5086
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float4_int4_0;

		// Token: 0x040013DF RID: 5087
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float4_UInt32_0;

		// Token: 0x040013E0 RID: 5088
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float4_uint4_0;

		// Token: 0x040013E1 RID: 5089
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float4_half_0;

		// Token: 0x040013E2 RID: 5090
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float4_half4_0;

		// Token: 0x040013E3 RID: 5091
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_float4_Double_0;

		// Token: 0x040013E4 RID: 5092
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_float4_double4_0;

		// Token: 0x040013E5 RID: 5093
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_float4_float4_float4_0;

		// Token: 0x040013E6 RID: 5094
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_float4_float4_Single_0;

		// Token: 0x040013E7 RID: 5095
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_float4_Single_float4_0;

		// Token: 0x040013E8 RID: 5096
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_float4_float4_float4_0;

		// Token: 0x040013E9 RID: 5097
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_float4_float4_Single_0;

		// Token: 0x040013EA RID: 5098
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_float4_Single_float4_0;

		// Token: 0x040013EB RID: 5099
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_float4_float4_float4_0;

		// Token: 0x040013EC RID: 5100
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_float4_float4_Single_0;

		// Token: 0x040013ED RID: 5101
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_float4_Single_float4_0;

		// Token: 0x040013EE RID: 5102
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_float4_float4_float4_0;

		// Token: 0x040013EF RID: 5103
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_float4_float4_Single_0;

		// Token: 0x040013F0 RID: 5104
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_float4_Single_float4_0;

		// Token: 0x040013F1 RID: 5105
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_float4_float4_float4_0;

		// Token: 0x040013F2 RID: 5106
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_float4_float4_Single_0;

		// Token: 0x040013F3 RID: 5107
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_float4_Single_float4_0;

		// Token: 0x040013F4 RID: 5108
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_float4_float4_0;

		// Token: 0x040013F5 RID: 5109
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_float4_float4_0;

		// Token: 0x040013F6 RID: 5110
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool4_float4_float4_0;

		// Token: 0x040013F7 RID: 5111
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool4_float4_Single_0;

		// Token: 0x040013F8 RID: 5112
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool4_Single_float4_0;

		// Token: 0x040013F9 RID: 5113
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4_float4_float4_0;

		// Token: 0x040013FA RID: 5114
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4_float4_Single_0;

		// Token: 0x040013FB RID: 5115
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4_Single_float4_0;

		// Token: 0x040013FC RID: 5116
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4_float4_float4_0;

		// Token: 0x040013FD RID: 5117
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4_float4_Single_0;

		// Token: 0x040013FE RID: 5118
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4_Single_float4_0;

		// Token: 0x040013FF RID: 5119
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4_float4_float4_0;

		// Token: 0x04001400 RID: 5120
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4_float4_Single_0;

		// Token: 0x04001401 RID: 5121
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4_Single_float4_0;

		// Token: 0x04001402 RID: 5122
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_float4_float4_0;

		// Token: 0x04001403 RID: 5123
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryPlus_Public_Static_float4_float4_0;

		// Token: 0x04001404 RID: 5124
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4_float4_float4_0;

		// Token: 0x04001405 RID: 5125
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4_float4_Single_0;

		// Token: 0x04001406 RID: 5126
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4_Single_float4_0;

		// Token: 0x04001407 RID: 5127
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_float4_float4_0;

		// Token: 0x04001408 RID: 5128
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_float4_Single_0;

		// Token: 0x04001409 RID: 5129
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_Single_float4_0;

		// Token: 0x0400140A RID: 5130
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxx_Public_get_float4_0;

		// Token: 0x0400140B RID: 5131
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxy_Public_get_float4_0;

		// Token: 0x0400140C RID: 5132
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxz_Public_get_float4_0;

		// Token: 0x0400140D RID: 5133
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxw_Public_get_float4_0;

		// Token: 0x0400140E RID: 5134
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyx_Public_get_float4_0;

		// Token: 0x0400140F RID: 5135
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyy_Public_get_float4_0;

		// Token: 0x04001410 RID: 5136
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyz_Public_get_float4_0;

		// Token: 0x04001411 RID: 5137
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyw_Public_get_float4_0;

		// Token: 0x04001412 RID: 5138
		private static readonly IntPtr NativeMethodInfoPtr_get_xxzx_Public_get_float4_0;

		// Token: 0x04001413 RID: 5139
		private static readonly IntPtr NativeMethodInfoPtr_get_xxzy_Public_get_float4_0;

		// Token: 0x04001414 RID: 5140
		private static readonly IntPtr NativeMethodInfoPtr_get_xxzz_Public_get_float4_0;

		// Token: 0x04001415 RID: 5141
		private static readonly IntPtr NativeMethodInfoPtr_get_xxzw_Public_get_float4_0;

		// Token: 0x04001416 RID: 5142
		private static readonly IntPtr NativeMethodInfoPtr_get_xxwx_Public_get_float4_0;

		// Token: 0x04001417 RID: 5143
		private static readonly IntPtr NativeMethodInfoPtr_get_xxwy_Public_get_float4_0;

		// Token: 0x04001418 RID: 5144
		private static readonly IntPtr NativeMethodInfoPtr_get_xxwz_Public_get_float4_0;

		// Token: 0x04001419 RID: 5145
		private static readonly IntPtr NativeMethodInfoPtr_get_xxww_Public_get_float4_0;

		// Token: 0x0400141A RID: 5146
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxx_Public_get_float4_0;

		// Token: 0x0400141B RID: 5147
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxy_Public_get_float4_0;

		// Token: 0x0400141C RID: 5148
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxz_Public_get_float4_0;

		// Token: 0x0400141D RID: 5149
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxw_Public_get_float4_0;

		// Token: 0x0400141E RID: 5150
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyx_Public_get_float4_0;

		// Token: 0x0400141F RID: 5151
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyy_Public_get_float4_0;

		// Token: 0x04001420 RID: 5152
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyz_Public_get_float4_0;

		// Token: 0x04001421 RID: 5153
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyw_Public_get_float4_0;

		// Token: 0x04001422 RID: 5154
		private static readonly IntPtr NativeMethodInfoPtr_get_xyzx_Public_get_float4_0;

		// Token: 0x04001423 RID: 5155
		private static readonly IntPtr NativeMethodInfoPtr_get_xyzy_Public_get_float4_0;

		// Token: 0x04001424 RID: 5156
		private static readonly IntPtr NativeMethodInfoPtr_get_xyzz_Public_get_float4_0;

		// Token: 0x04001425 RID: 5157
		private static readonly IntPtr NativeMethodInfoPtr_get_xyzw_Public_get_float4_0;

		// Token: 0x04001426 RID: 5158
		private static readonly IntPtr NativeMethodInfoPtr_set_xyzw_Public_set_Void_float4_0;

		// Token: 0x04001427 RID: 5159
		private static readonly IntPtr NativeMethodInfoPtr_get_xywx_Public_get_float4_0;

		// Token: 0x04001428 RID: 5160
		private static readonly IntPtr NativeMethodInfoPtr_get_xywy_Public_get_float4_0;

		// Token: 0x04001429 RID: 5161
		private static readonly IntPtr NativeMethodInfoPtr_get_xywz_Public_get_float4_0;

		// Token: 0x0400142A RID: 5162
		private static readonly IntPtr NativeMethodInfoPtr_set_xywz_Public_set_Void_float4_0;

		// Token: 0x0400142B RID: 5163
		private static readonly IntPtr NativeMethodInfoPtr_get_xyww_Public_get_float4_0;

		// Token: 0x0400142C RID: 5164
		private static readonly IntPtr NativeMethodInfoPtr_get_xzxx_Public_get_float4_0;

		// Token: 0x0400142D RID: 5165
		private static readonly IntPtr NativeMethodInfoPtr_get_xzxy_Public_get_float4_0;

		// Token: 0x0400142E RID: 5166
		private static readonly IntPtr NativeMethodInfoPtr_get_xzxz_Public_get_float4_0;

		// Token: 0x0400142F RID: 5167
		private static readonly IntPtr NativeMethodInfoPtr_get_xzxw_Public_get_float4_0;

		// Token: 0x04001430 RID: 5168
		private static readonly IntPtr NativeMethodInfoPtr_get_xzyx_Public_get_float4_0;

		// Token: 0x04001431 RID: 5169
		private static readonly IntPtr NativeMethodInfoPtr_get_xzyy_Public_get_float4_0;

		// Token: 0x04001432 RID: 5170
		private static readonly IntPtr NativeMethodInfoPtr_get_xzyz_Public_get_float4_0;

		// Token: 0x04001433 RID: 5171
		private static readonly IntPtr NativeMethodInfoPtr_get_xzyw_Public_get_float4_0;

		// Token: 0x04001434 RID: 5172
		private static readonly IntPtr NativeMethodInfoPtr_set_xzyw_Public_set_Void_float4_0;

		// Token: 0x04001435 RID: 5173
		private static readonly IntPtr NativeMethodInfoPtr_get_xzzx_Public_get_float4_0;

		// Token: 0x04001436 RID: 5174
		private static readonly IntPtr NativeMethodInfoPtr_get_xzzy_Public_get_float4_0;

		// Token: 0x04001437 RID: 5175
		private static readonly IntPtr NativeMethodInfoPtr_get_xzzz_Public_get_float4_0;

		// Token: 0x04001438 RID: 5176
		private static readonly IntPtr NativeMethodInfoPtr_get_xzzw_Public_get_float4_0;

		// Token: 0x04001439 RID: 5177
		private static readonly IntPtr NativeMethodInfoPtr_get_xzwx_Public_get_float4_0;

		// Token: 0x0400143A RID: 5178
		private static readonly IntPtr NativeMethodInfoPtr_get_xzwy_Public_get_float4_0;

		// Token: 0x0400143B RID: 5179
		private static readonly IntPtr NativeMethodInfoPtr_set_xzwy_Public_set_Void_float4_0;

		// Token: 0x0400143C RID: 5180
		private static readonly IntPtr NativeMethodInfoPtr_get_xzwz_Public_get_float4_0;

		// Token: 0x0400143D RID: 5181
		private static readonly IntPtr NativeMethodInfoPtr_get_xzww_Public_get_float4_0;

		// Token: 0x0400143E RID: 5182
		private static readonly IntPtr NativeMethodInfoPtr_get_xwxx_Public_get_float4_0;

		// Token: 0x0400143F RID: 5183
		private static readonly IntPtr NativeMethodInfoPtr_get_xwxy_Public_get_float4_0;

		// Token: 0x04001440 RID: 5184
		private static readonly IntPtr NativeMethodInfoPtr_get_xwxz_Public_get_float4_0;

		// Token: 0x04001441 RID: 5185
		private static readonly IntPtr NativeMethodInfoPtr_get_xwxw_Public_get_float4_0;

		// Token: 0x04001442 RID: 5186
		private static readonly IntPtr NativeMethodInfoPtr_get_xwyx_Public_get_float4_0;

		// Token: 0x04001443 RID: 5187
		private static readonly IntPtr NativeMethodInfoPtr_get_xwyy_Public_get_float4_0;

		// Token: 0x04001444 RID: 5188
		private static readonly IntPtr NativeMethodInfoPtr_get_xwyz_Public_get_float4_0;

		// Token: 0x04001445 RID: 5189
		private static readonly IntPtr NativeMethodInfoPtr_set_xwyz_Public_set_Void_float4_0;

		// Token: 0x04001446 RID: 5190
		private static readonly IntPtr NativeMethodInfoPtr_get_xwyw_Public_get_float4_0;

		// Token: 0x04001447 RID: 5191
		private static readonly IntPtr NativeMethodInfoPtr_get_xwzx_Public_get_float4_0;

		// Token: 0x04001448 RID: 5192
		private static readonly IntPtr NativeMethodInfoPtr_get_xwzy_Public_get_float4_0;

		// Token: 0x04001449 RID: 5193
		private static readonly IntPtr NativeMethodInfoPtr_set_xwzy_Public_set_Void_float4_0;

		// Token: 0x0400144A RID: 5194
		private static readonly IntPtr NativeMethodInfoPtr_get_xwzz_Public_get_float4_0;

		// Token: 0x0400144B RID: 5195
		private static readonly IntPtr NativeMethodInfoPtr_get_xwzw_Public_get_float4_0;

		// Token: 0x0400144C RID: 5196
		private static readonly IntPtr NativeMethodInfoPtr_get_xwwx_Public_get_float4_0;

		// Token: 0x0400144D RID: 5197
		private static readonly IntPtr NativeMethodInfoPtr_get_xwwy_Public_get_float4_0;

		// Token: 0x0400144E RID: 5198
		private static readonly IntPtr NativeMethodInfoPtr_get_xwwz_Public_get_float4_0;

		// Token: 0x0400144F RID: 5199
		private static readonly IntPtr NativeMethodInfoPtr_get_xwww_Public_get_float4_0;

		// Token: 0x04001450 RID: 5200
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxx_Public_get_float4_0;

		// Token: 0x04001451 RID: 5201
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxy_Public_get_float4_0;

		// Token: 0x04001452 RID: 5202
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxz_Public_get_float4_0;

		// Token: 0x04001453 RID: 5203
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxw_Public_get_float4_0;

		// Token: 0x04001454 RID: 5204
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyx_Public_get_float4_0;

		// Token: 0x04001455 RID: 5205
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyy_Public_get_float4_0;

		// Token: 0x04001456 RID: 5206
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyz_Public_get_float4_0;

		// Token: 0x04001457 RID: 5207
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyw_Public_get_float4_0;

		// Token: 0x04001458 RID: 5208
		private static readonly IntPtr NativeMethodInfoPtr_get_yxzx_Public_get_float4_0;

		// Token: 0x04001459 RID: 5209
		private static readonly IntPtr NativeMethodInfoPtr_get_yxzy_Public_get_float4_0;

		// Token: 0x0400145A RID: 5210
		private static readonly IntPtr NativeMethodInfoPtr_get_yxzz_Public_get_float4_0;

		// Token: 0x0400145B RID: 5211
		private static readonly IntPtr NativeMethodInfoPtr_get_yxzw_Public_get_float4_0;

		// Token: 0x0400145C RID: 5212
		private static readonly IntPtr NativeMethodInfoPtr_set_yxzw_Public_set_Void_float4_0;

		// Token: 0x0400145D RID: 5213
		private static readonly IntPtr NativeMethodInfoPtr_get_yxwx_Public_get_float4_0;

		// Token: 0x0400145E RID: 5214
		private static readonly IntPtr NativeMethodInfoPtr_get_yxwy_Public_get_float4_0;

		// Token: 0x0400145F RID: 5215
		private static readonly IntPtr NativeMethodInfoPtr_get_yxwz_Public_get_float4_0;

		// Token: 0x04001460 RID: 5216
		private static readonly IntPtr NativeMethodInfoPtr_set_yxwz_Public_set_Void_float4_0;

		// Token: 0x04001461 RID: 5217
		private static readonly IntPtr NativeMethodInfoPtr_get_yxww_Public_get_float4_0;

		// Token: 0x04001462 RID: 5218
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxx_Public_get_float4_0;

		// Token: 0x04001463 RID: 5219
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxy_Public_get_float4_0;

		// Token: 0x04001464 RID: 5220
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxz_Public_get_float4_0;

		// Token: 0x04001465 RID: 5221
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxw_Public_get_float4_0;

		// Token: 0x04001466 RID: 5222
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyx_Public_get_float4_0;

		// Token: 0x04001467 RID: 5223
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyy_Public_get_float4_0;

		// Token: 0x04001468 RID: 5224
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyz_Public_get_float4_0;

		// Token: 0x04001469 RID: 5225
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyw_Public_get_float4_0;

		// Token: 0x0400146A RID: 5226
		private static readonly IntPtr NativeMethodInfoPtr_get_yyzx_Public_get_float4_0;

		// Token: 0x0400146B RID: 5227
		private static readonly IntPtr NativeMethodInfoPtr_get_yyzy_Public_get_float4_0;

		// Token: 0x0400146C RID: 5228
		private static readonly IntPtr NativeMethodInfoPtr_get_yyzz_Public_get_float4_0;

		// Token: 0x0400146D RID: 5229
		private static readonly IntPtr NativeMethodInfoPtr_get_yyzw_Public_get_float4_0;

		// Token: 0x0400146E RID: 5230
		private static readonly IntPtr NativeMethodInfoPtr_get_yywx_Public_get_float4_0;

		// Token: 0x0400146F RID: 5231
		private static readonly IntPtr NativeMethodInfoPtr_get_yywy_Public_get_float4_0;

		// Token: 0x04001470 RID: 5232
		private static readonly IntPtr NativeMethodInfoPtr_get_yywz_Public_get_float4_0;

		// Token: 0x04001471 RID: 5233
		private static readonly IntPtr NativeMethodInfoPtr_get_yyww_Public_get_float4_0;

		// Token: 0x04001472 RID: 5234
		private static readonly IntPtr NativeMethodInfoPtr_get_yzxx_Public_get_float4_0;

		// Token: 0x04001473 RID: 5235
		private static readonly IntPtr NativeMethodInfoPtr_get_yzxy_Public_get_float4_0;

		// Token: 0x04001474 RID: 5236
		private static readonly IntPtr NativeMethodInfoPtr_get_yzxz_Public_get_float4_0;

		// Token: 0x04001475 RID: 5237
		private static readonly IntPtr NativeMethodInfoPtr_get_yzxw_Public_get_float4_0;

		// Token: 0x04001476 RID: 5238
		private static readonly IntPtr NativeMethodInfoPtr_set_yzxw_Public_set_Void_float4_0;

		// Token: 0x04001477 RID: 5239
		private static readonly IntPtr NativeMethodInfoPtr_get_yzyx_Public_get_float4_0;

		// Token: 0x04001478 RID: 5240
		private static readonly IntPtr NativeMethodInfoPtr_get_yzyy_Public_get_float4_0;

		// Token: 0x04001479 RID: 5241
		private static readonly IntPtr NativeMethodInfoPtr_get_yzyz_Public_get_float4_0;

		// Token: 0x0400147A RID: 5242
		private static readonly IntPtr NativeMethodInfoPtr_get_yzyw_Public_get_float4_0;

		// Token: 0x0400147B RID: 5243
		private static readonly IntPtr NativeMethodInfoPtr_get_yzzx_Public_get_float4_0;

		// Token: 0x0400147C RID: 5244
		private static readonly IntPtr NativeMethodInfoPtr_get_yzzy_Public_get_float4_0;

		// Token: 0x0400147D RID: 5245
		private static readonly IntPtr NativeMethodInfoPtr_get_yzzz_Public_get_float4_0;

		// Token: 0x0400147E RID: 5246
		private static readonly IntPtr NativeMethodInfoPtr_get_yzzw_Public_get_float4_0;

		// Token: 0x0400147F RID: 5247
		private static readonly IntPtr NativeMethodInfoPtr_get_yzwx_Public_get_float4_0;

		// Token: 0x04001480 RID: 5248
		private static readonly IntPtr NativeMethodInfoPtr_set_yzwx_Public_set_Void_float4_0;

		// Token: 0x04001481 RID: 5249
		private static readonly IntPtr NativeMethodInfoPtr_get_yzwy_Public_get_float4_0;

		// Token: 0x04001482 RID: 5250
		private static readonly IntPtr NativeMethodInfoPtr_get_yzwz_Public_get_float4_0;

		// Token: 0x04001483 RID: 5251
		private static readonly IntPtr NativeMethodInfoPtr_get_yzww_Public_get_float4_0;

		// Token: 0x04001484 RID: 5252
		private static readonly IntPtr NativeMethodInfoPtr_get_ywxx_Public_get_float4_0;

		// Token: 0x04001485 RID: 5253
		private static readonly IntPtr NativeMethodInfoPtr_get_ywxy_Public_get_float4_0;

		// Token: 0x04001486 RID: 5254
		private static readonly IntPtr NativeMethodInfoPtr_get_ywxz_Public_get_float4_0;

		// Token: 0x04001487 RID: 5255
		private static readonly IntPtr NativeMethodInfoPtr_set_ywxz_Public_set_Void_float4_0;

		// Token: 0x04001488 RID: 5256
		private static readonly IntPtr NativeMethodInfoPtr_get_ywxw_Public_get_float4_0;

		// Token: 0x04001489 RID: 5257
		private static readonly IntPtr NativeMethodInfoPtr_get_ywyx_Public_get_float4_0;

		// Token: 0x0400148A RID: 5258
		private static readonly IntPtr NativeMethodInfoPtr_get_ywyy_Public_get_float4_0;

		// Token: 0x0400148B RID: 5259
		private static readonly IntPtr NativeMethodInfoPtr_get_ywyz_Public_get_float4_0;

		// Token: 0x0400148C RID: 5260
		private static readonly IntPtr NativeMethodInfoPtr_get_ywyw_Public_get_float4_0;

		// Token: 0x0400148D RID: 5261
		private static readonly IntPtr NativeMethodInfoPtr_get_ywzx_Public_get_float4_0;

		// Token: 0x0400148E RID: 5262
		private static readonly IntPtr NativeMethodInfoPtr_set_ywzx_Public_set_Void_float4_0;

		// Token: 0x0400148F RID: 5263
		private static readonly IntPtr NativeMethodInfoPtr_get_ywzy_Public_get_float4_0;

		// Token: 0x04001490 RID: 5264
		private static readonly IntPtr NativeMethodInfoPtr_get_ywzz_Public_get_float4_0;

		// Token: 0x04001491 RID: 5265
		private static readonly IntPtr NativeMethodInfoPtr_get_ywzw_Public_get_float4_0;

		// Token: 0x04001492 RID: 5266
		private static readonly IntPtr NativeMethodInfoPtr_get_ywwx_Public_get_float4_0;

		// Token: 0x04001493 RID: 5267
		private static readonly IntPtr NativeMethodInfoPtr_get_ywwy_Public_get_float4_0;

		// Token: 0x04001494 RID: 5268
		private static readonly IntPtr NativeMethodInfoPtr_get_ywwz_Public_get_float4_0;

		// Token: 0x04001495 RID: 5269
		private static readonly IntPtr NativeMethodInfoPtr_get_ywww_Public_get_float4_0;

		// Token: 0x04001496 RID: 5270
		private static readonly IntPtr NativeMethodInfoPtr_get_zxxx_Public_get_float4_0;

		// Token: 0x04001497 RID: 5271
		private static readonly IntPtr NativeMethodInfoPtr_get_zxxy_Public_get_float4_0;

		// Token: 0x04001498 RID: 5272
		private static readonly IntPtr NativeMethodInfoPtr_get_zxxz_Public_get_float4_0;

		// Token: 0x04001499 RID: 5273
		private static readonly IntPtr NativeMethodInfoPtr_get_zxxw_Public_get_float4_0;

		// Token: 0x0400149A RID: 5274
		private static readonly IntPtr NativeMethodInfoPtr_get_zxyx_Public_get_float4_0;

		// Token: 0x0400149B RID: 5275
		private static readonly IntPtr NativeMethodInfoPtr_get_zxyy_Public_get_float4_0;

		// Token: 0x0400149C RID: 5276
		private static readonly IntPtr NativeMethodInfoPtr_get_zxyz_Public_get_float4_0;

		// Token: 0x0400149D RID: 5277
		private static readonly IntPtr NativeMethodInfoPtr_get_zxyw_Public_get_float4_0;

		// Token: 0x0400149E RID: 5278
		private static readonly IntPtr NativeMethodInfoPtr_set_zxyw_Public_set_Void_float4_0;

		// Token: 0x0400149F RID: 5279
		private static readonly IntPtr NativeMethodInfoPtr_get_zxzx_Public_get_float4_0;

		// Token: 0x040014A0 RID: 5280
		private static readonly IntPtr NativeMethodInfoPtr_get_zxzy_Public_get_float4_0;

		// Token: 0x040014A1 RID: 5281
		private static readonly IntPtr NativeMethodInfoPtr_get_zxzz_Public_get_float4_0;

		// Token: 0x040014A2 RID: 5282
		private static readonly IntPtr NativeMethodInfoPtr_get_zxzw_Public_get_float4_0;

		// Token: 0x040014A3 RID: 5283
		private static readonly IntPtr NativeMethodInfoPtr_get_zxwx_Public_get_float4_0;

		// Token: 0x040014A4 RID: 5284
		private static readonly IntPtr NativeMethodInfoPtr_get_zxwy_Public_get_float4_0;

		// Token: 0x040014A5 RID: 5285
		private static readonly IntPtr NativeMethodInfoPtr_set_zxwy_Public_set_Void_float4_0;

		// Token: 0x040014A6 RID: 5286
		private static readonly IntPtr NativeMethodInfoPtr_get_zxwz_Public_get_float4_0;

		// Token: 0x040014A7 RID: 5287
		private static readonly IntPtr NativeMethodInfoPtr_get_zxww_Public_get_float4_0;

		// Token: 0x040014A8 RID: 5288
		private static readonly IntPtr NativeMethodInfoPtr_get_zyxx_Public_get_float4_0;

		// Token: 0x040014A9 RID: 5289
		private static readonly IntPtr NativeMethodInfoPtr_get_zyxy_Public_get_float4_0;

		// Token: 0x040014AA RID: 5290
		private static readonly IntPtr NativeMethodInfoPtr_get_zyxz_Public_get_float4_0;

		// Token: 0x040014AB RID: 5291
		private static readonly IntPtr NativeMethodInfoPtr_get_zyxw_Public_get_float4_0;

		// Token: 0x040014AC RID: 5292
		private static readonly IntPtr NativeMethodInfoPtr_set_zyxw_Public_set_Void_float4_0;

		// Token: 0x040014AD RID: 5293
		private static readonly IntPtr NativeMethodInfoPtr_get_zyyx_Public_get_float4_0;

		// Token: 0x040014AE RID: 5294
		private static readonly IntPtr NativeMethodInfoPtr_get_zyyy_Public_get_float4_0;

		// Token: 0x040014AF RID: 5295
		private static readonly IntPtr NativeMethodInfoPtr_get_zyyz_Public_get_float4_0;

		// Token: 0x040014B0 RID: 5296
		private static readonly IntPtr NativeMethodInfoPtr_get_zyyw_Public_get_float4_0;

		// Token: 0x040014B1 RID: 5297
		private static readonly IntPtr NativeMethodInfoPtr_get_zyzx_Public_get_float4_0;

		// Token: 0x040014B2 RID: 5298
		private static readonly IntPtr NativeMethodInfoPtr_get_zyzy_Public_get_float4_0;

		// Token: 0x040014B3 RID: 5299
		private static readonly IntPtr NativeMethodInfoPtr_get_zyzz_Public_get_float4_0;

		// Token: 0x040014B4 RID: 5300
		private static readonly IntPtr NativeMethodInfoPtr_get_zyzw_Public_get_float4_0;

		// Token: 0x040014B5 RID: 5301
		private static readonly IntPtr NativeMethodInfoPtr_get_zywx_Public_get_float4_0;

		// Token: 0x040014B6 RID: 5302
		private static readonly IntPtr NativeMethodInfoPtr_set_zywx_Public_set_Void_float4_0;

		// Token: 0x040014B7 RID: 5303
		private static readonly IntPtr NativeMethodInfoPtr_get_zywy_Public_get_float4_0;

		// Token: 0x040014B8 RID: 5304
		private static readonly IntPtr NativeMethodInfoPtr_get_zywz_Public_get_float4_0;

		// Token: 0x040014B9 RID: 5305
		private static readonly IntPtr NativeMethodInfoPtr_get_zyww_Public_get_float4_0;

		// Token: 0x040014BA RID: 5306
		private static readonly IntPtr NativeMethodInfoPtr_get_zzxx_Public_get_float4_0;

		// Token: 0x040014BB RID: 5307
		private static readonly IntPtr NativeMethodInfoPtr_get_zzxy_Public_get_float4_0;

		// Token: 0x040014BC RID: 5308
		private static readonly IntPtr NativeMethodInfoPtr_get_zzxz_Public_get_float4_0;

		// Token: 0x040014BD RID: 5309
		private static readonly IntPtr NativeMethodInfoPtr_get_zzxw_Public_get_float4_0;

		// Token: 0x040014BE RID: 5310
		private static readonly IntPtr NativeMethodInfoPtr_get_zzyx_Public_get_float4_0;

		// Token: 0x040014BF RID: 5311
		private static readonly IntPtr NativeMethodInfoPtr_get_zzyy_Public_get_float4_0;

		// Token: 0x040014C0 RID: 5312
		private static readonly IntPtr NativeMethodInfoPtr_get_zzyz_Public_get_float4_0;

		// Token: 0x040014C1 RID: 5313
		private static readonly IntPtr NativeMethodInfoPtr_get_zzyw_Public_get_float4_0;

		// Token: 0x040014C2 RID: 5314
		private static readonly IntPtr NativeMethodInfoPtr_get_zzzx_Public_get_float4_0;

		// Token: 0x040014C3 RID: 5315
		private static readonly IntPtr NativeMethodInfoPtr_get_zzzy_Public_get_float4_0;

		// Token: 0x040014C4 RID: 5316
		private static readonly IntPtr NativeMethodInfoPtr_get_zzzz_Public_get_float4_0;

		// Token: 0x040014C5 RID: 5317
		private static readonly IntPtr NativeMethodInfoPtr_get_zzzw_Public_get_float4_0;

		// Token: 0x040014C6 RID: 5318
		private static readonly IntPtr NativeMethodInfoPtr_get_zzwx_Public_get_float4_0;

		// Token: 0x040014C7 RID: 5319
		private static readonly IntPtr NativeMethodInfoPtr_get_zzwy_Public_get_float4_0;

		// Token: 0x040014C8 RID: 5320
		private static readonly IntPtr NativeMethodInfoPtr_get_zzwz_Public_get_float4_0;

		// Token: 0x040014C9 RID: 5321
		private static readonly IntPtr NativeMethodInfoPtr_get_zzww_Public_get_float4_0;

		// Token: 0x040014CA RID: 5322
		private static readonly IntPtr NativeMethodInfoPtr_get_zwxx_Public_get_float4_0;

		// Token: 0x040014CB RID: 5323
		private static readonly IntPtr NativeMethodInfoPtr_get_zwxy_Public_get_float4_0;

		// Token: 0x040014CC RID: 5324
		private static readonly IntPtr NativeMethodInfoPtr_set_zwxy_Public_set_Void_float4_0;

		// Token: 0x040014CD RID: 5325
		private static readonly IntPtr NativeMethodInfoPtr_get_zwxz_Public_get_float4_0;

		// Token: 0x040014CE RID: 5326
		private static readonly IntPtr NativeMethodInfoPtr_get_zwxw_Public_get_float4_0;

		// Token: 0x040014CF RID: 5327
		private static readonly IntPtr NativeMethodInfoPtr_get_zwyx_Public_get_float4_0;

		// Token: 0x040014D0 RID: 5328
		private static readonly IntPtr NativeMethodInfoPtr_set_zwyx_Public_set_Void_float4_0;

		// Token: 0x040014D1 RID: 5329
		private static readonly IntPtr NativeMethodInfoPtr_get_zwyy_Public_get_float4_0;

		// Token: 0x040014D2 RID: 5330
		private static readonly IntPtr NativeMethodInfoPtr_get_zwyz_Public_get_float4_0;

		// Token: 0x040014D3 RID: 5331
		private static readonly IntPtr NativeMethodInfoPtr_get_zwyw_Public_get_float4_0;

		// Token: 0x040014D4 RID: 5332
		private static readonly IntPtr NativeMethodInfoPtr_get_zwzx_Public_get_float4_0;

		// Token: 0x040014D5 RID: 5333
		private static readonly IntPtr NativeMethodInfoPtr_get_zwzy_Public_get_float4_0;

		// Token: 0x040014D6 RID: 5334
		private static readonly IntPtr NativeMethodInfoPtr_get_zwzz_Public_get_float4_0;

		// Token: 0x040014D7 RID: 5335
		private static readonly IntPtr NativeMethodInfoPtr_get_zwzw_Public_get_float4_0;

		// Token: 0x040014D8 RID: 5336
		private static readonly IntPtr NativeMethodInfoPtr_get_zwwx_Public_get_float4_0;

		// Token: 0x040014D9 RID: 5337
		private static readonly IntPtr NativeMethodInfoPtr_get_zwwy_Public_get_float4_0;

		// Token: 0x040014DA RID: 5338
		private static readonly IntPtr NativeMethodInfoPtr_get_zwwz_Public_get_float4_0;

		// Token: 0x040014DB RID: 5339
		private static readonly IntPtr NativeMethodInfoPtr_get_zwww_Public_get_float4_0;

		// Token: 0x040014DC RID: 5340
		private static readonly IntPtr NativeMethodInfoPtr_get_wxxx_Public_get_float4_0;

		// Token: 0x040014DD RID: 5341
		private static readonly IntPtr NativeMethodInfoPtr_get_wxxy_Public_get_float4_0;

		// Token: 0x040014DE RID: 5342
		private static readonly IntPtr NativeMethodInfoPtr_get_wxxz_Public_get_float4_0;

		// Token: 0x040014DF RID: 5343
		private static readonly IntPtr NativeMethodInfoPtr_get_wxxw_Public_get_float4_0;

		// Token: 0x040014E0 RID: 5344
		private static readonly IntPtr NativeMethodInfoPtr_get_wxyx_Public_get_float4_0;

		// Token: 0x040014E1 RID: 5345
		private static readonly IntPtr NativeMethodInfoPtr_get_wxyy_Public_get_float4_0;

		// Token: 0x040014E2 RID: 5346
		private static readonly IntPtr NativeMethodInfoPtr_get_wxyz_Public_get_float4_0;

		// Token: 0x040014E3 RID: 5347
		private static readonly IntPtr NativeMethodInfoPtr_set_wxyz_Public_set_Void_float4_0;

		// Token: 0x040014E4 RID: 5348
		private static readonly IntPtr NativeMethodInfoPtr_get_wxyw_Public_get_float4_0;

		// Token: 0x040014E5 RID: 5349
		private static readonly IntPtr NativeMethodInfoPtr_get_wxzx_Public_get_float4_0;

		// Token: 0x040014E6 RID: 5350
		private static readonly IntPtr NativeMethodInfoPtr_get_wxzy_Public_get_float4_0;

		// Token: 0x040014E7 RID: 5351
		private static readonly IntPtr NativeMethodInfoPtr_set_wxzy_Public_set_Void_float4_0;

		// Token: 0x040014E8 RID: 5352
		private static readonly IntPtr NativeMethodInfoPtr_get_wxzz_Public_get_float4_0;

		// Token: 0x040014E9 RID: 5353
		private static readonly IntPtr NativeMethodInfoPtr_get_wxzw_Public_get_float4_0;

		// Token: 0x040014EA RID: 5354
		private static readonly IntPtr NativeMethodInfoPtr_get_wxwx_Public_get_float4_0;

		// Token: 0x040014EB RID: 5355
		private static readonly IntPtr NativeMethodInfoPtr_get_wxwy_Public_get_float4_0;

		// Token: 0x040014EC RID: 5356
		private static readonly IntPtr NativeMethodInfoPtr_get_wxwz_Public_get_float4_0;

		// Token: 0x040014ED RID: 5357
		private static readonly IntPtr NativeMethodInfoPtr_get_wxww_Public_get_float4_0;

		// Token: 0x040014EE RID: 5358
		private static readonly IntPtr NativeMethodInfoPtr_get_wyxx_Public_get_float4_0;

		// Token: 0x040014EF RID: 5359
		private static readonly IntPtr NativeMethodInfoPtr_get_wyxy_Public_get_float4_0;

		// Token: 0x040014F0 RID: 5360
		private static readonly IntPtr NativeMethodInfoPtr_get_wyxz_Public_get_float4_0;

		// Token: 0x040014F1 RID: 5361
		private static readonly IntPtr NativeMethodInfoPtr_set_wyxz_Public_set_Void_float4_0;

		// Token: 0x040014F2 RID: 5362
		private static readonly IntPtr NativeMethodInfoPtr_get_wyxw_Public_get_float4_0;

		// Token: 0x040014F3 RID: 5363
		private static readonly IntPtr NativeMethodInfoPtr_get_wyyx_Public_get_float4_0;

		// Token: 0x040014F4 RID: 5364
		private static readonly IntPtr NativeMethodInfoPtr_get_wyyy_Public_get_float4_0;

		// Token: 0x040014F5 RID: 5365
		private static readonly IntPtr NativeMethodInfoPtr_get_wyyz_Public_get_float4_0;

		// Token: 0x040014F6 RID: 5366
		private static readonly IntPtr NativeMethodInfoPtr_get_wyyw_Public_get_float4_0;

		// Token: 0x040014F7 RID: 5367
		private static readonly IntPtr NativeMethodInfoPtr_get_wyzx_Public_get_float4_0;

		// Token: 0x040014F8 RID: 5368
		private static readonly IntPtr NativeMethodInfoPtr_set_wyzx_Public_set_Void_float4_0;

		// Token: 0x040014F9 RID: 5369
		private static readonly IntPtr NativeMethodInfoPtr_get_wyzy_Public_get_float4_0;

		// Token: 0x040014FA RID: 5370
		private static readonly IntPtr NativeMethodInfoPtr_get_wyzz_Public_get_float4_0;

		// Token: 0x040014FB RID: 5371
		private static readonly IntPtr NativeMethodInfoPtr_get_wyzw_Public_get_float4_0;

		// Token: 0x040014FC RID: 5372
		private static readonly IntPtr NativeMethodInfoPtr_get_wywx_Public_get_float4_0;

		// Token: 0x040014FD RID: 5373
		private static readonly IntPtr NativeMethodInfoPtr_get_wywy_Public_get_float4_0;

		// Token: 0x040014FE RID: 5374
		private static readonly IntPtr NativeMethodInfoPtr_get_wywz_Public_get_float4_0;

		// Token: 0x040014FF RID: 5375
		private static readonly IntPtr NativeMethodInfoPtr_get_wyww_Public_get_float4_0;

		// Token: 0x04001500 RID: 5376
		private static readonly IntPtr NativeMethodInfoPtr_get_wzxx_Public_get_float4_0;

		// Token: 0x04001501 RID: 5377
		private static readonly IntPtr NativeMethodInfoPtr_get_wzxy_Public_get_float4_0;

		// Token: 0x04001502 RID: 5378
		private static readonly IntPtr NativeMethodInfoPtr_set_wzxy_Public_set_Void_float4_0;

		// Token: 0x04001503 RID: 5379
		private static readonly IntPtr NativeMethodInfoPtr_get_wzxz_Public_get_float4_0;

		// Token: 0x04001504 RID: 5380
		private static readonly IntPtr NativeMethodInfoPtr_get_wzxw_Public_get_float4_0;

		// Token: 0x04001505 RID: 5381
		private static readonly IntPtr NativeMethodInfoPtr_get_wzyx_Public_get_float4_0;

		// Token: 0x04001506 RID: 5382
		private static readonly IntPtr NativeMethodInfoPtr_set_wzyx_Public_set_Void_float4_0;

		// Token: 0x04001507 RID: 5383
		private static readonly IntPtr NativeMethodInfoPtr_get_wzyy_Public_get_float4_0;

		// Token: 0x04001508 RID: 5384
		private static readonly IntPtr NativeMethodInfoPtr_get_wzyz_Public_get_float4_0;

		// Token: 0x04001509 RID: 5385
		private static readonly IntPtr NativeMethodInfoPtr_get_wzyw_Public_get_float4_0;

		// Token: 0x0400150A RID: 5386
		private static readonly IntPtr NativeMethodInfoPtr_get_wzzx_Public_get_float4_0;

		// Token: 0x0400150B RID: 5387
		private static readonly IntPtr NativeMethodInfoPtr_get_wzzy_Public_get_float4_0;

		// Token: 0x0400150C RID: 5388
		private static readonly IntPtr NativeMethodInfoPtr_get_wzzz_Public_get_float4_0;

		// Token: 0x0400150D RID: 5389
		private static readonly IntPtr NativeMethodInfoPtr_get_wzzw_Public_get_float4_0;

		// Token: 0x0400150E RID: 5390
		private static readonly IntPtr NativeMethodInfoPtr_get_wzwx_Public_get_float4_0;

		// Token: 0x0400150F RID: 5391
		private static readonly IntPtr NativeMethodInfoPtr_get_wzwy_Public_get_float4_0;

		// Token: 0x04001510 RID: 5392
		private static readonly IntPtr NativeMethodInfoPtr_get_wzwz_Public_get_float4_0;

		// Token: 0x04001511 RID: 5393
		private static readonly IntPtr NativeMethodInfoPtr_get_wzww_Public_get_float4_0;

		// Token: 0x04001512 RID: 5394
		private static readonly IntPtr NativeMethodInfoPtr_get_wwxx_Public_get_float4_0;

		// Token: 0x04001513 RID: 5395
		private static readonly IntPtr NativeMethodInfoPtr_get_wwxy_Public_get_float4_0;

		// Token: 0x04001514 RID: 5396
		private static readonly IntPtr NativeMethodInfoPtr_get_wwxz_Public_get_float4_0;

		// Token: 0x04001515 RID: 5397
		private static readonly IntPtr NativeMethodInfoPtr_get_wwxw_Public_get_float4_0;

		// Token: 0x04001516 RID: 5398
		private static readonly IntPtr NativeMethodInfoPtr_get_wwyx_Public_get_float4_0;

		// Token: 0x04001517 RID: 5399
		private static readonly IntPtr NativeMethodInfoPtr_get_wwyy_Public_get_float4_0;

		// Token: 0x04001518 RID: 5400
		private static readonly IntPtr NativeMethodInfoPtr_get_wwyz_Public_get_float4_0;

		// Token: 0x04001519 RID: 5401
		private static readonly IntPtr NativeMethodInfoPtr_get_wwyw_Public_get_float4_0;

		// Token: 0x0400151A RID: 5402
		private static readonly IntPtr NativeMethodInfoPtr_get_wwzx_Public_get_float4_0;

		// Token: 0x0400151B RID: 5403
		private static readonly IntPtr NativeMethodInfoPtr_get_wwzy_Public_get_float4_0;

		// Token: 0x0400151C RID: 5404
		private static readonly IntPtr NativeMethodInfoPtr_get_wwzz_Public_get_float4_0;

		// Token: 0x0400151D RID: 5405
		private static readonly IntPtr NativeMethodInfoPtr_get_wwzw_Public_get_float4_0;

		// Token: 0x0400151E RID: 5406
		private static readonly IntPtr NativeMethodInfoPtr_get_wwwx_Public_get_float4_0;

		// Token: 0x0400151F RID: 5407
		private static readonly IntPtr NativeMethodInfoPtr_get_wwwy_Public_get_float4_0;

		// Token: 0x04001520 RID: 5408
		private static readonly IntPtr NativeMethodInfoPtr_get_wwwz_Public_get_float4_0;

		// Token: 0x04001521 RID: 5409
		private static readonly IntPtr NativeMethodInfoPtr_get_wwww_Public_get_float4_0;

		// Token: 0x04001522 RID: 5410
		private static readonly IntPtr NativeMethodInfoPtr_get_xxx_Public_get_float3_0;

		// Token: 0x04001523 RID: 5411
		private static readonly IntPtr NativeMethodInfoPtr_get_xxy_Public_get_float3_0;

		// Token: 0x04001524 RID: 5412
		private static readonly IntPtr NativeMethodInfoPtr_get_xxz_Public_get_float3_0;

		// Token: 0x04001525 RID: 5413
		private static readonly IntPtr NativeMethodInfoPtr_get_xxw_Public_get_float3_0;

		// Token: 0x04001526 RID: 5414
		private static readonly IntPtr NativeMethodInfoPtr_get_xyx_Public_get_float3_0;

		// Token: 0x04001527 RID: 5415
		private static readonly IntPtr NativeMethodInfoPtr_get_xyy_Public_get_float3_0;

		// Token: 0x04001528 RID: 5416
		private static readonly IntPtr NativeMethodInfoPtr_get_xyz_Public_get_float3_0;

		// Token: 0x04001529 RID: 5417
		private static readonly IntPtr NativeMethodInfoPtr_set_xyz_Public_set_Void_float3_0;

		// Token: 0x0400152A RID: 5418
		private static readonly IntPtr NativeMethodInfoPtr_get_xyw_Public_get_float3_0;

		// Token: 0x0400152B RID: 5419
		private static readonly IntPtr NativeMethodInfoPtr_set_xyw_Public_set_Void_float3_0;

		// Token: 0x0400152C RID: 5420
		private static readonly IntPtr NativeMethodInfoPtr_get_xzx_Public_get_float3_0;

		// Token: 0x0400152D RID: 5421
		private static readonly IntPtr NativeMethodInfoPtr_get_xzy_Public_get_float3_0;

		// Token: 0x0400152E RID: 5422
		private static readonly IntPtr NativeMethodInfoPtr_set_xzy_Public_set_Void_float3_0;

		// Token: 0x0400152F RID: 5423
		private static readonly IntPtr NativeMethodInfoPtr_get_xzz_Public_get_float3_0;

		// Token: 0x04001530 RID: 5424
		private static readonly IntPtr NativeMethodInfoPtr_get_xzw_Public_get_float3_0;

		// Token: 0x04001531 RID: 5425
		private static readonly IntPtr NativeMethodInfoPtr_set_xzw_Public_set_Void_float3_0;

		// Token: 0x04001532 RID: 5426
		private static readonly IntPtr NativeMethodInfoPtr_get_xwx_Public_get_float3_0;

		// Token: 0x04001533 RID: 5427
		private static readonly IntPtr NativeMethodInfoPtr_get_xwy_Public_get_float3_0;

		// Token: 0x04001534 RID: 5428
		private static readonly IntPtr NativeMethodInfoPtr_set_xwy_Public_set_Void_float3_0;

		// Token: 0x04001535 RID: 5429
		private static readonly IntPtr NativeMethodInfoPtr_get_xwz_Public_get_float3_0;

		// Token: 0x04001536 RID: 5430
		private static readonly IntPtr NativeMethodInfoPtr_set_xwz_Public_set_Void_float3_0;

		// Token: 0x04001537 RID: 5431
		private static readonly IntPtr NativeMethodInfoPtr_get_xww_Public_get_float3_0;

		// Token: 0x04001538 RID: 5432
		private static readonly IntPtr NativeMethodInfoPtr_get_yxx_Public_get_float3_0;

		// Token: 0x04001539 RID: 5433
		private static readonly IntPtr NativeMethodInfoPtr_get_yxy_Public_get_float3_0;

		// Token: 0x0400153A RID: 5434
		private static readonly IntPtr NativeMethodInfoPtr_get_yxz_Public_get_float3_0;

		// Token: 0x0400153B RID: 5435
		private static readonly IntPtr NativeMethodInfoPtr_set_yxz_Public_set_Void_float3_0;

		// Token: 0x0400153C RID: 5436
		private static readonly IntPtr NativeMethodInfoPtr_get_yxw_Public_get_float3_0;

		// Token: 0x0400153D RID: 5437
		private static readonly IntPtr NativeMethodInfoPtr_set_yxw_Public_set_Void_float3_0;

		// Token: 0x0400153E RID: 5438
		private static readonly IntPtr NativeMethodInfoPtr_get_yyx_Public_get_float3_0;

		// Token: 0x0400153F RID: 5439
		private static readonly IntPtr NativeMethodInfoPtr_get_yyy_Public_get_float3_0;

		// Token: 0x04001540 RID: 5440
		private static readonly IntPtr NativeMethodInfoPtr_get_yyz_Public_get_float3_0;

		// Token: 0x04001541 RID: 5441
		private static readonly IntPtr NativeMethodInfoPtr_get_yyw_Public_get_float3_0;

		// Token: 0x04001542 RID: 5442
		private static readonly IntPtr NativeMethodInfoPtr_get_yzx_Public_get_float3_0;

		// Token: 0x04001543 RID: 5443
		private static readonly IntPtr NativeMethodInfoPtr_set_yzx_Public_set_Void_float3_0;

		// Token: 0x04001544 RID: 5444
		private static readonly IntPtr NativeMethodInfoPtr_get_yzy_Public_get_float3_0;

		// Token: 0x04001545 RID: 5445
		private static readonly IntPtr NativeMethodInfoPtr_get_yzz_Public_get_float3_0;

		// Token: 0x04001546 RID: 5446
		private static readonly IntPtr NativeMethodInfoPtr_get_yzw_Public_get_float3_0;

		// Token: 0x04001547 RID: 5447
		private static readonly IntPtr NativeMethodInfoPtr_set_yzw_Public_set_Void_float3_0;

		// Token: 0x04001548 RID: 5448
		private static readonly IntPtr NativeMethodInfoPtr_get_ywx_Public_get_float3_0;

		// Token: 0x04001549 RID: 5449
		private static readonly IntPtr NativeMethodInfoPtr_set_ywx_Public_set_Void_float3_0;

		// Token: 0x0400154A RID: 5450
		private static readonly IntPtr NativeMethodInfoPtr_get_ywy_Public_get_float3_0;

		// Token: 0x0400154B RID: 5451
		private static readonly IntPtr NativeMethodInfoPtr_get_ywz_Public_get_float3_0;

		// Token: 0x0400154C RID: 5452
		private static readonly IntPtr NativeMethodInfoPtr_set_ywz_Public_set_Void_float3_0;

		// Token: 0x0400154D RID: 5453
		private static readonly IntPtr NativeMethodInfoPtr_get_yww_Public_get_float3_0;

		// Token: 0x0400154E RID: 5454
		private static readonly IntPtr NativeMethodInfoPtr_get_zxx_Public_get_float3_0;

		// Token: 0x0400154F RID: 5455
		private static readonly IntPtr NativeMethodInfoPtr_get_zxy_Public_get_float3_0;

		// Token: 0x04001550 RID: 5456
		private static readonly IntPtr NativeMethodInfoPtr_set_zxy_Public_set_Void_float3_0;

		// Token: 0x04001551 RID: 5457
		private static readonly IntPtr NativeMethodInfoPtr_get_zxz_Public_get_float3_0;

		// Token: 0x04001552 RID: 5458
		private static readonly IntPtr NativeMethodInfoPtr_get_zxw_Public_get_float3_0;

		// Token: 0x04001553 RID: 5459
		private static readonly IntPtr NativeMethodInfoPtr_set_zxw_Public_set_Void_float3_0;

		// Token: 0x04001554 RID: 5460
		private static readonly IntPtr NativeMethodInfoPtr_get_zyx_Public_get_float3_0;

		// Token: 0x04001555 RID: 5461
		private static readonly IntPtr NativeMethodInfoPtr_set_zyx_Public_set_Void_float3_0;

		// Token: 0x04001556 RID: 5462
		private static readonly IntPtr NativeMethodInfoPtr_get_zyy_Public_get_float3_0;

		// Token: 0x04001557 RID: 5463
		private static readonly IntPtr NativeMethodInfoPtr_get_zyz_Public_get_float3_0;

		// Token: 0x04001558 RID: 5464
		private static readonly IntPtr NativeMethodInfoPtr_get_zyw_Public_get_float3_0;

		// Token: 0x04001559 RID: 5465
		private static readonly IntPtr NativeMethodInfoPtr_set_zyw_Public_set_Void_float3_0;

		// Token: 0x0400155A RID: 5466
		private static readonly IntPtr NativeMethodInfoPtr_get_zzx_Public_get_float3_0;

		// Token: 0x0400155B RID: 5467
		private static readonly IntPtr NativeMethodInfoPtr_get_zzy_Public_get_float3_0;

		// Token: 0x0400155C RID: 5468
		private static readonly IntPtr NativeMethodInfoPtr_get_zzz_Public_get_float3_0;

		// Token: 0x0400155D RID: 5469
		private static readonly IntPtr NativeMethodInfoPtr_get_zzw_Public_get_float3_0;

		// Token: 0x0400155E RID: 5470
		private static readonly IntPtr NativeMethodInfoPtr_get_zwx_Public_get_float3_0;

		// Token: 0x0400155F RID: 5471
		private static readonly IntPtr NativeMethodInfoPtr_set_zwx_Public_set_Void_float3_0;

		// Token: 0x04001560 RID: 5472
		private static readonly IntPtr NativeMethodInfoPtr_get_zwy_Public_get_float3_0;

		// Token: 0x04001561 RID: 5473
		private static readonly IntPtr NativeMethodInfoPtr_set_zwy_Public_set_Void_float3_0;

		// Token: 0x04001562 RID: 5474
		private static readonly IntPtr NativeMethodInfoPtr_get_zwz_Public_get_float3_0;

		// Token: 0x04001563 RID: 5475
		private static readonly IntPtr NativeMethodInfoPtr_get_zww_Public_get_float3_0;

		// Token: 0x04001564 RID: 5476
		private static readonly IntPtr NativeMethodInfoPtr_get_wxx_Public_get_float3_0;

		// Token: 0x04001565 RID: 5477
		private static readonly IntPtr NativeMethodInfoPtr_get_wxy_Public_get_float3_0;

		// Token: 0x04001566 RID: 5478
		private static readonly IntPtr NativeMethodInfoPtr_set_wxy_Public_set_Void_float3_0;

		// Token: 0x04001567 RID: 5479
		private static readonly IntPtr NativeMethodInfoPtr_get_wxz_Public_get_float3_0;

		// Token: 0x04001568 RID: 5480
		private static readonly IntPtr NativeMethodInfoPtr_set_wxz_Public_set_Void_float3_0;

		// Token: 0x04001569 RID: 5481
		private static readonly IntPtr NativeMethodInfoPtr_get_wxw_Public_get_float3_0;

		// Token: 0x0400156A RID: 5482
		private static readonly IntPtr NativeMethodInfoPtr_get_wyx_Public_get_float3_0;

		// Token: 0x0400156B RID: 5483
		private static readonly IntPtr NativeMethodInfoPtr_set_wyx_Public_set_Void_float3_0;

		// Token: 0x0400156C RID: 5484
		private static readonly IntPtr NativeMethodInfoPtr_get_wyy_Public_get_float3_0;

		// Token: 0x0400156D RID: 5485
		private static readonly IntPtr NativeMethodInfoPtr_get_wyz_Public_get_float3_0;

		// Token: 0x0400156E RID: 5486
		private static readonly IntPtr NativeMethodInfoPtr_set_wyz_Public_set_Void_float3_0;

		// Token: 0x0400156F RID: 5487
		private static readonly IntPtr NativeMethodInfoPtr_get_wyw_Public_get_float3_0;

		// Token: 0x04001570 RID: 5488
		private static readonly IntPtr NativeMethodInfoPtr_get_wzx_Public_get_float3_0;

		// Token: 0x04001571 RID: 5489
		private static readonly IntPtr NativeMethodInfoPtr_set_wzx_Public_set_Void_float3_0;

		// Token: 0x04001572 RID: 5490
		private static readonly IntPtr NativeMethodInfoPtr_get_wzy_Public_get_float3_0;

		// Token: 0x04001573 RID: 5491
		private static readonly IntPtr NativeMethodInfoPtr_set_wzy_Public_set_Void_float3_0;

		// Token: 0x04001574 RID: 5492
		private static readonly IntPtr NativeMethodInfoPtr_get_wzz_Public_get_float3_0;

		// Token: 0x04001575 RID: 5493
		private static readonly IntPtr NativeMethodInfoPtr_get_wzw_Public_get_float3_0;

		// Token: 0x04001576 RID: 5494
		private static readonly IntPtr NativeMethodInfoPtr_get_wwx_Public_get_float3_0;

		// Token: 0x04001577 RID: 5495
		private static readonly IntPtr NativeMethodInfoPtr_get_wwy_Public_get_float3_0;

		// Token: 0x04001578 RID: 5496
		private static readonly IntPtr NativeMethodInfoPtr_get_wwz_Public_get_float3_0;

		// Token: 0x04001579 RID: 5497
		private static readonly IntPtr NativeMethodInfoPtr_get_www_Public_get_float3_0;

		// Token: 0x0400157A RID: 5498
		private static readonly IntPtr NativeMethodInfoPtr_get_xx_Public_get_float2_0;

		// Token: 0x0400157B RID: 5499
		private static readonly IntPtr NativeMethodInfoPtr_get_xy_Public_get_float2_0;

		// Token: 0x0400157C RID: 5500
		private static readonly IntPtr NativeMethodInfoPtr_set_xy_Public_set_Void_float2_0;

		// Token: 0x0400157D RID: 5501
		private static readonly IntPtr NativeMethodInfoPtr_get_xz_Public_get_float2_0;

		// Token: 0x0400157E RID: 5502
		private static readonly IntPtr NativeMethodInfoPtr_set_xz_Public_set_Void_float2_0;

		// Token: 0x0400157F RID: 5503
		private static readonly IntPtr NativeMethodInfoPtr_get_xw_Public_get_float2_0;

		// Token: 0x04001580 RID: 5504
		private static readonly IntPtr NativeMethodInfoPtr_set_xw_Public_set_Void_float2_0;

		// Token: 0x04001581 RID: 5505
		private static readonly IntPtr NativeMethodInfoPtr_get_yx_Public_get_float2_0;

		// Token: 0x04001582 RID: 5506
		private static readonly IntPtr NativeMethodInfoPtr_set_yx_Public_set_Void_float2_0;

		// Token: 0x04001583 RID: 5507
		private static readonly IntPtr NativeMethodInfoPtr_get_yy_Public_get_float2_0;

		// Token: 0x04001584 RID: 5508
		private static readonly IntPtr NativeMethodInfoPtr_get_yz_Public_get_float2_0;

		// Token: 0x04001585 RID: 5509
		private static readonly IntPtr NativeMethodInfoPtr_set_yz_Public_set_Void_float2_0;

		// Token: 0x04001586 RID: 5510
		private static readonly IntPtr NativeMethodInfoPtr_get_yw_Public_get_float2_0;

		// Token: 0x04001587 RID: 5511
		private static readonly IntPtr NativeMethodInfoPtr_set_yw_Public_set_Void_float2_0;

		// Token: 0x04001588 RID: 5512
		private static readonly IntPtr NativeMethodInfoPtr_get_zx_Public_get_float2_0;

		// Token: 0x04001589 RID: 5513
		private static readonly IntPtr NativeMethodInfoPtr_set_zx_Public_set_Void_float2_0;

		// Token: 0x0400158A RID: 5514
		private static readonly IntPtr NativeMethodInfoPtr_get_zy_Public_get_float2_0;

		// Token: 0x0400158B RID: 5515
		private static readonly IntPtr NativeMethodInfoPtr_set_zy_Public_set_Void_float2_0;

		// Token: 0x0400158C RID: 5516
		private static readonly IntPtr NativeMethodInfoPtr_get_zz_Public_get_float2_0;

		// Token: 0x0400158D RID: 5517
		private static readonly IntPtr NativeMethodInfoPtr_get_zw_Public_get_float2_0;

		// Token: 0x0400158E RID: 5518
		private static readonly IntPtr NativeMethodInfoPtr_set_zw_Public_set_Void_float2_0;

		// Token: 0x0400158F RID: 5519
		private static readonly IntPtr NativeMethodInfoPtr_get_wx_Public_get_float2_0;

		// Token: 0x04001590 RID: 5520
		private static readonly IntPtr NativeMethodInfoPtr_set_wx_Public_set_Void_float2_0;

		// Token: 0x04001591 RID: 5521
		private static readonly IntPtr NativeMethodInfoPtr_get_wy_Public_get_float2_0;

		// Token: 0x04001592 RID: 5522
		private static readonly IntPtr NativeMethodInfoPtr_set_wy_Public_set_Void_float2_0;

		// Token: 0x04001593 RID: 5523
		private static readonly IntPtr NativeMethodInfoPtr_get_wz_Public_get_float2_0;

		// Token: 0x04001594 RID: 5524
		private static readonly IntPtr NativeMethodInfoPtr_set_wz_Public_set_Void_float2_0;

		// Token: 0x04001595 RID: 5525
		private static readonly IntPtr NativeMethodInfoPtr_get_ww_Public_get_float2_0;

		// Token: 0x04001596 RID: 5526
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0;

		// Token: 0x04001597 RID: 5527
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0;

		// Token: 0x04001598 RID: 5528
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_float4_0;

		// Token: 0x04001599 RID: 5529
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400159A RID: 5530
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400159B RID: 5531
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400159C RID: 5532
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x0400159D RID: 5533
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float4_Vector4_0;

		// Token: 0x0400159E RID: 5534
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_float4_0;

		// Token: 0x0400159F RID: 5535
		[FieldOffset(0)]
		public float x;

		// Token: 0x040015A0 RID: 5536
		[FieldOffset(4)]
		public float y;

		// Token: 0x040015A1 RID: 5537
		[FieldOffset(8)]
		public float z;

		// Token: 0x040015A2 RID: 5538
		[FieldOffset(12)]
		public float w;

		// Token: 0x0200005C RID: 92
		public sealed class DebuggerProxy : global::Il2CppSystem.Object
		{
			// Token: 0x060025FF RID: 9727 RVA: 0x000C3700 File Offset: 0x000C1900
			// Note: this type is marked as 'beforefieldinit'.
			static DebuggerProxy()
			{
				Il2CppClassPointerStore<float4.DebuggerProxy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<float4>.NativeClassPtr, "DebuggerProxy");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<float4.DebuggerProxy>.NativeClassPtr);
				float4.DebuggerProxy.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float4.DebuggerProxy>.NativeClassPtr, "x");
				float4.DebuggerProxy.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float4.DebuggerProxy>.NativeClassPtr, "y");
				float4.DebuggerProxy.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float4.DebuggerProxy>.NativeClassPtr, "z");
				float4.DebuggerProxy.NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float4.DebuggerProxy>.NativeClassPtr, "w");
				float4.DebuggerProxy.NativeMethodInfoPtr__ctor_Public_Void_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4.DebuggerProxy>.NativeClassPtr, 100668602);
			}

			// Token: 0x06002600 RID: 9728 RVA: 0x000C3790 File Offset: 0x000C1990
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637905, XrefRangeEnd = 637906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DebuggerProxy(float4 v)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<float4.DebuggerProxy>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4.DebuggerProxy.NativeMethodInfoPtr__ctor_Public_Void_float4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002601 RID: 9729 RVA: 0x00002E8C File Offset: 0x0000108C
			public DebuggerProxy(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C08 RID: 3080
			// (get) Token: 0x06002602 RID: 9730 RVA: 0x000C37D8 File Offset: 0x000C19D8
			// (set) Token: 0x06002603 RID: 9731 RVA: 0x00002E95 File Offset: 0x00001095
			public unsafe float x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(float4.DebuggerProxy.NativeFieldInfoPtr_x);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(float4.DebuggerProxy.NativeFieldInfoPtr_x)) = value;
				}
			}

			// Token: 0x17000C09 RID: 3081
			// (get) Token: 0x06002604 RID: 9732 RVA: 0x000C3800 File Offset: 0x000C1A00
			// (set) Token: 0x06002605 RID: 9733 RVA: 0x00002EB0 File Offset: 0x000010B0
			public unsafe float y
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(float4.DebuggerProxy.NativeFieldInfoPtr_y);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(float4.DebuggerProxy.NativeFieldInfoPtr_y)) = value;
				}
			}

			// Token: 0x17000C0A RID: 3082
			// (get) Token: 0x06002606 RID: 9734 RVA: 0x000C3828 File Offset: 0x000C1A28
			// (set) Token: 0x06002607 RID: 9735 RVA: 0x00002ECB File Offset: 0x000010CB
			public unsafe float z
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(float4.DebuggerProxy.NativeFieldInfoPtr_z);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(float4.DebuggerProxy.NativeFieldInfoPtr_z)) = value;
				}
			}

			// Token: 0x17000C0B RID: 3083
			// (get) Token: 0x06002608 RID: 9736 RVA: 0x000C3850 File Offset: 0x000C1A50
			// (set) Token: 0x06002609 RID: 9737 RVA: 0x00002EE6 File Offset: 0x000010E6
			public unsafe float w
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(float4.DebuggerProxy.NativeFieldInfoPtr_w);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(float4.DebuggerProxy.NativeFieldInfoPtr_w)) = value;
				}
			}

			// Token: 0x0400267B RID: 9851
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x0400267C RID: 9852
			private static readonly IntPtr NativeFieldInfoPtr_y;

			// Token: 0x0400267D RID: 9853
			private static readonly IntPtr NativeFieldInfoPtr_z;

			// Token: 0x0400267E RID: 9854
			private static readonly IntPtr NativeFieldInfoPtr_w;

			// Token: 0x0400267F RID: 9855
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float4_0;
		}
	}
}
