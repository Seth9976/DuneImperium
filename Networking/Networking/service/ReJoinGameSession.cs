using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Networking.service
{
	// Token: 0x0200005B RID: 91
	public class ReJoinGameSession : NetworkMessageEvent
	{
		// Token: 0x060002E3 RID: 739 RVA: 0x0000D2E4 File Offset: 0x0000B4E4
		// Note: this type is marked as 'beforefieldinit'.
		static ReJoinGameSession()
		{
			Il2CppClassPointerStore<ReJoinGameSession>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.service", "ReJoinGameSession");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReJoinGameSession>.NativeClassPtr);
			ReJoinGameSession.NativeFieldInfoPtr_GameSessionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReJoinGameSession>.NativeClassPtr, "GameSessionID");
			ReJoinGameSession.NativeFieldInfoPtr_PlayerSessionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReJoinGameSession>.NativeClassPtr, "PlayerSessionID");
			ReJoinGameSession.NativeFieldInfoPtr_Token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReJoinGameSession>.NativeClassPtr, "Token");
			ReJoinGameSession.NativeFieldInfoPtr_Metadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReJoinGameSession>.NativeClassPtr, "Metadata");
			ReJoinGameSession.NativeFieldInfoPtr_FastReconnect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReJoinGameSession>.NativeClassPtr, "FastReconnect");
			ReJoinGameSession.NativeFieldInfoPtr_AckClientMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReJoinGameSession>.NativeClassPtr, "AckClientMessages");
			ReJoinGameSession.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReJoinGameSession>.NativeClassPtr, 100663442);
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0000D3A0 File Offset: 0x0000B5A0
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReJoinGameSession()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReJoinGameSession>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReJoinGameSession.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00003E77 File Offset: 0x00002077
		public ReJoinGameSession(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x0000D3DC File Offset: 0x0000B5DC
		// (set) Token: 0x060002E7 RID: 743 RVA: 0x00003E80 File Offset: 0x00002080
		public unsafe string GameSessionID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReJoinGameSession.NativeFieldInfoPtr_GameSessionID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReJoinGameSession.NativeFieldInfoPtr_GameSessionID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x0000D404 File Offset: 0x0000B604
		// (set) Token: 0x060002E9 RID: 745 RVA: 0x00003E9F File Offset: 0x0000209F
		public unsafe string PlayerSessionID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReJoinGameSession.NativeFieldInfoPtr_PlayerSessionID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReJoinGameSession.NativeFieldInfoPtr_PlayerSessionID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060002EA RID: 746 RVA: 0x0000D42C File Offset: 0x0000B62C
		// (set) Token: 0x060002EB RID: 747 RVA: 0x00003EBE File Offset: 0x000020BE
		public unsafe string Token
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReJoinGameSession.NativeFieldInfoPtr_Token);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReJoinGameSession.NativeFieldInfoPtr_Token), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060002EC RID: 748 RVA: 0x0000D454 File Offset: 0x0000B654
		// (set) Token: 0x060002ED RID: 749 RVA: 0x00003EDD File Offset: 0x000020DD
		public unsafe Dictionary<string, string> Metadata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReJoinGameSession.NativeFieldInfoPtr_Metadata);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReJoinGameSession.NativeFieldInfoPtr_Metadata), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060002EE RID: 750 RVA: 0x0000D484 File Offset: 0x0000B684
		// (set) Token: 0x060002EF RID: 751 RVA: 0x00003EFC File Offset: 0x000020FC
		public unsafe bool FastReconnect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReJoinGameSession.NativeFieldInfoPtr_FastReconnect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReJoinGameSession.NativeFieldInfoPtr_FastReconnect)) = value;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x0000D4AC File Offset: 0x0000B6AC
		// (set) Token: 0x060002F1 RID: 753 RVA: 0x00003F17 File Offset: 0x00002117
		public unsafe bool AckClientMessages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReJoinGameSession.NativeFieldInfoPtr_AckClientMessages);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReJoinGameSession.NativeFieldInfoPtr_AckClientMessages)) = value;
			}
		}

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeFieldInfoPtr_GameSessionID;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeFieldInfoPtr_PlayerSessionID;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeFieldInfoPtr_Token;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeFieldInfoPtr_Metadata;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeFieldInfoPtr_FastReconnect;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeFieldInfoPtr_AckClientMessages;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
