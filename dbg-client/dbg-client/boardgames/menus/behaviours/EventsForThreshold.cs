using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace boardgames.menus.behaviours
{
	// Token: 0x020001B9 RID: 441
	public class EventsForThreshold : MonoBehaviour
	{
		// Token: 0x060013DF RID: 5087 RVA: 0x0005DE0C File Offset: 0x0005C00C
		// Note: this type is marked as 'beforefieldinit'.
		static EventsForThreshold()
		{
			Il2CppClassPointerStore<EventsForThreshold>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.behaviours", "EventsForThreshold");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForThreshold>.NativeClassPtr);
			EventsForThreshold.NativeFieldInfoPtr_threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForThreshold>.NativeClassPtr, "threshold");
			EventsForThreshold.NativeFieldInfoPtr_onTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForThreshold>.NativeClassPtr, "onTrigger");
			EventsForThreshold.NativeFieldInfoPtr_onUnder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForThreshold>.NativeClassPtr, "onUnder");
			EventsForThreshold.NativeMethodInfoPtr_Event_Trigger_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForThreshold>.NativeClassPtr, 100666225);
			EventsForThreshold.NativeMethodInfoPtr_Event_UnderThreshold_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForThreshold>.NativeClassPtr, 100666226);
			EventsForThreshold.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForThreshold>.NativeClassPtr, 100666227);
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x0005DEB4 File Offset: 0x0005C0B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519830, XrefRangeEnd = 519834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Trigger(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForThreshold.NativeMethodInfoPtr_Event_Trigger_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x0005DEF4 File Offset: 0x0005C0F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519834, XrefRangeEnd = 519838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_UnderThreshold(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForThreshold.NativeMethodInfoPtr_Event_UnderThreshold_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x0005DF34 File Offset: 0x0005C134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519838, XrefRangeEnd = 519851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsForThreshold()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForThreshold>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForThreshold.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x0000B544 File Offset: 0x00009744
		public EventsForThreshold(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x060013E4 RID: 5092 RVA: 0x0005DF70 File Offset: 0x0005C170
		// (set) Token: 0x060013E5 RID: 5093 RVA: 0x0000B54D File Offset: 0x0000974D
		public unsafe float threshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForThreshold.NativeFieldInfoPtr_threshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForThreshold.NativeFieldInfoPtr_threshold)) = value;
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x060013E6 RID: 5094 RVA: 0x0005DF98 File Offset: 0x0005C198
		// (set) Token: 0x060013E7 RID: 5095 RVA: 0x0000B568 File Offset: 0x00009768
		public unsafe UnityEvent<bool> onTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForThreshold.NativeFieldInfoPtr_onTrigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForThreshold.NativeFieldInfoPtr_onTrigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x060013E8 RID: 5096 RVA: 0x0005DFC8 File Offset: 0x0005C1C8
		// (set) Token: 0x060013E9 RID: 5097 RVA: 0x0000B587 File Offset: 0x00009787
		public unsafe UnityEvent<bool> onUnder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForThreshold.NativeFieldInfoPtr_onUnder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForThreshold.NativeFieldInfoPtr_onUnder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C44 RID: 3140
		private static readonly IntPtr NativeFieldInfoPtr_threshold;

		// Token: 0x04000C45 RID: 3141
		private static readonly IntPtr NativeFieldInfoPtr_onTrigger;

		// Token: 0x04000C46 RID: 3142
		private static readonly IntPtr NativeFieldInfoPtr_onUnder;

		// Token: 0x04000C47 RID: 3143
		private static readonly IntPtr NativeMethodInfoPtr_Event_Trigger_Public_Void_Single_0;

		// Token: 0x04000C48 RID: 3144
		private static readonly IntPtr NativeMethodInfoPtr_Event_UnderThreshold_Public_Void_Single_0;

		// Token: 0x04000C49 RID: 3145
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
