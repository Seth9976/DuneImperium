using System;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.match.messages
{
	// Token: 0x02000162 RID: 354
	public class GameEnded : GameMessage
	{
		// Token: 0x060014C0 RID: 5312 RVA: 0x000675E4 File Offset: 0x000657E4
		// Note: this type is marked as 'beforefieldinit'.
		static GameEnded()
		{
			Il2CppClassPointerStore<GameEnded>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.messages", "GameEnded");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameEnded>.NativeClassPtr);
			GameEnded.NativeFieldInfoPtr_WinnerList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameEnded>.NativeClassPtr, "WinnerList");
			GameEnded.NativeFieldInfoPtr_LoserMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameEnded>.NativeClassPtr, "LoserMap");
			GameEnded.NativeFieldInfoPtr_Draw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameEnded>.NativeClassPtr, "Draw");
			GameEnded.NativeMethodInfoPtr_DidPlayerWin_Public_Boolean_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEnded>.NativeClassPtr, 100666424);
			GameEnded.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEnded>.NativeClassPtr, 100666425);
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x00067678 File Offset: 0x00065878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875083, XrefRangeEnd = 875088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DidPlayerWin(AccountID playerAccountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerAccountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameEnded.NativeMethodInfoPtr_DidPlayerWin_Public_Boolean_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x000676C8 File Offset: 0x000658C8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 542958, RefRangeEnd = 542962, XrefRangeStart = 542958, XrefRangeEnd = 542962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameEnded()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameEnded>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameEnded.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x000092AB File Offset: 0x000074AB
		public GameEnded(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x060014C4 RID: 5316 RVA: 0x00067704 File Offset: 0x00065904
		// (set) Token: 0x060014C5 RID: 5317 RVA: 0x000092B4 File Offset: 0x000074B4
		public unsafe IList<AccountID> WinnerList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameEnded.NativeFieldInfoPtr_WinnerList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<AccountID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameEnded.NativeFieldInfoPtr_WinnerList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x060014C6 RID: 5318 RVA: 0x00067734 File Offset: 0x00065934
		// (set) Token: 0x060014C7 RID: 5319 RVA: 0x000092D3 File Offset: 0x000074D3
		public unsafe Dictionary<AccountID, string> LoserMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameEnded.NativeFieldInfoPtr_LoserMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AccountID, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameEnded.NativeFieldInfoPtr_LoserMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x060014C8 RID: 5320 RVA: 0x00067764 File Offset: 0x00065964
		// (set) Token: 0x060014C9 RID: 5321 RVA: 0x000092F2 File Offset: 0x000074F2
		public unsafe bool Draw
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameEnded.NativeFieldInfoPtr_Draw);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameEnded.NativeFieldInfoPtr_Draw)) = value;
			}
		}

		// Token: 0x04000ED8 RID: 3800
		private static readonly IntPtr NativeFieldInfoPtr_WinnerList;

		// Token: 0x04000ED9 RID: 3801
		private static readonly IntPtr NativeFieldInfoPtr_LoserMap;

		// Token: 0x04000EDA RID: 3802
		private static readonly IntPtr NativeFieldInfoPtr_Draw;

		// Token: 0x04000EDB RID: 3803
		private static readonly IntPtr NativeMethodInfoPtr_DidPlayerWin_Public_Boolean_AccountID_0;

		// Token: 0x04000EDC RID: 3804
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
