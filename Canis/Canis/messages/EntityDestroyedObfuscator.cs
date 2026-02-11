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
	// Token: 0x0200016B RID: 363
	public class EntityDestroyedObfuscator : MessageObfuscator<EntityDestroyed>
	{
		// Token: 0x06001036 RID: 4150 RVA: 0x0005B178 File Offset: 0x00059378
		// Note: this type is marked as 'beforefieldinit'.
		static EntityDestroyedObfuscator()
		{
			Il2CppClassPointerStore<EntityDestroyedObfuscator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.messages", "EntityDestroyedObfuscator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityDestroyedObfuscator>.NativeClassPtr);
			EntityDestroyedObfuscator.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityDestroyedObfuscator>.NativeClassPtr, "Instance");
			EntityDestroyedObfuscator.NativeMethodInfoPtr_Obfuscate_Public_Virtual_IEnumerable_1_NetworkMessageEvent_EntityDestroyed_Match_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDestroyedObfuscator>.NativeClassPtr, 100666602);
			EntityDestroyedObfuscator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDestroyedObfuscator>.NativeClassPtr, 100666603);
		}

		// Token: 0x06001037 RID: 4151 RVA: 0x0005B1E4 File Offset: 0x000593E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 579189, XrefRangeEnd = 579197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<NetworkMessageEvent> Obfuscate(EntityDestroyed message, Match match, PlayerEntity player)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityDestroyedObfuscator.NativeMethodInfoPtr_Obfuscate_Public_Virtual_IEnumerable_1_NetworkMessageEvent_EntityDestroyed_Match_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<NetworkMessageEvent>>(intPtr3) : null;
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x0005B264 File Offset: 0x00059464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 579197, XrefRangeEnd = 579200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityDestroyedObfuscator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityDestroyedObfuscator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityDestroyedObfuscator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x0000840E File Offset: 0x0000660E
		public EntityDestroyedObfuscator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x0600103A RID: 4154 RVA: 0x0005B2A0 File Offset: 0x000594A0
		// (set) Token: 0x0600103B RID: 4155 RVA: 0x00008417 File Offset: 0x00006617
		public unsafe static EntityDestroyedObfuscator Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityDestroyedObfuscator.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityDestroyedObfuscator>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityDestroyedObfuscator.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AB0 RID: 2736
		private static readonly IntPtr NativeFieldInfoPtr_Instance;

		// Token: 0x04000AB1 RID: 2737
		private static readonly IntPtr NativeMethodInfoPtr_Obfuscate_Public_Virtual_IEnumerable_1_NetworkMessageEvent_EntityDestroyed_Match_PlayerEntity_0;

		// Token: 0x04000AB2 RID: 2738
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003A5 RID: 933
		[ObfuscatedName("Canis.messages.EntityDestroyedObfuscator+<Obfuscate>d__1")]
		public sealed class _Obfuscate_d__1 : Object
		{
			// Token: 0x060026ED RID: 9965 RVA: 0x000AAE84 File Offset: 0x000A9084
			// Note: this type is marked as 'beforefieldinit'.
			static _Obfuscate_d__1()
			{
				Il2CppClassPointerStore<EntityDestroyedObfuscator._Obfuscate_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntityDestroyedObfuscator>.NativeClassPtr, "<Obfuscate>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityDestroyedObfuscator._Obfuscate_d__1>.NativeClassPtr);
				EntityDestroyedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityDestroyedObfuscator._Obfuscate_d__1>.NativeClassPtr, "<>1__state");
				EntityDestroyedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityDestroyedObfuscator._Obfuscate_d__1>.NativeClassPtr, "<>2__current");
				EntityDestroyedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityDestroyedObfuscator._Obfuscate_d__1>.NativeClassPtr, "<>l__initialThreadId");
				EntityDestroyedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityDestroyedObfuscator._Obfuscate_d__1>.NativeClassPtr, "match");
				EntityDestroyedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityDestroyedObfuscator._Obfuscate_d__1>.NativeClassPtr, "<>3__match");
				EntityDestroyedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityDestroyedObfuscator._Obfuscate_d__1>.NativeClassPtr, "message");
				EntityDestroyedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___3__message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityDestroyedObfuscator._Obfuscate_d__1>.NativeClassPtr, "<>3__message");
				EntityDestroyedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityDestroyedObfuscator._Obfuscate_d__1>.NativeClassPtr, "player");
				EntityDestroyedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___3__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityDestroyedObfuscator._Obfuscate_d__1>.NativeClassPtr, "<>3__player");
				EntityDestroyedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr__destroyedEntity_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityDestroyedObfuscator._Obfuscate_d__1>.NativeClassPtr, "<destroyedEntity>5__2");
				EntityDestroyedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr__playerID_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityDestroyedObfuscator._Obfuscate_d__1>.NativeClassPtr, "<playerID>5__3");
				EntityDestroyedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr__parent_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityDestroyedObfuscator._Obfuscate_d__1>.NativeClassPtr, "<parent>5__4");
				EntityDestroyedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___7__wrap4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityDestroyedObfuscator._Obfuscate_d__1>.NativeClassPtr, "<>7__wrap4");
				EntityDestroyedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDestroyedObfuscator._Obfuscate_d__1>.NativeClassPtr, 100666605);
				EntityDestroyedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDestroyedObfuscator._Obfuscate_d__1>.NativeClassPtr, 100666606);
				EntityDestroyedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDestroyedObfuscator._Obfuscate_d__1>.NativeClassPtr, 100666607);
				EntityDestroyedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDestroyedObfuscator._Obfuscate_d__1>.NativeClassPtr, 100666608);
				EntityDestroyedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_json_events_NetworkMessageEvent__get_Current_Private_Virtual_Final_New_get_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDestroyedObfuscator._Obfuscate_d__1>.NativeClassPtr, 100666609);
				EntityDestroyedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDestroyedObfuscator._Obfuscate_d__1>.NativeClassPtr, 100666610);
				EntityDestroyedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDestroyedObfuscator._Obfuscate_d__1>.NativeClassPtr, 100666611);
				EntityDestroyedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_json_events_NetworkMessageEvent__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDestroyedObfuscator._Obfuscate_d__1>.NativeClassPtr, 100666612);
				EntityDestroyedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDestroyedObfuscator._Obfuscate_d__1>.NativeClassPtr, 100666613);
			}

			// Token: 0x060026EE RID: 9966 RVA: 0x000AB068 File Offset: 0x000A9268
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Obfuscate_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityDestroyedObfuscator._Obfuscate_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityDestroyedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060026EF RID: 9967 RVA: 0x000AB0B0 File Offset: 0x000A92B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 579110, XrefRangeEnd = 579115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityDestroyedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060026F0 RID: 9968 RVA: 0x000AB0E4 File Offset: 0x000A92E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 579115, XrefRangeEnd = 579171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityDestroyedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060026F1 RID: 9969 RVA: 0x000AB120 File Offset: 0x000A9320
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 579171, XrefRangeEnd = 579174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityDestroyedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170009AE RID: 2478
			// (get) Token: 0x060026F2 RID: 9970 RVA: 0x000AB154 File Offset: 0x000A9354
			public unsafe NetworkMessageEvent System.Collections.Generic.IEnumerator<Canis.json.events.NetworkMessageEvent>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityDestroyedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_json_events_NetworkMessageEvent__get_Current_Private_Virtual_Final_New_get_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkMessageEvent>(intPtr3) : null;
				}
			}

			// Token: 0x060026F3 RID: 9971 RVA: 0x000AB194 File Offset: 0x000A9394
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 579174, XrefRangeEnd = 579179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityDestroyedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170009AF RID: 2479
			// (get) Token: 0x060026F4 RID: 9972 RVA: 0x000AB1C8 File Offset: 0x000A93C8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityDestroyedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060026F5 RID: 9973 RVA: 0x000AB208 File Offset: 0x000A9408
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 579179, XrefRangeEnd = 579189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<NetworkMessageEvent> System_Collections_Generic_IEnumerable_Canis_json_events_NetworkMessageEvent__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityDestroyedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_json_events_NetworkMessageEvent__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<NetworkMessageEvent>>(intPtr3) : null;
			}

			// Token: 0x060026F6 RID: 9974 RVA: 0x000AB248 File Offset: 0x000A9448
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityDestroyedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060026F7 RID: 9975 RVA: 0x00012944 File Offset: 0x00010B44
			public _Obfuscate_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009A1 RID: 2465
			// (get) Token: 0x060026F8 RID: 9976 RVA: 0x000AB288 File Offset: 0x000A9488
			// (set) Token: 0x060026F9 RID: 9977 RVA: 0x0001294D File Offset: 0x00010B4D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityDestroyedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityDestroyedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170009A2 RID: 2466
			// (get) Token: 0x060026FA RID: 9978 RVA: 0x000AB2B0 File Offset: 0x000A94B0
			// (set) Token: 0x060026FB RID: 9979 RVA: 0x00012968 File Offset: 0x00010B68
			public unsafe NetworkMessageEvent __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityDestroyedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkMessageEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityDestroyedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009A3 RID: 2467
			// (get) Token: 0x060026FC RID: 9980 RVA: 0x000AB2E0 File Offset: 0x000A94E0
			// (set) Token: 0x060026FD RID: 9981 RVA: 0x00012987 File Offset: 0x00010B87
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityDestroyedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityDestroyedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170009A4 RID: 2468
			// (get) Token: 0x060026FE RID: 9982 RVA: 0x000AB308 File Offset: 0x000A9508
			// (set) Token: 0x060026FF RID: 9983 RVA: 0x000129A2 File Offset: 0x00010BA2
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityDestroyedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityDestroyedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009A5 RID: 2469
			// (get) Token: 0x06002700 RID: 9984 RVA: 0x000AB338 File Offset: 0x000A9538
			// (set) Token: 0x06002701 RID: 9985 RVA: 0x000129C1 File Offset: 0x00010BC1
			public unsafe Match __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityDestroyedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityDestroyedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009A6 RID: 2470
			// (get) Token: 0x06002702 RID: 9986 RVA: 0x000AB368 File Offset: 0x000A9568
			// (set) Token: 0x06002703 RID: 9987 RVA: 0x000129E0 File Offset: 0x00010BE0
			public unsafe EntityDestroyed message
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityDestroyedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr_message);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityDestroyed>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityDestroyedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009A7 RID: 2471
			// (get) Token: 0x06002704 RID: 9988 RVA: 0x000AB398 File Offset: 0x000A9598
			// (set) Token: 0x06002705 RID: 9989 RVA: 0x000129FF File Offset: 0x00010BFF
			public unsafe EntityDestroyed __3__message
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityDestroyedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___3__message);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityDestroyed>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityDestroyedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___3__message), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009A8 RID: 2472
			// (get) Token: 0x06002706 RID: 9990 RVA: 0x000AB3C8 File Offset: 0x000A95C8
			// (set) Token: 0x06002707 RID: 9991 RVA: 0x00012A1E File Offset: 0x00010C1E
			public unsafe PlayerEntity player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityDestroyedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityDestroyedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009A9 RID: 2473
			// (get) Token: 0x06002708 RID: 9992 RVA: 0x000AB3F8 File Offset: 0x000A95F8
			// (set) Token: 0x06002709 RID: 9993 RVA: 0x00012A3D File Offset: 0x00010C3D
			public unsafe PlayerEntity __3__player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityDestroyedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___3__player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityDestroyedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___3__player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009AA RID: 2474
			// (get) Token: 0x0600270A RID: 9994 RVA: 0x000AB428 File Offset: 0x000A9628
			// (set) Token: 0x0600270B RID: 9995 RVA: 0x00012A5C File Offset: 0x00010C5C
			public unsafe Entity _destroyedEntity_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityDestroyedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr__destroyedEntity_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityDestroyedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr__destroyedEntity_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009AB RID: 2475
			// (get) Token: 0x0600270C RID: 9996 RVA: 0x000AB458 File Offset: 0x000A9658
			// (set) Token: 0x0600270D RID: 9997 RVA: 0x00012A7B File Offset: 0x00010C7B
			public unsafe AccountID _playerID_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityDestroyedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr__playerID_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityDestroyedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr__playerID_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009AC RID: 2476
			// (get) Token: 0x0600270E RID: 9998 RVA: 0x000AB488 File Offset: 0x000A9688
			// (set) Token: 0x0600270F RID: 9999 RVA: 0x00012A9A File Offset: 0x00010C9A
			public unsafe Entity _parent_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityDestroyedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr__parent_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityDestroyedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr__parent_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009AD RID: 2477
			// (get) Token: 0x06002710 RID: 10000 RVA: 0x000AB4B8 File Offset: 0x000A96B8
			// (set) Token: 0x06002711 RID: 10001 RVA: 0x00012AB9 File Offset: 0x00010CB9
			public unsafe IEnumerator<IAttribute<Nullable<int>>> __7__wrap4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityDestroyedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___7__wrap4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<IAttribute<Nullable<int>>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityDestroyedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___7__wrap4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400184A RID: 6218
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400184B RID: 6219
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400184C RID: 6220
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400184D RID: 6221
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x0400184E RID: 6222
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x0400184F RID: 6223
			private static readonly IntPtr NativeFieldInfoPtr_message;

			// Token: 0x04001850 RID: 6224
			private static readonly IntPtr NativeFieldInfoPtr___3__message;

			// Token: 0x04001851 RID: 6225
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04001852 RID: 6226
			private static readonly IntPtr NativeFieldInfoPtr___3__player;

			// Token: 0x04001853 RID: 6227
			private static readonly IntPtr NativeFieldInfoPtr__destroyedEntity_5__2;

			// Token: 0x04001854 RID: 6228
			private static readonly IntPtr NativeFieldInfoPtr__playerID_5__3;

			// Token: 0x04001855 RID: 6229
			private static readonly IntPtr NativeFieldInfoPtr__parent_5__4;

			// Token: 0x04001856 RID: 6230
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap4;

			// Token: 0x04001857 RID: 6231
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001858 RID: 6232
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001859 RID: 6233
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400185A RID: 6234
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400185B RID: 6235
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_json_events_NetworkMessageEvent__get_Current_Private_Virtual_Final_New_get_NetworkMessageEvent_0;

			// Token: 0x0400185C RID: 6236
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400185D RID: 6237
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400185E RID: 6238
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_json_events_NetworkMessageEvent__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_NetworkMessageEvent_0;

			// Token: 0x0400185F RID: 6239
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
