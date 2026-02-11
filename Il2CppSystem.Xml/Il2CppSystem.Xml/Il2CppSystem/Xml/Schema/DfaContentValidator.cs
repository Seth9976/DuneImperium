using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000123 RID: 291
	public sealed class DfaContentValidator : ContentValidator
	{
		// Token: 0x0600196E RID: 6510 RVA: 0x000824A4 File Offset: 0x000806A4
		// Note: this type is marked as 'beforefieldinit'.
		static DfaContentValidator()
		{
			Il2CppClassPointerStore<DfaContentValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "DfaContentValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DfaContentValidator>.NativeClassPtr);
			DfaContentValidator.NativeFieldInfoPtr_transitionTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DfaContentValidator>.NativeClassPtr, "transitionTable");
			DfaContentValidator.NativeFieldInfoPtr_symbols = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DfaContentValidator>.NativeClassPtr, "symbols");
			DfaContentValidator.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_SymbolsDictionary_XmlSchemaContentType_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DfaContentValidator>.NativeClassPtr, 100667219);
			DfaContentValidator.NativeMethodInfoPtr_InitValidation_Public_Virtual_Void_ValidationState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DfaContentValidator>.NativeClassPtr, 100667220);
			DfaContentValidator.NativeMethodInfoPtr_ValidateElement_Public_Virtual_Object_XmlQualifiedName_ValidationState_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DfaContentValidator>.NativeClassPtr, 100667221);
			DfaContentValidator.NativeMethodInfoPtr_CompleteValidation_Public_Virtual_Boolean_ValidationState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DfaContentValidator>.NativeClassPtr, 100667222);
			DfaContentValidator.NativeMethodInfoPtr_ExpectedElements_Public_Virtual_ArrayList_ValidationState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DfaContentValidator>.NativeClassPtr, 100667223);
			DfaContentValidator.NativeMethodInfoPtr_ExpectedParticles_Public_Virtual_ArrayList_ValidationState_Boolean_XmlSchemaSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DfaContentValidator>.NativeClassPtr, 100667224);
		}

		// Token: 0x0600196F RID: 6511 RVA: 0x00082574 File Offset: 0x00080774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392855, XrefRangeEnd = 392861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DfaContentValidator(Il2CppReferenceArray<Il2CppStructArray<int>> transitionTable, SymbolsDictionary symbols, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DfaContentValidator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transitionTable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(symbols);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contentType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isOpen;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isEmptiable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DfaContentValidator.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_SymbolsDictionary_XmlSchemaContentType_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001970 RID: 6512 RVA: 0x000825FC File Offset: 0x000807FC
		[CallerCount(0)]
		public unsafe override void InitValidation(ValidationState context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DfaContentValidator.NativeMethodInfoPtr_InitValidation_Public_Virtual_Void_ValidationState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001971 RID: 6513 RVA: 0x00082640 File Offset: 0x00080840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392861, XrefRangeEnd = 392867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errorCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DfaContentValidator.NativeMethodInfoPtr_ValidateElement_Public_Virtual_Object_XmlQualifiedName_ValidationState_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001972 RID: 6514 RVA: 0x000826B0 File Offset: 0x000808B0
		[CallerCount(0)]
		public unsafe override bool CompleteValidation(ValidationState context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DfaContentValidator.NativeMethodInfoPtr_CompleteValidation_Public_Virtual_Boolean_ValidationState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001973 RID: 6515 RVA: 0x00082700 File Offset: 0x00080900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392867, XrefRangeEnd = 392877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isRequiredOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DfaContentValidator.NativeMethodInfoPtr_ExpectedElements_Public_Virtual_ArrayList_ValidationState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
		}

		// Token: 0x06001974 RID: 6516 RVA: 0x00082760 File Offset: 0x00080960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392877, XrefRangeEnd = 392889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isRequiredOnly;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaSet);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DfaContentValidator.NativeMethodInfoPtr_ExpectedParticles_Public_Virtual_ArrayList_ValidationState_Boolean_XmlSchemaSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
		}

		// Token: 0x06001975 RID: 6517 RVA: 0x0000AD08 File Offset: 0x00008F08
		public DfaContentValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x06001976 RID: 6518 RVA: 0x000827D0 File Offset: 0x000809D0
		// (set) Token: 0x06001977 RID: 6519 RVA: 0x0000AD11 File Offset: 0x00008F11
		public unsafe Il2CppReferenceArray<Il2CppStructArray<int>> transitionTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DfaContentValidator.NativeFieldInfoPtr_transitionTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DfaContentValidator.NativeFieldInfoPtr_transitionTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x06001978 RID: 6520 RVA: 0x00082800 File Offset: 0x00080A00
		// (set) Token: 0x06001979 RID: 6521 RVA: 0x0000AD30 File Offset: 0x00008F30
		public unsafe SymbolsDictionary symbols
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DfaContentValidator.NativeFieldInfoPtr_symbols);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SymbolsDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DfaContentValidator.NativeFieldInfoPtr_symbols), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040013CB RID: 5067
		private static readonly IntPtr NativeFieldInfoPtr_transitionTable;

		// Token: 0x040013CC RID: 5068
		private static readonly IntPtr NativeFieldInfoPtr_symbols;

		// Token: 0x040013CD RID: 5069
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_SymbolsDictionary_XmlSchemaContentType_Boolean_Boolean_0;

		// Token: 0x040013CE RID: 5070
		private static readonly IntPtr NativeMethodInfoPtr_InitValidation_Public_Virtual_Void_ValidationState_0;

		// Token: 0x040013CF RID: 5071
		private static readonly IntPtr NativeMethodInfoPtr_ValidateElement_Public_Virtual_Object_XmlQualifiedName_ValidationState_byref_Int32_0;

		// Token: 0x040013D0 RID: 5072
		private static readonly IntPtr NativeMethodInfoPtr_CompleteValidation_Public_Virtual_Boolean_ValidationState_0;

		// Token: 0x040013D1 RID: 5073
		private static readonly IntPtr NativeMethodInfoPtr_ExpectedElements_Public_Virtual_ArrayList_ValidationState_Boolean_0;

		// Token: 0x040013D2 RID: 5074
		private static readonly IntPtr NativeMethodInfoPtr_ExpectedParticles_Public_Virtual_ArrayList_ValidationState_Boolean_XmlSchemaSet_0;
	}
}
