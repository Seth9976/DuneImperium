using System;
using Canis.actions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.events
{
	// Token: 0x020000AF RID: 175
	public class EventReactor : Object
	{
		// Token: 0x0600082E RID: 2094 RVA: 0x0003A594 File Offset: 0x00038794
		// Note: this type is marked as 'beforefieldinit'.
		static EventReactor()
		{
			Il2CppClassPointerStore<EventReactor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.events", "EventReactor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventReactor>.NativeClassPtr);
			EventReactor.NativeFieldInfoPtr__responses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventReactor>.NativeClassPtr, "_responses");
			EventReactor.NativeMethodInfoPtr_When_Public_Virtual_New_Void_Event_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventReactor>.NativeClassPtr, 100664976);
			EventReactor.NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_Event_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventReactor>.NativeClassPtr, 100664977);
			EventReactor.NativeMethodInfoPtr_FireEvent_Public_Virtual_New_Action_Event_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventReactor>.NativeClassPtr, 100664978);
			EventReactor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventReactor>.NativeClassPtr, 100664979);
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x0003A628 File Offset: 0x00038828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 559599, XrefRangeEnd = 559616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void When(Event evt, Canis.actions.Action response)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(response);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventReactor.NativeMethodInfoPtr_When_Public_Virtual_New_Void_Event_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x0003A688 File Offset: 0x00038888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 559616, XrefRangeEnd = 559640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Remove(Event evt, Canis.actions.Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventReactor.NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_Event_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x0003A6E8 File Offset: 0x000388E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 559693, RefRangeEnd = 559694, XrefRangeStart = 559640, XrefRangeEnd = 559693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Canis.actions.Action FireEvent(Event evt, Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventReactor.NativeMethodInfoPtr_FireEvent_Public_Virtual_New_Action_Event_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x0003A758 File Offset: 0x00038958
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 559702, RefRangeEnd = 559703, XrefRangeStart = 559694, XrefRangeEnd = 559702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventReactor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventReactor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventReactor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x000053D2 File Offset: 0x000035D2
		public EventReactor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000834 RID: 2100 RVA: 0x0003A794 File Offset: 0x00038994
		// (set) Token: 0x06000835 RID: 2101 RVA: 0x000053DB File Offset: 0x000035DB
		public unsafe Dictionary<Event, List<Canis.actions.Action>> _responses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventReactor.NativeFieldInfoPtr__responses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Event, List<Canis.actions.Action>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventReactor.NativeFieldInfoPtr__responses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000593 RID: 1427
		private static readonly IntPtr NativeFieldInfoPtr__responses;

		// Token: 0x04000594 RID: 1428
		private static readonly IntPtr NativeMethodInfoPtr_When_Public_Virtual_New_Void_Event_Action_0;

		// Token: 0x04000595 RID: 1429
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_Event_Action_0;

		// Token: 0x04000596 RID: 1430
		private static readonly IntPtr NativeMethodInfoPtr_FireEvent_Public_Virtual_New_Action_Event_Match_0;

		// Token: 0x04000597 RID: 1431
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002EC RID: 748
		[ObfuscatedName("Canis.events.EventReactor+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x06001F3E RID: 7998 RVA: 0x00090064 File Offset: 0x0008E264
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<EventReactor.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventReactor>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventReactor.__c__DisplayClass2_0>.NativeClassPtr);
				EventReactor.__c__DisplayClass2_0.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventReactor.__c__DisplayClass2_0>.NativeClassPtr, "action");
				EventReactor.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventReactor.__c__DisplayClass2_0>.NativeClassPtr, 100664980);
				EventReactor.__c__DisplayClass2_0.NativeMethodInfoPtr__Remove_b__0_Internal_Boolean_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventReactor.__c__DisplayClass2_0>.NativeClassPtr, 100664981);
			}

			// Token: 0x06001F3F RID: 7999 RVA: 0x000900CC File Offset: 0x0008E2CC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventReactor.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventReactor.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F40 RID: 8000 RVA: 0x00090108 File Offset: 0x0008E308
			[CallerCount(0)]
			public unsafe bool _Remove_b__0(Canis.actions.Action act)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(act);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventReactor.__c__DisplayClass2_0.NativeMethodInfoPtr__Remove_b__0_Internal_Boolean_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001F41 RID: 8001 RVA: 0x0000F087 File Offset: 0x0000D287
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000759 RID: 1881
			// (get) Token: 0x06001F42 RID: 8002 RVA: 0x00090158 File Offset: 0x0008E358
			// (set) Token: 0x06001F43 RID: 8003 RVA: 0x0000F090 File Offset: 0x0000D290
			public unsafe Canis.actions.Action action
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventReactor.__c__DisplayClass2_0.NativeFieldInfoPtr_action);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventReactor.__c__DisplayClass2_0.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040013B7 RID: 5047
			private static readonly IntPtr NativeFieldInfoPtr_action;

			// Token: 0x040013B8 RID: 5048
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040013B9 RID: 5049
			private static readonly IntPtr NativeMethodInfoPtr__Remove_b__0_Internal_Boolean_Action_0;
		}
	}
}
