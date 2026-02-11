using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace lotus
{
	// Token: 0x02000072 RID: 114
	public class PoolableItem : MonoBehaviour
	{
		// Token: 0x0600069D RID: 1693 RVA: 0x0001F47C File Offset: 0x0001D67C
		// Note: this type is marked as 'beforefieldinit'.
		static PoolableItem()
		{
			Il2CppClassPointerStore<PoolableItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "PoolableItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoolableItem>.NativeClassPtr);
			PoolableItem.NativeFieldInfoPtr_OnSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolableItem>.NativeClassPtr, "OnSpawn");
			PoolableItem.NativeFieldInfoPtr_OnDespawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolableItem>.NativeClassPtr, "OnDespawn");
			PoolableItem.NativeFieldInfoPtr_children = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolableItem>.NativeClassPtr, "children");
			PoolableItem.NativeFieldInfoPtr_internalChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolableItem>.NativeClassPtr, "internalChildren");
			PoolableItem.NativeFieldInfoPtr_topLevelPoolable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolableItem>.NativeClassPtr, "topLevelPoolable");
			PoolableItem.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolableItem>.NativeClassPtr, "parent");
			PoolableItem.NativeFieldInfoPtr_prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolableItem>.NativeClassPtr, "prefab");
			PoolableItem.NativeFieldInfoPtr_manager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolableItem>.NativeClassPtr, "manager");
			PoolableItem.NativeFieldInfoPtr_node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolableItem>.NativeClassPtr, "node");
			PoolableItem.NativeFieldInfoPtr_logStr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolableItem>.NativeClassPtr, "logStr");
			PoolableItem.NativeMethodInfoPtr_get_Manager_Public_get_PoolManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableItem>.NativeClassPtr, 100664206);
			PoolableItem.NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableItem>.NativeClassPtr, 100664207);
			PoolableItem.NativeMethodInfoPtr_initializeInternalChildren_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableItem>.NativeClassPtr, 100664208);
			PoolableItem.NativeMethodInfoPtr_log_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableItem>.NativeClassPtr, 100664209);
			PoolableItem.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableItem>.NativeClassPtr, 100664210);
			PoolableItem.NativeMethodInfoPtr_Despawn_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableItem>.NativeClassPtr, 100664211);
			PoolableItem.NativeMethodInfoPtr_DespawnInternal_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableItem>.NativeClassPtr, 100664212);
			PoolableItem.NativeMethodInfoPtr_DespawnChildren_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableItem>.NativeClassPtr, 100664213);
			PoolableItem.NativeMethodInfoPtr_DespawnInternalChildren_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableItem>.NativeClassPtr, 100664214);
			PoolableItem.NativeMethodInfoPtr_SpawnMe_Public_Void_PoolableItem_PoolableItem_PoolManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableItem>.NativeClassPtr, 100664215);
			PoolableItem.NativeMethodInfoPtr_emitOnSpawn_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableItem>.NativeClassPtr, 100664216);
			PoolableItem.NativeMethodInfoPtr_AddChild_Public_Void_PoolableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableItem>.NativeClassPtr, 100664217);
			PoolableItem.NativeMethodInfoPtr_RemoveChild_Public_Void_PoolableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableItem>.NativeClassPtr, 100664218);
			PoolableItem.NativeMethodInfoPtr_IsSpawned_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableItem>.NativeClassPtr, 100664219);
			PoolableItem.NativeMethodInfoPtr_HasChildren_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableItem>.NativeClassPtr, 100664220);
			PoolableItem.NativeMethodInfoPtr_placedInScene_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableItem>.NativeClassPtr, 100664221);
			PoolableItem.NativeMethodInfoPtr_GetStatistics_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableItem>.NativeClassPtr, 100664222);
			PoolableItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableItem>.NativeClassPtr, 100664223);
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x0600069E RID: 1694 RVA: 0x0001F6DC File Offset: 0x0001D8DC
		public unsafe PoolManager Manager
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113234, XrefRangeEnd = 1113242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolableItem.NativeMethodInfoPtr_get_Manager_Public_get_PoolManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PoolManager>(intPtr3) : null;
			}
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x0001F71C File Offset: 0x0001D91C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113242, XrefRangeEnd = 1113244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolableItem.NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x0001F750 File Offset: 0x0001D950
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1113270, RefRangeEnd = 1113274, XrefRangeStart = 1113244, XrefRangeEnd = 1113270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void initializeInternalChildren()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolableItem.NativeMethodInfoPtr_initializeInternalChildren_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x0001F784 File Offset: 0x0001D984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113274, XrefRangeEnd = 1113277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void log(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolableItem.NativeMethodInfoPtr_log_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x0001F7C8 File Offset: 0x0001D9C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113277, XrefRangeEnd = 1113302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolableItem.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x0001F7FC File Offset: 0x0001D9FC
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 1113313, RefRangeEnd = 1113334, XrefRangeStart = 1113302, XrefRangeEnd = 1113313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Despawn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolableItem.NativeMethodInfoPtr_Despawn_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x0001F830 File Offset: 0x0001DA30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1113357, RefRangeEnd = 1113359, XrefRangeStart = 1113334, XrefRangeEnd = 1113357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DespawnInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolableItem.NativeMethodInfoPtr_DespawnInternal_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x0001F864 File Offset: 0x0001DA64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1113398, RefRangeEnd = 1113400, XrefRangeStart = 1113359, XrefRangeEnd = 1113398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DespawnChildren()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolableItem.NativeMethodInfoPtr_DespawnChildren_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x0001F898 File Offset: 0x0001DA98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1113405, RefRangeEnd = 1113406, XrefRangeStart = 1113400, XrefRangeEnd = 1113405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DespawnInternalChildren()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolableItem.NativeMethodInfoPtr_DespawnInternalChildren_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x0001F8CC File Offset: 0x0001DACC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1113434, RefRangeEnd = 1113435, XrefRangeStart = 1113406, XrefRangeEnd = 1113434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpawnMe(PoolableItem pfab, PoolableItem pp, PoolManager m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pfab);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pp);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolableItem.NativeMethodInfoPtr_SpawnMe_Public_Void_PoolableItem_PoolableItem_PoolManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x0001F934 File Offset: 0x0001DB34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1113454, RefRangeEnd = 1113456, XrefRangeStart = 1113435, XrefRangeEnd = 1113454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void emitOnSpawn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolableItem.NativeMethodInfoPtr_emitOnSpawn_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x0001F968 File Offset: 0x0001DB68
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1113468, RefRangeEnd = 1113471, XrefRangeStart = 1113456, XrefRangeEnd = 1113468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddChild(PoolableItem child)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolableItem.NativeMethodInfoPtr_AddChild_Public_Void_PoolableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x0001F9AC File Offset: 0x0001DBAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113471, XrefRangeEnd = 1113476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveChild(PoolableItem child)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolableItem.NativeMethodInfoPtr_RemoveChild_Public_Void_PoolableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x0001F9F0 File Offset: 0x0001DBF0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1113481, RefRangeEnd = 1113488, XrefRangeStart = 1113476, XrefRangeEnd = 1113481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSpawned()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolableItem.NativeMethodInfoPtr_IsSpawned_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x0001FA2C File Offset: 0x0001DC2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113488, XrefRangeEnd = 1113489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasChildren()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolableItem.NativeMethodInfoPtr_HasChildren_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x0001FA68 File Offset: 0x0001DC68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113489, XrefRangeEnd = 1113493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool placedInScene()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolableItem.NativeMethodInfoPtr_placedInScene_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x0001FAA4 File Offset: 0x0001DCA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113493, XrefRangeEnd = 1113538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetStatistics()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolableItem.NativeMethodInfoPtr_GetStatistics_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x0001FADC File Offset: 0x0001DCDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113538, XrefRangeEnd = 1113562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PoolableItem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoolableItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolableItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00005436 File Offset: 0x00003636
		public PoolableItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x0001FB18 File Offset: 0x0001DD18
		// (set) Token: 0x060006B2 RID: 1714 RVA: 0x0000543F File Offset: 0x0000363F
		public unsafe PoolableItem.PoolableItemEvent OnSpawn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableItem.NativeFieldInfoPtr_OnSpawn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoolableItem.PoolableItemEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableItem.NativeFieldInfoPtr_OnSpawn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x060006B3 RID: 1715 RVA: 0x0001FB48 File Offset: 0x0001DD48
		// (set) Token: 0x060006B4 RID: 1716 RVA: 0x0000545E File Offset: 0x0000365E
		public unsafe PoolableItem.PoolableItemEvent OnDespawn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableItem.NativeFieldInfoPtr_OnDespawn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoolableItem.PoolableItemEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableItem.NativeFieldInfoPtr_OnDespawn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060006B5 RID: 1717 RVA: 0x0001FB78 File Offset: 0x0001DD78
		// (set) Token: 0x060006B6 RID: 1718 RVA: 0x0000547D File Offset: 0x0000367D
		public unsafe HashSet<PoolableItem> children
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableItem.NativeFieldInfoPtr_children);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<PoolableItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableItem.NativeFieldInfoPtr_children), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060006B7 RID: 1719 RVA: 0x0001FBA8 File Offset: 0x0001DDA8
		// (set) Token: 0x060006B8 RID: 1720 RVA: 0x0000549C File Offset: 0x0000369C
		public unsafe List<PoolableItem> internalChildren
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableItem.NativeFieldInfoPtr_internalChildren);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PoolableItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableItem.NativeFieldInfoPtr_internalChildren), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060006B9 RID: 1721 RVA: 0x0001FBD8 File Offset: 0x0001DDD8
		// (set) Token: 0x060006BA RID: 1722 RVA: 0x000054BB File Offset: 0x000036BB
		public unsafe PoolableItem topLevelPoolable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableItem.NativeFieldInfoPtr_topLevelPoolable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoolableItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableItem.NativeFieldInfoPtr_topLevelPoolable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060006BB RID: 1723 RVA: 0x0001FC08 File Offset: 0x0001DE08
		// (set) Token: 0x060006BC RID: 1724 RVA: 0x000054DA File Offset: 0x000036DA
		public unsafe PoolableItem parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableItem.NativeFieldInfoPtr_parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoolableItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableItem.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060006BD RID: 1725 RVA: 0x0001FC38 File Offset: 0x0001DE38
		// (set) Token: 0x060006BE RID: 1726 RVA: 0x000054F9 File Offset: 0x000036F9
		public unsafe PoolableItem prefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableItem.NativeFieldInfoPtr_prefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoolableItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableItem.NativeFieldInfoPtr_prefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060006BF RID: 1727 RVA: 0x0001FC68 File Offset: 0x0001DE68
		// (set) Token: 0x060006C0 RID: 1728 RVA: 0x00005518 File Offset: 0x00003718
		public unsafe PoolManager manager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableItem.NativeFieldInfoPtr_manager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoolManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableItem.NativeFieldInfoPtr_manager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060006C1 RID: 1729 RVA: 0x0001FC98 File Offset: 0x0001DE98
		// (set) Token: 0x060006C2 RID: 1730 RVA: 0x00005537 File Offset: 0x00003737
		public unsafe LinkedListNode<PoolableItem> node
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableItem.NativeFieldInfoPtr_node);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedListNode<PoolableItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableItem.NativeFieldInfoPtr_node), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060006C3 RID: 1731 RVA: 0x0001FCC8 File Offset: 0x0001DEC8
		// (set) Token: 0x060006C4 RID: 1732 RVA: 0x00005556 File Offset: 0x00003756
		public unsafe string logStr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableItem.NativeFieldInfoPtr_logStr);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableItem.NativeFieldInfoPtr_logStr), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000421 RID: 1057
		private static readonly IntPtr NativeFieldInfoPtr_OnSpawn;

		// Token: 0x04000422 RID: 1058
		private static readonly IntPtr NativeFieldInfoPtr_OnDespawn;

		// Token: 0x04000423 RID: 1059
		private static readonly IntPtr NativeFieldInfoPtr_children;

		// Token: 0x04000424 RID: 1060
		private static readonly IntPtr NativeFieldInfoPtr_internalChildren;

		// Token: 0x04000425 RID: 1061
		private static readonly IntPtr NativeFieldInfoPtr_topLevelPoolable;

		// Token: 0x04000426 RID: 1062
		private static readonly IntPtr NativeFieldInfoPtr_parent;

		// Token: 0x04000427 RID: 1063
		private static readonly IntPtr NativeFieldInfoPtr_prefab;

		// Token: 0x04000428 RID: 1064
		private static readonly IntPtr NativeFieldInfoPtr_manager;

		// Token: 0x04000429 RID: 1065
		private static readonly IntPtr NativeFieldInfoPtr_node;

		// Token: 0x0400042A RID: 1066
		private static readonly IntPtr NativeFieldInfoPtr_logStr;

		// Token: 0x0400042B RID: 1067
		private static readonly IntPtr NativeMethodInfoPtr_get_Manager_Public_get_PoolManager_0;

		// Token: 0x0400042C RID: 1068
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

		// Token: 0x0400042D RID: 1069
		private static readonly IntPtr NativeMethodInfoPtr_initializeInternalChildren_Private_Void_0;

		// Token: 0x0400042E RID: 1070
		private static readonly IntPtr NativeMethodInfoPtr_log_Private_Void_String_0;

		// Token: 0x0400042F RID: 1071
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000430 RID: 1072
		private static readonly IntPtr NativeMethodInfoPtr_Despawn_Public_Void_0;

		// Token: 0x04000431 RID: 1073
		private static readonly IntPtr NativeMethodInfoPtr_DespawnInternal_Public_Void_0;

		// Token: 0x04000432 RID: 1074
		private static readonly IntPtr NativeMethodInfoPtr_DespawnChildren_Public_Void_0;

		// Token: 0x04000433 RID: 1075
		private static readonly IntPtr NativeMethodInfoPtr_DespawnInternalChildren_Public_Void_0;

		// Token: 0x04000434 RID: 1076
		private static readonly IntPtr NativeMethodInfoPtr_SpawnMe_Public_Void_PoolableItem_PoolableItem_PoolManager_0;

		// Token: 0x04000435 RID: 1077
		private static readonly IntPtr NativeMethodInfoPtr_emitOnSpawn_Private_Void_0;

		// Token: 0x04000436 RID: 1078
		private static readonly IntPtr NativeMethodInfoPtr_AddChild_Public_Void_PoolableItem_0;

		// Token: 0x04000437 RID: 1079
		private static readonly IntPtr NativeMethodInfoPtr_RemoveChild_Public_Void_PoolableItem_0;

		// Token: 0x04000438 RID: 1080
		private static readonly IntPtr NativeMethodInfoPtr_IsSpawned_Public_Boolean_0;

		// Token: 0x04000439 RID: 1081
		private static readonly IntPtr NativeMethodInfoPtr_HasChildren_Public_Boolean_0;

		// Token: 0x0400043A RID: 1082
		private static readonly IntPtr NativeMethodInfoPtr_placedInScene_Private_Boolean_0;

		// Token: 0x0400043B RID: 1083
		private static readonly IntPtr NativeMethodInfoPtr_GetStatistics_Public_String_0;

		// Token: 0x0400043C RID: 1084
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000F2 RID: 242
		public class PoolableItemEvent : UnityEvent<PoolableItem>
		{
			// Token: 0x06000C9D RID: 3229 RVA: 0x00008356 File Offset: 0x00006556
			// Note: this type is marked as 'beforefieldinit'.
			static PoolableItemEvent()
			{
				Il2CppClassPointerStore<PoolableItem.PoolableItemEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PoolableItem>.NativeClassPtr, "PoolableItemEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoolableItem.PoolableItemEvent>.NativeClassPtr);
				PoolableItem.PoolableItemEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableItem.PoolableItemEvent>.NativeClassPtr, 100664224);
			}

			// Token: 0x06000C9E RID: 3230 RVA: 0x00032454 File Offset: 0x00030654
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113231, XrefRangeEnd = 1113234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PoolableItemEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoolableItem.PoolableItemEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolableItem.PoolableItemEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C9F RID: 3231 RVA: 0x0000838A File Offset: 0x0000658A
			public PoolableItemEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040007D7 RID: 2007
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
