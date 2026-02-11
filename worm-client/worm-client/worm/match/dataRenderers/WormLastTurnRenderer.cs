using System;
using boardgames.match.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x02000141 RID: 321
	public class WormLastTurnRenderer : VersionedView<WormLastRoundData>
	{
		// Token: 0x06000E71 RID: 3697 RVA: 0x000439D8 File Offset: 0x00041BD8
		// Note: this type is marked as 'beforefieldinit'.
		static WormLastTurnRenderer()
		{
			Il2CppClassPointerStore<WormLastTurnRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormLastTurnRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormLastTurnRenderer>.NativeClassPtr);
			WormLastTurnRenderer.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLastTurnRenderer>.NativeClassPtr, "animator");
			WormLastTurnRenderer.NativeFieldInfoPtr_GameEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLastTurnRenderer>.NativeClassPtr, "GameEnd");
			WormLastTurnRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLastTurnRenderer>.NativeClassPtr, 100665251);
			WormLastTurnRenderer.NativeMethodInfoPtr_Init_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLastTurnRenderer>.NativeClassPtr, 100665252);
			WormLastTurnRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLastTurnRenderer>.NativeClassPtr, 100665253);
			WormLastTurnRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLastTurnRenderer>.NativeClassPtr, 100665254);
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x00043A80 File Offset: 0x00041C80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706621, XrefRangeEnd = 706635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormLastTurnRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x00043ABC File Offset: 0x00041CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706635, XrefRangeEnd = 706640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLastTurnRenderer.NativeMethodInfoPtr_Init_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x00043AFC File Offset: 0x00041CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706640, XrefRangeEnd = 706647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormLastTurnRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x00043B38 File Offset: 0x00041D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706647, XrefRangeEnd = 706650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormLastTurnRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormLastTurnRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLastTurnRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x000099B2 File Offset: 0x00007BB2
		public WormLastTurnRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000E77 RID: 3703 RVA: 0x00043B74 File Offset: 0x00041D74
		// (set) Token: 0x06000E78 RID: 3704 RVA: 0x000099BB File Offset: 0x00007BBB
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLastTurnRenderer.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLastTurnRenderer.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000E79 RID: 3705 RVA: 0x00043BA4 File Offset: 0x00041DA4
		// (set) Token: 0x06000E7A RID: 3706 RVA: 0x000099DA File Offset: 0x00007BDA
		public unsafe static int GameEnd
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormLastTurnRenderer.NativeFieldInfoPtr_GameEnd, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormLastTurnRenderer.NativeFieldInfoPtr_GameEnd, (void*)(&value));
			}
		}

		// Token: 0x04000854 RID: 2132
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x04000855 RID: 2133
		private static readonly IntPtr NativeFieldInfoPtr_GameEnd;

		// Token: 0x04000856 RID: 2134
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000857 RID: 2135
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_IEnumerator_0;

		// Token: 0x04000858 RID: 2136
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000859 RID: 2137
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000391 RID: 913
		[ObfuscatedName("worm.match.dataRenderers.WormLastTurnRenderer+<Init>d__3")]
		public sealed class _Init_d__3 : global::Il2CppSystem.Object
		{
			// Token: 0x060024B5 RID: 9397 RVA: 0x000871F0 File Offset: 0x000853F0
			// Note: this type is marked as 'beforefieldinit'.
			static _Init_d__3()
			{
				Il2CppClassPointerStore<WormLastTurnRenderer._Init_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormLastTurnRenderer>.NativeClassPtr, "<Init>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormLastTurnRenderer._Init_d__3>.NativeClassPtr);
				WormLastTurnRenderer._Init_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLastTurnRenderer._Init_d__3>.NativeClassPtr, "<>1__state");
				WormLastTurnRenderer._Init_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLastTurnRenderer._Init_d__3>.NativeClassPtr, "<>2__current");
				WormLastTurnRenderer._Init_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLastTurnRenderer._Init_d__3>.NativeClassPtr, "<>4__this");
				WormLastTurnRenderer._Init_d__3.NativeFieldInfoPtr__entities_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLastTurnRenderer._Init_d__3>.NativeClassPtr, "<entities>5__2");
				WormLastTurnRenderer._Init_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLastTurnRenderer._Init_d__3>.NativeClassPtr, 100665256);
				WormLastTurnRenderer._Init_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLastTurnRenderer._Init_d__3>.NativeClassPtr, 100665257);
				WormLastTurnRenderer._Init_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLastTurnRenderer._Init_d__3>.NativeClassPtr, 100665258);
				WormLastTurnRenderer._Init_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLastTurnRenderer._Init_d__3>.NativeClassPtr, 100665259);
				WormLastTurnRenderer._Init_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLastTurnRenderer._Init_d__3>.NativeClassPtr, 100665260);
				WormLastTurnRenderer._Init_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLastTurnRenderer._Init_d__3>.NativeClassPtr, 100665261);
			}

			// Token: 0x060024B6 RID: 9398 RVA: 0x000872E4 File Offset: 0x000854E4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Init_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormLastTurnRenderer._Init_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLastTurnRenderer._Init_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060024B7 RID: 9399 RVA: 0x0008732C File Offset: 0x0008552C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLastTurnRenderer._Init_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060024B8 RID: 9400 RVA: 0x00087360 File Offset: 0x00085560
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706609, XrefRangeEnd = 706616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLastTurnRenderer._Init_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A33 RID: 2611
			// (get) Token: 0x060024B9 RID: 9401 RVA: 0x0008739C File Offset: 0x0008559C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLastTurnRenderer._Init_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060024BA RID: 9402 RVA: 0x000873DC File Offset: 0x000855DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706616, XrefRangeEnd = 706621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLastTurnRenderer._Init_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A34 RID: 2612
			// (get) Token: 0x060024BB RID: 9403 RVA: 0x00087410 File Offset: 0x00085610
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLastTurnRenderer._Init_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060024BC RID: 9404 RVA: 0x0001479E File Offset: 0x0001299E
			public _Init_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A2F RID: 2607
			// (get) Token: 0x060024BD RID: 9405 RVA: 0x00087450 File Offset: 0x00085650
			// (set) Token: 0x060024BE RID: 9406 RVA: 0x000147A7 File Offset: 0x000129A7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLastTurnRenderer._Init_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLastTurnRenderer._Init_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A30 RID: 2608
			// (get) Token: 0x060024BF RID: 9407 RVA: 0x00087478 File Offset: 0x00085678
			// (set) Token: 0x060024C0 RID: 9408 RVA: 0x000147C2 File Offset: 0x000129C2
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLastTurnRenderer._Init_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLastTurnRenderer._Init_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A31 RID: 2609
			// (get) Token: 0x060024C1 RID: 9409 RVA: 0x000874A8 File Offset: 0x000856A8
			// (set) Token: 0x060024C2 RID: 9410 RVA: 0x000147E1 File Offset: 0x000129E1
			public unsafe WormLastTurnRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLastTurnRenderer._Init_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormLastTurnRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLastTurnRenderer._Init_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A32 RID: 2610
			// (get) Token: 0x060024C3 RID: 9411 RVA: 0x000874D8 File Offset: 0x000856D8
			// (set) Token: 0x060024C4 RID: 9412 RVA: 0x00014800 File Offset: 0x00012A00
			public unsafe DBGEntitiesProvider _entities_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLastTurnRenderer._Init_d__3.NativeFieldInfoPtr__entities_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLastTurnRenderer._Init_d__3.NativeFieldInfoPtr__entities_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001514 RID: 5396
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001515 RID: 5397
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001516 RID: 5398
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001517 RID: 5399
			private static readonly IntPtr NativeFieldInfoPtr__entities_5__2;

			// Token: 0x04001518 RID: 5400
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001519 RID: 5401
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400151A RID: 5402
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400151B RID: 5403
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400151C RID: 5404
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400151D RID: 5405
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
