using System;
using boardgames.match;
using Canis.attributes;
using Canis.utils;
using Canis.utils.ids;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.Events;
using worm.canis.data.enums;

namespace worm.match.dataRenderers
{
	// Token: 0x02000161 RID: 353
	public class WormSkirmishScoreRenderer : VersionedView<VersionedList<IVersionedModel>>
	{
		// Token: 0x06000FC6 RID: 4038 RVA: 0x000477A0 File Offset: 0x000459A0
		// Note: this type is marked as 'beforefieldinit'.
		static WormSkirmishScoreRenderer()
		{
			Il2CppClassPointerStore<WormSkirmishScoreRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormSkirmishScoreRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSkirmishScoreRenderer>.NativeClassPtr);
			WormSkirmishScoreRenderer.NativeFieldInfoPtr_onScoreUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSkirmishScoreRenderer>.NativeClassPtr, "onScoreUpdated");
			WormSkirmishScoreRenderer.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSkirmishScoreRenderer>.NativeClassPtr, "entities");
			WormSkirmishScoreRenderer.NativeFieldInfoPtr_localPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSkirmishScoreRenderer>.NativeClassPtr, "localPlayer");
			WormSkirmishScoreRenderer.NativeFieldInfoPtr_archetypeProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSkirmishScoreRenderer>.NativeClassPtr, "archetypeProvider");
			WormSkirmishScoreRenderer.NativeMethodInfoPtr_get_currentModelVersion_Protected_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSkirmishScoreRenderer>.NativeClassPtr, 100665438);
			WormSkirmishScoreRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSkirmishScoreRenderer>.NativeClassPtr, 100665439);
			WormSkirmishScoreRenderer.NativeMethodInfoPtr_GetScoreForMethod_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSkirmishScoreRenderer>.NativeClassPtr, 100665440);
			WormSkirmishScoreRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSkirmishScoreRenderer>.NativeClassPtr, 100665441);
			WormSkirmishScoreRenderer.NativeMethodInfoPtr_SpaceScoringMethod_Private_Int32_AgentIcons_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSkirmishScoreRenderer>.NativeClassPtr, 100665442);
			WormSkirmishScoreRenderer.NativeMethodInfoPtr_WatchAttribute_Private_T_AttributeDefinition_1_T_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSkirmishScoreRenderer>.NativeClassPtr, 100665443);
			WormSkirmishScoreRenderer.NativeMethodInfoPtr_Watch_Private_Void_IVersionedModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSkirmishScoreRenderer>.NativeClassPtr, 100665444);
			WormSkirmishScoreRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSkirmishScoreRenderer>.NativeClassPtr, 100665445);
			WormSkirmishScoreRenderer.NativeMethodInfoPtr__GetScoreForMethod_b__7_1_Private_Boolean_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSkirmishScoreRenderer>.NativeClassPtr, 100665446);
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06000FC7 RID: 4039 RVA: 0x000478D4 File Offset: 0x00045AD4
		public unsafe override ulong currentModelVersion
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 708355, XrefRangeEnd = 708356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSkirmishScoreRenderer.NativeMethodInfoPtr_get_currentModelVersion_Protected_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x0004791C File Offset: 0x00045B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 708356, XrefRangeEnd = 708365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSkirmishScoreRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x00047958 File Offset: 0x00045B58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 708662, RefRangeEnd = 708663, XrefRangeStart = 708365, XrefRangeEnd = 708662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetScoreForMethod(int methodId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref methodId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSkirmishScoreRenderer.NativeMethodInfoPtr_GetScoreForMethod_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x000479A4 File Offset: 0x00045BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSkirmishScoreRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x000479E0 File Offset: 0x00045BE0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 708684, RefRangeEnd = 708687, XrefRangeStart = 708663, XrefRangeEnd = 708684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int SpaceScoringMethod(AgentIcons spaceType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref spaceType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSkirmishScoreRenderer.NativeMethodInfoPtr_SpaceScoringMethod_Private_Int32_AgentIcons_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x00047A2C File Offset: 0x00045C2C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 708692, RefRangeEnd = 708701, XrefRangeStart = 708687, XrefRangeEnd = 708692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T WatchAttribute<T>(AttributeDefinition<T> attributeDefinition, EntityComponent component = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeDefinition);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(component);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSkirmishScoreRenderer.MethodInfoStoreGeneric_WatchAttribute_Private_T_AttributeDefinition_1_T_EntityComponent_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x00047A88 File Offset: 0x00045C88
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 708707, RefRangeEnd = 708712, XrefRangeStart = 708701, XrefRangeEnd = 708707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Watch(IVersionedModel model)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(model);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSkirmishScoreRenderer.NativeMethodInfoPtr_Watch_Private_Void_IVersionedModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x00047ACC File Offset: 0x00045CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 708712, XrefRangeEnd = 708720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSkirmishScoreRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSkirmishScoreRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSkirmishScoreRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x00047B08 File Offset: 0x00045D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 708720, XrefRangeEnd = 708734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetScoreForMethod_b__7_1(ArchetypeID c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSkirmishScoreRenderer.NativeMethodInfoPtr__GetScoreForMethod_b__7_1_Private_Boolean_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x0000A4E2 File Offset: 0x000086E2
		public WormSkirmishScoreRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06000FD1 RID: 4049 RVA: 0x00047B58 File Offset: 0x00045D58
		// (set) Token: 0x06000FD2 RID: 4050 RVA: 0x0000A4EB File Offset: 0x000086EB
		public unsafe UnityEvent onScoreUpdated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishScoreRenderer.NativeFieldInfoPtr_onScoreUpdated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishScoreRenderer.NativeFieldInfoPtr_onScoreUpdated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06000FD3 RID: 4051 RVA: 0x00047B88 File Offset: 0x00045D88
		// (set) Token: 0x06000FD4 RID: 4052 RVA: 0x0000A50A File Offset: 0x0000870A
		public unsafe DBGEntities entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishScoreRenderer.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishScoreRenderer.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06000FD5 RID: 4053 RVA: 0x00047BB8 File Offset: 0x00045DB8
		// (set) Token: 0x06000FD6 RID: 4054 RVA: 0x0000A529 File Offset: 0x00008729
		public unsafe EntityComponent localPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishScoreRenderer.NativeFieldInfoPtr_localPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishScoreRenderer.NativeFieldInfoPtr_localPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06000FD7 RID: 4055 RVA: 0x00047BE8 File Offset: 0x00045DE8
		// (set) Token: 0x06000FD8 RID: 4056 RVA: 0x0000A548 File Offset: 0x00008748
		public unsafe WormArchetypeProvider archetypeProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishScoreRenderer.NativeFieldInfoPtr_archetypeProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormArchetypeProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishScoreRenderer.NativeFieldInfoPtr_archetypeProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000914 RID: 2324
		private static readonly IntPtr NativeFieldInfoPtr_onScoreUpdated;

		// Token: 0x04000915 RID: 2325
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x04000916 RID: 2326
		private static readonly IntPtr NativeFieldInfoPtr_localPlayer;

		// Token: 0x04000917 RID: 2327
		private static readonly IntPtr NativeFieldInfoPtr_archetypeProvider;

		// Token: 0x04000918 RID: 2328
		private static readonly IntPtr NativeMethodInfoPtr_get_currentModelVersion_Protected_Virtual_get_UInt64_0;

		// Token: 0x04000919 RID: 2329
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400091A RID: 2330
		private static readonly IntPtr NativeMethodInfoPtr_GetScoreForMethod_Public_Int32_Int32_0;

		// Token: 0x0400091B RID: 2331
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400091C RID: 2332
		private static readonly IntPtr NativeMethodInfoPtr_SpaceScoringMethod_Private_Int32_AgentIcons_0;

		// Token: 0x0400091D RID: 2333
		private static readonly IntPtr NativeMethodInfoPtr_WatchAttribute_Private_T_AttributeDefinition_1_T_EntityComponent_0;

		// Token: 0x0400091E RID: 2334
		private static readonly IntPtr NativeMethodInfoPtr_Watch_Private_Void_IVersionedModel_0;

		// Token: 0x0400091F RID: 2335
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000920 RID: 2336
		private static readonly IntPtr NativeMethodInfoPtr__GetScoreForMethod_b__7_1_Private_Boolean_ArchetypeID_0;

		// Token: 0x020003A8 RID: 936
		[ObfuscatedName("worm.match.dataRenderers.WormSkirmishScoreRenderer+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060025AD RID: 9645 RVA: 0x00089D60 File Offset: 0x00087F60
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormSkirmishScoreRenderer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormSkirmishScoreRenderer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSkirmishScoreRenderer.__c>.NativeClassPtr);
				WormSkirmishScoreRenderer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSkirmishScoreRenderer.__c>.NativeClassPtr, "<>9");
				WormSkirmishScoreRenderer.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSkirmishScoreRenderer.__c>.NativeClassPtr, "<>9__7_0");
				WormSkirmishScoreRenderer.__c.NativeFieldInfoPtr___9__7_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSkirmishScoreRenderer.__c>.NativeClassPtr, "<>9__7_2");
				WormSkirmishScoreRenderer.__c.NativeFieldInfoPtr___9__7_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSkirmishScoreRenderer.__c>.NativeClassPtr, "<>9__7_3");
				WormSkirmishScoreRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSkirmishScoreRenderer.__c>.NativeClassPtr, 100665448);
				WormSkirmishScoreRenderer.__c.NativeMethodInfoPtr__GetScoreForMethod_b__7_0_Internal_Boolean_KeyValuePair_2_ArchetypeID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSkirmishScoreRenderer.__c>.NativeClassPtr, 100665449);
				WormSkirmishScoreRenderer.__c.NativeMethodInfoPtr__GetScoreForMethod_b__7_2_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSkirmishScoreRenderer.__c>.NativeClassPtr, 100665450);
				WormSkirmishScoreRenderer.__c.NativeMethodInfoPtr__GetScoreForMethod_b__7_3_Internal_Int32_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSkirmishScoreRenderer.__c>.NativeClassPtr, 100665451);
			}

			// Token: 0x060025AE RID: 9646 RVA: 0x00089E2C File Offset: 0x0008802C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSkirmishScoreRenderer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSkirmishScoreRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060025AF RID: 9647 RVA: 0x00089E68 File Offset: 0x00088068
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 708318, XrefRangeEnd = 708319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetScoreForMethod_b__7_0(KeyValuePair<ArchetypeID, int> s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(s));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSkirmishScoreRenderer.__c.NativeMethodInfoPtr__GetScoreForMethod_b__7_0_Internal_Boolean_KeyValuePair_2_ArchetypeID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060025B0 RID: 9648 RVA: 0x00089EBC File Offset: 0x000880BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 708319, XrefRangeEnd = 708326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetScoreForMethod_b__7_2(EntityComponent t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSkirmishScoreRenderer.__c.NativeMethodInfoPtr__GetScoreForMethod_b__7_2_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060025B1 RID: 9649 RVA: 0x00089F0C File Offset: 0x0008810C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 708326, XrefRangeEnd = 708334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetScoreForMethod_b__7_3(EntityComponent t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSkirmishScoreRenderer.__c.NativeMethodInfoPtr__GetScoreForMethod_b__7_3_Internal_Int32_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060025B2 RID: 9650 RVA: 0x00014F78 File Offset: 0x00013178
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A80 RID: 2688
			// (get) Token: 0x060025B3 RID: 9651 RVA: 0x00089F5C File Offset: 0x0008815C
			// (set) Token: 0x060025B4 RID: 9652 RVA: 0x00014F81 File Offset: 0x00013181
			public unsafe static WormSkirmishScoreRenderer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormSkirmishScoreRenderer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSkirmishScoreRenderer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormSkirmishScoreRenderer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A81 RID: 2689
			// (get) Token: 0x060025B5 RID: 9653 RVA: 0x00089F84 File Offset: 0x00088184
			// (set) Token: 0x060025B6 RID: 9654 RVA: 0x00014F93 File Offset: 0x00013193
			public unsafe static Func<KeyValuePair<ArchetypeID, int>, bool> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormSkirmishScoreRenderer.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<ArchetypeID, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormSkirmishScoreRenderer.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A82 RID: 2690
			// (get) Token: 0x060025B7 RID: 9655 RVA: 0x00089FAC File Offset: 0x000881AC
			// (set) Token: 0x060025B8 RID: 9656 RVA: 0x00014FA5 File Offset: 0x000131A5
			public unsafe static Func<EntityComponent, bool> __9__7_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormSkirmishScoreRenderer.__c.NativeFieldInfoPtr___9__7_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormSkirmishScoreRenderer.__c.NativeFieldInfoPtr___9__7_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A83 RID: 2691
			// (get) Token: 0x060025B9 RID: 9657 RVA: 0x00089FD4 File Offset: 0x000881D4
			// (set) Token: 0x060025BA RID: 9658 RVA: 0x00014FB7 File Offset: 0x000131B7
			public unsafe static Func<EntityComponent, int> __9__7_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormSkirmishScoreRenderer.__c.NativeFieldInfoPtr___9__7_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormSkirmishScoreRenderer.__c.NativeFieldInfoPtr___9__7_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400159C RID: 5532
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400159D RID: 5533
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x0400159E RID: 5534
			private static readonly IntPtr NativeFieldInfoPtr___9__7_2;

			// Token: 0x0400159F RID: 5535
			private static readonly IntPtr NativeFieldInfoPtr___9__7_3;

			// Token: 0x040015A0 RID: 5536
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040015A1 RID: 5537
			private static readonly IntPtr NativeMethodInfoPtr__GetScoreForMethod_b__7_0_Internal_Boolean_KeyValuePair_2_ArchetypeID_Int32_0;

			// Token: 0x040015A2 RID: 5538
			private static readonly IntPtr NativeMethodInfoPtr__GetScoreForMethod_b__7_2_Internal_Boolean_EntityComponent_0;

			// Token: 0x040015A3 RID: 5539
			private static readonly IntPtr NativeMethodInfoPtr__GetScoreForMethod_b__7_3_Internal_Int32_EntityComponent_0;
		}

		// Token: 0x020003A9 RID: 937
		[ObfuscatedName("worm.match.dataRenderers.WormSkirmishScoreRenderer+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x060025BB RID: 9659 RVA: 0x00089FFC File Offset: 0x000881FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<WormSkirmishScoreRenderer.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormSkirmishScoreRenderer>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSkirmishScoreRenderer.__c__DisplayClass7_0>.NativeClassPtr);
				WormSkirmishScoreRenderer.__c__DisplayClass7_0.NativeFieldInfoPtr_activePlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSkirmishScoreRenderer.__c__DisplayClass7_0>.NativeClassPtr, "activePlayer");
				WormSkirmishScoreRenderer.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSkirmishScoreRenderer.__c__DisplayClass7_0>.NativeClassPtr, 100665452);
				WormSkirmishScoreRenderer.__c__DisplayClass7_0.NativeMethodInfoPtr__GetScoreForMethod_b__4_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSkirmishScoreRenderer.__c__DisplayClass7_0>.NativeClassPtr, 100665453);
			}

			// Token: 0x060025BC RID: 9660 RVA: 0x0008A064 File Offset: 0x00088264
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSkirmishScoreRenderer.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSkirmishScoreRenderer.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060025BD RID: 9661 RVA: 0x0008A0A0 File Offset: 0x000882A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 708334, XrefRangeEnd = 708339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetScoreForMethod_b__4(EntityComponent s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSkirmishScoreRenderer.__c__DisplayClass7_0.NativeMethodInfoPtr__GetScoreForMethod_b__4_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060025BE RID: 9662 RVA: 0x00014FC9 File Offset: 0x000131C9
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A84 RID: 2692
			// (get) Token: 0x060025BF RID: 9663 RVA: 0x0008A0F0 File Offset: 0x000882F0
			// (set) Token: 0x060025C0 RID: 9664 RVA: 0x00014FD2 File Offset: 0x000131D2
			public unsafe AccountID activePlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishScoreRenderer.__c__DisplayClass7_0.NativeFieldInfoPtr_activePlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishScoreRenderer.__c__DisplayClass7_0.NativeFieldInfoPtr_activePlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015A4 RID: 5540
			private static readonly IntPtr NativeFieldInfoPtr_activePlayer;

			// Token: 0x040015A5 RID: 5541
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040015A6 RID: 5542
			private static readonly IntPtr NativeMethodInfoPtr__GetScoreForMethod_b__4_Internal_Boolean_EntityComponent_0;
		}

		// Token: 0x020003AA RID: 938
		[ObfuscatedName("worm.match.dataRenderers.WormSkirmishScoreRenderer+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Object
		{
			// Token: 0x060025C1 RID: 9665 RVA: 0x0008A120 File Offset: 0x00088320
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<WormSkirmishScoreRenderer.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormSkirmishScoreRenderer>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSkirmishScoreRenderer.__c__DisplayClass9_0>.NativeClassPtr);
				WormSkirmishScoreRenderer.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSkirmishScoreRenderer.__c__DisplayClass9_0>.NativeClassPtr, "<>4__this");
				WormSkirmishScoreRenderer.__c__DisplayClass9_0.NativeFieldInfoPtr_spaceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSkirmishScoreRenderer.__c__DisplayClass9_0>.NativeClassPtr, "spaceType");
				WormSkirmishScoreRenderer.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSkirmishScoreRenderer.__c__DisplayClass9_0>.NativeClassPtr, 100665454);
				WormSkirmishScoreRenderer.__c__DisplayClass9_0.NativeMethodInfoPtr__SpaceScoringMethod_b__0_Internal_Int32_KeyValuePair_2_ArchetypeID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSkirmishScoreRenderer.__c__DisplayClass9_0>.NativeClassPtr, 100665455);
			}

			// Token: 0x060025C2 RID: 9666 RVA: 0x0008A19C File Offset: 0x0008839C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSkirmishScoreRenderer.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSkirmishScoreRenderer.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060025C3 RID: 9667 RVA: 0x0008A1D8 File Offset: 0x000883D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 708339, XrefRangeEnd = 708355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _SpaceScoringMethod_b__0(KeyValuePair<ArchetypeID, int> kvp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kvp));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSkirmishScoreRenderer.__c__DisplayClass9_0.NativeMethodInfoPtr__SpaceScoringMethod_b__0_Internal_Int32_KeyValuePair_2_ArchetypeID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060025C4 RID: 9668 RVA: 0x00014FF1 File Offset: 0x000131F1
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A85 RID: 2693
			// (get) Token: 0x060025C5 RID: 9669 RVA: 0x0008A22C File Offset: 0x0008842C
			// (set) Token: 0x060025C6 RID: 9670 RVA: 0x00014FFA File Offset: 0x000131FA
			public unsafe WormSkirmishScoreRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishScoreRenderer.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSkirmishScoreRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishScoreRenderer.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A86 RID: 2694
			// (get) Token: 0x060025C7 RID: 9671 RVA: 0x0008A25C File Offset: 0x0008845C
			// (set) Token: 0x060025C8 RID: 9672 RVA: 0x00015019 File Offset: 0x00013219
			public unsafe AgentIcons spaceType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishScoreRenderer.__c__DisplayClass9_0.NativeFieldInfoPtr_spaceType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishScoreRenderer.__c__DisplayClass9_0.NativeFieldInfoPtr_spaceType)) = value;
				}
			}

			// Token: 0x040015A7 RID: 5543
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040015A8 RID: 5544
			private static readonly IntPtr NativeFieldInfoPtr_spaceType;

			// Token: 0x040015A9 RID: 5545
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040015AA RID: 5546
			private static readonly IntPtr NativeMethodInfoPtr__SpaceScoringMethod_b__0_Internal_Int32_KeyValuePair_2_ArchetypeID_Int32_0;
		}

		// Token: 0x020003AB RID: 939
		private sealed class MethodInfoStoreGeneric_WatchAttribute_Private_T_AttributeDefinition_1_T_EntityComponent_0<T>
		{
			// Token: 0x040015AB RID: 5547
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(WormSkirmishScoreRenderer.NativeMethodInfoPtr_WatchAttribute_Private_T_AttributeDefinition_1_T_EntityComponent_0, Il2CppClassPointerStore<WormSkirmishScoreRenderer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
