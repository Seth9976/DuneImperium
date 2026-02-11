using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200003E RID: 62
	public class XmlAsyncCheckReaderWithLineInfoNSSchema : XmlAsyncCheckReaderWithLineInfoNS
	{
		// Token: 0x060003D2 RID: 978 RVA: 0x00025D04 File Offset: 0x00023F04
		// Note: this type is marked as 'beforefieldinit'.
		static XmlAsyncCheckReaderWithLineInfoNSSchema()
		{
			Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfoNSSchema>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlAsyncCheckReaderWithLineInfoNSSchema");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfoNSSchema>.NativeClassPtr);
			XmlAsyncCheckReaderWithLineInfoNSSchema.NativeFieldInfoPtr_readerAsIXmlSchemaInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfoNSSchema>.NativeClassPtr, "readerAsIXmlSchemaInfo");
			XmlAsyncCheckReaderWithLineInfoNSSchema.NativeMethodInfoPtr__ctor_Public_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfoNSSchema>.NativeClassPtr, 100663858);
			XmlAsyncCheckReaderWithLineInfoNSSchema.NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_Validity_Private_Virtual_Final_New_get_XmlSchemaValidity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfoNSSchema>.NativeClassPtr, 100663859);
			XmlAsyncCheckReaderWithLineInfoNSSchema.NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_IsDefault_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfoNSSchema>.NativeClassPtr, 100663860);
			XmlAsyncCheckReaderWithLineInfoNSSchema.NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_IsNil_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfoNSSchema>.NativeClassPtr, 100663861);
			XmlAsyncCheckReaderWithLineInfoNSSchema.NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_MemberType_Private_Virtual_Final_New_get_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfoNSSchema>.NativeClassPtr, 100663862);
			XmlAsyncCheckReaderWithLineInfoNSSchema.NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_SchemaType_Private_Virtual_Final_New_get_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfoNSSchema>.NativeClassPtr, 100663863);
			XmlAsyncCheckReaderWithLineInfoNSSchema.NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_SchemaElement_Private_Virtual_Final_New_get_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfoNSSchema>.NativeClassPtr, 100663864);
			XmlAsyncCheckReaderWithLineInfoNSSchema.NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_SchemaAttribute_Private_Virtual_Final_New_get_XmlSchemaAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfoNSSchema>.NativeClassPtr, 100663865);
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00025DE8 File Offset: 0x00023FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365130, XrefRangeEnd = 365140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAsyncCheckReaderWithLineInfoNSSchema(XmlReader reader)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfoNSSchema>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAsyncCheckReaderWithLineInfoNSSchema.NativeMethodInfoPtr__ctor_Public_Void_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x00025E34 File Offset: 0x00024034
		public unsafe virtual XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.Validity
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365140, XrefRangeEnd = 365144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAsyncCheckReaderWithLineInfoNSSchema.NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_Validity_Private_Virtual_Final_New_get_XmlSchemaValidity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x00025E70 File Offset: 0x00024070
		public unsafe virtual bool System.Xml.Schema.IXmlSchemaInfo.IsDefault
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365144, XrefRangeEnd = 365148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAsyncCheckReaderWithLineInfoNSSchema.NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_IsDefault_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x00025EAC File Offset: 0x000240AC
		public unsafe virtual bool System.Xml.Schema.IXmlSchemaInfo.IsNil
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365148, XrefRangeEnd = 365152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAsyncCheckReaderWithLineInfoNSSchema.NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_IsNil_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x00025EE8 File Offset: 0x000240E8
		public unsafe virtual XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.MemberType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365152, XrefRangeEnd = 365156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAsyncCheckReaderWithLineInfoNSSchema.NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_MemberType_Private_Virtual_Final_New_get_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x00025F28 File Offset: 0x00024128
		public unsafe virtual XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.SchemaType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365156, XrefRangeEnd = 365160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAsyncCheckReaderWithLineInfoNSSchema.NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_SchemaType_Private_Virtual_Final_New_get_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr3) : null;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x00025F68 File Offset: 0x00024168
		public unsafe virtual XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.SchemaElement
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365160, XrefRangeEnd = 365164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAsyncCheckReaderWithLineInfoNSSchema.NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_SchemaElement_Private_Virtual_Final_New_get_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaElement>(intPtr3) : null;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060003DA RID: 986 RVA: 0x00025FA8 File Offset: 0x000241A8
		public unsafe virtual XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.SchemaAttribute
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365164, XrefRangeEnd = 365168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAsyncCheckReaderWithLineInfoNSSchema.NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_SchemaAttribute_Private_Virtual_Final_New_get_XmlSchemaAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00003484 File Offset: 0x00001684
		public XmlAsyncCheckReaderWithLineInfoNSSchema(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060003DC RID: 988 RVA: 0x00025FE8 File Offset: 0x000241E8
		// (set) Token: 0x060003DD RID: 989 RVA: 0x0000348D File Offset: 0x0000168D
		public unsafe IXmlSchemaInfo readerAsIXmlSchemaInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAsyncCheckReaderWithLineInfoNSSchema.NativeFieldInfoPtr_readerAsIXmlSchemaInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IXmlSchemaInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAsyncCheckReaderWithLineInfoNSSchema.NativeFieldInfoPtr_readerAsIXmlSchemaInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000345 RID: 837
		private static readonly IntPtr NativeFieldInfoPtr_readerAsIXmlSchemaInfo;

		// Token: 0x04000346 RID: 838
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlReader_0;

		// Token: 0x04000347 RID: 839
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_Validity_Private_Virtual_Final_New_get_XmlSchemaValidity_0;

		// Token: 0x04000348 RID: 840
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_IsDefault_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000349 RID: 841
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_IsNil_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400034A RID: 842
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_MemberType_Private_Virtual_Final_New_get_XmlSchemaSimpleType_0;

		// Token: 0x0400034B RID: 843
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_SchemaType_Private_Virtual_Final_New_get_XmlSchemaType_0;

		// Token: 0x0400034C RID: 844
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_SchemaElement_Private_Virtual_Final_New_get_XmlSchemaElement_0;

		// Token: 0x0400034D RID: 845
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_SchemaAttribute_Private_Virtual_Final_New_get_XmlSchemaAttribute_0;
	}
}
