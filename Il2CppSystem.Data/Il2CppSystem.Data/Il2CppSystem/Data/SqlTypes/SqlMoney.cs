using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Data.SqlTypes
{
	// Token: 0x02000099 RID: 153
	[Serializable]
	[StructLayout(2)]
	public struct SqlMoney
	{
		// Token: 0x06000FE9 RID: 4073 RVA: 0x0004C514 File Offset: 0x0004A714
		// Note: this type is marked as 'beforefieldinit'.
		static SqlMoney()
		{
			Il2CppClassPointerStore<SqlMoney>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data.SqlTypes", "SqlMoney");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr);
			SqlMoney.NativeFieldInfoPtr__fNotNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, "_fNotNull");
			SqlMoney.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, "_value");
			SqlMoney.NativeFieldInfoPtr_s_iMoneyScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, "s_iMoneyScale");
			SqlMoney.NativeFieldInfoPtr_s_lTickBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, "s_lTickBase");
			SqlMoney.NativeFieldInfoPtr_s_dTickBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, "s_dTickBase");
			SqlMoney.NativeFieldInfoPtr_s_minLong = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, "s_minLong");
			SqlMoney.NativeFieldInfoPtr_s_maxLong = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, "s_maxLong");
			SqlMoney.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, "Null");
			SqlMoney.NativeFieldInfoPtr_Zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, "Zero");
			SqlMoney.NativeFieldInfoPtr_MinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, "MinValue");
			SqlMoney.NativeFieldInfoPtr_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, "MaxValue");
			SqlMoney.NativeMethodInfoPtr__ctor_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, 100665856);
			SqlMoney.NativeMethodInfoPtr__ctor_Internal_Void_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, 100665857);
			SqlMoney.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, 100665858);
			SqlMoney.NativeMethodInfoPtr__ctor_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, 100665859);
			SqlMoney.NativeMethodInfoPtr__ctor_Public_Void_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, 100665860);
			SqlMoney.NativeMethodInfoPtr_get_IsNull_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, 100665861);
			SqlMoney.NativeMethodInfoPtr_get_Value_Public_get_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, 100665862);
			SqlMoney.NativeMethodInfoPtr_ToDecimal_Public_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, 100665863);
			SqlMoney.NativeMethodInfoPtr_ToDouble_Public_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, 100665864);
			SqlMoney.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlMoney_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, 100665865);
			SqlMoney.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlMoney_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, 100665866);
			SqlMoney.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, 100665867);
			SqlMoney.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_SqlMoney_SqlMoney_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, 100665868);
			SqlMoney.NativeMethodInfoPtr_op_Addition_Public_Static_SqlMoney_SqlMoney_SqlMoney_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, 100665869);
			SqlMoney.NativeMethodInfoPtr_op_Subtraction_Public_Static_SqlMoney_SqlMoney_SqlMoney_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, 100665870);
			SqlMoney.NativeMethodInfoPtr_op_Multiply_Public_Static_SqlMoney_SqlMoney_SqlMoney_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, 100665871);
			SqlMoney.NativeMethodInfoPtr_op_Division_Public_Static_SqlMoney_SqlMoney_SqlMoney_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, 100665872);
			SqlMoney.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlMoney_SqlByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, 100665873);
			SqlMoney.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlMoney_SqlInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, 100665874);
			SqlMoney.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlMoney_SqlInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, 100665875);
			SqlMoney.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlMoney_SqlInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, 100665876);
			SqlMoney.NativeMethodInfoPtr_op_Explicit_Public_Static_SqlMoney_SqlDecimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, 100665877);
			SqlMoney.NativeMethodInfoPtr_op_Equality_Public_Static_SqlBoolean_SqlMoney_SqlMoney_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, 100665878);
			SqlMoney.NativeMethodInfoPtr_op_LessThan_Public_Static_SqlBoolean_SqlMoney_SqlMoney_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, 100665879);
			SqlMoney.NativeMethodInfoPtr_op_GreaterThan_Public_Static_SqlBoolean_SqlMoney_SqlMoney_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, 100665880);
			SqlMoney.NativeMethodInfoPtr_LessThan_Public_Static_SqlBoolean_SqlMoney_SqlMoney_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, 100665881);
			SqlMoney.NativeMethodInfoPtr_GreaterThan_Public_Static_SqlBoolean_SqlMoney_SqlMoney_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, 100665882);
			SqlMoney.NativeMethodInfoPtr_ToSqlDouble_Public_SqlDouble_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, 100665883);
			SqlMoney.NativeMethodInfoPtr_ToSqlDecimal_Public_SqlDecimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, 100665884);
			SqlMoney.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, 100665885);
			SqlMoney.NativeMethodInfoPtr_CompareTo_Public_Int32_SqlMoney_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, 100665886);
			SqlMoney.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, 100665887);
			SqlMoney.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, 100665888);
			SqlMoney.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, 100665889);
			SqlMoney.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, 100665890);
			SqlMoney.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, 100665891);
			SqlMoney.NativeMethodInfoPtr_GetXsdType_Public_Static_XmlQualifiedName_XmlSchemaSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, 100665892);
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x0004C904 File Offset: 0x0004AB04
		[CallerCount(0)]
		public unsafe SqlMoney(bool fNull)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fNull;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlMoney.NativeMethodInfoPtr__ctor_Private_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x0004C938 File Offset: 0x0004AB38
		[CallerCount(45)]
		[CachedScanResults(RefRangeStart = 918835, RefRangeEnd = 918880, XrefRangeStart = 918835, XrefRangeEnd = 918880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlMoney(long value, int ignored)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignored;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlMoney.NativeMethodInfoPtr__ctor_Internal_Void_Int64_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x0004C978 File Offset: 0x0004AB78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919212, XrefRangeEnd = 919216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlMoney(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlMoney.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x0004C9AC File Offset: 0x0004ABAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919216, XrefRangeEnd = 919224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlMoney(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlMoney.NativeMethodInfoPtr__ctor_Public_Void_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x0004C9E0 File Offset: 0x0004ABE0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 919237, RefRangeEnd = 919241, XrefRangeStart = 919224, XrefRangeEnd = 919237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlMoney(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlMoney.NativeMethodInfoPtr__ctor_Public_Void_Decimal_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000FEF RID: 4079 RVA: 0x0004CA14 File Offset: 0x0004AC14
		public unsafe bool IsNull
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 786806, RefRangeEnd = 786824, XrefRangeStart = 786806, XrefRangeEnd = 786824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlMoney.NativeMethodInfoPtr_get_IsNull_Public_Virtual_Final_New_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000FF0 RID: 4080 RVA: 0x0004CA44 File Offset: 0x0004AC44
		public unsafe Decimal Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919241, XrefRangeEnd = 919245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlMoney.NativeMethodInfoPtr_get_Value_Public_get_Decimal_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x0004CA74 File Offset: 0x0004AC74
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 919252, RefRangeEnd = 919262, XrefRangeStart = 919245, XrefRangeEnd = 919252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Decimal ToDecimal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlMoney.NativeMethodInfoPtr_ToDecimal_Public_Decimal_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x0004CAA4 File Offset: 0x0004ACA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919262, XrefRangeEnd = 919270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double ToDouble()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlMoney.NativeMethodInfoPtr_ToDouble_Public_Double_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x0004CAD4 File Offset: 0x0004ACD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919270, XrefRangeEnd = 919271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SqlMoney(Decimal x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlMoney.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlMoney_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x0004CB14 File Offset: 0x0004AD14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 919273, RefRangeEnd = 919275, XrefRangeStart = 919271, XrefRangeEnd = 919273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SqlMoney(long x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlMoney.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlMoney_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x0004CB54 File Offset: 0x0004AD54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919275, XrefRangeEnd = 919287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlMoney.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x0004CB80 File Offset: 0x0004AD80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 919293, RefRangeEnd = 919294, XrefRangeStart = 919287, XrefRangeEnd = 919293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlMoney operator -(SqlMoney x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlMoney.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_SqlMoney_SqlMoney_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x0004CBC0 File Offset: 0x0004ADC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919294, XrefRangeEnd = 919304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlMoney operator +(SqlMoney x, SqlMoney y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlMoney.NativeMethodInfoPtr_op_Addition_Public_Static_SqlMoney_SqlMoney_SqlMoney_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x0004CC0C File Offset: 0x0004AE0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919304, XrefRangeEnd = 919315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlMoney operator -(SqlMoney x, SqlMoney y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlMoney.NativeMethodInfoPtr_op_Subtraction_Public_Static_SqlMoney_SqlMoney_SqlMoney_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x0004CC58 File Offset: 0x0004AE58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919315, XrefRangeEnd = 919332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlMoney operator *(SqlMoney x, SqlMoney y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlMoney.NativeMethodInfoPtr_op_Multiply_Public_Static_SqlMoney_SqlMoney_SqlMoney_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x0004CCA4 File Offset: 0x0004AEA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919332, XrefRangeEnd = 919349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlMoney operator /(SqlMoney x, SqlMoney y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlMoney.NativeMethodInfoPtr_op_Division_Public_Static_SqlMoney_SqlMoney_SqlMoney_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x0004CCF0 File Offset: 0x0004AEF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919349, XrefRangeEnd = 919357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SqlMoney(SqlByte x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlMoney.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlMoney_SqlByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x0004CD30 File Offset: 0x0004AF30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919357, XrefRangeEnd = 919365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SqlMoney(SqlInt16 x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlMoney.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlMoney_SqlInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x0004CD70 File Offset: 0x0004AF70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919365, XrefRangeEnd = 919372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SqlMoney(SqlInt32 x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlMoney.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlMoney_SqlInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x0004CDB0 File Offset: 0x0004AFB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919372, XrefRangeEnd = 919380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SqlMoney(SqlInt64 x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlMoney.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlMoney_SqlInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x0004CDF0 File Offset: 0x0004AFF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919380, XrefRangeEnd = 919392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator SqlMoney(SqlDecimal x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlMoney.NativeMethodInfoPtr_op_Explicit_Public_Static_SqlMoney_SqlDecimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x0004CE30 File Offset: 0x0004B030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919392, XrefRangeEnd = 919399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean operator ==(SqlMoney x, SqlMoney y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlMoney.NativeMethodInfoPtr_op_Equality_Public_Static_SqlBoolean_SqlMoney_SqlMoney_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x0004CE7C File Offset: 0x0004B07C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919399, XrefRangeEnd = 919406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean operator <(SqlMoney x, SqlMoney y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlMoney.NativeMethodInfoPtr_op_LessThan_Public_Static_SqlBoolean_SqlMoney_SqlMoney_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x0004CEC8 File Offset: 0x0004B0C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 919413, RefRangeEnd = 919414, XrefRangeStart = 919406, XrefRangeEnd = 919413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean operator >(SqlMoney x, SqlMoney y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlMoney.NativeMethodInfoPtr_op_GreaterThan_Public_Static_SqlBoolean_SqlMoney_SqlMoney_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x0004CF14 File Offset: 0x0004B114
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 919424, RefRangeEnd = 919425, XrefRangeStart = 919414, XrefRangeEnd = 919424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean LessThan(SqlMoney x, SqlMoney y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlMoney.NativeMethodInfoPtr_LessThan_Public_Static_SqlBoolean_SqlMoney_SqlMoney_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x0004CF60 File Offset: 0x0004B160
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 919435, RefRangeEnd = 919436, XrefRangeStart = 919425, XrefRangeEnd = 919435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean GreaterThan(SqlMoney x, SqlMoney y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlMoney.NativeMethodInfoPtr_GreaterThan_Public_Static_SqlBoolean_SqlMoney_SqlMoney_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x0004CFAC File Offset: 0x0004B1AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 919457, RefRangeEnd = 919460, XrefRangeStart = 919436, XrefRangeEnd = 919457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlDouble ToSqlDouble()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlMoney.NativeMethodInfoPtr_ToSqlDouble_Public_SqlDouble_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x0004CFDC File Offset: 0x0004B1DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 919475, RefRangeEnd = 919476, XrefRangeStart = 919460, XrefRangeEnd = 919475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlDecimal ToSqlDecimal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlMoney.NativeMethodInfoPtr_ToSqlDecimal_Public_SqlDecimal_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x0004D00C File Offset: 0x0004B20C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919476, XrefRangeEnd = 919482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlMoney.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x0004D050 File Offset: 0x0004B250
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 919511, RefRangeEnd = 919515, XrefRangeStart = 919482, XrefRangeEnd = 919511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(SqlMoney value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlMoney.NativeMethodInfoPtr_CompareTo_Public_Int32_SqlMoney_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x0004D090 File Offset: 0x0004B290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919515, XrefRangeEnd = 919540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlMoney.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x0004D0D4 File Offset: 0x0004B2D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919540, XrefRangeEnd = 919543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlMoney.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x0004D104 File Offset: 0x0004B304
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchema System_Xml_Serialization_IXmlSerializable_GetSchema()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlMoney.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x0004D138 File Offset: 0x0004B338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919543, XrefRangeEnd = 919552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Xml_Serialization_IXmlSerializable_ReadXml(XmlReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlMoney.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x0004D170 File Offset: 0x0004B370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919552, XrefRangeEnd = 919571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Xml_Serialization_IXmlSerializable_WriteXml(XmlWriter writer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlMoney.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x0004D1A8 File Offset: 0x0004B3A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919571, XrefRangeEnd = 919579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaSet);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlMoney.NativeMethodInfoPtr_GetXsdType_Public_Static_XmlQualifiedName_XmlSchemaSet_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x00006CAF File Offset: 0x00004EAF
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SqlMoney>.NativeClassPtr, ref this));
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06001010 RID: 4112 RVA: 0x0004D1EC File Offset: 0x0004B3EC
		// (set) Token: 0x06001011 RID: 4113 RVA: 0x00006CC1 File Offset: 0x00004EC1
		public unsafe static int s_iMoneyScale
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SqlMoney.NativeFieldInfoPtr_s_iMoneyScale, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlMoney.NativeFieldInfoPtr_s_iMoneyScale, (void*)(&value));
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06001012 RID: 4114 RVA: 0x0004D208 File Offset: 0x0004B408
		// (set) Token: 0x06001013 RID: 4115 RVA: 0x00006CCF File Offset: 0x00004ECF
		public unsafe static long s_lTickBase
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(SqlMoney.NativeFieldInfoPtr_s_lTickBase, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlMoney.NativeFieldInfoPtr_s_lTickBase, (void*)(&value));
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06001014 RID: 4116 RVA: 0x0004D224 File Offset: 0x0004B424
		// (set) Token: 0x06001015 RID: 4117 RVA: 0x00006CDD File Offset: 0x00004EDD
		public unsafe static double s_dTickBase
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(SqlMoney.NativeFieldInfoPtr_s_dTickBase, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlMoney.NativeFieldInfoPtr_s_dTickBase, (void*)(&value));
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06001016 RID: 4118 RVA: 0x0004D240 File Offset: 0x0004B440
		// (set) Token: 0x06001017 RID: 4119 RVA: 0x00006CEB File Offset: 0x00004EEB
		public unsafe static long s_minLong
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(SqlMoney.NativeFieldInfoPtr_s_minLong, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlMoney.NativeFieldInfoPtr_s_minLong, (void*)(&value));
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06001018 RID: 4120 RVA: 0x0004D25C File Offset: 0x0004B45C
		// (set) Token: 0x06001019 RID: 4121 RVA: 0x00006CF9 File Offset: 0x00004EF9
		public unsafe static long s_maxLong
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(SqlMoney.NativeFieldInfoPtr_s_maxLong, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlMoney.NativeFieldInfoPtr_s_maxLong, (void*)(&value));
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x0600101A RID: 4122 RVA: 0x0004D278 File Offset: 0x0004B478
		// (set) Token: 0x0600101B RID: 4123 RVA: 0x00006D07 File Offset: 0x00004F07
		public unsafe static SqlMoney Null
		{
			get
			{
				SqlMoney sqlMoney;
				IL2CPP.il2cpp_field_static_get_value(SqlMoney.NativeFieldInfoPtr_Null, (void*)(&sqlMoney));
				return sqlMoney;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlMoney.NativeFieldInfoPtr_Null, (void*)(&value));
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x0600101C RID: 4124 RVA: 0x0004D294 File Offset: 0x0004B494
		// (set) Token: 0x0600101D RID: 4125 RVA: 0x00006D15 File Offset: 0x00004F15
		public unsafe static SqlMoney Zero
		{
			get
			{
				SqlMoney sqlMoney;
				IL2CPP.il2cpp_field_static_get_value(SqlMoney.NativeFieldInfoPtr_Zero, (void*)(&sqlMoney));
				return sqlMoney;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlMoney.NativeFieldInfoPtr_Zero, (void*)(&value));
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x0600101E RID: 4126 RVA: 0x0004D2B0 File Offset: 0x0004B4B0
		// (set) Token: 0x0600101F RID: 4127 RVA: 0x00006D23 File Offset: 0x00004F23
		public unsafe static SqlMoney MinValue
		{
			get
			{
				SqlMoney sqlMoney;
				IL2CPP.il2cpp_field_static_get_value(SqlMoney.NativeFieldInfoPtr_MinValue, (void*)(&sqlMoney));
				return sqlMoney;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlMoney.NativeFieldInfoPtr_MinValue, (void*)(&value));
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06001020 RID: 4128 RVA: 0x0004D2CC File Offset: 0x0004B4CC
		// (set) Token: 0x06001021 RID: 4129 RVA: 0x00006D31 File Offset: 0x00004F31
		public unsafe static SqlMoney MaxValue
		{
			get
			{
				SqlMoney sqlMoney;
				IL2CPP.il2cpp_field_static_get_value(SqlMoney.NativeFieldInfoPtr_MaxValue, (void*)(&sqlMoney));
				return sqlMoney;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlMoney.NativeFieldInfoPtr_MaxValue, (void*)(&value));
			}
		}

		// Token: 0x04000D2F RID: 3375
		private static readonly IntPtr NativeFieldInfoPtr__fNotNull;

		// Token: 0x04000D30 RID: 3376
		private static readonly IntPtr NativeFieldInfoPtr__value;

		// Token: 0x04000D31 RID: 3377
		private static readonly IntPtr NativeFieldInfoPtr_s_iMoneyScale;

		// Token: 0x04000D32 RID: 3378
		private static readonly IntPtr NativeFieldInfoPtr_s_lTickBase;

		// Token: 0x04000D33 RID: 3379
		private static readonly IntPtr NativeFieldInfoPtr_s_dTickBase;

		// Token: 0x04000D34 RID: 3380
		private static readonly IntPtr NativeFieldInfoPtr_s_minLong;

		// Token: 0x04000D35 RID: 3381
		private static readonly IntPtr NativeFieldInfoPtr_s_maxLong;

		// Token: 0x04000D36 RID: 3382
		private static readonly IntPtr NativeFieldInfoPtr_Null;

		// Token: 0x04000D37 RID: 3383
		private static readonly IntPtr NativeFieldInfoPtr_Zero;

		// Token: 0x04000D38 RID: 3384
		private static readonly IntPtr NativeFieldInfoPtr_MinValue;

		// Token: 0x04000D39 RID: 3385
		private static readonly IntPtr NativeFieldInfoPtr_MaxValue;

		// Token: 0x04000D3A RID: 3386
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Boolean_0;

		// Token: 0x04000D3B RID: 3387
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int64_Int32_0;

		// Token: 0x04000D3C RID: 3388
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000D3D RID: 3389
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_0;

		// Token: 0x04000D3E RID: 3390
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Decimal_0;

		// Token: 0x04000D3F RID: 3391
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNull_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000D40 RID: 3392
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Decimal_0;

		// Token: 0x04000D41 RID: 3393
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Decimal_0;

		// Token: 0x04000D42 RID: 3394
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Double_0;

		// Token: 0x04000D43 RID: 3395
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SqlMoney_Decimal_0;

		// Token: 0x04000D44 RID: 3396
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SqlMoney_Int64_0;

		// Token: 0x04000D45 RID: 3397
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000D46 RID: 3398
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_SqlMoney_SqlMoney_0;

		// Token: 0x04000D47 RID: 3399
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_SqlMoney_SqlMoney_SqlMoney_0;

		// Token: 0x04000D48 RID: 3400
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_SqlMoney_SqlMoney_SqlMoney_0;

		// Token: 0x04000D49 RID: 3401
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_SqlMoney_SqlMoney_SqlMoney_0;

		// Token: 0x04000D4A RID: 3402
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_SqlMoney_SqlMoney_SqlMoney_0;

		// Token: 0x04000D4B RID: 3403
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SqlMoney_SqlByte_0;

		// Token: 0x04000D4C RID: 3404
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SqlMoney_SqlInt16_0;

		// Token: 0x04000D4D RID: 3405
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SqlMoney_SqlInt32_0;

		// Token: 0x04000D4E RID: 3406
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SqlMoney_SqlInt64_0;

		// Token: 0x04000D4F RID: 3407
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_SqlMoney_SqlDecimal_0;

		// Token: 0x04000D50 RID: 3408
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_SqlBoolean_SqlMoney_SqlMoney_0;

		// Token: 0x04000D51 RID: 3409
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_SqlBoolean_SqlMoney_SqlMoney_0;

		// Token: 0x04000D52 RID: 3410
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_SqlBoolean_SqlMoney_SqlMoney_0;

		// Token: 0x04000D53 RID: 3411
		private static readonly IntPtr NativeMethodInfoPtr_LessThan_Public_Static_SqlBoolean_SqlMoney_SqlMoney_0;

		// Token: 0x04000D54 RID: 3412
		private static readonly IntPtr NativeMethodInfoPtr_GreaterThan_Public_Static_SqlBoolean_SqlMoney_SqlMoney_0;

		// Token: 0x04000D55 RID: 3413
		private static readonly IntPtr NativeMethodInfoPtr_ToSqlDouble_Public_SqlDouble_0;

		// Token: 0x04000D56 RID: 3414
		private static readonly IntPtr NativeMethodInfoPtr_ToSqlDecimal_Public_SqlDecimal_0;

		// Token: 0x04000D57 RID: 3415
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000D58 RID: 3416
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Int32_SqlMoney_0;

		// Token: 0x04000D59 RID: 3417
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000D5A RID: 3418
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000D5B RID: 3419
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0;

		// Token: 0x04000D5C RID: 3420
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0;

		// Token: 0x04000D5D RID: 3421
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0;

		// Token: 0x04000D5E RID: 3422
		private static readonly IntPtr NativeMethodInfoPtr_GetXsdType_Public_Static_XmlQualifiedName_XmlSchemaSet_0;

		// Token: 0x04000D5F RID: 3423
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool _fNotNull;

		// Token: 0x04000D60 RID: 3424
		[FieldOffset(8)]
		public long _value;
	}
}
