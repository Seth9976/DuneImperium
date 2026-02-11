using System;
using boardgames.match.behaviours;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine.Events;
using worm.canis.data.enums;

namespace worm.match.dataRenderers
{
	// Token: 0x0200011A RID: 282
	public class WormEventsForHagalRenderer : VersionedView<IAttribute<Nullable<HagalModes>>>
	{
		// Token: 0x06000CEF RID: 3311 RVA: 0x0003F578 File Offset: 0x0003D778
		// Note: this type is marked as 'beforefieldinit'.
		static WormEventsForHagalRenderer()
		{
			Il2CppClassPointerStore<WormEventsForHagalRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormEventsForHagalRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventsForHagalRenderer>.NativeClassPtr);
			WormEventsForHagalRenderer.NativeFieldInfoPtr_onIsHagal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForHagalRenderer>.NativeClassPtr, "onIsHagal");
			WormEventsForHagalRenderer.NativeFieldInfoPtr_onNotHagal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForHagalRenderer>.NativeClassPtr, "onNotHagal");
			WormEventsForHagalRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForHagalRenderer>.NativeClassPtr, 100665064);
			WormEventsForHagalRenderer.NativeMethodInfoPtr_Init_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForHagalRenderer>.NativeClassPtr, 100665065);
			WormEventsForHagalRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForHagalRenderer>.NativeClassPtr, 100665066);
			WormEventsForHagalRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForHagalRenderer>.NativeClassPtr, 100665067);
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x0003F620 File Offset: 0x0003D820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705078, XrefRangeEnd = 705087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEventsForHagalRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x0003F65C File Offset: 0x0003D85C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705087, XrefRangeEnd = 705092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsForHagalRenderer.NativeMethodInfoPtr_Init_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x0003F69C File Offset: 0x0003D89C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705092, XrefRangeEnd = 705101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEventsForHagalRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x0003F6D8 File Offset: 0x0003D8D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705101, XrefRangeEnd = 705113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEventsForHagalRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventsForHagalRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsForHagalRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x00008D7A File Offset: 0x00006F7A
		public WormEventsForHagalRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000CF5 RID: 3317 RVA: 0x0003F714 File Offset: 0x0003D914
		// (set) Token: 0x06000CF6 RID: 3318 RVA: 0x00008D83 File Offset: 0x00006F83
		public unsafe UnityEvent onIsHagal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForHagalRenderer.NativeFieldInfoPtr_onIsHagal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForHagalRenderer.NativeFieldInfoPtr_onIsHagal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000CF7 RID: 3319 RVA: 0x0003F744 File Offset: 0x0003D944
		// (set) Token: 0x06000CF8 RID: 3320 RVA: 0x00008DA2 File Offset: 0x00006FA2
		public unsafe UnityEvent onNotHagal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForHagalRenderer.NativeFieldInfoPtr_onNotHagal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForHagalRenderer.NativeFieldInfoPtr_onNotHagal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400077F RID: 1919
		private static readonly IntPtr NativeFieldInfoPtr_onIsHagal;

		// Token: 0x04000780 RID: 1920
		private static readonly IntPtr NativeFieldInfoPtr_onNotHagal;

		// Token: 0x04000781 RID: 1921
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000782 RID: 1922
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_IEnumerator_0;

		// Token: 0x04000783 RID: 1923
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000784 RID: 1924
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200037B RID: 891
		[ObfuscatedName("worm.match.dataRenderers.WormEventsForHagalRenderer+<Init>d__3")]
		public sealed class _Init_d__3 : Object
		{
			// Token: 0x060023D7 RID: 9175 RVA: 0x00084B1C File Offset: 0x00082D1C
			// Note: this type is marked as 'beforefieldinit'.
			static _Init_d__3()
			{
				Il2CppClassPointerStore<WormEventsForHagalRenderer._Init_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormEventsForHagalRenderer>.NativeClassPtr, "<Init>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventsForHagalRenderer._Init_d__3>.NativeClassPtr);
				WormEventsForHagalRenderer._Init_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForHagalRenderer._Init_d__3>.NativeClassPtr, "<>1__state");
				WormEventsForHagalRenderer._Init_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForHagalRenderer._Init_d__3>.NativeClassPtr, "<>2__current");
				WormEventsForHagalRenderer._Init_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForHagalRenderer._Init_d__3>.NativeClassPtr, "<>4__this");
				WormEventsForHagalRenderer._Init_d__3.NativeFieldInfoPtr__entitiesProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForHagalRenderer._Init_d__3>.NativeClassPtr, "<entitiesProvider>5__2");
				WormEventsForHagalRenderer._Init_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForHagalRenderer._Init_d__3>.NativeClassPtr, 100665068);
				WormEventsForHagalRenderer._Init_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForHagalRenderer._Init_d__3>.NativeClassPtr, 100665069);
				WormEventsForHagalRenderer._Init_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForHagalRenderer._Init_d__3>.NativeClassPtr, 100665070);
				WormEventsForHagalRenderer._Init_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForHagalRenderer._Init_d__3>.NativeClassPtr, 100665071);
				WormEventsForHagalRenderer._Init_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForHagalRenderer._Init_d__3>.NativeClassPtr, 100665072);
				WormEventsForHagalRenderer._Init_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForHagalRenderer._Init_d__3>.NativeClassPtr, 100665073);
			}

			// Token: 0x060023D8 RID: 9176 RVA: 0x00084C10 File Offset: 0x00082E10
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Init_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventsForHagalRenderer._Init_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsForHagalRenderer._Init_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060023D9 RID: 9177 RVA: 0x00084C58 File Offset: 0x00082E58
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsForHagalRenderer._Init_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023DA RID: 9178 RVA: 0x00084C8C File Offset: 0x00082E8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705065, XrefRangeEnd = 705073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsForHagalRenderer._Init_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170009EA RID: 2538
			// (get) Token: 0x060023DB RID: 9179 RVA: 0x00084CC8 File Offset: 0x00082EC8
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsForHagalRenderer._Init_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060023DC RID: 9180 RVA: 0x00084D08 File Offset: 0x00082F08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705073, XrefRangeEnd = 705078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsForHagalRenderer._Init_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170009EB RID: 2539
			// (get) Token: 0x060023DD RID: 9181 RVA: 0x00084D3C File Offset: 0x00082F3C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsForHagalRenderer._Init_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060023DE RID: 9182 RVA: 0x00013FFE File Offset: 0x000121FE
			public _Init_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009E6 RID: 2534
			// (get) Token: 0x060023DF RID: 9183 RVA: 0x00084D7C File Offset: 0x00082F7C
			// (set) Token: 0x060023E0 RID: 9184 RVA: 0x00014007 File Offset: 0x00012207
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForHagalRenderer._Init_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForHagalRenderer._Init_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170009E7 RID: 2535
			// (get) Token: 0x060023E1 RID: 9185 RVA: 0x00084DA4 File Offset: 0x00082FA4
			// (set) Token: 0x060023E2 RID: 9186 RVA: 0x00014022 File Offset: 0x00012222
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForHagalRenderer._Init_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForHagalRenderer._Init_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009E8 RID: 2536
			// (get) Token: 0x060023E3 RID: 9187 RVA: 0x00084DD4 File Offset: 0x00082FD4
			// (set) Token: 0x060023E4 RID: 9188 RVA: 0x00014041 File Offset: 0x00012241
			public unsafe WormEventsForHagalRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForHagalRenderer._Init_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEventsForHagalRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForHagalRenderer._Init_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009E9 RID: 2537
			// (get) Token: 0x060023E5 RID: 9189 RVA: 0x00084E04 File Offset: 0x00083004
			// (set) Token: 0x060023E6 RID: 9190 RVA: 0x00014060 File Offset: 0x00012260
			public unsafe DBGEntitiesProvider _entitiesProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForHagalRenderer._Init_d__3.NativeFieldInfoPtr__entitiesProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForHagalRenderer._Init_d__3.NativeFieldInfoPtr__entitiesProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400148F RID: 5263
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001490 RID: 5264
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001491 RID: 5265
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001492 RID: 5266
			private static readonly IntPtr NativeFieldInfoPtr__entitiesProvider_5__2;

			// Token: 0x04001493 RID: 5267
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001494 RID: 5268
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001495 RID: 5269
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001496 RID: 5270
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001497 RID: 5271
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001498 RID: 5272
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
