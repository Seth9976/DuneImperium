using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x0200042B RID: 1067
	public sealed class SignaturePointerType : SignatureHasElementType
	{
		// Token: 0x06003D38 RID: 15672 RVA: 0x0012545C File Offset: 0x0012365C
		// Note: this type is marked as 'beforefieldinit'.
		static SignaturePointerType()
		{
			Il2CppClassPointerStore<SignaturePointerType>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "SignaturePointerType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SignaturePointerType>.NativeClassPtr);
			SignaturePointerType.NativeMethodInfoPtr__ctor_Internal_Void_SignatureType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignaturePointerType>.NativeClassPtr, 100672457);
			SignaturePointerType.NativeMethodInfoPtr_IsArrayImpl_Protected_Virtual_Final_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignaturePointerType>.NativeClassPtr, 100672458);
			SignaturePointerType.NativeMethodInfoPtr_IsByRefImpl_Protected_Virtual_Final_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignaturePointerType>.NativeClassPtr, 100672459);
			SignaturePointerType.NativeMethodInfoPtr_IsPointerImpl_Protected_Virtual_Final_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignaturePointerType>.NativeClassPtr, 100672460);
			SignaturePointerType.NativeMethodInfoPtr_get_IsSZArray_Public_Virtual_Final_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignaturePointerType>.NativeClassPtr, 100672461);
			SignaturePointerType.NativeMethodInfoPtr_get_IsVariableBoundArray_Public_Virtual_Final_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignaturePointerType>.NativeClassPtr, 100672462);
			SignaturePointerType.NativeMethodInfoPtr_GetArrayRank_Public_Virtual_Final_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignaturePointerType>.NativeClassPtr, 100672463);
			SignaturePointerType.NativeMethodInfoPtr_get_Suffix_Protected_Virtual_Final_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignaturePointerType>.NativeClassPtr, 100672464);
		}

		// Token: 0x06003D39 RID: 15673 RVA: 0x0012552C File Offset: 0x0012372C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SignaturePointerType(SignatureType elementType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SignaturePointerType>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignaturePointerType.NativeMethodInfoPtr__ctor_Internal_Void_SignatureType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003D3A RID: 15674 RVA: 0x00125578 File Offset: 0x00123778
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsArrayImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignaturePointerType.NativeMethodInfoPtr_IsArrayImpl_Protected_Virtual_Final_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D3B RID: 15675 RVA: 0x001255B4 File Offset: 0x001237B4
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsByRefImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignaturePointerType.NativeMethodInfoPtr_IsByRefImpl_Protected_Virtual_Final_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D3C RID: 15676 RVA: 0x001255F0 File Offset: 0x001237F0
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsPointerImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignaturePointerType.NativeMethodInfoPtr_IsPointerImpl_Protected_Virtual_Final_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000E67 RID: 3687
		// (get) Token: 0x06003D3D RID: 15677 RVA: 0x0012562C File Offset: 0x0012382C
		public unsafe override bool IsSZArray
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignaturePointerType.NativeMethodInfoPtr_get_IsSZArray_Public_Virtual_Final_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E68 RID: 3688
		// (get) Token: 0x06003D3E RID: 15678 RVA: 0x00125668 File Offset: 0x00123868
		public unsafe override bool IsVariableBoundArray
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignaturePointerType.NativeMethodInfoPtr_get_IsVariableBoundArray_Public_Virtual_Final_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003D3F RID: 15679 RVA: 0x001256A4 File Offset: 0x001238A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399227, XrefRangeEnd = 1399233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetArrayRank()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignaturePointerType.NativeMethodInfoPtr_GetArrayRank_Public_Virtual_Final_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000E69 RID: 3689
		// (get) Token: 0x06003D40 RID: 15680 RVA: 0x001256E0 File Offset: 0x001238E0
		public unsafe override string Suffix
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399233, XrefRangeEnd = 1399235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignaturePointerType.NativeMethodInfoPtr_get_Suffix_Protected_Virtual_Final_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003D41 RID: 15681 RVA: 0x0001694F File Offset: 0x00014B4F
		public SignaturePointerType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040031F8 RID: 12792
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SignatureType_0;

		// Token: 0x040031F9 RID: 12793
		private static readonly IntPtr NativeMethodInfoPtr_IsArrayImpl_Protected_Virtual_Final_Boolean_0;

		// Token: 0x040031FA RID: 12794
		private static readonly IntPtr NativeMethodInfoPtr_IsByRefImpl_Protected_Virtual_Final_Boolean_0;

		// Token: 0x040031FB RID: 12795
		private static readonly IntPtr NativeMethodInfoPtr_IsPointerImpl_Protected_Virtual_Final_Boolean_0;

		// Token: 0x040031FC RID: 12796
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSZArray_Public_Virtual_Final_get_Boolean_0;

		// Token: 0x040031FD RID: 12797
		private static readonly IntPtr NativeMethodInfoPtr_get_IsVariableBoundArray_Public_Virtual_Final_get_Boolean_0;

		// Token: 0x040031FE RID: 12798
		private static readonly IntPtr NativeMethodInfoPtr_GetArrayRank_Public_Virtual_Final_Int32_0;

		// Token: 0x040031FF RID: 12799
		private static readonly IntPtr NativeMethodInfoPtr_get_Suffix_Protected_Virtual_Final_get_String_0;
	}
}
