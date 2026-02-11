using System;
using boardgames.match.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using TMPro;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x0200015C RID: 348
	public class WormSelectLeaderHeaderRenderer : VersionedView<WormLeaderHeaderData>
	{
		// Token: 0x06000F8C RID: 3980 RVA: 0x00046CB8 File Offset: 0x00044EB8
		// Note: this type is marked as 'beforefieldinit'.
		static WormSelectLeaderHeaderRenderer()
		{
			Il2CppClassPointerStore<WormSelectLeaderHeaderRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormSelectLeaderHeaderRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSelectLeaderHeaderRenderer>.NativeClassPtr);
			WormSelectLeaderHeaderRenderer.NativeFieldInfoPtr_headerText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectLeaderHeaderRenderer>.NativeClassPtr, "headerText");
			WormSelectLeaderHeaderRenderer.NativeFieldInfoPtr_selectedLocKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectLeaderHeaderRenderer>.NativeClassPtr, "selectedLocKey");
			WormSelectLeaderHeaderRenderer.NativeFieldInfoPtr_notSelectedLocKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectLeaderHeaderRenderer>.NativeClassPtr, "notSelectedLocKey");
			WormSelectLeaderHeaderRenderer.NativeMethodInfoPtr_get_HasSelectedLeader_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectLeaderHeaderRenderer>.NativeClassPtr, 100665399);
			WormSelectLeaderHeaderRenderer.NativeMethodInfoPtr_set_HasSelectedLeader_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectLeaderHeaderRenderer>.NativeClassPtr, 100665400);
			WormSelectLeaderHeaderRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectLeaderHeaderRenderer>.NativeClassPtr, 100665401);
			WormSelectLeaderHeaderRenderer.NativeMethodInfoPtr_Init_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectLeaderHeaderRenderer>.NativeClassPtr, 100665402);
			WormSelectLeaderHeaderRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectLeaderHeaderRenderer>.NativeClassPtr, 100665403);
			WormSelectLeaderHeaderRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectLeaderHeaderRenderer>.NativeClassPtr, 100665404);
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06000F8D RID: 3981 RVA: 0x00046D9C File Offset: 0x00044F9C
		// (set) Token: 0x06000F8E RID: 3982 RVA: 0x00046DD8 File Offset: 0x00044FD8
		public unsafe bool HasSelectedLeader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectLeaderHeaderRenderer.NativeMethodInfoPtr_get_HasSelectedLeader_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707931, XrefRangeEnd = 707932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectLeaderHeaderRenderer.NativeMethodInfoPtr_set_HasSelectedLeader_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x00046E18 File Offset: 0x00045018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707932, XrefRangeEnd = 707941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSelectLeaderHeaderRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x00046E54 File Offset: 0x00045054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707941, XrefRangeEnd = 707946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectLeaderHeaderRenderer.NativeMethodInfoPtr_Init_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x00046E94 File Offset: 0x00045094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707946, XrefRangeEnd = 707949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSelectLeaderHeaderRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x00046ED0 File Offset: 0x000450D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707949, XrefRangeEnd = 707957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSelectLeaderHeaderRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSelectLeaderHeaderRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectLeaderHeaderRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x0000A310 File Offset: 0x00008510
		public WormSelectLeaderHeaderRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06000F94 RID: 3988 RVA: 0x00046F0C File Offset: 0x0004510C
		// (set) Token: 0x06000F95 RID: 3989 RVA: 0x0000A319 File Offset: 0x00008519
		public unsafe TMP_Text headerText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectLeaderHeaderRenderer.NativeFieldInfoPtr_headerText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectLeaderHeaderRenderer.NativeFieldInfoPtr_headerText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06000F96 RID: 3990 RVA: 0x00046F3C File Offset: 0x0004513C
		// (set) Token: 0x06000F97 RID: 3991 RVA: 0x0000A338 File Offset: 0x00008538
		public unsafe string selectedLocKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectLeaderHeaderRenderer.NativeFieldInfoPtr_selectedLocKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectLeaderHeaderRenderer.NativeFieldInfoPtr_selectedLocKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06000F98 RID: 3992 RVA: 0x00046F64 File Offset: 0x00045164
		// (set) Token: 0x06000F99 RID: 3993 RVA: 0x0000A357 File Offset: 0x00008557
		public unsafe string notSelectedLocKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectLeaderHeaderRenderer.NativeFieldInfoPtr_notSelectedLocKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectLeaderHeaderRenderer.NativeFieldInfoPtr_notSelectedLocKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040008F2 RID: 2290
		private static readonly IntPtr NativeFieldInfoPtr_headerText;

		// Token: 0x040008F3 RID: 2291
		private static readonly IntPtr NativeFieldInfoPtr_selectedLocKey;

		// Token: 0x040008F4 RID: 2292
		private static readonly IntPtr NativeFieldInfoPtr_notSelectedLocKey;

		// Token: 0x040008F5 RID: 2293
		private static readonly IntPtr NativeMethodInfoPtr_get_HasSelectedLeader_Public_get_Boolean_0;

		// Token: 0x040008F6 RID: 2294
		private static readonly IntPtr NativeMethodInfoPtr_set_HasSelectedLeader_Public_set_Void_Boolean_0;

		// Token: 0x040008F7 RID: 2295
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040008F8 RID: 2296
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_IEnumerator_0;

		// Token: 0x040008F9 RID: 2297
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040008FA RID: 2298
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003A1 RID: 929
		[ObfuscatedName("worm.match.dataRenderers.WormSelectLeaderHeaderRenderer+<Init>d__7")]
		public sealed class _Init_d__7 : Object
		{
			// Token: 0x0600256E RID: 9582 RVA: 0x000892D0 File Offset: 0x000874D0
			// Note: this type is marked as 'beforefieldinit'.
			static _Init_d__7()
			{
				Il2CppClassPointerStore<WormSelectLeaderHeaderRenderer._Init_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormSelectLeaderHeaderRenderer>.NativeClassPtr, "<Init>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSelectLeaderHeaderRenderer._Init_d__7>.NativeClassPtr);
				WormSelectLeaderHeaderRenderer._Init_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectLeaderHeaderRenderer._Init_d__7>.NativeClassPtr, "<>1__state");
				WormSelectLeaderHeaderRenderer._Init_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectLeaderHeaderRenderer._Init_d__7>.NativeClassPtr, "<>2__current");
				WormSelectLeaderHeaderRenderer._Init_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectLeaderHeaderRenderer._Init_d__7>.NativeClassPtr, "<>4__this");
				WormSelectLeaderHeaderRenderer._Init_d__7.NativeFieldInfoPtr__entitiesProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectLeaderHeaderRenderer._Init_d__7>.NativeClassPtr, "<entitiesProvider>5__2");
				WormSelectLeaderHeaderRenderer._Init_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectLeaderHeaderRenderer._Init_d__7>.NativeClassPtr, 100665405);
				WormSelectLeaderHeaderRenderer._Init_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectLeaderHeaderRenderer._Init_d__7>.NativeClassPtr, 100665406);
				WormSelectLeaderHeaderRenderer._Init_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectLeaderHeaderRenderer._Init_d__7>.NativeClassPtr, 100665407);
				WormSelectLeaderHeaderRenderer._Init_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectLeaderHeaderRenderer._Init_d__7>.NativeClassPtr, 100665408);
				WormSelectLeaderHeaderRenderer._Init_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectLeaderHeaderRenderer._Init_d__7>.NativeClassPtr, 100665409);
				WormSelectLeaderHeaderRenderer._Init_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectLeaderHeaderRenderer._Init_d__7>.NativeClassPtr, 100665410);
			}

			// Token: 0x0600256F RID: 9583 RVA: 0x000893C4 File Offset: 0x000875C4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Init_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSelectLeaderHeaderRenderer._Init_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectLeaderHeaderRenderer._Init_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002570 RID: 9584 RVA: 0x0008940C File Offset: 0x0008760C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectLeaderHeaderRenderer._Init_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002571 RID: 9585 RVA: 0x00089440 File Offset: 0x00087640
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707918, XrefRangeEnd = 707926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectLeaderHeaderRenderer._Init_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A72 RID: 2674
			// (get) Token: 0x06002572 RID: 9586 RVA: 0x0008947C File Offset: 0x0008767C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectLeaderHeaderRenderer._Init_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002573 RID: 9587 RVA: 0x000894BC File Offset: 0x000876BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707926, XrefRangeEnd = 707931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectLeaderHeaderRenderer._Init_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A73 RID: 2675
			// (get) Token: 0x06002574 RID: 9588 RVA: 0x000894F0 File Offset: 0x000876F0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectLeaderHeaderRenderer._Init_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002575 RID: 9589 RVA: 0x00014D91 File Offset: 0x00012F91
			public _Init_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A6E RID: 2670
			// (get) Token: 0x06002576 RID: 9590 RVA: 0x00089530 File Offset: 0x00087730
			// (set) Token: 0x06002577 RID: 9591 RVA: 0x00014D9A File Offset: 0x00012F9A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectLeaderHeaderRenderer._Init_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectLeaderHeaderRenderer._Init_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A6F RID: 2671
			// (get) Token: 0x06002578 RID: 9592 RVA: 0x00089558 File Offset: 0x00087758
			// (set) Token: 0x06002579 RID: 9593 RVA: 0x00014DB5 File Offset: 0x00012FB5
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectLeaderHeaderRenderer._Init_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectLeaderHeaderRenderer._Init_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A70 RID: 2672
			// (get) Token: 0x0600257A RID: 9594 RVA: 0x00089588 File Offset: 0x00087788
			// (set) Token: 0x0600257B RID: 9595 RVA: 0x00014DD4 File Offset: 0x00012FD4
			public unsafe WormSelectLeaderHeaderRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectLeaderHeaderRenderer._Init_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSelectLeaderHeaderRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectLeaderHeaderRenderer._Init_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A71 RID: 2673
			// (get) Token: 0x0600257C RID: 9596 RVA: 0x000895B8 File Offset: 0x000877B8
			// (set) Token: 0x0600257D RID: 9597 RVA: 0x00014DF3 File Offset: 0x00012FF3
			public unsafe DBGEntitiesProvider _entitiesProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectLeaderHeaderRenderer._Init_d__7.NativeFieldInfoPtr__entitiesProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectLeaderHeaderRenderer._Init_d__7.NativeFieldInfoPtr__entitiesProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400157C RID: 5500
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400157D RID: 5501
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400157E RID: 5502
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400157F RID: 5503
			private static readonly IntPtr NativeFieldInfoPtr__entitiesProvider_5__2;

			// Token: 0x04001580 RID: 5504
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001581 RID: 5505
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001582 RID: 5506
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001583 RID: 5507
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001584 RID: 5508
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001585 RID: 5509
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
