using System;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Networking.game
{
	// Token: 0x020000AE RID: 174
	public class DWDPendingGameMetadata : Object
	{
		// Token: 0x060005AF RID: 1455 RVA: 0x00015078 File Offset: 0x00013278
		// Note: this type is marked as 'beforefieldinit'.
		static DWDPendingGameMetadata()
		{
			Il2CppClassPointerStore<DWDPendingGameMetadata>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.game", "DWDPendingGameMetadata");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DWDPendingGameMetadata>.NativeClassPtr);
			DWDPendingGameMetadata.NativeFieldInfoPtr_GameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDPendingGameMetadata>.NativeClassPtr, "GameID");
			DWDPendingGameMetadata.NativeFieldInfoPtr_CreatorID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDPendingGameMetadata>.NativeClassPtr, "CreatorID");
			DWDPendingGameMetadata.NativeFieldInfoPtr_MaximumPlayerSessionCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDPendingGameMetadata>.NativeClassPtr, "MaximumPlayerSessionCount");
			DWDPendingGameMetadata.NativeFieldInfoPtr_AIPlayerCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDPendingGameMetadata>.NativeClassPtr, "AIPlayerCount");
			DWDPendingGameMetadata.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDPendingGameMetadata>.NativeClassPtr, "Name");
			DWDPendingGameMetadata.NativeFieldInfoPtr_CurrentPlayerSessionCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDPendingGameMetadata>.NativeClassPtr, "CurrentPlayerSessionCount");
			DWDPendingGameMetadata.NativeFieldInfoPtr_PlayersInGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDPendingGameMetadata>.NativeClassPtr, "PlayersInGame");
			DWDPendingGameMetadata.NativeFieldInfoPtr_AlreadyInGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDPendingGameMetadata>.NativeClassPtr, "AlreadyInGame");
			DWDPendingGameMetadata.NativeFieldInfoPtr_HasPassword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDPendingGameMetadata>.NativeClassPtr, "HasPassword");
			DWDPendingGameMetadata.NativeFieldInfoPtr_MatchType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDPendingGameMetadata>.NativeClassPtr, "MatchType");
			DWDPendingGameMetadata.NativeFieldInfoPtr_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDPendingGameMetadata>.NativeClassPtr, "Options");
			DWDPendingGameMetadata.NativeFieldInfoPtr_MatchInitData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDPendingGameMetadata>.NativeClassPtr, "MatchInitData");
			DWDPendingGameMetadata.NativeFieldInfoPtr_Password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDPendingGameMetadata>.NativeClassPtr, "Password");
			DWDPendingGameMetadata.NativeMethodInfoPtr_IsPlayerInGame_Public_Boolean_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDPendingGameMetadata>.NativeClassPtr, 100663651);
			DWDPendingGameMetadata.NativeMethodInfoPtr_IsPlayerBlocked_Public_Boolean_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDPendingGameMetadata>.NativeClassPtr, 100663652);
			DWDPendingGameMetadata.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDPendingGameMetadata>.NativeClassPtr, 100663653);
			DWDPendingGameMetadata.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDPendingGameMetadata>.NativeClassPtr, 100663654);
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x000151FC File Offset: 0x000133FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1195223, XrefRangeEnd = 1195238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPlayerInGame(AccountID id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDPendingGameMetadata.NativeMethodInfoPtr_IsPlayerInGame_Public_Boolean_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x0001524C File Offset: 0x0001344C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1195256, RefRangeEnd = 1195259, XrefRangeStart = 1195238, XrefRangeEnd = 1195256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPlayerBlocked(AccountID id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDPendingGameMetadata.NativeMethodInfoPtr_IsPlayerBlocked_Public_Boolean_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x0001529C File Offset: 0x0001349C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1195259, XrefRangeEnd = 1195316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DWDPendingGameMetadata.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x000152E0 File Offset: 0x000134E0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DWDPendingGameMetadata()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DWDPendingGameMetadata>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDPendingGameMetadata.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00005834 File Offset: 0x00003A34
		public DWDPendingGameMetadata(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x0001531C File Offset: 0x0001351C
		// (set) Token: 0x060005B6 RID: 1462 RVA: 0x0000583D File Offset: 0x00003A3D
		public unsafe GameID GameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDPendingGameMetadata.NativeFieldInfoPtr_GameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDPendingGameMetadata.NativeFieldInfoPtr_GameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x0001534C File Offset: 0x0001354C
		// (set) Token: 0x060005B8 RID: 1464 RVA: 0x0000585C File Offset: 0x00003A5C
		public unsafe AccountID CreatorID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDPendingGameMetadata.NativeFieldInfoPtr_CreatorID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDPendingGameMetadata.NativeFieldInfoPtr_CreatorID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x0001537C File Offset: 0x0001357C
		// (set) Token: 0x060005BA RID: 1466 RVA: 0x0000587B File Offset: 0x00003A7B
		public unsafe int MaximumPlayerSessionCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDPendingGameMetadata.NativeFieldInfoPtr_MaximumPlayerSessionCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDPendingGameMetadata.NativeFieldInfoPtr_MaximumPlayerSessionCount)) = value;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060005BB RID: 1467 RVA: 0x000153A4 File Offset: 0x000135A4
		// (set) Token: 0x060005BC RID: 1468 RVA: 0x00005896 File Offset: 0x00003A96
		public unsafe int AIPlayerCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDPendingGameMetadata.NativeFieldInfoPtr_AIPlayerCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDPendingGameMetadata.NativeFieldInfoPtr_AIPlayerCount)) = value;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060005BD RID: 1469 RVA: 0x000153CC File Offset: 0x000135CC
		// (set) Token: 0x060005BE RID: 1470 RVA: 0x000058B1 File Offset: 0x00003AB1
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDPendingGameMetadata.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDPendingGameMetadata.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060005BF RID: 1471 RVA: 0x000153F4 File Offset: 0x000135F4
		// (set) Token: 0x060005C0 RID: 1472 RVA: 0x000058D0 File Offset: 0x00003AD0
		public unsafe int CurrentPlayerSessionCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDPendingGameMetadata.NativeFieldInfoPtr_CurrentPlayerSessionCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDPendingGameMetadata.NativeFieldInfoPtr_CurrentPlayerSessionCount)) = value;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x060005C1 RID: 1473 RVA: 0x0001541C File Offset: 0x0001361C
		// (set) Token: 0x060005C2 RID: 1474 RVA: 0x000058EB File Offset: 0x00003AEB
		public unsafe List<AccountIDUsernameMetadata> PlayersInGame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDPendingGameMetadata.NativeFieldInfoPtr_PlayersInGame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AccountIDUsernameMetadata>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDPendingGameMetadata.NativeFieldInfoPtr_PlayersInGame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x060005C3 RID: 1475 RVA: 0x0001544C File Offset: 0x0001364C
		// (set) Token: 0x060005C4 RID: 1476 RVA: 0x0000590A File Offset: 0x00003B0A
		public unsafe bool AlreadyInGame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDPendingGameMetadata.NativeFieldInfoPtr_AlreadyInGame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDPendingGameMetadata.NativeFieldInfoPtr_AlreadyInGame)) = value;
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060005C5 RID: 1477 RVA: 0x00015474 File Offset: 0x00013674
		// (set) Token: 0x060005C6 RID: 1478 RVA: 0x00005925 File Offset: 0x00003B25
		public unsafe bool HasPassword
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDPendingGameMetadata.NativeFieldInfoPtr_HasPassword);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDPendingGameMetadata.NativeFieldInfoPtr_HasPassword)) = value;
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x060005C7 RID: 1479 RVA: 0x0001549C File Offset: 0x0001369C
		// (set) Token: 0x060005C8 RID: 1480 RVA: 0x00005940 File Offset: 0x00003B40
		public unsafe string MatchType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDPendingGameMetadata.NativeFieldInfoPtr_MatchType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDPendingGameMetadata.NativeFieldInfoPtr_MatchType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x000154C4 File Offset: 0x000136C4
		// (set) Token: 0x060005CA RID: 1482 RVA: 0x0000595F File Offset: 0x00003B5F
		public unsafe Dictionary<string, string> Options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDPendingGameMetadata.NativeFieldInfoPtr_Options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDPendingGameMetadata.NativeFieldInfoPtr_Options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x000154F4 File Offset: 0x000136F4
		// (set) Token: 0x060005CC RID: 1484 RVA: 0x0000597E File Offset: 0x00003B7E
		public unsafe string MatchInitData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDPendingGameMetadata.NativeFieldInfoPtr_MatchInitData);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDPendingGameMetadata.NativeFieldInfoPtr_MatchInitData), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060005CD RID: 1485 RVA: 0x0001551C File Offset: 0x0001371C
		// (set) Token: 0x060005CE RID: 1486 RVA: 0x0000599D File Offset: 0x00003B9D
		public unsafe string Password
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDPendingGameMetadata.NativeFieldInfoPtr_Password);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDPendingGameMetadata.NativeFieldInfoPtr_Password), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000300 RID: 768
		private static readonly IntPtr NativeFieldInfoPtr_GameID;

		// Token: 0x04000301 RID: 769
		private static readonly IntPtr NativeFieldInfoPtr_CreatorID;

		// Token: 0x04000302 RID: 770
		private static readonly IntPtr NativeFieldInfoPtr_MaximumPlayerSessionCount;

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeFieldInfoPtr_AIPlayerCount;

		// Token: 0x04000304 RID: 772
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeFieldInfoPtr_CurrentPlayerSessionCount;

		// Token: 0x04000306 RID: 774
		private static readonly IntPtr NativeFieldInfoPtr_PlayersInGame;

		// Token: 0x04000307 RID: 775
		private static readonly IntPtr NativeFieldInfoPtr_AlreadyInGame;

		// Token: 0x04000308 RID: 776
		private static readonly IntPtr NativeFieldInfoPtr_HasPassword;

		// Token: 0x04000309 RID: 777
		private static readonly IntPtr NativeFieldInfoPtr_MatchType;

		// Token: 0x0400030A RID: 778
		private static readonly IntPtr NativeFieldInfoPtr_Options;

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeFieldInfoPtr_MatchInitData;

		// Token: 0x0400030C RID: 780
		private static readonly IntPtr NativeFieldInfoPtr_Password;

		// Token: 0x0400030D RID: 781
		private static readonly IntPtr NativeMethodInfoPtr_IsPlayerInGame_Public_Boolean_AccountID_0;

		// Token: 0x0400030E RID: 782
		private static readonly IntPtr NativeMethodInfoPtr_IsPlayerBlocked_Public_Boolean_AccountID_0;

		// Token: 0x0400030F RID: 783
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000310 RID: 784
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000CB RID: 203
		[ObfuscatedName("Networking.game.DWDPendingGameMetadata+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Object
		{
			// Token: 0x06000694 RID: 1684 RVA: 0x0001730C File Offset: 0x0001550C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<DWDPendingGameMetadata.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DWDPendingGameMetadata>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DWDPendingGameMetadata.__c__DisplayClass13_0>.NativeClassPtr);
				DWDPendingGameMetadata.__c__DisplayClass13_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDPendingGameMetadata.__c__DisplayClass13_0>.NativeClassPtr, "id");
				DWDPendingGameMetadata.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDPendingGameMetadata.__c__DisplayClass13_0>.NativeClassPtr, 100663655);
				DWDPendingGameMetadata.__c__DisplayClass13_0.NativeMethodInfoPtr__IsPlayerInGame_b__0_Internal_Boolean_AccountIDUsernameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDPendingGameMetadata.__c__DisplayClass13_0>.NativeClassPtr, 100663656);
			}

			// Token: 0x06000695 RID: 1685 RVA: 0x00017374 File Offset: 0x00015574
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DWDPendingGameMetadata.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDPendingGameMetadata.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000696 RID: 1686 RVA: 0x000173B0 File Offset: 0x000155B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1195218, XrefRangeEnd = 1195223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _IsPlayerInGame_b__0(AccountIDUsernameMetadata t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDPendingGameMetadata.__c__DisplayClass13_0.NativeMethodInfoPtr__IsPlayerInGame_b__0_Internal_Boolean_AccountIDUsernameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000697 RID: 1687 RVA: 0x00006110 File Offset: 0x00004310
			public __c__DisplayClass13_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001E6 RID: 486
			// (get) Token: 0x06000698 RID: 1688 RVA: 0x00017400 File Offset: 0x00015600
			// (set) Token: 0x06000699 RID: 1689 RVA: 0x00006119 File Offset: 0x00004319
			public unsafe AccountID id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDPendingGameMetadata.__c__DisplayClass13_0.NativeFieldInfoPtr_id);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDPendingGameMetadata.__c__DisplayClass13_0.NativeFieldInfoPtr_id), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400036A RID: 874
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x0400036B RID: 875
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400036C RID: 876
			private static readonly IntPtr NativeMethodInfoPtr__IsPlayerInGame_b__0_Internal_Boolean_AccountIDUsernameMetadata_0;
		}
	}
}
