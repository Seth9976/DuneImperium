using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000127 RID: 295
	public sealed class AllElementsContentValidator : ContentValidator
	{
		// Token: 0x060019A9 RID: 6569 RVA: 0x00083284 File Offset: 0x00081484
		// Note: this type is marked as 'beforefieldinit'.
		static AllElementsContentValidator()
		{
			Il2CppClassPointerStore<AllElementsContentValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "AllElementsContentValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AllElementsContentValidator>.NativeClassPtr);
			AllElementsContentValidator.NativeFieldInfoPtr_elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllElementsContentValidator>.NativeClassPtr, "elements");
			AllElementsContentValidator.NativeFieldInfoPtr_particles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllElementsContentValidator>.NativeClassPtr, "particles");
			AllElementsContentValidator.NativeFieldInfoPtr_isRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllElementsContentValidator>.NativeClassPtr, "isRequired");
			AllElementsContentValidator.NativeFieldInfoPtr_countRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllElementsContentValidator>.NativeClassPtr, "countRequired");
			AllElementsContentValidator.NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaContentType_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllElementsContentValidator>.NativeClassPtr, 100667237);
			AllElementsContentValidator.NativeMethodInfoPtr_AddElement_Public_Boolean_XmlQualifiedName_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllElementsContentValidator>.NativeClassPtr, 100667238);
			AllElementsContentValidator.NativeMethodInfoPtr_get_IsEmptiable_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllElementsContentValidator>.NativeClassPtr, 100667239);
			AllElementsContentValidator.NativeMethodInfoPtr_InitValidation_Public_Virtual_Void_ValidationState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllElementsContentValidator>.NativeClassPtr, 100667240);
			AllElementsContentValidator.NativeMethodInfoPtr_ValidateElement_Public_Virtual_Object_XmlQualifiedName_ValidationState_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllElementsContentValidator>.NativeClassPtr, 100667241);
			AllElementsContentValidator.NativeMethodInfoPtr_CompleteValidation_Public_Virtual_Boolean_ValidationState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllElementsContentValidator>.NativeClassPtr, 100667242);
			AllElementsContentValidator.NativeMethodInfoPtr_ExpectedElements_Public_Virtual_ArrayList_ValidationState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllElementsContentValidator>.NativeClassPtr, 100667243);
			AllElementsContentValidator.NativeMethodInfoPtr_ExpectedParticles_Public_Virtual_ArrayList_ValidationState_Boolean_XmlSchemaSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllElementsContentValidator>.NativeClassPtr, 100667244);
		}

		// Token: 0x060019AA RID: 6570 RVA: 0x000833A4 File Offset: 0x000815A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 393130, RefRangeEnd = 393132, XrefRangeStart = 393112, XrefRangeEnd = 393130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AllElementsContentValidator(XmlSchemaContentType contentType, int size, bool isEmptiable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AllElementsContentValidator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref contentType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isEmptiable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllElementsContentValidator.NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaContentType_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019AB RID: 6571 RVA: 0x00083408 File Offset: 0x00081608
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 393138, RefRangeEnd = 393140, XrefRangeStart = 393132, XrefRangeEnd = 393138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddElement(XmlQualifiedName name, Object particle, bool isEmptiable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(particle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isEmptiable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllElementsContentValidator.NativeMethodInfoPtr_AddElement_Public_Boolean_XmlQualifiedName_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x060019AC RID: 6572 RVA: 0x00083478 File Offset: 0x00081678
		public unsafe override bool IsEmptiable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllElementsContentValidator.NativeMethodInfoPtr_get_IsEmptiable_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019AD RID: 6573 RVA: 0x000834B4 File Offset: 0x000816B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393140, XrefRangeEnd = 393145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitValidation(ValidationState context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllElementsContentValidator.NativeMethodInfoPtr_InitValidation_Public_Virtual_Void_ValidationState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019AE RID: 6574 RVA: 0x000834F8 File Offset: 0x000816F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393145, XrefRangeEnd = 393152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllElementsContentValidator.NativeMethodInfoPtr_ValidateElement_Public_Virtual_Object_XmlQualifiedName_ValidationState_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060019AF RID: 6575 RVA: 0x00083568 File Offset: 0x00081768
		[CallerCount(0)]
		public unsafe override bool CompleteValidation(ValidationState context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllElementsContentValidator.NativeMethodInfoPtr_CompleteValidation_Public_Virtual_Boolean_ValidationState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x000835B8 File Offset: 0x000817B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393152, XrefRangeEnd = 393180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllElementsContentValidator.NativeMethodInfoPtr_ExpectedElements_Public_Virtual_ArrayList_ValidationState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
		}

		// Token: 0x060019B1 RID: 6577 RVA: 0x00083618 File Offset: 0x00081818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393180, XrefRangeEnd = 393219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllElementsContentValidator.NativeMethodInfoPtr_ExpectedParticles_Public_Virtual_ArrayList_ValidationState_Boolean_XmlSchemaSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
		}

		// Token: 0x060019B2 RID: 6578 RVA: 0x0000AF22 File Offset: 0x00009122
		public AllElementsContentValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x060019B3 RID: 6579 RVA: 0x00083688 File Offset: 0x00081888
		// (set) Token: 0x060019B4 RID: 6580 RVA: 0x0000AF2B File Offset: 0x0000912B
		public unsafe Hashtable elements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllElementsContentValidator.NativeFieldInfoPtr_elements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllElementsContentValidator.NativeFieldInfoPtr_elements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x060019B5 RID: 6581 RVA: 0x000836B8 File Offset: 0x000818B8
		// (set) Token: 0x060019B6 RID: 6582 RVA: 0x0000AF4A File Offset: 0x0000914A
		public unsafe Il2CppReferenceArray<Object> particles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllElementsContentValidator.NativeFieldInfoPtr_particles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllElementsContentValidator.NativeFieldInfoPtr_particles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x060019B7 RID: 6583 RVA: 0x000836E8 File Offset: 0x000818E8
		// (set) Token: 0x060019B8 RID: 6584 RVA: 0x0000AF69 File Offset: 0x00009169
		public unsafe BitSet isRequired
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllElementsContentValidator.NativeFieldInfoPtr_isRequired);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BitSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllElementsContentValidator.NativeFieldInfoPtr_isRequired), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x060019B9 RID: 6585 RVA: 0x00083718 File Offset: 0x00081918
		// (set) Token: 0x060019BA RID: 6586 RVA: 0x0000AF88 File Offset: 0x00009188
		public unsafe int countRequired
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllElementsContentValidator.NativeFieldInfoPtr_countRequired);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllElementsContentValidator.NativeFieldInfoPtr_countRequired)) = value;
			}
		}

		// Token: 0x040013ED RID: 5101
		private static readonly IntPtr NativeFieldInfoPtr_elements;

		// Token: 0x040013EE RID: 5102
		private static readonly IntPtr NativeFieldInfoPtr_particles;

		// Token: 0x040013EF RID: 5103
		private static readonly IntPtr NativeFieldInfoPtr_isRequired;

		// Token: 0x040013F0 RID: 5104
		private static readonly IntPtr NativeFieldInfoPtr_countRequired;

		// Token: 0x040013F1 RID: 5105
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaContentType_Int32_Boolean_0;

		// Token: 0x040013F2 RID: 5106
		private static readonly IntPtr NativeMethodInfoPtr_AddElement_Public_Boolean_XmlQualifiedName_Object_Boolean_0;

		// Token: 0x040013F3 RID: 5107
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEmptiable_Public_Virtual_get_Boolean_0;

		// Token: 0x040013F4 RID: 5108
		private static readonly IntPtr NativeMethodInfoPtr_InitValidation_Public_Virtual_Void_ValidationState_0;

		// Token: 0x040013F5 RID: 5109
		private static readonly IntPtr NativeMethodInfoPtr_ValidateElement_Public_Virtual_Object_XmlQualifiedName_ValidationState_byref_Int32_0;

		// Token: 0x040013F6 RID: 5110
		private static readonly IntPtr NativeMethodInfoPtr_CompleteValidation_Public_Virtual_Boolean_ValidationState_0;

		// Token: 0x040013F7 RID: 5111
		private static readonly IntPtr NativeMethodInfoPtr_ExpectedElements_Public_Virtual_ArrayList_ValidationState_Boolean_0;

		// Token: 0x040013F8 RID: 5112
		private static readonly IntPtr NativeMethodInfoPtr_ExpectedParticles_Public_Virtual_ArrayList_ValidationState_Boolean_XmlSchemaSet_0;
	}
}
