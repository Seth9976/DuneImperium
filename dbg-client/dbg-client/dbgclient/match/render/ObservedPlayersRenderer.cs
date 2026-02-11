using System;
using boardgames.match.behaviours;
using Canis.utils.ids;
using dwd.core.data.composition;
using dwd.core.match;
using dwd.core.prefabs.prefabProvider;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dbgclient.match.render
{
	// Token: 0x020000A6 RID: 166
	public class ObservedPlayersRenderer : VersionedView<ObserversProvider>
	{
		// Token: 0x06000683 RID: 1667 RVA: 0x00032414 File Offset: 0x00030614
		// Note: this type is marked as 'beforefieldinit'.
		static ObservedPlayersRenderer()
		{
			Il2CppClassPointerStore<ObservedPlayersRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.match.render", "ObservedPlayersRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObservedPlayersRenderer>.NativeClassPtr);
			ObservedPlayersRenderer.NativeFieldInfoPtr_providerInstantiator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObservedPlayersRenderer>.NativeClassPtr, "providerInstantiator");
			ObservedPlayersRenderer.NativeFieldInfoPtr_dbgEntitiesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObservedPlayersRenderer>.NativeClassPtr, "dbgEntitiesProvider");
			ObservedPlayersRenderer.NativeFieldInfoPtr_playerDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObservedPlayersRenderer>.NativeClassPtr, "playerDatas");
			ObservedPlayersRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObservedPlayersRenderer>.NativeClassPtr, 100664327);
			ObservedPlayersRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObservedPlayersRenderer>.NativeClassPtr, 100664328);
			ObservedPlayersRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObservedPlayersRenderer>.NativeClassPtr, 100664329);
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x000324BC File Offset: 0x000306BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503415, XrefRangeEnd = 503427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObservedPlayersRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x000324F8 File Offset: 0x000306F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503427, XrefRangeEnd = 503560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObservedPlayersRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x00032534 File Offset: 0x00030734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503560, XrefRangeEnd = 503570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObservedPlayersRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObservedPlayersRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObservedPlayersRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x00004EF7 File Offset: 0x000030F7
		public ObservedPlayersRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000688 RID: 1672 RVA: 0x00032570 File Offset: 0x00030770
		// (set) Token: 0x06000689 RID: 1673 RVA: 0x00004F00 File Offset: 0x00003100
		public unsafe ProviderInstantiator providerInstantiator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObservedPlayersRenderer.NativeFieldInfoPtr_providerInstantiator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProviderInstantiator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObservedPlayersRenderer.NativeFieldInfoPtr_providerInstantiator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x0600068A RID: 1674 RVA: 0x000325A0 File Offset: 0x000307A0
		// (set) Token: 0x0600068B RID: 1675 RVA: 0x00004F1F File Offset: 0x0000311F
		public unsafe DBGEntitiesProvider dbgEntitiesProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObservedPlayersRenderer.NativeFieldInfoPtr_dbgEntitiesProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObservedPlayersRenderer.NativeFieldInfoPtr_dbgEntitiesProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x0600068C RID: 1676 RVA: 0x000325D0 File Offset: 0x000307D0
		// (set) Token: 0x0600068D RID: 1677 RVA: 0x00004F3E File Offset: 0x0000313E
		public unsafe VersionedList<DataComposition> playerDatas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObservedPlayersRenderer.NativeFieldInfoPtr_playerDatas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VersionedList<DataComposition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObservedPlayersRenderer.NativeFieldInfoPtr_playerDatas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000404 RID: 1028
		private static readonly IntPtr NativeFieldInfoPtr_providerInstantiator;

		// Token: 0x04000405 RID: 1029
		private static readonly IntPtr NativeFieldInfoPtr_dbgEntitiesProvider;

		// Token: 0x04000406 RID: 1030
		private static readonly IntPtr NativeFieldInfoPtr_playerDatas;

		// Token: 0x04000407 RID: 1031
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x04000408 RID: 1032
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000409 RID: 1033
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000315 RID: 789
		[ObfuscatedName("dbgclient.match.render.ObservedPlayersRenderer+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600255B RID: 9563 RVA: 0x00098364 File Offset: 0x00096564
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ObservedPlayersRenderer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObservedPlayersRenderer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObservedPlayersRenderer.__c>.NativeClassPtr);
				ObservedPlayersRenderer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObservedPlayersRenderer.__c>.NativeClassPtr, "<>9");
				ObservedPlayersRenderer.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObservedPlayersRenderer.__c>.NativeClassPtr, "<>9__4_0");
				ObservedPlayersRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObservedPlayersRenderer.__c>.NativeClassPtr, 100664331);
				ObservedPlayersRenderer.__c.NativeMethodInfoPtr__dirtyUpdate_b__4_0_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObservedPlayersRenderer.__c>.NativeClassPtr, 100664332);
			}

			// Token: 0x0600255C RID: 9564 RVA: 0x000983E0 File Offset: 0x000965E0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObservedPlayersRenderer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObservedPlayersRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600255D RID: 9565 RVA: 0x0009841C File Offset: 0x0009661C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503393, XrefRangeEnd = 503399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _dirtyUpdate_b__4_0(EntityComponent ec)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ec);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObservedPlayersRenderer.__c.NativeMethodInfoPtr__dirtyUpdate_b__4_0_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600255E RID: 9566 RVA: 0x0001367A File Offset: 0x0001187A
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A4A RID: 2634
			// (get) Token: 0x0600255F RID: 9567 RVA: 0x0009846C File Offset: 0x0009666C
			// (set) Token: 0x06002560 RID: 9568 RVA: 0x00013683 File Offset: 0x00011883
			public unsafe static ObservedPlayersRenderer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ObservedPlayersRenderer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObservedPlayersRenderer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ObservedPlayersRenderer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A4B RID: 2635
			// (get) Token: 0x06002561 RID: 9569 RVA: 0x00098494 File Offset: 0x00096694
			// (set) Token: 0x06002562 RID: 9570 RVA: 0x00013695 File Offset: 0x00011895
			public unsafe static Func<EntityComponent, bool> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ObservedPlayersRenderer.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ObservedPlayersRenderer.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001775 RID: 6005
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001776 RID: 6006
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x04001777 RID: 6007
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001778 RID: 6008
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__4_0_Internal_Boolean_EntityComponent_0;
		}

		// Token: 0x02000316 RID: 790
		[ObfuscatedName("dbgclient.match.render.ObservedPlayersRenderer+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x06002563 RID: 9571 RVA: 0x000984BC File Offset: 0x000966BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<ObservedPlayersRenderer.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObservedPlayersRenderer>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObservedPlayersRenderer.__c__DisplayClass4_0>.NativeClassPtr);
				ObservedPlayersRenderer.__c__DisplayClass4_0.NativeFieldInfoPtr_accountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObservedPlayersRenderer.__c__DisplayClass4_0>.NativeClassPtr, "accountID");
				ObservedPlayersRenderer.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObservedPlayersRenderer.__c__DisplayClass4_0>.NativeClassPtr, 100664333);
				ObservedPlayersRenderer.__c__DisplayClass4_0.NativeMethodInfoPtr__dirtyUpdate_b__1_Internal_Boolean_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObservedPlayersRenderer.__c__DisplayClass4_0>.NativeClassPtr, 100664334);
				ObservedPlayersRenderer.__c__DisplayClass4_0.NativeMethodInfoPtr__dirtyUpdate_b__2_Internal_Boolean_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObservedPlayersRenderer.__c__DisplayClass4_0>.NativeClassPtr, 100664335);
			}

			// Token: 0x06002564 RID: 9572 RVA: 0x00098538 File Offset: 0x00096738
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObservedPlayersRenderer.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObservedPlayersRenderer.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002565 RID: 9573 RVA: 0x00098574 File Offset: 0x00096774
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503399, XrefRangeEnd = 503407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _dirtyUpdate_b__1(DataComposition pd)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(pd);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObservedPlayersRenderer.__c__DisplayClass4_0.NativeMethodInfoPtr__dirtyUpdate_b__1_Internal_Boolean_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002566 RID: 9574 RVA: 0x000985C4 File Offset: 0x000967C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503407, XrefRangeEnd = 503415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _dirtyUpdate_b__2(DataComposition pd)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(pd);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObservedPlayersRenderer.__c__DisplayClass4_0.NativeMethodInfoPtr__dirtyUpdate_b__2_Internal_Boolean_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002567 RID: 9575 RVA: 0x000136A7 File Offset: 0x000118A7
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A4C RID: 2636
			// (get) Token: 0x06002568 RID: 9576 RVA: 0x00098614 File Offset: 0x00096814
			// (set) Token: 0x06002569 RID: 9577 RVA: 0x000136B0 File Offset: 0x000118B0
			public unsafe AccountID accountID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObservedPlayersRenderer.__c__DisplayClass4_0.NativeFieldInfoPtr_accountID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObservedPlayersRenderer.__c__DisplayClass4_0.NativeFieldInfoPtr_accountID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001779 RID: 6009
			private static readonly IntPtr NativeFieldInfoPtr_accountID;

			// Token: 0x0400177A RID: 6010
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400177B RID: 6011
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__1_Internal_Boolean_DataComposition_0;

			// Token: 0x0400177C RID: 6012
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__2_Internal_Boolean_DataComposition_0;
		}
	}
}
