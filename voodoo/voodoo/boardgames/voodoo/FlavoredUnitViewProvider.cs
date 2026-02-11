using System;
using dwd.core.match;
using dwd.core.prefabs.implementations.byflavor;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using lotus;
using voodoo;
using voodoo.flavors;

namespace boardgames.voodoo
{
	// Token: 0x02000097 RID: 151
	public class FlavoredUnitViewProvider : UnitViewProvider
	{
		// Token: 0x060008E7 RID: 2279 RVA: 0x00027020 File Offset: 0x00025220
		// Note: this type is marked as 'beforefieldinit'.
		static FlavoredUnitViewProvider()
		{
			Il2CppClassPointerStore<FlavoredUnitViewProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "boardgames.voodoo", "FlavoredUnitViewProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlavoredUnitViewProvider>.NativeClassPtr);
			FlavoredUnitViewProvider.NativeFieldInfoPtr_pileFlavors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlavoredUnitViewProvider>.NativeClassPtr, "pileFlavors");
			FlavoredUnitViewProvider.NativeFieldInfoPtr_prefabLoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlavoredUnitViewProvider>.NativeClassPtr, "prefabLoader");
			FlavoredUnitViewProvider.NativeMethodInfoPtr_Init_Public_Virtual_Void_ContainerView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredUnitViewProvider>.NativeClassPtr, 100664584);
			FlavoredUnitViewProvider.NativeMethodInfoPtr_GetUnitView_Public_Virtual_UnitView_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredUnitViewProvider>.NativeClassPtr, 100664585);
			FlavoredUnitViewProvider.NativeMethodInfoPtr_GetUnitView_Public_UnitView_EntityComponent_PrefabFlavorContext_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredUnitViewProvider>.NativeClassPtr, 100664586);
			FlavoredUnitViewProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredUnitViewProvider>.NativeClassPtr, 100664587);
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x000270C8 File Offset: 0x000252C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116936, XrefRangeEnd = 1116945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init(ContainerView container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FlavoredUnitViewProvider.NativeMethodInfoPtr_Init_Public_Virtual_Void_ContainerView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x00027118 File Offset: 0x00025318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116945, XrefRangeEnd = 1116948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override UnitView GetUnitView(EntityComponent entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FlavoredUnitViewProvider.NativeMethodInfoPtr_GetUnitView_Public_Virtual_UnitView_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnitView>(intPtr3) : null;
			}
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x00027174 File Offset: 0x00025374
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1116987, RefRangeEnd = 1116993, XrefRangeStart = 1116948, XrefRangeEnd = 1116987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnitView GetUnitView(EntityComponent entity, PrefabFlavorContext context, bool fallbackToDefault = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fallbackToDefault;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredUnitViewProvider.NativeMethodInfoPtr_GetUnitView_Public_UnitView_EntityComponent_PrefabFlavorContext_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnitView>(intPtr3) : null;
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x000271EC File Offset: 0x000253EC
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlavoredUnitViewProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlavoredUnitViewProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredUnitViewProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x00006598 File Offset: 0x00004798
		public FlavoredUnitViewProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x060008ED RID: 2285 RVA: 0x00027228 File Offset: 0x00025428
		// (set) Token: 0x060008EE RID: 2286 RVA: 0x000065A1 File Offset: 0x000047A1
		public unsafe PileFlavors pileFlavors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredUnitViewProvider.NativeFieldInfoPtr_pileFlavors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PileFlavors>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredUnitViewProvider.NativeFieldInfoPtr_pileFlavors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x060008EF RID: 2287 RVA: 0x00027258 File Offset: 0x00025458
		// (set) Token: 0x060008F0 RID: 2288 RVA: 0x000065C0 File Offset: 0x000047C0
		public unsafe PrefabByFlavorLoader prefabLoader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredUnitViewProvider.NativeFieldInfoPtr_prefabLoader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefabByFlavorLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredUnitViewProvider.NativeFieldInfoPtr_prefabLoader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000594 RID: 1428
		private static readonly IntPtr NativeFieldInfoPtr_pileFlavors;

		// Token: 0x04000595 RID: 1429
		private static readonly IntPtr NativeFieldInfoPtr_prefabLoader;

		// Token: 0x04000596 RID: 1430
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_ContainerView_0;

		// Token: 0x04000597 RID: 1431
		private static readonly IntPtr NativeMethodInfoPtr_GetUnitView_Public_Virtual_UnitView_EntityComponent_0;

		// Token: 0x04000598 RID: 1432
		private static readonly IntPtr NativeMethodInfoPtr_GetUnitView_Public_UnitView_EntityComponent_PrefabFlavorContext_Boolean_0;

		// Token: 0x04000599 RID: 1433
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000113 RID: 275
		[ObfuscatedName("boardgames.voodoo.FlavoredUnitViewProvider+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000E44 RID: 3652 RVA: 0x000372C4 File Offset: 0x000354C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FlavoredUnitViewProvider.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlavoredUnitViewProvider>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlavoredUnitViewProvider.__c>.NativeClassPtr);
				FlavoredUnitViewProvider.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlavoredUnitViewProvider.__c>.NativeClassPtr, "<>9");
				FlavoredUnitViewProvider.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlavoredUnitViewProvider.__c>.NativeClassPtr, "<>9__4_0");
				FlavoredUnitViewProvider.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredUnitViewProvider.__c>.NativeClassPtr, 100664589);
				FlavoredUnitViewProvider.__c.NativeMethodInfoPtr__GetUnitView_b__4_0_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredUnitViewProvider.__c>.NativeClassPtr, 100664590);
			}

			// Token: 0x06000E45 RID: 3653 RVA: 0x00037340 File Offset: 0x00035540
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlavoredUnitViewProvider.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredUnitViewProvider.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E46 RID: 3654 RVA: 0x0003737C File Offset: 0x0003557C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116935, XrefRangeEnd = 1116936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetUnitView_b__4_0(string _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredUnitViewProvider.__c.NativeMethodInfoPtr__GetUnitView_b__4_0_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000E47 RID: 3655 RVA: 0x00009191 File Offset: 0x00007391
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700044E RID: 1102
			// (get) Token: 0x06000E48 RID: 3656 RVA: 0x000373CC File Offset: 0x000355CC
			// (set) Token: 0x06000E49 RID: 3657 RVA: 0x0000919A File Offset: 0x0000739A
			public unsafe static FlavoredUnitViewProvider.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FlavoredUnitViewProvider.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlavoredUnitViewProvider.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FlavoredUnitViewProvider.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700044F RID: 1103
			// (get) Token: 0x06000E4A RID: 3658 RVA: 0x000373F4 File Offset: 0x000355F4
			// (set) Token: 0x06000E4B RID: 3659 RVA: 0x000091AC File Offset: 0x000073AC
			public unsafe static Func<string, bool> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FlavoredUnitViewProvider.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FlavoredUnitViewProvider.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040008DA RID: 2266
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040008DB RID: 2267
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x040008DC RID: 2268
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040008DD RID: 2269
			private static readonly IntPtr NativeMethodInfoPtr__GetUnitView_b__4_0_Internal_Boolean_String_0;
		}
	}
}
