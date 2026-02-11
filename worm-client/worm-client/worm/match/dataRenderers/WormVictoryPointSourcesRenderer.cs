using System;
using boardgames.match.behaviours;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Linq;
using UnityEngine;
using voodoo;
using worm.match.components;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x02000176 RID: 374
	public class WormVictoryPointSourcesRenderer : VersionedDataComponentObserver<WormVictoryPointsData>
	{
		// Token: 0x060010C1 RID: 4289 RVA: 0x0004A4B4 File Offset: 0x000486B4
		// Note: this type is marked as 'beforefieldinit'.
		static WormVictoryPointSourcesRenderer()
		{
			Il2CppClassPointerStore<WormVictoryPointSourcesRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormVictoryPointSourcesRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormVictoryPointSourcesRenderer>.NativeClassPtr);
			WormVictoryPointSourcesRenderer.NativeFieldInfoPtr_categoriesRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVictoryPointSourcesRenderer>.NativeClassPtr, "categoriesRoot");
			WormVictoryPointSourcesRenderer.NativeFieldInfoPtr_categoryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVictoryPointSourcesRenderer>.NativeClassPtr, "categoryPrefab");
			WormVictoryPointSourcesRenderer.NativeFieldInfoPtr_entitiesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVictoryPointSourcesRenderer>.NativeClassPtr, "entitiesProvider");
			WormVictoryPointSourcesRenderer.NativeFieldInfoPtr_LocPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVictoryPointSourcesRenderer>.NativeClassPtr, "LocPrefix");
			WormVictoryPointSourcesRenderer.NativeFieldInfoPtr_HeaderPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVictoryPointSourcesRenderer>.NativeClassPtr, "HeaderPrefix");
			WormVictoryPointSourcesRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVictoryPointSourcesRenderer>.NativeClassPtr, 100665616);
			WormVictoryPointSourcesRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVictoryPointSourcesRenderer>.NativeClassPtr, 100665617);
			WormVictoryPointSourcesRenderer.NativeMethodInfoPtr_ShowCategories_Private_Void_IReadOnlyList_1_VPCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVictoryPointSourcesRenderer>.NativeClassPtr, 100665618);
			WormVictoryPointSourcesRenderer.NativeMethodInfoPtr_GetCardsCategory_Private_VPCategory_String_IEnumerable_1_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVictoryPointSourcesRenderer>.NativeClassPtr, 100665619);
			WormVictoryPointSourcesRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVictoryPointSourcesRenderer>.NativeClassPtr, 100665620);
			WormVictoryPointSourcesRenderer.NativeMethodInfoPtr__versionChanged_b__7_0_Private_ValueTuple_2_String_Int32_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVictoryPointSourcesRenderer>.NativeClassPtr, 100665621);
			WormVictoryPointSourcesRenderer.NativeMethodInfoPtr__versionChanged_b__7_1_Private_Int32_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVictoryPointSourcesRenderer>.NativeClassPtr, 100665622);
			WormVictoryPointSourcesRenderer.NativeMethodInfoPtr__versionChanged_b__7_2_Private_Int32_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVictoryPointSourcesRenderer>.NativeClassPtr, 100665623);
			WormVictoryPointSourcesRenderer.NativeMethodInfoPtr__versionChanged_b__7_3_Private_ValueTuple_2_String_Int32_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVictoryPointSourcesRenderer>.NativeClassPtr, 100665624);
			WormVictoryPointSourcesRenderer.NativeMethodInfoPtr__versionChanged_b__7_4_Private_Int32_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVictoryPointSourcesRenderer>.NativeClassPtr, 100665625);
			WormVictoryPointSourcesRenderer.NativeMethodInfoPtr__GetCardsCategory_b__9_1_Private_ValueTuple_2_String_Int32_IGrouping_2_String_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVictoryPointSourcesRenderer>.NativeClassPtr, 100665626);
			WormVictoryPointSourcesRenderer.NativeMethodInfoPtr__GetCardsCategory_b__9_2_Private_Int32_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVictoryPointSourcesRenderer>.NativeClassPtr, 100665627);
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x0004A638 File Offset: 0x00048838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709996, XrefRangeEnd = 710000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormVictoryPointSourcesRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x0004A674 File Offset: 0x00048874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710000, XrefRangeEnd = 710342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void versionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormVictoryPointSourcesRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x0004A6B0 File Offset: 0x000488B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 710374, RefRangeEnd = 710375, XrefRangeStart = 710342, XrefRangeEnd = 710374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowCategories(IReadOnlyList<WormVictoryPointSourcesRenderer.VPCategory> categories)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(categories);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVictoryPointSourcesRenderer.NativeMethodInfoPtr_ShowCategories_Private_Void_IReadOnlyList_1_VPCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010C5 RID: 4293 RVA: 0x0004A6F4 File Offset: 0x000488F4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 710403, RefRangeEnd = 710408, XrefRangeStart = 710375, XrefRangeEnd = 710403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormVictoryPointSourcesRenderer.VPCategory GetCardsCategory(string category, IEnumerable<EntityComponent> cards)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(category);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cards);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVictoryPointSourcesRenderer.NativeMethodInfoPtr_GetCardsCategory_Private_VPCategory_String_IEnumerable_1_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new WormVictoryPointSourcesRenderer.VPCategory(intPtr);
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x0004A750 File Offset: 0x00048950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710408, XrefRangeEnd = 710411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormVictoryPointSourcesRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormVictoryPointSourcesRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVictoryPointSourcesRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x0004A78C File Offset: 0x0004898C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710411, XrefRangeEnd = 710436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<string, int> _versionChanged_b__7_0(EntityComponent a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVictoryPointSourcesRenderer.NativeMethodInfoPtr__versionChanged_b__7_0_Private_ValueTuple_2_String_Int32_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTuple<string, int>(intPtr);
			}
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x0004A7D4 File Offset: 0x000489D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710436, XrefRangeEnd = 710441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _versionChanged_b__7_1(EntityComponent t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVictoryPointSourcesRenderer.NativeMethodInfoPtr__versionChanged_b__7_1_Private_Int32_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x0004A824 File Offset: 0x00048A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710441, XrefRangeEnd = 710446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _versionChanged_b__7_2(EntityComponent t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVictoryPointSourcesRenderer.NativeMethodInfoPtr__versionChanged_b__7_2_Private_Int32_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x0004A874 File Offset: 0x00048A74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710446, XrefRangeEnd = 710456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<string, int> _versionChanged_b__7_3(EntityComponent h)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(h);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVictoryPointSourcesRenderer.NativeMethodInfoPtr__versionChanged_b__7_3_Private_ValueTuple_2_String_Int32_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTuple<string, int>(intPtr);
			}
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x0004A8BC File Offset: 0x00048ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710456, XrefRangeEnd = 710461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _versionChanged_b__7_4(EntityComponent t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVictoryPointSourcesRenderer.NativeMethodInfoPtr__versionChanged_b__7_4_Private_Int32_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x0004A90C File Offset: 0x00048B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710461, XrefRangeEnd = 710479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<string, int> _GetCardsCategory_b__9_1(IGrouping<string, EntityComponent> g)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(g);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVictoryPointSourcesRenderer.NativeMethodInfoPtr__GetCardsCategory_b__9_1_Private_ValueTuple_2_String_Int32_IGrouping_2_String_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTuple<string, int>(intPtr);
			}
		}

		// Token: 0x060010CD RID: 4301 RVA: 0x0004A954 File Offset: 0x00048B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710479, XrefRangeEnd = 710484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _GetCardsCategory_b__9_2(EntityComponent c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVictoryPointSourcesRenderer.NativeMethodInfoPtr__GetCardsCategory_b__9_2_Private_Int32_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x0000AD52 File Offset: 0x00008F52
		public WormVictoryPointSourcesRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x060010CF RID: 4303 RVA: 0x0004A9A4 File Offset: 0x00048BA4
		// (set) Token: 0x060010D0 RID: 4304 RVA: 0x0000AD5B File Offset: 0x00008F5B
		public unsafe Transform categoriesRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVictoryPointSourcesRenderer.NativeFieldInfoPtr_categoriesRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVictoryPointSourcesRenderer.NativeFieldInfoPtr_categoriesRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x060010D1 RID: 4305 RVA: 0x0004A9D4 File Offset: 0x00048BD4
		// (set) Token: 0x060010D2 RID: 4306 RVA: 0x0000AD7A File Offset: 0x00008F7A
		public unsafe WormVPCategoryDisplay categoryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVictoryPointSourcesRenderer.NativeFieldInfoPtr_categoryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormVPCategoryDisplay>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVictoryPointSourcesRenderer.NativeFieldInfoPtr_categoryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x060010D3 RID: 4307 RVA: 0x0004AA04 File Offset: 0x00048C04
		// (set) Token: 0x060010D4 RID: 4308 RVA: 0x0000AD99 File Offset: 0x00008F99
		public unsafe DBGEntitiesProvider entitiesProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVictoryPointSourcesRenderer.NativeFieldInfoPtr_entitiesProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVictoryPointSourcesRenderer.NativeFieldInfoPtr_entitiesProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x060010D5 RID: 4309 RVA: 0x0004AA34 File Offset: 0x00048C34
		// (set) Token: 0x060010D6 RID: 4310 RVA: 0x0000ADB8 File Offset: 0x00008FB8
		public unsafe static string LocPrefix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormVictoryPointSourcesRenderer.NativeFieldInfoPtr_LocPrefix, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormVictoryPointSourcesRenderer.NativeFieldInfoPtr_LocPrefix, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x060010D7 RID: 4311 RVA: 0x0004AA54 File Offset: 0x00048C54
		// (set) Token: 0x060010D8 RID: 4312 RVA: 0x0000ADCA File Offset: 0x00008FCA
		public unsafe static string HeaderPrefix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormVictoryPointSourcesRenderer.NativeFieldInfoPtr_HeaderPrefix, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormVictoryPointSourcesRenderer.NativeFieldInfoPtr_HeaderPrefix, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040009A1 RID: 2465
		private static readonly IntPtr NativeFieldInfoPtr_categoriesRoot;

		// Token: 0x040009A2 RID: 2466
		private static readonly IntPtr NativeFieldInfoPtr_categoryPrefab;

		// Token: 0x040009A3 RID: 2467
		private static readonly IntPtr NativeFieldInfoPtr_entitiesProvider;

		// Token: 0x040009A4 RID: 2468
		private static readonly IntPtr NativeFieldInfoPtr_LocPrefix;

		// Token: 0x040009A5 RID: 2469
		private static readonly IntPtr NativeFieldInfoPtr_HeaderPrefix;

		// Token: 0x040009A6 RID: 2470
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040009A7 RID: 2471
		private static readonly IntPtr NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0;

		// Token: 0x040009A8 RID: 2472
		private static readonly IntPtr NativeMethodInfoPtr_ShowCategories_Private_Void_IReadOnlyList_1_VPCategory_0;

		// Token: 0x040009A9 RID: 2473
		private static readonly IntPtr NativeMethodInfoPtr_GetCardsCategory_Private_VPCategory_String_IEnumerable_1_EntityComponent_0;

		// Token: 0x040009AA RID: 2474
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040009AB RID: 2475
		private static readonly IntPtr NativeMethodInfoPtr__versionChanged_b__7_0_Private_ValueTuple_2_String_Int32_EntityComponent_0;

		// Token: 0x040009AC RID: 2476
		private static readonly IntPtr NativeMethodInfoPtr__versionChanged_b__7_1_Private_Int32_EntityComponent_0;

		// Token: 0x040009AD RID: 2477
		private static readonly IntPtr NativeMethodInfoPtr__versionChanged_b__7_2_Private_Int32_EntityComponent_0;

		// Token: 0x040009AE RID: 2478
		private static readonly IntPtr NativeMethodInfoPtr__versionChanged_b__7_3_Private_ValueTuple_2_String_Int32_EntityComponent_0;

		// Token: 0x040009AF RID: 2479
		private static readonly IntPtr NativeMethodInfoPtr__versionChanged_b__7_4_Private_Int32_EntityComponent_0;

		// Token: 0x040009B0 RID: 2480
		private static readonly IntPtr NativeMethodInfoPtr__GetCardsCategory_b__9_1_Private_ValueTuple_2_String_Int32_IGrouping_2_String_EntityComponent_0;

		// Token: 0x040009B1 RID: 2481
		private static readonly IntPtr NativeMethodInfoPtr__GetCardsCategory_b__9_2_Private_Int32_EntityComponent_0;

		// Token: 0x020003B7 RID: 951
		public sealed class VPCategory : ValueType
		{
			// Token: 0x0600266A RID: 9834 RVA: 0x0008CC3C File Offset: 0x0008AE3C
			// Note: this type is marked as 'beforefieldinit'.
			static VPCategory()
			{
				Il2CppClassPointerStore<WormVictoryPointSourcesRenderer.VPCategory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormVictoryPointSourcesRenderer>.NativeClassPtr, "VPCategory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormVictoryPointSourcesRenderer.VPCategory>.NativeClassPtr);
				WormVictoryPointSourcesRenderer.VPCategory.NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVictoryPointSourcesRenderer.VPCategory>.NativeClassPtr, "category");
				WormVictoryPointSourcesRenderer.VPCategory.NativeFieldInfoPtr_sources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVictoryPointSourcesRenderer.VPCategory>.NativeClassPtr, "sources");
				WormVictoryPointSourcesRenderer.VPCategory.NativeMethodInfoPtr__ctor_Public_Void_String_IEnumerable_1_ValueTuple_2_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVictoryPointSourcesRenderer.VPCategory>.NativeClassPtr, 100665628);
			}

			// Token: 0x0600266B RID: 9835 RVA: 0x0008CCA4 File Offset: 0x0008AEA4
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 709980, RefRangeEnd = 709987, XrefRangeStart = 709954, XrefRangeEnd = 709980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe VPCategory(string category, IEnumerable<ValueTuple<string, int>> sources)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormVictoryPointSourcesRenderer.VPCategory>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(category);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sources);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVictoryPointSourcesRenderer.VPCategory.NativeMethodInfoPtr__ctor_Public_Void_String_IEnumerable_1_ValueTuple_2_String_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600266C RID: 9836 RVA: 0x0001537B File Offset: 0x0001357B
			public VPCategory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600266D RID: 9837 RVA: 0x00015384 File Offset: 0x00013584
			public VPCategory()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormVictoryPointSourcesRenderer.VPCategory>.NativeClassPtr))
			{
			}

			// Token: 0x17000AAB RID: 2731
			// (get) Token: 0x0600266E RID: 9838 RVA: 0x0008CD08 File Offset: 0x0008AF08
			// (set) Token: 0x0600266F RID: 9839 RVA: 0x00015396 File Offset: 0x00013596
			public unsafe string category
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVictoryPointSourcesRenderer.VPCategory.NativeFieldInfoPtr_category);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVictoryPointSourcesRenderer.VPCategory.NativeFieldInfoPtr_category), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000AAC RID: 2732
			// (get) Token: 0x06002670 RID: 9840 RVA: 0x0008CD30 File Offset: 0x0008AF30
			// (set) Token: 0x06002671 RID: 9841 RVA: 0x000153B5 File Offset: 0x000135B5
			public unsafe IReadOnlyList<ValueTuple<string, int>> sources
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVictoryPointSourcesRenderer.VPCategory.NativeFieldInfoPtr_sources);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<ValueTuple<string, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVictoryPointSourcesRenderer.VPCategory.NativeFieldInfoPtr_sources), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001621 RID: 5665
			private static readonly IntPtr NativeFieldInfoPtr_category;

			// Token: 0x04001622 RID: 5666
			private static readonly IntPtr NativeFieldInfoPtr_sources;

			// Token: 0x04001623 RID: 5667
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_IEnumerable_1_ValueTuple_2_String_Int32_0;

			// Token: 0x0200044A RID: 1098
			[ObfuscatedName("worm.match.dataRenderers.WormVictoryPointSourcesRenderer+VPCategory+<>c")]
			[Serializable]
			public sealed class __c : global::Il2CppSystem.Object
			{
				// Token: 0x06002D7A RID: 11642 RVA: 0x000A1C88 File Offset: 0x0009FE88
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<WormVictoryPointSourcesRenderer.VPCategory.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormVictoryPointSourcesRenderer.VPCategory>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormVictoryPointSourcesRenderer.VPCategory.__c>.NativeClassPtr);
					WormVictoryPointSourcesRenderer.VPCategory.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVictoryPointSourcesRenderer.VPCategory.__c>.NativeClassPtr, "<>9");
					WormVictoryPointSourcesRenderer.VPCategory.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVictoryPointSourcesRenderer.VPCategory.__c>.NativeClassPtr, "<>9__2_0");
					WormVictoryPointSourcesRenderer.VPCategory.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVictoryPointSourcesRenderer.VPCategory.__c>.NativeClassPtr, 100665630);
					WormVictoryPointSourcesRenderer.VPCategory.__c.NativeMethodInfoPtr___ctor_b__2_0_Internal_String_ValueTuple_2_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVictoryPointSourcesRenderer.VPCategory.__c>.NativeClassPtr, 100665631);
				}

				// Token: 0x06002D7B RID: 11643 RVA: 0x000A1D04 File Offset: 0x0009FF04
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormVictoryPointSourcesRenderer.VPCategory.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVictoryPointSourcesRenderer.VPCategory.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002D7C RID: 11644 RVA: 0x000A1D40 File Offset: 0x0009FF40
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709950, XrefRangeEnd = 709954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string __ctor_b__2_0(ValueTuple<string, int> s)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(s));
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVictoryPointSourcesRenderer.VPCategory.__c.NativeMethodInfoPtr___ctor_b__2_0_Internal_String_ValueTuple_2_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x06002D7D RID: 11645 RVA: 0x00018A79 File Offset: 0x00016C79
				public __c(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000D0B RID: 3339
				// (get) Token: 0x06002D7E RID: 11646 RVA: 0x000A1D90 File Offset: 0x0009FF90
				// (set) Token: 0x06002D7F RID: 11647 RVA: 0x00018A82 File Offset: 0x00016C82
				public unsafe static WormVictoryPointSourcesRenderer.VPCategory.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(WormVictoryPointSourcesRenderer.VPCategory.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormVictoryPointSourcesRenderer.VPCategory.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(WormVictoryPointSourcesRenderer.VPCategory.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000D0C RID: 3340
				// (get) Token: 0x06002D80 RID: 11648 RVA: 0x000A1DB8 File Offset: 0x0009FFB8
				// (set) Token: 0x06002D81 RID: 11649 RVA: 0x00018A94 File Offset: 0x00016C94
				public unsafe static Func<ValueTuple<string, int>, string> __9__2_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(WormVictoryPointSourcesRenderer.VPCategory.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<string, int>, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(WormVictoryPointSourcesRenderer.VPCategory.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04001A6B RID: 6763
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x04001A6C RID: 6764
				private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

				// Token: 0x04001A6D RID: 6765
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04001A6E RID: 6766
				private static readonly IntPtr NativeMethodInfoPtr___ctor_b__2_0_Internal_String_ValueTuple_2_String_Int32_0;
			}
		}

		// Token: 0x020003B8 RID: 952
		[ObfuscatedName("worm.match.dataRenderers.WormVictoryPointSourcesRenderer+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06002672 RID: 9842 RVA: 0x0008CD60 File Offset: 0x0008AF60
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormVictoryPointSourcesRenderer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormVictoryPointSourcesRenderer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormVictoryPointSourcesRenderer.__c>.NativeClassPtr);
				WormVictoryPointSourcesRenderer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVictoryPointSourcesRenderer.__c>.NativeClassPtr, "<>9");
				WormVictoryPointSourcesRenderer.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVictoryPointSourcesRenderer.__c>.NativeClassPtr, "<>9__9_0");
				WormVictoryPointSourcesRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVictoryPointSourcesRenderer.__c>.NativeClassPtr, 100665633);
				WormVictoryPointSourcesRenderer.__c.NativeMethodInfoPtr__GetCardsCategory_b__9_0_Internal_String_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVictoryPointSourcesRenderer.__c>.NativeClassPtr, 100665634);
			}

			// Token: 0x06002673 RID: 9843 RVA: 0x0008CDDC File Offset: 0x0008AFDC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormVictoryPointSourcesRenderer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVictoryPointSourcesRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002674 RID: 9844 RVA: 0x0008CE18 File Offset: 0x0008B018
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709987, XrefRangeEnd = 709996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetCardsCategory_b__9_0(EntityComponent c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVictoryPointSourcesRenderer.__c.NativeMethodInfoPtr__GetCardsCategory_b__9_0_Internal_String_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06002675 RID: 9845 RVA: 0x000153D4 File Offset: 0x000135D4
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AAD RID: 2733
			// (get) Token: 0x06002676 RID: 9846 RVA: 0x0008CE60 File Offset: 0x0008B060
			// (set) Token: 0x06002677 RID: 9847 RVA: 0x000153DD File Offset: 0x000135DD
			public unsafe static WormVictoryPointSourcesRenderer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormVictoryPointSourcesRenderer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormVictoryPointSourcesRenderer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormVictoryPointSourcesRenderer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AAE RID: 2734
			// (get) Token: 0x06002678 RID: 9848 RVA: 0x0008CE88 File Offset: 0x0008B088
			// (set) Token: 0x06002679 RID: 9849 RVA: 0x000153EF File Offset: 0x000135EF
			public unsafe static Func<EntityComponent, string> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormVictoryPointSourcesRenderer.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormVictoryPointSourcesRenderer.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001624 RID: 5668
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001625 RID: 5669
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x04001626 RID: 5670
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001627 RID: 5671
			private static readonly IntPtr NativeMethodInfoPtr__GetCardsCategory_b__9_0_Internal_String_EntityComponent_0;
		}
	}
}
