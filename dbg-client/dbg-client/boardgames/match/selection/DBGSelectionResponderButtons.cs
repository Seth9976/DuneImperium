using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.match.selection
{
	// Token: 0x0200026D RID: 621
	public class DBGSelectionResponderButtons : VersionedView<DBGSelectionResponder>
	{
		// Token: 0x06001CEB RID: 7403 RVA: 0x0007D680 File Offset: 0x0007B880
		// Note: this type is marked as 'beforefieldinit'.
		static DBGSelectionResponderButtons()
		{
			Il2CppClassPointerStore<DBGSelectionResponderButtons>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.selection", "DBGSelectionResponderButtons");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGSelectionResponderButtons>.NativeClassPtr);
			DBGSelectionResponderButtons.NativeFieldInfoPtr_cancelButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectionResponderButtons>.NativeClassPtr, "cancelButton");
			DBGSelectionResponderButtons.NativeFieldInfoPtr_advanceButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectionResponderButtons>.NativeClassPtr, "advanceButton");
			DBGSelectionResponderButtons.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponderButtons>.NativeClassPtr, 100668049);
			DBGSelectionResponderButtons.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponderButtons>.NativeClassPtr, 100668050);
			DBGSelectionResponderButtons.NativeMethodInfoPtr_Event_CancelSelection_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponderButtons>.NativeClassPtr, 100668051);
			DBGSelectionResponderButtons.NativeMethodInfoPtr_Event_ConfirmSelection_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponderButtons>.NativeClassPtr, 100668052);
			DBGSelectionResponderButtons.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponderButtons>.NativeClassPtr, 100668053);
		}

		// Token: 0x06001CEC RID: 7404 RVA: 0x0007D73C File Offset: 0x0007B93C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536242, XrefRangeEnd = 536248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGSelectionResponderButtons.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CED RID: 7405 RVA: 0x0007D778 File Offset: 0x0007B978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536248, XrefRangeEnd = 536260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGSelectionResponderButtons.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CEE RID: 7406 RVA: 0x0007D7B4 File Offset: 0x0007B9B4
		[CallerCount(0)]
		public unsafe virtual void Event_CancelSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGSelectionResponderButtons.NativeMethodInfoPtr_Event_CancelSelection_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CEF RID: 7407 RVA: 0x0007D7F0 File Offset: 0x0007B9F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536260, XrefRangeEnd = 536262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Event_ConfirmSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGSelectionResponderButtons.NativeMethodInfoPtr_Event_ConfirmSelection_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF0 RID: 7408 RVA: 0x0007D82C File Offset: 0x0007BA2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536262, XrefRangeEnd = 536265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGSelectionResponderButtons()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGSelectionResponderButtons>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionResponderButtons.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF1 RID: 7409 RVA: 0x0000F6D3 File Offset: 0x0000D8D3
		public DBGSelectionResponderButtons(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06001CF2 RID: 7410 RVA: 0x0007D868 File Offset: 0x0007BA68
		// (set) Token: 0x06001CF3 RID: 7411 RVA: 0x0000F6DC File Offset: 0x0000D8DC
		public unsafe GameObject cancelButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionResponderButtons.NativeFieldInfoPtr_cancelButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionResponderButtons.NativeFieldInfoPtr_cancelButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06001CF4 RID: 7412 RVA: 0x0007D898 File Offset: 0x0007BA98
		// (set) Token: 0x06001CF5 RID: 7413 RVA: 0x0000F6FB File Offset: 0x0000D8FB
		public unsafe GameObject advanceButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionResponderButtons.NativeFieldInfoPtr_advanceButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionResponderButtons.NativeFieldInfoPtr_advanceButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001237 RID: 4663
		private static readonly IntPtr NativeFieldInfoPtr_cancelButton;

		// Token: 0x04001238 RID: 4664
		private static readonly IntPtr NativeFieldInfoPtr_advanceButton;

		// Token: 0x04001239 RID: 4665
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400123A RID: 4666
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400123B RID: 4667
		private static readonly IntPtr NativeMethodInfoPtr_Event_CancelSelection_Public_Virtual_New_Void_0;

		// Token: 0x0400123C RID: 4668
		private static readonly IntPtr NativeMethodInfoPtr_Event_ConfirmSelection_Public_Virtual_New_Void_0;

		// Token: 0x0400123D RID: 4669
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
