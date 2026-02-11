using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x02000019 RID: 25
	[Serializable]
	[StructLayout(2)]
	public struct double4
	{
		// Token: 0x06000DEB RID: 3563 RVA: 0x0004E1F0 File Offset: 0x0004C3F0
		// Note: this type is marked as 'beforefieldinit'.
		static double4()
		{
			Il2CppClassPointerStore<double4>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "double4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<double4>.NativeClassPtr);
			double4.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double4>.NativeClassPtr, "x");
			double4.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double4>.NativeClassPtr, "y");
			double4.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double4>.NativeClassPtr, "z");
			double4.NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double4>.NativeClassPtr, "w");
			double4.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double4>.NativeClassPtr, "zero");
			double4.NativeMethodInfoPtr__ctor_Public_Void_Double_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666756);
			double4.NativeMethodInfoPtr__ctor_Public_Void_Double_Double_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666757);
			double4.NativeMethodInfoPtr__ctor_Public_Void_Double_double2_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666758);
			double4.NativeMethodInfoPtr__ctor_Public_Void_Double_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666759);
			double4.NativeMethodInfoPtr__ctor_Public_Void_double2_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666760);
			double4.NativeMethodInfoPtr__ctor_Public_Void_double2_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666761);
			double4.NativeMethodInfoPtr__ctor_Public_Void_double3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666762);
			double4.NativeMethodInfoPtr__ctor_Public_Void_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666763);
			double4.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666764);
			double4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666765);
			double4.NativeMethodInfoPtr__ctor_Public_Void_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666766);
			double4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666767);
			double4.NativeMethodInfoPtr__ctor_Public_Void_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666768);
			double4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666769);
			double4.NativeMethodInfoPtr__ctor_Public_Void_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666770);
			double4.NativeMethodInfoPtr__ctor_Public_Void_half_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666771);
			double4.NativeMethodInfoPtr__ctor_Public_Void_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666772);
			double4.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666773);
			double4.NativeMethodInfoPtr__ctor_Public_Void_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666774);
			double4.NativeMethodInfoPtr_op_Implicit_Public_Static_double4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666775);
			double4.NativeMethodInfoPtr_op_Explicit_Public_Static_double4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666776);
			double4.NativeMethodInfoPtr_op_Explicit_Public_Static_double4_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666777);
			double4.NativeMethodInfoPtr_op_Implicit_Public_Static_double4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666778);
			double4.NativeMethodInfoPtr_op_Implicit_Public_Static_double4_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666779);
			double4.NativeMethodInfoPtr_op_Implicit_Public_Static_double4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666780);
			double4.NativeMethodInfoPtr_op_Implicit_Public_Static_double4_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666781);
			double4.NativeMethodInfoPtr_op_Implicit_Public_Static_double4_half_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666782);
			double4.NativeMethodInfoPtr_op_Implicit_Public_Static_double4_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666783);
			double4.NativeMethodInfoPtr_op_Implicit_Public_Static_double4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666784);
			double4.NativeMethodInfoPtr_op_Implicit_Public_Static_double4_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666785);
			double4.NativeMethodInfoPtr_op_Multiply_Public_Static_double4_double4_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666786);
			double4.NativeMethodInfoPtr_op_Multiply_Public_Static_double4_double4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666787);
			double4.NativeMethodInfoPtr_op_Multiply_Public_Static_double4_Double_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666788);
			double4.NativeMethodInfoPtr_op_Addition_Public_Static_double4_double4_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666789);
			double4.NativeMethodInfoPtr_op_Addition_Public_Static_double4_double4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666790);
			double4.NativeMethodInfoPtr_op_Addition_Public_Static_double4_Double_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666791);
			double4.NativeMethodInfoPtr_op_Subtraction_Public_Static_double4_double4_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666792);
			double4.NativeMethodInfoPtr_op_Subtraction_Public_Static_double4_double4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666793);
			double4.NativeMethodInfoPtr_op_Subtraction_Public_Static_double4_Double_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666794);
			double4.NativeMethodInfoPtr_op_Division_Public_Static_double4_double4_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666795);
			double4.NativeMethodInfoPtr_op_Division_Public_Static_double4_double4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666796);
			double4.NativeMethodInfoPtr_op_Division_Public_Static_double4_Double_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666797);
			double4.NativeMethodInfoPtr_op_Modulus_Public_Static_double4_double4_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666798);
			double4.NativeMethodInfoPtr_op_Modulus_Public_Static_double4_double4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666799);
			double4.NativeMethodInfoPtr_op_Modulus_Public_Static_double4_Double_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666800);
			double4.NativeMethodInfoPtr_op_Increment_Public_Static_double4_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666801);
			double4.NativeMethodInfoPtr_op_Decrement_Public_Static_double4_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666802);
			double4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4_double4_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666803);
			double4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4_double4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666804);
			double4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4_Double_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666805);
			double4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4_double4_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666806);
			double4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4_double4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666807);
			double4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4_Double_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666808);
			double4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4_double4_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666809);
			double4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4_double4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666810);
			double4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4_Double_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666811);
			double4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4_double4_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666812);
			double4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4_double4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666813);
			double4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4_Double_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666814);
			double4.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_double4_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666815);
			double4.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_double4_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666816);
			double4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4_double4_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666817);
			double4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4_double4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666818);
			double4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4_Double_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666819);
			double4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_double4_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666820);
			double4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_double4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666821);
			double4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_Double_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666822);
			double4.NativeMethodInfoPtr_get_xxxx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666823);
			double4.NativeMethodInfoPtr_get_xxxy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666824);
			double4.NativeMethodInfoPtr_get_xxxz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666825);
			double4.NativeMethodInfoPtr_get_xxxw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666826);
			double4.NativeMethodInfoPtr_get_xxyx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666827);
			double4.NativeMethodInfoPtr_get_xxyy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666828);
			double4.NativeMethodInfoPtr_get_xxyz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666829);
			double4.NativeMethodInfoPtr_get_xxyw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666830);
			double4.NativeMethodInfoPtr_get_xxzx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666831);
			double4.NativeMethodInfoPtr_get_xxzy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666832);
			double4.NativeMethodInfoPtr_get_xxzz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666833);
			double4.NativeMethodInfoPtr_get_xxzw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666834);
			double4.NativeMethodInfoPtr_get_xxwx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666835);
			double4.NativeMethodInfoPtr_get_xxwy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666836);
			double4.NativeMethodInfoPtr_get_xxwz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666837);
			double4.NativeMethodInfoPtr_get_xxww_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666838);
			double4.NativeMethodInfoPtr_get_xyxx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666839);
			double4.NativeMethodInfoPtr_get_xyxy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666840);
			double4.NativeMethodInfoPtr_get_xyxz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666841);
			double4.NativeMethodInfoPtr_get_xyxw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666842);
			double4.NativeMethodInfoPtr_get_xyyx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666843);
			double4.NativeMethodInfoPtr_get_xyyy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666844);
			double4.NativeMethodInfoPtr_get_xyyz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666845);
			double4.NativeMethodInfoPtr_get_xyyw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666846);
			double4.NativeMethodInfoPtr_get_xyzx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666847);
			double4.NativeMethodInfoPtr_get_xyzy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666848);
			double4.NativeMethodInfoPtr_get_xyzz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666849);
			double4.NativeMethodInfoPtr_get_xyzw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666850);
			double4.NativeMethodInfoPtr_set_xyzw_Public_set_Void_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666851);
			double4.NativeMethodInfoPtr_get_xywx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666852);
			double4.NativeMethodInfoPtr_get_xywy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666853);
			double4.NativeMethodInfoPtr_get_xywz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666854);
			double4.NativeMethodInfoPtr_set_xywz_Public_set_Void_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666855);
			double4.NativeMethodInfoPtr_get_xyww_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666856);
			double4.NativeMethodInfoPtr_get_xzxx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666857);
			double4.NativeMethodInfoPtr_get_xzxy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666858);
			double4.NativeMethodInfoPtr_get_xzxz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666859);
			double4.NativeMethodInfoPtr_get_xzxw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666860);
			double4.NativeMethodInfoPtr_get_xzyx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666861);
			double4.NativeMethodInfoPtr_get_xzyy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666862);
			double4.NativeMethodInfoPtr_get_xzyz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666863);
			double4.NativeMethodInfoPtr_get_xzyw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666864);
			double4.NativeMethodInfoPtr_set_xzyw_Public_set_Void_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666865);
			double4.NativeMethodInfoPtr_get_xzzx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666866);
			double4.NativeMethodInfoPtr_get_xzzy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666867);
			double4.NativeMethodInfoPtr_get_xzzz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666868);
			double4.NativeMethodInfoPtr_get_xzzw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666869);
			double4.NativeMethodInfoPtr_get_xzwx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666870);
			double4.NativeMethodInfoPtr_get_xzwy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666871);
			double4.NativeMethodInfoPtr_set_xzwy_Public_set_Void_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666872);
			double4.NativeMethodInfoPtr_get_xzwz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666873);
			double4.NativeMethodInfoPtr_get_xzww_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666874);
			double4.NativeMethodInfoPtr_get_xwxx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666875);
			double4.NativeMethodInfoPtr_get_xwxy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666876);
			double4.NativeMethodInfoPtr_get_xwxz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666877);
			double4.NativeMethodInfoPtr_get_xwxw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666878);
			double4.NativeMethodInfoPtr_get_xwyx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666879);
			double4.NativeMethodInfoPtr_get_xwyy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666880);
			double4.NativeMethodInfoPtr_get_xwyz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666881);
			double4.NativeMethodInfoPtr_set_xwyz_Public_set_Void_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666882);
			double4.NativeMethodInfoPtr_get_xwyw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666883);
			double4.NativeMethodInfoPtr_get_xwzx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666884);
			double4.NativeMethodInfoPtr_get_xwzy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666885);
			double4.NativeMethodInfoPtr_set_xwzy_Public_set_Void_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666886);
			double4.NativeMethodInfoPtr_get_xwzz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666887);
			double4.NativeMethodInfoPtr_get_xwzw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666888);
			double4.NativeMethodInfoPtr_get_xwwx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666889);
			double4.NativeMethodInfoPtr_get_xwwy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666890);
			double4.NativeMethodInfoPtr_get_xwwz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666891);
			double4.NativeMethodInfoPtr_get_xwww_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666892);
			double4.NativeMethodInfoPtr_get_yxxx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666893);
			double4.NativeMethodInfoPtr_get_yxxy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666894);
			double4.NativeMethodInfoPtr_get_yxxz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666895);
			double4.NativeMethodInfoPtr_get_yxxw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666896);
			double4.NativeMethodInfoPtr_get_yxyx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666897);
			double4.NativeMethodInfoPtr_get_yxyy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666898);
			double4.NativeMethodInfoPtr_get_yxyz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666899);
			double4.NativeMethodInfoPtr_get_yxyw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666900);
			double4.NativeMethodInfoPtr_get_yxzx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666901);
			double4.NativeMethodInfoPtr_get_yxzy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666902);
			double4.NativeMethodInfoPtr_get_yxzz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666903);
			double4.NativeMethodInfoPtr_get_yxzw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666904);
			double4.NativeMethodInfoPtr_set_yxzw_Public_set_Void_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666905);
			double4.NativeMethodInfoPtr_get_yxwx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666906);
			double4.NativeMethodInfoPtr_get_yxwy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666907);
			double4.NativeMethodInfoPtr_get_yxwz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666908);
			double4.NativeMethodInfoPtr_set_yxwz_Public_set_Void_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666909);
			double4.NativeMethodInfoPtr_get_yxww_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666910);
			double4.NativeMethodInfoPtr_get_yyxx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666911);
			double4.NativeMethodInfoPtr_get_yyxy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666912);
			double4.NativeMethodInfoPtr_get_yyxz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666913);
			double4.NativeMethodInfoPtr_get_yyxw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666914);
			double4.NativeMethodInfoPtr_get_yyyx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666915);
			double4.NativeMethodInfoPtr_get_yyyy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666916);
			double4.NativeMethodInfoPtr_get_yyyz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666917);
			double4.NativeMethodInfoPtr_get_yyyw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666918);
			double4.NativeMethodInfoPtr_get_yyzx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666919);
			double4.NativeMethodInfoPtr_get_yyzy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666920);
			double4.NativeMethodInfoPtr_get_yyzz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666921);
			double4.NativeMethodInfoPtr_get_yyzw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666922);
			double4.NativeMethodInfoPtr_get_yywx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666923);
			double4.NativeMethodInfoPtr_get_yywy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666924);
			double4.NativeMethodInfoPtr_get_yywz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666925);
			double4.NativeMethodInfoPtr_get_yyww_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666926);
			double4.NativeMethodInfoPtr_get_yzxx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666927);
			double4.NativeMethodInfoPtr_get_yzxy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666928);
			double4.NativeMethodInfoPtr_get_yzxz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666929);
			double4.NativeMethodInfoPtr_get_yzxw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666930);
			double4.NativeMethodInfoPtr_set_yzxw_Public_set_Void_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666931);
			double4.NativeMethodInfoPtr_get_yzyx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666932);
			double4.NativeMethodInfoPtr_get_yzyy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666933);
			double4.NativeMethodInfoPtr_get_yzyz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666934);
			double4.NativeMethodInfoPtr_get_yzyw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666935);
			double4.NativeMethodInfoPtr_get_yzzx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666936);
			double4.NativeMethodInfoPtr_get_yzzy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666937);
			double4.NativeMethodInfoPtr_get_yzzz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666938);
			double4.NativeMethodInfoPtr_get_yzzw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666939);
			double4.NativeMethodInfoPtr_get_yzwx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666940);
			double4.NativeMethodInfoPtr_set_yzwx_Public_set_Void_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666941);
			double4.NativeMethodInfoPtr_get_yzwy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666942);
			double4.NativeMethodInfoPtr_get_yzwz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666943);
			double4.NativeMethodInfoPtr_get_yzww_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666944);
			double4.NativeMethodInfoPtr_get_ywxx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666945);
			double4.NativeMethodInfoPtr_get_ywxy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666946);
			double4.NativeMethodInfoPtr_get_ywxz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666947);
			double4.NativeMethodInfoPtr_set_ywxz_Public_set_Void_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666948);
			double4.NativeMethodInfoPtr_get_ywxw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666949);
			double4.NativeMethodInfoPtr_get_ywyx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666950);
			double4.NativeMethodInfoPtr_get_ywyy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666951);
			double4.NativeMethodInfoPtr_get_ywyz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666952);
			double4.NativeMethodInfoPtr_get_ywyw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666953);
			double4.NativeMethodInfoPtr_get_ywzx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666954);
			double4.NativeMethodInfoPtr_set_ywzx_Public_set_Void_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666955);
			double4.NativeMethodInfoPtr_get_ywzy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666956);
			double4.NativeMethodInfoPtr_get_ywzz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666957);
			double4.NativeMethodInfoPtr_get_ywzw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666958);
			double4.NativeMethodInfoPtr_get_ywwx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666959);
			double4.NativeMethodInfoPtr_get_ywwy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666960);
			double4.NativeMethodInfoPtr_get_ywwz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666961);
			double4.NativeMethodInfoPtr_get_ywww_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666962);
			double4.NativeMethodInfoPtr_get_zxxx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666963);
			double4.NativeMethodInfoPtr_get_zxxy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666964);
			double4.NativeMethodInfoPtr_get_zxxz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666965);
			double4.NativeMethodInfoPtr_get_zxxw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666966);
			double4.NativeMethodInfoPtr_get_zxyx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666967);
			double4.NativeMethodInfoPtr_get_zxyy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666968);
			double4.NativeMethodInfoPtr_get_zxyz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666969);
			double4.NativeMethodInfoPtr_get_zxyw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666970);
			double4.NativeMethodInfoPtr_set_zxyw_Public_set_Void_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666971);
			double4.NativeMethodInfoPtr_get_zxzx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666972);
			double4.NativeMethodInfoPtr_get_zxzy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666973);
			double4.NativeMethodInfoPtr_get_zxzz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666974);
			double4.NativeMethodInfoPtr_get_zxzw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666975);
			double4.NativeMethodInfoPtr_get_zxwx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666976);
			double4.NativeMethodInfoPtr_get_zxwy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666977);
			double4.NativeMethodInfoPtr_set_zxwy_Public_set_Void_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666978);
			double4.NativeMethodInfoPtr_get_zxwz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666979);
			double4.NativeMethodInfoPtr_get_zxww_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666980);
			double4.NativeMethodInfoPtr_get_zyxx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666981);
			double4.NativeMethodInfoPtr_get_zyxy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666982);
			double4.NativeMethodInfoPtr_get_zyxz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666983);
			double4.NativeMethodInfoPtr_get_zyxw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666984);
			double4.NativeMethodInfoPtr_set_zyxw_Public_set_Void_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666985);
			double4.NativeMethodInfoPtr_get_zyyx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666986);
			double4.NativeMethodInfoPtr_get_zyyy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666987);
			double4.NativeMethodInfoPtr_get_zyyz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666988);
			double4.NativeMethodInfoPtr_get_zyyw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666989);
			double4.NativeMethodInfoPtr_get_zyzx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666990);
			double4.NativeMethodInfoPtr_get_zyzy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666991);
			double4.NativeMethodInfoPtr_get_zyzz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666992);
			double4.NativeMethodInfoPtr_get_zyzw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666993);
			double4.NativeMethodInfoPtr_get_zywx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666994);
			double4.NativeMethodInfoPtr_set_zywx_Public_set_Void_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666995);
			double4.NativeMethodInfoPtr_get_zywy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666996);
			double4.NativeMethodInfoPtr_get_zywz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666997);
			double4.NativeMethodInfoPtr_get_zyww_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666998);
			double4.NativeMethodInfoPtr_get_zzxx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100666999);
			double4.NativeMethodInfoPtr_get_zzxy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667000);
			double4.NativeMethodInfoPtr_get_zzxz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667001);
			double4.NativeMethodInfoPtr_get_zzxw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667002);
			double4.NativeMethodInfoPtr_get_zzyx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667003);
			double4.NativeMethodInfoPtr_get_zzyy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667004);
			double4.NativeMethodInfoPtr_get_zzyz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667005);
			double4.NativeMethodInfoPtr_get_zzyw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667006);
			double4.NativeMethodInfoPtr_get_zzzx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667007);
			double4.NativeMethodInfoPtr_get_zzzy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667008);
			double4.NativeMethodInfoPtr_get_zzzz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667009);
			double4.NativeMethodInfoPtr_get_zzzw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667010);
			double4.NativeMethodInfoPtr_get_zzwx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667011);
			double4.NativeMethodInfoPtr_get_zzwy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667012);
			double4.NativeMethodInfoPtr_get_zzwz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667013);
			double4.NativeMethodInfoPtr_get_zzww_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667014);
			double4.NativeMethodInfoPtr_get_zwxx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667015);
			double4.NativeMethodInfoPtr_get_zwxy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667016);
			double4.NativeMethodInfoPtr_set_zwxy_Public_set_Void_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667017);
			double4.NativeMethodInfoPtr_get_zwxz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667018);
			double4.NativeMethodInfoPtr_get_zwxw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667019);
			double4.NativeMethodInfoPtr_get_zwyx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667020);
			double4.NativeMethodInfoPtr_set_zwyx_Public_set_Void_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667021);
			double4.NativeMethodInfoPtr_get_zwyy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667022);
			double4.NativeMethodInfoPtr_get_zwyz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667023);
			double4.NativeMethodInfoPtr_get_zwyw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667024);
			double4.NativeMethodInfoPtr_get_zwzx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667025);
			double4.NativeMethodInfoPtr_get_zwzy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667026);
			double4.NativeMethodInfoPtr_get_zwzz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667027);
			double4.NativeMethodInfoPtr_get_zwzw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667028);
			double4.NativeMethodInfoPtr_get_zwwx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667029);
			double4.NativeMethodInfoPtr_get_zwwy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667030);
			double4.NativeMethodInfoPtr_get_zwwz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667031);
			double4.NativeMethodInfoPtr_get_zwww_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667032);
			double4.NativeMethodInfoPtr_get_wxxx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667033);
			double4.NativeMethodInfoPtr_get_wxxy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667034);
			double4.NativeMethodInfoPtr_get_wxxz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667035);
			double4.NativeMethodInfoPtr_get_wxxw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667036);
			double4.NativeMethodInfoPtr_get_wxyx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667037);
			double4.NativeMethodInfoPtr_get_wxyy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667038);
			double4.NativeMethodInfoPtr_get_wxyz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667039);
			double4.NativeMethodInfoPtr_set_wxyz_Public_set_Void_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667040);
			double4.NativeMethodInfoPtr_get_wxyw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667041);
			double4.NativeMethodInfoPtr_get_wxzx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667042);
			double4.NativeMethodInfoPtr_get_wxzy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667043);
			double4.NativeMethodInfoPtr_set_wxzy_Public_set_Void_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667044);
			double4.NativeMethodInfoPtr_get_wxzz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667045);
			double4.NativeMethodInfoPtr_get_wxzw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667046);
			double4.NativeMethodInfoPtr_get_wxwx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667047);
			double4.NativeMethodInfoPtr_get_wxwy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667048);
			double4.NativeMethodInfoPtr_get_wxwz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667049);
			double4.NativeMethodInfoPtr_get_wxww_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667050);
			double4.NativeMethodInfoPtr_get_wyxx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667051);
			double4.NativeMethodInfoPtr_get_wyxy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667052);
			double4.NativeMethodInfoPtr_get_wyxz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667053);
			double4.NativeMethodInfoPtr_set_wyxz_Public_set_Void_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667054);
			double4.NativeMethodInfoPtr_get_wyxw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667055);
			double4.NativeMethodInfoPtr_get_wyyx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667056);
			double4.NativeMethodInfoPtr_get_wyyy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667057);
			double4.NativeMethodInfoPtr_get_wyyz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667058);
			double4.NativeMethodInfoPtr_get_wyyw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667059);
			double4.NativeMethodInfoPtr_get_wyzx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667060);
			double4.NativeMethodInfoPtr_set_wyzx_Public_set_Void_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667061);
			double4.NativeMethodInfoPtr_get_wyzy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667062);
			double4.NativeMethodInfoPtr_get_wyzz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667063);
			double4.NativeMethodInfoPtr_get_wyzw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667064);
			double4.NativeMethodInfoPtr_get_wywx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667065);
			double4.NativeMethodInfoPtr_get_wywy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667066);
			double4.NativeMethodInfoPtr_get_wywz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667067);
			double4.NativeMethodInfoPtr_get_wyww_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667068);
			double4.NativeMethodInfoPtr_get_wzxx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667069);
			double4.NativeMethodInfoPtr_get_wzxy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667070);
			double4.NativeMethodInfoPtr_set_wzxy_Public_set_Void_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667071);
			double4.NativeMethodInfoPtr_get_wzxz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667072);
			double4.NativeMethodInfoPtr_get_wzxw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667073);
			double4.NativeMethodInfoPtr_get_wzyx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667074);
			double4.NativeMethodInfoPtr_set_wzyx_Public_set_Void_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667075);
			double4.NativeMethodInfoPtr_get_wzyy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667076);
			double4.NativeMethodInfoPtr_get_wzyz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667077);
			double4.NativeMethodInfoPtr_get_wzyw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667078);
			double4.NativeMethodInfoPtr_get_wzzx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667079);
			double4.NativeMethodInfoPtr_get_wzzy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667080);
			double4.NativeMethodInfoPtr_get_wzzz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667081);
			double4.NativeMethodInfoPtr_get_wzzw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667082);
			double4.NativeMethodInfoPtr_get_wzwx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667083);
			double4.NativeMethodInfoPtr_get_wzwy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667084);
			double4.NativeMethodInfoPtr_get_wzwz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667085);
			double4.NativeMethodInfoPtr_get_wzww_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667086);
			double4.NativeMethodInfoPtr_get_wwxx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667087);
			double4.NativeMethodInfoPtr_get_wwxy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667088);
			double4.NativeMethodInfoPtr_get_wwxz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667089);
			double4.NativeMethodInfoPtr_get_wwxw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667090);
			double4.NativeMethodInfoPtr_get_wwyx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667091);
			double4.NativeMethodInfoPtr_get_wwyy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667092);
			double4.NativeMethodInfoPtr_get_wwyz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667093);
			double4.NativeMethodInfoPtr_get_wwyw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667094);
			double4.NativeMethodInfoPtr_get_wwzx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667095);
			double4.NativeMethodInfoPtr_get_wwzy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667096);
			double4.NativeMethodInfoPtr_get_wwzz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667097);
			double4.NativeMethodInfoPtr_get_wwzw_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667098);
			double4.NativeMethodInfoPtr_get_wwwx_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667099);
			double4.NativeMethodInfoPtr_get_wwwy_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667100);
			double4.NativeMethodInfoPtr_get_wwwz_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667101);
			double4.NativeMethodInfoPtr_get_wwww_Public_get_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667102);
			double4.NativeMethodInfoPtr_get_xxx_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667103);
			double4.NativeMethodInfoPtr_get_xxy_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667104);
			double4.NativeMethodInfoPtr_get_xxz_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667105);
			double4.NativeMethodInfoPtr_get_xxw_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667106);
			double4.NativeMethodInfoPtr_get_xyx_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667107);
			double4.NativeMethodInfoPtr_get_xyy_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667108);
			double4.NativeMethodInfoPtr_get_xyz_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667109);
			double4.NativeMethodInfoPtr_set_xyz_Public_set_Void_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667110);
			double4.NativeMethodInfoPtr_get_xyw_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667111);
			double4.NativeMethodInfoPtr_set_xyw_Public_set_Void_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667112);
			double4.NativeMethodInfoPtr_get_xzx_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667113);
			double4.NativeMethodInfoPtr_get_xzy_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667114);
			double4.NativeMethodInfoPtr_set_xzy_Public_set_Void_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667115);
			double4.NativeMethodInfoPtr_get_xzz_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667116);
			double4.NativeMethodInfoPtr_get_xzw_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667117);
			double4.NativeMethodInfoPtr_set_xzw_Public_set_Void_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667118);
			double4.NativeMethodInfoPtr_get_xwx_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667119);
			double4.NativeMethodInfoPtr_get_xwy_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667120);
			double4.NativeMethodInfoPtr_set_xwy_Public_set_Void_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667121);
			double4.NativeMethodInfoPtr_get_xwz_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667122);
			double4.NativeMethodInfoPtr_set_xwz_Public_set_Void_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667123);
			double4.NativeMethodInfoPtr_get_xww_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667124);
			double4.NativeMethodInfoPtr_get_yxx_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667125);
			double4.NativeMethodInfoPtr_get_yxy_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667126);
			double4.NativeMethodInfoPtr_get_yxz_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667127);
			double4.NativeMethodInfoPtr_set_yxz_Public_set_Void_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667128);
			double4.NativeMethodInfoPtr_get_yxw_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667129);
			double4.NativeMethodInfoPtr_set_yxw_Public_set_Void_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667130);
			double4.NativeMethodInfoPtr_get_yyx_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667131);
			double4.NativeMethodInfoPtr_get_yyy_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667132);
			double4.NativeMethodInfoPtr_get_yyz_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667133);
			double4.NativeMethodInfoPtr_get_yyw_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667134);
			double4.NativeMethodInfoPtr_get_yzx_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667135);
			double4.NativeMethodInfoPtr_set_yzx_Public_set_Void_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667136);
			double4.NativeMethodInfoPtr_get_yzy_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667137);
			double4.NativeMethodInfoPtr_get_yzz_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667138);
			double4.NativeMethodInfoPtr_get_yzw_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667139);
			double4.NativeMethodInfoPtr_set_yzw_Public_set_Void_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667140);
			double4.NativeMethodInfoPtr_get_ywx_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667141);
			double4.NativeMethodInfoPtr_set_ywx_Public_set_Void_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667142);
			double4.NativeMethodInfoPtr_get_ywy_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667143);
			double4.NativeMethodInfoPtr_get_ywz_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667144);
			double4.NativeMethodInfoPtr_set_ywz_Public_set_Void_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667145);
			double4.NativeMethodInfoPtr_get_yww_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667146);
			double4.NativeMethodInfoPtr_get_zxx_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667147);
			double4.NativeMethodInfoPtr_get_zxy_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667148);
			double4.NativeMethodInfoPtr_set_zxy_Public_set_Void_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667149);
			double4.NativeMethodInfoPtr_get_zxz_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667150);
			double4.NativeMethodInfoPtr_get_zxw_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667151);
			double4.NativeMethodInfoPtr_set_zxw_Public_set_Void_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667152);
			double4.NativeMethodInfoPtr_get_zyx_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667153);
			double4.NativeMethodInfoPtr_set_zyx_Public_set_Void_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667154);
			double4.NativeMethodInfoPtr_get_zyy_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667155);
			double4.NativeMethodInfoPtr_get_zyz_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667156);
			double4.NativeMethodInfoPtr_get_zyw_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667157);
			double4.NativeMethodInfoPtr_set_zyw_Public_set_Void_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667158);
			double4.NativeMethodInfoPtr_get_zzx_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667159);
			double4.NativeMethodInfoPtr_get_zzy_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667160);
			double4.NativeMethodInfoPtr_get_zzz_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667161);
			double4.NativeMethodInfoPtr_get_zzw_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667162);
			double4.NativeMethodInfoPtr_get_zwx_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667163);
			double4.NativeMethodInfoPtr_set_zwx_Public_set_Void_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667164);
			double4.NativeMethodInfoPtr_get_zwy_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667165);
			double4.NativeMethodInfoPtr_set_zwy_Public_set_Void_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667166);
			double4.NativeMethodInfoPtr_get_zwz_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667167);
			double4.NativeMethodInfoPtr_get_zww_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667168);
			double4.NativeMethodInfoPtr_get_wxx_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667169);
			double4.NativeMethodInfoPtr_get_wxy_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667170);
			double4.NativeMethodInfoPtr_set_wxy_Public_set_Void_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667171);
			double4.NativeMethodInfoPtr_get_wxz_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667172);
			double4.NativeMethodInfoPtr_set_wxz_Public_set_Void_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667173);
			double4.NativeMethodInfoPtr_get_wxw_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667174);
			double4.NativeMethodInfoPtr_get_wyx_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667175);
			double4.NativeMethodInfoPtr_set_wyx_Public_set_Void_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667176);
			double4.NativeMethodInfoPtr_get_wyy_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667177);
			double4.NativeMethodInfoPtr_get_wyz_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667178);
			double4.NativeMethodInfoPtr_set_wyz_Public_set_Void_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667179);
			double4.NativeMethodInfoPtr_get_wyw_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667180);
			double4.NativeMethodInfoPtr_get_wzx_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667181);
			double4.NativeMethodInfoPtr_set_wzx_Public_set_Void_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667182);
			double4.NativeMethodInfoPtr_get_wzy_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667183);
			double4.NativeMethodInfoPtr_set_wzy_Public_set_Void_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667184);
			double4.NativeMethodInfoPtr_get_wzz_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667185);
			double4.NativeMethodInfoPtr_get_wzw_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667186);
			double4.NativeMethodInfoPtr_get_wwx_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667187);
			double4.NativeMethodInfoPtr_get_wwy_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667188);
			double4.NativeMethodInfoPtr_get_wwz_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667189);
			double4.NativeMethodInfoPtr_get_www_Public_get_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667190);
			double4.NativeMethodInfoPtr_get_xx_Public_get_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667191);
			double4.NativeMethodInfoPtr_get_xy_Public_get_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667192);
			double4.NativeMethodInfoPtr_set_xy_Public_set_Void_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667193);
			double4.NativeMethodInfoPtr_get_xz_Public_get_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667194);
			double4.NativeMethodInfoPtr_set_xz_Public_set_Void_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667195);
			double4.NativeMethodInfoPtr_get_xw_Public_get_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667196);
			double4.NativeMethodInfoPtr_set_xw_Public_set_Void_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667197);
			double4.NativeMethodInfoPtr_get_yx_Public_get_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667198);
			double4.NativeMethodInfoPtr_set_yx_Public_set_Void_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667199);
			double4.NativeMethodInfoPtr_get_yy_Public_get_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667200);
			double4.NativeMethodInfoPtr_get_yz_Public_get_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667201);
			double4.NativeMethodInfoPtr_set_yz_Public_set_Void_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667202);
			double4.NativeMethodInfoPtr_get_yw_Public_get_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667203);
			double4.NativeMethodInfoPtr_set_yw_Public_set_Void_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667204);
			double4.NativeMethodInfoPtr_get_zx_Public_get_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667205);
			double4.NativeMethodInfoPtr_set_zx_Public_set_Void_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667206);
			double4.NativeMethodInfoPtr_get_zy_Public_get_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667207);
			double4.NativeMethodInfoPtr_set_zy_Public_set_Void_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667208);
			double4.NativeMethodInfoPtr_get_zz_Public_get_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667209);
			double4.NativeMethodInfoPtr_get_zw_Public_get_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667210);
			double4.NativeMethodInfoPtr_set_zw_Public_set_Void_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667211);
			double4.NativeMethodInfoPtr_get_wx_Public_get_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667212);
			double4.NativeMethodInfoPtr_set_wx_Public_set_Void_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667213);
			double4.NativeMethodInfoPtr_get_wy_Public_get_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667214);
			double4.NativeMethodInfoPtr_set_wy_Public_set_Void_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667215);
			double4.NativeMethodInfoPtr_get_wz_Public_get_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667216);
			double4.NativeMethodInfoPtr_set_wz_Public_set_Void_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667217);
			double4.NativeMethodInfoPtr_get_ww_Public_get_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667218);
			double4.NativeMethodInfoPtr_get_Item_Public_get_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667219);
			double4.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667220);
			double4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667221);
			double4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667222);
			double4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667223);
			double4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667224);
			double4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4>.NativeClassPtr, 100667225);
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x0005073C File Offset: 0x0004E93C
		[CallerCount(0)]
		public unsafe double4(double x, double y, double z, double w)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr__ctor_Public_Void_Double_Double_Double_Double_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x00050798 File Offset: 0x0004E998
		[CallerCount(0)]
		public unsafe double4(double x, double y, double2 zw)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr__ctor_Public_Void_Double_Double_double2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x000507E8 File Offset: 0x0004E9E8
		[CallerCount(0)]
		public unsafe double4(double x, double2 yz, double w)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr__ctor_Public_Void_Double_double2_Double_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x00050838 File Offset: 0x0004EA38
		[CallerCount(0)]
		public unsafe double4(double x, double3 yzw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yzw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr__ctor_Public_Void_Double_double3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x00050878 File Offset: 0x0004EA78
		[CallerCount(0)]
		public unsafe double4(double2 xy, double z, double w)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr__ctor_Public_Void_double2_Double_Double_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x000508C8 File Offset: 0x0004EAC8
		[CallerCount(0)]
		public unsafe double4(double2 xy, double2 zw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xy;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr__ctor_Public_Void_double2_double2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x00050908 File Offset: 0x0004EB08
		[CallerCount(0)]
		public unsafe double4(double3 xyz, double w)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr__ctor_Public_Void_double3_Double_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x00050948 File Offset: 0x0004EB48
		[CallerCount(0)]
		public unsafe double4(double4 xyzw)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyzw;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr__ctor_Public_Void_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x0005097C File Offset: 0x0004EB7C
		[CallerCount(0)]
		public unsafe double4(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x000509B0 File Offset: 0x0004EBB0
		[CallerCount(0)]
		public unsafe double4(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x000509E4 File Offset: 0x0004EBE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635847, XrefRangeEnd = 635850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double4(bool4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr__ctor_Public_Void_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x00050A18 File Offset: 0x0004EC18
		[CallerCount(0)]
		public unsafe double4(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x00050A4C File Offset: 0x0004EC4C
		[CallerCount(0)]
		public unsafe double4(int4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr__ctor_Public_Void_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x00050A80 File Offset: 0x0004EC80
		[CallerCount(0)]
		public unsafe double4(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x00050AB4 File Offset: 0x0004ECB4
		[CallerCount(0)]
		public unsafe double4(uint4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr__ctor_Public_Void_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x00050AE8 File Offset: 0x0004ECE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 635850, RefRangeEnd = 635852, XrefRangeStart = 635850, XrefRangeEnd = 635850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double4(half v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr__ctor_Public_Void_half_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x00050B1C File Offset: 0x0004ED1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 635852, RefRangeEnd = 635854, XrefRangeStart = 635852, XrefRangeEnd = 635852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double4(half4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr__ctor_Public_Void_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x00050B50 File Offset: 0x0004ED50
		[CallerCount(0)]
		public unsafe double4(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x00050B84 File Offset: 0x0004ED84
		[CallerCount(0)]
		public unsafe double4(float4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr__ctor_Public_Void_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x00050BB8 File Offset: 0x0004EDB8
		[CallerCount(0)]
		public unsafe static implicit operator double4(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_Implicit_Public_Static_double4_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x00050BF8 File Offset: 0x0004EDF8
		[CallerCount(0)]
		public unsafe static explicit operator double4(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_Explicit_Public_Static_double4_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x00050C38 File Offset: 0x0004EE38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator double4(bool4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_Explicit_Public_Static_double4_bool4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x00050C78 File Offset: 0x0004EE78
		[CallerCount(0)]
		public unsafe static implicit operator double4(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_Implicit_Public_Static_double4_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x00050CB8 File Offset: 0x0004EEB8
		[CallerCount(0)]
		public unsafe static implicit operator double4(int4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_Implicit_Public_Static_double4_int4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x00050CF8 File Offset: 0x0004EEF8
		[CallerCount(0)]
		public unsafe static implicit operator double4(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_Implicit_Public_Static_double4_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x00050D38 File Offset: 0x0004EF38
		[CallerCount(0)]
		public unsafe static implicit operator double4(uint4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_Implicit_Public_Static_double4_uint4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x00050D78 File Offset: 0x0004EF78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator double4(half v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_Implicit_Public_Static_double4_half_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x00050DB8 File Offset: 0x0004EFB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator double4(half4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_Implicit_Public_Static_double4_half4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x00050DF8 File Offset: 0x0004EFF8
		[CallerCount(0)]
		public unsafe static implicit operator double4(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_Implicit_Public_Static_double4_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x00050E38 File Offset: 0x0004F038
		[CallerCount(0)]
		public unsafe static implicit operator double4(float4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_Implicit_Public_Static_double4_float4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x00050E78 File Offset: 0x0004F078
		[CallerCount(0)]
		public unsafe static double4 operator *(double4 lhs, double4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_Multiply_Public_Static_double4_double4_double4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x00050EC4 File Offset: 0x0004F0C4
		[CallerCount(0)]
		public unsafe static double4 operator *(double4 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_Multiply_Public_Static_double4_double4_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x00050F10 File Offset: 0x0004F110
		[CallerCount(0)]
		public unsafe static double4 operator *(double lhs, double4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_Multiply_Public_Static_double4_Double_double4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x00050F5C File Offset: 0x0004F15C
		[CallerCount(0)]
		public unsafe static double4 operator +(double4 lhs, double4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_Addition_Public_Static_double4_double4_double4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x00050FA8 File Offset: 0x0004F1A8
		[CallerCount(0)]
		public unsafe static double4 operator +(double4 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_Addition_Public_Static_double4_double4_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x00050FF4 File Offset: 0x0004F1F4
		[CallerCount(0)]
		public unsafe static double4 operator +(double lhs, double4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_Addition_Public_Static_double4_Double_double4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x00051040 File Offset: 0x0004F240
		[CallerCount(0)]
		public unsafe static double4 operator -(double4 lhs, double4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_Subtraction_Public_Static_double4_double4_double4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x0005108C File Offset: 0x0004F28C
		[CallerCount(0)]
		public unsafe static double4 operator -(double4 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_Subtraction_Public_Static_double4_double4_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x000510D8 File Offset: 0x0004F2D8
		[CallerCount(0)]
		public unsafe static double4 operator -(double lhs, double4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_Subtraction_Public_Static_double4_Double_double4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x00051124 File Offset: 0x0004F324
		[CallerCount(0)]
		public unsafe static double4 operator /(double4 lhs, double4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_Division_Public_Static_double4_double4_double4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x00051170 File Offset: 0x0004F370
		[CallerCount(0)]
		public unsafe static double4 operator /(double4 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_Division_Public_Static_double4_double4_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x000511BC File Offset: 0x0004F3BC
		[CallerCount(0)]
		public unsafe static double4 operator /(double lhs, double4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_Division_Public_Static_double4_Double_double4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x00051208 File Offset: 0x0004F408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double4 operator %(double4 lhs, double4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_Modulus_Public_Static_double4_double4_double4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x00051254 File Offset: 0x0004F454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635854, XrefRangeEnd = 635858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double4 operator %(double4 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_Modulus_Public_Static_double4_double4_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x000512A0 File Offset: 0x0004F4A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635858, XrefRangeEnd = 635862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double4 operator %(double lhs, double4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_Modulus_Public_Static_double4_Double_double4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x000512EC File Offset: 0x0004F4EC
		[CallerCount(0)]
		public unsafe static double4 operator ++(double4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_Increment_Public_Static_double4_double4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x0005132C File Offset: 0x0004F52C
		[CallerCount(0)]
		public unsafe static double4 operator --(double4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_Decrement_Public_Static_double4_double4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x0005136C File Offset: 0x0004F56C
		[CallerCount(0)]
		public unsafe static bool4 operator <(double4 lhs, double4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4_double4_double4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x000513B8 File Offset: 0x0004F5B8
		[CallerCount(0)]
		public unsafe static bool4 operator <(double4 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4_double4_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x00051404 File Offset: 0x0004F604
		[CallerCount(0)]
		public unsafe static bool4 operator <(double lhs, double4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4_Double_double4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x00051450 File Offset: 0x0004F650
		[CallerCount(0)]
		public unsafe static bool4 operator <=(double4 lhs, double4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4_double4_double4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x0005149C File Offset: 0x0004F69C
		[CallerCount(0)]
		public unsafe static bool4 operator <=(double4 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4_double4_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x000514E8 File Offset: 0x0004F6E8
		[CallerCount(0)]
		public unsafe static bool4 operator <=(double lhs, double4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4_Double_double4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x00051534 File Offset: 0x0004F734
		[CallerCount(0)]
		public unsafe static bool4 operator >(double4 lhs, double4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4_double4_double4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x00051580 File Offset: 0x0004F780
		[CallerCount(0)]
		public unsafe static bool4 operator >(double4 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4_double4_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x000515CC File Offset: 0x0004F7CC
		[CallerCount(0)]
		public unsafe static bool4 operator >(double lhs, double4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4_Double_double4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x00051618 File Offset: 0x0004F818
		[CallerCount(0)]
		public unsafe static bool4 operator >=(double4 lhs, double4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4_double4_double4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x00051664 File Offset: 0x0004F864
		[CallerCount(0)]
		public unsafe static bool4 operator >=(double4 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4_double4_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x000516B0 File Offset: 0x0004F8B0
		[CallerCount(0)]
		public unsafe static bool4 operator >=(double lhs, double4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4_Double_double4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x000516FC File Offset: 0x0004F8FC
		[CallerCount(0)]
		public unsafe static double4 operator -(double4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_double4_double4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x0005173C File Offset: 0x0004F93C
		[CallerCount(0)]
		public unsafe static double4 operator +(double4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_double4_double4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x0005177C File Offset: 0x0004F97C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635862, XrefRangeEnd = 635866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool4 operator ==(double4 lhs, double4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4_double4_double4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x000517C8 File Offset: 0x0004F9C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635866, XrefRangeEnd = 635869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool4 operator ==(double4 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4_double4_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E2B RID: 3627 RVA: 0x00051814 File Offset: 0x0004FA14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635869, XrefRangeEnd = 635873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool4 operator ==(double lhs, double4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4_Double_double4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x00051860 File Offset: 0x0004FA60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635873, XrefRangeEnd = 635877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool4 operator !=(double4 lhs, double4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_double4_double4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x000518AC File Offset: 0x0004FAAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635877, XrefRangeEnd = 635880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool4 operator !=(double4 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_double4_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x000518F8 File Offset: 0x0004FAF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635880, XrefRangeEnd = 635884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool4 operator !=(double lhs, double4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_Double_double4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000E2F RID: 3631 RVA: 0x00051944 File Offset: 0x0004FB44
		public unsafe double4 xxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xxxx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000E30 RID: 3632 RVA: 0x00051974 File Offset: 0x0004FB74
		public unsafe double4 xxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xxxy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000E31 RID: 3633 RVA: 0x000519A4 File Offset: 0x0004FBA4
		public unsafe double4 xxxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xxxz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000E32 RID: 3634 RVA: 0x000519D4 File Offset: 0x0004FBD4
		public unsafe double4 xxxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xxxw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000E33 RID: 3635 RVA: 0x00051A04 File Offset: 0x0004FC04
		public unsafe double4 xxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xxyx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000E34 RID: 3636 RVA: 0x00051A34 File Offset: 0x0004FC34
		public unsafe double4 xxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xxyy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000E35 RID: 3637 RVA: 0x00051A64 File Offset: 0x0004FC64
		public unsafe double4 xxyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xxyz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000E36 RID: 3638 RVA: 0x00051A94 File Offset: 0x0004FC94
		public unsafe double4 xxyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xxyw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000E37 RID: 3639 RVA: 0x00051AC4 File Offset: 0x0004FCC4
		public unsafe double4 xxzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xxzx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000E38 RID: 3640 RVA: 0x00051AF4 File Offset: 0x0004FCF4
		public unsafe double4 xxzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xxzy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000E39 RID: 3641 RVA: 0x00051B24 File Offset: 0x0004FD24
		public unsafe double4 xxzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xxzz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000E3A RID: 3642 RVA: 0x00051B54 File Offset: 0x0004FD54
		public unsafe double4 xxzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xxzw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000E3B RID: 3643 RVA: 0x00051B84 File Offset: 0x0004FD84
		public unsafe double4 xxwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xxwx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000E3C RID: 3644 RVA: 0x00051BB4 File Offset: 0x0004FDB4
		public unsafe double4 xxwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xxwy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000E3D RID: 3645 RVA: 0x00051BE4 File Offset: 0x0004FDE4
		public unsafe double4 xxwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xxwz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000E3E RID: 3646 RVA: 0x00051C14 File Offset: 0x0004FE14
		public unsafe double4 xxww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xxww_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000E3F RID: 3647 RVA: 0x00051C44 File Offset: 0x0004FE44
		public unsafe double4 xyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xyxx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000E40 RID: 3648 RVA: 0x00051C74 File Offset: 0x0004FE74
		public unsafe double4 xyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xyxy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000E41 RID: 3649 RVA: 0x00051CA4 File Offset: 0x0004FEA4
		public unsafe double4 xyxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xyxz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000E42 RID: 3650 RVA: 0x00051CD4 File Offset: 0x0004FED4
		public unsafe double4 xyxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xyxw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000E43 RID: 3651 RVA: 0x00051D04 File Offset: 0x0004FF04
		public unsafe double4 xyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xyyx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000E44 RID: 3652 RVA: 0x00051D34 File Offset: 0x0004FF34
		public unsafe double4 xyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xyyy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000E45 RID: 3653 RVA: 0x00051D64 File Offset: 0x0004FF64
		public unsafe double4 xyyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xyyz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000E46 RID: 3654 RVA: 0x00051D94 File Offset: 0x0004FF94
		public unsafe double4 xyyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xyyw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000E47 RID: 3655 RVA: 0x00051DC4 File Offset: 0x0004FFC4
		public unsafe double4 xyzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xyzx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000E48 RID: 3656 RVA: 0x00051DF4 File Offset: 0x0004FFF4
		public unsafe double4 xyzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xyzy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000E49 RID: 3657 RVA: 0x00051E24 File Offset: 0x00050024
		public unsafe double4 xyzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xyzz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000E4A RID: 3658 RVA: 0x00051E54 File Offset: 0x00050054
		// (set) Token: 0x06000E4B RID: 3659 RVA: 0x00051E84 File Offset: 0x00050084
		public unsafe double4 xyzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xyzw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_xyzw_Public_set_Void_double4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000E4C RID: 3660 RVA: 0x00051EB8 File Offset: 0x000500B8
		public unsafe double4 xywx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xywx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000E4D RID: 3661 RVA: 0x00051EE8 File Offset: 0x000500E8
		public unsafe double4 xywy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xywy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000E4E RID: 3662 RVA: 0x00051F18 File Offset: 0x00050118
		// (set) Token: 0x06000E4F RID: 3663 RVA: 0x00051F48 File Offset: 0x00050148
		public unsafe double4 xywz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xywz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_xywz_Public_set_Void_double4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000E50 RID: 3664 RVA: 0x00051F7C File Offset: 0x0005017C
		public unsafe double4 xyww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xyww_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000E51 RID: 3665 RVA: 0x00051FAC File Offset: 0x000501AC
		public unsafe double4 xzxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xzxx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000E52 RID: 3666 RVA: 0x00051FDC File Offset: 0x000501DC
		public unsafe double4 xzxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xzxy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000E53 RID: 3667 RVA: 0x0005200C File Offset: 0x0005020C
		public unsafe double4 xzxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xzxz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000E54 RID: 3668 RVA: 0x0005203C File Offset: 0x0005023C
		public unsafe double4 xzxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xzxw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000E55 RID: 3669 RVA: 0x0005206C File Offset: 0x0005026C
		public unsafe double4 xzyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xzyx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000E56 RID: 3670 RVA: 0x0005209C File Offset: 0x0005029C
		public unsafe double4 xzyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xzyy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000E57 RID: 3671 RVA: 0x000520CC File Offset: 0x000502CC
		public unsafe double4 xzyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xzyz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000E58 RID: 3672 RVA: 0x000520FC File Offset: 0x000502FC
		// (set) Token: 0x06000E59 RID: 3673 RVA: 0x0005212C File Offset: 0x0005032C
		public unsafe double4 xzyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xzyw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_xzyw_Public_set_Void_double4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000E5A RID: 3674 RVA: 0x00052160 File Offset: 0x00050360
		public unsafe double4 xzzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xzzx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000E5B RID: 3675 RVA: 0x00052190 File Offset: 0x00050390
		public unsafe double4 xzzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xzzy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000E5C RID: 3676 RVA: 0x000521C0 File Offset: 0x000503C0
		public unsafe double4 xzzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xzzz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000E5D RID: 3677 RVA: 0x000521F0 File Offset: 0x000503F0
		public unsafe double4 xzzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xzzw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000E5E RID: 3678 RVA: 0x00052220 File Offset: 0x00050420
		public unsafe double4 xzwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xzwx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000E5F RID: 3679 RVA: 0x00052250 File Offset: 0x00050450
		// (set) Token: 0x06000E60 RID: 3680 RVA: 0x00052280 File Offset: 0x00050480
		public unsafe double4 xzwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xzwy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_xzwy_Public_set_Void_double4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000E61 RID: 3681 RVA: 0x000522B4 File Offset: 0x000504B4
		public unsafe double4 xzwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xzwz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000E62 RID: 3682 RVA: 0x000522E4 File Offset: 0x000504E4
		public unsafe double4 xzww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xzww_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000E63 RID: 3683 RVA: 0x00052314 File Offset: 0x00050514
		public unsafe double4 xwxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xwxx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000E64 RID: 3684 RVA: 0x00052344 File Offset: 0x00050544
		public unsafe double4 xwxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xwxy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000E65 RID: 3685 RVA: 0x00052374 File Offset: 0x00050574
		public unsafe double4 xwxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xwxz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000E66 RID: 3686 RVA: 0x000523A4 File Offset: 0x000505A4
		public unsafe double4 xwxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xwxw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000E67 RID: 3687 RVA: 0x000523D4 File Offset: 0x000505D4
		public unsafe double4 xwyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xwyx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000E68 RID: 3688 RVA: 0x00052404 File Offset: 0x00050604
		public unsafe double4 xwyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xwyy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000E69 RID: 3689 RVA: 0x00052434 File Offset: 0x00050634
		// (set) Token: 0x06000E6A RID: 3690 RVA: 0x00052464 File Offset: 0x00050664
		public unsafe double4 xwyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xwyz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_xwyz_Public_set_Void_double4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000E6B RID: 3691 RVA: 0x00052498 File Offset: 0x00050698
		public unsafe double4 xwyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xwyw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000E6C RID: 3692 RVA: 0x000524C8 File Offset: 0x000506C8
		public unsafe double4 xwzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xwzx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000E6D RID: 3693 RVA: 0x000524F8 File Offset: 0x000506F8
		// (set) Token: 0x06000E6E RID: 3694 RVA: 0x00052528 File Offset: 0x00050728
		public unsafe double4 xwzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xwzy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_xwzy_Public_set_Void_double4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000E6F RID: 3695 RVA: 0x0005255C File Offset: 0x0005075C
		public unsafe double4 xwzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xwzz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000E70 RID: 3696 RVA: 0x0005258C File Offset: 0x0005078C
		public unsafe double4 xwzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xwzw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000E71 RID: 3697 RVA: 0x000525BC File Offset: 0x000507BC
		public unsafe double4 xwwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xwwx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000E72 RID: 3698 RVA: 0x000525EC File Offset: 0x000507EC
		public unsafe double4 xwwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xwwy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000E73 RID: 3699 RVA: 0x0005261C File Offset: 0x0005081C
		public unsafe double4 xwwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xwwz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000E74 RID: 3700 RVA: 0x0005264C File Offset: 0x0005084C
		public unsafe double4 xwww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xwww_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000E75 RID: 3701 RVA: 0x0005267C File Offset: 0x0005087C
		public unsafe double4 yxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yxxx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000E76 RID: 3702 RVA: 0x000526AC File Offset: 0x000508AC
		public unsafe double4 yxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yxxy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000E77 RID: 3703 RVA: 0x000526DC File Offset: 0x000508DC
		public unsafe double4 yxxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yxxz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000E78 RID: 3704 RVA: 0x0005270C File Offset: 0x0005090C
		public unsafe double4 yxxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yxxw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000E79 RID: 3705 RVA: 0x0005273C File Offset: 0x0005093C
		public unsafe double4 yxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yxyx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000E7A RID: 3706 RVA: 0x0005276C File Offset: 0x0005096C
		public unsafe double4 yxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yxyy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000E7B RID: 3707 RVA: 0x0005279C File Offset: 0x0005099C
		public unsafe double4 yxyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yxyz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000E7C RID: 3708 RVA: 0x000527CC File Offset: 0x000509CC
		public unsafe double4 yxyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yxyw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000E7D RID: 3709 RVA: 0x000527FC File Offset: 0x000509FC
		public unsafe double4 yxzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yxzx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000E7E RID: 3710 RVA: 0x0005282C File Offset: 0x00050A2C
		public unsafe double4 yxzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yxzy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000E7F RID: 3711 RVA: 0x0005285C File Offset: 0x00050A5C
		public unsafe double4 yxzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yxzz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000E80 RID: 3712 RVA: 0x0005288C File Offset: 0x00050A8C
		// (set) Token: 0x06000E81 RID: 3713 RVA: 0x000528BC File Offset: 0x00050ABC
		public unsafe double4 yxzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yxzw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_yxzw_Public_set_Void_double4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000E82 RID: 3714 RVA: 0x000528F0 File Offset: 0x00050AF0
		public unsafe double4 yxwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yxwx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000E83 RID: 3715 RVA: 0x00052920 File Offset: 0x00050B20
		public unsafe double4 yxwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yxwy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000E84 RID: 3716 RVA: 0x00052950 File Offset: 0x00050B50
		// (set) Token: 0x06000E85 RID: 3717 RVA: 0x00052980 File Offset: 0x00050B80
		public unsafe double4 yxwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yxwz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_yxwz_Public_set_Void_double4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000E86 RID: 3718 RVA: 0x000529B4 File Offset: 0x00050BB4
		public unsafe double4 yxww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yxww_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000E87 RID: 3719 RVA: 0x000529E4 File Offset: 0x00050BE4
		public unsafe double4 yyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yyxx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000E88 RID: 3720 RVA: 0x00052A14 File Offset: 0x00050C14
		public unsafe double4 yyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yyxy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000E89 RID: 3721 RVA: 0x00052A44 File Offset: 0x00050C44
		public unsafe double4 yyxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yyxz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000E8A RID: 3722 RVA: 0x00052A74 File Offset: 0x00050C74
		public unsafe double4 yyxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yyxw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000E8B RID: 3723 RVA: 0x00052AA4 File Offset: 0x00050CA4
		public unsafe double4 yyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yyyx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000E8C RID: 3724 RVA: 0x00052AD4 File Offset: 0x00050CD4
		public unsafe double4 yyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yyyy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000E8D RID: 3725 RVA: 0x00052B04 File Offset: 0x00050D04
		public unsafe double4 yyyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yyyz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000E8E RID: 3726 RVA: 0x00052B34 File Offset: 0x00050D34
		public unsafe double4 yyyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yyyw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000E8F RID: 3727 RVA: 0x00052B64 File Offset: 0x00050D64
		public unsafe double4 yyzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yyzx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000E90 RID: 3728 RVA: 0x00052B94 File Offset: 0x00050D94
		public unsafe double4 yyzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yyzy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000E91 RID: 3729 RVA: 0x00052BC4 File Offset: 0x00050DC4
		public unsafe double4 yyzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yyzz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000E92 RID: 3730 RVA: 0x00052BF4 File Offset: 0x00050DF4
		public unsafe double4 yyzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yyzw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000E93 RID: 3731 RVA: 0x00052C24 File Offset: 0x00050E24
		public unsafe double4 yywx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yywx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000E94 RID: 3732 RVA: 0x00052C54 File Offset: 0x00050E54
		public unsafe double4 yywy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yywy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000E95 RID: 3733 RVA: 0x00052C84 File Offset: 0x00050E84
		public unsafe double4 yywz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yywz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000E96 RID: 3734 RVA: 0x00052CB4 File Offset: 0x00050EB4
		public unsafe double4 yyww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yyww_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000E97 RID: 3735 RVA: 0x00052CE4 File Offset: 0x00050EE4
		public unsafe double4 yzxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yzxx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000E98 RID: 3736 RVA: 0x00052D14 File Offset: 0x00050F14
		public unsafe double4 yzxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yzxy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000E99 RID: 3737 RVA: 0x00052D44 File Offset: 0x00050F44
		public unsafe double4 yzxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yzxz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000E9A RID: 3738 RVA: 0x00052D74 File Offset: 0x00050F74
		// (set) Token: 0x06000E9B RID: 3739 RVA: 0x00052DA4 File Offset: 0x00050FA4
		public unsafe double4 yzxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yzxw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_yzxw_Public_set_Void_double4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000E9C RID: 3740 RVA: 0x00052DD8 File Offset: 0x00050FD8
		public unsafe double4 yzyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yzyx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000E9D RID: 3741 RVA: 0x00052E08 File Offset: 0x00051008
		public unsafe double4 yzyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yzyy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000E9E RID: 3742 RVA: 0x00052E38 File Offset: 0x00051038
		public unsafe double4 yzyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yzyz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000E9F RID: 3743 RVA: 0x00052E68 File Offset: 0x00051068
		public unsafe double4 yzyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yzyw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000EA0 RID: 3744 RVA: 0x00052E98 File Offset: 0x00051098
		public unsafe double4 yzzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yzzx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000EA1 RID: 3745 RVA: 0x00052EC8 File Offset: 0x000510C8
		public unsafe double4 yzzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yzzy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000EA2 RID: 3746 RVA: 0x00052EF8 File Offset: 0x000510F8
		public unsafe double4 yzzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yzzz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000EA3 RID: 3747 RVA: 0x00052F28 File Offset: 0x00051128
		public unsafe double4 yzzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yzzw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000EA4 RID: 3748 RVA: 0x00052F58 File Offset: 0x00051158
		// (set) Token: 0x06000EA5 RID: 3749 RVA: 0x00052F88 File Offset: 0x00051188
		public unsafe double4 yzwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yzwx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_yzwx_Public_set_Void_double4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000EA6 RID: 3750 RVA: 0x00052FBC File Offset: 0x000511BC
		public unsafe double4 yzwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yzwy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000EA7 RID: 3751 RVA: 0x00052FEC File Offset: 0x000511EC
		public unsafe double4 yzwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yzwz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000EA8 RID: 3752 RVA: 0x0005301C File Offset: 0x0005121C
		public unsafe double4 yzww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yzww_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000EA9 RID: 3753 RVA: 0x0005304C File Offset: 0x0005124C
		public unsafe double4 ywxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_ywxx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000EAA RID: 3754 RVA: 0x0005307C File Offset: 0x0005127C
		public unsafe double4 ywxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_ywxy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000EAB RID: 3755 RVA: 0x000530AC File Offset: 0x000512AC
		// (set) Token: 0x06000EAC RID: 3756 RVA: 0x000530DC File Offset: 0x000512DC
		public unsafe double4 ywxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_ywxz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_ywxz_Public_set_Void_double4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000EAD RID: 3757 RVA: 0x00053110 File Offset: 0x00051310
		public unsafe double4 ywxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_ywxw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000EAE RID: 3758 RVA: 0x00053140 File Offset: 0x00051340
		public unsafe double4 ywyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_ywyx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000EAF RID: 3759 RVA: 0x00053170 File Offset: 0x00051370
		public unsafe double4 ywyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_ywyy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000EB0 RID: 3760 RVA: 0x000531A0 File Offset: 0x000513A0
		public unsafe double4 ywyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_ywyz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000EB1 RID: 3761 RVA: 0x000531D0 File Offset: 0x000513D0
		public unsafe double4 ywyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_ywyw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000EB2 RID: 3762 RVA: 0x00053200 File Offset: 0x00051400
		// (set) Token: 0x06000EB3 RID: 3763 RVA: 0x00053230 File Offset: 0x00051430
		public unsafe double4 ywzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_ywzx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_ywzx_Public_set_Void_double4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000EB4 RID: 3764 RVA: 0x00053264 File Offset: 0x00051464
		public unsafe double4 ywzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_ywzy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000EB5 RID: 3765 RVA: 0x00053294 File Offset: 0x00051494
		public unsafe double4 ywzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_ywzz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000EB6 RID: 3766 RVA: 0x000532C4 File Offset: 0x000514C4
		public unsafe double4 ywzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_ywzw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000EB7 RID: 3767 RVA: 0x000532F4 File Offset: 0x000514F4
		public unsafe double4 ywwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_ywwx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000EB8 RID: 3768 RVA: 0x00053324 File Offset: 0x00051524
		public unsafe double4 ywwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_ywwy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000EB9 RID: 3769 RVA: 0x00053354 File Offset: 0x00051554
		public unsafe double4 ywwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_ywwz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000EBA RID: 3770 RVA: 0x00053384 File Offset: 0x00051584
		public unsafe double4 ywww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_ywww_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000EBB RID: 3771 RVA: 0x000533B4 File Offset: 0x000515B4
		public unsafe double4 zxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zxxx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000EBC RID: 3772 RVA: 0x000533E4 File Offset: 0x000515E4
		public unsafe double4 zxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zxxy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000EBD RID: 3773 RVA: 0x00053414 File Offset: 0x00051614
		public unsafe double4 zxxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zxxz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000EBE RID: 3774 RVA: 0x00053444 File Offset: 0x00051644
		public unsafe double4 zxxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zxxw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000EBF RID: 3775 RVA: 0x00053474 File Offset: 0x00051674
		public unsafe double4 zxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zxyx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000EC0 RID: 3776 RVA: 0x000534A4 File Offset: 0x000516A4
		public unsafe double4 zxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zxyy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000EC1 RID: 3777 RVA: 0x000534D4 File Offset: 0x000516D4
		public unsafe double4 zxyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zxyz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000EC2 RID: 3778 RVA: 0x00053504 File Offset: 0x00051704
		// (set) Token: 0x06000EC3 RID: 3779 RVA: 0x00053534 File Offset: 0x00051734
		public unsafe double4 zxyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zxyw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_zxyw_Public_set_Void_double4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000EC4 RID: 3780 RVA: 0x00053568 File Offset: 0x00051768
		public unsafe double4 zxzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zxzx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000EC5 RID: 3781 RVA: 0x00053598 File Offset: 0x00051798
		public unsafe double4 zxzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zxzy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000EC6 RID: 3782 RVA: 0x000535C8 File Offset: 0x000517C8
		public unsafe double4 zxzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zxzz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000EC7 RID: 3783 RVA: 0x000535F8 File Offset: 0x000517F8
		public unsafe double4 zxzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zxzw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000EC8 RID: 3784 RVA: 0x00053628 File Offset: 0x00051828
		public unsafe double4 zxwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zxwx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000EC9 RID: 3785 RVA: 0x00053658 File Offset: 0x00051858
		// (set) Token: 0x06000ECA RID: 3786 RVA: 0x00053688 File Offset: 0x00051888
		public unsafe double4 zxwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zxwy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_zxwy_Public_set_Void_double4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000ECB RID: 3787 RVA: 0x000536BC File Offset: 0x000518BC
		public unsafe double4 zxwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zxwz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000ECC RID: 3788 RVA: 0x000536EC File Offset: 0x000518EC
		public unsafe double4 zxww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zxww_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000ECD RID: 3789 RVA: 0x0005371C File Offset: 0x0005191C
		public unsafe double4 zyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zyxx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000ECE RID: 3790 RVA: 0x0005374C File Offset: 0x0005194C
		public unsafe double4 zyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zyxy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000ECF RID: 3791 RVA: 0x0005377C File Offset: 0x0005197C
		public unsafe double4 zyxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zyxz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000ED0 RID: 3792 RVA: 0x000537AC File Offset: 0x000519AC
		// (set) Token: 0x06000ED1 RID: 3793 RVA: 0x000537DC File Offset: 0x000519DC
		public unsafe double4 zyxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zyxw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_zyxw_Public_set_Void_double4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000ED2 RID: 3794 RVA: 0x00053810 File Offset: 0x00051A10
		public unsafe double4 zyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zyyx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000ED3 RID: 3795 RVA: 0x00053840 File Offset: 0x00051A40
		public unsafe double4 zyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zyyy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000ED4 RID: 3796 RVA: 0x00053870 File Offset: 0x00051A70
		public unsafe double4 zyyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zyyz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000ED5 RID: 3797 RVA: 0x000538A0 File Offset: 0x00051AA0
		public unsafe double4 zyyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zyyw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000ED6 RID: 3798 RVA: 0x000538D0 File Offset: 0x00051AD0
		public unsafe double4 zyzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zyzx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000ED7 RID: 3799 RVA: 0x00053900 File Offset: 0x00051B00
		public unsafe double4 zyzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zyzy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000ED8 RID: 3800 RVA: 0x00053930 File Offset: 0x00051B30
		public unsafe double4 zyzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zyzz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000ED9 RID: 3801 RVA: 0x00053960 File Offset: 0x00051B60
		public unsafe double4 zyzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zyzw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000EDA RID: 3802 RVA: 0x00053990 File Offset: 0x00051B90
		// (set) Token: 0x06000EDB RID: 3803 RVA: 0x000539C0 File Offset: 0x00051BC0
		public unsafe double4 zywx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zywx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_zywx_Public_set_Void_double4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000EDC RID: 3804 RVA: 0x000539F4 File Offset: 0x00051BF4
		public unsafe double4 zywy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zywy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000EDD RID: 3805 RVA: 0x00053A24 File Offset: 0x00051C24
		public unsafe double4 zywz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zywz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000EDE RID: 3806 RVA: 0x00053A54 File Offset: 0x00051C54
		public unsafe double4 zyww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zyww_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000EDF RID: 3807 RVA: 0x00053A84 File Offset: 0x00051C84
		public unsafe double4 zzxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zzxx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000EE0 RID: 3808 RVA: 0x00053AB4 File Offset: 0x00051CB4
		public unsafe double4 zzxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zzxy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000EE1 RID: 3809 RVA: 0x00053AE4 File Offset: 0x00051CE4
		public unsafe double4 zzxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zzxz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000EE2 RID: 3810 RVA: 0x00053B14 File Offset: 0x00051D14
		public unsafe double4 zzxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zzxw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000EE3 RID: 3811 RVA: 0x00053B44 File Offset: 0x00051D44
		public unsafe double4 zzyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zzyx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000EE4 RID: 3812 RVA: 0x00053B74 File Offset: 0x00051D74
		public unsafe double4 zzyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zzyy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000EE5 RID: 3813 RVA: 0x00053BA4 File Offset: 0x00051DA4
		public unsafe double4 zzyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zzyz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000EE6 RID: 3814 RVA: 0x00053BD4 File Offset: 0x00051DD4
		public unsafe double4 zzyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zzyw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000EE7 RID: 3815 RVA: 0x00053C04 File Offset: 0x00051E04
		public unsafe double4 zzzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zzzx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000EE8 RID: 3816 RVA: 0x00053C34 File Offset: 0x00051E34
		public unsafe double4 zzzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zzzy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000EE9 RID: 3817 RVA: 0x00053C64 File Offset: 0x00051E64
		public unsafe double4 zzzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zzzz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000EEA RID: 3818 RVA: 0x00053C94 File Offset: 0x00051E94
		public unsafe double4 zzzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zzzw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000EEB RID: 3819 RVA: 0x00053CC4 File Offset: 0x00051EC4
		public unsafe double4 zzwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zzwx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000EEC RID: 3820 RVA: 0x00053CF4 File Offset: 0x00051EF4
		public unsafe double4 zzwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zzwy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000EED RID: 3821 RVA: 0x00053D24 File Offset: 0x00051F24
		public unsafe double4 zzwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zzwz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000EEE RID: 3822 RVA: 0x00053D54 File Offset: 0x00051F54
		public unsafe double4 zzww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zzww_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000EEF RID: 3823 RVA: 0x00053D84 File Offset: 0x00051F84
		public unsafe double4 zwxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zwxx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000EF0 RID: 3824 RVA: 0x00053DB4 File Offset: 0x00051FB4
		// (set) Token: 0x06000EF1 RID: 3825 RVA: 0x00053DE4 File Offset: 0x00051FE4
		public unsafe double4 zwxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zwxy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_zwxy_Public_set_Void_double4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000EF2 RID: 3826 RVA: 0x00053E18 File Offset: 0x00052018
		public unsafe double4 zwxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zwxz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000EF3 RID: 3827 RVA: 0x00053E48 File Offset: 0x00052048
		public unsafe double4 zwxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zwxw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000EF4 RID: 3828 RVA: 0x00053E78 File Offset: 0x00052078
		// (set) Token: 0x06000EF5 RID: 3829 RVA: 0x00053EA8 File Offset: 0x000520A8
		public unsafe double4 zwyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zwyx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_zwyx_Public_set_Void_double4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000EF6 RID: 3830 RVA: 0x00053EDC File Offset: 0x000520DC
		public unsafe double4 zwyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zwyy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000EF7 RID: 3831 RVA: 0x00053F0C File Offset: 0x0005210C
		public unsafe double4 zwyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zwyz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000EF8 RID: 3832 RVA: 0x00053F3C File Offset: 0x0005213C
		public unsafe double4 zwyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zwyw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000EF9 RID: 3833 RVA: 0x00053F6C File Offset: 0x0005216C
		public unsafe double4 zwzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zwzx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000EFA RID: 3834 RVA: 0x00053F9C File Offset: 0x0005219C
		public unsafe double4 zwzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zwzy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000EFB RID: 3835 RVA: 0x00053FCC File Offset: 0x000521CC
		public unsafe double4 zwzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zwzz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000EFC RID: 3836 RVA: 0x00053FFC File Offset: 0x000521FC
		public unsafe double4 zwzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zwzw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000EFD RID: 3837 RVA: 0x0005402C File Offset: 0x0005222C
		public unsafe double4 zwwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zwwx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000EFE RID: 3838 RVA: 0x0005405C File Offset: 0x0005225C
		public unsafe double4 zwwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zwwy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000EFF RID: 3839 RVA: 0x0005408C File Offset: 0x0005228C
		public unsafe double4 zwwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zwwz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000F00 RID: 3840 RVA: 0x000540BC File Offset: 0x000522BC
		public unsafe double4 zwww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zwww_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000F01 RID: 3841 RVA: 0x000540EC File Offset: 0x000522EC
		public unsafe double4 wxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wxxx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000F02 RID: 3842 RVA: 0x0005411C File Offset: 0x0005231C
		public unsafe double4 wxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wxxy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000F03 RID: 3843 RVA: 0x0005414C File Offset: 0x0005234C
		public unsafe double4 wxxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wxxz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000F04 RID: 3844 RVA: 0x0005417C File Offset: 0x0005237C
		public unsafe double4 wxxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wxxw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000F05 RID: 3845 RVA: 0x000541AC File Offset: 0x000523AC
		public unsafe double4 wxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wxyx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000F06 RID: 3846 RVA: 0x000541DC File Offset: 0x000523DC
		public unsafe double4 wxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wxyy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000F07 RID: 3847 RVA: 0x0005420C File Offset: 0x0005240C
		// (set) Token: 0x06000F08 RID: 3848 RVA: 0x0005423C File Offset: 0x0005243C
		public unsafe double4 wxyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wxyz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_wxyz_Public_set_Void_double4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000F09 RID: 3849 RVA: 0x00054270 File Offset: 0x00052470
		public unsafe double4 wxyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wxyw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000F0A RID: 3850 RVA: 0x000542A0 File Offset: 0x000524A0
		public unsafe double4 wxzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wxzx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000F0B RID: 3851 RVA: 0x000542D0 File Offset: 0x000524D0
		// (set) Token: 0x06000F0C RID: 3852 RVA: 0x00054300 File Offset: 0x00052500
		public unsafe double4 wxzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wxzy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_wxzy_Public_set_Void_double4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000F0D RID: 3853 RVA: 0x00054334 File Offset: 0x00052534
		public unsafe double4 wxzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wxzz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000F0E RID: 3854 RVA: 0x00054364 File Offset: 0x00052564
		public unsafe double4 wxzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wxzw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000F0F RID: 3855 RVA: 0x00054394 File Offset: 0x00052594
		public unsafe double4 wxwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wxwx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000F10 RID: 3856 RVA: 0x000543C4 File Offset: 0x000525C4
		public unsafe double4 wxwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wxwy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000F11 RID: 3857 RVA: 0x000543F4 File Offset: 0x000525F4
		public unsafe double4 wxwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wxwz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000F12 RID: 3858 RVA: 0x00054424 File Offset: 0x00052624
		public unsafe double4 wxww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wxww_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000F13 RID: 3859 RVA: 0x00054454 File Offset: 0x00052654
		public unsafe double4 wyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wyxx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000F14 RID: 3860 RVA: 0x00054484 File Offset: 0x00052684
		public unsafe double4 wyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wyxy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000F15 RID: 3861 RVA: 0x000544B4 File Offset: 0x000526B4
		// (set) Token: 0x06000F16 RID: 3862 RVA: 0x000544E4 File Offset: 0x000526E4
		public unsafe double4 wyxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wyxz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_wyxz_Public_set_Void_double4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000F17 RID: 3863 RVA: 0x00054518 File Offset: 0x00052718
		public unsafe double4 wyxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wyxw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000F18 RID: 3864 RVA: 0x00054548 File Offset: 0x00052748
		public unsafe double4 wyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wyyx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000F19 RID: 3865 RVA: 0x00054578 File Offset: 0x00052778
		public unsafe double4 wyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wyyy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000F1A RID: 3866 RVA: 0x000545A8 File Offset: 0x000527A8
		public unsafe double4 wyyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wyyz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000F1B RID: 3867 RVA: 0x000545D8 File Offset: 0x000527D8
		public unsafe double4 wyyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wyyw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000F1C RID: 3868 RVA: 0x00054608 File Offset: 0x00052808
		// (set) Token: 0x06000F1D RID: 3869 RVA: 0x00054638 File Offset: 0x00052838
		public unsafe double4 wyzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wyzx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_wyzx_Public_set_Void_double4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000F1E RID: 3870 RVA: 0x0005466C File Offset: 0x0005286C
		public unsafe double4 wyzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wyzy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000F1F RID: 3871 RVA: 0x0005469C File Offset: 0x0005289C
		public unsafe double4 wyzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wyzz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000F20 RID: 3872 RVA: 0x000546CC File Offset: 0x000528CC
		public unsafe double4 wyzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wyzw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000F21 RID: 3873 RVA: 0x000546FC File Offset: 0x000528FC
		public unsafe double4 wywx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wywx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000F22 RID: 3874 RVA: 0x0005472C File Offset: 0x0005292C
		public unsafe double4 wywy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wywy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000F23 RID: 3875 RVA: 0x0005475C File Offset: 0x0005295C
		public unsafe double4 wywz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wywz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000F24 RID: 3876 RVA: 0x0005478C File Offset: 0x0005298C
		public unsafe double4 wyww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wyww_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000F25 RID: 3877 RVA: 0x000547BC File Offset: 0x000529BC
		public unsafe double4 wzxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wzxx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000F26 RID: 3878 RVA: 0x000547EC File Offset: 0x000529EC
		// (set) Token: 0x06000F27 RID: 3879 RVA: 0x0005481C File Offset: 0x00052A1C
		public unsafe double4 wzxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wzxy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_wzxy_Public_set_Void_double4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000F28 RID: 3880 RVA: 0x00054850 File Offset: 0x00052A50
		public unsafe double4 wzxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wzxz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000F29 RID: 3881 RVA: 0x00054880 File Offset: 0x00052A80
		public unsafe double4 wzxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wzxw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000F2A RID: 3882 RVA: 0x000548B0 File Offset: 0x00052AB0
		// (set) Token: 0x06000F2B RID: 3883 RVA: 0x000548E0 File Offset: 0x00052AE0
		public unsafe double4 wzyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wzyx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_wzyx_Public_set_Void_double4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000F2C RID: 3884 RVA: 0x00054914 File Offset: 0x00052B14
		public unsafe double4 wzyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wzyy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000F2D RID: 3885 RVA: 0x00054944 File Offset: 0x00052B44
		public unsafe double4 wzyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wzyz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000F2E RID: 3886 RVA: 0x00054974 File Offset: 0x00052B74
		public unsafe double4 wzyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wzyw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000F2F RID: 3887 RVA: 0x000549A4 File Offset: 0x00052BA4
		public unsafe double4 wzzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wzzx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000F30 RID: 3888 RVA: 0x000549D4 File Offset: 0x00052BD4
		public unsafe double4 wzzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wzzy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000F31 RID: 3889 RVA: 0x00054A04 File Offset: 0x00052C04
		public unsafe double4 wzzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wzzz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000F32 RID: 3890 RVA: 0x00054A34 File Offset: 0x00052C34
		public unsafe double4 wzzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wzzw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000F33 RID: 3891 RVA: 0x00054A64 File Offset: 0x00052C64
		public unsafe double4 wzwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wzwx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000F34 RID: 3892 RVA: 0x00054A94 File Offset: 0x00052C94
		public unsafe double4 wzwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wzwy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000F35 RID: 3893 RVA: 0x00054AC4 File Offset: 0x00052CC4
		public unsafe double4 wzwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wzwz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000F36 RID: 3894 RVA: 0x00054AF4 File Offset: 0x00052CF4
		public unsafe double4 wzww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wzww_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000F37 RID: 3895 RVA: 0x00054B24 File Offset: 0x00052D24
		public unsafe double4 wwxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wwxx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000F38 RID: 3896 RVA: 0x00054B54 File Offset: 0x00052D54
		public unsafe double4 wwxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wwxy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000F39 RID: 3897 RVA: 0x00054B84 File Offset: 0x00052D84
		public unsafe double4 wwxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wwxz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000F3A RID: 3898 RVA: 0x00054BB4 File Offset: 0x00052DB4
		public unsafe double4 wwxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wwxw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000F3B RID: 3899 RVA: 0x00054BE4 File Offset: 0x00052DE4
		public unsafe double4 wwyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wwyx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000F3C RID: 3900 RVA: 0x00054C14 File Offset: 0x00052E14
		public unsafe double4 wwyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wwyy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000F3D RID: 3901 RVA: 0x00054C44 File Offset: 0x00052E44
		public unsafe double4 wwyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wwyz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000F3E RID: 3902 RVA: 0x00054C74 File Offset: 0x00052E74
		public unsafe double4 wwyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wwyw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000F3F RID: 3903 RVA: 0x00054CA4 File Offset: 0x00052EA4
		public unsafe double4 wwzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wwzx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000F40 RID: 3904 RVA: 0x00054CD4 File Offset: 0x00052ED4
		public unsafe double4 wwzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wwzy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000F41 RID: 3905 RVA: 0x00054D04 File Offset: 0x00052F04
		public unsafe double4 wwzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wwzz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000F42 RID: 3906 RVA: 0x00054D34 File Offset: 0x00052F34
		public unsafe double4 wwzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wwzw_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000F43 RID: 3907 RVA: 0x00054D64 File Offset: 0x00052F64
		public unsafe double4 wwwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wwwx_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000F44 RID: 3908 RVA: 0x00054D94 File Offset: 0x00052F94
		public unsafe double4 wwwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wwwy_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000F45 RID: 3909 RVA: 0x00054DC4 File Offset: 0x00052FC4
		public unsafe double4 wwwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wwwz_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000F46 RID: 3910 RVA: 0x00054DF4 File Offset: 0x00052FF4
		public unsafe double4 wwww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wwww_Public_get_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000F47 RID: 3911 RVA: 0x00054E24 File Offset: 0x00053024
		public unsafe double3 xxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xxx_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000F48 RID: 3912 RVA: 0x00054E54 File Offset: 0x00053054
		public unsafe double3 xxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xxy_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000F49 RID: 3913 RVA: 0x00054E84 File Offset: 0x00053084
		public unsafe double3 xxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xxz_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000F4A RID: 3914 RVA: 0x00054EB4 File Offset: 0x000530B4
		public unsafe double3 xxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xxw_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000F4B RID: 3915 RVA: 0x00054EE4 File Offset: 0x000530E4
		public unsafe double3 xyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xyx_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000F4C RID: 3916 RVA: 0x00054F14 File Offset: 0x00053114
		public unsafe double3 xyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xyy_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000F4D RID: 3917 RVA: 0x00054F44 File Offset: 0x00053144
		// (set) Token: 0x06000F4E RID: 3918 RVA: 0x00054F74 File Offset: 0x00053174
		public unsafe double3 xyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xyz_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_xyz_Public_set_Void_double3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000F4F RID: 3919 RVA: 0x00054FA8 File Offset: 0x000531A8
		// (set) Token: 0x06000F50 RID: 3920 RVA: 0x00054FD8 File Offset: 0x000531D8
		public unsafe double3 xyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xyw_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_xyw_Public_set_Void_double3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000F51 RID: 3921 RVA: 0x0005500C File Offset: 0x0005320C
		public unsafe double3 xzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xzx_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000F52 RID: 3922 RVA: 0x0005503C File Offset: 0x0005323C
		// (set) Token: 0x06000F53 RID: 3923 RVA: 0x0005506C File Offset: 0x0005326C
		public unsafe double3 xzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xzy_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_xzy_Public_set_Void_double3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000F54 RID: 3924 RVA: 0x000550A0 File Offset: 0x000532A0
		public unsafe double3 xzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xzz_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000F55 RID: 3925 RVA: 0x000550D0 File Offset: 0x000532D0
		// (set) Token: 0x06000F56 RID: 3926 RVA: 0x00055100 File Offset: 0x00053300
		public unsafe double3 xzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xzw_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_xzw_Public_set_Void_double3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000F57 RID: 3927 RVA: 0x00055134 File Offset: 0x00053334
		public unsafe double3 xwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xwx_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000F58 RID: 3928 RVA: 0x00055164 File Offset: 0x00053364
		// (set) Token: 0x06000F59 RID: 3929 RVA: 0x00055194 File Offset: 0x00053394
		public unsafe double3 xwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xwy_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_xwy_Public_set_Void_double3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000F5A RID: 3930 RVA: 0x000551C8 File Offset: 0x000533C8
		// (set) Token: 0x06000F5B RID: 3931 RVA: 0x000551F8 File Offset: 0x000533F8
		public unsafe double3 xwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xwz_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_xwz_Public_set_Void_double3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000F5C RID: 3932 RVA: 0x0005522C File Offset: 0x0005342C
		public unsafe double3 xww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xww_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000F5D RID: 3933 RVA: 0x0005525C File Offset: 0x0005345C
		public unsafe double3 yxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yxx_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000F5E RID: 3934 RVA: 0x0005528C File Offset: 0x0005348C
		public unsafe double3 yxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yxy_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000F5F RID: 3935 RVA: 0x000552BC File Offset: 0x000534BC
		// (set) Token: 0x06000F60 RID: 3936 RVA: 0x000552EC File Offset: 0x000534EC
		public unsafe double3 yxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yxz_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_yxz_Public_set_Void_double3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000F61 RID: 3937 RVA: 0x00055320 File Offset: 0x00053520
		// (set) Token: 0x06000F62 RID: 3938 RVA: 0x00055350 File Offset: 0x00053550
		public unsafe double3 yxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yxw_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_yxw_Public_set_Void_double3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000F63 RID: 3939 RVA: 0x00055384 File Offset: 0x00053584
		public unsafe double3 yyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yyx_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000F64 RID: 3940 RVA: 0x000553B4 File Offset: 0x000535B4
		public unsafe double3 yyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yyy_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000F65 RID: 3941 RVA: 0x000553E4 File Offset: 0x000535E4
		public unsafe double3 yyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yyz_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000F66 RID: 3942 RVA: 0x00055414 File Offset: 0x00053614
		public unsafe double3 yyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yyw_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000F67 RID: 3943 RVA: 0x00055444 File Offset: 0x00053644
		// (set) Token: 0x06000F68 RID: 3944 RVA: 0x00055474 File Offset: 0x00053674
		public unsafe double3 yzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yzx_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_yzx_Public_set_Void_double3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000F69 RID: 3945 RVA: 0x000554A8 File Offset: 0x000536A8
		public unsafe double3 yzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yzy_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000F6A RID: 3946 RVA: 0x000554D8 File Offset: 0x000536D8
		public unsafe double3 yzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yzz_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000F6B RID: 3947 RVA: 0x00055508 File Offset: 0x00053708
		// (set) Token: 0x06000F6C RID: 3948 RVA: 0x00055538 File Offset: 0x00053738
		public unsafe double3 yzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yzw_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_yzw_Public_set_Void_double3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000F6D RID: 3949 RVA: 0x0005556C File Offset: 0x0005376C
		// (set) Token: 0x06000F6E RID: 3950 RVA: 0x0005559C File Offset: 0x0005379C
		public unsafe double3 ywx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_ywx_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_ywx_Public_set_Void_double3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000F6F RID: 3951 RVA: 0x000555D0 File Offset: 0x000537D0
		public unsafe double3 ywy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_ywy_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000F70 RID: 3952 RVA: 0x00055600 File Offset: 0x00053800
		// (set) Token: 0x06000F71 RID: 3953 RVA: 0x00055630 File Offset: 0x00053830
		public unsafe double3 ywz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_ywz_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_ywz_Public_set_Void_double3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000F72 RID: 3954 RVA: 0x00055664 File Offset: 0x00053864
		public unsafe double3 yww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yww_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000F73 RID: 3955 RVA: 0x00055694 File Offset: 0x00053894
		public unsafe double3 zxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zxx_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000F74 RID: 3956 RVA: 0x000556C4 File Offset: 0x000538C4
		// (set) Token: 0x06000F75 RID: 3957 RVA: 0x000556F4 File Offset: 0x000538F4
		public unsafe double3 zxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zxy_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_zxy_Public_set_Void_double3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000F76 RID: 3958 RVA: 0x00055728 File Offset: 0x00053928
		public unsafe double3 zxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zxz_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000F77 RID: 3959 RVA: 0x00055758 File Offset: 0x00053958
		// (set) Token: 0x06000F78 RID: 3960 RVA: 0x00055788 File Offset: 0x00053988
		public unsafe double3 zxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zxw_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_zxw_Public_set_Void_double3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000F79 RID: 3961 RVA: 0x000557BC File Offset: 0x000539BC
		// (set) Token: 0x06000F7A RID: 3962 RVA: 0x000557EC File Offset: 0x000539EC
		public unsafe double3 zyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zyx_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_zyx_Public_set_Void_double3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000F7B RID: 3963 RVA: 0x00055820 File Offset: 0x00053A20
		public unsafe double3 zyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zyy_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000F7C RID: 3964 RVA: 0x00055850 File Offset: 0x00053A50
		public unsafe double3 zyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zyz_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000F7D RID: 3965 RVA: 0x00055880 File Offset: 0x00053A80
		// (set) Token: 0x06000F7E RID: 3966 RVA: 0x000558B0 File Offset: 0x00053AB0
		public unsafe double3 zyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zyw_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_zyw_Public_set_Void_double3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000F7F RID: 3967 RVA: 0x000558E4 File Offset: 0x00053AE4
		public unsafe double3 zzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zzx_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000F80 RID: 3968 RVA: 0x00055914 File Offset: 0x00053B14
		public unsafe double3 zzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zzy_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000F81 RID: 3969 RVA: 0x00055944 File Offset: 0x00053B44
		public unsafe double3 zzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zzz_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000F82 RID: 3970 RVA: 0x00055974 File Offset: 0x00053B74
		public unsafe double3 zzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zzw_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000F83 RID: 3971 RVA: 0x000559A4 File Offset: 0x00053BA4
		// (set) Token: 0x06000F84 RID: 3972 RVA: 0x000559D4 File Offset: 0x00053BD4
		public unsafe double3 zwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zwx_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_zwx_Public_set_Void_double3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000F85 RID: 3973 RVA: 0x00055A08 File Offset: 0x00053C08
		// (set) Token: 0x06000F86 RID: 3974 RVA: 0x00055A38 File Offset: 0x00053C38
		public unsafe double3 zwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zwy_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_zwy_Public_set_Void_double3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000F87 RID: 3975 RVA: 0x00055A6C File Offset: 0x00053C6C
		public unsafe double3 zwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zwz_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000F88 RID: 3976 RVA: 0x00055A9C File Offset: 0x00053C9C
		public unsafe double3 zww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zww_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000F89 RID: 3977 RVA: 0x00055ACC File Offset: 0x00053CCC
		public unsafe double3 wxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wxx_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000F8A RID: 3978 RVA: 0x00055AFC File Offset: 0x00053CFC
		// (set) Token: 0x06000F8B RID: 3979 RVA: 0x00055B2C File Offset: 0x00053D2C
		public unsafe double3 wxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wxy_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_wxy_Public_set_Void_double3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000F8C RID: 3980 RVA: 0x00055B60 File Offset: 0x00053D60
		// (set) Token: 0x06000F8D RID: 3981 RVA: 0x00055B90 File Offset: 0x00053D90
		public unsafe double3 wxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wxz_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_wxz_Public_set_Void_double3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000F8E RID: 3982 RVA: 0x00055BC4 File Offset: 0x00053DC4
		public unsafe double3 wxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wxw_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000F8F RID: 3983 RVA: 0x00055BF4 File Offset: 0x00053DF4
		// (set) Token: 0x06000F90 RID: 3984 RVA: 0x00055C24 File Offset: 0x00053E24
		public unsafe double3 wyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wyx_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_wyx_Public_set_Void_double3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000F91 RID: 3985 RVA: 0x00055C58 File Offset: 0x00053E58
		public unsafe double3 wyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wyy_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000F92 RID: 3986 RVA: 0x00055C88 File Offset: 0x00053E88
		// (set) Token: 0x06000F93 RID: 3987 RVA: 0x00055CB8 File Offset: 0x00053EB8
		public unsafe double3 wyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wyz_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_wyz_Public_set_Void_double3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000F94 RID: 3988 RVA: 0x00055CEC File Offset: 0x00053EEC
		public unsafe double3 wyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wyw_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000F95 RID: 3989 RVA: 0x00055D1C File Offset: 0x00053F1C
		// (set) Token: 0x06000F96 RID: 3990 RVA: 0x00055D4C File Offset: 0x00053F4C
		public unsafe double3 wzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wzx_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_wzx_Public_set_Void_double3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000F97 RID: 3991 RVA: 0x00055D80 File Offset: 0x00053F80
		// (set) Token: 0x06000F98 RID: 3992 RVA: 0x00055DB0 File Offset: 0x00053FB0
		public unsafe double3 wzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wzy_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_wzy_Public_set_Void_double3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000F99 RID: 3993 RVA: 0x00055DE4 File Offset: 0x00053FE4
		public unsafe double3 wzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wzz_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000F9A RID: 3994 RVA: 0x00055E14 File Offset: 0x00054014
		public unsafe double3 wzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wzw_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000F9B RID: 3995 RVA: 0x00055E44 File Offset: 0x00054044
		public unsafe double3 wwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wwx_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000F9C RID: 3996 RVA: 0x00055E74 File Offset: 0x00054074
		public unsafe double3 wwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wwy_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000F9D RID: 3997 RVA: 0x00055EA4 File Offset: 0x000540A4
		public unsafe double3 wwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wwz_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000F9E RID: 3998 RVA: 0x00055ED4 File Offset: 0x000540D4
		public unsafe double3 www
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_www_Public_get_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000F9F RID: 3999 RVA: 0x00055F04 File Offset: 0x00054104
		public unsafe double2 xx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xx_Public_get_double2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000FA0 RID: 4000 RVA: 0x00055F34 File Offset: 0x00054134
		// (set) Token: 0x06000FA1 RID: 4001 RVA: 0x00055F64 File Offset: 0x00054164
		public unsafe double2 xy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xy_Public_get_double2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_xy_Public_set_Void_double2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000FA2 RID: 4002 RVA: 0x00055F98 File Offset: 0x00054198
		// (set) Token: 0x06000FA3 RID: 4003 RVA: 0x00055FC8 File Offset: 0x000541C8
		public unsafe double2 xz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xz_Public_get_double2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_xz_Public_set_Void_double2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000FA4 RID: 4004 RVA: 0x00055FFC File Offset: 0x000541FC
		// (set) Token: 0x06000FA5 RID: 4005 RVA: 0x0005602C File Offset: 0x0005422C
		public unsafe double2 xw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_xw_Public_get_double2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_xw_Public_set_Void_double2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000FA6 RID: 4006 RVA: 0x00056060 File Offset: 0x00054260
		// (set) Token: 0x06000FA7 RID: 4007 RVA: 0x00056090 File Offset: 0x00054290
		public unsafe double2 yx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yx_Public_get_double2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_yx_Public_set_Void_double2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000FA8 RID: 4008 RVA: 0x000560C4 File Offset: 0x000542C4
		public unsafe double2 yy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yy_Public_get_double2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000FA9 RID: 4009 RVA: 0x000560F4 File Offset: 0x000542F4
		// (set) Token: 0x06000FAA RID: 4010 RVA: 0x00056124 File Offset: 0x00054324
		public unsafe double2 yz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yz_Public_get_double2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_yz_Public_set_Void_double2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000FAB RID: 4011 RVA: 0x00056158 File Offset: 0x00054358
		// (set) Token: 0x06000FAC RID: 4012 RVA: 0x00056188 File Offset: 0x00054388
		public unsafe double2 yw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_yw_Public_get_double2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_yw_Public_set_Void_double2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000FAD RID: 4013 RVA: 0x000561BC File Offset: 0x000543BC
		// (set) Token: 0x06000FAE RID: 4014 RVA: 0x000561EC File Offset: 0x000543EC
		public unsafe double2 zx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zx_Public_get_double2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_zx_Public_set_Void_double2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000FAF RID: 4015 RVA: 0x00056220 File Offset: 0x00054420
		// (set) Token: 0x06000FB0 RID: 4016 RVA: 0x00056250 File Offset: 0x00054450
		public unsafe double2 zy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zy_Public_get_double2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_zy_Public_set_Void_double2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000FB1 RID: 4017 RVA: 0x00056284 File Offset: 0x00054484
		public unsafe double2 zz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zz_Public_get_double2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000FB2 RID: 4018 RVA: 0x000562B4 File Offset: 0x000544B4
		// (set) Token: 0x06000FB3 RID: 4019 RVA: 0x000562E4 File Offset: 0x000544E4
		public unsafe double2 zw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_zw_Public_get_double2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_zw_Public_set_Void_double2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000FB4 RID: 4020 RVA: 0x00056318 File Offset: 0x00054518
		// (set) Token: 0x06000FB5 RID: 4021 RVA: 0x00056348 File Offset: 0x00054548
		public unsafe double2 wx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wx_Public_get_double2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_wx_Public_set_Void_double2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000FB6 RID: 4022 RVA: 0x0005637C File Offset: 0x0005457C
		// (set) Token: 0x06000FB7 RID: 4023 RVA: 0x000563AC File Offset: 0x000545AC
		public unsafe double2 wy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wy_Public_get_double2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_wy_Public_set_Void_double2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000FB8 RID: 4024 RVA: 0x000563E0 File Offset: 0x000545E0
		// (set) Token: 0x06000FB9 RID: 4025 RVA: 0x00056410 File Offset: 0x00054610
		public unsafe double2 wz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_wz_Public_get_double2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_wz_Public_set_Void_double2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000FBA RID: 4026 RVA: 0x00056444 File Offset: 0x00054644
		public unsafe double2 ww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_ww_Public_get_double2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003F8 RID: 1016
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_get_Item_Public_get_Double_Int32_0, ref this, (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x000564F4 File Offset: 0x000546F4
		[CallerCount(0)]
		public unsafe bool Equals(double4 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x00056534 File Offset: 0x00054734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635884, XrefRangeEnd = 635887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x00056578 File Offset: 0x00054778
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x000565A8 File Offset: 0x000547A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635887, XrefRangeEnd = 635910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x000565D4 File Offset: 0x000547D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635910, XrefRangeEnd = 635938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x000023CC File Offset: 0x000005CC
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<double4>.NativeClassPtr, ref this));
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000FC3 RID: 4035 RVA: 0x00056624 File Offset: 0x00054824
		// (set) Token: 0x06000FC4 RID: 4036 RVA: 0x000023DE File Offset: 0x000005DE
		public unsafe static double4 zero
		{
			get
			{
				double4 @double;
				IL2CPP.il2cpp_field_static_get_value(double4.NativeFieldInfoPtr_zero, (void*)(&@double));
				return @double;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(double4.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x04000E13 RID: 3603
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x04000E14 RID: 3604
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04000E15 RID: 3605
		private static readonly IntPtr NativeFieldInfoPtr_z;

		// Token: 0x04000E16 RID: 3606
		private static readonly IntPtr NativeFieldInfoPtr_w;

		// Token: 0x04000E17 RID: 3607
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x04000E18 RID: 3608
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_Double_Double_Double_0;

		// Token: 0x04000E19 RID: 3609
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_Double_double2_0;

		// Token: 0x04000E1A RID: 3610
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_double2_Double_0;

		// Token: 0x04000E1B RID: 3611
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_double3_0;

		// Token: 0x04000E1C RID: 3612
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double2_Double_Double_0;

		// Token: 0x04000E1D RID: 3613
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double2_double2_0;

		// Token: 0x04000E1E RID: 3614
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double3_Double_0;

		// Token: 0x04000E1F RID: 3615
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double4_0;

		// Token: 0x04000E20 RID: 3616
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x04000E21 RID: 3617
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04000E22 RID: 3618
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool4_0;

		// Token: 0x04000E23 RID: 3619
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000E24 RID: 3620
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int4_0;

		// Token: 0x04000E25 RID: 3621
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04000E26 RID: 3622
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint4_0;

		// Token: 0x04000E27 RID: 3623
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_half_0;

		// Token: 0x04000E28 RID: 3624
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_half4_0;

		// Token: 0x04000E29 RID: 3625
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x04000E2A RID: 3626
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float4_0;

		// Token: 0x04000E2B RID: 3627
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double4_Double_0;

		// Token: 0x04000E2C RID: 3628
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_double4_Boolean_0;

		// Token: 0x04000E2D RID: 3629
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_double4_bool4_0;

		// Token: 0x04000E2E RID: 3630
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double4_Int32_0;

		// Token: 0x04000E2F RID: 3631
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double4_int4_0;

		// Token: 0x04000E30 RID: 3632
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double4_UInt32_0;

		// Token: 0x04000E31 RID: 3633
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double4_uint4_0;

		// Token: 0x04000E32 RID: 3634
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double4_half_0;

		// Token: 0x04000E33 RID: 3635
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double4_half4_0;

		// Token: 0x04000E34 RID: 3636
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double4_Single_0;

		// Token: 0x04000E35 RID: 3637
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double4_float4_0;

		// Token: 0x04000E36 RID: 3638
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_double4_double4_double4_0;

		// Token: 0x04000E37 RID: 3639
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_double4_double4_Double_0;

		// Token: 0x04000E38 RID: 3640
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_double4_Double_double4_0;

		// Token: 0x04000E39 RID: 3641
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_double4_double4_double4_0;

		// Token: 0x04000E3A RID: 3642
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_double4_double4_Double_0;

		// Token: 0x04000E3B RID: 3643
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_double4_Double_double4_0;

		// Token: 0x04000E3C RID: 3644
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_double4_double4_double4_0;

		// Token: 0x04000E3D RID: 3645
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_double4_double4_Double_0;

		// Token: 0x04000E3E RID: 3646
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_double4_Double_double4_0;

		// Token: 0x04000E3F RID: 3647
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_double4_double4_double4_0;

		// Token: 0x04000E40 RID: 3648
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_double4_double4_Double_0;

		// Token: 0x04000E41 RID: 3649
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_double4_Double_double4_0;

		// Token: 0x04000E42 RID: 3650
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_double4_double4_double4_0;

		// Token: 0x04000E43 RID: 3651
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_double4_double4_Double_0;

		// Token: 0x04000E44 RID: 3652
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_double4_Double_double4_0;

		// Token: 0x04000E45 RID: 3653
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_double4_double4_0;

		// Token: 0x04000E46 RID: 3654
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_double4_double4_0;

		// Token: 0x04000E47 RID: 3655
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool4_double4_double4_0;

		// Token: 0x04000E48 RID: 3656
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool4_double4_Double_0;

		// Token: 0x04000E49 RID: 3657
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool4_Double_double4_0;

		// Token: 0x04000E4A RID: 3658
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4_double4_double4_0;

		// Token: 0x04000E4B RID: 3659
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4_double4_Double_0;

		// Token: 0x04000E4C RID: 3660
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4_Double_double4_0;

		// Token: 0x04000E4D RID: 3661
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4_double4_double4_0;

		// Token: 0x04000E4E RID: 3662
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4_double4_Double_0;

		// Token: 0x04000E4F RID: 3663
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4_Double_double4_0;

		// Token: 0x04000E50 RID: 3664
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4_double4_double4_0;

		// Token: 0x04000E51 RID: 3665
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4_double4_Double_0;

		// Token: 0x04000E52 RID: 3666
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4_Double_double4_0;

		// Token: 0x04000E53 RID: 3667
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_double4_double4_0;

		// Token: 0x04000E54 RID: 3668
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryPlus_Public_Static_double4_double4_0;

		// Token: 0x04000E55 RID: 3669
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4_double4_double4_0;

		// Token: 0x04000E56 RID: 3670
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4_double4_Double_0;

		// Token: 0x04000E57 RID: 3671
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4_Double_double4_0;

		// Token: 0x04000E58 RID: 3672
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_double4_double4_0;

		// Token: 0x04000E59 RID: 3673
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_double4_Double_0;

		// Token: 0x04000E5A RID: 3674
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_Double_double4_0;

		// Token: 0x04000E5B RID: 3675
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxx_Public_get_double4_0;

		// Token: 0x04000E5C RID: 3676
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxy_Public_get_double4_0;

		// Token: 0x04000E5D RID: 3677
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxz_Public_get_double4_0;

		// Token: 0x04000E5E RID: 3678
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxw_Public_get_double4_0;

		// Token: 0x04000E5F RID: 3679
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyx_Public_get_double4_0;

		// Token: 0x04000E60 RID: 3680
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyy_Public_get_double4_0;

		// Token: 0x04000E61 RID: 3681
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyz_Public_get_double4_0;

		// Token: 0x04000E62 RID: 3682
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyw_Public_get_double4_0;

		// Token: 0x04000E63 RID: 3683
		private static readonly IntPtr NativeMethodInfoPtr_get_xxzx_Public_get_double4_0;

		// Token: 0x04000E64 RID: 3684
		private static readonly IntPtr NativeMethodInfoPtr_get_xxzy_Public_get_double4_0;

		// Token: 0x04000E65 RID: 3685
		private static readonly IntPtr NativeMethodInfoPtr_get_xxzz_Public_get_double4_0;

		// Token: 0x04000E66 RID: 3686
		private static readonly IntPtr NativeMethodInfoPtr_get_xxzw_Public_get_double4_0;

		// Token: 0x04000E67 RID: 3687
		private static readonly IntPtr NativeMethodInfoPtr_get_xxwx_Public_get_double4_0;

		// Token: 0x04000E68 RID: 3688
		private static readonly IntPtr NativeMethodInfoPtr_get_xxwy_Public_get_double4_0;

		// Token: 0x04000E69 RID: 3689
		private static readonly IntPtr NativeMethodInfoPtr_get_xxwz_Public_get_double4_0;

		// Token: 0x04000E6A RID: 3690
		private static readonly IntPtr NativeMethodInfoPtr_get_xxww_Public_get_double4_0;

		// Token: 0x04000E6B RID: 3691
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxx_Public_get_double4_0;

		// Token: 0x04000E6C RID: 3692
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxy_Public_get_double4_0;

		// Token: 0x04000E6D RID: 3693
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxz_Public_get_double4_0;

		// Token: 0x04000E6E RID: 3694
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxw_Public_get_double4_0;

		// Token: 0x04000E6F RID: 3695
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyx_Public_get_double4_0;

		// Token: 0x04000E70 RID: 3696
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyy_Public_get_double4_0;

		// Token: 0x04000E71 RID: 3697
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyz_Public_get_double4_0;

		// Token: 0x04000E72 RID: 3698
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyw_Public_get_double4_0;

		// Token: 0x04000E73 RID: 3699
		private static readonly IntPtr NativeMethodInfoPtr_get_xyzx_Public_get_double4_0;

		// Token: 0x04000E74 RID: 3700
		private static readonly IntPtr NativeMethodInfoPtr_get_xyzy_Public_get_double4_0;

		// Token: 0x04000E75 RID: 3701
		private static readonly IntPtr NativeMethodInfoPtr_get_xyzz_Public_get_double4_0;

		// Token: 0x04000E76 RID: 3702
		private static readonly IntPtr NativeMethodInfoPtr_get_xyzw_Public_get_double4_0;

		// Token: 0x04000E77 RID: 3703
		private static readonly IntPtr NativeMethodInfoPtr_set_xyzw_Public_set_Void_double4_0;

		// Token: 0x04000E78 RID: 3704
		private static readonly IntPtr NativeMethodInfoPtr_get_xywx_Public_get_double4_0;

		// Token: 0x04000E79 RID: 3705
		private static readonly IntPtr NativeMethodInfoPtr_get_xywy_Public_get_double4_0;

		// Token: 0x04000E7A RID: 3706
		private static readonly IntPtr NativeMethodInfoPtr_get_xywz_Public_get_double4_0;

		// Token: 0x04000E7B RID: 3707
		private static readonly IntPtr NativeMethodInfoPtr_set_xywz_Public_set_Void_double4_0;

		// Token: 0x04000E7C RID: 3708
		private static readonly IntPtr NativeMethodInfoPtr_get_xyww_Public_get_double4_0;

		// Token: 0x04000E7D RID: 3709
		private static readonly IntPtr NativeMethodInfoPtr_get_xzxx_Public_get_double4_0;

		// Token: 0x04000E7E RID: 3710
		private static readonly IntPtr NativeMethodInfoPtr_get_xzxy_Public_get_double4_0;

		// Token: 0x04000E7F RID: 3711
		private static readonly IntPtr NativeMethodInfoPtr_get_xzxz_Public_get_double4_0;

		// Token: 0x04000E80 RID: 3712
		private static readonly IntPtr NativeMethodInfoPtr_get_xzxw_Public_get_double4_0;

		// Token: 0x04000E81 RID: 3713
		private static readonly IntPtr NativeMethodInfoPtr_get_xzyx_Public_get_double4_0;

		// Token: 0x04000E82 RID: 3714
		private static readonly IntPtr NativeMethodInfoPtr_get_xzyy_Public_get_double4_0;

		// Token: 0x04000E83 RID: 3715
		private static readonly IntPtr NativeMethodInfoPtr_get_xzyz_Public_get_double4_0;

		// Token: 0x04000E84 RID: 3716
		private static readonly IntPtr NativeMethodInfoPtr_get_xzyw_Public_get_double4_0;

		// Token: 0x04000E85 RID: 3717
		private static readonly IntPtr NativeMethodInfoPtr_set_xzyw_Public_set_Void_double4_0;

		// Token: 0x04000E86 RID: 3718
		private static readonly IntPtr NativeMethodInfoPtr_get_xzzx_Public_get_double4_0;

		// Token: 0x04000E87 RID: 3719
		private static readonly IntPtr NativeMethodInfoPtr_get_xzzy_Public_get_double4_0;

		// Token: 0x04000E88 RID: 3720
		private static readonly IntPtr NativeMethodInfoPtr_get_xzzz_Public_get_double4_0;

		// Token: 0x04000E89 RID: 3721
		private static readonly IntPtr NativeMethodInfoPtr_get_xzzw_Public_get_double4_0;

		// Token: 0x04000E8A RID: 3722
		private static readonly IntPtr NativeMethodInfoPtr_get_xzwx_Public_get_double4_0;

		// Token: 0x04000E8B RID: 3723
		private static readonly IntPtr NativeMethodInfoPtr_get_xzwy_Public_get_double4_0;

		// Token: 0x04000E8C RID: 3724
		private static readonly IntPtr NativeMethodInfoPtr_set_xzwy_Public_set_Void_double4_0;

		// Token: 0x04000E8D RID: 3725
		private static readonly IntPtr NativeMethodInfoPtr_get_xzwz_Public_get_double4_0;

		// Token: 0x04000E8E RID: 3726
		private static readonly IntPtr NativeMethodInfoPtr_get_xzww_Public_get_double4_0;

		// Token: 0x04000E8F RID: 3727
		private static readonly IntPtr NativeMethodInfoPtr_get_xwxx_Public_get_double4_0;

		// Token: 0x04000E90 RID: 3728
		private static readonly IntPtr NativeMethodInfoPtr_get_xwxy_Public_get_double4_0;

		// Token: 0x04000E91 RID: 3729
		private static readonly IntPtr NativeMethodInfoPtr_get_xwxz_Public_get_double4_0;

		// Token: 0x04000E92 RID: 3730
		private static readonly IntPtr NativeMethodInfoPtr_get_xwxw_Public_get_double4_0;

		// Token: 0x04000E93 RID: 3731
		private static readonly IntPtr NativeMethodInfoPtr_get_xwyx_Public_get_double4_0;

		// Token: 0x04000E94 RID: 3732
		private static readonly IntPtr NativeMethodInfoPtr_get_xwyy_Public_get_double4_0;

		// Token: 0x04000E95 RID: 3733
		private static readonly IntPtr NativeMethodInfoPtr_get_xwyz_Public_get_double4_0;

		// Token: 0x04000E96 RID: 3734
		private static readonly IntPtr NativeMethodInfoPtr_set_xwyz_Public_set_Void_double4_0;

		// Token: 0x04000E97 RID: 3735
		private static readonly IntPtr NativeMethodInfoPtr_get_xwyw_Public_get_double4_0;

		// Token: 0x04000E98 RID: 3736
		private static readonly IntPtr NativeMethodInfoPtr_get_xwzx_Public_get_double4_0;

		// Token: 0x04000E99 RID: 3737
		private static readonly IntPtr NativeMethodInfoPtr_get_xwzy_Public_get_double4_0;

		// Token: 0x04000E9A RID: 3738
		private static readonly IntPtr NativeMethodInfoPtr_set_xwzy_Public_set_Void_double4_0;

		// Token: 0x04000E9B RID: 3739
		private static readonly IntPtr NativeMethodInfoPtr_get_xwzz_Public_get_double4_0;

		// Token: 0x04000E9C RID: 3740
		private static readonly IntPtr NativeMethodInfoPtr_get_xwzw_Public_get_double4_0;

		// Token: 0x04000E9D RID: 3741
		private static readonly IntPtr NativeMethodInfoPtr_get_xwwx_Public_get_double4_0;

		// Token: 0x04000E9E RID: 3742
		private static readonly IntPtr NativeMethodInfoPtr_get_xwwy_Public_get_double4_0;

		// Token: 0x04000E9F RID: 3743
		private static readonly IntPtr NativeMethodInfoPtr_get_xwwz_Public_get_double4_0;

		// Token: 0x04000EA0 RID: 3744
		private static readonly IntPtr NativeMethodInfoPtr_get_xwww_Public_get_double4_0;

		// Token: 0x04000EA1 RID: 3745
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxx_Public_get_double4_0;

		// Token: 0x04000EA2 RID: 3746
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxy_Public_get_double4_0;

		// Token: 0x04000EA3 RID: 3747
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxz_Public_get_double4_0;

		// Token: 0x04000EA4 RID: 3748
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxw_Public_get_double4_0;

		// Token: 0x04000EA5 RID: 3749
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyx_Public_get_double4_0;

		// Token: 0x04000EA6 RID: 3750
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyy_Public_get_double4_0;

		// Token: 0x04000EA7 RID: 3751
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyz_Public_get_double4_0;

		// Token: 0x04000EA8 RID: 3752
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyw_Public_get_double4_0;

		// Token: 0x04000EA9 RID: 3753
		private static readonly IntPtr NativeMethodInfoPtr_get_yxzx_Public_get_double4_0;

		// Token: 0x04000EAA RID: 3754
		private static readonly IntPtr NativeMethodInfoPtr_get_yxzy_Public_get_double4_0;

		// Token: 0x04000EAB RID: 3755
		private static readonly IntPtr NativeMethodInfoPtr_get_yxzz_Public_get_double4_0;

		// Token: 0x04000EAC RID: 3756
		private static readonly IntPtr NativeMethodInfoPtr_get_yxzw_Public_get_double4_0;

		// Token: 0x04000EAD RID: 3757
		private static readonly IntPtr NativeMethodInfoPtr_set_yxzw_Public_set_Void_double4_0;

		// Token: 0x04000EAE RID: 3758
		private static readonly IntPtr NativeMethodInfoPtr_get_yxwx_Public_get_double4_0;

		// Token: 0x04000EAF RID: 3759
		private static readonly IntPtr NativeMethodInfoPtr_get_yxwy_Public_get_double4_0;

		// Token: 0x04000EB0 RID: 3760
		private static readonly IntPtr NativeMethodInfoPtr_get_yxwz_Public_get_double4_0;

		// Token: 0x04000EB1 RID: 3761
		private static readonly IntPtr NativeMethodInfoPtr_set_yxwz_Public_set_Void_double4_0;

		// Token: 0x04000EB2 RID: 3762
		private static readonly IntPtr NativeMethodInfoPtr_get_yxww_Public_get_double4_0;

		// Token: 0x04000EB3 RID: 3763
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxx_Public_get_double4_0;

		// Token: 0x04000EB4 RID: 3764
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxy_Public_get_double4_0;

		// Token: 0x04000EB5 RID: 3765
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxz_Public_get_double4_0;

		// Token: 0x04000EB6 RID: 3766
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxw_Public_get_double4_0;

		// Token: 0x04000EB7 RID: 3767
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyx_Public_get_double4_0;

		// Token: 0x04000EB8 RID: 3768
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyy_Public_get_double4_0;

		// Token: 0x04000EB9 RID: 3769
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyz_Public_get_double4_0;

		// Token: 0x04000EBA RID: 3770
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyw_Public_get_double4_0;

		// Token: 0x04000EBB RID: 3771
		private static readonly IntPtr NativeMethodInfoPtr_get_yyzx_Public_get_double4_0;

		// Token: 0x04000EBC RID: 3772
		private static readonly IntPtr NativeMethodInfoPtr_get_yyzy_Public_get_double4_0;

		// Token: 0x04000EBD RID: 3773
		private static readonly IntPtr NativeMethodInfoPtr_get_yyzz_Public_get_double4_0;

		// Token: 0x04000EBE RID: 3774
		private static readonly IntPtr NativeMethodInfoPtr_get_yyzw_Public_get_double4_0;

		// Token: 0x04000EBF RID: 3775
		private static readonly IntPtr NativeMethodInfoPtr_get_yywx_Public_get_double4_0;

		// Token: 0x04000EC0 RID: 3776
		private static readonly IntPtr NativeMethodInfoPtr_get_yywy_Public_get_double4_0;

		// Token: 0x04000EC1 RID: 3777
		private static readonly IntPtr NativeMethodInfoPtr_get_yywz_Public_get_double4_0;

		// Token: 0x04000EC2 RID: 3778
		private static readonly IntPtr NativeMethodInfoPtr_get_yyww_Public_get_double4_0;

		// Token: 0x04000EC3 RID: 3779
		private static readonly IntPtr NativeMethodInfoPtr_get_yzxx_Public_get_double4_0;

		// Token: 0x04000EC4 RID: 3780
		private static readonly IntPtr NativeMethodInfoPtr_get_yzxy_Public_get_double4_0;

		// Token: 0x04000EC5 RID: 3781
		private static readonly IntPtr NativeMethodInfoPtr_get_yzxz_Public_get_double4_0;

		// Token: 0x04000EC6 RID: 3782
		private static readonly IntPtr NativeMethodInfoPtr_get_yzxw_Public_get_double4_0;

		// Token: 0x04000EC7 RID: 3783
		private static readonly IntPtr NativeMethodInfoPtr_set_yzxw_Public_set_Void_double4_0;

		// Token: 0x04000EC8 RID: 3784
		private static readonly IntPtr NativeMethodInfoPtr_get_yzyx_Public_get_double4_0;

		// Token: 0x04000EC9 RID: 3785
		private static readonly IntPtr NativeMethodInfoPtr_get_yzyy_Public_get_double4_0;

		// Token: 0x04000ECA RID: 3786
		private static readonly IntPtr NativeMethodInfoPtr_get_yzyz_Public_get_double4_0;

		// Token: 0x04000ECB RID: 3787
		private static readonly IntPtr NativeMethodInfoPtr_get_yzyw_Public_get_double4_0;

		// Token: 0x04000ECC RID: 3788
		private static readonly IntPtr NativeMethodInfoPtr_get_yzzx_Public_get_double4_0;

		// Token: 0x04000ECD RID: 3789
		private static readonly IntPtr NativeMethodInfoPtr_get_yzzy_Public_get_double4_0;

		// Token: 0x04000ECE RID: 3790
		private static readonly IntPtr NativeMethodInfoPtr_get_yzzz_Public_get_double4_0;

		// Token: 0x04000ECF RID: 3791
		private static readonly IntPtr NativeMethodInfoPtr_get_yzzw_Public_get_double4_0;

		// Token: 0x04000ED0 RID: 3792
		private static readonly IntPtr NativeMethodInfoPtr_get_yzwx_Public_get_double4_0;

		// Token: 0x04000ED1 RID: 3793
		private static readonly IntPtr NativeMethodInfoPtr_set_yzwx_Public_set_Void_double4_0;

		// Token: 0x04000ED2 RID: 3794
		private static readonly IntPtr NativeMethodInfoPtr_get_yzwy_Public_get_double4_0;

		// Token: 0x04000ED3 RID: 3795
		private static readonly IntPtr NativeMethodInfoPtr_get_yzwz_Public_get_double4_0;

		// Token: 0x04000ED4 RID: 3796
		private static readonly IntPtr NativeMethodInfoPtr_get_yzww_Public_get_double4_0;

		// Token: 0x04000ED5 RID: 3797
		private static readonly IntPtr NativeMethodInfoPtr_get_ywxx_Public_get_double4_0;

		// Token: 0x04000ED6 RID: 3798
		private static readonly IntPtr NativeMethodInfoPtr_get_ywxy_Public_get_double4_0;

		// Token: 0x04000ED7 RID: 3799
		private static readonly IntPtr NativeMethodInfoPtr_get_ywxz_Public_get_double4_0;

		// Token: 0x04000ED8 RID: 3800
		private static readonly IntPtr NativeMethodInfoPtr_set_ywxz_Public_set_Void_double4_0;

		// Token: 0x04000ED9 RID: 3801
		private static readonly IntPtr NativeMethodInfoPtr_get_ywxw_Public_get_double4_0;

		// Token: 0x04000EDA RID: 3802
		private static readonly IntPtr NativeMethodInfoPtr_get_ywyx_Public_get_double4_0;

		// Token: 0x04000EDB RID: 3803
		private static readonly IntPtr NativeMethodInfoPtr_get_ywyy_Public_get_double4_0;

		// Token: 0x04000EDC RID: 3804
		private static readonly IntPtr NativeMethodInfoPtr_get_ywyz_Public_get_double4_0;

		// Token: 0x04000EDD RID: 3805
		private static readonly IntPtr NativeMethodInfoPtr_get_ywyw_Public_get_double4_0;

		// Token: 0x04000EDE RID: 3806
		private static readonly IntPtr NativeMethodInfoPtr_get_ywzx_Public_get_double4_0;

		// Token: 0x04000EDF RID: 3807
		private static readonly IntPtr NativeMethodInfoPtr_set_ywzx_Public_set_Void_double4_0;

		// Token: 0x04000EE0 RID: 3808
		private static readonly IntPtr NativeMethodInfoPtr_get_ywzy_Public_get_double4_0;

		// Token: 0x04000EE1 RID: 3809
		private static readonly IntPtr NativeMethodInfoPtr_get_ywzz_Public_get_double4_0;

		// Token: 0x04000EE2 RID: 3810
		private static readonly IntPtr NativeMethodInfoPtr_get_ywzw_Public_get_double4_0;

		// Token: 0x04000EE3 RID: 3811
		private static readonly IntPtr NativeMethodInfoPtr_get_ywwx_Public_get_double4_0;

		// Token: 0x04000EE4 RID: 3812
		private static readonly IntPtr NativeMethodInfoPtr_get_ywwy_Public_get_double4_0;

		// Token: 0x04000EE5 RID: 3813
		private static readonly IntPtr NativeMethodInfoPtr_get_ywwz_Public_get_double4_0;

		// Token: 0x04000EE6 RID: 3814
		private static readonly IntPtr NativeMethodInfoPtr_get_ywww_Public_get_double4_0;

		// Token: 0x04000EE7 RID: 3815
		private static readonly IntPtr NativeMethodInfoPtr_get_zxxx_Public_get_double4_0;

		// Token: 0x04000EE8 RID: 3816
		private static readonly IntPtr NativeMethodInfoPtr_get_zxxy_Public_get_double4_0;

		// Token: 0x04000EE9 RID: 3817
		private static readonly IntPtr NativeMethodInfoPtr_get_zxxz_Public_get_double4_0;

		// Token: 0x04000EEA RID: 3818
		private static readonly IntPtr NativeMethodInfoPtr_get_zxxw_Public_get_double4_0;

		// Token: 0x04000EEB RID: 3819
		private static readonly IntPtr NativeMethodInfoPtr_get_zxyx_Public_get_double4_0;

		// Token: 0x04000EEC RID: 3820
		private static readonly IntPtr NativeMethodInfoPtr_get_zxyy_Public_get_double4_0;

		// Token: 0x04000EED RID: 3821
		private static readonly IntPtr NativeMethodInfoPtr_get_zxyz_Public_get_double4_0;

		// Token: 0x04000EEE RID: 3822
		private static readonly IntPtr NativeMethodInfoPtr_get_zxyw_Public_get_double4_0;

		// Token: 0x04000EEF RID: 3823
		private static readonly IntPtr NativeMethodInfoPtr_set_zxyw_Public_set_Void_double4_0;

		// Token: 0x04000EF0 RID: 3824
		private static readonly IntPtr NativeMethodInfoPtr_get_zxzx_Public_get_double4_0;

		// Token: 0x04000EF1 RID: 3825
		private static readonly IntPtr NativeMethodInfoPtr_get_zxzy_Public_get_double4_0;

		// Token: 0x04000EF2 RID: 3826
		private static readonly IntPtr NativeMethodInfoPtr_get_zxzz_Public_get_double4_0;

		// Token: 0x04000EF3 RID: 3827
		private static readonly IntPtr NativeMethodInfoPtr_get_zxzw_Public_get_double4_0;

		// Token: 0x04000EF4 RID: 3828
		private static readonly IntPtr NativeMethodInfoPtr_get_zxwx_Public_get_double4_0;

		// Token: 0x04000EF5 RID: 3829
		private static readonly IntPtr NativeMethodInfoPtr_get_zxwy_Public_get_double4_0;

		// Token: 0x04000EF6 RID: 3830
		private static readonly IntPtr NativeMethodInfoPtr_set_zxwy_Public_set_Void_double4_0;

		// Token: 0x04000EF7 RID: 3831
		private static readonly IntPtr NativeMethodInfoPtr_get_zxwz_Public_get_double4_0;

		// Token: 0x04000EF8 RID: 3832
		private static readonly IntPtr NativeMethodInfoPtr_get_zxww_Public_get_double4_0;

		// Token: 0x04000EF9 RID: 3833
		private static readonly IntPtr NativeMethodInfoPtr_get_zyxx_Public_get_double4_0;

		// Token: 0x04000EFA RID: 3834
		private static readonly IntPtr NativeMethodInfoPtr_get_zyxy_Public_get_double4_0;

		// Token: 0x04000EFB RID: 3835
		private static readonly IntPtr NativeMethodInfoPtr_get_zyxz_Public_get_double4_0;

		// Token: 0x04000EFC RID: 3836
		private static readonly IntPtr NativeMethodInfoPtr_get_zyxw_Public_get_double4_0;

		// Token: 0x04000EFD RID: 3837
		private static readonly IntPtr NativeMethodInfoPtr_set_zyxw_Public_set_Void_double4_0;

		// Token: 0x04000EFE RID: 3838
		private static readonly IntPtr NativeMethodInfoPtr_get_zyyx_Public_get_double4_0;

		// Token: 0x04000EFF RID: 3839
		private static readonly IntPtr NativeMethodInfoPtr_get_zyyy_Public_get_double4_0;

		// Token: 0x04000F00 RID: 3840
		private static readonly IntPtr NativeMethodInfoPtr_get_zyyz_Public_get_double4_0;

		// Token: 0x04000F01 RID: 3841
		private static readonly IntPtr NativeMethodInfoPtr_get_zyyw_Public_get_double4_0;

		// Token: 0x04000F02 RID: 3842
		private static readonly IntPtr NativeMethodInfoPtr_get_zyzx_Public_get_double4_0;

		// Token: 0x04000F03 RID: 3843
		private static readonly IntPtr NativeMethodInfoPtr_get_zyzy_Public_get_double4_0;

		// Token: 0x04000F04 RID: 3844
		private static readonly IntPtr NativeMethodInfoPtr_get_zyzz_Public_get_double4_0;

		// Token: 0x04000F05 RID: 3845
		private static readonly IntPtr NativeMethodInfoPtr_get_zyzw_Public_get_double4_0;

		// Token: 0x04000F06 RID: 3846
		private static readonly IntPtr NativeMethodInfoPtr_get_zywx_Public_get_double4_0;

		// Token: 0x04000F07 RID: 3847
		private static readonly IntPtr NativeMethodInfoPtr_set_zywx_Public_set_Void_double4_0;

		// Token: 0x04000F08 RID: 3848
		private static readonly IntPtr NativeMethodInfoPtr_get_zywy_Public_get_double4_0;

		// Token: 0x04000F09 RID: 3849
		private static readonly IntPtr NativeMethodInfoPtr_get_zywz_Public_get_double4_0;

		// Token: 0x04000F0A RID: 3850
		private static readonly IntPtr NativeMethodInfoPtr_get_zyww_Public_get_double4_0;

		// Token: 0x04000F0B RID: 3851
		private static readonly IntPtr NativeMethodInfoPtr_get_zzxx_Public_get_double4_0;

		// Token: 0x04000F0C RID: 3852
		private static readonly IntPtr NativeMethodInfoPtr_get_zzxy_Public_get_double4_0;

		// Token: 0x04000F0D RID: 3853
		private static readonly IntPtr NativeMethodInfoPtr_get_zzxz_Public_get_double4_0;

		// Token: 0x04000F0E RID: 3854
		private static readonly IntPtr NativeMethodInfoPtr_get_zzxw_Public_get_double4_0;

		// Token: 0x04000F0F RID: 3855
		private static readonly IntPtr NativeMethodInfoPtr_get_zzyx_Public_get_double4_0;

		// Token: 0x04000F10 RID: 3856
		private static readonly IntPtr NativeMethodInfoPtr_get_zzyy_Public_get_double4_0;

		// Token: 0x04000F11 RID: 3857
		private static readonly IntPtr NativeMethodInfoPtr_get_zzyz_Public_get_double4_0;

		// Token: 0x04000F12 RID: 3858
		private static readonly IntPtr NativeMethodInfoPtr_get_zzyw_Public_get_double4_0;

		// Token: 0x04000F13 RID: 3859
		private static readonly IntPtr NativeMethodInfoPtr_get_zzzx_Public_get_double4_0;

		// Token: 0x04000F14 RID: 3860
		private static readonly IntPtr NativeMethodInfoPtr_get_zzzy_Public_get_double4_0;

		// Token: 0x04000F15 RID: 3861
		private static readonly IntPtr NativeMethodInfoPtr_get_zzzz_Public_get_double4_0;

		// Token: 0x04000F16 RID: 3862
		private static readonly IntPtr NativeMethodInfoPtr_get_zzzw_Public_get_double4_0;

		// Token: 0x04000F17 RID: 3863
		private static readonly IntPtr NativeMethodInfoPtr_get_zzwx_Public_get_double4_0;

		// Token: 0x04000F18 RID: 3864
		private static readonly IntPtr NativeMethodInfoPtr_get_zzwy_Public_get_double4_0;

		// Token: 0x04000F19 RID: 3865
		private static readonly IntPtr NativeMethodInfoPtr_get_zzwz_Public_get_double4_0;

		// Token: 0x04000F1A RID: 3866
		private static readonly IntPtr NativeMethodInfoPtr_get_zzww_Public_get_double4_0;

		// Token: 0x04000F1B RID: 3867
		private static readonly IntPtr NativeMethodInfoPtr_get_zwxx_Public_get_double4_0;

		// Token: 0x04000F1C RID: 3868
		private static readonly IntPtr NativeMethodInfoPtr_get_zwxy_Public_get_double4_0;

		// Token: 0x04000F1D RID: 3869
		private static readonly IntPtr NativeMethodInfoPtr_set_zwxy_Public_set_Void_double4_0;

		// Token: 0x04000F1E RID: 3870
		private static readonly IntPtr NativeMethodInfoPtr_get_zwxz_Public_get_double4_0;

		// Token: 0x04000F1F RID: 3871
		private static readonly IntPtr NativeMethodInfoPtr_get_zwxw_Public_get_double4_0;

		// Token: 0x04000F20 RID: 3872
		private static readonly IntPtr NativeMethodInfoPtr_get_zwyx_Public_get_double4_0;

		// Token: 0x04000F21 RID: 3873
		private static readonly IntPtr NativeMethodInfoPtr_set_zwyx_Public_set_Void_double4_0;

		// Token: 0x04000F22 RID: 3874
		private static readonly IntPtr NativeMethodInfoPtr_get_zwyy_Public_get_double4_0;

		// Token: 0x04000F23 RID: 3875
		private static readonly IntPtr NativeMethodInfoPtr_get_zwyz_Public_get_double4_0;

		// Token: 0x04000F24 RID: 3876
		private static readonly IntPtr NativeMethodInfoPtr_get_zwyw_Public_get_double4_0;

		// Token: 0x04000F25 RID: 3877
		private static readonly IntPtr NativeMethodInfoPtr_get_zwzx_Public_get_double4_0;

		// Token: 0x04000F26 RID: 3878
		private static readonly IntPtr NativeMethodInfoPtr_get_zwzy_Public_get_double4_0;

		// Token: 0x04000F27 RID: 3879
		private static readonly IntPtr NativeMethodInfoPtr_get_zwzz_Public_get_double4_0;

		// Token: 0x04000F28 RID: 3880
		private static readonly IntPtr NativeMethodInfoPtr_get_zwzw_Public_get_double4_0;

		// Token: 0x04000F29 RID: 3881
		private static readonly IntPtr NativeMethodInfoPtr_get_zwwx_Public_get_double4_0;

		// Token: 0x04000F2A RID: 3882
		private static readonly IntPtr NativeMethodInfoPtr_get_zwwy_Public_get_double4_0;

		// Token: 0x04000F2B RID: 3883
		private static readonly IntPtr NativeMethodInfoPtr_get_zwwz_Public_get_double4_0;

		// Token: 0x04000F2C RID: 3884
		private static readonly IntPtr NativeMethodInfoPtr_get_zwww_Public_get_double4_0;

		// Token: 0x04000F2D RID: 3885
		private static readonly IntPtr NativeMethodInfoPtr_get_wxxx_Public_get_double4_0;

		// Token: 0x04000F2E RID: 3886
		private static readonly IntPtr NativeMethodInfoPtr_get_wxxy_Public_get_double4_0;

		// Token: 0x04000F2F RID: 3887
		private static readonly IntPtr NativeMethodInfoPtr_get_wxxz_Public_get_double4_0;

		// Token: 0x04000F30 RID: 3888
		private static readonly IntPtr NativeMethodInfoPtr_get_wxxw_Public_get_double4_0;

		// Token: 0x04000F31 RID: 3889
		private static readonly IntPtr NativeMethodInfoPtr_get_wxyx_Public_get_double4_0;

		// Token: 0x04000F32 RID: 3890
		private static readonly IntPtr NativeMethodInfoPtr_get_wxyy_Public_get_double4_0;

		// Token: 0x04000F33 RID: 3891
		private static readonly IntPtr NativeMethodInfoPtr_get_wxyz_Public_get_double4_0;

		// Token: 0x04000F34 RID: 3892
		private static readonly IntPtr NativeMethodInfoPtr_set_wxyz_Public_set_Void_double4_0;

		// Token: 0x04000F35 RID: 3893
		private static readonly IntPtr NativeMethodInfoPtr_get_wxyw_Public_get_double4_0;

		// Token: 0x04000F36 RID: 3894
		private static readonly IntPtr NativeMethodInfoPtr_get_wxzx_Public_get_double4_0;

		// Token: 0x04000F37 RID: 3895
		private static readonly IntPtr NativeMethodInfoPtr_get_wxzy_Public_get_double4_0;

		// Token: 0x04000F38 RID: 3896
		private static readonly IntPtr NativeMethodInfoPtr_set_wxzy_Public_set_Void_double4_0;

		// Token: 0x04000F39 RID: 3897
		private static readonly IntPtr NativeMethodInfoPtr_get_wxzz_Public_get_double4_0;

		// Token: 0x04000F3A RID: 3898
		private static readonly IntPtr NativeMethodInfoPtr_get_wxzw_Public_get_double4_0;

		// Token: 0x04000F3B RID: 3899
		private static readonly IntPtr NativeMethodInfoPtr_get_wxwx_Public_get_double4_0;

		// Token: 0x04000F3C RID: 3900
		private static readonly IntPtr NativeMethodInfoPtr_get_wxwy_Public_get_double4_0;

		// Token: 0x04000F3D RID: 3901
		private static readonly IntPtr NativeMethodInfoPtr_get_wxwz_Public_get_double4_0;

		// Token: 0x04000F3E RID: 3902
		private static readonly IntPtr NativeMethodInfoPtr_get_wxww_Public_get_double4_0;

		// Token: 0x04000F3F RID: 3903
		private static readonly IntPtr NativeMethodInfoPtr_get_wyxx_Public_get_double4_0;

		// Token: 0x04000F40 RID: 3904
		private static readonly IntPtr NativeMethodInfoPtr_get_wyxy_Public_get_double4_0;

		// Token: 0x04000F41 RID: 3905
		private static readonly IntPtr NativeMethodInfoPtr_get_wyxz_Public_get_double4_0;

		// Token: 0x04000F42 RID: 3906
		private static readonly IntPtr NativeMethodInfoPtr_set_wyxz_Public_set_Void_double4_0;

		// Token: 0x04000F43 RID: 3907
		private static readonly IntPtr NativeMethodInfoPtr_get_wyxw_Public_get_double4_0;

		// Token: 0x04000F44 RID: 3908
		private static readonly IntPtr NativeMethodInfoPtr_get_wyyx_Public_get_double4_0;

		// Token: 0x04000F45 RID: 3909
		private static readonly IntPtr NativeMethodInfoPtr_get_wyyy_Public_get_double4_0;

		// Token: 0x04000F46 RID: 3910
		private static readonly IntPtr NativeMethodInfoPtr_get_wyyz_Public_get_double4_0;

		// Token: 0x04000F47 RID: 3911
		private static readonly IntPtr NativeMethodInfoPtr_get_wyyw_Public_get_double4_0;

		// Token: 0x04000F48 RID: 3912
		private static readonly IntPtr NativeMethodInfoPtr_get_wyzx_Public_get_double4_0;

		// Token: 0x04000F49 RID: 3913
		private static readonly IntPtr NativeMethodInfoPtr_set_wyzx_Public_set_Void_double4_0;

		// Token: 0x04000F4A RID: 3914
		private static readonly IntPtr NativeMethodInfoPtr_get_wyzy_Public_get_double4_0;

		// Token: 0x04000F4B RID: 3915
		private static readonly IntPtr NativeMethodInfoPtr_get_wyzz_Public_get_double4_0;

		// Token: 0x04000F4C RID: 3916
		private static readonly IntPtr NativeMethodInfoPtr_get_wyzw_Public_get_double4_0;

		// Token: 0x04000F4D RID: 3917
		private static readonly IntPtr NativeMethodInfoPtr_get_wywx_Public_get_double4_0;

		// Token: 0x04000F4E RID: 3918
		private static readonly IntPtr NativeMethodInfoPtr_get_wywy_Public_get_double4_0;

		// Token: 0x04000F4F RID: 3919
		private static readonly IntPtr NativeMethodInfoPtr_get_wywz_Public_get_double4_0;

		// Token: 0x04000F50 RID: 3920
		private static readonly IntPtr NativeMethodInfoPtr_get_wyww_Public_get_double4_0;

		// Token: 0x04000F51 RID: 3921
		private static readonly IntPtr NativeMethodInfoPtr_get_wzxx_Public_get_double4_0;

		// Token: 0x04000F52 RID: 3922
		private static readonly IntPtr NativeMethodInfoPtr_get_wzxy_Public_get_double4_0;

		// Token: 0x04000F53 RID: 3923
		private static readonly IntPtr NativeMethodInfoPtr_set_wzxy_Public_set_Void_double4_0;

		// Token: 0x04000F54 RID: 3924
		private static readonly IntPtr NativeMethodInfoPtr_get_wzxz_Public_get_double4_0;

		// Token: 0x04000F55 RID: 3925
		private static readonly IntPtr NativeMethodInfoPtr_get_wzxw_Public_get_double4_0;

		// Token: 0x04000F56 RID: 3926
		private static readonly IntPtr NativeMethodInfoPtr_get_wzyx_Public_get_double4_0;

		// Token: 0x04000F57 RID: 3927
		private static readonly IntPtr NativeMethodInfoPtr_set_wzyx_Public_set_Void_double4_0;

		// Token: 0x04000F58 RID: 3928
		private static readonly IntPtr NativeMethodInfoPtr_get_wzyy_Public_get_double4_0;

		// Token: 0x04000F59 RID: 3929
		private static readonly IntPtr NativeMethodInfoPtr_get_wzyz_Public_get_double4_0;

		// Token: 0x04000F5A RID: 3930
		private static readonly IntPtr NativeMethodInfoPtr_get_wzyw_Public_get_double4_0;

		// Token: 0x04000F5B RID: 3931
		private static readonly IntPtr NativeMethodInfoPtr_get_wzzx_Public_get_double4_0;

		// Token: 0x04000F5C RID: 3932
		private static readonly IntPtr NativeMethodInfoPtr_get_wzzy_Public_get_double4_0;

		// Token: 0x04000F5D RID: 3933
		private static readonly IntPtr NativeMethodInfoPtr_get_wzzz_Public_get_double4_0;

		// Token: 0x04000F5E RID: 3934
		private static readonly IntPtr NativeMethodInfoPtr_get_wzzw_Public_get_double4_0;

		// Token: 0x04000F5F RID: 3935
		private static readonly IntPtr NativeMethodInfoPtr_get_wzwx_Public_get_double4_0;

		// Token: 0x04000F60 RID: 3936
		private static readonly IntPtr NativeMethodInfoPtr_get_wzwy_Public_get_double4_0;

		// Token: 0x04000F61 RID: 3937
		private static readonly IntPtr NativeMethodInfoPtr_get_wzwz_Public_get_double4_0;

		// Token: 0x04000F62 RID: 3938
		private static readonly IntPtr NativeMethodInfoPtr_get_wzww_Public_get_double4_0;

		// Token: 0x04000F63 RID: 3939
		private static readonly IntPtr NativeMethodInfoPtr_get_wwxx_Public_get_double4_0;

		// Token: 0x04000F64 RID: 3940
		private static readonly IntPtr NativeMethodInfoPtr_get_wwxy_Public_get_double4_0;

		// Token: 0x04000F65 RID: 3941
		private static readonly IntPtr NativeMethodInfoPtr_get_wwxz_Public_get_double4_0;

		// Token: 0x04000F66 RID: 3942
		private static readonly IntPtr NativeMethodInfoPtr_get_wwxw_Public_get_double4_0;

		// Token: 0x04000F67 RID: 3943
		private static readonly IntPtr NativeMethodInfoPtr_get_wwyx_Public_get_double4_0;

		// Token: 0x04000F68 RID: 3944
		private static readonly IntPtr NativeMethodInfoPtr_get_wwyy_Public_get_double4_0;

		// Token: 0x04000F69 RID: 3945
		private static readonly IntPtr NativeMethodInfoPtr_get_wwyz_Public_get_double4_0;

		// Token: 0x04000F6A RID: 3946
		private static readonly IntPtr NativeMethodInfoPtr_get_wwyw_Public_get_double4_0;

		// Token: 0x04000F6B RID: 3947
		private static readonly IntPtr NativeMethodInfoPtr_get_wwzx_Public_get_double4_0;

		// Token: 0x04000F6C RID: 3948
		private static readonly IntPtr NativeMethodInfoPtr_get_wwzy_Public_get_double4_0;

		// Token: 0x04000F6D RID: 3949
		private static readonly IntPtr NativeMethodInfoPtr_get_wwzz_Public_get_double4_0;

		// Token: 0x04000F6E RID: 3950
		private static readonly IntPtr NativeMethodInfoPtr_get_wwzw_Public_get_double4_0;

		// Token: 0x04000F6F RID: 3951
		private static readonly IntPtr NativeMethodInfoPtr_get_wwwx_Public_get_double4_0;

		// Token: 0x04000F70 RID: 3952
		private static readonly IntPtr NativeMethodInfoPtr_get_wwwy_Public_get_double4_0;

		// Token: 0x04000F71 RID: 3953
		private static readonly IntPtr NativeMethodInfoPtr_get_wwwz_Public_get_double4_0;

		// Token: 0x04000F72 RID: 3954
		private static readonly IntPtr NativeMethodInfoPtr_get_wwww_Public_get_double4_0;

		// Token: 0x04000F73 RID: 3955
		private static readonly IntPtr NativeMethodInfoPtr_get_xxx_Public_get_double3_0;

		// Token: 0x04000F74 RID: 3956
		private static readonly IntPtr NativeMethodInfoPtr_get_xxy_Public_get_double3_0;

		// Token: 0x04000F75 RID: 3957
		private static readonly IntPtr NativeMethodInfoPtr_get_xxz_Public_get_double3_0;

		// Token: 0x04000F76 RID: 3958
		private static readonly IntPtr NativeMethodInfoPtr_get_xxw_Public_get_double3_0;

		// Token: 0x04000F77 RID: 3959
		private static readonly IntPtr NativeMethodInfoPtr_get_xyx_Public_get_double3_0;

		// Token: 0x04000F78 RID: 3960
		private static readonly IntPtr NativeMethodInfoPtr_get_xyy_Public_get_double3_0;

		// Token: 0x04000F79 RID: 3961
		private static readonly IntPtr NativeMethodInfoPtr_get_xyz_Public_get_double3_0;

		// Token: 0x04000F7A RID: 3962
		private static readonly IntPtr NativeMethodInfoPtr_set_xyz_Public_set_Void_double3_0;

		// Token: 0x04000F7B RID: 3963
		private static readonly IntPtr NativeMethodInfoPtr_get_xyw_Public_get_double3_0;

		// Token: 0x04000F7C RID: 3964
		private static readonly IntPtr NativeMethodInfoPtr_set_xyw_Public_set_Void_double3_0;

		// Token: 0x04000F7D RID: 3965
		private static readonly IntPtr NativeMethodInfoPtr_get_xzx_Public_get_double3_0;

		// Token: 0x04000F7E RID: 3966
		private static readonly IntPtr NativeMethodInfoPtr_get_xzy_Public_get_double3_0;

		// Token: 0x04000F7F RID: 3967
		private static readonly IntPtr NativeMethodInfoPtr_set_xzy_Public_set_Void_double3_0;

		// Token: 0x04000F80 RID: 3968
		private static readonly IntPtr NativeMethodInfoPtr_get_xzz_Public_get_double3_0;

		// Token: 0x04000F81 RID: 3969
		private static readonly IntPtr NativeMethodInfoPtr_get_xzw_Public_get_double3_0;

		// Token: 0x04000F82 RID: 3970
		private static readonly IntPtr NativeMethodInfoPtr_set_xzw_Public_set_Void_double3_0;

		// Token: 0x04000F83 RID: 3971
		private static readonly IntPtr NativeMethodInfoPtr_get_xwx_Public_get_double3_0;

		// Token: 0x04000F84 RID: 3972
		private static readonly IntPtr NativeMethodInfoPtr_get_xwy_Public_get_double3_0;

		// Token: 0x04000F85 RID: 3973
		private static readonly IntPtr NativeMethodInfoPtr_set_xwy_Public_set_Void_double3_0;

		// Token: 0x04000F86 RID: 3974
		private static readonly IntPtr NativeMethodInfoPtr_get_xwz_Public_get_double3_0;

		// Token: 0x04000F87 RID: 3975
		private static readonly IntPtr NativeMethodInfoPtr_set_xwz_Public_set_Void_double3_0;

		// Token: 0x04000F88 RID: 3976
		private static readonly IntPtr NativeMethodInfoPtr_get_xww_Public_get_double3_0;

		// Token: 0x04000F89 RID: 3977
		private static readonly IntPtr NativeMethodInfoPtr_get_yxx_Public_get_double3_0;

		// Token: 0x04000F8A RID: 3978
		private static readonly IntPtr NativeMethodInfoPtr_get_yxy_Public_get_double3_0;

		// Token: 0x04000F8B RID: 3979
		private static readonly IntPtr NativeMethodInfoPtr_get_yxz_Public_get_double3_0;

		// Token: 0x04000F8C RID: 3980
		private static readonly IntPtr NativeMethodInfoPtr_set_yxz_Public_set_Void_double3_0;

		// Token: 0x04000F8D RID: 3981
		private static readonly IntPtr NativeMethodInfoPtr_get_yxw_Public_get_double3_0;

		// Token: 0x04000F8E RID: 3982
		private static readonly IntPtr NativeMethodInfoPtr_set_yxw_Public_set_Void_double3_0;

		// Token: 0x04000F8F RID: 3983
		private static readonly IntPtr NativeMethodInfoPtr_get_yyx_Public_get_double3_0;

		// Token: 0x04000F90 RID: 3984
		private static readonly IntPtr NativeMethodInfoPtr_get_yyy_Public_get_double3_0;

		// Token: 0x04000F91 RID: 3985
		private static readonly IntPtr NativeMethodInfoPtr_get_yyz_Public_get_double3_0;

		// Token: 0x04000F92 RID: 3986
		private static readonly IntPtr NativeMethodInfoPtr_get_yyw_Public_get_double3_0;

		// Token: 0x04000F93 RID: 3987
		private static readonly IntPtr NativeMethodInfoPtr_get_yzx_Public_get_double3_0;

		// Token: 0x04000F94 RID: 3988
		private static readonly IntPtr NativeMethodInfoPtr_set_yzx_Public_set_Void_double3_0;

		// Token: 0x04000F95 RID: 3989
		private static readonly IntPtr NativeMethodInfoPtr_get_yzy_Public_get_double3_0;

		// Token: 0x04000F96 RID: 3990
		private static readonly IntPtr NativeMethodInfoPtr_get_yzz_Public_get_double3_0;

		// Token: 0x04000F97 RID: 3991
		private static readonly IntPtr NativeMethodInfoPtr_get_yzw_Public_get_double3_0;

		// Token: 0x04000F98 RID: 3992
		private static readonly IntPtr NativeMethodInfoPtr_set_yzw_Public_set_Void_double3_0;

		// Token: 0x04000F99 RID: 3993
		private static readonly IntPtr NativeMethodInfoPtr_get_ywx_Public_get_double3_0;

		// Token: 0x04000F9A RID: 3994
		private static readonly IntPtr NativeMethodInfoPtr_set_ywx_Public_set_Void_double3_0;

		// Token: 0x04000F9B RID: 3995
		private static readonly IntPtr NativeMethodInfoPtr_get_ywy_Public_get_double3_0;

		// Token: 0x04000F9C RID: 3996
		private static readonly IntPtr NativeMethodInfoPtr_get_ywz_Public_get_double3_0;

		// Token: 0x04000F9D RID: 3997
		private static readonly IntPtr NativeMethodInfoPtr_set_ywz_Public_set_Void_double3_0;

		// Token: 0x04000F9E RID: 3998
		private static readonly IntPtr NativeMethodInfoPtr_get_yww_Public_get_double3_0;

		// Token: 0x04000F9F RID: 3999
		private static readonly IntPtr NativeMethodInfoPtr_get_zxx_Public_get_double3_0;

		// Token: 0x04000FA0 RID: 4000
		private static readonly IntPtr NativeMethodInfoPtr_get_zxy_Public_get_double3_0;

		// Token: 0x04000FA1 RID: 4001
		private static readonly IntPtr NativeMethodInfoPtr_set_zxy_Public_set_Void_double3_0;

		// Token: 0x04000FA2 RID: 4002
		private static readonly IntPtr NativeMethodInfoPtr_get_zxz_Public_get_double3_0;

		// Token: 0x04000FA3 RID: 4003
		private static readonly IntPtr NativeMethodInfoPtr_get_zxw_Public_get_double3_0;

		// Token: 0x04000FA4 RID: 4004
		private static readonly IntPtr NativeMethodInfoPtr_set_zxw_Public_set_Void_double3_0;

		// Token: 0x04000FA5 RID: 4005
		private static readonly IntPtr NativeMethodInfoPtr_get_zyx_Public_get_double3_0;

		// Token: 0x04000FA6 RID: 4006
		private static readonly IntPtr NativeMethodInfoPtr_set_zyx_Public_set_Void_double3_0;

		// Token: 0x04000FA7 RID: 4007
		private static readonly IntPtr NativeMethodInfoPtr_get_zyy_Public_get_double3_0;

		// Token: 0x04000FA8 RID: 4008
		private static readonly IntPtr NativeMethodInfoPtr_get_zyz_Public_get_double3_0;

		// Token: 0x04000FA9 RID: 4009
		private static readonly IntPtr NativeMethodInfoPtr_get_zyw_Public_get_double3_0;

		// Token: 0x04000FAA RID: 4010
		private static readonly IntPtr NativeMethodInfoPtr_set_zyw_Public_set_Void_double3_0;

		// Token: 0x04000FAB RID: 4011
		private static readonly IntPtr NativeMethodInfoPtr_get_zzx_Public_get_double3_0;

		// Token: 0x04000FAC RID: 4012
		private static readonly IntPtr NativeMethodInfoPtr_get_zzy_Public_get_double3_0;

		// Token: 0x04000FAD RID: 4013
		private static readonly IntPtr NativeMethodInfoPtr_get_zzz_Public_get_double3_0;

		// Token: 0x04000FAE RID: 4014
		private static readonly IntPtr NativeMethodInfoPtr_get_zzw_Public_get_double3_0;

		// Token: 0x04000FAF RID: 4015
		private static readonly IntPtr NativeMethodInfoPtr_get_zwx_Public_get_double3_0;

		// Token: 0x04000FB0 RID: 4016
		private static readonly IntPtr NativeMethodInfoPtr_set_zwx_Public_set_Void_double3_0;

		// Token: 0x04000FB1 RID: 4017
		private static readonly IntPtr NativeMethodInfoPtr_get_zwy_Public_get_double3_0;

		// Token: 0x04000FB2 RID: 4018
		private static readonly IntPtr NativeMethodInfoPtr_set_zwy_Public_set_Void_double3_0;

		// Token: 0x04000FB3 RID: 4019
		private static readonly IntPtr NativeMethodInfoPtr_get_zwz_Public_get_double3_0;

		// Token: 0x04000FB4 RID: 4020
		private static readonly IntPtr NativeMethodInfoPtr_get_zww_Public_get_double3_0;

		// Token: 0x04000FB5 RID: 4021
		private static readonly IntPtr NativeMethodInfoPtr_get_wxx_Public_get_double3_0;

		// Token: 0x04000FB6 RID: 4022
		private static readonly IntPtr NativeMethodInfoPtr_get_wxy_Public_get_double3_0;

		// Token: 0x04000FB7 RID: 4023
		private static readonly IntPtr NativeMethodInfoPtr_set_wxy_Public_set_Void_double3_0;

		// Token: 0x04000FB8 RID: 4024
		private static readonly IntPtr NativeMethodInfoPtr_get_wxz_Public_get_double3_0;

		// Token: 0x04000FB9 RID: 4025
		private static readonly IntPtr NativeMethodInfoPtr_set_wxz_Public_set_Void_double3_0;

		// Token: 0x04000FBA RID: 4026
		private static readonly IntPtr NativeMethodInfoPtr_get_wxw_Public_get_double3_0;

		// Token: 0x04000FBB RID: 4027
		private static readonly IntPtr NativeMethodInfoPtr_get_wyx_Public_get_double3_0;

		// Token: 0x04000FBC RID: 4028
		private static readonly IntPtr NativeMethodInfoPtr_set_wyx_Public_set_Void_double3_0;

		// Token: 0x04000FBD RID: 4029
		private static readonly IntPtr NativeMethodInfoPtr_get_wyy_Public_get_double3_0;

		// Token: 0x04000FBE RID: 4030
		private static readonly IntPtr NativeMethodInfoPtr_get_wyz_Public_get_double3_0;

		// Token: 0x04000FBF RID: 4031
		private static readonly IntPtr NativeMethodInfoPtr_set_wyz_Public_set_Void_double3_0;

		// Token: 0x04000FC0 RID: 4032
		private static readonly IntPtr NativeMethodInfoPtr_get_wyw_Public_get_double3_0;

		// Token: 0x04000FC1 RID: 4033
		private static readonly IntPtr NativeMethodInfoPtr_get_wzx_Public_get_double3_0;

		// Token: 0x04000FC2 RID: 4034
		private static readonly IntPtr NativeMethodInfoPtr_set_wzx_Public_set_Void_double3_0;

		// Token: 0x04000FC3 RID: 4035
		private static readonly IntPtr NativeMethodInfoPtr_get_wzy_Public_get_double3_0;

		// Token: 0x04000FC4 RID: 4036
		private static readonly IntPtr NativeMethodInfoPtr_set_wzy_Public_set_Void_double3_0;

		// Token: 0x04000FC5 RID: 4037
		private static readonly IntPtr NativeMethodInfoPtr_get_wzz_Public_get_double3_0;

		// Token: 0x04000FC6 RID: 4038
		private static readonly IntPtr NativeMethodInfoPtr_get_wzw_Public_get_double3_0;

		// Token: 0x04000FC7 RID: 4039
		private static readonly IntPtr NativeMethodInfoPtr_get_wwx_Public_get_double3_0;

		// Token: 0x04000FC8 RID: 4040
		private static readonly IntPtr NativeMethodInfoPtr_get_wwy_Public_get_double3_0;

		// Token: 0x04000FC9 RID: 4041
		private static readonly IntPtr NativeMethodInfoPtr_get_wwz_Public_get_double3_0;

		// Token: 0x04000FCA RID: 4042
		private static readonly IntPtr NativeMethodInfoPtr_get_www_Public_get_double3_0;

		// Token: 0x04000FCB RID: 4043
		private static readonly IntPtr NativeMethodInfoPtr_get_xx_Public_get_double2_0;

		// Token: 0x04000FCC RID: 4044
		private static readonly IntPtr NativeMethodInfoPtr_get_xy_Public_get_double2_0;

		// Token: 0x04000FCD RID: 4045
		private static readonly IntPtr NativeMethodInfoPtr_set_xy_Public_set_Void_double2_0;

		// Token: 0x04000FCE RID: 4046
		private static readonly IntPtr NativeMethodInfoPtr_get_xz_Public_get_double2_0;

		// Token: 0x04000FCF RID: 4047
		private static readonly IntPtr NativeMethodInfoPtr_set_xz_Public_set_Void_double2_0;

		// Token: 0x04000FD0 RID: 4048
		private static readonly IntPtr NativeMethodInfoPtr_get_xw_Public_get_double2_0;

		// Token: 0x04000FD1 RID: 4049
		private static readonly IntPtr NativeMethodInfoPtr_set_xw_Public_set_Void_double2_0;

		// Token: 0x04000FD2 RID: 4050
		private static readonly IntPtr NativeMethodInfoPtr_get_yx_Public_get_double2_0;

		// Token: 0x04000FD3 RID: 4051
		private static readonly IntPtr NativeMethodInfoPtr_set_yx_Public_set_Void_double2_0;

		// Token: 0x04000FD4 RID: 4052
		private static readonly IntPtr NativeMethodInfoPtr_get_yy_Public_get_double2_0;

		// Token: 0x04000FD5 RID: 4053
		private static readonly IntPtr NativeMethodInfoPtr_get_yz_Public_get_double2_0;

		// Token: 0x04000FD6 RID: 4054
		private static readonly IntPtr NativeMethodInfoPtr_set_yz_Public_set_Void_double2_0;

		// Token: 0x04000FD7 RID: 4055
		private static readonly IntPtr NativeMethodInfoPtr_get_yw_Public_get_double2_0;

		// Token: 0x04000FD8 RID: 4056
		private static readonly IntPtr NativeMethodInfoPtr_set_yw_Public_set_Void_double2_0;

		// Token: 0x04000FD9 RID: 4057
		private static readonly IntPtr NativeMethodInfoPtr_get_zx_Public_get_double2_0;

		// Token: 0x04000FDA RID: 4058
		private static readonly IntPtr NativeMethodInfoPtr_set_zx_Public_set_Void_double2_0;

		// Token: 0x04000FDB RID: 4059
		private static readonly IntPtr NativeMethodInfoPtr_get_zy_Public_get_double2_0;

		// Token: 0x04000FDC RID: 4060
		private static readonly IntPtr NativeMethodInfoPtr_set_zy_Public_set_Void_double2_0;

		// Token: 0x04000FDD RID: 4061
		private static readonly IntPtr NativeMethodInfoPtr_get_zz_Public_get_double2_0;

		// Token: 0x04000FDE RID: 4062
		private static readonly IntPtr NativeMethodInfoPtr_get_zw_Public_get_double2_0;

		// Token: 0x04000FDF RID: 4063
		private static readonly IntPtr NativeMethodInfoPtr_set_zw_Public_set_Void_double2_0;

		// Token: 0x04000FE0 RID: 4064
		private static readonly IntPtr NativeMethodInfoPtr_get_wx_Public_get_double2_0;

		// Token: 0x04000FE1 RID: 4065
		private static readonly IntPtr NativeMethodInfoPtr_set_wx_Public_set_Void_double2_0;

		// Token: 0x04000FE2 RID: 4066
		private static readonly IntPtr NativeMethodInfoPtr_get_wy_Public_get_double2_0;

		// Token: 0x04000FE3 RID: 4067
		private static readonly IntPtr NativeMethodInfoPtr_set_wy_Public_set_Void_double2_0;

		// Token: 0x04000FE4 RID: 4068
		private static readonly IntPtr NativeMethodInfoPtr_get_wz_Public_get_double2_0;

		// Token: 0x04000FE5 RID: 4069
		private static readonly IntPtr NativeMethodInfoPtr_set_wz_Public_set_Void_double2_0;

		// Token: 0x04000FE6 RID: 4070
		private static readonly IntPtr NativeMethodInfoPtr_get_ww_Public_get_double2_0;

		// Token: 0x04000FE7 RID: 4071
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Double_Int32_0;

		// Token: 0x04000FE8 RID: 4072
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Double_0;

		// Token: 0x04000FE9 RID: 4073
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_double4_0;

		// Token: 0x04000FEA RID: 4074
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000FEB RID: 4075
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000FEC RID: 4076
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000FED RID: 4077
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04000FEE RID: 4078
		[FieldOffset(0)]
		public double x;

		// Token: 0x04000FEF RID: 4079
		[FieldOffset(8)]
		public double y;

		// Token: 0x04000FF0 RID: 4080
		[FieldOffset(16)]
		public double z;

		// Token: 0x04000FF1 RID: 4081
		[FieldOffset(24)]
		public double w;

		// Token: 0x02000059 RID: 89
		public sealed class DebuggerProxy : Object
		{
			// Token: 0x060025E4 RID: 9700 RVA: 0x000C334C File Offset: 0x000C154C
			// Note: this type is marked as 'beforefieldinit'.
			static DebuggerProxy()
			{
				Il2CppClassPointerStore<double4.DebuggerProxy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<double4>.NativeClassPtr, "DebuggerProxy");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<double4.DebuggerProxy>.NativeClassPtr);
				double4.DebuggerProxy.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double4.DebuggerProxy>.NativeClassPtr, "x");
				double4.DebuggerProxy.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double4.DebuggerProxy>.NativeClassPtr, "y");
				double4.DebuggerProxy.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double4.DebuggerProxy>.NativeClassPtr, "z");
				double4.DebuggerProxy.NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double4.DebuggerProxy>.NativeClassPtr, "w");
				double4.DebuggerProxy.NativeMethodInfoPtr__ctor_Public_Void_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4.DebuggerProxy>.NativeClassPtr, 100667226);
			}

			// Token: 0x060025E5 RID: 9701 RVA: 0x000C33DC File Offset: 0x000C15DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635846, XrefRangeEnd = 635847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DebuggerProxy(double4 v)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<double4.DebuggerProxy>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4.DebuggerProxy.NativeMethodInfoPtr__ctor_Public_Void_double4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060025E6 RID: 9702 RVA: 0x00002D7E File Offset: 0x00000F7E
			public DebuggerProxy(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BFF RID: 3071
			// (get) Token: 0x060025E7 RID: 9703 RVA: 0x000C3424 File Offset: 0x000C1624
			// (set) Token: 0x060025E8 RID: 9704 RVA: 0x00002D87 File Offset: 0x00000F87
			public unsafe double x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(double4.DebuggerProxy.NativeFieldInfoPtr_x);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(double4.DebuggerProxy.NativeFieldInfoPtr_x)) = value;
				}
			}

			// Token: 0x17000C00 RID: 3072
			// (get) Token: 0x060025E9 RID: 9705 RVA: 0x000C344C File Offset: 0x000C164C
			// (set) Token: 0x060025EA RID: 9706 RVA: 0x00002DA2 File Offset: 0x00000FA2
			public unsafe double y
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(double4.DebuggerProxy.NativeFieldInfoPtr_y);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(double4.DebuggerProxy.NativeFieldInfoPtr_y)) = value;
				}
			}

			// Token: 0x17000C01 RID: 3073
			// (get) Token: 0x060025EB RID: 9707 RVA: 0x000C3474 File Offset: 0x000C1674
			// (set) Token: 0x060025EC RID: 9708 RVA: 0x00002DBD File Offset: 0x00000FBD
			public unsafe double z
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(double4.DebuggerProxy.NativeFieldInfoPtr_z);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(double4.DebuggerProxy.NativeFieldInfoPtr_z)) = value;
				}
			}

			// Token: 0x17000C02 RID: 3074
			// (get) Token: 0x060025ED RID: 9709 RVA: 0x000C349C File Offset: 0x000C169C
			// (set) Token: 0x060025EE RID: 9710 RVA: 0x00002DD8 File Offset: 0x00000FD8
			public unsafe double w
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(double4.DebuggerProxy.NativeFieldInfoPtr_w);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(double4.DebuggerProxy.NativeFieldInfoPtr_w)) = value;
				}
			}

			// Token: 0x0400266F RID: 9839
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04002670 RID: 9840
			private static readonly IntPtr NativeFieldInfoPtr_y;

			// Token: 0x04002671 RID: 9841
			private static readonly IntPtr NativeFieldInfoPtr_z;

			// Token: 0x04002672 RID: 9842
			private static readonly IntPtr NativeFieldInfoPtr_w;

			// Token: 0x04002673 RID: 9843
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double4_0;
		}
	}
}
