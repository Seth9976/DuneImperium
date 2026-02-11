using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Data.SqlTypes
{
	// Token: 0x02000097 RID: 151
	[Serializable]
	[StructLayout(2)]
	public struct SqlInt32
	{
		// Token: 0x06000F8C RID: 3980 RVA: 0x0004AD1C File Offset: 0x00048F1C
		// Note: this type is marked as 'beforefieldinit'.
		static SqlInt32()
		{
			Il2CppClassPointerStore<SqlInt32>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data.SqlTypes", "SqlInt32");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SqlInt32>.NativeClassPtr);
			SqlInt32.NativeFieldInfoPtr_m_fNotNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlInt32>.NativeClassPtr, "m_fNotNull");
			SqlInt32.NativeFieldInfoPtr_m_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlInt32>.NativeClassPtr, "m_value");
			SqlInt32.NativeFieldInfoPtr_s_iIntMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlInt32>.NativeClassPtr, "s_iIntMin");
			SqlInt32.NativeFieldInfoPtr_s_lBitNotIntMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlInt32>.NativeClassPtr, "s_lBitNotIntMax");
			SqlInt32.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlInt32>.NativeClassPtr, "Null");
			SqlInt32.NativeFieldInfoPtr_Zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlInt32>.NativeClassPtr, "Zero");
			SqlInt32.NativeFieldInfoPtr_MinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlInt32>.NativeClassPtr, "MinValue");
			SqlInt32.NativeFieldInfoPtr_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlInt32>.NativeClassPtr, "MaxValue");
			SqlInt32.NativeMethodInfoPtr__ctor_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt32>.NativeClassPtr, 100665789);
			SqlInt32.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt32>.NativeClassPtr, 100665790);
			SqlInt32.NativeMethodInfoPtr_get_IsNull_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt32>.NativeClassPtr, 100665791);
			SqlInt32.NativeMethodInfoPtr_get_Value_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt32>.NativeClassPtr, 100665792);
			SqlInt32.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt32>.NativeClassPtr, 100665793);
			SqlInt32.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt32>.NativeClassPtr, 100665794);
			SqlInt32.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_SqlInt32_SqlInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt32>.NativeClassPtr, 100665795);
			SqlInt32.NativeMethodInfoPtr_op_Addition_Public_Static_SqlInt32_SqlInt32_SqlInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt32>.NativeClassPtr, 100665796);
			SqlInt32.NativeMethodInfoPtr_op_Subtraction_Public_Static_SqlInt32_SqlInt32_SqlInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt32>.NativeClassPtr, 100665797);
			SqlInt32.NativeMethodInfoPtr_op_Multiply_Public_Static_SqlInt32_SqlInt32_SqlInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt32>.NativeClassPtr, 100665798);
			SqlInt32.NativeMethodInfoPtr_op_Division_Public_Static_SqlInt32_SqlInt32_SqlInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt32>.NativeClassPtr, 100665799);
			SqlInt32.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlInt32_SqlByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt32>.NativeClassPtr, 100665800);
			SqlInt32.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlInt32_SqlInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt32>.NativeClassPtr, 100665801);
			SqlInt32.NativeMethodInfoPtr_op_Explicit_Public_Static_SqlInt32_SqlInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt32>.NativeClassPtr, 100665802);
			SqlInt32.NativeMethodInfoPtr_SameSignInt_Private_Static_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt32>.NativeClassPtr, 100665803);
			SqlInt32.NativeMethodInfoPtr_op_Equality_Public_Static_SqlBoolean_SqlInt32_SqlInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt32>.NativeClassPtr, 100665804);
			SqlInt32.NativeMethodInfoPtr_op_LessThan_Public_Static_SqlBoolean_SqlInt32_SqlInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt32>.NativeClassPtr, 100665805);
			SqlInt32.NativeMethodInfoPtr_op_GreaterThan_Public_Static_SqlBoolean_SqlInt32_SqlInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt32>.NativeClassPtr, 100665806);
			SqlInt32.NativeMethodInfoPtr_LessThan_Public_Static_SqlBoolean_SqlInt32_SqlInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt32>.NativeClassPtr, 100665807);
			SqlInt32.NativeMethodInfoPtr_GreaterThan_Public_Static_SqlBoolean_SqlInt32_SqlInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt32>.NativeClassPtr, 100665808);
			SqlInt32.NativeMethodInfoPtr_ToSqlDouble_Public_SqlDouble_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt32>.NativeClassPtr, 100665809);
			SqlInt32.NativeMethodInfoPtr_ToSqlInt64_Public_SqlInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt32>.NativeClassPtr, 100665810);
			SqlInt32.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt32>.NativeClassPtr, 100665811);
			SqlInt32.NativeMethodInfoPtr_CompareTo_Public_Int32_SqlInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt32>.NativeClassPtr, 100665812);
			SqlInt32.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt32>.NativeClassPtr, 100665813);
			SqlInt32.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt32>.NativeClassPtr, 100665814);
			SqlInt32.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt32>.NativeClassPtr, 100665815);
			SqlInt32.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt32>.NativeClassPtr, 100665816);
			SqlInt32.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt32>.NativeClassPtr, 100665817);
			SqlInt32.NativeMethodInfoPtr_GetXsdType_Public_Static_XmlQualifiedName_XmlSchemaSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt32>.NativeClassPtr, 100665818);
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x0004B044 File Offset: 0x00049244
		[CallerCount(0)]
		public unsafe SqlInt32(bool fNull)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fNull;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt32.NativeMethodInfoPtr__ctor_Private_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x0004B078 File Offset: 0x00049278
		[CallerCount(2754)]
		[CachedScanResults(RefRangeStart = 787572, RefRangeEnd = 790326, XrefRangeStart = 787572, XrefRangeEnd = 790326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlInt32(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt32.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000F8F RID: 3983 RVA: 0x0004B0AC File Offset: 0x000492AC
		public unsafe bool IsNull
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 786806, RefRangeEnd = 786824, XrefRangeStart = 786806, XrefRangeEnd = 786824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt32.NativeMethodInfoPtr_get_IsNull_Public_Virtual_Final_New_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000F90 RID: 3984 RVA: 0x0004B0DC File Offset: 0x000492DC
		public unsafe int Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918594, XrefRangeEnd = 918597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt32.NativeMethodInfoPtr_get_Value_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x0004B10C File Offset: 0x0004930C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 790378, RefRangeEnd = 790387, XrefRangeStart = 790378, XrefRangeEnd = 790387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SqlInt32(int x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt32.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x0004B14C File Offset: 0x0004934C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918597, XrefRangeEnd = 918609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt32.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x0004B178 File Offset: 0x00049378
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 918615, RefRangeEnd = 918616, XrefRangeStart = 918609, XrefRangeEnd = 918615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlInt32 operator -(SqlInt32 x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt32.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_SqlInt32_SqlInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x0004B1B8 File Offset: 0x000493B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918616, XrefRangeEnd = 918625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlInt32 operator +(SqlInt32 x, SqlInt32 y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt32.NativeMethodInfoPtr_op_Addition_Public_Static_SqlInt32_SqlInt32_SqlInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x0004B204 File Offset: 0x00049404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918625, XrefRangeEnd = 918634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlInt32 operator -(SqlInt32 x, SqlInt32 y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt32.NativeMethodInfoPtr_op_Subtraction_Public_Static_SqlInt32_SqlInt32_SqlInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x0004B250 File Offset: 0x00049450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918634, XrefRangeEnd = 918644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlInt32 operator *(SqlInt32 x, SqlInt32 y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt32.NativeMethodInfoPtr_op_Multiply_Public_Static_SqlInt32_SqlInt32_SqlInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x0004B29C File Offset: 0x0004949C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918644, XrefRangeEnd = 918652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlInt32 operator /(SqlInt32 x, SqlInt32 y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt32.NativeMethodInfoPtr_op_Division_Public_Static_SqlInt32_SqlInt32_SqlInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x0004B2E8 File Offset: 0x000494E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918652, XrefRangeEnd = 918660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SqlInt32(SqlByte x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt32.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlInt32_SqlByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x0004B328 File Offset: 0x00049528
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 918668, RefRangeEnd = 918669, XrefRangeStart = 918660, XrefRangeEnd = 918668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SqlInt32(SqlInt16 x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt32.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlInt32_SqlInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x0004B368 File Offset: 0x00049568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918669, XrefRangeEnd = 918675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator SqlInt32(SqlInt64 x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt32.NativeMethodInfoPtr_op_Explicit_Public_Static_SqlInt32_SqlInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x0004B3A8 File Offset: 0x000495A8
		[CallerCount(0)]
		public unsafe static bool SameSignInt(int x, int y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt32.NativeMethodInfoPtr_SameSignInt_Private_Static_Boolean_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x0004B3F4 File Offset: 0x000495F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918675, XrefRangeEnd = 918682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean operator ==(SqlInt32 x, SqlInt32 y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt32.NativeMethodInfoPtr_op_Equality_Public_Static_SqlBoolean_SqlInt32_SqlInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x0004B440 File Offset: 0x00049640
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 918689, RefRangeEnd = 918691, XrefRangeStart = 918682, XrefRangeEnd = 918689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean operator <(SqlInt32 x, SqlInt32 y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt32.NativeMethodInfoPtr_op_LessThan_Public_Static_SqlBoolean_SqlInt32_SqlInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x0004B48C File Offset: 0x0004968C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 918698, RefRangeEnd = 918700, XrefRangeStart = 918691, XrefRangeEnd = 918698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean operator >(SqlInt32 x, SqlInt32 y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt32.NativeMethodInfoPtr_op_GreaterThan_Public_Static_SqlBoolean_SqlInt32_SqlInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x0004B4D8 File Offset: 0x000496D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 918704, RefRangeEnd = 918705, XrefRangeStart = 918700, XrefRangeEnd = 918704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean LessThan(SqlInt32 x, SqlInt32 y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt32.NativeMethodInfoPtr_LessThan_Public_Static_SqlBoolean_SqlInt32_SqlInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x0004B524 File Offset: 0x00049724
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 918709, RefRangeEnd = 918710, XrefRangeStart = 918705, XrefRangeEnd = 918709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean GreaterThan(SqlInt32 x, SqlInt32 y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt32.NativeMethodInfoPtr_GreaterThan_Public_Static_SqlBoolean_SqlInt32_SqlInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x0004B570 File Offset: 0x00049770
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 918720, RefRangeEnd = 918723, XrefRangeStart = 918710, XrefRangeEnd = 918720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlDouble ToSqlDouble()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt32.NativeMethodInfoPtr_ToSqlDouble_Public_SqlDouble_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x0004B5A0 File Offset: 0x000497A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 918733, RefRangeEnd = 918734, XrefRangeStart = 918723, XrefRangeEnd = 918733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlInt64 ToSqlInt64()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt32.NativeMethodInfoPtr_ToSqlInt64_Public_SqlInt64_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FA3 RID: 4003 RVA: 0x0004B5D0 File Offset: 0x000497D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918734, XrefRangeEnd = 918752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt32.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FA4 RID: 4004 RVA: 0x0004B614 File Offset: 0x00049814
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 918770, RefRangeEnd = 918774, XrefRangeStart = 918752, XrefRangeEnd = 918770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(SqlInt32 value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt32.NativeMethodInfoPtr_CompareTo_Public_Int32_SqlInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x0004B654 File Offset: 0x00049854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918774, XrefRangeEnd = 918799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt32.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x0004B698 File Offset: 0x00049898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918799, XrefRangeEnd = 918803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt32.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x0004B6C8 File Offset: 0x000498C8
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchema System_Xml_Serialization_IXmlSerializable_GetSchema()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt32.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x0004B6FC File Offset: 0x000498FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918803, XrefRangeEnd = 918811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Xml_Serialization_IXmlSerializable_ReadXml(XmlReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt32.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x0004B734 File Offset: 0x00049934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918811, XrefRangeEnd = 918827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Xml_Serialization_IXmlSerializable_WriteXml(XmlWriter writer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt32.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x0004B76C File Offset: 0x0004996C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918827, XrefRangeEnd = 918835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaSet);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt32.NativeMethodInfoPtr_GetXsdType_Public_Static_XmlQualifiedName_XmlSchemaSet_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x00006BE3 File Offset: 0x00004DE3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SqlInt32>.NativeClassPtr, ref this));
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000FAC RID: 4012 RVA: 0x0004B7B0 File Offset: 0x000499B0
		// (set) Token: 0x06000FAD RID: 4013 RVA: 0x00006BF5 File Offset: 0x00004DF5
		public unsafe static long s_iIntMin
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(SqlInt32.NativeFieldInfoPtr_s_iIntMin, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlInt32.NativeFieldInfoPtr_s_iIntMin, (void*)(&value));
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000FAE RID: 4014 RVA: 0x0004B7CC File Offset: 0x000499CC
		// (set) Token: 0x06000FAF RID: 4015 RVA: 0x00006C03 File Offset: 0x00004E03
		public unsafe static long s_lBitNotIntMax
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(SqlInt32.NativeFieldInfoPtr_s_lBitNotIntMax, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlInt32.NativeFieldInfoPtr_s_lBitNotIntMax, (void*)(&value));
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000FB0 RID: 4016 RVA: 0x0004B7E8 File Offset: 0x000499E8
		// (set) Token: 0x06000FB1 RID: 4017 RVA: 0x00006C11 File Offset: 0x00004E11
		public unsafe static SqlInt32 Null
		{
			get
			{
				SqlInt32 sqlInt;
				IL2CPP.il2cpp_field_static_get_value(SqlInt32.NativeFieldInfoPtr_Null, (void*)(&sqlInt));
				return sqlInt;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlInt32.NativeFieldInfoPtr_Null, (void*)(&value));
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000FB2 RID: 4018 RVA: 0x0004B804 File Offset: 0x00049A04
		// (set) Token: 0x06000FB3 RID: 4019 RVA: 0x00006C1F File Offset: 0x00004E1F
		public unsafe static SqlInt32 Zero
		{
			get
			{
				SqlInt32 sqlInt;
				IL2CPP.il2cpp_field_static_get_value(SqlInt32.NativeFieldInfoPtr_Zero, (void*)(&sqlInt));
				return sqlInt;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlInt32.NativeFieldInfoPtr_Zero, (void*)(&value));
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000FB4 RID: 4020 RVA: 0x0004B820 File Offset: 0x00049A20
		// (set) Token: 0x06000FB5 RID: 4021 RVA: 0x00006C2D File Offset: 0x00004E2D
		public unsafe static SqlInt32 MinValue
		{
			get
			{
				SqlInt32 sqlInt;
				IL2CPP.il2cpp_field_static_get_value(SqlInt32.NativeFieldInfoPtr_MinValue, (void*)(&sqlInt));
				return sqlInt;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlInt32.NativeFieldInfoPtr_MinValue, (void*)(&value));
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000FB6 RID: 4022 RVA: 0x0004B83C File Offset: 0x00049A3C
		// (set) Token: 0x06000FB7 RID: 4023 RVA: 0x00006C3B File Offset: 0x00004E3B
		public unsafe static SqlInt32 MaxValue
		{
			get
			{
				SqlInt32 sqlInt;
				IL2CPP.il2cpp_field_static_get_value(SqlInt32.NativeFieldInfoPtr_MaxValue, (void*)(&sqlInt));
				return sqlInt;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlInt32.NativeFieldInfoPtr_MaxValue, (void*)(&value));
			}
		}

		// Token: 0x04000CDA RID: 3290
		private static readonly IntPtr NativeFieldInfoPtr_m_fNotNull;

		// Token: 0x04000CDB RID: 3291
		private static readonly IntPtr NativeFieldInfoPtr_m_value;

		// Token: 0x04000CDC RID: 3292
		private static readonly IntPtr NativeFieldInfoPtr_s_iIntMin;

		// Token: 0x04000CDD RID: 3293
		private static readonly IntPtr NativeFieldInfoPtr_s_lBitNotIntMax;

		// Token: 0x04000CDE RID: 3294
		private static readonly IntPtr NativeFieldInfoPtr_Null;

		// Token: 0x04000CDF RID: 3295
		private static readonly IntPtr NativeFieldInfoPtr_Zero;

		// Token: 0x04000CE0 RID: 3296
		private static readonly IntPtr NativeFieldInfoPtr_MinValue;

		// Token: 0x04000CE1 RID: 3297
		private static readonly IntPtr NativeFieldInfoPtr_MaxValue;

		// Token: 0x04000CE2 RID: 3298
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Boolean_0;

		// Token: 0x04000CE3 RID: 3299
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000CE4 RID: 3300
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNull_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000CE5 RID: 3301
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Int32_0;

		// Token: 0x04000CE6 RID: 3302
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SqlInt32_Int32_0;

		// Token: 0x04000CE7 RID: 3303
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000CE8 RID: 3304
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_SqlInt32_SqlInt32_0;

		// Token: 0x04000CE9 RID: 3305
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_SqlInt32_SqlInt32_SqlInt32_0;

		// Token: 0x04000CEA RID: 3306
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_SqlInt32_SqlInt32_SqlInt32_0;

		// Token: 0x04000CEB RID: 3307
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_SqlInt32_SqlInt32_SqlInt32_0;

		// Token: 0x04000CEC RID: 3308
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_SqlInt32_SqlInt32_SqlInt32_0;

		// Token: 0x04000CED RID: 3309
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SqlInt32_SqlByte_0;

		// Token: 0x04000CEE RID: 3310
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SqlInt32_SqlInt16_0;

		// Token: 0x04000CEF RID: 3311
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_SqlInt32_SqlInt64_0;

		// Token: 0x04000CF0 RID: 3312
		private static readonly IntPtr NativeMethodInfoPtr_SameSignInt_Private_Static_Boolean_Int32_Int32_0;

		// Token: 0x04000CF1 RID: 3313
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_SqlBoolean_SqlInt32_SqlInt32_0;

		// Token: 0x04000CF2 RID: 3314
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_SqlBoolean_SqlInt32_SqlInt32_0;

		// Token: 0x04000CF3 RID: 3315
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_SqlBoolean_SqlInt32_SqlInt32_0;

		// Token: 0x04000CF4 RID: 3316
		private static readonly IntPtr NativeMethodInfoPtr_LessThan_Public_Static_SqlBoolean_SqlInt32_SqlInt32_0;

		// Token: 0x04000CF5 RID: 3317
		private static readonly IntPtr NativeMethodInfoPtr_GreaterThan_Public_Static_SqlBoolean_SqlInt32_SqlInt32_0;

		// Token: 0x04000CF6 RID: 3318
		private static readonly IntPtr NativeMethodInfoPtr_ToSqlDouble_Public_SqlDouble_0;

		// Token: 0x04000CF7 RID: 3319
		private static readonly IntPtr NativeMethodInfoPtr_ToSqlInt64_Public_SqlInt64_0;

		// Token: 0x04000CF8 RID: 3320
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000CF9 RID: 3321
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Int32_SqlInt32_0;

		// Token: 0x04000CFA RID: 3322
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000CFB RID: 3323
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000CFC RID: 3324
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0;

		// Token: 0x04000CFD RID: 3325
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0;

		// Token: 0x04000CFE RID: 3326
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0;

		// Token: 0x04000CFF RID: 3327
		private static readonly IntPtr NativeMethodInfoPtr_GetXsdType_Public_Static_XmlQualifiedName_XmlSchemaSet_0;

		// Token: 0x04000D00 RID: 3328
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool m_fNotNull;

		// Token: 0x04000D01 RID: 3329
		[FieldOffset(4)]
		public int m_value;
	}
}
