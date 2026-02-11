using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Data.SqlTypes;

namespace Il2CppSystem.Data.Common
{
	// Token: 0x020000B4 RID: 180
	public static class SqlConvert : Object
	{
		// Token: 0x06001259 RID: 4697 RVA: 0x00057710 File Offset: 0x00055910
		// Note: this type is marked as 'beforefieldinit'.
		static SqlConvert()
		{
			Il2CppClassPointerStore<SqlConvert>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data.Common", "SqlConvert");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SqlConvert>.NativeClassPtr);
			SqlConvert.NativeMethodInfoPtr_ConvertToSqlByte_Public_Static_SqlByte_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlConvert>.NativeClassPtr, 100666270);
			SqlConvert.NativeMethodInfoPtr_ConvertToSqlInt16_Public_Static_SqlInt16_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlConvert>.NativeClassPtr, 100666271);
			SqlConvert.NativeMethodInfoPtr_ConvertToSqlInt32_Public_Static_SqlInt32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlConvert>.NativeClassPtr, 100666272);
			SqlConvert.NativeMethodInfoPtr_ConvertToSqlInt64_Public_Static_SqlInt64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlConvert>.NativeClassPtr, 100666273);
			SqlConvert.NativeMethodInfoPtr_ConvertToSqlDouble_Public_Static_SqlDouble_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlConvert>.NativeClassPtr, 100666274);
			SqlConvert.NativeMethodInfoPtr_ConvertToSqlDecimal_Public_Static_SqlDecimal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlConvert>.NativeClassPtr, 100666275);
			SqlConvert.NativeMethodInfoPtr_ConvertToSqlSingle_Public_Static_SqlSingle_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlConvert>.NativeClassPtr, 100666276);
			SqlConvert.NativeMethodInfoPtr_ConvertToSqlMoney_Public_Static_SqlMoney_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlConvert>.NativeClassPtr, 100666277);
			SqlConvert.NativeMethodInfoPtr_ConvertToSqlDateTime_Public_Static_SqlDateTime_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlConvert>.NativeClassPtr, 100666278);
			SqlConvert.NativeMethodInfoPtr_ConvertToSqlBoolean_Public_Static_SqlBoolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlConvert>.NativeClassPtr, 100666279);
			SqlConvert.NativeMethodInfoPtr_ConvertToSqlGuid_Public_Static_SqlGuid_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlConvert>.NativeClassPtr, 100666280);
			SqlConvert.NativeMethodInfoPtr_ConvertToSqlBinary_Public_Static_SqlBinary_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlConvert>.NativeClassPtr, 100666281);
			SqlConvert.NativeMethodInfoPtr_ConvertToSqlString_Public_Static_SqlString_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlConvert>.NativeClassPtr, 100666282);
			SqlConvert.NativeMethodInfoPtr_ConvertToSqlChars_Public_Static_SqlChars_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlConvert>.NativeClassPtr, 100666283);
			SqlConvert.NativeMethodInfoPtr_ConvertToSqlBytes_Public_Static_SqlBytes_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlConvert>.NativeClassPtr, 100666284);
			SqlConvert.NativeMethodInfoPtr_ConvertStringToDateTimeOffset_Public_Static_DateTimeOffset_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlConvert>.NativeClassPtr, 100666285);
			SqlConvert.NativeMethodInfoPtr_ChangeTypeForDefaultValue_Public_Static_Object_Object_Type_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlConvert>.NativeClassPtr, 100666286);
			SqlConvert.NativeMethodInfoPtr_ChangeType2_Public_Static_Object_Object_StorageType_Type_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlConvert>.NativeClassPtr, 100666287);
			SqlConvert.NativeMethodInfoPtr_ChangeTypeForXML_Public_Static_Object_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlConvert>.NativeClassPtr, 100666288);
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x000578BC File Offset: 0x00055ABC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 923952, RefRangeEnd = 923954, XrefRangeStart = 923934, XrefRangeEnd = 923952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlByte ConvertToSqlByte(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlConvert.NativeMethodInfoPtr_ConvertToSqlByte_Public_Static_SqlByte_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x00057900 File Offset: 0x00055B00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 923974, RefRangeEnd = 923976, XrefRangeStart = 923954, XrefRangeEnd = 923974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlInt16 ConvertToSqlInt16(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlConvert.NativeMethodInfoPtr_ConvertToSqlInt16_Public_Static_SqlInt16_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x00057944 File Offset: 0x00055B44
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 923999, RefRangeEnd = 924003, XrefRangeStart = 923976, XrefRangeEnd = 923999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlInt32 ConvertToSqlInt32(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlConvert.NativeMethodInfoPtr_ConvertToSqlInt32_Public_Static_SqlInt32_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x00057988 File Offset: 0x00055B88
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 924052, RefRangeEnd = 924056, XrefRangeStart = 924003, XrefRangeEnd = 924052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlInt64 ConvertToSqlInt64(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlConvert.NativeMethodInfoPtr_ConvertToSqlInt64_Public_Static_SqlInt64_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x000579CC File Offset: 0x00055BCC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 924127, RefRangeEnd = 924131, XrefRangeStart = 924056, XrefRangeEnd = 924127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlDouble ConvertToSqlDouble(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlConvert.NativeMethodInfoPtr_ConvertToSqlDouble_Public_Static_SqlDouble_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x00057A10 File Offset: 0x00055C10
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 924184, RefRangeEnd = 924188, XrefRangeStart = 924131, XrefRangeEnd = 924184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlDecimal ConvertToSqlDecimal(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlConvert.NativeMethodInfoPtr_ConvertToSqlDecimal_Public_Static_SqlDecimal_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x00057A54 File Offset: 0x00055C54
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 924262, RefRangeEnd = 924266, XrefRangeStart = 924188, XrefRangeEnd = 924262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlSingle ConvertToSqlSingle(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlConvert.NativeMethodInfoPtr_ConvertToSqlSingle_Public_Static_SqlSingle_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x00057A98 File Offset: 0x00055C98
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 924318, RefRangeEnd = 924322, XrefRangeStart = 924266, XrefRangeEnd = 924318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlMoney ConvertToSqlMoney(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlConvert.NativeMethodInfoPtr_ConvertToSqlMoney_Public_Static_SqlMoney_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x00057ADC File Offset: 0x00055CDC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 924341, RefRangeEnd = 924345, XrefRangeStart = 924322, XrefRangeEnd = 924341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlDateTime ConvertToSqlDateTime(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlConvert.NativeMethodInfoPtr_ConvertToSqlDateTime_Public_Static_SqlDateTime_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x00057B20 File Offset: 0x00055D20
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 924363, RefRangeEnd = 924367, XrefRangeStart = 924345, XrefRangeEnd = 924363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean ConvertToSqlBoolean(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlConvert.NativeMethodInfoPtr_ConvertToSqlBoolean_Public_Static_SqlBoolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x00057B64 File Offset: 0x00055D64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 924383, RefRangeEnd = 924385, XrefRangeStart = 924367, XrefRangeEnd = 924383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlGuid ConvertToSqlGuid(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlConvert.NativeMethodInfoPtr_ConvertToSqlGuid_Public_Static_SqlGuid_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new SqlGuid(intPtr);
			}
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x00057BA0 File Offset: 0x00055DA0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 924403, RefRangeEnd = 924407, XrefRangeStart = 924385, XrefRangeEnd = 924403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBinary ConvertToSqlBinary(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlConvert.NativeMethodInfoPtr_ConvertToSqlBinary_Public_Static_SqlBinary_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new SqlBinary(intPtr);
			}
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x00057BDC File Offset: 0x00055DDC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 924425, RefRangeEnd = 924428, XrefRangeStart = 924407, XrefRangeEnd = 924425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlString ConvertToSqlString(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlConvert.NativeMethodInfoPtr_ConvertToSqlString_Public_Static_SqlString_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new SqlString(intPtr);
			}
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x00057C18 File Offset: 0x00055E18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924428, XrefRangeEnd = 924441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlChars ConvertToSqlChars(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlConvert.NativeMethodInfoPtr_ConvertToSqlChars_Public_Static_SqlChars_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SqlChars>(intPtr3) : null;
			}
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x00057C5C File Offset: 0x00055E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924441, XrefRangeEnd = 924454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBytes ConvertToSqlBytes(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlConvert.NativeMethodInfoPtr_ConvertToSqlBytes_Public_Static_SqlBytes_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SqlBytes>(intPtr3) : null;
			}
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x00057CA0 File Offset: 0x00055EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924454, XrefRangeEnd = 924458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeOffset ConvertStringToDateTimeOffset(string value, IFormatProvider formatProvider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlConvert.NativeMethodInfoPtr_ConvertStringToDateTimeOffset_Public_Static_DateTimeOffset_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x00057CF4 File Offset: 0x00055EF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 924486, RefRangeEnd = 924488, XrefRangeStart = 924458, XrefRangeEnd = 924486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ChangeTypeForDefaultValue(Object value, Type type, IFormatProvider formatProvider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlConvert.NativeMethodInfoPtr_ChangeTypeForDefaultValue_Public_Static_Object_Object_Type_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x00057D5C File Offset: 0x00055F5C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 924727, RefRangeEnd = 924730, XrefRangeStart = 924488, XrefRangeEnd = 924727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ChangeType2(Object value, StorageType stype, Type type, IFormatProvider formatProvider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stype;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlConvert.NativeMethodInfoPtr_ChangeType2_Public_Static_Object_Object_StorageType_Type_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x00057DD4 File Offset: 0x00055FD4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 924793, RefRangeEnd = 924797, XrefRangeStart = 924730, XrefRangeEnd = 924793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ChangeTypeForXML(Object value, Type type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlConvert.NativeMethodInfoPtr_ChangeTypeForXML_Public_Static_Object_Object_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x00007507 File Offset: 0x00005707
		public SqlConvert(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F58 RID: 3928
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToSqlByte_Public_Static_SqlByte_Object_0;

		// Token: 0x04000F59 RID: 3929
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToSqlInt16_Public_Static_SqlInt16_Object_0;

		// Token: 0x04000F5A RID: 3930
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToSqlInt32_Public_Static_SqlInt32_Object_0;

		// Token: 0x04000F5B RID: 3931
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToSqlInt64_Public_Static_SqlInt64_Object_0;

		// Token: 0x04000F5C RID: 3932
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToSqlDouble_Public_Static_SqlDouble_Object_0;

		// Token: 0x04000F5D RID: 3933
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToSqlDecimal_Public_Static_SqlDecimal_Object_0;

		// Token: 0x04000F5E RID: 3934
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToSqlSingle_Public_Static_SqlSingle_Object_0;

		// Token: 0x04000F5F RID: 3935
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToSqlMoney_Public_Static_SqlMoney_Object_0;

		// Token: 0x04000F60 RID: 3936
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToSqlDateTime_Public_Static_SqlDateTime_Object_0;

		// Token: 0x04000F61 RID: 3937
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToSqlBoolean_Public_Static_SqlBoolean_Object_0;

		// Token: 0x04000F62 RID: 3938
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToSqlGuid_Public_Static_SqlGuid_Object_0;

		// Token: 0x04000F63 RID: 3939
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToSqlBinary_Public_Static_SqlBinary_Object_0;

		// Token: 0x04000F64 RID: 3940
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToSqlString_Public_Static_SqlString_Object_0;

		// Token: 0x04000F65 RID: 3941
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToSqlChars_Public_Static_SqlChars_Object_0;

		// Token: 0x04000F66 RID: 3942
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToSqlBytes_Public_Static_SqlBytes_Object_0;

		// Token: 0x04000F67 RID: 3943
		private static readonly IntPtr NativeMethodInfoPtr_ConvertStringToDateTimeOffset_Public_Static_DateTimeOffset_String_IFormatProvider_0;

		// Token: 0x04000F68 RID: 3944
		private static readonly IntPtr NativeMethodInfoPtr_ChangeTypeForDefaultValue_Public_Static_Object_Object_Type_IFormatProvider_0;

		// Token: 0x04000F69 RID: 3945
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType2_Public_Static_Object_Object_StorageType_Type_IFormatProvider_0;

		// Token: 0x04000F6A RID: 3946
		private static readonly IntPtr NativeMethodInfoPtr_ChangeTypeForXML_Public_Static_Object_Object_Type_0;
	}
}
