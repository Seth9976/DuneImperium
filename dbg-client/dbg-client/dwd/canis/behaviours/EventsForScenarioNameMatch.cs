using System;
using boardgames.match.behaviours;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace dwd.canis.behaviours
{
	// Token: 0x02000067 RID: 103
	public class EventsForScenarioNameMatch : MonoBehaviour
	{
		// Token: 0x060003D8 RID: 984 RVA: 0x00029A80 File Offset: 0x00027C80
		// Note: this type is marked as 'beforefieldinit'.
		static EventsForScenarioNameMatch()
		{
			Il2CppClassPointerStore<EventsForScenarioNameMatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.behaviours", "EventsForScenarioNameMatch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForScenarioNameMatch>.NativeClassPtr);
			EventsForScenarioNameMatch.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForScenarioNameMatch>.NativeClassPtr, "match");
			EventsForScenarioNameMatch.NativeFieldInfoPtr_onMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForScenarioNameMatch>.NativeClassPtr, "onMatch");
			EventsForScenarioNameMatch.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForScenarioNameMatch>.NativeClassPtr, 100663889);
			EventsForScenarioNameMatch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForScenarioNameMatch>.NativeClassPtr, 100663890);
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00029B00 File Offset: 0x00027D00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500102, XrefRangeEnd = 500107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForScenarioNameMatch.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00029B40 File Offset: 0x00027D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500107, XrefRangeEnd = 500117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsForScenarioNameMatch()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForScenarioNameMatch>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForScenarioNameMatch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00003B2C File Offset: 0x00001D2C
		public EventsForScenarioNameMatch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060003DC RID: 988 RVA: 0x00029B7C File Offset: 0x00027D7C
		// (set) Token: 0x060003DD RID: 989 RVA: 0x00003B35 File Offset: 0x00001D35
		public unsafe Il2CppStringArray match
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForScenarioNameMatch.NativeFieldInfoPtr_match);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForScenarioNameMatch.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060003DE RID: 990 RVA: 0x00029BAC File Offset: 0x00027DAC
		// (set) Token: 0x060003DF RID: 991 RVA: 0x00003B54 File Offset: 0x00001D54
		public unsafe BoolUnityEvents onMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForScenarioNameMatch.NativeFieldInfoPtr_onMatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolUnityEvents>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForScenarioNameMatch.NativeFieldInfoPtr_onMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000253 RID: 595
		private static readonly IntPtr NativeFieldInfoPtr_match;

		// Token: 0x04000254 RID: 596
		private static readonly IntPtr NativeFieldInfoPtr_onMatch;

		// Token: 0x04000255 RID: 597
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x04000256 RID: 598
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002EE RID: 750
		[ObfuscatedName("dwd.canis.behaviours.EventsForScenarioNameMatch+<Start>d__2")]
		public sealed class _Start_d__2 : global::Il2CppSystem.Object
		{
			// Token: 0x06002368 RID: 9064 RVA: 0x00092658 File Offset: 0x00090858
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__2()
			{
				Il2CppClassPointerStore<EventsForScenarioNameMatch._Start_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventsForScenarioNameMatch>.NativeClassPtr, "<Start>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForScenarioNameMatch._Start_d__2>.NativeClassPtr);
				EventsForScenarioNameMatch._Start_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForScenarioNameMatch._Start_d__2>.NativeClassPtr, "<>1__state");
				EventsForScenarioNameMatch._Start_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForScenarioNameMatch._Start_d__2>.NativeClassPtr, "<>2__current");
				EventsForScenarioNameMatch._Start_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForScenarioNameMatch._Start_d__2>.NativeClassPtr, "<>4__this");
				EventsForScenarioNameMatch._Start_d__2.NativeFieldInfoPtr__matchHub_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForScenarioNameMatch._Start_d__2>.NativeClassPtr, "<matchHub>5__2");
				EventsForScenarioNameMatch._Start_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForScenarioNameMatch._Start_d__2>.NativeClassPtr, 100663891);
				EventsForScenarioNameMatch._Start_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForScenarioNameMatch._Start_d__2>.NativeClassPtr, 100663892);
				EventsForScenarioNameMatch._Start_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForScenarioNameMatch._Start_d__2>.NativeClassPtr, 100663893);
				EventsForScenarioNameMatch._Start_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForScenarioNameMatch._Start_d__2>.NativeClassPtr, 100663894);
				EventsForScenarioNameMatch._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForScenarioNameMatch._Start_d__2>.NativeClassPtr, 100663895);
				EventsForScenarioNameMatch._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForScenarioNameMatch._Start_d__2>.NativeClassPtr, 100663896);
			}

			// Token: 0x06002369 RID: 9065 RVA: 0x0009274C File Offset: 0x0009094C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForScenarioNameMatch._Start_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForScenarioNameMatch._Start_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600236A RID: 9066 RVA: 0x00092794 File Offset: 0x00090994
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForScenarioNameMatch._Start_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600236B RID: 9067 RVA: 0x000927C8 File Offset: 0x000909C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500086, XrefRangeEnd = 500097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForScenarioNameMatch._Start_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170009A0 RID: 2464
			// (get) Token: 0x0600236C RID: 9068 RVA: 0x00092804 File Offset: 0x00090A04
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForScenarioNameMatch._Start_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600236D RID: 9069 RVA: 0x00092844 File Offset: 0x00090A44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500097, XrefRangeEnd = 500102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForScenarioNameMatch._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170009A1 RID: 2465
			// (get) Token: 0x0600236E RID: 9070 RVA: 0x00092878 File Offset: 0x00090A78
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForScenarioNameMatch._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600236F RID: 9071 RVA: 0x0001271B File Offset: 0x0001091B
			public _Start_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700099C RID: 2460
			// (get) Token: 0x06002370 RID: 9072 RVA: 0x000928B8 File Offset: 0x00090AB8
			// (set) Token: 0x06002371 RID: 9073 RVA: 0x00012724 File Offset: 0x00010924
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForScenarioNameMatch._Start_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForScenarioNameMatch._Start_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700099D RID: 2461
			// (get) Token: 0x06002372 RID: 9074 RVA: 0x000928E0 File Offset: 0x00090AE0
			// (set) Token: 0x06002373 RID: 9075 RVA: 0x0001273F File Offset: 0x0001093F
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForScenarioNameMatch._Start_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForScenarioNameMatch._Start_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700099E RID: 2462
			// (get) Token: 0x06002374 RID: 9076 RVA: 0x00092910 File Offset: 0x00090B10
			// (set) Token: 0x06002375 RID: 9077 RVA: 0x0001275E File Offset: 0x0001095E
			public unsafe EventsForScenarioNameMatch __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForScenarioNameMatch._Start_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventsForScenarioNameMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForScenarioNameMatch._Start_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700099F RID: 2463
			// (get) Token: 0x06002376 RID: 9078 RVA: 0x00092940 File Offset: 0x00090B40
			// (set) Token: 0x06002377 RID: 9079 RVA: 0x0001277D File Offset: 0x0001097D
			public unsafe DBGMatchHub _matchHub_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForScenarioNameMatch._Start_d__2.NativeFieldInfoPtr__matchHub_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGMatchHub>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForScenarioNameMatch._Start_d__2.NativeFieldInfoPtr__matchHub_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001643 RID: 5699
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001644 RID: 5700
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001645 RID: 5701
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001646 RID: 5702
			private static readonly IntPtr NativeFieldInfoPtr__matchHub_5__2;

			// Token: 0x04001647 RID: 5703
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001648 RID: 5704
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001649 RID: 5705
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400164A RID: 5706
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400164B RID: 5707
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400164C RID: 5708
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
