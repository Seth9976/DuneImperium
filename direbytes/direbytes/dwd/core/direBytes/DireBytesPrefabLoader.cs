using System;
using boardgames.src.broadcast.motd;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace dwd.core.direBytes
{
	// Token: 0x0200000C RID: 12
	public class DireBytesPrefabLoader : Subscriber<DireBytesPrefabData>
	{
		// Token: 0x06000054 RID: 84 RVA: 0x00004594 File Offset: 0x00002794
		// Note: this type is marked as 'beforefieldinit'.
		static DireBytesPrefabLoader()
		{
			Il2CppClassPointerStore<DireBytesPrefabLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("direbytes.dll", "dwd.core.direBytes", "DireBytesPrefabLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DireBytesPrefabLoader>.NativeClassPtr);
			DireBytesPrefabLoader.NativeFieldInfoPtr_resourcePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesPrefabLoader>.NativeClassPtr, "resourcePath");
			DireBytesPrefabLoader.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesPrefabLoader>.NativeClassPtr, 100663332);
			DireBytesPrefabLoader.NativeMethodInfoPtr_waitForBroadcastProvider_Private_IEnumerator_BroadcastContentProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesPrefabLoader>.NativeClassPtr, 100663333);
			DireBytesPrefabLoader.NativeMethodInfoPtr_loadPrefab_Private_Void_BroadcastContentProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesPrefabLoader>.NativeClassPtr, 100663334);
			DireBytesPrefabLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesPrefabLoader>.NativeClassPtr, 100663335);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00004628 File Offset: 0x00002828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233718, XrefRangeEnd = 1233733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DireBytesPrefabLoader.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00004664 File Offset: 0x00002864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233733, XrefRangeEnd = 1233739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator waitForBroadcastProvider(BroadcastContentProvider broadcast)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(broadcast);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesPrefabLoader.NativeMethodInfoPtr_waitForBroadcastProvider_Private_IEnumerator_BroadcastContentProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000046B4 File Offset: 0x000028B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1233770, RefRangeEnd = 1233771, XrefRangeStart = 1233739, XrefRangeEnd = 1233770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void loadPrefab(BroadcastContentProvider broadcast)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(broadcast);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesPrefabLoader.NativeMethodInfoPtr_loadPrefab_Private_Void_BroadcastContentProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000046F8 File Offset: 0x000028F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233771, XrefRangeEnd = 1233778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DireBytesPrefabLoader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DireBytesPrefabLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesPrefabLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002305 File Offset: 0x00000505
		public DireBytesPrefabLoader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00004734 File Offset: 0x00002934
		// (set) Token: 0x0600005B RID: 91 RVA: 0x0000230E File Offset: 0x0000050E
		public unsafe string resourcePath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesPrefabLoader.NativeFieldInfoPtr_resourcePath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesPrefabLoader.NativeFieldInfoPtr_resourcePath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeFieldInfoPtr_resourcePath;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_waitForBroadcastProvider_Private_IEnumerator_BroadcastContentProvider_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_loadPrefab_Private_Void_BroadcastContentProvider_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200002D RID: 45
		[ObfuscatedName("dwd.core.direBytes.DireBytesPrefabLoader+<waitForBroadcastProvider>d__2")]
		public sealed class _waitForBroadcastProvider_d__2 : Object
		{
			// Token: 0x06000209 RID: 521 RVA: 0x000090E8 File Offset: 0x000072E8
			// Note: this type is marked as 'beforefieldinit'.
			static _waitForBroadcastProvider_d__2()
			{
				Il2CppClassPointerStore<DireBytesPrefabLoader._waitForBroadcastProvider_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DireBytesPrefabLoader>.NativeClassPtr, "<waitForBroadcastProvider>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DireBytesPrefabLoader._waitForBroadcastProvider_d__2>.NativeClassPtr);
				DireBytesPrefabLoader._waitForBroadcastProvider_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesPrefabLoader._waitForBroadcastProvider_d__2>.NativeClassPtr, "<>1__state");
				DireBytesPrefabLoader._waitForBroadcastProvider_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesPrefabLoader._waitForBroadcastProvider_d__2>.NativeClassPtr, "<>2__current");
				DireBytesPrefabLoader._waitForBroadcastProvider_d__2.NativeFieldInfoPtr_broadcast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesPrefabLoader._waitForBroadcastProvider_d__2>.NativeClassPtr, "broadcast");
				DireBytesPrefabLoader._waitForBroadcastProvider_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesPrefabLoader._waitForBroadcastProvider_d__2>.NativeClassPtr, "<>4__this");
				DireBytesPrefabLoader._waitForBroadcastProvider_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesPrefabLoader._waitForBroadcastProvider_d__2>.NativeClassPtr, 100663336);
				DireBytesPrefabLoader._waitForBroadcastProvider_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesPrefabLoader._waitForBroadcastProvider_d__2>.NativeClassPtr, 100663337);
				DireBytesPrefabLoader._waitForBroadcastProvider_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesPrefabLoader._waitForBroadcastProvider_d__2>.NativeClassPtr, 100663338);
				DireBytesPrefabLoader._waitForBroadcastProvider_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesPrefabLoader._waitForBroadcastProvider_d__2>.NativeClassPtr, 100663339);
				DireBytesPrefabLoader._waitForBroadcastProvider_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesPrefabLoader._waitForBroadcastProvider_d__2>.NativeClassPtr, 100663340);
				DireBytesPrefabLoader._waitForBroadcastProvider_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesPrefabLoader._waitForBroadcastProvider_d__2>.NativeClassPtr, 100663341);
			}

			// Token: 0x0600020A RID: 522 RVA: 0x000091DC File Offset: 0x000073DC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _waitForBroadcastProvider_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DireBytesPrefabLoader._waitForBroadcastProvider_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesPrefabLoader._waitForBroadcastProvider_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600020B RID: 523 RVA: 0x00009224 File Offset: 0x00007424
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesPrefabLoader._waitForBroadcastProvider_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600020C RID: 524 RVA: 0x00009258 File Offset: 0x00007458
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233712, XrefRangeEnd = 1233713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesPrefabLoader._waitForBroadcastProvider_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170000AC RID: 172
			// (get) Token: 0x0600020D RID: 525 RVA: 0x00009294 File Offset: 0x00007494
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesPrefabLoader._waitForBroadcastProvider_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600020E RID: 526 RVA: 0x000092D4 File Offset: 0x000074D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233713, XrefRangeEnd = 1233718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesPrefabLoader._waitForBroadcastProvider_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000AD RID: 173
			// (get) Token: 0x0600020F RID: 527 RVA: 0x00009308 File Offset: 0x00007508
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesPrefabLoader._waitForBroadcastProvider_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000210 RID: 528 RVA: 0x000032BB File Offset: 0x000014BB
			public _waitForBroadcastProvider_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000A8 RID: 168
			// (get) Token: 0x06000211 RID: 529 RVA: 0x00009348 File Offset: 0x00007548
			// (set) Token: 0x06000212 RID: 530 RVA: 0x000032C4 File Offset: 0x000014C4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesPrefabLoader._waitForBroadcastProvider_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesPrefabLoader._waitForBroadcastProvider_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000A9 RID: 169
			// (get) Token: 0x06000213 RID: 531 RVA: 0x00009370 File Offset: 0x00007570
			// (set) Token: 0x06000214 RID: 532 RVA: 0x000032DF File Offset: 0x000014DF
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesPrefabLoader._waitForBroadcastProvider_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesPrefabLoader._waitForBroadcastProvider_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000AA RID: 170
			// (get) Token: 0x06000215 RID: 533 RVA: 0x000093A0 File Offset: 0x000075A0
			// (set) Token: 0x06000216 RID: 534 RVA: 0x000032FE File Offset: 0x000014FE
			public unsafe BroadcastContentProvider broadcast
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesPrefabLoader._waitForBroadcastProvider_d__2.NativeFieldInfoPtr_broadcast);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BroadcastContentProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesPrefabLoader._waitForBroadcastProvider_d__2.NativeFieldInfoPtr_broadcast), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000AB RID: 171
			// (get) Token: 0x06000217 RID: 535 RVA: 0x000093D0 File Offset: 0x000075D0
			// (set) Token: 0x06000218 RID: 536 RVA: 0x0000331D File Offset: 0x0000151D
			public unsafe DireBytesPrefabLoader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesPrefabLoader._waitForBroadcastProvider_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DireBytesPrefabLoader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesPrefabLoader._waitForBroadcastProvider_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400011F RID: 287
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000120 RID: 288
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000121 RID: 289
			private static readonly IntPtr NativeFieldInfoPtr_broadcast;

			// Token: 0x04000122 RID: 290
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000123 RID: 291
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000124 RID: 292
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000125 RID: 293
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000126 RID: 294
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000127 RID: 295
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000128 RID: 296
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
