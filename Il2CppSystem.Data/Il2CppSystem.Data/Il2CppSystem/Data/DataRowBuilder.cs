using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Data
{
	// Token: 0x02000033 RID: 51
	public sealed class DataRowBuilder : Object
	{
		// Token: 0x06000698 RID: 1688 RVA: 0x00025BD4 File Offset: 0x00023DD4
		// Note: this type is marked as 'beforefieldinit'.
		static DataRowBuilder()
		{
			Il2CppClassPointerStore<DataRowBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "DataRowBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataRowBuilder>.NativeClassPtr);
			DataRowBuilder.NativeFieldInfoPtr__table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRowBuilder>.NativeClassPtr, "_table");
			DataRowBuilder.NativeFieldInfoPtr__record = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRowBuilder>.NativeClassPtr, "_record");
			DataRowBuilder.NativeMethodInfoPtr__ctor_Internal_Void_DataTable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowBuilder>.NativeClassPtr, 100664432);
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00025C40 File Offset: 0x00023E40
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 412652, RefRangeEnd = 412658, XrefRangeStart = 412652, XrefRangeEnd = 412658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataRowBuilder(DataTable table, int record)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataRowBuilder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref record;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowBuilder.NativeMethodInfoPtr__ctor_Internal_Void_DataTable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00003E45 File Offset: 0x00002045
		public DataRowBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x0600069B RID: 1691 RVA: 0x00025C9C File Offset: 0x00023E9C
		// (set) Token: 0x0600069C RID: 1692 RVA: 0x00003E4E File Offset: 0x0000204E
		public unsafe DataTable _table
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRowBuilder.NativeFieldInfoPtr__table);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRowBuilder.NativeFieldInfoPtr__table), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600069D RID: 1693 RVA: 0x00025CCC File Offset: 0x00023ECC
		// (set) Token: 0x0600069E RID: 1694 RVA: 0x00003E6D File Offset: 0x0000206D
		public unsafe int _record
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRowBuilder.NativeFieldInfoPtr__record);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRowBuilder.NativeFieldInfoPtr__record)) = value;
			}
		}

		// Token: 0x04000574 RID: 1396
		private static readonly IntPtr NativeFieldInfoPtr__table;

		// Token: 0x04000575 RID: 1397
		private static readonly IntPtr NativeFieldInfoPtr__record;

		// Token: 0x04000576 RID: 1398
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DataTable_Int32_0;
	}
}
