using System;
using Canis.attributes;
using dwd.core.data.composition;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace worm.match.data
{
	// Token: 0x0200019D RID: 413
	public class WormRestrictedOrdnanceData : VersionedDataComponent
	{
		// Token: 0x06001263 RID: 4707 RVA: 0x0004FC0C File Offset: 0x0004DE0C
		// Note: this type is marked as 'beforefieldinit'.
		static WormRestrictedOrdnanceData()
		{
			Il2CppClassPointerStore<WormRestrictedOrdnanceData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.data", "WormRestrictedOrdnanceData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormRestrictedOrdnanceData>.NativeClassPtr);
			WormRestrictedOrdnanceData.NativeFieldInfoPtr_highCouncilAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRestrictedOrdnanceData>.NativeClassPtr, "highCouncilAttribute");
			WormRestrictedOrdnanceData.NativeFieldInfoPtr_techTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRestrictedOrdnanceData>.NativeClassPtr, "techTiles");
			WormRestrictedOrdnanceData.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRestrictedOrdnanceData>.NativeClassPtr, "player");
			WormRestrictedOrdnanceData.NativeMethodInfoPtr_get_HasHighCouncilSeat_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRestrictedOrdnanceData>.NativeClassPtr, 100665803);
			WormRestrictedOrdnanceData.NativeMethodInfoPtr_get_HasRestrictedOrdnance_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRestrictedOrdnanceData>.NativeClassPtr, 100665804);
			WormRestrictedOrdnanceData.NativeMethodInfoPtr__ctor_Public_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRestrictedOrdnanceData>.NativeClassPtr, 100665805);
			WormRestrictedOrdnanceData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRestrictedOrdnanceData>.NativeClassPtr, 100665806);
			WormRestrictedOrdnanceData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRestrictedOrdnanceData>.NativeClassPtr, 100665807);
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06001264 RID: 4708 RVA: 0x0004FCDC File Offset: 0x0004DEDC
		public unsafe bool HasHighCouncilSeat
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711997, XrefRangeEnd = 712003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRestrictedOrdnanceData.NativeMethodInfoPtr_get_HasHighCouncilSeat_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06001265 RID: 4709 RVA: 0x0004FD18 File Offset: 0x0004DF18
		public unsafe bool HasRestrictedOrdnance
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 712039, RefRangeEnd = 712041, XrefRangeStart = 712003, XrefRangeEnd = 712039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRestrictedOrdnanceData.NativeMethodInfoPtr_get_HasRestrictedOrdnance_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x0004FD54 File Offset: 0x0004DF54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 712049, RefRangeEnd = 712050, XrefRangeStart = 712041, XrefRangeEnd = 712049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormRestrictedOrdnanceData(EntityComponent ec)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormRestrictedOrdnanceData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ec);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRestrictedOrdnanceData.NativeMethodInfoPtr__ctor_Public_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06001267 RID: 4711 RVA: 0x0004FDA0 File Offset: 0x0004DFA0
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712050, XrefRangeEnd = 712073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormRestrictedOrdnanceData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x0004FDE8 File Offset: 0x0004DFE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712073, XrefRangeEnd = 712090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormRestrictedOrdnanceData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x0000B915 File Offset: 0x00009B15
		public WormRestrictedOrdnanceData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x0600126A RID: 4714 RVA: 0x0004FE2C File Offset: 0x0004E02C
		// (set) Token: 0x0600126B RID: 4715 RVA: 0x0000B91E File Offset: 0x00009B1E
		public unsafe IAttribute<Nullable<bool>> highCouncilAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRestrictedOrdnanceData.NativeFieldInfoPtr_highCouncilAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRestrictedOrdnanceData.NativeFieldInfoPtr_highCouncilAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x0600126C RID: 4716 RVA: 0x0004FE5C File Offset: 0x0004E05C
		// (set) Token: 0x0600126D RID: 4717 RVA: 0x0000B93D File Offset: 0x00009B3D
		public unsafe ReadOnlyVersionedList<EntityComponent> techTiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRestrictedOrdnanceData.NativeFieldInfoPtr_techTiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyVersionedList<EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRestrictedOrdnanceData.NativeFieldInfoPtr_techTiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x0600126E RID: 4718 RVA: 0x0004FE8C File Offset: 0x0004E08C
		// (set) Token: 0x0600126F RID: 4719 RVA: 0x0000B95C File Offset: 0x00009B5C
		public unsafe EntityComponent player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRestrictedOrdnanceData.NativeFieldInfoPtr_player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRestrictedOrdnanceData.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AA4 RID: 2724
		private static readonly IntPtr NativeFieldInfoPtr_highCouncilAttribute;

		// Token: 0x04000AA5 RID: 2725
		private static readonly IntPtr NativeFieldInfoPtr_techTiles;

		// Token: 0x04000AA6 RID: 2726
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x04000AA7 RID: 2727
		private static readonly IntPtr NativeMethodInfoPtr_get_HasHighCouncilSeat_Public_get_Boolean_0;

		// Token: 0x04000AA8 RID: 2728
		private static readonly IntPtr NativeMethodInfoPtr_get_HasRestrictedOrdnance_Public_get_Boolean_0;

		// Token: 0x04000AA9 RID: 2729
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityComponent_0;

		// Token: 0x04000AAA RID: 2730
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;

		// Token: 0x04000AAB RID: 2731
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x020003BE RID: 958
		[ObfuscatedName("worm.match.data.WormRestrictedOrdnanceData+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060026A6 RID: 9894 RVA: 0x0008D6C0 File Offset: 0x0008B8C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormRestrictedOrdnanceData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormRestrictedOrdnanceData>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormRestrictedOrdnanceData.__c>.NativeClassPtr);
				WormRestrictedOrdnanceData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRestrictedOrdnanceData.__c>.NativeClassPtr, "<>9");
				WormRestrictedOrdnanceData.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRestrictedOrdnanceData.__c>.NativeClassPtr, "<>9__5_0");
				WormRestrictedOrdnanceData.__c.NativeFieldInfoPtr___9__5_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRestrictedOrdnanceData.__c>.NativeClassPtr, "<>9__5_1");
				WormRestrictedOrdnanceData.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRestrictedOrdnanceData.__c>.NativeClassPtr, "<>9__9_0");
				WormRestrictedOrdnanceData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRestrictedOrdnanceData.__c>.NativeClassPtr, 100665809);
				WormRestrictedOrdnanceData.__c.NativeMethodInfoPtr__get_HasRestrictedOrdnance_b__5_0_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRestrictedOrdnanceData.__c>.NativeClassPtr, 100665810);
				WormRestrictedOrdnanceData.__c.NativeMethodInfoPtr__get_HasRestrictedOrdnance_b__5_1_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRestrictedOrdnanceData.__c>.NativeClassPtr, 100665811);
				WormRestrictedOrdnanceData.__c.NativeMethodInfoPtr__get_Version_b__9_0_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRestrictedOrdnanceData.__c>.NativeClassPtr, 100665812);
			}

			// Token: 0x060026A7 RID: 9895 RVA: 0x0008D78C File Offset: 0x0008B98C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormRestrictedOrdnanceData.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRestrictedOrdnanceData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060026A8 RID: 9896 RVA: 0x0008D7C8 File Offset: 0x0008B9C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711964, XrefRangeEnd = 711971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_HasRestrictedOrdnance_b__5_0(EntityComponent child)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRestrictedOrdnanceData.__c.NativeMethodInfoPtr__get_HasRestrictedOrdnance_b__5_0_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060026A9 RID: 9897 RVA: 0x0008D818 File Offset: 0x0008BA18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711971, XrefRangeEnd = 711990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_HasRestrictedOrdnance_b__5_1(EntityComponent child)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRestrictedOrdnanceData.__c.NativeMethodInfoPtr__get_HasRestrictedOrdnance_b__5_1_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060026AA RID: 9898 RVA: 0x0008D868 File Offset: 0x0008BA68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711990, XrefRangeEnd = 711997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_Version_b__9_0(EntityComponent child)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRestrictedOrdnanceData.__c.NativeMethodInfoPtr__get_Version_b__9_0_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060026AB RID: 9899 RVA: 0x0001552C File Offset: 0x0001372C
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000ABB RID: 2747
			// (get) Token: 0x060026AC RID: 9900 RVA: 0x0008D8B8 File Offset: 0x0008BAB8
			// (set) Token: 0x060026AD RID: 9901 RVA: 0x00015535 File Offset: 0x00013735
			public unsafe static WormRestrictedOrdnanceData.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormRestrictedOrdnanceData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormRestrictedOrdnanceData.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormRestrictedOrdnanceData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000ABC RID: 2748
			// (get) Token: 0x060026AE RID: 9902 RVA: 0x0008D8E0 File Offset: 0x0008BAE0
			// (set) Token: 0x060026AF RID: 9903 RVA: 0x00015547 File Offset: 0x00013747
			public unsafe static Func<EntityComponent, bool> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormRestrictedOrdnanceData.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormRestrictedOrdnanceData.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000ABD RID: 2749
			// (get) Token: 0x060026B0 RID: 9904 RVA: 0x0008D908 File Offset: 0x0008BB08
			// (set) Token: 0x060026B1 RID: 9905 RVA: 0x00015559 File Offset: 0x00013759
			public unsafe static Func<EntityComponent, bool> __9__5_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormRestrictedOrdnanceData.__c.NativeFieldInfoPtr___9__5_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormRestrictedOrdnanceData.__c.NativeFieldInfoPtr___9__5_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000ABE RID: 2750
			// (get) Token: 0x060026B2 RID: 9906 RVA: 0x0008D930 File Offset: 0x0008BB30
			// (set) Token: 0x060026B3 RID: 9907 RVA: 0x0001556B File Offset: 0x0001376B
			public unsafe static Func<EntityComponent, bool> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormRestrictedOrdnanceData.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormRestrictedOrdnanceData.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001640 RID: 5696
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001641 RID: 5697
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04001642 RID: 5698
			private static readonly IntPtr NativeFieldInfoPtr___9__5_1;

			// Token: 0x04001643 RID: 5699
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x04001644 RID: 5700
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001645 RID: 5701
			private static readonly IntPtr NativeMethodInfoPtr__get_HasRestrictedOrdnance_b__5_0_Internal_Boolean_EntityComponent_0;

			// Token: 0x04001646 RID: 5702
			private static readonly IntPtr NativeMethodInfoPtr__get_HasRestrictedOrdnance_b__5_1_Internal_Boolean_EntityComponent_0;

			// Token: 0x04001647 RID: 5703
			private static readonly IntPtr NativeMethodInfoPtr__get_Version_b__9_0_Internal_Boolean_EntityComponent_0;
		}
	}
}
