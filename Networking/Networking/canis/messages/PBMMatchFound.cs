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
	// Token: 0x0200002A RID: 42
	public class PBMMatchFound : NetworkMessageEvent
	{
		// Token: 0x0600015B RID: 347 RVA: 0x000097BC File Offset: 0x000079BC
		// Note: this type is marked as 'beforefieldinit'.
		static PBMMatchFound()
		{
			Il2CppClassPointerStore<PBMMatchFound>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages", "PBMMatchFound");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PBMMatchFound>.NativeClassPtr);
			PBMMatchFound.NativeFieldInfoPtr_GameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PBMMatchFound>.NativeClassPtr, "GameID");
			PBMMatchFound.NativeFieldInfoPtr_playerSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PBMMatchFound>.NativeClassPtr, "playerSlots");
			PBMMatchFound.NativeFieldInfoPtr_GameOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PBMMatchFound>.NativeClassPtr, "GameOptions");
			PBMMatchFound.NativeFieldInfoPtr_GameName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PBMMatchFound>.NativeClassPtr, "GameName");
			PBMMatchFound.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PBMMatchFound>.NativeClassPtr, 100663367);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00009850 File Offset: 0x00007A50
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PBMMatchFound()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PBMMatchFound>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PBMMatchFound.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00002EA2 File Offset: 0x000010A2
		public PBMMatchFound(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600015E RID: 350 RVA: 0x0000988C File Offset: 0x00007A8C
		// (set) Token: 0x0600015F RID: 351 RVA: 0x00002EAB File Offset: 0x000010AB
		public unsafe GameID GameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PBMMatchFound.NativeFieldInfoPtr_GameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PBMMatchFound.NativeFieldInfoPtr_GameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000160 RID: 352 RVA: 0x000098BC File Offset: 0x00007ABC
		// (set) Token: 0x06000161 RID: 353 RVA: 0x00002ECA File Offset: 0x000010CA
		public unsafe Il2CppReferenceArray<AccountIDUsernameMetadata> playerSlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PBMMatchFound.NativeFieldInfoPtr_playerSlots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AccountIDUsernameMetadata>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PBMMatchFound.NativeFieldInfoPtr_playerSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000162 RID: 354 RVA: 0x000098EC File Offset: 0x00007AEC
		// (set) Token: 0x06000163 RID: 355 RVA: 0x00002EE9 File Offset: 0x000010E9
		public unsafe Dictionary<string, string> GameOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PBMMatchFound.NativeFieldInfoPtr_GameOptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PBMMatchFound.NativeFieldInfoPtr_GameOptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000164 RID: 356 RVA: 0x0000991C File Offset: 0x00007B1C
		// (set) Token: 0x06000165 RID: 357 RVA: 0x00002F08 File Offset: 0x00001108
		public unsafe string GameName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PBMMatchFound.NativeFieldInfoPtr_GameName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PBMMatchFound.NativeFieldInfoPtr_GameName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeFieldInfoPtr_GameID;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeFieldInfoPtr_playerSlots;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeFieldInfoPtr_GameOptions;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeFieldInfoPtr_GameName;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
