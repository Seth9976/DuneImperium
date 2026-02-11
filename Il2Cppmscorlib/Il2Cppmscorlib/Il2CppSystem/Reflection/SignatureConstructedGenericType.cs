using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000429 RID: 1065
	public sealed class SignatureConstructedGenericType : SignatureType
	{
		// Token: 0x06003D03 RID: 15619 RVA: 0x00124534 File Offset: 0x00122734
		// Note: this type is marked as 'beforefieldinit'.
		static SignatureConstructedGenericType()
		{
			Il2CppClassPointerStore<SignatureConstructedGenericType>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "SignatureConstructedGenericType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SignatureConstructedGenericType>.NativeClassPtr);
			SignatureConstructedGenericType.NativeFieldInfoPtr__genericTypeDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignatureConstructedGenericType>.NativeClassPtr, "_genericTypeDefinition");
			SignatureConstructedGenericType.NativeFieldInfoPtr__genericTypeArguments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignatureConstructedGenericType>.NativeClassPtr, "_genericTypeArguments");
			SignatureConstructedGenericType.NativeMethodInfoPtr__ctor_Internal_Void_Type_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureConstructedGenericType>.NativeClassPtr, 100672414);
			SignatureConstructedGenericType.NativeMethodInfoPtr_get_IsGenericTypeDefinition_Public_Virtual_Final_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureConstructedGenericType>.NativeClassPtr, 100672415);
			SignatureConstructedGenericType.NativeMethodInfoPtr_HasElementTypeImpl_Protected_Virtual_Final_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureConstructedGenericType>.NativeClassPtr, 100672416);
			SignatureConstructedGenericType.NativeMethodInfoPtr_IsArrayImpl_Protected_Virtual_Final_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureConstructedGenericType>.NativeClassPtr, 100672417);
			SignatureConstructedGenericType.NativeMethodInfoPtr_IsByRefImpl_Protected_Virtual_Final_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureConstructedGenericType>.NativeClassPtr, 100672418);
			SignatureConstructedGenericType.NativeMethodInfoPtr_IsPointerImpl_Protected_Virtual_Final_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureConstructedGenericType>.NativeClassPtr, 100672419);
			SignatureConstructedGenericType.NativeMethodInfoPtr_get_IsSZArray_Public_Virtual_Final_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureConstructedGenericType>.NativeClassPtr, 100672420);
			SignatureConstructedGenericType.NativeMethodInfoPtr_get_IsVariableBoundArray_Public_Virtual_Final_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureConstructedGenericType>.NativeClassPtr, 100672421);
			SignatureConstructedGenericType.NativeMethodInfoPtr_get_IsConstructedGenericType_Public_Virtual_Final_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureConstructedGenericType>.NativeClassPtr, 100672422);
			SignatureConstructedGenericType.NativeMethodInfoPtr_get_IsGenericParameter_Public_Virtual_Final_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureConstructedGenericType>.NativeClassPtr, 100672423);
			SignatureConstructedGenericType.NativeMethodInfoPtr_get_IsGenericMethodParameter_Public_Virtual_Final_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureConstructedGenericType>.NativeClassPtr, 100672424);
			SignatureConstructedGenericType.NativeMethodInfoPtr_get_ContainsGenericParameters_Public_Virtual_Final_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureConstructedGenericType>.NativeClassPtr, 100672425);
			SignatureConstructedGenericType.NativeMethodInfoPtr_get_ElementType_Internal_Virtual_Final_get_SignatureType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureConstructedGenericType>.NativeClassPtr, 100672426);
			SignatureConstructedGenericType.NativeMethodInfoPtr_GetArrayRank_Public_Virtual_Final_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureConstructedGenericType>.NativeClassPtr, 100672427);
			SignatureConstructedGenericType.NativeMethodInfoPtr_GetGenericTypeDefinition_Public_Virtual_Final_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureConstructedGenericType>.NativeClassPtr, 100672428);
			SignatureConstructedGenericType.NativeMethodInfoPtr_GetGenericArguments_Public_Virtual_Final_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureConstructedGenericType>.NativeClassPtr, 100672429);
			SignatureConstructedGenericType.NativeMethodInfoPtr_get_GenericTypeArguments_Public_Virtual_Final_get_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureConstructedGenericType>.NativeClassPtr, 100672430);
			SignatureConstructedGenericType.NativeMethodInfoPtr_get_GenericParameterPosition_Public_Virtual_Final_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureConstructedGenericType>.NativeClassPtr, 100672431);
			SignatureConstructedGenericType.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureConstructedGenericType>.NativeClassPtr, 100672432);
			SignatureConstructedGenericType.NativeMethodInfoPtr_get_Namespace_Public_Virtual_Final_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureConstructedGenericType>.NativeClassPtr, 100672433);
			SignatureConstructedGenericType.NativeMethodInfoPtr_ToString_Public_Virtual_Final_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureConstructedGenericType>.NativeClassPtr, 100672434);
		}

		// Token: 0x06003D04 RID: 15620 RVA: 0x00124730 File Offset: 0x00122930
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1399175, RefRangeEnd = 1399176, XrefRangeStart = 1399136, XrefRangeEnd = 1399175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SignatureConstructedGenericType(Type genericTypeDefinition, Il2CppReferenceArray<Type> typeArguments)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SignatureConstructedGenericType>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(genericTypeDefinition);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeArguments);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureConstructedGenericType.NativeMethodInfoPtr__ctor_Internal_Void_Type_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000E4D RID: 3661
		// (get) Token: 0x06003D05 RID: 15621 RVA: 0x00124790 File Offset: 0x00122990
		public unsafe override bool IsGenericTypeDefinition
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureConstructedGenericType.NativeMethodInfoPtr_get_IsGenericTypeDefinition_Public_Virtual_Final_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003D06 RID: 15622 RVA: 0x001247CC File Offset: 0x001229CC
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool HasElementTypeImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureConstructedGenericType.NativeMethodInfoPtr_HasElementTypeImpl_Protected_Virtual_Final_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D07 RID: 15623 RVA: 0x00124808 File Offset: 0x00122A08
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsArrayImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureConstructedGenericType.NativeMethodInfoPtr_IsArrayImpl_Protected_Virtual_Final_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D08 RID: 15624 RVA: 0x00124844 File Offset: 0x00122A44
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsByRefImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureConstructedGenericType.NativeMethodInfoPtr_IsByRefImpl_Protected_Virtual_Final_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D09 RID: 15625 RVA: 0x00124880 File Offset: 0x00122A80
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsPointerImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureConstructedGenericType.NativeMethodInfoPtr_IsPointerImpl_Protected_Virtual_Final_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000E4E RID: 3662
		// (get) Token: 0x06003D0A RID: 15626 RVA: 0x001248BC File Offset: 0x00122ABC
		public unsafe override bool IsSZArray
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureConstructedGenericType.NativeMethodInfoPtr_get_IsSZArray_Public_Virtual_Final_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E4F RID: 3663
		// (get) Token: 0x06003D0B RID: 15627 RVA: 0x001248F8 File Offset: 0x00122AF8
		public unsafe override bool IsVariableBoundArray
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureConstructedGenericType.NativeMethodInfoPtr_get_IsVariableBoundArray_Public_Virtual_Final_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E50 RID: 3664
		// (get) Token: 0x06003D0C RID: 15628 RVA: 0x00124934 File Offset: 0x00122B34
		public unsafe override bool IsConstructedGenericType
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureConstructedGenericType.NativeMethodInfoPtr_get_IsConstructedGenericType_Public_Virtual_Final_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E51 RID: 3665
		// (get) Token: 0x06003D0D RID: 15629 RVA: 0x00124970 File Offset: 0x00122B70
		public unsafe override bool IsGenericParameter
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureConstructedGenericType.NativeMethodInfoPtr_get_IsGenericParameter_Public_Virtual_Final_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E52 RID: 3666
		// (get) Token: 0x06003D0E RID: 15630 RVA: 0x001249AC File Offset: 0x00122BAC
		public unsafe override bool IsGenericMethodParameter
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureConstructedGenericType.NativeMethodInfoPtr_get_IsGenericMethodParameter_Public_Virtual_Final_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E53 RID: 3667
		// (get) Token: 0x06003D0F RID: 15631 RVA: 0x001249E8 File Offset: 0x00122BE8
		public unsafe override bool ContainsGenericParameters
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399176, XrefRangeEnd = 1399177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureConstructedGenericType.NativeMethodInfoPtr_get_ContainsGenericParameters_Public_Virtual_Final_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E54 RID: 3668
		// (get) Token: 0x06003D10 RID: 15632 RVA: 0x00124A24 File Offset: 0x00122C24
		public unsafe override SignatureType ElementType
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureConstructedGenericType.NativeMethodInfoPtr_get_ElementType_Internal_Virtual_Final_get_SignatureType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SignatureType>(intPtr3) : null;
			}
		}

		// Token: 0x06003D11 RID: 15633 RVA: 0x00124A64 File Offset: 0x00122C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399177, XrefRangeEnd = 1399183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetArrayRank()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureConstructedGenericType.NativeMethodInfoPtr_GetArrayRank_Public_Virtual_Final_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D12 RID: 15634 RVA: 0x00124AA0 File Offset: 0x00122CA0
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetGenericTypeDefinition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureConstructedGenericType.NativeMethodInfoPtr_GetGenericTypeDefinition_Public_Virtual_Final_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06003D13 RID: 15635 RVA: 0x00124AE0 File Offset: 0x00122CE0
		[CallerCount(0)]
		public unsafe override Il2CppReferenceArray<Type> GetGenericArguments()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureConstructedGenericType.NativeMethodInfoPtr_GetGenericArguments_Public_Virtual_Final_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x17000E55 RID: 3669
		// (get) Token: 0x06003D14 RID: 15636 RVA: 0x00124B20 File Offset: 0x00122D20
		public unsafe override Il2CppReferenceArray<Type> GenericTypeArguments
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399183, XrefRangeEnd = 1399186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureConstructedGenericType.NativeMethodInfoPtr_get_GenericTypeArguments_Public_Virtual_Final_get_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x17000E56 RID: 3670
		// (get) Token: 0x06003D15 RID: 15637 RVA: 0x00124B60 File Offset: 0x00122D60
		public unsafe override int GenericParameterPosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399186, XrefRangeEnd = 1399192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureConstructedGenericType.NativeMethodInfoPtr_get_GenericParameterPosition_Public_Virtual_Final_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E57 RID: 3671
		// (get) Token: 0x06003D16 RID: 15638 RVA: 0x00124B9C File Offset: 0x00122D9C
		public unsafe override string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureConstructedGenericType.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000E58 RID: 3672
		// (get) Token: 0x06003D17 RID: 15639 RVA: 0x00124BD4 File Offset: 0x00122DD4
		public unsafe override string Namespace
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureConstructedGenericType.NativeMethodInfoPtr_get_Namespace_Public_Virtual_Final_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003D18 RID: 15640 RVA: 0x00124C0C File Offset: 0x00122E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399192, XrefRangeEnd = 1399204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureConstructedGenericType.NativeMethodInfoPtr_ToString_Public_Virtual_Final_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003D19 RID: 15641 RVA: 0x000168E0 File Offset: 0x00014AE0
		public SignatureConstructedGenericType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E4B RID: 3659
		// (get) Token: 0x06003D1A RID: 15642 RVA: 0x00124C44 File Offset: 0x00122E44
		// (set) Token: 0x06003D1B RID: 15643 RVA: 0x000168E9 File Offset: 0x00014AE9
		public unsafe Type _genericTypeDefinition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignatureConstructedGenericType.NativeFieldInfoPtr__genericTypeDefinition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignatureConstructedGenericType.NativeFieldInfoPtr__genericTypeDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E4C RID: 3660
		// (get) Token: 0x06003D1C RID: 15644 RVA: 0x00124C74 File Offset: 0x00122E74
		// (set) Token: 0x06003D1D RID: 15645 RVA: 0x00016908 File Offset: 0x00014B08
		public unsafe Il2CppReferenceArray<Type> _genericTypeArguments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignatureConstructedGenericType.NativeFieldInfoPtr__genericTypeArguments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignatureConstructedGenericType.NativeFieldInfoPtr__genericTypeArguments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031CA RID: 12746
		private static readonly IntPtr NativeFieldInfoPtr__genericTypeDefinition;

		// Token: 0x040031CB RID: 12747
		private static readonly IntPtr NativeFieldInfoPtr__genericTypeArguments;

		// Token: 0x040031CC RID: 12748
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_Il2CppReferenceArray_1_Type_0;

		// Token: 0x040031CD RID: 12749
		private static readonly IntPtr NativeMethodInfoPtr_get_IsGenericTypeDefinition_Public_Virtual_Final_get_Boolean_0;

		// Token: 0x040031CE RID: 12750
		private static readonly IntPtr NativeMethodInfoPtr_HasElementTypeImpl_Protected_Virtual_Final_Boolean_0;

		// Token: 0x040031CF RID: 12751
		private static readonly IntPtr NativeMethodInfoPtr_IsArrayImpl_Protected_Virtual_Final_Boolean_0;

		// Token: 0x040031D0 RID: 12752
		private static readonly IntPtr NativeMethodInfoPtr_IsByRefImpl_Protected_Virtual_Final_Boolean_0;

		// Token: 0x040031D1 RID: 12753
		private static readonly IntPtr NativeMethodInfoPtr_IsPointerImpl_Protected_Virtual_Final_Boolean_0;

		// Token: 0x040031D2 RID: 12754
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSZArray_Public_Virtual_Final_get_Boolean_0;

		// Token: 0x040031D3 RID: 12755
		private static readonly IntPtr NativeMethodInfoPtr_get_IsVariableBoundArray_Public_Virtual_Final_get_Boolean_0;

		// Token: 0x040031D4 RID: 12756
		private static readonly IntPtr NativeMethodInfoPtr_get_IsConstructedGenericType_Public_Virtual_Final_get_Boolean_0;

		// Token: 0x040031D5 RID: 12757
		private static readonly IntPtr NativeMethodInfoPtr_get_IsGenericParameter_Public_Virtual_Final_get_Boolean_0;

		// Token: 0x040031D6 RID: 12758
		private static readonly IntPtr NativeMethodInfoPtr_get_IsGenericMethodParameter_Public_Virtual_Final_get_Boolean_0;

		// Token: 0x040031D7 RID: 12759
		private static readonly IntPtr NativeMethodInfoPtr_get_ContainsGenericParameters_Public_Virtual_Final_get_Boolean_0;

		// Token: 0x040031D8 RID: 12760
		private static readonly IntPtr NativeMethodInfoPtr_get_ElementType_Internal_Virtual_Final_get_SignatureType_0;

		// Token: 0x040031D9 RID: 12761
		private static readonly IntPtr NativeMethodInfoPtr_GetArrayRank_Public_Virtual_Final_Int32_0;

		// Token: 0x040031DA RID: 12762
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericTypeDefinition_Public_Virtual_Final_Type_0;

		// Token: 0x040031DB RID: 12763
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericArguments_Public_Virtual_Final_Il2CppReferenceArray_1_Type_0;

		// Token: 0x040031DC RID: 12764
		private static readonly IntPtr NativeMethodInfoPtr_get_GenericTypeArguments_Public_Virtual_Final_get_Il2CppReferenceArray_1_Type_0;

		// Token: 0x040031DD RID: 12765
		private static readonly IntPtr NativeMethodInfoPtr_get_GenericParameterPosition_Public_Virtual_Final_get_Int32_0;

		// Token: 0x040031DE RID: 12766
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_Final_get_String_0;

		// Token: 0x040031DF RID: 12767
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespace_Public_Virtual_Final_get_String_0;

		// Token: 0x040031E0 RID: 12768
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_String_0;
	}
}
