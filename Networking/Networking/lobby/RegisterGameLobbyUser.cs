using System;
using Canis.json.events;
using Canis.utils.ids;
using dwd.core.platform.authentication;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Networking.lobby
{
	// Token: 0x0200009A RID: 154
	public class RegisterGameLobbyUser : NetworkMessageEvent
	{
		// Token: 0x06000517 RID: 1303 RVA: 0x00013AE8 File Offset: 0x00011CE8
		// Note: this type is marked as 'beforefieldinit'.
		static RegisterGameLobbyUser()
		{
			Il2CppClassPointerStore<RegisterGameLobbyUser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.lobby", "RegisterGameLobbyUser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterGameLobbyUser>.NativeClassPtr);
			RegisterGameLobbyUser.NativeFieldInfoPtr_Token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterGameLobbyUser>.NativeClassPtr, "Token");
			RegisterGameLobbyUser.NativeFieldInfoPtr_Metadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterGameLobbyUser>.NativeClassPtr, "Metadata");
			RegisterGameLobbyUser.NativeFieldInfoPtr_GameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterGameLobbyUser>.NativeClassPtr, "GameID");
			RegisterGameLobbyUser.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterGameLobbyUser>.NativeClassPtr, 100663629);
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00013B68 File Offset: 0x00011D68
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegisterGameLobbyUser()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegisterGameLobbyUser>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterGameLobbyUser.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x000051B7 File Offset: 0x000033B7
		public RegisterGameLobbyUser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x00013BA4 File Offset: 0x00011DA4
		// (set) Token: 0x0600051B RID: 1307 RVA: 0x000051C0 File Offset: 0x000033C0
		public unsafe PlatformToken Token
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterGameLobbyUser.NativeFieldInfoPtr_Token);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformToken>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterGameLobbyUser.NativeFieldInfoPtr_Token), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x00013BD4 File Offset: 0x00011DD4
		// (set) Token: 0x0600051D RID: 1309 RVA: 0x000051DF File Offset: 0x000033DF
		public unsafe Dictionary<string, string> Metadata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterGameLobbyUser.NativeFieldInfoPtr_Metadata);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterGameLobbyUser.NativeFieldInfoPtr_Metadata), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x0600051E RID: 1310 RVA: 0x00013C04 File Offset: 0x00011E04
		// (set) Token: 0x0600051F RID: 1311 RVA: 0x000051FE File Offset: 0x000033FE
		public unsafe GameID GameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterGameLobbyUser.NativeFieldInfoPtr_GameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterGameLobbyUser.NativeFieldInfoPtr_GameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeFieldInfoPtr_Token;

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeFieldInfoPtr_Metadata;

		// Token: 0x040002BF RID: 703
		private static readonly IntPtr NativeFieldInfoPtr_GameID;

		// Token: 0x040002C0 RID: 704
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
