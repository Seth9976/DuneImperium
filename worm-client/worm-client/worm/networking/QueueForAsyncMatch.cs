using System;
using Canis.json.events;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.networking
{
	// Token: 0x02000062 RID: 98
	public class QueueForAsyncMatch : NetworkMessageEvent
	{
		// Token: 0x060003C8 RID: 968 RVA: 0x00024DCC File Offset: 0x00022FCC
		// Note: this type is marked as 'beforefieldinit'.
		static QueueForAsyncMatch()
		{
			Il2CppClassPointerStore<QueueForAsyncMatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.networking", "QueueForAsyncMatch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueueForAsyncMatch>.NativeClassPtr);
			QueueForAsyncMatch.NativeFieldInfoPtr_eventID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueueForAsyncMatch>.NativeClassPtr, "eventID");
			QueueForAsyncMatch.NativeFieldInfoPtr_entryID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueueForAsyncMatch>.NativeClassPtr, "entryID");
			QueueForAsyncMatch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueueForAsyncMatch>.NativeClassPtr, 100663919);
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00024E38 File Offset: 0x00023038
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QueueForAsyncMatch()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QueueForAsyncMatch>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QueueForAsyncMatch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00003AB8 File Offset: 0x00001CB8
		public QueueForAsyncMatch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060003CB RID: 971 RVA: 0x00024E74 File Offset: 0x00023074
		// (set) Token: 0x060003CC RID: 972 RVA: 0x00003AC1 File Offset: 0x00001CC1
		public unsafe EventID eventID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueueForAsyncMatch.NativeFieldInfoPtr_eventID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueueForAsyncMatch.NativeFieldInfoPtr_eventID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060003CD RID: 973 RVA: 0x00024EA4 File Offset: 0x000230A4
		// (set) Token: 0x060003CE RID: 974 RVA: 0x00003AE0 File Offset: 0x00001CE0
		public unsafe EntryID entryID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueueForAsyncMatch.NativeFieldInfoPtr_entryID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntryID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueueForAsyncMatch.NativeFieldInfoPtr_entryID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeFieldInfoPtr_eventID;

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeFieldInfoPtr_entryID;

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
