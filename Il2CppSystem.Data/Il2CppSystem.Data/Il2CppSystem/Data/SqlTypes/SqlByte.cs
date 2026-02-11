using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Data.SqlTypes
{
	// Token: 0x0200008E RID: 142
	[Serializable]
	[StructLayout(2)]
	public struct SqlByte
	{
		// Token: 0x06000DBC RID: 3516 RVA: 0x0004477C File Offset: 0x0004297C
		// Note: this type is marked as 'beforefieldinit'.
		static SqlByte()
		{
			Il2CppClassPointerStore<SqlByte>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data.SqlTypes", "SqlByte");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SqlByte>.NativeClassPtr);
			SqlByte.NativeFieldInfoPtr_m_fNotNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlByte>.NativeClassPtr, "m_fNotNull");
			SqlByte.NativeFieldInfoPtr_m_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlByte>.NativeClassPtr, "m_value");
			SqlByte.NativeFieldInfoPtr_s_iBitNotByteMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlByte>.NativeClassPtr, "s_iBitNotByteMax");
			SqlByte.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlByte>.NativeClassPtr, "Null");
			SqlByte.NativeFieldInfoPtr_Zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlByte>.NativeClassPtr, "Zero");
			SqlByte.NativeFieldInfoPtr_MinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlByte>.NativeClassPtr, "MinValue");
			SqlByte.NativeFieldInfoPtr_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlByte>.NativeClassPtr, "MaxValue");
			SqlByte.NativeMethodInfoPtr__ctor_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlByte>.NativeClassPtr, 100665548);
			SqlByte.NativeMethodInfoPtr__ctor_Public_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlByte>.NativeClassPtr, 100665549);
			SqlByte.NativeMethodInfoPtr_get_IsNull_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlByte>.NativeClassPtr, 100665550);
			SqlByte.NativeMethodInfoPtr_get_Value_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlByte>.NativeClassPtr, 100665551);
			SqlByte.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlByte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlByte>.NativeClassPtr, 100665552);
			SqlByte.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlByte>.NativeClassPtr, 100665553);
			SqlByte.NativeMethodInfoPtr_op_Addition_Public_Static_SqlByte_SqlByte_SqlByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlByte>.NativeClassPtr, 100665554);
			SqlByte.NativeMethodInfoPtr_op_Subtraction_Public_Static_SqlByte_SqlByte_SqlByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlByte>.NativeClassPtr, 100665555);
			SqlByte.NativeMethodInfoPtr_op_Multiply_Public_Static_SqlByte_SqlByte_SqlByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlByte>.NativeClassPtr, 100665556);
			SqlByte.NativeMethodInfoPtr_op_Division_Public_Static_SqlByte_SqlByte_SqlByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlByte>.NativeClassPtr, 100665557);
			SqlByte.NativeMethodInfoPtr_op_Explicit_Public_Static_SqlByte_SqlInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlByte>.NativeClassPtr, 100665558);
			SqlByte.NativeMethodInfoPtr_op_Equality_Public_Static_SqlBoolean_SqlByte_SqlByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlByte>.NativeClassPtr, 100665559);
			SqlByte.NativeMethodInfoPtr_op_LessThan_Public_Static_SqlBoolean_SqlByte_SqlByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlByte>.NativeClassPtr, 100665560);
			SqlByte.NativeMethodInfoPtr_op_GreaterThan_Public_Static_SqlBoolean_SqlByte_SqlByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlByte>.NativeClassPtr, 100665561);
			SqlByte.NativeMethodInfoPtr_LessThan_Public_Static_SqlBoolean_SqlByte_SqlByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlByte>.NativeClassPtr, 100665562);
			SqlByte.NativeMethodInfoPtr_GreaterThan_Public_Static_SqlBoolean_SqlByte_SqlByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlByte>.NativeClassPtr, 100665563);
			SqlByte.NativeMethodInfoPtr_ToSqlDouble_Public_SqlDouble_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlByte>.NativeClassPtr, 100665564);
			SqlByte.NativeMethodInfoPtr_ToSqlInt64_Public_SqlInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlByte>.NativeClassPtr, 100665565);
			SqlByte.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlByte>.NativeClassPtr, 100665566);
			SqlByte.NativeMethodInfoPtr_CompareTo_Public_Int32_SqlByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlByte>.NativeClassPtr, 100665567);
			SqlByte.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlByte>.NativeClassPtr, 100665568);
			SqlByte.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlByte>.NativeClassPtr, 100665569);
			SqlByte.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlByte>.NativeClassPtr, 100665570);
			SqlByte.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlByte>.NativeClassPtr, 100665571);
			SqlByte.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlByte>.NativeClassPtr, 100665572);
			SqlByte.NativeMethodInfoPtr_GetXsdType_Public_Static_XmlQualifiedName_XmlSchemaSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlByte>.NativeClassPtr, 100665573);
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x00044A40 File Offset: 0x00042C40
		[CallerCount(0)]
		public unsafe SqlByte(bool fNull)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fNull;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlByte.NativeMethodInfoPtr__ctor_Private_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x00044A74 File Offset: 0x00042C74
		[CallerCount(480)]
		[CachedScanResults(RefRangeStart = 915607, RefRangeEnd = 916087, XrefRangeStart = 915607, XrefRangeEnd = 915607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlByte(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlByte.NativeMethodInfoPtr__ctor_Public_Void_Byte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000DBF RID: 3519 RVA: 0x00044AA8 File Offset: 0x00042CA8
		public unsafe bool IsNull
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 786806, RefRangeEnd = 786824, XrefRangeStart = 786806, XrefRangeEnd = 786824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlByte.NativeMethodInfoPtr_get_IsNull_Public_Virtual_Final_New_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000DC0 RID: 3520 RVA: 0x00044AD8 File Offset: 0x00042CD8
		public unsafe byte Value
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlByte.NativeMethodInfoPtr_get_Value_Public_get_Byte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x00044B08 File Offset: 0x00042D08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 916087, RefRangeEnd = 916089, XrefRangeStart = 916087, XrefRangeEnd = 916087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SqlByte(byte x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlByte.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlByte_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x00044B48 File Offset: 0x00042D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916089, XrefRangeEnd = 916094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlByte.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x00044B74 File Offset: 0x00042D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916094, XrefRangeEnd = 916102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlByte operator +(SqlByte x, SqlByte y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlByte.NativeMethodInfoPtr_op_Addition_Public_Static_SqlByte_SqlByte_SqlByte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x00044BC0 File Offset: 0x00042DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916102, XrefRangeEnd = 916110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlByte operator -(SqlByte x, SqlByte y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlByte.NativeMethodInfoPtr_op_Subtraction_Public_Static_SqlByte_SqlByte_SqlByte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x00044C0C File Offset: 0x00042E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916110, XrefRangeEnd = 916118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlByte operator *(SqlByte x, SqlByte y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlByte.NativeMethodInfoPtr_op_Multiply_Public_Static_SqlByte_SqlByte_SqlByte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x00044C58 File Offset: 0x00042E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916118, XrefRangeEnd = 916124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlByte operator /(SqlByte x, SqlByte y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlByte.NativeMethodInfoPtr_op_Division_Public_Static_SqlByte_SqlByte_SqlByte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x00044CA4 File Offset: 0x00042EA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 916141, RefRangeEnd = 916142, XrefRangeStart = 916124, XrefRangeEnd = 916141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator SqlByte(SqlInt64 x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlByte.NativeMethodInfoPtr_op_Explicit_Public_Static_SqlByte_SqlInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x00044CE4 File Offset: 0x00042EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916142, XrefRangeEnd = 916148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean operator ==(SqlByte x, SqlByte y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlByte.NativeMethodInfoPtr_op_Equality_Public_Static_SqlBoolean_SqlByte_SqlByte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x00044D30 File Offset: 0x00042F30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 916154, RefRangeEnd = 916156, XrefRangeStart = 916148, XrefRangeEnd = 916154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean operator <(SqlByte x, SqlByte y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlByte.NativeMethodInfoPtr_op_LessThan_Public_Static_SqlBoolean_SqlByte_SqlByte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x00044D7C File Offset: 0x00042F7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 916162, RefRangeEnd = 916164, XrefRangeStart = 916156, XrefRangeEnd = 916162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean operator >(SqlByte x, SqlByte y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlByte.NativeMethodInfoPtr_op_GreaterThan_Public_Static_SqlBoolean_SqlByte_SqlByte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x00044DC8 File Offset: 0x00042FC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 916168, RefRangeEnd = 916169, XrefRangeStart = 916164, XrefRangeEnd = 916168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean LessThan(SqlByte x, SqlByte y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlByte.NativeMethodInfoPtr_LessThan_Public_Static_SqlBoolean_SqlByte_SqlByte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x00044E14 File Offset: 0x00043014
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 916173, RefRangeEnd = 916174, XrefRangeStart = 916169, XrefRangeEnd = 916173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean GreaterThan(SqlByte x, SqlByte y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlByte.NativeMethodInfoPtr_GreaterThan_Public_Static_SqlBoolean_SqlByte_SqlByte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x00044E60 File Offset: 0x00043060
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 916178, RefRangeEnd = 916181, XrefRangeStart = 916174, XrefRangeEnd = 916178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlDouble ToSqlDouble()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlByte.NativeMethodInfoPtr_ToSqlDouble_Public_SqlDouble_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x00044E90 File Offset: 0x00043090
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 916185, RefRangeEnd = 916186, XrefRangeStart = 916181, XrefRangeEnd = 916185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlInt64 ToSqlInt64()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlByte.NativeMethodInfoPtr_ToSqlInt64_Public_SqlInt64_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x00044EC0 File Offset: 0x000430C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916186, XrefRangeEnd = 916204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlByte.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x00044F04 File Offset: 0x00043104
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 916226, RefRangeEnd = 916229, XrefRangeStart = 916204, XrefRangeEnd = 916226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(SqlByte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlByte.NativeMethodInfoPtr_CompareTo_Public_Int32_SqlByte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x00044F44 File Offset: 0x00043144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916229, XrefRangeEnd = 916252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlByte.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x00044F88 File Offset: 0x00043188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916252, XrefRangeEnd = 916256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlByte.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x00044FB8 File Offset: 0x000431B8
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchema System_Xml_Serialization_IXmlSerializable_GetSchema()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlByte.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x00044FEC File Offset: 0x000431EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916256, XrefRangeEnd = 916264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Xml_Serialization_IXmlSerializable_ReadXml(XmlReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlByte.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x00045024 File Offset: 0x00043224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916264, XrefRangeEnd = 916280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Xml_Serialization_IXmlSerializable_WriteXml(XmlWriter writer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlByte.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x0004505C File Offset: 0x0004325C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916280, XrefRangeEnd = 916288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaSet);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlByte.NativeMethodInfoPtr_GetXsdType_Public_Static_XmlQualifiedName_XmlSchemaSet_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x000064B0 File Offset: 0x000046B0
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SqlByte>.NativeClassPtr, ref this));
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000DD8 RID: 3544 RVA: 0x000450A0 File Offset: 0x000432A0
		// (set) Token: 0x06000DD9 RID: 3545 RVA: 0x000064C2 File Offset: 0x000046C2
		public unsafe static int s_iBitNotByteMax
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SqlByte.NativeFieldInfoPtr_s_iBitNotByteMax, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlByte.NativeFieldInfoPtr_s_iBitNotByteMax, (void*)(&value));
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000DDA RID: 3546 RVA: 0x000450BC File Offset: 0x000432BC
		// (set) Token: 0x06000DDB RID: 3547 RVA: 0x000064D0 File Offset: 0x000046D0
		public unsafe static SqlByte Null
		{
			get
			{
				SqlByte sqlByte;
				IL2CPP.il2cpp_field_static_get_value(SqlByte.NativeFieldInfoPtr_Null, (void*)(&sqlByte));
				return sqlByte;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlByte.NativeFieldInfoPtr_Null, (void*)(&value));
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000DDC RID: 3548 RVA: 0x000450D8 File Offset: 0x000432D8
		// (set) Token: 0x06000DDD RID: 3549 RVA: 0x000064DE File Offset: 0x000046DE
		public unsafe static SqlByte Zero
		{
			get
			{
				SqlByte sqlByte;
				IL2CPP.il2cpp_field_static_get_value(SqlByte.NativeFieldInfoPtr_Zero, (void*)(&sqlByte));
				return sqlByte;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlByte.NativeFieldInfoPtr_Zero, (void*)(&value));
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000DDE RID: 3550 RVA: 0x000450F4 File Offset: 0x000432F4
		// (set) Token: 0x06000DDF RID: 3551 RVA: 0x000064EC File Offset: 0x000046EC
		public unsafe static SqlByte MinValue
		{
			get
			{
				SqlByte sqlByte;
				IL2CPP.il2cpp_field_static_get_value(SqlByte.NativeFieldInfoPtr_MinValue, (void*)(&sqlByte));
				return sqlByte;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlByte.NativeFieldInfoPtr_MinValue, (void*)(&value));
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000DE0 RID: 3552 RVA: 0x00045110 File Offset: 0x00043310
		// (set) Token: 0x06000DE1 RID: 3553 RVA: 0x000064FA File Offset: 0x000046FA
		public unsafe static SqlByte MaxValue
		{
			get
			{
				SqlByte sqlByte;
				IL2CPP.il2cpp_field_static_get_value(SqlByte.NativeFieldInfoPtr_MaxValue, (void*)(&sqlByte));
				return sqlByte;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlByte.NativeFieldInfoPtr_MaxValue, (void*)(&value));
			}
		}

		// Token: 0x04000B5F RID: 2911
		private static readonly IntPtr NativeFieldInfoPtr_m_fNotNull;

		// Token: 0x04000B60 RID: 2912
		private static readonly IntPtr NativeFieldInfoPtr_m_value;

		// Token: 0x04000B61 RID: 2913
		private static readonly IntPtr NativeFieldInfoPtr_s_iBitNotByteMax;

		// Token: 0x04000B62 RID: 2914
		private static readonly IntPtr NativeFieldInfoPtr_Null;

		// Token: 0x04000B63 RID: 2915
		private static readonly IntPtr NativeFieldInfoPtr_Zero;

		// Token: 0x04000B64 RID: 2916
		private static readonly IntPtr NativeFieldInfoPtr_MinValue;

		// Token: 0x04000B65 RID: 2917
		private static readonly IntPtr NativeFieldInfoPtr_MaxValue;

		// Token: 0x04000B66 RID: 2918
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Boolean_0;

		// Token: 0x04000B67 RID: 2919
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_0;

		// Token: 0x04000B68 RID: 2920
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNull_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000B69 RID: 2921
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Byte_0;

		// Token: 0x04000B6A RID: 2922
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SqlByte_Byte_0;

		// Token: 0x04000B6B RID: 2923
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000B6C RID: 2924
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_SqlByte_SqlByte_SqlByte_0;

		// Token: 0x04000B6D RID: 2925
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_SqlByte_SqlByte_SqlByte_0;

		// Token: 0x04000B6E RID: 2926
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_SqlByte_SqlByte_SqlByte_0;

		// Token: 0x04000B6F RID: 2927
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_SqlByte_SqlByte_SqlByte_0;

		// Token: 0x04000B70 RID: 2928
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_SqlByte_SqlInt64_0;

		// Token: 0x04000B71 RID: 2929
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_SqlBoolean_SqlByte_SqlByte_0;

		// Token: 0x04000B72 RID: 2930
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_SqlBoolean_SqlByte_SqlByte_0;

		// Token: 0x04000B73 RID: 2931
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_SqlBoolean_SqlByte_SqlByte_0;

		// Token: 0x04000B74 RID: 2932
		private static readonly IntPtr NativeMethodInfoPtr_LessThan_Public_Static_SqlBoolean_SqlByte_SqlByte_0;

		// Token: 0x04000B75 RID: 2933
		private static readonly IntPtr NativeMethodInfoPtr_GreaterThan_Public_Static_SqlBoolean_SqlByte_SqlByte_0;

		// Token: 0x04000B76 RID: 2934
		private static readonly IntPtr NativeMethodInfoPtr_ToSqlDouble_Public_SqlDouble_0;

		// Token: 0x04000B77 RID: 2935
		private static readonly IntPtr NativeMethodInfoPtr_ToSqlInt64_Public_SqlInt64_0;

		// Token: 0x04000B78 RID: 2936
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000B79 RID: 2937
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Int32_SqlByte_0;

		// Token: 0x04000B7A RID: 2938
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000B7B RID: 2939
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000B7C RID: 2940
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0;

		// Token: 0x04000B7D RID: 2941
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0;

		// Token: 0x04000B7E RID: 2942
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0;

		// Token: 0x04000B7F RID: 2943
		private static readonly IntPtr NativeMethodInfoPtr_GetXsdType_Public_Static_XmlQualifiedName_XmlSchemaSet_0;

		// Token: 0x04000B80 RID: 2944
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool m_fNotNull;

		// Token: 0x04000B81 RID: 2945
		[FieldOffset(1)]
		public byte m_value;
	}
}
