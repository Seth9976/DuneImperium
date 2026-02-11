using System;
using boardgames.match.behaviours;
using boardgames.moz;
using dwd.core.eventTriggers;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001F4 RID: 500
	public class WormFremenBondFTTTrigger : MonoBehaviour
	{
		// Token: 0x0600161C RID: 5660 RVA: 0x0005B430 File Offset: 0x00059630
		// Note: this type is marked as 'beforefieldinit'.
		static WormFremenBondFTTTrigger()
		{
			Il2CppClassPointerStore<WormFremenBondFTTTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormFremenBondFTTTrigger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormFremenBondFTTTrigger>.NativeClassPtr);
			WormFremenBondFTTTrigger.NativeFieldInfoPtr_EventName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFremenBondFTTTrigger>.NativeClassPtr, "EventName");
			WormFremenBondFTTTrigger.NativeFieldInfoPtr_mozManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFremenBondFTTTrigger>.NativeClassPtr, "mozManager");
			WormFremenBondFTTTrigger.NativeFieldInfoPtr_entitiesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFremenBondFTTTrigger>.NativeClassPtr, "entitiesProvider");
			WormFremenBondFTTTrigger.NativeFieldInfoPtr_clientEventResponder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFremenBondFTTTrigger>.NativeClassPtr, "clientEventResponder");
			WormFremenBondFTTTrigger.NativeFieldInfoPtr__LastTriggerCard_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFremenBondFTTTrigger>.NativeClassPtr, "<LastTriggerCard>k__BackingField");
			WormFremenBondFTTTrigger.NativeMethodInfoPtr_get_LastTriggerCard_Public_get_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFremenBondFTTTrigger>.NativeClassPtr, 100666343);
			WormFremenBondFTTTrigger.NativeMethodInfoPtr_set_LastTriggerCard_Private_set_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFremenBondFTTTrigger>.NativeClassPtr, 100666344);
			WormFremenBondFTTTrigger.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFremenBondFTTTrigger>.NativeClassPtr, 100666345);
			WormFremenBondFTTTrigger.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFremenBondFTTTrigger>.NativeClassPtr, 100666346);
			WormFremenBondFTTTrigger.NativeMethodInfoPtr_HandleMoz_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFremenBondFTTTrigger>.NativeClassPtr, 100666347);
			WormFremenBondFTTTrigger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFremenBondFTTTrigger>.NativeClassPtr, 100666348);
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x0600161D RID: 5661 RVA: 0x0005B53C File Offset: 0x0005973C
		// (set) Token: 0x0600161E RID: 5662 RVA: 0x0005B57C File Offset: 0x0005977C
		public unsafe EntityComponent LastTriggerCard
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFremenBondFTTTrigger.NativeMethodInfoPtr_get_LastTriggerCard_Public_get_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFremenBondFTTTrigger.NativeMethodInfoPtr_set_LastTriggerCard_Private_set_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x0005B5C0 File Offset: 0x000597C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716070, XrefRangeEnd = 716075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFremenBondFTTTrigger.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x0005B600 File Offset: 0x00059800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716075, XrefRangeEnd = 716088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFremenBondFTTTrigger.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x0005B634 File Offset: 0x00059834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716088, XrefRangeEnd = 716130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleMoz(string entityIDString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(entityIDString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFremenBondFTTTrigger.NativeMethodInfoPtr_HandleMoz_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x0005B678 File Offset: 0x00059878
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormFremenBondFTTTrigger()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormFremenBondFTTTrigger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFremenBondFTTTrigger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x0000D585 File Offset: 0x0000B785
		public WormFremenBondFTTTrigger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06001624 RID: 5668 RVA: 0x0005B6B4 File Offset: 0x000598B4
		// (set) Token: 0x06001625 RID: 5669 RVA: 0x0000D58E File Offset: 0x0000B78E
		public unsafe static string EventName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormFremenBondFTTTrigger.NativeFieldInfoPtr_EventName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormFremenBondFTTTrigger.NativeFieldInfoPtr_EventName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06001626 RID: 5670 RVA: 0x0005B6D4 File Offset: 0x000598D4
		// (set) Token: 0x06001627 RID: 5671 RVA: 0x0000D5A0 File Offset: 0x0000B7A0
		public unsafe MozManager mozManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFremenBondFTTTrigger.NativeFieldInfoPtr_mozManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MozManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFremenBondFTTTrigger.NativeFieldInfoPtr_mozManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06001628 RID: 5672 RVA: 0x0005B704 File Offset: 0x00059904
		// (set) Token: 0x06001629 RID: 5673 RVA: 0x0000D5BF File Offset: 0x0000B7BF
		public unsafe DBGEntitiesProvider entitiesProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFremenBondFTTTrigger.NativeFieldInfoPtr_entitiesProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFremenBondFTTTrigger.NativeFieldInfoPtr_entitiesProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x0600162A RID: 5674 RVA: 0x0005B734 File Offset: 0x00059934
		// (set) Token: 0x0600162B RID: 5675 RVA: 0x0000D5DE File Offset: 0x0000B7DE
		public unsafe ClientEventResponder clientEventResponder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFremenBondFTTTrigger.NativeFieldInfoPtr_clientEventResponder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFremenBondFTTTrigger.NativeFieldInfoPtr_clientEventResponder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x0600162C RID: 5676 RVA: 0x0005B764 File Offset: 0x00059964
		// (set) Token: 0x0600162D RID: 5677 RVA: 0x0000D5FD File Offset: 0x0000B7FD
		public unsafe EntityComponent _LastTriggerCard_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFremenBondFTTTrigger.NativeFieldInfoPtr__LastTriggerCard_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFremenBondFTTTrigger.NativeFieldInfoPtr__LastTriggerCard_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CD4 RID: 3284
		private static readonly IntPtr NativeFieldInfoPtr_EventName;

		// Token: 0x04000CD5 RID: 3285
		private static readonly IntPtr NativeFieldInfoPtr_mozManager;

		// Token: 0x04000CD6 RID: 3286
		private static readonly IntPtr NativeFieldInfoPtr_entitiesProvider;

		// Token: 0x04000CD7 RID: 3287
		private static readonly IntPtr NativeFieldInfoPtr_clientEventResponder;

		// Token: 0x04000CD8 RID: 3288
		private static readonly IntPtr NativeFieldInfoPtr__LastTriggerCard_k__BackingField;

		// Token: 0x04000CD9 RID: 3289
		private static readonly IntPtr NativeMethodInfoPtr_get_LastTriggerCard_Public_get_EntityComponent_0;

		// Token: 0x04000CDA RID: 3290
		private static readonly IntPtr NativeMethodInfoPtr_set_LastTriggerCard_Private_set_Void_EntityComponent_0;

		// Token: 0x04000CDB RID: 3291
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x04000CDC RID: 3292
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000CDD RID: 3293
		private static readonly IntPtr NativeMethodInfoPtr_HandleMoz_Private_Void_String_0;

		// Token: 0x04000CDE RID: 3294
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003EC RID: 1004
		[ObfuscatedName("worm.match.components.WormFremenBondFTTTrigger+<Start>d__8")]
		public sealed class _Start_d__8 : global::Il2CppSystem.Object
		{
			// Token: 0x060028C8 RID: 10440 RVA: 0x000939BC File Offset: 0x00091BBC
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__8()
			{
				Il2CppClassPointerStore<WormFremenBondFTTTrigger._Start_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormFremenBondFTTTrigger>.NativeClassPtr, "<Start>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormFremenBondFTTTrigger._Start_d__8>.NativeClassPtr);
				WormFremenBondFTTTrigger._Start_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFremenBondFTTTrigger._Start_d__8>.NativeClassPtr, "<>1__state");
				WormFremenBondFTTTrigger._Start_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFremenBondFTTTrigger._Start_d__8>.NativeClassPtr, "<>2__current");
				WormFremenBondFTTTrigger._Start_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFremenBondFTTTrigger._Start_d__8>.NativeClassPtr, "<>4__this");
				WormFremenBondFTTTrigger._Start_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFremenBondFTTTrigger._Start_d__8>.NativeClassPtr, 100666349);
				WormFremenBondFTTTrigger._Start_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFremenBondFTTTrigger._Start_d__8>.NativeClassPtr, 100666350);
				WormFremenBondFTTTrigger._Start_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFremenBondFTTTrigger._Start_d__8>.NativeClassPtr, 100666351);
				WormFremenBondFTTTrigger._Start_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFremenBondFTTTrigger._Start_d__8>.NativeClassPtr, 100666352);
				WormFremenBondFTTTrigger._Start_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFremenBondFTTTrigger._Start_d__8>.NativeClassPtr, 100666353);
				WormFremenBondFTTTrigger._Start_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFremenBondFTTTrigger._Start_d__8>.NativeClassPtr, 100666354);
			}

			// Token: 0x060028C9 RID: 10441 RVA: 0x00093A9C File Offset: 0x00091C9C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormFremenBondFTTTrigger._Start_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFremenBondFTTTrigger._Start_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060028CA RID: 10442 RVA: 0x00093AE4 File Offset: 0x00091CE4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFremenBondFTTTrigger._Start_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060028CB RID: 10443 RVA: 0x00093B18 File Offset: 0x00091D18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716051, XrefRangeEnd = 716065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFremenBondFTTTrigger._Start_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B74 RID: 2932
			// (get) Token: 0x060028CC RID: 10444 RVA: 0x00093B54 File Offset: 0x00091D54
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFremenBondFTTTrigger._Start_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060028CD RID: 10445 RVA: 0x00093B94 File Offset: 0x00091D94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716065, XrefRangeEnd = 716070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFremenBondFTTTrigger._Start_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B75 RID: 2933
			// (get) Token: 0x060028CE RID: 10446 RVA: 0x00093BC8 File Offset: 0x00091DC8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFremenBondFTTTrigger._Start_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060028CF RID: 10447 RVA: 0x000165CE File Offset: 0x000147CE
			public _Start_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B71 RID: 2929
			// (get) Token: 0x060028D0 RID: 10448 RVA: 0x00093C08 File Offset: 0x00091E08
			// (set) Token: 0x060028D1 RID: 10449 RVA: 0x000165D7 File Offset: 0x000147D7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFremenBondFTTTrigger._Start_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFremenBondFTTTrigger._Start_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B72 RID: 2930
			// (get) Token: 0x060028D2 RID: 10450 RVA: 0x00093C30 File Offset: 0x00091E30
			// (set) Token: 0x060028D3 RID: 10451 RVA: 0x000165F2 File Offset: 0x000147F2
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFremenBondFTTTrigger._Start_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFremenBondFTTTrigger._Start_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B73 RID: 2931
			// (get) Token: 0x060028D4 RID: 10452 RVA: 0x00093C60 File Offset: 0x00091E60
			// (set) Token: 0x060028D5 RID: 10453 RVA: 0x00016611 File Offset: 0x00014811
			public unsafe WormFremenBondFTTTrigger __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFremenBondFTTTrigger._Start_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormFremenBondFTTTrigger>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFremenBondFTTTrigger._Start_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400177E RID: 6014
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400177F RID: 6015
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001780 RID: 6016
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001781 RID: 6017
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001782 RID: 6018
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001783 RID: 6019
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001784 RID: 6020
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001785 RID: 6021
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001786 RID: 6022
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
