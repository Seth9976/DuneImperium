using System;
using boardgames.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001BF RID: 447
	public class SelectionResponderButtons : VersionedView<DBGSelectionResponder>
	{
		// Token: 0x060013A7 RID: 5031 RVA: 0x00053D3C File Offset: 0x00051F3C
		// Note: this type is marked as 'beforefieldinit'.
		static SelectionResponderButtons()
		{
			Il2CppClassPointerStore<SelectionResponderButtons>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "SelectionResponderButtons");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionResponderButtons>.NativeClassPtr);
			SelectionResponderButtons.NativeFieldInfoPtr_cancelButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionResponderButtons>.NativeClassPtr, "cancelButton");
			SelectionResponderButtons.NativeFieldInfoPtr_advanceButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionResponderButtons>.NativeClassPtr, "advanceButton");
			SelectionResponderButtons.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionResponderButtons>.NativeClassPtr, 100665992);
			SelectionResponderButtons.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionResponderButtons>.NativeClassPtr, 100665993);
			SelectionResponderButtons.NativeMethodInfoPtr_Event_CancelSelection_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionResponderButtons>.NativeClassPtr, 100665994);
			SelectionResponderButtons.NativeMethodInfoPtr_Event_ConfirmSelection_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionResponderButtons>.NativeClassPtr, 100665995);
			SelectionResponderButtons.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionResponderButtons>.NativeClassPtr, 100665996);
		}

		// Token: 0x060013A8 RID: 5032 RVA: 0x00053DF8 File Offset: 0x00051FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713254, XrefRangeEnd = 713260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionResponderButtons.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013A9 RID: 5033 RVA: 0x00053E34 File Offset: 0x00052034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713260, XrefRangeEnd = 713289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionResponderButtons.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x00053E70 File Offset: 0x00052070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713289, XrefRangeEnd = 713291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Event_CancelSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionResponderButtons.NativeMethodInfoPtr_Event_CancelSelection_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x00053EAC File Offset: 0x000520AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Event_ConfirmSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionResponderButtons.NativeMethodInfoPtr_Event_ConfirmSelection_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013AC RID: 5036 RVA: 0x00053EE8 File Offset: 0x000520E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713291, XrefRangeEnd = 713294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionResponderButtons()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionResponderButtons>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionResponderButtons.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x0000C1B9 File Offset: 0x0000A3B9
		public SelectionResponderButtons(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x060013AE RID: 5038 RVA: 0x00053F24 File Offset: 0x00052124
		// (set) Token: 0x060013AF RID: 5039 RVA: 0x0000C1C2 File Offset: 0x0000A3C2
		public unsafe GameObject cancelButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionResponderButtons.NativeFieldInfoPtr_cancelButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionResponderButtons.NativeFieldInfoPtr_cancelButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x060013B0 RID: 5040 RVA: 0x00053F54 File Offset: 0x00052154
		// (set) Token: 0x060013B1 RID: 5041 RVA: 0x0000C1E1 File Offset: 0x0000A3E1
		public unsafe GameObject advanceButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionResponderButtons.NativeFieldInfoPtr_advanceButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionResponderButtons.NativeFieldInfoPtr_advanceButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B63 RID: 2915
		private static readonly IntPtr NativeFieldInfoPtr_cancelButton;

		// Token: 0x04000B64 RID: 2916
		private static readonly IntPtr NativeFieldInfoPtr_advanceButton;

		// Token: 0x04000B65 RID: 2917
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000B66 RID: 2918
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000B67 RID: 2919
		private static readonly IntPtr NativeMethodInfoPtr_Event_CancelSelection_Public_Virtual_New_Void_0;

		// Token: 0x04000B68 RID: 2920
		private static readonly IntPtr NativeMethodInfoPtr_Event_ConfirmSelection_Public_Virtual_New_Void_0;

		// Token: 0x04000B69 RID: 2921
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
