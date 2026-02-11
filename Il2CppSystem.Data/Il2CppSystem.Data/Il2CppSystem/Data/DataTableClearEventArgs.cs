using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Data
{
	// Token: 0x0200003F RID: 63
	public sealed class DataTableClearEventArgs : EventArgs
	{
		// Token: 0x060006F9 RID: 1785 RVA: 0x00027220 File Offset: 0x00025420
		// Note: this type is marked as 'beforefieldinit'.
		static DataTableClearEventArgs()
		{
			Il2CppClassPointerStore<DataTableClearEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "DataTableClearEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataTableClearEventArgs>.NativeClassPtr);
			DataTableClearEventArgs.NativeFieldInfoPtr__Table_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTableClearEventArgs>.NativeClassPtr, "<Table>k__BackingField");
			DataTableClearEventArgs.NativeMethodInfoPtr__ctor_Public_Void_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTableClearEventArgs>.NativeClassPtr, 100664485);
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00027278 File Offset: 0x00025478
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 901389, RefRangeEnd = 901390, XrefRangeStart = 901384, XrefRangeEnd = 901389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataTableClearEventArgs(DataTable dataTable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataTableClearEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataTable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTableClearEventArgs.NativeMethodInfoPtr__ctor_Public_Void_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x0000405E File Offset: 0x0000225E
		public DataTableClearEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060006FC RID: 1788 RVA: 0x000272C4 File Offset: 0x000254C4
		// (set) Token: 0x060006FD RID: 1789 RVA: 0x00004067 File Offset: 0x00002267
		public unsafe DataTable _Table_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTableClearEventArgs.NativeFieldInfoPtr__Table_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTableClearEventArgs.NativeFieldInfoPtr__Table_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005CD RID: 1485
		private static readonly IntPtr NativeFieldInfoPtr__Table_k__BackingField;

		// Token: 0x040005CE RID: 1486
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataTable_0;
	}
}
