using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Networking.service;
using UnityEngine;

namespace boardgames.ui
{
	// Token: 0x02000124 RID: 292
	public class PlayerOnlineStatusMonitor : MonoBehaviour
	{
		// Token: 0x06000F08 RID: 3848 RVA: 0x0003EAFC File Offset: 0x0003CCFC
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerOnlineStatusMonitor()
		{
			Il2CppClassPointerStore<PlayerOnlineStatusMonitor>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.ui", "PlayerOnlineStatusMonitor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerOnlineStatusMonitor>.NativeClassPtr);
			PlayerOnlineStatusMonitor.NativeFieldInfoPtr_OnStatusChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerOnlineStatusMonitor>.NativeClassPtr, "OnStatusChanged");
			PlayerOnlineStatusMonitor.NativeFieldInfoPtr_playerStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerOnlineStatusMonitor>.NativeClassPtr, "playerStatus");
			PlayerOnlineStatusMonitor.NativeMethodInfoPtr_add_OnStatusChanged_Public_add_Void_Action_2_AccountID_Status_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerOnlineStatusMonitor>.NativeClassPtr, 100665432);
			PlayerOnlineStatusMonitor.NativeMethodInfoPtr_remove_OnStatusChanged_Public_rem_Void_Action_2_AccountID_Status_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerOnlineStatusMonitor>.NativeClassPtr, 100665433);
			PlayerOnlineStatusMonitor.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerOnlineStatusMonitor>.NativeClassPtr, 100665434);
			PlayerOnlineStatusMonitor.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerOnlineStatusMonitor>.NativeClassPtr, 100665435);
			PlayerOnlineStatusMonitor.NativeMethodInfoPtr_GetStatus_Public_Status_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerOnlineStatusMonitor>.NativeClassPtr, 100665436);
			PlayerOnlineStatusMonitor.NativeMethodInfoPtr_Subscribe_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerOnlineStatusMonitor>.NativeClassPtr, 100665437);
			PlayerOnlineStatusMonitor.NativeMethodInfoPtr_Unsubscribe_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerOnlineStatusMonitor>.NativeClassPtr, 100665438);
			PlayerOnlineStatusMonitor.NativeMethodInfoPtr_OnGameSessionJoined_Private_Void_GameSessionJoined_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerOnlineStatusMonitor>.NativeClassPtr, 100665439);
			PlayerOnlineStatusMonitor.NativeMethodInfoPtr_OnGameSessionLeft_Private_Void_GameSessionLeft_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerOnlineStatusMonitor>.NativeClassPtr, 100665440);
			PlayerOnlineStatusMonitor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerOnlineStatusMonitor>.NativeClassPtr, 100665441);
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x0003EC1C File Offset: 0x0003CE1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 996983, RefRangeEnd = 996985, XrefRangeStart = 996978, XrefRangeEnd = 996983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnStatusChanged(Action<AccountID, PlayerOnlineStatusMonitor.Status> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerOnlineStatusMonitor.NativeMethodInfoPtr_add_OnStatusChanged_Public_add_Void_Action_2_AccountID_Status_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x0003EC60 File Offset: 0x0003CE60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 996990, RefRangeEnd = 996992, XrefRangeStart = 996985, XrefRangeEnd = 996990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnStatusChanged(Action<AccountID, PlayerOnlineStatusMonitor.Status> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerOnlineStatusMonitor.NativeMethodInfoPtr_remove_OnStatusChanged_Public_rem_Void_Action_2_AccountID_Status_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x0003ECA4 File Offset: 0x0003CEA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996992, XrefRangeEnd = 997013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerOnlineStatusMonitor.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x0003ECD8 File Offset: 0x0003CED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997013, XrefRangeEnd = 997034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerOnlineStatusMonitor.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x0003ED0C File Offset: 0x0003CF0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 997041, RefRangeEnd = 997042, XrefRangeStart = 997034, XrefRangeEnd = 997041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerOnlineStatusMonitor.Status GetStatus(AccountID id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerOnlineStatusMonitor.NativeMethodInfoPtr_GetStatus_Public_Status_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x0003ED5C File Offset: 0x0003CF5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Subscribe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerOnlineStatusMonitor.NativeMethodInfoPtr_Subscribe_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x0003ED90 File Offset: 0x0003CF90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unsubscribe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerOnlineStatusMonitor.NativeMethodInfoPtr_Unsubscribe_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x0003EDC4 File Offset: 0x0003CFC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997042, XrefRangeEnd = 997046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGameSessionJoined(GameSessionJoined joinedMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(joinedMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerOnlineStatusMonitor.NativeMethodInfoPtr_OnGameSessionJoined_Private_Void_GameSessionJoined_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x0003EE08 File Offset: 0x0003D008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997046, XrefRangeEnd = 997050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGameSessionLeft(GameSessionLeft leftMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(leftMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerOnlineStatusMonitor.NativeMethodInfoPtr_OnGameSessionLeft_Private_Void_GameSessionLeft_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x0003EE4C File Offset: 0x0003D04C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997050, XrefRangeEnd = 997075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerOnlineStatusMonitor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerOnlineStatusMonitor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerOnlineStatusMonitor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x00009082 File Offset: 0x00007282
		public PlayerOnlineStatusMonitor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06000F14 RID: 3860 RVA: 0x0003EE88 File Offset: 0x0003D088
		// (set) Token: 0x06000F15 RID: 3861 RVA: 0x0000908B File Offset: 0x0000728B
		public unsafe Action<AccountID, PlayerOnlineStatusMonitor.Status> OnStatusChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerOnlineStatusMonitor.NativeFieldInfoPtr_OnStatusChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AccountID, PlayerOnlineStatusMonitor.Status>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerOnlineStatusMonitor.NativeFieldInfoPtr_OnStatusChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06000F16 RID: 3862 RVA: 0x0003EEB8 File Offset: 0x0003D0B8
		// (set) Token: 0x06000F17 RID: 3863 RVA: 0x000090AA File Offset: 0x000072AA
		public unsafe Dictionary<AccountID, PlayerOnlineStatusMonitor.Status> playerStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerOnlineStatusMonitor.NativeFieldInfoPtr_playerStatus);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AccountID, PlayerOnlineStatusMonitor.Status>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerOnlineStatusMonitor.NativeFieldInfoPtr_playerStatus), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000915 RID: 2325
		private static readonly IntPtr NativeFieldInfoPtr_OnStatusChanged;

		// Token: 0x04000916 RID: 2326
		private static readonly IntPtr NativeFieldInfoPtr_playerStatus;

		// Token: 0x04000917 RID: 2327
		private static readonly IntPtr NativeMethodInfoPtr_add_OnStatusChanged_Public_add_Void_Action_2_AccountID_Status_0;

		// Token: 0x04000918 RID: 2328
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnStatusChanged_Public_rem_Void_Action_2_AccountID_Status_0;

		// Token: 0x04000919 RID: 2329
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400091A RID: 2330
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400091B RID: 2331
		private static readonly IntPtr NativeMethodInfoPtr_GetStatus_Public_Status_AccountID_0;

		// Token: 0x0400091C RID: 2332
		private static readonly IntPtr NativeMethodInfoPtr_Subscribe_Private_Void_0;

		// Token: 0x0400091D RID: 2333
		private static readonly IntPtr NativeMethodInfoPtr_Unsubscribe_Private_Void_0;

		// Token: 0x0400091E RID: 2334
		private static readonly IntPtr NativeMethodInfoPtr_OnGameSessionJoined_Private_Void_GameSessionJoined_0;

		// Token: 0x0400091F RID: 2335
		private static readonly IntPtr NativeMethodInfoPtr_OnGameSessionLeft_Private_Void_GameSessionLeft_0;

		// Token: 0x04000920 RID: 2336
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200025C RID: 604
		public enum Status
		{
			// Token: 0x040010DF RID: 4319
			Online,
			// Token: 0x040010E0 RID: 4320
			Offline
		}

		// Token: 0x0200025D RID: 605
		[ObfuscatedName("boardgames.ui.PlayerOnlineStatusMonitor+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06001BC1 RID: 7105 RVA: 0x00066B28 File Offset: 0x00064D28
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PlayerOnlineStatusMonitor.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerOnlineStatusMonitor>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerOnlineStatusMonitor.__c>.NativeClassPtr);
				PlayerOnlineStatusMonitor.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerOnlineStatusMonitor.__c>.NativeClassPtr, "<>9");
				PlayerOnlineStatusMonitor.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerOnlineStatusMonitor.__c>.NativeClassPtr, "<>9__12_0");
				PlayerOnlineStatusMonitor.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerOnlineStatusMonitor.__c>.NativeClassPtr, 100665443);
				PlayerOnlineStatusMonitor.__c.NativeMethodInfoPtr___ctor_b__12_0_Internal_Void_AccountID_Status_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerOnlineStatusMonitor.__c>.NativeClassPtr, 100665444);
			}

			// Token: 0x06001BC2 RID: 7106 RVA: 0x00066BA4 File Offset: 0x00064DA4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerOnlineStatusMonitor.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerOnlineStatusMonitor.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BC3 RID: 7107 RVA: 0x00066BE0 File Offset: 0x00064DE0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__12_0(AccountID <p0>, PlayerOnlineStatusMonitor.Status <p1>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref <p1>;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerOnlineStatusMonitor.__c.NativeMethodInfoPtr___ctor_b__12_0_Internal_Void_AccountID_Status_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BC4 RID: 7108 RVA: 0x0000F072 File Offset: 0x0000D272
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000831 RID: 2097
			// (get) Token: 0x06001BC5 RID: 7109 RVA: 0x00066C30 File Offset: 0x00064E30
			// (set) Token: 0x06001BC6 RID: 7110 RVA: 0x0000F07B File Offset: 0x0000D27B
			public unsafe static PlayerOnlineStatusMonitor.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerOnlineStatusMonitor.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerOnlineStatusMonitor.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerOnlineStatusMonitor.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000832 RID: 2098
			// (get) Token: 0x06001BC7 RID: 7111 RVA: 0x00066C58 File Offset: 0x00064E58
			// (set) Token: 0x06001BC8 RID: 7112 RVA: 0x0000F08D File Offset: 0x0000D28D
			public unsafe static Action<AccountID, PlayerOnlineStatusMonitor.Status> __9__12_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerOnlineStatusMonitor.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AccountID, PlayerOnlineStatusMonitor.Status>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerOnlineStatusMonitor.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040010E1 RID: 4321
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040010E2 RID: 4322
			private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

			// Token: 0x040010E3 RID: 4323
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040010E4 RID: 4324
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__12_0_Internal_Void_AccountID_Status_0;
		}
	}
}
