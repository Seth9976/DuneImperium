using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace dwd.core.input
{
	// Token: 0x0200004D RID: 77
	public class MobileKeyboardInputField : InputField
	{
		// Token: 0x06000279 RID: 633 RVA: 0x0000EA00 File Offset: 0x0000CC00
		// Note: this type is marked as 'beforefieldinit'.
		static MobileKeyboardInputField()
		{
			Il2CppClassPointerStore<MobileKeyboardInputField>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input", "MobileKeyboardInputField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MobileKeyboardInputField>.NativeClassPtr);
			MobileKeyboardInputField.NativeFieldInfoPtr_clearOnSubmit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileKeyboardInputField>.NativeClassPtr, "clearOnSubmit");
			MobileKeyboardInputField.NativeFieldInfoPtr_onSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileKeyboardInputField>.NativeClassPtr, "onSelected");
			MobileKeyboardInputField.NativeFieldInfoPtr_onDeselected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileKeyboardInputField>.NativeClassPtr, "onDeselected");
			MobileKeyboardInputField.NativeFieldInfoPtr_onKeyboardSubmit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileKeyboardInputField>.NativeClassPtr, "onKeyboardSubmit");
			MobileKeyboardInputField.NativeMethodInfoPtr_get_OnSelected_Public_get_UnityEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileKeyboardInputField>.NativeClassPtr, 100663604);
			MobileKeyboardInputField.NativeMethodInfoPtr_get_OnDeselected_Public_get_UnityEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileKeyboardInputField>.NativeClassPtr, 100663605);
			MobileKeyboardInputField.NativeMethodInfoPtr_get_onSubmit_Public_get_UnityEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileKeyboardInputField>.NativeClassPtr, 100663606);
			MobileKeyboardInputField.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileKeyboardInputField>.NativeClassPtr, 100663607);
			MobileKeyboardInputField.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileKeyboardInputField>.NativeClassPtr, 100663608);
			MobileKeyboardInputField.NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileKeyboardInputField>.NativeClassPtr, 100663609);
			MobileKeyboardInputField.NativeMethodInfoPtr_OnDeselect_Public_Virtual_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileKeyboardInputField>.NativeClassPtr, 100663610);
			MobileKeyboardInputField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileKeyboardInputField>.NativeClassPtr, 100663611);
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600027A RID: 634 RVA: 0x0000EB20 File Offset: 0x0000CD20
		public unsafe UnityEvent OnSelected
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileKeyboardInputField.NativeMethodInfoPtr_get_OnSelected_Public_get_UnityEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr3) : null;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600027B RID: 635 RVA: 0x0000EB60 File Offset: 0x0000CD60
		public unsafe UnityEvent OnDeselected
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileKeyboardInputField.NativeMethodInfoPtr_get_OnDeselected_Public_get_UnityEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr3) : null;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600027C RID: 636 RVA: 0x0000EBA0 File Offset: 0x0000CDA0
		public new unsafe UnityEvent onSubmit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileKeyboardInputField.NativeMethodInfoPtr_get_onSubmit_Public_get_UnityEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr3) : null;
			}
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000EBE0 File Offset: 0x0000CDE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120815, XrefRangeEnd = 1120820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileKeyboardInputField.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000EC14 File Offset: 0x0000CE14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120820, XrefRangeEnd = 1120823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileKeyboardInputField.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000EC50 File Offset: 0x0000CE50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120823, XrefRangeEnd = 1120826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSelect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileKeyboardInputField.NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000ECA0 File Offset: 0x0000CEA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120826, XrefRangeEnd = 1120829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDeselect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileKeyboardInputField.NativeMethodInfoPtr_OnDeselect_Public_Virtual_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0000ECF0 File Offset: 0x0000CEF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120829, XrefRangeEnd = 1120846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MobileKeyboardInputField()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MobileKeyboardInputField>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileKeyboardInputField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x000036E4 File Offset: 0x000018E4
		public MobileKeyboardInputField(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000283 RID: 643 RVA: 0x0000ED2C File Offset: 0x0000CF2C
		// (set) Token: 0x06000284 RID: 644 RVA: 0x000036ED File Offset: 0x000018ED
		public unsafe bool clearOnSubmit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileKeyboardInputField.NativeFieldInfoPtr_clearOnSubmit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileKeyboardInputField.NativeFieldInfoPtr_clearOnSubmit)) = value;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000285 RID: 645 RVA: 0x0000ED54 File Offset: 0x0000CF54
		// (set) Token: 0x06000286 RID: 646 RVA: 0x00003708 File Offset: 0x00001908
		public unsafe UnityEvent onSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileKeyboardInputField.NativeFieldInfoPtr_onSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileKeyboardInputField.NativeFieldInfoPtr_onSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000287 RID: 647 RVA: 0x0000ED84 File Offset: 0x0000CF84
		// (set) Token: 0x06000288 RID: 648 RVA: 0x00003727 File Offset: 0x00001927
		public unsafe UnityEvent onDeselected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileKeyboardInputField.NativeFieldInfoPtr_onDeselected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileKeyboardInputField.NativeFieldInfoPtr_onDeselected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000289 RID: 649 RVA: 0x0000EDB4 File Offset: 0x0000CFB4
		// (set) Token: 0x0600028A RID: 650 RVA: 0x00003746 File Offset: 0x00001946
		public unsafe UnityEvent onKeyboardSubmit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileKeyboardInputField.NativeFieldInfoPtr_onKeyboardSubmit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileKeyboardInputField.NativeFieldInfoPtr_onKeyboardSubmit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeFieldInfoPtr_clearOnSubmit;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeFieldInfoPtr_onSelected;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeFieldInfoPtr_onDeselected;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeFieldInfoPtr_onKeyboardSubmit;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeMethodInfoPtr_get_OnSelected_Public_get_UnityEvent_0;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeMethodInfoPtr_get_OnDeselected_Public_get_UnityEvent_0;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeMethodInfoPtr_get_onSubmit_Public_get_UnityEvent_0;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeMethodInfoPtr_OnDeselect_Public_Virtual_Void_BaseEventData_0;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
