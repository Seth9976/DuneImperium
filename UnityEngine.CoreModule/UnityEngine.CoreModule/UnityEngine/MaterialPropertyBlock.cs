using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x020000A3 RID: 163
	public sealed class MaterialPropertyBlock : Object
	{
		// Token: 0x06000AE8 RID: 2792 RVA: 0x00038380 File Offset: 0x00036580
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialPropertyBlock()
		{
			Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "MaterialPropertyBlock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr);
			MaterialPropertyBlock.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, "m_Ptr");
			MaterialPropertyBlock.NativeMethodInfoPtr_SetIntImpl_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664490);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetFloatImpl_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664491);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetVectorImpl_Private_Void_Int32_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664492);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetMatrixImpl_Private_Void_Int32_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664493);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetTextureImpl_Private_Void_Int32_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664494);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetRenderTextureImpl_Private_Void_Int32_RenderTexture_RenderTextureSubElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664495);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetFloatArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664496);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetVectorArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664497);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetMatrixArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Matrix4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664498);
			MaterialPropertyBlock.NativeMethodInfoPtr_CreateImpl_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664499);
			MaterialPropertyBlock.NativeMethodInfoPtr_DestroyImpl_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664500);
			MaterialPropertyBlock.NativeMethodInfoPtr_Clear_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664501);
			MaterialPropertyBlock.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664502);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetFloatArray_Private_Void_Int32_Il2CppStructArray_1_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664503);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetVectorArray_Private_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664504);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetMatrixArray_Private_Void_Int32_Il2CppStructArray_1_Matrix4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664505);
			MaterialPropertyBlock.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664506);
			MaterialPropertyBlock.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664507);
			MaterialPropertyBlock.NativeMethodInfoPtr_Dispose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664508);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetInt_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664509);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetInt_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664510);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetFloat_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664511);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetFloat_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664512);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetInteger_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664513);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetVector_Public_Void_String_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664514);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetVector_Public_Void_Int32_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664515);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetMatrix_Public_Void_String_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664516);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetMatrix_Public_Void_Int32_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664517);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetTexture_Public_Void_Int32_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664518);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetTexture_Public_Void_Int32_RenderTexture_RenderTextureSubElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664519);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetFloatArray_Public_Void_String_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664520);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetVectorArray_Public_Void_String_Il2CppStructArray_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664521);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetVectorArray_Public_Void_Int32_Il2CppStructArray_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664522);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetMatrixArray_Public_Void_String_Il2CppStructArray_1_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664523);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetVectorImpl_Injected_Private_Void_Int32_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664524);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetMatrixImpl_Injected_Private_Void_Int32_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664525);
			MaterialPropertyBlock.GetIntImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetIntImplDelegate>("UnityEngine.MaterialPropertyBlock::GetIntImpl");
			MaterialPropertyBlock.GetFloatImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetFloatImplDelegate>("UnityEngine.MaterialPropertyBlock::GetFloatImpl");
			MaterialPropertyBlock.GetTextureImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetTextureImplDelegate>("UnityEngine.MaterialPropertyBlock::GetTextureImpl");
			MaterialPropertyBlock.HasPropertyImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.HasPropertyImplDelegate>("UnityEngine.MaterialPropertyBlock::HasPropertyImpl");
			MaterialPropertyBlock.HasFloatImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.HasFloatImplDelegate>("UnityEngine.MaterialPropertyBlock::HasFloatImpl");
			MaterialPropertyBlock.HasIntImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.HasIntImplDelegate>("UnityEngine.MaterialPropertyBlock::HasIntImpl");
			MaterialPropertyBlock.HasTextureImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.HasTextureImplDelegate>("UnityEngine.MaterialPropertyBlock::HasTextureImpl");
			MaterialPropertyBlock.HasMatrixImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.HasMatrixImplDelegate>("UnityEngine.MaterialPropertyBlock::HasMatrixImpl");
			MaterialPropertyBlock.HasVectorImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.HasVectorImplDelegate>("UnityEngine.MaterialPropertyBlock::HasVectorImpl");
			MaterialPropertyBlock.HasBufferImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.HasBufferImplDelegate>("UnityEngine.MaterialPropertyBlock::HasBufferImpl");
			MaterialPropertyBlock.HasConstantBufferImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.HasConstantBufferImplDelegate>("UnityEngine.MaterialPropertyBlock::HasConstantBufferImpl");
			MaterialPropertyBlock.SetBufferImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.SetBufferImplDelegate>("UnityEngine.MaterialPropertyBlock::SetBufferImpl");
			MaterialPropertyBlock.SetGraphicsBufferImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.SetGraphicsBufferImplDelegate>("UnityEngine.MaterialPropertyBlock::SetGraphicsBufferImpl");
			MaterialPropertyBlock.SetConstantBufferImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.SetConstantBufferImplDelegate>("UnityEngine.MaterialPropertyBlock::SetConstantBufferImpl");
			MaterialPropertyBlock.SetConstantGraphicsBufferImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.SetConstantGraphicsBufferImplDelegate>("UnityEngine.MaterialPropertyBlock::SetConstantGraphicsBufferImpl");
			MaterialPropertyBlock.GetFloatArrayImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetFloatArrayImplDelegate>("UnityEngine.MaterialPropertyBlock::GetFloatArrayImpl");
			MaterialPropertyBlock.GetVectorArrayImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetVectorArrayImplDelegate>("UnityEngine.MaterialPropertyBlock::GetVectorArrayImpl");
			MaterialPropertyBlock.GetMatrixArrayImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetMatrixArrayImplDelegate>("UnityEngine.MaterialPropertyBlock::GetMatrixArrayImpl");
			MaterialPropertyBlock.GetFloatArrayCountImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetFloatArrayCountImplDelegate>("UnityEngine.MaterialPropertyBlock::GetFloatArrayCountImpl");
			MaterialPropertyBlock.GetVectorArrayCountImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetVectorArrayCountImplDelegate>("UnityEngine.MaterialPropertyBlock::GetVectorArrayCountImpl");
			MaterialPropertyBlock.GetMatrixArrayCountImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetMatrixArrayCountImplDelegate>("UnityEngine.MaterialPropertyBlock::GetMatrixArrayCountImpl");
			MaterialPropertyBlock.ExtractFloatArrayImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.ExtractFloatArrayImplDelegate>("UnityEngine.MaterialPropertyBlock::ExtractFloatArrayImpl");
			MaterialPropertyBlock.ExtractVectorArrayImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.ExtractVectorArrayImplDelegate>("UnityEngine.MaterialPropertyBlock::ExtractVectorArrayImpl");
			MaterialPropertyBlock.ExtractMatrixArrayImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.ExtractMatrixArrayImplDelegate>("UnityEngine.MaterialPropertyBlock::ExtractMatrixArrayImpl");
			MaterialPropertyBlock.Internal_CopySHCoefficientArraysFromDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.Internal_CopySHCoefficientArraysFromDelegate>("UnityEngine.MaterialPropertyBlock::Internal_CopySHCoefficientArraysFrom");
			MaterialPropertyBlock.Internal_CopyProbeOcclusionArrayFromDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.Internal_CopyProbeOcclusionArrayFromDelegate>("UnityEngine.MaterialPropertyBlock::Internal_CopyProbeOcclusionArrayFrom");
			MaterialPropertyBlock.get_isEmptyDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.get_isEmptyDelegate>("UnityEngine.MaterialPropertyBlock::get_isEmpty");
			MaterialPropertyBlock.GetVectorImpl_InjectedDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetVectorImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::GetVectorImpl_Injected");
			MaterialPropertyBlock.GetColorImpl_InjectedDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetColorImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::GetColorImpl_Injected");
			MaterialPropertyBlock.GetMatrixImpl_InjectedDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetMatrixImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::GetMatrixImpl_Injected");
			MaterialPropertyBlock.SetColorImpl_InjectedDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.SetColorImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::SetColorImpl_Injected");
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x00038868 File Offset: 0x00036A68
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 650392, RefRangeEnd = 650395, XrefRangeStart = 650390, XrefRangeEnd = 650392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIntImpl(int name, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetIntImpl_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x000388B4 File Offset: 0x00036AB4
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 650397, RefRangeEnd = 650415, XrefRangeStart = 650395, XrefRangeEnd = 650397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFloatImpl(int name, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetFloatImpl_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x00038900 File Offset: 0x00036B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650415, XrefRangeEnd = 650417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVectorImpl(int name, Vector4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetVectorImpl_Private_Void_Int32_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x0003894C File Offset: 0x00036B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650417, XrefRangeEnd = 650419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMatrixImpl(int name, Matrix4x4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetMatrixImpl_Private_Void_Int32_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x00038998 File Offset: 0x00036B98
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 650421, RefRangeEnd = 650439, XrefRangeStart = 650419, XrefRangeEnd = 650421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTextureImpl(int name, Texture value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetTextureImpl_Private_Void_Int32_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x000389E8 File Offset: 0x00036BE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 650441, RefRangeEnd = 650442, XrefRangeStart = 650439, XrefRangeEnd = 650441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRenderTextureImpl(int name, RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref element;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetRenderTextureImpl_Private_Void_Int32_RenderTexture_RenderTextureSubElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x00038A48 File Offset: 0x00036C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650442, XrefRangeEnd = 650444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFloatArrayImpl(int name, Il2CppStructArray<float> values, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetFloatArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x00038AA8 File Offset: 0x00036CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650444, XrefRangeEnd = 650446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVectorArrayImpl(int name, Il2CppStructArray<Vector4> values, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetVectorArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x00038B08 File Offset: 0x00036D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650446, XrefRangeEnd = 650448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMatrixArrayImpl(int name, Il2CppStructArray<Matrix4x4> values, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetMatrixArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Matrix4x4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x00038B68 File Offset: 0x00036D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650448, XrefRangeEnd = 650450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CreateImpl()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_CreateImpl_Private_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x00038B98 File Offset: 0x00036D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650450, XrefRangeEnd = 650452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DestroyImpl(IntPtr mpb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mpb;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_DestroyImpl_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x00038BCC File Offset: 0x00036DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650452, XrefRangeEnd = 650454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear(bool keepMemory)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keepMemory;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_Clear_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x00038C0C File Offset: 0x00036E0C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 650456, RefRangeEnd = 650463, XrefRangeStart = 650454, XrefRangeEnd = 650456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x00038C40 File Offset: 0x00036E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650463, XrefRangeEnd = 650483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFloatArray(int name, Il2CppStructArray<float> values, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetFloatArray_Private_Void_Int32_Il2CppStructArray_1_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x00038CA0 File Offset: 0x00036EA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 650503, RefRangeEnd = 650505, XrefRangeStart = 650483, XrefRangeEnd = 650503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVectorArray(int name, Il2CppStructArray<Vector4> values, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetVectorArray_Private_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x00038D00 File Offset: 0x00036F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650505, XrefRangeEnd = 650525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMatrixArray(int name, Il2CppStructArray<Matrix4x4> values, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetMatrixArray_Private_Void_Int32_Il2CppStructArray_1_Matrix4x4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x00038D60 File Offset: 0x00036F60
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 650528, RefRangeEnd = 650533, XrefRangeStart = 650525, XrefRangeEnd = 650528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaterialPropertyBlock()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x00038D9C File Offset: 0x00036F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650533, XrefRangeEnd = 650543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x00038DD0 File Offset: 0x00036FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650543, XrefRangeEnd = 650550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_Dispose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x00038E04 File Offset: 0x00037004
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 650554, RefRangeEnd = 650557, XrefRangeStart = 650550, XrefRangeEnd = 650554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInt(string name, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetInt_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x00038E54 File Offset: 0x00037054
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 650559, RefRangeEnd = 650564, XrefRangeStart = 650557, XrefRangeEnd = 650559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInt(int nameID, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetInt_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x00038EA0 File Offset: 0x000370A0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 650568, RefRangeEnd = 650575, XrefRangeStart = 650564, XrefRangeEnd = 650568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFloat(string name, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetFloat_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x00038EF0 File Offset: 0x000370F0
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 650397, RefRangeEnd = 650415, XrefRangeStart = 650397, XrefRangeEnd = 650415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFloat(int nameID, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetFloat_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x00038F3C File Offset: 0x0003713C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 650392, RefRangeEnd = 650395, XrefRangeStart = 650392, XrefRangeEnd = 650395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteger(int nameID, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetInteger_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x00038F88 File Offset: 0x00037188
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 650579, RefRangeEnd = 650582, XrefRangeStart = 650575, XrefRangeEnd = 650579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVector(string name, Vector4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetVector_Public_Void_String_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x00038FD8 File Offset: 0x000371D8
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 650584, RefRangeEnd = 650618, XrefRangeStart = 650582, XrefRangeEnd = 650584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVector(int nameID, Vector4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetVector_Public_Void_Int32_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x00039024 File Offset: 0x00037224
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 650622, RefRangeEnd = 650624, XrefRangeStart = 650618, XrefRangeEnd = 650622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMatrix(string name, Matrix4x4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetMatrix_Public_Void_String_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x00039074 File Offset: 0x00037274
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 650626, RefRangeEnd = 650627, XrefRangeStart = 650624, XrefRangeEnd = 650626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMatrix(int nameID, Matrix4x4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetMatrix_Public_Void_Int32_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x000390C0 File Offset: 0x000372C0
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 650421, RefRangeEnd = 650439, XrefRangeStart = 650421, XrefRangeEnd = 650439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTexture(int nameID, Texture value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetTexture_Public_Void_Int32_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x00039110 File Offset: 0x00037310
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 650441, RefRangeEnd = 650442, XrefRangeStart = 650441, XrefRangeEnd = 650442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTexture(int nameID, RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref element;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetTexture_Public_Void_Int32_RenderTexture_RenderTextureSubElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x00039170 File Offset: 0x00037370
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 650638, RefRangeEnd = 650643, XrefRangeStart = 650627, XrefRangeEnd = 650638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFloatArray(string name, Il2CppStructArray<float> values)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetFloatArray_Public_Void_String_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x000391C4 File Offset: 0x000373C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 650646, RefRangeEnd = 650648, XrefRangeStart = 650643, XrefRangeEnd = 650646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVectorArray(string name, Il2CppStructArray<Vector4> values)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetVectorArray_Public_Void_String_Il2CppStructArray_1_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x00039218 File Offset: 0x00037418
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 650649, RefRangeEnd = 650650, XrefRangeStart = 650648, XrefRangeEnd = 650649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVectorArray(int nameID, Il2CppStructArray<Vector4> values)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetVectorArray_Public_Void_Int32_Il2CppStructArray_1_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x00039268 File Offset: 0x00037468
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 650661, RefRangeEnd = 650663, XrefRangeStart = 650650, XrefRangeEnd = 650661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMatrixArray(string name, Il2CppStructArray<Matrix4x4> values)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetMatrixArray_Public_Void_String_Il2CppStructArray_1_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x000392BC File Offset: 0x000374BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650663, XrefRangeEnd = 650665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVectorImpl_Injected(int name, ref Vector4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetVectorImpl_Injected_Private_Void_Int32_byref_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x00039308 File Offset: 0x00037508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650665, XrefRangeEnd = 650667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMatrixImpl_Injected(int name, ref Matrix4x4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetMatrixImpl_Injected_Private_Void_Int32_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x00006528 File Offset: 0x00004728
		public MaterialPropertyBlock(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000B0E RID: 2830 RVA: 0x00039354 File Offset: 0x00037554
		// (set) Token: 0x06000B0F RID: 2831 RVA: 0x00006531 File Offset: 0x00004731
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialPropertyBlock.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialPropertyBlock.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x0000654C File Offset: 0x0000474C
		public void AddFloat(string name, float value)
		{
			this.SetFloat(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x0000655D File Offset: 0x0000475D
		public void AddFloat(int nameID, float value)
		{
			this.SetFloat(nameID, value);
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x00006569 File Offset: 0x00004769
		public void AddVector(string name, Vector4 value)
		{
			this.SetVector(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x0000657A File Offset: 0x0000477A
		public void AddVector(int nameID, Vector4 value)
		{
			this.SetVector(nameID, value);
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x00006586 File Offset: 0x00004786
		public void AddColor(string name, Color value)
		{
			this.SetColor(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x00006597 File Offset: 0x00004797
		public void AddColor(int nameID, Color value)
		{
			this.SetColor(nameID, value);
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x000065A3 File Offset: 0x000047A3
		public void AddMatrix(string name, Matrix4x4 value)
		{
			this.SetMatrix(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x000065B4 File Offset: 0x000047B4
		public void AddMatrix(int nameID, Matrix4x4 value)
		{
			this.SetMatrix(nameID, value);
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x000065C0 File Offset: 0x000047C0
		public void AddTexture(string name, Texture value)
		{
			this.SetTexture(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x000065D1 File Offset: 0x000047D1
		public void AddTexture(int nameID, Texture value)
		{
			this.SetTexture(nameID, value);
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x000065DD File Offset: 0x000047DD
		public int GetIntImpl(int name)
		{
			return MaterialPropertyBlock.GetIntImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x000065F0 File Offset: 0x000047F0
		public float GetFloatImpl(int name)
		{
			return MaterialPropertyBlock.GetFloatImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x0003937C File Offset: 0x0003757C
		public Vector4 GetVectorImpl(int name)
		{
			Vector4 vector;
			this.GetVectorImpl_Injected(name, out vector);
			return vector;
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x00039394 File Offset: 0x00037594
		public Color GetColorImpl(int name)
		{
			Color color;
			this.GetColorImpl_Injected(name, out color);
			return color;
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x000393AC File Offset: 0x000375AC
		public Matrix4x4 GetMatrixImpl(int name)
		{
			Matrix4x4 matrix4x;
			this.GetMatrixImpl_Injected(name, out matrix4x);
			return matrix4x;
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x000393C4 File Offset: 0x000375C4
		public Texture GetTextureImpl(int name)
		{
			IntPtr intPtr = MaterialPropertyBlock.GetTextureImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x00006603 File Offset: 0x00004803
		public bool HasPropertyImpl(int name)
		{
			return MaterialPropertyBlock.HasPropertyImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x00006616 File Offset: 0x00004816
		public bool HasFloatImpl(int name)
		{
			return MaterialPropertyBlock.HasFloatImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x00006629 File Offset: 0x00004829
		public bool HasIntImpl(int name)
		{
			return MaterialPropertyBlock.HasIntImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x0000663C File Offset: 0x0000483C
		public bool HasTextureImpl(int name)
		{
			return MaterialPropertyBlock.HasTextureImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x0000664F File Offset: 0x0000484F
		public bool HasMatrixImpl(int name)
		{
			return MaterialPropertyBlock.HasMatrixImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x00006662 File Offset: 0x00004862
		public bool HasVectorImpl(int name)
		{
			return MaterialPropertyBlock.HasVectorImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x00006675 File Offset: 0x00004875
		public bool HasBufferImpl(int name)
		{
			return MaterialPropertyBlock.HasBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x00006688 File Offset: 0x00004888
		public bool HasConstantBufferImpl(int name)
		{
			return MaterialPropertyBlock.HasConstantBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x0000669B File Offset: 0x0000489B
		public void SetColorImpl(int name, Color value)
		{
			this.SetColorImpl_Injected(name, ref value);
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x000066A6 File Offset: 0x000048A6
		public void SetBufferImpl(int name, ComputeBuffer value)
		{
			MaterialPropertyBlock.SetBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(value));
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x000066BF File Offset: 0x000048BF
		public void SetGraphicsBufferImpl(int name, GraphicsBuffer value)
		{
			MaterialPropertyBlock.SetGraphicsBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(value));
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x000066D8 File Offset: 0x000048D8
		public void SetConstantBufferImpl(int name, ComputeBuffer value, int offset, int size)
		{
			MaterialPropertyBlock.SetConstantBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(value), offset, size);
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x000066F4 File Offset: 0x000048F4
		public void SetConstantGraphicsBufferImpl(int name, GraphicsBuffer value, int offset, int size)
		{
			MaterialPropertyBlock.SetConstantGraphicsBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(value), offset, size);
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x000393F4 File Offset: 0x000375F4
		public Il2CppStructArray<float> GetFloatArrayImpl(int name)
		{
			IntPtr intPtr = MaterialPropertyBlock.GetFloatArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x00039424 File Offset: 0x00037624
		public Il2CppStructArray<Vector4> GetVectorArrayImpl(int name)
		{
			IntPtr intPtr = MaterialPropertyBlock.GetVectorArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x00039454 File Offset: 0x00037654
		public Il2CppStructArray<Matrix4x4> GetMatrixArrayImpl(int name)
		{
			IntPtr intPtr = MaterialPropertyBlock.GetMatrixArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x00006710 File Offset: 0x00004910
		public int GetFloatArrayCountImpl(int name)
		{
			return MaterialPropertyBlock.GetFloatArrayCountImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x00006723 File Offset: 0x00004923
		public int GetVectorArrayCountImpl(int name)
		{
			return MaterialPropertyBlock.GetVectorArrayCountImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x00006736 File Offset: 0x00004936
		public int GetMatrixArrayCountImpl(int name)
		{
			return MaterialPropertyBlock.GetMatrixArrayCountImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x00006749 File Offset: 0x00004949
		public void ExtractFloatArrayImpl(int name, [Out] Il2CppStructArray<float> val)
		{
			MaterialPropertyBlock.ExtractFloatArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(val));
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x00006762 File Offset: 0x00004962
		public void ExtractVectorArrayImpl(int name, [Out] Il2CppStructArray<Vector4> val)
		{
			MaterialPropertyBlock.ExtractVectorArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(val));
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x0000677B File Offset: 0x0000497B
		public void ExtractMatrixArrayImpl(int name, [Out] Il2CppStructArray<Matrix4x4> val)
		{
			MaterialPropertyBlock.ExtractMatrixArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(val));
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x00006794 File Offset: 0x00004994
		public static void Internal_CopySHCoefficientArraysFrom(MaterialPropertyBlock properties, Il2CppStructArray<UnityEngine.Rendering.SphericalHarmonicsL2> lightProbes, int sourceStart, int destStart, int count)
		{
			MaterialPropertyBlock.Internal_CopySHCoefficientArraysFromDelegateField(IL2CPP.Il2CppObjectBaseToPtr(properties), IL2CPP.Il2CppObjectBaseToPtr(lightProbes), sourceStart, destStart, count);
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x000067B0 File Offset: 0x000049B0
		public static void Internal_CopyProbeOcclusionArrayFrom(MaterialPropertyBlock properties, Il2CppStructArray<Vector4> occlusionProbes, int sourceStart, int destStart, int count)
		{
			MaterialPropertyBlock.Internal_CopyProbeOcclusionArrayFromDelegateField(IL2CPP.Il2CppObjectBaseToPtr(properties), IL2CPP.Il2CppObjectBaseToPtr(occlusionProbes), sourceStart, destStart, count);
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000B38 RID: 2872 RVA: 0x000067CC File Offset: 0x000049CC
		public bool isEmpty
		{
			get
			{
				return MaterialPropertyBlock.get_isEmptyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x00039484 File Offset: 0x00037684
		public void ExtractFloatArray(int name, List<float> values)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			values.Clear();
			int floatArrayCountImpl = this.GetFloatArrayCountImpl(name);
			bool flag2 = floatArrayCountImpl > 0;
			if (flag2)
			{
				NoAllocHelpers.EnsureListElemCount<float>(values, floatArrayCountImpl);
				this.ExtractFloatArrayImpl(name, NoAllocHelpers.ExtractArrayFromList(values).Cast<Il2CppStructArray<float>>());
			}
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x000394DC File Offset: 0x000376DC
		public void ExtractVectorArray(int name, List<Vector4> values)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			values.Clear();
			int vectorArrayCountImpl = this.GetVectorArrayCountImpl(name);
			bool flag2 = vectorArrayCountImpl > 0;
			if (flag2)
			{
				NoAllocHelpers.EnsureListElemCount<Vector4>(values, vectorArrayCountImpl);
				this.ExtractVectorArrayImpl(name, NoAllocHelpers.ExtractArrayFromList(values).Cast<Il2CppStructArray<Vector4>>());
			}
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x00039534 File Offset: 0x00037734
		public void ExtractMatrixArray(int name, List<Matrix4x4> values)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			values.Clear();
			int matrixArrayCountImpl = this.GetMatrixArrayCountImpl(name);
			bool flag2 = matrixArrayCountImpl > 0;
			if (flag2)
			{
				NoAllocHelpers.EnsureListElemCount<Matrix4x4>(values, matrixArrayCountImpl);
				this.ExtractMatrixArrayImpl(name, NoAllocHelpers.ExtractArrayFromList(values).Cast<Il2CppStructArray<Matrix4x4>>());
			}
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x000067DE File Offset: 0x000049DE
		public void SetInteger(string name, int value)
		{
			this.SetIntImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x000067EF File Offset: 0x000049EF
		public void SetColor(string name, Color value)
		{
			this.SetColorImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x00006800 File Offset: 0x00004A00
		public void SetColor(int nameID, Color value)
		{
			this.SetColorImpl(nameID, value);
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x0000680C File Offset: 0x00004A0C
		public void SetBuffer(string name, ComputeBuffer value)
		{
			this.SetBufferImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x0000681D File Offset: 0x00004A1D
		public void SetBuffer(int nameID, ComputeBuffer value)
		{
			this.SetBufferImpl(nameID, value);
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x00006829 File Offset: 0x00004A29
		public void SetBuffer(string name, GraphicsBuffer value)
		{
			this.SetGraphicsBufferImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x0000683A File Offset: 0x00004A3A
		public void SetBuffer(int nameID, GraphicsBuffer value)
		{
			this.SetGraphicsBufferImpl(nameID, value);
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x00006846 File Offset: 0x00004A46
		public void SetTexture(string name, Texture value)
		{
			this.SetTextureImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x00006857 File Offset: 0x00004A57
		public void SetTexture(string name, RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			this.SetRenderTextureImpl(Shader.PropertyToID(name), value, element);
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x00006869 File Offset: 0x00004A69
		public void SetConstantBuffer(string name, ComputeBuffer value, int offset, int size)
		{
			this.SetConstantBufferImpl(Shader.PropertyToID(name), value, offset, size);
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x0000687D File Offset: 0x00004A7D
		public void SetConstantBuffer(int nameID, ComputeBuffer value, int offset, int size)
		{
			this.SetConstantBufferImpl(nameID, value, offset, size);
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x0000688C File Offset: 0x00004A8C
		public void SetConstantBuffer(string name, GraphicsBuffer value, int offset, int size)
		{
			this.SetConstantGraphicsBufferImpl(Shader.PropertyToID(name), value, offset, size);
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x000068A0 File Offset: 0x00004AA0
		public void SetConstantBuffer(int nameID, GraphicsBuffer value, int offset, int size)
		{
			this.SetConstantGraphicsBufferImpl(nameID, value, offset, size);
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x000068AF File Offset: 0x00004AAF
		public void SetFloatArray(string name, List<float> values)
		{
			this.SetFloatArray(Shader.PropertyToID(name), NoAllocHelpers.ExtractArrayFromListT<float>(values), values.Count);
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x000068CB File Offset: 0x00004ACB
		public void SetFloatArray(int nameID, List<float> values)
		{
			this.SetFloatArray(nameID, NoAllocHelpers.ExtractArrayFromListT<float>(values), values.Count);
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x000068E2 File Offset: 0x00004AE2
		public void SetFloatArray(int nameID, Il2CppStructArray<float> values)
		{
			this.SetFloatArray(nameID, values, values.Length);
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x000068F5 File Offset: 0x00004AF5
		public void SetVectorArray(string name, List<Vector4> values)
		{
			this.SetVectorArray(Shader.PropertyToID(name), NoAllocHelpers.ExtractArrayFromListT<Vector4>(values), values.Count);
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x00006911 File Offset: 0x00004B11
		public void SetVectorArray(int nameID, List<Vector4> values)
		{
			this.SetVectorArray(nameID, NoAllocHelpers.ExtractArrayFromListT<Vector4>(values), values.Count);
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x00006928 File Offset: 0x00004B28
		public void SetMatrixArray(string name, List<Matrix4x4> values)
		{
			this.SetMatrixArray(Shader.PropertyToID(name), NoAllocHelpers.ExtractArrayFromListT<Matrix4x4>(values), values.Count);
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x00006944 File Offset: 0x00004B44
		public void SetMatrixArray(int nameID, List<Matrix4x4> values)
		{
			this.SetMatrixArray(nameID, NoAllocHelpers.ExtractArrayFromListT<Matrix4x4>(values), values.Count);
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x0000695B File Offset: 0x00004B5B
		public void SetMatrixArray(int nameID, Il2CppStructArray<Matrix4x4> values)
		{
			this.SetMatrixArray(nameID, values, values.Length);
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x0003958C File Offset: 0x0003778C
		public bool HasProperty(string name)
		{
			return this.HasPropertyImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x000395AC File Offset: 0x000377AC
		public bool HasProperty(int nameID)
		{
			return this.HasPropertyImpl(nameID);
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x000395C8 File Offset: 0x000377C8
		public bool HasInt(string name)
		{
			return this.HasFloatImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x000395E8 File Offset: 0x000377E8
		public bool HasInt(int nameID)
		{
			return this.HasFloatImpl(nameID);
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x00039604 File Offset: 0x00037804
		public bool HasFloat(string name)
		{
			return this.HasFloatImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x00039624 File Offset: 0x00037824
		public bool HasFloat(int nameID)
		{
			return this.HasFloatImpl(nameID);
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x00039640 File Offset: 0x00037840
		public bool HasInteger(string name)
		{
			return this.HasIntImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x00039660 File Offset: 0x00037860
		public bool HasInteger(int nameID)
		{
			return this.HasIntImpl(nameID);
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x0003967C File Offset: 0x0003787C
		public bool HasTexture(string name)
		{
			return this.HasTextureImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x0003969C File Offset: 0x0003789C
		public bool HasTexture(int nameID)
		{
			return this.HasTextureImpl(nameID);
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x000396B8 File Offset: 0x000378B8
		public bool HasMatrix(string name)
		{
			return this.HasMatrixImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x000396D8 File Offset: 0x000378D8
		public bool HasMatrix(int nameID)
		{
			return this.HasMatrixImpl(nameID);
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x000396F4 File Offset: 0x000378F4
		public bool HasVector(string name)
		{
			return this.HasVectorImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x00039714 File Offset: 0x00037914
		public bool HasVector(int nameID)
		{
			return this.HasVectorImpl(nameID);
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x00039730 File Offset: 0x00037930
		public bool HasColor(string name)
		{
			return this.HasVectorImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x00039750 File Offset: 0x00037950
		public bool HasColor(int nameID)
		{
			return this.HasVectorImpl(nameID);
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x0003976C File Offset: 0x0003796C
		public bool HasBuffer(string name)
		{
			return this.HasBufferImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x0003978C File Offset: 0x0003798C
		public bool HasBuffer(int nameID)
		{
			return this.HasBufferImpl(nameID);
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x000397A8 File Offset: 0x000379A8
		public bool HasConstantBuffer(string name)
		{
			return this.HasConstantBufferImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x000397C8 File Offset: 0x000379C8
		public bool HasConstantBuffer(int nameID)
		{
			return this.HasConstantBufferImpl(nameID);
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x000397E4 File Offset: 0x000379E4
		public float GetFloat(string name)
		{
			return this.GetFloatImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x00039804 File Offset: 0x00037A04
		public float GetFloat(int nameID)
		{
			return this.GetFloatImpl(nameID);
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x00039820 File Offset: 0x00037A20
		public int GetInt(string name)
		{
			return (int)this.GetFloatImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x00039840 File Offset: 0x00037A40
		public int GetInt(int nameID)
		{
			return (int)this.GetFloatImpl(nameID);
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x0003985C File Offset: 0x00037A5C
		public int GetInteger(string name)
		{
			return this.GetIntImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x0003987C File Offset: 0x00037A7C
		public int GetInteger(int nameID)
		{
			return this.GetIntImpl(nameID);
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x00039898 File Offset: 0x00037A98
		public Vector4 GetVector(string name)
		{
			return this.GetVectorImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x000398B8 File Offset: 0x00037AB8
		public Vector4 GetVector(int nameID)
		{
			return this.GetVectorImpl(nameID);
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x000398D4 File Offset: 0x00037AD4
		public Color GetColor(string name)
		{
			return this.GetColorImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x000398F4 File Offset: 0x00037AF4
		public Color GetColor(int nameID)
		{
			return this.GetColorImpl(nameID);
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x00039910 File Offset: 0x00037B10
		public Matrix4x4 GetMatrix(string name)
		{
			return this.GetMatrixImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x00039930 File Offset: 0x00037B30
		public Matrix4x4 GetMatrix(int nameID)
		{
			return this.GetMatrixImpl(nameID);
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x0003994C File Offset: 0x00037B4C
		public Texture GetTexture(string name)
		{
			return this.GetTextureImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x0003996C File Offset: 0x00037B6C
		public Texture GetTexture(int nameID)
		{
			return this.GetTextureImpl(nameID);
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x00039988 File Offset: 0x00037B88
		public Il2CppStructArray<float> GetFloatArray(string name)
		{
			return this.GetFloatArray(Shader.PropertyToID(name));
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x000399A8 File Offset: 0x00037BA8
		public Il2CppStructArray<float> GetFloatArray(int nameID)
		{
			return (this.GetFloatArrayCountImpl(nameID) != 0) ? this.GetFloatArrayImpl(nameID) : null;
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x000399D0 File Offset: 0x00037BD0
		public Il2CppStructArray<Vector4> GetVectorArray(string name)
		{
			return this.GetVectorArray(Shader.PropertyToID(name));
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x000399F0 File Offset: 0x00037BF0
		public Il2CppStructArray<Vector4> GetVectorArray(int nameID)
		{
			return (this.GetVectorArrayCountImpl(nameID) != 0) ? this.GetVectorArrayImpl(nameID) : null;
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x00039A18 File Offset: 0x00037C18
		public Il2CppStructArray<Matrix4x4> GetMatrixArray(string name)
		{
			return this.GetMatrixArray(Shader.PropertyToID(name));
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x00039A38 File Offset: 0x00037C38
		public Il2CppStructArray<Matrix4x4> GetMatrixArray(int nameID)
		{
			return (this.GetMatrixArrayCountImpl(nameID) != 0) ? this.GetMatrixArrayImpl(nameID) : null;
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x0000696E File Offset: 0x00004B6E
		public void GetFloatArray(string name, List<float> values)
		{
			this.ExtractFloatArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x0000697F File Offset: 0x00004B7F
		public void GetFloatArray(int nameID, List<float> values)
		{
			this.ExtractFloatArray(nameID, values);
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x0000698B File Offset: 0x00004B8B
		public void GetVectorArray(string name, List<Vector4> values)
		{
			this.ExtractVectorArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x0000699C File Offset: 0x00004B9C
		public void GetVectorArray(int nameID, List<Vector4> values)
		{
			this.ExtractVectorArray(nameID, values);
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x000069A8 File Offset: 0x00004BA8
		public void GetMatrixArray(string name, List<Matrix4x4> values)
		{
			this.ExtractMatrixArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x000069B9 File Offset: 0x00004BB9
		public void GetMatrixArray(int nameID, List<Matrix4x4> values)
		{
			this.ExtractMatrixArray(nameID, values);
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x00039A60 File Offset: 0x00037C60
		public void CopySHCoefficientArraysFrom(List<UnityEngine.Rendering.SphericalHarmonicsL2> lightProbes)
		{
			bool flag = lightProbes == null;
			if (flag)
			{
				throw new ArgumentNullException("lightProbes");
			}
			this.CopySHCoefficientArraysFrom(NoAllocHelpers.ExtractArrayFromListT<UnityEngine.Rendering.SphericalHarmonicsL2>(lightProbes), 0, 0, lightProbes.Count);
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x00039A98 File Offset: 0x00037C98
		public void CopySHCoefficientArraysFrom(Il2CppStructArray<UnityEngine.Rendering.SphericalHarmonicsL2> lightProbes)
		{
			bool flag = lightProbes == null;
			if (flag)
			{
				throw new ArgumentNullException("lightProbes");
			}
			this.CopySHCoefficientArraysFrom(lightProbes, 0, 0, lightProbes.Length);
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x000069C5 File Offset: 0x00004BC5
		public void CopySHCoefficientArraysFrom(List<UnityEngine.Rendering.SphericalHarmonicsL2> lightProbes, int sourceStart, int destStart, int count)
		{
			this.CopySHCoefficientArraysFrom(NoAllocHelpers.ExtractArrayFromListT<UnityEngine.Rendering.SphericalHarmonicsL2>(lightProbes), sourceStart, destStart, count);
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x00039ACC File Offset: 0x00037CCC
		public void CopySHCoefficientArraysFrom(Il2CppStructArray<UnityEngine.Rendering.SphericalHarmonicsL2> lightProbes, int sourceStart, int destStart, int count)
		{
			bool flag = lightProbes == null;
			if (flag)
			{
				throw new ArgumentNullException("lightProbes");
			}
			bool flag2 = sourceStart < 0;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("sourceStart", "Argument sourceStart must not be negative.");
			}
			bool flag3 = destStart < 0;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException("sourceStart", "Argument destStart must not be negative.");
			}
			bool flag4 = count < 0;
			if (flag4)
			{
				throw new ArgumentOutOfRangeException("count", "Argument count must not be negative.");
			}
			bool flag5 = lightProbes.Length < sourceStart + count;
			if (flag5)
			{
				throw new ArgumentOutOfRangeException("The specified source start index or count is out of the range.");
			}
			MaterialPropertyBlock.Internal_CopySHCoefficientArraysFrom(this, lightProbes, sourceStart, destStart, count);
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x00039B60 File Offset: 0x00037D60
		public void CopyProbeOcclusionArrayFrom(List<Vector4> occlusionProbes)
		{
			bool flag = occlusionProbes == null;
			if (flag)
			{
				throw new ArgumentNullException("occlusionProbes");
			}
			this.CopyProbeOcclusionArrayFrom(NoAllocHelpers.ExtractArrayFromListT<Vector4>(occlusionProbes), 0, 0, occlusionProbes.Count);
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x00039B98 File Offset: 0x00037D98
		public void CopyProbeOcclusionArrayFrom(Il2CppStructArray<Vector4> occlusionProbes)
		{
			bool flag = occlusionProbes == null;
			if (flag)
			{
				throw new ArgumentNullException("occlusionProbes");
			}
			this.CopyProbeOcclusionArrayFrom(occlusionProbes, 0, 0, occlusionProbes.Length);
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x000069D9 File Offset: 0x00004BD9
		public void CopyProbeOcclusionArrayFrom(List<Vector4> occlusionProbes, int sourceStart, int destStart, int count)
		{
			this.CopyProbeOcclusionArrayFrom(NoAllocHelpers.ExtractArrayFromListT<Vector4>(occlusionProbes), sourceStart, destStart, count);
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x00039BCC File Offset: 0x00037DCC
		public void CopyProbeOcclusionArrayFrom(Il2CppStructArray<Vector4> occlusionProbes, int sourceStart, int destStart, int count)
		{
			bool flag = occlusionProbes == null;
			if (flag)
			{
				throw new ArgumentNullException("occlusionProbes");
			}
			bool flag2 = sourceStart < 0;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("sourceStart", "Argument sourceStart must not be negative.");
			}
			bool flag3 = destStart < 0;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException("sourceStart", "Argument destStart must not be negative.");
			}
			bool flag4 = count < 0;
			if (flag4)
			{
				throw new ArgumentOutOfRangeException("count", "Argument count must not be negative.");
			}
			bool flag5 = occlusionProbes.Length < sourceStart + count;
			if (flag5)
			{
				throw new ArgumentOutOfRangeException("The specified source start index or count is out of the range.");
			}
			MaterialPropertyBlock.Internal_CopyProbeOcclusionArrayFrom(this, occlusionProbes, sourceStart, destStart, count);
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x000069ED File Offset: 0x00004BED
		public void GetVectorImpl_Injected(int name, out Vector4 ret)
		{
			MaterialPropertyBlock.GetVectorImpl_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, out ret);
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x00006A01 File Offset: 0x00004C01
		public void GetColorImpl_Injected(int name, out Color ret)
		{
			MaterialPropertyBlock.GetColorImpl_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, out ret);
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x00006A15 File Offset: 0x00004C15
		public void GetMatrixImpl_Injected(int name, out Matrix4x4 ret)
		{
			MaterialPropertyBlock.GetMatrixImpl_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, out ret);
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x00006A29 File Offset: 0x00004C29
		public void SetColorImpl_Injected(int name, ref Color value)
		{
			MaterialPropertyBlock.SetColorImpl_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, ref value);
		}

		// Token: 0x04000885 RID: 2181
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04000886 RID: 2182
		private static readonly IntPtr NativeMethodInfoPtr_SetIntImpl_Private_Void_Int32_Int32_0;

		// Token: 0x04000887 RID: 2183
		private static readonly IntPtr NativeMethodInfoPtr_SetFloatImpl_Private_Void_Int32_Single_0;

		// Token: 0x04000888 RID: 2184
		private static readonly IntPtr NativeMethodInfoPtr_SetVectorImpl_Private_Void_Int32_Vector4_0;

		// Token: 0x04000889 RID: 2185
		private static readonly IntPtr NativeMethodInfoPtr_SetMatrixImpl_Private_Void_Int32_Matrix4x4_0;

		// Token: 0x0400088A RID: 2186
		private static readonly IntPtr NativeMethodInfoPtr_SetTextureImpl_Private_Void_Int32_Texture_0;

		// Token: 0x0400088B RID: 2187
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTextureImpl_Private_Void_Int32_RenderTexture_RenderTextureSubElement_0;

		// Token: 0x0400088C RID: 2188
		private static readonly IntPtr NativeMethodInfoPtr_SetFloatArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Single_Int32_0;

		// Token: 0x0400088D RID: 2189
		private static readonly IntPtr NativeMethodInfoPtr_SetVectorArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0;

		// Token: 0x0400088E RID: 2190
		private static readonly IntPtr NativeMethodInfoPtr_SetMatrixArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Matrix4x4_Int32_0;

		// Token: 0x0400088F RID: 2191
		private static readonly IntPtr NativeMethodInfoPtr_CreateImpl_Private_Static_IntPtr_0;

		// Token: 0x04000890 RID: 2192
		private static readonly IntPtr NativeMethodInfoPtr_DestroyImpl_Private_Static_Void_IntPtr_0;

		// Token: 0x04000891 RID: 2193
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Private_Void_Boolean_0;

		// Token: 0x04000892 RID: 2194
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04000893 RID: 2195
		private static readonly IntPtr NativeMethodInfoPtr_SetFloatArray_Private_Void_Int32_Il2CppStructArray_1_Single_Int32_0;

		// Token: 0x04000894 RID: 2196
		private static readonly IntPtr NativeMethodInfoPtr_SetVectorArray_Private_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0;

		// Token: 0x04000895 RID: 2197
		private static readonly IntPtr NativeMethodInfoPtr_SetMatrixArray_Private_Void_Int32_Il2CppStructArray_1_Matrix4x4_Int32_0;

		// Token: 0x04000896 RID: 2198
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000897 RID: 2199
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000898 RID: 2200
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_0;

		// Token: 0x04000899 RID: 2201
		private static readonly IntPtr NativeMethodInfoPtr_SetInt_Public_Void_String_Int32_0;

		// Token: 0x0400089A RID: 2202
		private static readonly IntPtr NativeMethodInfoPtr_SetInt_Public_Void_Int32_Int32_0;

		// Token: 0x0400089B RID: 2203
		private static readonly IntPtr NativeMethodInfoPtr_SetFloat_Public_Void_String_Single_0;

		// Token: 0x0400089C RID: 2204
		private static readonly IntPtr NativeMethodInfoPtr_SetFloat_Public_Void_Int32_Single_0;

		// Token: 0x0400089D RID: 2205
		private static readonly IntPtr NativeMethodInfoPtr_SetInteger_Public_Void_Int32_Int32_0;

		// Token: 0x0400089E RID: 2206
		private static readonly IntPtr NativeMethodInfoPtr_SetVector_Public_Void_String_Vector4_0;

		// Token: 0x0400089F RID: 2207
		private static readonly IntPtr NativeMethodInfoPtr_SetVector_Public_Void_Int32_Vector4_0;

		// Token: 0x040008A0 RID: 2208
		private static readonly IntPtr NativeMethodInfoPtr_SetMatrix_Public_Void_String_Matrix4x4_0;

		// Token: 0x040008A1 RID: 2209
		private static readonly IntPtr NativeMethodInfoPtr_SetMatrix_Public_Void_Int32_Matrix4x4_0;

		// Token: 0x040008A2 RID: 2210
		private static readonly IntPtr NativeMethodInfoPtr_SetTexture_Public_Void_Int32_Texture_0;

		// Token: 0x040008A3 RID: 2211
		private static readonly IntPtr NativeMethodInfoPtr_SetTexture_Public_Void_Int32_RenderTexture_RenderTextureSubElement_0;

		// Token: 0x040008A4 RID: 2212
		private static readonly IntPtr NativeMethodInfoPtr_SetFloatArray_Public_Void_String_Il2CppStructArray_1_Single_0;

		// Token: 0x040008A5 RID: 2213
		private static readonly IntPtr NativeMethodInfoPtr_SetVectorArray_Public_Void_String_Il2CppStructArray_1_Vector4_0;

		// Token: 0x040008A6 RID: 2214
		private static readonly IntPtr NativeMethodInfoPtr_SetVectorArray_Public_Void_Int32_Il2CppStructArray_1_Vector4_0;

		// Token: 0x040008A7 RID: 2215
		private static readonly IntPtr NativeMethodInfoPtr_SetMatrixArray_Public_Void_String_Il2CppStructArray_1_Matrix4x4_0;

		// Token: 0x040008A8 RID: 2216
		private static readonly IntPtr NativeMethodInfoPtr_SetVectorImpl_Injected_Private_Void_Int32_byref_Vector4_0;

		// Token: 0x040008A9 RID: 2217
		private static readonly IntPtr NativeMethodInfoPtr_SetMatrixImpl_Injected_Private_Void_Int32_byref_Matrix4x4_0;

		// Token: 0x040008AA RID: 2218
		private static readonly MaterialPropertyBlock.GetIntImplDelegate GetIntImplDelegateField;

		// Token: 0x040008AB RID: 2219
		private static readonly MaterialPropertyBlock.GetFloatImplDelegate GetFloatImplDelegateField;

		// Token: 0x040008AC RID: 2220
		private static readonly MaterialPropertyBlock.GetTextureImplDelegate GetTextureImplDelegateField;

		// Token: 0x040008AD RID: 2221
		private static readonly MaterialPropertyBlock.HasPropertyImplDelegate HasPropertyImplDelegateField;

		// Token: 0x040008AE RID: 2222
		private static readonly MaterialPropertyBlock.HasFloatImplDelegate HasFloatImplDelegateField;

		// Token: 0x040008AF RID: 2223
		private static readonly MaterialPropertyBlock.HasIntImplDelegate HasIntImplDelegateField;

		// Token: 0x040008B0 RID: 2224
		private static readonly MaterialPropertyBlock.HasTextureImplDelegate HasTextureImplDelegateField;

		// Token: 0x040008B1 RID: 2225
		private static readonly MaterialPropertyBlock.HasMatrixImplDelegate HasMatrixImplDelegateField;

		// Token: 0x040008B2 RID: 2226
		private static readonly MaterialPropertyBlock.HasVectorImplDelegate HasVectorImplDelegateField;

		// Token: 0x040008B3 RID: 2227
		private static readonly MaterialPropertyBlock.HasBufferImplDelegate HasBufferImplDelegateField;

		// Token: 0x040008B4 RID: 2228
		private static readonly MaterialPropertyBlock.HasConstantBufferImplDelegate HasConstantBufferImplDelegateField;

		// Token: 0x040008B5 RID: 2229
		private static readonly MaterialPropertyBlock.SetBufferImplDelegate SetBufferImplDelegateField;

		// Token: 0x040008B6 RID: 2230
		private static readonly MaterialPropertyBlock.SetGraphicsBufferImplDelegate SetGraphicsBufferImplDelegateField;

		// Token: 0x040008B7 RID: 2231
		private static readonly MaterialPropertyBlock.SetConstantBufferImplDelegate SetConstantBufferImplDelegateField;

		// Token: 0x040008B8 RID: 2232
		private static readonly MaterialPropertyBlock.SetConstantGraphicsBufferImplDelegate SetConstantGraphicsBufferImplDelegateField;

		// Token: 0x040008B9 RID: 2233
		private static readonly MaterialPropertyBlock.GetFloatArrayImplDelegate GetFloatArrayImplDelegateField;

		// Token: 0x040008BA RID: 2234
		private static readonly MaterialPropertyBlock.GetVectorArrayImplDelegate GetVectorArrayImplDelegateField;

		// Token: 0x040008BB RID: 2235
		private static readonly MaterialPropertyBlock.GetMatrixArrayImplDelegate GetMatrixArrayImplDelegateField;

		// Token: 0x040008BC RID: 2236
		private static readonly MaterialPropertyBlock.GetFloatArrayCountImplDelegate GetFloatArrayCountImplDelegateField;

		// Token: 0x040008BD RID: 2237
		private static readonly MaterialPropertyBlock.GetVectorArrayCountImplDelegate GetVectorArrayCountImplDelegateField;

		// Token: 0x040008BE RID: 2238
		private static readonly MaterialPropertyBlock.GetMatrixArrayCountImplDelegate GetMatrixArrayCountImplDelegateField;

		// Token: 0x040008BF RID: 2239
		private static readonly MaterialPropertyBlock.ExtractFloatArrayImplDelegate ExtractFloatArrayImplDelegateField;

		// Token: 0x040008C0 RID: 2240
		private static readonly MaterialPropertyBlock.ExtractVectorArrayImplDelegate ExtractVectorArrayImplDelegateField;

		// Token: 0x040008C1 RID: 2241
		private static readonly MaterialPropertyBlock.ExtractMatrixArrayImplDelegate ExtractMatrixArrayImplDelegateField;

		// Token: 0x040008C2 RID: 2242
		private static readonly MaterialPropertyBlock.Internal_CopySHCoefficientArraysFromDelegate Internal_CopySHCoefficientArraysFromDelegateField;

		// Token: 0x040008C3 RID: 2243
		private static readonly MaterialPropertyBlock.Internal_CopyProbeOcclusionArrayFromDelegate Internal_CopyProbeOcclusionArrayFromDelegateField;

		// Token: 0x040008C4 RID: 2244
		private static readonly MaterialPropertyBlock.get_isEmptyDelegate get_isEmptyDelegateField;

		// Token: 0x040008C5 RID: 2245
		private static readonly MaterialPropertyBlock.GetVectorImpl_InjectedDelegate GetVectorImpl_InjectedDelegateField;

		// Token: 0x040008C6 RID: 2246
		private static readonly MaterialPropertyBlock.GetColorImpl_InjectedDelegate GetColorImpl_InjectedDelegateField;

		// Token: 0x040008C7 RID: 2247
		private static readonly MaterialPropertyBlock.GetMatrixImpl_InjectedDelegate GetMatrixImpl_InjectedDelegateField;

		// Token: 0x040008C8 RID: 2248
		private static readonly MaterialPropertyBlock.SetColorImpl_InjectedDelegate SetColorImpl_InjectedDelegateField;

		// Token: 0x020005AB RID: 1451
		// (Invoke) Token: 0x06003467 RID: 13415
		private delegate int GetIntImplDelegate(IntPtr @this, int name);

		// Token: 0x020005AC RID: 1452
		// (Invoke) Token: 0x06003469 RID: 13417
		private delegate float GetFloatImplDelegate(IntPtr @this, int name);

		// Token: 0x020005AD RID: 1453
		// (Invoke) Token: 0x0600346B RID: 13419
		private delegate IntPtr GetTextureImplDelegate(IntPtr @this, int name);

		// Token: 0x020005AE RID: 1454
		// (Invoke) Token: 0x0600346D RID: 13421
		private delegate bool HasPropertyImplDelegate(IntPtr @this, int name);

		// Token: 0x020005AF RID: 1455
		// (Invoke) Token: 0x0600346F RID: 13423
		private delegate bool HasFloatImplDelegate(IntPtr @this, int name);

		// Token: 0x020005B0 RID: 1456
		// (Invoke) Token: 0x06003471 RID: 13425
		private delegate bool HasIntImplDelegate(IntPtr @this, int name);

		// Token: 0x020005B1 RID: 1457
		// (Invoke) Token: 0x06003473 RID: 13427
		private delegate bool HasTextureImplDelegate(IntPtr @this, int name);

		// Token: 0x020005B2 RID: 1458
		// (Invoke) Token: 0x06003475 RID: 13429
		private delegate bool HasMatrixImplDelegate(IntPtr @this, int name);

		// Token: 0x020005B3 RID: 1459
		// (Invoke) Token: 0x06003477 RID: 13431
		private delegate bool HasVectorImplDelegate(IntPtr @this, int name);

		// Token: 0x020005B4 RID: 1460
		// (Invoke) Token: 0x06003479 RID: 13433
		private delegate bool HasBufferImplDelegate(IntPtr @this, int name);

		// Token: 0x020005B5 RID: 1461
		// (Invoke) Token: 0x0600347B RID: 13435
		private delegate bool HasConstantBufferImplDelegate(IntPtr @this, int name);

		// Token: 0x020005B6 RID: 1462
		// (Invoke) Token: 0x0600347D RID: 13437
		private delegate void SetBufferImplDelegate(IntPtr @this, int name, IntPtr value);

		// Token: 0x020005B7 RID: 1463
		// (Invoke) Token: 0x0600347F RID: 13439
		private delegate void SetGraphicsBufferImplDelegate(IntPtr @this, int name, IntPtr value);

		// Token: 0x020005B8 RID: 1464
		// (Invoke) Token: 0x06003481 RID: 13441
		private delegate void SetConstantBufferImplDelegate(IntPtr @this, int name, IntPtr value, int offset, int size);

		// Token: 0x020005B9 RID: 1465
		// (Invoke) Token: 0x06003483 RID: 13443
		private delegate void SetConstantGraphicsBufferImplDelegate(IntPtr @this, int name, IntPtr value, int offset, int size);

		// Token: 0x020005BA RID: 1466
		// (Invoke) Token: 0x06003485 RID: 13445
		private delegate IntPtr GetFloatArrayImplDelegate(IntPtr @this, int name);

		// Token: 0x020005BB RID: 1467
		// (Invoke) Token: 0x06003487 RID: 13447
		private delegate IntPtr GetVectorArrayImplDelegate(IntPtr @this, int name);

		// Token: 0x020005BC RID: 1468
		// (Invoke) Token: 0x06003489 RID: 13449
		private delegate IntPtr GetMatrixArrayImplDelegate(IntPtr @this, int name);

		// Token: 0x020005BD RID: 1469
		// (Invoke) Token: 0x0600348B RID: 13451
		private delegate int GetFloatArrayCountImplDelegate(IntPtr @this, int name);

		// Token: 0x020005BE RID: 1470
		// (Invoke) Token: 0x0600348D RID: 13453
		private delegate int GetVectorArrayCountImplDelegate(IntPtr @this, int name);

		// Token: 0x020005BF RID: 1471
		// (Invoke) Token: 0x0600348F RID: 13455
		private delegate int GetMatrixArrayCountImplDelegate(IntPtr @this, int name);

		// Token: 0x020005C0 RID: 1472
		// (Invoke) Token: 0x06003491 RID: 13457
		private delegate void ExtractFloatArrayImplDelegate(IntPtr @this, int name, [Out] IntPtr val);

		// Token: 0x020005C1 RID: 1473
		// (Invoke) Token: 0x06003493 RID: 13459
		private delegate void ExtractVectorArrayImplDelegate(IntPtr @this, int name, [Out] IntPtr val);

		// Token: 0x020005C2 RID: 1474
		// (Invoke) Token: 0x06003495 RID: 13461
		private delegate void ExtractMatrixArrayImplDelegate(IntPtr @this, int name, [Out] IntPtr val);

		// Token: 0x020005C3 RID: 1475
		// (Invoke) Token: 0x06003497 RID: 13463
		private delegate void Internal_CopySHCoefficientArraysFromDelegate(IntPtr properties, IntPtr lightProbes, int sourceStart, int destStart, int count);

		// Token: 0x020005C4 RID: 1476
		// (Invoke) Token: 0x06003499 RID: 13465
		private delegate void Internal_CopyProbeOcclusionArrayFromDelegate(IntPtr properties, IntPtr occlusionProbes, int sourceStart, int destStart, int count);

		// Token: 0x020005C5 RID: 1477
		// (Invoke) Token: 0x0600349B RID: 13467
		private delegate bool get_isEmptyDelegate(IntPtr @this);

		// Token: 0x020005C6 RID: 1478
		// (Invoke) Token: 0x0600349D RID: 13469
		private delegate void GetVectorImpl_InjectedDelegate(IntPtr @this, int name, [Out] IntPtr ret);

		// Token: 0x020005C7 RID: 1479
		// (Invoke) Token: 0x0600349F RID: 13471
		private delegate void GetColorImpl_InjectedDelegate(IntPtr @this, int name, [Out] IntPtr ret);

		// Token: 0x020005C8 RID: 1480
		// (Invoke) Token: 0x060034A1 RID: 13473
		private delegate void GetMatrixImpl_InjectedDelegate(IntPtr @this, int name, [Out] IntPtr ret);

		// Token: 0x020005C9 RID: 1481
		// (Invoke) Token: 0x060034A3 RID: 13475
		private delegate void SetColorImpl_InjectedDelegate(IntPtr @this, int name, IntPtr value);
	}
}
