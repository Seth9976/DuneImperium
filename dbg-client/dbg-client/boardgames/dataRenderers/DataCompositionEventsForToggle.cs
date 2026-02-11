using System;
using dwd.core;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.dataRenderers
{
	// Token: 0x02000143 RID: 323
	public class DataCompositionEventsForToggle : Subscriber
	{
		// Token: 0x06000ECD RID: 3789 RVA: 0x0004CC8C File Offset: 0x0004AE8C
		// Note: this type is marked as 'beforefieldinit'.
		static DataCompositionEventsForToggle()
		{
			Il2CppClassPointerStore<DataCompositionEventsForToggle>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.dataRenderers", "DataCompositionEventsForToggle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataCompositionEventsForToggle>.NativeClassPtr);
			DataCompositionEventsForToggle.NativeFieldInfoPtr_dataCompositionEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataCompositionEventsForToggle>.NativeClassPtr, "dataCompositionEvents");
			DataCompositionEventsForToggle.NativeMethodInfoPtr_Event_FireEvent_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCompositionEventsForToggle>.NativeClassPtr, 100665454);
			DataCompositionEventsForToggle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCompositionEventsForToggle>.NativeClassPtr, 100665455);
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x0004CCF8 File Offset: 0x0004AEF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512684, XrefRangeEnd = 512688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_FireEvent(bool isOn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isOn;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataCompositionEventsForToggle.NativeMethodInfoPtr_Event_FireEvent_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x0004CD38 File Offset: 0x0004AF38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512688, XrefRangeEnd = 512694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataCompositionEventsForToggle()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataCompositionEventsForToggle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataCompositionEventsForToggle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x0000921C File Offset: 0x0000741C
		public DataCompositionEventsForToggle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000ED1 RID: 3793 RVA: 0x0004CD74 File Offset: 0x0004AF74
		// (set) Token: 0x06000ED2 RID: 3794 RVA: 0x00009225 File Offset: 0x00007425
		public unsafe UnityToggleEventForDataComp dataCompositionEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCompositionEventsForToggle.NativeFieldInfoPtr_dataCompositionEvents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityToggleEventForDataComp>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCompositionEventsForToggle.NativeFieldInfoPtr_dataCompositionEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000924 RID: 2340
		private static readonly IntPtr NativeFieldInfoPtr_dataCompositionEvents;

		// Token: 0x04000925 RID: 2341
		private static readonly IntPtr NativeMethodInfoPtr_Event_FireEvent_Public_Void_Boolean_0;

		// Token: 0x04000926 RID: 2342
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
