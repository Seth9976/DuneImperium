using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Events;

namespace dwd.core.util
{
	// Token: 0x02000089 RID: 137
	[Serializable]
	public class BoolUnityEvents : Object
	{
		// Token: 0x060009F7 RID: 2551 RVA: 0x00039B44 File Offset: 0x00037D44
		// Note: this type is marked as 'beforefieldinit'.
		static BoolUnityEvents()
		{
			Il2CppClassPointerStore<BoolUnityEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.util", "BoolUnityEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoolUnityEvents>.NativeClassPtr);
			BoolUnityEvents.NativeFieldInfoPtr_eventTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoolUnityEvents>.NativeClassPtr, "eventTypes");
			BoolUnityEvents.NativeFieldInfoPtr_onEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoolUnityEvents>.NativeClassPtr, "onEvent");
			BoolUnityEvents.NativeFieldInfoPtr_onInverse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoolUnityEvents>.NativeClassPtr, "onInverse");
			BoolUnityEvents.NativeFieldInfoPtr_onTrue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoolUnityEvents>.NativeClassPtr, "onTrue");
			BoolUnityEvents.NativeFieldInfoPtr_onFalse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoolUnityEvents>.NativeClassPtr, "onFalse");
			BoolUnityEvents.NativeMethodInfoPtr_get_OnEvent_Public_get_UnityEvent_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolUnityEvents>.NativeClassPtr, 100664687);
			BoolUnityEvents.NativeMethodInfoPtr_get_OnInverse_Public_get_UnityEvent_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolUnityEvents>.NativeClassPtr, 100664688);
			BoolUnityEvents.NativeMethodInfoPtr_get_OnTrue_Public_get_UnityEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolUnityEvents>.NativeClassPtr, 100664689);
			BoolUnityEvents.NativeMethodInfoPtr_get_OnFalse_Public_get_UnityEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolUnityEvents>.NativeClassPtr, 100664690);
			BoolUnityEvents.NativeMethodInfoPtr_Invoke_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolUnityEvents>.NativeClassPtr, 100664691);
			BoolUnityEvents.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolUnityEvents>.NativeClassPtr, 100664692);
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x060009F8 RID: 2552 RVA: 0x00039C50 File Offset: 0x00037E50
		public unsafe UnityEvent<bool> OnEvent
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolUnityEvents.NativeMethodInfoPtr_get_OnEvent_Public_get_UnityEvent_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEvent<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x060009F9 RID: 2553 RVA: 0x00039C90 File Offset: 0x00037E90
		public unsafe UnityEvent<bool> OnInverse
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolUnityEvents.NativeMethodInfoPtr_get_OnInverse_Public_get_UnityEvent_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEvent<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x060009FA RID: 2554 RVA: 0x00039CD0 File Offset: 0x00037ED0
		public unsafe UnityEvent OnTrue
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolUnityEvents.NativeMethodInfoPtr_get_OnTrue_Public_get_UnityEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x060009FB RID: 2555 RVA: 0x00039D10 File Offset: 0x00037F10
		public unsafe UnityEvent OnFalse
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolUnityEvents.NativeMethodInfoPtr_get_OnFalse_Public_get_UnityEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr3) : null;
			}
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x00039D50 File Offset: 0x00037F50
		[CallerCount(41)]
		[CachedScanResults(RefRangeStart = 862440, RefRangeEnd = 862481, XrefRangeStart = 862432, XrefRangeEnd = 862440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolUnityEvents.NativeMethodInfoPtr_Invoke_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x00039D90 File Offset: 0x00037F90
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 862503, RefRangeEnd = 862529, XrefRangeStart = 862481, XrefRangeEnd = 862503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoolUnityEvents()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoolUnityEvents>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolUnityEvents.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x000057CF File Offset: 0x000039CF
		public BoolUnityEvents(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x060009FF RID: 2559 RVA: 0x00039DCC File Offset: 0x00037FCC
		// (set) Token: 0x06000A00 RID: 2560 RVA: 0x000057D8 File Offset: 0x000039D8
		public unsafe BoolUnityEvents.EventType eventTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolUnityEvents.NativeFieldInfoPtr_eventTypes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolUnityEvents.NativeFieldInfoPtr_eventTypes)) = value;
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000A01 RID: 2561 RVA: 0x00039DF4 File Offset: 0x00037FF4
		// (set) Token: 0x06000A02 RID: 2562 RVA: 0x000057F3 File Offset: 0x000039F3
		public unsafe UnityEvent<bool> onEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolUnityEvents.NativeFieldInfoPtr_onEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolUnityEvents.NativeFieldInfoPtr_onEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000A03 RID: 2563 RVA: 0x00039E24 File Offset: 0x00038024
		// (set) Token: 0x06000A04 RID: 2564 RVA: 0x00005812 File Offset: 0x00003A12
		public unsafe UnityEvent<bool> onInverse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolUnityEvents.NativeFieldInfoPtr_onInverse);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolUnityEvents.NativeFieldInfoPtr_onInverse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000A05 RID: 2565 RVA: 0x00039E54 File Offset: 0x00038054
		// (set) Token: 0x06000A06 RID: 2566 RVA: 0x00005831 File Offset: 0x00003A31
		public unsafe UnityEvent onTrue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolUnityEvents.NativeFieldInfoPtr_onTrue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolUnityEvents.NativeFieldInfoPtr_onTrue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000A07 RID: 2567 RVA: 0x00039E84 File Offset: 0x00038084
		// (set) Token: 0x06000A08 RID: 2568 RVA: 0x00005850 File Offset: 0x00003A50
		public unsafe UnityEvent onFalse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolUnityEvents.NativeFieldInfoPtr_onFalse);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolUnityEvents.NativeFieldInfoPtr_onFalse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400075B RID: 1883
		private static readonly IntPtr NativeFieldInfoPtr_eventTypes;

		// Token: 0x0400075C RID: 1884
		private static readonly IntPtr NativeFieldInfoPtr_onEvent;

		// Token: 0x0400075D RID: 1885
		private static readonly IntPtr NativeFieldInfoPtr_onInverse;

		// Token: 0x0400075E RID: 1886
		private static readonly IntPtr NativeFieldInfoPtr_onTrue;

		// Token: 0x0400075F RID: 1887
		private static readonly IntPtr NativeFieldInfoPtr_onFalse;

		// Token: 0x04000760 RID: 1888
		private static readonly IntPtr NativeMethodInfoPtr_get_OnEvent_Public_get_UnityEvent_1_Boolean_0;

		// Token: 0x04000761 RID: 1889
		private static readonly IntPtr NativeMethodInfoPtr_get_OnInverse_Public_get_UnityEvent_1_Boolean_0;

		// Token: 0x04000762 RID: 1890
		private static readonly IntPtr NativeMethodInfoPtr_get_OnTrue_Public_get_UnityEvent_0;

		// Token: 0x04000763 RID: 1891
		private static readonly IntPtr NativeMethodInfoPtr_get_OnFalse_Public_get_UnityEvent_0;

		// Token: 0x04000764 RID: 1892
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_Boolean_0;

		// Token: 0x04000765 RID: 1893
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200028A RID: 650
		[Flags]
		public enum EventType
		{
			// Token: 0x040015F1 RID: 5617
			None = 0,
			// Token: 0x040015F2 RID: 5618
			Event = 1,
			// Token: 0x040015F3 RID: 5619
			Inverse = 2,
			// Token: 0x040015F4 RID: 5620
			True = 4,
			// Token: 0x040015F5 RID: 5621
			False = 8
		}
	}
}
