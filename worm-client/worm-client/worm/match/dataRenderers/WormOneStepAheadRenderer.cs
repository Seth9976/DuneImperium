using System;
using boardgames.match.behaviours;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lotus;

namespace worm.match.dataRenderers
{
	// Token: 0x02000148 RID: 328
	public class WormOneStepAheadRenderer : VersionedView<ReadOnlyVersionedList<EntityComponent>>
	{
		// Token: 0x06000EC0 RID: 3776 RVA: 0x000447D4 File Offset: 0x000429D4
		// Note: this type is marked as 'beforefieldinit'.
		static WormOneStepAheadRenderer()
		{
			Il2CppClassPointerStore<WormOneStepAheadRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormOneStepAheadRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormOneStepAheadRenderer>.NativeClassPtr);
			WormOneStepAheadRenderer.NativeFieldInfoPtr_oneStepAheadView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormOneStepAheadRenderer>.NativeClassPtr, "oneStepAheadView");
			WormOneStepAheadRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOneStepAheadRenderer>.NativeClassPtr, 100665284);
			WormOneStepAheadRenderer.NativeMethodInfoPtr_Init_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOneStepAheadRenderer>.NativeClassPtr, 100665285);
			WormOneStepAheadRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOneStepAheadRenderer>.NativeClassPtr, 100665286);
			WormOneStepAheadRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOneStepAheadRenderer>.NativeClassPtr, 100665287);
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x00044868 File Offset: 0x00042A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706998, XrefRangeEnd = 707007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormOneStepAheadRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x000448A4 File Offset: 0x00042AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707007, XrefRangeEnd = 707012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormOneStepAheadRenderer.NativeMethodInfoPtr_Init_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x000448E4 File Offset: 0x00042AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707012, XrefRangeEnd = 707018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormOneStepAheadRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x00044920 File Offset: 0x00042B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707018, XrefRangeEnd = 707021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormOneStepAheadRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormOneStepAheadRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormOneStepAheadRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x00009C6B File Offset: 0x00007E6B
		public WormOneStepAheadRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000EC6 RID: 3782 RVA: 0x0004495C File Offset: 0x00042B5C
		// (set) Token: 0x06000EC7 RID: 3783 RVA: 0x00009C74 File Offset: 0x00007E74
		public unsafe EntityView oneStepAheadView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormOneStepAheadRenderer.NativeFieldInfoPtr_oneStepAheadView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormOneStepAheadRenderer.NativeFieldInfoPtr_oneStepAheadView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000880 RID: 2176
		private static readonly IntPtr NativeFieldInfoPtr_oneStepAheadView;

		// Token: 0x04000881 RID: 2177
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000882 RID: 2178
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_IEnumerator_0;

		// Token: 0x04000883 RID: 2179
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000884 RID: 2180
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000394 RID: 916
		[ObfuscatedName("worm.match.dataRenderers.WormOneStepAheadRenderer+<Init>d__2")]
		public sealed class _Init_d__2 : Object
		{
			// Token: 0x060024D3 RID: 9427 RVA: 0x00087704 File Offset: 0x00085904
			// Note: this type is marked as 'beforefieldinit'.
			static _Init_d__2()
			{
				Il2CppClassPointerStore<WormOneStepAheadRenderer._Init_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormOneStepAheadRenderer>.NativeClassPtr, "<Init>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormOneStepAheadRenderer._Init_d__2>.NativeClassPtr);
				WormOneStepAheadRenderer._Init_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormOneStepAheadRenderer._Init_d__2>.NativeClassPtr, "<>1__state");
				WormOneStepAheadRenderer._Init_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormOneStepAheadRenderer._Init_d__2>.NativeClassPtr, "<>2__current");
				WormOneStepAheadRenderer._Init_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormOneStepAheadRenderer._Init_d__2>.NativeClassPtr, "<>4__this");
				WormOneStepAheadRenderer._Init_d__2.NativeFieldInfoPtr__entitiesProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormOneStepAheadRenderer._Init_d__2>.NativeClassPtr, "<entitiesProvider>5__2");
				WormOneStepAheadRenderer._Init_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOneStepAheadRenderer._Init_d__2>.NativeClassPtr, 100665288);
				WormOneStepAheadRenderer._Init_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOneStepAheadRenderer._Init_d__2>.NativeClassPtr, 100665289);
				WormOneStepAheadRenderer._Init_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOneStepAheadRenderer._Init_d__2>.NativeClassPtr, 100665290);
				WormOneStepAheadRenderer._Init_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOneStepAheadRenderer._Init_d__2>.NativeClassPtr, 100665291);
				WormOneStepAheadRenderer._Init_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOneStepAheadRenderer._Init_d__2>.NativeClassPtr, 100665292);
				WormOneStepAheadRenderer._Init_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOneStepAheadRenderer._Init_d__2>.NativeClassPtr, 100665293);
			}

			// Token: 0x060024D4 RID: 9428 RVA: 0x000877F8 File Offset: 0x000859F8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Init_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormOneStepAheadRenderer._Init_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormOneStepAheadRenderer._Init_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060024D5 RID: 9429 RVA: 0x00087840 File Offset: 0x00085A40
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormOneStepAheadRenderer._Init_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060024D6 RID: 9430 RVA: 0x00087874 File Offset: 0x00085A74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706982, XrefRangeEnd = 706993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormOneStepAheadRenderer._Init_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A3D RID: 2621
			// (get) Token: 0x060024D7 RID: 9431 RVA: 0x000878B0 File Offset: 0x00085AB0
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormOneStepAheadRenderer._Init_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060024D8 RID: 9432 RVA: 0x000878F0 File Offset: 0x00085AF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706993, XrefRangeEnd = 706998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormOneStepAheadRenderer._Init_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A3E RID: 2622
			// (get) Token: 0x060024D9 RID: 9433 RVA: 0x00087924 File Offset: 0x00085B24
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormOneStepAheadRenderer._Init_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060024DA RID: 9434 RVA: 0x00014879 File Offset: 0x00012A79
			public _Init_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A39 RID: 2617
			// (get) Token: 0x060024DB RID: 9435 RVA: 0x00087964 File Offset: 0x00085B64
			// (set) Token: 0x060024DC RID: 9436 RVA: 0x00014882 File Offset: 0x00012A82
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormOneStepAheadRenderer._Init_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormOneStepAheadRenderer._Init_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A3A RID: 2618
			// (get) Token: 0x060024DD RID: 9437 RVA: 0x0008798C File Offset: 0x00085B8C
			// (set) Token: 0x060024DE RID: 9438 RVA: 0x0001489D File Offset: 0x00012A9D
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormOneStepAheadRenderer._Init_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormOneStepAheadRenderer._Init_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A3B RID: 2619
			// (get) Token: 0x060024DF RID: 9439 RVA: 0x000879BC File Offset: 0x00085BBC
			// (set) Token: 0x060024E0 RID: 9440 RVA: 0x000148BC File Offset: 0x00012ABC
			public unsafe WormOneStepAheadRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormOneStepAheadRenderer._Init_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormOneStepAheadRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormOneStepAheadRenderer._Init_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A3C RID: 2620
			// (get) Token: 0x060024E1 RID: 9441 RVA: 0x000879EC File Offset: 0x00085BEC
			// (set) Token: 0x060024E2 RID: 9442 RVA: 0x000148DB File Offset: 0x00012ADB
			public unsafe DBGEntitiesProvider _entitiesProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormOneStepAheadRenderer._Init_d__2.NativeFieldInfoPtr__entitiesProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormOneStepAheadRenderer._Init_d__2.NativeFieldInfoPtr__entitiesProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001524 RID: 5412
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001525 RID: 5413
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001526 RID: 5414
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001527 RID: 5415
			private static readonly IntPtr NativeFieldInfoPtr__entitiesProvider_5__2;

			// Token: 0x04001528 RID: 5416
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001529 RID: 5417
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400152A RID: 5418
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400152B RID: 5419
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400152C RID: 5420
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400152D RID: 5421
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
