using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Data.SqlTypes
{
	// Token: 0x0200008D RID: 141
	[Serializable]
	[StructLayout(2)]
	public struct SqlBoolean
	{
		// Token: 0x06000D98 RID: 3480 RVA: 0x00043EC8 File Offset: 0x000420C8
		// Note: this type is marked as 'beforefieldinit'.
		static SqlBoolean()
		{
			Il2CppClassPointerStore<SqlBoolean>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data.SqlTypes", "SqlBoolean");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SqlBoolean>.NativeClassPtr);
			SqlBoolean.NativeFieldInfoPtr_m_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlBoolean>.NativeClassPtr, "m_value");
			SqlBoolean.NativeFieldInfoPtr_True = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlBoolean>.NativeClassPtr, "True");
			SqlBoolean.NativeFieldInfoPtr_False = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlBoolean>.NativeClassPtr, "False");
			SqlBoolean.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlBoolean>.NativeClassPtr, "Null");
			SqlBoolean.NativeFieldInfoPtr_Zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlBoolean>.NativeClassPtr, "Zero");
			SqlBoolean.NativeFieldInfoPtr_One = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlBoolean>.NativeClassPtr, "One");
			SqlBoolean.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlBoolean>.NativeClassPtr, 100665523);
			SqlBoolean.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlBoolean>.NativeClassPtr, 100665524);
			SqlBoolean.NativeMethodInfoPtr__ctor_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlBoolean>.NativeClassPtr, 100665525);
			SqlBoolean.NativeMethodInfoPtr_get_IsNull_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlBoolean>.NativeClassPtr, 100665526);
			SqlBoolean.NativeMethodInfoPtr_get_Value_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlBoolean>.NativeClassPtr, 100665527);
			SqlBoolean.NativeMethodInfoPtr_get_IsTrue_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlBoolean>.NativeClassPtr, 100665528);
			SqlBoolean.NativeMethodInfoPtr_get_IsFalse_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlBoolean>.NativeClassPtr, 100665529);
			SqlBoolean.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlBoolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlBoolean>.NativeClassPtr, 100665530);
			SqlBoolean.NativeMethodInfoPtr_op_True_Public_Static_Boolean_SqlBoolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlBoolean>.NativeClassPtr, 100665531);
			SqlBoolean.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_SqlBoolean_SqlBoolean_SqlBoolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlBoolean>.NativeClassPtr, 100665532);
			SqlBoolean.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_SqlBoolean_SqlBoolean_SqlBoolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlBoolean>.NativeClassPtr, 100665533);
			SqlBoolean.NativeMethodInfoPtr_get_ByteValue_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlBoolean>.NativeClassPtr, 100665534);
			SqlBoolean.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlBoolean>.NativeClassPtr, 100665535);
			SqlBoolean.NativeMethodInfoPtr_op_Equality_Public_Static_SqlBoolean_SqlBoolean_SqlBoolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlBoolean>.NativeClassPtr, 100665536);
			SqlBoolean.NativeMethodInfoPtr_And_Public_Static_SqlBoolean_SqlBoolean_SqlBoolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlBoolean>.NativeClassPtr, 100665537);
			SqlBoolean.NativeMethodInfoPtr_Or_Public_Static_SqlBoolean_SqlBoolean_SqlBoolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlBoolean>.NativeClassPtr, 100665538);
			SqlBoolean.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlBoolean>.NativeClassPtr, 100665539);
			SqlBoolean.NativeMethodInfoPtr_CompareTo_Public_Int32_SqlBoolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlBoolean>.NativeClassPtr, 100665540);
			SqlBoolean.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlBoolean>.NativeClassPtr, 100665541);
			SqlBoolean.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlBoolean>.NativeClassPtr, 100665542);
			SqlBoolean.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlBoolean>.NativeClassPtr, 100665543);
			SqlBoolean.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlBoolean>.NativeClassPtr, 100665544);
			SqlBoolean.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlBoolean>.NativeClassPtr, 100665545);
			SqlBoolean.NativeMethodInfoPtr_GetXsdType_Public_Static_XmlQualifiedName_XmlSchemaSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlBoolean>.NativeClassPtr, 100665546);
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x00044150 File Offset: 0x00042350
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 915342, RefRangeEnd = 915394, XrefRangeStart = 915342, XrefRangeEnd = 915342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlBoolean(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlBoolean.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x00044184 File Offset: 0x00042384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915394, XrefRangeEnd = 915397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlBoolean(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlBoolean.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x000441B8 File Offset: 0x000423B8
		[CallerCount(0)]
		public unsafe SqlBoolean(int value, bool fNull)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fNull;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlBoolean.NativeMethodInfoPtr__ctor_Private_Void_Int32_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000D9C RID: 3484 RVA: 0x000441F8 File Offset: 0x000423F8
		public unsafe bool IsNull
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 786806, RefRangeEnd = 786824, XrefRangeStart = 786806, XrefRangeEnd = 786824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlBoolean.NativeMethodInfoPtr_get_IsNull_Public_Virtual_Final_New_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000D9D RID: 3485 RVA: 0x00044228 File Offset: 0x00042428
		public unsafe bool Value
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 915397, RefRangeEnd = 915407, XrefRangeStart = 915397, XrefRangeEnd = 915397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlBoolean.NativeMethodInfoPtr_get_Value_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000D9E RID: 3486 RVA: 0x00044258 File Offset: 0x00042458
		public unsafe bool IsTrue
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 915407, RefRangeEnd = 915426, XrefRangeStart = 915407, XrefRangeEnd = 915407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlBoolean.NativeMethodInfoPtr_get_IsTrue_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000D9F RID: 3487 RVA: 0x00044288 File Offset: 0x00042488
		public unsafe bool IsFalse
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 915426, RefRangeEnd = 915427, XrefRangeStart = 915426, XrefRangeEnd = 915426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlBoolean.NativeMethodInfoPtr_get_IsFalse_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x000442B8 File Offset: 0x000424B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 915427, RefRangeEnd = 915430, XrefRangeStart = 915427, XrefRangeEnd = 915427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SqlBoolean(bool x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlBoolean.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlBoolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x000442F8 File Offset: 0x000424F8
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 915433, RefRangeEnd = 915467, XrefRangeStart = 915430, XrefRangeEnd = 915433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator true(SqlBoolean x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlBoolean.NativeMethodInfoPtr_op_True_Public_Static_Boolean_SqlBoolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x00044338 File Offset: 0x00042538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915467, XrefRangeEnd = 915471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean operator &(SqlBoolean x, SqlBoolean y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlBoolean.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_SqlBoolean_SqlBoolean_SqlBoolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x00044384 File Offset: 0x00042584
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 915475, RefRangeEnd = 915483, XrefRangeStart = 915471, XrefRangeEnd = 915475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean operator |(SqlBoolean x, SqlBoolean y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlBoolean.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_SqlBoolean_SqlBoolean_SqlBoolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000DA4 RID: 3492 RVA: 0x000443D0 File Offset: 0x000425D0
		public unsafe byte ByteValue
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 915486, RefRangeEnd = 915490, XrefRangeStart = 915483, XrefRangeEnd = 915486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlBoolean.NativeMethodInfoPtr_get_ByteValue_Public_get_Byte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x00044400 File Offset: 0x00042600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915490, XrefRangeEnd = 915497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlBoolean.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x0004442C File Offset: 0x0004262C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915497, XrefRangeEnd = 915503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean operator ==(SqlBoolean x, SqlBoolean y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlBoolean.NativeMethodInfoPtr_op_Equality_Public_Static_SqlBoolean_SqlBoolean_SqlBoolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x00044478 File Offset: 0x00042678
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 915511, RefRangeEnd = 915512, XrefRangeStart = 915503, XrefRangeEnd = 915511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean And(SqlBoolean x, SqlBoolean y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlBoolean.NativeMethodInfoPtr_And_Public_Static_SqlBoolean_SqlBoolean_SqlBoolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x000444C4 File Offset: 0x000426C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 915520, RefRangeEnd = 915521, XrefRangeStart = 915512, XrefRangeEnd = 915520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean Or(SqlBoolean x, SqlBoolean y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlBoolean.NativeMethodInfoPtr_Or_Public_Static_SqlBoolean_SqlBoolean_SqlBoolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x00044510 File Offset: 0x00042710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915521, XrefRangeEnd = 915539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlBoolean.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x00044554 File Offset: 0x00042754
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 915552, RefRangeEnd = 915556, XrefRangeStart = 915539, XrefRangeEnd = 915552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(SqlBoolean value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlBoolean.NativeMethodInfoPtr_CompareTo_Public_Int32_SqlBoolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x00044594 File Offset: 0x00042794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915556, XrefRangeEnd = 915571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlBoolean.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x000445D8 File Offset: 0x000427D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915571, XrefRangeEnd = 915576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlBoolean.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x00044608 File Offset: 0x00042808
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchema System_Xml_Serialization_IXmlSerializable_GetSchema()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlBoolean.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x0004463C File Offset: 0x0004283C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915576, XrefRangeEnd = 915584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Xml_Serialization_IXmlSerializable_ReadXml(XmlReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlBoolean.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x00044674 File Offset: 0x00042874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915584, XrefRangeEnd = 915599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Xml_Serialization_IXmlSerializable_WriteXml(XmlWriter writer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlBoolean.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x000446AC File Offset: 0x000428AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915599, XrefRangeEnd = 915607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaSet);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlBoolean.NativeMethodInfoPtr_GetXsdType_Public_Static_XmlQualifiedName_XmlSchemaSet_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x00006458 File Offset: 0x00004658
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SqlBoolean>.NativeClassPtr, ref this));
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000DB2 RID: 3506 RVA: 0x000446F0 File Offset: 0x000428F0
		// (set) Token: 0x06000DB3 RID: 3507 RVA: 0x0000646A File Offset: 0x0000466A
		public unsafe static SqlBoolean True
		{
			get
			{
				SqlBoolean sqlBoolean;
				IL2CPP.il2cpp_field_static_get_value(SqlBoolean.NativeFieldInfoPtr_True, (void*)(&sqlBoolean));
				return sqlBoolean;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlBoolean.NativeFieldInfoPtr_True, (void*)(&value));
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000DB4 RID: 3508 RVA: 0x0004470C File Offset: 0x0004290C
		// (set) Token: 0x06000DB5 RID: 3509 RVA: 0x00006478 File Offset: 0x00004678
		public unsafe static SqlBoolean False
		{
			get
			{
				SqlBoolean sqlBoolean;
				IL2CPP.il2cpp_field_static_get_value(SqlBoolean.NativeFieldInfoPtr_False, (void*)(&sqlBoolean));
				return sqlBoolean;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlBoolean.NativeFieldInfoPtr_False, (void*)(&value));
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000DB6 RID: 3510 RVA: 0x00044728 File Offset: 0x00042928
		// (set) Token: 0x06000DB7 RID: 3511 RVA: 0x00006486 File Offset: 0x00004686
		public unsafe static SqlBoolean Null
		{
			get
			{
				SqlBoolean sqlBoolean;
				IL2CPP.il2cpp_field_static_get_value(SqlBoolean.NativeFieldInfoPtr_Null, (void*)(&sqlBoolean));
				return sqlBoolean;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlBoolean.NativeFieldInfoPtr_Null, (void*)(&value));
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000DB8 RID: 3512 RVA: 0x00044744 File Offset: 0x00042944
		// (set) Token: 0x06000DB9 RID: 3513 RVA: 0x00006494 File Offset: 0x00004694
		public unsafe static SqlBoolean Zero
		{
			get
			{
				SqlBoolean sqlBoolean;
				IL2CPP.il2cpp_field_static_get_value(SqlBoolean.NativeFieldInfoPtr_Zero, (void*)(&sqlBoolean));
				return sqlBoolean;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlBoolean.NativeFieldInfoPtr_Zero, (void*)(&value));
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000DBA RID: 3514 RVA: 0x00044760 File Offset: 0x00042960
		// (set) Token: 0x06000DBB RID: 3515 RVA: 0x000064A2 File Offset: 0x000046A2
		public unsafe static SqlBoolean One
		{
			get
			{
				SqlBoolean sqlBoolean;
				IL2CPP.il2cpp_field_static_get_value(SqlBoolean.NativeFieldInfoPtr_One, (void*)(&sqlBoolean));
				return sqlBoolean;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlBoolean.NativeFieldInfoPtr_One, (void*)(&value));
			}
		}

		// Token: 0x04000B40 RID: 2880
		private static readonly IntPtr NativeFieldInfoPtr_m_value;

		// Token: 0x04000B41 RID: 2881
		private static readonly IntPtr NativeFieldInfoPtr_True;

		// Token: 0x04000B42 RID: 2882
		private static readonly IntPtr NativeFieldInfoPtr_False;

		// Token: 0x04000B43 RID: 2883
		private static readonly IntPtr NativeFieldInfoPtr_Null;

		// Token: 0x04000B44 RID: 2884
		private static readonly IntPtr NativeFieldInfoPtr_Zero;

		// Token: 0x04000B45 RID: 2885
		private static readonly IntPtr NativeFieldInfoPtr_One;

		// Token: 0x04000B46 RID: 2886
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04000B47 RID: 2887
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000B48 RID: 2888
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_Boolean_0;

		// Token: 0x04000B49 RID: 2889
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNull_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000B4A RID: 2890
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Boolean_0;

		// Token: 0x04000B4B RID: 2891
		private static readonly IntPtr NativeMethodInfoPtr_get_IsTrue_Public_get_Boolean_0;

		// Token: 0x04000B4C RID: 2892
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFalse_Public_get_Boolean_0;

		// Token: 0x04000B4D RID: 2893
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SqlBoolean_Boolean_0;

		// Token: 0x04000B4E RID: 2894
		private static readonly IntPtr NativeMethodInfoPtr_op_True_Public_Static_Boolean_SqlBoolean_0;

		// Token: 0x04000B4F RID: 2895
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_SqlBoolean_SqlBoolean_SqlBoolean_0;

		// Token: 0x04000B50 RID: 2896
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_SqlBoolean_SqlBoolean_SqlBoolean_0;

		// Token: 0x04000B51 RID: 2897
		private static readonly IntPtr NativeMethodInfoPtr_get_ByteValue_Public_get_Byte_0;

		// Token: 0x04000B52 RID: 2898
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000B53 RID: 2899
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_SqlBoolean_SqlBoolean_SqlBoolean_0;

		// Token: 0x04000B54 RID: 2900
		private static readonly IntPtr NativeMethodInfoPtr_And_Public_Static_SqlBoolean_SqlBoolean_SqlBoolean_0;

		// Token: 0x04000B55 RID: 2901
		private static readonly IntPtr NativeMethodInfoPtr_Or_Public_Static_SqlBoolean_SqlBoolean_SqlBoolean_0;

		// Token: 0x04000B56 RID: 2902
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000B57 RID: 2903
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Int32_SqlBoolean_0;

		// Token: 0x04000B58 RID: 2904
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000B59 RID: 2905
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000B5A RID: 2906
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0;

		// Token: 0x04000B5B RID: 2907
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0;

		// Token: 0x04000B5C RID: 2908
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0;

		// Token: 0x04000B5D RID: 2909
		private static readonly IntPtr NativeMethodInfoPtr_GetXsdType_Public_Static_XmlQualifiedName_XmlSchemaSet_0;

		// Token: 0x04000B5E RID: 2910
		[FieldOffset(0)]
		public byte m_value;
	}
}
