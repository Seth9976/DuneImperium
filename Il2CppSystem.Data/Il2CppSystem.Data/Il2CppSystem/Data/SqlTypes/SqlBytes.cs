using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Xml;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Data.SqlTypes
{
	// Token: 0x02000090 RID: 144
	[DefaultMember("Item")]
	[Serializable]
	public sealed class SqlBytes : Object
	{
		// Token: 0x06000DE2 RID: 3554 RVA: 0x0004512C File Offset: 0x0004332C
		// Note: this type is marked as 'beforefieldinit'.
		static SqlBytes()
		{
			Il2CppClassPointerStore<SqlBytes>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data.SqlTypes", "SqlBytes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SqlBytes>.NativeClassPtr);
			SqlBytes.NativeFieldInfoPtr__rgbBuf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlBytes>.NativeClassPtr, "_rgbBuf");
			SqlBytes.NativeFieldInfoPtr__lCurLen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlBytes>.NativeClassPtr, "_lCurLen");
			SqlBytes.NativeFieldInfoPtr__stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlBytes>.NativeClassPtr, "_stream");
			SqlBytes.NativeFieldInfoPtr__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlBytes>.NativeClassPtr, "_state");
			SqlBytes.NativeFieldInfoPtr__rgbWorkBuf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlBytes>.NativeClassPtr, "_rgbWorkBuf");
			SqlBytes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlBytes>.NativeClassPtr, 100665575);
			SqlBytes.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlBytes>.NativeClassPtr, 100665576);
			SqlBytes.NativeMethodInfoPtr__ctor_Public_Void_SqlBinary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlBytes>.NativeClassPtr, 100665577);
			SqlBytes.NativeMethodInfoPtr_get_IsNull_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlBytes>.NativeClassPtr, 100665578);
			SqlBytes.NativeMethodInfoPtr_get_Buffer_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlBytes>.NativeClassPtr, 100665579);
			SqlBytes.NativeMethodInfoPtr_get_Length_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlBytes>.NativeClassPtr, 100665580);
			SqlBytes.NativeMethodInfoPtr_get_Value_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlBytes>.NativeClassPtr, 100665581);
			SqlBytes.NativeMethodInfoPtr_SetNull_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlBytes>.NativeClassPtr, 100665582);
			SqlBytes.NativeMethodInfoPtr_CopyStreamToBuffer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlBytes>.NativeClassPtr, 100665583);
			SqlBytes.NativeMethodInfoPtr_FStream_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlBytes>.NativeClassPtr, 100665584);
			SqlBytes.NativeMethodInfoPtr_SetBuffer_Private_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlBytes>.NativeClassPtr, 100665585);
			SqlBytes.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlBytes>.NativeClassPtr, 100665586);
			SqlBytes.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlBytes>.NativeClassPtr, 100665587);
			SqlBytes.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlBytes>.NativeClassPtr, 100665588);
			SqlBytes.NativeMethodInfoPtr_GetXsdType_Public_Static_XmlQualifiedName_XmlSchemaSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlBytes>.NativeClassPtr, 100665589);
			SqlBytes.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlBytes>.NativeClassPtr, 100665590);
			SqlBytes.NativeMethodInfoPtr_get_Null_Public_Static_get_SqlBytes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlBytes>.NativeClassPtr, 100665591);
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x00045314 File Offset: 0x00043514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916288, XrefRangeEnd = 916290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlBytes()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SqlBytes>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlBytes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x00045350 File Offset: 0x00043550
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 916296, RefRangeEnd = 916300, XrefRangeStart = 916290, XrefRangeEnd = 916296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlBytes(Il2CppStructArray<byte> buffer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SqlBytes>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlBytes.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x0004539C File Offset: 0x0004359C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 916309, RefRangeEnd = 916310, XrefRangeStart = 916300, XrefRangeEnd = 916309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlBytes(SqlBinary value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SqlBytes>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlBytes.NativeMethodInfoPtr__ctor_Public_Void_SqlBinary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000DE6 RID: 3558 RVA: 0x000453EC File Offset: 0x000435EC
		public unsafe bool IsNull
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 623558, RefRangeEnd = 623560, XrefRangeStart = 623558, XrefRangeEnd = 623560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlBytes.NativeMethodInfoPtr_get_IsNull_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000DE7 RID: 3559 RVA: 0x00045428 File Offset: 0x00043628
		public unsafe Il2CppStructArray<byte> Buffer
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916310, XrefRangeEnd = 916316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlBytes.NativeMethodInfoPtr_get_Buffer_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000DE8 RID: 3560 RVA: 0x00045468 File Offset: 0x00043668
		public unsafe long Length
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlBytes.NativeMethodInfoPtr_get_Length_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000DE9 RID: 3561 RVA: 0x000454A4 File Offset: 0x000436A4
		public unsafe Il2CppStructArray<byte> Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916316, XrefRangeEnd = 916321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlBytes.NativeMethodInfoPtr_get_Value_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x000454E4 File Offset: 0x000436E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916321, XrefRangeEnd = 916322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlBytes.NativeMethodInfoPtr_SetNull_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x00045518 File Offset: 0x00043718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916322, XrefRangeEnd = 916328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyStreamToBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlBytes.NativeMethodInfoPtr_CopyStreamToBuffer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x0004554C File Offset: 0x0004374C
		[CallerCount(0)]
		public unsafe bool FStream()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlBytes.NativeMethodInfoPtr_FStream_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x00045588 File Offset: 0x00043788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916328, XrefRangeEnd = 916331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBuffer(Il2CppStructArray<byte> buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlBytes.NativeMethodInfoPtr_SetBuffer_Private_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x000455CC File Offset: 0x000437CC
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchema System_Xml_Serialization_IXmlSerializable_GetSchema()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlBytes.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x0004560C File Offset: 0x0004380C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916331, XrefRangeEnd = 916352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Xml_Serialization_IXmlSerializable_ReadXml(XmlReader r)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlBytes.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x00045650 File Offset: 0x00043850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916352, XrefRangeEnd = 916372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Xml_Serialization_IXmlSerializable_WriteXml(XmlWriter writer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlBytes.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x00045694 File Offset: 0x00043894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916372, XrefRangeEnd = 916380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaSet);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlBytes.NativeMethodInfoPtr_GetXsdType_Public_Static_XmlQualifiedName_XmlSchemaSet_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x000456D8 File Offset: 0x000438D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916380, XrefRangeEnd = 916385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlBytes.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000DF3 RID: 3571 RVA: 0x00045734 File Offset: 0x00043934
		public unsafe static SqlBytes Null
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 916389, RefRangeEnd = 916394, XrefRangeStart = 916385, XrefRangeEnd = 916389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlBytes.NativeMethodInfoPtr_get_Null_Public_Static_get_SqlBytes_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SqlBytes>(intPtr3) : null;
			}
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x00006508 File Offset: 0x00004708
		public SqlBytes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000DF5 RID: 3573 RVA: 0x00045768 File Offset: 0x00043968
		// (set) Token: 0x06000DF6 RID: 3574 RVA: 0x00006511 File Offset: 0x00004711
		public unsafe Il2CppStructArray<byte> _rgbBuf
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SqlBytes.NativeFieldInfoPtr__rgbBuf);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SqlBytes.NativeFieldInfoPtr__rgbBuf), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000DF7 RID: 3575 RVA: 0x00045798 File Offset: 0x00043998
		// (set) Token: 0x06000DF8 RID: 3576 RVA: 0x00006530 File Offset: 0x00004730
		public unsafe long _lCurLen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SqlBytes.NativeFieldInfoPtr__lCurLen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SqlBytes.NativeFieldInfoPtr__lCurLen)) = value;
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000DF9 RID: 3577 RVA: 0x000457C0 File Offset: 0x000439C0
		// (set) Token: 0x06000DFA RID: 3578 RVA: 0x0000654B File Offset: 0x0000474B
		public unsafe Stream _stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SqlBytes.NativeFieldInfoPtr__stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SqlBytes.NativeFieldInfoPtr__stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000DFB RID: 3579 RVA: 0x000457F0 File Offset: 0x000439F0
		// (set) Token: 0x06000DFC RID: 3580 RVA: 0x0000656A File Offset: 0x0000476A
		public unsafe SqlBytesCharsState _state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SqlBytes.NativeFieldInfoPtr__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SqlBytes.NativeFieldInfoPtr__state)) = value;
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000DFD RID: 3581 RVA: 0x00045818 File Offset: 0x00043A18
		// (set) Token: 0x06000DFE RID: 3582 RVA: 0x00006585 File Offset: 0x00004785
		public unsafe Il2CppStructArray<byte> _rgbWorkBuf
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SqlBytes.NativeFieldInfoPtr__rgbWorkBuf);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SqlBytes.NativeFieldInfoPtr__rgbWorkBuf), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B86 RID: 2950
		private static readonly IntPtr NativeFieldInfoPtr__rgbBuf;

		// Token: 0x04000B87 RID: 2951
		private static readonly IntPtr NativeFieldInfoPtr__lCurLen;

		// Token: 0x04000B88 RID: 2952
		private static readonly IntPtr NativeFieldInfoPtr__stream;

		// Token: 0x04000B89 RID: 2953
		private static readonly IntPtr NativeFieldInfoPtr__state;

		// Token: 0x04000B8A RID: 2954
		private static readonly IntPtr NativeFieldInfoPtr__rgbWorkBuf;

		// Token: 0x04000B8B RID: 2955
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000B8C RID: 2956
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000B8D RID: 2957
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SqlBinary_0;

		// Token: 0x04000B8E RID: 2958
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNull_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000B8F RID: 2959
		private static readonly IntPtr NativeMethodInfoPtr_get_Buffer_Public_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000B90 RID: 2960
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int64_0;

		// Token: 0x04000B91 RID: 2961
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000B92 RID: 2962
		private static readonly IntPtr NativeMethodInfoPtr_SetNull_Public_Void_0;

		// Token: 0x04000B93 RID: 2963
		private static readonly IntPtr NativeMethodInfoPtr_CopyStreamToBuffer_Private_Void_0;

		// Token: 0x04000B94 RID: 2964
		private static readonly IntPtr NativeMethodInfoPtr_FStream_Internal_Boolean_0;

		// Token: 0x04000B95 RID: 2965
		private static readonly IntPtr NativeMethodInfoPtr_SetBuffer_Private_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000B96 RID: 2966
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0;

		// Token: 0x04000B97 RID: 2967
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0;

		// Token: 0x04000B98 RID: 2968
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0;

		// Token: 0x04000B99 RID: 2969
		private static readonly IntPtr NativeMethodInfoPtr_GetXsdType_Public_Static_XmlQualifiedName_XmlSchemaSet_0;

		// Token: 0x04000B9A RID: 2970
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000B9B RID: 2971
		private static readonly IntPtr NativeMethodInfoPtr_get_Null_Public_Static_get_SqlBytes_0;
	}
}
