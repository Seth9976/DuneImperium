using System;
using boardgames.match.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace dwd.canis.lib.canis.dbg_client.dataProviders
{
	// Token: 0x0200005D RID: 93
	public class ChallengeTextDataProvider : MonoBehaviour
	{
		// Token: 0x06000391 RID: 913 RVA: 0x00028D90 File Offset: 0x00026F90
		// Note: this type is marked as 'beforefieldinit'.
		static ChallengeTextDataProvider()
		{
			Il2CppClassPointerStore<ChallengeTextDataProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.lib.canis.dbg_client.dataProviders", "ChallengeTextDataProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeTextDataProvider>.NativeClassPtr);
			ChallengeTextDataProvider.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeTextDataProvider>.NativeClassPtr, 100663847);
			ChallengeTextDataProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeTextDataProvider>.NativeClassPtr, 100663848);
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00028DE8 File Offset: 0x00026FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499914, XrefRangeEnd = 499919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeTextDataProvider.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00028E28 File Offset: 0x00027028
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChallengeTextDataProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengeTextDataProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeTextDataProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0000390E File Offset: 0x00001B0E
		public ChallengeTextDataProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002EA RID: 746
		[ObfuscatedName("dwd.canis.lib.canis.dbg_client.dataProviders.ChallengeTextDataProvider+<Start>d__0")]
		public sealed class _Start_d__0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002334 RID: 9012 RVA: 0x00091C90 File Offset: 0x0008FE90
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__0()
			{
				Il2CppClassPointerStore<ChallengeTextDataProvider._Start_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChallengeTextDataProvider>.NativeClassPtr, "<Start>d__0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeTextDataProvider._Start_d__0>.NativeClassPtr);
				ChallengeTextDataProvider._Start_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeTextDataProvider._Start_d__0>.NativeClassPtr, "<>1__state");
				ChallengeTextDataProvider._Start_d__0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeTextDataProvider._Start_d__0>.NativeClassPtr, "<>2__current");
				ChallengeTextDataProvider._Start_d__0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeTextDataProvider._Start_d__0>.NativeClassPtr, "<>4__this");
				ChallengeTextDataProvider._Start_d__0.NativeFieldInfoPtr__subscriptionProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeTextDataProvider._Start_d__0>.NativeClassPtr, "<subscriptionProvider>5__2");
				ChallengeTextDataProvider._Start_d__0.NativeFieldInfoPtr__matchHub_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeTextDataProvider._Start_d__0>.NativeClassPtr, "<matchHub>5__3");
				ChallengeTextDataProvider._Start_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeTextDataProvider._Start_d__0>.NativeClassPtr, 100663849);
				ChallengeTextDataProvider._Start_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeTextDataProvider._Start_d__0>.NativeClassPtr, 100663850);
				ChallengeTextDataProvider._Start_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeTextDataProvider._Start_d__0>.NativeClassPtr, 100663851);
				ChallengeTextDataProvider._Start_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeTextDataProvider._Start_d__0>.NativeClassPtr, 100663852);
				ChallengeTextDataProvider._Start_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeTextDataProvider._Start_d__0>.NativeClassPtr, 100663853);
				ChallengeTextDataProvider._Start_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeTextDataProvider._Start_d__0>.NativeClassPtr, 100663854);
			}

			// Token: 0x06002335 RID: 9013 RVA: 0x00091D98 File Offset: 0x0008FF98
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__0(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengeTextDataProvider._Start_d__0>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeTextDataProvider._Start_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002336 RID: 9014 RVA: 0x00091DE0 File Offset: 0x0008FFE0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeTextDataProvider._Start_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002337 RID: 9015 RVA: 0x00091E14 File Offset: 0x00090014
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499893, XrefRangeEnd = 499909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeTextDataProvider._Start_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700098D RID: 2445
			// (get) Token: 0x06002338 RID: 9016 RVA: 0x00091E50 File Offset: 0x00090050
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeTextDataProvider._Start_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002339 RID: 9017 RVA: 0x00091E90 File Offset: 0x00090090
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499909, XrefRangeEnd = 499914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeTextDataProvider._Start_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700098E RID: 2446
			// (get) Token: 0x0600233A RID: 9018 RVA: 0x00091EC4 File Offset: 0x000900C4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeTextDataProvider._Start_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600233B RID: 9019 RVA: 0x0001255A File Offset: 0x0001075A
			public _Start_d__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000988 RID: 2440
			// (get) Token: 0x0600233C RID: 9020 RVA: 0x00091F04 File Offset: 0x00090104
			// (set) Token: 0x0600233D RID: 9021 RVA: 0x00012563 File Offset: 0x00010763
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeTextDataProvider._Start_d__0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeTextDataProvider._Start_d__0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000989 RID: 2441
			// (get) Token: 0x0600233E RID: 9022 RVA: 0x00091F2C File Offset: 0x0009012C
			// (set) Token: 0x0600233F RID: 9023 RVA: 0x0001257E File Offset: 0x0001077E
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeTextDataProvider._Start_d__0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeTextDataProvider._Start_d__0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700098A RID: 2442
			// (get) Token: 0x06002340 RID: 9024 RVA: 0x00091F5C File Offset: 0x0009015C
			// (set) Token: 0x06002341 RID: 9025 RVA: 0x0001259D File Offset: 0x0001079D
			public unsafe ChallengeTextDataProvider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeTextDataProvider._Start_d__0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChallengeTextDataProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeTextDataProvider._Start_d__0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700098B RID: 2443
			// (get) Token: 0x06002342 RID: 9026 RVA: 0x00091F8C File Offset: 0x0009018C
			// (set) Token: 0x06002343 RID: 9027 RVA: 0x000125BC File Offset: 0x000107BC
			public unsafe SubscriptionProvider _subscriptionProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeTextDataProvider._Start_d__0.NativeFieldInfoPtr__subscriptionProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeTextDataProvider._Start_d__0.NativeFieldInfoPtr__subscriptionProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700098C RID: 2444
			// (get) Token: 0x06002344 RID: 9028 RVA: 0x00091FBC File Offset: 0x000901BC
			// (set) Token: 0x06002345 RID: 9029 RVA: 0x000125DB File Offset: 0x000107DB
			public unsafe DBGMatchHub _matchHub_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeTextDataProvider._Start_d__0.NativeFieldInfoPtr__matchHub_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGMatchHub>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeTextDataProvider._Start_d__0.NativeFieldInfoPtr__matchHub_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001620 RID: 5664
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001621 RID: 5665
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001622 RID: 5666
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001623 RID: 5667
			private static readonly IntPtr NativeFieldInfoPtr__subscriptionProvider_5__2;

			// Token: 0x04001624 RID: 5668
			private static readonly IntPtr NativeFieldInfoPtr__matchHub_5__3;

			// Token: 0x04001625 RID: 5669
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001626 RID: 5670
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001627 RID: 5671
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001628 RID: 5672
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001629 RID: 5673
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400162A RID: 5674
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
