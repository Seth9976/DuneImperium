using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000427 RID: 1063
	public sealed class SignatureArrayType : SignatureHasElementType
	{
		// Token: 0x06003CEB RID: 15595 RVA: 0x00123F28 File Offset: 0x00122128
		// Note: this type is marked as 'beforefieldinit'.
		static SignatureArrayType()
		{
			Il2CppClassPointerStore<SignatureArrayType>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "SignatureArrayType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SignatureArrayType>.NativeClassPtr);
			SignatureArrayType.NativeFieldInfoPtr__rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignatureArrayType>.NativeClassPtr, "_rank");
			SignatureArrayType.NativeFieldInfoPtr__isMultiDim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignatureArrayType>.NativeClassPtr, "_isMultiDim");
			SignatureArrayType.NativeMethodInfoPtr__ctor_Internal_Void_SignatureType_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureArrayType>.NativeClassPtr, 100672398);
			SignatureArrayType.NativeMethodInfoPtr_IsArrayImpl_Protected_Virtual_Final_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureArrayType>.NativeClassPtr, 100672399);
			SignatureArrayType.NativeMethodInfoPtr_IsByRefImpl_Protected_Virtual_Final_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureArrayType>.NativeClassPtr, 100672400);
			SignatureArrayType.NativeMethodInfoPtr_IsPointerImpl_Protected_Virtual_Final_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureArrayType>.NativeClassPtr, 100672401);
			SignatureArrayType.NativeMethodInfoPtr_get_IsSZArray_Public_Virtual_Final_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureArrayType>.NativeClassPtr, 100672402);
			SignatureArrayType.NativeMethodInfoPtr_get_IsVariableBoundArray_Public_Virtual_Final_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureArrayType>.NativeClassPtr, 100672403);
			SignatureArrayType.NativeMethodInfoPtr_GetArrayRank_Public_Virtual_Final_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureArrayType>.NativeClassPtr, 100672404);
			SignatureArrayType.NativeMethodInfoPtr_get_Suffix_Protected_Virtual_Final_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureArrayType>.NativeClassPtr, 100672405);
		}

		// Token: 0x06003CEC RID: 15596 RVA: 0x00124020 File Offset: 0x00122220
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1399112, RefRangeEnd = 1399114, XrefRangeStart = 1399107, XrefRangeEnd = 1399112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SignatureArrayType(SignatureType elementType, int rank, bool isMultiDim)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SignatureArrayType>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rank;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isMultiDim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureArrayType.NativeMethodInfoPtr__ctor_Internal_Void_SignatureType_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CED RID: 15597 RVA: 0x00124088 File Offset: 0x00122288
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsArrayImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureArrayType.NativeMethodInfoPtr_IsArrayImpl_Protected_Virtual_Final_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003CEE RID: 15598 RVA: 0x001240C4 File Offset: 0x001222C4
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsByRefImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureArrayType.NativeMethodInfoPtr_IsByRefImpl_Protected_Virtual_Final_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003CEF RID: 15599 RVA: 0x00124100 File Offset: 0x00122300
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsPointerImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureArrayType.NativeMethodInfoPtr_IsPointerImpl_Protected_Virtual_Final_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000E45 RID: 3653
		// (get) Token: 0x06003CF0 RID: 15600 RVA: 0x0012413C File Offset: 0x0012233C
		public unsafe override bool IsSZArray
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureArrayType.NativeMethodInfoPtr_get_IsSZArray_Public_Virtual_Final_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E46 RID: 3654
		// (get) Token: 0x06003CF1 RID: 15601 RVA: 0x00124178 File Offset: 0x00122378
		public unsafe override bool IsVariableBoundArray
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureArrayType.NativeMethodInfoPtr_get_IsVariableBoundArray_Public_Virtual_Final_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003CF2 RID: 15602 RVA: 0x001241B4 File Offset: 0x001223B4
		[CallerCount(0)]
		public unsafe override int GetArrayRank()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureArrayType.NativeMethodInfoPtr_GetArrayRank_Public_Virtual_Final_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000E47 RID: 3655
		// (get) Token: 0x06003CF3 RID: 15603 RVA: 0x001241F0 File Offset: 0x001223F0
		public unsafe override string Suffix
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399114, XrefRangeEnd = 1399123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureArrayType.NativeMethodInfoPtr_get_Suffix_Protected_Virtual_Final_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003CF4 RID: 15604 RVA: 0x00016898 File Offset: 0x00014A98
		public SignatureArrayType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E43 RID: 3651
		// (get) Token: 0x06003CF5 RID: 15605 RVA: 0x00124228 File Offset: 0x00122428
		// (set) Token: 0x06003CF6 RID: 15606 RVA: 0x000168A1 File Offset: 0x00014AA1
		public unsafe int _rank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignatureArrayType.NativeFieldInfoPtr__rank);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignatureArrayType.NativeFieldInfoPtr__rank)) = value;
			}
		}

		// Token: 0x17000E44 RID: 3652
		// (get) Token: 0x06003CF7 RID: 15607 RVA: 0x00124250 File Offset: 0x00122450
		// (set) Token: 0x06003CF8 RID: 15608 RVA: 0x000168BC File Offset: 0x00014ABC
		public unsafe bool _isMultiDim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignatureArrayType.NativeFieldInfoPtr__isMultiDim);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignatureArrayType.NativeFieldInfoPtr__isMultiDim)) = value;
			}
		}

		// Token: 0x040031B8 RID: 12728
		private static readonly IntPtr NativeFieldInfoPtr__rank;

		// Token: 0x040031B9 RID: 12729
		private static readonly IntPtr NativeFieldInfoPtr__isMultiDim;

		// Token: 0x040031BA RID: 12730
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SignatureType_Int32_Boolean_0;

		// Token: 0x040031BB RID: 12731
		private static readonly IntPtr NativeMethodInfoPtr_IsArrayImpl_Protected_Virtual_Final_Boolean_0;

		// Token: 0x040031BC RID: 12732
		private static readonly IntPtr NativeMethodInfoPtr_IsByRefImpl_Protected_Virtual_Final_Boolean_0;

		// Token: 0x040031BD RID: 12733
		private static readonly IntPtr NativeMethodInfoPtr_IsPointerImpl_Protected_Virtual_Final_Boolean_0;

		// Token: 0x040031BE RID: 12734
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSZArray_Public_Virtual_Final_get_Boolean_0;

		// Token: 0x040031BF RID: 12735
		private static readonly IntPtr NativeMethodInfoPtr_get_IsVariableBoundArray_Public_Virtual_Final_get_Boolean_0;

		// Token: 0x040031C0 RID: 12736
		private static readonly IntPtr NativeMethodInfoPtr_GetArrayRank_Public_Virtual_Final_Int32_0;

		// Token: 0x040031C1 RID: 12737
		private static readonly IntPtr NativeMethodInfoPtr_get_Suffix_Protected_Virtual_Final_get_String_0;
	}
}
