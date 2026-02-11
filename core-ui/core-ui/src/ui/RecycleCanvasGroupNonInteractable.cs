using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace src.ui
{
	// Token: 0x02000009 RID: 9
	public class RecycleCanvasGroupNonInteractable : MonoBehaviour
	{
		// Token: 0x06000039 RID: 57 RVA: 0x000036A4 File Offset: 0x000018A4
		// Note: this type is marked as 'beforefieldinit'.
		static RecycleCanvasGroupNonInteractable()
		{
			Il2CppClassPointerStore<RecycleCanvasGroupNonInteractable>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-ui.dll", "src.ui", "RecycleCanvasGroupNonInteractable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecycleCanvasGroupNonInteractable>.NativeClassPtr);
			RecycleCanvasGroupNonInteractable.NativeFieldInfoPtr__canvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecycleCanvasGroupNonInteractable>.NativeClassPtr, "_canvasGroup");
			RecycleCanvasGroupNonInteractable.NativeFieldInfoPtr_recycling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecycleCanvasGroupNonInteractable>.NativeClassPtr, "recycling");
			RecycleCanvasGroupNonInteractable.NativeMethodInfoPtr_get_canvasGroup_Private_get_CanvasGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecycleCanvasGroupNonInteractable>.NativeClassPtr, 100663321);
			RecycleCanvasGroupNonInteractable.NativeMethodInfoPtr_Event_ResetGroupForNonInteractable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecycleCanvasGroupNonInteractable>.NativeClassPtr, 100663322);
			RecycleCanvasGroupNonInteractable.NativeMethodInfoPtr_resetGroupForNonInteractable_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecycleCanvasGroupNonInteractable>.NativeClassPtr, 100663323);
			RecycleCanvasGroupNonInteractable.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecycleCanvasGroupNonInteractable>.NativeClassPtr, 100663324);
			RecycleCanvasGroupNonInteractable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecycleCanvasGroupNonInteractable>.NativeClassPtr, 100663325);
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00003760 File Offset: 0x00001960
		public unsafe CanvasGroup canvasGroup
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1253575, RefRangeEnd = 1253578, XrefRangeStart = 1253567, XrefRangeEnd = 1253575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecycleCanvasGroupNonInteractable.NativeMethodInfoPtr_get_canvasGroup_Private_get_CanvasGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr3) : null;
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000037A0 File Offset: 0x000019A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253578, XrefRangeEnd = 1253584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ResetGroupForNonInteractable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecycleCanvasGroupNonInteractable.NativeMethodInfoPtr_Event_ResetGroupForNonInteractable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000037D4 File Offset: 0x000019D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253584, XrefRangeEnd = 1253589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator resetGroupForNonInteractable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecycleCanvasGroupNonInteractable.NativeMethodInfoPtr_resetGroupForNonInteractable_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003814 File Offset: 0x00001A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253589, XrefRangeEnd = 1253591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecycleCanvasGroupNonInteractable.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003848 File Offset: 0x00001A48
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RecycleCanvasGroupNonInteractable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RecycleCanvasGroupNonInteractable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecycleCanvasGroupNonInteractable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000021D7 File Offset: 0x000003D7
		public RecycleCanvasGroupNonInteractable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00003884 File Offset: 0x00001A84
		// (set) Token: 0x06000041 RID: 65 RVA: 0x000021E0 File Offset: 0x000003E0
		public unsafe CanvasGroup _canvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecycleCanvasGroupNonInteractable.NativeFieldInfoPtr__canvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecycleCanvasGroupNonInteractable.NativeFieldInfoPtr__canvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000042 RID: 66 RVA: 0x000038B4 File Offset: 0x00001AB4
		// (set) Token: 0x06000043 RID: 67 RVA: 0x000021FF File Offset: 0x000003FF
		public unsafe bool recycling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecycleCanvasGroupNonInteractable.NativeFieldInfoPtr_recycling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecycleCanvasGroupNonInteractable.NativeFieldInfoPtr_recycling)) = value;
			}
		}

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeFieldInfoPtr__canvasGroup;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeFieldInfoPtr_recycling;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_get_canvasGroup_Private_get_CanvasGroup_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_Event_ResetGroupForNonInteractable_Public_Void_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_resetGroupForNonInteractable_Private_IEnumerator_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000020 RID: 32
		[ObfuscatedName("src.ui.RecycleCanvasGroupNonInteractable+<resetGroupForNonInteractable>d__5")]
		public sealed class _resetGroupForNonInteractable_d__5 : global::Il2CppSystem.Object
		{
			// Token: 0x06000144 RID: 324 RVA: 0x00006BDC File Offset: 0x00004DDC
			// Note: this type is marked as 'beforefieldinit'.
			static _resetGroupForNonInteractable_d__5()
			{
				Il2CppClassPointerStore<RecycleCanvasGroupNonInteractable._resetGroupForNonInteractable_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RecycleCanvasGroupNonInteractable>.NativeClassPtr, "<resetGroupForNonInteractable>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecycleCanvasGroupNonInteractable._resetGroupForNonInteractable_d__5>.NativeClassPtr);
				RecycleCanvasGroupNonInteractable._resetGroupForNonInteractable_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecycleCanvasGroupNonInteractable._resetGroupForNonInteractable_d__5>.NativeClassPtr, "<>1__state");
				RecycleCanvasGroupNonInteractable._resetGroupForNonInteractable_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecycleCanvasGroupNonInteractable._resetGroupForNonInteractable_d__5>.NativeClassPtr, "<>2__current");
				RecycleCanvasGroupNonInteractable._resetGroupForNonInteractable_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecycleCanvasGroupNonInteractable._resetGroupForNonInteractable_d__5>.NativeClassPtr, "<>4__this");
				RecycleCanvasGroupNonInteractable._resetGroupForNonInteractable_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecycleCanvasGroupNonInteractable._resetGroupForNonInteractable_d__5>.NativeClassPtr, 100663326);
				RecycleCanvasGroupNonInteractable._resetGroupForNonInteractable_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecycleCanvasGroupNonInteractable._resetGroupForNonInteractable_d__5>.NativeClassPtr, 100663327);
				RecycleCanvasGroupNonInteractable._resetGroupForNonInteractable_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecycleCanvasGroupNonInteractable._resetGroupForNonInteractable_d__5>.NativeClassPtr, 100663328);
				RecycleCanvasGroupNonInteractable._resetGroupForNonInteractable_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecycleCanvasGroupNonInteractable._resetGroupForNonInteractable_d__5>.NativeClassPtr, 100663329);
				RecycleCanvasGroupNonInteractable._resetGroupForNonInteractable_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecycleCanvasGroupNonInteractable._resetGroupForNonInteractable_d__5>.NativeClassPtr, 100663330);
				RecycleCanvasGroupNonInteractable._resetGroupForNonInteractable_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecycleCanvasGroupNonInteractable._resetGroupForNonInteractable_d__5>.NativeClassPtr, 100663331);
			}

			// Token: 0x06000145 RID: 325 RVA: 0x00006CBC File Offset: 0x00004EBC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _resetGroupForNonInteractable_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RecycleCanvasGroupNonInteractable._resetGroupForNonInteractable_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecycleCanvasGroupNonInteractable._resetGroupForNonInteractable_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000146 RID: 326 RVA: 0x00006D04 File Offset: 0x00004F04
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecycleCanvasGroupNonInteractable._resetGroupForNonInteractable_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000147 RID: 327 RVA: 0x00006D38 File Offset: 0x00004F38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253553, XrefRangeEnd = 1253562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecycleCanvasGroupNonInteractable._resetGroupForNonInteractable_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000052 RID: 82
			// (get) Token: 0x06000148 RID: 328 RVA: 0x00006D74 File Offset: 0x00004F74
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecycleCanvasGroupNonInteractable._resetGroupForNonInteractable_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000149 RID: 329 RVA: 0x00006DB4 File Offset: 0x00004FB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253562, XrefRangeEnd = 1253567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecycleCanvasGroupNonInteractable._resetGroupForNonInteractable_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000053 RID: 83
			// (get) Token: 0x0600014A RID: 330 RVA: 0x00006DE8 File Offset: 0x00004FE8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecycleCanvasGroupNonInteractable._resetGroupForNonInteractable_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600014B RID: 331 RVA: 0x00002971 File Offset: 0x00000B71
			public _resetGroupForNonInteractable_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700004F RID: 79
			// (get) Token: 0x0600014C RID: 332 RVA: 0x00006E28 File Offset: 0x00005028
			// (set) Token: 0x0600014D RID: 333 RVA: 0x0000297A File Offset: 0x00000B7A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecycleCanvasGroupNonInteractable._resetGroupForNonInteractable_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecycleCanvasGroupNonInteractable._resetGroupForNonInteractable_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000050 RID: 80
			// (get) Token: 0x0600014E RID: 334 RVA: 0x00006E50 File Offset: 0x00005050
			// (set) Token: 0x0600014F RID: 335 RVA: 0x00002995 File Offset: 0x00000B95
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecycleCanvasGroupNonInteractable._resetGroupForNonInteractable_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecycleCanvasGroupNonInteractable._resetGroupForNonInteractable_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000051 RID: 81
			// (get) Token: 0x06000150 RID: 336 RVA: 0x00006E80 File Offset: 0x00005080
			// (set) Token: 0x06000151 RID: 337 RVA: 0x000029B4 File Offset: 0x00000BB4
			public unsafe RecycleCanvasGroupNonInteractable __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecycleCanvasGroupNonInteractable._resetGroupForNonInteractable_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RecycleCanvasGroupNonInteractable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecycleCanvasGroupNonInteractable._resetGroupForNonInteractable_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000C6 RID: 198
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040000C7 RID: 199
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040000C8 RID: 200
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040000C9 RID: 201
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040000CA RID: 202
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000CB RID: 203
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040000CC RID: 204
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040000CD RID: 205
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000CE RID: 206
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
