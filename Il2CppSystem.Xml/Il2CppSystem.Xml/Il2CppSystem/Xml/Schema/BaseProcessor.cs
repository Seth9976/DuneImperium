using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000108 RID: 264
	public class BaseProcessor : Object
	{
		// Token: 0x060017A6 RID: 6054 RVA: 0x0007B418 File Offset: 0x00079618
		// Note: this type is marked as 'beforefieldinit'.
		static BaseProcessor()
		{
			Il2CppClassPointerStore<BaseProcessor>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "BaseProcessor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseProcessor>.NativeClassPtr);
			BaseProcessor.NativeFieldInfoPtr_nameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseProcessor>.NativeClassPtr, "nameTable");
			BaseProcessor.NativeFieldInfoPtr_schemaNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseProcessor>.NativeClassPtr, "schemaNames");
			BaseProcessor.NativeFieldInfoPtr_eventHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseProcessor>.NativeClassPtr, "eventHandler");
			BaseProcessor.NativeFieldInfoPtr_compilationSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseProcessor>.NativeClassPtr, "compilationSettings");
			BaseProcessor.NativeFieldInfoPtr_errorCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseProcessor>.NativeClassPtr, "errorCount");
			BaseProcessor.NativeFieldInfoPtr_NsXml = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseProcessor>.NativeClassPtr, "NsXml");
			BaseProcessor.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_SchemaNames_ValidationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseProcessor>.NativeClassPtr, 100666994);
			BaseProcessor.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_SchemaNames_ValidationEventHandler_XmlSchemaCompilationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseProcessor>.NativeClassPtr, 100666995);
			BaseProcessor.NativeMethodInfoPtr_get_NameTable_Protected_get_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseProcessor>.NativeClassPtr, 100666996);
			BaseProcessor.NativeMethodInfoPtr_get_SchemaNames_Protected_get_SchemaNames_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseProcessor>.NativeClassPtr, 100666997);
			BaseProcessor.NativeMethodInfoPtr_get_EventHandler_Protected_get_ValidationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseProcessor>.NativeClassPtr, 100666998);
			BaseProcessor.NativeMethodInfoPtr_get_CompilationSettings_Protected_get_XmlSchemaCompilationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseProcessor>.NativeClassPtr, 100666999);
			BaseProcessor.NativeMethodInfoPtr_get_HasErrors_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseProcessor>.NativeClassPtr, 100667000);
			BaseProcessor.NativeMethodInfoPtr_AddToTable_Protected_Void_XmlSchemaObjectTable_XmlQualifiedName_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseProcessor>.NativeClassPtr, 100667001);
			BaseProcessor.NativeMethodInfoPtr_IsValidAttributeGroupRedefine_Private_Boolean_XmlSchemaObject_XmlSchemaObject_XmlSchemaObjectTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseProcessor>.NativeClassPtr, 100667002);
			BaseProcessor.NativeMethodInfoPtr_IsValidGroupRedefine_Private_Boolean_XmlSchemaObject_XmlSchemaObject_XmlSchemaObjectTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseProcessor>.NativeClassPtr, 100667003);
			BaseProcessor.NativeMethodInfoPtr_IsValidTypeRedefine_Private_Boolean_XmlSchemaObject_XmlSchemaObject_XmlSchemaObjectTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseProcessor>.NativeClassPtr, 100667004);
			BaseProcessor.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseProcessor>.NativeClassPtr, 100667005);
			BaseProcessor.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_String_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseProcessor>.NativeClassPtr, 100667006);
			BaseProcessor.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_String_String_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseProcessor>.NativeClassPtr, 100667007);
			BaseProcessor.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_Il2CppStringArray_Exception_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseProcessor>.NativeClassPtr, 100667008);
			BaseProcessor.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_String_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseProcessor>.NativeClassPtr, 100667009);
			BaseProcessor.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_XmlSchemaObject_XmlSeverityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseProcessor>.NativeClassPtr, 100667010);
			BaseProcessor.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_XmlSchemaException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseProcessor>.NativeClassPtr, 100667011);
			BaseProcessor.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_String_XmlSchemaObject_XmlSeverityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseProcessor>.NativeClassPtr, 100667012);
			BaseProcessor.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_XmlSchemaException_XmlSeverityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseProcessor>.NativeClassPtr, 100667013);
			BaseProcessor.NativeMethodInfoPtr_SendValidationEventNoThrow_Protected_Void_XmlSchemaException_XmlSeverityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseProcessor>.NativeClassPtr, 100667014);
		}

		// Token: 0x060017A7 RID: 6055 RVA: 0x0007B664 File Offset: 0x00079864
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 390865, RefRangeEnd = 390867, XrefRangeStart = 390852, XrefRangeEnd = 390865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseProcessor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseProcessor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaNames);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventHandler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseProcessor.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_SchemaNames_ValidationEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017A8 RID: 6056 RVA: 0x0007B6D4 File Offset: 0x000798D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 390876, RefRangeEnd = 390878, XrefRangeStart = 390867, XrefRangeEnd = 390876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseProcessor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseProcessor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaNames);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventHandler);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(compilationSettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseProcessor.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_SchemaNames_ValidationEventHandler_XmlSchemaCompilationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x060017A9 RID: 6057 RVA: 0x0007B758 File Offset: 0x00079958
		public unsafe XmlNameTable NameTable
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseProcessor.NativeMethodInfoPtr_get_NameTable_Protected_get_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr3) : null;
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x060017AA RID: 6058 RVA: 0x0007B798 File Offset: 0x00079998
		public unsafe SchemaNames SchemaNames
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 390883, RefRangeEnd = 390885, XrefRangeStart = 390878, XrefRangeEnd = 390883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseProcessor.NativeMethodInfoPtr_get_SchemaNames_Protected_get_SchemaNames_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaNames>(intPtr3) : null;
			}
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x060017AB RID: 6059 RVA: 0x0007B7D8 File Offset: 0x000799D8
		public unsafe ValidationEventHandler EventHandler
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseProcessor.NativeMethodInfoPtr_get_EventHandler_Protected_get_ValidationEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ValidationEventHandler>(intPtr3) : null;
			}
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x060017AC RID: 6060 RVA: 0x0007B818 File Offset: 0x00079A18
		public unsafe XmlSchemaCompilationSettings CompilationSettings
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseProcessor.NativeMethodInfoPtr_get_CompilationSettings_Protected_get_XmlSchemaCompilationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaCompilationSettings>(intPtr3) : null;
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x060017AD RID: 6061 RVA: 0x0007B858 File Offset: 0x00079A58
		public unsafe bool HasErrors
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 390885, RefRangeEnd = 390894, XrefRangeStart = 390885, XrefRangeEnd = 390885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseProcessor.NativeMethodInfoPtr_get_HasErrors_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017AE RID: 6062 RVA: 0x0007B894 File Offset: 0x00079A94
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 390923, RefRangeEnd = 390960, XrefRangeStart = 390894, XrefRangeEnd = 390923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(qname);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseProcessor.NativeMethodInfoPtr_AddToTable_Protected_Void_XmlSchemaObjectTable_XmlQualifiedName_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017AF RID: 6063 RVA: 0x0007B8FC File Offset: 0x00079AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390960, XrefRangeEnd = 390965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValidAttributeGroupRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(existingObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(table);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseProcessor.NativeMethodInfoPtr_IsValidAttributeGroupRedefine_Private_Boolean_XmlSchemaObject_XmlSchemaObject_XmlSchemaObjectTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x0007B970 File Offset: 0x00079B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390965, XrefRangeEnd = 390970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValidGroupRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(existingObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(table);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseProcessor.NativeMethodInfoPtr_IsValidGroupRedefine_Private_Boolean_XmlSchemaObject_XmlSchemaObject_XmlSchemaObjectTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017B1 RID: 6065 RVA: 0x0007B9E4 File Offset: 0x00079BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390970, XrefRangeEnd = 390975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValidTypeRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(existingObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(table);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseProcessor.NativeMethodInfoPtr_IsValidTypeRedefine_Private_Boolean_XmlSchemaObject_XmlSchemaObject_XmlSchemaObjectTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017B2 RID: 6066 RVA: 0x0007BA58 File Offset: 0x00079C58
		[CallerCount(171)]
		[CachedScanResults(RefRangeStart = 390983, RefRangeEnd = 391154, XrefRangeStart = 390975, XrefRangeEnd = 390983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(string code, XmlSchemaObject source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseProcessor.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017B3 RID: 6067 RVA: 0x0007BAAC File Offset: 0x00079CAC
		[CallerCount(88)]
		[CachedScanResults(RefRangeStart = 391162, RefRangeEnd = 391250, XrefRangeStart = 391154, XrefRangeEnd = 391162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(string code, string msg, XmlSchemaObject source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(msg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseProcessor.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_String_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017B4 RID: 6068 RVA: 0x0007BB14 File Offset: 0x00079D14
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 391263, RefRangeEnd = 391280, XrefRangeStart = 391250, XrefRangeEnd = 391263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(string code, string msg1, string msg2, XmlSchemaObject source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(msg1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(msg2);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseProcessor.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_String_String_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017B5 RID: 6069 RVA: 0x0007BB90 File Offset: 0x00079D90
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 391288, RefRangeEnd = 391294, XrefRangeStart = 391280, XrefRangeEnd = 391288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(string code, Il2CppStringArray args, Exception innerException, XmlSchemaObject source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseProcessor.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_Il2CppStringArray_Exception_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017B6 RID: 6070 RVA: 0x0007BC0C File Offset: 0x00079E0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 391307, RefRangeEnd = 391308, XrefRangeStart = 391294, XrefRangeEnd = 391307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(string code, string msg1, string msg2, string sourceUri, int lineNumber, int linePosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(msg1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(msg2);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sourceUri);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNumber;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseProcessor.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_String_String_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017B7 RID: 6071 RVA: 0x0007BCA4 File Offset: 0x00079EA4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 391313, RefRangeEnd = 391323, XrefRangeStart = 391308, XrefRangeEnd = 391313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(string code, XmlSchemaObject source, XmlSeverityType severity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref severity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseProcessor.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_XmlSchemaObject_XmlSeverityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017B8 RID: 6072 RVA: 0x0007BD08 File Offset: 0x00079F08
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 391327, RefRangeEnd = 391337, XrefRangeStart = 391323, XrefRangeEnd = 391327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(XmlSchemaException e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseProcessor.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_XmlSchemaException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017B9 RID: 6073 RVA: 0x0007BD4C File Offset: 0x00079F4C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 391342, RefRangeEnd = 391348, XrefRangeStart = 391337, XrefRangeEnd = 391342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(string code, string msg, XmlSchemaObject source, XmlSeverityType severity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(msg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref severity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseProcessor.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_String_XmlSchemaObject_XmlSeverityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x0007BDC0 File Offset: 0x00079FC0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 391353, RefRangeEnd = 391357, XrefRangeStart = 391348, XrefRangeEnd = 391353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref severity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseProcessor.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_XmlSchemaException_XmlSeverityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017BB RID: 6075 RVA: 0x0007BE10 File Offset: 0x0007A010
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 391361, RefRangeEnd = 391362, XrefRangeStart = 391357, XrefRangeEnd = 391361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEventNoThrow(XmlSchemaException e, XmlSeverityType severity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref severity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseProcessor.NativeMethodInfoPtr_SendValidationEventNoThrow_Protected_Void_XmlSchemaException_XmlSeverityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x0000A194 File Offset: 0x00008394
		public BaseProcessor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x060017BD RID: 6077 RVA: 0x0007BE60 File Offset: 0x0007A060
		// (set) Token: 0x060017BE RID: 6078 RVA: 0x0000A19D File Offset: 0x0000839D
		public unsafe XmlNameTable nameTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseProcessor.NativeFieldInfoPtr_nameTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseProcessor.NativeFieldInfoPtr_nameTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x060017BF RID: 6079 RVA: 0x0007BE90 File Offset: 0x0007A090
		// (set) Token: 0x060017C0 RID: 6080 RVA: 0x0000A1BC File Offset: 0x000083BC
		public unsafe SchemaNames schemaNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseProcessor.NativeFieldInfoPtr_schemaNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaNames>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseProcessor.NativeFieldInfoPtr_schemaNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x060017C1 RID: 6081 RVA: 0x0007BEC0 File Offset: 0x0007A0C0
		// (set) Token: 0x060017C2 RID: 6082 RVA: 0x0000A1DB File Offset: 0x000083DB
		public unsafe ValidationEventHandler eventHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseProcessor.NativeFieldInfoPtr_eventHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidationEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseProcessor.NativeFieldInfoPtr_eventHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x060017C3 RID: 6083 RVA: 0x0007BEF0 File Offset: 0x0007A0F0
		// (set) Token: 0x060017C4 RID: 6084 RVA: 0x0000A1FA File Offset: 0x000083FA
		public unsafe XmlSchemaCompilationSettings compilationSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseProcessor.NativeFieldInfoPtr_compilationSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaCompilationSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseProcessor.NativeFieldInfoPtr_compilationSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x060017C5 RID: 6085 RVA: 0x0007BF20 File Offset: 0x0007A120
		// (set) Token: 0x060017C6 RID: 6086 RVA: 0x0000A219 File Offset: 0x00008419
		public unsafe int errorCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseProcessor.NativeFieldInfoPtr_errorCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseProcessor.NativeFieldInfoPtr_errorCount)) = value;
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x060017C7 RID: 6087 RVA: 0x0007BF48 File Offset: 0x0007A148
		// (set) Token: 0x060017C8 RID: 6088 RVA: 0x0000A234 File Offset: 0x00008434
		public unsafe string NsXml
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseProcessor.NativeFieldInfoPtr_NsXml);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseProcessor.NativeFieldInfoPtr_NsXml), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001296 RID: 4758
		private static readonly IntPtr NativeFieldInfoPtr_nameTable;

		// Token: 0x04001297 RID: 4759
		private static readonly IntPtr NativeFieldInfoPtr_schemaNames;

		// Token: 0x04001298 RID: 4760
		private static readonly IntPtr NativeFieldInfoPtr_eventHandler;

		// Token: 0x04001299 RID: 4761
		private static readonly IntPtr NativeFieldInfoPtr_compilationSettings;

		// Token: 0x0400129A RID: 4762
		private static readonly IntPtr NativeFieldInfoPtr_errorCount;

		// Token: 0x0400129B RID: 4763
		private static readonly IntPtr NativeFieldInfoPtr_NsXml;

		// Token: 0x0400129C RID: 4764
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_SchemaNames_ValidationEventHandler_0;

		// Token: 0x0400129D RID: 4765
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_SchemaNames_ValidationEventHandler_XmlSchemaCompilationSettings_0;

		// Token: 0x0400129E RID: 4766
		private static readonly IntPtr NativeMethodInfoPtr_get_NameTable_Protected_get_XmlNameTable_0;

		// Token: 0x0400129F RID: 4767
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaNames_Protected_get_SchemaNames_0;

		// Token: 0x040012A0 RID: 4768
		private static readonly IntPtr NativeMethodInfoPtr_get_EventHandler_Protected_get_ValidationEventHandler_0;

		// Token: 0x040012A1 RID: 4769
		private static readonly IntPtr NativeMethodInfoPtr_get_CompilationSettings_Protected_get_XmlSchemaCompilationSettings_0;

		// Token: 0x040012A2 RID: 4770
		private static readonly IntPtr NativeMethodInfoPtr_get_HasErrors_Protected_get_Boolean_0;

		// Token: 0x040012A3 RID: 4771
		private static readonly IntPtr NativeMethodInfoPtr_AddToTable_Protected_Void_XmlSchemaObjectTable_XmlQualifiedName_XmlSchemaObject_0;

		// Token: 0x040012A4 RID: 4772
		private static readonly IntPtr NativeMethodInfoPtr_IsValidAttributeGroupRedefine_Private_Boolean_XmlSchemaObject_XmlSchemaObject_XmlSchemaObjectTable_0;

		// Token: 0x040012A5 RID: 4773
		private static readonly IntPtr NativeMethodInfoPtr_IsValidGroupRedefine_Private_Boolean_XmlSchemaObject_XmlSchemaObject_XmlSchemaObjectTable_0;

		// Token: 0x040012A6 RID: 4774
		private static readonly IntPtr NativeMethodInfoPtr_IsValidTypeRedefine_Private_Boolean_XmlSchemaObject_XmlSchemaObject_XmlSchemaObjectTable_0;

		// Token: 0x040012A7 RID: 4775
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_XmlSchemaObject_0;

		// Token: 0x040012A8 RID: 4776
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_String_XmlSchemaObject_0;

		// Token: 0x040012A9 RID: 4777
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_String_String_XmlSchemaObject_0;

		// Token: 0x040012AA RID: 4778
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_Il2CppStringArray_Exception_XmlSchemaObject_0;

		// Token: 0x040012AB RID: 4779
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_String_String_String_Int32_Int32_0;

		// Token: 0x040012AC RID: 4780
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_XmlSchemaObject_XmlSeverityType_0;

		// Token: 0x040012AD RID: 4781
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Protected_Void_XmlSchemaException_0;

		// Token: 0x040012AE RID: 4782
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_String_XmlSchemaObject_XmlSeverityType_0;

		// Token: 0x040012AF RID: 4783
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Protected_Void_XmlSchemaException_XmlSeverityType_0;

		// Token: 0x040012B0 RID: 4784
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEventNoThrow_Protected_Void_XmlSchemaException_XmlSeverityType_0;
	}
}
