using System;
using boardgames.match.behaviours;
using Canis.attributes;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lib.canis.boardgames.src.match;
using lotus;

namespace worm.match.dataRenderers
{
	// Token: 0x02000154 RID: 340
	public class WormPrescienceRenderer : VersionedView<IAttribute<ArchetypeID>>
	{
		// Token: 0x06000F36 RID: 3894 RVA: 0x00045CF0 File Offset: 0x00043EF0
		// Note: this type is marked as 'beforefieldinit'.
		static WormPrescienceRenderer()
		{
			Il2CppClassPointerStore<WormPrescienceRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormPrescienceRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPrescienceRenderer>.NativeClassPtr);
			WormPrescienceRenderer.NativeFieldInfoPtr_prescienceView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrescienceRenderer>.NativeClassPtr, "prescienceView");
			WormPrescienceRenderer.NativeFieldInfoPtr_deckView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrescienceRenderer>.NativeClassPtr, "deckView");
			WormPrescienceRenderer.NativeFieldInfoPtr_archetypeProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrescienceRenderer>.NativeClassPtr, "archetypeProvider");
			WormPrescienceRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPrescienceRenderer>.NativeClassPtr, 100665350);
			WormPrescienceRenderer.NativeMethodInfoPtr_Init_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPrescienceRenderer>.NativeClassPtr, 100665351);
			WormPrescienceRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPrescienceRenderer>.NativeClassPtr, 100665352);
			WormPrescienceRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPrescienceRenderer>.NativeClassPtr, 100665353);
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x00045DAC File Offset: 0x00043FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707558, XrefRangeEnd = 707568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPrescienceRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x00045DE8 File Offset: 0x00043FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707568, XrefRangeEnd = 707573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPrescienceRenderer.NativeMethodInfoPtr_Init_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x00045E28 File Offset: 0x00044028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707573, XrefRangeEnd = 707586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPrescienceRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x00045E64 File Offset: 0x00044064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707586, XrefRangeEnd = 707589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPrescienceRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPrescienceRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPrescienceRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x0000A03D File Offset: 0x0000823D
		public WormPrescienceRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000F3C RID: 3900 RVA: 0x00045EA0 File Offset: 0x000440A0
		// (set) Token: 0x06000F3D RID: 3901 RVA: 0x0000A046 File Offset: 0x00008246
		public unsafe EntityView prescienceView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPrescienceRenderer.NativeFieldInfoPtr_prescienceView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPrescienceRenderer.NativeFieldInfoPtr_prescienceView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06000F3E RID: 3902 RVA: 0x00045ED0 File Offset: 0x000440D0
		// (set) Token: 0x06000F3F RID: 3903 RVA: 0x0000A065 File Offset: 0x00008265
		public unsafe EntityView deckView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPrescienceRenderer.NativeFieldInfoPtr_deckView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPrescienceRenderer.NativeFieldInfoPtr_deckView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06000F40 RID: 3904 RVA: 0x00045F00 File Offset: 0x00044100
		// (set) Token: 0x06000F41 RID: 3905 RVA: 0x0000A084 File Offset: 0x00008284
		public unsafe ArchetypeProvider archetypeProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPrescienceRenderer.NativeFieldInfoPtr_archetypeProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPrescienceRenderer.NativeFieldInfoPtr_archetypeProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008C1 RID: 2241
		private static readonly IntPtr NativeFieldInfoPtr_prescienceView;

		// Token: 0x040008C2 RID: 2242
		private static readonly IntPtr NativeFieldInfoPtr_deckView;

		// Token: 0x040008C3 RID: 2243
		private static readonly IntPtr NativeFieldInfoPtr_archetypeProvider;

		// Token: 0x040008C4 RID: 2244
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040008C5 RID: 2245
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_IEnumerator_0;

		// Token: 0x040008C6 RID: 2246
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040008C7 RID: 2247
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200039C RID: 924
		[ObfuscatedName("worm.match.dataRenderers.WormPrescienceRenderer+<Init>d__4")]
		public sealed class _Init_d__4 : Object
		{
			// Token: 0x0600252D RID: 9517 RVA: 0x000886F8 File Offset: 0x000868F8
			// Note: this type is marked as 'beforefieldinit'.
			static _Init_d__4()
			{
				Il2CppClassPointerStore<WormPrescienceRenderer._Init_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPrescienceRenderer>.NativeClassPtr, "<Init>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPrescienceRenderer._Init_d__4>.NativeClassPtr);
				WormPrescienceRenderer._Init_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrescienceRenderer._Init_d__4>.NativeClassPtr, "<>1__state");
				WormPrescienceRenderer._Init_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrescienceRenderer._Init_d__4>.NativeClassPtr, "<>2__current");
				WormPrescienceRenderer._Init_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrescienceRenderer._Init_d__4>.NativeClassPtr, "<>4__this");
				WormPrescienceRenderer._Init_d__4.NativeFieldInfoPtr__entitiesProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPrescienceRenderer._Init_d__4>.NativeClassPtr, "<entitiesProvider>5__2");
				WormPrescienceRenderer._Init_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPrescienceRenderer._Init_d__4>.NativeClassPtr, 100665354);
				WormPrescienceRenderer._Init_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPrescienceRenderer._Init_d__4>.NativeClassPtr, 100665355);
				WormPrescienceRenderer._Init_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPrescienceRenderer._Init_d__4>.NativeClassPtr, 100665356);
				WormPrescienceRenderer._Init_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPrescienceRenderer._Init_d__4>.NativeClassPtr, 100665357);
				WormPrescienceRenderer._Init_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPrescienceRenderer._Init_d__4>.NativeClassPtr, 100665358);
				WormPrescienceRenderer._Init_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPrescienceRenderer._Init_d__4>.NativeClassPtr, 100665359);
			}

			// Token: 0x0600252E RID: 9518 RVA: 0x000887EC File Offset: 0x000869EC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Init_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPrescienceRenderer._Init_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPrescienceRenderer._Init_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600252F RID: 9519 RVA: 0x00088834 File Offset: 0x00086A34
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPrescienceRenderer._Init_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002530 RID: 9520 RVA: 0x00088868 File Offset: 0x00086A68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707525, XrefRangeEnd = 707553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPrescienceRenderer._Init_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A5B RID: 2651
			// (get) Token: 0x06002531 RID: 9521 RVA: 0x000888A4 File Offset: 0x00086AA4
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPrescienceRenderer._Init_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002532 RID: 9522 RVA: 0x000888E4 File Offset: 0x00086AE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707553, XrefRangeEnd = 707558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPrescienceRenderer._Init_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A5C RID: 2652
			// (get) Token: 0x06002533 RID: 9523 RVA: 0x00088918 File Offset: 0x00086B18
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPrescienceRenderer._Init_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002534 RID: 9524 RVA: 0x00014B61 File Offset: 0x00012D61
			public _Init_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A57 RID: 2647
			// (get) Token: 0x06002535 RID: 9525 RVA: 0x00088958 File Offset: 0x00086B58
			// (set) Token: 0x06002536 RID: 9526 RVA: 0x00014B6A File Offset: 0x00012D6A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPrescienceRenderer._Init_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPrescienceRenderer._Init_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A58 RID: 2648
			// (get) Token: 0x06002537 RID: 9527 RVA: 0x00088980 File Offset: 0x00086B80
			// (set) Token: 0x06002538 RID: 9528 RVA: 0x00014B85 File Offset: 0x00012D85
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPrescienceRenderer._Init_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPrescienceRenderer._Init_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A59 RID: 2649
			// (get) Token: 0x06002539 RID: 9529 RVA: 0x000889B0 File Offset: 0x00086BB0
			// (set) Token: 0x0600253A RID: 9530 RVA: 0x00014BA4 File Offset: 0x00012DA4
			public unsafe WormPrescienceRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPrescienceRenderer._Init_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPrescienceRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPrescienceRenderer._Init_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A5A RID: 2650
			// (get) Token: 0x0600253B RID: 9531 RVA: 0x000889E0 File Offset: 0x00086BE0
			// (set) Token: 0x0600253C RID: 9532 RVA: 0x00014BC3 File Offset: 0x00012DC3
			public unsafe DBGEntitiesProvider _entitiesProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPrescienceRenderer._Init_d__4.NativeFieldInfoPtr__entitiesProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPrescienceRenderer._Init_d__4.NativeFieldInfoPtr__entitiesProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001556 RID: 5462
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001557 RID: 5463
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001558 RID: 5464
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001559 RID: 5465
			private static readonly IntPtr NativeFieldInfoPtr__entitiesProvider_5__2;

			// Token: 0x0400155A RID: 5466
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400155B RID: 5467
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400155C RID: 5468
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400155D RID: 5469
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400155E RID: 5470
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400155F RID: 5471
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
