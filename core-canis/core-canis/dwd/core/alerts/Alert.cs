using System;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.alerts
{
	// Token: 0x0200021A RID: 538
	public class Alert : Object
	{
		// Token: 0x06001D6A RID: 7530 RVA: 0x00088134 File Offset: 0x00086334
		// Note: this type is marked as 'beforefieldinit'.
		static Alert()
		{
			Il2CppClassPointerStore<Alert>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.alerts", "Alert");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Alert>.NativeClassPtr);
			Alert.NativeFieldInfoPtr_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Alert>.NativeClassPtr, "Message");
			Alert.NativeFieldInfoPtr_Confirm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Alert>.NativeClassPtr, "Confirm");
			Alert.NativeMethodInfoPtr__ctor_Protected_Void_LocalizedString_LocalizedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Alert>.NativeClassPtr, 100668037);
		}

		// Token: 0x06001D6B RID: 7531 RVA: 0x000881A0 File Offset: 0x000863A0
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Alert(LocalizedString message, LocalizedString confirm)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Alert>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(confirm);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Alert.NativeMethodInfoPtr__ctor_Protected_Void_LocalizedString_LocalizedString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D6C RID: 7532 RVA: 0x0000C885 File Offset: 0x0000AA85
		public Alert(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x06001D6D RID: 7533 RVA: 0x00088200 File Offset: 0x00086400
		// (set) Token: 0x06001D6E RID: 7534 RVA: 0x0000C88E File Offset: 0x0000AA8E
		public unsafe LocalizedString Message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alert.NativeFieldInfoPtr_Message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alert.NativeFieldInfoPtr_Message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x06001D6F RID: 7535 RVA: 0x00088230 File Offset: 0x00086430
		// (set) Token: 0x06001D70 RID: 7536 RVA: 0x0000C8AD File Offset: 0x0000AAAD
		public unsafe LocalizedString Confirm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alert.NativeFieldInfoPtr_Confirm);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alert.NativeFieldInfoPtr_Confirm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001498 RID: 5272
		private static readonly IntPtr NativeFieldInfoPtr_Message;

		// Token: 0x04001499 RID: 5273
		private static readonly IntPtr NativeFieldInfoPtr_Confirm;

		// Token: 0x0400149A RID: 5274
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_LocalizedString_LocalizedString_0;
	}
}
