using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Networking.lobby.responses
{
	// Token: 0x020000A9 RID: 169
	public class LobbyQueuePlayer : Object
	{
		// Token: 0x0600057A RID: 1402 RVA: 0x00014930 File Offset: 0x00012B30
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyQueuePlayer()
		{
			Il2CppClassPointerStore<LobbyQueuePlayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.lobby.responses", "LobbyQueuePlayer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyQueuePlayer>.NativeClassPtr);
			LobbyQueuePlayer.NativeFieldInfoPtr_accountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyQueuePlayer>.NativeClassPtr, "accountID");
			LobbyQueuePlayer.NativeFieldInfoPtr_username = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyQueuePlayer>.NativeClassPtr, "username");
			LobbyQueuePlayer.NativeFieldInfoPtr_metadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyQueuePlayer>.NativeClassPtr, "metadata");
			LobbyQueuePlayer.NativeFieldInfoPtr_joinedAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyQueuePlayer>.NativeClassPtr, "joinedAt");
			LobbyQueuePlayer.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyQueuePlayer>.NativeClassPtr, 100663644);
			LobbyQueuePlayer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyQueuePlayer>.NativeClassPtr, 100663645);
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x000149D8 File Offset: 0x00012BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1195198, XrefRangeEnd = 1195204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LobbyQueuePlayer.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00014A1C File Offset: 0x00012C1C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LobbyQueuePlayer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyQueuePlayer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyQueuePlayer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x000055B0 File Offset: 0x000037B0
		public LobbyQueuePlayer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x0600057E RID: 1406 RVA: 0x00014A58 File Offset: 0x00012C58
		// (set) Token: 0x0600057F RID: 1407 RVA: 0x000055B9 File Offset: 0x000037B9
		public unsafe AccountID accountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyQueuePlayer.NativeFieldInfoPtr_accountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyQueuePlayer.NativeFieldInfoPtr_accountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000580 RID: 1408 RVA: 0x00014A88 File Offset: 0x00012C88
		// (set) Token: 0x06000581 RID: 1409 RVA: 0x000055D8 File Offset: 0x000037D8
		public unsafe string username
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyQueuePlayer.NativeFieldInfoPtr_username);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyQueuePlayer.NativeFieldInfoPtr_username), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000582 RID: 1410 RVA: 0x00014AB0 File Offset: 0x00012CB0
		// (set) Token: 0x06000583 RID: 1411 RVA: 0x000055F7 File Offset: 0x000037F7
		public unsafe Dictionary<string, string> metadata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyQueuePlayer.NativeFieldInfoPtr_metadata);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyQueuePlayer.NativeFieldInfoPtr_metadata), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000584 RID: 1412 RVA: 0x00014AE0 File Offset: 0x00012CE0
		// (set) Token: 0x06000585 RID: 1413 RVA: 0x00005616 File Offset: 0x00003816
		public unsafe long joinedAt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyQueuePlayer.NativeFieldInfoPtr_joinedAt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyQueuePlayer.NativeFieldInfoPtr_joinedAt)) = value;
			}
		}

		// Token: 0x040002E7 RID: 743
		private static readonly IntPtr NativeFieldInfoPtr_accountID;

		// Token: 0x040002E8 RID: 744
		private static readonly IntPtr NativeFieldInfoPtr_username;

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeFieldInfoPtr_metadata;

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeFieldInfoPtr_joinedAt;

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040002EC RID: 748
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
