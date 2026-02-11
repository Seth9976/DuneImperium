using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Data.SqlTypes
{
	// Token: 0x02000098 RID: 152
	[Serializable]
	[StructLayout(2)]
	public struct SqlInt64
	{
		// Token: 0x06000FB8 RID: 4024 RVA: 0x0004B858 File Offset: 0x00049A58
		// Note: this type is marked as 'beforefieldinit'.
		static SqlInt64()
		{
			Il2CppClassPointerStore<SqlInt64>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data.SqlTypes", "SqlInt64");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr);
			SqlInt64.NativeFieldInfoPtr_m_fNotNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr, "m_fNotNull");
			SqlInt64.NativeFieldInfoPtr_m_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr, "m_value");
			SqlInt64.NativeFieldInfoPtr_s_lLowIntMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr, "s_lLowIntMask");
			SqlInt64.NativeFieldInfoPtr_s_lHighIntMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr, "s_lHighIntMask");
			SqlInt64.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr, "Null");
			SqlInt64.NativeFieldInfoPtr_Zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr, "Zero");
			SqlInt64.NativeFieldInfoPtr_MinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr, "MinValue");
			SqlInt64.NativeFieldInfoPtr_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr, "MaxValue");
			SqlInt64.NativeMethodInfoPtr__ctor_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr, 100665820);
			SqlInt64.NativeMethodInfoPtr__ctor_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr, 100665821);
			SqlInt64.NativeMethodInfoPtr_get_IsNull_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr, 100665822);
			SqlInt64.NativeMethodInfoPtr_get_Value_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr, 100665823);
			SqlInt64.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlInt64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr, 100665824);
			SqlInt64.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr, 100665825);
			SqlInt64.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_SqlInt64_SqlInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr, 100665826);
			SqlInt64.NativeMethodInfoPtr_op_Addition_Public_Static_SqlInt64_SqlInt64_SqlInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr, 100665827);
			SqlInt64.NativeMethodInfoPtr_op_Subtraction_Public_Static_SqlInt64_SqlInt64_SqlInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr, 100665828);
			SqlInt64.NativeMethodInfoPtr_op_Multiply_Public_Static_SqlInt64_SqlInt64_SqlInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr, 100665829);
			SqlInt64.NativeMethodInfoPtr_op_Division_Public_Static_SqlInt64_SqlInt64_SqlInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr, 100665830);
			SqlInt64.NativeMethodInfoPtr_op_Modulus_Public_Static_SqlInt64_SqlInt64_SqlInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr, 100665831);
			SqlInt64.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlInt64_SqlByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr, 100665832);
			SqlInt64.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlInt64_SqlInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr, 100665833);
			SqlInt64.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlInt64_SqlInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr, 100665834);
			SqlInt64.NativeMethodInfoPtr_op_Explicit_Public_Static_SqlInt64_SqlDecimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr, 100665835);
			SqlInt64.NativeMethodInfoPtr_SameSignLong_Private_Static_Boolean_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr, 100665836);
			SqlInt64.NativeMethodInfoPtr_op_Equality_Public_Static_SqlBoolean_SqlInt64_SqlInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr, 100665837);
			SqlInt64.NativeMethodInfoPtr_op_LessThan_Public_Static_SqlBoolean_SqlInt64_SqlInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr, 100665838);
			SqlInt64.NativeMethodInfoPtr_op_GreaterThan_Public_Static_SqlBoolean_SqlInt64_SqlInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr, 100665839);
			SqlInt64.NativeMethodInfoPtr_LessThan_Public_Static_SqlBoolean_SqlInt64_SqlInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr, 100665840);
			SqlInt64.NativeMethodInfoPtr_GreaterThan_Public_Static_SqlBoolean_SqlInt64_SqlInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr, 100665841);
			SqlInt64.NativeMethodInfoPtr_ToSqlByte_Public_SqlByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr, 100665842);
			SqlInt64.NativeMethodInfoPtr_ToSqlDouble_Public_SqlDouble_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr, 100665843);
			SqlInt64.NativeMethodInfoPtr_ToSqlInt16_Public_SqlInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr, 100665844);
			SqlInt64.NativeMethodInfoPtr_ToSqlInt32_Public_SqlInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr, 100665845);
			SqlInt64.NativeMethodInfoPtr_ToSqlDecimal_Public_SqlDecimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr, 100665846);
			SqlInt64.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr, 100665847);
			SqlInt64.NativeMethodInfoPtr_CompareTo_Public_Int32_SqlInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr, 100665848);
			SqlInt64.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr, 100665849);
			SqlInt64.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr, 100665850);
			SqlInt64.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr, 100665851);
			SqlInt64.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr, 100665852);
			SqlInt64.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr, 100665853);
			SqlInt64.NativeMethodInfoPtr_GetXsdType_Public_Static_XmlQualifiedName_XmlSchemaSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr, 100665854);
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x0004BBE4 File Offset: 0x00049DE4
		[CallerCount(0)]
		public unsafe SqlInt64(bool fNull)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fNull;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt64.NativeMethodInfoPtr__ctor_Private_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x0004BC18 File Offset: 0x00049E18
		[CallerCount(45)]
		[CachedScanResults(RefRangeStart = 918835, RefRangeEnd = 918880, XrefRangeStart = 918835, XrefRangeEnd = 918835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlInt64(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt64.NativeMethodInfoPtr__ctor_Public_Void_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000FBB RID: 4027 RVA: 0x0004BC4C File Offset: 0x00049E4C
		public unsafe bool IsNull
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 786806, RefRangeEnd = 786824, XrefRangeStart = 786806, XrefRangeEnd = 786824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt64.NativeMethodInfoPtr_get_IsNull_Public_Virtual_Final_New_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000FBC RID: 4028 RVA: 0x0004BC7C File Offset: 0x00049E7C
		public unsafe long Value
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 918880, RefRangeEnd = 918883, XrefRangeStart = 918880, XrefRangeEnd = 918880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt64.NativeMethodInfoPtr_get_Value_Public_get_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x0004BCAC File Offset: 0x00049EAC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 918883, RefRangeEnd = 918895, XrefRangeStart = 918883, XrefRangeEnd = 918883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SqlInt64(long x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt64.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlInt64_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x0004BCEC File Offset: 0x00049EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918895, XrefRangeEnd = 918907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt64.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x0004BD18 File Offset: 0x00049F18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 918913, RefRangeEnd = 918914, XrefRangeStart = 918907, XrefRangeEnd = 918913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlInt64 operator -(SqlInt64 x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt64.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_SqlInt64_SqlInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x0004BD58 File Offset: 0x00049F58
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 918923, RefRangeEnd = 918930, XrefRangeStart = 918914, XrefRangeEnd = 918923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlInt64 operator +(SqlInt64 x, SqlInt64 y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt64.NativeMethodInfoPtr_op_Addition_Public_Static_SqlInt64_SqlInt64_SqlInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x0004BDA4 File Offset: 0x00049FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918930, XrefRangeEnd = 918939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlInt64 operator -(SqlInt64 x, SqlInt64 y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt64.NativeMethodInfoPtr_op_Subtraction_Public_Static_SqlInt64_SqlInt64_SqlInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x0004BDF0 File Offset: 0x00049FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918939, XrefRangeEnd = 918948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlInt64 operator *(SqlInt64 x, SqlInt64 y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt64.NativeMethodInfoPtr_op_Multiply_Public_Static_SqlInt64_SqlInt64_SqlInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x0004BE3C File Offset: 0x0004A03C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 918954, RefRangeEnd = 918957, XrefRangeStart = 918948, XrefRangeEnd = 918954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlInt64 operator /(SqlInt64 x, SqlInt64 y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt64.NativeMethodInfoPtr_op_Division_Public_Static_SqlInt64_SqlInt64_SqlInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x0004BE88 File Offset: 0x0004A088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918957, XrefRangeEnd = 918963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlInt64 operator %(SqlInt64 x, SqlInt64 y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt64.NativeMethodInfoPtr_op_Modulus_Public_Static_SqlInt64_SqlInt64_SqlInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x0004BED4 File Offset: 0x0004A0D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 918971, RefRangeEnd = 918973, XrefRangeStart = 918963, XrefRangeEnd = 918971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SqlInt64(SqlByte x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt64.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlInt64_SqlByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x0004BF14 File Offset: 0x0004A114
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 918981, RefRangeEnd = 918982, XrefRangeStart = 918973, XrefRangeEnd = 918981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SqlInt64(SqlInt16 x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt64.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlInt64_SqlInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x0004BF54 File Offset: 0x0004A154
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 918989, RefRangeEnd = 918990, XrefRangeStart = 918982, XrefRangeEnd = 918989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SqlInt64(SqlInt32 x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt64.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlInt64_SqlInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x0004BF94 File Offset: 0x0004A194
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 919011, RefRangeEnd = 919012, XrefRangeStart = 918990, XrefRangeEnd = 919011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator SqlInt64(SqlDecimal x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt64.NativeMethodInfoPtr_op_Explicit_Public_Static_SqlInt64_SqlDecimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x0004BFD4 File Offset: 0x0004A1D4
		[CallerCount(0)]
		public unsafe static bool SameSignLong(long x, long y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt64.NativeMethodInfoPtr_SameSignLong_Private_Static_Boolean_Int64_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x0004C020 File Offset: 0x0004A220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919012, XrefRangeEnd = 919019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean operator ==(SqlInt64 x, SqlInt64 y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt64.NativeMethodInfoPtr_op_Equality_Public_Static_SqlBoolean_SqlInt64_SqlInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x0004C06C File Offset: 0x0004A26C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919019, XrefRangeEnd = 919026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean operator <(SqlInt64 x, SqlInt64 y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt64.NativeMethodInfoPtr_op_LessThan_Public_Static_SqlBoolean_SqlInt64_SqlInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x0004C0B8 File Offset: 0x0004A2B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 919033, RefRangeEnd = 919034, XrefRangeStart = 919026, XrefRangeEnd = 919033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean operator >(SqlInt64 x, SqlInt64 y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt64.NativeMethodInfoPtr_op_GreaterThan_Public_Static_SqlBoolean_SqlInt64_SqlInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x0004C104 File Offset: 0x0004A304
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 919044, RefRangeEnd = 919045, XrefRangeStart = 919034, XrefRangeEnd = 919044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean LessThan(SqlInt64 x, SqlInt64 y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt64.NativeMethodInfoPtr_LessThan_Public_Static_SqlBoolean_SqlInt64_SqlInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x0004C150 File Offset: 0x0004A350
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 919055, RefRangeEnd = 919056, XrefRangeStart = 919045, XrefRangeEnd = 919055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean GreaterThan(SqlInt64 x, SqlInt64 y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt64.NativeMethodInfoPtr_GreaterThan_Public_Static_SqlBoolean_SqlInt64_SqlInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x0004C19C File Offset: 0x0004A39C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 919060, RefRangeEnd = 919061, XrefRangeStart = 919056, XrefRangeEnd = 919060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlByte ToSqlByte()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt64.NativeMethodInfoPtr_ToSqlByte_Public_SqlByte_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x0004C1CC File Offset: 0x0004A3CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 919074, RefRangeEnd = 919077, XrefRangeStart = 919061, XrefRangeEnd = 919074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlDouble ToSqlDouble()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt64.NativeMethodInfoPtr_ToSqlDouble_Public_SqlDouble_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x0004C1FC File Offset: 0x0004A3FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 919086, RefRangeEnd = 919087, XrefRangeStart = 919077, XrefRangeEnd = 919086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlInt16 ToSqlInt16()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt64.NativeMethodInfoPtr_ToSqlInt16_Public_SqlInt16_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FD2 RID: 4050 RVA: 0x0004C22C File Offset: 0x0004A42C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 919096, RefRangeEnd = 919097, XrefRangeStart = 919087, XrefRangeEnd = 919096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlInt32 ToSqlInt32()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt64.NativeMethodInfoPtr_ToSqlInt32_Public_SqlInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FD3 RID: 4051 RVA: 0x0004C25C File Offset: 0x0004A45C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 919111, RefRangeEnd = 919112, XrefRangeStart = 919097, XrefRangeEnd = 919111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlDecimal ToSqlDecimal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt64.NativeMethodInfoPtr_ToSqlDecimal_Public_SqlDecimal_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x0004C28C File Offset: 0x0004A48C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919112, XrefRangeEnd = 919118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt64.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x0004C2D0 File Offset: 0x0004A4D0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 919147, RefRangeEnd = 919151, XrefRangeStart = 919118, XrefRangeEnd = 919147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(SqlInt64 value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt64.NativeMethodInfoPtr_CompareTo_Public_Int32_SqlInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x0004C310 File Offset: 0x0004A510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919151, XrefRangeEnd = 919176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt64.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x0004C354 File Offset: 0x0004A554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919176, XrefRangeEnd = 919180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt64.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x0004C384 File Offset: 0x0004A584
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchema System_Xml_Serialization_IXmlSerializable_GetSchema()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt64.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x0004C3B8 File Offset: 0x0004A5B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919180, XrefRangeEnd = 919188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Xml_Serialization_IXmlSerializable_ReadXml(XmlReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt64.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x0004C3F0 File Offset: 0x0004A5F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919188, XrefRangeEnd = 919204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Xml_Serialization_IXmlSerializable_WriteXml(XmlWriter writer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt64.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x0004C428 File Offset: 0x0004A628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919204, XrefRangeEnd = 919212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaSet);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt64.NativeMethodInfoPtr_GetXsdType_Public_Static_XmlQualifiedName_XmlSchemaSet_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x00006C49 File Offset: 0x00004E49
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SqlInt64>.NativeClassPtr, ref this));
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000FDD RID: 4061 RVA: 0x0004C46C File Offset: 0x0004A66C
		// (set) Token: 0x06000FDE RID: 4062 RVA: 0x00006C5B File Offset: 0x00004E5B
		public unsafe static long s_lLowIntMask
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(SqlInt64.NativeFieldInfoPtr_s_lLowIntMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlInt64.NativeFieldInfoPtr_s_lLowIntMask, (void*)(&value));
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000FDF RID: 4063 RVA: 0x0004C488 File Offset: 0x0004A688
		// (set) Token: 0x06000FE0 RID: 4064 RVA: 0x00006C69 File Offset: 0x00004E69
		public unsafe static long s_lHighIntMask
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(SqlInt64.NativeFieldInfoPtr_s_lHighIntMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlInt64.NativeFieldInfoPtr_s_lHighIntMask, (void*)(&value));
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000FE1 RID: 4065 RVA: 0x0004C4A4 File Offset: 0x0004A6A4
		// (set) Token: 0x06000FE2 RID: 4066 RVA: 0x00006C77 File Offset: 0x00004E77
		public unsafe static SqlInt64 Null
		{
			get
			{
				SqlInt64 sqlInt;
				IL2CPP.il2cpp_field_static_get_value(SqlInt64.NativeFieldInfoPtr_Null, (void*)(&sqlInt));
				return sqlInt;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlInt64.NativeFieldInfoPtr_Null, (void*)(&value));
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000FE3 RID: 4067 RVA: 0x0004C4C0 File Offset: 0x0004A6C0
		// (set) Token: 0x06000FE4 RID: 4068 RVA: 0x00006C85 File Offset: 0x00004E85
		public unsafe static SqlInt64 Zero
		{
			get
			{
				SqlInt64 sqlInt;
				IL2CPP.il2cpp_field_static_get_value(SqlInt64.NativeFieldInfoPtr_Zero, (void*)(&sqlInt));
				return sqlInt;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlInt64.NativeFieldInfoPtr_Zero, (void*)(&value));
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000FE5 RID: 4069 RVA: 0x0004C4DC File Offset: 0x0004A6DC
		// (set) Token: 0x06000FE6 RID: 4070 RVA: 0x00006C93 File Offset: 0x00004E93
		public unsafe static SqlInt64 MinValue
		{
			get
			{
				SqlInt64 sqlInt;
				IL2CPP.il2cpp_field_static_get_value(SqlInt64.NativeFieldInfoPtr_MinValue, (void*)(&sqlInt));
				return sqlInt;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlInt64.NativeFieldInfoPtr_MinValue, (void*)(&value));
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000FE7 RID: 4071 RVA: 0x0004C4F8 File Offset: 0x0004A6F8
		// (set) Token: 0x06000FE8 RID: 4072 RVA: 0x00006CA1 File Offset: 0x00004EA1
		public unsafe static SqlInt64 MaxValue
		{
			get
			{
				SqlInt64 sqlInt;
				IL2CPP.il2cpp_field_static_get_value(SqlInt64.NativeFieldInfoPtr_MaxValue, (void*)(&sqlInt));
				return sqlInt;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlInt64.NativeFieldInfoPtr_MaxValue, (void*)(&value));
			}
		}

		// Token: 0x04000D02 RID: 3330
		private static readonly IntPtr NativeFieldInfoPtr_m_fNotNull;

		// Token: 0x04000D03 RID: 3331
		private static readonly IntPtr NativeFieldInfoPtr_m_value;

		// Token: 0x04000D04 RID: 3332
		private static readonly IntPtr NativeFieldInfoPtr_s_lLowIntMask;

		// Token: 0x04000D05 RID: 3333
		private static readonly IntPtr NativeFieldInfoPtr_s_lHighIntMask;

		// Token: 0x04000D06 RID: 3334
		private static readonly IntPtr NativeFieldInfoPtr_Null;

		// Token: 0x04000D07 RID: 3335
		private static readonly IntPtr NativeFieldInfoPtr_Zero;

		// Token: 0x04000D08 RID: 3336
		private static readonly IntPtr NativeFieldInfoPtr_MinValue;

		// Token: 0x04000D09 RID: 3337
		private static readonly IntPtr NativeFieldInfoPtr_MaxValue;

		// Token: 0x04000D0A RID: 3338
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Boolean_0;

		// Token: 0x04000D0B RID: 3339
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_0;

		// Token: 0x04000D0C RID: 3340
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNull_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000D0D RID: 3341
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Int64_0;

		// Token: 0x04000D0E RID: 3342
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SqlInt64_Int64_0;

		// Token: 0x04000D0F RID: 3343
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000D10 RID: 3344
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_SqlInt64_SqlInt64_0;

		// Token: 0x04000D11 RID: 3345
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_SqlInt64_SqlInt64_SqlInt64_0;

		// Token: 0x04000D12 RID: 3346
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_SqlInt64_SqlInt64_SqlInt64_0;

		// Token: 0x04000D13 RID: 3347
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_SqlInt64_SqlInt64_SqlInt64_0;

		// Token: 0x04000D14 RID: 3348
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_SqlInt64_SqlInt64_SqlInt64_0;

		// Token: 0x04000D15 RID: 3349
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_SqlInt64_SqlInt64_SqlInt64_0;

		// Token: 0x04000D16 RID: 3350
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SqlInt64_SqlByte_0;

		// Token: 0x04000D17 RID: 3351
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SqlInt64_SqlInt16_0;

		// Token: 0x04000D18 RID: 3352
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SqlInt64_SqlInt32_0;

		// Token: 0x04000D19 RID: 3353
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_SqlInt64_SqlDecimal_0;

		// Token: 0x04000D1A RID: 3354
		private static readonly IntPtr NativeMethodInfoPtr_SameSignLong_Private_Static_Boolean_Int64_Int64_0;

		// Token: 0x04000D1B RID: 3355
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_SqlBoolean_SqlInt64_SqlInt64_0;

		// Token: 0x04000D1C RID: 3356
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_SqlBoolean_SqlInt64_SqlInt64_0;

		// Token: 0x04000D1D RID: 3357
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_SqlBoolean_SqlInt64_SqlInt64_0;

		// Token: 0x04000D1E RID: 3358
		private static readonly IntPtr NativeMethodInfoPtr_LessThan_Public_Static_SqlBoolean_SqlInt64_SqlInt64_0;

		// Token: 0x04000D1F RID: 3359
		private static readonly IntPtr NativeMethodInfoPtr_GreaterThan_Public_Static_SqlBoolean_SqlInt64_SqlInt64_0;

		// Token: 0x04000D20 RID: 3360
		private static readonly IntPtr NativeMethodInfoPtr_ToSqlByte_Public_SqlByte_0;

		// Token: 0x04000D21 RID: 3361
		private static readonly IntPtr NativeMethodInfoPtr_ToSqlDouble_Public_SqlDouble_0;

		// Token: 0x04000D22 RID: 3362
		private static readonly IntPtr NativeMethodInfoPtr_ToSqlInt16_Public_SqlInt16_0;

		// Token: 0x04000D23 RID: 3363
		private static readonly IntPtr NativeMethodInfoPtr_ToSqlInt32_Public_SqlInt32_0;

		// Token: 0x04000D24 RID: 3364
		private static readonly IntPtr NativeMethodInfoPtr_ToSqlDecimal_Public_SqlDecimal_0;

		// Token: 0x04000D25 RID: 3365
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000D26 RID: 3366
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Int32_SqlInt64_0;

		// Token: 0x04000D27 RID: 3367
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000D28 RID: 3368
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000D29 RID: 3369
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0;

		// Token: 0x04000D2A RID: 3370
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0;

		// Token: 0x04000D2B RID: 3371
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0;

		// Token: 0x04000D2C RID: 3372
		private static readonly IntPtr NativeMethodInfoPtr_GetXsdType_Public_Static_XmlQualifiedName_XmlSchemaSet_0;

		// Token: 0x04000D2D RID: 3373
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool m_fNotNull;

		// Token: 0x04000D2E RID: 3374
		[FieldOffset(8)]
		public long m_value;
	}
}
