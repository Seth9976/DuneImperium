using System;
using Canis.attributes;
using Canis.utils.ids;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using lib.canis.boardgames.src.match;

namespace worm.match.components.stingers
{
	// Token: 0x0200022E RID: 558
	public class WormStingerMultiCardInitializer : WormStingerContainerInitializer
	{
		// Token: 0x06001858 RID: 6232 RVA: 0x00061FCC File Offset: 0x000601CC
		// Note: this type is marked as 'beforefieldinit'.
		static WormStingerMultiCardInitializer()
		{
			Il2CppClassPointerStore<WormStingerMultiCardInitializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components.stingers", "WormStingerMultiCardInitializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormStingerMultiCardInitializer>.NativeClassPtr);
			WormStingerMultiCardInitializer.NativeFieldInfoPtr_archetypeProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormStingerMultiCardInitializer>.NativeClassPtr, "archetypeProvider");
			WormStingerMultiCardInitializer.NativeMethodInfoPtr_InitViews_Public_Virtual_Void_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStingerMultiCardInitializer>.NativeClassPtr, 100666664);
			WormStingerMultiCardInitializer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStingerMultiCardInitializer>.NativeClassPtr, 100666665);
			WormStingerMultiCardInitializer.NativeMethodInfoPtr__InitViews_b__1_0_Private_EntityComponent_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStingerMultiCardInitializer>.NativeClassPtr, 100666666);
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x0006204C File Offset: 0x0006024C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718296, XrefRangeEnd = 718341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitViews(IHasAttributes attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormStingerMultiCardInitializer.NativeMethodInfoPtr_InitViews_Public_Virtual_Void_IHasAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x0006209C File Offset: 0x0006029C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormStingerMultiCardInitializer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormStingerMultiCardInitializer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormStingerMultiCardInitializer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x000620D8 File Offset: 0x000602D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718341, XrefRangeEnd = 718343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityComponent _InitViews_b__1_0(ArchetypeID a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormStingerMultiCardInitializer.NativeMethodInfoPtr__InitViews_b__1_0_Private_EntityComponent_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
			}
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x0000E710 File Offset: 0x0000C910
		public WormStingerMultiCardInitializer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x0600185D RID: 6237 RVA: 0x00062128 File Offset: 0x00060328
		// (set) Token: 0x0600185E RID: 6238 RVA: 0x0000E719 File Offset: 0x0000C919
		public unsafe ArchetypeProvider archetypeProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormStingerMultiCardInitializer.NativeFieldInfoPtr_archetypeProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormStingerMultiCardInitializer.NativeFieldInfoPtr_archetypeProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E1C RID: 3612
		private static readonly IntPtr NativeFieldInfoPtr_archetypeProvider;

		// Token: 0x04000E1D RID: 3613
		private static readonly IntPtr NativeMethodInfoPtr_InitViews_Public_Virtual_Void_IHasAttributes_0;

		// Token: 0x04000E1E RID: 3614
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000E1F RID: 3615
		private static readonly IntPtr NativeMethodInfoPtr__InitViews_b__1_0_Private_EntityComponent_ArchetypeID_0;

		// Token: 0x02000403 RID: 1027
		[ObfuscatedName("worm.match.components.stingers.WormStingerMultiCardInitializer+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002A10 RID: 10768 RVA: 0x00097778 File Offset: 0x00095978
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormStingerMultiCardInitializer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormStingerMultiCardInitializer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormStingerMultiCardInitializer.__c>.NativeClassPtr);
				WormStingerMultiCardInitializer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormStingerMultiCardInitializer.__c>.NativeClassPtr, "<>9");
				WormStingerMultiCardInitializer.__c.NativeFieldInfoPtr___9__1_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormStingerMultiCardInitializer.__c>.NativeClassPtr, "<>9__1_1");
				WormStingerMultiCardInitializer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStingerMultiCardInitializer.__c>.NativeClassPtr, 100666668);
				WormStingerMultiCardInitializer.__c.NativeMethodInfoPtr__InitViews_b__1_1_Internal_Int32_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStingerMultiCardInitializer.__c>.NativeClassPtr, 100666669);
			}

			// Token: 0x06002A11 RID: 10769 RVA: 0x000977F4 File Offset: 0x000959F4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormStingerMultiCardInitializer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormStingerMultiCardInitializer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A12 RID: 10770 RVA: 0x00097830 File Offset: 0x00095A30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718288, XrefRangeEnd = 718296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _InitViews_b__1_1(EntityComponent a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormStingerMultiCardInitializer.__c.NativeMethodInfoPtr__InitViews_b__1_1_Internal_Int32_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002A13 RID: 10771 RVA: 0x00017068 File Offset: 0x00015268
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BE9 RID: 3049
			// (get) Token: 0x06002A14 RID: 10772 RVA: 0x00097880 File Offset: 0x00095A80
			// (set) Token: 0x06002A15 RID: 10773 RVA: 0x00017071 File Offset: 0x00015271
			public unsafe static WormStingerMultiCardInitializer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormStingerMultiCardInitializer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormStingerMultiCardInitializer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormStingerMultiCardInitializer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BEA RID: 3050
			// (get) Token: 0x06002A16 RID: 10774 RVA: 0x000978A8 File Offset: 0x00095AA8
			// (set) Token: 0x06002A17 RID: 10775 RVA: 0x00017083 File Offset: 0x00015283
			public unsafe static Func<EntityComponent, int> __9__1_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormStingerMultiCardInitializer.__c.NativeFieldInfoPtr___9__1_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormStingerMultiCardInitializer.__c.NativeFieldInfoPtr___9__1_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001865 RID: 6245
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001866 RID: 6246
			private static readonly IntPtr NativeFieldInfoPtr___9__1_1;

			// Token: 0x04001867 RID: 6247
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001868 RID: 6248
			private static readonly IntPtr NativeMethodInfoPtr__InitViews_b__1_1_Internal_Int32_EntityComponent_0;
		}
	}
}
