using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace lotus
{
	// Token: 0x020000AD RID: 173
	public class ClientChatMessage : Object
	{
		// Token: 0x0600086B RID: 2155 RVA: 0x0002BBEC File Offset: 0x00029DEC
		// Note: this type is marked as 'beforefieldinit'.
		static ClientChatMessage()
		{
			Il2CppClassPointerStore<ClientChatMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus", "ClientChatMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientChatMessage>.NativeClassPtr);
			ClientChatMessage.NativeFieldInfoPtr_Timestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientChatMessage>.NativeClassPtr, "Timestamp");
			ClientChatMessage.NativeFieldInfoPtr_AccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientChatMessage>.NativeClassPtr, "AccountID");
			ClientChatMessage.NativeFieldInfoPtr_ScreenName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientChatMessage>.NativeClassPtr, "ScreenName");
			ClientChatMessage.NativeFieldInfoPtr_Metadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientChatMessage>.NativeClassPtr, "Metadata");
			ClientChatMessage.NativeFieldInfoPtr_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientChatMessage>.NativeClassPtr, "Message");
			ClientChatMessage.NativeFieldInfoPtr_Game = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientChatMessage>.NativeClassPtr, "Game");
			ClientChatMessage.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientChatMessage>.NativeClassPtr, 100664623);
			ClientChatMessage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientChatMessage>.NativeClassPtr, 100664624);
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x0002BCBC File Offset: 0x00029EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991595, XrefRangeEnd = 991616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClientChatMessage.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x0002BD00 File Offset: 0x00029F00
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClientChatMessage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientChatMessage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientChatMessage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00005CEC File Offset: 0x00003EEC
		public ClientChatMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x0600086F RID: 2159 RVA: 0x0002BD3C File Offset: 0x00029F3C
		// (set) Token: 0x06000870 RID: 2160 RVA: 0x00005CF5 File Offset: 0x00003EF5
		public unsafe long Timestamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientChatMessage.NativeFieldInfoPtr_Timestamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientChatMessage.NativeFieldInfoPtr_Timestamp)) = value;
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x0002BD64 File Offset: 0x00029F64
		// (set) Token: 0x06000872 RID: 2162 RVA: 0x00005D10 File Offset: 0x00003F10
		public unsafe AccountID AccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientChatMessage.NativeFieldInfoPtr_AccountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientChatMessage.NativeFieldInfoPtr_AccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000873 RID: 2163 RVA: 0x0002BD94 File Offset: 0x00029F94
		// (set) Token: 0x06000874 RID: 2164 RVA: 0x00005D2F File Offset: 0x00003F2F
		public unsafe string ScreenName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientChatMessage.NativeFieldInfoPtr_ScreenName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientChatMessage.NativeFieldInfoPtr_ScreenName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x0002BDBC File Offset: 0x00029FBC
		// (set) Token: 0x06000876 RID: 2166 RVA: 0x00005D4E File Offset: 0x00003F4E
		public unsafe Dictionary<string, string> Metadata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientChatMessage.NativeFieldInfoPtr_Metadata);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientChatMessage.NativeFieldInfoPtr_Metadata), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x0002BDEC File Offset: 0x00029FEC
		// (set) Token: 0x06000878 RID: 2168 RVA: 0x00005D6D File Offset: 0x00003F6D
		public unsafe string Message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientChatMessage.NativeFieldInfoPtr_Message);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientChatMessage.NativeFieldInfoPtr_Message), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000879 RID: 2169 RVA: 0x0002BE14 File Offset: 0x0002A014
		// (set) Token: 0x0600087A RID: 2170 RVA: 0x00005D8C File Offset: 0x00003F8C
		public unsafe string Game
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientChatMessage.NativeFieldInfoPtr_Game);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientChatMessage.NativeFieldInfoPtr_Game), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000528 RID: 1320
		private static readonly IntPtr NativeFieldInfoPtr_Timestamp;

		// Token: 0x04000529 RID: 1321
		private static readonly IntPtr NativeFieldInfoPtr_AccountID;

		// Token: 0x0400052A RID: 1322
		private static readonly IntPtr NativeFieldInfoPtr_ScreenName;

		// Token: 0x0400052B RID: 1323
		private static readonly IntPtr NativeFieldInfoPtr_Metadata;

		// Token: 0x0400052C RID: 1324
		private static readonly IntPtr NativeFieldInfoPtr_Message;

		// Token: 0x0400052D RID: 1325
		private static readonly IntPtr NativeFieldInfoPtr_Game;

		// Token: 0x0400052E RID: 1326
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400052F RID: 1327
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
