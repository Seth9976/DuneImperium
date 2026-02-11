using System;
using Canis.utils.ids;
using dwd.core.match;
using dwd.core.match.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lib.canis.boardgames.src.match;
using lotus;

namespace boardgames.attributes
{
	// Token: 0x0200015B RID: 347
	public class ArchetypesAttributeContainerViewInitializer : AttributeView
	{
		// Token: 0x060011A2 RID: 4514 RVA: 0x00047424 File Offset: 0x00045624
		// Note: this type is marked as 'beforefieldinit'.
		static ArchetypesAttributeContainerViewInitializer()
		{
			Il2CppClassPointerStore<ArchetypesAttributeContainerViewInitializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.attributes", "ArchetypesAttributeContainerViewInitializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArchetypesAttributeContainerViewInitializer>.NativeClassPtr);
			ArchetypesAttributeContainerViewInitializer.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypesAttributeContainerViewInitializer>.NativeClassPtr, "container");
			ArchetypesAttributeContainerViewInitializer.NativeFieldInfoPtr_tempParentEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypesAttributeContainerViewInitializer>.NativeClassPtr, "tempParentEntity");
			ArchetypesAttributeContainerViewInitializer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypesAttributeContainerViewInitializer>.NativeClassPtr, 100665896);
			ArchetypesAttributeContainerViewInitializer.NativeMethodInfoPtr_Init_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypesAttributeContainerViewInitializer>.NativeClassPtr, 100665897);
			ArchetypesAttributeContainerViewInitializer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypesAttributeContainerViewInitializer>.NativeClassPtr, 100665898);
			ArchetypesAttributeContainerViewInitializer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypesAttributeContainerViewInitializer>.NativeClassPtr, 100665899);
		}

		// Token: 0x060011A3 RID: 4515 RVA: 0x000474CC File Offset: 0x000456CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000288, XrefRangeEnd = 1000295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArchetypesAttributeContainerViewInitializer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x00047508 File Offset: 0x00045708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000295, XrefRangeEnd = 1000300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypesAttributeContainerViewInitializer.NativeMethodInfoPtr_Init_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x00047548 File Offset: 0x00045748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000300, XrefRangeEnd = 1000330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArchetypesAttributeContainerViewInitializer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011A6 RID: 4518 RVA: 0x00047584 File Offset: 0x00045784
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1000333, RefRangeEnd = 1000339, XrefRangeStart = 1000330, XrefRangeEnd = 1000333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArchetypesAttributeContainerViewInitializer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArchetypesAttributeContainerViewInitializer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypesAttributeContainerViewInitializer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011A7 RID: 4519 RVA: 0x0000A399 File Offset: 0x00008599
		public ArchetypesAttributeContainerViewInitializer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x060011A8 RID: 4520 RVA: 0x000475C0 File Offset: 0x000457C0
		// (set) Token: 0x060011A9 RID: 4521 RVA: 0x0000A3A2 File Offset: 0x000085A2
		public unsafe ContainerView container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypesAttributeContainerViewInitializer.NativeFieldInfoPtr_container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypesAttributeContainerViewInitializer.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x060011AA RID: 4522 RVA: 0x000475F0 File Offset: 0x000457F0
		// (set) Token: 0x060011AB RID: 4523 RVA: 0x0000A3C1 File Offset: 0x000085C1
		public unsafe EntityComponent tempParentEntity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypesAttributeContainerViewInitializer.NativeFieldInfoPtr_tempParentEntity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypesAttributeContainerViewInitializer.NativeFieldInfoPtr_tempParentEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000ABA RID: 2746
		private static readonly IntPtr NativeFieldInfoPtr_container;

		// Token: 0x04000ABB RID: 2747
		private static readonly IntPtr NativeFieldInfoPtr_tempParentEntity;

		// Token: 0x04000ABC RID: 2748
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x04000ABD RID: 2749
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_IEnumerator_0;

		// Token: 0x04000ABE RID: 2750
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000ABF RID: 2751
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000281 RID: 641
		[ObfuscatedName("boardgames.attributes.ArchetypesAttributeContainerViewInitializer+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x06001DAA RID: 7594 RVA: 0x0006C8B0 File Offset: 0x0006AAB0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<ArchetypesAttributeContainerViewInitializer.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArchetypesAttributeContainerViewInitializer>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArchetypesAttributeContainerViewInitializer.__c__DisplayClass4_0>.NativeClassPtr);
				ArchetypesAttributeContainerViewInitializer.__c__DisplayClass4_0.NativeFieldInfoPtr_archProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypesAttributeContainerViewInitializer.__c__DisplayClass4_0>.NativeClassPtr, "archProvider");
				ArchetypesAttributeContainerViewInitializer.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypesAttributeContainerViewInitializer.__c__DisplayClass4_0>.NativeClassPtr, 100665900);
				ArchetypesAttributeContainerViewInitializer.__c__DisplayClass4_0.NativeMethodInfoPtr__dirtyUpdate_b__0_Internal_ValueTuple_2_Boolean_EntityComponent_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypesAttributeContainerViewInitializer.__c__DisplayClass4_0>.NativeClassPtr, 100665901);
			}

			// Token: 0x06001DAB RID: 7595 RVA: 0x0006C918 File Offset: 0x0006AB18
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArchetypesAttributeContainerViewInitializer.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypesAttributeContainerViewInitializer.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DAC RID: 7596 RVA: 0x0006C954 File Offset: 0x0006AB54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000272, XrefRangeEnd = 1000276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<bool, EntityComponent> _dirtyUpdate_b__0(ArchetypeID a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypesAttributeContainerViewInitializer.__c__DisplayClass4_0.NativeMethodInfoPtr__dirtyUpdate_b__0_Internal_ValueTuple_2_Boolean_EntityComponent_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<bool, EntityComponent>(intPtr);
				}
			}

			// Token: 0x06001DAD RID: 7597 RVA: 0x0000FF5B File Offset: 0x0000E15B
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008DD RID: 2269
			// (get) Token: 0x06001DAE RID: 7598 RVA: 0x0006C99C File Offset: 0x0006AB9C
			// (set) Token: 0x06001DAF RID: 7599 RVA: 0x0000FF64 File Offset: 0x0000E164
			public unsafe ArchetypeProvider archProvider
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypesAttributeContainerViewInitializer.__c__DisplayClass4_0.NativeFieldInfoPtr_archProvider);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypesAttributeContainerViewInitializer.__c__DisplayClass4_0.NativeFieldInfoPtr_archProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400120E RID: 4622
			private static readonly IntPtr NativeFieldInfoPtr_archProvider;

			// Token: 0x0400120F RID: 4623
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001210 RID: 4624
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__0_Internal_ValueTuple_2_Boolean_EntityComponent_ArchetypeID_0;
		}

		// Token: 0x02000282 RID: 642
		[ObfuscatedName("boardgames.attributes.ArchetypesAttributeContainerViewInitializer+<Init>d__3")]
		public sealed class _Init_d__3 : Object
		{
			// Token: 0x06001DB0 RID: 7600 RVA: 0x0006C9CC File Offset: 0x0006ABCC
			// Note: this type is marked as 'beforefieldinit'.
			static _Init_d__3()
			{
				Il2CppClassPointerStore<ArchetypesAttributeContainerViewInitializer._Init_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArchetypesAttributeContainerViewInitializer>.NativeClassPtr, "<Init>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArchetypesAttributeContainerViewInitializer._Init_d__3>.NativeClassPtr);
				ArchetypesAttributeContainerViewInitializer._Init_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypesAttributeContainerViewInitializer._Init_d__3>.NativeClassPtr, "<>1__state");
				ArchetypesAttributeContainerViewInitializer._Init_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypesAttributeContainerViewInitializer._Init_d__3>.NativeClassPtr, "<>2__current");
				ArchetypesAttributeContainerViewInitializer._Init_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypesAttributeContainerViewInitializer._Init_d__3>.NativeClassPtr, "<>4__this");
				ArchetypesAttributeContainerViewInitializer._Init_d__3.NativeFieldInfoPtr__entitiesProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypesAttributeContainerViewInitializer._Init_d__3>.NativeClassPtr, "<entitiesProvider>5__2");
				ArchetypesAttributeContainerViewInitializer._Init_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypesAttributeContainerViewInitializer._Init_d__3>.NativeClassPtr, 100665902);
				ArchetypesAttributeContainerViewInitializer._Init_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypesAttributeContainerViewInitializer._Init_d__3>.NativeClassPtr, 100665903);
				ArchetypesAttributeContainerViewInitializer._Init_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypesAttributeContainerViewInitializer._Init_d__3>.NativeClassPtr, 100665904);
				ArchetypesAttributeContainerViewInitializer._Init_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypesAttributeContainerViewInitializer._Init_d__3>.NativeClassPtr, 100665905);
				ArchetypesAttributeContainerViewInitializer._Init_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypesAttributeContainerViewInitializer._Init_d__3>.NativeClassPtr, 100665906);
				ArchetypesAttributeContainerViewInitializer._Init_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypesAttributeContainerViewInitializer._Init_d__3>.NativeClassPtr, 100665907);
			}

			// Token: 0x06001DB1 RID: 7601 RVA: 0x0006CAC0 File Offset: 0x0006ACC0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Init_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArchetypesAttributeContainerViewInitializer._Init_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypesAttributeContainerViewInitializer._Init_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001DB2 RID: 7602 RVA: 0x0006CB08 File Offset: 0x0006AD08
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypesAttributeContainerViewInitializer._Init_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DB3 RID: 7603 RVA: 0x0006CB3C File Offset: 0x0006AD3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000276, XrefRangeEnd = 1000283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypesAttributeContainerViewInitializer._Init_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170008E2 RID: 2274
			// (get) Token: 0x06001DB4 RID: 7604 RVA: 0x0006CB78 File Offset: 0x0006AD78
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypesAttributeContainerViewInitializer._Init_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001DB5 RID: 7605 RVA: 0x0006CBB8 File Offset: 0x0006ADB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000283, XrefRangeEnd = 1000288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypesAttributeContainerViewInitializer._Init_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170008E3 RID: 2275
			// (get) Token: 0x06001DB6 RID: 7606 RVA: 0x0006CBEC File Offset: 0x0006ADEC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypesAttributeContainerViewInitializer._Init_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001DB7 RID: 7607 RVA: 0x0000FF83 File Offset: 0x0000E183
			public _Init_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008DE RID: 2270
			// (get) Token: 0x06001DB8 RID: 7608 RVA: 0x0006CC2C File Offset: 0x0006AE2C
			// (set) Token: 0x06001DB9 RID: 7609 RVA: 0x0000FF8C File Offset: 0x0000E18C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypesAttributeContainerViewInitializer._Init_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypesAttributeContainerViewInitializer._Init_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008DF RID: 2271
			// (get) Token: 0x06001DBA RID: 7610 RVA: 0x0006CC54 File Offset: 0x0006AE54
			// (set) Token: 0x06001DBB RID: 7611 RVA: 0x0000FFA7 File Offset: 0x0000E1A7
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypesAttributeContainerViewInitializer._Init_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypesAttributeContainerViewInitializer._Init_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008E0 RID: 2272
			// (get) Token: 0x06001DBC RID: 7612 RVA: 0x0006CC84 File Offset: 0x0006AE84
			// (set) Token: 0x06001DBD RID: 7613 RVA: 0x0000FFC6 File Offset: 0x0000E1C6
			public unsafe ArchetypesAttributeContainerViewInitializer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypesAttributeContainerViewInitializer._Init_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypesAttributeContainerViewInitializer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypesAttributeContainerViewInitializer._Init_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008E1 RID: 2273
			// (get) Token: 0x06001DBE RID: 7614 RVA: 0x0006CCB4 File Offset: 0x0006AEB4
			// (set) Token: 0x06001DBF RID: 7615 RVA: 0x0000FFE5 File Offset: 0x0000E1E5
			public unsafe EntitiesProvider _entitiesProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypesAttributeContainerViewInitializer._Init_d__3.NativeFieldInfoPtr__entitiesProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntitiesProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypesAttributeContainerViewInitializer._Init_d__3.NativeFieldInfoPtr__entitiesProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001211 RID: 4625
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001212 RID: 4626
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001213 RID: 4627
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001214 RID: 4628
			private static readonly IntPtr NativeFieldInfoPtr__entitiesProvider_5__2;

			// Token: 0x04001215 RID: 4629
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001216 RID: 4630
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001217 RID: 4631
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001218 RID: 4632
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001219 RID: 4633
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400121A RID: 4634
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
