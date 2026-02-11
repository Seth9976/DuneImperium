using System;
using boardgames.data;
using dwd.core.data.composition;
using dwd.core.settings.platform.definitions;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace boardgames
{
	// Token: 0x020000E3 RID: 227
	public class ConfigurePlayerEvent : MonoBehaviour
	{
		// Token: 0x060009D8 RID: 2520 RVA: 0x0003C760 File Offset: 0x0003A960
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigurePlayerEvent()
		{
			Il2CppClassPointerStore<ConfigurePlayerEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames", "ConfigurePlayerEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigurePlayerEvent>.NativeClassPtr);
			ConfigurePlayerEvent.NativeFieldInfoPtr_playerConfigurationModalScope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurePlayerEvent>.NativeClassPtr, "playerConfigurationModalScope");
			ConfigurePlayerEvent.NativeFieldInfoPtr_validColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurePlayerEvent>.NativeClassPtr, "validColors");
			ConfigurePlayerEvent.NativeFieldInfoPtr_validAvatars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurePlayerEvent>.NativeClassPtr, "validAvatars");
			ConfigurePlayerEvent.NativeFieldInfoPtr_localPlayerSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurePlayerEvent>.NativeClassPtr, "localPlayerSlot");
			ConfigurePlayerEvent.NativeFieldInfoPtr_online = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurePlayerEvent>.NativeClassPtr, "online");
			ConfigurePlayerEvent.NativeMethodInfoPtr_get_colorTypePref_Private_get_PlatformSettingDefinition_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurePlayerEvent>.NativeClassPtr, 100664729);
			ConfigurePlayerEvent.NativeMethodInfoPtr_get_avatarTypePref_Private_get_PlatformSettingDefinition_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurePlayerEvent>.NativeClassPtr, 100664730);
			ConfigurePlayerEvent.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurePlayerEvent>.NativeClassPtr, 100664731);
			ConfigurePlayerEvent.NativeMethodInfoPtr_Event_ConfigurePlayer_Public_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurePlayerEvent>.NativeClassPtr, 100664732);
			ConfigurePlayerEvent.NativeMethodInfoPtr_ConfigurePlayer_Private_IEnumerator_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurePlayerEvent>.NativeClassPtr, 100664733);
			ConfigurePlayerEvent.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurePlayerEvent>.NativeClassPtr, 100664734);
			ConfigurePlayerEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurePlayerEvent>.NativeClassPtr, 100664735);
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x060009D9 RID: 2521 RVA: 0x0003C880 File Offset: 0x0003AA80
		public unsafe PlatformSettingDefinition<string> colorTypePref
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 506289, RefRangeEnd = 506293, XrefRangeStart = 506285, XrefRangeEnd = 506289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurePlayerEvent.NativeMethodInfoPtr_get_colorTypePref_Private_get_PlatformSettingDefinition_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<string>>(intPtr3) : null;
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x060009DA RID: 2522 RVA: 0x0003C8C0 File Offset: 0x0003AAC0
		public unsafe PlatformSettingDefinition<string> avatarTypePref
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 506297, RefRangeEnd = 506301, XrefRangeStart = 506293, XrefRangeEnd = 506297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurePlayerEvent.NativeMethodInfoPtr_get_avatarTypePref_Private_get_PlatformSettingDefinition_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<string>>(intPtr3) : null;
			}
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x0003C900 File Offset: 0x0003AB00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506301, XrefRangeEnd = 506382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurePlayerEvent.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x0003C934 File Offset: 0x0003AB34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506382, XrefRangeEnd = 506389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ConfigurePlayer(DataComposition data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurePlayerEvent.NativeMethodInfoPtr_Event_ConfigurePlayer_Public_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x0003C978 File Offset: 0x0003AB78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506389, XrefRangeEnd = 506395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ConfigurePlayer(DataComposition data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurePlayerEvent.NativeMethodInfoPtr_ConfigurePlayer_Private_IEnumerator_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x0003C9C8 File Offset: 0x0003ABC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506395, XrefRangeEnd = 506408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurePlayerEvent.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x0003C9FC File Offset: 0x0003ABFC
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigurePlayerEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigurePlayerEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurePlayerEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x00006B32 File Offset: 0x00004D32
		public ConfigurePlayerEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x060009E1 RID: 2529 RVA: 0x0003CA38 File Offset: 0x0003AC38
		// (set) Token: 0x060009E2 RID: 2530 RVA: 0x00006B3B File Offset: 0x00004D3B
		public unsafe ModalScope playerConfigurationModalScope
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurePlayerEvent.NativeFieldInfoPtr_playerConfigurationModalScope);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ModalScope>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurePlayerEvent.NativeFieldInfoPtr_playerConfigurationModalScope), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x060009E3 RID: 2531 RVA: 0x0003CA68 File Offset: 0x0003AC68
		// (set) Token: 0x060009E4 RID: 2532 RVA: 0x00006B5A File Offset: 0x00004D5A
		public unsafe ValidStringsScriptableObject validColors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurePlayerEvent.NativeFieldInfoPtr_validColors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidStringsScriptableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurePlayerEvent.NativeFieldInfoPtr_validColors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x060009E5 RID: 2533 RVA: 0x0003CA98 File Offset: 0x0003AC98
		// (set) Token: 0x060009E6 RID: 2534 RVA: 0x00006B79 File Offset: 0x00004D79
		public unsafe ValidStringsScriptableObject validAvatars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurePlayerEvent.NativeFieldInfoPtr_validAvatars);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidStringsScriptableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurePlayerEvent.NativeFieldInfoPtr_validAvatars), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x060009E7 RID: 2535 RVA: 0x0003CAC8 File Offset: 0x0003ACC8
		// (set) Token: 0x060009E8 RID: 2536 RVA: 0x00006B98 File Offset: 0x00004D98
		public unsafe SubscriptionProvider localPlayerSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurePlayerEvent.NativeFieldInfoPtr_localPlayerSlot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurePlayerEvent.NativeFieldInfoPtr_localPlayerSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x060009E9 RID: 2537 RVA: 0x0003CAF8 File Offset: 0x0003ACF8
		// (set) Token: 0x060009EA RID: 2538 RVA: 0x00006BB7 File Offset: 0x00004DB7
		public unsafe bool online
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurePlayerEvent.NativeFieldInfoPtr_online);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurePlayerEvent.NativeFieldInfoPtr_online)) = value;
			}
		}

		// Token: 0x040005FB RID: 1531
		private static readonly IntPtr NativeFieldInfoPtr_playerConfigurationModalScope;

		// Token: 0x040005FC RID: 1532
		private static readonly IntPtr NativeFieldInfoPtr_validColors;

		// Token: 0x040005FD RID: 1533
		private static readonly IntPtr NativeFieldInfoPtr_validAvatars;

		// Token: 0x040005FE RID: 1534
		private static readonly IntPtr NativeFieldInfoPtr_localPlayerSlot;

		// Token: 0x040005FF RID: 1535
		private static readonly IntPtr NativeFieldInfoPtr_online;

		// Token: 0x04000600 RID: 1536
		private static readonly IntPtr NativeMethodInfoPtr_get_colorTypePref_Private_get_PlatformSettingDefinition_1_String_0;

		// Token: 0x04000601 RID: 1537
		private static readonly IntPtr NativeMethodInfoPtr_get_avatarTypePref_Private_get_PlatformSettingDefinition_1_String_0;

		// Token: 0x04000602 RID: 1538
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000603 RID: 1539
		private static readonly IntPtr NativeMethodInfoPtr_Event_ConfigurePlayer_Public_Void_DataComposition_0;

		// Token: 0x04000604 RID: 1540
		private static readonly IntPtr NativeMethodInfoPtr_ConfigurePlayer_Private_IEnumerator_DataComposition_0;

		// Token: 0x04000605 RID: 1541
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000606 RID: 1542
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000334 RID: 820
		[ObfuscatedName("boardgames.ConfigurePlayerEvent+<ConfigurePlayer>d__11")]
		public sealed class _ConfigurePlayer_d__11 : global::Il2CppSystem.Object
		{
			// Token: 0x060026B8 RID: 9912 RVA: 0x0009C560 File Offset: 0x0009A760
			// Note: this type is marked as 'beforefieldinit'.
			static _ConfigurePlayer_d__11()
			{
				Il2CppClassPointerStore<ConfigurePlayerEvent._ConfigurePlayer_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfigurePlayerEvent>.NativeClassPtr, "<ConfigurePlayer>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigurePlayerEvent._ConfigurePlayer_d__11>.NativeClassPtr);
				ConfigurePlayerEvent._ConfigurePlayer_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurePlayerEvent._ConfigurePlayer_d__11>.NativeClassPtr, "<>1__state");
				ConfigurePlayerEvent._ConfigurePlayer_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurePlayerEvent._ConfigurePlayer_d__11>.NativeClassPtr, "<>2__current");
				ConfigurePlayerEvent._ConfigurePlayer_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurePlayerEvent._ConfigurePlayer_d__11>.NativeClassPtr, "<>4__this");
				ConfigurePlayerEvent._ConfigurePlayer_d__11.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurePlayerEvent._ConfigurePlayer_d__11>.NativeClassPtr, "data");
				ConfigurePlayerEvent._ConfigurePlayer_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurePlayerEvent._ConfigurePlayer_d__11>.NativeClassPtr, 100664736);
				ConfigurePlayerEvent._ConfigurePlayer_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurePlayerEvent._ConfigurePlayer_d__11>.NativeClassPtr, 100664737);
				ConfigurePlayerEvent._ConfigurePlayer_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurePlayerEvent._ConfigurePlayer_d__11>.NativeClassPtr, 100664738);
				ConfigurePlayerEvent._ConfigurePlayer_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurePlayerEvent._ConfigurePlayer_d__11>.NativeClassPtr, 100664739);
				ConfigurePlayerEvent._ConfigurePlayer_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurePlayerEvent._ConfigurePlayer_d__11>.NativeClassPtr, 100664740);
				ConfigurePlayerEvent._ConfigurePlayer_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurePlayerEvent._ConfigurePlayer_d__11>.NativeClassPtr, 100664741);
			}

			// Token: 0x060026B9 RID: 9913 RVA: 0x0009C654 File Offset: 0x0009A854
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ConfigurePlayer_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigurePlayerEvent._ConfigurePlayer_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurePlayerEvent._ConfigurePlayer_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060026BA RID: 9914 RVA: 0x0009C69C File Offset: 0x0009A89C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurePlayerEvent._ConfigurePlayer_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060026BB RID: 9915 RVA: 0x0009C6D0 File Offset: 0x0009A8D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506235, XrefRangeEnd = 506280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurePlayerEvent._ConfigurePlayer_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000AC0 RID: 2752
			// (get) Token: 0x060026BC RID: 9916 RVA: 0x0009C70C File Offset: 0x0009A90C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurePlayerEvent._ConfigurePlayer_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060026BD RID: 9917 RVA: 0x0009C74C File Offset: 0x0009A94C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506280, XrefRangeEnd = 506285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurePlayerEvent._ConfigurePlayer_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000AC1 RID: 2753
			// (get) Token: 0x060026BE RID: 9918 RVA: 0x0009C780 File Offset: 0x0009A980
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurePlayerEvent._ConfigurePlayer_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060026BF RID: 9919 RVA: 0x000140F7 File Offset: 0x000122F7
			public _ConfigurePlayer_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000ABC RID: 2748
			// (get) Token: 0x060026C0 RID: 9920 RVA: 0x0009C7C0 File Offset: 0x0009A9C0
			// (set) Token: 0x060026C1 RID: 9921 RVA: 0x00014100 File Offset: 0x00012300
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurePlayerEvent._ConfigurePlayer_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurePlayerEvent._ConfigurePlayer_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000ABD RID: 2749
			// (get) Token: 0x060026C2 RID: 9922 RVA: 0x0009C7E8 File Offset: 0x0009A9E8
			// (set) Token: 0x060026C3 RID: 9923 RVA: 0x0001411B File Offset: 0x0001231B
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurePlayerEvent._ConfigurePlayer_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurePlayerEvent._ConfigurePlayer_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000ABE RID: 2750
			// (get) Token: 0x060026C4 RID: 9924 RVA: 0x0009C818 File Offset: 0x0009AA18
			// (set) Token: 0x060026C5 RID: 9925 RVA: 0x0001413A File Offset: 0x0001233A
			public unsafe ConfigurePlayerEvent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurePlayerEvent._ConfigurePlayer_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurePlayerEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurePlayerEvent._ConfigurePlayer_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000ABF RID: 2751
			// (get) Token: 0x060026C6 RID: 9926 RVA: 0x0009C848 File Offset: 0x0009AA48
			// (set) Token: 0x060026C7 RID: 9927 RVA: 0x00014159 File Offset: 0x00012359
			public unsafe DataComposition data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurePlayerEvent._ConfigurePlayer_d__11.NativeFieldInfoPtr_data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurePlayerEvent._ConfigurePlayer_d__11.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001848 RID: 6216
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001849 RID: 6217
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400184A RID: 6218
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400184B RID: 6219
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x0400184C RID: 6220
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400184D RID: 6221
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400184E RID: 6222
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400184F RID: 6223
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001850 RID: 6224
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001851 RID: 6225
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
