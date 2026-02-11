using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace lotus
{
	// Token: 0x0200000E RID: 14
	public class CutScenePlayCutscene : CutSceneAction
	{
		// Token: 0x06000077 RID: 119 RVA: 0x000046F4 File Offset: 0x000028F4
		// Note: this type is marked as 'beforefieldinit'.
		static CutScenePlayCutscene()
		{
			Il2CppClassPointerStore<CutScenePlayCutscene>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-cutscenes.dll", "lotus", "CutScenePlayCutscene");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CutScenePlayCutscene>.NativeClassPtr);
			CutScenePlayCutscene.NativeFieldInfoPtr_cutSceneKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutScenePlayCutscene>.NativeClassPtr, "cutSceneKey");
			CutScenePlayCutscene.NativeMethodInfoPtr_Play_Public_Virtual_Command_CutsceneContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutScenePlayCutscene>.NativeClassPtr, 100663386);
			CutScenePlayCutscene.NativeMethodInfoPtr_play_Private_IEnumerator_CutsceneContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutScenePlayCutscene>.NativeClassPtr, 100663387);
			CutScenePlayCutscene.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutScenePlayCutscene>.NativeClassPtr, 100663388);
			CutScenePlayCutscene.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutScenePlayCutscene>.NativeClassPtr, 100663389);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00004788 File Offset: 0x00002988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258349, XrefRangeEnd = 1258359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Command Play(CutsceneContext cc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CutScenePlayCutscene.NativeMethodInfoPtr_Play_Public_Virtual_Command_CutsceneContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000047E4 File Offset: 0x000029E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258359, XrefRangeEnd = 1258365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator play(CutsceneContext cc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutScenePlayCutscene.NativeMethodInfoPtr_play_Private_IEnumerator_CutsceneContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00004834 File Offset: 0x00002A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258365, XrefRangeEnd = 1258368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CutScenePlayCutscene.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00004878 File Offset: 0x00002A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CutScenePlayCutscene()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CutScenePlayCutscene>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutScenePlayCutscene.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000231E File Offset: 0x0000051E
		public CutScenePlayCutscene(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600007D RID: 125 RVA: 0x000048B4 File Offset: 0x00002AB4
		// (set) Token: 0x0600007E RID: 126 RVA: 0x00002327 File Offset: 0x00000527
		public unsafe string cutSceneKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutScenePlayCutscene.NativeFieldInfoPtr_cutSceneKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutScenePlayCutscene.NativeFieldInfoPtr_cutSceneKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeFieldInfoPtr_cutSceneKey;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Virtual_Command_CutsceneContext_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_play_Private_IEnumerator_CutsceneContext_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000027 RID: 39
		[ObfuscatedName("lotus.CutScenePlayCutscene+<play>d__2")]
		public sealed class _play_d__2 : Object
		{
			// Token: 0x0600016A RID: 362 RVA: 0x000076D8 File Offset: 0x000058D8
			// Note: this type is marked as 'beforefieldinit'.
			static _play_d__2()
			{
				Il2CppClassPointerStore<CutScenePlayCutscene._play_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CutScenePlayCutscene>.NativeClassPtr, "<play>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CutScenePlayCutscene._play_d__2>.NativeClassPtr);
				CutScenePlayCutscene._play_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutScenePlayCutscene._play_d__2>.NativeClassPtr, "<>1__state");
				CutScenePlayCutscene._play_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutScenePlayCutscene._play_d__2>.NativeClassPtr, "<>2__current");
				CutScenePlayCutscene._play_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutScenePlayCutscene._play_d__2>.NativeClassPtr, "<>4__this");
				CutScenePlayCutscene._play_d__2.NativeFieldInfoPtr_cc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutScenePlayCutscene._play_d__2>.NativeClassPtr, "cc");
				CutScenePlayCutscene._play_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutScenePlayCutscene._play_d__2>.NativeClassPtr, 100663390);
				CutScenePlayCutscene._play_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutScenePlayCutscene._play_d__2>.NativeClassPtr, 100663391);
				CutScenePlayCutscene._play_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutScenePlayCutscene._play_d__2>.NativeClassPtr, 100663392);
				CutScenePlayCutscene._play_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutScenePlayCutscene._play_d__2>.NativeClassPtr, 100663393);
				CutScenePlayCutscene._play_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutScenePlayCutscene._play_d__2>.NativeClassPtr, 100663394);
				CutScenePlayCutscene._play_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutScenePlayCutscene._play_d__2>.NativeClassPtr, 100663395);
			}

			// Token: 0x0600016B RID: 363 RVA: 0x000077CC File Offset: 0x000059CC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _play_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CutScenePlayCutscene._play_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutScenePlayCutscene._play_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600016C RID: 364 RVA: 0x00007814 File Offset: 0x00005A14
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutScenePlayCutscene._play_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600016D RID: 365 RVA: 0x00007848 File Offset: 0x00005A48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258337, XrefRangeEnd = 1258344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutScenePlayCutscene._play_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700005C RID: 92
			// (get) Token: 0x0600016E RID: 366 RVA: 0x00007884 File Offset: 0x00005A84
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutScenePlayCutscene._play_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600016F RID: 367 RVA: 0x000078C4 File Offset: 0x00005AC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258344, XrefRangeEnd = 1258349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutScenePlayCutscene._play_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700005D RID: 93
			// (get) Token: 0x06000170 RID: 368 RVA: 0x000078F8 File Offset: 0x00005AF8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutScenePlayCutscene._play_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000171 RID: 369 RVA: 0x000029D3 File Offset: 0x00000BD3
			public _play_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000058 RID: 88
			// (get) Token: 0x06000172 RID: 370 RVA: 0x00007938 File Offset: 0x00005B38
			// (set) Token: 0x06000173 RID: 371 RVA: 0x000029DC File Offset: 0x00000BDC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutScenePlayCutscene._play_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutScenePlayCutscene._play_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000059 RID: 89
			// (get) Token: 0x06000174 RID: 372 RVA: 0x00007960 File Offset: 0x00005B60
			// (set) Token: 0x06000175 RID: 373 RVA: 0x000029F7 File Offset: 0x00000BF7
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutScenePlayCutscene._play_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutScenePlayCutscene._play_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700005A RID: 90
			// (get) Token: 0x06000176 RID: 374 RVA: 0x00007990 File Offset: 0x00005B90
			// (set) Token: 0x06000177 RID: 375 RVA: 0x00002A16 File Offset: 0x00000C16
			public unsafe CutScenePlayCutscene __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutScenePlayCutscene._play_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CutScenePlayCutscene>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutScenePlayCutscene._play_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700005B RID: 91
			// (get) Token: 0x06000178 RID: 376 RVA: 0x000079C0 File Offset: 0x00005BC0
			// (set) Token: 0x06000179 RID: 377 RVA: 0x00002A35 File Offset: 0x00000C35
			public unsafe CutsceneContext cc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutScenePlayCutscene._play_d__2.NativeFieldInfoPtr_cc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CutsceneContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutScenePlayCutscene._play_d__2.NativeFieldInfoPtr_cc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000D9 RID: 217
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040000DA RID: 218
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040000DB RID: 219
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040000DC RID: 220
			private static readonly IntPtr NativeFieldInfoPtr_cc;

			// Token: 0x040000DD RID: 221
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040000DE RID: 222
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000DF RID: 223
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040000E0 RID: 224
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040000E1 RID: 225
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000E2 RID: 226
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
