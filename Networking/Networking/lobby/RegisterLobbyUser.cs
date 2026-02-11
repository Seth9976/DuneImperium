using System;
using Canis.json.events;
using dwd.core.platform.authentication;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Networking.lobby
{
	// Token: 0x0200009B RID: 155
	public class RegisterLobbyUser : NetworkMessageEvent
	{
		// Token: 0x06000520 RID: 1312 RVA: 0x00013C34 File Offset: 0x00011E34
		// Note: this type is marked as 'beforefieldinit'.
		static RegisterLobbyUser()
		{
			Il2CppClassPointerStore<RegisterLobbyUser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.lobby", "RegisterLobbyUser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterLobbyUser>.NativeClassPtr);
			RegisterLobbyUser.NativeFieldInfoPtr_Token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterLobbyUser>.NativeClassPtr, "Token");
			RegisterLobbyUser.NativeFieldInfoPtr_Metadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterLobbyUser>.NativeClassPtr, "Metadata");
			RegisterLobbyUser.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterLobbyUser>.NativeClassPtr, 100663630);
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00013CA0 File Offset: 0x00011EA0
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegisterLobbyUser()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegisterLobbyUser>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterLobbyUser.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x0000521D File Offset: 0x0000341D
		public RegisterLobbyUser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x00013CDC File Offset: 0x00011EDC
		// (set) Token: 0x06000524 RID: 1316 RVA: 0x00005226 File Offset: 0x00003426
		public unsafe PlatformToken Token
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterLobbyUser.NativeFieldInfoPtr_Token);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformToken>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterLobbyUser.NativeFieldInfoPtr_Token), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x00013D0C File Offset: 0x00011F0C
		// (set) Token: 0x06000526 RID: 1318 RVA: 0x00005245 File Offset: 0x00003445
		public unsafe Dictionary<string, string> Metadata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterLobbyUser.NativeFieldInfoPtr_Metadata);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterLobbyUser.NativeFieldInfoPtr_Metadata), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002C1 RID: 705
		private static readonly IntPtr NativeFieldInfoPtr_Token;

		// Token: 0x040002C2 RID: 706
		private static readonly IntPtr NativeFieldInfoPtr_Metadata;

		// Token: 0x040002C3 RID: 707
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
