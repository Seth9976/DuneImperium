using System;
using Canis.json.events;
using dwd.core.platform.authentication;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace boardgames.notifications.socket
{
	// Token: 0x02000114 RID: 276
	public class NotificationsConnect : NetworkMessageEvent
	{
		// Token: 0x06000E6D RID: 3693 RVA: 0x0003CC94 File Offset: 0x0003AE94
		// Note: this type is marked as 'beforefieldinit'.
		static NotificationsConnect()
		{
			Il2CppClassPointerStore<NotificationsConnect>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.notifications.socket", "NotificationsConnect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotificationsConnect>.NativeClassPtr);
			NotificationsConnect.NativeFieldInfoPtr_Token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsConnect>.NativeClassPtr, "Token");
			NotificationsConnect.NativeFieldInfoPtr_Metadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsConnect>.NativeClassPtr, "Metadata");
			NotificationsConnect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsConnect>.NativeClassPtr, 100665351);
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x0003CD00 File Offset: 0x0003AF00
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NotificationsConnect()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotificationsConnect>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsConnect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x00008C0A File Offset: 0x00006E0A
		public NotificationsConnect(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000E70 RID: 3696 RVA: 0x0003CD3C File Offset: 0x0003AF3C
		// (set) Token: 0x06000E71 RID: 3697 RVA: 0x00008C13 File Offset: 0x00006E13
		public unsafe PlatformToken Token
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsConnect.NativeFieldInfoPtr_Token);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformToken>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsConnect.NativeFieldInfoPtr_Token), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000E72 RID: 3698 RVA: 0x0003CD6C File Offset: 0x0003AF6C
		// (set) Token: 0x06000E73 RID: 3699 RVA: 0x00008C32 File Offset: 0x00006E32
		public unsafe Dictionary<string, string> Metadata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsConnect.NativeFieldInfoPtr_Metadata);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsConnect.NativeFieldInfoPtr_Metadata), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008B7 RID: 2231
		private static readonly IntPtr NativeFieldInfoPtr_Token;

		// Token: 0x040008B8 RID: 2232
		private static readonly IntPtr NativeFieldInfoPtr_Metadata;

		// Token: 0x040008B9 RID: 2233
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
