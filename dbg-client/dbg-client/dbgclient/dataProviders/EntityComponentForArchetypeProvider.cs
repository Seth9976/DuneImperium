using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lib.canis.boardgames.src.match;
using lotus;
using UnityEngine;

namespace dbgclient.dataProviders
{
	// Token: 0x020000C4 RID: 196
	public class EntityComponentForArchetypeProvider : MonoBehaviour
	{
		// Token: 0x06000850 RID: 2128 RVA: 0x00037C94 File Offset: 0x00035E94
		// Note: this type is marked as 'beforefieldinit'.
		static EntityComponentForArchetypeProvider()
		{
			Il2CppClassPointerStore<EntityComponentForArchetypeProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.dataProviders", "EntityComponentForArchetypeProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityComponentForArchetypeProvider>.NativeClassPtr);
			EntityComponentForArchetypeProvider.NativeFieldInfoPtr_archetypeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityComponentForArchetypeProvider>.NativeClassPtr, "archetypeID");
			EntityComponentForArchetypeProvider.NativeFieldInfoPtr_entityView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityComponentForArchetypeProvider>.NativeClassPtr, "entityView");
			EntityComponentForArchetypeProvider.NativeFieldInfoPtr_subscriptionProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityComponentForArchetypeProvider>.NativeClassPtr, "subscriptionProvider");
			EntityComponentForArchetypeProvider.NativeFieldInfoPtr_archetypeProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityComponentForArchetypeProvider>.NativeClassPtr, "archetypeProvider");
			EntityComponentForArchetypeProvider.NativeFieldInfoPtr_initCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityComponentForArchetypeProvider>.NativeClassPtr, "initCoroutine");
			EntityComponentForArchetypeProvider.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityComponentForArchetypeProvider>.NativeClassPtr, "initialized");
			EntityComponentForArchetypeProvider.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponentForArchetypeProvider>.NativeClassPtr, 100664531);
			EntityComponentForArchetypeProvider.NativeMethodInfoPtr_SetArchetype_Public_Void_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponentForArchetypeProvider>.NativeClassPtr, 100664532);
			EntityComponentForArchetypeProvider.NativeMethodInfoPtr_Initialize_Private_IEnumerator_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponentForArchetypeProvider>.NativeClassPtr, 100664533);
			EntityComponentForArchetypeProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponentForArchetypeProvider>.NativeClassPtr, 100664534);
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00037D8C File Offset: 0x00035F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504752, XrefRangeEnd = 504755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityComponentForArchetypeProvider.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x00037DC0 File Offset: 0x00035FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504755, XrefRangeEnd = 504759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetArchetype(ArchetypeID id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityComponentForArchetypeProvider.NativeMethodInfoPtr_SetArchetype_Public_Void_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00037E04 File Offset: 0x00036004
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 504765, RefRangeEnd = 504767, XrefRangeStart = 504759, XrefRangeEnd = 504765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Initialize(ArchetypeID id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityComponentForArchetypeProvider.NativeMethodInfoPtr_Initialize_Private_IEnumerator_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x00037E54 File Offset: 0x00036054
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityComponentForArchetypeProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityComponentForArchetypeProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityComponentForArchetypeProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x00005D9A File Offset: 0x00003F9A
		public EntityComponentForArchetypeProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000856 RID: 2134 RVA: 0x00037E90 File Offset: 0x00036090
		// (set) Token: 0x06000857 RID: 2135 RVA: 0x00005DA3 File Offset: 0x00003FA3
		public unsafe ArchetypeID archetypeID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityComponentForArchetypeProvider.NativeFieldInfoPtr_archetypeID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityComponentForArchetypeProvider.NativeFieldInfoPtr_archetypeID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000858 RID: 2136 RVA: 0x00037EC0 File Offset: 0x000360C0
		// (set) Token: 0x06000859 RID: 2137 RVA: 0x00005DC2 File Offset: 0x00003FC2
		public unsafe EntityView entityView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityComponentForArchetypeProvider.NativeFieldInfoPtr_entityView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityComponentForArchetypeProvider.NativeFieldInfoPtr_entityView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x0600085A RID: 2138 RVA: 0x00037EF0 File Offset: 0x000360F0
		// (set) Token: 0x0600085B RID: 2139 RVA: 0x00005DE1 File Offset: 0x00003FE1
		public unsafe SubscriptionProvider subscriptionProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityComponentForArchetypeProvider.NativeFieldInfoPtr_subscriptionProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityComponentForArchetypeProvider.NativeFieldInfoPtr_subscriptionProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x0600085C RID: 2140 RVA: 0x00037F20 File Offset: 0x00036120
		// (set) Token: 0x0600085D RID: 2141 RVA: 0x00005E00 File Offset: 0x00004000
		public unsafe ArchetypeProvider archetypeProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityComponentForArchetypeProvider.NativeFieldInfoPtr_archetypeProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityComponentForArchetypeProvider.NativeFieldInfoPtr_archetypeProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x0600085E RID: 2142 RVA: 0x00037F50 File Offset: 0x00036150
		// (set) Token: 0x0600085F RID: 2143 RVA: 0x00005E1F File Offset: 0x0000401F
		public unsafe Coroutine initCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityComponentForArchetypeProvider.NativeFieldInfoPtr_initCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityComponentForArchetypeProvider.NativeFieldInfoPtr_initCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000860 RID: 2144 RVA: 0x00037F80 File Offset: 0x00036180
		// (set) Token: 0x06000861 RID: 2145 RVA: 0x00005E3E File Offset: 0x0000403E
		public unsafe bool initialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityComponentForArchetypeProvider.NativeFieldInfoPtr_initialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityComponentForArchetypeProvider.NativeFieldInfoPtr_initialized)) = value;
			}
		}

		// Token: 0x0400051C RID: 1308
		private static readonly IntPtr NativeFieldInfoPtr_archetypeID;

		// Token: 0x0400051D RID: 1309
		private static readonly IntPtr NativeFieldInfoPtr_entityView;

		// Token: 0x0400051E RID: 1310
		private static readonly IntPtr NativeFieldInfoPtr_subscriptionProvider;

		// Token: 0x0400051F RID: 1311
		private static readonly IntPtr NativeFieldInfoPtr_archetypeProvider;

		// Token: 0x04000520 RID: 1312
		private static readonly IntPtr NativeFieldInfoPtr_initCoroutine;

		// Token: 0x04000521 RID: 1313
		private static readonly IntPtr NativeFieldInfoPtr_initialized;

		// Token: 0x04000522 RID: 1314
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000523 RID: 1315
		private static readonly IntPtr NativeMethodInfoPtr_SetArchetype_Public_Void_ArchetypeID_0;

		// Token: 0x04000524 RID: 1316
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_IEnumerator_ArchetypeID_0;

		// Token: 0x04000525 RID: 1317
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000323 RID: 803
		[ObfuscatedName("dbgclient.dataProviders.EntityComponentForArchetypeProvider+<Initialize>d__8")]
		public sealed class _Initialize_d__8 : global::Il2CppSystem.Object
		{
			// Token: 0x060025DD RID: 9693 RVA: 0x00099BD8 File Offset: 0x00097DD8
			// Note: this type is marked as 'beforefieldinit'.
			static _Initialize_d__8()
			{
				Il2CppClassPointerStore<EntityComponentForArchetypeProvider._Initialize_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntityComponentForArchetypeProvider>.NativeClassPtr, "<Initialize>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityComponentForArchetypeProvider._Initialize_d__8>.NativeClassPtr);
				EntityComponentForArchetypeProvider._Initialize_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityComponentForArchetypeProvider._Initialize_d__8>.NativeClassPtr, "<>1__state");
				EntityComponentForArchetypeProvider._Initialize_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityComponentForArchetypeProvider._Initialize_d__8>.NativeClassPtr, "<>2__current");
				EntityComponentForArchetypeProvider._Initialize_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityComponentForArchetypeProvider._Initialize_d__8>.NativeClassPtr, "<>4__this");
				EntityComponentForArchetypeProvider._Initialize_d__8.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityComponentForArchetypeProvider._Initialize_d__8>.NativeClassPtr, "id");
				EntityComponentForArchetypeProvider._Initialize_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponentForArchetypeProvider._Initialize_d__8>.NativeClassPtr, 100664535);
				EntityComponentForArchetypeProvider._Initialize_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponentForArchetypeProvider._Initialize_d__8>.NativeClassPtr, 100664536);
				EntityComponentForArchetypeProvider._Initialize_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponentForArchetypeProvider._Initialize_d__8>.NativeClassPtr, 100664537);
				EntityComponentForArchetypeProvider._Initialize_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponentForArchetypeProvider._Initialize_d__8>.NativeClassPtr, 100664538);
				EntityComponentForArchetypeProvider._Initialize_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponentForArchetypeProvider._Initialize_d__8>.NativeClassPtr, 100664539);
				EntityComponentForArchetypeProvider._Initialize_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponentForArchetypeProvider._Initialize_d__8>.NativeClassPtr, 100664540);
			}

			// Token: 0x060025DE RID: 9694 RVA: 0x00099CCC File Offset: 0x00097ECC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Initialize_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityComponentForArchetypeProvider._Initialize_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityComponentForArchetypeProvider._Initialize_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060025DF RID: 9695 RVA: 0x00099D14 File Offset: 0x00097F14
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityComponentForArchetypeProvider._Initialize_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060025E0 RID: 9696 RVA: 0x00099D48 File Offset: 0x00097F48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504733, XrefRangeEnd = 504747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityComponentForArchetypeProvider._Initialize_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A75 RID: 2677
			// (get) Token: 0x060025E1 RID: 9697 RVA: 0x00099D84 File Offset: 0x00097F84
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityComponentForArchetypeProvider._Initialize_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060025E2 RID: 9698 RVA: 0x00099DC4 File Offset: 0x00097FC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504747, XrefRangeEnd = 504752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityComponentForArchetypeProvider._Initialize_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A76 RID: 2678
			// (get) Token: 0x060025E3 RID: 9699 RVA: 0x00099DF8 File Offset: 0x00097FF8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityComponentForArchetypeProvider._Initialize_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060025E4 RID: 9700 RVA: 0x00013A7D File Offset: 0x00011C7D
			public _Initialize_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A71 RID: 2673
			// (get) Token: 0x060025E5 RID: 9701 RVA: 0x00099E38 File Offset: 0x00098038
			// (set) Token: 0x060025E6 RID: 9702 RVA: 0x00013A86 File Offset: 0x00011C86
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityComponentForArchetypeProvider._Initialize_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityComponentForArchetypeProvider._Initialize_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A72 RID: 2674
			// (get) Token: 0x060025E7 RID: 9703 RVA: 0x00099E60 File Offset: 0x00098060
			// (set) Token: 0x060025E8 RID: 9704 RVA: 0x00013AA1 File Offset: 0x00011CA1
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityComponentForArchetypeProvider._Initialize_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityComponentForArchetypeProvider._Initialize_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A73 RID: 2675
			// (get) Token: 0x060025E9 RID: 9705 RVA: 0x00099E90 File Offset: 0x00098090
			// (set) Token: 0x060025EA RID: 9706 RVA: 0x00013AC0 File Offset: 0x00011CC0
			public unsafe EntityComponentForArchetypeProvider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityComponentForArchetypeProvider._Initialize_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponentForArchetypeProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityComponentForArchetypeProvider._Initialize_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A74 RID: 2676
			// (get) Token: 0x060025EB RID: 9707 RVA: 0x00099EC0 File Offset: 0x000980C0
			// (set) Token: 0x060025EC RID: 9708 RVA: 0x00013ADF File Offset: 0x00011CDF
			public unsafe ArchetypeID id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityComponentForArchetypeProvider._Initialize_d__8.NativeFieldInfoPtr_id);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityComponentForArchetypeProvider._Initialize_d__8.NativeFieldInfoPtr_id), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017BF RID: 6079
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040017C0 RID: 6080
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040017C1 RID: 6081
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040017C2 RID: 6082
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x040017C3 RID: 6083
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040017C4 RID: 6084
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017C5 RID: 6085
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040017C6 RID: 6086
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040017C7 RID: 6087
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017C8 RID: 6088
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
