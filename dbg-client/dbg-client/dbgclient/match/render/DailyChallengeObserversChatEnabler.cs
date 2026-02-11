using System;
using boardgames.match.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lotus;

namespace dbgclient.match.render
{
	// Token: 0x020000A5 RID: 165
	public class DailyChallengeObserversChatEnabler : VersionedView<ObserversProvider>
	{
		// Token: 0x0600067B RID: 1659 RVA: 0x0003225C File Offset: 0x0003045C
		// Note: this type is marked as 'beforefieldinit'.
		static DailyChallengeObserversChatEnabler()
		{
			Il2CppClassPointerStore<DailyChallengeObserversChatEnabler>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.match.render", "DailyChallengeObserversChatEnabler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyChallengeObserversChatEnabler>.NativeClassPtr);
			DailyChallengeObserversChatEnabler.NativeFieldInfoPtr_chatView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeObserversChatEnabler>.NativeClassPtr, "chatView");
			DailyChallengeObserversChatEnabler.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeObserversChatEnabler>.NativeClassPtr, 100664317);
			DailyChallengeObserversChatEnabler.NativeMethodInfoPtr_Init_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeObserversChatEnabler>.NativeClassPtr, 100664318);
			DailyChallengeObserversChatEnabler.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeObserversChatEnabler>.NativeClassPtr, 100664319);
			DailyChallengeObserversChatEnabler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeObserversChatEnabler>.NativeClassPtr, 100664320);
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x000322F0 File Offset: 0x000304F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503375, XrefRangeEnd = 503381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailyChallengeObserversChatEnabler.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x0003232C File Offset: 0x0003052C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503381, XrefRangeEnd = 503386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeObserversChatEnabler.NativeMethodInfoPtr_Init_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x0003236C File Offset: 0x0003056C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503386, XrefRangeEnd = 503390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailyChallengeObserversChatEnabler.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x000323A8 File Offset: 0x000305A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503390, XrefRangeEnd = 503393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DailyChallengeObserversChatEnabler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyChallengeObserversChatEnabler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeObserversChatEnabler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00004ECF File Offset: 0x000030CF
		public DailyChallengeObserversChatEnabler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000681 RID: 1665 RVA: 0x000323E4 File Offset: 0x000305E4
		// (set) Token: 0x06000682 RID: 1666 RVA: 0x00004ED8 File Offset: 0x000030D8
		public unsafe ChatView chatView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeObserversChatEnabler.NativeFieldInfoPtr_chatView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChatView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeObserversChatEnabler.NativeFieldInfoPtr_chatView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003FF RID: 1023
		private static readonly IntPtr NativeFieldInfoPtr_chatView;

		// Token: 0x04000400 RID: 1024
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x04000401 RID: 1025
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_IEnumerator_0;

		// Token: 0x04000402 RID: 1026
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000403 RID: 1027
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000314 RID: 788
		[ObfuscatedName("dbgclient.match.render.DailyChallengeObserversChatEnabler+<Init>d__2")]
		public sealed class _Init_d__2 : Object
		{
			// Token: 0x0600254D RID: 9549 RVA: 0x00098090 File Offset: 0x00096290
			// Note: this type is marked as 'beforefieldinit'.
			static _Init_d__2()
			{
				Il2CppClassPointerStore<DailyChallengeObserversChatEnabler._Init_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DailyChallengeObserversChatEnabler>.NativeClassPtr, "<Init>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyChallengeObserversChatEnabler._Init_d__2>.NativeClassPtr);
				DailyChallengeObserversChatEnabler._Init_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeObserversChatEnabler._Init_d__2>.NativeClassPtr, "<>1__state");
				DailyChallengeObserversChatEnabler._Init_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeObserversChatEnabler._Init_d__2>.NativeClassPtr, "<>2__current");
				DailyChallengeObserversChatEnabler._Init_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeObserversChatEnabler._Init_d__2>.NativeClassPtr, "<>4__this");
				DailyChallengeObserversChatEnabler._Init_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeObserversChatEnabler._Init_d__2>.NativeClassPtr, 100664321);
				DailyChallengeObserversChatEnabler._Init_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeObserversChatEnabler._Init_d__2>.NativeClassPtr, 100664322);
				DailyChallengeObserversChatEnabler._Init_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeObserversChatEnabler._Init_d__2>.NativeClassPtr, 100664323);
				DailyChallengeObserversChatEnabler._Init_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeObserversChatEnabler._Init_d__2>.NativeClassPtr, 100664324);
				DailyChallengeObserversChatEnabler._Init_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeObserversChatEnabler._Init_d__2>.NativeClassPtr, 100664325);
				DailyChallengeObserversChatEnabler._Init_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeObserversChatEnabler._Init_d__2>.NativeClassPtr, 100664326);
			}

			// Token: 0x0600254E RID: 9550 RVA: 0x00098170 File Offset: 0x00096370
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Init_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyChallengeObserversChatEnabler._Init_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeObserversChatEnabler._Init_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600254F RID: 9551 RVA: 0x000981B8 File Offset: 0x000963B8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeObserversChatEnabler._Init_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002550 RID: 9552 RVA: 0x000981EC File Offset: 0x000963EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503356, XrefRangeEnd = 503370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeObserversChatEnabler._Init_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A48 RID: 2632
			// (get) Token: 0x06002551 RID: 9553 RVA: 0x00098228 File Offset: 0x00096428
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeObserversChatEnabler._Init_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002552 RID: 9554 RVA: 0x00098268 File Offset: 0x00096468
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503370, XrefRangeEnd = 503375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeObserversChatEnabler._Init_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A49 RID: 2633
			// (get) Token: 0x06002553 RID: 9555 RVA: 0x0009829C File Offset: 0x0009649C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeObserversChatEnabler._Init_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002554 RID: 9556 RVA: 0x00013618 File Offset: 0x00011818
			public _Init_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A45 RID: 2629
			// (get) Token: 0x06002555 RID: 9557 RVA: 0x000982DC File Offset: 0x000964DC
			// (set) Token: 0x06002556 RID: 9558 RVA: 0x00013621 File Offset: 0x00011821
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeObserversChatEnabler._Init_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeObserversChatEnabler._Init_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A46 RID: 2630
			// (get) Token: 0x06002557 RID: 9559 RVA: 0x00098304 File Offset: 0x00096504
			// (set) Token: 0x06002558 RID: 9560 RVA: 0x0001363C File Offset: 0x0001183C
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeObserversChatEnabler._Init_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeObserversChatEnabler._Init_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A47 RID: 2631
			// (get) Token: 0x06002559 RID: 9561 RVA: 0x00098334 File Offset: 0x00096534
			// (set) Token: 0x0600255A RID: 9562 RVA: 0x0001365B File Offset: 0x0001185B
			public unsafe DailyChallengeObserversChatEnabler __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeObserversChatEnabler._Init_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DailyChallengeObserversChatEnabler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeObserversChatEnabler._Init_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400176C RID: 5996
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400176D RID: 5997
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400176E RID: 5998
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400176F RID: 5999
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001770 RID: 6000
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001771 RID: 6001
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001772 RID: 6002
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001773 RID: 6003
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001774 RID: 6004
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
