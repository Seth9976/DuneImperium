using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x02000047 RID: 71
	[Serializable]
	[StructLayout(2)]
	public struct uint4
	{
		// Token: 0x060022A7 RID: 8871 RVA: 0x000B44B8 File Offset: 0x000B26B8
		// Note: this type is marked as 'beforefieldinit'.
		static uint4()
		{
			Il2CppClassPointerStore<uint4>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "uint4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<uint4>.NativeClassPtr);
			uint4.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint4>.NativeClassPtr, "x");
			uint4.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint4>.NativeClassPtr, "y");
			uint4.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint4>.NativeClassPtr, "z");
			uint4.NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint4>.NativeClassPtr, "w");
			uint4.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint4>.NativeClassPtr, "zero");
			uint4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671894);
			uint4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671895);
			uint4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_uint2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671896);
			uint4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671897);
			uint4.NativeMethodInfoPtr__ctor_Public_Void_uint2_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671898);
			uint4.NativeMethodInfoPtr__ctor_Public_Void_uint2_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671899);
			uint4.NativeMethodInfoPtr__ctor_Public_Void_uint3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671900);
			uint4.NativeMethodInfoPtr__ctor_Public_Void_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671901);
			uint4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671902);
			uint4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671903);
			uint4.NativeMethodInfoPtr__ctor_Public_Void_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671904);
			uint4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671905);
			uint4.NativeMethodInfoPtr__ctor_Public_Void_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671906);
			uint4.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671907);
			uint4.NativeMethodInfoPtr__ctor_Public_Void_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671908);
			uint4.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671909);
			uint4.NativeMethodInfoPtr__ctor_Public_Void_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671910);
			uint4.NativeMethodInfoPtr_op_Implicit_Public_Static_uint4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671911);
			uint4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671912);
			uint4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671913);
			uint4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671914);
			uint4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671915);
			uint4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671916);
			uint4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671917);
			uint4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671918);
			uint4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671919);
			uint4.NativeMethodInfoPtr_op_Multiply_Public_Static_uint4_uint4_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671920);
			uint4.NativeMethodInfoPtr_op_Multiply_Public_Static_uint4_uint4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671921);
			uint4.NativeMethodInfoPtr_op_Multiply_Public_Static_uint4_UInt32_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671922);
			uint4.NativeMethodInfoPtr_op_Addition_Public_Static_uint4_uint4_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671923);
			uint4.NativeMethodInfoPtr_op_Addition_Public_Static_uint4_uint4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671924);
			uint4.NativeMethodInfoPtr_op_Addition_Public_Static_uint4_UInt32_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671925);
			uint4.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint4_uint4_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671926);
			uint4.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint4_uint4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671927);
			uint4.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint4_UInt32_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671928);
			uint4.NativeMethodInfoPtr_op_Division_Public_Static_uint4_uint4_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671929);
			uint4.NativeMethodInfoPtr_op_Division_Public_Static_uint4_uint4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671930);
			uint4.NativeMethodInfoPtr_op_Division_Public_Static_uint4_UInt32_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671931);
			uint4.NativeMethodInfoPtr_op_Modulus_Public_Static_uint4_uint4_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671932);
			uint4.NativeMethodInfoPtr_op_Modulus_Public_Static_uint4_uint4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671933);
			uint4.NativeMethodInfoPtr_op_Modulus_Public_Static_uint4_UInt32_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671934);
			uint4.NativeMethodInfoPtr_op_Increment_Public_Static_uint4_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671935);
			uint4.NativeMethodInfoPtr_op_Decrement_Public_Static_uint4_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671936);
			uint4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4_uint4_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671937);
			uint4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4_uint4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671938);
			uint4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4_UInt32_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671939);
			uint4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4_uint4_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671940);
			uint4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4_uint4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671941);
			uint4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4_UInt32_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671942);
			uint4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4_uint4_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671943);
			uint4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4_uint4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671944);
			uint4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4_UInt32_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671945);
			uint4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4_uint4_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671946);
			uint4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4_uint4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671947);
			uint4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4_UInt32_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671948);
			uint4.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_uint4_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671949);
			uint4.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_uint4_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671950);
			uint4.NativeMethodInfoPtr_op_LeftShift_Public_Static_uint4_uint4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671951);
			uint4.NativeMethodInfoPtr_op_RightShift_Public_Static_uint4_uint4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671952);
			uint4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4_uint4_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671953);
			uint4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4_uint4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671954);
			uint4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4_UInt32_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671955);
			uint4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_uint4_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671956);
			uint4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_uint4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671957);
			uint4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_UInt32_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671958);
			uint4.NativeMethodInfoPtr_op_OnesComplement_Public_Static_uint4_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671959);
			uint4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint4_uint4_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671960);
			uint4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint4_uint4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671961);
			uint4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint4_UInt32_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671962);
			uint4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint4_uint4_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671963);
			uint4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint4_uint4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671964);
			uint4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint4_UInt32_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671965);
			uint4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint4_uint4_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671966);
			uint4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint4_uint4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671967);
			uint4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint4_UInt32_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671968);
			uint4.NativeMethodInfoPtr_get_xxxx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671969);
			uint4.NativeMethodInfoPtr_get_xxxy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671970);
			uint4.NativeMethodInfoPtr_get_xxxz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671971);
			uint4.NativeMethodInfoPtr_get_xxxw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671972);
			uint4.NativeMethodInfoPtr_get_xxyx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671973);
			uint4.NativeMethodInfoPtr_get_xxyy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671974);
			uint4.NativeMethodInfoPtr_get_xxyz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671975);
			uint4.NativeMethodInfoPtr_get_xxyw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671976);
			uint4.NativeMethodInfoPtr_get_xxzx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671977);
			uint4.NativeMethodInfoPtr_get_xxzy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671978);
			uint4.NativeMethodInfoPtr_get_xxzz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671979);
			uint4.NativeMethodInfoPtr_get_xxzw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671980);
			uint4.NativeMethodInfoPtr_get_xxwx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671981);
			uint4.NativeMethodInfoPtr_get_xxwy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671982);
			uint4.NativeMethodInfoPtr_get_xxwz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671983);
			uint4.NativeMethodInfoPtr_get_xxww_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671984);
			uint4.NativeMethodInfoPtr_get_xyxx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671985);
			uint4.NativeMethodInfoPtr_get_xyxy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671986);
			uint4.NativeMethodInfoPtr_get_xyxz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671987);
			uint4.NativeMethodInfoPtr_get_xyxw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671988);
			uint4.NativeMethodInfoPtr_get_xyyx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671989);
			uint4.NativeMethodInfoPtr_get_xyyy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671990);
			uint4.NativeMethodInfoPtr_get_xyyz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671991);
			uint4.NativeMethodInfoPtr_get_xyyw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671992);
			uint4.NativeMethodInfoPtr_get_xyzx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671993);
			uint4.NativeMethodInfoPtr_get_xyzy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671994);
			uint4.NativeMethodInfoPtr_get_xyzz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671995);
			uint4.NativeMethodInfoPtr_get_xyzw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671996);
			uint4.NativeMethodInfoPtr_set_xyzw_Public_set_Void_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671997);
			uint4.NativeMethodInfoPtr_get_xywx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671998);
			uint4.NativeMethodInfoPtr_get_xywy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100671999);
			uint4.NativeMethodInfoPtr_get_xywz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672000);
			uint4.NativeMethodInfoPtr_set_xywz_Public_set_Void_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672001);
			uint4.NativeMethodInfoPtr_get_xyww_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672002);
			uint4.NativeMethodInfoPtr_get_xzxx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672003);
			uint4.NativeMethodInfoPtr_get_xzxy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672004);
			uint4.NativeMethodInfoPtr_get_xzxz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672005);
			uint4.NativeMethodInfoPtr_get_xzxw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672006);
			uint4.NativeMethodInfoPtr_get_xzyx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672007);
			uint4.NativeMethodInfoPtr_get_xzyy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672008);
			uint4.NativeMethodInfoPtr_get_xzyz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672009);
			uint4.NativeMethodInfoPtr_get_xzyw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672010);
			uint4.NativeMethodInfoPtr_set_xzyw_Public_set_Void_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672011);
			uint4.NativeMethodInfoPtr_get_xzzx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672012);
			uint4.NativeMethodInfoPtr_get_xzzy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672013);
			uint4.NativeMethodInfoPtr_get_xzzz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672014);
			uint4.NativeMethodInfoPtr_get_xzzw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672015);
			uint4.NativeMethodInfoPtr_get_xzwx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672016);
			uint4.NativeMethodInfoPtr_get_xzwy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672017);
			uint4.NativeMethodInfoPtr_set_xzwy_Public_set_Void_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672018);
			uint4.NativeMethodInfoPtr_get_xzwz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672019);
			uint4.NativeMethodInfoPtr_get_xzww_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672020);
			uint4.NativeMethodInfoPtr_get_xwxx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672021);
			uint4.NativeMethodInfoPtr_get_xwxy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672022);
			uint4.NativeMethodInfoPtr_get_xwxz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672023);
			uint4.NativeMethodInfoPtr_get_xwxw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672024);
			uint4.NativeMethodInfoPtr_get_xwyx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672025);
			uint4.NativeMethodInfoPtr_get_xwyy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672026);
			uint4.NativeMethodInfoPtr_get_xwyz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672027);
			uint4.NativeMethodInfoPtr_set_xwyz_Public_set_Void_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672028);
			uint4.NativeMethodInfoPtr_get_xwyw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672029);
			uint4.NativeMethodInfoPtr_get_xwzx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672030);
			uint4.NativeMethodInfoPtr_get_xwzy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672031);
			uint4.NativeMethodInfoPtr_set_xwzy_Public_set_Void_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672032);
			uint4.NativeMethodInfoPtr_get_xwzz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672033);
			uint4.NativeMethodInfoPtr_get_xwzw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672034);
			uint4.NativeMethodInfoPtr_get_xwwx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672035);
			uint4.NativeMethodInfoPtr_get_xwwy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672036);
			uint4.NativeMethodInfoPtr_get_xwwz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672037);
			uint4.NativeMethodInfoPtr_get_xwww_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672038);
			uint4.NativeMethodInfoPtr_get_yxxx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672039);
			uint4.NativeMethodInfoPtr_get_yxxy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672040);
			uint4.NativeMethodInfoPtr_get_yxxz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672041);
			uint4.NativeMethodInfoPtr_get_yxxw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672042);
			uint4.NativeMethodInfoPtr_get_yxyx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672043);
			uint4.NativeMethodInfoPtr_get_yxyy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672044);
			uint4.NativeMethodInfoPtr_get_yxyz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672045);
			uint4.NativeMethodInfoPtr_get_yxyw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672046);
			uint4.NativeMethodInfoPtr_get_yxzx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672047);
			uint4.NativeMethodInfoPtr_get_yxzy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672048);
			uint4.NativeMethodInfoPtr_get_yxzz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672049);
			uint4.NativeMethodInfoPtr_get_yxzw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672050);
			uint4.NativeMethodInfoPtr_set_yxzw_Public_set_Void_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672051);
			uint4.NativeMethodInfoPtr_get_yxwx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672052);
			uint4.NativeMethodInfoPtr_get_yxwy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672053);
			uint4.NativeMethodInfoPtr_get_yxwz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672054);
			uint4.NativeMethodInfoPtr_set_yxwz_Public_set_Void_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672055);
			uint4.NativeMethodInfoPtr_get_yxww_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672056);
			uint4.NativeMethodInfoPtr_get_yyxx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672057);
			uint4.NativeMethodInfoPtr_get_yyxy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672058);
			uint4.NativeMethodInfoPtr_get_yyxz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672059);
			uint4.NativeMethodInfoPtr_get_yyxw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672060);
			uint4.NativeMethodInfoPtr_get_yyyx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672061);
			uint4.NativeMethodInfoPtr_get_yyyy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672062);
			uint4.NativeMethodInfoPtr_get_yyyz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672063);
			uint4.NativeMethodInfoPtr_get_yyyw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672064);
			uint4.NativeMethodInfoPtr_get_yyzx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672065);
			uint4.NativeMethodInfoPtr_get_yyzy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672066);
			uint4.NativeMethodInfoPtr_get_yyzz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672067);
			uint4.NativeMethodInfoPtr_get_yyzw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672068);
			uint4.NativeMethodInfoPtr_get_yywx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672069);
			uint4.NativeMethodInfoPtr_get_yywy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672070);
			uint4.NativeMethodInfoPtr_get_yywz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672071);
			uint4.NativeMethodInfoPtr_get_yyww_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672072);
			uint4.NativeMethodInfoPtr_get_yzxx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672073);
			uint4.NativeMethodInfoPtr_get_yzxy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672074);
			uint4.NativeMethodInfoPtr_get_yzxz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672075);
			uint4.NativeMethodInfoPtr_get_yzxw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672076);
			uint4.NativeMethodInfoPtr_set_yzxw_Public_set_Void_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672077);
			uint4.NativeMethodInfoPtr_get_yzyx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672078);
			uint4.NativeMethodInfoPtr_get_yzyy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672079);
			uint4.NativeMethodInfoPtr_get_yzyz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672080);
			uint4.NativeMethodInfoPtr_get_yzyw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672081);
			uint4.NativeMethodInfoPtr_get_yzzx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672082);
			uint4.NativeMethodInfoPtr_get_yzzy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672083);
			uint4.NativeMethodInfoPtr_get_yzzz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672084);
			uint4.NativeMethodInfoPtr_get_yzzw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672085);
			uint4.NativeMethodInfoPtr_get_yzwx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672086);
			uint4.NativeMethodInfoPtr_set_yzwx_Public_set_Void_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672087);
			uint4.NativeMethodInfoPtr_get_yzwy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672088);
			uint4.NativeMethodInfoPtr_get_yzwz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672089);
			uint4.NativeMethodInfoPtr_get_yzww_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672090);
			uint4.NativeMethodInfoPtr_get_ywxx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672091);
			uint4.NativeMethodInfoPtr_get_ywxy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672092);
			uint4.NativeMethodInfoPtr_get_ywxz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672093);
			uint4.NativeMethodInfoPtr_set_ywxz_Public_set_Void_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672094);
			uint4.NativeMethodInfoPtr_get_ywxw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672095);
			uint4.NativeMethodInfoPtr_get_ywyx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672096);
			uint4.NativeMethodInfoPtr_get_ywyy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672097);
			uint4.NativeMethodInfoPtr_get_ywyz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672098);
			uint4.NativeMethodInfoPtr_get_ywyw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672099);
			uint4.NativeMethodInfoPtr_get_ywzx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672100);
			uint4.NativeMethodInfoPtr_set_ywzx_Public_set_Void_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672101);
			uint4.NativeMethodInfoPtr_get_ywzy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672102);
			uint4.NativeMethodInfoPtr_get_ywzz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672103);
			uint4.NativeMethodInfoPtr_get_ywzw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672104);
			uint4.NativeMethodInfoPtr_get_ywwx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672105);
			uint4.NativeMethodInfoPtr_get_ywwy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672106);
			uint4.NativeMethodInfoPtr_get_ywwz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672107);
			uint4.NativeMethodInfoPtr_get_ywww_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672108);
			uint4.NativeMethodInfoPtr_get_zxxx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672109);
			uint4.NativeMethodInfoPtr_get_zxxy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672110);
			uint4.NativeMethodInfoPtr_get_zxxz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672111);
			uint4.NativeMethodInfoPtr_get_zxxw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672112);
			uint4.NativeMethodInfoPtr_get_zxyx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672113);
			uint4.NativeMethodInfoPtr_get_zxyy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672114);
			uint4.NativeMethodInfoPtr_get_zxyz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672115);
			uint4.NativeMethodInfoPtr_get_zxyw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672116);
			uint4.NativeMethodInfoPtr_set_zxyw_Public_set_Void_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672117);
			uint4.NativeMethodInfoPtr_get_zxzx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672118);
			uint4.NativeMethodInfoPtr_get_zxzy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672119);
			uint4.NativeMethodInfoPtr_get_zxzz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672120);
			uint4.NativeMethodInfoPtr_get_zxzw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672121);
			uint4.NativeMethodInfoPtr_get_zxwx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672122);
			uint4.NativeMethodInfoPtr_get_zxwy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672123);
			uint4.NativeMethodInfoPtr_set_zxwy_Public_set_Void_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672124);
			uint4.NativeMethodInfoPtr_get_zxwz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672125);
			uint4.NativeMethodInfoPtr_get_zxww_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672126);
			uint4.NativeMethodInfoPtr_get_zyxx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672127);
			uint4.NativeMethodInfoPtr_get_zyxy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672128);
			uint4.NativeMethodInfoPtr_get_zyxz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672129);
			uint4.NativeMethodInfoPtr_get_zyxw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672130);
			uint4.NativeMethodInfoPtr_set_zyxw_Public_set_Void_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672131);
			uint4.NativeMethodInfoPtr_get_zyyx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672132);
			uint4.NativeMethodInfoPtr_get_zyyy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672133);
			uint4.NativeMethodInfoPtr_get_zyyz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672134);
			uint4.NativeMethodInfoPtr_get_zyyw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672135);
			uint4.NativeMethodInfoPtr_get_zyzx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672136);
			uint4.NativeMethodInfoPtr_get_zyzy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672137);
			uint4.NativeMethodInfoPtr_get_zyzz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672138);
			uint4.NativeMethodInfoPtr_get_zyzw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672139);
			uint4.NativeMethodInfoPtr_get_zywx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672140);
			uint4.NativeMethodInfoPtr_set_zywx_Public_set_Void_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672141);
			uint4.NativeMethodInfoPtr_get_zywy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672142);
			uint4.NativeMethodInfoPtr_get_zywz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672143);
			uint4.NativeMethodInfoPtr_get_zyww_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672144);
			uint4.NativeMethodInfoPtr_get_zzxx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672145);
			uint4.NativeMethodInfoPtr_get_zzxy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672146);
			uint4.NativeMethodInfoPtr_get_zzxz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672147);
			uint4.NativeMethodInfoPtr_get_zzxw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672148);
			uint4.NativeMethodInfoPtr_get_zzyx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672149);
			uint4.NativeMethodInfoPtr_get_zzyy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672150);
			uint4.NativeMethodInfoPtr_get_zzyz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672151);
			uint4.NativeMethodInfoPtr_get_zzyw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672152);
			uint4.NativeMethodInfoPtr_get_zzzx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672153);
			uint4.NativeMethodInfoPtr_get_zzzy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672154);
			uint4.NativeMethodInfoPtr_get_zzzz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672155);
			uint4.NativeMethodInfoPtr_get_zzzw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672156);
			uint4.NativeMethodInfoPtr_get_zzwx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672157);
			uint4.NativeMethodInfoPtr_get_zzwy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672158);
			uint4.NativeMethodInfoPtr_get_zzwz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672159);
			uint4.NativeMethodInfoPtr_get_zzww_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672160);
			uint4.NativeMethodInfoPtr_get_zwxx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672161);
			uint4.NativeMethodInfoPtr_get_zwxy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672162);
			uint4.NativeMethodInfoPtr_set_zwxy_Public_set_Void_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672163);
			uint4.NativeMethodInfoPtr_get_zwxz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672164);
			uint4.NativeMethodInfoPtr_get_zwxw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672165);
			uint4.NativeMethodInfoPtr_get_zwyx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672166);
			uint4.NativeMethodInfoPtr_set_zwyx_Public_set_Void_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672167);
			uint4.NativeMethodInfoPtr_get_zwyy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672168);
			uint4.NativeMethodInfoPtr_get_zwyz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672169);
			uint4.NativeMethodInfoPtr_get_zwyw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672170);
			uint4.NativeMethodInfoPtr_get_zwzx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672171);
			uint4.NativeMethodInfoPtr_get_zwzy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672172);
			uint4.NativeMethodInfoPtr_get_zwzz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672173);
			uint4.NativeMethodInfoPtr_get_zwzw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672174);
			uint4.NativeMethodInfoPtr_get_zwwx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672175);
			uint4.NativeMethodInfoPtr_get_zwwy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672176);
			uint4.NativeMethodInfoPtr_get_zwwz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672177);
			uint4.NativeMethodInfoPtr_get_zwww_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672178);
			uint4.NativeMethodInfoPtr_get_wxxx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672179);
			uint4.NativeMethodInfoPtr_get_wxxy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672180);
			uint4.NativeMethodInfoPtr_get_wxxz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672181);
			uint4.NativeMethodInfoPtr_get_wxxw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672182);
			uint4.NativeMethodInfoPtr_get_wxyx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672183);
			uint4.NativeMethodInfoPtr_get_wxyy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672184);
			uint4.NativeMethodInfoPtr_get_wxyz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672185);
			uint4.NativeMethodInfoPtr_set_wxyz_Public_set_Void_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672186);
			uint4.NativeMethodInfoPtr_get_wxyw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672187);
			uint4.NativeMethodInfoPtr_get_wxzx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672188);
			uint4.NativeMethodInfoPtr_get_wxzy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672189);
			uint4.NativeMethodInfoPtr_set_wxzy_Public_set_Void_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672190);
			uint4.NativeMethodInfoPtr_get_wxzz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672191);
			uint4.NativeMethodInfoPtr_get_wxzw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672192);
			uint4.NativeMethodInfoPtr_get_wxwx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672193);
			uint4.NativeMethodInfoPtr_get_wxwy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672194);
			uint4.NativeMethodInfoPtr_get_wxwz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672195);
			uint4.NativeMethodInfoPtr_get_wxww_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672196);
			uint4.NativeMethodInfoPtr_get_wyxx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672197);
			uint4.NativeMethodInfoPtr_get_wyxy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672198);
			uint4.NativeMethodInfoPtr_get_wyxz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672199);
			uint4.NativeMethodInfoPtr_set_wyxz_Public_set_Void_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672200);
			uint4.NativeMethodInfoPtr_get_wyxw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672201);
			uint4.NativeMethodInfoPtr_get_wyyx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672202);
			uint4.NativeMethodInfoPtr_get_wyyy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672203);
			uint4.NativeMethodInfoPtr_get_wyyz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672204);
			uint4.NativeMethodInfoPtr_get_wyyw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672205);
			uint4.NativeMethodInfoPtr_get_wyzx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672206);
			uint4.NativeMethodInfoPtr_set_wyzx_Public_set_Void_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672207);
			uint4.NativeMethodInfoPtr_get_wyzy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672208);
			uint4.NativeMethodInfoPtr_get_wyzz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672209);
			uint4.NativeMethodInfoPtr_get_wyzw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672210);
			uint4.NativeMethodInfoPtr_get_wywx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672211);
			uint4.NativeMethodInfoPtr_get_wywy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672212);
			uint4.NativeMethodInfoPtr_get_wywz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672213);
			uint4.NativeMethodInfoPtr_get_wyww_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672214);
			uint4.NativeMethodInfoPtr_get_wzxx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672215);
			uint4.NativeMethodInfoPtr_get_wzxy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672216);
			uint4.NativeMethodInfoPtr_set_wzxy_Public_set_Void_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672217);
			uint4.NativeMethodInfoPtr_get_wzxz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672218);
			uint4.NativeMethodInfoPtr_get_wzxw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672219);
			uint4.NativeMethodInfoPtr_get_wzyx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672220);
			uint4.NativeMethodInfoPtr_set_wzyx_Public_set_Void_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672221);
			uint4.NativeMethodInfoPtr_get_wzyy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672222);
			uint4.NativeMethodInfoPtr_get_wzyz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672223);
			uint4.NativeMethodInfoPtr_get_wzyw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672224);
			uint4.NativeMethodInfoPtr_get_wzzx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672225);
			uint4.NativeMethodInfoPtr_get_wzzy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672226);
			uint4.NativeMethodInfoPtr_get_wzzz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672227);
			uint4.NativeMethodInfoPtr_get_wzzw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672228);
			uint4.NativeMethodInfoPtr_get_wzwx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672229);
			uint4.NativeMethodInfoPtr_get_wzwy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672230);
			uint4.NativeMethodInfoPtr_get_wzwz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672231);
			uint4.NativeMethodInfoPtr_get_wzww_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672232);
			uint4.NativeMethodInfoPtr_get_wwxx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672233);
			uint4.NativeMethodInfoPtr_get_wwxy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672234);
			uint4.NativeMethodInfoPtr_get_wwxz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672235);
			uint4.NativeMethodInfoPtr_get_wwxw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672236);
			uint4.NativeMethodInfoPtr_get_wwyx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672237);
			uint4.NativeMethodInfoPtr_get_wwyy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672238);
			uint4.NativeMethodInfoPtr_get_wwyz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672239);
			uint4.NativeMethodInfoPtr_get_wwyw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672240);
			uint4.NativeMethodInfoPtr_get_wwzx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672241);
			uint4.NativeMethodInfoPtr_get_wwzy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672242);
			uint4.NativeMethodInfoPtr_get_wwzz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672243);
			uint4.NativeMethodInfoPtr_get_wwzw_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672244);
			uint4.NativeMethodInfoPtr_get_wwwx_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672245);
			uint4.NativeMethodInfoPtr_get_wwwy_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672246);
			uint4.NativeMethodInfoPtr_get_wwwz_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672247);
			uint4.NativeMethodInfoPtr_get_wwww_Public_get_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672248);
			uint4.NativeMethodInfoPtr_get_xxx_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672249);
			uint4.NativeMethodInfoPtr_get_xxy_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672250);
			uint4.NativeMethodInfoPtr_get_xxz_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672251);
			uint4.NativeMethodInfoPtr_get_xxw_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672252);
			uint4.NativeMethodInfoPtr_get_xyx_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672253);
			uint4.NativeMethodInfoPtr_get_xyy_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672254);
			uint4.NativeMethodInfoPtr_get_xyz_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672255);
			uint4.NativeMethodInfoPtr_set_xyz_Public_set_Void_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672256);
			uint4.NativeMethodInfoPtr_get_xyw_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672257);
			uint4.NativeMethodInfoPtr_set_xyw_Public_set_Void_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672258);
			uint4.NativeMethodInfoPtr_get_xzx_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672259);
			uint4.NativeMethodInfoPtr_get_xzy_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672260);
			uint4.NativeMethodInfoPtr_set_xzy_Public_set_Void_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672261);
			uint4.NativeMethodInfoPtr_get_xzz_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672262);
			uint4.NativeMethodInfoPtr_get_xzw_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672263);
			uint4.NativeMethodInfoPtr_set_xzw_Public_set_Void_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672264);
			uint4.NativeMethodInfoPtr_get_xwx_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672265);
			uint4.NativeMethodInfoPtr_get_xwy_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672266);
			uint4.NativeMethodInfoPtr_set_xwy_Public_set_Void_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672267);
			uint4.NativeMethodInfoPtr_get_xwz_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672268);
			uint4.NativeMethodInfoPtr_set_xwz_Public_set_Void_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672269);
			uint4.NativeMethodInfoPtr_get_xww_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672270);
			uint4.NativeMethodInfoPtr_get_yxx_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672271);
			uint4.NativeMethodInfoPtr_get_yxy_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672272);
			uint4.NativeMethodInfoPtr_get_yxz_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672273);
			uint4.NativeMethodInfoPtr_set_yxz_Public_set_Void_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672274);
			uint4.NativeMethodInfoPtr_get_yxw_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672275);
			uint4.NativeMethodInfoPtr_set_yxw_Public_set_Void_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672276);
			uint4.NativeMethodInfoPtr_get_yyx_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672277);
			uint4.NativeMethodInfoPtr_get_yyy_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672278);
			uint4.NativeMethodInfoPtr_get_yyz_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672279);
			uint4.NativeMethodInfoPtr_get_yyw_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672280);
			uint4.NativeMethodInfoPtr_get_yzx_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672281);
			uint4.NativeMethodInfoPtr_set_yzx_Public_set_Void_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672282);
			uint4.NativeMethodInfoPtr_get_yzy_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672283);
			uint4.NativeMethodInfoPtr_get_yzz_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672284);
			uint4.NativeMethodInfoPtr_get_yzw_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672285);
			uint4.NativeMethodInfoPtr_set_yzw_Public_set_Void_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672286);
			uint4.NativeMethodInfoPtr_get_ywx_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672287);
			uint4.NativeMethodInfoPtr_set_ywx_Public_set_Void_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672288);
			uint4.NativeMethodInfoPtr_get_ywy_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672289);
			uint4.NativeMethodInfoPtr_get_ywz_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672290);
			uint4.NativeMethodInfoPtr_set_ywz_Public_set_Void_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672291);
			uint4.NativeMethodInfoPtr_get_yww_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672292);
			uint4.NativeMethodInfoPtr_get_zxx_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672293);
			uint4.NativeMethodInfoPtr_get_zxy_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672294);
			uint4.NativeMethodInfoPtr_set_zxy_Public_set_Void_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672295);
			uint4.NativeMethodInfoPtr_get_zxz_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672296);
			uint4.NativeMethodInfoPtr_get_zxw_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672297);
			uint4.NativeMethodInfoPtr_set_zxw_Public_set_Void_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672298);
			uint4.NativeMethodInfoPtr_get_zyx_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672299);
			uint4.NativeMethodInfoPtr_set_zyx_Public_set_Void_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672300);
			uint4.NativeMethodInfoPtr_get_zyy_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672301);
			uint4.NativeMethodInfoPtr_get_zyz_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672302);
			uint4.NativeMethodInfoPtr_get_zyw_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672303);
			uint4.NativeMethodInfoPtr_set_zyw_Public_set_Void_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672304);
			uint4.NativeMethodInfoPtr_get_zzx_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672305);
			uint4.NativeMethodInfoPtr_get_zzy_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672306);
			uint4.NativeMethodInfoPtr_get_zzz_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672307);
			uint4.NativeMethodInfoPtr_get_zzw_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672308);
			uint4.NativeMethodInfoPtr_get_zwx_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672309);
			uint4.NativeMethodInfoPtr_set_zwx_Public_set_Void_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672310);
			uint4.NativeMethodInfoPtr_get_zwy_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672311);
			uint4.NativeMethodInfoPtr_set_zwy_Public_set_Void_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672312);
			uint4.NativeMethodInfoPtr_get_zwz_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672313);
			uint4.NativeMethodInfoPtr_get_zww_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672314);
			uint4.NativeMethodInfoPtr_get_wxx_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672315);
			uint4.NativeMethodInfoPtr_get_wxy_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672316);
			uint4.NativeMethodInfoPtr_set_wxy_Public_set_Void_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672317);
			uint4.NativeMethodInfoPtr_get_wxz_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672318);
			uint4.NativeMethodInfoPtr_set_wxz_Public_set_Void_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672319);
			uint4.NativeMethodInfoPtr_get_wxw_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672320);
			uint4.NativeMethodInfoPtr_get_wyx_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672321);
			uint4.NativeMethodInfoPtr_set_wyx_Public_set_Void_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672322);
			uint4.NativeMethodInfoPtr_get_wyy_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672323);
			uint4.NativeMethodInfoPtr_get_wyz_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672324);
			uint4.NativeMethodInfoPtr_set_wyz_Public_set_Void_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672325);
			uint4.NativeMethodInfoPtr_get_wyw_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672326);
			uint4.NativeMethodInfoPtr_get_wzx_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672327);
			uint4.NativeMethodInfoPtr_set_wzx_Public_set_Void_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672328);
			uint4.NativeMethodInfoPtr_get_wzy_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672329);
			uint4.NativeMethodInfoPtr_set_wzy_Public_set_Void_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672330);
			uint4.NativeMethodInfoPtr_get_wzz_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672331);
			uint4.NativeMethodInfoPtr_get_wzw_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672332);
			uint4.NativeMethodInfoPtr_get_wwx_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672333);
			uint4.NativeMethodInfoPtr_get_wwy_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672334);
			uint4.NativeMethodInfoPtr_get_wwz_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672335);
			uint4.NativeMethodInfoPtr_get_www_Public_get_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672336);
			uint4.NativeMethodInfoPtr_get_xx_Public_get_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672337);
			uint4.NativeMethodInfoPtr_get_xy_Public_get_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672338);
			uint4.NativeMethodInfoPtr_set_xy_Public_set_Void_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672339);
			uint4.NativeMethodInfoPtr_get_xz_Public_get_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672340);
			uint4.NativeMethodInfoPtr_set_xz_Public_set_Void_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672341);
			uint4.NativeMethodInfoPtr_get_xw_Public_get_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672342);
			uint4.NativeMethodInfoPtr_set_xw_Public_set_Void_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672343);
			uint4.NativeMethodInfoPtr_get_yx_Public_get_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672344);
			uint4.NativeMethodInfoPtr_set_yx_Public_set_Void_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672345);
			uint4.NativeMethodInfoPtr_get_yy_Public_get_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672346);
			uint4.NativeMethodInfoPtr_get_yz_Public_get_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672347);
			uint4.NativeMethodInfoPtr_set_yz_Public_set_Void_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672348);
			uint4.NativeMethodInfoPtr_get_yw_Public_get_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672349);
			uint4.NativeMethodInfoPtr_set_yw_Public_set_Void_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672350);
			uint4.NativeMethodInfoPtr_get_zx_Public_get_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672351);
			uint4.NativeMethodInfoPtr_set_zx_Public_set_Void_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672352);
			uint4.NativeMethodInfoPtr_get_zy_Public_get_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672353);
			uint4.NativeMethodInfoPtr_set_zy_Public_set_Void_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672354);
			uint4.NativeMethodInfoPtr_get_zz_Public_get_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672355);
			uint4.NativeMethodInfoPtr_get_zw_Public_get_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672356);
			uint4.NativeMethodInfoPtr_set_zw_Public_set_Void_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672357);
			uint4.NativeMethodInfoPtr_get_wx_Public_get_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672358);
			uint4.NativeMethodInfoPtr_set_wx_Public_set_Void_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672359);
			uint4.NativeMethodInfoPtr_get_wy_Public_get_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672360);
			uint4.NativeMethodInfoPtr_set_wy_Public_set_Void_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672361);
			uint4.NativeMethodInfoPtr_get_wz_Public_get_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672362);
			uint4.NativeMethodInfoPtr_set_wz_Public_set_Void_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672363);
			uint4.NativeMethodInfoPtr_get_ww_Public_get_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672364);
			uint4.NativeMethodInfoPtr_get_Item_Public_get_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672365);
			uint4.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672366);
			uint4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672367);
			uint4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672368);
			uint4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672369);
			uint4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672370);
			uint4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4>.NativeClassPtr, 100672371);
		}

		// Token: 0x060022A8 RID: 8872 RVA: 0x000B6AA4 File Offset: 0x000B4CA4
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 608741, RefRangeEnd = 608768, XrefRangeStart = 608741, XrefRangeEnd = 608768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint4(uint x, uint y, uint z, uint w)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022A9 RID: 8873 RVA: 0x000B6B00 File Offset: 0x000B4D00
		[CallerCount(0)]
		public unsafe uint4(uint x, uint y, uint2 zw)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_uint2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022AA RID: 8874 RVA: 0x000B6B50 File Offset: 0x000B4D50
		[CallerCount(0)]
		public unsafe uint4(uint x, uint2 yz, uint w)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_uint2_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022AB RID: 8875 RVA: 0x000B6BA0 File Offset: 0x000B4DA0
		[CallerCount(0)]
		public unsafe uint4(uint x, uint3 yzw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yzw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_uint3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022AC RID: 8876 RVA: 0x000B6BE0 File Offset: 0x000B4DE0
		[CallerCount(0)]
		public unsafe uint4(uint2 xy, uint z, uint w)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr__ctor_Public_Void_uint2_UInt32_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022AD RID: 8877 RVA: 0x000B6C30 File Offset: 0x000B4E30
		[CallerCount(0)]
		public unsafe uint4(uint2 xy, uint2 zw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xy;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr__ctor_Public_Void_uint2_uint2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022AE RID: 8878 RVA: 0x000B6C70 File Offset: 0x000B4E70
		[CallerCount(0)]
		public unsafe uint4(uint3 xyz, uint w)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr__ctor_Public_Void_uint3_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022AF RID: 8879 RVA: 0x000B6CB0 File Offset: 0x000B4EB0
		[CallerCount(0)]
		public unsafe uint4(uint4 xyzw)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyzw;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr__ctor_Public_Void_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022B0 RID: 8880 RVA: 0x000B6CE4 File Offset: 0x000B4EE4
		[CallerCount(0)]
		public unsafe uint4(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022B1 RID: 8881 RVA: 0x000B6D18 File Offset: 0x000B4F18
		[CallerCount(0)]
		public unsafe uint4(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022B2 RID: 8882 RVA: 0x000B6D4C File Offset: 0x000B4F4C
		[CallerCount(0)]
		public unsafe uint4(bool4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr__ctor_Public_Void_bool4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022B3 RID: 8883 RVA: 0x000B6D80 File Offset: 0x000B4F80
		[CallerCount(0)]
		public unsafe uint4(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022B4 RID: 8884 RVA: 0x000B6DB4 File Offset: 0x000B4FB4
		[CallerCount(0)]
		public unsafe uint4(int4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr__ctor_Public_Void_int4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022B5 RID: 8885 RVA: 0x000B6DE8 File Offset: 0x000B4FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642198, XrefRangeEnd = 642201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint4(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022B6 RID: 8886 RVA: 0x000B6E1C File Offset: 0x000B501C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642201, XrefRangeEnd = 642204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint4(float4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr__ctor_Public_Void_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022B7 RID: 8887 RVA: 0x000B6E50 File Offset: 0x000B5050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642204, XrefRangeEnd = 642207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint4(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022B8 RID: 8888 RVA: 0x000B6E84 File Offset: 0x000B5084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642207, XrefRangeEnd = 642210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint4(double4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr__ctor_Public_Void_double4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022B9 RID: 8889 RVA: 0x000B6EB8 File Offset: 0x000B50B8
		[CallerCount(0)]
		public unsafe static implicit operator uint4(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_Implicit_Public_Static_uint4_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060022BA RID: 8890 RVA: 0x000B6EF8 File Offset: 0x000B50F8
		[CallerCount(0)]
		public unsafe static explicit operator uint4(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060022BB RID: 8891 RVA: 0x000B6F38 File Offset: 0x000B5138
		[CallerCount(0)]
		public unsafe static explicit operator uint4(bool4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4_bool4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060022BC RID: 8892 RVA: 0x000B6F78 File Offset: 0x000B5178
		[CallerCount(0)]
		public unsafe static explicit operator uint4(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060022BD RID: 8893 RVA: 0x000B6FB8 File Offset: 0x000B51B8
		[CallerCount(0)]
		public unsafe static explicit operator uint4(int4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4_int4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060022BE RID: 8894 RVA: 0x000B6FF8 File Offset: 0x000B51F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint4(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060022BF RID: 8895 RVA: 0x000B7038 File Offset: 0x000B5238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint4(float4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4_float4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060022C0 RID: 8896 RVA: 0x000B7078 File Offset: 0x000B5278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint4(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060022C1 RID: 8897 RVA: 0x000B70B8 File Offset: 0x000B52B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint4(double4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4_double4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060022C2 RID: 8898 RVA: 0x000B70F8 File Offset: 0x000B52F8
		[CallerCount(0)]
		public unsafe static uint4 operator *(uint4 lhs, uint4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_Multiply_Public_Static_uint4_uint4_uint4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022C3 RID: 8899 RVA: 0x000B7144 File Offset: 0x000B5344
		[CallerCount(0)]
		public unsafe static uint4 operator *(uint4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_Multiply_Public_Static_uint4_uint4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022C4 RID: 8900 RVA: 0x000B7190 File Offset: 0x000B5390
		[CallerCount(0)]
		public unsafe static uint4 operator *(uint lhs, uint4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_Multiply_Public_Static_uint4_UInt32_uint4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022C5 RID: 8901 RVA: 0x000B71DC File Offset: 0x000B53DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 639724, RefRangeEnd = 639726, XrefRangeStart = 639724, XrefRangeEnd = 639726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint4 operator +(uint4 lhs, uint4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_Addition_Public_Static_uint4_uint4_uint4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022C6 RID: 8902 RVA: 0x000B7228 File Offset: 0x000B5428
		[CallerCount(0)]
		public unsafe static uint4 operator +(uint4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_Addition_Public_Static_uint4_uint4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022C7 RID: 8903 RVA: 0x000B7274 File Offset: 0x000B5474
		[CallerCount(0)]
		public unsafe static uint4 operator +(uint lhs, uint4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_Addition_Public_Static_uint4_UInt32_uint4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022C8 RID: 8904 RVA: 0x000B72C0 File Offset: 0x000B54C0
		[CallerCount(0)]
		public unsafe static uint4 operator -(uint4 lhs, uint4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint4_uint4_uint4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022C9 RID: 8905 RVA: 0x000B730C File Offset: 0x000B550C
		[CallerCount(0)]
		public unsafe static uint4 operator -(uint4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint4_uint4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022CA RID: 8906 RVA: 0x000B7358 File Offset: 0x000B5558
		[CallerCount(0)]
		public unsafe static uint4 operator -(uint lhs, uint4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint4_UInt32_uint4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022CB RID: 8907 RVA: 0x000B73A4 File Offset: 0x000B55A4
		[CallerCount(0)]
		public unsafe static uint4 operator /(uint4 lhs, uint4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_Division_Public_Static_uint4_uint4_uint4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022CC RID: 8908 RVA: 0x000B73F0 File Offset: 0x000B55F0
		[CallerCount(0)]
		public unsafe static uint4 operator /(uint4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_Division_Public_Static_uint4_uint4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022CD RID: 8909 RVA: 0x000B743C File Offset: 0x000B563C
		[CallerCount(0)]
		public unsafe static uint4 operator /(uint lhs, uint4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_Division_Public_Static_uint4_UInt32_uint4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022CE RID: 8910 RVA: 0x000B7488 File Offset: 0x000B5688
		[CallerCount(0)]
		public unsafe static uint4 operator %(uint4 lhs, uint4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_Modulus_Public_Static_uint4_uint4_uint4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022CF RID: 8911 RVA: 0x000B74D4 File Offset: 0x000B56D4
		[CallerCount(0)]
		public unsafe static uint4 operator %(uint4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_Modulus_Public_Static_uint4_uint4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022D0 RID: 8912 RVA: 0x000B7520 File Offset: 0x000B5720
		[CallerCount(0)]
		public unsafe static uint4 operator %(uint lhs, uint4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_Modulus_Public_Static_uint4_UInt32_uint4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022D1 RID: 8913 RVA: 0x000B756C File Offset: 0x000B576C
		[CallerCount(0)]
		public unsafe static uint4 operator ++(uint4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_Increment_Public_Static_uint4_uint4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060022D2 RID: 8914 RVA: 0x000B75AC File Offset: 0x000B57AC
		[CallerCount(0)]
		public unsafe static uint4 operator --(uint4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_Decrement_Public_Static_uint4_uint4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060022D3 RID: 8915 RVA: 0x000B75EC File Offset: 0x000B57EC
		[CallerCount(0)]
		public unsafe static bool4 operator <(uint4 lhs, uint4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4_uint4_uint4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022D4 RID: 8916 RVA: 0x000B7638 File Offset: 0x000B5838
		[CallerCount(0)]
		public unsafe static bool4 operator <(uint4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4_uint4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022D5 RID: 8917 RVA: 0x000B7684 File Offset: 0x000B5884
		[CallerCount(0)]
		public unsafe static bool4 operator <(uint lhs, uint4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4_UInt32_uint4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022D6 RID: 8918 RVA: 0x000B76D0 File Offset: 0x000B58D0
		[CallerCount(0)]
		public unsafe static bool4 operator <=(uint4 lhs, uint4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4_uint4_uint4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022D7 RID: 8919 RVA: 0x000B771C File Offset: 0x000B591C
		[CallerCount(0)]
		public unsafe static bool4 operator <=(uint4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4_uint4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022D8 RID: 8920 RVA: 0x000B7768 File Offset: 0x000B5968
		[CallerCount(0)]
		public unsafe static bool4 operator <=(uint lhs, uint4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4_UInt32_uint4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022D9 RID: 8921 RVA: 0x000B77B4 File Offset: 0x000B59B4
		[CallerCount(0)]
		public unsafe static bool4 operator >(uint4 lhs, uint4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4_uint4_uint4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022DA RID: 8922 RVA: 0x000B7800 File Offset: 0x000B5A00
		[CallerCount(0)]
		public unsafe static bool4 operator >(uint4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4_uint4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022DB RID: 8923 RVA: 0x000B784C File Offset: 0x000B5A4C
		[CallerCount(0)]
		public unsafe static bool4 operator >(uint lhs, uint4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4_UInt32_uint4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022DC RID: 8924 RVA: 0x000B7898 File Offset: 0x000B5A98
		[CallerCount(0)]
		public unsafe static bool4 operator >=(uint4 lhs, uint4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4_uint4_uint4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022DD RID: 8925 RVA: 0x000B78E4 File Offset: 0x000B5AE4
		[CallerCount(0)]
		public unsafe static bool4 operator >=(uint4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4_uint4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022DE RID: 8926 RVA: 0x000B7930 File Offset: 0x000B5B30
		[CallerCount(0)]
		public unsafe static bool4 operator >=(uint lhs, uint4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4_UInt32_uint4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022DF RID: 8927 RVA: 0x000B797C File Offset: 0x000B5B7C
		[CallerCount(0)]
		public unsafe static uint4 operator -(uint4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_uint4_uint4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060022E0 RID: 8928 RVA: 0x000B79BC File Offset: 0x000B5BBC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 637974, RefRangeEnd = 637984, XrefRangeStart = 637974, XrefRangeEnd = 637984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint4 operator +(uint4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_uint4_uint4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060022E1 RID: 8929 RVA: 0x000B79FC File Offset: 0x000B5BFC
		[CallerCount(0)]
		public unsafe static uint4 operator <<(uint4 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_LeftShift_Public_Static_uint4_uint4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022E2 RID: 8930 RVA: 0x000B7A48 File Offset: 0x000B5C48
		[CallerCount(0)]
		public unsafe static uint4 operator >>(uint4 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_RightShift_Public_Static_uint4_uint4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022E3 RID: 8931 RVA: 0x000B7A94 File Offset: 0x000B5C94
		[CallerCount(0)]
		public unsafe static bool4 operator ==(uint4 lhs, uint4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4_uint4_uint4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022E4 RID: 8932 RVA: 0x000B7AE0 File Offset: 0x000B5CE0
		[CallerCount(0)]
		public unsafe static bool4 operator ==(uint4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4_uint4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022E5 RID: 8933 RVA: 0x000B7B2C File Offset: 0x000B5D2C
		[CallerCount(0)]
		public unsafe static bool4 operator ==(uint lhs, uint4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4_UInt32_uint4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022E6 RID: 8934 RVA: 0x000B7B78 File Offset: 0x000B5D78
		[CallerCount(0)]
		public unsafe static bool4 operator !=(uint4 lhs, uint4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_uint4_uint4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022E7 RID: 8935 RVA: 0x000B7BC4 File Offset: 0x000B5DC4
		[CallerCount(0)]
		public unsafe static bool4 operator !=(uint4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_uint4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022E8 RID: 8936 RVA: 0x000B7C10 File Offset: 0x000B5E10
		[CallerCount(0)]
		public unsafe static bool4 operator !=(uint lhs, uint4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_UInt32_uint4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022E9 RID: 8937 RVA: 0x000B7C5C File Offset: 0x000B5E5C
		[CallerCount(0)]
		public unsafe static uint4 operator ~(uint4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_OnesComplement_Public_Static_uint4_uint4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060022EA RID: 8938 RVA: 0x000B7C9C File Offset: 0x000B5E9C
		[CallerCount(0)]
		public unsafe static uint4 operator &(uint4 lhs, uint4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint4_uint4_uint4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022EB RID: 8939 RVA: 0x000B7CE8 File Offset: 0x000B5EE8
		[CallerCount(0)]
		public unsafe static uint4 operator &(uint4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint4_uint4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022EC RID: 8940 RVA: 0x000B7D34 File Offset: 0x000B5F34
		[CallerCount(0)]
		public unsafe static uint4 operator &(uint lhs, uint4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint4_UInt32_uint4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022ED RID: 8941 RVA: 0x000B7D80 File Offset: 0x000B5F80
		[CallerCount(0)]
		public unsafe static uint4 operator |(uint4 lhs, uint4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint4_uint4_uint4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022EE RID: 8942 RVA: 0x000B7DCC File Offset: 0x000B5FCC
		[CallerCount(0)]
		public unsafe static uint4 operator |(uint4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint4_uint4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022EF RID: 8943 RVA: 0x000B7E18 File Offset: 0x000B6018
		[CallerCount(0)]
		public unsafe static uint4 operator |(uint lhs, uint4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint4_UInt32_uint4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022F0 RID: 8944 RVA: 0x000B7E64 File Offset: 0x000B6064
		[CallerCount(0)]
		public unsafe static uint4 operator ^(uint4 lhs, uint4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint4_uint4_uint4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022F1 RID: 8945 RVA: 0x000B7EB0 File Offset: 0x000B60B0
		[CallerCount(0)]
		public unsafe static uint4 operator ^(uint4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint4_uint4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022F2 RID: 8946 RVA: 0x000B7EFC File Offset: 0x000B60FC
		[CallerCount(0)]
		public unsafe static uint4 operator ^(uint lhs, uint4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint4_UInt32_uint4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x060022F3 RID: 8947 RVA: 0x000B7F48 File Offset: 0x000B6148
		public unsafe uint4 xxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xxxx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x060022F4 RID: 8948 RVA: 0x000B7F78 File Offset: 0x000B6178
		public unsafe uint4 xxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xxxy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x060022F5 RID: 8949 RVA: 0x000B7FA8 File Offset: 0x000B61A8
		public unsafe uint4 xxxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xxxz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x060022F6 RID: 8950 RVA: 0x000B7FD8 File Offset: 0x000B61D8
		public unsafe uint4 xxxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xxxw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x060022F7 RID: 8951 RVA: 0x000B8008 File Offset: 0x000B6208
		public unsafe uint4 xxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xxyx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x060022F8 RID: 8952 RVA: 0x000B8038 File Offset: 0x000B6238
		public unsafe uint4 xxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xxyy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x060022F9 RID: 8953 RVA: 0x000B8068 File Offset: 0x000B6268
		public unsafe uint4 xxyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xxyz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x060022FA RID: 8954 RVA: 0x000B8098 File Offset: 0x000B6298
		public unsafe uint4 xxyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xxyw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x060022FB RID: 8955 RVA: 0x000B80C8 File Offset: 0x000B62C8
		public unsafe uint4 xxzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xxzx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x060022FC RID: 8956 RVA: 0x000B80F8 File Offset: 0x000B62F8
		public unsafe uint4 xxzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xxzy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x060022FD RID: 8957 RVA: 0x000B8128 File Offset: 0x000B6328
		public unsafe uint4 xxzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xxzz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x060022FE RID: 8958 RVA: 0x000B8158 File Offset: 0x000B6358
		public unsafe uint4 xxzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xxzw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x060022FF RID: 8959 RVA: 0x000B8188 File Offset: 0x000B6388
		public unsafe uint4 xxwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xxwx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x06002300 RID: 8960 RVA: 0x000B81B8 File Offset: 0x000B63B8
		public unsafe uint4 xxwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xxwy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x06002301 RID: 8961 RVA: 0x000B81E8 File Offset: 0x000B63E8
		public unsafe uint4 xxwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xxwz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x06002302 RID: 8962 RVA: 0x000B8218 File Offset: 0x000B6418
		public unsafe uint4 xxww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xxww_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x06002303 RID: 8963 RVA: 0x000B8248 File Offset: 0x000B6448
		public unsafe uint4 xyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xyxx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x06002304 RID: 8964 RVA: 0x000B8278 File Offset: 0x000B6478
		public unsafe uint4 xyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xyxy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x06002305 RID: 8965 RVA: 0x000B82A8 File Offset: 0x000B64A8
		public unsafe uint4 xyxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xyxz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x06002306 RID: 8966 RVA: 0x000B82D8 File Offset: 0x000B64D8
		public unsafe uint4 xyxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xyxw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x06002307 RID: 8967 RVA: 0x000B8308 File Offset: 0x000B6508
		public unsafe uint4 xyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xyyx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x06002308 RID: 8968 RVA: 0x000B8338 File Offset: 0x000B6538
		public unsafe uint4 xyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xyyy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x06002309 RID: 8969 RVA: 0x000B8368 File Offset: 0x000B6568
		public unsafe uint4 xyyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xyyz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x0600230A RID: 8970 RVA: 0x000B8398 File Offset: 0x000B6598
		public unsafe uint4 xyyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xyyw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x0600230B RID: 8971 RVA: 0x000B83C8 File Offset: 0x000B65C8
		public unsafe uint4 xyzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xyzx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x0600230C RID: 8972 RVA: 0x000B83F8 File Offset: 0x000B65F8
		public unsafe uint4 xyzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xyzy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x0600230D RID: 8973 RVA: 0x000B8428 File Offset: 0x000B6628
		public unsafe uint4 xyzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xyzz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x0600230E RID: 8974 RVA: 0x000B8458 File Offset: 0x000B6658
		// (set) Token: 0x0600230F RID: 8975 RVA: 0x000B8488 File Offset: 0x000B6688
		public unsafe uint4 xyzw
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 637974, RefRangeEnd = 637984, XrefRangeStart = 637974, XrefRangeEnd = 637984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xyzw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_xyzw_Public_set_Void_uint4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x06002310 RID: 8976 RVA: 0x000B84BC File Offset: 0x000B66BC
		public unsafe uint4 xywx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xywx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x06002311 RID: 8977 RVA: 0x000B84EC File Offset: 0x000B66EC
		public unsafe uint4 xywy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xywy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x06002312 RID: 8978 RVA: 0x000B851C File Offset: 0x000B671C
		// (set) Token: 0x06002313 RID: 8979 RVA: 0x000B854C File Offset: 0x000B674C
		public unsafe uint4 xywz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xywz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_xywz_Public_set_Void_uint4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x06002314 RID: 8980 RVA: 0x000B8580 File Offset: 0x000B6780
		public unsafe uint4 xyww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xyww_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x06002315 RID: 8981 RVA: 0x000B85B0 File Offset: 0x000B67B0
		public unsafe uint4 xzxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xzxx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x06002316 RID: 8982 RVA: 0x000B85E0 File Offset: 0x000B67E0
		public unsafe uint4 xzxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xzxy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x06002317 RID: 8983 RVA: 0x000B8610 File Offset: 0x000B6810
		public unsafe uint4 xzxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xzxz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x06002318 RID: 8984 RVA: 0x000B8640 File Offset: 0x000B6840
		public unsafe uint4 xzxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xzxw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x06002319 RID: 8985 RVA: 0x000B8670 File Offset: 0x000B6870
		public unsafe uint4 xzyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xzyx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x0600231A RID: 8986 RVA: 0x000B86A0 File Offset: 0x000B68A0
		public unsafe uint4 xzyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xzyy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x0600231B RID: 8987 RVA: 0x000B86D0 File Offset: 0x000B68D0
		public unsafe uint4 xzyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xzyz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x0600231C RID: 8988 RVA: 0x000B8700 File Offset: 0x000B6900
		// (set) Token: 0x0600231D RID: 8989 RVA: 0x000B8730 File Offset: 0x000B6930
		public unsafe uint4 xzyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xzyw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_xzyw_Public_set_Void_uint4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x0600231E RID: 8990 RVA: 0x000B8764 File Offset: 0x000B6964
		public unsafe uint4 xzzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xzzx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x0600231F RID: 8991 RVA: 0x000B8794 File Offset: 0x000B6994
		public unsafe uint4 xzzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xzzy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x06002320 RID: 8992 RVA: 0x000B87C4 File Offset: 0x000B69C4
		public unsafe uint4 xzzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xzzz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x06002321 RID: 8993 RVA: 0x000B87F4 File Offset: 0x000B69F4
		public unsafe uint4 xzzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xzzw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x06002322 RID: 8994 RVA: 0x000B8824 File Offset: 0x000B6A24
		public unsafe uint4 xzwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xzwx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x06002323 RID: 8995 RVA: 0x000B8854 File Offset: 0x000B6A54
		// (set) Token: 0x06002324 RID: 8996 RVA: 0x000B8884 File Offset: 0x000B6A84
		public unsafe uint4 xzwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xzwy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_xzwy_Public_set_Void_uint4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x06002325 RID: 8997 RVA: 0x000B88B8 File Offset: 0x000B6AB8
		public unsafe uint4 xzwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xzwz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x06002326 RID: 8998 RVA: 0x000B88E8 File Offset: 0x000B6AE8
		public unsafe uint4 xzww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xzww_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x06002327 RID: 8999 RVA: 0x000B8918 File Offset: 0x000B6B18
		public unsafe uint4 xwxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xwxx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x06002328 RID: 9000 RVA: 0x000B8948 File Offset: 0x000B6B48
		public unsafe uint4 xwxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xwxy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x06002329 RID: 9001 RVA: 0x000B8978 File Offset: 0x000B6B78
		public unsafe uint4 xwxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xwxz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x0600232A RID: 9002 RVA: 0x000B89A8 File Offset: 0x000B6BA8
		public unsafe uint4 xwxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xwxw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x0600232B RID: 9003 RVA: 0x000B89D8 File Offset: 0x000B6BD8
		public unsafe uint4 xwyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xwyx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x0600232C RID: 9004 RVA: 0x000B8A08 File Offset: 0x000B6C08
		public unsafe uint4 xwyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xwyy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x0600232D RID: 9005 RVA: 0x000B8A38 File Offset: 0x000B6C38
		// (set) Token: 0x0600232E RID: 9006 RVA: 0x000B8A68 File Offset: 0x000B6C68
		public unsafe uint4 xwyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xwyz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_xwyz_Public_set_Void_uint4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x0600232F RID: 9007 RVA: 0x000B8A9C File Offset: 0x000B6C9C
		public unsafe uint4 xwyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xwyw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x06002330 RID: 9008 RVA: 0x000B8ACC File Offset: 0x000B6CCC
		public unsafe uint4 xwzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xwzx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x06002331 RID: 9009 RVA: 0x000B8AFC File Offset: 0x000B6CFC
		// (set) Token: 0x06002332 RID: 9010 RVA: 0x000B8B2C File Offset: 0x000B6D2C
		public unsafe uint4 xwzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xwzy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_xwzy_Public_set_Void_uint4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x06002333 RID: 9011 RVA: 0x000B8B60 File Offset: 0x000B6D60
		public unsafe uint4 xwzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xwzz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x06002334 RID: 9012 RVA: 0x000B8B90 File Offset: 0x000B6D90
		public unsafe uint4 xwzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xwzw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x06002335 RID: 9013 RVA: 0x000B8BC0 File Offset: 0x000B6DC0
		public unsafe uint4 xwwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xwwx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x06002336 RID: 9014 RVA: 0x000B8BF0 File Offset: 0x000B6DF0
		public unsafe uint4 xwwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xwwy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x06002337 RID: 9015 RVA: 0x000B8C20 File Offset: 0x000B6E20
		public unsafe uint4 xwwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xwwz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x06002338 RID: 9016 RVA: 0x000B8C50 File Offset: 0x000B6E50
		public unsafe uint4 xwww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xwww_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x06002339 RID: 9017 RVA: 0x000B8C80 File Offset: 0x000B6E80
		public unsafe uint4 yxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yxxx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x0600233A RID: 9018 RVA: 0x000B8CB0 File Offset: 0x000B6EB0
		public unsafe uint4 yxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yxxy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x0600233B RID: 9019 RVA: 0x000B8CE0 File Offset: 0x000B6EE0
		public unsafe uint4 yxxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yxxz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x0600233C RID: 9020 RVA: 0x000B8D10 File Offset: 0x000B6F10
		public unsafe uint4 yxxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yxxw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x0600233D RID: 9021 RVA: 0x000B8D40 File Offset: 0x000B6F40
		public unsafe uint4 yxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yxyx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x0600233E RID: 9022 RVA: 0x000B8D70 File Offset: 0x000B6F70
		public unsafe uint4 yxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yxyy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x0600233F RID: 9023 RVA: 0x000B8DA0 File Offset: 0x000B6FA0
		public unsafe uint4 yxyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yxyz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x06002340 RID: 9024 RVA: 0x000B8DD0 File Offset: 0x000B6FD0
		public unsafe uint4 yxyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yxyw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x06002341 RID: 9025 RVA: 0x000B8E00 File Offset: 0x000B7000
		public unsafe uint4 yxzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yxzx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x06002342 RID: 9026 RVA: 0x000B8E30 File Offset: 0x000B7030
		public unsafe uint4 yxzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yxzy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x06002343 RID: 9027 RVA: 0x000B8E60 File Offset: 0x000B7060
		public unsafe uint4 yxzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yxzz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x06002344 RID: 9028 RVA: 0x000B8E90 File Offset: 0x000B7090
		// (set) Token: 0x06002345 RID: 9029 RVA: 0x000B8EC0 File Offset: 0x000B70C0
		public unsafe uint4 yxzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yxzw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_yxzw_Public_set_Void_uint4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x06002346 RID: 9030 RVA: 0x000B8EF4 File Offset: 0x000B70F4
		public unsafe uint4 yxwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yxwx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x06002347 RID: 9031 RVA: 0x000B8F24 File Offset: 0x000B7124
		public unsafe uint4 yxwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yxwy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x06002348 RID: 9032 RVA: 0x000B8F54 File Offset: 0x000B7154
		// (set) Token: 0x06002349 RID: 9033 RVA: 0x000B8F84 File Offset: 0x000B7184
		public unsafe uint4 yxwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yxwz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_yxwz_Public_set_Void_uint4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x0600234A RID: 9034 RVA: 0x000B8FB8 File Offset: 0x000B71B8
		public unsafe uint4 yxww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yxww_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x0600234B RID: 9035 RVA: 0x000B8FE8 File Offset: 0x000B71E8
		public unsafe uint4 yyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yyxx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x0600234C RID: 9036 RVA: 0x000B9018 File Offset: 0x000B7218
		public unsafe uint4 yyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yyxy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x0600234D RID: 9037 RVA: 0x000B9048 File Offset: 0x000B7248
		public unsafe uint4 yyxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yyxz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x0600234E RID: 9038 RVA: 0x000B9078 File Offset: 0x000B7278
		public unsafe uint4 yyxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yyxw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x0600234F RID: 9039 RVA: 0x000B90A8 File Offset: 0x000B72A8
		public unsafe uint4 yyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yyyx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x06002350 RID: 9040 RVA: 0x000B90D8 File Offset: 0x000B72D8
		public unsafe uint4 yyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yyyy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x06002351 RID: 9041 RVA: 0x000B9108 File Offset: 0x000B7308
		public unsafe uint4 yyyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yyyz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x06002352 RID: 9042 RVA: 0x000B9138 File Offset: 0x000B7338
		public unsafe uint4 yyyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yyyw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x06002353 RID: 9043 RVA: 0x000B9168 File Offset: 0x000B7368
		public unsafe uint4 yyzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yyzx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x06002354 RID: 9044 RVA: 0x000B9198 File Offset: 0x000B7398
		public unsafe uint4 yyzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yyzy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x06002355 RID: 9045 RVA: 0x000B91C8 File Offset: 0x000B73C8
		public unsafe uint4 yyzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yyzz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x06002356 RID: 9046 RVA: 0x000B91F8 File Offset: 0x000B73F8
		public unsafe uint4 yyzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yyzw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x06002357 RID: 9047 RVA: 0x000B9228 File Offset: 0x000B7428
		public unsafe uint4 yywx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yywx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x06002358 RID: 9048 RVA: 0x000B9258 File Offset: 0x000B7458
		public unsafe uint4 yywy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yywy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x06002359 RID: 9049 RVA: 0x000B9288 File Offset: 0x000B7488
		public unsafe uint4 yywz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yywz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x0600235A RID: 9050 RVA: 0x000B92B8 File Offset: 0x000B74B8
		public unsafe uint4 yyww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yyww_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x0600235B RID: 9051 RVA: 0x000B92E8 File Offset: 0x000B74E8
		public unsafe uint4 yzxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yzxx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x0600235C RID: 9052 RVA: 0x000B9318 File Offset: 0x000B7518
		public unsafe uint4 yzxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yzxy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x0600235D RID: 9053 RVA: 0x000B9348 File Offset: 0x000B7548
		public unsafe uint4 yzxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yzxz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x0600235E RID: 9054 RVA: 0x000B9378 File Offset: 0x000B7578
		// (set) Token: 0x0600235F RID: 9055 RVA: 0x000B93A8 File Offset: 0x000B75A8
		public unsafe uint4 yzxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yzxw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_yzxw_Public_set_Void_uint4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x06002360 RID: 9056 RVA: 0x000B93DC File Offset: 0x000B75DC
		public unsafe uint4 yzyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yzyx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x06002361 RID: 9057 RVA: 0x000B940C File Offset: 0x000B760C
		public unsafe uint4 yzyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yzyy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x06002362 RID: 9058 RVA: 0x000B943C File Offset: 0x000B763C
		public unsafe uint4 yzyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yzyz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x06002363 RID: 9059 RVA: 0x000B946C File Offset: 0x000B766C
		public unsafe uint4 yzyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yzyw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x06002364 RID: 9060 RVA: 0x000B949C File Offset: 0x000B769C
		public unsafe uint4 yzzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yzzx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x06002365 RID: 9061 RVA: 0x000B94CC File Offset: 0x000B76CC
		public unsafe uint4 yzzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yzzy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x06002366 RID: 9062 RVA: 0x000B94FC File Offset: 0x000B76FC
		public unsafe uint4 yzzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yzzz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x06002367 RID: 9063 RVA: 0x000B952C File Offset: 0x000B772C
		public unsafe uint4 yzzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yzzw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x06002368 RID: 9064 RVA: 0x000B955C File Offset: 0x000B775C
		// (set) Token: 0x06002369 RID: 9065 RVA: 0x000B958C File Offset: 0x000B778C
		public unsafe uint4 yzwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yzwx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_yzwx_Public_set_Void_uint4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x0600236A RID: 9066 RVA: 0x000B95C0 File Offset: 0x000B77C0
		public unsafe uint4 yzwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yzwy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x0600236B RID: 9067 RVA: 0x000B95F0 File Offset: 0x000B77F0
		public unsafe uint4 yzwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yzwz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x0600236C RID: 9068 RVA: 0x000B9620 File Offset: 0x000B7820
		public unsafe uint4 yzww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yzww_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x0600236D RID: 9069 RVA: 0x000B9650 File Offset: 0x000B7850
		public unsafe uint4 ywxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_ywxx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x0600236E RID: 9070 RVA: 0x000B9680 File Offset: 0x000B7880
		public unsafe uint4 ywxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_ywxy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x0600236F RID: 9071 RVA: 0x000B96B0 File Offset: 0x000B78B0
		// (set) Token: 0x06002370 RID: 9072 RVA: 0x000B96E0 File Offset: 0x000B78E0
		public unsafe uint4 ywxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_ywxz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_ywxz_Public_set_Void_uint4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x06002371 RID: 9073 RVA: 0x000B9714 File Offset: 0x000B7914
		public unsafe uint4 ywxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_ywxw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x06002372 RID: 9074 RVA: 0x000B9744 File Offset: 0x000B7944
		public unsafe uint4 ywyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_ywyx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x06002373 RID: 9075 RVA: 0x000B9774 File Offset: 0x000B7974
		public unsafe uint4 ywyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_ywyy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x06002374 RID: 9076 RVA: 0x000B97A4 File Offset: 0x000B79A4
		public unsafe uint4 ywyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_ywyz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x06002375 RID: 9077 RVA: 0x000B97D4 File Offset: 0x000B79D4
		public unsafe uint4 ywyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_ywyw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x06002376 RID: 9078 RVA: 0x000B9804 File Offset: 0x000B7A04
		// (set) Token: 0x06002377 RID: 9079 RVA: 0x000B9834 File Offset: 0x000B7A34
		public unsafe uint4 ywzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_ywzx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_ywzx_Public_set_Void_uint4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x06002378 RID: 9080 RVA: 0x000B9868 File Offset: 0x000B7A68
		public unsafe uint4 ywzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_ywzy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x06002379 RID: 9081 RVA: 0x000B9898 File Offset: 0x000B7A98
		public unsafe uint4 ywzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_ywzz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x0600237A RID: 9082 RVA: 0x000B98C8 File Offset: 0x000B7AC8
		public unsafe uint4 ywzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_ywzw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x0600237B RID: 9083 RVA: 0x000B98F8 File Offset: 0x000B7AF8
		public unsafe uint4 ywwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_ywwx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x0600237C RID: 9084 RVA: 0x000B9928 File Offset: 0x000B7B28
		public unsafe uint4 ywwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_ywwy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x0600237D RID: 9085 RVA: 0x000B9958 File Offset: 0x000B7B58
		public unsafe uint4 ywwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_ywwz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x0600237E RID: 9086 RVA: 0x000B9988 File Offset: 0x000B7B88
		public unsafe uint4 ywww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_ywww_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x0600237F RID: 9087 RVA: 0x000B99B8 File Offset: 0x000B7BB8
		public unsafe uint4 zxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zxxx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x06002380 RID: 9088 RVA: 0x000B99E8 File Offset: 0x000B7BE8
		public unsafe uint4 zxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zxxy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x06002381 RID: 9089 RVA: 0x000B9A18 File Offset: 0x000B7C18
		public unsafe uint4 zxxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zxxz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x06002382 RID: 9090 RVA: 0x000B9A48 File Offset: 0x000B7C48
		public unsafe uint4 zxxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zxxw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x06002383 RID: 9091 RVA: 0x000B9A78 File Offset: 0x000B7C78
		public unsafe uint4 zxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zxyx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x06002384 RID: 9092 RVA: 0x000B9AA8 File Offset: 0x000B7CA8
		public unsafe uint4 zxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zxyy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x06002385 RID: 9093 RVA: 0x000B9AD8 File Offset: 0x000B7CD8
		public unsafe uint4 zxyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zxyz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x06002386 RID: 9094 RVA: 0x000B9B08 File Offset: 0x000B7D08
		// (set) Token: 0x06002387 RID: 9095 RVA: 0x000B9B38 File Offset: 0x000B7D38
		public unsafe uint4 zxyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zxyw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_zxyw_Public_set_Void_uint4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x06002388 RID: 9096 RVA: 0x000B9B6C File Offset: 0x000B7D6C
		public unsafe uint4 zxzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zxzx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x06002389 RID: 9097 RVA: 0x000B9B9C File Offset: 0x000B7D9C
		public unsafe uint4 zxzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zxzy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x0600238A RID: 9098 RVA: 0x000B9BCC File Offset: 0x000B7DCC
		public unsafe uint4 zxzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zxzz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x0600238B RID: 9099 RVA: 0x000B9BFC File Offset: 0x000B7DFC
		public unsafe uint4 zxzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zxzw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x0600238C RID: 9100 RVA: 0x000B9C2C File Offset: 0x000B7E2C
		public unsafe uint4 zxwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zxwx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x0600238D RID: 9101 RVA: 0x000B9C5C File Offset: 0x000B7E5C
		// (set) Token: 0x0600238E RID: 9102 RVA: 0x000B9C8C File Offset: 0x000B7E8C
		public unsafe uint4 zxwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zxwy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_zxwy_Public_set_Void_uint4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x0600238F RID: 9103 RVA: 0x000B9CC0 File Offset: 0x000B7EC0
		public unsafe uint4 zxwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zxwz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x06002390 RID: 9104 RVA: 0x000B9CF0 File Offset: 0x000B7EF0
		public unsafe uint4 zxww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zxww_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x06002391 RID: 9105 RVA: 0x000B9D20 File Offset: 0x000B7F20
		public unsafe uint4 zyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zyxx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x06002392 RID: 9106 RVA: 0x000B9D50 File Offset: 0x000B7F50
		public unsafe uint4 zyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zyxy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x06002393 RID: 9107 RVA: 0x000B9D80 File Offset: 0x000B7F80
		public unsafe uint4 zyxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zyxz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x06002394 RID: 9108 RVA: 0x000B9DB0 File Offset: 0x000B7FB0
		// (set) Token: 0x06002395 RID: 9109 RVA: 0x000B9DE0 File Offset: 0x000B7FE0
		public unsafe uint4 zyxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zyxw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_zyxw_Public_set_Void_uint4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x06002396 RID: 9110 RVA: 0x000B9E14 File Offset: 0x000B8014
		public unsafe uint4 zyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zyyx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x06002397 RID: 9111 RVA: 0x000B9E44 File Offset: 0x000B8044
		public unsafe uint4 zyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zyyy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x06002398 RID: 9112 RVA: 0x000B9E74 File Offset: 0x000B8074
		public unsafe uint4 zyyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zyyz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x06002399 RID: 9113 RVA: 0x000B9EA4 File Offset: 0x000B80A4
		public unsafe uint4 zyyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zyyw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x0600239A RID: 9114 RVA: 0x000B9ED4 File Offset: 0x000B80D4
		public unsafe uint4 zyzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zyzx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x0600239B RID: 9115 RVA: 0x000B9F04 File Offset: 0x000B8104
		public unsafe uint4 zyzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zyzy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x0600239C RID: 9116 RVA: 0x000B9F34 File Offset: 0x000B8134
		public unsafe uint4 zyzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zyzz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x0600239D RID: 9117 RVA: 0x000B9F64 File Offset: 0x000B8164
		public unsafe uint4 zyzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zyzw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x0600239E RID: 9118 RVA: 0x000B9F94 File Offset: 0x000B8194
		// (set) Token: 0x0600239F RID: 9119 RVA: 0x000B9FC4 File Offset: 0x000B81C4
		public unsafe uint4 zywx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zywx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_zywx_Public_set_Void_uint4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x060023A0 RID: 9120 RVA: 0x000B9FF8 File Offset: 0x000B81F8
		public unsafe uint4 zywy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zywy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x060023A1 RID: 9121 RVA: 0x000BA028 File Offset: 0x000B8228
		public unsafe uint4 zywz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zywz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x060023A2 RID: 9122 RVA: 0x000BA058 File Offset: 0x000B8258
		public unsafe uint4 zyww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zyww_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x060023A3 RID: 9123 RVA: 0x000BA088 File Offset: 0x000B8288
		public unsafe uint4 zzxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zzxx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x060023A4 RID: 9124 RVA: 0x000BA0B8 File Offset: 0x000B82B8
		public unsafe uint4 zzxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zzxy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x060023A5 RID: 9125 RVA: 0x000BA0E8 File Offset: 0x000B82E8
		public unsafe uint4 zzxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zzxz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x060023A6 RID: 9126 RVA: 0x000BA118 File Offset: 0x000B8318
		public unsafe uint4 zzxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zzxw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x060023A7 RID: 9127 RVA: 0x000BA148 File Offset: 0x000B8348
		public unsafe uint4 zzyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zzyx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x060023A8 RID: 9128 RVA: 0x000BA178 File Offset: 0x000B8378
		public unsafe uint4 zzyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zzyy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x060023A9 RID: 9129 RVA: 0x000BA1A8 File Offset: 0x000B83A8
		public unsafe uint4 zzyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zzyz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x060023AA RID: 9130 RVA: 0x000BA1D8 File Offset: 0x000B83D8
		public unsafe uint4 zzyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zzyw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x060023AB RID: 9131 RVA: 0x000BA208 File Offset: 0x000B8408
		public unsafe uint4 zzzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zzzx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x060023AC RID: 9132 RVA: 0x000BA238 File Offset: 0x000B8438
		public unsafe uint4 zzzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zzzy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x060023AD RID: 9133 RVA: 0x000BA268 File Offset: 0x000B8468
		public unsafe uint4 zzzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zzzz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x060023AE RID: 9134 RVA: 0x000BA298 File Offset: 0x000B8498
		public unsafe uint4 zzzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zzzw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x060023AF RID: 9135 RVA: 0x000BA2C8 File Offset: 0x000B84C8
		public unsafe uint4 zzwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zzwx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x060023B0 RID: 9136 RVA: 0x000BA2F8 File Offset: 0x000B84F8
		public unsafe uint4 zzwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zzwy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x060023B1 RID: 9137 RVA: 0x000BA328 File Offset: 0x000B8528
		public unsafe uint4 zzwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zzwz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x060023B2 RID: 9138 RVA: 0x000BA358 File Offset: 0x000B8558
		public unsafe uint4 zzww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zzww_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x060023B3 RID: 9139 RVA: 0x000BA388 File Offset: 0x000B8588
		public unsafe uint4 zwxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zwxx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x060023B4 RID: 9140 RVA: 0x000BA3B8 File Offset: 0x000B85B8
		// (set) Token: 0x060023B5 RID: 9141 RVA: 0x000BA3E8 File Offset: 0x000B85E8
		public unsafe uint4 zwxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zwxy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_zwxy_Public_set_Void_uint4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x060023B6 RID: 9142 RVA: 0x000BA41C File Offset: 0x000B861C
		public unsafe uint4 zwxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zwxz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x060023B7 RID: 9143 RVA: 0x000BA44C File Offset: 0x000B864C
		public unsafe uint4 zwxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zwxw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x060023B8 RID: 9144 RVA: 0x000BA47C File Offset: 0x000B867C
		// (set) Token: 0x060023B9 RID: 9145 RVA: 0x000BA4AC File Offset: 0x000B86AC
		public unsafe uint4 zwyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zwyx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_zwyx_Public_set_Void_uint4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x060023BA RID: 9146 RVA: 0x000BA4E0 File Offset: 0x000B86E0
		public unsafe uint4 zwyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zwyy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x060023BB RID: 9147 RVA: 0x000BA510 File Offset: 0x000B8710
		public unsafe uint4 zwyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zwyz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x060023BC RID: 9148 RVA: 0x000BA540 File Offset: 0x000B8740
		public unsafe uint4 zwyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zwyw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x060023BD RID: 9149 RVA: 0x000BA570 File Offset: 0x000B8770
		public unsafe uint4 zwzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zwzx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x060023BE RID: 9150 RVA: 0x000BA5A0 File Offset: 0x000B87A0
		public unsafe uint4 zwzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zwzy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x060023BF RID: 9151 RVA: 0x000BA5D0 File Offset: 0x000B87D0
		public unsafe uint4 zwzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zwzz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x060023C0 RID: 9152 RVA: 0x000BA600 File Offset: 0x000B8800
		public unsafe uint4 zwzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zwzw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x060023C1 RID: 9153 RVA: 0x000BA630 File Offset: 0x000B8830
		public unsafe uint4 zwwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zwwx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x060023C2 RID: 9154 RVA: 0x000BA660 File Offset: 0x000B8860
		public unsafe uint4 zwwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zwwy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x060023C3 RID: 9155 RVA: 0x000BA690 File Offset: 0x000B8890
		public unsafe uint4 zwwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zwwz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x060023C4 RID: 9156 RVA: 0x000BA6C0 File Offset: 0x000B88C0
		public unsafe uint4 zwww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zwww_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x060023C5 RID: 9157 RVA: 0x000BA6F0 File Offset: 0x000B88F0
		public unsafe uint4 wxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wxxx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x060023C6 RID: 9158 RVA: 0x000BA720 File Offset: 0x000B8920
		public unsafe uint4 wxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wxxy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x060023C7 RID: 9159 RVA: 0x000BA750 File Offset: 0x000B8950
		public unsafe uint4 wxxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wxxz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x060023C8 RID: 9160 RVA: 0x000BA780 File Offset: 0x000B8980
		public unsafe uint4 wxxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wxxw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x060023C9 RID: 9161 RVA: 0x000BA7B0 File Offset: 0x000B89B0
		public unsafe uint4 wxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wxyx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x060023CA RID: 9162 RVA: 0x000BA7E0 File Offset: 0x000B89E0
		public unsafe uint4 wxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wxyy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x060023CB RID: 9163 RVA: 0x000BA810 File Offset: 0x000B8A10
		// (set) Token: 0x060023CC RID: 9164 RVA: 0x000BA840 File Offset: 0x000B8A40
		public unsafe uint4 wxyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wxyz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_wxyz_Public_set_Void_uint4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x060023CD RID: 9165 RVA: 0x000BA874 File Offset: 0x000B8A74
		public unsafe uint4 wxyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wxyw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x060023CE RID: 9166 RVA: 0x000BA8A4 File Offset: 0x000B8AA4
		public unsafe uint4 wxzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wxzx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x060023CF RID: 9167 RVA: 0x000BA8D4 File Offset: 0x000B8AD4
		// (set) Token: 0x060023D0 RID: 9168 RVA: 0x000BA904 File Offset: 0x000B8B04
		public unsafe uint4 wxzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wxzy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_wxzy_Public_set_Void_uint4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x060023D1 RID: 9169 RVA: 0x000BA938 File Offset: 0x000B8B38
		public unsafe uint4 wxzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wxzz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x060023D2 RID: 9170 RVA: 0x000BA968 File Offset: 0x000B8B68
		public unsafe uint4 wxzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wxzw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x060023D3 RID: 9171 RVA: 0x000BA998 File Offset: 0x000B8B98
		public unsafe uint4 wxwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wxwx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x060023D4 RID: 9172 RVA: 0x000BA9C8 File Offset: 0x000B8BC8
		public unsafe uint4 wxwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wxwy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x060023D5 RID: 9173 RVA: 0x000BA9F8 File Offset: 0x000B8BF8
		public unsafe uint4 wxwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wxwz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x060023D6 RID: 9174 RVA: 0x000BAA28 File Offset: 0x000B8C28
		public unsafe uint4 wxww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wxww_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x060023D7 RID: 9175 RVA: 0x000BAA58 File Offset: 0x000B8C58
		public unsafe uint4 wyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wyxx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x060023D8 RID: 9176 RVA: 0x000BAA88 File Offset: 0x000B8C88
		public unsafe uint4 wyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wyxy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x060023D9 RID: 9177 RVA: 0x000BAAB8 File Offset: 0x000B8CB8
		// (set) Token: 0x060023DA RID: 9178 RVA: 0x000BAAE8 File Offset: 0x000B8CE8
		public unsafe uint4 wyxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wyxz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_wyxz_Public_set_Void_uint4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x060023DB RID: 9179 RVA: 0x000BAB1C File Offset: 0x000B8D1C
		public unsafe uint4 wyxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wyxw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x060023DC RID: 9180 RVA: 0x000BAB4C File Offset: 0x000B8D4C
		public unsafe uint4 wyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wyyx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x060023DD RID: 9181 RVA: 0x000BAB7C File Offset: 0x000B8D7C
		public unsafe uint4 wyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wyyy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x060023DE RID: 9182 RVA: 0x000BABAC File Offset: 0x000B8DAC
		public unsafe uint4 wyyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wyyz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x060023DF RID: 9183 RVA: 0x000BABDC File Offset: 0x000B8DDC
		public unsafe uint4 wyyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wyyw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x060023E0 RID: 9184 RVA: 0x000BAC0C File Offset: 0x000B8E0C
		// (set) Token: 0x060023E1 RID: 9185 RVA: 0x000BAC3C File Offset: 0x000B8E3C
		public unsafe uint4 wyzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wyzx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_wyzx_Public_set_Void_uint4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x060023E2 RID: 9186 RVA: 0x000BAC70 File Offset: 0x000B8E70
		public unsafe uint4 wyzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wyzy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x060023E3 RID: 9187 RVA: 0x000BACA0 File Offset: 0x000B8EA0
		public unsafe uint4 wyzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wyzz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x060023E4 RID: 9188 RVA: 0x000BACD0 File Offset: 0x000B8ED0
		public unsafe uint4 wyzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wyzw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x060023E5 RID: 9189 RVA: 0x000BAD00 File Offset: 0x000B8F00
		public unsafe uint4 wywx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wywx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x060023E6 RID: 9190 RVA: 0x000BAD30 File Offset: 0x000B8F30
		public unsafe uint4 wywy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wywy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x060023E7 RID: 9191 RVA: 0x000BAD60 File Offset: 0x000B8F60
		public unsafe uint4 wywz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wywz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x060023E8 RID: 9192 RVA: 0x000BAD90 File Offset: 0x000B8F90
		public unsafe uint4 wyww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wyww_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x060023E9 RID: 9193 RVA: 0x000BADC0 File Offset: 0x000B8FC0
		public unsafe uint4 wzxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wzxx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x060023EA RID: 9194 RVA: 0x000BADF0 File Offset: 0x000B8FF0
		// (set) Token: 0x060023EB RID: 9195 RVA: 0x000BAE20 File Offset: 0x000B9020
		public unsafe uint4 wzxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wzxy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_wzxy_Public_set_Void_uint4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x060023EC RID: 9196 RVA: 0x000BAE54 File Offset: 0x000B9054
		public unsafe uint4 wzxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wzxz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x060023ED RID: 9197 RVA: 0x000BAE84 File Offset: 0x000B9084
		public unsafe uint4 wzxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wzxw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x060023EE RID: 9198 RVA: 0x000BAEB4 File Offset: 0x000B90B4
		// (set) Token: 0x060023EF RID: 9199 RVA: 0x000BAEE4 File Offset: 0x000B90E4
		public unsafe uint4 wzyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wzyx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_wzyx_Public_set_Void_uint4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x060023F0 RID: 9200 RVA: 0x000BAF18 File Offset: 0x000B9118
		public unsafe uint4 wzyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wzyy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x060023F1 RID: 9201 RVA: 0x000BAF48 File Offset: 0x000B9148
		public unsafe uint4 wzyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wzyz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x060023F2 RID: 9202 RVA: 0x000BAF78 File Offset: 0x000B9178
		public unsafe uint4 wzyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wzyw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x060023F3 RID: 9203 RVA: 0x000BAFA8 File Offset: 0x000B91A8
		public unsafe uint4 wzzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wzzx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x060023F4 RID: 9204 RVA: 0x000BAFD8 File Offset: 0x000B91D8
		public unsafe uint4 wzzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wzzy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x060023F5 RID: 9205 RVA: 0x000BB008 File Offset: 0x000B9208
		public unsafe uint4 wzzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wzzz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x060023F6 RID: 9206 RVA: 0x000BB038 File Offset: 0x000B9238
		public unsafe uint4 wzzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wzzw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x060023F7 RID: 9207 RVA: 0x000BB068 File Offset: 0x000B9268
		public unsafe uint4 wzwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wzwx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x060023F8 RID: 9208 RVA: 0x000BB098 File Offset: 0x000B9298
		public unsafe uint4 wzwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wzwy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x060023F9 RID: 9209 RVA: 0x000BB0C8 File Offset: 0x000B92C8
		public unsafe uint4 wzwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wzwz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x060023FA RID: 9210 RVA: 0x000BB0F8 File Offset: 0x000B92F8
		public unsafe uint4 wzww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wzww_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x060023FB RID: 9211 RVA: 0x000BB128 File Offset: 0x000B9328
		public unsafe uint4 wwxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wwxx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x060023FC RID: 9212 RVA: 0x000BB158 File Offset: 0x000B9358
		public unsafe uint4 wwxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wwxy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x060023FD RID: 9213 RVA: 0x000BB188 File Offset: 0x000B9388
		public unsafe uint4 wwxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wwxz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x060023FE RID: 9214 RVA: 0x000BB1B8 File Offset: 0x000B93B8
		public unsafe uint4 wwxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wwxw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x060023FF RID: 9215 RVA: 0x000BB1E8 File Offset: 0x000B93E8
		public unsafe uint4 wwyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wwyx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x06002400 RID: 9216 RVA: 0x000BB218 File Offset: 0x000B9418
		public unsafe uint4 wwyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wwyy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x06002401 RID: 9217 RVA: 0x000BB248 File Offset: 0x000B9448
		public unsafe uint4 wwyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wwyz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x06002402 RID: 9218 RVA: 0x000BB278 File Offset: 0x000B9478
		public unsafe uint4 wwyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wwyw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x06002403 RID: 9219 RVA: 0x000BB2A8 File Offset: 0x000B94A8
		public unsafe uint4 wwzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wwzx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x06002404 RID: 9220 RVA: 0x000BB2D8 File Offset: 0x000B94D8
		public unsafe uint4 wwzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wwzy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x06002405 RID: 9221 RVA: 0x000BB308 File Offset: 0x000B9508
		public unsafe uint4 wwzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wwzz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x06002406 RID: 9222 RVA: 0x000BB338 File Offset: 0x000B9538
		public unsafe uint4 wwzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wwzw_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x06002407 RID: 9223 RVA: 0x000BB368 File Offset: 0x000B9568
		public unsafe uint4 wwwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wwwx_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x06002408 RID: 9224 RVA: 0x000BB398 File Offset: 0x000B9598
		public unsafe uint4 wwwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wwwy_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x06002409 RID: 9225 RVA: 0x000BB3C8 File Offset: 0x000B95C8
		public unsafe uint4 wwwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wwwz_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x0600240A RID: 9226 RVA: 0x000BB3F8 File Offset: 0x000B95F8
		public unsafe uint4 wwww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wwww_Public_get_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x0600240B RID: 9227 RVA: 0x000BB428 File Offset: 0x000B9628
		public unsafe uint3 xxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xxx_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x0600240C RID: 9228 RVA: 0x000BB458 File Offset: 0x000B9658
		public unsafe uint3 xxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xxy_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x0600240D RID: 9229 RVA: 0x000BB488 File Offset: 0x000B9688
		public unsafe uint3 xxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xxz_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x0600240E RID: 9230 RVA: 0x000BB4B8 File Offset: 0x000B96B8
		public unsafe uint3 xxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xxw_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x0600240F RID: 9231 RVA: 0x000BB4E8 File Offset: 0x000B96E8
		public unsafe uint3 xyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xyx_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x06002410 RID: 9232 RVA: 0x000BB518 File Offset: 0x000B9718
		public unsafe uint3 xyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xyy_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x06002411 RID: 9233 RVA: 0x000BB548 File Offset: 0x000B9748
		// (set) Token: 0x06002412 RID: 9234 RVA: 0x000BB578 File Offset: 0x000B9778
		public unsafe uint3 xyz
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 637161, RefRangeEnd = 637182, XrefRangeStart = 637161, XrefRangeEnd = 637182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xyz_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_xyz_Public_set_Void_uint3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x06002413 RID: 9235 RVA: 0x000BB5AC File Offset: 0x000B97AC
		// (set) Token: 0x06002414 RID: 9236 RVA: 0x000BB5DC File Offset: 0x000B97DC
		public unsafe uint3 xyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xyw_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_xyw_Public_set_Void_uint3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x06002415 RID: 9237 RVA: 0x000BB610 File Offset: 0x000B9810
		public unsafe uint3 xzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xzx_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x06002416 RID: 9238 RVA: 0x000BB640 File Offset: 0x000B9840
		// (set) Token: 0x06002417 RID: 9239 RVA: 0x000BB670 File Offset: 0x000B9870
		public unsafe uint3 xzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xzy_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_xzy_Public_set_Void_uint3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x06002418 RID: 9240 RVA: 0x000BB6A4 File Offset: 0x000B98A4
		public unsafe uint3 xzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xzz_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x06002419 RID: 9241 RVA: 0x000BB6D4 File Offset: 0x000B98D4
		// (set) Token: 0x0600241A RID: 9242 RVA: 0x000BB704 File Offset: 0x000B9904
		public unsafe uint3 xzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xzw_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_xzw_Public_set_Void_uint3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x0600241B RID: 9243 RVA: 0x000BB738 File Offset: 0x000B9938
		public unsafe uint3 xwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xwx_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x0600241C RID: 9244 RVA: 0x000BB768 File Offset: 0x000B9968
		// (set) Token: 0x0600241D RID: 9245 RVA: 0x000BB798 File Offset: 0x000B9998
		public unsafe uint3 xwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xwy_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_xwy_Public_set_Void_uint3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x0600241E RID: 9246 RVA: 0x000BB7CC File Offset: 0x000B99CC
		// (set) Token: 0x0600241F RID: 9247 RVA: 0x000BB7FC File Offset: 0x000B99FC
		public unsafe uint3 xwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xwz_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_xwz_Public_set_Void_uint3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x06002420 RID: 9248 RVA: 0x000BB830 File Offset: 0x000B9A30
		public unsafe uint3 xww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xww_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x06002421 RID: 9249 RVA: 0x000BB860 File Offset: 0x000B9A60
		public unsafe uint3 yxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yxx_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x06002422 RID: 9250 RVA: 0x000BB890 File Offset: 0x000B9A90
		public unsafe uint3 yxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yxy_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x06002423 RID: 9251 RVA: 0x000BB8C0 File Offset: 0x000B9AC0
		// (set) Token: 0x06002424 RID: 9252 RVA: 0x000BB8F0 File Offset: 0x000B9AF0
		public unsafe uint3 yxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yxz_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_yxz_Public_set_Void_uint3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x06002425 RID: 9253 RVA: 0x000BB924 File Offset: 0x000B9B24
		// (set) Token: 0x06002426 RID: 9254 RVA: 0x000BB954 File Offset: 0x000B9B54
		public unsafe uint3 yxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yxw_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_yxw_Public_set_Void_uint3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x06002427 RID: 9255 RVA: 0x000BB988 File Offset: 0x000B9B88
		public unsafe uint3 yyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yyx_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x06002428 RID: 9256 RVA: 0x000BB9B8 File Offset: 0x000B9BB8
		public unsafe uint3 yyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yyy_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x06002429 RID: 9257 RVA: 0x000BB9E8 File Offset: 0x000B9BE8
		public unsafe uint3 yyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yyz_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x0600242A RID: 9258 RVA: 0x000BBA18 File Offset: 0x000B9C18
		public unsafe uint3 yyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yyw_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x0600242B RID: 9259 RVA: 0x000BBA48 File Offset: 0x000B9C48
		// (set) Token: 0x0600242C RID: 9260 RVA: 0x000BBA78 File Offset: 0x000B9C78
		public unsafe uint3 yzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yzx_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_yzx_Public_set_Void_uint3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x0600242D RID: 9261 RVA: 0x000BBAAC File Offset: 0x000B9CAC
		public unsafe uint3 yzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yzy_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x0600242E RID: 9262 RVA: 0x000BBADC File Offset: 0x000B9CDC
		public unsafe uint3 yzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yzz_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x0600242F RID: 9263 RVA: 0x000BBB0C File Offset: 0x000B9D0C
		// (set) Token: 0x06002430 RID: 9264 RVA: 0x000BBB3C File Offset: 0x000B9D3C
		public unsafe uint3 yzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yzw_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_yzw_Public_set_Void_uint3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x06002431 RID: 9265 RVA: 0x000BBB70 File Offset: 0x000B9D70
		// (set) Token: 0x06002432 RID: 9266 RVA: 0x000BBBA0 File Offset: 0x000B9DA0
		public unsafe uint3 ywx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_ywx_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_ywx_Public_set_Void_uint3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x06002433 RID: 9267 RVA: 0x000BBBD4 File Offset: 0x000B9DD4
		public unsafe uint3 ywy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_ywy_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x06002434 RID: 9268 RVA: 0x000BBC04 File Offset: 0x000B9E04
		// (set) Token: 0x06002435 RID: 9269 RVA: 0x000BBC34 File Offset: 0x000B9E34
		public unsafe uint3 ywz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_ywz_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_ywz_Public_set_Void_uint3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x06002436 RID: 9270 RVA: 0x000BBC68 File Offset: 0x000B9E68
		public unsafe uint3 yww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yww_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x06002437 RID: 9271 RVA: 0x000BBC98 File Offset: 0x000B9E98
		public unsafe uint3 zxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zxx_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x06002438 RID: 9272 RVA: 0x000BBCC8 File Offset: 0x000B9EC8
		// (set) Token: 0x06002439 RID: 9273 RVA: 0x000BBCF8 File Offset: 0x000B9EF8
		public unsafe uint3 zxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zxy_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_zxy_Public_set_Void_uint3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x0600243A RID: 9274 RVA: 0x000BBD2C File Offset: 0x000B9F2C
		public unsafe uint3 zxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zxz_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x0600243B RID: 9275 RVA: 0x000BBD5C File Offset: 0x000B9F5C
		// (set) Token: 0x0600243C RID: 9276 RVA: 0x000BBD8C File Offset: 0x000B9F8C
		public unsafe uint3 zxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zxw_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_zxw_Public_set_Void_uint3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x0600243D RID: 9277 RVA: 0x000BBDC0 File Offset: 0x000B9FC0
		// (set) Token: 0x0600243E RID: 9278 RVA: 0x000BBDF0 File Offset: 0x000B9FF0
		public unsafe uint3 zyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zyx_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_zyx_Public_set_Void_uint3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x0600243F RID: 9279 RVA: 0x000BBE24 File Offset: 0x000BA024
		public unsafe uint3 zyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zyy_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x06002440 RID: 9280 RVA: 0x000BBE54 File Offset: 0x000BA054
		public unsafe uint3 zyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zyz_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x06002441 RID: 9281 RVA: 0x000BBE84 File Offset: 0x000BA084
		// (set) Token: 0x06002442 RID: 9282 RVA: 0x000BBEB4 File Offset: 0x000BA0B4
		public unsafe uint3 zyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zyw_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_zyw_Public_set_Void_uint3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x06002443 RID: 9283 RVA: 0x000BBEE8 File Offset: 0x000BA0E8
		public unsafe uint3 zzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zzx_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x06002444 RID: 9284 RVA: 0x000BBF18 File Offset: 0x000BA118
		public unsafe uint3 zzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zzy_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x06002445 RID: 9285 RVA: 0x000BBF48 File Offset: 0x000BA148
		public unsafe uint3 zzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zzz_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x06002446 RID: 9286 RVA: 0x000BBF78 File Offset: 0x000BA178
		public unsafe uint3 zzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zzw_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x06002447 RID: 9287 RVA: 0x000BBFA8 File Offset: 0x000BA1A8
		// (set) Token: 0x06002448 RID: 9288 RVA: 0x000BBFD8 File Offset: 0x000BA1D8
		public unsafe uint3 zwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zwx_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_zwx_Public_set_Void_uint3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x06002449 RID: 9289 RVA: 0x000BC00C File Offset: 0x000BA20C
		// (set) Token: 0x0600244A RID: 9290 RVA: 0x000BC03C File Offset: 0x000BA23C
		public unsafe uint3 zwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zwy_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_zwy_Public_set_Void_uint3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x0600244B RID: 9291 RVA: 0x000BC070 File Offset: 0x000BA270
		public unsafe uint3 zwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zwz_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x0600244C RID: 9292 RVA: 0x000BC0A0 File Offset: 0x000BA2A0
		public unsafe uint3 zww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zww_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x0600244D RID: 9293 RVA: 0x000BC0D0 File Offset: 0x000BA2D0
		public unsafe uint3 wxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wxx_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x0600244E RID: 9294 RVA: 0x000BC100 File Offset: 0x000BA300
		// (set) Token: 0x0600244F RID: 9295 RVA: 0x000BC130 File Offset: 0x000BA330
		public unsafe uint3 wxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wxy_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_wxy_Public_set_Void_uint3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x06002450 RID: 9296 RVA: 0x000BC164 File Offset: 0x000BA364
		// (set) Token: 0x06002451 RID: 9297 RVA: 0x000BC194 File Offset: 0x000BA394
		public unsafe uint3 wxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wxz_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_wxz_Public_set_Void_uint3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x06002452 RID: 9298 RVA: 0x000BC1C8 File Offset: 0x000BA3C8
		public unsafe uint3 wxw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wxw_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x06002453 RID: 9299 RVA: 0x000BC1F8 File Offset: 0x000BA3F8
		// (set) Token: 0x06002454 RID: 9300 RVA: 0x000BC228 File Offset: 0x000BA428
		public unsafe uint3 wyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wyx_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_wyx_Public_set_Void_uint3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x06002455 RID: 9301 RVA: 0x000BC25C File Offset: 0x000BA45C
		public unsafe uint3 wyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wyy_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x06002456 RID: 9302 RVA: 0x000BC28C File Offset: 0x000BA48C
		// (set) Token: 0x06002457 RID: 9303 RVA: 0x000BC2BC File Offset: 0x000BA4BC
		public unsafe uint3 wyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wyz_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_wyz_Public_set_Void_uint3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x06002458 RID: 9304 RVA: 0x000BC2F0 File Offset: 0x000BA4F0
		public unsafe uint3 wyw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wyw_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x06002459 RID: 9305 RVA: 0x000BC320 File Offset: 0x000BA520
		// (set) Token: 0x0600245A RID: 9306 RVA: 0x000BC350 File Offset: 0x000BA550
		public unsafe uint3 wzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wzx_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_wzx_Public_set_Void_uint3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x0600245B RID: 9307 RVA: 0x000BC384 File Offset: 0x000BA584
		// (set) Token: 0x0600245C RID: 9308 RVA: 0x000BC3B4 File Offset: 0x000BA5B4
		public unsafe uint3 wzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wzy_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_wzy_Public_set_Void_uint3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x0600245D RID: 9309 RVA: 0x000BC3E8 File Offset: 0x000BA5E8
		public unsafe uint3 wzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wzz_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x0600245E RID: 9310 RVA: 0x000BC418 File Offset: 0x000BA618
		public unsafe uint3 wzw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wzw_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x0600245F RID: 9311 RVA: 0x000BC448 File Offset: 0x000BA648
		public unsafe uint3 wwx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wwx_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x06002460 RID: 9312 RVA: 0x000BC478 File Offset: 0x000BA678
		public unsafe uint3 wwy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wwy_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x06002461 RID: 9313 RVA: 0x000BC4A8 File Offset: 0x000BA6A8
		public unsafe uint3 wwz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wwz_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x06002462 RID: 9314 RVA: 0x000BC4D8 File Offset: 0x000BA6D8
		public unsafe uint3 www
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_www_Public_get_uint3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x06002463 RID: 9315 RVA: 0x000BC508 File Offset: 0x000BA708
		public unsafe uint2 xx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xx_Public_get_uint2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x06002464 RID: 9316 RVA: 0x000BC538 File Offset: 0x000BA738
		// (set) Token: 0x06002465 RID: 9317 RVA: 0x000BC568 File Offset: 0x000BA768
		public unsafe uint2 xy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xy_Public_get_uint2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_xy_Public_set_Void_uint2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x06002466 RID: 9318 RVA: 0x000BC59C File Offset: 0x000BA79C
		// (set) Token: 0x06002467 RID: 9319 RVA: 0x000BC5CC File Offset: 0x000BA7CC
		public unsafe uint2 xz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xz_Public_get_uint2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_xz_Public_set_Void_uint2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x06002468 RID: 9320 RVA: 0x000BC600 File Offset: 0x000BA800
		// (set) Token: 0x06002469 RID: 9321 RVA: 0x000BC630 File Offset: 0x000BA830
		public unsafe uint2 xw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_xw_Public_get_uint2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_xw_Public_set_Void_uint2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x0600246A RID: 9322 RVA: 0x000BC664 File Offset: 0x000BA864
		// (set) Token: 0x0600246B RID: 9323 RVA: 0x000BC694 File Offset: 0x000BA894
		public unsafe uint2 yx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yx_Public_get_uint2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_yx_Public_set_Void_uint2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x0600246C RID: 9324 RVA: 0x000BC6C8 File Offset: 0x000BA8C8
		public unsafe uint2 yy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yy_Public_get_uint2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x0600246D RID: 9325 RVA: 0x000BC6F8 File Offset: 0x000BA8F8
		// (set) Token: 0x0600246E RID: 9326 RVA: 0x000BC728 File Offset: 0x000BA928
		public unsafe uint2 yz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yz_Public_get_uint2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_yz_Public_set_Void_uint2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x0600246F RID: 9327 RVA: 0x000BC75C File Offset: 0x000BA95C
		// (set) Token: 0x06002470 RID: 9328 RVA: 0x000BC78C File Offset: 0x000BA98C
		public unsafe uint2 yw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_yw_Public_get_uint2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_yw_Public_set_Void_uint2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x06002471 RID: 9329 RVA: 0x000BC7C0 File Offset: 0x000BA9C0
		// (set) Token: 0x06002472 RID: 9330 RVA: 0x000BC7F0 File Offset: 0x000BA9F0
		public unsafe uint2 zx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zx_Public_get_uint2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_zx_Public_set_Void_uint2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x06002473 RID: 9331 RVA: 0x000BC824 File Offset: 0x000BAA24
		// (set) Token: 0x06002474 RID: 9332 RVA: 0x000BC854 File Offset: 0x000BAA54
		public unsafe uint2 zy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zy_Public_get_uint2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_zy_Public_set_Void_uint2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x06002475 RID: 9333 RVA: 0x000BC888 File Offset: 0x000BAA88
		public unsafe uint2 zz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zz_Public_get_uint2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x06002476 RID: 9334 RVA: 0x000BC8B8 File Offset: 0x000BAAB8
		// (set) Token: 0x06002477 RID: 9335 RVA: 0x000BC8E8 File Offset: 0x000BAAE8
		public unsafe uint2 zw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_zw_Public_get_uint2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_zw_Public_set_Void_uint2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x06002478 RID: 9336 RVA: 0x000BC91C File Offset: 0x000BAB1C
		// (set) Token: 0x06002479 RID: 9337 RVA: 0x000BC94C File Offset: 0x000BAB4C
		public unsafe uint2 wx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wx_Public_get_uint2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_wx_Public_set_Void_uint2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x0600247A RID: 9338 RVA: 0x000BC980 File Offset: 0x000BAB80
		// (set) Token: 0x0600247B RID: 9339 RVA: 0x000BC9B0 File Offset: 0x000BABB0
		public unsafe uint2 wy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wy_Public_get_uint2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_wy_Public_set_Void_uint2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x0600247C RID: 9340 RVA: 0x000BC9E4 File Offset: 0x000BABE4
		// (set) Token: 0x0600247D RID: 9341 RVA: 0x000BCA14 File Offset: 0x000BAC14
		public unsafe uint2 wz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_wz_Public_get_uint2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_wz_Public_set_Void_uint2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x0600247E RID: 9342 RVA: 0x000BCA48 File Offset: 0x000BAC48
		public unsafe uint2 ww
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_ww_Public_get_uint2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BDA RID: 3034
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_get_Item_Public_get_UInt32_Int32_0, ref this, (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002481 RID: 9345 RVA: 0x000BCAF8 File Offset: 0x000BACF8
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 639726, RefRangeEnd = 639747, XrefRangeStart = 639726, XrefRangeEnd = 639747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(uint4 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_uint4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002482 RID: 9346 RVA: 0x000BCB38 File Offset: 0x000BAD38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642210, XrefRangeEnd = 642213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002483 RID: 9347 RVA: 0x000BCB7C File Offset: 0x000BAD7C
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002484 RID: 9348 RVA: 0x000BCBAC File Offset: 0x000BADAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642213, XrefRangeEnd = 642236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002485 RID: 9349 RVA: 0x000BCBD8 File Offset: 0x000BADD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642236, XrefRangeEnd = 642264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002486 RID: 9350 RVA: 0x00002A29 File Offset: 0x00000C29
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<uint4>.NativeClassPtr, ref this));
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x06002487 RID: 9351 RVA: 0x000BCC28 File Offset: 0x000BAE28
		// (set) Token: 0x06002488 RID: 9352 RVA: 0x00002A3B File Offset: 0x00000C3B
		public unsafe static uint4 zero
		{
			get
			{
				uint4 @uint;
				IL2CPP.il2cpp_field_static_get_value(uint4.NativeFieldInfoPtr_zero, (void*)(&@uint));
				return @uint;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(uint4.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x04002334 RID: 9012
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x04002335 RID: 9013
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04002336 RID: 9014
		private static readonly IntPtr NativeFieldInfoPtr_z;

		// Token: 0x04002337 RID: 9015
		private static readonly IntPtr NativeFieldInfoPtr_w;

		// Token: 0x04002338 RID: 9016
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x04002339 RID: 9017
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_0;

		// Token: 0x0400233A RID: 9018
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_uint2_0;

		// Token: 0x0400233B RID: 9019
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_uint2_UInt32_0;

		// Token: 0x0400233C RID: 9020
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_uint3_0;

		// Token: 0x0400233D RID: 9021
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint2_UInt32_UInt32_0;

		// Token: 0x0400233E RID: 9022
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint2_uint2_0;

		// Token: 0x0400233F RID: 9023
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint3_UInt32_0;

		// Token: 0x04002340 RID: 9024
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint4_0;

		// Token: 0x04002341 RID: 9025
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04002342 RID: 9026
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04002343 RID: 9027
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool4_0;

		// Token: 0x04002344 RID: 9028
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04002345 RID: 9029
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int4_0;

		// Token: 0x04002346 RID: 9030
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x04002347 RID: 9031
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float4_0;

		// Token: 0x04002348 RID: 9032
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x04002349 RID: 9033
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double4_0;

		// Token: 0x0400234A RID: 9034
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_uint4_UInt32_0;

		// Token: 0x0400234B RID: 9035
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint4_Boolean_0;

		// Token: 0x0400234C RID: 9036
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint4_bool4_0;

		// Token: 0x0400234D RID: 9037
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint4_Int32_0;

		// Token: 0x0400234E RID: 9038
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint4_int4_0;

		// Token: 0x0400234F RID: 9039
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint4_Single_0;

		// Token: 0x04002350 RID: 9040
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint4_float4_0;

		// Token: 0x04002351 RID: 9041
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint4_Double_0;

		// Token: 0x04002352 RID: 9042
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint4_double4_0;

		// Token: 0x04002353 RID: 9043
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_uint4_uint4_uint4_0;

		// Token: 0x04002354 RID: 9044
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_uint4_uint4_UInt32_0;

		// Token: 0x04002355 RID: 9045
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_uint4_UInt32_uint4_0;

		// Token: 0x04002356 RID: 9046
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_uint4_uint4_uint4_0;

		// Token: 0x04002357 RID: 9047
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_uint4_uint4_UInt32_0;

		// Token: 0x04002358 RID: 9048
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_uint4_UInt32_uint4_0;

		// Token: 0x04002359 RID: 9049
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_uint4_uint4_uint4_0;

		// Token: 0x0400235A RID: 9050
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_uint4_uint4_UInt32_0;

		// Token: 0x0400235B RID: 9051
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_uint4_UInt32_uint4_0;

		// Token: 0x0400235C RID: 9052
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_uint4_uint4_uint4_0;

		// Token: 0x0400235D RID: 9053
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_uint4_uint4_UInt32_0;

		// Token: 0x0400235E RID: 9054
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_uint4_UInt32_uint4_0;

		// Token: 0x0400235F RID: 9055
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_uint4_uint4_uint4_0;

		// Token: 0x04002360 RID: 9056
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_uint4_uint4_UInt32_0;

		// Token: 0x04002361 RID: 9057
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_uint4_UInt32_uint4_0;

		// Token: 0x04002362 RID: 9058
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_uint4_uint4_0;

		// Token: 0x04002363 RID: 9059
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_uint4_uint4_0;

		// Token: 0x04002364 RID: 9060
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool4_uint4_uint4_0;

		// Token: 0x04002365 RID: 9061
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool4_uint4_UInt32_0;

		// Token: 0x04002366 RID: 9062
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool4_UInt32_uint4_0;

		// Token: 0x04002367 RID: 9063
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4_uint4_uint4_0;

		// Token: 0x04002368 RID: 9064
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4_uint4_UInt32_0;

		// Token: 0x04002369 RID: 9065
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4_UInt32_uint4_0;

		// Token: 0x0400236A RID: 9066
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4_uint4_uint4_0;

		// Token: 0x0400236B RID: 9067
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4_uint4_UInt32_0;

		// Token: 0x0400236C RID: 9068
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4_UInt32_uint4_0;

		// Token: 0x0400236D RID: 9069
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4_uint4_uint4_0;

		// Token: 0x0400236E RID: 9070
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4_uint4_UInt32_0;

		// Token: 0x0400236F RID: 9071
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4_UInt32_uint4_0;

		// Token: 0x04002370 RID: 9072
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_uint4_uint4_0;

		// Token: 0x04002371 RID: 9073
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryPlus_Public_Static_uint4_uint4_0;

		// Token: 0x04002372 RID: 9074
		private static readonly IntPtr NativeMethodInfoPtr_op_LeftShift_Public_Static_uint4_uint4_Int32_0;

		// Token: 0x04002373 RID: 9075
		private static readonly IntPtr NativeMethodInfoPtr_op_RightShift_Public_Static_uint4_uint4_Int32_0;

		// Token: 0x04002374 RID: 9076
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4_uint4_uint4_0;

		// Token: 0x04002375 RID: 9077
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4_uint4_UInt32_0;

		// Token: 0x04002376 RID: 9078
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4_UInt32_uint4_0;

		// Token: 0x04002377 RID: 9079
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_uint4_uint4_0;

		// Token: 0x04002378 RID: 9080
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_uint4_UInt32_0;

		// Token: 0x04002379 RID: 9081
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4_UInt32_uint4_0;

		// Token: 0x0400237A RID: 9082
		private static readonly IntPtr NativeMethodInfoPtr_op_OnesComplement_Public_Static_uint4_uint4_0;

		// Token: 0x0400237B RID: 9083
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint4_uint4_uint4_0;

		// Token: 0x0400237C RID: 9084
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint4_uint4_UInt32_0;

		// Token: 0x0400237D RID: 9085
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint4_UInt32_uint4_0;

		// Token: 0x0400237E RID: 9086
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint4_uint4_uint4_0;

		// Token: 0x0400237F RID: 9087
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint4_uint4_UInt32_0;

		// Token: 0x04002380 RID: 9088
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint4_UInt32_uint4_0;

		// Token: 0x04002381 RID: 9089
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint4_uint4_uint4_0;

		// Token: 0x04002382 RID: 9090
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint4_uint4_UInt32_0;

		// Token: 0x04002383 RID: 9091
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint4_UInt32_uint4_0;

		// Token: 0x04002384 RID: 9092
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxx_Public_get_uint4_0;

		// Token: 0x04002385 RID: 9093
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxy_Public_get_uint4_0;

		// Token: 0x04002386 RID: 9094
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxz_Public_get_uint4_0;

		// Token: 0x04002387 RID: 9095
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxw_Public_get_uint4_0;

		// Token: 0x04002388 RID: 9096
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyx_Public_get_uint4_0;

		// Token: 0x04002389 RID: 9097
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyy_Public_get_uint4_0;

		// Token: 0x0400238A RID: 9098
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyz_Public_get_uint4_0;

		// Token: 0x0400238B RID: 9099
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyw_Public_get_uint4_0;

		// Token: 0x0400238C RID: 9100
		private static readonly IntPtr NativeMethodInfoPtr_get_xxzx_Public_get_uint4_0;

		// Token: 0x0400238D RID: 9101
		private static readonly IntPtr NativeMethodInfoPtr_get_xxzy_Public_get_uint4_0;

		// Token: 0x0400238E RID: 9102
		private static readonly IntPtr NativeMethodInfoPtr_get_xxzz_Public_get_uint4_0;

		// Token: 0x0400238F RID: 9103
		private static readonly IntPtr NativeMethodInfoPtr_get_xxzw_Public_get_uint4_0;

		// Token: 0x04002390 RID: 9104
		private static readonly IntPtr NativeMethodInfoPtr_get_xxwx_Public_get_uint4_0;

		// Token: 0x04002391 RID: 9105
		private static readonly IntPtr NativeMethodInfoPtr_get_xxwy_Public_get_uint4_0;

		// Token: 0x04002392 RID: 9106
		private static readonly IntPtr NativeMethodInfoPtr_get_xxwz_Public_get_uint4_0;

		// Token: 0x04002393 RID: 9107
		private static readonly IntPtr NativeMethodInfoPtr_get_xxww_Public_get_uint4_0;

		// Token: 0x04002394 RID: 9108
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxx_Public_get_uint4_0;

		// Token: 0x04002395 RID: 9109
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxy_Public_get_uint4_0;

		// Token: 0x04002396 RID: 9110
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxz_Public_get_uint4_0;

		// Token: 0x04002397 RID: 9111
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxw_Public_get_uint4_0;

		// Token: 0x04002398 RID: 9112
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyx_Public_get_uint4_0;

		// Token: 0x04002399 RID: 9113
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyy_Public_get_uint4_0;

		// Token: 0x0400239A RID: 9114
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyz_Public_get_uint4_0;

		// Token: 0x0400239B RID: 9115
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyw_Public_get_uint4_0;

		// Token: 0x0400239C RID: 9116
		private static readonly IntPtr NativeMethodInfoPtr_get_xyzx_Public_get_uint4_0;

		// Token: 0x0400239D RID: 9117
		private static readonly IntPtr NativeMethodInfoPtr_get_xyzy_Public_get_uint4_0;

		// Token: 0x0400239E RID: 9118
		private static readonly IntPtr NativeMethodInfoPtr_get_xyzz_Public_get_uint4_0;

		// Token: 0x0400239F RID: 9119
		private static readonly IntPtr NativeMethodInfoPtr_get_xyzw_Public_get_uint4_0;

		// Token: 0x040023A0 RID: 9120
		private static readonly IntPtr NativeMethodInfoPtr_set_xyzw_Public_set_Void_uint4_0;

		// Token: 0x040023A1 RID: 9121
		private static readonly IntPtr NativeMethodInfoPtr_get_xywx_Public_get_uint4_0;

		// Token: 0x040023A2 RID: 9122
		private static readonly IntPtr NativeMethodInfoPtr_get_xywy_Public_get_uint4_0;

		// Token: 0x040023A3 RID: 9123
		private static readonly IntPtr NativeMethodInfoPtr_get_xywz_Public_get_uint4_0;

		// Token: 0x040023A4 RID: 9124
		private static readonly IntPtr NativeMethodInfoPtr_set_xywz_Public_set_Void_uint4_0;

		// Token: 0x040023A5 RID: 9125
		private static readonly IntPtr NativeMethodInfoPtr_get_xyww_Public_get_uint4_0;

		// Token: 0x040023A6 RID: 9126
		private static readonly IntPtr NativeMethodInfoPtr_get_xzxx_Public_get_uint4_0;

		// Token: 0x040023A7 RID: 9127
		private static readonly IntPtr NativeMethodInfoPtr_get_xzxy_Public_get_uint4_0;

		// Token: 0x040023A8 RID: 9128
		private static readonly IntPtr NativeMethodInfoPtr_get_xzxz_Public_get_uint4_0;

		// Token: 0x040023A9 RID: 9129
		private static readonly IntPtr NativeMethodInfoPtr_get_xzxw_Public_get_uint4_0;

		// Token: 0x040023AA RID: 9130
		private static readonly IntPtr NativeMethodInfoPtr_get_xzyx_Public_get_uint4_0;

		// Token: 0x040023AB RID: 9131
		private static readonly IntPtr NativeMethodInfoPtr_get_xzyy_Public_get_uint4_0;

		// Token: 0x040023AC RID: 9132
		private static readonly IntPtr NativeMethodInfoPtr_get_xzyz_Public_get_uint4_0;

		// Token: 0x040023AD RID: 9133
		private static readonly IntPtr NativeMethodInfoPtr_get_xzyw_Public_get_uint4_0;

		// Token: 0x040023AE RID: 9134
		private static readonly IntPtr NativeMethodInfoPtr_set_xzyw_Public_set_Void_uint4_0;

		// Token: 0x040023AF RID: 9135
		private static readonly IntPtr NativeMethodInfoPtr_get_xzzx_Public_get_uint4_0;

		// Token: 0x040023B0 RID: 9136
		private static readonly IntPtr NativeMethodInfoPtr_get_xzzy_Public_get_uint4_0;

		// Token: 0x040023B1 RID: 9137
		private static readonly IntPtr NativeMethodInfoPtr_get_xzzz_Public_get_uint4_0;

		// Token: 0x040023B2 RID: 9138
		private static readonly IntPtr NativeMethodInfoPtr_get_xzzw_Public_get_uint4_0;

		// Token: 0x040023B3 RID: 9139
		private static readonly IntPtr NativeMethodInfoPtr_get_xzwx_Public_get_uint4_0;

		// Token: 0x040023B4 RID: 9140
		private static readonly IntPtr NativeMethodInfoPtr_get_xzwy_Public_get_uint4_0;

		// Token: 0x040023B5 RID: 9141
		private static readonly IntPtr NativeMethodInfoPtr_set_xzwy_Public_set_Void_uint4_0;

		// Token: 0x040023B6 RID: 9142
		private static readonly IntPtr NativeMethodInfoPtr_get_xzwz_Public_get_uint4_0;

		// Token: 0x040023B7 RID: 9143
		private static readonly IntPtr NativeMethodInfoPtr_get_xzww_Public_get_uint4_0;

		// Token: 0x040023B8 RID: 9144
		private static readonly IntPtr NativeMethodInfoPtr_get_xwxx_Public_get_uint4_0;

		// Token: 0x040023B9 RID: 9145
		private static readonly IntPtr NativeMethodInfoPtr_get_xwxy_Public_get_uint4_0;

		// Token: 0x040023BA RID: 9146
		private static readonly IntPtr NativeMethodInfoPtr_get_xwxz_Public_get_uint4_0;

		// Token: 0x040023BB RID: 9147
		private static readonly IntPtr NativeMethodInfoPtr_get_xwxw_Public_get_uint4_0;

		// Token: 0x040023BC RID: 9148
		private static readonly IntPtr NativeMethodInfoPtr_get_xwyx_Public_get_uint4_0;

		// Token: 0x040023BD RID: 9149
		private static readonly IntPtr NativeMethodInfoPtr_get_xwyy_Public_get_uint4_0;

		// Token: 0x040023BE RID: 9150
		private static readonly IntPtr NativeMethodInfoPtr_get_xwyz_Public_get_uint4_0;

		// Token: 0x040023BF RID: 9151
		private static readonly IntPtr NativeMethodInfoPtr_set_xwyz_Public_set_Void_uint4_0;

		// Token: 0x040023C0 RID: 9152
		private static readonly IntPtr NativeMethodInfoPtr_get_xwyw_Public_get_uint4_0;

		// Token: 0x040023C1 RID: 9153
		private static readonly IntPtr NativeMethodInfoPtr_get_xwzx_Public_get_uint4_0;

		// Token: 0x040023C2 RID: 9154
		private static readonly IntPtr NativeMethodInfoPtr_get_xwzy_Public_get_uint4_0;

		// Token: 0x040023C3 RID: 9155
		private static readonly IntPtr NativeMethodInfoPtr_set_xwzy_Public_set_Void_uint4_0;

		// Token: 0x040023C4 RID: 9156
		private static readonly IntPtr NativeMethodInfoPtr_get_xwzz_Public_get_uint4_0;

		// Token: 0x040023C5 RID: 9157
		private static readonly IntPtr NativeMethodInfoPtr_get_xwzw_Public_get_uint4_0;

		// Token: 0x040023C6 RID: 9158
		private static readonly IntPtr NativeMethodInfoPtr_get_xwwx_Public_get_uint4_0;

		// Token: 0x040023C7 RID: 9159
		private static readonly IntPtr NativeMethodInfoPtr_get_xwwy_Public_get_uint4_0;

		// Token: 0x040023C8 RID: 9160
		private static readonly IntPtr NativeMethodInfoPtr_get_xwwz_Public_get_uint4_0;

		// Token: 0x040023C9 RID: 9161
		private static readonly IntPtr NativeMethodInfoPtr_get_xwww_Public_get_uint4_0;

		// Token: 0x040023CA RID: 9162
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxx_Public_get_uint4_0;

		// Token: 0x040023CB RID: 9163
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxy_Public_get_uint4_0;

		// Token: 0x040023CC RID: 9164
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxz_Public_get_uint4_0;

		// Token: 0x040023CD RID: 9165
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxw_Public_get_uint4_0;

		// Token: 0x040023CE RID: 9166
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyx_Public_get_uint4_0;

		// Token: 0x040023CF RID: 9167
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyy_Public_get_uint4_0;

		// Token: 0x040023D0 RID: 9168
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyz_Public_get_uint4_0;

		// Token: 0x040023D1 RID: 9169
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyw_Public_get_uint4_0;

		// Token: 0x040023D2 RID: 9170
		private static readonly IntPtr NativeMethodInfoPtr_get_yxzx_Public_get_uint4_0;

		// Token: 0x040023D3 RID: 9171
		private static readonly IntPtr NativeMethodInfoPtr_get_yxzy_Public_get_uint4_0;

		// Token: 0x040023D4 RID: 9172
		private static readonly IntPtr NativeMethodInfoPtr_get_yxzz_Public_get_uint4_0;

		// Token: 0x040023D5 RID: 9173
		private static readonly IntPtr NativeMethodInfoPtr_get_yxzw_Public_get_uint4_0;

		// Token: 0x040023D6 RID: 9174
		private static readonly IntPtr NativeMethodInfoPtr_set_yxzw_Public_set_Void_uint4_0;

		// Token: 0x040023D7 RID: 9175
		private static readonly IntPtr NativeMethodInfoPtr_get_yxwx_Public_get_uint4_0;

		// Token: 0x040023D8 RID: 9176
		private static readonly IntPtr NativeMethodInfoPtr_get_yxwy_Public_get_uint4_0;

		// Token: 0x040023D9 RID: 9177
		private static readonly IntPtr NativeMethodInfoPtr_get_yxwz_Public_get_uint4_0;

		// Token: 0x040023DA RID: 9178
		private static readonly IntPtr NativeMethodInfoPtr_set_yxwz_Public_set_Void_uint4_0;

		// Token: 0x040023DB RID: 9179
		private static readonly IntPtr NativeMethodInfoPtr_get_yxww_Public_get_uint4_0;

		// Token: 0x040023DC RID: 9180
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxx_Public_get_uint4_0;

		// Token: 0x040023DD RID: 9181
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxy_Public_get_uint4_0;

		// Token: 0x040023DE RID: 9182
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxz_Public_get_uint4_0;

		// Token: 0x040023DF RID: 9183
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxw_Public_get_uint4_0;

		// Token: 0x040023E0 RID: 9184
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyx_Public_get_uint4_0;

		// Token: 0x040023E1 RID: 9185
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyy_Public_get_uint4_0;

		// Token: 0x040023E2 RID: 9186
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyz_Public_get_uint4_0;

		// Token: 0x040023E3 RID: 9187
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyw_Public_get_uint4_0;

		// Token: 0x040023E4 RID: 9188
		private static readonly IntPtr NativeMethodInfoPtr_get_yyzx_Public_get_uint4_0;

		// Token: 0x040023E5 RID: 9189
		private static readonly IntPtr NativeMethodInfoPtr_get_yyzy_Public_get_uint4_0;

		// Token: 0x040023E6 RID: 9190
		private static readonly IntPtr NativeMethodInfoPtr_get_yyzz_Public_get_uint4_0;

		// Token: 0x040023E7 RID: 9191
		private static readonly IntPtr NativeMethodInfoPtr_get_yyzw_Public_get_uint4_0;

		// Token: 0x040023E8 RID: 9192
		private static readonly IntPtr NativeMethodInfoPtr_get_yywx_Public_get_uint4_0;

		// Token: 0x040023E9 RID: 9193
		private static readonly IntPtr NativeMethodInfoPtr_get_yywy_Public_get_uint4_0;

		// Token: 0x040023EA RID: 9194
		private static readonly IntPtr NativeMethodInfoPtr_get_yywz_Public_get_uint4_0;

		// Token: 0x040023EB RID: 9195
		private static readonly IntPtr NativeMethodInfoPtr_get_yyww_Public_get_uint4_0;

		// Token: 0x040023EC RID: 9196
		private static readonly IntPtr NativeMethodInfoPtr_get_yzxx_Public_get_uint4_0;

		// Token: 0x040023ED RID: 9197
		private static readonly IntPtr NativeMethodInfoPtr_get_yzxy_Public_get_uint4_0;

		// Token: 0x040023EE RID: 9198
		private static readonly IntPtr NativeMethodInfoPtr_get_yzxz_Public_get_uint4_0;

		// Token: 0x040023EF RID: 9199
		private static readonly IntPtr NativeMethodInfoPtr_get_yzxw_Public_get_uint4_0;

		// Token: 0x040023F0 RID: 9200
		private static readonly IntPtr NativeMethodInfoPtr_set_yzxw_Public_set_Void_uint4_0;

		// Token: 0x040023F1 RID: 9201
		private static readonly IntPtr NativeMethodInfoPtr_get_yzyx_Public_get_uint4_0;

		// Token: 0x040023F2 RID: 9202
		private static readonly IntPtr NativeMethodInfoPtr_get_yzyy_Public_get_uint4_0;

		// Token: 0x040023F3 RID: 9203
		private static readonly IntPtr NativeMethodInfoPtr_get_yzyz_Public_get_uint4_0;

		// Token: 0x040023F4 RID: 9204
		private static readonly IntPtr NativeMethodInfoPtr_get_yzyw_Public_get_uint4_0;

		// Token: 0x040023F5 RID: 9205
		private static readonly IntPtr NativeMethodInfoPtr_get_yzzx_Public_get_uint4_0;

		// Token: 0x040023F6 RID: 9206
		private static readonly IntPtr NativeMethodInfoPtr_get_yzzy_Public_get_uint4_0;

		// Token: 0x040023F7 RID: 9207
		private static readonly IntPtr NativeMethodInfoPtr_get_yzzz_Public_get_uint4_0;

		// Token: 0x040023F8 RID: 9208
		private static readonly IntPtr NativeMethodInfoPtr_get_yzzw_Public_get_uint4_0;

		// Token: 0x040023F9 RID: 9209
		private static readonly IntPtr NativeMethodInfoPtr_get_yzwx_Public_get_uint4_0;

		// Token: 0x040023FA RID: 9210
		private static readonly IntPtr NativeMethodInfoPtr_set_yzwx_Public_set_Void_uint4_0;

		// Token: 0x040023FB RID: 9211
		private static readonly IntPtr NativeMethodInfoPtr_get_yzwy_Public_get_uint4_0;

		// Token: 0x040023FC RID: 9212
		private static readonly IntPtr NativeMethodInfoPtr_get_yzwz_Public_get_uint4_0;

		// Token: 0x040023FD RID: 9213
		private static readonly IntPtr NativeMethodInfoPtr_get_yzww_Public_get_uint4_0;

		// Token: 0x040023FE RID: 9214
		private static readonly IntPtr NativeMethodInfoPtr_get_ywxx_Public_get_uint4_0;

		// Token: 0x040023FF RID: 9215
		private static readonly IntPtr NativeMethodInfoPtr_get_ywxy_Public_get_uint4_0;

		// Token: 0x04002400 RID: 9216
		private static readonly IntPtr NativeMethodInfoPtr_get_ywxz_Public_get_uint4_0;

		// Token: 0x04002401 RID: 9217
		private static readonly IntPtr NativeMethodInfoPtr_set_ywxz_Public_set_Void_uint4_0;

		// Token: 0x04002402 RID: 9218
		private static readonly IntPtr NativeMethodInfoPtr_get_ywxw_Public_get_uint4_0;

		// Token: 0x04002403 RID: 9219
		private static readonly IntPtr NativeMethodInfoPtr_get_ywyx_Public_get_uint4_0;

		// Token: 0x04002404 RID: 9220
		private static readonly IntPtr NativeMethodInfoPtr_get_ywyy_Public_get_uint4_0;

		// Token: 0x04002405 RID: 9221
		private static readonly IntPtr NativeMethodInfoPtr_get_ywyz_Public_get_uint4_0;

		// Token: 0x04002406 RID: 9222
		private static readonly IntPtr NativeMethodInfoPtr_get_ywyw_Public_get_uint4_0;

		// Token: 0x04002407 RID: 9223
		private static readonly IntPtr NativeMethodInfoPtr_get_ywzx_Public_get_uint4_0;

		// Token: 0x04002408 RID: 9224
		private static readonly IntPtr NativeMethodInfoPtr_set_ywzx_Public_set_Void_uint4_0;

		// Token: 0x04002409 RID: 9225
		private static readonly IntPtr NativeMethodInfoPtr_get_ywzy_Public_get_uint4_0;

		// Token: 0x0400240A RID: 9226
		private static readonly IntPtr NativeMethodInfoPtr_get_ywzz_Public_get_uint4_0;

		// Token: 0x0400240B RID: 9227
		private static readonly IntPtr NativeMethodInfoPtr_get_ywzw_Public_get_uint4_0;

		// Token: 0x0400240C RID: 9228
		private static readonly IntPtr NativeMethodInfoPtr_get_ywwx_Public_get_uint4_0;

		// Token: 0x0400240D RID: 9229
		private static readonly IntPtr NativeMethodInfoPtr_get_ywwy_Public_get_uint4_0;

		// Token: 0x0400240E RID: 9230
		private static readonly IntPtr NativeMethodInfoPtr_get_ywwz_Public_get_uint4_0;

		// Token: 0x0400240F RID: 9231
		private static readonly IntPtr NativeMethodInfoPtr_get_ywww_Public_get_uint4_0;

		// Token: 0x04002410 RID: 9232
		private static readonly IntPtr NativeMethodInfoPtr_get_zxxx_Public_get_uint4_0;

		// Token: 0x04002411 RID: 9233
		private static readonly IntPtr NativeMethodInfoPtr_get_zxxy_Public_get_uint4_0;

		// Token: 0x04002412 RID: 9234
		private static readonly IntPtr NativeMethodInfoPtr_get_zxxz_Public_get_uint4_0;

		// Token: 0x04002413 RID: 9235
		private static readonly IntPtr NativeMethodInfoPtr_get_zxxw_Public_get_uint4_0;

		// Token: 0x04002414 RID: 9236
		private static readonly IntPtr NativeMethodInfoPtr_get_zxyx_Public_get_uint4_0;

		// Token: 0x04002415 RID: 9237
		private static readonly IntPtr NativeMethodInfoPtr_get_zxyy_Public_get_uint4_0;

		// Token: 0x04002416 RID: 9238
		private static readonly IntPtr NativeMethodInfoPtr_get_zxyz_Public_get_uint4_0;

		// Token: 0x04002417 RID: 9239
		private static readonly IntPtr NativeMethodInfoPtr_get_zxyw_Public_get_uint4_0;

		// Token: 0x04002418 RID: 9240
		private static readonly IntPtr NativeMethodInfoPtr_set_zxyw_Public_set_Void_uint4_0;

		// Token: 0x04002419 RID: 9241
		private static readonly IntPtr NativeMethodInfoPtr_get_zxzx_Public_get_uint4_0;

		// Token: 0x0400241A RID: 9242
		private static readonly IntPtr NativeMethodInfoPtr_get_zxzy_Public_get_uint4_0;

		// Token: 0x0400241B RID: 9243
		private static readonly IntPtr NativeMethodInfoPtr_get_zxzz_Public_get_uint4_0;

		// Token: 0x0400241C RID: 9244
		private static readonly IntPtr NativeMethodInfoPtr_get_zxzw_Public_get_uint4_0;

		// Token: 0x0400241D RID: 9245
		private static readonly IntPtr NativeMethodInfoPtr_get_zxwx_Public_get_uint4_0;

		// Token: 0x0400241E RID: 9246
		private static readonly IntPtr NativeMethodInfoPtr_get_zxwy_Public_get_uint4_0;

		// Token: 0x0400241F RID: 9247
		private static readonly IntPtr NativeMethodInfoPtr_set_zxwy_Public_set_Void_uint4_0;

		// Token: 0x04002420 RID: 9248
		private static readonly IntPtr NativeMethodInfoPtr_get_zxwz_Public_get_uint4_0;

		// Token: 0x04002421 RID: 9249
		private static readonly IntPtr NativeMethodInfoPtr_get_zxww_Public_get_uint4_0;

		// Token: 0x04002422 RID: 9250
		private static readonly IntPtr NativeMethodInfoPtr_get_zyxx_Public_get_uint4_0;

		// Token: 0x04002423 RID: 9251
		private static readonly IntPtr NativeMethodInfoPtr_get_zyxy_Public_get_uint4_0;

		// Token: 0x04002424 RID: 9252
		private static readonly IntPtr NativeMethodInfoPtr_get_zyxz_Public_get_uint4_0;

		// Token: 0x04002425 RID: 9253
		private static readonly IntPtr NativeMethodInfoPtr_get_zyxw_Public_get_uint4_0;

		// Token: 0x04002426 RID: 9254
		private static readonly IntPtr NativeMethodInfoPtr_set_zyxw_Public_set_Void_uint4_0;

		// Token: 0x04002427 RID: 9255
		private static readonly IntPtr NativeMethodInfoPtr_get_zyyx_Public_get_uint4_0;

		// Token: 0x04002428 RID: 9256
		private static readonly IntPtr NativeMethodInfoPtr_get_zyyy_Public_get_uint4_0;

		// Token: 0x04002429 RID: 9257
		private static readonly IntPtr NativeMethodInfoPtr_get_zyyz_Public_get_uint4_0;

		// Token: 0x0400242A RID: 9258
		private static readonly IntPtr NativeMethodInfoPtr_get_zyyw_Public_get_uint4_0;

		// Token: 0x0400242B RID: 9259
		private static readonly IntPtr NativeMethodInfoPtr_get_zyzx_Public_get_uint4_0;

		// Token: 0x0400242C RID: 9260
		private static readonly IntPtr NativeMethodInfoPtr_get_zyzy_Public_get_uint4_0;

		// Token: 0x0400242D RID: 9261
		private static readonly IntPtr NativeMethodInfoPtr_get_zyzz_Public_get_uint4_0;

		// Token: 0x0400242E RID: 9262
		private static readonly IntPtr NativeMethodInfoPtr_get_zyzw_Public_get_uint4_0;

		// Token: 0x0400242F RID: 9263
		private static readonly IntPtr NativeMethodInfoPtr_get_zywx_Public_get_uint4_0;

		// Token: 0x04002430 RID: 9264
		private static readonly IntPtr NativeMethodInfoPtr_set_zywx_Public_set_Void_uint4_0;

		// Token: 0x04002431 RID: 9265
		private static readonly IntPtr NativeMethodInfoPtr_get_zywy_Public_get_uint4_0;

		// Token: 0x04002432 RID: 9266
		private static readonly IntPtr NativeMethodInfoPtr_get_zywz_Public_get_uint4_0;

		// Token: 0x04002433 RID: 9267
		private static readonly IntPtr NativeMethodInfoPtr_get_zyww_Public_get_uint4_0;

		// Token: 0x04002434 RID: 9268
		private static readonly IntPtr NativeMethodInfoPtr_get_zzxx_Public_get_uint4_0;

		// Token: 0x04002435 RID: 9269
		private static readonly IntPtr NativeMethodInfoPtr_get_zzxy_Public_get_uint4_0;

		// Token: 0x04002436 RID: 9270
		private static readonly IntPtr NativeMethodInfoPtr_get_zzxz_Public_get_uint4_0;

		// Token: 0x04002437 RID: 9271
		private static readonly IntPtr NativeMethodInfoPtr_get_zzxw_Public_get_uint4_0;

		// Token: 0x04002438 RID: 9272
		private static readonly IntPtr NativeMethodInfoPtr_get_zzyx_Public_get_uint4_0;

		// Token: 0x04002439 RID: 9273
		private static readonly IntPtr NativeMethodInfoPtr_get_zzyy_Public_get_uint4_0;

		// Token: 0x0400243A RID: 9274
		private static readonly IntPtr NativeMethodInfoPtr_get_zzyz_Public_get_uint4_0;

		// Token: 0x0400243B RID: 9275
		private static readonly IntPtr NativeMethodInfoPtr_get_zzyw_Public_get_uint4_0;

		// Token: 0x0400243C RID: 9276
		private static readonly IntPtr NativeMethodInfoPtr_get_zzzx_Public_get_uint4_0;

		// Token: 0x0400243D RID: 9277
		private static readonly IntPtr NativeMethodInfoPtr_get_zzzy_Public_get_uint4_0;

		// Token: 0x0400243E RID: 9278
		private static readonly IntPtr NativeMethodInfoPtr_get_zzzz_Public_get_uint4_0;

		// Token: 0x0400243F RID: 9279
		private static readonly IntPtr NativeMethodInfoPtr_get_zzzw_Public_get_uint4_0;

		// Token: 0x04002440 RID: 9280
		private static readonly IntPtr NativeMethodInfoPtr_get_zzwx_Public_get_uint4_0;

		// Token: 0x04002441 RID: 9281
		private static readonly IntPtr NativeMethodInfoPtr_get_zzwy_Public_get_uint4_0;

		// Token: 0x04002442 RID: 9282
		private static readonly IntPtr NativeMethodInfoPtr_get_zzwz_Public_get_uint4_0;

		// Token: 0x04002443 RID: 9283
		private static readonly IntPtr NativeMethodInfoPtr_get_zzww_Public_get_uint4_0;

		// Token: 0x04002444 RID: 9284
		private static readonly IntPtr NativeMethodInfoPtr_get_zwxx_Public_get_uint4_0;

		// Token: 0x04002445 RID: 9285
		private static readonly IntPtr NativeMethodInfoPtr_get_zwxy_Public_get_uint4_0;

		// Token: 0x04002446 RID: 9286
		private static readonly IntPtr NativeMethodInfoPtr_set_zwxy_Public_set_Void_uint4_0;

		// Token: 0x04002447 RID: 9287
		private static readonly IntPtr NativeMethodInfoPtr_get_zwxz_Public_get_uint4_0;

		// Token: 0x04002448 RID: 9288
		private static readonly IntPtr NativeMethodInfoPtr_get_zwxw_Public_get_uint4_0;

		// Token: 0x04002449 RID: 9289
		private static readonly IntPtr NativeMethodInfoPtr_get_zwyx_Public_get_uint4_0;

		// Token: 0x0400244A RID: 9290
		private static readonly IntPtr NativeMethodInfoPtr_set_zwyx_Public_set_Void_uint4_0;

		// Token: 0x0400244B RID: 9291
		private static readonly IntPtr NativeMethodInfoPtr_get_zwyy_Public_get_uint4_0;

		// Token: 0x0400244C RID: 9292
		private static readonly IntPtr NativeMethodInfoPtr_get_zwyz_Public_get_uint4_0;

		// Token: 0x0400244D RID: 9293
		private static readonly IntPtr NativeMethodInfoPtr_get_zwyw_Public_get_uint4_0;

		// Token: 0x0400244E RID: 9294
		private static readonly IntPtr NativeMethodInfoPtr_get_zwzx_Public_get_uint4_0;

		// Token: 0x0400244F RID: 9295
		private static readonly IntPtr NativeMethodInfoPtr_get_zwzy_Public_get_uint4_0;

		// Token: 0x04002450 RID: 9296
		private static readonly IntPtr NativeMethodInfoPtr_get_zwzz_Public_get_uint4_0;

		// Token: 0x04002451 RID: 9297
		private static readonly IntPtr NativeMethodInfoPtr_get_zwzw_Public_get_uint4_0;

		// Token: 0x04002452 RID: 9298
		private static readonly IntPtr NativeMethodInfoPtr_get_zwwx_Public_get_uint4_0;

		// Token: 0x04002453 RID: 9299
		private static readonly IntPtr NativeMethodInfoPtr_get_zwwy_Public_get_uint4_0;

		// Token: 0x04002454 RID: 9300
		private static readonly IntPtr NativeMethodInfoPtr_get_zwwz_Public_get_uint4_0;

		// Token: 0x04002455 RID: 9301
		private static readonly IntPtr NativeMethodInfoPtr_get_zwww_Public_get_uint4_0;

		// Token: 0x04002456 RID: 9302
		private static readonly IntPtr NativeMethodInfoPtr_get_wxxx_Public_get_uint4_0;

		// Token: 0x04002457 RID: 9303
		private static readonly IntPtr NativeMethodInfoPtr_get_wxxy_Public_get_uint4_0;

		// Token: 0x04002458 RID: 9304
		private static readonly IntPtr NativeMethodInfoPtr_get_wxxz_Public_get_uint4_0;

		// Token: 0x04002459 RID: 9305
		private static readonly IntPtr NativeMethodInfoPtr_get_wxxw_Public_get_uint4_0;

		// Token: 0x0400245A RID: 9306
		private static readonly IntPtr NativeMethodInfoPtr_get_wxyx_Public_get_uint4_0;

		// Token: 0x0400245B RID: 9307
		private static readonly IntPtr NativeMethodInfoPtr_get_wxyy_Public_get_uint4_0;

		// Token: 0x0400245C RID: 9308
		private static readonly IntPtr NativeMethodInfoPtr_get_wxyz_Public_get_uint4_0;

		// Token: 0x0400245D RID: 9309
		private static readonly IntPtr NativeMethodInfoPtr_set_wxyz_Public_set_Void_uint4_0;

		// Token: 0x0400245E RID: 9310
		private static readonly IntPtr NativeMethodInfoPtr_get_wxyw_Public_get_uint4_0;

		// Token: 0x0400245F RID: 9311
		private static readonly IntPtr NativeMethodInfoPtr_get_wxzx_Public_get_uint4_0;

		// Token: 0x04002460 RID: 9312
		private static readonly IntPtr NativeMethodInfoPtr_get_wxzy_Public_get_uint4_0;

		// Token: 0x04002461 RID: 9313
		private static readonly IntPtr NativeMethodInfoPtr_set_wxzy_Public_set_Void_uint4_0;

		// Token: 0x04002462 RID: 9314
		private static readonly IntPtr NativeMethodInfoPtr_get_wxzz_Public_get_uint4_0;

		// Token: 0x04002463 RID: 9315
		private static readonly IntPtr NativeMethodInfoPtr_get_wxzw_Public_get_uint4_0;

		// Token: 0x04002464 RID: 9316
		private static readonly IntPtr NativeMethodInfoPtr_get_wxwx_Public_get_uint4_0;

		// Token: 0x04002465 RID: 9317
		private static readonly IntPtr NativeMethodInfoPtr_get_wxwy_Public_get_uint4_0;

		// Token: 0x04002466 RID: 9318
		private static readonly IntPtr NativeMethodInfoPtr_get_wxwz_Public_get_uint4_0;

		// Token: 0x04002467 RID: 9319
		private static readonly IntPtr NativeMethodInfoPtr_get_wxww_Public_get_uint4_0;

		// Token: 0x04002468 RID: 9320
		private static readonly IntPtr NativeMethodInfoPtr_get_wyxx_Public_get_uint4_0;

		// Token: 0x04002469 RID: 9321
		private static readonly IntPtr NativeMethodInfoPtr_get_wyxy_Public_get_uint4_0;

		// Token: 0x0400246A RID: 9322
		private static readonly IntPtr NativeMethodInfoPtr_get_wyxz_Public_get_uint4_0;

		// Token: 0x0400246B RID: 9323
		private static readonly IntPtr NativeMethodInfoPtr_set_wyxz_Public_set_Void_uint4_0;

		// Token: 0x0400246C RID: 9324
		private static readonly IntPtr NativeMethodInfoPtr_get_wyxw_Public_get_uint4_0;

		// Token: 0x0400246D RID: 9325
		private static readonly IntPtr NativeMethodInfoPtr_get_wyyx_Public_get_uint4_0;

		// Token: 0x0400246E RID: 9326
		private static readonly IntPtr NativeMethodInfoPtr_get_wyyy_Public_get_uint4_0;

		// Token: 0x0400246F RID: 9327
		private static readonly IntPtr NativeMethodInfoPtr_get_wyyz_Public_get_uint4_0;

		// Token: 0x04002470 RID: 9328
		private static readonly IntPtr NativeMethodInfoPtr_get_wyyw_Public_get_uint4_0;

		// Token: 0x04002471 RID: 9329
		private static readonly IntPtr NativeMethodInfoPtr_get_wyzx_Public_get_uint4_0;

		// Token: 0x04002472 RID: 9330
		private static readonly IntPtr NativeMethodInfoPtr_set_wyzx_Public_set_Void_uint4_0;

		// Token: 0x04002473 RID: 9331
		private static readonly IntPtr NativeMethodInfoPtr_get_wyzy_Public_get_uint4_0;

		// Token: 0x04002474 RID: 9332
		private static readonly IntPtr NativeMethodInfoPtr_get_wyzz_Public_get_uint4_0;

		// Token: 0x04002475 RID: 9333
		private static readonly IntPtr NativeMethodInfoPtr_get_wyzw_Public_get_uint4_0;

		// Token: 0x04002476 RID: 9334
		private static readonly IntPtr NativeMethodInfoPtr_get_wywx_Public_get_uint4_0;

		// Token: 0x04002477 RID: 9335
		private static readonly IntPtr NativeMethodInfoPtr_get_wywy_Public_get_uint4_0;

		// Token: 0x04002478 RID: 9336
		private static readonly IntPtr NativeMethodInfoPtr_get_wywz_Public_get_uint4_0;

		// Token: 0x04002479 RID: 9337
		private static readonly IntPtr NativeMethodInfoPtr_get_wyww_Public_get_uint4_0;

		// Token: 0x0400247A RID: 9338
		private static readonly IntPtr NativeMethodInfoPtr_get_wzxx_Public_get_uint4_0;

		// Token: 0x0400247B RID: 9339
		private static readonly IntPtr NativeMethodInfoPtr_get_wzxy_Public_get_uint4_0;

		// Token: 0x0400247C RID: 9340
		private static readonly IntPtr NativeMethodInfoPtr_set_wzxy_Public_set_Void_uint4_0;

		// Token: 0x0400247D RID: 9341
		private static readonly IntPtr NativeMethodInfoPtr_get_wzxz_Public_get_uint4_0;

		// Token: 0x0400247E RID: 9342
		private static readonly IntPtr NativeMethodInfoPtr_get_wzxw_Public_get_uint4_0;

		// Token: 0x0400247F RID: 9343
		private static readonly IntPtr NativeMethodInfoPtr_get_wzyx_Public_get_uint4_0;

		// Token: 0x04002480 RID: 9344
		private static readonly IntPtr NativeMethodInfoPtr_set_wzyx_Public_set_Void_uint4_0;

		// Token: 0x04002481 RID: 9345
		private static readonly IntPtr NativeMethodInfoPtr_get_wzyy_Public_get_uint4_0;

		// Token: 0x04002482 RID: 9346
		private static readonly IntPtr NativeMethodInfoPtr_get_wzyz_Public_get_uint4_0;

		// Token: 0x04002483 RID: 9347
		private static readonly IntPtr NativeMethodInfoPtr_get_wzyw_Public_get_uint4_0;

		// Token: 0x04002484 RID: 9348
		private static readonly IntPtr NativeMethodInfoPtr_get_wzzx_Public_get_uint4_0;

		// Token: 0x04002485 RID: 9349
		private static readonly IntPtr NativeMethodInfoPtr_get_wzzy_Public_get_uint4_0;

		// Token: 0x04002486 RID: 9350
		private static readonly IntPtr NativeMethodInfoPtr_get_wzzz_Public_get_uint4_0;

		// Token: 0x04002487 RID: 9351
		private static readonly IntPtr NativeMethodInfoPtr_get_wzzw_Public_get_uint4_0;

		// Token: 0x04002488 RID: 9352
		private static readonly IntPtr NativeMethodInfoPtr_get_wzwx_Public_get_uint4_0;

		// Token: 0x04002489 RID: 9353
		private static readonly IntPtr NativeMethodInfoPtr_get_wzwy_Public_get_uint4_0;

		// Token: 0x0400248A RID: 9354
		private static readonly IntPtr NativeMethodInfoPtr_get_wzwz_Public_get_uint4_0;

		// Token: 0x0400248B RID: 9355
		private static readonly IntPtr NativeMethodInfoPtr_get_wzww_Public_get_uint4_0;

		// Token: 0x0400248C RID: 9356
		private static readonly IntPtr NativeMethodInfoPtr_get_wwxx_Public_get_uint4_0;

		// Token: 0x0400248D RID: 9357
		private static readonly IntPtr NativeMethodInfoPtr_get_wwxy_Public_get_uint4_0;

		// Token: 0x0400248E RID: 9358
		private static readonly IntPtr NativeMethodInfoPtr_get_wwxz_Public_get_uint4_0;

		// Token: 0x0400248F RID: 9359
		private static readonly IntPtr NativeMethodInfoPtr_get_wwxw_Public_get_uint4_0;

		// Token: 0x04002490 RID: 9360
		private static readonly IntPtr NativeMethodInfoPtr_get_wwyx_Public_get_uint4_0;

		// Token: 0x04002491 RID: 9361
		private static readonly IntPtr NativeMethodInfoPtr_get_wwyy_Public_get_uint4_0;

		// Token: 0x04002492 RID: 9362
		private static readonly IntPtr NativeMethodInfoPtr_get_wwyz_Public_get_uint4_0;

		// Token: 0x04002493 RID: 9363
		private static readonly IntPtr NativeMethodInfoPtr_get_wwyw_Public_get_uint4_0;

		// Token: 0x04002494 RID: 9364
		private static readonly IntPtr NativeMethodInfoPtr_get_wwzx_Public_get_uint4_0;

		// Token: 0x04002495 RID: 9365
		private static readonly IntPtr NativeMethodInfoPtr_get_wwzy_Public_get_uint4_0;

		// Token: 0x04002496 RID: 9366
		private static readonly IntPtr NativeMethodInfoPtr_get_wwzz_Public_get_uint4_0;

		// Token: 0x04002497 RID: 9367
		private static readonly IntPtr NativeMethodInfoPtr_get_wwzw_Public_get_uint4_0;

		// Token: 0x04002498 RID: 9368
		private static readonly IntPtr NativeMethodInfoPtr_get_wwwx_Public_get_uint4_0;

		// Token: 0x04002499 RID: 9369
		private static readonly IntPtr NativeMethodInfoPtr_get_wwwy_Public_get_uint4_0;

		// Token: 0x0400249A RID: 9370
		private static readonly IntPtr NativeMethodInfoPtr_get_wwwz_Public_get_uint4_0;

		// Token: 0x0400249B RID: 9371
		private static readonly IntPtr NativeMethodInfoPtr_get_wwww_Public_get_uint4_0;

		// Token: 0x0400249C RID: 9372
		private static readonly IntPtr NativeMethodInfoPtr_get_xxx_Public_get_uint3_0;

		// Token: 0x0400249D RID: 9373
		private static readonly IntPtr NativeMethodInfoPtr_get_xxy_Public_get_uint3_0;

		// Token: 0x0400249E RID: 9374
		private static readonly IntPtr NativeMethodInfoPtr_get_xxz_Public_get_uint3_0;

		// Token: 0x0400249F RID: 9375
		private static readonly IntPtr NativeMethodInfoPtr_get_xxw_Public_get_uint3_0;

		// Token: 0x040024A0 RID: 9376
		private static readonly IntPtr NativeMethodInfoPtr_get_xyx_Public_get_uint3_0;

		// Token: 0x040024A1 RID: 9377
		private static readonly IntPtr NativeMethodInfoPtr_get_xyy_Public_get_uint3_0;

		// Token: 0x040024A2 RID: 9378
		private static readonly IntPtr NativeMethodInfoPtr_get_xyz_Public_get_uint3_0;

		// Token: 0x040024A3 RID: 9379
		private static readonly IntPtr NativeMethodInfoPtr_set_xyz_Public_set_Void_uint3_0;

		// Token: 0x040024A4 RID: 9380
		private static readonly IntPtr NativeMethodInfoPtr_get_xyw_Public_get_uint3_0;

		// Token: 0x040024A5 RID: 9381
		private static readonly IntPtr NativeMethodInfoPtr_set_xyw_Public_set_Void_uint3_0;

		// Token: 0x040024A6 RID: 9382
		private static readonly IntPtr NativeMethodInfoPtr_get_xzx_Public_get_uint3_0;

		// Token: 0x040024A7 RID: 9383
		private static readonly IntPtr NativeMethodInfoPtr_get_xzy_Public_get_uint3_0;

		// Token: 0x040024A8 RID: 9384
		private static readonly IntPtr NativeMethodInfoPtr_set_xzy_Public_set_Void_uint3_0;

		// Token: 0x040024A9 RID: 9385
		private static readonly IntPtr NativeMethodInfoPtr_get_xzz_Public_get_uint3_0;

		// Token: 0x040024AA RID: 9386
		private static readonly IntPtr NativeMethodInfoPtr_get_xzw_Public_get_uint3_0;

		// Token: 0x040024AB RID: 9387
		private static readonly IntPtr NativeMethodInfoPtr_set_xzw_Public_set_Void_uint3_0;

		// Token: 0x040024AC RID: 9388
		private static readonly IntPtr NativeMethodInfoPtr_get_xwx_Public_get_uint3_0;

		// Token: 0x040024AD RID: 9389
		private static readonly IntPtr NativeMethodInfoPtr_get_xwy_Public_get_uint3_0;

		// Token: 0x040024AE RID: 9390
		private static readonly IntPtr NativeMethodInfoPtr_set_xwy_Public_set_Void_uint3_0;

		// Token: 0x040024AF RID: 9391
		private static readonly IntPtr NativeMethodInfoPtr_get_xwz_Public_get_uint3_0;

		// Token: 0x040024B0 RID: 9392
		private static readonly IntPtr NativeMethodInfoPtr_set_xwz_Public_set_Void_uint3_0;

		// Token: 0x040024B1 RID: 9393
		private static readonly IntPtr NativeMethodInfoPtr_get_xww_Public_get_uint3_0;

		// Token: 0x040024B2 RID: 9394
		private static readonly IntPtr NativeMethodInfoPtr_get_yxx_Public_get_uint3_0;

		// Token: 0x040024B3 RID: 9395
		private static readonly IntPtr NativeMethodInfoPtr_get_yxy_Public_get_uint3_0;

		// Token: 0x040024B4 RID: 9396
		private static readonly IntPtr NativeMethodInfoPtr_get_yxz_Public_get_uint3_0;

		// Token: 0x040024B5 RID: 9397
		private static readonly IntPtr NativeMethodInfoPtr_set_yxz_Public_set_Void_uint3_0;

		// Token: 0x040024B6 RID: 9398
		private static readonly IntPtr NativeMethodInfoPtr_get_yxw_Public_get_uint3_0;

		// Token: 0x040024B7 RID: 9399
		private static readonly IntPtr NativeMethodInfoPtr_set_yxw_Public_set_Void_uint3_0;

		// Token: 0x040024B8 RID: 9400
		private static readonly IntPtr NativeMethodInfoPtr_get_yyx_Public_get_uint3_0;

		// Token: 0x040024B9 RID: 9401
		private static readonly IntPtr NativeMethodInfoPtr_get_yyy_Public_get_uint3_0;

		// Token: 0x040024BA RID: 9402
		private static readonly IntPtr NativeMethodInfoPtr_get_yyz_Public_get_uint3_0;

		// Token: 0x040024BB RID: 9403
		private static readonly IntPtr NativeMethodInfoPtr_get_yyw_Public_get_uint3_0;

		// Token: 0x040024BC RID: 9404
		private static readonly IntPtr NativeMethodInfoPtr_get_yzx_Public_get_uint3_0;

		// Token: 0x040024BD RID: 9405
		private static readonly IntPtr NativeMethodInfoPtr_set_yzx_Public_set_Void_uint3_0;

		// Token: 0x040024BE RID: 9406
		private static readonly IntPtr NativeMethodInfoPtr_get_yzy_Public_get_uint3_0;

		// Token: 0x040024BF RID: 9407
		private static readonly IntPtr NativeMethodInfoPtr_get_yzz_Public_get_uint3_0;

		// Token: 0x040024C0 RID: 9408
		private static readonly IntPtr NativeMethodInfoPtr_get_yzw_Public_get_uint3_0;

		// Token: 0x040024C1 RID: 9409
		private static readonly IntPtr NativeMethodInfoPtr_set_yzw_Public_set_Void_uint3_0;

		// Token: 0x040024C2 RID: 9410
		private static readonly IntPtr NativeMethodInfoPtr_get_ywx_Public_get_uint3_0;

		// Token: 0x040024C3 RID: 9411
		private static readonly IntPtr NativeMethodInfoPtr_set_ywx_Public_set_Void_uint3_0;

		// Token: 0x040024C4 RID: 9412
		private static readonly IntPtr NativeMethodInfoPtr_get_ywy_Public_get_uint3_0;

		// Token: 0x040024C5 RID: 9413
		private static readonly IntPtr NativeMethodInfoPtr_get_ywz_Public_get_uint3_0;

		// Token: 0x040024C6 RID: 9414
		private static readonly IntPtr NativeMethodInfoPtr_set_ywz_Public_set_Void_uint3_0;

		// Token: 0x040024C7 RID: 9415
		private static readonly IntPtr NativeMethodInfoPtr_get_yww_Public_get_uint3_0;

		// Token: 0x040024C8 RID: 9416
		private static readonly IntPtr NativeMethodInfoPtr_get_zxx_Public_get_uint3_0;

		// Token: 0x040024C9 RID: 9417
		private static readonly IntPtr NativeMethodInfoPtr_get_zxy_Public_get_uint3_0;

		// Token: 0x040024CA RID: 9418
		private static readonly IntPtr NativeMethodInfoPtr_set_zxy_Public_set_Void_uint3_0;

		// Token: 0x040024CB RID: 9419
		private static readonly IntPtr NativeMethodInfoPtr_get_zxz_Public_get_uint3_0;

		// Token: 0x040024CC RID: 9420
		private static readonly IntPtr NativeMethodInfoPtr_get_zxw_Public_get_uint3_0;

		// Token: 0x040024CD RID: 9421
		private static readonly IntPtr NativeMethodInfoPtr_set_zxw_Public_set_Void_uint3_0;

		// Token: 0x040024CE RID: 9422
		private static readonly IntPtr NativeMethodInfoPtr_get_zyx_Public_get_uint3_0;

		// Token: 0x040024CF RID: 9423
		private static readonly IntPtr NativeMethodInfoPtr_set_zyx_Public_set_Void_uint3_0;

		// Token: 0x040024D0 RID: 9424
		private static readonly IntPtr NativeMethodInfoPtr_get_zyy_Public_get_uint3_0;

		// Token: 0x040024D1 RID: 9425
		private static readonly IntPtr NativeMethodInfoPtr_get_zyz_Public_get_uint3_0;

		// Token: 0x040024D2 RID: 9426
		private static readonly IntPtr NativeMethodInfoPtr_get_zyw_Public_get_uint3_0;

		// Token: 0x040024D3 RID: 9427
		private static readonly IntPtr NativeMethodInfoPtr_set_zyw_Public_set_Void_uint3_0;

		// Token: 0x040024D4 RID: 9428
		private static readonly IntPtr NativeMethodInfoPtr_get_zzx_Public_get_uint3_0;

		// Token: 0x040024D5 RID: 9429
		private static readonly IntPtr NativeMethodInfoPtr_get_zzy_Public_get_uint3_0;

		// Token: 0x040024D6 RID: 9430
		private static readonly IntPtr NativeMethodInfoPtr_get_zzz_Public_get_uint3_0;

		// Token: 0x040024D7 RID: 9431
		private static readonly IntPtr NativeMethodInfoPtr_get_zzw_Public_get_uint3_0;

		// Token: 0x040024D8 RID: 9432
		private static readonly IntPtr NativeMethodInfoPtr_get_zwx_Public_get_uint3_0;

		// Token: 0x040024D9 RID: 9433
		private static readonly IntPtr NativeMethodInfoPtr_set_zwx_Public_set_Void_uint3_0;

		// Token: 0x040024DA RID: 9434
		private static readonly IntPtr NativeMethodInfoPtr_get_zwy_Public_get_uint3_0;

		// Token: 0x040024DB RID: 9435
		private static readonly IntPtr NativeMethodInfoPtr_set_zwy_Public_set_Void_uint3_0;

		// Token: 0x040024DC RID: 9436
		private static readonly IntPtr NativeMethodInfoPtr_get_zwz_Public_get_uint3_0;

		// Token: 0x040024DD RID: 9437
		private static readonly IntPtr NativeMethodInfoPtr_get_zww_Public_get_uint3_0;

		// Token: 0x040024DE RID: 9438
		private static readonly IntPtr NativeMethodInfoPtr_get_wxx_Public_get_uint3_0;

		// Token: 0x040024DF RID: 9439
		private static readonly IntPtr NativeMethodInfoPtr_get_wxy_Public_get_uint3_0;

		// Token: 0x040024E0 RID: 9440
		private static readonly IntPtr NativeMethodInfoPtr_set_wxy_Public_set_Void_uint3_0;

		// Token: 0x040024E1 RID: 9441
		private static readonly IntPtr NativeMethodInfoPtr_get_wxz_Public_get_uint3_0;

		// Token: 0x040024E2 RID: 9442
		private static readonly IntPtr NativeMethodInfoPtr_set_wxz_Public_set_Void_uint3_0;

		// Token: 0x040024E3 RID: 9443
		private static readonly IntPtr NativeMethodInfoPtr_get_wxw_Public_get_uint3_0;

		// Token: 0x040024E4 RID: 9444
		private static readonly IntPtr NativeMethodInfoPtr_get_wyx_Public_get_uint3_0;

		// Token: 0x040024E5 RID: 9445
		private static readonly IntPtr NativeMethodInfoPtr_set_wyx_Public_set_Void_uint3_0;

		// Token: 0x040024E6 RID: 9446
		private static readonly IntPtr NativeMethodInfoPtr_get_wyy_Public_get_uint3_0;

		// Token: 0x040024E7 RID: 9447
		private static readonly IntPtr NativeMethodInfoPtr_get_wyz_Public_get_uint3_0;

		// Token: 0x040024E8 RID: 9448
		private static readonly IntPtr NativeMethodInfoPtr_set_wyz_Public_set_Void_uint3_0;

		// Token: 0x040024E9 RID: 9449
		private static readonly IntPtr NativeMethodInfoPtr_get_wyw_Public_get_uint3_0;

		// Token: 0x040024EA RID: 9450
		private static readonly IntPtr NativeMethodInfoPtr_get_wzx_Public_get_uint3_0;

		// Token: 0x040024EB RID: 9451
		private static readonly IntPtr NativeMethodInfoPtr_set_wzx_Public_set_Void_uint3_0;

		// Token: 0x040024EC RID: 9452
		private static readonly IntPtr NativeMethodInfoPtr_get_wzy_Public_get_uint3_0;

		// Token: 0x040024ED RID: 9453
		private static readonly IntPtr NativeMethodInfoPtr_set_wzy_Public_set_Void_uint3_0;

		// Token: 0x040024EE RID: 9454
		private static readonly IntPtr NativeMethodInfoPtr_get_wzz_Public_get_uint3_0;

		// Token: 0x040024EF RID: 9455
		private static readonly IntPtr NativeMethodInfoPtr_get_wzw_Public_get_uint3_0;

		// Token: 0x040024F0 RID: 9456
		private static readonly IntPtr NativeMethodInfoPtr_get_wwx_Public_get_uint3_0;

		// Token: 0x040024F1 RID: 9457
		private static readonly IntPtr NativeMethodInfoPtr_get_wwy_Public_get_uint3_0;

		// Token: 0x040024F2 RID: 9458
		private static readonly IntPtr NativeMethodInfoPtr_get_wwz_Public_get_uint3_0;

		// Token: 0x040024F3 RID: 9459
		private static readonly IntPtr NativeMethodInfoPtr_get_www_Public_get_uint3_0;

		// Token: 0x040024F4 RID: 9460
		private static readonly IntPtr NativeMethodInfoPtr_get_xx_Public_get_uint2_0;

		// Token: 0x040024F5 RID: 9461
		private static readonly IntPtr NativeMethodInfoPtr_get_xy_Public_get_uint2_0;

		// Token: 0x040024F6 RID: 9462
		private static readonly IntPtr NativeMethodInfoPtr_set_xy_Public_set_Void_uint2_0;

		// Token: 0x040024F7 RID: 9463
		private static readonly IntPtr NativeMethodInfoPtr_get_xz_Public_get_uint2_0;

		// Token: 0x040024F8 RID: 9464
		private static readonly IntPtr NativeMethodInfoPtr_set_xz_Public_set_Void_uint2_0;

		// Token: 0x040024F9 RID: 9465
		private static readonly IntPtr NativeMethodInfoPtr_get_xw_Public_get_uint2_0;

		// Token: 0x040024FA RID: 9466
		private static readonly IntPtr NativeMethodInfoPtr_set_xw_Public_set_Void_uint2_0;

		// Token: 0x040024FB RID: 9467
		private static readonly IntPtr NativeMethodInfoPtr_get_yx_Public_get_uint2_0;

		// Token: 0x040024FC RID: 9468
		private static readonly IntPtr NativeMethodInfoPtr_set_yx_Public_set_Void_uint2_0;

		// Token: 0x040024FD RID: 9469
		private static readonly IntPtr NativeMethodInfoPtr_get_yy_Public_get_uint2_0;

		// Token: 0x040024FE RID: 9470
		private static readonly IntPtr NativeMethodInfoPtr_get_yz_Public_get_uint2_0;

		// Token: 0x040024FF RID: 9471
		private static readonly IntPtr NativeMethodInfoPtr_set_yz_Public_set_Void_uint2_0;

		// Token: 0x04002500 RID: 9472
		private static readonly IntPtr NativeMethodInfoPtr_get_yw_Public_get_uint2_0;

		// Token: 0x04002501 RID: 9473
		private static readonly IntPtr NativeMethodInfoPtr_set_yw_Public_set_Void_uint2_0;

		// Token: 0x04002502 RID: 9474
		private static readonly IntPtr NativeMethodInfoPtr_get_zx_Public_get_uint2_0;

		// Token: 0x04002503 RID: 9475
		private static readonly IntPtr NativeMethodInfoPtr_set_zx_Public_set_Void_uint2_0;

		// Token: 0x04002504 RID: 9476
		private static readonly IntPtr NativeMethodInfoPtr_get_zy_Public_get_uint2_0;

		// Token: 0x04002505 RID: 9477
		private static readonly IntPtr NativeMethodInfoPtr_set_zy_Public_set_Void_uint2_0;

		// Token: 0x04002506 RID: 9478
		private static readonly IntPtr NativeMethodInfoPtr_get_zz_Public_get_uint2_0;

		// Token: 0x04002507 RID: 9479
		private static readonly IntPtr NativeMethodInfoPtr_get_zw_Public_get_uint2_0;

		// Token: 0x04002508 RID: 9480
		private static readonly IntPtr NativeMethodInfoPtr_set_zw_Public_set_Void_uint2_0;

		// Token: 0x04002509 RID: 9481
		private static readonly IntPtr NativeMethodInfoPtr_get_wx_Public_get_uint2_0;

		// Token: 0x0400250A RID: 9482
		private static readonly IntPtr NativeMethodInfoPtr_set_wx_Public_set_Void_uint2_0;

		// Token: 0x0400250B RID: 9483
		private static readonly IntPtr NativeMethodInfoPtr_get_wy_Public_get_uint2_0;

		// Token: 0x0400250C RID: 9484
		private static readonly IntPtr NativeMethodInfoPtr_set_wy_Public_set_Void_uint2_0;

		// Token: 0x0400250D RID: 9485
		private static readonly IntPtr NativeMethodInfoPtr_get_wz_Public_get_uint2_0;

		// Token: 0x0400250E RID: 9486
		private static readonly IntPtr NativeMethodInfoPtr_set_wz_Public_set_Void_uint2_0;

		// Token: 0x0400250F RID: 9487
		private static readonly IntPtr NativeMethodInfoPtr_get_ww_Public_get_uint2_0;

		// Token: 0x04002510 RID: 9488
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_UInt32_Int32_0;

		// Token: 0x04002511 RID: 9489
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_UInt32_0;

		// Token: 0x04002512 RID: 9490
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_uint4_0;

		// Token: 0x04002513 RID: 9491
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002514 RID: 9492
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002515 RID: 9493
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002516 RID: 9494
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04002517 RID: 9495
		[FieldOffset(0)]
		public uint x;

		// Token: 0x04002518 RID: 9496
		[FieldOffset(4)]
		public uint y;

		// Token: 0x04002519 RID: 9497
		[FieldOffset(8)]
		public uint z;

		// Token: 0x0400251A RID: 9498
		[FieldOffset(12)]
		public uint w;

		// Token: 0x02000065 RID: 101
		public sealed class DebuggerProxy : Object
		{
			// Token: 0x06002650 RID: 9808 RVA: 0x000C421C File Offset: 0x000C241C
			// Note: this type is marked as 'beforefieldinit'.
			static DebuggerProxy()
			{
				Il2CppClassPointerStore<uint4.DebuggerProxy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<uint4>.NativeClassPtr, "DebuggerProxy");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<uint4.DebuggerProxy>.NativeClassPtr);
				uint4.DebuggerProxy.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint4.DebuggerProxy>.NativeClassPtr, "x");
				uint4.DebuggerProxy.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint4.DebuggerProxy>.NativeClassPtr, "y");
				uint4.DebuggerProxy.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint4.DebuggerProxy>.NativeClassPtr, "z");
				uint4.DebuggerProxy.NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint4.DebuggerProxy>.NativeClassPtr, "w");
				uint4.DebuggerProxy.NativeMethodInfoPtr__ctor_Public_Void_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4.DebuggerProxy>.NativeClassPtr, 100672372);
			}

			// Token: 0x06002651 RID: 9809 RVA: 0x000C42AC File Offset: 0x000C24AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DebuggerProxy(uint4 v)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<uint4.DebuggerProxy>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4.DebuggerProxy.NativeMethodInfoPtr__ctor_Public_Void_uint4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002652 RID: 9810 RVA: 0x000031B6 File Offset: 0x000013B6
			public DebuggerProxy(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C23 RID: 3107
			// (get) Token: 0x06002653 RID: 9811 RVA: 0x000C42F4 File Offset: 0x000C24F4
			// (set) Token: 0x06002654 RID: 9812 RVA: 0x000031BF File Offset: 0x000013BF
			public unsafe uint x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(uint4.DebuggerProxy.NativeFieldInfoPtr_x);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(uint4.DebuggerProxy.NativeFieldInfoPtr_x)) = value;
				}
			}

			// Token: 0x17000C24 RID: 3108
			// (get) Token: 0x06002655 RID: 9813 RVA: 0x000C431C File Offset: 0x000C251C
			// (set) Token: 0x06002656 RID: 9814 RVA: 0x000031DA File Offset: 0x000013DA
			public unsafe uint y
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(uint4.DebuggerProxy.NativeFieldInfoPtr_y);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(uint4.DebuggerProxy.NativeFieldInfoPtr_y)) = value;
				}
			}

			// Token: 0x17000C25 RID: 3109
			// (get) Token: 0x06002657 RID: 9815 RVA: 0x000C4344 File Offset: 0x000C2544
			// (set) Token: 0x06002658 RID: 9816 RVA: 0x000031F5 File Offset: 0x000013F5
			public unsafe uint z
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(uint4.DebuggerProxy.NativeFieldInfoPtr_z);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(uint4.DebuggerProxy.NativeFieldInfoPtr_z)) = value;
				}
			}

			// Token: 0x17000C26 RID: 3110
			// (get) Token: 0x06002659 RID: 9817 RVA: 0x000C436C File Offset: 0x000C256C
			// (set) Token: 0x0600265A RID: 9818 RVA: 0x00003210 File Offset: 0x00001410
			public unsafe uint w
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(uint4.DebuggerProxy.NativeFieldInfoPtr_w);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(uint4.DebuggerProxy.NativeFieldInfoPtr_w)) = value;
				}
			}

			// Token: 0x0400269F RID: 9887
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x040026A0 RID: 9888
			private static readonly IntPtr NativeFieldInfoPtr_y;

			// Token: 0x040026A1 RID: 9889
			private static readonly IntPtr NativeFieldInfoPtr_z;

			// Token: 0x040026A2 RID: 9890
			private static readonly IntPtr NativeFieldInfoPtr_w;

			// Token: 0x040026A3 RID: 9891
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint4_0;
		}
	}
}
