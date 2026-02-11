using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x02000009 RID: 9
	[Serializable]
	[StructLayout(2)]
	public struct bool3
	{
		// Token: 0x06000835 RID: 2101 RVA: 0x00032274 File Offset: 0x00030474
		// Note: this type is marked as 'beforefieldinit'.
		static bool3()
		{
			Il2CppClassPointerStore<bool3>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "bool3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<bool3>.NativeClassPtr);
			bool3.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bool3>.NativeClassPtr, "x");
			bool3.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bool3>.NativeClassPtr, "y");
			bool3.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bool3>.NativeClassPtr, "z");
			bool3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665340);
			bool3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665341);
			bool3.NativeMethodInfoPtr__ctor_Public_Void_bool2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665342);
			bool3.NativeMethodInfoPtr__ctor_Public_Void_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665343);
			bool3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665344);
			bool3.NativeMethodInfoPtr_op_Implicit_Public_Static_bool3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665345);
			bool3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3_bool3_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665346);
			bool3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3_bool3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665347);
			bool3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3_Boolean_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665348);
			bool3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_bool3_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665349);
			bool3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_bool3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665350);
			bool3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_Boolean_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665351);
			bool3.NativeMethodInfoPtr_op_LogicalNot_Public_Static_bool3_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665352);
			bool3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool3_bool3_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665353);
			bool3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool3_bool3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665354);
			bool3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool3_Boolean_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665355);
			bool3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool3_bool3_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665356);
			bool3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool3_bool3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665357);
			bool3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool3_Boolean_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665358);
			bool3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool3_bool3_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665359);
			bool3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool3_bool3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665360);
			bool3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool3_Boolean_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665361);
			bool3.NativeMethodInfoPtr_get_xxxx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665362);
			bool3.NativeMethodInfoPtr_get_xxxy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665363);
			bool3.NativeMethodInfoPtr_get_xxxz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665364);
			bool3.NativeMethodInfoPtr_get_xxyx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665365);
			bool3.NativeMethodInfoPtr_get_xxyy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665366);
			bool3.NativeMethodInfoPtr_get_xxyz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665367);
			bool3.NativeMethodInfoPtr_get_xxzx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665368);
			bool3.NativeMethodInfoPtr_get_xxzy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665369);
			bool3.NativeMethodInfoPtr_get_xxzz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665370);
			bool3.NativeMethodInfoPtr_get_xyxx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665371);
			bool3.NativeMethodInfoPtr_get_xyxy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665372);
			bool3.NativeMethodInfoPtr_get_xyxz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665373);
			bool3.NativeMethodInfoPtr_get_xyyx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665374);
			bool3.NativeMethodInfoPtr_get_xyyy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665375);
			bool3.NativeMethodInfoPtr_get_xyyz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665376);
			bool3.NativeMethodInfoPtr_get_xyzx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665377);
			bool3.NativeMethodInfoPtr_get_xyzy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665378);
			bool3.NativeMethodInfoPtr_get_xyzz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665379);
			bool3.NativeMethodInfoPtr_get_xzxx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665380);
			bool3.NativeMethodInfoPtr_get_xzxy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665381);
			bool3.NativeMethodInfoPtr_get_xzxz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665382);
			bool3.NativeMethodInfoPtr_get_xzyx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665383);
			bool3.NativeMethodInfoPtr_get_xzyy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665384);
			bool3.NativeMethodInfoPtr_get_xzyz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665385);
			bool3.NativeMethodInfoPtr_get_xzzx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665386);
			bool3.NativeMethodInfoPtr_get_xzzy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665387);
			bool3.NativeMethodInfoPtr_get_xzzz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665388);
			bool3.NativeMethodInfoPtr_get_yxxx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665389);
			bool3.NativeMethodInfoPtr_get_yxxy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665390);
			bool3.NativeMethodInfoPtr_get_yxxz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665391);
			bool3.NativeMethodInfoPtr_get_yxyx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665392);
			bool3.NativeMethodInfoPtr_get_yxyy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665393);
			bool3.NativeMethodInfoPtr_get_yxyz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665394);
			bool3.NativeMethodInfoPtr_get_yxzx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665395);
			bool3.NativeMethodInfoPtr_get_yxzy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665396);
			bool3.NativeMethodInfoPtr_get_yxzz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665397);
			bool3.NativeMethodInfoPtr_get_yyxx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665398);
			bool3.NativeMethodInfoPtr_get_yyxy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665399);
			bool3.NativeMethodInfoPtr_get_yyxz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665400);
			bool3.NativeMethodInfoPtr_get_yyyx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665401);
			bool3.NativeMethodInfoPtr_get_yyyy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665402);
			bool3.NativeMethodInfoPtr_get_yyyz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665403);
			bool3.NativeMethodInfoPtr_get_yyzx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665404);
			bool3.NativeMethodInfoPtr_get_yyzy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665405);
			bool3.NativeMethodInfoPtr_get_yyzz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665406);
			bool3.NativeMethodInfoPtr_get_yzxx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665407);
			bool3.NativeMethodInfoPtr_get_yzxy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665408);
			bool3.NativeMethodInfoPtr_get_yzxz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665409);
			bool3.NativeMethodInfoPtr_get_yzyx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665410);
			bool3.NativeMethodInfoPtr_get_yzyy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665411);
			bool3.NativeMethodInfoPtr_get_yzyz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665412);
			bool3.NativeMethodInfoPtr_get_yzzx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665413);
			bool3.NativeMethodInfoPtr_get_yzzy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665414);
			bool3.NativeMethodInfoPtr_get_yzzz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665415);
			bool3.NativeMethodInfoPtr_get_zxxx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665416);
			bool3.NativeMethodInfoPtr_get_zxxy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665417);
			bool3.NativeMethodInfoPtr_get_zxxz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665418);
			bool3.NativeMethodInfoPtr_get_zxyx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665419);
			bool3.NativeMethodInfoPtr_get_zxyy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665420);
			bool3.NativeMethodInfoPtr_get_zxyz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665421);
			bool3.NativeMethodInfoPtr_get_zxzx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665422);
			bool3.NativeMethodInfoPtr_get_zxzy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665423);
			bool3.NativeMethodInfoPtr_get_zxzz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665424);
			bool3.NativeMethodInfoPtr_get_zyxx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665425);
			bool3.NativeMethodInfoPtr_get_zyxy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665426);
			bool3.NativeMethodInfoPtr_get_zyxz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665427);
			bool3.NativeMethodInfoPtr_get_zyyx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665428);
			bool3.NativeMethodInfoPtr_get_zyyy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665429);
			bool3.NativeMethodInfoPtr_get_zyyz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665430);
			bool3.NativeMethodInfoPtr_get_zyzx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665431);
			bool3.NativeMethodInfoPtr_get_zyzy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665432);
			bool3.NativeMethodInfoPtr_get_zyzz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665433);
			bool3.NativeMethodInfoPtr_get_zzxx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665434);
			bool3.NativeMethodInfoPtr_get_zzxy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665435);
			bool3.NativeMethodInfoPtr_get_zzxz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665436);
			bool3.NativeMethodInfoPtr_get_zzyx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665437);
			bool3.NativeMethodInfoPtr_get_zzyy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665438);
			bool3.NativeMethodInfoPtr_get_zzyz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665439);
			bool3.NativeMethodInfoPtr_get_zzzx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665440);
			bool3.NativeMethodInfoPtr_get_zzzy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665441);
			bool3.NativeMethodInfoPtr_get_zzzz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665442);
			bool3.NativeMethodInfoPtr_get_xxx_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665443);
			bool3.NativeMethodInfoPtr_get_xxy_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665444);
			bool3.NativeMethodInfoPtr_get_xxz_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665445);
			bool3.NativeMethodInfoPtr_get_xyx_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665446);
			bool3.NativeMethodInfoPtr_get_xyy_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665447);
			bool3.NativeMethodInfoPtr_get_xyz_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665448);
			bool3.NativeMethodInfoPtr_set_xyz_Public_set_Void_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665449);
			bool3.NativeMethodInfoPtr_get_xzx_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665450);
			bool3.NativeMethodInfoPtr_get_xzy_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665451);
			bool3.NativeMethodInfoPtr_set_xzy_Public_set_Void_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665452);
			bool3.NativeMethodInfoPtr_get_xzz_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665453);
			bool3.NativeMethodInfoPtr_get_yxx_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665454);
			bool3.NativeMethodInfoPtr_get_yxy_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665455);
			bool3.NativeMethodInfoPtr_get_yxz_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665456);
			bool3.NativeMethodInfoPtr_set_yxz_Public_set_Void_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665457);
			bool3.NativeMethodInfoPtr_get_yyx_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665458);
			bool3.NativeMethodInfoPtr_get_yyy_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665459);
			bool3.NativeMethodInfoPtr_get_yyz_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665460);
			bool3.NativeMethodInfoPtr_get_yzx_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665461);
			bool3.NativeMethodInfoPtr_set_yzx_Public_set_Void_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665462);
			bool3.NativeMethodInfoPtr_get_yzy_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665463);
			bool3.NativeMethodInfoPtr_get_yzz_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665464);
			bool3.NativeMethodInfoPtr_get_zxx_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665465);
			bool3.NativeMethodInfoPtr_get_zxy_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665466);
			bool3.NativeMethodInfoPtr_set_zxy_Public_set_Void_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665467);
			bool3.NativeMethodInfoPtr_get_zxz_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665468);
			bool3.NativeMethodInfoPtr_get_zyx_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665469);
			bool3.NativeMethodInfoPtr_set_zyx_Public_set_Void_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665470);
			bool3.NativeMethodInfoPtr_get_zyy_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665471);
			bool3.NativeMethodInfoPtr_get_zyz_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665472);
			bool3.NativeMethodInfoPtr_get_zzx_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665473);
			bool3.NativeMethodInfoPtr_get_zzy_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665474);
			bool3.NativeMethodInfoPtr_get_zzz_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665475);
			bool3.NativeMethodInfoPtr_get_xx_Public_get_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665476);
			bool3.NativeMethodInfoPtr_get_xy_Public_get_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665477);
			bool3.NativeMethodInfoPtr_set_xy_Public_set_Void_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665478);
			bool3.NativeMethodInfoPtr_get_xz_Public_get_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665479);
			bool3.NativeMethodInfoPtr_set_xz_Public_set_Void_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665480);
			bool3.NativeMethodInfoPtr_get_yx_Public_get_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665481);
			bool3.NativeMethodInfoPtr_set_yx_Public_set_Void_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665482);
			bool3.NativeMethodInfoPtr_get_yy_Public_get_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665483);
			bool3.NativeMethodInfoPtr_get_yz_Public_get_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665484);
			bool3.NativeMethodInfoPtr_set_yz_Public_set_Void_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665485);
			bool3.NativeMethodInfoPtr_get_zx_Public_get_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665486);
			bool3.NativeMethodInfoPtr_set_zx_Public_set_Void_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665487);
			bool3.NativeMethodInfoPtr_get_zy_Public_get_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665488);
			bool3.NativeMethodInfoPtr_set_zy_Public_set_Void_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665489);
			bool3.NativeMethodInfoPtr_get_zz_Public_get_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665490);
			bool3.NativeMethodInfoPtr_get_Item_Public_get_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665491);
			bool3.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665492);
			bool3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665493);
			bool3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665494);
			bool3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665495);
			bool3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3>.NativeClassPtr, 100665496);
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x00032F24 File Offset: 0x00031124
		[CallerCount(0)]
		public unsafe bool3(bool x, bool y, bool z)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x00032F74 File Offset: 0x00031174
		[CallerCount(0)]
		public unsafe bool3(bool x, bool2 yz)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yz;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_bool2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00032FB4 File Offset: 0x000311B4
		[CallerCount(0)]
		public unsafe bool3(bool2 xy, bool z)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xy;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr__ctor_Public_Void_bool2_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x00032FF4 File Offset: 0x000311F4
		[CallerCount(0)]
		public unsafe bool3(bool3 xyz)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyz;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr__ctor_Public_Void_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x00033028 File Offset: 0x00031228
		[CallerCount(0)]
		public unsafe bool3(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x0003305C File Offset: 0x0003125C
		[CallerCount(0)]
		public unsafe static implicit operator bool3(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_op_Implicit_Public_Static_bool3_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x0003309C File Offset: 0x0003129C
		[CallerCount(0)]
		public unsafe static bool3 operator ==(bool3 lhs, bool3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3_bool3_bool3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x000330E8 File Offset: 0x000312E8
		[CallerCount(0)]
		public unsafe static bool3 operator ==(bool3 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3_bool3_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x00033134 File Offset: 0x00031334
		[CallerCount(0)]
		public unsafe static bool3 operator ==(bool lhs, bool3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3_Boolean_bool3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x00033180 File Offset: 0x00031380
		[CallerCount(0)]
		public unsafe static bool3 operator !=(bool3 lhs, bool3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_bool3_bool3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x000331CC File Offset: 0x000313CC
		[CallerCount(0)]
		public unsafe static bool3 operator !=(bool3 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_bool3_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x00033218 File Offset: 0x00031418
		[CallerCount(0)]
		public unsafe static bool3 operator !=(bool lhs, bool3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_Boolean_bool3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00033264 File Offset: 0x00031464
		[CallerCount(0)]
		public unsafe static bool3 operator !(bool3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_op_LogicalNot_Public_Static_bool3_bool3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x000332A4 File Offset: 0x000314A4
		[CallerCount(0)]
		public unsafe static bool3 operator &(bool3 lhs, bool3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool3_bool3_bool3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x000332F0 File Offset: 0x000314F0
		[CallerCount(0)]
		public unsafe static bool3 operator &(bool3 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool3_bool3_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x0003333C File Offset: 0x0003153C
		[CallerCount(0)]
		public unsafe static bool3 operator &(bool lhs, bool3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool3_Boolean_bool3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x00033388 File Offset: 0x00031588
		[CallerCount(0)]
		public unsafe static bool3 operator |(bool3 lhs, bool3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool3_bool3_bool3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x000333D4 File Offset: 0x000315D4
		[CallerCount(0)]
		public unsafe static bool3 operator |(bool3 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool3_bool3_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x00033420 File Offset: 0x00031620
		[CallerCount(0)]
		public unsafe static bool3 operator |(bool lhs, bool3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool3_Boolean_bool3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x0003346C File Offset: 0x0003166C
		[CallerCount(0)]
		public unsafe static bool3 operator ^(bool3 lhs, bool3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool3_bool3_bool3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x000334B8 File Offset: 0x000316B8
		[CallerCount(0)]
		public unsafe static bool3 operator ^(bool3 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool3_bool3_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00033504 File Offset: 0x00031704
		[CallerCount(0)]
		public unsafe static bool3 operator ^(bool lhs, bool3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool3_Boolean_bool3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600084C RID: 2124 RVA: 0x00033550 File Offset: 0x00031750
		public unsafe bool4 xxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_xxxx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x00033580 File Offset: 0x00031780
		public unsafe bool4 xxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_xxxy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600084E RID: 2126 RVA: 0x000335B0 File Offset: 0x000317B0
		public unsafe bool4 xxxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_xxxz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600084F RID: 2127 RVA: 0x000335E0 File Offset: 0x000317E0
		public unsafe bool4 xxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_xxyx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000850 RID: 2128 RVA: 0x00033610 File Offset: 0x00031810
		public unsafe bool4 xxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_xxyy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000851 RID: 2129 RVA: 0x00033640 File Offset: 0x00031840
		public unsafe bool4 xxyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_xxyz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000852 RID: 2130 RVA: 0x00033670 File Offset: 0x00031870
		public unsafe bool4 xxzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_xxzx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000853 RID: 2131 RVA: 0x000336A0 File Offset: 0x000318A0
		public unsafe bool4 xxzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_xxzy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000854 RID: 2132 RVA: 0x000336D0 File Offset: 0x000318D0
		public unsafe bool4 xxzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_xxzz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000855 RID: 2133 RVA: 0x00033700 File Offset: 0x00031900
		public unsafe bool4 xyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_xyxx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000856 RID: 2134 RVA: 0x00033730 File Offset: 0x00031930
		public unsafe bool4 xyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_xyxy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x00033760 File Offset: 0x00031960
		public unsafe bool4 xyxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_xyxz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000858 RID: 2136 RVA: 0x00033790 File Offset: 0x00031990
		public unsafe bool4 xyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_xyyx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000859 RID: 2137 RVA: 0x000337C0 File Offset: 0x000319C0
		public unsafe bool4 xyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_xyyy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600085A RID: 2138 RVA: 0x000337F0 File Offset: 0x000319F0
		public unsafe bool4 xyyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_xyyz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600085B RID: 2139 RVA: 0x00033820 File Offset: 0x00031A20
		public unsafe bool4 xyzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_xyzx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600085C RID: 2140 RVA: 0x00033850 File Offset: 0x00031A50
		public unsafe bool4 xyzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_xyzy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600085D RID: 2141 RVA: 0x00033880 File Offset: 0x00031A80
		public unsafe bool4 xyzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_xyzz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600085E RID: 2142 RVA: 0x000338B0 File Offset: 0x00031AB0
		public unsafe bool4 xzxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_xzxx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600085F RID: 2143 RVA: 0x000338E0 File Offset: 0x00031AE0
		public unsafe bool4 xzxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_xzxy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000860 RID: 2144 RVA: 0x00033910 File Offset: 0x00031B10
		public unsafe bool4 xzxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_xzxz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000861 RID: 2145 RVA: 0x00033940 File Offset: 0x00031B40
		public unsafe bool4 xzyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_xzyx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000862 RID: 2146 RVA: 0x00033970 File Offset: 0x00031B70
		public unsafe bool4 xzyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_xzyy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000863 RID: 2147 RVA: 0x000339A0 File Offset: 0x00031BA0
		public unsafe bool4 xzyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_xzyz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000864 RID: 2148 RVA: 0x000339D0 File Offset: 0x00031BD0
		public unsafe bool4 xzzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_xzzx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000865 RID: 2149 RVA: 0x00033A00 File Offset: 0x00031C00
		public unsafe bool4 xzzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_xzzy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000866 RID: 2150 RVA: 0x00033A30 File Offset: 0x00031C30
		public unsafe bool4 xzzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_xzzz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000867 RID: 2151 RVA: 0x00033A60 File Offset: 0x00031C60
		public unsafe bool4 yxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_yxxx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000868 RID: 2152 RVA: 0x00033A90 File Offset: 0x00031C90
		public unsafe bool4 yxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_yxxy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000869 RID: 2153 RVA: 0x00033AC0 File Offset: 0x00031CC0
		public unsafe bool4 yxxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_yxxz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600086A RID: 2154 RVA: 0x00033AF0 File Offset: 0x00031CF0
		public unsafe bool4 yxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_yxyx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600086B RID: 2155 RVA: 0x00033B20 File Offset: 0x00031D20
		public unsafe bool4 yxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_yxyy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600086C RID: 2156 RVA: 0x00033B50 File Offset: 0x00031D50
		public unsafe bool4 yxyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_yxyz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600086D RID: 2157 RVA: 0x00033B80 File Offset: 0x00031D80
		public unsafe bool4 yxzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_yxzx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600086E RID: 2158 RVA: 0x00033BB0 File Offset: 0x00031DB0
		public unsafe bool4 yxzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_yxzy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600086F RID: 2159 RVA: 0x00033BE0 File Offset: 0x00031DE0
		public unsafe bool4 yxzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_yxzz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000870 RID: 2160 RVA: 0x00033C10 File Offset: 0x00031E10
		public unsafe bool4 yyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_yyxx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x00033C40 File Offset: 0x00031E40
		public unsafe bool4 yyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_yyxy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000872 RID: 2162 RVA: 0x00033C70 File Offset: 0x00031E70
		public unsafe bool4 yyxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_yyxz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000873 RID: 2163 RVA: 0x00033CA0 File Offset: 0x00031EA0
		public unsafe bool4 yyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_yyyx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000874 RID: 2164 RVA: 0x00033CD0 File Offset: 0x00031ED0
		public unsafe bool4 yyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_yyyy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x00033D00 File Offset: 0x00031F00
		public unsafe bool4 yyyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_yyyz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000876 RID: 2166 RVA: 0x00033D30 File Offset: 0x00031F30
		public unsafe bool4 yyzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_yyzx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x00033D60 File Offset: 0x00031F60
		public unsafe bool4 yyzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_yyzy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000878 RID: 2168 RVA: 0x00033D90 File Offset: 0x00031F90
		public unsafe bool4 yyzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_yyzz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000879 RID: 2169 RVA: 0x00033DC0 File Offset: 0x00031FC0
		public unsafe bool4 yzxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_yzxx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600087A RID: 2170 RVA: 0x00033DF0 File Offset: 0x00031FF0
		public unsafe bool4 yzxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_yzxy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600087B RID: 2171 RVA: 0x00033E20 File Offset: 0x00032020
		public unsafe bool4 yzxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_yzxz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600087C RID: 2172 RVA: 0x00033E50 File Offset: 0x00032050
		public unsafe bool4 yzyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_yzyx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600087D RID: 2173 RVA: 0x00033E80 File Offset: 0x00032080
		public unsafe bool4 yzyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_yzyy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600087E RID: 2174 RVA: 0x00033EB0 File Offset: 0x000320B0
		public unsafe bool4 yzyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_yzyz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600087F RID: 2175 RVA: 0x00033EE0 File Offset: 0x000320E0
		public unsafe bool4 yzzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_yzzx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000880 RID: 2176 RVA: 0x00033F10 File Offset: 0x00032110
		public unsafe bool4 yzzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_yzzy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000881 RID: 2177 RVA: 0x00033F40 File Offset: 0x00032140
		public unsafe bool4 yzzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_yzzz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000882 RID: 2178 RVA: 0x00033F70 File Offset: 0x00032170
		public unsafe bool4 zxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_zxxx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000883 RID: 2179 RVA: 0x00033FA0 File Offset: 0x000321A0
		public unsafe bool4 zxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_zxxy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000884 RID: 2180 RVA: 0x00033FD0 File Offset: 0x000321D0
		public unsafe bool4 zxxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_zxxz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000885 RID: 2181 RVA: 0x00034000 File Offset: 0x00032200
		public unsafe bool4 zxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_zxyx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000886 RID: 2182 RVA: 0x00034030 File Offset: 0x00032230
		public unsafe bool4 zxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_zxyy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000887 RID: 2183 RVA: 0x00034060 File Offset: 0x00032260
		public unsafe bool4 zxyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_zxyz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000888 RID: 2184 RVA: 0x00034090 File Offset: 0x00032290
		public unsafe bool4 zxzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_zxzx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000889 RID: 2185 RVA: 0x000340C0 File Offset: 0x000322C0
		public unsafe bool4 zxzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_zxzy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600088A RID: 2186 RVA: 0x000340F0 File Offset: 0x000322F0
		public unsafe bool4 zxzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_zxzz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600088B RID: 2187 RVA: 0x00034120 File Offset: 0x00032320
		public unsafe bool4 zyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_zyxx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600088C RID: 2188 RVA: 0x00034150 File Offset: 0x00032350
		public unsafe bool4 zyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_zyxy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600088D RID: 2189 RVA: 0x00034180 File Offset: 0x00032380
		public unsafe bool4 zyxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_zyxz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600088E RID: 2190 RVA: 0x000341B0 File Offset: 0x000323B0
		public unsafe bool4 zyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_zyyx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600088F RID: 2191 RVA: 0x000341E0 File Offset: 0x000323E0
		public unsafe bool4 zyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_zyyy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000890 RID: 2192 RVA: 0x00034210 File Offset: 0x00032410
		public unsafe bool4 zyyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_zyyz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000891 RID: 2193 RVA: 0x00034240 File Offset: 0x00032440
		public unsafe bool4 zyzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_zyzx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000892 RID: 2194 RVA: 0x00034270 File Offset: 0x00032470
		public unsafe bool4 zyzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_zyzy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000893 RID: 2195 RVA: 0x000342A0 File Offset: 0x000324A0
		public unsafe bool4 zyzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_zyzz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000894 RID: 2196 RVA: 0x000342D0 File Offset: 0x000324D0
		public unsafe bool4 zzxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_zzxx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000895 RID: 2197 RVA: 0x00034300 File Offset: 0x00032500
		public unsafe bool4 zzxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_zzxy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000896 RID: 2198 RVA: 0x00034330 File Offset: 0x00032530
		public unsafe bool4 zzxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_zzxz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000897 RID: 2199 RVA: 0x00034360 File Offset: 0x00032560
		public unsafe bool4 zzyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_zzyx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000898 RID: 2200 RVA: 0x00034390 File Offset: 0x00032590
		public unsafe bool4 zzyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_zzyy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000899 RID: 2201 RVA: 0x000343C0 File Offset: 0x000325C0
		public unsafe bool4 zzyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_zzyz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600089A RID: 2202 RVA: 0x000343F0 File Offset: 0x000325F0
		public unsafe bool4 zzzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_zzzx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600089B RID: 2203 RVA: 0x00034420 File Offset: 0x00032620
		public unsafe bool4 zzzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_zzzy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600089C RID: 2204 RVA: 0x00034450 File Offset: 0x00032650
		public unsafe bool4 zzzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_zzzz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600089D RID: 2205 RVA: 0x00034480 File Offset: 0x00032680
		public unsafe bool3 xxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_xxx_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600089E RID: 2206 RVA: 0x000344B0 File Offset: 0x000326B0
		public unsafe bool3 xxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_xxy_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600089F RID: 2207 RVA: 0x000344E0 File Offset: 0x000326E0
		public unsafe bool3 xxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_xxz_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060008A0 RID: 2208 RVA: 0x00034510 File Offset: 0x00032710
		public unsafe bool3 xyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_xyx_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060008A1 RID: 2209 RVA: 0x00034540 File Offset: 0x00032740
		public unsafe bool3 xyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_xyy_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060008A2 RID: 2210 RVA: 0x00034570 File Offset: 0x00032770
		// (set) Token: 0x060008A3 RID: 2211 RVA: 0x000345A0 File Offset: 0x000327A0
		public unsafe bool3 xyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_xyz_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_set_xyz_Public_set_Void_bool3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060008A4 RID: 2212 RVA: 0x000345D4 File Offset: 0x000327D4
		public unsafe bool3 xzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_xzx_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060008A5 RID: 2213 RVA: 0x00034604 File Offset: 0x00032804
		// (set) Token: 0x060008A6 RID: 2214 RVA: 0x00034634 File Offset: 0x00032834
		public unsafe bool3 xzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_xzy_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_set_xzy_Public_set_Void_bool3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060008A7 RID: 2215 RVA: 0x00034668 File Offset: 0x00032868
		public unsafe bool3 xzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_xzz_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060008A8 RID: 2216 RVA: 0x00034698 File Offset: 0x00032898
		public unsafe bool3 yxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_yxx_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060008A9 RID: 2217 RVA: 0x000346C8 File Offset: 0x000328C8
		public unsafe bool3 yxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_yxy_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060008AA RID: 2218 RVA: 0x000346F8 File Offset: 0x000328F8
		// (set) Token: 0x060008AB RID: 2219 RVA: 0x00034728 File Offset: 0x00032928
		public unsafe bool3 yxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_yxz_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_set_yxz_Public_set_Void_bool3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060008AC RID: 2220 RVA: 0x0003475C File Offset: 0x0003295C
		public unsafe bool3 yyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_yyx_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060008AD RID: 2221 RVA: 0x0003478C File Offset: 0x0003298C
		public unsafe bool3 yyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_yyy_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060008AE RID: 2222 RVA: 0x000347BC File Offset: 0x000329BC
		public unsafe bool3 yyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_yyz_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060008AF RID: 2223 RVA: 0x000347EC File Offset: 0x000329EC
		// (set) Token: 0x060008B0 RID: 2224 RVA: 0x0003481C File Offset: 0x00032A1C
		public unsafe bool3 yzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_yzx_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_set_yzx_Public_set_Void_bool3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060008B1 RID: 2225 RVA: 0x00034850 File Offset: 0x00032A50
		public unsafe bool3 yzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_yzy_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060008B2 RID: 2226 RVA: 0x00034880 File Offset: 0x00032A80
		public unsafe bool3 yzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_yzz_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060008B3 RID: 2227 RVA: 0x000348B0 File Offset: 0x00032AB0
		public unsafe bool3 zxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_zxx_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060008B4 RID: 2228 RVA: 0x000348E0 File Offset: 0x00032AE0
		// (set) Token: 0x060008B5 RID: 2229 RVA: 0x00034910 File Offset: 0x00032B10
		public unsafe bool3 zxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_zxy_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_set_zxy_Public_set_Void_bool3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060008B6 RID: 2230 RVA: 0x00034944 File Offset: 0x00032B44
		public unsafe bool3 zxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_zxz_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060008B7 RID: 2231 RVA: 0x00034974 File Offset: 0x00032B74
		// (set) Token: 0x060008B8 RID: 2232 RVA: 0x000349A4 File Offset: 0x00032BA4
		public unsafe bool3 zyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_zyx_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_set_zyx_Public_set_Void_bool3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060008B9 RID: 2233 RVA: 0x000349D8 File Offset: 0x00032BD8
		public unsafe bool3 zyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_zyy_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060008BA RID: 2234 RVA: 0x00034A08 File Offset: 0x00032C08
		public unsafe bool3 zyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_zyz_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060008BB RID: 2235 RVA: 0x00034A38 File Offset: 0x00032C38
		public unsafe bool3 zzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_zzx_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060008BC RID: 2236 RVA: 0x00034A68 File Offset: 0x00032C68
		public unsafe bool3 zzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_zzy_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060008BD RID: 2237 RVA: 0x00034A98 File Offset: 0x00032C98
		public unsafe bool3 zzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_zzz_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060008BE RID: 2238 RVA: 0x00034AC8 File Offset: 0x00032CC8
		public unsafe bool2 xx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_xx_Public_get_bool2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060008BF RID: 2239 RVA: 0x00034AF8 File Offset: 0x00032CF8
		// (set) Token: 0x060008C0 RID: 2240 RVA: 0x00034B28 File Offset: 0x00032D28
		public unsafe bool2 xy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_xy_Public_get_bool2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_set_xy_Public_set_Void_bool2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060008C1 RID: 2241 RVA: 0x00034B5C File Offset: 0x00032D5C
		// (set) Token: 0x060008C2 RID: 2242 RVA: 0x00034B8C File Offset: 0x00032D8C
		public unsafe bool2 xz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_xz_Public_get_bool2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_set_xz_Public_set_Void_bool2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060008C3 RID: 2243 RVA: 0x00034BC0 File Offset: 0x00032DC0
		// (set) Token: 0x060008C4 RID: 2244 RVA: 0x00034BF0 File Offset: 0x00032DF0
		public unsafe bool2 yx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_yx_Public_get_bool2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_set_yx_Public_set_Void_bool2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060008C5 RID: 2245 RVA: 0x00034C24 File Offset: 0x00032E24
		public unsafe bool2 yy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_yy_Public_get_bool2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060008C6 RID: 2246 RVA: 0x00034C54 File Offset: 0x00032E54
		// (set) Token: 0x060008C7 RID: 2247 RVA: 0x00034C84 File Offset: 0x00032E84
		public unsafe bool2 yz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_yz_Public_get_bool2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_set_yz_Public_set_Void_bool2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060008C8 RID: 2248 RVA: 0x00034CB8 File Offset: 0x00032EB8
		// (set) Token: 0x060008C9 RID: 2249 RVA: 0x00034CE8 File Offset: 0x00032EE8
		public unsafe bool2 zx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_zx_Public_get_bool2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_set_zx_Public_set_Void_bool2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x00034D1C File Offset: 0x00032F1C
		// (set) Token: 0x060008CB RID: 2251 RVA: 0x00034D4C File Offset: 0x00032F4C
		public unsafe bool2 zy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_zy_Public_get_bool2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_set_zy_Public_set_Void_bool2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060008CC RID: 2252 RVA: 0x00034D80 File Offset: 0x00032F80
		public unsafe bool2 zz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_zz_Public_get_bool2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000AC RID: 172
		public unsafe bool this[int index]
		{
			[CallerCount(0)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_get_Item_Public_get_Boolean_Int32_0, ref this, (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x00034E30 File Offset: 0x00033030
		[CallerCount(0)]
		public unsafe bool Equals(bool3 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x00034E70 File Offset: 0x00033070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634415, XrefRangeEnd = 634418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x00034EB4 File Offset: 0x000330B4
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00034EE4 File Offset: 0x000330E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634418, XrefRangeEnd = 634428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x00002220 File Offset: 0x00000420
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<bool3>.NativeClassPtr, ref this));
		}

		// Token: 0x04000827 RID: 2087
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x04000828 RID: 2088
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04000829 RID: 2089
		private static readonly IntPtr NativeFieldInfoPtr_z;

		// Token: 0x0400082A RID: 2090
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_0;

		// Token: 0x0400082B RID: 2091
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_bool2_0;

		// Token: 0x0400082C RID: 2092
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool2_Boolean_0;

		// Token: 0x0400082D RID: 2093
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool3_0;

		// Token: 0x0400082E RID: 2094
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x0400082F RID: 2095
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_bool3_Boolean_0;

		// Token: 0x04000830 RID: 2096
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3_bool3_bool3_0;

		// Token: 0x04000831 RID: 2097
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3_bool3_Boolean_0;

		// Token: 0x04000832 RID: 2098
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3_Boolean_bool3_0;

		// Token: 0x04000833 RID: 2099
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_bool3_bool3_0;

		// Token: 0x04000834 RID: 2100
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_bool3_Boolean_0;

		// Token: 0x04000835 RID: 2101
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_Boolean_bool3_0;

		// Token: 0x04000836 RID: 2102
		private static readonly IntPtr NativeMethodInfoPtr_op_LogicalNot_Public_Static_bool3_bool3_0;

		// Token: 0x04000837 RID: 2103
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool3_bool3_bool3_0;

		// Token: 0x04000838 RID: 2104
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool3_bool3_Boolean_0;

		// Token: 0x04000839 RID: 2105
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool3_Boolean_bool3_0;

		// Token: 0x0400083A RID: 2106
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool3_bool3_bool3_0;

		// Token: 0x0400083B RID: 2107
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool3_bool3_Boolean_0;

		// Token: 0x0400083C RID: 2108
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool3_Boolean_bool3_0;

		// Token: 0x0400083D RID: 2109
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool3_bool3_bool3_0;

		// Token: 0x0400083E RID: 2110
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool3_bool3_Boolean_0;

		// Token: 0x0400083F RID: 2111
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool3_Boolean_bool3_0;

		// Token: 0x04000840 RID: 2112
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxx_Public_get_bool4_0;

		// Token: 0x04000841 RID: 2113
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxy_Public_get_bool4_0;

		// Token: 0x04000842 RID: 2114
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxz_Public_get_bool4_0;

		// Token: 0x04000843 RID: 2115
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyx_Public_get_bool4_0;

		// Token: 0x04000844 RID: 2116
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyy_Public_get_bool4_0;

		// Token: 0x04000845 RID: 2117
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyz_Public_get_bool4_0;

		// Token: 0x04000846 RID: 2118
		private static readonly IntPtr NativeMethodInfoPtr_get_xxzx_Public_get_bool4_0;

		// Token: 0x04000847 RID: 2119
		private static readonly IntPtr NativeMethodInfoPtr_get_xxzy_Public_get_bool4_0;

		// Token: 0x04000848 RID: 2120
		private static readonly IntPtr NativeMethodInfoPtr_get_xxzz_Public_get_bool4_0;

		// Token: 0x04000849 RID: 2121
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxx_Public_get_bool4_0;

		// Token: 0x0400084A RID: 2122
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxy_Public_get_bool4_0;

		// Token: 0x0400084B RID: 2123
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxz_Public_get_bool4_0;

		// Token: 0x0400084C RID: 2124
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyx_Public_get_bool4_0;

		// Token: 0x0400084D RID: 2125
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyy_Public_get_bool4_0;

		// Token: 0x0400084E RID: 2126
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyz_Public_get_bool4_0;

		// Token: 0x0400084F RID: 2127
		private static readonly IntPtr NativeMethodInfoPtr_get_xyzx_Public_get_bool4_0;

		// Token: 0x04000850 RID: 2128
		private static readonly IntPtr NativeMethodInfoPtr_get_xyzy_Public_get_bool4_0;

		// Token: 0x04000851 RID: 2129
		private static readonly IntPtr NativeMethodInfoPtr_get_xyzz_Public_get_bool4_0;

		// Token: 0x04000852 RID: 2130
		private static readonly IntPtr NativeMethodInfoPtr_get_xzxx_Public_get_bool4_0;

		// Token: 0x04000853 RID: 2131
		private static readonly IntPtr NativeMethodInfoPtr_get_xzxy_Public_get_bool4_0;

		// Token: 0x04000854 RID: 2132
		private static readonly IntPtr NativeMethodInfoPtr_get_xzxz_Public_get_bool4_0;

		// Token: 0x04000855 RID: 2133
		private static readonly IntPtr NativeMethodInfoPtr_get_xzyx_Public_get_bool4_0;

		// Token: 0x04000856 RID: 2134
		private static readonly IntPtr NativeMethodInfoPtr_get_xzyy_Public_get_bool4_0;

		// Token: 0x04000857 RID: 2135
		private static readonly IntPtr NativeMethodInfoPtr_get_xzyz_Public_get_bool4_0;

		// Token: 0x04000858 RID: 2136
		private static readonly IntPtr NativeMethodInfoPtr_get_xzzx_Public_get_bool4_0;

		// Token: 0x04000859 RID: 2137
		private static readonly IntPtr NativeMethodInfoPtr_get_xzzy_Public_get_bool4_0;

		// Token: 0x0400085A RID: 2138
		private static readonly IntPtr NativeMethodInfoPtr_get_xzzz_Public_get_bool4_0;

		// Token: 0x0400085B RID: 2139
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxx_Public_get_bool4_0;

		// Token: 0x0400085C RID: 2140
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxy_Public_get_bool4_0;

		// Token: 0x0400085D RID: 2141
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxz_Public_get_bool4_0;

		// Token: 0x0400085E RID: 2142
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyx_Public_get_bool4_0;

		// Token: 0x0400085F RID: 2143
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyy_Public_get_bool4_0;

		// Token: 0x04000860 RID: 2144
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyz_Public_get_bool4_0;

		// Token: 0x04000861 RID: 2145
		private static readonly IntPtr NativeMethodInfoPtr_get_yxzx_Public_get_bool4_0;

		// Token: 0x04000862 RID: 2146
		private static readonly IntPtr NativeMethodInfoPtr_get_yxzy_Public_get_bool4_0;

		// Token: 0x04000863 RID: 2147
		private static readonly IntPtr NativeMethodInfoPtr_get_yxzz_Public_get_bool4_0;

		// Token: 0x04000864 RID: 2148
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxx_Public_get_bool4_0;

		// Token: 0x04000865 RID: 2149
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxy_Public_get_bool4_0;

		// Token: 0x04000866 RID: 2150
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxz_Public_get_bool4_0;

		// Token: 0x04000867 RID: 2151
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyx_Public_get_bool4_0;

		// Token: 0x04000868 RID: 2152
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyy_Public_get_bool4_0;

		// Token: 0x04000869 RID: 2153
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyz_Public_get_bool4_0;

		// Token: 0x0400086A RID: 2154
		private static readonly IntPtr NativeMethodInfoPtr_get_yyzx_Public_get_bool4_0;

		// Token: 0x0400086B RID: 2155
		private static readonly IntPtr NativeMethodInfoPtr_get_yyzy_Public_get_bool4_0;

		// Token: 0x0400086C RID: 2156
		private static readonly IntPtr NativeMethodInfoPtr_get_yyzz_Public_get_bool4_0;

		// Token: 0x0400086D RID: 2157
		private static readonly IntPtr NativeMethodInfoPtr_get_yzxx_Public_get_bool4_0;

		// Token: 0x0400086E RID: 2158
		private static readonly IntPtr NativeMethodInfoPtr_get_yzxy_Public_get_bool4_0;

		// Token: 0x0400086F RID: 2159
		private static readonly IntPtr NativeMethodInfoPtr_get_yzxz_Public_get_bool4_0;

		// Token: 0x04000870 RID: 2160
		private static readonly IntPtr NativeMethodInfoPtr_get_yzyx_Public_get_bool4_0;

		// Token: 0x04000871 RID: 2161
		private static readonly IntPtr NativeMethodInfoPtr_get_yzyy_Public_get_bool4_0;

		// Token: 0x04000872 RID: 2162
		private static readonly IntPtr NativeMethodInfoPtr_get_yzyz_Public_get_bool4_0;

		// Token: 0x04000873 RID: 2163
		private static readonly IntPtr NativeMethodInfoPtr_get_yzzx_Public_get_bool4_0;

		// Token: 0x04000874 RID: 2164
		private static readonly IntPtr NativeMethodInfoPtr_get_yzzy_Public_get_bool4_0;

		// Token: 0x04000875 RID: 2165
		private static readonly IntPtr NativeMethodInfoPtr_get_yzzz_Public_get_bool4_0;

		// Token: 0x04000876 RID: 2166
		private static readonly IntPtr NativeMethodInfoPtr_get_zxxx_Public_get_bool4_0;

		// Token: 0x04000877 RID: 2167
		private static readonly IntPtr NativeMethodInfoPtr_get_zxxy_Public_get_bool4_0;

		// Token: 0x04000878 RID: 2168
		private static readonly IntPtr NativeMethodInfoPtr_get_zxxz_Public_get_bool4_0;

		// Token: 0x04000879 RID: 2169
		private static readonly IntPtr NativeMethodInfoPtr_get_zxyx_Public_get_bool4_0;

		// Token: 0x0400087A RID: 2170
		private static readonly IntPtr NativeMethodInfoPtr_get_zxyy_Public_get_bool4_0;

		// Token: 0x0400087B RID: 2171
		private static readonly IntPtr NativeMethodInfoPtr_get_zxyz_Public_get_bool4_0;

		// Token: 0x0400087C RID: 2172
		private static readonly IntPtr NativeMethodInfoPtr_get_zxzx_Public_get_bool4_0;

		// Token: 0x0400087D RID: 2173
		private static readonly IntPtr NativeMethodInfoPtr_get_zxzy_Public_get_bool4_0;

		// Token: 0x0400087E RID: 2174
		private static readonly IntPtr NativeMethodInfoPtr_get_zxzz_Public_get_bool4_0;

		// Token: 0x0400087F RID: 2175
		private static readonly IntPtr NativeMethodInfoPtr_get_zyxx_Public_get_bool4_0;

		// Token: 0x04000880 RID: 2176
		private static readonly IntPtr NativeMethodInfoPtr_get_zyxy_Public_get_bool4_0;

		// Token: 0x04000881 RID: 2177
		private static readonly IntPtr NativeMethodInfoPtr_get_zyxz_Public_get_bool4_0;

		// Token: 0x04000882 RID: 2178
		private static readonly IntPtr NativeMethodInfoPtr_get_zyyx_Public_get_bool4_0;

		// Token: 0x04000883 RID: 2179
		private static readonly IntPtr NativeMethodInfoPtr_get_zyyy_Public_get_bool4_0;

		// Token: 0x04000884 RID: 2180
		private static readonly IntPtr NativeMethodInfoPtr_get_zyyz_Public_get_bool4_0;

		// Token: 0x04000885 RID: 2181
		private static readonly IntPtr NativeMethodInfoPtr_get_zyzx_Public_get_bool4_0;

		// Token: 0x04000886 RID: 2182
		private static readonly IntPtr NativeMethodInfoPtr_get_zyzy_Public_get_bool4_0;

		// Token: 0x04000887 RID: 2183
		private static readonly IntPtr NativeMethodInfoPtr_get_zyzz_Public_get_bool4_0;

		// Token: 0x04000888 RID: 2184
		private static readonly IntPtr NativeMethodInfoPtr_get_zzxx_Public_get_bool4_0;

		// Token: 0x04000889 RID: 2185
		private static readonly IntPtr NativeMethodInfoPtr_get_zzxy_Public_get_bool4_0;

		// Token: 0x0400088A RID: 2186
		private static readonly IntPtr NativeMethodInfoPtr_get_zzxz_Public_get_bool4_0;

		// Token: 0x0400088B RID: 2187
		private static readonly IntPtr NativeMethodInfoPtr_get_zzyx_Public_get_bool4_0;

		// Token: 0x0400088C RID: 2188
		private static readonly IntPtr NativeMethodInfoPtr_get_zzyy_Public_get_bool4_0;

		// Token: 0x0400088D RID: 2189
		private static readonly IntPtr NativeMethodInfoPtr_get_zzyz_Public_get_bool4_0;

		// Token: 0x0400088E RID: 2190
		private static readonly IntPtr NativeMethodInfoPtr_get_zzzx_Public_get_bool4_0;

		// Token: 0x0400088F RID: 2191
		private static readonly IntPtr NativeMethodInfoPtr_get_zzzy_Public_get_bool4_0;

		// Token: 0x04000890 RID: 2192
		private static readonly IntPtr NativeMethodInfoPtr_get_zzzz_Public_get_bool4_0;

		// Token: 0x04000891 RID: 2193
		private static readonly IntPtr NativeMethodInfoPtr_get_xxx_Public_get_bool3_0;

		// Token: 0x04000892 RID: 2194
		private static readonly IntPtr NativeMethodInfoPtr_get_xxy_Public_get_bool3_0;

		// Token: 0x04000893 RID: 2195
		private static readonly IntPtr NativeMethodInfoPtr_get_xxz_Public_get_bool3_0;

		// Token: 0x04000894 RID: 2196
		private static readonly IntPtr NativeMethodInfoPtr_get_xyx_Public_get_bool3_0;

		// Token: 0x04000895 RID: 2197
		private static readonly IntPtr NativeMethodInfoPtr_get_xyy_Public_get_bool3_0;

		// Token: 0x04000896 RID: 2198
		private static readonly IntPtr NativeMethodInfoPtr_get_xyz_Public_get_bool3_0;

		// Token: 0x04000897 RID: 2199
		private static readonly IntPtr NativeMethodInfoPtr_set_xyz_Public_set_Void_bool3_0;

		// Token: 0x04000898 RID: 2200
		private static readonly IntPtr NativeMethodInfoPtr_get_xzx_Public_get_bool3_0;

		// Token: 0x04000899 RID: 2201
		private static readonly IntPtr NativeMethodInfoPtr_get_xzy_Public_get_bool3_0;

		// Token: 0x0400089A RID: 2202
		private static readonly IntPtr NativeMethodInfoPtr_set_xzy_Public_set_Void_bool3_0;

		// Token: 0x0400089B RID: 2203
		private static readonly IntPtr NativeMethodInfoPtr_get_xzz_Public_get_bool3_0;

		// Token: 0x0400089C RID: 2204
		private static readonly IntPtr NativeMethodInfoPtr_get_yxx_Public_get_bool3_0;

		// Token: 0x0400089D RID: 2205
		private static readonly IntPtr NativeMethodInfoPtr_get_yxy_Public_get_bool3_0;

		// Token: 0x0400089E RID: 2206
		private static readonly IntPtr NativeMethodInfoPtr_get_yxz_Public_get_bool3_0;

		// Token: 0x0400089F RID: 2207
		private static readonly IntPtr NativeMethodInfoPtr_set_yxz_Public_set_Void_bool3_0;

		// Token: 0x040008A0 RID: 2208
		private static readonly IntPtr NativeMethodInfoPtr_get_yyx_Public_get_bool3_0;

		// Token: 0x040008A1 RID: 2209
		private static readonly IntPtr NativeMethodInfoPtr_get_yyy_Public_get_bool3_0;

		// Token: 0x040008A2 RID: 2210
		private static readonly IntPtr NativeMethodInfoPtr_get_yyz_Public_get_bool3_0;

		// Token: 0x040008A3 RID: 2211
		private static readonly IntPtr NativeMethodInfoPtr_get_yzx_Public_get_bool3_0;

		// Token: 0x040008A4 RID: 2212
		private static readonly IntPtr NativeMethodInfoPtr_set_yzx_Public_set_Void_bool3_0;

		// Token: 0x040008A5 RID: 2213
		private static readonly IntPtr NativeMethodInfoPtr_get_yzy_Public_get_bool3_0;

		// Token: 0x040008A6 RID: 2214
		private static readonly IntPtr NativeMethodInfoPtr_get_yzz_Public_get_bool3_0;

		// Token: 0x040008A7 RID: 2215
		private static readonly IntPtr NativeMethodInfoPtr_get_zxx_Public_get_bool3_0;

		// Token: 0x040008A8 RID: 2216
		private static readonly IntPtr NativeMethodInfoPtr_get_zxy_Public_get_bool3_0;

		// Token: 0x040008A9 RID: 2217
		private static readonly IntPtr NativeMethodInfoPtr_set_zxy_Public_set_Void_bool3_0;

		// Token: 0x040008AA RID: 2218
		private static readonly IntPtr NativeMethodInfoPtr_get_zxz_Public_get_bool3_0;

		// Token: 0x040008AB RID: 2219
		private static readonly IntPtr NativeMethodInfoPtr_get_zyx_Public_get_bool3_0;

		// Token: 0x040008AC RID: 2220
		private static readonly IntPtr NativeMethodInfoPtr_set_zyx_Public_set_Void_bool3_0;

		// Token: 0x040008AD RID: 2221
		private static readonly IntPtr NativeMethodInfoPtr_get_zyy_Public_get_bool3_0;

		// Token: 0x040008AE RID: 2222
		private static readonly IntPtr NativeMethodInfoPtr_get_zyz_Public_get_bool3_0;

		// Token: 0x040008AF RID: 2223
		private static readonly IntPtr NativeMethodInfoPtr_get_zzx_Public_get_bool3_0;

		// Token: 0x040008B0 RID: 2224
		private static readonly IntPtr NativeMethodInfoPtr_get_zzy_Public_get_bool3_0;

		// Token: 0x040008B1 RID: 2225
		private static readonly IntPtr NativeMethodInfoPtr_get_zzz_Public_get_bool3_0;

		// Token: 0x040008B2 RID: 2226
		private static readonly IntPtr NativeMethodInfoPtr_get_xx_Public_get_bool2_0;

		// Token: 0x040008B3 RID: 2227
		private static readonly IntPtr NativeMethodInfoPtr_get_xy_Public_get_bool2_0;

		// Token: 0x040008B4 RID: 2228
		private static readonly IntPtr NativeMethodInfoPtr_set_xy_Public_set_Void_bool2_0;

		// Token: 0x040008B5 RID: 2229
		private static readonly IntPtr NativeMethodInfoPtr_get_xz_Public_get_bool2_0;

		// Token: 0x040008B6 RID: 2230
		private static readonly IntPtr NativeMethodInfoPtr_set_xz_Public_set_Void_bool2_0;

		// Token: 0x040008B7 RID: 2231
		private static readonly IntPtr NativeMethodInfoPtr_get_yx_Public_get_bool2_0;

		// Token: 0x040008B8 RID: 2232
		private static readonly IntPtr NativeMethodInfoPtr_set_yx_Public_set_Void_bool2_0;

		// Token: 0x040008B9 RID: 2233
		private static readonly IntPtr NativeMethodInfoPtr_get_yy_Public_get_bool2_0;

		// Token: 0x040008BA RID: 2234
		private static readonly IntPtr NativeMethodInfoPtr_get_yz_Public_get_bool2_0;

		// Token: 0x040008BB RID: 2235
		private static readonly IntPtr NativeMethodInfoPtr_set_yz_Public_set_Void_bool2_0;

		// Token: 0x040008BC RID: 2236
		private static readonly IntPtr NativeMethodInfoPtr_get_zx_Public_get_bool2_0;

		// Token: 0x040008BD RID: 2237
		private static readonly IntPtr NativeMethodInfoPtr_set_zx_Public_set_Void_bool2_0;

		// Token: 0x040008BE RID: 2238
		private static readonly IntPtr NativeMethodInfoPtr_get_zy_Public_get_bool2_0;

		// Token: 0x040008BF RID: 2239
		private static readonly IntPtr NativeMethodInfoPtr_set_zy_Public_set_Void_bool2_0;

		// Token: 0x040008C0 RID: 2240
		private static readonly IntPtr NativeMethodInfoPtr_get_zz_Public_get_bool2_0;

		// Token: 0x040008C1 RID: 2241
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Boolean_Int32_0;

		// Token: 0x040008C2 RID: 2242
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Boolean_0;

		// Token: 0x040008C3 RID: 2243
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_bool3_0;

		// Token: 0x040008C4 RID: 2244
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040008C5 RID: 2245
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040008C6 RID: 2246
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040008C7 RID: 2247
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool x;

		// Token: 0x040008C8 RID: 2248
		[FieldOffset(1)]
		[MarshalAs(4)]
		public bool y;

		// Token: 0x040008C9 RID: 2249
		[FieldOffset(2)]
		[MarshalAs(4)]
		public bool z;

		// Token: 0x02000055 RID: 85
		public sealed class DebuggerProxy : Object
		{
			// Token: 0x060025C0 RID: 9664 RVA: 0x000C2E5C File Offset: 0x000C105C
			// Note: this type is marked as 'beforefieldinit'.
			static DebuggerProxy()
			{
				Il2CppClassPointerStore<bool3.DebuggerProxy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<bool3>.NativeClassPtr, "DebuggerProxy");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<bool3.DebuggerProxy>.NativeClassPtr);
				bool3.DebuggerProxy.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bool3.DebuggerProxy>.NativeClassPtr, "x");
				bool3.DebuggerProxy.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bool3.DebuggerProxy>.NativeClassPtr, "y");
				bool3.DebuggerProxy.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bool3.DebuggerProxy>.NativeClassPtr, "z");
				bool3.DebuggerProxy.NativeMethodInfoPtr__ctor_Public_Void_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool3.DebuggerProxy>.NativeClassPtr, 100665497);
			}

			// Token: 0x060025C1 RID: 9665 RVA: 0x000C2ED8 File Offset: 0x000C10D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634414, XrefRangeEnd = 634415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DebuggerProxy(bool3 v)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<bool3.DebuggerProxy>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool3.DebuggerProxy.NativeMethodInfoPtr__ctor_Public_Void_bool3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060025C2 RID: 9666 RVA: 0x00002C16 File Offset: 0x00000E16
			public DebuggerProxy(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BF3 RID: 3059
			// (get) Token: 0x060025C3 RID: 9667 RVA: 0x000C2F20 File Offset: 0x000C1120
			// (set) Token: 0x060025C4 RID: 9668 RVA: 0x00002C1F File Offset: 0x00000E1F
			public unsafe bool x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bool3.DebuggerProxy.NativeFieldInfoPtr_x);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bool3.DebuggerProxy.NativeFieldInfoPtr_x)) = value;
				}
			}

			// Token: 0x17000BF4 RID: 3060
			// (get) Token: 0x060025C5 RID: 9669 RVA: 0x000C2F48 File Offset: 0x000C1148
			// (set) Token: 0x060025C6 RID: 9670 RVA: 0x00002C3A File Offset: 0x00000E3A
			public unsafe bool y
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bool3.DebuggerProxy.NativeFieldInfoPtr_y);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bool3.DebuggerProxy.NativeFieldInfoPtr_y)) = value;
				}
			}

			// Token: 0x17000BF5 RID: 3061
			// (get) Token: 0x060025C7 RID: 9671 RVA: 0x000C2F70 File Offset: 0x000C1170
			// (set) Token: 0x060025C8 RID: 9672 RVA: 0x00002C55 File Offset: 0x00000E55
			public unsafe bool z
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bool3.DebuggerProxy.NativeFieldInfoPtr_z);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bool3.DebuggerProxy.NativeFieldInfoPtr_z)) = value;
				}
			}

			// Token: 0x0400265F RID: 9823
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04002660 RID: 9824
			private static readonly IntPtr NativeFieldInfoPtr_y;

			// Token: 0x04002661 RID: 9825
			private static readonly IntPtr NativeFieldInfoPtr_z;

			// Token: 0x04002662 RID: 9826
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool3_0;
		}
	}
}
