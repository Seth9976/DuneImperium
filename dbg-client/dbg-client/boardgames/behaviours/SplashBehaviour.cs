using System;
using dwd.core.animation;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace boardgames.behaviours
{
	// Token: 0x020002B3 RID: 691
	public class SplashBehaviour : MonoBehaviour
	{
		// Token: 0x060020B1 RID: 8369 RVA: 0x0008A65C File Offset: 0x0008885C
		// Note: this type is marked as 'beforefieldinit'.
		static SplashBehaviour()
		{
			Il2CppClassPointerStore<SplashBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.behaviours", "SplashBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SplashBehaviour>.NativeClassPtr);
			SplashBehaviour.NativeFieldInfoPtr_introAnimations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplashBehaviour>.NativeClassPtr, "introAnimations");
			SplashBehaviour.NativeMethodInfoPtr_PlayAnimations_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplashBehaviour>.NativeClassPtr, 100668721);
			SplashBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplashBehaviour>.NativeClassPtr, 100668722);
		}

		// Token: 0x060020B2 RID: 8370 RVA: 0x0008A6C8 File Offset: 0x000888C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 542703, RefRangeEnd = 542704, XrefRangeStart = 542698, XrefRangeEnd = 542703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator PlayAnimations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SplashBehaviour.NativeMethodInfoPtr_PlayAnimations_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060020B3 RID: 8371 RVA: 0x0008A708 File Offset: 0x00088908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542704, XrefRangeEnd = 542709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SplashBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SplashBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SplashBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020B4 RID: 8372 RVA: 0x000111F9 File Offset: 0x0000F3F9
		public SplashBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x060020B5 RID: 8373 RVA: 0x0008A744 File Offset: 0x00088944
		// (set) Token: 0x060020B6 RID: 8374 RVA: 0x00011202 File Offset: 0x0000F402
		public unsafe Il2CppReferenceArray<TriggeredBlockingAnimation> introAnimations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SplashBehaviour.NativeFieldInfoPtr_introAnimations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TriggeredBlockingAnimation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SplashBehaviour.NativeFieldInfoPtr_introAnimations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014A1 RID: 5281
		private static readonly IntPtr NativeFieldInfoPtr_introAnimations;

		// Token: 0x040014A2 RID: 5282
		private static readonly IntPtr NativeMethodInfoPtr_PlayAnimations_Public_IEnumerator_0;

		// Token: 0x040014A3 RID: 5283
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020004A6 RID: 1190
		[ObfuscatedName("boardgames.behaviours.SplashBehaviour+<PlayAnimations>d__1")]
		public sealed class _PlayAnimations_d__1 : global::Il2CppSystem.Object
		{
			// Token: 0x0600386E RID: 14446 RVA: 0x000D1040 File Offset: 0x000CF240
			// Note: this type is marked as 'beforefieldinit'.
			static _PlayAnimations_d__1()
			{
				Il2CppClassPointerStore<SplashBehaviour._PlayAnimations_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SplashBehaviour>.NativeClassPtr, "<PlayAnimations>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SplashBehaviour._PlayAnimations_d__1>.NativeClassPtr);
				SplashBehaviour._PlayAnimations_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplashBehaviour._PlayAnimations_d__1>.NativeClassPtr, "<>1__state");
				SplashBehaviour._PlayAnimations_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplashBehaviour._PlayAnimations_d__1>.NativeClassPtr, "<>2__current");
				SplashBehaviour._PlayAnimations_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplashBehaviour._PlayAnimations_d__1>.NativeClassPtr, "<>4__this");
				SplashBehaviour._PlayAnimations_d__1.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplashBehaviour._PlayAnimations_d__1>.NativeClassPtr, "<>7__wrap1");
				SplashBehaviour._PlayAnimations_d__1.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplashBehaviour._PlayAnimations_d__1>.NativeClassPtr, "<>7__wrap2");
				SplashBehaviour._PlayAnimations_d__1.NativeFieldInfoPtr__currentAnimation_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplashBehaviour._PlayAnimations_d__1>.NativeClassPtr, "<currentAnimation>5__4");
				SplashBehaviour._PlayAnimations_d__1.NativeFieldInfoPtr__skipping_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplashBehaviour._PlayAnimations_d__1>.NativeClassPtr, "<skipping>5__5");
				SplashBehaviour._PlayAnimations_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplashBehaviour._PlayAnimations_d__1>.NativeClassPtr, 100668723);
				SplashBehaviour._PlayAnimations_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplashBehaviour._PlayAnimations_d__1>.NativeClassPtr, 100668724);
				SplashBehaviour._PlayAnimations_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplashBehaviour._PlayAnimations_d__1>.NativeClassPtr, 100668725);
				SplashBehaviour._PlayAnimations_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplashBehaviour._PlayAnimations_d__1>.NativeClassPtr, 100668726);
				SplashBehaviour._PlayAnimations_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplashBehaviour._PlayAnimations_d__1>.NativeClassPtr, 100668727);
				SplashBehaviour._PlayAnimations_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplashBehaviour._PlayAnimations_d__1>.NativeClassPtr, 100668728);
			}

			// Token: 0x0600386F RID: 14447 RVA: 0x000D1170 File Offset: 0x000CF370
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PlayAnimations_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SplashBehaviour._PlayAnimations_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SplashBehaviour._PlayAnimations_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003870 RID: 14448 RVA: 0x000D11B8 File Offset: 0x000CF3B8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SplashBehaviour._PlayAnimations_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003871 RID: 14449 RVA: 0x000D11EC File Offset: 0x000CF3EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542672, XrefRangeEnd = 542693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SplashBehaviour._PlayAnimations_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170010B5 RID: 4277
			// (get) Token: 0x06003872 RID: 14450 RVA: 0x000D1228 File Offset: 0x000CF428
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SplashBehaviour._PlayAnimations_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003873 RID: 14451 RVA: 0x000D1268 File Offset: 0x000CF468
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542693, XrefRangeEnd = 542698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SplashBehaviour._PlayAnimations_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170010B6 RID: 4278
			// (get) Token: 0x06003874 RID: 14452 RVA: 0x000D129C File Offset: 0x000CF49C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SplashBehaviour._PlayAnimations_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003875 RID: 14453 RVA: 0x0001D07C File Offset: 0x0001B27C
			public _PlayAnimations_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010AE RID: 4270
			// (get) Token: 0x06003876 RID: 14454 RVA: 0x000D12DC File Offset: 0x000CF4DC
			// (set) Token: 0x06003877 RID: 14455 RVA: 0x0001D085 File Offset: 0x0001B285
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SplashBehaviour._PlayAnimations_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SplashBehaviour._PlayAnimations_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170010AF RID: 4271
			// (get) Token: 0x06003878 RID: 14456 RVA: 0x000D1304 File Offset: 0x000CF504
			// (set) Token: 0x06003879 RID: 14457 RVA: 0x0001D0A0 File Offset: 0x0001B2A0
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SplashBehaviour._PlayAnimations_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SplashBehaviour._PlayAnimations_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010B0 RID: 4272
			// (get) Token: 0x0600387A RID: 14458 RVA: 0x000D1334 File Offset: 0x000CF534
			// (set) Token: 0x0600387B RID: 14459 RVA: 0x0001D0BF File Offset: 0x0001B2BF
			public unsafe SplashBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SplashBehaviour._PlayAnimations_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SplashBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SplashBehaviour._PlayAnimations_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010B1 RID: 4273
			// (get) Token: 0x0600387C RID: 14460 RVA: 0x000D1364 File Offset: 0x000CF564
			// (set) Token: 0x0600387D RID: 14461 RVA: 0x0001D0DE File Offset: 0x0001B2DE
			public unsafe Il2CppReferenceArray<TriggeredBlockingAnimation> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SplashBehaviour._PlayAnimations_d__1.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TriggeredBlockingAnimation>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SplashBehaviour._PlayAnimations_d__1.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010B2 RID: 4274
			// (get) Token: 0x0600387E RID: 14462 RVA: 0x000D1394 File Offset: 0x000CF594
			// (set) Token: 0x0600387F RID: 14463 RVA: 0x0001D0FD File Offset: 0x0001B2FD
			public unsafe int __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SplashBehaviour._PlayAnimations_d__1.NativeFieldInfoPtr___7__wrap2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SplashBehaviour._PlayAnimations_d__1.NativeFieldInfoPtr___7__wrap2)) = value;
				}
			}

			// Token: 0x170010B3 RID: 4275
			// (get) Token: 0x06003880 RID: 14464 RVA: 0x000D13BC File Offset: 0x000CF5BC
			// (set) Token: 0x06003881 RID: 14465 RVA: 0x0001D118 File Offset: 0x0001B318
			public unsafe TriggeredBlockingAnimation _currentAnimation_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SplashBehaviour._PlayAnimations_d__1.NativeFieldInfoPtr__currentAnimation_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TriggeredBlockingAnimation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SplashBehaviour._PlayAnimations_d__1.NativeFieldInfoPtr__currentAnimation_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010B4 RID: 4276
			// (get) Token: 0x06003882 RID: 14466 RVA: 0x000D13EC File Offset: 0x000CF5EC
			// (set) Token: 0x06003883 RID: 14467 RVA: 0x0001D137 File Offset: 0x0001B337
			public unsafe bool _skipping_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SplashBehaviour._PlayAnimations_d__1.NativeFieldInfoPtr__skipping_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SplashBehaviour._PlayAnimations_d__1.NativeFieldInfoPtr__skipping_5__5)) = value;
				}
			}

			// Token: 0x040022AE RID: 8878
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040022AF RID: 8879
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040022B0 RID: 8880
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040022B1 RID: 8881
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040022B2 RID: 8882
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x040022B3 RID: 8883
			private static readonly IntPtr NativeFieldInfoPtr__currentAnimation_5__4;

			// Token: 0x040022B4 RID: 8884
			private static readonly IntPtr NativeFieldInfoPtr__skipping_5__5;

			// Token: 0x040022B5 RID: 8885
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040022B6 RID: 8886
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040022B7 RID: 8887
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040022B8 RID: 8888
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040022B9 RID: 8889
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040022BA RID: 8890
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
