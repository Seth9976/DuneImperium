using System;
using dwd.core.commands;
using dwd.iap.store;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.iap
{
	// Token: 0x02000009 RID: 9
	public sealed class WriteOwnedProductsCommand : Command
	{
		// Token: 0x06000020 RID: 32 RVA: 0x0000445C File Offset: 0x0000265C
		// Note: this type is marked as 'beforefieldinit'.
		static WriteOwnedProductsCommand()
		{
			Il2CppClassPointerStore<WriteOwnedProductsCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("InAppPurchasing.dll", "dwd.core.iap", "WriteOwnedProductsCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WriteOwnedProductsCommand>.NativeClassPtr);
			WriteOwnedProductsCommand.NativeFieldInfoPtr_products = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteOwnedProductsCommand>.NativeClassPtr, "products");
			WriteOwnedProductsCommand.NativeFieldInfoPtr_lastVerified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteOwnedProductsCommand>.NativeClassPtr, "lastVerified");
			WriteOwnedProductsCommand.NativeMethodInfoPtr__ctor_Public_Void_HashSet_1_IAPProduct_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteOwnedProductsCommand>.NativeClassPtr, 100663323);
			WriteOwnedProductsCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteOwnedProductsCommand>.NativeClassPtr, 100663324);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000044DC File Offset: 0x000026DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199681, XrefRangeEnd = 1199683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WriteOwnedProductsCommand(HashSet<IAPProduct> products, long lastVerified = 0L)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WriteOwnedProductsCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(products);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lastVerified;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteOwnedProductsCommand.NativeMethodInfoPtr__ctor_Public_Void_HashSet_1_IAPProduct_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00004538 File Offset: 0x00002738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199683, XrefRangeEnd = 1199688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteOwnedProductsCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000215A File Offset: 0x0000035A
		public WriteOwnedProductsCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00004578 File Offset: 0x00002778
		// (set) Token: 0x06000025 RID: 37 RVA: 0x00002163 File Offset: 0x00000363
		public unsafe HashSet<IAPProduct> products
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteOwnedProductsCommand.NativeFieldInfoPtr_products);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<IAPProduct>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteOwnedProductsCommand.NativeFieldInfoPtr_products), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000026 RID: 38 RVA: 0x000045A8 File Offset: 0x000027A8
		// (set) Token: 0x06000027 RID: 39 RVA: 0x00002182 File Offset: 0x00000382
		public unsafe long lastVerified
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteOwnedProductsCommand.NativeFieldInfoPtr_lastVerified);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteOwnedProductsCommand.NativeFieldInfoPtr_lastVerified)) = value;
			}
		}

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeFieldInfoPtr_products;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeFieldInfoPtr_lastVerified;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_HashSet_1_IAPProduct_Int64_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x0200002D RID: 45
		[ObfuscatedName("dwd.core.iap.WriteOwnedProductsCommand+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000283 RID: 643 RVA: 0x0000CA00 File Offset: 0x0000AC00
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WriteOwnedProductsCommand.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WriteOwnedProductsCommand>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WriteOwnedProductsCommand.__c>.NativeClassPtr);
				WriteOwnedProductsCommand.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteOwnedProductsCommand.__c>.NativeClassPtr, "<>9");
				WriteOwnedProductsCommand.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteOwnedProductsCommand.__c>.NativeClassPtr, "<>9__3_0");
				WriteOwnedProductsCommand.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteOwnedProductsCommand.__c>.NativeClassPtr, 100663326);
				WriteOwnedProductsCommand.__c.NativeMethodInfoPtr__execute_b__3_0_Internal_String_IAPProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteOwnedProductsCommand.__c>.NativeClassPtr, 100663327);
			}

			// Token: 0x06000284 RID: 644 RVA: 0x0000CA7C File Offset: 0x0000AC7C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WriteOwnedProductsCommand.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteOwnedProductsCommand.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000285 RID: 645 RVA: 0x0000CAB8 File Offset: 0x0000ACB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _execute_b__3_0(IAPProduct p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteOwnedProductsCommand.__c.NativeMethodInfoPtr__execute_b__3_0_Internal_String_IAPProduct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000286 RID: 646 RVA: 0x00003141 File Offset: 0x00001341
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000D4 RID: 212
			// (get) Token: 0x06000287 RID: 647 RVA: 0x0000CB00 File Offset: 0x0000AD00
			// (set) Token: 0x06000288 RID: 648 RVA: 0x0000314A File Offset: 0x0000134A
			public unsafe static WriteOwnedProductsCommand.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WriteOwnedProductsCommand.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WriteOwnedProductsCommand.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WriteOwnedProductsCommand.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000D5 RID: 213
			// (get) Token: 0x06000289 RID: 649 RVA: 0x0000CB28 File Offset: 0x0000AD28
			// (set) Token: 0x0600028A RID: 650 RVA: 0x0000315C File Offset: 0x0000135C
			public unsafe static Func<IAPProduct, string> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WriteOwnedProductsCommand.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IAPProduct, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WriteOwnedProductsCommand.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001BE RID: 446
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040001BF RID: 447
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x040001C0 RID: 448
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040001C1 RID: 449
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__3_0_Internal_String_IAPProduct_0;
		}

		// Token: 0x0200002E RID: 46
		[ObfuscatedName("dwd.core.iap.WriteOwnedProductsCommand+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x0600028B RID: 651 RVA: 0x0000CB50 File Offset: 0x0000AD50
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<WriteOwnedProductsCommand._execute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WriteOwnedProductsCommand>.NativeClassPtr, "<execute>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WriteOwnedProductsCommand._execute_d__3>.NativeClassPtr);
				WriteOwnedProductsCommand._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteOwnedProductsCommand._execute_d__3>.NativeClassPtr, "<>1__state");
				WriteOwnedProductsCommand._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteOwnedProductsCommand._execute_d__3>.NativeClassPtr, "<>2__current");
				WriteOwnedProductsCommand._execute_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteOwnedProductsCommand._execute_d__3>.NativeClassPtr, "<>4__this");
				WriteOwnedProductsCommand._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteOwnedProductsCommand._execute_d__3>.NativeClassPtr, 100663328);
				WriteOwnedProductsCommand._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteOwnedProductsCommand._execute_d__3>.NativeClassPtr, 100663329);
				WriteOwnedProductsCommand._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteOwnedProductsCommand._execute_d__3>.NativeClassPtr, 100663330);
				WriteOwnedProductsCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteOwnedProductsCommand._execute_d__3>.NativeClassPtr, 100663331);
				WriteOwnedProductsCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteOwnedProductsCommand._execute_d__3>.NativeClassPtr, 100663332);
				WriteOwnedProductsCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteOwnedProductsCommand._execute_d__3>.NativeClassPtr, 100663333);
			}

			// Token: 0x0600028C RID: 652 RVA: 0x0000CC30 File Offset: 0x0000AE30
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WriteOwnedProductsCommand._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteOwnedProductsCommand._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600028D RID: 653 RVA: 0x0000CC78 File Offset: 0x0000AE78
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteOwnedProductsCommand._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600028E RID: 654 RVA: 0x0000CCAC File Offset: 0x0000AEAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199628, XrefRangeEnd = 1199676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteOwnedProductsCommand._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170000D9 RID: 217
			// (get) Token: 0x0600028F RID: 655 RVA: 0x0000CCE8 File Offset: 0x0000AEE8
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteOwnedProductsCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000290 RID: 656 RVA: 0x0000CD28 File Offset: 0x0000AF28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199676, XrefRangeEnd = 1199681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteOwnedProductsCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000DA RID: 218
			// (get) Token: 0x06000291 RID: 657 RVA: 0x0000CD5C File Offset: 0x0000AF5C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteOwnedProductsCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000292 RID: 658 RVA: 0x0000316E File Offset: 0x0000136E
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000D6 RID: 214
			// (get) Token: 0x06000293 RID: 659 RVA: 0x0000CD9C File Offset: 0x0000AF9C
			// (set) Token: 0x06000294 RID: 660 RVA: 0x00003177 File Offset: 0x00001377
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteOwnedProductsCommand._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteOwnedProductsCommand._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000D7 RID: 215
			// (get) Token: 0x06000295 RID: 661 RVA: 0x0000CDC4 File Offset: 0x0000AFC4
			// (set) Token: 0x06000296 RID: 662 RVA: 0x00003192 File Offset: 0x00001392
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteOwnedProductsCommand._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteOwnedProductsCommand._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000D8 RID: 216
			// (get) Token: 0x06000297 RID: 663 RVA: 0x0000CDF4 File Offset: 0x0000AFF4
			// (set) Token: 0x06000298 RID: 664 RVA: 0x000031B1 File Offset: 0x000013B1
			public unsafe WriteOwnedProductsCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteOwnedProductsCommand._execute_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WriteOwnedProductsCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteOwnedProductsCommand._execute_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001C2 RID: 450
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040001C3 RID: 451
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040001C4 RID: 452
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040001C5 RID: 453
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040001C6 RID: 454
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001C7 RID: 455
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040001C8 RID: 456
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040001C9 RID: 457
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001CA RID: 458
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
