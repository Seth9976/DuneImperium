using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x02000166 RID: 358
	public sealed class ComputeShader : Object
	{
		// Token: 0x06001A37 RID: 6711 RVA: 0x0007B174 File Offset: 0x00079374
		// Note: this type is marked as 'beforefieldinit'.
		static ComputeShader()
		{
			Il2CppClassPointerStore<ComputeShader>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ComputeShader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr);
			ComputeShader.NativeMethodInfoPtr_FindKernel_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666941);
			ComputeShader.NativeMethodInfoPtr_SetInt_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666942);
			ComputeShader.NativeMethodInfoPtr_SetConstantComputeBuffer_Private_Void_Int32_ComputeBuffer_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666943);
			ComputeShader.NativeMethodInfoPtr_EnableKeyword_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666944);
			ComputeShader.NativeMethodInfoPtr_DisableKeyword_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666945);
			ComputeShader.NativeMethodInfoPtr_SetConstantBuffer_Public_Void_Int32_ComputeBuffer_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666946);
			ComputeShader.HasKernelDelegateField = IL2CPP.ResolveICall<ComputeShader.HasKernelDelegate>("UnityEngine.ComputeShader::HasKernel");
			ComputeShader.SetFloatDelegateField = IL2CPP.ResolveICall<ComputeShader.SetFloatDelegate>("UnityEngine.ComputeShader::SetFloat");
			ComputeShader.SetFloatArrayDelegateField = IL2CPP.ResolveICall<ComputeShader.SetFloatArrayDelegate>("UnityEngine.ComputeShader::SetFloatArray");
			ComputeShader.SetIntArrayDelegateField = IL2CPP.ResolveICall<ComputeShader.SetIntArrayDelegate>("UnityEngine.ComputeShader::SetIntArray");
			ComputeShader.SetVectorArrayDelegateField = IL2CPP.ResolveICall<ComputeShader.SetVectorArrayDelegate>("UnityEngine.ComputeShader::SetVectorArray");
			ComputeShader.SetMatrixArrayDelegateField = IL2CPP.ResolveICall<ComputeShader.SetMatrixArrayDelegate>("UnityEngine.ComputeShader::SetMatrixArray");
			ComputeShader.SetTextureDelegateField = IL2CPP.ResolveICall<ComputeShader.SetTextureDelegate>("UnityEngine.ComputeShader::SetTexture");
			ComputeShader.SetRenderTextureDelegateField = IL2CPP.ResolveICall<ComputeShader.SetRenderTextureDelegate>("UnityEngine.ComputeShader::SetRenderTexture");
			ComputeShader.SetTextureFromGlobalDelegateField = IL2CPP.ResolveICall<ComputeShader.SetTextureFromGlobalDelegate>("UnityEngine.ComputeShader::SetTextureFromGlobal");
			ComputeShader.Internal_SetBufferDelegateField = IL2CPP.ResolveICall<ComputeShader.Internal_SetBufferDelegate>("UnityEngine.ComputeShader::Internal_SetBuffer");
			ComputeShader.Internal_SetGraphicsBufferDelegateField = IL2CPP.ResolveICall<ComputeShader.Internal_SetGraphicsBufferDelegate>("UnityEngine.ComputeShader::Internal_SetGraphicsBuffer");
			ComputeShader.SetConstantGraphicsBufferDelegateField = IL2CPP.ResolveICall<ComputeShader.SetConstantGraphicsBufferDelegate>("UnityEngine.ComputeShader::SetConstantGraphicsBuffer");
			ComputeShader.GetKernelThreadGroupSizesDelegateField = IL2CPP.ResolveICall<ComputeShader.GetKernelThreadGroupSizesDelegate>("UnityEngine.ComputeShader::GetKernelThreadGroupSizes");
			ComputeShader.DispatchDelegateField = IL2CPP.ResolveICall<ComputeShader.DispatchDelegate>("UnityEngine.ComputeShader::Dispatch");
			ComputeShader.Internal_DispatchIndirectDelegateField = IL2CPP.ResolveICall<ComputeShader.Internal_DispatchIndirectDelegate>("UnityEngine.ComputeShader::Internal_DispatchIndirect");
			ComputeShader.Internal_DispatchIndirectGraphicsBufferDelegateField = IL2CPP.ResolveICall<ComputeShader.Internal_DispatchIndirectGraphicsBufferDelegate>("UnityEngine.ComputeShader::Internal_DispatchIndirectGraphicsBuffer");
			ComputeShader.IsKeywordEnabledDelegateField = IL2CPP.ResolveICall<ComputeShader.IsKeywordEnabledDelegate>("UnityEngine.ComputeShader::IsKeywordEnabled");
			ComputeShader.IsSupportedDelegateField = IL2CPP.ResolveICall<ComputeShader.IsSupportedDelegate>("UnityEngine.ComputeShader::IsSupported");
			ComputeShader.GetShaderKeywordsDelegateField = IL2CPP.ResolveICall<ComputeShader.GetShaderKeywordsDelegate>("UnityEngine.ComputeShader::GetShaderKeywords");
			ComputeShader.SetShaderKeywordsDelegateField = IL2CPP.ResolveICall<ComputeShader.SetShaderKeywordsDelegate>("UnityEngine.ComputeShader::SetShaderKeywords");
			ComputeShader.GetEnabledKeywordsDelegateField = IL2CPP.ResolveICall<ComputeShader.GetEnabledKeywordsDelegate>("UnityEngine.ComputeShader::GetEnabledKeywords");
			ComputeShader.SetEnabledKeywordsDelegateField = IL2CPP.ResolveICall<ComputeShader.SetEnabledKeywordsDelegate>("UnityEngine.ComputeShader::SetEnabledKeywords");
			ComputeShader.SetVector_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.SetVector_InjectedDelegate>("UnityEngine.ComputeShader::SetVector_Injected");
			ComputeShader.SetMatrix_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.SetMatrix_InjectedDelegate>("UnityEngine.ComputeShader::SetMatrix_Injected");
			ComputeShader.get_keywordSpace_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.get_keywordSpace_InjectedDelegate>("UnityEngine.ComputeShader::get_keywordSpace_Injected");
			ComputeShader.EnableLocalKeyword_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.EnableLocalKeyword_InjectedDelegate>("UnityEngine.ComputeShader::EnableLocalKeyword_Injected");
			ComputeShader.DisableLocalKeyword_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.DisableLocalKeyword_InjectedDelegate>("UnityEngine.ComputeShader::DisableLocalKeyword_Injected");
			ComputeShader.SetLocalKeyword_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.SetLocalKeyword_InjectedDelegate>("UnityEngine.ComputeShader::SetLocalKeyword_Injected");
			ComputeShader.IsLocalKeywordEnabled_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.IsLocalKeywordEnabled_InjectedDelegate>("UnityEngine.ComputeShader::IsLocalKeywordEnabled_Injected");
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x0007B3D0 File Offset: 0x000795D0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 673222, RefRangeEnd = 673227, XrefRangeStart = 673220, XrefRangeEnd = 673222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindKernel(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_FindKernel_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x0007B420 File Offset: 0x00079620
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 673229, RefRangeEnd = 673231, XrefRangeStart = 673227, XrefRangeEnd = 673229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInt(int nameID, int val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_SetInt_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A3A RID: 6714 RVA: 0x0007B46C File Offset: 0x0007966C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 673233, RefRangeEnd = 673234, XrefRangeStart = 673231, XrefRangeEnd = 673233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetConstantComputeBuffer(int nameID, ComputeBuffer buffer, int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_SetConstantComputeBuffer_Private_Void_Int32_ComputeBuffer_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x0007B4D8 File Offset: 0x000796D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 673236, RefRangeEnd = 673238, XrefRangeStart = 673234, XrefRangeEnd = 673236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableKeyword(string keyword)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_EnableKeyword_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x0007B51C File Offset: 0x0007971C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 673240, RefRangeEnd = 673242, XrefRangeStart = 673238, XrefRangeEnd = 673240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableKeyword(string keyword)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_DisableKeyword_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A3D RID: 6717 RVA: 0x0007B560 File Offset: 0x00079760
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 673233, RefRangeEnd = 673234, XrefRangeStart = 673233, XrefRangeEnd = 673234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetConstantBuffer(int nameID, ComputeBuffer buffer, int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_SetConstantBuffer_Public_Void_Int32_ComputeBuffer_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A3E RID: 6718 RVA: 0x0000A23D File Offset: 0x0000843D
		public ComputeShader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x0000A246 File Offset: 0x00008446
		public bool HasKernel(string name)
		{
			return ComputeShader.HasKernelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x0000A25E File Offset: 0x0000845E
		public void SetFloat(int nameID, float val)
		{
			ComputeShader.SetFloatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, val);
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x0000A272 File Offset: 0x00008472
		public void SetVector(int nameID, Vector4 val)
		{
			this.SetVector_Injected(nameID, ref val);
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x0000A27D File Offset: 0x0000847D
		public void SetMatrix(int nameID, Matrix4x4 val)
		{
			this.SetMatrix_Injected(nameID, ref val);
		}

		// Token: 0x06001A43 RID: 6723 RVA: 0x0000A288 File Offset: 0x00008488
		public void SetFloatArray(int nameID, Il2CppStructArray<float> values)
		{
			ComputeShader.SetFloatArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x0000A2A1 File Offset: 0x000084A1
		public void SetIntArray(int nameID, Il2CppStructArray<int> values)
		{
			ComputeShader.SetIntArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x0000A2BA File Offset: 0x000084BA
		public void SetVectorArray(int nameID, Il2CppStructArray<Vector4> values)
		{
			ComputeShader.SetVectorArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x0000A2D3 File Offset: 0x000084D3
		public void SetMatrixArray(int nameID, Il2CppStructArray<Matrix4x4> values)
		{
			ComputeShader.SetMatrixArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x0000A2EC File Offset: 0x000084EC
		public void SetTexture(int kernelIndex, int nameID, Texture texture, int mipLevel)
		{
			ComputeShader.SetTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), kernelIndex, nameID, IL2CPP.Il2CppObjectBaseToPtr(texture), mipLevel);
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x0000A308 File Offset: 0x00008508
		public void SetRenderTexture(int kernelIndex, int nameID, RenderTexture texture, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			ComputeShader.SetRenderTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), kernelIndex, nameID, IL2CPP.Il2CppObjectBaseToPtr(texture), mipLevel, element);
		}

		// Token: 0x06001A49 RID: 6729 RVA: 0x0000A326 File Offset: 0x00008526
		public void SetTextureFromGlobal(int kernelIndex, int nameID, int globalTextureNameID)
		{
			ComputeShader.SetTextureFromGlobalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), kernelIndex, nameID, globalTextureNameID);
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x0000A33B File Offset: 0x0000853B
		public void Internal_SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer)
		{
			ComputeShader.Internal_SetBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), kernelIndex, nameID, IL2CPP.Il2CppObjectBaseToPtr(buffer));
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x0000A355 File Offset: 0x00008555
		public void Internal_SetGraphicsBuffer(int kernelIndex, int nameID, GraphicsBuffer buffer)
		{
			ComputeShader.Internal_SetGraphicsBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), kernelIndex, nameID, IL2CPP.Il2CppObjectBaseToPtr(buffer));
		}

		// Token: 0x06001A4C RID: 6732 RVA: 0x0000A36F File Offset: 0x0000856F
		public void SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer)
		{
			this.Internal_SetBuffer(kernelIndex, nameID, buffer);
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x0000A37C File Offset: 0x0000857C
		public void SetBuffer(int kernelIndex, int nameID, GraphicsBuffer buffer)
		{
			this.Internal_SetGraphicsBuffer(kernelIndex, nameID, buffer);
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x0000A389 File Offset: 0x00008589
		public void SetConstantGraphicsBuffer(int nameID, GraphicsBuffer buffer, int offset, int size)
		{
			ComputeShader.SetConstantGraphicsBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(buffer), offset, size);
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x0000A3A5 File Offset: 0x000085A5
		public void GetKernelThreadGroupSizes(int kernelIndex, out uint x, out uint y, out uint z)
		{
			ComputeShader.GetKernelThreadGroupSizesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), kernelIndex, out x, out y, out z);
		}

		// Token: 0x06001A50 RID: 6736 RVA: 0x0000A3BC File Offset: 0x000085BC
		public void Dispatch(int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ)
		{
			ComputeShader.DispatchDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), kernelIndex, threadGroupsX, threadGroupsY, threadGroupsZ);
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x0000A3D3 File Offset: 0x000085D3
		public void Internal_DispatchIndirect(int kernelIndex, ComputeBuffer argsBuffer, uint argsOffset)
		{
			ComputeShader.Internal_DispatchIndirectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), kernelIndex, IL2CPP.Il2CppObjectBaseToPtr(argsBuffer), argsOffset);
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x0000A3ED File Offset: 0x000085ED
		public void Internal_DispatchIndirectGraphicsBuffer(int kernelIndex, GraphicsBuffer argsBuffer, uint argsOffset)
		{
			ComputeShader.Internal_DispatchIndirectGraphicsBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), kernelIndex, IL2CPP.Il2CppObjectBaseToPtr(argsBuffer), argsOffset);
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06001A53 RID: 6739 RVA: 0x0007B5CC File Offset: 0x000797CC
		public UnityEngine.Rendering.LocalKeywordSpace keywordSpace
		{
			get
			{
				UnityEngine.Rendering.LocalKeywordSpace localKeywordSpace;
				this.get_keywordSpace_Injected(out localKeywordSpace);
				return localKeywordSpace;
			}
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x0000A407 File Offset: 0x00008607
		public bool IsKeywordEnabled(string keyword)
		{
			return ComputeShader.IsKeywordEnabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(keyword));
		}

		// Token: 0x06001A55 RID: 6741 RVA: 0x0000A41F File Offset: 0x0000861F
		public void EnableLocalKeyword(UnityEngine.Rendering.LocalKeyword keyword)
		{
			this.EnableLocalKeyword_Injected(ref keyword);
		}

		// Token: 0x06001A56 RID: 6742 RVA: 0x0000A429 File Offset: 0x00008629
		public void DisableLocalKeyword(UnityEngine.Rendering.LocalKeyword keyword)
		{
			this.DisableLocalKeyword_Injected(ref keyword);
		}

		// Token: 0x06001A57 RID: 6743 RVA: 0x0000A433 File Offset: 0x00008633
		public void SetLocalKeyword(UnityEngine.Rendering.LocalKeyword keyword, bool value)
		{
			this.SetLocalKeyword_Injected(ref keyword, value);
		}

		// Token: 0x06001A58 RID: 6744 RVA: 0x0000A43E File Offset: 0x0000863E
		public bool IsLocalKeywordEnabled(UnityEngine.Rendering.LocalKeyword keyword)
		{
			return this.IsLocalKeywordEnabled_Injected(ref keyword);
		}

		// Token: 0x06001A59 RID: 6745 RVA: 0x0000A448 File Offset: 0x00008648
		public void EnableKeyword([In] ref UnityEngine.Rendering.LocalKeyword keyword)
		{
			this.EnableLocalKeyword(keyword);
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x0000A458 File Offset: 0x00008658
		public void DisableKeyword([In] ref UnityEngine.Rendering.LocalKeyword keyword)
		{
			this.DisableLocalKeyword(keyword);
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x0000A468 File Offset: 0x00008668
		public void SetKeyword([In] ref UnityEngine.Rendering.LocalKeyword keyword, bool value)
		{
			this.SetLocalKeyword(keyword, value);
		}

		// Token: 0x06001A5C RID: 6748 RVA: 0x0007B5E4 File Offset: 0x000797E4
		public bool IsKeywordEnabled([In] ref UnityEngine.Rendering.LocalKeyword keyword)
		{
			return this.IsLocalKeywordEnabled(keyword);
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x0000A479 File Offset: 0x00008679
		public bool IsSupported(int kernelIndex)
		{
			return ComputeShader.IsSupportedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), kernelIndex);
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x0007B604 File Offset: 0x00079804
		public Il2CppStringArray GetShaderKeywords()
		{
			IntPtr intPtr = ComputeShader.GetShaderKeywordsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x0000A48C File Offset: 0x0000868C
		public void SetShaderKeywords(Il2CppStringArray names)
		{
			ComputeShader.SetShaderKeywordsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(names));
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06001A60 RID: 6752 RVA: 0x0007B630 File Offset: 0x00079830
		// (set) Token: 0x06001A61 RID: 6753 RVA: 0x0000A4A4 File Offset: 0x000086A4
		public Il2CppStringArray shaderKeywords
		{
			get
			{
				return this.GetShaderKeywords();
			}
			set
			{
				this.SetShaderKeywords(value);
			}
		}

		// Token: 0x06001A62 RID: 6754 RVA: 0x0007B648 File Offset: 0x00079848
		public Il2CppReferenceArray<UnityEngine.Rendering.LocalKeyword> GetEnabledKeywords()
		{
			IntPtr intPtr = ComputeShader.GetEnabledKeywordsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UnityEngine.Rendering.LocalKeyword>>(intPtr2) : null;
		}

		// Token: 0x06001A63 RID: 6755 RVA: 0x0000A4AF File Offset: 0x000086AF
		public void SetEnabledKeywords(Il2CppReferenceArray<UnityEngine.Rendering.LocalKeyword> keywords)
		{
			ComputeShader.SetEnabledKeywordsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(keywords));
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06001A64 RID: 6756 RVA: 0x0007B674 File Offset: 0x00079874
		// (set) Token: 0x06001A65 RID: 6757 RVA: 0x0000A4C7 File Offset: 0x000086C7
		public Il2CppReferenceArray<UnityEngine.Rendering.LocalKeyword> enabledKeywords
		{
			get
			{
				return this.GetEnabledKeywords();
			}
			set
			{
				this.SetEnabledKeywords(value);
			}
		}

		// Token: 0x06001A66 RID: 6758 RVA: 0x0000A4D2 File Offset: 0x000086D2
		public void SetFloat(string name, float val)
		{
			this.SetFloat(Shader.PropertyToID(name), val);
		}

		// Token: 0x06001A67 RID: 6759 RVA: 0x0000A4E3 File Offset: 0x000086E3
		public void SetInt(string name, int val)
		{
			this.SetInt(Shader.PropertyToID(name), val);
		}

		// Token: 0x06001A68 RID: 6760 RVA: 0x0000A4F4 File Offset: 0x000086F4
		public void SetVector(string name, Vector4 val)
		{
			this.SetVector(Shader.PropertyToID(name), val);
		}

		// Token: 0x06001A69 RID: 6761 RVA: 0x0000A505 File Offset: 0x00008705
		public void SetMatrix(string name, Matrix4x4 val)
		{
			this.SetMatrix(Shader.PropertyToID(name), val);
		}

		// Token: 0x06001A6A RID: 6762 RVA: 0x0000A516 File Offset: 0x00008716
		public void SetVectorArray(string name, Il2CppStructArray<Vector4> values)
		{
			this.SetVectorArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06001A6B RID: 6763 RVA: 0x0000A527 File Offset: 0x00008727
		public void SetMatrixArray(string name, Il2CppStructArray<Matrix4x4> values)
		{
			this.SetMatrixArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06001A6C RID: 6764 RVA: 0x0000A538 File Offset: 0x00008738
		public void SetFloats(string name, Il2CppStructArray<float> values)
		{
			this.SetFloatArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06001A6D RID: 6765 RVA: 0x0000A549 File Offset: 0x00008749
		public void SetFloats(string name, params float[] values)
		{
			this.SetFloats(name, new Il2CppStructArray<float>(values));
		}

		// Token: 0x06001A6E RID: 6766 RVA: 0x0000A558 File Offset: 0x00008758
		public void SetFloats(int nameID, Il2CppStructArray<float> values)
		{
			this.SetFloatArray(nameID, values);
		}

		// Token: 0x06001A6F RID: 6767 RVA: 0x0000A564 File Offset: 0x00008764
		public void SetFloats(int nameID, params float[] values)
		{
			this.SetFloats(nameID, new Il2CppStructArray<float>(values));
		}

		// Token: 0x06001A70 RID: 6768 RVA: 0x0000A573 File Offset: 0x00008773
		public void SetInts(string name, Il2CppStructArray<int> values)
		{
			this.SetIntArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x0000A584 File Offset: 0x00008784
		public void SetInts(string name, params int[] values)
		{
			this.SetInts(name, new Il2CppStructArray<int>(values));
		}

		// Token: 0x06001A72 RID: 6770 RVA: 0x0000A593 File Offset: 0x00008793
		public void SetInts(int nameID, Il2CppStructArray<int> values)
		{
			this.SetIntArray(nameID, values);
		}

		// Token: 0x06001A73 RID: 6771 RVA: 0x0000A59F File Offset: 0x0000879F
		public void SetInts(int nameID, params int[] values)
		{
			this.SetInts(nameID, new Il2CppStructArray<int>(values));
		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x0000A5AE File Offset: 0x000087AE
		public void SetBool(string name, bool val)
		{
			this.SetInt(Shader.PropertyToID(name), val ? 1 : 0);
		}

		// Token: 0x06001A75 RID: 6773 RVA: 0x0000A5C5 File Offset: 0x000087C5
		public void SetBool(int nameID, bool val)
		{
			this.SetInt(nameID, val ? 1 : 0);
		}

		// Token: 0x06001A76 RID: 6774 RVA: 0x0000A5D7 File Offset: 0x000087D7
		public void SetTexture(int kernelIndex, int nameID, Texture texture)
		{
			this.SetTexture(kernelIndex, nameID, texture, 0);
		}

		// Token: 0x06001A77 RID: 6775 RVA: 0x0000A5E5 File Offset: 0x000087E5
		public void SetTexture(int kernelIndex, string name, Texture texture)
		{
			this.SetTexture(kernelIndex, Shader.PropertyToID(name), texture, 0);
		}

		// Token: 0x06001A78 RID: 6776 RVA: 0x0000A5F8 File Offset: 0x000087F8
		public void SetTexture(int kernelIndex, string name, Texture texture, int mipLevel)
		{
			this.SetTexture(kernelIndex, Shader.PropertyToID(name), texture, mipLevel);
		}

		// Token: 0x06001A79 RID: 6777 RVA: 0x0000A60C File Offset: 0x0000880C
		public void SetTexture(int kernelIndex, int nameID, RenderTexture texture, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			this.SetRenderTexture(kernelIndex, nameID, texture, mipLevel, element);
		}

		// Token: 0x06001A7A RID: 6778 RVA: 0x0000A61D File Offset: 0x0000881D
		public void SetTexture(int kernelIndex, string name, RenderTexture texture, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			this.SetRenderTexture(kernelIndex, Shader.PropertyToID(name), texture, mipLevel, element);
		}

		// Token: 0x06001A7B RID: 6779 RVA: 0x0000A633 File Offset: 0x00008833
		public void SetTextureFromGlobal(int kernelIndex, string name, string globalTextureName)
		{
			this.SetTextureFromGlobal(kernelIndex, Shader.PropertyToID(name), Shader.PropertyToID(globalTextureName));
		}

		// Token: 0x06001A7C RID: 6780 RVA: 0x0000A64A File Offset: 0x0000884A
		public void SetBuffer(int kernelIndex, string name, ComputeBuffer buffer)
		{
			this.SetBuffer(kernelIndex, Shader.PropertyToID(name), buffer);
		}

		// Token: 0x06001A7D RID: 6781 RVA: 0x0000A65C File Offset: 0x0000885C
		public void SetBuffer(int kernelIndex, string name, GraphicsBuffer buffer)
		{
			this.SetBuffer(kernelIndex, Shader.PropertyToID(name), buffer);
		}

		// Token: 0x06001A7E RID: 6782 RVA: 0x0000A66E File Offset: 0x0000886E
		public void SetConstantBuffer(string name, ComputeBuffer buffer, int offset, int size)
		{
			this.SetConstantBuffer(Shader.PropertyToID(name), buffer, offset, size);
		}

		// Token: 0x06001A7F RID: 6783 RVA: 0x0000A682 File Offset: 0x00008882
		public void SetConstantBuffer(int nameID, GraphicsBuffer buffer, int offset, int size)
		{
			this.SetConstantGraphicsBuffer(nameID, buffer, offset, size);
		}

		// Token: 0x06001A80 RID: 6784 RVA: 0x0000A691 File Offset: 0x00008891
		public void SetConstantBuffer(string name, GraphicsBuffer buffer, int offset, int size)
		{
			this.SetConstantBuffer(Shader.PropertyToID(name), buffer, offset, size);
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x0007B68C File Offset: 0x0007988C
		public void DispatchIndirect(int kernelIndex, ComputeBuffer argsBuffer, uint argsOffset)
		{
			bool flag = argsBuffer == null;
			if (flag)
			{
				throw new ArgumentNullException("argsBuffer");
			}
			bool flag2 = argsBuffer.m_Ptr == IntPtr.Zero;
			if (flag2)
			{
				throw new ObjectDisposedException("argsBuffer");
			}
			bool flag3 = SystemInfo.graphicsDeviceType == UnityEngine.Rendering.GraphicsDeviceType.Metal && !SystemInfo.supportsIndirectArgumentsBuffer;
			if (flag3)
			{
				throw new InvalidOperationException("Indirect argument buffers are not supported.");
			}
			this.Internal_DispatchIndirect(kernelIndex, argsBuffer, argsOffset);
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x0000A6A5 File Offset: 0x000088A5
		public void DispatchIndirect(int kernelIndex, ComputeBuffer argsBuffer)
		{
			this.DispatchIndirect(kernelIndex, argsBuffer, 0U);
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x0007B6FC File Offset: 0x000798FC
		public void DispatchIndirect(int kernelIndex, GraphicsBuffer argsBuffer, uint argsOffset)
		{
			bool flag = argsBuffer == null;
			if (flag)
			{
				throw new ArgumentNullException("argsBuffer");
			}
			bool flag2 = argsBuffer.m_Ptr == IntPtr.Zero;
			if (flag2)
			{
				throw new ObjectDisposedException("argsBuffer");
			}
			bool flag3 = SystemInfo.graphicsDeviceType == UnityEngine.Rendering.GraphicsDeviceType.Metal && !SystemInfo.supportsIndirectArgumentsBuffer;
			if (flag3)
			{
				throw new InvalidOperationException("Indirect argument buffers are not supported.");
			}
			this.Internal_DispatchIndirectGraphicsBuffer(kernelIndex, argsBuffer, argsOffset);
		}

		// Token: 0x06001A84 RID: 6788 RVA: 0x0000A6B2 File Offset: 0x000088B2
		public void DispatchIndirect(int kernelIndex, GraphicsBuffer argsBuffer)
		{
			this.DispatchIndirect(kernelIndex, argsBuffer, 0U);
		}

		// Token: 0x06001A85 RID: 6789 RVA: 0x0000A6BF File Offset: 0x000088BF
		public void SetVector_Injected(int nameID, ref Vector4 val)
		{
			ComputeShader.SetVector_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, ref val);
		}

		// Token: 0x06001A86 RID: 6790 RVA: 0x0000A6D3 File Offset: 0x000088D3
		public void SetMatrix_Injected(int nameID, ref Matrix4x4 val)
		{
			ComputeShader.SetMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, ref val);
		}

		// Token: 0x06001A87 RID: 6791 RVA: 0x0000A6E7 File Offset: 0x000088E7
		public void get_keywordSpace_Injected(out UnityEngine.Rendering.LocalKeywordSpace ret)
		{
			ComputeShader.get_keywordSpace_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x0007B76C File Offset: 0x0007996C
		public unsafe void EnableLocalKeyword_Injected(ref UnityEngine.Rendering.LocalKeyword keyword)
		{
			ComputeShader.EnableLocalKeyword_InjectedDelegate enableLocalKeyword_InjectedDelegateField = ComputeShader.EnableLocalKeyword_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(keyword);
			enableLocalKeyword_InjectedDelegateField(intPtr, &intPtr2);
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x0007B794 File Offset: 0x00079994
		public unsafe void DisableLocalKeyword_Injected(ref UnityEngine.Rendering.LocalKeyword keyword)
		{
			ComputeShader.DisableLocalKeyword_InjectedDelegate disableLocalKeyword_InjectedDelegateField = ComputeShader.DisableLocalKeyword_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(keyword);
			disableLocalKeyword_InjectedDelegateField(intPtr, &intPtr2);
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x0007B7BC File Offset: 0x000799BC
		public unsafe void SetLocalKeyword_Injected(ref UnityEngine.Rendering.LocalKeyword keyword, bool value)
		{
			ComputeShader.SetLocalKeyword_InjectedDelegate setLocalKeyword_InjectedDelegateField = ComputeShader.SetLocalKeyword_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(keyword);
			setLocalKeyword_InjectedDelegateField(intPtr, &intPtr2, value);
		}

		// Token: 0x06001A8B RID: 6795 RVA: 0x0007B7E8 File Offset: 0x000799E8
		public unsafe bool IsLocalKeywordEnabled_Injected(ref UnityEngine.Rendering.LocalKeyword keyword)
		{
			ComputeShader.IsLocalKeywordEnabled_InjectedDelegate isLocalKeywordEnabled_InjectedDelegateField = ComputeShader.IsLocalKeywordEnabled_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(keyword);
			return isLocalKeywordEnabled_InjectedDelegateField(intPtr, &intPtr2);
		}

		// Token: 0x04001745 RID: 5957
		private static readonly IntPtr NativeMethodInfoPtr_FindKernel_Public_Int32_String_0;

		// Token: 0x04001746 RID: 5958
		private static readonly IntPtr NativeMethodInfoPtr_SetInt_Public_Void_Int32_Int32_0;

		// Token: 0x04001747 RID: 5959
		private static readonly IntPtr NativeMethodInfoPtr_SetConstantComputeBuffer_Private_Void_Int32_ComputeBuffer_Int32_Int32_0;

		// Token: 0x04001748 RID: 5960
		private static readonly IntPtr NativeMethodInfoPtr_EnableKeyword_Public_Void_String_0;

		// Token: 0x04001749 RID: 5961
		private static readonly IntPtr NativeMethodInfoPtr_DisableKeyword_Public_Void_String_0;

		// Token: 0x0400174A RID: 5962
		private static readonly IntPtr NativeMethodInfoPtr_SetConstantBuffer_Public_Void_Int32_ComputeBuffer_Int32_Int32_0;

		// Token: 0x0400174B RID: 5963
		private static readonly ComputeShader.HasKernelDelegate HasKernelDelegateField;

		// Token: 0x0400174C RID: 5964
		private static readonly ComputeShader.SetFloatDelegate SetFloatDelegateField;

		// Token: 0x0400174D RID: 5965
		private static readonly ComputeShader.SetFloatArrayDelegate SetFloatArrayDelegateField;

		// Token: 0x0400174E RID: 5966
		private static readonly ComputeShader.SetIntArrayDelegate SetIntArrayDelegateField;

		// Token: 0x0400174F RID: 5967
		private static readonly ComputeShader.SetVectorArrayDelegate SetVectorArrayDelegateField;

		// Token: 0x04001750 RID: 5968
		private static readonly ComputeShader.SetMatrixArrayDelegate SetMatrixArrayDelegateField;

		// Token: 0x04001751 RID: 5969
		private static readonly ComputeShader.SetTextureDelegate SetTextureDelegateField;

		// Token: 0x04001752 RID: 5970
		private static readonly ComputeShader.SetRenderTextureDelegate SetRenderTextureDelegateField;

		// Token: 0x04001753 RID: 5971
		private static readonly ComputeShader.SetTextureFromGlobalDelegate SetTextureFromGlobalDelegateField;

		// Token: 0x04001754 RID: 5972
		private static readonly ComputeShader.Internal_SetBufferDelegate Internal_SetBufferDelegateField;

		// Token: 0x04001755 RID: 5973
		private static readonly ComputeShader.Internal_SetGraphicsBufferDelegate Internal_SetGraphicsBufferDelegateField;

		// Token: 0x04001756 RID: 5974
		private static readonly ComputeShader.SetConstantGraphicsBufferDelegate SetConstantGraphicsBufferDelegateField;

		// Token: 0x04001757 RID: 5975
		private static readonly ComputeShader.GetKernelThreadGroupSizesDelegate GetKernelThreadGroupSizesDelegateField;

		// Token: 0x04001758 RID: 5976
		private static readonly ComputeShader.DispatchDelegate DispatchDelegateField;

		// Token: 0x04001759 RID: 5977
		private static readonly ComputeShader.Internal_DispatchIndirectDelegate Internal_DispatchIndirectDelegateField;

		// Token: 0x0400175A RID: 5978
		private static readonly ComputeShader.Internal_DispatchIndirectGraphicsBufferDelegate Internal_DispatchIndirectGraphicsBufferDelegateField;

		// Token: 0x0400175B RID: 5979
		private static readonly ComputeShader.IsKeywordEnabledDelegate IsKeywordEnabledDelegateField;

		// Token: 0x0400175C RID: 5980
		private static readonly ComputeShader.IsSupportedDelegate IsSupportedDelegateField;

		// Token: 0x0400175D RID: 5981
		private static readonly ComputeShader.GetShaderKeywordsDelegate GetShaderKeywordsDelegateField;

		// Token: 0x0400175E RID: 5982
		private static readonly ComputeShader.SetShaderKeywordsDelegate SetShaderKeywordsDelegateField;

		// Token: 0x0400175F RID: 5983
		private static readonly ComputeShader.GetEnabledKeywordsDelegate GetEnabledKeywordsDelegateField;

		// Token: 0x04001760 RID: 5984
		private static readonly ComputeShader.SetEnabledKeywordsDelegate SetEnabledKeywordsDelegateField;

		// Token: 0x04001761 RID: 5985
		private static readonly ComputeShader.SetVector_InjectedDelegate SetVector_InjectedDelegateField;

		// Token: 0x04001762 RID: 5986
		private static readonly ComputeShader.SetMatrix_InjectedDelegate SetMatrix_InjectedDelegateField;

		// Token: 0x04001763 RID: 5987
		private static readonly ComputeShader.get_keywordSpace_InjectedDelegate get_keywordSpace_InjectedDelegateField;

		// Token: 0x04001764 RID: 5988
		private static readonly ComputeShader.EnableLocalKeyword_InjectedDelegate EnableLocalKeyword_InjectedDelegateField;

		// Token: 0x04001765 RID: 5989
		private static readonly ComputeShader.DisableLocalKeyword_InjectedDelegate DisableLocalKeyword_InjectedDelegateField;

		// Token: 0x04001766 RID: 5990
		private static readonly ComputeShader.SetLocalKeyword_InjectedDelegate SetLocalKeyword_InjectedDelegateField;

		// Token: 0x04001767 RID: 5991
		private static readonly ComputeShader.IsLocalKeywordEnabled_InjectedDelegate IsLocalKeywordEnabled_InjectedDelegateField;

		// Token: 0x0200078C RID: 1932
		// (Invoke) Token: 0x060037C5 RID: 14277
		private delegate bool HasKernelDelegate(IntPtr @this, IntPtr name);

		// Token: 0x0200078D RID: 1933
		// (Invoke) Token: 0x060037C7 RID: 14279
		private delegate void SetFloatDelegate(IntPtr @this, int nameID, float val);

		// Token: 0x0200078E RID: 1934
		// (Invoke) Token: 0x060037C9 RID: 14281
		private delegate void SetFloatArrayDelegate(IntPtr @this, int nameID, IntPtr values);

		// Token: 0x0200078F RID: 1935
		// (Invoke) Token: 0x060037CB RID: 14283
		private delegate void SetIntArrayDelegate(IntPtr @this, int nameID, IntPtr values);

		// Token: 0x02000790 RID: 1936
		// (Invoke) Token: 0x060037CD RID: 14285
		private delegate void SetVectorArrayDelegate(IntPtr @this, int nameID, IntPtr values);

		// Token: 0x02000791 RID: 1937
		// (Invoke) Token: 0x060037CF RID: 14287
		private delegate void SetMatrixArrayDelegate(IntPtr @this, int nameID, IntPtr values);

		// Token: 0x02000792 RID: 1938
		// (Invoke) Token: 0x060037D1 RID: 14289
		private delegate void SetTextureDelegate(IntPtr @this, int kernelIndex, int nameID, IntPtr texture, int mipLevel);

		// Token: 0x02000793 RID: 1939
		// (Invoke) Token: 0x060037D3 RID: 14291
		private delegate void SetRenderTextureDelegate(IntPtr @this, int kernelIndex, int nameID, IntPtr texture, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element);

		// Token: 0x02000794 RID: 1940
		// (Invoke) Token: 0x060037D5 RID: 14293
		private delegate void SetTextureFromGlobalDelegate(IntPtr @this, int kernelIndex, int nameID, int globalTextureNameID);

		// Token: 0x02000795 RID: 1941
		// (Invoke) Token: 0x060037D7 RID: 14295
		private delegate void Internal_SetBufferDelegate(IntPtr @this, int kernelIndex, int nameID, IntPtr buffer);

		// Token: 0x02000796 RID: 1942
		// (Invoke) Token: 0x060037D9 RID: 14297
		private delegate void Internal_SetGraphicsBufferDelegate(IntPtr @this, int kernelIndex, int nameID, IntPtr buffer);

		// Token: 0x02000797 RID: 1943
		// (Invoke) Token: 0x060037DB RID: 14299
		private delegate void SetConstantGraphicsBufferDelegate(IntPtr @this, int nameID, IntPtr buffer, int offset, int size);

		// Token: 0x02000798 RID: 1944
		// (Invoke) Token: 0x060037DD RID: 14301
		private delegate void GetKernelThreadGroupSizesDelegate(IntPtr @this, int kernelIndex, [Out] IntPtr x, [Out] IntPtr y, [Out] IntPtr z);

		// Token: 0x02000799 RID: 1945
		// (Invoke) Token: 0x060037DF RID: 14303
		private delegate void DispatchDelegate(IntPtr @this, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ);

		// Token: 0x0200079A RID: 1946
		// (Invoke) Token: 0x060037E1 RID: 14305
		private delegate void Internal_DispatchIndirectDelegate(IntPtr @this, int kernelIndex, IntPtr argsBuffer, uint argsOffset);

		// Token: 0x0200079B RID: 1947
		// (Invoke) Token: 0x060037E3 RID: 14307
		private delegate void Internal_DispatchIndirectGraphicsBufferDelegate(IntPtr @this, int kernelIndex, IntPtr argsBuffer, uint argsOffset);

		// Token: 0x0200079C RID: 1948
		// (Invoke) Token: 0x060037E5 RID: 14309
		private delegate bool IsKeywordEnabledDelegate(IntPtr @this, IntPtr keyword);

		// Token: 0x0200079D RID: 1949
		// (Invoke) Token: 0x060037E7 RID: 14311
		private delegate bool IsSupportedDelegate(IntPtr @this, int kernelIndex);

		// Token: 0x0200079E RID: 1950
		// (Invoke) Token: 0x060037E9 RID: 14313
		private delegate IntPtr GetShaderKeywordsDelegate(IntPtr @this);

		// Token: 0x0200079F RID: 1951
		// (Invoke) Token: 0x060037EB RID: 14315
		private delegate void SetShaderKeywordsDelegate(IntPtr @this, IntPtr names);

		// Token: 0x020007A0 RID: 1952
		// (Invoke) Token: 0x060037ED RID: 14317
		private delegate IntPtr GetEnabledKeywordsDelegate(IntPtr @this);

		// Token: 0x020007A1 RID: 1953
		// (Invoke) Token: 0x060037EF RID: 14319
		private delegate void SetEnabledKeywordsDelegate(IntPtr @this, IntPtr keywords);

		// Token: 0x020007A2 RID: 1954
		// (Invoke) Token: 0x060037F1 RID: 14321
		private delegate void SetVector_InjectedDelegate(IntPtr @this, int nameID, IntPtr val);

		// Token: 0x020007A3 RID: 1955
		// (Invoke) Token: 0x060037F3 RID: 14323
		private delegate void SetMatrix_InjectedDelegate(IntPtr @this, int nameID, IntPtr val);

		// Token: 0x020007A4 RID: 1956
		// (Invoke) Token: 0x060037F5 RID: 14325
		private delegate void get_keywordSpace_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020007A5 RID: 1957
		// (Invoke) Token: 0x060037F7 RID: 14327
		private delegate void EnableLocalKeyword_InjectedDelegate(IntPtr @this, IntPtr keyword);

		// Token: 0x020007A6 RID: 1958
		// (Invoke) Token: 0x060037F9 RID: 14329
		private delegate void DisableLocalKeyword_InjectedDelegate(IntPtr @this, IntPtr keyword);

		// Token: 0x020007A7 RID: 1959
		// (Invoke) Token: 0x060037FB RID: 14331
		private delegate void SetLocalKeyword_InjectedDelegate(IntPtr @this, IntPtr keyword, bool value);

		// Token: 0x020007A8 RID: 1960
		// (Invoke) Token: 0x060037FD RID: 14333
		private delegate bool IsLocalKeywordEnabled_InjectedDelegate(IntPtr @this, IntPtr keyword);
	}
}
