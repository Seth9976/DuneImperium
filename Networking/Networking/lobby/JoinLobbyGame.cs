using System;
using Canis.json.events;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Networking.lobby
{
	// Token: 0x02000097 RID: 151
	public class JoinLobbyGame : NetworkMessageEvent
	{
		// Token: 0x06000502 RID: 1282 RVA: 0x000137E0 File Offset: 0x000119E0
		// Note: this type is marked as 'beforefieldinit'.
		static JoinLobbyGame()
		{
			Il2CppClassPointerStore<JoinLobbyGame>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.lobby", "JoinLobbyGame");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JoinLobbyGame>.NativeClassPtr);
			JoinLobbyGame.NativeFieldInfoPtr_GameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinLobbyGame>.NativeClassPtr, "GameID");
			JoinLobbyGame.NativeFieldInfoPtr_Password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinLobbyGame>.NativeClassPtr, "Password");
			JoinLobbyGame.NativeFieldInfoPtr_Metadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinLobbyGame>.NativeClassPtr, "Metadata");
			JoinLobbyGame.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinLobbyGame>.NativeClassPtr, 100663626);
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00013860 File Offset: 0x00011A60
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JoinLobbyGame()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JoinLobbyGame>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoinLobbyGame.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x000050E2 File Offset: 0x000032E2
		public JoinLobbyGame(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x0001389C File Offset: 0x00011A9C
		// (set) Token: 0x06000506 RID: 1286 RVA: 0x000050EB File Offset: 0x000032EB
		public unsafe GameID GameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinLobbyGame.NativeFieldInfoPtr_GameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinLobbyGame.NativeFieldInfoPtr_GameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x000138CC File Offset: 0x00011ACC
		// (set) Token: 0x06000508 RID: 1288 RVA: 0x0000510A File Offset: 0x0000330A
		public unsafe string Password
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinLobbyGame.NativeFieldInfoPtr_Password);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinLobbyGame.NativeFieldInfoPtr_Password), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x000138F4 File Offset: 0x00011AF4
		// (set) Token: 0x0600050A RID: 1290 RVA: 0x00005129 File Offset: 0x00003329
		public unsafe Dictionary<string, string> Metadata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinLobbyGame.NativeFieldInfoPtr_Metadata);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinLobbyGame.NativeFieldInfoPtr_Metadata), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeFieldInfoPtr_GameID;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeFieldInfoPtr_Password;

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeFieldInfoPtr_Metadata;

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
