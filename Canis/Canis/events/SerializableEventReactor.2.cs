using System;
using Canis.actions;
using Canis.actions.serialized;
using Canis.context;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.events
{
	// Token: 0x020000B3 RID: 179
	public class SerializableEventReactor<TMatch> : SerializableEventReactor where TMatch : Match
	{
		// Token: 0x06000857 RID: 2135 RVA: 0x0003B044 File Offset: 0x00039244
		// Note: this type is marked as 'beforefieldinit'.
		static SerializableEventReactor()
		{
			Il2CppClassPointerStore<SerializableEventReactor<TMatch>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.events", "SerializableEventReactor`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializableEventReactor<TMatch>>.NativeClassPtr);
			SerializableEventReactor<TMatch>.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableEventReactor<TMatch>>.NativeClassPtr, "match");
			SerializableEventReactor<TMatch>.NativeMethodInfoPtr__ctor_Public_Void_TMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEventReactor<TMatch>>.NativeClassPtr, 100665001);
			SerializableEventReactor<TMatch>.NativeMethodInfoPtr_RestoreSerializedResponses_Public_Virtual_Void_SerializedEventReactor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEventReactor<TMatch>>.NativeClassPtr, 100665002);
			SerializableEventReactor<TMatch>.NativeMethodInfoPtr_AppendUndo_Protected_Virtual_New_Boolean_UndoNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEventReactor<TMatch>>.NativeClassPtr, 100665003);
			SerializableEventReactor<TMatch>.NativeMethodInfoPtr_MakeRunTriggeredAbility_Protected_Virtual_New_Action_SerializableEvent_ITriggeredAbility_PlayerEntity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEventReactor<TMatch>>.NativeClassPtr, 100665004);
			SerializableEventReactor<TMatch>.NativeMethodInfoPtr_FindRunnableTriggeredAbilities_Protected_Virtual_New_IEnumerable_1_Action_SerializableEvent_IEnumerable_1_ITriggeredAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEventReactor<TMatch>>.NativeClassPtr, 100665005);
			SerializableEventReactor<TMatch>.NativeMethodInfoPtr_FireEvent_Public_Virtual_Action_Event_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEventReactor<TMatch>>.NativeClassPtr, 100665006);
			SerializableEventReactor<TMatch>.NativeMethodInfoPtr_Serialize_Public_Virtual_SerializedEventReactor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEventReactor<TMatch>>.NativeClassPtr, 100665007);
			SerializableEventReactor<TMatch>.NativeMethodInfoPtr__RestoreSerializedResponses_b__2_0_Private_SerializableEvent_SerializedEventResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEventReactor<TMatch>>.NativeClassPtr, 100665008);
			SerializableEventReactor<TMatch>.NativeMethodInfoPtr__RestoreSerializedResponses_b__2_1_Private_List_1_Action_SerializedEventResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEventReactor<TMatch>>.NativeClassPtr, 100665009);
			SerializableEventReactor<TMatch>.NativeMethodInfoPtr__RestoreSerializedResponses_b__2_2_Private_Action_SerializedAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEventReactor<TMatch>>.NativeClassPtr, 100665010);
			SerializableEventReactor<TMatch>.NativeMethodInfoPtr__Serialize_b__7_0_Private_SerializedEventResponse_KeyValuePair_2_SerializableEvent_List_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEventReactor<TMatch>>.NativeClassPtr, 100665011);
			SerializableEventReactor<TMatch>.NativeMethodInfoPtr__Serialize_b__7_1_Private_SerializedAction_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEventReactor<TMatch>>.NativeClassPtr, 100665012);
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x0003B1B4 File Offset: 0x000393B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 560091, RefRangeEnd = 560092, XrefRangeStart = 560089, XrefRangeEnd = 560091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializableEventReactor(TMatch match)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializableEventReactor<TMatch>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TMatch).IsValueType)
				{
					TMatch tmatch = match;
					intPtr = ((tmatch is string) ? IL2CPP.ManagedStringToIl2Cpp(tmatch as string) : IL2CPP.Il2CppObjectBaseToPtr(tmatch as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref match;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SerializableEventReactor<TMatch>.NativeMethodInfoPtr__ctor_Public_Void_TMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x0003B238 File Offset: 0x00039438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 560092, XrefRangeEnd = 560105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RestoreSerializedResponses(SerializedEventReactor serialized)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializableEventReactor<TMatch>.NativeMethodInfoPtr_RestoreSerializedResponses_Public_Virtual_Void_SerializedEventReactor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x0003B288 File Offset: 0x00039488
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool AppendUndo(UndoNode undoNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(undoNode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializableEventReactor<TMatch>.NativeMethodInfoPtr_AppendUndo_Protected_Virtual_New_Boolean_UndoNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x0003B2E0 File Offset: 0x000394E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 560105, XrefRangeEnd = 560126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Canis.actions.Action MakeRunTriggeredAbility(SerializableEvent triggeringEvent, ITriggeredAbility triggeredAbility, PlayerEntity runningPlayer, Context paramContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(triggeringEvent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(triggeredAbility);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(runningPlayer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializableEventReactor<TMatch>.NativeMethodInfoPtr_MakeRunTriggeredAbility_Protected_Virtual_New_Action_SerializableEvent_ITriggeredAbility_PlayerEntity_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x0003B374 File Offset: 0x00039574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 560126, XrefRangeEnd = 560132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<Canis.actions.Action> FindRunnableTriggeredAbilities(SerializableEvent serializableEvent, IEnumerable<ITriggeredAbility> triggeredAbilities)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializableEvent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(triggeredAbilities);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializableEventReactor<TMatch>.NativeMethodInfoPtr_FindRunnableTriggeredAbilities_Protected_Virtual_New_IEnumerable_1_Action_SerializableEvent_IEnumerable_1_ITriggeredAbility_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x0003B3E4 File Offset: 0x000395E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 560155, RefRangeEnd = 560156, XrefRangeStart = 560132, XrefRangeEnd = 560155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Canis.actions.Action FireEvent(Event evt, Match match)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializableEventReactor<TMatch>.NativeMethodInfoPtr_FireEvent_Public_Virtual_Action_Event_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x0003B454 File Offset: 0x00039654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 560156, XrefRangeEnd = 560171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedEventReactor Serialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializableEventReactor<TMatch>.NativeMethodInfoPtr_Serialize_Public_Virtual_SerializedEventReactor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedEventReactor>(intPtr3) : null;
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x0003B4A0 File Offset: 0x000396A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 560171, XrefRangeEnd = 560173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializableEvent _RestoreSerializedResponses_b__2_0(SerializedEventResponse r)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableEventReactor<TMatch>.NativeMethodInfoPtr__RestoreSerializedResponses_b__2_0_Private_SerializableEvent_SerializedEventResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr3) : null;
			}
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x0003B4F0 File Offset: 0x000396F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 560173, XrefRangeEnd = 560184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Canis.actions.Action> _RestoreSerializedResponses_b__2_1(SerializedEventResponse r)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableEventReactor<TMatch>.NativeMethodInfoPtr__RestoreSerializedResponses_b__2_1_Private_List_1_Action_SerializedEventResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x0003B540 File Offset: 0x00039740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 560184, XrefRangeEnd = 560186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canis.actions.Action _RestoreSerializedResponses_b__2_2(SerializedAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableEventReactor<TMatch>.NativeMethodInfoPtr__RestoreSerializedResponses_b__2_2_Private_Action_SerializedAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
			}
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x0003B590 File Offset: 0x00039790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 560186, XrefRangeEnd = 560205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedEventResponse _Serialize_b__7_0(KeyValuePair<SerializableEvent, List<Canis.actions.Action>> pair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pair));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableEventReactor<TMatch>.NativeMethodInfoPtr__Serialize_b__7_0_Private_SerializedEventResponse_KeyValuePair_2_SerializableEvent_List_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedEventResponse>(intPtr3) : null;
			}
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x0003B5E8 File Offset: 0x000397E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 560205, XrefRangeEnd = 560207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedAction _Serialize_b__7_1(Canis.actions.Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableEventReactor<TMatch>.NativeMethodInfoPtr__Serialize_b__7_1_Private_SerializedAction_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x000054B0 File Offset: 0x000036B0
		public SerializableEventReactor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000865 RID: 2149 RVA: 0x0003B638 File Offset: 0x00039838
		// (set) Token: 0x06000866 RID: 2150 RVA: 0x0003B660 File Offset: 0x00039860
		public unsafe TMatch match
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableEventReactor<TMatch>.NativeFieldInfoPtr_match);
				return IL2CPP.PointerToValueGeneric<TMatch>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableEventReactor<TMatch>.NativeFieldInfoPtr_match);
				Type typeFromHandle = typeof(TMatch);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x040005AE RID: 1454
		private static readonly IntPtr NativeFieldInfoPtr_match;

		// Token: 0x040005AF RID: 1455
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TMatch_0;

		// Token: 0x040005B0 RID: 1456
		private static readonly IntPtr NativeMethodInfoPtr_RestoreSerializedResponses_Public_Virtual_Void_SerializedEventReactor_0;

		// Token: 0x040005B1 RID: 1457
		private static readonly IntPtr NativeMethodInfoPtr_AppendUndo_Protected_Virtual_New_Boolean_UndoNode_0;

		// Token: 0x040005B2 RID: 1458
		private static readonly IntPtr NativeMethodInfoPtr_MakeRunTriggeredAbility_Protected_Virtual_New_Action_SerializableEvent_ITriggeredAbility_PlayerEntity_Context_0;

		// Token: 0x040005B3 RID: 1459
		private static readonly IntPtr NativeMethodInfoPtr_FindRunnableTriggeredAbilities_Protected_Virtual_New_IEnumerable_1_Action_SerializableEvent_IEnumerable_1_ITriggeredAbility_0;

		// Token: 0x040005B4 RID: 1460
		private static readonly IntPtr NativeMethodInfoPtr_FireEvent_Public_Virtual_Action_Event_Match_0;

		// Token: 0x040005B5 RID: 1461
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_SerializedEventReactor_0;

		// Token: 0x040005B6 RID: 1462
		private static readonly IntPtr NativeMethodInfoPtr__RestoreSerializedResponses_b__2_0_Private_SerializableEvent_SerializedEventResponse_0;

		// Token: 0x040005B7 RID: 1463
		private static readonly IntPtr NativeMethodInfoPtr__RestoreSerializedResponses_b__2_1_Private_List_1_Action_SerializedEventResponse_0;

		// Token: 0x040005B8 RID: 1464
		private static readonly IntPtr NativeMethodInfoPtr__RestoreSerializedResponses_b__2_2_Private_Action_SerializedAction_0;

		// Token: 0x040005B9 RID: 1465
		private static readonly IntPtr NativeMethodInfoPtr__Serialize_b__7_0_Private_SerializedEventResponse_KeyValuePair_2_SerializableEvent_List_1_Action_0;

		// Token: 0x040005BA RID: 1466
		private static readonly IntPtr NativeMethodInfoPtr__Serialize_b__7_1_Private_SerializedAction_Action_0;

		// Token: 0x020002EE RID: 750
		[ObfuscatedName("Canis.events.SerializableEventReactor`1+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x06001F4A RID: 8010 RVA: 0x000902AC File Offset: 0x0008E4AC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<SerializableEventReactor<TMatch>.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializableEventReactor<TMatch>>.NativeClassPtr, "<>c__DisplayClass6_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializableEventReactor<TMatch>.__c__DisplayClass6_0>.NativeClassPtr);
				SerializableEventReactor<TMatch>.__c__DisplayClass6_0.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableEventReactor<TMatch>.__c__DisplayClass6_0>.NativeClassPtr, "match");
				SerializableEventReactor<TMatch>.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEventReactor<TMatch>.__c__DisplayClass6_0>.NativeClassPtr, 100665013);
				SerializableEventReactor<TMatch>.__c__DisplayClass6_0.NativeMethodInfoPtr__FireEvent_b__0_Internal_Boolean_ITriggeredAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEventReactor<TMatch>.__c__DisplayClass6_0>.NativeClassPtr, 100665014);
			}

			// Token: 0x06001F4B RID: 8011 RVA: 0x00090350 File Offset: 0x0008E550
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializableEventReactor<TMatch>.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableEventReactor<TMatch>.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F4C RID: 8012 RVA: 0x0009038C File Offset: 0x0008E58C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 560001, XrefRangeEnd = 560005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _FireEvent_b__0(ITriggeredAbility t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableEventReactor<TMatch>.__c__DisplayClass6_0.NativeMethodInfoPtr__FireEvent_b__0_Internal_Boolean_ITriggeredAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001F4D RID: 8013 RVA: 0x0000F0D7 File Offset: 0x0000D2D7
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700075B RID: 1883
			// (get) Token: 0x06001F4E RID: 8014 RVA: 0x000903DC File Offset: 0x0008E5DC
			// (set) Token: 0x06001F4F RID: 8015 RVA: 0x0000F0E0 File Offset: 0x0000D2E0
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableEventReactor<TMatch>.__c__DisplayClass6_0.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableEventReactor<TMatch>.__c__DisplayClass6_0.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040013BD RID: 5053
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x040013BE RID: 5054
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040013BF RID: 5055
			private static readonly IntPtr NativeMethodInfoPtr__FireEvent_b__0_Internal_Boolean_ITriggeredAbility_0;
		}

		// Token: 0x020002EF RID: 751
		[ObfuscatedName("Canis.events.SerializableEventReactor`1+<FindRunnableTriggeredAbilities>d__5")]
		public sealed class _FindRunnableTriggeredAbilities_d__5 : Object
		{
			// Token: 0x06001F50 RID: 8016 RVA: 0x0009040C File Offset: 0x0008E60C
			// Note: this type is marked as 'beforefieldinit'.
			static _FindRunnableTriggeredAbilities_d__5()
			{
				Il2CppClassPointerStore<SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializableEventReactor<TMatch>>.NativeClassPtr, "<FindRunnableTriggeredAbilities>d__5"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5>.NativeClassPtr);
				SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5>.NativeClassPtr, "<>1__state");
				SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5>.NativeClassPtr, "<>2__current");
				SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5>.NativeClassPtr, "<>l__initialThreadId");
				SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeFieldInfoPtr_serializableEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5>.NativeClassPtr, "serializableEvent");
				SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeFieldInfoPtr___3__serializableEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5>.NativeClassPtr, "<>3__serializableEvent");
				SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeFieldInfoPtr_triggeredAbilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5>.NativeClassPtr, "triggeredAbilities");
				SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeFieldInfoPtr___3__triggeredAbilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5>.NativeClassPtr, "<>3__triggeredAbilities");
				SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5>.NativeClassPtr, "<>4__this");
				SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeFieldInfoPtr__paramContext_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5>.NativeClassPtr, "<paramContext>5__2");
				SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5>.NativeClassPtr, "<>7__wrap2");
				SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeFieldInfoPtr__triggered_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5>.NativeClassPtr, "<triggered>5__4");
				SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeFieldInfoPtr___7__wrap4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5>.NativeClassPtr, "<>7__wrap4");
				SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5>.NativeClassPtr, 100665015);
				SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5>.NativeClassPtr, 100665016);
				SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5>.NativeClassPtr, 100665017);
				SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5>.NativeClassPtr, 100665018);
				SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5>.NativeClassPtr, 100665019);
				SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5>.NativeClassPtr, 100665020);
				SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5>.NativeClassPtr, 100665021);
				SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5>.NativeClassPtr, 100665022);
				SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5>.NativeClassPtr, 100665023);
				SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5>.NativeClassPtr, 100665024);
			}

			// Token: 0x06001F51 RID: 8017 RVA: 0x0009062C File Offset: 0x0008E82C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _FindRunnableTriggeredAbilities_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F52 RID: 8018 RVA: 0x00090674 File Offset: 0x0008E874
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 560005, XrefRangeEnd = 560015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F53 RID: 8019 RVA: 0x000906A8 File Offset: 0x0008E8A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 560015, XrefRangeEnd = 560065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001F54 RID: 8020 RVA: 0x000906E4 File Offset: 0x0008E8E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 560065, XrefRangeEnd = 560068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F55 RID: 8021 RVA: 0x00090718 File Offset: 0x0008E918
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 560068, XrefRangeEnd = 560071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000768 RID: 1896
			// (get) Token: 0x06001F56 RID: 8022 RVA: 0x0009074C File Offset: 0x0008E94C
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06001F57 RID: 8023 RVA: 0x0009078C File Offset: 0x0008E98C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000769 RID: 1897
			// (get) Token: 0x06001F58 RID: 8024 RVA: 0x000907C0 File Offset: 0x0008E9C0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001F59 RID: 8025 RVA: 0x00090800 File Offset: 0x0008EA00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 560071, XrefRangeEnd = 560080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06001F5A RID: 8026 RVA: 0x00090840 File Offset: 0x0008EA40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 560080, XrefRangeEnd = 560089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001F5B RID: 8027 RVA: 0x0000F0FF File Offset: 0x0000D2FF
			public _FindRunnableTriggeredAbilities_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700075C RID: 1884
			// (get) Token: 0x06001F5C RID: 8028 RVA: 0x00090880 File Offset: 0x0008EA80
			// (set) Token: 0x06001F5D RID: 8029 RVA: 0x0000F108 File Offset: 0x0000D308
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700075D RID: 1885
			// (get) Token: 0x06001F5E RID: 8030 RVA: 0x000908A8 File Offset: 0x0008EAA8
			// (set) Token: 0x06001F5F RID: 8031 RVA: 0x0000F123 File Offset: 0x0000D323
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700075E RID: 1886
			// (get) Token: 0x06001F60 RID: 8032 RVA: 0x000908D8 File Offset: 0x0008EAD8
			// (set) Token: 0x06001F61 RID: 8033 RVA: 0x0000F142 File Offset: 0x0000D342
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700075F RID: 1887
			// (get) Token: 0x06001F62 RID: 8034 RVA: 0x00090900 File Offset: 0x0008EB00
			// (set) Token: 0x06001F63 RID: 8035 RVA: 0x0000F15D File Offset: 0x0000D35D
			public unsafe SerializableEvent serializableEvent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeFieldInfoPtr_serializableEvent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeFieldInfoPtr_serializableEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000760 RID: 1888
			// (get) Token: 0x06001F64 RID: 8036 RVA: 0x00090930 File Offset: 0x0008EB30
			// (set) Token: 0x06001F65 RID: 8037 RVA: 0x0000F17C File Offset: 0x0000D37C
			public unsafe SerializableEvent __3__serializableEvent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeFieldInfoPtr___3__serializableEvent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeFieldInfoPtr___3__serializableEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000761 RID: 1889
			// (get) Token: 0x06001F66 RID: 8038 RVA: 0x00090960 File Offset: 0x0008EB60
			// (set) Token: 0x06001F67 RID: 8039 RVA: 0x0000F19B File Offset: 0x0000D39B
			public unsafe IEnumerable<ITriggeredAbility> triggeredAbilities
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeFieldInfoPtr_triggeredAbilities);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<ITriggeredAbility>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeFieldInfoPtr_triggeredAbilities), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000762 RID: 1890
			// (get) Token: 0x06001F68 RID: 8040 RVA: 0x00090990 File Offset: 0x0008EB90
			// (set) Token: 0x06001F69 RID: 8041 RVA: 0x0000F1BA File Offset: 0x0000D3BA
			public unsafe IEnumerable<ITriggeredAbility> __3__triggeredAbilities
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeFieldInfoPtr___3__triggeredAbilities);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<ITriggeredAbility>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeFieldInfoPtr___3__triggeredAbilities), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000763 RID: 1891
			// (get) Token: 0x06001F6A RID: 8042 RVA: 0x000909C0 File Offset: 0x0008EBC0
			// (set) Token: 0x06001F6B RID: 8043 RVA: 0x0000F1D9 File Offset: 0x0000D3D9
			public unsafe SerializableEventReactor<TMatch> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableEventReactor<TMatch>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000764 RID: 1892
			// (get) Token: 0x06001F6C RID: 8044 RVA: 0x000909F0 File Offset: 0x0008EBF0
			// (set) Token: 0x06001F6D RID: 8045 RVA: 0x0000F1F8 File Offset: 0x0000D3F8
			public unsafe Context _paramContext_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeFieldInfoPtr__paramContext_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeFieldInfoPtr__paramContext_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000765 RID: 1893
			// (get) Token: 0x06001F6E RID: 8046 RVA: 0x00090A20 File Offset: 0x0008EC20
			// (set) Token: 0x06001F6F RID: 8047 RVA: 0x0000F217 File Offset: 0x0000D417
			public unsafe IEnumerator<ITriggeredAbility> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<ITriggeredAbility>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000766 RID: 1894
			// (get) Token: 0x06001F70 RID: 8048 RVA: 0x00090A50 File Offset: 0x0008EC50
			// (set) Token: 0x06001F71 RID: 8049 RVA: 0x0000F236 File Offset: 0x0000D436
			public unsafe ITriggeredAbility _triggered_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeFieldInfoPtr__triggered_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITriggeredAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeFieldInfoPtr__triggered_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000767 RID: 1895
			// (get) Token: 0x06001F72 RID: 8050 RVA: 0x00090A80 File Offset: 0x0008EC80
			// (set) Token: 0x06001F73 RID: 8051 RVA: 0x0000F255 File Offset: 0x0000D455
			public unsafe IEnumerator<PlayerEntity> __7__wrap4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeFieldInfoPtr___7__wrap4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<PlayerEntity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableEventReactor<TMatch>._FindRunnableTriggeredAbilities_d__5.NativeFieldInfoPtr___7__wrap4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040013C0 RID: 5056
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040013C1 RID: 5057
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040013C2 RID: 5058
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040013C3 RID: 5059
			private static readonly IntPtr NativeFieldInfoPtr_serializableEvent;

			// Token: 0x040013C4 RID: 5060
			private static readonly IntPtr NativeFieldInfoPtr___3__serializableEvent;

			// Token: 0x040013C5 RID: 5061
			private static readonly IntPtr NativeFieldInfoPtr_triggeredAbilities;

			// Token: 0x040013C6 RID: 5062
			private static readonly IntPtr NativeFieldInfoPtr___3__triggeredAbilities;

			// Token: 0x040013C7 RID: 5063
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040013C8 RID: 5064
			private static readonly IntPtr NativeFieldInfoPtr__paramContext_5__2;

			// Token: 0x040013C9 RID: 5065
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x040013CA RID: 5066
			private static readonly IntPtr NativeFieldInfoPtr__triggered_5__4;

			// Token: 0x040013CB RID: 5067
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap4;

			// Token: 0x040013CC RID: 5068
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040013CD RID: 5069
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040013CE RID: 5070
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040013CF RID: 5071
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040013D0 RID: 5072
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x040013D1 RID: 5073
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040013D2 RID: 5074
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040013D3 RID: 5075
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040013D4 RID: 5076
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040013D5 RID: 5077
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
