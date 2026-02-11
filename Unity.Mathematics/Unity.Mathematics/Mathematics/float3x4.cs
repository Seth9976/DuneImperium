using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x02000024 RID: 36
	[Serializable]
	[StructLayout(2)]
	public struct float3x4
	{
		// Token: 0x06001336 RID: 4918 RVA: 0x00068378 File Offset: 0x00066578
		// Note: this type is marked as 'beforefieldinit'.
		static float3x4()
		{
			Il2CppClassPointerStore<float3x4>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "float3x4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<float3x4>.NativeClassPtr);
			float3x4.NativeFieldInfoPtr_c0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float3x4>.NativeClassPtr, "c0");
			float3x4.NativeFieldInfoPtr_c1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float3x4>.NativeClassPtr, "c1");
			float3x4.NativeFieldInfoPtr_c2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float3x4>.NativeClassPtr, "c2");
			float3x4.NativeFieldInfoPtr_c3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float3x4>.NativeClassPtr, "c3");
			float3x4.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float3x4>.NativeClassPtr, "zero");
			float3x4.NativeMethodInfoPtr__ctor_Public_Void_float3_float3_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668067);
			float3x4.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668068);
			float3x4.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668069);
			float3x4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668070);
			float3x4.NativeMethodInfoPtr__ctor_Public_Void_bool3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668071);
			float3x4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668072);
			float3x4.NativeMethodInfoPtr__ctor_Public_Void_int3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668073);
			float3x4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668074);
			float3x4.NativeMethodInfoPtr__ctor_Public_Void_uint3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668075);
			float3x4.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668076);
			float3x4.NativeMethodInfoPtr__ctor_Public_Void_double3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668077);
			float3x4.NativeMethodInfoPtr_op_Implicit_Public_Static_float3x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668078);
			float3x4.NativeMethodInfoPtr_op_Explicit_Public_Static_float3x4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668079);
			float3x4.NativeMethodInfoPtr_op_Explicit_Public_Static_float3x4_bool3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668080);
			float3x4.NativeMethodInfoPtr_op_Implicit_Public_Static_float3x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668081);
			float3x4.NativeMethodInfoPtr_op_Implicit_Public_Static_float3x4_int3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668082);
			float3x4.NativeMethodInfoPtr_op_Implicit_Public_Static_float3x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668083);
			float3x4.NativeMethodInfoPtr_op_Implicit_Public_Static_float3x4_uint3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668084);
			float3x4.NativeMethodInfoPtr_op_Explicit_Public_Static_float3x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668085);
			float3x4.NativeMethodInfoPtr_op_Explicit_Public_Static_float3x4_double3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668086);
			float3x4.NativeMethodInfoPtr_op_Multiply_Public_Static_float3x4_float3x4_float3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668087);
			float3x4.NativeMethodInfoPtr_op_Multiply_Public_Static_float3x4_float3x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668088);
			float3x4.NativeMethodInfoPtr_op_Multiply_Public_Static_float3x4_Single_float3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668089);
			float3x4.NativeMethodInfoPtr_op_Addition_Public_Static_float3x4_float3x4_float3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668090);
			float3x4.NativeMethodInfoPtr_op_Addition_Public_Static_float3x4_float3x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668091);
			float3x4.NativeMethodInfoPtr_op_Addition_Public_Static_float3x4_Single_float3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668092);
			float3x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_float3x4_float3x4_float3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668093);
			float3x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_float3x4_float3x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668094);
			float3x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_float3x4_Single_float3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668095);
			float3x4.NativeMethodInfoPtr_op_Division_Public_Static_float3x4_float3x4_float3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668096);
			float3x4.NativeMethodInfoPtr_op_Division_Public_Static_float3x4_float3x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668097);
			float3x4.NativeMethodInfoPtr_op_Division_Public_Static_float3x4_Single_float3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668098);
			float3x4.NativeMethodInfoPtr_op_Modulus_Public_Static_float3x4_float3x4_float3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668099);
			float3x4.NativeMethodInfoPtr_op_Modulus_Public_Static_float3x4_float3x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668100);
			float3x4.NativeMethodInfoPtr_op_Modulus_Public_Static_float3x4_Single_float3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668101);
			float3x4.NativeMethodInfoPtr_op_Increment_Public_Static_float3x4_float3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668102);
			float3x4.NativeMethodInfoPtr_op_Decrement_Public_Static_float3x4_float3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668103);
			float3x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x4_float3x4_float3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668104);
			float3x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x4_float3x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668105);
			float3x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x4_Single_float3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668106);
			float3x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x4_float3x4_float3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668107);
			float3x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x4_float3x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668108);
			float3x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x4_Single_float3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668109);
			float3x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x4_float3x4_float3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668110);
			float3x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x4_float3x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668111);
			float3x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x4_Single_float3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668112);
			float3x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x4_float3x4_float3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668113);
			float3x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x4_float3x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668114);
			float3x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x4_Single_float3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668115);
			float3x4.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_float3x4_float3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668116);
			float3x4.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_float3x4_float3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668117);
			float3x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x4_float3x4_float3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668118);
			float3x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x4_float3x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668119);
			float3x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x4_Single_float3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668120);
			float3x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x4_float3x4_float3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668121);
			float3x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x4_float3x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668122);
			float3x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x4_Single_float3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668123);
			float3x4.NativeMethodInfoPtr_get_Item_Public_get_byref_float3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668124);
			float3x4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_float3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668125);
			float3x4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668126);
			float3x4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668127);
			float3x4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668128);
			float3x4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float3x4>.NativeClassPtr, 100668129);
		}

		// Token: 0x06001337 RID: 4919 RVA: 0x000688F8 File Offset: 0x00066AF8
		[CallerCount(0)]
		public unsafe float3x4(float3 c0, float3 c1, float3 c2, float3 c3)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr__ctor_Public_Void_float3_float3_float3_float3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x00068954 File Offset: 0x00066B54
		[CallerCount(0)]
		public unsafe float3x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
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
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x00068A24 File Offset: 0x00066C24
		[CallerCount(0)]
		public unsafe float3x4(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x00068A58 File Offset: 0x00066C58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 637648, RefRangeEnd = 637649, XrefRangeStart = 637648, XrefRangeEnd = 637648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float3x4(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x00068A8C File Offset: 0x00066C8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 637660, RefRangeEnd = 637661, XrefRangeStart = 637649, XrefRangeEnd = 637660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float3x4(bool3x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr__ctor_Public_Void_bool3x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x00068AC0 File Offset: 0x00066CC0
		[CallerCount(0)]
		public unsafe float3x4(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x00068AF4 File Offset: 0x00066CF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 637661, RefRangeEnd = 637662, XrefRangeStart = 637661, XrefRangeEnd = 637661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float3x4(int3x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr__ctor_Public_Void_int3x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x00068B28 File Offset: 0x00066D28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 637662, RefRangeEnd = 637663, XrefRangeStart = 637662, XrefRangeEnd = 637662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float3x4(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x00068B5C File Offset: 0x00066D5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 637663, RefRangeEnd = 637664, XrefRangeStart = 637663, XrefRangeEnd = 637663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float3x4(uint3x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr__ctor_Public_Void_uint3x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x00068B90 File Offset: 0x00066D90
		[CallerCount(0)]
		public unsafe float3x4(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x00068BC4 File Offset: 0x00066DC4
		[CallerCount(0)]
		public unsafe float3x4(double3x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr__ctor_Public_Void_double3x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x00068BF8 File Offset: 0x00066DF8
		[CallerCount(0)]
		public unsafe static implicit operator float3x4(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_Implicit_Public_Static_float3x4_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x00068C38 File Offset: 0x00066E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637664, XrefRangeEnd = 637665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator float3x4(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_Explicit_Public_Static_float3x4_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x00068C78 File Offset: 0x00066E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637665, XrefRangeEnd = 637666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator float3x4(bool3x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_Explicit_Public_Static_float3x4_bool3x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x00068CB8 File Offset: 0x00066EB8
		[CallerCount(0)]
		public unsafe static implicit operator float3x4(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_Implicit_Public_Static_float3x4_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x00068CF8 File Offset: 0x00066EF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637666, XrefRangeEnd = 637667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator float3x4(int3x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_Implicit_Public_Static_float3x4_int3x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x00068D38 File Offset: 0x00066F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637667, XrefRangeEnd = 637668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator float3x4(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_Implicit_Public_Static_float3x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x00068D78 File Offset: 0x00066F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637668, XrefRangeEnd = 637669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator float3x4(uint3x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_Implicit_Public_Static_float3x4_uint3x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x00068DB8 File Offset: 0x00066FB8
		[CallerCount(0)]
		public unsafe static explicit operator float3x4(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_Explicit_Public_Static_float3x4_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x00068DF8 File Offset: 0x00066FF8
		[CallerCount(0)]
		public unsafe static explicit operator float3x4(double3x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_Explicit_Public_Static_float3x4_double3x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x00068E38 File Offset: 0x00067038
		[CallerCount(0)]
		public unsafe static float3x4 operator *(float3x4 lhs, float3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_Multiply_Public_Static_float3x4_float3x4_float3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600134C RID: 4940 RVA: 0x00068E84 File Offset: 0x00067084
		[CallerCount(0)]
		public unsafe static float3x4 operator *(float3x4 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_Multiply_Public_Static_float3x4_float3x4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600134D RID: 4941 RVA: 0x00068ED0 File Offset: 0x000670D0
		[CallerCount(0)]
		public unsafe static float3x4 operator *(float lhs, float3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_Multiply_Public_Static_float3x4_Single_float3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x00068F1C File Offset: 0x0006711C
		[CallerCount(0)]
		public unsafe static float3x4 operator +(float3x4 lhs, float3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_Addition_Public_Static_float3x4_float3x4_float3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x00068F68 File Offset: 0x00067168
		[CallerCount(0)]
		public unsafe static float3x4 operator +(float3x4 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_Addition_Public_Static_float3x4_float3x4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x00068FB4 File Offset: 0x000671B4
		[CallerCount(0)]
		public unsafe static float3x4 operator +(float lhs, float3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_Addition_Public_Static_float3x4_Single_float3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x00069000 File Offset: 0x00067200
		[CallerCount(0)]
		public unsafe static float3x4 operator -(float3x4 lhs, float3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_float3x4_float3x4_float3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x0006904C File Offset: 0x0006724C
		[CallerCount(0)]
		public unsafe static float3x4 operator -(float3x4 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_float3x4_float3x4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x00069098 File Offset: 0x00067298
		[CallerCount(0)]
		public unsafe static float3x4 operator -(float lhs, float3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_float3x4_Single_float3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x000690E4 File Offset: 0x000672E4
		[CallerCount(0)]
		public unsafe static float3x4 operator /(float3x4 lhs, float3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_Division_Public_Static_float3x4_float3x4_float3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x00069130 File Offset: 0x00067330
		[CallerCount(0)]
		public unsafe static float3x4 operator /(float3x4 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_Division_Public_Static_float3x4_float3x4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x0006917C File Offset: 0x0006737C
		[CallerCount(0)]
		public unsafe static float3x4 operator /(float lhs, float3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_Division_Public_Static_float3x4_Single_float3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x000691C8 File Offset: 0x000673C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637669, XrefRangeEnd = 637681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float3x4 operator %(float3x4 lhs, float3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_Modulus_Public_Static_float3x4_float3x4_float3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x00069214 File Offset: 0x00067414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637681, XrefRangeEnd = 637693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float3x4 operator %(float3x4 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_Modulus_Public_Static_float3x4_float3x4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x00069260 File Offset: 0x00067460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637693, XrefRangeEnd = 637705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float3x4 operator %(float lhs, float3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_Modulus_Public_Static_float3x4_Single_float3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x000692AC File Offset: 0x000674AC
		[CallerCount(0)]
		public unsafe static float3x4 operator ++(float3x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_Increment_Public_Static_float3x4_float3x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x000692EC File Offset: 0x000674EC
		[CallerCount(0)]
		public unsafe static float3x4 operator --(float3x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_Decrement_Public_Static_float3x4_float3x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x0006932C File Offset: 0x0006752C
		[CallerCount(0)]
		public unsafe static bool3x4 operator <(float3x4 lhs, float3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x4_float3x4_float3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x00069378 File Offset: 0x00067578
		[CallerCount(0)]
		public unsafe static bool3x4 operator <(float3x4 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x4_float3x4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x000693C4 File Offset: 0x000675C4
		[CallerCount(0)]
		public unsafe static bool3x4 operator <(float lhs, float3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x4_Single_float3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x00069410 File Offset: 0x00067610
		[CallerCount(0)]
		public unsafe static bool3x4 operator <=(float3x4 lhs, float3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x4_float3x4_float3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x0006945C File Offset: 0x0006765C
		[CallerCount(0)]
		public unsafe static bool3x4 operator <=(float3x4 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x4_float3x4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001361 RID: 4961 RVA: 0x000694A8 File Offset: 0x000676A8
		[CallerCount(0)]
		public unsafe static bool3x4 operator <=(float lhs, float3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x4_Single_float3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x000694F4 File Offset: 0x000676F4
		[CallerCount(0)]
		public unsafe static bool3x4 operator >(float3x4 lhs, float3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x4_float3x4_float3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x00069540 File Offset: 0x00067740
		[CallerCount(0)]
		public unsafe static bool3x4 operator >(float3x4 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x4_float3x4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x0006958C File Offset: 0x0006778C
		[CallerCount(0)]
		public unsafe static bool3x4 operator >(float lhs, float3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x4_Single_float3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001365 RID: 4965 RVA: 0x000695D8 File Offset: 0x000677D8
		[CallerCount(0)]
		public unsafe static bool3x4 operator >=(float3x4 lhs, float3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x4_float3x4_float3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001366 RID: 4966 RVA: 0x00069624 File Offset: 0x00067824
		[CallerCount(0)]
		public unsafe static bool3x4 operator >=(float3x4 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x4_float3x4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001367 RID: 4967 RVA: 0x00069670 File Offset: 0x00067870
		[CallerCount(0)]
		public unsafe static bool3x4 operator >=(float lhs, float3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x4_Single_float3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x000696BC File Offset: 0x000678BC
		[CallerCount(0)]
		public unsafe static float3x4 operator -(float3x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_float3x4_float3x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001369 RID: 4969 RVA: 0x000696FC File Offset: 0x000678FC
		[CallerCount(0)]
		public unsafe static float3x4 operator +(float3x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_float3x4_float3x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600136A RID: 4970 RVA: 0x0006973C File Offset: 0x0006793C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637705, XrefRangeEnd = 637717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool3x4 operator ==(float3x4 lhs, float3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x4_float3x4_float3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600136B RID: 4971 RVA: 0x00069788 File Offset: 0x00067988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637717, XrefRangeEnd = 637729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool3x4 operator ==(float3x4 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x4_float3x4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600136C RID: 4972 RVA: 0x000697D4 File Offset: 0x000679D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637729, XrefRangeEnd = 637741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool3x4 operator ==(float lhs, float3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x4_Single_float3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600136D RID: 4973 RVA: 0x00069820 File Offset: 0x00067A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637741, XrefRangeEnd = 637753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool3x4 operator !=(float3x4 lhs, float3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x4_float3x4_float3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600136E RID: 4974 RVA: 0x0006986C File Offset: 0x00067A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637753, XrefRangeEnd = 637765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool3x4 operator !=(float3x4 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x4_float3x4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x000698B8 File Offset: 0x00067AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637765, XrefRangeEnd = 637777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool3x4 operator !=(float lhs, float3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x4_Single_float3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170004A2 RID: 1186
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_get_Item_Public_get_byref_float3_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x00069938 File Offset: 0x00067B38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 637777, RefRangeEnd = 637778, XrefRangeStart = 637777, XrefRangeEnd = 637777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(float3x4 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_float3x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001372 RID: 4978 RVA: 0x00069978 File Offset: 0x00067B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637778, XrefRangeEnd = 637782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x000699BC File Offset: 0x00067BBC
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x000699EC File Offset: 0x00067BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637782, XrefRangeEnd = 637837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x00069A18 File Offset: 0x00067C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637837, XrefRangeEnd = 637905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float3x4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x00002556 File Offset: 0x00000756
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<float3x4>.NativeClassPtr, ref this));
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06001377 RID: 4983 RVA: 0x00069A68 File Offset: 0x00067C68
		// (set) Token: 0x06001378 RID: 4984 RVA: 0x00002568 File Offset: 0x00000768
		public unsafe static float3x4 zero
		{
			get
			{
				float3x4 float3x;
				IL2CPP.il2cpp_field_static_get_value(float3x4.NativeFieldInfoPtr_zero, (void*)(&float3x));
				return float3x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(float3x4.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x0400137A RID: 4986
		private static readonly IntPtr NativeFieldInfoPtr_c0;

		// Token: 0x0400137B RID: 4987
		private static readonly IntPtr NativeFieldInfoPtr_c1;

		// Token: 0x0400137C RID: 4988
		private static readonly IntPtr NativeFieldInfoPtr_c2;

		// Token: 0x0400137D RID: 4989
		private static readonly IntPtr NativeFieldInfoPtr_c3;

		// Token: 0x0400137E RID: 4990
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x0400137F RID: 4991
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float3_float3_float3_float3_0;

		// Token: 0x04001380 RID: 4992
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_0;

		// Token: 0x04001381 RID: 4993
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x04001382 RID: 4994
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04001383 RID: 4995
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool3x4_0;

		// Token: 0x04001384 RID: 4996
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001385 RID: 4997
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int3x4_0;

		// Token: 0x04001386 RID: 4998
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04001387 RID: 4999
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint3x4_0;

		// Token: 0x04001388 RID: 5000
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x04001389 RID: 5001
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double3x4_0;

		// Token: 0x0400138A RID: 5002
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float3x4_Single_0;

		// Token: 0x0400138B RID: 5003
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_float3x4_Boolean_0;

		// Token: 0x0400138C RID: 5004
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_float3x4_bool3x4_0;

		// Token: 0x0400138D RID: 5005
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float3x4_Int32_0;

		// Token: 0x0400138E RID: 5006
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float3x4_int3x4_0;

		// Token: 0x0400138F RID: 5007
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float3x4_UInt32_0;

		// Token: 0x04001390 RID: 5008
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float3x4_uint3x4_0;

		// Token: 0x04001391 RID: 5009
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_float3x4_Double_0;

		// Token: 0x04001392 RID: 5010
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_float3x4_double3x4_0;

		// Token: 0x04001393 RID: 5011
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_float3x4_float3x4_float3x4_0;

		// Token: 0x04001394 RID: 5012
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_float3x4_float3x4_Single_0;

		// Token: 0x04001395 RID: 5013
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_float3x4_Single_float3x4_0;

		// Token: 0x04001396 RID: 5014
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_float3x4_float3x4_float3x4_0;

		// Token: 0x04001397 RID: 5015
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_float3x4_float3x4_Single_0;

		// Token: 0x04001398 RID: 5016
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_float3x4_Single_float3x4_0;

		// Token: 0x04001399 RID: 5017
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_float3x4_float3x4_float3x4_0;

		// Token: 0x0400139A RID: 5018
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_float3x4_float3x4_Single_0;

		// Token: 0x0400139B RID: 5019
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_float3x4_Single_float3x4_0;

		// Token: 0x0400139C RID: 5020
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_float3x4_float3x4_float3x4_0;

		// Token: 0x0400139D RID: 5021
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_float3x4_float3x4_Single_0;

		// Token: 0x0400139E RID: 5022
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_float3x4_Single_float3x4_0;

		// Token: 0x0400139F RID: 5023
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_float3x4_float3x4_float3x4_0;

		// Token: 0x040013A0 RID: 5024
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_float3x4_float3x4_Single_0;

		// Token: 0x040013A1 RID: 5025
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_float3x4_Single_float3x4_0;

		// Token: 0x040013A2 RID: 5026
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_float3x4_float3x4_0;

		// Token: 0x040013A3 RID: 5027
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_float3x4_float3x4_0;

		// Token: 0x040013A4 RID: 5028
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x4_float3x4_float3x4_0;

		// Token: 0x040013A5 RID: 5029
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x4_float3x4_Single_0;

		// Token: 0x040013A6 RID: 5030
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x4_Single_float3x4_0;

		// Token: 0x040013A7 RID: 5031
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x4_float3x4_float3x4_0;

		// Token: 0x040013A8 RID: 5032
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x4_float3x4_Single_0;

		// Token: 0x040013A9 RID: 5033
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x4_Single_float3x4_0;

		// Token: 0x040013AA RID: 5034
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x4_float3x4_float3x4_0;

		// Token: 0x040013AB RID: 5035
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x4_float3x4_Single_0;

		// Token: 0x040013AC RID: 5036
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x4_Single_float3x4_0;

		// Token: 0x040013AD RID: 5037
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x4_float3x4_float3x4_0;

		// Token: 0x040013AE RID: 5038
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x4_float3x4_Single_0;

		// Token: 0x040013AF RID: 5039
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x4_Single_float3x4_0;

		// Token: 0x040013B0 RID: 5040
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_float3x4_float3x4_0;

		// Token: 0x040013B1 RID: 5041
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryPlus_Public_Static_float3x4_float3x4_0;

		// Token: 0x040013B2 RID: 5042
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3x4_float3x4_float3x4_0;

		// Token: 0x040013B3 RID: 5043
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3x4_float3x4_Single_0;

		// Token: 0x040013B4 RID: 5044
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3x4_Single_float3x4_0;

		// Token: 0x040013B5 RID: 5045
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x4_float3x4_float3x4_0;

		// Token: 0x040013B6 RID: 5046
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x4_float3x4_Single_0;

		// Token: 0x040013B7 RID: 5047
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x4_Single_float3x4_0;

		// Token: 0x040013B8 RID: 5048
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_float3_Int32_0;

		// Token: 0x040013B9 RID: 5049
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_float3x4_0;

		// Token: 0x040013BA RID: 5050
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040013BB RID: 5051
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040013BC RID: 5052
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040013BD RID: 5053
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x040013BE RID: 5054
		[FieldOffset(0)]
		public float3 c0;

		// Token: 0x040013BF RID: 5055
		[FieldOffset(12)]
		public float3 c1;

		// Token: 0x040013C0 RID: 5056
		[FieldOffset(24)]
		public float3 c2;

		// Token: 0x040013C1 RID: 5057
		[FieldOffset(36)]
		public float3 c3;
	}
}
