using System;
using boardgames;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace lotus
{
	// Token: 0x0200000D RID: 13
	public class CutScenePlayAnimation : CutSceneAction
	{
		// Token: 0x0600006B RID: 107 RVA: 0x000044AC File Offset: 0x000026AC
		// Note: this type is marked as 'beforefieldinit'.
		static CutScenePlayAnimation()
		{
			Il2CppClassPointerStore<CutScenePlayAnimation>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-cutscenes.dll", "lotus", "CutScenePlayAnimation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CutScenePlayAnimation>.NativeClassPtr);
			CutScenePlayAnimation.NativeFieldInfoPtr_viewKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutScenePlayAnimation>.NativeClassPtr, "viewKey");
			CutScenePlayAnimation.NativeFieldInfoPtr_param = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutScenePlayAnimation>.NativeClassPtr, "param");
			CutScenePlayAnimation.NativeFieldInfoPtr_blockOnAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutScenePlayAnimation>.NativeClassPtr, "blockOnAnimation");
			CutScenePlayAnimation.NativeMethodInfoPtr_Play_Public_Virtual_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutScenePlayAnimation>.NativeClassPtr, 100663376);
			CutScenePlayAnimation.NativeMethodInfoPtr_play_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutScenePlayAnimation>.NativeClassPtr, 100663377);
			CutScenePlayAnimation.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutScenePlayAnimation>.NativeClassPtr, 100663378);
			CutScenePlayAnimation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutScenePlayAnimation>.NativeClassPtr, 100663379);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00004568 File Offset: 0x00002768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258317, XrefRangeEnd = 1258326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Command Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CutScenePlayAnimation.NativeMethodInfoPtr_Play_Public_Virtual_Command_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000045B4 File Offset: 0x000027B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258326, XrefRangeEnd = 1258331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutScenePlayAnimation.NativeMethodInfoPtr_play_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000045F4 File Offset: 0x000027F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258331, XrefRangeEnd = 1258337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CutScenePlayAnimation.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00004638 File Offset: 0x00002838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CutScenePlayAnimation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CutScenePlayAnimation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutScenePlayAnimation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000022BC File Offset: 0x000004BC
		public CutScenePlayAnimation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00004674 File Offset: 0x00002874
		// (set) Token: 0x06000072 RID: 114 RVA: 0x000022C5 File Offset: 0x000004C5
		public unsafe string viewKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutScenePlayAnimation.NativeFieldInfoPtr_viewKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutScenePlayAnimation.NativeFieldInfoPtr_viewKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000073 RID: 115 RVA: 0x0000469C File Offset: 0x0000289C
		// (set) Token: 0x06000074 RID: 116 RVA: 0x000022E4 File Offset: 0x000004E4
		public unsafe AnimationParameter param
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutScenePlayAnimation.NativeFieldInfoPtr_param);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutScenePlayAnimation.NativeFieldInfoPtr_param), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000075 RID: 117 RVA: 0x000046CC File Offset: 0x000028CC
		// (set) Token: 0x06000076 RID: 118 RVA: 0x00002303 File Offset: 0x00000503
		public unsafe bool blockOnAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutScenePlayAnimation.NativeFieldInfoPtr_blockOnAnimation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutScenePlayAnimation.NativeFieldInfoPtr_blockOnAnimation)) = value;
			}
		}

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeFieldInfoPtr_viewKey;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeFieldInfoPtr_param;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeFieldInfoPtr_blockOnAnimation;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Virtual_Command_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_play_Private_IEnumerator_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000026 RID: 38
		[ObfuscatedName("lotus.CutScenePlayAnimation+<play>d__4")]
		public sealed class _play_d__4 : Object
		{
			// Token: 0x0600015C RID: 348 RVA: 0x00007404 File Offset: 0x00005604
			// Note: this type is marked as 'beforefieldinit'.
			static _play_d__4()
			{
				Il2CppClassPointerStore<CutScenePlayAnimation._play_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CutScenePlayAnimation>.NativeClassPtr, "<play>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CutScenePlayAnimation._play_d__4>.NativeClassPtr);
				CutScenePlayAnimation._play_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutScenePlayAnimation._play_d__4>.NativeClassPtr, "<>1__state");
				CutScenePlayAnimation._play_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutScenePlayAnimation._play_d__4>.NativeClassPtr, "<>2__current");
				CutScenePlayAnimation._play_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutScenePlayAnimation._play_d__4>.NativeClassPtr, "<>4__this");
				CutScenePlayAnimation._play_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutScenePlayAnimation._play_d__4>.NativeClassPtr, 100663380);
				CutScenePlayAnimation._play_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutScenePlayAnimation._play_d__4>.NativeClassPtr, 100663381);
				CutScenePlayAnimation._play_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutScenePlayAnimation._play_d__4>.NativeClassPtr, 100663382);
				CutScenePlayAnimation._play_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutScenePlayAnimation._play_d__4>.NativeClassPtr, 100663383);
				CutScenePlayAnimation._play_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutScenePlayAnimation._play_d__4>.NativeClassPtr, 100663384);
				CutScenePlayAnimation._play_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutScenePlayAnimation._play_d__4>.NativeClassPtr, 100663385);
			}

			// Token: 0x0600015D RID: 349 RVA: 0x000074E4 File Offset: 0x000056E4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _play_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CutScenePlayAnimation._play_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutScenePlayAnimation._play_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600015E RID: 350 RVA: 0x0000752C File Offset: 0x0000572C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutScenePlayAnimation._play_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600015F RID: 351 RVA: 0x00007560 File Offset: 0x00005760
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258299, XrefRangeEnd = 1258312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutScenePlayAnimation._play_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000056 RID: 86
			// (get) Token: 0x06000160 RID: 352 RVA: 0x0000759C File Offset: 0x0000579C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutScenePlayAnimation._play_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000161 RID: 353 RVA: 0x000075DC File Offset: 0x000057DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258312, XrefRangeEnd = 1258317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutScenePlayAnimation._play_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000057 RID: 87
			// (get) Token: 0x06000162 RID: 354 RVA: 0x00007610 File Offset: 0x00005810
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutScenePlayAnimation._play_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000163 RID: 355 RVA: 0x00002971 File Offset: 0x00000B71
			public _play_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000053 RID: 83
			// (get) Token: 0x06000164 RID: 356 RVA: 0x00007650 File Offset: 0x00005850
			// (set) Token: 0x06000165 RID: 357 RVA: 0x0000297A File Offset: 0x00000B7A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutScenePlayAnimation._play_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutScenePlayAnimation._play_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000054 RID: 84
			// (get) Token: 0x06000166 RID: 358 RVA: 0x00007678 File Offset: 0x00005878
			// (set) Token: 0x06000167 RID: 359 RVA: 0x00002995 File Offset: 0x00000B95
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutScenePlayAnimation._play_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutScenePlayAnimation._play_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000055 RID: 85
			// (get) Token: 0x06000168 RID: 360 RVA: 0x000076A8 File Offset: 0x000058A8
			// (set) Token: 0x06000169 RID: 361 RVA: 0x000029B4 File Offset: 0x00000BB4
			public unsafe CutScenePlayAnimation __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutScenePlayAnimation._play_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CutScenePlayAnimation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutScenePlayAnimation._play_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000D0 RID: 208
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040000D1 RID: 209
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040000D2 RID: 210
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040000D3 RID: 211
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040000D4 RID: 212
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000D5 RID: 213
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040000D6 RID: 214
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040000D7 RID: 215
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000D8 RID: 216
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
