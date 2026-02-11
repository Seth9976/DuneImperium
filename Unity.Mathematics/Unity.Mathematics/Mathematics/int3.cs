using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x02000031 RID: 49
	[Serializable]
	[StructLayout(2)]
	public struct int3
	{
		// Token: 0x06001A3E RID: 6718 RVA: 0x00089D5C File Offset: 0x00087F5C
		// Note: this type is marked as 'beforefieldinit'.
		static int3()
		{
			Il2CppClassPointerStore<int3>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "int3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<int3>.NativeClassPtr);
			int3.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int3>.NativeClassPtr, "x");
			int3.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int3>.NativeClassPtr, "y");
			int3.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int3>.NativeClassPtr, "z");
			int3.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int3>.NativeClassPtr, "zero");
			int3.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669819);
			int3.NativeMethodInfoPtr__ctor_Public_Void_Int32_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669820);
			int3.NativeMethodInfoPtr__ctor_Public_Void_int2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669821);
			int3.NativeMethodInfoPtr__ctor_Public_Void_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669822);
			int3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669823);
			int3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669824);
			int3.NativeMethodInfoPtr__ctor_Public_Void_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669825);
			int3.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669826);
			int3.NativeMethodInfoPtr__ctor_Public_Void_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669827);
			int3.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669828);
			int3.NativeMethodInfoPtr__ctor_Public_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669829);
			int3.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669830);
			int3.NativeMethodInfoPtr__ctor_Public_Void_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669831);
			int3.NativeMethodInfoPtr_op_Implicit_Public_Static_int3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669832);
			int3.NativeMethodInfoPtr_op_Explicit_Public_Static_int3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669833);
			int3.NativeMethodInfoPtr_op_Explicit_Public_Static_int3_bool3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669834);
			int3.NativeMethodInfoPtr_op_Explicit_Public_Static_int3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669835);
			int3.NativeMethodInfoPtr_op_Explicit_Public_Static_int3_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669836);
			int3.NativeMethodInfoPtr_op_Explicit_Public_Static_int3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669837);
			int3.NativeMethodInfoPtr_op_Explicit_Public_Static_int3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669838);
			int3.NativeMethodInfoPtr_op_Explicit_Public_Static_int3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669839);
			int3.NativeMethodInfoPtr_op_Explicit_Public_Static_int3_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669840);
			int3.NativeMethodInfoPtr_op_Multiply_Public_Static_int3_int3_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669841);
			int3.NativeMethodInfoPtr_op_Multiply_Public_Static_int3_int3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669842);
			int3.NativeMethodInfoPtr_op_Multiply_Public_Static_int3_Int32_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669843);
			int3.NativeMethodInfoPtr_op_Addition_Public_Static_int3_int3_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669844);
			int3.NativeMethodInfoPtr_op_Addition_Public_Static_int3_int3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669845);
			int3.NativeMethodInfoPtr_op_Addition_Public_Static_int3_Int32_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669846);
			int3.NativeMethodInfoPtr_op_Subtraction_Public_Static_int3_int3_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669847);
			int3.NativeMethodInfoPtr_op_Subtraction_Public_Static_int3_int3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669848);
			int3.NativeMethodInfoPtr_op_Subtraction_Public_Static_int3_Int32_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669849);
			int3.NativeMethodInfoPtr_op_Division_Public_Static_int3_int3_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669850);
			int3.NativeMethodInfoPtr_op_Division_Public_Static_int3_int3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669851);
			int3.NativeMethodInfoPtr_op_Division_Public_Static_int3_Int32_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669852);
			int3.NativeMethodInfoPtr_op_Modulus_Public_Static_int3_int3_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669853);
			int3.NativeMethodInfoPtr_op_Modulus_Public_Static_int3_int3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669854);
			int3.NativeMethodInfoPtr_op_Modulus_Public_Static_int3_Int32_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669855);
			int3.NativeMethodInfoPtr_op_Increment_Public_Static_int3_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669856);
			int3.NativeMethodInfoPtr_op_Decrement_Public_Static_int3_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669857);
			int3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3_int3_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669858);
			int3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3_int3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669859);
			int3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3_Int32_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669860);
			int3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3_int3_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669861);
			int3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3_int3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669862);
			int3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3_Int32_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669863);
			int3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3_int3_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669864);
			int3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3_int3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669865);
			int3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3_Int32_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669866);
			int3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3_int3_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669867);
			int3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3_int3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669868);
			int3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3_Int32_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669869);
			int3.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_int3_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669870);
			int3.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_int3_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669871);
			int3.NativeMethodInfoPtr_op_LeftShift_Public_Static_int3_int3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669872);
			int3.NativeMethodInfoPtr_op_RightShift_Public_Static_int3_int3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669873);
			int3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3_int3_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669874);
			int3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3_int3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669875);
			int3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3_Int32_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669876);
			int3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_int3_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669877);
			int3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_int3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669878);
			int3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_Int32_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669879);
			int3.NativeMethodInfoPtr_op_OnesComplement_Public_Static_int3_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669880);
			int3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int3_int3_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669881);
			int3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int3_int3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669882);
			int3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int3_Int32_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669883);
			int3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int3_int3_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669884);
			int3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int3_int3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669885);
			int3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int3_Int32_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669886);
			int3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int3_int3_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669887);
			int3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int3_int3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669888);
			int3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int3_Int32_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669889);
			int3.NativeMethodInfoPtr_get_xxxx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669890);
			int3.NativeMethodInfoPtr_get_xxxy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669891);
			int3.NativeMethodInfoPtr_get_xxxz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669892);
			int3.NativeMethodInfoPtr_get_xxyx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669893);
			int3.NativeMethodInfoPtr_get_xxyy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669894);
			int3.NativeMethodInfoPtr_get_xxyz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669895);
			int3.NativeMethodInfoPtr_get_xxzx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669896);
			int3.NativeMethodInfoPtr_get_xxzy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669897);
			int3.NativeMethodInfoPtr_get_xxzz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669898);
			int3.NativeMethodInfoPtr_get_xyxx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669899);
			int3.NativeMethodInfoPtr_get_xyxy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669900);
			int3.NativeMethodInfoPtr_get_xyxz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669901);
			int3.NativeMethodInfoPtr_get_xyyx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669902);
			int3.NativeMethodInfoPtr_get_xyyy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669903);
			int3.NativeMethodInfoPtr_get_xyyz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669904);
			int3.NativeMethodInfoPtr_get_xyzx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669905);
			int3.NativeMethodInfoPtr_get_xyzy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669906);
			int3.NativeMethodInfoPtr_get_xyzz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669907);
			int3.NativeMethodInfoPtr_get_xzxx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669908);
			int3.NativeMethodInfoPtr_get_xzxy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669909);
			int3.NativeMethodInfoPtr_get_xzxz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669910);
			int3.NativeMethodInfoPtr_get_xzyx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669911);
			int3.NativeMethodInfoPtr_get_xzyy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669912);
			int3.NativeMethodInfoPtr_get_xzyz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669913);
			int3.NativeMethodInfoPtr_get_xzzx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669914);
			int3.NativeMethodInfoPtr_get_xzzy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669915);
			int3.NativeMethodInfoPtr_get_xzzz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669916);
			int3.NativeMethodInfoPtr_get_yxxx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669917);
			int3.NativeMethodInfoPtr_get_yxxy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669918);
			int3.NativeMethodInfoPtr_get_yxxz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669919);
			int3.NativeMethodInfoPtr_get_yxyx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669920);
			int3.NativeMethodInfoPtr_get_yxyy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669921);
			int3.NativeMethodInfoPtr_get_yxyz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669922);
			int3.NativeMethodInfoPtr_get_yxzx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669923);
			int3.NativeMethodInfoPtr_get_yxzy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669924);
			int3.NativeMethodInfoPtr_get_yxzz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669925);
			int3.NativeMethodInfoPtr_get_yyxx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669926);
			int3.NativeMethodInfoPtr_get_yyxy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669927);
			int3.NativeMethodInfoPtr_get_yyxz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669928);
			int3.NativeMethodInfoPtr_get_yyyx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669929);
			int3.NativeMethodInfoPtr_get_yyyy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669930);
			int3.NativeMethodInfoPtr_get_yyyz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669931);
			int3.NativeMethodInfoPtr_get_yyzx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669932);
			int3.NativeMethodInfoPtr_get_yyzy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669933);
			int3.NativeMethodInfoPtr_get_yyzz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669934);
			int3.NativeMethodInfoPtr_get_yzxx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669935);
			int3.NativeMethodInfoPtr_get_yzxy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669936);
			int3.NativeMethodInfoPtr_get_yzxz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669937);
			int3.NativeMethodInfoPtr_get_yzyx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669938);
			int3.NativeMethodInfoPtr_get_yzyy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669939);
			int3.NativeMethodInfoPtr_get_yzyz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669940);
			int3.NativeMethodInfoPtr_get_yzzx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669941);
			int3.NativeMethodInfoPtr_get_yzzy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669942);
			int3.NativeMethodInfoPtr_get_yzzz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669943);
			int3.NativeMethodInfoPtr_get_zxxx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669944);
			int3.NativeMethodInfoPtr_get_zxxy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669945);
			int3.NativeMethodInfoPtr_get_zxxz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669946);
			int3.NativeMethodInfoPtr_get_zxyx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669947);
			int3.NativeMethodInfoPtr_get_zxyy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669948);
			int3.NativeMethodInfoPtr_get_zxyz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669949);
			int3.NativeMethodInfoPtr_get_zxzx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669950);
			int3.NativeMethodInfoPtr_get_zxzy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669951);
			int3.NativeMethodInfoPtr_get_zxzz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669952);
			int3.NativeMethodInfoPtr_get_zyxx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669953);
			int3.NativeMethodInfoPtr_get_zyxy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669954);
			int3.NativeMethodInfoPtr_get_zyxz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669955);
			int3.NativeMethodInfoPtr_get_zyyx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669956);
			int3.NativeMethodInfoPtr_get_zyyy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669957);
			int3.NativeMethodInfoPtr_get_zyyz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669958);
			int3.NativeMethodInfoPtr_get_zyzx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669959);
			int3.NativeMethodInfoPtr_get_zyzy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669960);
			int3.NativeMethodInfoPtr_get_zyzz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669961);
			int3.NativeMethodInfoPtr_get_zzxx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669962);
			int3.NativeMethodInfoPtr_get_zzxy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669963);
			int3.NativeMethodInfoPtr_get_zzxz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669964);
			int3.NativeMethodInfoPtr_get_zzyx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669965);
			int3.NativeMethodInfoPtr_get_zzyy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669966);
			int3.NativeMethodInfoPtr_get_zzyz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669967);
			int3.NativeMethodInfoPtr_get_zzzx_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669968);
			int3.NativeMethodInfoPtr_get_zzzy_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669969);
			int3.NativeMethodInfoPtr_get_zzzz_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669970);
			int3.NativeMethodInfoPtr_get_xxx_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669971);
			int3.NativeMethodInfoPtr_get_xxy_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669972);
			int3.NativeMethodInfoPtr_get_xxz_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669973);
			int3.NativeMethodInfoPtr_get_xyx_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669974);
			int3.NativeMethodInfoPtr_get_xyy_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669975);
			int3.NativeMethodInfoPtr_get_xyz_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669976);
			int3.NativeMethodInfoPtr_set_xyz_Public_set_Void_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669977);
			int3.NativeMethodInfoPtr_get_xzx_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669978);
			int3.NativeMethodInfoPtr_get_xzy_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669979);
			int3.NativeMethodInfoPtr_set_xzy_Public_set_Void_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669980);
			int3.NativeMethodInfoPtr_get_xzz_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669981);
			int3.NativeMethodInfoPtr_get_yxx_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669982);
			int3.NativeMethodInfoPtr_get_yxy_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669983);
			int3.NativeMethodInfoPtr_get_yxz_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669984);
			int3.NativeMethodInfoPtr_set_yxz_Public_set_Void_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669985);
			int3.NativeMethodInfoPtr_get_yyx_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669986);
			int3.NativeMethodInfoPtr_get_yyy_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669987);
			int3.NativeMethodInfoPtr_get_yyz_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669988);
			int3.NativeMethodInfoPtr_get_yzx_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669989);
			int3.NativeMethodInfoPtr_set_yzx_Public_set_Void_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669990);
			int3.NativeMethodInfoPtr_get_yzy_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669991);
			int3.NativeMethodInfoPtr_get_yzz_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669992);
			int3.NativeMethodInfoPtr_get_zxx_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669993);
			int3.NativeMethodInfoPtr_get_zxy_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669994);
			int3.NativeMethodInfoPtr_set_zxy_Public_set_Void_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669995);
			int3.NativeMethodInfoPtr_get_zxz_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669996);
			int3.NativeMethodInfoPtr_get_zyx_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669997);
			int3.NativeMethodInfoPtr_set_zyx_Public_set_Void_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669998);
			int3.NativeMethodInfoPtr_get_zyy_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100669999);
			int3.NativeMethodInfoPtr_get_zyz_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100670000);
			int3.NativeMethodInfoPtr_get_zzx_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100670001);
			int3.NativeMethodInfoPtr_get_zzy_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100670002);
			int3.NativeMethodInfoPtr_get_zzz_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100670003);
			int3.NativeMethodInfoPtr_get_xx_Public_get_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100670004);
			int3.NativeMethodInfoPtr_get_xy_Public_get_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100670005);
			int3.NativeMethodInfoPtr_set_xy_Public_set_Void_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100670006);
			int3.NativeMethodInfoPtr_get_xz_Public_get_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100670007);
			int3.NativeMethodInfoPtr_set_xz_Public_set_Void_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100670008);
			int3.NativeMethodInfoPtr_get_yx_Public_get_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100670009);
			int3.NativeMethodInfoPtr_set_yx_Public_set_Void_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100670010);
			int3.NativeMethodInfoPtr_get_yy_Public_get_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100670011);
			int3.NativeMethodInfoPtr_get_yz_Public_get_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100670012);
			int3.NativeMethodInfoPtr_set_yz_Public_set_Void_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100670013);
			int3.NativeMethodInfoPtr_get_zx_Public_get_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100670014);
			int3.NativeMethodInfoPtr_set_zx_Public_set_Void_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100670015);
			int3.NativeMethodInfoPtr_get_zy_Public_get_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100670016);
			int3.NativeMethodInfoPtr_set_zy_Public_set_Void_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100670017);
			int3.NativeMethodInfoPtr_get_zz_Public_get_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100670018);
			int3.NativeMethodInfoPtr_get_Item_Public_get_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100670019);
			int3.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100670020);
			int3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100670021);
			int3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100670022);
			int3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100670023);
			int3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100670024);
			int3.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3>.NativeClassPtr, 100670025);
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x0008AE08 File Offset: 0x00089008
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 556229, RefRangeEnd = 556238, XrefRangeStart = 556229, XrefRangeEnd = 556238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int3(int x, int y, int z)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x0008AE58 File Offset: 0x00089058
		[CallerCount(0)]
		public unsafe int3(int x, int2 yz)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yz;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr__ctor_Public_Void_Int32_int2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x0008AE98 File Offset: 0x00089098
		[CallerCount(0)]
		public unsafe int3(int2 xy, int z)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xy;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr__ctor_Public_Void_int2_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x0008AED8 File Offset: 0x000890D8
		[CallerCount(0)]
		public unsafe int3(int3 xyz)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyz;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr__ctor_Public_Void_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A43 RID: 6723 RVA: 0x0008AF0C File Offset: 0x0008910C
		[CallerCount(0)]
		public unsafe int3(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x0008AF40 File Offset: 0x00089140
		[CallerCount(0)]
		public unsafe int3(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x0008AF74 File Offset: 0x00089174
		[CallerCount(0)]
		public unsafe int3(bool3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr__ctor_Public_Void_bool3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x0008AFA8 File Offset: 0x000891A8
		[CallerCount(0)]
		public unsafe int3(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x0008AFDC File Offset: 0x000891DC
		[CallerCount(0)]
		public unsafe int3(uint3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr__ctor_Public_Void_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x0008B010 File Offset: 0x00089210
		[CallerCount(0)]
		public unsafe int3(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A49 RID: 6729 RVA: 0x0008B044 File Offset: 0x00089244
		[CallerCount(0)]
		public unsafe int3(float3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr__ctor_Public_Void_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x0008B078 File Offset: 0x00089278
		[CallerCount(0)]
		public unsafe int3(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x0008B0AC File Offset: 0x000892AC
		[CallerCount(0)]
		public unsafe int3(double3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr__ctor_Public_Void_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A4C RID: 6732 RVA: 0x0008B0E0 File Offset: 0x000892E0
		[CallerCount(0)]
		public unsafe static implicit operator int3(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_Implicit_Public_Static_int3_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x0008B120 File Offset: 0x00089320
		[CallerCount(0)]
		public unsafe static explicit operator int3(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_Explicit_Public_Static_int3_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x0008B160 File Offset: 0x00089360
		[CallerCount(0)]
		public unsafe static explicit operator int3(bool3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_Explicit_Public_Static_int3_bool3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x0008B1A0 File Offset: 0x000893A0
		[CallerCount(0)]
		public unsafe static explicit operator int3(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_Explicit_Public_Static_int3_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A50 RID: 6736 RVA: 0x0008B1E0 File Offset: 0x000893E0
		[CallerCount(0)]
		public unsafe static explicit operator int3(uint3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_Explicit_Public_Static_int3_uint3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x0008B220 File Offset: 0x00089420
		[CallerCount(0)]
		public unsafe static explicit operator int3(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_Explicit_Public_Static_int3_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x0008B260 File Offset: 0x00089460
		[CallerCount(0)]
		public unsafe static explicit operator int3(float3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_Explicit_Public_Static_int3_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A53 RID: 6739 RVA: 0x0008B2A0 File Offset: 0x000894A0
		[CallerCount(0)]
		public unsafe static explicit operator int3(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_Explicit_Public_Static_int3_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x0008B2E0 File Offset: 0x000894E0
		[CallerCount(0)]
		public unsafe static explicit operator int3(double3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_Explicit_Public_Static_int3_double3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A55 RID: 6741 RVA: 0x0008B320 File Offset: 0x00089520
		[CallerCount(0)]
		public unsafe static int3 operator *(int3 lhs, int3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_Multiply_Public_Static_int3_int3_int3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A56 RID: 6742 RVA: 0x0008B36C File Offset: 0x0008956C
		[CallerCount(0)]
		public unsafe static int3 operator *(int3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_Multiply_Public_Static_int3_int3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A57 RID: 6743 RVA: 0x0008B3B8 File Offset: 0x000895B8
		[CallerCount(0)]
		public unsafe static int3 operator *(int lhs, int3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_Multiply_Public_Static_int3_Int32_int3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A58 RID: 6744 RVA: 0x0008B404 File Offset: 0x00089604
		[CallerCount(0)]
		public unsafe static int3 operator +(int3 lhs, int3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_Addition_Public_Static_int3_int3_int3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A59 RID: 6745 RVA: 0x0008B450 File Offset: 0x00089650
		[CallerCount(0)]
		public unsafe static int3 operator +(int3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_Addition_Public_Static_int3_int3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x0008B49C File Offset: 0x0008969C
		[CallerCount(0)]
		public unsafe static int3 operator +(int lhs, int3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_Addition_Public_Static_int3_Int32_int3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x0008B4E8 File Offset: 0x000896E8
		[CallerCount(0)]
		public unsafe static int3 operator -(int3 lhs, int3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_Subtraction_Public_Static_int3_int3_int3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A5C RID: 6748 RVA: 0x0008B534 File Offset: 0x00089734
		[CallerCount(0)]
		public unsafe static int3 operator -(int3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_Subtraction_Public_Static_int3_int3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x0008B580 File Offset: 0x00089780
		[CallerCount(0)]
		public unsafe static int3 operator -(int lhs, int3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_Subtraction_Public_Static_int3_Int32_int3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x0008B5CC File Offset: 0x000897CC
		[CallerCount(0)]
		public unsafe static int3 operator /(int3 lhs, int3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_Division_Public_Static_int3_int3_int3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x0008B618 File Offset: 0x00089818
		[CallerCount(0)]
		public unsafe static int3 operator /(int3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_Division_Public_Static_int3_int3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A60 RID: 6752 RVA: 0x0008B664 File Offset: 0x00089864
		[CallerCount(0)]
		public unsafe static int3 operator /(int lhs, int3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_Division_Public_Static_int3_Int32_int3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A61 RID: 6753 RVA: 0x0008B6B0 File Offset: 0x000898B0
		[CallerCount(0)]
		public unsafe static int3 operator %(int3 lhs, int3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_Modulus_Public_Static_int3_int3_int3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A62 RID: 6754 RVA: 0x0008B6FC File Offset: 0x000898FC
		[CallerCount(0)]
		public unsafe static int3 operator %(int3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_Modulus_Public_Static_int3_int3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A63 RID: 6755 RVA: 0x0008B748 File Offset: 0x00089948
		[CallerCount(0)]
		public unsafe static int3 operator %(int lhs, int3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_Modulus_Public_Static_int3_Int32_int3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A64 RID: 6756 RVA: 0x0008B794 File Offset: 0x00089994
		[CallerCount(0)]
		public unsafe static int3 operator ++(int3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_Increment_Public_Static_int3_int3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A65 RID: 6757 RVA: 0x0008B7D4 File Offset: 0x000899D4
		[CallerCount(0)]
		public unsafe static int3 operator --(int3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_Decrement_Public_Static_int3_int3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A66 RID: 6758 RVA: 0x0008B814 File Offset: 0x00089A14
		[CallerCount(0)]
		public unsafe static bool3 operator <(int3 lhs, int3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3_int3_int3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A67 RID: 6759 RVA: 0x0008B860 File Offset: 0x00089A60
		[CallerCount(0)]
		public unsafe static bool3 operator <(int3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3_int3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A68 RID: 6760 RVA: 0x0008B8AC File Offset: 0x00089AAC
		[CallerCount(0)]
		public unsafe static bool3 operator <(int lhs, int3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3_Int32_int3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A69 RID: 6761 RVA: 0x0008B8F8 File Offset: 0x00089AF8
		[CallerCount(0)]
		public unsafe static bool3 operator <=(int3 lhs, int3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3_int3_int3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A6A RID: 6762 RVA: 0x0008B944 File Offset: 0x00089B44
		[CallerCount(0)]
		public unsafe static bool3 operator <=(int3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3_int3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A6B RID: 6763 RVA: 0x0008B990 File Offset: 0x00089B90
		[CallerCount(0)]
		public unsafe static bool3 operator <=(int lhs, int3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3_Int32_int3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A6C RID: 6764 RVA: 0x0008B9DC File Offset: 0x00089BDC
		[CallerCount(0)]
		public unsafe static bool3 operator >(int3 lhs, int3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3_int3_int3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A6D RID: 6765 RVA: 0x0008BA28 File Offset: 0x00089C28
		[CallerCount(0)]
		public unsafe static bool3 operator >(int3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3_int3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A6E RID: 6766 RVA: 0x0008BA74 File Offset: 0x00089C74
		[CallerCount(0)]
		public unsafe static bool3 operator >(int lhs, int3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3_Int32_int3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A6F RID: 6767 RVA: 0x0008BAC0 File Offset: 0x00089CC0
		[CallerCount(0)]
		public unsafe static bool3 operator >=(int3 lhs, int3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3_int3_int3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A70 RID: 6768 RVA: 0x0008BB0C File Offset: 0x00089D0C
		[CallerCount(0)]
		public unsafe static bool3 operator >=(int3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3_int3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x0008BB58 File Offset: 0x00089D58
		[CallerCount(0)]
		public unsafe static bool3 operator >=(int lhs, int3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3_Int32_int3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A72 RID: 6770 RVA: 0x0008BBA4 File Offset: 0x00089DA4
		[CallerCount(0)]
		public unsafe static int3 operator -(int3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_int3_int3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A73 RID: 6771 RVA: 0x0008BBE4 File Offset: 0x00089DE4
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 637161, RefRangeEnd = 637182, XrefRangeStart = 637161, XrefRangeEnd = 637182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int3 operator +(int3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_int3_int3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x0008BC24 File Offset: 0x00089E24
		[CallerCount(0)]
		public unsafe static int3 operator <<(int3 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_LeftShift_Public_Static_int3_int3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A75 RID: 6773 RVA: 0x0008BC70 File Offset: 0x00089E70
		[CallerCount(0)]
		public unsafe static int3 operator >>(int3 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_RightShift_Public_Static_int3_int3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A76 RID: 6774 RVA: 0x0008BCBC File Offset: 0x00089EBC
		[CallerCount(0)]
		public unsafe static bool3 operator ==(int3 lhs, int3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3_int3_int3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A77 RID: 6775 RVA: 0x0008BD08 File Offset: 0x00089F08
		[CallerCount(0)]
		public unsafe static bool3 operator ==(int3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3_int3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A78 RID: 6776 RVA: 0x0008BD54 File Offset: 0x00089F54
		[CallerCount(0)]
		public unsafe static bool3 operator ==(int lhs, int3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3_Int32_int3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A79 RID: 6777 RVA: 0x0008BDA0 File Offset: 0x00089FA0
		[CallerCount(0)]
		public unsafe static bool3 operator !=(int3 lhs, int3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_int3_int3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A7A RID: 6778 RVA: 0x0008BDEC File Offset: 0x00089FEC
		[CallerCount(0)]
		public unsafe static bool3 operator !=(int3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_int3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A7B RID: 6779 RVA: 0x0008BE38 File Offset: 0x0008A038
		[CallerCount(0)]
		public unsafe static bool3 operator !=(int lhs, int3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_Int32_int3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A7C RID: 6780 RVA: 0x0008BE84 File Offset: 0x0008A084
		[CallerCount(0)]
		public unsafe static int3 operator ~(int3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_OnesComplement_Public_Static_int3_int3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A7D RID: 6781 RVA: 0x0008BEC4 File Offset: 0x0008A0C4
		[CallerCount(0)]
		public unsafe static int3 operator &(int3 lhs, int3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int3_int3_int3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A7E RID: 6782 RVA: 0x0008BF10 File Offset: 0x0008A110
		[CallerCount(0)]
		public unsafe static int3 operator &(int3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int3_int3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A7F RID: 6783 RVA: 0x0008BF5C File Offset: 0x0008A15C
		[CallerCount(0)]
		public unsafe static int3 operator &(int lhs, int3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int3_Int32_int3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A80 RID: 6784 RVA: 0x0008BFA8 File Offset: 0x0008A1A8
		[CallerCount(0)]
		public unsafe static int3 operator |(int3 lhs, int3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int3_int3_int3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x0008BFF4 File Offset: 0x0008A1F4
		[CallerCount(0)]
		public unsafe static int3 operator |(int3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int3_int3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x0008C040 File Offset: 0x0008A240
		[CallerCount(0)]
		public unsafe static int3 operator |(int lhs, int3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int3_Int32_int3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x0008C08C File Offset: 0x0008A28C
		[CallerCount(0)]
		public unsafe static int3 operator ^(int3 lhs, int3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int3_int3_int3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A84 RID: 6788 RVA: 0x0008C0D8 File Offset: 0x0008A2D8
		[CallerCount(0)]
		public unsafe static int3 operator ^(int3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int3_int3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A85 RID: 6789 RVA: 0x0008C124 File Offset: 0x0008A324
		[CallerCount(0)]
		public unsafe static int3 operator ^(int lhs, int3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int3_Int32_int3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x06001A86 RID: 6790 RVA: 0x0008C170 File Offset: 0x0008A370
		public unsafe int4 xxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_xxxx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x06001A87 RID: 6791 RVA: 0x0008C1A0 File Offset: 0x0008A3A0
		public unsafe int4 xxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_xxxy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x06001A88 RID: 6792 RVA: 0x0008C1D0 File Offset: 0x0008A3D0
		public unsafe int4 xxxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_xxxz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x06001A89 RID: 6793 RVA: 0x0008C200 File Offset: 0x0008A400
		public unsafe int4 xxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_xxyx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x06001A8A RID: 6794 RVA: 0x0008C230 File Offset: 0x0008A430
		public unsafe int4 xxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_xxyy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x06001A8B RID: 6795 RVA: 0x0008C260 File Offset: 0x0008A460
		public unsafe int4 xxyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_xxyz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x06001A8C RID: 6796 RVA: 0x0008C290 File Offset: 0x0008A490
		public unsafe int4 xxzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_xxzx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x06001A8D RID: 6797 RVA: 0x0008C2C0 File Offset: 0x0008A4C0
		public unsafe int4 xxzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_xxzy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x06001A8E RID: 6798 RVA: 0x0008C2F0 File Offset: 0x0008A4F0
		public unsafe int4 xxzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_xxzz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x06001A8F RID: 6799 RVA: 0x0008C320 File Offset: 0x0008A520
		public unsafe int4 xyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_xyxx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x06001A90 RID: 6800 RVA: 0x0008C350 File Offset: 0x0008A550
		public unsafe int4 xyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_xyxy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x06001A91 RID: 6801 RVA: 0x0008C380 File Offset: 0x0008A580
		public unsafe int4 xyxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_xyxz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x06001A92 RID: 6802 RVA: 0x0008C3B0 File Offset: 0x0008A5B0
		public unsafe int4 xyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_xyyx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x06001A93 RID: 6803 RVA: 0x0008C3E0 File Offset: 0x0008A5E0
		public unsafe int4 xyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_xyyy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x06001A94 RID: 6804 RVA: 0x0008C410 File Offset: 0x0008A610
		public unsafe int4 xyyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_xyyz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x06001A95 RID: 6805 RVA: 0x0008C440 File Offset: 0x0008A640
		public unsafe int4 xyzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_xyzx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06001A96 RID: 6806 RVA: 0x0008C470 File Offset: 0x0008A670
		public unsafe int4 xyzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_xyzy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x06001A97 RID: 6807 RVA: 0x0008C4A0 File Offset: 0x0008A6A0
		public unsafe int4 xyzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_xyzz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x06001A98 RID: 6808 RVA: 0x0008C4D0 File Offset: 0x0008A6D0
		public unsafe int4 xzxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_xzxx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x06001A99 RID: 6809 RVA: 0x0008C500 File Offset: 0x0008A700
		public unsafe int4 xzxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_xzxy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x06001A9A RID: 6810 RVA: 0x0008C530 File Offset: 0x0008A730
		public unsafe int4 xzxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_xzxz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x06001A9B RID: 6811 RVA: 0x0008C560 File Offset: 0x0008A760
		public unsafe int4 xzyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_xzyx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x06001A9C RID: 6812 RVA: 0x0008C590 File Offset: 0x0008A790
		public unsafe int4 xzyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_xzyy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x06001A9D RID: 6813 RVA: 0x0008C5C0 File Offset: 0x0008A7C0
		public unsafe int4 xzyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_xzyz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x06001A9E RID: 6814 RVA: 0x0008C5F0 File Offset: 0x0008A7F0
		public unsafe int4 xzzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_xzzx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x06001A9F RID: 6815 RVA: 0x0008C620 File Offset: 0x0008A820
		public unsafe int4 xzzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_xzzy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x06001AA0 RID: 6816 RVA: 0x0008C650 File Offset: 0x0008A850
		public unsafe int4 xzzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_xzzz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x06001AA1 RID: 6817 RVA: 0x0008C680 File Offset: 0x0008A880
		public unsafe int4 yxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_yxxx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x06001AA2 RID: 6818 RVA: 0x0008C6B0 File Offset: 0x0008A8B0
		public unsafe int4 yxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_yxxy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x06001AA3 RID: 6819 RVA: 0x0008C6E0 File Offset: 0x0008A8E0
		public unsafe int4 yxxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_yxxz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x06001AA4 RID: 6820 RVA: 0x0008C710 File Offset: 0x0008A910
		public unsafe int4 yxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_yxyx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x06001AA5 RID: 6821 RVA: 0x0008C740 File Offset: 0x0008A940
		public unsafe int4 yxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_yxyy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x06001AA6 RID: 6822 RVA: 0x0008C770 File Offset: 0x0008A970
		public unsafe int4 yxyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_yxyz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x06001AA7 RID: 6823 RVA: 0x0008C7A0 File Offset: 0x0008A9A0
		public unsafe int4 yxzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_yxzx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x06001AA8 RID: 6824 RVA: 0x0008C7D0 File Offset: 0x0008A9D0
		public unsafe int4 yxzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_yxzy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x06001AA9 RID: 6825 RVA: 0x0008C800 File Offset: 0x0008AA00
		public unsafe int4 yxzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_yxzz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x06001AAA RID: 6826 RVA: 0x0008C830 File Offset: 0x0008AA30
		public unsafe int4 yyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_yyxx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x06001AAB RID: 6827 RVA: 0x0008C860 File Offset: 0x0008AA60
		public unsafe int4 yyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_yyxy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x06001AAC RID: 6828 RVA: 0x0008C890 File Offset: 0x0008AA90
		public unsafe int4 yyxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_yyxz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x06001AAD RID: 6829 RVA: 0x0008C8C0 File Offset: 0x0008AAC0
		public unsafe int4 yyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_yyyx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06001AAE RID: 6830 RVA: 0x0008C8F0 File Offset: 0x0008AAF0
		public unsafe int4 yyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_yyyy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06001AAF RID: 6831 RVA: 0x0008C920 File Offset: 0x0008AB20
		public unsafe int4 yyyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_yyyz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x06001AB0 RID: 6832 RVA: 0x0008C950 File Offset: 0x0008AB50
		public unsafe int4 yyzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_yyzx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x06001AB1 RID: 6833 RVA: 0x0008C980 File Offset: 0x0008AB80
		public unsafe int4 yyzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_yyzy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x06001AB2 RID: 6834 RVA: 0x0008C9B0 File Offset: 0x0008ABB0
		public unsafe int4 yyzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_yyzz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x06001AB3 RID: 6835 RVA: 0x0008C9E0 File Offset: 0x0008ABE0
		public unsafe int4 yzxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_yzxx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06001AB4 RID: 6836 RVA: 0x0008CA10 File Offset: 0x0008AC10
		public unsafe int4 yzxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_yzxy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06001AB5 RID: 6837 RVA: 0x0008CA40 File Offset: 0x0008AC40
		public unsafe int4 yzxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_yzxz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06001AB6 RID: 6838 RVA: 0x0008CA70 File Offset: 0x0008AC70
		public unsafe int4 yzyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_yzyx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06001AB7 RID: 6839 RVA: 0x0008CAA0 File Offset: 0x0008ACA0
		public unsafe int4 yzyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_yzyy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06001AB8 RID: 6840 RVA: 0x0008CAD0 File Offset: 0x0008ACD0
		public unsafe int4 yzyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_yzyz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x06001AB9 RID: 6841 RVA: 0x0008CB00 File Offset: 0x0008AD00
		public unsafe int4 yzzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_yzzx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06001ABA RID: 6842 RVA: 0x0008CB30 File Offset: 0x0008AD30
		public unsafe int4 yzzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_yzzy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06001ABB RID: 6843 RVA: 0x0008CB60 File Offset: 0x0008AD60
		public unsafe int4 yzzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_yzzz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06001ABC RID: 6844 RVA: 0x0008CB90 File Offset: 0x0008AD90
		public unsafe int4 zxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_zxxx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06001ABD RID: 6845 RVA: 0x0008CBC0 File Offset: 0x0008ADC0
		public unsafe int4 zxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_zxxy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x06001ABE RID: 6846 RVA: 0x0008CBF0 File Offset: 0x0008ADF0
		public unsafe int4 zxxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_zxxz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x06001ABF RID: 6847 RVA: 0x0008CC20 File Offset: 0x0008AE20
		public unsafe int4 zxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_zxyx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x06001AC0 RID: 6848 RVA: 0x0008CC50 File Offset: 0x0008AE50
		public unsafe int4 zxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_zxyy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x06001AC1 RID: 6849 RVA: 0x0008CC80 File Offset: 0x0008AE80
		public unsafe int4 zxyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_zxyz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06001AC2 RID: 6850 RVA: 0x0008CCB0 File Offset: 0x0008AEB0
		public unsafe int4 zxzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_zxzx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x06001AC3 RID: 6851 RVA: 0x0008CCE0 File Offset: 0x0008AEE0
		public unsafe int4 zxzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_zxzy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x06001AC4 RID: 6852 RVA: 0x0008CD10 File Offset: 0x0008AF10
		public unsafe int4 zxzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_zxzz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x06001AC5 RID: 6853 RVA: 0x0008CD40 File Offset: 0x0008AF40
		public unsafe int4 zyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_zyxx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x06001AC6 RID: 6854 RVA: 0x0008CD70 File Offset: 0x0008AF70
		public unsafe int4 zyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_zyxy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x06001AC7 RID: 6855 RVA: 0x0008CDA0 File Offset: 0x0008AFA0
		public unsafe int4 zyxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_zyxz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x06001AC8 RID: 6856 RVA: 0x0008CDD0 File Offset: 0x0008AFD0
		public unsafe int4 zyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_zyyx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06001AC9 RID: 6857 RVA: 0x0008CE00 File Offset: 0x0008B000
		public unsafe int4 zyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_zyyy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x06001ACA RID: 6858 RVA: 0x0008CE30 File Offset: 0x0008B030
		public unsafe int4 zyyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_zyyz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x06001ACB RID: 6859 RVA: 0x0008CE60 File Offset: 0x0008B060
		public unsafe int4 zyzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_zyzx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06001ACC RID: 6860 RVA: 0x0008CE90 File Offset: 0x0008B090
		public unsafe int4 zyzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_zyzy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06001ACD RID: 6861 RVA: 0x0008CEC0 File Offset: 0x0008B0C0
		public unsafe int4 zyzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_zyzz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x06001ACE RID: 6862 RVA: 0x0008CEF0 File Offset: 0x0008B0F0
		public unsafe int4 zzxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_zzxx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x06001ACF RID: 6863 RVA: 0x0008CF20 File Offset: 0x0008B120
		public unsafe int4 zzxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_zzxy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x06001AD0 RID: 6864 RVA: 0x0008CF50 File Offset: 0x0008B150
		public unsafe int4 zzxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_zzxz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x06001AD1 RID: 6865 RVA: 0x0008CF80 File Offset: 0x0008B180
		public unsafe int4 zzyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_zzyx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x06001AD2 RID: 6866 RVA: 0x0008CFB0 File Offset: 0x0008B1B0
		public unsafe int4 zzyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_zzyy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x06001AD3 RID: 6867 RVA: 0x0008CFE0 File Offset: 0x0008B1E0
		public unsafe int4 zzyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_zzyz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06001AD4 RID: 6868 RVA: 0x0008D010 File Offset: 0x0008B210
		public unsafe int4 zzzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_zzzx_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x06001AD5 RID: 6869 RVA: 0x0008D040 File Offset: 0x0008B240
		public unsafe int4 zzzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_zzzy_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x06001AD6 RID: 6870 RVA: 0x0008D070 File Offset: 0x0008B270
		public unsafe int4 zzzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_zzzz_Public_get_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x06001AD7 RID: 6871 RVA: 0x0008D0A0 File Offset: 0x0008B2A0
		public unsafe int3 xxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_xxx_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x06001AD8 RID: 6872 RVA: 0x0008D0D0 File Offset: 0x0008B2D0
		public unsafe int3 xxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_xxy_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06001AD9 RID: 6873 RVA: 0x0008D100 File Offset: 0x0008B300
		public unsafe int3 xxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_xxz_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06001ADA RID: 6874 RVA: 0x0008D130 File Offset: 0x0008B330
		public unsafe int3 xyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_xyx_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x06001ADB RID: 6875 RVA: 0x0008D160 File Offset: 0x0008B360
		public unsafe int3 xyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_xyy_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06001ADC RID: 6876 RVA: 0x0008D190 File Offset: 0x0008B390
		// (set) Token: 0x06001ADD RID: 6877 RVA: 0x0008D1C0 File Offset: 0x0008B3C0
		public unsafe int3 xyz
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 637161, RefRangeEnd = 637182, XrefRangeStart = 637161, XrefRangeEnd = 637182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_xyz_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_set_xyz_Public_set_Void_int3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x06001ADE RID: 6878 RVA: 0x0008D1F4 File Offset: 0x0008B3F4
		public unsafe int3 xzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_xzx_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x06001ADF RID: 6879 RVA: 0x0008D224 File Offset: 0x0008B424
		// (set) Token: 0x06001AE0 RID: 6880 RVA: 0x0008D254 File Offset: 0x0008B454
		public unsafe int3 xzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_xzy_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_set_xzy_Public_set_Void_int3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x06001AE1 RID: 6881 RVA: 0x0008D288 File Offset: 0x0008B488
		public unsafe int3 xzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_xzz_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x06001AE2 RID: 6882 RVA: 0x0008D2B8 File Offset: 0x0008B4B8
		public unsafe int3 yxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_yxx_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x06001AE3 RID: 6883 RVA: 0x0008D2E8 File Offset: 0x0008B4E8
		public unsafe int3 yxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_yxy_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06001AE4 RID: 6884 RVA: 0x0008D318 File Offset: 0x0008B518
		// (set) Token: 0x06001AE5 RID: 6885 RVA: 0x0008D348 File Offset: 0x0008B548
		public unsafe int3 yxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_yxz_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_set_yxz_Public_set_Void_int3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06001AE6 RID: 6886 RVA: 0x0008D37C File Offset: 0x0008B57C
		public unsafe int3 yyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_yyx_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x06001AE7 RID: 6887 RVA: 0x0008D3AC File Offset: 0x0008B5AC
		public unsafe int3 yyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_yyy_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06001AE8 RID: 6888 RVA: 0x0008D3DC File Offset: 0x0008B5DC
		public unsafe int3 yyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_yyz_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x06001AE9 RID: 6889 RVA: 0x0008D40C File Offset: 0x0008B60C
		// (set) Token: 0x06001AEA RID: 6890 RVA: 0x0008D43C File Offset: 0x0008B63C
		public unsafe int3 yzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_yzx_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_set_yzx_Public_set_Void_int3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x06001AEB RID: 6891 RVA: 0x0008D470 File Offset: 0x0008B670
		public unsafe int3 yzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_yzy_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x06001AEC RID: 6892 RVA: 0x0008D4A0 File Offset: 0x0008B6A0
		public unsafe int3 yzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_yzz_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x06001AED RID: 6893 RVA: 0x0008D4D0 File Offset: 0x0008B6D0
		public unsafe int3 zxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_zxx_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06001AEE RID: 6894 RVA: 0x0008D500 File Offset: 0x0008B700
		// (set) Token: 0x06001AEF RID: 6895 RVA: 0x0008D530 File Offset: 0x0008B730
		public unsafe int3 zxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_zxy_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_set_zxy_Public_set_Void_int3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x06001AF0 RID: 6896 RVA: 0x0008D564 File Offset: 0x0008B764
		public unsafe int3 zxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_zxz_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06001AF1 RID: 6897 RVA: 0x0008D594 File Offset: 0x0008B794
		// (set) Token: 0x06001AF2 RID: 6898 RVA: 0x0008D5C4 File Offset: 0x0008B7C4
		public unsafe int3 zyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_zyx_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_set_zyx_Public_set_Void_int3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06001AF3 RID: 6899 RVA: 0x0008D5F8 File Offset: 0x0008B7F8
		public unsafe int3 zyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_zyy_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06001AF4 RID: 6900 RVA: 0x0008D628 File Offset: 0x0008B828
		public unsafe int3 zyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_zyz_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06001AF5 RID: 6901 RVA: 0x0008D658 File Offset: 0x0008B858
		public unsafe int3 zzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_zzx_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06001AF6 RID: 6902 RVA: 0x0008D688 File Offset: 0x0008B888
		public unsafe int3 zzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_zzy_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x06001AF7 RID: 6903 RVA: 0x0008D6B8 File Offset: 0x0008B8B8
		public unsafe int3 zzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_zzz_Public_get_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06001AF8 RID: 6904 RVA: 0x0008D6E8 File Offset: 0x0008B8E8
		public unsafe int2 xx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_xx_Public_get_int2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x06001AF9 RID: 6905 RVA: 0x0008D718 File Offset: 0x0008B918
		// (set) Token: 0x06001AFA RID: 6906 RVA: 0x0008D748 File Offset: 0x0008B948
		public unsafe int2 xy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_xy_Public_get_int2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_set_xy_Public_set_Void_int2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06001AFB RID: 6907 RVA: 0x0008D77C File Offset: 0x0008B97C
		// (set) Token: 0x06001AFC RID: 6908 RVA: 0x0008D7AC File Offset: 0x0008B9AC
		public unsafe int2 xz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_xz_Public_get_int2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_set_xz_Public_set_Void_int2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06001AFD RID: 6909 RVA: 0x0008D7E0 File Offset: 0x0008B9E0
		// (set) Token: 0x06001AFE RID: 6910 RVA: 0x0008D810 File Offset: 0x0008BA10
		public unsafe int2 yx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_yx_Public_get_int2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_set_yx_Public_set_Void_int2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x06001AFF RID: 6911 RVA: 0x0008D844 File Offset: 0x0008BA44
		public unsafe int2 yy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_yy_Public_get_int2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x06001B00 RID: 6912 RVA: 0x0008D874 File Offset: 0x0008BA74
		// (set) Token: 0x06001B01 RID: 6913 RVA: 0x0008D8A4 File Offset: 0x0008BAA4
		public unsafe int2 yz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_yz_Public_get_int2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_set_yz_Public_set_Void_int2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x06001B02 RID: 6914 RVA: 0x0008D8D8 File Offset: 0x0008BAD8
		// (set) Token: 0x06001B03 RID: 6915 RVA: 0x0008D908 File Offset: 0x0008BB08
		public unsafe int2 zx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_zx_Public_get_int2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_set_zx_Public_set_Void_int2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x06001B04 RID: 6916 RVA: 0x0008D93C File Offset: 0x0008BB3C
		// (set) Token: 0x06001B05 RID: 6917 RVA: 0x0008D96C File Offset: 0x0008BB6C
		public unsafe int2 zy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_zy_Public_get_int2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_set_zy_Public_set_Void_int2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06001B06 RID: 6918 RVA: 0x0008D9A0 File Offset: 0x0008BBA0
		public unsafe int2 zz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_zz_Public_get_int2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000883 RID: 2179
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_get_Item_Public_get_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B09 RID: 6921 RVA: 0x0008DA50 File Offset: 0x0008BC50
		[CallerCount(0)]
		public unsafe bool Equals(int3 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_int3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B0A RID: 6922 RVA: 0x0008DA90 File Offset: 0x0008BC90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639395, XrefRangeEnd = 639398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B0B RID: 6923 RVA: 0x0008DAD4 File Offset: 0x0008BCD4
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B0C RID: 6924 RVA: 0x0008DB04 File Offset: 0x0008BD04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639398, XrefRangeEnd = 639408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001B0D RID: 6925 RVA: 0x0008DB30 File Offset: 0x0008BD30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639408, XrefRangeEnd = 639414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001B0E RID: 6926 RVA: 0x00002712 File Offset: 0x00000912
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<int3>.NativeClassPtr, ref this));
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x06001B0F RID: 6927 RVA: 0x0008DB80 File Offset: 0x0008BD80
		// (set) Token: 0x06001B10 RID: 6928 RVA: 0x00002724 File Offset: 0x00000924
		public unsafe static int3 zero
		{
			get
			{
				int3 @int;
				IL2CPP.il2cpp_field_static_get_value(int3.NativeFieldInfoPtr_zero, (void*)(&@int));
				return @int;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(int3.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x04001AA5 RID: 6821
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x04001AA6 RID: 6822
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04001AA7 RID: 6823
		private static readonly IntPtr NativeFieldInfoPtr_z;

		// Token: 0x04001AA8 RID: 6824
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x04001AA9 RID: 6825
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

		// Token: 0x04001AAA RID: 6826
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_int2_0;

		// Token: 0x04001AAB RID: 6827
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int2_Int32_0;

		// Token: 0x04001AAC RID: 6828
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int3_0;

		// Token: 0x04001AAD RID: 6829
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001AAE RID: 6830
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04001AAF RID: 6831
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool3_0;

		// Token: 0x04001AB0 RID: 6832
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04001AB1 RID: 6833
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint3_0;

		// Token: 0x04001AB2 RID: 6834
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x04001AB3 RID: 6835
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float3_0;

		// Token: 0x04001AB4 RID: 6836
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x04001AB5 RID: 6837
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double3_0;

		// Token: 0x04001AB6 RID: 6838
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_int3_Int32_0;

		// Token: 0x04001AB7 RID: 6839
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int3_Boolean_0;

		// Token: 0x04001AB8 RID: 6840
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int3_bool3_0;

		// Token: 0x04001AB9 RID: 6841
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int3_UInt32_0;

		// Token: 0x04001ABA RID: 6842
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int3_uint3_0;

		// Token: 0x04001ABB RID: 6843
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int3_Single_0;

		// Token: 0x04001ABC RID: 6844
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int3_float3_0;

		// Token: 0x04001ABD RID: 6845
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int3_Double_0;

		// Token: 0x04001ABE RID: 6846
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int3_double3_0;

		// Token: 0x04001ABF RID: 6847
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_int3_int3_int3_0;

		// Token: 0x04001AC0 RID: 6848
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_int3_int3_Int32_0;

		// Token: 0x04001AC1 RID: 6849
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_int3_Int32_int3_0;

		// Token: 0x04001AC2 RID: 6850
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_int3_int3_int3_0;

		// Token: 0x04001AC3 RID: 6851
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_int3_int3_Int32_0;

		// Token: 0x04001AC4 RID: 6852
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_int3_Int32_int3_0;

		// Token: 0x04001AC5 RID: 6853
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_int3_int3_int3_0;

		// Token: 0x04001AC6 RID: 6854
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_int3_int3_Int32_0;

		// Token: 0x04001AC7 RID: 6855
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_int3_Int32_int3_0;

		// Token: 0x04001AC8 RID: 6856
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_int3_int3_int3_0;

		// Token: 0x04001AC9 RID: 6857
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_int3_int3_Int32_0;

		// Token: 0x04001ACA RID: 6858
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_int3_Int32_int3_0;

		// Token: 0x04001ACB RID: 6859
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_int3_int3_int3_0;

		// Token: 0x04001ACC RID: 6860
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_int3_int3_Int32_0;

		// Token: 0x04001ACD RID: 6861
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_int3_Int32_int3_0;

		// Token: 0x04001ACE RID: 6862
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_int3_int3_0;

		// Token: 0x04001ACF RID: 6863
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_int3_int3_0;

		// Token: 0x04001AD0 RID: 6864
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool3_int3_int3_0;

		// Token: 0x04001AD1 RID: 6865
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool3_int3_Int32_0;

		// Token: 0x04001AD2 RID: 6866
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool3_Int32_int3_0;

		// Token: 0x04001AD3 RID: 6867
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3_int3_int3_0;

		// Token: 0x04001AD4 RID: 6868
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3_int3_Int32_0;

		// Token: 0x04001AD5 RID: 6869
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3_Int32_int3_0;

		// Token: 0x04001AD6 RID: 6870
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3_int3_int3_0;

		// Token: 0x04001AD7 RID: 6871
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3_int3_Int32_0;

		// Token: 0x04001AD8 RID: 6872
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3_Int32_int3_0;

		// Token: 0x04001AD9 RID: 6873
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3_int3_int3_0;

		// Token: 0x04001ADA RID: 6874
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3_int3_Int32_0;

		// Token: 0x04001ADB RID: 6875
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3_Int32_int3_0;

		// Token: 0x04001ADC RID: 6876
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_int3_int3_0;

		// Token: 0x04001ADD RID: 6877
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryPlus_Public_Static_int3_int3_0;

		// Token: 0x04001ADE RID: 6878
		private static readonly IntPtr NativeMethodInfoPtr_op_LeftShift_Public_Static_int3_int3_Int32_0;

		// Token: 0x04001ADF RID: 6879
		private static readonly IntPtr NativeMethodInfoPtr_op_RightShift_Public_Static_int3_int3_Int32_0;

		// Token: 0x04001AE0 RID: 6880
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3_int3_int3_0;

		// Token: 0x04001AE1 RID: 6881
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3_int3_Int32_0;

		// Token: 0x04001AE2 RID: 6882
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3_Int32_int3_0;

		// Token: 0x04001AE3 RID: 6883
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_int3_int3_0;

		// Token: 0x04001AE4 RID: 6884
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_int3_Int32_0;

		// Token: 0x04001AE5 RID: 6885
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_Int32_int3_0;

		// Token: 0x04001AE6 RID: 6886
		private static readonly IntPtr NativeMethodInfoPtr_op_OnesComplement_Public_Static_int3_int3_0;

		// Token: 0x04001AE7 RID: 6887
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int3_int3_int3_0;

		// Token: 0x04001AE8 RID: 6888
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int3_int3_Int32_0;

		// Token: 0x04001AE9 RID: 6889
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int3_Int32_int3_0;

		// Token: 0x04001AEA RID: 6890
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int3_int3_int3_0;

		// Token: 0x04001AEB RID: 6891
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int3_int3_Int32_0;

		// Token: 0x04001AEC RID: 6892
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int3_Int32_int3_0;

		// Token: 0x04001AED RID: 6893
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int3_int3_int3_0;

		// Token: 0x04001AEE RID: 6894
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int3_int3_Int32_0;

		// Token: 0x04001AEF RID: 6895
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int3_Int32_int3_0;

		// Token: 0x04001AF0 RID: 6896
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxx_Public_get_int4_0;

		// Token: 0x04001AF1 RID: 6897
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxy_Public_get_int4_0;

		// Token: 0x04001AF2 RID: 6898
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxz_Public_get_int4_0;

		// Token: 0x04001AF3 RID: 6899
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyx_Public_get_int4_0;

		// Token: 0x04001AF4 RID: 6900
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyy_Public_get_int4_0;

		// Token: 0x04001AF5 RID: 6901
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyz_Public_get_int4_0;

		// Token: 0x04001AF6 RID: 6902
		private static readonly IntPtr NativeMethodInfoPtr_get_xxzx_Public_get_int4_0;

		// Token: 0x04001AF7 RID: 6903
		private static readonly IntPtr NativeMethodInfoPtr_get_xxzy_Public_get_int4_0;

		// Token: 0x04001AF8 RID: 6904
		private static readonly IntPtr NativeMethodInfoPtr_get_xxzz_Public_get_int4_0;

		// Token: 0x04001AF9 RID: 6905
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxx_Public_get_int4_0;

		// Token: 0x04001AFA RID: 6906
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxy_Public_get_int4_0;

		// Token: 0x04001AFB RID: 6907
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxz_Public_get_int4_0;

		// Token: 0x04001AFC RID: 6908
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyx_Public_get_int4_0;

		// Token: 0x04001AFD RID: 6909
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyy_Public_get_int4_0;

		// Token: 0x04001AFE RID: 6910
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyz_Public_get_int4_0;

		// Token: 0x04001AFF RID: 6911
		private static readonly IntPtr NativeMethodInfoPtr_get_xyzx_Public_get_int4_0;

		// Token: 0x04001B00 RID: 6912
		private static readonly IntPtr NativeMethodInfoPtr_get_xyzy_Public_get_int4_0;

		// Token: 0x04001B01 RID: 6913
		private static readonly IntPtr NativeMethodInfoPtr_get_xyzz_Public_get_int4_0;

		// Token: 0x04001B02 RID: 6914
		private static readonly IntPtr NativeMethodInfoPtr_get_xzxx_Public_get_int4_0;

		// Token: 0x04001B03 RID: 6915
		private static readonly IntPtr NativeMethodInfoPtr_get_xzxy_Public_get_int4_0;

		// Token: 0x04001B04 RID: 6916
		private static readonly IntPtr NativeMethodInfoPtr_get_xzxz_Public_get_int4_0;

		// Token: 0x04001B05 RID: 6917
		private static readonly IntPtr NativeMethodInfoPtr_get_xzyx_Public_get_int4_0;

		// Token: 0x04001B06 RID: 6918
		private static readonly IntPtr NativeMethodInfoPtr_get_xzyy_Public_get_int4_0;

		// Token: 0x04001B07 RID: 6919
		private static readonly IntPtr NativeMethodInfoPtr_get_xzyz_Public_get_int4_0;

		// Token: 0x04001B08 RID: 6920
		private static readonly IntPtr NativeMethodInfoPtr_get_xzzx_Public_get_int4_0;

		// Token: 0x04001B09 RID: 6921
		private static readonly IntPtr NativeMethodInfoPtr_get_xzzy_Public_get_int4_0;

		// Token: 0x04001B0A RID: 6922
		private static readonly IntPtr NativeMethodInfoPtr_get_xzzz_Public_get_int4_0;

		// Token: 0x04001B0B RID: 6923
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxx_Public_get_int4_0;

		// Token: 0x04001B0C RID: 6924
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxy_Public_get_int4_0;

		// Token: 0x04001B0D RID: 6925
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxz_Public_get_int4_0;

		// Token: 0x04001B0E RID: 6926
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyx_Public_get_int4_0;

		// Token: 0x04001B0F RID: 6927
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyy_Public_get_int4_0;

		// Token: 0x04001B10 RID: 6928
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyz_Public_get_int4_0;

		// Token: 0x04001B11 RID: 6929
		private static readonly IntPtr NativeMethodInfoPtr_get_yxzx_Public_get_int4_0;

		// Token: 0x04001B12 RID: 6930
		private static readonly IntPtr NativeMethodInfoPtr_get_yxzy_Public_get_int4_0;

		// Token: 0x04001B13 RID: 6931
		private static readonly IntPtr NativeMethodInfoPtr_get_yxzz_Public_get_int4_0;

		// Token: 0x04001B14 RID: 6932
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxx_Public_get_int4_0;

		// Token: 0x04001B15 RID: 6933
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxy_Public_get_int4_0;

		// Token: 0x04001B16 RID: 6934
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxz_Public_get_int4_0;

		// Token: 0x04001B17 RID: 6935
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyx_Public_get_int4_0;

		// Token: 0x04001B18 RID: 6936
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyy_Public_get_int4_0;

		// Token: 0x04001B19 RID: 6937
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyz_Public_get_int4_0;

		// Token: 0x04001B1A RID: 6938
		private static readonly IntPtr NativeMethodInfoPtr_get_yyzx_Public_get_int4_0;

		// Token: 0x04001B1B RID: 6939
		private static readonly IntPtr NativeMethodInfoPtr_get_yyzy_Public_get_int4_0;

		// Token: 0x04001B1C RID: 6940
		private static readonly IntPtr NativeMethodInfoPtr_get_yyzz_Public_get_int4_0;

		// Token: 0x04001B1D RID: 6941
		private static readonly IntPtr NativeMethodInfoPtr_get_yzxx_Public_get_int4_0;

		// Token: 0x04001B1E RID: 6942
		private static readonly IntPtr NativeMethodInfoPtr_get_yzxy_Public_get_int4_0;

		// Token: 0x04001B1F RID: 6943
		private static readonly IntPtr NativeMethodInfoPtr_get_yzxz_Public_get_int4_0;

		// Token: 0x04001B20 RID: 6944
		private static readonly IntPtr NativeMethodInfoPtr_get_yzyx_Public_get_int4_0;

		// Token: 0x04001B21 RID: 6945
		private static readonly IntPtr NativeMethodInfoPtr_get_yzyy_Public_get_int4_0;

		// Token: 0x04001B22 RID: 6946
		private static readonly IntPtr NativeMethodInfoPtr_get_yzyz_Public_get_int4_0;

		// Token: 0x04001B23 RID: 6947
		private static readonly IntPtr NativeMethodInfoPtr_get_yzzx_Public_get_int4_0;

		// Token: 0x04001B24 RID: 6948
		private static readonly IntPtr NativeMethodInfoPtr_get_yzzy_Public_get_int4_0;

		// Token: 0x04001B25 RID: 6949
		private static readonly IntPtr NativeMethodInfoPtr_get_yzzz_Public_get_int4_0;

		// Token: 0x04001B26 RID: 6950
		private static readonly IntPtr NativeMethodInfoPtr_get_zxxx_Public_get_int4_0;

		// Token: 0x04001B27 RID: 6951
		private static readonly IntPtr NativeMethodInfoPtr_get_zxxy_Public_get_int4_0;

		// Token: 0x04001B28 RID: 6952
		private static readonly IntPtr NativeMethodInfoPtr_get_zxxz_Public_get_int4_0;

		// Token: 0x04001B29 RID: 6953
		private static readonly IntPtr NativeMethodInfoPtr_get_zxyx_Public_get_int4_0;

		// Token: 0x04001B2A RID: 6954
		private static readonly IntPtr NativeMethodInfoPtr_get_zxyy_Public_get_int4_0;

		// Token: 0x04001B2B RID: 6955
		private static readonly IntPtr NativeMethodInfoPtr_get_zxyz_Public_get_int4_0;

		// Token: 0x04001B2C RID: 6956
		private static readonly IntPtr NativeMethodInfoPtr_get_zxzx_Public_get_int4_0;

		// Token: 0x04001B2D RID: 6957
		private static readonly IntPtr NativeMethodInfoPtr_get_zxzy_Public_get_int4_0;

		// Token: 0x04001B2E RID: 6958
		private static readonly IntPtr NativeMethodInfoPtr_get_zxzz_Public_get_int4_0;

		// Token: 0x04001B2F RID: 6959
		private static readonly IntPtr NativeMethodInfoPtr_get_zyxx_Public_get_int4_0;

		// Token: 0x04001B30 RID: 6960
		private static readonly IntPtr NativeMethodInfoPtr_get_zyxy_Public_get_int4_0;

		// Token: 0x04001B31 RID: 6961
		private static readonly IntPtr NativeMethodInfoPtr_get_zyxz_Public_get_int4_0;

		// Token: 0x04001B32 RID: 6962
		private static readonly IntPtr NativeMethodInfoPtr_get_zyyx_Public_get_int4_0;

		// Token: 0x04001B33 RID: 6963
		private static readonly IntPtr NativeMethodInfoPtr_get_zyyy_Public_get_int4_0;

		// Token: 0x04001B34 RID: 6964
		private static readonly IntPtr NativeMethodInfoPtr_get_zyyz_Public_get_int4_0;

		// Token: 0x04001B35 RID: 6965
		private static readonly IntPtr NativeMethodInfoPtr_get_zyzx_Public_get_int4_0;

		// Token: 0x04001B36 RID: 6966
		private static readonly IntPtr NativeMethodInfoPtr_get_zyzy_Public_get_int4_0;

		// Token: 0x04001B37 RID: 6967
		private static readonly IntPtr NativeMethodInfoPtr_get_zyzz_Public_get_int4_0;

		// Token: 0x04001B38 RID: 6968
		private static readonly IntPtr NativeMethodInfoPtr_get_zzxx_Public_get_int4_0;

		// Token: 0x04001B39 RID: 6969
		private static readonly IntPtr NativeMethodInfoPtr_get_zzxy_Public_get_int4_0;

		// Token: 0x04001B3A RID: 6970
		private static readonly IntPtr NativeMethodInfoPtr_get_zzxz_Public_get_int4_0;

		// Token: 0x04001B3B RID: 6971
		private static readonly IntPtr NativeMethodInfoPtr_get_zzyx_Public_get_int4_0;

		// Token: 0x04001B3C RID: 6972
		private static readonly IntPtr NativeMethodInfoPtr_get_zzyy_Public_get_int4_0;

		// Token: 0x04001B3D RID: 6973
		private static readonly IntPtr NativeMethodInfoPtr_get_zzyz_Public_get_int4_0;

		// Token: 0x04001B3E RID: 6974
		private static readonly IntPtr NativeMethodInfoPtr_get_zzzx_Public_get_int4_0;

		// Token: 0x04001B3F RID: 6975
		private static readonly IntPtr NativeMethodInfoPtr_get_zzzy_Public_get_int4_0;

		// Token: 0x04001B40 RID: 6976
		private static readonly IntPtr NativeMethodInfoPtr_get_zzzz_Public_get_int4_0;

		// Token: 0x04001B41 RID: 6977
		private static readonly IntPtr NativeMethodInfoPtr_get_xxx_Public_get_int3_0;

		// Token: 0x04001B42 RID: 6978
		private static readonly IntPtr NativeMethodInfoPtr_get_xxy_Public_get_int3_0;

		// Token: 0x04001B43 RID: 6979
		private static readonly IntPtr NativeMethodInfoPtr_get_xxz_Public_get_int3_0;

		// Token: 0x04001B44 RID: 6980
		private static readonly IntPtr NativeMethodInfoPtr_get_xyx_Public_get_int3_0;

		// Token: 0x04001B45 RID: 6981
		private static readonly IntPtr NativeMethodInfoPtr_get_xyy_Public_get_int3_0;

		// Token: 0x04001B46 RID: 6982
		private static readonly IntPtr NativeMethodInfoPtr_get_xyz_Public_get_int3_0;

		// Token: 0x04001B47 RID: 6983
		private static readonly IntPtr NativeMethodInfoPtr_set_xyz_Public_set_Void_int3_0;

		// Token: 0x04001B48 RID: 6984
		private static readonly IntPtr NativeMethodInfoPtr_get_xzx_Public_get_int3_0;

		// Token: 0x04001B49 RID: 6985
		private static readonly IntPtr NativeMethodInfoPtr_get_xzy_Public_get_int3_0;

		// Token: 0x04001B4A RID: 6986
		private static readonly IntPtr NativeMethodInfoPtr_set_xzy_Public_set_Void_int3_0;

		// Token: 0x04001B4B RID: 6987
		private static readonly IntPtr NativeMethodInfoPtr_get_xzz_Public_get_int3_0;

		// Token: 0x04001B4C RID: 6988
		private static readonly IntPtr NativeMethodInfoPtr_get_yxx_Public_get_int3_0;

		// Token: 0x04001B4D RID: 6989
		private static readonly IntPtr NativeMethodInfoPtr_get_yxy_Public_get_int3_0;

		// Token: 0x04001B4E RID: 6990
		private static readonly IntPtr NativeMethodInfoPtr_get_yxz_Public_get_int3_0;

		// Token: 0x04001B4F RID: 6991
		private static readonly IntPtr NativeMethodInfoPtr_set_yxz_Public_set_Void_int3_0;

		// Token: 0x04001B50 RID: 6992
		private static readonly IntPtr NativeMethodInfoPtr_get_yyx_Public_get_int3_0;

		// Token: 0x04001B51 RID: 6993
		private static readonly IntPtr NativeMethodInfoPtr_get_yyy_Public_get_int3_0;

		// Token: 0x04001B52 RID: 6994
		private static readonly IntPtr NativeMethodInfoPtr_get_yyz_Public_get_int3_0;

		// Token: 0x04001B53 RID: 6995
		private static readonly IntPtr NativeMethodInfoPtr_get_yzx_Public_get_int3_0;

		// Token: 0x04001B54 RID: 6996
		private static readonly IntPtr NativeMethodInfoPtr_set_yzx_Public_set_Void_int3_0;

		// Token: 0x04001B55 RID: 6997
		private static readonly IntPtr NativeMethodInfoPtr_get_yzy_Public_get_int3_0;

		// Token: 0x04001B56 RID: 6998
		private static readonly IntPtr NativeMethodInfoPtr_get_yzz_Public_get_int3_0;

		// Token: 0x04001B57 RID: 6999
		private static readonly IntPtr NativeMethodInfoPtr_get_zxx_Public_get_int3_0;

		// Token: 0x04001B58 RID: 7000
		private static readonly IntPtr NativeMethodInfoPtr_get_zxy_Public_get_int3_0;

		// Token: 0x04001B59 RID: 7001
		private static readonly IntPtr NativeMethodInfoPtr_set_zxy_Public_set_Void_int3_0;

		// Token: 0x04001B5A RID: 7002
		private static readonly IntPtr NativeMethodInfoPtr_get_zxz_Public_get_int3_0;

		// Token: 0x04001B5B RID: 7003
		private static readonly IntPtr NativeMethodInfoPtr_get_zyx_Public_get_int3_0;

		// Token: 0x04001B5C RID: 7004
		private static readonly IntPtr NativeMethodInfoPtr_set_zyx_Public_set_Void_int3_0;

		// Token: 0x04001B5D RID: 7005
		private static readonly IntPtr NativeMethodInfoPtr_get_zyy_Public_get_int3_0;

		// Token: 0x04001B5E RID: 7006
		private static readonly IntPtr NativeMethodInfoPtr_get_zyz_Public_get_int3_0;

		// Token: 0x04001B5F RID: 7007
		private static readonly IntPtr NativeMethodInfoPtr_get_zzx_Public_get_int3_0;

		// Token: 0x04001B60 RID: 7008
		private static readonly IntPtr NativeMethodInfoPtr_get_zzy_Public_get_int3_0;

		// Token: 0x04001B61 RID: 7009
		private static readonly IntPtr NativeMethodInfoPtr_get_zzz_Public_get_int3_0;

		// Token: 0x04001B62 RID: 7010
		private static readonly IntPtr NativeMethodInfoPtr_get_xx_Public_get_int2_0;

		// Token: 0x04001B63 RID: 7011
		private static readonly IntPtr NativeMethodInfoPtr_get_xy_Public_get_int2_0;

		// Token: 0x04001B64 RID: 7012
		private static readonly IntPtr NativeMethodInfoPtr_set_xy_Public_set_Void_int2_0;

		// Token: 0x04001B65 RID: 7013
		private static readonly IntPtr NativeMethodInfoPtr_get_xz_Public_get_int2_0;

		// Token: 0x04001B66 RID: 7014
		private static readonly IntPtr NativeMethodInfoPtr_set_xz_Public_set_Void_int2_0;

		// Token: 0x04001B67 RID: 7015
		private static readonly IntPtr NativeMethodInfoPtr_get_yx_Public_get_int2_0;

		// Token: 0x04001B68 RID: 7016
		private static readonly IntPtr NativeMethodInfoPtr_set_yx_Public_set_Void_int2_0;

		// Token: 0x04001B69 RID: 7017
		private static readonly IntPtr NativeMethodInfoPtr_get_yy_Public_get_int2_0;

		// Token: 0x04001B6A RID: 7018
		private static readonly IntPtr NativeMethodInfoPtr_get_yz_Public_get_int2_0;

		// Token: 0x04001B6B RID: 7019
		private static readonly IntPtr NativeMethodInfoPtr_set_yz_Public_set_Void_int2_0;

		// Token: 0x04001B6C RID: 7020
		private static readonly IntPtr NativeMethodInfoPtr_get_zx_Public_get_int2_0;

		// Token: 0x04001B6D RID: 7021
		private static readonly IntPtr NativeMethodInfoPtr_set_zx_Public_set_Void_int2_0;

		// Token: 0x04001B6E RID: 7022
		private static readonly IntPtr NativeMethodInfoPtr_get_zy_Public_get_int2_0;

		// Token: 0x04001B6F RID: 7023
		private static readonly IntPtr NativeMethodInfoPtr_set_zy_Public_set_Void_int2_0;

		// Token: 0x04001B70 RID: 7024
		private static readonly IntPtr NativeMethodInfoPtr_get_zz_Public_get_int2_0;

		// Token: 0x04001B71 RID: 7025
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Int32_Int32_0;

		// Token: 0x04001B72 RID: 7026
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_0;

		// Token: 0x04001B73 RID: 7027
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_int3_0;

		// Token: 0x04001B74 RID: 7028
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001B75 RID: 7029
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001B76 RID: 7030
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001B77 RID: 7031
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04001B78 RID: 7032
		[FieldOffset(0)]
		public int x;

		// Token: 0x04001B79 RID: 7033
		[FieldOffset(4)]
		public int y;

		// Token: 0x04001B7A RID: 7034
		[FieldOffset(8)]
		public int z;

		// Token: 0x02000061 RID: 97
		public sealed class DebuggerProxy : Object
		{
			// Token: 0x0600262C RID: 9772 RVA: 0x000C3D2C File Offset: 0x000C1F2C
			// Note: this type is marked as 'beforefieldinit'.
			static DebuggerProxy()
			{
				Il2CppClassPointerStore<int3.DebuggerProxy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<int3>.NativeClassPtr, "DebuggerProxy");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<int3.DebuggerProxy>.NativeClassPtr);
				int3.DebuggerProxy.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int3.DebuggerProxy>.NativeClassPtr, "x");
				int3.DebuggerProxy.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int3.DebuggerProxy>.NativeClassPtr, "y");
				int3.DebuggerProxy.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int3.DebuggerProxy>.NativeClassPtr, "z");
				int3.DebuggerProxy.NativeMethodInfoPtr__ctor_Public_Void_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3.DebuggerProxy>.NativeClassPtr, 100670026);
			}

			// Token: 0x0600262D RID: 9773 RVA: 0x000C3DA8 File Offset: 0x000C1FA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DebuggerProxy(int3 v)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<int3.DebuggerProxy>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3.DebuggerProxy.NativeMethodInfoPtr__ctor_Public_Void_int3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600262E RID: 9774 RVA: 0x0000304E File Offset: 0x0000124E
			public DebuggerProxy(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C17 RID: 3095
			// (get) Token: 0x0600262F RID: 9775 RVA: 0x000C3DF0 File Offset: 0x000C1FF0
			// (set) Token: 0x06002630 RID: 9776 RVA: 0x00003057 File Offset: 0x00001257
			public unsafe int x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(int3.DebuggerProxy.NativeFieldInfoPtr_x);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(int3.DebuggerProxy.NativeFieldInfoPtr_x)) = value;
				}
			}

			// Token: 0x17000C18 RID: 3096
			// (get) Token: 0x06002631 RID: 9777 RVA: 0x000C3E18 File Offset: 0x000C2018
			// (set) Token: 0x06002632 RID: 9778 RVA: 0x00003072 File Offset: 0x00001272
			public unsafe int y
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(int3.DebuggerProxy.NativeFieldInfoPtr_y);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(int3.DebuggerProxy.NativeFieldInfoPtr_y)) = value;
				}
			}

			// Token: 0x17000C19 RID: 3097
			// (get) Token: 0x06002633 RID: 9779 RVA: 0x000C3E40 File Offset: 0x000C2040
			// (set) Token: 0x06002634 RID: 9780 RVA: 0x0000308D File Offset: 0x0000128D
			public unsafe int z
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(int3.DebuggerProxy.NativeFieldInfoPtr_z);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(int3.DebuggerProxy.NativeFieldInfoPtr_z)) = value;
				}
			}

			// Token: 0x0400268F RID: 9871
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04002690 RID: 9872
			private static readonly IntPtr NativeFieldInfoPtr_y;

			// Token: 0x04002691 RID: 9873
			private static readonly IntPtr NativeFieldInfoPtr_z;

			// Token: 0x04002692 RID: 9874
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int3_0;
		}
	}
}
