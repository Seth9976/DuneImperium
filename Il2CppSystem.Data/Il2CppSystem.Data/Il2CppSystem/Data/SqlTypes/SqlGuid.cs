using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Data.SqlTypes
{
	// Token: 0x02000095 RID: 149
	[Serializable]
	public sealed class SqlGuid : ValueType
	{
		// Token: 0x06000F47 RID: 3911 RVA: 0x00049ABC File Offset: 0x00047CBC
		// Note: this type is marked as 'beforefieldinit'.
		static SqlGuid()
		{
			Il2CppClassPointerStore<SqlGuid>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data.SqlTypes", "SqlGuid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SqlGuid>.NativeClassPtr);
			SqlGuid.NativeFieldInfoPtr_s_sizeOfGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlGuid>.NativeClassPtr, "s_sizeOfGuid");
			SqlGuid.NativeFieldInfoPtr_s_rgiGuidOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlGuid>.NativeClassPtr, "s_rgiGuidOrder");
			SqlGuid.NativeFieldInfoPtr_m_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlGuid>.NativeClassPtr, "m_value");
			SqlGuid.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlGuid>.NativeClassPtr, "Null");
			SqlGuid.NativeMethodInfoPtr__ctor_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlGuid>.NativeClassPtr, 100665741);
			SqlGuid.NativeMethodInfoPtr__ctor_Public_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlGuid>.NativeClassPtr, 100665742);
			SqlGuid.NativeMethodInfoPtr_get_IsNull_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlGuid>.NativeClassPtr, 100665743);
			SqlGuid.NativeMethodInfoPtr_get_Value_Public_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlGuid>.NativeClassPtr, 100665744);
			SqlGuid.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlGuid_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlGuid>.NativeClassPtr, 100665745);
			SqlGuid.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlGuid>.NativeClassPtr, 100665746);
			SqlGuid.NativeMethodInfoPtr_Compare_Private_Static_EComparison_SqlGuid_SqlGuid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlGuid>.NativeClassPtr, 100665747);
			SqlGuid.NativeMethodInfoPtr_op_Equality_Public_Static_SqlBoolean_SqlGuid_SqlGuid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlGuid>.NativeClassPtr, 100665748);
			SqlGuid.NativeMethodInfoPtr_op_LessThan_Public_Static_SqlBoolean_SqlGuid_SqlGuid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlGuid>.NativeClassPtr, 100665749);
			SqlGuid.NativeMethodInfoPtr_op_GreaterThan_Public_Static_SqlBoolean_SqlGuid_SqlGuid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlGuid>.NativeClassPtr, 100665750);
			SqlGuid.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlGuid>.NativeClassPtr, 100665751);
			SqlGuid.NativeMethodInfoPtr_CompareTo_Public_Int32_SqlGuid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlGuid>.NativeClassPtr, 100665752);
			SqlGuid.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlGuid>.NativeClassPtr, 100665753);
			SqlGuid.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlGuid>.NativeClassPtr, 100665754);
			SqlGuid.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlGuid>.NativeClassPtr, 100665755);
			SqlGuid.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlGuid>.NativeClassPtr, 100665756);
			SqlGuid.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlGuid>.NativeClassPtr, 100665757);
			SqlGuid.NativeMethodInfoPtr_GetXsdType_Public_Static_XmlQualifiedName_XmlSchemaSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlGuid>.NativeClassPtr, 100665758);
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x00049CA4 File Offset: 0x00047EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlGuid(bool fNull)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SqlGuid>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fNull;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlGuid.NativeMethodInfoPtr__ctor_Private_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x00049CF0 File Offset: 0x00047EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918191, XrefRangeEnd = 918193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlGuid(Guid g)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SqlGuid>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref g;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlGuid.NativeMethodInfoPtr__ctor_Public_Void_Guid_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000F4A RID: 3914 RVA: 0x00049D3C File Offset: 0x00047F3C
		public unsafe bool IsNull
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 745863, RefRangeEnd = 745876, XrefRangeStart = 745863, XrefRangeEnd = 745876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlGuid.NativeMethodInfoPtr_get_IsNull_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000F4B RID: 3915 RVA: 0x00049D80 File Offset: 0x00047F80
		public unsafe Guid Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918193, XrefRangeEnd = 918197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlGuid.NativeMethodInfoPtr_get_Value_Public_get_Guid_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x00049DC4 File Offset: 0x00047FC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 918199, RefRangeEnd = 918200, XrefRangeStart = 918197, XrefRangeEnd = 918199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SqlGuid(Guid x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlGuid.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlGuid_Guid_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new SqlGuid(intPtr);
			}
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x00049DFC File Offset: 0x00047FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918200, XrefRangeEnd = 918205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlGuid.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x00049E38 File Offset: 0x00048038
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 918213, RefRangeEnd = 918219, XrefRangeStart = 918205, XrefRangeEnd = 918213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EComparison Compare(SqlGuid x, SqlGuid y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlGuid.NativeMethodInfoPtr_Compare_Private_Static_EComparison_SqlGuid_SqlGuid_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x00049E98 File Offset: 0x00048098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918219, XrefRangeEnd = 918229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean operator ==(SqlGuid x, SqlGuid y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlGuid.NativeMethodInfoPtr_op_Equality_Public_Static_SqlBoolean_SqlGuid_SqlGuid_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x00049EF8 File Offset: 0x000480F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918229, XrefRangeEnd = 918239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean operator <(SqlGuid x, SqlGuid y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlGuid.NativeMethodInfoPtr_op_LessThan_Public_Static_SqlBoolean_SqlGuid_SqlGuid_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x00049F58 File Offset: 0x00048158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918239, XrefRangeEnd = 918249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean operator >(SqlGuid x, SqlGuid y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlGuid.NativeMethodInfoPtr_op_GreaterThan_Public_Static_SqlBoolean_SqlGuid_SqlGuid_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x00049FB8 File Offset: 0x000481B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 918267, RefRangeEnd = 918268, XrefRangeStart = 918249, XrefRangeEnd = 918267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlGuid.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x0004A00C File Offset: 0x0004820C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 918313, RefRangeEnd = 918316, XrefRangeStart = 918268, XrefRangeEnd = 918313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(SqlGuid value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlGuid.NativeMethodInfoPtr_CompareTo_Public_Int32_SqlGuid_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x0004A064 File Offset: 0x00048264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918316, XrefRangeEnd = 918340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlGuid.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x0004A0B8 File Offset: 0x000482B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918340, XrefRangeEnd = 918343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlGuid.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x0004A0FC File Offset: 0x000482FC
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchema System_Xml_Serialization_IXmlSerializable_GetSchema()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlGuid.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x0004A140 File Offset: 0x00048340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918343, XrefRangeEnd = 918352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Xml_Serialization_IXmlSerializable_ReadXml(XmlReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlGuid.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x0004A188 File Offset: 0x00048388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918352, XrefRangeEnd = 918364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Xml_Serialization_IXmlSerializable_WriteXml(XmlWriter writer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlGuid.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x0004A1D0 File Offset: 0x000483D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 918364, XrefRangeEnd = 918372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaSet);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlGuid.NativeMethodInfoPtr_GetXsdType_Public_Static_XmlQualifiedName_XmlSchemaSet_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x00006B1A File Offset: 0x00004D1A
		public SqlGuid(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x00006B23 File Offset: 0x00004D23
		public SqlGuid()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SqlGuid>.NativeClassPtr))
		{
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000F5C RID: 3932 RVA: 0x0004A214 File Offset: 0x00048414
		// (set) Token: 0x06000F5D RID: 3933 RVA: 0x00006B35 File Offset: 0x00004D35
		public unsafe static int s_sizeOfGuid
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SqlGuid.NativeFieldInfoPtr_s_sizeOfGuid, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlGuid.NativeFieldInfoPtr_s_sizeOfGuid, (void*)(&value));
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000F5E RID: 3934 RVA: 0x0004A230 File Offset: 0x00048430
		// (set) Token: 0x06000F5F RID: 3935 RVA: 0x00006B43 File Offset: 0x00004D43
		public unsafe static Il2CppStructArray<int> s_rgiGuidOrder
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SqlGuid.NativeFieldInfoPtr_s_rgiGuidOrder, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlGuid.NativeFieldInfoPtr_s_rgiGuidOrder, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000F60 RID: 3936 RVA: 0x0004A258 File Offset: 0x00048458
		// (set) Token: 0x06000F61 RID: 3937 RVA: 0x00006B55 File Offset: 0x00004D55
		public unsafe Il2CppStructArray<byte> m_value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SqlGuid.NativeFieldInfoPtr_m_value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SqlGuid.NativeFieldInfoPtr_m_value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000F62 RID: 3938 RVA: 0x0004A288 File Offset: 0x00048488
		// (set) Token: 0x06000F63 RID: 3939 RVA: 0x00006B74 File Offset: 0x00004D74
		public unsafe static SqlGuid Null
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SqlGuid>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(SqlGuid.NativeFieldInfoPtr_Null, intPtr);
				return new SqlGuid(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SqlGuid>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlGuid.NativeFieldInfoPtr_Null, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x04000C9F RID: 3231
		private static readonly IntPtr NativeFieldInfoPtr_s_sizeOfGuid;

		// Token: 0x04000CA0 RID: 3232
		private static readonly IntPtr NativeFieldInfoPtr_s_rgiGuidOrder;

		// Token: 0x04000CA1 RID: 3233
		private static readonly IntPtr NativeFieldInfoPtr_m_value;

		// Token: 0x04000CA2 RID: 3234
		private static readonly IntPtr NativeFieldInfoPtr_Null;

		// Token: 0x04000CA3 RID: 3235
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Boolean_0;

		// Token: 0x04000CA4 RID: 3236
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_0;

		// Token: 0x04000CA5 RID: 3237
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNull_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000CA6 RID: 3238
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Guid_0;

		// Token: 0x04000CA7 RID: 3239
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SqlGuid_Guid_0;

		// Token: 0x04000CA8 RID: 3240
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000CA9 RID: 3241
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Private_Static_EComparison_SqlGuid_SqlGuid_0;

		// Token: 0x04000CAA RID: 3242
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_SqlBoolean_SqlGuid_SqlGuid_0;

		// Token: 0x04000CAB RID: 3243
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_SqlBoolean_SqlGuid_SqlGuid_0;

		// Token: 0x04000CAC RID: 3244
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_SqlBoolean_SqlGuid_SqlGuid_0;

		// Token: 0x04000CAD RID: 3245
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000CAE RID: 3246
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Int32_SqlGuid_0;

		// Token: 0x04000CAF RID: 3247
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000CB0 RID: 3248
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000CB1 RID: 3249
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0;

		// Token: 0x04000CB2 RID: 3250
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0;

		// Token: 0x04000CB3 RID: 3251
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0;

		// Token: 0x04000CB4 RID: 3252
		private static readonly IntPtr NativeMethodInfoPtr_GetXsdType_Public_Static_XmlQualifiedName_XmlSchemaSet_0;
	}
}
