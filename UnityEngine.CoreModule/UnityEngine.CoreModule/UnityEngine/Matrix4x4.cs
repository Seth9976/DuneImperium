using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000FD RID: 253
	[StructLayout(2)]
	public struct Matrix4x4
	{
		// Token: 0x060013A5 RID: 5029 RVA: 0x00062220 File Offset: 0x00060420
		// Note: this type is marked as 'beforefieldinit'.
		static Matrix4x4()
		{
			Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Matrix4x4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr);
			Matrix4x4.NativeFieldInfoPtr_m00 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m00");
			Matrix4x4.NativeFieldInfoPtr_m10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m10");
			Matrix4x4.NativeFieldInfoPtr_m20 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m20");
			Matrix4x4.NativeFieldInfoPtr_m30 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m30");
			Matrix4x4.NativeFieldInfoPtr_m01 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m01");
			Matrix4x4.NativeFieldInfoPtr_m11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m11");
			Matrix4x4.NativeFieldInfoPtr_m21 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m21");
			Matrix4x4.NativeFieldInfoPtr_m31 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m31");
			Matrix4x4.NativeFieldInfoPtr_m02 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m02");
			Matrix4x4.NativeFieldInfoPtr_m12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m12");
			Matrix4x4.NativeFieldInfoPtr_m22 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m22");
			Matrix4x4.NativeFieldInfoPtr_m32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m32");
			Matrix4x4.NativeFieldInfoPtr_m03 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m03");
			Matrix4x4.NativeFieldInfoPtr_m13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m13");
			Matrix4x4.NativeFieldInfoPtr_m23 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m23");
			Matrix4x4.NativeFieldInfoPtr_m33 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m33");
			Matrix4x4.NativeFieldInfoPtr_zeroMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "zeroMatrix");
			Matrix4x4.NativeFieldInfoPtr_identityMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "identityMatrix");
			Matrix4x4.NativeMethodInfoPtr_GetLossyScale_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666064);
			Matrix4x4.NativeMethodInfoPtr_DecomposeProjection_Private_FrustumPlanes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666065);
			Matrix4x4.NativeMethodInfoPtr_get_lossyScale_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666066);
			Matrix4x4.NativeMethodInfoPtr_get_decomposeProjection_Public_get_FrustumPlanes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666067);
			Matrix4x4.NativeMethodInfoPtr_TRS_Public_Static_Matrix4x4_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666068);
			Matrix4x4.NativeMethodInfoPtr_Inverse3DAffine_Public_Static_Boolean_Matrix4x4_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666069);
			Matrix4x4.NativeMethodInfoPtr_Inverse_Public_Static_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666070);
			Matrix4x4.NativeMethodInfoPtr_get_inverse_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666071);
			Matrix4x4.NativeMethodInfoPtr_Transpose_Public_Static_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666072);
			Matrix4x4.NativeMethodInfoPtr_get_transpose_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666073);
			Matrix4x4.NativeMethodInfoPtr_Ortho_Public_Static_Matrix4x4_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666074);
			Matrix4x4.NativeMethodInfoPtr_Perspective_Public_Static_Matrix4x4_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666075);
			Matrix4x4.NativeMethodInfoPtr_LookAt_Public_Static_Matrix4x4_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666076);
			Matrix4x4.NativeMethodInfoPtr_Frustum_Public_Static_Matrix4x4_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666077);
			Matrix4x4.NativeMethodInfoPtr_Frustum_Public_Static_Matrix4x4_FrustumPlanes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666078);
			Matrix4x4.NativeMethodInfoPtr__ctor_Public_Void_Vector4_Vector4_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666079);
			Matrix4x4.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666080);
			Matrix4x4.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666081);
			Matrix4x4.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666082);
			Matrix4x4.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666083);
			Matrix4x4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666084);
			Matrix4x4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666085);
			Matrix4x4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666086);
			Matrix4x4.NativeMethodInfoPtr_op_Multiply_Public_Static_Matrix4x4_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666087);
			Matrix4x4.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector4_Matrix4x4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666088);
			Matrix4x4.NativeMethodInfoPtr_GetColumn_Public_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666089);
			Matrix4x4.NativeMethodInfoPtr_GetRow_Public_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666090);
			Matrix4x4.NativeMethodInfoPtr_SetColumn_Public_Void_Int32_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666091);
			Matrix4x4.NativeMethodInfoPtr_MultiplyPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666092);
			Matrix4x4.NativeMethodInfoPtr_MultiplyPoint3x4_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666093);
			Matrix4x4.NativeMethodInfoPtr_MultiplyVector_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666094);
			Matrix4x4.NativeMethodInfoPtr_Scale_Public_Static_Matrix4x4_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666095);
			Matrix4x4.NativeMethodInfoPtr_Translate_Public_Static_Matrix4x4_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666096);
			Matrix4x4.NativeMethodInfoPtr_Rotate_Public_Static_Matrix4x4_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666097);
			Matrix4x4.NativeMethodInfoPtr_get_zero_Public_Static_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666098);
			Matrix4x4.NativeMethodInfoPtr_get_identity_Public_Static_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666099);
			Matrix4x4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666100);
			Matrix4x4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666101);
			Matrix4x4.NativeMethodInfoPtr_GetLossyScale_Injected_Private_Static_Void_byref_Matrix4x4_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666103);
			Matrix4x4.NativeMethodInfoPtr_DecomposeProjection_Injected_Private_Static_Void_byref_Matrix4x4_byref_FrustumPlanes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666104);
			Matrix4x4.NativeMethodInfoPtr_TRS_Injected_Private_Static_Void_byref_Vector3_byref_Quaternion_byref_Vector3_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666105);
			Matrix4x4.NativeMethodInfoPtr_Inverse3DAffine_Injected_Private_Static_Boolean_byref_Matrix4x4_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666106);
			Matrix4x4.NativeMethodInfoPtr_Inverse_Injected_Private_Static_Void_byref_Matrix4x4_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666107);
			Matrix4x4.NativeMethodInfoPtr_Transpose_Injected_Private_Static_Void_byref_Matrix4x4_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666108);
			Matrix4x4.NativeMethodInfoPtr_Ortho_Injected_Private_Static_Void_Single_Single_Single_Single_Single_Single_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666109);
			Matrix4x4.NativeMethodInfoPtr_Perspective_Injected_Private_Static_Void_Single_Single_Single_Single_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666110);
			Matrix4x4.NativeMethodInfoPtr_LookAt_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Vector3_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666111);
			Matrix4x4.NativeMethodInfoPtr_Frustum_Injected_Private_Static_Void_Single_Single_Single_Single_Single_Single_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100666112);
			Matrix4x4.GetRotation_InjectedDelegateField = IL2CPP.ResolveICall<Matrix4x4.GetRotation_InjectedDelegate>("UnityEngine.Matrix4x4::GetRotation_Injected");
			Matrix4x4.IsIdentity_InjectedDelegateField = IL2CPP.ResolveICall<Matrix4x4.IsIdentity_InjectedDelegate>("UnityEngine.Matrix4x4::IsIdentity_Injected");
			Matrix4x4.GetDeterminant_InjectedDelegateField = IL2CPP.ResolveICall<Matrix4x4.GetDeterminant_InjectedDelegate>("UnityEngine.Matrix4x4::GetDeterminant_Injected");
			Matrix4x4.ValidTRS_InjectedDelegateField = IL2CPP.ResolveICall<Matrix4x4.ValidTRS_InjectedDelegate>("UnityEngine.Matrix4x4::ValidTRS_Injected");
			Matrix4x4.CompareApproximately_InjectedDelegateField = IL2CPP.ResolveICall<Matrix4x4.CompareApproximately_InjectedDelegate>("UnityEngine.Matrix4x4::CompareApproximately_Injected");
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x000627C4 File Offset: 0x000609C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658330, XrefRangeEnd = 658332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetLossyScale()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_GetLossyScale_Private_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x000627F4 File Offset: 0x000609F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658332, XrefRangeEnd = 658334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FrustumPlanes DecomposeProjection()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_DecomposeProjection_Private_FrustumPlanes_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x060013A8 RID: 5032 RVA: 0x00062824 File Offset: 0x00060A24
		public unsafe Vector3 lossyScale
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 658336, RefRangeEnd = 658340, XrefRangeStart = 658334, XrefRangeEnd = 658336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_get_lossyScale_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x060013A9 RID: 5033 RVA: 0x00062854 File Offset: 0x00060A54
		public unsafe FrustumPlanes decomposeProjection
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 658342, RefRangeEnd = 658345, XrefRangeStart = 658340, XrefRangeEnd = 658342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_get_decomposeProjection_Public_get_FrustumPlanes_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x00062884 File Offset: 0x00060A84
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 658347, RefRangeEnd = 658363, XrefRangeStart = 658345, XrefRangeEnd = 658347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref q;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref s;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_TRS_Public_Static_Matrix4x4_Vector3_Quaternion_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x000628E0 File Offset: 0x00060AE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 658365, RefRangeEnd = 658367, XrefRangeStart = 658363, XrefRangeEnd = 658365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Inverse3DAffine(Matrix4x4 input, ref Matrix4x4 result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Inverse3DAffine_Public_Static_Boolean_Matrix4x4_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013AC RID: 5036 RVA: 0x0006292C File Offset: 0x00060B2C
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 658369, RefRangeEnd = 658387, XrefRangeStart = 658367, XrefRangeEnd = 658369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 Inverse(Matrix4x4 m)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref m;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Inverse_Public_Static_Matrix4x4_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x060013AD RID: 5037 RVA: 0x0006296C File Offset: 0x00060B6C
		public unsafe Matrix4x4 inverse
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 658389, RefRangeEnd = 658402, XrefRangeStart = 658387, XrefRangeEnd = 658389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_get_inverse_Public_get_Matrix4x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x0006299C File Offset: 0x00060B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658402, XrefRangeEnd = 658404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 Transpose(Matrix4x4 m)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref m;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Transpose_Public_Static_Matrix4x4_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x060013AF RID: 5039 RVA: 0x000629DC File Offset: 0x00060BDC
		public unsafe Matrix4x4 transpose
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 658406, RefRangeEnd = 658407, XrefRangeStart = 658404, XrefRangeEnd = 658406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_get_transpose_Public_get_Matrix4x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x00062A0C File Offset: 0x00060C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658407, XrefRangeEnd = 658409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 Ortho(float left, float right, float bottom, float top, float zNear, float zFar)
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
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zNear;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zFar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Ortho_Public_Static_Matrix4x4_Single_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x00062A90 File Offset: 0x00060C90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 658411, RefRangeEnd = 658413, XrefRangeStart = 658409, XrefRangeEnd = 658411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 Perspective(float fov, float aspect, float zNear, float zFar)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fov;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref aspect;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zNear;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zFar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Perspective_Public_Static_Matrix4x4_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x00062AF8 File Offset: 0x00060CF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 658415, RefRangeEnd = 658416, XrefRangeStart = 658413, XrefRangeEnd = 658415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 LookAt(Vector3 from, Vector3 to, Vector3 up)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref from;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref up;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_LookAt_Public_Static_Matrix4x4_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x00062B54 File Offset: 0x00060D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658416, XrefRangeEnd = 658418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 Frustum(float left, float right, float bottom, float top, float zNear, float zFar)
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
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zNear;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zFar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Frustum_Public_Static_Matrix4x4_Single_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x00062BD8 File Offset: 0x00060DD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 658420, RefRangeEnd = 658421, XrefRangeStart = 658418, XrefRangeEnd = 658420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 Frustum(FrustumPlanes fp)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Frustum_Public_Static_Matrix4x4_FrustumPlanes_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x00062C18 File Offset: 0x00060E18
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 658421, RefRangeEnd = 658425, XrefRangeStart = 658421, XrefRangeEnd = 658421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Matrix4x4(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref column0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref column1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref column2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref column3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr__ctor_Public_Void_Vector4_Vector4_Vector4_Vector4_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700041D RID: 1053
		public unsafe float this[int row, int column]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658425, XrefRangeEnd = 658426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref row;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref column;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658426, XrefRangeEnd = 658427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref row;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref column;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700041E RID: 1054
		public unsafe float this[int index]
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 658427, RefRangeEnd = 658446, XrefRangeStart = 658427, XrefRangeEnd = 658427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 658446, RefRangeEnd = 658451, XrefRangeStart = 658446, XrefRangeEnd = 658446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x00062D90 File Offset: 0x00060F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658451, XrefRangeEnd = 658467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x00062DC0 File Offset: 0x00060FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658467, XrefRangeEnd = 658471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013BC RID: 5052 RVA: 0x00062E04 File Offset: 0x00061004
		[CallerCount(0)]
		public unsafe bool Equals(Matrix4x4 other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Matrix4x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013BD RID: 5053 RVA: 0x00062E44 File Offset: 0x00061044
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 658471, RefRangeEnd = 658519, XrefRangeStart = 658471, XrefRangeEnd = 658471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 operator *(Matrix4x4 lhs, Matrix4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_op_Multiply_Public_Static_Matrix4x4_Matrix4x4_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x00062E90 File Offset: 0x00061090
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 658519, RefRangeEnd = 658527, XrefRangeStart = 658519, XrefRangeEnd = 658519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector4 operator *(Matrix4x4 lhs, Vector4 vector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vector;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector4_Matrix4x4_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x00062EDC File Offset: 0x000610DC
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 658527, RefRangeEnd = 658554, XrefRangeStart = 658527, XrefRangeEnd = 658527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4 GetColumn(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_GetColumn_Public_Vector4_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013C0 RID: 5056 RVA: 0x00062F1C File Offset: 0x0006111C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 658557, RefRangeEnd = 658563, XrefRangeStart = 658554, XrefRangeEnd = 658557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4 GetRow(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_GetRow_Public_Vector4_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013C1 RID: 5057 RVA: 0x00062F5C File Offset: 0x0006115C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 658567, RefRangeEnd = 658572, XrefRangeStart = 658563, XrefRangeEnd = 658567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColumn(int index, Vector4 column)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref column;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_SetColumn_Public_Void_Int32_Vector4_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013C2 RID: 5058 RVA: 0x00062F9C File Offset: 0x0006119C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 658572, RefRangeEnd = 658579, XrefRangeStart = 658572, XrefRangeEnd = 658572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 MultiplyPoint(Vector3 point)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_MultiplyPoint_Public_Vector3_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x00062FDC File Offset: 0x000611DC
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 658579, RefRangeEnd = 658607, XrefRangeStart = 658579, XrefRangeEnd = 658579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 MultiplyPoint3x4(Vector3 point)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_MultiplyPoint3x4_Public_Vector3_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x0006301C File Offset: 0x0006121C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 658607, RefRangeEnd = 658610, XrefRangeStart = 658607, XrefRangeEnd = 658607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 MultiplyVector(Vector3 vector)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vector;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_MultiplyVector_Public_Vector3_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013C5 RID: 5061 RVA: 0x0006305C File Offset: 0x0006125C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 658610, RefRangeEnd = 658620, XrefRangeStart = 658610, XrefRangeEnd = 658610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 Scale(Vector3 vector)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vector;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Scale_Public_Static_Matrix4x4_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013C6 RID: 5062 RVA: 0x0006309C File Offset: 0x0006129C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 658620, RefRangeEnd = 658623, XrefRangeStart = 658620, XrefRangeEnd = 658620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 Translate(Vector3 vector)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vector;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Translate_Public_Static_Matrix4x4_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013C7 RID: 5063 RVA: 0x000630DC File Offset: 0x000612DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 658623, RefRangeEnd = 658625, XrefRangeStart = 658623, XrefRangeEnd = 658623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 Rotate(Quaternion q)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref q;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Rotate_Public_Static_Matrix4x4_Quaternion_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x060013C8 RID: 5064 RVA: 0x0006311C File Offset: 0x0006131C
		public unsafe static Matrix4x4 zero
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 658627, RefRangeEnd = 658628, XrefRangeStart = 658625, XrefRangeEnd = 658627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_get_zero_Public_Static_get_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x060013C9 RID: 5065 RVA: 0x0006314C File Offset: 0x0006134C
		public unsafe static Matrix4x4 identity
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658628, XrefRangeEnd = 658630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_get_identity_Public_Static_get_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013CA RID: 5066 RVA: 0x0006317C File Offset: 0x0006137C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658630, XrefRangeEnd = 658631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x000631A8 File Offset: 0x000613A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658631, XrefRangeEnd = 658726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060013CC RID: 5068 RVA: 0x000631F8 File Offset: 0x000613F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658726, XrefRangeEnd = 658728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetLossyScale_Injected(ref Matrix4x4 _unity_self, out Vector3 ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_GetLossyScale_Injected_Private_Static_Void_byref_Matrix4x4_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x00063238 File Offset: 0x00061438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658728, XrefRangeEnd = 658730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DecomposeProjection_Injected(ref Matrix4x4 _unity_self, out FrustumPlanes ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_DecomposeProjection_Injected_Private_Static_Void_byref_Matrix4x4_byref_FrustumPlanes_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013CE RID: 5070 RVA: 0x00063278 File Offset: 0x00061478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658730, XrefRangeEnd = 658732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TRS_Injected(ref Vector3 pos, ref Quaternion q, ref Vector3 s, out Matrix4x4 ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &q;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &s;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_TRS_Injected_Private_Static_Void_byref_Vector3_byref_Quaternion_byref_Vector3_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x000632D4 File Offset: 0x000614D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658732, XrefRangeEnd = 658734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Inverse3DAffine_Injected(ref Matrix4x4 input, ref Matrix4x4 result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Inverse3DAffine_Injected_Private_Static_Boolean_byref_Matrix4x4_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x00063320 File Offset: 0x00061520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658734, XrefRangeEnd = 658736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Inverse_Injected(ref Matrix4x4 m, out Matrix4x4 ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &m;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Inverse_Injected_Private_Static_Void_byref_Matrix4x4_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x00063360 File Offset: 0x00061560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658736, XrefRangeEnd = 658738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Transpose_Injected(ref Matrix4x4 m, out Matrix4x4 ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &m;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Transpose_Injected_Private_Static_Void_byref_Matrix4x4_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013D2 RID: 5074 RVA: 0x000633A0 File Offset: 0x000615A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658738, XrefRangeEnd = 658740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Ortho_Injected(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bottom;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref top;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zNear;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zFar;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Ortho_Injected_Private_Static_Void_Single_Single_Single_Single_Single_Single_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x00063428 File Offset: 0x00061628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658740, XrefRangeEnd = 658742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Perspective_Injected(float fov, float aspect, float zNear, float zFar, out Matrix4x4 ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fov;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref aspect;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zNear;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zFar;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Perspective_Injected_Private_Static_Void_Single_Single_Single_Single_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x00063494 File Offset: 0x00061694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658742, XrefRangeEnd = 658744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LookAt_Injected(ref Vector3 from, ref Vector3 to, ref Vector3 up, out Matrix4x4 ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &from;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &up;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_LookAt_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Vector3_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x000634F0 File Offset: 0x000616F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658744, XrefRangeEnd = 658746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Frustum_Injected(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bottom;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref top;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zNear;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zFar;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Frustum_Injected_Private_Static_Void_Single_Single_Single_Single_Single_Single_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x00008134 File Offset: 0x00006334
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, ref this));
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x060013D7 RID: 5079 RVA: 0x00063578 File Offset: 0x00061778
		// (set) Token: 0x060013D8 RID: 5080 RVA: 0x00008146 File Offset: 0x00006346
		public unsafe static Matrix4x4 zeroMatrix
		{
			get
			{
				Matrix4x4 matrix4x;
				IL2CPP.il2cpp_field_static_get_value(Matrix4x4.NativeFieldInfoPtr_zeroMatrix, (void*)(&matrix4x));
				return matrix4x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Matrix4x4.NativeFieldInfoPtr_zeroMatrix, (void*)(&value));
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x060013D9 RID: 5081 RVA: 0x00063594 File Offset: 0x00061794
		// (set) Token: 0x060013DA RID: 5082 RVA: 0x00008154 File Offset: 0x00006354
		public unsafe static Matrix4x4 identityMatrix
		{
			get
			{
				Matrix4x4 matrix4x;
				IL2CPP.il2cpp_field_static_get_value(Matrix4x4.NativeFieldInfoPtr_identityMatrix, (void*)(&matrix4x));
				return matrix4x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Matrix4x4.NativeFieldInfoPtr_identityMatrix, (void*)(&value));
			}
		}

		// Token: 0x060013DB RID: 5083 RVA: 0x000635B0 File Offset: 0x000617B0
		public Quaternion GetRotation()
		{
			Quaternion quaternion;
			Matrix4x4.GetRotation_Injected(ref this, out quaternion);
			return quaternion;
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x00008162 File Offset: 0x00006362
		public bool IsIdentity()
		{
			return Matrix4x4.IsIdentity_Injected(ref this);
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x0000816A File Offset: 0x0000636A
		public float GetDeterminant()
		{
			return Matrix4x4.GetDeterminant_Injected(ref this);
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x060013DE RID: 5086 RVA: 0x000635C8 File Offset: 0x000617C8
		public Quaternion rotation
		{
			get
			{
				return this.GetRotation();
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x060013DF RID: 5087 RVA: 0x000635E0 File Offset: 0x000617E0
		public bool isIdentity
		{
			get
			{
				return this.IsIdentity();
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x060013E0 RID: 5088 RVA: 0x000635F8 File Offset: 0x000617F8
		public float determinant
		{
			get
			{
				return this.GetDeterminant();
			}
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x00008172 File Offset: 0x00006372
		public bool ValidTRS()
		{
			return Matrix4x4.ValidTRS_Injected(ref this);
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x00063610 File Offset: 0x00061810
		public static float Determinant(Matrix4x4 m)
		{
			return m.determinant;
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x0000817A File Offset: 0x0000637A
		public void SetTRS(Vector3 pos, Quaternion q, Vector3 s)
		{
			this = Matrix4x4.TRS(pos, q, s);
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x0000818B File Offset: 0x0000638B
		public static bool CompareApproximately(Matrix4x4 a, Matrix4x4 b, float threshold)
		{
			return Matrix4x4.CompareApproximately_Injected(ref a, ref b, threshold);
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x0006362C File Offset: 0x0006182C
		public static bool operator ==(Matrix4x4 lhs, Matrix4x4 rhs)
		{
			return lhs.GetColumn(0) == rhs.GetColumn(0) && lhs.GetColumn(1) == rhs.GetColumn(1) && lhs.GetColumn(2) == rhs.GetColumn(2) && lhs.GetColumn(3) == rhs.GetColumn(3);
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x0006369C File Offset: 0x0006189C
		public static bool operator !=(Matrix4x4 lhs, Matrix4x4 rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x060013E7 RID: 5095 RVA: 0x000636B8 File Offset: 0x000618B8
		public Vector3 GetPosition()
		{
			return new Vector3(this.m03, this.m13, this.m23);
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x00008197 File Offset: 0x00006397
		public void SetRow(int index, Vector4 row)
		{
			this[index, 0] = row.x;
			this[index, 1] = row.y;
			this[index, 2] = row.z;
			this[index, 3] = row.w;
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x000636E4 File Offset: 0x000618E4
		public Plane TransformPlane(Plane plane)
		{
			Matrix4x4 inverse = this.inverse;
			float x = plane.normal.x;
			float y = plane.normal.y;
			float z = plane.normal.z;
			float distance = plane.distance;
			float num = inverse.m00 * x + inverse.m10 * y + inverse.m20 * z + inverse.m30 * distance;
			float num2 = inverse.m01 * x + inverse.m11 * y + inverse.m21 * z + inverse.m31 * distance;
			float num3 = inverse.m02 * x + inverse.m12 * y + inverse.m22 * z + inverse.m32 * distance;
			float num4 = inverse.m03 * x + inverse.m13 * y + inverse.m23 * z + inverse.m33 * distance;
			return new Plane(new Vector3(num, num2, num3), num4);
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x000637DC File Offset: 0x000619DC
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x000081D6 File Offset: 0x000063D6
		public static void GetRotation_Injected(ref Matrix4x4 _unity_self, out Quaternion ret)
		{
			Matrix4x4.GetRotation_InjectedDelegateField(ref _unity_self, out ret);
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x000081E4 File Offset: 0x000063E4
		public static bool IsIdentity_Injected(ref Matrix4x4 _unity_self)
		{
			return Matrix4x4.IsIdentity_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x000081F1 File Offset: 0x000063F1
		public static float GetDeterminant_Injected(ref Matrix4x4 _unity_self)
		{
			return Matrix4x4.GetDeterminant_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x000081FE File Offset: 0x000063FE
		public static bool ValidTRS_Injected(ref Matrix4x4 _unity_self)
		{
			return Matrix4x4.ValidTRS_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x0000820B File Offset: 0x0000640B
		public static bool CompareApproximately_Injected(ref Matrix4x4 a, ref Matrix4x4 b, float threshold)
		{
			return Matrix4x4.CompareApproximately_InjectedDelegateField(ref a, ref b, threshold);
		}

		// Token: 0x040012B4 RID: 4788
		private static readonly IntPtr NativeFieldInfoPtr_m00;

		// Token: 0x040012B5 RID: 4789
		private static readonly IntPtr NativeFieldInfoPtr_m10;

		// Token: 0x040012B6 RID: 4790
		private static readonly IntPtr NativeFieldInfoPtr_m20;

		// Token: 0x040012B7 RID: 4791
		private static readonly IntPtr NativeFieldInfoPtr_m30;

		// Token: 0x040012B8 RID: 4792
		private static readonly IntPtr NativeFieldInfoPtr_m01;

		// Token: 0x040012B9 RID: 4793
		private static readonly IntPtr NativeFieldInfoPtr_m11;

		// Token: 0x040012BA RID: 4794
		private static readonly IntPtr NativeFieldInfoPtr_m21;

		// Token: 0x040012BB RID: 4795
		private static readonly IntPtr NativeFieldInfoPtr_m31;

		// Token: 0x040012BC RID: 4796
		private static readonly IntPtr NativeFieldInfoPtr_m02;

		// Token: 0x040012BD RID: 4797
		private static readonly IntPtr NativeFieldInfoPtr_m12;

		// Token: 0x040012BE RID: 4798
		private static readonly IntPtr NativeFieldInfoPtr_m22;

		// Token: 0x040012BF RID: 4799
		private static readonly IntPtr NativeFieldInfoPtr_m32;

		// Token: 0x040012C0 RID: 4800
		private static readonly IntPtr NativeFieldInfoPtr_m03;

		// Token: 0x040012C1 RID: 4801
		private static readonly IntPtr NativeFieldInfoPtr_m13;

		// Token: 0x040012C2 RID: 4802
		private static readonly IntPtr NativeFieldInfoPtr_m23;

		// Token: 0x040012C3 RID: 4803
		private static readonly IntPtr NativeFieldInfoPtr_m33;

		// Token: 0x040012C4 RID: 4804
		private static readonly IntPtr NativeFieldInfoPtr_zeroMatrix;

		// Token: 0x040012C5 RID: 4805
		private static readonly IntPtr NativeFieldInfoPtr_identityMatrix;

		// Token: 0x040012C6 RID: 4806
		private static readonly IntPtr NativeMethodInfoPtr_GetLossyScale_Private_Vector3_0;

		// Token: 0x040012C7 RID: 4807
		private static readonly IntPtr NativeMethodInfoPtr_DecomposeProjection_Private_FrustumPlanes_0;

		// Token: 0x040012C8 RID: 4808
		private static readonly IntPtr NativeMethodInfoPtr_get_lossyScale_Public_get_Vector3_0;

		// Token: 0x040012C9 RID: 4809
		private static readonly IntPtr NativeMethodInfoPtr_get_decomposeProjection_Public_get_FrustumPlanes_0;

		// Token: 0x040012CA RID: 4810
		private static readonly IntPtr NativeMethodInfoPtr_TRS_Public_Static_Matrix4x4_Vector3_Quaternion_Vector3_0;

		// Token: 0x040012CB RID: 4811
		private static readonly IntPtr NativeMethodInfoPtr_Inverse3DAffine_Public_Static_Boolean_Matrix4x4_byref_Matrix4x4_0;

		// Token: 0x040012CC RID: 4812
		private static readonly IntPtr NativeMethodInfoPtr_Inverse_Public_Static_Matrix4x4_Matrix4x4_0;

		// Token: 0x040012CD RID: 4813
		private static readonly IntPtr NativeMethodInfoPtr_get_inverse_Public_get_Matrix4x4_0;

		// Token: 0x040012CE RID: 4814
		private static readonly IntPtr NativeMethodInfoPtr_Transpose_Public_Static_Matrix4x4_Matrix4x4_0;

		// Token: 0x040012CF RID: 4815
		private static readonly IntPtr NativeMethodInfoPtr_get_transpose_Public_get_Matrix4x4_0;

		// Token: 0x040012D0 RID: 4816
		private static readonly IntPtr NativeMethodInfoPtr_Ortho_Public_Static_Matrix4x4_Single_Single_Single_Single_Single_Single_0;

		// Token: 0x040012D1 RID: 4817
		private static readonly IntPtr NativeMethodInfoPtr_Perspective_Public_Static_Matrix4x4_Single_Single_Single_Single_0;

		// Token: 0x040012D2 RID: 4818
		private static readonly IntPtr NativeMethodInfoPtr_LookAt_Public_Static_Matrix4x4_Vector3_Vector3_Vector3_0;

		// Token: 0x040012D3 RID: 4819
		private static readonly IntPtr NativeMethodInfoPtr_Frustum_Public_Static_Matrix4x4_Single_Single_Single_Single_Single_Single_0;

		// Token: 0x040012D4 RID: 4820
		private static readonly IntPtr NativeMethodInfoPtr_Frustum_Public_Static_Matrix4x4_FrustumPlanes_0;

		// Token: 0x040012D5 RID: 4821
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector4_Vector4_Vector4_Vector4_0;

		// Token: 0x040012D6 RID: 4822
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_Int32_0;

		// Token: 0x040012D7 RID: 4823
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_Single_0;

		// Token: 0x040012D8 RID: 4824
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0;

		// Token: 0x040012D9 RID: 4825
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0;

		// Token: 0x040012DA RID: 4826
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040012DB RID: 4827
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040012DC RID: 4828
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Matrix4x4_0;

		// Token: 0x040012DD RID: 4829
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Matrix4x4_Matrix4x4_Matrix4x4_0;

		// Token: 0x040012DE RID: 4830
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Vector4_Matrix4x4_Vector4_0;

		// Token: 0x040012DF RID: 4831
		private static readonly IntPtr NativeMethodInfoPtr_GetColumn_Public_Vector4_Int32_0;

		// Token: 0x040012E0 RID: 4832
		private static readonly IntPtr NativeMethodInfoPtr_GetRow_Public_Vector4_Int32_0;

		// Token: 0x040012E1 RID: 4833
		private static readonly IntPtr NativeMethodInfoPtr_SetColumn_Public_Void_Int32_Vector4_0;

		// Token: 0x040012E2 RID: 4834
		private static readonly IntPtr NativeMethodInfoPtr_MultiplyPoint_Public_Vector3_Vector3_0;

		// Token: 0x040012E3 RID: 4835
		private static readonly IntPtr NativeMethodInfoPtr_MultiplyPoint3x4_Public_Vector3_Vector3_0;

		// Token: 0x040012E4 RID: 4836
		private static readonly IntPtr NativeMethodInfoPtr_MultiplyVector_Public_Vector3_Vector3_0;

		// Token: 0x040012E5 RID: 4837
		private static readonly IntPtr NativeMethodInfoPtr_Scale_Public_Static_Matrix4x4_Vector3_0;

		// Token: 0x040012E6 RID: 4838
		private static readonly IntPtr NativeMethodInfoPtr_Translate_Public_Static_Matrix4x4_Vector3_0;

		// Token: 0x040012E7 RID: 4839
		private static readonly IntPtr NativeMethodInfoPtr_Rotate_Public_Static_Matrix4x4_Quaternion_0;

		// Token: 0x040012E8 RID: 4840
		private static readonly IntPtr NativeMethodInfoPtr_get_zero_Public_Static_get_Matrix4x4_0;

		// Token: 0x040012E9 RID: 4841
		private static readonly IntPtr NativeMethodInfoPtr_get_identity_Public_Static_get_Matrix4x4_0;

		// Token: 0x040012EA RID: 4842
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040012EB RID: 4843
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x040012EC RID: 4844
		private static readonly IntPtr NativeMethodInfoPtr_GetLossyScale_Injected_Private_Static_Void_byref_Matrix4x4_byref_Vector3_0;

		// Token: 0x040012ED RID: 4845
		private static readonly IntPtr NativeMethodInfoPtr_DecomposeProjection_Injected_Private_Static_Void_byref_Matrix4x4_byref_FrustumPlanes_0;

		// Token: 0x040012EE RID: 4846
		private static readonly IntPtr NativeMethodInfoPtr_TRS_Injected_Private_Static_Void_byref_Vector3_byref_Quaternion_byref_Vector3_byref_Matrix4x4_0;

		// Token: 0x040012EF RID: 4847
		private static readonly IntPtr NativeMethodInfoPtr_Inverse3DAffine_Injected_Private_Static_Boolean_byref_Matrix4x4_byref_Matrix4x4_0;

		// Token: 0x040012F0 RID: 4848
		private static readonly IntPtr NativeMethodInfoPtr_Inverse_Injected_Private_Static_Void_byref_Matrix4x4_byref_Matrix4x4_0;

		// Token: 0x040012F1 RID: 4849
		private static readonly IntPtr NativeMethodInfoPtr_Transpose_Injected_Private_Static_Void_byref_Matrix4x4_byref_Matrix4x4_0;

		// Token: 0x040012F2 RID: 4850
		private static readonly IntPtr NativeMethodInfoPtr_Ortho_Injected_Private_Static_Void_Single_Single_Single_Single_Single_Single_byref_Matrix4x4_0;

		// Token: 0x040012F3 RID: 4851
		private static readonly IntPtr NativeMethodInfoPtr_Perspective_Injected_Private_Static_Void_Single_Single_Single_Single_byref_Matrix4x4_0;

		// Token: 0x040012F4 RID: 4852
		private static readonly IntPtr NativeMethodInfoPtr_LookAt_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Vector3_byref_Matrix4x4_0;

		// Token: 0x040012F5 RID: 4853
		private static readonly IntPtr NativeMethodInfoPtr_Frustum_Injected_Private_Static_Void_Single_Single_Single_Single_Single_Single_byref_Matrix4x4_0;

		// Token: 0x040012F6 RID: 4854
		[FieldOffset(0)]
		public float m00;

		// Token: 0x040012F7 RID: 4855
		[FieldOffset(4)]
		public float m10;

		// Token: 0x040012F8 RID: 4856
		[FieldOffset(8)]
		public float m20;

		// Token: 0x040012F9 RID: 4857
		[FieldOffset(12)]
		public float m30;

		// Token: 0x040012FA RID: 4858
		[FieldOffset(16)]
		public float m01;

		// Token: 0x040012FB RID: 4859
		[FieldOffset(20)]
		public float m11;

		// Token: 0x040012FC RID: 4860
		[FieldOffset(24)]
		public float m21;

		// Token: 0x040012FD RID: 4861
		[FieldOffset(28)]
		public float m31;

		// Token: 0x040012FE RID: 4862
		[FieldOffset(32)]
		public float m02;

		// Token: 0x040012FF RID: 4863
		[FieldOffset(36)]
		public float m12;

		// Token: 0x04001300 RID: 4864
		[FieldOffset(40)]
		public float m22;

		// Token: 0x04001301 RID: 4865
		[FieldOffset(44)]
		public float m32;

		// Token: 0x04001302 RID: 4866
		[FieldOffset(48)]
		public float m03;

		// Token: 0x04001303 RID: 4867
		[FieldOffset(52)]
		public float m13;

		// Token: 0x04001304 RID: 4868
		[FieldOffset(56)]
		public float m23;

		// Token: 0x04001305 RID: 4869
		[FieldOffset(60)]
		public float m33;

		// Token: 0x04001306 RID: 4870
		private static readonly Matrix4x4.GetRotation_InjectedDelegate GetRotation_InjectedDelegateField;

		// Token: 0x04001307 RID: 4871
		private static readonly Matrix4x4.IsIdentity_InjectedDelegate IsIdentity_InjectedDelegateField;

		// Token: 0x04001308 RID: 4872
		private static readonly Matrix4x4.GetDeterminant_InjectedDelegate GetDeterminant_InjectedDelegateField;

		// Token: 0x04001309 RID: 4873
		private static readonly Matrix4x4.ValidTRS_InjectedDelegate ValidTRS_InjectedDelegateField;

		// Token: 0x0400130A RID: 4874
		private static readonly Matrix4x4.CompareApproximately_InjectedDelegate CompareApproximately_InjectedDelegateField;

		// Token: 0x020006E7 RID: 1767
		// (Invoke) Token: 0x060036AD RID: 13997
		private delegate void GetRotation_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

		// Token: 0x020006E8 RID: 1768
		// (Invoke) Token: 0x060036AF RID: 13999
		private delegate bool IsIdentity_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020006E9 RID: 1769
		// (Invoke) Token: 0x060036B1 RID: 14001
		private delegate float GetDeterminant_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020006EA RID: 1770
		// (Invoke) Token: 0x060036B3 RID: 14003
		private delegate bool ValidTRS_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020006EB RID: 1771
		// (Invoke) Token: 0x060036B5 RID: 14005
		private delegate bool CompareApproximately_InjectedDelegate(IntPtr a, IntPtr b, float threshold);
	}
}
