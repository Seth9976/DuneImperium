using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000126 RID: 294
	public sealed class RangeContentValidator : ContentValidator
	{
		// Token: 0x06001993 RID: 6547 RVA: 0x00082D6C File Offset: 0x00080F6C
		// Note: this type is marked as 'beforefieldinit'.
		static RangeContentValidator()
		{
			Il2CppClassPointerStore<RangeContentValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "RangeContentValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RangeContentValidator>.NativeClassPtr);
			RangeContentValidator.NativeFieldInfoPtr_firstpos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeContentValidator>.NativeClassPtr, "firstpos");
			RangeContentValidator.NativeFieldInfoPtr_followpos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeContentValidator>.NativeClassPtr, "followpos");
			RangeContentValidator.NativeFieldInfoPtr_positionsWithRangeTerminals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeContentValidator>.NativeClassPtr, "positionsWithRangeTerminals");
			RangeContentValidator.NativeFieldInfoPtr_symbols = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeContentValidator>.NativeClassPtr, "symbols");
			RangeContentValidator.NativeFieldInfoPtr_positions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeContentValidator>.NativeClassPtr, "positions");
			RangeContentValidator.NativeFieldInfoPtr_minMaxNodesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeContentValidator>.NativeClassPtr, "minMaxNodesCount");
			RangeContentValidator.NativeFieldInfoPtr_endMarkerPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeContentValidator>.NativeClassPtr, "endMarkerPos");
			RangeContentValidator.NativeMethodInfoPtr__ctor_Internal_Void_BitSet_Il2CppReferenceArray_1_BitSet_SymbolsDictionary_Positions_Int32_XmlSchemaContentType_Boolean_BitSet_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeContentValidator>.NativeClassPtr, 100667231);
			RangeContentValidator.NativeMethodInfoPtr_InitValidation_Public_Virtual_Void_ValidationState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeContentValidator>.NativeClassPtr, 100667232);
			RangeContentValidator.NativeMethodInfoPtr_ValidateElement_Public_Virtual_Object_XmlQualifiedName_ValidationState_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeContentValidator>.NativeClassPtr, 100667233);
			RangeContentValidator.NativeMethodInfoPtr_CompleteValidation_Public_Virtual_Boolean_ValidationState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeContentValidator>.NativeClassPtr, 100667234);
			RangeContentValidator.NativeMethodInfoPtr_ExpectedElements_Public_Virtual_ArrayList_ValidationState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeContentValidator>.NativeClassPtr, 100667235);
			RangeContentValidator.NativeMethodInfoPtr_ExpectedParticles_Public_Virtual_ArrayList_ValidationState_Boolean_XmlSchemaSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeContentValidator>.NativeClassPtr, 100667236);
		}

		// Token: 0x06001994 RID: 6548 RVA: 0x00082EA0 File Offset: 0x000810A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392942, XrefRangeEnd = 392951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RangeContentValidator(BitSet firstpos, Il2CppReferenceArray<BitSet> followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isEmptiable, BitSet positionsWithRangeTerminals, int minmaxNodesCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RangeContentValidator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(firstpos);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(followpos);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(symbols);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(positions);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endMarkerPos;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contentType;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isEmptiable;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(positionsWithRangeTerminals);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minmaxNodesCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RangeContentValidator.NativeMethodInfoPtr__ctor_Internal_Void_BitSet_Il2CppReferenceArray_1_BitSet_SymbolsDictionary_Positions_Int32_XmlSchemaContentType_Boolean_BitSet_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001995 RID: 6549 RVA: 0x00082F70 File Offset: 0x00081170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392951, XrefRangeEnd = 392974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitValidation(ValidationState context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RangeContentValidator.NativeMethodInfoPtr_InitValidation_Public_Virtual_Void_ValidationState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001996 RID: 6550 RVA: 0x00082FB4 File Offset: 0x000811B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392974, XrefRangeEnd = 393063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RangeContentValidator.NativeMethodInfoPtr_ValidateElement_Public_Virtual_Object_XmlQualifiedName_ValidationState_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001997 RID: 6551 RVA: 0x00083024 File Offset: 0x00081224
		[CallerCount(0)]
		public unsafe override bool CompleteValidation(ValidationState context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RangeContentValidator.NativeMethodInfoPtr_CompleteValidation_Public_Virtual_Boolean_ValidationState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x00083074 File Offset: 0x00081274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393063, XrefRangeEnd = 393087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RangeContentValidator.NativeMethodInfoPtr_ExpectedElements_Public_Virtual_ArrayList_ValidationState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x000830D4 File Offset: 0x000812D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393087, XrefRangeEnd = 393112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RangeContentValidator.NativeMethodInfoPtr_ExpectedParticles_Public_Virtual_ArrayList_ValidationState_Boolean_XmlSchemaSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
		}

		// Token: 0x0600199A RID: 6554 RVA: 0x0000AE48 File Offset: 0x00009048
		public RangeContentValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x0600199B RID: 6555 RVA: 0x00083144 File Offset: 0x00081344
		// (set) Token: 0x0600199C RID: 6556 RVA: 0x0000AE51 File Offset: 0x00009051
		public unsafe BitSet firstpos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeContentValidator.NativeFieldInfoPtr_firstpos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BitSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeContentValidator.NativeFieldInfoPtr_firstpos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x0600199D RID: 6557 RVA: 0x00083174 File Offset: 0x00081374
		// (set) Token: 0x0600199E RID: 6558 RVA: 0x0000AE70 File Offset: 0x00009070
		public unsafe Il2CppReferenceArray<BitSet> followpos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeContentValidator.NativeFieldInfoPtr_followpos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BitSet>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeContentValidator.NativeFieldInfoPtr_followpos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x0600199F RID: 6559 RVA: 0x000831A4 File Offset: 0x000813A4
		// (set) Token: 0x060019A0 RID: 6560 RVA: 0x0000AE8F File Offset: 0x0000908F
		public unsafe BitSet positionsWithRangeTerminals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeContentValidator.NativeFieldInfoPtr_positionsWithRangeTerminals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BitSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeContentValidator.NativeFieldInfoPtr_positionsWithRangeTerminals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x060019A1 RID: 6561 RVA: 0x000831D4 File Offset: 0x000813D4
		// (set) Token: 0x060019A2 RID: 6562 RVA: 0x0000AEAE File Offset: 0x000090AE
		public unsafe SymbolsDictionary symbols
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeContentValidator.NativeFieldInfoPtr_symbols);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SymbolsDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeContentValidator.NativeFieldInfoPtr_symbols), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x060019A3 RID: 6563 RVA: 0x00083204 File Offset: 0x00081404
		// (set) Token: 0x060019A4 RID: 6564 RVA: 0x0000AECD File Offset: 0x000090CD
		public unsafe Positions positions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeContentValidator.NativeFieldInfoPtr_positions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Positions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeContentValidator.NativeFieldInfoPtr_positions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x060019A5 RID: 6565 RVA: 0x00083234 File Offset: 0x00081434
		// (set) Token: 0x060019A6 RID: 6566 RVA: 0x0000AEEC File Offset: 0x000090EC
		public unsafe int minMaxNodesCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeContentValidator.NativeFieldInfoPtr_minMaxNodesCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeContentValidator.NativeFieldInfoPtr_minMaxNodesCount)) = value;
			}
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x060019A7 RID: 6567 RVA: 0x0008325C File Offset: 0x0008145C
		// (set) Token: 0x060019A8 RID: 6568 RVA: 0x0000AF07 File Offset: 0x00009107
		public unsafe int endMarkerPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeContentValidator.NativeFieldInfoPtr_endMarkerPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeContentValidator.NativeFieldInfoPtr_endMarkerPos)) = value;
			}
		}

		// Token: 0x040013E0 RID: 5088
		private static readonly IntPtr NativeFieldInfoPtr_firstpos;

		// Token: 0x040013E1 RID: 5089
		private static readonly IntPtr NativeFieldInfoPtr_followpos;

		// Token: 0x040013E2 RID: 5090
		private static readonly IntPtr NativeFieldInfoPtr_positionsWithRangeTerminals;

		// Token: 0x040013E3 RID: 5091
		private static readonly IntPtr NativeFieldInfoPtr_symbols;

		// Token: 0x040013E4 RID: 5092
		private static readonly IntPtr NativeFieldInfoPtr_positions;

		// Token: 0x040013E5 RID: 5093
		private static readonly IntPtr NativeFieldInfoPtr_minMaxNodesCount;

		// Token: 0x040013E6 RID: 5094
		private static readonly IntPtr NativeFieldInfoPtr_endMarkerPos;

		// Token: 0x040013E7 RID: 5095
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BitSet_Il2CppReferenceArray_1_BitSet_SymbolsDictionary_Positions_Int32_XmlSchemaContentType_Boolean_BitSet_Int32_0;

		// Token: 0x040013E8 RID: 5096
		private static readonly IntPtr NativeMethodInfoPtr_InitValidation_Public_Virtual_Void_ValidationState_0;

		// Token: 0x040013E9 RID: 5097
		private static readonly IntPtr NativeMethodInfoPtr_ValidateElement_Public_Virtual_Object_XmlQualifiedName_ValidationState_byref_Int32_0;

		// Token: 0x040013EA RID: 5098
		private static readonly IntPtr NativeMethodInfoPtr_CompleteValidation_Public_Virtual_Boolean_ValidationState_0;

		// Token: 0x040013EB RID: 5099
		private static readonly IntPtr NativeMethodInfoPtr_ExpectedElements_Public_Virtual_ArrayList_ValidationState_Boolean_0;

		// Token: 0x040013EC RID: 5100
		private static readonly IntPtr NativeMethodInfoPtr_ExpectedParticles_Public_Virtual_ArrayList_ValidationState_Boolean_XmlSchemaSet_0;
	}
}
