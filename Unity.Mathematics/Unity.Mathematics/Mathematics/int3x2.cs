using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x02000032 RID: 50
	[Serializable]
	[StructLayout(2)]
	public struct int3x2
	{
		// Token: 0x06001B11 RID: 6929 RVA: 0x0008DB9C File Offset: 0x0008BD9C
		// Note: this type is marked as 'beforefieldinit'.
		static int3x2()
		{
			Il2CppClassPointerStore<int3x2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "int3x2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<int3x2>.NativeClassPtr);
			int3x2.NativeFieldInfoPtr_c0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int3x2>.NativeClassPtr, "c0");
			int3x2.NativeFieldInfoPtr_c1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int3x2>.NativeClassPtr, "c1");
			int3x2.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int3x2>.NativeClassPtr, "zero");
			int3x2.NativeMethodInfoPtr__ctor_Public_Void_int3_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670027);
			int3x2.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670028);
			int3x2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670029);
			int3x2.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670030);
			int3x2.NativeMethodInfoPtr__ctor_Public_Void_bool3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670031);
			int3x2.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670032);
			int3x2.NativeMethodInfoPtr__ctor_Public_Void_uint3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670033);
			int3x2.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670034);
			int3x2.NativeMethodInfoPtr__ctor_Public_Void_float3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670035);
			int3x2.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670036);
			int3x2.NativeMethodInfoPtr__ctor_Public_Void_double3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670037);
			int3x2.NativeMethodInfoPtr_op_Implicit_Public_Static_int3x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670038);
			int3x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670039);
			int3x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x2_bool3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670040);
			int3x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670041);
			int3x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x2_uint3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670042);
			int3x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670043);
			int3x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x2_float3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670044);
			int3x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x2_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670045);
			int3x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x2_double3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670046);
			int3x2.NativeMethodInfoPtr_op_Multiply_Public_Static_int3x2_int3x2_int3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670047);
			int3x2.NativeMethodInfoPtr_op_Multiply_Public_Static_int3x2_int3x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670048);
			int3x2.NativeMethodInfoPtr_op_Multiply_Public_Static_int3x2_Int32_int3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670049);
			int3x2.NativeMethodInfoPtr_op_Addition_Public_Static_int3x2_int3x2_int3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670050);
			int3x2.NativeMethodInfoPtr_op_Addition_Public_Static_int3x2_int3x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670051);
			int3x2.NativeMethodInfoPtr_op_Addition_Public_Static_int3x2_Int32_int3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670052);
			int3x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_int3x2_int3x2_int3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670053);
			int3x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_int3x2_int3x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670054);
			int3x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_int3x2_Int32_int3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670055);
			int3x2.NativeMethodInfoPtr_op_Division_Public_Static_int3x2_int3x2_int3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670056);
			int3x2.NativeMethodInfoPtr_op_Division_Public_Static_int3x2_int3x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670057);
			int3x2.NativeMethodInfoPtr_op_Division_Public_Static_int3x2_Int32_int3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670058);
			int3x2.NativeMethodInfoPtr_op_Modulus_Public_Static_int3x2_int3x2_int3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670059);
			int3x2.NativeMethodInfoPtr_op_Modulus_Public_Static_int3x2_int3x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670060);
			int3x2.NativeMethodInfoPtr_op_Modulus_Public_Static_int3x2_Int32_int3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670061);
			int3x2.NativeMethodInfoPtr_op_Increment_Public_Static_int3x2_int3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670062);
			int3x2.NativeMethodInfoPtr_op_Decrement_Public_Static_int3x2_int3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670063);
			int3x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x2_int3x2_int3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670064);
			int3x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x2_int3x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670065);
			int3x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x2_Int32_int3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670066);
			int3x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x2_int3x2_int3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670067);
			int3x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x2_int3x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670068);
			int3x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x2_Int32_int3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670069);
			int3x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x2_int3x2_int3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670070);
			int3x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x2_int3x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670071);
			int3x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x2_Int32_int3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670072);
			int3x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x2_int3x2_int3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670073);
			int3x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x2_int3x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670074);
			int3x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x2_Int32_int3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670075);
			int3x2.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_int3x2_int3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670076);
			int3x2.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_int3x2_int3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670077);
			int3x2.NativeMethodInfoPtr_op_LeftShift_Public_Static_int3x2_int3x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670078);
			int3x2.NativeMethodInfoPtr_op_RightShift_Public_Static_int3x2_int3x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670079);
			int3x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x2_int3x2_int3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670080);
			int3x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x2_int3x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670081);
			int3x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x2_Int32_int3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670082);
			int3x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x2_int3x2_int3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670083);
			int3x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x2_int3x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670084);
			int3x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x2_Int32_int3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670085);
			int3x2.NativeMethodInfoPtr_op_OnesComplement_Public_Static_int3x2_int3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670086);
			int3x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int3x2_int3x2_int3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670087);
			int3x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int3x2_int3x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670088);
			int3x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int3x2_Int32_int3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670089);
			int3x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int3x2_int3x2_int3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670090);
			int3x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int3x2_int3x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670091);
			int3x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int3x2_Int32_int3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670092);
			int3x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int3x2_int3x2_int3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670093);
			int3x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int3x2_int3x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670094);
			int3x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int3x2_Int32_int3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670095);
			int3x2.NativeMethodInfoPtr_get_Item_Public_get_byref_int3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670096);
			int3x2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_int3x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670097);
			int3x2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670098);
			int3x2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670099);
			int3x2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670100);
			int3x2.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x2>.NativeClassPtr, 100670101);
		}

		// Token: 0x06001B12 RID: 6930 RVA: 0x0008E1E4 File Offset: 0x0008C3E4
		[CallerCount(0)]
		public unsafe int3x2(int3 c0, int3 c1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr__ctor_Public_Void_int3_int3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B13 RID: 6931 RVA: 0x0008E224 File Offset: 0x0008C424
		[CallerCount(0)]
		public unsafe int3x2(int m00, int m01, int m10, int m11, int m20, int m21)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref m00;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m01;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m10;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m11;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m20;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m21;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B14 RID: 6932 RVA: 0x0008E29C File Offset: 0x0008C49C
		[CallerCount(0)]
		public unsafe int3x2(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B15 RID: 6933 RVA: 0x0008E2D0 File Offset: 0x0008C4D0
		[CallerCount(0)]
		public unsafe int3x2(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B16 RID: 6934 RVA: 0x0008E304 File Offset: 0x0008C504
		[CallerCount(0)]
		public unsafe int3x2(bool3x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr__ctor_Public_Void_bool3x2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B17 RID: 6935 RVA: 0x0008E338 File Offset: 0x0008C538
		[CallerCount(0)]
		public unsafe int3x2(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B18 RID: 6936 RVA: 0x0008E36C File Offset: 0x0008C56C
		[CallerCount(0)]
		public unsafe int3x2(uint3x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr__ctor_Public_Void_uint3x2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B19 RID: 6937 RVA: 0x0008E3A0 File Offset: 0x0008C5A0
		[CallerCount(0)]
		public unsafe int3x2(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B1A RID: 6938 RVA: 0x0008E3D4 File Offset: 0x0008C5D4
		[CallerCount(0)]
		public unsafe int3x2(float3x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr__ctor_Public_Void_float3x2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B1B RID: 6939 RVA: 0x0008E408 File Offset: 0x0008C608
		[CallerCount(0)]
		public unsafe int3x2(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B1C RID: 6940 RVA: 0x0008E43C File Offset: 0x0008C63C
		[CallerCount(0)]
		public unsafe int3x2(double3x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr__ctor_Public_Void_double3x2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B1D RID: 6941 RVA: 0x0008E470 File Offset: 0x0008C670
		[CallerCount(0)]
		public unsafe static implicit operator int3x2(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_Implicit_Public_Static_int3x2_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B1E RID: 6942 RVA: 0x0008E4B0 File Offset: 0x0008C6B0
		[CallerCount(0)]
		public unsafe static explicit operator int3x2(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x2_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B1F RID: 6943 RVA: 0x0008E4F0 File Offset: 0x0008C6F0
		[CallerCount(0)]
		public unsafe static explicit operator int3x2(bool3x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x2_bool3x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B20 RID: 6944 RVA: 0x0008E530 File Offset: 0x0008C730
		[CallerCount(0)]
		public unsafe static explicit operator int3x2(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B21 RID: 6945 RVA: 0x0008E570 File Offset: 0x0008C770
		[CallerCount(0)]
		public unsafe static explicit operator int3x2(uint3x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x2_uint3x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B22 RID: 6946 RVA: 0x0008E5B0 File Offset: 0x0008C7B0
		[CallerCount(0)]
		public unsafe static explicit operator int3x2(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x2_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B23 RID: 6947 RVA: 0x0008E5F0 File Offset: 0x0008C7F0
		[CallerCount(0)]
		public unsafe static explicit operator int3x2(float3x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x2_float3x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B24 RID: 6948 RVA: 0x0008E630 File Offset: 0x0008C830
		[CallerCount(0)]
		public unsafe static explicit operator int3x2(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x2_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B25 RID: 6949 RVA: 0x0008E670 File Offset: 0x0008C870
		[CallerCount(0)]
		public unsafe static explicit operator int3x2(double3x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x2_double3x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B26 RID: 6950 RVA: 0x0008E6B0 File Offset: 0x0008C8B0
		[CallerCount(0)]
		public unsafe static int3x2 operator *(int3x2 lhs, int3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_Multiply_Public_Static_int3x2_int3x2_int3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B27 RID: 6951 RVA: 0x0008E6FC File Offset: 0x0008C8FC
		[CallerCount(0)]
		public unsafe static int3x2 operator *(int3x2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_Multiply_Public_Static_int3x2_int3x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B28 RID: 6952 RVA: 0x0008E748 File Offset: 0x0008C948
		[CallerCount(0)]
		public unsafe static int3x2 operator *(int lhs, int3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_Multiply_Public_Static_int3x2_Int32_int3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B29 RID: 6953 RVA: 0x0008E794 File Offset: 0x0008C994
		[CallerCount(0)]
		public unsafe static int3x2 operator +(int3x2 lhs, int3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_Addition_Public_Static_int3x2_int3x2_int3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B2A RID: 6954 RVA: 0x0008E7E0 File Offset: 0x0008C9E0
		[CallerCount(0)]
		public unsafe static int3x2 operator +(int3x2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_Addition_Public_Static_int3x2_int3x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B2B RID: 6955 RVA: 0x0008E82C File Offset: 0x0008CA2C
		[CallerCount(0)]
		public unsafe static int3x2 operator +(int lhs, int3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_Addition_Public_Static_int3x2_Int32_int3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B2C RID: 6956 RVA: 0x0008E878 File Offset: 0x0008CA78
		[CallerCount(0)]
		public unsafe static int3x2 operator -(int3x2 lhs, int3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_int3x2_int3x2_int3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B2D RID: 6957 RVA: 0x0008E8C4 File Offset: 0x0008CAC4
		[CallerCount(0)]
		public unsafe static int3x2 operator -(int3x2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_int3x2_int3x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B2E RID: 6958 RVA: 0x0008E910 File Offset: 0x0008CB10
		[CallerCount(0)]
		public unsafe static int3x2 operator -(int lhs, int3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_int3x2_Int32_int3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B2F RID: 6959 RVA: 0x0008E95C File Offset: 0x0008CB5C
		[CallerCount(0)]
		public unsafe static int3x2 operator /(int3x2 lhs, int3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_Division_Public_Static_int3x2_int3x2_int3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B30 RID: 6960 RVA: 0x0008E9A8 File Offset: 0x0008CBA8
		[CallerCount(0)]
		public unsafe static int3x2 operator /(int3x2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_Division_Public_Static_int3x2_int3x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B31 RID: 6961 RVA: 0x0008E9F4 File Offset: 0x0008CBF4
		[CallerCount(0)]
		public unsafe static int3x2 operator /(int lhs, int3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_Division_Public_Static_int3x2_Int32_int3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B32 RID: 6962 RVA: 0x0008EA40 File Offset: 0x0008CC40
		[CallerCount(0)]
		public unsafe static int3x2 operator %(int3x2 lhs, int3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_Modulus_Public_Static_int3x2_int3x2_int3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B33 RID: 6963 RVA: 0x0008EA8C File Offset: 0x0008CC8C
		[CallerCount(0)]
		public unsafe static int3x2 operator %(int3x2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_Modulus_Public_Static_int3x2_int3x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B34 RID: 6964 RVA: 0x0008EAD8 File Offset: 0x0008CCD8
		[CallerCount(0)]
		public unsafe static int3x2 operator %(int lhs, int3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_Modulus_Public_Static_int3x2_Int32_int3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B35 RID: 6965 RVA: 0x0008EB24 File Offset: 0x0008CD24
		[CallerCount(0)]
		public unsafe static int3x2 operator ++(int3x2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_Increment_Public_Static_int3x2_int3x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B36 RID: 6966 RVA: 0x0008EB64 File Offset: 0x0008CD64
		[CallerCount(0)]
		public unsafe static int3x2 operator --(int3x2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_Decrement_Public_Static_int3x2_int3x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x0008EBA4 File Offset: 0x0008CDA4
		[CallerCount(0)]
		public unsafe static bool3x2 operator <(int3x2 lhs, int3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x2_int3x2_int3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B38 RID: 6968 RVA: 0x0008EBF0 File Offset: 0x0008CDF0
		[CallerCount(0)]
		public unsafe static bool3x2 operator <(int3x2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x2_int3x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x0008EC3C File Offset: 0x0008CE3C
		[CallerCount(0)]
		public unsafe static bool3x2 operator <(int lhs, int3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x2_Int32_int3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B3A RID: 6970 RVA: 0x0008EC88 File Offset: 0x0008CE88
		[CallerCount(0)]
		public unsafe static bool3x2 operator <=(int3x2 lhs, int3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x2_int3x2_int3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B3B RID: 6971 RVA: 0x0008ECD4 File Offset: 0x0008CED4
		[CallerCount(0)]
		public unsafe static bool3x2 operator <=(int3x2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x2_int3x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B3C RID: 6972 RVA: 0x0008ED20 File Offset: 0x0008CF20
		[CallerCount(0)]
		public unsafe static bool3x2 operator <=(int lhs, int3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x2_Int32_int3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x0008ED6C File Offset: 0x0008CF6C
		[CallerCount(0)]
		public unsafe static bool3x2 operator >(int3x2 lhs, int3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x2_int3x2_int3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x0008EDB8 File Offset: 0x0008CFB8
		[CallerCount(0)]
		public unsafe static bool3x2 operator >(int3x2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x2_int3x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x0008EE04 File Offset: 0x0008D004
		[CallerCount(0)]
		public unsafe static bool3x2 operator >(int lhs, int3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x2_Int32_int3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B40 RID: 6976 RVA: 0x0008EE50 File Offset: 0x0008D050
		[CallerCount(0)]
		public unsafe static bool3x2 operator >=(int3x2 lhs, int3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x2_int3x2_int3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x0008EE9C File Offset: 0x0008D09C
		[CallerCount(0)]
		public unsafe static bool3x2 operator >=(int3x2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x2_int3x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x0008EEE8 File Offset: 0x0008D0E8
		[CallerCount(0)]
		public unsafe static bool3x2 operator >=(int lhs, int3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x2_Int32_int3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x0008EF34 File Offset: 0x0008D134
		[CallerCount(0)]
		public unsafe static int3x2 operator -(int3x2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_int3x2_int3x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x0008EF74 File Offset: 0x0008D174
		[CallerCount(0)]
		public unsafe static int3x2 operator +(int3x2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_int3x2_int3x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x0008EFB4 File Offset: 0x0008D1B4
		[CallerCount(0)]
		public unsafe static int3x2 operator <<(int3x2 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_LeftShift_Public_Static_int3x2_int3x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B46 RID: 6982 RVA: 0x0008F000 File Offset: 0x0008D200
		[CallerCount(0)]
		public unsafe static int3x2 operator >>(int3x2 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_RightShift_Public_Static_int3x2_int3x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B47 RID: 6983 RVA: 0x0008F04C File Offset: 0x0008D24C
		[CallerCount(0)]
		public unsafe static bool3x2 operator ==(int3x2 lhs, int3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x2_int3x2_int3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B48 RID: 6984 RVA: 0x0008F098 File Offset: 0x0008D298
		[CallerCount(0)]
		public unsafe static bool3x2 operator ==(int3x2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x2_int3x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B49 RID: 6985 RVA: 0x0008F0E4 File Offset: 0x0008D2E4
		[CallerCount(0)]
		public unsafe static bool3x2 operator ==(int lhs, int3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x2_Int32_int3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B4A RID: 6986 RVA: 0x0008F130 File Offset: 0x0008D330
		[CallerCount(0)]
		public unsafe static bool3x2 operator !=(int3x2 lhs, int3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x2_int3x2_int3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B4B RID: 6987 RVA: 0x0008F17C File Offset: 0x0008D37C
		[CallerCount(0)]
		public unsafe static bool3x2 operator !=(int3x2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x2_int3x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B4C RID: 6988 RVA: 0x0008F1C8 File Offset: 0x0008D3C8
		[CallerCount(0)]
		public unsafe static bool3x2 operator !=(int lhs, int3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x2_Int32_int3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x0008F214 File Offset: 0x0008D414
		[CallerCount(0)]
		public unsafe static int3x2 operator ~(int3x2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_OnesComplement_Public_Static_int3x2_int3x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B4E RID: 6990 RVA: 0x0008F254 File Offset: 0x0008D454
		[CallerCount(0)]
		public unsafe static int3x2 operator &(int3x2 lhs, int3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int3x2_int3x2_int3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B4F RID: 6991 RVA: 0x0008F2A0 File Offset: 0x0008D4A0
		[CallerCount(0)]
		public unsafe static int3x2 operator &(int3x2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int3x2_int3x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B50 RID: 6992 RVA: 0x0008F2EC File Offset: 0x0008D4EC
		[CallerCount(0)]
		public unsafe static int3x2 operator &(int lhs, int3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int3x2_Int32_int3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B51 RID: 6993 RVA: 0x0008F338 File Offset: 0x0008D538
		[CallerCount(0)]
		public unsafe static int3x2 operator |(int3x2 lhs, int3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int3x2_int3x2_int3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B52 RID: 6994 RVA: 0x0008F384 File Offset: 0x0008D584
		[CallerCount(0)]
		public unsafe static int3x2 operator |(int3x2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int3x2_int3x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B53 RID: 6995 RVA: 0x0008F3D0 File Offset: 0x0008D5D0
		[CallerCount(0)]
		public unsafe static int3x2 operator |(int lhs, int3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int3x2_Int32_int3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B54 RID: 6996 RVA: 0x0008F41C File Offset: 0x0008D61C
		[CallerCount(0)]
		public unsafe static int3x2 operator ^(int3x2 lhs, int3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int3x2_int3x2_int3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x0008F468 File Offset: 0x0008D668
		[CallerCount(0)]
		public unsafe static int3x2 operator ^(int3x2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int3x2_int3x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B56 RID: 6998 RVA: 0x0008F4B4 File Offset: 0x0008D6B4
		[CallerCount(0)]
		public unsafe static int3x2 operator ^(int lhs, int3x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int3x2_Int32_int3x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000885 RID: 2181
		public unsafe ref int3 this[int index]
		{
			[CallerCount(0)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_get_Item_Public_get_byref_int3_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x06001B58 RID: 7000 RVA: 0x0008F534 File Offset: 0x0008D734
		[CallerCount(0)]
		public unsafe bool Equals(int3x2 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_int3x2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B59 RID: 7001 RVA: 0x0008F574 File Offset: 0x0008D774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639414, XrefRangeEnd = 639417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B5A RID: 7002 RVA: 0x0008F5B8 File Offset: 0x0008D7B8
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B5B RID: 7003 RVA: 0x0008F5E8 File Offset: 0x0008D7E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639417, XrefRangeEnd = 639448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001B5C RID: 7004 RVA: 0x0008F614 File Offset: 0x0008D814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639448, XrefRangeEnd = 639486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x2.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001B5D RID: 7005 RVA: 0x00002732 File Offset: 0x00000932
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<int3x2>.NativeClassPtr, ref this));
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x06001B5E RID: 7006 RVA: 0x0008F664 File Offset: 0x0008D864
		// (set) Token: 0x06001B5F RID: 7007 RVA: 0x00002744 File Offset: 0x00000944
		public unsafe static int3x2 zero
		{
			get
			{
				int3x2 int3x;
				IL2CPP.il2cpp_field_static_get_value(int3x2.NativeFieldInfoPtr_zero, (void*)(&int3x));
				return int3x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(int3x2.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x04001B7B RID: 7035
		private static readonly IntPtr NativeFieldInfoPtr_c0;

		// Token: 0x04001B7C RID: 7036
		private static readonly IntPtr NativeFieldInfoPtr_c1;

		// Token: 0x04001B7D RID: 7037
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x04001B7E RID: 7038
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int3_int3_0;

		// Token: 0x04001B7F RID: 7039
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x04001B80 RID: 7040
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001B81 RID: 7041
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04001B82 RID: 7042
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool3x2_0;

		// Token: 0x04001B83 RID: 7043
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04001B84 RID: 7044
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint3x2_0;

		// Token: 0x04001B85 RID: 7045
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x04001B86 RID: 7046
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float3x2_0;

		// Token: 0x04001B87 RID: 7047
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x04001B88 RID: 7048
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double3x2_0;

		// Token: 0x04001B89 RID: 7049
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_int3x2_Int32_0;

		// Token: 0x04001B8A RID: 7050
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int3x2_Boolean_0;

		// Token: 0x04001B8B RID: 7051
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int3x2_bool3x2_0;

		// Token: 0x04001B8C RID: 7052
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int3x2_UInt32_0;

		// Token: 0x04001B8D RID: 7053
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int3x2_uint3x2_0;

		// Token: 0x04001B8E RID: 7054
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int3x2_Single_0;

		// Token: 0x04001B8F RID: 7055
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int3x2_float3x2_0;

		// Token: 0x04001B90 RID: 7056
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int3x2_Double_0;

		// Token: 0x04001B91 RID: 7057
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int3x2_double3x2_0;

		// Token: 0x04001B92 RID: 7058
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_int3x2_int3x2_int3x2_0;

		// Token: 0x04001B93 RID: 7059
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_int3x2_int3x2_Int32_0;

		// Token: 0x04001B94 RID: 7060
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_int3x2_Int32_int3x2_0;

		// Token: 0x04001B95 RID: 7061
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_int3x2_int3x2_int3x2_0;

		// Token: 0x04001B96 RID: 7062
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_int3x2_int3x2_Int32_0;

		// Token: 0x04001B97 RID: 7063
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_int3x2_Int32_int3x2_0;

		// Token: 0x04001B98 RID: 7064
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_int3x2_int3x2_int3x2_0;

		// Token: 0x04001B99 RID: 7065
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_int3x2_int3x2_Int32_0;

		// Token: 0x04001B9A RID: 7066
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_int3x2_Int32_int3x2_0;

		// Token: 0x04001B9B RID: 7067
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_int3x2_int3x2_int3x2_0;

		// Token: 0x04001B9C RID: 7068
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_int3x2_int3x2_Int32_0;

		// Token: 0x04001B9D RID: 7069
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_int3x2_Int32_int3x2_0;

		// Token: 0x04001B9E RID: 7070
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_int3x2_int3x2_int3x2_0;

		// Token: 0x04001B9F RID: 7071
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_int3x2_int3x2_Int32_0;

		// Token: 0x04001BA0 RID: 7072
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_int3x2_Int32_int3x2_0;

		// Token: 0x04001BA1 RID: 7073
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_int3x2_int3x2_0;

		// Token: 0x04001BA2 RID: 7074
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_int3x2_int3x2_0;

		// Token: 0x04001BA3 RID: 7075
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x2_int3x2_int3x2_0;

		// Token: 0x04001BA4 RID: 7076
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x2_int3x2_Int32_0;

		// Token: 0x04001BA5 RID: 7077
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x2_Int32_int3x2_0;

		// Token: 0x04001BA6 RID: 7078
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x2_int3x2_int3x2_0;

		// Token: 0x04001BA7 RID: 7079
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x2_int3x2_Int32_0;

		// Token: 0x04001BA8 RID: 7080
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x2_Int32_int3x2_0;

		// Token: 0x04001BA9 RID: 7081
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x2_int3x2_int3x2_0;

		// Token: 0x04001BAA RID: 7082
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x2_int3x2_Int32_0;

		// Token: 0x04001BAB RID: 7083
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x2_Int32_int3x2_0;

		// Token: 0x04001BAC RID: 7084
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x2_int3x2_int3x2_0;

		// Token: 0x04001BAD RID: 7085
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x2_int3x2_Int32_0;

		// Token: 0x04001BAE RID: 7086
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x2_Int32_int3x2_0;

		// Token: 0x04001BAF RID: 7087
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_int3x2_int3x2_0;

		// Token: 0x04001BB0 RID: 7088
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryPlus_Public_Static_int3x2_int3x2_0;

		// Token: 0x04001BB1 RID: 7089
		private static readonly IntPtr NativeMethodInfoPtr_op_LeftShift_Public_Static_int3x2_int3x2_Int32_0;

		// Token: 0x04001BB2 RID: 7090
		private static readonly IntPtr NativeMethodInfoPtr_op_RightShift_Public_Static_int3x2_int3x2_Int32_0;

		// Token: 0x04001BB3 RID: 7091
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3x2_int3x2_int3x2_0;

		// Token: 0x04001BB4 RID: 7092
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3x2_int3x2_Int32_0;

		// Token: 0x04001BB5 RID: 7093
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3x2_Int32_int3x2_0;

		// Token: 0x04001BB6 RID: 7094
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x2_int3x2_int3x2_0;

		// Token: 0x04001BB7 RID: 7095
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x2_int3x2_Int32_0;

		// Token: 0x04001BB8 RID: 7096
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x2_Int32_int3x2_0;

		// Token: 0x04001BB9 RID: 7097
		private static readonly IntPtr NativeMethodInfoPtr_op_OnesComplement_Public_Static_int3x2_int3x2_0;

		// Token: 0x04001BBA RID: 7098
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int3x2_int3x2_int3x2_0;

		// Token: 0x04001BBB RID: 7099
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int3x2_int3x2_Int32_0;

		// Token: 0x04001BBC RID: 7100
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int3x2_Int32_int3x2_0;

		// Token: 0x04001BBD RID: 7101
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int3x2_int3x2_int3x2_0;

		// Token: 0x04001BBE RID: 7102
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int3x2_int3x2_Int32_0;

		// Token: 0x04001BBF RID: 7103
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int3x2_Int32_int3x2_0;

		// Token: 0x04001BC0 RID: 7104
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int3x2_int3x2_int3x2_0;

		// Token: 0x04001BC1 RID: 7105
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int3x2_int3x2_Int32_0;

		// Token: 0x04001BC2 RID: 7106
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int3x2_Int32_int3x2_0;

		// Token: 0x04001BC3 RID: 7107
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_int3_Int32_0;

		// Token: 0x04001BC4 RID: 7108
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_int3x2_0;

		// Token: 0x04001BC5 RID: 7109
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001BC6 RID: 7110
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001BC7 RID: 7111
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001BC8 RID: 7112
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04001BC9 RID: 7113
		[FieldOffset(0)]
		public int3 c0;

		// Token: 0x04001BCA RID: 7114
		[FieldOffset(12)]
		public int3 c1;
	}
}
