using System;
using dwd.core.match;
using dwd.core.match.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lotus;
using UnityEngine;
using UnityEngine.Events;

namespace worm.match.components
{
	// Token: 0x020001B8 RID: 440
	public class PlayerLeaderDataProvider : MonoBehaviour
	{
		// Token: 0x06001369 RID: 4969 RVA: 0x0005306C File Offset: 0x0005126C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerLeaderDataProvider()
		{
			Il2CppClassPointerStore<PlayerLeaderDataProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "PlayerLeaderDataProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerLeaderDataProvider>.NativeClassPtr);
			PlayerLeaderDataProvider.NativeFieldInfoPtr_parentView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLeaderDataProvider>.NativeClassPtr, "parentView");
			PlayerLeaderDataProvider.NativeFieldInfoPtr_pileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLeaderDataProvider>.NativeClassPtr, "pileName");
			PlayerLeaderDataProvider.NativeFieldInfoPtr_entityToInitialize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLeaderDataProvider>.NativeClassPtr, "entityToInitialize");
			PlayerLeaderDataProvider.NativeFieldInfoPtr_wormEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLeaderDataProvider>.NativeClassPtr, "wormEntities");
			PlayerLeaderDataProvider.NativeFieldInfoPtr_OnDataProvided = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLeaderDataProvider>.NativeClassPtr, "OnDataProvided");
			PlayerLeaderDataProvider.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLeaderDataProvider>.NativeClassPtr, 100665953);
			PlayerLeaderDataProvider.NativeMethodInfoPtr_IntroducePlayerPile_Private_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLeaderDataProvider>.NativeClassPtr, 100665954);
			PlayerLeaderDataProvider.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLeaderDataProvider>.NativeClassPtr, 100665955);
			PlayerLeaderDataProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLeaderDataProvider>.NativeClassPtr, 100665956);
			PlayerLeaderDataProvider.NativeMethodInfoPtr__Start_b__5_0_Private_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLeaderDataProvider>.NativeClassPtr, 100665957);
		}

		// Token: 0x0600136A RID: 4970 RVA: 0x00053164 File Offset: 0x00051364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713044, XrefRangeEnd = 713049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerLeaderDataProvider.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600136B RID: 4971 RVA: 0x000531A4 File Offset: 0x000513A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713049, XrefRangeEnd = 713059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IntroducePlayerPile(EntityComponent entityComponent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityComponent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerLeaderDataProvider.NativeMethodInfoPtr_IntroducePlayerPile_Private_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600136C RID: 4972 RVA: 0x000531E8 File Offset: 0x000513E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713059, XrefRangeEnd = 713072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerLeaderDataProvider.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600136D RID: 4973 RVA: 0x0005321C File Offset: 0x0005141C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713072, XrefRangeEnd = 713081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerLeaderDataProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerLeaderDataProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerLeaderDataProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600136E RID: 4974 RVA: 0x00053258 File Offset: 0x00051458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713081, XrefRangeEnd = 713083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Start_b__5_0(EntityComponent child)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerLeaderDataProvider.NativeMethodInfoPtr__Start_b__5_0_Private_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x0000C029 File Offset: 0x0000A229
		public PlayerLeaderDataProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06001370 RID: 4976 RVA: 0x000532A8 File Offset: 0x000514A8
		// (set) Token: 0x06001371 RID: 4977 RVA: 0x0000C032 File Offset: 0x0000A232
		public unsafe EntityView parentView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLeaderDataProvider.NativeFieldInfoPtr_parentView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLeaderDataProvider.NativeFieldInfoPtr_parentView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06001372 RID: 4978 RVA: 0x000532D8 File Offset: 0x000514D8
		// (set) Token: 0x06001373 RID: 4979 RVA: 0x0000C051 File Offset: 0x0000A251
		public unsafe string pileName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLeaderDataProvider.NativeFieldInfoPtr_pileName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLeaderDataProvider.NativeFieldInfoPtr_pileName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06001374 RID: 4980 RVA: 0x00053300 File Offset: 0x00051500
		// (set) Token: 0x06001375 RID: 4981 RVA: 0x0000C070 File Offset: 0x0000A270
		public unsafe EntityView entityToInitialize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLeaderDataProvider.NativeFieldInfoPtr_entityToInitialize);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLeaderDataProvider.NativeFieldInfoPtr_entityToInitialize), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06001376 RID: 4982 RVA: 0x00053330 File Offset: 0x00051530
		// (set) Token: 0x06001377 RID: 4983 RVA: 0x0000C08F File Offset: 0x0000A28F
		public unsafe WormEntities wormEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLeaderDataProvider.NativeFieldInfoPtr_wormEntities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEntities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLeaderDataProvider.NativeFieldInfoPtr_wormEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06001378 RID: 4984 RVA: 0x00053360 File Offset: 0x00051560
		// (set) Token: 0x06001379 RID: 4985 RVA: 0x0000C0AE File Offset: 0x0000A2AE
		public unsafe UnityEvent OnDataProvided
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLeaderDataProvider.NativeFieldInfoPtr_OnDataProvided);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLeaderDataProvider.NativeFieldInfoPtr_OnDataProvided), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B3F RID: 2879
		private static readonly IntPtr NativeFieldInfoPtr_parentView;

		// Token: 0x04000B40 RID: 2880
		private static readonly IntPtr NativeFieldInfoPtr_pileName;

		// Token: 0x04000B41 RID: 2881
		private static readonly IntPtr NativeFieldInfoPtr_entityToInitialize;

		// Token: 0x04000B42 RID: 2882
		private static readonly IntPtr NativeFieldInfoPtr_wormEntities;

		// Token: 0x04000B43 RID: 2883
		private static readonly IntPtr NativeFieldInfoPtr_OnDataProvided;

		// Token: 0x04000B44 RID: 2884
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x04000B45 RID: 2885
		private static readonly IntPtr NativeMethodInfoPtr_IntroducePlayerPile_Private_Void_EntityComponent_0;

		// Token: 0x04000B46 RID: 2886
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000B47 RID: 2887
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000B48 RID: 2888
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__5_0_Private_Boolean_EntityComponent_0;

		// Token: 0x020003C8 RID: 968
		[ObfuscatedName("worm.match.components.PlayerLeaderDataProvider+<Start>d__5")]
		public sealed class _Start_d__5 : global::Il2CppSystem.Object
		{
			// Token: 0x06002727 RID: 10023 RVA: 0x0008EEE8 File Offset: 0x0008D0E8
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__5()
			{
				Il2CppClassPointerStore<PlayerLeaderDataProvider._Start_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerLeaderDataProvider>.NativeClassPtr, "<Start>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerLeaderDataProvider._Start_d__5>.NativeClassPtr);
				PlayerLeaderDataProvider._Start_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLeaderDataProvider._Start_d__5>.NativeClassPtr, "<>1__state");
				PlayerLeaderDataProvider._Start_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLeaderDataProvider._Start_d__5>.NativeClassPtr, "<>2__current");
				PlayerLeaderDataProvider._Start_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLeaderDataProvider._Start_d__5>.NativeClassPtr, "<>4__this");
				PlayerLeaderDataProvider._Start_d__5.NativeFieldInfoPtr__entitiesProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLeaderDataProvider._Start_d__5>.NativeClassPtr, "<entitiesProvider>5__2");
				PlayerLeaderDataProvider._Start_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLeaderDataProvider._Start_d__5>.NativeClassPtr, 100665958);
				PlayerLeaderDataProvider._Start_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLeaderDataProvider._Start_d__5>.NativeClassPtr, 100665959);
				PlayerLeaderDataProvider._Start_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLeaderDataProvider._Start_d__5>.NativeClassPtr, 100665960);
				PlayerLeaderDataProvider._Start_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLeaderDataProvider._Start_d__5>.NativeClassPtr, 100665961);
				PlayerLeaderDataProvider._Start_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLeaderDataProvider._Start_d__5>.NativeClassPtr, 100665962);
				PlayerLeaderDataProvider._Start_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLeaderDataProvider._Start_d__5>.NativeClassPtr, 100665963);
			}

			// Token: 0x06002728 RID: 10024 RVA: 0x0008EFDC File Offset: 0x0008D1DC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerLeaderDataProvider._Start_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerLeaderDataProvider._Start_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002729 RID: 10025 RVA: 0x0008F024 File Offset: 0x0008D224
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerLeaderDataProvider._Start_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600272A RID: 10026 RVA: 0x0008F058 File Offset: 0x0008D258
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713004, XrefRangeEnd = 713039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerLeaderDataProvider._Start_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000AEA RID: 2794
			// (get) Token: 0x0600272B RID: 10027 RVA: 0x0008F094 File Offset: 0x0008D294
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerLeaderDataProvider._Start_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600272C RID: 10028 RVA: 0x0008F0D4 File Offset: 0x0008D2D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713039, XrefRangeEnd = 713044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerLeaderDataProvider._Start_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000AEB RID: 2795
			// (get) Token: 0x0600272D RID: 10029 RVA: 0x0008F108 File Offset: 0x0008D308
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerLeaderDataProvider._Start_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600272E RID: 10030 RVA: 0x000158D1 File Offset: 0x00013AD1
			public _Start_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AE6 RID: 2790
			// (get) Token: 0x0600272F RID: 10031 RVA: 0x0008F148 File Offset: 0x0008D348
			// (set) Token: 0x06002730 RID: 10032 RVA: 0x000158DA File Offset: 0x00013ADA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLeaderDataProvider._Start_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLeaderDataProvider._Start_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000AE7 RID: 2791
			// (get) Token: 0x06002731 RID: 10033 RVA: 0x0008F170 File Offset: 0x0008D370
			// (set) Token: 0x06002732 RID: 10034 RVA: 0x000158F5 File Offset: 0x00013AF5
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLeaderDataProvider._Start_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLeaderDataProvider._Start_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AE8 RID: 2792
			// (get) Token: 0x06002733 RID: 10035 RVA: 0x0008F1A0 File Offset: 0x0008D3A0
			// (set) Token: 0x06002734 RID: 10036 RVA: 0x00015914 File Offset: 0x00013B14
			public unsafe PlayerLeaderDataProvider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLeaderDataProvider._Start_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerLeaderDataProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLeaderDataProvider._Start_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AE9 RID: 2793
			// (get) Token: 0x06002735 RID: 10037 RVA: 0x0008F1D0 File Offset: 0x0008D3D0
			// (set) Token: 0x06002736 RID: 10038 RVA: 0x00015933 File Offset: 0x00013B33
			public unsafe EntitiesProvider _entitiesProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLeaderDataProvider._Start_d__5.NativeFieldInfoPtr__entitiesProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntitiesProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLeaderDataProvider._Start_d__5.NativeFieldInfoPtr__entitiesProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400168C RID: 5772
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400168D RID: 5773
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400168E RID: 5774
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400168F RID: 5775
			private static readonly IntPtr NativeFieldInfoPtr__entitiesProvider_5__2;

			// Token: 0x04001690 RID: 5776
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001691 RID: 5777
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001692 RID: 5778
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001693 RID: 5779
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001694 RID: 5780
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001695 RID: 5781
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
