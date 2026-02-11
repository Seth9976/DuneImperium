using System;
using boardgames.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace boardgames.dataRenderers
{
	// Token: 0x02000147 RID: 327
	public class EventsForPlayerTypeSubscriber : VersionedSubscriber<PlayerTypeData>
	{
		// Token: 0x06000EED RID: 3821 RVA: 0x0004D2AC File Offset: 0x0004B4AC
		// Note: this type is marked as 'beforefieldinit'.
		static EventsForPlayerTypeSubscriber()
		{
			Il2CppClassPointerStore<EventsForPlayerTypeSubscriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.dataRenderers", "EventsForPlayerTypeSubscriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForPlayerTypeSubscriber>.NativeClassPtr);
			EventsForPlayerTypeSubscriber.NativeFieldInfoPtr_eventPairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForPlayerTypeSubscriber>.NativeClassPtr, "eventPairs");
			EventsForPlayerTypeSubscriber.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForPlayerTypeSubscriber>.NativeClassPtr, 100665466);
			EventsForPlayerTypeSubscriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForPlayerTypeSubscriber>.NativeClassPtr, 100665467);
			EventsForPlayerTypeSubscriber.NativeMethodInfoPtr__dirtyUpdate_b__2_0_Private_Boolean_TypeEventPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForPlayerTypeSubscriber>.NativeClassPtr, 100665468);
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x0004D32C File Offset: 0x0004B52C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512754, XrefRangeEnd = 512764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventsForPlayerTypeSubscriber.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x0004D368 File Offset: 0x0004B568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512764, XrefRangeEnd = 512774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsForPlayerTypeSubscriber()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForPlayerTypeSubscriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForPlayerTypeSubscriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x0004D3A4 File Offset: 0x0004B5A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512774, XrefRangeEnd = 512775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _dirtyUpdate_b__2_0(EventsForPlayerTypeSubscriber.TypeEventPair p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(p));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForPlayerTypeSubscriber.NativeMethodInfoPtr__dirtyUpdate_b__2_0_Private_Boolean_TypeEventPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EF1 RID: 3825 RVA: 0x000092FA File Offset: 0x000074FA
		public EventsForPlayerTypeSubscriber(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000EF2 RID: 3826 RVA: 0x0004D3F8 File Offset: 0x0004B5F8
		// (set) Token: 0x06000EF3 RID: 3827 RVA: 0x00009303 File Offset: 0x00007503
		public unsafe List<EventsForPlayerTypeSubscriber.TypeEventPair> eventPairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForPlayerTypeSubscriber.NativeFieldInfoPtr_eventPairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EventsForPlayerTypeSubscriber.TypeEventPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForPlayerTypeSubscriber.NativeFieldInfoPtr_eventPairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000936 RID: 2358
		private static readonly IntPtr NativeFieldInfoPtr_eventPairs;

		// Token: 0x04000937 RID: 2359
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000938 RID: 2360
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000939 RID: 2361
		private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__2_0_Private_Boolean_TypeEventPair_0;

		// Token: 0x02000369 RID: 873
		[Serializable]
		public sealed class TypeEventPair : ValueType
		{
			// Token: 0x0600292E RID: 10542 RVA: 0x000A3DB4 File Offset: 0x000A1FB4
			// Note: this type is marked as 'beforefieldinit'.
			static TypeEventPair()
			{
				Il2CppClassPointerStore<EventsForPlayerTypeSubscriber.TypeEventPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventsForPlayerTypeSubscriber>.NativeClassPtr, "TypeEventPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForPlayerTypeSubscriber.TypeEventPair>.NativeClassPtr);
				EventsForPlayerTypeSubscriber.TypeEventPair.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForPlayerTypeSubscriber.TypeEventPair>.NativeClassPtr, "type");
				EventsForPlayerTypeSubscriber.TypeEventPair.NativeFieldInfoPtr_localPlayerOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForPlayerTypeSubscriber.TypeEventPair>.NativeClassPtr, "localPlayerOnly");
				EventsForPlayerTypeSubscriber.TypeEventPair.NativeFieldInfoPtr_typeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForPlayerTypeSubscriber.TypeEventPair>.NativeClassPtr, "typeEvent");
			}

			// Token: 0x0600292F RID: 10543 RVA: 0x00015405 File Offset: 0x00013605
			public TypeEventPair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002930 RID: 10544 RVA: 0x0001540E File Offset: 0x0001360E
			public TypeEventPair()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForPlayerTypeSubscriber.TypeEventPair>.NativeClassPtr))
			{
			}

			// Token: 0x17000B93 RID: 2963
			// (get) Token: 0x06002931 RID: 10545 RVA: 0x000A3E1C File Offset: 0x000A201C
			// (set) Token: 0x06002932 RID: 10546 RVA: 0x00015420 File Offset: 0x00013620
			public unsafe PlayerTypeData.PlayerType type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForPlayerTypeSubscriber.TypeEventPair.NativeFieldInfoPtr_type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForPlayerTypeSubscriber.TypeEventPair.NativeFieldInfoPtr_type)) = value;
				}
			}

			// Token: 0x17000B94 RID: 2964
			// (get) Token: 0x06002933 RID: 10547 RVA: 0x000A3E44 File Offset: 0x000A2044
			// (set) Token: 0x06002934 RID: 10548 RVA: 0x0001543B File Offset: 0x0001363B
			public unsafe bool localPlayerOnly
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForPlayerTypeSubscriber.TypeEventPair.NativeFieldInfoPtr_localPlayerOnly);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForPlayerTypeSubscriber.TypeEventPair.NativeFieldInfoPtr_localPlayerOnly)) = value;
				}
			}

			// Token: 0x17000B95 RID: 2965
			// (get) Token: 0x06002935 RID: 10549 RVA: 0x000A3E6C File Offset: 0x000A206C
			// (set) Token: 0x06002936 RID: 10550 RVA: 0x00015456 File Offset: 0x00013656
			public unsafe UnityEvent typeEvent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForPlayerTypeSubscriber.TypeEventPair.NativeFieldInfoPtr_typeEvent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForPlayerTypeSubscriber.TypeEventPair.NativeFieldInfoPtr_typeEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040019C3 RID: 6595
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x040019C4 RID: 6596
			private static readonly IntPtr NativeFieldInfoPtr_localPlayerOnly;

			// Token: 0x040019C5 RID: 6597
			private static readonly IntPtr NativeFieldInfoPtr_typeEvent;
		}
	}
}
