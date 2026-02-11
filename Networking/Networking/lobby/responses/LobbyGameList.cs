using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Networking.game;

namespace Networking.lobby.responses
{
	// Token: 0x020000A0 RID: 160
	public class LobbyGameList : NetworkMessageEvent
	{
		// Token: 0x0600053D RID: 1341 RVA: 0x0001404C File Offset: 0x0001224C
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyGameList()
		{
			Il2CppClassPointerStore<LobbyGameList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.lobby.responses", "LobbyGameList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyGameList>.NativeClassPtr);
			LobbyGameList.NativeFieldInfoPtr_Games = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyGameList>.NativeClassPtr, "Games");
			LobbyGameList.NativeFieldInfoPtr_TotalResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyGameList>.NativeClassPtr, "TotalResults");
			LobbyGameList.NativeFieldInfoPtr_PageReturned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyGameList>.NativeClassPtr, "PageReturned");
			LobbyGameList.NativeFieldInfoPtr_PasswordGamesIncluded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyGameList>.NativeClassPtr, "PasswordGamesIncluded");
			LobbyGameList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyGameList>.NativeClassPtr, 100663635);
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x000140E0 File Offset: 0x000122E0
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LobbyGameList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyGameList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyGameList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x0000535C File Offset: 0x0000355C
		public LobbyGameList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000540 RID: 1344 RVA: 0x0001411C File Offset: 0x0001231C
		// (set) Token: 0x06000541 RID: 1345 RVA: 0x00005365 File Offset: 0x00003565
		public unsafe List<DWDPendingGameMetadata> Games
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyGameList.NativeFieldInfoPtr_Games);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DWDPendingGameMetadata>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyGameList.NativeFieldInfoPtr_Games), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000542 RID: 1346 RVA: 0x0001414C File Offset: 0x0001234C
		// (set) Token: 0x06000543 RID: 1347 RVA: 0x00005384 File Offset: 0x00003584
		public unsafe int TotalResults
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyGameList.NativeFieldInfoPtr_TotalResults);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyGameList.NativeFieldInfoPtr_TotalResults)) = value;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000544 RID: 1348 RVA: 0x00014174 File Offset: 0x00012374
		// (set) Token: 0x06000545 RID: 1349 RVA: 0x0000539F File Offset: 0x0000359F
		public unsafe int PageReturned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyGameList.NativeFieldInfoPtr_PageReturned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyGameList.NativeFieldInfoPtr_PageReturned)) = value;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000546 RID: 1350 RVA: 0x0001419C File Offset: 0x0001239C
		// (set) Token: 0x06000547 RID: 1351 RVA: 0x000053BA File Offset: 0x000035BA
		public unsafe bool PasswordGamesIncluded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyGameList.NativeFieldInfoPtr_PasswordGamesIncluded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyGameList.NativeFieldInfoPtr_PasswordGamesIncluded)) = value;
			}
		}

		// Token: 0x040002CD RID: 717
		private static readonly IntPtr NativeFieldInfoPtr_Games;

		// Token: 0x040002CE RID: 718
		private static readonly IntPtr NativeFieldInfoPtr_TotalResults;

		// Token: 0x040002CF RID: 719
		private static readonly IntPtr NativeFieldInfoPtr_PageReturned;

		// Token: 0x040002D0 RID: 720
		private static readonly IntPtr NativeFieldInfoPtr_PasswordGamesIncluded;

		// Token: 0x040002D1 RID: 721
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
