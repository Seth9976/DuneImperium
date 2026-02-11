using System;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.menus.prompts
{
	// Token: 0x020001C4 RID: 452
	public class AccountActionsPromptBehaviour : PromptBehaviour<AccountActionsPrompt>
	{
		// Token: 0x0600144E RID: 5198 RVA: 0x0005F1DC File Offset: 0x0005D3DC
		// Note: this type is marked as 'beforefieldinit'.
		static AccountActionsPromptBehaviour()
		{
			Il2CppClassPointerStore<AccountActionsPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "AccountActionsPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AccountActionsPromptBehaviour>.NativeClassPtr);
			AccountActionsPromptBehaviour.NativeFieldInfoPtr_activeWhenGuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountActionsPromptBehaviour>.NativeClassPtr, "activeWhenGuest");
			AccountActionsPromptBehaviour.NativeFieldInfoPtr_activeWhenNotGuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountActionsPromptBehaviour>.NativeClassPtr, "activeWhenNotGuest");
			AccountActionsPromptBehaviour.NativeFieldInfoPtr_activeWhenLinked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountActionsPromptBehaviour>.NativeClassPtr, "activeWhenLinked");
			AccountActionsPromptBehaviour.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountActionsPromptBehaviour>.NativeClassPtr, 100666268);
			AccountActionsPromptBehaviour.NativeMethodInfoPtr_Event_ChangeAccount_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountActionsPromptBehaviour>.NativeClassPtr, 100666269);
			AccountActionsPromptBehaviour.NativeMethodInfoPtr_Event_ChangePassword_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountActionsPromptBehaviour>.NativeClassPtr, 100666270);
			AccountActionsPromptBehaviour.NativeMethodInfoPtr_Event_Logout_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountActionsPromptBehaviour>.NativeClassPtr, 100666271);
			AccountActionsPromptBehaviour.NativeMethodInfoPtr_Event_Dismiss_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountActionsPromptBehaviour>.NativeClassPtr, 100666272);
			AccountActionsPromptBehaviour.NativeMethodInfoPtr_Event_DeleteAccount_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountActionsPromptBehaviour>.NativeClassPtr, 100666273);
			AccountActionsPromptBehaviour.NativeMethodInfoPtr_Event_LinkAccounts_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountActionsPromptBehaviour>.NativeClassPtr, 100666274);
			AccountActionsPromptBehaviour.NativeMethodInfoPtr_Event_UnlinkAccounts_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountActionsPromptBehaviour>.NativeClassPtr, 100666275);
			AccountActionsPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountActionsPromptBehaviour>.NativeClassPtr, 100666276);
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x0005F2FC File Offset: 0x0005D4FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520231, XrefRangeEnd = 520293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountActionsPromptBehaviour.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x0005F330 File Offset: 0x0005D530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520293, XrefRangeEnd = 520296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ChangeAccount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountActionsPromptBehaviour.NativeMethodInfoPtr_Event_ChangeAccount_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001451 RID: 5201 RVA: 0x0005F364 File Offset: 0x0005D564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520296, XrefRangeEnd = 520299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ChangePassword()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountActionsPromptBehaviour.NativeMethodInfoPtr_Event_ChangePassword_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x0005F398 File Offset: 0x0005D598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520299, XrefRangeEnd = 520302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Logout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountActionsPromptBehaviour.NativeMethodInfoPtr_Event_Logout_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x0005F3CC File Offset: 0x0005D5CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520302, XrefRangeEnd = 520305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Dismiss()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountActionsPromptBehaviour.NativeMethodInfoPtr_Event_Dismiss_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x0005F400 File Offset: 0x0005D600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520305, XrefRangeEnd = 520308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_DeleteAccount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountActionsPromptBehaviour.NativeMethodInfoPtr_Event_DeleteAccount_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x0005F434 File Offset: 0x0005D634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520308, XrefRangeEnd = 520311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_LinkAccounts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountActionsPromptBehaviour.NativeMethodInfoPtr_Event_LinkAccounts_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x0005F468 File Offset: 0x0005D668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520311, XrefRangeEnd = 520314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_UnlinkAccounts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountActionsPromptBehaviour.NativeMethodInfoPtr_Event_UnlinkAccounts_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x0005F49C File Offset: 0x0005D69C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520314, XrefRangeEnd = 520327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AccountActionsPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AccountActionsPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountActionsPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x0000B8D9 File Offset: 0x00009AD9
		public AccountActionsPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06001459 RID: 5209 RVA: 0x0005F4D8 File Offset: 0x0005D6D8
		// (set) Token: 0x0600145A RID: 5210 RVA: 0x0000B8E2 File Offset: 0x00009AE2
		public unsafe Il2CppReferenceArray<GameObject> activeWhenGuest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountActionsPromptBehaviour.NativeFieldInfoPtr_activeWhenGuest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountActionsPromptBehaviour.NativeFieldInfoPtr_activeWhenGuest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x0600145B RID: 5211 RVA: 0x0005F508 File Offset: 0x0005D708
		// (set) Token: 0x0600145C RID: 5212 RVA: 0x0000B901 File Offset: 0x00009B01
		public unsafe Il2CppReferenceArray<GameObject> activeWhenNotGuest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountActionsPromptBehaviour.NativeFieldInfoPtr_activeWhenNotGuest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountActionsPromptBehaviour.NativeFieldInfoPtr_activeWhenNotGuest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x0600145D RID: 5213 RVA: 0x0005F538 File Offset: 0x0005D738
		// (set) Token: 0x0600145E RID: 5214 RVA: 0x0000B920 File Offset: 0x00009B20
		public unsafe Il2CppReferenceArray<GameObject> activeWhenLinked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountActionsPromptBehaviour.NativeFieldInfoPtr_activeWhenLinked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountActionsPromptBehaviour.NativeFieldInfoPtr_activeWhenLinked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C8B RID: 3211
		private static readonly IntPtr NativeFieldInfoPtr_activeWhenGuest;

		// Token: 0x04000C8C RID: 3212
		private static readonly IntPtr NativeFieldInfoPtr_activeWhenNotGuest;

		// Token: 0x04000C8D RID: 3213
		private static readonly IntPtr NativeFieldInfoPtr_activeWhenLinked;

		// Token: 0x04000C8E RID: 3214
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000C8F RID: 3215
		private static readonly IntPtr NativeMethodInfoPtr_Event_ChangeAccount_Public_Void_0;

		// Token: 0x04000C90 RID: 3216
		private static readonly IntPtr NativeMethodInfoPtr_Event_ChangePassword_Public_Void_0;

		// Token: 0x04000C91 RID: 3217
		private static readonly IntPtr NativeMethodInfoPtr_Event_Logout_Public_Void_0;

		// Token: 0x04000C92 RID: 3218
		private static readonly IntPtr NativeMethodInfoPtr_Event_Dismiss_Public_Void_0;

		// Token: 0x04000C93 RID: 3219
		private static readonly IntPtr NativeMethodInfoPtr_Event_DeleteAccount_Public_Void_0;

		// Token: 0x04000C94 RID: 3220
		private static readonly IntPtr NativeMethodInfoPtr_Event_LinkAccounts_Public_Void_0;

		// Token: 0x04000C95 RID: 3221
		private static readonly IntPtr NativeMethodInfoPtr_Event_UnlinkAccounts_Public_Void_0;

		// Token: 0x04000C96 RID: 3222
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
