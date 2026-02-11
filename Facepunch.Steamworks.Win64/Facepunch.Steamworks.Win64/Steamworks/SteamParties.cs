using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x020000A9 RID: 169
	public class SteamParties : SteamClientClass<SteamParties>
	{
		// Token: 0x06000A24 RID: 2596 RVA: 0x00049858 File Offset: 0x00047A58
		// Note: this type is marked as 'beforefieldinit'.
		static SteamParties()
		{
			Il2CppClassPointerStore<SteamParties>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "SteamParties");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamParties>.NativeClassPtr);
			SteamParties.NativeFieldInfoPtr_OnBeaconLocationsUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamParties>.NativeClassPtr, "OnBeaconLocationsUpdated");
			SteamParties.NativeFieldInfoPtr_OnActiveBeaconsUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamParties>.NativeClassPtr, "OnActiveBeaconsUpdated");
			SteamParties.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamParties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParties>.NativeClassPtr, 100665785);
			SteamParties.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParties>.NativeClassPtr, 100665786);
			SteamParties.NativeMethodInfoPtr_InstallEvents_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParties>.NativeClassPtr, 100665787);
			SteamParties.NativeMethodInfoPtr_add_OnBeaconLocationsUpdated_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParties>.NativeClassPtr, 100665788);
			SteamParties.NativeMethodInfoPtr_remove_OnBeaconLocationsUpdated_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParties>.NativeClassPtr, 100665789);
			SteamParties.NativeMethodInfoPtr_add_OnActiveBeaconsUpdated_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParties>.NativeClassPtr, 100665790);
			SteamParties.NativeMethodInfoPtr_remove_OnActiveBeaconsUpdated_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParties>.NativeClassPtr, 100665791);
			SteamParties.NativeMethodInfoPtr_get_ActiveBeaconCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParties>.NativeClassPtr, 100665792);
			SteamParties.NativeMethodInfoPtr_get_ActiveBeacons_Public_Static_get_IEnumerable_1_PartyBeacon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParties>.NativeClassPtr, 100665793);
			SteamParties.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParties>.NativeClassPtr, 100665794);
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000A25 RID: 2597 RVA: 0x00049978 File Offset: 0x00047B78
		public unsafe static ISteamParties Internal
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 941822, RefRangeEnd = 941832, XrefRangeStart = 941819, XrefRangeEnd = 941822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParties.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamParties_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISteamParties>(intPtr3) : null;
			}
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x000499AC File Offset: 0x00047BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941832, XrefRangeEnd = 941837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeInterface(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref server;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamParties.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x000499F8 File Offset: 0x00047BF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 941877, RefRangeEnd = 941878, XrefRangeStart = 941837, XrefRangeEnd = 941877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InstallEvents(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref server;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParties.NativeMethodInfoPtr_InstallEvents_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x00049A38 File Offset: 0x00047C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941878, XrefRangeEnd = 941885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnBeaconLocationsUpdated(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParties.NativeMethodInfoPtr_add_OnBeaconLocationsUpdated_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x00049A70 File Offset: 0x00047C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941885, XrefRangeEnd = 941892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnBeaconLocationsUpdated(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParties.NativeMethodInfoPtr_remove_OnBeaconLocationsUpdated_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x00049AA8 File Offset: 0x00047CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941892, XrefRangeEnd = 941899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnActiveBeaconsUpdated(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParties.NativeMethodInfoPtr_add_OnActiveBeaconsUpdated_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x00049AE0 File Offset: 0x00047CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941899, XrefRangeEnd = 941906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnActiveBeaconsUpdated(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParties.NativeMethodInfoPtr_remove_OnActiveBeaconsUpdated_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x00049B18 File Offset: 0x00047D18
		public unsafe static int ActiveBeaconCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941906, XrefRangeEnd = 941909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParties.NativeMethodInfoPtr_get_ActiveBeaconCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000A2D RID: 2605 RVA: 0x00049B48 File Offset: 0x00047D48
		public unsafe static IEnumerable<PartyBeacon> ActiveBeacons
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941909, XrefRangeEnd = 941914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParties.NativeMethodInfoPtr_get_ActiveBeacons_Public_Static_get_IEnumerable_1_PartyBeacon_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PartyBeacon>>(intPtr3) : null;
			}
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x00049B7C File Offset: 0x00047D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941914, XrefRangeEnd = 941917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamParties()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamParties>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParties.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x00002A8A File Offset: 0x00000C8A
		public SteamParties(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000A30 RID: 2608 RVA: 0x00049BB8 File Offset: 0x00047DB8
		// (set) Token: 0x06000A31 RID: 2609 RVA: 0x00002A93 File Offset: 0x00000C93
		public unsafe static Action OnBeaconLocationsUpdated
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamParties.NativeFieldInfoPtr_OnBeaconLocationsUpdated, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamParties.NativeFieldInfoPtr_OnBeaconLocationsUpdated, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000A32 RID: 2610 RVA: 0x00049BE0 File Offset: 0x00047DE0
		// (set) Token: 0x06000A33 RID: 2611 RVA: 0x00002AA5 File Offset: 0x00000CA5
		public unsafe static Action OnActiveBeaconsUpdated
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamParties.NativeFieldInfoPtr_OnActiveBeaconsUpdated, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamParties.NativeFieldInfoPtr_OnActiveBeaconsUpdated, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001104 RID: 4356
		private static readonly IntPtr NativeFieldInfoPtr_OnBeaconLocationsUpdated;

		// Token: 0x04001105 RID: 4357
		private static readonly IntPtr NativeFieldInfoPtr_OnActiveBeaconsUpdated;

		// Token: 0x04001106 RID: 4358
		private static readonly IntPtr NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamParties_0;

		// Token: 0x04001107 RID: 4359
		private static readonly IntPtr NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0;

		// Token: 0x04001108 RID: 4360
		private static readonly IntPtr NativeMethodInfoPtr_InstallEvents_Internal_Void_Boolean_0;

		// Token: 0x04001109 RID: 4361
		private static readonly IntPtr NativeMethodInfoPtr_add_OnBeaconLocationsUpdated_Public_Static_add_Void_Action_0;

		// Token: 0x0400110A RID: 4362
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnBeaconLocationsUpdated_Public_Static_rem_Void_Action_0;

		// Token: 0x0400110B RID: 4363
		private static readonly IntPtr NativeMethodInfoPtr_add_OnActiveBeaconsUpdated_Public_Static_add_Void_Action_0;

		// Token: 0x0400110C RID: 4364
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnActiveBeaconsUpdated_Public_Static_rem_Void_Action_0;

		// Token: 0x0400110D RID: 4365
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveBeaconCount_Public_Static_get_Int32_0;

		// Token: 0x0400110E RID: 4366
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveBeacons_Public_Static_get_IEnumerable_1_PartyBeacon_0;

		// Token: 0x0400110F RID: 4367
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200024D RID: 589
		[ObfuscatedName("Steamworks.SteamParties+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001DAD RID: 7597 RVA: 0x00087E30 File Offset: 0x00086030
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SteamParties.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamParties>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamParties.__c>.NativeClassPtr);
				SteamParties.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamParties.__c>.NativeClassPtr, "<>9");
				SteamParties.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamParties.__c>.NativeClassPtr, "<>9__3_0");
				SteamParties.__c.NativeFieldInfoPtr___9__3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamParties.__c>.NativeClassPtr, "<>9__3_1");
				SteamParties.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParties.__c>.NativeClassPtr, 100665796);
				SteamParties.__c.NativeMethodInfoPtr__InstallEvents_b__3_0_Internal_Void_AvailableBeaconLocationsUpdated_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParties.__c>.NativeClassPtr, 100665797);
				SteamParties.__c.NativeMethodInfoPtr__InstallEvents_b__3_1_Internal_Void_ActiveBeaconsUpdated_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParties.__c>.NativeClassPtr, 100665798);
			}

			// Token: 0x06001DAE RID: 7598 RVA: 0x00087ED4 File Offset: 0x000860D4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamParties.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParties.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DAF RID: 7599 RVA: 0x00087F10 File Offset: 0x00086110
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941800, XrefRangeEnd = 941802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__3_0(AvailableBeaconLocationsUpdated_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParties.__c.NativeMethodInfoPtr__InstallEvents_b__3_0_Internal_Void_AvailableBeaconLocationsUpdated_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001DB0 RID: 7600 RVA: 0x00087F50 File Offset: 0x00086150
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941802, XrefRangeEnd = 941804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__3_1(ActiveBeaconsUpdated_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParties.__c.NativeMethodInfoPtr__InstallEvents_b__3_1_Internal_Void_ActiveBeaconsUpdated_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001DB1 RID: 7601 RVA: 0x0000A8FF File Offset: 0x00008AFF
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700077B RID: 1915
			// (get) Token: 0x06001DB2 RID: 7602 RVA: 0x00087F90 File Offset: 0x00086190
			// (set) Token: 0x06001DB3 RID: 7603 RVA: 0x0000A908 File Offset: 0x00008B08
			public unsafe static SteamParties.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamParties.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SteamParties.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamParties.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700077C RID: 1916
			// (get) Token: 0x06001DB4 RID: 7604 RVA: 0x00087FB8 File Offset: 0x000861B8
			// (set) Token: 0x06001DB5 RID: 7605 RVA: 0x0000A91A File Offset: 0x00008B1A
			public unsafe static Action<AvailableBeaconLocationsUpdated_t> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamParties.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AvailableBeaconLocationsUpdated_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamParties.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700077D RID: 1917
			// (get) Token: 0x06001DB6 RID: 7606 RVA: 0x00087FE0 File Offset: 0x000861E0
			// (set) Token: 0x06001DB7 RID: 7607 RVA: 0x0000A92C File Offset: 0x00008B2C
			public unsafe static Action<ActiveBeaconsUpdated_t> __9__3_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamParties.__c.NativeFieldInfoPtr___9__3_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ActiveBeaconsUpdated_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamParties.__c.NativeFieldInfoPtr___9__3_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400214C RID: 8524
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400214D RID: 8525
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x0400214E RID: 8526
			private static readonly IntPtr NativeFieldInfoPtr___9__3_1;

			// Token: 0x0400214F RID: 8527
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002150 RID: 8528
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__3_0_Internal_Void_AvailableBeaconLocationsUpdated_t_0;

			// Token: 0x04002151 RID: 8529
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__3_1_Internal_Void_ActiveBeaconsUpdated_t_0;
		}

		// Token: 0x0200024E RID: 590
		[ObfuscatedName("Steamworks.SteamParties+<get_ActiveBeacons>d__13")]
		public sealed class _get_ActiveBeacons_d__13 : Object
		{
			// Token: 0x06001DB8 RID: 7608 RVA: 0x00088008 File Offset: 0x00086208
			// Note: this type is marked as 'beforefieldinit'.
			static _get_ActiveBeacons_d__13()
			{
				Il2CppClassPointerStore<SteamParties._get_ActiveBeacons_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamParties>.NativeClassPtr, "<get_ActiveBeacons>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamParties._get_ActiveBeacons_d__13>.NativeClassPtr);
				SteamParties._get_ActiveBeacons_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamParties._get_ActiveBeacons_d__13>.NativeClassPtr, "<>1__state");
				SteamParties._get_ActiveBeacons_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamParties._get_ActiveBeacons_d__13>.NativeClassPtr, "<>2__current");
				SteamParties._get_ActiveBeacons_d__13.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamParties._get_ActiveBeacons_d__13>.NativeClassPtr, "<>l__initialThreadId");
				SteamParties._get_ActiveBeacons_d__13.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamParties._get_ActiveBeacons_d__13>.NativeClassPtr, "<i>5__2");
				SteamParties._get_ActiveBeacons_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParties._get_ActiveBeacons_d__13>.NativeClassPtr, 100665799);
				SteamParties._get_ActiveBeacons_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParties._get_ActiveBeacons_d__13>.NativeClassPtr, 100665800);
				SteamParties._get_ActiveBeacons_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParties._get_ActiveBeacons_d__13>.NativeClassPtr, 100665801);
				SteamParties._get_ActiveBeacons_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Steamworks_PartyBeacon__get_Current_Private_Virtual_Final_New_get_PartyBeacon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParties._get_ActiveBeacons_d__13>.NativeClassPtr, 100665802);
				SteamParties._get_ActiveBeacons_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParties._get_ActiveBeacons_d__13>.NativeClassPtr, 100665803);
				SteamParties._get_ActiveBeacons_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParties._get_ActiveBeacons_d__13>.NativeClassPtr, 100665804);
				SteamParties._get_ActiveBeacons_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Steamworks_PartyBeacon__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PartyBeacon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParties._get_ActiveBeacons_d__13>.NativeClassPtr, 100665805);
				SteamParties._get_ActiveBeacons_d__13.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParties._get_ActiveBeacons_d__13>.NativeClassPtr, 100665806);
			}

			// Token: 0x06001DB9 RID: 7609 RVA: 0x00088124 File Offset: 0x00086324
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _get_ActiveBeacons_d__13(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamParties._get_ActiveBeacons_d__13>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParties._get_ActiveBeacons_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001DBA RID: 7610 RVA: 0x0008816C File Offset: 0x0008636C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParties._get_ActiveBeacons_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DBB RID: 7611 RVA: 0x000881A0 File Offset: 0x000863A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941804, XrefRangeEnd = 941809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParties._get_ActiveBeacons_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000782 RID: 1922
			// (get) Token: 0x06001DBC RID: 7612 RVA: 0x000881DC File Offset: 0x000863DC
			public unsafe PartyBeacon System.Collections.Generic.IEnumerator<Steamworks.PartyBeacon>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParties._get_ActiveBeacons_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Steamworks_PartyBeacon__get_Current_Private_Virtual_Final_New_get_PartyBeacon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001DBD RID: 7613 RVA: 0x00088218 File Offset: 0x00086418
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941809, XrefRangeEnd = 941814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParties._get_ActiveBeacons_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000783 RID: 1923
			// (get) Token: 0x06001DBE RID: 7614 RVA: 0x0008824C File Offset: 0x0008644C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941814, XrefRangeEnd = 941817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParties._get_ActiveBeacons_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001DBF RID: 7615 RVA: 0x0008828C File Offset: 0x0008648C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941817, XrefRangeEnd = 941819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<PartyBeacon> System_Collections_Generic_IEnumerable_Steamworks_PartyBeacon__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParties._get_ActiveBeacons_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Steamworks_PartyBeacon__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PartyBeacon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<PartyBeacon>>(intPtr3) : null;
			}

			// Token: 0x06001DC0 RID: 7616 RVA: 0x000882CC File Offset: 0x000864CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParties._get_ActiveBeacons_d__13.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001DC1 RID: 7617 RVA: 0x0000A93E File Offset: 0x00008B3E
			public _get_ActiveBeacons_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700077E RID: 1918
			// (get) Token: 0x06001DC2 RID: 7618 RVA: 0x0008830C File Offset: 0x0008650C
			// (set) Token: 0x06001DC3 RID: 7619 RVA: 0x0000A947 File Offset: 0x00008B47
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamParties._get_ActiveBeacons_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamParties._get_ActiveBeacons_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700077F RID: 1919
			// (get) Token: 0x06001DC4 RID: 7620 RVA: 0x00088334 File Offset: 0x00086534
			// (set) Token: 0x06001DC5 RID: 7621 RVA: 0x0000A962 File Offset: 0x00008B62
			public unsafe PartyBeacon __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamParties._get_ActiveBeacons_d__13.NativeFieldInfoPtr___2__current);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamParties._get_ActiveBeacons_d__13.NativeFieldInfoPtr___2__current)) = value;
				}
			}

			// Token: 0x17000780 RID: 1920
			// (get) Token: 0x06001DC6 RID: 7622 RVA: 0x0008835C File Offset: 0x0008655C
			// (set) Token: 0x06001DC7 RID: 7623 RVA: 0x0000A97D File Offset: 0x00008B7D
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamParties._get_ActiveBeacons_d__13.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamParties._get_ActiveBeacons_d__13.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000781 RID: 1921
			// (get) Token: 0x06001DC8 RID: 7624 RVA: 0x00088384 File Offset: 0x00086584
			// (set) Token: 0x06001DC9 RID: 7625 RVA: 0x0000A998 File Offset: 0x00008B98
			public unsafe uint _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamParties._get_ActiveBeacons_d__13.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamParties._get_ActiveBeacons_d__13.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x04002152 RID: 8530
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002153 RID: 8531
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002154 RID: 8532
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002155 RID: 8533
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x04002156 RID: 8534
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002157 RID: 8535
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002158 RID: 8536
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002159 RID: 8537
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Steamworks_PartyBeacon__get_Current_Private_Virtual_Final_New_get_PartyBeacon_0;

			// Token: 0x0400215A RID: 8538
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400215B RID: 8539
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400215C RID: 8540
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Steamworks_PartyBeacon__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PartyBeacon_0;

			// Token: 0x0400215D RID: 8541
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
