using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace boardgames.match.selection
{
	// Token: 0x0200025C RID: 604
	public class AdvanceOrCancelSelection : MonoBehaviour
	{
		// Token: 0x06001BA8 RID: 7080 RVA: 0x0007860C File Offset: 0x0007680C
		// Note: this type is marked as 'beforefieldinit'.
		static AdvanceOrCancelSelection()
		{
			Il2CppClassPointerStore<AdvanceOrCancelSelection>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.selection", "AdvanceOrCancelSelection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdvanceOrCancelSelection>.NativeClassPtr);
			AdvanceOrCancelSelection.NativeFieldInfoPtr_cancelButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvanceOrCancelSelection>.NativeClassPtr, "cancelButton");
			AdvanceOrCancelSelection.NativeFieldInfoPtr_skipButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvanceOrCancelSelection>.NativeClassPtr, "skipButton");
			AdvanceOrCancelSelection.NativeFieldInfoPtr_confirmButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvanceOrCancelSelection>.NativeClassPtr, "confirmButton");
			AdvanceOrCancelSelection.NativeFieldInfoPtr_selectionResponder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvanceOrCancelSelection>.NativeClassPtr, "selectionResponder");
			AdvanceOrCancelSelection.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvanceOrCancelSelection>.NativeClassPtr, "version");
			AdvanceOrCancelSelection.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvanceOrCancelSelection>.NativeClassPtr, 100667811);
			AdvanceOrCancelSelection.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvanceOrCancelSelection>.NativeClassPtr, 100667812);
			AdvanceOrCancelSelection.NativeMethodInfoPtr_HandleSelectionPromptOptions_Protected_Virtual_New_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvanceOrCancelSelection>.NativeClassPtr, 100667813);
			AdvanceOrCancelSelection.NativeMethodInfoPtr_Event_CancelSelection_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvanceOrCancelSelection>.NativeClassPtr, 100667814);
			AdvanceOrCancelSelection.NativeMethodInfoPtr_Event_SkipSelection_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvanceOrCancelSelection>.NativeClassPtr, 100667815);
			AdvanceOrCancelSelection.NativeMethodInfoPtr_Event_ConfirmSelection_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvanceOrCancelSelection>.NativeClassPtr, 100667816);
			AdvanceOrCancelSelection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvanceOrCancelSelection>.NativeClassPtr, 100667817);
		}

		// Token: 0x06001BA9 RID: 7081 RVA: 0x0007872C File Offset: 0x0007692C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534301, XrefRangeEnd = 534305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvanceOrCancelSelection.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BAA RID: 7082 RVA: 0x00078760 File Offset: 0x00076960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534305, XrefRangeEnd = 534317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvanceOrCancelSelection.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BAB RID: 7083 RVA: 0x00078794 File Offset: 0x00076994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534317, XrefRangeEnd = 534343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HandleSelectionPromptOptions(Nullable<int> promptOptionsAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(promptOptionsAttr));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AdvanceOrCancelSelection.NativeMethodInfoPtr_HandleSelectionPromptOptions_Protected_Virtual_New_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x000787E8 File Offset: 0x000769E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534343, XrefRangeEnd = 534345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Event_CancelSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AdvanceOrCancelSelection.NativeMethodInfoPtr_Event_CancelSelection_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x00078824 File Offset: 0x00076A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534345, XrefRangeEnd = 534347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Event_SkipSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AdvanceOrCancelSelection.NativeMethodInfoPtr_Event_SkipSelection_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x00078860 File Offset: 0x00076A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Event_ConfirmSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AdvanceOrCancelSelection.NativeMethodInfoPtr_Event_ConfirmSelection_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x0007889C File Offset: 0x00076A9C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdvanceOrCancelSelection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdvanceOrCancelSelection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvanceOrCancelSelection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x0000EF01 File Offset: 0x0000D101
		public AdvanceOrCancelSelection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x06001BB1 RID: 7089 RVA: 0x000788D8 File Offset: 0x00076AD8
		// (set) Token: 0x06001BB2 RID: 7090 RVA: 0x0000EF0A File Offset: 0x0000D10A
		public unsafe GameObject cancelButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvanceOrCancelSelection.NativeFieldInfoPtr_cancelButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvanceOrCancelSelection.NativeFieldInfoPtr_cancelButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x06001BB3 RID: 7091 RVA: 0x00078908 File Offset: 0x00076B08
		// (set) Token: 0x06001BB4 RID: 7092 RVA: 0x0000EF29 File Offset: 0x0000D129
		public unsafe GameObject skipButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvanceOrCancelSelection.NativeFieldInfoPtr_skipButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvanceOrCancelSelection.NativeFieldInfoPtr_skipButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x06001BB5 RID: 7093 RVA: 0x00078938 File Offset: 0x00076B38
		// (set) Token: 0x06001BB6 RID: 7094 RVA: 0x0000EF48 File Offset: 0x0000D148
		public unsafe GameObject confirmButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvanceOrCancelSelection.NativeFieldInfoPtr_confirmButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvanceOrCancelSelection.NativeFieldInfoPtr_confirmButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x06001BB7 RID: 7095 RVA: 0x00078968 File Offset: 0x00076B68
		// (set) Token: 0x06001BB8 RID: 7096 RVA: 0x0000EF67 File Offset: 0x0000D167
		public unsafe DBGSelectionResponder selectionResponder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvanceOrCancelSelection.NativeFieldInfoPtr_selectionResponder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionResponder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvanceOrCancelSelection.NativeFieldInfoPtr_selectionResponder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x06001BB9 RID: 7097 RVA: 0x00078998 File Offset: 0x00076B98
		// (set) Token: 0x06001BBA RID: 7098 RVA: 0x0000EF86 File Offset: 0x0000D186
		public unsafe ulong version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvanceOrCancelSelection.NativeFieldInfoPtr_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvanceOrCancelSelection.NativeFieldInfoPtr_version)) = value;
			}
		}

		// Token: 0x04001153 RID: 4435
		private static readonly IntPtr NativeFieldInfoPtr_cancelButton;

		// Token: 0x04001154 RID: 4436
		private static readonly IntPtr NativeFieldInfoPtr_skipButton;

		// Token: 0x04001155 RID: 4437
		private static readonly IntPtr NativeFieldInfoPtr_confirmButton;

		// Token: 0x04001156 RID: 4438
		private static readonly IntPtr NativeFieldInfoPtr_selectionResponder;

		// Token: 0x04001157 RID: 4439
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x04001158 RID: 4440
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001159 RID: 4441
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400115A RID: 4442
		private static readonly IntPtr NativeMethodInfoPtr_HandleSelectionPromptOptions_Protected_Virtual_New_Void_Nullable_1_Int32_0;

		// Token: 0x0400115B RID: 4443
		private static readonly IntPtr NativeMethodInfoPtr_Event_CancelSelection_Public_Virtual_New_Void_0;

		// Token: 0x0400115C RID: 4444
		private static readonly IntPtr NativeMethodInfoPtr_Event_SkipSelection_Public_Virtual_New_Void_0;

		// Token: 0x0400115D RID: 4445
		private static readonly IntPtr NativeMethodInfoPtr_Event_ConfirmSelection_Public_Virtual_New_Void_0;

		// Token: 0x0400115E RID: 4446
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
