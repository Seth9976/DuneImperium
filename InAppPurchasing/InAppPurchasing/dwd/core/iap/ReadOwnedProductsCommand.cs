using System;
using dwd.core.commands;
using dwd.iap.store;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace dwd.core.iap
{
	// Token: 0x02000008 RID: 8
	public sealed class ReadOwnedProductsCommand : Command
	{
		// Token: 0x0600001A RID: 26 RVA: 0x00004334 File Offset: 0x00002534
		// Note: this type is marked as 'beforefieldinit'.
		static ReadOwnedProductsCommand()
		{
			Il2CppClassPointerStore<ReadOwnedProductsCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("InAppPurchasing.dll", "dwd.core.iap", "ReadOwnedProductsCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadOwnedProductsCommand>.NativeClassPtr);
			ReadOwnedProductsCommand.NativeFieldInfoPtr_onStorageReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOwnedProductsCommand>.NativeClassPtr, "onStorageReceived");
			ReadOwnedProductsCommand.NativeMethodInfoPtr__ctor_Public_Void_Action_1_OfflineProductStorage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOwnedProductsCommand>.NativeClassPtr, 100663312);
			ReadOwnedProductsCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOwnedProductsCommand>.NativeClassPtr, 100663313);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000043A0 File Offset: 0x000025A0
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 495009, RefRangeEnd = 495046, XrefRangeStart = 495009, XrefRangeEnd = 495046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOwnedProductsCommand(Action<OfflineProductStorage> onStorageReceived)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOwnedProductsCommand>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(onStorageReceived);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOwnedProductsCommand.NativeMethodInfoPtr__ctor_Public_Void_Action_1_OfflineProductStorage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000043EC File Offset: 0x000025EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199623, XrefRangeEnd = 1199628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOwnedProductsCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002132 File Offset: 0x00000332
		public ReadOwnedProductsCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001E RID: 30 RVA: 0x0000442C File Offset: 0x0000262C
		// (set) Token: 0x0600001F RID: 31 RVA: 0x0000213B File Offset: 0x0000033B
		public unsafe Action<OfflineProductStorage> onStorageReceived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOwnedProductsCommand.NativeFieldInfoPtr_onStorageReceived);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<OfflineProductStorage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOwnedProductsCommand.NativeFieldInfoPtr_onStorageReceived), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeFieldInfoPtr_onStorageReceived;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Action_1_OfflineProductStorage_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x0200002B RID: 43
		[ObfuscatedName("dwd.core.iap.ReadOwnedProductsCommand+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600026D RID: 621 RVA: 0x0000C5DC File Offset: 0x0000A7DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ReadOwnedProductsCommand.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReadOwnedProductsCommand>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadOwnedProductsCommand.__c>.NativeClassPtr);
				ReadOwnedProductsCommand.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOwnedProductsCommand.__c>.NativeClassPtr, "<>9");
				ReadOwnedProductsCommand.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOwnedProductsCommand.__c>.NativeClassPtr, "<>9__2_0");
				ReadOwnedProductsCommand.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOwnedProductsCommand.__c>.NativeClassPtr, 100663315);
				ReadOwnedProductsCommand.__c.NativeMethodInfoPtr__execute_b__2_0_Internal_String_IAPProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOwnedProductsCommand.__c>.NativeClassPtr, 100663316);
			}

			// Token: 0x0600026E RID: 622 RVA: 0x0000C658 File Offset: 0x0000A858
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOwnedProductsCommand.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOwnedProductsCommand.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600026F RID: 623 RVA: 0x0000C694 File Offset: 0x0000A894
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199602, XrefRangeEnd = 1199606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _execute_b__2_0(IAPProduct p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOwnedProductsCommand.__c.NativeMethodInfoPtr__execute_b__2_0_Internal_String_IAPProduct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000270 RID: 624 RVA: 0x000030B2 File Offset: 0x000012B2
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000CD RID: 205
			// (get) Token: 0x06000271 RID: 625 RVA: 0x0000C6DC File Offset: 0x0000A8DC
			// (set) Token: 0x06000272 RID: 626 RVA: 0x000030BB File Offset: 0x000012BB
			public unsafe static ReadOwnedProductsCommand.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReadOwnedProductsCommand.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOwnedProductsCommand.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReadOwnedProductsCommand.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000CE RID: 206
			// (get) Token: 0x06000273 RID: 627 RVA: 0x0000C704 File Offset: 0x0000A904
			// (set) Token: 0x06000274 RID: 628 RVA: 0x000030CD File Offset: 0x000012CD
			public unsafe static Func<IAPProduct, string> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReadOwnedProductsCommand.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IAPProduct, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReadOwnedProductsCommand.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001B1 RID: 433
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040001B2 RID: 434
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x040001B3 RID: 435
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040001B4 RID: 436
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__2_0_Internal_String_IAPProduct_0;
		}

		// Token: 0x0200002C RID: 44
		[ObfuscatedName("dwd.core.iap.ReadOwnedProductsCommand+<execute>d__2")]
		public sealed class _execute_d__2 : Object
		{
			// Token: 0x06000275 RID: 629 RVA: 0x0000C72C File Offset: 0x0000A92C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__2()
			{
				Il2CppClassPointerStore<ReadOwnedProductsCommand._execute_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReadOwnedProductsCommand>.NativeClassPtr, "<execute>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadOwnedProductsCommand._execute_d__2>.NativeClassPtr);
				ReadOwnedProductsCommand._execute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOwnedProductsCommand._execute_d__2>.NativeClassPtr, "<>1__state");
				ReadOwnedProductsCommand._execute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOwnedProductsCommand._execute_d__2>.NativeClassPtr, "<>2__current");
				ReadOwnedProductsCommand._execute_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOwnedProductsCommand._execute_d__2>.NativeClassPtr, "<>4__this");
				ReadOwnedProductsCommand._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOwnedProductsCommand._execute_d__2>.NativeClassPtr, 100663317);
				ReadOwnedProductsCommand._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOwnedProductsCommand._execute_d__2>.NativeClassPtr, 100663318);
				ReadOwnedProductsCommand._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOwnedProductsCommand._execute_d__2>.NativeClassPtr, 100663319);
				ReadOwnedProductsCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOwnedProductsCommand._execute_d__2>.NativeClassPtr, 100663320);
				ReadOwnedProductsCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOwnedProductsCommand._execute_d__2>.NativeClassPtr, 100663321);
				ReadOwnedProductsCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOwnedProductsCommand._execute_d__2>.NativeClassPtr, 100663322);
			}

			// Token: 0x06000276 RID: 630 RVA: 0x0000C80C File Offset: 0x0000AA0C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOwnedProductsCommand._execute_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOwnedProductsCommand._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000277 RID: 631 RVA: 0x0000C854 File Offset: 0x0000AA54
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOwnedProductsCommand._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000278 RID: 632 RVA: 0x0000C888 File Offset: 0x0000AA88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199606, XrefRangeEnd = 1199618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOwnedProductsCommand._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170000D2 RID: 210
			// (get) Token: 0x06000279 RID: 633 RVA: 0x0000C8C4 File Offset: 0x0000AAC4
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOwnedProductsCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600027A RID: 634 RVA: 0x0000C904 File Offset: 0x0000AB04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199618, XrefRangeEnd = 1199623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOwnedProductsCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000D3 RID: 211
			// (get) Token: 0x0600027B RID: 635 RVA: 0x0000C938 File Offset: 0x0000AB38
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOwnedProductsCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600027C RID: 636 RVA: 0x000030DF File Offset: 0x000012DF
			public _execute_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000CF RID: 207
			// (get) Token: 0x0600027D RID: 637 RVA: 0x0000C978 File Offset: 0x0000AB78
			// (set) Token: 0x0600027E RID: 638 RVA: 0x000030E8 File Offset: 0x000012E8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOwnedProductsCommand._execute_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOwnedProductsCommand._execute_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000D0 RID: 208
			// (get) Token: 0x0600027F RID: 639 RVA: 0x0000C9A0 File Offset: 0x0000ABA0
			// (set) Token: 0x06000280 RID: 640 RVA: 0x00003103 File Offset: 0x00001303
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOwnedProductsCommand._execute_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOwnedProductsCommand._execute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000D1 RID: 209
			// (get) Token: 0x06000281 RID: 641 RVA: 0x0000C9D0 File Offset: 0x0000ABD0
			// (set) Token: 0x06000282 RID: 642 RVA: 0x00003122 File Offset: 0x00001322
			public unsafe ReadOwnedProductsCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOwnedProductsCommand._execute_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOwnedProductsCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOwnedProductsCommand._execute_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001B5 RID: 437
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040001B6 RID: 438
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040001B7 RID: 439
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040001B8 RID: 440
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040001B9 RID: 441
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001BA RID: 442
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040001BB RID: 443
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040001BC RID: 444
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001BD RID: 445
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
