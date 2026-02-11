using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x02000035 RID: 53
	[Serializable]
	[StructLayout(2)]
	public struct int4
	{
		// Token: 0x06001C00 RID: 7168 RVA: 0x00092D64 File Offset: 0x00090F64
		// Note: this type is marked as 'beforefieldinit'.
		static int4()
		{
			Il2CppClassPointerStore<int4>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "int4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<int4>.NativeClassPtr);
			int4.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int4>.NativeClassPtr, "x");
			int4.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int4>.NativeClassPtr, "y");
			int4.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int4>.NativeClassPtr, "z");
			int4.NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int4>.NativeClassPtr, "w");
			int4.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int4>.NativeClassPtr, "zero");
			int4.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670253);
			int4.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670254);
			int4.NativeMethodInfoPtr__ctor_Public_Void_Int32_int2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670255);
			int4.NativeMethodInfoPtr__ctor_Public_Void_Int32_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670256);
			int4.NativeMethodInfoPtr__ctor_Public_Void_int2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670257);
			int4.NativeMethodInfoPtr__ctor_Public_Void_int2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670258);
			int4.NativeMethodInfoPtr__ctor_Public_Void_int3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670259);
			int4.NativeMethodInfoPtr__ctor_Public_Void_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670260);
			int4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670261);
			int4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670262);
			int4.NativeMethodInfoPtr__ctor_Public_Void_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670263);
			int4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670264);
			int4.NativeMethodInfoPtr__ctor_Public_Void_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670265);
			int4.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670266);
			int4.NativeMethodInfoPtr__ctor_Public_Void_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670267);
			int4.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670268);
			int4.NativeMethodInfoPtr__ctor_Public_Void_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670269);
			int4.NativeMethodInfoPtr_op_Implicit_Public_Static_int4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670270);
			int4.NativeMethodInfoPtr_op_Explicit_Public_Static_int4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670271);
			int4.NativeMethodInfoPtr_op_Explicit_Public_Static_int4_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670272);
			int4.NativeMethodInfoPtr_op_Explicit_Public_Static_int4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670273);
			int4.NativeMethodInfoPtr_op_Explicit_Public_Static_int4_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670274);
			int4.NativeMethodInfoPtr_op_Explicit_Public_Static_int4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670275);
			int4.NativeMethodInfoPtr_op_Explicit_Public_Static_int4_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670276);
			int4.NativeMethodInfoPtr_op_Explicit_Public_Static_int4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670277);
			int4.NativeMethodInfoPtr_op_Explicit_Public_Static_int4_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670278);
			int4.NativeMethodInfoPtr_op_Multiply_Public_Static_int4_int4_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670279);
			int4.NativeMethodInfoPtr_op_Multiply_Public_Static_int4_int4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670280);
			int4.NativeMethodInfoPtr_op_Multiply_Public_Static_int4_Int32_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670281);
			int4.NativeMethodInfoPtr_op_Addition_Public_Static_int4_int4_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670282);
			int4.NativeMethodInfoPtr_op_Addition_Public_Static_int4_int4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670283);
			int4.NativeMethodInfoPtr_op_Addition_Public_Static_int4_Int32_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670284);
			int4.NativeMethodInfoPtr_op_Subtraction_Public_Static_int4_int4_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670285);
			int4.NativeMethodInfoPtr_op_Subtraction_Public_Static_int4_int4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670286);
			int4.NativeMethodInfoPtr_op_Subtraction_Public_Static_int4_Int32_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670287);
			int4.NativeMethodInfoPtr_op_Division_Public_Static_int4_int4_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670288);
			int4.NativeMethodInfoPtr_op_Division_Public_Static_int4_int4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670289);
			int4.NativeMethodInfoPtr_op_Division_Public_Static_int4_Int32_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670290);
			int4.NativeMethodInfoPtr_op_Modulus_Public_Static_int4_int4_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670291);
			int4.NativeMethodInfoPtr_op_Modulus_Public_Static_int4_int4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670292);
			int4.NativeMethodInfoPtr_op_Modulus_Public_Static_int4_Int32_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670293);
			int4.NativeMethodInfoPtr_op_Increment_Public_Static_int4_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670294);
			int4.NativeMethodInfoPtr_op_Decrement_Public_Static_int4_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670295);
			int4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4_int4_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670296);
			int4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4_int4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670297);
			int4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4_Int32_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670298);
			int4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4_int4_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670299);
			int4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4_int4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670300);
			int4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4_Int32_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670301);
			int4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4_int4_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670302);
			int4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4_int4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670303);
			int4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4_Int32_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670304);
			int4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4_int4_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670305);
			int4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4_int4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670306);
			int4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4_Int32_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670307);
			int4.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_int4_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670308);
			int4.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_int4_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670309);
			int4.NativeMethodInfoPtr_op_LeftShift_Public_Static_int4_int4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670310);
			int4.NativeMethodInfoPtr_op_RightShift_Public_Static_int4_int4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670311);
			int4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4_int4_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670312);
			int4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4_int4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670313);
			int4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4_Int32_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670314);
			int4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_int4_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670315);
			int4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_int4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670316);
			int4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_Int32_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670317);
			int4.NativeMethodInfoPtr_op_OnesComplement_Public_Static_int4_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670318);
			int4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int4_int4_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670319);
			int4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int4_int4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670320);
			int4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int4_Int32_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670321);
			int4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int4_int4_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670322);
			int4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int4_int4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670323);
			int4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int4_Int32_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670324);
			int4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int4_int4_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670325);
			int4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int4_int4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670326);
			int4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int4_Int32_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670327);
			int4.NativeMethodInfoPtr_get_xxxx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670328);
			int4.NativeMethodInfoPtr_get_xxxy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670329);
			int4.NativeMethodInfoPtr_get_xxxz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670330);
			int4.NativeMethodInfoPtr_get_xxxw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670331);
			int4.NativeMethodInfoPtr_get_xxyx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670332);
			int4.NativeMethodInfoPtr_get_xxyy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670333);
			int4.NativeMethodInfoPtr_get_xxyz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670334);
			int4.NativeMethodInfoPtr_get_xxyw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670335);
			int4.NativeMethodInfoPtr_get_xxzx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670336);
			int4.NativeMethodInfoPtr_get_xxzy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670337);
			int4.NativeMethodInfoPtr_get_xxzz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670338);
			int4.NativeMethodInfoPtr_get_xxzw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670339);
			int4.NativeMethodInfoPtr_get_xxwx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670340);
			int4.NativeMethodInfoPtr_get_xxwy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670341);
			int4.NativeMethodInfoPtr_get_xxwz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670342);
			int4.NativeMethodInfoPtr_get_xxww_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670343);
			int4.NativeMethodInfoPtr_get_xyxx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670344);
			int4.NativeMethodInfoPtr_get_xyxy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670345);
			int4.NativeMethodInfoPtr_get_xyxz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670346);
			int4.NativeMethodInfoPtr_get_xyxw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670347);
			int4.NativeMethodInfoPtr_get_xyyx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670348);
			int4.NativeMethodInfoPtr_get_xyyy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670349);
			int4.NativeMethodInfoPtr_get_xyyz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670350);
			int4.NativeMethodInfoPtr_get_xyyw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670351);
			int4.NativeMethodInfoPtr_get_xyzx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670352);
			int4.NativeMethodInfoPtr_get_xyzy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670353);
			int4.NativeMethodInfoPtr_get_xyzz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670354);
			int4.NativeMethodInfoPtr_get_xyzw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670355);
			int4.NativeMethodInfoPtr_set_xyzw_Public_set_Void_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670356);
			int4.NativeMethodInfoPtr_get_xywx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670357);
			int4.NativeMethodInfoPtr_get_xywy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670358);
			int4.NativeMethodInfoPtr_get_xywz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670359);
			int4.NativeMethodInfoPtr_set_xywz_Public_set_Void_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670360);
			int4.NativeMethodInfoPtr_get_xyww_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670361);
			int4.NativeMethodInfoPtr_get_xzxx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670362);
			int4.NativeMethodInfoPtr_get_xzxy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670363);
			int4.NativeMethodInfoPtr_get_xzxz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670364);
			int4.NativeMethodInfoPtr_get_xzxw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670365);
			int4.NativeMethodInfoPtr_get_xzyx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670366);
			int4.NativeMethodInfoPtr_get_xzyy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670367);
			int4.NativeMethodInfoPtr_get_xzyz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670368);
			int4.NativeMethodInfoPtr_get_xzyw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670369);
			int4.NativeMethodInfoPtr_set_xzyw_Public_set_Void_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670370);
			int4.NativeMethodInfoPtr_get_xzzx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670371);
			int4.NativeMethodInfoPtr_get_xzzy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670372);
			int4.NativeMethodInfoPtr_get_xzzz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670373);
			int4.NativeMethodInfoPtr_get_xzzw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670374);
			int4.NativeMethodInfoPtr_get_xzwx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670375);
			int4.NativeMethodInfoPtr_get_xzwy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670376);
			int4.NativeMethodInfoPtr_set_xzwy_Public_set_Void_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670377);
			int4.NativeMethodInfoPtr_get_xzwz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670378);
			int4.NativeMethodInfoPtr_get_xzww_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670379);
			int4.NativeMethodInfoPtr_get_xwxx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670380);
			int4.NativeMethodInfoPtr_get_xwxy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670381);
			int4.NativeMethodInfoPtr_get_xwxz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670382);
			int4.NativeMethodInfoPtr_get_xwxw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670383);
			int4.NativeMethodInfoPtr_get_xwyx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670384);
			int4.NativeMethodInfoPtr_get_xwyy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670385);
			int4.NativeMethodInfoPtr_get_xwyz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670386);
			int4.NativeMethodInfoPtr_set_xwyz_Public_set_Void_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670387);
			int4.NativeMethodInfoPtr_get_xwyw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670388);
			int4.NativeMethodInfoPtr_get_xwzx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670389);
			int4.NativeMethodInfoPtr_get_xwzy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670390);
			int4.NativeMethodInfoPtr_set_xwzy_Public_set_Void_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670391);
			int4.NativeMethodInfoPtr_get_xwzz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670392);
			int4.NativeMethodInfoPtr_get_xwzw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670393);
			int4.NativeMethodInfoPtr_get_xwwx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670394);
			int4.NativeMethodInfoPtr_get_xwwy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670395);
			int4.NativeMethodInfoPtr_get_xwwz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670396);
			int4.NativeMethodInfoPtr_get_xwww_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670397);
			int4.NativeMethodInfoPtr_get_yxxx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670398);
			int4.NativeMethodInfoPtr_get_yxxy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670399);
			int4.NativeMethodInfoPtr_get_yxxz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670400);
			int4.NativeMethodInfoPtr_get_yxxw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670401);
			int4.NativeMethodInfoPtr_get_yxyx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670402);
			int4.NativeMethodInfoPtr_get_yxyy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670403);
			int4.NativeMethodInfoPtr_get_yxyz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670404);
			int4.NativeMethodInfoPtr_get_yxyw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670405);
			int4.NativeMethodInfoPtr_get_yxzx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670406);
			int4.NativeMethodInfoPtr_get_yxzy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670407);
			int4.NativeMethodInfoPtr_get_yxzz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670408);
			int4.NativeMethodInfoPtr_get_yxzw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670409);
			int4.NativeMethodInfoPtr_set_yxzw_Public_set_Void_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670410);
			int4.NativeMethodInfoPtr_get_yxwx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670411);
			int4.NativeMethodInfoPtr_get_yxwy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670412);
			int4.NativeMethodInfoPtr_get_yxwz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670413);
			int4.NativeMethodInfoPtr_set_yxwz_Public_set_Void_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670414);
			int4.NativeMethodInfoPtr_get_yxww_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670415);
			int4.NativeMethodInfoPtr_get_yyxx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670416);
			int4.NativeMethodInfoPtr_get_yyxy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670417);
			int4.NativeMethodInfoPtr_get_yyxz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670418);
			int4.NativeMethodInfoPtr_get_yyxw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670419);
			int4.NativeMethodInfoPtr_get_yyyx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670420);
			int4.NativeMethodInfoPtr_get_yyyy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670421);
			int4.NativeMethodInfoPtr_get_yyyz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670422);
			int4.NativeMethodInfoPtr_get_yyyw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670423);
			int4.NativeMethodInfoPtr_get_yyzx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670424);
			int4.NativeMethodInfoPtr_get_yyzy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670425);
			int4.NativeMethodInfoPtr_get_yyzz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670426);
			int4.NativeMethodInfoPtr_get_yyzw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670427);
			int4.NativeMethodInfoPtr_get_yywx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670428);
			int4.NativeMethodInfoPtr_get_yywy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670429);
			int4.NativeMethodInfoPtr_get_yywz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670430);
			int4.NativeMethodInfoPtr_get_yyww_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670431);
			int4.NativeMethodInfoPtr_get_yzxx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670432);
			int4.NativeMethodInfoPtr_get_yzxy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670433);
			int4.NativeMethodInfoPtr_get_yzxz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670434);
			int4.NativeMethodInfoPtr_get_yzxw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670435);
			int4.NativeMethodInfoPtr_set_yzxw_Public_set_Void_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670436);
			int4.NativeMethodInfoPtr_get_yzyx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670437);
			int4.NativeMethodInfoPtr_get_yzyy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670438);
			int4.NativeMethodInfoPtr_get_yzyz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670439);
			int4.NativeMethodInfoPtr_get_yzyw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670440);
			int4.NativeMethodInfoPtr_get_yzzx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670441);
			int4.NativeMethodInfoPtr_get_yzzy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670442);
			int4.NativeMethodInfoPtr_get_yzzz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670443);
			int4.NativeMethodInfoPtr_get_yzzw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670444);
			int4.NativeMethodInfoPtr_get_yzwx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670445);
			int4.NativeMethodInfoPtr_set_yzwx_Public_set_Void_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670446);
			int4.NativeMethodInfoPtr_get_yzwy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670447);
			int4.NativeMethodInfoPtr_get_yzwz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670448);
			int4.NativeMethodInfoPtr_get_yzww_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670449);
			int4.NativeMethodInfoPtr_get_ywxx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670450);
			int4.NativeMethodInfoPtr_get_ywxy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670451);
			int4.NativeMethodInfoPtr_get_ywxz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670452);
			int4.NativeMethodInfoPtr_set_ywxz_Public_set_Void_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670453);
			int4.NativeMethodInfoPtr_get_ywxw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670454);
			int4.NativeMethodInfoPtr_get_ywyx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670455);
			int4.NativeMethodInfoPtr_get_ywyy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670456);
			int4.NativeMethodInfoPtr_get_ywyz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670457);
			int4.NativeMethodInfoPtr_get_ywyw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670458);
			int4.NativeMethodInfoPtr_get_ywzx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670459);
			int4.NativeMethodInfoPtr_set_ywzx_Public_set_Void_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670460);
			int4.NativeMethodInfoPtr_get_ywzy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670461);
			int4.NativeMethodInfoPtr_get_ywzz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670462);
			int4.NativeMethodInfoPtr_get_ywzw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670463);
			int4.NativeMethodInfoPtr_get_ywwx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670464);
			int4.NativeMethodInfoPtr_get_ywwy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670465);
			int4.NativeMethodInfoPtr_get_ywwz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670466);
			int4.NativeMethodInfoPtr_get_ywww_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670467);
			int4.NativeMethodInfoPtr_get_zxxx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670468);
			int4.NativeMethodInfoPtr_get_zxxy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670469);
			int4.NativeMethodInfoPtr_get_zxxz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670470);
			int4.NativeMethodInfoPtr_get_zxxw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670471);
			int4.NativeMethodInfoPtr_get_zxyx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670472);
			int4.NativeMethodInfoPtr_get_zxyy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670473);
			int4.NativeMethodInfoPtr_get_zxyz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670474);
			int4.NativeMethodInfoPtr_get_zxyw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670475);
			int4.NativeMethodInfoPtr_set_zxyw_Public_set_Void_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670476);
			int4.NativeMethodInfoPtr_get_zxzx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670477);
			int4.NativeMethodInfoPtr_get_zxzy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670478);
			int4.NativeMethodInfoPtr_get_zxzz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670479);
			int4.NativeMethodInfoPtr_get_zxzw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670480);
			int4.NativeMethodInfoPtr_get_zxwx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670481);
			int4.NativeMethodInfoPtr_get_zxwy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670482);
			int4.NativeMethodInfoPtr_set_zxwy_Public_set_Void_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670483);
			int4.NativeMethodInfoPtr_get_zxwz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670484);
			int4.NativeMethodInfoPtr_get_zxww_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670485);
			int4.NativeMethodInfoPtr_get_zyxx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670486);
			int4.NativeMethodInfoPtr_get_zyxy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670487);
			int4.NativeMethodInfoPtr_get_zyxz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670488);
			int4.NativeMethodInfoPtr_get_zyxw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670489);
			int4.NativeMethodInfoPtr_set_zyxw_Public_set_Void_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670490);
			int4.NativeMethodInfoPtr_get_zyyx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670491);
			int4.NativeMethodInfoPtr_get_zyyy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670492);
			int4.NativeMethodInfoPtr_get_zyyz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670493);
			int4.NativeMethodInfoPtr_get_zyyw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670494);
			int4.NativeMethodInfoPtr_get_zyzx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670495);
			int4.NativeMethodInfoPtr_get_zyzy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670496);
			int4.NativeMethodInfoPtr_get_zyzz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670497);
			int4.NativeMethodInfoPtr_get_zyzw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670498);
			int4.NativeMethodInfoPtr_get_zywx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670499);
			int4.NativeMethodInfoPtr_set_zywx_Public_set_Void_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670500);
			int4.NativeMethodInfoPtr_get_zywy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670501);
			int4.NativeMethodInfoPtr_get_zywz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670502);
			int4.NativeMethodInfoPtr_get_zyww_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670503);
			int4.NativeMethodInfoPtr_get_zzxx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670504);
			int4.NativeMethodInfoPtr_get_zzxy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670505);
			int4.NativeMethodInfoPtr_get_zzxz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670506);
			int4.NativeMethodInfoPtr_get_zzxw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670507);
			int4.NativeMethodInfoPtr_get_zzyx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670508);
			int4.NativeMethodInfoPtr_get_zzyy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670509);
			int4.NativeMethodInfoPtr_get_zzyz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670510);
			int4.NativeMethodInfoPtr_get_zzyw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670511);
			int4.NativeMethodInfoPtr_get_zzzx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670512);
			int4.NativeMethodInfoPtr_get_zzzy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670513);
			int4.NativeMethodInfoPtr_get_zzzz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670514);
			int4.NativeMethodInfoPtr_get_zzzw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670515);
			int4.NativeMethodInfoPtr_get_zzwx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670516);
			int4.NativeMethodInfoPtr_get_zzwy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670517);
			int4.NativeMethodInfoPtr_get_zzwz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670518);
			int4.NativeMethodInfoPtr_get_zzww_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670519);
			int4.NativeMethodInfoPtr_get_zwxx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670520);
			int4.NativeMethodInfoPtr_get_zwxy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670521);
			int4.NativeMethodInfoPtr_set_zwxy_Public_set_Void_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670522);
			int4.NativeMethodInfoPtr_get_zwxz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670523);
			int4.NativeMethodInfoPtr_get_zwxw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670524);
			int4.NativeMethodInfoPtr_get_zwyx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670525);
			int4.NativeMethodInfoPtr_set_zwyx_Public_set_Void_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670526);
			int4.NativeMethodInfoPtr_get_zwyy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670527);
			int4.NativeMethodInfoPtr_get_zwyz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670528);
			int4.NativeMethodInfoPtr_get_zwyw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670529);
			int4.NativeMethodInfoPtr_get_zwzx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670530);
			int4.NativeMethodInfoPtr_get_zwzy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670531);
			int4.NativeMethodInfoPtr_get_zwzz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670532);
			int4.NativeMethodInfoPtr_get_zwzw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670533);
			int4.NativeMethodInfoPtr_get_zwwx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670534);
			int4.NativeMethodInfoPtr_get_zwwy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670535);
			int4.NativeMethodInfoPtr_get_zwwz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670536);
			int4.NativeMethodInfoPtr_get_zwww_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670537);
			int4.NativeMethodInfoPtr_get_wxxx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670538);
			int4.NativeMethodInfoPtr_get_wxxy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670539);
			int4.NativeMethodInfoPtr_get_wxxz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670540);
			int4.NativeMethodInfoPtr_get_wxxw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670541);
			int4.NativeMethodInfoPtr_get_wxyx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670542);
			int4.NativeMethodInfoPtr_get_wxyy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670543);
			int4.NativeMethodInfoPtr_get_wxyz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670544);
			int4.NativeMethodInfoPtr_set_wxyz_Public_set_Void_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670545);
			int4.NativeMethodInfoPtr_get_wxyw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670546);
			int4.NativeMethodInfoPtr_get_wxzx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670547);
			int4.NativeMethodInfoPtr_get_wxzy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670548);
			int4.NativeMethodInfoPtr_set_wxzy_Public_set_Void_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670549);
			int4.NativeMethodInfoPtr_get_wxzz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670550);
			int4.NativeMethodInfoPtr_get_wxzw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670551);
			int4.NativeMethodInfoPtr_get_wxwx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670552);
			int4.NativeMethodInfoPtr_get_wxwy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670553);
			int4.NativeMethodInfoPtr_get_wxwz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670554);
			int4.NativeMethodInfoPtr_get_wxww_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670555);
			int4.NativeMethodInfoPtr_get_wyxx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670556);
			int4.NativeMethodInfoPtr_get_wyxy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670557);
			int4.NativeMethodInfoPtr_get_wyxz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670558);
			int4.NativeMethodInfoPtr_set_wyxz_Public_set_Void_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670559);
			int4.NativeMethodInfoPtr_get_wyxw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670560);
			int4.NativeMethodInfoPtr_get_wyyx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670561);
			int4.NativeMethodInfoPtr_get_wyyy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670562);
			int4.NativeMethodInfoPtr_get_wyyz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670563);
			int4.NativeMethodInfoPtr_get_wyyw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670564);
			int4.NativeMethodInfoPtr_get_wyzx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670565);
			int4.NativeMethodInfoPtr_set_wyzx_Public_set_Void_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670566);
			int4.NativeMethodInfoPtr_get_wyzy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670567);
			int4.NativeMethodInfoPtr_get_wyzz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670568);
			int4.NativeMethodInfoPtr_get_wyzw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670569);
			int4.NativeMethodInfoPtr_get_wywx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670570);
			int4.NativeMethodInfoPtr_get_wywy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670571);
			int4.NativeMethodInfoPtr_get_wywz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670572);
			int4.NativeMethodInfoPtr_get_wyww_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670573);
			int4.NativeMethodInfoPtr_get_wzxx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670574);
			int4.NativeMethodInfoPtr_get_wzxy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670575);
			int4.NativeMethodInfoPtr_set_wzxy_Public_set_Void_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670576);
			int4.NativeMethodInfoPtr_get_wzxz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670577);
			int4.NativeMethodInfoPtr_get_wzxw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670578);
			int4.NativeMethodInfoPtr_get_wzyx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670579);
			int4.NativeMethodInfoPtr_set_wzyx_Public_set_Void_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670580);
			int4.NativeMethodInfoPtr_get_wzyy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670581);
			int4.NativeMethodInfoPtr_get_wzyz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670582);
			int4.NativeMethodInfoPtr_get_wzyw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670583);
			int4.NativeMethodInfoPtr_get_wzzx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670584);
			int4.NativeMethodInfoPtr_get_wzzy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670585);
			int4.NativeMethodInfoPtr_get_wzzz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670586);
			int4.NativeMethodInfoPtr_get_wzzw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670587);
			int4.NativeMethodInfoPtr_get_wzwx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670588);
			int4.NativeMethodInfoPtr_get_wzwy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670589);
			int4.NativeMethodInfoPtr_get_wzwz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670590);
			int4.NativeMethodInfoPtr_get_wzww_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670591);
			int4.NativeMethodInfoPtr_get_wwxx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670592);
			int4.NativeMethodInfoPtr_get_wwxy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670593);
			int4.NativeMethodInfoPtr_get_wwxz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670594);
			int4.NativeMethodInfoPtr_get_wwxw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670595);
			int4.NativeMethodInfoPtr_get_wwyx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670596);
			int4.NativeMethodInfoPtr_get_wwyy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670597);
			int4.NativeMethodInfoPtr_get_wwyz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670598);
			int4.NativeMethodInfoPtr_get_wwyw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670599);
			int4.NativeMethodInfoPtr_get_wwzx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670600);
			int4.NativeMethodInfoPtr_get_wwzy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670601);
			int4.NativeMethodInfoPtr_get_wwzz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670602);
			int4.NativeMethodInfoPtr_get_wwzw_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670603);
			int4.NativeMethodInfoPtr_get_wwwx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670604);
			int4.NativeMethodInfoPtr_get_wwwy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670605);
			int4.NativeMethodInfoPtr_get_wwwz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670606);
			int4.NativeMethodInfoPtr_get_wwww_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670607);
			int4.NativeMethodInfoPtr_get_xxx_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670608);
			int4.NativeMethodInfoPtr_get_xxy_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670609);
			int4.NativeMethodInfoPtr_get_xxz_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670610);
			int4.NativeMethodInfoPtr_get_xxw_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670611);
			int4.NativeMethodInfoPtr_get_xyx_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670612);
			int4.NativeMethodInfoPtr_get_xyy_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670613);
			int4.NativeMethodInfoPtr_get_xyz_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670614);
			int4.NativeMethodInfoPtr_set_xyz_Public_set_Void_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670615);
			int4.NativeMethodInfoPtr_get_xyw_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670616);
			int4.NativeMethodInfoPtr_set_xyw_Public_set_Void_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670617);
			int4.NativeMethodInfoPtr_get_xzx_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670618);
			int4.NativeMethodInfoPtr_get_xzy_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670619);
			int4.NativeMethodInfoPtr_set_xzy_Public_set_Void_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670620);
			int4.NativeMethodInfoPtr_get_xzz_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670621);
			int4.NativeMethodInfoPtr_get_xzw_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670622);
			int4.NativeMethodInfoPtr_set_xzw_Public_set_Void_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670623);
			int4.NativeMethodInfoPtr_get_xwx_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670624);
			int4.NativeMethodInfoPtr_get_xwy_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670625);
			int4.NativeMethodInfoPtr_set_xwy_Public_set_Void_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670626);
			int4.NativeMethodInfoPtr_get_xwz_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670627);
			int4.NativeMethodInfoPtr_set_xwz_Public_set_Void_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670628);
			int4.NativeMethodInfoPtr_get_xww_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670629);
			int4.NativeMethodInfoPtr_get_yxx_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670630);
			int4.NativeMethodInfoPtr_get_yxy_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670631);
			int4.NativeMethodInfoPtr_get_yxz_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670632);
			int4.NativeMethodInfoPtr_set_yxz_Public_set_Void_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670633);
			int4.NativeMethodInfoPtr_get_yxw_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670634);
			int4.NativeMethodInfoPtr_set_yxw_Public_set_Void_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670635);
			int4.NativeMethodInfoPtr_get_yyx_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670636);
			int4.NativeMethodInfoPtr_get_yyy_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670637);
			int4.NativeMethodInfoPtr_get_yyz_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670638);
			int4.NativeMethodInfoPtr_get_yyw_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670639);
			int4.NativeMethodInfoPtr_get_yzx_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670640);
			int4.NativeMethodInfoPtr_set_yzx_Public_set_Void_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670641);
			int4.NativeMethodInfoPtr_get_yzy_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670642);
			int4.NativeMethodInfoPtr_get_yzz_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670643);
			int4.NativeMethodInfoPtr_get_yzw_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670644);
			int4.NativeMethodInfoPtr_set_yzw_Public_set_Void_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670645);
			int4.NativeMethodInfoPtr_get_ywx_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670646);
			int4.NativeMethodInfoPtr_set_ywx_Public_set_Void_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670647);
			int4.NativeMethodInfoPtr_get_ywy_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670648);
			int4.NativeMethodInfoPtr_get_ywz_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670649);
			int4.NativeMethodInfoPtr_set_ywz_Public_set_Void_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670650);
			int4.NativeMethodInfoPtr_get_yww_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670651);
			int4.NativeMethodInfoPtr_get_zxx_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670652);
			int4.NativeMethodInfoPtr_get_zxy_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670653);
			int4.NativeMethodInfoPtr_set_zxy_Public_set_Void_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670654);
			int4.NativeMethodInfoPtr_get_zxz_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670655);
			int4.NativeMethodInfoPtr_get_zxw_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670656);
			int4.NativeMethodInfoPtr_set_zxw_Public_set_Void_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670657);
			int4.NativeMethodInfoPtr_get_zyx_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670658);
			int4.NativeMethodInfoPtr_set_zyx_Public_set_Void_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670659);
			int4.NativeMethodInfoPtr_get_zyy_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670660);
			int4.NativeMethodInfoPtr_get_zyz_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670661);
			int4.NativeMethodInfoPtr_get_zyw_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670662);
			int4.NativeMethodInfoPtr_set_zyw_Public_set_Void_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670663);
			int4.NativeMethodInfoPtr_get_zzx_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670664);
			int4.NativeMethodInfoPtr_get_zzy_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670665);
			int4.NativeMethodInfoPtr_get_zzz_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670666);
			int4.NativeMethodInfoPtr_get_zzw_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670667);
			int4.NativeMethodInfoPtr_get_zwx_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670668);
			int4.NativeMethodInfoPtr_set_zwx_Public_set_Void_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670669);
			int4.NativeMethodInfoPtr_get_zwy_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670670);
			int4.NativeMethodInfoPtr_set_zwy_Public_set_Void_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670671);
			int4.NativeMethodInfoPtr_get_zwz_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670672);
			int4.NativeMethodInfoPtr_get_zww_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670673);
			int4.NativeMethodInfoPtr_get_wxx_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670674);
			int4.NativeMethodInfoPtr_get_wxy_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670675);
			int4.NativeMethodInfoPtr_set_wxy_Public_set_Void_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670676);
			int4.NativeMethodInfoPtr_get_wxz_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670677);
			int4.NativeMethodInfoPtr_set_wxz_Public_set_Void_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670678);
			int4.NativeMethodInfoPtr_get_wxw_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670679);
			int4.NativeMethodInfoPtr_get_wyx_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670680);
			int4.NativeMethodInfoPtr_set_wyx_Public_set_Void_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670681);
			int4.NativeMethodInfoPtr_get_wyy_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670682);
			int4.NativeMethodInfoPtr_get_wyz_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670683);
			int4.NativeMethodInfoPtr_set_wyz_Public_set_Void_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670684);
			int4.NativeMethodInfoPtr_get_wyw_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670685);
			int4.NativeMethodInfoPtr_get_wzx_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670686);
			int4.NativeMethodInfoPtr_set_wzx_Public_set_Void_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670687);
			int4.NativeMethodInfoPtr_get_wzy_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670688);
			int4.NativeMethodInfoPtr_set_wzy_Public_set_Void_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670689);
			int4.NativeMethodInfoPtr_get_wzz_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670690);
			int4.NativeMethodInfoPtr_get_wzw_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670691);
			int4.NativeMethodInfoPtr_get_wwx_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670692);
			int4.NativeMethodInfoPtr_get_wwy_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670693);
			int4.NativeMethodInfoPtr_get_wwz_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670694);
			int4.NativeMethodInfoPtr_get_www_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670695);
			int4.NativeMethodInfoPtr_get_xx_Public_get_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670696);
			int4.NativeMethodInfoPtr_get_xy_Public_get_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670697);
			int4.NativeMethodInfoPtr_set_xy_Public_set_Void_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670698);
			int4.NativeMethodInfoPtr_get_xz_Public_get_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670699);
			int4.NativeMethodInfoPtr_set_xz_Public_set_Void_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670700);
			int4.NativeMethodInfoPtr_get_xw_Public_get_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670701);
			int4.NativeMethodInfoPtr_set_xw_Public_set_Void_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670702);
			int4.NativeMethodInfoPtr_get_yx_Public_get_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670703);
			int4.NativeMethodInfoPtr_set_yx_Public_set_Void_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670704);
			int4.NativeMethodInfoPtr_get_yy_Public_get_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670705);
			int4.NativeMethodInfoPtr_get_yz_Public_get_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670706);
			int4.NativeMethodInfoPtr_set_yz_Public_set_Void_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670707);
			int4.NativeMethodInfoPtr_get_yw_Public_get_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670708);
			int4.NativeMethodInfoPtr_set_yw_Public_set_Void_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670709);
			int4.NativeMethodInfoPtr_get_zx_Public_get_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670710);
			int4.NativeMethodInfoPtr_set_zx_Public_set_Void_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670711);
			int4.NativeMethodInfoPtr_get_zy_Public_get_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670712);
			int4.NativeMethodInfoPtr_set_zy_Public_set_Void_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670713);
			int4.NativeMethodInfoPtr_get_zz_Public_get_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670714);
			int4.NativeMethodInfoPtr_get_zw_Public_get_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670715);
			int4.NativeMethodInfoPtr_set_zw_Public_set_Void_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670716);
			int4.NativeMethodInfoPtr_get_wx_Public_get_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670717);
			int4.NativeMethodInfoPtr_set_wx_Public_set_Void_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670718);
			int4.NativeMethodInfoPtr_get_wy_Public_get_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670719);
			int4.NativeMethodInfoPtr_set_wy_Public_set_Void_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670720);
			int4.NativeMethodInfoPtr_get_wz_Public_get_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670721);
			int4.NativeMethodInfoPtr_set_wz_Public_set_Void_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670722);
			int4.NativeMethodInfoPtr_get_ww_Public_get_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670723);
			int4.NativeMethodInfoPtr_get_Item_Public_get_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670724);
			int4.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670725);
			int4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670726);
			int4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670727);
			int4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670728);
			int4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670729);
			int4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4>.NativeClassPtr, 100670730);
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x00095350 File Offset: 0x00093550
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 608741, RefRangeEnd = 608768, XrefRangeStart = 608741, XrefRangeEnd = 608768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int4(int x, int y, int z, int w)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C02 RID: 7170 RVA: 0x000953AC File Offset: 0x000935AC
		[CallerCount(0)]
		public unsafe int4(int x, int y, int2 zw)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_int2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C03 RID: 7171 RVA: 0x000953FC File Offset: 0x000935FC
		[CallerCount(0)]
		public unsafe int4(int x, int2 yz, int w)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr__ctor_Public_Void_Int32_int2_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x0009544C File Offset: 0x0009364C
		[CallerCount(0)]
		public unsafe int4(int x, int3 yzw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yzw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr__ctor_Public_Void_Int32_int3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x0009548C File Offset: 0x0009368C
		[CallerCount(0)]
		public unsafe int4(int2 xy, int z, int w)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr__ctor_Public_Void_int2_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C06 RID: 7174 RVA: 0x000954DC File Offset: 0x000936DC
		[CallerCount(0)]
		public unsafe int4(int2 xy, int2 zw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xy;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr__ctor_Public_Void_int2_int2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C07 RID: 7175 RVA: 0x0009551C File Offset: 0x0009371C
		[CallerCount(0)]
		public unsafe int4(int3 xyz, int w)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr__ctor_Public_Void_int3_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x0009555C File Offset: 0x0009375C
		[CallerCount(0)]
		public unsafe int4(int4 xyzw)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyzw;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr__ctor_Public_Void_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x00095590 File Offset: 0x00093790
		[CallerCount(0)]
		public unsafe int4(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x000955C4 File Offset: 0x000937C4
		[CallerCount(0)]
		public unsafe int4(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x000955F8 File Offset: 0x000937F8
		[CallerCount(0)]
		public unsafe int4(bool4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr__ctor_Public_Void_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C0C RID: 7180 RVA: 0x0009562C File Offset: 0x0009382C
		[CallerCount(0)]
		public unsafe int4(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x00095660 File Offset: 0x00093860
		[CallerCount(0)]
		public unsafe int4(uint4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr__ctor_Public_Void_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x00095694 File Offset: 0x00093894
		[CallerCount(0)]
		public unsafe int4(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x000956C8 File Offset: 0x000938C8
		[CallerCount(0)]
		public unsafe int4(float4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr__ctor_Public_Void_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x000956FC File Offset: 0x000938FC
		[CallerCount(0)]
		public unsafe int4(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x00095730 File Offset: 0x00093930
		[CallerCount(0)]
		public unsafe int4(double4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr__ctor_Public_Void_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C12 RID: 7186 RVA: 0x00095764 File Offset: 0x00093964
		[CallerCount(0)]
		public unsafe static implicit operator int4(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_Implicit_Public_Static_int4_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C13 RID: 7187 RVA: 0x000957A4 File Offset: 0x000939A4
		[CallerCount(0)]
		public unsafe static explicit operator int4(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_Explicit_Public_Static_int4_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x000957E4 File Offset: 0x000939E4
		[CallerCount(0)]
		public unsafe static explicit operator int4(bool4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_Explicit_Public_Static_int4_bool4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x00095824 File Offset: 0x00093A24
		[CallerCount(0)]
		public unsafe static explicit operator int4(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_Explicit_Public_Static_int4_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C16 RID: 7190 RVA: 0x00095864 File Offset: 0x00093A64
		[CallerCount(0)]
		public unsafe static explicit operator int4(uint4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_Explicit_Public_Static_int4_uint4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C17 RID: 7191 RVA: 0x000958A4 File Offset: 0x00093AA4
		[CallerCount(0)]
		public unsafe static explicit operator int4(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_Explicit_Public_Static_int4_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C18 RID: 7192 RVA: 0x000958E4 File Offset: 0x00093AE4
		[CallerCount(0)]
		public unsafe static explicit operator int4(float4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_Explicit_Public_Static_int4_float4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C19 RID: 7193 RVA: 0x00095924 File Offset: 0x00093B24
		[CallerCount(0)]
		public unsafe static explicit operator int4(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_Explicit_Public_Static_int4_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C1A RID: 7194 RVA: 0x00095964 File Offset: 0x00093B64
		[CallerCount(0)]
		public unsafe static explicit operator int4(double4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_Explicit_Public_Static_int4_double4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x000959A4 File Offset: 0x00093BA4
		[CallerCount(0)]
		public unsafe static int4 operator *(int4 lhs, int4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_Multiply_Public_Static_int4_int4_int4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x000959F0 File Offset: 0x00093BF0
		[CallerCount(0)]
		public unsafe static int4 operator *(int4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_Multiply_Public_Static_int4_int4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x00095A3C File Offset: 0x00093C3C
		[CallerCount(0)]
		public unsafe static int4 operator *(int lhs, int4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_Multiply_Public_Static_int4_Int32_int4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x00095A88 File Offset: 0x00093C88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 639724, RefRangeEnd = 639726, XrefRangeStart = 639724, XrefRangeEnd = 639724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int4 operator +(int4 lhs, int4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_Addition_Public_Static_int4_int4_int4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x00095AD4 File Offset: 0x00093CD4
		[CallerCount(0)]
		public unsafe static int4 operator +(int4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_Addition_Public_Static_int4_int4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x00095B20 File Offset: 0x00093D20
		[CallerCount(0)]
		public unsafe static int4 operator +(int lhs, int4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_Addition_Public_Static_int4_Int32_int4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C21 RID: 7201 RVA: 0x00095B6C File Offset: 0x00093D6C
		[CallerCount(0)]
		public unsafe static int4 operator -(int4 lhs, int4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_Subtraction_Public_Static_int4_int4_int4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x00095BB8 File Offset: 0x00093DB8
		[CallerCount(0)]
		public unsafe static int4 operator -(int4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_Subtraction_Public_Static_int4_int4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x00095C04 File Offset: 0x00093E04
		[CallerCount(0)]
		public unsafe static int4 operator -(int lhs, int4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_Subtraction_Public_Static_int4_Int32_int4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x00095C50 File Offset: 0x00093E50
		[CallerCount(0)]
		public unsafe static int4 operator /(int4 lhs, int4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_Division_Public_Static_int4_int4_int4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C25 RID: 7205 RVA: 0x00095C9C File Offset: 0x00093E9C
		[CallerCount(0)]
		public unsafe static int4 operator /(int4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_Division_Public_Static_int4_int4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C26 RID: 7206 RVA: 0x00095CE8 File Offset: 0x00093EE8
		[CallerCount(0)]
		public unsafe static int4 operator /(int lhs, int4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_Division_Public_Static_int4_Int32_int4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C27 RID: 7207 RVA: 0x00095D34 File Offset: 0x00093F34
		[CallerCount(0)]
		public unsafe static int4 operator %(int4 lhs, int4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_Modulus_Public_Static_int4_int4_int4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C28 RID: 7208 RVA: 0x00095D80 File Offset: 0x00093F80
		[CallerCount(0)]
		public unsafe static int4 operator %(int4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_Modulus_Public_Static_int4_int4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x00095DCC File Offset: 0x00093FCC
		[CallerCount(0)]
		public unsafe static int4 operator %(int lhs, int4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_Modulus_Public_Static_int4_Int32_int4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C2A RID: 7210 RVA: 0x00095E18 File Offset: 0x00094018
		[CallerCount(0)]
		public unsafe static int4 operator ++(int4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_Increment_Public_Static_int4_int4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C2B RID: 7211 RVA: 0x00095E58 File Offset: 0x00094058
		[CallerCount(0)]
		public unsafe static int4 operator --(int4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_Decrement_Public_Static_int4_int4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C2C RID: 7212 RVA: 0x00095E98 File Offset: 0x00094098
		[CallerCount(0)]
		public unsafe static bool4 operator <(int4 lhs, int4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4_int4_int4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C2D RID: 7213 RVA: 0x00095EE4 File Offset: 0x000940E4
		[CallerCount(0)]
		public unsafe static bool4 operator <(int4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4_int4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C2E RID: 7214 RVA: 0x00095F30 File Offset: 0x00094130
		[CallerCount(0)]
		public unsafe static bool4 operator <(int lhs, int4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4_Int32_int4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C2F RID: 7215 RVA: 0x00095F7C File Offset: 0x0009417C
		[CallerCount(0)]
		public unsafe static bool4 operator <=(int4 lhs, int4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4_int4_int4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C30 RID: 7216 RVA: 0x00095FC8 File Offset: 0x000941C8
		[CallerCount(0)]
		public unsafe static bool4 operator <=(int4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4_int4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C31 RID: 7217 RVA: 0x00096014 File Offset: 0x00094214
		[CallerCount(0)]
		public unsafe static bool4 operator <=(int lhs, int4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4_Int32_int4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C32 RID: 7218 RVA: 0x00096060 File Offset: 0x00094260
		[CallerCount(0)]
		public unsafe static bool4 operator >(int4 lhs, int4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4_int4_int4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x000960AC File Offset: 0x000942AC
		[CallerCount(0)]
		public unsafe static bool4 operator >(int4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4_int4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C34 RID: 7220 RVA: 0x000960F8 File Offset: 0x000942F8
		[CallerCount(0)]
		public unsafe static bool4 operator >(int lhs, int4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4_Int32_int4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x00096144 File Offset: 0x00094344
		[CallerCount(0)]
		public unsafe static bool4 operator >=(int4 lhs, int4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4_int4_int4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x00096190 File Offset: 0x00094390
		[CallerCount(0)]
		public unsafe static bool4 operator >=(int4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4_int4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C37 RID: 7223 RVA: 0x000961DC File Offset: 0x000943DC
		[CallerCount(0)]
		public unsafe static bool4 operator >=(int lhs, int4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4_Int32_int4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C38 RID: 7224 RVA: 0x00096228 File Offset: 0x00094428
		[CallerCount(0)]
		public unsafe static int4 operator -(int4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_int4_int4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C39 RID: 7225 RVA: 0x00096268 File Offset: 0x00094468
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 637974, RefRangeEnd = 637984, XrefRangeStart = 637974, XrefRangeEnd = 637984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int4 operator +(int4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_int4_int4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C3A RID: 7226 RVA: 0x000962A8 File Offset: 0x000944A8
		[CallerCount(0)]
		public unsafe static int4 operator <<(int4 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_LeftShift_Public_Static_int4_int4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C3B RID: 7227 RVA: 0x000962F4 File Offset: 0x000944F4
		[CallerCount(0)]
		public unsafe static int4 operator >>(int4 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_RightShift_Public_Static_int4_int4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C3C RID: 7228 RVA: 0x00096340 File Offset: 0x00094540
		[CallerCount(0)]
		public unsafe static bool4 operator ==(int4 lhs, int4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4_int4_int4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C3D RID: 7229 RVA: 0x0009638C File Offset: 0x0009458C
		[CallerCount(0)]
		public unsafe static bool4 operator ==(int4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4_int4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x000963D8 File Offset: 0x000945D8
		[CallerCount(0)]
		public unsafe static bool4 operator ==(int lhs, int4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4_Int32_int4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C3F RID: 7231 RVA: 0x00096424 File Offset: 0x00094624
		[CallerCount(0)]
		public unsafe static bool4 operator !=(int4 lhs, int4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_int4_int4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C40 RID: 7232 RVA: 0x00096470 File Offset: 0x00094670
		[CallerCount(0)]
		public unsafe static bool4 operator !=(int4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_int4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C41 RID: 7233 RVA: 0x000964BC File Offset: 0x000946BC
		[CallerCount(0)]
		public unsafe static bool4 operator !=(int lhs, int4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_Int32_int4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C42 RID: 7234 RVA: 0x00096508 File Offset: 0x00094708
		[CallerCount(0)]
		public unsafe static int4 operator ~(int4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_OnesComplement_Public_Static_int4_int4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C43 RID: 7235 RVA: 0x00096548 File Offset: 0x00094748
		[CallerCount(0)]
		public unsafe static int4 operator &(int4 lhs, int4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int4_int4_int4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C44 RID: 7236 RVA: 0x00096594 File Offset: 0x00094794
		[CallerCount(0)]
		public unsafe static int4 operator &(int4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int4_int4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C45 RID: 7237 RVA: 0x000965E0 File Offset: 0x000947E0
		[CallerCount(0)]
		public unsafe static int4 operator &(int lhs, int4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int4_Int32_int4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C46 RID: 7238 RVA: 0x0009662C File Offset: 0x0009482C
		[CallerCount(0)]
		public unsafe static int4 operator |(int4 lhs, int4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int4_int4_int4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C47 RID: 7239 RVA: 0x00096678 File Offset: 0x00094878
		[CallerCount(0)]
		public unsafe static int4 operator |(int4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int4_int4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C48 RID: 7240 RVA: 0x000966C4 File Offset: 0x000948C4
		[CallerCount(0)]
		public unsafe static int4 operator |(int lhs, int4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int4_Int32_int4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C49 RID: 7241 RVA: 0x00096710 File Offset: 0x00094910
		[CallerCount(0)]
		public unsafe static int4 operator ^(int4 lhs, int4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int4_int4_int4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C4A RID: 7242 RVA: 0x0009675C File Offset: 0x0009495C
		[CallerCount(0)]
		public unsafe static int4 operator ^(int4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int4_int4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C4B RID: 7243 RVA: 0x000967A8 File Offset: 0x000949A8
		[CallerCount(0)]
		public unsafe static int4 operator ^(int lhs, int4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int4_Int32_int4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06001C4C RID: 7244 RVA: 0x000967F4 File Offset: 0x000949F4
		public unsafe int4 xxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xxxx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x06001C4D RID: 7245 RVA: 0x00096824 File Offset: 0x00094A24
		public unsafe int4 xxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xxxy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x06001C4E RID: 7246 RVA: 0x00096854 File Offset: 0x00094A54
		public unsafe int4 xxxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xxxz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x06001C4F RID: 7247 RVA: 0x00096884 File Offset: 0x00094A84
		public unsafe int4 xxxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xxxw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x06001C50 RID: 7248 RVA: 0x000968B4 File Offset: 0x00094AB4
		public unsafe int4 xxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xxyx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x06001C51 RID: 7249 RVA: 0x000968E4 File Offset: 0x00094AE4
		public unsafe int4 xxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xxyy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x06001C52 RID: 7250 RVA: 0x00096914 File Offset: 0x00094B14
		public unsafe int4 xxyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xxyz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x06001C53 RID: 7251 RVA: 0x00096944 File Offset: 0x00094B44
		public unsafe int4 xxyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xxyw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x06001C54 RID: 7252 RVA: 0x00096974 File Offset: 0x00094B74
		public unsafe int4 xxzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xxzx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x06001C55 RID: 7253 RVA: 0x000969A4 File Offset: 0x00094BA4
		public unsafe int4 xxzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xxzy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x06001C56 RID: 7254 RVA: 0x000969D4 File Offset: 0x00094BD4
		public unsafe int4 xxzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xxzz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x06001C57 RID: 7255 RVA: 0x00096A04 File Offset: 0x00094C04
		public unsafe int4 xxzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xxzw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x06001C58 RID: 7256 RVA: 0x00096A34 File Offset: 0x00094C34
		public unsafe int4 xxwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xxwx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x06001C59 RID: 7257 RVA: 0x00096A64 File Offset: 0x00094C64
		public unsafe int4 xxwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xxwy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x06001C5A RID: 7258 RVA: 0x00096A94 File Offset: 0x00094C94
		public unsafe int4 xxwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xxwz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x06001C5B RID: 7259 RVA: 0x00096AC4 File Offset: 0x00094CC4
		public unsafe int4 xxww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xxww_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x06001C5C RID: 7260 RVA: 0x00096AF4 File Offset: 0x00094CF4
		public unsafe int4 xyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xyxx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x06001C5D RID: 7261 RVA: 0x00096B24 File Offset: 0x00094D24
		public unsafe int4 xyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xyxy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x06001C5E RID: 7262 RVA: 0x00096B54 File Offset: 0x00094D54
		public unsafe int4 xyxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xyxz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x06001C5F RID: 7263 RVA: 0x00096B84 File Offset: 0x00094D84
		public unsafe int4 xyxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xyxw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06001C60 RID: 7264 RVA: 0x00096BB4 File Offset: 0x00094DB4
		public unsafe int4 xyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xyyx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06001C61 RID: 7265 RVA: 0x00096BE4 File Offset: 0x00094DE4
		public unsafe int4 xyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xyyy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x06001C62 RID: 7266 RVA: 0x00096C14 File Offset: 0x00094E14
		public unsafe int4 xyyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xyyz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x06001C63 RID: 7267 RVA: 0x00096C44 File Offset: 0x00094E44
		public unsafe int4 xyyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xyyw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06001C64 RID: 7268 RVA: 0x00096C74 File Offset: 0x00094E74
		public unsafe int4 xyzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xyzx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x06001C65 RID: 7269 RVA: 0x00096CA4 File Offset: 0x00094EA4
		public unsafe int4 xyzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xyzy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x06001C66 RID: 7270 RVA: 0x00096CD4 File Offset: 0x00094ED4
		public unsafe int4 xyzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xyzz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x06001C67 RID: 7271 RVA: 0x00096D04 File Offset: 0x00094F04
		// (set) Token: 0x06001C68 RID: 7272 RVA: 0x00096D34 File Offset: 0x00094F34
		public unsafe int4 xyzw
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 637974, RefRangeEnd = 637984, XrefRangeStart = 637974, XrefRangeEnd = 637984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xyzw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_xyzw_Public_set_Void_int4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06001C69 RID: 7273 RVA: 0x00096D68 File Offset: 0x00094F68
		public unsafe int4 xywx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xywx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06001C6A RID: 7274 RVA: 0x00096D98 File Offset: 0x00094F98
		public unsafe int4 xywy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xywy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06001C6B RID: 7275 RVA: 0x00096DC8 File Offset: 0x00094FC8
		// (set) Token: 0x06001C6C RID: 7276 RVA: 0x00096DF8 File Offset: 0x00094FF8
		public unsafe int4 xywz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xywz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_xywz_Public_set_Void_int4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06001C6D RID: 7277 RVA: 0x00096E2C File Offset: 0x0009502C
		public unsafe int4 xyww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xyww_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06001C6E RID: 7278 RVA: 0x00096E5C File Offset: 0x0009505C
		public unsafe int4 xzxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xzxx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06001C6F RID: 7279 RVA: 0x00096E8C File Offset: 0x0009508C
		public unsafe int4 xzxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xzxy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06001C70 RID: 7280 RVA: 0x00096EBC File Offset: 0x000950BC
		public unsafe int4 xzxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xzxz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06001C71 RID: 7281 RVA: 0x00096EEC File Offset: 0x000950EC
		public unsafe int4 xzxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xzxw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x06001C72 RID: 7282 RVA: 0x00096F1C File Offset: 0x0009511C
		public unsafe int4 xzyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xzyx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x06001C73 RID: 7283 RVA: 0x00096F4C File Offset: 0x0009514C
		public unsafe int4 xzyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xzyy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x06001C74 RID: 7284 RVA: 0x00096F7C File Offset: 0x0009517C
		public unsafe int4 xzyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xzyz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x06001C75 RID: 7285 RVA: 0x00096FAC File Offset: 0x000951AC
		// (set) Token: 0x06001C76 RID: 7286 RVA: 0x00096FDC File Offset: 0x000951DC
		public unsafe int4 xzyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xzyw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_xzyw_Public_set_Void_int4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x06001C77 RID: 7287 RVA: 0x00097010 File Offset: 0x00095210
		public unsafe int4 xzzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xzzx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x06001C78 RID: 7288 RVA: 0x00097040 File Offset: 0x00095240
		public unsafe int4 xzzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xzzy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x06001C79 RID: 7289 RVA: 0x00097070 File Offset: 0x00095270
		public unsafe int4 xzzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xzzz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06001C7A RID: 7290 RVA: 0x000970A0 File Offset: 0x000952A0
		public unsafe int4 xzzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xzzw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x06001C7B RID: 7291 RVA: 0x000970D0 File Offset: 0x000952D0
		public unsafe int4 xzwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xzwx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06001C7C RID: 7292 RVA: 0x00097100 File Offset: 0x00095300
		// (set) Token: 0x06001C7D RID: 7293 RVA: 0x00097130 File Offset: 0x00095330
		public unsafe int4 xzwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xzwy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_xzwy_Public_set_Void_int4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06001C7E RID: 7294 RVA: 0x00097164 File Offset: 0x00095364
		public unsafe int4 xzwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xzwz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06001C7F RID: 7295 RVA: 0x00097194 File Offset: 0x00095394
		public unsafe int4 xzww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xzww_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06001C80 RID: 7296 RVA: 0x000971C4 File Offset: 0x000953C4
		public unsafe int4 xwxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xwxx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x06001C81 RID: 7297 RVA: 0x000971F4 File Offset: 0x000953F4
		public unsafe int4 xwxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xwxy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06001C82 RID: 7298 RVA: 0x00097224 File Offset: 0x00095424
		public unsafe int4 xwxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xwxz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06001C83 RID: 7299 RVA: 0x00097254 File Offset: 0x00095454
		public unsafe int4 xwxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xwxw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06001C84 RID: 7300 RVA: 0x00097284 File Offset: 0x00095484
		public unsafe int4 xwyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xwyx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x06001C85 RID: 7301 RVA: 0x000972B4 File Offset: 0x000954B4
		public unsafe int4 xwyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xwyy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06001C86 RID: 7302 RVA: 0x000972E4 File Offset: 0x000954E4
		// (set) Token: 0x06001C87 RID: 7303 RVA: 0x00097314 File Offset: 0x00095514
		public unsafe int4 xwyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xwyz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_xwyz_Public_set_Void_int4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06001C88 RID: 7304 RVA: 0x00097348 File Offset: 0x00095548
		public unsafe int4 xwyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xwyw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x06001C89 RID: 7305 RVA: 0x00097378 File Offset: 0x00095578
		public unsafe int4 xwzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xwzx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x06001C8A RID: 7306 RVA: 0x000973A8 File Offset: 0x000955A8
		// (set) Token: 0x06001C8B RID: 7307 RVA: 0x000973D8 File Offset: 0x000955D8
		public unsafe int4 xwzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xwzy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_xwzy_Public_set_Void_int4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x06001C8C RID: 7308 RVA: 0x0009740C File Offset: 0x0009560C
		public unsafe int4 xwzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xwzz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06001C8D RID: 7309 RVA: 0x0009743C File Offset: 0x0009563C
		public unsafe int4 xwzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xwzw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x06001C8E RID: 7310 RVA: 0x0009746C File Offset: 0x0009566C
		public unsafe int4 xwwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xwwx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x06001C8F RID: 7311 RVA: 0x0009749C File Offset: 0x0009569C
		public unsafe int4 xwwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xwwy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x06001C90 RID: 7312 RVA: 0x000974CC File Offset: 0x000956CC
		public unsafe int4 xwwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xwwz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x06001C91 RID: 7313 RVA: 0x000974FC File Offset: 0x000956FC
		public unsafe int4 xwww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xwww_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x06001C92 RID: 7314 RVA: 0x0009752C File Offset: 0x0009572C
		public unsafe int4 yxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yxxx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06001C93 RID: 7315 RVA: 0x0009755C File Offset: 0x0009575C
		public unsafe int4 yxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yxxy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x06001C94 RID: 7316 RVA: 0x0009758C File Offset: 0x0009578C
		public unsafe int4 yxxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yxxz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x06001C95 RID: 7317 RVA: 0x000975BC File Offset: 0x000957BC
		public unsafe int4 yxxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yxxw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x06001C96 RID: 7318 RVA: 0x000975EC File Offset: 0x000957EC
		public unsafe int4 yxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yxyx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x06001C97 RID: 7319 RVA: 0x0009761C File Offset: 0x0009581C
		public unsafe int4 yxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yxyy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x06001C98 RID: 7320 RVA: 0x0009764C File Offset: 0x0009584C
		public unsafe int4 yxyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yxyz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x06001C99 RID: 7321 RVA: 0x0009767C File Offset: 0x0009587C
		public unsafe int4 yxyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yxyw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x06001C9A RID: 7322 RVA: 0x000976AC File Offset: 0x000958AC
		public unsafe int4 yxzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yxzx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x06001C9B RID: 7323 RVA: 0x000976DC File Offset: 0x000958DC
		public unsafe int4 yxzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yxzy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x06001C9C RID: 7324 RVA: 0x0009770C File Offset: 0x0009590C
		public unsafe int4 yxzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yxzz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x06001C9D RID: 7325 RVA: 0x0009773C File Offset: 0x0009593C
		// (set) Token: 0x06001C9E RID: 7326 RVA: 0x0009776C File Offset: 0x0009596C
		public unsafe int4 yxzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yxzw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_yxzw_Public_set_Void_int4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06001C9F RID: 7327 RVA: 0x000977A0 File Offset: 0x000959A0
		public unsafe int4 yxwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yxwx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06001CA0 RID: 7328 RVA: 0x000977D0 File Offset: 0x000959D0
		public unsafe int4 yxwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yxwy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06001CA1 RID: 7329 RVA: 0x00097800 File Offset: 0x00095A00
		// (set) Token: 0x06001CA2 RID: 7330 RVA: 0x00097830 File Offset: 0x00095A30
		public unsafe int4 yxwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yxwz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_yxwz_Public_set_Void_int4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x06001CA3 RID: 7331 RVA: 0x00097864 File Offset: 0x00095A64
		public unsafe int4 yxww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yxww_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x06001CA4 RID: 7332 RVA: 0x00097894 File Offset: 0x00095A94
		public unsafe int4 yyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yyxx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x06001CA5 RID: 7333 RVA: 0x000978C4 File Offset: 0x00095AC4
		public unsafe int4 yyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yyxy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06001CA6 RID: 7334 RVA: 0x000978F4 File Offset: 0x00095AF4
		public unsafe int4 yyxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yyxz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06001CA7 RID: 7335 RVA: 0x00097924 File Offset: 0x00095B24
		public unsafe int4 yyxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yyxw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06001CA8 RID: 7336 RVA: 0x00097954 File Offset: 0x00095B54
		public unsafe int4 yyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yyyx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06001CA9 RID: 7337 RVA: 0x00097984 File Offset: 0x00095B84
		public unsafe int4 yyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yyyy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06001CAA RID: 7338 RVA: 0x000979B4 File Offset: 0x00095BB4
		public unsafe int4 yyyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yyyz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x06001CAB RID: 7339 RVA: 0x000979E4 File Offset: 0x00095BE4
		public unsafe int4 yyyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yyyw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x06001CAC RID: 7340 RVA: 0x00097A14 File Offset: 0x00095C14
		public unsafe int4 yyzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yyzx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x06001CAD RID: 7341 RVA: 0x00097A44 File Offset: 0x00095C44
		public unsafe int4 yyzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yyzy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x06001CAE RID: 7342 RVA: 0x00097A74 File Offset: 0x00095C74
		public unsafe int4 yyzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yyzz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x06001CAF RID: 7343 RVA: 0x00097AA4 File Offset: 0x00095CA4
		public unsafe int4 yyzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yyzw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x06001CB0 RID: 7344 RVA: 0x00097AD4 File Offset: 0x00095CD4
		public unsafe int4 yywx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yywx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x06001CB1 RID: 7345 RVA: 0x00097B04 File Offset: 0x00095D04
		public unsafe int4 yywy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yywy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x06001CB2 RID: 7346 RVA: 0x00097B34 File Offset: 0x00095D34
		public unsafe int4 yywz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yywz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x06001CB3 RID: 7347 RVA: 0x00097B64 File Offset: 0x00095D64
		public unsafe int4 yyww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yyww_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x06001CB4 RID: 7348 RVA: 0x00097B94 File Offset: 0x00095D94
		public unsafe int4 yzxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yzxx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x06001CB5 RID: 7349 RVA: 0x00097BC4 File Offset: 0x00095DC4
		public unsafe int4 yzxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yzxy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x06001CB6 RID: 7350 RVA: 0x00097BF4 File Offset: 0x00095DF4
		public unsafe int4 yzxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yzxz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x06001CB7 RID: 7351 RVA: 0x00097C24 File Offset: 0x00095E24
		// (set) Token: 0x06001CB8 RID: 7352 RVA: 0x00097C54 File Offset: 0x00095E54
		public unsafe int4 yzxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yzxw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_yzxw_Public_set_Void_int4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06001CB9 RID: 7353 RVA: 0x00097C88 File Offset: 0x00095E88
		public unsafe int4 yzyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yzyx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x06001CBA RID: 7354 RVA: 0x00097CB8 File Offset: 0x00095EB8
		public unsafe int4 yzyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yzyy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06001CBB RID: 7355 RVA: 0x00097CE8 File Offset: 0x00095EE8
		public unsafe int4 yzyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yzyz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x06001CBC RID: 7356 RVA: 0x00097D18 File Offset: 0x00095F18
		public unsafe int4 yzyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yzyw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x06001CBD RID: 7357 RVA: 0x00097D48 File Offset: 0x00095F48
		public unsafe int4 yzzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yzzx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06001CBE RID: 7358 RVA: 0x00097D78 File Offset: 0x00095F78
		public unsafe int4 yzzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yzzy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x06001CBF RID: 7359 RVA: 0x00097DA8 File Offset: 0x00095FA8
		public unsafe int4 yzzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yzzz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x06001CC0 RID: 7360 RVA: 0x00097DD8 File Offset: 0x00095FD8
		public unsafe int4 yzzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yzzw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x06001CC1 RID: 7361 RVA: 0x00097E08 File Offset: 0x00096008
		// (set) Token: 0x06001CC2 RID: 7362 RVA: 0x00097E38 File Offset: 0x00096038
		public unsafe int4 yzwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yzwx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_yzwx_Public_set_Void_int4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x06001CC3 RID: 7363 RVA: 0x00097E6C File Offset: 0x0009606C
		public unsafe int4 yzwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yzwy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06001CC4 RID: 7364 RVA: 0x00097E9C File Offset: 0x0009609C
		public unsafe int4 yzwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yzwz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x06001CC5 RID: 7365 RVA: 0x00097ECC File Offset: 0x000960CC
		public unsafe int4 yzww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yzww_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x06001CC6 RID: 7366 RVA: 0x00097EFC File Offset: 0x000960FC
		public unsafe int4 ywxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_ywxx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x06001CC7 RID: 7367 RVA: 0x00097F2C File Offset: 0x0009612C
		public unsafe int4 ywxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_ywxy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x06001CC8 RID: 7368 RVA: 0x00097F5C File Offset: 0x0009615C
		// (set) Token: 0x06001CC9 RID: 7369 RVA: 0x00097F8C File Offset: 0x0009618C
		public unsafe int4 ywxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_ywxz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_ywxz_Public_set_Void_int4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x06001CCA RID: 7370 RVA: 0x00097FC0 File Offset: 0x000961C0
		public unsafe int4 ywxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_ywxw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06001CCB RID: 7371 RVA: 0x00097FF0 File Offset: 0x000961F0
		public unsafe int4 ywyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_ywyx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x06001CCC RID: 7372 RVA: 0x00098020 File Offset: 0x00096220
		public unsafe int4 ywyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_ywyy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06001CCD RID: 7373 RVA: 0x00098050 File Offset: 0x00096250
		public unsafe int4 ywyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_ywyz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06001CCE RID: 7374 RVA: 0x00098080 File Offset: 0x00096280
		public unsafe int4 ywyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_ywyw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x06001CCF RID: 7375 RVA: 0x000980B0 File Offset: 0x000962B0
		// (set) Token: 0x06001CD0 RID: 7376 RVA: 0x000980E0 File Offset: 0x000962E0
		public unsafe int4 ywzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_ywzx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_ywzx_Public_set_Void_int4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06001CD1 RID: 7377 RVA: 0x00098114 File Offset: 0x00096314
		public unsafe int4 ywzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_ywzy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x06001CD2 RID: 7378 RVA: 0x00098144 File Offset: 0x00096344
		public unsafe int4 ywzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_ywzz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x06001CD3 RID: 7379 RVA: 0x00098174 File Offset: 0x00096374
		public unsafe int4 ywzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_ywzw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x06001CD4 RID: 7380 RVA: 0x000981A4 File Offset: 0x000963A4
		public unsafe int4 ywwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_ywwx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x06001CD5 RID: 7381 RVA: 0x000981D4 File Offset: 0x000963D4
		public unsafe int4 ywwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_ywwy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x06001CD6 RID: 7382 RVA: 0x00098204 File Offset: 0x00096404
		public unsafe int4 ywwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_ywwz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x06001CD7 RID: 7383 RVA: 0x00098234 File Offset: 0x00096434
		public unsafe int4 ywww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_ywww_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06001CD8 RID: 7384 RVA: 0x00098264 File Offset: 0x00096464
		public unsafe int4 zxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zxxx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x06001CD9 RID: 7385 RVA: 0x00098294 File Offset: 0x00096494
		public unsafe int4 zxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zxxy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x06001CDA RID: 7386 RVA: 0x000982C4 File Offset: 0x000964C4
		public unsafe int4 zxxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zxxz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x06001CDB RID: 7387 RVA: 0x000982F4 File Offset: 0x000964F4
		public unsafe int4 zxxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zxxw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06001CDC RID: 7388 RVA: 0x00098324 File Offset: 0x00096524
		public unsafe int4 zxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zxyx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x06001CDD RID: 7389 RVA: 0x00098354 File Offset: 0x00096554
		public unsafe int4 zxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zxyy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x06001CDE RID: 7390 RVA: 0x00098384 File Offset: 0x00096584
		public unsafe int4 zxyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zxyz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x06001CDF RID: 7391 RVA: 0x000983B4 File Offset: 0x000965B4
		// (set) Token: 0x06001CE0 RID: 7392 RVA: 0x000983E4 File Offset: 0x000965E4
		public unsafe int4 zxyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zxyw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_zxyw_Public_set_Void_int4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06001CE1 RID: 7393 RVA: 0x00098418 File Offset: 0x00096618
		public unsafe int4 zxzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zxzx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06001CE2 RID: 7394 RVA: 0x00098448 File Offset: 0x00096648
		public unsafe int4 zxzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zxzy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x06001CE3 RID: 7395 RVA: 0x00098478 File Offset: 0x00096678
		public unsafe int4 zxzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zxzz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06001CE4 RID: 7396 RVA: 0x000984A8 File Offset: 0x000966A8
		public unsafe int4 zxzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zxzw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x06001CE5 RID: 7397 RVA: 0x000984D8 File Offset: 0x000966D8
		public unsafe int4 zxwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zxwx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06001CE6 RID: 7398 RVA: 0x00098508 File Offset: 0x00096708
		// (set) Token: 0x06001CE7 RID: 7399 RVA: 0x00098538 File Offset: 0x00096738
		public unsafe int4 zxwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zxwy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_zxwy_Public_set_Void_int4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06001CE8 RID: 7400 RVA: 0x0009856C File Offset: 0x0009676C
		public unsafe int4 zxwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zxwz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06001CE9 RID: 7401 RVA: 0x0009859C File Offset: 0x0009679C
		public unsafe int4 zxww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zxww_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06001CEA RID: 7402 RVA: 0x000985CC File Offset: 0x000967CC
		public unsafe int4 zyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zyxx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06001CEB RID: 7403 RVA: 0x000985FC File Offset: 0x000967FC
		public unsafe int4 zyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zyxy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06001CEC RID: 7404 RVA: 0x0009862C File Offset: 0x0009682C
		public unsafe int4 zyxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zyxz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06001CED RID: 7405 RVA: 0x0009865C File Offset: 0x0009685C
		// (set) Token: 0x06001CEE RID: 7406 RVA: 0x0009868C File Offset: 0x0009688C
		public unsafe int4 zyxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zyxw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_zyxw_Public_set_Void_int4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06001CEF RID: 7407 RVA: 0x000986C0 File Offset: 0x000968C0
		public unsafe int4 zyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zyyx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06001CF0 RID: 7408 RVA: 0x000986F0 File Offset: 0x000968F0
		public unsafe int4 zyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zyyy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06001CF1 RID: 7409 RVA: 0x00098720 File Offset: 0x00096920
		public unsafe int4 zyyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zyyz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06001CF2 RID: 7410 RVA: 0x00098750 File Offset: 0x00096950
		public unsafe int4 zyyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zyyw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06001CF3 RID: 7411 RVA: 0x00098780 File Offset: 0x00096980
		public unsafe int4 zyzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zyzx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06001CF4 RID: 7412 RVA: 0x000987B0 File Offset: 0x000969B0
		public unsafe int4 zyzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zyzy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06001CF5 RID: 7413 RVA: 0x000987E0 File Offset: 0x000969E0
		public unsafe int4 zyzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zyzz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06001CF6 RID: 7414 RVA: 0x00098810 File Offset: 0x00096A10
		public unsafe int4 zyzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zyzw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06001CF7 RID: 7415 RVA: 0x00098840 File Offset: 0x00096A40
		// (set) Token: 0x06001CF8 RID: 7416 RVA: 0x00098870 File Offset: 0x00096A70
		public unsafe int4 zywx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zywx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_zywx_Public_set_Void_int4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06001CF9 RID: 7417 RVA: 0x000988A4 File Offset: 0x00096AA4
		public unsafe int4 zywy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zywy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06001CFA RID: 7418 RVA: 0x000988D4 File Offset: 0x00096AD4
		public unsafe int4 zywz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zywz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06001CFB RID: 7419 RVA: 0x00098904 File Offset: 0x00096B04
		public unsafe int4 zyww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zyww_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06001CFC RID: 7420 RVA: 0x00098934 File Offset: 0x00096B34
		public unsafe int4 zzxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zzxx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06001CFD RID: 7421 RVA: 0x00098964 File Offset: 0x00096B64
		public unsafe int4 zzxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zzxy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x06001CFE RID: 7422 RVA: 0x00098994 File Offset: 0x00096B94
		public unsafe int4 zzxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zzxz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06001CFF RID: 7423 RVA: 0x000989C4 File Offset: 0x00096BC4
		public unsafe int4 zzxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zzxw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06001D00 RID: 7424 RVA: 0x000989F4 File Offset: 0x00096BF4
		public unsafe int4 zzyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zzyx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06001D01 RID: 7425 RVA: 0x00098A24 File Offset: 0x00096C24
		public unsafe int4 zzyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zzyy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06001D02 RID: 7426 RVA: 0x00098A54 File Offset: 0x00096C54
		public unsafe int4 zzyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zzyz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06001D03 RID: 7427 RVA: 0x00098A84 File Offset: 0x00096C84
		public unsafe int4 zzyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zzyw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06001D04 RID: 7428 RVA: 0x00098AB4 File Offset: 0x00096CB4
		public unsafe int4 zzzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zzzx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06001D05 RID: 7429 RVA: 0x00098AE4 File Offset: 0x00096CE4
		public unsafe int4 zzzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zzzy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x06001D06 RID: 7430 RVA: 0x00098B14 File Offset: 0x00096D14
		public unsafe int4 zzzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zzzz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06001D07 RID: 7431 RVA: 0x00098B44 File Offset: 0x00096D44
		public unsafe int4 zzzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zzzw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06001D08 RID: 7432 RVA: 0x00098B74 File Offset: 0x00096D74
		public unsafe int4 zzwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zzwx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06001D09 RID: 7433 RVA: 0x00098BA4 File Offset: 0x00096DA4
		public unsafe int4 zzwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zzwy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06001D0A RID: 7434 RVA: 0x00098BD4 File Offset: 0x00096DD4
		public unsafe int4 zzwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zzwz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06001D0B RID: 7435 RVA: 0x00098C04 File Offset: 0x00096E04
		public unsafe int4 zzww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zzww_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06001D0C RID: 7436 RVA: 0x00098C34 File Offset: 0x00096E34
		public unsafe int4 zwxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zwxx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06001D0D RID: 7437 RVA: 0x00098C64 File Offset: 0x00096E64
		// (set) Token: 0x06001D0E RID: 7438 RVA: 0x00098C94 File Offset: 0x00096E94
		public unsafe int4 zwxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zwxy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_zwxy_Public_set_Void_int4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06001D0F RID: 7439 RVA: 0x00098CC8 File Offset: 0x00096EC8
		public unsafe int4 zwxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zwxz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x06001D10 RID: 7440 RVA: 0x00098CF8 File Offset: 0x00096EF8
		public unsafe int4 zwxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zwxw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x06001D11 RID: 7441 RVA: 0x00098D28 File Offset: 0x00096F28
		// (set) Token: 0x06001D12 RID: 7442 RVA: 0x00098D58 File Offset: 0x00096F58
		public unsafe int4 zwyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zwyx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_zwyx_Public_set_Void_int4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06001D13 RID: 7443 RVA: 0x00098D8C File Offset: 0x00096F8C
		public unsafe int4 zwyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zwyy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x06001D14 RID: 7444 RVA: 0x00098DBC File Offset: 0x00096FBC
		public unsafe int4 zwyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zwyz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06001D15 RID: 7445 RVA: 0x00098DEC File Offset: 0x00096FEC
		public unsafe int4 zwyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zwyw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x06001D16 RID: 7446 RVA: 0x00098E1C File Offset: 0x0009701C
		public unsafe int4 zwzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zwzx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06001D17 RID: 7447 RVA: 0x00098E4C File Offset: 0x0009704C
		public unsafe int4 zwzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zwzy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x06001D18 RID: 7448 RVA: 0x00098E7C File Offset: 0x0009707C
		public unsafe int4 zwzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zwzz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x06001D19 RID: 7449 RVA: 0x00098EAC File Offset: 0x000970AC
		public unsafe int4 zwzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zwzw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06001D1A RID: 7450 RVA: 0x00098EDC File Offset: 0x000970DC
		public unsafe int4 zwwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zwwx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06001D1B RID: 7451 RVA: 0x00098F0C File Offset: 0x0009710C
		public unsafe int4 zwwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zwwy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06001D1C RID: 7452 RVA: 0x00098F3C File Offset: 0x0009713C
		public unsafe int4 zwwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zwwz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06001D1D RID: 7453 RVA: 0x00098F6C File Offset: 0x0009716C
		public unsafe int4 zwww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zwww_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x06001D1E RID: 7454 RVA: 0x00098F9C File Offset: 0x0009719C
		public unsafe int4 wxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wxxx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06001D1F RID: 7455 RVA: 0x00098FCC File Offset: 0x000971CC
		public unsafe int4 wxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wxxy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06001D20 RID: 7456 RVA: 0x00098FFC File Offset: 0x000971FC
		public unsafe int4 wxxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wxxz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x06001D21 RID: 7457 RVA: 0x0009902C File Offset: 0x0009722C
		public unsafe int4 wxxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wxxw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06001D22 RID: 7458 RVA: 0x0009905C File Offset: 0x0009725C
		public unsafe int4 wxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wxyx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06001D23 RID: 7459 RVA: 0x0009908C File Offset: 0x0009728C
		public unsafe int4 wxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wxyy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x06001D24 RID: 7460 RVA: 0x000990BC File Offset: 0x000972BC
		// (set) Token: 0x06001D25 RID: 7461 RVA: 0x000990EC File Offset: 0x000972EC
		public unsafe int4 wxyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wxyz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_wxyz_Public_set_Void_int4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x06001D26 RID: 7462 RVA: 0x00099120 File Offset: 0x00097320
		public unsafe int4 wxyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wxyw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x06001D27 RID: 7463 RVA: 0x00099150 File Offset: 0x00097350
		public unsafe int4 wxzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wxzx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x06001D28 RID: 7464 RVA: 0x00099180 File Offset: 0x00097380
		// (set) Token: 0x06001D29 RID: 7465 RVA: 0x000991B0 File Offset: 0x000973B0
		public unsafe int4 wxzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wxzy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_wxzy_Public_set_Void_int4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x06001D2A RID: 7466 RVA: 0x000991E4 File Offset: 0x000973E4
		public unsafe int4 wxzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wxzz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x06001D2B RID: 7467 RVA: 0x00099214 File Offset: 0x00097414
		public unsafe int4 wxzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wxzw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x06001D2C RID: 7468 RVA: 0x00099244 File Offset: 0x00097444
		public unsafe int4 wxwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wxwx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x06001D2D RID: 7469 RVA: 0x00099274 File Offset: 0x00097474
		public unsafe int4 wxwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wxwy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x06001D2E RID: 7470 RVA: 0x000992A4 File Offset: 0x000974A4
		public unsafe int4 wxwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wxwz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x06001D2F RID: 7471 RVA: 0x000992D4 File Offset: 0x000974D4
		public unsafe int4 wxww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wxww_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x06001D30 RID: 7472 RVA: 0x00099304 File Offset: 0x00097504
		public unsafe int4 wyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wyxx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x06001D31 RID: 7473 RVA: 0x00099334 File Offset: 0x00097534
		public unsafe int4 wyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wyxy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x06001D32 RID: 7474 RVA: 0x00099364 File Offset: 0x00097564
		// (set) Token: 0x06001D33 RID: 7475 RVA: 0x00099394 File Offset: 0x00097594
		public unsafe int4 wyxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wyxz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_wyxz_Public_set_Void_int4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x06001D34 RID: 7476 RVA: 0x000993C8 File Offset: 0x000975C8
		public unsafe int4 wyxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wyxw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x06001D35 RID: 7477 RVA: 0x000993F8 File Offset: 0x000975F8
		public unsafe int4 wyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wyyx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x06001D36 RID: 7478 RVA: 0x00099428 File Offset: 0x00097628
		public unsafe int4 wyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wyyy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x06001D37 RID: 7479 RVA: 0x00099458 File Offset: 0x00097658
		public unsafe int4 wyyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wyyz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x06001D38 RID: 7480 RVA: 0x00099488 File Offset: 0x00097688
		public unsafe int4 wyyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wyyw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x06001D39 RID: 7481 RVA: 0x000994B8 File Offset: 0x000976B8
		// (set) Token: 0x06001D3A RID: 7482 RVA: 0x000994E8 File Offset: 0x000976E8
		public unsafe int4 wyzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wyzx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_wyzx_Public_set_Void_int4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x06001D3B RID: 7483 RVA: 0x0009951C File Offset: 0x0009771C
		public unsafe int4 wyzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wyzy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x06001D3C RID: 7484 RVA: 0x0009954C File Offset: 0x0009774C
		public unsafe int4 wyzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wyzz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x06001D3D RID: 7485 RVA: 0x0009957C File Offset: 0x0009777C
		public unsafe int4 wyzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wyzw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x06001D3E RID: 7486 RVA: 0x000995AC File Offset: 0x000977AC
		public unsafe int4 wywx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wywx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x06001D3F RID: 7487 RVA: 0x000995DC File Offset: 0x000977DC
		public unsafe int4 wywy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wywy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x06001D40 RID: 7488 RVA: 0x0009960C File Offset: 0x0009780C
		public unsafe int4 wywz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wywz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x06001D41 RID: 7489 RVA: 0x0009963C File Offset: 0x0009783C
		public unsafe int4 wyww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wyww_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x06001D42 RID: 7490 RVA: 0x0009966C File Offset: 0x0009786C
		public unsafe int4 wzxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wzxx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x06001D43 RID: 7491 RVA: 0x0009969C File Offset: 0x0009789C
		// (set) Token: 0x06001D44 RID: 7492 RVA: 0x000996CC File Offset: 0x000978CC
		public unsafe int4 wzxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wzxy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_wzxy_Public_set_Void_int4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x06001D45 RID: 7493 RVA: 0x00099700 File Offset: 0x00097900
		public unsafe int4 wzxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wzxz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x06001D46 RID: 7494 RVA: 0x00099730 File Offset: 0x00097930
		public unsafe int4 wzxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wzxw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x06001D47 RID: 7495 RVA: 0x00099760 File Offset: 0x00097960
		// (set) Token: 0x06001D48 RID: 7496 RVA: 0x00099790 File Offset: 0x00097990
		public unsafe int4 wzyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wzyx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_wzyx_Public_set_Void_int4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x06001D49 RID: 7497 RVA: 0x000997C4 File Offset: 0x000979C4
		public unsafe int4 wzyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wzyy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x06001D4A RID: 7498 RVA: 0x000997F4 File Offset: 0x000979F4
		public unsafe int4 wzyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wzyz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x06001D4B RID: 7499 RVA: 0x00099824 File Offset: 0x00097A24
		public unsafe int4 wzyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wzyw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x06001D4C RID: 7500 RVA: 0x00099854 File Offset: 0x00097A54
		public unsafe int4 wzzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wzzx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x06001D4D RID: 7501 RVA: 0x00099884 File Offset: 0x00097A84
		public unsafe int4 wzzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wzzy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x06001D4E RID: 7502 RVA: 0x000998B4 File Offset: 0x00097AB4
		public unsafe int4 wzzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wzzz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x06001D4F RID: 7503 RVA: 0x000998E4 File Offset: 0x00097AE4
		public unsafe int4 wzzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wzzw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x06001D50 RID: 7504 RVA: 0x00099914 File Offset: 0x00097B14
		public unsafe int4 wzwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wzwx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x06001D51 RID: 7505 RVA: 0x00099944 File Offset: 0x00097B44
		public unsafe int4 wzwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wzwy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x06001D52 RID: 7506 RVA: 0x00099974 File Offset: 0x00097B74
		public unsafe int4 wzwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wzwz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x06001D53 RID: 7507 RVA: 0x000999A4 File Offset: 0x00097BA4
		public unsafe int4 wzww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wzww_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x06001D54 RID: 7508 RVA: 0x000999D4 File Offset: 0x00097BD4
		public unsafe int4 wwxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wwxx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x06001D55 RID: 7509 RVA: 0x00099A04 File Offset: 0x00097C04
		public unsafe int4 wwxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wwxy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x06001D56 RID: 7510 RVA: 0x00099A34 File Offset: 0x00097C34
		public unsafe int4 wwxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wwxz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x06001D57 RID: 7511 RVA: 0x00099A64 File Offset: 0x00097C64
		public unsafe int4 wwxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wwxw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x06001D58 RID: 7512 RVA: 0x00099A94 File Offset: 0x00097C94
		public unsafe int4 wwyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wwyx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x06001D59 RID: 7513 RVA: 0x00099AC4 File Offset: 0x00097CC4
		public unsafe int4 wwyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wwyy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x06001D5A RID: 7514 RVA: 0x00099AF4 File Offset: 0x00097CF4
		public unsafe int4 wwyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wwyz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x06001D5B RID: 7515 RVA: 0x00099B24 File Offset: 0x00097D24
		public unsafe int4 wwyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wwyw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06001D5C RID: 7516 RVA: 0x00099B54 File Offset: 0x00097D54
		public unsafe int4 wwzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wwzx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x06001D5D RID: 7517 RVA: 0x00099B84 File Offset: 0x00097D84
		public unsafe int4 wwzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wwzy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x06001D5E RID: 7518 RVA: 0x00099BB4 File Offset: 0x00097DB4
		public unsafe int4 wwzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wwzz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x06001D5F RID: 7519 RVA: 0x00099BE4 File Offset: 0x00097DE4
		public unsafe int4 wwzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wwzw_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x06001D60 RID: 7520 RVA: 0x00099C14 File Offset: 0x00097E14
		public unsafe int4 wwwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wwwx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06001D61 RID: 7521 RVA: 0x00099C44 File Offset: 0x00097E44
		public unsafe int4 wwwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wwwy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x06001D62 RID: 7522 RVA: 0x00099C74 File Offset: 0x00097E74
		public unsafe int4 wwwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wwwz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06001D63 RID: 7523 RVA: 0x00099CA4 File Offset: 0x00097EA4
		public unsafe int4 wwww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wwww_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06001D64 RID: 7524 RVA: 0x00099CD4 File Offset: 0x00097ED4
		public unsafe int3 xxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xxx_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x06001D65 RID: 7525 RVA: 0x00099D04 File Offset: 0x00097F04
		public unsafe int3 xxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xxy_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x06001D66 RID: 7526 RVA: 0x00099D34 File Offset: 0x00097F34
		public unsafe int3 xxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xxz_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06001D67 RID: 7527 RVA: 0x00099D64 File Offset: 0x00097F64
		public unsafe int3 xxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xxw_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06001D68 RID: 7528 RVA: 0x00099D94 File Offset: 0x00097F94
		public unsafe int3 xyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xyx_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x06001D69 RID: 7529 RVA: 0x00099DC4 File Offset: 0x00097FC4
		public unsafe int3 xyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xyy_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x06001D6A RID: 7530 RVA: 0x00099DF4 File Offset: 0x00097FF4
		// (set) Token: 0x06001D6B RID: 7531 RVA: 0x00099E24 File Offset: 0x00098024
		public unsafe int3 xyz
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 637161, RefRangeEnd = 637182, XrefRangeStart = 637161, XrefRangeEnd = 637182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xyz_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_xyz_Public_set_Void_int3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x06001D6C RID: 7532 RVA: 0x00099E58 File Offset: 0x00098058
		// (set) Token: 0x06001D6D RID: 7533 RVA: 0x00099E88 File Offset: 0x00098088
		public unsafe int3 xyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xyw_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_xyw_Public_set_Void_int3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x06001D6E RID: 7534 RVA: 0x00099EBC File Offset: 0x000980BC
		public unsafe int3 xzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xzx_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x06001D6F RID: 7535 RVA: 0x00099EEC File Offset: 0x000980EC
		// (set) Token: 0x06001D70 RID: 7536 RVA: 0x00099F1C File Offset: 0x0009811C
		public unsafe int3 xzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xzy_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_xzy_Public_set_Void_int3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x06001D71 RID: 7537 RVA: 0x00099F50 File Offset: 0x00098150
		public unsafe int3 xzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xzz_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x06001D72 RID: 7538 RVA: 0x00099F80 File Offset: 0x00098180
		// (set) Token: 0x06001D73 RID: 7539 RVA: 0x00099FB0 File Offset: 0x000981B0
		public unsafe int3 xzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xzw_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_xzw_Public_set_Void_int3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x06001D74 RID: 7540 RVA: 0x00099FE4 File Offset: 0x000981E4
		public unsafe int3 xwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xwx_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06001D75 RID: 7541 RVA: 0x0009A014 File Offset: 0x00098214
		// (set) Token: 0x06001D76 RID: 7542 RVA: 0x0009A044 File Offset: 0x00098244
		public unsafe int3 xwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xwy_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_xwy_Public_set_Void_int3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06001D77 RID: 7543 RVA: 0x0009A078 File Offset: 0x00098278
		// (set) Token: 0x06001D78 RID: 7544 RVA: 0x0009A0A8 File Offset: 0x000982A8
		public unsafe int3 xwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xwz_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_xwz_Public_set_Void_int3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06001D79 RID: 7545 RVA: 0x0009A0DC File Offset: 0x000982DC
		public unsafe int3 xww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xww_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x06001D7A RID: 7546 RVA: 0x0009A10C File Offset: 0x0009830C
		public unsafe int3 yxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yxx_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x06001D7B RID: 7547 RVA: 0x0009A13C File Offset: 0x0009833C
		public unsafe int3 yxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yxy_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x06001D7C RID: 7548 RVA: 0x0009A16C File Offset: 0x0009836C
		// (set) Token: 0x06001D7D RID: 7549 RVA: 0x0009A19C File Offset: 0x0009839C
		public unsafe int3 yxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yxz_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_yxz_Public_set_Void_int3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x06001D7E RID: 7550 RVA: 0x0009A1D0 File Offset: 0x000983D0
		// (set) Token: 0x06001D7F RID: 7551 RVA: 0x0009A200 File Offset: 0x00098400
		public unsafe int3 yxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yxw_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_yxw_Public_set_Void_int3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06001D80 RID: 7552 RVA: 0x0009A234 File Offset: 0x00098434
		public unsafe int3 yyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yyx_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06001D81 RID: 7553 RVA: 0x0009A264 File Offset: 0x00098464
		public unsafe int3 yyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yyy_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06001D82 RID: 7554 RVA: 0x0009A294 File Offset: 0x00098494
		public unsafe int3 yyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yyz_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06001D83 RID: 7555 RVA: 0x0009A2C4 File Offset: 0x000984C4
		public unsafe int3 yyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yyw_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x06001D84 RID: 7556 RVA: 0x0009A2F4 File Offset: 0x000984F4
		// (set) Token: 0x06001D85 RID: 7557 RVA: 0x0009A324 File Offset: 0x00098524
		public unsafe int3 yzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yzx_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_yzx_Public_set_Void_int3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x06001D86 RID: 7558 RVA: 0x0009A358 File Offset: 0x00098558
		public unsafe int3 yzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yzy_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x06001D87 RID: 7559 RVA: 0x0009A388 File Offset: 0x00098588
		public unsafe int3 yzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yzz_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x06001D88 RID: 7560 RVA: 0x0009A3B8 File Offset: 0x000985B8
		// (set) Token: 0x06001D89 RID: 7561 RVA: 0x0009A3E8 File Offset: 0x000985E8
		public unsafe int3 yzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yzw_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_yzw_Public_set_Void_int3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x06001D8A RID: 7562 RVA: 0x0009A41C File Offset: 0x0009861C
		// (set) Token: 0x06001D8B RID: 7563 RVA: 0x0009A44C File Offset: 0x0009864C
		public unsafe int3 ywx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_ywx_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_ywx_Public_set_Void_int3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06001D8C RID: 7564 RVA: 0x0009A480 File Offset: 0x00098680
		public unsafe int3 ywy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_ywy_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06001D8D RID: 7565 RVA: 0x0009A4B0 File Offset: 0x000986B0
		// (set) Token: 0x06001D8E RID: 7566 RVA: 0x0009A4E0 File Offset: 0x000986E0
		public unsafe int3 ywz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_ywz_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_ywz_Public_set_Void_int3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06001D8F RID: 7567 RVA: 0x0009A514 File Offset: 0x00098714
		public unsafe int3 yww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yww_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x06001D90 RID: 7568 RVA: 0x0009A544 File Offset: 0x00098744
		public unsafe int3 zxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zxx_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x06001D91 RID: 7569 RVA: 0x0009A574 File Offset: 0x00098774
		// (set) Token: 0x06001D92 RID: 7570 RVA: 0x0009A5A4 File Offset: 0x000987A4
		public unsafe int3 zxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zxy_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_zxy_Public_set_Void_int3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x06001D93 RID: 7571 RVA: 0x0009A5D8 File Offset: 0x000987D8
		public unsafe int3 zxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zxz_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x06001D94 RID: 7572 RVA: 0x0009A608 File Offset: 0x00098808
		// (set) Token: 0x06001D95 RID: 7573 RVA: 0x0009A638 File Offset: 0x00098838
		public unsafe int3 zxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zxw_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_zxw_Public_set_Void_int3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x06001D96 RID: 7574 RVA: 0x0009A66C File Offset: 0x0009886C
		// (set) Token: 0x06001D97 RID: 7575 RVA: 0x0009A69C File Offset: 0x0009889C
		public unsafe int3 zyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zyx_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_zyx_Public_set_Void_int3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x06001D98 RID: 7576 RVA: 0x0009A6D0 File Offset: 0x000988D0
		public unsafe int3 zyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zyy_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x06001D99 RID: 7577 RVA: 0x0009A700 File Offset: 0x00098900
		public unsafe int3 zyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zyz_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x06001D9A RID: 7578 RVA: 0x0009A730 File Offset: 0x00098930
		// (set) Token: 0x06001D9B RID: 7579 RVA: 0x0009A760 File Offset: 0x00098960
		public unsafe int3 zyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zyw_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_zyw_Public_set_Void_int3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x06001D9C RID: 7580 RVA: 0x0009A794 File Offset: 0x00098994
		public unsafe int3 zzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zzx_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x06001D9D RID: 7581 RVA: 0x0009A7C4 File Offset: 0x000989C4
		public unsafe int3 zzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zzy_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x06001D9E RID: 7582 RVA: 0x0009A7F4 File Offset: 0x000989F4
		public unsafe int3 zzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zzz_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x06001D9F RID: 7583 RVA: 0x0009A824 File Offset: 0x00098A24
		public unsafe int3 zzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zzw_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x06001DA0 RID: 7584 RVA: 0x0009A854 File Offset: 0x00098A54
		// (set) Token: 0x06001DA1 RID: 7585 RVA: 0x0009A884 File Offset: 0x00098A84
		public unsafe int3 zwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zwx_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_zwx_Public_set_Void_int3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x06001DA2 RID: 7586 RVA: 0x0009A8B8 File Offset: 0x00098AB8
		// (set) Token: 0x06001DA3 RID: 7587 RVA: 0x0009A8E8 File Offset: 0x00098AE8
		public unsafe int3 zwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zwy_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_zwy_Public_set_Void_int3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x06001DA4 RID: 7588 RVA: 0x0009A91C File Offset: 0x00098B1C
		public unsafe int3 zwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zwz_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x06001DA5 RID: 7589 RVA: 0x0009A94C File Offset: 0x00098B4C
		public unsafe int3 zww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zww_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x06001DA6 RID: 7590 RVA: 0x0009A97C File Offset: 0x00098B7C
		public unsafe int3 wxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wxx_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x06001DA7 RID: 7591 RVA: 0x0009A9AC File Offset: 0x00098BAC
		// (set) Token: 0x06001DA8 RID: 7592 RVA: 0x0009A9DC File Offset: 0x00098BDC
		public unsafe int3 wxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wxy_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_wxy_Public_set_Void_int3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x06001DA9 RID: 7593 RVA: 0x0009AA10 File Offset: 0x00098C10
		// (set) Token: 0x06001DAA RID: 7594 RVA: 0x0009AA40 File Offset: 0x00098C40
		public unsafe int3 wxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wxz_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_wxz_Public_set_Void_int3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x06001DAB RID: 7595 RVA: 0x0009AA74 File Offset: 0x00098C74
		public unsafe int3 wxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wxw_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x06001DAC RID: 7596 RVA: 0x0009AAA4 File Offset: 0x00098CA4
		// (set) Token: 0x06001DAD RID: 7597 RVA: 0x0009AAD4 File Offset: 0x00098CD4
		public unsafe int3 wyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wyx_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_wyx_Public_set_Void_int3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x06001DAE RID: 7598 RVA: 0x0009AB08 File Offset: 0x00098D08
		public unsafe int3 wyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wyy_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x06001DAF RID: 7599 RVA: 0x0009AB38 File Offset: 0x00098D38
		// (set) Token: 0x06001DB0 RID: 7600 RVA: 0x0009AB68 File Offset: 0x00098D68
		public unsafe int3 wyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wyz_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_wyz_Public_set_Void_int3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x06001DB1 RID: 7601 RVA: 0x0009AB9C File Offset: 0x00098D9C
		public unsafe int3 wyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wyw_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x06001DB2 RID: 7602 RVA: 0x0009ABCC File Offset: 0x00098DCC
		// (set) Token: 0x06001DB3 RID: 7603 RVA: 0x0009ABFC File Offset: 0x00098DFC
		public unsafe int3 wzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wzx_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_wzx_Public_set_Void_int3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x06001DB4 RID: 7604 RVA: 0x0009AC30 File Offset: 0x00098E30
		// (set) Token: 0x06001DB5 RID: 7605 RVA: 0x0009AC60 File Offset: 0x00098E60
		public unsafe int3 wzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wzy_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_wzy_Public_set_Void_int3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x06001DB6 RID: 7606 RVA: 0x0009AC94 File Offset: 0x00098E94
		public unsafe int3 wzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wzz_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x06001DB7 RID: 7607 RVA: 0x0009ACC4 File Offset: 0x00098EC4
		public unsafe int3 wzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wzw_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x06001DB8 RID: 7608 RVA: 0x0009ACF4 File Offset: 0x00098EF4
		public unsafe int3 wwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wwx_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x06001DB9 RID: 7609 RVA: 0x0009AD24 File Offset: 0x00098F24
		public unsafe int3 wwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wwy_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x06001DBA RID: 7610 RVA: 0x0009AD54 File Offset: 0x00098F54
		public unsafe int3 wwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wwz_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x06001DBB RID: 7611 RVA: 0x0009AD84 File Offset: 0x00098F84
		public unsafe int3 www
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_www_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x06001DBC RID: 7612 RVA: 0x0009ADB4 File Offset: 0x00098FB4
		public unsafe int2 xx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xx_Public_get_int2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x06001DBD RID: 7613 RVA: 0x0009ADE4 File Offset: 0x00098FE4
		// (set) Token: 0x06001DBE RID: 7614 RVA: 0x0009AE14 File Offset: 0x00099014
		public unsafe int2 xy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xy_Public_get_int2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_xy_Public_set_Void_int2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x06001DBF RID: 7615 RVA: 0x0009AE48 File Offset: 0x00099048
		// (set) Token: 0x06001DC0 RID: 7616 RVA: 0x0009AE78 File Offset: 0x00099078
		public unsafe int2 xz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xz_Public_get_int2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_xz_Public_set_Void_int2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x06001DC1 RID: 7617 RVA: 0x0009AEAC File Offset: 0x000990AC
		// (set) Token: 0x06001DC2 RID: 7618 RVA: 0x0009AEDC File Offset: 0x000990DC
		public unsafe int2 xw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_xw_Public_get_int2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_xw_Public_set_Void_int2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x06001DC3 RID: 7619 RVA: 0x0009AF10 File Offset: 0x00099110
		// (set) Token: 0x06001DC4 RID: 7620 RVA: 0x0009AF40 File Offset: 0x00099140
		public unsafe int2 yx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yx_Public_get_int2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_yx_Public_set_Void_int2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x06001DC5 RID: 7621 RVA: 0x0009AF74 File Offset: 0x00099174
		public unsafe int2 yy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yy_Public_get_int2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x06001DC6 RID: 7622 RVA: 0x0009AFA4 File Offset: 0x000991A4
		// (set) Token: 0x06001DC7 RID: 7623 RVA: 0x0009AFD4 File Offset: 0x000991D4
		public unsafe int2 yz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yz_Public_get_int2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_yz_Public_set_Void_int2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x06001DC8 RID: 7624 RVA: 0x0009B008 File Offset: 0x00099208
		// (set) Token: 0x06001DC9 RID: 7625 RVA: 0x0009B038 File Offset: 0x00099238
		public unsafe int2 yw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_yw_Public_get_int2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_yw_Public_set_Void_int2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x06001DCA RID: 7626 RVA: 0x0009B06C File Offset: 0x0009926C
		// (set) Token: 0x06001DCB RID: 7627 RVA: 0x0009B09C File Offset: 0x0009929C
		public unsafe int2 zx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zx_Public_get_int2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_zx_Public_set_Void_int2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x06001DCC RID: 7628 RVA: 0x0009B0D0 File Offset: 0x000992D0
		// (set) Token: 0x06001DCD RID: 7629 RVA: 0x0009B100 File Offset: 0x00099300
		public unsafe int2 zy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zy_Public_get_int2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_zy_Public_set_Void_int2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x06001DCE RID: 7630 RVA: 0x0009B134 File Offset: 0x00099334
		public unsafe int2 zz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zz_Public_get_int2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x06001DCF RID: 7631 RVA: 0x0009B164 File Offset: 0x00099364
		// (set) Token: 0x06001DD0 RID: 7632 RVA: 0x0009B194 File Offset: 0x00099394
		public unsafe int2 zw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_zw_Public_get_int2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_zw_Public_set_Void_int2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x06001DD1 RID: 7633 RVA: 0x0009B1C8 File Offset: 0x000993C8
		// (set) Token: 0x06001DD2 RID: 7634 RVA: 0x0009B1F8 File Offset: 0x000993F8
		public unsafe int2 wx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wx_Public_get_int2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_wx_Public_set_Void_int2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x06001DD3 RID: 7635 RVA: 0x0009B22C File Offset: 0x0009942C
		// (set) Token: 0x06001DD4 RID: 7636 RVA: 0x0009B25C File Offset: 0x0009945C
		public unsafe int2 wy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wy_Public_get_int2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_wy_Public_set_Void_int2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x06001DD5 RID: 7637 RVA: 0x0009B290 File Offset: 0x00099490
		// (set) Token: 0x06001DD6 RID: 7638 RVA: 0x0009B2C0 File Offset: 0x000994C0
		public unsafe int2 wz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_wz_Public_get_int2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_wz_Public_set_Void_int2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06001DD7 RID: 7639 RVA: 0x0009B2F4 File Offset: 0x000994F4
		public unsafe int2 ww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_ww_Public_get_int2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009DC RID: 2524
		public unsafe int this[int index]
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_get_Item_Public_get_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DDA RID: 7642 RVA: 0x0009B3A4 File Offset: 0x000995A4
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 639726, RefRangeEnd = 639747, XrefRangeStart = 639726, XrefRangeEnd = 639726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(int4 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DDB RID: 7643 RVA: 0x0009B3E4 File Offset: 0x000995E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639747, XrefRangeEnd = 639750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DDC RID: 7644 RVA: 0x0009B428 File Offset: 0x00099628
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DDD RID: 7645 RVA: 0x0009B458 File Offset: 0x00099658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639750, XrefRangeEnd = 639773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001DDE RID: 7646 RVA: 0x0009B484 File Offset: 0x00099684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639773, XrefRangeEnd = 639801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001DDF RID: 7647 RVA: 0x000027A0 File Offset: 0x000009A0
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<int4>.NativeClassPtr, ref this));
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x06001DE0 RID: 7648 RVA: 0x0009B4D4 File Offset: 0x000996D4
		// (set) Token: 0x06001DE1 RID: 7649 RVA: 0x000027B2 File Offset: 0x000009B2
		public unsafe static int4 zero
		{
			get
			{
				int4 @int;
				IL2CPP.il2cpp_field_static_get_value(int4.NativeFieldInfoPtr_zero, (void*)(&@int));
				return @int;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(int4.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x04001C72 RID: 7282
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x04001C73 RID: 7283
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04001C74 RID: 7284
		private static readonly IntPtr NativeFieldInfoPtr_z;

		// Token: 0x04001C75 RID: 7285
		private static readonly IntPtr NativeFieldInfoPtr_w;

		// Token: 0x04001C76 RID: 7286
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x04001C77 RID: 7287
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0;

		// Token: 0x04001C78 RID: 7288
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_int2_0;

		// Token: 0x04001C79 RID: 7289
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_int2_Int32_0;

		// Token: 0x04001C7A RID: 7290
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_int3_0;

		// Token: 0x04001C7B RID: 7291
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int2_Int32_Int32_0;

		// Token: 0x04001C7C RID: 7292
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int2_int2_0;

		// Token: 0x04001C7D RID: 7293
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int3_Int32_0;

		// Token: 0x04001C7E RID: 7294
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int4_0;

		// Token: 0x04001C7F RID: 7295
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001C80 RID: 7296
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04001C81 RID: 7297
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool4_0;

		// Token: 0x04001C82 RID: 7298
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04001C83 RID: 7299
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint4_0;

		// Token: 0x04001C84 RID: 7300
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x04001C85 RID: 7301
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float4_0;

		// Token: 0x04001C86 RID: 7302
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x04001C87 RID: 7303
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double4_0;

		// Token: 0x04001C88 RID: 7304
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_int4_Int32_0;

		// Token: 0x04001C89 RID: 7305
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int4_Boolean_0;

		// Token: 0x04001C8A RID: 7306
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int4_bool4_0;

		// Token: 0x04001C8B RID: 7307
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int4_UInt32_0;

		// Token: 0x04001C8C RID: 7308
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int4_uint4_0;

		// Token: 0x04001C8D RID: 7309
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int4_Single_0;

		// Token: 0x04001C8E RID: 7310
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int4_float4_0;

		// Token: 0x04001C8F RID: 7311
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int4_Double_0;

		// Token: 0x04001C90 RID: 7312
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int4_double4_0;

		// Token: 0x04001C91 RID: 7313
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_int4_int4_int4_0;

		// Token: 0x04001C92 RID: 7314
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_int4_int4_Int32_0;

		// Token: 0x04001C93 RID: 7315
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_int4_Int32_int4_0;

		// Token: 0x04001C94 RID: 7316
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_int4_int4_int4_0;

		// Token: 0x04001C95 RID: 7317
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_int4_int4_Int32_0;

		// Token: 0x04001C96 RID: 7318
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_int4_Int32_int4_0;

		// Token: 0x04001C97 RID: 7319
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_int4_int4_int4_0;

		// Token: 0x04001C98 RID: 7320
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_int4_int4_Int32_0;

		// Token: 0x04001C99 RID: 7321
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_int4_Int32_int4_0;

		// Token: 0x04001C9A RID: 7322
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_int4_int4_int4_0;

		// Token: 0x04001C9B RID: 7323
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_int4_int4_Int32_0;

		// Token: 0x04001C9C RID: 7324
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_int4_Int32_int4_0;

		// Token: 0x04001C9D RID: 7325
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_int4_int4_int4_0;

		// Token: 0x04001C9E RID: 7326
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_int4_int4_Int32_0;

		// Token: 0x04001C9F RID: 7327
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_int4_Int32_int4_0;

		// Token: 0x04001CA0 RID: 7328
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_int4_int4_0;

		// Token: 0x04001CA1 RID: 7329
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_int4_int4_0;

		// Token: 0x04001CA2 RID: 7330
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool4_int4_int4_0;

		// Token: 0x04001CA3 RID: 7331
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool4_int4_Int32_0;

		// Token: 0x04001CA4 RID: 7332
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool4_Int32_int4_0;

		// Token: 0x04001CA5 RID: 7333
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4_int4_int4_0;

		// Token: 0x04001CA6 RID: 7334
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4_int4_Int32_0;

		// Token: 0x04001CA7 RID: 7335
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4_Int32_int4_0;

		// Token: 0x04001CA8 RID: 7336
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4_int4_int4_0;

		// Token: 0x04001CA9 RID: 7337
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4_int4_Int32_0;

		// Token: 0x04001CAA RID: 7338
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4_Int32_int4_0;

		// Token: 0x04001CAB RID: 7339
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4_int4_int4_0;

		// Token: 0x04001CAC RID: 7340
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4_int4_Int32_0;

		// Token: 0x04001CAD RID: 7341
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4_Int32_int4_0;

		// Token: 0x04001CAE RID: 7342
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_int4_int4_0;

		// Token: 0x04001CAF RID: 7343
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryPlus_Public_Static_int4_int4_0;

		// Token: 0x04001CB0 RID: 7344
		private static readonly IntPtr NativeMethodInfoPtr_op_LeftShift_Public_Static_int4_int4_Int32_0;

		// Token: 0x04001CB1 RID: 7345
		private static readonly IntPtr NativeMethodInfoPtr_op_RightShift_Public_Static_int4_int4_Int32_0;

		// Token: 0x04001CB2 RID: 7346
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4_int4_int4_0;

		// Token: 0x04001CB3 RID: 7347
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4_int4_Int32_0;

		// Token: 0x04001CB4 RID: 7348
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4_Int32_int4_0;

		// Token: 0x04001CB5 RID: 7349
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_int4_int4_0;

		// Token: 0x04001CB6 RID: 7350
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_int4_Int32_0;

		// Token: 0x04001CB7 RID: 7351
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_Int32_int4_0;

		// Token: 0x04001CB8 RID: 7352
		private static readonly IntPtr NativeMethodInfoPtr_op_OnesComplement_Public_Static_int4_int4_0;

		// Token: 0x04001CB9 RID: 7353
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int4_int4_int4_0;

		// Token: 0x04001CBA RID: 7354
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int4_int4_Int32_0;

		// Token: 0x04001CBB RID: 7355
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int4_Int32_int4_0;

		// Token: 0x04001CBC RID: 7356
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int4_int4_int4_0;

		// Token: 0x04001CBD RID: 7357
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int4_int4_Int32_0;

		// Token: 0x04001CBE RID: 7358
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int4_Int32_int4_0;

		// Token: 0x04001CBF RID: 7359
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int4_int4_int4_0;

		// Token: 0x04001CC0 RID: 7360
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int4_int4_Int32_0;

		// Token: 0x04001CC1 RID: 7361
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int4_Int32_int4_0;

		// Token: 0x04001CC2 RID: 7362
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxx_Public_get_int4_0;

		// Token: 0x04001CC3 RID: 7363
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxy_Public_get_int4_0;

		// Token: 0x04001CC4 RID: 7364
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxz_Public_get_int4_0;

		// Token: 0x04001CC5 RID: 7365
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxw_Public_get_int4_0;

		// Token: 0x04001CC6 RID: 7366
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyx_Public_get_int4_0;

		// Token: 0x04001CC7 RID: 7367
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyy_Public_get_int4_0;

		// Token: 0x04001CC8 RID: 7368
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyz_Public_get_int4_0;

		// Token: 0x04001CC9 RID: 7369
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyw_Public_get_int4_0;

		// Token: 0x04001CCA RID: 7370
		private static readonly IntPtr NativeMethodInfoPtr_get_xxzx_Public_get_int4_0;

		// Token: 0x04001CCB RID: 7371
		private static readonly IntPtr NativeMethodInfoPtr_get_xxzy_Public_get_int4_0;

		// Token: 0x04001CCC RID: 7372
		private static readonly IntPtr NativeMethodInfoPtr_get_xxzz_Public_get_int4_0;

		// Token: 0x04001CCD RID: 7373
		private static readonly IntPtr NativeMethodInfoPtr_get_xxzw_Public_get_int4_0;

		// Token: 0x04001CCE RID: 7374
		private static readonly IntPtr NativeMethodInfoPtr_get_xxwx_Public_get_int4_0;

		// Token: 0x04001CCF RID: 7375
		private static readonly IntPtr NativeMethodInfoPtr_get_xxwy_Public_get_int4_0;

		// Token: 0x04001CD0 RID: 7376
		private static readonly IntPtr NativeMethodInfoPtr_get_xxwz_Public_get_int4_0;

		// Token: 0x04001CD1 RID: 7377
		private static readonly IntPtr NativeMethodInfoPtr_get_xxww_Public_get_int4_0;

		// Token: 0x04001CD2 RID: 7378
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxx_Public_get_int4_0;

		// Token: 0x04001CD3 RID: 7379
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxy_Public_get_int4_0;

		// Token: 0x04001CD4 RID: 7380
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxz_Public_get_int4_0;

		// Token: 0x04001CD5 RID: 7381
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxw_Public_get_int4_0;

		// Token: 0x04001CD6 RID: 7382
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyx_Public_get_int4_0;

		// Token: 0x04001CD7 RID: 7383
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyy_Public_get_int4_0;

		// Token: 0x04001CD8 RID: 7384
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyz_Public_get_int4_0;

		// Token: 0x04001CD9 RID: 7385
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyw_Public_get_int4_0;

		// Token: 0x04001CDA RID: 7386
		private static readonly IntPtr NativeMethodInfoPtr_get_xyzx_Public_get_int4_0;

		// Token: 0x04001CDB RID: 7387
		private static readonly IntPtr NativeMethodInfoPtr_get_xyzy_Public_get_int4_0;

		// Token: 0x04001CDC RID: 7388
		private static readonly IntPtr NativeMethodInfoPtr_get_xyzz_Public_get_int4_0;

		// Token: 0x04001CDD RID: 7389
		private static readonly IntPtr NativeMethodInfoPtr_get_xyzw_Public_get_int4_0;

		// Token: 0x04001CDE RID: 7390
		private static readonly IntPtr NativeMethodInfoPtr_set_xyzw_Public_set_Void_int4_0;

		// Token: 0x04001CDF RID: 7391
		private static readonly IntPtr NativeMethodInfoPtr_get_xywx_Public_get_int4_0;

		// Token: 0x04001CE0 RID: 7392
		private static readonly IntPtr NativeMethodInfoPtr_get_xywy_Public_get_int4_0;

		// Token: 0x04001CE1 RID: 7393
		private static readonly IntPtr NativeMethodInfoPtr_get_xywz_Public_get_int4_0;

		// Token: 0x04001CE2 RID: 7394
		private static readonly IntPtr NativeMethodInfoPtr_set_xywz_Public_set_Void_int4_0;

		// Token: 0x04001CE3 RID: 7395
		private static readonly IntPtr NativeMethodInfoPtr_get_xyww_Public_get_int4_0;

		// Token: 0x04001CE4 RID: 7396
		private static readonly IntPtr NativeMethodInfoPtr_get_xzxx_Public_get_int4_0;

		// Token: 0x04001CE5 RID: 7397
		private static readonly IntPtr NativeMethodInfoPtr_get_xzxy_Public_get_int4_0;

		// Token: 0x04001CE6 RID: 7398
		private static readonly IntPtr NativeMethodInfoPtr_get_xzxz_Public_get_int4_0;

		// Token: 0x04001CE7 RID: 7399
		private static readonly IntPtr NativeMethodInfoPtr_get_xzxw_Public_get_int4_0;

		// Token: 0x04001CE8 RID: 7400
		private static readonly IntPtr NativeMethodInfoPtr_get_xzyx_Public_get_int4_0;

		// Token: 0x04001CE9 RID: 7401
		private static readonly IntPtr NativeMethodInfoPtr_get_xzyy_Public_get_int4_0;

		// Token: 0x04001CEA RID: 7402
		private static readonly IntPtr NativeMethodInfoPtr_get_xzyz_Public_get_int4_0;

		// Token: 0x04001CEB RID: 7403
		private static readonly IntPtr NativeMethodInfoPtr_get_xzyw_Public_get_int4_0;

		// Token: 0x04001CEC RID: 7404
		private static readonly IntPtr NativeMethodInfoPtr_set_xzyw_Public_set_Void_int4_0;

		// Token: 0x04001CED RID: 7405
		private static readonly IntPtr NativeMethodInfoPtr_get_xzzx_Public_get_int4_0;

		// Token: 0x04001CEE RID: 7406
		private static readonly IntPtr NativeMethodInfoPtr_get_xzzy_Public_get_int4_0;

		// Token: 0x04001CEF RID: 7407
		private static readonly IntPtr NativeMethodInfoPtr_get_xzzz_Public_get_int4_0;

		// Token: 0x04001CF0 RID: 7408
		private static readonly IntPtr NativeMethodInfoPtr_get_xzzw_Public_get_int4_0;

		// Token: 0x04001CF1 RID: 7409
		private static readonly IntPtr NativeMethodInfoPtr_get_xzwx_Public_get_int4_0;

		// Token: 0x04001CF2 RID: 7410
		private static readonly IntPtr NativeMethodInfoPtr_get_xzwy_Public_get_int4_0;

		// Token: 0x04001CF3 RID: 7411
		private static readonly IntPtr NativeMethodInfoPtr_set_xzwy_Public_set_Void_int4_0;

		// Token: 0x04001CF4 RID: 7412
		private static readonly IntPtr NativeMethodInfoPtr_get_xzwz_Public_get_int4_0;

		// Token: 0x04001CF5 RID: 7413
		private static readonly IntPtr NativeMethodInfoPtr_get_xzww_Public_get_int4_0;

		// Token: 0x04001CF6 RID: 7414
		private static readonly IntPtr NativeMethodInfoPtr_get_xwxx_Public_get_int4_0;

		// Token: 0x04001CF7 RID: 7415
		private static readonly IntPtr NativeMethodInfoPtr_get_xwxy_Public_get_int4_0;

		// Token: 0x04001CF8 RID: 7416
		private static readonly IntPtr NativeMethodInfoPtr_get_xwxz_Public_get_int4_0;

		// Token: 0x04001CF9 RID: 7417
		private static readonly IntPtr NativeMethodInfoPtr_get_xwxw_Public_get_int4_0;

		// Token: 0x04001CFA RID: 7418
		private static readonly IntPtr NativeMethodInfoPtr_get_xwyx_Public_get_int4_0;

		// Token: 0x04001CFB RID: 7419
		private static readonly IntPtr NativeMethodInfoPtr_get_xwyy_Public_get_int4_0;

		// Token: 0x04001CFC RID: 7420
		private static readonly IntPtr NativeMethodInfoPtr_get_xwyz_Public_get_int4_0;

		// Token: 0x04001CFD RID: 7421
		private static readonly IntPtr NativeMethodInfoPtr_set_xwyz_Public_set_Void_int4_0;

		// Token: 0x04001CFE RID: 7422
		private static readonly IntPtr NativeMethodInfoPtr_get_xwyw_Public_get_int4_0;

		// Token: 0x04001CFF RID: 7423
		private static readonly IntPtr NativeMethodInfoPtr_get_xwzx_Public_get_int4_0;

		// Token: 0x04001D00 RID: 7424
		private static readonly IntPtr NativeMethodInfoPtr_get_xwzy_Public_get_int4_0;

		// Token: 0x04001D01 RID: 7425
		private static readonly IntPtr NativeMethodInfoPtr_set_xwzy_Public_set_Void_int4_0;

		// Token: 0x04001D02 RID: 7426
		private static readonly IntPtr NativeMethodInfoPtr_get_xwzz_Public_get_int4_0;

		// Token: 0x04001D03 RID: 7427
		private static readonly IntPtr NativeMethodInfoPtr_get_xwzw_Public_get_int4_0;

		// Token: 0x04001D04 RID: 7428
		private static readonly IntPtr NativeMethodInfoPtr_get_xwwx_Public_get_int4_0;

		// Token: 0x04001D05 RID: 7429
		private static readonly IntPtr NativeMethodInfoPtr_get_xwwy_Public_get_int4_0;

		// Token: 0x04001D06 RID: 7430
		private static readonly IntPtr NativeMethodInfoPtr_get_xwwz_Public_get_int4_0;

		// Token: 0x04001D07 RID: 7431
		private static readonly IntPtr NativeMethodInfoPtr_get_xwww_Public_get_int4_0;

		// Token: 0x04001D08 RID: 7432
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxx_Public_get_int4_0;

		// Token: 0x04001D09 RID: 7433
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxy_Public_get_int4_0;

		// Token: 0x04001D0A RID: 7434
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxz_Public_get_int4_0;

		// Token: 0x04001D0B RID: 7435
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxw_Public_get_int4_0;

		// Token: 0x04001D0C RID: 7436
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyx_Public_get_int4_0;

		// Token: 0x04001D0D RID: 7437
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyy_Public_get_int4_0;

		// Token: 0x04001D0E RID: 7438
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyz_Public_get_int4_0;

		// Token: 0x04001D0F RID: 7439
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyw_Public_get_int4_0;

		// Token: 0x04001D10 RID: 7440
		private static readonly IntPtr NativeMethodInfoPtr_get_yxzx_Public_get_int4_0;

		// Token: 0x04001D11 RID: 7441
		private static readonly IntPtr NativeMethodInfoPtr_get_yxzy_Public_get_int4_0;

		// Token: 0x04001D12 RID: 7442
		private static readonly IntPtr NativeMethodInfoPtr_get_yxzz_Public_get_int4_0;

		// Token: 0x04001D13 RID: 7443
		private static readonly IntPtr NativeMethodInfoPtr_get_yxzw_Public_get_int4_0;

		// Token: 0x04001D14 RID: 7444
		private static readonly IntPtr NativeMethodInfoPtr_set_yxzw_Public_set_Void_int4_0;

		// Token: 0x04001D15 RID: 7445
		private static readonly IntPtr NativeMethodInfoPtr_get_yxwx_Public_get_int4_0;

		// Token: 0x04001D16 RID: 7446
		private static readonly IntPtr NativeMethodInfoPtr_get_yxwy_Public_get_int4_0;

		// Token: 0x04001D17 RID: 7447
		private static readonly IntPtr NativeMethodInfoPtr_get_yxwz_Public_get_int4_0;

		// Token: 0x04001D18 RID: 7448
		private static readonly IntPtr NativeMethodInfoPtr_set_yxwz_Public_set_Void_int4_0;

		// Token: 0x04001D19 RID: 7449
		private static readonly IntPtr NativeMethodInfoPtr_get_yxww_Public_get_int4_0;

		// Token: 0x04001D1A RID: 7450
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxx_Public_get_int4_0;

		// Token: 0x04001D1B RID: 7451
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxy_Public_get_int4_0;

		// Token: 0x04001D1C RID: 7452
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxz_Public_get_int4_0;

		// Token: 0x04001D1D RID: 7453
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxw_Public_get_int4_0;

		// Token: 0x04001D1E RID: 7454
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyx_Public_get_int4_0;

		// Token: 0x04001D1F RID: 7455
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyy_Public_get_int4_0;

		// Token: 0x04001D20 RID: 7456
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyz_Public_get_int4_0;

		// Token: 0x04001D21 RID: 7457
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyw_Public_get_int4_0;

		// Token: 0x04001D22 RID: 7458
		private static readonly IntPtr NativeMethodInfoPtr_get_yyzx_Public_get_int4_0;

		// Token: 0x04001D23 RID: 7459
		private static readonly IntPtr NativeMethodInfoPtr_get_yyzy_Public_get_int4_0;

		// Token: 0x04001D24 RID: 7460
		private static readonly IntPtr NativeMethodInfoPtr_get_yyzz_Public_get_int4_0;

		// Token: 0x04001D25 RID: 7461
		private static readonly IntPtr NativeMethodInfoPtr_get_yyzw_Public_get_int4_0;

		// Token: 0x04001D26 RID: 7462
		private static readonly IntPtr NativeMethodInfoPtr_get_yywx_Public_get_int4_0;

		// Token: 0x04001D27 RID: 7463
		private static readonly IntPtr NativeMethodInfoPtr_get_yywy_Public_get_int4_0;

		// Token: 0x04001D28 RID: 7464
		private static readonly IntPtr NativeMethodInfoPtr_get_yywz_Public_get_int4_0;

		// Token: 0x04001D29 RID: 7465
		private static readonly IntPtr NativeMethodInfoPtr_get_yyww_Public_get_int4_0;

		// Token: 0x04001D2A RID: 7466
		private static readonly IntPtr NativeMethodInfoPtr_get_yzxx_Public_get_int4_0;

		// Token: 0x04001D2B RID: 7467
		private static readonly IntPtr NativeMethodInfoPtr_get_yzxy_Public_get_int4_0;

		// Token: 0x04001D2C RID: 7468
		private static readonly IntPtr NativeMethodInfoPtr_get_yzxz_Public_get_int4_0;

		// Token: 0x04001D2D RID: 7469
		private static readonly IntPtr NativeMethodInfoPtr_get_yzxw_Public_get_int4_0;

		// Token: 0x04001D2E RID: 7470
		private static readonly IntPtr NativeMethodInfoPtr_set_yzxw_Public_set_Void_int4_0;

		// Token: 0x04001D2F RID: 7471
		private static readonly IntPtr NativeMethodInfoPtr_get_yzyx_Public_get_int4_0;

		// Token: 0x04001D30 RID: 7472
		private static readonly IntPtr NativeMethodInfoPtr_get_yzyy_Public_get_int4_0;

		// Token: 0x04001D31 RID: 7473
		private static readonly IntPtr NativeMethodInfoPtr_get_yzyz_Public_get_int4_0;

		// Token: 0x04001D32 RID: 7474
		private static readonly IntPtr NativeMethodInfoPtr_get_yzyw_Public_get_int4_0;

		// Token: 0x04001D33 RID: 7475
		private static readonly IntPtr NativeMethodInfoPtr_get_yzzx_Public_get_int4_0;

		// Token: 0x04001D34 RID: 7476
		private static readonly IntPtr NativeMethodInfoPtr_get_yzzy_Public_get_int4_0;

		// Token: 0x04001D35 RID: 7477
		private static readonly IntPtr NativeMethodInfoPtr_get_yzzz_Public_get_int4_0;

		// Token: 0x04001D36 RID: 7478
		private static readonly IntPtr NativeMethodInfoPtr_get_yzzw_Public_get_int4_0;

		// Token: 0x04001D37 RID: 7479
		private static readonly IntPtr NativeMethodInfoPtr_get_yzwx_Public_get_int4_0;

		// Token: 0x04001D38 RID: 7480
		private static readonly IntPtr NativeMethodInfoPtr_set_yzwx_Public_set_Void_int4_0;

		// Token: 0x04001D39 RID: 7481
		private static readonly IntPtr NativeMethodInfoPtr_get_yzwy_Public_get_int4_0;

		// Token: 0x04001D3A RID: 7482
		private static readonly IntPtr NativeMethodInfoPtr_get_yzwz_Public_get_int4_0;

		// Token: 0x04001D3B RID: 7483
		private static readonly IntPtr NativeMethodInfoPtr_get_yzww_Public_get_int4_0;

		// Token: 0x04001D3C RID: 7484
		private static readonly IntPtr NativeMethodInfoPtr_get_ywxx_Public_get_int4_0;

		// Token: 0x04001D3D RID: 7485
		private static readonly IntPtr NativeMethodInfoPtr_get_ywxy_Public_get_int4_0;

		// Token: 0x04001D3E RID: 7486
		private static readonly IntPtr NativeMethodInfoPtr_get_ywxz_Public_get_int4_0;

		// Token: 0x04001D3F RID: 7487
		private static readonly IntPtr NativeMethodInfoPtr_set_ywxz_Public_set_Void_int4_0;

		// Token: 0x04001D40 RID: 7488
		private static readonly IntPtr NativeMethodInfoPtr_get_ywxw_Public_get_int4_0;

		// Token: 0x04001D41 RID: 7489
		private static readonly IntPtr NativeMethodInfoPtr_get_ywyx_Public_get_int4_0;

		// Token: 0x04001D42 RID: 7490
		private static readonly IntPtr NativeMethodInfoPtr_get_ywyy_Public_get_int4_0;

		// Token: 0x04001D43 RID: 7491
		private static readonly IntPtr NativeMethodInfoPtr_get_ywyz_Public_get_int4_0;

		// Token: 0x04001D44 RID: 7492
		private static readonly IntPtr NativeMethodInfoPtr_get_ywyw_Public_get_int4_0;

		// Token: 0x04001D45 RID: 7493
		private static readonly IntPtr NativeMethodInfoPtr_get_ywzx_Public_get_int4_0;

		// Token: 0x04001D46 RID: 7494
		private static readonly IntPtr NativeMethodInfoPtr_set_ywzx_Public_set_Void_int4_0;

		// Token: 0x04001D47 RID: 7495
		private static readonly IntPtr NativeMethodInfoPtr_get_ywzy_Public_get_int4_0;

		// Token: 0x04001D48 RID: 7496
		private static readonly IntPtr NativeMethodInfoPtr_get_ywzz_Public_get_int4_0;

		// Token: 0x04001D49 RID: 7497
		private static readonly IntPtr NativeMethodInfoPtr_get_ywzw_Public_get_int4_0;

		// Token: 0x04001D4A RID: 7498
		private static readonly IntPtr NativeMethodInfoPtr_get_ywwx_Public_get_int4_0;

		// Token: 0x04001D4B RID: 7499
		private static readonly IntPtr NativeMethodInfoPtr_get_ywwy_Public_get_int4_0;

		// Token: 0x04001D4C RID: 7500
		private static readonly IntPtr NativeMethodInfoPtr_get_ywwz_Public_get_int4_0;

		// Token: 0x04001D4D RID: 7501
		private static readonly IntPtr NativeMethodInfoPtr_get_ywww_Public_get_int4_0;

		// Token: 0x04001D4E RID: 7502
		private static readonly IntPtr NativeMethodInfoPtr_get_zxxx_Public_get_int4_0;

		// Token: 0x04001D4F RID: 7503
		private static readonly IntPtr NativeMethodInfoPtr_get_zxxy_Public_get_int4_0;

		// Token: 0x04001D50 RID: 7504
		private static readonly IntPtr NativeMethodInfoPtr_get_zxxz_Public_get_int4_0;

		// Token: 0x04001D51 RID: 7505
		private static readonly IntPtr NativeMethodInfoPtr_get_zxxw_Public_get_int4_0;

		// Token: 0x04001D52 RID: 7506
		private static readonly IntPtr NativeMethodInfoPtr_get_zxyx_Public_get_int4_0;

		// Token: 0x04001D53 RID: 7507
		private static readonly IntPtr NativeMethodInfoPtr_get_zxyy_Public_get_int4_0;

		// Token: 0x04001D54 RID: 7508
		private static readonly IntPtr NativeMethodInfoPtr_get_zxyz_Public_get_int4_0;

		// Token: 0x04001D55 RID: 7509
		private static readonly IntPtr NativeMethodInfoPtr_get_zxyw_Public_get_int4_0;

		// Token: 0x04001D56 RID: 7510
		private static readonly IntPtr NativeMethodInfoPtr_set_zxyw_Public_set_Void_int4_0;

		// Token: 0x04001D57 RID: 7511
		private static readonly IntPtr NativeMethodInfoPtr_get_zxzx_Public_get_int4_0;

		// Token: 0x04001D58 RID: 7512
		private static readonly IntPtr NativeMethodInfoPtr_get_zxzy_Public_get_int4_0;

		// Token: 0x04001D59 RID: 7513
		private static readonly IntPtr NativeMethodInfoPtr_get_zxzz_Public_get_int4_0;

		// Token: 0x04001D5A RID: 7514
		private static readonly IntPtr NativeMethodInfoPtr_get_zxzw_Public_get_int4_0;

		// Token: 0x04001D5B RID: 7515
		private static readonly IntPtr NativeMethodInfoPtr_get_zxwx_Public_get_int4_0;

		// Token: 0x04001D5C RID: 7516
		private static readonly IntPtr NativeMethodInfoPtr_get_zxwy_Public_get_int4_0;

		// Token: 0x04001D5D RID: 7517
		private static readonly IntPtr NativeMethodInfoPtr_set_zxwy_Public_set_Void_int4_0;

		// Token: 0x04001D5E RID: 7518
		private static readonly IntPtr NativeMethodInfoPtr_get_zxwz_Public_get_int4_0;

		// Token: 0x04001D5F RID: 7519
		private static readonly IntPtr NativeMethodInfoPtr_get_zxww_Public_get_int4_0;

		// Token: 0x04001D60 RID: 7520
		private static readonly IntPtr NativeMethodInfoPtr_get_zyxx_Public_get_int4_0;

		// Token: 0x04001D61 RID: 7521
		private static readonly IntPtr NativeMethodInfoPtr_get_zyxy_Public_get_int4_0;

		// Token: 0x04001D62 RID: 7522
		private static readonly IntPtr NativeMethodInfoPtr_get_zyxz_Public_get_int4_0;

		// Token: 0x04001D63 RID: 7523
		private static readonly IntPtr NativeMethodInfoPtr_get_zyxw_Public_get_int4_0;

		// Token: 0x04001D64 RID: 7524
		private static readonly IntPtr NativeMethodInfoPtr_set_zyxw_Public_set_Void_int4_0;

		// Token: 0x04001D65 RID: 7525
		private static readonly IntPtr NativeMethodInfoPtr_get_zyyx_Public_get_int4_0;

		// Token: 0x04001D66 RID: 7526
		private static readonly IntPtr NativeMethodInfoPtr_get_zyyy_Public_get_int4_0;

		// Token: 0x04001D67 RID: 7527
		private static readonly IntPtr NativeMethodInfoPtr_get_zyyz_Public_get_int4_0;

		// Token: 0x04001D68 RID: 7528
		private static readonly IntPtr NativeMethodInfoPtr_get_zyyw_Public_get_int4_0;

		// Token: 0x04001D69 RID: 7529
		private static readonly IntPtr NativeMethodInfoPtr_get_zyzx_Public_get_int4_0;

		// Token: 0x04001D6A RID: 7530
		private static readonly IntPtr NativeMethodInfoPtr_get_zyzy_Public_get_int4_0;

		// Token: 0x04001D6B RID: 7531
		private static readonly IntPtr NativeMethodInfoPtr_get_zyzz_Public_get_int4_0;

		// Token: 0x04001D6C RID: 7532
		private static readonly IntPtr NativeMethodInfoPtr_get_zyzw_Public_get_int4_0;

		// Token: 0x04001D6D RID: 7533
		private static readonly IntPtr NativeMethodInfoPtr_get_zywx_Public_get_int4_0;

		// Token: 0x04001D6E RID: 7534
		private static readonly IntPtr NativeMethodInfoPtr_set_zywx_Public_set_Void_int4_0;

		// Token: 0x04001D6F RID: 7535
		private static readonly IntPtr NativeMethodInfoPtr_get_zywy_Public_get_int4_0;

		// Token: 0x04001D70 RID: 7536
		private static readonly IntPtr NativeMethodInfoPtr_get_zywz_Public_get_int4_0;

		// Token: 0x04001D71 RID: 7537
		private static readonly IntPtr NativeMethodInfoPtr_get_zyww_Public_get_int4_0;

		// Token: 0x04001D72 RID: 7538
		private static readonly IntPtr NativeMethodInfoPtr_get_zzxx_Public_get_int4_0;

		// Token: 0x04001D73 RID: 7539
		private static readonly IntPtr NativeMethodInfoPtr_get_zzxy_Public_get_int4_0;

		// Token: 0x04001D74 RID: 7540
		private static readonly IntPtr NativeMethodInfoPtr_get_zzxz_Public_get_int4_0;

		// Token: 0x04001D75 RID: 7541
		private static readonly IntPtr NativeMethodInfoPtr_get_zzxw_Public_get_int4_0;

		// Token: 0x04001D76 RID: 7542
		private static readonly IntPtr NativeMethodInfoPtr_get_zzyx_Public_get_int4_0;

		// Token: 0x04001D77 RID: 7543
		private static readonly IntPtr NativeMethodInfoPtr_get_zzyy_Public_get_int4_0;

		// Token: 0x04001D78 RID: 7544
		private static readonly IntPtr NativeMethodInfoPtr_get_zzyz_Public_get_int4_0;

		// Token: 0x04001D79 RID: 7545
		private static readonly IntPtr NativeMethodInfoPtr_get_zzyw_Public_get_int4_0;

		// Token: 0x04001D7A RID: 7546
		private static readonly IntPtr NativeMethodInfoPtr_get_zzzx_Public_get_int4_0;

		// Token: 0x04001D7B RID: 7547
		private static readonly IntPtr NativeMethodInfoPtr_get_zzzy_Public_get_int4_0;

		// Token: 0x04001D7C RID: 7548
		private static readonly IntPtr NativeMethodInfoPtr_get_zzzz_Public_get_int4_0;

		// Token: 0x04001D7D RID: 7549
		private static readonly IntPtr NativeMethodInfoPtr_get_zzzw_Public_get_int4_0;

		// Token: 0x04001D7E RID: 7550
		private static readonly IntPtr NativeMethodInfoPtr_get_zzwx_Public_get_int4_0;

		// Token: 0x04001D7F RID: 7551
		private static readonly IntPtr NativeMethodInfoPtr_get_zzwy_Public_get_int4_0;

		// Token: 0x04001D80 RID: 7552
		private static readonly IntPtr NativeMethodInfoPtr_get_zzwz_Public_get_int4_0;

		// Token: 0x04001D81 RID: 7553
		private static readonly IntPtr NativeMethodInfoPtr_get_zzww_Public_get_int4_0;

		// Token: 0x04001D82 RID: 7554
		private static readonly IntPtr NativeMethodInfoPtr_get_zwxx_Public_get_int4_0;

		// Token: 0x04001D83 RID: 7555
		private static readonly IntPtr NativeMethodInfoPtr_get_zwxy_Public_get_int4_0;

		// Token: 0x04001D84 RID: 7556
		private static readonly IntPtr NativeMethodInfoPtr_set_zwxy_Public_set_Void_int4_0;

		// Token: 0x04001D85 RID: 7557
		private static readonly IntPtr NativeMethodInfoPtr_get_zwxz_Public_get_int4_0;

		// Token: 0x04001D86 RID: 7558
		private static readonly IntPtr NativeMethodInfoPtr_get_zwxw_Public_get_int4_0;

		// Token: 0x04001D87 RID: 7559
		private static readonly IntPtr NativeMethodInfoPtr_get_zwyx_Public_get_int4_0;

		// Token: 0x04001D88 RID: 7560
		private static readonly IntPtr NativeMethodInfoPtr_set_zwyx_Public_set_Void_int4_0;

		// Token: 0x04001D89 RID: 7561
		private static readonly IntPtr NativeMethodInfoPtr_get_zwyy_Public_get_int4_0;

		// Token: 0x04001D8A RID: 7562
		private static readonly IntPtr NativeMethodInfoPtr_get_zwyz_Public_get_int4_0;

		// Token: 0x04001D8B RID: 7563
		private static readonly IntPtr NativeMethodInfoPtr_get_zwyw_Public_get_int4_0;

		// Token: 0x04001D8C RID: 7564
		private static readonly IntPtr NativeMethodInfoPtr_get_zwzx_Public_get_int4_0;

		// Token: 0x04001D8D RID: 7565
		private static readonly IntPtr NativeMethodInfoPtr_get_zwzy_Public_get_int4_0;

		// Token: 0x04001D8E RID: 7566
		private static readonly IntPtr NativeMethodInfoPtr_get_zwzz_Public_get_int4_0;

		// Token: 0x04001D8F RID: 7567
		private static readonly IntPtr NativeMethodInfoPtr_get_zwzw_Public_get_int4_0;

		// Token: 0x04001D90 RID: 7568
		private static readonly IntPtr NativeMethodInfoPtr_get_zwwx_Public_get_int4_0;

		// Token: 0x04001D91 RID: 7569
		private static readonly IntPtr NativeMethodInfoPtr_get_zwwy_Public_get_int4_0;

		// Token: 0x04001D92 RID: 7570
		private static readonly IntPtr NativeMethodInfoPtr_get_zwwz_Public_get_int4_0;

		// Token: 0x04001D93 RID: 7571
		private static readonly IntPtr NativeMethodInfoPtr_get_zwww_Public_get_int4_0;

		// Token: 0x04001D94 RID: 7572
		private static readonly IntPtr NativeMethodInfoPtr_get_wxxx_Public_get_int4_0;

		// Token: 0x04001D95 RID: 7573
		private static readonly IntPtr NativeMethodInfoPtr_get_wxxy_Public_get_int4_0;

		// Token: 0x04001D96 RID: 7574
		private static readonly IntPtr NativeMethodInfoPtr_get_wxxz_Public_get_int4_0;

		// Token: 0x04001D97 RID: 7575
		private static readonly IntPtr NativeMethodInfoPtr_get_wxxw_Public_get_int4_0;

		// Token: 0x04001D98 RID: 7576
		private static readonly IntPtr NativeMethodInfoPtr_get_wxyx_Public_get_int4_0;

		// Token: 0x04001D99 RID: 7577
		private static readonly IntPtr NativeMethodInfoPtr_get_wxyy_Public_get_int4_0;

		// Token: 0x04001D9A RID: 7578
		private static readonly IntPtr NativeMethodInfoPtr_get_wxyz_Public_get_int4_0;

		// Token: 0x04001D9B RID: 7579
		private static readonly IntPtr NativeMethodInfoPtr_set_wxyz_Public_set_Void_int4_0;

		// Token: 0x04001D9C RID: 7580
		private static readonly IntPtr NativeMethodInfoPtr_get_wxyw_Public_get_int4_0;

		// Token: 0x04001D9D RID: 7581
		private static readonly IntPtr NativeMethodInfoPtr_get_wxzx_Public_get_int4_0;

		// Token: 0x04001D9E RID: 7582
		private static readonly IntPtr NativeMethodInfoPtr_get_wxzy_Public_get_int4_0;

		// Token: 0x04001D9F RID: 7583
		private static readonly IntPtr NativeMethodInfoPtr_set_wxzy_Public_set_Void_int4_0;

		// Token: 0x04001DA0 RID: 7584
		private static readonly IntPtr NativeMethodInfoPtr_get_wxzz_Public_get_int4_0;

		// Token: 0x04001DA1 RID: 7585
		private static readonly IntPtr NativeMethodInfoPtr_get_wxzw_Public_get_int4_0;

		// Token: 0x04001DA2 RID: 7586
		private static readonly IntPtr NativeMethodInfoPtr_get_wxwx_Public_get_int4_0;

		// Token: 0x04001DA3 RID: 7587
		private static readonly IntPtr NativeMethodInfoPtr_get_wxwy_Public_get_int4_0;

		// Token: 0x04001DA4 RID: 7588
		private static readonly IntPtr NativeMethodInfoPtr_get_wxwz_Public_get_int4_0;

		// Token: 0x04001DA5 RID: 7589
		private static readonly IntPtr NativeMethodInfoPtr_get_wxww_Public_get_int4_0;

		// Token: 0x04001DA6 RID: 7590
		private static readonly IntPtr NativeMethodInfoPtr_get_wyxx_Public_get_int4_0;

		// Token: 0x04001DA7 RID: 7591
		private static readonly IntPtr NativeMethodInfoPtr_get_wyxy_Public_get_int4_0;

		// Token: 0x04001DA8 RID: 7592
		private static readonly IntPtr NativeMethodInfoPtr_get_wyxz_Public_get_int4_0;

		// Token: 0x04001DA9 RID: 7593
		private static readonly IntPtr NativeMethodInfoPtr_set_wyxz_Public_set_Void_int4_0;

		// Token: 0x04001DAA RID: 7594
		private static readonly IntPtr NativeMethodInfoPtr_get_wyxw_Public_get_int4_0;

		// Token: 0x04001DAB RID: 7595
		private static readonly IntPtr NativeMethodInfoPtr_get_wyyx_Public_get_int4_0;

		// Token: 0x04001DAC RID: 7596
		private static readonly IntPtr NativeMethodInfoPtr_get_wyyy_Public_get_int4_0;

		// Token: 0x04001DAD RID: 7597
		private static readonly IntPtr NativeMethodInfoPtr_get_wyyz_Public_get_int4_0;

		// Token: 0x04001DAE RID: 7598
		private static readonly IntPtr NativeMethodInfoPtr_get_wyyw_Public_get_int4_0;

		// Token: 0x04001DAF RID: 7599
		private static readonly IntPtr NativeMethodInfoPtr_get_wyzx_Public_get_int4_0;

		// Token: 0x04001DB0 RID: 7600
		private static readonly IntPtr NativeMethodInfoPtr_set_wyzx_Public_set_Void_int4_0;

		// Token: 0x04001DB1 RID: 7601
		private static readonly IntPtr NativeMethodInfoPtr_get_wyzy_Public_get_int4_0;

		// Token: 0x04001DB2 RID: 7602
		private static readonly IntPtr NativeMethodInfoPtr_get_wyzz_Public_get_int4_0;

		// Token: 0x04001DB3 RID: 7603
		private static readonly IntPtr NativeMethodInfoPtr_get_wyzw_Public_get_int4_0;

		// Token: 0x04001DB4 RID: 7604
		private static readonly IntPtr NativeMethodInfoPtr_get_wywx_Public_get_int4_0;

		// Token: 0x04001DB5 RID: 7605
		private static readonly IntPtr NativeMethodInfoPtr_get_wywy_Public_get_int4_0;

		// Token: 0x04001DB6 RID: 7606
		private static readonly IntPtr NativeMethodInfoPtr_get_wywz_Public_get_int4_0;

		// Token: 0x04001DB7 RID: 7607
		private static readonly IntPtr NativeMethodInfoPtr_get_wyww_Public_get_int4_0;

		// Token: 0x04001DB8 RID: 7608
		private static readonly IntPtr NativeMethodInfoPtr_get_wzxx_Public_get_int4_0;

		// Token: 0x04001DB9 RID: 7609
		private static readonly IntPtr NativeMethodInfoPtr_get_wzxy_Public_get_int4_0;

		// Token: 0x04001DBA RID: 7610
		private static readonly IntPtr NativeMethodInfoPtr_set_wzxy_Public_set_Void_int4_0;

		// Token: 0x04001DBB RID: 7611
		private static readonly IntPtr NativeMethodInfoPtr_get_wzxz_Public_get_int4_0;

		// Token: 0x04001DBC RID: 7612
		private static readonly IntPtr NativeMethodInfoPtr_get_wzxw_Public_get_int4_0;

		// Token: 0x04001DBD RID: 7613
		private static readonly IntPtr NativeMethodInfoPtr_get_wzyx_Public_get_int4_0;

		// Token: 0x04001DBE RID: 7614
		private static readonly IntPtr NativeMethodInfoPtr_set_wzyx_Public_set_Void_int4_0;

		// Token: 0x04001DBF RID: 7615
		private static readonly IntPtr NativeMethodInfoPtr_get_wzyy_Public_get_int4_0;

		// Token: 0x04001DC0 RID: 7616
		private static readonly IntPtr NativeMethodInfoPtr_get_wzyz_Public_get_int4_0;

		// Token: 0x04001DC1 RID: 7617
		private static readonly IntPtr NativeMethodInfoPtr_get_wzyw_Public_get_int4_0;

		// Token: 0x04001DC2 RID: 7618
		private static readonly IntPtr NativeMethodInfoPtr_get_wzzx_Public_get_int4_0;

		// Token: 0x04001DC3 RID: 7619
		private static readonly IntPtr NativeMethodInfoPtr_get_wzzy_Public_get_int4_0;

		// Token: 0x04001DC4 RID: 7620
		private static readonly IntPtr NativeMethodInfoPtr_get_wzzz_Public_get_int4_0;

		// Token: 0x04001DC5 RID: 7621
		private static readonly IntPtr NativeMethodInfoPtr_get_wzzw_Public_get_int4_0;

		// Token: 0x04001DC6 RID: 7622
		private static readonly IntPtr NativeMethodInfoPtr_get_wzwx_Public_get_int4_0;

		// Token: 0x04001DC7 RID: 7623
		private static readonly IntPtr NativeMethodInfoPtr_get_wzwy_Public_get_int4_0;

		// Token: 0x04001DC8 RID: 7624
		private static readonly IntPtr NativeMethodInfoPtr_get_wzwz_Public_get_int4_0;

		// Token: 0x04001DC9 RID: 7625
		private static readonly IntPtr NativeMethodInfoPtr_get_wzww_Public_get_int4_0;

		// Token: 0x04001DCA RID: 7626
		private static readonly IntPtr NativeMethodInfoPtr_get_wwxx_Public_get_int4_0;

		// Token: 0x04001DCB RID: 7627
		private static readonly IntPtr NativeMethodInfoPtr_get_wwxy_Public_get_int4_0;

		// Token: 0x04001DCC RID: 7628
		private static readonly IntPtr NativeMethodInfoPtr_get_wwxz_Public_get_int4_0;

		// Token: 0x04001DCD RID: 7629
		private static readonly IntPtr NativeMethodInfoPtr_get_wwxw_Public_get_int4_0;

		// Token: 0x04001DCE RID: 7630
		private static readonly IntPtr NativeMethodInfoPtr_get_wwyx_Public_get_int4_0;

		// Token: 0x04001DCF RID: 7631
		private static readonly IntPtr NativeMethodInfoPtr_get_wwyy_Public_get_int4_0;

		// Token: 0x04001DD0 RID: 7632
		private static readonly IntPtr NativeMethodInfoPtr_get_wwyz_Public_get_int4_0;

		// Token: 0x04001DD1 RID: 7633
		private static readonly IntPtr NativeMethodInfoPtr_get_wwyw_Public_get_int4_0;

		// Token: 0x04001DD2 RID: 7634
		private static readonly IntPtr NativeMethodInfoPtr_get_wwzx_Public_get_int4_0;

		// Token: 0x04001DD3 RID: 7635
		private static readonly IntPtr NativeMethodInfoPtr_get_wwzy_Public_get_int4_0;

		// Token: 0x04001DD4 RID: 7636
		private static readonly IntPtr NativeMethodInfoPtr_get_wwzz_Public_get_int4_0;

		// Token: 0x04001DD5 RID: 7637
		private static readonly IntPtr NativeMethodInfoPtr_get_wwzw_Public_get_int4_0;

		// Token: 0x04001DD6 RID: 7638
		private static readonly IntPtr NativeMethodInfoPtr_get_wwwx_Public_get_int4_0;

		// Token: 0x04001DD7 RID: 7639
		private static readonly IntPtr NativeMethodInfoPtr_get_wwwy_Public_get_int4_0;

		// Token: 0x04001DD8 RID: 7640
		private static readonly IntPtr NativeMethodInfoPtr_get_wwwz_Public_get_int4_0;

		// Token: 0x04001DD9 RID: 7641
		private static readonly IntPtr NativeMethodInfoPtr_get_wwww_Public_get_int4_0;

		// Token: 0x04001DDA RID: 7642
		private static readonly IntPtr NativeMethodInfoPtr_get_xxx_Public_get_int3_0;

		// Token: 0x04001DDB RID: 7643
		private static readonly IntPtr NativeMethodInfoPtr_get_xxy_Public_get_int3_0;

		// Token: 0x04001DDC RID: 7644
		private static readonly IntPtr NativeMethodInfoPtr_get_xxz_Public_get_int3_0;

		// Token: 0x04001DDD RID: 7645
		private static readonly IntPtr NativeMethodInfoPtr_get_xxw_Public_get_int3_0;

		// Token: 0x04001DDE RID: 7646
		private static readonly IntPtr NativeMethodInfoPtr_get_xyx_Public_get_int3_0;

		// Token: 0x04001DDF RID: 7647
		private static readonly IntPtr NativeMethodInfoPtr_get_xyy_Public_get_int3_0;

		// Token: 0x04001DE0 RID: 7648
		private static readonly IntPtr NativeMethodInfoPtr_get_xyz_Public_get_int3_0;

		// Token: 0x04001DE1 RID: 7649
		private static readonly IntPtr NativeMethodInfoPtr_set_xyz_Public_set_Void_int3_0;

		// Token: 0x04001DE2 RID: 7650
		private static readonly IntPtr NativeMethodInfoPtr_get_xyw_Public_get_int3_0;

		// Token: 0x04001DE3 RID: 7651
		private static readonly IntPtr NativeMethodInfoPtr_set_xyw_Public_set_Void_int3_0;

		// Token: 0x04001DE4 RID: 7652
		private static readonly IntPtr NativeMethodInfoPtr_get_xzx_Public_get_int3_0;

		// Token: 0x04001DE5 RID: 7653
		private static readonly IntPtr NativeMethodInfoPtr_get_xzy_Public_get_int3_0;

		// Token: 0x04001DE6 RID: 7654
		private static readonly IntPtr NativeMethodInfoPtr_set_xzy_Public_set_Void_int3_0;

		// Token: 0x04001DE7 RID: 7655
		private static readonly IntPtr NativeMethodInfoPtr_get_xzz_Public_get_int3_0;

		// Token: 0x04001DE8 RID: 7656
		private static readonly IntPtr NativeMethodInfoPtr_get_xzw_Public_get_int3_0;

		// Token: 0x04001DE9 RID: 7657
		private static readonly IntPtr NativeMethodInfoPtr_set_xzw_Public_set_Void_int3_0;

		// Token: 0x04001DEA RID: 7658
		private static readonly IntPtr NativeMethodInfoPtr_get_xwx_Public_get_int3_0;

		// Token: 0x04001DEB RID: 7659
		private static readonly IntPtr NativeMethodInfoPtr_get_xwy_Public_get_int3_0;

		// Token: 0x04001DEC RID: 7660
		private static readonly IntPtr NativeMethodInfoPtr_set_xwy_Public_set_Void_int3_0;

		// Token: 0x04001DED RID: 7661
		private static readonly IntPtr NativeMethodInfoPtr_get_xwz_Public_get_int3_0;

		// Token: 0x04001DEE RID: 7662
		private static readonly IntPtr NativeMethodInfoPtr_set_xwz_Public_set_Void_int3_0;

		// Token: 0x04001DEF RID: 7663
		private static readonly IntPtr NativeMethodInfoPtr_get_xww_Public_get_int3_0;

		// Token: 0x04001DF0 RID: 7664
		private static readonly IntPtr NativeMethodInfoPtr_get_yxx_Public_get_int3_0;

		// Token: 0x04001DF1 RID: 7665
		private static readonly IntPtr NativeMethodInfoPtr_get_yxy_Public_get_int3_0;

		// Token: 0x04001DF2 RID: 7666
		private static readonly IntPtr NativeMethodInfoPtr_get_yxz_Public_get_int3_0;

		// Token: 0x04001DF3 RID: 7667
		private static readonly IntPtr NativeMethodInfoPtr_set_yxz_Public_set_Void_int3_0;

		// Token: 0x04001DF4 RID: 7668
		private static readonly IntPtr NativeMethodInfoPtr_get_yxw_Public_get_int3_0;

		// Token: 0x04001DF5 RID: 7669
		private static readonly IntPtr NativeMethodInfoPtr_set_yxw_Public_set_Void_int3_0;

		// Token: 0x04001DF6 RID: 7670
		private static readonly IntPtr NativeMethodInfoPtr_get_yyx_Public_get_int3_0;

		// Token: 0x04001DF7 RID: 7671
		private static readonly IntPtr NativeMethodInfoPtr_get_yyy_Public_get_int3_0;

		// Token: 0x04001DF8 RID: 7672
		private static readonly IntPtr NativeMethodInfoPtr_get_yyz_Public_get_int3_0;

		// Token: 0x04001DF9 RID: 7673
		private static readonly IntPtr NativeMethodInfoPtr_get_yyw_Public_get_int3_0;

		// Token: 0x04001DFA RID: 7674
		private static readonly IntPtr NativeMethodInfoPtr_get_yzx_Public_get_int3_0;

		// Token: 0x04001DFB RID: 7675
		private static readonly IntPtr NativeMethodInfoPtr_set_yzx_Public_set_Void_int3_0;

		// Token: 0x04001DFC RID: 7676
		private static readonly IntPtr NativeMethodInfoPtr_get_yzy_Public_get_int3_0;

		// Token: 0x04001DFD RID: 7677
		private static readonly IntPtr NativeMethodInfoPtr_get_yzz_Public_get_int3_0;

		// Token: 0x04001DFE RID: 7678
		private static readonly IntPtr NativeMethodInfoPtr_get_yzw_Public_get_int3_0;

		// Token: 0x04001DFF RID: 7679
		private static readonly IntPtr NativeMethodInfoPtr_set_yzw_Public_set_Void_int3_0;

		// Token: 0x04001E00 RID: 7680
		private static readonly IntPtr NativeMethodInfoPtr_get_ywx_Public_get_int3_0;

		// Token: 0x04001E01 RID: 7681
		private static readonly IntPtr NativeMethodInfoPtr_set_ywx_Public_set_Void_int3_0;

		// Token: 0x04001E02 RID: 7682
		private static readonly IntPtr NativeMethodInfoPtr_get_ywy_Public_get_int3_0;

		// Token: 0x04001E03 RID: 7683
		private static readonly IntPtr NativeMethodInfoPtr_get_ywz_Public_get_int3_0;

		// Token: 0x04001E04 RID: 7684
		private static readonly IntPtr NativeMethodInfoPtr_set_ywz_Public_set_Void_int3_0;

		// Token: 0x04001E05 RID: 7685
		private static readonly IntPtr NativeMethodInfoPtr_get_yww_Public_get_int3_0;

		// Token: 0x04001E06 RID: 7686
		private static readonly IntPtr NativeMethodInfoPtr_get_zxx_Public_get_int3_0;

		// Token: 0x04001E07 RID: 7687
		private static readonly IntPtr NativeMethodInfoPtr_get_zxy_Public_get_int3_0;

		// Token: 0x04001E08 RID: 7688
		private static readonly IntPtr NativeMethodInfoPtr_set_zxy_Public_set_Void_int3_0;

		// Token: 0x04001E09 RID: 7689
		private static readonly IntPtr NativeMethodInfoPtr_get_zxz_Public_get_int3_0;

		// Token: 0x04001E0A RID: 7690
		private static readonly IntPtr NativeMethodInfoPtr_get_zxw_Public_get_int3_0;

		// Token: 0x04001E0B RID: 7691
		private static readonly IntPtr NativeMethodInfoPtr_set_zxw_Public_set_Void_int3_0;

		// Token: 0x04001E0C RID: 7692
		private static readonly IntPtr NativeMethodInfoPtr_get_zyx_Public_get_int3_0;

		// Token: 0x04001E0D RID: 7693
		private static readonly IntPtr NativeMethodInfoPtr_set_zyx_Public_set_Void_int3_0;

		// Token: 0x04001E0E RID: 7694
		private static readonly IntPtr NativeMethodInfoPtr_get_zyy_Public_get_int3_0;

		// Token: 0x04001E0F RID: 7695
		private static readonly IntPtr NativeMethodInfoPtr_get_zyz_Public_get_int3_0;

		// Token: 0x04001E10 RID: 7696
		private static readonly IntPtr NativeMethodInfoPtr_get_zyw_Public_get_int3_0;

		// Token: 0x04001E11 RID: 7697
		private static readonly IntPtr NativeMethodInfoPtr_set_zyw_Public_set_Void_int3_0;

		// Token: 0x04001E12 RID: 7698
		private static readonly IntPtr NativeMethodInfoPtr_get_zzx_Public_get_int3_0;

		// Token: 0x04001E13 RID: 7699
		private static readonly IntPtr NativeMethodInfoPtr_get_zzy_Public_get_int3_0;

		// Token: 0x04001E14 RID: 7700
		private static readonly IntPtr NativeMethodInfoPtr_get_zzz_Public_get_int3_0;

		// Token: 0x04001E15 RID: 7701
		private static readonly IntPtr NativeMethodInfoPtr_get_zzw_Public_get_int3_0;

		// Token: 0x04001E16 RID: 7702
		private static readonly IntPtr NativeMethodInfoPtr_get_zwx_Public_get_int3_0;

		// Token: 0x04001E17 RID: 7703
		private static readonly IntPtr NativeMethodInfoPtr_set_zwx_Public_set_Void_int3_0;

		// Token: 0x04001E18 RID: 7704
		private static readonly IntPtr NativeMethodInfoPtr_get_zwy_Public_get_int3_0;

		// Token: 0x04001E19 RID: 7705
		private static readonly IntPtr NativeMethodInfoPtr_set_zwy_Public_set_Void_int3_0;

		// Token: 0x04001E1A RID: 7706
		private static readonly IntPtr NativeMethodInfoPtr_get_zwz_Public_get_int3_0;

		// Token: 0x04001E1B RID: 7707
		private static readonly IntPtr NativeMethodInfoPtr_get_zww_Public_get_int3_0;

		// Token: 0x04001E1C RID: 7708
		private static readonly IntPtr NativeMethodInfoPtr_get_wxx_Public_get_int3_0;

		// Token: 0x04001E1D RID: 7709
		private static readonly IntPtr NativeMethodInfoPtr_get_wxy_Public_get_int3_0;

		// Token: 0x04001E1E RID: 7710
		private static readonly IntPtr NativeMethodInfoPtr_set_wxy_Public_set_Void_int3_0;

		// Token: 0x04001E1F RID: 7711
		private static readonly IntPtr NativeMethodInfoPtr_get_wxz_Public_get_int3_0;

		// Token: 0x04001E20 RID: 7712
		private static readonly IntPtr NativeMethodInfoPtr_set_wxz_Public_set_Void_int3_0;

		// Token: 0x04001E21 RID: 7713
		private static readonly IntPtr NativeMethodInfoPtr_get_wxw_Public_get_int3_0;

		// Token: 0x04001E22 RID: 7714
		private static readonly IntPtr NativeMethodInfoPtr_get_wyx_Public_get_int3_0;

		// Token: 0x04001E23 RID: 7715
		private static readonly IntPtr NativeMethodInfoPtr_set_wyx_Public_set_Void_int3_0;

		// Token: 0x04001E24 RID: 7716
		private static readonly IntPtr NativeMethodInfoPtr_get_wyy_Public_get_int3_0;

		// Token: 0x04001E25 RID: 7717
		private static readonly IntPtr NativeMethodInfoPtr_get_wyz_Public_get_int3_0;

		// Token: 0x04001E26 RID: 7718
		private static readonly IntPtr NativeMethodInfoPtr_set_wyz_Public_set_Void_int3_0;

		// Token: 0x04001E27 RID: 7719
		private static readonly IntPtr NativeMethodInfoPtr_get_wyw_Public_get_int3_0;

		// Token: 0x04001E28 RID: 7720
		private static readonly IntPtr NativeMethodInfoPtr_get_wzx_Public_get_int3_0;

		// Token: 0x04001E29 RID: 7721
		private static readonly IntPtr NativeMethodInfoPtr_set_wzx_Public_set_Void_int3_0;

		// Token: 0x04001E2A RID: 7722
		private static readonly IntPtr NativeMethodInfoPtr_get_wzy_Public_get_int3_0;

		// Token: 0x04001E2B RID: 7723
		private static readonly IntPtr NativeMethodInfoPtr_set_wzy_Public_set_Void_int3_0;

		// Token: 0x04001E2C RID: 7724
		private static readonly IntPtr NativeMethodInfoPtr_get_wzz_Public_get_int3_0;

		// Token: 0x04001E2D RID: 7725
		private static readonly IntPtr NativeMethodInfoPtr_get_wzw_Public_get_int3_0;

		// Token: 0x04001E2E RID: 7726
		private static readonly IntPtr NativeMethodInfoPtr_get_wwx_Public_get_int3_0;

		// Token: 0x04001E2F RID: 7727
		private static readonly IntPtr NativeMethodInfoPtr_get_wwy_Public_get_int3_0;

		// Token: 0x04001E30 RID: 7728
		private static readonly IntPtr NativeMethodInfoPtr_get_wwz_Public_get_int3_0;

		// Token: 0x04001E31 RID: 7729
		private static readonly IntPtr NativeMethodInfoPtr_get_www_Public_get_int3_0;

		// Token: 0x04001E32 RID: 7730
		private static readonly IntPtr NativeMethodInfoPtr_get_xx_Public_get_int2_0;

		// Token: 0x04001E33 RID: 7731
		private static readonly IntPtr NativeMethodInfoPtr_get_xy_Public_get_int2_0;

		// Token: 0x04001E34 RID: 7732
		private static readonly IntPtr NativeMethodInfoPtr_set_xy_Public_set_Void_int2_0;

		// Token: 0x04001E35 RID: 7733
		private static readonly IntPtr NativeMethodInfoPtr_get_xz_Public_get_int2_0;

		// Token: 0x04001E36 RID: 7734
		private static readonly IntPtr NativeMethodInfoPtr_set_xz_Public_set_Void_int2_0;

		// Token: 0x04001E37 RID: 7735
		private static readonly IntPtr NativeMethodInfoPtr_get_xw_Public_get_int2_0;

		// Token: 0x04001E38 RID: 7736
		private static readonly IntPtr NativeMethodInfoPtr_set_xw_Public_set_Void_int2_0;

		// Token: 0x04001E39 RID: 7737
		private static readonly IntPtr NativeMethodInfoPtr_get_yx_Public_get_int2_0;

		// Token: 0x04001E3A RID: 7738
		private static readonly IntPtr NativeMethodInfoPtr_set_yx_Public_set_Void_int2_0;

		// Token: 0x04001E3B RID: 7739
		private static readonly IntPtr NativeMethodInfoPtr_get_yy_Public_get_int2_0;

		// Token: 0x04001E3C RID: 7740
		private static readonly IntPtr NativeMethodInfoPtr_get_yz_Public_get_int2_0;

		// Token: 0x04001E3D RID: 7741
		private static readonly IntPtr NativeMethodInfoPtr_set_yz_Public_set_Void_int2_0;

		// Token: 0x04001E3E RID: 7742
		private static readonly IntPtr NativeMethodInfoPtr_get_yw_Public_get_int2_0;

		// Token: 0x04001E3F RID: 7743
		private static readonly IntPtr NativeMethodInfoPtr_set_yw_Public_set_Void_int2_0;

		// Token: 0x04001E40 RID: 7744
		private static readonly IntPtr NativeMethodInfoPtr_get_zx_Public_get_int2_0;

		// Token: 0x04001E41 RID: 7745
		private static readonly IntPtr NativeMethodInfoPtr_set_zx_Public_set_Void_int2_0;

		// Token: 0x04001E42 RID: 7746
		private static readonly IntPtr NativeMethodInfoPtr_get_zy_Public_get_int2_0;

		// Token: 0x04001E43 RID: 7747
		private static readonly IntPtr NativeMethodInfoPtr_set_zy_Public_set_Void_int2_0;

		// Token: 0x04001E44 RID: 7748
		private static readonly IntPtr NativeMethodInfoPtr_get_zz_Public_get_int2_0;

		// Token: 0x04001E45 RID: 7749
		private static readonly IntPtr NativeMethodInfoPtr_get_zw_Public_get_int2_0;

		// Token: 0x04001E46 RID: 7750
		private static readonly IntPtr NativeMethodInfoPtr_set_zw_Public_set_Void_int2_0;

		// Token: 0x04001E47 RID: 7751
		private static readonly IntPtr NativeMethodInfoPtr_get_wx_Public_get_int2_0;

		// Token: 0x04001E48 RID: 7752
		private static readonly IntPtr NativeMethodInfoPtr_set_wx_Public_set_Void_int2_0;

		// Token: 0x04001E49 RID: 7753
		private static readonly IntPtr NativeMethodInfoPtr_get_wy_Public_get_int2_0;

		// Token: 0x04001E4A RID: 7754
		private static readonly IntPtr NativeMethodInfoPtr_set_wy_Public_set_Void_int2_0;

		// Token: 0x04001E4B RID: 7755
		private static readonly IntPtr NativeMethodInfoPtr_get_wz_Public_get_int2_0;

		// Token: 0x04001E4C RID: 7756
		private static readonly IntPtr NativeMethodInfoPtr_set_wz_Public_set_Void_int2_0;

		// Token: 0x04001E4D RID: 7757
		private static readonly IntPtr NativeMethodInfoPtr_get_ww_Public_get_int2_0;

		// Token: 0x04001E4E RID: 7758
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Int32_Int32_0;

		// Token: 0x04001E4F RID: 7759
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_0;

		// Token: 0x04001E50 RID: 7760
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_int4_0;

		// Token: 0x04001E51 RID: 7761
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001E52 RID: 7762
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001E53 RID: 7763
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001E54 RID: 7764
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04001E55 RID: 7765
		[FieldOffset(0)]
		public int x;

		// Token: 0x04001E56 RID: 7766
		[FieldOffset(4)]
		public int y;

		// Token: 0x04001E57 RID: 7767
		[FieldOffset(8)]
		public int z;

		// Token: 0x04001E58 RID: 7768
		[FieldOffset(12)]
		public int w;

		// Token: 0x02000062 RID: 98
		public sealed class DebuggerProxy : Object
		{
			// Token: 0x06002635 RID: 9781 RVA: 0x000C3E68 File Offset: 0x000C2068
			// Note: this type is marked as 'beforefieldinit'.
			static DebuggerProxy()
			{
				Il2CppClassPointerStore<int4.DebuggerProxy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<int4>.NativeClassPtr, "DebuggerProxy");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<int4.DebuggerProxy>.NativeClassPtr);
				int4.DebuggerProxy.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int4.DebuggerProxy>.NativeClassPtr, "x");
				int4.DebuggerProxy.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int4.DebuggerProxy>.NativeClassPtr, "y");
				int4.DebuggerProxy.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int4.DebuggerProxy>.NativeClassPtr, "z");
				int4.DebuggerProxy.NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int4.DebuggerProxy>.NativeClassPtr, "w");
				int4.DebuggerProxy.NativeMethodInfoPtr__ctor_Public_Void_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4.DebuggerProxy>.NativeClassPtr, 100670731);
			}

			// Token: 0x06002636 RID: 9782 RVA: 0x000C3EF8 File Offset: 0x000C20F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DebuggerProxy(int4 v)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<int4.DebuggerProxy>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4.DebuggerProxy.NativeMethodInfoPtr__ctor_Public_Void_int4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002637 RID: 9783 RVA: 0x000030A8 File Offset: 0x000012A8
			public DebuggerProxy(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C1A RID: 3098
			// (get) Token: 0x06002638 RID: 9784 RVA: 0x000C3F40 File Offset: 0x000C2140
			// (set) Token: 0x06002639 RID: 9785 RVA: 0x000030B1 File Offset: 0x000012B1
			public unsafe int x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(int4.DebuggerProxy.NativeFieldInfoPtr_x);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(int4.DebuggerProxy.NativeFieldInfoPtr_x)) = value;
				}
			}

			// Token: 0x17000C1B RID: 3099
			// (get) Token: 0x0600263A RID: 9786 RVA: 0x000C3F68 File Offset: 0x000C2168
			// (set) Token: 0x0600263B RID: 9787 RVA: 0x000030CC File Offset: 0x000012CC
			public unsafe int y
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(int4.DebuggerProxy.NativeFieldInfoPtr_y);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(int4.DebuggerProxy.NativeFieldInfoPtr_y)) = value;
				}
			}

			// Token: 0x17000C1C RID: 3100
			// (get) Token: 0x0600263C RID: 9788 RVA: 0x000C3F90 File Offset: 0x000C2190
			// (set) Token: 0x0600263D RID: 9789 RVA: 0x000030E7 File Offset: 0x000012E7
			public unsafe int z
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(int4.DebuggerProxy.NativeFieldInfoPtr_z);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(int4.DebuggerProxy.NativeFieldInfoPtr_z)) = value;
				}
			}

			// Token: 0x17000C1D RID: 3101
			// (get) Token: 0x0600263E RID: 9790 RVA: 0x000C3FB8 File Offset: 0x000C21B8
			// (set) Token: 0x0600263F RID: 9791 RVA: 0x00003102 File Offset: 0x00001302
			public unsafe int w
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(int4.DebuggerProxy.NativeFieldInfoPtr_w);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(int4.DebuggerProxy.NativeFieldInfoPtr_w)) = value;
				}
			}

			// Token: 0x04002693 RID: 9875
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04002694 RID: 9876
			private static readonly IntPtr NativeFieldInfoPtr_y;

			// Token: 0x04002695 RID: 9877
			private static readonly IntPtr NativeFieldInfoPtr_z;

			// Token: 0x04002696 RID: 9878
			private static readonly IntPtr NativeFieldInfoPtr_w;

			// Token: 0x04002697 RID: 9879
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int4_0;
		}
	}
}
