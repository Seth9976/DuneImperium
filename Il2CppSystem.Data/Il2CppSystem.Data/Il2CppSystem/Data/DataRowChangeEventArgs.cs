using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Data
{
	// Token: 0x02000035 RID: 53
	public class DataRowChangeEventArgs : EventArgs
	{
		// Token: 0x0600069F RID: 1695 RVA: 0x00025CF4 File Offset: 0x00023EF4
		// Note: this type is marked as 'beforefieldinit'.
		static DataRowChangeEventArgs()
		{
			Il2CppClassPointerStore<DataRowChangeEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "DataRowChangeEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataRowChangeEventArgs>.NativeClassPtr);
			DataRowChangeEventArgs.NativeFieldInfoPtr__Row_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRowChangeEventArgs>.NativeClassPtr, "<Row>k__BackingField");
			DataRowChangeEventArgs.NativeFieldInfoPtr__Action_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRowChangeEventArgs>.NativeClassPtr, "<Action>k__BackingField");
			DataRowChangeEventArgs.NativeMethodInfoPtr__ctor_Public_Void_DataRow_DataRowAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowChangeEventArgs>.NativeClassPtr, 100664433);
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x00025D60 File Offset: 0x00023F60
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 901164, RefRangeEnd = 901172, XrefRangeStart = 901159, XrefRangeEnd = 901164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataRowChangeEventArgs(DataRow row, DataRowAction action)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataRowChangeEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref action;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowChangeEventArgs.NativeMethodInfoPtr__ctor_Public_Void_DataRow_DataRowAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00003E88 File Offset: 0x00002088
		public DataRowChangeEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060006A2 RID: 1698 RVA: 0x00025DBC File Offset: 0x00023FBC
		// (set) Token: 0x060006A3 RID: 1699 RVA: 0x00003E91 File Offset: 0x00002091
		public unsafe DataRow _Row_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRowChangeEventArgs.NativeFieldInfoPtr__Row_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataRow>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRowChangeEventArgs.NativeFieldInfoPtr__Row_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060006A4 RID: 1700 RVA: 0x00025DEC File Offset: 0x00023FEC
		// (set) Token: 0x060006A5 RID: 1701 RVA: 0x00003EB0 File Offset: 0x000020B0
		public unsafe DataRowAction _Action_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRowChangeEventArgs.NativeFieldInfoPtr__Action_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRowChangeEventArgs.NativeFieldInfoPtr__Action_k__BackingField)) = value;
			}
		}

		// Token: 0x04000580 RID: 1408
		private static readonly IntPtr NativeFieldInfoPtr__Row_k__BackingField;

		// Token: 0x04000581 RID: 1409
		private static readonly IntPtr NativeFieldInfoPtr__Action_k__BackingField;

		// Token: 0x04000582 RID: 1410
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataRow_DataRowAction_0;
	}
}
