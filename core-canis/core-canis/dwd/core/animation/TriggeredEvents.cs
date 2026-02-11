using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace dwd.core.animation
{
	// Token: 0x02000218 RID: 536
	public class TriggeredEvents : MonoBehaviour
	{
		// Token: 0x06001D60 RID: 7520 RVA: 0x00087F50 File Offset: 0x00086150
		// Note: this type is marked as 'beforefieldinit'.
		static TriggeredEvents()
		{
			Il2CppClassPointerStore<TriggeredEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.animation", "TriggeredEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TriggeredEvents>.NativeClassPtr);
			TriggeredEvents.NativeFieldInfoPtr_triggeredEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggeredEvents>.NativeClassPtr, "triggeredEvents");
			TriggeredEvents.NativeMethodInfoPtr_FireEvents_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggeredEvents>.NativeClassPtr, 100668030);
			TriggeredEvents.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggeredEvents>.NativeClassPtr, 100668031);
		}

		// Token: 0x06001D61 RID: 7521 RVA: 0x00087FBC File Offset: 0x000861BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886368, XrefRangeEnd = 886398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FireEvents(string triggerName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(triggerName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggeredEvents.NativeMethodInfoPtr_FireEvents_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D62 RID: 7522 RVA: 0x00088000 File Offset: 0x00086200
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TriggeredEvents()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TriggeredEvents>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggeredEvents.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D63 RID: 7523 RVA: 0x0000C854 File Offset: 0x0000AA54
		public TriggeredEvents(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x06001D64 RID: 7524 RVA: 0x0008803C File Offset: 0x0008623C
		// (set) Token: 0x06001D65 RID: 7525 RVA: 0x0000C85D File Offset: 0x0000AA5D
		public unsafe List<TriggeredEvents.StringToEvent> triggeredEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggeredEvents.NativeFieldInfoPtr_triggeredEvents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TriggeredEvents.StringToEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggeredEvents.NativeFieldInfoPtr_triggeredEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001493 RID: 5267
		private static readonly IntPtr NativeFieldInfoPtr_triggeredEvents;

		// Token: 0x04001494 RID: 5268
		private static readonly IntPtr NativeMethodInfoPtr_FireEvents_Public_Void_String_0;

		// Token: 0x04001495 RID: 5269
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003A4 RID: 932
		[Serializable]
		public class StringToEvent : global::Il2CppSystem.Object
		{
			// Token: 0x06002989 RID: 10633 RVA: 0x000AE13C File Offset: 0x000AC33C
			// Note: this type is marked as 'beforefieldinit'.
			static StringToEvent()
			{
				Il2CppClassPointerStore<TriggeredEvents.StringToEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TriggeredEvents>.NativeClassPtr, "StringToEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TriggeredEvents.StringToEvent>.NativeClassPtr);
				TriggeredEvents.StringToEvent.NativeFieldInfoPtr_EventName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggeredEvents.StringToEvent>.NativeClassPtr, "EventName");
				TriggeredEvents.StringToEvent.NativeFieldInfoPtr_TriggeredEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggeredEvents.StringToEvent>.NativeClassPtr, "TriggeredEvent");
				TriggeredEvents.StringToEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggeredEvents.StringToEvent>.NativeClassPtr, 100668032);
			}

			// Token: 0x0600298A RID: 10634 RVA: 0x000AE1A4 File Offset: 0x000AC3A4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StringToEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TriggeredEvents.StringToEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggeredEvents.StringToEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600298B RID: 10635 RVA: 0x00012E2A File Offset: 0x0001102A
			public StringToEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BCD RID: 3021
			// (get) Token: 0x0600298C RID: 10636 RVA: 0x000AE1E0 File Offset: 0x000AC3E0
			// (set) Token: 0x0600298D RID: 10637 RVA: 0x00012E33 File Offset: 0x00011033
			public unsafe string EventName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggeredEvents.StringToEvent.NativeFieldInfoPtr_EventName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggeredEvents.StringToEvent.NativeFieldInfoPtr_EventName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000BCE RID: 3022
			// (get) Token: 0x0600298E RID: 10638 RVA: 0x000AE208 File Offset: 0x000AC408
			// (set) Token: 0x0600298F RID: 10639 RVA: 0x00012E52 File Offset: 0x00011052
			public unsafe UnityEvent TriggeredEvent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggeredEvents.StringToEvent.NativeFieldInfoPtr_TriggeredEvent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggeredEvents.StringToEvent.NativeFieldInfoPtr_TriggeredEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001C16 RID: 7190
			private static readonly IntPtr NativeFieldInfoPtr_EventName;

			// Token: 0x04001C17 RID: 7191
			private static readonly IntPtr NativeFieldInfoPtr_TriggeredEvent;

			// Token: 0x04001C18 RID: 7192
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020003A5 RID: 933
		[ObfuscatedName("dwd.core.animation.TriggeredEvents+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002990 RID: 10640 RVA: 0x000AE238 File Offset: 0x000AC438
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<TriggeredEvents.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TriggeredEvents>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TriggeredEvents.__c__DisplayClass2_0>.NativeClassPtr);
				TriggeredEvents.__c__DisplayClass2_0.NativeFieldInfoPtr_triggerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggeredEvents.__c__DisplayClass2_0>.NativeClassPtr, "triggerName");
				TriggeredEvents.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggeredEvents.__c__DisplayClass2_0>.NativeClassPtr, 100668033);
				TriggeredEvents.__c__DisplayClass2_0.NativeMethodInfoPtr__FireEvents_b__0_Internal_Boolean_StringToEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggeredEvents.__c__DisplayClass2_0>.NativeClassPtr, 100668034);
			}

			// Token: 0x06002991 RID: 10641 RVA: 0x000AE2A0 File Offset: 0x000AC4A0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TriggeredEvents.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggeredEvents.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002992 RID: 10642 RVA: 0x000AE2DC File Offset: 0x000AC4DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886364, XrefRangeEnd = 886368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _FireEvents_b__0(TriggeredEvents.StringToEvent te)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(te);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggeredEvents.__c__DisplayClass2_0.NativeMethodInfoPtr__FireEvents_b__0_Internal_Boolean_StringToEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002993 RID: 10643 RVA: 0x00012E71 File Offset: 0x00011071
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BCF RID: 3023
			// (get) Token: 0x06002994 RID: 10644 RVA: 0x000AE32C File Offset: 0x000AC52C
			// (set) Token: 0x06002995 RID: 10645 RVA: 0x00012E7A File Offset: 0x0001107A
			public unsafe string triggerName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggeredEvents.__c__DisplayClass2_0.NativeFieldInfoPtr_triggerName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggeredEvents.__c__DisplayClass2_0.NativeFieldInfoPtr_triggerName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04001C19 RID: 7193
			private static readonly IntPtr NativeFieldInfoPtr_triggerName;

			// Token: 0x04001C1A RID: 7194
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001C1B RID: 7195
			private static readonly IntPtr NativeMethodInfoPtr__FireEvents_b__0_Internal_Boolean_StringToEvent_0;
		}
	}
}
