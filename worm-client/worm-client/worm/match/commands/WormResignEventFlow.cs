using System;
using Canis.utils.ids;
using dwd.core.commands;
using dwd.core.data.composition;
using dwd.core.session.commands;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using worm.components;
using worm.networking.responses;

namespace worm.match.commands
{
	// Token: 0x0200023A RID: 570
	public class WormResignEventFlow : Command
	{
		// Token: 0x060018A9 RID: 6313 RVA: 0x00063080 File Offset: 0x00061280
		// Note: this type is marked as 'beforefieldinit'.
		static WormResignEventFlow()
		{
			Il2CppClassPointerStore<WormResignEventFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands", "WormResignEventFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormResignEventFlow>.NativeClassPtr);
			WormResignEventFlow.NativeFieldInfoPtr_eventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResignEventFlow>.NativeClassPtr, "eventData");
			WormResignEventFlow.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResignEventFlow>.NativeClassPtr, 100666744);
			WormResignEventFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResignEventFlow>.NativeClassPtr, 100666745);
		}

		// Token: 0x060018AA RID: 6314 RVA: 0x000630EC File Offset: 0x000612EC
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 495009, RefRangeEnd = 495046, XrefRangeStart = 495009, XrefRangeEnd = 495046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormResignEventFlow(DataComposition eventData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormResignEventFlow>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResignEventFlow.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018AB RID: 6315 RVA: 0x00063138 File Offset: 0x00061338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719073, XrefRangeEnd = 719078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormResignEventFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x0000E916 File Offset: 0x0000CB16
		public WormResignEventFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x060018AD RID: 6317 RVA: 0x00063184 File Offset: 0x00061384
		// (set) Token: 0x060018AE RID: 6318 RVA: 0x0000E91F File Offset: 0x0000CB1F
		public unsafe DataComposition eventData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResignEventFlow.NativeFieldInfoPtr_eventData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResignEventFlow.NativeFieldInfoPtr_eventData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E48 RID: 3656
		private static readonly IntPtr NativeFieldInfoPtr_eventData;

		// Token: 0x04000E49 RID: 3657
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0;

		// Token: 0x04000E4A RID: 3658
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x0200040C RID: 1036
		[ObfuscatedName("worm.match.commands.WormResignEventFlow+<execute>d__2")]
		public sealed class _execute_d__2 : Object
		{
			// Token: 0x06002A9D RID: 10909 RVA: 0x000991C4 File Offset: 0x000973C4
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__2()
			{
				Il2CppClassPointerStore<WormResignEventFlow._execute_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormResignEventFlow>.NativeClassPtr, "<execute>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormResignEventFlow._execute_d__2>.NativeClassPtr);
				WormResignEventFlow._execute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResignEventFlow._execute_d__2>.NativeClassPtr, "<>1__state");
				WormResignEventFlow._execute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResignEventFlow._execute_d__2>.NativeClassPtr, "<>2__current");
				WormResignEventFlow._execute_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResignEventFlow._execute_d__2>.NativeClassPtr, "<>4__this");
				WormResignEventFlow._execute_d__2.NativeFieldInfoPtr__confirmPrompt_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResignEventFlow._execute_d__2>.NativeClassPtr, "<confirmPrompt>5__2");
				WormResignEventFlow._execute_d__2.NativeFieldInfoPtr__eventsProvider_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResignEventFlow._execute_d__2>.NativeClassPtr, "<eventsProvider>5__3");
				WormResignEventFlow._execute_d__2.NativeFieldInfoPtr__eventID_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResignEventFlow._execute_d__2>.NativeClassPtr, "<eventID>5__4");
				WormResignEventFlow._execute_d__2.NativeFieldInfoPtr__resign_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResignEventFlow._execute_d__2>.NativeClassPtr, "<resign>5__5");
				WormResignEventFlow._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResignEventFlow._execute_d__2>.NativeClassPtr, 100666746);
				WormResignEventFlow._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResignEventFlow._execute_d__2>.NativeClassPtr, 100666747);
				WormResignEventFlow._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResignEventFlow._execute_d__2>.NativeClassPtr, 100666748);
				WormResignEventFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResignEventFlow._execute_d__2>.NativeClassPtr, 100666749);
				WormResignEventFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResignEventFlow._execute_d__2>.NativeClassPtr, 100666750);
				WormResignEventFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResignEventFlow._execute_d__2>.NativeClassPtr, 100666751);
			}

			// Token: 0x06002A9E RID: 10910 RVA: 0x000992F4 File Offset: 0x000974F4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormResignEventFlow._execute_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResignEventFlow._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002A9F RID: 10911 RVA: 0x0009933C File Offset: 0x0009753C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResignEventFlow._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002AA0 RID: 10912 RVA: 0x00099370 File Offset: 0x00097570
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719008, XrefRangeEnd = 719068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResignEventFlow._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000C21 RID: 3105
			// (get) Token: 0x06002AA1 RID: 10913 RVA: 0x000993AC File Offset: 0x000975AC
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResignEventFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002AA2 RID: 10914 RVA: 0x000993EC File Offset: 0x000975EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719068, XrefRangeEnd = 719073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResignEventFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000C22 RID: 3106
			// (get) Token: 0x06002AA3 RID: 10915 RVA: 0x00099420 File Offset: 0x00097620
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResignEventFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002AA4 RID: 10916 RVA: 0x0001749B File Offset: 0x0001569B
			public _execute_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C1A RID: 3098
			// (get) Token: 0x06002AA5 RID: 10917 RVA: 0x00099460 File Offset: 0x00097660
			// (set) Token: 0x06002AA6 RID: 10918 RVA: 0x000174A4 File Offset: 0x000156A4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResignEventFlow._execute_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResignEventFlow._execute_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000C1B RID: 3099
			// (get) Token: 0x06002AA7 RID: 10919 RVA: 0x00099488 File Offset: 0x00097688
			// (set) Token: 0x06002AA8 RID: 10920 RVA: 0x000174BF File Offset: 0x000156BF
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResignEventFlow._execute_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResignEventFlow._execute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C1C RID: 3100
			// (get) Token: 0x06002AA9 RID: 10921 RVA: 0x000994B8 File Offset: 0x000976B8
			// (set) Token: 0x06002AAA RID: 10922 RVA: 0x000174DE File Offset: 0x000156DE
			public unsafe WormResignEventFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResignEventFlow._execute_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormResignEventFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResignEventFlow._execute_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C1D RID: 3101
			// (get) Token: 0x06002AAB RID: 10923 RVA: 0x000994E8 File Offset: 0x000976E8
			// (set) Token: 0x06002AAC RID: 10924 RVA: 0x000174FD File Offset: 0x000156FD
			public unsafe ConfirmOrDenyPrompt _confirmPrompt_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResignEventFlow._execute_d__2.NativeFieldInfoPtr__confirmPrompt_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfirmOrDenyPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResignEventFlow._execute_d__2.NativeFieldInfoPtr__confirmPrompt_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C1E RID: 3102
			// (get) Token: 0x06002AAD RID: 10925 RVA: 0x00099518 File Offset: 0x00097718
			// (set) Token: 0x06002AAE RID: 10926 RVA: 0x0001751C File Offset: 0x0001571C
			public unsafe WormEventsProvider _eventsProvider_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResignEventFlow._execute_d__2.NativeFieldInfoPtr__eventsProvider_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEventsProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResignEventFlow._execute_d__2.NativeFieldInfoPtr__eventsProvider_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C1F RID: 3103
			// (get) Token: 0x06002AAF RID: 10927 RVA: 0x00099548 File Offset: 0x00097748
			// (set) Token: 0x06002AB0 RID: 10928 RVA: 0x0001753B File Offset: 0x0001573B
			public unsafe EventID _eventID_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResignEventFlow._execute_d__2.NativeFieldInfoPtr__eventID_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResignEventFlow._execute_d__2.NativeFieldInfoPtr__eventID_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C20 RID: 3104
			// (get) Token: 0x06002AB1 RID: 10929 RVA: 0x00099578 File Offset: 0x00097778
			// (set) Token: 0x06002AB2 RID: 10930 RVA: 0x0001755A File Offset: 0x0001575A
			public unsafe WriteToSessionAndAwaitResponse<EventEntryEnded, EventError> _resign_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResignEventFlow._execute_d__2.NativeFieldInfoPtr__resign_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WriteToSessionAndAwaitResponse<EventEntryEnded, EventError>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResignEventFlow._execute_d__2.NativeFieldInfoPtr__resign_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040018B9 RID: 6329
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040018BA RID: 6330
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040018BB RID: 6331
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040018BC RID: 6332
			private static readonly IntPtr NativeFieldInfoPtr__confirmPrompt_5__2;

			// Token: 0x040018BD RID: 6333
			private static readonly IntPtr NativeFieldInfoPtr__eventsProvider_5__3;

			// Token: 0x040018BE RID: 6334
			private static readonly IntPtr NativeFieldInfoPtr__eventID_5__4;

			// Token: 0x040018BF RID: 6335
			private static readonly IntPtr NativeFieldInfoPtr__resign_5__5;

			// Token: 0x040018C0 RID: 6336
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040018C1 RID: 6337
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040018C2 RID: 6338
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040018C3 RID: 6339
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040018C4 RID: 6340
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040018C5 RID: 6341
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
