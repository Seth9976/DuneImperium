using System;
using boardgames.match.behaviours;
using Canis.gameLogs;
using Canis.utils.localization;
using coreactionlog.actionlog;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lib.canis.boardgames.src.match;
using lotus;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001CE RID: 462
	public class WormActionLogEntry : ActionLogEntry
	{
		// Token: 0x0600146B RID: 5227 RVA: 0x00056160 File Offset: 0x00054360
		// Note: this type is marked as 'beforefieldinit'.
		static WormActionLogEntry()
		{
			Il2CppClassPointerStore<WormActionLogEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormActionLogEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormActionLogEntry>.NativeClassPtr);
			WormActionLogEntry.NativeFieldInfoPtr_cardsView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormActionLogEntry>.NativeClassPtr, "cardsView");
			WormActionLogEntry.NativeFieldInfoPtr_leaderView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormActionLogEntry>.NativeClassPtr, "leaderView");
			WormActionLogEntry.NativeFieldInfoPtr_iconBacker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormActionLogEntry>.NativeClassPtr, "iconBacker");
			WormActionLogEntry.NativeFieldInfoPtr_icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormActionLogEntry>.NativeClassPtr, "icon");
			WormActionLogEntry.NativeFieldInfoPtr_defaultIconName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormActionLogEntry>.NativeClassPtr, "defaultIconName");
			WormActionLogEntry.NativeFieldInfoPtr_tempEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormActionLogEntry>.NativeClassPtr, "tempEntities");
			WormActionLogEntry.NativeFieldInfoPtr_archetypeProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormActionLogEntry>.NativeClassPtr, "archetypeProvider");
			WormActionLogEntry.NativeFieldInfoPtr_entitiesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormActionLogEntry>.NativeClassPtr, "entitiesProvider");
			WormActionLogEntry.NativeFieldInfoPtr_backerObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormActionLogEntry>.NativeClassPtr, "backerObjects");
			WormActionLogEntry.NativeFieldInfoPtr_cardNameBacker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormActionLogEntry>.NativeClassPtr, "cardNameBacker");
			WormActionLogEntry.NativeMethodInfoPtr_Init_Public_Virtual_Void_SerializedGameLog_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormActionLogEntry>.NativeClassPtr, 100666089);
			WormActionLogEntry.NativeMethodInfoPtr_ProcessLogText_Protected_Virtual_String_LocalizableTextVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormActionLogEntry>.NativeClassPtr, 100666090);
			WormActionLogEntry.NativeMethodInfoPtr_ShowCards_Private_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormActionLogEntry>.NativeClassPtr, 100666091);
			WormActionLogEntry.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormActionLogEntry>.NativeClassPtr, 100666092);
			WormActionLogEntry.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormActionLogEntry>.NativeClassPtr, 100666093);
			WormActionLogEntry.NativeMethodInfoPtr_populateUsernameBackers_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormActionLogEntry>.NativeClassPtr, 100666094);
			WormActionLogEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormActionLogEntry>.NativeClassPtr, 100666095);
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x000562E4 File Offset: 0x000544E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714062, XrefRangeEnd = 714137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init(SerializedGameLog gameLog, int logIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameLog);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref logIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormActionLogEntry.NativeMethodInfoPtr_Init_Public_Virtual_Void_SerializedGameLog_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x00056340 File Offset: 0x00054540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714137, XrefRangeEnd = 714138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ProcessLogText(LocalizableTextVariables logText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(logText);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormActionLogEntry.NativeMethodInfoPtr_ProcessLogText_Protected_Virtual_String_LocalizableTextVariables_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x00056394 File Offset: 0x00054594
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 714204, RefRangeEnd = 714205, XrefRangeStart = 714138, XrefRangeEnd = 714204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityComponent ShowCards()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormActionLogEntry.NativeMethodInfoPtr_ShowCards_Private_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
		}

		// Token: 0x0600146F RID: 5231 RVA: 0x000563D4 File Offset: 0x000545D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714205, XrefRangeEnd = 714231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormActionLogEntry.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x00056408 File Offset: 0x00054608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714231, XrefRangeEnd = 714268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormActionLogEntry.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x0005643C File Offset: 0x0005463C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714268, XrefRangeEnd = 714273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator populateUsernameBackers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormActionLogEntry.NativeMethodInfoPtr_populateUsernameBackers_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x0005647C File Offset: 0x0005467C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714273, XrefRangeEnd = 714291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormActionLogEntry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormActionLogEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormActionLogEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x0000C84E File Offset: 0x0000AA4E
		public WormActionLogEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06001474 RID: 5236 RVA: 0x000564B8 File Offset: 0x000546B8
		// (set) Token: 0x06001475 RID: 5237 RVA: 0x0000C857 File Offset: 0x0000AA57
		public unsafe ContainerView cardsView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLogEntry.NativeFieldInfoPtr_cardsView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLogEntry.NativeFieldInfoPtr_cardsView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06001476 RID: 5238 RVA: 0x000564E8 File Offset: 0x000546E8
		// (set) Token: 0x06001477 RID: 5239 RVA: 0x0000C876 File Offset: 0x0000AA76
		public unsafe EntityView leaderView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLogEntry.NativeFieldInfoPtr_leaderView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLogEntry.NativeFieldInfoPtr_leaderView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06001478 RID: 5240 RVA: 0x00056518 File Offset: 0x00054718
		// (set) Token: 0x06001479 RID: 5241 RVA: 0x0000C895 File Offset: 0x0000AA95
		public unsafe GameObject iconBacker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLogEntry.NativeFieldInfoPtr_iconBacker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLogEntry.NativeFieldInfoPtr_iconBacker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x0600147A RID: 5242 RVA: 0x00056548 File Offset: 0x00054748
		// (set) Token: 0x0600147B RID: 5243 RVA: 0x0000C8B4 File Offset: 0x0000AAB4
		public unsafe GameObject icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLogEntry.NativeFieldInfoPtr_icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLogEntry.NativeFieldInfoPtr_icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x0600147C RID: 5244 RVA: 0x00056578 File Offset: 0x00054778
		// (set) Token: 0x0600147D RID: 5245 RVA: 0x0000C8D3 File Offset: 0x0000AAD3
		public unsafe string defaultIconName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLogEntry.NativeFieldInfoPtr_defaultIconName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLogEntry.NativeFieldInfoPtr_defaultIconName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x0600147E RID: 5246 RVA: 0x000565A0 File Offset: 0x000547A0
		// (set) Token: 0x0600147F RID: 5247 RVA: 0x0000C8F2 File Offset: 0x0000AAF2
		public unsafe List<EntityComponent> tempEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLogEntry.NativeFieldInfoPtr_tempEntities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLogEntry.NativeFieldInfoPtr_tempEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06001480 RID: 5248 RVA: 0x000565D0 File Offset: 0x000547D0
		// (set) Token: 0x06001481 RID: 5249 RVA: 0x0000C911 File Offset: 0x0000AB11
		public unsafe ArchetypeProvider archetypeProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLogEntry.NativeFieldInfoPtr_archetypeProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLogEntry.NativeFieldInfoPtr_archetypeProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06001482 RID: 5250 RVA: 0x00056600 File Offset: 0x00054800
		// (set) Token: 0x06001483 RID: 5251 RVA: 0x0000C930 File Offset: 0x0000AB30
		public unsafe DBGEntitiesProvider entitiesProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLogEntry.NativeFieldInfoPtr_entitiesProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLogEntry.NativeFieldInfoPtr_entitiesProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06001484 RID: 5252 RVA: 0x00056630 File Offset: 0x00054830
		// (set) Token: 0x06001485 RID: 5253 RVA: 0x0000C94F File Offset: 0x0000AB4F
		public unsafe List<GameObject> backerObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLogEntry.NativeFieldInfoPtr_backerObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLogEntry.NativeFieldInfoPtr_backerObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06001486 RID: 5254 RVA: 0x00056660 File Offset: 0x00054860
		// (set) Token: 0x06001487 RID: 5255 RVA: 0x0000C96E File Offset: 0x0000AB6E
		public unsafe GameObject cardNameBacker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLogEntry.NativeFieldInfoPtr_cardNameBacker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLogEntry.NativeFieldInfoPtr_cardNameBacker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BD5 RID: 3029
		private static readonly IntPtr NativeFieldInfoPtr_cardsView;

		// Token: 0x04000BD6 RID: 3030
		private static readonly IntPtr NativeFieldInfoPtr_leaderView;

		// Token: 0x04000BD7 RID: 3031
		private static readonly IntPtr NativeFieldInfoPtr_iconBacker;

		// Token: 0x04000BD8 RID: 3032
		private static readonly IntPtr NativeFieldInfoPtr_icon;

		// Token: 0x04000BD9 RID: 3033
		private static readonly IntPtr NativeFieldInfoPtr_defaultIconName;

		// Token: 0x04000BDA RID: 3034
		private static readonly IntPtr NativeFieldInfoPtr_tempEntities;

		// Token: 0x04000BDB RID: 3035
		private static readonly IntPtr NativeFieldInfoPtr_archetypeProvider;

		// Token: 0x04000BDC RID: 3036
		private static readonly IntPtr NativeFieldInfoPtr_entitiesProvider;

		// Token: 0x04000BDD RID: 3037
		private static readonly IntPtr NativeFieldInfoPtr_backerObjects;

		// Token: 0x04000BDE RID: 3038
		private static readonly IntPtr NativeFieldInfoPtr_cardNameBacker;

		// Token: 0x04000BDF RID: 3039
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_SerializedGameLog_Int32_0;

		// Token: 0x04000BE0 RID: 3040
		private static readonly IntPtr NativeMethodInfoPtr_ProcessLogText_Protected_Virtual_String_LocalizableTextVariables_0;

		// Token: 0x04000BE1 RID: 3041
		private static readonly IntPtr NativeMethodInfoPtr_ShowCards_Private_EntityComponent_0;

		// Token: 0x04000BE2 RID: 3042
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000BE3 RID: 3043
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000BE4 RID: 3044
		private static readonly IntPtr NativeMethodInfoPtr_populateUsernameBackers_Private_IEnumerator_0;

		// Token: 0x04000BE5 RID: 3045
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003D2 RID: 978
		[ObfuscatedName("worm.match.components.WormActionLogEntry+<populateUsernameBackers>d__15")]
		public sealed class _populateUsernameBackers_d__15 : global::Il2CppSystem.Object
		{
			// Token: 0x060027AB RID: 10155 RVA: 0x00090748 File Offset: 0x0008E948
			// Note: this type is marked as 'beforefieldinit'.
			static _populateUsernameBackers_d__15()
			{
				Il2CppClassPointerStore<WormActionLogEntry._populateUsernameBackers_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormActionLogEntry>.NativeClassPtr, "<populateUsernameBackers>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormActionLogEntry._populateUsernameBackers_d__15>.NativeClassPtr);
				WormActionLogEntry._populateUsernameBackers_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormActionLogEntry._populateUsernameBackers_d__15>.NativeClassPtr, "<>1__state");
				WormActionLogEntry._populateUsernameBackers_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormActionLogEntry._populateUsernameBackers_d__15>.NativeClassPtr, "<>2__current");
				WormActionLogEntry._populateUsernameBackers_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormActionLogEntry._populateUsernameBackers_d__15>.NativeClassPtr, "<>4__this");
				WormActionLogEntry._populateUsernameBackers_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormActionLogEntry._populateUsernameBackers_d__15>.NativeClassPtr, 100666096);
				WormActionLogEntry._populateUsernameBackers_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormActionLogEntry._populateUsernameBackers_d__15>.NativeClassPtr, 100666097);
				WormActionLogEntry._populateUsernameBackers_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormActionLogEntry._populateUsernameBackers_d__15>.NativeClassPtr, 100666098);
				WormActionLogEntry._populateUsernameBackers_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormActionLogEntry._populateUsernameBackers_d__15>.NativeClassPtr, 100666099);
				WormActionLogEntry._populateUsernameBackers_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormActionLogEntry._populateUsernameBackers_d__15>.NativeClassPtr, 100666100);
				WormActionLogEntry._populateUsernameBackers_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormActionLogEntry._populateUsernameBackers_d__15>.NativeClassPtr, 100666101);
			}

			// Token: 0x060027AC RID: 10156 RVA: 0x00090828 File Offset: 0x0008EA28
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _populateUsernameBackers_d__15(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormActionLogEntry._populateUsernameBackers_d__15>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormActionLogEntry._populateUsernameBackers_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060027AD RID: 10157 RVA: 0x00090870 File Offset: 0x0008EA70
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormActionLogEntry._populateUsernameBackers_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060027AE RID: 10158 RVA: 0x000908A4 File Offset: 0x0008EAA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713970, XrefRangeEnd = 714057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormActionLogEntry._populateUsernameBackers_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B17 RID: 2839
			// (get) Token: 0x060027AF RID: 10159 RVA: 0x000908E0 File Offset: 0x0008EAE0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormActionLogEntry._populateUsernameBackers_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060027B0 RID: 10160 RVA: 0x00090920 File Offset: 0x0008EB20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714057, XrefRangeEnd = 714062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormActionLogEntry._populateUsernameBackers_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B18 RID: 2840
			// (get) Token: 0x060027B1 RID: 10161 RVA: 0x00090954 File Offset: 0x0008EB54
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormActionLogEntry._populateUsernameBackers_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060027B2 RID: 10162 RVA: 0x00015CC5 File Offset: 0x00013EC5
			public _populateUsernameBackers_d__15(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B14 RID: 2836
			// (get) Token: 0x060027B3 RID: 10163 RVA: 0x00090994 File Offset: 0x0008EB94
			// (set) Token: 0x060027B4 RID: 10164 RVA: 0x00015CCE File Offset: 0x00013ECE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLogEntry._populateUsernameBackers_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLogEntry._populateUsernameBackers_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B15 RID: 2837
			// (get) Token: 0x060027B5 RID: 10165 RVA: 0x000909BC File Offset: 0x0008EBBC
			// (set) Token: 0x060027B6 RID: 10166 RVA: 0x00015CE9 File Offset: 0x00013EE9
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLogEntry._populateUsernameBackers_d__15.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLogEntry._populateUsernameBackers_d__15.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B16 RID: 2838
			// (get) Token: 0x060027B7 RID: 10167 RVA: 0x000909EC File Offset: 0x0008EBEC
			// (set) Token: 0x060027B8 RID: 10168 RVA: 0x00015D08 File Offset: 0x00013F08
			public unsafe WormActionLogEntry __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLogEntry._populateUsernameBackers_d__15.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActionLogEntry>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLogEntry._populateUsernameBackers_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016DA RID: 5850
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040016DB RID: 5851
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040016DC RID: 5852
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040016DD RID: 5853
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040016DE RID: 5854
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016DF RID: 5855
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040016E0 RID: 5856
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040016E1 RID: 5857
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016E2 RID: 5858
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
