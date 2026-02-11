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
using worm.networking.responses;

namespace worm.match.commands
{
	// Token: 0x02000238 RID: 568
	public class WormJoinEventFlow : Command
	{
		// Token: 0x06001898 RID: 6296 RVA: 0x00062D58 File Offset: 0x00060F58
		// Note: this type is marked as 'beforefieldinit'.
		static WormJoinEventFlow()
		{
			Il2CppClassPointerStore<WormJoinEventFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands", "WormJoinEventFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormJoinEventFlow>.NativeClassPtr);
			WormJoinEventFlow.NativeFieldInfoPtr_eventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormJoinEventFlow>.NativeClassPtr, "eventData");
			WormJoinEventFlow.NativeFieldInfoPtr_queueJoined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormJoinEventFlow>.NativeClassPtr, "queueJoined");
			WormJoinEventFlow.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormJoinEventFlow>.NativeClassPtr, 100666727);
			WormJoinEventFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormJoinEventFlow>.NativeClassPtr, 100666728);
		}

		// Token: 0x06001899 RID: 6297 RVA: 0x00062DD8 File Offset: 0x00060FD8
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 495009, RefRangeEnd = 495046, XrefRangeStart = 495009, XrefRangeEnd = 495046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormJoinEventFlow(DataComposition eventData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormJoinEventFlow>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormJoinEventFlow.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x00062E24 File Offset: 0x00061024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718937, XrefRangeEnd = 718942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormJoinEventFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x0000E890 File Offset: 0x0000CA90
		public WormJoinEventFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x0600189C RID: 6300 RVA: 0x00062E70 File Offset: 0x00061070
		// (set) Token: 0x0600189D RID: 6301 RVA: 0x0000E899 File Offset: 0x0000CA99
		public unsafe DataComposition eventData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormJoinEventFlow.NativeFieldInfoPtr_eventData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormJoinEventFlow.NativeFieldInfoPtr_eventData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x0600189E RID: 6302 RVA: 0x00062EA0 File Offset: 0x000610A0
		// (set) Token: 0x0600189F RID: 6303 RVA: 0x0000E8B8 File Offset: 0x0000CAB8
		public unsafe bool queueJoined
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormJoinEventFlow.NativeFieldInfoPtr_queueJoined);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormJoinEventFlow.NativeFieldInfoPtr_queueJoined)) = value;
			}
		}

		// Token: 0x04000E3F RID: 3647
		private static readonly IntPtr NativeFieldInfoPtr_eventData;

		// Token: 0x04000E40 RID: 3648
		private static readonly IntPtr NativeFieldInfoPtr_queueJoined;

		// Token: 0x04000E41 RID: 3649
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0;

		// Token: 0x04000E42 RID: 3650
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x0200040A RID: 1034
		[ObfuscatedName("worm.match.commands.WormJoinEventFlow+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x06002A73 RID: 10867 RVA: 0x00098A40 File Offset: 0x00096C40
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<WormJoinEventFlow._execute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormJoinEventFlow>.NativeClassPtr, "<execute>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormJoinEventFlow._execute_d__3>.NativeClassPtr);
				WormJoinEventFlow._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormJoinEventFlow._execute_d__3>.NativeClassPtr, "<>1__state");
				WormJoinEventFlow._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormJoinEventFlow._execute_d__3>.NativeClassPtr, "<>2__current");
				WormJoinEventFlow._execute_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormJoinEventFlow._execute_d__3>.NativeClassPtr, "<>4__this");
				WormJoinEventFlow._execute_d__3.NativeFieldInfoPtr__eventsProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormJoinEventFlow._execute_d__3>.NativeClassPtr, "<eventsProvider>5__2");
				WormJoinEventFlow._execute_d__3.NativeFieldInfoPtr__eventID_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormJoinEventFlow._execute_d__3>.NativeClassPtr, "<eventID>5__3");
				WormJoinEventFlow._execute_d__3.NativeFieldInfoPtr__register_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormJoinEventFlow._execute_d__3>.NativeClassPtr, "<register>5__4");
				WormJoinEventFlow._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormJoinEventFlow._execute_d__3>.NativeClassPtr, 100666729);
				WormJoinEventFlow._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormJoinEventFlow._execute_d__3>.NativeClassPtr, 100666730);
				WormJoinEventFlow._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormJoinEventFlow._execute_d__3>.NativeClassPtr, 100666731);
				WormJoinEventFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormJoinEventFlow._execute_d__3>.NativeClassPtr, 100666732);
				WormJoinEventFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormJoinEventFlow._execute_d__3>.NativeClassPtr, 100666733);
				WormJoinEventFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormJoinEventFlow._execute_d__3>.NativeClassPtr, 100666734);
			}

			// Token: 0x06002A74 RID: 10868 RVA: 0x00098B5C File Offset: 0x00096D5C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormJoinEventFlow._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormJoinEventFlow._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002A75 RID: 10869 RVA: 0x00098BA4 File Offset: 0x00096DA4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormJoinEventFlow._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A76 RID: 10870 RVA: 0x00098BD8 File Offset: 0x00096DD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718901, XrefRangeEnd = 718932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormJoinEventFlow._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000C0F RID: 3087
			// (get) Token: 0x06002A77 RID: 10871 RVA: 0x00098C14 File Offset: 0x00096E14
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormJoinEventFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002A78 RID: 10872 RVA: 0x00098C54 File Offset: 0x00096E54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718932, XrefRangeEnd = 718937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormJoinEventFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000C10 RID: 3088
			// (get) Token: 0x06002A79 RID: 10873 RVA: 0x00098C88 File Offset: 0x00096E88
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormJoinEventFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002A7A RID: 10874 RVA: 0x000172FE File Offset: 0x000154FE
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C09 RID: 3081
			// (get) Token: 0x06002A7B RID: 10875 RVA: 0x00098CC8 File Offset: 0x00096EC8
			// (set) Token: 0x06002A7C RID: 10876 RVA: 0x00017307 File Offset: 0x00015507
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormJoinEventFlow._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormJoinEventFlow._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000C0A RID: 3082
			// (get) Token: 0x06002A7D RID: 10877 RVA: 0x00098CF0 File Offset: 0x00096EF0
			// (set) Token: 0x06002A7E RID: 10878 RVA: 0x00017322 File Offset: 0x00015522
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormJoinEventFlow._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormJoinEventFlow._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C0B RID: 3083
			// (get) Token: 0x06002A7F RID: 10879 RVA: 0x00098D20 File Offset: 0x00096F20
			// (set) Token: 0x06002A80 RID: 10880 RVA: 0x00017341 File Offset: 0x00015541
			public unsafe WormJoinEventFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormJoinEventFlow._execute_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormJoinEventFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormJoinEventFlow._execute_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C0C RID: 3084
			// (get) Token: 0x06002A81 RID: 10881 RVA: 0x00098D50 File Offset: 0x00096F50
			// (set) Token: 0x06002A82 RID: 10882 RVA: 0x00017360 File Offset: 0x00015560
			public unsafe WormEventsProvider _eventsProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormJoinEventFlow._execute_d__3.NativeFieldInfoPtr__eventsProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEventsProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormJoinEventFlow._execute_d__3.NativeFieldInfoPtr__eventsProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C0D RID: 3085
			// (get) Token: 0x06002A83 RID: 10883 RVA: 0x00098D80 File Offset: 0x00096F80
			// (set) Token: 0x06002A84 RID: 10884 RVA: 0x0001737F File Offset: 0x0001557F
			public unsafe EventID _eventID_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormJoinEventFlow._execute_d__3.NativeFieldInfoPtr__eventID_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormJoinEventFlow._execute_d__3.NativeFieldInfoPtr__eventID_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C0E RID: 3086
			// (get) Token: 0x06002A85 RID: 10885 RVA: 0x00098DB0 File Offset: 0x00096FB0
			// (set) Token: 0x06002A86 RID: 10886 RVA: 0x0001739E File Offset: 0x0001559E
			public unsafe WriteToSessionAndAwaitResponse<EventJoined, EventError> _register_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormJoinEventFlow._execute_d__3.NativeFieldInfoPtr__register_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WriteToSessionAndAwaitResponse<EventJoined, EventError>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormJoinEventFlow._execute_d__3.NativeFieldInfoPtr__register_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040018A0 RID: 6304
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040018A1 RID: 6305
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040018A2 RID: 6306
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040018A3 RID: 6307
			private static readonly IntPtr NativeFieldInfoPtr__eventsProvider_5__2;

			// Token: 0x040018A4 RID: 6308
			private static readonly IntPtr NativeFieldInfoPtr__eventID_5__3;

			// Token: 0x040018A5 RID: 6309
			private static readonly IntPtr NativeFieldInfoPtr__register_5__4;

			// Token: 0x040018A6 RID: 6310
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040018A7 RID: 6311
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040018A8 RID: 6312
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040018A9 RID: 6313
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040018AA RID: 6314
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040018AB RID: 6315
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
