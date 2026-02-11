using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000121 RID: 289
	public class ContentValidator : Object
	{
		// Token: 0x06001926 RID: 6438 RVA: 0x00081160 File Offset: 0x0007F360
		// Note: this type is marked as 'beforefieldinit'.
		static ContentValidator()
		{
			Il2CppClassPointerStore<ContentValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "ContentValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr);
			ContentValidator.NativeFieldInfoPtr_contentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, "contentType");
			ContentValidator.NativeFieldInfoPtr_isOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, "isOpen");
			ContentValidator.NativeFieldInfoPtr_isEmptiable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, "isEmptiable");
			ContentValidator.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, "Empty");
			ContentValidator.NativeFieldInfoPtr_TextOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, "TextOnly");
			ContentValidator.NativeFieldInfoPtr_Mixed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, "Mixed");
			ContentValidator.NativeFieldInfoPtr_Any = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, "Any");
			ContentValidator.NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaContentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, 100667178);
			ContentValidator.NativeMethodInfoPtr__ctor_Protected_Void_XmlSchemaContentType_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, 100667179);
			ContentValidator.NativeMethodInfoPtr_get_ContentType_Public_get_XmlSchemaContentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, 100667180);
			ContentValidator.NativeMethodInfoPtr_get_PreserveWhitespace_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, 100667181);
			ContentValidator.NativeMethodInfoPtr_get_IsEmptiable_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, 100667182);
			ContentValidator.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, 100667183);
			ContentValidator.NativeMethodInfoPtr_set_IsOpen_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, 100667184);
			ContentValidator.NativeMethodInfoPtr_InitValidation_Public_Virtual_New_Void_ValidationState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, 100667185);
			ContentValidator.NativeMethodInfoPtr_ValidateElement_Public_Virtual_New_Object_XmlQualifiedName_ValidationState_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, 100667186);
			ContentValidator.NativeMethodInfoPtr_CompleteValidation_Public_Virtual_New_Boolean_ValidationState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, 100667187);
			ContentValidator.NativeMethodInfoPtr_ExpectedElements_Public_Virtual_New_ArrayList_ValidationState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, 100667188);
			ContentValidator.NativeMethodInfoPtr_ExpectedParticles_Public_Virtual_New_ArrayList_ValidationState_Boolean_XmlSchemaSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, 100667189);
			ContentValidator.NativeMethodInfoPtr_AddParticleToExpected_Public_Static_Void_XmlSchemaParticle_XmlSchemaSet_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, 100667190);
			ContentValidator.NativeMethodInfoPtr_AddParticleToExpected_Public_Static_Void_XmlSchemaParticle_XmlSchemaSet_ArrayList_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, 100667191);
		}

		// Token: 0x06001927 RID: 6439 RVA: 0x00081334 File Offset: 0x0007F534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392436, XrefRangeEnd = 392437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContentValidator(XmlSchemaContentType contentType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref contentType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentValidator.NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaContentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001928 RID: 6440 RVA: 0x0008137C File Offset: 0x0007F57C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 392438, RefRangeEnd = 392441, XrefRangeStart = 392437, XrefRangeEnd = 392438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContentValidator(XmlSchemaContentType contentType, bool isOpen, bool isEmptiable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref contentType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isOpen;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isEmptiable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentValidator.NativeMethodInfoPtr__ctor_Protected_Void_XmlSchemaContentType_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x06001929 RID: 6441 RVA: 0x000813E0 File Offset: 0x0007F5E0
		public unsafe XmlSchemaContentType ContentType
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentValidator.NativeMethodInfoPtr_get_ContentType_Public_get_XmlSchemaContentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x0600192A RID: 6442 RVA: 0x0008141C File Offset: 0x0007F61C
		public unsafe bool PreserveWhitespace
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 392441, RefRangeEnd = 392444, XrefRangeStart = 392441, XrefRangeEnd = 392441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentValidator.NativeMethodInfoPtr_get_PreserveWhitespace_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x0600192B RID: 6443 RVA: 0x00081458 File Offset: 0x0007F658
		public unsafe virtual bool IsEmptiable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContentValidator.NativeMethodInfoPtr_get_IsEmptiable_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x0600192C RID: 6444 RVA: 0x000814A0 File Offset: 0x0007F6A0
		// (set) Token: 0x0600192D RID: 6445 RVA: 0x000814DC File Offset: 0x0007F6DC
		public unsafe bool IsOpen
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 392444, RefRangeEnd = 392449, XrefRangeStart = 392444, XrefRangeEnd = 392444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentValidator.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentValidator.NativeMethodInfoPtr_set_IsOpen_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600192E RID: 6446 RVA: 0x0008151C File Offset: 0x0007F71C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitValidation(ValidationState context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContentValidator.NativeMethodInfoPtr_InitValidation_Public_Virtual_New_Void_ValidationState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600192F RID: 6447 RVA: 0x0008156C File Offset: 0x0007F76C
		[CallerCount(0)]
		public unsafe virtual Object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContentValidator.NativeMethodInfoPtr_ValidateElement_Public_Virtual_New_Object_XmlQualifiedName_ValidationState_byref_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001930 RID: 6448 RVA: 0x000815E8 File Offset: 0x0007F7E8
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CompleteValidation(ValidationState context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContentValidator.NativeMethodInfoPtr_CompleteValidation_Public_Virtual_New_Boolean_ValidationState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001931 RID: 6449 RVA: 0x00081640 File Offset: 0x0007F840
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContentValidator.NativeMethodInfoPtr_ExpectedElements_Public_Virtual_New_ArrayList_ValidationState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
		}

		// Token: 0x06001932 RID: 6450 RVA: 0x000816AC File Offset: 0x0007F8AC
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContentValidator.NativeMethodInfoPtr_ExpectedParticles_Public_Virtual_New_ArrayList_ValidationState_Boolean_XmlSchemaSet_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x00081728 File Offset: 0x0007F928
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 392453, RefRangeEnd = 392457, XrefRangeStart = 392449, XrefRangeEnd = 392453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddParticleToExpected(XmlSchemaParticle p, XmlSchemaSet schemaSet, ArrayList particles)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaSet);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(particles);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentValidator.NativeMethodInfoPtr_AddParticleToExpected_Public_Static_Void_XmlSchemaParticle_XmlSchemaSet_ArrayList_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001934 RID: 6452 RVA: 0x00081784 File Offset: 0x0007F984
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 392467, RefRangeEnd = 392468, XrefRangeStart = 392457, XrefRangeEnd = 392467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddParticleToExpected(XmlSchemaParticle p, XmlSchemaSet schemaSet, ArrayList particles, bool global)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaSet);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(particles);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref global;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentValidator.NativeMethodInfoPtr_AddParticleToExpected_Public_Static_Void_XmlSchemaParticle_XmlSchemaSet_ArrayList_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001935 RID: 6453 RVA: 0x0000AB90 File Offset: 0x00008D90
		public ContentValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x06001936 RID: 6454 RVA: 0x000817EC File Offset: 0x0007F9EC
		// (set) Token: 0x06001937 RID: 6455 RVA: 0x0000AB99 File Offset: 0x00008D99
		public unsafe XmlSchemaContentType contentType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentValidator.NativeFieldInfoPtr_contentType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentValidator.NativeFieldInfoPtr_contentType)) = value;
			}
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x06001938 RID: 6456 RVA: 0x00081814 File Offset: 0x0007FA14
		// (set) Token: 0x06001939 RID: 6457 RVA: 0x0000ABB4 File Offset: 0x00008DB4
		public unsafe bool isOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentValidator.NativeFieldInfoPtr_isOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentValidator.NativeFieldInfoPtr_isOpen)) = value;
			}
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x0600193A RID: 6458 RVA: 0x0008183C File Offset: 0x0007FA3C
		// (set) Token: 0x0600193B RID: 6459 RVA: 0x0000ABCF File Offset: 0x00008DCF
		public unsafe bool isEmptiable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentValidator.NativeFieldInfoPtr_isEmptiable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentValidator.NativeFieldInfoPtr_isEmptiable)) = value;
			}
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x0600193C RID: 6460 RVA: 0x00081864 File Offset: 0x0007FA64
		// (set) Token: 0x0600193D RID: 6461 RVA: 0x0000ABEA File Offset: 0x00008DEA
		public unsafe static ContentValidator Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ContentValidator.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContentValidator>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ContentValidator.NativeFieldInfoPtr_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x0600193E RID: 6462 RVA: 0x0008188C File Offset: 0x0007FA8C
		// (set) Token: 0x0600193F RID: 6463 RVA: 0x0000ABFC File Offset: 0x00008DFC
		public unsafe static ContentValidator TextOnly
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ContentValidator.NativeFieldInfoPtr_TextOnly, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContentValidator>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ContentValidator.NativeFieldInfoPtr_TextOnly, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x06001940 RID: 6464 RVA: 0x000818B4 File Offset: 0x0007FAB4
		// (set) Token: 0x06001941 RID: 6465 RVA: 0x0000AC0E File Offset: 0x00008E0E
		public unsafe static ContentValidator Mixed
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ContentValidator.NativeFieldInfoPtr_Mixed, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContentValidator>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ContentValidator.NativeFieldInfoPtr_Mixed, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x06001942 RID: 6466 RVA: 0x000818DC File Offset: 0x0007FADC
		// (set) Token: 0x06001943 RID: 6467 RVA: 0x0000AC20 File Offset: 0x00008E20
		public unsafe static ContentValidator Any
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ContentValidator.NativeFieldInfoPtr_Any, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContentValidator>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ContentValidator.NativeFieldInfoPtr_Any, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001395 RID: 5013
		private static readonly IntPtr NativeFieldInfoPtr_contentType;

		// Token: 0x04001396 RID: 5014
		private static readonly IntPtr NativeFieldInfoPtr_isOpen;

		// Token: 0x04001397 RID: 5015
		private static readonly IntPtr NativeFieldInfoPtr_isEmptiable;

		// Token: 0x04001398 RID: 5016
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x04001399 RID: 5017
		private static readonly IntPtr NativeFieldInfoPtr_TextOnly;

		// Token: 0x0400139A RID: 5018
		private static readonly IntPtr NativeFieldInfoPtr_Mixed;

		// Token: 0x0400139B RID: 5019
		private static readonly IntPtr NativeFieldInfoPtr_Any;

		// Token: 0x0400139C RID: 5020
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaContentType_0;

		// Token: 0x0400139D RID: 5021
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_XmlSchemaContentType_Boolean_Boolean_0;

		// Token: 0x0400139E RID: 5022
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentType_Public_get_XmlSchemaContentType_0;

		// Token: 0x0400139F RID: 5023
		private static readonly IntPtr NativeMethodInfoPtr_get_PreserveWhitespace_Public_get_Boolean_0;

		// Token: 0x040013A0 RID: 5024
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEmptiable_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040013A1 RID: 5025
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x040013A2 RID: 5026
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Public_set_Void_Boolean_0;

		// Token: 0x040013A3 RID: 5027
		private static readonly IntPtr NativeMethodInfoPtr_InitValidation_Public_Virtual_New_Void_ValidationState_0;

		// Token: 0x040013A4 RID: 5028
		private static readonly IntPtr NativeMethodInfoPtr_ValidateElement_Public_Virtual_New_Object_XmlQualifiedName_ValidationState_byref_Int32_0;

		// Token: 0x040013A5 RID: 5029
		private static readonly IntPtr NativeMethodInfoPtr_CompleteValidation_Public_Virtual_New_Boolean_ValidationState_0;

		// Token: 0x040013A6 RID: 5030
		private static readonly IntPtr NativeMethodInfoPtr_ExpectedElements_Public_Virtual_New_ArrayList_ValidationState_Boolean_0;

		// Token: 0x040013A7 RID: 5031
		private static readonly IntPtr NativeMethodInfoPtr_ExpectedParticles_Public_Virtual_New_ArrayList_ValidationState_Boolean_XmlSchemaSet_0;

		// Token: 0x040013A8 RID: 5032
		private static readonly IntPtr NativeMethodInfoPtr_AddParticleToExpected_Public_Static_Void_XmlSchemaParticle_XmlSchemaSet_ArrayList_0;

		// Token: 0x040013A9 RID: 5033
		private static readonly IntPtr NativeMethodInfoPtr_AddParticleToExpected_Public_Static_Void_XmlSchemaParticle_XmlSchemaSet_ArrayList_Boolean_0;
	}
}
