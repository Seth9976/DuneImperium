using System;
using Canis.json.events;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Networking.game.messages.pbm
{
	// Token: 0x020000B0 RID: 176
	public class PBMGameResigned : NetworkMessageEvent
	{
		// Token: 0x060005D9 RID: 1497 RVA: 0x000156E0 File Offset: 0x000138E0
		// Note: this type is marked as 'beforefieldinit'.
		static PBMGameResigned()
		{
			Il2CppClassPointerStore<PBMGameResigned>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.game.messages.pbm", "PBMGameResigned");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PBMGameResigned>.NativeClassPtr);
			PBMGameResigned.NativeFieldInfoPtr_GameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PBMGameResigned>.NativeClassPtr, "GameID");
			PBMGameResigned.NativeFieldInfoPtr_playerSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PBMGameResigned>.NativeClassPtr, "playerSlots");
			PBMGameResigned.NativeFieldInfoPtr_GameOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PBMGameResigned>.NativeClassPtr, "GameOptions");
			PBMGameResigned.NativeFieldInfoPtr_GameName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PBMGameResigned>.NativeClassPtr, "GameName");
			PBMGameResigned.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PBMGameResigned>.NativeClassPtr, 100663659);
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00015774 File Offset: 0x00013974
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PBMGameResigned()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PBMGameResigned>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PBMGameResigned.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00005A1E File Offset: 0x00003C1E
		public PBMGameResigned(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060005DC RID: 1500 RVA: 0x000157B0 File Offset: 0x000139B0
		// (set) Token: 0x060005DD RID: 1501 RVA: 0x00005A27 File Offset: 0x00003C27
		public unsafe GameID GameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PBMGameResigned.NativeFieldInfoPtr_GameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PBMGameResigned.NativeFieldInfoPtr_GameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x060005DE RID: 1502 RVA: 0x000157E0 File Offset: 0x000139E0
		// (set) Token: 0x060005DF RID: 1503 RVA: 0x00005A46 File Offset: 0x00003C46
		public unsafe Il2CppReferenceArray<AccountIDUsernameMetadata> playerSlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PBMGameResigned.NativeFieldInfoPtr_playerSlots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AccountIDUsernameMetadata>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PBMGameResigned.NativeFieldInfoPtr_playerSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x060005E0 RID: 1504 RVA: 0x00015810 File Offset: 0x00013A10
		// (set) Token: 0x060005E1 RID: 1505 RVA: 0x00005A65 File Offset: 0x00003C65
		public unsafe Dictionary<string, string> GameOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PBMGameResigned.NativeFieldInfoPtr_GameOptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PBMGameResigned.NativeFieldInfoPtr_GameOptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060005E2 RID: 1506 RVA: 0x00015840 File Offset: 0x00013A40
		// (set) Token: 0x060005E3 RID: 1507 RVA: 0x00005A84 File Offset: 0x00003C84
		public unsafe string GameName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PBMGameResigned.NativeFieldInfoPtr_GameName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PBMGameResigned.NativeFieldInfoPtr_GameName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000316 RID: 790
		private static readonly IntPtr NativeFieldInfoPtr_GameID;

		// Token: 0x04000317 RID: 791
		private static readonly IntPtr NativeFieldInfoPtr_playerSlots;

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeFieldInfoPtr_GameOptions;

		// Token: 0x04000319 RID: 793
		private static readonly IntPtr NativeFieldInfoPtr_GameName;

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
