using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine.SceneManagement;

namespace dwd.core.input.compositeModule
{
	// Token: 0x02000088 RID: 136
	public class EventsForInputModuleActivationPersistent : EventsForInputModuleActivation
	{
		// Token: 0x060005F5 RID: 1525 RVA: 0x00019B2C File Offset: 0x00017D2C
		// Note: this type is marked as 'beforefieldinit'.
		static EventsForInputModuleActivationPersistent()
		{
			Il2CppClassPointerStore<EventsForInputModuleActivationPersistent>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.compositeModule", "EventsForInputModuleActivationPersistent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForInputModuleActivationPersistent>.NativeClassPtr);
			EventsForInputModuleActivationPersistent.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForInputModuleActivationPersistent>.NativeClassPtr, 100664027);
			EventsForInputModuleActivationPersistent.NativeMethodInfoPtr_OnSceneLoaded_Private_Void_Scene_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForInputModuleActivationPersistent>.NativeClassPtr, 100664028);
			EventsForInputModuleActivationPersistent.NativeMethodInfoPtr_UpdateModel_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForInputModuleActivationPersistent>.NativeClassPtr, 100664029);
			EventsForInputModuleActivationPersistent.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForInputModuleActivationPersistent>.NativeClassPtr, 100664030);
			EventsForInputModuleActivationPersistent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForInputModuleActivationPersistent>.NativeClassPtr, 100664031);
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00019BC0 File Offset: 0x00017DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124990, XrefRangeEnd = 1125013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventsForInputModuleActivationPersistent.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00019BFC File Offset: 0x00017DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125013, XrefRangeEnd = 1125019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForInputModuleActivationPersistent.NativeMethodInfoPtr_OnSceneLoaded_Private_Void_Scene_LoadSceneMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00019C48 File Offset: 0x00017E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125019, XrefRangeEnd = 1125024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator UpdateModel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForInputModuleActivationPersistent.NativeMethodInfoPtr_UpdateModel_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00019C88 File Offset: 0x00017E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125024, XrefRangeEnd = 1125034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForInputModuleActivationPersistent.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00019CBC File Offset: 0x00017EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsForInputModuleActivationPersistent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForInputModuleActivationPersistent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForInputModuleActivationPersistent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00005474 File Offset: 0x00003674
		public EventsForInputModuleActivationPersistent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400039B RID: 923
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400039C RID: 924
		private static readonly IntPtr NativeMethodInfoPtr_OnSceneLoaded_Private_Void_Scene_LoadSceneMode_0;

		// Token: 0x0400039D RID: 925
		private static readonly IntPtr NativeMethodInfoPtr_UpdateModel_Private_IEnumerator_0;

		// Token: 0x0400039E RID: 926
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400039F RID: 927
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000DA RID: 218
		[ObfuscatedName("dwd.core.input.compositeModule.EventsForInputModuleActivationPersistent+<UpdateModel>d__2")]
		public sealed class _UpdateModel_d__2 : Object
		{
			// Token: 0x060009A0 RID: 2464 RVA: 0x00025E6C File Offset: 0x0002406C
			// Note: this type is marked as 'beforefieldinit'.
			static _UpdateModel_d__2()
			{
				Il2CppClassPointerStore<EventsForInputModuleActivationPersistent._UpdateModel_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventsForInputModuleActivationPersistent>.NativeClassPtr, "<UpdateModel>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForInputModuleActivationPersistent._UpdateModel_d__2>.NativeClassPtr);
				EventsForInputModuleActivationPersistent._UpdateModel_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForInputModuleActivationPersistent._UpdateModel_d__2>.NativeClassPtr, "<>1__state");
				EventsForInputModuleActivationPersistent._UpdateModel_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForInputModuleActivationPersistent._UpdateModel_d__2>.NativeClassPtr, "<>2__current");
				EventsForInputModuleActivationPersistent._UpdateModel_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForInputModuleActivationPersistent._UpdateModel_d__2>.NativeClassPtr, "<>4__this");
				EventsForInputModuleActivationPersistent._UpdateModel_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForInputModuleActivationPersistent._UpdateModel_d__2>.NativeClassPtr, 100664032);
				EventsForInputModuleActivationPersistent._UpdateModel_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForInputModuleActivationPersistent._UpdateModel_d__2>.NativeClassPtr, 100664033);
				EventsForInputModuleActivationPersistent._UpdateModel_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForInputModuleActivationPersistent._UpdateModel_d__2>.NativeClassPtr, 100664034);
				EventsForInputModuleActivationPersistent._UpdateModel_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForInputModuleActivationPersistent._UpdateModel_d__2>.NativeClassPtr, 100664035);
				EventsForInputModuleActivationPersistent._UpdateModel_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForInputModuleActivationPersistent._UpdateModel_d__2>.NativeClassPtr, 100664036);
				EventsForInputModuleActivationPersistent._UpdateModel_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForInputModuleActivationPersistent._UpdateModel_d__2>.NativeClassPtr, 100664037);
			}

			// Token: 0x060009A1 RID: 2465 RVA: 0x00025F4C File Offset: 0x0002414C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _UpdateModel_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForInputModuleActivationPersistent._UpdateModel_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForInputModuleActivationPersistent._UpdateModel_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060009A2 RID: 2466 RVA: 0x00025F94 File Offset: 0x00024194
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForInputModuleActivationPersistent._UpdateModel_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060009A3 RID: 2467 RVA: 0x00025FC8 File Offset: 0x000241C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124974, XrefRangeEnd = 1124985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForInputModuleActivationPersistent._UpdateModel_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170002CF RID: 719
			// (get) Token: 0x060009A4 RID: 2468 RVA: 0x00026004 File Offset: 0x00024204
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForInputModuleActivationPersistent._UpdateModel_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060009A5 RID: 2469 RVA: 0x00026044 File Offset: 0x00024244
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124985, XrefRangeEnd = 1124990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForInputModuleActivationPersistent._UpdateModel_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170002D0 RID: 720
			// (get) Token: 0x060009A6 RID: 2470 RVA: 0x00026078 File Offset: 0x00024278
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForInputModuleActivationPersistent._UpdateModel_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060009A7 RID: 2471 RVA: 0x00006FEE File Offset: 0x000051EE
			public _UpdateModel_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170002CC RID: 716
			// (get) Token: 0x060009A8 RID: 2472 RVA: 0x000260B8 File Offset: 0x000242B8
			// (set) Token: 0x060009A9 RID: 2473 RVA: 0x00006FF7 File Offset: 0x000051F7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForInputModuleActivationPersistent._UpdateModel_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForInputModuleActivationPersistent._UpdateModel_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170002CD RID: 717
			// (get) Token: 0x060009AA RID: 2474 RVA: 0x000260E0 File Offset: 0x000242E0
			// (set) Token: 0x060009AB RID: 2475 RVA: 0x00007012 File Offset: 0x00005212
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForInputModuleActivationPersistent._UpdateModel_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForInputModuleActivationPersistent._UpdateModel_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002CE RID: 718
			// (get) Token: 0x060009AC RID: 2476 RVA: 0x00026110 File Offset: 0x00024310
			// (set) Token: 0x060009AD RID: 2477 RVA: 0x00007031 File Offset: 0x00005231
			public unsafe EventsForInputModuleActivationPersistent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForInputModuleActivationPersistent._UpdateModel_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventsForInputModuleActivationPersistent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForInputModuleActivationPersistent._UpdateModel_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040005F3 RID: 1523
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040005F4 RID: 1524
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040005F5 RID: 1525
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040005F6 RID: 1526
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040005F7 RID: 1527
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040005F8 RID: 1528
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040005F9 RID: 1529
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040005FA RID: 1530
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040005FB RID: 1531
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
