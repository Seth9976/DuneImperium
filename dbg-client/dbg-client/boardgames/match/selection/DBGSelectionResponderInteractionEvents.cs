using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.match.selection
{
	// Token: 0x0200026E RID: 622
	public class DBGSelectionResponderInteractionEvents : MonoBehaviour
	{
		// Token: 0x06001CF6 RID: 7414 RVA: 0x0007D8C8 File Offset: 0x0007BAC8
		// Note: this type is marked as 'beforefieldinit'.
		static DBGSelectionResponderInteractionEvents()
		{
			Il2CppClassPointerStore<DBGSelectionResponderInteractionEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.selection", "DBGSelectionResponderInteractionEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGSelectionResponderInteractionEvents>.NativeClassPtr);
			DBGSelectionResponderInteractionEvents.NativeFieldInfoPtr_selectionResponder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectionResponderInteractionEvents>.NativeClassPtr, "selectionResponder");
			DBGSelectionResponderInteractionEvents.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponderInteractionEvents>.NativeClassPtr, 100668054);
			DBGSelectionResponderInteractionEvents.NativeMethodInfoPtr_Event_CancelSelection_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponderInteractionEvents>.NativeClassPtr, 100668055);
			DBGSelectionResponderInteractionEvents.NativeMethodInfoPtr_Event_SkipSelection_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponderInteractionEvents>.NativeClassPtr, 100668056);
			DBGSelectionResponderInteractionEvents.NativeMethodInfoPtr_Event_ConfirmSelection_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponderInteractionEvents>.NativeClassPtr, 100668057);
			DBGSelectionResponderInteractionEvents.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponderInteractionEvents>.NativeClassPtr, 100668058);
		}

		// Token: 0x06001CF7 RID: 7415 RVA: 0x0007D970 File Offset: 0x0007BB70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536265, XrefRangeEnd = 536269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionResponderInteractionEvents.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF8 RID: 7416 RVA: 0x0007D9A4 File Offset: 0x0007BBA4
		[CallerCount(0)]
		public unsafe void Event_CancelSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionResponderInteractionEvents.NativeMethodInfoPtr_Event_CancelSelection_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF9 RID: 7417 RVA: 0x0007D9D8 File Offset: 0x0007BBD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536269, XrefRangeEnd = 536271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SkipSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionResponderInteractionEvents.NativeMethodInfoPtr_Event_SkipSelection_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CFA RID: 7418 RVA: 0x0007DA0C File Offset: 0x0007BC0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ConfirmSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionResponderInteractionEvents.NativeMethodInfoPtr_Event_ConfirmSelection_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CFB RID: 7419 RVA: 0x0007DA40 File Offset: 0x0007BC40
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGSelectionResponderInteractionEvents()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGSelectionResponderInteractionEvents>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionResponderInteractionEvents.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CFC RID: 7420 RVA: 0x0000F71A File Offset: 0x0000D91A
		public DBGSelectionResponderInteractionEvents(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06001CFD RID: 7421 RVA: 0x0007DA7C File Offset: 0x0007BC7C
		// (set) Token: 0x06001CFE RID: 7422 RVA: 0x0000F723 File Offset: 0x0000D923
		public unsafe DBGSelectionResponder selectionResponder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionResponderInteractionEvents.NativeFieldInfoPtr_selectionResponder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionResponder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionResponderInteractionEvents.NativeFieldInfoPtr_selectionResponder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400123E RID: 4670
		private static readonly IntPtr NativeFieldInfoPtr_selectionResponder;

		// Token: 0x0400123F RID: 4671
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001240 RID: 4672
		private static readonly IntPtr NativeMethodInfoPtr_Event_CancelSelection_Public_Void_0;

		// Token: 0x04001241 RID: 4673
		private static readonly IntPtr NativeMethodInfoPtr_Event_SkipSelection_Public_Void_0;

		// Token: 0x04001242 RID: 4674
		private static readonly IntPtr NativeMethodInfoPtr_Event_ConfirmSelection_Public_Void_0;

		// Token: 0x04001243 RID: 4675
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
