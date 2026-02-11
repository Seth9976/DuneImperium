using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x02000027 RID: 39
	[Serializable]
	[StructLayout(2)]
	public struct float4x3
	{
		// Token: 0x06001598 RID: 5528 RVA: 0x00073608 File Offset: 0x00071808
		// Note: this type is marked as 'beforefieldinit'.
		static float4x3()
		{
			Il2CppClassPointerStore<float4x3>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "float4x3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<float4x3>.NativeClassPtr);
			float4x3.NativeFieldInfoPtr_c0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float4x3>.NativeClassPtr, "c0");
			float4x3.NativeFieldInfoPtr_c1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float4x3>.NativeClassPtr, "c1");
			float4x3.NativeFieldInfoPtr_c2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float4x3>.NativeClassPtr, "c2");
			float4x3.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float4x3>.NativeClassPtr, "zero");
			float4x3.NativeMethodInfoPtr__ctor_Public_Void_float4_float4_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668666);
			float4x3.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668667);
			float4x3.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668668);
			float4x3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668669);
			float4x3.NativeMethodInfoPtr__ctor_Public_Void_bool4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668670);
			float4x3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668671);
			float4x3.NativeMethodInfoPtr__ctor_Public_Void_int4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668672);
			float4x3.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668673);
			float4x3.NativeMethodInfoPtr__ctor_Public_Void_uint4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668674);
			float4x3.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668675);
			float4x3.NativeMethodInfoPtr__ctor_Public_Void_double4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668676);
			float4x3.NativeMethodInfoPtr_op_Implicit_Public_Static_float4x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668677);
			float4x3.NativeMethodInfoPtr_op_Explicit_Public_Static_float4x3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668678);
			float4x3.NativeMethodInfoPtr_op_Explicit_Public_Static_float4x3_bool4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668679);
			float4x3.NativeMethodInfoPtr_op_Implicit_Public_Static_float4x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668680);
			float4x3.NativeMethodInfoPtr_op_Implicit_Public_Static_float4x3_int4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668681);
			float4x3.NativeMethodInfoPtr_op_Implicit_Public_Static_float4x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668682);
			float4x3.NativeMethodInfoPtr_op_Implicit_Public_Static_float4x3_uint4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668683);
			float4x3.NativeMethodInfoPtr_op_Explicit_Public_Static_float4x3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668684);
			float4x3.NativeMethodInfoPtr_op_Explicit_Public_Static_float4x3_double4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668685);
			float4x3.NativeMethodInfoPtr_op_Multiply_Public_Static_float4x3_float4x3_float4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668686);
			float4x3.NativeMethodInfoPtr_op_Multiply_Public_Static_float4x3_float4x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668687);
			float4x3.NativeMethodInfoPtr_op_Multiply_Public_Static_float4x3_Single_float4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668688);
			float4x3.NativeMethodInfoPtr_op_Addition_Public_Static_float4x3_float4x3_float4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668689);
			float4x3.NativeMethodInfoPtr_op_Addition_Public_Static_float4x3_float4x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668690);
			float4x3.NativeMethodInfoPtr_op_Addition_Public_Static_float4x3_Single_float4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668691);
			float4x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_float4x3_float4x3_float4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668692);
			float4x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_float4x3_float4x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668693);
			float4x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_float4x3_Single_float4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668694);
			float4x3.NativeMethodInfoPtr_op_Division_Public_Static_float4x3_float4x3_float4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668695);
			float4x3.NativeMethodInfoPtr_op_Division_Public_Static_float4x3_float4x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668696);
			float4x3.NativeMethodInfoPtr_op_Division_Public_Static_float4x3_Single_float4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668697);
			float4x3.NativeMethodInfoPtr_op_Modulus_Public_Static_float4x3_float4x3_float4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668698);
			float4x3.NativeMethodInfoPtr_op_Modulus_Public_Static_float4x3_float4x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668699);
			float4x3.NativeMethodInfoPtr_op_Modulus_Public_Static_float4x3_Single_float4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668700);
			float4x3.NativeMethodInfoPtr_op_Increment_Public_Static_float4x3_float4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668701);
			float4x3.NativeMethodInfoPtr_op_Decrement_Public_Static_float4x3_float4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668702);
			float4x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x3_float4x3_float4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668703);
			float4x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x3_float4x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668704);
			float4x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x3_Single_float4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668705);
			float4x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x3_float4x3_float4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668706);
			float4x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x3_float4x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668707);
			float4x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x3_Single_float4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668708);
			float4x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x3_float4x3_float4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668709);
			float4x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x3_float4x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668710);
			float4x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x3_Single_float4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668711);
			float4x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x3_float4x3_float4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668712);
			float4x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x3_float4x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668713);
			float4x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x3_Single_float4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668714);
			float4x3.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_float4x3_float4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668715);
			float4x3.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_float4x3_float4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668716);
			float4x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_float4x3_float4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668717);
			float4x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_float4x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668718);
			float4x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_Single_float4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668719);
			float4x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_float4x3_float4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668720);
			float4x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_float4x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668721);
			float4x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_Single_float4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668722);
			float4x3.NativeMethodInfoPtr_get_Item_Public_get_byref_float4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668723);
			float4x3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_float4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668724);
			float4x3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668725);
			float4x3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668726);
			float4x3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668727);
			float4x3.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float4x3>.NativeClassPtr, 100668728);
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x00073B74 File Offset: 0x00071D74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 556238, RefRangeEnd = 556240, XrefRangeStart = 556238, XrefRangeEnd = 556240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float4x3(float4 c0, float4 c1, float4 c2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr__ctor_Public_Void_float4_float4_float4_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x00073BC4 File Offset: 0x00071DC4
		[CallerCount(0)]
		public unsafe float4x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22, float m30, float m31, float m32)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m30;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m31;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m32;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600159B RID: 5531 RVA: 0x00073C94 File Offset: 0x00071E94
		[CallerCount(0)]
		public unsafe float4x3(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x00073CC8 File Offset: 0x00071EC8
		[CallerCount(0)]
		public unsafe float4x3(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x00073CFC File Offset: 0x00071EFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 638240, RefRangeEnd = 638241, XrefRangeStart = 638229, XrefRangeEnd = 638240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float4x3(bool4x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr__ctor_Public_Void_bool4x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x00073D30 File Offset: 0x00071F30
		[CallerCount(0)]
		public unsafe float4x3(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x00073D64 File Offset: 0x00071F64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 638241, RefRangeEnd = 638242, XrefRangeStart = 638241, XrefRangeEnd = 638241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float4x3(int4x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr__ctor_Public_Void_int4x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x00073D98 File Offset: 0x00071F98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 638242, RefRangeEnd = 638243, XrefRangeStart = 638242, XrefRangeEnd = 638242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float4x3(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x00073DCC File Offset: 0x00071FCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 638243, RefRangeEnd = 638244, XrefRangeStart = 638243, XrefRangeEnd = 638243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float4x3(uint4x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr__ctor_Public_Void_uint4x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x00073E00 File Offset: 0x00072000
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 638244, RefRangeEnd = 638245, XrefRangeStart = 638244, XrefRangeEnd = 638244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float4x3(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x00073E34 File Offset: 0x00072034
		[CallerCount(0)]
		public unsafe float4x3(double4x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr__ctor_Public_Void_double4x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015A4 RID: 5540 RVA: 0x00073E68 File Offset: 0x00072068
		[CallerCount(0)]
		public unsafe static implicit operator float4x3(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_Implicit_Public_Static_float4x3_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x00073EA8 File Offset: 0x000720A8
		[CallerCount(0)]
		public unsafe static explicit operator float4x3(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_Explicit_Public_Static_float4x3_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x00073EE8 File Offset: 0x000720E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638245, XrefRangeEnd = 638246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator float4x3(bool4x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_Explicit_Public_Static_float4x3_bool4x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x00073F28 File Offset: 0x00072128
		[CallerCount(0)]
		public unsafe static implicit operator float4x3(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_Implicit_Public_Static_float4x3_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x00073F68 File Offset: 0x00072168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638246, XrefRangeEnd = 638247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator float4x3(int4x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_Implicit_Public_Static_float4x3_int4x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015A9 RID: 5545 RVA: 0x00073FA8 File Offset: 0x000721A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638247, XrefRangeEnd = 638248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator float4x3(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_Implicit_Public_Static_float4x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015AA RID: 5546 RVA: 0x00073FE8 File Offset: 0x000721E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638248, XrefRangeEnd = 638249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator float4x3(uint4x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_Implicit_Public_Static_float4x3_uint4x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015AB RID: 5547 RVA: 0x00074028 File Offset: 0x00072228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638249, XrefRangeEnd = 638250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator float4x3(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_Explicit_Public_Static_float4x3_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x00074068 File Offset: 0x00072268
		[CallerCount(0)]
		public unsafe static explicit operator float4x3(double4x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_Explicit_Public_Static_float4x3_double4x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015AD RID: 5549 RVA: 0x000740A8 File Offset: 0x000722A8
		[CallerCount(0)]
		public unsafe static float4x3 operator *(float4x3 lhs, float4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_Multiply_Public_Static_float4x3_float4x3_float4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015AE RID: 5550 RVA: 0x000740F4 File Offset: 0x000722F4
		[CallerCount(0)]
		public unsafe static float4x3 operator *(float4x3 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_Multiply_Public_Static_float4x3_float4x3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015AF RID: 5551 RVA: 0x00074140 File Offset: 0x00072340
		[CallerCount(0)]
		public unsafe static float4x3 operator *(float lhs, float4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_Multiply_Public_Static_float4x3_Single_float4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015B0 RID: 5552 RVA: 0x0007418C File Offset: 0x0007238C
		[CallerCount(0)]
		public unsafe static float4x3 operator +(float4x3 lhs, float4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_Addition_Public_Static_float4x3_float4x3_float4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015B1 RID: 5553 RVA: 0x000741D8 File Offset: 0x000723D8
		[CallerCount(0)]
		public unsafe static float4x3 operator +(float4x3 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_Addition_Public_Static_float4x3_float4x3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x00074224 File Offset: 0x00072424
		[CallerCount(0)]
		public unsafe static float4x3 operator +(float lhs, float4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_Addition_Public_Static_float4x3_Single_float4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x00074270 File Offset: 0x00072470
		[CallerCount(0)]
		public unsafe static float4x3 operator -(float4x3 lhs, float4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_float4x3_float4x3_float4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x000742BC File Offset: 0x000724BC
		[CallerCount(0)]
		public unsafe static float4x3 operator -(float4x3 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_float4x3_float4x3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x00074308 File Offset: 0x00072508
		[CallerCount(0)]
		public unsafe static float4x3 operator -(float lhs, float4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_float4x3_Single_float4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x00074354 File Offset: 0x00072554
		[CallerCount(0)]
		public unsafe static float4x3 operator /(float4x3 lhs, float4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_Division_Public_Static_float4x3_float4x3_float4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x000743A0 File Offset: 0x000725A0
		[CallerCount(0)]
		public unsafe static float4x3 operator /(float4x3 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_Division_Public_Static_float4x3_float4x3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x000743EC File Offset: 0x000725EC
		[CallerCount(0)]
		public unsafe static float4x3 operator /(float lhs, float4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_Division_Public_Static_float4x3_Single_float4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x00074438 File Offset: 0x00072638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638250, XrefRangeEnd = 638262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4x3 operator %(float4x3 lhs, float4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_Modulus_Public_Static_float4x3_float4x3_float4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x00074484 File Offset: 0x00072684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638262, XrefRangeEnd = 638274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4x3 operator %(float4x3 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_Modulus_Public_Static_float4x3_float4x3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015BB RID: 5563 RVA: 0x000744D0 File Offset: 0x000726D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638274, XrefRangeEnd = 638286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4x3 operator %(float lhs, float4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_Modulus_Public_Static_float4x3_Single_float4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x0007451C File Offset: 0x0007271C
		[CallerCount(0)]
		public unsafe static float4x3 operator ++(float4x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_Increment_Public_Static_float4x3_float4x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015BD RID: 5565 RVA: 0x0007455C File Offset: 0x0007275C
		[CallerCount(0)]
		public unsafe static float4x3 operator --(float4x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_Decrement_Public_Static_float4x3_float4x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x0007459C File Offset: 0x0007279C
		[CallerCount(0)]
		public unsafe static bool4x3 operator <(float4x3 lhs, float4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x3_float4x3_float4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015BF RID: 5567 RVA: 0x000745E8 File Offset: 0x000727E8
		[CallerCount(0)]
		public unsafe static bool4x3 operator <(float4x3 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x3_float4x3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015C0 RID: 5568 RVA: 0x00074634 File Offset: 0x00072834
		[CallerCount(0)]
		public unsafe static bool4x3 operator <(float lhs, float4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x3_Single_float4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x00074680 File Offset: 0x00072880
		[CallerCount(0)]
		public unsafe static bool4x3 operator <=(float4x3 lhs, float4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x3_float4x3_float4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x000746CC File Offset: 0x000728CC
		[CallerCount(0)]
		public unsafe static bool4x3 operator <=(float4x3 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x3_float4x3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x00074718 File Offset: 0x00072918
		[CallerCount(0)]
		public unsafe static bool4x3 operator <=(float lhs, float4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x3_Single_float4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x00074764 File Offset: 0x00072964
		[CallerCount(0)]
		public unsafe static bool4x3 operator >(float4x3 lhs, float4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x3_float4x3_float4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x000747B0 File Offset: 0x000729B0
		[CallerCount(0)]
		public unsafe static bool4x3 operator >(float4x3 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x3_float4x3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x000747FC File Offset: 0x000729FC
		[CallerCount(0)]
		public unsafe static bool4x3 operator >(float lhs, float4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x3_Single_float4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x00074848 File Offset: 0x00072A48
		[CallerCount(0)]
		public unsafe static bool4x3 operator >=(float4x3 lhs, float4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x3_float4x3_float4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x00074894 File Offset: 0x00072A94
		[CallerCount(0)]
		public unsafe static bool4x3 operator >=(float4x3 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x3_float4x3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x000748E0 File Offset: 0x00072AE0
		[CallerCount(0)]
		public unsafe static bool4x3 operator >=(float lhs, float4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x3_Single_float4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x0007492C File Offset: 0x00072B2C
		[CallerCount(0)]
		public unsafe static float4x3 operator -(float4x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_float4x3_float4x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x0007496C File Offset: 0x00072B6C
		[CallerCount(0)]
		public unsafe static float4x3 operator +(float4x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_float4x3_float4x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015CC RID: 5580 RVA: 0x000749AC File Offset: 0x00072BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638286, XrefRangeEnd = 638298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool4x3 operator ==(float4x3 lhs, float4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_float4x3_float4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x000749F8 File Offset: 0x00072BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638298, XrefRangeEnd = 638310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool4x3 operator ==(float4x3 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_float4x3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x00074A44 File Offset: 0x00072C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638310, XrefRangeEnd = 638322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool4x3 operator ==(float lhs, float4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_Single_float4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x00074A90 File Offset: 0x00072C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638322, XrefRangeEnd = 638334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool4x3 operator !=(float4x3 lhs, float4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_float4x3_float4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x00074ADC File Offset: 0x00072CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638334, XrefRangeEnd = 638346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool4x3 operator !=(float4x3 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_float4x3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x00074B28 File Offset: 0x00072D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638346, XrefRangeEnd = 638358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool4x3 operator !=(float lhs, float4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_Single_float4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170005F8 RID: 1528
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_get_Item_Public_get_byref_float4_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x00074BA8 File Offset: 0x00072DA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 638358, RefRangeEnd = 638359, XrefRangeStart = 638358, XrefRangeEnd = 638358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(float4x3 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_float4x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015D4 RID: 5588 RVA: 0x00074BE8 File Offset: 0x00072DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638359, XrefRangeEnd = 638363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x00074C2C File Offset: 0x00072E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638363, XrefRangeEnd = 638364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x00074C5C File Offset: 0x00072E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638364, XrefRangeEnd = 638419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060015D7 RID: 5591 RVA: 0x00074C88 File Offset: 0x00072E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638419, XrefRangeEnd = 638487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float4x3.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060015D8 RID: 5592 RVA: 0x000025B6 File Offset: 0x000007B6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<float4x3>.NativeClassPtr, ref this));
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x060015D9 RID: 5593 RVA: 0x00074CD8 File Offset: 0x00072ED8
		// (set) Token: 0x060015DA RID: 5594 RVA: 0x000025C8 File Offset: 0x000007C8
		public unsafe static float4x3 zero
		{
			get
			{
				float4x3 float4x;
				IL2CPP.il2cpp_field_static_get_value(float4x3.NativeFieldInfoPtr_zero, (void*)(&float4x));
				return float4x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(float4x3.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x040015E7 RID: 5607
		private static readonly IntPtr NativeFieldInfoPtr_c0;

		// Token: 0x040015E8 RID: 5608
		private static readonly IntPtr NativeFieldInfoPtr_c1;

		// Token: 0x040015E9 RID: 5609
		private static readonly IntPtr NativeFieldInfoPtr_c2;

		// Token: 0x040015EA RID: 5610
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x040015EB RID: 5611
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float4_float4_float4_0;

		// Token: 0x040015EC RID: 5612
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_0;

		// Token: 0x040015ED RID: 5613
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x040015EE RID: 5614
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x040015EF RID: 5615
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool4x3_0;

		// Token: 0x040015F0 RID: 5616
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040015F1 RID: 5617
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int4x3_0;

		// Token: 0x040015F2 RID: 5618
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x040015F3 RID: 5619
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint4x3_0;

		// Token: 0x040015F4 RID: 5620
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x040015F5 RID: 5621
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double4x3_0;

		// Token: 0x040015F6 RID: 5622
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float4x3_Single_0;

		// Token: 0x040015F7 RID: 5623
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_float4x3_Boolean_0;

		// Token: 0x040015F8 RID: 5624
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_float4x3_bool4x3_0;

		// Token: 0x040015F9 RID: 5625
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float4x3_Int32_0;

		// Token: 0x040015FA RID: 5626
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float4x3_int4x3_0;

		// Token: 0x040015FB RID: 5627
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float4x3_UInt32_0;

		// Token: 0x040015FC RID: 5628
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float4x3_uint4x3_0;

		// Token: 0x040015FD RID: 5629
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_float4x3_Double_0;

		// Token: 0x040015FE RID: 5630
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_float4x3_double4x3_0;

		// Token: 0x040015FF RID: 5631
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_float4x3_float4x3_float4x3_0;

		// Token: 0x04001600 RID: 5632
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_float4x3_float4x3_Single_0;

		// Token: 0x04001601 RID: 5633
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_float4x3_Single_float4x3_0;

		// Token: 0x04001602 RID: 5634
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_float4x3_float4x3_float4x3_0;

		// Token: 0x04001603 RID: 5635
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_float4x3_float4x3_Single_0;

		// Token: 0x04001604 RID: 5636
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_float4x3_Single_float4x3_0;

		// Token: 0x04001605 RID: 5637
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_float4x3_float4x3_float4x3_0;

		// Token: 0x04001606 RID: 5638
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_float4x3_float4x3_Single_0;

		// Token: 0x04001607 RID: 5639
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_float4x3_Single_float4x3_0;

		// Token: 0x04001608 RID: 5640
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_float4x3_float4x3_float4x3_0;

		// Token: 0x04001609 RID: 5641
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_float4x3_float4x3_Single_0;

		// Token: 0x0400160A RID: 5642
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_float4x3_Single_float4x3_0;

		// Token: 0x0400160B RID: 5643
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_float4x3_float4x3_float4x3_0;

		// Token: 0x0400160C RID: 5644
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_float4x3_float4x3_Single_0;

		// Token: 0x0400160D RID: 5645
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_float4x3_Single_float4x3_0;

		// Token: 0x0400160E RID: 5646
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_float4x3_float4x3_0;

		// Token: 0x0400160F RID: 5647
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_float4x3_float4x3_0;

		// Token: 0x04001610 RID: 5648
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x3_float4x3_float4x3_0;

		// Token: 0x04001611 RID: 5649
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x3_float4x3_Single_0;

		// Token: 0x04001612 RID: 5650
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x3_Single_float4x3_0;

		// Token: 0x04001613 RID: 5651
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x3_float4x3_float4x3_0;

		// Token: 0x04001614 RID: 5652
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x3_float4x3_Single_0;

		// Token: 0x04001615 RID: 5653
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x3_Single_float4x3_0;

		// Token: 0x04001616 RID: 5654
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x3_float4x3_float4x3_0;

		// Token: 0x04001617 RID: 5655
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x3_float4x3_Single_0;

		// Token: 0x04001618 RID: 5656
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x3_Single_float4x3_0;

		// Token: 0x04001619 RID: 5657
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x3_float4x3_float4x3_0;

		// Token: 0x0400161A RID: 5658
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x3_float4x3_Single_0;

		// Token: 0x0400161B RID: 5659
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x3_Single_float4x3_0;

		// Token: 0x0400161C RID: 5660
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_float4x3_float4x3_0;

		// Token: 0x0400161D RID: 5661
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryPlus_Public_Static_float4x3_float4x3_0;

		// Token: 0x0400161E RID: 5662
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_float4x3_float4x3_0;

		// Token: 0x0400161F RID: 5663
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_float4x3_Single_0;

		// Token: 0x04001620 RID: 5664
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_Single_float4x3_0;

		// Token: 0x04001621 RID: 5665
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_float4x3_float4x3_0;

		// Token: 0x04001622 RID: 5666
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_float4x3_Single_0;

		// Token: 0x04001623 RID: 5667
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_Single_float4x3_0;

		// Token: 0x04001624 RID: 5668
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_float4_Int32_0;

		// Token: 0x04001625 RID: 5669
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_float4x3_0;

		// Token: 0x04001626 RID: 5670
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001627 RID: 5671
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001628 RID: 5672
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001629 RID: 5673
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x0400162A RID: 5674
		[FieldOffset(0)]
		public float4 c0;

		// Token: 0x0400162B RID: 5675
		[FieldOffset(16)]
		public float4 c1;

		// Token: 0x0400162C RID: 5676
		[FieldOffset(32)]
		public float4 c2;
	}
}
