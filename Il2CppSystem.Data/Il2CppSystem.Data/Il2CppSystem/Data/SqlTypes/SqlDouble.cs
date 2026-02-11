using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Data.SqlTypes
{
	// Token: 0x02000094 RID: 148
	[Serializable]
	[StructLayout(2)]
	public struct SqlDouble
	{
		// Token: 0x06000F1D RID: 3869 RVA: 0x00048F34 File Offset: 0x00047134
		// Note: this type is marked as 'beforefieldinit'.
		static SqlDouble()
		{
			Il2CppClassPointerStore<SqlDouble>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data.SqlTypes", "SqlDouble");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SqlDouble>.NativeClassPtr);
			SqlDouble.NativeFieldInfoPtr_m_fNotNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDouble>.NativeClassPtr, "m_fNotNull");
			SqlDouble.NativeFieldInfoPtr_m_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDouble>.NativeClassPtr, "m_value");
			SqlDouble.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDouble>.NativeClassPtr, "Null");
			SqlDouble.NativeFieldInfoPtr_Zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDouble>.NativeClassPtr, "Zero");
			SqlDouble.NativeFieldInfoPtr_MinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDouble>.NativeClassPtr, "MinValue");
			SqlDouble.NativeFieldInfoPtr_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDouble>.NativeClassPtr, "MaxValue");
			SqlDouble.NativeMethodInfoPtr__ctor_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDouble>.NativeClassPtr, 100665708);
			SqlDouble.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDouble>.NativeClassPtr, 100665709);
			SqlDouble.NativeMethodInfoPtr_get_IsNull_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDouble>.NativeClassPtr, 100665710);
			SqlDouble.NativeMethodInfoPtr_get_Value_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDouble>.NativeClassPtr, 100665711);
			SqlDouble.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDouble_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDouble>.NativeClassPtr, 100665712);
			SqlDouble.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDouble>.NativeClassPtr, 100665713);
			SqlDouble.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_SqlDouble_SqlDouble_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDouble>.NativeClassPtr, 100665714);
			SqlDouble.NativeMethodInfoPtr_op_Addition_Public_Static_SqlDouble_SqlDouble_SqlDouble_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDouble>.NativeClassPtr, 100665715);
			SqlDouble.NativeMethodInfoPtr_op_Subtraction_Public_Static_SqlDouble_SqlDouble_SqlDouble_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDouble>.NativeClassPtr, 100665716);
			SqlDouble.NativeMethodInfoPtr_op_Multiply_Public_Static_SqlDouble_SqlDouble_SqlDouble_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDouble>.NativeClassPtr, 100665717);
			SqlDouble.NativeMethodInfoPtr_op_Division_Public_Static_SqlDouble_SqlDouble_SqlDouble_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDouble>.NativeClassPtr, 100665718);
			SqlDouble.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDouble_SqlByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDouble>.NativeClassPtr, 100665719);
			SqlDouble.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDouble_SqlInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDouble>.NativeClassPtr, 100665720);
			SqlDouble.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDouble_SqlInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDouble>.NativeClassPtr, 100665721);
			SqlDouble.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDouble_SqlInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDouble>.NativeClassPtr, 100665722);
			SqlDouble.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDouble_SqlSingle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDouble>.NativeClassPtr, 100665723);
			SqlDouble.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDouble_SqlMoney_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDouble>.NativeClassPtr, 100665724);
			SqlDouble.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDouble_SqlDecimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDouble>.NativeClassPtr, 100665725);
			SqlDouble.NativeMethodInfoPtr_op_Equality_Public_Static_SqlBoolean_SqlDouble_SqlDouble_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDouble>.NativeClassPtr, 100665726);
			SqlDouble.NativeMethodInfoPtr_op_LessThan_Public_Static_SqlBoolean_SqlDouble_SqlDouble_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDouble>.NativeClassPtr, 100665727);
			SqlDouble.NativeMethodInfoPtr_op_GreaterThan_Public_Static_SqlBoolean_SqlDouble_SqlDouble_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDouble>.NativeClassPtr, 100665728);
			SqlDouble.NativeMethodInfoPtr_LessThan_Public_Static_SqlBoolean_SqlDouble_SqlDouble_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDouble>.NativeClassPtr, 100665729);
			SqlDouble.NativeMethodInfoPtr_GreaterThan_Public_Static_SqlBoolean_SqlDouble_SqlDouble_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDouble>.NativeClassPtr, 100665730);
			SqlDouble.NativeMethodInfoPtr_ToSqlSingle_Public_SqlSingle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDouble>.NativeClassPtr, 100665731);
			SqlDouble.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDouble>.NativeClassPtr, 100665732);
			SqlDouble.NativeMethodInfoPtr_CompareTo_Public_Int32_SqlDouble_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDouble>.NativeClassPtr, 100665733);
			SqlDouble.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDouble>.NativeClassPtr, 100665734);
			SqlDouble.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDouble>.NativeClassPtr, 100665735);
			SqlDouble.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDouble>.NativeClassPtr, 100665736);
			SqlDouble.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDouble>.NativeClassPtr, 100665737);
			SqlDouble.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDouble>.NativeClassPtr, 100665738);
			SqlDouble.NativeMethodInfoPtr_GetXsdType_Public_Static_XmlQualifiedName_XmlSchemaSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDouble>.NativeClassPtr, 100665739);
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x0004925C File Offset: 0x0004745C
		[CallerCount(0)]
		public unsafe SqlDouble(bool fNull)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fNull;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDouble.NativeMethodInfoPtr__ctor_Private_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x00049290 File Offset: 0x00047490
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 917735, RefRangeEnd = 917740, XrefRangeStart = 917735, XrefRangeEnd = 917735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlDouble(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDouble.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000F20 RID: 3872 RVA: 0x000492C4 File Offset: 0x000474C4
		public unsafe bool IsNull
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 786806, RefRangeEnd = 786824, XrefRangeStart = 786806, XrefRangeEnd = 786824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDouble.NativeMethodInfoPtr_get_IsNull_Public_Virtual_Final_New_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000F21 RID: 3873 RVA: 0x000492F4 File Offset: 0x000474F4
		public unsafe double Value
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 917740, RefRangeEnd = 917748, XrefRangeStart = 917740, XrefRangeEnd = 917740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDouble.NativeMethodInfoPtr_get_Value_Public_get_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F22 RID: 3874 RVA: 0x00049324 File Offset: 0x00047524
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 917749, RefRangeEnd = 917828, XrefRangeStart = 917748, XrefRangeEnd = 917749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SqlDouble(double x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDouble.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDouble_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F23 RID: 3875 RVA: 0x00049364 File Offset: 0x00047564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 917828, XrefRangeEnd = 917838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDouble.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x00049390 File Offset: 0x00047590
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 917844, RefRangeEnd = 917845, XrefRangeStart = 917838, XrefRangeEnd = 917844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlDouble operator -(SqlDouble x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDouble.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_SqlDouble_SqlDouble_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x000493D0 File Offset: 0x000475D0
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 917852, RefRangeEnd = 917871, XrefRangeStart = 917845, XrefRangeEnd = 917852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlDouble operator +(SqlDouble x, SqlDouble y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDouble.NativeMethodInfoPtr_op_Addition_Public_Static_SqlDouble_SqlDouble_SqlDouble_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x0004941C File Offset: 0x0004761C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 917878, RefRangeEnd = 917886, XrefRangeStart = 917871, XrefRangeEnd = 917878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlDouble operator -(SqlDouble x, SqlDouble y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDouble.NativeMethodInfoPtr_op_Subtraction_Public_Static_SqlDouble_SqlDouble_SqlDouble_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F27 RID: 3879 RVA: 0x00049468 File Offset: 0x00047668
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 917893, RefRangeEnd = 917925, XrefRangeStart = 917886, XrefRangeEnd = 917893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlDouble operator *(SqlDouble x, SqlDouble y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDouble.NativeMethodInfoPtr_op_Multiply_Public_Static_SqlDouble_SqlDouble_SqlDouble_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x000494B4 File Offset: 0x000476B4
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 917932, RefRangeEnd = 917950, XrefRangeStart = 917925, XrefRangeEnd = 917932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlDouble operator /(SqlDouble x, SqlDouble y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDouble.NativeMethodInfoPtr_op_Division_Public_Static_SqlDouble_SqlDouble_SqlDouble_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x00049500 File Offset: 0x00047700
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 917958, RefRangeEnd = 917959, XrefRangeStart = 917950, XrefRangeEnd = 917958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SqlDouble(SqlByte x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDouble.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDouble_SqlByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x00049540 File Offset: 0x00047740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 917959, XrefRangeEnd = 917967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SqlDouble(SqlInt16 x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDouble.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDouble_SqlInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x00049580 File Offset: 0x00047780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 917967, XrefRangeEnd = 917974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SqlDouble(SqlInt32 x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDouble.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDouble_SqlInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x000495C0 File Offset: 0x000477C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 917974, XrefRangeEnd = 917982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SqlDouble(SqlInt64 x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDouble.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDouble_SqlInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x00049600 File Offset: 0x00047800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 917982, XrefRangeEnd = 917990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SqlDouble(SqlSingle x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDouble.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDouble_SqlSingle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x00049640 File Offset: 0x00047840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 917990, XrefRangeEnd = 917998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SqlDouble(SqlMoney x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDouble.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDouble_SqlMoney_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F2F RID: 3887 RVA: 0x00049680 File Offset: 0x00047880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 917998, XrefRangeEnd = 918010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SqlDouble(SqlDecimal x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDouble.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDouble_SqlDecimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x000496C0 File Offset: 0x000478C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918010, XrefRangeEnd = 918017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean operator ==(SqlDouble x, SqlDouble y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDouble.NativeMethodInfoPtr_op_Equality_Public_Static_SqlBoolean_SqlDouble_SqlDouble_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x0004970C File Offset: 0x0004790C
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 918024, RefRangeEnd = 918040, XrefRangeStart = 918017, XrefRangeEnd = 918024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean operator <(SqlDouble x, SqlDouble y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDouble.NativeMethodInfoPtr_op_LessThan_Public_Static_SqlBoolean_SqlDouble_SqlDouble_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x00049758 File Offset: 0x00047958
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 918047, RefRangeEnd = 918048, XrefRangeStart = 918040, XrefRangeEnd = 918047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean operator >(SqlDouble x, SqlDouble y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDouble.NativeMethodInfoPtr_op_GreaterThan_Public_Static_SqlBoolean_SqlDouble_SqlDouble_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x000497A4 File Offset: 0x000479A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 918062, RefRangeEnd = 918063, XrefRangeStart = 918048, XrefRangeEnd = 918062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean LessThan(SqlDouble x, SqlDouble y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDouble.NativeMethodInfoPtr_LessThan_Public_Static_SqlBoolean_SqlDouble_SqlDouble_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x000497F0 File Offset: 0x000479F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 918077, RefRangeEnd = 918078, XrefRangeStart = 918063, XrefRangeEnd = 918077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean GreaterThan(SqlDouble x, SqlDouble y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDouble.NativeMethodInfoPtr_GreaterThan_Public_Static_SqlBoolean_SqlDouble_SqlDouble_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x0004983C File Offset: 0x00047A3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 918089, RefRangeEnd = 918090, XrefRangeStart = 918078, XrefRangeEnd = 918089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlSingle ToSqlSingle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDouble.NativeMethodInfoPtr_ToSqlSingle_Public_SqlSingle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x0004986C File Offset: 0x00047A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918090, XrefRangeEnd = 918096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDouble.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x000498B0 File Offset: 0x00047AB0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 918125, RefRangeEnd = 918129, XrefRangeStart = 918096, XrefRangeEnd = 918125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(SqlDouble value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDouble.NativeMethodInfoPtr_CompareTo_Public_Int32_SqlDouble_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x000498F0 File Offset: 0x00047AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918129, XrefRangeEnd = 918155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDouble.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x00049934 File Offset: 0x00047B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918155, XrefRangeEnd = 918159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDouble.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x00049964 File Offset: 0x00047B64
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchema System_Xml_Serialization_IXmlSerializable_GetSchema()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDouble.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x00049998 File Offset: 0x00047B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918159, XrefRangeEnd = 918167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Xml_Serialization_IXmlSerializable_ReadXml(XmlReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDouble.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x000499D0 File Offset: 0x00047BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918167, XrefRangeEnd = 918183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Xml_Serialization_IXmlSerializable_WriteXml(XmlWriter writer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDouble.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F3D RID: 3901 RVA: 0x00049A08 File Offset: 0x00047C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918183, XrefRangeEnd = 918191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaSet);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDouble.NativeMethodInfoPtr_GetXsdType_Public_Static_XmlQualifiedName_XmlSchemaSet_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
		}

		// Token: 0x06000F3E RID: 3902 RVA: 0x00006AD0 File Offset: 0x00004CD0
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SqlDouble>.NativeClassPtr, ref this));
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000F3F RID: 3903 RVA: 0x00049A4C File Offset: 0x00047C4C
		// (set) Token: 0x06000F40 RID: 3904 RVA: 0x00006AE2 File Offset: 0x00004CE2
		public unsafe static SqlDouble Null
		{
			get
			{
				SqlDouble sqlDouble;
				IL2CPP.il2cpp_field_static_get_value(SqlDouble.NativeFieldInfoPtr_Null, (void*)(&sqlDouble));
				return sqlDouble;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDouble.NativeFieldInfoPtr_Null, (void*)(&value));
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000F41 RID: 3905 RVA: 0x00049A68 File Offset: 0x00047C68
		// (set) Token: 0x06000F42 RID: 3906 RVA: 0x00006AF0 File Offset: 0x00004CF0
		public unsafe static SqlDouble Zero
		{
			get
			{
				SqlDouble sqlDouble;
				IL2CPP.il2cpp_field_static_get_value(SqlDouble.NativeFieldInfoPtr_Zero, (void*)(&sqlDouble));
				return sqlDouble;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDouble.NativeFieldInfoPtr_Zero, (void*)(&value));
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000F43 RID: 3907 RVA: 0x00049A84 File Offset: 0x00047C84
		// (set) Token: 0x06000F44 RID: 3908 RVA: 0x00006AFE File Offset: 0x00004CFE
		public unsafe static SqlDouble MinValue
		{
			get
			{
				SqlDouble sqlDouble;
				IL2CPP.il2cpp_field_static_get_value(SqlDouble.NativeFieldInfoPtr_MinValue, (void*)(&sqlDouble));
				return sqlDouble;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDouble.NativeFieldInfoPtr_MinValue, (void*)(&value));
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000F45 RID: 3909 RVA: 0x00049AA0 File Offset: 0x00047CA0
		// (set) Token: 0x06000F46 RID: 3910 RVA: 0x00006B0C File Offset: 0x00004D0C
		public unsafe static SqlDouble MaxValue
		{
			get
			{
				SqlDouble sqlDouble;
				IL2CPP.il2cpp_field_static_get_value(SqlDouble.NativeFieldInfoPtr_MaxValue, (void*)(&sqlDouble));
				return sqlDouble;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDouble.NativeFieldInfoPtr_MaxValue, (void*)(&value));
			}
		}

		// Token: 0x04000C77 RID: 3191
		private static readonly IntPtr NativeFieldInfoPtr_m_fNotNull;

		// Token: 0x04000C78 RID: 3192
		private static readonly IntPtr NativeFieldInfoPtr_m_value;

		// Token: 0x04000C79 RID: 3193
		private static readonly IntPtr NativeFieldInfoPtr_Null;

		// Token: 0x04000C7A RID: 3194
		private static readonly IntPtr NativeFieldInfoPtr_Zero;

		// Token: 0x04000C7B RID: 3195
		private static readonly IntPtr NativeFieldInfoPtr_MinValue;

		// Token: 0x04000C7C RID: 3196
		private static readonly IntPtr NativeFieldInfoPtr_MaxValue;

		// Token: 0x04000C7D RID: 3197
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Boolean_0;

		// Token: 0x04000C7E RID: 3198
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x04000C7F RID: 3199
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNull_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000C80 RID: 3200
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Double_0;

		// Token: 0x04000C81 RID: 3201
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDouble_Double_0;

		// Token: 0x04000C82 RID: 3202
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000C83 RID: 3203
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_SqlDouble_SqlDouble_0;

		// Token: 0x04000C84 RID: 3204
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_SqlDouble_SqlDouble_SqlDouble_0;

		// Token: 0x04000C85 RID: 3205
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_SqlDouble_SqlDouble_SqlDouble_0;

		// Token: 0x04000C86 RID: 3206
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_SqlDouble_SqlDouble_SqlDouble_0;

		// Token: 0x04000C87 RID: 3207
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_SqlDouble_SqlDouble_SqlDouble_0;

		// Token: 0x04000C88 RID: 3208
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDouble_SqlByte_0;

		// Token: 0x04000C89 RID: 3209
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDouble_SqlInt16_0;

		// Token: 0x04000C8A RID: 3210
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDouble_SqlInt32_0;

		// Token: 0x04000C8B RID: 3211
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDouble_SqlInt64_0;

		// Token: 0x04000C8C RID: 3212
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDouble_SqlSingle_0;

		// Token: 0x04000C8D RID: 3213
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDouble_SqlMoney_0;

		// Token: 0x04000C8E RID: 3214
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDouble_SqlDecimal_0;

		// Token: 0x04000C8F RID: 3215
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_SqlBoolean_SqlDouble_SqlDouble_0;

		// Token: 0x04000C90 RID: 3216
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_SqlBoolean_SqlDouble_SqlDouble_0;

		// Token: 0x04000C91 RID: 3217
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_SqlBoolean_SqlDouble_SqlDouble_0;

		// Token: 0x04000C92 RID: 3218
		private static readonly IntPtr NativeMethodInfoPtr_LessThan_Public_Static_SqlBoolean_SqlDouble_SqlDouble_0;

		// Token: 0x04000C93 RID: 3219
		private static readonly IntPtr NativeMethodInfoPtr_GreaterThan_Public_Static_SqlBoolean_SqlDouble_SqlDouble_0;

		// Token: 0x04000C94 RID: 3220
		private static readonly IntPtr NativeMethodInfoPtr_ToSqlSingle_Public_SqlSingle_0;

		// Token: 0x04000C95 RID: 3221
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000C96 RID: 3222
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Int32_SqlDouble_0;

		// Token: 0x04000C97 RID: 3223
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000C98 RID: 3224
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000C99 RID: 3225
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0;

		// Token: 0x04000C9A RID: 3226
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0;

		// Token: 0x04000C9B RID: 3227
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0;

		// Token: 0x04000C9C RID: 3228
		private static readonly IntPtr NativeMethodInfoPtr_GetXsdType_Public_Static_XmlQualifiedName_XmlSchemaSet_0;

		// Token: 0x04000C9D RID: 3229
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool m_fNotNull;

		// Token: 0x04000C9E RID: 3230
		[FieldOffset(8)]
		public double m_value;
	}
}
