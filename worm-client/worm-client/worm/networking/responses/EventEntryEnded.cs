using System;
using Canis.json.events;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.networking.responses
{
	// Token: 0x02000070 RID: 112
	public class EventEntryEnded : NetworkMessageEvent
	{
		// Token: 0x06000460 RID: 1120 RVA: 0x000263E8 File Offset: 0x000245E8
		// Note: this type is marked as 'beforefieldinit'.
		static EventEntryEnded()
		{
			Il2CppClassPointerStore<EventEntryEnded>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.networking.responses", "EventEntryEnded");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventEntryEnded>.NativeClassPtr);
			EventEntryEnded.NativeFieldInfoPtr_eventID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventEntryEnded>.NativeClassPtr, "eventID");
			EventEntryEnded.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventEntryEnded>.NativeClassPtr, "entry");
			EventEntryEnded.NativeFieldInfoPtr_accountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventEntryEnded>.NativeClassPtr, "accountID");
			EventEntryEnded.NativeFieldInfoPtr_reason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventEntryEnded>.NativeClassPtr, "reason");
			EventEntryEnded.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventEntryEnded>.NativeClassPtr, 100663947);
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x0002647C File Offset: 0x0002467C
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventEntryEnded()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventEntryEnded>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventEntryEnded.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x0000424B File Offset: 0x0000244B
		public EventEntryEnded(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x000264B8 File Offset: 0x000246B8
		// (set) Token: 0x06000464 RID: 1124 RVA: 0x00004254 File Offset: 0x00002454
		public unsafe string eventID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntryEnded.NativeFieldInfoPtr_eventID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntryEnded.NativeFieldInfoPtr_eventID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x000264E0 File Offset: 0x000246E0
		// (set) Token: 0x06000466 RID: 1126 RVA: 0x00004273 File Offset: 0x00002473
		public unsafe EventEntry entry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntryEnded.NativeFieldInfoPtr_entry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntryEnded.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x00026510 File Offset: 0x00024710
		// (set) Token: 0x06000468 RID: 1128 RVA: 0x00004292 File Offset: 0x00002492
		public unsafe AccountID accountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntryEnded.NativeFieldInfoPtr_accountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntryEnded.NativeFieldInfoPtr_accountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x00026540 File Offset: 0x00024740
		// (set) Token: 0x0600046A RID: 1130 RVA: 0x000042B1 File Offset: 0x000024B1
		public unsafe string reason
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntryEnded.NativeFieldInfoPtr_reason);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntryEnded.NativeFieldInfoPtr_reason), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400028C RID: 652
		private static readonly IntPtr NativeFieldInfoPtr_eventID;

		// Token: 0x0400028D RID: 653
		private static readonly IntPtr NativeFieldInfoPtr_entry;

		// Token: 0x0400028E RID: 654
		private static readonly IntPtr NativeFieldInfoPtr_accountID;

		// Token: 0x0400028F RID: 655
		private static readonly IntPtr NativeFieldInfoPtr_reason;

		// Token: 0x04000290 RID: 656
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
