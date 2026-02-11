using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Data
{
	// Token: 0x0200002D RID: 45
	public sealed class DataError : Object
	{
		// Token: 0x06000583 RID: 1411 RVA: 0x00020FDC File Offset: 0x0001F1DC
		// Note: this type is marked as 'beforefieldinit'.
		static DataError()
		{
			Il2CppClassPointerStore<DataError>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "DataError");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataError>.NativeClassPtr);
			DataError.NativeFieldInfoPtr__rowError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataError>.NativeClassPtr, "_rowError");
			DataError.NativeFieldInfoPtr__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataError>.NativeClassPtr, "_count");
			DataError.NativeFieldInfoPtr__errorList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataError>.NativeClassPtr, "_errorList");
			DataError.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataError>.NativeClassPtr, 100664240);
			DataError.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataError>.NativeClassPtr, 100664241);
			DataError.NativeMethodInfoPtr_get_Text_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataError>.NativeClassPtr, 100664242);
			DataError.NativeMethodInfoPtr_set_Text_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataError>.NativeClassPtr, 100664243);
			DataError.NativeMethodInfoPtr_get_HasErrors_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataError>.NativeClassPtr, 100664244);
			DataError.NativeMethodInfoPtr_SetColumnError_Internal_Void_DataColumn_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataError>.NativeClassPtr, 100664245);
			DataError.NativeMethodInfoPtr_GetColumnError_Internal_String_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataError>.NativeClassPtr, 100664246);
			DataError.NativeMethodInfoPtr_Clear_Internal_Void_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataError>.NativeClassPtr, 100664247);
			DataError.NativeMethodInfoPtr_Clear_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataError>.NativeClassPtr, 100664248);
			DataError.NativeMethodInfoPtr_GetColumnsInError_Internal_Il2CppReferenceArray_1_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataError>.NativeClassPtr, 100664249);
			DataError.NativeMethodInfoPtr_SetText_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataError>.NativeClassPtr, 100664250);
			DataError.NativeMethodInfoPtr_IndexOf_Internal_Int32_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataError>.NativeClassPtr, 100664251);
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00021138 File Offset: 0x0001F338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899184, XrefRangeEnd = 899188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataError()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataError>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataError.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00021174 File Offset: 0x0001F374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899188, XrefRangeEnd = 899195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataError(string rowError)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataError>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(rowError);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataError.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000586 RID: 1414 RVA: 0x000211C0 File Offset: 0x0001F3C0
		// (set) Token: 0x06000587 RID: 1415 RVA: 0x000211F8 File Offset: 0x0001F3F8
		public unsafe string Text
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataError.NativeMethodInfoPtr_get_Text_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899195, XrefRangeEnd = 899198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataError.NativeMethodInfoPtr_set_Text_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x0002123C File Offset: 0x0001F43C
		public unsafe bool HasErrors
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataError.NativeMethodInfoPtr_get_HasErrors_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x00021278 File Offset: 0x0001F478
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 899213, RefRangeEnd = 899214, XrefRangeStart = 899198, XrefRangeEnd = 899213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColumnError(DataColumn column, string error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(error);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataError.NativeMethodInfoPtr_SetColumnError_Internal_Void_DataColumn_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x000212CC File Offset: 0x0001F4CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899214, XrefRangeEnd = 899216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetColumnError(DataColumn column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataError.NativeMethodInfoPtr_GetColumnError_Internal_String_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x00021314 File Offset: 0x0001F514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899216, XrefRangeEnd = 899217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear(DataColumn column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataError.NativeMethodInfoPtr_Clear_Internal_Void_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00021358 File Offset: 0x0001F558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899217, XrefRangeEnd = 899222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataError.NativeMethodInfoPtr_Clear_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x0002138C File Offset: 0x0001F58C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899222, XrefRangeEnd = 899227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<DataColumn> GetColumnsInError()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataError.NativeMethodInfoPtr_GetColumnsInError_Internal_Il2CppReferenceArray_1_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataColumn>>(intPtr3) : null;
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x000213CC File Offset: 0x0001F5CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899227, XrefRangeEnd = 899230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(string errorText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(errorText);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataError.NativeMethodInfoPtr_SetText_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00021410 File Offset: 0x0001F610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899230, XrefRangeEnd = 899239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(DataColumn column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataError.NativeMethodInfoPtr_IndexOf_Internal_Int32_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x000038C8 File Offset: 0x00001AC8
		public DataError(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x00021460 File Offset: 0x0001F660
		// (set) Token: 0x06000592 RID: 1426 RVA: 0x000038D1 File Offset: 0x00001AD1
		public unsafe string _rowError
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataError.NativeFieldInfoPtr__rowError);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataError.NativeFieldInfoPtr__rowError), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x00021488 File Offset: 0x0001F688
		// (set) Token: 0x06000594 RID: 1428 RVA: 0x000038F0 File Offset: 0x00001AF0
		public unsafe int _count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataError.NativeFieldInfoPtr__count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataError.NativeFieldInfoPtr__count)) = value;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x000214B0 File Offset: 0x0001F6B0
		// (set) Token: 0x06000596 RID: 1430 RVA: 0x0000390B File Offset: 0x00001B0B
		public unsafe Il2CppReferenceArray<DataError.ColumnError> _errorList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataError.NativeFieldInfoPtr__errorList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataError.ColumnError>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataError.NativeFieldInfoPtr__errorList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400049A RID: 1178
		private static readonly IntPtr NativeFieldInfoPtr__rowError;

		// Token: 0x0400049B RID: 1179
		private static readonly IntPtr NativeFieldInfoPtr__count;

		// Token: 0x0400049C RID: 1180
		private static readonly IntPtr NativeFieldInfoPtr__errorList;

		// Token: 0x0400049D RID: 1181
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x0400049E RID: 1182
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

		// Token: 0x0400049F RID: 1183
		private static readonly IntPtr NativeMethodInfoPtr_get_Text_Internal_get_String_0;

		// Token: 0x040004A0 RID: 1184
		private static readonly IntPtr NativeMethodInfoPtr_set_Text_Internal_set_Void_String_0;

		// Token: 0x040004A1 RID: 1185
		private static readonly IntPtr NativeMethodInfoPtr_get_HasErrors_Internal_get_Boolean_0;

		// Token: 0x040004A2 RID: 1186
		private static readonly IntPtr NativeMethodInfoPtr_SetColumnError_Internal_Void_DataColumn_String_0;

		// Token: 0x040004A3 RID: 1187
		private static readonly IntPtr NativeMethodInfoPtr_GetColumnError_Internal_String_DataColumn_0;

		// Token: 0x040004A4 RID: 1188
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Void_DataColumn_0;

		// Token: 0x040004A5 RID: 1189
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Void_0;

		// Token: 0x040004A6 RID: 1190
		private static readonly IntPtr NativeMethodInfoPtr_GetColumnsInError_Internal_Il2CppReferenceArray_1_DataColumn_0;

		// Token: 0x040004A7 RID: 1191
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Private_Void_String_0;

		// Token: 0x040004A8 RID: 1192
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Internal_Int32_DataColumn_0;

		// Token: 0x020000DC RID: 220
		public sealed class ColumnError : ValueType
		{
			// Token: 0x0600146A RID: 5226 RVA: 0x00061BC4 File Offset: 0x0005FDC4
			// Note: this type is marked as 'beforefieldinit'.
			static ColumnError()
			{
				Il2CppClassPointerStore<DataError.ColumnError>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataError>.NativeClassPtr, "ColumnError");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataError.ColumnError>.NativeClassPtr);
				DataError.ColumnError.NativeFieldInfoPtr__column = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataError.ColumnError>.NativeClassPtr, "_column");
				DataError.ColumnError.NativeFieldInfoPtr__error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataError.ColumnError>.NativeClassPtr, "_error");
			}

			// Token: 0x0600146B RID: 5227 RVA: 0x00007ACE File Offset: 0x00005CCE
			public ColumnError(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600146C RID: 5228 RVA: 0x00007AD7 File Offset: 0x00005CD7
			public ColumnError()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataError.ColumnError>.NativeClassPtr))
			{
			}

			// Token: 0x1700049F RID: 1183
			// (get) Token: 0x0600146D RID: 5229 RVA: 0x00061C18 File Offset: 0x0005FE18
			// (set) Token: 0x0600146E RID: 5230 RVA: 0x00007AE9 File Offset: 0x00005CE9
			public unsafe DataColumn _column
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataError.ColumnError.NativeFieldInfoPtr__column);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataColumn>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataError.ColumnError.NativeFieldInfoPtr__column), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170004A0 RID: 1184
			// (get) Token: 0x0600146F RID: 5231 RVA: 0x00061C48 File Offset: 0x0005FE48
			// (set) Token: 0x06001470 RID: 5232 RVA: 0x00007B08 File Offset: 0x00005D08
			public unsafe string _error
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataError.ColumnError.NativeFieldInfoPtr__error);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataError.ColumnError.NativeFieldInfoPtr__error), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040010FC RID: 4348
			private static readonly IntPtr NativeFieldInfoPtr__column;

			// Token: 0x040010FD RID: 4349
			private static readonly IntPtr NativeFieldInfoPtr__error;
		}
	}
}
