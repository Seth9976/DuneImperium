using System;
using dwd.core.data.composition;
using dwd.core.platform.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dbgclient.data
{
	// Token: 0x020000CE RID: 206
	public class FriendObserveGameData : DataComponent
	{
		// Token: 0x060008C1 RID: 2241 RVA: 0x00039020 File Offset: 0x00037220
		// Note: this type is marked as 'beforefieldinit'.
		static FriendObserveGameData()
		{
			Il2CppClassPointerStore<FriendObserveGameData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.data", "FriendObserveGameData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendObserveGameData>.NativeClassPtr);
			FriendObserveGameData.NativeFieldInfoPtr__InGame_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendObserveGameData>.NativeClassPtr, "<InGame>k__BackingField");
			FriendObserveGameData.NativeFieldInfoPtr__ObserversAllowed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendObserveGameData>.NativeClassPtr, "<ObserversAllowed>k__BackingField");
			FriendObserveGameData.NativeFieldInfoPtr__GameSession_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendObserveGameData>.NativeClassPtr, "<GameSession>k__BackingField");
			FriendObserveGameData.NativeMethodInfoPtr_get_InGame_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendObserveGameData>.NativeClassPtr, 100664564);
			FriendObserveGameData.NativeMethodInfoPtr_get_ObserversAllowed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendObserveGameData>.NativeClassPtr, 100664565);
			FriendObserveGameData.NativeMethodInfoPtr_get_GameSession_Public_get_ObserverGameSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendObserveGameData>.NativeClassPtr, 100664566);
			FriendObserveGameData.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_ObserverGameSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendObserveGameData>.NativeClassPtr, 100664567);
			FriendObserveGameData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendObserveGameData>.NativeClassPtr, 100664568);
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x060008C2 RID: 2242 RVA: 0x000390F0 File Offset: 0x000372F0
		public unsafe bool InGame
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendObserveGameData.NativeMethodInfoPtr_get_InGame_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x060008C3 RID: 2243 RVA: 0x0003912C File Offset: 0x0003732C
		public unsafe bool ObserversAllowed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendObserveGameData.NativeMethodInfoPtr_get_ObserversAllowed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x060008C4 RID: 2244 RVA: 0x00039168 File Offset: 0x00037368
		public unsafe ObserverGameSession GameSession
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendObserveGameData.NativeMethodInfoPtr_get_GameSession_Public_get_ObserverGameSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObserverGameSession>(intPtr3) : null;
			}
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x000391A8 File Offset: 0x000373A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 504857, RefRangeEnd = 504858, XrefRangeStart = 504855, XrefRangeEnd = 504857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FriendObserveGameData(bool inGame, bool observersAllowed, ObserverGameSession gameSession)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendObserveGameData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inGame;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref observersAllowed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameSession);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendObserveGameData.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_ObserverGameSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x00039210 File Offset: 0x00037410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504858, XrefRangeEnd = 504875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendObserveGameData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x000061AB File Offset: 0x000043AB
		public FriendObserveGameData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x060008C8 RID: 2248 RVA: 0x00039254 File Offset: 0x00037454
		// (set) Token: 0x060008C9 RID: 2249 RVA: 0x000061B4 File Offset: 0x000043B4
		public unsafe bool _InGame_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendObserveGameData.NativeFieldInfoPtr__InGame_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendObserveGameData.NativeFieldInfoPtr__InGame_k__BackingField)) = value;
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x0003927C File Offset: 0x0003747C
		// (set) Token: 0x060008CB RID: 2251 RVA: 0x000061CF File Offset: 0x000043CF
		public unsafe bool _ObserversAllowed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendObserveGameData.NativeFieldInfoPtr__ObserversAllowed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendObserveGameData.NativeFieldInfoPtr__ObserversAllowed_k__BackingField)) = value;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x060008CC RID: 2252 RVA: 0x000392A4 File Offset: 0x000374A4
		// (set) Token: 0x060008CD RID: 2253 RVA: 0x000061EA File Offset: 0x000043EA
		public unsafe ObserverGameSession _GameSession_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendObserveGameData.NativeFieldInfoPtr__GameSession_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObserverGameSession>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendObserveGameData.NativeFieldInfoPtr__GameSession_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000558 RID: 1368
		private static readonly IntPtr NativeFieldInfoPtr__InGame_k__BackingField;

		// Token: 0x04000559 RID: 1369
		private static readonly IntPtr NativeFieldInfoPtr__ObserversAllowed_k__BackingField;

		// Token: 0x0400055A RID: 1370
		private static readonly IntPtr NativeFieldInfoPtr__GameSession_k__BackingField;

		// Token: 0x0400055B RID: 1371
		private static readonly IntPtr NativeMethodInfoPtr_get_InGame_Public_get_Boolean_0;

		// Token: 0x0400055C RID: 1372
		private static readonly IntPtr NativeMethodInfoPtr_get_ObserversAllowed_Public_get_Boolean_0;

		// Token: 0x0400055D RID: 1373
		private static readonly IntPtr NativeMethodInfoPtr_get_GameSession_Public_get_ObserverGameSession_0;

		// Token: 0x0400055E RID: 1374
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_ObserverGameSession_0;

		// Token: 0x0400055F RID: 1375
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
