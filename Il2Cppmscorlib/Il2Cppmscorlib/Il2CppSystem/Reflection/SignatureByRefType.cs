using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000428 RID: 1064
	public sealed class SignatureByRefType : SignatureHasElementType
	{
		// Token: 0x06003CF9 RID: 15609 RVA: 0x00124278 File Offset: 0x00122478
		// Note: this type is marked as 'beforefieldinit'.
		static SignatureByRefType()
		{
			Il2CppClassPointerStore<SignatureByRefType>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "SignatureByRefType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SignatureByRefType>.NativeClassPtr);
			SignatureByRefType.NativeMethodInfoPtr__ctor_Internal_Void_SignatureType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureByRefType>.NativeClassPtr, 100672406);
			SignatureByRefType.NativeMethodInfoPtr_IsArrayImpl_Protected_Virtual_Final_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureByRefType>.NativeClassPtr, 100672407);
			SignatureByRefType.NativeMethodInfoPtr_IsByRefImpl_Protected_Virtual_Final_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureByRefType>.NativeClassPtr, 100672408);
			SignatureByRefType.NativeMethodInfoPtr_IsPointerImpl_Protected_Virtual_Final_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureByRefType>.NativeClassPtr, 100672409);
			SignatureByRefType.NativeMethodInfoPtr_get_IsSZArray_Public_Virtual_Final_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureByRefType>.NativeClassPtr, 100672410);
			SignatureByRefType.NativeMethodInfoPtr_get_IsVariableBoundArray_Public_Virtual_Final_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureByRefType>.NativeClassPtr, 100672411);
			SignatureByRefType.NativeMethodInfoPtr_GetArrayRank_Public_Virtual_Final_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureByRefType>.NativeClassPtr, 100672412);
			SignatureByRefType.NativeMethodInfoPtr_get_Suffix_Protected_Virtual_Final_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureByRefType>.NativeClassPtr, 100672413);
		}

		// Token: 0x06003CFA RID: 15610 RVA: 0x00124348 File Offset: 0x00122548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399123, XrefRangeEnd = 1399128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SignatureByRefType(SignatureType elementType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SignatureByRefType>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureByRefType.NativeMethodInfoPtr__ctor_Internal_Void_SignatureType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003CFB RID: 15611 RVA: 0x00124394 File Offset: 0x00122594
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsArrayImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureByRefType.NativeMethodInfoPtr_IsArrayImpl_Protected_Virtual_Final_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003CFC RID: 15612 RVA: 0x001243D0 File Offset: 0x001225D0
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsByRefImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureByRefType.NativeMethodInfoPtr_IsByRefImpl_Protected_Virtual_Final_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003CFD RID: 15613 RVA: 0x0012440C File Offset: 0x0012260C
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsPointerImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureByRefType.NativeMethodInfoPtr_IsPointerImpl_Protected_Virtual_Final_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000E48 RID: 3656
		// (get) Token: 0x06003CFE RID: 15614 RVA: 0x00124448 File Offset: 0x00122648
		public unsafe override bool IsSZArray
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureByRefType.NativeMethodInfoPtr_get_IsSZArray_Public_Virtual_Final_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E49 RID: 3657
		// (get) Token: 0x06003CFF RID: 15615 RVA: 0x00124484 File Offset: 0x00122684
		public unsafe override bool IsVariableBoundArray
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureByRefType.NativeMethodInfoPtr_get_IsVariableBoundArray_Public_Virtual_Final_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003D00 RID: 15616 RVA: 0x001244C0 File Offset: 0x001226C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399128, XrefRangeEnd = 1399134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetArrayRank()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureByRefType.NativeMethodInfoPtr_GetArrayRank_Public_Virtual_Final_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000E4A RID: 3658
		// (get) Token: 0x06003D01 RID: 15617 RVA: 0x001244FC File Offset: 0x001226FC
		public unsafe override string Suffix
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399134, XrefRangeEnd = 1399136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureByRefType.NativeMethodInfoPtr_get_Suffix_Protected_Virtual_Final_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003D02 RID: 15618 RVA: 0x000168D7 File Offset: 0x00014AD7
		public SignatureByRefType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040031C2 RID: 12738
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SignatureType_0;

		// Token: 0x040031C3 RID: 12739
		private static readonly IntPtr NativeMethodInfoPtr_IsArrayImpl_Protected_Virtual_Final_Boolean_0;

		// Token: 0x040031C4 RID: 12740
		private static readonly IntPtr NativeMethodInfoPtr_IsByRefImpl_Protected_Virtual_Final_Boolean_0;

		// Token: 0x040031C5 RID: 12741
		private static readonly IntPtr NativeMethodInfoPtr_IsPointerImpl_Protected_Virtual_Final_Boolean_0;

		// Token: 0x040031C6 RID: 12742
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSZArray_Public_Virtual_Final_get_Boolean_0;

		// Token: 0x040031C7 RID: 12743
		private static readonly IntPtr NativeMethodInfoPtr_get_IsVariableBoundArray_Public_Virtual_Final_get_Boolean_0;

		// Token: 0x040031C8 RID: 12744
		private static readonly IntPtr NativeMethodInfoPtr_GetArrayRank_Public_Virtual_Final_Int32_0;

		// Token: 0x040031C9 RID: 12745
		private static readonly IntPtr NativeMethodInfoPtr_get_Suffix_Protected_Virtual_Final_get_String_0;
	}
}
