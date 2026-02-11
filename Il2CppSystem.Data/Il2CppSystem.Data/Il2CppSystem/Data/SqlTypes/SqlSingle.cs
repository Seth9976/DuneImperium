using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Data.SqlTypes
{
	// Token: 0x0200009A RID: 154
	[Serializable]
	[StructLayout(2)]
	public struct SqlSingle
	{
		// Token: 0x06001022 RID: 4130 RVA: 0x0004D2E8 File Offset: 0x0004B4E8
		// Note: this type is marked as 'beforefieldinit'.
		static SqlSingle()
		{
			Il2CppClassPointerStore<SqlSingle>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data.SqlTypes", "SqlSingle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SqlSingle>.NativeClassPtr);
			SqlSingle.NativeFieldInfoPtr__fNotNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlSingle>.NativeClassPtr, "_fNotNull");
			SqlSingle.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlSingle>.NativeClassPtr, "_value");
			SqlSingle.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlSingle>.NativeClassPtr, "Null");
			SqlSingle.NativeFieldInfoPtr_Zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlSingle>.NativeClassPtr, "Zero");
			SqlSingle.NativeFieldInfoPtr_MinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlSingle>.NativeClassPtr, "MinValue");
			SqlSingle.NativeFieldInfoPtr_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlSingle>.NativeClassPtr, "MaxValue");
			SqlSingle.NativeMethodInfoPtr__ctor_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingle>.NativeClassPtr, 100665894);
			SqlSingle.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingle>.NativeClassPtr, 100665895);
			SqlSingle.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingle>.NativeClassPtr, 100665896);
			SqlSingle.NativeMethodInfoPtr_get_IsNull_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingle>.NativeClassPtr, 100665897);
			SqlSingle.NativeMethodInfoPtr_get_Value_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingle>.NativeClassPtr, 100665898);
			SqlSingle.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlSingle_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingle>.NativeClassPtr, 100665899);
			SqlSingle.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingle>.NativeClassPtr, 100665900);
			SqlSingle.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_SqlSingle_SqlSingle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingle>.NativeClassPtr, 100665901);
			SqlSingle.NativeMethodInfoPtr_op_Addition_Public_Static_SqlSingle_SqlSingle_SqlSingle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingle>.NativeClassPtr, 100665902);
			SqlSingle.NativeMethodInfoPtr_op_Subtraction_Public_Static_SqlSingle_SqlSingle_SqlSingle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingle>.NativeClassPtr, 100665903);
			SqlSingle.NativeMethodInfoPtr_op_Multiply_Public_Static_SqlSingle_SqlSingle_SqlSingle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingle>.NativeClassPtr, 100665904);
			SqlSingle.NativeMethodInfoPtr_op_Division_Public_Static_SqlSingle_SqlSingle_SqlSingle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingle>.NativeClassPtr, 100665905);
			SqlSingle.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlSingle_SqlByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingle>.NativeClassPtr, 100665906);
			SqlSingle.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlSingle_SqlInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingle>.NativeClassPtr, 100665907);
			SqlSingle.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlSingle_SqlInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingle>.NativeClassPtr, 100665908);
			SqlSingle.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlSingle_SqlInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingle>.NativeClassPtr, 100665909);
			SqlSingle.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlSingle_SqlMoney_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingle>.NativeClassPtr, 100665910);
			SqlSingle.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlSingle_SqlDecimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingle>.NativeClassPtr, 100665911);
			SqlSingle.NativeMethodInfoPtr_op_Explicit_Public_Static_SqlSingle_SqlDouble_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingle>.NativeClassPtr, 100665912);
			SqlSingle.NativeMethodInfoPtr_op_Equality_Public_Static_SqlBoolean_SqlSingle_SqlSingle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingle>.NativeClassPtr, 100665913);
			SqlSingle.NativeMethodInfoPtr_op_LessThan_Public_Static_SqlBoolean_SqlSingle_SqlSingle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingle>.NativeClassPtr, 100665914);
			SqlSingle.NativeMethodInfoPtr_op_GreaterThan_Public_Static_SqlBoolean_SqlSingle_SqlSingle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingle>.NativeClassPtr, 100665915);
			SqlSingle.NativeMethodInfoPtr_LessThan_Public_Static_SqlBoolean_SqlSingle_SqlSingle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingle>.NativeClassPtr, 100665916);
			SqlSingle.NativeMethodInfoPtr_GreaterThan_Public_Static_SqlBoolean_SqlSingle_SqlSingle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingle>.NativeClassPtr, 100665917);
			SqlSingle.NativeMethodInfoPtr_ToSqlDouble_Public_SqlDouble_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingle>.NativeClassPtr, 100665918);
			SqlSingle.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingle>.NativeClassPtr, 100665919);
			SqlSingle.NativeMethodInfoPtr_CompareTo_Public_Int32_SqlSingle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingle>.NativeClassPtr, 100665920);
			SqlSingle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingle>.NativeClassPtr, 100665921);
			SqlSingle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingle>.NativeClassPtr, 100665922);
			SqlSingle.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingle>.NativeClassPtr, 100665923);
			SqlSingle.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingle>.NativeClassPtr, 100665924);
			SqlSingle.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingle>.NativeClassPtr, 100665925);
			SqlSingle.NativeMethodInfoPtr_GetXsdType_Public_Static_XmlQualifiedName_XmlSchemaSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingle>.NativeClassPtr, 100665926);
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x0004D624 File Offset: 0x0004B824
		[CallerCount(0)]
		public unsafe SqlSingle(bool fNull)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fNull;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingle.NativeMethodInfoPtr__ctor_Private_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x0004D658 File Offset: 0x0004B858
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 919579, RefRangeEnd = 919581, XrefRangeStart = 919579, XrefRangeEnd = 919579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlSingle(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingle.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x0004D68C File Offset: 0x0004B88C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919581, XrefRangeEnd = 919585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlSingle(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingle.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06001026 RID: 4134 RVA: 0x0004D6C0 File Offset: 0x0004B8C0
		public unsafe bool IsNull
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 786806, RefRangeEnd = 786824, XrefRangeStart = 786806, XrefRangeEnd = 786824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingle.NativeMethodInfoPtr_get_IsNull_Public_Virtual_Final_New_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06001027 RID: 4135 RVA: 0x0004D6F0 File Offset: 0x0004B8F0
		public unsafe float Value
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingle.NativeMethodInfoPtr_get_Value_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x0004D720 File Offset: 0x0004B920
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 919585, RefRangeEnd = 919594, XrefRangeStart = 919585, XrefRangeEnd = 919585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SqlSingle(float x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingle.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlSingle_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x0004D760 File Offset: 0x0004B960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919594, XrefRangeEnd = 919604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingle.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x0004D78C File Offset: 0x0004B98C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 919610, RefRangeEnd = 919611, XrefRangeStart = 919604, XrefRangeEnd = 919610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlSingle operator -(SqlSingle x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingle.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_SqlSingle_SqlSingle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x0004D7CC File Offset: 0x0004B9CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 919617, RefRangeEnd = 919618, XrefRangeStart = 919611, XrefRangeEnd = 919617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlSingle operator +(SqlSingle x, SqlSingle y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingle.NativeMethodInfoPtr_op_Addition_Public_Static_SqlSingle_SqlSingle_SqlSingle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x0004D818 File Offset: 0x0004BA18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919618, XrefRangeEnd = 919624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlSingle operator -(SqlSingle x, SqlSingle y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingle.NativeMethodInfoPtr_op_Subtraction_Public_Static_SqlSingle_SqlSingle_SqlSingle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x0004D864 File Offset: 0x0004BA64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919624, XrefRangeEnd = 919630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlSingle operator *(SqlSingle x, SqlSingle y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingle.NativeMethodInfoPtr_op_Multiply_Public_Static_SqlSingle_SqlSingle_SqlSingle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x0004D8B0 File Offset: 0x0004BAB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919630, XrefRangeEnd = 919637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlSingle operator /(SqlSingle x, SqlSingle y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingle.NativeMethodInfoPtr_op_Division_Public_Static_SqlSingle_SqlSingle_SqlSingle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x0004D8FC File Offset: 0x0004BAFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 919645, RefRangeEnd = 919646, XrefRangeStart = 919637, XrefRangeEnd = 919645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SqlSingle(SqlByte x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingle.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlSingle_SqlByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x0004D93C File Offset: 0x0004BB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919646, XrefRangeEnd = 919654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SqlSingle(SqlInt16 x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingle.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlSingle_SqlInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x0004D97C File Offset: 0x0004BB7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919654, XrefRangeEnd = 919661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SqlSingle(SqlInt32 x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingle.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlSingle_SqlInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x0004D9BC File Offset: 0x0004BBBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919661, XrefRangeEnd = 919669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SqlSingle(SqlInt64 x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingle.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlSingle_SqlInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x0004D9FC File Offset: 0x0004BBFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919669, XrefRangeEnd = 919677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SqlSingle(SqlMoney x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingle.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlSingle_SqlMoney_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x0004DA3C File Offset: 0x0004BC3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 919689, RefRangeEnd = 919690, XrefRangeStart = 919677, XrefRangeEnd = 919689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SqlSingle(SqlDecimal x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingle.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlSingle_SqlDecimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x0004DA7C File Offset: 0x0004BC7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919690, XrefRangeEnd = 919698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator SqlSingle(SqlDouble x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingle.NativeMethodInfoPtr_op_Explicit_Public_Static_SqlSingle_SqlDouble_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x0004DABC File Offset: 0x0004BCBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919698, XrefRangeEnd = 919705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean operator ==(SqlSingle x, SqlSingle y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingle.NativeMethodInfoPtr_op_Equality_Public_Static_SqlBoolean_SqlSingle_SqlSingle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001037 RID: 4151 RVA: 0x0004DB08 File Offset: 0x0004BD08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 919712, RefRangeEnd = 919714, XrefRangeStart = 919705, XrefRangeEnd = 919712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean operator <(SqlSingle x, SqlSingle y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingle.NativeMethodInfoPtr_op_LessThan_Public_Static_SqlBoolean_SqlSingle_SqlSingle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x0004DB54 File Offset: 0x0004BD54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 919721, RefRangeEnd = 919723, XrefRangeStart = 919714, XrefRangeEnd = 919721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean operator >(SqlSingle x, SqlSingle y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingle.NativeMethodInfoPtr_op_GreaterThan_Public_Static_SqlBoolean_SqlSingle_SqlSingle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x0004DBA0 File Offset: 0x0004BDA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 919727, RefRangeEnd = 919728, XrefRangeStart = 919723, XrefRangeEnd = 919727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean LessThan(SqlSingle x, SqlSingle y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingle.NativeMethodInfoPtr_LessThan_Public_Static_SqlBoolean_SqlSingle_SqlSingle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600103A RID: 4154 RVA: 0x0004DBEC File Offset: 0x0004BDEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 919732, RefRangeEnd = 919733, XrefRangeStart = 919728, XrefRangeEnd = 919732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean GreaterThan(SqlSingle x, SqlSingle y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingle.NativeMethodInfoPtr_GreaterThan_Public_Static_SqlBoolean_SqlSingle_SqlSingle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600103B RID: 4155 RVA: 0x0004DC38 File Offset: 0x0004BE38
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 919744, RefRangeEnd = 919748, XrefRangeStart = 919733, XrefRangeEnd = 919744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlDouble ToSqlDouble()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingle.NativeMethodInfoPtr_ToSqlDouble_Public_SqlDouble_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600103C RID: 4156 RVA: 0x0004DC68 File Offset: 0x0004BE68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919748, XrefRangeEnd = 919766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingle.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600103D RID: 4157 RVA: 0x0004DCAC File Offset: 0x0004BEAC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 919784, RefRangeEnd = 919788, XrefRangeStart = 919766, XrefRangeEnd = 919784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(SqlSingle value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingle.NativeMethodInfoPtr_CompareTo_Public_Int32_SqlSingle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x0004DCEC File Offset: 0x0004BEEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919788, XrefRangeEnd = 919814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x0004DD30 File Offset: 0x0004BF30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919814, XrefRangeEnd = 919818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x0004DD60 File Offset: 0x0004BF60
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchema System_Xml_Serialization_IXmlSerializable_GetSchema()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingle.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x0004DD94 File Offset: 0x0004BF94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919818, XrefRangeEnd = 919826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Xml_Serialization_IXmlSerializable_ReadXml(XmlReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingle.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001042 RID: 4162 RVA: 0x0004DDCC File Offset: 0x0004BFCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919826, XrefRangeEnd = 919842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Xml_Serialization_IXmlSerializable_WriteXml(XmlWriter writer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingle.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001043 RID: 4163 RVA: 0x0004DE04 File Offset: 0x0004C004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919842, XrefRangeEnd = 919850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaSet);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingle.NativeMethodInfoPtr_GetXsdType_Public_Static_XmlQualifiedName_XmlSchemaSet_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x00006D3F File Offset: 0x00004F3F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SqlSingle>.NativeClassPtr, ref this));
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06001045 RID: 4165 RVA: 0x0004DE48 File Offset: 0x0004C048
		// (set) Token: 0x06001046 RID: 4166 RVA: 0x00006D51 File Offset: 0x00004F51
		public unsafe static SqlSingle Null
		{
			get
			{
				SqlSingle sqlSingle;
				IL2CPP.il2cpp_field_static_get_value(SqlSingle.NativeFieldInfoPtr_Null, (void*)(&sqlSingle));
				return sqlSingle;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlSingle.NativeFieldInfoPtr_Null, (void*)(&value));
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06001047 RID: 4167 RVA: 0x0004DE64 File Offset: 0x0004C064
		// (set) Token: 0x06001048 RID: 4168 RVA: 0x00006D5F File Offset: 0x00004F5F
		public unsafe static SqlSingle Zero
		{
			get
			{
				SqlSingle sqlSingle;
				IL2CPP.il2cpp_field_static_get_value(SqlSingle.NativeFieldInfoPtr_Zero, (void*)(&sqlSingle));
				return sqlSingle;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlSingle.NativeFieldInfoPtr_Zero, (void*)(&value));
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06001049 RID: 4169 RVA: 0x0004DE80 File Offset: 0x0004C080
		// (set) Token: 0x0600104A RID: 4170 RVA: 0x00006D6D File Offset: 0x00004F6D
		public unsafe static SqlSingle MinValue
		{
			get
			{
				SqlSingle sqlSingle;
				IL2CPP.il2cpp_field_static_get_value(SqlSingle.NativeFieldInfoPtr_MinValue, (void*)(&sqlSingle));
				return sqlSingle;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlSingle.NativeFieldInfoPtr_MinValue, (void*)(&value));
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x0600104B RID: 4171 RVA: 0x0004DE9C File Offset: 0x0004C09C
		// (set) Token: 0x0600104C RID: 4172 RVA: 0x00006D7B File Offset: 0x00004F7B
		public unsafe static SqlSingle MaxValue
		{
			get
			{
				SqlSingle sqlSingle;
				IL2CPP.il2cpp_field_static_get_value(SqlSingle.NativeFieldInfoPtr_MaxValue, (void*)(&sqlSingle));
				return sqlSingle;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlSingle.NativeFieldInfoPtr_MaxValue, (void*)(&value));
			}
		}

		// Token: 0x04000D61 RID: 3425
		private static readonly IntPtr NativeFieldInfoPtr__fNotNull;

		// Token: 0x04000D62 RID: 3426
		private static readonly IntPtr NativeFieldInfoPtr__value;

		// Token: 0x04000D63 RID: 3427
		private static readonly IntPtr NativeFieldInfoPtr_Null;

		// Token: 0x04000D64 RID: 3428
		private static readonly IntPtr NativeFieldInfoPtr_Zero;

		// Token: 0x04000D65 RID: 3429
		private static readonly IntPtr NativeFieldInfoPtr_MinValue;

		// Token: 0x04000D66 RID: 3430
		private static readonly IntPtr NativeFieldInfoPtr_MaxValue;

		// Token: 0x04000D67 RID: 3431
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Boolean_0;

		// Token: 0x04000D68 RID: 3432
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x04000D69 RID: 3433
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x04000D6A RID: 3434
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNull_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000D6B RID: 3435
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Single_0;

		// Token: 0x04000D6C RID: 3436
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SqlSingle_Single_0;

		// Token: 0x04000D6D RID: 3437
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000D6E RID: 3438
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_SqlSingle_SqlSingle_0;

		// Token: 0x04000D6F RID: 3439
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_SqlSingle_SqlSingle_SqlSingle_0;

		// Token: 0x04000D70 RID: 3440
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_SqlSingle_SqlSingle_SqlSingle_0;

		// Token: 0x04000D71 RID: 3441
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_SqlSingle_SqlSingle_SqlSingle_0;

		// Token: 0x04000D72 RID: 3442
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_SqlSingle_SqlSingle_SqlSingle_0;

		// Token: 0x04000D73 RID: 3443
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SqlSingle_SqlByte_0;

		// Token: 0x04000D74 RID: 3444
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SqlSingle_SqlInt16_0;

		// Token: 0x04000D75 RID: 3445
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SqlSingle_SqlInt32_0;

		// Token: 0x04000D76 RID: 3446
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SqlSingle_SqlInt64_0;

		// Token: 0x04000D77 RID: 3447
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SqlSingle_SqlMoney_0;

		// Token: 0x04000D78 RID: 3448
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SqlSingle_SqlDecimal_0;

		// Token: 0x04000D79 RID: 3449
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_SqlSingle_SqlDouble_0;

		// Token: 0x04000D7A RID: 3450
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_SqlBoolean_SqlSingle_SqlSingle_0;

		// Token: 0x04000D7B RID: 3451
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_SqlBoolean_SqlSingle_SqlSingle_0;

		// Token: 0x04000D7C RID: 3452
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_SqlBoolean_SqlSingle_SqlSingle_0;

		// Token: 0x04000D7D RID: 3453
		private static readonly IntPtr NativeMethodInfoPtr_LessThan_Public_Static_SqlBoolean_SqlSingle_SqlSingle_0;

		// Token: 0x04000D7E RID: 3454
		private static readonly IntPtr NativeMethodInfoPtr_GreaterThan_Public_Static_SqlBoolean_SqlSingle_SqlSingle_0;

		// Token: 0x04000D7F RID: 3455
		private static readonly IntPtr NativeMethodInfoPtr_ToSqlDouble_Public_SqlDouble_0;

		// Token: 0x04000D80 RID: 3456
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000D81 RID: 3457
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Int32_SqlSingle_0;

		// Token: 0x04000D82 RID: 3458
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000D83 RID: 3459
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000D84 RID: 3460
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0;

		// Token: 0x04000D85 RID: 3461
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0;

		// Token: 0x04000D86 RID: 3462
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0;

		// Token: 0x04000D87 RID: 3463
		private static readonly IntPtr NativeMethodInfoPtr_GetXsdType_Public_Static_XmlQualifiedName_XmlSchemaSet_0;

		// Token: 0x04000D88 RID: 3464
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool _fNotNull;

		// Token: 0x04000D89 RID: 3465
		[FieldOffset(4)]
		public float _value;
	}
}
