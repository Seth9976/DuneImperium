using System;
using Canis;
using Canis.entities;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace worm.canis.abilities
{
	// Token: 0x0200031C RID: 796
	public class WormAbilityFactory : EntityFactory<AbilityID, AbilityDefinitionForGame<WormMatch>>
	{
		// Token: 0x06002078 RID: 8312 RVA: 0x000D85AC File Offset: 0x000D67AC
		// Note: this type is marked as 'beforefieldinit'.
		static WormAbilityFactory()
		{
			Il2CppClassPointerStore<WormAbilityFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities", "WormAbilityFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAbilityFactory>.NativeClassPtr);
			WormAbilityFactory.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAbilityFactory>.NativeClassPtr, "initialized");
			WormAbilityFactory.NativeMethodInfoPtr_initializeEntities_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityFactory>.NativeClassPtr, 100671238);
			WormAbilityFactory.NativeMethodInfoPtr_Configure_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityFactory>.NativeClassPtr, 100671239);
			WormAbilityFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityFactory>.NativeClassPtr, 100671240);
		}

		// Token: 0x06002079 RID: 8313 RVA: 0x000D862C File Offset: 0x000D682C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176030, XrefRangeEnd = 176071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initializeEntities()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAbilityFactory.NativeMethodInfoPtr_initializeEntities_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600207A RID: 8314 RVA: 0x000D8668 File Offset: 0x000D6868
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 176077, RefRangeEnd = 176078, XrefRangeStart = 176071, XrefRangeEnd = 176077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Configure()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAbilityFactory.NativeMethodInfoPtr_Configure_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600207B RID: 8315 RVA: 0x000D869C File Offset: 0x000D689C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 176081, RefRangeEnd = 176083, XrefRangeStart = 176078, XrefRangeEnd = 176081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormAbilityFactory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAbilityFactory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAbilityFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600207C RID: 8316 RVA: 0x0000D666 File Offset: 0x0000B866
		public WormAbilityFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x0600207D RID: 8317 RVA: 0x000D86D8 File Offset: 0x000D68D8
		// (set) Token: 0x0600207E RID: 8318 RVA: 0x0000D66F File Offset: 0x0000B86F
		public unsafe bool initialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityFactory.NativeFieldInfoPtr_initialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityFactory.NativeFieldInfoPtr_initialized)) = value;
			}
		}

		// Token: 0x0400147C RID: 5244
		private static readonly IntPtr NativeFieldInfoPtr_initialized;

		// Token: 0x0400147D RID: 5245
		private static readonly IntPtr NativeMethodInfoPtr_initializeEntities_Protected_Virtual_Void_0;

		// Token: 0x0400147E RID: 5246
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Void_0;

		// Token: 0x0400147F RID: 5247
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007DA RID: 2010
		[ObfuscatedName("worm.canis.abilities.WormAbilityFactory+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060071B4 RID: 29108 RVA: 0x00210068 File Offset: 0x0020E268
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormAbilityFactory.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAbilityFactory>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAbilityFactory.__c>.NativeClassPtr);
				WormAbilityFactory.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAbilityFactory.__c>.NativeClassPtr, "<>9");
				WormAbilityFactory.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAbilityFactory.__c>.NativeClassPtr, "<>9__1_0");
				WormAbilityFactory.__c.NativeFieldInfoPtr___9__1_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAbilityFactory.__c>.NativeClassPtr, "<>9__1_1");
				WormAbilityFactory.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityFactory.__c>.NativeClassPtr, 100671242);
				WormAbilityFactory.__c.NativeMethodInfoPtr__initializeEntities_b__1_0_Internal_AbilityDefinitionForGame_1_WormMatch_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityFactory.__c>.NativeClassPtr, 100671243);
				WormAbilityFactory.__c.NativeMethodInfoPtr__initializeEntities_b__1_1_Internal_AbilityDefinitionForGame_1_WormMatch_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityFactory.__c>.NativeClassPtr, 100671244);
			}

			// Token: 0x060071B5 RID: 29109 RVA: 0x0021010C File Offset: 0x0020E30C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAbilityFactory.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAbilityFactory.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060071B6 RID: 29110 RVA: 0x00210148 File Offset: 0x0020E348
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176014, XrefRangeEnd = 176022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AbilityDefinitionForGame<WormMatch> _initializeEntities_b__1_0(Match m)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAbilityFactory.__c.NativeMethodInfoPtr__initializeEntities_b__1_0_Internal_AbilityDefinitionForGame_1_WormMatch_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityDefinitionForGame<WormMatch>>(intPtr3) : null;
				}
			}

			// Token: 0x060071B7 RID: 29111 RVA: 0x00210198 File Offset: 0x0020E398
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176022, XrefRangeEnd = 176030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AbilityDefinitionForGame<WormMatch> _initializeEntities_b__1_1(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAbilityFactory.__c.NativeMethodInfoPtr__initializeEntities_b__1_1_Internal_AbilityDefinitionForGame_1_WormMatch_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityDefinitionForGame<WormMatch>>(intPtr3) : null;
			}

			// Token: 0x060071B8 RID: 29112 RVA: 0x0002D2AD File Offset: 0x0002B4AD
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001F44 RID: 8004
			// (get) Token: 0x060071B9 RID: 29113 RVA: 0x0021020C File Offset: 0x0020E40C
			// (set) Token: 0x060071BA RID: 29114 RVA: 0x0002D2B6 File Offset: 0x0002B4B6
			public unsafe static WormAbilityFactory.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAbilityFactory.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAbilityFactory.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAbilityFactory.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001F45 RID: 8005
			// (get) Token: 0x060071BB RID: 29115 RVA: 0x00210234 File Offset: 0x0020E434
			// (set) Token: 0x060071BC RID: 29116 RVA: 0x0002D2C8 File Offset: 0x0002B4C8
			public unsafe static Func<Match, AbilityDefinitionForGame<WormMatch>> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAbilityFactory.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Match, AbilityDefinitionForGame<WormMatch>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAbilityFactory.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001F46 RID: 8006
			// (get) Token: 0x060071BD RID: 29117 RVA: 0x0021025C File Offset: 0x0020E45C
			// (set) Token: 0x060071BE RID: 29118 RVA: 0x0002D2DA File Offset: 0x0002B4DA
			public unsafe static Func<SerializedEntity, Match, Entity, AbilityDefinitionForGame<WormMatch>> __9__1_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAbilityFactory.__c.NativeFieldInfoPtr___9__1_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SerializedEntity, Match, Entity, AbilityDefinitionForGame<WormMatch>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAbilityFactory.__c.NativeFieldInfoPtr___9__1_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004973 RID: 18803
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04004974 RID: 18804
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04004975 RID: 18805
			private static readonly IntPtr NativeFieldInfoPtr___9__1_1;

			// Token: 0x04004976 RID: 18806
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004977 RID: 18807
			private static readonly IntPtr NativeMethodInfoPtr__initializeEntities_b__1_0_Internal_AbilityDefinitionForGame_1_WormMatch_Match_0;

			// Token: 0x04004978 RID: 18808
			private static readonly IntPtr NativeMethodInfoPtr__initializeEntities_b__1_1_Internal_AbilityDefinitionForGame_1_WormMatch_SerializedEntity_Match_Entity_0;
		}
	}
}
