using System;
using Canis.json.events;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Canis.messages
{
	// Token: 0x0200002C RID: 44
	public class PBMTurnReady : NetworkMessageEvent
	{
		// Token: 0x06000170 RID: 368 RVA: 0x00009AE0 File Offset: 0x00007CE0
		// Note: this type is marked as 'beforefieldinit'.
		static PBMTurnReady()
		{
			Il2CppClassPointerStore<PBMTurnReady>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages", "PBMTurnReady");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PBMTurnReady>.NativeClassPtr);
			PBMTurnReady.NativeFieldInfoPtr_GameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PBMTurnReady>.NativeClassPtr, "GameID");
			PBMTurnReady.NativeFieldInfoPtr_playerSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PBMTurnReady>.NativeClassPtr, "playerSlots");
			PBMTurnReady.NativeFieldInfoPtr_GameOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PBMTurnReady>.NativeClassPtr, "GameOptions");
			PBMTurnReady.NativeFieldInfoPtr_TurnNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PBMTurnReady>.NativeClassPtr, "TurnNumber");
			PBMTurnReady.NativeFieldInfoPtr_GameName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PBMTurnReady>.NativeClassPtr, "GameName");
			PBMTurnReady.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PBMTurnReady>.NativeClassPtr, 100663373);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00009B88 File Offset: 0x00007D88
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PBMTurnReady()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PBMTurnReady>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PBMTurnReady.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00002F8D File Offset: 0x0000118D
		public PBMTurnReady(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000173 RID: 371 RVA: 0x00009BC4 File Offset: 0x00007DC4
		// (set) Token: 0x06000174 RID: 372 RVA: 0x00002F96 File Offset: 0x00001196
		public unsafe GameID GameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PBMTurnReady.NativeFieldInfoPtr_GameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PBMTurnReady.NativeFieldInfoPtr_GameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000175 RID: 373 RVA: 0x00009BF4 File Offset: 0x00007DF4
		// (set) Token: 0x06000176 RID: 374 RVA: 0x00002FB5 File Offset: 0x000011B5
		public unsafe Il2CppReferenceArray<AccountIDUsernameMetadata> playerSlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PBMTurnReady.NativeFieldInfoPtr_playerSlots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AccountIDUsernameMetadata>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PBMTurnReady.NativeFieldInfoPtr_playerSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00009C24 File Offset: 0x00007E24
		// (set) Token: 0x06000178 RID: 376 RVA: 0x00002FD4 File Offset: 0x000011D4
		public unsafe Dictionary<string, string> GameOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PBMTurnReady.NativeFieldInfoPtr_GameOptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PBMTurnReady.NativeFieldInfoPtr_GameOptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000179 RID: 377 RVA: 0x00009C54 File Offset: 0x00007E54
		// (set) Token: 0x0600017A RID: 378 RVA: 0x00002FF3 File Offset: 0x000011F3
		public unsafe int TurnNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PBMTurnReady.NativeFieldInfoPtr_TurnNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PBMTurnReady.NativeFieldInfoPtr_TurnNumber)) = value;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600017B RID: 379 RVA: 0x00009C7C File Offset: 0x00007E7C
		// (set) Token: 0x0600017C RID: 380 RVA: 0x0000300E File Offset: 0x0000120E
		public unsafe string GameName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PBMTurnReady.NativeFieldInfoPtr_GameName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PBMTurnReady.NativeFieldInfoPtr_GameName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeFieldInfoPtr_GameID;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeFieldInfoPtr_playerSlots;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeFieldInfoPtr_GameOptions;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeFieldInfoPtr_TurnNumber;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeFieldInfoPtr_GameName;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
