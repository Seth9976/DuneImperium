using System;
using Canis.json.events;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.networking
{
	// Token: 0x02000060 RID: 96
	public class LeaveQueueForAsyncMatch : NetworkMessageEvent
	{
		// Token: 0x060003C0 RID: 960 RVA: 0x00024CCC File Offset: 0x00022ECC
		// Note: this type is marked as 'beforefieldinit'.
		static LeaveQueueForAsyncMatch()
		{
			Il2CppClassPointerStore<LeaveQueueForAsyncMatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.networking", "LeaveQueueForAsyncMatch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaveQueueForAsyncMatch>.NativeClassPtr);
			LeaveQueueForAsyncMatch.NativeFieldInfoPtr_eventID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaveQueueForAsyncMatch>.NativeClassPtr, "eventID");
			LeaveQueueForAsyncMatch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaveQueueForAsyncMatch>.NativeClassPtr, 100663917);
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00024D24 File Offset: 0x00022F24
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LeaveQueueForAsyncMatch()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaveQueueForAsyncMatch>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaveQueueForAsyncMatch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00003A4E File Offset: 0x00001C4E
		public LeaveQueueForAsyncMatch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x00024D60 File Offset: 0x00022F60
		// (set) Token: 0x060003C4 RID: 964 RVA: 0x00003A57 File Offset: 0x00001C57
		public unsafe EventID eventID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaveQueueForAsyncMatch.NativeFieldInfoPtr_eventID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaveQueueForAsyncMatch.NativeFieldInfoPtr_eventID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000241 RID: 577
		private static readonly IntPtr NativeFieldInfoPtr_eventID;

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
