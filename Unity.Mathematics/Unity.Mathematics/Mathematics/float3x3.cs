using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x02000023 RID: 35
	[Serializable]
	[StructLayout(2)]
	public struct float3x3
	{
		// Token: 0x060012D7 RID: 4823 RVA: 0x000662FC File Offset: 0x000644FC
		// Note: this type is marked as 'beforefieldinit'.
		static float3x3()
		{
			Il2CppClassPointerStore<float3x3>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "float3x3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<float3x3>.NativeClassPtr);
			float3x3.NativeFieldInfoPtr_c0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float3x3>.NativeClassPtr, "c0");
			float3x3.NativeFieldInfoPtr_c1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float3x3>.NativeClassPtr, "c1");
			float3x3.NativeFieldInfoPtr_c2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float3x3>.NativeClassPtr, "c2");
			float3x3.NativeFieldInfoPtr_identity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float3x3>.NativeClassPtr, "identity");
			float3x3.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float3x3>.NativeClassPtr, "zero");
			float3x3.NativeMethodInfoPtr__ctor_Public_Void_float3_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100667977);
			float3x3.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100667978);
			float3x3.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100667979);
			float3x3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100667980);
			float3x3.NativeMethodInfoPtr__ctor_Public_Void_bool3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100667981);
			float3x3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100667982);
			float3x3.NativeMethodInfoPtr__ctor_Public_Void_int3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100667983);
			float3x3.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100667984);
			float3x3.NativeMethodInfoPtr__ctor_Public_Void_uint3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100667985);
			float3x3.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100667986);
			float3x3.NativeMethodInfoPtr__ctor_Public_Void_double3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100667987);
			float3x3.NativeMethodInfoPtr_op_Implicit_Public_Static_float3x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100667988);
			float3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_float3x3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100667989);
			float3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_float3x3_bool3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100667990);
			float3x3.NativeMethodInfoPtr_op_Implicit_Public_Static_float3x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100667991);
			float3x3.NativeMethodInfoPtr_op_Implicit_Public_Static_float3x3_int3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100667992);
			float3x3.NativeMethodInfoPtr_op_Implicit_Public_Static_float3x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100667993);
			float3x3.NativeMethodInfoPtr_op_Implicit_Public_Static_float3x3_uint3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100667994);
			float3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_float3x3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100667995);
			float3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_float3x3_double3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100667996);
			float3x3.NativeMethodInfoPtr_op_Multiply_Public_Static_float3x3_float3x3_float3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100667997);
			float3x3.NativeMethodInfoPtr_op_Multiply_Public_Static_float3x3_float3x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100667998);
			float3x3.NativeMethodInfoPtr_op_Multiply_Public_Static_float3x3_Single_float3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100667999);
			float3x3.NativeMethodInfoPtr_op_Addition_Public_Static_float3x3_float3x3_float3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668000);
			float3x3.NativeMethodInfoPtr_op_Addition_Public_Static_float3x3_float3x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668001);
			float3x3.NativeMethodInfoPtr_op_Addition_Public_Static_float3x3_Single_float3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668002);
			float3x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_float3x3_float3x3_float3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668003);
			float3x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_float3x3_float3x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668004);
			float3x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_float3x3_Single_float3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668005);
			float3x3.NativeMethodInfoPtr_op_Division_Public_Static_float3x3_float3x3_float3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668006);
			float3x3.NativeMethodInfoPtr_op_Division_Public_Static_float3x3_float3x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668007);
			float3x3.NativeMethodInfoPtr_op_Division_Public_Static_float3x3_Single_float3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668008);
			float3x3.NativeMethodInfoPtr_op_Modulus_Public_Static_float3x3_float3x3_float3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668009);
			float3x3.NativeMethodInfoPtr_op_Modulus_Public_Static_float3x3_float3x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668010);
			float3x3.NativeMethodInfoPtr_op_Modulus_Public_Static_float3x3_Single_float3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668011);
			float3x3.NativeMethodInfoPtr_op_Increment_Public_Static_float3x3_float3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668012);
			float3x3.NativeMethodInfoPtr_op_Decrement_Public_Static_float3x3_float3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668013);
			float3x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x3_float3x3_float3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668014);
			float3x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x3_float3x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668015);
			float3x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x3_Single_float3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668016);
			float3x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x3_float3x3_float3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668017);
			float3x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x3_float3x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668018);
			float3x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x3_Single_float3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668019);
			float3x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x3_float3x3_float3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668020);
			float3x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x3_float3x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668021);
			float3x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x3_Single_float3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668022);
			float3x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x3_float3x3_float3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668023);
			float3x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x3_float3x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668024);
			float3x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x3_Single_float3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668025);
			float3x3.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_float3x3_float3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668026);
			float3x3.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_float3x3_float3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668027);
			float3x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_float3x3_float3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668028);
			float3x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_float3x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668029);
			float3x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_Single_float3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668030);
			float3x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_float3x3_float3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668031);
			float3x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_float3x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668032);
			float3x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_Single_float3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668033);
			float3x3.NativeMethodInfoPtr_get_Item_Public_get_byref_float3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668034);
			float3x3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_float3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668035);
			float3x3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668036);
			float3x3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668037);
			float3x3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668038);
			float3x3.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668039);
			float3x3.NativeMethodInfoPtr__ctor_Public_Void_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668040);
			float3x3.NativeMethodInfoPtr__ctor_Public_Void_quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668041);
			float3x3.NativeMethodInfoPtr_AxisAngle_Public_Static_float3x3_float3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668042);
			float3x3.NativeMethodInfoPtr_EulerXYZ_Public_Static_float3x3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668043);
			float3x3.NativeMethodInfoPtr_EulerXZY_Public_Static_float3x3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668044);
			float3x3.NativeMethodInfoPtr_EulerYXZ_Public_Static_float3x3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668045);
			float3x3.NativeMethodInfoPtr_EulerYZX_Public_Static_float3x3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668046);
			float3x3.NativeMethodInfoPtr_EulerZXY_Public_Static_float3x3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668047);
			float3x3.NativeMethodInfoPtr_EulerZYX_Public_Static_float3x3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668048);
			float3x3.NativeMethodInfoPtr_EulerXYZ_Public_Static_float3x3_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668049);
			float3x3.NativeMethodInfoPtr_EulerXZY_Public_Static_float3x3_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668050);
			float3x3.NativeMethodInfoPtr_EulerYXZ_Public_Static_float3x3_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668051);
			float3x3.NativeMethodInfoPtr_EulerYZX_Public_Static_float3x3_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668052);
			float3x3.NativeMethodInfoPtr_EulerZXY_Public_Static_float3x3_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668053);
			float3x3.NativeMethodInfoPtr_EulerZYX_Public_Static_float3x3_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668054);
			float3x3.NativeMethodInfoPtr_Euler_Public_Static_float3x3_float3_RotationOrder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668055);
			float3x3.NativeMethodInfoPtr_Euler_Public_Static_float3x3_Single_Single_Single_RotationOrder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668056);
			float3x3.NativeMethodInfoPtr_RotateX_Public_Static_float3x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668057);
			float3x3.NativeMethodInfoPtr_RotateY_Public_Static_float3x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668058);
			float3x3.NativeMethodInfoPtr_RotateZ_Public_Static_float3x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668059);
			float3x3.NativeMethodInfoPtr_Scale_Public_Static_float3x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668060);
			float3x3.NativeMethodInfoPtr_Scale_Public_Static_float3x3_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668061);
			float3x3.NativeMethodInfoPtr_Scale_Public_Static_float3x3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668062);
			float3x3.NativeMethodInfoPtr_LookRotation_Public_Static_float3x3_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668063);
			float3x3.NativeMethodInfoPtr_LookRotationSafe_Public_Static_float3x3_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668064);
			float3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_float3x3_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x3>.NativeClassPtr, 100668065);
		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x00066A84 File Offset: 0x00064C84
		[CallerCount(0)]
		public unsafe float3x3(float3 c0, float3 c1, float3 c2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr__ctor_Public_Void_float3_float3_float3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x00066AD4 File Offset: 0x00064CD4
		[CallerCount(0)]
		public unsafe float3x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref m00;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m01;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m02;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m10;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m11;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m12;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m20;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m21;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m22;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x00066B78 File Offset: 0x00064D78
		[CallerCount(0)]
		public unsafe float3x3(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012DB RID: 4827 RVA: 0x00066BAC File Offset: 0x00064DAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 637344, RefRangeEnd = 637345, XrefRangeStart = 637344, XrefRangeEnd = 637344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float3x3(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012DC RID: 4828 RVA: 0x00066BE0 File Offset: 0x00064DE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 637353, RefRangeEnd = 637354, XrefRangeStart = 637345, XrefRangeEnd = 637353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float3x3(bool3x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr__ctor_Public_Void_bool3x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x00066C14 File Offset: 0x00064E14
		[CallerCount(0)]
		public unsafe float3x3(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x00066C48 File Offset: 0x00064E48
		[CallerCount(0)]
		public unsafe float3x3(int3x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr__ctor_Public_Void_int3x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x00066C7C File Offset: 0x00064E7C
		[CallerCount(0)]
		public unsafe float3x3(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x00066CB0 File Offset: 0x00064EB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 637354, RefRangeEnd = 637355, XrefRangeStart = 637354, XrefRangeEnd = 637354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float3x3(uint3x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr__ctor_Public_Void_uint3x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x00066CE4 File Offset: 0x00064EE4
		[CallerCount(0)]
		public unsafe float3x3(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x00066D18 File Offset: 0x00064F18
		[CallerCount(0)]
		public unsafe float3x3(double3x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr__ctor_Public_Void_double3x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x00066D4C File Offset: 0x00064F4C
		[CallerCount(0)]
		public unsafe static implicit operator float3x3(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_Implicit_Public_Static_float3x3_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x00066D8C File Offset: 0x00064F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637355, XrefRangeEnd = 637356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator float3x3(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_float3x3_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x00066DCC File Offset: 0x00064FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637356, XrefRangeEnd = 637357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator float3x3(bool3x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_float3x3_bool3x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x00066E0C File Offset: 0x0006500C
		[CallerCount(0)]
		public unsafe static implicit operator float3x3(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_Implicit_Public_Static_float3x3_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x00066E4C File Offset: 0x0006504C
		[CallerCount(0)]
		public unsafe static implicit operator float3x3(int3x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_Implicit_Public_Static_float3x3_int3x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x00066E8C File Offset: 0x0006508C
		[CallerCount(0)]
		public unsafe static implicit operator float3x3(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_Implicit_Public_Static_float3x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x00066ECC File Offset: 0x000650CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637357, XrefRangeEnd = 637358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator float3x3(uint3x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_Implicit_Public_Static_float3x3_uint3x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x00066F0C File Offset: 0x0006510C
		[CallerCount(0)]
		public unsafe static explicit operator float3x3(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_float3x3_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x00066F4C File Offset: 0x0006514C
		[CallerCount(0)]
		public unsafe static explicit operator float3x3(double3x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_float3x3_double3x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x00066F8C File Offset: 0x0006518C
		[CallerCount(0)]
		public unsafe static float3x3 operator *(float3x3 lhs, float3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_Multiply_Public_Static_float3x3_float3x3_float3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x00066FD8 File Offset: 0x000651D8
		[CallerCount(0)]
		public unsafe static float3x3 operator *(float3x3 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_Multiply_Public_Static_float3x3_float3x3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x00067024 File Offset: 0x00065224
		[CallerCount(0)]
		public unsafe static float3x3 operator *(float lhs, float3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_Multiply_Public_Static_float3x3_Single_float3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x00067070 File Offset: 0x00065270
		[CallerCount(0)]
		public unsafe static float3x3 operator +(float3x3 lhs, float3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_Addition_Public_Static_float3x3_float3x3_float3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x000670BC File Offset: 0x000652BC
		[CallerCount(0)]
		public unsafe static float3x3 operator +(float3x3 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_Addition_Public_Static_float3x3_float3x3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x00067108 File Offset: 0x00065308
		[CallerCount(0)]
		public unsafe static float3x3 operator +(float lhs, float3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_Addition_Public_Static_float3x3_Single_float3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x00067154 File Offset: 0x00065354
		[CallerCount(0)]
		public unsafe static float3x3 operator -(float3x3 lhs, float3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_float3x3_float3x3_float3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x000671A0 File Offset: 0x000653A0
		[CallerCount(0)]
		public unsafe static float3x3 operator -(float3x3 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_float3x3_float3x3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x000671EC File Offset: 0x000653EC
		[CallerCount(0)]
		public unsafe static float3x3 operator -(float lhs, float3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_float3x3_Single_float3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x00067238 File Offset: 0x00065438
		[CallerCount(0)]
		public unsafe static float3x3 operator /(float3x3 lhs, float3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_Division_Public_Static_float3x3_float3x3_float3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x00067284 File Offset: 0x00065484
		[CallerCount(0)]
		public unsafe static float3x3 operator /(float3x3 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_Division_Public_Static_float3x3_float3x3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x000672D0 File Offset: 0x000654D0
		[CallerCount(0)]
		public unsafe static float3x3 operator /(float lhs, float3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_Division_Public_Static_float3x3_Single_float3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x0006731C File Offset: 0x0006551C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637358, XrefRangeEnd = 637367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float3x3 operator %(float3x3 lhs, float3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_Modulus_Public_Static_float3x3_float3x3_float3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x00067368 File Offset: 0x00065568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637367, XrefRangeEnd = 637376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float3x3 operator %(float3x3 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_Modulus_Public_Static_float3x3_float3x3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x000673B4 File Offset: 0x000655B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637376, XrefRangeEnd = 637385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float3x3 operator %(float lhs, float3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_Modulus_Public_Static_float3x3_Single_float3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x00067400 File Offset: 0x00065600
		[CallerCount(0)]
		public unsafe static float3x3 operator ++(float3x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_Increment_Public_Static_float3x3_float3x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x00067440 File Offset: 0x00065640
		[CallerCount(0)]
		public unsafe static float3x3 operator --(float3x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_Decrement_Public_Static_float3x3_float3x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x00067480 File Offset: 0x00065680
		[CallerCount(0)]
		public unsafe static bool3x3 operator <(float3x3 lhs, float3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x3_float3x3_float3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x000674CC File Offset: 0x000656CC
		[CallerCount(0)]
		public unsafe static bool3x3 operator <(float3x3 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x3_float3x3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x00067518 File Offset: 0x00065718
		[CallerCount(0)]
		public unsafe static bool3x3 operator <(float lhs, float3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x3_Single_float3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x00067564 File Offset: 0x00065764
		[CallerCount(0)]
		public unsafe static bool3x3 operator <=(float3x3 lhs, float3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x3_float3x3_float3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x000675B0 File Offset: 0x000657B0
		[CallerCount(0)]
		public unsafe static bool3x3 operator <=(float3x3 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x3_float3x3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x000675FC File Offset: 0x000657FC
		[CallerCount(0)]
		public unsafe static bool3x3 operator <=(float lhs, float3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x3_Single_float3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x00067648 File Offset: 0x00065848
		[CallerCount(0)]
		public unsafe static bool3x3 operator >(float3x3 lhs, float3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x3_float3x3_float3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x00067694 File Offset: 0x00065894
		[CallerCount(0)]
		public unsafe static bool3x3 operator >(float3x3 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x3_float3x3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x000676E0 File Offset: 0x000658E0
		[CallerCount(0)]
		public unsafe static bool3x3 operator >(float lhs, float3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x3_Single_float3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x0006772C File Offset: 0x0006592C
		[CallerCount(0)]
		public unsafe static bool3x3 operator >=(float3x3 lhs, float3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x3_float3x3_float3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x00067778 File Offset: 0x00065978
		[CallerCount(0)]
		public unsafe static bool3x3 operator >=(float3x3 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x3_float3x3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x000677C4 File Offset: 0x000659C4
		[CallerCount(0)]
		public unsafe static bool3x3 operator >=(float lhs, float3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x3_Single_float3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x00067810 File Offset: 0x00065A10
		[CallerCount(0)]
		public unsafe static float3x3 operator -(float3x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_float3x3_float3x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x00067850 File Offset: 0x00065A50
		[CallerCount(0)]
		public unsafe static float3x3 operator +(float3x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_float3x3_float3x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x00067890 File Offset: 0x00065A90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637385, XrefRangeEnd = 637394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool3x3 operator ==(float3x3 lhs, float3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_float3x3_float3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x000678DC File Offset: 0x00065ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637394, XrefRangeEnd = 637403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool3x3 operator ==(float3x3 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_float3x3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x00067928 File Offset: 0x00065B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637403, XrefRangeEnd = 637412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool3x3 operator ==(float lhs, float3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_Single_float3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x00067974 File Offset: 0x00065B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637412, XrefRangeEnd = 637421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool3x3 operator !=(float3x3 lhs, float3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_float3x3_float3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x000679C0 File Offset: 0x00065BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637421, XrefRangeEnd = 637430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool3x3 operator !=(float3x3 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_float3x3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x00067A0C File Offset: 0x00065C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637430, XrefRangeEnd = 637439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool3x3 operator !=(float lhs, float3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_Single_float3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170004A0 RID: 1184
		public unsafe ref float3 this[int index]
		{
			[CallerCount(0)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_get_Item_Public_get_byref_float3_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x00067A8C File Offset: 0x00065C8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 637439, RefRangeEnd = 637440, XrefRangeStart = 637439, XrefRangeEnd = 637439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(float3x3 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_float3x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x00067ACC File Offset: 0x00065CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637440, XrefRangeEnd = 637444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x00067B10 File Offset: 0x00065D10
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x00067B40 File Offset: 0x00065D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637444, XrefRangeEnd = 637487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x00067B6C File Offset: 0x00065D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637487, XrefRangeEnd = 637542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x00067BBC File Offset: 0x00065DBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 637542, RefRangeEnd = 637544, XrefRangeStart = 637542, XrefRangeEnd = 637542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float3x3(float4x4 f4x4)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f4x4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr__ctor_Public_Void_float4x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x00067BF0 File Offset: 0x00065DF0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 637544, RefRangeEnd = 637549, XrefRangeStart = 637544, XrefRangeEnd = 637544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float3x3(quaternion q)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref q;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr__ctor_Public_Void_quaternion_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x00067C24 File Offset: 0x00065E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637549, XrefRangeEnd = 637557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float3x3 AxisAngle(float3 axis, float angle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axis;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_AxisAngle_Public_Static_float3x3_float3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x00067C70 File Offset: 0x00065E70
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 637558, RefRangeEnd = 637561, XrefRangeStart = 637557, XrefRangeEnd = 637558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float3x3 EulerXYZ(float3 xyz)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyz;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_EulerXYZ_Public_Static_float3x3_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x00067CB0 File Offset: 0x00065EB0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 637562, RefRangeEnd = 637565, XrefRangeStart = 637561, XrefRangeEnd = 637562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float3x3 EulerXZY(float3 xyz)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyz;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_EulerXZY_Public_Static_float3x3_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x00067CF0 File Offset: 0x00065EF0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 637566, RefRangeEnd = 637569, XrefRangeStart = 637565, XrefRangeEnd = 637566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float3x3 EulerYXZ(float3 xyz)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyz;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_EulerYXZ_Public_Static_float3x3_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x00067D30 File Offset: 0x00065F30
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 637570, RefRangeEnd = 637573, XrefRangeStart = 637569, XrefRangeEnd = 637570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float3x3 EulerYZX(float3 xyz)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyz;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_EulerYZX_Public_Static_float3x3_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x00067D70 File Offset: 0x00065F70
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 637574, RefRangeEnd = 637577, XrefRangeStart = 637573, XrefRangeEnd = 637574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float3x3 EulerZXY(float3 xyz)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyz;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_EulerZXY_Public_Static_float3x3_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x00067DB0 File Offset: 0x00065FB0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 637578, RefRangeEnd = 637581, XrefRangeStart = 637577, XrefRangeEnd = 637578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float3x3 EulerZYX(float3 xyz)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyz;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_EulerZYX_Public_Static_float3x3_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x00067DF0 File Offset: 0x00065FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637581, XrefRangeEnd = 637582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float3x3 EulerXYZ(float x, float y, float z)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_EulerXYZ_Public_Static_float3x3_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x00067E4C File Offset: 0x0006604C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637582, XrefRangeEnd = 637583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float3x3 EulerXZY(float x, float y, float z)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_EulerXZY_Public_Static_float3x3_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x00067EA8 File Offset: 0x000660A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637583, XrefRangeEnd = 637584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float3x3 EulerYXZ(float x, float y, float z)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_EulerYXZ_Public_Static_float3x3_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x00067F04 File Offset: 0x00066104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637584, XrefRangeEnd = 637585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float3x3 EulerYZX(float x, float y, float z)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_EulerYZX_Public_Static_float3x3_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x00067F60 File Offset: 0x00066160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637585, XrefRangeEnd = 637586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float3x3 EulerZXY(float x, float y, float z)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_EulerZXY_Public_Static_float3x3_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x00067FBC File Offset: 0x000661BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637586, XrefRangeEnd = 637587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float3x3 EulerZYX(float x, float y, float z)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_EulerZYX_Public_Static_float3x3_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x00068018 File Offset: 0x00066218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637587, XrefRangeEnd = 637601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float3x3 Euler(float3 xyz, math.RotationOrder order = math.RotationOrder.ZXY)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xyz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref order;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_Euler_Public_Static_float3x3_float3_RotationOrder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x00068064 File Offset: 0x00066264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637601, XrefRangeEnd = 637615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float3x3 Euler(float x, float y, float z, math.RotationOrder order = math.RotationOrder.ZXY)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_Euler_Public_Static_float3x3_Single_Single_Single_RotationOrder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x000680CC File Offset: 0x000662CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637615, XrefRangeEnd = 637623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float3x3 RotateX(float angle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_RotateX_Public_Static_float3x3_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x0006810C File Offset: 0x0006630C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637623, XrefRangeEnd = 637631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float3x3 RotateY(float angle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_RotateY_Public_Static_float3x3_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x0006814C File Offset: 0x0006634C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637631, XrefRangeEnd = 637639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float3x3 RotateZ(float angle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_RotateZ_Public_Static_float3x3_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x0006818C File Offset: 0x0006638C
		[CallerCount(0)]
		public unsafe static float3x3 Scale(float s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref s;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_Scale_Public_Static_float3x3_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600132C RID: 4908 RVA: 0x000681CC File Offset: 0x000663CC
		[CallerCount(0)]
		public unsafe static float3x3 Scale(float x, float y, float z)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_Scale_Public_Static_float3x3_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600132D RID: 4909 RVA: 0x00068228 File Offset: 0x00066428
		[CallerCount(0)]
		public unsafe static float3x3 Scale(float3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_Scale_Public_Static_float3x3_float3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600132E RID: 4910 RVA: 0x00068268 File Offset: 0x00066468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637639, XrefRangeEnd = 637640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float3x3 LookRotation(float3 forward, float3 up)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref forward;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref up;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_LookRotation_Public_Static_float3x3_float3_float3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600132F RID: 4911 RVA: 0x000682B4 File Offset: 0x000664B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637640, XrefRangeEnd = 637648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float3x3 LookRotationSafe(float3 forward, float3 up)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref forward;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref up;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_LookRotationSafe_Public_Static_float3x3_float3_float3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001330 RID: 4912 RVA: 0x00068300 File Offset: 0x00066500
		[CallerCount(0)]
		public unsafe static explicit operator float3x3(float4x4 f4x4)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f4x4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_float3x3_float4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x00002528 File Offset: 0x00000728
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<float3x3>.NativeClassPtr, ref this));
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06001332 RID: 4914 RVA: 0x00068340 File Offset: 0x00066540
		// (set) Token: 0x06001333 RID: 4915 RVA: 0x0000253A File Offset: 0x0000073A
		public unsafe static float3x3 identity
		{
			get
			{
				float3x3 float3x;
				IL2CPP.il2cpp_field_static_get_value(float3x3.NativeFieldInfoPtr_identity, (void*)(&float3x));
				return float3x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(float3x3.NativeFieldInfoPtr_identity, (void*)(&value));
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06001334 RID: 4916 RVA: 0x0006835C File Offset: 0x0006655C
		// (set) Token: 0x06001335 RID: 4917 RVA: 0x00002548 File Offset: 0x00000748
		public unsafe static float3x3 zero
		{
			get
			{
				float3x3 float3x;
				IL2CPP.il2cpp_field_static_get_value(float3x3.NativeFieldInfoPtr_zero, (void*)(&float3x));
				return float3x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(float3x3.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x04001319 RID: 4889
		private static readonly IntPtr NativeFieldInfoPtr_c0;

		// Token: 0x0400131A RID: 4890
		private static readonly IntPtr NativeFieldInfoPtr_c1;

		// Token: 0x0400131B RID: 4891
		private static readonly IntPtr NativeFieldInfoPtr_c2;

		// Token: 0x0400131C RID: 4892
		private static readonly IntPtr NativeFieldInfoPtr_identity;

		// Token: 0x0400131D RID: 4893
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x0400131E RID: 4894
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float3_float3_float3_0;

		// Token: 0x0400131F RID: 4895
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_Single_Single_Single_0;

		// Token: 0x04001320 RID: 4896
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x04001321 RID: 4897
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04001322 RID: 4898
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool3x3_0;

		// Token: 0x04001323 RID: 4899
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001324 RID: 4900
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int3x3_0;

		// Token: 0x04001325 RID: 4901
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04001326 RID: 4902
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint3x3_0;

		// Token: 0x04001327 RID: 4903
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x04001328 RID: 4904
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double3x3_0;

		// Token: 0x04001329 RID: 4905
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float3x3_Single_0;

		// Token: 0x0400132A RID: 4906
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_float3x3_Boolean_0;

		// Token: 0x0400132B RID: 4907
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_float3x3_bool3x3_0;

		// Token: 0x0400132C RID: 4908
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float3x3_Int32_0;

		// Token: 0x0400132D RID: 4909
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float3x3_int3x3_0;

		// Token: 0x0400132E RID: 4910
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float3x3_UInt32_0;

		// Token: 0x0400132F RID: 4911
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float3x3_uint3x3_0;

		// Token: 0x04001330 RID: 4912
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_float3x3_Double_0;

		// Token: 0x04001331 RID: 4913
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_float3x3_double3x3_0;

		// Token: 0x04001332 RID: 4914
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_float3x3_float3x3_float3x3_0;

		// Token: 0x04001333 RID: 4915
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_float3x3_float3x3_Single_0;

		// Token: 0x04001334 RID: 4916
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_float3x3_Single_float3x3_0;

		// Token: 0x04001335 RID: 4917
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_float3x3_float3x3_float3x3_0;

		// Token: 0x04001336 RID: 4918
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_float3x3_float3x3_Single_0;

		// Token: 0x04001337 RID: 4919
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_float3x3_Single_float3x3_0;

		// Token: 0x04001338 RID: 4920
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_float3x3_float3x3_float3x3_0;

		// Token: 0x04001339 RID: 4921
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_float3x3_float3x3_Single_0;

		// Token: 0x0400133A RID: 4922
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_float3x3_Single_float3x3_0;

		// Token: 0x0400133B RID: 4923
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_float3x3_float3x3_float3x3_0;

		// Token: 0x0400133C RID: 4924
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_float3x3_float3x3_Single_0;

		// Token: 0x0400133D RID: 4925
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_float3x3_Single_float3x3_0;

		// Token: 0x0400133E RID: 4926
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_float3x3_float3x3_float3x3_0;

		// Token: 0x0400133F RID: 4927
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_float3x3_float3x3_Single_0;

		// Token: 0x04001340 RID: 4928
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_float3x3_Single_float3x3_0;

		// Token: 0x04001341 RID: 4929
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_float3x3_float3x3_0;

		// Token: 0x04001342 RID: 4930
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_float3x3_float3x3_0;

		// Token: 0x04001343 RID: 4931
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x3_float3x3_float3x3_0;

		// Token: 0x04001344 RID: 4932
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x3_float3x3_Single_0;

		// Token: 0x04001345 RID: 4933
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x3_Single_float3x3_0;

		// Token: 0x04001346 RID: 4934
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x3_float3x3_float3x3_0;

		// Token: 0x04001347 RID: 4935
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x3_float3x3_Single_0;

		// Token: 0x04001348 RID: 4936
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x3_Single_float3x3_0;

		// Token: 0x04001349 RID: 4937
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x3_float3x3_float3x3_0;

		// Token: 0x0400134A RID: 4938
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x3_float3x3_Single_0;

		// Token: 0x0400134B RID: 4939
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x3_Single_float3x3_0;

		// Token: 0x0400134C RID: 4940
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x3_float3x3_float3x3_0;

		// Token: 0x0400134D RID: 4941
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x3_float3x3_Single_0;

		// Token: 0x0400134E RID: 4942
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x3_Single_float3x3_0;

		// Token: 0x0400134F RID: 4943
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_float3x3_float3x3_0;

		// Token: 0x04001350 RID: 4944
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryPlus_Public_Static_float3x3_float3x3_0;

		// Token: 0x04001351 RID: 4945
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_float3x3_float3x3_0;

		// Token: 0x04001352 RID: 4946
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_float3x3_Single_0;

		// Token: 0x04001353 RID: 4947
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_Single_float3x3_0;

		// Token: 0x04001354 RID: 4948
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_float3x3_float3x3_0;

		// Token: 0x04001355 RID: 4949
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_float3x3_Single_0;

		// Token: 0x04001356 RID: 4950
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_Single_float3x3_0;

		// Token: 0x04001357 RID: 4951
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_float3_Int32_0;

		// Token: 0x04001358 RID: 4952
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_float3x3_0;

		// Token: 0x04001359 RID: 4953
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400135A RID: 4954
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400135B RID: 4955
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400135C RID: 4956
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x0400135D RID: 4957
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float4x4_0;

		// Token: 0x0400135E RID: 4958
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_quaternion_0;

		// Token: 0x0400135F RID: 4959
		private static readonly IntPtr NativeMethodInfoPtr_AxisAngle_Public_Static_float3x3_float3_Single_0;

		// Token: 0x04001360 RID: 4960
		private static readonly IntPtr NativeMethodInfoPtr_EulerXYZ_Public_Static_float3x3_float3_0;

		// Token: 0x04001361 RID: 4961
		private static readonly IntPtr NativeMethodInfoPtr_EulerXZY_Public_Static_float3x3_float3_0;

		// Token: 0x04001362 RID: 4962
		private static readonly IntPtr NativeMethodInfoPtr_EulerYXZ_Public_Static_float3x3_float3_0;

		// Token: 0x04001363 RID: 4963
		private static readonly IntPtr NativeMethodInfoPtr_EulerYZX_Public_Static_float3x3_float3_0;

		// Token: 0x04001364 RID: 4964
		private static readonly IntPtr NativeMethodInfoPtr_EulerZXY_Public_Static_float3x3_float3_0;

		// Token: 0x04001365 RID: 4965
		private static readonly IntPtr NativeMethodInfoPtr_EulerZYX_Public_Static_float3x3_float3_0;

		// Token: 0x04001366 RID: 4966
		private static readonly IntPtr NativeMethodInfoPtr_EulerXYZ_Public_Static_float3x3_Single_Single_Single_0;

		// Token: 0x04001367 RID: 4967
		private static readonly IntPtr NativeMethodInfoPtr_EulerXZY_Public_Static_float3x3_Single_Single_Single_0;

		// Token: 0x04001368 RID: 4968
		private static readonly IntPtr NativeMethodInfoPtr_EulerYXZ_Public_Static_float3x3_Single_Single_Single_0;

		// Token: 0x04001369 RID: 4969
		private static readonly IntPtr NativeMethodInfoPtr_EulerYZX_Public_Static_float3x3_Single_Single_Single_0;

		// Token: 0x0400136A RID: 4970
		private static readonly IntPtr NativeMethodInfoPtr_EulerZXY_Public_Static_float3x3_Single_Single_Single_0;

		// Token: 0x0400136B RID: 4971
		private static readonly IntPtr NativeMethodInfoPtr_EulerZYX_Public_Static_float3x3_Single_Single_Single_0;

		// Token: 0x0400136C RID: 4972
		private static readonly IntPtr NativeMethodInfoPtr_Euler_Public_Static_float3x3_float3_RotationOrder_0;

		// Token: 0x0400136D RID: 4973
		private static readonly IntPtr NativeMethodInfoPtr_Euler_Public_Static_float3x3_Single_Single_Single_RotationOrder_0;

		// Token: 0x0400136E RID: 4974
		private static readonly IntPtr NativeMethodInfoPtr_RotateX_Public_Static_float3x3_Single_0;

		// Token: 0x0400136F RID: 4975
		private static readonly IntPtr NativeMethodInfoPtr_RotateY_Public_Static_float3x3_Single_0;

		// Token: 0x04001370 RID: 4976
		private static readonly IntPtr NativeMethodInfoPtr_RotateZ_Public_Static_float3x3_Single_0;

		// Token: 0x04001371 RID: 4977
		private static readonly IntPtr NativeMethodInfoPtr_Scale_Public_Static_float3x3_Single_0;

		// Token: 0x04001372 RID: 4978
		private static readonly IntPtr NativeMethodInfoPtr_Scale_Public_Static_float3x3_Single_Single_Single_0;

		// Token: 0x04001373 RID: 4979
		private static readonly IntPtr NativeMethodInfoPtr_Scale_Public_Static_float3x3_float3_0;

		// Token: 0x04001374 RID: 4980
		private static readonly IntPtr NativeMethodInfoPtr_LookRotation_Public_Static_float3x3_float3_float3_0;

		// Token: 0x04001375 RID: 4981
		private static readonly IntPtr NativeMethodInfoPtr_LookRotationSafe_Public_Static_float3x3_float3_float3_0;

		// Token: 0x04001376 RID: 4982
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_float3x3_float4x4_0;

		// Token: 0x04001377 RID: 4983
		[FieldOffset(0)]
		public float3 c0;

		// Token: 0x04001378 RID: 4984
		[FieldOffset(12)]
		public float3 c1;

		// Token: 0x04001379 RID: 4985
		[FieldOffset(24)]
		public float3 c2;
	}
}
