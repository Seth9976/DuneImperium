using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000134 RID: 308
	public class ReaderWriterCount : Object
	{
		// Token: 0x06001225 RID: 4645 RVA: 0x0005E974 File Offset: 0x0005CB74
		// Note: this type is marked as 'beforefieldinit'.
		static ReaderWriterCount()
		{
			Il2CppClassPointerStore<ReaderWriterCount>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Threading", "ReaderWriterCount");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReaderWriterCount>.NativeClassPtr);
			ReaderWriterCount.NativeFieldInfoPtr_lockID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterCount>.NativeClassPtr, "lockID");
			ReaderWriterCount.NativeFieldInfoPtr_readercount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterCount>.NativeClassPtr, "readercount");
			ReaderWriterCount.NativeFieldInfoPtr_writercount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterCount>.NativeClassPtr, "writercount");
			ReaderWriterCount.NativeFieldInfoPtr_upgradecount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterCount>.NativeClassPtr, "upgradecount");
			ReaderWriterCount.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterCount>.NativeClassPtr, "next");
			ReaderWriterCount.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterCount>.NativeClassPtr, 100666730);
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x0005EA1C File Offset: 0x0005CC1C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReaderWriterCount()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReaderWriterCount>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterCount.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001227 RID: 4647 RVA: 0x000077F3 File Offset: 0x000059F3
		public ReaderWriterCount(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06001228 RID: 4648 RVA: 0x0005EA58 File Offset: 0x0005CC58
		// (set) Token: 0x06001229 RID: 4649 RVA: 0x000077FC File Offset: 0x000059FC
		public unsafe long lockID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterCount.NativeFieldInfoPtr_lockID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterCount.NativeFieldInfoPtr_lockID)) = value;
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x0600122A RID: 4650 RVA: 0x0005EA80 File Offset: 0x0005CC80
		// (set) Token: 0x0600122B RID: 4651 RVA: 0x00007817 File Offset: 0x00005A17
		public unsafe int readercount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterCount.NativeFieldInfoPtr_readercount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterCount.NativeFieldInfoPtr_readercount)) = value;
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x0600122C RID: 4652 RVA: 0x0005EAA8 File Offset: 0x0005CCA8
		// (set) Token: 0x0600122D RID: 4653 RVA: 0x00007832 File Offset: 0x00005A32
		public unsafe int writercount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterCount.NativeFieldInfoPtr_writercount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterCount.NativeFieldInfoPtr_writercount)) = value;
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x0600122E RID: 4654 RVA: 0x0005EAD0 File Offset: 0x0005CCD0
		// (set) Token: 0x0600122F RID: 4655 RVA: 0x0000784D File Offset: 0x00005A4D
		public unsafe int upgradecount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterCount.NativeFieldInfoPtr_upgradecount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterCount.NativeFieldInfoPtr_upgradecount)) = value;
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06001230 RID: 4656 RVA: 0x0005EAF8 File Offset: 0x0005CCF8
		// (set) Token: 0x06001231 RID: 4657 RVA: 0x00007868 File Offset: 0x00005A68
		public unsafe ReaderWriterCount next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterCount.NativeFieldInfoPtr_next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReaderWriterCount>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterCount.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D12 RID: 3346
		private static readonly IntPtr NativeFieldInfoPtr_lockID;

		// Token: 0x04000D13 RID: 3347
		private static readonly IntPtr NativeFieldInfoPtr_readercount;

		// Token: 0x04000D14 RID: 3348
		private static readonly IntPtr NativeFieldInfoPtr_writercount;

		// Token: 0x04000D15 RID: 3349
		private static readonly IntPtr NativeFieldInfoPtr_upgradecount;

		// Token: 0x04000D16 RID: 3350
		private static readonly IntPtr NativeFieldInfoPtr_next;

		// Token: 0x04000D17 RID: 3351
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
