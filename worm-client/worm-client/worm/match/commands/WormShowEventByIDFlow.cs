using System;
using Canis.utils.ids;
using dwd.core;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using worm.components;
using worm.networking.responses;

namespace worm.match.commands
{
	// Token: 0x02000240 RID: 576
	public class WormShowEventByIDFlow : Command
	{
		// Token: 0x060018C5 RID: 6341 RVA: 0x00063668 File Offset: 0x00061868
		// Note: this type is marked as 'beforefieldinit'.
		static WormShowEventByIDFlow()
		{
			Il2CppClassPointerStore<WormShowEventByIDFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands", "WormShowEventByIDFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormShowEventByIDFlow>.NativeClassPtr);
			WormShowEventByIDFlow.NativeFieldInfoPtr_eventID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowEventByIDFlow>.NativeClassPtr, "eventID");
			WormShowEventByIDFlow.NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowEventByIDFlow>.NativeClassPtr, "status");
			WormShowEventByIDFlow.NativeMethodInfoPtr__ctor_Public_Void_EventID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowEventByIDFlow>.NativeClassPtr, 100666786);
			WormShowEventByIDFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowEventByIDFlow>.NativeClassPtr, 100666787);
			WormShowEventByIDFlow.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowEventByIDFlow>.NativeClassPtr, 100666788);
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x000636FC File Offset: 0x000618FC
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 495009, RefRangeEnd = 495046, XrefRangeStart = 495009, XrefRangeEnd = 495046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormShowEventByIDFlow(EventID eventID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormShowEventByIDFlow>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowEventByIDFlow.NativeMethodInfoPtr__ctor_Public_Void_EventID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018C7 RID: 6343 RVA: 0x00063748 File Offset: 0x00061948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719250, XrefRangeEnd = 719255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormShowEventByIDFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060018C8 RID: 6344 RVA: 0x00063794 File Offset: 0x00061994
		[CallerCount(0)]
		public unsafe virtual ErrorInfo Status()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowEventByIDFlow.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ErrorInfo(intPtr);
		}

		// Token: 0x060018C9 RID: 6345 RVA: 0x0000E98A File Offset: 0x0000CB8A
		public WormShowEventByIDFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x060018CA RID: 6346 RVA: 0x000637CC File Offset: 0x000619CC
		// (set) Token: 0x060018CB RID: 6347 RVA: 0x0000E993 File Offset: 0x0000CB93
		public unsafe EventID eventID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowEventByIDFlow.NativeFieldInfoPtr_eventID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowEventByIDFlow.NativeFieldInfoPtr_eventID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x060018CC RID: 6348 RVA: 0x000637FC File Offset: 0x000619FC
		// (set) Token: 0x060018CD RID: 6349 RVA: 0x0000E9B2 File Offset: 0x0000CBB2
		public ErrorInfo status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowEventByIDFlow.NativeFieldInfoPtr_status);
				return new ErrorInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowEventByIDFlow.NativeFieldInfoPtr_status), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000E56 RID: 3670
		private static readonly IntPtr NativeFieldInfoPtr_eventID;

		// Token: 0x04000E57 RID: 3671
		private static readonly IntPtr NativeFieldInfoPtr_status;

		// Token: 0x04000E58 RID: 3672
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EventID_0;

		// Token: 0x04000E59 RID: 3673
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000E5A RID: 3674
		private static readonly IntPtr NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0;

		// Token: 0x02000411 RID: 1041
		[ObfuscatedName("worm.match.commands.WormShowEventByIDFlow+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x06002AE9 RID: 10985 RVA: 0x0009A0B4 File Offset: 0x000982B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<WormShowEventByIDFlow.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormShowEventByIDFlow>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormShowEventByIDFlow.__c__DisplayClass3_0>.NativeClassPtr);
				WormShowEventByIDFlow.__c__DisplayClass3_0.NativeFieldInfoPtr_eventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowEventByIDFlow.__c__DisplayClass3_0>.NativeClassPtr, "eventData");
				WormShowEventByIDFlow.__c__DisplayClass3_0.NativeFieldInfoPtr_eventsProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowEventByIDFlow.__c__DisplayClass3_0>.NativeClassPtr, "eventsProvider");
				WormShowEventByIDFlow.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowEventByIDFlow.__c__DisplayClass3_0>.NativeClassPtr, "<>4__this");
				WormShowEventByIDFlow.__c__DisplayClass3_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowEventByIDFlow.__c__DisplayClass3_0>.NativeClassPtr, "<>9__1");
				WormShowEventByIDFlow.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowEventByIDFlow.__c__DisplayClass3_0>.NativeClassPtr, 100666789);
				WormShowEventByIDFlow.__c__DisplayClass3_0.NativeMethodInfoPtr__execute_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowEventByIDFlow.__c__DisplayClass3_0>.NativeClassPtr, 100666790);
				WormShowEventByIDFlow.__c__DisplayClass3_0.NativeMethodInfoPtr__execute_b__1_Internal_Boolean_EventDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowEventByIDFlow.__c__DisplayClass3_0>.NativeClassPtr, 100666791);
			}

			// Token: 0x06002AEA RID: 10986 RVA: 0x0009A16C File Offset: 0x0009836C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormShowEventByIDFlow.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowEventByIDFlow.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002AEB RID: 10987 RVA: 0x0009A1A8 File Offset: 0x000983A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719209, XrefRangeEnd = 719220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _execute_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowEventByIDFlow.__c__DisplayClass3_0.NativeMethodInfoPtr__execute_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002AEC RID: 10988 RVA: 0x0009A1E4 File Offset: 0x000983E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719220, XrefRangeEnd = 719225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _execute_b__1(EventDefinition e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowEventByIDFlow.__c__DisplayClass3_0.NativeMethodInfoPtr__execute_b__1_Internal_Boolean_EventDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002AED RID: 10989 RVA: 0x000176E2 File Offset: 0x000158E2
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C36 RID: 3126
			// (get) Token: 0x06002AEE RID: 10990 RVA: 0x0009A234 File Offset: 0x00098434
			// (set) Token: 0x06002AEF RID: 10991 RVA: 0x000176EB File Offset: 0x000158EB
			public unsafe EventDefinition eventData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowEventByIDFlow.__c__DisplayClass3_0.NativeFieldInfoPtr_eventData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowEventByIDFlow.__c__DisplayClass3_0.NativeFieldInfoPtr_eventData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C37 RID: 3127
			// (get) Token: 0x06002AF0 RID: 10992 RVA: 0x0009A264 File Offset: 0x00098464
			// (set) Token: 0x06002AF1 RID: 10993 RVA: 0x0001770A File Offset: 0x0001590A
			public unsafe WormEventsProvider eventsProvider
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowEventByIDFlow.__c__DisplayClass3_0.NativeFieldInfoPtr_eventsProvider);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEventsProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowEventByIDFlow.__c__DisplayClass3_0.NativeFieldInfoPtr_eventsProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C38 RID: 3128
			// (get) Token: 0x06002AF2 RID: 10994 RVA: 0x0009A294 File Offset: 0x00098494
			// (set) Token: 0x06002AF3 RID: 10995 RVA: 0x00017729 File Offset: 0x00015929
			public unsafe WormShowEventByIDFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowEventByIDFlow.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormShowEventByIDFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowEventByIDFlow.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C39 RID: 3129
			// (get) Token: 0x06002AF4 RID: 10996 RVA: 0x0009A2C4 File Offset: 0x000984C4
			// (set) Token: 0x06002AF5 RID: 10997 RVA: 0x00017748 File Offset: 0x00015948
			public unsafe Func<EventDefinition, bool> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowEventByIDFlow.__c__DisplayClass3_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EventDefinition, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowEventByIDFlow.__c__DisplayClass3_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040018E9 RID: 6377
			private static readonly IntPtr NativeFieldInfoPtr_eventData;

			// Token: 0x040018EA RID: 6378
			private static readonly IntPtr NativeFieldInfoPtr_eventsProvider;

			// Token: 0x040018EB RID: 6379
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040018EC RID: 6380
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x040018ED RID: 6381
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040018EE RID: 6382
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__0_Internal_Boolean_0;

			// Token: 0x040018EF RID: 6383
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__1_Internal_Boolean_EventDefinition_0;
		}

		// Token: 0x02000412 RID: 1042
		[ObfuscatedName("worm.match.commands.WormShowEventByIDFlow+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x06002AF6 RID: 10998 RVA: 0x0009A2F4 File Offset: 0x000984F4
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<WormShowEventByIDFlow._execute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormShowEventByIDFlow>.NativeClassPtr, "<execute>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormShowEventByIDFlow._execute_d__3>.NativeClassPtr);
				WormShowEventByIDFlow._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowEventByIDFlow._execute_d__3>.NativeClassPtr, "<>1__state");
				WormShowEventByIDFlow._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowEventByIDFlow._execute_d__3>.NativeClassPtr, "<>2__current");
				WormShowEventByIDFlow._execute_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowEventByIDFlow._execute_d__3>.NativeClassPtr, "<>4__this");
				WormShowEventByIDFlow._execute_d__3.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowEventByIDFlow._execute_d__3>.NativeClassPtr, "<>8__1");
				WormShowEventByIDFlow._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowEventByIDFlow._execute_d__3>.NativeClassPtr, 100666792);
				WormShowEventByIDFlow._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowEventByIDFlow._execute_d__3>.NativeClassPtr, 100666793);
				WormShowEventByIDFlow._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowEventByIDFlow._execute_d__3>.NativeClassPtr, 100666794);
				WormShowEventByIDFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowEventByIDFlow._execute_d__3>.NativeClassPtr, 100666795);
				WormShowEventByIDFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowEventByIDFlow._execute_d__3>.NativeClassPtr, 100666796);
				WormShowEventByIDFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowEventByIDFlow._execute_d__3>.NativeClassPtr, 100666797);
			}

			// Token: 0x06002AF7 RID: 10999 RVA: 0x0009A3E8 File Offset: 0x000985E8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormShowEventByIDFlow._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowEventByIDFlow._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002AF8 RID: 11000 RVA: 0x0009A430 File Offset: 0x00098630
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowEventByIDFlow._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002AF9 RID: 11001 RVA: 0x0009A464 File Offset: 0x00098664
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719225, XrefRangeEnd = 719245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowEventByIDFlow._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000C3E RID: 3134
			// (get) Token: 0x06002AFA RID: 11002 RVA: 0x0009A4A0 File Offset: 0x000986A0
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowEventByIDFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002AFB RID: 11003 RVA: 0x0009A4E0 File Offset: 0x000986E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719245, XrefRangeEnd = 719250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowEventByIDFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000C3F RID: 3135
			// (get) Token: 0x06002AFC RID: 11004 RVA: 0x0009A514 File Offset: 0x00098714
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowEventByIDFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002AFD RID: 11005 RVA: 0x00017767 File Offset: 0x00015967
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C3A RID: 3130
			// (get) Token: 0x06002AFE RID: 11006 RVA: 0x0009A554 File Offset: 0x00098754
			// (set) Token: 0x06002AFF RID: 11007 RVA: 0x00017770 File Offset: 0x00015970
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowEventByIDFlow._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowEventByIDFlow._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000C3B RID: 3131
			// (get) Token: 0x06002B00 RID: 11008 RVA: 0x0009A57C File Offset: 0x0009877C
			// (set) Token: 0x06002B01 RID: 11009 RVA: 0x0001778B File Offset: 0x0001598B
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowEventByIDFlow._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowEventByIDFlow._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C3C RID: 3132
			// (get) Token: 0x06002B02 RID: 11010 RVA: 0x0009A5AC File Offset: 0x000987AC
			// (set) Token: 0x06002B03 RID: 11011 RVA: 0x000177AA File Offset: 0x000159AA
			public unsafe WormShowEventByIDFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowEventByIDFlow._execute_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormShowEventByIDFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowEventByIDFlow._execute_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C3D RID: 3133
			// (get) Token: 0x06002B04 RID: 11012 RVA: 0x0009A5DC File Offset: 0x000987DC
			// (set) Token: 0x06002B05 RID: 11013 RVA: 0x000177C9 File Offset: 0x000159C9
			public unsafe WormShowEventByIDFlow.__c__DisplayClass3_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowEventByIDFlow._execute_d__3.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormShowEventByIDFlow.__c__DisplayClass3_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowEventByIDFlow._execute_d__3.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040018F0 RID: 6384
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040018F1 RID: 6385
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040018F2 RID: 6386
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040018F3 RID: 6387
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x040018F4 RID: 6388
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040018F5 RID: 6389
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040018F6 RID: 6390
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040018F7 RID: 6391
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040018F8 RID: 6392
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040018F9 RID: 6393
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
