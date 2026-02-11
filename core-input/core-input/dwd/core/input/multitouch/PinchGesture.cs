using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace dwd.core.input.multitouch
{
	// Token: 0x0200006C RID: 108
	public sealed class PinchGesture : MonoBehaviour
	{
		// Token: 0x0600042E RID: 1070 RVA: 0x00013DD8 File Offset: 0x00011FD8
		// Note: this type is marked as 'beforefieldinit'.
		static PinchGesture()
		{
			Il2CppClassPointerStore<PinchGesture>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.multitouch", "PinchGesture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PinchGesture>.NativeClassPtr);
			PinchGesture.NativeFieldInfoPtr__TwoFingerGesture_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PinchGesture>.NativeClassPtr, "<TwoFingerGesture>k__BackingField");
			PinchGesture.NativeFieldInfoPtr_PreviousPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PinchGesture>.NativeClassPtr, "PreviousPosition");
			PinchGesture.NativeMethodInfoPtr_get_TwoFingerGesture_Public_get_Gesture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinchGesture>.NativeClassPtr, 100663763);
			PinchGesture.NativeMethodInfoPtr_set_TwoFingerGesture_Private_set_Void_Gesture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinchGesture>.NativeClassPtr, 100663764);
			PinchGesture.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinchGesture>.NativeClassPtr, 100663765);
			PinchGesture.NativeMethodInfoPtr_get_Delta_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinchGesture>.NativeClassPtr, 100663766);
			PinchGesture.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinchGesture>.NativeClassPtr, 100663767);
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x0600042F RID: 1071 RVA: 0x00013E94 File Offset: 0x00012094
		// (set) Token: 0x06000430 RID: 1072 RVA: 0x00013ED4 File Offset: 0x000120D4
		public unsafe Gesture TwoFingerGesture
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PinchGesture.NativeMethodInfoPtr_get_TwoFingerGesture_Public_get_Gesture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Gesture>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PinchGesture.NativeMethodInfoPtr_set_TwoFingerGesture_Private_set_Void_Gesture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00013F18 File Offset: 0x00012118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122578, XrefRangeEnd = 1122583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PinchGesture.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x00013F58 File Offset: 0x00012158
		public unsafe float Delta
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122583, XrefRangeEnd = 1122585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PinchGesture.NativeMethodInfoPtr_get_Delta_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00013F94 File Offset: 0x00012194
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PinchGesture()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PinchGesture>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PinchGesture.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00004674 File Offset: 0x00002874
		public PinchGesture(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x00013FD0 File Offset: 0x000121D0
		// (set) Token: 0x06000436 RID: 1078 RVA: 0x0000467D File Offset: 0x0000287D
		public unsafe Gesture _TwoFingerGesture_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PinchGesture.NativeFieldInfoPtr__TwoFingerGesture_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gesture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PinchGesture.NativeFieldInfoPtr__TwoFingerGesture_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x00014000 File Offset: 0x00012200
		// (set) Token: 0x06000438 RID: 1080 RVA: 0x0000469C File Offset: 0x0000289C
		public unsafe ReadOnlyDictionary<TouchPress, Vector2> PreviousPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PinchGesture.NativeFieldInfoPtr_PreviousPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyDictionary<TouchPress, Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PinchGesture.NativeFieldInfoPtr_PreviousPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeFieldInfoPtr__TwoFingerGesture_k__BackingField;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeFieldInfoPtr_PreviousPosition;

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeMethodInfoPtr_get_TwoFingerGesture_Public_get_Gesture_0;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeMethodInfoPtr_set_TwoFingerGesture_Private_set_Void_Gesture_0;

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeMethodInfoPtr_get_Delta_Public_get_Single_0;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000CA RID: 202
		[ObfuscatedName("dwd.core.input.multitouch.PinchGesture+<Start>d__5")]
		public sealed class _Start_d__5 : global::Il2CppSystem.Object
		{
			// Token: 0x060008DA RID: 2266 RVA: 0x0002391C File Offset: 0x00021B1C
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__5()
			{
				Il2CppClassPointerStore<PinchGesture._Start_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PinchGesture>.NativeClassPtr, "<Start>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PinchGesture._Start_d__5>.NativeClassPtr);
				PinchGesture._Start_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PinchGesture._Start_d__5>.NativeClassPtr, "<>1__state");
				PinchGesture._Start_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PinchGesture._Start_d__5>.NativeClassPtr, "<>2__current");
				PinchGesture._Start_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PinchGesture._Start_d__5>.NativeClassPtr, "<>4__this");
				PinchGesture._Start_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinchGesture._Start_d__5>.NativeClassPtr, 100663768);
				PinchGesture._Start_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinchGesture._Start_d__5>.NativeClassPtr, 100663769);
				PinchGesture._Start_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinchGesture._Start_d__5>.NativeClassPtr, 100663770);
				PinchGesture._Start_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinchGesture._Start_d__5>.NativeClassPtr, 100663771);
				PinchGesture._Start_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinchGesture._Start_d__5>.NativeClassPtr, 100663772);
				PinchGesture._Start_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinchGesture._Start_d__5>.NativeClassPtr, 100663773);
			}

			// Token: 0x060008DB RID: 2267 RVA: 0x000239FC File Offset: 0x00021BFC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PinchGesture._Start_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PinchGesture._Start_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060008DC RID: 2268 RVA: 0x00023A44 File Offset: 0x00021C44
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PinchGesture._Start_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060008DD RID: 2269 RVA: 0x00023A78 File Offset: 0x00021C78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122566, XrefRangeEnd = 1122573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PinchGesture._Start_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700028D RID: 653
			// (get) Token: 0x060008DE RID: 2270 RVA: 0x00023AB4 File Offset: 0x00021CB4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PinchGesture._Start_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060008DF RID: 2271 RVA: 0x00023AF4 File Offset: 0x00021CF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122573, XrefRangeEnd = 1122578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PinchGesture._Start_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700028E RID: 654
			// (get) Token: 0x060008E0 RID: 2272 RVA: 0x00023B28 File Offset: 0x00021D28
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PinchGesture._Start_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060008E1 RID: 2273 RVA: 0x000069D5 File Offset: 0x00004BD5
			public _Start_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700028A RID: 650
			// (get) Token: 0x060008E2 RID: 2274 RVA: 0x00023B68 File Offset: 0x00021D68
			// (set) Token: 0x060008E3 RID: 2275 RVA: 0x000069DE File Offset: 0x00004BDE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PinchGesture._Start_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PinchGesture._Start_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700028B RID: 651
			// (get) Token: 0x060008E4 RID: 2276 RVA: 0x00023B90 File Offset: 0x00021D90
			// (set) Token: 0x060008E5 RID: 2277 RVA: 0x000069F9 File Offset: 0x00004BF9
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PinchGesture._Start_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PinchGesture._Start_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700028C RID: 652
			// (get) Token: 0x060008E6 RID: 2278 RVA: 0x00023BC0 File Offset: 0x00021DC0
			// (set) Token: 0x060008E7 RID: 2279 RVA: 0x00006A18 File Offset: 0x00004C18
			public unsafe PinchGesture __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PinchGesture._Start_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PinchGesture>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PinchGesture._Start_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400057D RID: 1405
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400057E RID: 1406
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400057F RID: 1407
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000580 RID: 1408
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000581 RID: 1409
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000582 RID: 1410
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000583 RID: 1411
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000584 RID: 1412
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000585 RID: 1413
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
