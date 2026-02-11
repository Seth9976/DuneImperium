using System;
using dwd.core.input.compositeModule.inputDetection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace dwd.core.input.compositeModule.eventDispatch
{
	// Token: 0x0200009D RID: 157
	public sealed class SelectedObjectEventDispatcher : UIEventDispatcher
	{
		// Token: 0x0600071A RID: 1818 RVA: 0x0001E208 File Offset: 0x0001C408
		// Note: this type is marked as 'beforefieldinit'.
		static SelectedObjectEventDispatcher()
		{
			Il2CppClassPointerStore<SelectedObjectEventDispatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.compositeModule.eventDispatch", "SelectedObjectEventDispatcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectedObjectEventDispatcher>.NativeClassPtr);
			SelectedObjectEventDispatcher.NativeFieldInfoPtr_submitButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedObjectEventDispatcher>.NativeClassPtr, "submitButton");
			SelectedObjectEventDispatcher.NativeFieldInfoPtr_cancelButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedObjectEventDispatcher>.NativeClassPtr, "cancelButton");
			SelectedObjectEventDispatcher.NativeFieldInfoPtr_horizontalMoveAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedObjectEventDispatcher>.NativeClassPtr, "horizontalMoveAxis");
			SelectedObjectEventDispatcher.NativeFieldInfoPtr_verticalMoveAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedObjectEventDispatcher>.NativeClassPtr, "verticalMoveAxis");
			SelectedObjectEventDispatcher.NativeFieldInfoPtr_moveEventsAllowedPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedObjectEventDispatcher>.NativeClassPtr, "moveEventsAllowedPerSecond");
			SelectedObjectEventDispatcher.NativeFieldInfoPtr_moveVectorDeadzone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedObjectEventDispatcher>.NativeClassPtr, "moveVectorDeadzone");
			SelectedObjectEventDispatcher.NativeFieldInfoPtr_suppressSelectableNavigation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedObjectEventDispatcher>.NativeClassPtr, "suppressSelectableNavigation");
			SelectedObjectEventDispatcher.NativeFieldInfoPtr_currentInputDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedObjectEventDispatcher>.NativeClassPtr, "currentInputDetector");
			SelectedObjectEventDispatcher.NativeFieldInfoPtr_currentEventSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedObjectEventDispatcher>.NativeClassPtr, "currentEventSystem");
			SelectedObjectEventDispatcher.NativeFieldInfoPtr_continuousMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedObjectEventDispatcher>.NativeClassPtr, "continuousMovement");
			SelectedObjectEventDispatcher.NativeFieldInfoPtr_lastMoveEventTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedObjectEventDispatcher>.NativeClassPtr, "lastMoveEventTime");
			SelectedObjectEventDispatcher.NativeFieldInfoPtr_ExplicitNoNavigation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedObjectEventDispatcher>.NativeClassPtr, "ExplicitNoNavigation");
			SelectedObjectEventDispatcher.NativeFieldInfoPtr__componentListScratchBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedObjectEventDispatcher>.NativeClassPtr, "_componentListScratchBuffer");
			SelectedObjectEventDispatcher.NativeMethodInfoPtr_DispatchEvents_Public_Virtual_Boolean_InputDetector_EventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedObjectEventDispatcher>.NativeClassPtr, 100664188);
			SelectedObjectEventDispatcher.NativeMethodInfoPtr_dispatchMoveEvents_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedObjectEventDispatcher>.NativeClassPtr, 100664189);
			SelectedObjectEventDispatcher.NativeMethodInfoPtr_getMoveInputVector_Private_Vector2_InputDetector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedObjectEventDispatcher>.NativeClassPtr, 100664190);
			SelectedObjectEventDispatcher.NativeMethodInfoPtr_sendMoveEventToSelectedObject_Private_Void_AxisEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedObjectEventDispatcher>.NativeClassPtr, 100664191);
			SelectedObjectEventDispatcher.NativeMethodInfoPtr_dispatchSubmitEvent_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedObjectEventDispatcher>.NativeClassPtr, 100664192);
			SelectedObjectEventDispatcher.NativeMethodInfoPtr_dispatchCancelEvent_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedObjectEventDispatcher>.NativeClassPtr, 100664193);
			SelectedObjectEventDispatcher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedObjectEventDispatcher>.NativeClassPtr, 100664194);
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x0001E3C8 File Offset: 0x0001C5C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126289, XrefRangeEnd = 1126320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DispatchEvents(InputDetector inputDetector, EventSystem eventSystem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDetector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventSystem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedObjectEventDispatcher.NativeMethodInfoPtr_DispatchEvents_Public_Virtual_Boolean_InputDetector_EventSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x0001E428 File Offset: 0x0001C628
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1126334, RefRangeEnd = 1126335, XrefRangeStart = 1126320, XrefRangeEnd = 1126334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool dispatchMoveEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedObjectEventDispatcher.NativeMethodInfoPtr_dispatchMoveEvents_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x0001E464 File Offset: 0x0001C664
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1126346, RefRangeEnd = 1126347, XrefRangeStart = 1126335, XrefRangeEnd = 1126346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 getMoveInputVector(InputDetector inputDetector)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDetector);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedObjectEventDispatcher.NativeMethodInfoPtr_getMoveInputVector_Private_Vector2_InputDetector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x0001E4B4 File Offset: 0x0001C6B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1126405, RefRangeEnd = 1126406, XrefRangeStart = 1126347, XrefRangeEnd = 1126405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void sendMoveEventToSelectedObject(AxisEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedObjectEventDispatcher.NativeMethodInfoPtr_sendMoveEventToSelectedObject_Private_Void_AxisEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x0001E4F8 File Offset: 0x0001C6F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126406, XrefRangeEnd = 1126419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool dispatchSubmitEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedObjectEventDispatcher.NativeMethodInfoPtr_dispatchSubmitEvent_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x0001E534 File Offset: 0x0001C734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126419, XrefRangeEnd = 1126432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool dispatchCancelEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedObjectEventDispatcher.NativeMethodInfoPtr_dispatchCancelEvent_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x0001E570 File Offset: 0x0001C770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126432, XrefRangeEnd = 1126460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectedObjectEventDispatcher()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectedObjectEventDispatcher>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedObjectEventDispatcher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00005BA2 File Offset: 0x00003DA2
		public SelectedObjectEventDispatcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000723 RID: 1827 RVA: 0x0001E5AC File Offset: 0x0001C7AC
		// (set) Token: 0x06000724 RID: 1828 RVA: 0x00005BAB File Offset: 0x00003DAB
		public unsafe string submitButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedObjectEventDispatcher.NativeFieldInfoPtr_submitButton);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedObjectEventDispatcher.NativeFieldInfoPtr_submitButton), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000725 RID: 1829 RVA: 0x0001E5D4 File Offset: 0x0001C7D4
		// (set) Token: 0x06000726 RID: 1830 RVA: 0x00005BCA File Offset: 0x00003DCA
		public unsafe string cancelButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedObjectEventDispatcher.NativeFieldInfoPtr_cancelButton);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedObjectEventDispatcher.NativeFieldInfoPtr_cancelButton), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000727 RID: 1831 RVA: 0x0001E5FC File Offset: 0x0001C7FC
		// (set) Token: 0x06000728 RID: 1832 RVA: 0x00005BE9 File Offset: 0x00003DE9
		public unsafe string horizontalMoveAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedObjectEventDispatcher.NativeFieldInfoPtr_horizontalMoveAxis);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedObjectEventDispatcher.NativeFieldInfoPtr_horizontalMoveAxis), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000729 RID: 1833 RVA: 0x0001E624 File Offset: 0x0001C824
		// (set) Token: 0x0600072A RID: 1834 RVA: 0x00005C08 File Offset: 0x00003E08
		public unsafe string verticalMoveAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedObjectEventDispatcher.NativeFieldInfoPtr_verticalMoveAxis);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedObjectEventDispatcher.NativeFieldInfoPtr_verticalMoveAxis), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x0600072B RID: 1835 RVA: 0x0001E64C File Offset: 0x0001C84C
		// (set) Token: 0x0600072C RID: 1836 RVA: 0x00005C27 File Offset: 0x00003E27
		public unsafe float moveEventsAllowedPerSecond
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedObjectEventDispatcher.NativeFieldInfoPtr_moveEventsAllowedPerSecond);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedObjectEventDispatcher.NativeFieldInfoPtr_moveEventsAllowedPerSecond)) = value;
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x0600072D RID: 1837 RVA: 0x0001E674 File Offset: 0x0001C874
		// (set) Token: 0x0600072E RID: 1838 RVA: 0x00005C42 File Offset: 0x00003E42
		public unsafe float moveVectorDeadzone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedObjectEventDispatcher.NativeFieldInfoPtr_moveVectorDeadzone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedObjectEventDispatcher.NativeFieldInfoPtr_moveVectorDeadzone)) = value;
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x0600072F RID: 1839 RVA: 0x0001E69C File Offset: 0x0001C89C
		// (set) Token: 0x06000730 RID: 1840 RVA: 0x00005C5D File Offset: 0x00003E5D
		public unsafe bool suppressSelectableNavigation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedObjectEventDispatcher.NativeFieldInfoPtr_suppressSelectableNavigation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedObjectEventDispatcher.NativeFieldInfoPtr_suppressSelectableNavigation)) = value;
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000731 RID: 1841 RVA: 0x0001E6C4 File Offset: 0x0001C8C4
		// (set) Token: 0x06000732 RID: 1842 RVA: 0x00005C78 File Offset: 0x00003E78
		public unsafe InputDetector currentInputDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedObjectEventDispatcher.NativeFieldInfoPtr_currentInputDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedObjectEventDispatcher.NativeFieldInfoPtr_currentInputDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000733 RID: 1843 RVA: 0x0001E6F4 File Offset: 0x0001C8F4
		// (set) Token: 0x06000734 RID: 1844 RVA: 0x00005C97 File Offset: 0x00003E97
		public unsafe EventSystem currentEventSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedObjectEventDispatcher.NativeFieldInfoPtr_currentEventSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedObjectEventDispatcher.NativeFieldInfoPtr_currentEventSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000735 RID: 1845 RVA: 0x0001E724 File Offset: 0x0001C924
		// (set) Token: 0x06000736 RID: 1846 RVA: 0x00005CB6 File Offset: 0x00003EB6
		public unsafe bool continuousMovement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedObjectEventDispatcher.NativeFieldInfoPtr_continuousMovement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedObjectEventDispatcher.NativeFieldInfoPtr_continuousMovement)) = value;
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000737 RID: 1847 RVA: 0x0001E74C File Offset: 0x0001C94C
		// (set) Token: 0x06000738 RID: 1848 RVA: 0x00005CD1 File Offset: 0x00003ED1
		public unsafe float lastMoveEventTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedObjectEventDispatcher.NativeFieldInfoPtr_lastMoveEventTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedObjectEventDispatcher.NativeFieldInfoPtr_lastMoveEventTime)) = value;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000739 RID: 1849 RVA: 0x0001E774 File Offset: 0x0001C974
		// (set) Token: 0x0600073A RID: 1850 RVA: 0x00005CEC File Offset: 0x00003EEC
		public unsafe static Navigation ExplicitNoNavigation
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Navigation>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(SelectedObjectEventDispatcher.NativeFieldInfoPtr_ExplicitNoNavigation, intPtr);
				return new Navigation(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Navigation>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SelectedObjectEventDispatcher.NativeFieldInfoPtr_ExplicitNoNavigation, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x0600073B RID: 1851 RVA: 0x0001E7B0 File Offset: 0x0001C9B0
		// (set) Token: 0x0600073C RID: 1852 RVA: 0x00005D03 File Offset: 0x00003F03
		public unsafe List<Component> _componentListScratchBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedObjectEventDispatcher.NativeFieldInfoPtr__componentListScratchBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Component>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedObjectEventDispatcher.NativeFieldInfoPtr__componentListScratchBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000465 RID: 1125
		private static readonly IntPtr NativeFieldInfoPtr_submitButton;

		// Token: 0x04000466 RID: 1126
		private static readonly IntPtr NativeFieldInfoPtr_cancelButton;

		// Token: 0x04000467 RID: 1127
		private static readonly IntPtr NativeFieldInfoPtr_horizontalMoveAxis;

		// Token: 0x04000468 RID: 1128
		private static readonly IntPtr NativeFieldInfoPtr_verticalMoveAxis;

		// Token: 0x04000469 RID: 1129
		private static readonly IntPtr NativeFieldInfoPtr_moveEventsAllowedPerSecond;

		// Token: 0x0400046A RID: 1130
		private static readonly IntPtr NativeFieldInfoPtr_moveVectorDeadzone;

		// Token: 0x0400046B RID: 1131
		private static readonly IntPtr NativeFieldInfoPtr_suppressSelectableNavigation;

		// Token: 0x0400046C RID: 1132
		private static readonly IntPtr NativeFieldInfoPtr_currentInputDetector;

		// Token: 0x0400046D RID: 1133
		private static readonly IntPtr NativeFieldInfoPtr_currentEventSystem;

		// Token: 0x0400046E RID: 1134
		private static readonly IntPtr NativeFieldInfoPtr_continuousMovement;

		// Token: 0x0400046F RID: 1135
		private static readonly IntPtr NativeFieldInfoPtr_lastMoveEventTime;

		// Token: 0x04000470 RID: 1136
		private static readonly IntPtr NativeFieldInfoPtr_ExplicitNoNavigation;

		// Token: 0x04000471 RID: 1137
		private static readonly IntPtr NativeFieldInfoPtr__componentListScratchBuffer;

		// Token: 0x04000472 RID: 1138
		private static readonly IntPtr NativeMethodInfoPtr_DispatchEvents_Public_Virtual_Boolean_InputDetector_EventSystem_0;

		// Token: 0x04000473 RID: 1139
		private static readonly IntPtr NativeMethodInfoPtr_dispatchMoveEvents_Private_Boolean_0;

		// Token: 0x04000474 RID: 1140
		private static readonly IntPtr NativeMethodInfoPtr_getMoveInputVector_Private_Vector2_InputDetector_0;

		// Token: 0x04000475 RID: 1141
		private static readonly IntPtr NativeMethodInfoPtr_sendMoveEventToSelectedObject_Private_Void_AxisEventData_0;

		// Token: 0x04000476 RID: 1142
		private static readonly IntPtr NativeMethodInfoPtr_dispatchSubmitEvent_Private_Boolean_0;

		// Token: 0x04000477 RID: 1143
		private static readonly IntPtr NativeMethodInfoPtr_dispatchCancelEvent_Private_Boolean_0;

		// Token: 0x04000478 RID: 1144
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
