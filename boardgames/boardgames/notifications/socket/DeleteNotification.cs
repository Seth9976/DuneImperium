using System;
using Canis.json.events;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.notifications.socket
{
	// Token: 0x02000112 RID: 274
	public class DeleteNotification : NetworkMessageEvent
	{
		// Token: 0x06000E65 RID: 3685 RVA: 0x0003CB94 File Offset: 0x0003AD94
		// Note: this type is marked as 'beforefieldinit'.
		static DeleteNotification()
		{
			Il2CppClassPointerStore<DeleteNotification>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.notifications.socket", "DeleteNotification");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeleteNotification>.NativeClassPtr);
			DeleteNotification.NativeFieldInfoPtr_NoteID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteNotification>.NativeClassPtr, "NoteID");
			DeleteNotification.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteNotification>.NativeClassPtr, 100665349);
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x0003CBEC File Offset: 0x0003ADEC
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeleteNotification()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeleteNotification>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteNotification.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x00008BA0 File Offset: 0x00006DA0
		public DeleteNotification(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000E68 RID: 3688 RVA: 0x0003CC28 File Offset: 0x0003AE28
		// (set) Token: 0x06000E69 RID: 3689 RVA: 0x00008BA9 File Offset: 0x00006DA9
		public unsafe NotificationID NoteID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteNotification.NativeFieldInfoPtr_NoteID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NotificationID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteNotification.NativeFieldInfoPtr_NoteID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008B4 RID: 2228
		private static readonly IntPtr NativeFieldInfoPtr_NoteID;

		// Token: 0x040008B5 RID: 2229
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
