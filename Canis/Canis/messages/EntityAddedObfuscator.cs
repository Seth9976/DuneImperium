using System;
using Canis.attributes;
using Canis.entities;
using Canis.json.events;
using Canis.obfuscation;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.messages
{
	// Token: 0x0200016A RID: 362
	public class EntityAddedObfuscator : MessageObfuscator<EntityAdded>
	{
		// Token: 0x06001030 RID: 4144 RVA: 0x0005B028 File Offset: 0x00059228
		// Note: this type is marked as 'beforefieldinit'.
		static EntityAddedObfuscator()
		{
			Il2CppClassPointerStore<EntityAddedObfuscator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.messages", "EntityAddedObfuscator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityAddedObfuscator>.NativeClassPtr);
			EntityAddedObfuscator.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityAddedObfuscator>.NativeClassPtr, "Instance");
			EntityAddedObfuscator.NativeMethodInfoPtr_Obfuscate_Public_Virtual_IEnumerable_1_NetworkMessageEvent_EntityAdded_Match_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityAddedObfuscator>.NativeClassPtr, 100666590);
			EntityAddedObfuscator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityAddedObfuscator>.NativeClassPtr, 100666591);
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x0005B094 File Offset: 0x00059294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 579099, XrefRangeEnd = 579107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<NetworkMessageEvent> Obfuscate(EntityAdded message, Match match, PlayerEntity player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityAddedObfuscator.NativeMethodInfoPtr_Obfuscate_Public_Virtual_IEnumerable_1_NetworkMessageEvent_EntityAdded_Match_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<NetworkMessageEvent>>(intPtr3) : null;
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x0005B114 File Offset: 0x00059314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 579107, XrefRangeEnd = 579110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityAddedObfuscator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityAddedObfuscator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityAddedObfuscator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x000083F3 File Offset: 0x000065F3
		public EntityAddedObfuscator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06001034 RID: 4148 RVA: 0x0005B150 File Offset: 0x00059350
		// (set) Token: 0x06001035 RID: 4149 RVA: 0x000083FC File Offset: 0x000065FC
		public unsafe static EntityAddedObfuscator Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityAddedObfuscator.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityAddedObfuscator>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityAddedObfuscator.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AAD RID: 2733
		private static readonly IntPtr NativeFieldInfoPtr_Instance;

		// Token: 0x04000AAE RID: 2734
		private static readonly IntPtr NativeMethodInfoPtr_Obfuscate_Public_Virtual_IEnumerable_1_NetworkMessageEvent_EntityAdded_Match_PlayerEntity_0;

		// Token: 0x04000AAF RID: 2735
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003A4 RID: 932
		[ObfuscatedName("Canis.messages.EntityAddedObfuscator+<Obfuscate>d__1")]
		public sealed class _Obfuscate_d__1 : Object
		{
			// Token: 0x060026C8 RID: 9928 RVA: 0x000AA820 File Offset: 0x000A8A20
			// Note: this type is marked as 'beforefieldinit'.
			static _Obfuscate_d__1()
			{
				Il2CppClassPointerStore<EntityAddedObfuscator._Obfuscate_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntityAddedObfuscator>.NativeClassPtr, "<Obfuscate>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityAddedObfuscator._Obfuscate_d__1>.NativeClassPtr);
				EntityAddedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityAddedObfuscator._Obfuscate_d__1>.NativeClassPtr, "<>1__state");
				EntityAddedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityAddedObfuscator._Obfuscate_d__1>.NativeClassPtr, "<>2__current");
				EntityAddedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityAddedObfuscator._Obfuscate_d__1>.NativeClassPtr, "<>l__initialThreadId");
				EntityAddedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityAddedObfuscator._Obfuscate_d__1>.NativeClassPtr, "match");
				EntityAddedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityAddedObfuscator._Obfuscate_d__1>.NativeClassPtr, "<>3__match");
				EntityAddedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityAddedObfuscator._Obfuscate_d__1>.NativeClassPtr, "message");
				EntityAddedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___3__message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityAddedObfuscator._Obfuscate_d__1>.NativeClassPtr, "<>3__message");
				EntityAddedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityAddedObfuscator._Obfuscate_d__1>.NativeClassPtr, "player");
				EntityAddedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___3__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityAddedObfuscator._Obfuscate_d__1>.NativeClassPtr, "<>3__player");
				EntityAddedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr__addedEntity_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityAddedObfuscator._Obfuscate_d__1>.NativeClassPtr, "<addedEntity>5__2");
				EntityAddedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr__playerID_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityAddedObfuscator._Obfuscate_d__1>.NativeClassPtr, "<playerID>5__3");
				EntityAddedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr__parent_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityAddedObfuscator._Obfuscate_d__1>.NativeClassPtr, "<parent>5__4");
				EntityAddedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___7__wrap4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityAddedObfuscator._Obfuscate_d__1>.NativeClassPtr, "<>7__wrap4");
				EntityAddedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityAddedObfuscator._Obfuscate_d__1>.NativeClassPtr, 100666593);
				EntityAddedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityAddedObfuscator._Obfuscate_d__1>.NativeClassPtr, 100666594);
				EntityAddedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityAddedObfuscator._Obfuscate_d__1>.NativeClassPtr, 100666595);
				EntityAddedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityAddedObfuscator._Obfuscate_d__1>.NativeClassPtr, 100666596);
				EntityAddedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_json_events_NetworkMessageEvent__get_Current_Private_Virtual_Final_New_get_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityAddedObfuscator._Obfuscate_d__1>.NativeClassPtr, 100666597);
				EntityAddedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityAddedObfuscator._Obfuscate_d__1>.NativeClassPtr, 100666598);
				EntityAddedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityAddedObfuscator._Obfuscate_d__1>.NativeClassPtr, 100666599);
				EntityAddedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_json_events_NetworkMessageEvent__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityAddedObfuscator._Obfuscate_d__1>.NativeClassPtr, 100666600);
				EntityAddedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityAddedObfuscator._Obfuscate_d__1>.NativeClassPtr, 100666601);
			}

			// Token: 0x060026C9 RID: 9929 RVA: 0x000AAA04 File Offset: 0x000A8C04
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Obfuscate_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityAddedObfuscator._Obfuscate_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityAddedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060026CA RID: 9930 RVA: 0x000AAA4C File Offset: 0x000A8C4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 579022, XrefRangeEnd = 579027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityAddedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060026CB RID: 9931 RVA: 0x000AAA80 File Offset: 0x000A8C80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 579027, XrefRangeEnd = 579081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityAddedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060026CC RID: 9932 RVA: 0x000AAABC File Offset: 0x000A8CBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 579081, XrefRangeEnd = 579084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityAddedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700099F RID: 2463
			// (get) Token: 0x060026CD RID: 9933 RVA: 0x000AAAF0 File Offset: 0x000A8CF0
			public unsafe NetworkMessageEvent System.Collections.Generic.IEnumerator<Canis.json.events.NetworkMessageEvent>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityAddedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_json_events_NetworkMessageEvent__get_Current_Private_Virtual_Final_New_get_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkMessageEvent>(intPtr3) : null;
				}
			}

			// Token: 0x060026CE RID: 9934 RVA: 0x000AAB30 File Offset: 0x000A8D30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 579084, XrefRangeEnd = 579089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityAddedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170009A0 RID: 2464
			// (get) Token: 0x060026CF RID: 9935 RVA: 0x000AAB64 File Offset: 0x000A8D64
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityAddedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060026D0 RID: 9936 RVA: 0x000AABA4 File Offset: 0x000A8DA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 579089, XrefRangeEnd = 579099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<NetworkMessageEvent> System_Collections_Generic_IEnumerable_Canis_json_events_NetworkMessageEvent__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityAddedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_json_events_NetworkMessageEvent__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<NetworkMessageEvent>>(intPtr3) : null;
			}

			// Token: 0x060026D1 RID: 9937 RVA: 0x000AABE4 File Offset: 0x000A8DE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityAddedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060026D2 RID: 9938 RVA: 0x000127B0 File Offset: 0x000109B0
			public _Obfuscate_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000992 RID: 2450
			// (get) Token: 0x060026D3 RID: 9939 RVA: 0x000AAC24 File Offset: 0x000A8E24
			// (set) Token: 0x060026D4 RID: 9940 RVA: 0x000127B9 File Offset: 0x000109B9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityAddedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityAddedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000993 RID: 2451
			// (get) Token: 0x060026D5 RID: 9941 RVA: 0x000AAC4C File Offset: 0x000A8E4C
			// (set) Token: 0x060026D6 RID: 9942 RVA: 0x000127D4 File Offset: 0x000109D4
			public unsafe NetworkMessageEvent __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityAddedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkMessageEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityAddedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000994 RID: 2452
			// (get) Token: 0x060026D7 RID: 9943 RVA: 0x000AAC7C File Offset: 0x000A8E7C
			// (set) Token: 0x060026D8 RID: 9944 RVA: 0x000127F3 File Offset: 0x000109F3
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityAddedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityAddedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000995 RID: 2453
			// (get) Token: 0x060026D9 RID: 9945 RVA: 0x000AACA4 File Offset: 0x000A8EA4
			// (set) Token: 0x060026DA RID: 9946 RVA: 0x0001280E File Offset: 0x00010A0E
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityAddedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityAddedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000996 RID: 2454
			// (get) Token: 0x060026DB RID: 9947 RVA: 0x000AACD4 File Offset: 0x000A8ED4
			// (set) Token: 0x060026DC RID: 9948 RVA: 0x0001282D File Offset: 0x00010A2D
			public unsafe Match __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityAddedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityAddedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000997 RID: 2455
			// (get) Token: 0x060026DD RID: 9949 RVA: 0x000AAD04 File Offset: 0x000A8F04
			// (set) Token: 0x060026DE RID: 9950 RVA: 0x0001284C File Offset: 0x00010A4C
			public unsafe EntityAdded message
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityAddedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr_message);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityAdded>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityAddedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000998 RID: 2456
			// (get) Token: 0x060026DF RID: 9951 RVA: 0x000AAD34 File Offset: 0x000A8F34
			// (set) Token: 0x060026E0 RID: 9952 RVA: 0x0001286B File Offset: 0x00010A6B
			public unsafe EntityAdded __3__message
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityAddedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___3__message);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityAdded>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityAddedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___3__message), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000999 RID: 2457
			// (get) Token: 0x060026E1 RID: 9953 RVA: 0x000AAD64 File Offset: 0x000A8F64
			// (set) Token: 0x060026E2 RID: 9954 RVA: 0x0001288A File Offset: 0x00010A8A
			public unsafe PlayerEntity player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityAddedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityAddedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700099A RID: 2458
			// (get) Token: 0x060026E3 RID: 9955 RVA: 0x000AAD94 File Offset: 0x000A8F94
			// (set) Token: 0x060026E4 RID: 9956 RVA: 0x000128A9 File Offset: 0x00010AA9
			public unsafe PlayerEntity __3__player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityAddedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___3__player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityAddedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___3__player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700099B RID: 2459
			// (get) Token: 0x060026E5 RID: 9957 RVA: 0x000AADC4 File Offset: 0x000A8FC4
			// (set) Token: 0x060026E6 RID: 9958 RVA: 0x000128C8 File Offset: 0x00010AC8
			public unsafe Entity _addedEntity_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityAddedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr__addedEntity_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityAddedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr__addedEntity_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700099C RID: 2460
			// (get) Token: 0x060026E7 RID: 9959 RVA: 0x000AADF4 File Offset: 0x000A8FF4
			// (set) Token: 0x060026E8 RID: 9960 RVA: 0x000128E7 File Offset: 0x00010AE7
			public unsafe AccountID _playerID_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityAddedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr__playerID_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityAddedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr__playerID_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700099D RID: 2461
			// (get) Token: 0x060026E9 RID: 9961 RVA: 0x000AAE24 File Offset: 0x000A9024
			// (set) Token: 0x060026EA RID: 9962 RVA: 0x00012906 File Offset: 0x00010B06
			public unsafe Entity _parent_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityAddedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr__parent_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityAddedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr__parent_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700099E RID: 2462
			// (get) Token: 0x060026EB RID: 9963 RVA: 0x000AAE54 File Offset: 0x000A9054
			// (set) Token: 0x060026EC RID: 9964 RVA: 0x00012925 File Offset: 0x00010B25
			public unsafe IEnumerator<IAttribute<Nullable<int>>> __7__wrap4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityAddedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___7__wrap4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<IAttribute<Nullable<int>>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityAddedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___7__wrap4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001834 RID: 6196
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001835 RID: 6197
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001836 RID: 6198
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001837 RID: 6199
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04001838 RID: 6200
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04001839 RID: 6201
			private static readonly IntPtr NativeFieldInfoPtr_message;

			// Token: 0x0400183A RID: 6202
			private static readonly IntPtr NativeFieldInfoPtr___3__message;

			// Token: 0x0400183B RID: 6203
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x0400183C RID: 6204
			private static readonly IntPtr NativeFieldInfoPtr___3__player;

			// Token: 0x0400183D RID: 6205
			private static readonly IntPtr NativeFieldInfoPtr__addedEntity_5__2;

			// Token: 0x0400183E RID: 6206
			private static readonly IntPtr NativeFieldInfoPtr__playerID_5__3;

			// Token: 0x0400183F RID: 6207
			private static readonly IntPtr NativeFieldInfoPtr__parent_5__4;

			// Token: 0x04001840 RID: 6208
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap4;

			// Token: 0x04001841 RID: 6209
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001842 RID: 6210
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001843 RID: 6211
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001844 RID: 6212
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001845 RID: 6213
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_json_events_NetworkMessageEvent__get_Current_Private_Virtual_Final_New_get_NetworkMessageEvent_0;

			// Token: 0x04001846 RID: 6214
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001847 RID: 6215
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001848 RID: 6216
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_json_events_NetworkMessageEvent__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_NetworkMessageEvent_0;

			// Token: 0x04001849 RID: 6217
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
