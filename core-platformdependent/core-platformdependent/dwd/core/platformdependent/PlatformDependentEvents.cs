using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace dwd.core.platformdependent
{
	// Token: 0x0200000F RID: 15
	public class PlatformDependentEvents : MonoBehaviour
	{
		// Token: 0x06000057 RID: 87 RVA: 0x0000416C File Offset: 0x0000236C
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformDependentEvents()
		{
			Il2CppClassPointerStore<PlatformDependentEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-platformdependent.dll", "dwd.core.platformdependent", "PlatformDependentEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformDependentEvents>.NativeClassPtr);
			PlatformDependentEvents.NativeFieldInfoPtr_platformEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentEvents>.NativeClassPtr, "platformEvents");
			PlatformDependentEvents.NativeFieldInfoPtr_allowFallbackToDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentEvents>.NativeClassPtr, "allowFallbackToDefault");
			PlatformDependentEvents.NativeMethodInfoPtr_Input_FirePlatformEvent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentEvents>.NativeClassPtr, 100663340);
			PlatformDependentEvents.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentEvents>.NativeClassPtr, 100663341);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000041EC File Offset: 0x000023EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1238879, RefRangeEnd = 1238881, XrefRangeStart = 1238845, XrefRangeEnd = 1238879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Input_FirePlatformEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentEvents.NativeMethodInfoPtr_Input_FirePlatformEvent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00004220 File Offset: 0x00002420
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1238889, RefRangeEnd = 1238891, XrefRangeStart = 1238881, XrefRangeEnd = 1238889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformDependentEvents()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformDependentEvents>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentEvents.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002270 File Offset: 0x00000470
		public PlatformDependentEvents(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600005B RID: 91 RVA: 0x0000425C File Offset: 0x0000245C
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00002279 File Offset: 0x00000479
		public unsafe List<PlatformDependentEvents.PlatformToEvent> platformEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentEvents.NativeFieldInfoPtr_platformEvents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlatformDependentEvents.PlatformToEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentEvents.NativeFieldInfoPtr_platformEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600005D RID: 93 RVA: 0x0000428C File Offset: 0x0000248C
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00002298 File Offset: 0x00000498
		public unsafe bool allowFallbackToDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentEvents.NativeFieldInfoPtr_allowFallbackToDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentEvents.NativeFieldInfoPtr_allowFallbackToDefault)) = value;
			}
		}

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeFieldInfoPtr_platformEvents;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeFieldInfoPtr_allowFallbackToDefault;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_Input_FirePlatformEvent_Public_Void_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000032 RID: 50
		[Serializable]
		public class PlatformToEvent : global::Il2CppSystem.Object
		{
			// Token: 0x060001BD RID: 445 RVA: 0x00008110 File Offset: 0x00006310
			// Note: this type is marked as 'beforefieldinit'.
			static PlatformToEvent()
			{
				Il2CppClassPointerStore<PlatformDependentEvents.PlatformToEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlatformDependentEvents>.NativeClassPtr, "PlatformToEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformDependentEvents.PlatformToEvent>.NativeClassPtr);
				PlatformDependentEvents.PlatformToEvent.NativeFieldInfoPtr_Platform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentEvents.PlatformToEvent>.NativeClassPtr, "Platform");
				PlatformDependentEvents.PlatformToEvent.NativeFieldInfoPtr_PlatformEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentEvents.PlatformToEvent>.NativeClassPtr, "PlatformEvent");
				PlatformDependentEvents.PlatformToEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentEvents.PlatformToEvent>.NativeClassPtr, 100663342);
			}

			// Token: 0x060001BE RID: 446 RVA: 0x00008178 File Offset: 0x00006378
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlatformToEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformDependentEvents.PlatformToEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentEvents.PlatformToEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001BF RID: 447 RVA: 0x00002D17 File Offset: 0x00000F17
			public PlatformToEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000078 RID: 120
			// (get) Token: 0x060001C0 RID: 448 RVA: 0x000081B4 File Offset: 0x000063B4
			// (set) Token: 0x060001C1 RID: 449 RVA: 0x00002D20 File Offset: 0x00000F20
			public unsafe uint Platform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentEvents.PlatformToEvent.NativeFieldInfoPtr_Platform);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentEvents.PlatformToEvent.NativeFieldInfoPtr_Platform)) = value;
				}
			}

			// Token: 0x17000079 RID: 121
			// (get) Token: 0x060001C2 RID: 450 RVA: 0x000081DC File Offset: 0x000063DC
			// (set) Token: 0x060001C3 RID: 451 RVA: 0x00002D3B File Offset: 0x00000F3B
			public unsafe UnityEvent PlatformEvent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentEvents.PlatformToEvent.NativeFieldInfoPtr_PlatformEvent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentEvents.PlatformToEvent.NativeFieldInfoPtr_PlatformEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000F9 RID: 249
			private static readonly IntPtr NativeFieldInfoPtr_Platform;

			// Token: 0x040000FA RID: 250
			private static readonly IntPtr NativeFieldInfoPtr_PlatformEvent;

			// Token: 0x040000FB RID: 251
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000033 RID: 51
		[ObfuscatedName("dwd.core.platformdependent.PlatformDependentEvents+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x060001C4 RID: 452 RVA: 0x0000820C File Offset: 0x0000640C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PlatformDependentEvents.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlatformDependentEvents>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformDependentEvents.__c>.NativeClassPtr);
				PlatformDependentEvents.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentEvents.__c>.NativeClassPtr, "<>9");
				PlatformDependentEvents.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentEvents.__c>.NativeClassPtr, "<>9__3_0");
				PlatformDependentEvents.__c.NativeFieldInfoPtr___9__3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentEvents.__c>.NativeClassPtr, "<>9__3_1");
				PlatformDependentEvents.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentEvents.__c>.NativeClassPtr, 100663344);
				PlatformDependentEvents.__c.NativeMethodInfoPtr__Input_FirePlatformEvent_b__3_0_Internal_Boolean_PlatformToEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentEvents.__c>.NativeClassPtr, 100663345);
				PlatformDependentEvents.__c.NativeMethodInfoPtr__Input_FirePlatformEvent_b__3_1_Internal_Boolean_PlatformToEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentEvents.__c>.NativeClassPtr, 100663346);
			}

			// Token: 0x060001C5 RID: 453 RVA: 0x000082B0 File Offset: 0x000064B0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformDependentEvents.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentEvents.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001C6 RID: 454 RVA: 0x000082EC File Offset: 0x000064EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238837, XrefRangeEnd = 1238841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Input_FirePlatformEvent_b__3_0(PlatformDependentEvents.PlatformToEvent pe)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(pe);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentEvents.__c.NativeMethodInfoPtr__Input_FirePlatformEvent_b__3_0_Internal_Boolean_PlatformToEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060001C7 RID: 455 RVA: 0x0000833C File Offset: 0x0000653C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238841, XrefRangeEnd = 1238845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Input_FirePlatformEvent_b__3_1(PlatformDependentEvents.PlatformToEvent pe)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(pe);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentEvents.__c.NativeMethodInfoPtr__Input_FirePlatformEvent_b__3_1_Internal_Boolean_PlatformToEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060001C8 RID: 456 RVA: 0x00002D5A File Offset: 0x00000F5A
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700007A RID: 122
			// (get) Token: 0x060001C9 RID: 457 RVA: 0x0000838C File Offset: 0x0000658C
			// (set) Token: 0x060001CA RID: 458 RVA: 0x00002D63 File Offset: 0x00000F63
			public unsafe static PlatformDependentEvents.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlatformDependentEvents.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformDependentEvents.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlatformDependentEvents.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700007B RID: 123
			// (get) Token: 0x060001CB RID: 459 RVA: 0x000083B4 File Offset: 0x000065B4
			// (set) Token: 0x060001CC RID: 460 RVA: 0x00002D75 File Offset: 0x00000F75
			public unsafe static Func<PlatformDependentEvents.PlatformToEvent, bool> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlatformDependentEvents.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlatformDependentEvents.PlatformToEvent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlatformDependentEvents.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700007C RID: 124
			// (get) Token: 0x060001CD RID: 461 RVA: 0x000083DC File Offset: 0x000065DC
			// (set) Token: 0x060001CE RID: 462 RVA: 0x00002D87 File Offset: 0x00000F87
			public unsafe static Func<PlatformDependentEvents.PlatformToEvent, bool> __9__3_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlatformDependentEvents.__c.NativeFieldInfoPtr___9__3_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlatformDependentEvents.PlatformToEvent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlatformDependentEvents.__c.NativeFieldInfoPtr___9__3_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000FC RID: 252
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040000FD RID: 253
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x040000FE RID: 254
			private static readonly IntPtr NativeFieldInfoPtr___9__3_1;

			// Token: 0x040000FF RID: 255
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000100 RID: 256
			private static readonly IntPtr NativeMethodInfoPtr__Input_FirePlatformEvent_b__3_0_Internal_Boolean_PlatformToEvent_0;

			// Token: 0x04000101 RID: 257
			private static readonly IntPtr NativeMethodInfoPtr__Input_FirePlatformEvent_b__3_1_Internal_Boolean_PlatformToEvent_0;
		}
	}
}
