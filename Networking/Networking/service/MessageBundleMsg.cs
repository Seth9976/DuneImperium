using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Networking.service
{
	// Token: 0x02000058 RID: 88
	public class MessageBundleMsg : NetworkMessageEvent
	{
		// Token: 0x060002D8 RID: 728 RVA: 0x0000D1A8 File Offset: 0x0000B3A8
		// Note: this type is marked as 'beforefieldinit'.
		static MessageBundleMsg()
		{
			Il2CppClassPointerStore<MessageBundleMsg>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.service", "MessageBundleMsg");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageBundleMsg>.NativeClassPtr);
			MessageBundleMsg.NativeFieldInfoPtr_MessageList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBundleMsg>.NativeClassPtr, "MessageList");
			MessageBundleMsg.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBundleMsg>.NativeClassPtr, 100663439);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0000D200 File Offset: 0x0000B400
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageBundleMsg()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageBundleMsg>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageBundleMsg.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00003DCB File Offset: 0x00001FCB
		public MessageBundleMsg(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060002DB RID: 731 RVA: 0x0000D23C File Offset: 0x0000B43C
		// (set) Token: 0x060002DC RID: 732 RVA: 0x00003DD4 File Offset: 0x00001FD4
		public unsafe List<DWDEvent> MessageList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBundleMsg.NativeFieldInfoPtr_MessageList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DWDEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBundleMsg.NativeFieldInfoPtr_MessageList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeFieldInfoPtr_MessageList;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
