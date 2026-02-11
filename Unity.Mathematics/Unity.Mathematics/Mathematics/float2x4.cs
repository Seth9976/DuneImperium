using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x02000020 RID: 32
	[Serializable]
	[StructLayout(2)]
	public struct float2x4
	{
		// Token: 0x06001184 RID: 4484 RVA: 0x0005FA10 File Offset: 0x0005DC10
		// Note: this type is marked as 'beforefieldinit'.
		static float2x4()
		{
			Il2CppClassPointerStore<float2x4>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "float2x4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<float2x4>.NativeClassPtr);
			float2x4.NativeFieldInfoPtr_c0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float2x4>.NativeClassPtr, "c0");
			float2x4.NativeFieldInfoPtr_c1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float2x4>.NativeClassPtr, "c1");
			float2x4.NativeFieldInfoPtr_c2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float2x4>.NativeClassPtr, "c2");
			float2x4.NativeFieldInfoPtr_c3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float2x4>.NativeClassPtr, "c3");
			float2x4.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float2x4>.NativeClassPtr, "zero");
			float2x4.NativeMethodInfoPtr__ctor_Public_Void_float2_float2_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667649);
			float2x4.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667650);
			float2x4.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667651);
			float2x4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667652);
			float2x4.NativeMethodInfoPtr__ctor_Public_Void_bool2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667653);
			float2x4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667654);
			float2x4.NativeMethodInfoPtr__ctor_Public_Void_int2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667655);
			float2x4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667656);
			float2x4.NativeMethodInfoPtr__ctor_Public_Void_uint2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667657);
			float2x4.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667658);
			float2x4.NativeMethodInfoPtr__ctor_Public_Void_double2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667659);
			float2x4.NativeMethodInfoPtr_op_Implicit_Public_Static_float2x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667660);
			float2x4.NativeMethodInfoPtr_op_Explicit_Public_Static_float2x4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667661);
			float2x4.NativeMethodInfoPtr_op_Explicit_Public_Static_float2x4_bool2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667662);
			float2x4.NativeMethodInfoPtr_op_Implicit_Public_Static_float2x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667663);
			float2x4.NativeMethodInfoPtr_op_Implicit_Public_Static_float2x4_int2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667664);
			float2x4.NativeMethodInfoPtr_op_Implicit_Public_Static_float2x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667665);
			float2x4.NativeMethodInfoPtr_op_Implicit_Public_Static_float2x4_uint2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667666);
			float2x4.NativeMethodInfoPtr_op_Explicit_Public_Static_float2x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667667);
			float2x4.NativeMethodInfoPtr_op_Explicit_Public_Static_float2x4_double2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667668);
			float2x4.NativeMethodInfoPtr_op_Multiply_Public_Static_float2x4_float2x4_float2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667669);
			float2x4.NativeMethodInfoPtr_op_Multiply_Public_Static_float2x4_float2x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667670);
			float2x4.NativeMethodInfoPtr_op_Multiply_Public_Static_float2x4_Single_float2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667671);
			float2x4.NativeMethodInfoPtr_op_Addition_Public_Static_float2x4_float2x4_float2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667672);
			float2x4.NativeMethodInfoPtr_op_Addition_Public_Static_float2x4_float2x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667673);
			float2x4.NativeMethodInfoPtr_op_Addition_Public_Static_float2x4_Single_float2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667674);
			float2x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_float2x4_float2x4_float2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667675);
			float2x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_float2x4_float2x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667676);
			float2x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_float2x4_Single_float2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667677);
			float2x4.NativeMethodInfoPtr_op_Division_Public_Static_float2x4_float2x4_float2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667678);
			float2x4.NativeMethodInfoPtr_op_Division_Public_Static_float2x4_float2x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667679);
			float2x4.NativeMethodInfoPtr_op_Division_Public_Static_float2x4_Single_float2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667680);
			float2x4.NativeMethodInfoPtr_op_Modulus_Public_Static_float2x4_float2x4_float2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667681);
			float2x4.NativeMethodInfoPtr_op_Modulus_Public_Static_float2x4_float2x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667682);
			float2x4.NativeMethodInfoPtr_op_Modulus_Public_Static_float2x4_Single_float2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667683);
			float2x4.NativeMethodInfoPtr_op_Increment_Public_Static_float2x4_float2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667684);
			float2x4.NativeMethodInfoPtr_op_Decrement_Public_Static_float2x4_float2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667685);
			float2x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x4_float2x4_float2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667686);
			float2x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x4_float2x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667687);
			float2x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x4_Single_float2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667688);
			float2x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x4_float2x4_float2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667689);
			float2x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x4_float2x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667690);
			float2x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x4_Single_float2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667691);
			float2x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x4_float2x4_float2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667692);
			float2x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x4_float2x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667693);
			float2x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x4_Single_float2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667694);
			float2x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x4_float2x4_float2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667695);
			float2x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x4_float2x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667696);
			float2x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x4_Single_float2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667697);
			float2x4.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_float2x4_float2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667698);
			float2x4.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_float2x4_float2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667699);
			float2x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_float2x4_float2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667700);
			float2x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_float2x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667701);
			float2x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_Single_float2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667702);
			float2x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_float2x4_float2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667703);
			float2x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_float2x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667704);
			float2x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_Single_float2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667705);
			float2x4.NativeMethodInfoPtr_get_Item_Public_get_byref_float2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667706);
			float2x4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_float2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667707);
			float2x4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667708);
			float2x4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667709);
			float2x4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667710);
			float2x4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x4>.NativeClassPtr, 100667711);
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x0005FF90 File Offset: 0x0005E190
		[CallerCount(0)]
		public unsafe float2x4(float2 c0, float2 c1, float2 c2, float2 c3)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr__ctor_Public_Void_float2_float2_float2_float2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001186 RID: 4486 RVA: 0x0005FFEC File Offset: 0x0005E1EC
		[CallerCount(0)]
		public unsafe float2x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref m00;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m01;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m02;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m03;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m10;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m11;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m12;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m13;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001187 RID: 4487 RVA: 0x00060080 File Offset: 0x0005E280
		[CallerCount(0)]
		public unsafe float2x4(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x000600B4 File Offset: 0x0005E2B4
		[CallerCount(0)]
		public unsafe float2x4(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x000600E8 File Offset: 0x0005E2E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 636983, RefRangeEnd = 636984, XrefRangeStart = 636976, XrefRangeEnd = 636983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float2x4(bool2x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr__ctor_Public_Void_bool2x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x0006011C File Offset: 0x0005E31C
		[CallerCount(0)]
		public unsafe float2x4(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x00060150 File Offset: 0x0005E350
		[CallerCount(0)]
		public unsafe float2x4(int2x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr__ctor_Public_Void_int2x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x00060184 File Offset: 0x0005E384
		[CallerCount(0)]
		public unsafe float2x4(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600118D RID: 4493 RVA: 0x000601B8 File Offset: 0x0005E3B8
		[CallerCount(0)]
		public unsafe float2x4(uint2x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr__ctor_Public_Void_uint2x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x000601EC File Offset: 0x0005E3EC
		[CallerCount(0)]
		public unsafe float2x4(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600118F RID: 4495 RVA: 0x00060220 File Offset: 0x0005E420
		[CallerCount(0)]
		public unsafe float2x4(double2x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr__ctor_Public_Void_double2x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x00060254 File Offset: 0x0005E454
		[CallerCount(0)]
		public unsafe static implicit operator float2x4(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_Implicit_Public_Static_float2x4_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x00060294 File Offset: 0x0005E494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator float2x4(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_Explicit_Public_Static_float2x4_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x000602D4 File Offset: 0x0005E4D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636984, XrefRangeEnd = 636985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator float2x4(bool2x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_Explicit_Public_Static_float2x4_bool2x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001193 RID: 4499 RVA: 0x00060314 File Offset: 0x0005E514
		[CallerCount(0)]
		public unsafe static implicit operator float2x4(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_Implicit_Public_Static_float2x4_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001194 RID: 4500 RVA: 0x00060354 File Offset: 0x0005E554
		[CallerCount(0)]
		public unsafe static implicit operator float2x4(int2x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_Implicit_Public_Static_float2x4_int2x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001195 RID: 4501 RVA: 0x00060394 File Offset: 0x0005E594
		[CallerCount(0)]
		public unsafe static implicit operator float2x4(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_Implicit_Public_Static_float2x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x000603D4 File Offset: 0x0005E5D4
		[CallerCount(0)]
		public unsafe static implicit operator float2x4(uint2x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_Implicit_Public_Static_float2x4_uint2x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x00060414 File Offset: 0x0005E614
		[CallerCount(0)]
		public unsafe static explicit operator float2x4(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_Explicit_Public_Static_float2x4_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x00060454 File Offset: 0x0005E654
		[CallerCount(0)]
		public unsafe static explicit operator float2x4(double2x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_Explicit_Public_Static_float2x4_double2x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001199 RID: 4505 RVA: 0x00060494 File Offset: 0x0005E694
		[CallerCount(0)]
		public unsafe static float2x4 operator *(float2x4 lhs, float2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_Multiply_Public_Static_float2x4_float2x4_float2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600119A RID: 4506 RVA: 0x000604E0 File Offset: 0x0005E6E0
		[CallerCount(0)]
		public unsafe static float2x4 operator *(float2x4 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_Multiply_Public_Static_float2x4_float2x4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x0006052C File Offset: 0x0005E72C
		[CallerCount(0)]
		public unsafe static float2x4 operator *(float lhs, float2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_Multiply_Public_Static_float2x4_Single_float2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x00060578 File Offset: 0x0005E778
		[CallerCount(0)]
		public unsafe static float2x4 operator +(float2x4 lhs, float2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_Addition_Public_Static_float2x4_float2x4_float2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x000605C4 File Offset: 0x0005E7C4
		[CallerCount(0)]
		public unsafe static float2x4 operator +(float2x4 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_Addition_Public_Static_float2x4_float2x4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x00060610 File Offset: 0x0005E810
		[CallerCount(0)]
		public unsafe static float2x4 operator +(float lhs, float2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_Addition_Public_Static_float2x4_Single_float2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x0006065C File Offset: 0x0005E85C
		[CallerCount(0)]
		public unsafe static float2x4 operator -(float2x4 lhs, float2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_float2x4_float2x4_float2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x000606A8 File Offset: 0x0005E8A8
		[CallerCount(0)]
		public unsafe static float2x4 operator -(float2x4 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_float2x4_float2x4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x000606F4 File Offset: 0x0005E8F4
		[CallerCount(0)]
		public unsafe static float2x4 operator -(float lhs, float2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_float2x4_Single_float2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x00060740 File Offset: 0x0005E940
		[CallerCount(0)]
		public unsafe static float2x4 operator /(float2x4 lhs, float2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_Division_Public_Static_float2x4_float2x4_float2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011A3 RID: 4515 RVA: 0x0006078C File Offset: 0x0005E98C
		[CallerCount(0)]
		public unsafe static float2x4 operator /(float2x4 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_Division_Public_Static_float2x4_float2x4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x000607D8 File Offset: 0x0005E9D8
		[CallerCount(0)]
		public unsafe static float2x4 operator /(float lhs, float2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_Division_Public_Static_float2x4_Single_float2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x00060824 File Offset: 0x0005EA24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636985, XrefRangeEnd = 636993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float2x4 operator %(float2x4 lhs, float2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_Modulus_Public_Static_float2x4_float2x4_float2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011A6 RID: 4518 RVA: 0x00060870 File Offset: 0x0005EA70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636993, XrefRangeEnd = 637001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float2x4 operator %(float2x4 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_Modulus_Public_Static_float2x4_float2x4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011A7 RID: 4519 RVA: 0x000608BC File Offset: 0x0005EABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637001, XrefRangeEnd = 637009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float2x4 operator %(float lhs, float2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_Modulus_Public_Static_float2x4_Single_float2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x00060908 File Offset: 0x0005EB08
		[CallerCount(0)]
		public unsafe static float2x4 operator ++(float2x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_Increment_Public_Static_float2x4_float2x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x00060948 File Offset: 0x0005EB48
		[CallerCount(0)]
		public unsafe static float2x4 operator --(float2x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_Decrement_Public_Static_float2x4_float2x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x00060988 File Offset: 0x0005EB88
		[CallerCount(0)]
		public unsafe static bool2x4 operator <(float2x4 lhs, float2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x4_float2x4_float2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011AB RID: 4523 RVA: 0x000609D4 File Offset: 0x0005EBD4
		[CallerCount(0)]
		public unsafe static bool2x4 operator <(float2x4 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x4_float2x4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x00060A20 File Offset: 0x0005EC20
		[CallerCount(0)]
		public unsafe static bool2x4 operator <(float lhs, float2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x4_Single_float2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x00060A6C File Offset: 0x0005EC6C
		[CallerCount(0)]
		public unsafe static bool2x4 operator <=(float2x4 lhs, float2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x4_float2x4_float2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x00060AB8 File Offset: 0x0005ECB8
		[CallerCount(0)]
		public unsafe static bool2x4 operator <=(float2x4 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x4_float2x4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x00060B04 File Offset: 0x0005ED04
		[CallerCount(0)]
		public unsafe static bool2x4 operator <=(float lhs, float2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x4_Single_float2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x00060B50 File Offset: 0x0005ED50
		[CallerCount(0)]
		public unsafe static bool2x4 operator >(float2x4 lhs, float2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x4_float2x4_float2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x00060B9C File Offset: 0x0005ED9C
		[CallerCount(0)]
		public unsafe static bool2x4 operator >(float2x4 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x4_float2x4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x00060BE8 File Offset: 0x0005EDE8
		[CallerCount(0)]
		public unsafe static bool2x4 operator >(float lhs, float2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x4_Single_float2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x00060C34 File Offset: 0x0005EE34
		[CallerCount(0)]
		public unsafe static bool2x4 operator >=(float2x4 lhs, float2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x4_float2x4_float2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x00060C80 File Offset: 0x0005EE80
		[CallerCount(0)]
		public unsafe static bool2x4 operator >=(float2x4 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x4_float2x4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011B5 RID: 4533 RVA: 0x00060CCC File Offset: 0x0005EECC
		[CallerCount(0)]
		public unsafe static bool2x4 operator >=(float lhs, float2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x4_Single_float2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x00060D18 File Offset: 0x0005EF18
		[CallerCount(0)]
		public unsafe static float2x4 operator -(float2x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_float2x4_float2x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x00060D58 File Offset: 0x0005EF58
		[CallerCount(0)]
		public unsafe static float2x4 operator +(float2x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_float2x4_float2x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x00060D98 File Offset: 0x0005EF98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637009, XrefRangeEnd = 637017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool2x4 operator ==(float2x4 lhs, float2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_float2x4_float2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x00060DE4 File Offset: 0x0005EFE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637017, XrefRangeEnd = 637025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool2x4 operator ==(float2x4 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_float2x4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x00060E30 File Offset: 0x0005F030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637025, XrefRangeEnd = 637032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool2x4 operator ==(float lhs, float2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_Single_float2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x00060E7C File Offset: 0x0005F07C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637032, XrefRangeEnd = 637040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool2x4 operator !=(float2x4 lhs, float2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_float2x4_float2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x00060EC8 File Offset: 0x0005F0C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637040, XrefRangeEnd = 637048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool2x4 operator !=(float2x4 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_float2x4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011BD RID: 4541 RVA: 0x00060F14 File Offset: 0x0005F114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637048, XrefRangeEnd = 637055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool2x4 operator !=(float lhs, float2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_Single_float2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000424 RID: 1060
		public unsafe ref float2 this[int index]
		{
			[CallerCount(0)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_get_Item_Public_get_byref_float2_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x060011BF RID: 4543 RVA: 0x00060F94 File Offset: 0x0005F194
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 637055, RefRangeEnd = 637056, XrefRangeStart = 637055, XrefRangeEnd = 637055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(float2x4 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_float2x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x00060FD4 File Offset: 0x0005F1D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637056, XrefRangeEnd = 637060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x00061018 File Offset: 0x0005F218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637060, XrefRangeEnd = 637061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x00061048 File Offset: 0x0005F248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637061, XrefRangeEnd = 637100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x00061074 File Offset: 0x0005F274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637100, XrefRangeEnd = 637148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x000024C8 File Offset: 0x000006C8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<float2x4>.NativeClassPtr, ref this));
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x060011C5 RID: 4549 RVA: 0x000610C4 File Offset: 0x0005F2C4
		// (set) Token: 0x060011C6 RID: 4550 RVA: 0x000024DA File Offset: 0x000006DA
		public unsafe static float2x4 zero
		{
			get
			{
				float2x4 float2x;
				IL2CPP.il2cpp_field_static_get_value(float2x4.NativeFieldInfoPtr_zero, (void*)(&float2x));
				return float2x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(float2x4.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x040011BD RID: 4541
		private static readonly IntPtr NativeFieldInfoPtr_c0;

		// Token: 0x040011BE RID: 4542
		private static readonly IntPtr NativeFieldInfoPtr_c1;

		// Token: 0x040011BF RID: 4543
		private static readonly IntPtr NativeFieldInfoPtr_c2;

		// Token: 0x040011C0 RID: 4544
		private static readonly IntPtr NativeFieldInfoPtr_c3;

		// Token: 0x040011C1 RID: 4545
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x040011C2 RID: 4546
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float2_float2_float2_float2_0;

		// Token: 0x040011C3 RID: 4547
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_Single_Single_0;

		// Token: 0x040011C4 RID: 4548
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x040011C5 RID: 4549
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x040011C6 RID: 4550
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool2x4_0;

		// Token: 0x040011C7 RID: 4551
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040011C8 RID: 4552
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int2x4_0;

		// Token: 0x040011C9 RID: 4553
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x040011CA RID: 4554
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint2x4_0;

		// Token: 0x040011CB RID: 4555
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x040011CC RID: 4556
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double2x4_0;

		// Token: 0x040011CD RID: 4557
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float2x4_Single_0;

		// Token: 0x040011CE RID: 4558
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_float2x4_Boolean_0;

		// Token: 0x040011CF RID: 4559
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_float2x4_bool2x4_0;

		// Token: 0x040011D0 RID: 4560
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float2x4_Int32_0;

		// Token: 0x040011D1 RID: 4561
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float2x4_int2x4_0;

		// Token: 0x040011D2 RID: 4562
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float2x4_UInt32_0;

		// Token: 0x040011D3 RID: 4563
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float2x4_uint2x4_0;

		// Token: 0x040011D4 RID: 4564
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_float2x4_Double_0;

		// Token: 0x040011D5 RID: 4565
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_float2x4_double2x4_0;

		// Token: 0x040011D6 RID: 4566
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_float2x4_float2x4_float2x4_0;

		// Token: 0x040011D7 RID: 4567
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_float2x4_float2x4_Single_0;

		// Token: 0x040011D8 RID: 4568
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_float2x4_Single_float2x4_0;

		// Token: 0x040011D9 RID: 4569
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_float2x4_float2x4_float2x4_0;

		// Token: 0x040011DA RID: 4570
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_float2x4_float2x4_Single_0;

		// Token: 0x040011DB RID: 4571
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_float2x4_Single_float2x4_0;

		// Token: 0x040011DC RID: 4572
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_float2x4_float2x4_float2x4_0;

		// Token: 0x040011DD RID: 4573
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_float2x4_float2x4_Single_0;

		// Token: 0x040011DE RID: 4574
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_float2x4_Single_float2x4_0;

		// Token: 0x040011DF RID: 4575
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_float2x4_float2x4_float2x4_0;

		// Token: 0x040011E0 RID: 4576
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_float2x4_float2x4_Single_0;

		// Token: 0x040011E1 RID: 4577
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_float2x4_Single_float2x4_0;

		// Token: 0x040011E2 RID: 4578
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_float2x4_float2x4_float2x4_0;

		// Token: 0x040011E3 RID: 4579
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_float2x4_float2x4_Single_0;

		// Token: 0x040011E4 RID: 4580
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_float2x4_Single_float2x4_0;

		// Token: 0x040011E5 RID: 4581
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_float2x4_float2x4_0;

		// Token: 0x040011E6 RID: 4582
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_float2x4_float2x4_0;

		// Token: 0x040011E7 RID: 4583
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x4_float2x4_float2x4_0;

		// Token: 0x040011E8 RID: 4584
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x4_float2x4_Single_0;

		// Token: 0x040011E9 RID: 4585
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x4_Single_float2x4_0;

		// Token: 0x040011EA RID: 4586
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x4_float2x4_float2x4_0;

		// Token: 0x040011EB RID: 4587
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x4_float2x4_Single_0;

		// Token: 0x040011EC RID: 4588
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x4_Single_float2x4_0;

		// Token: 0x040011ED RID: 4589
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x4_float2x4_float2x4_0;

		// Token: 0x040011EE RID: 4590
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x4_float2x4_Single_0;

		// Token: 0x040011EF RID: 4591
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x4_Single_float2x4_0;

		// Token: 0x040011F0 RID: 4592
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x4_float2x4_float2x4_0;

		// Token: 0x040011F1 RID: 4593
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x4_float2x4_Single_0;

		// Token: 0x040011F2 RID: 4594
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x4_Single_float2x4_0;

		// Token: 0x040011F3 RID: 4595
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_float2x4_float2x4_0;

		// Token: 0x040011F4 RID: 4596
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryPlus_Public_Static_float2x4_float2x4_0;

		// Token: 0x040011F5 RID: 4597
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_float2x4_float2x4_0;

		// Token: 0x040011F6 RID: 4598
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_float2x4_Single_0;

		// Token: 0x040011F7 RID: 4599
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_Single_float2x4_0;

		// Token: 0x040011F8 RID: 4600
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_float2x4_float2x4_0;

		// Token: 0x040011F9 RID: 4601
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_float2x4_Single_0;

		// Token: 0x040011FA RID: 4602
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_Single_float2x4_0;

		// Token: 0x040011FB RID: 4603
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_float2_Int32_0;

		// Token: 0x040011FC RID: 4604
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_float2x4_0;

		// Token: 0x040011FD RID: 4605
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040011FE RID: 4606
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040011FF RID: 4607
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001200 RID: 4608
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04001201 RID: 4609
		[FieldOffset(0)]
		public float2 c0;

		// Token: 0x04001202 RID: 4610
		[FieldOffset(8)]
		public float2 c1;

		// Token: 0x04001203 RID: 4611
		[FieldOffset(16)]
		public float2 c2;

		// Token: 0x04001204 RID: 4612
		[FieldOffset(24)]
		public float2 c3;
	}
}
