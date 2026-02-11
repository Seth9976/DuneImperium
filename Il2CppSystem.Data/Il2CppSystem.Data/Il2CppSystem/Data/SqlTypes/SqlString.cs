using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;
using Il2CppSystem.Text;
using Il2CppSystem.Xml;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Data.SqlTypes
{
	// Token: 0x0200009C RID: 156
	[Serializable]
	public sealed class SqlString : ValueType
	{
		// Token: 0x0600104D RID: 4173 RVA: 0x0004DEB8 File Offset: 0x0004C0B8
		// Note: this type is marked as 'beforefieldinit'.
		static SqlString()
		{
			Il2CppClassPointerStore<SqlString>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data.SqlTypes", "SqlString");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SqlString>.NativeClassPtr);
			SqlString.NativeFieldInfoPtr_m_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlString>.NativeClassPtr, "m_value");
			SqlString.NativeFieldInfoPtr_m_cmpInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlString>.NativeClassPtr, "m_cmpInfo");
			SqlString.NativeFieldInfoPtr_m_lcid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlString>.NativeClassPtr, "m_lcid");
			SqlString.NativeFieldInfoPtr_m_flag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlString>.NativeClassPtr, "m_flag");
			SqlString.NativeFieldInfoPtr_m_fNotNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlString>.NativeClassPtr, "m_fNotNull");
			SqlString.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlString>.NativeClassPtr, "Null");
			SqlString.NativeFieldInfoPtr_s_unicodeEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlString>.NativeClassPtr, "s_unicodeEncoding");
			SqlString.NativeFieldInfoPtr_IgnoreCase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlString>.NativeClassPtr, "IgnoreCase");
			SqlString.NativeFieldInfoPtr_IgnoreWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlString>.NativeClassPtr, "IgnoreWidth");
			SqlString.NativeFieldInfoPtr_IgnoreNonSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlString>.NativeClassPtr, "IgnoreNonSpace");
			SqlString.NativeFieldInfoPtr_IgnoreKanaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlString>.NativeClassPtr, "IgnoreKanaType");
			SqlString.NativeFieldInfoPtr_BinarySort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlString>.NativeClassPtr, "BinarySort");
			SqlString.NativeFieldInfoPtr_BinarySort2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlString>.NativeClassPtr, "BinarySort2");
			SqlString.NativeFieldInfoPtr_s_iDefaultFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlString>.NativeClassPtr, "s_iDefaultFlag");
			SqlString.NativeFieldInfoPtr_s_iValidCompareOptionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlString>.NativeClassPtr, "s_iValidCompareOptionMask");
			SqlString.NativeFieldInfoPtr_s_iValidSqlCompareOptionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlString>.NativeClassPtr, "s_iValidSqlCompareOptionMask");
			SqlString.NativeFieldInfoPtr_s_lcidUSEnglish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlString>.NativeClassPtr, "s_lcidUSEnglish");
			SqlString.NativeFieldInfoPtr_s_lcidBinary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlString>.NativeClassPtr, "s_lcidBinary");
			SqlString.NativeMethodInfoPtr__ctor_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlString>.NativeClassPtr, 100665928);
			SqlString.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_SqlCompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlString>.NativeClassPtr, 100665929);
			SqlString.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlString>.NativeClassPtr, 100665930);
			SqlString.NativeMethodInfoPtr__ctor_Private_Void_Int32_SqlCompareOptions_String_CompareInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlString>.NativeClassPtr, 100665931);
			SqlString.NativeMethodInfoPtr_get_IsNull_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlString>.NativeClassPtr, 100665932);
			SqlString.NativeMethodInfoPtr_get_Value_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlString>.NativeClassPtr, 100665933);
			SqlString.NativeMethodInfoPtr_SetCompareInfo_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlString>.NativeClassPtr, 100665934);
			SqlString.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlString_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlString>.NativeClassPtr, 100665935);
			SqlString.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlString>.NativeClassPtr, 100665936);
			SqlString.NativeMethodInfoPtr_op_Addition_Public_Static_SqlString_SqlString_SqlString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlString>.NativeClassPtr, 100665937);
			SqlString.NativeMethodInfoPtr_StringCompare_Private_Static_Int32_SqlString_SqlString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlString>.NativeClassPtr, 100665938);
			SqlString.NativeMethodInfoPtr_Compare_Private_Static_SqlBoolean_SqlString_SqlString_EComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlString>.NativeClassPtr, 100665939);
			SqlString.NativeMethodInfoPtr_op_Equality_Public_Static_SqlBoolean_SqlString_SqlString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlString>.NativeClassPtr, 100665940);
			SqlString.NativeMethodInfoPtr_ValidateSqlCompareOptions_Private_Static_Void_SqlCompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlString>.NativeClassPtr, 100665941);
			SqlString.NativeMethodInfoPtr_CompareOptionsFromSqlCompareOptions_Public_Static_CompareOptions_SqlCompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlString>.NativeClassPtr, 100665942);
			SqlString.NativeMethodInfoPtr_FBinarySort_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlString>.NativeClassPtr, 100665943);
			SqlString.NativeMethodInfoPtr_CompareBinary_Private_Static_Int32_SqlString_SqlString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlString>.NativeClassPtr, 100665944);
			SqlString.NativeMethodInfoPtr_CompareBinary2_Private_Static_Int32_SqlString_SqlString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlString>.NativeClassPtr, 100665945);
			SqlString.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlString>.NativeClassPtr, 100665946);
			SqlString.NativeMethodInfoPtr_CompareTo_Public_Int32_SqlString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlString>.NativeClassPtr, 100665947);
			SqlString.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlString>.NativeClassPtr, 100665948);
			SqlString.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlString>.NativeClassPtr, 100665949);
			SqlString.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlString>.NativeClassPtr, 100665950);
			SqlString.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlString>.NativeClassPtr, 100665951);
			SqlString.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlString>.NativeClassPtr, 100665952);
			SqlString.NativeMethodInfoPtr_GetXsdType_Public_Static_XmlQualifiedName_XmlSchemaSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlString>.NativeClassPtr, 100665953);
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x0004E258 File Offset: 0x0004C458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919850, XrefRangeEnd = 919852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlString(bool fNull)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SqlString>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fNull;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlString.NativeMethodInfoPtr__ctor_Private_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x0004E2A4 File Offset: 0x0004C4A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919852, XrefRangeEnd = 919858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlString(string data, int lcid, SqlCompareOptions compareOptions)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SqlString>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lcid;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref compareOptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlString.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_SqlCompareOptions_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x0004E310 File Offset: 0x0004C510
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 919874, RefRangeEnd = 919875, XrefRangeStart = 919858, XrefRangeEnd = 919874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlString(string data)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SqlString>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlString.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x0004E360 File Offset: 0x0004C560
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 919884, RefRangeEnd = 919885, XrefRangeStart = 919875, XrefRangeEnd = 919884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlString(int lcid, SqlCompareOptions compareOptions, string data, CompareInfo cmpInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SqlString>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lcid;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref compareOptions;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmpInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlString.NativeMethodInfoPtr__ctor_Private_Void_Int32_SqlCompareOptions_String_CompareInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06001052 RID: 4178 RVA: 0x0004E3E0 File Offset: 0x0004C5E0
		public unsafe bool IsNull
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 919885, RefRangeEnd = 919889, XrefRangeStart = 919885, XrefRangeEnd = 919885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlString.NativeMethodInfoPtr_get_IsNull_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06001053 RID: 4179 RVA: 0x0004E424 File Offset: 0x0004C624
		public unsafe string Value
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 919892, RefRangeEnd = 919896, XrefRangeStart = 919889, XrefRangeEnd = 919892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlString.NativeMethodInfoPtr_get_Value_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x0004E460 File Offset: 0x0004C660
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 919901, RefRangeEnd = 919904, XrefRangeStart = 919896, XrefRangeEnd = 919901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCompareInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlString.NativeMethodInfoPtr_SetCompareInfo_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x0004E498 File Offset: 0x0004C698
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 919905, RefRangeEnd = 919906, XrefRangeStart = 919904, XrefRangeEnd = 919905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator SqlString(string x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlString.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlString_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new SqlString(intPtr);
			}
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x0004E4D4 File Offset: 0x0004C6D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919906, XrefRangeEnd = 919910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlString.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x0004E510 File Offset: 0x0004C710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919910, XrefRangeEnd = 919919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlString operator +(SqlString x, SqlString y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlString.NativeMethodInfoPtr_op_Addition_Public_Static_SqlString_SqlString_SqlString_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new SqlString(intPtr);
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x0004E568 File Offset: 0x0004C768
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 919949, RefRangeEnd = 919953, XrefRangeStart = 919919, XrefRangeEnd = 919949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int StringCompare(SqlString x, SqlString y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlString.NativeMethodInfoPtr_StringCompare_Private_Static_Int32_SqlString_SqlString_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x0004E5C8 File Offset: 0x0004C7C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919953, XrefRangeEnd = 919967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean Compare(SqlString x, SqlString y, EComparison ecExpectedResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ecExpectedResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlString.NativeMethodInfoPtr_Compare_Private_Static_SqlBoolean_SqlString_SqlString_EComparison_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x0004E634 File Offset: 0x0004C834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919967, XrefRangeEnd = 919980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean operator ==(SqlString x, SqlString y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlString.NativeMethodInfoPtr_op_Equality_Public_Static_SqlBoolean_SqlString_SqlString_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x0004E694 File Offset: 0x0004C894
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 919984, RefRangeEnd = 919988, XrefRangeStart = 919980, XrefRangeEnd = 919984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateSqlCompareOptions(SqlCompareOptions compareOptions)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref compareOptions;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlString.NativeMethodInfoPtr_ValidateSqlCompareOptions_Private_Static_Void_SqlCompareOptions_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x0004E6C8 File Offset: 0x0004C8C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 919992, RefRangeEnd = 919994, XrefRangeStart = 919988, XrefRangeEnd = 919992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CompareOptions CompareOptionsFromSqlCompareOptions(SqlCompareOptions compareOptions)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref compareOptions;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlString.NativeMethodInfoPtr_CompareOptionsFromSqlCompareOptions_Public_Static_CompareOptions_SqlCompareOptions_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x0004E708 File Offset: 0x0004C908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919994, XrefRangeEnd = 919997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool FBinarySort()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlString.NativeMethodInfoPtr_FBinarySort_Private_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x0004E74C File Offset: 0x0004C94C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 920002, RefRangeEnd = 920003, XrefRangeStart = 919997, XrefRangeEnd = 920002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompareBinary(SqlString x, SqlString y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlString.NativeMethodInfoPtr_CompareBinary_Private_Static_Int32_SqlString_SqlString_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x0004E7AC File Offset: 0x0004C9AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 920003, XrefRangeEnd = 920008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompareBinary2(SqlString x, SqlString y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlString.NativeMethodInfoPtr_CompareBinary2_Private_Static_Int32_SqlString_SqlString_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x0004E80C File Offset: 0x0004CA0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 920008, XrefRangeEnd = 920014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlString.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x0004E860 File Offset: 0x0004CA60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 920022, RefRangeEnd = 920023, XrefRangeStart = 920014, XrefRangeEnd = 920022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(SqlString value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlString.NativeMethodInfoPtr_CompareTo_Public_Int32_SqlString_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x0004E8B8 File Offset: 0x0004CAB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 920023, XrefRangeEnd = 920053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlString.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x0004E90C File Offset: 0x0004CB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 920053, XrefRangeEnd = 920079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlString.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x0004E950 File Offset: 0x0004CB50
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchema System_Xml_Serialization_IXmlSerializable_GetSchema()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlString.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x0004E994 File Offset: 0x0004CB94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 920079, XrefRangeEnd = 920087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Xml_Serialization_IXmlSerializable_ReadXml(XmlReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlString.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x0004E9DC File Offset: 0x0004CBDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 920087, XrefRangeEnd = 920099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Xml_Serialization_IXmlSerializable_WriteXml(XmlWriter writer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlString.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x0004EA24 File Offset: 0x0004CC24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 920099, XrefRangeEnd = 920107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaSet);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlString.NativeMethodInfoPtr_GetXsdType_Public_Static_XmlQualifiedName_XmlSchemaSet_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x00006D89 File Offset: 0x00004F89
		public SqlString(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x00006D92 File Offset: 0x00004F92
		public SqlString()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SqlString>.NativeClassPtr))
		{
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x0600106A RID: 4202 RVA: 0x0004EA68 File Offset: 0x0004CC68
		// (set) Token: 0x0600106B RID: 4203 RVA: 0x00006DA4 File Offset: 0x00004FA4
		public unsafe string m_value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SqlString.NativeFieldInfoPtr_m_value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SqlString.NativeFieldInfoPtr_m_value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x0600106C RID: 4204 RVA: 0x0004EA90 File Offset: 0x0004CC90
		// (set) Token: 0x0600106D RID: 4205 RVA: 0x00006DC3 File Offset: 0x00004FC3
		public unsafe CompareInfo m_cmpInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SqlString.NativeFieldInfoPtr_m_cmpInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompareInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SqlString.NativeFieldInfoPtr_m_cmpInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x0600106E RID: 4206 RVA: 0x0004EAC0 File Offset: 0x0004CCC0
		// (set) Token: 0x0600106F RID: 4207 RVA: 0x00006DE2 File Offset: 0x00004FE2
		public unsafe int m_lcid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SqlString.NativeFieldInfoPtr_m_lcid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SqlString.NativeFieldInfoPtr_m_lcid)) = value;
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06001070 RID: 4208 RVA: 0x0004EAE8 File Offset: 0x0004CCE8
		// (set) Token: 0x06001071 RID: 4209 RVA: 0x00006DFD File Offset: 0x00004FFD
		public unsafe SqlCompareOptions m_flag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SqlString.NativeFieldInfoPtr_m_flag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SqlString.NativeFieldInfoPtr_m_flag)) = value;
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06001072 RID: 4210 RVA: 0x0004EB10 File Offset: 0x0004CD10
		// (set) Token: 0x06001073 RID: 4211 RVA: 0x00006E18 File Offset: 0x00005018
		public unsafe bool m_fNotNull
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SqlString.NativeFieldInfoPtr_m_fNotNull);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SqlString.NativeFieldInfoPtr_m_fNotNull)) = value;
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06001074 RID: 4212 RVA: 0x0004EB38 File Offset: 0x0004CD38
		// (set) Token: 0x06001075 RID: 4213 RVA: 0x00006E33 File Offset: 0x00005033
		public unsafe static SqlString Null
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SqlString>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(SqlString.NativeFieldInfoPtr_Null, intPtr);
				return new SqlString(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SqlString>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlString.NativeFieldInfoPtr_Null, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06001076 RID: 4214 RVA: 0x0004EB74 File Offset: 0x0004CD74
		// (set) Token: 0x06001077 RID: 4215 RVA: 0x00006E4A File Offset: 0x0000504A
		public unsafe static UnicodeEncoding s_unicodeEncoding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SqlString.NativeFieldInfoPtr_s_unicodeEncoding, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnicodeEncoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlString.NativeFieldInfoPtr_s_unicodeEncoding, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06001078 RID: 4216 RVA: 0x0004EB9C File Offset: 0x0004CD9C
		// (set) Token: 0x06001079 RID: 4217 RVA: 0x00006E5C File Offset: 0x0000505C
		public unsafe static int IgnoreCase
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SqlString.NativeFieldInfoPtr_IgnoreCase, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlString.NativeFieldInfoPtr_IgnoreCase, (void*)(&value));
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x0600107A RID: 4218 RVA: 0x0004EBB8 File Offset: 0x0004CDB8
		// (set) Token: 0x0600107B RID: 4219 RVA: 0x00006E6A File Offset: 0x0000506A
		public unsafe static int IgnoreWidth
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SqlString.NativeFieldInfoPtr_IgnoreWidth, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlString.NativeFieldInfoPtr_IgnoreWidth, (void*)(&value));
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x0600107C RID: 4220 RVA: 0x0004EBD4 File Offset: 0x0004CDD4
		// (set) Token: 0x0600107D RID: 4221 RVA: 0x00006E78 File Offset: 0x00005078
		public unsafe static int IgnoreNonSpace
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SqlString.NativeFieldInfoPtr_IgnoreNonSpace, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlString.NativeFieldInfoPtr_IgnoreNonSpace, (void*)(&value));
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x0600107E RID: 4222 RVA: 0x0004EBF0 File Offset: 0x0004CDF0
		// (set) Token: 0x0600107F RID: 4223 RVA: 0x00006E86 File Offset: 0x00005086
		public unsafe static int IgnoreKanaType
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SqlString.NativeFieldInfoPtr_IgnoreKanaType, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlString.NativeFieldInfoPtr_IgnoreKanaType, (void*)(&value));
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06001080 RID: 4224 RVA: 0x0004EC0C File Offset: 0x0004CE0C
		// (set) Token: 0x06001081 RID: 4225 RVA: 0x00006E94 File Offset: 0x00005094
		public unsafe static int BinarySort
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SqlString.NativeFieldInfoPtr_BinarySort, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlString.NativeFieldInfoPtr_BinarySort, (void*)(&value));
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06001082 RID: 4226 RVA: 0x0004EC28 File Offset: 0x0004CE28
		// (set) Token: 0x06001083 RID: 4227 RVA: 0x00006EA2 File Offset: 0x000050A2
		public unsafe static int BinarySort2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SqlString.NativeFieldInfoPtr_BinarySort2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlString.NativeFieldInfoPtr_BinarySort2, (void*)(&value));
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06001084 RID: 4228 RVA: 0x0004EC44 File Offset: 0x0004CE44
		// (set) Token: 0x06001085 RID: 4229 RVA: 0x00006EB0 File Offset: 0x000050B0
		public unsafe static SqlCompareOptions s_iDefaultFlag
		{
			get
			{
				SqlCompareOptions sqlCompareOptions;
				IL2CPP.il2cpp_field_static_get_value(SqlString.NativeFieldInfoPtr_s_iDefaultFlag, (void*)(&sqlCompareOptions));
				return sqlCompareOptions;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlString.NativeFieldInfoPtr_s_iDefaultFlag, (void*)(&value));
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06001086 RID: 4230 RVA: 0x0004EC60 File Offset: 0x0004CE60
		// (set) Token: 0x06001087 RID: 4231 RVA: 0x00006EBE File Offset: 0x000050BE
		public unsafe static CompareOptions s_iValidCompareOptionMask
		{
			get
			{
				CompareOptions compareOptions;
				IL2CPP.il2cpp_field_static_get_value(SqlString.NativeFieldInfoPtr_s_iValidCompareOptionMask, (void*)(&compareOptions));
				return compareOptions;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlString.NativeFieldInfoPtr_s_iValidCompareOptionMask, (void*)(&value));
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06001088 RID: 4232 RVA: 0x0004EC7C File Offset: 0x0004CE7C
		// (set) Token: 0x06001089 RID: 4233 RVA: 0x00006ECC File Offset: 0x000050CC
		public unsafe static SqlCompareOptions s_iValidSqlCompareOptionMask
		{
			get
			{
				SqlCompareOptions sqlCompareOptions;
				IL2CPP.il2cpp_field_static_get_value(SqlString.NativeFieldInfoPtr_s_iValidSqlCompareOptionMask, (void*)(&sqlCompareOptions));
				return sqlCompareOptions;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlString.NativeFieldInfoPtr_s_iValidSqlCompareOptionMask, (void*)(&value));
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x0600108A RID: 4234 RVA: 0x0004EC98 File Offset: 0x0004CE98
		// (set) Token: 0x0600108B RID: 4235 RVA: 0x00006EDA File Offset: 0x000050DA
		public unsafe static int s_lcidUSEnglish
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SqlString.NativeFieldInfoPtr_s_lcidUSEnglish, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlString.NativeFieldInfoPtr_s_lcidUSEnglish, (void*)(&value));
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x0600108C RID: 4236 RVA: 0x0004ECB4 File Offset: 0x0004CEB4
		// (set) Token: 0x0600108D RID: 4237 RVA: 0x00006EE8 File Offset: 0x000050E8
		public unsafe static int s_lcidBinary
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SqlString.NativeFieldInfoPtr_s_lcidBinary, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlString.NativeFieldInfoPtr_s_lcidBinary, (void*)(&value));
			}
		}

		// Token: 0x04000D92 RID: 3474
		private static readonly IntPtr NativeFieldInfoPtr_m_value;

		// Token: 0x04000D93 RID: 3475
		private static readonly IntPtr NativeFieldInfoPtr_m_cmpInfo;

		// Token: 0x04000D94 RID: 3476
		private static readonly IntPtr NativeFieldInfoPtr_m_lcid;

		// Token: 0x04000D95 RID: 3477
		private static readonly IntPtr NativeFieldInfoPtr_m_flag;

		// Token: 0x04000D96 RID: 3478
		private static readonly IntPtr NativeFieldInfoPtr_m_fNotNull;

		// Token: 0x04000D97 RID: 3479
		private static readonly IntPtr NativeFieldInfoPtr_Null;

		// Token: 0x04000D98 RID: 3480
		private static readonly IntPtr NativeFieldInfoPtr_s_unicodeEncoding;

		// Token: 0x04000D99 RID: 3481
		private static readonly IntPtr NativeFieldInfoPtr_IgnoreCase;

		// Token: 0x04000D9A RID: 3482
		private static readonly IntPtr NativeFieldInfoPtr_IgnoreWidth;

		// Token: 0x04000D9B RID: 3483
		private static readonly IntPtr NativeFieldInfoPtr_IgnoreNonSpace;

		// Token: 0x04000D9C RID: 3484
		private static readonly IntPtr NativeFieldInfoPtr_IgnoreKanaType;

		// Token: 0x04000D9D RID: 3485
		private static readonly IntPtr NativeFieldInfoPtr_BinarySort;

		// Token: 0x04000D9E RID: 3486
		private static readonly IntPtr NativeFieldInfoPtr_BinarySort2;

		// Token: 0x04000D9F RID: 3487
		private static readonly IntPtr NativeFieldInfoPtr_s_iDefaultFlag;

		// Token: 0x04000DA0 RID: 3488
		private static readonly IntPtr NativeFieldInfoPtr_s_iValidCompareOptionMask;

		// Token: 0x04000DA1 RID: 3489
		private static readonly IntPtr NativeFieldInfoPtr_s_iValidSqlCompareOptionMask;

		// Token: 0x04000DA2 RID: 3490
		private static readonly IntPtr NativeFieldInfoPtr_s_lcidUSEnglish;

		// Token: 0x04000DA3 RID: 3491
		private static readonly IntPtr NativeFieldInfoPtr_s_lcidBinary;

		// Token: 0x04000DA4 RID: 3492
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Boolean_0;

		// Token: 0x04000DA5 RID: 3493
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_SqlCompareOptions_0;

		// Token: 0x04000DA6 RID: 3494
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000DA7 RID: 3495
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_SqlCompareOptions_String_CompareInfo_0;

		// Token: 0x04000DA8 RID: 3496
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNull_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000DA9 RID: 3497
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_String_0;

		// Token: 0x04000DAA RID: 3498
		private static readonly IntPtr NativeMethodInfoPtr_SetCompareInfo_Private_Void_0;

		// Token: 0x04000DAB RID: 3499
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SqlString_String_0;

		// Token: 0x04000DAC RID: 3500
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000DAD RID: 3501
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_SqlString_SqlString_SqlString_0;

		// Token: 0x04000DAE RID: 3502
		private static readonly IntPtr NativeMethodInfoPtr_StringCompare_Private_Static_Int32_SqlString_SqlString_0;

		// Token: 0x04000DAF RID: 3503
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Private_Static_SqlBoolean_SqlString_SqlString_EComparison_0;

		// Token: 0x04000DB0 RID: 3504
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_SqlBoolean_SqlString_SqlString_0;

		// Token: 0x04000DB1 RID: 3505
		private static readonly IntPtr NativeMethodInfoPtr_ValidateSqlCompareOptions_Private_Static_Void_SqlCompareOptions_0;

		// Token: 0x04000DB2 RID: 3506
		private static readonly IntPtr NativeMethodInfoPtr_CompareOptionsFromSqlCompareOptions_Public_Static_CompareOptions_SqlCompareOptions_0;

		// Token: 0x04000DB3 RID: 3507
		private static readonly IntPtr NativeMethodInfoPtr_FBinarySort_Private_Boolean_0;

		// Token: 0x04000DB4 RID: 3508
		private static readonly IntPtr NativeMethodInfoPtr_CompareBinary_Private_Static_Int32_SqlString_SqlString_0;

		// Token: 0x04000DB5 RID: 3509
		private static readonly IntPtr NativeMethodInfoPtr_CompareBinary2_Private_Static_Int32_SqlString_SqlString_0;

		// Token: 0x04000DB6 RID: 3510
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000DB7 RID: 3511
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Int32_SqlString_0;

		// Token: 0x04000DB8 RID: 3512
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000DB9 RID: 3513
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000DBA RID: 3514
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0;

		// Token: 0x04000DBB RID: 3515
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0;

		// Token: 0x04000DBC RID: 3516
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0;

		// Token: 0x04000DBD RID: 3517
		private static readonly IntPtr NativeMethodInfoPtr_GetXsdType_Public_Static_XmlQualifiedName_XmlSchemaSet_0;
	}
}
