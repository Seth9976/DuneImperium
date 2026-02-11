using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x02000017 RID: 23
	[Serializable]
	[StructLayout(2)]
	public struct double3x3
	{
		// Token: 0x06000D63 RID: 3427 RVA: 0x0004B3F4 File Offset: 0x000495F4
		// Note: this type is marked as 'beforefieldinit'.
		static double3x3()
		{
			Il2CppClassPointerStore<double3x3>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "double3x3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<double3x3>.NativeClassPtr);
			double3x3.NativeFieldInfoPtr_c0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double3x3>.NativeClassPtr, "c0");
			double3x3.NativeFieldInfoPtr_c1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double3x3>.NativeClassPtr, "c1");
			double3x3.NativeFieldInfoPtr_c2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double3x3>.NativeClassPtr, "c2");
			double3x3.NativeFieldInfoPtr_identity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double3x3>.NativeClassPtr, "identity");
			double3x3.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double3x3>.NativeClassPtr, "zero");
			double3x3.NativeMethodInfoPtr__ctor_Public_Void_double3_double3_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666629);
			double3x3.NativeMethodInfoPtr__ctor_Public_Void_Double_Double_Double_Double_Double_Double_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666630);
			double3x3.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666631);
			double3x3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666632);
			double3x3.NativeMethodInfoPtr__ctor_Public_Void_bool3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666633);
			double3x3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666634);
			double3x3.NativeMethodInfoPtr__ctor_Public_Void_int3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666635);
			double3x3.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666636);
			double3x3.NativeMethodInfoPtr__ctor_Public_Void_uint3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666637);
			double3x3.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666638);
			double3x3.NativeMethodInfoPtr__ctor_Public_Void_float3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666639);
			double3x3.NativeMethodInfoPtr_op_Implicit_Public_Static_double3x3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666640);
			double3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_double3x3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666641);
			double3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_double3x3_bool3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666642);
			double3x3.NativeMethodInfoPtr_op_Implicit_Public_Static_double3x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666643);
			double3x3.NativeMethodInfoPtr_op_Implicit_Public_Static_double3x3_int3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666644);
			double3x3.NativeMethodInfoPtr_op_Implicit_Public_Static_double3x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666645);
			double3x3.NativeMethodInfoPtr_op_Implicit_Public_Static_double3x3_uint3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666646);
			double3x3.NativeMethodInfoPtr_op_Implicit_Public_Static_double3x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666647);
			double3x3.NativeMethodInfoPtr_op_Implicit_Public_Static_double3x3_float3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666648);
			double3x3.NativeMethodInfoPtr_op_Multiply_Public_Static_double3x3_double3x3_double3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666649);
			double3x3.NativeMethodInfoPtr_op_Multiply_Public_Static_double3x3_double3x3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666650);
			double3x3.NativeMethodInfoPtr_op_Multiply_Public_Static_double3x3_Double_double3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666651);
			double3x3.NativeMethodInfoPtr_op_Addition_Public_Static_double3x3_double3x3_double3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666652);
			double3x3.NativeMethodInfoPtr_op_Addition_Public_Static_double3x3_double3x3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666653);
			double3x3.NativeMethodInfoPtr_op_Addition_Public_Static_double3x3_Double_double3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666654);
			double3x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_double3x3_double3x3_double3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666655);
			double3x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_double3x3_double3x3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666656);
			double3x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_double3x3_Double_double3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666657);
			double3x3.NativeMethodInfoPtr_op_Division_Public_Static_double3x3_double3x3_double3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666658);
			double3x3.NativeMethodInfoPtr_op_Division_Public_Static_double3x3_double3x3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666659);
			double3x3.NativeMethodInfoPtr_op_Division_Public_Static_double3x3_Double_double3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666660);
			double3x3.NativeMethodInfoPtr_op_Modulus_Public_Static_double3x3_double3x3_double3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666661);
			double3x3.NativeMethodInfoPtr_op_Modulus_Public_Static_double3x3_double3x3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666662);
			double3x3.NativeMethodInfoPtr_op_Modulus_Public_Static_double3x3_Double_double3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666663);
			double3x3.NativeMethodInfoPtr_op_Increment_Public_Static_double3x3_double3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666664);
			double3x3.NativeMethodInfoPtr_op_Decrement_Public_Static_double3x3_double3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666665);
			double3x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x3_double3x3_double3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666666);
			double3x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x3_double3x3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666667);
			double3x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x3_Double_double3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666668);
			double3x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x3_double3x3_double3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666669);
			double3x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x3_double3x3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666670);
			double3x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x3_Double_double3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666671);
			double3x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x3_double3x3_double3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666672);
			double3x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x3_double3x3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666673);
			double3x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x3_Double_double3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666674);
			double3x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x3_double3x3_double3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666675);
			double3x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x3_double3x3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666676);
			double3x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x3_Double_double3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666677);
			double3x3.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_double3x3_double3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666678);
			double3x3.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_double3x3_double3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666679);
			double3x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_double3x3_double3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666680);
			double3x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_double3x3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666681);
			double3x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_Double_double3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666682);
			double3x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_double3x3_double3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666683);
			double3x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_double3x3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666684);
			double3x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_Double_double3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666685);
			double3x3.NativeMethodInfoPtr_get_Item_Public_get_byref_double3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666686);
			double3x3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_double3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666687);
			double3x3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666688);
			double3x3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666689);
			double3x3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666690);
			double3x3.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x3>.NativeClassPtr, 100666691);
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x0004B974 File Offset: 0x00049B74
		[CallerCount(0)]
		public unsafe double3x3(double3 c0, double3 c1, double3 c2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr__ctor_Public_Void_double3_double3_double3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x0004B9C4 File Offset: 0x00049BC4
		[CallerCount(0)]
		public unsafe double3x3(double m00, double m01, double m02, double m10, double m11, double m12, double m20, double m21, double m22)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr__ctor_Public_Void_Double_Double_Double_Double_Double_Double_Double_Double_Double_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x0004BA68 File Offset: 0x00049C68
		[CallerCount(0)]
		public unsafe double3x3(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x0004BA9C File Offset: 0x00049C9C
		[CallerCount(0)]
		public unsafe double3x3(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x0004BAD0 File Offset: 0x00049CD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 635403, RefRangeEnd = 635404, XrefRangeStart = 635395, XrefRangeEnd = 635403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double3x3(bool3x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr__ctor_Public_Void_bool3x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x0004BB04 File Offset: 0x00049D04
		[CallerCount(0)]
		public unsafe double3x3(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x0004BB38 File Offset: 0x00049D38
		[CallerCount(0)]
		public unsafe double3x3(int3x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr__ctor_Public_Void_int3x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x0004BB6C File Offset: 0x00049D6C
		[CallerCount(0)]
		public unsafe double3x3(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x0004BBA0 File Offset: 0x00049DA0
		[CallerCount(0)]
		public unsafe double3x3(uint3x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr__ctor_Public_Void_uint3x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x0004BBD4 File Offset: 0x00049DD4
		[CallerCount(0)]
		public unsafe double3x3(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x0004BC08 File Offset: 0x00049E08
		[CallerCount(0)]
		public unsafe double3x3(float3x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr__ctor_Public_Void_float3x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x0004BC3C File Offset: 0x00049E3C
		[CallerCount(0)]
		public unsafe static implicit operator double3x3(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_Implicit_Public_Static_double3x3_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x0004BC7C File Offset: 0x00049E7C
		[CallerCount(0)]
		public unsafe static explicit operator double3x3(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_double3x3_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x0004BCBC File Offset: 0x00049EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635404, XrefRangeEnd = 635405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator double3x3(bool3x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_Explicit_Public_Static_double3x3_bool3x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x0004BCFC File Offset: 0x00049EFC
		[CallerCount(0)]
		public unsafe static implicit operator double3x3(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_Implicit_Public_Static_double3x3_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x0004BD3C File Offset: 0x00049F3C
		[CallerCount(0)]
		public unsafe static implicit operator double3x3(int3x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_Implicit_Public_Static_double3x3_int3x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x0004BD7C File Offset: 0x00049F7C
		[CallerCount(0)]
		public unsafe static implicit operator double3x3(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_Implicit_Public_Static_double3x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x0004BDBC File Offset: 0x00049FBC
		[CallerCount(0)]
		public unsafe static implicit operator double3x3(uint3x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_Implicit_Public_Static_double3x3_uint3x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x0004BDFC File Offset: 0x00049FFC
		[CallerCount(0)]
		public unsafe static implicit operator double3x3(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_Implicit_Public_Static_double3x3_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x0004BE3C File Offset: 0x0004A03C
		[CallerCount(0)]
		public unsafe static implicit operator double3x3(float3x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_Implicit_Public_Static_double3x3_float3x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x0004BE7C File Offset: 0x0004A07C
		[CallerCount(0)]
		public unsafe static double3x3 operator *(double3x3 lhs, double3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_Multiply_Public_Static_double3x3_double3x3_double3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x0004BEC8 File Offset: 0x0004A0C8
		[CallerCount(0)]
		public unsafe static double3x3 operator *(double3x3 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_Multiply_Public_Static_double3x3_double3x3_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x0004BF14 File Offset: 0x0004A114
		[CallerCount(0)]
		public unsafe static double3x3 operator *(double lhs, double3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_Multiply_Public_Static_double3x3_Double_double3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x0004BF60 File Offset: 0x0004A160
		[CallerCount(0)]
		public unsafe static double3x3 operator +(double3x3 lhs, double3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_Addition_Public_Static_double3x3_double3x3_double3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x0004BFAC File Offset: 0x0004A1AC
		[CallerCount(0)]
		public unsafe static double3x3 operator +(double3x3 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_Addition_Public_Static_double3x3_double3x3_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x0004BFF8 File Offset: 0x0004A1F8
		[CallerCount(0)]
		public unsafe static double3x3 operator +(double lhs, double3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_Addition_Public_Static_double3x3_Double_double3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x0004C044 File Offset: 0x0004A244
		[CallerCount(0)]
		public unsafe static double3x3 operator -(double3x3 lhs, double3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_double3x3_double3x3_double3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x0004C090 File Offset: 0x0004A290
		[CallerCount(0)]
		public unsafe static double3x3 operator -(double3x3 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_double3x3_double3x3_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x0004C0DC File Offset: 0x0004A2DC
		[CallerCount(0)]
		public unsafe static double3x3 operator -(double lhs, double3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_double3x3_Double_double3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x0004C128 File Offset: 0x0004A328
		[CallerCount(0)]
		public unsafe static double3x3 operator /(double3x3 lhs, double3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_Division_Public_Static_double3x3_double3x3_double3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x0004C174 File Offset: 0x0004A374
		[CallerCount(0)]
		public unsafe static double3x3 operator /(double3x3 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_Division_Public_Static_double3x3_double3x3_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x0004C1C0 File Offset: 0x0004A3C0
		[CallerCount(0)]
		public unsafe static double3x3 operator /(double lhs, double3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_Division_Public_Static_double3x3_Double_double3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x0004C20C File Offset: 0x0004A40C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635405, XrefRangeEnd = 635414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double3x3 operator %(double3x3 lhs, double3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_Modulus_Public_Static_double3x3_double3x3_double3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x0004C258 File Offset: 0x0004A458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635414, XrefRangeEnd = 635423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double3x3 operator %(double3x3 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_Modulus_Public_Static_double3x3_double3x3_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x0004C2A4 File Offset: 0x0004A4A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635423, XrefRangeEnd = 635432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double3x3 operator %(double lhs, double3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_Modulus_Public_Static_double3x3_Double_double3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x0004C2F0 File Offset: 0x0004A4F0
		[CallerCount(0)]
		public unsafe static double3x3 operator ++(double3x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_Increment_Public_Static_double3x3_double3x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x0004C330 File Offset: 0x0004A530
		[CallerCount(0)]
		public unsafe static double3x3 operator --(double3x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_Decrement_Public_Static_double3x3_double3x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x0004C370 File Offset: 0x0004A570
		[CallerCount(0)]
		public unsafe static bool3x3 operator <(double3x3 lhs, double3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x3_double3x3_double3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x0004C3BC File Offset: 0x0004A5BC
		[CallerCount(0)]
		public unsafe static bool3x3 operator <(double3x3 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x3_double3x3_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x0004C408 File Offset: 0x0004A608
		[CallerCount(0)]
		public unsafe static bool3x3 operator <(double lhs, double3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x3_Double_double3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x0004C454 File Offset: 0x0004A654
		[CallerCount(0)]
		public unsafe static bool3x3 operator <=(double3x3 lhs, double3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x3_double3x3_double3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x0004C4A0 File Offset: 0x0004A6A0
		[CallerCount(0)]
		public unsafe static bool3x3 operator <=(double3x3 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x3_double3x3_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x0004C4EC File Offset: 0x0004A6EC
		[CallerCount(0)]
		public unsafe static bool3x3 operator <=(double lhs, double3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x3_Double_double3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x0004C538 File Offset: 0x0004A738
		[CallerCount(0)]
		public unsafe static bool3x3 operator >(double3x3 lhs, double3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x3_double3x3_double3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x0004C584 File Offset: 0x0004A784
		[CallerCount(0)]
		public unsafe static bool3x3 operator >(double3x3 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x3_double3x3_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x0004C5D0 File Offset: 0x0004A7D0
		[CallerCount(0)]
		public unsafe static bool3x3 operator >(double lhs, double3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x3_Double_double3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x0004C61C File Offset: 0x0004A81C
		[CallerCount(0)]
		public unsafe static bool3x3 operator >=(double3x3 lhs, double3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x3_double3x3_double3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x0004C668 File Offset: 0x0004A868
		[CallerCount(0)]
		public unsafe static bool3x3 operator >=(double3x3 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x3_double3x3_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x0004C6B4 File Offset: 0x0004A8B4
		[CallerCount(0)]
		public unsafe static bool3x3 operator >=(double lhs, double3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x3_Double_double3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x0004C700 File Offset: 0x0004A900
		[CallerCount(0)]
		public unsafe static double3x3 operator -(double3x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_double3x3_double3x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x0004C740 File Offset: 0x0004A940
		[CallerCount(0)]
		public unsafe static double3x3 operator +(double3x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_double3x3_double3x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x0004C780 File Offset: 0x0004A980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635432, XrefRangeEnd = 635441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool3x3 operator ==(double3x3 lhs, double3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_double3x3_double3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x0004C7CC File Offset: 0x0004A9CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635441, XrefRangeEnd = 635450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool3x3 operator ==(double3x3 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_double3x3_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x0004C818 File Offset: 0x0004AA18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635450, XrefRangeEnd = 635459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool3x3 operator ==(double lhs, double3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_Double_double3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x0004C864 File Offset: 0x0004AA64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635459, XrefRangeEnd = 635468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool3x3 operator !=(double3x3 lhs, double3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_double3x3_double3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x0004C8B0 File Offset: 0x0004AAB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635468, XrefRangeEnd = 635477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool3x3 operator !=(double3x3 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_double3x3_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x0004C8FC File Offset: 0x0004AAFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635477, XrefRangeEnd = 635486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool3x3 operator !=(double lhs, double3x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_Double_double3x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170002A4 RID: 676
		public unsafe ref double3 this[int index]
		{
			[CallerCount(0)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_get_Item_Public_get_byref_double3_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x0004C97C File Offset: 0x0004AB7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 635486, RefRangeEnd = 635487, XrefRangeStart = 635486, XrefRangeEnd = 635486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(double3x3 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_double3x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x0004C9BC File Offset: 0x0004ABBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635487, XrefRangeEnd = 635491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x0004CA00 File Offset: 0x0004AC00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635491, XrefRangeEnd = 635492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x0004CA30 File Offset: 0x0004AC30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635492, XrefRangeEnd = 635535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x0004CA5C File Offset: 0x0004AC5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635535, XrefRangeEnd = 635590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x3.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x0000237E File Offset: 0x0000057E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<double3x3>.NativeClassPtr, ref this));
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000DA4 RID: 3492 RVA: 0x0004CAAC File Offset: 0x0004ACAC
		// (set) Token: 0x06000DA5 RID: 3493 RVA: 0x00002390 File Offset: 0x00000590
		public unsafe static double3x3 identity
		{
			get
			{
				double3x3 double3x;
				IL2CPP.il2cpp_field_static_get_value(double3x3.NativeFieldInfoPtr_identity, (void*)(&double3x));
				return double3x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(double3x3.NativeFieldInfoPtr_identity, (void*)(&value));
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000DA6 RID: 3494 RVA: 0x0004CAC8 File Offset: 0x0004ACC8
		// (set) Token: 0x06000DA7 RID: 3495 RVA: 0x0000239E File Offset: 0x0000059E
		public unsafe static double3x3 zero
		{
			get
			{
				double3x3 double3x;
				IL2CPP.il2cpp_field_static_get_value(double3x3.NativeFieldInfoPtr_zero, (void*)(&double3x));
				return double3x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(double3x3.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x04000D84 RID: 3460
		private static readonly IntPtr NativeFieldInfoPtr_c0;

		// Token: 0x04000D85 RID: 3461
		private static readonly IntPtr NativeFieldInfoPtr_c1;

		// Token: 0x04000D86 RID: 3462
		private static readonly IntPtr NativeFieldInfoPtr_c2;

		// Token: 0x04000D87 RID: 3463
		private static readonly IntPtr NativeFieldInfoPtr_identity;

		// Token: 0x04000D88 RID: 3464
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x04000D89 RID: 3465
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double3_double3_double3_0;

		// Token: 0x04000D8A RID: 3466
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_Double_Double_Double_Double_Double_Double_Double_Double_0;

		// Token: 0x04000D8B RID: 3467
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x04000D8C RID: 3468
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04000D8D RID: 3469
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool3x3_0;

		// Token: 0x04000D8E RID: 3470
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000D8F RID: 3471
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int3x3_0;

		// Token: 0x04000D90 RID: 3472
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04000D91 RID: 3473
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint3x3_0;

		// Token: 0x04000D92 RID: 3474
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x04000D93 RID: 3475
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float3x3_0;

		// Token: 0x04000D94 RID: 3476
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double3x3_Double_0;

		// Token: 0x04000D95 RID: 3477
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_double3x3_Boolean_0;

		// Token: 0x04000D96 RID: 3478
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_double3x3_bool3x3_0;

		// Token: 0x04000D97 RID: 3479
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double3x3_Int32_0;

		// Token: 0x04000D98 RID: 3480
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double3x3_int3x3_0;

		// Token: 0x04000D99 RID: 3481
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double3x3_UInt32_0;

		// Token: 0x04000D9A RID: 3482
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double3x3_uint3x3_0;

		// Token: 0x04000D9B RID: 3483
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double3x3_Single_0;

		// Token: 0x04000D9C RID: 3484
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double3x3_float3x3_0;

		// Token: 0x04000D9D RID: 3485
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_double3x3_double3x3_double3x3_0;

		// Token: 0x04000D9E RID: 3486
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_double3x3_double3x3_Double_0;

		// Token: 0x04000D9F RID: 3487
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_double3x3_Double_double3x3_0;

		// Token: 0x04000DA0 RID: 3488
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_double3x3_double3x3_double3x3_0;

		// Token: 0x04000DA1 RID: 3489
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_double3x3_double3x3_Double_0;

		// Token: 0x04000DA2 RID: 3490
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_double3x3_Double_double3x3_0;

		// Token: 0x04000DA3 RID: 3491
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_double3x3_double3x3_double3x3_0;

		// Token: 0x04000DA4 RID: 3492
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_double3x3_double3x3_Double_0;

		// Token: 0x04000DA5 RID: 3493
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_double3x3_Double_double3x3_0;

		// Token: 0x04000DA6 RID: 3494
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_double3x3_double3x3_double3x3_0;

		// Token: 0x04000DA7 RID: 3495
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_double3x3_double3x3_Double_0;

		// Token: 0x04000DA8 RID: 3496
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_double3x3_Double_double3x3_0;

		// Token: 0x04000DA9 RID: 3497
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_double3x3_double3x3_double3x3_0;

		// Token: 0x04000DAA RID: 3498
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_double3x3_double3x3_Double_0;

		// Token: 0x04000DAB RID: 3499
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_double3x3_Double_double3x3_0;

		// Token: 0x04000DAC RID: 3500
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_double3x3_double3x3_0;

		// Token: 0x04000DAD RID: 3501
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_double3x3_double3x3_0;

		// Token: 0x04000DAE RID: 3502
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x3_double3x3_double3x3_0;

		// Token: 0x04000DAF RID: 3503
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x3_double3x3_Double_0;

		// Token: 0x04000DB0 RID: 3504
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x3_Double_double3x3_0;

		// Token: 0x04000DB1 RID: 3505
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x3_double3x3_double3x3_0;

		// Token: 0x04000DB2 RID: 3506
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x3_double3x3_Double_0;

		// Token: 0x04000DB3 RID: 3507
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x3_Double_double3x3_0;

		// Token: 0x04000DB4 RID: 3508
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x3_double3x3_double3x3_0;

		// Token: 0x04000DB5 RID: 3509
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x3_double3x3_Double_0;

		// Token: 0x04000DB6 RID: 3510
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x3_Double_double3x3_0;

		// Token: 0x04000DB7 RID: 3511
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x3_double3x3_double3x3_0;

		// Token: 0x04000DB8 RID: 3512
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x3_double3x3_Double_0;

		// Token: 0x04000DB9 RID: 3513
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x3_Double_double3x3_0;

		// Token: 0x04000DBA RID: 3514
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_double3x3_double3x3_0;

		// Token: 0x04000DBB RID: 3515
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryPlus_Public_Static_double3x3_double3x3_0;

		// Token: 0x04000DBC RID: 3516
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_double3x3_double3x3_0;

		// Token: 0x04000DBD RID: 3517
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_double3x3_Double_0;

		// Token: 0x04000DBE RID: 3518
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3x3_Double_double3x3_0;

		// Token: 0x04000DBF RID: 3519
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_double3x3_double3x3_0;

		// Token: 0x04000DC0 RID: 3520
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_double3x3_Double_0;

		// Token: 0x04000DC1 RID: 3521
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x3_Double_double3x3_0;

		// Token: 0x04000DC2 RID: 3522
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_double3_Int32_0;

		// Token: 0x04000DC3 RID: 3523
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_double3x3_0;

		// Token: 0x04000DC4 RID: 3524
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000DC5 RID: 3525
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000DC6 RID: 3526
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000DC7 RID: 3527
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04000DC8 RID: 3528
		[FieldOffset(0)]
		public double3 c0;

		// Token: 0x04000DC9 RID: 3529
		[FieldOffset(24)]
		public double3 c1;

		// Token: 0x04000DCA RID: 3530
		[FieldOffset(48)]
		public double3 c2;
	}
}
