using System;
using boardgames.match.behaviours;
using Canis;
using Canis.boardgames;
using Canis.utils.ids;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using lotus;

namespace boardgames.match.canis
{
	// Token: 0x0200027C RID: 636
	public class DBGCanisOfflineMatch : CanisMatch
	{
		// Token: 0x06001DDA RID: 7642 RVA: 0x000810B8 File Offset: 0x0007F2B8
		// Note: this type is marked as 'beforefieldinit'.
		static DBGCanisOfflineMatch()
		{
			Il2CppClassPointerStore<DBGCanisOfflineMatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.canis", "DBGCanisOfflineMatch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGCanisOfflineMatch>.NativeClassPtr);
			DBGCanisOfflineMatch.NativeFieldInfoPtr_staticSaveAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGCanisOfflineMatch>.NativeClassPtr, "staticSaveAnimator");
			DBGCanisOfflineMatch.NativeFieldInfoPtr_matchHub = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGCanisOfflineMatch>.NativeClassPtr, "matchHub");
			DBGCanisOfflineMatch.NativeFieldInfoPtr_metaProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGCanisOfflineMatch>.NativeClassPtr, "metaProvider");
			DBGCanisOfflineMatch.NativeFieldInfoPtr_saveRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGCanisOfflineMatch>.NativeClassPtr, "saveRequested");
			DBGCanisOfflineMatch.NativeMethodInfoPtr_Configure_Public_Void_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCanisOfflineMatch>.NativeClassPtr, 100668194);
			DBGCanisOfflineMatch.NativeMethodInfoPtr_configure_Protected_Abstract_Virtual_New_Void_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCanisOfflineMatch>.NativeClassPtr, 100668195);
			DBGCanisOfflineMatch.NativeMethodInfoPtr_getLocalPlayerAccountId_Protected_Virtual_New_AccountID_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCanisOfflineMatch>.NativeClassPtr, 100668196);
			DBGCanisOfflineMatch.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCanisOfflineMatch>.NativeClassPtr, 100668197);
			DBGCanisOfflineMatch.NativeMethodInfoPtr_SaveGame_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCanisOfflineMatch>.NativeClassPtr, 100668198);
			DBGCanisOfflineMatch.NativeMethodInfoPtr_DeleteSaveGame_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCanisOfflineMatch>.NativeClassPtr, 100668199);
			DBGCanisOfflineMatch.NativeMethodInfoPtr_SetupCheats_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCanisOfflineMatch>.NativeClassPtr, 100668200);
			DBGCanisOfflineMatch.NativeMethodInfoPtr_shouldSave_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCanisOfflineMatch>.NativeClassPtr, 100668201);
			DBGCanisOfflineMatch.NativeMethodInfoPtr_WithSaveSpinner_Private_IEnumerator_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCanisOfflineMatch>.NativeClassPtr, 100668202);
			DBGCanisOfflineMatch.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCanisOfflineMatch>.NativeClassPtr, 100668203);
			DBGCanisOfflineMatch.NativeMethodInfoPtr__WithSaveSpinner_b__12_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCanisOfflineMatch>.NativeClassPtr, 100668204);
		}

		// Token: 0x06001DDB RID: 7643 RVA: 0x00081214 File Offset: 0x0007F414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537826, XrefRangeEnd = 537830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Configure(MatchInitData mid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGCanisOfflineMatch.NativeMethodInfoPtr_Configure_Public_Void_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DDC RID: 7644 RVA: 0x00081258 File Offset: 0x0007F458
		[CallerCount(0)]
		public unsafe virtual void configure(MatchInitData mid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGCanisOfflineMatch.NativeMethodInfoPtr_configure_Protected_Abstract_Virtual_New_Void_MatchInitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DDD RID: 7645 RVA: 0x000812A8 File Offset: 0x0007F4A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537830, XrefRangeEnd = 537831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AccountID getLocalPlayerAccountId(MatchInitData mid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGCanisOfflineMatch.NativeMethodInfoPtr_getLocalPlayerAccountId_Protected_Virtual_New_AccountID_MatchInitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
			}
		}

		// Token: 0x06001DDE RID: 7646 RVA: 0x00081304 File Offset: 0x0007F504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537831, XrefRangeEnd = 537850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGCanisOfflineMatch.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DDF RID: 7647 RVA: 0x00081340 File Offset: 0x0007F540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537850, XrefRangeEnd = 537851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SaveGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGCanisOfflineMatch.NativeMethodInfoPtr_SaveGame_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DE0 RID: 7648 RVA: 0x0008137C File Offset: 0x0007F57C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537851, XrefRangeEnd = 537869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DeleteSaveGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGCanisOfflineMatch.NativeMethodInfoPtr_DeleteSaveGame_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DE1 RID: 7649 RVA: 0x000813B8 File Offset: 0x0007F5B8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetupCheats()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGCanisOfflineMatch.NativeMethodInfoPtr_SetupCheats_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DE2 RID: 7650 RVA: 0x000813F4 File Offset: 0x0007F5F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 537874, RefRangeEnd = 537876, XrefRangeStart = 537869, XrefRangeEnd = 537874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool shouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGCanisOfflineMatch.NativeMethodInfoPtr_shouldSave_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DE3 RID: 7651 RVA: 0x00081430 File Offset: 0x0007F630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537876, XrefRangeEnd = 537899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator WithSaveSpinner(IEnumerator save)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(save);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGCanisOfflineMatch.NativeMethodInfoPtr_WithSaveSpinner_Private_IEnumerator_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001DE4 RID: 7652 RVA: 0x00081480 File Offset: 0x0007F680
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 537900, RefRangeEnd = 537901, XrefRangeStart = 537899, XrefRangeEnd = 537900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGCanisOfflineMatch()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGCanisOfflineMatch>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGCanisOfflineMatch.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DE5 RID: 7653 RVA: 0x000814BC File Offset: 0x0007F6BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537901, XrefRangeEnd = 537906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _WithSaveSpinner_b__12_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGCanisOfflineMatch.NativeMethodInfoPtr__WithSaveSpinner_b__12_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DE6 RID: 7654 RVA: 0x0000FC9A File Offset: 0x0000DE9A
		public DBGCanisOfflineMatch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x06001DE7 RID: 7655 RVA: 0x000814F0 File Offset: 0x0007F6F0
		// (set) Token: 0x06001DE8 RID: 7656 RVA: 0x0000FCA3 File Offset: 0x0000DEA3
		public unsafe PromptAnims staticSaveAnimator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGCanisOfflineMatch.NativeFieldInfoPtr_staticSaveAnimator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PromptAnims>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGCanisOfflineMatch.NativeFieldInfoPtr_staticSaveAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06001DE9 RID: 7657 RVA: 0x00081520 File Offset: 0x0007F720
		// (set) Token: 0x06001DEA RID: 7658 RVA: 0x0000FCC2 File Offset: 0x0000DEC2
		public unsafe DBGMatchHub matchHub
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGCanisOfflineMatch.NativeFieldInfoPtr_matchHub);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGMatchHub>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGCanisOfflineMatch.NativeFieldInfoPtr_matchHub), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x06001DEB RID: 7659 RVA: 0x00081550 File Offset: 0x0007F750
		// (set) Token: 0x06001DEC RID: 7660 RVA: 0x0000FCE1 File Offset: 0x0000DEE1
		public unsafe SaveMetaDataProvider metaProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGCanisOfflineMatch.NativeFieldInfoPtr_metaProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveMetaDataProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGCanisOfflineMatch.NativeFieldInfoPtr_metaProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x06001DED RID: 7661 RVA: 0x00081580 File Offset: 0x0007F780
		// (set) Token: 0x06001DEE RID: 7662 RVA: 0x0000FD00 File Offset: 0x0000DF00
		public unsafe bool saveRequested
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGCanisOfflineMatch.NativeFieldInfoPtr_saveRequested);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGCanisOfflineMatch.NativeFieldInfoPtr_saveRequested)) = value;
			}
		}

		// Token: 0x040012DC RID: 4828
		private static readonly IntPtr NativeFieldInfoPtr_staticSaveAnimator;

		// Token: 0x040012DD RID: 4829
		private static readonly IntPtr NativeFieldInfoPtr_matchHub;

		// Token: 0x040012DE RID: 4830
		private static readonly IntPtr NativeFieldInfoPtr_metaProvider;

		// Token: 0x040012DF RID: 4831
		private static readonly IntPtr NativeFieldInfoPtr_saveRequested;

		// Token: 0x040012E0 RID: 4832
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Void_MatchInitData_0;

		// Token: 0x040012E1 RID: 4833
		private static readonly IntPtr NativeMethodInfoPtr_configure_Protected_Abstract_Virtual_New_Void_MatchInitData_0;

		// Token: 0x040012E2 RID: 4834
		private static readonly IntPtr NativeMethodInfoPtr_getLocalPlayerAccountId_Protected_Virtual_New_AccountID_MatchInitData_0;

		// Token: 0x040012E3 RID: 4835
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x040012E4 RID: 4836
		private static readonly IntPtr NativeMethodInfoPtr_SaveGame_Public_Virtual_Void_0;

		// Token: 0x040012E5 RID: 4837
		private static readonly IntPtr NativeMethodInfoPtr_DeleteSaveGame_Public_Virtual_Void_0;

		// Token: 0x040012E6 RID: 4838
		private static readonly IntPtr NativeMethodInfoPtr_SetupCheats_Protected_Virtual_New_Void_0;

		// Token: 0x040012E7 RID: 4839
		private static readonly IntPtr NativeMethodInfoPtr_shouldSave_Private_Boolean_0;

		// Token: 0x040012E8 RID: 4840
		private static readonly IntPtr NativeMethodInfoPtr_WithSaveSpinner_Private_IEnumerator_IEnumerator_0;

		// Token: 0x040012E9 RID: 4841
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040012EA RID: 4842
		private static readonly IntPtr NativeMethodInfoPtr__WithSaveSpinner_b__12_0_Private_Void_0;
	}
}
