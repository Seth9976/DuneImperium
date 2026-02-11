using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200016C RID: 364
	public sealed class DtdValidator : BaseValidator
	{
		// Token: 0x06001D05 RID: 7429 RVA: 0x00090008 File Offset: 0x0008E208
		// Note: this type is marked as 'beforefieldinit'.
		static DtdValidator()
		{
			Il2CppClassPointerStore<DtdValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "DtdValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DtdValidator>.NativeClassPtr);
			DtdValidator.NativeFieldInfoPtr_namespaceManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdValidator>.NativeClassPtr, "namespaceManager");
			DtdValidator.NativeFieldInfoPtr_validationStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdValidator>.NativeClassPtr, "validationStack");
			DtdValidator.NativeFieldInfoPtr_attPresence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdValidator>.NativeClassPtr, "attPresence");
			DtdValidator.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdValidator>.NativeClassPtr, "name");
			DtdValidator.NativeFieldInfoPtr_IDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdValidator>.NativeClassPtr, "IDs");
			DtdValidator.NativeFieldInfoPtr_idRefListHead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdValidator>.NativeClassPtr, "idRefListHead");
			DtdValidator.NativeFieldInfoPtr_processIdentityConstraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdValidator>.NativeClassPtr, "processIdentityConstraints");
			DtdValidator.NativeMethodInfoPtr__ctor_Internal_Void_XmlValidatingReaderImpl_IValidationEventHandling_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdValidator>.NativeClassPtr, 100667648);
			DtdValidator.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdValidator>.NativeClassPtr, 100667649);
			DtdValidator.NativeMethodInfoPtr_Validate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdValidator>.NativeClassPtr, 100667650);
			DtdValidator.NativeMethodInfoPtr_MeetsStandAloneConstraint_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdValidator>.NativeClassPtr, 100667651);
			DtdValidator.NativeMethodInfoPtr_ValidatePIComment_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdValidator>.NativeClassPtr, 100667652);
			DtdValidator.NativeMethodInfoPtr_ValidateElement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdValidator>.NativeClassPtr, 100667653);
			DtdValidator.NativeMethodInfoPtr_ValidateChildElement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdValidator>.NativeClassPtr, 100667654);
			DtdValidator.NativeMethodInfoPtr_ValidateStartElement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdValidator>.NativeClassPtr, 100667655);
			DtdValidator.NativeMethodInfoPtr_ValidateEndStartElement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdValidator>.NativeClassPtr, 100667656);
			DtdValidator.NativeMethodInfoPtr_ProcessElement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdValidator>.NativeClassPtr, 100667657);
			DtdValidator.NativeMethodInfoPtr_CompleteValidation_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdValidator>.NativeClassPtr, 100667658);
			DtdValidator.NativeMethodInfoPtr_ValidateEndElement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdValidator>.NativeClassPtr, 100667659);
			DtdValidator.NativeMethodInfoPtr_get_PreserveWhitespace_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdValidator>.NativeClassPtr, 100667660);
			DtdValidator.NativeMethodInfoPtr_ProcessTokenizedType_Private_Void_XmlTokenizedType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdValidator>.NativeClassPtr, 100667661);
			DtdValidator.NativeMethodInfoPtr_CheckValue_Private_Void_String_SchemaAttDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdValidator>.NativeClassPtr, 100667662);
			DtdValidator.NativeMethodInfoPtr_AddID_Internal_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdValidator>.NativeClassPtr, 100667663);
			DtdValidator.NativeMethodInfoPtr_FindId_Public_Virtual_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdValidator>.NativeClassPtr, 100667664);
			DtdValidator.NativeMethodInfoPtr_GenEntity_Private_Boolean_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdValidator>.NativeClassPtr, 100667665);
			DtdValidator.NativeMethodInfoPtr_GetEntity_Private_SchemaEntity_XmlQualifiedName_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdValidator>.NativeClassPtr, 100667666);
			DtdValidator.NativeMethodInfoPtr_CheckForwardRefs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdValidator>.NativeClassPtr, 100667667);
			DtdValidator.NativeMethodInfoPtr_Push_Private_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdValidator>.NativeClassPtr, 100667668);
			DtdValidator.NativeMethodInfoPtr_Pop_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdValidator>.NativeClassPtr, 100667669);
			DtdValidator.NativeMethodInfoPtr_SetDefaultTypedValue_Public_Static_Void_SchemaAttDef_IDtdParserAdapter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdValidator>.NativeClassPtr, 100667670);
			DtdValidator.NativeMethodInfoPtr_CheckDefaultValue_Public_Static_Void_SchemaAttDef_SchemaInfo_IValidationEventHandling_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdValidator>.NativeClassPtr, 100667671);
		}

		// Token: 0x06001D06 RID: 7430 RVA: 0x000902A4 File Offset: 0x0008E4A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 395138, RefRangeEnd = 395139, XrefRangeStart = 395106, XrefRangeEnd = 395138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdValidator(XmlValidatingReaderImpl reader, IValidationEventHandling eventHandling, bool processIdentityConstraints)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DtdValidator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventHandling);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref processIdentityConstraints;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdValidator.NativeMethodInfoPtr__ctor_Internal_Void_XmlValidatingReaderImpl_IValidationEventHandling_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D07 RID: 7431 RVA: 0x00090310 File Offset: 0x0008E510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395139, XrefRangeEnd = 395165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdValidator.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D08 RID: 7432 RVA: 0x00090344 File Offset: 0x0008E544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395165, XrefRangeEnd = 395169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Validate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdValidator.NativeMethodInfoPtr_Validate_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D09 RID: 7433 RVA: 0x00090378 File Offset: 0x0008E578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395169, XrefRangeEnd = 395173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MeetsStandAloneConstraint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdValidator.NativeMethodInfoPtr_MeetsStandAloneConstraint_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D0A RID: 7434 RVA: 0x000903B4 File Offset: 0x0008E5B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395173, XrefRangeEnd = 395180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidatePIComment()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdValidator.NativeMethodInfoPtr_ValidatePIComment_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D0B RID: 7435 RVA: 0x000903E8 File Offset: 0x0008E5E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395180, XrefRangeEnd = 395201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdValidator.NativeMethodInfoPtr_ValidateElement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D0C RID: 7436 RVA: 0x0009041C File Offset: 0x0008E61C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395201, XrefRangeEnd = 395206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateChildElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdValidator.NativeMethodInfoPtr_ValidateChildElement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D0D RID: 7437 RVA: 0x00090450 File Offset: 0x0008E650
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 395223, RefRangeEnd = 395224, XrefRangeStart = 395206, XrefRangeEnd = 395223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateStartElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdValidator.NativeMethodInfoPtr_ValidateStartElement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D0E RID: 7438 RVA: 0x00090484 File Offset: 0x0008E684
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 395233, RefRangeEnd = 395234, XrefRangeStart = 395224, XrefRangeEnd = 395233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateEndStartElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdValidator.NativeMethodInfoPtr_ValidateEndStartElement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D0F RID: 7439 RVA: 0x000904B8 File Offset: 0x0008E6B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395234, XrefRangeEnd = 395248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdValidator.NativeMethodInfoPtr_ProcessElement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D10 RID: 7440 RVA: 0x000904EC File Offset: 0x0008E6EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395248, XrefRangeEnd = 395259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CompleteValidation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdValidator.NativeMethodInfoPtr_CompleteValidation_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D11 RID: 7441 RVA: 0x00090520 File Offset: 0x0008E720
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 395272, RefRangeEnd = 395273, XrefRangeStart = 395259, XrefRangeEnd = 395272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateEndElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdValidator.NativeMethodInfoPtr_ValidateEndElement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x06001D12 RID: 7442 RVA: 0x00090554 File Offset: 0x0008E754
		public unsafe override bool PreserveWhitespace
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395273, XrefRangeEnd = 395274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdValidator.NativeMethodInfoPtr_get_PreserveWhitespace_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D13 RID: 7443 RVA: 0x00090590 File Offset: 0x0008E790
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 395292, RefRangeEnd = 395294, XrefRangeStart = 395274, XrefRangeEnd = 395292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessTokenizedType(XmlTokenizedType ttype, string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ttype;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdValidator.NativeMethodInfoPtr_ProcessTokenizedType_Private_Void_XmlTokenizedType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D14 RID: 7444 RVA: 0x000905E0 File Offset: 0x0008E7E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 395338, RefRangeEnd = 395340, XrefRangeStart = 395294, XrefRangeEnd = 395338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckValue(string value, SchemaAttDef attdef)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attdef);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdValidator.NativeMethodInfoPtr_CheckValue_Private_Void_String_SchemaAttDef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D15 RID: 7445 RVA: 0x00090634 File Offset: 0x0008E834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395340, XrefRangeEnd = 395346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddID(string name, Object node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(node);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdValidator.NativeMethodInfoPtr_AddID_Internal_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D16 RID: 7446 RVA: 0x00090688 File Offset: 0x0008E888
		[CallerCount(0)]
		public unsafe override Object FindId(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdValidator.NativeMethodInfoPtr_FindId_Public_Virtual_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001D17 RID: 7447 RVA: 0x000906D8 File Offset: 0x0008E8D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395346, XrefRangeEnd = 395357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GenEntity(XmlQualifiedName qname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdValidator.NativeMethodInfoPtr_GenEntity_Private_Boolean_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D18 RID: 7448 RVA: 0x00090728 File Offset: 0x0008E928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395357, XrefRangeEnd = 395363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaEntity GetEntity(XmlQualifiedName qname, bool fParameterEntity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fParameterEntity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdValidator.NativeMethodInfoPtr_GetEntity_Private_SchemaEntity_XmlQualifiedName_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaEntity>(intPtr3) : null;
		}

		// Token: 0x06001D19 RID: 7449 RVA: 0x00090788 File Offset: 0x0008E988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395363, XrefRangeEnd = 395373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckForwardRefs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdValidator.NativeMethodInfoPtr_CheckForwardRefs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D1A RID: 7450 RVA: 0x000907BC File Offset: 0x0008E9BC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 395386, RefRangeEnd = 395390, XrefRangeStart = 395373, XrefRangeEnd = 395386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Push(XmlQualifiedName elementName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdValidator.NativeMethodInfoPtr_Push_Private_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D1B RID: 7451 RVA: 0x00090800 File Offset: 0x0008EA00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 395391, RefRangeEnd = 395393, XrefRangeStart = 395390, XrefRangeEnd = 395391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdValidator.NativeMethodInfoPtr_Pop_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D1C RID: 7452 RVA: 0x0009083C File Offset: 0x0008EA3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 395416, RefRangeEnd = 395417, XrefRangeStart = 395393, XrefRangeEnd = 395416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetDefaultTypedValue(SchemaAttDef attdef, IDtdParserAdapter readerAdapter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attdef);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(readerAdapter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdValidator.NativeMethodInfoPtr_SetDefaultTypedValue_Public_Static_Void_SchemaAttDef_IDtdParserAdapter_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D1D RID: 7453 RVA: 0x00090884 File Offset: 0x0008EA84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 395446, RefRangeEnd = 395447, XrefRangeStart = 395417, XrefRangeEnd = 395446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckDefaultValue(SchemaAttDef attdef, SchemaInfo sinfo, IValidationEventHandling eventHandling, string baseUriStr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attdef);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sinfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventHandling);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseUriStr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdValidator.NativeMethodInfoPtr_CheckDefaultValue_Public_Static_Void_SchemaAttDef_SchemaInfo_IValidationEventHandling_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D1E RID: 7454 RVA: 0x0000C03A File Offset: 0x0000A23A
		public DtdValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x06001D1F RID: 7455 RVA: 0x000908F0 File Offset: 0x0008EAF0
		// (set) Token: 0x06001D20 RID: 7456 RVA: 0x0000C043 File Offset: 0x0000A243
		public unsafe static DtdValidator.NamespaceManager namespaceManager
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DtdValidator.NativeFieldInfoPtr_namespaceManager, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DtdValidator.NamespaceManager>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DtdValidator.NativeFieldInfoPtr_namespaceManager, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x06001D21 RID: 7457 RVA: 0x00090918 File Offset: 0x0008EB18
		// (set) Token: 0x06001D22 RID: 7458 RVA: 0x0000C055 File Offset: 0x0000A255
		public unsafe HWStack validationStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdValidator.NativeFieldInfoPtr_validationStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HWStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdValidator.NativeFieldInfoPtr_validationStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x06001D23 RID: 7459 RVA: 0x00090948 File Offset: 0x0008EB48
		// (set) Token: 0x06001D24 RID: 7460 RVA: 0x0000C074 File Offset: 0x0000A274
		public unsafe Hashtable attPresence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdValidator.NativeFieldInfoPtr_attPresence);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdValidator.NativeFieldInfoPtr_attPresence), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x06001D25 RID: 7461 RVA: 0x00090978 File Offset: 0x0008EB78
		// (set) Token: 0x06001D26 RID: 7462 RVA: 0x0000C093 File Offset: 0x0000A293
		public unsafe XmlQualifiedName name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdValidator.NativeFieldInfoPtr_name);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdValidator.NativeFieldInfoPtr_name), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x06001D27 RID: 7463 RVA: 0x000909A8 File Offset: 0x0008EBA8
		// (set) Token: 0x06001D28 RID: 7464 RVA: 0x0000C0B2 File Offset: 0x0000A2B2
		public unsafe Hashtable IDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdValidator.NativeFieldInfoPtr_IDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdValidator.NativeFieldInfoPtr_IDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x06001D29 RID: 7465 RVA: 0x000909D8 File Offset: 0x0008EBD8
		// (set) Token: 0x06001D2A RID: 7466 RVA: 0x0000C0D1 File Offset: 0x0000A2D1
		public unsafe IdRefNode idRefListHead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdValidator.NativeFieldInfoPtr_idRefListHead);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IdRefNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdValidator.NativeFieldInfoPtr_idRefListHead), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x06001D2B RID: 7467 RVA: 0x00090A08 File Offset: 0x0008EC08
		// (set) Token: 0x06001D2C RID: 7468 RVA: 0x0000C0F0 File Offset: 0x0000A2F0
		public unsafe bool processIdentityConstraints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdValidator.NativeFieldInfoPtr_processIdentityConstraints);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdValidator.NativeFieldInfoPtr_processIdentityConstraints)) = value;
			}
		}

		// Token: 0x0400162A RID: 5674
		private static readonly IntPtr NativeFieldInfoPtr_namespaceManager;

		// Token: 0x0400162B RID: 5675
		private static readonly IntPtr NativeFieldInfoPtr_validationStack;

		// Token: 0x0400162C RID: 5676
		private static readonly IntPtr NativeFieldInfoPtr_attPresence;

		// Token: 0x0400162D RID: 5677
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x0400162E RID: 5678
		private static readonly IntPtr NativeFieldInfoPtr_IDs;

		// Token: 0x0400162F RID: 5679
		private static readonly IntPtr NativeFieldInfoPtr_idRefListHead;

		// Token: 0x04001630 RID: 5680
		private static readonly IntPtr NativeFieldInfoPtr_processIdentityConstraints;

		// Token: 0x04001631 RID: 5681
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlValidatingReaderImpl_IValidationEventHandling_Boolean_0;

		// Token: 0x04001632 RID: 5682
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x04001633 RID: 5683
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Public_Virtual_Void_0;

		// Token: 0x04001634 RID: 5684
		private static readonly IntPtr NativeMethodInfoPtr_MeetsStandAloneConstraint_Private_Boolean_0;

		// Token: 0x04001635 RID: 5685
		private static readonly IntPtr NativeMethodInfoPtr_ValidatePIComment_Private_Void_0;

		// Token: 0x04001636 RID: 5686
		private static readonly IntPtr NativeMethodInfoPtr_ValidateElement_Private_Void_0;

		// Token: 0x04001637 RID: 5687
		private static readonly IntPtr NativeMethodInfoPtr_ValidateChildElement_Private_Void_0;

		// Token: 0x04001638 RID: 5688
		private static readonly IntPtr NativeMethodInfoPtr_ValidateStartElement_Private_Void_0;

		// Token: 0x04001639 RID: 5689
		private static readonly IntPtr NativeMethodInfoPtr_ValidateEndStartElement_Private_Void_0;

		// Token: 0x0400163A RID: 5690
		private static readonly IntPtr NativeMethodInfoPtr_ProcessElement_Private_Void_0;

		// Token: 0x0400163B RID: 5691
		private static readonly IntPtr NativeMethodInfoPtr_CompleteValidation_Public_Virtual_Void_0;

		// Token: 0x0400163C RID: 5692
		private static readonly IntPtr NativeMethodInfoPtr_ValidateEndElement_Private_Void_0;

		// Token: 0x0400163D RID: 5693
		private static readonly IntPtr NativeMethodInfoPtr_get_PreserveWhitespace_Public_Virtual_get_Boolean_0;

		// Token: 0x0400163E RID: 5694
		private static readonly IntPtr NativeMethodInfoPtr_ProcessTokenizedType_Private_Void_XmlTokenizedType_String_0;

		// Token: 0x0400163F RID: 5695
		private static readonly IntPtr NativeMethodInfoPtr_CheckValue_Private_Void_String_SchemaAttDef_0;

		// Token: 0x04001640 RID: 5696
		private static readonly IntPtr NativeMethodInfoPtr_AddID_Internal_Void_String_Object_0;

		// Token: 0x04001641 RID: 5697
		private static readonly IntPtr NativeMethodInfoPtr_FindId_Public_Virtual_Object_String_0;

		// Token: 0x04001642 RID: 5698
		private static readonly IntPtr NativeMethodInfoPtr_GenEntity_Private_Boolean_XmlQualifiedName_0;

		// Token: 0x04001643 RID: 5699
		private static readonly IntPtr NativeMethodInfoPtr_GetEntity_Private_SchemaEntity_XmlQualifiedName_Boolean_0;

		// Token: 0x04001644 RID: 5700
		private static readonly IntPtr NativeMethodInfoPtr_CheckForwardRefs_Private_Void_0;

		// Token: 0x04001645 RID: 5701
		private static readonly IntPtr NativeMethodInfoPtr_Push_Private_Void_XmlQualifiedName_0;

		// Token: 0x04001646 RID: 5702
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Private_Boolean_0;

		// Token: 0x04001647 RID: 5703
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaultTypedValue_Public_Static_Void_SchemaAttDef_IDtdParserAdapter_0;

		// Token: 0x04001648 RID: 5704
		private static readonly IntPtr NativeMethodInfoPtr_CheckDefaultValue_Public_Static_Void_SchemaAttDef_SchemaInfo_IValidationEventHandling_String_0;

		// Token: 0x02000258 RID: 600
		public class NamespaceManager : XmlNamespaceManager
		{
			// Token: 0x0600316C RID: 12652 RVA: 0x000DD010 File Offset: 0x000DB210
			// Note: this type is marked as 'beforefieldinit'.
			static NamespaceManager()
			{
				Il2CppClassPointerStore<DtdValidator.NamespaceManager>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DtdValidator>.NativeClassPtr, "NamespaceManager");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DtdValidator.NamespaceManager>.NativeClassPtr);
				DtdValidator.NamespaceManager.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdValidator.NamespaceManager>.NativeClassPtr, 100667673);
				DtdValidator.NamespaceManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdValidator.NamespaceManager>.NativeClassPtr, 100667674);
			}

			// Token: 0x0600316D RID: 12653 RVA: 0x000DD064 File Offset: 0x000DB264
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 75263, RefRangeEnd = 75264, XrefRangeStart = 75263, XrefRangeEnd = 75264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string LookupNamespace(string prefix)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DtdValidator.NamespaceManager.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600316E RID: 12654 RVA: 0x000DD0B8 File Offset: 0x000DB2B8
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NamespaceManager()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DtdValidator.NamespaceManager>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdValidator.NamespaceManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600316F RID: 12655 RVA: 0x00014EDC File Offset: 0x000130DC
			public NamespaceManager(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400263A RID: 9786
			private static readonly IntPtr NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0;

			// Token: 0x0400263B RID: 9787
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
