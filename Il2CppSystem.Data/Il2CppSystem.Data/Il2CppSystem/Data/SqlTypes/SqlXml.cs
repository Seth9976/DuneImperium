using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Reflection;
using Il2CppSystem.Xml;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Data.SqlTypes
{
	// Token: 0x020000A2 RID: 162
	[Serializable]
	public sealed class SqlXml : Object
	{
		// Token: 0x060010A9 RID: 4265 RVA: 0x0004F56C File Offset: 0x0004D76C
		// Note: this type is marked as 'beforefieldinit'.
		static SqlXml()
		{
			Il2CppClassPointerStore<SqlXml>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data.SqlTypes", "SqlXml");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SqlXml>.NativeClassPtr);
			SqlXml.NativeFieldInfoPtr_s_sqlReaderDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlXml>.NativeClassPtr, "s_sqlReaderDelegate");
			SqlXml.NativeFieldInfoPtr_s_defaultXmlReaderSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlXml>.NativeClassPtr, "s_defaultXmlReaderSettings");
			SqlXml.NativeFieldInfoPtr_s_defaultXmlReaderSettingsCloseInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlXml>.NativeClassPtr, "s_defaultXmlReaderSettingsCloseInput");
			SqlXml.NativeFieldInfoPtr_s_createSqlReaderMethodInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlXml>.NativeClassPtr, "s_createSqlReaderMethodInfo");
			SqlXml.NativeFieldInfoPtr__createSqlReaderMethodInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlXml>.NativeClassPtr, "_createSqlReaderMethodInfo");
			SqlXml.NativeFieldInfoPtr__fNotNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlXml>.NativeClassPtr, "_fNotNull");
			SqlXml.NativeFieldInfoPtr__stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlXml>.NativeClassPtr, "_stream");
			SqlXml.NativeFieldInfoPtr__firstCreateReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlXml>.NativeClassPtr, "_firstCreateReader");
			SqlXml.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlXml>.NativeClassPtr, 100665974);
			SqlXml.NativeMethodInfoPtr_CreateReader_Public_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlXml>.NativeClassPtr, 100665975);
			SqlXml.NativeMethodInfoPtr_CreateSqlXmlReader_Internal_Static_XmlReader_Stream_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlXml>.NativeClassPtr, 100665976);
			SqlXml.NativeMethodInfoPtr_CreateSqlReaderDelegate_Private_Static_Func_4_Stream_XmlReaderSettings_XmlParserContext_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlXml>.NativeClassPtr, 100665977);
			SqlXml.NativeMethodInfoPtr_get_CreateSqlReaderMethodInfo_Private_Static_get_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlXml>.NativeClassPtr, 100665978);
			SqlXml.NativeMethodInfoPtr_get_IsNull_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlXml>.NativeClassPtr, 100665979);
			SqlXml.NativeMethodInfoPtr_SetNull_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlXml>.NativeClassPtr, 100665980);
			SqlXml.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlXml>.NativeClassPtr, 100665981);
			SqlXml.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlXml>.NativeClassPtr, 100665982);
			SqlXml.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlXml>.NativeClassPtr, 100665983);
			SqlXml.NativeMethodInfoPtr_GetXsdType_Public_Static_XmlQualifiedName_XmlSchemaSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlXml>.NativeClassPtr, 100665984);
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x0004F718 File Offset: 0x0004D918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 920167, XrefRangeEnd = 920169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlXml()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SqlXml>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlXml.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x0004F754 File Offset: 0x0004D954
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 920186, RefRangeEnd = 920187, XrefRangeStart = 920169, XrefRangeEnd = 920186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlReader CreateReader()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlXml.NativeMethodInfoPtr_CreateReader_Public_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlReader>(intPtr3) : null;
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x0004F794 File Offset: 0x0004D994
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 920197, RefRangeEnd = 920198, XrefRangeStart = 920187, XrefRangeEnd = 920197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlReader CreateSqlXmlReader(Stream stream, bool closeInput = false, bool throwTargetInvocationExceptions = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref closeInput;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwTargetInvocationExceptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlXml.NativeMethodInfoPtr_CreateSqlXmlReader_Internal_Static_XmlReader_Stream_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlReader>(intPtr3) : null;
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x0004F7F4 File Offset: 0x0004D9F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 920198, XrefRangeEnd = 920210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader> CreateSqlReaderDelegate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlXml.NativeMethodInfoPtr_CreateSqlReaderDelegate_Private_Static_Func_4_Stream_XmlReaderSettings_XmlParserContext_XmlReader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader>>(intPtr3) : null;
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x060010AE RID: 4270 RVA: 0x0004F828 File Offset: 0x0004DA28
		public unsafe static MethodInfo CreateSqlReaderMethodInfo
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 920232, RefRangeEnd = 920235, XrefRangeStart = 920210, XrefRangeEnd = 920232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlXml.NativeMethodInfoPtr_get_CreateSqlReaderMethodInfo_Private_Static_get_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x060010AF RID: 4271 RVA: 0x0004F85C File Offset: 0x0004DA5C
		public unsafe bool IsNull
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 919885, RefRangeEnd = 919889, XrefRangeStart = 919885, XrefRangeEnd = 919889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlXml.NativeMethodInfoPtr_get_IsNull_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x0004F898 File Offset: 0x0004DA98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 920235, XrefRangeEnd = 920236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlXml.NativeMethodInfoPtr_SetNull_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x0004F8CC File Offset: 0x0004DACC
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchema System_Xml_Serialization_IXmlSerializable_GetSchema()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlXml.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x0004F90C File Offset: 0x0004DB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 920236, XrefRangeEnd = 920247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Xml_Serialization_IXmlSerializable_ReadXml(XmlReader r)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlXml.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x0004F950 File Offset: 0x0004DB50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 920247, XrefRangeEnd = 920296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Xml_Serialization_IXmlSerializable_WriteXml(XmlWriter writer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlXml.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010B4 RID: 4276 RVA: 0x0004F994 File Offset: 0x0004DB94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 920296, XrefRangeEnd = 920304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaSet);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlXml.NativeMethodInfoPtr_GetXsdType_Public_Static_XmlQualifiedName_XmlSchemaSet_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
		}

		// Token: 0x060010B5 RID: 4277 RVA: 0x00006F1A File Offset: 0x0000511A
		public SqlXml(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x060010B6 RID: 4278 RVA: 0x0004F9D8 File Offset: 0x0004DBD8
		// (set) Token: 0x060010B7 RID: 4279 RVA: 0x00006F23 File Offset: 0x00005123
		public unsafe static Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader> s_sqlReaderDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SqlXml.NativeFieldInfoPtr_s_sqlReaderDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlXml.NativeFieldInfoPtr_s_sqlReaderDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x060010B8 RID: 4280 RVA: 0x0004FA00 File Offset: 0x0004DC00
		// (set) Token: 0x060010B9 RID: 4281 RVA: 0x00006F35 File Offset: 0x00005135
		public unsafe static XmlReaderSettings s_defaultXmlReaderSettings
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SqlXml.NativeFieldInfoPtr_s_defaultXmlReaderSettings, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlReaderSettings>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlXml.NativeFieldInfoPtr_s_defaultXmlReaderSettings, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x060010BA RID: 4282 RVA: 0x0004FA28 File Offset: 0x0004DC28
		// (set) Token: 0x060010BB RID: 4283 RVA: 0x00006F47 File Offset: 0x00005147
		public unsafe static XmlReaderSettings s_defaultXmlReaderSettingsCloseInput
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SqlXml.NativeFieldInfoPtr_s_defaultXmlReaderSettingsCloseInput, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlReaderSettings>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlXml.NativeFieldInfoPtr_s_defaultXmlReaderSettingsCloseInput, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x060010BC RID: 4284 RVA: 0x0004FA50 File Offset: 0x0004DC50
		// (set) Token: 0x060010BD RID: 4285 RVA: 0x00006F59 File Offset: 0x00005159
		public unsafe static MethodInfo s_createSqlReaderMethodInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SqlXml.NativeFieldInfoPtr_s_createSqlReaderMethodInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlXml.NativeFieldInfoPtr_s_createSqlReaderMethodInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x060010BE RID: 4286 RVA: 0x0004FA78 File Offset: 0x0004DC78
		// (set) Token: 0x060010BF RID: 4287 RVA: 0x00006F6B File Offset: 0x0000516B
		public unsafe MethodInfo _createSqlReaderMethodInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SqlXml.NativeFieldInfoPtr__createSqlReaderMethodInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SqlXml.NativeFieldInfoPtr__createSqlReaderMethodInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x060010C0 RID: 4288 RVA: 0x0004FAA8 File Offset: 0x0004DCA8
		// (set) Token: 0x060010C1 RID: 4289 RVA: 0x00006F8A File Offset: 0x0000518A
		public unsafe bool _fNotNull
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SqlXml.NativeFieldInfoPtr__fNotNull);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SqlXml.NativeFieldInfoPtr__fNotNull)) = value;
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x060010C2 RID: 4290 RVA: 0x0004FAD0 File Offset: 0x0004DCD0
		// (set) Token: 0x060010C3 RID: 4291 RVA: 0x00006FA5 File Offset: 0x000051A5
		public unsafe Stream _stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SqlXml.NativeFieldInfoPtr__stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SqlXml.NativeFieldInfoPtr__stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x060010C4 RID: 4292 RVA: 0x0004FB00 File Offset: 0x0004DD00
		// (set) Token: 0x060010C5 RID: 4293 RVA: 0x00006FC4 File Offset: 0x000051C4
		public unsafe bool _firstCreateReader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SqlXml.NativeFieldInfoPtr__firstCreateReader);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SqlXml.NativeFieldInfoPtr__firstCreateReader)) = value;
			}
		}

		// Token: 0x04000DD8 RID: 3544
		private static readonly IntPtr NativeFieldInfoPtr_s_sqlReaderDelegate;

		// Token: 0x04000DD9 RID: 3545
		private static readonly IntPtr NativeFieldInfoPtr_s_defaultXmlReaderSettings;

		// Token: 0x04000DDA RID: 3546
		private static readonly IntPtr NativeFieldInfoPtr_s_defaultXmlReaderSettingsCloseInput;

		// Token: 0x04000DDB RID: 3547
		private static readonly IntPtr NativeFieldInfoPtr_s_createSqlReaderMethodInfo;

		// Token: 0x04000DDC RID: 3548
		private static readonly IntPtr NativeFieldInfoPtr__createSqlReaderMethodInfo;

		// Token: 0x04000DDD RID: 3549
		private static readonly IntPtr NativeFieldInfoPtr__fNotNull;

		// Token: 0x04000DDE RID: 3550
		private static readonly IntPtr NativeFieldInfoPtr__stream;

		// Token: 0x04000DDF RID: 3551
		private static readonly IntPtr NativeFieldInfoPtr__firstCreateReader;

		// Token: 0x04000DE0 RID: 3552
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000DE1 RID: 3553
		private static readonly IntPtr NativeMethodInfoPtr_CreateReader_Public_XmlReader_0;

		// Token: 0x04000DE2 RID: 3554
		private static readonly IntPtr NativeMethodInfoPtr_CreateSqlXmlReader_Internal_Static_XmlReader_Stream_Boolean_Boolean_0;

		// Token: 0x04000DE3 RID: 3555
		private static readonly IntPtr NativeMethodInfoPtr_CreateSqlReaderDelegate_Private_Static_Func_4_Stream_XmlReaderSettings_XmlParserContext_XmlReader_0;

		// Token: 0x04000DE4 RID: 3556
		private static readonly IntPtr NativeMethodInfoPtr_get_CreateSqlReaderMethodInfo_Private_Static_get_MethodInfo_0;

		// Token: 0x04000DE5 RID: 3557
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNull_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000DE6 RID: 3558
		private static readonly IntPtr NativeMethodInfoPtr_SetNull_Private_Void_0;

		// Token: 0x04000DE7 RID: 3559
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0;

		// Token: 0x04000DE8 RID: 3560
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0;

		// Token: 0x04000DE9 RID: 3561
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0;

		// Token: 0x04000DEA RID: 3562
		private static readonly IntPtr NativeMethodInfoPtr_GetXsdType_Public_Static_XmlQualifiedName_XmlSchemaSet_0;
	}
}
