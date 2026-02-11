using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Data.SqlTypes
{
	// Token: 0x02000096 RID: 150
	[Serializable]
	[StructLayout(2)]
	public struct SqlInt16
	{
		// Token: 0x06000F64 RID: 3940 RVA: 0x0004A2C4 File Offset: 0x000484C4
		// Note: this type is marked as 'beforefieldinit'.
		static SqlInt16()
		{
			Il2CppClassPointerStore<SqlInt16>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data.SqlTypes", "SqlInt16");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SqlInt16>.NativeClassPtr);
			SqlInt16.NativeFieldInfoPtr_m_fNotNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlInt16>.NativeClassPtr, "m_fNotNull");
			SqlInt16.NativeFieldInfoPtr_m_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlInt16>.NativeClassPtr, "m_value");
			SqlInt16.NativeFieldInfoPtr_s_MASKI2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlInt16>.NativeClassPtr, "s_MASKI2");
			SqlInt16.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlInt16>.NativeClassPtr, "Null");
			SqlInt16.NativeFieldInfoPtr_Zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlInt16>.NativeClassPtr, "Zero");
			SqlInt16.NativeFieldInfoPtr_MinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlInt16>.NativeClassPtr, "MinValue");
			SqlInt16.NativeFieldInfoPtr_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlInt16>.NativeClassPtr, "MaxValue");
			SqlInt16.NativeMethodInfoPtr__ctor_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt16>.NativeClassPtr, 100665760);
			SqlInt16.NativeMethodInfoPtr__ctor_Public_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt16>.NativeClassPtr, 100665761);
			SqlInt16.NativeMethodInfoPtr_get_IsNull_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt16>.NativeClassPtr, 100665762);
			SqlInt16.NativeMethodInfoPtr_get_Value_Public_get_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt16>.NativeClassPtr, 100665763);
			SqlInt16.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlInt16_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt16>.NativeClassPtr, 100665764);
			SqlInt16.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt16>.NativeClassPtr, 100665765);
			SqlInt16.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_SqlInt16_SqlInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt16>.NativeClassPtr, 100665766);
			SqlInt16.NativeMethodInfoPtr_op_Addition_Public_Static_SqlInt16_SqlInt16_SqlInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt16>.NativeClassPtr, 100665767);
			SqlInt16.NativeMethodInfoPtr_op_Subtraction_Public_Static_SqlInt16_SqlInt16_SqlInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt16>.NativeClassPtr, 100665768);
			SqlInt16.NativeMethodInfoPtr_op_Multiply_Public_Static_SqlInt16_SqlInt16_SqlInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt16>.NativeClassPtr, 100665769);
			SqlInt16.NativeMethodInfoPtr_op_Division_Public_Static_SqlInt16_SqlInt16_SqlInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt16>.NativeClassPtr, 100665770);
			SqlInt16.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlInt16_SqlByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt16>.NativeClassPtr, 100665771);
			SqlInt16.NativeMethodInfoPtr_op_Explicit_Public_Static_SqlInt16_SqlInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt16>.NativeClassPtr, 100665772);
			SqlInt16.NativeMethodInfoPtr_op_Equality_Public_Static_SqlBoolean_SqlInt16_SqlInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt16>.NativeClassPtr, 100665773);
			SqlInt16.NativeMethodInfoPtr_op_LessThan_Public_Static_SqlBoolean_SqlInt16_SqlInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt16>.NativeClassPtr, 100665774);
			SqlInt16.NativeMethodInfoPtr_op_GreaterThan_Public_Static_SqlBoolean_SqlInt16_SqlInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt16>.NativeClassPtr, 100665775);
			SqlInt16.NativeMethodInfoPtr_LessThan_Public_Static_SqlBoolean_SqlInt16_SqlInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt16>.NativeClassPtr, 100665776);
			SqlInt16.NativeMethodInfoPtr_GreaterThan_Public_Static_SqlBoolean_SqlInt16_SqlInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt16>.NativeClassPtr, 100665777);
			SqlInt16.NativeMethodInfoPtr_ToSqlDouble_Public_SqlDouble_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt16>.NativeClassPtr, 100665778);
			SqlInt16.NativeMethodInfoPtr_ToSqlInt64_Public_SqlInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt16>.NativeClassPtr, 100665779);
			SqlInt16.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt16>.NativeClassPtr, 100665780);
			SqlInt16.NativeMethodInfoPtr_CompareTo_Public_Int32_SqlInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt16>.NativeClassPtr, 100665781);
			SqlInt16.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt16>.NativeClassPtr, 100665782);
			SqlInt16.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt16>.NativeClassPtr, 100665783);
			SqlInt16.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt16>.NativeClassPtr, 100665784);
			SqlInt16.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt16>.NativeClassPtr, 100665785);
			SqlInt16.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt16>.NativeClassPtr, 100665786);
			SqlInt16.NativeMethodInfoPtr_GetXsdType_Public_Static_XmlQualifiedName_XmlSchemaSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlInt16>.NativeClassPtr, 100665787);
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x0004A5B0 File Offset: 0x000487B0
		[CallerCount(0)]
		public unsafe SqlInt16(bool fNull)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fNull;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt16.NativeMethodInfoPtr__ctor_Private_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x0004A5E4 File Offset: 0x000487E4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 786838, RefRangeEnd = 786847, XrefRangeStart = 786838, XrefRangeEnd = 786847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlInt16(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt16.NativeMethodInfoPtr__ctor_Public_Void_Int16_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000F67 RID: 3943 RVA: 0x0004A618 File Offset: 0x00048818
		public unsafe bool IsNull
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 786806, RefRangeEnd = 786824, XrefRangeStart = 786806, XrefRangeEnd = 786824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt16.NativeMethodInfoPtr_get_IsNull_Public_Virtual_Final_New_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000F68 RID: 3944 RVA: 0x0004A648 File Offset: 0x00048848
		public unsafe short Value
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt16.NativeMethodInfoPtr_get_Value_Public_get_Int16_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x0004A678 File Offset: 0x00048878
		[CallerCount(691)]
		[CachedScanResults(RefRangeStart = 786858, RefRangeEnd = 787549, XrefRangeStart = 786858, XrefRangeEnd = 787549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SqlInt16(short x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt16.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlInt16_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x0004A6B8 File Offset: 0x000488B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918372, XrefRangeEnd = 918383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt16.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x0004A6E4 File Offset: 0x000488E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 918389, RefRangeEnd = 918390, XrefRangeStart = 918383, XrefRangeEnd = 918389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlInt16 operator -(SqlInt16 x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt16.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_SqlInt16_SqlInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x0004A724 File Offset: 0x00048924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918390, XrefRangeEnd = 918396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlInt16 operator +(SqlInt16 x, SqlInt16 y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt16.NativeMethodInfoPtr_op_Addition_Public_Static_SqlInt16_SqlInt16_SqlInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x0004A770 File Offset: 0x00048970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918396, XrefRangeEnd = 918402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlInt16 operator -(SqlInt16 x, SqlInt16 y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt16.NativeMethodInfoPtr_op_Subtraction_Public_Static_SqlInt16_SqlInt16_SqlInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x0004A7BC File Offset: 0x000489BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918402, XrefRangeEnd = 918412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlInt16 operator *(SqlInt16 x, SqlInt16 y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt16.NativeMethodInfoPtr_op_Multiply_Public_Static_SqlInt16_SqlInt16_SqlInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x0004A808 File Offset: 0x00048A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918412, XrefRangeEnd = 918418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlInt16 operator /(SqlInt16 x, SqlInt16 y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt16.NativeMethodInfoPtr_op_Division_Public_Static_SqlInt16_SqlInt16_SqlInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x0004A854 File Offset: 0x00048A54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 918426, RefRangeEnd = 918427, XrefRangeStart = 918418, XrefRangeEnd = 918426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SqlInt16(SqlByte x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt16.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlInt16_SqlByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x0004A894 File Offset: 0x00048A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918427, XrefRangeEnd = 918433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator SqlInt16(SqlInt64 x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt16.NativeMethodInfoPtr_op_Explicit_Public_Static_SqlInt16_SqlInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x0004A8D4 File Offset: 0x00048AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918433, XrefRangeEnd = 918440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean operator ==(SqlInt16 x, SqlInt16 y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt16.NativeMethodInfoPtr_op_Equality_Public_Static_SqlBoolean_SqlInt16_SqlInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x0004A920 File Offset: 0x00048B20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 918447, RefRangeEnd = 918449, XrefRangeStart = 918440, XrefRangeEnd = 918447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean operator <(SqlInt16 x, SqlInt16 y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt16.NativeMethodInfoPtr_op_LessThan_Public_Static_SqlBoolean_SqlInt16_SqlInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x0004A96C File Offset: 0x00048B6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 918456, RefRangeEnd = 918458, XrefRangeStart = 918449, XrefRangeEnd = 918456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean operator >(SqlInt16 x, SqlInt16 y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt16.NativeMethodInfoPtr_op_GreaterThan_Public_Static_SqlBoolean_SqlInt16_SqlInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x0004A9B8 File Offset: 0x00048BB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 918462, RefRangeEnd = 918463, XrefRangeStart = 918458, XrefRangeEnd = 918462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean LessThan(SqlInt16 x, SqlInt16 y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt16.NativeMethodInfoPtr_LessThan_Public_Static_SqlBoolean_SqlInt16_SqlInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x0004AA04 File Offset: 0x00048C04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 918467, RefRangeEnd = 918468, XrefRangeStart = 918463, XrefRangeEnd = 918467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean GreaterThan(SqlInt16 x, SqlInt16 y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt16.NativeMethodInfoPtr_GreaterThan_Public_Static_SqlBoolean_SqlInt16_SqlInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x0004AA50 File Offset: 0x00048C50
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 918479, RefRangeEnd = 918482, XrefRangeStart = 918468, XrefRangeEnd = 918479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlDouble ToSqlDouble()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt16.NativeMethodInfoPtr_ToSqlDouble_Public_SqlDouble_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x0004AA80 File Offset: 0x00048C80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 918493, RefRangeEnd = 918494, XrefRangeStart = 918482, XrefRangeEnd = 918493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlInt64 ToSqlInt64()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt16.NativeMethodInfoPtr_ToSqlInt64_Public_SqlInt64_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x0004AAB0 File Offset: 0x00048CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918494, XrefRangeEnd = 918512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt16.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x0004AAF4 File Offset: 0x00048CF4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 918530, RefRangeEnd = 918533, XrefRangeStart = 918512, XrefRangeEnd = 918530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(SqlInt16 value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt16.NativeMethodInfoPtr_CompareTo_Public_Int32_SqlInt16_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x0004AB34 File Offset: 0x00048D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918533, XrefRangeEnd = 918558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt16.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x0004AB78 File Offset: 0x00048D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918558, XrefRangeEnd = 918562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt16.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x0004ABA8 File Offset: 0x00048DA8
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchema System_Xml_Serialization_IXmlSerializable_GetSchema()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt16.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x0004ABDC File Offset: 0x00048DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918562, XrefRangeEnd = 918570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Xml_Serialization_IXmlSerializable_ReadXml(XmlReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt16.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x0004AC14 File Offset: 0x00048E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918570, XrefRangeEnd = 918586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Xml_Serialization_IXmlSerializable_WriteXml(XmlWriter writer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt16.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x0004AC4C File Offset: 0x00048E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918586, XrefRangeEnd = 918594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaSet);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlInt16.NativeMethodInfoPtr_GetXsdType_Public_Static_XmlQualifiedName_XmlSchemaSet_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x00006B8B File Offset: 0x00004D8B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SqlInt16>.NativeClassPtr, ref this));
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000F82 RID: 3970 RVA: 0x0004AC90 File Offset: 0x00048E90
		// (set) Token: 0x06000F83 RID: 3971 RVA: 0x00006B9D File Offset: 0x00004D9D
		public unsafe static int s_MASKI2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SqlInt16.NativeFieldInfoPtr_s_MASKI2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlInt16.NativeFieldInfoPtr_s_MASKI2, (void*)(&value));
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000F84 RID: 3972 RVA: 0x0004ACAC File Offset: 0x00048EAC
		// (set) Token: 0x06000F85 RID: 3973 RVA: 0x00006BAB File Offset: 0x00004DAB
		public unsafe static SqlInt16 Null
		{
			get
			{
				SqlInt16 sqlInt;
				IL2CPP.il2cpp_field_static_get_value(SqlInt16.NativeFieldInfoPtr_Null, (void*)(&sqlInt));
				return sqlInt;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlInt16.NativeFieldInfoPtr_Null, (void*)(&value));
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000F86 RID: 3974 RVA: 0x0004ACC8 File Offset: 0x00048EC8
		// (set) Token: 0x06000F87 RID: 3975 RVA: 0x00006BB9 File Offset: 0x00004DB9
		public unsafe static SqlInt16 Zero
		{
			get
			{
				SqlInt16 sqlInt;
				IL2CPP.il2cpp_field_static_get_value(SqlInt16.NativeFieldInfoPtr_Zero, (void*)(&sqlInt));
				return sqlInt;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlInt16.NativeFieldInfoPtr_Zero, (void*)(&value));
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000F88 RID: 3976 RVA: 0x0004ACE4 File Offset: 0x00048EE4
		// (set) Token: 0x06000F89 RID: 3977 RVA: 0x00006BC7 File Offset: 0x00004DC7
		public unsafe static SqlInt16 MinValue
		{
			get
			{
				SqlInt16 sqlInt;
				IL2CPP.il2cpp_field_static_get_value(SqlInt16.NativeFieldInfoPtr_MinValue, (void*)(&sqlInt));
				return sqlInt;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlInt16.NativeFieldInfoPtr_MinValue, (void*)(&value));
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000F8A RID: 3978 RVA: 0x0004AD00 File Offset: 0x00048F00
		// (set) Token: 0x06000F8B RID: 3979 RVA: 0x00006BD5 File Offset: 0x00004DD5
		public unsafe static SqlInt16 MaxValue
		{
			get
			{
				SqlInt16 sqlInt;
				IL2CPP.il2cpp_field_static_get_value(SqlInt16.NativeFieldInfoPtr_MaxValue, (void*)(&sqlInt));
				return sqlInt;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlInt16.NativeFieldInfoPtr_MaxValue, (void*)(&value));
			}
		}

		// Token: 0x04000CB5 RID: 3253
		private static readonly IntPtr NativeFieldInfoPtr_m_fNotNull;

		// Token: 0x04000CB6 RID: 3254
		private static readonly IntPtr NativeFieldInfoPtr_m_value;

		// Token: 0x04000CB7 RID: 3255
		private static readonly IntPtr NativeFieldInfoPtr_s_MASKI2;

		// Token: 0x04000CB8 RID: 3256
		private static readonly IntPtr NativeFieldInfoPtr_Null;

		// Token: 0x04000CB9 RID: 3257
		private static readonly IntPtr NativeFieldInfoPtr_Zero;

		// Token: 0x04000CBA RID: 3258
		private static readonly IntPtr NativeFieldInfoPtr_MinValue;

		// Token: 0x04000CBB RID: 3259
		private static readonly IntPtr NativeFieldInfoPtr_MaxValue;

		// Token: 0x04000CBC RID: 3260
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Boolean_0;

		// Token: 0x04000CBD RID: 3261
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int16_0;

		// Token: 0x04000CBE RID: 3262
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNull_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000CBF RID: 3263
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Int16_0;

		// Token: 0x04000CC0 RID: 3264
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SqlInt16_Int16_0;

		// Token: 0x04000CC1 RID: 3265
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000CC2 RID: 3266
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_SqlInt16_SqlInt16_0;

		// Token: 0x04000CC3 RID: 3267
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_SqlInt16_SqlInt16_SqlInt16_0;

		// Token: 0x04000CC4 RID: 3268
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_SqlInt16_SqlInt16_SqlInt16_0;

		// Token: 0x04000CC5 RID: 3269
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_SqlInt16_SqlInt16_SqlInt16_0;

		// Token: 0x04000CC6 RID: 3270
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_SqlInt16_SqlInt16_SqlInt16_0;

		// Token: 0x04000CC7 RID: 3271
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SqlInt16_SqlByte_0;

		// Token: 0x04000CC8 RID: 3272
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_SqlInt16_SqlInt64_0;

		// Token: 0x04000CC9 RID: 3273
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_SqlBoolean_SqlInt16_SqlInt16_0;

		// Token: 0x04000CCA RID: 3274
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_SqlBoolean_SqlInt16_SqlInt16_0;

		// Token: 0x04000CCB RID: 3275
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_SqlBoolean_SqlInt16_SqlInt16_0;

		// Token: 0x04000CCC RID: 3276
		private static readonly IntPtr NativeMethodInfoPtr_LessThan_Public_Static_SqlBoolean_SqlInt16_SqlInt16_0;

		// Token: 0x04000CCD RID: 3277
		private static readonly IntPtr NativeMethodInfoPtr_GreaterThan_Public_Static_SqlBoolean_SqlInt16_SqlInt16_0;

		// Token: 0x04000CCE RID: 3278
		private static readonly IntPtr NativeMethodInfoPtr_ToSqlDouble_Public_SqlDouble_0;

		// Token: 0x04000CCF RID: 3279
		private static readonly IntPtr NativeMethodInfoPtr_ToSqlInt64_Public_SqlInt64_0;

		// Token: 0x04000CD0 RID: 3280
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000CD1 RID: 3281
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Int32_SqlInt16_0;

		// Token: 0x04000CD2 RID: 3282
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000CD3 RID: 3283
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000CD4 RID: 3284
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0;

		// Token: 0x04000CD5 RID: 3285
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0;

		// Token: 0x04000CD6 RID: 3286
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0;

		// Token: 0x04000CD7 RID: 3287
		private static readonly IntPtr NativeMethodInfoPtr_GetXsdType_Public_Static_XmlQualifiedName_XmlSchemaSet_0;

		// Token: 0x04000CD8 RID: 3288
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool m_fNotNull;

		// Token: 0x04000CD9 RID: 3289
		[FieldOffset(2)]
		public short m_value;
	}
}
