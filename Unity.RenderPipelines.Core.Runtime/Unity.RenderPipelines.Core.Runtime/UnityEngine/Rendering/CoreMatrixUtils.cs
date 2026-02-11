using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x020000D3 RID: 211
	public static class CoreMatrixUtils : Object
	{
		// Token: 0x06000F56 RID: 3926 RVA: 0x00046BD4 File Offset: 0x00044DD4
		// Note: this type is marked as 'beforefieldinit'.
		static CoreMatrixUtils()
		{
			Il2CppClassPointerStore<CoreMatrixUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "CoreMatrixUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoreMatrixUtils>.NativeClassPtr);
			CoreMatrixUtils.NativeMethodInfoPtr_MatrixTimesTranslation_Public_Static_Void_byref_Matrix4x4_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreMatrixUtils>.NativeClassPtr, 100665549);
			CoreMatrixUtils.NativeMethodInfoPtr_TranslationTimesMatrix_Public_Static_Void_byref_Matrix4x4_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreMatrixUtils>.NativeClassPtr, 100665550);
			CoreMatrixUtils.NativeMethodInfoPtr_MultiplyPerspectiveMatrix_Public_Static_Matrix4x4_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreMatrixUtils>.NativeClassPtr, 100665551);
			CoreMatrixUtils.NativeMethodInfoPtr_MultiplyOrthoMatrixCentered_Private_Static_Matrix4x4_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreMatrixUtils>.NativeClassPtr, 100665552);
			CoreMatrixUtils.NativeMethodInfoPtr_MultiplyGenericOrthoMatrix_Private_Static_Matrix4x4_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreMatrixUtils>.NativeClassPtr, 100665553);
			CoreMatrixUtils.NativeMethodInfoPtr_MultiplyOrthoMatrix_Public_Static_Matrix4x4_Matrix4x4_Matrix4x4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreMatrixUtils>.NativeClassPtr, 100665554);
			CoreMatrixUtils.NativeMethodInfoPtr_MultiplyProjectionMatrix_Public_Static_Matrix4x4_Matrix4x4_Matrix4x4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreMatrixUtils>.NativeClassPtr, 100665555);
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x00046C90 File Offset: 0x00044E90
		[CallerCount(0)]
		public unsafe static void MatrixTimesTranslation(ref Matrix4x4 inOutMatrix, Vector3 translation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &inOutMatrix;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref translation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreMatrixUtils.NativeMethodInfoPtr_MatrixTimesTranslation_Public_Static_Void_byref_Matrix4x4_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x00046CD0 File Offset: 0x00044ED0
		[CallerCount(0)]
		public unsafe static void TranslationTimesMatrix(ref Matrix4x4 inOutMatrix, Vector3 translation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &inOutMatrix;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref translation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreMatrixUtils.NativeMethodInfoPtr_TranslationTimesMatrix_Public_Static_Void_byref_Matrix4x4_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x00046D10 File Offset: 0x00044F10
		[CallerCount(0)]
		public unsafe static Matrix4x4 MultiplyPerspectiveMatrix(Matrix4x4 perspective, Matrix4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref perspective;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreMatrixUtils.NativeMethodInfoPtr_MultiplyPerspectiveMatrix_Public_Static_Matrix4x4_Matrix4x4_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x00046D5C File Offset: 0x00044F5C
		[CallerCount(0)]
		public unsafe static Matrix4x4 MultiplyOrthoMatrixCentered(Matrix4x4 ortho, Matrix4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ortho;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreMatrixUtils.NativeMethodInfoPtr_MultiplyOrthoMatrixCentered_Private_Static_Matrix4x4_Matrix4x4_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x00046DA8 File Offset: 0x00044FA8
		[CallerCount(0)]
		public unsafe static Matrix4x4 MultiplyGenericOrthoMatrix(Matrix4x4 ortho, Matrix4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ortho;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreMatrixUtils.NativeMethodInfoPtr_MultiplyGenericOrthoMatrix_Private_Static_Matrix4x4_Matrix4x4_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x00046DF4 File Offset: 0x00044FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976128, XrefRangeEnd = 976129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 MultiplyOrthoMatrix(Matrix4x4 ortho, Matrix4x4 rhs, bool centered)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ortho;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref centered;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreMatrixUtils.NativeMethodInfoPtr_MultiplyOrthoMatrix_Public_Static_Matrix4x4_Matrix4x4_Matrix4x4_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x00046E50 File Offset: 0x00045050
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 976130, RefRangeEnd = 976131, XrefRangeStart = 976129, XrefRangeEnd = 976130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 MultiplyProjectionMatrix(Matrix4x4 projMatrix, Matrix4x4 rhs, bool orthoCentered)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref projMatrix;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref orthoCentered;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreMatrixUtils.NativeMethodInfoPtr_MultiplyProjectionMatrix_Public_Static_Matrix4x4_Matrix4x4_Matrix4x4_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x000085A2 File Offset: 0x000067A2
		public CoreMatrixUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BB2 RID: 2994
		private static readonly IntPtr NativeMethodInfoPtr_MatrixTimesTranslation_Public_Static_Void_byref_Matrix4x4_Vector3_0;

		// Token: 0x04000BB3 RID: 2995
		private static readonly IntPtr NativeMethodInfoPtr_TranslationTimesMatrix_Public_Static_Void_byref_Matrix4x4_Vector3_0;

		// Token: 0x04000BB4 RID: 2996
		private static readonly IntPtr NativeMethodInfoPtr_MultiplyPerspectiveMatrix_Public_Static_Matrix4x4_Matrix4x4_Matrix4x4_0;

		// Token: 0x04000BB5 RID: 2997
		private static readonly IntPtr NativeMethodInfoPtr_MultiplyOrthoMatrixCentered_Private_Static_Matrix4x4_Matrix4x4_Matrix4x4_0;

		// Token: 0x04000BB6 RID: 2998
		private static readonly IntPtr NativeMethodInfoPtr_MultiplyGenericOrthoMatrix_Private_Static_Matrix4x4_Matrix4x4_Matrix4x4_0;

		// Token: 0x04000BB7 RID: 2999
		private static readonly IntPtr NativeMethodInfoPtr_MultiplyOrthoMatrix_Public_Static_Matrix4x4_Matrix4x4_Matrix4x4_Boolean_0;

		// Token: 0x04000BB8 RID: 3000
		private static readonly IntPtr NativeMethodInfoPtr_MultiplyProjectionMatrix_Public_Static_Matrix4x4_Matrix4x4_Matrix4x4_Boolean_0;
	}
}
