using System;
using Canis;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace boardgames.data
{
	// Token: 0x02000181 RID: 385
	public class ChallengePlayerData : VersionedDataComponent
	{
		// Token: 0x060010DB RID: 4315 RVA: 0x00052C90 File Offset: 0x00050E90
		// Note: this type is marked as 'beforefieldinit'.
		static ChallengePlayerData()
		{
			Il2CppClassPointerStore<ChallengePlayerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.data", "ChallengePlayerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengePlayerData>.NativeClassPtr);
			ChallengePlayerData.NativeFieldInfoPtr_Players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengePlayerData>.NativeClassPtr, "Players");
			ChallengePlayerData.NativeMethodInfoPtr__ctor_Public_Void_List_1_PlayerMatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengePlayerData>.NativeClassPtr, 100665656);
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x00052CE8 File Offset: 0x00050EE8
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 504779, RefRangeEnd = 504807, XrefRangeStart = 504779, XrefRangeEnd = 504807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChallengePlayerData(List<PlayerMatchInitData> players)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengePlayerData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(players);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengePlayerData.NativeMethodInfoPtr__ctor_Public_Void_List_1_PlayerMatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x0000A217 File Offset: 0x00008417
		public ChallengePlayerData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x060010DE RID: 4318 RVA: 0x00052D34 File Offset: 0x00050F34
		// (set) Token: 0x060010DF RID: 4319 RVA: 0x0000A220 File Offset: 0x00008420
		public unsafe List<PlayerMatchInitData> Players
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengePlayerData.NativeFieldInfoPtr_Players);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayerMatchInitData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengePlayerData.NativeFieldInfoPtr_Players), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A42 RID: 2626
		private static readonly IntPtr NativeFieldInfoPtr_Players;

		// Token: 0x04000A43 RID: 2627
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_PlayerMatchInitData_0;
	}
}
