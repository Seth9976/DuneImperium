using System;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace dwd.iap.store
{
	// Token: 0x02000024 RID: 36
	public class IAPProductRenderer : VersionedSubscriber<IAPProductDataComponent>
	{
		// Token: 0x0600020B RID: 523 RVA: 0x0000B3E4 File Offset: 0x000095E4
		// Note: this type is marked as 'beforefieldinit'.
		static IAPProductRenderer()
		{
			Il2CppClassPointerStore<IAPProductRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("InAppPurchasing.dll", "dwd.iap.store", "IAPProductRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IAPProductRenderer>.NativeClassPtr);
			IAPProductRenderer.NativeFieldInfoPtr_purchasedLocKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPProductRenderer>.NativeClassPtr, "purchasedLocKey");
			IAPProductRenderer.NativeFieldInfoPtr_SetPrefUnseenValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPProductRenderer>.NativeClassPtr, "SetPrefUnseenValue");
			IAPProductRenderer.NativeFieldInfoPtr_storeBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPProductRenderer>.NativeClassPtr, "storeBehaviour");
			IAPProductRenderer.NativeFieldInfoPtr_titleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPProductRenderer>.NativeClassPtr, "titleText");
			IAPProductRenderer.NativeFieldInfoPtr_descriptionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPProductRenderer>.NativeClassPtr, "descriptionText");
			IAPProductRenderer.NativeFieldInfoPtr_priceText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPProductRenderer>.NativeClassPtr, "priceText");
			IAPProductRenderer.NativeFieldInfoPtr_purchaseButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPProductRenderer>.NativeClassPtr, "purchaseButton");
			IAPProductRenderer.NativeFieldInfoPtr_contentAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPProductRenderer>.NativeClassPtr, "contentAnchor");
			IAPProductRenderer.NativeFieldInfoPtr_resetPrefNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPProductRenderer>.NativeClassPtr, "resetPrefNames");
			IAPProductRenderer.NativeFieldInfoPtr_purchaseClickedEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPProductRenderer>.NativeClassPtr, "purchaseClickedEvents");
			IAPProductRenderer.NativeFieldInfoPtr_purchaseFinishedEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPProductRenderer>.NativeClassPtr, "purchaseFinishedEvents");
			IAPProductRenderer.NativeFieldInfoPtr_content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPProductRenderer>.NativeClassPtr, "content");
			IAPProductRenderer.NativeFieldInfoPtr_purchaseSpinner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPProductRenderer>.NativeClassPtr, "purchaseSpinner");
			IAPProductRenderer.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProductRenderer>.NativeClassPtr, 100663737);
			IAPProductRenderer.NativeMethodInfoPtr_onEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProductRenderer>.NativeClassPtr, 100663738);
			IAPProductRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProductRenderer>.NativeClassPtr, 100663739);
			IAPProductRenderer.NativeMethodInfoPtr_Event_OnPurchaseClicked_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProductRenderer>.NativeClassPtr, 100663740);
			IAPProductRenderer.NativeMethodInfoPtr_OnPurchaseAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProductRenderer>.NativeClassPtr, 100663741);
			IAPProductRenderer.NativeMethodInfoPtr_Event_ShowPurchaseSpinner_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProductRenderer>.NativeClassPtr, 100663742);
			IAPProductRenderer.NativeMethodInfoPtr_Event_HidePurchaseSpinner_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProductRenderer>.NativeClassPtr, 100663743);
			IAPProductRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProductRenderer>.NativeClassPtr, 100663744);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000B5B8 File Offset: 0x000097B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202425, XrefRangeEnd = 1202429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProductRenderer.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000B5EC File Offset: 0x000097EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202429, XrefRangeEnd = 1202430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void onEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAPProductRenderer.NativeMethodInfoPtr_onEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0000B628 File Offset: 0x00009828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202430, XrefRangeEnd = 1202488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAPProductRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0000B664 File Offset: 0x00009864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202488, XrefRangeEnd = 1202505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Event_OnPurchaseClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAPProductRenderer.NativeMethodInfoPtr_Event_OnPurchaseClicked_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0000B6A0 File Offset: 0x000098A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202505, XrefRangeEnd = 1202551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPurchaseAction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProductRenderer.NativeMethodInfoPtr_OnPurchaseAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0000B6D4 File Offset: 0x000098D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202551, XrefRangeEnd = 1202566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ShowPurchaseSpinner()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProductRenderer.NativeMethodInfoPtr_Event_ShowPurchaseSpinner_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0000B708 File Offset: 0x00009908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202566, XrefRangeEnd = 1202568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_HidePurchaseSpinner()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProductRenderer.NativeMethodInfoPtr_Event_HidePurchaseSpinner_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000B73C File Offset: 0x0000993C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202568, XrefRangeEnd = 1202571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAPProductRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IAPProductRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProductRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00002D5A File Offset: 0x00000F5A
		public IAPProductRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000215 RID: 533 RVA: 0x0000B778 File Offset: 0x00009978
		// (set) Token: 0x06000216 RID: 534 RVA: 0x00002D63 File Offset: 0x00000F63
		public unsafe static string purchasedLocKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IAPProductRenderer.NativeFieldInfoPtr_purchasedLocKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IAPProductRenderer.NativeFieldInfoPtr_purchasedLocKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000217 RID: 535 RVA: 0x0000B798 File Offset: 0x00009998
		// (set) Token: 0x06000218 RID: 536 RVA: 0x00002D75 File Offset: 0x00000F75
		public unsafe static int SetPrefUnseenValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(IAPProductRenderer.NativeFieldInfoPtr_SetPrefUnseenValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IAPProductRenderer.NativeFieldInfoPtr_SetPrefUnseenValue, (void*)(&value));
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000219 RID: 537 RVA: 0x0000B7B4 File Offset: 0x000099B4
		// (set) Token: 0x0600021A RID: 538 RVA: 0x00002D83 File Offset: 0x00000F83
		public unsafe IAPStoreBehaviour storeBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProductRenderer.NativeFieldInfoPtr_storeBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAPStoreBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProductRenderer.NativeFieldInfoPtr_storeBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600021B RID: 539 RVA: 0x0000B7E4 File Offset: 0x000099E4
		// (set) Token: 0x0600021C RID: 540 RVA: 0x00002DA2 File Offset: 0x00000FA2
		public unsafe TMP_Text titleText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProductRenderer.NativeFieldInfoPtr_titleText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProductRenderer.NativeFieldInfoPtr_titleText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600021D RID: 541 RVA: 0x0000B814 File Offset: 0x00009A14
		// (set) Token: 0x0600021E RID: 542 RVA: 0x00002DC1 File Offset: 0x00000FC1
		public unsafe TMP_Text descriptionText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProductRenderer.NativeFieldInfoPtr_descriptionText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProductRenderer.NativeFieldInfoPtr_descriptionText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600021F RID: 543 RVA: 0x0000B844 File Offset: 0x00009A44
		// (set) Token: 0x06000220 RID: 544 RVA: 0x00002DE0 File Offset: 0x00000FE0
		public unsafe TMP_Text priceText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProductRenderer.NativeFieldInfoPtr_priceText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProductRenderer.NativeFieldInfoPtr_priceText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000221 RID: 545 RVA: 0x0000B874 File Offset: 0x00009A74
		// (set) Token: 0x06000222 RID: 546 RVA: 0x00002DFF File Offset: 0x00000FFF
		public unsafe Button purchaseButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProductRenderer.NativeFieldInfoPtr_purchaseButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProductRenderer.NativeFieldInfoPtr_purchaseButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000223 RID: 547 RVA: 0x0000B8A4 File Offset: 0x00009AA4
		// (set) Token: 0x06000224 RID: 548 RVA: 0x00002E1E File Offset: 0x0000101E
		public unsafe GameObject contentAnchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProductRenderer.NativeFieldInfoPtr_contentAnchor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProductRenderer.NativeFieldInfoPtr_contentAnchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000225 RID: 549 RVA: 0x0000B8D4 File Offset: 0x00009AD4
		// (set) Token: 0x06000226 RID: 550 RVA: 0x00002E3D File Offset: 0x0000103D
		public unsafe Il2CppStringArray resetPrefNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProductRenderer.NativeFieldInfoPtr_resetPrefNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProductRenderer.NativeFieldInfoPtr_resetPrefNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000227 RID: 551 RVA: 0x0000B904 File Offset: 0x00009B04
		// (set) Token: 0x06000228 RID: 552 RVA: 0x00002E5C File Offset: 0x0000105C
		public unsafe UnityEvent purchaseClickedEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProductRenderer.NativeFieldInfoPtr_purchaseClickedEvents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProductRenderer.NativeFieldInfoPtr_purchaseClickedEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000229 RID: 553 RVA: 0x0000B934 File Offset: 0x00009B34
		// (set) Token: 0x0600022A RID: 554 RVA: 0x00002E7B File Offset: 0x0000107B
		public unsafe UnityEvent purchaseFinishedEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProductRenderer.NativeFieldInfoPtr_purchaseFinishedEvents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProductRenderer.NativeFieldInfoPtr_purchaseFinishedEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600022B RID: 555 RVA: 0x0000B964 File Offset: 0x00009B64
		// (set) Token: 0x0600022C RID: 556 RVA: 0x00002E9A File Offset: 0x0000109A
		public unsafe GameObject content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProductRenderer.NativeFieldInfoPtr_content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProductRenderer.NativeFieldInfoPtr_content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600022D RID: 557 RVA: 0x0000B994 File Offset: 0x00009B94
		// (set) Token: 0x0600022E RID: 558 RVA: 0x00002EB9 File Offset: 0x000010B9
		public unsafe Spinner purchaseSpinner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProductRenderer.NativeFieldInfoPtr_purchaseSpinner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spinner>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProductRenderer.NativeFieldInfoPtr_purchaseSpinner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeFieldInfoPtr_purchasedLocKey;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeFieldInfoPtr_SetPrefUnseenValue;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeFieldInfoPtr_storeBehaviour;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeFieldInfoPtr_titleText;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeFieldInfoPtr_descriptionText;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeFieldInfoPtr_priceText;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeFieldInfoPtr_purchaseButton;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeFieldInfoPtr_contentAnchor;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeFieldInfoPtr_resetPrefNames;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeFieldInfoPtr_purchaseClickedEvents;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeFieldInfoPtr_purchaseFinishedEvents;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeFieldInfoPtr_content;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeFieldInfoPtr_purchaseSpinner;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeMethodInfoPtr_onEnable_Protected_Virtual_Void_0;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeMethodInfoPtr_Event_OnPurchaseClicked_Public_Virtual_New_Void_0;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeMethodInfoPtr_OnPurchaseAction_Private_Void_0;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeMethodInfoPtr_Event_ShowPurchaseSpinner_Public_Void_0;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeMethodInfoPtr_Event_HidePurchaseSpinner_Public_Void_0;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
