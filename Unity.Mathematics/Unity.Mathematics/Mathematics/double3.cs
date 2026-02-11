using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x02000015 RID: 21
	[Serializable]
	[StructLayout(2)]
	public struct double3
	{
		// Token: 0x06000C55 RID: 3157 RVA: 0x00046280 File Offset: 0x00044480
		// Note: this type is marked as 'beforefieldinit'.
		static double3()
		{
			Il2CppClassPointerStore<double3>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "double3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<double3>.NativeClassPtr);
			double3.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double3>.NativeClassPtr, "x");
			double3.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double3>.NativeClassPtr, "y");
			double3.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double3>.NativeClassPtr, "z");
			double3.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double3>.NativeClassPtr, "zero");
			double3.NativeMethodInfoPtr__ctor_Public_Void_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666366);
			double3.NativeMethodInfoPtr__ctor_Public_Void_Double_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666367);
			double3.NativeMethodInfoPtr__ctor_Public_Void_double2_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666368);
			double3.NativeMethodInfoPtr__ctor_Public_Void_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666369);
			double3.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666370);
			double3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666371);
			double3.NativeMethodInfoPtr__ctor_Public_Void_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666372);
			double3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666373);
			double3.NativeMethodInfoPtr__ctor_Public_Void_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666374);
			double3.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666375);
			double3.NativeMethodInfoPtr__ctor_Public_Void_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666376);
			double3.NativeMethodInfoPtr__ctor_Public_Void_half_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666377);
			double3.NativeMethodInfoPtr__ctor_Public_Void_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666378);
			double3.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666379);
			double3.NativeMethodInfoPtr__ctor_Public_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666380);
			double3.NativeMethodInfoPtr_op_Implicit_Public_Static_double3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666381);
			double3.NativeMethodInfoPtr_op_Explicit_Public_Static_double3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666382);
			double3.NativeMethodInfoPtr_op_Explicit_Public_Static_double3_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666383);
			double3.NativeMethodInfoPtr_op_Implicit_Public_Static_double3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666384);
			double3.NativeMethodInfoPtr_op_Implicit_Public_Static_double3_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666385);
			double3.NativeMethodInfoPtr_op_Implicit_Public_Static_double3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666386);
			double3.NativeMethodInfoPtr_op_Implicit_Public_Static_double3_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666387);
			double3.NativeMethodInfoPtr_op_Implicit_Public_Static_double3_half_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666388);
			double3.NativeMethodInfoPtr_op_Implicit_Public_Static_double3_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666389);
			double3.NativeMethodInfoPtr_op_Implicit_Public_Static_double3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666390);
			double3.NativeMethodInfoPtr_op_Implicit_Public_Static_double3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666391);
			double3.NativeMethodInfoPtr_op_Multiply_Public_Static_double3_double3_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666392);
			double3.NativeMethodInfoPtr_op_Multiply_Public_Static_double3_double3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666393);
			double3.NativeMethodInfoPtr_op_Multiply_Public_Static_double3_Double_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666394);
			double3.NativeMethodInfoPtr_op_Addition_Public_Static_double3_double3_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666395);
			double3.NativeMethodInfoPtr_op_Addition_Public_Static_double3_double3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666396);
			double3.NativeMethodInfoPtr_op_Addition_Public_Static_double3_Double_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666397);
			double3.NativeMethodInfoPtr_op_Subtraction_Public_Static_double3_double3_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666398);
			double3.NativeMethodInfoPtr_op_Subtraction_Public_Static_double3_double3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666399);
			double3.NativeMethodInfoPtr_op_Subtraction_Public_Static_double3_Double_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666400);
			double3.NativeMethodInfoPtr_op_Division_Public_Static_double3_double3_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666401);
			double3.NativeMethodInfoPtr_op_Division_Public_Static_double3_double3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666402);
			double3.NativeMethodInfoPtr_op_Division_Public_Static_double3_Double_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666403);
			double3.NativeMethodInfoPtr_op_Modulus_Public_Static_double3_double3_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666404);
			double3.NativeMethodInfoPtr_op_Modulus_Public_Static_double3_double3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666405);
			double3.NativeMethodInfoPtr_op_Modulus_Public_Static_double3_Double_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666406);
			double3.NativeMethodInfoPtr_op_Increment_Public_Static_double3_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666407);
			double3.NativeMethodInfoPtr_op_Decrement_Public_Static_double3_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666408);
			double3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3_double3_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666409);
			double3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3_double3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666410);
			double3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3_Double_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666411);
			double3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3_double3_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666412);
			double3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3_double3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666413);
			double3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3_Double_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666414);
			double3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3_double3_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666415);
			double3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3_double3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666416);
			double3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3_Double_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666417);
			double3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3_double3_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666418);
			double3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3_double3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666419);
			double3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3_Double_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666420);
			double3.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_double3_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666421);
			double3.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_double3_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666422);
			double3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3_double3_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666423);
			double3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3_double3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666424);
			double3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3_Double_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666425);
			double3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_double3_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666426);
			double3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_double3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666427);
			double3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_Double_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666428);
			double3.NativeMethodInfoPtr_get_xxxx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666429);
			double3.NativeMethodInfoPtr_get_xxxy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666430);
			double3.NativeMethodInfoPtr_get_xxxz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666431);
			double3.NativeMethodInfoPtr_get_xxyx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666432);
			double3.NativeMethodInfoPtr_get_xxyy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666433);
			double3.NativeMethodInfoPtr_get_xxyz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666434);
			double3.NativeMethodInfoPtr_get_xxzx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666435);
			double3.NativeMethodInfoPtr_get_xxzy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666436);
			double3.NativeMethodInfoPtr_get_xxzz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666437);
			double3.NativeMethodInfoPtr_get_xyxx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666438);
			double3.NativeMethodInfoPtr_get_xyxy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666439);
			double3.NativeMethodInfoPtr_get_xyxz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666440);
			double3.NativeMethodInfoPtr_get_xyyx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666441);
			double3.NativeMethodInfoPtr_get_xyyy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666442);
			double3.NativeMethodInfoPtr_get_xyyz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666443);
			double3.NativeMethodInfoPtr_get_xyzx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666444);
			double3.NativeMethodInfoPtr_get_xyzy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666445);
			double3.NativeMethodInfoPtr_get_xyzz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666446);
			double3.NativeMethodInfoPtr_get_xzxx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666447);
			double3.NativeMethodInfoPtr_get_xzxy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666448);
			double3.NativeMethodInfoPtr_get_xzxz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666449);
			double3.NativeMethodInfoPtr_get_xzyx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666450);
			double3.NativeMethodInfoPtr_get_xzyy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666451);
			double3.NativeMethodInfoPtr_get_xzyz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666452);
			double3.NativeMethodInfoPtr_get_xzzx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666453);
			double3.NativeMethodInfoPtr_get_xzzy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666454);
			double3.NativeMethodInfoPtr_get_xzzz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666455);
			double3.NativeMethodInfoPtr_get_yxxx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666456);
			double3.NativeMethodInfoPtr_get_yxxy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666457);
			double3.NativeMethodInfoPtr_get_yxxz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666458);
			double3.NativeMethodInfoPtr_get_yxyx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666459);
			double3.NativeMethodInfoPtr_get_yxyy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666460);
			double3.NativeMethodInfoPtr_get_yxyz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666461);
			double3.NativeMethodInfoPtr_get_yxzx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666462);
			double3.NativeMethodInfoPtr_get_yxzy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666463);
			double3.NativeMethodInfoPtr_get_yxzz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666464);
			double3.NativeMethodInfoPtr_get_yyxx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666465);
			double3.NativeMethodInfoPtr_get_yyxy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666466);
			double3.NativeMethodInfoPtr_get_yyxz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666467);
			double3.NativeMethodInfoPtr_get_yyyx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666468);
			double3.NativeMethodInfoPtr_get_yyyy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666469);
			double3.NativeMethodInfoPtr_get_yyyz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666470);
			double3.NativeMethodInfoPtr_get_yyzx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666471);
			double3.NativeMethodInfoPtr_get_yyzy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666472);
			double3.NativeMethodInfoPtr_get_yyzz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666473);
			double3.NativeMethodInfoPtr_get_yzxx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666474);
			double3.NativeMethodInfoPtr_get_yzxy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666475);
			double3.NativeMethodInfoPtr_get_yzxz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666476);
			double3.NativeMethodInfoPtr_get_yzyx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666477);
			double3.NativeMethodInfoPtr_get_yzyy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666478);
			double3.NativeMethodInfoPtr_get_yzyz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666479);
			double3.NativeMethodInfoPtr_get_yzzx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666480);
			double3.NativeMethodInfoPtr_get_yzzy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666481);
			double3.NativeMethodInfoPtr_get_yzzz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666482);
			double3.NativeMethodInfoPtr_get_zxxx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666483);
			double3.NativeMethodInfoPtr_get_zxxy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666484);
			double3.NativeMethodInfoPtr_get_zxxz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666485);
			double3.NativeMethodInfoPtr_get_zxyx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666486);
			double3.NativeMethodInfoPtr_get_zxyy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666487);
			double3.NativeMethodInfoPtr_get_zxyz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666488);
			double3.NativeMethodInfoPtr_get_zxzx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666489);
			double3.NativeMethodInfoPtr_get_zxzy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666490);
			double3.NativeMethodInfoPtr_get_zxzz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666491);
			double3.NativeMethodInfoPtr_get_zyxx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666492);
			double3.NativeMethodInfoPtr_get_zyxy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666493);
			double3.NativeMethodInfoPtr_get_zyxz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666494);
			double3.NativeMethodInfoPtr_get_zyyx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666495);
			double3.NativeMethodInfoPtr_get_zyyy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666496);
			double3.NativeMethodInfoPtr_get_zyyz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666497);
			double3.NativeMethodInfoPtr_get_zyzx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666498);
			double3.NativeMethodInfoPtr_get_zyzy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666499);
			double3.NativeMethodInfoPtr_get_zyzz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666500);
			double3.NativeMethodInfoPtr_get_zzxx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666501);
			double3.NativeMethodInfoPtr_get_zzxy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666502);
			double3.NativeMethodInfoPtr_get_zzxz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666503);
			double3.NativeMethodInfoPtr_get_zzyx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666504);
			double3.NativeMethodInfoPtr_get_zzyy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666505);
			double3.NativeMethodInfoPtr_get_zzyz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666506);
			double3.NativeMethodInfoPtr_get_zzzx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666507);
			double3.NativeMethodInfoPtr_get_zzzy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666508);
			double3.NativeMethodInfoPtr_get_zzzz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666509);
			double3.NativeMethodInfoPtr_get_xxx_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666510);
			double3.NativeMethodInfoPtr_get_xxy_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666511);
			double3.NativeMethodInfoPtr_get_xxz_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666512);
			double3.NativeMethodInfoPtr_get_xyx_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666513);
			double3.NativeMethodInfoPtr_get_xyy_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666514);
			double3.NativeMethodInfoPtr_get_xyz_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666515);
			double3.NativeMethodInfoPtr_set_xyz_Public_set_Void_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666516);
			double3.NativeMethodInfoPtr_get_xzx_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666517);
			double3.NativeMethodInfoPtr_get_xzy_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666518);
			double3.NativeMethodInfoPtr_set_xzy_Public_set_Void_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666519);
			double3.NativeMethodInfoPtr_get_xzz_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666520);
			double3.NativeMethodInfoPtr_get_yxx_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666521);
			double3.NativeMethodInfoPtr_get_yxy_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666522);
			double3.NativeMethodInfoPtr_get_yxz_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666523);
			double3.NativeMethodInfoPtr_set_yxz_Public_set_Void_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666524);
			double3.NativeMethodInfoPtr_get_yyx_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666525);
			double3.NativeMethodInfoPtr_get_yyy_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666526);
			double3.NativeMethodInfoPtr_get_yyz_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666527);
			double3.NativeMethodInfoPtr_get_yzx_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666528);
			double3.NativeMethodInfoPtr_set_yzx_Public_set_Void_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666529);
			double3.NativeMethodInfoPtr_get_yzy_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666530);
			double3.NativeMethodInfoPtr_get_yzz_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666531);
			double3.NativeMethodInfoPtr_get_zxx_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666532);
			double3.NativeMethodInfoPtr_get_zxy_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666533);
			double3.NativeMethodInfoPtr_set_zxy_Public_set_Void_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666534);
			double3.NativeMethodInfoPtr_get_zxz_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666535);
			double3.NativeMethodInfoPtr_get_zyx_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666536);
			double3.NativeMethodInfoPtr_set_zyx_Public_set_Void_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666537);
			double3.NativeMethodInfoPtr_get_zyy_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666538);
			double3.NativeMethodInfoPtr_get_zyz_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666539);
			double3.NativeMethodInfoPtr_get_zzx_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666540);
			double3.NativeMethodInfoPtr_get_zzy_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666541);
			double3.NativeMethodInfoPtr_get_zzz_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666542);
			double3.NativeMethodInfoPtr_get_xx_Public_get_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666543);
			double3.NativeMethodInfoPtr_get_xy_Public_get_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666544);
			double3.NativeMethodInfoPtr_set_xy_Public_set_Void_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666545);
			double3.NativeMethodInfoPtr_get_xz_Public_get_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666546);
			double3.NativeMethodInfoPtr_set_xz_Public_set_Void_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666547);
			double3.NativeMethodInfoPtr_get_yx_Public_get_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666548);
			double3.NativeMethodInfoPtr_set_yx_Public_set_Void_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666549);
			double3.NativeMethodInfoPtr_get_yy_Public_get_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666550);
			double3.NativeMethodInfoPtr_get_yz_Public_get_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666551);
			double3.NativeMethodInfoPtr_set_yz_Public_set_Void_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666552);
			double3.NativeMethodInfoPtr_get_zx_Public_get_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666553);
			double3.NativeMethodInfoPtr_set_zx_Public_set_Void_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666554);
			double3.NativeMethodInfoPtr_get_zy_Public_get_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666555);
			double3.NativeMethodInfoPtr_set_zy_Public_set_Void_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666556);
			double3.NativeMethodInfoPtr_get_zz_Public_get_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666557);
			double3.NativeMethodInfoPtr_get_Item_Public_get_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666558);
			double3.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666559);
			double3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666560);
			double3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666561);
			double3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666562);
			double3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666563);
			double3.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3>.NativeClassPtr, 100666564);
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x0004728C File Offset: 0x0004548C
		[CallerCount(0)]
		public unsafe double3(double x, double y, double z)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr__ctor_Public_Void_Double_Double_Double_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x000472DC File Offset: 0x000454DC
		[CallerCount(0)]
		public unsafe double3(double x, double2 yz)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yz;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr__ctor_Public_Void_Double_double2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x0004731C File Offset: 0x0004551C
		[CallerCount(0)]
		public unsafe double3(double2 xy, double z)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xy;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr__ctor_Public_Void_double2_Double_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x0004735C File Offset: 0x0004555C
		[CallerCount(0)]
		public unsafe double3(double3 xyz)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyz;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr__ctor_Public_Void_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x00047390 File Offset: 0x00045590
		[CallerCount(0)]
		public unsafe double3(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x000473C4 File Offset: 0x000455C4
		[CallerCount(0)]
		public unsafe double3(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x000473F8 File Offset: 0x000455F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635221, XrefRangeEnd = 635223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double3(bool3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr__ctor_Public_Void_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x0004742C File Offset: 0x0004562C
		[CallerCount(0)]
		public unsafe double3(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x00047460 File Offset: 0x00045660
		[CallerCount(0)]
		public unsafe double3(int3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr__ctor_Public_Void_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x00047494 File Offset: 0x00045694
		[CallerCount(0)]
		public unsafe double3(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x000474C8 File Offset: 0x000456C8
		[CallerCount(0)]
		public unsafe double3(uint3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr__ctor_Public_Void_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x000474FC File Offset: 0x000456FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 635223, RefRangeEnd = 635224, XrefRangeStart = 635223, XrefRangeEnd = 635223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double3(half v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr__ctor_Public_Void_half_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x00047530 File Offset: 0x00045730
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 635224, RefRangeEnd = 635225, XrefRangeStart = 635224, XrefRangeEnd = 635224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double3(half3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr__ctor_Public_Void_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x00047564 File Offset: 0x00045764
		[CallerCount(0)]
		public unsafe double3(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x00047598 File Offset: 0x00045798
		[CallerCount(0)]
		public unsafe double3(float3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr__ctor_Public_Void_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x000475CC File Offset: 0x000457CC
		[CallerCount(0)]
		public unsafe static implicit operator double3(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_Implicit_Public_Static_double3_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x0004760C File Offset: 0x0004580C
		[CallerCount(0)]
		public unsafe static explicit operator double3(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_Explicit_Public_Static_double3_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x0004764C File Offset: 0x0004584C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator double3(bool3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_Explicit_Public_Static_double3_bool3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x0004768C File Offset: 0x0004588C
		[CallerCount(0)]
		public unsafe static implicit operator double3(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_Implicit_Public_Static_double3_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x000476CC File Offset: 0x000458CC
		[CallerCount(0)]
		public unsafe static implicit operator double3(int3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_Implicit_Public_Static_double3_int3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x0004770C File Offset: 0x0004590C
		[CallerCount(0)]
		public unsafe static implicit operator double3(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_Implicit_Public_Static_double3_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x0004774C File Offset: 0x0004594C
		[CallerCount(0)]
		public unsafe static implicit operator double3(uint3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_Implicit_Public_Static_double3_uint3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x0004778C File Offset: 0x0004598C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635225, XrefRangeEnd = 635226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator double3(half v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_Implicit_Public_Static_double3_half_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x000477CC File Offset: 0x000459CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635226, XrefRangeEnd = 635227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator double3(half3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_Implicit_Public_Static_double3_half3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x0004780C File Offset: 0x00045A0C
		[CallerCount(0)]
		public unsafe static implicit operator double3(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_Implicit_Public_Static_double3_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x0004784C File Offset: 0x00045A4C
		[CallerCount(0)]
		public unsafe static implicit operator double3(float3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_Implicit_Public_Static_double3_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x0004788C File Offset: 0x00045A8C
		[CallerCount(0)]
		public unsafe static double3 operator *(double3 lhs, double3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_Multiply_Public_Static_double3_double3_double3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x000478D8 File Offset: 0x00045AD8
		[CallerCount(0)]
		public unsafe static double3 operator *(double3 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_Multiply_Public_Static_double3_double3_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x00047924 File Offset: 0x00045B24
		[CallerCount(0)]
		public unsafe static double3 operator *(double lhs, double3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_Multiply_Public_Static_double3_Double_double3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x00047970 File Offset: 0x00045B70
		[CallerCount(0)]
		public unsafe static double3 operator +(double3 lhs, double3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_Addition_Public_Static_double3_double3_double3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x000479BC File Offset: 0x00045BBC
		[CallerCount(0)]
		public unsafe static double3 operator +(double3 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_Addition_Public_Static_double3_double3_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x00047A08 File Offset: 0x00045C08
		[CallerCount(0)]
		public unsafe static double3 operator +(double lhs, double3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_Addition_Public_Static_double3_Double_double3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x00047A54 File Offset: 0x00045C54
		[CallerCount(0)]
		public unsafe static double3 operator -(double3 lhs, double3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_Subtraction_Public_Static_double3_double3_double3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x00047AA0 File Offset: 0x00045CA0
		[CallerCount(0)]
		public unsafe static double3 operator -(double3 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_Subtraction_Public_Static_double3_double3_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x00047AEC File Offset: 0x00045CEC
		[CallerCount(0)]
		public unsafe static double3 operator -(double lhs, double3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_Subtraction_Public_Static_double3_Double_double3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x00047B38 File Offset: 0x00045D38
		[CallerCount(0)]
		public unsafe static double3 operator /(double3 lhs, double3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_Division_Public_Static_double3_double3_double3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x00047B84 File Offset: 0x00045D84
		[CallerCount(0)]
		public unsafe static double3 operator /(double3 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_Division_Public_Static_double3_double3_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x00047BD0 File Offset: 0x00045DD0
		[CallerCount(0)]
		public unsafe static double3 operator /(double lhs, double3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_Division_Public_Static_double3_Double_double3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x00047C1C File Offset: 0x00045E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double3 operator %(double3 lhs, double3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_Modulus_Public_Static_double3_double3_double3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x00047C68 File Offset: 0x00045E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635227, XrefRangeEnd = 635230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double3 operator %(double3 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_Modulus_Public_Static_double3_double3_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x00047CB4 File Offset: 0x00045EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635230, XrefRangeEnd = 635233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double3 operator %(double lhs, double3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_Modulus_Public_Static_double3_Double_double3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x00047D00 File Offset: 0x00045F00
		[CallerCount(0)]
		public unsafe static double3 operator ++(double3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_Increment_Public_Static_double3_double3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x00047D40 File Offset: 0x00045F40
		[CallerCount(0)]
		public unsafe static double3 operator --(double3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_Decrement_Public_Static_double3_double3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x00047D80 File Offset: 0x00045F80
		[CallerCount(0)]
		public unsafe static bool3 operator <(double3 lhs, double3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3_double3_double3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x00047DCC File Offset: 0x00045FCC
		[CallerCount(0)]
		public unsafe static bool3 operator <(double3 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3_double3_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x00047E18 File Offset: 0x00046018
		[CallerCount(0)]
		public unsafe static bool3 operator <(double lhs, double3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3_Double_double3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x00047E64 File Offset: 0x00046064
		[CallerCount(0)]
		public unsafe static bool3 operator <=(double3 lhs, double3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3_double3_double3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x00047EB0 File Offset: 0x000460B0
		[CallerCount(0)]
		public unsafe static bool3 operator <=(double3 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3_double3_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x00047EFC File Offset: 0x000460FC
		[CallerCount(0)]
		public unsafe static bool3 operator <=(double lhs, double3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3_Double_double3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x00047F48 File Offset: 0x00046148
		[CallerCount(0)]
		public unsafe static bool3 operator >(double3 lhs, double3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3_double3_double3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x00047F94 File Offset: 0x00046194
		[CallerCount(0)]
		public unsafe static bool3 operator >(double3 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3_double3_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x00047FE0 File Offset: 0x000461E0
		[CallerCount(0)]
		public unsafe static bool3 operator >(double lhs, double3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3_Double_double3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x0004802C File Offset: 0x0004622C
		[CallerCount(0)]
		public unsafe static bool3 operator >=(double3 lhs, double3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3_double3_double3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x00048078 File Offset: 0x00046278
		[CallerCount(0)]
		public unsafe static bool3 operator >=(double3 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3_double3_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x000480C4 File Offset: 0x000462C4
		[CallerCount(0)]
		public unsafe static bool3 operator >=(double lhs, double3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3_Double_double3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x00048110 File Offset: 0x00046310
		[CallerCount(0)]
		public unsafe static double3 operator -(double3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_double3_double3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x00048150 File Offset: 0x00046350
		[CallerCount(0)]
		public unsafe static double3 operator +(double3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_double3_double3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x00048190 File Offset: 0x00046390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635233, XrefRangeEnd = 635235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool3 operator ==(double3 lhs, double3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3_double3_double3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x000481DC File Offset: 0x000463DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635235, XrefRangeEnd = 635237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool3 operator ==(double3 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3_double3_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x00048228 File Offset: 0x00046428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635237, XrefRangeEnd = 635239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool3 operator ==(double lhs, double3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3_Double_double3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x00048274 File Offset: 0x00046474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635239, XrefRangeEnd = 635241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool3 operator !=(double3 lhs, double3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_double3_double3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x000482C0 File Offset: 0x000464C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635241, XrefRangeEnd = 635243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool3 operator !=(double3 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_double3_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x0004830C File Offset: 0x0004650C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635243, XrefRangeEnd = 635245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool3 operator !=(double lhs, double3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_Double_double3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000C95 RID: 3221 RVA: 0x00048358 File Offset: 0x00046558
		public unsafe double4 xxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_xxxx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000C96 RID: 3222 RVA: 0x00048388 File Offset: 0x00046588
		public unsafe double4 xxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_xxxy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000C97 RID: 3223 RVA: 0x000483B8 File Offset: 0x000465B8
		public unsafe double4 xxxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_xxxz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000C98 RID: 3224 RVA: 0x000483E8 File Offset: 0x000465E8
		public unsafe double4 xxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_xxyx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000C99 RID: 3225 RVA: 0x00048418 File Offset: 0x00046618
		public unsafe double4 xxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_xxyy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000C9A RID: 3226 RVA: 0x00048448 File Offset: 0x00046648
		public unsafe double4 xxyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_xxyz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000C9B RID: 3227 RVA: 0x00048478 File Offset: 0x00046678
		public unsafe double4 xxzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_xxzx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000C9C RID: 3228 RVA: 0x000484A8 File Offset: 0x000466A8
		public unsafe double4 xxzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_xxzy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000C9D RID: 3229 RVA: 0x000484D8 File Offset: 0x000466D8
		public unsafe double4 xxzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_xxzz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000C9E RID: 3230 RVA: 0x00048508 File Offset: 0x00046708
		public unsafe double4 xyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_xyxx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000C9F RID: 3231 RVA: 0x00048538 File Offset: 0x00046738
		public unsafe double4 xyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_xyxy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000CA0 RID: 3232 RVA: 0x00048568 File Offset: 0x00046768
		public unsafe double4 xyxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_xyxz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000CA1 RID: 3233 RVA: 0x00048598 File Offset: 0x00046798
		public unsafe double4 xyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_xyyx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000CA2 RID: 3234 RVA: 0x000485C8 File Offset: 0x000467C8
		public unsafe double4 xyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_xyyy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000CA3 RID: 3235 RVA: 0x000485F8 File Offset: 0x000467F8
		public unsafe double4 xyyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_xyyz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000CA4 RID: 3236 RVA: 0x00048628 File Offset: 0x00046828
		public unsafe double4 xyzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_xyzx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000CA5 RID: 3237 RVA: 0x00048658 File Offset: 0x00046858
		public unsafe double4 xyzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_xyzy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000CA6 RID: 3238 RVA: 0x00048688 File Offset: 0x00046888
		public unsafe double4 xyzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_xyzz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000CA7 RID: 3239 RVA: 0x000486B8 File Offset: 0x000468B8
		public unsafe double4 xzxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_xzxx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000CA8 RID: 3240 RVA: 0x000486E8 File Offset: 0x000468E8
		public unsafe double4 xzxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_xzxy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000CA9 RID: 3241 RVA: 0x00048718 File Offset: 0x00046918
		public unsafe double4 xzxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_xzxz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000CAA RID: 3242 RVA: 0x00048748 File Offset: 0x00046948
		public unsafe double4 xzyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_xzyx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000CAB RID: 3243 RVA: 0x00048778 File Offset: 0x00046978
		public unsafe double4 xzyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_xzyy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000CAC RID: 3244 RVA: 0x000487A8 File Offset: 0x000469A8
		public unsafe double4 xzyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_xzyz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000CAD RID: 3245 RVA: 0x000487D8 File Offset: 0x000469D8
		public unsafe double4 xzzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_xzzx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000CAE RID: 3246 RVA: 0x00048808 File Offset: 0x00046A08
		public unsafe double4 xzzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_xzzy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000CAF RID: 3247 RVA: 0x00048838 File Offset: 0x00046A38
		public unsafe double4 xzzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_xzzz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000CB0 RID: 3248 RVA: 0x00048868 File Offset: 0x00046A68
		public unsafe double4 yxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_yxxx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000CB1 RID: 3249 RVA: 0x00048898 File Offset: 0x00046A98
		public unsafe double4 yxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_yxxy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000CB2 RID: 3250 RVA: 0x000488C8 File Offset: 0x00046AC8
		public unsafe double4 yxxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_yxxz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000CB3 RID: 3251 RVA: 0x000488F8 File Offset: 0x00046AF8
		public unsafe double4 yxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_yxyx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000CB4 RID: 3252 RVA: 0x00048928 File Offset: 0x00046B28
		public unsafe double4 yxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_yxyy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x00048958 File Offset: 0x00046B58
		public unsafe double4 yxyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_yxyz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000CB6 RID: 3254 RVA: 0x00048988 File Offset: 0x00046B88
		public unsafe double4 yxzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_yxzx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x000489B8 File Offset: 0x00046BB8
		public unsafe double4 yxzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_yxzy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x000489E8 File Offset: 0x00046BE8
		public unsafe double4 yxzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_yxzz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000CB9 RID: 3257 RVA: 0x00048A18 File Offset: 0x00046C18
		public unsafe double4 yyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_yyxx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000CBA RID: 3258 RVA: 0x00048A48 File Offset: 0x00046C48
		public unsafe double4 yyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_yyxy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000CBB RID: 3259 RVA: 0x00048A78 File Offset: 0x00046C78
		public unsafe double4 yyxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_yyxz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000CBC RID: 3260 RVA: 0x00048AA8 File Offset: 0x00046CA8
		public unsafe double4 yyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_yyyx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000CBD RID: 3261 RVA: 0x00048AD8 File Offset: 0x00046CD8
		public unsafe double4 yyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_yyyy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000CBE RID: 3262 RVA: 0x00048B08 File Offset: 0x00046D08
		public unsafe double4 yyyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_yyyz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000CBF RID: 3263 RVA: 0x00048B38 File Offset: 0x00046D38
		public unsafe double4 yyzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_yyzx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000CC0 RID: 3264 RVA: 0x00048B68 File Offset: 0x00046D68
		public unsafe double4 yyzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_yyzy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000CC1 RID: 3265 RVA: 0x00048B98 File Offset: 0x00046D98
		public unsafe double4 yyzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_yyzz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000CC2 RID: 3266 RVA: 0x00048BC8 File Offset: 0x00046DC8
		public unsafe double4 yzxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_yzxx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000CC3 RID: 3267 RVA: 0x00048BF8 File Offset: 0x00046DF8
		public unsafe double4 yzxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_yzxy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000CC4 RID: 3268 RVA: 0x00048C28 File Offset: 0x00046E28
		public unsafe double4 yzxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_yzxz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000CC5 RID: 3269 RVA: 0x00048C58 File Offset: 0x00046E58
		public unsafe double4 yzyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_yzyx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000CC6 RID: 3270 RVA: 0x00048C88 File Offset: 0x00046E88
		public unsafe double4 yzyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_yzyy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000CC7 RID: 3271 RVA: 0x00048CB8 File Offset: 0x00046EB8
		public unsafe double4 yzyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_yzyz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000CC8 RID: 3272 RVA: 0x00048CE8 File Offset: 0x00046EE8
		public unsafe double4 yzzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_yzzx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000CC9 RID: 3273 RVA: 0x00048D18 File Offset: 0x00046F18
		public unsafe double4 yzzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_yzzy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000CCA RID: 3274 RVA: 0x00048D48 File Offset: 0x00046F48
		public unsafe double4 yzzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_yzzz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000CCB RID: 3275 RVA: 0x00048D78 File Offset: 0x00046F78
		public unsafe double4 zxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_zxxx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000CCC RID: 3276 RVA: 0x00048DA8 File Offset: 0x00046FA8
		public unsafe double4 zxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_zxxy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000CCD RID: 3277 RVA: 0x00048DD8 File Offset: 0x00046FD8
		public unsafe double4 zxxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_zxxz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000CCE RID: 3278 RVA: 0x00048E08 File Offset: 0x00047008
		public unsafe double4 zxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_zxyx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000CCF RID: 3279 RVA: 0x00048E38 File Offset: 0x00047038
		public unsafe double4 zxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_zxyy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000CD0 RID: 3280 RVA: 0x00048E68 File Offset: 0x00047068
		public unsafe double4 zxyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_zxyz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000CD1 RID: 3281 RVA: 0x00048E98 File Offset: 0x00047098
		public unsafe double4 zxzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_zxzx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000CD2 RID: 3282 RVA: 0x00048EC8 File Offset: 0x000470C8
		public unsafe double4 zxzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_zxzy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000CD3 RID: 3283 RVA: 0x00048EF8 File Offset: 0x000470F8
		public unsafe double4 zxzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_zxzz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000CD4 RID: 3284 RVA: 0x00048F28 File Offset: 0x00047128
		public unsafe double4 zyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_zyxx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000CD5 RID: 3285 RVA: 0x00048F58 File Offset: 0x00047158
		public unsafe double4 zyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_zyxy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000CD6 RID: 3286 RVA: 0x00048F88 File Offset: 0x00047188
		public unsafe double4 zyxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_zyxz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000CD7 RID: 3287 RVA: 0x00048FB8 File Offset: 0x000471B8
		public unsafe double4 zyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_zyyx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000CD8 RID: 3288 RVA: 0x00048FE8 File Offset: 0x000471E8
		public unsafe double4 zyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_zyyy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000CD9 RID: 3289 RVA: 0x00049018 File Offset: 0x00047218
		public unsafe double4 zyyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_zyyz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000CDA RID: 3290 RVA: 0x00049048 File Offset: 0x00047248
		public unsafe double4 zyzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_zyzx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000CDB RID: 3291 RVA: 0x00049078 File Offset: 0x00047278
		public unsafe double4 zyzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_zyzy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000CDC RID: 3292 RVA: 0x000490A8 File Offset: 0x000472A8
		public unsafe double4 zyzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_zyzz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000CDD RID: 3293 RVA: 0x000490D8 File Offset: 0x000472D8
		public unsafe double4 zzxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_zzxx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000CDE RID: 3294 RVA: 0x00049108 File Offset: 0x00047308
		public unsafe double4 zzxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_zzxy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000CDF RID: 3295 RVA: 0x00049138 File Offset: 0x00047338
		public unsafe double4 zzxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_zzxz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000CE0 RID: 3296 RVA: 0x00049168 File Offset: 0x00047368
		public unsafe double4 zzyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_zzyx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000CE1 RID: 3297 RVA: 0x00049198 File Offset: 0x00047398
		public unsafe double4 zzyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_zzyy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000CE2 RID: 3298 RVA: 0x000491C8 File Offset: 0x000473C8
		public unsafe double4 zzyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_zzyz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000CE3 RID: 3299 RVA: 0x000491F8 File Offset: 0x000473F8
		public unsafe double4 zzzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_zzzx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000CE4 RID: 3300 RVA: 0x00049228 File Offset: 0x00047428
		public unsafe double4 zzzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_zzzy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x00049258 File Offset: 0x00047458
		public unsafe double4 zzzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_zzzz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000CE6 RID: 3302 RVA: 0x00049288 File Offset: 0x00047488
		public unsafe double3 xxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_xxx_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000CE7 RID: 3303 RVA: 0x000492B8 File Offset: 0x000474B8
		public unsafe double3 xxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_xxy_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000CE8 RID: 3304 RVA: 0x000492E8 File Offset: 0x000474E8
		public unsafe double3 xxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_xxz_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000CE9 RID: 3305 RVA: 0x00049318 File Offset: 0x00047518
		public unsafe double3 xyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_xyx_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000CEA RID: 3306 RVA: 0x00049348 File Offset: 0x00047548
		public unsafe double3 xyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_xyy_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000CEB RID: 3307 RVA: 0x00049378 File Offset: 0x00047578
		// (set) Token: 0x06000CEC RID: 3308 RVA: 0x000493A8 File Offset: 0x000475A8
		public unsafe double3 xyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_xyz_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_set_xyz_Public_set_Void_double3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000CED RID: 3309 RVA: 0x000493DC File Offset: 0x000475DC
		public unsafe double3 xzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_xzx_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000CEE RID: 3310 RVA: 0x0004940C File Offset: 0x0004760C
		// (set) Token: 0x06000CEF RID: 3311 RVA: 0x0004943C File Offset: 0x0004763C
		public unsafe double3 xzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_xzy_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_set_xzy_Public_set_Void_double3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000CF0 RID: 3312 RVA: 0x00049470 File Offset: 0x00047670
		public unsafe double3 xzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_xzz_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000CF1 RID: 3313 RVA: 0x000494A0 File Offset: 0x000476A0
		public unsafe double3 yxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_yxx_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000CF2 RID: 3314 RVA: 0x000494D0 File Offset: 0x000476D0
		public unsafe double3 yxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_yxy_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000CF3 RID: 3315 RVA: 0x00049500 File Offset: 0x00047700
		// (set) Token: 0x06000CF4 RID: 3316 RVA: 0x00049530 File Offset: 0x00047730
		public unsafe double3 yxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_yxz_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_set_yxz_Public_set_Void_double3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000CF5 RID: 3317 RVA: 0x00049564 File Offset: 0x00047764
		public unsafe double3 yyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_yyx_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000CF6 RID: 3318 RVA: 0x00049594 File Offset: 0x00047794
		public unsafe double3 yyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_yyy_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000CF7 RID: 3319 RVA: 0x000495C4 File Offset: 0x000477C4
		public unsafe double3 yyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_yyz_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000CF8 RID: 3320 RVA: 0x000495F4 File Offset: 0x000477F4
		// (set) Token: 0x06000CF9 RID: 3321 RVA: 0x00049624 File Offset: 0x00047824
		public unsafe double3 yzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_yzx_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_set_yzx_Public_set_Void_double3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000CFA RID: 3322 RVA: 0x00049658 File Offset: 0x00047858
		public unsafe double3 yzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_yzy_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000CFB RID: 3323 RVA: 0x00049688 File Offset: 0x00047888
		public unsafe double3 yzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_yzz_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000CFC RID: 3324 RVA: 0x000496B8 File Offset: 0x000478B8
		public unsafe double3 zxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_zxx_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000CFD RID: 3325 RVA: 0x000496E8 File Offset: 0x000478E8
		// (set) Token: 0x06000CFE RID: 3326 RVA: 0x00049718 File Offset: 0x00047918
		public unsafe double3 zxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_zxy_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_set_zxy_Public_set_Void_double3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000CFF RID: 3327 RVA: 0x0004974C File Offset: 0x0004794C
		public unsafe double3 zxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_zxz_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000D00 RID: 3328 RVA: 0x0004977C File Offset: 0x0004797C
		// (set) Token: 0x06000D01 RID: 3329 RVA: 0x000497AC File Offset: 0x000479AC
		public unsafe double3 zyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_zyx_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_set_zyx_Public_set_Void_double3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000D02 RID: 3330 RVA: 0x000497E0 File Offset: 0x000479E0
		public unsafe double3 zyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_zyy_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000D03 RID: 3331 RVA: 0x00049810 File Offset: 0x00047A10
		public unsafe double3 zyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_zyz_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000D04 RID: 3332 RVA: 0x00049840 File Offset: 0x00047A40
		public unsafe double3 zzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_zzx_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000D05 RID: 3333 RVA: 0x00049870 File Offset: 0x00047A70
		public unsafe double3 zzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_zzy_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000D06 RID: 3334 RVA: 0x000498A0 File Offset: 0x00047AA0
		public unsafe double3 zzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_zzz_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000D07 RID: 3335 RVA: 0x000498D0 File Offset: 0x00047AD0
		public unsafe double2 xx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_xx_Public_get_double2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000D08 RID: 3336 RVA: 0x00049900 File Offset: 0x00047B00
		// (set) Token: 0x06000D09 RID: 3337 RVA: 0x00049930 File Offset: 0x00047B30
		public unsafe double2 xy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_xy_Public_get_double2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_set_xy_Public_set_Void_double2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000D0A RID: 3338 RVA: 0x00049964 File Offset: 0x00047B64
		// (set) Token: 0x06000D0B RID: 3339 RVA: 0x00049994 File Offset: 0x00047B94
		public unsafe double2 xz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_xz_Public_get_double2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_set_xz_Public_set_Void_double2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000D0C RID: 3340 RVA: 0x000499C8 File Offset: 0x00047BC8
		// (set) Token: 0x06000D0D RID: 3341 RVA: 0x000499F8 File Offset: 0x00047BF8
		public unsafe double2 yx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_yx_Public_get_double2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_set_yx_Public_set_Void_double2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000D0E RID: 3342 RVA: 0x00049A2C File Offset: 0x00047C2C
		public unsafe double2 yy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_yy_Public_get_double2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000D0F RID: 3343 RVA: 0x00049A5C File Offset: 0x00047C5C
		// (set) Token: 0x06000D10 RID: 3344 RVA: 0x00049A8C File Offset: 0x00047C8C
		public unsafe double2 yz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_yz_Public_get_double2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_set_yz_Public_set_Void_double2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000D11 RID: 3345 RVA: 0x00049AC0 File Offset: 0x00047CC0
		// (set) Token: 0x06000D12 RID: 3346 RVA: 0x00049AF0 File Offset: 0x00047CF0
		public unsafe double2 zx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_zx_Public_get_double2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_set_zx_Public_set_Void_double2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000D13 RID: 3347 RVA: 0x00049B24 File Offset: 0x00047D24
		// (set) Token: 0x06000D14 RID: 3348 RVA: 0x00049B54 File Offset: 0x00047D54
		public unsafe double2 zy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_zy_Public_get_double2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_set_zy_Public_set_Void_double2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000D15 RID: 3349 RVA: 0x00049B88 File Offset: 0x00047D88
		public unsafe double2 zz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_zz_Public_get_double2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700029F RID: 671
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_get_Item_Public_get_Double_Int32_0, ref this, (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x00049C38 File Offset: 0x00047E38
		[CallerCount(0)]
		public unsafe bool Equals(double3 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x00049C78 File Offset: 0x00047E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635245, XrefRangeEnd = 635248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x00049CBC File Offset: 0x00047EBC
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x00049CEC File Offset: 0x00047EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635248, XrefRangeEnd = 635258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x00049D18 File Offset: 0x00047F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635258, XrefRangeEnd = 635264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x0000233E File Offset: 0x0000053E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<double3>.NativeClassPtr, ref this));
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000D1E RID: 3358 RVA: 0x00049D68 File Offset: 0x00047F68
		// (set) Token: 0x06000D1F RID: 3359 RVA: 0x00002350 File Offset: 0x00000550
		public unsafe static double3 zero
		{
			get
			{
				double3 @double;
				IL2CPP.il2cpp_field_static_get_value(double3.NativeFieldInfoPtr_zero, (void*)(&@double));
				return @double;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(double3.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x04000C72 RID: 3186
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x04000C73 RID: 3187
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04000C74 RID: 3188
		private static readonly IntPtr NativeFieldInfoPtr_z;

		// Token: 0x04000C75 RID: 3189
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x04000C76 RID: 3190
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_Double_Double_0;

		// Token: 0x04000C77 RID: 3191
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_double2_0;

		// Token: 0x04000C78 RID: 3192
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double2_Double_0;

		// Token: 0x04000C79 RID: 3193
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double3_0;

		// Token: 0x04000C7A RID: 3194
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x04000C7B RID: 3195
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04000C7C RID: 3196
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool3_0;

		// Token: 0x04000C7D RID: 3197
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000C7E RID: 3198
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int3_0;

		// Token: 0x04000C7F RID: 3199
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04000C80 RID: 3200
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint3_0;

		// Token: 0x04000C81 RID: 3201
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_half_0;

		// Token: 0x04000C82 RID: 3202
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_half3_0;

		// Token: 0x04000C83 RID: 3203
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x04000C84 RID: 3204
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float3_0;

		// Token: 0x04000C85 RID: 3205
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double3_Double_0;

		// Token: 0x04000C86 RID: 3206
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_double3_Boolean_0;

		// Token: 0x04000C87 RID: 3207
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_double3_bool3_0;

		// Token: 0x04000C88 RID: 3208
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double3_Int32_0;

		// Token: 0x04000C89 RID: 3209
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double3_int3_0;

		// Token: 0x04000C8A RID: 3210
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double3_UInt32_0;

		// Token: 0x04000C8B RID: 3211
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double3_uint3_0;

		// Token: 0x04000C8C RID: 3212
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double3_half_0;

		// Token: 0x04000C8D RID: 3213
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double3_half3_0;

		// Token: 0x04000C8E RID: 3214
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double3_Single_0;

		// Token: 0x04000C8F RID: 3215
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double3_float3_0;

		// Token: 0x04000C90 RID: 3216
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_double3_double3_double3_0;

		// Token: 0x04000C91 RID: 3217
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_double3_double3_Double_0;

		// Token: 0x04000C92 RID: 3218
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_double3_Double_double3_0;

		// Token: 0x04000C93 RID: 3219
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_double3_double3_double3_0;

		// Token: 0x04000C94 RID: 3220
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_double3_double3_Double_0;

		// Token: 0x04000C95 RID: 3221
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_double3_Double_double3_0;

		// Token: 0x04000C96 RID: 3222
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_double3_double3_double3_0;

		// Token: 0x04000C97 RID: 3223
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_double3_double3_Double_0;

		// Token: 0x04000C98 RID: 3224
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_double3_Double_double3_0;

		// Token: 0x04000C99 RID: 3225
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_double3_double3_double3_0;

		// Token: 0x04000C9A RID: 3226
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_double3_double3_Double_0;

		// Token: 0x04000C9B RID: 3227
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_double3_Double_double3_0;

		// Token: 0x04000C9C RID: 3228
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_double3_double3_double3_0;

		// Token: 0x04000C9D RID: 3229
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_double3_double3_Double_0;

		// Token: 0x04000C9E RID: 3230
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_double3_Double_double3_0;

		// Token: 0x04000C9F RID: 3231
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_double3_double3_0;

		// Token: 0x04000CA0 RID: 3232
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_double3_double3_0;

		// Token: 0x04000CA1 RID: 3233
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool3_double3_double3_0;

		// Token: 0x04000CA2 RID: 3234
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool3_double3_Double_0;

		// Token: 0x04000CA3 RID: 3235
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool3_Double_double3_0;

		// Token: 0x04000CA4 RID: 3236
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3_double3_double3_0;

		// Token: 0x04000CA5 RID: 3237
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3_double3_Double_0;

		// Token: 0x04000CA6 RID: 3238
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3_Double_double3_0;

		// Token: 0x04000CA7 RID: 3239
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3_double3_double3_0;

		// Token: 0x04000CA8 RID: 3240
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3_double3_Double_0;

		// Token: 0x04000CA9 RID: 3241
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3_Double_double3_0;

		// Token: 0x04000CAA RID: 3242
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3_double3_double3_0;

		// Token: 0x04000CAB RID: 3243
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3_double3_Double_0;

		// Token: 0x04000CAC RID: 3244
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3_Double_double3_0;

		// Token: 0x04000CAD RID: 3245
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_double3_double3_0;

		// Token: 0x04000CAE RID: 3246
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryPlus_Public_Static_double3_double3_0;

		// Token: 0x04000CAF RID: 3247
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3_double3_double3_0;

		// Token: 0x04000CB0 RID: 3248
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3_double3_Double_0;

		// Token: 0x04000CB1 RID: 3249
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3_Double_double3_0;

		// Token: 0x04000CB2 RID: 3250
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_double3_double3_0;

		// Token: 0x04000CB3 RID: 3251
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_double3_Double_0;

		// Token: 0x04000CB4 RID: 3252
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_Double_double3_0;

		// Token: 0x04000CB5 RID: 3253
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxx_Public_get_double4_0;

		// Token: 0x04000CB6 RID: 3254
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxy_Public_get_double4_0;

		// Token: 0x04000CB7 RID: 3255
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxz_Public_get_double4_0;

		// Token: 0x04000CB8 RID: 3256
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyx_Public_get_double4_0;

		// Token: 0x04000CB9 RID: 3257
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyy_Public_get_double4_0;

		// Token: 0x04000CBA RID: 3258
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyz_Public_get_double4_0;

		// Token: 0x04000CBB RID: 3259
		private static readonly IntPtr NativeMethodInfoPtr_get_xxzx_Public_get_double4_0;

		// Token: 0x04000CBC RID: 3260
		private static readonly IntPtr NativeMethodInfoPtr_get_xxzy_Public_get_double4_0;

		// Token: 0x04000CBD RID: 3261
		private static readonly IntPtr NativeMethodInfoPtr_get_xxzz_Public_get_double4_0;

		// Token: 0x04000CBE RID: 3262
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxx_Public_get_double4_0;

		// Token: 0x04000CBF RID: 3263
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxy_Public_get_double4_0;

		// Token: 0x04000CC0 RID: 3264
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxz_Public_get_double4_0;

		// Token: 0x04000CC1 RID: 3265
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyx_Public_get_double4_0;

		// Token: 0x04000CC2 RID: 3266
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyy_Public_get_double4_0;

		// Token: 0x04000CC3 RID: 3267
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyz_Public_get_double4_0;

		// Token: 0x04000CC4 RID: 3268
		private static readonly IntPtr NativeMethodInfoPtr_get_xyzx_Public_get_double4_0;

		// Token: 0x04000CC5 RID: 3269
		private static readonly IntPtr NativeMethodInfoPtr_get_xyzy_Public_get_double4_0;

		// Token: 0x04000CC6 RID: 3270
		private static readonly IntPtr NativeMethodInfoPtr_get_xyzz_Public_get_double4_0;

		// Token: 0x04000CC7 RID: 3271
		private static readonly IntPtr NativeMethodInfoPtr_get_xzxx_Public_get_double4_0;

		// Token: 0x04000CC8 RID: 3272
		private static readonly IntPtr NativeMethodInfoPtr_get_xzxy_Public_get_double4_0;

		// Token: 0x04000CC9 RID: 3273
		private static readonly IntPtr NativeMethodInfoPtr_get_xzxz_Public_get_double4_0;

		// Token: 0x04000CCA RID: 3274
		private static readonly IntPtr NativeMethodInfoPtr_get_xzyx_Public_get_double4_0;

		// Token: 0x04000CCB RID: 3275
		private static readonly IntPtr NativeMethodInfoPtr_get_xzyy_Public_get_double4_0;

		// Token: 0x04000CCC RID: 3276
		private static readonly IntPtr NativeMethodInfoPtr_get_xzyz_Public_get_double4_0;

		// Token: 0x04000CCD RID: 3277
		private static readonly IntPtr NativeMethodInfoPtr_get_xzzx_Public_get_double4_0;

		// Token: 0x04000CCE RID: 3278
		private static readonly IntPtr NativeMethodInfoPtr_get_xzzy_Public_get_double4_0;

		// Token: 0x04000CCF RID: 3279
		private static readonly IntPtr NativeMethodInfoPtr_get_xzzz_Public_get_double4_0;

		// Token: 0x04000CD0 RID: 3280
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxx_Public_get_double4_0;

		// Token: 0x04000CD1 RID: 3281
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxy_Public_get_double4_0;

		// Token: 0x04000CD2 RID: 3282
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxz_Public_get_double4_0;

		// Token: 0x04000CD3 RID: 3283
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyx_Public_get_double4_0;

		// Token: 0x04000CD4 RID: 3284
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyy_Public_get_double4_0;

		// Token: 0x04000CD5 RID: 3285
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyz_Public_get_double4_0;

		// Token: 0x04000CD6 RID: 3286
		private static readonly IntPtr NativeMethodInfoPtr_get_yxzx_Public_get_double4_0;

		// Token: 0x04000CD7 RID: 3287
		private static readonly IntPtr NativeMethodInfoPtr_get_yxzy_Public_get_double4_0;

		// Token: 0x04000CD8 RID: 3288
		private static readonly IntPtr NativeMethodInfoPtr_get_yxzz_Public_get_double4_0;

		// Token: 0x04000CD9 RID: 3289
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxx_Public_get_double4_0;

		// Token: 0x04000CDA RID: 3290
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxy_Public_get_double4_0;

		// Token: 0x04000CDB RID: 3291
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxz_Public_get_double4_0;

		// Token: 0x04000CDC RID: 3292
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyx_Public_get_double4_0;

		// Token: 0x04000CDD RID: 3293
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyy_Public_get_double4_0;

		// Token: 0x04000CDE RID: 3294
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyz_Public_get_double4_0;

		// Token: 0x04000CDF RID: 3295
		private static readonly IntPtr NativeMethodInfoPtr_get_yyzx_Public_get_double4_0;

		// Token: 0x04000CE0 RID: 3296
		private static readonly IntPtr NativeMethodInfoPtr_get_yyzy_Public_get_double4_0;

		// Token: 0x04000CE1 RID: 3297
		private static readonly IntPtr NativeMethodInfoPtr_get_yyzz_Public_get_double4_0;

		// Token: 0x04000CE2 RID: 3298
		private static readonly IntPtr NativeMethodInfoPtr_get_yzxx_Public_get_double4_0;

		// Token: 0x04000CE3 RID: 3299
		private static readonly IntPtr NativeMethodInfoPtr_get_yzxy_Public_get_double4_0;

		// Token: 0x04000CE4 RID: 3300
		private static readonly IntPtr NativeMethodInfoPtr_get_yzxz_Public_get_double4_0;

		// Token: 0x04000CE5 RID: 3301
		private static readonly IntPtr NativeMethodInfoPtr_get_yzyx_Public_get_double4_0;

		// Token: 0x04000CE6 RID: 3302
		private static readonly IntPtr NativeMethodInfoPtr_get_yzyy_Public_get_double4_0;

		// Token: 0x04000CE7 RID: 3303
		private static readonly IntPtr NativeMethodInfoPtr_get_yzyz_Public_get_double4_0;

		// Token: 0x04000CE8 RID: 3304
		private static readonly IntPtr NativeMethodInfoPtr_get_yzzx_Public_get_double4_0;

		// Token: 0x04000CE9 RID: 3305
		private static readonly IntPtr NativeMethodInfoPtr_get_yzzy_Public_get_double4_0;

		// Token: 0x04000CEA RID: 3306
		private static readonly IntPtr NativeMethodInfoPtr_get_yzzz_Public_get_double4_0;

		// Token: 0x04000CEB RID: 3307
		private static readonly IntPtr NativeMethodInfoPtr_get_zxxx_Public_get_double4_0;

		// Token: 0x04000CEC RID: 3308
		private static readonly IntPtr NativeMethodInfoPtr_get_zxxy_Public_get_double4_0;

		// Token: 0x04000CED RID: 3309
		private static readonly IntPtr NativeMethodInfoPtr_get_zxxz_Public_get_double4_0;

		// Token: 0x04000CEE RID: 3310
		private static readonly IntPtr NativeMethodInfoPtr_get_zxyx_Public_get_double4_0;

		// Token: 0x04000CEF RID: 3311
		private static readonly IntPtr NativeMethodInfoPtr_get_zxyy_Public_get_double4_0;

		// Token: 0x04000CF0 RID: 3312
		private static readonly IntPtr NativeMethodInfoPtr_get_zxyz_Public_get_double4_0;

		// Token: 0x04000CF1 RID: 3313
		private static readonly IntPtr NativeMethodInfoPtr_get_zxzx_Public_get_double4_0;

		// Token: 0x04000CF2 RID: 3314
		private static readonly IntPtr NativeMethodInfoPtr_get_zxzy_Public_get_double4_0;

		// Token: 0x04000CF3 RID: 3315
		private static readonly IntPtr NativeMethodInfoPtr_get_zxzz_Public_get_double4_0;

		// Token: 0x04000CF4 RID: 3316
		private static readonly IntPtr NativeMethodInfoPtr_get_zyxx_Public_get_double4_0;

		// Token: 0x04000CF5 RID: 3317
		private static readonly IntPtr NativeMethodInfoPtr_get_zyxy_Public_get_double4_0;

		// Token: 0x04000CF6 RID: 3318
		private static readonly IntPtr NativeMethodInfoPtr_get_zyxz_Public_get_double4_0;

		// Token: 0x04000CF7 RID: 3319
		private static readonly IntPtr NativeMethodInfoPtr_get_zyyx_Public_get_double4_0;

		// Token: 0x04000CF8 RID: 3320
		private static readonly IntPtr NativeMethodInfoPtr_get_zyyy_Public_get_double4_0;

		// Token: 0x04000CF9 RID: 3321
		private static readonly IntPtr NativeMethodInfoPtr_get_zyyz_Public_get_double4_0;

		// Token: 0x04000CFA RID: 3322
		private static readonly IntPtr NativeMethodInfoPtr_get_zyzx_Public_get_double4_0;

		// Token: 0x04000CFB RID: 3323
		private static readonly IntPtr NativeMethodInfoPtr_get_zyzy_Public_get_double4_0;

		// Token: 0x04000CFC RID: 3324
		private static readonly IntPtr NativeMethodInfoPtr_get_zyzz_Public_get_double4_0;

		// Token: 0x04000CFD RID: 3325
		private static readonly IntPtr NativeMethodInfoPtr_get_zzxx_Public_get_double4_0;

		// Token: 0x04000CFE RID: 3326
		private static readonly IntPtr NativeMethodInfoPtr_get_zzxy_Public_get_double4_0;

		// Token: 0x04000CFF RID: 3327
		private static readonly IntPtr NativeMethodInfoPtr_get_zzxz_Public_get_double4_0;

		// Token: 0x04000D00 RID: 3328
		private static readonly IntPtr NativeMethodInfoPtr_get_zzyx_Public_get_double4_0;

		// Token: 0x04000D01 RID: 3329
		private static readonly IntPtr NativeMethodInfoPtr_get_zzyy_Public_get_double4_0;

		// Token: 0x04000D02 RID: 3330
		private static readonly IntPtr NativeMethodInfoPtr_get_zzyz_Public_get_double4_0;

		// Token: 0x04000D03 RID: 3331
		private static readonly IntPtr NativeMethodInfoPtr_get_zzzx_Public_get_double4_0;

		// Token: 0x04000D04 RID: 3332
		private static readonly IntPtr NativeMethodInfoPtr_get_zzzy_Public_get_double4_0;

		// Token: 0x04000D05 RID: 3333
		private static readonly IntPtr NativeMethodInfoPtr_get_zzzz_Public_get_double4_0;

		// Token: 0x04000D06 RID: 3334
		private static readonly IntPtr NativeMethodInfoPtr_get_xxx_Public_get_double3_0;

		// Token: 0x04000D07 RID: 3335
		private static readonly IntPtr NativeMethodInfoPtr_get_xxy_Public_get_double3_0;

		// Token: 0x04000D08 RID: 3336
		private static readonly IntPtr NativeMethodInfoPtr_get_xxz_Public_get_double3_0;

		// Token: 0x04000D09 RID: 3337
		private static readonly IntPtr NativeMethodInfoPtr_get_xyx_Public_get_double3_0;

		// Token: 0x04000D0A RID: 3338
		private static readonly IntPtr NativeMethodInfoPtr_get_xyy_Public_get_double3_0;

		// Token: 0x04000D0B RID: 3339
		private static readonly IntPtr NativeMethodInfoPtr_get_xyz_Public_get_double3_0;

		// Token: 0x04000D0C RID: 3340
		private static readonly IntPtr NativeMethodInfoPtr_set_xyz_Public_set_Void_double3_0;

		// Token: 0x04000D0D RID: 3341
		private static readonly IntPtr NativeMethodInfoPtr_get_xzx_Public_get_double3_0;

		// Token: 0x04000D0E RID: 3342
		private static readonly IntPtr NativeMethodInfoPtr_get_xzy_Public_get_double3_0;

		// Token: 0x04000D0F RID: 3343
		private static readonly IntPtr NativeMethodInfoPtr_set_xzy_Public_set_Void_double3_0;

		// Token: 0x04000D10 RID: 3344
		private static readonly IntPtr NativeMethodInfoPtr_get_xzz_Public_get_double3_0;

		// Token: 0x04000D11 RID: 3345
		private static readonly IntPtr NativeMethodInfoPtr_get_yxx_Public_get_double3_0;

		// Token: 0x04000D12 RID: 3346
		private static readonly IntPtr NativeMethodInfoPtr_get_yxy_Public_get_double3_0;

		// Token: 0x04000D13 RID: 3347
		private static readonly IntPtr NativeMethodInfoPtr_get_yxz_Public_get_double3_0;

		// Token: 0x04000D14 RID: 3348
		private static readonly IntPtr NativeMethodInfoPtr_set_yxz_Public_set_Void_double3_0;

		// Token: 0x04000D15 RID: 3349
		private static readonly IntPtr NativeMethodInfoPtr_get_yyx_Public_get_double3_0;

		// Token: 0x04000D16 RID: 3350
		private static readonly IntPtr NativeMethodInfoPtr_get_yyy_Public_get_double3_0;

		// Token: 0x04000D17 RID: 3351
		private static readonly IntPtr NativeMethodInfoPtr_get_yyz_Public_get_double3_0;

		// Token: 0x04000D18 RID: 3352
		private static readonly IntPtr NativeMethodInfoPtr_get_yzx_Public_get_double3_0;

		// Token: 0x04000D19 RID: 3353
		private static readonly IntPtr NativeMethodInfoPtr_set_yzx_Public_set_Void_double3_0;

		// Token: 0x04000D1A RID: 3354
		private static readonly IntPtr NativeMethodInfoPtr_get_yzy_Public_get_double3_0;

		// Token: 0x04000D1B RID: 3355
		private static readonly IntPtr NativeMethodInfoPtr_get_yzz_Public_get_double3_0;

		// Token: 0x04000D1C RID: 3356
		private static readonly IntPtr NativeMethodInfoPtr_get_zxx_Public_get_double3_0;

		// Token: 0x04000D1D RID: 3357
		private static readonly IntPtr NativeMethodInfoPtr_get_zxy_Public_get_double3_0;

		// Token: 0x04000D1E RID: 3358
		private static readonly IntPtr NativeMethodInfoPtr_set_zxy_Public_set_Void_double3_0;

		// Token: 0x04000D1F RID: 3359
		private static readonly IntPtr NativeMethodInfoPtr_get_zxz_Public_get_double3_0;

		// Token: 0x04000D20 RID: 3360
		private static readonly IntPtr NativeMethodInfoPtr_get_zyx_Public_get_double3_0;

		// Token: 0x04000D21 RID: 3361
		private static readonly IntPtr NativeMethodInfoPtr_set_zyx_Public_set_Void_double3_0;

		// Token: 0x04000D22 RID: 3362
		private static readonly IntPtr NativeMethodInfoPtr_get_zyy_Public_get_double3_0;

		// Token: 0x04000D23 RID: 3363
		private static readonly IntPtr NativeMethodInfoPtr_get_zyz_Public_get_double3_0;

		// Token: 0x04000D24 RID: 3364
		private static readonly IntPtr NativeMethodInfoPtr_get_zzx_Public_get_double3_0;

		// Token: 0x04000D25 RID: 3365
		private static readonly IntPtr NativeMethodInfoPtr_get_zzy_Public_get_double3_0;

		// Token: 0x04000D26 RID: 3366
		private static readonly IntPtr NativeMethodInfoPtr_get_zzz_Public_get_double3_0;

		// Token: 0x04000D27 RID: 3367
		private static readonly IntPtr NativeMethodInfoPtr_get_xx_Public_get_double2_0;

		// Token: 0x04000D28 RID: 3368
		private static readonly IntPtr NativeMethodInfoPtr_get_xy_Public_get_double2_0;

		// Token: 0x04000D29 RID: 3369
		private static readonly IntPtr NativeMethodInfoPtr_set_xy_Public_set_Void_double2_0;

		// Token: 0x04000D2A RID: 3370
		private static readonly IntPtr NativeMethodInfoPtr_get_xz_Public_get_double2_0;

		// Token: 0x04000D2B RID: 3371
		private static readonly IntPtr NativeMethodInfoPtr_set_xz_Public_set_Void_double2_0;

		// Token: 0x04000D2C RID: 3372
		private static readonly IntPtr NativeMethodInfoPtr_get_yx_Public_get_double2_0;

		// Token: 0x04000D2D RID: 3373
		private static readonly IntPtr NativeMethodInfoPtr_set_yx_Public_set_Void_double2_0;

		// Token: 0x04000D2E RID: 3374
		private static readonly IntPtr NativeMethodInfoPtr_get_yy_Public_get_double2_0;

		// Token: 0x04000D2F RID: 3375
		private static readonly IntPtr NativeMethodInfoPtr_get_yz_Public_get_double2_0;

		// Token: 0x04000D30 RID: 3376
		private static readonly IntPtr NativeMethodInfoPtr_set_yz_Public_set_Void_double2_0;

		// Token: 0x04000D31 RID: 3377
		private static readonly IntPtr NativeMethodInfoPtr_get_zx_Public_get_double2_0;

		// Token: 0x04000D32 RID: 3378
		private static readonly IntPtr NativeMethodInfoPtr_set_zx_Public_set_Void_double2_0;

		// Token: 0x04000D33 RID: 3379
		private static readonly IntPtr NativeMethodInfoPtr_get_zy_Public_get_double2_0;

		// Token: 0x04000D34 RID: 3380
		private static readonly IntPtr NativeMethodInfoPtr_set_zy_Public_set_Void_double2_0;

		// Token: 0x04000D35 RID: 3381
		private static readonly IntPtr NativeMethodInfoPtr_get_zz_Public_get_double2_0;

		// Token: 0x04000D36 RID: 3382
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Double_Int32_0;

		// Token: 0x04000D37 RID: 3383
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Double_0;

		// Token: 0x04000D38 RID: 3384
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_double3_0;

		// Token: 0x04000D39 RID: 3385
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000D3A RID: 3386
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000D3B RID: 3387
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000D3C RID: 3388
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04000D3D RID: 3389
		[FieldOffset(0)]
		public double x;

		// Token: 0x04000D3E RID: 3390
		[FieldOffset(8)]
		public double y;

		// Token: 0x04000D3F RID: 3391
		[FieldOffset(16)]
		public double z;

		// Token: 0x02000058 RID: 88
		public sealed class DebuggerProxy : Object
		{
			// Token: 0x060025DB RID: 9691 RVA: 0x000C3210 File Offset: 0x000C1410
			// Note: this type is marked as 'beforefieldinit'.
			static DebuggerProxy()
			{
				Il2CppClassPointerStore<double3.DebuggerProxy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<double3>.NativeClassPtr, "DebuggerProxy");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<double3.DebuggerProxy>.NativeClassPtr);
				double3.DebuggerProxy.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double3.DebuggerProxy>.NativeClassPtr, "x");
				double3.DebuggerProxy.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double3.DebuggerProxy>.NativeClassPtr, "y");
				double3.DebuggerProxy.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double3.DebuggerProxy>.NativeClassPtr, "z");
				double3.DebuggerProxy.NativeMethodInfoPtr__ctor_Public_Void_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3.DebuggerProxy>.NativeClassPtr, 100666565);
			}

			// Token: 0x060025DC RID: 9692 RVA: 0x000C328C File Offset: 0x000C148C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635220, XrefRangeEnd = 635221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DebuggerProxy(double3 v)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<double3.DebuggerProxy>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3.DebuggerProxy.NativeMethodInfoPtr__ctor_Public_Void_double3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060025DD RID: 9693 RVA: 0x00002D24 File Offset: 0x00000F24
			public DebuggerProxy(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BFC RID: 3068
			// (get) Token: 0x060025DE RID: 9694 RVA: 0x000C32D4 File Offset: 0x000C14D4
			// (set) Token: 0x060025DF RID: 9695 RVA: 0x00002D2D File Offset: 0x00000F2D
			public unsafe double x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(double3.DebuggerProxy.NativeFieldInfoPtr_x);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(double3.DebuggerProxy.NativeFieldInfoPtr_x)) = value;
				}
			}

			// Token: 0x17000BFD RID: 3069
			// (get) Token: 0x060025E0 RID: 9696 RVA: 0x000C32FC File Offset: 0x000C14FC
			// (set) Token: 0x060025E1 RID: 9697 RVA: 0x00002D48 File Offset: 0x00000F48
			public unsafe double y
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(double3.DebuggerProxy.NativeFieldInfoPtr_y);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(double3.DebuggerProxy.NativeFieldInfoPtr_y)) = value;
				}
			}

			// Token: 0x17000BFE RID: 3070
			// (get) Token: 0x060025E2 RID: 9698 RVA: 0x000C3324 File Offset: 0x000C1524
			// (set) Token: 0x060025E3 RID: 9699 RVA: 0x00002D63 File Offset: 0x00000F63
			public unsafe double z
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(double3.DebuggerProxy.NativeFieldInfoPtr_z);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(double3.DebuggerProxy.NativeFieldInfoPtr_z)) = value;
				}
			}

			// Token: 0x0400266B RID: 9835
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x0400266C RID: 9836
			private static readonly IntPtr NativeFieldInfoPtr_y;

			// Token: 0x0400266D RID: 9837
			private static readonly IntPtr NativeFieldInfoPtr_z;

			// Token: 0x0400266E RID: 9838
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double3_0;
		}
	}
}
