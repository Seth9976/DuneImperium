using System;
using dwd.core.pooling;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace lotus
{
	// Token: 0x02000074 RID: 116
	public class PoolManager : MonoBehaviour
	{
		// Token: 0x060006D0 RID: 1744 RVA: 0x0001FEE8 File Offset: 0x0001E0E8
		// Note: this type is marked as 'beforefieldinit'.
		static PoolManager()
		{
			Il2CppClassPointerStore<PoolManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "PoolManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoolManager>.NativeClassPtr);
			PoolManager.NativeFieldInfoPtr_defaults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolManager>.NativeClassPtr, "defaults");
			PoolManager.NativeFieldInfoPtr_PoolDefinitions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolManager>.NativeClassPtr, "PoolDefinitions");
			PoolManager.NativeFieldInfoPtr_PlatformPoolDefinitions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolManager>.NativeClassPtr, "PlatformPoolDefinitions");
			PoolManager.NativeFieldInfoPtr_definitionsMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolManager>.NativeClassPtr, "definitionsMap");
			PoolManager.NativeFieldInfoPtr_poolGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolManager>.NativeClassPtr, "poolGroup");
			PoolManager.NativeFieldInfoPtr_spawnedItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolManager>.NativeClassPtr, "spawnedItems");
			PoolManager.NativeFieldInfoPtr_positions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolManager>.NativeClassPtr, "positions");
			PoolManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolManager>.NativeClassPtr, 100664228);
			PoolManager.NativeMethodInfoPtr_initPoolable_Private_Void_PoolableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolManager>.NativeClassPtr, 100664229);
			PoolManager.NativeMethodInfoPtr_getPosition_Private_UnitPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolManager>.NativeClassPtr, 100664230);
			PoolManager.NativeMethodInfoPtr_resetPosition_Private_Void_UnitPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolManager>.NativeClassPtr, 100664231);
			PoolManager.NativeMethodInfoPtr_GetDefinition_Public_PoolDefinition_PoolableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolManager>.NativeClassPtr, 100664232);
			PoolManager.NativeMethodInfoPtr_AddDefinitionFor_Public_Void_PoolableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolManager>.NativeClassPtr, 100664233);
			PoolManager.NativeMethodInfoPtr_ValidateDataIntegrity_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolManager>.NativeClassPtr, 100664234);
			PoolManager.NativeMethodInfoPtr_generateDefinitionsMap_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolManager>.NativeClassPtr, 100664235);
			PoolManager.NativeMethodInfoPtr_Spawn_Public_T_PoolableItem_PoolableItem_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolManager>.NativeClassPtr, 100664236);
			PoolManager.NativeMethodInfoPtr_Spawn_Public_T_T_PoolableItem_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolManager>.NativeClassPtr, 100664237);
			PoolManager.NativeMethodInfoPtr_Despawn_Public_Void_PoolableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolManager>.NativeClassPtr, 100664238);
			PoolManager.NativeMethodInfoPtr_DespawnAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolManager>.NativeClassPtr, 100664239);
			PoolManager.NativeMethodInfoPtr_DespawnOverTime_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolManager>.NativeClassPtr, 100664240);
			PoolManager.NativeMethodInfoPtr_GetStatistics_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolManager>.NativeClassPtr, 100664241);
			PoolManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolManager>.NativeClassPtr, 100664242);
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x000200D0 File Offset: 0x0001E2D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113620, XrefRangeEnd = 1113712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x00020104 File Offset: 0x0001E304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113712, XrefRangeEnd = 1113715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void initPoolable(PoolableItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolManager.NativeMethodInfoPtr_initPoolable_Private_Void_PoolableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x00020148 File Offset: 0x0001E348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113715, XrefRangeEnd = 1113719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnitPosition getPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolManager.NativeMethodInfoPtr_getPosition_Private_UnitPosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnitPosition>(intPtr3) : null;
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x00020188 File Offset: 0x0001E388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113719, XrefRangeEnd = 1113725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void resetPosition(UnitPosition up)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(up);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolManager.NativeMethodInfoPtr_resetPosition_Private_Void_UnitPosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x000201CC File Offset: 0x0001E3CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113725, XrefRangeEnd = 1113732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PoolDefinition GetDefinition(PoolableItem pi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pi);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolManager.NativeMethodInfoPtr_GetDefinition_Public_PoolDefinition_PoolableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PoolDefinition>(intPtr3) : null;
			}
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x0002021C File Offset: 0x0001E41C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113732, XrefRangeEnd = 1113763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDefinitionFor(PoolableItem pi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pi);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolManager.NativeMethodInfoPtr_AddDefinitionFor_Public_Void_PoolableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x00020260 File Offset: 0x0001E460
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1113816, RefRangeEnd = 1113817, XrefRangeStart = 1113763, XrefRangeEnd = 1113816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateDataIntegrity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolManager.NativeMethodInfoPtr_ValidateDataIntegrity_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x00020294 File Offset: 0x0001E494
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1113851, RefRangeEnd = 1113854, XrefRangeStart = 1113817, XrefRangeEnd = 1113851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void generateDefinitionsMap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolManager.NativeMethodInfoPtr_generateDefinitionsMap_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x000202C8 File Offset: 0x0001E4C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1113879, RefRangeEnd = 1113880, XrefRangeStart = 1113854, XrefRangeEnd = 1113879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T Spawn<T>(PoolableItem prefab, PoolableItem poolParent, Transform parent) where T : Component
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(poolParent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolManager.MethodInfoStoreGeneric_Spawn_Public_T_PoolableItem_PoolableItem_Transform_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00020338 File Offset: 0x0001E538
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1113895, RefRangeEnd = 1113903, XrefRangeStart = 1113880, XrefRangeEnd = 1113895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T Spawn<T>(T prefab, PoolableItem poolParent, Transform parent) where T : Component
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = prefab;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref prefab;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(poolParent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PoolManager.MethodInfoStoreGeneric_Spawn_Public_T_T_PoolableItem_Transform_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x000203DC File Offset: 0x0001E5DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1113910, RefRangeEnd = 1113911, XrefRangeStart = 1113903, XrefRangeEnd = 1113910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Despawn(PoolableItem instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolManager.NativeMethodInfoPtr_Despawn_Public_Void_PoolableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00020420 File Offset: 0x0001E620
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1113939, RefRangeEnd = 1113940, XrefRangeStart = 1113911, XrefRangeEnd = 1113939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DespawnAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolManager.NativeMethodInfoPtr_DespawnAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x00020454 File Offset: 0x0001E654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113940, XrefRangeEnd = 1113945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DespawnOverTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolManager.NativeMethodInfoPtr_DespawnOverTime_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x00020494 File Offset: 0x0001E694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113945, XrefRangeEnd = 1113956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetStatistics()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolManager.NativeMethodInfoPtr_GetStatistics_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x000204CC File Offset: 0x0001E6CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113956, XrefRangeEnd = 1113971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PoolManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoolManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x000055D3 File Offset: 0x000037D3
		public PoolManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060006E1 RID: 1761 RVA: 0x00020508 File Offset: 0x0001E708
		// (set) Token: 0x060006E2 RID: 1762 RVA: 0x000055DC File Offset: 0x000037DC
		public unsafe PoolDefinition defaults
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolManager.NativeFieldInfoPtr_defaults);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoolDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolManager.NativeFieldInfoPtr_defaults), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060006E3 RID: 1763 RVA: 0x00020538 File Offset: 0x0001E738
		// (set) Token: 0x060006E4 RID: 1764 RVA: 0x000055FB File Offset: 0x000037FB
		public unsafe List<PoolDefinition> PoolDefinitions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolManager.NativeFieldInfoPtr_PoolDefinitions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PoolDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolManager.NativeFieldInfoPtr_PoolDefinitions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060006E5 RID: 1765 RVA: 0x00020568 File Offset: 0x0001E768
		// (set) Token: 0x060006E6 RID: 1766 RVA: 0x0000561A File Offset: 0x0000381A
		public unsafe List<PoolManager.PlatformPoolDefinition> PlatformPoolDefinitions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolManager.NativeFieldInfoPtr_PlatformPoolDefinitions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PoolManager.PlatformPoolDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolManager.NativeFieldInfoPtr_PlatformPoolDefinitions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060006E7 RID: 1767 RVA: 0x00020598 File Offset: 0x0001E798
		// (set) Token: 0x060006E8 RID: 1768 RVA: 0x00005639 File Offset: 0x00003839
		public unsafe Dictionary<PoolableItem, PoolDefinition> definitionsMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolManager.NativeFieldInfoPtr_definitionsMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<PoolableItem, PoolDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolManager.NativeFieldInfoPtr_definitionsMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060006E9 RID: 1769 RVA: 0x000205C8 File Offset: 0x0001E7C8
		// (set) Token: 0x060006EA RID: 1770 RVA: 0x00005658 File Offset: 0x00003858
		public unsafe PrefabPoolGroup<PoolableItem> poolGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolManager.NativeFieldInfoPtr_poolGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefabPoolGroup<PoolableItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolManager.NativeFieldInfoPtr_poolGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x060006EB RID: 1771 RVA: 0x000205F8 File Offset: 0x0001E7F8
		// (set) Token: 0x060006EC RID: 1772 RVA: 0x00005677 File Offset: 0x00003877
		public unsafe LinkedList<PoolableItem> spawnedItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolManager.NativeFieldInfoPtr_spawnedItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedList<PoolableItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolManager.NativeFieldInfoPtr_spawnedItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x060006ED RID: 1773 RVA: 0x00020628 File Offset: 0x0001E828
		// (set) Token: 0x060006EE RID: 1774 RVA: 0x00005696 File Offset: 0x00003896
		public unsafe Pool<UnitPosition> positions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolManager.NativeFieldInfoPtr_positions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pool<UnitPosition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolManager.NativeFieldInfoPtr_positions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000443 RID: 1091
		private static readonly IntPtr NativeFieldInfoPtr_defaults;

		// Token: 0x04000444 RID: 1092
		private static readonly IntPtr NativeFieldInfoPtr_PoolDefinitions;

		// Token: 0x04000445 RID: 1093
		private static readonly IntPtr NativeFieldInfoPtr_PlatformPoolDefinitions;

		// Token: 0x04000446 RID: 1094
		private static readonly IntPtr NativeFieldInfoPtr_definitionsMap;

		// Token: 0x04000447 RID: 1095
		private static readonly IntPtr NativeFieldInfoPtr_poolGroup;

		// Token: 0x04000448 RID: 1096
		private static readonly IntPtr NativeFieldInfoPtr_spawnedItems;

		// Token: 0x04000449 RID: 1097
		private static readonly IntPtr NativeFieldInfoPtr_positions;

		// Token: 0x0400044A RID: 1098
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400044B RID: 1099
		private static readonly IntPtr NativeMethodInfoPtr_initPoolable_Private_Void_PoolableItem_0;

		// Token: 0x0400044C RID: 1100
		private static readonly IntPtr NativeMethodInfoPtr_getPosition_Private_UnitPosition_0;

		// Token: 0x0400044D RID: 1101
		private static readonly IntPtr NativeMethodInfoPtr_resetPosition_Private_Void_UnitPosition_0;

		// Token: 0x0400044E RID: 1102
		private static readonly IntPtr NativeMethodInfoPtr_GetDefinition_Public_PoolDefinition_PoolableItem_0;

		// Token: 0x0400044F RID: 1103
		private static readonly IntPtr NativeMethodInfoPtr_AddDefinitionFor_Public_Void_PoolableItem_0;

		// Token: 0x04000450 RID: 1104
		private static readonly IntPtr NativeMethodInfoPtr_ValidateDataIntegrity_Public_Void_0;

		// Token: 0x04000451 RID: 1105
		private static readonly IntPtr NativeMethodInfoPtr_generateDefinitionsMap_Public_Void_0;

		// Token: 0x04000452 RID: 1106
		private static readonly IntPtr NativeMethodInfoPtr_Spawn_Public_T_PoolableItem_PoolableItem_Transform_0;

		// Token: 0x04000453 RID: 1107
		private static readonly IntPtr NativeMethodInfoPtr_Spawn_Public_T_T_PoolableItem_Transform_0;

		// Token: 0x04000454 RID: 1108
		private static readonly IntPtr NativeMethodInfoPtr_Despawn_Public_Void_PoolableItem_0;

		// Token: 0x04000455 RID: 1109
		private static readonly IntPtr NativeMethodInfoPtr_DespawnAll_Public_Void_0;

		// Token: 0x04000456 RID: 1110
		private static readonly IntPtr NativeMethodInfoPtr_DespawnOverTime_Public_IEnumerator_0;

		// Token: 0x04000457 RID: 1111
		private static readonly IntPtr NativeMethodInfoPtr_GetStatistics_Public_String_0;

		// Token: 0x04000458 RID: 1112
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000F3 RID: 243
		public enum Platform
		{
			// Token: 0x040007D9 RID: 2009
			Tablet = 1,
			// Token: 0x040007DA RID: 2010
			Phone,
			// Token: 0x040007DB RID: 2011
			Desktop,
			// Token: 0x040007DC RID: 2012
			Switch,
			// Token: 0x040007DD RID: 2013
			Gameboard
		}

		// Token: 0x020000F4 RID: 244
		[Serializable]
		public sealed class PlatformPoolDefinition : ValueType
		{
			// Token: 0x06000CA0 RID: 3232 RVA: 0x00032490 File Offset: 0x00030690
			// Note: this type is marked as 'beforefieldinit'.
			static PlatformPoolDefinition()
			{
				Il2CppClassPointerStore<PoolManager.PlatformPoolDefinition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PoolManager>.NativeClassPtr, "PlatformPoolDefinition");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoolManager.PlatformPoolDefinition>.NativeClassPtr);
				PoolManager.PlatformPoolDefinition.NativeFieldInfoPtr_platform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolManager.PlatformPoolDefinition>.NativeClassPtr, "platform");
				PoolManager.PlatformPoolDefinition.NativeFieldInfoPtr_poolDefinitions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolManager.PlatformPoolDefinition>.NativeClassPtr, "poolDefinitions");
			}

			// Token: 0x06000CA1 RID: 3233 RVA: 0x00008393 File Offset: 0x00006593
			public PlatformPoolDefinition(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000CA2 RID: 3234 RVA: 0x0000839C File Offset: 0x0000659C
			public PlatformPoolDefinition()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoolManager.PlatformPoolDefinition>.NativeClassPtr))
			{
			}

			// Token: 0x170003BA RID: 954
			// (get) Token: 0x06000CA3 RID: 3235 RVA: 0x000324E4 File Offset: 0x000306E4
			// (set) Token: 0x06000CA4 RID: 3236 RVA: 0x000083AE File Offset: 0x000065AE
			public unsafe PoolManager.Platform platform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolManager.PlatformPoolDefinition.NativeFieldInfoPtr_platform);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolManager.PlatformPoolDefinition.NativeFieldInfoPtr_platform)) = value;
				}
			}

			// Token: 0x170003BB RID: 955
			// (get) Token: 0x06000CA5 RID: 3237 RVA: 0x0003250C File Offset: 0x0003070C
			// (set) Token: 0x06000CA6 RID: 3238 RVA: 0x000083C9 File Offset: 0x000065C9
			public unsafe List<PoolDefinition> poolDefinitions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolManager.PlatformPoolDefinition.NativeFieldInfoPtr_poolDefinitions);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PoolDefinition>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolManager.PlatformPoolDefinition.NativeFieldInfoPtr_poolDefinitions), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040007DE RID: 2014
			private static readonly IntPtr NativeFieldInfoPtr_platform;

			// Token: 0x040007DF RID: 2015
			private static readonly IntPtr NativeFieldInfoPtr_poolDefinitions;
		}

		// Token: 0x020000F5 RID: 245
		[ObfuscatedName("lotus.PoolManager+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06000CA7 RID: 3239 RVA: 0x0003253C File Offset: 0x0003073C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PoolManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PoolManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoolManager.__c>.NativeClassPtr);
				PoolManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolManager.__c>.NativeClassPtr, "<>9");
				PoolManager.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolManager.__c>.NativeClassPtr, "<>9__9_0");
				PoolManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolManager.__c>.NativeClassPtr, 100664244);
				PoolManager.__c.NativeMethodInfoPtr__Start_b__9_0_Internal_Boolean_PlatformPoolDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolManager.__c>.NativeClassPtr, 100664245);
			}

			// Token: 0x06000CA8 RID: 3240 RVA: 0x000325B8 File Offset: 0x000307B8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoolManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CA9 RID: 3241 RVA: 0x000325F4 File Offset: 0x000307F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113574, XrefRangeEnd = 1113575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Start_b__9_0(PoolManager.PlatformPoolDefinition p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(p));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolManager.__c.NativeMethodInfoPtr__Start_b__9_0_Internal_Boolean_PlatformPoolDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000CAA RID: 3242 RVA: 0x000083E8 File Offset: 0x000065E8
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003BC RID: 956
			// (get) Token: 0x06000CAB RID: 3243 RVA: 0x00032648 File Offset: 0x00030848
			// (set) Token: 0x06000CAC RID: 3244 RVA: 0x000083F1 File Offset: 0x000065F1
			public unsafe static PoolManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PoolManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoolManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PoolManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003BD RID: 957
			// (get) Token: 0x06000CAD RID: 3245 RVA: 0x00032670 File Offset: 0x00030870
			// (set) Token: 0x06000CAE RID: 3246 RVA: 0x00008403 File Offset: 0x00006603
			public unsafe static Func<PoolManager.PlatformPoolDefinition, bool> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PoolManager.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PoolManager.PlatformPoolDefinition, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PoolManager.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040007E0 RID: 2016
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040007E1 RID: 2017
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x040007E2 RID: 2018
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040007E3 RID: 2019
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__9_0_Internal_Boolean_PlatformPoolDefinition_0;
		}

		// Token: 0x020000F6 RID: 246
		[ObfuscatedName("lotus.PoolManager+<DespawnOverTime>d__21")]
		public sealed class _DespawnOverTime_d__21 : global::Il2CppSystem.Object
		{
			// Token: 0x06000CAF RID: 3247 RVA: 0x00032698 File Offset: 0x00030898
			// Note: this type is marked as 'beforefieldinit'.
			static _DespawnOverTime_d__21()
			{
				Il2CppClassPointerStore<PoolManager._DespawnOverTime_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PoolManager>.NativeClassPtr, "<DespawnOverTime>d__21");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoolManager._DespawnOverTime_d__21>.NativeClassPtr);
				PoolManager._DespawnOverTime_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolManager._DespawnOverTime_d__21>.NativeClassPtr, "<>1__state");
				PoolManager._DespawnOverTime_d__21.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolManager._DespawnOverTime_d__21>.NativeClassPtr, "<>2__current");
				PoolManager._DespawnOverTime_d__21.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolManager._DespawnOverTime_d__21>.NativeClassPtr, "<>4__this");
				PoolManager._DespawnOverTime_d__21.NativeFieldInfoPtr__despawnParents_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolManager._DespawnOverTime_d__21>.NativeClassPtr, "<despawnParents>5__2");
				PoolManager._DespawnOverTime_d__21.NativeFieldInfoPtr__batchSize_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolManager._DespawnOverTime_d__21>.NativeClassPtr, "<batchSize>5__3");
				PoolManager._DespawnOverTime_d__21.NativeFieldInfoPtr__batchCount_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolManager._DespawnOverTime_d__21>.NativeClassPtr, "<batchCount>5__4");
				PoolManager._DespawnOverTime_d__21.NativeFieldInfoPtr___7__wrap4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolManager._DespawnOverTime_d__21>.NativeClassPtr, "<>7__wrap4");
				PoolManager._DespawnOverTime_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolManager._DespawnOverTime_d__21>.NativeClassPtr, 100664246);
				PoolManager._DespawnOverTime_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolManager._DespawnOverTime_d__21>.NativeClassPtr, 100664247);
				PoolManager._DespawnOverTime_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolManager._DespawnOverTime_d__21>.NativeClassPtr, 100664248);
				PoolManager._DespawnOverTime_d__21.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolManager._DespawnOverTime_d__21>.NativeClassPtr, 100664249);
				PoolManager._DespawnOverTime_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolManager._DespawnOverTime_d__21>.NativeClassPtr, 100664250);
				PoolManager._DespawnOverTime_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolManager._DespawnOverTime_d__21>.NativeClassPtr, 100664251);
				PoolManager._DespawnOverTime_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolManager._DespawnOverTime_d__21>.NativeClassPtr, 100664252);
			}

			// Token: 0x06000CB0 RID: 3248 RVA: 0x000327DC File Offset: 0x000309DC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DespawnOverTime_d__21(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoolManager._DespawnOverTime_d__21>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolManager._DespawnOverTime_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000CB1 RID: 3249 RVA: 0x00032824 File Offset: 0x00030A24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113575, XrefRangeEnd = 1113580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolManager._DespawnOverTime_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CB2 RID: 3250 RVA: 0x00032858 File Offset: 0x00030A58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113580, XrefRangeEnd = 1113612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolManager._DespawnOverTime_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000CB3 RID: 3251 RVA: 0x00032894 File Offset: 0x00030A94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113612, XrefRangeEnd = 1113615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolManager._DespawnOverTime_d__21.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170003C5 RID: 965
			// (get) Token: 0x06000CB4 RID: 3252 RVA: 0x000328C8 File Offset: 0x00030AC8
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolManager._DespawnOverTime_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000CB5 RID: 3253 RVA: 0x00032908 File Offset: 0x00030B08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113615, XrefRangeEnd = 1113620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolManager._DespawnOverTime_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170003C6 RID: 966
			// (get) Token: 0x06000CB6 RID: 3254 RVA: 0x0003293C File Offset: 0x00030B3C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolManager._DespawnOverTime_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000CB7 RID: 3255 RVA: 0x00008415 File Offset: 0x00006615
			public _DespawnOverTime_d__21(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003BE RID: 958
			// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x0003297C File Offset: 0x00030B7C
			// (set) Token: 0x06000CB9 RID: 3257 RVA: 0x0000841E File Offset: 0x0000661E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolManager._DespawnOverTime_d__21.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolManager._DespawnOverTime_d__21.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170003BF RID: 959
			// (get) Token: 0x06000CBA RID: 3258 RVA: 0x000329A4 File Offset: 0x00030BA4
			// (set) Token: 0x06000CBB RID: 3259 RVA: 0x00008439 File Offset: 0x00006639
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolManager._DespawnOverTime_d__21.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolManager._DespawnOverTime_d__21.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003C0 RID: 960
			// (get) Token: 0x06000CBC RID: 3260 RVA: 0x000329D4 File Offset: 0x00030BD4
			// (set) Token: 0x06000CBD RID: 3261 RVA: 0x00008458 File Offset: 0x00006658
			public unsafe PoolManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolManager._DespawnOverTime_d__21.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoolManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolManager._DespawnOverTime_d__21.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003C1 RID: 961
			// (get) Token: 0x06000CBE RID: 3262 RVA: 0x00032A04 File Offset: 0x00030C04
			// (set) Token: 0x06000CBF RID: 3263 RVA: 0x00008477 File Offset: 0x00006677
			public unsafe int _despawnParents_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolManager._DespawnOverTime_d__21.NativeFieldInfoPtr__despawnParents_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolManager._DespawnOverTime_d__21.NativeFieldInfoPtr__despawnParents_5__2)) = value;
				}
			}

			// Token: 0x170003C2 RID: 962
			// (get) Token: 0x06000CC0 RID: 3264 RVA: 0x00032A2C File Offset: 0x00030C2C
			// (set) Token: 0x06000CC1 RID: 3265 RVA: 0x00008492 File Offset: 0x00006692
			public unsafe int _batchSize_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolManager._DespawnOverTime_d__21.NativeFieldInfoPtr__batchSize_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolManager._DespawnOverTime_d__21.NativeFieldInfoPtr__batchSize_5__3)) = value;
				}
			}

			// Token: 0x170003C3 RID: 963
			// (get) Token: 0x06000CC2 RID: 3266 RVA: 0x00032A54 File Offset: 0x00030C54
			// (set) Token: 0x06000CC3 RID: 3267 RVA: 0x000084AD File Offset: 0x000066AD
			public unsafe int _batchCount_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolManager._DespawnOverTime_d__21.NativeFieldInfoPtr__batchCount_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolManager._DespawnOverTime_d__21.NativeFieldInfoPtr__batchCount_5__4)) = value;
				}
			}

			// Token: 0x170003C4 RID: 964
			// (get) Token: 0x06000CC4 RID: 3268 RVA: 0x00032A7C File Offset: 0x00030C7C
			// (set) Token: 0x06000CC5 RID: 3269 RVA: 0x000084C8 File Offset: 0x000066C8
			public List<PoolableItem>.Enumerator __7__wrap4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolManager._DespawnOverTime_d__21.NativeFieldInfoPtr___7__wrap4);
					return new List<PoolableItem>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<PoolableItem>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolManager._DespawnOverTime_d__21.NativeFieldInfoPtr___7__wrap4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<PoolableItem>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040007E4 RID: 2020
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040007E5 RID: 2021
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040007E6 RID: 2022
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040007E7 RID: 2023
			private static readonly IntPtr NativeFieldInfoPtr__despawnParents_5__2;

			// Token: 0x040007E8 RID: 2024
			private static readonly IntPtr NativeFieldInfoPtr__batchSize_5__3;

			// Token: 0x040007E9 RID: 2025
			private static readonly IntPtr NativeFieldInfoPtr__batchCount_5__4;

			// Token: 0x040007EA RID: 2026
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap4;

			// Token: 0x040007EB RID: 2027
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040007EC RID: 2028
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040007ED RID: 2029
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040007EE RID: 2030
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040007EF RID: 2031
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040007F0 RID: 2032
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040007F1 RID: 2033
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020000F7 RID: 247
		private sealed class MethodInfoStoreGeneric_Spawn_Public_T_PoolableItem_PoolableItem_Transform_0<T>
		{
			// Token: 0x040007F2 RID: 2034
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PoolManager.NativeMethodInfoPtr_Spawn_Public_T_PoolableItem_PoolableItem_Transform_0, Il2CppClassPointerStore<PoolManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000F8 RID: 248
		private sealed class MethodInfoStoreGeneric_Spawn_Public_T_T_PoolableItem_Transform_0<T>
		{
			// Token: 0x040007F3 RID: 2035
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PoolManager.NativeMethodInfoPtr_Spawn_Public_T_T_PoolableItem_Transform_0, Il2CppClassPointerStore<PoolManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
