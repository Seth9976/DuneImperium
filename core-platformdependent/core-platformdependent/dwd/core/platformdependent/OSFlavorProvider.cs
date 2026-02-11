using System;
using dwd.core.prefabs;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace dwd.core.platformdependent
{
	// Token: 0x0200000A RID: 10
	public class OSFlavorProvider : FlavorProvider
	{
		// Token: 0x06000038 RID: 56 RVA: 0x00003B14 File Offset: 0x00001D14
		// Note: this type is marked as 'beforefieldinit'.
		static OSFlavorProvider()
		{
			Il2CppClassPointerStore<OSFlavorProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-platformdependent.dll", "dwd.core.platformdependent", "OSFlavorProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OSFlavorProvider>.NativeClassPtr);
			OSFlavorProvider.NativeFieldInfoPtr_OS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OSFlavorProvider>.NativeClassPtr, "OS");
			OSFlavorProvider.NativeMethodInfoPtr_GetFlavors_Public_Virtual_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSFlavorProvider>.NativeClassPtr, 100663317);
			OSFlavorProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSFlavorProvider>.NativeClassPtr, 100663318);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00003B80 File Offset: 0x00001D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238773, XrefRangeEnd = 1238779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<string> GetFlavors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OSFlavorProvider.NativeMethodInfoPtr_GetFlavors_Public_Virtual_IEnumerable_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00003BCC File Offset: 0x00001DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OSFlavorProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OSFlavorProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSFlavorProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000021EA File Offset: 0x000003EA
		public OSFlavorProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00003C08 File Offset: 0x00001E08
		// (set) Token: 0x0600003D RID: 61 RVA: 0x000021F3 File Offset: 0x000003F3
		public unsafe RuntimePlatform OS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OSFlavorProvider.NativeFieldInfoPtr_OS);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OSFlavorProvider.NativeFieldInfoPtr_OS)) = value;
			}
		}

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeFieldInfoPtr_OS;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_GetFlavors_Public_Virtual_IEnumerable_1_String_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000030 RID: 48
		[ObfuscatedName("dwd.core.platformdependent.OSFlavorProvider+<GetFlavors>d__1")]
		public sealed class _GetFlavors_d__1 : global::Il2CppSystem.Object
		{
			// Token: 0x060001A4 RID: 420 RVA: 0x00007CBC File Offset: 0x00005EBC
			// Note: this type is marked as 'beforefieldinit'.
			static _GetFlavors_d__1()
			{
				Il2CppClassPointerStore<OSFlavorProvider._GetFlavors_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OSFlavorProvider>.NativeClassPtr, "<GetFlavors>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OSFlavorProvider._GetFlavors_d__1>.NativeClassPtr);
				OSFlavorProvider._GetFlavors_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OSFlavorProvider._GetFlavors_d__1>.NativeClassPtr, "<>1__state");
				OSFlavorProvider._GetFlavors_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OSFlavorProvider._GetFlavors_d__1>.NativeClassPtr, "<>2__current");
				OSFlavorProvider._GetFlavors_d__1.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OSFlavorProvider._GetFlavors_d__1>.NativeClassPtr, "<>l__initialThreadId");
				OSFlavorProvider._GetFlavors_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OSFlavorProvider._GetFlavors_d__1>.NativeClassPtr, "<>4__this");
				OSFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSFlavorProvider._GetFlavors_d__1>.NativeClassPtr, 100663319);
				OSFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSFlavorProvider._GetFlavors_d__1>.NativeClassPtr, 100663320);
				OSFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSFlavorProvider._GetFlavors_d__1>.NativeClassPtr, 100663321);
				OSFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSFlavorProvider._GetFlavors_d__1>.NativeClassPtr, 100663322);
				OSFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSFlavorProvider._GetFlavors_d__1>.NativeClassPtr, 100663323);
				OSFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSFlavorProvider._GetFlavors_d__1>.NativeClassPtr, 100663324);
				OSFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSFlavorProvider._GetFlavors_d__1>.NativeClassPtr, 100663325);
				OSFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSFlavorProvider._GetFlavors_d__1>.NativeClassPtr, 100663326);
			}

			// Token: 0x060001A5 RID: 421 RVA: 0x00007DD8 File Offset: 0x00005FD8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetFlavors_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OSFlavorProvider._GetFlavors_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060001A6 RID: 422 RVA: 0x00007E20 File Offset: 0x00006020
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001A7 RID: 423 RVA: 0x00007E54 File Offset: 0x00006054
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238762, XrefRangeEnd = 1238766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000074 RID: 116
			// (get) Token: 0x060001A8 RID: 424 RVA: 0x00007E90 File Offset: 0x00006090
			public unsafe string System.Collections.Generic.IEnumerator<System.String>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060001A9 RID: 425 RVA: 0x00007EC8 File Offset: 0x000060C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238766, XrefRangeEnd = 1238771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000075 RID: 117
			// (get) Token: 0x060001AA RID: 426 RVA: 0x00007EFC File Offset: 0x000060FC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060001AB RID: 427 RVA: 0x00007F3C File Offset: 0x0000613C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238771, XrefRangeEnd = 1238773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<string> System_Collections_Generic_IEnumerable_System_String__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<string>>(intPtr3) : null;
			}

			// Token: 0x060001AC RID: 428 RVA: 0x00007F7C File Offset: 0x0000617C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSFlavorProvider._GetFlavors_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060001AD RID: 429 RVA: 0x00002C45 File Offset: 0x00000E45
			public _GetFlavors_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000070 RID: 112
			// (get) Token: 0x060001AE RID: 430 RVA: 0x00007FBC File Offset: 0x000061BC
			// (set) Token: 0x060001AF RID: 431 RVA: 0x00002C4E File Offset: 0x00000E4E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OSFlavorProvider._GetFlavors_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OSFlavorProvider._GetFlavors_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000071 RID: 113
			// (get) Token: 0x060001B0 RID: 432 RVA: 0x00007FE4 File Offset: 0x000061E4
			// (set) Token: 0x060001B1 RID: 433 RVA: 0x00002C69 File Offset: 0x00000E69
			public unsafe string __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OSFlavorProvider._GetFlavors_d__1.NativeFieldInfoPtr___2__current);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OSFlavorProvider._GetFlavors_d__1.NativeFieldInfoPtr___2__current), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000072 RID: 114
			// (get) Token: 0x060001B2 RID: 434 RVA: 0x0000800C File Offset: 0x0000620C
			// (set) Token: 0x060001B3 RID: 435 RVA: 0x00002C88 File Offset: 0x00000E88
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OSFlavorProvider._GetFlavors_d__1.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OSFlavorProvider._GetFlavors_d__1.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000073 RID: 115
			// (get) Token: 0x060001B4 RID: 436 RVA: 0x00008034 File Offset: 0x00006234
			// (set) Token: 0x060001B5 RID: 437 RVA: 0x00002CA3 File Offset: 0x00000EA3
			public unsafe OSFlavorProvider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OSFlavorProvider._GetFlavors_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OSFlavorProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OSFlavorProvider._GetFlavors_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000EB RID: 235
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040000EC RID: 236
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040000ED RID: 237
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040000EE RID: 238
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040000EF RID: 239
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040000F0 RID: 240
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000F1 RID: 241
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040000F2 RID: 242
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0;

			// Token: 0x040000F3 RID: 243
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000F4 RID: 244
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040000F5 RID: 245
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0;

			// Token: 0x040000F6 RID: 246
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
