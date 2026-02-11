using System;
using dwd.core.input.compositeModule.inputDetection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.EventSystems;

namespace dwd.core.input.compositeModule.eventDispatch
{
	// Token: 0x0200009E RID: 158
	public class UIEventDispatcher : UIBehaviour
	{
		// Token: 0x0600073D RID: 1853 RVA: 0x0001E7E0 File Offset: 0x0001C9E0
		// Note: this type is marked as 'beforefieldinit'.
		static UIEventDispatcher()
		{
			Il2CppClassPointerStore<UIEventDispatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.compositeModule.eventDispatch", "UIEventDispatcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIEventDispatcher>.NativeClassPtr);
			UIEventDispatcher.NativeFieldInfoPtr_eventDispatchStrategy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIEventDispatcher>.NativeClassPtr, "eventDispatchStrategy");
			UIEventDispatcher.NativeFieldInfoPtr_baseEventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIEventDispatcher>.NativeClassPtr, "baseEventData");
			UIEventDispatcher.NativeFieldInfoPtr_axisEventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIEventDispatcher>.NativeClassPtr, "axisEventData");
			UIEventDispatcher.NativeMethodInfoPtr_get_StrategyName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIEventDispatcher>.NativeClassPtr, 100664196);
			UIEventDispatcher.NativeMethodInfoPtr_DispatchEvents_Public_Abstract_Virtual_New_Boolean_InputDetector_EventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIEventDispatcher>.NativeClassPtr, 100664197);
			UIEventDispatcher.NativeMethodInfoPtr_getBaseEventData_Protected_BaseEventData_EventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIEventDispatcher>.NativeClassPtr, 100664198);
			UIEventDispatcher.NativeMethodInfoPtr_getAxisEventData_Protected_AxisEventData_EventSystem_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIEventDispatcher>.NativeClassPtr, 100664199);
			UIEventDispatcher.NativeMethodInfoPtr_determineMoveDirection_Private_Static_MoveDirection_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIEventDispatcher>.NativeClassPtr, 100664200);
			UIEventDispatcher.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIEventDispatcher>.NativeClassPtr, 100664201);
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x0001E8C4 File Offset: 0x0001CAC4
		public unsafe virtual string StrategyName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIEventDispatcher.NativeMethodInfoPtr_get_StrategyName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x0001E8FC File Offset: 0x0001CAFC
		[CallerCount(0)]
		public unsafe virtual bool DispatchEvents(InputDetector inputDetector, EventSystem eventSystem)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIEventDispatcher.NativeMethodInfoPtr_DispatchEvents_Public_Abstract_Virtual_New_Boolean_InputDetector_EventSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x0001E968 File Offset: 0x0001CB68
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1126465, RefRangeEnd = 1126469, XrefRangeStart = 1126460, XrefRangeEnd = 1126465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseEventData getBaseEventData(EventSystem eventSystem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventSystem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIEventDispatcher.NativeMethodInfoPtr_getBaseEventData_Protected_BaseEventData_EventSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseEventData>(intPtr3) : null;
			}
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x0001E9B8 File Offset: 0x0001CBB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126469, XrefRangeEnd = 1126478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AxisEventData getAxisEventData(EventSystem eventSystem, float x, float y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventSystem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIEventDispatcher.NativeMethodInfoPtr_getAxisEventData_Protected_AxisEventData_EventSystem_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AxisEventData>(intPtr3) : null;
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x0001EA24 File Offset: 0x0001CC24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126478, XrefRangeEnd = 1126482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MoveDirection determineMoveDirection(float x, float y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIEventDispatcher.NativeMethodInfoPtr_determineMoveDirection_Private_Static_MoveDirection_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x0001EA70 File Offset: 0x0001CC70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126482, XrefRangeEnd = 1126487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIEventDispatcher()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIEventDispatcher>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIEventDispatcher.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x00005D22 File Offset: 0x00003F22
		public UIEventDispatcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000745 RID: 1861 RVA: 0x0001EAAC File Offset: 0x0001CCAC
		// (set) Token: 0x06000746 RID: 1862 RVA: 0x00005D2B File Offset: 0x00003F2B
		public unsafe string eventDispatchStrategy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIEventDispatcher.NativeFieldInfoPtr_eventDispatchStrategy);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIEventDispatcher.NativeFieldInfoPtr_eventDispatchStrategy), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000747 RID: 1863 RVA: 0x0001EAD4 File Offset: 0x0001CCD4
		// (set) Token: 0x06000748 RID: 1864 RVA: 0x00005D4A File Offset: 0x00003F4A
		public unsafe BaseEventData baseEventData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIEventDispatcher.NativeFieldInfoPtr_baseEventData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseEventData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIEventDispatcher.NativeFieldInfoPtr_baseEventData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000749 RID: 1865 RVA: 0x0001EB04 File Offset: 0x0001CD04
		// (set) Token: 0x0600074A RID: 1866 RVA: 0x00005D69 File Offset: 0x00003F69
		public unsafe AxisEventData axisEventData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIEventDispatcher.NativeFieldInfoPtr_axisEventData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AxisEventData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIEventDispatcher.NativeFieldInfoPtr_axisEventData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000479 RID: 1145
		private static readonly IntPtr NativeFieldInfoPtr_eventDispatchStrategy;

		// Token: 0x0400047A RID: 1146
		private static readonly IntPtr NativeFieldInfoPtr_baseEventData;

		// Token: 0x0400047B RID: 1147
		private static readonly IntPtr NativeFieldInfoPtr_axisEventData;

		// Token: 0x0400047C RID: 1148
		private static readonly IntPtr NativeMethodInfoPtr_get_StrategyName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400047D RID: 1149
		private static readonly IntPtr NativeMethodInfoPtr_DispatchEvents_Public_Abstract_Virtual_New_Boolean_InputDetector_EventSystem_0;

		// Token: 0x0400047E RID: 1150
		private static readonly IntPtr NativeMethodInfoPtr_getBaseEventData_Protected_BaseEventData_EventSystem_0;

		// Token: 0x0400047F RID: 1151
		private static readonly IntPtr NativeMethodInfoPtr_getAxisEventData_Protected_AxisEventData_EventSystem_Single_Single_0;

		// Token: 0x04000480 RID: 1152
		private static readonly IntPtr NativeMethodInfoPtr_determineMoveDirection_Private_Static_MoveDirection_Single_Single_0;

		// Token: 0x04000481 RID: 1153
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
