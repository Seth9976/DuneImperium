using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x0200001C RID: 28
	[Serializable]
	[StructLayout(2)]
	public struct double4x4
	{
		// Token: 0x0600104B RID: 4171 RVA: 0x000593B8 File Offset: 0x000575B8
		// Note: this type is marked as 'beforefieldinit'.
		static double4x4()
		{
			Il2CppClassPointerStore<double4x4>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "double4x4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<double4x4>.NativeClassPtr);
			double4x4.NativeFieldInfoPtr_c0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double4x4>.NativeClassPtr, "c0");
			double4x4.NativeFieldInfoPtr_c1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double4x4>.NativeClassPtr, "c1");
			double4x4.NativeFieldInfoPtr_c2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double4x4>.NativeClassPtr, "c2");
			double4x4.NativeFieldInfoPtr_c3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double4x4>.NativeClassPtr, "c3");
			double4x4.NativeFieldInfoPtr_identity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double4x4>.NativeClassPtr, "identity");
			double4x4.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double4x4>.NativeClassPtr, "zero");
			double4x4.NativeMethodInfoPtr__ctor_Public_Void_double4_double4_double4_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667353);
			double4x4.NativeMethodInfoPtr__ctor_Public_Void_Double_Double_Double_Double_Double_Double_Double_Double_Double_Double_Double_Double_Double_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667354);
			double4x4.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667355);
			double4x4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667356);
			double4x4.NativeMethodInfoPtr__ctor_Public_Void_bool4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667357);
			double4x4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667358);
			double4x4.NativeMethodInfoPtr__ctor_Public_Void_int4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667359);
			double4x4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667360);
			double4x4.NativeMethodInfoPtr__ctor_Public_Void_uint4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667361);
			double4x4.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667362);
			double4x4.NativeMethodInfoPtr__ctor_Public_Void_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667363);
			double4x4.NativeMethodInfoPtr_op_Implicit_Public_Static_double4x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667364);
			double4x4.NativeMethodInfoPtr_op_Explicit_Public_Static_double4x4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667365);
			double4x4.NativeMethodInfoPtr_op_Explicit_Public_Static_double4x4_bool4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667366);
			double4x4.NativeMethodInfoPtr_op_Implicit_Public_Static_double4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667367);
			double4x4.NativeMethodInfoPtr_op_Implicit_Public_Static_double4x4_int4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667368);
			double4x4.NativeMethodInfoPtr_op_Implicit_Public_Static_double4x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667369);
			double4x4.NativeMethodInfoPtr_op_Implicit_Public_Static_double4x4_uint4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667370);
			double4x4.NativeMethodInfoPtr_op_Implicit_Public_Static_double4x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667371);
			double4x4.NativeMethodInfoPtr_op_Implicit_Public_Static_double4x4_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667372);
			double4x4.NativeMethodInfoPtr_op_Multiply_Public_Static_double4x4_double4x4_double4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667373);
			double4x4.NativeMethodInfoPtr_op_Multiply_Public_Static_double4x4_double4x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667374);
			double4x4.NativeMethodInfoPtr_op_Multiply_Public_Static_double4x4_Double_double4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667375);
			double4x4.NativeMethodInfoPtr_op_Addition_Public_Static_double4x4_double4x4_double4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667376);
			double4x4.NativeMethodInfoPtr_op_Addition_Public_Static_double4x4_double4x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667377);
			double4x4.NativeMethodInfoPtr_op_Addition_Public_Static_double4x4_Double_double4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667378);
			double4x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_double4x4_double4x4_double4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667379);
			double4x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_double4x4_double4x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667380);
			double4x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_double4x4_Double_double4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667381);
			double4x4.NativeMethodInfoPtr_op_Division_Public_Static_double4x4_double4x4_double4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667382);
			double4x4.NativeMethodInfoPtr_op_Division_Public_Static_double4x4_double4x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667383);
			double4x4.NativeMethodInfoPtr_op_Division_Public_Static_double4x4_Double_double4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667384);
			double4x4.NativeMethodInfoPtr_op_Modulus_Public_Static_double4x4_double4x4_double4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667385);
			double4x4.NativeMethodInfoPtr_op_Modulus_Public_Static_double4x4_double4x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667386);
			double4x4.NativeMethodInfoPtr_op_Modulus_Public_Static_double4x4_Double_double4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667387);
			double4x4.NativeMethodInfoPtr_op_Increment_Public_Static_double4x4_double4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667388);
			double4x4.NativeMethodInfoPtr_op_Decrement_Public_Static_double4x4_double4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667389);
			double4x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x4_double4x4_double4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667390);
			double4x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x4_double4x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667391);
			double4x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x4_Double_double4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667392);
			double4x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x4_double4x4_double4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667393);
			double4x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x4_double4x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667394);
			double4x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x4_Double_double4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667395);
			double4x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x4_double4x4_double4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667396);
			double4x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x4_double4x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667397);
			double4x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x4_Double_double4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667398);
			double4x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x4_double4x4_double4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667399);
			double4x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x4_double4x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667400);
			double4x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x4_Double_double4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667401);
			double4x4.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_double4x4_double4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667402);
			double4x4.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_double4x4_double4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667403);
			double4x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_double4x4_double4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667404);
			double4x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_double4x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667405);
			double4x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_Double_double4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667406);
			double4x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_double4x4_double4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667407);
			double4x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_double4x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667408);
			double4x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_Double_double4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667409);
			double4x4.NativeMethodInfoPtr_get_Item_Public_get_byref_double4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667410);
			double4x4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_double4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667411);
			double4x4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667412);
			double4x4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667413);
			double4x4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667414);
			double4x4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x4>.NativeClassPtr, 100667415);
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x0005994C File Offset: 0x00057B4C
		[CallerCount(0)]
		public unsafe double4x4(double4 c0, double4 c1, double4 c2, double4 c3)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr__ctor_Public_Void_double4_double4_double4_double4_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x000599A8 File Offset: 0x00057BA8
		[CallerCount(0)]
		public unsafe double4x4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13, double m20, double m21, double m22, double m23, double m30, double m31, double m32, double m33)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr__ctor_Public_Void_Double_Double_Double_Double_Double_Double_Double_Double_Double_Double_Double_Double_Double_Double_Double_Double_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x00059AB4 File Offset: 0x00057CB4
		[CallerCount(0)]
		public unsafe double4x4(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x00059AE8 File Offset: 0x00057CE8
		[CallerCount(0)]
		public unsafe double4x4(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x00059B1C File Offset: 0x00057D1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 636374, RefRangeEnd = 636376, XrefRangeStart = 636358, XrefRangeEnd = 636374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double4x4(bool4x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr__ctor_Public_Void_bool4x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x00059B50 File Offset: 0x00057D50
		[CallerCount(0)]
		public unsafe double4x4(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x00059B84 File Offset: 0x00057D84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 636376, RefRangeEnd = 636377, XrefRangeStart = 636376, XrefRangeEnd = 636376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double4x4(int4x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr__ctor_Public_Void_int4x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x00059BB8 File Offset: 0x00057DB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 636377, RefRangeEnd = 636378, XrefRangeStart = 636377, XrefRangeEnd = 636377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double4x4(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x00059BEC File Offset: 0x00057DEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 636378, RefRangeEnd = 636379, XrefRangeStart = 636378, XrefRangeEnd = 636378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double4x4(uint4x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr__ctor_Public_Void_uint4x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x00059C20 File Offset: 0x00057E20
		[CallerCount(0)]
		public unsafe double4x4(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x00059C54 File Offset: 0x00057E54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 636379, RefRangeEnd = 636380, XrefRangeStart = 636379, XrefRangeEnd = 636379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double4x4(float4x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr__ctor_Public_Void_float4x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x00059C88 File Offset: 0x00057E88
		[CallerCount(0)]
		public unsafe static implicit operator double4x4(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_Implicit_Public_Static_double4x4_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x00059CC8 File Offset: 0x00057EC8
		[CallerCount(0)]
		public unsafe static explicit operator double4x4(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_Explicit_Public_Static_double4x4_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x00059D08 File Offset: 0x00057F08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator double4x4(bool4x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_Explicit_Public_Static_double4x4_bool4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x00059D48 File Offset: 0x00057F48
		[CallerCount(0)]
		public unsafe static implicit operator double4x4(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_Implicit_Public_Static_double4x4_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x00059D88 File Offset: 0x00057F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636380, XrefRangeEnd = 636381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator double4x4(int4x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_Implicit_Public_Static_double4x4_int4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x00059DC8 File Offset: 0x00057FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636381, XrefRangeEnd = 636382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator double4x4(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_Implicit_Public_Static_double4x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x00059E08 File Offset: 0x00058008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636382, XrefRangeEnd = 636383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator double4x4(uint4x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_Implicit_Public_Static_double4x4_uint4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x00059E48 File Offset: 0x00058048
		[CallerCount(0)]
		public unsafe static implicit operator double4x4(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_Implicit_Public_Static_double4x4_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x00059E88 File Offset: 0x00058088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636383, XrefRangeEnd = 636384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator double4x4(float4x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_Implicit_Public_Static_double4x4_float4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x00059EC8 File Offset: 0x000580C8
		[CallerCount(0)]
		public unsafe static double4x4 operator *(double4x4 lhs, double4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_Multiply_Public_Static_double4x4_double4x4_double4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x00059F14 File Offset: 0x00058114
		[CallerCount(0)]
		public unsafe static double4x4 operator *(double4x4 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_Multiply_Public_Static_double4x4_double4x4_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x00059F60 File Offset: 0x00058160
		[CallerCount(0)]
		public unsafe static double4x4 operator *(double lhs, double4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_Multiply_Public_Static_double4x4_Double_double4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x00059FAC File Offset: 0x000581AC
		[CallerCount(0)]
		public unsafe static double4x4 operator +(double4x4 lhs, double4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_Addition_Public_Static_double4x4_double4x4_double4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x00059FF8 File Offset: 0x000581F8
		[CallerCount(0)]
		public unsafe static double4x4 operator +(double4x4 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_Addition_Public_Static_double4x4_double4x4_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x0005A044 File Offset: 0x00058244
		[CallerCount(0)]
		public unsafe static double4x4 operator +(double lhs, double4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_Addition_Public_Static_double4x4_Double_double4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x0005A090 File Offset: 0x00058290
		[CallerCount(0)]
		public unsafe static double4x4 operator -(double4x4 lhs, double4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_double4x4_double4x4_double4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x0005A0DC File Offset: 0x000582DC
		[CallerCount(0)]
		public unsafe static double4x4 operator -(double4x4 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_double4x4_double4x4_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x0005A128 File Offset: 0x00058328
		[CallerCount(0)]
		public unsafe static double4x4 operator -(double lhs, double4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_double4x4_Double_double4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x0005A174 File Offset: 0x00058374
		[CallerCount(0)]
		public unsafe static double4x4 operator /(double4x4 lhs, double4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_Division_Public_Static_double4x4_double4x4_double4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x0005A1C0 File Offset: 0x000583C0
		[CallerCount(0)]
		public unsafe static double4x4 operator /(double4x4 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_Division_Public_Static_double4x4_double4x4_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x0005A20C File Offset: 0x0005840C
		[CallerCount(0)]
		public unsafe static double4x4 operator /(double lhs, double4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_Division_Public_Static_double4x4_Double_double4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x0005A258 File Offset: 0x00058458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636384, XrefRangeEnd = 636400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double4x4 operator %(double4x4 lhs, double4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_Modulus_Public_Static_double4x4_double4x4_double4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600106D RID: 4205 RVA: 0x0005A2A4 File Offset: 0x000584A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636400, XrefRangeEnd = 636416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double4x4 operator %(double4x4 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_Modulus_Public_Static_double4x4_double4x4_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600106E RID: 4206 RVA: 0x0005A2F0 File Offset: 0x000584F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636416, XrefRangeEnd = 636432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double4x4 operator %(double lhs, double4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_Modulus_Public_Static_double4x4_Double_double4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600106F RID: 4207 RVA: 0x0005A33C File Offset: 0x0005853C
		[CallerCount(0)]
		public unsafe static double4x4 operator ++(double4x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_Increment_Public_Static_double4x4_double4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x0005A37C File Offset: 0x0005857C
		[CallerCount(0)]
		public unsafe static double4x4 operator --(double4x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_Decrement_Public_Static_double4x4_double4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x0005A3BC File Offset: 0x000585BC
		[CallerCount(0)]
		public unsafe static bool4x4 operator <(double4x4 lhs, double4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x4_double4x4_double4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x0005A408 File Offset: 0x00058608
		[CallerCount(0)]
		public unsafe static bool4x4 operator <(double4x4 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x4_double4x4_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001073 RID: 4211 RVA: 0x0005A454 File Offset: 0x00058654
		[CallerCount(0)]
		public unsafe static bool4x4 operator <(double lhs, double4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x4_Double_double4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x0005A4A0 File Offset: 0x000586A0
		[CallerCount(0)]
		public unsafe static bool4x4 operator <=(double4x4 lhs, double4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x4_double4x4_double4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x0005A4EC File Offset: 0x000586EC
		[CallerCount(0)]
		public unsafe static bool4x4 operator <=(double4x4 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x4_double4x4_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001076 RID: 4214 RVA: 0x0005A538 File Offset: 0x00058738
		[CallerCount(0)]
		public unsafe static bool4x4 operator <=(double lhs, double4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x4_Double_double4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x0005A584 File Offset: 0x00058784
		[CallerCount(0)]
		public unsafe static bool4x4 operator >(double4x4 lhs, double4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x4_double4x4_double4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x0005A5D0 File Offset: 0x000587D0
		[CallerCount(0)]
		public unsafe static bool4x4 operator >(double4x4 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x4_double4x4_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x0005A61C File Offset: 0x0005881C
		[CallerCount(0)]
		public unsafe static bool4x4 operator >(double lhs, double4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x4_Double_double4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x0005A668 File Offset: 0x00058868
		[CallerCount(0)]
		public unsafe static bool4x4 operator >=(double4x4 lhs, double4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x4_double4x4_double4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x0005A6B4 File Offset: 0x000588B4
		[CallerCount(0)]
		public unsafe static bool4x4 operator >=(double4x4 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x4_double4x4_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x0005A700 File Offset: 0x00058900
		[CallerCount(0)]
		public unsafe static bool4x4 operator >=(double lhs, double4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x4_Double_double4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x0005A74C File Offset: 0x0005894C
		[CallerCount(0)]
		public unsafe static double4x4 operator -(double4x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_double4x4_double4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x0005A78C File Offset: 0x0005898C
		[CallerCount(0)]
		public unsafe static double4x4 operator +(double4x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_double4x4_double4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600107F RID: 4223 RVA: 0x0005A7CC File Offset: 0x000589CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636432, XrefRangeEnd = 636448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool4x4 operator ==(double4x4 lhs, double4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_double4x4_double4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x0005A818 File Offset: 0x00058A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636448, XrefRangeEnd = 636464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool4x4 operator ==(double4x4 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_double4x4_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x0005A864 File Offset: 0x00058A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636464, XrefRangeEnd = 636480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool4x4 operator ==(double lhs, double4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_Double_double4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x0005A8B0 File Offset: 0x00058AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636480, XrefRangeEnd = 636496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool4x4 operator !=(double4x4 lhs, double4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_double4x4_double4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x0005A8FC File Offset: 0x00058AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636496, XrefRangeEnd = 636512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool4x4 operator !=(double4x4 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_double4x4_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x0005A948 File Offset: 0x00058B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636512, XrefRangeEnd = 636528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool4x4 operator !=(double lhs, double4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_Double_double4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170003FF RID: 1023
		public unsafe ref double4 this[int index]
		{
			[CallerCount(0)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_get_Item_Public_get_byref_double4_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x06001086 RID: 4230 RVA: 0x0005A9C8 File Offset: 0x00058BC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 636528, RefRangeEnd = 636529, XrefRangeStart = 636528, XrefRangeEnd = 636528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(double4x4 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_double4x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001087 RID: 4231 RVA: 0x0005AA08 File Offset: 0x00058C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636529, XrefRangeEnd = 636533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x0005AA4C File Offset: 0x00058C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636533, XrefRangeEnd = 636534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x0005AA7C File Offset: 0x00058C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636534, XrefRangeEnd = 636605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x0005AAA8 File Offset: 0x00058CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636605, XrefRangeEnd = 636693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x0000242C File Offset: 0x0000062C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<double4x4>.NativeClassPtr, ref this));
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x0600108C RID: 4236 RVA: 0x0005AAF8 File Offset: 0x00058CF8
		// (set) Token: 0x0600108D RID: 4237 RVA: 0x0000243E File Offset: 0x0000063E
		public unsafe static double4x4 identity
		{
			get
			{
				double4x4 double4x;
				IL2CPP.il2cpp_field_static_get_value(double4x4.NativeFieldInfoPtr_identity, (void*)(&double4x));
				return double4x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(double4x4.NativeFieldInfoPtr_identity, (void*)(&value));
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x0600108E RID: 4238 RVA: 0x0005AB14 File Offset: 0x00058D14
		// (set) Token: 0x0600108F RID: 4239 RVA: 0x0000244C File Offset: 0x0000064C
		public unsafe static double4x4 zero
		{
			get
			{
				double4x4 double4x;
				IL2CPP.il2cpp_field_static_get_value(double4x4.NativeFieldInfoPtr_zero, (void*)(&double4x));
				return double4x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(double4x4.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x0400107C RID: 4220
		private static readonly IntPtr NativeFieldInfoPtr_c0;

		// Token: 0x0400107D RID: 4221
		private static readonly IntPtr NativeFieldInfoPtr_c1;

		// Token: 0x0400107E RID: 4222
		private static readonly IntPtr NativeFieldInfoPtr_c2;

		// Token: 0x0400107F RID: 4223
		private static readonly IntPtr NativeFieldInfoPtr_c3;

		// Token: 0x04001080 RID: 4224
		private static readonly IntPtr NativeFieldInfoPtr_identity;

		// Token: 0x04001081 RID: 4225
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x04001082 RID: 4226
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double4_double4_double4_double4_0;

		// Token: 0x04001083 RID: 4227
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_Double_Double_Double_Double_Double_Double_Double_Double_Double_Double_Double_Double_Double_Double_Double_0;

		// Token: 0x04001084 RID: 4228
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x04001085 RID: 4229
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04001086 RID: 4230
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool4x4_0;

		// Token: 0x04001087 RID: 4231
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001088 RID: 4232
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int4x4_0;

		// Token: 0x04001089 RID: 4233
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x0400108A RID: 4234
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint4x4_0;

		// Token: 0x0400108B RID: 4235
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x0400108C RID: 4236
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float4x4_0;

		// Token: 0x0400108D RID: 4237
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double4x4_Double_0;

		// Token: 0x0400108E RID: 4238
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_double4x4_Boolean_0;

		// Token: 0x0400108F RID: 4239
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_double4x4_bool4x4_0;

		// Token: 0x04001090 RID: 4240
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double4x4_Int32_0;

		// Token: 0x04001091 RID: 4241
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double4x4_int4x4_0;

		// Token: 0x04001092 RID: 4242
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double4x4_UInt32_0;

		// Token: 0x04001093 RID: 4243
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double4x4_uint4x4_0;

		// Token: 0x04001094 RID: 4244
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double4x4_Single_0;

		// Token: 0x04001095 RID: 4245
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double4x4_float4x4_0;

		// Token: 0x04001096 RID: 4246
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_double4x4_double4x4_double4x4_0;

		// Token: 0x04001097 RID: 4247
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_double4x4_double4x4_Double_0;

		// Token: 0x04001098 RID: 4248
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_double4x4_Double_double4x4_0;

		// Token: 0x04001099 RID: 4249
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_double4x4_double4x4_double4x4_0;

		// Token: 0x0400109A RID: 4250
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_double4x4_double4x4_Double_0;

		// Token: 0x0400109B RID: 4251
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_double4x4_Double_double4x4_0;

		// Token: 0x0400109C RID: 4252
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_double4x4_double4x4_double4x4_0;

		// Token: 0x0400109D RID: 4253
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_double4x4_double4x4_Double_0;

		// Token: 0x0400109E RID: 4254
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_double4x4_Double_double4x4_0;

		// Token: 0x0400109F RID: 4255
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_double4x4_double4x4_double4x4_0;

		// Token: 0x040010A0 RID: 4256
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_double4x4_double4x4_Double_0;

		// Token: 0x040010A1 RID: 4257
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_double4x4_Double_double4x4_0;

		// Token: 0x040010A2 RID: 4258
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_double4x4_double4x4_double4x4_0;

		// Token: 0x040010A3 RID: 4259
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_double4x4_double4x4_Double_0;

		// Token: 0x040010A4 RID: 4260
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_double4x4_Double_double4x4_0;

		// Token: 0x040010A5 RID: 4261
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_double4x4_double4x4_0;

		// Token: 0x040010A6 RID: 4262
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_double4x4_double4x4_0;

		// Token: 0x040010A7 RID: 4263
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x4_double4x4_double4x4_0;

		// Token: 0x040010A8 RID: 4264
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x4_double4x4_Double_0;

		// Token: 0x040010A9 RID: 4265
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x4_Double_double4x4_0;

		// Token: 0x040010AA RID: 4266
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x4_double4x4_double4x4_0;

		// Token: 0x040010AB RID: 4267
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x4_double4x4_Double_0;

		// Token: 0x040010AC RID: 4268
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x4_Double_double4x4_0;

		// Token: 0x040010AD RID: 4269
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x4_double4x4_double4x4_0;

		// Token: 0x040010AE RID: 4270
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x4_double4x4_Double_0;

		// Token: 0x040010AF RID: 4271
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x4_Double_double4x4_0;

		// Token: 0x040010B0 RID: 4272
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x4_double4x4_double4x4_0;

		// Token: 0x040010B1 RID: 4273
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x4_double4x4_Double_0;

		// Token: 0x040010B2 RID: 4274
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x4_Double_double4x4_0;

		// Token: 0x040010B3 RID: 4275
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_double4x4_double4x4_0;

		// Token: 0x040010B4 RID: 4276
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryPlus_Public_Static_double4x4_double4x4_0;

		// Token: 0x040010B5 RID: 4277
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_double4x4_double4x4_0;

		// Token: 0x040010B6 RID: 4278
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_double4x4_Double_0;

		// Token: 0x040010B7 RID: 4279
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_Double_double4x4_0;

		// Token: 0x040010B8 RID: 4280
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_double4x4_double4x4_0;

		// Token: 0x040010B9 RID: 4281
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_double4x4_Double_0;

		// Token: 0x040010BA RID: 4282
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_Double_double4x4_0;

		// Token: 0x040010BB RID: 4283
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_double4_Int32_0;

		// Token: 0x040010BC RID: 4284
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_double4x4_0;

		// Token: 0x040010BD RID: 4285
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040010BE RID: 4286
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040010BF RID: 4287
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040010C0 RID: 4288
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x040010C1 RID: 4289
		[FieldOffset(0)]
		public double4 c0;

		// Token: 0x040010C2 RID: 4290
		[FieldOffset(32)]
		public double4 c1;

		// Token: 0x040010C3 RID: 4291
		[FieldOffset(64)]
		public double4 c2;

		// Token: 0x040010C4 RID: 4292
		[FieldOffset(96)]
		public double4 c3;
	}
}
