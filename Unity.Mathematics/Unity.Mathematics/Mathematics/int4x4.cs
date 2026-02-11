using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x02000038 RID: 56
	[Serializable]
	[StructLayout(2)]
	public struct int4x4
	{
		// Token: 0x06001E80 RID: 7808 RVA: 0x0009EB50 File Offset: 0x0009CD50
		// Note: this type is marked as 'beforefieldinit'.
		static int4x4()
		{
			Il2CppClassPointerStore<int4x4>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "int4x4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<int4x4>.NativeClassPtr);
			int4x4.NativeFieldInfoPtr_c0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int4x4>.NativeClassPtr, "c0");
			int4x4.NativeFieldInfoPtr_c1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int4x4>.NativeClassPtr, "c1");
			int4x4.NativeFieldInfoPtr_c2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int4x4>.NativeClassPtr, "c2");
			int4x4.NativeFieldInfoPtr_c3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int4x4>.NativeClassPtr, "c3");
			int4x4.NativeFieldInfoPtr_identity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int4x4>.NativeClassPtr, "identity");
			int4x4.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int4x4>.NativeClassPtr, "zero");
			int4x4.NativeMethodInfoPtr__ctor_Public_Void_int4_int4_int4_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670882);
			int4x4.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670883);
			int4x4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670884);
			int4x4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670885);
			int4x4.NativeMethodInfoPtr__ctor_Public_Void_bool4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670886);
			int4x4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670887);
			int4x4.NativeMethodInfoPtr__ctor_Public_Void_uint4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670888);
			int4x4.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670889);
			int4x4.NativeMethodInfoPtr__ctor_Public_Void_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670890);
			int4x4.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670891);
			int4x4.NativeMethodInfoPtr__ctor_Public_Void_double4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670892);
			int4x4.NativeMethodInfoPtr_op_Implicit_Public_Static_int4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670893);
			int4x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670894);
			int4x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x4_bool4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670895);
			int4x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670896);
			int4x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x4_uint4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670897);
			int4x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670898);
			int4x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x4_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670899);
			int4x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670900);
			int4x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x4_double4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670901);
			int4x4.NativeMethodInfoPtr_op_Multiply_Public_Static_int4x4_int4x4_int4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670902);
			int4x4.NativeMethodInfoPtr_op_Multiply_Public_Static_int4x4_int4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670903);
			int4x4.NativeMethodInfoPtr_op_Multiply_Public_Static_int4x4_Int32_int4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670904);
			int4x4.NativeMethodInfoPtr_op_Addition_Public_Static_int4x4_int4x4_int4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670905);
			int4x4.NativeMethodInfoPtr_op_Addition_Public_Static_int4x4_int4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670906);
			int4x4.NativeMethodInfoPtr_op_Addition_Public_Static_int4x4_Int32_int4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670907);
			int4x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_int4x4_int4x4_int4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670908);
			int4x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_int4x4_int4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670909);
			int4x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_int4x4_Int32_int4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670910);
			int4x4.NativeMethodInfoPtr_op_Division_Public_Static_int4x4_int4x4_int4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670911);
			int4x4.NativeMethodInfoPtr_op_Division_Public_Static_int4x4_int4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670912);
			int4x4.NativeMethodInfoPtr_op_Division_Public_Static_int4x4_Int32_int4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670913);
			int4x4.NativeMethodInfoPtr_op_Modulus_Public_Static_int4x4_int4x4_int4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670914);
			int4x4.NativeMethodInfoPtr_op_Modulus_Public_Static_int4x4_int4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670915);
			int4x4.NativeMethodInfoPtr_op_Modulus_Public_Static_int4x4_Int32_int4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670916);
			int4x4.NativeMethodInfoPtr_op_Increment_Public_Static_int4x4_int4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670917);
			int4x4.NativeMethodInfoPtr_op_Decrement_Public_Static_int4x4_int4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670918);
			int4x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x4_int4x4_int4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670919);
			int4x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x4_int4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670920);
			int4x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x4_Int32_int4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670921);
			int4x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x4_int4x4_int4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670922);
			int4x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x4_int4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670923);
			int4x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x4_Int32_int4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670924);
			int4x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x4_int4x4_int4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670925);
			int4x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x4_int4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670926);
			int4x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x4_Int32_int4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670927);
			int4x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x4_int4x4_int4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670928);
			int4x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x4_int4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670929);
			int4x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x4_Int32_int4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670930);
			int4x4.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_int4x4_int4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670931);
			int4x4.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_int4x4_int4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670932);
			int4x4.NativeMethodInfoPtr_op_LeftShift_Public_Static_int4x4_int4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670933);
			int4x4.NativeMethodInfoPtr_op_RightShift_Public_Static_int4x4_int4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670934);
			int4x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_int4x4_int4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670935);
			int4x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_int4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670936);
			int4x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_Int32_int4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670937);
			int4x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_int4x4_int4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670938);
			int4x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_int4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670939);
			int4x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_Int32_int4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670940);
			int4x4.NativeMethodInfoPtr_op_OnesComplement_Public_Static_int4x4_int4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670941);
			int4x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int4x4_int4x4_int4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670942);
			int4x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int4x4_int4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670943);
			int4x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int4x4_Int32_int4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670944);
			int4x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int4x4_int4x4_int4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670945);
			int4x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int4x4_int4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670946);
			int4x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int4x4_Int32_int4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670947);
			int4x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int4x4_int4x4_int4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670948);
			int4x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int4x4_int4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670949);
			int4x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int4x4_Int32_int4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670950);
			int4x4.NativeMethodInfoPtr_get_Item_Public_get_byref_int4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670951);
			int4x4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_int4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670952);
			int4x4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670953);
			int4x4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670954);
			int4x4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670955);
			int4x4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x4>.NativeClassPtr, 100670956);
		}

		// Token: 0x06001E81 RID: 7809 RVA: 0x0009F1D4 File Offset: 0x0009D3D4
		[CallerCount(0)]
		public unsafe int4x4(int4 c0, int4 c1, int4 c2, int4 c3)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr__ctor_Public_Void_int4_int4_int4_int4_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E82 RID: 7810 RVA: 0x0009F230 File Offset: 0x0009D430
		[CallerCount(0)]
		public unsafe int4x4(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13, int m20, int m21, int m22, int m23, int m30, int m31, int m32, int m33)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E83 RID: 7811 RVA: 0x0009F33C File Offset: 0x0009D53C
		[CallerCount(0)]
		public unsafe int4x4(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E84 RID: 7812 RVA: 0x0009F370 File Offset: 0x0009D570
		[CallerCount(0)]
		public unsafe int4x4(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E85 RID: 7813 RVA: 0x0009F3A4 File Offset: 0x0009D5A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 640017, RefRangeEnd = 640019, XrefRangeStart = 640017, XrefRangeEnd = 640017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int4x4(bool4x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr__ctor_Public_Void_bool4x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E86 RID: 7814 RVA: 0x0009F3D8 File Offset: 0x0009D5D8
		[CallerCount(0)]
		public unsafe int4x4(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E87 RID: 7815 RVA: 0x0009F40C File Offset: 0x0009D60C
		[CallerCount(0)]
		public unsafe int4x4(uint4x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr__ctor_Public_Void_uint4x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E88 RID: 7816 RVA: 0x0009F440 File Offset: 0x0009D640
		[CallerCount(0)]
		public unsafe int4x4(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E89 RID: 7817 RVA: 0x0009F474 File Offset: 0x0009D674
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 640019, RefRangeEnd = 640020, XrefRangeStart = 640019, XrefRangeEnd = 640019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int4x4(float4x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr__ctor_Public_Void_float4x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E8A RID: 7818 RVA: 0x0009F4A8 File Offset: 0x0009D6A8
		[CallerCount(0)]
		public unsafe int4x4(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E8B RID: 7819 RVA: 0x0009F4DC File Offset: 0x0009D6DC
		[CallerCount(0)]
		public unsafe int4x4(double4x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr__ctor_Public_Void_double4x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E8C RID: 7820 RVA: 0x0009F510 File Offset: 0x0009D710
		[CallerCount(0)]
		public unsafe static implicit operator int4x4(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_Implicit_Public_Static_int4x4_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E8D RID: 7821 RVA: 0x0009F550 File Offset: 0x0009D750
		[CallerCount(0)]
		public unsafe static explicit operator int4x4(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x4_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E8E RID: 7822 RVA: 0x0009F590 File Offset: 0x0009D790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 640020, XrefRangeEnd = 640021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator int4x4(bool4x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x4_bool4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E8F RID: 7823 RVA: 0x0009F5D0 File Offset: 0x0009D7D0
		[CallerCount(0)]
		public unsafe static explicit operator int4x4(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E90 RID: 7824 RVA: 0x0009F610 File Offset: 0x0009D810
		[CallerCount(0)]
		public unsafe static explicit operator int4x4(uint4x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x4_uint4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E91 RID: 7825 RVA: 0x0009F650 File Offset: 0x0009D850
		[CallerCount(0)]
		public unsafe static explicit operator int4x4(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x4_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E92 RID: 7826 RVA: 0x0009F690 File Offset: 0x0009D890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 640021, XrefRangeEnd = 640022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator int4x4(float4x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x4_float4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E93 RID: 7827 RVA: 0x0009F6D0 File Offset: 0x0009D8D0
		[CallerCount(0)]
		public unsafe static explicit operator int4x4(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x4_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E94 RID: 7828 RVA: 0x0009F710 File Offset: 0x0009D910
		[CallerCount(0)]
		public unsafe static explicit operator int4x4(double4x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x4_double4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E95 RID: 7829 RVA: 0x0009F750 File Offset: 0x0009D950
		[CallerCount(0)]
		public unsafe static int4x4 operator *(int4x4 lhs, int4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_Multiply_Public_Static_int4x4_int4x4_int4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E96 RID: 7830 RVA: 0x0009F79C File Offset: 0x0009D99C
		[CallerCount(0)]
		public unsafe static int4x4 operator *(int4x4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_Multiply_Public_Static_int4x4_int4x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E97 RID: 7831 RVA: 0x0009F7E8 File Offset: 0x0009D9E8
		[CallerCount(0)]
		public unsafe static int4x4 operator *(int lhs, int4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_Multiply_Public_Static_int4x4_Int32_int4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E98 RID: 7832 RVA: 0x0009F834 File Offset: 0x0009DA34
		[CallerCount(0)]
		public unsafe static int4x4 operator +(int4x4 lhs, int4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_Addition_Public_Static_int4x4_int4x4_int4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x0009F880 File Offset: 0x0009DA80
		[CallerCount(0)]
		public unsafe static int4x4 operator +(int4x4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_Addition_Public_Static_int4x4_int4x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E9A RID: 7834 RVA: 0x0009F8CC File Offset: 0x0009DACC
		[CallerCount(0)]
		public unsafe static int4x4 operator +(int lhs, int4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_Addition_Public_Static_int4x4_Int32_int4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E9B RID: 7835 RVA: 0x0009F918 File Offset: 0x0009DB18
		[CallerCount(0)]
		public unsafe static int4x4 operator -(int4x4 lhs, int4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_int4x4_int4x4_int4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E9C RID: 7836 RVA: 0x0009F964 File Offset: 0x0009DB64
		[CallerCount(0)]
		public unsafe static int4x4 operator -(int4x4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_int4x4_int4x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E9D RID: 7837 RVA: 0x0009F9B0 File Offset: 0x0009DBB0
		[CallerCount(0)]
		public unsafe static int4x4 operator -(int lhs, int4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_int4x4_Int32_int4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E9E RID: 7838 RVA: 0x0009F9FC File Offset: 0x0009DBFC
		[CallerCount(0)]
		public unsafe static int4x4 operator /(int4x4 lhs, int4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_Division_Public_Static_int4x4_int4x4_int4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E9F RID: 7839 RVA: 0x0009FA48 File Offset: 0x0009DC48
		[CallerCount(0)]
		public unsafe static int4x4 operator /(int4x4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_Division_Public_Static_int4x4_int4x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EA0 RID: 7840 RVA: 0x0009FA94 File Offset: 0x0009DC94
		[CallerCount(0)]
		public unsafe static int4x4 operator /(int lhs, int4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_Division_Public_Static_int4x4_Int32_int4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EA1 RID: 7841 RVA: 0x0009FAE0 File Offset: 0x0009DCE0
		[CallerCount(0)]
		public unsafe static int4x4 operator %(int4x4 lhs, int4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_Modulus_Public_Static_int4x4_int4x4_int4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EA2 RID: 7842 RVA: 0x0009FB2C File Offset: 0x0009DD2C
		[CallerCount(0)]
		public unsafe static int4x4 operator %(int4x4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_Modulus_Public_Static_int4x4_int4x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EA3 RID: 7843 RVA: 0x0009FB78 File Offset: 0x0009DD78
		[CallerCount(0)]
		public unsafe static int4x4 operator %(int lhs, int4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_Modulus_Public_Static_int4x4_Int32_int4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EA4 RID: 7844 RVA: 0x0009FBC4 File Offset: 0x0009DDC4
		[CallerCount(0)]
		public unsafe static int4x4 operator ++(int4x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_Increment_Public_Static_int4x4_int4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EA5 RID: 7845 RVA: 0x0009FC04 File Offset: 0x0009DE04
		[CallerCount(0)]
		public unsafe static int4x4 operator --(int4x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_Decrement_Public_Static_int4x4_int4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EA6 RID: 7846 RVA: 0x0009FC44 File Offset: 0x0009DE44
		[CallerCount(0)]
		public unsafe static bool4x4 operator <(int4x4 lhs, int4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x4_int4x4_int4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EA7 RID: 7847 RVA: 0x0009FC90 File Offset: 0x0009DE90
		[CallerCount(0)]
		public unsafe static bool4x4 operator <(int4x4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x4_int4x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EA8 RID: 7848 RVA: 0x0009FCDC File Offset: 0x0009DEDC
		[CallerCount(0)]
		public unsafe static bool4x4 operator <(int lhs, int4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x4_Int32_int4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EA9 RID: 7849 RVA: 0x0009FD28 File Offset: 0x0009DF28
		[CallerCount(0)]
		public unsafe static bool4x4 operator <=(int4x4 lhs, int4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x4_int4x4_int4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EAA RID: 7850 RVA: 0x0009FD74 File Offset: 0x0009DF74
		[CallerCount(0)]
		public unsafe static bool4x4 operator <=(int4x4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x4_int4x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EAB RID: 7851 RVA: 0x0009FDC0 File Offset: 0x0009DFC0
		[CallerCount(0)]
		public unsafe static bool4x4 operator <=(int lhs, int4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x4_Int32_int4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EAC RID: 7852 RVA: 0x0009FE0C File Offset: 0x0009E00C
		[CallerCount(0)]
		public unsafe static bool4x4 operator >(int4x4 lhs, int4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x4_int4x4_int4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EAD RID: 7853 RVA: 0x0009FE58 File Offset: 0x0009E058
		[CallerCount(0)]
		public unsafe static bool4x4 operator >(int4x4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x4_int4x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EAE RID: 7854 RVA: 0x0009FEA4 File Offset: 0x0009E0A4
		[CallerCount(0)]
		public unsafe static bool4x4 operator >(int lhs, int4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x4_Int32_int4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EAF RID: 7855 RVA: 0x0009FEF0 File Offset: 0x0009E0F0
		[CallerCount(0)]
		public unsafe static bool4x4 operator >=(int4x4 lhs, int4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x4_int4x4_int4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EB0 RID: 7856 RVA: 0x0009FF3C File Offset: 0x0009E13C
		[CallerCount(0)]
		public unsafe static bool4x4 operator >=(int4x4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x4_int4x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EB1 RID: 7857 RVA: 0x0009FF88 File Offset: 0x0009E188
		[CallerCount(0)]
		public unsafe static bool4x4 operator >=(int lhs, int4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x4_Int32_int4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EB2 RID: 7858 RVA: 0x0009FFD4 File Offset: 0x0009E1D4
		[CallerCount(0)]
		public unsafe static int4x4 operator -(int4x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_int4x4_int4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EB3 RID: 7859 RVA: 0x000A0014 File Offset: 0x0009E214
		[CallerCount(0)]
		public unsafe static int4x4 operator +(int4x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_int4x4_int4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EB4 RID: 7860 RVA: 0x000A0054 File Offset: 0x0009E254
		[CallerCount(0)]
		public unsafe static int4x4 operator <<(int4x4 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_LeftShift_Public_Static_int4x4_int4x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EB5 RID: 7861 RVA: 0x000A00A0 File Offset: 0x0009E2A0
		[CallerCount(0)]
		public unsafe static int4x4 operator >>(int4x4 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_RightShift_Public_Static_int4x4_int4x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EB6 RID: 7862 RVA: 0x000A00EC File Offset: 0x0009E2EC
		[CallerCount(0)]
		public unsafe static bool4x4 operator ==(int4x4 lhs, int4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_int4x4_int4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EB7 RID: 7863 RVA: 0x000A0138 File Offset: 0x0009E338
		[CallerCount(0)]
		public unsafe static bool4x4 operator ==(int4x4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_int4x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EB8 RID: 7864 RVA: 0x000A0184 File Offset: 0x0009E384
		[CallerCount(0)]
		public unsafe static bool4x4 operator ==(int lhs, int4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_Int32_int4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EB9 RID: 7865 RVA: 0x000A01D0 File Offset: 0x0009E3D0
		[CallerCount(0)]
		public unsafe static bool4x4 operator !=(int4x4 lhs, int4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_int4x4_int4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EBA RID: 7866 RVA: 0x000A021C File Offset: 0x0009E41C
		[CallerCount(0)]
		public unsafe static bool4x4 operator !=(int4x4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_int4x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EBB RID: 7867 RVA: 0x000A0268 File Offset: 0x0009E468
		[CallerCount(0)]
		public unsafe static bool4x4 operator !=(int lhs, int4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_Int32_int4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EBC RID: 7868 RVA: 0x000A02B4 File Offset: 0x0009E4B4
		[CallerCount(0)]
		public unsafe static int4x4 operator ~(int4x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_OnesComplement_Public_Static_int4x4_int4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x000A02F4 File Offset: 0x0009E4F4
		[CallerCount(0)]
		public unsafe static int4x4 operator &(int4x4 lhs, int4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int4x4_int4x4_int4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EBE RID: 7870 RVA: 0x000A0340 File Offset: 0x0009E540
		[CallerCount(0)]
		public unsafe static int4x4 operator &(int4x4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int4x4_int4x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EBF RID: 7871 RVA: 0x000A038C File Offset: 0x0009E58C
		[CallerCount(0)]
		public unsafe static int4x4 operator &(int lhs, int4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int4x4_Int32_int4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EC0 RID: 7872 RVA: 0x000A03D8 File Offset: 0x0009E5D8
		[CallerCount(0)]
		public unsafe static int4x4 operator |(int4x4 lhs, int4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int4x4_int4x4_int4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EC1 RID: 7873 RVA: 0x000A0424 File Offset: 0x0009E624
		[CallerCount(0)]
		public unsafe static int4x4 operator |(int4x4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int4x4_int4x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EC2 RID: 7874 RVA: 0x000A0470 File Offset: 0x0009E670
		[CallerCount(0)]
		public unsafe static int4x4 operator |(int lhs, int4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int4x4_Int32_int4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EC3 RID: 7875 RVA: 0x000A04BC File Offset: 0x0009E6BC
		[CallerCount(0)]
		public unsafe static int4x4 operator ^(int4x4 lhs, int4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int4x4_int4x4_int4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EC4 RID: 7876 RVA: 0x000A0508 File Offset: 0x0009E708
		[CallerCount(0)]
		public unsafe static int4x4 operator ^(int4x4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int4x4_int4x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EC5 RID: 7877 RVA: 0x000A0554 File Offset: 0x0009E754
		[CallerCount(0)]
		public unsafe static int4x4 operator ^(int lhs, int4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int4x4_Int32_int4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170009E3 RID: 2531
		public unsafe ref int4 this[int index]
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_get_Item_Public_get_byref_int4_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x06001EC7 RID: 7879 RVA: 0x000A05D4 File Offset: 0x0009E7D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 640022, RefRangeEnd = 640024, XrefRangeStart = 640022, XrefRangeEnd = 640022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(int4x4 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_int4x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EC8 RID: 7880 RVA: 0x000A0614 File Offset: 0x0009E814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 640024, XrefRangeEnd = 640028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EC9 RID: 7881 RVA: 0x000A0658 File Offset: 0x0009E858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 640028, XrefRangeEnd = 640029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001ECA RID: 7882 RVA: 0x000A0688 File Offset: 0x0009E888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 640029, XrefRangeEnd = 640100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001ECB RID: 7883 RVA: 0x000A06B4 File Offset: 0x0009E8B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 640100, XrefRangeEnd = 640188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001ECC RID: 7884 RVA: 0x00002800 File Offset: 0x00000A00
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<int4x4>.NativeClassPtr, ref this));
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x06001ECD RID: 7885 RVA: 0x000A0704 File Offset: 0x0009E904
		// (set) Token: 0x06001ECE RID: 7886 RVA: 0x00002812 File Offset: 0x00000A12
		public unsafe static int4x4 identity
		{
			get
			{
				int4x4 int4x;
				IL2CPP.il2cpp_field_static_get_value(int4x4.NativeFieldInfoPtr_identity, (void*)(&int4x));
				return int4x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(int4x4.NativeFieldInfoPtr_identity, (void*)(&value));
			}
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06001ECF RID: 7887 RVA: 0x000A0720 File Offset: 0x0009E920
		// (set) Token: 0x06001ED0 RID: 7888 RVA: 0x00002820 File Offset: 0x00000A20
		public unsafe static int4x4 zero
		{
			get
			{
				int4x4 int4x;
				IL2CPP.il2cpp_field_static_get_value(int4x4.NativeFieldInfoPtr_zero, (void*)(&int4x));
				return int4x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(int4x4.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x04001EFB RID: 7931
		private static readonly IntPtr NativeFieldInfoPtr_c0;

		// Token: 0x04001EFC RID: 7932
		private static readonly IntPtr NativeFieldInfoPtr_c1;

		// Token: 0x04001EFD RID: 7933
		private static readonly IntPtr NativeFieldInfoPtr_c2;

		// Token: 0x04001EFE RID: 7934
		private static readonly IntPtr NativeFieldInfoPtr_c3;

		// Token: 0x04001EFF RID: 7935
		private static readonly IntPtr NativeFieldInfoPtr_identity;

		// Token: 0x04001F00 RID: 7936
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x04001F01 RID: 7937
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int4_int4_int4_int4_0;

		// Token: 0x04001F02 RID: 7938
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x04001F03 RID: 7939
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001F04 RID: 7940
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04001F05 RID: 7941
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool4x4_0;

		// Token: 0x04001F06 RID: 7942
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04001F07 RID: 7943
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint4x4_0;

		// Token: 0x04001F08 RID: 7944
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x04001F09 RID: 7945
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float4x4_0;

		// Token: 0x04001F0A RID: 7946
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x04001F0B RID: 7947
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double4x4_0;

		// Token: 0x04001F0C RID: 7948
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_int4x4_Int32_0;

		// Token: 0x04001F0D RID: 7949
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int4x4_Boolean_0;

		// Token: 0x04001F0E RID: 7950
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int4x4_bool4x4_0;

		// Token: 0x04001F0F RID: 7951
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int4x4_UInt32_0;

		// Token: 0x04001F10 RID: 7952
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int4x4_uint4x4_0;

		// Token: 0x04001F11 RID: 7953
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int4x4_Single_0;

		// Token: 0x04001F12 RID: 7954
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int4x4_float4x4_0;

		// Token: 0x04001F13 RID: 7955
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int4x4_Double_0;

		// Token: 0x04001F14 RID: 7956
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int4x4_double4x4_0;

		// Token: 0x04001F15 RID: 7957
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_int4x4_int4x4_int4x4_0;

		// Token: 0x04001F16 RID: 7958
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_int4x4_int4x4_Int32_0;

		// Token: 0x04001F17 RID: 7959
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_int4x4_Int32_int4x4_0;

		// Token: 0x04001F18 RID: 7960
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_int4x4_int4x4_int4x4_0;

		// Token: 0x04001F19 RID: 7961
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_int4x4_int4x4_Int32_0;

		// Token: 0x04001F1A RID: 7962
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_int4x4_Int32_int4x4_0;

		// Token: 0x04001F1B RID: 7963
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_int4x4_int4x4_int4x4_0;

		// Token: 0x04001F1C RID: 7964
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_int4x4_int4x4_Int32_0;

		// Token: 0x04001F1D RID: 7965
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_int4x4_Int32_int4x4_0;

		// Token: 0x04001F1E RID: 7966
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_int4x4_int4x4_int4x4_0;

		// Token: 0x04001F1F RID: 7967
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_int4x4_int4x4_Int32_0;

		// Token: 0x04001F20 RID: 7968
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_int4x4_Int32_int4x4_0;

		// Token: 0x04001F21 RID: 7969
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_int4x4_int4x4_int4x4_0;

		// Token: 0x04001F22 RID: 7970
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_int4x4_int4x4_Int32_0;

		// Token: 0x04001F23 RID: 7971
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_int4x4_Int32_int4x4_0;

		// Token: 0x04001F24 RID: 7972
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_int4x4_int4x4_0;

		// Token: 0x04001F25 RID: 7973
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_int4x4_int4x4_0;

		// Token: 0x04001F26 RID: 7974
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x4_int4x4_int4x4_0;

		// Token: 0x04001F27 RID: 7975
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x4_int4x4_Int32_0;

		// Token: 0x04001F28 RID: 7976
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x4_Int32_int4x4_0;

		// Token: 0x04001F29 RID: 7977
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x4_int4x4_int4x4_0;

		// Token: 0x04001F2A RID: 7978
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x4_int4x4_Int32_0;

		// Token: 0x04001F2B RID: 7979
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x4_Int32_int4x4_0;

		// Token: 0x04001F2C RID: 7980
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x4_int4x4_int4x4_0;

		// Token: 0x04001F2D RID: 7981
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x4_int4x4_Int32_0;

		// Token: 0x04001F2E RID: 7982
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x4_Int32_int4x4_0;

		// Token: 0x04001F2F RID: 7983
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x4_int4x4_int4x4_0;

		// Token: 0x04001F30 RID: 7984
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x4_int4x4_Int32_0;

		// Token: 0x04001F31 RID: 7985
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x4_Int32_int4x4_0;

		// Token: 0x04001F32 RID: 7986
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_int4x4_int4x4_0;

		// Token: 0x04001F33 RID: 7987
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryPlus_Public_Static_int4x4_int4x4_0;

		// Token: 0x04001F34 RID: 7988
		private static readonly IntPtr NativeMethodInfoPtr_op_LeftShift_Public_Static_int4x4_int4x4_Int32_0;

		// Token: 0x04001F35 RID: 7989
		private static readonly IntPtr NativeMethodInfoPtr_op_RightShift_Public_Static_int4x4_int4x4_Int32_0;

		// Token: 0x04001F36 RID: 7990
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_int4x4_int4x4_0;

		// Token: 0x04001F37 RID: 7991
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_int4x4_Int32_0;

		// Token: 0x04001F38 RID: 7992
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_Int32_int4x4_0;

		// Token: 0x04001F39 RID: 7993
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_int4x4_int4x4_0;

		// Token: 0x04001F3A RID: 7994
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_int4x4_Int32_0;

		// Token: 0x04001F3B RID: 7995
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_Int32_int4x4_0;

		// Token: 0x04001F3C RID: 7996
		private static readonly IntPtr NativeMethodInfoPtr_op_OnesComplement_Public_Static_int4x4_int4x4_0;

		// Token: 0x04001F3D RID: 7997
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int4x4_int4x4_int4x4_0;

		// Token: 0x04001F3E RID: 7998
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int4x4_int4x4_Int32_0;

		// Token: 0x04001F3F RID: 7999
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int4x4_Int32_int4x4_0;

		// Token: 0x04001F40 RID: 8000
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int4x4_int4x4_int4x4_0;

		// Token: 0x04001F41 RID: 8001
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int4x4_int4x4_Int32_0;

		// Token: 0x04001F42 RID: 8002
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int4x4_Int32_int4x4_0;

		// Token: 0x04001F43 RID: 8003
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int4x4_int4x4_int4x4_0;

		// Token: 0x04001F44 RID: 8004
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int4x4_int4x4_Int32_0;

		// Token: 0x04001F45 RID: 8005
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int4x4_Int32_int4x4_0;

		// Token: 0x04001F46 RID: 8006
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_int4_Int32_0;

		// Token: 0x04001F47 RID: 8007
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_int4x4_0;

		// Token: 0x04001F48 RID: 8008
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001F49 RID: 8009
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001F4A RID: 8010
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001F4B RID: 8011
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04001F4C RID: 8012
		[FieldOffset(0)]
		public int4 c0;

		// Token: 0x04001F4D RID: 8013
		[FieldOffset(16)]
		public int4 c1;

		// Token: 0x04001F4E RID: 8014
		[FieldOffset(32)]
		public int4 c2;

		// Token: 0x04001F4F RID: 8015
		[FieldOffset(48)]
		public int4 c3;
	}
}
