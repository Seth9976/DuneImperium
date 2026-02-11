using System;
using dwd.core;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace dwd.iap.store
{
	// Token: 0x02000023 RID: 35
	public class PurchaseIAPProductCommand : Command
	{
		// Token: 0x060001FB RID: 507 RVA: 0x0000B078 File Offset: 0x00009278
		// Note: this type is marked as 'beforefieldinit'.
		static PurchaseIAPProductCommand()
		{
			Il2CppClassPointerStore<PurchaseIAPProductCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("InAppPurchasing.dll", "dwd.iap.store", "PurchaseIAPProductCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PurchaseIAPProductCommand>.NativeClassPtr);
			PurchaseIAPProductCommand.NativeFieldInfoPtr_store = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchaseIAPProductCommand>.NativeClassPtr, "store");
			PurchaseIAPProductCommand.NativeFieldInfoPtr_ProductID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchaseIAPProductCommand>.NativeClassPtr, "ProductID");
			PurchaseIAPProductCommand.NativeFieldInfoPtr__Product_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchaseIAPProductCommand>.NativeClassPtr, "<Product>k__BackingField");
			PurchaseIAPProductCommand.NativeFieldInfoPtr_purchaseMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchaseIAPProductCommand>.NativeClassPtr, "purchaseMethod");
			PurchaseIAPProductCommand.NativeMethodInfoPtr_get_Product_Public_get_IAPProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchaseIAPProductCommand>.NativeClassPtr, 100663725);
			PurchaseIAPProductCommand.NativeMethodInfoPtr_set_Product_Private_set_Void_IAPProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchaseIAPProductCommand>.NativeClassPtr, 100663726);
			PurchaseIAPProductCommand.NativeMethodInfoPtr__ctor_Public_Void_IAPStoreModel_String_Func_2_IAPProduct_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchaseIAPProductCommand>.NativeClassPtr, 100663727);
			PurchaseIAPProductCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchaseIAPProductCommand>.NativeClassPtr, 100663728);
			PurchaseIAPProductCommand.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchaseIAPProductCommand>.NativeClassPtr, 100663729);
			PurchaseIAPProductCommand.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchaseIAPProductCommand>.NativeClassPtr, 100663730);
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060001FC RID: 508 RVA: 0x0000B170 File Offset: 0x00009370
		// (set) Token: 0x060001FD RID: 509 RVA: 0x0000B1B0 File Offset: 0x000093B0
		public unsafe IAPProduct Product
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchaseIAPProductCommand.NativeMethodInfoPtr_get_Product_Public_get_IAPProduct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAPProduct>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchaseIAPProductCommand.NativeMethodInfoPtr_set_Product_Private_set_Void_IAPProduct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0000B1F4 File Offset: 0x000093F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202377, XrefRangeEnd = 1202381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PurchaseIAPProductCommand(IAPStoreModel store, string productID, Func<IAPProduct, IEnumerator> purchaseMethod)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PurchaseIAPProductCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(store);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(productID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(purchaseMethod);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchaseIAPProductCommand.NativeMethodInfoPtr__ctor_Public_Void_IAPStoreModel_String_Func_2_IAPProduct_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0000B264 File Offset: 0x00009464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202381, XrefRangeEnd = 1202386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PurchaseIAPProductCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0000B2B0 File Offset: 0x000094B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202386, XrefRangeEnd = 1202390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ErrorInfo Status()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchaseIAPProductCommand.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ErrorInfo(intPtr);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0000B2E8 File Offset: 0x000094E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202390, XrefRangeEnd = 1202425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PurchaseIAPProductCommand.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00002CD5 File Offset: 0x00000ED5
		public PurchaseIAPProductCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000203 RID: 515 RVA: 0x0000B32C File Offset: 0x0000952C
		// (set) Token: 0x06000204 RID: 516 RVA: 0x00002CDE File Offset: 0x00000EDE
		public unsafe IAPStoreModel store
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseIAPProductCommand.NativeFieldInfoPtr_store);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAPStoreModel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseIAPProductCommand.NativeFieldInfoPtr_store), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000205 RID: 517 RVA: 0x0000B35C File Offset: 0x0000955C
		// (set) Token: 0x06000206 RID: 518 RVA: 0x00002CFD File Offset: 0x00000EFD
		public unsafe string ProductID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseIAPProductCommand.NativeFieldInfoPtr_ProductID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseIAPProductCommand.NativeFieldInfoPtr_ProductID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000207 RID: 519 RVA: 0x0000B384 File Offset: 0x00009584
		// (set) Token: 0x06000208 RID: 520 RVA: 0x00002D1C File Offset: 0x00000F1C
		public unsafe IAPProduct _Product_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseIAPProductCommand.NativeFieldInfoPtr__Product_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAPProduct>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseIAPProductCommand.NativeFieldInfoPtr__Product_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000209 RID: 521 RVA: 0x0000B3B4 File Offset: 0x000095B4
		// (set) Token: 0x0600020A RID: 522 RVA: 0x00002D3B File Offset: 0x00000F3B
		public unsafe Func<IAPProduct, IEnumerator> purchaseMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseIAPProductCommand.NativeFieldInfoPtr_purchaseMethod);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IAPProduct, IEnumerator>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseIAPProductCommand.NativeFieldInfoPtr_purchaseMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeFieldInfoPtr_store;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeFieldInfoPtr_ProductID;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeFieldInfoPtr__Product_k__BackingField;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeFieldInfoPtr_purchaseMethod;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeMethodInfoPtr_get_Product_Public_get_IAPProduct_0;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeMethodInfoPtr_set_Product_Private_set_Void_IAPProduct_0;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IAPStoreModel_String_Func_2_IAPProduct_IEnumerator_0;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x02000050 RID: 80
		[ObfuscatedName("dwd.iap.store.PurchaseIAPProductCommand+<execute>d__8")]
		public sealed class _execute_d__8 : Object
		{
			// Token: 0x0600042C RID: 1068 RVA: 0x00011D78 File Offset: 0x0000FF78
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__8()
			{
				Il2CppClassPointerStore<PurchaseIAPProductCommand._execute_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PurchaseIAPProductCommand>.NativeClassPtr, "<execute>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PurchaseIAPProductCommand._execute_d__8>.NativeClassPtr);
				PurchaseIAPProductCommand._execute_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchaseIAPProductCommand._execute_d__8>.NativeClassPtr, "<>1__state");
				PurchaseIAPProductCommand._execute_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchaseIAPProductCommand._execute_d__8>.NativeClassPtr, "<>2__current");
				PurchaseIAPProductCommand._execute_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchaseIAPProductCommand._execute_d__8>.NativeClassPtr, "<>4__this");
				PurchaseIAPProductCommand._execute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchaseIAPProductCommand._execute_d__8>.NativeClassPtr, 100663731);
				PurchaseIAPProductCommand._execute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchaseIAPProductCommand._execute_d__8>.NativeClassPtr, 100663732);
				PurchaseIAPProductCommand._execute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchaseIAPProductCommand._execute_d__8>.NativeClassPtr, 100663733);
				PurchaseIAPProductCommand._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchaseIAPProductCommand._execute_d__8>.NativeClassPtr, 100663734);
				PurchaseIAPProductCommand._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchaseIAPProductCommand._execute_d__8>.NativeClassPtr, 100663735);
				PurchaseIAPProductCommand._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchaseIAPProductCommand._execute_d__8>.NativeClassPtr, 100663736);
			}

			// Token: 0x0600042D RID: 1069 RVA: 0x00011E58 File Offset: 0x00010058
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PurchaseIAPProductCommand._execute_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchaseIAPProductCommand._execute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600042E RID: 1070 RVA: 0x00011EA0 File Offset: 0x000100A0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchaseIAPProductCommand._execute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600042F RID: 1071 RVA: 0x00011ED4 File Offset: 0x000100D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202358, XrefRangeEnd = 1202372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchaseIAPProductCommand._execute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000163 RID: 355
			// (get) Token: 0x06000430 RID: 1072 RVA: 0x00011F10 File Offset: 0x00010110
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchaseIAPProductCommand._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000431 RID: 1073 RVA: 0x00011F50 File Offset: 0x00010150
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202372, XrefRangeEnd = 1202377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchaseIAPProductCommand._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000164 RID: 356
			// (get) Token: 0x06000432 RID: 1074 RVA: 0x00011F84 File Offset: 0x00010184
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchaseIAPProductCommand._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000433 RID: 1075 RVA: 0x00003D78 File Offset: 0x00001F78
			public _execute_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000160 RID: 352
			// (get) Token: 0x06000434 RID: 1076 RVA: 0x00011FC4 File Offset: 0x000101C4
			// (set) Token: 0x06000435 RID: 1077 RVA: 0x00003D81 File Offset: 0x00001F81
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseIAPProductCommand._execute_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseIAPProductCommand._execute_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000161 RID: 353
			// (get) Token: 0x06000436 RID: 1078 RVA: 0x00011FEC File Offset: 0x000101EC
			// (set) Token: 0x06000437 RID: 1079 RVA: 0x00003D9C File Offset: 0x00001F9C
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseIAPProductCommand._execute_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseIAPProductCommand._execute_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000162 RID: 354
			// (get) Token: 0x06000438 RID: 1080 RVA: 0x0001201C File Offset: 0x0001021C
			// (set) Token: 0x06000439 RID: 1081 RVA: 0x00003DBB File Offset: 0x00001FBB
			public unsafe PurchaseIAPProductCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseIAPProductCommand._execute_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PurchaseIAPProductCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseIAPProductCommand._execute_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040002C1 RID: 705
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040002C2 RID: 706
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040002C3 RID: 707
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040002C4 RID: 708
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040002C5 RID: 709
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002C6 RID: 710
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040002C7 RID: 711
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040002C8 RID: 712
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002C9 RID: 713
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
