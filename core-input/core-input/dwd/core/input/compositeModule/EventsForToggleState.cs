using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace dwd.core.input.compositeModule
{
	// Token: 0x0200008A RID: 138
	public class EventsForToggleState : MonoBehaviour
	{
		// Token: 0x06000605 RID: 1541 RVA: 0x00019EB0 File Offset: 0x000180B0
		// Note: this type is marked as 'beforefieldinit'.
		static EventsForToggleState()
		{
			Il2CppClassPointerStore<EventsForToggleState>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.compositeModule", "EventsForToggleState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForToggleState>.NativeClassPtr);
			EventsForToggleState.NativeFieldInfoPtr_onToggleOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForToggleState>.NativeClassPtr, "onToggleOn");
			EventsForToggleState.NativeFieldInfoPtr_onToggleOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForToggleState>.NativeClassPtr, "onToggleOff");
			EventsForToggleState.NativeMethodInfoPtr_get_OnToggleOn_Public_get_UnityEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForToggleState>.NativeClassPtr, 100664041);
			EventsForToggleState.NativeMethodInfoPtr_get_OnToggleOff_Public_get_UnityEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForToggleState>.NativeClassPtr, 100664042);
			EventsForToggleState.NativeMethodInfoPtr_Event_OnToggle_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForToggleState>.NativeClassPtr, 100664043);
			EventsForToggleState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForToggleState>.NativeClassPtr, 100664044);
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000606 RID: 1542 RVA: 0x00019F58 File Offset: 0x00018158
		public unsafe UnityEvent OnToggleOn
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForToggleState.NativeMethodInfoPtr_get_OnToggleOn_Public_get_UnityEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x00019F98 File Offset: 0x00018198
		public unsafe UnityEvent OnToggleOff
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForToggleState.NativeMethodInfoPtr_get_OnToggleOff_Public_get_UnityEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr3) : null;
			}
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00019FD8 File Offset: 0x000181D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125046, XrefRangeEnd = 1125049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_OnToggle(bool toggle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref toggle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForToggleState.NativeMethodInfoPtr_Event_OnToggle_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x0001A018 File Offset: 0x00018218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125049, XrefRangeEnd = 1125059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsForToggleState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForToggleState>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForToggleState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x000054C4 File Offset: 0x000036C4
		public EventsForToggleState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600060B RID: 1547 RVA: 0x0001A054 File Offset: 0x00018254
		// (set) Token: 0x0600060C RID: 1548 RVA: 0x000054CD File Offset: 0x000036CD
		public unsafe UnityEvent onToggleOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForToggleState.NativeFieldInfoPtr_onToggleOn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForToggleState.NativeFieldInfoPtr_onToggleOn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x0600060D RID: 1549 RVA: 0x0001A084 File Offset: 0x00018284
		// (set) Token: 0x0600060E RID: 1550 RVA: 0x000054EC File Offset: 0x000036EC
		public unsafe UnityEvent onToggleOff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForToggleState.NativeFieldInfoPtr_onToggleOff);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForToggleState.NativeFieldInfoPtr_onToggleOff), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003A5 RID: 933
		private static readonly IntPtr NativeFieldInfoPtr_onToggleOn;

		// Token: 0x040003A6 RID: 934
		private static readonly IntPtr NativeFieldInfoPtr_onToggleOff;

		// Token: 0x040003A7 RID: 935
		private static readonly IntPtr NativeMethodInfoPtr_get_OnToggleOn_Public_get_UnityEvent_0;

		// Token: 0x040003A8 RID: 936
		private static readonly IntPtr NativeMethodInfoPtr_get_OnToggleOff_Public_get_UnityEvent_0;

		// Token: 0x040003A9 RID: 937
		private static readonly IntPtr NativeMethodInfoPtr_Event_OnToggle_Public_Void_Boolean_0;

		// Token: 0x040003AA RID: 938
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
