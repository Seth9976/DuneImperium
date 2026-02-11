using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Networking.lobby
{
	// Token: 0x02000093 RID: 147
	public class CreateLobbyGame : NetworkMessageEvent
	{
		// Token: 0x060004D7 RID: 1239 RVA: 0x00013230 File Offset: 0x00011430
		// Note: this type is marked as 'beforefieldinit'.
		static CreateLobbyGame()
		{
			Il2CppClassPointerStore<CreateLobbyGame>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.lobby", "CreateLobbyGame");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateLobbyGame>.NativeClassPtr);
			CreateLobbyGame.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyGame>.NativeClassPtr, "Name");
			CreateLobbyGame.NativeFieldInfoPtr_NumberOfAIPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyGame>.NativeClassPtr, "NumberOfAIPlayers");
			CreateLobbyGame.NativeFieldInfoPtr_NumberOfPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyGame>.NativeClassPtr, "NumberOfPlayers");
			CreateLobbyGame.NativeFieldInfoPtr_MatchType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyGame>.NativeClassPtr, "MatchType");
			CreateLobbyGame.NativeFieldInfoPtr_Password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyGame>.NativeClassPtr, "Password");
			CreateLobbyGame.NativeFieldInfoPtr_PlayerMetadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyGame>.NativeClassPtr, "PlayerMetadata");
			CreateLobbyGame.NativeFieldInfoPtr_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyGame>.NativeClassPtr, "Options");
			CreateLobbyGame.NativeFieldInfoPtr_MatchInitData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyGame>.NativeClassPtr, "MatchInitData");
			CreateLobbyGame.NativeFieldInfoPtr_Game = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyGame>.NativeClassPtr, "Game");
			CreateLobbyGame.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyGame>.NativeClassPtr, 100663621);
			CreateLobbyGame.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyGame>.NativeClassPtr, 100663622);
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x0001333C File Offset: 0x0001153C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1195146, XrefRangeEnd = 1195198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CreateLobbyGame.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00013380 File Offset: 0x00011580
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CreateLobbyGame()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateLobbyGame>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateLobbyGame.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00004ECC File Offset: 0x000030CC
		public CreateLobbyGame(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x000133BC File Offset: 0x000115BC
		// (set) Token: 0x060004DC RID: 1244 RVA: 0x00004ED5 File Offset: 0x000030D5
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateLobbyGame.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateLobbyGame.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x000133E4 File Offset: 0x000115E4
		// (set) Token: 0x060004DE RID: 1246 RVA: 0x00004EF4 File Offset: 0x000030F4
		public unsafe int NumberOfAIPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateLobbyGame.NativeFieldInfoPtr_NumberOfAIPlayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateLobbyGame.NativeFieldInfoPtr_NumberOfAIPlayers)) = value;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x0001340C File Offset: 0x0001160C
		// (set) Token: 0x060004E0 RID: 1248 RVA: 0x00004F0F File Offset: 0x0000310F
		public unsafe int NumberOfPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateLobbyGame.NativeFieldInfoPtr_NumberOfPlayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateLobbyGame.NativeFieldInfoPtr_NumberOfPlayers)) = value;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x00013434 File Offset: 0x00011634
		// (set) Token: 0x060004E2 RID: 1250 RVA: 0x00004F2A File Offset: 0x0000312A
		public unsafe string MatchType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateLobbyGame.NativeFieldInfoPtr_MatchType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateLobbyGame.NativeFieldInfoPtr_MatchType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x0001345C File Offset: 0x0001165C
		// (set) Token: 0x060004E4 RID: 1252 RVA: 0x00004F49 File Offset: 0x00003149
		public unsafe string Password
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateLobbyGame.NativeFieldInfoPtr_Password);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateLobbyGame.NativeFieldInfoPtr_Password), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x00013484 File Offset: 0x00011684
		// (set) Token: 0x060004E6 RID: 1254 RVA: 0x00004F68 File Offset: 0x00003168
		public unsafe Dictionary<string, string> PlayerMetadata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateLobbyGame.NativeFieldInfoPtr_PlayerMetadata);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateLobbyGame.NativeFieldInfoPtr_PlayerMetadata), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x000134B4 File Offset: 0x000116B4
		// (set) Token: 0x060004E8 RID: 1256 RVA: 0x00004F87 File Offset: 0x00003187
		public unsafe Dictionary<string, string> Options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateLobbyGame.NativeFieldInfoPtr_Options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateLobbyGame.NativeFieldInfoPtr_Options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x000134E4 File Offset: 0x000116E4
		// (set) Token: 0x060004EA RID: 1258 RVA: 0x00004FA6 File Offset: 0x000031A6
		public unsafe string MatchInitData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateLobbyGame.NativeFieldInfoPtr_MatchInitData);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateLobbyGame.NativeFieldInfoPtr_MatchInitData), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x0001350C File Offset: 0x0001170C
		// (set) Token: 0x060004EC RID: 1260 RVA: 0x00004FC5 File Offset: 0x000031C5
		public unsafe string Game
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateLobbyGame.NativeFieldInfoPtr_Game);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateLobbyGame.NativeFieldInfoPtr_Game), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040002A0 RID: 672
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeFieldInfoPtr_NumberOfAIPlayers;

		// Token: 0x040002A2 RID: 674
		private static readonly IntPtr NativeFieldInfoPtr_NumberOfPlayers;

		// Token: 0x040002A3 RID: 675
		private static readonly IntPtr NativeFieldInfoPtr_MatchType;

		// Token: 0x040002A4 RID: 676
		private static readonly IntPtr NativeFieldInfoPtr_Password;

		// Token: 0x040002A5 RID: 677
		private static readonly IntPtr NativeFieldInfoPtr_PlayerMetadata;

		// Token: 0x040002A6 RID: 678
		private static readonly IntPtr NativeFieldInfoPtr_Options;

		// Token: 0x040002A7 RID: 679
		private static readonly IntPtr NativeFieldInfoPtr_MatchInitData;

		// Token: 0x040002A8 RID: 680
		private static readonly IntPtr NativeFieldInfoPtr_Game;

		// Token: 0x040002A9 RID: 681
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040002AA RID: 682
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
