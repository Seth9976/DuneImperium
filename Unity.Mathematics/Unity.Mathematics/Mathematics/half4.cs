using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x0200002C RID: 44
	[Serializable]
	[StructLayout(2)]
	public struct half4
	{
		// Token: 0x06001732 RID: 5938 RVA: 0x0007B3E0 File Offset: 0x000795E0
		// Note: this type is marked as 'beforefieldinit'.
		static half4()
		{
			Il2CppClassPointerStore<half4>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "half4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<half4>.NativeClassPtr);
			half4.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<half4>.NativeClassPtr, "x");
			half4.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<half4>.NativeClassPtr, "y");
			half4.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<half4>.NativeClassPtr, "z");
			half4.NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<half4>.NativeClassPtr, "w");
			half4.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<half4>.NativeClassPtr, "zero");
			half4.NativeMethodInfoPtr__ctor_Public_Void_half_half_half_half_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669058);
			half4.NativeMethodInfoPtr__ctor_Public_Void_half_half_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669059);
			half4.NativeMethodInfoPtr__ctor_Public_Void_half_half2_half_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669060);
			half4.NativeMethodInfoPtr__ctor_Public_Void_half_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669061);
			half4.NativeMethodInfoPtr__ctor_Public_Void_half2_half_half_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669062);
			half4.NativeMethodInfoPtr__ctor_Public_Void_half2_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669063);
			half4.NativeMethodInfoPtr__ctor_Public_Void_half3_half_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669064);
			half4.NativeMethodInfoPtr__ctor_Public_Void_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669065);
			half4.NativeMethodInfoPtr__ctor_Public_Void_half_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669066);
			half4.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669067);
			half4.NativeMethodInfoPtr__ctor_Public_Void_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669068);
			half4.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669069);
			half4.NativeMethodInfoPtr__ctor_Public_Void_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669070);
			half4.NativeMethodInfoPtr_op_Implicit_Public_Static_half4_half_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669071);
			half4.NativeMethodInfoPtr_op_Explicit_Public_Static_half4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669072);
			half4.NativeMethodInfoPtr_op_Explicit_Public_Static_half4_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669073);
			half4.NativeMethodInfoPtr_op_Explicit_Public_Static_half4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669074);
			half4.NativeMethodInfoPtr_op_Explicit_Public_Static_half4_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669075);
			half4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4_half4_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669076);
			half4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4_half4_half_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669077);
			half4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4_half_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669078);
			half4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_half4_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669079);
			half4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_half4_half_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669080);
			half4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_half_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669081);
			half4.NativeMethodInfoPtr_get_xxxx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669082);
			half4.NativeMethodInfoPtr_get_xxxy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669083);
			half4.NativeMethodInfoPtr_get_xxxz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669084);
			half4.NativeMethodInfoPtr_get_xxxw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669085);
			half4.NativeMethodInfoPtr_get_xxyx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669086);
			half4.NativeMethodInfoPtr_get_xxyy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669087);
			half4.NativeMethodInfoPtr_get_xxyz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669088);
			half4.NativeMethodInfoPtr_get_xxyw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669089);
			half4.NativeMethodInfoPtr_get_xxzx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669090);
			half4.NativeMethodInfoPtr_get_xxzy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669091);
			half4.NativeMethodInfoPtr_get_xxzz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669092);
			half4.NativeMethodInfoPtr_get_xxzw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669093);
			half4.NativeMethodInfoPtr_get_xxwx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669094);
			half4.NativeMethodInfoPtr_get_xxwy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669095);
			half4.NativeMethodInfoPtr_get_xxwz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669096);
			half4.NativeMethodInfoPtr_get_xxww_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669097);
			half4.NativeMethodInfoPtr_get_xyxx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669098);
			half4.NativeMethodInfoPtr_get_xyxy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669099);
			half4.NativeMethodInfoPtr_get_xyxz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669100);
			half4.NativeMethodInfoPtr_get_xyxw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669101);
			half4.NativeMethodInfoPtr_get_xyyx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669102);
			half4.NativeMethodInfoPtr_get_xyyy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669103);
			half4.NativeMethodInfoPtr_get_xyyz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669104);
			half4.NativeMethodInfoPtr_get_xyyw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669105);
			half4.NativeMethodInfoPtr_get_xyzx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669106);
			half4.NativeMethodInfoPtr_get_xyzy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669107);
			half4.NativeMethodInfoPtr_get_xyzz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669108);
			half4.NativeMethodInfoPtr_get_xyzw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669109);
			half4.NativeMethodInfoPtr_set_xyzw_Public_set_Void_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669110);
			half4.NativeMethodInfoPtr_get_xywx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669111);
			half4.NativeMethodInfoPtr_get_xywy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669112);
			half4.NativeMethodInfoPtr_get_xywz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669113);
			half4.NativeMethodInfoPtr_set_xywz_Public_set_Void_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669114);
			half4.NativeMethodInfoPtr_get_xyww_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669115);
			half4.NativeMethodInfoPtr_get_xzxx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669116);
			half4.NativeMethodInfoPtr_get_xzxy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669117);
			half4.NativeMethodInfoPtr_get_xzxz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669118);
			half4.NativeMethodInfoPtr_get_xzxw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669119);
			half4.NativeMethodInfoPtr_get_xzyx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669120);
			half4.NativeMethodInfoPtr_get_xzyy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669121);
			half4.NativeMethodInfoPtr_get_xzyz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669122);
			half4.NativeMethodInfoPtr_get_xzyw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669123);
			half4.NativeMethodInfoPtr_set_xzyw_Public_set_Void_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669124);
			half4.NativeMethodInfoPtr_get_xzzx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669125);
			half4.NativeMethodInfoPtr_get_xzzy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669126);
			half4.NativeMethodInfoPtr_get_xzzz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669127);
			half4.NativeMethodInfoPtr_get_xzzw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669128);
			half4.NativeMethodInfoPtr_get_xzwx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669129);
			half4.NativeMethodInfoPtr_get_xzwy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669130);
			half4.NativeMethodInfoPtr_set_xzwy_Public_set_Void_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669131);
			half4.NativeMethodInfoPtr_get_xzwz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669132);
			half4.NativeMethodInfoPtr_get_xzww_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669133);
			half4.NativeMethodInfoPtr_get_xwxx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669134);
			half4.NativeMethodInfoPtr_get_xwxy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669135);
			half4.NativeMethodInfoPtr_get_xwxz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669136);
			half4.NativeMethodInfoPtr_get_xwxw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669137);
			half4.NativeMethodInfoPtr_get_xwyx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669138);
			half4.NativeMethodInfoPtr_get_xwyy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669139);
			half4.NativeMethodInfoPtr_get_xwyz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669140);
			half4.NativeMethodInfoPtr_set_xwyz_Public_set_Void_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669141);
			half4.NativeMethodInfoPtr_get_xwyw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669142);
			half4.NativeMethodInfoPtr_get_xwzx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669143);
			half4.NativeMethodInfoPtr_get_xwzy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669144);
			half4.NativeMethodInfoPtr_set_xwzy_Public_set_Void_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669145);
			half4.NativeMethodInfoPtr_get_xwzz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669146);
			half4.NativeMethodInfoPtr_get_xwzw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669147);
			half4.NativeMethodInfoPtr_get_xwwx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669148);
			half4.NativeMethodInfoPtr_get_xwwy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669149);
			half4.NativeMethodInfoPtr_get_xwwz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669150);
			half4.NativeMethodInfoPtr_get_xwww_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669151);
			half4.NativeMethodInfoPtr_get_yxxx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669152);
			half4.NativeMethodInfoPtr_get_yxxy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669153);
			half4.NativeMethodInfoPtr_get_yxxz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669154);
			half4.NativeMethodInfoPtr_get_yxxw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669155);
			half4.NativeMethodInfoPtr_get_yxyx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669156);
			half4.NativeMethodInfoPtr_get_yxyy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669157);
			half4.NativeMethodInfoPtr_get_yxyz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669158);
			half4.NativeMethodInfoPtr_get_yxyw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669159);
			half4.NativeMethodInfoPtr_get_yxzx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669160);
			half4.NativeMethodInfoPtr_get_yxzy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669161);
			half4.NativeMethodInfoPtr_get_yxzz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669162);
			half4.NativeMethodInfoPtr_get_yxzw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669163);
			half4.NativeMethodInfoPtr_set_yxzw_Public_set_Void_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669164);
			half4.NativeMethodInfoPtr_get_yxwx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669165);
			half4.NativeMethodInfoPtr_get_yxwy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669166);
			half4.NativeMethodInfoPtr_get_yxwz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669167);
			half4.NativeMethodInfoPtr_set_yxwz_Public_set_Void_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669168);
			half4.NativeMethodInfoPtr_get_yxww_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669169);
			half4.NativeMethodInfoPtr_get_yyxx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669170);
			half4.NativeMethodInfoPtr_get_yyxy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669171);
			half4.NativeMethodInfoPtr_get_yyxz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669172);
			half4.NativeMethodInfoPtr_get_yyxw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669173);
			half4.NativeMethodInfoPtr_get_yyyx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669174);
			half4.NativeMethodInfoPtr_get_yyyy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669175);
			half4.NativeMethodInfoPtr_get_yyyz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669176);
			half4.NativeMethodInfoPtr_get_yyyw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669177);
			half4.NativeMethodInfoPtr_get_yyzx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669178);
			half4.NativeMethodInfoPtr_get_yyzy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669179);
			half4.NativeMethodInfoPtr_get_yyzz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669180);
			half4.NativeMethodInfoPtr_get_yyzw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669181);
			half4.NativeMethodInfoPtr_get_yywx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669182);
			half4.NativeMethodInfoPtr_get_yywy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669183);
			half4.NativeMethodInfoPtr_get_yywz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669184);
			half4.NativeMethodInfoPtr_get_yyww_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669185);
			half4.NativeMethodInfoPtr_get_yzxx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669186);
			half4.NativeMethodInfoPtr_get_yzxy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669187);
			half4.NativeMethodInfoPtr_get_yzxz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669188);
			half4.NativeMethodInfoPtr_get_yzxw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669189);
			half4.NativeMethodInfoPtr_set_yzxw_Public_set_Void_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669190);
			half4.NativeMethodInfoPtr_get_yzyx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669191);
			half4.NativeMethodInfoPtr_get_yzyy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669192);
			half4.NativeMethodInfoPtr_get_yzyz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669193);
			half4.NativeMethodInfoPtr_get_yzyw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669194);
			half4.NativeMethodInfoPtr_get_yzzx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669195);
			half4.NativeMethodInfoPtr_get_yzzy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669196);
			half4.NativeMethodInfoPtr_get_yzzz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669197);
			half4.NativeMethodInfoPtr_get_yzzw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669198);
			half4.NativeMethodInfoPtr_get_yzwx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669199);
			half4.NativeMethodInfoPtr_set_yzwx_Public_set_Void_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669200);
			half4.NativeMethodInfoPtr_get_yzwy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669201);
			half4.NativeMethodInfoPtr_get_yzwz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669202);
			half4.NativeMethodInfoPtr_get_yzww_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669203);
			half4.NativeMethodInfoPtr_get_ywxx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669204);
			half4.NativeMethodInfoPtr_get_ywxy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669205);
			half4.NativeMethodInfoPtr_get_ywxz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669206);
			half4.NativeMethodInfoPtr_set_ywxz_Public_set_Void_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669207);
			half4.NativeMethodInfoPtr_get_ywxw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669208);
			half4.NativeMethodInfoPtr_get_ywyx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669209);
			half4.NativeMethodInfoPtr_get_ywyy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669210);
			half4.NativeMethodInfoPtr_get_ywyz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669211);
			half4.NativeMethodInfoPtr_get_ywyw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669212);
			half4.NativeMethodInfoPtr_get_ywzx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669213);
			half4.NativeMethodInfoPtr_set_ywzx_Public_set_Void_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669214);
			half4.NativeMethodInfoPtr_get_ywzy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669215);
			half4.NativeMethodInfoPtr_get_ywzz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669216);
			half4.NativeMethodInfoPtr_get_ywzw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669217);
			half4.NativeMethodInfoPtr_get_ywwx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669218);
			half4.NativeMethodInfoPtr_get_ywwy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669219);
			half4.NativeMethodInfoPtr_get_ywwz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669220);
			half4.NativeMethodInfoPtr_get_ywww_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669221);
			half4.NativeMethodInfoPtr_get_zxxx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669222);
			half4.NativeMethodInfoPtr_get_zxxy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669223);
			half4.NativeMethodInfoPtr_get_zxxz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669224);
			half4.NativeMethodInfoPtr_get_zxxw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669225);
			half4.NativeMethodInfoPtr_get_zxyx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669226);
			half4.NativeMethodInfoPtr_get_zxyy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669227);
			half4.NativeMethodInfoPtr_get_zxyz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669228);
			half4.NativeMethodInfoPtr_get_zxyw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669229);
			half4.NativeMethodInfoPtr_set_zxyw_Public_set_Void_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669230);
			half4.NativeMethodInfoPtr_get_zxzx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669231);
			half4.NativeMethodInfoPtr_get_zxzy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669232);
			half4.NativeMethodInfoPtr_get_zxzz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669233);
			half4.NativeMethodInfoPtr_get_zxzw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669234);
			half4.NativeMethodInfoPtr_get_zxwx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669235);
			half4.NativeMethodInfoPtr_get_zxwy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669236);
			half4.NativeMethodInfoPtr_set_zxwy_Public_set_Void_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669237);
			half4.NativeMethodInfoPtr_get_zxwz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669238);
			half4.NativeMethodInfoPtr_get_zxww_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669239);
			half4.NativeMethodInfoPtr_get_zyxx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669240);
			half4.NativeMethodInfoPtr_get_zyxy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669241);
			half4.NativeMethodInfoPtr_get_zyxz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669242);
			half4.NativeMethodInfoPtr_get_zyxw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669243);
			half4.NativeMethodInfoPtr_set_zyxw_Public_set_Void_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669244);
			half4.NativeMethodInfoPtr_get_zyyx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669245);
			half4.NativeMethodInfoPtr_get_zyyy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669246);
			half4.NativeMethodInfoPtr_get_zyyz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669247);
			half4.NativeMethodInfoPtr_get_zyyw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669248);
			half4.NativeMethodInfoPtr_get_zyzx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669249);
			half4.NativeMethodInfoPtr_get_zyzy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669250);
			half4.NativeMethodInfoPtr_get_zyzz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669251);
			half4.NativeMethodInfoPtr_get_zyzw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669252);
			half4.NativeMethodInfoPtr_get_zywx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669253);
			half4.NativeMethodInfoPtr_set_zywx_Public_set_Void_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669254);
			half4.NativeMethodInfoPtr_get_zywy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669255);
			half4.NativeMethodInfoPtr_get_zywz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669256);
			half4.NativeMethodInfoPtr_get_zyww_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669257);
			half4.NativeMethodInfoPtr_get_zzxx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669258);
			half4.NativeMethodInfoPtr_get_zzxy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669259);
			half4.NativeMethodInfoPtr_get_zzxz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669260);
			half4.NativeMethodInfoPtr_get_zzxw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669261);
			half4.NativeMethodInfoPtr_get_zzyx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669262);
			half4.NativeMethodInfoPtr_get_zzyy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669263);
			half4.NativeMethodInfoPtr_get_zzyz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669264);
			half4.NativeMethodInfoPtr_get_zzyw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669265);
			half4.NativeMethodInfoPtr_get_zzzx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669266);
			half4.NativeMethodInfoPtr_get_zzzy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669267);
			half4.NativeMethodInfoPtr_get_zzzz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669268);
			half4.NativeMethodInfoPtr_get_zzzw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669269);
			half4.NativeMethodInfoPtr_get_zzwx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669270);
			half4.NativeMethodInfoPtr_get_zzwy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669271);
			half4.NativeMethodInfoPtr_get_zzwz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669272);
			half4.NativeMethodInfoPtr_get_zzww_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669273);
			half4.NativeMethodInfoPtr_get_zwxx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669274);
			half4.NativeMethodInfoPtr_get_zwxy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669275);
			half4.NativeMethodInfoPtr_set_zwxy_Public_set_Void_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669276);
			half4.NativeMethodInfoPtr_get_zwxz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669277);
			half4.NativeMethodInfoPtr_get_zwxw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669278);
			half4.NativeMethodInfoPtr_get_zwyx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669279);
			half4.NativeMethodInfoPtr_set_zwyx_Public_set_Void_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669280);
			half4.NativeMethodInfoPtr_get_zwyy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669281);
			half4.NativeMethodInfoPtr_get_zwyz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669282);
			half4.NativeMethodInfoPtr_get_zwyw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669283);
			half4.NativeMethodInfoPtr_get_zwzx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669284);
			half4.NativeMethodInfoPtr_get_zwzy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669285);
			half4.NativeMethodInfoPtr_get_zwzz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669286);
			half4.NativeMethodInfoPtr_get_zwzw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669287);
			half4.NativeMethodInfoPtr_get_zwwx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669288);
			half4.NativeMethodInfoPtr_get_zwwy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669289);
			half4.NativeMethodInfoPtr_get_zwwz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669290);
			half4.NativeMethodInfoPtr_get_zwww_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669291);
			half4.NativeMethodInfoPtr_get_wxxx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669292);
			half4.NativeMethodInfoPtr_get_wxxy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669293);
			half4.NativeMethodInfoPtr_get_wxxz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669294);
			half4.NativeMethodInfoPtr_get_wxxw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669295);
			half4.NativeMethodInfoPtr_get_wxyx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669296);
			half4.NativeMethodInfoPtr_get_wxyy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669297);
			half4.NativeMethodInfoPtr_get_wxyz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669298);
			half4.NativeMethodInfoPtr_set_wxyz_Public_set_Void_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669299);
			half4.NativeMethodInfoPtr_get_wxyw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669300);
			half4.NativeMethodInfoPtr_get_wxzx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669301);
			half4.NativeMethodInfoPtr_get_wxzy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669302);
			half4.NativeMethodInfoPtr_set_wxzy_Public_set_Void_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669303);
			half4.NativeMethodInfoPtr_get_wxzz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669304);
			half4.NativeMethodInfoPtr_get_wxzw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669305);
			half4.NativeMethodInfoPtr_get_wxwx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669306);
			half4.NativeMethodInfoPtr_get_wxwy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669307);
			half4.NativeMethodInfoPtr_get_wxwz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669308);
			half4.NativeMethodInfoPtr_get_wxww_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669309);
			half4.NativeMethodInfoPtr_get_wyxx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669310);
			half4.NativeMethodInfoPtr_get_wyxy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669311);
			half4.NativeMethodInfoPtr_get_wyxz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669312);
			half4.NativeMethodInfoPtr_set_wyxz_Public_set_Void_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669313);
			half4.NativeMethodInfoPtr_get_wyxw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669314);
			half4.NativeMethodInfoPtr_get_wyyx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669315);
			half4.NativeMethodInfoPtr_get_wyyy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669316);
			half4.NativeMethodInfoPtr_get_wyyz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669317);
			half4.NativeMethodInfoPtr_get_wyyw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669318);
			half4.NativeMethodInfoPtr_get_wyzx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669319);
			half4.NativeMethodInfoPtr_set_wyzx_Public_set_Void_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669320);
			half4.NativeMethodInfoPtr_get_wyzy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669321);
			half4.NativeMethodInfoPtr_get_wyzz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669322);
			half4.NativeMethodInfoPtr_get_wyzw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669323);
			half4.NativeMethodInfoPtr_get_wywx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669324);
			half4.NativeMethodInfoPtr_get_wywy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669325);
			half4.NativeMethodInfoPtr_get_wywz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669326);
			half4.NativeMethodInfoPtr_get_wyww_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669327);
			half4.NativeMethodInfoPtr_get_wzxx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669328);
			half4.NativeMethodInfoPtr_get_wzxy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669329);
			half4.NativeMethodInfoPtr_set_wzxy_Public_set_Void_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669330);
			half4.NativeMethodInfoPtr_get_wzxz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669331);
			half4.NativeMethodInfoPtr_get_wzxw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669332);
			half4.NativeMethodInfoPtr_get_wzyx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669333);
			half4.NativeMethodInfoPtr_set_wzyx_Public_set_Void_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669334);
			half4.NativeMethodInfoPtr_get_wzyy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669335);
			half4.NativeMethodInfoPtr_get_wzyz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669336);
			half4.NativeMethodInfoPtr_get_wzyw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669337);
			half4.NativeMethodInfoPtr_get_wzzx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669338);
			half4.NativeMethodInfoPtr_get_wzzy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669339);
			half4.NativeMethodInfoPtr_get_wzzz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669340);
			half4.NativeMethodInfoPtr_get_wzzw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669341);
			half4.NativeMethodInfoPtr_get_wzwx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669342);
			half4.NativeMethodInfoPtr_get_wzwy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669343);
			half4.NativeMethodInfoPtr_get_wzwz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669344);
			half4.NativeMethodInfoPtr_get_wzww_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669345);
			half4.NativeMethodInfoPtr_get_wwxx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669346);
			half4.NativeMethodInfoPtr_get_wwxy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669347);
			half4.NativeMethodInfoPtr_get_wwxz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669348);
			half4.NativeMethodInfoPtr_get_wwxw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669349);
			half4.NativeMethodInfoPtr_get_wwyx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669350);
			half4.NativeMethodInfoPtr_get_wwyy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669351);
			half4.NativeMethodInfoPtr_get_wwyz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669352);
			half4.NativeMethodInfoPtr_get_wwyw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669353);
			half4.NativeMethodInfoPtr_get_wwzx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669354);
			half4.NativeMethodInfoPtr_get_wwzy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669355);
			half4.NativeMethodInfoPtr_get_wwzz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669356);
			half4.NativeMethodInfoPtr_get_wwzw_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669357);
			half4.NativeMethodInfoPtr_get_wwwx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669358);
			half4.NativeMethodInfoPtr_get_wwwy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669359);
			half4.NativeMethodInfoPtr_get_wwwz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669360);
			half4.NativeMethodInfoPtr_get_wwww_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669361);
			half4.NativeMethodInfoPtr_get_xxx_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669362);
			half4.NativeMethodInfoPtr_get_xxy_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669363);
			half4.NativeMethodInfoPtr_get_xxz_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669364);
			half4.NativeMethodInfoPtr_get_xxw_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669365);
			half4.NativeMethodInfoPtr_get_xyx_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669366);
			half4.NativeMethodInfoPtr_get_xyy_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669367);
			half4.NativeMethodInfoPtr_get_xyz_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669368);
			half4.NativeMethodInfoPtr_set_xyz_Public_set_Void_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669369);
			half4.NativeMethodInfoPtr_get_xyw_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669370);
			half4.NativeMethodInfoPtr_set_xyw_Public_set_Void_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669371);
			half4.NativeMethodInfoPtr_get_xzx_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669372);
			half4.NativeMethodInfoPtr_get_xzy_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669373);
			half4.NativeMethodInfoPtr_set_xzy_Public_set_Void_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669374);
			half4.NativeMethodInfoPtr_get_xzz_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669375);
			half4.NativeMethodInfoPtr_get_xzw_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669376);
			half4.NativeMethodInfoPtr_set_xzw_Public_set_Void_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669377);
			half4.NativeMethodInfoPtr_get_xwx_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669378);
			half4.NativeMethodInfoPtr_get_xwy_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669379);
			half4.NativeMethodInfoPtr_set_xwy_Public_set_Void_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669380);
			half4.NativeMethodInfoPtr_get_xwz_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669381);
			half4.NativeMethodInfoPtr_set_xwz_Public_set_Void_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669382);
			half4.NativeMethodInfoPtr_get_xww_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669383);
			half4.NativeMethodInfoPtr_get_yxx_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669384);
			half4.NativeMethodInfoPtr_get_yxy_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669385);
			half4.NativeMethodInfoPtr_get_yxz_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669386);
			half4.NativeMethodInfoPtr_set_yxz_Public_set_Void_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669387);
			half4.NativeMethodInfoPtr_get_yxw_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669388);
			half4.NativeMethodInfoPtr_set_yxw_Public_set_Void_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669389);
			half4.NativeMethodInfoPtr_get_yyx_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669390);
			half4.NativeMethodInfoPtr_get_yyy_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669391);
			half4.NativeMethodInfoPtr_get_yyz_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669392);
			half4.NativeMethodInfoPtr_get_yyw_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669393);
			half4.NativeMethodInfoPtr_get_yzx_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669394);
			half4.NativeMethodInfoPtr_set_yzx_Public_set_Void_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669395);
			half4.NativeMethodInfoPtr_get_yzy_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669396);
			half4.NativeMethodInfoPtr_get_yzz_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669397);
			half4.NativeMethodInfoPtr_get_yzw_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669398);
			half4.NativeMethodInfoPtr_set_yzw_Public_set_Void_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669399);
			half4.NativeMethodInfoPtr_get_ywx_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669400);
			half4.NativeMethodInfoPtr_set_ywx_Public_set_Void_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669401);
			half4.NativeMethodInfoPtr_get_ywy_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669402);
			half4.NativeMethodInfoPtr_get_ywz_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669403);
			half4.NativeMethodInfoPtr_set_ywz_Public_set_Void_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669404);
			half4.NativeMethodInfoPtr_get_yww_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669405);
			half4.NativeMethodInfoPtr_get_zxx_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669406);
			half4.NativeMethodInfoPtr_get_zxy_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669407);
			half4.NativeMethodInfoPtr_set_zxy_Public_set_Void_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669408);
			half4.NativeMethodInfoPtr_get_zxz_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669409);
			half4.NativeMethodInfoPtr_get_zxw_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669410);
			half4.NativeMethodInfoPtr_set_zxw_Public_set_Void_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669411);
			half4.NativeMethodInfoPtr_get_zyx_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669412);
			half4.NativeMethodInfoPtr_set_zyx_Public_set_Void_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669413);
			half4.NativeMethodInfoPtr_get_zyy_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669414);
			half4.NativeMethodInfoPtr_get_zyz_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669415);
			half4.NativeMethodInfoPtr_get_zyw_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669416);
			half4.NativeMethodInfoPtr_set_zyw_Public_set_Void_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669417);
			half4.NativeMethodInfoPtr_get_zzx_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669418);
			half4.NativeMethodInfoPtr_get_zzy_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669419);
			half4.NativeMethodInfoPtr_get_zzz_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669420);
			half4.NativeMethodInfoPtr_get_zzw_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669421);
			half4.NativeMethodInfoPtr_get_zwx_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669422);
			half4.NativeMethodInfoPtr_set_zwx_Public_set_Void_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669423);
			half4.NativeMethodInfoPtr_get_zwy_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669424);
			half4.NativeMethodInfoPtr_set_zwy_Public_set_Void_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669425);
			half4.NativeMethodInfoPtr_get_zwz_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669426);
			half4.NativeMethodInfoPtr_get_zww_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669427);
			half4.NativeMethodInfoPtr_get_wxx_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669428);
			half4.NativeMethodInfoPtr_get_wxy_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669429);
			half4.NativeMethodInfoPtr_set_wxy_Public_set_Void_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669430);
			half4.NativeMethodInfoPtr_get_wxz_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669431);
			half4.NativeMethodInfoPtr_set_wxz_Public_set_Void_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669432);
			half4.NativeMethodInfoPtr_get_wxw_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669433);
			half4.NativeMethodInfoPtr_get_wyx_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669434);
			half4.NativeMethodInfoPtr_set_wyx_Public_set_Void_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669435);
			half4.NativeMethodInfoPtr_get_wyy_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669436);
			half4.NativeMethodInfoPtr_get_wyz_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669437);
			half4.NativeMethodInfoPtr_set_wyz_Public_set_Void_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669438);
			half4.NativeMethodInfoPtr_get_wyw_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669439);
			half4.NativeMethodInfoPtr_get_wzx_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669440);
			half4.NativeMethodInfoPtr_set_wzx_Public_set_Void_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669441);
			half4.NativeMethodInfoPtr_get_wzy_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669442);
			half4.NativeMethodInfoPtr_set_wzy_Public_set_Void_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669443);
			half4.NativeMethodInfoPtr_get_wzz_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669444);
			half4.NativeMethodInfoPtr_get_wzw_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669445);
			half4.NativeMethodInfoPtr_get_wwx_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669446);
			half4.NativeMethodInfoPtr_get_wwy_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669447);
			half4.NativeMethodInfoPtr_get_wwz_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669448);
			half4.NativeMethodInfoPtr_get_www_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669449);
			half4.NativeMethodInfoPtr_get_xx_Public_get_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669450);
			half4.NativeMethodInfoPtr_get_xy_Public_get_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669451);
			half4.NativeMethodInfoPtr_set_xy_Public_set_Void_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669452);
			half4.NativeMethodInfoPtr_get_xz_Public_get_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669453);
			half4.NativeMethodInfoPtr_set_xz_Public_set_Void_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669454);
			half4.NativeMethodInfoPtr_get_xw_Public_get_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669455);
			half4.NativeMethodInfoPtr_set_xw_Public_set_Void_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669456);
			half4.NativeMethodInfoPtr_get_yx_Public_get_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669457);
			half4.NativeMethodInfoPtr_set_yx_Public_set_Void_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669458);
			half4.NativeMethodInfoPtr_get_yy_Public_get_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669459);
			half4.NativeMethodInfoPtr_get_yz_Public_get_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669460);
			half4.NativeMethodInfoPtr_set_yz_Public_set_Void_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669461);
			half4.NativeMethodInfoPtr_get_yw_Public_get_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669462);
			half4.NativeMethodInfoPtr_set_yw_Public_set_Void_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669463);
			half4.NativeMethodInfoPtr_get_zx_Public_get_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669464);
			half4.NativeMethodInfoPtr_set_zx_Public_set_Void_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669465);
			half4.NativeMethodInfoPtr_get_zy_Public_get_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669466);
			half4.NativeMethodInfoPtr_set_zy_Public_set_Void_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669467);
			half4.NativeMethodInfoPtr_get_zz_Public_get_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669468);
			half4.NativeMethodInfoPtr_get_zw_Public_get_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669469);
			half4.NativeMethodInfoPtr_set_zw_Public_set_Void_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669470);
			half4.NativeMethodInfoPtr_get_wx_Public_get_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669471);
			half4.NativeMethodInfoPtr_set_wx_Public_set_Void_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669472);
			half4.NativeMethodInfoPtr_get_wy_Public_get_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669473);
			half4.NativeMethodInfoPtr_set_wy_Public_set_Void_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669474);
			half4.NativeMethodInfoPtr_get_wz_Public_get_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669475);
			half4.NativeMethodInfoPtr_set_wz_Public_set_Void_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669476);
			half4.NativeMethodInfoPtr_get_ww_Public_get_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669477);
			half4.NativeMethodInfoPtr_get_Item_Public_get_half_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669478);
			half4.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_half_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669479);
			half4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669480);
			half4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669481);
			half4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669482);
			half4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669483);
			half4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4>.NativeClassPtr, 100669484);
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x0007D5D0 File Offset: 0x0007B7D0
		[CallerCount(0)]
		public unsafe half4(half x, half y, half z, half w)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr__ctor_Public_Void_half_half_half_half_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x0007D62C File Offset: 0x0007B82C
		[CallerCount(0)]
		public unsafe half4(half x, half y, half2 zw)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr__ctor_Public_Void_half_half_half2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x0007D67C File Offset: 0x0007B87C
		[CallerCount(0)]
		public unsafe half4(half x, half2 yz, half w)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr__ctor_Public_Void_half_half2_half_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001736 RID: 5942 RVA: 0x0007D6CC File Offset: 0x0007B8CC
		[CallerCount(0)]
		public unsafe half4(half x, half3 yzw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yzw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr__ctor_Public_Void_half_half3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x0007D70C File Offset: 0x0007B90C
		[CallerCount(0)]
		public unsafe half4(half2 xy, half z, half w)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr__ctor_Public_Void_half2_half_half_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001738 RID: 5944 RVA: 0x0007D75C File Offset: 0x0007B95C
		[CallerCount(0)]
		public unsafe half4(half2 xy, half2 zw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xy;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr__ctor_Public_Void_half2_half2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001739 RID: 5945 RVA: 0x0007D79C File Offset: 0x0007B99C
		[CallerCount(0)]
		public unsafe half4(half3 xyz, half w)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr__ctor_Public_Void_half3_half_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600173A RID: 5946 RVA: 0x0007D7DC File Offset: 0x0007B9DC
		[CallerCount(0)]
		public unsafe half4(half4 xyzw)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyzw;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr__ctor_Public_Void_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600173B RID: 5947 RVA: 0x0007D810 File Offset: 0x0007BA10
		[CallerCount(0)]
		public unsafe half4(half v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr__ctor_Public_Void_half_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600173C RID: 5948 RVA: 0x0007D844 File Offset: 0x0007BA44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639071, XrefRangeEnd = 639075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe half4(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600173D RID: 5949 RVA: 0x0007D878 File Offset: 0x0007BA78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639075, XrefRangeEnd = 639079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe half4(float4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr__ctor_Public_Void_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600173E RID: 5950 RVA: 0x0007D8AC File Offset: 0x0007BAAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639079, XrefRangeEnd = 639083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe half4(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600173F RID: 5951 RVA: 0x0007D8E0 File Offset: 0x0007BAE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639083, XrefRangeEnd = 639087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe half4(double4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr__ctor_Public_Void_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001740 RID: 5952 RVA: 0x0007D914 File Offset: 0x0007BB14
		[CallerCount(0)]
		public unsafe static implicit operator half4(half v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_op_Implicit_Public_Static_half4_half_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001741 RID: 5953 RVA: 0x0007D954 File Offset: 0x0007BB54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator half4(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_op_Explicit_Public_Static_half4_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001742 RID: 5954 RVA: 0x0007D994 File Offset: 0x0007BB94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator half4(float4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_op_Explicit_Public_Static_half4_float4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001743 RID: 5955 RVA: 0x0007D9D4 File Offset: 0x0007BBD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator half4(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_op_Explicit_Public_Static_half4_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001744 RID: 5956 RVA: 0x0007DA14 File Offset: 0x0007BC14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator half4(double4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_op_Explicit_Public_Static_half4_double4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x0007DA54 File Offset: 0x0007BC54
		[CallerCount(0)]
		public unsafe static bool4 operator ==(half4 lhs, half4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4_half4_half4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x0007DAA0 File Offset: 0x0007BCA0
		[CallerCount(0)]
		public unsafe static bool4 operator ==(half4 lhs, half rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4_half4_half_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x0007DAEC File Offset: 0x0007BCEC
		[CallerCount(0)]
		public unsafe static bool4 operator ==(half lhs, half4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4_half_half4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x0007DB38 File Offset: 0x0007BD38
		[CallerCount(0)]
		public unsafe static bool4 operator !=(half4 lhs, half4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_half4_half4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001749 RID: 5961 RVA: 0x0007DB84 File Offset: 0x0007BD84
		[CallerCount(0)]
		public unsafe static bool4 operator !=(half4 lhs, half rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_half4_half_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600174A RID: 5962 RVA: 0x0007DBD0 File Offset: 0x0007BDD0
		[CallerCount(0)]
		public unsafe static bool4 operator !=(half lhs, half4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_half_half4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x0600174B RID: 5963 RVA: 0x0007DC1C File Offset: 0x0007BE1C
		public unsafe half4 xxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xxxx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x0600174C RID: 5964 RVA: 0x0007DC4C File Offset: 0x0007BE4C
		public unsafe half4 xxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xxxy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x0600174D RID: 5965 RVA: 0x0007DC7C File Offset: 0x0007BE7C
		public unsafe half4 xxxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xxxz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x0600174E RID: 5966 RVA: 0x0007DCAC File Offset: 0x0007BEAC
		public unsafe half4 xxxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xxxw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x0600174F RID: 5967 RVA: 0x0007DCDC File Offset: 0x0007BEDC
		public unsafe half4 xxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xxyx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06001750 RID: 5968 RVA: 0x0007DD0C File Offset: 0x0007BF0C
		public unsafe half4 xxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xxyy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06001751 RID: 5969 RVA: 0x0007DD3C File Offset: 0x0007BF3C
		public unsafe half4 xxyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xxyz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06001752 RID: 5970 RVA: 0x0007DD6C File Offset: 0x0007BF6C
		public unsafe half4 xxyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xxyw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06001753 RID: 5971 RVA: 0x0007DD9C File Offset: 0x0007BF9C
		public unsafe half4 xxzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xxzx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06001754 RID: 5972 RVA: 0x0007DDCC File Offset: 0x0007BFCC
		public unsafe half4 xxzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xxzy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06001755 RID: 5973 RVA: 0x0007DDFC File Offset: 0x0007BFFC
		public unsafe half4 xxzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xxzz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06001756 RID: 5974 RVA: 0x0007DE2C File Offset: 0x0007C02C
		public unsafe half4 xxzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xxzw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06001757 RID: 5975 RVA: 0x0007DE5C File Offset: 0x0007C05C
		public unsafe half4 xxwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xxwx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06001758 RID: 5976 RVA: 0x0007DE8C File Offset: 0x0007C08C
		public unsafe half4 xxwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xxwy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06001759 RID: 5977 RVA: 0x0007DEBC File Offset: 0x0007C0BC
		public unsafe half4 xxwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xxwz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x0600175A RID: 5978 RVA: 0x0007DEEC File Offset: 0x0007C0EC
		public unsafe half4 xxww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xxww_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x0600175B RID: 5979 RVA: 0x0007DF1C File Offset: 0x0007C11C
		public unsafe half4 xyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xyxx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x0600175C RID: 5980 RVA: 0x0007DF4C File Offset: 0x0007C14C
		public unsafe half4 xyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xyxy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x0600175D RID: 5981 RVA: 0x0007DF7C File Offset: 0x0007C17C
		public unsafe half4 xyxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xyxz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x0600175E RID: 5982 RVA: 0x0007DFAC File Offset: 0x0007C1AC
		public unsafe half4 xyxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xyxw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x0600175F RID: 5983 RVA: 0x0007DFDC File Offset: 0x0007C1DC
		public unsafe half4 xyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xyyx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06001760 RID: 5984 RVA: 0x0007E00C File Offset: 0x0007C20C
		public unsafe half4 xyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xyyy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06001761 RID: 5985 RVA: 0x0007E03C File Offset: 0x0007C23C
		public unsafe half4 xyyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xyyz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06001762 RID: 5986 RVA: 0x0007E06C File Offset: 0x0007C26C
		public unsafe half4 xyyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xyyw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06001763 RID: 5987 RVA: 0x0007E09C File Offset: 0x0007C29C
		public unsafe half4 xyzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xyzx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06001764 RID: 5988 RVA: 0x0007E0CC File Offset: 0x0007C2CC
		public unsafe half4 xyzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xyzy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06001765 RID: 5989 RVA: 0x0007E0FC File Offset: 0x0007C2FC
		public unsafe half4 xyzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xyzz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06001766 RID: 5990 RVA: 0x0007E12C File Offset: 0x0007C32C
		// (set) Token: 0x06001767 RID: 5991 RVA: 0x0007E15C File Offset: 0x0007C35C
		public unsafe half4 xyzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xyzw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_xyzw_Public_set_Void_half4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06001768 RID: 5992 RVA: 0x0007E190 File Offset: 0x0007C390
		public unsafe half4 xywx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xywx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06001769 RID: 5993 RVA: 0x0007E1C0 File Offset: 0x0007C3C0
		public unsafe half4 xywy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xywy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x0600176A RID: 5994 RVA: 0x0007E1F0 File Offset: 0x0007C3F0
		// (set) Token: 0x0600176B RID: 5995 RVA: 0x0007E220 File Offset: 0x0007C420
		public unsafe half4 xywz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xywz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_xywz_Public_set_Void_half4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x0600176C RID: 5996 RVA: 0x0007E254 File Offset: 0x0007C454
		public unsafe half4 xyww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xyww_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x0600176D RID: 5997 RVA: 0x0007E284 File Offset: 0x0007C484
		public unsafe half4 xzxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xzxx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x0600176E RID: 5998 RVA: 0x0007E2B4 File Offset: 0x0007C4B4
		public unsafe half4 xzxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xzxy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x0600176F RID: 5999 RVA: 0x0007E2E4 File Offset: 0x0007C4E4
		public unsafe half4 xzxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xzxz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06001770 RID: 6000 RVA: 0x0007E314 File Offset: 0x0007C514
		public unsafe half4 xzxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xzxw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x06001771 RID: 6001 RVA: 0x0007E344 File Offset: 0x0007C544
		public unsafe half4 xzyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xzyx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06001772 RID: 6002 RVA: 0x0007E374 File Offset: 0x0007C574
		public unsafe half4 xzyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xzyy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06001773 RID: 6003 RVA: 0x0007E3A4 File Offset: 0x0007C5A4
		public unsafe half4 xzyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xzyz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06001774 RID: 6004 RVA: 0x0007E3D4 File Offset: 0x0007C5D4
		// (set) Token: 0x06001775 RID: 6005 RVA: 0x0007E404 File Offset: 0x0007C604
		public unsafe half4 xzyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xzyw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_xzyw_Public_set_Void_half4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06001776 RID: 6006 RVA: 0x0007E438 File Offset: 0x0007C638
		public unsafe half4 xzzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xzzx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06001777 RID: 6007 RVA: 0x0007E468 File Offset: 0x0007C668
		public unsafe half4 xzzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xzzy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06001778 RID: 6008 RVA: 0x0007E498 File Offset: 0x0007C698
		public unsafe half4 xzzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xzzz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06001779 RID: 6009 RVA: 0x0007E4C8 File Offset: 0x0007C6C8
		public unsafe half4 xzzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xzzw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x0600177A RID: 6010 RVA: 0x0007E4F8 File Offset: 0x0007C6F8
		public unsafe half4 xzwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xzwx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x0600177B RID: 6011 RVA: 0x0007E528 File Offset: 0x0007C728
		// (set) Token: 0x0600177C RID: 6012 RVA: 0x0007E558 File Offset: 0x0007C758
		public unsafe half4 xzwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xzwy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_xzwy_Public_set_Void_half4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x0600177D RID: 6013 RVA: 0x0007E58C File Offset: 0x0007C78C
		public unsafe half4 xzwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xzwz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x0600177E RID: 6014 RVA: 0x0007E5BC File Offset: 0x0007C7BC
		public unsafe half4 xzww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xzww_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x0600177F RID: 6015 RVA: 0x0007E5EC File Offset: 0x0007C7EC
		public unsafe half4 xwxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xwxx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x06001780 RID: 6016 RVA: 0x0007E61C File Offset: 0x0007C81C
		public unsafe half4 xwxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xwxy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06001781 RID: 6017 RVA: 0x0007E64C File Offset: 0x0007C84C
		public unsafe half4 xwxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xwxz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06001782 RID: 6018 RVA: 0x0007E67C File Offset: 0x0007C87C
		public unsafe half4 xwxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xwxw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x06001783 RID: 6019 RVA: 0x0007E6AC File Offset: 0x0007C8AC
		public unsafe half4 xwyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xwyx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x06001784 RID: 6020 RVA: 0x0007E6DC File Offset: 0x0007C8DC
		public unsafe half4 xwyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xwyy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x06001785 RID: 6021 RVA: 0x0007E70C File Offset: 0x0007C90C
		// (set) Token: 0x06001786 RID: 6022 RVA: 0x0007E73C File Offset: 0x0007C93C
		public unsafe half4 xwyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xwyz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_xwyz_Public_set_Void_half4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x06001787 RID: 6023 RVA: 0x0007E770 File Offset: 0x0007C970
		public unsafe half4 xwyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xwyw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x06001788 RID: 6024 RVA: 0x0007E7A0 File Offset: 0x0007C9A0
		public unsafe half4 xwzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xwzx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06001789 RID: 6025 RVA: 0x0007E7D0 File Offset: 0x0007C9D0
		// (set) Token: 0x0600178A RID: 6026 RVA: 0x0007E800 File Offset: 0x0007CA00
		public unsafe half4 xwzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xwzy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_xwzy_Public_set_Void_half4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x0600178B RID: 6027 RVA: 0x0007E834 File Offset: 0x0007CA34
		public unsafe half4 xwzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xwzz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x0600178C RID: 6028 RVA: 0x0007E864 File Offset: 0x0007CA64
		public unsafe half4 xwzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xwzw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x0600178D RID: 6029 RVA: 0x0007E894 File Offset: 0x0007CA94
		public unsafe half4 xwwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xwwx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x0600178E RID: 6030 RVA: 0x0007E8C4 File Offset: 0x0007CAC4
		public unsafe half4 xwwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xwwy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x0600178F RID: 6031 RVA: 0x0007E8F4 File Offset: 0x0007CAF4
		public unsafe half4 xwwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xwwz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x06001790 RID: 6032 RVA: 0x0007E924 File Offset: 0x0007CB24
		public unsafe half4 xwww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xwww_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06001791 RID: 6033 RVA: 0x0007E954 File Offset: 0x0007CB54
		public unsafe half4 yxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yxxx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06001792 RID: 6034 RVA: 0x0007E984 File Offset: 0x0007CB84
		public unsafe half4 yxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yxxy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06001793 RID: 6035 RVA: 0x0007E9B4 File Offset: 0x0007CBB4
		public unsafe half4 yxxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yxxz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06001794 RID: 6036 RVA: 0x0007E9E4 File Offset: 0x0007CBE4
		public unsafe half4 yxxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yxxw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x06001795 RID: 6037 RVA: 0x0007EA14 File Offset: 0x0007CC14
		public unsafe half4 yxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yxyx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x06001796 RID: 6038 RVA: 0x0007EA44 File Offset: 0x0007CC44
		public unsafe half4 yxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yxyy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x06001797 RID: 6039 RVA: 0x0007EA74 File Offset: 0x0007CC74
		public unsafe half4 yxyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yxyz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x06001798 RID: 6040 RVA: 0x0007EAA4 File Offset: 0x0007CCA4
		public unsafe half4 yxyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yxyw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x06001799 RID: 6041 RVA: 0x0007EAD4 File Offset: 0x0007CCD4
		public unsafe half4 yxzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yxzx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x0600179A RID: 6042 RVA: 0x0007EB04 File Offset: 0x0007CD04
		public unsafe half4 yxzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yxzy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x0600179B RID: 6043 RVA: 0x0007EB34 File Offset: 0x0007CD34
		public unsafe half4 yxzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yxzz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x0600179C RID: 6044 RVA: 0x0007EB64 File Offset: 0x0007CD64
		// (set) Token: 0x0600179D RID: 6045 RVA: 0x0007EB94 File Offset: 0x0007CD94
		public unsafe half4 yxzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yxzw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_yxzw_Public_set_Void_half4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x0600179E RID: 6046 RVA: 0x0007EBC8 File Offset: 0x0007CDC8
		public unsafe half4 yxwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yxwx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x0600179F RID: 6047 RVA: 0x0007EBF8 File Offset: 0x0007CDF8
		public unsafe half4 yxwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yxwy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x060017A0 RID: 6048 RVA: 0x0007EC28 File Offset: 0x0007CE28
		// (set) Token: 0x060017A1 RID: 6049 RVA: 0x0007EC58 File Offset: 0x0007CE58
		public unsafe half4 yxwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yxwz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_yxwz_Public_set_Void_half4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x060017A2 RID: 6050 RVA: 0x0007EC8C File Offset: 0x0007CE8C
		public unsafe half4 yxww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yxww_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x060017A3 RID: 6051 RVA: 0x0007ECBC File Offset: 0x0007CEBC
		public unsafe half4 yyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yyxx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x060017A4 RID: 6052 RVA: 0x0007ECEC File Offset: 0x0007CEEC
		public unsafe half4 yyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yyxy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x060017A5 RID: 6053 RVA: 0x0007ED1C File Offset: 0x0007CF1C
		public unsafe half4 yyxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yyxz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x060017A6 RID: 6054 RVA: 0x0007ED4C File Offset: 0x0007CF4C
		public unsafe half4 yyxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yyxw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x060017A7 RID: 6055 RVA: 0x0007ED7C File Offset: 0x0007CF7C
		public unsafe half4 yyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yyyx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x060017A8 RID: 6056 RVA: 0x0007EDAC File Offset: 0x0007CFAC
		public unsafe half4 yyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yyyy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x060017A9 RID: 6057 RVA: 0x0007EDDC File Offset: 0x0007CFDC
		public unsafe half4 yyyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yyyz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x060017AA RID: 6058 RVA: 0x0007EE0C File Offset: 0x0007D00C
		public unsafe half4 yyyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yyyw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x060017AB RID: 6059 RVA: 0x0007EE3C File Offset: 0x0007D03C
		public unsafe half4 yyzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yyzx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x060017AC RID: 6060 RVA: 0x0007EE6C File Offset: 0x0007D06C
		public unsafe half4 yyzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yyzy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x060017AD RID: 6061 RVA: 0x0007EE9C File Offset: 0x0007D09C
		public unsafe half4 yyzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yyzz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x060017AE RID: 6062 RVA: 0x0007EECC File Offset: 0x0007D0CC
		public unsafe half4 yyzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yyzw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x060017AF RID: 6063 RVA: 0x0007EEFC File Offset: 0x0007D0FC
		public unsafe half4 yywx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yywx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x060017B0 RID: 6064 RVA: 0x0007EF2C File Offset: 0x0007D12C
		public unsafe half4 yywy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yywy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x060017B1 RID: 6065 RVA: 0x0007EF5C File Offset: 0x0007D15C
		public unsafe half4 yywz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yywz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x060017B2 RID: 6066 RVA: 0x0007EF8C File Offset: 0x0007D18C
		public unsafe half4 yyww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yyww_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x060017B3 RID: 6067 RVA: 0x0007EFBC File Offset: 0x0007D1BC
		public unsafe half4 yzxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yzxx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x060017B4 RID: 6068 RVA: 0x0007EFEC File Offset: 0x0007D1EC
		public unsafe half4 yzxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yzxy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x060017B5 RID: 6069 RVA: 0x0007F01C File Offset: 0x0007D21C
		public unsafe half4 yzxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yzxz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x060017B6 RID: 6070 RVA: 0x0007F04C File Offset: 0x0007D24C
		// (set) Token: 0x060017B7 RID: 6071 RVA: 0x0007F07C File Offset: 0x0007D27C
		public unsafe half4 yzxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yzxw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_yzxw_Public_set_Void_half4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x060017B8 RID: 6072 RVA: 0x0007F0B0 File Offset: 0x0007D2B0
		public unsafe half4 yzyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yzyx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x060017B9 RID: 6073 RVA: 0x0007F0E0 File Offset: 0x0007D2E0
		public unsafe half4 yzyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yzyy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x060017BA RID: 6074 RVA: 0x0007F110 File Offset: 0x0007D310
		public unsafe half4 yzyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yzyz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x060017BB RID: 6075 RVA: 0x0007F140 File Offset: 0x0007D340
		public unsafe half4 yzyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yzyw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x060017BC RID: 6076 RVA: 0x0007F170 File Offset: 0x0007D370
		public unsafe half4 yzzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yzzx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x060017BD RID: 6077 RVA: 0x0007F1A0 File Offset: 0x0007D3A0
		public unsafe half4 yzzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yzzy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x060017BE RID: 6078 RVA: 0x0007F1D0 File Offset: 0x0007D3D0
		public unsafe half4 yzzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yzzz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x060017BF RID: 6079 RVA: 0x0007F200 File Offset: 0x0007D400
		public unsafe half4 yzzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yzzw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x060017C0 RID: 6080 RVA: 0x0007F230 File Offset: 0x0007D430
		// (set) Token: 0x060017C1 RID: 6081 RVA: 0x0007F260 File Offset: 0x0007D460
		public unsafe half4 yzwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yzwx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_yzwx_Public_set_Void_half4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x060017C2 RID: 6082 RVA: 0x0007F294 File Offset: 0x0007D494
		public unsafe half4 yzwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yzwy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x060017C3 RID: 6083 RVA: 0x0007F2C4 File Offset: 0x0007D4C4
		public unsafe half4 yzwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yzwz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x060017C4 RID: 6084 RVA: 0x0007F2F4 File Offset: 0x0007D4F4
		public unsafe half4 yzww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yzww_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x060017C5 RID: 6085 RVA: 0x0007F324 File Offset: 0x0007D524
		public unsafe half4 ywxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_ywxx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x060017C6 RID: 6086 RVA: 0x0007F354 File Offset: 0x0007D554
		public unsafe half4 ywxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_ywxy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x060017C7 RID: 6087 RVA: 0x0007F384 File Offset: 0x0007D584
		// (set) Token: 0x060017C8 RID: 6088 RVA: 0x0007F3B4 File Offset: 0x0007D5B4
		public unsafe half4 ywxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_ywxz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_ywxz_Public_set_Void_half4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x060017C9 RID: 6089 RVA: 0x0007F3E8 File Offset: 0x0007D5E8
		public unsafe half4 ywxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_ywxw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x060017CA RID: 6090 RVA: 0x0007F418 File Offset: 0x0007D618
		public unsafe half4 ywyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_ywyx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x060017CB RID: 6091 RVA: 0x0007F448 File Offset: 0x0007D648
		public unsafe half4 ywyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_ywyy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x060017CC RID: 6092 RVA: 0x0007F478 File Offset: 0x0007D678
		public unsafe half4 ywyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_ywyz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x060017CD RID: 6093 RVA: 0x0007F4A8 File Offset: 0x0007D6A8
		public unsafe half4 ywyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_ywyw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x060017CE RID: 6094 RVA: 0x0007F4D8 File Offset: 0x0007D6D8
		// (set) Token: 0x060017CF RID: 6095 RVA: 0x0007F508 File Offset: 0x0007D708
		public unsafe half4 ywzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_ywzx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_ywzx_Public_set_Void_half4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x060017D0 RID: 6096 RVA: 0x0007F53C File Offset: 0x0007D73C
		public unsafe half4 ywzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_ywzy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x060017D1 RID: 6097 RVA: 0x0007F56C File Offset: 0x0007D76C
		public unsafe half4 ywzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_ywzz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x060017D2 RID: 6098 RVA: 0x0007F59C File Offset: 0x0007D79C
		public unsafe half4 ywzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_ywzw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x060017D3 RID: 6099 RVA: 0x0007F5CC File Offset: 0x0007D7CC
		public unsafe half4 ywwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_ywwx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x060017D4 RID: 6100 RVA: 0x0007F5FC File Offset: 0x0007D7FC
		public unsafe half4 ywwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_ywwy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x060017D5 RID: 6101 RVA: 0x0007F62C File Offset: 0x0007D82C
		public unsafe half4 ywwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_ywwz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x060017D6 RID: 6102 RVA: 0x0007F65C File Offset: 0x0007D85C
		public unsafe half4 ywww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_ywww_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x060017D7 RID: 6103 RVA: 0x0007F68C File Offset: 0x0007D88C
		public unsafe half4 zxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zxxx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x060017D8 RID: 6104 RVA: 0x0007F6BC File Offset: 0x0007D8BC
		public unsafe half4 zxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zxxy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x060017D9 RID: 6105 RVA: 0x0007F6EC File Offset: 0x0007D8EC
		public unsafe half4 zxxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zxxz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x060017DA RID: 6106 RVA: 0x0007F71C File Offset: 0x0007D91C
		public unsafe half4 zxxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zxxw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x060017DB RID: 6107 RVA: 0x0007F74C File Offset: 0x0007D94C
		public unsafe half4 zxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zxyx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x060017DC RID: 6108 RVA: 0x0007F77C File Offset: 0x0007D97C
		public unsafe half4 zxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zxyy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x060017DD RID: 6109 RVA: 0x0007F7AC File Offset: 0x0007D9AC
		public unsafe half4 zxyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zxyz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x060017DE RID: 6110 RVA: 0x0007F7DC File Offset: 0x0007D9DC
		// (set) Token: 0x060017DF RID: 6111 RVA: 0x0007F80C File Offset: 0x0007DA0C
		public unsafe half4 zxyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zxyw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_zxyw_Public_set_Void_half4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x060017E0 RID: 6112 RVA: 0x0007F840 File Offset: 0x0007DA40
		public unsafe half4 zxzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zxzx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x060017E1 RID: 6113 RVA: 0x0007F870 File Offset: 0x0007DA70
		public unsafe half4 zxzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zxzy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x060017E2 RID: 6114 RVA: 0x0007F8A0 File Offset: 0x0007DAA0
		public unsafe half4 zxzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zxzz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x060017E3 RID: 6115 RVA: 0x0007F8D0 File Offset: 0x0007DAD0
		public unsafe half4 zxzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zxzw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x060017E4 RID: 6116 RVA: 0x0007F900 File Offset: 0x0007DB00
		public unsafe half4 zxwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zxwx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x060017E5 RID: 6117 RVA: 0x0007F930 File Offset: 0x0007DB30
		// (set) Token: 0x060017E6 RID: 6118 RVA: 0x0007F960 File Offset: 0x0007DB60
		public unsafe half4 zxwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zxwy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_zxwy_Public_set_Void_half4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x060017E7 RID: 6119 RVA: 0x0007F994 File Offset: 0x0007DB94
		public unsafe half4 zxwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zxwz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x060017E8 RID: 6120 RVA: 0x0007F9C4 File Offset: 0x0007DBC4
		public unsafe half4 zxww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zxww_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x060017E9 RID: 6121 RVA: 0x0007F9F4 File Offset: 0x0007DBF4
		public unsafe half4 zyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zyxx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x060017EA RID: 6122 RVA: 0x0007FA24 File Offset: 0x0007DC24
		public unsafe half4 zyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zyxy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x060017EB RID: 6123 RVA: 0x0007FA54 File Offset: 0x0007DC54
		public unsafe half4 zyxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zyxz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x060017EC RID: 6124 RVA: 0x0007FA84 File Offset: 0x0007DC84
		// (set) Token: 0x060017ED RID: 6125 RVA: 0x0007FAB4 File Offset: 0x0007DCB4
		public unsafe half4 zyxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zyxw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_zyxw_Public_set_Void_half4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x060017EE RID: 6126 RVA: 0x0007FAE8 File Offset: 0x0007DCE8
		public unsafe half4 zyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zyyx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x060017EF RID: 6127 RVA: 0x0007FB18 File Offset: 0x0007DD18
		public unsafe half4 zyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zyyy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x060017F0 RID: 6128 RVA: 0x0007FB48 File Offset: 0x0007DD48
		public unsafe half4 zyyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zyyz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x060017F1 RID: 6129 RVA: 0x0007FB78 File Offset: 0x0007DD78
		public unsafe half4 zyyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zyyw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x060017F2 RID: 6130 RVA: 0x0007FBA8 File Offset: 0x0007DDA8
		public unsafe half4 zyzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zyzx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x060017F3 RID: 6131 RVA: 0x0007FBD8 File Offset: 0x0007DDD8
		public unsafe half4 zyzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zyzy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x060017F4 RID: 6132 RVA: 0x0007FC08 File Offset: 0x0007DE08
		public unsafe half4 zyzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zyzz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x060017F5 RID: 6133 RVA: 0x0007FC38 File Offset: 0x0007DE38
		public unsafe half4 zyzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zyzw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x060017F6 RID: 6134 RVA: 0x0007FC68 File Offset: 0x0007DE68
		// (set) Token: 0x060017F7 RID: 6135 RVA: 0x0007FC98 File Offset: 0x0007DE98
		public unsafe half4 zywx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zywx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_zywx_Public_set_Void_half4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x060017F8 RID: 6136 RVA: 0x0007FCCC File Offset: 0x0007DECC
		public unsafe half4 zywy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zywy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x060017F9 RID: 6137 RVA: 0x0007FCFC File Offset: 0x0007DEFC
		public unsafe half4 zywz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zywz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x060017FA RID: 6138 RVA: 0x0007FD2C File Offset: 0x0007DF2C
		public unsafe half4 zyww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zyww_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x060017FB RID: 6139 RVA: 0x0007FD5C File Offset: 0x0007DF5C
		public unsafe half4 zzxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zzxx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x060017FC RID: 6140 RVA: 0x0007FD8C File Offset: 0x0007DF8C
		public unsafe half4 zzxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zzxy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x060017FD RID: 6141 RVA: 0x0007FDBC File Offset: 0x0007DFBC
		public unsafe half4 zzxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zzxz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x060017FE RID: 6142 RVA: 0x0007FDEC File Offset: 0x0007DFEC
		public unsafe half4 zzxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zzxw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x060017FF RID: 6143 RVA: 0x0007FE1C File Offset: 0x0007E01C
		public unsafe half4 zzyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zzyx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x06001800 RID: 6144 RVA: 0x0007FE4C File Offset: 0x0007E04C
		public unsafe half4 zzyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zzyy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x06001801 RID: 6145 RVA: 0x0007FE7C File Offset: 0x0007E07C
		public unsafe half4 zzyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zzyz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x06001802 RID: 6146 RVA: 0x0007FEAC File Offset: 0x0007E0AC
		public unsafe half4 zzyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zzyw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x06001803 RID: 6147 RVA: 0x0007FEDC File Offset: 0x0007E0DC
		public unsafe half4 zzzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zzzx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x06001804 RID: 6148 RVA: 0x0007FF0C File Offset: 0x0007E10C
		public unsafe half4 zzzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zzzy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x06001805 RID: 6149 RVA: 0x0007FF3C File Offset: 0x0007E13C
		public unsafe half4 zzzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zzzz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x06001806 RID: 6150 RVA: 0x0007FF6C File Offset: 0x0007E16C
		public unsafe half4 zzzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zzzw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x06001807 RID: 6151 RVA: 0x0007FF9C File Offset: 0x0007E19C
		public unsafe half4 zzwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zzwx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x06001808 RID: 6152 RVA: 0x0007FFCC File Offset: 0x0007E1CC
		public unsafe half4 zzwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zzwy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x06001809 RID: 6153 RVA: 0x0007FFFC File Offset: 0x0007E1FC
		public unsafe half4 zzwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zzwz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x0600180A RID: 6154 RVA: 0x0008002C File Offset: 0x0007E22C
		public unsafe half4 zzww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zzww_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x0600180B RID: 6155 RVA: 0x0008005C File Offset: 0x0007E25C
		public unsafe half4 zwxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zwxx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x0600180C RID: 6156 RVA: 0x0008008C File Offset: 0x0007E28C
		// (set) Token: 0x0600180D RID: 6157 RVA: 0x000800BC File Offset: 0x0007E2BC
		public unsafe half4 zwxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zwxy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_zwxy_Public_set_Void_half4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x0600180E RID: 6158 RVA: 0x000800F0 File Offset: 0x0007E2F0
		public unsafe half4 zwxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zwxz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x0600180F RID: 6159 RVA: 0x00080120 File Offset: 0x0007E320
		public unsafe half4 zwxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zwxw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x06001810 RID: 6160 RVA: 0x00080150 File Offset: 0x0007E350
		// (set) Token: 0x06001811 RID: 6161 RVA: 0x00080180 File Offset: 0x0007E380
		public unsafe half4 zwyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zwyx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_zwyx_Public_set_Void_half4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x06001812 RID: 6162 RVA: 0x000801B4 File Offset: 0x0007E3B4
		public unsafe half4 zwyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zwyy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06001813 RID: 6163 RVA: 0x000801E4 File Offset: 0x0007E3E4
		public unsafe half4 zwyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zwyz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06001814 RID: 6164 RVA: 0x00080214 File Offset: 0x0007E414
		public unsafe half4 zwyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zwyw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x06001815 RID: 6165 RVA: 0x00080244 File Offset: 0x0007E444
		public unsafe half4 zwzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zwzx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x06001816 RID: 6166 RVA: 0x00080274 File Offset: 0x0007E474
		public unsafe half4 zwzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zwzy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x06001817 RID: 6167 RVA: 0x000802A4 File Offset: 0x0007E4A4
		public unsafe half4 zwzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zwzz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x06001818 RID: 6168 RVA: 0x000802D4 File Offset: 0x0007E4D4
		public unsafe half4 zwzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zwzw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x06001819 RID: 6169 RVA: 0x00080304 File Offset: 0x0007E504
		public unsafe half4 zwwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zwwx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x0600181A RID: 6170 RVA: 0x00080334 File Offset: 0x0007E534
		public unsafe half4 zwwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zwwy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x0600181B RID: 6171 RVA: 0x00080364 File Offset: 0x0007E564
		public unsafe half4 zwwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zwwz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x0600181C RID: 6172 RVA: 0x00080394 File Offset: 0x0007E594
		public unsafe half4 zwww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zwww_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x0600181D RID: 6173 RVA: 0x000803C4 File Offset: 0x0007E5C4
		public unsafe half4 wxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wxxx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x0600181E RID: 6174 RVA: 0x000803F4 File Offset: 0x0007E5F4
		public unsafe half4 wxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wxxy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x0600181F RID: 6175 RVA: 0x00080424 File Offset: 0x0007E624
		public unsafe half4 wxxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wxxz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x06001820 RID: 6176 RVA: 0x00080454 File Offset: 0x0007E654
		public unsafe half4 wxxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wxxw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06001821 RID: 6177 RVA: 0x00080484 File Offset: 0x0007E684
		public unsafe half4 wxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wxyx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06001822 RID: 6178 RVA: 0x000804B4 File Offset: 0x0007E6B4
		public unsafe half4 wxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wxyy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06001823 RID: 6179 RVA: 0x000804E4 File Offset: 0x0007E6E4
		// (set) Token: 0x06001824 RID: 6180 RVA: 0x00080514 File Offset: 0x0007E714
		public unsafe half4 wxyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wxyz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_wxyz_Public_set_Void_half4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06001825 RID: 6181 RVA: 0x00080548 File Offset: 0x0007E748
		public unsafe half4 wxyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wxyw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06001826 RID: 6182 RVA: 0x00080578 File Offset: 0x0007E778
		public unsafe half4 wxzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wxzx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06001827 RID: 6183 RVA: 0x000805A8 File Offset: 0x0007E7A8
		// (set) Token: 0x06001828 RID: 6184 RVA: 0x000805D8 File Offset: 0x0007E7D8
		public unsafe half4 wxzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wxzy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_wxzy_Public_set_Void_half4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06001829 RID: 6185 RVA: 0x0008060C File Offset: 0x0007E80C
		public unsafe half4 wxzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wxzz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x0600182A RID: 6186 RVA: 0x0008063C File Offset: 0x0007E83C
		public unsafe half4 wxzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wxzw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x0600182B RID: 6187 RVA: 0x0008066C File Offset: 0x0007E86C
		public unsafe half4 wxwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wxwx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x0600182C RID: 6188 RVA: 0x0008069C File Offset: 0x0007E89C
		public unsafe half4 wxwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wxwy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x0600182D RID: 6189 RVA: 0x000806CC File Offset: 0x0007E8CC
		public unsafe half4 wxwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wxwz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x0600182E RID: 6190 RVA: 0x000806FC File Offset: 0x0007E8FC
		public unsafe half4 wxww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wxww_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x0600182F RID: 6191 RVA: 0x0008072C File Offset: 0x0007E92C
		public unsafe half4 wyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wyxx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x06001830 RID: 6192 RVA: 0x0008075C File Offset: 0x0007E95C
		public unsafe half4 wyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wyxy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06001831 RID: 6193 RVA: 0x0008078C File Offset: 0x0007E98C
		// (set) Token: 0x06001832 RID: 6194 RVA: 0x000807BC File Offset: 0x0007E9BC
		public unsafe half4 wyxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wyxz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_wyxz_Public_set_Void_half4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06001833 RID: 6195 RVA: 0x000807F0 File Offset: 0x0007E9F0
		public unsafe half4 wyxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wyxw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06001834 RID: 6196 RVA: 0x00080820 File Offset: 0x0007EA20
		public unsafe half4 wyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wyyx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06001835 RID: 6197 RVA: 0x00080850 File Offset: 0x0007EA50
		public unsafe half4 wyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wyyy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06001836 RID: 6198 RVA: 0x00080880 File Offset: 0x0007EA80
		public unsafe half4 wyyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wyyz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06001837 RID: 6199 RVA: 0x000808B0 File Offset: 0x0007EAB0
		public unsafe half4 wyyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wyyw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x06001838 RID: 6200 RVA: 0x000808E0 File Offset: 0x0007EAE0
		// (set) Token: 0x06001839 RID: 6201 RVA: 0x00080910 File Offset: 0x0007EB10
		public unsafe half4 wyzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wyzx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_wyzx_Public_set_Void_half4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x0600183A RID: 6202 RVA: 0x00080944 File Offset: 0x0007EB44
		public unsafe half4 wyzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wyzy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x0600183B RID: 6203 RVA: 0x00080974 File Offset: 0x0007EB74
		public unsafe half4 wyzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wyzz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x0600183C RID: 6204 RVA: 0x000809A4 File Offset: 0x0007EBA4
		public unsafe half4 wyzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wyzw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x0600183D RID: 6205 RVA: 0x000809D4 File Offset: 0x0007EBD4
		public unsafe half4 wywx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wywx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x0600183E RID: 6206 RVA: 0x00080A04 File Offset: 0x0007EC04
		public unsafe half4 wywy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wywy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x0600183F RID: 6207 RVA: 0x00080A34 File Offset: 0x0007EC34
		public unsafe half4 wywz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wywz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x06001840 RID: 6208 RVA: 0x00080A64 File Offset: 0x0007EC64
		public unsafe half4 wyww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wyww_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x06001841 RID: 6209 RVA: 0x00080A94 File Offset: 0x0007EC94
		public unsafe half4 wzxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wzxx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06001842 RID: 6210 RVA: 0x00080AC4 File Offset: 0x0007ECC4
		// (set) Token: 0x06001843 RID: 6211 RVA: 0x00080AF4 File Offset: 0x0007ECF4
		public unsafe half4 wzxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wzxy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_wzxy_Public_set_Void_half4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06001844 RID: 6212 RVA: 0x00080B28 File Offset: 0x0007ED28
		public unsafe half4 wzxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wzxz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06001845 RID: 6213 RVA: 0x00080B58 File Offset: 0x0007ED58
		public unsafe half4 wzxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wzxw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06001846 RID: 6214 RVA: 0x00080B88 File Offset: 0x0007ED88
		// (set) Token: 0x06001847 RID: 6215 RVA: 0x00080BB8 File Offset: 0x0007EDB8
		public unsafe half4 wzyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wzyx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_wzyx_Public_set_Void_half4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06001848 RID: 6216 RVA: 0x00080BEC File Offset: 0x0007EDEC
		public unsafe half4 wzyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wzyy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06001849 RID: 6217 RVA: 0x00080C1C File Offset: 0x0007EE1C
		public unsafe half4 wzyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wzyz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x0600184A RID: 6218 RVA: 0x00080C4C File Offset: 0x0007EE4C
		public unsafe half4 wzyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wzyw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x0600184B RID: 6219 RVA: 0x00080C7C File Offset: 0x0007EE7C
		public unsafe half4 wzzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wzzx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x0600184C RID: 6220 RVA: 0x00080CAC File Offset: 0x0007EEAC
		public unsafe half4 wzzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wzzy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x0600184D RID: 6221 RVA: 0x00080CDC File Offset: 0x0007EEDC
		public unsafe half4 wzzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wzzz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x0600184E RID: 6222 RVA: 0x00080D0C File Offset: 0x0007EF0C
		public unsafe half4 wzzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wzzw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x0600184F RID: 6223 RVA: 0x00080D3C File Offset: 0x0007EF3C
		public unsafe half4 wzwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wzwx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x06001850 RID: 6224 RVA: 0x00080D6C File Offset: 0x0007EF6C
		public unsafe half4 wzwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wzwy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06001851 RID: 6225 RVA: 0x00080D9C File Offset: 0x0007EF9C
		public unsafe half4 wzwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wzwz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x06001852 RID: 6226 RVA: 0x00080DCC File Offset: 0x0007EFCC
		public unsafe half4 wzww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wzww_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06001853 RID: 6227 RVA: 0x00080DFC File Offset: 0x0007EFFC
		public unsafe half4 wwxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wwxx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06001854 RID: 6228 RVA: 0x00080E2C File Offset: 0x0007F02C
		public unsafe half4 wwxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wwxy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06001855 RID: 6229 RVA: 0x00080E5C File Offset: 0x0007F05C
		public unsafe half4 wwxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wwxz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06001856 RID: 6230 RVA: 0x00080E8C File Offset: 0x0007F08C
		public unsafe half4 wwxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wwxw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x06001857 RID: 6231 RVA: 0x00080EBC File Offset: 0x0007F0BC
		public unsafe half4 wwyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wwyx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x06001858 RID: 6232 RVA: 0x00080EEC File Offset: 0x0007F0EC
		public unsafe half4 wwyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wwyy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x06001859 RID: 6233 RVA: 0x00080F1C File Offset: 0x0007F11C
		public unsafe half4 wwyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wwyz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x0600185A RID: 6234 RVA: 0x00080F4C File Offset: 0x0007F14C
		public unsafe half4 wwyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wwyw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x0600185B RID: 6235 RVA: 0x00080F7C File Offset: 0x0007F17C
		public unsafe half4 wwzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wwzx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x0600185C RID: 6236 RVA: 0x00080FAC File Offset: 0x0007F1AC
		public unsafe half4 wwzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wwzy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x0600185D RID: 6237 RVA: 0x00080FDC File Offset: 0x0007F1DC
		public unsafe half4 wwzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wwzz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x0600185E RID: 6238 RVA: 0x0008100C File Offset: 0x0007F20C
		public unsafe half4 wwzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wwzw_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x0600185F RID: 6239 RVA: 0x0008103C File Offset: 0x0007F23C
		public unsafe half4 wwwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wwwx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x06001860 RID: 6240 RVA: 0x0008106C File Offset: 0x0007F26C
		public unsafe half4 wwwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wwwy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x06001861 RID: 6241 RVA: 0x0008109C File Offset: 0x0007F29C
		public unsafe half4 wwwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wwwz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x06001862 RID: 6242 RVA: 0x000810CC File Offset: 0x0007F2CC
		public unsafe half4 wwww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wwww_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x06001863 RID: 6243 RVA: 0x000810FC File Offset: 0x0007F2FC
		public unsafe half3 xxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xxx_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x06001864 RID: 6244 RVA: 0x0008112C File Offset: 0x0007F32C
		public unsafe half3 xxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xxy_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x06001865 RID: 6245 RVA: 0x0008115C File Offset: 0x0007F35C
		public unsafe half3 xxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xxz_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x06001866 RID: 6246 RVA: 0x0008118C File Offset: 0x0007F38C
		public unsafe half3 xxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xxw_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x06001867 RID: 6247 RVA: 0x000811BC File Offset: 0x0007F3BC
		public unsafe half3 xyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xyx_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x06001868 RID: 6248 RVA: 0x000811EC File Offset: 0x0007F3EC
		public unsafe half3 xyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xyy_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06001869 RID: 6249 RVA: 0x0008121C File Offset: 0x0007F41C
		// (set) Token: 0x0600186A RID: 6250 RVA: 0x0008124C File Offset: 0x0007F44C
		public unsafe half3 xyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xyz_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_xyz_Public_set_Void_half3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x0600186B RID: 6251 RVA: 0x00081280 File Offset: 0x0007F480
		// (set) Token: 0x0600186C RID: 6252 RVA: 0x000812B0 File Offset: 0x0007F4B0
		public unsafe half3 xyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xyw_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_xyw_Public_set_Void_half3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x0600186D RID: 6253 RVA: 0x000812E4 File Offset: 0x0007F4E4
		public unsafe half3 xzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xzx_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x0600186E RID: 6254 RVA: 0x00081314 File Offset: 0x0007F514
		// (set) Token: 0x0600186F RID: 6255 RVA: 0x00081344 File Offset: 0x0007F544
		public unsafe half3 xzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xzy_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_xzy_Public_set_Void_half3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06001870 RID: 6256 RVA: 0x00081378 File Offset: 0x0007F578
		public unsafe half3 xzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xzz_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x06001871 RID: 6257 RVA: 0x000813A8 File Offset: 0x0007F5A8
		// (set) Token: 0x06001872 RID: 6258 RVA: 0x000813D8 File Offset: 0x0007F5D8
		public unsafe half3 xzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xzw_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_xzw_Public_set_Void_half3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x06001873 RID: 6259 RVA: 0x0008140C File Offset: 0x0007F60C
		public unsafe half3 xwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xwx_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x06001874 RID: 6260 RVA: 0x0008143C File Offset: 0x0007F63C
		// (set) Token: 0x06001875 RID: 6261 RVA: 0x0008146C File Offset: 0x0007F66C
		public unsafe half3 xwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xwy_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_xwy_Public_set_Void_half3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06001876 RID: 6262 RVA: 0x000814A0 File Offset: 0x0007F6A0
		// (set) Token: 0x06001877 RID: 6263 RVA: 0x000814D0 File Offset: 0x0007F6D0
		public unsafe half3 xwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xwz_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_xwz_Public_set_Void_half3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x06001878 RID: 6264 RVA: 0x00081504 File Offset: 0x0007F704
		public unsafe half3 xww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xww_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06001879 RID: 6265 RVA: 0x00081534 File Offset: 0x0007F734
		public unsafe half3 yxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yxx_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x0600187A RID: 6266 RVA: 0x00081564 File Offset: 0x0007F764
		public unsafe half3 yxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yxy_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x0600187B RID: 6267 RVA: 0x00081594 File Offset: 0x0007F794
		// (set) Token: 0x0600187C RID: 6268 RVA: 0x000815C4 File Offset: 0x0007F7C4
		public unsafe half3 yxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yxz_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_yxz_Public_set_Void_half3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x0600187D RID: 6269 RVA: 0x000815F8 File Offset: 0x0007F7F8
		// (set) Token: 0x0600187E RID: 6270 RVA: 0x00081628 File Offset: 0x0007F828
		public unsafe half3 yxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yxw_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_yxw_Public_set_Void_half3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x0600187F RID: 6271 RVA: 0x0008165C File Offset: 0x0007F85C
		public unsafe half3 yyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yyx_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06001880 RID: 6272 RVA: 0x0008168C File Offset: 0x0007F88C
		public unsafe half3 yyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yyy_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06001881 RID: 6273 RVA: 0x000816BC File Offset: 0x0007F8BC
		public unsafe half3 yyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yyz_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06001882 RID: 6274 RVA: 0x000816EC File Offset: 0x0007F8EC
		public unsafe half3 yyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yyw_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06001883 RID: 6275 RVA: 0x0008171C File Offset: 0x0007F91C
		// (set) Token: 0x06001884 RID: 6276 RVA: 0x0008174C File Offset: 0x0007F94C
		public unsafe half3 yzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yzx_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_yzx_Public_set_Void_half3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06001885 RID: 6277 RVA: 0x00081780 File Offset: 0x0007F980
		public unsafe half3 yzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yzy_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06001886 RID: 6278 RVA: 0x000817B0 File Offset: 0x0007F9B0
		public unsafe half3 yzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yzz_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06001887 RID: 6279 RVA: 0x000817E0 File Offset: 0x0007F9E0
		// (set) Token: 0x06001888 RID: 6280 RVA: 0x00081810 File Offset: 0x0007FA10
		public unsafe half3 yzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yzw_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_yzw_Public_set_Void_half3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06001889 RID: 6281 RVA: 0x00081844 File Offset: 0x0007FA44
		// (set) Token: 0x0600188A RID: 6282 RVA: 0x00081874 File Offset: 0x0007FA74
		public unsafe half3 ywx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_ywx_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_ywx_Public_set_Void_half3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x0600188B RID: 6283 RVA: 0x000818A8 File Offset: 0x0007FAA8
		public unsafe half3 ywy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_ywy_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x0600188C RID: 6284 RVA: 0x000818D8 File Offset: 0x0007FAD8
		// (set) Token: 0x0600188D RID: 6285 RVA: 0x00081908 File Offset: 0x0007FB08
		public unsafe half3 ywz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_ywz_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_ywz_Public_set_Void_half3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x0600188E RID: 6286 RVA: 0x0008193C File Offset: 0x0007FB3C
		public unsafe half3 yww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yww_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x0600188F RID: 6287 RVA: 0x0008196C File Offset: 0x0007FB6C
		public unsafe half3 zxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zxx_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06001890 RID: 6288 RVA: 0x0008199C File Offset: 0x0007FB9C
		// (set) Token: 0x06001891 RID: 6289 RVA: 0x000819CC File Offset: 0x0007FBCC
		public unsafe half3 zxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zxy_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_zxy_Public_set_Void_half3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06001892 RID: 6290 RVA: 0x00081A00 File Offset: 0x0007FC00
		public unsafe half3 zxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zxz_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06001893 RID: 6291 RVA: 0x00081A30 File Offset: 0x0007FC30
		// (set) Token: 0x06001894 RID: 6292 RVA: 0x00081A60 File Offset: 0x0007FC60
		public unsafe half3 zxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zxw_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_zxw_Public_set_Void_half3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06001895 RID: 6293 RVA: 0x00081A94 File Offset: 0x0007FC94
		// (set) Token: 0x06001896 RID: 6294 RVA: 0x00081AC4 File Offset: 0x0007FCC4
		public unsafe half3 zyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zyx_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_zyx_Public_set_Void_half3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06001897 RID: 6295 RVA: 0x00081AF8 File Offset: 0x0007FCF8
		public unsafe half3 zyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zyy_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x06001898 RID: 6296 RVA: 0x00081B28 File Offset: 0x0007FD28
		public unsafe half3 zyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zyz_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x06001899 RID: 6297 RVA: 0x00081B58 File Offset: 0x0007FD58
		// (set) Token: 0x0600189A RID: 6298 RVA: 0x00081B88 File Offset: 0x0007FD88
		public unsafe half3 zyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zyw_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_zyw_Public_set_Void_half3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x0600189B RID: 6299 RVA: 0x00081BBC File Offset: 0x0007FDBC
		public unsafe half3 zzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zzx_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x0600189C RID: 6300 RVA: 0x00081BEC File Offset: 0x0007FDEC
		public unsafe half3 zzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zzy_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x0600189D RID: 6301 RVA: 0x00081C1C File Offset: 0x0007FE1C
		public unsafe half3 zzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zzz_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x0600189E RID: 6302 RVA: 0x00081C4C File Offset: 0x0007FE4C
		public unsafe half3 zzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zzw_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x0600189F RID: 6303 RVA: 0x00081C7C File Offset: 0x0007FE7C
		// (set) Token: 0x060018A0 RID: 6304 RVA: 0x00081CAC File Offset: 0x0007FEAC
		public unsafe half3 zwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zwx_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_zwx_Public_set_Void_half3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x060018A1 RID: 6305 RVA: 0x00081CE0 File Offset: 0x0007FEE0
		// (set) Token: 0x060018A2 RID: 6306 RVA: 0x00081D10 File Offset: 0x0007FF10
		public unsafe half3 zwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zwy_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_zwy_Public_set_Void_half3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x060018A3 RID: 6307 RVA: 0x00081D44 File Offset: 0x0007FF44
		public unsafe half3 zwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zwz_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x060018A4 RID: 6308 RVA: 0x00081D74 File Offset: 0x0007FF74
		public unsafe half3 zww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zww_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x060018A5 RID: 6309 RVA: 0x00081DA4 File Offset: 0x0007FFA4
		public unsafe half3 wxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wxx_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x060018A6 RID: 6310 RVA: 0x00081DD4 File Offset: 0x0007FFD4
		// (set) Token: 0x060018A7 RID: 6311 RVA: 0x00081E04 File Offset: 0x00080004
		public unsafe half3 wxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wxy_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_wxy_Public_set_Void_half3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x060018A8 RID: 6312 RVA: 0x00081E38 File Offset: 0x00080038
		// (set) Token: 0x060018A9 RID: 6313 RVA: 0x00081E68 File Offset: 0x00080068
		public unsafe half3 wxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wxz_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_wxz_Public_set_Void_half3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x060018AA RID: 6314 RVA: 0x00081E9C File Offset: 0x0008009C
		public unsafe half3 wxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wxw_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x060018AB RID: 6315 RVA: 0x00081ECC File Offset: 0x000800CC
		// (set) Token: 0x060018AC RID: 6316 RVA: 0x00081EFC File Offset: 0x000800FC
		public unsafe half3 wyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wyx_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_wyx_Public_set_Void_half3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x060018AD RID: 6317 RVA: 0x00081F30 File Offset: 0x00080130
		public unsafe half3 wyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wyy_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x060018AE RID: 6318 RVA: 0x00081F60 File Offset: 0x00080160
		// (set) Token: 0x060018AF RID: 6319 RVA: 0x00081F90 File Offset: 0x00080190
		public unsafe half3 wyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wyz_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_wyz_Public_set_Void_half3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x060018B0 RID: 6320 RVA: 0x00081FC4 File Offset: 0x000801C4
		public unsafe half3 wyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wyw_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x060018B1 RID: 6321 RVA: 0x00081FF4 File Offset: 0x000801F4
		// (set) Token: 0x060018B2 RID: 6322 RVA: 0x00082024 File Offset: 0x00080224
		public unsafe half3 wzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wzx_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_wzx_Public_set_Void_half3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x060018B3 RID: 6323 RVA: 0x00082058 File Offset: 0x00080258
		// (set) Token: 0x060018B4 RID: 6324 RVA: 0x00082088 File Offset: 0x00080288
		public unsafe half3 wzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wzy_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_wzy_Public_set_Void_half3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x060018B5 RID: 6325 RVA: 0x000820BC File Offset: 0x000802BC
		public unsafe half3 wzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wzz_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x060018B6 RID: 6326 RVA: 0x000820EC File Offset: 0x000802EC
		public unsafe half3 wzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wzw_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x060018B7 RID: 6327 RVA: 0x0008211C File Offset: 0x0008031C
		public unsafe half3 wwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wwx_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x060018B8 RID: 6328 RVA: 0x0008214C File Offset: 0x0008034C
		public unsafe half3 wwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wwy_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x060018B9 RID: 6329 RVA: 0x0008217C File Offset: 0x0008037C
		public unsafe half3 wwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wwz_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x060018BA RID: 6330 RVA: 0x000821AC File Offset: 0x000803AC
		public unsafe half3 www
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_www_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x060018BB RID: 6331 RVA: 0x000821DC File Offset: 0x000803DC
		public unsafe half2 xx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xx_Public_get_half2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x060018BC RID: 6332 RVA: 0x0008220C File Offset: 0x0008040C
		// (set) Token: 0x060018BD RID: 6333 RVA: 0x0008223C File Offset: 0x0008043C
		public unsafe half2 xy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xy_Public_get_half2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_xy_Public_set_Void_half2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x060018BE RID: 6334 RVA: 0x00082270 File Offset: 0x00080470
		// (set) Token: 0x060018BF RID: 6335 RVA: 0x000822A0 File Offset: 0x000804A0
		public unsafe half2 xz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xz_Public_get_half2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_xz_Public_set_Void_half2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x060018C0 RID: 6336 RVA: 0x000822D4 File Offset: 0x000804D4
		// (set) Token: 0x060018C1 RID: 6337 RVA: 0x00082304 File Offset: 0x00080504
		public unsafe half2 xw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_xw_Public_get_half2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_xw_Public_set_Void_half2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x060018C2 RID: 6338 RVA: 0x00082338 File Offset: 0x00080538
		// (set) Token: 0x060018C3 RID: 6339 RVA: 0x00082368 File Offset: 0x00080568
		public unsafe half2 yx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yx_Public_get_half2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_yx_Public_set_Void_half2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x060018C4 RID: 6340 RVA: 0x0008239C File Offset: 0x0008059C
		public unsafe half2 yy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yy_Public_get_half2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x060018C5 RID: 6341 RVA: 0x000823CC File Offset: 0x000805CC
		// (set) Token: 0x060018C6 RID: 6342 RVA: 0x000823FC File Offset: 0x000805FC
		public unsafe half2 yz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yz_Public_get_half2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_yz_Public_set_Void_half2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x060018C7 RID: 6343 RVA: 0x00082430 File Offset: 0x00080630
		// (set) Token: 0x060018C8 RID: 6344 RVA: 0x00082460 File Offset: 0x00080660
		public unsafe half2 yw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_yw_Public_get_half2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_yw_Public_set_Void_half2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x060018C9 RID: 6345 RVA: 0x00082494 File Offset: 0x00080694
		// (set) Token: 0x060018CA RID: 6346 RVA: 0x000824C4 File Offset: 0x000806C4
		public unsafe half2 zx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zx_Public_get_half2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_zx_Public_set_Void_half2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x060018CB RID: 6347 RVA: 0x000824F8 File Offset: 0x000806F8
		// (set) Token: 0x060018CC RID: 6348 RVA: 0x00082528 File Offset: 0x00080728
		public unsafe half2 zy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zy_Public_get_half2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_zy_Public_set_Void_half2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x060018CD RID: 6349 RVA: 0x0008255C File Offset: 0x0008075C
		public unsafe half2 zz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zz_Public_get_half2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x060018CE RID: 6350 RVA: 0x0008258C File Offset: 0x0008078C
		// (set) Token: 0x060018CF RID: 6351 RVA: 0x000825BC File Offset: 0x000807BC
		public unsafe half2 zw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_zw_Public_get_half2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_zw_Public_set_Void_half2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x060018D0 RID: 6352 RVA: 0x000825F0 File Offset: 0x000807F0
		// (set) Token: 0x060018D1 RID: 6353 RVA: 0x00082620 File Offset: 0x00080820
		public unsafe half2 wx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wx_Public_get_half2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_wx_Public_set_Void_half2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x060018D2 RID: 6354 RVA: 0x00082654 File Offset: 0x00080854
		// (set) Token: 0x060018D3 RID: 6355 RVA: 0x00082684 File Offset: 0x00080884
		public unsafe half2 wy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wy_Public_get_half2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_wy_Public_set_Void_half2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x060018D4 RID: 6356 RVA: 0x000826B8 File Offset: 0x000808B8
		// (set) Token: 0x060018D5 RID: 6357 RVA: 0x000826E8 File Offset: 0x000808E8
		public unsafe half2 wz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_wz_Public_get_half2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_wz_Public_set_Void_half2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x060018D6 RID: 6358 RVA: 0x0008271C File Offset: 0x0008091C
		public unsafe half2 ww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_ww_Public_get_half2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007E7 RID: 2023
		public unsafe half this[int index]
		{
			[CallerCount(0)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_get_Item_Public_get_half_Int32_0, ref this, (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_half_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x000827CC File Offset: 0x000809CC
		[CallerCount(0)]
		public unsafe bool Equals(half4 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018DA RID: 6362 RVA: 0x0008280C File Offset: 0x00080A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639087, XrefRangeEnd = 639090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018DB RID: 6363 RVA: 0x00082850 File Offset: 0x00080A50
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x00082880 File Offset: 0x00080A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639090, XrefRangeEnd = 639113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x000828AC File Offset: 0x00080AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639113, XrefRangeEnd = 639141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x00002664 File Offset: 0x00000864
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<half4>.NativeClassPtr, ref this));
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x060018DF RID: 6367 RVA: 0x000828FC File Offset: 0x00080AFC
		// (set) Token: 0x060018E0 RID: 6368 RVA: 0x00002676 File Offset: 0x00000876
		public unsafe static half4 zero
		{
			get
			{
				half4 half;
				IL2CPP.il2cpp_field_static_get_value(half4.NativeFieldInfoPtr_zero, (void*)(&half));
				return half;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(half4.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x0400178B RID: 6027
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x0400178C RID: 6028
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x0400178D RID: 6029
		private static readonly IntPtr NativeFieldInfoPtr_z;

		// Token: 0x0400178E RID: 6030
		private static readonly IntPtr NativeFieldInfoPtr_w;

		// Token: 0x0400178F RID: 6031
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x04001790 RID: 6032
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_half_half_half_half_0;

		// Token: 0x04001791 RID: 6033
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_half_half_half2_0;

		// Token: 0x04001792 RID: 6034
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_half_half2_half_0;

		// Token: 0x04001793 RID: 6035
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_half_half3_0;

		// Token: 0x04001794 RID: 6036
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_half2_half_half_0;

		// Token: 0x04001795 RID: 6037
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_half2_half2_0;

		// Token: 0x04001796 RID: 6038
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_half3_half_0;

		// Token: 0x04001797 RID: 6039
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_half4_0;

		// Token: 0x04001798 RID: 6040
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_half_0;

		// Token: 0x04001799 RID: 6041
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x0400179A RID: 6042
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float4_0;

		// Token: 0x0400179B RID: 6043
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x0400179C RID: 6044
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double4_0;

		// Token: 0x0400179D RID: 6045
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_half4_half_0;

		// Token: 0x0400179E RID: 6046
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_half4_Single_0;

		// Token: 0x0400179F RID: 6047
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_half4_float4_0;

		// Token: 0x040017A0 RID: 6048
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_half4_Double_0;

		// Token: 0x040017A1 RID: 6049
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_half4_double4_0;

		// Token: 0x040017A2 RID: 6050
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4_half4_half4_0;

		// Token: 0x040017A3 RID: 6051
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4_half4_half_0;

		// Token: 0x040017A4 RID: 6052
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4_half_half4_0;

		// Token: 0x040017A5 RID: 6053
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_half4_half4_0;

		// Token: 0x040017A6 RID: 6054
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_half4_half_0;

		// Token: 0x040017A7 RID: 6055
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_half_half4_0;

		// Token: 0x040017A8 RID: 6056
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxx_Public_get_half4_0;

		// Token: 0x040017A9 RID: 6057
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxy_Public_get_half4_0;

		// Token: 0x040017AA RID: 6058
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxz_Public_get_half4_0;

		// Token: 0x040017AB RID: 6059
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxw_Public_get_half4_0;

		// Token: 0x040017AC RID: 6060
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyx_Public_get_half4_0;

		// Token: 0x040017AD RID: 6061
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyy_Public_get_half4_0;

		// Token: 0x040017AE RID: 6062
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyz_Public_get_half4_0;

		// Token: 0x040017AF RID: 6063
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyw_Public_get_half4_0;

		// Token: 0x040017B0 RID: 6064
		private static readonly IntPtr NativeMethodInfoPtr_get_xxzx_Public_get_half4_0;

		// Token: 0x040017B1 RID: 6065
		private static readonly IntPtr NativeMethodInfoPtr_get_xxzy_Public_get_half4_0;

		// Token: 0x040017B2 RID: 6066
		private static readonly IntPtr NativeMethodInfoPtr_get_xxzz_Public_get_half4_0;

		// Token: 0x040017B3 RID: 6067
		private static readonly IntPtr NativeMethodInfoPtr_get_xxzw_Public_get_half4_0;

		// Token: 0x040017B4 RID: 6068
		private static readonly IntPtr NativeMethodInfoPtr_get_xxwx_Public_get_half4_0;

		// Token: 0x040017B5 RID: 6069
		private static readonly IntPtr NativeMethodInfoPtr_get_xxwy_Public_get_half4_0;

		// Token: 0x040017B6 RID: 6070
		private static readonly IntPtr NativeMethodInfoPtr_get_xxwz_Public_get_half4_0;

		// Token: 0x040017B7 RID: 6071
		private static readonly IntPtr NativeMethodInfoPtr_get_xxww_Public_get_half4_0;

		// Token: 0x040017B8 RID: 6072
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxx_Public_get_half4_0;

		// Token: 0x040017B9 RID: 6073
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxy_Public_get_half4_0;

		// Token: 0x040017BA RID: 6074
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxz_Public_get_half4_0;

		// Token: 0x040017BB RID: 6075
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxw_Public_get_half4_0;

		// Token: 0x040017BC RID: 6076
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyx_Public_get_half4_0;

		// Token: 0x040017BD RID: 6077
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyy_Public_get_half4_0;

		// Token: 0x040017BE RID: 6078
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyz_Public_get_half4_0;

		// Token: 0x040017BF RID: 6079
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyw_Public_get_half4_0;

		// Token: 0x040017C0 RID: 6080
		private static readonly IntPtr NativeMethodInfoPtr_get_xyzx_Public_get_half4_0;

		// Token: 0x040017C1 RID: 6081
		private static readonly IntPtr NativeMethodInfoPtr_get_xyzy_Public_get_half4_0;

		// Token: 0x040017C2 RID: 6082
		private static readonly IntPtr NativeMethodInfoPtr_get_xyzz_Public_get_half4_0;

		// Token: 0x040017C3 RID: 6083
		private static readonly IntPtr NativeMethodInfoPtr_get_xyzw_Public_get_half4_0;

		// Token: 0x040017C4 RID: 6084
		private static readonly IntPtr NativeMethodInfoPtr_set_xyzw_Public_set_Void_half4_0;

		// Token: 0x040017C5 RID: 6085
		private static readonly IntPtr NativeMethodInfoPtr_get_xywx_Public_get_half4_0;

		// Token: 0x040017C6 RID: 6086
		private static readonly IntPtr NativeMethodInfoPtr_get_xywy_Public_get_half4_0;

		// Token: 0x040017C7 RID: 6087
		private static readonly IntPtr NativeMethodInfoPtr_get_xywz_Public_get_half4_0;

		// Token: 0x040017C8 RID: 6088
		private static readonly IntPtr NativeMethodInfoPtr_set_xywz_Public_set_Void_half4_0;

		// Token: 0x040017C9 RID: 6089
		private static readonly IntPtr NativeMethodInfoPtr_get_xyww_Public_get_half4_0;

		// Token: 0x040017CA RID: 6090
		private static readonly IntPtr NativeMethodInfoPtr_get_xzxx_Public_get_half4_0;

		// Token: 0x040017CB RID: 6091
		private static readonly IntPtr NativeMethodInfoPtr_get_xzxy_Public_get_half4_0;

		// Token: 0x040017CC RID: 6092
		private static readonly IntPtr NativeMethodInfoPtr_get_xzxz_Public_get_half4_0;

		// Token: 0x040017CD RID: 6093
		private static readonly IntPtr NativeMethodInfoPtr_get_xzxw_Public_get_half4_0;

		// Token: 0x040017CE RID: 6094
		private static readonly IntPtr NativeMethodInfoPtr_get_xzyx_Public_get_half4_0;

		// Token: 0x040017CF RID: 6095
		private static readonly IntPtr NativeMethodInfoPtr_get_xzyy_Public_get_half4_0;

		// Token: 0x040017D0 RID: 6096
		private static readonly IntPtr NativeMethodInfoPtr_get_xzyz_Public_get_half4_0;

		// Token: 0x040017D1 RID: 6097
		private static readonly IntPtr NativeMethodInfoPtr_get_xzyw_Public_get_half4_0;

		// Token: 0x040017D2 RID: 6098
		private static readonly IntPtr NativeMethodInfoPtr_set_xzyw_Public_set_Void_half4_0;

		// Token: 0x040017D3 RID: 6099
		private static readonly IntPtr NativeMethodInfoPtr_get_xzzx_Public_get_half4_0;

		// Token: 0x040017D4 RID: 6100
		private static readonly IntPtr NativeMethodInfoPtr_get_xzzy_Public_get_half4_0;

		// Token: 0x040017D5 RID: 6101
		private static readonly IntPtr NativeMethodInfoPtr_get_xzzz_Public_get_half4_0;

		// Token: 0x040017D6 RID: 6102
		private static readonly IntPtr NativeMethodInfoPtr_get_xzzw_Public_get_half4_0;

		// Token: 0x040017D7 RID: 6103
		private static readonly IntPtr NativeMethodInfoPtr_get_xzwx_Public_get_half4_0;

		// Token: 0x040017D8 RID: 6104
		private static readonly IntPtr NativeMethodInfoPtr_get_xzwy_Public_get_half4_0;

		// Token: 0x040017D9 RID: 6105
		private static readonly IntPtr NativeMethodInfoPtr_set_xzwy_Public_set_Void_half4_0;

		// Token: 0x040017DA RID: 6106
		private static readonly IntPtr NativeMethodInfoPtr_get_xzwz_Public_get_half4_0;

		// Token: 0x040017DB RID: 6107
		private static readonly IntPtr NativeMethodInfoPtr_get_xzww_Public_get_half4_0;

		// Token: 0x040017DC RID: 6108
		private static readonly IntPtr NativeMethodInfoPtr_get_xwxx_Public_get_half4_0;

		// Token: 0x040017DD RID: 6109
		private static readonly IntPtr NativeMethodInfoPtr_get_xwxy_Public_get_half4_0;

		// Token: 0x040017DE RID: 6110
		private static readonly IntPtr NativeMethodInfoPtr_get_xwxz_Public_get_half4_0;

		// Token: 0x040017DF RID: 6111
		private static readonly IntPtr NativeMethodInfoPtr_get_xwxw_Public_get_half4_0;

		// Token: 0x040017E0 RID: 6112
		private static readonly IntPtr NativeMethodInfoPtr_get_xwyx_Public_get_half4_0;

		// Token: 0x040017E1 RID: 6113
		private static readonly IntPtr NativeMethodInfoPtr_get_xwyy_Public_get_half4_0;

		// Token: 0x040017E2 RID: 6114
		private static readonly IntPtr NativeMethodInfoPtr_get_xwyz_Public_get_half4_0;

		// Token: 0x040017E3 RID: 6115
		private static readonly IntPtr NativeMethodInfoPtr_set_xwyz_Public_set_Void_half4_0;

		// Token: 0x040017E4 RID: 6116
		private static readonly IntPtr NativeMethodInfoPtr_get_xwyw_Public_get_half4_0;

		// Token: 0x040017E5 RID: 6117
		private static readonly IntPtr NativeMethodInfoPtr_get_xwzx_Public_get_half4_0;

		// Token: 0x040017E6 RID: 6118
		private static readonly IntPtr NativeMethodInfoPtr_get_xwzy_Public_get_half4_0;

		// Token: 0x040017E7 RID: 6119
		private static readonly IntPtr NativeMethodInfoPtr_set_xwzy_Public_set_Void_half4_0;

		// Token: 0x040017E8 RID: 6120
		private static readonly IntPtr NativeMethodInfoPtr_get_xwzz_Public_get_half4_0;

		// Token: 0x040017E9 RID: 6121
		private static readonly IntPtr NativeMethodInfoPtr_get_xwzw_Public_get_half4_0;

		// Token: 0x040017EA RID: 6122
		private static readonly IntPtr NativeMethodInfoPtr_get_xwwx_Public_get_half4_0;

		// Token: 0x040017EB RID: 6123
		private static readonly IntPtr NativeMethodInfoPtr_get_xwwy_Public_get_half4_0;

		// Token: 0x040017EC RID: 6124
		private static readonly IntPtr NativeMethodInfoPtr_get_xwwz_Public_get_half4_0;

		// Token: 0x040017ED RID: 6125
		private static readonly IntPtr NativeMethodInfoPtr_get_xwww_Public_get_half4_0;

		// Token: 0x040017EE RID: 6126
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxx_Public_get_half4_0;

		// Token: 0x040017EF RID: 6127
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxy_Public_get_half4_0;

		// Token: 0x040017F0 RID: 6128
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxz_Public_get_half4_0;

		// Token: 0x040017F1 RID: 6129
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxw_Public_get_half4_0;

		// Token: 0x040017F2 RID: 6130
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyx_Public_get_half4_0;

		// Token: 0x040017F3 RID: 6131
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyy_Public_get_half4_0;

		// Token: 0x040017F4 RID: 6132
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyz_Public_get_half4_0;

		// Token: 0x040017F5 RID: 6133
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyw_Public_get_half4_0;

		// Token: 0x040017F6 RID: 6134
		private static readonly IntPtr NativeMethodInfoPtr_get_yxzx_Public_get_half4_0;

		// Token: 0x040017F7 RID: 6135
		private static readonly IntPtr NativeMethodInfoPtr_get_yxzy_Public_get_half4_0;

		// Token: 0x040017F8 RID: 6136
		private static readonly IntPtr NativeMethodInfoPtr_get_yxzz_Public_get_half4_0;

		// Token: 0x040017F9 RID: 6137
		private static readonly IntPtr NativeMethodInfoPtr_get_yxzw_Public_get_half4_0;

		// Token: 0x040017FA RID: 6138
		private static readonly IntPtr NativeMethodInfoPtr_set_yxzw_Public_set_Void_half4_0;

		// Token: 0x040017FB RID: 6139
		private static readonly IntPtr NativeMethodInfoPtr_get_yxwx_Public_get_half4_0;

		// Token: 0x040017FC RID: 6140
		private static readonly IntPtr NativeMethodInfoPtr_get_yxwy_Public_get_half4_0;

		// Token: 0x040017FD RID: 6141
		private static readonly IntPtr NativeMethodInfoPtr_get_yxwz_Public_get_half4_0;

		// Token: 0x040017FE RID: 6142
		private static readonly IntPtr NativeMethodInfoPtr_set_yxwz_Public_set_Void_half4_0;

		// Token: 0x040017FF RID: 6143
		private static readonly IntPtr NativeMethodInfoPtr_get_yxww_Public_get_half4_0;

		// Token: 0x04001800 RID: 6144
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxx_Public_get_half4_0;

		// Token: 0x04001801 RID: 6145
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxy_Public_get_half4_0;

		// Token: 0x04001802 RID: 6146
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxz_Public_get_half4_0;

		// Token: 0x04001803 RID: 6147
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxw_Public_get_half4_0;

		// Token: 0x04001804 RID: 6148
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyx_Public_get_half4_0;

		// Token: 0x04001805 RID: 6149
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyy_Public_get_half4_0;

		// Token: 0x04001806 RID: 6150
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyz_Public_get_half4_0;

		// Token: 0x04001807 RID: 6151
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyw_Public_get_half4_0;

		// Token: 0x04001808 RID: 6152
		private static readonly IntPtr NativeMethodInfoPtr_get_yyzx_Public_get_half4_0;

		// Token: 0x04001809 RID: 6153
		private static readonly IntPtr NativeMethodInfoPtr_get_yyzy_Public_get_half4_0;

		// Token: 0x0400180A RID: 6154
		private static readonly IntPtr NativeMethodInfoPtr_get_yyzz_Public_get_half4_0;

		// Token: 0x0400180B RID: 6155
		private static readonly IntPtr NativeMethodInfoPtr_get_yyzw_Public_get_half4_0;

		// Token: 0x0400180C RID: 6156
		private static readonly IntPtr NativeMethodInfoPtr_get_yywx_Public_get_half4_0;

		// Token: 0x0400180D RID: 6157
		private static readonly IntPtr NativeMethodInfoPtr_get_yywy_Public_get_half4_0;

		// Token: 0x0400180E RID: 6158
		private static readonly IntPtr NativeMethodInfoPtr_get_yywz_Public_get_half4_0;

		// Token: 0x0400180F RID: 6159
		private static readonly IntPtr NativeMethodInfoPtr_get_yyww_Public_get_half4_0;

		// Token: 0x04001810 RID: 6160
		private static readonly IntPtr NativeMethodInfoPtr_get_yzxx_Public_get_half4_0;

		// Token: 0x04001811 RID: 6161
		private static readonly IntPtr NativeMethodInfoPtr_get_yzxy_Public_get_half4_0;

		// Token: 0x04001812 RID: 6162
		private static readonly IntPtr NativeMethodInfoPtr_get_yzxz_Public_get_half4_0;

		// Token: 0x04001813 RID: 6163
		private static readonly IntPtr NativeMethodInfoPtr_get_yzxw_Public_get_half4_0;

		// Token: 0x04001814 RID: 6164
		private static readonly IntPtr NativeMethodInfoPtr_set_yzxw_Public_set_Void_half4_0;

		// Token: 0x04001815 RID: 6165
		private static readonly IntPtr NativeMethodInfoPtr_get_yzyx_Public_get_half4_0;

		// Token: 0x04001816 RID: 6166
		private static readonly IntPtr NativeMethodInfoPtr_get_yzyy_Public_get_half4_0;

		// Token: 0x04001817 RID: 6167
		private static readonly IntPtr NativeMethodInfoPtr_get_yzyz_Public_get_half4_0;

		// Token: 0x04001818 RID: 6168
		private static readonly IntPtr NativeMethodInfoPtr_get_yzyw_Public_get_half4_0;

		// Token: 0x04001819 RID: 6169
		private static readonly IntPtr NativeMethodInfoPtr_get_yzzx_Public_get_half4_0;

		// Token: 0x0400181A RID: 6170
		private static readonly IntPtr NativeMethodInfoPtr_get_yzzy_Public_get_half4_0;

		// Token: 0x0400181B RID: 6171
		private static readonly IntPtr NativeMethodInfoPtr_get_yzzz_Public_get_half4_0;

		// Token: 0x0400181C RID: 6172
		private static readonly IntPtr NativeMethodInfoPtr_get_yzzw_Public_get_half4_0;

		// Token: 0x0400181D RID: 6173
		private static readonly IntPtr NativeMethodInfoPtr_get_yzwx_Public_get_half4_0;

		// Token: 0x0400181E RID: 6174
		private static readonly IntPtr NativeMethodInfoPtr_set_yzwx_Public_set_Void_half4_0;

		// Token: 0x0400181F RID: 6175
		private static readonly IntPtr NativeMethodInfoPtr_get_yzwy_Public_get_half4_0;

		// Token: 0x04001820 RID: 6176
		private static readonly IntPtr NativeMethodInfoPtr_get_yzwz_Public_get_half4_0;

		// Token: 0x04001821 RID: 6177
		private static readonly IntPtr NativeMethodInfoPtr_get_yzww_Public_get_half4_0;

		// Token: 0x04001822 RID: 6178
		private static readonly IntPtr NativeMethodInfoPtr_get_ywxx_Public_get_half4_0;

		// Token: 0x04001823 RID: 6179
		private static readonly IntPtr NativeMethodInfoPtr_get_ywxy_Public_get_half4_0;

		// Token: 0x04001824 RID: 6180
		private static readonly IntPtr NativeMethodInfoPtr_get_ywxz_Public_get_half4_0;

		// Token: 0x04001825 RID: 6181
		private static readonly IntPtr NativeMethodInfoPtr_set_ywxz_Public_set_Void_half4_0;

		// Token: 0x04001826 RID: 6182
		private static readonly IntPtr NativeMethodInfoPtr_get_ywxw_Public_get_half4_0;

		// Token: 0x04001827 RID: 6183
		private static readonly IntPtr NativeMethodInfoPtr_get_ywyx_Public_get_half4_0;

		// Token: 0x04001828 RID: 6184
		private static readonly IntPtr NativeMethodInfoPtr_get_ywyy_Public_get_half4_0;

		// Token: 0x04001829 RID: 6185
		private static readonly IntPtr NativeMethodInfoPtr_get_ywyz_Public_get_half4_0;

		// Token: 0x0400182A RID: 6186
		private static readonly IntPtr NativeMethodInfoPtr_get_ywyw_Public_get_half4_0;

		// Token: 0x0400182B RID: 6187
		private static readonly IntPtr NativeMethodInfoPtr_get_ywzx_Public_get_half4_0;

		// Token: 0x0400182C RID: 6188
		private static readonly IntPtr NativeMethodInfoPtr_set_ywzx_Public_set_Void_half4_0;

		// Token: 0x0400182D RID: 6189
		private static readonly IntPtr NativeMethodInfoPtr_get_ywzy_Public_get_half4_0;

		// Token: 0x0400182E RID: 6190
		private static readonly IntPtr NativeMethodInfoPtr_get_ywzz_Public_get_half4_0;

		// Token: 0x0400182F RID: 6191
		private static readonly IntPtr NativeMethodInfoPtr_get_ywzw_Public_get_half4_0;

		// Token: 0x04001830 RID: 6192
		private static readonly IntPtr NativeMethodInfoPtr_get_ywwx_Public_get_half4_0;

		// Token: 0x04001831 RID: 6193
		private static readonly IntPtr NativeMethodInfoPtr_get_ywwy_Public_get_half4_0;

		// Token: 0x04001832 RID: 6194
		private static readonly IntPtr NativeMethodInfoPtr_get_ywwz_Public_get_half4_0;

		// Token: 0x04001833 RID: 6195
		private static readonly IntPtr NativeMethodInfoPtr_get_ywww_Public_get_half4_0;

		// Token: 0x04001834 RID: 6196
		private static readonly IntPtr NativeMethodInfoPtr_get_zxxx_Public_get_half4_0;

		// Token: 0x04001835 RID: 6197
		private static readonly IntPtr NativeMethodInfoPtr_get_zxxy_Public_get_half4_0;

		// Token: 0x04001836 RID: 6198
		private static readonly IntPtr NativeMethodInfoPtr_get_zxxz_Public_get_half4_0;

		// Token: 0x04001837 RID: 6199
		private static readonly IntPtr NativeMethodInfoPtr_get_zxxw_Public_get_half4_0;

		// Token: 0x04001838 RID: 6200
		private static readonly IntPtr NativeMethodInfoPtr_get_zxyx_Public_get_half4_0;

		// Token: 0x04001839 RID: 6201
		private static readonly IntPtr NativeMethodInfoPtr_get_zxyy_Public_get_half4_0;

		// Token: 0x0400183A RID: 6202
		private static readonly IntPtr NativeMethodInfoPtr_get_zxyz_Public_get_half4_0;

		// Token: 0x0400183B RID: 6203
		private static readonly IntPtr NativeMethodInfoPtr_get_zxyw_Public_get_half4_0;

		// Token: 0x0400183C RID: 6204
		private static readonly IntPtr NativeMethodInfoPtr_set_zxyw_Public_set_Void_half4_0;

		// Token: 0x0400183D RID: 6205
		private static readonly IntPtr NativeMethodInfoPtr_get_zxzx_Public_get_half4_0;

		// Token: 0x0400183E RID: 6206
		private static readonly IntPtr NativeMethodInfoPtr_get_zxzy_Public_get_half4_0;

		// Token: 0x0400183F RID: 6207
		private static readonly IntPtr NativeMethodInfoPtr_get_zxzz_Public_get_half4_0;

		// Token: 0x04001840 RID: 6208
		private static readonly IntPtr NativeMethodInfoPtr_get_zxzw_Public_get_half4_0;

		// Token: 0x04001841 RID: 6209
		private static readonly IntPtr NativeMethodInfoPtr_get_zxwx_Public_get_half4_0;

		// Token: 0x04001842 RID: 6210
		private static readonly IntPtr NativeMethodInfoPtr_get_zxwy_Public_get_half4_0;

		// Token: 0x04001843 RID: 6211
		private static readonly IntPtr NativeMethodInfoPtr_set_zxwy_Public_set_Void_half4_0;

		// Token: 0x04001844 RID: 6212
		private static readonly IntPtr NativeMethodInfoPtr_get_zxwz_Public_get_half4_0;

		// Token: 0x04001845 RID: 6213
		private static readonly IntPtr NativeMethodInfoPtr_get_zxww_Public_get_half4_0;

		// Token: 0x04001846 RID: 6214
		private static readonly IntPtr NativeMethodInfoPtr_get_zyxx_Public_get_half4_0;

		// Token: 0x04001847 RID: 6215
		private static readonly IntPtr NativeMethodInfoPtr_get_zyxy_Public_get_half4_0;

		// Token: 0x04001848 RID: 6216
		private static readonly IntPtr NativeMethodInfoPtr_get_zyxz_Public_get_half4_0;

		// Token: 0x04001849 RID: 6217
		private static readonly IntPtr NativeMethodInfoPtr_get_zyxw_Public_get_half4_0;

		// Token: 0x0400184A RID: 6218
		private static readonly IntPtr NativeMethodInfoPtr_set_zyxw_Public_set_Void_half4_0;

		// Token: 0x0400184B RID: 6219
		private static readonly IntPtr NativeMethodInfoPtr_get_zyyx_Public_get_half4_0;

		// Token: 0x0400184C RID: 6220
		private static readonly IntPtr NativeMethodInfoPtr_get_zyyy_Public_get_half4_0;

		// Token: 0x0400184D RID: 6221
		private static readonly IntPtr NativeMethodInfoPtr_get_zyyz_Public_get_half4_0;

		// Token: 0x0400184E RID: 6222
		private static readonly IntPtr NativeMethodInfoPtr_get_zyyw_Public_get_half4_0;

		// Token: 0x0400184F RID: 6223
		private static readonly IntPtr NativeMethodInfoPtr_get_zyzx_Public_get_half4_0;

		// Token: 0x04001850 RID: 6224
		private static readonly IntPtr NativeMethodInfoPtr_get_zyzy_Public_get_half4_0;

		// Token: 0x04001851 RID: 6225
		private static readonly IntPtr NativeMethodInfoPtr_get_zyzz_Public_get_half4_0;

		// Token: 0x04001852 RID: 6226
		private static readonly IntPtr NativeMethodInfoPtr_get_zyzw_Public_get_half4_0;

		// Token: 0x04001853 RID: 6227
		private static readonly IntPtr NativeMethodInfoPtr_get_zywx_Public_get_half4_0;

		// Token: 0x04001854 RID: 6228
		private static readonly IntPtr NativeMethodInfoPtr_set_zywx_Public_set_Void_half4_0;

		// Token: 0x04001855 RID: 6229
		private static readonly IntPtr NativeMethodInfoPtr_get_zywy_Public_get_half4_0;

		// Token: 0x04001856 RID: 6230
		private static readonly IntPtr NativeMethodInfoPtr_get_zywz_Public_get_half4_0;

		// Token: 0x04001857 RID: 6231
		private static readonly IntPtr NativeMethodInfoPtr_get_zyww_Public_get_half4_0;

		// Token: 0x04001858 RID: 6232
		private static readonly IntPtr NativeMethodInfoPtr_get_zzxx_Public_get_half4_0;

		// Token: 0x04001859 RID: 6233
		private static readonly IntPtr NativeMethodInfoPtr_get_zzxy_Public_get_half4_0;

		// Token: 0x0400185A RID: 6234
		private static readonly IntPtr NativeMethodInfoPtr_get_zzxz_Public_get_half4_0;

		// Token: 0x0400185B RID: 6235
		private static readonly IntPtr NativeMethodInfoPtr_get_zzxw_Public_get_half4_0;

		// Token: 0x0400185C RID: 6236
		private static readonly IntPtr NativeMethodInfoPtr_get_zzyx_Public_get_half4_0;

		// Token: 0x0400185D RID: 6237
		private static readonly IntPtr NativeMethodInfoPtr_get_zzyy_Public_get_half4_0;

		// Token: 0x0400185E RID: 6238
		private static readonly IntPtr NativeMethodInfoPtr_get_zzyz_Public_get_half4_0;

		// Token: 0x0400185F RID: 6239
		private static readonly IntPtr NativeMethodInfoPtr_get_zzyw_Public_get_half4_0;

		// Token: 0x04001860 RID: 6240
		private static readonly IntPtr NativeMethodInfoPtr_get_zzzx_Public_get_half4_0;

		// Token: 0x04001861 RID: 6241
		private static readonly IntPtr NativeMethodInfoPtr_get_zzzy_Public_get_half4_0;

		// Token: 0x04001862 RID: 6242
		private static readonly IntPtr NativeMethodInfoPtr_get_zzzz_Public_get_half4_0;

		// Token: 0x04001863 RID: 6243
		private static readonly IntPtr NativeMethodInfoPtr_get_zzzw_Public_get_half4_0;

		// Token: 0x04001864 RID: 6244
		private static readonly IntPtr NativeMethodInfoPtr_get_zzwx_Public_get_half4_0;

		// Token: 0x04001865 RID: 6245
		private static readonly IntPtr NativeMethodInfoPtr_get_zzwy_Public_get_half4_0;

		// Token: 0x04001866 RID: 6246
		private static readonly IntPtr NativeMethodInfoPtr_get_zzwz_Public_get_half4_0;

		// Token: 0x04001867 RID: 6247
		private static readonly IntPtr NativeMethodInfoPtr_get_zzww_Public_get_half4_0;

		// Token: 0x04001868 RID: 6248
		private static readonly IntPtr NativeMethodInfoPtr_get_zwxx_Public_get_half4_0;

		// Token: 0x04001869 RID: 6249
		private static readonly IntPtr NativeMethodInfoPtr_get_zwxy_Public_get_half4_0;

		// Token: 0x0400186A RID: 6250
		private static readonly IntPtr NativeMethodInfoPtr_set_zwxy_Public_set_Void_half4_0;

		// Token: 0x0400186B RID: 6251
		private static readonly IntPtr NativeMethodInfoPtr_get_zwxz_Public_get_half4_0;

		// Token: 0x0400186C RID: 6252
		private static readonly IntPtr NativeMethodInfoPtr_get_zwxw_Public_get_half4_0;

		// Token: 0x0400186D RID: 6253
		private static readonly IntPtr NativeMethodInfoPtr_get_zwyx_Public_get_half4_0;

		// Token: 0x0400186E RID: 6254
		private static readonly IntPtr NativeMethodInfoPtr_set_zwyx_Public_set_Void_half4_0;

		// Token: 0x0400186F RID: 6255
		private static readonly IntPtr NativeMethodInfoPtr_get_zwyy_Public_get_half4_0;

		// Token: 0x04001870 RID: 6256
		private static readonly IntPtr NativeMethodInfoPtr_get_zwyz_Public_get_half4_0;

		// Token: 0x04001871 RID: 6257
		private static readonly IntPtr NativeMethodInfoPtr_get_zwyw_Public_get_half4_0;

		// Token: 0x04001872 RID: 6258
		private static readonly IntPtr NativeMethodInfoPtr_get_zwzx_Public_get_half4_0;

		// Token: 0x04001873 RID: 6259
		private static readonly IntPtr NativeMethodInfoPtr_get_zwzy_Public_get_half4_0;

		// Token: 0x04001874 RID: 6260
		private static readonly IntPtr NativeMethodInfoPtr_get_zwzz_Public_get_half4_0;

		// Token: 0x04001875 RID: 6261
		private static readonly IntPtr NativeMethodInfoPtr_get_zwzw_Public_get_half4_0;

		// Token: 0x04001876 RID: 6262
		private static readonly IntPtr NativeMethodInfoPtr_get_zwwx_Public_get_half4_0;

		// Token: 0x04001877 RID: 6263
		private static readonly IntPtr NativeMethodInfoPtr_get_zwwy_Public_get_half4_0;

		// Token: 0x04001878 RID: 6264
		private static readonly IntPtr NativeMethodInfoPtr_get_zwwz_Public_get_half4_0;

		// Token: 0x04001879 RID: 6265
		private static readonly IntPtr NativeMethodInfoPtr_get_zwww_Public_get_half4_0;

		// Token: 0x0400187A RID: 6266
		private static readonly IntPtr NativeMethodInfoPtr_get_wxxx_Public_get_half4_0;

		// Token: 0x0400187B RID: 6267
		private static readonly IntPtr NativeMethodInfoPtr_get_wxxy_Public_get_half4_0;

		// Token: 0x0400187C RID: 6268
		private static readonly IntPtr NativeMethodInfoPtr_get_wxxz_Public_get_half4_0;

		// Token: 0x0400187D RID: 6269
		private static readonly IntPtr NativeMethodInfoPtr_get_wxxw_Public_get_half4_0;

		// Token: 0x0400187E RID: 6270
		private static readonly IntPtr NativeMethodInfoPtr_get_wxyx_Public_get_half4_0;

		// Token: 0x0400187F RID: 6271
		private static readonly IntPtr NativeMethodInfoPtr_get_wxyy_Public_get_half4_0;

		// Token: 0x04001880 RID: 6272
		private static readonly IntPtr NativeMethodInfoPtr_get_wxyz_Public_get_half4_0;

		// Token: 0x04001881 RID: 6273
		private static readonly IntPtr NativeMethodInfoPtr_set_wxyz_Public_set_Void_half4_0;

		// Token: 0x04001882 RID: 6274
		private static readonly IntPtr NativeMethodInfoPtr_get_wxyw_Public_get_half4_0;

		// Token: 0x04001883 RID: 6275
		private static readonly IntPtr NativeMethodInfoPtr_get_wxzx_Public_get_half4_0;

		// Token: 0x04001884 RID: 6276
		private static readonly IntPtr NativeMethodInfoPtr_get_wxzy_Public_get_half4_0;

		// Token: 0x04001885 RID: 6277
		private static readonly IntPtr NativeMethodInfoPtr_set_wxzy_Public_set_Void_half4_0;

		// Token: 0x04001886 RID: 6278
		private static readonly IntPtr NativeMethodInfoPtr_get_wxzz_Public_get_half4_0;

		// Token: 0x04001887 RID: 6279
		private static readonly IntPtr NativeMethodInfoPtr_get_wxzw_Public_get_half4_0;

		// Token: 0x04001888 RID: 6280
		private static readonly IntPtr NativeMethodInfoPtr_get_wxwx_Public_get_half4_0;

		// Token: 0x04001889 RID: 6281
		private static readonly IntPtr NativeMethodInfoPtr_get_wxwy_Public_get_half4_0;

		// Token: 0x0400188A RID: 6282
		private static readonly IntPtr NativeMethodInfoPtr_get_wxwz_Public_get_half4_0;

		// Token: 0x0400188B RID: 6283
		private static readonly IntPtr NativeMethodInfoPtr_get_wxww_Public_get_half4_0;

		// Token: 0x0400188C RID: 6284
		private static readonly IntPtr NativeMethodInfoPtr_get_wyxx_Public_get_half4_0;

		// Token: 0x0400188D RID: 6285
		private static readonly IntPtr NativeMethodInfoPtr_get_wyxy_Public_get_half4_0;

		// Token: 0x0400188E RID: 6286
		private static readonly IntPtr NativeMethodInfoPtr_get_wyxz_Public_get_half4_0;

		// Token: 0x0400188F RID: 6287
		private static readonly IntPtr NativeMethodInfoPtr_set_wyxz_Public_set_Void_half4_0;

		// Token: 0x04001890 RID: 6288
		private static readonly IntPtr NativeMethodInfoPtr_get_wyxw_Public_get_half4_0;

		// Token: 0x04001891 RID: 6289
		private static readonly IntPtr NativeMethodInfoPtr_get_wyyx_Public_get_half4_0;

		// Token: 0x04001892 RID: 6290
		private static readonly IntPtr NativeMethodInfoPtr_get_wyyy_Public_get_half4_0;

		// Token: 0x04001893 RID: 6291
		private static readonly IntPtr NativeMethodInfoPtr_get_wyyz_Public_get_half4_0;

		// Token: 0x04001894 RID: 6292
		private static readonly IntPtr NativeMethodInfoPtr_get_wyyw_Public_get_half4_0;

		// Token: 0x04001895 RID: 6293
		private static readonly IntPtr NativeMethodInfoPtr_get_wyzx_Public_get_half4_0;

		// Token: 0x04001896 RID: 6294
		private static readonly IntPtr NativeMethodInfoPtr_set_wyzx_Public_set_Void_half4_0;

		// Token: 0x04001897 RID: 6295
		private static readonly IntPtr NativeMethodInfoPtr_get_wyzy_Public_get_half4_0;

		// Token: 0x04001898 RID: 6296
		private static readonly IntPtr NativeMethodInfoPtr_get_wyzz_Public_get_half4_0;

		// Token: 0x04001899 RID: 6297
		private static readonly IntPtr NativeMethodInfoPtr_get_wyzw_Public_get_half4_0;

		// Token: 0x0400189A RID: 6298
		private static readonly IntPtr NativeMethodInfoPtr_get_wywx_Public_get_half4_0;

		// Token: 0x0400189B RID: 6299
		private static readonly IntPtr NativeMethodInfoPtr_get_wywy_Public_get_half4_0;

		// Token: 0x0400189C RID: 6300
		private static readonly IntPtr NativeMethodInfoPtr_get_wywz_Public_get_half4_0;

		// Token: 0x0400189D RID: 6301
		private static readonly IntPtr NativeMethodInfoPtr_get_wyww_Public_get_half4_0;

		// Token: 0x0400189E RID: 6302
		private static readonly IntPtr NativeMethodInfoPtr_get_wzxx_Public_get_half4_0;

		// Token: 0x0400189F RID: 6303
		private static readonly IntPtr NativeMethodInfoPtr_get_wzxy_Public_get_half4_0;

		// Token: 0x040018A0 RID: 6304
		private static readonly IntPtr NativeMethodInfoPtr_set_wzxy_Public_set_Void_half4_0;

		// Token: 0x040018A1 RID: 6305
		private static readonly IntPtr NativeMethodInfoPtr_get_wzxz_Public_get_half4_0;

		// Token: 0x040018A2 RID: 6306
		private static readonly IntPtr NativeMethodInfoPtr_get_wzxw_Public_get_half4_0;

		// Token: 0x040018A3 RID: 6307
		private static readonly IntPtr NativeMethodInfoPtr_get_wzyx_Public_get_half4_0;

		// Token: 0x040018A4 RID: 6308
		private static readonly IntPtr NativeMethodInfoPtr_set_wzyx_Public_set_Void_half4_0;

		// Token: 0x040018A5 RID: 6309
		private static readonly IntPtr NativeMethodInfoPtr_get_wzyy_Public_get_half4_0;

		// Token: 0x040018A6 RID: 6310
		private static readonly IntPtr NativeMethodInfoPtr_get_wzyz_Public_get_half4_0;

		// Token: 0x040018A7 RID: 6311
		private static readonly IntPtr NativeMethodInfoPtr_get_wzyw_Public_get_half4_0;

		// Token: 0x040018A8 RID: 6312
		private static readonly IntPtr NativeMethodInfoPtr_get_wzzx_Public_get_half4_0;

		// Token: 0x040018A9 RID: 6313
		private static readonly IntPtr NativeMethodInfoPtr_get_wzzy_Public_get_half4_0;

		// Token: 0x040018AA RID: 6314
		private static readonly IntPtr NativeMethodInfoPtr_get_wzzz_Public_get_half4_0;

		// Token: 0x040018AB RID: 6315
		private static readonly IntPtr NativeMethodInfoPtr_get_wzzw_Public_get_half4_0;

		// Token: 0x040018AC RID: 6316
		private static readonly IntPtr NativeMethodInfoPtr_get_wzwx_Public_get_half4_0;

		// Token: 0x040018AD RID: 6317
		private static readonly IntPtr NativeMethodInfoPtr_get_wzwy_Public_get_half4_0;

		// Token: 0x040018AE RID: 6318
		private static readonly IntPtr NativeMethodInfoPtr_get_wzwz_Public_get_half4_0;

		// Token: 0x040018AF RID: 6319
		private static readonly IntPtr NativeMethodInfoPtr_get_wzww_Public_get_half4_0;

		// Token: 0x040018B0 RID: 6320
		private static readonly IntPtr NativeMethodInfoPtr_get_wwxx_Public_get_half4_0;

		// Token: 0x040018B1 RID: 6321
		private static readonly IntPtr NativeMethodInfoPtr_get_wwxy_Public_get_half4_0;

		// Token: 0x040018B2 RID: 6322
		private static readonly IntPtr NativeMethodInfoPtr_get_wwxz_Public_get_half4_0;

		// Token: 0x040018B3 RID: 6323
		private static readonly IntPtr NativeMethodInfoPtr_get_wwxw_Public_get_half4_0;

		// Token: 0x040018B4 RID: 6324
		private static readonly IntPtr NativeMethodInfoPtr_get_wwyx_Public_get_half4_0;

		// Token: 0x040018B5 RID: 6325
		private static readonly IntPtr NativeMethodInfoPtr_get_wwyy_Public_get_half4_0;

		// Token: 0x040018B6 RID: 6326
		private static readonly IntPtr NativeMethodInfoPtr_get_wwyz_Public_get_half4_0;

		// Token: 0x040018B7 RID: 6327
		private static readonly IntPtr NativeMethodInfoPtr_get_wwyw_Public_get_half4_0;

		// Token: 0x040018B8 RID: 6328
		private static readonly IntPtr NativeMethodInfoPtr_get_wwzx_Public_get_half4_0;

		// Token: 0x040018B9 RID: 6329
		private static readonly IntPtr NativeMethodInfoPtr_get_wwzy_Public_get_half4_0;

		// Token: 0x040018BA RID: 6330
		private static readonly IntPtr NativeMethodInfoPtr_get_wwzz_Public_get_half4_0;

		// Token: 0x040018BB RID: 6331
		private static readonly IntPtr NativeMethodInfoPtr_get_wwzw_Public_get_half4_0;

		// Token: 0x040018BC RID: 6332
		private static readonly IntPtr NativeMethodInfoPtr_get_wwwx_Public_get_half4_0;

		// Token: 0x040018BD RID: 6333
		private static readonly IntPtr NativeMethodInfoPtr_get_wwwy_Public_get_half4_0;

		// Token: 0x040018BE RID: 6334
		private static readonly IntPtr NativeMethodInfoPtr_get_wwwz_Public_get_half4_0;

		// Token: 0x040018BF RID: 6335
		private static readonly IntPtr NativeMethodInfoPtr_get_wwww_Public_get_half4_0;

		// Token: 0x040018C0 RID: 6336
		private static readonly IntPtr NativeMethodInfoPtr_get_xxx_Public_get_half3_0;

		// Token: 0x040018C1 RID: 6337
		private static readonly IntPtr NativeMethodInfoPtr_get_xxy_Public_get_half3_0;

		// Token: 0x040018C2 RID: 6338
		private static readonly IntPtr NativeMethodInfoPtr_get_xxz_Public_get_half3_0;

		// Token: 0x040018C3 RID: 6339
		private static readonly IntPtr NativeMethodInfoPtr_get_xxw_Public_get_half3_0;

		// Token: 0x040018C4 RID: 6340
		private static readonly IntPtr NativeMethodInfoPtr_get_xyx_Public_get_half3_0;

		// Token: 0x040018C5 RID: 6341
		private static readonly IntPtr NativeMethodInfoPtr_get_xyy_Public_get_half3_0;

		// Token: 0x040018C6 RID: 6342
		private static readonly IntPtr NativeMethodInfoPtr_get_xyz_Public_get_half3_0;

		// Token: 0x040018C7 RID: 6343
		private static readonly IntPtr NativeMethodInfoPtr_set_xyz_Public_set_Void_half3_0;

		// Token: 0x040018C8 RID: 6344
		private static readonly IntPtr NativeMethodInfoPtr_get_xyw_Public_get_half3_0;

		// Token: 0x040018C9 RID: 6345
		private static readonly IntPtr NativeMethodInfoPtr_set_xyw_Public_set_Void_half3_0;

		// Token: 0x040018CA RID: 6346
		private static readonly IntPtr NativeMethodInfoPtr_get_xzx_Public_get_half3_0;

		// Token: 0x040018CB RID: 6347
		private static readonly IntPtr NativeMethodInfoPtr_get_xzy_Public_get_half3_0;

		// Token: 0x040018CC RID: 6348
		private static readonly IntPtr NativeMethodInfoPtr_set_xzy_Public_set_Void_half3_0;

		// Token: 0x040018CD RID: 6349
		private static readonly IntPtr NativeMethodInfoPtr_get_xzz_Public_get_half3_0;

		// Token: 0x040018CE RID: 6350
		private static readonly IntPtr NativeMethodInfoPtr_get_xzw_Public_get_half3_0;

		// Token: 0x040018CF RID: 6351
		private static readonly IntPtr NativeMethodInfoPtr_set_xzw_Public_set_Void_half3_0;

		// Token: 0x040018D0 RID: 6352
		private static readonly IntPtr NativeMethodInfoPtr_get_xwx_Public_get_half3_0;

		// Token: 0x040018D1 RID: 6353
		private static readonly IntPtr NativeMethodInfoPtr_get_xwy_Public_get_half3_0;

		// Token: 0x040018D2 RID: 6354
		private static readonly IntPtr NativeMethodInfoPtr_set_xwy_Public_set_Void_half3_0;

		// Token: 0x040018D3 RID: 6355
		private static readonly IntPtr NativeMethodInfoPtr_get_xwz_Public_get_half3_0;

		// Token: 0x040018D4 RID: 6356
		private static readonly IntPtr NativeMethodInfoPtr_set_xwz_Public_set_Void_half3_0;

		// Token: 0x040018D5 RID: 6357
		private static readonly IntPtr NativeMethodInfoPtr_get_xww_Public_get_half3_0;

		// Token: 0x040018D6 RID: 6358
		private static readonly IntPtr NativeMethodInfoPtr_get_yxx_Public_get_half3_0;

		// Token: 0x040018D7 RID: 6359
		private static readonly IntPtr NativeMethodInfoPtr_get_yxy_Public_get_half3_0;

		// Token: 0x040018D8 RID: 6360
		private static readonly IntPtr NativeMethodInfoPtr_get_yxz_Public_get_half3_0;

		// Token: 0x040018D9 RID: 6361
		private static readonly IntPtr NativeMethodInfoPtr_set_yxz_Public_set_Void_half3_0;

		// Token: 0x040018DA RID: 6362
		private static readonly IntPtr NativeMethodInfoPtr_get_yxw_Public_get_half3_0;

		// Token: 0x040018DB RID: 6363
		private static readonly IntPtr NativeMethodInfoPtr_set_yxw_Public_set_Void_half3_0;

		// Token: 0x040018DC RID: 6364
		private static readonly IntPtr NativeMethodInfoPtr_get_yyx_Public_get_half3_0;

		// Token: 0x040018DD RID: 6365
		private static readonly IntPtr NativeMethodInfoPtr_get_yyy_Public_get_half3_0;

		// Token: 0x040018DE RID: 6366
		private static readonly IntPtr NativeMethodInfoPtr_get_yyz_Public_get_half3_0;

		// Token: 0x040018DF RID: 6367
		private static readonly IntPtr NativeMethodInfoPtr_get_yyw_Public_get_half3_0;

		// Token: 0x040018E0 RID: 6368
		private static readonly IntPtr NativeMethodInfoPtr_get_yzx_Public_get_half3_0;

		// Token: 0x040018E1 RID: 6369
		private static readonly IntPtr NativeMethodInfoPtr_set_yzx_Public_set_Void_half3_0;

		// Token: 0x040018E2 RID: 6370
		private static readonly IntPtr NativeMethodInfoPtr_get_yzy_Public_get_half3_0;

		// Token: 0x040018E3 RID: 6371
		private static readonly IntPtr NativeMethodInfoPtr_get_yzz_Public_get_half3_0;

		// Token: 0x040018E4 RID: 6372
		private static readonly IntPtr NativeMethodInfoPtr_get_yzw_Public_get_half3_0;

		// Token: 0x040018E5 RID: 6373
		private static readonly IntPtr NativeMethodInfoPtr_set_yzw_Public_set_Void_half3_0;

		// Token: 0x040018E6 RID: 6374
		private static readonly IntPtr NativeMethodInfoPtr_get_ywx_Public_get_half3_0;

		// Token: 0x040018E7 RID: 6375
		private static readonly IntPtr NativeMethodInfoPtr_set_ywx_Public_set_Void_half3_0;

		// Token: 0x040018E8 RID: 6376
		private static readonly IntPtr NativeMethodInfoPtr_get_ywy_Public_get_half3_0;

		// Token: 0x040018E9 RID: 6377
		private static readonly IntPtr NativeMethodInfoPtr_get_ywz_Public_get_half3_0;

		// Token: 0x040018EA RID: 6378
		private static readonly IntPtr NativeMethodInfoPtr_set_ywz_Public_set_Void_half3_0;

		// Token: 0x040018EB RID: 6379
		private static readonly IntPtr NativeMethodInfoPtr_get_yww_Public_get_half3_0;

		// Token: 0x040018EC RID: 6380
		private static readonly IntPtr NativeMethodInfoPtr_get_zxx_Public_get_half3_0;

		// Token: 0x040018ED RID: 6381
		private static readonly IntPtr NativeMethodInfoPtr_get_zxy_Public_get_half3_0;

		// Token: 0x040018EE RID: 6382
		private static readonly IntPtr NativeMethodInfoPtr_set_zxy_Public_set_Void_half3_0;

		// Token: 0x040018EF RID: 6383
		private static readonly IntPtr NativeMethodInfoPtr_get_zxz_Public_get_half3_0;

		// Token: 0x040018F0 RID: 6384
		private static readonly IntPtr NativeMethodInfoPtr_get_zxw_Public_get_half3_0;

		// Token: 0x040018F1 RID: 6385
		private static readonly IntPtr NativeMethodInfoPtr_set_zxw_Public_set_Void_half3_0;

		// Token: 0x040018F2 RID: 6386
		private static readonly IntPtr NativeMethodInfoPtr_get_zyx_Public_get_half3_0;

		// Token: 0x040018F3 RID: 6387
		private static readonly IntPtr NativeMethodInfoPtr_set_zyx_Public_set_Void_half3_0;

		// Token: 0x040018F4 RID: 6388
		private static readonly IntPtr NativeMethodInfoPtr_get_zyy_Public_get_half3_0;

		// Token: 0x040018F5 RID: 6389
		private static readonly IntPtr NativeMethodInfoPtr_get_zyz_Public_get_half3_0;

		// Token: 0x040018F6 RID: 6390
		private static readonly IntPtr NativeMethodInfoPtr_get_zyw_Public_get_half3_0;

		// Token: 0x040018F7 RID: 6391
		private static readonly IntPtr NativeMethodInfoPtr_set_zyw_Public_set_Void_half3_0;

		// Token: 0x040018F8 RID: 6392
		private static readonly IntPtr NativeMethodInfoPtr_get_zzx_Public_get_half3_0;

		// Token: 0x040018F9 RID: 6393
		private static readonly IntPtr NativeMethodInfoPtr_get_zzy_Public_get_half3_0;

		// Token: 0x040018FA RID: 6394
		private static readonly IntPtr NativeMethodInfoPtr_get_zzz_Public_get_half3_0;

		// Token: 0x040018FB RID: 6395
		private static readonly IntPtr NativeMethodInfoPtr_get_zzw_Public_get_half3_0;

		// Token: 0x040018FC RID: 6396
		private static readonly IntPtr NativeMethodInfoPtr_get_zwx_Public_get_half3_0;

		// Token: 0x040018FD RID: 6397
		private static readonly IntPtr NativeMethodInfoPtr_set_zwx_Public_set_Void_half3_0;

		// Token: 0x040018FE RID: 6398
		private static readonly IntPtr NativeMethodInfoPtr_get_zwy_Public_get_half3_0;

		// Token: 0x040018FF RID: 6399
		private static readonly IntPtr NativeMethodInfoPtr_set_zwy_Public_set_Void_half3_0;

		// Token: 0x04001900 RID: 6400
		private static readonly IntPtr NativeMethodInfoPtr_get_zwz_Public_get_half3_0;

		// Token: 0x04001901 RID: 6401
		private static readonly IntPtr NativeMethodInfoPtr_get_zww_Public_get_half3_0;

		// Token: 0x04001902 RID: 6402
		private static readonly IntPtr NativeMethodInfoPtr_get_wxx_Public_get_half3_0;

		// Token: 0x04001903 RID: 6403
		private static readonly IntPtr NativeMethodInfoPtr_get_wxy_Public_get_half3_0;

		// Token: 0x04001904 RID: 6404
		private static readonly IntPtr NativeMethodInfoPtr_set_wxy_Public_set_Void_half3_0;

		// Token: 0x04001905 RID: 6405
		private static readonly IntPtr NativeMethodInfoPtr_get_wxz_Public_get_half3_0;

		// Token: 0x04001906 RID: 6406
		private static readonly IntPtr NativeMethodInfoPtr_set_wxz_Public_set_Void_half3_0;

		// Token: 0x04001907 RID: 6407
		private static readonly IntPtr NativeMethodInfoPtr_get_wxw_Public_get_half3_0;

		// Token: 0x04001908 RID: 6408
		private static readonly IntPtr NativeMethodInfoPtr_get_wyx_Public_get_half3_0;

		// Token: 0x04001909 RID: 6409
		private static readonly IntPtr NativeMethodInfoPtr_set_wyx_Public_set_Void_half3_0;

		// Token: 0x0400190A RID: 6410
		private static readonly IntPtr NativeMethodInfoPtr_get_wyy_Public_get_half3_0;

		// Token: 0x0400190B RID: 6411
		private static readonly IntPtr NativeMethodInfoPtr_get_wyz_Public_get_half3_0;

		// Token: 0x0400190C RID: 6412
		private static readonly IntPtr NativeMethodInfoPtr_set_wyz_Public_set_Void_half3_0;

		// Token: 0x0400190D RID: 6413
		private static readonly IntPtr NativeMethodInfoPtr_get_wyw_Public_get_half3_0;

		// Token: 0x0400190E RID: 6414
		private static readonly IntPtr NativeMethodInfoPtr_get_wzx_Public_get_half3_0;

		// Token: 0x0400190F RID: 6415
		private static readonly IntPtr NativeMethodInfoPtr_set_wzx_Public_set_Void_half3_0;

		// Token: 0x04001910 RID: 6416
		private static readonly IntPtr NativeMethodInfoPtr_get_wzy_Public_get_half3_0;

		// Token: 0x04001911 RID: 6417
		private static readonly IntPtr NativeMethodInfoPtr_set_wzy_Public_set_Void_half3_0;

		// Token: 0x04001912 RID: 6418
		private static readonly IntPtr NativeMethodInfoPtr_get_wzz_Public_get_half3_0;

		// Token: 0x04001913 RID: 6419
		private static readonly IntPtr NativeMethodInfoPtr_get_wzw_Public_get_half3_0;

		// Token: 0x04001914 RID: 6420
		private static readonly IntPtr NativeMethodInfoPtr_get_wwx_Public_get_half3_0;

		// Token: 0x04001915 RID: 6421
		private static readonly IntPtr NativeMethodInfoPtr_get_wwy_Public_get_half3_0;

		// Token: 0x04001916 RID: 6422
		private static readonly IntPtr NativeMethodInfoPtr_get_wwz_Public_get_half3_0;

		// Token: 0x04001917 RID: 6423
		private static readonly IntPtr NativeMethodInfoPtr_get_www_Public_get_half3_0;

		// Token: 0x04001918 RID: 6424
		private static readonly IntPtr NativeMethodInfoPtr_get_xx_Public_get_half2_0;

		// Token: 0x04001919 RID: 6425
		private static readonly IntPtr NativeMethodInfoPtr_get_xy_Public_get_half2_0;

		// Token: 0x0400191A RID: 6426
		private static readonly IntPtr NativeMethodInfoPtr_set_xy_Public_set_Void_half2_0;

		// Token: 0x0400191B RID: 6427
		private static readonly IntPtr NativeMethodInfoPtr_get_xz_Public_get_half2_0;

		// Token: 0x0400191C RID: 6428
		private static readonly IntPtr NativeMethodInfoPtr_set_xz_Public_set_Void_half2_0;

		// Token: 0x0400191D RID: 6429
		private static readonly IntPtr NativeMethodInfoPtr_get_xw_Public_get_half2_0;

		// Token: 0x0400191E RID: 6430
		private static readonly IntPtr NativeMethodInfoPtr_set_xw_Public_set_Void_half2_0;

		// Token: 0x0400191F RID: 6431
		private static readonly IntPtr NativeMethodInfoPtr_get_yx_Public_get_half2_0;

		// Token: 0x04001920 RID: 6432
		private static readonly IntPtr NativeMethodInfoPtr_set_yx_Public_set_Void_half2_0;

		// Token: 0x04001921 RID: 6433
		private static readonly IntPtr NativeMethodInfoPtr_get_yy_Public_get_half2_0;

		// Token: 0x04001922 RID: 6434
		private static readonly IntPtr NativeMethodInfoPtr_get_yz_Public_get_half2_0;

		// Token: 0x04001923 RID: 6435
		private static readonly IntPtr NativeMethodInfoPtr_set_yz_Public_set_Void_half2_0;

		// Token: 0x04001924 RID: 6436
		private static readonly IntPtr NativeMethodInfoPtr_get_yw_Public_get_half2_0;

		// Token: 0x04001925 RID: 6437
		private static readonly IntPtr NativeMethodInfoPtr_set_yw_Public_set_Void_half2_0;

		// Token: 0x04001926 RID: 6438
		private static readonly IntPtr NativeMethodInfoPtr_get_zx_Public_get_half2_0;

		// Token: 0x04001927 RID: 6439
		private static readonly IntPtr NativeMethodInfoPtr_set_zx_Public_set_Void_half2_0;

		// Token: 0x04001928 RID: 6440
		private static readonly IntPtr NativeMethodInfoPtr_get_zy_Public_get_half2_0;

		// Token: 0x04001929 RID: 6441
		private static readonly IntPtr NativeMethodInfoPtr_set_zy_Public_set_Void_half2_0;

		// Token: 0x0400192A RID: 6442
		private static readonly IntPtr NativeMethodInfoPtr_get_zz_Public_get_half2_0;

		// Token: 0x0400192B RID: 6443
		private static readonly IntPtr NativeMethodInfoPtr_get_zw_Public_get_half2_0;

		// Token: 0x0400192C RID: 6444
		private static readonly IntPtr NativeMethodInfoPtr_set_zw_Public_set_Void_half2_0;

		// Token: 0x0400192D RID: 6445
		private static readonly IntPtr NativeMethodInfoPtr_get_wx_Public_get_half2_0;

		// Token: 0x0400192E RID: 6446
		private static readonly IntPtr NativeMethodInfoPtr_set_wx_Public_set_Void_half2_0;

		// Token: 0x0400192F RID: 6447
		private static readonly IntPtr NativeMethodInfoPtr_get_wy_Public_get_half2_0;

		// Token: 0x04001930 RID: 6448
		private static readonly IntPtr NativeMethodInfoPtr_set_wy_Public_set_Void_half2_0;

		// Token: 0x04001931 RID: 6449
		private static readonly IntPtr NativeMethodInfoPtr_get_wz_Public_get_half2_0;

		// Token: 0x04001932 RID: 6450
		private static readonly IntPtr NativeMethodInfoPtr_set_wz_Public_set_Void_half2_0;

		// Token: 0x04001933 RID: 6451
		private static readonly IntPtr NativeMethodInfoPtr_get_ww_Public_get_half2_0;

		// Token: 0x04001934 RID: 6452
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_half_Int32_0;

		// Token: 0x04001935 RID: 6453
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_half_0;

		// Token: 0x04001936 RID: 6454
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_half4_0;

		// Token: 0x04001937 RID: 6455
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001938 RID: 6456
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001939 RID: 6457
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400193A RID: 6458
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x0400193B RID: 6459
		[FieldOffset(0)]
		public half x;

		// Token: 0x0400193C RID: 6460
		[FieldOffset(2)]
		public half y;

		// Token: 0x0400193D RID: 6461
		[FieldOffset(4)]
		public half z;

		// Token: 0x0400193E RID: 6462
		[FieldOffset(6)]
		public half w;

		// Token: 0x0200005F RID: 95
		public sealed class DebuggerProxy : Object
		{
			// Token: 0x0600261A RID: 9754 RVA: 0x000C3AB4 File Offset: 0x000C1CB4
			// Note: this type is marked as 'beforefieldinit'.
			static DebuggerProxy()
			{
				Il2CppClassPointerStore<half4.DebuggerProxy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<half4>.NativeClassPtr, "DebuggerProxy");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<half4.DebuggerProxy>.NativeClassPtr);
				half4.DebuggerProxy.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<half4.DebuggerProxy>.NativeClassPtr, "x");
				half4.DebuggerProxy.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<half4.DebuggerProxy>.NativeClassPtr, "y");
				half4.DebuggerProxy.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<half4.DebuggerProxy>.NativeClassPtr, "z");
				half4.DebuggerProxy.NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<half4.DebuggerProxy>.NativeClassPtr, "w");
				half4.DebuggerProxy.NativeMethodInfoPtr__ctor_Public_Void_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half4.DebuggerProxy>.NativeClassPtr, 100669485);
			}

			// Token: 0x0600261B RID: 9755 RVA: 0x000C3B44 File Offset: 0x000C1D44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639070, XrefRangeEnd = 639071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DebuggerProxy(half4 v)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<half4.DebuggerProxy>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half4.DebuggerProxy.NativeMethodInfoPtr__ctor_Public_Void_half4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600261C RID: 9756 RVA: 0x00002F9A File Offset: 0x0000119A
			public DebuggerProxy(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C11 RID: 3089
			// (get) Token: 0x0600261D RID: 9757 RVA: 0x000C3B8C File Offset: 0x000C1D8C
			// (set) Token: 0x0600261E RID: 9758 RVA: 0x00002FA3 File Offset: 0x000011A3
			public unsafe half x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(half4.DebuggerProxy.NativeFieldInfoPtr_x);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(half4.DebuggerProxy.NativeFieldInfoPtr_x)) = value;
				}
			}

			// Token: 0x17000C12 RID: 3090
			// (get) Token: 0x0600261F RID: 9759 RVA: 0x000C3BB4 File Offset: 0x000C1DB4
			// (set) Token: 0x06002620 RID: 9760 RVA: 0x00002FBE File Offset: 0x000011BE
			public unsafe half y
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(half4.DebuggerProxy.NativeFieldInfoPtr_y);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(half4.DebuggerProxy.NativeFieldInfoPtr_y)) = value;
				}
			}

			// Token: 0x17000C13 RID: 3091
			// (get) Token: 0x06002621 RID: 9761 RVA: 0x000C3BDC File Offset: 0x000C1DDC
			// (set) Token: 0x06002622 RID: 9762 RVA: 0x00002FD9 File Offset: 0x000011D9
			public unsafe half z
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(half4.DebuggerProxy.NativeFieldInfoPtr_z);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(half4.DebuggerProxy.NativeFieldInfoPtr_z)) = value;
				}
			}

			// Token: 0x17000C14 RID: 3092
			// (get) Token: 0x06002623 RID: 9763 RVA: 0x000C3C04 File Offset: 0x000C1E04
			// (set) Token: 0x06002624 RID: 9764 RVA: 0x00002FF4 File Offset: 0x000011F4
			public unsafe half w
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(half4.DebuggerProxy.NativeFieldInfoPtr_w);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(half4.DebuggerProxy.NativeFieldInfoPtr_w)) = value;
				}
			}

			// Token: 0x04002687 RID: 9863
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04002688 RID: 9864
			private static readonly IntPtr NativeFieldInfoPtr_y;

			// Token: 0x04002689 RID: 9865
			private static readonly IntPtr NativeFieldInfoPtr_z;

			// Token: 0x0400268A RID: 9866
			private static readonly IntPtr NativeFieldInfoPtr_w;

			// Token: 0x0400268B RID: 9867
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_half4_0;
		}
	}
}
