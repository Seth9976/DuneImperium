using System;
using Canis.json.events;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.messages
{
	// Token: 0x02000028 RID: 40
	public class PBMGameEnded : NetworkMessageEvent
	{
		// Token: 0x0600014B RID: 331 RVA: 0x00009508 File Offset: 0x00007708
		// Note: this type is marked as 'beforefieldinit'.
		static PBMGameEnded()
		{
			Il2CppClassPointerStore<PBMGameEnded>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages", "PBMGameEnded");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PBMGameEnded>.NativeClassPtr);
			PBMGameEnded.NativeFieldInfoPtr_GameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PBMGameEnded>.NativeClassPtr, "GameID");
			PBMGameEnded.NativeFieldInfoPtr_Players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PBMGameEnded>.NativeClassPtr, "Players");
			PBMGameEnded.NativeMethodInfoPtr_GetGameID_Public_Virtual_Final_New_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PBMGameEnded>.NativeClassPtr, 100663363);
			PBMGameEnded.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PBMGameEnded>.NativeClassPtr, 100663364);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00009588 File Offset: 0x00007788
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual GameID GetGameID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PBMGameEnded.NativeMethodInfoPtr_GetGameID_Public_Virtual_Final_New_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr3) : null;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x000095C8 File Offset: 0x000077C8
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PBMGameEnded()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PBMGameEnded>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PBMGameEnded.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002E14 File Offset: 0x00001014
		public PBMGameEnded(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600014F RID: 335 RVA: 0x00009604 File Offset: 0x00007804
		// (set) Token: 0x06000150 RID: 336 RVA: 0x00002E1D File Offset: 0x0000101D
		public unsafe GameID GameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PBMGameEnded.NativeFieldInfoPtr_GameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PBMGameEnded.NativeFieldInfoPtr_GameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000151 RID: 337 RVA: 0x00009634 File Offset: 0x00007834
		// (set) Token: 0x06000152 RID: 338 RVA: 0x00002E3C File Offset: 0x0000103C
		public unsafe Il2CppReferenceArray<AccountIDUsername> Players
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PBMGameEnded.NativeFieldInfoPtr_Players);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AccountIDUsername>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PBMGameEnded.NativeFieldInfoPtr_Players), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeFieldInfoPtr_GameID;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeFieldInfoPtr_Players;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_GetGameID_Public_Virtual_Final_New_GameID_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
