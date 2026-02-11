using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x0200002B RID: 43
	[Serializable]
	[StructLayout(2)]
	public struct half3
	{
		// Token: 0x06001692 RID: 5778 RVA: 0x000787F4 File Offset: 0x000769F4
		// Note: this type is marked as 'beforefieldinit'.
		static half3()
		{
			Il2CppClassPointerStore<half3>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "half3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<half3>.NativeClassPtr);
			half3.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<half3>.NativeClassPtr, "x");
			half3.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<half3>.NativeClassPtr, "y");
			half3.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<half3>.NativeClassPtr, "z");
			half3.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<half3>.NativeClassPtr, "zero");
			half3.NativeMethodInfoPtr__ctor_Public_Void_half_half_half_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668901);
			half3.NativeMethodInfoPtr__ctor_Public_Void_half_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668902);
			half3.NativeMethodInfoPtr__ctor_Public_Void_half2_half_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668903);
			half3.NativeMethodInfoPtr__ctor_Public_Void_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668904);
			half3.NativeMethodInfoPtr__ctor_Public_Void_half_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668905);
			half3.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668906);
			half3.NativeMethodInfoPtr__ctor_Public_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668907);
			half3.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668908);
			half3.NativeMethodInfoPtr__ctor_Public_Void_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668909);
			half3.NativeMethodInfoPtr_op_Implicit_Public_Static_half3_half_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668910);
			half3.NativeMethodInfoPtr_op_Explicit_Public_Static_half3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668911);
			half3.NativeMethodInfoPtr_op_Explicit_Public_Static_half3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668912);
			half3.NativeMethodInfoPtr_op_Explicit_Public_Static_half3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668913);
			half3.NativeMethodInfoPtr_op_Explicit_Public_Static_half3_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668914);
			half3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3_half3_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668915);
			half3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3_half3_half_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668916);
			half3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3_half_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668917);
			half3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_half3_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668918);
			half3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_half3_half_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668919);
			half3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_half_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668920);
			half3.NativeMethodInfoPtr_get_xxxx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668921);
			half3.NativeMethodInfoPtr_get_xxxy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668922);
			half3.NativeMethodInfoPtr_get_xxxz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668923);
			half3.NativeMethodInfoPtr_get_xxyx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668924);
			half3.NativeMethodInfoPtr_get_xxyy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668925);
			half3.NativeMethodInfoPtr_get_xxyz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668926);
			half3.NativeMethodInfoPtr_get_xxzx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668927);
			half3.NativeMethodInfoPtr_get_xxzy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668928);
			half3.NativeMethodInfoPtr_get_xxzz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668929);
			half3.NativeMethodInfoPtr_get_xyxx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668930);
			half3.NativeMethodInfoPtr_get_xyxy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668931);
			half3.NativeMethodInfoPtr_get_xyxz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668932);
			half3.NativeMethodInfoPtr_get_xyyx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668933);
			half3.NativeMethodInfoPtr_get_xyyy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668934);
			half3.NativeMethodInfoPtr_get_xyyz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668935);
			half3.NativeMethodInfoPtr_get_xyzx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668936);
			half3.NativeMethodInfoPtr_get_xyzy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668937);
			half3.NativeMethodInfoPtr_get_xyzz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668938);
			half3.NativeMethodInfoPtr_get_xzxx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668939);
			half3.NativeMethodInfoPtr_get_xzxy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668940);
			half3.NativeMethodInfoPtr_get_xzxz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668941);
			half3.NativeMethodInfoPtr_get_xzyx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668942);
			half3.NativeMethodInfoPtr_get_xzyy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668943);
			half3.NativeMethodInfoPtr_get_xzyz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668944);
			half3.NativeMethodInfoPtr_get_xzzx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668945);
			half3.NativeMethodInfoPtr_get_xzzy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668946);
			half3.NativeMethodInfoPtr_get_xzzz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668947);
			half3.NativeMethodInfoPtr_get_yxxx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668948);
			half3.NativeMethodInfoPtr_get_yxxy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668949);
			half3.NativeMethodInfoPtr_get_yxxz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668950);
			half3.NativeMethodInfoPtr_get_yxyx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668951);
			half3.NativeMethodInfoPtr_get_yxyy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668952);
			half3.NativeMethodInfoPtr_get_yxyz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668953);
			half3.NativeMethodInfoPtr_get_yxzx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668954);
			half3.NativeMethodInfoPtr_get_yxzy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668955);
			half3.NativeMethodInfoPtr_get_yxzz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668956);
			half3.NativeMethodInfoPtr_get_yyxx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668957);
			half3.NativeMethodInfoPtr_get_yyxy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668958);
			half3.NativeMethodInfoPtr_get_yyxz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668959);
			half3.NativeMethodInfoPtr_get_yyyx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668960);
			half3.NativeMethodInfoPtr_get_yyyy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668961);
			half3.NativeMethodInfoPtr_get_yyyz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668962);
			half3.NativeMethodInfoPtr_get_yyzx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668963);
			half3.NativeMethodInfoPtr_get_yyzy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668964);
			half3.NativeMethodInfoPtr_get_yyzz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668965);
			half3.NativeMethodInfoPtr_get_yzxx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668966);
			half3.NativeMethodInfoPtr_get_yzxy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668967);
			half3.NativeMethodInfoPtr_get_yzxz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668968);
			half3.NativeMethodInfoPtr_get_yzyx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668969);
			half3.NativeMethodInfoPtr_get_yzyy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668970);
			half3.NativeMethodInfoPtr_get_yzyz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668971);
			half3.NativeMethodInfoPtr_get_yzzx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668972);
			half3.NativeMethodInfoPtr_get_yzzy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668973);
			half3.NativeMethodInfoPtr_get_yzzz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668974);
			half3.NativeMethodInfoPtr_get_zxxx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668975);
			half3.NativeMethodInfoPtr_get_zxxy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668976);
			half3.NativeMethodInfoPtr_get_zxxz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668977);
			half3.NativeMethodInfoPtr_get_zxyx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668978);
			half3.NativeMethodInfoPtr_get_zxyy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668979);
			half3.NativeMethodInfoPtr_get_zxyz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668980);
			half3.NativeMethodInfoPtr_get_zxzx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668981);
			half3.NativeMethodInfoPtr_get_zxzy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668982);
			half3.NativeMethodInfoPtr_get_zxzz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668983);
			half3.NativeMethodInfoPtr_get_zyxx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668984);
			half3.NativeMethodInfoPtr_get_zyxy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668985);
			half3.NativeMethodInfoPtr_get_zyxz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668986);
			half3.NativeMethodInfoPtr_get_zyyx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668987);
			half3.NativeMethodInfoPtr_get_zyyy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668988);
			half3.NativeMethodInfoPtr_get_zyyz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668989);
			half3.NativeMethodInfoPtr_get_zyzx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668990);
			half3.NativeMethodInfoPtr_get_zyzy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668991);
			half3.NativeMethodInfoPtr_get_zyzz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668992);
			half3.NativeMethodInfoPtr_get_zzxx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668993);
			half3.NativeMethodInfoPtr_get_zzxy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668994);
			half3.NativeMethodInfoPtr_get_zzxz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668995);
			half3.NativeMethodInfoPtr_get_zzyx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668996);
			half3.NativeMethodInfoPtr_get_zzyy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668997);
			half3.NativeMethodInfoPtr_get_zzyz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668998);
			half3.NativeMethodInfoPtr_get_zzzx_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100668999);
			half3.NativeMethodInfoPtr_get_zzzy_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669000);
			half3.NativeMethodInfoPtr_get_zzzz_Public_get_half4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669001);
			half3.NativeMethodInfoPtr_get_xxx_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669002);
			half3.NativeMethodInfoPtr_get_xxy_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669003);
			half3.NativeMethodInfoPtr_get_xxz_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669004);
			half3.NativeMethodInfoPtr_get_xyx_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669005);
			half3.NativeMethodInfoPtr_get_xyy_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669006);
			half3.NativeMethodInfoPtr_get_xyz_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669007);
			half3.NativeMethodInfoPtr_set_xyz_Public_set_Void_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669008);
			half3.NativeMethodInfoPtr_get_xzx_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669009);
			half3.NativeMethodInfoPtr_get_xzy_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669010);
			half3.NativeMethodInfoPtr_set_xzy_Public_set_Void_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669011);
			half3.NativeMethodInfoPtr_get_xzz_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669012);
			half3.NativeMethodInfoPtr_get_yxx_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669013);
			half3.NativeMethodInfoPtr_get_yxy_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669014);
			half3.NativeMethodInfoPtr_get_yxz_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669015);
			half3.NativeMethodInfoPtr_set_yxz_Public_set_Void_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669016);
			half3.NativeMethodInfoPtr_get_yyx_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669017);
			half3.NativeMethodInfoPtr_get_yyy_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669018);
			half3.NativeMethodInfoPtr_get_yyz_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669019);
			half3.NativeMethodInfoPtr_get_yzx_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669020);
			half3.NativeMethodInfoPtr_set_yzx_Public_set_Void_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669021);
			half3.NativeMethodInfoPtr_get_yzy_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669022);
			half3.NativeMethodInfoPtr_get_yzz_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669023);
			half3.NativeMethodInfoPtr_get_zxx_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669024);
			half3.NativeMethodInfoPtr_get_zxy_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669025);
			half3.NativeMethodInfoPtr_set_zxy_Public_set_Void_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669026);
			half3.NativeMethodInfoPtr_get_zxz_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669027);
			half3.NativeMethodInfoPtr_get_zyx_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669028);
			half3.NativeMethodInfoPtr_set_zyx_Public_set_Void_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669029);
			half3.NativeMethodInfoPtr_get_zyy_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669030);
			half3.NativeMethodInfoPtr_get_zyz_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669031);
			half3.NativeMethodInfoPtr_get_zzx_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669032);
			half3.NativeMethodInfoPtr_get_zzy_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669033);
			half3.NativeMethodInfoPtr_get_zzz_Public_get_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669034);
			half3.NativeMethodInfoPtr_get_xx_Public_get_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669035);
			half3.NativeMethodInfoPtr_get_xy_Public_get_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669036);
			half3.NativeMethodInfoPtr_set_xy_Public_set_Void_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669037);
			half3.NativeMethodInfoPtr_get_xz_Public_get_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669038);
			half3.NativeMethodInfoPtr_set_xz_Public_set_Void_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669039);
			half3.NativeMethodInfoPtr_get_yx_Public_get_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669040);
			half3.NativeMethodInfoPtr_set_yx_Public_set_Void_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669041);
			half3.NativeMethodInfoPtr_get_yy_Public_get_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669042);
			half3.NativeMethodInfoPtr_get_yz_Public_get_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669043);
			half3.NativeMethodInfoPtr_set_yz_Public_set_Void_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669044);
			half3.NativeMethodInfoPtr_get_zx_Public_get_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669045);
			half3.NativeMethodInfoPtr_set_zx_Public_set_Void_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669046);
			half3.NativeMethodInfoPtr_get_zy_Public_get_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669047);
			half3.NativeMethodInfoPtr_set_zy_Public_set_Void_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669048);
			half3.NativeMethodInfoPtr_get_zz_Public_get_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669049);
			half3.NativeMethodInfoPtr_get_Item_Public_get_half_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669050);
			half3.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_half_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669051);
			half3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669052);
			half3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669053);
			half3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669054);
			half3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669055);
			half3.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3>.NativeClassPtr, 100669056);
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x000794A4 File Offset: 0x000776A4
		[CallerCount(0)]
		public unsafe half3(half x, half y, half z)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr__ctor_Public_Void_half_half_half_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001694 RID: 5780 RVA: 0x000794F4 File Offset: 0x000776F4
		[CallerCount(0)]
		public unsafe half3(half x, half2 yz)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yz;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr__ctor_Public_Void_half_half2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001695 RID: 5781 RVA: 0x00079534 File Offset: 0x00077734
		[CallerCount(0)]
		public unsafe half3(half2 xy, half z)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xy;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr__ctor_Public_Void_half2_half_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001696 RID: 5782 RVA: 0x00079574 File Offset: 0x00077774
		[CallerCount(0)]
		public unsafe half3(half3 xyz)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyz;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr__ctor_Public_Void_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001697 RID: 5783 RVA: 0x000795A8 File Offset: 0x000777A8
		[CallerCount(0)]
		public unsafe half3(half v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr__ctor_Public_Void_half_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001698 RID: 5784 RVA: 0x000795DC File Offset: 0x000777DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639039, XrefRangeEnd = 639042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe half3(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x00079610 File Offset: 0x00077810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639042, XrefRangeEnd = 639045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe half3(float3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr__ctor_Public_Void_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x00079644 File Offset: 0x00077844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639045, XrefRangeEnd = 639048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe half3(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x00079678 File Offset: 0x00077878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639048, XrefRangeEnd = 639051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe half3(double3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr__ctor_Public_Void_double3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x000796AC File Offset: 0x000778AC
		[CallerCount(0)]
		public unsafe static implicit operator half3(half v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_op_Implicit_Public_Static_half3_half_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600169D RID: 5789 RVA: 0x000796EC File Offset: 0x000778EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator half3(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_op_Explicit_Public_Static_half3_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x0007972C File Offset: 0x0007792C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator half3(float3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_op_Explicit_Public_Static_half3_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x0007976C File Offset: 0x0007796C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator half3(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_op_Explicit_Public_Static_half3_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x000797AC File Offset: 0x000779AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator half3(double3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_op_Explicit_Public_Static_half3_double3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x000797EC File Offset: 0x000779EC
		[CallerCount(0)]
		public unsafe static bool3 operator ==(half3 lhs, half3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3_half3_half3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x00079838 File Offset: 0x00077A38
		[CallerCount(0)]
		public unsafe static bool3 operator ==(half3 lhs, half rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3_half3_half_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x00079884 File Offset: 0x00077A84
		[CallerCount(0)]
		public unsafe static bool3 operator ==(half lhs, half3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3_half_half3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x000798D0 File Offset: 0x00077AD0
		[CallerCount(0)]
		public unsafe static bool3 operator !=(half3 lhs, half3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_half3_half3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x0007991C File Offset: 0x00077B1C
		[CallerCount(0)]
		public unsafe static bool3 operator !=(half3 lhs, half rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_half3_half_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x00079968 File Offset: 0x00077B68
		[CallerCount(0)]
		public unsafe static bool3 operator !=(half lhs, half3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_half_half3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x060016A7 RID: 5799 RVA: 0x000799B4 File Offset: 0x00077BB4
		public unsafe half4 xxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_xxxx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x060016A8 RID: 5800 RVA: 0x000799E4 File Offset: 0x00077BE4
		public unsafe half4 xxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_xxxy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x060016A9 RID: 5801 RVA: 0x00079A14 File Offset: 0x00077C14
		public unsafe half4 xxxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_xxxz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x060016AA RID: 5802 RVA: 0x00079A44 File Offset: 0x00077C44
		public unsafe half4 xxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_xxyx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x060016AB RID: 5803 RVA: 0x00079A74 File Offset: 0x00077C74
		public unsafe half4 xxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_xxyy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x060016AC RID: 5804 RVA: 0x00079AA4 File Offset: 0x00077CA4
		public unsafe half4 xxyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_xxyz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x060016AD RID: 5805 RVA: 0x00079AD4 File Offset: 0x00077CD4
		public unsafe half4 xxzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_xxzx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x060016AE RID: 5806 RVA: 0x00079B04 File Offset: 0x00077D04
		public unsafe half4 xxzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_xxzy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x060016AF RID: 5807 RVA: 0x00079B34 File Offset: 0x00077D34
		public unsafe half4 xxzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_xxzz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x060016B0 RID: 5808 RVA: 0x00079B64 File Offset: 0x00077D64
		public unsafe half4 xyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_xyxx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x060016B1 RID: 5809 RVA: 0x00079B94 File Offset: 0x00077D94
		public unsafe half4 xyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_xyxy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x060016B2 RID: 5810 RVA: 0x00079BC4 File Offset: 0x00077DC4
		public unsafe half4 xyxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_xyxz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x060016B3 RID: 5811 RVA: 0x00079BF4 File Offset: 0x00077DF4
		public unsafe half4 xyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_xyyx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x060016B4 RID: 5812 RVA: 0x00079C24 File Offset: 0x00077E24
		public unsafe half4 xyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_xyyy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x060016B5 RID: 5813 RVA: 0x00079C54 File Offset: 0x00077E54
		public unsafe half4 xyyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_xyyz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x060016B6 RID: 5814 RVA: 0x00079C84 File Offset: 0x00077E84
		public unsafe half4 xyzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_xyzx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x060016B7 RID: 5815 RVA: 0x00079CB4 File Offset: 0x00077EB4
		public unsafe half4 xyzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_xyzy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x060016B8 RID: 5816 RVA: 0x00079CE4 File Offset: 0x00077EE4
		public unsafe half4 xyzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_xyzz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x060016B9 RID: 5817 RVA: 0x00079D14 File Offset: 0x00077F14
		public unsafe half4 xzxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_xzxx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x060016BA RID: 5818 RVA: 0x00079D44 File Offset: 0x00077F44
		public unsafe half4 xzxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_xzxy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x060016BB RID: 5819 RVA: 0x00079D74 File Offset: 0x00077F74
		public unsafe half4 xzxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_xzxz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x060016BC RID: 5820 RVA: 0x00079DA4 File Offset: 0x00077FA4
		public unsafe half4 xzyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_xzyx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x060016BD RID: 5821 RVA: 0x00079DD4 File Offset: 0x00077FD4
		public unsafe half4 xzyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_xzyy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x060016BE RID: 5822 RVA: 0x00079E04 File Offset: 0x00078004
		public unsafe half4 xzyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_xzyz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x060016BF RID: 5823 RVA: 0x00079E34 File Offset: 0x00078034
		public unsafe half4 xzzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_xzzx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x060016C0 RID: 5824 RVA: 0x00079E64 File Offset: 0x00078064
		public unsafe half4 xzzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_xzzy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x060016C1 RID: 5825 RVA: 0x00079E94 File Offset: 0x00078094
		public unsafe half4 xzzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_xzzz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x060016C2 RID: 5826 RVA: 0x00079EC4 File Offset: 0x000780C4
		public unsafe half4 yxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_yxxx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x060016C3 RID: 5827 RVA: 0x00079EF4 File Offset: 0x000780F4
		public unsafe half4 yxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_yxxy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x060016C4 RID: 5828 RVA: 0x00079F24 File Offset: 0x00078124
		public unsafe half4 yxxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_yxxz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x060016C5 RID: 5829 RVA: 0x00079F54 File Offset: 0x00078154
		public unsafe half4 yxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_yxyx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x060016C6 RID: 5830 RVA: 0x00079F84 File Offset: 0x00078184
		public unsafe half4 yxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_yxyy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x060016C7 RID: 5831 RVA: 0x00079FB4 File Offset: 0x000781B4
		public unsafe half4 yxyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_yxyz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x060016C8 RID: 5832 RVA: 0x00079FE4 File Offset: 0x000781E4
		public unsafe half4 yxzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_yxzx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x060016C9 RID: 5833 RVA: 0x0007A014 File Offset: 0x00078214
		public unsafe half4 yxzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_yxzy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x060016CA RID: 5834 RVA: 0x0007A044 File Offset: 0x00078244
		public unsafe half4 yxzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_yxzz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x060016CB RID: 5835 RVA: 0x0007A074 File Offset: 0x00078274
		public unsafe half4 yyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_yyxx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x060016CC RID: 5836 RVA: 0x0007A0A4 File Offset: 0x000782A4
		public unsafe half4 yyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_yyxy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x060016CD RID: 5837 RVA: 0x0007A0D4 File Offset: 0x000782D4
		public unsafe half4 yyxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_yyxz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x060016CE RID: 5838 RVA: 0x0007A104 File Offset: 0x00078304
		public unsafe half4 yyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_yyyx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x060016CF RID: 5839 RVA: 0x0007A134 File Offset: 0x00078334
		public unsafe half4 yyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_yyyy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x060016D0 RID: 5840 RVA: 0x0007A164 File Offset: 0x00078364
		public unsafe half4 yyyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_yyyz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x060016D1 RID: 5841 RVA: 0x0007A194 File Offset: 0x00078394
		public unsafe half4 yyzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_yyzx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x060016D2 RID: 5842 RVA: 0x0007A1C4 File Offset: 0x000783C4
		public unsafe half4 yyzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_yyzy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x060016D3 RID: 5843 RVA: 0x0007A1F4 File Offset: 0x000783F4
		public unsafe half4 yyzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_yyzz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x060016D4 RID: 5844 RVA: 0x0007A224 File Offset: 0x00078424
		public unsafe half4 yzxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_yzxx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x060016D5 RID: 5845 RVA: 0x0007A254 File Offset: 0x00078454
		public unsafe half4 yzxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_yzxy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x060016D6 RID: 5846 RVA: 0x0007A284 File Offset: 0x00078484
		public unsafe half4 yzxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_yzxz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x060016D7 RID: 5847 RVA: 0x0007A2B4 File Offset: 0x000784B4
		public unsafe half4 yzyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_yzyx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x060016D8 RID: 5848 RVA: 0x0007A2E4 File Offset: 0x000784E4
		public unsafe half4 yzyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_yzyy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x060016D9 RID: 5849 RVA: 0x0007A314 File Offset: 0x00078514
		public unsafe half4 yzyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_yzyz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x060016DA RID: 5850 RVA: 0x0007A344 File Offset: 0x00078544
		public unsafe half4 yzzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_yzzx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x060016DB RID: 5851 RVA: 0x0007A374 File Offset: 0x00078574
		public unsafe half4 yzzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_yzzy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x060016DC RID: 5852 RVA: 0x0007A3A4 File Offset: 0x000785A4
		public unsafe half4 yzzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_yzzz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x060016DD RID: 5853 RVA: 0x0007A3D4 File Offset: 0x000785D4
		public unsafe half4 zxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_zxxx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x060016DE RID: 5854 RVA: 0x0007A404 File Offset: 0x00078604
		public unsafe half4 zxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_zxxy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x060016DF RID: 5855 RVA: 0x0007A434 File Offset: 0x00078634
		public unsafe half4 zxxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_zxxz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x060016E0 RID: 5856 RVA: 0x0007A464 File Offset: 0x00078664
		public unsafe half4 zxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_zxyx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x060016E1 RID: 5857 RVA: 0x0007A494 File Offset: 0x00078694
		public unsafe half4 zxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_zxyy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x060016E2 RID: 5858 RVA: 0x0007A4C4 File Offset: 0x000786C4
		public unsafe half4 zxyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_zxyz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x060016E3 RID: 5859 RVA: 0x0007A4F4 File Offset: 0x000786F4
		public unsafe half4 zxzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_zxzx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x060016E4 RID: 5860 RVA: 0x0007A524 File Offset: 0x00078724
		public unsafe half4 zxzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_zxzy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x060016E5 RID: 5861 RVA: 0x0007A554 File Offset: 0x00078754
		public unsafe half4 zxzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_zxzz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x060016E6 RID: 5862 RVA: 0x0007A584 File Offset: 0x00078784
		public unsafe half4 zyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_zyxx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x060016E7 RID: 5863 RVA: 0x0007A5B4 File Offset: 0x000787B4
		public unsafe half4 zyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_zyxy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x060016E8 RID: 5864 RVA: 0x0007A5E4 File Offset: 0x000787E4
		public unsafe half4 zyxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_zyxz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x060016E9 RID: 5865 RVA: 0x0007A614 File Offset: 0x00078814
		public unsafe half4 zyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_zyyx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x060016EA RID: 5866 RVA: 0x0007A644 File Offset: 0x00078844
		public unsafe half4 zyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_zyyy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x060016EB RID: 5867 RVA: 0x0007A674 File Offset: 0x00078874
		public unsafe half4 zyyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_zyyz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x060016EC RID: 5868 RVA: 0x0007A6A4 File Offset: 0x000788A4
		public unsafe half4 zyzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_zyzx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x060016ED RID: 5869 RVA: 0x0007A6D4 File Offset: 0x000788D4
		public unsafe half4 zyzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_zyzy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x060016EE RID: 5870 RVA: 0x0007A704 File Offset: 0x00078904
		public unsafe half4 zyzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_zyzz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x060016EF RID: 5871 RVA: 0x0007A734 File Offset: 0x00078934
		public unsafe half4 zzxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_zzxx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x060016F0 RID: 5872 RVA: 0x0007A764 File Offset: 0x00078964
		public unsafe half4 zzxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_zzxy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x060016F1 RID: 5873 RVA: 0x0007A794 File Offset: 0x00078994
		public unsafe half4 zzxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_zzxz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x060016F2 RID: 5874 RVA: 0x0007A7C4 File Offset: 0x000789C4
		public unsafe half4 zzyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_zzyx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x060016F3 RID: 5875 RVA: 0x0007A7F4 File Offset: 0x000789F4
		public unsafe half4 zzyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_zzyy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x060016F4 RID: 5876 RVA: 0x0007A824 File Offset: 0x00078A24
		public unsafe half4 zzyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_zzyz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x060016F5 RID: 5877 RVA: 0x0007A854 File Offset: 0x00078A54
		public unsafe half4 zzzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_zzzx_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x060016F6 RID: 5878 RVA: 0x0007A884 File Offset: 0x00078A84
		public unsafe half4 zzzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_zzzy_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x060016F7 RID: 5879 RVA: 0x0007A8B4 File Offset: 0x00078AB4
		public unsafe half4 zzzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_zzzz_Public_get_half4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x060016F8 RID: 5880 RVA: 0x0007A8E4 File Offset: 0x00078AE4
		public unsafe half3 xxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_xxx_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x060016F9 RID: 5881 RVA: 0x0007A914 File Offset: 0x00078B14
		public unsafe half3 xxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_xxy_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x060016FA RID: 5882 RVA: 0x0007A944 File Offset: 0x00078B44
		public unsafe half3 xxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_xxz_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x060016FB RID: 5883 RVA: 0x0007A974 File Offset: 0x00078B74
		public unsafe half3 xyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_xyx_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x060016FC RID: 5884 RVA: 0x0007A9A4 File Offset: 0x00078BA4
		public unsafe half3 xyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_xyy_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x060016FD RID: 5885 RVA: 0x0007A9D4 File Offset: 0x00078BD4
		// (set) Token: 0x060016FE RID: 5886 RVA: 0x0007AA04 File Offset: 0x00078C04
		public unsafe half3 xyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_xyz_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_set_xyz_Public_set_Void_half3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x060016FF RID: 5887 RVA: 0x0007AA38 File Offset: 0x00078C38
		public unsafe half3 xzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_xzx_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06001700 RID: 5888 RVA: 0x0007AA68 File Offset: 0x00078C68
		// (set) Token: 0x06001701 RID: 5889 RVA: 0x0007AA98 File Offset: 0x00078C98
		public unsafe half3 xzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_xzy_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_set_xzy_Public_set_Void_half3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06001702 RID: 5890 RVA: 0x0007AACC File Offset: 0x00078CCC
		public unsafe half3 xzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_xzz_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06001703 RID: 5891 RVA: 0x0007AAFC File Offset: 0x00078CFC
		public unsafe half3 yxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_yxx_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06001704 RID: 5892 RVA: 0x0007AB2C File Offset: 0x00078D2C
		public unsafe half3 yxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_yxy_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06001705 RID: 5893 RVA: 0x0007AB5C File Offset: 0x00078D5C
		// (set) Token: 0x06001706 RID: 5894 RVA: 0x0007AB8C File Offset: 0x00078D8C
		public unsafe half3 yxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_yxz_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_set_yxz_Public_set_Void_half3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06001707 RID: 5895 RVA: 0x0007ABC0 File Offset: 0x00078DC0
		public unsafe half3 yyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_yyx_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06001708 RID: 5896 RVA: 0x0007ABF0 File Offset: 0x00078DF0
		public unsafe half3 yyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_yyy_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06001709 RID: 5897 RVA: 0x0007AC20 File Offset: 0x00078E20
		public unsafe half3 yyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_yyz_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x0600170A RID: 5898 RVA: 0x0007AC50 File Offset: 0x00078E50
		// (set) Token: 0x0600170B RID: 5899 RVA: 0x0007AC80 File Offset: 0x00078E80
		public unsafe half3 yzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_yzx_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_set_yzx_Public_set_Void_half3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x0600170C RID: 5900 RVA: 0x0007ACB4 File Offset: 0x00078EB4
		public unsafe half3 yzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_yzy_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x0600170D RID: 5901 RVA: 0x0007ACE4 File Offset: 0x00078EE4
		public unsafe half3 yzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_yzz_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x0600170E RID: 5902 RVA: 0x0007AD14 File Offset: 0x00078F14
		public unsafe half3 zxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_zxx_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x0600170F RID: 5903 RVA: 0x0007AD44 File Offset: 0x00078F44
		// (set) Token: 0x06001710 RID: 5904 RVA: 0x0007AD74 File Offset: 0x00078F74
		public unsafe half3 zxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_zxy_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_set_zxy_Public_set_Void_half3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06001711 RID: 5905 RVA: 0x0007ADA8 File Offset: 0x00078FA8
		public unsafe half3 zxz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_zxz_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06001712 RID: 5906 RVA: 0x0007ADD8 File Offset: 0x00078FD8
		// (set) Token: 0x06001713 RID: 5907 RVA: 0x0007AE08 File Offset: 0x00079008
		public unsafe half3 zyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_zyx_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_set_zyx_Public_set_Void_half3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06001714 RID: 5908 RVA: 0x0007AE3C File Offset: 0x0007903C
		public unsafe half3 zyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_zyy_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06001715 RID: 5909 RVA: 0x0007AE6C File Offset: 0x0007906C
		public unsafe half3 zyz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_zyz_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06001716 RID: 5910 RVA: 0x0007AE9C File Offset: 0x0007909C
		public unsafe half3 zzx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_zzx_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06001717 RID: 5911 RVA: 0x0007AECC File Offset: 0x000790CC
		public unsafe half3 zzy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_zzy_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06001718 RID: 5912 RVA: 0x0007AEFC File Offset: 0x000790FC
		public unsafe half3 zzz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_zzz_Public_get_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06001719 RID: 5913 RVA: 0x0007AF2C File Offset: 0x0007912C
		public unsafe half2 xx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_xx_Public_get_half2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x0600171A RID: 5914 RVA: 0x0007AF5C File Offset: 0x0007915C
		// (set) Token: 0x0600171B RID: 5915 RVA: 0x0007AF8C File Offset: 0x0007918C
		public unsafe half2 xy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_xy_Public_get_half2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_set_xy_Public_set_Void_half2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x0600171C RID: 5916 RVA: 0x0007AFC0 File Offset: 0x000791C0
		// (set) Token: 0x0600171D RID: 5917 RVA: 0x0007AFF0 File Offset: 0x000791F0
		public unsafe half2 xz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_xz_Public_get_half2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_set_xz_Public_set_Void_half2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x0600171E RID: 5918 RVA: 0x0007B024 File Offset: 0x00079224
		// (set) Token: 0x0600171F RID: 5919 RVA: 0x0007B054 File Offset: 0x00079254
		public unsafe half2 yx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_yx_Public_get_half2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_set_yx_Public_set_Void_half2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06001720 RID: 5920 RVA: 0x0007B088 File Offset: 0x00079288
		public unsafe half2 yy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_yy_Public_get_half2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06001721 RID: 5921 RVA: 0x0007B0B8 File Offset: 0x000792B8
		// (set) Token: 0x06001722 RID: 5922 RVA: 0x0007B0E8 File Offset: 0x000792E8
		public unsafe half2 yz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_yz_Public_get_half2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_set_yz_Public_set_Void_half2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06001723 RID: 5923 RVA: 0x0007B11C File Offset: 0x0007931C
		// (set) Token: 0x06001724 RID: 5924 RVA: 0x0007B14C File Offset: 0x0007934C
		public unsafe half2 zx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_zx_Public_get_half2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_set_zx_Public_set_Void_half2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06001725 RID: 5925 RVA: 0x0007B180 File Offset: 0x00079380
		// (set) Token: 0x06001726 RID: 5926 RVA: 0x0007B1B0 File Offset: 0x000793B0
		public unsafe half2 zy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_zy_Public_get_half2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_set_zy_Public_set_Void_half2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06001727 RID: 5927 RVA: 0x0007B1E4 File Offset: 0x000793E4
		public unsafe half2 zz
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_zz_Public_get_half2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000695 RID: 1685
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_get_Item_Public_get_half_Int32_0, ref this, (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_half_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600172A RID: 5930 RVA: 0x0007B294 File Offset: 0x00079494
		[CallerCount(0)]
		public unsafe bool Equals(half3 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_half3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600172B RID: 5931 RVA: 0x0007B2D4 File Offset: 0x000794D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639051, XrefRangeEnd = 639054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600172C RID: 5932 RVA: 0x0007B318 File Offset: 0x00079518
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600172D RID: 5933 RVA: 0x0007B348 File Offset: 0x00079548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639054, XrefRangeEnd = 639064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600172E RID: 5934 RVA: 0x0007B374 File Offset: 0x00079574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639064, XrefRangeEnd = 639070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600172F RID: 5935 RVA: 0x00002644 File Offset: 0x00000844
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<half3>.NativeClassPtr, ref this));
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06001730 RID: 5936 RVA: 0x0007B3C4 File Offset: 0x000795C4
		// (set) Token: 0x06001731 RID: 5937 RVA: 0x00002656 File Offset: 0x00000856
		public unsafe static half3 zero
		{
			get
			{
				half3 half;
				IL2CPP.il2cpp_field_static_get_value(half3.NativeFieldInfoPtr_zero, (void*)(&half));
				return half;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(half3.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x040016E8 RID: 5864
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x040016E9 RID: 5865
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x040016EA RID: 5866
		private static readonly IntPtr NativeFieldInfoPtr_z;

		// Token: 0x040016EB RID: 5867
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x040016EC RID: 5868
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_half_half_half_0;

		// Token: 0x040016ED RID: 5869
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_half_half2_0;

		// Token: 0x040016EE RID: 5870
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_half2_half_0;

		// Token: 0x040016EF RID: 5871
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_half3_0;

		// Token: 0x040016F0 RID: 5872
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_half_0;

		// Token: 0x040016F1 RID: 5873
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x040016F2 RID: 5874
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float3_0;

		// Token: 0x040016F3 RID: 5875
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x040016F4 RID: 5876
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double3_0;

		// Token: 0x040016F5 RID: 5877
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_half3_half_0;

		// Token: 0x040016F6 RID: 5878
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_half3_Single_0;

		// Token: 0x040016F7 RID: 5879
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_half3_float3_0;

		// Token: 0x040016F8 RID: 5880
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_half3_Double_0;

		// Token: 0x040016F9 RID: 5881
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_half3_double3_0;

		// Token: 0x040016FA RID: 5882
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3_half3_half3_0;

		// Token: 0x040016FB RID: 5883
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3_half3_half_0;

		// Token: 0x040016FC RID: 5884
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3_half_half3_0;

		// Token: 0x040016FD RID: 5885
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_half3_half3_0;

		// Token: 0x040016FE RID: 5886
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_half3_half_0;

		// Token: 0x040016FF RID: 5887
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3_half_half3_0;

		// Token: 0x04001700 RID: 5888
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxx_Public_get_half4_0;

		// Token: 0x04001701 RID: 5889
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxy_Public_get_half4_0;

		// Token: 0x04001702 RID: 5890
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxz_Public_get_half4_0;

		// Token: 0x04001703 RID: 5891
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyx_Public_get_half4_0;

		// Token: 0x04001704 RID: 5892
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyy_Public_get_half4_0;

		// Token: 0x04001705 RID: 5893
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyz_Public_get_half4_0;

		// Token: 0x04001706 RID: 5894
		private static readonly IntPtr NativeMethodInfoPtr_get_xxzx_Public_get_half4_0;

		// Token: 0x04001707 RID: 5895
		private static readonly IntPtr NativeMethodInfoPtr_get_xxzy_Public_get_half4_0;

		// Token: 0x04001708 RID: 5896
		private static readonly IntPtr NativeMethodInfoPtr_get_xxzz_Public_get_half4_0;

		// Token: 0x04001709 RID: 5897
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxx_Public_get_half4_0;

		// Token: 0x0400170A RID: 5898
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxy_Public_get_half4_0;

		// Token: 0x0400170B RID: 5899
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxz_Public_get_half4_0;

		// Token: 0x0400170C RID: 5900
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyx_Public_get_half4_0;

		// Token: 0x0400170D RID: 5901
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyy_Public_get_half4_0;

		// Token: 0x0400170E RID: 5902
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyz_Public_get_half4_0;

		// Token: 0x0400170F RID: 5903
		private static readonly IntPtr NativeMethodInfoPtr_get_xyzx_Public_get_half4_0;

		// Token: 0x04001710 RID: 5904
		private static readonly IntPtr NativeMethodInfoPtr_get_xyzy_Public_get_half4_0;

		// Token: 0x04001711 RID: 5905
		private static readonly IntPtr NativeMethodInfoPtr_get_xyzz_Public_get_half4_0;

		// Token: 0x04001712 RID: 5906
		private static readonly IntPtr NativeMethodInfoPtr_get_xzxx_Public_get_half4_0;

		// Token: 0x04001713 RID: 5907
		private static readonly IntPtr NativeMethodInfoPtr_get_xzxy_Public_get_half4_0;

		// Token: 0x04001714 RID: 5908
		private static readonly IntPtr NativeMethodInfoPtr_get_xzxz_Public_get_half4_0;

		// Token: 0x04001715 RID: 5909
		private static readonly IntPtr NativeMethodInfoPtr_get_xzyx_Public_get_half4_0;

		// Token: 0x04001716 RID: 5910
		private static readonly IntPtr NativeMethodInfoPtr_get_xzyy_Public_get_half4_0;

		// Token: 0x04001717 RID: 5911
		private static readonly IntPtr NativeMethodInfoPtr_get_xzyz_Public_get_half4_0;

		// Token: 0x04001718 RID: 5912
		private static readonly IntPtr NativeMethodInfoPtr_get_xzzx_Public_get_half4_0;

		// Token: 0x04001719 RID: 5913
		private static readonly IntPtr NativeMethodInfoPtr_get_xzzy_Public_get_half4_0;

		// Token: 0x0400171A RID: 5914
		private static readonly IntPtr NativeMethodInfoPtr_get_xzzz_Public_get_half4_0;

		// Token: 0x0400171B RID: 5915
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxx_Public_get_half4_0;

		// Token: 0x0400171C RID: 5916
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxy_Public_get_half4_0;

		// Token: 0x0400171D RID: 5917
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxz_Public_get_half4_0;

		// Token: 0x0400171E RID: 5918
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyx_Public_get_half4_0;

		// Token: 0x0400171F RID: 5919
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyy_Public_get_half4_0;

		// Token: 0x04001720 RID: 5920
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyz_Public_get_half4_0;

		// Token: 0x04001721 RID: 5921
		private static readonly IntPtr NativeMethodInfoPtr_get_yxzx_Public_get_half4_0;

		// Token: 0x04001722 RID: 5922
		private static readonly IntPtr NativeMethodInfoPtr_get_yxzy_Public_get_half4_0;

		// Token: 0x04001723 RID: 5923
		private static readonly IntPtr NativeMethodInfoPtr_get_yxzz_Public_get_half4_0;

		// Token: 0x04001724 RID: 5924
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxx_Public_get_half4_0;

		// Token: 0x04001725 RID: 5925
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxy_Public_get_half4_0;

		// Token: 0x04001726 RID: 5926
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxz_Public_get_half4_0;

		// Token: 0x04001727 RID: 5927
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyx_Public_get_half4_0;

		// Token: 0x04001728 RID: 5928
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyy_Public_get_half4_0;

		// Token: 0x04001729 RID: 5929
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyz_Public_get_half4_0;

		// Token: 0x0400172A RID: 5930
		private static readonly IntPtr NativeMethodInfoPtr_get_yyzx_Public_get_half4_0;

		// Token: 0x0400172B RID: 5931
		private static readonly IntPtr NativeMethodInfoPtr_get_yyzy_Public_get_half4_0;

		// Token: 0x0400172C RID: 5932
		private static readonly IntPtr NativeMethodInfoPtr_get_yyzz_Public_get_half4_0;

		// Token: 0x0400172D RID: 5933
		private static readonly IntPtr NativeMethodInfoPtr_get_yzxx_Public_get_half4_0;

		// Token: 0x0400172E RID: 5934
		private static readonly IntPtr NativeMethodInfoPtr_get_yzxy_Public_get_half4_0;

		// Token: 0x0400172F RID: 5935
		private static readonly IntPtr NativeMethodInfoPtr_get_yzxz_Public_get_half4_0;

		// Token: 0x04001730 RID: 5936
		private static readonly IntPtr NativeMethodInfoPtr_get_yzyx_Public_get_half4_0;

		// Token: 0x04001731 RID: 5937
		private static readonly IntPtr NativeMethodInfoPtr_get_yzyy_Public_get_half4_0;

		// Token: 0x04001732 RID: 5938
		private static readonly IntPtr NativeMethodInfoPtr_get_yzyz_Public_get_half4_0;

		// Token: 0x04001733 RID: 5939
		private static readonly IntPtr NativeMethodInfoPtr_get_yzzx_Public_get_half4_0;

		// Token: 0x04001734 RID: 5940
		private static readonly IntPtr NativeMethodInfoPtr_get_yzzy_Public_get_half4_0;

		// Token: 0x04001735 RID: 5941
		private static readonly IntPtr NativeMethodInfoPtr_get_yzzz_Public_get_half4_0;

		// Token: 0x04001736 RID: 5942
		private static readonly IntPtr NativeMethodInfoPtr_get_zxxx_Public_get_half4_0;

		// Token: 0x04001737 RID: 5943
		private static readonly IntPtr NativeMethodInfoPtr_get_zxxy_Public_get_half4_0;

		// Token: 0x04001738 RID: 5944
		private static readonly IntPtr NativeMethodInfoPtr_get_zxxz_Public_get_half4_0;

		// Token: 0x04001739 RID: 5945
		private static readonly IntPtr NativeMethodInfoPtr_get_zxyx_Public_get_half4_0;

		// Token: 0x0400173A RID: 5946
		private static readonly IntPtr NativeMethodInfoPtr_get_zxyy_Public_get_half4_0;

		// Token: 0x0400173B RID: 5947
		private static readonly IntPtr NativeMethodInfoPtr_get_zxyz_Public_get_half4_0;

		// Token: 0x0400173C RID: 5948
		private static readonly IntPtr NativeMethodInfoPtr_get_zxzx_Public_get_half4_0;

		// Token: 0x0400173D RID: 5949
		private static readonly IntPtr NativeMethodInfoPtr_get_zxzy_Public_get_half4_0;

		// Token: 0x0400173E RID: 5950
		private static readonly IntPtr NativeMethodInfoPtr_get_zxzz_Public_get_half4_0;

		// Token: 0x0400173F RID: 5951
		private static readonly IntPtr NativeMethodInfoPtr_get_zyxx_Public_get_half4_0;

		// Token: 0x04001740 RID: 5952
		private static readonly IntPtr NativeMethodInfoPtr_get_zyxy_Public_get_half4_0;

		// Token: 0x04001741 RID: 5953
		private static readonly IntPtr NativeMethodInfoPtr_get_zyxz_Public_get_half4_0;

		// Token: 0x04001742 RID: 5954
		private static readonly IntPtr NativeMethodInfoPtr_get_zyyx_Public_get_half4_0;

		// Token: 0x04001743 RID: 5955
		private static readonly IntPtr NativeMethodInfoPtr_get_zyyy_Public_get_half4_0;

		// Token: 0x04001744 RID: 5956
		private static readonly IntPtr NativeMethodInfoPtr_get_zyyz_Public_get_half4_0;

		// Token: 0x04001745 RID: 5957
		private static readonly IntPtr NativeMethodInfoPtr_get_zyzx_Public_get_half4_0;

		// Token: 0x04001746 RID: 5958
		private static readonly IntPtr NativeMethodInfoPtr_get_zyzy_Public_get_half4_0;

		// Token: 0x04001747 RID: 5959
		private static readonly IntPtr NativeMethodInfoPtr_get_zyzz_Public_get_half4_0;

		// Token: 0x04001748 RID: 5960
		private static readonly IntPtr NativeMethodInfoPtr_get_zzxx_Public_get_half4_0;

		// Token: 0x04001749 RID: 5961
		private static readonly IntPtr NativeMethodInfoPtr_get_zzxy_Public_get_half4_0;

		// Token: 0x0400174A RID: 5962
		private static readonly IntPtr NativeMethodInfoPtr_get_zzxz_Public_get_half4_0;

		// Token: 0x0400174B RID: 5963
		private static readonly IntPtr NativeMethodInfoPtr_get_zzyx_Public_get_half4_0;

		// Token: 0x0400174C RID: 5964
		private static readonly IntPtr NativeMethodInfoPtr_get_zzyy_Public_get_half4_0;

		// Token: 0x0400174D RID: 5965
		private static readonly IntPtr NativeMethodInfoPtr_get_zzyz_Public_get_half4_0;

		// Token: 0x0400174E RID: 5966
		private static readonly IntPtr NativeMethodInfoPtr_get_zzzx_Public_get_half4_0;

		// Token: 0x0400174F RID: 5967
		private static readonly IntPtr NativeMethodInfoPtr_get_zzzy_Public_get_half4_0;

		// Token: 0x04001750 RID: 5968
		private static readonly IntPtr NativeMethodInfoPtr_get_zzzz_Public_get_half4_0;

		// Token: 0x04001751 RID: 5969
		private static readonly IntPtr NativeMethodInfoPtr_get_xxx_Public_get_half3_0;

		// Token: 0x04001752 RID: 5970
		private static readonly IntPtr NativeMethodInfoPtr_get_xxy_Public_get_half3_0;

		// Token: 0x04001753 RID: 5971
		private static readonly IntPtr NativeMethodInfoPtr_get_xxz_Public_get_half3_0;

		// Token: 0x04001754 RID: 5972
		private static readonly IntPtr NativeMethodInfoPtr_get_xyx_Public_get_half3_0;

		// Token: 0x04001755 RID: 5973
		private static readonly IntPtr NativeMethodInfoPtr_get_xyy_Public_get_half3_0;

		// Token: 0x04001756 RID: 5974
		private static readonly IntPtr NativeMethodInfoPtr_get_xyz_Public_get_half3_0;

		// Token: 0x04001757 RID: 5975
		private static readonly IntPtr NativeMethodInfoPtr_set_xyz_Public_set_Void_half3_0;

		// Token: 0x04001758 RID: 5976
		private static readonly IntPtr NativeMethodInfoPtr_get_xzx_Public_get_half3_0;

		// Token: 0x04001759 RID: 5977
		private static readonly IntPtr NativeMethodInfoPtr_get_xzy_Public_get_half3_0;

		// Token: 0x0400175A RID: 5978
		private static readonly IntPtr NativeMethodInfoPtr_set_xzy_Public_set_Void_half3_0;

		// Token: 0x0400175B RID: 5979
		private static readonly IntPtr NativeMethodInfoPtr_get_xzz_Public_get_half3_0;

		// Token: 0x0400175C RID: 5980
		private static readonly IntPtr NativeMethodInfoPtr_get_yxx_Public_get_half3_0;

		// Token: 0x0400175D RID: 5981
		private static readonly IntPtr NativeMethodInfoPtr_get_yxy_Public_get_half3_0;

		// Token: 0x0400175E RID: 5982
		private static readonly IntPtr NativeMethodInfoPtr_get_yxz_Public_get_half3_0;

		// Token: 0x0400175F RID: 5983
		private static readonly IntPtr NativeMethodInfoPtr_set_yxz_Public_set_Void_half3_0;

		// Token: 0x04001760 RID: 5984
		private static readonly IntPtr NativeMethodInfoPtr_get_yyx_Public_get_half3_0;

		// Token: 0x04001761 RID: 5985
		private static readonly IntPtr NativeMethodInfoPtr_get_yyy_Public_get_half3_0;

		// Token: 0x04001762 RID: 5986
		private static readonly IntPtr NativeMethodInfoPtr_get_yyz_Public_get_half3_0;

		// Token: 0x04001763 RID: 5987
		private static readonly IntPtr NativeMethodInfoPtr_get_yzx_Public_get_half3_0;

		// Token: 0x04001764 RID: 5988
		private static readonly IntPtr NativeMethodInfoPtr_set_yzx_Public_set_Void_half3_0;

		// Token: 0x04001765 RID: 5989
		private static readonly IntPtr NativeMethodInfoPtr_get_yzy_Public_get_half3_0;

		// Token: 0x04001766 RID: 5990
		private static readonly IntPtr NativeMethodInfoPtr_get_yzz_Public_get_half3_0;

		// Token: 0x04001767 RID: 5991
		private static readonly IntPtr NativeMethodInfoPtr_get_zxx_Public_get_half3_0;

		// Token: 0x04001768 RID: 5992
		private static readonly IntPtr NativeMethodInfoPtr_get_zxy_Public_get_half3_0;

		// Token: 0x04001769 RID: 5993
		private static readonly IntPtr NativeMethodInfoPtr_set_zxy_Public_set_Void_half3_0;

		// Token: 0x0400176A RID: 5994
		private static readonly IntPtr NativeMethodInfoPtr_get_zxz_Public_get_half3_0;

		// Token: 0x0400176B RID: 5995
		private static readonly IntPtr NativeMethodInfoPtr_get_zyx_Public_get_half3_0;

		// Token: 0x0400176C RID: 5996
		private static readonly IntPtr NativeMethodInfoPtr_set_zyx_Public_set_Void_half3_0;

		// Token: 0x0400176D RID: 5997
		private static readonly IntPtr NativeMethodInfoPtr_get_zyy_Public_get_half3_0;

		// Token: 0x0400176E RID: 5998
		private static readonly IntPtr NativeMethodInfoPtr_get_zyz_Public_get_half3_0;

		// Token: 0x0400176F RID: 5999
		private static readonly IntPtr NativeMethodInfoPtr_get_zzx_Public_get_half3_0;

		// Token: 0x04001770 RID: 6000
		private static readonly IntPtr NativeMethodInfoPtr_get_zzy_Public_get_half3_0;

		// Token: 0x04001771 RID: 6001
		private static readonly IntPtr NativeMethodInfoPtr_get_zzz_Public_get_half3_0;

		// Token: 0x04001772 RID: 6002
		private static readonly IntPtr NativeMethodInfoPtr_get_xx_Public_get_half2_0;

		// Token: 0x04001773 RID: 6003
		private static readonly IntPtr NativeMethodInfoPtr_get_xy_Public_get_half2_0;

		// Token: 0x04001774 RID: 6004
		private static readonly IntPtr NativeMethodInfoPtr_set_xy_Public_set_Void_half2_0;

		// Token: 0x04001775 RID: 6005
		private static readonly IntPtr NativeMethodInfoPtr_get_xz_Public_get_half2_0;

		// Token: 0x04001776 RID: 6006
		private static readonly IntPtr NativeMethodInfoPtr_set_xz_Public_set_Void_half2_0;

		// Token: 0x04001777 RID: 6007
		private static readonly IntPtr NativeMethodInfoPtr_get_yx_Public_get_half2_0;

		// Token: 0x04001778 RID: 6008
		private static readonly IntPtr NativeMethodInfoPtr_set_yx_Public_set_Void_half2_0;

		// Token: 0x04001779 RID: 6009
		private static readonly IntPtr NativeMethodInfoPtr_get_yy_Public_get_half2_0;

		// Token: 0x0400177A RID: 6010
		private static readonly IntPtr NativeMethodInfoPtr_get_yz_Public_get_half2_0;

		// Token: 0x0400177B RID: 6011
		private static readonly IntPtr NativeMethodInfoPtr_set_yz_Public_set_Void_half2_0;

		// Token: 0x0400177C RID: 6012
		private static readonly IntPtr NativeMethodInfoPtr_get_zx_Public_get_half2_0;

		// Token: 0x0400177D RID: 6013
		private static readonly IntPtr NativeMethodInfoPtr_set_zx_Public_set_Void_half2_0;

		// Token: 0x0400177E RID: 6014
		private static readonly IntPtr NativeMethodInfoPtr_get_zy_Public_get_half2_0;

		// Token: 0x0400177F RID: 6015
		private static readonly IntPtr NativeMethodInfoPtr_set_zy_Public_set_Void_half2_0;

		// Token: 0x04001780 RID: 6016
		private static readonly IntPtr NativeMethodInfoPtr_get_zz_Public_get_half2_0;

		// Token: 0x04001781 RID: 6017
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_half_Int32_0;

		// Token: 0x04001782 RID: 6018
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_half_0;

		// Token: 0x04001783 RID: 6019
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_half3_0;

		// Token: 0x04001784 RID: 6020
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001785 RID: 6021
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001786 RID: 6022
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001787 RID: 6023
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04001788 RID: 6024
		[FieldOffset(0)]
		public half x;

		// Token: 0x04001789 RID: 6025
		[FieldOffset(2)]
		public half y;

		// Token: 0x0400178A RID: 6026
		[FieldOffset(4)]
		public half z;

		// Token: 0x0200005E RID: 94
		public sealed class DebuggerProxy : Object
		{
			// Token: 0x06002611 RID: 9745 RVA: 0x000C3978 File Offset: 0x000C1B78
			// Note: this type is marked as 'beforefieldinit'.
			static DebuggerProxy()
			{
				Il2CppClassPointerStore<half3.DebuggerProxy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<half3>.NativeClassPtr, "DebuggerProxy");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<half3.DebuggerProxy>.NativeClassPtr);
				half3.DebuggerProxy.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<half3.DebuggerProxy>.NativeClassPtr, "x");
				half3.DebuggerProxy.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<half3.DebuggerProxy>.NativeClassPtr, "y");
				half3.DebuggerProxy.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<half3.DebuggerProxy>.NativeClassPtr, "z");
				half3.DebuggerProxy.NativeMethodInfoPtr__ctor_Public_Void_half3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half3.DebuggerProxy>.NativeClassPtr, 100669057);
			}

			// Token: 0x06002612 RID: 9746 RVA: 0x000C39F4 File Offset: 0x000C1BF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639038, XrefRangeEnd = 639039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DebuggerProxy(half3 v)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<half3.DebuggerProxy>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half3.DebuggerProxy.NativeMethodInfoPtr__ctor_Public_Void_half3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002613 RID: 9747 RVA: 0x00002F40 File Offset: 0x00001140
			public DebuggerProxy(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C0E RID: 3086
			// (get) Token: 0x06002614 RID: 9748 RVA: 0x000C3A3C File Offset: 0x000C1C3C
			// (set) Token: 0x06002615 RID: 9749 RVA: 0x00002F49 File Offset: 0x00001149
			public unsafe half x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(half3.DebuggerProxy.NativeFieldInfoPtr_x);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(half3.DebuggerProxy.NativeFieldInfoPtr_x)) = value;
				}
			}

			// Token: 0x17000C0F RID: 3087
			// (get) Token: 0x06002616 RID: 9750 RVA: 0x000C3A64 File Offset: 0x000C1C64
			// (set) Token: 0x06002617 RID: 9751 RVA: 0x00002F64 File Offset: 0x00001164
			public unsafe half y
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(half3.DebuggerProxy.NativeFieldInfoPtr_y);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(half3.DebuggerProxy.NativeFieldInfoPtr_y)) = value;
				}
			}

			// Token: 0x17000C10 RID: 3088
			// (get) Token: 0x06002618 RID: 9752 RVA: 0x000C3A8C File Offset: 0x000C1C8C
			// (set) Token: 0x06002619 RID: 9753 RVA: 0x00002F7F File Offset: 0x0000117F
			public unsafe half z
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(half3.DebuggerProxy.NativeFieldInfoPtr_z);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(half3.DebuggerProxy.NativeFieldInfoPtr_z)) = value;
				}
			}

			// Token: 0x04002683 RID: 9859
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04002684 RID: 9860
			private static readonly IntPtr NativeFieldInfoPtr_y;

			// Token: 0x04002685 RID: 9861
			private static readonly IntPtr NativeFieldInfoPtr_z;

			// Token: 0x04002686 RID: 9862
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_half3_0;
		}
	}
}
