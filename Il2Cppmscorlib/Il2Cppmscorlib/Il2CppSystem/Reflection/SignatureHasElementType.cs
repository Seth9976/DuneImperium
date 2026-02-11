using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x0200042A RID: 1066
	public class SignatureHasElementType : SignatureType
	{
		// Token: 0x06003D1E RID: 15646 RVA: 0x00124CA4 File Offset: 0x00122EA4
		// Note: this type is marked as 'beforefieldinit'.
		static SignatureHasElementType()
		{
			Il2CppClassPointerStore<SignatureHasElementType>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "SignatureHasElementType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SignatureHasElementType>.NativeClassPtr);
			SignatureHasElementType.NativeFieldInfoPtr__elementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignatureHasElementType>.NativeClassPtr, "_elementType");
			SignatureHasElementType.NativeMethodInfoPtr__ctor_Protected_Void_SignatureType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureHasElementType>.NativeClassPtr, 100672435);
			SignatureHasElementType.NativeMethodInfoPtr_get_IsGenericTypeDefinition_Public_Virtual_Final_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureHasElementType>.NativeClassPtr, 100672436);
			SignatureHasElementType.NativeMethodInfoPtr_HasElementTypeImpl_Protected_Virtual_Final_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureHasElementType>.NativeClassPtr, 100672437);
			SignatureHasElementType.NativeMethodInfoPtr_IsArrayImpl_Protected_Abstract_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureHasElementType>.NativeClassPtr, 100672438);
			SignatureHasElementType.NativeMethodInfoPtr_IsByRefImpl_Protected_Abstract_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureHasElementType>.NativeClassPtr, 100672439);
			SignatureHasElementType.NativeMethodInfoPtr_IsPointerImpl_Protected_Abstract_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureHasElementType>.NativeClassPtr, 100672440);
			SignatureHasElementType.NativeMethodInfoPtr_get_IsSZArray_Public_Abstract_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureHasElementType>.NativeClassPtr, 100672441);
			SignatureHasElementType.NativeMethodInfoPtr_get_IsVariableBoundArray_Public_Abstract_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureHasElementType>.NativeClassPtr, 100672442);
			SignatureHasElementType.NativeMethodInfoPtr_get_IsConstructedGenericType_Public_Virtual_Final_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureHasElementType>.NativeClassPtr, 100672443);
			SignatureHasElementType.NativeMethodInfoPtr_get_IsGenericParameter_Public_Virtual_Final_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureHasElementType>.NativeClassPtr, 100672444);
			SignatureHasElementType.NativeMethodInfoPtr_get_IsGenericMethodParameter_Public_Virtual_Final_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureHasElementType>.NativeClassPtr, 100672445);
			SignatureHasElementType.NativeMethodInfoPtr_get_ContainsGenericParameters_Public_Virtual_Final_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureHasElementType>.NativeClassPtr, 100672446);
			SignatureHasElementType.NativeMethodInfoPtr_get_ElementType_Internal_Virtual_Final_get_SignatureType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureHasElementType>.NativeClassPtr, 100672447);
			SignatureHasElementType.NativeMethodInfoPtr_GetArrayRank_Public_Abstract_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureHasElementType>.NativeClassPtr, 100672448);
			SignatureHasElementType.NativeMethodInfoPtr_GetGenericTypeDefinition_Public_Virtual_Final_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureHasElementType>.NativeClassPtr, 100672449);
			SignatureHasElementType.NativeMethodInfoPtr_GetGenericArguments_Public_Virtual_Final_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureHasElementType>.NativeClassPtr, 100672450);
			SignatureHasElementType.NativeMethodInfoPtr_get_GenericTypeArguments_Public_Virtual_Final_get_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureHasElementType>.NativeClassPtr, 100672451);
			SignatureHasElementType.NativeMethodInfoPtr_get_GenericParameterPosition_Public_Virtual_Final_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureHasElementType>.NativeClassPtr, 100672452);
			SignatureHasElementType.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureHasElementType>.NativeClassPtr, 100672453);
			SignatureHasElementType.NativeMethodInfoPtr_get_Namespace_Public_Virtual_Final_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureHasElementType>.NativeClassPtr, 100672454);
			SignatureHasElementType.NativeMethodInfoPtr_ToString_Public_Virtual_Final_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureHasElementType>.NativeClassPtr, 100672455);
			SignatureHasElementType.NativeMethodInfoPtr_get_Suffix_Protected_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureHasElementType>.NativeClassPtr, 100672456);
		}

		// Token: 0x06003D1F RID: 15647 RVA: 0x00124EA0 File Offset: 0x001230A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SignatureHasElementType(SignatureType elementType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SignatureHasElementType>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureHasElementType.NativeMethodInfoPtr__ctor_Protected_Void_SignatureType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000E5A RID: 3674
		// (get) Token: 0x06003D20 RID: 15648 RVA: 0x00124EEC File Offset: 0x001230EC
		public unsafe override bool IsGenericTypeDefinition
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureHasElementType.NativeMethodInfoPtr_get_IsGenericTypeDefinition_Public_Virtual_Final_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003D21 RID: 15649 RVA: 0x00124F28 File Offset: 0x00123128
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool HasElementTypeImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureHasElementType.NativeMethodInfoPtr_HasElementTypeImpl_Protected_Virtual_Final_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D22 RID: 15650 RVA: 0x00124F64 File Offset: 0x00123164
		[CallerCount(0)]
		public unsafe override bool IsArrayImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SignatureHasElementType.NativeMethodInfoPtr_IsArrayImpl_Protected_Abstract_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D23 RID: 15651 RVA: 0x00124FAC File Offset: 0x001231AC
		[CallerCount(0)]
		public unsafe override bool IsByRefImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SignatureHasElementType.NativeMethodInfoPtr_IsByRefImpl_Protected_Abstract_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D24 RID: 15652 RVA: 0x00124FF4 File Offset: 0x001231F4
		[CallerCount(0)]
		public unsafe override bool IsPointerImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SignatureHasElementType.NativeMethodInfoPtr_IsPointerImpl_Protected_Abstract_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000E5B RID: 3675
		// (get) Token: 0x06003D25 RID: 15653 RVA: 0x0012503C File Offset: 0x0012323C
		public unsafe override bool IsSZArray
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SignatureHasElementType.NativeMethodInfoPtr_get_IsSZArray_Public_Abstract_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E5C RID: 3676
		// (get) Token: 0x06003D26 RID: 15654 RVA: 0x00125084 File Offset: 0x00123284
		public unsafe override bool IsVariableBoundArray
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SignatureHasElementType.NativeMethodInfoPtr_get_IsVariableBoundArray_Public_Abstract_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E5D RID: 3677
		// (get) Token: 0x06003D27 RID: 15655 RVA: 0x001250CC File Offset: 0x001232CC
		public unsafe override bool IsConstructedGenericType
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureHasElementType.NativeMethodInfoPtr_get_IsConstructedGenericType_Public_Virtual_Final_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E5E RID: 3678
		// (get) Token: 0x06003D28 RID: 15656 RVA: 0x00125108 File Offset: 0x00123308
		public unsafe override bool IsGenericParameter
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureHasElementType.NativeMethodInfoPtr_get_IsGenericParameter_Public_Virtual_Final_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E5F RID: 3679
		// (get) Token: 0x06003D29 RID: 15657 RVA: 0x00125144 File Offset: 0x00123344
		public unsafe override bool IsGenericMethodParameter
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureHasElementType.NativeMethodInfoPtr_get_IsGenericMethodParameter_Public_Virtual_Final_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E60 RID: 3680
		// (get) Token: 0x06003D2A RID: 15658 RVA: 0x00125180 File Offset: 0x00123380
		public unsafe override bool ContainsGenericParameters
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399204, XrefRangeEnd = 1399205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureHasElementType.NativeMethodInfoPtr_get_ContainsGenericParameters_Public_Virtual_Final_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E61 RID: 3681
		// (get) Token: 0x06003D2B RID: 15659 RVA: 0x001251BC File Offset: 0x001233BC
		public unsafe override SignatureType ElementType
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureHasElementType.NativeMethodInfoPtr_get_ElementType_Internal_Virtual_Final_get_SignatureType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SignatureType>(intPtr3) : null;
			}
		}

		// Token: 0x06003D2C RID: 15660 RVA: 0x001251FC File Offset: 0x001233FC
		[CallerCount(0)]
		public unsafe override int GetArrayRank()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SignatureHasElementType.NativeMethodInfoPtr_GetArrayRank_Public_Abstract_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D2D RID: 15661 RVA: 0x00125244 File Offset: 0x00123444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399205, XrefRangeEnd = 1399211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetGenericTypeDefinition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureHasElementType.NativeMethodInfoPtr_GetGenericTypeDefinition_Public_Virtual_Final_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06003D2E RID: 15662 RVA: 0x00125284 File Offset: 0x00123484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399211, XrefRangeEnd = 1399214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Type> GetGenericArguments()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureHasElementType.NativeMethodInfoPtr_GetGenericArguments_Public_Virtual_Final_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x17000E62 RID: 3682
		// (get) Token: 0x06003D2F RID: 15663 RVA: 0x001252C4 File Offset: 0x001234C4
		public unsafe override Il2CppReferenceArray<Type> GenericTypeArguments
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399214, XrefRangeEnd = 1399217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureHasElementType.NativeMethodInfoPtr_get_GenericTypeArguments_Public_Virtual_Final_get_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x17000E63 RID: 3683
		// (get) Token: 0x06003D30 RID: 15664 RVA: 0x00125304 File Offset: 0x00123504
		public unsafe override int GenericParameterPosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399217, XrefRangeEnd = 1399223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureHasElementType.NativeMethodInfoPtr_get_GenericParameterPosition_Public_Virtual_Final_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E64 RID: 3684
		// (get) Token: 0x06003D31 RID: 15665 RVA: 0x00125340 File Offset: 0x00123540
		public unsafe override string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399223, XrefRangeEnd = 1399225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureHasElementType.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000E65 RID: 3685
		// (get) Token: 0x06003D32 RID: 15666 RVA: 0x00125378 File Offset: 0x00123578
		public unsafe override string Namespace
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureHasElementType.NativeMethodInfoPtr_get_Namespace_Public_Virtual_Final_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003D33 RID: 15667 RVA: 0x001253B0 File Offset: 0x001235B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399225, XrefRangeEnd = 1399227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureHasElementType.NativeMethodInfoPtr_ToString_Public_Virtual_Final_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000E66 RID: 3686
		// (get) Token: 0x06003D34 RID: 15668 RVA: 0x001253E8 File Offset: 0x001235E8
		public unsafe virtual string Suffix
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SignatureHasElementType.NativeMethodInfoPtr_get_Suffix_Protected_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003D35 RID: 15669 RVA: 0x00016927 File Offset: 0x00014B27
		public SignatureHasElementType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E59 RID: 3673
		// (get) Token: 0x06003D36 RID: 15670 RVA: 0x0012542C File Offset: 0x0012362C
		// (set) Token: 0x06003D37 RID: 15671 RVA: 0x00016930 File Offset: 0x00014B30
		public unsafe SignatureType _elementType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignatureHasElementType.NativeFieldInfoPtr__elementType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SignatureType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignatureHasElementType.NativeFieldInfoPtr__elementType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031E1 RID: 12769
		private static readonly IntPtr NativeFieldInfoPtr__elementType;

		// Token: 0x040031E2 RID: 12770
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SignatureType_0;

		// Token: 0x040031E3 RID: 12771
		private static readonly IntPtr NativeMethodInfoPtr_get_IsGenericTypeDefinition_Public_Virtual_Final_get_Boolean_0;

		// Token: 0x040031E4 RID: 12772
		private static readonly IntPtr NativeMethodInfoPtr_HasElementTypeImpl_Protected_Virtual_Final_Boolean_0;

		// Token: 0x040031E5 RID: 12773
		private static readonly IntPtr NativeMethodInfoPtr_IsArrayImpl_Protected_Abstract_Virtual_Boolean_0;

		// Token: 0x040031E6 RID: 12774
		private static readonly IntPtr NativeMethodInfoPtr_IsByRefImpl_Protected_Abstract_Virtual_Boolean_0;

		// Token: 0x040031E7 RID: 12775
		private static readonly IntPtr NativeMethodInfoPtr_IsPointerImpl_Protected_Abstract_Virtual_Boolean_0;

		// Token: 0x040031E8 RID: 12776
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSZArray_Public_Abstract_Virtual_get_Boolean_0;

		// Token: 0x040031E9 RID: 12777
		private static readonly IntPtr NativeMethodInfoPtr_get_IsVariableBoundArray_Public_Abstract_Virtual_get_Boolean_0;

		// Token: 0x040031EA RID: 12778
		private static readonly IntPtr NativeMethodInfoPtr_get_IsConstructedGenericType_Public_Virtual_Final_get_Boolean_0;

		// Token: 0x040031EB RID: 12779
		private static readonly IntPtr NativeMethodInfoPtr_get_IsGenericParameter_Public_Virtual_Final_get_Boolean_0;

		// Token: 0x040031EC RID: 12780
		private static readonly IntPtr NativeMethodInfoPtr_get_IsGenericMethodParameter_Public_Virtual_Final_get_Boolean_0;

		// Token: 0x040031ED RID: 12781
		private static readonly IntPtr NativeMethodInfoPtr_get_ContainsGenericParameters_Public_Virtual_Final_get_Boolean_0;

		// Token: 0x040031EE RID: 12782
		private static readonly IntPtr NativeMethodInfoPtr_get_ElementType_Internal_Virtual_Final_get_SignatureType_0;

		// Token: 0x040031EF RID: 12783
		private static readonly IntPtr NativeMethodInfoPtr_GetArrayRank_Public_Abstract_Virtual_Int32_0;

		// Token: 0x040031F0 RID: 12784
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericTypeDefinition_Public_Virtual_Final_Type_0;

		// Token: 0x040031F1 RID: 12785
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericArguments_Public_Virtual_Final_Il2CppReferenceArray_1_Type_0;

		// Token: 0x040031F2 RID: 12786
		private static readonly IntPtr NativeMethodInfoPtr_get_GenericTypeArguments_Public_Virtual_Final_get_Il2CppReferenceArray_1_Type_0;

		// Token: 0x040031F3 RID: 12787
		private static readonly IntPtr NativeMethodInfoPtr_get_GenericParameterPosition_Public_Virtual_Final_get_Int32_0;

		// Token: 0x040031F4 RID: 12788
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_Final_get_String_0;

		// Token: 0x040031F5 RID: 12789
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespace_Public_Virtual_Final_get_String_0;

		// Token: 0x040031F6 RID: 12790
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_String_0;

		// Token: 0x040031F7 RID: 12791
		private static readonly IntPtr NativeMethodInfoPtr_get_Suffix_Protected_Abstract_Virtual_New_get_String_0;
	}
}
