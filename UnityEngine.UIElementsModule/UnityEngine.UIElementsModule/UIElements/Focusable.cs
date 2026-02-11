using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x0200012D RID: 301
	public class Focusable : CallbackEventHandler
	{
		// Token: 0x06001644 RID: 5700 RVA: 0x0006BD2C File Offset: 0x00069F2C
		// Note: this type is marked as 'beforefieldinit'.
		static Focusable()
		{
			Il2CppClassPointerStore<Focusable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "Focusable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Focusable>.NativeClassPtr);
			Focusable.NativeFieldInfoPtr__focusable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Focusable>.NativeClassPtr, "<focusable>k__BackingField");
			Focusable.NativeFieldInfoPtr__tabIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Focusable>.NativeClassPtr, "<tabIndex>k__BackingField");
			Focusable.NativeFieldInfoPtr_m_DelegatesFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Focusable>.NativeClassPtr, "m_DelegatesFocus");
			Focusable.NativeFieldInfoPtr_m_ExcludeFromFocusRing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Focusable>.NativeClassPtr, "m_ExcludeFromFocusRing");
			Focusable.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Focusable>.NativeClassPtr, 100666626);
			Focusable.NativeMethodInfoPtr_get_focusController_Public_Abstract_Virtual_New_get_FocusController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Focusable>.NativeClassPtr, 100666627);
			Focusable.NativeMethodInfoPtr_get_focusable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Focusable>.NativeClassPtr, 100666628);
			Focusable.NativeMethodInfoPtr_set_focusable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Focusable>.NativeClassPtr, 100666629);
			Focusable.NativeMethodInfoPtr_get_tabIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Focusable>.NativeClassPtr, 100666630);
			Focusable.NativeMethodInfoPtr_set_tabIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Focusable>.NativeClassPtr, 100666631);
			Focusable.NativeMethodInfoPtr_get_delegatesFocus_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Focusable>.NativeClassPtr, 100666632);
			Focusable.NativeMethodInfoPtr_set_delegatesFocus_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Focusable>.NativeClassPtr, 100666633);
			Focusable.NativeMethodInfoPtr_get_excludeFromFocusRing_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Focusable>.NativeClassPtr, 100666634);
			Focusable.NativeMethodInfoPtr_set_excludeFromFocusRing_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Focusable>.NativeClassPtr, 100666635);
			Focusable.NativeMethodInfoPtr_get_canGrabFocus_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Focusable>.NativeClassPtr, 100666636);
			Focusable.NativeMethodInfoPtr_Focus_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Focusable>.NativeClassPtr, 100666637);
			Focusable.NativeMethodInfoPtr_Blur_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Focusable>.NativeClassPtr, 100666638);
			Focusable.NativeMethodInfoPtr_BlurImmediately_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Focusable>.NativeClassPtr, 100666639);
			Focusable.NativeMethodInfoPtr_GetFocusDelegate_Private_Focusable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Focusable>.NativeClassPtr, 100666640);
			Focusable.NativeMethodInfoPtr_GetFirstFocusableChild_Private_Static_Focusable_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Focusable>.NativeClassPtr, 100666641);
			Focusable.NativeMethodInfoPtr_ExecuteDefaultAction_Protected_Virtual_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Focusable>.NativeClassPtr, 100666642);
			Focusable.NativeMethodInfoPtr_ExecuteDefaultActionDisabled_Internal_Virtual_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Focusable>.NativeClassPtr, 100666643);
			Focusable.NativeMethodInfoPtr_ProcessEvent_Private_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Focusable>.NativeClassPtr, 100666644);
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x0006BF28 File Offset: 0x0006A128
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317534, RefRangeEnd = 317535, XrefRangeStart = 317533, XrefRangeEnd = 317534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Focusable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Focusable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Focusable.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06001646 RID: 5702 RVA: 0x0006BF64 File Offset: 0x0006A164
		public unsafe virtual FocusController focusController
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Focusable.NativeMethodInfoPtr_get_focusController_Public_Abstract_Virtual_New_get_FocusController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FocusController>(intPtr3) : null;
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x06001647 RID: 5703 RVA: 0x0006BFB0 File Offset: 0x0006A1B0
		// (set) Token: 0x06001648 RID: 5704 RVA: 0x0006BFEC File Offset: 0x0006A1EC
		public unsafe bool focusable
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Focusable.NativeMethodInfoPtr_get_focusable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Focusable.NativeMethodInfoPtr_set_focusable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06001649 RID: 5705 RVA: 0x0006C02C File Offset: 0x0006A22C
		// (set) Token: 0x0600164A RID: 5706 RVA: 0x0006C068 File Offset: 0x0006A268
		public unsafe int tabIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Focusable.NativeMethodInfoPtr_get_tabIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Focusable.NativeMethodInfoPtr_set_tabIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x0600164B RID: 5707 RVA: 0x0006C0A8 File Offset: 0x0006A2A8
		// (set) Token: 0x0600164C RID: 5708 RVA: 0x0006C0E4 File Offset: 0x0006A2E4
		public unsafe bool delegatesFocus
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 317535, RefRangeEnd = 317537, XrefRangeStart = 317535, XrefRangeEnd = 317535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Focusable.NativeMethodInfoPtr_get_delegatesFocus_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 287297, RefRangeEnd = 287316, XrefRangeStart = 287297, XrefRangeEnd = 287316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Focusable.NativeMethodInfoPtr_set_delegatesFocus_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x0600164D RID: 5709 RVA: 0x0006C124 File Offset: 0x0006A324
		// (set) Token: 0x0600164E RID: 5710 RVA: 0x0006C160 File Offset: 0x0006A360
		public unsafe bool excludeFromFocusRing
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 317537, RefRangeEnd = 317542, XrefRangeStart = 317537, XrefRangeEnd = 317537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Focusable.NativeMethodInfoPtr_get_excludeFromFocusRing_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 317545, RefRangeEnd = 317550, XrefRangeStart = 317542, XrefRangeEnd = 317545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Focusable.NativeMethodInfoPtr_set_excludeFromFocusRing_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x0600164F RID: 5711 RVA: 0x0006C1A0 File Offset: 0x0006A3A0
		public unsafe virtual bool canGrabFocus
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Focusable.NativeMethodInfoPtr_get_canGrabFocus_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001650 RID: 5712 RVA: 0x0006C1E8 File Offset: 0x0006A3E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317557, RefRangeEnd = 317558, XrefRangeStart = 317550, XrefRangeEnd = 317557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Focus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Focusable.NativeMethodInfoPtr_Focus_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x0006C224 File Offset: 0x0006A424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317558, XrefRangeEnd = 317559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Blur()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Focusable.NativeMethodInfoPtr_Blur_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x0006C260 File Offset: 0x0006A460
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317560, RefRangeEnd = 317561, XrefRangeStart = 317559, XrefRangeEnd = 317560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BlurImmediately()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Focusable.NativeMethodInfoPtr_BlurImmediately_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x0006C294 File Offset: 0x0006A494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317561, XrefRangeEnd = 317566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Focusable GetFocusDelegate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Focusable.NativeMethodInfoPtr_GetFocusDelegate_Private_Focusable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Focusable>(intPtr3) : null;
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x0006C2D4 File Offset: 0x0006A4D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 317573, RefRangeEnd = 317576, XrefRangeStart = 317566, XrefRangeEnd = 317573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Focusable GetFirstFocusableChild(VisualElement ve)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Focusable.NativeMethodInfoPtr_GetFirstFocusableChild_Private_Static_Focusable_VisualElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Focusable>(intPtr3) : null;
			}
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x0006C318 File Offset: 0x0006A518
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317579, RefRangeEnd = 317580, XrefRangeStart = 317576, XrefRangeEnd = 317579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ExecuteDefaultAction(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Focusable.NativeMethodInfoPtr_ExecuteDefaultAction_Protected_Virtual_Void_EventBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x0006C368 File Offset: 0x0006A568
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317579, RefRangeEnd = 317580, XrefRangeStart = 317579, XrefRangeEnd = 317580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ExecuteDefaultActionDisabled(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Focusable.NativeMethodInfoPtr_ExecuteDefaultActionDisabled_Internal_Virtual_Void_EventBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x0006C3B8 File Offset: 0x0006A5B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317580, XrefRangeEnd = 317582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessEvent(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Focusable.NativeMethodInfoPtr_ProcessEvent_Private_Void_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x0000A59E File Offset: 0x0000879E
		public Focusable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06001659 RID: 5721 RVA: 0x0006C3FC File Offset: 0x0006A5FC
		// (set) Token: 0x0600165A RID: 5722 RVA: 0x0000A5A7 File Offset: 0x000087A7
		public unsafe bool _focusable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Focusable.NativeFieldInfoPtr__focusable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Focusable.NativeFieldInfoPtr__focusable_k__BackingField)) = value;
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x0600165B RID: 5723 RVA: 0x0006C424 File Offset: 0x0006A624
		// (set) Token: 0x0600165C RID: 5724 RVA: 0x0000A5C2 File Offset: 0x000087C2
		public unsafe int _tabIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Focusable.NativeFieldInfoPtr__tabIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Focusable.NativeFieldInfoPtr__tabIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x0600165D RID: 5725 RVA: 0x0006C44C File Offset: 0x0006A64C
		// (set) Token: 0x0600165E RID: 5726 RVA: 0x0000A5DD File Offset: 0x000087DD
		public unsafe bool m_DelegatesFocus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Focusable.NativeFieldInfoPtr_m_DelegatesFocus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Focusable.NativeFieldInfoPtr_m_DelegatesFocus)) = value;
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x0600165F RID: 5727 RVA: 0x0006C474 File Offset: 0x0006A674
		// (set) Token: 0x06001660 RID: 5728 RVA: 0x0000A5F8 File Offset: 0x000087F8
		public unsafe bool m_ExcludeFromFocusRing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Focusable.NativeFieldInfoPtr_m_ExcludeFromFocusRing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Focusable.NativeFieldInfoPtr_m_ExcludeFromFocusRing)) = value;
			}
		}

		// Token: 0x04000F29 RID: 3881
		private static readonly IntPtr NativeFieldInfoPtr__focusable_k__BackingField;

		// Token: 0x04000F2A RID: 3882
		private static readonly IntPtr NativeFieldInfoPtr__tabIndex_k__BackingField;

		// Token: 0x04000F2B RID: 3883
		private static readonly IntPtr NativeFieldInfoPtr_m_DelegatesFocus;

		// Token: 0x04000F2C RID: 3884
		private static readonly IntPtr NativeFieldInfoPtr_m_ExcludeFromFocusRing;

		// Token: 0x04000F2D RID: 3885
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000F2E RID: 3886
		private static readonly IntPtr NativeMethodInfoPtr_get_focusController_Public_Abstract_Virtual_New_get_FocusController_0;

		// Token: 0x04000F2F RID: 3887
		private static readonly IntPtr NativeMethodInfoPtr_get_focusable_Public_get_Boolean_0;

		// Token: 0x04000F30 RID: 3888
		private static readonly IntPtr NativeMethodInfoPtr_set_focusable_Public_set_Void_Boolean_0;

		// Token: 0x04000F31 RID: 3889
		private static readonly IntPtr NativeMethodInfoPtr_get_tabIndex_Public_get_Int32_0;

		// Token: 0x04000F32 RID: 3890
		private static readonly IntPtr NativeMethodInfoPtr_set_tabIndex_Public_set_Void_Int32_0;

		// Token: 0x04000F33 RID: 3891
		private static readonly IntPtr NativeMethodInfoPtr_get_delegatesFocus_Public_get_Boolean_0;

		// Token: 0x04000F34 RID: 3892
		private static readonly IntPtr NativeMethodInfoPtr_set_delegatesFocus_Public_set_Void_Boolean_0;

		// Token: 0x04000F35 RID: 3893
		private static readonly IntPtr NativeMethodInfoPtr_get_excludeFromFocusRing_Internal_get_Boolean_0;

		// Token: 0x04000F36 RID: 3894
		private static readonly IntPtr NativeMethodInfoPtr_set_excludeFromFocusRing_Internal_set_Void_Boolean_0;

		// Token: 0x04000F37 RID: 3895
		private static readonly IntPtr NativeMethodInfoPtr_get_canGrabFocus_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000F38 RID: 3896
		private static readonly IntPtr NativeMethodInfoPtr_Focus_Public_Virtual_New_Void_0;

		// Token: 0x04000F39 RID: 3897
		private static readonly IntPtr NativeMethodInfoPtr_Blur_Public_Virtual_New_Void_0;

		// Token: 0x04000F3A RID: 3898
		private static readonly IntPtr NativeMethodInfoPtr_BlurImmediately_Internal_Void_0;

		// Token: 0x04000F3B RID: 3899
		private static readonly IntPtr NativeMethodInfoPtr_GetFocusDelegate_Private_Focusable_0;

		// Token: 0x04000F3C RID: 3900
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstFocusableChild_Private_Static_Focusable_VisualElement_0;

		// Token: 0x04000F3D RID: 3901
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteDefaultAction_Protected_Virtual_Void_EventBase_0;

		// Token: 0x04000F3E RID: 3902
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteDefaultActionDisabled_Internal_Virtual_Void_EventBase_0;

		// Token: 0x04000F3F RID: 3903
		private static readonly IntPtr NativeMethodInfoPtr_ProcessEvent_Private_Void_EventBase_0;
	}
}
