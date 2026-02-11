using System;
using dwd.core.prefabs;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.platformdependent
{
	// Token: 0x02000025 RID: 37
	public class PlatformFlavorProvider : FlavorProvider
	{
		// Token: 0x0600013C RID: 316 RVA: 0x00006BCC File Offset: 0x00004DCC
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformFlavorProvider()
		{
			Il2CppClassPointerStore<PlatformFlavorProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-platformdependent.dll", "dwd.core.platformdependent", "PlatformFlavorProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformFlavorProvider>.NativeClassPtr);
			PlatformFlavorProvider.NativeFieldInfoPtr_Platform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformFlavorProvider>.NativeClassPtr, "Platform");
			PlatformFlavorProvider.NativeMethodInfoPtr_GetFlavors_Public_Virtual_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformFlavorProvider>.NativeClassPtr, 100663429);
			PlatformFlavorProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformFlavorProvider>.NativeClassPtr, 100663430);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00006C38 File Offset: 0x00004E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239669, XrefRangeEnd = 1239675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<string> GetFlavors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformFlavorProvider.NativeMethodInfoPtr_GetFlavors_Public_Virtual_IEnumerable_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00006C84 File Offset: 0x00004E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformFlavorProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformFlavorProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformFlavorProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00002940 File Offset: 0x00000B40
		public PlatformFlavorProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000140 RID: 320 RVA: 0x00006CC0 File Offset: 0x00004EC0
		// (set) Token: 0x06000141 RID: 321 RVA: 0x00002949 File Offset: 0x00000B49
		public unsafe uint Platform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformFlavorProvider.NativeFieldInfoPtr_Platform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformFlavorProvider.NativeFieldInfoPtr_Platform)) = value;
			}
		}

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeFieldInfoPtr_Platform;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_GetFlavors_Public_Virtual_IEnumerable_1_String_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200003F RID: 63
		[ObfuscatedName("dwd.core.platformdependent.PlatformFlavorProvider+<GetFlavors>d__1")]
		public sealed class _GetFlavors_d__1 : Object
		{
			// Token: 0x06000212 RID: 530 RVA: 0x00008F48 File Offset: 0x00007148
			// Note: this type is marked as 'beforefieldinit'.
			static _GetFlavors_d__1()
			{
				Il2CppClassPointerStore<PlatformFlavorProvider._GetFlavors_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlatformFlavorProvider>.NativeClassPtr, "<GetFlavors>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformFlavorProvider._GetFlavors_d__1>.NativeClassPtr);
				PlatformFlavorProvider._GetFlavors_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformFlavorProvider._GetFlavors_d__1>.NativeClassPtr, "<>1__state");
				PlatformFlavorProvider._GetFlavors_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformFlavorProvider._GetFlavors_d__1>.NativeClassPtr, "<>2__current");
				PlatformFlavorProvider._GetFlavors_d__1.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformFlavorProvider._GetFlavors_d__1>.NativeClassPtr, "<>l__initialThreadId");
				PlatformFlavorProvider._GetFlavors_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformFlavorProvider._GetFlavors_d__1>.NativeClassPtr, "<>4__this");
				PlatformFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformFlavorProvider._GetFlavors_d__1>.NativeClassPtr, 100663431);
				PlatformFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformFlavorProvider._GetFlavors_d__1>.NativeClassPtr, 100663432);
				PlatformFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformFlavorProvider._GetFlavors_d__1>.NativeClassPtr, 100663433);
				PlatformFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformFlavorProvider._GetFlavors_d__1>.NativeClassPtr, 100663434);
				PlatformFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformFlavorProvider._GetFlavors_d__1>.NativeClassPtr, 100663435);
				PlatformFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformFlavorProvider._GetFlavors_d__1>.NativeClassPtr, 100663436);
				PlatformFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformFlavorProvider._GetFlavors_d__1>.NativeClassPtr, 100663437);
				PlatformFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformFlavorProvider._GetFlavors_d__1>.NativeClassPtr, 100663438);
			}

			// Token: 0x06000213 RID: 531 RVA: 0x00009064 File Offset: 0x00007264
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetFlavors_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformFlavorProvider._GetFlavors_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000214 RID: 532 RVA: 0x000090AC File Offset: 0x000072AC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000215 RID: 533 RVA: 0x000090E0 File Offset: 0x000072E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239651, XrefRangeEnd = 1239662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000093 RID: 147
			// (get) Token: 0x06000216 RID: 534 RVA: 0x0000911C File Offset: 0x0000731C
			public unsafe string System.Collections.Generic.IEnumerator<System.String>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000217 RID: 535 RVA: 0x00009154 File Offset: 0x00007354
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239662, XrefRangeEnd = 1239667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000094 RID: 148
			// (get) Token: 0x06000218 RID: 536 RVA: 0x00009188 File Offset: 0x00007388
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000219 RID: 537 RVA: 0x000091C8 File Offset: 0x000073C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239667, XrefRangeEnd = 1239669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<string> System_Collections_Generic_IEnumerable_System_String__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<string>>(intPtr3) : null;
			}

			// Token: 0x0600021A RID: 538 RVA: 0x00009208 File Offset: 0x00007408
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600021B RID: 539 RVA: 0x00002FF4 File Offset: 0x000011F4
			public _GetFlavors_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700008F RID: 143
			// (get) Token: 0x0600021C RID: 540 RVA: 0x00009248 File Offset: 0x00007448
			// (set) Token: 0x0600021D RID: 541 RVA: 0x00002FFD File Offset: 0x000011FD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformFlavorProvider._GetFlavors_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformFlavorProvider._GetFlavors_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000090 RID: 144
			// (get) Token: 0x0600021E RID: 542 RVA: 0x00009270 File Offset: 0x00007470
			// (set) Token: 0x0600021F RID: 543 RVA: 0x00003018 File Offset: 0x00001218
			public unsafe string __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformFlavorProvider._GetFlavors_d__1.NativeFieldInfoPtr___2__current);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformFlavorProvider._GetFlavors_d__1.NativeFieldInfoPtr___2__current), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000091 RID: 145
			// (get) Token: 0x06000220 RID: 544 RVA: 0x00009298 File Offset: 0x00007498
			// (set) Token: 0x06000221 RID: 545 RVA: 0x00003037 File Offset: 0x00001237
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformFlavorProvider._GetFlavors_d__1.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformFlavorProvider._GetFlavors_d__1.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000092 RID: 146
			// (get) Token: 0x06000222 RID: 546 RVA: 0x000092C0 File Offset: 0x000074C0
			// (set) Token: 0x06000223 RID: 547 RVA: 0x00003052 File Offset: 0x00001252
			public unsafe PlatformFlavorProvider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformFlavorProvider._GetFlavors_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformFlavorProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformFlavorProvider._GetFlavors_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000121 RID: 289
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000122 RID: 290
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000123 RID: 291
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000124 RID: 292
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000125 RID: 293
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000126 RID: 294
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000127 RID: 295
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000128 RID: 296
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0;

			// Token: 0x04000129 RID: 297
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400012A RID: 298
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400012B RID: 299
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0;

			// Token: 0x0400012C RID: 300
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
