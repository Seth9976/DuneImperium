using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000231 RID: 561
	public class VisualElementPanelActivator : Object
	{
		// Token: 0x0600297C RID: 10620 RVA: 0x000B5760 File Offset: 0x000B3960
		// Note: this type is marked as 'beforefieldinit'.
		static VisualElementPanelActivator()
		{
			Il2CppClassPointerStore<VisualElementPanelActivator>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "VisualElementPanelActivator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualElementPanelActivator>.NativeClassPtr);
			VisualElementPanelActivator.NativeFieldInfoPtr_m_Activatable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementPanelActivator>.NativeClassPtr, "m_Activatable");
			VisualElementPanelActivator.NativeFieldInfoPtr__isActive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementPanelActivator>.NativeClassPtr, "<isActive>k__BackingField");
			VisualElementPanelActivator.NativeFieldInfoPtr__isDetaching_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementPanelActivator>.NativeClassPtr, "<isDetaching>k__BackingField");
			VisualElementPanelActivator.NativeFieldInfoPtr_m_OnAttachToPanelCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementPanelActivator>.NativeClassPtr, "m_OnAttachToPanelCallback");
			VisualElementPanelActivator.NativeFieldInfoPtr_m_OnDetachFromPanelCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementPanelActivator>.NativeClassPtr, "m_OnDetachFromPanelCallback");
			VisualElementPanelActivator.NativeMethodInfoPtr_get_isActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementPanelActivator>.NativeClassPtr, 100669532);
			VisualElementPanelActivator.NativeMethodInfoPtr_set_isActive_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementPanelActivator>.NativeClassPtr, 100669533);
			VisualElementPanelActivator.NativeMethodInfoPtr_get_isDetaching_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementPanelActivator>.NativeClassPtr, 100669534);
			VisualElementPanelActivator.NativeMethodInfoPtr_set_isDetaching_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementPanelActivator>.NativeClassPtr, 100669535);
			VisualElementPanelActivator.NativeMethodInfoPtr__ctor_Public_Void_IVisualElementPanelActivatable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementPanelActivator>.NativeClassPtr, 100669536);
			VisualElementPanelActivator.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementPanelActivator>.NativeClassPtr, 100669537);
			VisualElementPanelActivator.NativeMethodInfoPtr_SendActivation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementPanelActivator>.NativeClassPtr, 100669538);
			VisualElementPanelActivator.NativeMethodInfoPtr_SendDeactivation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementPanelActivator>.NativeClassPtr, 100669539);
			VisualElementPanelActivator.NativeMethodInfoPtr_OnEnter_Private_Void_AttachToPanelEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementPanelActivator>.NativeClassPtr, 100669540);
			VisualElementPanelActivator.NativeMethodInfoPtr_OnLeave_Private_Void_DetachFromPanelEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementPanelActivator>.NativeClassPtr, 100669541);
		}

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x0600297D RID: 10621 RVA: 0x000B58BC File Offset: 0x000B3ABC
		// (set) Token: 0x0600297E RID: 10622 RVA: 0x000B58F8 File Offset: 0x000B3AF8
		public unsafe bool isActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementPanelActivator.NativeMethodInfoPtr_get_isActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementPanelActivator.NativeMethodInfoPtr_set_isActive_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x0600297F RID: 10623 RVA: 0x000B5938 File Offset: 0x000B3B38
		// (set) Token: 0x06002980 RID: 10624 RVA: 0x000B5974 File Offset: 0x000B3B74
		public unsafe bool isDetaching
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementPanelActivator.NativeMethodInfoPtr_get_isDetaching_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementPanelActivator.NativeMethodInfoPtr_set_isDetaching_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002981 RID: 10625 RVA: 0x000B59B4 File Offset: 0x000B3BB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346677, RefRangeEnd = 346678, XrefRangeStart = 346661, XrefRangeEnd = 346677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisualElementPanelActivator(IVisualElementPanelActivatable activatable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualElementPanelActivator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activatable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementPanelActivator.NativeMethodInfoPtr__ctor_Public_Void_IVisualElementPanelActivatable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002982 RID: 10626 RVA: 0x000B5A00 File Offset: 0x000B3C00
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 346692, RefRangeEnd = 346698, XrefRangeStart = 346678, XrefRangeEnd = 346692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActive(bool action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref action;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementPanelActivator.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002983 RID: 10627 RVA: 0x000B5A40 File Offset: 0x000B3C40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346703, RefRangeEnd = 346704, XrefRangeStart = 346698, XrefRangeEnd = 346703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendActivation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementPanelActivator.NativeMethodInfoPtr_SendActivation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002984 RID: 10628 RVA: 0x000B5A74 File Offset: 0x000B3C74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 346709, RefRangeEnd = 346711, XrefRangeStart = 346704, XrefRangeEnd = 346709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendDeactivation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementPanelActivator.NativeMethodInfoPtr_SendDeactivation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002985 RID: 10629 RVA: 0x000B5AA8 File Offset: 0x000B3CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346711, XrefRangeEnd = 346712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnter(AttachToPanelEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementPanelActivator.NativeMethodInfoPtr_OnEnter_Private_Void_AttachToPanelEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002986 RID: 10630 RVA: 0x000B5AEC File Offset: 0x000B3CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346712, XrefRangeEnd = 346714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLeave(DetachFromPanelEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementPanelActivator.NativeMethodInfoPtr_OnLeave_Private_Void_DetachFromPanelEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002987 RID: 10631 RVA: 0x00010B2A File Offset: 0x0000ED2A
		public VisualElementPanelActivator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x06002988 RID: 10632 RVA: 0x000B5B30 File Offset: 0x000B3D30
		// (set) Token: 0x06002989 RID: 10633 RVA: 0x00010B33 File Offset: 0x0000ED33
		public unsafe IVisualElementPanelActivatable m_Activatable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementPanelActivator.NativeFieldInfoPtr_m_Activatable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IVisualElementPanelActivatable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementPanelActivator.NativeFieldInfoPtr_m_Activatable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x0600298A RID: 10634 RVA: 0x000B5B60 File Offset: 0x000B3D60
		// (set) Token: 0x0600298B RID: 10635 RVA: 0x00010B52 File Offset: 0x0000ED52
		public unsafe bool _isActive_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementPanelActivator.NativeFieldInfoPtr__isActive_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementPanelActivator.NativeFieldInfoPtr__isActive_k__BackingField)) = value;
			}
		}

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x0600298C RID: 10636 RVA: 0x000B5B88 File Offset: 0x000B3D88
		// (set) Token: 0x0600298D RID: 10637 RVA: 0x00010B6D File Offset: 0x0000ED6D
		public unsafe bool _isDetaching_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementPanelActivator.NativeFieldInfoPtr__isDetaching_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementPanelActivator.NativeFieldInfoPtr__isDetaching_k__BackingField)) = value;
			}
		}

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x0600298E RID: 10638 RVA: 0x000B5BB0 File Offset: 0x000B3DB0
		// (set) Token: 0x0600298F RID: 10639 RVA: 0x00010B88 File Offset: 0x0000ED88
		public unsafe EventCallback<AttachToPanelEvent> m_OnAttachToPanelCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementPanelActivator.NativeFieldInfoPtr_m_OnAttachToPanelCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventCallback<AttachToPanelEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementPanelActivator.NativeFieldInfoPtr_m_OnAttachToPanelCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x06002990 RID: 10640 RVA: 0x000B5BE0 File Offset: 0x000B3DE0
		// (set) Token: 0x06002991 RID: 10641 RVA: 0x00010BA7 File Offset: 0x0000EDA7
		public unsafe EventCallback<DetachFromPanelEvent> m_OnDetachFromPanelCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementPanelActivator.NativeFieldInfoPtr_m_OnDetachFromPanelCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventCallback<DetachFromPanelEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementPanelActivator.NativeFieldInfoPtr_m_OnDetachFromPanelCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D8F RID: 7567
		private static readonly IntPtr NativeFieldInfoPtr_m_Activatable;

		// Token: 0x04001D90 RID: 7568
		private static readonly IntPtr NativeFieldInfoPtr__isActive_k__BackingField;

		// Token: 0x04001D91 RID: 7569
		private static readonly IntPtr NativeFieldInfoPtr__isDetaching_k__BackingField;

		// Token: 0x04001D92 RID: 7570
		private static readonly IntPtr NativeFieldInfoPtr_m_OnAttachToPanelCallback;

		// Token: 0x04001D93 RID: 7571
		private static readonly IntPtr NativeFieldInfoPtr_m_OnDetachFromPanelCallback;

		// Token: 0x04001D94 RID: 7572
		private static readonly IntPtr NativeMethodInfoPtr_get_isActive_Public_get_Boolean_0;

		// Token: 0x04001D95 RID: 7573
		private static readonly IntPtr NativeMethodInfoPtr_set_isActive_Private_set_Void_Boolean_0;

		// Token: 0x04001D96 RID: 7574
		private static readonly IntPtr NativeMethodInfoPtr_get_isDetaching_Public_get_Boolean_0;

		// Token: 0x04001D97 RID: 7575
		private static readonly IntPtr NativeMethodInfoPtr_set_isDetaching_Private_set_Void_Boolean_0;

		// Token: 0x04001D98 RID: 7576
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IVisualElementPanelActivatable_0;

		// Token: 0x04001D99 RID: 7577
		private static readonly IntPtr NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0;

		// Token: 0x04001D9A RID: 7578
		private static readonly IntPtr NativeMethodInfoPtr_SendActivation_Public_Void_0;

		// Token: 0x04001D9B RID: 7579
		private static readonly IntPtr NativeMethodInfoPtr_SendDeactivation_Public_Void_0;

		// Token: 0x04001D9C RID: 7580
		private static readonly IntPtr NativeMethodInfoPtr_OnEnter_Private_Void_AttachToPanelEvent_0;

		// Token: 0x04001D9D RID: 7581
		private static readonly IntPtr NativeMethodInfoPtr_OnLeave_Private_Void_DetachFromPanelEvent_0;
	}
}
