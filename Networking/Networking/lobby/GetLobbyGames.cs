using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Networking.lobby
{
	// Token: 0x02000094 RID: 148
	public class GetLobbyGames : NetworkMessageEvent
	{
		// Token: 0x060004ED RID: 1261 RVA: 0x00013534 File Offset: 0x00011734
		// Note: this type is marked as 'beforefieldinit'.
		static GetLobbyGames()
		{
			Il2CppClassPointerStore<GetLobbyGames>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.lobby", "GetLobbyGames");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetLobbyGames>.NativeClassPtr);
			GetLobbyGames.NativeFieldInfoPtr_paginate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetLobbyGames>.NativeClassPtr, "paginate");
			GetLobbyGames.NativeFieldInfoPtr_passwordGamesShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetLobbyGames>.NativeClassPtr, "passwordGamesShown");
			GetLobbyGames.NativeFieldInfoPtr_page = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetLobbyGames>.NativeClassPtr, "page");
			GetLobbyGames.NativeFieldInfoPtr_entriesPerPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetLobbyGames>.NativeClassPtr, "entriesPerPage");
			GetLobbyGames.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetLobbyGames>.NativeClassPtr, 100663623);
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x000135C8 File Offset: 0x000117C8
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetLobbyGames()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetLobbyGames>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetLobbyGames.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00004FE4 File Offset: 0x000031E4
		public GetLobbyGames(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x00013604 File Offset: 0x00011804
		// (set) Token: 0x060004F1 RID: 1265 RVA: 0x00004FED File Offset: 0x000031ED
		public unsafe bool paginate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetLobbyGames.NativeFieldInfoPtr_paginate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetLobbyGames.NativeFieldInfoPtr_paginate)) = value;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060004F2 RID: 1266 RVA: 0x0001362C File Offset: 0x0001182C
		// (set) Token: 0x060004F3 RID: 1267 RVA: 0x00005008 File Offset: 0x00003208
		public unsafe bool passwordGamesShown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetLobbyGames.NativeFieldInfoPtr_passwordGamesShown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetLobbyGames.NativeFieldInfoPtr_passwordGamesShown)) = value;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060004F4 RID: 1268 RVA: 0x00013654 File Offset: 0x00011854
		// (set) Token: 0x060004F5 RID: 1269 RVA: 0x00005023 File Offset: 0x00003223
		public unsafe int page
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetLobbyGames.NativeFieldInfoPtr_page);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetLobbyGames.NativeFieldInfoPtr_page)) = value;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060004F6 RID: 1270 RVA: 0x0001367C File Offset: 0x0001187C
		// (set) Token: 0x060004F7 RID: 1271 RVA: 0x0000503E File Offset: 0x0000323E
		public unsafe int entriesPerPage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetLobbyGames.NativeFieldInfoPtr_entriesPerPage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetLobbyGames.NativeFieldInfoPtr_entriesPerPage)) = value;
			}
		}

		// Token: 0x040002AB RID: 683
		private static readonly IntPtr NativeFieldInfoPtr_paginate;

		// Token: 0x040002AC RID: 684
		private static readonly IntPtr NativeFieldInfoPtr_passwordGamesShown;

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeFieldInfoPtr_page;

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeFieldInfoPtr_entriesPerPage;

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
