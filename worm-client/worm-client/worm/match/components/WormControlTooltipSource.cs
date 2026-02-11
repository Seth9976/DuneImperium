using System;
using boardgames.match.behaviours;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lotus;

namespace worm.match.components
{
	// Token: 0x020001E0 RID: 480
	public class WormControlTooltipSource : VersionedView<ReadOnlyVersionedList<EntityComponent>>
	{
		// Token: 0x06001534 RID: 5428 RVA: 0x00058780 File Offset: 0x00056980
		// Note: this type is marked as 'beforefieldinit'.
		static WormControlTooltipSource()
		{
			Il2CppClassPointerStore<WormControlTooltipSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormControlTooltipSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormControlTooltipSource>.NativeClassPtr);
			WormControlTooltipSource.NativeFieldInfoPtr_entitiesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormControlTooltipSource>.NativeClassPtr, "entitiesProvider");
			WormControlTooltipSource.NativeFieldInfoPtr_tooltipKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormControlTooltipSource>.NativeClassPtr, "tooltipKey");
			WormControlTooltipSource.NativeFieldInfoPtr_playerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormControlTooltipSource>.NativeClassPtr, "playerName");
			WormControlTooltipSource.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormControlTooltipSource>.NativeClassPtr, 100666219);
			WormControlTooltipSource.NativeMethodInfoPtr_Init_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormControlTooltipSource>.NativeClassPtr, 100666220);
			WormControlTooltipSource.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormControlTooltipSource>.NativeClassPtr, 100666221);
			WormControlTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormControlTooltipSource>.NativeClassPtr, 100666222);
			WormControlTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormControlTooltipSource>.NativeClassPtr, 100666223);
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x00058850 File Offset: 0x00056A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715011, XrefRangeEnd = 715020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormControlTooltipSource.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x0005888C File Offset: 0x00056A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715020, XrefRangeEnd = 715025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormControlTooltipSource.NativeMethodInfoPtr_Init_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x000588CC File Offset: 0x00056ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715025, XrefRangeEnd = 715065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormControlTooltipSource.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x00058908 File Offset: 0x00056B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715065, XrefRangeEnd = 715070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetLocalizedTooltip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormControlTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x00058940 File Offset: 0x00056B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715070, XrefRangeEnd = 715078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormControlTooltipSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormControlTooltipSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormControlTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x0000CE73 File Offset: 0x0000B073
		public WormControlTooltipSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x0600153B RID: 5435 RVA: 0x0005897C File Offset: 0x00056B7C
		// (set) Token: 0x0600153C RID: 5436 RVA: 0x0000CE7C File Offset: 0x0000B07C
		public unsafe DBGEntitiesProvider entitiesProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormControlTooltipSource.NativeFieldInfoPtr_entitiesProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormControlTooltipSource.NativeFieldInfoPtr_entitiesProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x0600153D RID: 5437 RVA: 0x000589AC File Offset: 0x00056BAC
		// (set) Token: 0x0600153E RID: 5438 RVA: 0x0000CE9B File Offset: 0x0000B09B
		public unsafe string tooltipKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormControlTooltipSource.NativeFieldInfoPtr_tooltipKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormControlTooltipSource.NativeFieldInfoPtr_tooltipKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x0600153F RID: 5439 RVA: 0x000589D4 File Offset: 0x00056BD4
		// (set) Token: 0x06001540 RID: 5440 RVA: 0x0000CEBA File Offset: 0x0000B0BA
		public unsafe string playerName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormControlTooltipSource.NativeFieldInfoPtr_playerName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormControlTooltipSource.NativeFieldInfoPtr_playerName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000C4B RID: 3147
		private static readonly IntPtr NativeFieldInfoPtr_entitiesProvider;

		// Token: 0x04000C4C RID: 3148
		private static readonly IntPtr NativeFieldInfoPtr_tooltipKey;

		// Token: 0x04000C4D RID: 3149
		private static readonly IntPtr NativeFieldInfoPtr_playerName;

		// Token: 0x04000C4E RID: 3150
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000C4F RID: 3151
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_IEnumerator_0;

		// Token: 0x04000C50 RID: 3152
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000C51 RID: 3153
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0;

		// Token: 0x04000C52 RID: 3154
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003E0 RID: 992
		[ObfuscatedName("worm.match.components.WormControlTooltipSource+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002848 RID: 10312 RVA: 0x00092348 File Offset: 0x00090548
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormControlTooltipSource.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormControlTooltipSource>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormControlTooltipSource.__c>.NativeClassPtr);
				WormControlTooltipSource.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormControlTooltipSource.__c>.NativeClassPtr, "<>9");
				WormControlTooltipSource.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormControlTooltipSource.__c>.NativeClassPtr, "<>9__5_0");
				WormControlTooltipSource.__c.NativeFieldInfoPtr___9__5_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormControlTooltipSource.__c>.NativeClassPtr, "<>9__5_1");
				WormControlTooltipSource.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormControlTooltipSource.__c>.NativeClassPtr, 100666225);
				WormControlTooltipSource.__c.NativeMethodInfoPtr__dirtyUpdate_b__5_0_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormControlTooltipSource.__c>.NativeClassPtr, 100666226);
				WormControlTooltipSource.__c.NativeMethodInfoPtr__dirtyUpdate_b__5_1_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormControlTooltipSource.__c>.NativeClassPtr, 100666227);
			}

			// Token: 0x06002849 RID: 10313 RVA: 0x000923EC File Offset: 0x000905EC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormControlTooltipSource.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormControlTooltipSource.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600284A RID: 10314 RVA: 0x00092428 File Offset: 0x00090628
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714988, XrefRangeEnd = 714995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _dirtyUpdate_b__5_0(EntityComponent child)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormControlTooltipSource.__c.NativeMethodInfoPtr__dirtyUpdate_b__5_0_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600284B RID: 10315 RVA: 0x00092478 File Offset: 0x00090678
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714995, XrefRangeEnd = 715002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _dirtyUpdate_b__5_1(EntityComponent child)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormControlTooltipSource.__c.NativeMethodInfoPtr__dirtyUpdate_b__5_1_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600284C RID: 10316 RVA: 0x000161A9 File Offset: 0x000143A9
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B46 RID: 2886
			// (get) Token: 0x0600284D RID: 10317 RVA: 0x000924C8 File Offset: 0x000906C8
			// (set) Token: 0x0600284E RID: 10318 RVA: 0x000161B2 File Offset: 0x000143B2
			public unsafe static WormControlTooltipSource.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormControlTooltipSource.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormControlTooltipSource.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormControlTooltipSource.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B47 RID: 2887
			// (get) Token: 0x0600284F RID: 10319 RVA: 0x000924F0 File Offset: 0x000906F0
			// (set) Token: 0x06002850 RID: 10320 RVA: 0x000161C4 File Offset: 0x000143C4
			public unsafe static Func<EntityComponent, bool> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormControlTooltipSource.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormControlTooltipSource.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B48 RID: 2888
			// (get) Token: 0x06002851 RID: 10321 RVA: 0x00092518 File Offset: 0x00090718
			// (set) Token: 0x06002852 RID: 10322 RVA: 0x000161D6 File Offset: 0x000143D6
			public unsafe static Func<EntityComponent, bool> __9__5_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormControlTooltipSource.__c.NativeFieldInfoPtr___9__5_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormControlTooltipSource.__c.NativeFieldInfoPtr___9__5_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001733 RID: 5939
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001734 RID: 5940
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04001735 RID: 5941
			private static readonly IntPtr NativeFieldInfoPtr___9__5_1;

			// Token: 0x04001736 RID: 5942
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001737 RID: 5943
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__5_0_Internal_Boolean_EntityComponent_0;

			// Token: 0x04001738 RID: 5944
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__5_1_Internal_Boolean_EntityComponent_0;
		}

		// Token: 0x020003E1 RID: 993
		[ObfuscatedName("worm.match.components.WormControlTooltipSource+<Init>d__4")]
		public sealed class _Init_d__4 : Object
		{
			// Token: 0x06002853 RID: 10323 RVA: 0x00092540 File Offset: 0x00090740
			// Note: this type is marked as 'beforefieldinit'.
			static _Init_d__4()
			{
				Il2CppClassPointerStore<WormControlTooltipSource._Init_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormControlTooltipSource>.NativeClassPtr, "<Init>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormControlTooltipSource._Init_d__4>.NativeClassPtr);
				WormControlTooltipSource._Init_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormControlTooltipSource._Init_d__4>.NativeClassPtr, "<>1__state");
				WormControlTooltipSource._Init_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormControlTooltipSource._Init_d__4>.NativeClassPtr, "<>2__current");
				WormControlTooltipSource._Init_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormControlTooltipSource._Init_d__4>.NativeClassPtr, "<>4__this");
				WormControlTooltipSource._Init_d__4.NativeFieldInfoPtr__entityView_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormControlTooltipSource._Init_d__4>.NativeClassPtr, "<entityView>5__2");
				WormControlTooltipSource._Init_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormControlTooltipSource._Init_d__4>.NativeClassPtr, 100666228);
				WormControlTooltipSource._Init_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormControlTooltipSource._Init_d__4>.NativeClassPtr, 100666229);
				WormControlTooltipSource._Init_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormControlTooltipSource._Init_d__4>.NativeClassPtr, 100666230);
				WormControlTooltipSource._Init_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormControlTooltipSource._Init_d__4>.NativeClassPtr, 100666231);
				WormControlTooltipSource._Init_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormControlTooltipSource._Init_d__4>.NativeClassPtr, 100666232);
				WormControlTooltipSource._Init_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormControlTooltipSource._Init_d__4>.NativeClassPtr, 100666233);
			}

			// Token: 0x06002854 RID: 10324 RVA: 0x00092634 File Offset: 0x00090834
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Init_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormControlTooltipSource._Init_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormControlTooltipSource._Init_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002855 RID: 10325 RVA: 0x0009267C File Offset: 0x0009087C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormControlTooltipSource._Init_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002856 RID: 10326 RVA: 0x000926B0 File Offset: 0x000908B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715002, XrefRangeEnd = 715006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormControlTooltipSource._Init_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B4D RID: 2893
			// (get) Token: 0x06002857 RID: 10327 RVA: 0x000926EC File Offset: 0x000908EC
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormControlTooltipSource._Init_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002858 RID: 10328 RVA: 0x0009272C File Offset: 0x0009092C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715006, XrefRangeEnd = 715011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormControlTooltipSource._Init_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B4E RID: 2894
			// (get) Token: 0x06002859 RID: 10329 RVA: 0x00092760 File Offset: 0x00090960
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormControlTooltipSource._Init_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600285A RID: 10330 RVA: 0x000161E8 File Offset: 0x000143E8
			public _Init_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B49 RID: 2889
			// (get) Token: 0x0600285B RID: 10331 RVA: 0x000927A0 File Offset: 0x000909A0
			// (set) Token: 0x0600285C RID: 10332 RVA: 0x000161F1 File Offset: 0x000143F1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormControlTooltipSource._Init_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormControlTooltipSource._Init_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B4A RID: 2890
			// (get) Token: 0x0600285D RID: 10333 RVA: 0x000927C8 File Offset: 0x000909C8
			// (set) Token: 0x0600285E RID: 10334 RVA: 0x0001620C File Offset: 0x0001440C
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormControlTooltipSource._Init_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormControlTooltipSource._Init_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B4B RID: 2891
			// (get) Token: 0x0600285F RID: 10335 RVA: 0x000927F8 File Offset: 0x000909F8
			// (set) Token: 0x06002860 RID: 10336 RVA: 0x0001622B File Offset: 0x0001442B
			public unsafe WormControlTooltipSource __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormControlTooltipSource._Init_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormControlTooltipSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormControlTooltipSource._Init_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B4C RID: 2892
			// (get) Token: 0x06002861 RID: 10337 RVA: 0x00092828 File Offset: 0x00090A28
			// (set) Token: 0x06002862 RID: 10338 RVA: 0x0001624A File Offset: 0x0001444A
			public unsafe EntityView _entityView_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormControlTooltipSource._Init_d__4.NativeFieldInfoPtr__entityView_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormControlTooltipSource._Init_d__4.NativeFieldInfoPtr__entityView_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001739 RID: 5945
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400173A RID: 5946
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400173B RID: 5947
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400173C RID: 5948
			private static readonly IntPtr NativeFieldInfoPtr__entityView_5__2;

			// Token: 0x0400173D RID: 5949
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400173E RID: 5950
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400173F RID: 5951
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001740 RID: 5952
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001741 RID: 5953
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001742 RID: 5954
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
