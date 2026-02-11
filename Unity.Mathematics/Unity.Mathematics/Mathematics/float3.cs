using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Unity.Mathematics
{
	// Token: 0x02000021 RID: 33
	[Serializable]
	[StructLayout(2)]
	public struct float3
	{
		// Token: 0x060011C7 RID: 4551 RVA: 0x000610E0 File Offset: 0x0005F2E0
		// Note: this type is marked as 'beforefieldinit'.
		static float3()
		{
			Il2CppClassPointerStore<float3>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "float3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<float3>.NativeClassPtr);
			float3.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float3>.NativeClassPtr, "x");
			float3.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float3>.NativeClassPtr, "y");
			float3.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float3>.NativeClassPtr, "z");
			float3.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float3>.NativeClassPtr, "zero");
			float3.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667712);
			float3.NativeMethodInfoPtr__ctor_Public_Void_Single_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667713);
			float3.NativeMethodInfoPtr__ctor_Public_Void_float2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667714);
			float3.NativeMethodInfoPtr__ctor_Public_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667715);
			float3.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667716);
			float3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667717);
			float3.NativeMethodInfoPtr__ctor_Public_Void_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667718);
			float3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667719);
			float3.NativeMethodInfoPtr__ctor_Public_Void_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667720);
			float3.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667721);
			float3.NativeMethodInfoPtr__ctor_Public_Void_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667722);
			float3.NativeMethodInfoPtr__ctor_Public_Void_half_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667723);
			float3.NativeMethodInfoPtr__ctor_Public_Void_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667724);
			float3.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667725);
			float3.NativeMethodInfoPtr__ctor_Public_Void_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667726);
			float3.NativeMethodInfoPtr_op_Implicit_Public_Static_float3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667727);
			float3.NativeMethodInfoPtr_op_Explicit_Public_Static_float3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667728);
			float3.NativeMethodInfoPtr_op_Explicit_Public_Static_float3_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667729);
			float3.NativeMethodInfoPtr_op_Implicit_Public_Static_float3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667730);
			float3.NativeMethodInfoPtr_op_Implicit_Public_Static_float3_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667731);
			float3.NativeMethodInfoPtr_op_Implicit_Public_Static_float3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667732);
			float3.NativeMethodInfoPtr_op_Implicit_Public_Static_float3_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667733);
			float3.NativeMethodInfoPtr_op_Implicit_Public_Static_float3_half_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667734);
			float3.NativeMethodInfoPtr_op_Implicit_Public_Static_float3_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667735);
			float3.NativeMethodInfoPtr_op_Explicit_Public_Static_float3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667736);
			float3.NativeMethodInfoPtr_op_Explicit_Public_Static_float3_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667737);
			float3.NativeMethodInfoPtr_op_Multiply_Public_Static_float3_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667738);
			float3.NativeMethodInfoPtr_op_Multiply_Public_Static_float3_float3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667739);
			float3.NativeMethodInfoPtr_op_Multiply_Public_Static_float3_Single_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667740);
			float3.NativeMethodInfoPtr_op_Addition_Public_Static_float3_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667741);
			float3.NativeMethodInfoPtr_op_Addition_Public_Static_float3_float3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667742);
			float3.NativeMethodInfoPtr_op_Addition_Public_Static_float3_Single_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667743);
			float3.NativeMethodInfoPtr_op_Subtraction_Public_Static_float3_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667744);
			float3.NativeMethodInfoPtr_op_Subtraction_Public_Static_float3_float3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667745);
			float3.NativeMethodInfoPtr_op_Subtraction_Public_Static_float3_Single_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667746);
			float3.NativeMethodInfoPtr_op_Division_Public_Static_float3_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667747);
			float3.NativeMethodInfoPtr_op_Division_Public_Static_float3_float3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667748);
			float3.NativeMethodInfoPtr_op_Division_Public_Static_float3_Single_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667749);
			float3.NativeMethodInfoPtr_op_Modulus_Public_Static_float3_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667750);
			float3.NativeMethodInfoPtr_op_Modulus_Public_Static_float3_float3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667751);
			float3.NativeMethodInfoPtr_op_Modulus_Public_Static_float3_Single_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667752);
			float3.NativeMethodInfoPtr_op_Increment_Public_Static_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667753);
			float3.NativeMethodInfoPtr_op_Decrement_Public_Static_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667754);
			float3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667755);
			float3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3_float3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667756);
			float3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3_Single_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667757);
			float3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667758);
			float3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3_float3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667759);
			float3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3_Single_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667760);
			float3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667761);
			float3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3_float3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667762);
			float3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3_Single_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667763);
			float3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667764);
			float3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3_float3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667765);
			float3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3_Single_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667766);
			float3.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667767);
			float3.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667768);
			float3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667769);
			float3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3_float3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667770);
			float3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3_Single_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667771);
			float3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667772);
			float3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_float3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667773);
			float3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_Single_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667774);
			float3.NativeMethodInfoPtr_get_xxxx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667775);
			float3.NativeMethodInfoPtr_get_xxxy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667776);
			float3.NativeMethodInfoPtr_get_xxxz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667777);
			float3.NativeMethodInfoPtr_get_xxyx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667778);
			float3.NativeMethodInfoPtr_get_xxyy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667779);
			float3.NativeMethodInfoPtr_get_xxyz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667780);
			float3.NativeMethodInfoPtr_get_xxzx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667781);
			float3.NativeMethodInfoPtr_get_xxzy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667782);
			float3.NativeMethodInfoPtr_get_xxzz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667783);
			float3.NativeMethodInfoPtr_get_xyxx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667784);
			float3.NativeMethodInfoPtr_get_xyxy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667785);
			float3.NativeMethodInfoPtr_get_xyxz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667786);
			float3.NativeMethodInfoPtr_get_xyyx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667787);
			float3.NativeMethodInfoPtr_get_xyyy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667788);
			float3.NativeMethodInfoPtr_get_xyyz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667789);
			float3.NativeMethodInfoPtr_get_xyzx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667790);
			float3.NativeMethodInfoPtr_get_xyzy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667791);
			float3.NativeMethodInfoPtr_get_xyzz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667792);
			float3.NativeMethodInfoPtr_get_xzxx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667793);
			float3.NativeMethodInfoPtr_get_xzxy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667794);
			float3.NativeMethodInfoPtr_get_xzxz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667795);
			float3.NativeMethodInfoPtr_get_xzyx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667796);
			float3.NativeMethodInfoPtr_get_xzyy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667797);
			float3.NativeMethodInfoPtr_get_xzyz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667798);
			float3.NativeMethodInfoPtr_get_xzzx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667799);
			float3.NativeMethodInfoPtr_get_xzzy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667800);
			float3.NativeMethodInfoPtr_get_xzzz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667801);
			float3.NativeMethodInfoPtr_get_yxxx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667802);
			float3.NativeMethodInfoPtr_get_yxxy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667803);
			float3.NativeMethodInfoPtr_get_yxxz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667804);
			float3.NativeMethodInfoPtr_get_yxyx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667805);
			float3.NativeMethodInfoPtr_get_yxyy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667806);
			float3.NativeMethodInfoPtr_get_yxyz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667807);
			float3.NativeMethodInfoPtr_get_yxzx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667808);
			float3.NativeMethodInfoPtr_get_yxzy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667809);
			float3.NativeMethodInfoPtr_get_yxzz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667810);
			float3.NativeMethodInfoPtr_get_yyxx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667811);
			float3.NativeMethodInfoPtr_get_yyxy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667812);
			float3.NativeMethodInfoPtr_get_yyxz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667813);
			float3.NativeMethodInfoPtr_get_yyyx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667814);
			float3.NativeMethodInfoPtr_get_yyyy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667815);
			float3.NativeMethodInfoPtr_get_yyyz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667816);
			float3.NativeMethodInfoPtr_get_yyzx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667817);
			float3.NativeMethodInfoPtr_get_yyzy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667818);
			float3.NativeMethodInfoPtr_get_yyzz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667819);
			float3.NativeMethodInfoPtr_get_yzxx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667820);
			float3.NativeMethodInfoPtr_get_yzxy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667821);
			float3.NativeMethodInfoPtr_get_yzxz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667822);
			float3.NativeMethodInfoPtr_get_yzyx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667823);
			float3.NativeMethodInfoPtr_get_yzyy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667824);
			float3.NativeMethodInfoPtr_get_yzyz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667825);
			float3.NativeMethodInfoPtr_get_yzzx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667826);
			float3.NativeMethodInfoPtr_get_yzzy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667827);
			float3.NativeMethodInfoPtr_get_yzzz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667828);
			float3.NativeMethodInfoPtr_get_zxxx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667829);
			float3.NativeMethodInfoPtr_get_zxxy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667830);
			float3.NativeMethodInfoPtr_get_zxxz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667831);
			float3.NativeMethodInfoPtr_get_zxyx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667832);
			float3.NativeMethodInfoPtr_get_zxyy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667833);
			float3.NativeMethodInfoPtr_get_zxyz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667834);
			float3.NativeMethodInfoPtr_get_zxzx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667835);
			float3.NativeMethodInfoPtr_get_zxzy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667836);
			float3.NativeMethodInfoPtr_get_zxzz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667837);
			float3.NativeMethodInfoPtr_get_zyxx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667838);
			float3.NativeMethodInfoPtr_get_zyxy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667839);
			float3.NativeMethodInfoPtr_get_zyxz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667840);
			float3.NativeMethodInfoPtr_get_zyyx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667841);
			float3.NativeMethodInfoPtr_get_zyyy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667842);
			float3.NativeMethodInfoPtr_get_zyyz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667843);
			float3.NativeMethodInfoPtr_get_zyzx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667844);
			float3.NativeMethodInfoPtr_get_zyzy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667845);
			float3.NativeMethodInfoPtr_get_zyzz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667846);
			float3.NativeMethodInfoPtr_get_zzxx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667847);
			float3.NativeMethodInfoPtr_get_zzxy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667848);
			float3.NativeMethodInfoPtr_get_zzxz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667849);
			float3.NativeMethodInfoPtr_get_zzyx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667850);
			float3.NativeMethodInfoPtr_get_zzyy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667851);
			float3.NativeMethodInfoPtr_get_zzyz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667852);
			float3.NativeMethodInfoPtr_get_zzzx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667853);
			float3.NativeMethodInfoPtr_get_zzzy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667854);
			float3.NativeMethodInfoPtr_get_zzzz_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667855);
			float3.NativeMethodInfoPtr_get_xxx_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667856);
			float3.NativeMethodInfoPtr_get_xxy_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667857);
			float3.NativeMethodInfoPtr_get_xxz_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667858);
			float3.NativeMethodInfoPtr_get_xyx_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667859);
			float3.NativeMethodInfoPtr_get_xyy_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667860);
			float3.NativeMethodInfoPtr_get_xyz_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667861);
			float3.NativeMethodInfoPtr_set_xyz_Public_set_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667862);
			float3.NativeMethodInfoPtr_get_xzx_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667863);
			float3.NativeMethodInfoPtr_get_xzy_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667864);
			float3.NativeMethodInfoPtr_set_xzy_Public_set_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667865);
			float3.NativeMethodInfoPtr_get_xzz_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667866);
			float3.NativeMethodInfoPtr_get_yxx_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667867);
			float3.NativeMethodInfoPtr_get_yxy_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667868);
			float3.NativeMethodInfoPtr_get_yxz_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667869);
			float3.NativeMethodInfoPtr_set_yxz_Public_set_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667870);
			float3.NativeMethodInfoPtr_get_yyx_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667871);
			float3.NativeMethodInfoPtr_get_yyy_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667872);
			float3.NativeMethodInfoPtr_get_yyz_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667873);
			float3.NativeMethodInfoPtr_get_yzx_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667874);
			float3.NativeMethodInfoPtr_set_yzx_Public_set_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667875);
			float3.NativeMethodInfoPtr_get_yzy_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667876);
			float3.NativeMethodInfoPtr_get_yzz_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667877);
			float3.NativeMethodInfoPtr_get_zxx_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667878);
			float3.NativeMethodInfoPtr_get_zxy_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667879);
			float3.NativeMethodInfoPtr_set_zxy_Public_set_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667880);
			float3.NativeMethodInfoPtr_get_zxz_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667881);
			float3.NativeMethodInfoPtr_get_zyx_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667882);
			float3.NativeMethodInfoPtr_set_zyx_Public_set_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667883);
			float3.NativeMethodInfoPtr_get_zyy_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667884);
			float3.NativeMethodInfoPtr_get_zyz_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667885);
			float3.NativeMethodInfoPtr_get_zzx_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667886);
			float3.NativeMethodInfoPtr_get_zzy_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667887);
			float3.NativeMethodInfoPtr_get_zzz_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667888);
			float3.NativeMethodInfoPtr_get_xx_Public_get_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667889);
			float3.NativeMethodInfoPtr_get_xy_Public_get_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667890);
			float3.NativeMethodInfoPtr_set_xy_Public_set_Void_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667891);
			float3.NativeMethodInfoPtr_get_xz_Public_get_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667892);
			float3.NativeMethodInfoPtr_set_xz_Public_set_Void_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667893);
			float3.NativeMethodInfoPtr_get_yx_Public_get_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667894);
			float3.NativeMethodInfoPtr_set_yx_Public_set_Void_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667895);
			float3.NativeMethodInfoPtr_get_yy_Public_get_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667896);
			float3.NativeMethodInfoPtr_get_yz_Public_get_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667897);
			float3.NativeMethodInfoPtr_set_yz_Public_set_Void_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667898);
			float3.NativeMethodInfoPtr_get_zx_Public_get_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667899);
			float3.NativeMethodInfoPtr_set_zx_Public_set_Void_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667900);
			float3.NativeMethodInfoPtr_get_zy_Public_get_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667901);
			float3.NativeMethodInfoPtr_set_zy_Public_set_Void_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667902);
			float3.NativeMethodInfoPtr_get_zz_Public_get_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667903);
			float3.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667904);
			float3.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667905);
			float3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667906);
			float3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667907);
			float3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667908);
			float3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667909);
			float3.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667910);
			float3.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667911);
			float3.NativeMethodInfoPtr_op_Implicit_Public_Static_float3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3>.NativeClassPtr, 100667912);
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x00062114 File Offset: 0x00060314
		[CallerCount(0)]
		public unsafe float3(float x, float y, float z)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x00062164 File Offset: 0x00060364
		[CallerCount(0)]
		public unsafe float3(float x, float2 yz)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yz;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr__ctor_Public_Void_Single_float2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x000621A4 File Offset: 0x000603A4
		[CallerCount(0)]
		public unsafe float3(float2 xy, float z)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xy;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr__ctor_Public_Void_float2_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x000621E4 File Offset: 0x000603E4
		[CallerCount(0)]
		public unsafe float3(float3 xyz)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyz;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr__ctor_Public_Void_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x00062218 File Offset: 0x00060418
		[CallerCount(0)]
		public unsafe float3(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x0006224C File Offset: 0x0006044C
		[CallerCount(0)]
		public unsafe float3(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x00062280 File Offset: 0x00060480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637149, XrefRangeEnd = 637151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float3(bool3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr__ctor_Public_Void_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x000622B4 File Offset: 0x000604B4
		[CallerCount(0)]
		public unsafe float3(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x000622E8 File Offset: 0x000604E8
		[CallerCount(0)]
		public unsafe float3(int3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr__ctor_Public_Void_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011D1 RID: 4561 RVA: 0x0006231C File Offset: 0x0006051C
		[CallerCount(0)]
		public unsafe float3(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x00062350 File Offset: 0x00060550
		[CallerCount(0)]
		public unsafe float3(uint3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr__ctor_Public_Void_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x00062384 File Offset: 0x00060584
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 637151, RefRangeEnd = 637152, XrefRangeStart = 637151, XrefRangeEnd = 637151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float3(half v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr__ctor_Public_Void_half_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x000623B8 File Offset: 0x000605B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 637152, RefRangeEnd = 637153, XrefRangeStart = 637152, XrefRangeEnd = 637152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float3(half3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr__ctor_Public_Void_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x000623EC File Offset: 0x000605EC
		[CallerCount(0)]
		public unsafe float3(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x00062420 File Offset: 0x00060620
		[CallerCount(0)]
		public unsafe float3(double3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr__ctor_Public_Void_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x00062454 File Offset: 0x00060654
		[CallerCount(0)]
		public unsafe static implicit operator float3(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_Implicit_Public_Static_float3_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x00062494 File Offset: 0x00060694
		[CallerCount(0)]
		public unsafe static explicit operator float3(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_Explicit_Public_Static_float3_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x000624D4 File Offset: 0x000606D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator float3(bool3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_Explicit_Public_Static_float3_bool3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x00062514 File Offset: 0x00060714
		[CallerCount(0)]
		public unsafe static implicit operator float3(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_Implicit_Public_Static_float3_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x00062554 File Offset: 0x00060754
		[CallerCount(0)]
		public unsafe static implicit operator float3(int3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_Implicit_Public_Static_float3_int3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x00062594 File Offset: 0x00060794
		[CallerCount(0)]
		public unsafe static implicit operator float3(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_Implicit_Public_Static_float3_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x000625D4 File Offset: 0x000607D4
		[CallerCount(0)]
		public unsafe static implicit operator float3(uint3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_Implicit_Public_Static_float3_uint3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x00062614 File Offset: 0x00060814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637153, XrefRangeEnd = 637154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator float3(half v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_Implicit_Public_Static_float3_half_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011DF RID: 4575 RVA: 0x00062654 File Offset: 0x00060854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637154, XrefRangeEnd = 637155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator float3(half3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_Implicit_Public_Static_float3_half3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011E0 RID: 4576 RVA: 0x00062694 File Offset: 0x00060894
		[CallerCount(0)]
		public unsafe static explicit operator float3(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_Explicit_Public_Static_float3_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011E1 RID: 4577 RVA: 0x000626D4 File Offset: 0x000608D4
		[CallerCount(0)]
		public unsafe static explicit operator float3(double3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_Explicit_Public_Static_float3_double3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x00062714 File Offset: 0x00060914
		[CallerCount(0)]
		public unsafe static float3 operator *(float3 lhs, float3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_Multiply_Public_Static_float3_float3_float3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x00062760 File Offset: 0x00060960
		[CallerCount(0)]
		public unsafe static float3 operator *(float3 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_Multiply_Public_Static_float3_float3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x000627AC File Offset: 0x000609AC
		[CallerCount(0)]
		public unsafe static float3 operator *(float lhs, float3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_Multiply_Public_Static_float3_Single_float3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x000627F8 File Offset: 0x000609F8
		[CallerCount(0)]
		public unsafe static float3 operator +(float3 lhs, float3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_Addition_Public_Static_float3_float3_float3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x00062844 File Offset: 0x00060A44
		[CallerCount(0)]
		public unsafe static float3 operator +(float3 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_Addition_Public_Static_float3_float3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011E7 RID: 4583 RVA: 0x00062890 File Offset: 0x00060A90
		[CallerCount(0)]
		public unsafe static float3 operator +(float lhs, float3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_Addition_Public_Static_float3_Single_float3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x000628DC File Offset: 0x00060ADC
		[CallerCount(0)]
		public unsafe static float3 operator -(float3 lhs, float3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_Subtraction_Public_Static_float3_float3_float3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x00062928 File Offset: 0x00060B28
		[CallerCount(0)]
		public unsafe static float3 operator -(float3 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_Subtraction_Public_Static_float3_float3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x00062974 File Offset: 0x00060B74
		[CallerCount(0)]
		public unsafe static float3 operator -(float lhs, float3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_Subtraction_Public_Static_float3_Single_float3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x000629C0 File Offset: 0x00060BC0
		[CallerCount(0)]
		public unsafe static float3 operator /(float3 lhs, float3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_Division_Public_Static_float3_float3_float3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x00062A0C File Offset: 0x00060C0C
		[CallerCount(0)]
		public unsafe static float3 operator /(float3 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_Division_Public_Static_float3_float3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x00062A58 File Offset: 0x00060C58
		[CallerCount(0)]
		public unsafe static float3 operator /(float lhs, float3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_Division_Public_Static_float3_Single_float3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x00062AA4 File Offset: 0x00060CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float3 operator %(float3 lhs, float3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_Modulus_Public_Static_float3_float3_float3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x00062AF0 File Offset: 0x00060CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637155, XrefRangeEnd = 637158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float3 operator %(float3 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_Modulus_Public_Static_float3_float3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x00062B3C File Offset: 0x00060D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637158, XrefRangeEnd = 637161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float3 operator %(float lhs, float3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_Modulus_Public_Static_float3_Single_float3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x00062B88 File Offset: 0x00060D88
		[CallerCount(0)]
		public unsafe static float3 operator ++(float3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_Increment_Public_Static_float3_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x00062BC8 File Offset: 0x00060DC8
		[CallerCount(0)]
		public unsafe static float3 operator --(float3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_Decrement_Public_Static_float3_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011F3 RID: 4595 RVA: 0x00062C08 File Offset: 0x00060E08
		[CallerCount(0)]
		public unsafe static bool3 operator <(float3 lhs, float3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3_float3_float3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x00062C54 File Offset: 0x00060E54
		[CallerCount(0)]
		public unsafe static bool3 operator <(float3 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3_float3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x00062CA0 File Offset: 0x00060EA0
		[CallerCount(0)]
		public unsafe static bool3 operator <(float lhs, float3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3_Single_float3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x00062CEC File Offset: 0x00060EEC
		[CallerCount(0)]
		public unsafe static bool3 operator <=(float3 lhs, float3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3_float3_float3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x00062D38 File Offset: 0x00060F38
		[CallerCount(0)]
		public unsafe static bool3 operator <=(float3 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3_float3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x00062D84 File Offset: 0x00060F84
		[CallerCount(0)]
		public unsafe static bool3 operator <=(float lhs, float3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3_Single_float3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x00062DD0 File Offset: 0x00060FD0
		[CallerCount(0)]
		public unsafe static bool3 operator >(float3 lhs, float3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3_float3_float3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x00062E1C File Offset: 0x0006101C
		[CallerCount(0)]
		public unsafe static bool3 operator >(float3 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3_float3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x00062E68 File Offset: 0x00061068
		[CallerCount(0)]
		public unsafe static bool3 operator >(float lhs, float3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3_Single_float3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x00062EB4 File Offset: 0x000610B4
		[CallerCount(0)]
		public unsafe static bool3 operator >=(float3 lhs, float3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3_float3_float3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x00062F00 File Offset: 0x00061100
		[CallerCount(0)]
		public unsafe static bool3 operator >=(float3 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3_float3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011FE RID: 4606 RVA: 0x00062F4C File Offset: 0x0006114C
		[CallerCount(0)]
		public unsafe static bool3 operator >=(float lhs, float3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3_Single_float3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x00062F98 File Offset: 0x00061198
		[CallerCount(0)]
		public unsafe static float3 operator -(float3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_float3_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x00062FD8 File Offset: 0x000611D8
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 637161, RefRangeEnd = 637182, XrefRangeStart = 637161, XrefRangeEnd = 637161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float3 operator +(float3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_float3_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x00063018 File Offset: 0x00061218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637182, XrefRangeEnd = 637184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool3 operator ==(float3 lhs, float3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3_float3_float3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x00063064 File Offset: 0x00061264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637184, XrefRangeEnd = 637186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool3 operator ==(float3 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3_float3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x000630B0 File Offset: 0x000612B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637186, XrefRangeEnd = 637188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool3 operator ==(float lhs, float3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3_Single_float3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x000630FC File Offset: 0x000612FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637188, XrefRangeEnd = 637190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool3 operator !=(float3 lhs, float3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_float3_float3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x00063148 File Offset: 0x00061348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637190, XrefRangeEnd = 637192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool3 operator !=(float3 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_float3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x00063194 File Offset: 0x00061394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637192, XrefRangeEnd = 637194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool3 operator !=(float lhs, float3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_Single_float3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06001207 RID: 4615 RVA: 0x000631E0 File Offset: 0x000613E0
		public unsafe float4 xxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_xxxx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06001208 RID: 4616 RVA: 0x00063210 File Offset: 0x00061410
		public unsafe float4 xxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_xxxy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06001209 RID: 4617 RVA: 0x00063240 File Offset: 0x00061440
		public unsafe float4 xxxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_xxxz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x0600120A RID: 4618 RVA: 0x00063270 File Offset: 0x00061470
		public unsafe float4 xxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_xxyx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x0600120B RID: 4619 RVA: 0x000632A0 File Offset: 0x000614A0
		public unsafe float4 xxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_xxyy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x0600120C RID: 4620 RVA: 0x000632D0 File Offset: 0x000614D0
		public unsafe float4 xxyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_xxyz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x0600120D RID: 4621 RVA: 0x00063300 File Offset: 0x00061500
		public unsafe float4 xxzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_xxzx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x0600120E RID: 4622 RVA: 0x00063330 File Offset: 0x00061530
		public unsafe float4 xxzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_xxzy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x0600120F RID: 4623 RVA: 0x00063360 File Offset: 0x00061560
		public unsafe float4 xxzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_xxzz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06001210 RID: 4624 RVA: 0x00063390 File Offset: 0x00061590
		public unsafe float4 xyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_xyxx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06001211 RID: 4625 RVA: 0x000633C0 File Offset: 0x000615C0
		public unsafe float4 xyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_xyxy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06001212 RID: 4626 RVA: 0x000633F0 File Offset: 0x000615F0
		public unsafe float4 xyxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_xyxz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06001213 RID: 4627 RVA: 0x00063420 File Offset: 0x00061620
		public unsafe float4 xyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_xyyx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06001214 RID: 4628 RVA: 0x00063450 File Offset: 0x00061650
		public unsafe float4 xyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_xyyy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06001215 RID: 4629 RVA: 0x00063480 File Offset: 0x00061680
		public unsafe float4 xyyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_xyyz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06001216 RID: 4630 RVA: 0x000634B0 File Offset: 0x000616B0
		public unsafe float4 xyzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_xyzx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06001217 RID: 4631 RVA: 0x000634E0 File Offset: 0x000616E0
		public unsafe float4 xyzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_xyzy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06001218 RID: 4632 RVA: 0x00063510 File Offset: 0x00061710
		public unsafe float4 xyzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_xyzz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06001219 RID: 4633 RVA: 0x00063540 File Offset: 0x00061740
		public unsafe float4 xzxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_xzxx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x0600121A RID: 4634 RVA: 0x00063570 File Offset: 0x00061770
		public unsafe float4 xzxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_xzxy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x0600121B RID: 4635 RVA: 0x000635A0 File Offset: 0x000617A0
		public unsafe float4 xzxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_xzxz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x0600121C RID: 4636 RVA: 0x000635D0 File Offset: 0x000617D0
		public unsafe float4 xzyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_xzyx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x0600121D RID: 4637 RVA: 0x00063600 File Offset: 0x00061800
		public unsafe float4 xzyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_xzyy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x0600121E RID: 4638 RVA: 0x00063630 File Offset: 0x00061830
		public unsafe float4 xzyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_xzyz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x0600121F RID: 4639 RVA: 0x00063660 File Offset: 0x00061860
		public unsafe float4 xzzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_xzzx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06001220 RID: 4640 RVA: 0x00063690 File Offset: 0x00061890
		public unsafe float4 xzzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_xzzy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06001221 RID: 4641 RVA: 0x000636C0 File Offset: 0x000618C0
		public unsafe float4 xzzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_xzzz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06001222 RID: 4642 RVA: 0x000636F0 File Offset: 0x000618F0
		public unsafe float4 yxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_yxxx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06001223 RID: 4643 RVA: 0x00063720 File Offset: 0x00061920
		public unsafe float4 yxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_yxxy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06001224 RID: 4644 RVA: 0x00063750 File Offset: 0x00061950
		public unsafe float4 yxxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_yxxz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06001225 RID: 4645 RVA: 0x00063780 File Offset: 0x00061980
		public unsafe float4 yxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_yxyx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06001226 RID: 4646 RVA: 0x000637B0 File Offset: 0x000619B0
		public unsafe float4 yxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_yxyy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06001227 RID: 4647 RVA: 0x000637E0 File Offset: 0x000619E0
		public unsafe float4 yxyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_yxyz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06001228 RID: 4648 RVA: 0x00063810 File Offset: 0x00061A10
		public unsafe float4 yxzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_yxzx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06001229 RID: 4649 RVA: 0x00063840 File Offset: 0x00061A40
		public unsafe float4 yxzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_yxzy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x0600122A RID: 4650 RVA: 0x00063870 File Offset: 0x00061A70
		public unsafe float4 yxzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_yxzz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x0600122B RID: 4651 RVA: 0x000638A0 File Offset: 0x00061AA0
		public unsafe float4 yyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_yyxx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x0600122C RID: 4652 RVA: 0x000638D0 File Offset: 0x00061AD0
		public unsafe float4 yyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_yyxy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x0600122D RID: 4653 RVA: 0x00063900 File Offset: 0x00061B00
		public unsafe float4 yyxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_yyxz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x0600122E RID: 4654 RVA: 0x00063930 File Offset: 0x00061B30
		public unsafe float4 yyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_yyyx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x0600122F RID: 4655 RVA: 0x00063960 File Offset: 0x00061B60
		public unsafe float4 yyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_yyyy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06001230 RID: 4656 RVA: 0x00063990 File Offset: 0x00061B90
		public unsafe float4 yyyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_yyyz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06001231 RID: 4657 RVA: 0x000639C0 File Offset: 0x00061BC0
		public unsafe float4 yyzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_yyzx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06001232 RID: 4658 RVA: 0x000639F0 File Offset: 0x00061BF0
		public unsafe float4 yyzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_yyzy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06001233 RID: 4659 RVA: 0x00063A20 File Offset: 0x00061C20
		public unsafe float4 yyzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_yyzz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06001234 RID: 4660 RVA: 0x00063A50 File Offset: 0x00061C50
		public unsafe float4 yzxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_yzxx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06001235 RID: 4661 RVA: 0x00063A80 File Offset: 0x00061C80
		public unsafe float4 yzxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_yzxy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06001236 RID: 4662 RVA: 0x00063AB0 File Offset: 0x00061CB0
		public unsafe float4 yzxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_yzxz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06001237 RID: 4663 RVA: 0x00063AE0 File Offset: 0x00061CE0
		public unsafe float4 yzyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_yzyx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06001238 RID: 4664 RVA: 0x00063B10 File Offset: 0x00061D10
		public unsafe float4 yzyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_yzyy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06001239 RID: 4665 RVA: 0x00063B40 File Offset: 0x00061D40
		public unsafe float4 yzyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_yzyz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x0600123A RID: 4666 RVA: 0x00063B70 File Offset: 0x00061D70
		public unsafe float4 yzzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_yzzx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x0600123B RID: 4667 RVA: 0x00063BA0 File Offset: 0x00061DA0
		public unsafe float4 yzzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_yzzy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x0600123C RID: 4668 RVA: 0x00063BD0 File Offset: 0x00061DD0
		public unsafe float4 yzzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_yzzz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x0600123D RID: 4669 RVA: 0x00063C00 File Offset: 0x00061E00
		public unsafe float4 zxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_zxxx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x0600123E RID: 4670 RVA: 0x00063C30 File Offset: 0x00061E30
		public unsafe float4 zxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_zxxy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x0600123F RID: 4671 RVA: 0x00063C60 File Offset: 0x00061E60
		public unsafe float4 zxxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_zxxz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06001240 RID: 4672 RVA: 0x00063C90 File Offset: 0x00061E90
		public unsafe float4 zxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_zxyx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06001241 RID: 4673 RVA: 0x00063CC0 File Offset: 0x00061EC0
		public unsafe float4 zxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_zxyy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06001242 RID: 4674 RVA: 0x00063CF0 File Offset: 0x00061EF0
		public unsafe float4 zxyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_zxyz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06001243 RID: 4675 RVA: 0x00063D20 File Offset: 0x00061F20
		public unsafe float4 zxzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_zxzx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06001244 RID: 4676 RVA: 0x00063D50 File Offset: 0x00061F50
		public unsafe float4 zxzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_zxzy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06001245 RID: 4677 RVA: 0x00063D80 File Offset: 0x00061F80
		public unsafe float4 zxzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_zxzz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06001246 RID: 4678 RVA: 0x00063DB0 File Offset: 0x00061FB0
		public unsafe float4 zyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_zyxx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06001247 RID: 4679 RVA: 0x00063DE0 File Offset: 0x00061FE0
		public unsafe float4 zyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_zyxy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06001248 RID: 4680 RVA: 0x00063E10 File Offset: 0x00062010
		public unsafe float4 zyxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_zyxz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06001249 RID: 4681 RVA: 0x00063E40 File Offset: 0x00062040
		public unsafe float4 zyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_zyyx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x0600124A RID: 4682 RVA: 0x00063E70 File Offset: 0x00062070
		public unsafe float4 zyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_zyyy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x0600124B RID: 4683 RVA: 0x00063EA0 File Offset: 0x000620A0
		public unsafe float4 zyyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_zyyz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x0600124C RID: 4684 RVA: 0x00063ED0 File Offset: 0x000620D0
		public unsafe float4 zyzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_zyzx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x0600124D RID: 4685 RVA: 0x00063F00 File Offset: 0x00062100
		public unsafe float4 zyzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_zyzy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x0600124E RID: 4686 RVA: 0x00063F30 File Offset: 0x00062130
		public unsafe float4 zyzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_zyzz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x0600124F RID: 4687 RVA: 0x00063F60 File Offset: 0x00062160
		public unsafe float4 zzxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_zzxx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06001250 RID: 4688 RVA: 0x00063F90 File Offset: 0x00062190
		public unsafe float4 zzxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_zzxy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06001251 RID: 4689 RVA: 0x00063FC0 File Offset: 0x000621C0
		public unsafe float4 zzxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_zzxz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06001252 RID: 4690 RVA: 0x00063FF0 File Offset: 0x000621F0
		public unsafe float4 zzyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_zzyx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06001253 RID: 4691 RVA: 0x00064020 File Offset: 0x00062220
		public unsafe float4 zzyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_zzyy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06001254 RID: 4692 RVA: 0x00064050 File Offset: 0x00062250
		public unsafe float4 zzyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_zzyz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06001255 RID: 4693 RVA: 0x00064080 File Offset: 0x00062280
		public unsafe float4 zzzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_zzzx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06001256 RID: 4694 RVA: 0x000640B0 File Offset: 0x000622B0
		public unsafe float4 zzzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_zzzy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06001257 RID: 4695 RVA: 0x000640E0 File Offset: 0x000622E0
		public unsafe float4 zzzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_zzzz_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06001258 RID: 4696 RVA: 0x00064110 File Offset: 0x00062310
		public unsafe float3 xxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_xxx_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06001259 RID: 4697 RVA: 0x00064140 File Offset: 0x00062340
		public unsafe float3 xxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_xxy_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x0600125A RID: 4698 RVA: 0x00064170 File Offset: 0x00062370
		public unsafe float3 xxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_xxz_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x0600125B RID: 4699 RVA: 0x000641A0 File Offset: 0x000623A0
		public unsafe float3 xyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_xyx_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x0600125C RID: 4700 RVA: 0x000641D0 File Offset: 0x000623D0
		public unsafe float3 xyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_xyy_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x0600125D RID: 4701 RVA: 0x00064200 File Offset: 0x00062400
		// (set) Token: 0x0600125E RID: 4702 RVA: 0x00064230 File Offset: 0x00062430
		public unsafe float3 xyz
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 637161, RefRangeEnd = 637182, XrefRangeStart = 637161, XrefRangeEnd = 637182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_xyz_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_set_xyz_Public_set_Void_float3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x0600125F RID: 4703 RVA: 0x00064264 File Offset: 0x00062464
		public unsafe float3 xzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_xzx_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06001260 RID: 4704 RVA: 0x00064294 File Offset: 0x00062494
		// (set) Token: 0x06001261 RID: 4705 RVA: 0x000642C4 File Offset: 0x000624C4
		public unsafe float3 xzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_xzy_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_set_xzy_Public_set_Void_float3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06001262 RID: 4706 RVA: 0x000642F8 File Offset: 0x000624F8
		public unsafe float3 xzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_xzz_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06001263 RID: 4707 RVA: 0x00064328 File Offset: 0x00062528
		public unsafe float3 yxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_yxx_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06001264 RID: 4708 RVA: 0x00064358 File Offset: 0x00062558
		public unsafe float3 yxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_yxy_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06001265 RID: 4709 RVA: 0x00064388 File Offset: 0x00062588
		// (set) Token: 0x06001266 RID: 4710 RVA: 0x000643B8 File Offset: 0x000625B8
		public unsafe float3 yxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_yxz_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_set_yxz_Public_set_Void_float3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06001267 RID: 4711 RVA: 0x000643EC File Offset: 0x000625EC
		public unsafe float3 yyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_yyx_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06001268 RID: 4712 RVA: 0x0006441C File Offset: 0x0006261C
		public unsafe float3 yyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_yyy_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06001269 RID: 4713 RVA: 0x0006444C File Offset: 0x0006264C
		public unsafe float3 yyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_yyz_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x0600126A RID: 4714 RVA: 0x0006447C File Offset: 0x0006267C
		// (set) Token: 0x0600126B RID: 4715 RVA: 0x000644AC File Offset: 0x000626AC
		public unsafe float3 yzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_yzx_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_set_yzx_Public_set_Void_float3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x0600126C RID: 4716 RVA: 0x000644E0 File Offset: 0x000626E0
		public unsafe float3 yzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_yzy_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x0600126D RID: 4717 RVA: 0x00064510 File Offset: 0x00062710
		public unsafe float3 yzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_yzz_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x0600126E RID: 4718 RVA: 0x00064540 File Offset: 0x00062740
		public unsafe float3 zxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_zxx_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x0600126F RID: 4719 RVA: 0x00064570 File Offset: 0x00062770
		// (set) Token: 0x06001270 RID: 4720 RVA: 0x000645A0 File Offset: 0x000627A0
		public unsafe float3 zxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_zxy_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_set_zxy_Public_set_Void_float3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06001271 RID: 4721 RVA: 0x000645D4 File Offset: 0x000627D4
		public unsafe float3 zxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_zxz_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06001272 RID: 4722 RVA: 0x00064604 File Offset: 0x00062804
		// (set) Token: 0x06001273 RID: 4723 RVA: 0x00064634 File Offset: 0x00062834
		public unsafe float3 zyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_zyx_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_set_zyx_Public_set_Void_float3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06001274 RID: 4724 RVA: 0x00064668 File Offset: 0x00062868
		public unsafe float3 zyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_zyy_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06001275 RID: 4725 RVA: 0x00064698 File Offset: 0x00062898
		public unsafe float3 zyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_zyz_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06001276 RID: 4726 RVA: 0x000646C8 File Offset: 0x000628C8
		public unsafe float3 zzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_zzx_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06001277 RID: 4727 RVA: 0x000646F8 File Offset: 0x000628F8
		public unsafe float3 zzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_zzy_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06001278 RID: 4728 RVA: 0x00064728 File Offset: 0x00062928
		public unsafe float3 zzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_zzz_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06001279 RID: 4729 RVA: 0x00064758 File Offset: 0x00062958
		public unsafe float2 xx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_xx_Public_get_float2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x0600127A RID: 4730 RVA: 0x00064788 File Offset: 0x00062988
		// (set) Token: 0x0600127B RID: 4731 RVA: 0x000647B8 File Offset: 0x000629B8
		public unsafe float2 xy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_xy_Public_get_float2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_set_xy_Public_set_Void_float2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x0600127C RID: 4732 RVA: 0x000647EC File Offset: 0x000629EC
		// (set) Token: 0x0600127D RID: 4733 RVA: 0x0006481C File Offset: 0x00062A1C
		public unsafe float2 xz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_xz_Public_get_float2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_set_xz_Public_set_Void_float2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x0600127E RID: 4734 RVA: 0x00064850 File Offset: 0x00062A50
		// (set) Token: 0x0600127F RID: 4735 RVA: 0x00064880 File Offset: 0x00062A80
		public unsafe float2 yx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_yx_Public_get_float2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_set_yx_Public_set_Void_float2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06001280 RID: 4736 RVA: 0x000648B4 File Offset: 0x00062AB4
		public unsafe float2 yy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_yy_Public_get_float2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06001281 RID: 4737 RVA: 0x000648E4 File Offset: 0x00062AE4
		// (set) Token: 0x06001282 RID: 4738 RVA: 0x00064914 File Offset: 0x00062B14
		public unsafe float2 yz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_yz_Public_get_float2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_set_yz_Public_set_Void_float2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06001283 RID: 4739 RVA: 0x00064948 File Offset: 0x00062B48
		// (set) Token: 0x06001284 RID: 4740 RVA: 0x00064978 File Offset: 0x00062B78
		public unsafe float2 zx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_zx_Public_get_float2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_set_zx_Public_set_Void_float2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06001285 RID: 4741 RVA: 0x000649AC File Offset: 0x00062BAC
		// (set) Token: 0x06001286 RID: 4742 RVA: 0x000649DC File Offset: 0x00062BDC
		public unsafe float2 zy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_zy_Public_get_float2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_set_zy_Public_set_Void_float2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06001287 RID: 4743 RVA: 0x00064A10 File Offset: 0x00062C10
		public unsafe float2 zz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_zz_Public_get_float2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700049B RID: 1179
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0, ref this, (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x00064AC0 File Offset: 0x00062CC0
		[CallerCount(0)]
		public unsafe bool Equals(float3 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x00064B00 File Offset: 0x00062D00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637194, XrefRangeEnd = 637197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(global::Il2CppSystem.Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x00064B44 File Offset: 0x00062D44
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x00064B74 File Offset: 0x00062D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637197, XrefRangeEnd = 637207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x00064BA0 File Offset: 0x00062DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637207, XrefRangeEnd = 637213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x00064BF0 File Offset: 0x00062DF0
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 637161, RefRangeEnd = 637182, XrefRangeStart = 637161, XrefRangeEnd = 637182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Vector3(float3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x00064C30 File Offset: 0x00062E30
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 637161, RefRangeEnd = 637182, XrefRangeStart = 637161, XrefRangeEnd = 637182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator float3(Vector3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.NativeMethodInfoPtr_op_Implicit_Public_Static_float3_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x000024E8 File Offset: 0x000006E8
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<float3>.NativeClassPtr, ref this));
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06001292 RID: 4754 RVA: 0x00064C70 File Offset: 0x00062E70
		// (set) Token: 0x06001293 RID: 4755 RVA: 0x000024FA File Offset: 0x000006FA
		public unsafe static float3 zero
		{
			get
			{
				float3 @float;
				IL2CPP.il2cpp_field_static_get_value(float3.NativeFieldInfoPtr_zero, (void*)(&@float));
				return @float;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(float3.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x04001205 RID: 4613
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x04001206 RID: 4614
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04001207 RID: 4615
		private static readonly IntPtr NativeFieldInfoPtr_z;

		// Token: 0x04001208 RID: 4616
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x04001209 RID: 4617
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0;

		// Token: 0x0400120A RID: 4618
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_float2_0;

		// Token: 0x0400120B RID: 4619
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float2_Single_0;

		// Token: 0x0400120C RID: 4620
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float3_0;

		// Token: 0x0400120D RID: 4621
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x0400120E RID: 4622
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x0400120F RID: 4623
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool3_0;

		// Token: 0x04001210 RID: 4624
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001211 RID: 4625
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int3_0;

		// Token: 0x04001212 RID: 4626
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04001213 RID: 4627
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint3_0;

		// Token: 0x04001214 RID: 4628
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_half_0;

		// Token: 0x04001215 RID: 4629
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_half3_0;

		// Token: 0x04001216 RID: 4630
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x04001217 RID: 4631
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double3_0;

		// Token: 0x04001218 RID: 4632
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float3_Single_0;

		// Token: 0x04001219 RID: 4633
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_float3_Boolean_0;

		// Token: 0x0400121A RID: 4634
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_float3_bool3_0;

		// Token: 0x0400121B RID: 4635
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float3_Int32_0;

		// Token: 0x0400121C RID: 4636
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float3_int3_0;

		// Token: 0x0400121D RID: 4637
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float3_UInt32_0;

		// Token: 0x0400121E RID: 4638
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float3_uint3_0;

		// Token: 0x0400121F RID: 4639
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float3_half_0;

		// Token: 0x04001220 RID: 4640
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float3_half3_0;

		// Token: 0x04001221 RID: 4641
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_float3_Double_0;

		// Token: 0x04001222 RID: 4642
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_float3_double3_0;

		// Token: 0x04001223 RID: 4643
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_float3_float3_float3_0;

		// Token: 0x04001224 RID: 4644
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_float3_float3_Single_0;

		// Token: 0x04001225 RID: 4645
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_float3_Single_float3_0;

		// Token: 0x04001226 RID: 4646
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_float3_float3_float3_0;

		// Token: 0x04001227 RID: 4647
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_float3_float3_Single_0;

		// Token: 0x04001228 RID: 4648
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_float3_Single_float3_0;

		// Token: 0x04001229 RID: 4649
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_float3_float3_float3_0;

		// Token: 0x0400122A RID: 4650
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_float3_float3_Single_0;

		// Token: 0x0400122B RID: 4651
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_float3_Single_float3_0;

		// Token: 0x0400122C RID: 4652
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_float3_float3_float3_0;

		// Token: 0x0400122D RID: 4653
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_float3_float3_Single_0;

		// Token: 0x0400122E RID: 4654
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_float3_Single_float3_0;

		// Token: 0x0400122F RID: 4655
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_float3_float3_float3_0;

		// Token: 0x04001230 RID: 4656
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_float3_float3_Single_0;

		// Token: 0x04001231 RID: 4657
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_float3_Single_float3_0;

		// Token: 0x04001232 RID: 4658
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_float3_float3_0;

		// Token: 0x04001233 RID: 4659
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_float3_float3_0;

		// Token: 0x04001234 RID: 4660
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool3_float3_float3_0;

		// Token: 0x04001235 RID: 4661
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool3_float3_Single_0;

		// Token: 0x04001236 RID: 4662
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool3_Single_float3_0;

		// Token: 0x04001237 RID: 4663
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3_float3_float3_0;

		// Token: 0x04001238 RID: 4664
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3_float3_Single_0;

		// Token: 0x04001239 RID: 4665
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3_Single_float3_0;

		// Token: 0x0400123A RID: 4666
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3_float3_float3_0;

		// Token: 0x0400123B RID: 4667
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3_float3_Single_0;

		// Token: 0x0400123C RID: 4668
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3_Single_float3_0;

		// Token: 0x0400123D RID: 4669
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3_float3_float3_0;

		// Token: 0x0400123E RID: 4670
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3_float3_Single_0;

		// Token: 0x0400123F RID: 4671
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3_Single_float3_0;

		// Token: 0x04001240 RID: 4672
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_float3_float3_0;

		// Token: 0x04001241 RID: 4673
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryPlus_Public_Static_float3_float3_0;

		// Token: 0x04001242 RID: 4674
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3_float3_float3_0;

		// Token: 0x04001243 RID: 4675
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3_float3_Single_0;

		// Token: 0x04001244 RID: 4676
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3_Single_float3_0;

		// Token: 0x04001245 RID: 4677
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_float3_float3_0;

		// Token: 0x04001246 RID: 4678
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_float3_Single_0;

		// Token: 0x04001247 RID: 4679
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_Single_float3_0;

		// Token: 0x04001248 RID: 4680
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxx_Public_get_float4_0;

		// Token: 0x04001249 RID: 4681
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxy_Public_get_float4_0;

		// Token: 0x0400124A RID: 4682
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxz_Public_get_float4_0;

		// Token: 0x0400124B RID: 4683
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyx_Public_get_float4_0;

		// Token: 0x0400124C RID: 4684
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyy_Public_get_float4_0;

		// Token: 0x0400124D RID: 4685
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyz_Public_get_float4_0;

		// Token: 0x0400124E RID: 4686
		private static readonly IntPtr NativeMethodInfoPtr_get_xxzx_Public_get_float4_0;

		// Token: 0x0400124F RID: 4687
		private static readonly IntPtr NativeMethodInfoPtr_get_xxzy_Public_get_float4_0;

		// Token: 0x04001250 RID: 4688
		private static readonly IntPtr NativeMethodInfoPtr_get_xxzz_Public_get_float4_0;

		// Token: 0x04001251 RID: 4689
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxx_Public_get_float4_0;

		// Token: 0x04001252 RID: 4690
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxy_Public_get_float4_0;

		// Token: 0x04001253 RID: 4691
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxz_Public_get_float4_0;

		// Token: 0x04001254 RID: 4692
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyx_Public_get_float4_0;

		// Token: 0x04001255 RID: 4693
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyy_Public_get_float4_0;

		// Token: 0x04001256 RID: 4694
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyz_Public_get_float4_0;

		// Token: 0x04001257 RID: 4695
		private static readonly IntPtr NativeMethodInfoPtr_get_xyzx_Public_get_float4_0;

		// Token: 0x04001258 RID: 4696
		private static readonly IntPtr NativeMethodInfoPtr_get_xyzy_Public_get_float4_0;

		// Token: 0x04001259 RID: 4697
		private static readonly IntPtr NativeMethodInfoPtr_get_xyzz_Public_get_float4_0;

		// Token: 0x0400125A RID: 4698
		private static readonly IntPtr NativeMethodInfoPtr_get_xzxx_Public_get_float4_0;

		// Token: 0x0400125B RID: 4699
		private static readonly IntPtr NativeMethodInfoPtr_get_xzxy_Public_get_float4_0;

		// Token: 0x0400125C RID: 4700
		private static readonly IntPtr NativeMethodInfoPtr_get_xzxz_Public_get_float4_0;

		// Token: 0x0400125D RID: 4701
		private static readonly IntPtr NativeMethodInfoPtr_get_xzyx_Public_get_float4_0;

		// Token: 0x0400125E RID: 4702
		private static readonly IntPtr NativeMethodInfoPtr_get_xzyy_Public_get_float4_0;

		// Token: 0x0400125F RID: 4703
		private static readonly IntPtr NativeMethodInfoPtr_get_xzyz_Public_get_float4_0;

		// Token: 0x04001260 RID: 4704
		private static readonly IntPtr NativeMethodInfoPtr_get_xzzx_Public_get_float4_0;

		// Token: 0x04001261 RID: 4705
		private static readonly IntPtr NativeMethodInfoPtr_get_xzzy_Public_get_float4_0;

		// Token: 0x04001262 RID: 4706
		private static readonly IntPtr NativeMethodInfoPtr_get_xzzz_Public_get_float4_0;

		// Token: 0x04001263 RID: 4707
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxx_Public_get_float4_0;

		// Token: 0x04001264 RID: 4708
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxy_Public_get_float4_0;

		// Token: 0x04001265 RID: 4709
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxz_Public_get_float4_0;

		// Token: 0x04001266 RID: 4710
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyx_Public_get_float4_0;

		// Token: 0x04001267 RID: 4711
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyy_Public_get_float4_0;

		// Token: 0x04001268 RID: 4712
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyz_Public_get_float4_0;

		// Token: 0x04001269 RID: 4713
		private static readonly IntPtr NativeMethodInfoPtr_get_yxzx_Public_get_float4_0;

		// Token: 0x0400126A RID: 4714
		private static readonly IntPtr NativeMethodInfoPtr_get_yxzy_Public_get_float4_0;

		// Token: 0x0400126B RID: 4715
		private static readonly IntPtr NativeMethodInfoPtr_get_yxzz_Public_get_float4_0;

		// Token: 0x0400126C RID: 4716
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxx_Public_get_float4_0;

		// Token: 0x0400126D RID: 4717
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxy_Public_get_float4_0;

		// Token: 0x0400126E RID: 4718
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxz_Public_get_float4_0;

		// Token: 0x0400126F RID: 4719
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyx_Public_get_float4_0;

		// Token: 0x04001270 RID: 4720
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyy_Public_get_float4_0;

		// Token: 0x04001271 RID: 4721
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyz_Public_get_float4_0;

		// Token: 0x04001272 RID: 4722
		private static readonly IntPtr NativeMethodInfoPtr_get_yyzx_Public_get_float4_0;

		// Token: 0x04001273 RID: 4723
		private static readonly IntPtr NativeMethodInfoPtr_get_yyzy_Public_get_float4_0;

		// Token: 0x04001274 RID: 4724
		private static readonly IntPtr NativeMethodInfoPtr_get_yyzz_Public_get_float4_0;

		// Token: 0x04001275 RID: 4725
		private static readonly IntPtr NativeMethodInfoPtr_get_yzxx_Public_get_float4_0;

		// Token: 0x04001276 RID: 4726
		private static readonly IntPtr NativeMethodInfoPtr_get_yzxy_Public_get_float4_0;

		// Token: 0x04001277 RID: 4727
		private static readonly IntPtr NativeMethodInfoPtr_get_yzxz_Public_get_float4_0;

		// Token: 0x04001278 RID: 4728
		private static readonly IntPtr NativeMethodInfoPtr_get_yzyx_Public_get_float4_0;

		// Token: 0x04001279 RID: 4729
		private static readonly IntPtr NativeMethodInfoPtr_get_yzyy_Public_get_float4_0;

		// Token: 0x0400127A RID: 4730
		private static readonly IntPtr NativeMethodInfoPtr_get_yzyz_Public_get_float4_0;

		// Token: 0x0400127B RID: 4731
		private static readonly IntPtr NativeMethodInfoPtr_get_yzzx_Public_get_float4_0;

		// Token: 0x0400127C RID: 4732
		private static readonly IntPtr NativeMethodInfoPtr_get_yzzy_Public_get_float4_0;

		// Token: 0x0400127D RID: 4733
		private static readonly IntPtr NativeMethodInfoPtr_get_yzzz_Public_get_float4_0;

		// Token: 0x0400127E RID: 4734
		private static readonly IntPtr NativeMethodInfoPtr_get_zxxx_Public_get_float4_0;

		// Token: 0x0400127F RID: 4735
		private static readonly IntPtr NativeMethodInfoPtr_get_zxxy_Public_get_float4_0;

		// Token: 0x04001280 RID: 4736
		private static readonly IntPtr NativeMethodInfoPtr_get_zxxz_Public_get_float4_0;

		// Token: 0x04001281 RID: 4737
		private static readonly IntPtr NativeMethodInfoPtr_get_zxyx_Public_get_float4_0;

		// Token: 0x04001282 RID: 4738
		private static readonly IntPtr NativeMethodInfoPtr_get_zxyy_Public_get_float4_0;

		// Token: 0x04001283 RID: 4739
		private static readonly IntPtr NativeMethodInfoPtr_get_zxyz_Public_get_float4_0;

		// Token: 0x04001284 RID: 4740
		private static readonly IntPtr NativeMethodInfoPtr_get_zxzx_Public_get_float4_0;

		// Token: 0x04001285 RID: 4741
		private static readonly IntPtr NativeMethodInfoPtr_get_zxzy_Public_get_float4_0;

		// Token: 0x04001286 RID: 4742
		private static readonly IntPtr NativeMethodInfoPtr_get_zxzz_Public_get_float4_0;

		// Token: 0x04001287 RID: 4743
		private static readonly IntPtr NativeMethodInfoPtr_get_zyxx_Public_get_float4_0;

		// Token: 0x04001288 RID: 4744
		private static readonly IntPtr NativeMethodInfoPtr_get_zyxy_Public_get_float4_0;

		// Token: 0x04001289 RID: 4745
		private static readonly IntPtr NativeMethodInfoPtr_get_zyxz_Public_get_float4_0;

		// Token: 0x0400128A RID: 4746
		private static readonly IntPtr NativeMethodInfoPtr_get_zyyx_Public_get_float4_0;

		// Token: 0x0400128B RID: 4747
		private static readonly IntPtr NativeMethodInfoPtr_get_zyyy_Public_get_float4_0;

		// Token: 0x0400128C RID: 4748
		private static readonly IntPtr NativeMethodInfoPtr_get_zyyz_Public_get_float4_0;

		// Token: 0x0400128D RID: 4749
		private static readonly IntPtr NativeMethodInfoPtr_get_zyzx_Public_get_float4_0;

		// Token: 0x0400128E RID: 4750
		private static readonly IntPtr NativeMethodInfoPtr_get_zyzy_Public_get_float4_0;

		// Token: 0x0400128F RID: 4751
		private static readonly IntPtr NativeMethodInfoPtr_get_zyzz_Public_get_float4_0;

		// Token: 0x04001290 RID: 4752
		private static readonly IntPtr NativeMethodInfoPtr_get_zzxx_Public_get_float4_0;

		// Token: 0x04001291 RID: 4753
		private static readonly IntPtr NativeMethodInfoPtr_get_zzxy_Public_get_float4_0;

		// Token: 0x04001292 RID: 4754
		private static readonly IntPtr NativeMethodInfoPtr_get_zzxz_Public_get_float4_0;

		// Token: 0x04001293 RID: 4755
		private static readonly IntPtr NativeMethodInfoPtr_get_zzyx_Public_get_float4_0;

		// Token: 0x04001294 RID: 4756
		private static readonly IntPtr NativeMethodInfoPtr_get_zzyy_Public_get_float4_0;

		// Token: 0x04001295 RID: 4757
		private static readonly IntPtr NativeMethodInfoPtr_get_zzyz_Public_get_float4_0;

		// Token: 0x04001296 RID: 4758
		private static readonly IntPtr NativeMethodInfoPtr_get_zzzx_Public_get_float4_0;

		// Token: 0x04001297 RID: 4759
		private static readonly IntPtr NativeMethodInfoPtr_get_zzzy_Public_get_float4_0;

		// Token: 0x04001298 RID: 4760
		private static readonly IntPtr NativeMethodInfoPtr_get_zzzz_Public_get_float4_0;

		// Token: 0x04001299 RID: 4761
		private static readonly IntPtr NativeMethodInfoPtr_get_xxx_Public_get_float3_0;

		// Token: 0x0400129A RID: 4762
		private static readonly IntPtr NativeMethodInfoPtr_get_xxy_Public_get_float3_0;

		// Token: 0x0400129B RID: 4763
		private static readonly IntPtr NativeMethodInfoPtr_get_xxz_Public_get_float3_0;

		// Token: 0x0400129C RID: 4764
		private static readonly IntPtr NativeMethodInfoPtr_get_xyx_Public_get_float3_0;

		// Token: 0x0400129D RID: 4765
		private static readonly IntPtr NativeMethodInfoPtr_get_xyy_Public_get_float3_0;

		// Token: 0x0400129E RID: 4766
		private static readonly IntPtr NativeMethodInfoPtr_get_xyz_Public_get_float3_0;

		// Token: 0x0400129F RID: 4767
		private static readonly IntPtr NativeMethodInfoPtr_set_xyz_Public_set_Void_float3_0;

		// Token: 0x040012A0 RID: 4768
		private static readonly IntPtr NativeMethodInfoPtr_get_xzx_Public_get_float3_0;

		// Token: 0x040012A1 RID: 4769
		private static readonly IntPtr NativeMethodInfoPtr_get_xzy_Public_get_float3_0;

		// Token: 0x040012A2 RID: 4770
		private static readonly IntPtr NativeMethodInfoPtr_set_xzy_Public_set_Void_float3_0;

		// Token: 0x040012A3 RID: 4771
		private static readonly IntPtr NativeMethodInfoPtr_get_xzz_Public_get_float3_0;

		// Token: 0x040012A4 RID: 4772
		private static readonly IntPtr NativeMethodInfoPtr_get_yxx_Public_get_float3_0;

		// Token: 0x040012A5 RID: 4773
		private static readonly IntPtr NativeMethodInfoPtr_get_yxy_Public_get_float3_0;

		// Token: 0x040012A6 RID: 4774
		private static readonly IntPtr NativeMethodInfoPtr_get_yxz_Public_get_float3_0;

		// Token: 0x040012A7 RID: 4775
		private static readonly IntPtr NativeMethodInfoPtr_set_yxz_Public_set_Void_float3_0;

		// Token: 0x040012A8 RID: 4776
		private static readonly IntPtr NativeMethodInfoPtr_get_yyx_Public_get_float3_0;

		// Token: 0x040012A9 RID: 4777
		private static readonly IntPtr NativeMethodInfoPtr_get_yyy_Public_get_float3_0;

		// Token: 0x040012AA RID: 4778
		private static readonly IntPtr NativeMethodInfoPtr_get_yyz_Public_get_float3_0;

		// Token: 0x040012AB RID: 4779
		private static readonly IntPtr NativeMethodInfoPtr_get_yzx_Public_get_float3_0;

		// Token: 0x040012AC RID: 4780
		private static readonly IntPtr NativeMethodInfoPtr_set_yzx_Public_set_Void_float3_0;

		// Token: 0x040012AD RID: 4781
		private static readonly IntPtr NativeMethodInfoPtr_get_yzy_Public_get_float3_0;

		// Token: 0x040012AE RID: 4782
		private static readonly IntPtr NativeMethodInfoPtr_get_yzz_Public_get_float3_0;

		// Token: 0x040012AF RID: 4783
		private static readonly IntPtr NativeMethodInfoPtr_get_zxx_Public_get_float3_0;

		// Token: 0x040012B0 RID: 4784
		private static readonly IntPtr NativeMethodInfoPtr_get_zxy_Public_get_float3_0;

		// Token: 0x040012B1 RID: 4785
		private static readonly IntPtr NativeMethodInfoPtr_set_zxy_Public_set_Void_float3_0;

		// Token: 0x040012B2 RID: 4786
		private static readonly IntPtr NativeMethodInfoPtr_get_zxz_Public_get_float3_0;

		// Token: 0x040012B3 RID: 4787
		private static readonly IntPtr NativeMethodInfoPtr_get_zyx_Public_get_float3_0;

		// Token: 0x040012B4 RID: 4788
		private static readonly IntPtr NativeMethodInfoPtr_set_zyx_Public_set_Void_float3_0;

		// Token: 0x040012B5 RID: 4789
		private static readonly IntPtr NativeMethodInfoPtr_get_zyy_Public_get_float3_0;

		// Token: 0x040012B6 RID: 4790
		private static readonly IntPtr NativeMethodInfoPtr_get_zyz_Public_get_float3_0;

		// Token: 0x040012B7 RID: 4791
		private static readonly IntPtr NativeMethodInfoPtr_get_zzx_Public_get_float3_0;

		// Token: 0x040012B8 RID: 4792
		private static readonly IntPtr NativeMethodInfoPtr_get_zzy_Public_get_float3_0;

		// Token: 0x040012B9 RID: 4793
		private static readonly IntPtr NativeMethodInfoPtr_get_zzz_Public_get_float3_0;

		// Token: 0x040012BA RID: 4794
		private static readonly IntPtr NativeMethodInfoPtr_get_xx_Public_get_float2_0;

		// Token: 0x040012BB RID: 4795
		private static readonly IntPtr NativeMethodInfoPtr_get_xy_Public_get_float2_0;

		// Token: 0x040012BC RID: 4796
		private static readonly IntPtr NativeMethodInfoPtr_set_xy_Public_set_Void_float2_0;

		// Token: 0x040012BD RID: 4797
		private static readonly IntPtr NativeMethodInfoPtr_get_xz_Public_get_float2_0;

		// Token: 0x040012BE RID: 4798
		private static readonly IntPtr NativeMethodInfoPtr_set_xz_Public_set_Void_float2_0;

		// Token: 0x040012BF RID: 4799
		private static readonly IntPtr NativeMethodInfoPtr_get_yx_Public_get_float2_0;

		// Token: 0x040012C0 RID: 4800
		private static readonly IntPtr NativeMethodInfoPtr_set_yx_Public_set_Void_float2_0;

		// Token: 0x040012C1 RID: 4801
		private static readonly IntPtr NativeMethodInfoPtr_get_yy_Public_get_float2_0;

		// Token: 0x040012C2 RID: 4802
		private static readonly IntPtr NativeMethodInfoPtr_get_yz_Public_get_float2_0;

		// Token: 0x040012C3 RID: 4803
		private static readonly IntPtr NativeMethodInfoPtr_set_yz_Public_set_Void_float2_0;

		// Token: 0x040012C4 RID: 4804
		private static readonly IntPtr NativeMethodInfoPtr_get_zx_Public_get_float2_0;

		// Token: 0x040012C5 RID: 4805
		private static readonly IntPtr NativeMethodInfoPtr_set_zx_Public_set_Void_float2_0;

		// Token: 0x040012C6 RID: 4806
		private static readonly IntPtr NativeMethodInfoPtr_get_zy_Public_get_float2_0;

		// Token: 0x040012C7 RID: 4807
		private static readonly IntPtr NativeMethodInfoPtr_set_zy_Public_set_Void_float2_0;

		// Token: 0x040012C8 RID: 4808
		private static readonly IntPtr NativeMethodInfoPtr_get_zz_Public_get_float2_0;

		// Token: 0x040012C9 RID: 4809
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0;

		// Token: 0x040012CA RID: 4810
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0;

		// Token: 0x040012CB RID: 4811
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_float3_0;

		// Token: 0x040012CC RID: 4812
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040012CD RID: 4813
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040012CE RID: 4814
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040012CF RID: 4815
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x040012D0 RID: 4816
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_float3_0;

		// Token: 0x040012D1 RID: 4817
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float3_Vector3_0;

		// Token: 0x040012D2 RID: 4818
		[FieldOffset(0)]
		public float x;

		// Token: 0x040012D3 RID: 4819
		[FieldOffset(4)]
		public float y;

		// Token: 0x040012D4 RID: 4820
		[FieldOffset(8)]
		public float z;

		// Token: 0x0200005B RID: 91
		public sealed class DebuggerProxy : global::Il2CppSystem.Object
		{
			// Token: 0x060025F6 RID: 9718 RVA: 0x000C35C4 File Offset: 0x000C17C4
			// Note: this type is marked as 'beforefieldinit'.
			static DebuggerProxy()
			{
				Il2CppClassPointerStore<float3.DebuggerProxy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<float3>.NativeClassPtr, "DebuggerProxy");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<float3.DebuggerProxy>.NativeClassPtr);
				float3.DebuggerProxy.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float3.DebuggerProxy>.NativeClassPtr, "x");
				float3.DebuggerProxy.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float3.DebuggerProxy>.NativeClassPtr, "y");
				float3.DebuggerProxy.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float3.DebuggerProxy>.NativeClassPtr, "z");
				float3.DebuggerProxy.NativeMethodInfoPtr__ctor_Public_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3.DebuggerProxy>.NativeClassPtr, 100667913);
			}

			// Token: 0x060025F7 RID: 9719 RVA: 0x000C3640 File Offset: 0x000C1840
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637148, XrefRangeEnd = 637149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DebuggerProxy(float3 v)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<float3.DebuggerProxy>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3.DebuggerProxy.NativeMethodInfoPtr__ctor_Public_Void_float3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060025F8 RID: 9720 RVA: 0x00002E32 File Offset: 0x00001032
			public DebuggerProxy(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C05 RID: 3077
			// (get) Token: 0x060025F9 RID: 9721 RVA: 0x000C3688 File Offset: 0x000C1888
			// (set) Token: 0x060025FA RID: 9722 RVA: 0x00002E3B File Offset: 0x0000103B
			public unsafe float x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(float3.DebuggerProxy.NativeFieldInfoPtr_x);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(float3.DebuggerProxy.NativeFieldInfoPtr_x)) = value;
				}
			}

			// Token: 0x17000C06 RID: 3078
			// (get) Token: 0x060025FB RID: 9723 RVA: 0x000C36B0 File Offset: 0x000C18B0
			// (set) Token: 0x060025FC RID: 9724 RVA: 0x00002E56 File Offset: 0x00001056
			public unsafe float y
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(float3.DebuggerProxy.NativeFieldInfoPtr_y);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(float3.DebuggerProxy.NativeFieldInfoPtr_y)) = value;
				}
			}

			// Token: 0x17000C07 RID: 3079
			// (get) Token: 0x060025FD RID: 9725 RVA: 0x000C36D8 File Offset: 0x000C18D8
			// (set) Token: 0x060025FE RID: 9726 RVA: 0x00002E71 File Offset: 0x00001071
			public unsafe float z
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(float3.DebuggerProxy.NativeFieldInfoPtr_z);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(float3.DebuggerProxy.NativeFieldInfoPtr_z)) = value;
				}
			}

			// Token: 0x04002677 RID: 9847
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04002678 RID: 9848
			private static readonly IntPtr NativeFieldInfoPtr_y;

			// Token: 0x04002679 RID: 9849
			private static readonly IntPtr NativeFieldInfoPtr_z;

			// Token: 0x0400267A RID: 9850
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float3_0;
		}
	}
}
