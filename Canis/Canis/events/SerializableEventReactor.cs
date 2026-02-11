using System;
using Canis.actions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.events
{
	// Token: 0x020000B2 RID: 178
	public class SerializableEventReactor : EventReactor
	{
		// Token: 0x0600084D RID: 2125 RVA: 0x0003AD50 File Offset: 0x00038F50
		// Note: this type is marked as 'beforefieldinit'.
		static SerializableEventReactor()
		{
			Il2CppClassPointerStore<SerializableEventReactor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.events", "SerializableEventReactor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializableEventReactor>.NativeClassPtr);
			SerializableEventReactor.NativeFieldInfoPtr_serializableResponses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableEventReactor>.NativeClassPtr, "serializableResponses");
			SerializableEventReactor.NativeMethodInfoPtr_Remove_Public_Virtual_Void_Event_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEventReactor>.NativeClassPtr, 100664993);
			SerializableEventReactor.NativeMethodInfoPtr_When_Public_Virtual_Void_Event_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEventReactor>.NativeClassPtr, 100664994);
			SerializableEventReactor.NativeMethodInfoPtr_TryGetResponses_Public_Boolean_SerializableEvent_byref_List_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEventReactor>.NativeClassPtr, 100664995);
			SerializableEventReactor.NativeMethodInfoPtr_Serialize_Public_Abstract_Virtual_New_SerializedEventReactor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEventReactor>.NativeClassPtr, 100664996);
			SerializableEventReactor.NativeMethodInfoPtr_RestoreSerializedResponses_Public_Abstract_Virtual_New_Void_SerializedEventReactor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEventReactor>.NativeClassPtr, 100664997);
			SerializableEventReactor.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEventReactor>.NativeClassPtr, 100664998);
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x0003AE0C File Offset: 0x0003900C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 559936, XrefRangeEnd = 559963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Remove(Event evt, Canis.actions.Action action)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializableEventReactor.NativeMethodInfoPtr_Remove_Public_Virtual_Void_Event_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x0003AE6C File Offset: 0x0003906C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 559963, XrefRangeEnd = 559981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void When(Event evt, Canis.actions.Action response)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializableEventReactor.NativeMethodInfoPtr_When_Public_Virtual_Void_Event_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x0003AECC File Offset: 0x000390CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 559981, XrefRangeEnd = 559985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetResponses(SerializableEvent evt, out List<Canis.actions.Action> actions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SerializableEventReactor.NativeMethodInfoPtr_TryGetResponses_Public_Boolean_SerializableEvent_byref_List_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			actions = ((intPtr4 == 0) ? null : new List<Canis.actions.Action>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x0003AF3C File Offset: 0x0003913C
		[CallerCount(0)]
		public unsafe virtual SerializedEventReactor Serialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializableEventReactor.NativeMethodInfoPtr_Serialize_Public_Abstract_Virtual_New_SerializedEventReactor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedEventReactor>(intPtr3) : null;
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x0003AF88 File Offset: 0x00039188
		[CallerCount(0)]
		public unsafe virtual void RestoreSerializedResponses(SerializedEventReactor serialized)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializableEventReactor.NativeMethodInfoPtr_RestoreSerializedResponses_Public_Abstract_Virtual_New_Void_SerializedEventReactor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x0003AFD8 File Offset: 0x000391D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 560000, RefRangeEnd = 560001, XrefRangeStart = 559985, XrefRangeEnd = 560000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializableEventReactor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializableEventReactor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableEventReactor.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x00005488 File Offset: 0x00003688
		public SerializableEventReactor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000855 RID: 2133 RVA: 0x0003B014 File Offset: 0x00039214
		// (set) Token: 0x06000856 RID: 2134 RVA: 0x00005491 File Offset: 0x00003691
		public unsafe Dictionary<SerializableEvent, List<Canis.actions.Action>> serializableResponses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableEventReactor.NativeFieldInfoPtr_serializableResponses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<SerializableEvent, List<Canis.actions.Action>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableEventReactor.NativeFieldInfoPtr_serializableResponses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005A7 RID: 1447
		private static readonly IntPtr NativeFieldInfoPtr_serializableResponses;

		// Token: 0x040005A8 RID: 1448
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Void_Event_Action_0;

		// Token: 0x040005A9 RID: 1449
		private static readonly IntPtr NativeMethodInfoPtr_When_Public_Virtual_Void_Event_Action_0;

		// Token: 0x040005AA RID: 1450
		private static readonly IntPtr NativeMethodInfoPtr_TryGetResponses_Public_Boolean_SerializableEvent_byref_List_1_Action_0;

		// Token: 0x040005AB RID: 1451
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Abstract_Virtual_New_SerializedEventReactor_0;

		// Token: 0x040005AC RID: 1452
		private static readonly IntPtr NativeMethodInfoPtr_RestoreSerializedResponses_Public_Abstract_Virtual_New_Void_SerializedEventReactor_0;

		// Token: 0x040005AD RID: 1453
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x020002ED RID: 749
		[ObfuscatedName("Canis.events.SerializableEventReactor+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x06001F44 RID: 8004 RVA: 0x00090188 File Offset: 0x0008E388
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<SerializableEventReactor.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializableEventReactor>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializableEventReactor.__c__DisplayClass1_0>.NativeClassPtr);
				SerializableEventReactor.__c__DisplayClass1_0.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableEventReactor.__c__DisplayClass1_0>.NativeClassPtr, "action");
				SerializableEventReactor.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEventReactor.__c__DisplayClass1_0>.NativeClassPtr, 100664999);
				SerializableEventReactor.__c__DisplayClass1_0.NativeMethodInfoPtr__Remove_b__0_Internal_Boolean_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEventReactor.__c__DisplayClass1_0>.NativeClassPtr, 100665000);
			}

			// Token: 0x06001F45 RID: 8005 RVA: 0x000901F0 File Offset: 0x0008E3F0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializableEventReactor.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableEventReactor.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F46 RID: 8006 RVA: 0x0009022C File Offset: 0x0008E42C
			[CallerCount(0)]
			public unsafe bool _Remove_b__0(Canis.actions.Action act)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(act);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableEventReactor.__c__DisplayClass1_0.NativeMethodInfoPtr__Remove_b__0_Internal_Boolean_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001F47 RID: 8007 RVA: 0x0000F0AF File Offset: 0x0000D2AF
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700075A RID: 1882
			// (get) Token: 0x06001F48 RID: 8008 RVA: 0x0009027C File Offset: 0x0008E47C
			// (set) Token: 0x06001F49 RID: 8009 RVA: 0x0000F0B8 File Offset: 0x0000D2B8
			public unsafe Canis.actions.Action action
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableEventReactor.__c__DisplayClass1_0.NativeFieldInfoPtr_action);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableEventReactor.__c__DisplayClass1_0.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040013BA RID: 5050
			private static readonly IntPtr NativeFieldInfoPtr_action;

			// Token: 0x040013BB RID: 5051
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040013BC RID: 5052
			private static readonly IntPtr NativeMethodInfoPtr__Remove_b__0_Internal_Boolean_Action_0;
		}
	}
}
