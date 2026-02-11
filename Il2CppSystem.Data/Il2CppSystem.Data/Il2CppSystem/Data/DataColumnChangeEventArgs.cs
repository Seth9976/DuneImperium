using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Data
{
	// Token: 0x02000029 RID: 41
	public class DataColumnChangeEventArgs : EventArgs
	{
		// Token: 0x0600051E RID: 1310 RVA: 0x0001F5C8 File Offset: 0x0001D7C8
		// Note: this type is marked as 'beforefieldinit'.
		static DataColumnChangeEventArgs()
		{
			Il2CppClassPointerStore<DataColumnChangeEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "DataColumnChangeEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataColumnChangeEventArgs>.NativeClassPtr);
			DataColumnChangeEventArgs.NativeFieldInfoPtr__column = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumnChangeEventArgs>.NativeClassPtr, "_column");
			DataColumnChangeEventArgs.NativeFieldInfoPtr__Row_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumnChangeEventArgs>.NativeClassPtr, "<Row>k__BackingField");
			DataColumnChangeEventArgs.NativeFieldInfoPtr__ProposedValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumnChangeEventArgs>.NativeClassPtr, "<ProposedValue>k__BackingField");
			DataColumnChangeEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_DataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnChangeEventArgs>.NativeClassPtr, 100664182);
			DataColumnChangeEventArgs.NativeMethodInfoPtr__ctor_Public_Void_DataRow_DataColumn_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnChangeEventArgs>.NativeClassPtr, 100664183);
			DataColumnChangeEventArgs.NativeMethodInfoPtr_get_ProposedValue_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnChangeEventArgs>.NativeClassPtr, 100664184);
			DataColumnChangeEventArgs.NativeMethodInfoPtr_set_ProposedValue_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnChangeEventArgs>.NativeClassPtr, 100664185);
			DataColumnChangeEventArgs.NativeMethodInfoPtr_InitializeColumnChangeEvent_Internal_Void_DataColumn_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnChangeEventArgs>.NativeClassPtr, 100664186);
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x0001F698 File Offset: 0x0001D898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898587, XrefRangeEnd = 898592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataColumnChangeEventArgs(DataRow row)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataColumnChangeEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnChangeEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_DataRow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x0001F6E4 File Offset: 0x0001D8E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898592, XrefRangeEnd = 898599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataColumnChangeEventArgs(DataRow row, DataColumn column, Object value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataColumnChangeEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(column);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnChangeEventArgs.NativeMethodInfoPtr__ctor_Public_Void_DataRow_DataColumn_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000521 RID: 1313 RVA: 0x0001F754 File Offset: 0x0001D954
		// (set) Token: 0x06000522 RID: 1314 RVA: 0x0001F794 File Offset: 0x0001D994
		public unsafe Object ProposedValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnChangeEventArgs.NativeMethodInfoPtr_get_ProposedValue_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnChangeEventArgs.NativeMethodInfoPtr_set_ProposedValue_Public_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x0001F7D8 File Offset: 0x0001D9D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898599, XrefRangeEnd = 898601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeColumnChangeEvent(DataColumn column, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnChangeEventArgs.NativeMethodInfoPtr_InitializeColumnChangeEvent_Internal_Void_DataColumn_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x0000369D File Offset: 0x0000189D
		public DataColumnChangeEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x0001F82C File Offset: 0x0001DA2C
		// (set) Token: 0x06000526 RID: 1318 RVA: 0x000036A6 File Offset: 0x000018A6
		public unsafe DataColumn _column
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumnChangeEventArgs.NativeFieldInfoPtr__column);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataColumn>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumnChangeEventArgs.NativeFieldInfoPtr__column), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x0001F85C File Offset: 0x0001DA5C
		// (set) Token: 0x06000528 RID: 1320 RVA: 0x000036C5 File Offset: 0x000018C5
		public unsafe DataRow _Row_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumnChangeEventArgs.NativeFieldInfoPtr__Row_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataRow>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumnChangeEventArgs.NativeFieldInfoPtr__Row_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x0001F88C File Offset: 0x0001DA8C
		// (set) Token: 0x0600052A RID: 1322 RVA: 0x000036E4 File Offset: 0x000018E4
		public unsafe Object _ProposedValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumnChangeEventArgs.NativeFieldInfoPtr__ProposedValue_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumnChangeEventArgs.NativeFieldInfoPtr__ProposedValue_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000450 RID: 1104
		private static readonly IntPtr NativeFieldInfoPtr__column;

		// Token: 0x04000451 RID: 1105
		private static readonly IntPtr NativeFieldInfoPtr__Row_k__BackingField;

		// Token: 0x04000452 RID: 1106
		private static readonly IntPtr NativeFieldInfoPtr__ProposedValue_k__BackingField;

		// Token: 0x04000453 RID: 1107
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DataRow_0;

		// Token: 0x04000454 RID: 1108
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataRow_DataColumn_Object_0;

		// Token: 0x04000455 RID: 1109
		private static readonly IntPtr NativeMethodInfoPtr_get_ProposedValue_Public_get_Object_0;

		// Token: 0x04000456 RID: 1110
		private static readonly IntPtr NativeMethodInfoPtr_set_ProposedValue_Public_set_Void_Object_0;

		// Token: 0x04000457 RID: 1111
		private static readonly IntPtr NativeMethodInfoPtr_InitializeColumnChangeEvent_Internal_Void_DataColumn_Object_0;
	}
}
