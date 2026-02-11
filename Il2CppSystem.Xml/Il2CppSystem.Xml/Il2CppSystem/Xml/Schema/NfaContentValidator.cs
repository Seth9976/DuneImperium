using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000124 RID: 292
	public sealed class NfaContentValidator : ContentValidator
	{
		// Token: 0x0600197A RID: 6522 RVA: 0x00082830 File Offset: 0x00080A30
		// Note: this type is marked as 'beforefieldinit'.
		static NfaContentValidator()
		{
			Il2CppClassPointerStore<NfaContentValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "NfaContentValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NfaContentValidator>.NativeClassPtr);
			NfaContentValidator.NativeFieldInfoPtr_firstpos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NfaContentValidator>.NativeClassPtr, "firstpos");
			NfaContentValidator.NativeFieldInfoPtr_followpos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NfaContentValidator>.NativeClassPtr, "followpos");
			NfaContentValidator.NativeFieldInfoPtr_symbols = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NfaContentValidator>.NativeClassPtr, "symbols");
			NfaContentValidator.NativeFieldInfoPtr_positions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NfaContentValidator>.NativeClassPtr, "positions");
			NfaContentValidator.NativeFieldInfoPtr_endMarkerPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NfaContentValidator>.NativeClassPtr, "endMarkerPos");
			NfaContentValidator.NativeMethodInfoPtr__ctor_Internal_Void_BitSet_Il2CppReferenceArray_1_BitSet_SymbolsDictionary_Positions_Int32_XmlSchemaContentType_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NfaContentValidator>.NativeClassPtr, 100667225);
			NfaContentValidator.NativeMethodInfoPtr_InitValidation_Public_Virtual_Void_ValidationState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NfaContentValidator>.NativeClassPtr, 100667226);
			NfaContentValidator.NativeMethodInfoPtr_ValidateElement_Public_Virtual_Object_XmlQualifiedName_ValidationState_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NfaContentValidator>.NativeClassPtr, 100667227);
			NfaContentValidator.NativeMethodInfoPtr_CompleteValidation_Public_Virtual_Boolean_ValidationState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NfaContentValidator>.NativeClassPtr, 100667228);
			NfaContentValidator.NativeMethodInfoPtr_ExpectedElements_Public_Virtual_ArrayList_ValidationState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NfaContentValidator>.NativeClassPtr, 100667229);
			NfaContentValidator.NativeMethodInfoPtr_ExpectedParticles_Public_Virtual_ArrayList_ValidationState_Boolean_XmlSchemaSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NfaContentValidator>.NativeClassPtr, 100667230);
		}

		// Token: 0x0600197B RID: 6523 RVA: 0x0008293C File Offset: 0x00080B3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 392897, RefRangeEnd = 392898, XrefRangeStart = 392889, XrefRangeEnd = 392897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NfaContentValidator(BitSet firstpos, Il2CppReferenceArray<BitSet> followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NfaContentValidator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(firstpos);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(followpos);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(symbols);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(positions);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endMarkerPos;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contentType;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isOpen;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isEmptiable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NfaContentValidator.NativeMethodInfoPtr__ctor_Internal_Void_BitSet_Il2CppReferenceArray_1_BitSet_SymbolsDictionary_Positions_Int32_XmlSchemaContentType_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600197C RID: 6524 RVA: 0x000829F8 File Offset: 0x00080BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392898, XrefRangeEnd = 392905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitValidation(ValidationState context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NfaContentValidator.NativeMethodInfoPtr_InitValidation_Public_Virtual_Void_ValidationState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600197D RID: 6525 RVA: 0x00082A3C File Offset: 0x00080C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392905, XrefRangeEnd = 392916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NfaContentValidator.NativeMethodInfoPtr_ValidateElement_Public_Virtual_Object_XmlQualifiedName_ValidationState_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x00082AAC File Offset: 0x00080CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392916, XrefRangeEnd = 392917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CompleteValidation(ValidationState context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NfaContentValidator.NativeMethodInfoPtr_CompleteValidation_Public_Virtual_Boolean_ValidationState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x00082AFC File Offset: 0x00080CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392917, XrefRangeEnd = 392929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NfaContentValidator.NativeMethodInfoPtr_ExpectedElements_Public_Virtual_ArrayList_ValidationState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x00082B5C File Offset: 0x00080D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392929, XrefRangeEnd = 392942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NfaContentValidator.NativeMethodInfoPtr_ExpectedParticles_Public_Virtual_ArrayList_ValidationState_Boolean_XmlSchemaSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
		}

		// Token: 0x06001981 RID: 6529 RVA: 0x0000AD4F File Offset: 0x00008F4F
		public NfaContentValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06001982 RID: 6530 RVA: 0x00082BCC File Offset: 0x00080DCC
		// (set) Token: 0x06001983 RID: 6531 RVA: 0x0000AD58 File Offset: 0x00008F58
		public unsafe BitSet firstpos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NfaContentValidator.NativeFieldInfoPtr_firstpos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BitSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NfaContentValidator.NativeFieldInfoPtr_firstpos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06001984 RID: 6532 RVA: 0x00082BFC File Offset: 0x00080DFC
		// (set) Token: 0x06001985 RID: 6533 RVA: 0x0000AD77 File Offset: 0x00008F77
		public unsafe Il2CppReferenceArray<BitSet> followpos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NfaContentValidator.NativeFieldInfoPtr_followpos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BitSet>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NfaContentValidator.NativeFieldInfoPtr_followpos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x06001986 RID: 6534 RVA: 0x00082C2C File Offset: 0x00080E2C
		// (set) Token: 0x06001987 RID: 6535 RVA: 0x0000AD96 File Offset: 0x00008F96
		public unsafe SymbolsDictionary symbols
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NfaContentValidator.NativeFieldInfoPtr_symbols);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SymbolsDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NfaContentValidator.NativeFieldInfoPtr_symbols), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x06001988 RID: 6536 RVA: 0x00082C5C File Offset: 0x00080E5C
		// (set) Token: 0x06001989 RID: 6537 RVA: 0x0000ADB5 File Offset: 0x00008FB5
		public unsafe Positions positions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NfaContentValidator.NativeFieldInfoPtr_positions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Positions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NfaContentValidator.NativeFieldInfoPtr_positions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x0600198A RID: 6538 RVA: 0x00082C8C File Offset: 0x00080E8C
		// (set) Token: 0x0600198B RID: 6539 RVA: 0x0000ADD4 File Offset: 0x00008FD4
		public unsafe int endMarkerPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NfaContentValidator.NativeFieldInfoPtr_endMarkerPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NfaContentValidator.NativeFieldInfoPtr_endMarkerPos)) = value;
			}
		}

		// Token: 0x040013D3 RID: 5075
		private static readonly IntPtr NativeFieldInfoPtr_firstpos;

		// Token: 0x040013D4 RID: 5076
		private static readonly IntPtr NativeFieldInfoPtr_followpos;

		// Token: 0x040013D5 RID: 5077
		private static readonly IntPtr NativeFieldInfoPtr_symbols;

		// Token: 0x040013D6 RID: 5078
		private static readonly IntPtr NativeFieldInfoPtr_positions;

		// Token: 0x040013D7 RID: 5079
		private static readonly IntPtr NativeFieldInfoPtr_endMarkerPos;

		// Token: 0x040013D8 RID: 5080
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BitSet_Il2CppReferenceArray_1_BitSet_SymbolsDictionary_Positions_Int32_XmlSchemaContentType_Boolean_Boolean_0;

		// Token: 0x040013D9 RID: 5081
		private static readonly IntPtr NativeMethodInfoPtr_InitValidation_Public_Virtual_Void_ValidationState_0;

		// Token: 0x040013DA RID: 5082
		private static readonly IntPtr NativeMethodInfoPtr_ValidateElement_Public_Virtual_Object_XmlQualifiedName_ValidationState_byref_Int32_0;

		// Token: 0x040013DB RID: 5083
		private static readonly IntPtr NativeMethodInfoPtr_CompleteValidation_Public_Virtual_Boolean_ValidationState_0;

		// Token: 0x040013DC RID: 5084
		private static readonly IntPtr NativeMethodInfoPtr_ExpectedElements_Public_Virtual_ArrayList_ValidationState_Boolean_0;

		// Token: 0x040013DD RID: 5085
		private static readonly IntPtr NativeMethodInfoPtr_ExpectedParticles_Public_Virtual_ArrayList_ValidationState_Boolean_XmlSchemaSet_0;
	}
}
