using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Unity.Mathematics
{
	// Token: 0x02000028 RID: 40
	[Serializable]
	[StructLayout(2)]
	public struct float4x4
	{
		// Token: 0x060015DB RID: 5595 RVA: 0x00074CF4 File Offset: 0x00072EF4
		// Note: this type is marked as 'beforefieldinit'.
		static float4x4()
		{
			Il2CppClassPointerStore<float4x4>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "float4x4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<float4x4>.NativeClassPtr);
			float4x4.NativeFieldInfoPtr_c0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float4x4>.NativeClassPtr, "c0");
			float4x4.NativeFieldInfoPtr_c1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float4x4>.NativeClassPtr, "c1");
			float4x4.NativeFieldInfoPtr_c2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float4x4>.NativeClassPtr, "c2");
			float4x4.NativeFieldInfoPtr_c3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float4x4>.NativeClassPtr, "c3");
			float4x4.NativeFieldInfoPtr_identity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float4x4>.NativeClassPtr, "identity");
			float4x4.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float4x4>.NativeClassPtr, "zero");
			float4x4.NativeMethodInfoPtr__ctor_Public_Void_float4_float4_float4_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668729);
			float4x4.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668730);
			float4x4.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668731);
			float4x4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668732);
			float4x4.NativeMethodInfoPtr__ctor_Public_Void_bool4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668733);
			float4x4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668734);
			float4x4.NativeMethodInfoPtr__ctor_Public_Void_int4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668735);
			float4x4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668736);
			float4x4.NativeMethodInfoPtr__ctor_Public_Void_uint4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668737);
			float4x4.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668738);
			float4x4.NativeMethodInfoPtr__ctor_Public_Void_double4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668739);
			float4x4.NativeMethodInfoPtr_op_Implicit_Public_Static_float4x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668740);
			float4x4.NativeMethodInfoPtr_op_Explicit_Public_Static_float4x4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668741);
			float4x4.NativeMethodInfoPtr_op_Explicit_Public_Static_float4x4_bool4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668742);
			float4x4.NativeMethodInfoPtr_op_Implicit_Public_Static_float4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668743);
			float4x4.NativeMethodInfoPtr_op_Implicit_Public_Static_float4x4_int4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668744);
			float4x4.NativeMethodInfoPtr_op_Implicit_Public_Static_float4x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668745);
			float4x4.NativeMethodInfoPtr_op_Implicit_Public_Static_float4x4_uint4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668746);
			float4x4.NativeMethodInfoPtr_op_Explicit_Public_Static_float4x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668747);
			float4x4.NativeMethodInfoPtr_op_Explicit_Public_Static_float4x4_double4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668748);
			float4x4.NativeMethodInfoPtr_op_Multiply_Public_Static_float4x4_float4x4_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668749);
			float4x4.NativeMethodInfoPtr_op_Multiply_Public_Static_float4x4_float4x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668750);
			float4x4.NativeMethodInfoPtr_op_Multiply_Public_Static_float4x4_Single_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668751);
			float4x4.NativeMethodInfoPtr_op_Addition_Public_Static_float4x4_float4x4_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668752);
			float4x4.NativeMethodInfoPtr_op_Addition_Public_Static_float4x4_float4x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668753);
			float4x4.NativeMethodInfoPtr_op_Addition_Public_Static_float4x4_Single_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668754);
			float4x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_float4x4_float4x4_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668755);
			float4x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_float4x4_float4x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668756);
			float4x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_float4x4_Single_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668757);
			float4x4.NativeMethodInfoPtr_op_Division_Public_Static_float4x4_float4x4_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668758);
			float4x4.NativeMethodInfoPtr_op_Division_Public_Static_float4x4_float4x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668759);
			float4x4.NativeMethodInfoPtr_op_Division_Public_Static_float4x4_Single_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668760);
			float4x4.NativeMethodInfoPtr_op_Modulus_Public_Static_float4x4_float4x4_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668761);
			float4x4.NativeMethodInfoPtr_op_Modulus_Public_Static_float4x4_float4x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668762);
			float4x4.NativeMethodInfoPtr_op_Modulus_Public_Static_float4x4_Single_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668763);
			float4x4.NativeMethodInfoPtr_op_Increment_Public_Static_float4x4_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668764);
			float4x4.NativeMethodInfoPtr_op_Decrement_Public_Static_float4x4_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668765);
			float4x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x4_float4x4_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668766);
			float4x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x4_float4x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668767);
			float4x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x4_Single_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668768);
			float4x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x4_float4x4_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668769);
			float4x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x4_float4x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668770);
			float4x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x4_Single_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668771);
			float4x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x4_float4x4_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668772);
			float4x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x4_float4x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668773);
			float4x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x4_Single_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668774);
			float4x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x4_float4x4_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668775);
			float4x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x4_float4x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668776);
			float4x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x4_Single_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668777);
			float4x4.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_float4x4_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668778);
			float4x4.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_float4x4_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668779);
			float4x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_float4x4_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668780);
			float4x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_float4x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668781);
			float4x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_Single_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668782);
			float4x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_float4x4_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668783);
			float4x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_float4x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668784);
			float4x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_Single_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668785);
			float4x4.NativeMethodInfoPtr_get_Item_Public_get_byref_float4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668786);
			float4x4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668787);
			float4x4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668788);
			float4x4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668789);
			float4x4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668790);
			float4x4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668791);
			float4x4.NativeMethodInfoPtr_op_Implicit_Public_Static_float4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668792);
			float4x4.NativeMethodInfoPtr_op_Implicit_Public_Static_Matrix4x4_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668793);
			float4x4.NativeMethodInfoPtr__ctor_Public_Void_float3x3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668794);
			float4x4.NativeMethodInfoPtr__ctor_Public_Void_quaternion_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668795);
			float4x4.NativeMethodInfoPtr__ctor_Public_Void_RigidTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668796);
			float4x4.NativeMethodInfoPtr_AxisAngle_Public_Static_float4x4_float3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668797);
			float4x4.NativeMethodInfoPtr_EulerXYZ_Public_Static_float4x4_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668798);
			float4x4.NativeMethodInfoPtr_EulerXZY_Public_Static_float4x4_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668799);
			float4x4.NativeMethodInfoPtr_EulerYXZ_Public_Static_float4x4_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668800);
			float4x4.NativeMethodInfoPtr_EulerYZX_Public_Static_float4x4_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668801);
			float4x4.NativeMethodInfoPtr_EulerZXY_Public_Static_float4x4_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668802);
			float4x4.NativeMethodInfoPtr_EulerZYX_Public_Static_float4x4_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668803);
			float4x4.NativeMethodInfoPtr_EulerXYZ_Public_Static_float4x4_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668804);
			float4x4.NativeMethodInfoPtr_EulerXZY_Public_Static_float4x4_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668805);
			float4x4.NativeMethodInfoPtr_EulerYXZ_Public_Static_float4x4_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668806);
			float4x4.NativeMethodInfoPtr_EulerYZX_Public_Static_float4x4_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668807);
			float4x4.NativeMethodInfoPtr_EulerZXY_Public_Static_float4x4_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668808);
			float4x4.NativeMethodInfoPtr_EulerZYX_Public_Static_float4x4_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668809);
			float4x4.NativeMethodInfoPtr_Euler_Public_Static_float4x4_float3_RotationOrder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668810);
			float4x4.NativeMethodInfoPtr_Euler_Public_Static_float4x4_Single_Single_Single_RotationOrder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668811);
			float4x4.NativeMethodInfoPtr_RotateX_Public_Static_float4x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668812);
			float4x4.NativeMethodInfoPtr_RotateY_Public_Static_float4x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668813);
			float4x4.NativeMethodInfoPtr_RotateZ_Public_Static_float4x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668814);
			float4x4.NativeMethodInfoPtr_Scale_Public_Static_float4x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668815);
			float4x4.NativeMethodInfoPtr_Scale_Public_Static_float4x4_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668816);
			float4x4.NativeMethodInfoPtr_Scale_Public_Static_float4x4_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668817);
			float4x4.NativeMethodInfoPtr_Translate_Public_Static_float4x4_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668818);
			float4x4.NativeMethodInfoPtr_LookAt_Public_Static_float4x4_float3_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668819);
			float4x4.NativeMethodInfoPtr_Ortho_Public_Static_float4x4_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668820);
			float4x4.NativeMethodInfoPtr_OrthoOffCenter_Public_Static_float4x4_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668821);
			float4x4.NativeMethodInfoPtr_PerspectiveFov_Public_Static_float4x4_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668822);
			float4x4.NativeMethodInfoPtr_PerspectiveOffCenter_Public_Static_float4x4_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668823);
			float4x4.NativeMethodInfoPtr_TRS_Public_Static_float4x4_float3_quaternion_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x4>.NativeClassPtr, 100668824);
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x0007551C File Offset: 0x0007371C
		[CallerCount(0)]
		public unsafe float4x4(float4 c0, float4 c1, float4 c2, float4 c3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr__ctor_Public_Void_float4_float4_float4_float4_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x00075578 File Offset: 0x00073778
		[CallerCount(0)]
		public unsafe float4x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23, float m30, float m31, float m32, float m33)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)16) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref m00;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m01;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m02;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m03;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m10;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m11;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m12;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m13;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m20;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m21;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m22;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m23;
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m30;
			ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m31;
			ptr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m32;
			ptr[checked(unchecked((UIntPtr)15) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m33;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015DE RID: 5598 RVA: 0x00075684 File Offset: 0x00073884
		[CallerCount(0)]
		public unsafe float4x4(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015DF RID: 5599 RVA: 0x000756B8 File Offset: 0x000738B8
		[CallerCount(0)]
		public unsafe float4x4(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015E0 RID: 5600 RVA: 0x000756EC File Offset: 0x000738EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 638502, RefRangeEnd = 638504, XrefRangeStart = 638487, XrefRangeEnd = 638502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float4x4(bool4x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr__ctor_Public_Void_bool4x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015E1 RID: 5601 RVA: 0x00075720 File Offset: 0x00073920
		[CallerCount(0)]
		public unsafe float4x4(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x00075754 File Offset: 0x00073954
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 638504, RefRangeEnd = 638505, XrefRangeStart = 638504, XrefRangeEnd = 638504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float4x4(int4x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr__ctor_Public_Void_int4x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015E3 RID: 5603 RVA: 0x00075788 File Offset: 0x00073988
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 638505, RefRangeEnd = 638506, XrefRangeStart = 638505, XrefRangeEnd = 638505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float4x4(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015E4 RID: 5604 RVA: 0x000757BC File Offset: 0x000739BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 638506, RefRangeEnd = 638508, XrefRangeStart = 638506, XrefRangeEnd = 638506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float4x4(uint4x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr__ctor_Public_Void_uint4x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x000757F0 File Offset: 0x000739F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 638508, RefRangeEnd = 638509, XrefRangeStart = 638508, XrefRangeEnd = 638508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float4x4(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x00075824 File Offset: 0x00073A24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 638509, RefRangeEnd = 638510, XrefRangeStart = 638509, XrefRangeEnd = 638509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float4x4(double4x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr__ctor_Public_Void_double4x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x00075858 File Offset: 0x00073A58
		[CallerCount(0)]
		public unsafe static implicit operator float4x4(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_Implicit_Public_Static_float4x4_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x00075898 File Offset: 0x00073A98
		[CallerCount(0)]
		public unsafe static explicit operator float4x4(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_Explicit_Public_Static_float4x4_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x000758D8 File Offset: 0x00073AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator float4x4(bool4x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_Explicit_Public_Static_float4x4_bool4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x00075918 File Offset: 0x00073B18
		[CallerCount(0)]
		public unsafe static implicit operator float4x4(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_Implicit_Public_Static_float4x4_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x00075958 File Offset: 0x00073B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638510, XrefRangeEnd = 638511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator float4x4(int4x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_Implicit_Public_Static_float4x4_int4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x00075998 File Offset: 0x00073B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638511, XrefRangeEnd = 638512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator float4x4(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_Implicit_Public_Static_float4x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x000759D8 File Offset: 0x00073BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator float4x4(uint4x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_Implicit_Public_Static_float4x4_uint4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x00075A18 File Offset: 0x00073C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638512, XrefRangeEnd = 638513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator float4x4(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_Explicit_Public_Static_float4x4_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015EF RID: 5615 RVA: 0x00075A58 File Offset: 0x00073C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638513, XrefRangeEnd = 638514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator float4x4(double4x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_Explicit_Public_Static_float4x4_double4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x00075A98 File Offset: 0x00073C98
		[CallerCount(0)]
		public unsafe static float4x4 operator *(float4x4 lhs, float4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_Multiply_Public_Static_float4x4_float4x4_float4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x00075AE4 File Offset: 0x00073CE4
		[CallerCount(0)]
		public unsafe static float4x4 operator *(float4x4 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_Multiply_Public_Static_float4x4_float4x4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x00075B30 File Offset: 0x00073D30
		[CallerCount(0)]
		public unsafe static float4x4 operator *(float lhs, float4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_Multiply_Public_Static_float4x4_Single_float4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x00075B7C File Offset: 0x00073D7C
		[CallerCount(0)]
		public unsafe static float4x4 operator +(float4x4 lhs, float4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_Addition_Public_Static_float4x4_float4x4_float4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x00075BC8 File Offset: 0x00073DC8
		[CallerCount(0)]
		public unsafe static float4x4 operator +(float4x4 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_Addition_Public_Static_float4x4_float4x4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x00075C14 File Offset: 0x00073E14
		[CallerCount(0)]
		public unsafe static float4x4 operator +(float lhs, float4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_Addition_Public_Static_float4x4_Single_float4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x00075C60 File Offset: 0x00073E60
		[CallerCount(0)]
		public unsafe static float4x4 operator -(float4x4 lhs, float4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_float4x4_float4x4_float4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015F7 RID: 5623 RVA: 0x00075CAC File Offset: 0x00073EAC
		[CallerCount(0)]
		public unsafe static float4x4 operator -(float4x4 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_float4x4_float4x4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x00075CF8 File Offset: 0x00073EF8
		[CallerCount(0)]
		public unsafe static float4x4 operator -(float lhs, float4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_float4x4_Single_float4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015F9 RID: 5625 RVA: 0x00075D44 File Offset: 0x00073F44
		[CallerCount(0)]
		public unsafe static float4x4 operator /(float4x4 lhs, float4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_Division_Public_Static_float4x4_float4x4_float4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015FA RID: 5626 RVA: 0x00075D90 File Offset: 0x00073F90
		[CallerCount(0)]
		public unsafe static float4x4 operator /(float4x4 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_Division_Public_Static_float4x4_float4x4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x00075DDC File Offset: 0x00073FDC
		[CallerCount(0)]
		public unsafe static float4x4 operator /(float lhs, float4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_Division_Public_Static_float4x4_Single_float4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x00075E28 File Offset: 0x00074028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638514, XrefRangeEnd = 638530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4x4 operator %(float4x4 lhs, float4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_Modulus_Public_Static_float4x4_float4x4_float4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x00075E74 File Offset: 0x00074074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638530, XrefRangeEnd = 638546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4x4 operator %(float4x4 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_Modulus_Public_Static_float4x4_float4x4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x00075EC0 File Offset: 0x000740C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638546, XrefRangeEnd = 638562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4x4 operator %(float lhs, float4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_Modulus_Public_Static_float4x4_Single_float4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x00075F0C File Offset: 0x0007410C
		[CallerCount(0)]
		public unsafe static float4x4 operator ++(float4x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_Increment_Public_Static_float4x4_float4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x00075F4C File Offset: 0x0007414C
		[CallerCount(0)]
		public unsafe static float4x4 operator --(float4x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_Decrement_Public_Static_float4x4_float4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x00075F8C File Offset: 0x0007418C
		[CallerCount(0)]
		public unsafe static bool4x4 operator <(float4x4 lhs, float4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x4_float4x4_float4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x00075FD8 File Offset: 0x000741D8
		[CallerCount(0)]
		public unsafe static bool4x4 operator <(float4x4 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x4_float4x4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x00076024 File Offset: 0x00074224
		[CallerCount(0)]
		public unsafe static bool4x4 operator <(float lhs, float4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x4_Single_float4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x00076070 File Offset: 0x00074270
		[CallerCount(0)]
		public unsafe static bool4x4 operator <=(float4x4 lhs, float4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x4_float4x4_float4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x000760BC File Offset: 0x000742BC
		[CallerCount(0)]
		public unsafe static bool4x4 operator <=(float4x4 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x4_float4x4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x00076108 File Offset: 0x00074308
		[CallerCount(0)]
		public unsafe static bool4x4 operator <=(float lhs, float4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x4_Single_float4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x00076154 File Offset: 0x00074354
		[CallerCount(0)]
		public unsafe static bool4x4 operator >(float4x4 lhs, float4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x4_float4x4_float4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x000761A0 File Offset: 0x000743A0
		[CallerCount(0)]
		public unsafe static bool4x4 operator >(float4x4 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x4_float4x4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x000761EC File Offset: 0x000743EC
		[CallerCount(0)]
		public unsafe static bool4x4 operator >(float lhs, float4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x4_Single_float4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x00076238 File Offset: 0x00074438
		[CallerCount(0)]
		public unsafe static bool4x4 operator >=(float4x4 lhs, float4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x4_float4x4_float4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x00076284 File Offset: 0x00074484
		[CallerCount(0)]
		public unsafe static bool4x4 operator >=(float4x4 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x4_float4x4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600160C RID: 5644 RVA: 0x000762D0 File Offset: 0x000744D0
		[CallerCount(0)]
		public unsafe static bool4x4 operator >=(float lhs, float4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x4_Single_float4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600160D RID: 5645 RVA: 0x0007631C File Offset: 0x0007451C
		[CallerCount(0)]
		public unsafe static float4x4 operator -(float4x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_float4x4_float4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600160E RID: 5646 RVA: 0x0007635C File Offset: 0x0007455C
		[CallerCount(0)]
		public unsafe static float4x4 operator +(float4x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_float4x4_float4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600160F RID: 5647 RVA: 0x0007639C File Offset: 0x0007459C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638562, XrefRangeEnd = 638578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool4x4 operator ==(float4x4 lhs, float4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_float4x4_float4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x000763E8 File Offset: 0x000745E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638578, XrefRangeEnd = 638594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool4x4 operator ==(float4x4 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_float4x4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x00076434 File Offset: 0x00074634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638594, XrefRangeEnd = 638610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool4x4 operator ==(float lhs, float4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_Single_float4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x00076480 File Offset: 0x00074680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638610, XrefRangeEnd = 638626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool4x4 operator !=(float4x4 lhs, float4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_float4x4_float4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001613 RID: 5651 RVA: 0x000764CC File Offset: 0x000746CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638626, XrefRangeEnd = 638642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool4x4 operator !=(float4x4 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_float4x4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001614 RID: 5652 RVA: 0x00076518 File Offset: 0x00074718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638642, XrefRangeEnd = 638658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool4x4 operator !=(float lhs, float4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_Single_float4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170005FB RID: 1531
		public unsafe ref float4 this[int index]
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 634855, RefRangeEnd = 634861, XrefRangeStart = 634855, XrefRangeEnd = 634861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_get_Item_Public_get_byref_float4_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x06001616 RID: 5654 RVA: 0x00076598 File Offset: 0x00074798
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 638658, RefRangeEnd = 638659, XrefRangeStart = 638658, XrefRangeEnd = 638658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(float4x4 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_float4x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001617 RID: 5655 RVA: 0x000765D8 File Offset: 0x000747D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638659, XrefRangeEnd = 638663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(global::Il2CppSystem.Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x0007661C File Offset: 0x0007481C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638663, XrefRangeEnd = 638664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x0007664C File Offset: 0x0007484C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638664, XrefRangeEnd = 638735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x00076678 File Offset: 0x00074878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638735, XrefRangeEnd = 638823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x000766C8 File Offset: 0x000748C8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 638827, RefRangeEnd = 638838, XrefRangeStart = 638823, XrefRangeEnd = 638827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator float4x4(Matrix4x4 m)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref m;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_Implicit_Public_Static_float4x4_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x00076708 File Offset: 0x00074908
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 638839, RefRangeEnd = 638844, XrefRangeStart = 638838, XrefRangeEnd = 638839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Matrix4x4(float4x4 m)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref m;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_op_Implicit_Public_Static_Matrix4x4_float4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x00076748 File Offset: 0x00074948
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 638844, RefRangeEnd = 638845, XrefRangeStart = 638844, XrefRangeEnd = 638844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float4x4(float3x3 rotation, float3 translation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rotation;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref translation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr__ctor_Public_Void_float3x3_float3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x00076788 File Offset: 0x00074988
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 638846, RefRangeEnd = 638848, XrefRangeStart = 638845, XrefRangeEnd = 638846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float4x4(quaternion rotation, float3 translation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rotation;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref translation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr__ctor_Public_Void_quaternion_float3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x000767C8 File Offset: 0x000749C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 638849, RefRangeEnd = 638850, XrefRangeStart = 638848, XrefRangeEnd = 638849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float4x4(RigidTransform transform)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref transform;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr__ctor_Public_Void_RigidTransform_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x000767FC File Offset: 0x000749FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638850, XrefRangeEnd = 638858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4x4 AxisAngle(float3 axis, float angle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axis;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_AxisAngle_Public_Static_float4x4_float3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x00076848 File Offset: 0x00074A48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 638859, RefRangeEnd = 638862, XrefRangeStart = 638858, XrefRangeEnd = 638859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4x4 EulerXYZ(float3 xyz)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyz;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_EulerXYZ_Public_Static_float4x4_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x00076888 File Offset: 0x00074A88
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 638863, RefRangeEnd = 638866, XrefRangeStart = 638862, XrefRangeEnd = 638863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4x4 EulerXZY(float3 xyz)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyz;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_EulerXZY_Public_Static_float4x4_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x000768C8 File Offset: 0x00074AC8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 638867, RefRangeEnd = 638870, XrefRangeStart = 638866, XrefRangeEnd = 638867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4x4 EulerYXZ(float3 xyz)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyz;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_EulerYXZ_Public_Static_float4x4_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x00076908 File Offset: 0x00074B08
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 638871, RefRangeEnd = 638874, XrefRangeStart = 638870, XrefRangeEnd = 638871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4x4 EulerYZX(float3 xyz)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyz;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_EulerYZX_Public_Static_float4x4_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001625 RID: 5669 RVA: 0x00076948 File Offset: 0x00074B48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 638875, RefRangeEnd = 638878, XrefRangeStart = 638874, XrefRangeEnd = 638875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4x4 EulerZXY(float3 xyz)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyz;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_EulerZXY_Public_Static_float4x4_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x00076988 File Offset: 0x00074B88
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 638879, RefRangeEnd = 638882, XrefRangeStart = 638878, XrefRangeEnd = 638879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4x4 EulerZYX(float3 xyz)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyz;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_EulerZYX_Public_Static_float4x4_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x000769C8 File Offset: 0x00074BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638882, XrefRangeEnd = 638883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4x4 EulerXYZ(float x, float y, float z)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_EulerXYZ_Public_Static_float4x4_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x00076A24 File Offset: 0x00074C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638883, XrefRangeEnd = 638884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4x4 EulerXZY(float x, float y, float z)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_EulerXZY_Public_Static_float4x4_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x00076A80 File Offset: 0x00074C80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638884, XrefRangeEnd = 638885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4x4 EulerYXZ(float x, float y, float z)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_EulerYXZ_Public_Static_float4x4_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x00076ADC File Offset: 0x00074CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638885, XrefRangeEnd = 638886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4x4 EulerYZX(float x, float y, float z)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_EulerYZX_Public_Static_float4x4_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x00076B38 File Offset: 0x00074D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638886, XrefRangeEnd = 638887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4x4 EulerZXY(float x, float y, float z)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_EulerZXY_Public_Static_float4x4_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x00076B94 File Offset: 0x00074D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638887, XrefRangeEnd = 638888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4x4 EulerZYX(float x, float y, float z)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_EulerZYX_Public_Static_float4x4_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x00076BF0 File Offset: 0x00074DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638888, XrefRangeEnd = 638902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4x4 Euler(float3 xyz, math.RotationOrder order = math.RotationOrder.ZXY)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref order;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_Euler_Public_Static_float4x4_float3_RotationOrder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x00076C3C File Offset: 0x00074E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638902, XrefRangeEnd = 638916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4x4 Euler(float x, float y, float z, math.RotationOrder order = math.RotationOrder.ZXY)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref order;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_Euler_Public_Static_float4x4_Single_Single_Single_RotationOrder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x00076CA4 File Offset: 0x00074EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638916, XrefRangeEnd = 638924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4x4 RotateX(float angle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_RotateX_Public_Static_float4x4_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x00076CE4 File Offset: 0x00074EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638924, XrefRangeEnd = 638932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4x4 RotateY(float angle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_RotateY_Public_Static_float4x4_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x00076D24 File Offset: 0x00074F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638932, XrefRangeEnd = 638940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4x4 RotateZ(float angle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_RotateZ_Public_Static_float4x4_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x00076D64 File Offset: 0x00074F64
		[CallerCount(0)]
		public unsafe static float4x4 Scale(float s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref s;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_Scale_Public_Static_float4x4_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001633 RID: 5683 RVA: 0x00076DA4 File Offset: 0x00074FA4
		[CallerCount(0)]
		public unsafe static float4x4 Scale(float x, float y, float z)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_Scale_Public_Static_float4x4_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001634 RID: 5684 RVA: 0x00076E00 File Offset: 0x00075000
		[CallerCount(0)]
		public unsafe static float4x4 Scale(float3 scales)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scales;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_Scale_Public_Static_float4x4_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001635 RID: 5685 RVA: 0x00076E40 File Offset: 0x00075040
		[CallerCount(0)]
		public unsafe static float4x4 Translate(float3 vector)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vector;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_Translate_Public_Static_float4x4_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001636 RID: 5686 RVA: 0x00076E80 File Offset: 0x00075080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638940, XrefRangeEnd = 638946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4x4 LookAt(float3 eye, float3 target, float3 up)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eye;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref up;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_LookAt_Public_Static_float4x4_float3_float3_float3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001637 RID: 5687 RVA: 0x00076EDC File Offset: 0x000750DC
		[CallerCount(0)]
		public unsafe static float4x4 Ortho(float width, float height, float near, float far)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref near;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref far;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_Ortho_Public_Static_float4x4_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001638 RID: 5688 RVA: 0x00076F44 File Offset: 0x00075144
		[CallerCount(0)]
		public unsafe static float4x4 OrthoOffCenter(float left, float right, float bottom, float top, float near, float far)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bottom;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref top;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref near;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref far;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_OrthoOffCenter_Public_Static_float4x4_Single_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001639 RID: 5689 RVA: 0x00076FC8 File Offset: 0x000751C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638946, XrefRangeEnd = 638950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4x4 PerspectiveFov(float verticalFov, float aspect, float near, float far)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref verticalFov;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref aspect;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref near;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref far;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_PerspectiveFov_Public_Static_float4x4_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600163A RID: 5690 RVA: 0x00077030 File Offset: 0x00075230
		[CallerCount(0)]
		public unsafe static float4x4 PerspectiveOffCenter(float left, float right, float bottom, float top, float near, float far)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bottom;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref top;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref near;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref far;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_PerspectiveOffCenter_Public_Static_float4x4_Single_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600163B RID: 5691 RVA: 0x000770B4 File Offset: 0x000752B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638950, XrefRangeEnd = 638951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4x4 TRS(float3 translation, quaternion rotation, float3 scale)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref translation;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x4.NativeMethodInfoPtr_TRS_Public_Static_float4x4_float3_quaternion_float3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600163C RID: 5692 RVA: 0x000025D6 File Offset: 0x000007D6
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<float4x4>.NativeClassPtr, ref this));
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x0600163D RID: 5693 RVA: 0x00077110 File Offset: 0x00075310
		// (set) Token: 0x0600163E RID: 5694 RVA: 0x000025E8 File Offset: 0x000007E8
		public unsafe static float4x4 identity
		{
			get
			{
				float4x4 float4x;
				IL2CPP.il2cpp_field_static_get_value(float4x4.NativeFieldInfoPtr_identity, (void*)(&float4x));
				return float4x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(float4x4.NativeFieldInfoPtr_identity, (void*)(&value));
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x0600163F RID: 5695 RVA: 0x0007712C File Offset: 0x0007532C
		// (set) Token: 0x06001640 RID: 5696 RVA: 0x000025F6 File Offset: 0x000007F6
		public unsafe static float4x4 zero
		{
			get
			{
				float4x4 float4x;
				IL2CPP.il2cpp_field_static_get_value(float4x4.NativeFieldInfoPtr_zero, (void*)(&float4x));
				return float4x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(float4x4.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x0400162D RID: 5677
		private static readonly IntPtr NativeFieldInfoPtr_c0;

		// Token: 0x0400162E RID: 5678
		private static readonly IntPtr NativeFieldInfoPtr_c1;

		// Token: 0x0400162F RID: 5679
		private static readonly IntPtr NativeFieldInfoPtr_c2;

		// Token: 0x04001630 RID: 5680
		private static readonly IntPtr NativeFieldInfoPtr_c3;

		// Token: 0x04001631 RID: 5681
		private static readonly IntPtr NativeFieldInfoPtr_identity;

		// Token: 0x04001632 RID: 5682
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x04001633 RID: 5683
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float4_float4_float4_float4_0;

		// Token: 0x04001634 RID: 5684
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_0;

		// Token: 0x04001635 RID: 5685
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x04001636 RID: 5686
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04001637 RID: 5687
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool4x4_0;

		// Token: 0x04001638 RID: 5688
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001639 RID: 5689
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int4x4_0;

		// Token: 0x0400163A RID: 5690
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x0400163B RID: 5691
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint4x4_0;

		// Token: 0x0400163C RID: 5692
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x0400163D RID: 5693
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double4x4_0;

		// Token: 0x0400163E RID: 5694
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float4x4_Single_0;

		// Token: 0x0400163F RID: 5695
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_float4x4_Boolean_0;

		// Token: 0x04001640 RID: 5696
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_float4x4_bool4x4_0;

		// Token: 0x04001641 RID: 5697
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float4x4_Int32_0;

		// Token: 0x04001642 RID: 5698
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float4x4_int4x4_0;

		// Token: 0x04001643 RID: 5699
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float4x4_UInt32_0;

		// Token: 0x04001644 RID: 5700
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float4x4_uint4x4_0;

		// Token: 0x04001645 RID: 5701
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_float4x4_Double_0;

		// Token: 0x04001646 RID: 5702
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_float4x4_double4x4_0;

		// Token: 0x04001647 RID: 5703
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_float4x4_float4x4_float4x4_0;

		// Token: 0x04001648 RID: 5704
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_float4x4_float4x4_Single_0;

		// Token: 0x04001649 RID: 5705
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_float4x4_Single_float4x4_0;

		// Token: 0x0400164A RID: 5706
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_float4x4_float4x4_float4x4_0;

		// Token: 0x0400164B RID: 5707
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_float4x4_float4x4_Single_0;

		// Token: 0x0400164C RID: 5708
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_float4x4_Single_float4x4_0;

		// Token: 0x0400164D RID: 5709
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_float4x4_float4x4_float4x4_0;

		// Token: 0x0400164E RID: 5710
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_float4x4_float4x4_Single_0;

		// Token: 0x0400164F RID: 5711
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_float4x4_Single_float4x4_0;

		// Token: 0x04001650 RID: 5712
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_float4x4_float4x4_float4x4_0;

		// Token: 0x04001651 RID: 5713
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_float4x4_float4x4_Single_0;

		// Token: 0x04001652 RID: 5714
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_float4x4_Single_float4x4_0;

		// Token: 0x04001653 RID: 5715
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_float4x4_float4x4_float4x4_0;

		// Token: 0x04001654 RID: 5716
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_float4x4_float4x4_Single_0;

		// Token: 0x04001655 RID: 5717
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_float4x4_Single_float4x4_0;

		// Token: 0x04001656 RID: 5718
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_float4x4_float4x4_0;

		// Token: 0x04001657 RID: 5719
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_float4x4_float4x4_0;

		// Token: 0x04001658 RID: 5720
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x4_float4x4_float4x4_0;

		// Token: 0x04001659 RID: 5721
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x4_float4x4_Single_0;

		// Token: 0x0400165A RID: 5722
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x4_Single_float4x4_0;

		// Token: 0x0400165B RID: 5723
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x4_float4x4_float4x4_0;

		// Token: 0x0400165C RID: 5724
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x4_float4x4_Single_0;

		// Token: 0x0400165D RID: 5725
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x4_Single_float4x4_0;

		// Token: 0x0400165E RID: 5726
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x4_float4x4_float4x4_0;

		// Token: 0x0400165F RID: 5727
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x4_float4x4_Single_0;

		// Token: 0x04001660 RID: 5728
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x4_Single_float4x4_0;

		// Token: 0x04001661 RID: 5729
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x4_float4x4_float4x4_0;

		// Token: 0x04001662 RID: 5730
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x4_float4x4_Single_0;

		// Token: 0x04001663 RID: 5731
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x4_Single_float4x4_0;

		// Token: 0x04001664 RID: 5732
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_float4x4_float4x4_0;

		// Token: 0x04001665 RID: 5733
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryPlus_Public_Static_float4x4_float4x4_0;

		// Token: 0x04001666 RID: 5734
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_float4x4_float4x4_0;

		// Token: 0x04001667 RID: 5735
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_float4x4_Single_0;

		// Token: 0x04001668 RID: 5736
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_Single_float4x4_0;

		// Token: 0x04001669 RID: 5737
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_float4x4_float4x4_0;

		// Token: 0x0400166A RID: 5738
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_float4x4_Single_0;

		// Token: 0x0400166B RID: 5739
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_Single_float4x4_0;

		// Token: 0x0400166C RID: 5740
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_float4_Int32_0;

		// Token: 0x0400166D RID: 5741
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_float4x4_0;

		// Token: 0x0400166E RID: 5742
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400166F RID: 5743
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001670 RID: 5744
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001671 RID: 5745
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04001672 RID: 5746
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float4x4_Matrix4x4_0;

		// Token: 0x04001673 RID: 5747
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Matrix4x4_float4x4_0;

		// Token: 0x04001674 RID: 5748
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float3x3_float3_0;

		// Token: 0x04001675 RID: 5749
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_quaternion_float3_0;

		// Token: 0x04001676 RID: 5750
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RigidTransform_0;

		// Token: 0x04001677 RID: 5751
		private static readonly IntPtr NativeMethodInfoPtr_AxisAngle_Public_Static_float4x4_float3_Single_0;

		// Token: 0x04001678 RID: 5752
		private static readonly IntPtr NativeMethodInfoPtr_EulerXYZ_Public_Static_float4x4_float3_0;

		// Token: 0x04001679 RID: 5753
		private static readonly IntPtr NativeMethodInfoPtr_EulerXZY_Public_Static_float4x4_float3_0;

		// Token: 0x0400167A RID: 5754
		private static readonly IntPtr NativeMethodInfoPtr_EulerYXZ_Public_Static_float4x4_float3_0;

		// Token: 0x0400167B RID: 5755
		private static readonly IntPtr NativeMethodInfoPtr_EulerYZX_Public_Static_float4x4_float3_0;

		// Token: 0x0400167C RID: 5756
		private static readonly IntPtr NativeMethodInfoPtr_EulerZXY_Public_Static_float4x4_float3_0;

		// Token: 0x0400167D RID: 5757
		private static readonly IntPtr NativeMethodInfoPtr_EulerZYX_Public_Static_float4x4_float3_0;

		// Token: 0x0400167E RID: 5758
		private static readonly IntPtr NativeMethodInfoPtr_EulerXYZ_Public_Static_float4x4_Single_Single_Single_0;

		// Token: 0x0400167F RID: 5759
		private static readonly IntPtr NativeMethodInfoPtr_EulerXZY_Public_Static_float4x4_Single_Single_Single_0;

		// Token: 0x04001680 RID: 5760
		private static readonly IntPtr NativeMethodInfoPtr_EulerYXZ_Public_Static_float4x4_Single_Single_Single_0;

		// Token: 0x04001681 RID: 5761
		private static readonly IntPtr NativeMethodInfoPtr_EulerYZX_Public_Static_float4x4_Single_Single_Single_0;

		// Token: 0x04001682 RID: 5762
		private static readonly IntPtr NativeMethodInfoPtr_EulerZXY_Public_Static_float4x4_Single_Single_Single_0;

		// Token: 0x04001683 RID: 5763
		private static readonly IntPtr NativeMethodInfoPtr_EulerZYX_Public_Static_float4x4_Single_Single_Single_0;

		// Token: 0x04001684 RID: 5764
		private static readonly IntPtr NativeMethodInfoPtr_Euler_Public_Static_float4x4_float3_RotationOrder_0;

		// Token: 0x04001685 RID: 5765
		private static readonly IntPtr NativeMethodInfoPtr_Euler_Public_Static_float4x4_Single_Single_Single_RotationOrder_0;

		// Token: 0x04001686 RID: 5766
		private static readonly IntPtr NativeMethodInfoPtr_RotateX_Public_Static_float4x4_Single_0;

		// Token: 0x04001687 RID: 5767
		private static readonly IntPtr NativeMethodInfoPtr_RotateY_Public_Static_float4x4_Single_0;

		// Token: 0x04001688 RID: 5768
		private static readonly IntPtr NativeMethodInfoPtr_RotateZ_Public_Static_float4x4_Single_0;

		// Token: 0x04001689 RID: 5769
		private static readonly IntPtr NativeMethodInfoPtr_Scale_Public_Static_float4x4_Single_0;

		// Token: 0x0400168A RID: 5770
		private static readonly IntPtr NativeMethodInfoPtr_Scale_Public_Static_float4x4_Single_Single_Single_0;

		// Token: 0x0400168B RID: 5771
		private static readonly IntPtr NativeMethodInfoPtr_Scale_Public_Static_float4x4_float3_0;

		// Token: 0x0400168C RID: 5772
		private static readonly IntPtr NativeMethodInfoPtr_Translate_Public_Static_float4x4_float3_0;

		// Token: 0x0400168D RID: 5773
		private static readonly IntPtr NativeMethodInfoPtr_LookAt_Public_Static_float4x4_float3_float3_float3_0;

		// Token: 0x0400168E RID: 5774
		private static readonly IntPtr NativeMethodInfoPtr_Ortho_Public_Static_float4x4_Single_Single_Single_Single_0;

		// Token: 0x0400168F RID: 5775
		private static readonly IntPtr NativeMethodInfoPtr_OrthoOffCenter_Public_Static_float4x4_Single_Single_Single_Single_Single_Single_0;

		// Token: 0x04001690 RID: 5776
		private static readonly IntPtr NativeMethodInfoPtr_PerspectiveFov_Public_Static_float4x4_Single_Single_Single_Single_0;

		// Token: 0x04001691 RID: 5777
		private static readonly IntPtr NativeMethodInfoPtr_PerspectiveOffCenter_Public_Static_float4x4_Single_Single_Single_Single_Single_Single_0;

		// Token: 0x04001692 RID: 5778
		private static readonly IntPtr NativeMethodInfoPtr_TRS_Public_Static_float4x4_float3_quaternion_float3_0;

		// Token: 0x04001693 RID: 5779
		[FieldOffset(0)]
		public float4 c0;

		// Token: 0x04001694 RID: 5780
		[FieldOffset(16)]
		public float4 c1;

		// Token: 0x04001695 RID: 5781
		[FieldOffset(32)]
		public float4 c2;

		// Token: 0x04001696 RID: 5782
		[FieldOffset(48)]
		public float4 c3;
	}
}
