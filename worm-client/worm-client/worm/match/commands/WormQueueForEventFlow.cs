using System;
using Canis.utils.ids;
using dwd.core.commands;
using dwd.core.data.composition;
using dwd.core.session.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using worm.components;
using worm.match.prompts.prompts;
using worm.networking.responses;

namespace worm.match.commands
{
	// Token: 0x02000239 RID: 569
	public class WormQueueForEventFlow : Command
	{
		// Token: 0x060018A0 RID: 6304 RVA: 0x00062EC8 File Offset: 0x000610C8
		// Note: this type is marked as 'beforefieldinit'.
		static WormQueueForEventFlow()
		{
			Il2CppClassPointerStore<WormQueueForEventFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands", "WormQueueForEventFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormQueueForEventFlow>.NativeClassPtr);
			WormQueueForEventFlow.NativeFieldInfoPtr_eventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormQueueForEventFlow>.NativeClassPtr, "eventData");
			WormQueueForEventFlow.NativeFieldInfoPtr_gameStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormQueueForEventFlow>.NativeClassPtr, "gameStarted");
			WormQueueForEventFlow.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormQueueForEventFlow>.NativeClassPtr, 100666735);
			WormQueueForEventFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormQueueForEventFlow>.NativeClassPtr, 100666736);
			WormQueueForEventFlow.NativeMethodInfoPtr_HandleLobbyGameStarted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormQueueForEventFlow>.NativeClassPtr, 100666737);
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x00062F5C File Offset: 0x0006115C
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 495009, RefRangeEnd = 495046, XrefRangeStart = 495009, XrefRangeEnd = 495046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormQueueForEventFlow(DataComposition eventData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormQueueForEventFlow>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormQueueForEventFlow.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x00062FA8 File Offset: 0x000611A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719003, XrefRangeEnd = 719008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormQueueForEventFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x00062FF4 File Offset: 0x000611F4
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 689957, RefRangeEnd = 689983, XrefRangeStart = 689957, XrefRangeEnd = 689983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleLobbyGameStarted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormQueueForEventFlow.NativeMethodInfoPtr_HandleLobbyGameStarted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x0000E8D3 File Offset: 0x0000CAD3
		public WormQueueForEventFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x060018A5 RID: 6309 RVA: 0x00063028 File Offset: 0x00061228
		// (set) Token: 0x060018A6 RID: 6310 RVA: 0x0000E8DC File Offset: 0x0000CADC
		public unsafe DataComposition eventData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormQueueForEventFlow.NativeFieldInfoPtr_eventData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormQueueForEventFlow.NativeFieldInfoPtr_eventData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x060018A7 RID: 6311 RVA: 0x00063058 File Offset: 0x00061258
		// (set) Token: 0x060018A8 RID: 6312 RVA: 0x0000E8FB File Offset: 0x0000CAFB
		public unsafe bool gameStarted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormQueueForEventFlow.NativeFieldInfoPtr_gameStarted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormQueueForEventFlow.NativeFieldInfoPtr_gameStarted)) = value;
			}
		}

		// Token: 0x04000E43 RID: 3651
		private static readonly IntPtr NativeFieldInfoPtr_eventData;

		// Token: 0x04000E44 RID: 3652
		private static readonly IntPtr NativeFieldInfoPtr_gameStarted;

		// Token: 0x04000E45 RID: 3653
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0;

		// Token: 0x04000E46 RID: 3654
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000E47 RID: 3655
		private static readonly IntPtr NativeMethodInfoPtr_HandleLobbyGameStarted_Private_Void_0;

		// Token: 0x0200040B RID: 1035
		[ObfuscatedName("worm.match.commands.WormQueueForEventFlow+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x06002A87 RID: 10887 RVA: 0x00098DE0 File Offset: 0x00096FE0
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<WormQueueForEventFlow._execute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormQueueForEventFlow>.NativeClassPtr, "<execute>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormQueueForEventFlow._execute_d__3>.NativeClassPtr);
				WormQueueForEventFlow._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormQueueForEventFlow._execute_d__3>.NativeClassPtr, "<>1__state");
				WormQueueForEventFlow._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormQueueForEventFlow._execute_d__3>.NativeClassPtr, "<>2__current");
				WormQueueForEventFlow._execute_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormQueueForEventFlow._execute_d__3>.NativeClassPtr, "<>4__this");
				WormQueueForEventFlow._execute_d__3.NativeFieldInfoPtr__eventsProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormQueueForEventFlow._execute_d__3>.NativeClassPtr, "<eventsProvider>5__2");
				WormQueueForEventFlow._execute_d__3.NativeFieldInfoPtr__eventID_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormQueueForEventFlow._execute_d__3>.NativeClassPtr, "<eventID>5__3");
				WormQueueForEventFlow._execute_d__3.NativeFieldInfoPtr__queue_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormQueueForEventFlow._execute_d__3>.NativeClassPtr, "<queue>5__4");
				WormQueueForEventFlow._execute_d__3.NativeFieldInfoPtr__queuePrompt_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormQueueForEventFlow._execute_d__3>.NativeClassPtr, "<queuePrompt>5__5");
				WormQueueForEventFlow._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormQueueForEventFlow._execute_d__3>.NativeClassPtr, 100666738);
				WormQueueForEventFlow._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormQueueForEventFlow._execute_d__3>.NativeClassPtr, 100666739);
				WormQueueForEventFlow._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormQueueForEventFlow._execute_d__3>.NativeClassPtr, 100666740);
				WormQueueForEventFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormQueueForEventFlow._execute_d__3>.NativeClassPtr, 100666741);
				WormQueueForEventFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormQueueForEventFlow._execute_d__3>.NativeClassPtr, 100666742);
				WormQueueForEventFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormQueueForEventFlow._execute_d__3>.NativeClassPtr, 100666743);
			}

			// Token: 0x06002A88 RID: 10888 RVA: 0x00098F10 File Offset: 0x00097110
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormQueueForEventFlow._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormQueueForEventFlow._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002A89 RID: 10889 RVA: 0x00098F58 File Offset: 0x00097158
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormQueueForEventFlow._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A8A RID: 10890 RVA: 0x00098F8C File Offset: 0x0009718C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718942, XrefRangeEnd = 718998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormQueueForEventFlow._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000C18 RID: 3096
			// (get) Token: 0x06002A8B RID: 10891 RVA: 0x00098FC8 File Offset: 0x000971C8
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormQueueForEventFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002A8C RID: 10892 RVA: 0x00099008 File Offset: 0x00097208
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718998, XrefRangeEnd = 719003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormQueueForEventFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000C19 RID: 3097
			// (get) Token: 0x06002A8D RID: 10893 RVA: 0x0009903C File Offset: 0x0009723C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormQueueForEventFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002A8E RID: 10894 RVA: 0x000173BD File Offset: 0x000155BD
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C11 RID: 3089
			// (get) Token: 0x06002A8F RID: 10895 RVA: 0x0009907C File Offset: 0x0009727C
			// (set) Token: 0x06002A90 RID: 10896 RVA: 0x000173C6 File Offset: 0x000155C6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormQueueForEventFlow._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormQueueForEventFlow._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000C12 RID: 3090
			// (get) Token: 0x06002A91 RID: 10897 RVA: 0x000990A4 File Offset: 0x000972A4
			// (set) Token: 0x06002A92 RID: 10898 RVA: 0x000173E1 File Offset: 0x000155E1
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormQueueForEventFlow._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormQueueForEventFlow._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C13 RID: 3091
			// (get) Token: 0x06002A93 RID: 10899 RVA: 0x000990D4 File Offset: 0x000972D4
			// (set) Token: 0x06002A94 RID: 10900 RVA: 0x00017400 File Offset: 0x00015600
			public unsafe WormQueueForEventFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormQueueForEventFlow._execute_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormQueueForEventFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormQueueForEventFlow._execute_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C14 RID: 3092
			// (get) Token: 0x06002A95 RID: 10901 RVA: 0x00099104 File Offset: 0x00097304
			// (set) Token: 0x06002A96 RID: 10902 RVA: 0x0001741F File Offset: 0x0001561F
			public unsafe WormEventsProvider _eventsProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormQueueForEventFlow._execute_d__3.NativeFieldInfoPtr__eventsProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEventsProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormQueueForEventFlow._execute_d__3.NativeFieldInfoPtr__eventsProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C15 RID: 3093
			// (get) Token: 0x06002A97 RID: 10903 RVA: 0x00099134 File Offset: 0x00097334
			// (set) Token: 0x06002A98 RID: 10904 RVA: 0x0001743E File Offset: 0x0001563E
			public unsafe EventID _eventID_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormQueueForEventFlow._execute_d__3.NativeFieldInfoPtr__eventID_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormQueueForEventFlow._execute_d__3.NativeFieldInfoPtr__eventID_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C16 RID: 3094
			// (get) Token: 0x06002A99 RID: 10905 RVA: 0x00099164 File Offset: 0x00097364
			// (set) Token: 0x06002A9A RID: 10906 RVA: 0x0001745D File Offset: 0x0001565D
			public unsafe WriteToSessionAndAwaitResponse<EventQueueJoined, EventError> _queue_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormQueueForEventFlow._execute_d__3.NativeFieldInfoPtr__queue_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WriteToSessionAndAwaitResponse<EventQueueJoined, EventError>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormQueueForEventFlow._execute_d__3.NativeFieldInfoPtr__queue_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C17 RID: 3095
			// (get) Token: 0x06002A9B RID: 10907 RVA: 0x00099194 File Offset: 0x00097394
			// (set) Token: 0x06002A9C RID: 10908 RVA: 0x0001747C File Offset: 0x0001567C
			public unsafe WormEventQueuePrompt _queuePrompt_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormQueueForEventFlow._execute_d__3.NativeFieldInfoPtr__queuePrompt_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEventQueuePrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormQueueForEventFlow._execute_d__3.NativeFieldInfoPtr__queuePrompt_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040018AC RID: 6316
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040018AD RID: 6317
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040018AE RID: 6318
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040018AF RID: 6319
			private static readonly IntPtr NativeFieldInfoPtr__eventsProvider_5__2;

			// Token: 0x040018B0 RID: 6320
			private static readonly IntPtr NativeFieldInfoPtr__eventID_5__3;

			// Token: 0x040018B1 RID: 6321
			private static readonly IntPtr NativeFieldInfoPtr__queue_5__4;

			// Token: 0x040018B2 RID: 6322
			private static readonly IntPtr NativeFieldInfoPtr__queuePrompt_5__5;

			// Token: 0x040018B3 RID: 6323
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040018B4 RID: 6324
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040018B5 RID: 6325
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040018B6 RID: 6326
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040018B7 RID: 6327
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040018B8 RID: 6328
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
