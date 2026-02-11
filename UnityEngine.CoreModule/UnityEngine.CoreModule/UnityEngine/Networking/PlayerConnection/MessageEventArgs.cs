using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Networking.PlayerConnection
{
	// Token: 0x020001D7 RID: 471
	[Serializable]
	public class MessageEventArgs : Object
	{
		// Token: 0x0600213E RID: 8510 RVA: 0x000927F0 File Offset: 0x000909F0
		// Note: this type is marked as 'beforefieldinit'.
		static MessageEventArgs()
		{
			Il2CppClassPointerStore<MessageEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Networking.PlayerConnection", "MessageEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageEventArgs>.NativeClassPtr);
			MessageEventArgs.NativeFieldInfoPtr_playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageEventArgs>.NativeClassPtr, "playerId");
			MessageEventArgs.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageEventArgs>.NativeClassPtr, "data");
			MessageEventArgs.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageEventArgs>.NativeClassPtr, 100667775);
		}

		// Token: 0x0600213F RID: 8511 RVA: 0x0009285C File Offset: 0x00090A5C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageEventArgs()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageEventArgs.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002140 RID: 8512 RVA: 0x0000CB7E File Offset: 0x0000AD7E
		public MessageEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x06002141 RID: 8513 RVA: 0x00092898 File Offset: 0x00090A98
		// (set) Token: 0x06002142 RID: 8514 RVA: 0x0000CB87 File Offset: 0x0000AD87
		public unsafe int playerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageEventArgs.NativeFieldInfoPtr_playerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageEventArgs.NativeFieldInfoPtr_playerId)) = value;
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x06002143 RID: 8515 RVA: 0x000928C0 File Offset: 0x00090AC0
		// (set) Token: 0x06002144 RID: 8516 RVA: 0x0000CBA2 File Offset: 0x0000ADA2
		public unsafe Il2CppStructArray<byte> data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageEventArgs.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageEventArgs.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C58 RID: 7256
		private static readonly IntPtr NativeFieldInfoPtr_playerId;

		// Token: 0x04001C59 RID: 7257
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x04001C5A RID: 7258
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
