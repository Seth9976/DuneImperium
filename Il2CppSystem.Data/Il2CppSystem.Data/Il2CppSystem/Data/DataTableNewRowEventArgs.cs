using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Data
{
	// Token: 0x02000042 RID: 66
	public sealed class DataTableNewRowEventArgs : EventArgs
	{
		// Token: 0x06000736 RID: 1846 RVA: 0x00028238 File Offset: 0x00026438
		// Note: this type is marked as 'beforefieldinit'.
		static DataTableNewRowEventArgs()
		{
			Il2CppClassPointerStore<DataTableNewRowEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "DataTableNewRowEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataTableNewRowEventArgs>.NativeClassPtr);
			DataTableNewRowEventArgs.NativeFieldInfoPtr__Row_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTableNewRowEventArgs>.NativeClassPtr, "<Row>k__BackingField");
			DataTableNewRowEventArgs.NativeMethodInfoPtr__ctor_Public_Void_DataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTableNewRowEventArgs>.NativeClassPtr, 100664519);
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00028290 File Offset: 0x00026490
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 901872, RefRangeEnd = 901874, XrefRangeStart = 901867, XrefRangeEnd = 901872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataTableNewRowEventArgs(DataRow dataRow)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataTableNewRowEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataRow);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTableNewRowEventArgs.NativeMethodInfoPtr__ctor_Public_Void_DataRow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x0000419E File Offset: 0x0000239E
		public DataTableNewRowEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000739 RID: 1849 RVA: 0x000282DC File Offset: 0x000264DC
		// (set) Token: 0x0600073A RID: 1850 RVA: 0x000041A7 File Offset: 0x000023A7
		public unsafe DataRow _Row_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTableNewRowEventArgs.NativeFieldInfoPtr__Row_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataRow>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTableNewRowEventArgs.NativeFieldInfoPtr__Row_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005F8 RID: 1528
		private static readonly IntPtr NativeFieldInfoPtr__Row_k__BackingField;

		// Token: 0x040005F9 RID: 1529
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataRow_0;
	}
}
