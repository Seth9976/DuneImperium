using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x0200000D RID: 13
	[Serializable]
	[StructLayout(2)]
	public struct bool4
	{
		// Token: 0x06000925 RID: 2341 RVA: 0x00036BBC File Offset: 0x00034DBC
		// Note: this type is marked as 'beforefieldinit'.
		static bool4()
		{
			Il2CppClassPointerStore<bool4>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "bool4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<bool4>.NativeClassPtr);
			bool4.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bool4>.NativeClassPtr, "x");
			bool4.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bool4>.NativeClassPtr, "y");
			bool4.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bool4>.NativeClassPtr, "z");
			bool4.NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bool4>.NativeClassPtr, "w");
			bool4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665573);
			bool4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665574);
			bool4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_bool2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665575);
			bool4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665576);
			bool4.NativeMethodInfoPtr__ctor_Public_Void_bool2_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665577);
			bool4.NativeMethodInfoPtr__ctor_Public_Void_bool2_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665578);
			bool4.NativeMethodInfoPtr__ctor_Public_Void_bool3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665579);
			bool4.NativeMethodInfoPtr__ctor_Public_Void_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665580);
			bool4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665581);
			bool4.NativeMethodInfoPtr_op_Implicit_Public_Static_bool4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665582);
			bool4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4_bool4_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665583);
			bool4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4_bool4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665584);
			bool4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4_Boolean_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665585);
			bool4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_bool4_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665586);
			bool4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_bool4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665587);
			bool4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_Boolean_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665588);
			bool4.NativeMethodInfoPtr_op_LogicalNot_Public_Static_bool4_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665589);
			bool4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool4_bool4_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665590);
			bool4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool4_bool4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665591);
			bool4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool4_Boolean_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665592);
			bool4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool4_bool4_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665593);
			bool4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool4_bool4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665594);
			bool4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool4_Boolean_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665595);
			bool4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool4_bool4_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665596);
			bool4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool4_bool4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665597);
			bool4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool4_Boolean_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665598);
			bool4.NativeMethodInfoPtr_get_xxxx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665599);
			bool4.NativeMethodInfoPtr_get_xxxy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665600);
			bool4.NativeMethodInfoPtr_get_xxxz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665601);
			bool4.NativeMethodInfoPtr_get_xxxw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665602);
			bool4.NativeMethodInfoPtr_get_xxyx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665603);
			bool4.NativeMethodInfoPtr_get_xxyy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665604);
			bool4.NativeMethodInfoPtr_get_xxyz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665605);
			bool4.NativeMethodInfoPtr_get_xxyw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665606);
			bool4.NativeMethodInfoPtr_get_xxzx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665607);
			bool4.NativeMethodInfoPtr_get_xxzy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665608);
			bool4.NativeMethodInfoPtr_get_xxzz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665609);
			bool4.NativeMethodInfoPtr_get_xxzw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665610);
			bool4.NativeMethodInfoPtr_get_xxwx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665611);
			bool4.NativeMethodInfoPtr_get_xxwy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665612);
			bool4.NativeMethodInfoPtr_get_xxwz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665613);
			bool4.NativeMethodInfoPtr_get_xxww_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665614);
			bool4.NativeMethodInfoPtr_get_xyxx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665615);
			bool4.NativeMethodInfoPtr_get_xyxy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665616);
			bool4.NativeMethodInfoPtr_get_xyxz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665617);
			bool4.NativeMethodInfoPtr_get_xyxw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665618);
			bool4.NativeMethodInfoPtr_get_xyyx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665619);
			bool4.NativeMethodInfoPtr_get_xyyy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665620);
			bool4.NativeMethodInfoPtr_get_xyyz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665621);
			bool4.NativeMethodInfoPtr_get_xyyw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665622);
			bool4.NativeMethodInfoPtr_get_xyzx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665623);
			bool4.NativeMethodInfoPtr_get_xyzy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665624);
			bool4.NativeMethodInfoPtr_get_xyzz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665625);
			bool4.NativeMethodInfoPtr_get_xyzw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665626);
			bool4.NativeMethodInfoPtr_set_xyzw_Public_set_Void_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665627);
			bool4.NativeMethodInfoPtr_get_xywx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665628);
			bool4.NativeMethodInfoPtr_get_xywy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665629);
			bool4.NativeMethodInfoPtr_get_xywz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665630);
			bool4.NativeMethodInfoPtr_set_xywz_Public_set_Void_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665631);
			bool4.NativeMethodInfoPtr_get_xyww_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665632);
			bool4.NativeMethodInfoPtr_get_xzxx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665633);
			bool4.NativeMethodInfoPtr_get_xzxy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665634);
			bool4.NativeMethodInfoPtr_get_xzxz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665635);
			bool4.NativeMethodInfoPtr_get_xzxw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665636);
			bool4.NativeMethodInfoPtr_get_xzyx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665637);
			bool4.NativeMethodInfoPtr_get_xzyy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665638);
			bool4.NativeMethodInfoPtr_get_xzyz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665639);
			bool4.NativeMethodInfoPtr_get_xzyw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665640);
			bool4.NativeMethodInfoPtr_set_xzyw_Public_set_Void_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665641);
			bool4.NativeMethodInfoPtr_get_xzzx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665642);
			bool4.NativeMethodInfoPtr_get_xzzy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665643);
			bool4.NativeMethodInfoPtr_get_xzzz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665644);
			bool4.NativeMethodInfoPtr_get_xzzw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665645);
			bool4.NativeMethodInfoPtr_get_xzwx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665646);
			bool4.NativeMethodInfoPtr_get_xzwy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665647);
			bool4.NativeMethodInfoPtr_set_xzwy_Public_set_Void_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665648);
			bool4.NativeMethodInfoPtr_get_xzwz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665649);
			bool4.NativeMethodInfoPtr_get_xzww_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665650);
			bool4.NativeMethodInfoPtr_get_xwxx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665651);
			bool4.NativeMethodInfoPtr_get_xwxy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665652);
			bool4.NativeMethodInfoPtr_get_xwxz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665653);
			bool4.NativeMethodInfoPtr_get_xwxw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665654);
			bool4.NativeMethodInfoPtr_get_xwyx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665655);
			bool4.NativeMethodInfoPtr_get_xwyy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665656);
			bool4.NativeMethodInfoPtr_get_xwyz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665657);
			bool4.NativeMethodInfoPtr_set_xwyz_Public_set_Void_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665658);
			bool4.NativeMethodInfoPtr_get_xwyw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665659);
			bool4.NativeMethodInfoPtr_get_xwzx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665660);
			bool4.NativeMethodInfoPtr_get_xwzy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665661);
			bool4.NativeMethodInfoPtr_set_xwzy_Public_set_Void_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665662);
			bool4.NativeMethodInfoPtr_get_xwzz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665663);
			bool4.NativeMethodInfoPtr_get_xwzw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665664);
			bool4.NativeMethodInfoPtr_get_xwwx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665665);
			bool4.NativeMethodInfoPtr_get_xwwy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665666);
			bool4.NativeMethodInfoPtr_get_xwwz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665667);
			bool4.NativeMethodInfoPtr_get_xwww_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665668);
			bool4.NativeMethodInfoPtr_get_yxxx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665669);
			bool4.NativeMethodInfoPtr_get_yxxy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665670);
			bool4.NativeMethodInfoPtr_get_yxxz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665671);
			bool4.NativeMethodInfoPtr_get_yxxw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665672);
			bool4.NativeMethodInfoPtr_get_yxyx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665673);
			bool4.NativeMethodInfoPtr_get_yxyy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665674);
			bool4.NativeMethodInfoPtr_get_yxyz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665675);
			bool4.NativeMethodInfoPtr_get_yxyw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665676);
			bool4.NativeMethodInfoPtr_get_yxzx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665677);
			bool4.NativeMethodInfoPtr_get_yxzy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665678);
			bool4.NativeMethodInfoPtr_get_yxzz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665679);
			bool4.NativeMethodInfoPtr_get_yxzw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665680);
			bool4.NativeMethodInfoPtr_set_yxzw_Public_set_Void_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665681);
			bool4.NativeMethodInfoPtr_get_yxwx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665682);
			bool4.NativeMethodInfoPtr_get_yxwy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665683);
			bool4.NativeMethodInfoPtr_get_yxwz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665684);
			bool4.NativeMethodInfoPtr_set_yxwz_Public_set_Void_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665685);
			bool4.NativeMethodInfoPtr_get_yxww_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665686);
			bool4.NativeMethodInfoPtr_get_yyxx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665687);
			bool4.NativeMethodInfoPtr_get_yyxy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665688);
			bool4.NativeMethodInfoPtr_get_yyxz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665689);
			bool4.NativeMethodInfoPtr_get_yyxw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665690);
			bool4.NativeMethodInfoPtr_get_yyyx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665691);
			bool4.NativeMethodInfoPtr_get_yyyy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665692);
			bool4.NativeMethodInfoPtr_get_yyyz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665693);
			bool4.NativeMethodInfoPtr_get_yyyw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665694);
			bool4.NativeMethodInfoPtr_get_yyzx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665695);
			bool4.NativeMethodInfoPtr_get_yyzy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665696);
			bool4.NativeMethodInfoPtr_get_yyzz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665697);
			bool4.NativeMethodInfoPtr_get_yyzw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665698);
			bool4.NativeMethodInfoPtr_get_yywx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665699);
			bool4.NativeMethodInfoPtr_get_yywy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665700);
			bool4.NativeMethodInfoPtr_get_yywz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665701);
			bool4.NativeMethodInfoPtr_get_yyww_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665702);
			bool4.NativeMethodInfoPtr_get_yzxx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665703);
			bool4.NativeMethodInfoPtr_get_yzxy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665704);
			bool4.NativeMethodInfoPtr_get_yzxz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665705);
			bool4.NativeMethodInfoPtr_get_yzxw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665706);
			bool4.NativeMethodInfoPtr_set_yzxw_Public_set_Void_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665707);
			bool4.NativeMethodInfoPtr_get_yzyx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665708);
			bool4.NativeMethodInfoPtr_get_yzyy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665709);
			bool4.NativeMethodInfoPtr_get_yzyz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665710);
			bool4.NativeMethodInfoPtr_get_yzyw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665711);
			bool4.NativeMethodInfoPtr_get_yzzx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665712);
			bool4.NativeMethodInfoPtr_get_yzzy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665713);
			bool4.NativeMethodInfoPtr_get_yzzz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665714);
			bool4.NativeMethodInfoPtr_get_yzzw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665715);
			bool4.NativeMethodInfoPtr_get_yzwx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665716);
			bool4.NativeMethodInfoPtr_set_yzwx_Public_set_Void_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665717);
			bool4.NativeMethodInfoPtr_get_yzwy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665718);
			bool4.NativeMethodInfoPtr_get_yzwz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665719);
			bool4.NativeMethodInfoPtr_get_yzww_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665720);
			bool4.NativeMethodInfoPtr_get_ywxx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665721);
			bool4.NativeMethodInfoPtr_get_ywxy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665722);
			bool4.NativeMethodInfoPtr_get_ywxz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665723);
			bool4.NativeMethodInfoPtr_set_ywxz_Public_set_Void_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665724);
			bool4.NativeMethodInfoPtr_get_ywxw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665725);
			bool4.NativeMethodInfoPtr_get_ywyx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665726);
			bool4.NativeMethodInfoPtr_get_ywyy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665727);
			bool4.NativeMethodInfoPtr_get_ywyz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665728);
			bool4.NativeMethodInfoPtr_get_ywyw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665729);
			bool4.NativeMethodInfoPtr_get_ywzx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665730);
			bool4.NativeMethodInfoPtr_set_ywzx_Public_set_Void_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665731);
			bool4.NativeMethodInfoPtr_get_ywzy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665732);
			bool4.NativeMethodInfoPtr_get_ywzz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665733);
			bool4.NativeMethodInfoPtr_get_ywzw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665734);
			bool4.NativeMethodInfoPtr_get_ywwx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665735);
			bool4.NativeMethodInfoPtr_get_ywwy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665736);
			bool4.NativeMethodInfoPtr_get_ywwz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665737);
			bool4.NativeMethodInfoPtr_get_ywww_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665738);
			bool4.NativeMethodInfoPtr_get_zxxx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665739);
			bool4.NativeMethodInfoPtr_get_zxxy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665740);
			bool4.NativeMethodInfoPtr_get_zxxz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665741);
			bool4.NativeMethodInfoPtr_get_zxxw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665742);
			bool4.NativeMethodInfoPtr_get_zxyx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665743);
			bool4.NativeMethodInfoPtr_get_zxyy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665744);
			bool4.NativeMethodInfoPtr_get_zxyz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665745);
			bool4.NativeMethodInfoPtr_get_zxyw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665746);
			bool4.NativeMethodInfoPtr_set_zxyw_Public_set_Void_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665747);
			bool4.NativeMethodInfoPtr_get_zxzx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665748);
			bool4.NativeMethodInfoPtr_get_zxzy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665749);
			bool4.NativeMethodInfoPtr_get_zxzz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665750);
			bool4.NativeMethodInfoPtr_get_zxzw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665751);
			bool4.NativeMethodInfoPtr_get_zxwx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665752);
			bool4.NativeMethodInfoPtr_get_zxwy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665753);
			bool4.NativeMethodInfoPtr_set_zxwy_Public_set_Void_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665754);
			bool4.NativeMethodInfoPtr_get_zxwz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665755);
			bool4.NativeMethodInfoPtr_get_zxww_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665756);
			bool4.NativeMethodInfoPtr_get_zyxx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665757);
			bool4.NativeMethodInfoPtr_get_zyxy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665758);
			bool4.NativeMethodInfoPtr_get_zyxz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665759);
			bool4.NativeMethodInfoPtr_get_zyxw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665760);
			bool4.NativeMethodInfoPtr_set_zyxw_Public_set_Void_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665761);
			bool4.NativeMethodInfoPtr_get_zyyx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665762);
			bool4.NativeMethodInfoPtr_get_zyyy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665763);
			bool4.NativeMethodInfoPtr_get_zyyz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665764);
			bool4.NativeMethodInfoPtr_get_zyyw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665765);
			bool4.NativeMethodInfoPtr_get_zyzx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665766);
			bool4.NativeMethodInfoPtr_get_zyzy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665767);
			bool4.NativeMethodInfoPtr_get_zyzz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665768);
			bool4.NativeMethodInfoPtr_get_zyzw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665769);
			bool4.NativeMethodInfoPtr_get_zywx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665770);
			bool4.NativeMethodInfoPtr_set_zywx_Public_set_Void_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665771);
			bool4.NativeMethodInfoPtr_get_zywy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665772);
			bool4.NativeMethodInfoPtr_get_zywz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665773);
			bool4.NativeMethodInfoPtr_get_zyww_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665774);
			bool4.NativeMethodInfoPtr_get_zzxx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665775);
			bool4.NativeMethodInfoPtr_get_zzxy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665776);
			bool4.NativeMethodInfoPtr_get_zzxz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665777);
			bool4.NativeMethodInfoPtr_get_zzxw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665778);
			bool4.NativeMethodInfoPtr_get_zzyx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665779);
			bool4.NativeMethodInfoPtr_get_zzyy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665780);
			bool4.NativeMethodInfoPtr_get_zzyz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665781);
			bool4.NativeMethodInfoPtr_get_zzyw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665782);
			bool4.NativeMethodInfoPtr_get_zzzx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665783);
			bool4.NativeMethodInfoPtr_get_zzzy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665784);
			bool4.NativeMethodInfoPtr_get_zzzz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665785);
			bool4.NativeMethodInfoPtr_get_zzzw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665786);
			bool4.NativeMethodInfoPtr_get_zzwx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665787);
			bool4.NativeMethodInfoPtr_get_zzwy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665788);
			bool4.NativeMethodInfoPtr_get_zzwz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665789);
			bool4.NativeMethodInfoPtr_get_zzww_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665790);
			bool4.NativeMethodInfoPtr_get_zwxx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665791);
			bool4.NativeMethodInfoPtr_get_zwxy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665792);
			bool4.NativeMethodInfoPtr_set_zwxy_Public_set_Void_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665793);
			bool4.NativeMethodInfoPtr_get_zwxz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665794);
			bool4.NativeMethodInfoPtr_get_zwxw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665795);
			bool4.NativeMethodInfoPtr_get_zwyx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665796);
			bool4.NativeMethodInfoPtr_set_zwyx_Public_set_Void_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665797);
			bool4.NativeMethodInfoPtr_get_zwyy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665798);
			bool4.NativeMethodInfoPtr_get_zwyz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665799);
			bool4.NativeMethodInfoPtr_get_zwyw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665800);
			bool4.NativeMethodInfoPtr_get_zwzx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665801);
			bool4.NativeMethodInfoPtr_get_zwzy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665802);
			bool4.NativeMethodInfoPtr_get_zwzz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665803);
			bool4.NativeMethodInfoPtr_get_zwzw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665804);
			bool4.NativeMethodInfoPtr_get_zwwx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665805);
			bool4.NativeMethodInfoPtr_get_zwwy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665806);
			bool4.NativeMethodInfoPtr_get_zwwz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665807);
			bool4.NativeMethodInfoPtr_get_zwww_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665808);
			bool4.NativeMethodInfoPtr_get_wxxx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665809);
			bool4.NativeMethodInfoPtr_get_wxxy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665810);
			bool4.NativeMethodInfoPtr_get_wxxz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665811);
			bool4.NativeMethodInfoPtr_get_wxxw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665812);
			bool4.NativeMethodInfoPtr_get_wxyx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665813);
			bool4.NativeMethodInfoPtr_get_wxyy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665814);
			bool4.NativeMethodInfoPtr_get_wxyz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665815);
			bool4.NativeMethodInfoPtr_set_wxyz_Public_set_Void_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665816);
			bool4.NativeMethodInfoPtr_get_wxyw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665817);
			bool4.NativeMethodInfoPtr_get_wxzx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665818);
			bool4.NativeMethodInfoPtr_get_wxzy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665819);
			bool4.NativeMethodInfoPtr_set_wxzy_Public_set_Void_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665820);
			bool4.NativeMethodInfoPtr_get_wxzz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665821);
			bool4.NativeMethodInfoPtr_get_wxzw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665822);
			bool4.NativeMethodInfoPtr_get_wxwx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665823);
			bool4.NativeMethodInfoPtr_get_wxwy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665824);
			bool4.NativeMethodInfoPtr_get_wxwz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665825);
			bool4.NativeMethodInfoPtr_get_wxww_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665826);
			bool4.NativeMethodInfoPtr_get_wyxx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665827);
			bool4.NativeMethodInfoPtr_get_wyxy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665828);
			bool4.NativeMethodInfoPtr_get_wyxz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665829);
			bool4.NativeMethodInfoPtr_set_wyxz_Public_set_Void_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665830);
			bool4.NativeMethodInfoPtr_get_wyxw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665831);
			bool4.NativeMethodInfoPtr_get_wyyx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665832);
			bool4.NativeMethodInfoPtr_get_wyyy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665833);
			bool4.NativeMethodInfoPtr_get_wyyz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665834);
			bool4.NativeMethodInfoPtr_get_wyyw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665835);
			bool4.NativeMethodInfoPtr_get_wyzx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665836);
			bool4.NativeMethodInfoPtr_set_wyzx_Public_set_Void_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665837);
			bool4.NativeMethodInfoPtr_get_wyzy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665838);
			bool4.NativeMethodInfoPtr_get_wyzz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665839);
			bool4.NativeMethodInfoPtr_get_wyzw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665840);
			bool4.NativeMethodInfoPtr_get_wywx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665841);
			bool4.NativeMethodInfoPtr_get_wywy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665842);
			bool4.NativeMethodInfoPtr_get_wywz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665843);
			bool4.NativeMethodInfoPtr_get_wyww_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665844);
			bool4.NativeMethodInfoPtr_get_wzxx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665845);
			bool4.NativeMethodInfoPtr_get_wzxy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665846);
			bool4.NativeMethodInfoPtr_set_wzxy_Public_set_Void_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665847);
			bool4.NativeMethodInfoPtr_get_wzxz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665848);
			bool4.NativeMethodInfoPtr_get_wzxw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665849);
			bool4.NativeMethodInfoPtr_get_wzyx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665850);
			bool4.NativeMethodInfoPtr_set_wzyx_Public_set_Void_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665851);
			bool4.NativeMethodInfoPtr_get_wzyy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665852);
			bool4.NativeMethodInfoPtr_get_wzyz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665853);
			bool4.NativeMethodInfoPtr_get_wzyw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665854);
			bool4.NativeMethodInfoPtr_get_wzzx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665855);
			bool4.NativeMethodInfoPtr_get_wzzy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665856);
			bool4.NativeMethodInfoPtr_get_wzzz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665857);
			bool4.NativeMethodInfoPtr_get_wzzw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665858);
			bool4.NativeMethodInfoPtr_get_wzwx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665859);
			bool4.NativeMethodInfoPtr_get_wzwy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665860);
			bool4.NativeMethodInfoPtr_get_wzwz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665861);
			bool4.NativeMethodInfoPtr_get_wzww_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665862);
			bool4.NativeMethodInfoPtr_get_wwxx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665863);
			bool4.NativeMethodInfoPtr_get_wwxy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665864);
			bool4.NativeMethodInfoPtr_get_wwxz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665865);
			bool4.NativeMethodInfoPtr_get_wwxw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665866);
			bool4.NativeMethodInfoPtr_get_wwyx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665867);
			bool4.NativeMethodInfoPtr_get_wwyy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665868);
			bool4.NativeMethodInfoPtr_get_wwyz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665869);
			bool4.NativeMethodInfoPtr_get_wwyw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665870);
			bool4.NativeMethodInfoPtr_get_wwzx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665871);
			bool4.NativeMethodInfoPtr_get_wwzy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665872);
			bool4.NativeMethodInfoPtr_get_wwzz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665873);
			bool4.NativeMethodInfoPtr_get_wwzw_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665874);
			bool4.NativeMethodInfoPtr_get_wwwx_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665875);
			bool4.NativeMethodInfoPtr_get_wwwy_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665876);
			bool4.NativeMethodInfoPtr_get_wwwz_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665877);
			bool4.NativeMethodInfoPtr_get_wwww_Public_get_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665878);
			bool4.NativeMethodInfoPtr_get_xxx_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665879);
			bool4.NativeMethodInfoPtr_get_xxy_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665880);
			bool4.NativeMethodInfoPtr_get_xxz_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665881);
			bool4.NativeMethodInfoPtr_get_xxw_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665882);
			bool4.NativeMethodInfoPtr_get_xyx_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665883);
			bool4.NativeMethodInfoPtr_get_xyy_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665884);
			bool4.NativeMethodInfoPtr_get_xyz_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665885);
			bool4.NativeMethodInfoPtr_set_xyz_Public_set_Void_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665886);
			bool4.NativeMethodInfoPtr_get_xyw_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665887);
			bool4.NativeMethodInfoPtr_set_xyw_Public_set_Void_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665888);
			bool4.NativeMethodInfoPtr_get_xzx_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665889);
			bool4.NativeMethodInfoPtr_get_xzy_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665890);
			bool4.NativeMethodInfoPtr_set_xzy_Public_set_Void_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665891);
			bool4.NativeMethodInfoPtr_get_xzz_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665892);
			bool4.NativeMethodInfoPtr_get_xzw_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665893);
			bool4.NativeMethodInfoPtr_set_xzw_Public_set_Void_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665894);
			bool4.NativeMethodInfoPtr_get_xwx_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665895);
			bool4.NativeMethodInfoPtr_get_xwy_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665896);
			bool4.NativeMethodInfoPtr_set_xwy_Public_set_Void_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665897);
			bool4.NativeMethodInfoPtr_get_xwz_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665898);
			bool4.NativeMethodInfoPtr_set_xwz_Public_set_Void_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665899);
			bool4.NativeMethodInfoPtr_get_xww_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665900);
			bool4.NativeMethodInfoPtr_get_yxx_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665901);
			bool4.NativeMethodInfoPtr_get_yxy_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665902);
			bool4.NativeMethodInfoPtr_get_yxz_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665903);
			bool4.NativeMethodInfoPtr_set_yxz_Public_set_Void_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665904);
			bool4.NativeMethodInfoPtr_get_yxw_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665905);
			bool4.NativeMethodInfoPtr_set_yxw_Public_set_Void_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665906);
			bool4.NativeMethodInfoPtr_get_yyx_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665907);
			bool4.NativeMethodInfoPtr_get_yyy_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665908);
			bool4.NativeMethodInfoPtr_get_yyz_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665909);
			bool4.NativeMethodInfoPtr_get_yyw_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665910);
			bool4.NativeMethodInfoPtr_get_yzx_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665911);
			bool4.NativeMethodInfoPtr_set_yzx_Public_set_Void_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665912);
			bool4.NativeMethodInfoPtr_get_yzy_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665913);
			bool4.NativeMethodInfoPtr_get_yzz_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665914);
			bool4.NativeMethodInfoPtr_get_yzw_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665915);
			bool4.NativeMethodInfoPtr_set_yzw_Public_set_Void_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665916);
			bool4.NativeMethodInfoPtr_get_ywx_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665917);
			bool4.NativeMethodInfoPtr_set_ywx_Public_set_Void_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665918);
			bool4.NativeMethodInfoPtr_get_ywy_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665919);
			bool4.NativeMethodInfoPtr_get_ywz_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665920);
			bool4.NativeMethodInfoPtr_set_ywz_Public_set_Void_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665921);
			bool4.NativeMethodInfoPtr_get_yww_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665922);
			bool4.NativeMethodInfoPtr_get_zxx_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665923);
			bool4.NativeMethodInfoPtr_get_zxy_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665924);
			bool4.NativeMethodInfoPtr_set_zxy_Public_set_Void_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665925);
			bool4.NativeMethodInfoPtr_get_zxz_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665926);
			bool4.NativeMethodInfoPtr_get_zxw_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665927);
			bool4.NativeMethodInfoPtr_set_zxw_Public_set_Void_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665928);
			bool4.NativeMethodInfoPtr_get_zyx_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665929);
			bool4.NativeMethodInfoPtr_set_zyx_Public_set_Void_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665930);
			bool4.NativeMethodInfoPtr_get_zyy_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665931);
			bool4.NativeMethodInfoPtr_get_zyz_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665932);
			bool4.NativeMethodInfoPtr_get_zyw_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665933);
			bool4.NativeMethodInfoPtr_set_zyw_Public_set_Void_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665934);
			bool4.NativeMethodInfoPtr_get_zzx_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665935);
			bool4.NativeMethodInfoPtr_get_zzy_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665936);
			bool4.NativeMethodInfoPtr_get_zzz_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665937);
			bool4.NativeMethodInfoPtr_get_zzw_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665938);
			bool4.NativeMethodInfoPtr_get_zwx_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665939);
			bool4.NativeMethodInfoPtr_set_zwx_Public_set_Void_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665940);
			bool4.NativeMethodInfoPtr_get_zwy_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665941);
			bool4.NativeMethodInfoPtr_set_zwy_Public_set_Void_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665942);
			bool4.NativeMethodInfoPtr_get_zwz_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665943);
			bool4.NativeMethodInfoPtr_get_zww_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665944);
			bool4.NativeMethodInfoPtr_get_wxx_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665945);
			bool4.NativeMethodInfoPtr_get_wxy_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665946);
			bool4.NativeMethodInfoPtr_set_wxy_Public_set_Void_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665947);
			bool4.NativeMethodInfoPtr_get_wxz_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665948);
			bool4.NativeMethodInfoPtr_set_wxz_Public_set_Void_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665949);
			bool4.NativeMethodInfoPtr_get_wxw_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665950);
			bool4.NativeMethodInfoPtr_get_wyx_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665951);
			bool4.NativeMethodInfoPtr_set_wyx_Public_set_Void_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665952);
			bool4.NativeMethodInfoPtr_get_wyy_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665953);
			bool4.NativeMethodInfoPtr_get_wyz_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665954);
			bool4.NativeMethodInfoPtr_set_wyz_Public_set_Void_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665955);
			bool4.NativeMethodInfoPtr_get_wyw_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665956);
			bool4.NativeMethodInfoPtr_get_wzx_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665957);
			bool4.NativeMethodInfoPtr_set_wzx_Public_set_Void_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665958);
			bool4.NativeMethodInfoPtr_get_wzy_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665959);
			bool4.NativeMethodInfoPtr_set_wzy_Public_set_Void_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665960);
			bool4.NativeMethodInfoPtr_get_wzz_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665961);
			bool4.NativeMethodInfoPtr_get_wzw_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665962);
			bool4.NativeMethodInfoPtr_get_wwx_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665963);
			bool4.NativeMethodInfoPtr_get_wwy_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665964);
			bool4.NativeMethodInfoPtr_get_wwz_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665965);
			bool4.NativeMethodInfoPtr_get_www_Public_get_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665966);
			bool4.NativeMethodInfoPtr_get_xx_Public_get_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665967);
			bool4.NativeMethodInfoPtr_get_xy_Public_get_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665968);
			bool4.NativeMethodInfoPtr_set_xy_Public_set_Void_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665969);
			bool4.NativeMethodInfoPtr_get_xz_Public_get_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665970);
			bool4.NativeMethodInfoPtr_set_xz_Public_set_Void_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665971);
			bool4.NativeMethodInfoPtr_get_xw_Public_get_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665972);
			bool4.NativeMethodInfoPtr_set_xw_Public_set_Void_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665973);
			bool4.NativeMethodInfoPtr_get_yx_Public_get_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665974);
			bool4.NativeMethodInfoPtr_set_yx_Public_set_Void_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665975);
			bool4.NativeMethodInfoPtr_get_yy_Public_get_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665976);
			bool4.NativeMethodInfoPtr_get_yz_Public_get_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665977);
			bool4.NativeMethodInfoPtr_set_yz_Public_set_Void_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665978);
			bool4.NativeMethodInfoPtr_get_yw_Public_get_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665979);
			bool4.NativeMethodInfoPtr_set_yw_Public_set_Void_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665980);
			bool4.NativeMethodInfoPtr_get_zx_Public_get_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665981);
			bool4.NativeMethodInfoPtr_set_zx_Public_set_Void_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665982);
			bool4.NativeMethodInfoPtr_get_zy_Public_get_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665983);
			bool4.NativeMethodInfoPtr_set_zy_Public_set_Void_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665984);
			bool4.NativeMethodInfoPtr_get_zz_Public_get_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665985);
			bool4.NativeMethodInfoPtr_get_zw_Public_get_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665986);
			bool4.NativeMethodInfoPtr_set_zw_Public_set_Void_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665987);
			bool4.NativeMethodInfoPtr_get_wx_Public_get_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665988);
			bool4.NativeMethodInfoPtr_set_wx_Public_set_Void_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665989);
			bool4.NativeMethodInfoPtr_get_wy_Public_get_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665990);
			bool4.NativeMethodInfoPtr_set_wy_Public_set_Void_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665991);
			bool4.NativeMethodInfoPtr_get_wz_Public_get_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665992);
			bool4.NativeMethodInfoPtr_set_wz_Public_set_Void_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665993);
			bool4.NativeMethodInfoPtr_get_ww_Public_get_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665994);
			bool4.NativeMethodInfoPtr_get_Item_Public_get_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665995);
			bool4.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665996);
			bool4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665997);
			bool4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665998);
			bool4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100665999);
			bool4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4>.NativeClassPtr, 100666000);
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x00038DAC File Offset: 0x00036FAC
		[CallerCount(0)]
		public unsafe bool4(bool x, bool y, bool z, bool w)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x00038E08 File Offset: 0x00037008
		[CallerCount(0)]
		public unsafe bool4(bool x, bool y, bool2 zw)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_bool2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x00038E58 File Offset: 0x00037058
		[CallerCount(0)]
		public unsafe bool4(bool x, bool2 yz, bool w)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_bool2_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x00038EA8 File Offset: 0x000370A8
		[CallerCount(0)]
		public unsafe bool4(bool x, bool3 yzw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yzw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_bool3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00038EE8 File Offset: 0x000370E8
		[CallerCount(0)]
		public unsafe bool4(bool2 xy, bool z, bool w)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr__ctor_Public_Void_bool2_Boolean_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x00038F38 File Offset: 0x00037138
		[CallerCount(0)]
		public unsafe bool4(bool2 xy, bool2 zw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xy;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr__ctor_Public_Void_bool2_bool2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x00038F78 File Offset: 0x00037178
		[CallerCount(0)]
		public unsafe bool4(bool3 xyz, bool w)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr__ctor_Public_Void_bool3_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x00038FB8 File Offset: 0x000371B8
		[CallerCount(0)]
		public unsafe bool4(bool4 xyzw)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyzw;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr__ctor_Public_Void_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x00038FEC File Offset: 0x000371EC
		[CallerCount(0)]
		public unsafe bool4(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x00039020 File Offset: 0x00037220
		[CallerCount(0)]
		public unsafe static implicit operator bool4(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_op_Implicit_Public_Static_bool4_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x00039060 File Offset: 0x00037260
		[CallerCount(0)]
		public unsafe static bool4 operator ==(bool4 lhs, bool4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4_bool4_bool4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x000390AC File Offset: 0x000372AC
		[CallerCount(0)]
		public unsafe static bool4 operator ==(bool4 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4_bool4_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x000390F8 File Offset: 0x000372F8
		[CallerCount(0)]
		public unsafe static bool4 operator ==(bool lhs, bool4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4_Boolean_bool4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x00039144 File Offset: 0x00037344
		[CallerCount(0)]
		public unsafe static bool4 operator !=(bool4 lhs, bool4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_bool4_bool4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x00039190 File Offset: 0x00037390
		[CallerCount(0)]
		public unsafe static bool4 operator !=(bool4 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_bool4_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x000391DC File Offset: 0x000373DC
		[CallerCount(0)]
		public unsafe static bool4 operator !=(bool lhs, bool4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_Boolean_bool4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x00039228 File Offset: 0x00037428
		[CallerCount(0)]
		public unsafe static bool4 operator !(bool4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_op_LogicalNot_Public_Static_bool4_bool4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x00039268 File Offset: 0x00037468
		[CallerCount(0)]
		public unsafe static bool4 operator &(bool4 lhs, bool4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool4_bool4_bool4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x000392B4 File Offset: 0x000374B4
		[CallerCount(0)]
		public unsafe static bool4 operator &(bool4 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool4_bool4_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x00039300 File Offset: 0x00037500
		[CallerCount(0)]
		public unsafe static bool4 operator &(bool lhs, bool4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool4_Boolean_bool4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x0003934C File Offset: 0x0003754C
		[CallerCount(0)]
		public unsafe static bool4 operator |(bool4 lhs, bool4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool4_bool4_bool4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x00039398 File Offset: 0x00037598
		[CallerCount(0)]
		public unsafe static bool4 operator |(bool4 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool4_bool4_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x000393E4 File Offset: 0x000375E4
		[CallerCount(0)]
		public unsafe static bool4 operator |(bool lhs, bool4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool4_Boolean_bool4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x00039430 File Offset: 0x00037630
		[CallerCount(0)]
		public unsafe static bool4 operator ^(bool4 lhs, bool4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool4_bool4_bool4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x0003947C File Offset: 0x0003767C
		[CallerCount(0)]
		public unsafe static bool4 operator ^(bool4 lhs, bool rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool4_bool4_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x000394C8 File Offset: 0x000376C8
		[CallerCount(0)]
		public unsafe static bool4 operator ^(bool lhs, bool4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool4_Boolean_bool4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000940 RID: 2368 RVA: 0x00039514 File Offset: 0x00037714
		public unsafe bool4 xxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xxxx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000941 RID: 2369 RVA: 0x00039544 File Offset: 0x00037744
		public unsafe bool4 xxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xxxy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000942 RID: 2370 RVA: 0x00039574 File Offset: 0x00037774
		public unsafe bool4 xxxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xxxz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000943 RID: 2371 RVA: 0x000395A4 File Offset: 0x000377A4
		public unsafe bool4 xxxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xxxw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000944 RID: 2372 RVA: 0x000395D4 File Offset: 0x000377D4
		public unsafe bool4 xxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xxyx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000945 RID: 2373 RVA: 0x00039604 File Offset: 0x00037804
		public unsafe bool4 xxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xxyy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000946 RID: 2374 RVA: 0x00039634 File Offset: 0x00037834
		public unsafe bool4 xxyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xxyz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000947 RID: 2375 RVA: 0x00039664 File Offset: 0x00037864
		public unsafe bool4 xxyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xxyw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000948 RID: 2376 RVA: 0x00039694 File Offset: 0x00037894
		public unsafe bool4 xxzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xxzx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000949 RID: 2377 RVA: 0x000396C4 File Offset: 0x000378C4
		public unsafe bool4 xxzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xxzy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600094A RID: 2378 RVA: 0x000396F4 File Offset: 0x000378F4
		public unsafe bool4 xxzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xxzz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600094B RID: 2379 RVA: 0x00039724 File Offset: 0x00037924
		public unsafe bool4 xxzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xxzw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600094C RID: 2380 RVA: 0x00039754 File Offset: 0x00037954
		public unsafe bool4 xxwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xxwx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600094D RID: 2381 RVA: 0x00039784 File Offset: 0x00037984
		public unsafe bool4 xxwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xxwy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600094E RID: 2382 RVA: 0x000397B4 File Offset: 0x000379B4
		public unsafe bool4 xxwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xxwz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600094F RID: 2383 RVA: 0x000397E4 File Offset: 0x000379E4
		public unsafe bool4 xxww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xxww_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000950 RID: 2384 RVA: 0x00039814 File Offset: 0x00037A14
		public unsafe bool4 xyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xyxx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000951 RID: 2385 RVA: 0x00039844 File Offset: 0x00037A44
		public unsafe bool4 xyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xyxy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000952 RID: 2386 RVA: 0x00039874 File Offset: 0x00037A74
		public unsafe bool4 xyxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xyxz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000953 RID: 2387 RVA: 0x000398A4 File Offset: 0x00037AA4
		public unsafe bool4 xyxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xyxw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000954 RID: 2388 RVA: 0x000398D4 File Offset: 0x00037AD4
		public unsafe bool4 xyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xyyx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000955 RID: 2389 RVA: 0x00039904 File Offset: 0x00037B04
		public unsafe bool4 xyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xyyy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000956 RID: 2390 RVA: 0x00039934 File Offset: 0x00037B34
		public unsafe bool4 xyyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xyyz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000957 RID: 2391 RVA: 0x00039964 File Offset: 0x00037B64
		public unsafe bool4 xyyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xyyw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000958 RID: 2392 RVA: 0x00039994 File Offset: 0x00037B94
		public unsafe bool4 xyzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xyzx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000959 RID: 2393 RVA: 0x000399C4 File Offset: 0x00037BC4
		public unsafe bool4 xyzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xyzy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600095A RID: 2394 RVA: 0x000399F4 File Offset: 0x00037BF4
		public unsafe bool4 xyzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xyzz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600095B RID: 2395 RVA: 0x00039A24 File Offset: 0x00037C24
		// (set) Token: 0x0600095C RID: 2396 RVA: 0x00039A54 File Offset: 0x00037C54
		public unsafe bool4 xyzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xyzw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_xyzw_Public_set_Void_bool4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600095D RID: 2397 RVA: 0x00039A88 File Offset: 0x00037C88
		public unsafe bool4 xywx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xywx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600095E RID: 2398 RVA: 0x00039AB8 File Offset: 0x00037CB8
		public unsafe bool4 xywy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xywy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600095F RID: 2399 RVA: 0x00039AE8 File Offset: 0x00037CE8
		// (set) Token: 0x06000960 RID: 2400 RVA: 0x00039B18 File Offset: 0x00037D18
		public unsafe bool4 xywz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xywz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_xywz_Public_set_Void_bool4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000961 RID: 2401 RVA: 0x00039B4C File Offset: 0x00037D4C
		public unsafe bool4 xyww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xyww_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000962 RID: 2402 RVA: 0x00039B7C File Offset: 0x00037D7C
		public unsafe bool4 xzxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xzxx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000963 RID: 2403 RVA: 0x00039BAC File Offset: 0x00037DAC
		public unsafe bool4 xzxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xzxy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000964 RID: 2404 RVA: 0x00039BDC File Offset: 0x00037DDC
		public unsafe bool4 xzxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xzxz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000965 RID: 2405 RVA: 0x00039C0C File Offset: 0x00037E0C
		public unsafe bool4 xzxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xzxw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000966 RID: 2406 RVA: 0x00039C3C File Offset: 0x00037E3C
		public unsafe bool4 xzyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xzyx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000967 RID: 2407 RVA: 0x00039C6C File Offset: 0x00037E6C
		public unsafe bool4 xzyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xzyy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000968 RID: 2408 RVA: 0x00039C9C File Offset: 0x00037E9C
		public unsafe bool4 xzyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xzyz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000969 RID: 2409 RVA: 0x00039CCC File Offset: 0x00037ECC
		// (set) Token: 0x0600096A RID: 2410 RVA: 0x00039CFC File Offset: 0x00037EFC
		public unsafe bool4 xzyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xzyw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_xzyw_Public_set_Void_bool4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600096B RID: 2411 RVA: 0x00039D30 File Offset: 0x00037F30
		public unsafe bool4 xzzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xzzx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600096C RID: 2412 RVA: 0x00039D60 File Offset: 0x00037F60
		public unsafe bool4 xzzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xzzy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600096D RID: 2413 RVA: 0x00039D90 File Offset: 0x00037F90
		public unsafe bool4 xzzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xzzz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600096E RID: 2414 RVA: 0x00039DC0 File Offset: 0x00037FC0
		public unsafe bool4 xzzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xzzw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600096F RID: 2415 RVA: 0x00039DF0 File Offset: 0x00037FF0
		public unsafe bool4 xzwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xzwx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000970 RID: 2416 RVA: 0x00039E20 File Offset: 0x00038020
		// (set) Token: 0x06000971 RID: 2417 RVA: 0x00039E50 File Offset: 0x00038050
		public unsafe bool4 xzwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xzwy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_xzwy_Public_set_Void_bool4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000972 RID: 2418 RVA: 0x00039E84 File Offset: 0x00038084
		public unsafe bool4 xzwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xzwz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000973 RID: 2419 RVA: 0x00039EB4 File Offset: 0x000380B4
		public unsafe bool4 xzww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xzww_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000974 RID: 2420 RVA: 0x00039EE4 File Offset: 0x000380E4
		public unsafe bool4 xwxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xwxx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000975 RID: 2421 RVA: 0x00039F14 File Offset: 0x00038114
		public unsafe bool4 xwxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xwxy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000976 RID: 2422 RVA: 0x00039F44 File Offset: 0x00038144
		public unsafe bool4 xwxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xwxz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000977 RID: 2423 RVA: 0x00039F74 File Offset: 0x00038174
		public unsafe bool4 xwxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xwxw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000978 RID: 2424 RVA: 0x00039FA4 File Offset: 0x000381A4
		public unsafe bool4 xwyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xwyx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000979 RID: 2425 RVA: 0x00039FD4 File Offset: 0x000381D4
		public unsafe bool4 xwyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xwyy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600097A RID: 2426 RVA: 0x0003A004 File Offset: 0x00038204
		// (set) Token: 0x0600097B RID: 2427 RVA: 0x0003A034 File Offset: 0x00038234
		public unsafe bool4 xwyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xwyz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_xwyz_Public_set_Void_bool4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600097C RID: 2428 RVA: 0x0003A068 File Offset: 0x00038268
		public unsafe bool4 xwyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xwyw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600097D RID: 2429 RVA: 0x0003A098 File Offset: 0x00038298
		public unsafe bool4 xwzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xwzx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600097E RID: 2430 RVA: 0x0003A0C8 File Offset: 0x000382C8
		// (set) Token: 0x0600097F RID: 2431 RVA: 0x0003A0F8 File Offset: 0x000382F8
		public unsafe bool4 xwzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xwzy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_xwzy_Public_set_Void_bool4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000980 RID: 2432 RVA: 0x0003A12C File Offset: 0x0003832C
		public unsafe bool4 xwzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xwzz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000981 RID: 2433 RVA: 0x0003A15C File Offset: 0x0003835C
		public unsafe bool4 xwzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xwzw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000982 RID: 2434 RVA: 0x0003A18C File Offset: 0x0003838C
		public unsafe bool4 xwwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xwwx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000983 RID: 2435 RVA: 0x0003A1BC File Offset: 0x000383BC
		public unsafe bool4 xwwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xwwy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000984 RID: 2436 RVA: 0x0003A1EC File Offset: 0x000383EC
		public unsafe bool4 xwwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xwwz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000985 RID: 2437 RVA: 0x0003A21C File Offset: 0x0003841C
		public unsafe bool4 xwww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xwww_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000986 RID: 2438 RVA: 0x0003A24C File Offset: 0x0003844C
		public unsafe bool4 yxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yxxx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000987 RID: 2439 RVA: 0x0003A27C File Offset: 0x0003847C
		public unsafe bool4 yxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yxxy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000988 RID: 2440 RVA: 0x0003A2AC File Offset: 0x000384AC
		public unsafe bool4 yxxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yxxz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000989 RID: 2441 RVA: 0x0003A2DC File Offset: 0x000384DC
		public unsafe bool4 yxxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yxxw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600098A RID: 2442 RVA: 0x0003A30C File Offset: 0x0003850C
		public unsafe bool4 yxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yxyx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600098B RID: 2443 RVA: 0x0003A33C File Offset: 0x0003853C
		public unsafe bool4 yxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yxyy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600098C RID: 2444 RVA: 0x0003A36C File Offset: 0x0003856C
		public unsafe bool4 yxyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yxyz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600098D RID: 2445 RVA: 0x0003A39C File Offset: 0x0003859C
		public unsafe bool4 yxyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yxyw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600098E RID: 2446 RVA: 0x0003A3CC File Offset: 0x000385CC
		public unsafe bool4 yxzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yxzx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600098F RID: 2447 RVA: 0x0003A3FC File Offset: 0x000385FC
		public unsafe bool4 yxzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yxzy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000990 RID: 2448 RVA: 0x0003A42C File Offset: 0x0003862C
		public unsafe bool4 yxzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yxzz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000991 RID: 2449 RVA: 0x0003A45C File Offset: 0x0003865C
		// (set) Token: 0x06000992 RID: 2450 RVA: 0x0003A48C File Offset: 0x0003868C
		public unsafe bool4 yxzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yxzw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_yxzw_Public_set_Void_bool4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000993 RID: 2451 RVA: 0x0003A4C0 File Offset: 0x000386C0
		public unsafe bool4 yxwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yxwx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000994 RID: 2452 RVA: 0x0003A4F0 File Offset: 0x000386F0
		public unsafe bool4 yxwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yxwy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000995 RID: 2453 RVA: 0x0003A520 File Offset: 0x00038720
		// (set) Token: 0x06000996 RID: 2454 RVA: 0x0003A550 File Offset: 0x00038750
		public unsafe bool4 yxwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yxwz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_yxwz_Public_set_Void_bool4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000997 RID: 2455 RVA: 0x0003A584 File Offset: 0x00038784
		public unsafe bool4 yxww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yxww_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000998 RID: 2456 RVA: 0x0003A5B4 File Offset: 0x000387B4
		public unsafe bool4 yyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yyxx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000999 RID: 2457 RVA: 0x0003A5E4 File Offset: 0x000387E4
		public unsafe bool4 yyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yyxy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600099A RID: 2458 RVA: 0x0003A614 File Offset: 0x00038814
		public unsafe bool4 yyxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yyxz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x0600099B RID: 2459 RVA: 0x0003A644 File Offset: 0x00038844
		public unsafe bool4 yyxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yyxw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600099C RID: 2460 RVA: 0x0003A674 File Offset: 0x00038874
		public unsafe bool4 yyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yyyx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x0600099D RID: 2461 RVA: 0x0003A6A4 File Offset: 0x000388A4
		public unsafe bool4 yyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yyyy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600099E RID: 2462 RVA: 0x0003A6D4 File Offset: 0x000388D4
		public unsafe bool4 yyyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yyyz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x0600099F RID: 2463 RVA: 0x0003A704 File Offset: 0x00038904
		public unsafe bool4 yyyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yyyw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060009A0 RID: 2464 RVA: 0x0003A734 File Offset: 0x00038934
		public unsafe bool4 yyzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yyzx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060009A1 RID: 2465 RVA: 0x0003A764 File Offset: 0x00038964
		public unsafe bool4 yyzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yyzy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060009A2 RID: 2466 RVA: 0x0003A794 File Offset: 0x00038994
		public unsafe bool4 yyzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yyzz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060009A3 RID: 2467 RVA: 0x0003A7C4 File Offset: 0x000389C4
		public unsafe bool4 yyzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yyzw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060009A4 RID: 2468 RVA: 0x0003A7F4 File Offset: 0x000389F4
		public unsafe bool4 yywx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yywx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060009A5 RID: 2469 RVA: 0x0003A824 File Offset: 0x00038A24
		public unsafe bool4 yywy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yywy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060009A6 RID: 2470 RVA: 0x0003A854 File Offset: 0x00038A54
		public unsafe bool4 yywz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yywz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060009A7 RID: 2471 RVA: 0x0003A884 File Offset: 0x00038A84
		public unsafe bool4 yyww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yyww_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060009A8 RID: 2472 RVA: 0x0003A8B4 File Offset: 0x00038AB4
		public unsafe bool4 yzxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yzxx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060009A9 RID: 2473 RVA: 0x0003A8E4 File Offset: 0x00038AE4
		public unsafe bool4 yzxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yzxy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060009AA RID: 2474 RVA: 0x0003A914 File Offset: 0x00038B14
		public unsafe bool4 yzxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yzxz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060009AB RID: 2475 RVA: 0x0003A944 File Offset: 0x00038B44
		// (set) Token: 0x060009AC RID: 2476 RVA: 0x0003A974 File Offset: 0x00038B74
		public unsafe bool4 yzxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yzxw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_yzxw_Public_set_Void_bool4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060009AD RID: 2477 RVA: 0x0003A9A8 File Offset: 0x00038BA8
		public unsafe bool4 yzyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yzyx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060009AE RID: 2478 RVA: 0x0003A9D8 File Offset: 0x00038BD8
		public unsafe bool4 yzyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yzyy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060009AF RID: 2479 RVA: 0x0003AA08 File Offset: 0x00038C08
		public unsafe bool4 yzyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yzyz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060009B0 RID: 2480 RVA: 0x0003AA38 File Offset: 0x00038C38
		public unsafe bool4 yzyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yzyw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060009B1 RID: 2481 RVA: 0x0003AA68 File Offset: 0x00038C68
		public unsafe bool4 yzzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yzzx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060009B2 RID: 2482 RVA: 0x0003AA98 File Offset: 0x00038C98
		public unsafe bool4 yzzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yzzy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060009B3 RID: 2483 RVA: 0x0003AAC8 File Offset: 0x00038CC8
		public unsafe bool4 yzzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yzzz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060009B4 RID: 2484 RVA: 0x0003AAF8 File Offset: 0x00038CF8
		public unsafe bool4 yzzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yzzw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060009B5 RID: 2485 RVA: 0x0003AB28 File Offset: 0x00038D28
		// (set) Token: 0x060009B6 RID: 2486 RVA: 0x0003AB58 File Offset: 0x00038D58
		public unsafe bool4 yzwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yzwx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_yzwx_Public_set_Void_bool4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060009B7 RID: 2487 RVA: 0x0003AB8C File Offset: 0x00038D8C
		public unsafe bool4 yzwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yzwy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060009B8 RID: 2488 RVA: 0x0003ABBC File Offset: 0x00038DBC
		public unsafe bool4 yzwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yzwz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060009B9 RID: 2489 RVA: 0x0003ABEC File Offset: 0x00038DEC
		public unsafe bool4 yzww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yzww_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060009BA RID: 2490 RVA: 0x0003AC1C File Offset: 0x00038E1C
		public unsafe bool4 ywxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_ywxx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060009BB RID: 2491 RVA: 0x0003AC4C File Offset: 0x00038E4C
		public unsafe bool4 ywxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_ywxy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060009BC RID: 2492 RVA: 0x0003AC7C File Offset: 0x00038E7C
		// (set) Token: 0x060009BD RID: 2493 RVA: 0x0003ACAC File Offset: 0x00038EAC
		public unsafe bool4 ywxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_ywxz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_ywxz_Public_set_Void_bool4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060009BE RID: 2494 RVA: 0x0003ACE0 File Offset: 0x00038EE0
		public unsafe bool4 ywxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_ywxw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060009BF RID: 2495 RVA: 0x0003AD10 File Offset: 0x00038F10
		public unsafe bool4 ywyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_ywyx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060009C0 RID: 2496 RVA: 0x0003AD40 File Offset: 0x00038F40
		public unsafe bool4 ywyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_ywyy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060009C1 RID: 2497 RVA: 0x0003AD70 File Offset: 0x00038F70
		public unsafe bool4 ywyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_ywyz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060009C2 RID: 2498 RVA: 0x0003ADA0 File Offset: 0x00038FA0
		public unsafe bool4 ywyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_ywyw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060009C3 RID: 2499 RVA: 0x0003ADD0 File Offset: 0x00038FD0
		// (set) Token: 0x060009C4 RID: 2500 RVA: 0x0003AE00 File Offset: 0x00039000
		public unsafe bool4 ywzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_ywzx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_ywzx_Public_set_Void_bool4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060009C5 RID: 2501 RVA: 0x0003AE34 File Offset: 0x00039034
		public unsafe bool4 ywzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_ywzy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060009C6 RID: 2502 RVA: 0x0003AE64 File Offset: 0x00039064
		public unsafe bool4 ywzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_ywzz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060009C7 RID: 2503 RVA: 0x0003AE94 File Offset: 0x00039094
		public unsafe bool4 ywzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_ywzw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060009C8 RID: 2504 RVA: 0x0003AEC4 File Offset: 0x000390C4
		public unsafe bool4 ywwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_ywwx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060009C9 RID: 2505 RVA: 0x0003AEF4 File Offset: 0x000390F4
		public unsafe bool4 ywwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_ywwy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060009CA RID: 2506 RVA: 0x0003AF24 File Offset: 0x00039124
		public unsafe bool4 ywwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_ywwz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060009CB RID: 2507 RVA: 0x0003AF54 File Offset: 0x00039154
		public unsafe bool4 ywww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_ywww_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060009CC RID: 2508 RVA: 0x0003AF84 File Offset: 0x00039184
		public unsafe bool4 zxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zxxx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060009CD RID: 2509 RVA: 0x0003AFB4 File Offset: 0x000391B4
		public unsafe bool4 zxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zxxy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060009CE RID: 2510 RVA: 0x0003AFE4 File Offset: 0x000391E4
		public unsafe bool4 zxxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zxxz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060009CF RID: 2511 RVA: 0x0003B014 File Offset: 0x00039214
		public unsafe bool4 zxxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zxxw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060009D0 RID: 2512 RVA: 0x0003B044 File Offset: 0x00039244
		public unsafe bool4 zxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zxyx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060009D1 RID: 2513 RVA: 0x0003B074 File Offset: 0x00039274
		public unsafe bool4 zxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zxyy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060009D2 RID: 2514 RVA: 0x0003B0A4 File Offset: 0x000392A4
		public unsafe bool4 zxyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zxyz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060009D3 RID: 2515 RVA: 0x0003B0D4 File Offset: 0x000392D4
		// (set) Token: 0x060009D4 RID: 2516 RVA: 0x0003B104 File Offset: 0x00039304
		public unsafe bool4 zxyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zxyw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_zxyw_Public_set_Void_bool4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060009D5 RID: 2517 RVA: 0x0003B138 File Offset: 0x00039338
		public unsafe bool4 zxzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zxzx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060009D6 RID: 2518 RVA: 0x0003B168 File Offset: 0x00039368
		public unsafe bool4 zxzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zxzy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060009D7 RID: 2519 RVA: 0x0003B198 File Offset: 0x00039398
		public unsafe bool4 zxzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zxzz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060009D8 RID: 2520 RVA: 0x0003B1C8 File Offset: 0x000393C8
		public unsafe bool4 zxzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zxzw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060009D9 RID: 2521 RVA: 0x0003B1F8 File Offset: 0x000393F8
		public unsafe bool4 zxwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zxwx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060009DA RID: 2522 RVA: 0x0003B228 File Offset: 0x00039428
		// (set) Token: 0x060009DB RID: 2523 RVA: 0x0003B258 File Offset: 0x00039458
		public unsafe bool4 zxwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zxwy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_zxwy_Public_set_Void_bool4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060009DC RID: 2524 RVA: 0x0003B28C File Offset: 0x0003948C
		public unsafe bool4 zxwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zxwz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060009DD RID: 2525 RVA: 0x0003B2BC File Offset: 0x000394BC
		public unsafe bool4 zxww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zxww_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060009DE RID: 2526 RVA: 0x0003B2EC File Offset: 0x000394EC
		public unsafe bool4 zyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zyxx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060009DF RID: 2527 RVA: 0x0003B31C File Offset: 0x0003951C
		public unsafe bool4 zyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zyxy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060009E0 RID: 2528 RVA: 0x0003B34C File Offset: 0x0003954C
		public unsafe bool4 zyxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zyxz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060009E1 RID: 2529 RVA: 0x0003B37C File Offset: 0x0003957C
		// (set) Token: 0x060009E2 RID: 2530 RVA: 0x0003B3AC File Offset: 0x000395AC
		public unsafe bool4 zyxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zyxw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_zyxw_Public_set_Void_bool4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060009E3 RID: 2531 RVA: 0x0003B3E0 File Offset: 0x000395E0
		public unsafe bool4 zyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zyyx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060009E4 RID: 2532 RVA: 0x0003B410 File Offset: 0x00039610
		public unsafe bool4 zyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zyyy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060009E5 RID: 2533 RVA: 0x0003B440 File Offset: 0x00039640
		public unsafe bool4 zyyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zyyz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x0003B470 File Offset: 0x00039670
		public unsafe bool4 zyyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zyyw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060009E7 RID: 2535 RVA: 0x0003B4A0 File Offset: 0x000396A0
		public unsafe bool4 zyzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zyzx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060009E8 RID: 2536 RVA: 0x0003B4D0 File Offset: 0x000396D0
		public unsafe bool4 zyzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zyzy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060009E9 RID: 2537 RVA: 0x0003B500 File Offset: 0x00039700
		public unsafe bool4 zyzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zyzz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060009EA RID: 2538 RVA: 0x0003B530 File Offset: 0x00039730
		public unsafe bool4 zyzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zyzw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060009EB RID: 2539 RVA: 0x0003B560 File Offset: 0x00039760
		// (set) Token: 0x060009EC RID: 2540 RVA: 0x0003B590 File Offset: 0x00039790
		public unsafe bool4 zywx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zywx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_zywx_Public_set_Void_bool4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060009ED RID: 2541 RVA: 0x0003B5C4 File Offset: 0x000397C4
		public unsafe bool4 zywy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zywy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060009EE RID: 2542 RVA: 0x0003B5F4 File Offset: 0x000397F4
		public unsafe bool4 zywz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zywz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060009EF RID: 2543 RVA: 0x0003B624 File Offset: 0x00039824
		public unsafe bool4 zyww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zyww_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060009F0 RID: 2544 RVA: 0x0003B654 File Offset: 0x00039854
		public unsafe bool4 zzxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zzxx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060009F1 RID: 2545 RVA: 0x0003B684 File Offset: 0x00039884
		public unsafe bool4 zzxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zzxy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060009F2 RID: 2546 RVA: 0x0003B6B4 File Offset: 0x000398B4
		public unsafe bool4 zzxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zzxz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060009F3 RID: 2547 RVA: 0x0003B6E4 File Offset: 0x000398E4
		public unsafe bool4 zzxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zzxw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060009F4 RID: 2548 RVA: 0x0003B714 File Offset: 0x00039914
		public unsafe bool4 zzyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zzyx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060009F5 RID: 2549 RVA: 0x0003B744 File Offset: 0x00039944
		public unsafe bool4 zzyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zzyy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060009F6 RID: 2550 RVA: 0x0003B774 File Offset: 0x00039974
		public unsafe bool4 zzyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zzyz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060009F7 RID: 2551 RVA: 0x0003B7A4 File Offset: 0x000399A4
		public unsafe bool4 zzyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zzyw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060009F8 RID: 2552 RVA: 0x0003B7D4 File Offset: 0x000399D4
		public unsafe bool4 zzzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zzzx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060009F9 RID: 2553 RVA: 0x0003B804 File Offset: 0x00039A04
		public unsafe bool4 zzzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zzzy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060009FA RID: 2554 RVA: 0x0003B834 File Offset: 0x00039A34
		public unsafe bool4 zzzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zzzz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060009FB RID: 2555 RVA: 0x0003B864 File Offset: 0x00039A64
		public unsafe bool4 zzzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zzzw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060009FC RID: 2556 RVA: 0x0003B894 File Offset: 0x00039A94
		public unsafe bool4 zzwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zzwx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x0003B8C4 File Offset: 0x00039AC4
		public unsafe bool4 zzwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zzwy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060009FE RID: 2558 RVA: 0x0003B8F4 File Offset: 0x00039AF4
		public unsafe bool4 zzwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zzwz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060009FF RID: 2559 RVA: 0x0003B924 File Offset: 0x00039B24
		public unsafe bool4 zzww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zzww_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000A00 RID: 2560 RVA: 0x0003B954 File Offset: 0x00039B54
		public unsafe bool4 zwxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zwxx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000A01 RID: 2561 RVA: 0x0003B984 File Offset: 0x00039B84
		// (set) Token: 0x06000A02 RID: 2562 RVA: 0x0003B9B4 File Offset: 0x00039BB4
		public unsafe bool4 zwxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zwxy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_zwxy_Public_set_Void_bool4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000A03 RID: 2563 RVA: 0x0003B9E8 File Offset: 0x00039BE8
		public unsafe bool4 zwxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zwxz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000A04 RID: 2564 RVA: 0x0003BA18 File Offset: 0x00039C18
		public unsafe bool4 zwxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zwxw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000A05 RID: 2565 RVA: 0x0003BA48 File Offset: 0x00039C48
		// (set) Token: 0x06000A06 RID: 2566 RVA: 0x0003BA78 File Offset: 0x00039C78
		public unsafe bool4 zwyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zwyx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_zwyx_Public_set_Void_bool4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000A07 RID: 2567 RVA: 0x0003BAAC File Offset: 0x00039CAC
		public unsafe bool4 zwyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zwyy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x0003BADC File Offset: 0x00039CDC
		public unsafe bool4 zwyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zwyz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000A09 RID: 2569 RVA: 0x0003BB0C File Offset: 0x00039D0C
		public unsafe bool4 zwyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zwyw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000A0A RID: 2570 RVA: 0x0003BB3C File Offset: 0x00039D3C
		public unsafe bool4 zwzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zwzx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000A0B RID: 2571 RVA: 0x0003BB6C File Offset: 0x00039D6C
		public unsafe bool4 zwzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zwzy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000A0C RID: 2572 RVA: 0x0003BB9C File Offset: 0x00039D9C
		public unsafe bool4 zwzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zwzz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000A0D RID: 2573 RVA: 0x0003BBCC File Offset: 0x00039DCC
		public unsafe bool4 zwzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zwzw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000A0E RID: 2574 RVA: 0x0003BBFC File Offset: 0x00039DFC
		public unsafe bool4 zwwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zwwx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x0003BC2C File Offset: 0x00039E2C
		public unsafe bool4 zwwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zwwy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000A10 RID: 2576 RVA: 0x0003BC5C File Offset: 0x00039E5C
		public unsafe bool4 zwwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zwwz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x0003BC8C File Offset: 0x00039E8C
		public unsafe bool4 zwww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zwww_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000A12 RID: 2578 RVA: 0x0003BCBC File Offset: 0x00039EBC
		public unsafe bool4 wxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wxxx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x0003BCEC File Offset: 0x00039EEC
		public unsafe bool4 wxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wxxy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000A14 RID: 2580 RVA: 0x0003BD1C File Offset: 0x00039F1C
		public unsafe bool4 wxxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wxxz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x0003BD4C File Offset: 0x00039F4C
		public unsafe bool4 wxxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wxxw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000A16 RID: 2582 RVA: 0x0003BD7C File Offset: 0x00039F7C
		public unsafe bool4 wxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wxyx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x0003BDAC File Offset: 0x00039FAC
		public unsafe bool4 wxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wxyy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000A18 RID: 2584 RVA: 0x0003BDDC File Offset: 0x00039FDC
		// (set) Token: 0x06000A19 RID: 2585 RVA: 0x0003BE0C File Offset: 0x0003A00C
		public unsafe bool4 wxyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wxyz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_wxyz_Public_set_Void_bool4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000A1A RID: 2586 RVA: 0x0003BE40 File Offset: 0x0003A040
		public unsafe bool4 wxyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wxyw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x0003BE70 File Offset: 0x0003A070
		public unsafe bool4 wxzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wxzx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000A1C RID: 2588 RVA: 0x0003BEA0 File Offset: 0x0003A0A0
		// (set) Token: 0x06000A1D RID: 2589 RVA: 0x0003BED0 File Offset: 0x0003A0D0
		public unsafe bool4 wxzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wxzy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_wxzy_Public_set_Void_bool4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000A1E RID: 2590 RVA: 0x0003BF04 File Offset: 0x0003A104
		public unsafe bool4 wxzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wxzz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000A1F RID: 2591 RVA: 0x0003BF34 File Offset: 0x0003A134
		public unsafe bool4 wxzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wxzw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000A20 RID: 2592 RVA: 0x0003BF64 File Offset: 0x0003A164
		public unsafe bool4 wxwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wxwx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000A21 RID: 2593 RVA: 0x0003BF94 File Offset: 0x0003A194
		public unsafe bool4 wxwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wxwy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000A22 RID: 2594 RVA: 0x0003BFC4 File Offset: 0x0003A1C4
		public unsafe bool4 wxwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wxwz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000A23 RID: 2595 RVA: 0x0003BFF4 File Offset: 0x0003A1F4
		public unsafe bool4 wxww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wxww_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000A24 RID: 2596 RVA: 0x0003C024 File Offset: 0x0003A224
		public unsafe bool4 wyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wyxx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000A25 RID: 2597 RVA: 0x0003C054 File Offset: 0x0003A254
		public unsafe bool4 wyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wyxy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000A26 RID: 2598 RVA: 0x0003C084 File Offset: 0x0003A284
		// (set) Token: 0x06000A27 RID: 2599 RVA: 0x0003C0B4 File Offset: 0x0003A2B4
		public unsafe bool4 wyxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wyxz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_wyxz_Public_set_Void_bool4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x0003C0E8 File Offset: 0x0003A2E8
		public unsafe bool4 wyxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wyxw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000A29 RID: 2601 RVA: 0x0003C118 File Offset: 0x0003A318
		public unsafe bool4 wyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wyyx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000A2A RID: 2602 RVA: 0x0003C148 File Offset: 0x0003A348
		public unsafe bool4 wyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wyyy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000A2B RID: 2603 RVA: 0x0003C178 File Offset: 0x0003A378
		public unsafe bool4 wyyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wyyz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x0003C1A8 File Offset: 0x0003A3A8
		public unsafe bool4 wyyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wyyw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000A2D RID: 2605 RVA: 0x0003C1D8 File Offset: 0x0003A3D8
		// (set) Token: 0x06000A2E RID: 2606 RVA: 0x0003C208 File Offset: 0x0003A408
		public unsafe bool4 wyzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wyzx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_wyzx_Public_set_Void_bool4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x0003C23C File Offset: 0x0003A43C
		public unsafe bool4 wyzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wyzy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000A30 RID: 2608 RVA: 0x0003C26C File Offset: 0x0003A46C
		public unsafe bool4 wyzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wyzz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000A31 RID: 2609 RVA: 0x0003C29C File Offset: 0x0003A49C
		public unsafe bool4 wyzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wyzw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000A32 RID: 2610 RVA: 0x0003C2CC File Offset: 0x0003A4CC
		public unsafe bool4 wywx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wywx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000A33 RID: 2611 RVA: 0x0003C2FC File Offset: 0x0003A4FC
		public unsafe bool4 wywy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wywy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000A34 RID: 2612 RVA: 0x0003C32C File Offset: 0x0003A52C
		public unsafe bool4 wywz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wywz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000A35 RID: 2613 RVA: 0x0003C35C File Offset: 0x0003A55C
		public unsafe bool4 wyww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wyww_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000A36 RID: 2614 RVA: 0x0003C38C File Offset: 0x0003A58C
		public unsafe bool4 wzxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wzxx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000A37 RID: 2615 RVA: 0x0003C3BC File Offset: 0x0003A5BC
		// (set) Token: 0x06000A38 RID: 2616 RVA: 0x0003C3EC File Offset: 0x0003A5EC
		public unsafe bool4 wzxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wzxy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_wzxy_Public_set_Void_bool4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000A39 RID: 2617 RVA: 0x0003C420 File Offset: 0x0003A620
		public unsafe bool4 wzxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wzxz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000A3A RID: 2618 RVA: 0x0003C450 File Offset: 0x0003A650
		public unsafe bool4 wzxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wzxw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000A3B RID: 2619 RVA: 0x0003C480 File Offset: 0x0003A680
		// (set) Token: 0x06000A3C RID: 2620 RVA: 0x0003C4B0 File Offset: 0x0003A6B0
		public unsafe bool4 wzyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wzyx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_wzyx_Public_set_Void_bool4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000A3D RID: 2621 RVA: 0x0003C4E4 File Offset: 0x0003A6E4
		public unsafe bool4 wzyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wzyy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000A3E RID: 2622 RVA: 0x0003C514 File Offset: 0x0003A714
		public unsafe bool4 wzyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wzyz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x0003C544 File Offset: 0x0003A744
		public unsafe bool4 wzyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wzyw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000A40 RID: 2624 RVA: 0x0003C574 File Offset: 0x0003A774
		public unsafe bool4 wzzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wzzx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x0003C5A4 File Offset: 0x0003A7A4
		public unsafe bool4 wzzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wzzy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000A42 RID: 2626 RVA: 0x0003C5D4 File Offset: 0x0003A7D4
		public unsafe bool4 wzzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wzzz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000A43 RID: 2627 RVA: 0x0003C604 File Offset: 0x0003A804
		public unsafe bool4 wzzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wzzw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000A44 RID: 2628 RVA: 0x0003C634 File Offset: 0x0003A834
		public unsafe bool4 wzwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wzwx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000A45 RID: 2629 RVA: 0x0003C664 File Offset: 0x0003A864
		public unsafe bool4 wzwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wzwy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000A46 RID: 2630 RVA: 0x0003C694 File Offset: 0x0003A894
		public unsafe bool4 wzwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wzwz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000A47 RID: 2631 RVA: 0x0003C6C4 File Offset: 0x0003A8C4
		public unsafe bool4 wzww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wzww_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000A48 RID: 2632 RVA: 0x0003C6F4 File Offset: 0x0003A8F4
		public unsafe bool4 wwxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wwxx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000A49 RID: 2633 RVA: 0x0003C724 File Offset: 0x0003A924
		public unsafe bool4 wwxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wwxy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000A4A RID: 2634 RVA: 0x0003C754 File Offset: 0x0003A954
		public unsafe bool4 wwxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wwxz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000A4B RID: 2635 RVA: 0x0003C784 File Offset: 0x0003A984
		public unsafe bool4 wwxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wwxw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000A4C RID: 2636 RVA: 0x0003C7B4 File Offset: 0x0003A9B4
		public unsafe bool4 wwyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wwyx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000A4D RID: 2637 RVA: 0x0003C7E4 File Offset: 0x0003A9E4
		public unsafe bool4 wwyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wwyy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000A4E RID: 2638 RVA: 0x0003C814 File Offset: 0x0003AA14
		public unsafe bool4 wwyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wwyz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000A4F RID: 2639 RVA: 0x0003C844 File Offset: 0x0003AA44
		public unsafe bool4 wwyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wwyw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000A50 RID: 2640 RVA: 0x0003C874 File Offset: 0x0003AA74
		public unsafe bool4 wwzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wwzx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000A51 RID: 2641 RVA: 0x0003C8A4 File Offset: 0x0003AAA4
		public unsafe bool4 wwzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wwzy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000A52 RID: 2642 RVA: 0x0003C8D4 File Offset: 0x0003AAD4
		public unsafe bool4 wwzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wwzz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000A53 RID: 2643 RVA: 0x0003C904 File Offset: 0x0003AB04
		public unsafe bool4 wwzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wwzw_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000A54 RID: 2644 RVA: 0x0003C934 File Offset: 0x0003AB34
		public unsafe bool4 wwwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wwwx_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000A55 RID: 2645 RVA: 0x0003C964 File Offset: 0x0003AB64
		public unsafe bool4 wwwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wwwy_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000A56 RID: 2646 RVA: 0x0003C994 File Offset: 0x0003AB94
		public unsafe bool4 wwwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wwwz_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000A57 RID: 2647 RVA: 0x0003C9C4 File Offset: 0x0003ABC4
		public unsafe bool4 wwww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wwww_Public_get_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000A58 RID: 2648 RVA: 0x0003C9F4 File Offset: 0x0003ABF4
		public unsafe bool3 xxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xxx_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000A59 RID: 2649 RVA: 0x0003CA24 File Offset: 0x0003AC24
		public unsafe bool3 xxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xxy_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000A5A RID: 2650 RVA: 0x0003CA54 File Offset: 0x0003AC54
		public unsafe bool3 xxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xxz_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000A5B RID: 2651 RVA: 0x0003CA84 File Offset: 0x0003AC84
		public unsafe bool3 xxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xxw_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000A5C RID: 2652 RVA: 0x0003CAB4 File Offset: 0x0003ACB4
		public unsafe bool3 xyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xyx_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000A5D RID: 2653 RVA: 0x0003CAE4 File Offset: 0x0003ACE4
		public unsafe bool3 xyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xyy_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x0003CB14 File Offset: 0x0003AD14
		// (set) Token: 0x06000A5F RID: 2655 RVA: 0x0003CB44 File Offset: 0x0003AD44
		public unsafe bool3 xyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xyz_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_xyz_Public_set_Void_bool3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000A60 RID: 2656 RVA: 0x0003CB78 File Offset: 0x0003AD78
		// (set) Token: 0x06000A61 RID: 2657 RVA: 0x0003CBA8 File Offset: 0x0003ADA8
		public unsafe bool3 xyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xyw_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_xyw_Public_set_Void_bool3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000A62 RID: 2658 RVA: 0x0003CBDC File Offset: 0x0003ADDC
		public unsafe bool3 xzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xzx_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000A63 RID: 2659 RVA: 0x0003CC0C File Offset: 0x0003AE0C
		// (set) Token: 0x06000A64 RID: 2660 RVA: 0x0003CC3C File Offset: 0x0003AE3C
		public unsafe bool3 xzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xzy_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_xzy_Public_set_Void_bool3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000A65 RID: 2661 RVA: 0x0003CC70 File Offset: 0x0003AE70
		public unsafe bool3 xzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xzz_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000A66 RID: 2662 RVA: 0x0003CCA0 File Offset: 0x0003AEA0
		// (set) Token: 0x06000A67 RID: 2663 RVA: 0x0003CCD0 File Offset: 0x0003AED0
		public unsafe bool3 xzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xzw_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_xzw_Public_set_Void_bool3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000A68 RID: 2664 RVA: 0x0003CD04 File Offset: 0x0003AF04
		public unsafe bool3 xwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xwx_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000A69 RID: 2665 RVA: 0x0003CD34 File Offset: 0x0003AF34
		// (set) Token: 0x06000A6A RID: 2666 RVA: 0x0003CD64 File Offset: 0x0003AF64
		public unsafe bool3 xwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xwy_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_xwy_Public_set_Void_bool3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x0003CD98 File Offset: 0x0003AF98
		// (set) Token: 0x06000A6C RID: 2668 RVA: 0x0003CDC8 File Offset: 0x0003AFC8
		public unsafe bool3 xwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xwz_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_xwz_Public_set_Void_bool3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000A6D RID: 2669 RVA: 0x0003CDFC File Offset: 0x0003AFFC
		public unsafe bool3 xww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xww_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000A6E RID: 2670 RVA: 0x0003CE2C File Offset: 0x0003B02C
		public unsafe bool3 yxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yxx_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000A6F RID: 2671 RVA: 0x0003CE5C File Offset: 0x0003B05C
		public unsafe bool3 yxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yxy_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000A70 RID: 2672 RVA: 0x0003CE8C File Offset: 0x0003B08C
		// (set) Token: 0x06000A71 RID: 2673 RVA: 0x0003CEBC File Offset: 0x0003B0BC
		public unsafe bool3 yxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yxz_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_yxz_Public_set_Void_bool3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000A72 RID: 2674 RVA: 0x0003CEF0 File Offset: 0x0003B0F0
		// (set) Token: 0x06000A73 RID: 2675 RVA: 0x0003CF20 File Offset: 0x0003B120
		public unsafe bool3 yxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yxw_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_yxw_Public_set_Void_bool3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000A74 RID: 2676 RVA: 0x0003CF54 File Offset: 0x0003B154
		public unsafe bool3 yyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yyx_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000A75 RID: 2677 RVA: 0x0003CF84 File Offset: 0x0003B184
		public unsafe bool3 yyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yyy_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000A76 RID: 2678 RVA: 0x0003CFB4 File Offset: 0x0003B1B4
		public unsafe bool3 yyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yyz_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000A77 RID: 2679 RVA: 0x0003CFE4 File Offset: 0x0003B1E4
		public unsafe bool3 yyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yyw_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000A78 RID: 2680 RVA: 0x0003D014 File Offset: 0x0003B214
		// (set) Token: 0x06000A79 RID: 2681 RVA: 0x0003D044 File Offset: 0x0003B244
		public unsafe bool3 yzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yzx_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_yzx_Public_set_Void_bool3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000A7A RID: 2682 RVA: 0x0003D078 File Offset: 0x0003B278
		public unsafe bool3 yzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yzy_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000A7B RID: 2683 RVA: 0x0003D0A8 File Offset: 0x0003B2A8
		public unsafe bool3 yzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yzz_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000A7C RID: 2684 RVA: 0x0003D0D8 File Offset: 0x0003B2D8
		// (set) Token: 0x06000A7D RID: 2685 RVA: 0x0003D108 File Offset: 0x0003B308
		public unsafe bool3 yzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yzw_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_yzw_Public_set_Void_bool3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000A7E RID: 2686 RVA: 0x0003D13C File Offset: 0x0003B33C
		// (set) Token: 0x06000A7F RID: 2687 RVA: 0x0003D16C File Offset: 0x0003B36C
		public unsafe bool3 ywx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_ywx_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_ywx_Public_set_Void_bool3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000A80 RID: 2688 RVA: 0x0003D1A0 File Offset: 0x0003B3A0
		public unsafe bool3 ywy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_ywy_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000A81 RID: 2689 RVA: 0x0003D1D0 File Offset: 0x0003B3D0
		// (set) Token: 0x06000A82 RID: 2690 RVA: 0x0003D200 File Offset: 0x0003B400
		public unsafe bool3 ywz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_ywz_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_ywz_Public_set_Void_bool3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x0003D234 File Offset: 0x0003B434
		public unsafe bool3 yww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yww_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000A84 RID: 2692 RVA: 0x0003D264 File Offset: 0x0003B464
		public unsafe bool3 zxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zxx_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000A85 RID: 2693 RVA: 0x0003D294 File Offset: 0x0003B494
		// (set) Token: 0x06000A86 RID: 2694 RVA: 0x0003D2C4 File Offset: 0x0003B4C4
		public unsafe bool3 zxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zxy_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_zxy_Public_set_Void_bool3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000A87 RID: 2695 RVA: 0x0003D2F8 File Offset: 0x0003B4F8
		public unsafe bool3 zxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zxz_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000A88 RID: 2696 RVA: 0x0003D328 File Offset: 0x0003B528
		// (set) Token: 0x06000A89 RID: 2697 RVA: 0x0003D358 File Offset: 0x0003B558
		public unsafe bool3 zxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zxw_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_zxw_Public_set_Void_bool3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000A8A RID: 2698 RVA: 0x0003D38C File Offset: 0x0003B58C
		// (set) Token: 0x06000A8B RID: 2699 RVA: 0x0003D3BC File Offset: 0x0003B5BC
		public unsafe bool3 zyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zyx_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_zyx_Public_set_Void_bool3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000A8C RID: 2700 RVA: 0x0003D3F0 File Offset: 0x0003B5F0
		public unsafe bool3 zyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zyy_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000A8D RID: 2701 RVA: 0x0003D420 File Offset: 0x0003B620
		public unsafe bool3 zyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zyz_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000A8E RID: 2702 RVA: 0x0003D450 File Offset: 0x0003B650
		// (set) Token: 0x06000A8F RID: 2703 RVA: 0x0003D480 File Offset: 0x0003B680
		public unsafe bool3 zyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zyw_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_zyw_Public_set_Void_bool3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000A90 RID: 2704 RVA: 0x0003D4B4 File Offset: 0x0003B6B4
		public unsafe bool3 zzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zzx_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000A91 RID: 2705 RVA: 0x0003D4E4 File Offset: 0x0003B6E4
		public unsafe bool3 zzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zzy_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000A92 RID: 2706 RVA: 0x0003D514 File Offset: 0x0003B714
		public unsafe bool3 zzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zzz_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000A93 RID: 2707 RVA: 0x0003D544 File Offset: 0x0003B744
		public unsafe bool3 zzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zzw_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000A94 RID: 2708 RVA: 0x0003D574 File Offset: 0x0003B774
		// (set) Token: 0x06000A95 RID: 2709 RVA: 0x0003D5A4 File Offset: 0x0003B7A4
		public unsafe bool3 zwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zwx_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_zwx_Public_set_Void_bool3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000A96 RID: 2710 RVA: 0x0003D5D8 File Offset: 0x0003B7D8
		// (set) Token: 0x06000A97 RID: 2711 RVA: 0x0003D608 File Offset: 0x0003B808
		public unsafe bool3 zwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zwy_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_zwy_Public_set_Void_bool3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000A98 RID: 2712 RVA: 0x0003D63C File Offset: 0x0003B83C
		public unsafe bool3 zwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zwz_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000A99 RID: 2713 RVA: 0x0003D66C File Offset: 0x0003B86C
		public unsafe bool3 zww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zww_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000A9A RID: 2714 RVA: 0x0003D69C File Offset: 0x0003B89C
		public unsafe bool3 wxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wxx_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x0003D6CC File Offset: 0x0003B8CC
		// (set) Token: 0x06000A9C RID: 2716 RVA: 0x0003D6FC File Offset: 0x0003B8FC
		public unsafe bool3 wxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wxy_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_wxy_Public_set_Void_bool3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x0003D730 File Offset: 0x0003B930
		// (set) Token: 0x06000A9E RID: 2718 RVA: 0x0003D760 File Offset: 0x0003B960
		public unsafe bool3 wxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wxz_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_wxz_Public_set_Void_bool3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x0003D794 File Offset: 0x0003B994
		public unsafe bool3 wxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wxw_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000AA0 RID: 2720 RVA: 0x0003D7C4 File Offset: 0x0003B9C4
		// (set) Token: 0x06000AA1 RID: 2721 RVA: 0x0003D7F4 File Offset: 0x0003B9F4
		public unsafe bool3 wyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wyx_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_wyx_Public_set_Void_bool3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000AA2 RID: 2722 RVA: 0x0003D828 File Offset: 0x0003BA28
		public unsafe bool3 wyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wyy_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x0003D858 File Offset: 0x0003BA58
		// (set) Token: 0x06000AA4 RID: 2724 RVA: 0x0003D888 File Offset: 0x0003BA88
		public unsafe bool3 wyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wyz_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_wyz_Public_set_Void_bool3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x0003D8BC File Offset: 0x0003BABC
		public unsafe bool3 wyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wyw_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000AA6 RID: 2726 RVA: 0x0003D8EC File Offset: 0x0003BAEC
		// (set) Token: 0x06000AA7 RID: 2727 RVA: 0x0003D91C File Offset: 0x0003BB1C
		public unsafe bool3 wzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wzx_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_wzx_Public_set_Void_bool3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000AA8 RID: 2728 RVA: 0x0003D950 File Offset: 0x0003BB50
		// (set) Token: 0x06000AA9 RID: 2729 RVA: 0x0003D980 File Offset: 0x0003BB80
		public unsafe bool3 wzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wzy_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_wzy_Public_set_Void_bool3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000AAA RID: 2730 RVA: 0x0003D9B4 File Offset: 0x0003BBB4
		public unsafe bool3 wzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wzz_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000AAB RID: 2731 RVA: 0x0003D9E4 File Offset: 0x0003BBE4
		public unsafe bool3 wzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wzw_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000AAC RID: 2732 RVA: 0x0003DA14 File Offset: 0x0003BC14
		public unsafe bool3 wwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wwx_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000AAD RID: 2733 RVA: 0x0003DA44 File Offset: 0x0003BC44
		public unsafe bool3 wwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wwy_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000AAE RID: 2734 RVA: 0x0003DA74 File Offset: 0x0003BC74
		public unsafe bool3 wwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wwz_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000AAF RID: 2735 RVA: 0x0003DAA4 File Offset: 0x0003BCA4
		public unsafe bool3 www
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_www_Public_get_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000AB0 RID: 2736 RVA: 0x0003DAD4 File Offset: 0x0003BCD4
		public unsafe bool2 xx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xx_Public_get_bool2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000AB1 RID: 2737 RVA: 0x0003DB04 File Offset: 0x0003BD04
		// (set) Token: 0x06000AB2 RID: 2738 RVA: 0x0003DB34 File Offset: 0x0003BD34
		public unsafe bool2 xy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xy_Public_get_bool2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_xy_Public_set_Void_bool2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x0003DB68 File Offset: 0x0003BD68
		// (set) Token: 0x06000AB4 RID: 2740 RVA: 0x0003DB98 File Offset: 0x0003BD98
		public unsafe bool2 xz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xz_Public_get_bool2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_xz_Public_set_Void_bool2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x0003DBCC File Offset: 0x0003BDCC
		// (set) Token: 0x06000AB6 RID: 2742 RVA: 0x0003DBFC File Offset: 0x0003BDFC
		public unsafe bool2 xw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_xw_Public_get_bool2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_xw_Public_set_Void_bool2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x0003DC30 File Offset: 0x0003BE30
		// (set) Token: 0x06000AB8 RID: 2744 RVA: 0x0003DC60 File Offset: 0x0003BE60
		public unsafe bool2 yx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yx_Public_get_bool2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_yx_Public_set_Void_bool2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x0003DC94 File Offset: 0x0003BE94
		public unsafe bool2 yy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yy_Public_get_bool2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000ABA RID: 2746 RVA: 0x0003DCC4 File Offset: 0x0003BEC4
		// (set) Token: 0x06000ABB RID: 2747 RVA: 0x0003DCF4 File Offset: 0x0003BEF4
		public unsafe bool2 yz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yz_Public_get_bool2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_yz_Public_set_Void_bool2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000ABC RID: 2748 RVA: 0x0003DD28 File Offset: 0x0003BF28
		// (set) Token: 0x06000ABD RID: 2749 RVA: 0x0003DD58 File Offset: 0x0003BF58
		public unsafe bool2 yw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_yw_Public_get_bool2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_yw_Public_set_Void_bool2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000ABE RID: 2750 RVA: 0x0003DD8C File Offset: 0x0003BF8C
		// (set) Token: 0x06000ABF RID: 2751 RVA: 0x0003DDBC File Offset: 0x0003BFBC
		public unsafe bool2 zx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zx_Public_get_bool2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_zx_Public_set_Void_bool2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x0003DDF0 File Offset: 0x0003BFF0
		// (set) Token: 0x06000AC1 RID: 2753 RVA: 0x0003DE20 File Offset: 0x0003C020
		public unsafe bool2 zy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zy_Public_get_bool2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_zy_Public_set_Void_bool2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x0003DE54 File Offset: 0x0003C054
		public unsafe bool2 zz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zz_Public_get_bool2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x0003DE84 File Offset: 0x0003C084
		// (set) Token: 0x06000AC4 RID: 2756 RVA: 0x0003DEB4 File Offset: 0x0003C0B4
		public unsafe bool2 zw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_zw_Public_get_bool2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_zw_Public_set_Void_bool2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x0003DEE8 File Offset: 0x0003C0E8
		// (set) Token: 0x06000AC6 RID: 2758 RVA: 0x0003DF18 File Offset: 0x0003C118
		public unsafe bool2 wx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wx_Public_get_bool2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_wx_Public_set_Void_bool2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000AC7 RID: 2759 RVA: 0x0003DF4C File Offset: 0x0003C14C
		// (set) Token: 0x06000AC8 RID: 2760 RVA: 0x0003DF7C File Offset: 0x0003C17C
		public unsafe bool2 wy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wy_Public_get_bool2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_wy_Public_set_Void_bool2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000AC9 RID: 2761 RVA: 0x0003DFB0 File Offset: 0x0003C1B0
		// (set) Token: 0x06000ACA RID: 2762 RVA: 0x0003DFE0 File Offset: 0x0003C1E0
		public unsafe bool2 wz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_wz_Public_get_bool2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_wz_Public_set_Void_bool2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000ACB RID: 2763 RVA: 0x0003E014 File Offset: 0x0003C214
		public unsafe bool2 ww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_ww_Public_get_bool2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000200 RID: 512
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_get_Item_Public_get_Boolean_Int32_0, ref this, (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x0003E0C4 File Offset: 0x0003C2C4
		[CallerCount(0)]
		public unsafe bool Equals(bool4 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x0003E104 File Offset: 0x0003C304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634571, XrefRangeEnd = 634574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x0003E148 File Offset: 0x0003C348
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x0003E178 File Offset: 0x0003C378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634574, XrefRangeEnd = 634597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x00002268 File Offset: 0x00000468
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<bool4>.NativeClassPtr, ref this));
		}

		// Token: 0x04000927 RID: 2343
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x04000928 RID: 2344
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04000929 RID: 2345
		private static readonly IntPtr NativeFieldInfoPtr_z;

		// Token: 0x0400092A RID: 2346
		private static readonly IntPtr NativeFieldInfoPtr_w;

		// Token: 0x0400092B RID: 2347
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_Boolean_0;

		// Token: 0x0400092C RID: 2348
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_bool2_0;

		// Token: 0x0400092D RID: 2349
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_bool2_Boolean_0;

		// Token: 0x0400092E RID: 2350
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_bool3_0;

		// Token: 0x0400092F RID: 2351
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool2_Boolean_Boolean_0;

		// Token: 0x04000930 RID: 2352
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool2_bool2_0;

		// Token: 0x04000931 RID: 2353
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool3_Boolean_0;

		// Token: 0x04000932 RID: 2354
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool4_0;

		// Token: 0x04000933 RID: 2355
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04000934 RID: 2356
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_bool4_Boolean_0;

		// Token: 0x04000935 RID: 2357
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4_bool4_bool4_0;

		// Token: 0x04000936 RID: 2358
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4_bool4_Boolean_0;

		// Token: 0x04000937 RID: 2359
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4_Boolean_bool4_0;

		// Token: 0x04000938 RID: 2360
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_bool4_bool4_0;

		// Token: 0x04000939 RID: 2361
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_bool4_Boolean_0;

		// Token: 0x0400093A RID: 2362
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_Boolean_bool4_0;

		// Token: 0x0400093B RID: 2363
		private static readonly IntPtr NativeMethodInfoPtr_op_LogicalNot_Public_Static_bool4_bool4_0;

		// Token: 0x0400093C RID: 2364
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool4_bool4_bool4_0;

		// Token: 0x0400093D RID: 2365
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool4_bool4_Boolean_0;

		// Token: 0x0400093E RID: 2366
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_bool4_Boolean_bool4_0;

		// Token: 0x0400093F RID: 2367
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool4_bool4_bool4_0;

		// Token: 0x04000940 RID: 2368
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool4_bool4_Boolean_0;

		// Token: 0x04000941 RID: 2369
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_bool4_Boolean_bool4_0;

		// Token: 0x04000942 RID: 2370
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool4_bool4_bool4_0;

		// Token: 0x04000943 RID: 2371
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool4_bool4_Boolean_0;

		// Token: 0x04000944 RID: 2372
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_bool4_Boolean_bool4_0;

		// Token: 0x04000945 RID: 2373
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxx_Public_get_bool4_0;

		// Token: 0x04000946 RID: 2374
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxy_Public_get_bool4_0;

		// Token: 0x04000947 RID: 2375
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxz_Public_get_bool4_0;

		// Token: 0x04000948 RID: 2376
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxw_Public_get_bool4_0;

		// Token: 0x04000949 RID: 2377
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyx_Public_get_bool4_0;

		// Token: 0x0400094A RID: 2378
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyy_Public_get_bool4_0;

		// Token: 0x0400094B RID: 2379
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyz_Public_get_bool4_0;

		// Token: 0x0400094C RID: 2380
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyw_Public_get_bool4_0;

		// Token: 0x0400094D RID: 2381
		private static readonly IntPtr NativeMethodInfoPtr_get_xxzx_Public_get_bool4_0;

		// Token: 0x0400094E RID: 2382
		private static readonly IntPtr NativeMethodInfoPtr_get_xxzy_Public_get_bool4_0;

		// Token: 0x0400094F RID: 2383
		private static readonly IntPtr NativeMethodInfoPtr_get_xxzz_Public_get_bool4_0;

		// Token: 0x04000950 RID: 2384
		private static readonly IntPtr NativeMethodInfoPtr_get_xxzw_Public_get_bool4_0;

		// Token: 0x04000951 RID: 2385
		private static readonly IntPtr NativeMethodInfoPtr_get_xxwx_Public_get_bool4_0;

		// Token: 0x04000952 RID: 2386
		private static readonly IntPtr NativeMethodInfoPtr_get_xxwy_Public_get_bool4_0;

		// Token: 0x04000953 RID: 2387
		private static readonly IntPtr NativeMethodInfoPtr_get_xxwz_Public_get_bool4_0;

		// Token: 0x04000954 RID: 2388
		private static readonly IntPtr NativeMethodInfoPtr_get_xxww_Public_get_bool4_0;

		// Token: 0x04000955 RID: 2389
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxx_Public_get_bool4_0;

		// Token: 0x04000956 RID: 2390
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxy_Public_get_bool4_0;

		// Token: 0x04000957 RID: 2391
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxz_Public_get_bool4_0;

		// Token: 0x04000958 RID: 2392
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxw_Public_get_bool4_0;

		// Token: 0x04000959 RID: 2393
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyx_Public_get_bool4_0;

		// Token: 0x0400095A RID: 2394
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyy_Public_get_bool4_0;

		// Token: 0x0400095B RID: 2395
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyz_Public_get_bool4_0;

		// Token: 0x0400095C RID: 2396
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyw_Public_get_bool4_0;

		// Token: 0x0400095D RID: 2397
		private static readonly IntPtr NativeMethodInfoPtr_get_xyzx_Public_get_bool4_0;

		// Token: 0x0400095E RID: 2398
		private static readonly IntPtr NativeMethodInfoPtr_get_xyzy_Public_get_bool4_0;

		// Token: 0x0400095F RID: 2399
		private static readonly IntPtr NativeMethodInfoPtr_get_xyzz_Public_get_bool4_0;

		// Token: 0x04000960 RID: 2400
		private static readonly IntPtr NativeMethodInfoPtr_get_xyzw_Public_get_bool4_0;

		// Token: 0x04000961 RID: 2401
		private static readonly IntPtr NativeMethodInfoPtr_set_xyzw_Public_set_Void_bool4_0;

		// Token: 0x04000962 RID: 2402
		private static readonly IntPtr NativeMethodInfoPtr_get_xywx_Public_get_bool4_0;

		// Token: 0x04000963 RID: 2403
		private static readonly IntPtr NativeMethodInfoPtr_get_xywy_Public_get_bool4_0;

		// Token: 0x04000964 RID: 2404
		private static readonly IntPtr NativeMethodInfoPtr_get_xywz_Public_get_bool4_0;

		// Token: 0x04000965 RID: 2405
		private static readonly IntPtr NativeMethodInfoPtr_set_xywz_Public_set_Void_bool4_0;

		// Token: 0x04000966 RID: 2406
		private static readonly IntPtr NativeMethodInfoPtr_get_xyww_Public_get_bool4_0;

		// Token: 0x04000967 RID: 2407
		private static readonly IntPtr NativeMethodInfoPtr_get_xzxx_Public_get_bool4_0;

		// Token: 0x04000968 RID: 2408
		private static readonly IntPtr NativeMethodInfoPtr_get_xzxy_Public_get_bool4_0;

		// Token: 0x04000969 RID: 2409
		private static readonly IntPtr NativeMethodInfoPtr_get_xzxz_Public_get_bool4_0;

		// Token: 0x0400096A RID: 2410
		private static readonly IntPtr NativeMethodInfoPtr_get_xzxw_Public_get_bool4_0;

		// Token: 0x0400096B RID: 2411
		private static readonly IntPtr NativeMethodInfoPtr_get_xzyx_Public_get_bool4_0;

		// Token: 0x0400096C RID: 2412
		private static readonly IntPtr NativeMethodInfoPtr_get_xzyy_Public_get_bool4_0;

		// Token: 0x0400096D RID: 2413
		private static readonly IntPtr NativeMethodInfoPtr_get_xzyz_Public_get_bool4_0;

		// Token: 0x0400096E RID: 2414
		private static readonly IntPtr NativeMethodInfoPtr_get_xzyw_Public_get_bool4_0;

		// Token: 0x0400096F RID: 2415
		private static readonly IntPtr NativeMethodInfoPtr_set_xzyw_Public_set_Void_bool4_0;

		// Token: 0x04000970 RID: 2416
		private static readonly IntPtr NativeMethodInfoPtr_get_xzzx_Public_get_bool4_0;

		// Token: 0x04000971 RID: 2417
		private static readonly IntPtr NativeMethodInfoPtr_get_xzzy_Public_get_bool4_0;

		// Token: 0x04000972 RID: 2418
		private static readonly IntPtr NativeMethodInfoPtr_get_xzzz_Public_get_bool4_0;

		// Token: 0x04000973 RID: 2419
		private static readonly IntPtr NativeMethodInfoPtr_get_xzzw_Public_get_bool4_0;

		// Token: 0x04000974 RID: 2420
		private static readonly IntPtr NativeMethodInfoPtr_get_xzwx_Public_get_bool4_0;

		// Token: 0x04000975 RID: 2421
		private static readonly IntPtr NativeMethodInfoPtr_get_xzwy_Public_get_bool4_0;

		// Token: 0x04000976 RID: 2422
		private static readonly IntPtr NativeMethodInfoPtr_set_xzwy_Public_set_Void_bool4_0;

		// Token: 0x04000977 RID: 2423
		private static readonly IntPtr NativeMethodInfoPtr_get_xzwz_Public_get_bool4_0;

		// Token: 0x04000978 RID: 2424
		private static readonly IntPtr NativeMethodInfoPtr_get_xzww_Public_get_bool4_0;

		// Token: 0x04000979 RID: 2425
		private static readonly IntPtr NativeMethodInfoPtr_get_xwxx_Public_get_bool4_0;

		// Token: 0x0400097A RID: 2426
		private static readonly IntPtr NativeMethodInfoPtr_get_xwxy_Public_get_bool4_0;

		// Token: 0x0400097B RID: 2427
		private static readonly IntPtr NativeMethodInfoPtr_get_xwxz_Public_get_bool4_0;

		// Token: 0x0400097C RID: 2428
		private static readonly IntPtr NativeMethodInfoPtr_get_xwxw_Public_get_bool4_0;

		// Token: 0x0400097D RID: 2429
		private static readonly IntPtr NativeMethodInfoPtr_get_xwyx_Public_get_bool4_0;

		// Token: 0x0400097E RID: 2430
		private static readonly IntPtr NativeMethodInfoPtr_get_xwyy_Public_get_bool4_0;

		// Token: 0x0400097F RID: 2431
		private static readonly IntPtr NativeMethodInfoPtr_get_xwyz_Public_get_bool4_0;

		// Token: 0x04000980 RID: 2432
		private static readonly IntPtr NativeMethodInfoPtr_set_xwyz_Public_set_Void_bool4_0;

		// Token: 0x04000981 RID: 2433
		private static readonly IntPtr NativeMethodInfoPtr_get_xwyw_Public_get_bool4_0;

		// Token: 0x04000982 RID: 2434
		private static readonly IntPtr NativeMethodInfoPtr_get_xwzx_Public_get_bool4_0;

		// Token: 0x04000983 RID: 2435
		private static readonly IntPtr NativeMethodInfoPtr_get_xwzy_Public_get_bool4_0;

		// Token: 0x04000984 RID: 2436
		private static readonly IntPtr NativeMethodInfoPtr_set_xwzy_Public_set_Void_bool4_0;

		// Token: 0x04000985 RID: 2437
		private static readonly IntPtr NativeMethodInfoPtr_get_xwzz_Public_get_bool4_0;

		// Token: 0x04000986 RID: 2438
		private static readonly IntPtr NativeMethodInfoPtr_get_xwzw_Public_get_bool4_0;

		// Token: 0x04000987 RID: 2439
		private static readonly IntPtr NativeMethodInfoPtr_get_xwwx_Public_get_bool4_0;

		// Token: 0x04000988 RID: 2440
		private static readonly IntPtr NativeMethodInfoPtr_get_xwwy_Public_get_bool4_0;

		// Token: 0x04000989 RID: 2441
		private static readonly IntPtr NativeMethodInfoPtr_get_xwwz_Public_get_bool4_0;

		// Token: 0x0400098A RID: 2442
		private static readonly IntPtr NativeMethodInfoPtr_get_xwww_Public_get_bool4_0;

		// Token: 0x0400098B RID: 2443
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxx_Public_get_bool4_0;

		// Token: 0x0400098C RID: 2444
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxy_Public_get_bool4_0;

		// Token: 0x0400098D RID: 2445
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxz_Public_get_bool4_0;

		// Token: 0x0400098E RID: 2446
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxw_Public_get_bool4_0;

		// Token: 0x0400098F RID: 2447
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyx_Public_get_bool4_0;

		// Token: 0x04000990 RID: 2448
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyy_Public_get_bool4_0;

		// Token: 0x04000991 RID: 2449
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyz_Public_get_bool4_0;

		// Token: 0x04000992 RID: 2450
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyw_Public_get_bool4_0;

		// Token: 0x04000993 RID: 2451
		private static readonly IntPtr NativeMethodInfoPtr_get_yxzx_Public_get_bool4_0;

		// Token: 0x04000994 RID: 2452
		private static readonly IntPtr NativeMethodInfoPtr_get_yxzy_Public_get_bool4_0;

		// Token: 0x04000995 RID: 2453
		private static readonly IntPtr NativeMethodInfoPtr_get_yxzz_Public_get_bool4_0;

		// Token: 0x04000996 RID: 2454
		private static readonly IntPtr NativeMethodInfoPtr_get_yxzw_Public_get_bool4_0;

		// Token: 0x04000997 RID: 2455
		private static readonly IntPtr NativeMethodInfoPtr_set_yxzw_Public_set_Void_bool4_0;

		// Token: 0x04000998 RID: 2456
		private static readonly IntPtr NativeMethodInfoPtr_get_yxwx_Public_get_bool4_0;

		// Token: 0x04000999 RID: 2457
		private static readonly IntPtr NativeMethodInfoPtr_get_yxwy_Public_get_bool4_0;

		// Token: 0x0400099A RID: 2458
		private static readonly IntPtr NativeMethodInfoPtr_get_yxwz_Public_get_bool4_0;

		// Token: 0x0400099B RID: 2459
		private static readonly IntPtr NativeMethodInfoPtr_set_yxwz_Public_set_Void_bool4_0;

		// Token: 0x0400099C RID: 2460
		private static readonly IntPtr NativeMethodInfoPtr_get_yxww_Public_get_bool4_0;

		// Token: 0x0400099D RID: 2461
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxx_Public_get_bool4_0;

		// Token: 0x0400099E RID: 2462
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxy_Public_get_bool4_0;

		// Token: 0x0400099F RID: 2463
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxz_Public_get_bool4_0;

		// Token: 0x040009A0 RID: 2464
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxw_Public_get_bool4_0;

		// Token: 0x040009A1 RID: 2465
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyx_Public_get_bool4_0;

		// Token: 0x040009A2 RID: 2466
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyy_Public_get_bool4_0;

		// Token: 0x040009A3 RID: 2467
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyz_Public_get_bool4_0;

		// Token: 0x040009A4 RID: 2468
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyw_Public_get_bool4_0;

		// Token: 0x040009A5 RID: 2469
		private static readonly IntPtr NativeMethodInfoPtr_get_yyzx_Public_get_bool4_0;

		// Token: 0x040009A6 RID: 2470
		private static readonly IntPtr NativeMethodInfoPtr_get_yyzy_Public_get_bool4_0;

		// Token: 0x040009A7 RID: 2471
		private static readonly IntPtr NativeMethodInfoPtr_get_yyzz_Public_get_bool4_0;

		// Token: 0x040009A8 RID: 2472
		private static readonly IntPtr NativeMethodInfoPtr_get_yyzw_Public_get_bool4_0;

		// Token: 0x040009A9 RID: 2473
		private static readonly IntPtr NativeMethodInfoPtr_get_yywx_Public_get_bool4_0;

		// Token: 0x040009AA RID: 2474
		private static readonly IntPtr NativeMethodInfoPtr_get_yywy_Public_get_bool4_0;

		// Token: 0x040009AB RID: 2475
		private static readonly IntPtr NativeMethodInfoPtr_get_yywz_Public_get_bool4_0;

		// Token: 0x040009AC RID: 2476
		private static readonly IntPtr NativeMethodInfoPtr_get_yyww_Public_get_bool4_0;

		// Token: 0x040009AD RID: 2477
		private static readonly IntPtr NativeMethodInfoPtr_get_yzxx_Public_get_bool4_0;

		// Token: 0x040009AE RID: 2478
		private static readonly IntPtr NativeMethodInfoPtr_get_yzxy_Public_get_bool4_0;

		// Token: 0x040009AF RID: 2479
		private static readonly IntPtr NativeMethodInfoPtr_get_yzxz_Public_get_bool4_0;

		// Token: 0x040009B0 RID: 2480
		private static readonly IntPtr NativeMethodInfoPtr_get_yzxw_Public_get_bool4_0;

		// Token: 0x040009B1 RID: 2481
		private static readonly IntPtr NativeMethodInfoPtr_set_yzxw_Public_set_Void_bool4_0;

		// Token: 0x040009B2 RID: 2482
		private static readonly IntPtr NativeMethodInfoPtr_get_yzyx_Public_get_bool4_0;

		// Token: 0x040009B3 RID: 2483
		private static readonly IntPtr NativeMethodInfoPtr_get_yzyy_Public_get_bool4_0;

		// Token: 0x040009B4 RID: 2484
		private static readonly IntPtr NativeMethodInfoPtr_get_yzyz_Public_get_bool4_0;

		// Token: 0x040009B5 RID: 2485
		private static readonly IntPtr NativeMethodInfoPtr_get_yzyw_Public_get_bool4_0;

		// Token: 0x040009B6 RID: 2486
		private static readonly IntPtr NativeMethodInfoPtr_get_yzzx_Public_get_bool4_0;

		// Token: 0x040009B7 RID: 2487
		private static readonly IntPtr NativeMethodInfoPtr_get_yzzy_Public_get_bool4_0;

		// Token: 0x040009B8 RID: 2488
		private static readonly IntPtr NativeMethodInfoPtr_get_yzzz_Public_get_bool4_0;

		// Token: 0x040009B9 RID: 2489
		private static readonly IntPtr NativeMethodInfoPtr_get_yzzw_Public_get_bool4_0;

		// Token: 0x040009BA RID: 2490
		private static readonly IntPtr NativeMethodInfoPtr_get_yzwx_Public_get_bool4_0;

		// Token: 0x040009BB RID: 2491
		private static readonly IntPtr NativeMethodInfoPtr_set_yzwx_Public_set_Void_bool4_0;

		// Token: 0x040009BC RID: 2492
		private static readonly IntPtr NativeMethodInfoPtr_get_yzwy_Public_get_bool4_0;

		// Token: 0x040009BD RID: 2493
		private static readonly IntPtr NativeMethodInfoPtr_get_yzwz_Public_get_bool4_0;

		// Token: 0x040009BE RID: 2494
		private static readonly IntPtr NativeMethodInfoPtr_get_yzww_Public_get_bool4_0;

		// Token: 0x040009BF RID: 2495
		private static readonly IntPtr NativeMethodInfoPtr_get_ywxx_Public_get_bool4_0;

		// Token: 0x040009C0 RID: 2496
		private static readonly IntPtr NativeMethodInfoPtr_get_ywxy_Public_get_bool4_0;

		// Token: 0x040009C1 RID: 2497
		private static readonly IntPtr NativeMethodInfoPtr_get_ywxz_Public_get_bool4_0;

		// Token: 0x040009C2 RID: 2498
		private static readonly IntPtr NativeMethodInfoPtr_set_ywxz_Public_set_Void_bool4_0;

		// Token: 0x040009C3 RID: 2499
		private static readonly IntPtr NativeMethodInfoPtr_get_ywxw_Public_get_bool4_0;

		// Token: 0x040009C4 RID: 2500
		private static readonly IntPtr NativeMethodInfoPtr_get_ywyx_Public_get_bool4_0;

		// Token: 0x040009C5 RID: 2501
		private static readonly IntPtr NativeMethodInfoPtr_get_ywyy_Public_get_bool4_0;

		// Token: 0x040009C6 RID: 2502
		private static readonly IntPtr NativeMethodInfoPtr_get_ywyz_Public_get_bool4_0;

		// Token: 0x040009C7 RID: 2503
		private static readonly IntPtr NativeMethodInfoPtr_get_ywyw_Public_get_bool4_0;

		// Token: 0x040009C8 RID: 2504
		private static readonly IntPtr NativeMethodInfoPtr_get_ywzx_Public_get_bool4_0;

		// Token: 0x040009C9 RID: 2505
		private static readonly IntPtr NativeMethodInfoPtr_set_ywzx_Public_set_Void_bool4_0;

		// Token: 0x040009CA RID: 2506
		private static readonly IntPtr NativeMethodInfoPtr_get_ywzy_Public_get_bool4_0;

		// Token: 0x040009CB RID: 2507
		private static readonly IntPtr NativeMethodInfoPtr_get_ywzz_Public_get_bool4_0;

		// Token: 0x040009CC RID: 2508
		private static readonly IntPtr NativeMethodInfoPtr_get_ywzw_Public_get_bool4_0;

		// Token: 0x040009CD RID: 2509
		private static readonly IntPtr NativeMethodInfoPtr_get_ywwx_Public_get_bool4_0;

		// Token: 0x040009CE RID: 2510
		private static readonly IntPtr NativeMethodInfoPtr_get_ywwy_Public_get_bool4_0;

		// Token: 0x040009CF RID: 2511
		private static readonly IntPtr NativeMethodInfoPtr_get_ywwz_Public_get_bool4_0;

		// Token: 0x040009D0 RID: 2512
		private static readonly IntPtr NativeMethodInfoPtr_get_ywww_Public_get_bool4_0;

		// Token: 0x040009D1 RID: 2513
		private static readonly IntPtr NativeMethodInfoPtr_get_zxxx_Public_get_bool4_0;

		// Token: 0x040009D2 RID: 2514
		private static readonly IntPtr NativeMethodInfoPtr_get_zxxy_Public_get_bool4_0;

		// Token: 0x040009D3 RID: 2515
		private static readonly IntPtr NativeMethodInfoPtr_get_zxxz_Public_get_bool4_0;

		// Token: 0x040009D4 RID: 2516
		private static readonly IntPtr NativeMethodInfoPtr_get_zxxw_Public_get_bool4_0;

		// Token: 0x040009D5 RID: 2517
		private static readonly IntPtr NativeMethodInfoPtr_get_zxyx_Public_get_bool4_0;

		// Token: 0x040009D6 RID: 2518
		private static readonly IntPtr NativeMethodInfoPtr_get_zxyy_Public_get_bool4_0;

		// Token: 0x040009D7 RID: 2519
		private static readonly IntPtr NativeMethodInfoPtr_get_zxyz_Public_get_bool4_0;

		// Token: 0x040009D8 RID: 2520
		private static readonly IntPtr NativeMethodInfoPtr_get_zxyw_Public_get_bool4_0;

		// Token: 0x040009D9 RID: 2521
		private static readonly IntPtr NativeMethodInfoPtr_set_zxyw_Public_set_Void_bool4_0;

		// Token: 0x040009DA RID: 2522
		private static readonly IntPtr NativeMethodInfoPtr_get_zxzx_Public_get_bool4_0;

		// Token: 0x040009DB RID: 2523
		private static readonly IntPtr NativeMethodInfoPtr_get_zxzy_Public_get_bool4_0;

		// Token: 0x040009DC RID: 2524
		private static readonly IntPtr NativeMethodInfoPtr_get_zxzz_Public_get_bool4_0;

		// Token: 0x040009DD RID: 2525
		private static readonly IntPtr NativeMethodInfoPtr_get_zxzw_Public_get_bool4_0;

		// Token: 0x040009DE RID: 2526
		private static readonly IntPtr NativeMethodInfoPtr_get_zxwx_Public_get_bool4_0;

		// Token: 0x040009DF RID: 2527
		private static readonly IntPtr NativeMethodInfoPtr_get_zxwy_Public_get_bool4_0;

		// Token: 0x040009E0 RID: 2528
		private static readonly IntPtr NativeMethodInfoPtr_set_zxwy_Public_set_Void_bool4_0;

		// Token: 0x040009E1 RID: 2529
		private static readonly IntPtr NativeMethodInfoPtr_get_zxwz_Public_get_bool4_0;

		// Token: 0x040009E2 RID: 2530
		private static readonly IntPtr NativeMethodInfoPtr_get_zxww_Public_get_bool4_0;

		// Token: 0x040009E3 RID: 2531
		private static readonly IntPtr NativeMethodInfoPtr_get_zyxx_Public_get_bool4_0;

		// Token: 0x040009E4 RID: 2532
		private static readonly IntPtr NativeMethodInfoPtr_get_zyxy_Public_get_bool4_0;

		// Token: 0x040009E5 RID: 2533
		private static readonly IntPtr NativeMethodInfoPtr_get_zyxz_Public_get_bool4_0;

		// Token: 0x040009E6 RID: 2534
		private static readonly IntPtr NativeMethodInfoPtr_get_zyxw_Public_get_bool4_0;

		// Token: 0x040009E7 RID: 2535
		private static readonly IntPtr NativeMethodInfoPtr_set_zyxw_Public_set_Void_bool4_0;

		// Token: 0x040009E8 RID: 2536
		private static readonly IntPtr NativeMethodInfoPtr_get_zyyx_Public_get_bool4_0;

		// Token: 0x040009E9 RID: 2537
		private static readonly IntPtr NativeMethodInfoPtr_get_zyyy_Public_get_bool4_0;

		// Token: 0x040009EA RID: 2538
		private static readonly IntPtr NativeMethodInfoPtr_get_zyyz_Public_get_bool4_0;

		// Token: 0x040009EB RID: 2539
		private static readonly IntPtr NativeMethodInfoPtr_get_zyyw_Public_get_bool4_0;

		// Token: 0x040009EC RID: 2540
		private static readonly IntPtr NativeMethodInfoPtr_get_zyzx_Public_get_bool4_0;

		// Token: 0x040009ED RID: 2541
		private static readonly IntPtr NativeMethodInfoPtr_get_zyzy_Public_get_bool4_0;

		// Token: 0x040009EE RID: 2542
		private static readonly IntPtr NativeMethodInfoPtr_get_zyzz_Public_get_bool4_0;

		// Token: 0x040009EF RID: 2543
		private static readonly IntPtr NativeMethodInfoPtr_get_zyzw_Public_get_bool4_0;

		// Token: 0x040009F0 RID: 2544
		private static readonly IntPtr NativeMethodInfoPtr_get_zywx_Public_get_bool4_0;

		// Token: 0x040009F1 RID: 2545
		private static readonly IntPtr NativeMethodInfoPtr_set_zywx_Public_set_Void_bool4_0;

		// Token: 0x040009F2 RID: 2546
		private static readonly IntPtr NativeMethodInfoPtr_get_zywy_Public_get_bool4_0;

		// Token: 0x040009F3 RID: 2547
		private static readonly IntPtr NativeMethodInfoPtr_get_zywz_Public_get_bool4_0;

		// Token: 0x040009F4 RID: 2548
		private static readonly IntPtr NativeMethodInfoPtr_get_zyww_Public_get_bool4_0;

		// Token: 0x040009F5 RID: 2549
		private static readonly IntPtr NativeMethodInfoPtr_get_zzxx_Public_get_bool4_0;

		// Token: 0x040009F6 RID: 2550
		private static readonly IntPtr NativeMethodInfoPtr_get_zzxy_Public_get_bool4_0;

		// Token: 0x040009F7 RID: 2551
		private static readonly IntPtr NativeMethodInfoPtr_get_zzxz_Public_get_bool4_0;

		// Token: 0x040009F8 RID: 2552
		private static readonly IntPtr NativeMethodInfoPtr_get_zzxw_Public_get_bool4_0;

		// Token: 0x040009F9 RID: 2553
		private static readonly IntPtr NativeMethodInfoPtr_get_zzyx_Public_get_bool4_0;

		// Token: 0x040009FA RID: 2554
		private static readonly IntPtr NativeMethodInfoPtr_get_zzyy_Public_get_bool4_0;

		// Token: 0x040009FB RID: 2555
		private static readonly IntPtr NativeMethodInfoPtr_get_zzyz_Public_get_bool4_0;

		// Token: 0x040009FC RID: 2556
		private static readonly IntPtr NativeMethodInfoPtr_get_zzyw_Public_get_bool4_0;

		// Token: 0x040009FD RID: 2557
		private static readonly IntPtr NativeMethodInfoPtr_get_zzzx_Public_get_bool4_0;

		// Token: 0x040009FE RID: 2558
		private static readonly IntPtr NativeMethodInfoPtr_get_zzzy_Public_get_bool4_0;

		// Token: 0x040009FF RID: 2559
		private static readonly IntPtr NativeMethodInfoPtr_get_zzzz_Public_get_bool4_0;

		// Token: 0x04000A00 RID: 2560
		private static readonly IntPtr NativeMethodInfoPtr_get_zzzw_Public_get_bool4_0;

		// Token: 0x04000A01 RID: 2561
		private static readonly IntPtr NativeMethodInfoPtr_get_zzwx_Public_get_bool4_0;

		// Token: 0x04000A02 RID: 2562
		private static readonly IntPtr NativeMethodInfoPtr_get_zzwy_Public_get_bool4_0;

		// Token: 0x04000A03 RID: 2563
		private static readonly IntPtr NativeMethodInfoPtr_get_zzwz_Public_get_bool4_0;

		// Token: 0x04000A04 RID: 2564
		private static readonly IntPtr NativeMethodInfoPtr_get_zzww_Public_get_bool4_0;

		// Token: 0x04000A05 RID: 2565
		private static readonly IntPtr NativeMethodInfoPtr_get_zwxx_Public_get_bool4_0;

		// Token: 0x04000A06 RID: 2566
		private static readonly IntPtr NativeMethodInfoPtr_get_zwxy_Public_get_bool4_0;

		// Token: 0x04000A07 RID: 2567
		private static readonly IntPtr NativeMethodInfoPtr_set_zwxy_Public_set_Void_bool4_0;

		// Token: 0x04000A08 RID: 2568
		private static readonly IntPtr NativeMethodInfoPtr_get_zwxz_Public_get_bool4_0;

		// Token: 0x04000A09 RID: 2569
		private static readonly IntPtr NativeMethodInfoPtr_get_zwxw_Public_get_bool4_0;

		// Token: 0x04000A0A RID: 2570
		private static readonly IntPtr NativeMethodInfoPtr_get_zwyx_Public_get_bool4_0;

		// Token: 0x04000A0B RID: 2571
		private static readonly IntPtr NativeMethodInfoPtr_set_zwyx_Public_set_Void_bool4_0;

		// Token: 0x04000A0C RID: 2572
		private static readonly IntPtr NativeMethodInfoPtr_get_zwyy_Public_get_bool4_0;

		// Token: 0x04000A0D RID: 2573
		private static readonly IntPtr NativeMethodInfoPtr_get_zwyz_Public_get_bool4_0;

		// Token: 0x04000A0E RID: 2574
		private static readonly IntPtr NativeMethodInfoPtr_get_zwyw_Public_get_bool4_0;

		// Token: 0x04000A0F RID: 2575
		private static readonly IntPtr NativeMethodInfoPtr_get_zwzx_Public_get_bool4_0;

		// Token: 0x04000A10 RID: 2576
		private static readonly IntPtr NativeMethodInfoPtr_get_zwzy_Public_get_bool4_0;

		// Token: 0x04000A11 RID: 2577
		private static readonly IntPtr NativeMethodInfoPtr_get_zwzz_Public_get_bool4_0;

		// Token: 0x04000A12 RID: 2578
		private static readonly IntPtr NativeMethodInfoPtr_get_zwzw_Public_get_bool4_0;

		// Token: 0x04000A13 RID: 2579
		private static readonly IntPtr NativeMethodInfoPtr_get_zwwx_Public_get_bool4_0;

		// Token: 0x04000A14 RID: 2580
		private static readonly IntPtr NativeMethodInfoPtr_get_zwwy_Public_get_bool4_0;

		// Token: 0x04000A15 RID: 2581
		private static readonly IntPtr NativeMethodInfoPtr_get_zwwz_Public_get_bool4_0;

		// Token: 0x04000A16 RID: 2582
		private static readonly IntPtr NativeMethodInfoPtr_get_zwww_Public_get_bool4_0;

		// Token: 0x04000A17 RID: 2583
		private static readonly IntPtr NativeMethodInfoPtr_get_wxxx_Public_get_bool4_0;

		// Token: 0x04000A18 RID: 2584
		private static readonly IntPtr NativeMethodInfoPtr_get_wxxy_Public_get_bool4_0;

		// Token: 0x04000A19 RID: 2585
		private static readonly IntPtr NativeMethodInfoPtr_get_wxxz_Public_get_bool4_0;

		// Token: 0x04000A1A RID: 2586
		private static readonly IntPtr NativeMethodInfoPtr_get_wxxw_Public_get_bool4_0;

		// Token: 0x04000A1B RID: 2587
		private static readonly IntPtr NativeMethodInfoPtr_get_wxyx_Public_get_bool4_0;

		// Token: 0x04000A1C RID: 2588
		private static readonly IntPtr NativeMethodInfoPtr_get_wxyy_Public_get_bool4_0;

		// Token: 0x04000A1D RID: 2589
		private static readonly IntPtr NativeMethodInfoPtr_get_wxyz_Public_get_bool4_0;

		// Token: 0x04000A1E RID: 2590
		private static readonly IntPtr NativeMethodInfoPtr_set_wxyz_Public_set_Void_bool4_0;

		// Token: 0x04000A1F RID: 2591
		private static readonly IntPtr NativeMethodInfoPtr_get_wxyw_Public_get_bool4_0;

		// Token: 0x04000A20 RID: 2592
		private static readonly IntPtr NativeMethodInfoPtr_get_wxzx_Public_get_bool4_0;

		// Token: 0x04000A21 RID: 2593
		private static readonly IntPtr NativeMethodInfoPtr_get_wxzy_Public_get_bool4_0;

		// Token: 0x04000A22 RID: 2594
		private static readonly IntPtr NativeMethodInfoPtr_set_wxzy_Public_set_Void_bool4_0;

		// Token: 0x04000A23 RID: 2595
		private static readonly IntPtr NativeMethodInfoPtr_get_wxzz_Public_get_bool4_0;

		// Token: 0x04000A24 RID: 2596
		private static readonly IntPtr NativeMethodInfoPtr_get_wxzw_Public_get_bool4_0;

		// Token: 0x04000A25 RID: 2597
		private static readonly IntPtr NativeMethodInfoPtr_get_wxwx_Public_get_bool4_0;

		// Token: 0x04000A26 RID: 2598
		private static readonly IntPtr NativeMethodInfoPtr_get_wxwy_Public_get_bool4_0;

		// Token: 0x04000A27 RID: 2599
		private static readonly IntPtr NativeMethodInfoPtr_get_wxwz_Public_get_bool4_0;

		// Token: 0x04000A28 RID: 2600
		private static readonly IntPtr NativeMethodInfoPtr_get_wxww_Public_get_bool4_0;

		// Token: 0x04000A29 RID: 2601
		private static readonly IntPtr NativeMethodInfoPtr_get_wyxx_Public_get_bool4_0;

		// Token: 0x04000A2A RID: 2602
		private static readonly IntPtr NativeMethodInfoPtr_get_wyxy_Public_get_bool4_0;

		// Token: 0x04000A2B RID: 2603
		private static readonly IntPtr NativeMethodInfoPtr_get_wyxz_Public_get_bool4_0;

		// Token: 0x04000A2C RID: 2604
		private static readonly IntPtr NativeMethodInfoPtr_set_wyxz_Public_set_Void_bool4_0;

		// Token: 0x04000A2D RID: 2605
		private static readonly IntPtr NativeMethodInfoPtr_get_wyxw_Public_get_bool4_0;

		// Token: 0x04000A2E RID: 2606
		private static readonly IntPtr NativeMethodInfoPtr_get_wyyx_Public_get_bool4_0;

		// Token: 0x04000A2F RID: 2607
		private static readonly IntPtr NativeMethodInfoPtr_get_wyyy_Public_get_bool4_0;

		// Token: 0x04000A30 RID: 2608
		private static readonly IntPtr NativeMethodInfoPtr_get_wyyz_Public_get_bool4_0;

		// Token: 0x04000A31 RID: 2609
		private static readonly IntPtr NativeMethodInfoPtr_get_wyyw_Public_get_bool4_0;

		// Token: 0x04000A32 RID: 2610
		private static readonly IntPtr NativeMethodInfoPtr_get_wyzx_Public_get_bool4_0;

		// Token: 0x04000A33 RID: 2611
		private static readonly IntPtr NativeMethodInfoPtr_set_wyzx_Public_set_Void_bool4_0;

		// Token: 0x04000A34 RID: 2612
		private static readonly IntPtr NativeMethodInfoPtr_get_wyzy_Public_get_bool4_0;

		// Token: 0x04000A35 RID: 2613
		private static readonly IntPtr NativeMethodInfoPtr_get_wyzz_Public_get_bool4_0;

		// Token: 0x04000A36 RID: 2614
		private static readonly IntPtr NativeMethodInfoPtr_get_wyzw_Public_get_bool4_0;

		// Token: 0x04000A37 RID: 2615
		private static readonly IntPtr NativeMethodInfoPtr_get_wywx_Public_get_bool4_0;

		// Token: 0x04000A38 RID: 2616
		private static readonly IntPtr NativeMethodInfoPtr_get_wywy_Public_get_bool4_0;

		// Token: 0x04000A39 RID: 2617
		private static readonly IntPtr NativeMethodInfoPtr_get_wywz_Public_get_bool4_0;

		// Token: 0x04000A3A RID: 2618
		private static readonly IntPtr NativeMethodInfoPtr_get_wyww_Public_get_bool4_0;

		// Token: 0x04000A3B RID: 2619
		private static readonly IntPtr NativeMethodInfoPtr_get_wzxx_Public_get_bool4_0;

		// Token: 0x04000A3C RID: 2620
		private static readonly IntPtr NativeMethodInfoPtr_get_wzxy_Public_get_bool4_0;

		// Token: 0x04000A3D RID: 2621
		private static readonly IntPtr NativeMethodInfoPtr_set_wzxy_Public_set_Void_bool4_0;

		// Token: 0x04000A3E RID: 2622
		private static readonly IntPtr NativeMethodInfoPtr_get_wzxz_Public_get_bool4_0;

		// Token: 0x04000A3F RID: 2623
		private static readonly IntPtr NativeMethodInfoPtr_get_wzxw_Public_get_bool4_0;

		// Token: 0x04000A40 RID: 2624
		private static readonly IntPtr NativeMethodInfoPtr_get_wzyx_Public_get_bool4_0;

		// Token: 0x04000A41 RID: 2625
		private static readonly IntPtr NativeMethodInfoPtr_set_wzyx_Public_set_Void_bool4_0;

		// Token: 0x04000A42 RID: 2626
		private static readonly IntPtr NativeMethodInfoPtr_get_wzyy_Public_get_bool4_0;

		// Token: 0x04000A43 RID: 2627
		private static readonly IntPtr NativeMethodInfoPtr_get_wzyz_Public_get_bool4_0;

		// Token: 0x04000A44 RID: 2628
		private static readonly IntPtr NativeMethodInfoPtr_get_wzyw_Public_get_bool4_0;

		// Token: 0x04000A45 RID: 2629
		private static readonly IntPtr NativeMethodInfoPtr_get_wzzx_Public_get_bool4_0;

		// Token: 0x04000A46 RID: 2630
		private static readonly IntPtr NativeMethodInfoPtr_get_wzzy_Public_get_bool4_0;

		// Token: 0x04000A47 RID: 2631
		private static readonly IntPtr NativeMethodInfoPtr_get_wzzz_Public_get_bool4_0;

		// Token: 0x04000A48 RID: 2632
		private static readonly IntPtr NativeMethodInfoPtr_get_wzzw_Public_get_bool4_0;

		// Token: 0x04000A49 RID: 2633
		private static readonly IntPtr NativeMethodInfoPtr_get_wzwx_Public_get_bool4_0;

		// Token: 0x04000A4A RID: 2634
		private static readonly IntPtr NativeMethodInfoPtr_get_wzwy_Public_get_bool4_0;

		// Token: 0x04000A4B RID: 2635
		private static readonly IntPtr NativeMethodInfoPtr_get_wzwz_Public_get_bool4_0;

		// Token: 0x04000A4C RID: 2636
		private static readonly IntPtr NativeMethodInfoPtr_get_wzww_Public_get_bool4_0;

		// Token: 0x04000A4D RID: 2637
		private static readonly IntPtr NativeMethodInfoPtr_get_wwxx_Public_get_bool4_0;

		// Token: 0x04000A4E RID: 2638
		private static readonly IntPtr NativeMethodInfoPtr_get_wwxy_Public_get_bool4_0;

		// Token: 0x04000A4F RID: 2639
		private static readonly IntPtr NativeMethodInfoPtr_get_wwxz_Public_get_bool4_0;

		// Token: 0x04000A50 RID: 2640
		private static readonly IntPtr NativeMethodInfoPtr_get_wwxw_Public_get_bool4_0;

		// Token: 0x04000A51 RID: 2641
		private static readonly IntPtr NativeMethodInfoPtr_get_wwyx_Public_get_bool4_0;

		// Token: 0x04000A52 RID: 2642
		private static readonly IntPtr NativeMethodInfoPtr_get_wwyy_Public_get_bool4_0;

		// Token: 0x04000A53 RID: 2643
		private static readonly IntPtr NativeMethodInfoPtr_get_wwyz_Public_get_bool4_0;

		// Token: 0x04000A54 RID: 2644
		private static readonly IntPtr NativeMethodInfoPtr_get_wwyw_Public_get_bool4_0;

		// Token: 0x04000A55 RID: 2645
		private static readonly IntPtr NativeMethodInfoPtr_get_wwzx_Public_get_bool4_0;

		// Token: 0x04000A56 RID: 2646
		private static readonly IntPtr NativeMethodInfoPtr_get_wwzy_Public_get_bool4_0;

		// Token: 0x04000A57 RID: 2647
		private static readonly IntPtr NativeMethodInfoPtr_get_wwzz_Public_get_bool4_0;

		// Token: 0x04000A58 RID: 2648
		private static readonly IntPtr NativeMethodInfoPtr_get_wwzw_Public_get_bool4_0;

		// Token: 0x04000A59 RID: 2649
		private static readonly IntPtr NativeMethodInfoPtr_get_wwwx_Public_get_bool4_0;

		// Token: 0x04000A5A RID: 2650
		private static readonly IntPtr NativeMethodInfoPtr_get_wwwy_Public_get_bool4_0;

		// Token: 0x04000A5B RID: 2651
		private static readonly IntPtr NativeMethodInfoPtr_get_wwwz_Public_get_bool4_0;

		// Token: 0x04000A5C RID: 2652
		private static readonly IntPtr NativeMethodInfoPtr_get_wwww_Public_get_bool4_0;

		// Token: 0x04000A5D RID: 2653
		private static readonly IntPtr NativeMethodInfoPtr_get_xxx_Public_get_bool3_0;

		// Token: 0x04000A5E RID: 2654
		private static readonly IntPtr NativeMethodInfoPtr_get_xxy_Public_get_bool3_0;

		// Token: 0x04000A5F RID: 2655
		private static readonly IntPtr NativeMethodInfoPtr_get_xxz_Public_get_bool3_0;

		// Token: 0x04000A60 RID: 2656
		private static readonly IntPtr NativeMethodInfoPtr_get_xxw_Public_get_bool3_0;

		// Token: 0x04000A61 RID: 2657
		private static readonly IntPtr NativeMethodInfoPtr_get_xyx_Public_get_bool3_0;

		// Token: 0x04000A62 RID: 2658
		private static readonly IntPtr NativeMethodInfoPtr_get_xyy_Public_get_bool3_0;

		// Token: 0x04000A63 RID: 2659
		private static readonly IntPtr NativeMethodInfoPtr_get_xyz_Public_get_bool3_0;

		// Token: 0x04000A64 RID: 2660
		private static readonly IntPtr NativeMethodInfoPtr_set_xyz_Public_set_Void_bool3_0;

		// Token: 0x04000A65 RID: 2661
		private static readonly IntPtr NativeMethodInfoPtr_get_xyw_Public_get_bool3_0;

		// Token: 0x04000A66 RID: 2662
		private static readonly IntPtr NativeMethodInfoPtr_set_xyw_Public_set_Void_bool3_0;

		// Token: 0x04000A67 RID: 2663
		private static readonly IntPtr NativeMethodInfoPtr_get_xzx_Public_get_bool3_0;

		// Token: 0x04000A68 RID: 2664
		private static readonly IntPtr NativeMethodInfoPtr_get_xzy_Public_get_bool3_0;

		// Token: 0x04000A69 RID: 2665
		private static readonly IntPtr NativeMethodInfoPtr_set_xzy_Public_set_Void_bool3_0;

		// Token: 0x04000A6A RID: 2666
		private static readonly IntPtr NativeMethodInfoPtr_get_xzz_Public_get_bool3_0;

		// Token: 0x04000A6B RID: 2667
		private static readonly IntPtr NativeMethodInfoPtr_get_xzw_Public_get_bool3_0;

		// Token: 0x04000A6C RID: 2668
		private static readonly IntPtr NativeMethodInfoPtr_set_xzw_Public_set_Void_bool3_0;

		// Token: 0x04000A6D RID: 2669
		private static readonly IntPtr NativeMethodInfoPtr_get_xwx_Public_get_bool3_0;

		// Token: 0x04000A6E RID: 2670
		private static readonly IntPtr NativeMethodInfoPtr_get_xwy_Public_get_bool3_0;

		// Token: 0x04000A6F RID: 2671
		private static readonly IntPtr NativeMethodInfoPtr_set_xwy_Public_set_Void_bool3_0;

		// Token: 0x04000A70 RID: 2672
		private static readonly IntPtr NativeMethodInfoPtr_get_xwz_Public_get_bool3_0;

		// Token: 0x04000A71 RID: 2673
		private static readonly IntPtr NativeMethodInfoPtr_set_xwz_Public_set_Void_bool3_0;

		// Token: 0x04000A72 RID: 2674
		private static readonly IntPtr NativeMethodInfoPtr_get_xww_Public_get_bool3_0;

		// Token: 0x04000A73 RID: 2675
		private static readonly IntPtr NativeMethodInfoPtr_get_yxx_Public_get_bool3_0;

		// Token: 0x04000A74 RID: 2676
		private static readonly IntPtr NativeMethodInfoPtr_get_yxy_Public_get_bool3_0;

		// Token: 0x04000A75 RID: 2677
		private static readonly IntPtr NativeMethodInfoPtr_get_yxz_Public_get_bool3_0;

		// Token: 0x04000A76 RID: 2678
		private static readonly IntPtr NativeMethodInfoPtr_set_yxz_Public_set_Void_bool3_0;

		// Token: 0x04000A77 RID: 2679
		private static readonly IntPtr NativeMethodInfoPtr_get_yxw_Public_get_bool3_0;

		// Token: 0x04000A78 RID: 2680
		private static readonly IntPtr NativeMethodInfoPtr_set_yxw_Public_set_Void_bool3_0;

		// Token: 0x04000A79 RID: 2681
		private static readonly IntPtr NativeMethodInfoPtr_get_yyx_Public_get_bool3_0;

		// Token: 0x04000A7A RID: 2682
		private static readonly IntPtr NativeMethodInfoPtr_get_yyy_Public_get_bool3_0;

		// Token: 0x04000A7B RID: 2683
		private static readonly IntPtr NativeMethodInfoPtr_get_yyz_Public_get_bool3_0;

		// Token: 0x04000A7C RID: 2684
		private static readonly IntPtr NativeMethodInfoPtr_get_yyw_Public_get_bool3_0;

		// Token: 0x04000A7D RID: 2685
		private static readonly IntPtr NativeMethodInfoPtr_get_yzx_Public_get_bool3_0;

		// Token: 0x04000A7E RID: 2686
		private static readonly IntPtr NativeMethodInfoPtr_set_yzx_Public_set_Void_bool3_0;

		// Token: 0x04000A7F RID: 2687
		private static readonly IntPtr NativeMethodInfoPtr_get_yzy_Public_get_bool3_0;

		// Token: 0x04000A80 RID: 2688
		private static readonly IntPtr NativeMethodInfoPtr_get_yzz_Public_get_bool3_0;

		// Token: 0x04000A81 RID: 2689
		private static readonly IntPtr NativeMethodInfoPtr_get_yzw_Public_get_bool3_0;

		// Token: 0x04000A82 RID: 2690
		private static readonly IntPtr NativeMethodInfoPtr_set_yzw_Public_set_Void_bool3_0;

		// Token: 0x04000A83 RID: 2691
		private static readonly IntPtr NativeMethodInfoPtr_get_ywx_Public_get_bool3_0;

		// Token: 0x04000A84 RID: 2692
		private static readonly IntPtr NativeMethodInfoPtr_set_ywx_Public_set_Void_bool3_0;

		// Token: 0x04000A85 RID: 2693
		private static readonly IntPtr NativeMethodInfoPtr_get_ywy_Public_get_bool3_0;

		// Token: 0x04000A86 RID: 2694
		private static readonly IntPtr NativeMethodInfoPtr_get_ywz_Public_get_bool3_0;

		// Token: 0x04000A87 RID: 2695
		private static readonly IntPtr NativeMethodInfoPtr_set_ywz_Public_set_Void_bool3_0;

		// Token: 0x04000A88 RID: 2696
		private static readonly IntPtr NativeMethodInfoPtr_get_yww_Public_get_bool3_0;

		// Token: 0x04000A89 RID: 2697
		private static readonly IntPtr NativeMethodInfoPtr_get_zxx_Public_get_bool3_0;

		// Token: 0x04000A8A RID: 2698
		private static readonly IntPtr NativeMethodInfoPtr_get_zxy_Public_get_bool3_0;

		// Token: 0x04000A8B RID: 2699
		private static readonly IntPtr NativeMethodInfoPtr_set_zxy_Public_set_Void_bool3_0;

		// Token: 0x04000A8C RID: 2700
		private static readonly IntPtr NativeMethodInfoPtr_get_zxz_Public_get_bool3_0;

		// Token: 0x04000A8D RID: 2701
		private static readonly IntPtr NativeMethodInfoPtr_get_zxw_Public_get_bool3_0;

		// Token: 0x04000A8E RID: 2702
		private static readonly IntPtr NativeMethodInfoPtr_set_zxw_Public_set_Void_bool3_0;

		// Token: 0x04000A8F RID: 2703
		private static readonly IntPtr NativeMethodInfoPtr_get_zyx_Public_get_bool3_0;

		// Token: 0x04000A90 RID: 2704
		private static readonly IntPtr NativeMethodInfoPtr_set_zyx_Public_set_Void_bool3_0;

		// Token: 0x04000A91 RID: 2705
		private static readonly IntPtr NativeMethodInfoPtr_get_zyy_Public_get_bool3_0;

		// Token: 0x04000A92 RID: 2706
		private static readonly IntPtr NativeMethodInfoPtr_get_zyz_Public_get_bool3_0;

		// Token: 0x04000A93 RID: 2707
		private static readonly IntPtr NativeMethodInfoPtr_get_zyw_Public_get_bool3_0;

		// Token: 0x04000A94 RID: 2708
		private static readonly IntPtr NativeMethodInfoPtr_set_zyw_Public_set_Void_bool3_0;

		// Token: 0x04000A95 RID: 2709
		private static readonly IntPtr NativeMethodInfoPtr_get_zzx_Public_get_bool3_0;

		// Token: 0x04000A96 RID: 2710
		private static readonly IntPtr NativeMethodInfoPtr_get_zzy_Public_get_bool3_0;

		// Token: 0x04000A97 RID: 2711
		private static readonly IntPtr NativeMethodInfoPtr_get_zzz_Public_get_bool3_0;

		// Token: 0x04000A98 RID: 2712
		private static readonly IntPtr NativeMethodInfoPtr_get_zzw_Public_get_bool3_0;

		// Token: 0x04000A99 RID: 2713
		private static readonly IntPtr NativeMethodInfoPtr_get_zwx_Public_get_bool3_0;

		// Token: 0x04000A9A RID: 2714
		private static readonly IntPtr NativeMethodInfoPtr_set_zwx_Public_set_Void_bool3_0;

		// Token: 0x04000A9B RID: 2715
		private static readonly IntPtr NativeMethodInfoPtr_get_zwy_Public_get_bool3_0;

		// Token: 0x04000A9C RID: 2716
		private static readonly IntPtr NativeMethodInfoPtr_set_zwy_Public_set_Void_bool3_0;

		// Token: 0x04000A9D RID: 2717
		private static readonly IntPtr NativeMethodInfoPtr_get_zwz_Public_get_bool3_0;

		// Token: 0x04000A9E RID: 2718
		private static readonly IntPtr NativeMethodInfoPtr_get_zww_Public_get_bool3_0;

		// Token: 0x04000A9F RID: 2719
		private static readonly IntPtr NativeMethodInfoPtr_get_wxx_Public_get_bool3_0;

		// Token: 0x04000AA0 RID: 2720
		private static readonly IntPtr NativeMethodInfoPtr_get_wxy_Public_get_bool3_0;

		// Token: 0x04000AA1 RID: 2721
		private static readonly IntPtr NativeMethodInfoPtr_set_wxy_Public_set_Void_bool3_0;

		// Token: 0x04000AA2 RID: 2722
		private static readonly IntPtr NativeMethodInfoPtr_get_wxz_Public_get_bool3_0;

		// Token: 0x04000AA3 RID: 2723
		private static readonly IntPtr NativeMethodInfoPtr_set_wxz_Public_set_Void_bool3_0;

		// Token: 0x04000AA4 RID: 2724
		private static readonly IntPtr NativeMethodInfoPtr_get_wxw_Public_get_bool3_0;

		// Token: 0x04000AA5 RID: 2725
		private static readonly IntPtr NativeMethodInfoPtr_get_wyx_Public_get_bool3_0;

		// Token: 0x04000AA6 RID: 2726
		private static readonly IntPtr NativeMethodInfoPtr_set_wyx_Public_set_Void_bool3_0;

		// Token: 0x04000AA7 RID: 2727
		private static readonly IntPtr NativeMethodInfoPtr_get_wyy_Public_get_bool3_0;

		// Token: 0x04000AA8 RID: 2728
		private static readonly IntPtr NativeMethodInfoPtr_get_wyz_Public_get_bool3_0;

		// Token: 0x04000AA9 RID: 2729
		private static readonly IntPtr NativeMethodInfoPtr_set_wyz_Public_set_Void_bool3_0;

		// Token: 0x04000AAA RID: 2730
		private static readonly IntPtr NativeMethodInfoPtr_get_wyw_Public_get_bool3_0;

		// Token: 0x04000AAB RID: 2731
		private static readonly IntPtr NativeMethodInfoPtr_get_wzx_Public_get_bool3_0;

		// Token: 0x04000AAC RID: 2732
		private static readonly IntPtr NativeMethodInfoPtr_set_wzx_Public_set_Void_bool3_0;

		// Token: 0x04000AAD RID: 2733
		private static readonly IntPtr NativeMethodInfoPtr_get_wzy_Public_get_bool3_0;

		// Token: 0x04000AAE RID: 2734
		private static readonly IntPtr NativeMethodInfoPtr_set_wzy_Public_set_Void_bool3_0;

		// Token: 0x04000AAF RID: 2735
		private static readonly IntPtr NativeMethodInfoPtr_get_wzz_Public_get_bool3_0;

		// Token: 0x04000AB0 RID: 2736
		private static readonly IntPtr NativeMethodInfoPtr_get_wzw_Public_get_bool3_0;

		// Token: 0x04000AB1 RID: 2737
		private static readonly IntPtr NativeMethodInfoPtr_get_wwx_Public_get_bool3_0;

		// Token: 0x04000AB2 RID: 2738
		private static readonly IntPtr NativeMethodInfoPtr_get_wwy_Public_get_bool3_0;

		// Token: 0x04000AB3 RID: 2739
		private static readonly IntPtr NativeMethodInfoPtr_get_wwz_Public_get_bool3_0;

		// Token: 0x04000AB4 RID: 2740
		private static readonly IntPtr NativeMethodInfoPtr_get_www_Public_get_bool3_0;

		// Token: 0x04000AB5 RID: 2741
		private static readonly IntPtr NativeMethodInfoPtr_get_xx_Public_get_bool2_0;

		// Token: 0x04000AB6 RID: 2742
		private static readonly IntPtr NativeMethodInfoPtr_get_xy_Public_get_bool2_0;

		// Token: 0x04000AB7 RID: 2743
		private static readonly IntPtr NativeMethodInfoPtr_set_xy_Public_set_Void_bool2_0;

		// Token: 0x04000AB8 RID: 2744
		private static readonly IntPtr NativeMethodInfoPtr_get_xz_Public_get_bool2_0;

		// Token: 0x04000AB9 RID: 2745
		private static readonly IntPtr NativeMethodInfoPtr_set_xz_Public_set_Void_bool2_0;

		// Token: 0x04000ABA RID: 2746
		private static readonly IntPtr NativeMethodInfoPtr_get_xw_Public_get_bool2_0;

		// Token: 0x04000ABB RID: 2747
		private static readonly IntPtr NativeMethodInfoPtr_set_xw_Public_set_Void_bool2_0;

		// Token: 0x04000ABC RID: 2748
		private static readonly IntPtr NativeMethodInfoPtr_get_yx_Public_get_bool2_0;

		// Token: 0x04000ABD RID: 2749
		private static readonly IntPtr NativeMethodInfoPtr_set_yx_Public_set_Void_bool2_0;

		// Token: 0x04000ABE RID: 2750
		private static readonly IntPtr NativeMethodInfoPtr_get_yy_Public_get_bool2_0;

		// Token: 0x04000ABF RID: 2751
		private static readonly IntPtr NativeMethodInfoPtr_get_yz_Public_get_bool2_0;

		// Token: 0x04000AC0 RID: 2752
		private static readonly IntPtr NativeMethodInfoPtr_set_yz_Public_set_Void_bool2_0;

		// Token: 0x04000AC1 RID: 2753
		private static readonly IntPtr NativeMethodInfoPtr_get_yw_Public_get_bool2_0;

		// Token: 0x04000AC2 RID: 2754
		private static readonly IntPtr NativeMethodInfoPtr_set_yw_Public_set_Void_bool2_0;

		// Token: 0x04000AC3 RID: 2755
		private static readonly IntPtr NativeMethodInfoPtr_get_zx_Public_get_bool2_0;

		// Token: 0x04000AC4 RID: 2756
		private static readonly IntPtr NativeMethodInfoPtr_set_zx_Public_set_Void_bool2_0;

		// Token: 0x04000AC5 RID: 2757
		private static readonly IntPtr NativeMethodInfoPtr_get_zy_Public_get_bool2_0;

		// Token: 0x04000AC6 RID: 2758
		private static readonly IntPtr NativeMethodInfoPtr_set_zy_Public_set_Void_bool2_0;

		// Token: 0x04000AC7 RID: 2759
		private static readonly IntPtr NativeMethodInfoPtr_get_zz_Public_get_bool2_0;

		// Token: 0x04000AC8 RID: 2760
		private static readonly IntPtr NativeMethodInfoPtr_get_zw_Public_get_bool2_0;

		// Token: 0x04000AC9 RID: 2761
		private static readonly IntPtr NativeMethodInfoPtr_set_zw_Public_set_Void_bool2_0;

		// Token: 0x04000ACA RID: 2762
		private static readonly IntPtr NativeMethodInfoPtr_get_wx_Public_get_bool2_0;

		// Token: 0x04000ACB RID: 2763
		private static readonly IntPtr NativeMethodInfoPtr_set_wx_Public_set_Void_bool2_0;

		// Token: 0x04000ACC RID: 2764
		private static readonly IntPtr NativeMethodInfoPtr_get_wy_Public_get_bool2_0;

		// Token: 0x04000ACD RID: 2765
		private static readonly IntPtr NativeMethodInfoPtr_set_wy_Public_set_Void_bool2_0;

		// Token: 0x04000ACE RID: 2766
		private static readonly IntPtr NativeMethodInfoPtr_get_wz_Public_get_bool2_0;

		// Token: 0x04000ACF RID: 2767
		private static readonly IntPtr NativeMethodInfoPtr_set_wz_Public_set_Void_bool2_0;

		// Token: 0x04000AD0 RID: 2768
		private static readonly IntPtr NativeMethodInfoPtr_get_ww_Public_get_bool2_0;

		// Token: 0x04000AD1 RID: 2769
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Boolean_Int32_0;

		// Token: 0x04000AD2 RID: 2770
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Boolean_0;

		// Token: 0x04000AD3 RID: 2771
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_bool4_0;

		// Token: 0x04000AD4 RID: 2772
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000AD5 RID: 2773
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000AD6 RID: 2774
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000AD7 RID: 2775
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool x;

		// Token: 0x04000AD8 RID: 2776
		[FieldOffset(1)]
		[MarshalAs(4)]
		public bool y;

		// Token: 0x04000AD9 RID: 2777
		[FieldOffset(2)]
		[MarshalAs(4)]
		public bool z;

		// Token: 0x04000ADA RID: 2778
		[FieldOffset(3)]
		[MarshalAs(4)]
		public bool w;

		// Token: 0x02000056 RID: 86
		public sealed class DebuggerProxy : Object
		{
			// Token: 0x060025C9 RID: 9673 RVA: 0x000C2F98 File Offset: 0x000C1198
			// Note: this type is marked as 'beforefieldinit'.
			static DebuggerProxy()
			{
				Il2CppClassPointerStore<bool4.DebuggerProxy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<bool4>.NativeClassPtr, "DebuggerProxy");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<bool4.DebuggerProxy>.NativeClassPtr);
				bool4.DebuggerProxy.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bool4.DebuggerProxy>.NativeClassPtr, "x");
				bool4.DebuggerProxy.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bool4.DebuggerProxy>.NativeClassPtr, "y");
				bool4.DebuggerProxy.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bool4.DebuggerProxy>.NativeClassPtr, "z");
				bool4.DebuggerProxy.NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bool4.DebuggerProxy>.NativeClassPtr, "w");
				bool4.DebuggerProxy.NativeMethodInfoPtr__ctor_Public_Void_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bool4.DebuggerProxy>.NativeClassPtr, 100666001);
			}

			// Token: 0x060025CA RID: 9674 RVA: 0x000C3028 File Offset: 0x000C1228
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634570, XrefRangeEnd = 634571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DebuggerProxy(bool4 v)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<bool4.DebuggerProxy>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bool4.DebuggerProxy.NativeMethodInfoPtr__ctor_Public_Void_bool4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060025CB RID: 9675 RVA: 0x00002C70 File Offset: 0x00000E70
			public DebuggerProxy(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BF6 RID: 3062
			// (get) Token: 0x060025CC RID: 9676 RVA: 0x000C3070 File Offset: 0x000C1270
			// (set) Token: 0x060025CD RID: 9677 RVA: 0x00002C79 File Offset: 0x00000E79
			public unsafe bool x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bool4.DebuggerProxy.NativeFieldInfoPtr_x);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bool4.DebuggerProxy.NativeFieldInfoPtr_x)) = value;
				}
			}

			// Token: 0x17000BF7 RID: 3063
			// (get) Token: 0x060025CE RID: 9678 RVA: 0x000C3098 File Offset: 0x000C1298
			// (set) Token: 0x060025CF RID: 9679 RVA: 0x00002C94 File Offset: 0x00000E94
			public unsafe bool y
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bool4.DebuggerProxy.NativeFieldInfoPtr_y);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bool4.DebuggerProxy.NativeFieldInfoPtr_y)) = value;
				}
			}

			// Token: 0x17000BF8 RID: 3064
			// (get) Token: 0x060025D0 RID: 9680 RVA: 0x000C30C0 File Offset: 0x000C12C0
			// (set) Token: 0x060025D1 RID: 9681 RVA: 0x00002CAF File Offset: 0x00000EAF
			public unsafe bool z
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bool4.DebuggerProxy.NativeFieldInfoPtr_z);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bool4.DebuggerProxy.NativeFieldInfoPtr_z)) = value;
				}
			}

			// Token: 0x17000BF9 RID: 3065
			// (get) Token: 0x060025D2 RID: 9682 RVA: 0x000C30E8 File Offset: 0x000C12E8
			// (set) Token: 0x060025D3 RID: 9683 RVA: 0x00002CCA File Offset: 0x00000ECA
			public unsafe bool w
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bool4.DebuggerProxy.NativeFieldInfoPtr_w);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bool4.DebuggerProxy.NativeFieldInfoPtr_w)) = value;
				}
			}

			// Token: 0x04002663 RID: 9827
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04002664 RID: 9828
			private static readonly IntPtr NativeFieldInfoPtr_y;

			// Token: 0x04002665 RID: 9829
			private static readonly IntPtr NativeFieldInfoPtr_z;

			// Token: 0x04002666 RID: 9830
			private static readonly IntPtr NativeFieldInfoPtr_w;

			// Token: 0x04002667 RID: 9831
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool4_0;
		}
	}
}
