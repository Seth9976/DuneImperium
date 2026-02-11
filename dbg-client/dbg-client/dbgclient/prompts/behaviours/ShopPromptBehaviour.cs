using System;
using dwd.core.ui.prompt.behaviours;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Events;

namespace dbgclient.prompts.behaviours
{
	// Token: 0x0200009A RID: 154
	public class ShopPromptBehaviour : TabulatedPromptBehavior<ShopPrompt>
	{
		// Token: 0x060005F1 RID: 1521 RVA: 0x00030770 File Offset: 0x0002E970
		// Note: this type is marked as 'beforefieldinit'.
		static ShopPromptBehaviour()
		{
			Il2CppClassPointerStore<ShopPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.prompts.behaviours", "ShopPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopPromptBehaviour>.NativeClassPtr);
			ShopPromptBehaviour.NativeFieldInfoPtr_shopProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopPromptBehaviour>.NativeClassPtr, "shopProvider");
			ShopPromptBehaviour.NativeFieldInfoPtr_onLoadFailed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopPromptBehaviour>.NativeClassPtr, "onLoadFailed");
			ShopPromptBehaviour.NativeFieldInfoPtr_purchaseSpinner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopPromptBehaviour>.NativeClassPtr, "purchaseSpinner");
			ShopPromptBehaviour.NativeMethodInfoPtr_get_StartingTabIndex_Protected_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPromptBehaviour>.NativeClassPtr, 100664212);
			ShopPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPromptBehaviour>.NativeClassPtr, 100664213);
			ShopPromptBehaviour.NativeMethodInfoPtr_Event_ShowPurchaseSpinner_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPromptBehaviour>.NativeClassPtr, 100664214);
			ShopPromptBehaviour.NativeMethodInfoPtr_Event_HidePurchaseSpinner_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPromptBehaviour>.NativeClassPtr, 100664215);
			ShopPromptBehaviour.NativeMethodInfoPtr_Event_Dismiss_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPromptBehaviour>.NativeClassPtr, 100664216);
			ShopPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPromptBehaviour>.NativeClassPtr, 100664217);
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060005F2 RID: 1522 RVA: 0x00030854 File Offset: 0x0002EA54
		public unsafe override int StartingTabIndex
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502480, XrefRangeEnd = 502483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopPromptBehaviour.NativeMethodInfoPtr_get_StartingTabIndex_Protected_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x0003089C File Offset: 0x0002EA9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502483, XrefRangeEnd = 502517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x000308D8 File Offset: 0x0002EAD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502517, XrefRangeEnd = 502532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ShowPurchaseSpinner()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopPromptBehaviour.NativeMethodInfoPtr_Event_ShowPurchaseSpinner_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x0003090C File Offset: 0x0002EB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502532, XrefRangeEnd = 502534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_HidePurchaseSpinner()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopPromptBehaviour.NativeMethodInfoPtr_Event_HidePurchaseSpinner_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00030940 File Offset: 0x0002EB40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502534, XrefRangeEnd = 502539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Dismiss()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopPromptBehaviour.NativeMethodInfoPtr_Event_Dismiss_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00030974 File Offset: 0x0002EB74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502539, XrefRangeEnd = 502547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShopPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00004A57 File Offset: 0x00002C57
		public ShopPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060005F9 RID: 1529 RVA: 0x000309B0 File Offset: 0x0002EBB0
		// (set) Token: 0x060005FA RID: 1530 RVA: 0x00004A60 File Offset: 0x00002C60
		public unsafe SubscriptionProvider shopProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopPromptBehaviour.NativeFieldInfoPtr_shopProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopPromptBehaviour.NativeFieldInfoPtr_shopProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x000309E0 File Offset: 0x0002EBE0
		// (set) Token: 0x060005FC RID: 1532 RVA: 0x00004A7F File Offset: 0x00002C7F
		public unsafe UnityEvent onLoadFailed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopPromptBehaviour.NativeFieldInfoPtr_onLoadFailed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopPromptBehaviour.NativeFieldInfoPtr_onLoadFailed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060005FD RID: 1533 RVA: 0x00030A10 File Offset: 0x0002EC10
		// (set) Token: 0x060005FE RID: 1534 RVA: 0x00004A9E File Offset: 0x00002C9E
		public unsafe Spinner purchaseSpinner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopPromptBehaviour.NativeFieldInfoPtr_purchaseSpinner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spinner>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopPromptBehaviour.NativeFieldInfoPtr_purchaseSpinner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003AE RID: 942
		private static readonly IntPtr NativeFieldInfoPtr_shopProvider;

		// Token: 0x040003AF RID: 943
		private static readonly IntPtr NativeFieldInfoPtr_onLoadFailed;

		// Token: 0x040003B0 RID: 944
		private static readonly IntPtr NativeFieldInfoPtr_purchaseSpinner;

		// Token: 0x040003B1 RID: 945
		private static readonly IntPtr NativeMethodInfoPtr_get_StartingTabIndex_Protected_Virtual_get_Int32_0;

		// Token: 0x040003B2 RID: 946
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x040003B3 RID: 947
		private static readonly IntPtr NativeMethodInfoPtr_Event_ShowPurchaseSpinner_Public_Void_0;

		// Token: 0x040003B4 RID: 948
		private static readonly IntPtr NativeMethodInfoPtr_Event_HidePurchaseSpinner_Public_Void_0;

		// Token: 0x040003B5 RID: 949
		private static readonly IntPtr NativeMethodInfoPtr_Event_Dismiss_Public_Void_0;

		// Token: 0x040003B6 RID: 950
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
