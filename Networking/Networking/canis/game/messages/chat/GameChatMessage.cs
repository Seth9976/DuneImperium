using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.game.messages.chat
{
	// Token: 0x02000015 RID: 21
	public class GameChatMessage : Object
	{
		// Token: 0x060000A9 RID: 169 RVA: 0x00007C30 File Offset: 0x00005E30
		// Note: this type is marked as 'beforefieldinit'.
		static GameChatMessage()
		{
			Il2CppClassPointerStore<GameChatMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.game.messages.chat", "GameChatMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameChatMessage>.NativeClassPtr);
			GameChatMessage.NativeFieldInfoPtr_Timestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameChatMessage>.NativeClassPtr, "Timestamp");
			GameChatMessage.NativeFieldInfoPtr_AccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameChatMessage>.NativeClassPtr, "AccountID");
			GameChatMessage.NativeFieldInfoPtr_ScreenName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameChatMessage>.NativeClassPtr, "ScreenName");
			GameChatMessage.NativeFieldInfoPtr_Metadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameChatMessage>.NativeClassPtr, "Metadata");
			GameChatMessage.NativeFieldInfoPtr_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameChatMessage>.NativeClassPtr, "Message");
			GameChatMessage.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameChatMessage>.NativeClassPtr, 100663331);
			GameChatMessage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameChatMessage>.NativeClassPtr, 100663332);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00007CEC File Offset: 0x00005EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193511, XrefRangeEnd = 1193521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameChatMessage.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00007D30 File Offset: 0x00005F30
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameChatMessage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameChatMessage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameChatMessage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002723 File Offset: 0x00000923
		public GameChatMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00007D6C File Offset: 0x00005F6C
		// (set) Token: 0x060000AE RID: 174 RVA: 0x0000272C File Offset: 0x0000092C
		public unsafe long Timestamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameChatMessage.NativeFieldInfoPtr_Timestamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameChatMessage.NativeFieldInfoPtr_Timestamp)) = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00007D94 File Offset: 0x00005F94
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x00002747 File Offset: 0x00000947
		public unsafe AccountID AccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameChatMessage.NativeFieldInfoPtr_AccountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameChatMessage.NativeFieldInfoPtr_AccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00007DC4 File Offset: 0x00005FC4
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x00002766 File Offset: 0x00000966
		public unsafe string ScreenName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameChatMessage.NativeFieldInfoPtr_ScreenName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameChatMessage.NativeFieldInfoPtr_ScreenName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00007DEC File Offset: 0x00005FEC
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x00002785 File Offset: 0x00000985
		public unsafe Dictionary<string, string> Metadata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameChatMessage.NativeFieldInfoPtr_Metadata);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameChatMessage.NativeFieldInfoPtr_Metadata), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00007E1C File Offset: 0x0000601C
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x000027A4 File Offset: 0x000009A4
		public unsafe string Message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameChatMessage.NativeFieldInfoPtr_Message);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameChatMessage.NativeFieldInfoPtr_Message), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeFieldInfoPtr_Timestamp;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeFieldInfoPtr_AccountID;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeFieldInfoPtr_ScreenName;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeFieldInfoPtr_Metadata;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeFieldInfoPtr_Message;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
