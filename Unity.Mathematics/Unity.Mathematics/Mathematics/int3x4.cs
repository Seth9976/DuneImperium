using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x02000034 RID: 52
	[Serializable]
	[StructLayout(2)]
	public struct int3x4
	{
		// Token: 0x06001BB1 RID: 7089 RVA: 0x000911E4 File Offset: 0x0008F3E4
		// Note: this type is marked as 'beforefieldinit'.
		static int3x4()
		{
			Il2CppClassPointerStore<int3x4>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "int3x4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<int3x4>.NativeClassPtr);
			int3x4.NativeFieldInfoPtr_c0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int3x4>.NativeClassPtr, "c0");
			int3x4.NativeFieldInfoPtr_c1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int3x4>.NativeClassPtr, "c1");
			int3x4.NativeFieldInfoPtr_c2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int3x4>.NativeClassPtr, "c2");
			int3x4.NativeFieldInfoPtr_c3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int3x4>.NativeClassPtr, "c3");
			int3x4.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int3x4>.NativeClassPtr, "zero");
			int3x4.NativeMethodInfoPtr__ctor_Public_Void_int3_int3_int3_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670178);
			int3x4.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670179);
			int3x4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670180);
			int3x4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670181);
			int3x4.NativeMethodInfoPtr__ctor_Public_Void_bool3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670182);
			int3x4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670183);
			int3x4.NativeMethodInfoPtr__ctor_Public_Void_uint3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670184);
			int3x4.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670185);
			int3x4.NativeMethodInfoPtr__ctor_Public_Void_float3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670186);
			int3x4.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670187);
			int3x4.NativeMethodInfoPtr__ctor_Public_Void_double3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670188);
			int3x4.NativeMethodInfoPtr_op_Implicit_Public_Static_int3x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670189);
			int3x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670190);
			int3x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x4_bool3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670191);
			int3x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670192);
			int3x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x4_uint3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670193);
			int3x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670194);
			int3x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x4_float3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670195);
			int3x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670196);
			int3x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x4_double3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670197);
			int3x4.NativeMethodInfoPtr_op_Multiply_Public_Static_int3x4_int3x4_int3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670198);
			int3x4.NativeMethodInfoPtr_op_Multiply_Public_Static_int3x4_int3x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670199);
			int3x4.NativeMethodInfoPtr_op_Multiply_Public_Static_int3x4_Int32_int3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670200);
			int3x4.NativeMethodInfoPtr_op_Addition_Public_Static_int3x4_int3x4_int3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670201);
			int3x4.NativeMethodInfoPtr_op_Addition_Public_Static_int3x4_int3x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670202);
			int3x4.NativeMethodInfoPtr_op_Addition_Public_Static_int3x4_Int32_int3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670203);
			int3x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_int3x4_int3x4_int3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670204);
			int3x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_int3x4_int3x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670205);
			int3x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_int3x4_Int32_int3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670206);
			int3x4.NativeMethodInfoPtr_op_Division_Public_Static_int3x4_int3x4_int3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670207);
			int3x4.NativeMethodInfoPtr_op_Division_Public_Static_int3x4_int3x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670208);
			int3x4.NativeMethodInfoPtr_op_Division_Public_Static_int3x4_Int32_int3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670209);
			int3x4.NativeMethodInfoPtr_op_Modulus_Public_Static_int3x4_int3x4_int3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670210);
			int3x4.NativeMethodInfoPtr_op_Modulus_Public_Static_int3x4_int3x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670211);
			int3x4.NativeMethodInfoPtr_op_Modulus_Public_Static_int3x4_Int32_int3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670212);
			int3x4.NativeMethodInfoPtr_op_Increment_Public_Static_int3x4_int3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670213);
			int3x4.NativeMethodInfoPtr_op_Decrement_Public_Static_int3x4_int3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670214);
			int3x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x4_int3x4_int3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670215);
			int3x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x4_int3x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670216);
			int3x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x4_Int32_int3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670217);
			int3x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x4_int3x4_int3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670218);
			int3x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x4_int3x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670219);
			int3x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x4_Int32_int3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670220);
			int3x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x4_int3x4_int3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670221);
			int3x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x4_int3x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670222);
			int3x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x4_Int32_int3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670223);
			int3x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x4_int3x4_int3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670224);
			int3x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x4_int3x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670225);
			int3x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x4_Int32_int3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670226);
			int3x4.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_int3x4_int3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670227);
			int3x4.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_int3x4_int3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670228);
			int3x4.NativeMethodInfoPtr_op_LeftShift_Public_Static_int3x4_int3x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670229);
			int3x4.NativeMethodInfoPtr_op_RightShift_Public_Static_int3x4_int3x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670230);
			int3x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x4_int3x4_int3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670231);
			int3x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x4_int3x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670232);
			int3x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x4_Int32_int3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670233);
			int3x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x4_int3x4_int3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670234);
			int3x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x4_int3x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670235);
			int3x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x4_Int32_int3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670236);
			int3x4.NativeMethodInfoPtr_op_OnesComplement_Public_Static_int3x4_int3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670237);
			int3x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int3x4_int3x4_int3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670238);
			int3x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int3x4_int3x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670239);
			int3x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int3x4_Int32_int3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670240);
			int3x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int3x4_int3x4_int3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670241);
			int3x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int3x4_int3x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670242);
			int3x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int3x4_Int32_int3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670243);
			int3x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int3x4_int3x4_int3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670244);
			int3x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int3x4_int3x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670245);
			int3x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int3x4_Int32_int3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670246);
			int3x4.NativeMethodInfoPtr_get_Item_Public_get_byref_int3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670247);
			int3x4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_int3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670248);
			int3x4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670249);
			int3x4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670250);
			int3x4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670251);
			int3x4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int3x4>.NativeClassPtr, 100670252);
		}

		// Token: 0x06001BB2 RID: 7090 RVA: 0x00091854 File Offset: 0x0008FA54
		[CallerCount(0)]
		public unsafe int3x4(int3 c0, int3 c1, int3 c2, int3 c3)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr__ctor_Public_Void_int3_int3_int3_int3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BB3 RID: 7091 RVA: 0x000918B0 File Offset: 0x0008FAB0
		[CallerCount(0)]
		public unsafe int3x4(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13, int m20, int m21, int m22, int m23)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x00091980 File Offset: 0x0008FB80
		[CallerCount(0)]
		public unsafe int3x4(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BB5 RID: 7093 RVA: 0x000919B4 File Offset: 0x0008FBB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 639588, RefRangeEnd = 639590, XrefRangeStart = 639588, XrefRangeEnd = 639588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int3x4(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BB6 RID: 7094 RVA: 0x000919E8 File Offset: 0x0008FBE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 639590, RefRangeEnd = 639592, XrefRangeStart = 639590, XrefRangeEnd = 639590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int3x4(bool3x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr__ctor_Public_Void_bool3x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BB7 RID: 7095 RVA: 0x00091A1C File Offset: 0x0008FC1C
		[CallerCount(0)]
		public unsafe int3x4(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BB8 RID: 7096 RVA: 0x00091A50 File Offset: 0x0008FC50
		[CallerCount(0)]
		public unsafe int3x4(uint3x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr__ctor_Public_Void_uint3x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BB9 RID: 7097 RVA: 0x00091A84 File Offset: 0x0008FC84
		[CallerCount(0)]
		public unsafe int3x4(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BBA RID: 7098 RVA: 0x00091AB8 File Offset: 0x0008FCB8
		[CallerCount(0)]
		public unsafe int3x4(float3x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr__ctor_Public_Void_float3x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BBB RID: 7099 RVA: 0x00091AEC File Offset: 0x0008FCEC
		[CallerCount(0)]
		public unsafe int3x4(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BBC RID: 7100 RVA: 0x00091B20 File Offset: 0x0008FD20
		[CallerCount(0)]
		public unsafe int3x4(double3x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr__ctor_Public_Void_double3x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BBD RID: 7101 RVA: 0x00091B54 File Offset: 0x0008FD54
		[CallerCount(0)]
		public unsafe static implicit operator int3x4(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_Implicit_Public_Static_int3x4_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x00091B94 File Offset: 0x0008FD94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639592, XrefRangeEnd = 639593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator int3x4(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x4_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BBF RID: 7103 RVA: 0x00091BD4 File Offset: 0x0008FDD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639593, XrefRangeEnd = 639594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator int3x4(bool3x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x4_bool3x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BC0 RID: 7104 RVA: 0x00091C14 File Offset: 0x0008FE14
		[CallerCount(0)]
		public unsafe static explicit operator int3x4(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BC1 RID: 7105 RVA: 0x00091C54 File Offset: 0x0008FE54
		[CallerCount(0)]
		public unsafe static explicit operator int3x4(uint3x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x4_uint3x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BC2 RID: 7106 RVA: 0x00091C94 File Offset: 0x0008FE94
		[CallerCount(0)]
		public unsafe static explicit operator int3x4(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x4_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BC3 RID: 7107 RVA: 0x00091CD4 File Offset: 0x0008FED4
		[CallerCount(0)]
		public unsafe static explicit operator int3x4(float3x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x4_float3x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BC4 RID: 7108 RVA: 0x00091D14 File Offset: 0x0008FF14
		[CallerCount(0)]
		public unsafe static explicit operator int3x4(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x4_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BC5 RID: 7109 RVA: 0x00091D54 File Offset: 0x0008FF54
		[CallerCount(0)]
		public unsafe static explicit operator int3x4(double3x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int3x4_double3x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BC6 RID: 7110 RVA: 0x00091D94 File Offset: 0x0008FF94
		[CallerCount(0)]
		public unsafe static int3x4 operator *(int3x4 lhs, int3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_Multiply_Public_Static_int3x4_int3x4_int3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BC7 RID: 7111 RVA: 0x00091DE0 File Offset: 0x0008FFE0
		[CallerCount(0)]
		public unsafe static int3x4 operator *(int3x4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_Multiply_Public_Static_int3x4_int3x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BC8 RID: 7112 RVA: 0x00091E2C File Offset: 0x0009002C
		[CallerCount(0)]
		public unsafe static int3x4 operator *(int lhs, int3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_Multiply_Public_Static_int3x4_Int32_int3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BC9 RID: 7113 RVA: 0x00091E78 File Offset: 0x00090078
		[CallerCount(0)]
		public unsafe static int3x4 operator +(int3x4 lhs, int3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_Addition_Public_Static_int3x4_int3x4_int3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x00091EC4 File Offset: 0x000900C4
		[CallerCount(0)]
		public unsafe static int3x4 operator +(int3x4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_Addition_Public_Static_int3x4_int3x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x00091F10 File Offset: 0x00090110
		[CallerCount(0)]
		public unsafe static int3x4 operator +(int lhs, int3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_Addition_Public_Static_int3x4_Int32_int3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x00091F5C File Offset: 0x0009015C
		[CallerCount(0)]
		public unsafe static int3x4 operator -(int3x4 lhs, int3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_int3x4_int3x4_int3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x00091FA8 File Offset: 0x000901A8
		[CallerCount(0)]
		public unsafe static int3x4 operator -(int3x4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_int3x4_int3x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x00091FF4 File Offset: 0x000901F4
		[CallerCount(0)]
		public unsafe static int3x4 operator -(int lhs, int3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_int3x4_Int32_int3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x00092040 File Offset: 0x00090240
		[CallerCount(0)]
		public unsafe static int3x4 operator /(int3x4 lhs, int3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_Division_Public_Static_int3x4_int3x4_int3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BD0 RID: 7120 RVA: 0x0009208C File Offset: 0x0009028C
		[CallerCount(0)]
		public unsafe static int3x4 operator /(int3x4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_Division_Public_Static_int3x4_int3x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x000920D8 File Offset: 0x000902D8
		[CallerCount(0)]
		public unsafe static int3x4 operator /(int lhs, int3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_Division_Public_Static_int3x4_Int32_int3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x00092124 File Offset: 0x00090324
		[CallerCount(0)]
		public unsafe static int3x4 operator %(int3x4 lhs, int3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_Modulus_Public_Static_int3x4_int3x4_int3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x00092170 File Offset: 0x00090370
		[CallerCount(0)]
		public unsafe static int3x4 operator %(int3x4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_Modulus_Public_Static_int3x4_int3x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x000921BC File Offset: 0x000903BC
		[CallerCount(0)]
		public unsafe static int3x4 operator %(int lhs, int3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_Modulus_Public_Static_int3x4_Int32_int3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x00092208 File Offset: 0x00090408
		[CallerCount(0)]
		public unsafe static int3x4 operator ++(int3x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_Increment_Public_Static_int3x4_int3x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BD6 RID: 7126 RVA: 0x00092248 File Offset: 0x00090448
		[CallerCount(0)]
		public unsafe static int3x4 operator --(int3x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_Decrement_Public_Static_int3x4_int3x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x00092288 File Offset: 0x00090488
		[CallerCount(0)]
		public unsafe static bool3x4 operator <(int3x4 lhs, int3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x4_int3x4_int3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x000922D4 File Offset: 0x000904D4
		[CallerCount(0)]
		public unsafe static bool3x4 operator <(int3x4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x4_int3x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x00092320 File Offset: 0x00090520
		[CallerCount(0)]
		public unsafe static bool3x4 operator <(int lhs, int3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x4_Int32_int3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BDA RID: 7130 RVA: 0x0009236C File Offset: 0x0009056C
		[CallerCount(0)]
		public unsafe static bool3x4 operator <=(int3x4 lhs, int3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x4_int3x4_int3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BDB RID: 7131 RVA: 0x000923B8 File Offset: 0x000905B8
		[CallerCount(0)]
		public unsafe static bool3x4 operator <=(int3x4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x4_int3x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BDC RID: 7132 RVA: 0x00092404 File Offset: 0x00090604
		[CallerCount(0)]
		public unsafe static bool3x4 operator <=(int lhs, int3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x4_Int32_int3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BDD RID: 7133 RVA: 0x00092450 File Offset: 0x00090650
		[CallerCount(0)]
		public unsafe static bool3x4 operator >(int3x4 lhs, int3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x4_int3x4_int3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BDE RID: 7134 RVA: 0x0009249C File Offset: 0x0009069C
		[CallerCount(0)]
		public unsafe static bool3x4 operator >(int3x4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x4_int3x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BDF RID: 7135 RVA: 0x000924E8 File Offset: 0x000906E8
		[CallerCount(0)]
		public unsafe static bool3x4 operator >(int lhs, int3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x4_Int32_int3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BE0 RID: 7136 RVA: 0x00092534 File Offset: 0x00090734
		[CallerCount(0)]
		public unsafe static bool3x4 operator >=(int3x4 lhs, int3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x4_int3x4_int3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BE1 RID: 7137 RVA: 0x00092580 File Offset: 0x00090780
		[CallerCount(0)]
		public unsafe static bool3x4 operator >=(int3x4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x4_int3x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BE2 RID: 7138 RVA: 0x000925CC File Offset: 0x000907CC
		[CallerCount(0)]
		public unsafe static bool3x4 operator >=(int lhs, int3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x4_Int32_int3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BE3 RID: 7139 RVA: 0x00092618 File Offset: 0x00090818
		[CallerCount(0)]
		public unsafe static int3x4 operator -(int3x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_int3x4_int3x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BE4 RID: 7140 RVA: 0x00092658 File Offset: 0x00090858
		[CallerCount(0)]
		public unsafe static int3x4 operator +(int3x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_int3x4_int3x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BE5 RID: 7141 RVA: 0x00092698 File Offset: 0x00090898
		[CallerCount(0)]
		public unsafe static int3x4 operator <<(int3x4 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_LeftShift_Public_Static_int3x4_int3x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BE6 RID: 7142 RVA: 0x000926E4 File Offset: 0x000908E4
		[CallerCount(0)]
		public unsafe static int3x4 operator >>(int3x4 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_RightShift_Public_Static_int3x4_int3x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BE7 RID: 7143 RVA: 0x00092730 File Offset: 0x00090930
		[CallerCount(0)]
		public unsafe static bool3x4 operator ==(int3x4 lhs, int3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x4_int3x4_int3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BE8 RID: 7144 RVA: 0x0009277C File Offset: 0x0009097C
		[CallerCount(0)]
		public unsafe static bool3x4 operator ==(int3x4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x4_int3x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BE9 RID: 7145 RVA: 0x000927C8 File Offset: 0x000909C8
		[CallerCount(0)]
		public unsafe static bool3x4 operator ==(int lhs, int3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x4_Int32_int3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BEA RID: 7146 RVA: 0x00092814 File Offset: 0x00090A14
		[CallerCount(0)]
		public unsafe static bool3x4 operator !=(int3x4 lhs, int3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x4_int3x4_int3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BEB RID: 7147 RVA: 0x00092860 File Offset: 0x00090A60
		[CallerCount(0)]
		public unsafe static bool3x4 operator !=(int3x4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x4_int3x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BEC RID: 7148 RVA: 0x000928AC File Offset: 0x00090AAC
		[CallerCount(0)]
		public unsafe static bool3x4 operator !=(int lhs, int3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x4_Int32_int3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BED RID: 7149 RVA: 0x000928F8 File Offset: 0x00090AF8
		[CallerCount(0)]
		public unsafe static int3x4 operator ~(int3x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_OnesComplement_Public_Static_int3x4_int3x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BEE RID: 7150 RVA: 0x00092938 File Offset: 0x00090B38
		[CallerCount(0)]
		public unsafe static int3x4 operator &(int3x4 lhs, int3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int3x4_int3x4_int3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BEF RID: 7151 RVA: 0x00092984 File Offset: 0x00090B84
		[CallerCount(0)]
		public unsafe static int3x4 operator &(int3x4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int3x4_int3x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BF0 RID: 7152 RVA: 0x000929D0 File Offset: 0x00090BD0
		[CallerCount(0)]
		public unsafe static int3x4 operator &(int lhs, int3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int3x4_Int32_int3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BF1 RID: 7153 RVA: 0x00092A1C File Offset: 0x00090C1C
		[CallerCount(0)]
		public unsafe static int3x4 operator |(int3x4 lhs, int3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int3x4_int3x4_int3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x00092A68 File Offset: 0x00090C68
		[CallerCount(0)]
		public unsafe static int3x4 operator |(int3x4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int3x4_int3x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BF3 RID: 7155 RVA: 0x00092AB4 File Offset: 0x00090CB4
		[CallerCount(0)]
		public unsafe static int3x4 operator |(int lhs, int3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int3x4_Int32_int3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BF4 RID: 7156 RVA: 0x00092B00 File Offset: 0x00090D00
		[CallerCount(0)]
		public unsafe static int3x4 operator ^(int3x4 lhs, int3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int3x4_int3x4_int3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x00092B4C File Offset: 0x00090D4C
		[CallerCount(0)]
		public unsafe static int3x4 operator ^(int3x4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int3x4_int3x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x00092B98 File Offset: 0x00090D98
		[CallerCount(0)]
		public unsafe static int3x4 operator ^(int lhs, int3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int3x4_Int32_int3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700088A RID: 2186
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_get_Item_Public_get_byref_int3_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x00092C18 File Offset: 0x00090E18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 639594, RefRangeEnd = 639596, XrefRangeStart = 639594, XrefRangeEnd = 639594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(int3x4 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_int3x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x00092C58 File Offset: 0x00090E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639596, XrefRangeEnd = 639600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x00092C9C File Offset: 0x00090E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639600, XrefRangeEnd = 639601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BFB RID: 7163 RVA: 0x00092CCC File Offset: 0x00090ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639601, XrefRangeEnd = 639656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001BFC RID: 7164 RVA: 0x00092CF8 File Offset: 0x00090EF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639656, XrefRangeEnd = 639724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int3x4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x00002780 File Offset: 0x00000980
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<int3x4>.NativeClassPtr, ref this));
		}

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x06001BFE RID: 7166 RVA: 0x00092D48 File Offset: 0x00090F48
		// (set) Token: 0x06001BFF RID: 7167 RVA: 0x00002792 File Offset: 0x00000992
		public unsafe static int3x4 zero
		{
			get
			{
				int3x4 int3x;
				IL2CPP.il2cpp_field_static_get_value(int3x4.NativeFieldInfoPtr_zero, (void*)(&int3x));
				return int3x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(int3x4.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x04001C1E RID: 7198
		private static readonly IntPtr NativeFieldInfoPtr_c0;

		// Token: 0x04001C1F RID: 7199
		private static readonly IntPtr NativeFieldInfoPtr_c1;

		// Token: 0x04001C20 RID: 7200
		private static readonly IntPtr NativeFieldInfoPtr_c2;

		// Token: 0x04001C21 RID: 7201
		private static readonly IntPtr NativeFieldInfoPtr_c3;

		// Token: 0x04001C22 RID: 7202
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x04001C23 RID: 7203
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int3_int3_int3_int3_0;

		// Token: 0x04001C24 RID: 7204
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x04001C25 RID: 7205
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001C26 RID: 7206
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04001C27 RID: 7207
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool3x4_0;

		// Token: 0x04001C28 RID: 7208
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04001C29 RID: 7209
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint3x4_0;

		// Token: 0x04001C2A RID: 7210
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x04001C2B RID: 7211
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float3x4_0;

		// Token: 0x04001C2C RID: 7212
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x04001C2D RID: 7213
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double3x4_0;

		// Token: 0x04001C2E RID: 7214
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_int3x4_Int32_0;

		// Token: 0x04001C2F RID: 7215
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int3x4_Boolean_0;

		// Token: 0x04001C30 RID: 7216
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int3x4_bool3x4_0;

		// Token: 0x04001C31 RID: 7217
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int3x4_UInt32_0;

		// Token: 0x04001C32 RID: 7218
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int3x4_uint3x4_0;

		// Token: 0x04001C33 RID: 7219
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int3x4_Single_0;

		// Token: 0x04001C34 RID: 7220
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int3x4_float3x4_0;

		// Token: 0x04001C35 RID: 7221
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int3x4_Double_0;

		// Token: 0x04001C36 RID: 7222
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int3x4_double3x4_0;

		// Token: 0x04001C37 RID: 7223
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_int3x4_int3x4_int3x4_0;

		// Token: 0x04001C38 RID: 7224
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_int3x4_int3x4_Int32_0;

		// Token: 0x04001C39 RID: 7225
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_int3x4_Int32_int3x4_0;

		// Token: 0x04001C3A RID: 7226
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_int3x4_int3x4_int3x4_0;

		// Token: 0x04001C3B RID: 7227
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_int3x4_int3x4_Int32_0;

		// Token: 0x04001C3C RID: 7228
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_int3x4_Int32_int3x4_0;

		// Token: 0x04001C3D RID: 7229
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_int3x4_int3x4_int3x4_0;

		// Token: 0x04001C3E RID: 7230
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_int3x4_int3x4_Int32_0;

		// Token: 0x04001C3F RID: 7231
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_int3x4_Int32_int3x4_0;

		// Token: 0x04001C40 RID: 7232
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_int3x4_int3x4_int3x4_0;

		// Token: 0x04001C41 RID: 7233
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_int3x4_int3x4_Int32_0;

		// Token: 0x04001C42 RID: 7234
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_int3x4_Int32_int3x4_0;

		// Token: 0x04001C43 RID: 7235
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_int3x4_int3x4_int3x4_0;

		// Token: 0x04001C44 RID: 7236
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_int3x4_int3x4_Int32_0;

		// Token: 0x04001C45 RID: 7237
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_int3x4_Int32_int3x4_0;

		// Token: 0x04001C46 RID: 7238
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_int3x4_int3x4_0;

		// Token: 0x04001C47 RID: 7239
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_int3x4_int3x4_0;

		// Token: 0x04001C48 RID: 7240
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x4_int3x4_int3x4_0;

		// Token: 0x04001C49 RID: 7241
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x4_int3x4_Int32_0;

		// Token: 0x04001C4A RID: 7242
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x4_Int32_int3x4_0;

		// Token: 0x04001C4B RID: 7243
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x4_int3x4_int3x4_0;

		// Token: 0x04001C4C RID: 7244
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x4_int3x4_Int32_0;

		// Token: 0x04001C4D RID: 7245
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x4_Int32_int3x4_0;

		// Token: 0x04001C4E RID: 7246
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x4_int3x4_int3x4_0;

		// Token: 0x04001C4F RID: 7247
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x4_int3x4_Int32_0;

		// Token: 0x04001C50 RID: 7248
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x4_Int32_int3x4_0;

		// Token: 0x04001C51 RID: 7249
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x4_int3x4_int3x4_0;

		// Token: 0x04001C52 RID: 7250
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x4_int3x4_Int32_0;

		// Token: 0x04001C53 RID: 7251
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x4_Int32_int3x4_0;

		// Token: 0x04001C54 RID: 7252
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_int3x4_int3x4_0;

		// Token: 0x04001C55 RID: 7253
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryPlus_Public_Static_int3x4_int3x4_0;

		// Token: 0x04001C56 RID: 7254
		private static readonly IntPtr NativeMethodInfoPtr_op_LeftShift_Public_Static_int3x4_int3x4_Int32_0;

		// Token: 0x04001C57 RID: 7255
		private static readonly IntPtr NativeMethodInfoPtr_op_RightShift_Public_Static_int3x4_int3x4_Int32_0;

		// Token: 0x04001C58 RID: 7256
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3x4_int3x4_int3x4_0;

		// Token: 0x04001C59 RID: 7257
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3x4_int3x4_Int32_0;

		// Token: 0x04001C5A RID: 7258
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3x4_Int32_int3x4_0;

		// Token: 0x04001C5B RID: 7259
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x4_int3x4_int3x4_0;

		// Token: 0x04001C5C RID: 7260
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x4_int3x4_Int32_0;

		// Token: 0x04001C5D RID: 7261
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x4_Int32_int3x4_0;

		// Token: 0x04001C5E RID: 7262
		private static readonly IntPtr NativeMethodInfoPtr_op_OnesComplement_Public_Static_int3x4_int3x4_0;

		// Token: 0x04001C5F RID: 7263
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int3x4_int3x4_int3x4_0;

		// Token: 0x04001C60 RID: 7264
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int3x4_int3x4_Int32_0;

		// Token: 0x04001C61 RID: 7265
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int3x4_Int32_int3x4_0;

		// Token: 0x04001C62 RID: 7266
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int3x4_int3x4_int3x4_0;

		// Token: 0x04001C63 RID: 7267
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int3x4_int3x4_Int32_0;

		// Token: 0x04001C64 RID: 7268
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int3x4_Int32_int3x4_0;

		// Token: 0x04001C65 RID: 7269
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int3x4_int3x4_int3x4_0;

		// Token: 0x04001C66 RID: 7270
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int3x4_int3x4_Int32_0;

		// Token: 0x04001C67 RID: 7271
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int3x4_Int32_int3x4_0;

		// Token: 0x04001C68 RID: 7272
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_int3_Int32_0;

		// Token: 0x04001C69 RID: 7273
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_int3x4_0;

		// Token: 0x04001C6A RID: 7274
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001C6B RID: 7275
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001C6C RID: 7276
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001C6D RID: 7277
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04001C6E RID: 7278
		[FieldOffset(0)]
		public int3 c0;

		// Token: 0x04001C6F RID: 7279
		[FieldOffset(12)]
		public int3 c1;

		// Token: 0x04001C70 RID: 7280
		[FieldOffset(24)]
		public int3 c2;

		// Token: 0x04001C71 RID: 7281
		[FieldOffset(36)]
		public int3 c3;
	}
}
