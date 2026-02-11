using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace dwd.iap.store
{
	// Token: 0x02000026 RID: 38
	public class StubIAPStoreModel : IAPStoreModel
	{
		// Token: 0x06000232 RID: 562 RVA: 0x0000BA34 File Offset: 0x00009C34
		// Note: this type is marked as 'beforefieldinit'.
		static StubIAPStoreModel()
		{
			Il2CppClassPointerStore<StubIAPStoreModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("InAppPurchasing.dll", "dwd.iap.store", "StubIAPStoreModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StubIAPStoreModel>.NativeClassPtr);
			StubIAPStoreModel.NativeMethodInfoPtr_InitializeWithID_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StubIAPStoreModel>.NativeClassPtr, 100663746);
			StubIAPStoreModel.NativeMethodInfoPtr_purchase_Protected_Virtual_IEnumerator_IAPProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StubIAPStoreModel>.NativeClassPtr, 100663747);
			StubIAPStoreModel.NativeMethodInfoPtr_preInitialize_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StubIAPStoreModel>.NativeClassPtr, 100663748);
			StubIAPStoreModel.NativeMethodInfoPtr_populateCatalog_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StubIAPStoreModel>.NativeClassPtr, 100663749);
			StubIAPStoreModel.NativeMethodInfoPtr_getOwnedProductsCommand_Protected_Virtual_GetProductOwnershipCommand_Action_1_HashSet_1_IAPProduct_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StubIAPStoreModel>.NativeClassPtr, 100663750);
			StubIAPStoreModel.NativeMethodInfoPtr_uninitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StubIAPStoreModel>.NativeClassPtr, 100663751);
			StubIAPStoreModel.NativeMethodInfoPtr_get_IsStoreAvailable_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StubIAPStoreModel>.NativeClassPtr, 100663752);
			StubIAPStoreModel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StubIAPStoreModel>.NativeClassPtr, 100663753);
			StubIAPStoreModel.NativeMethodInfoPtr__populateCatalog_b__3_0_Private_Void_GetIAPCatalogCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StubIAPStoreModel>.NativeClassPtr, 100663754);
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0000BB18 File Offset: 0x00009D18
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeWithID(string applicationID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(applicationID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StubIAPStoreModel.NativeMethodInfoPtr_InitializeWithID_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0000BB68 File Offset: 0x00009D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202585, XrefRangeEnd = 1202589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator purchase(IAPProduct product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StubIAPStoreModel.NativeMethodInfoPtr_purchase_Protected_Virtual_IEnumerator_IAPProduct_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0000BBC4 File Offset: 0x00009DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202589, XrefRangeEnd = 1202594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator preInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StubIAPStoreModel.NativeMethodInfoPtr_preInitialize_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0000BC10 File Offset: 0x00009E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202594, XrefRangeEnd = 1202608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator populateCatalog()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StubIAPStoreModel.NativeMethodInfoPtr_populateCatalog_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0000BC5C File Offset: 0x00009E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202608, XrefRangeEnd = 1202615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override GetProductOwnershipCommand getOwnedProductsCommand(Action<HashSet<IAPProduct>> onOwnedProducts, Action<string> onFailed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(onOwnedProducts);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFailed);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StubIAPStoreModel.NativeMethodInfoPtr_getOwnedProductsCommand_Protected_Virtual_GetProductOwnershipCommand_Action_1_HashSet_1_IAPProduct_Action_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GetProductOwnershipCommand>(intPtr3) : null;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x0000BCCC File Offset: 0x00009ECC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void uninitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StubIAPStoreModel.NativeMethodInfoPtr_uninitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000239 RID: 569 RVA: 0x0000BD08 File Offset: 0x00009F08
		public unsafe override bool IsStoreAvailable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StubIAPStoreModel.NativeMethodInfoPtr_get_IsStoreAvailable_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0000BD50 File Offset: 0x00009F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202615, XrefRangeEnd = 1202656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StubIAPStoreModel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StubIAPStoreModel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StubIAPStoreModel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0000BD8C File Offset: 0x00009F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202656, XrefRangeEnd = 1202671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _populateCatalog_b__3_0(GetIAPCatalogCommand _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StubIAPStoreModel.NativeMethodInfoPtr__populateCatalog_b__3_0_Private_Void_GetIAPCatalogCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00002F1A File Offset: 0x0000111A
		public StubIAPStoreModel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeMethodInfoPtr_InitializeWithID_Public_Virtual_Void_String_0;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeMethodInfoPtr_purchase_Protected_Virtual_IEnumerator_IAPProduct_0;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeMethodInfoPtr_preInitialize_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeMethodInfoPtr_populateCatalog_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeMethodInfoPtr_getOwnedProductsCommand_Protected_Virtual_GetProductOwnershipCommand_Action_1_HashSet_1_IAPProduct_Action_1_String_0;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeMethodInfoPtr_uninitialize_Protected_Virtual_Void_0;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeMethodInfoPtr_get_IsStoreAvailable_Public_Virtual_get_Boolean_0;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeMethodInfoPtr__populateCatalog_b__3_0_Private_Void_GetIAPCatalogCommand_0;

		// Token: 0x02000051 RID: 81
		[ObfuscatedName("dwd.iap.store.StubIAPStoreModel+<preInitialize>d__2")]
		public sealed class _preInitialize_d__2 : Object
		{
			// Token: 0x0600043A RID: 1082 RVA: 0x0001204C File Offset: 0x0001024C
			// Note: this type is marked as 'beforefieldinit'.
			static _preInitialize_d__2()
			{
				Il2CppClassPointerStore<StubIAPStoreModel._preInitialize_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StubIAPStoreModel>.NativeClassPtr, "<preInitialize>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StubIAPStoreModel._preInitialize_d__2>.NativeClassPtr);
				StubIAPStoreModel._preInitialize_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StubIAPStoreModel._preInitialize_d__2>.NativeClassPtr, "<>1__state");
				StubIAPStoreModel._preInitialize_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StubIAPStoreModel._preInitialize_d__2>.NativeClassPtr, "<>2__current");
				StubIAPStoreModel._preInitialize_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StubIAPStoreModel._preInitialize_d__2>.NativeClassPtr, "<>4__this");
				StubIAPStoreModel._preInitialize_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StubIAPStoreModel._preInitialize_d__2>.NativeClassPtr, 100663755);
				StubIAPStoreModel._preInitialize_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StubIAPStoreModel._preInitialize_d__2>.NativeClassPtr, 100663756);
				StubIAPStoreModel._preInitialize_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StubIAPStoreModel._preInitialize_d__2>.NativeClassPtr, 100663757);
				StubIAPStoreModel._preInitialize_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StubIAPStoreModel._preInitialize_d__2>.NativeClassPtr, 100663758);
				StubIAPStoreModel._preInitialize_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StubIAPStoreModel._preInitialize_d__2>.NativeClassPtr, 100663759);
				StubIAPStoreModel._preInitialize_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StubIAPStoreModel._preInitialize_d__2>.NativeClassPtr, 100663760);
			}

			// Token: 0x0600043B RID: 1083 RVA: 0x0001212C File Offset: 0x0001032C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _preInitialize_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StubIAPStoreModel._preInitialize_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StubIAPStoreModel._preInitialize_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600043C RID: 1084 RVA: 0x00012174 File Offset: 0x00010374
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StubIAPStoreModel._preInitialize_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600043D RID: 1085 RVA: 0x000121A8 File Offset: 0x000103A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202571, XrefRangeEnd = 1202575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StubIAPStoreModel._preInitialize_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000168 RID: 360
			// (get) Token: 0x0600043E RID: 1086 RVA: 0x000121E4 File Offset: 0x000103E4
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StubIAPStoreModel._preInitialize_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600043F RID: 1087 RVA: 0x00012224 File Offset: 0x00010424
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202575, XrefRangeEnd = 1202580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StubIAPStoreModel._preInitialize_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000169 RID: 361
			// (get) Token: 0x06000440 RID: 1088 RVA: 0x00012258 File Offset: 0x00010458
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StubIAPStoreModel._preInitialize_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000441 RID: 1089 RVA: 0x00003DDA File Offset: 0x00001FDA
			public _preInitialize_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000165 RID: 357
			// (get) Token: 0x06000442 RID: 1090 RVA: 0x00012298 File Offset: 0x00010498
			// (set) Token: 0x06000443 RID: 1091 RVA: 0x00003DE3 File Offset: 0x00001FE3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StubIAPStoreModel._preInitialize_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StubIAPStoreModel._preInitialize_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000166 RID: 358
			// (get) Token: 0x06000444 RID: 1092 RVA: 0x000122C0 File Offset: 0x000104C0
			// (set) Token: 0x06000445 RID: 1093 RVA: 0x00003DFE File Offset: 0x00001FFE
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StubIAPStoreModel._preInitialize_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StubIAPStoreModel._preInitialize_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000167 RID: 359
			// (get) Token: 0x06000446 RID: 1094 RVA: 0x000122F0 File Offset: 0x000104F0
			// (set) Token: 0x06000447 RID: 1095 RVA: 0x00003E1D File Offset: 0x0000201D
			public unsafe StubIAPStoreModel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StubIAPStoreModel._preInitialize_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StubIAPStoreModel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StubIAPStoreModel._preInitialize_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040002CA RID: 714
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040002CB RID: 715
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040002CC RID: 716
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040002CD RID: 717
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040002CE RID: 718
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002CF RID: 719
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040002D0 RID: 720
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040002D1 RID: 721
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002D2 RID: 722
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000052 RID: 82
		[ObfuscatedName("dwd.iap.store.StubIAPStoreModel+<purchase>d__1")]
		public sealed class _purchase_d__1 : Object
		{
			// Token: 0x06000448 RID: 1096 RVA: 0x00012320 File Offset: 0x00010520
			// Note: this type is marked as 'beforefieldinit'.
			static _purchase_d__1()
			{
				Il2CppClassPointerStore<StubIAPStoreModel._purchase_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StubIAPStoreModel>.NativeClassPtr, "<purchase>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StubIAPStoreModel._purchase_d__1>.NativeClassPtr);
				StubIAPStoreModel._purchase_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StubIAPStoreModel._purchase_d__1>.NativeClassPtr, "<>1__state");
				StubIAPStoreModel._purchase_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StubIAPStoreModel._purchase_d__1>.NativeClassPtr, "<>2__current");
				StubIAPStoreModel._purchase_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StubIAPStoreModel._purchase_d__1>.NativeClassPtr, 100663761);
				StubIAPStoreModel._purchase_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StubIAPStoreModel._purchase_d__1>.NativeClassPtr, 100663762);
				StubIAPStoreModel._purchase_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StubIAPStoreModel._purchase_d__1>.NativeClassPtr, 100663763);
				StubIAPStoreModel._purchase_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StubIAPStoreModel._purchase_d__1>.NativeClassPtr, 100663764);
				StubIAPStoreModel._purchase_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StubIAPStoreModel._purchase_d__1>.NativeClassPtr, 100663765);
				StubIAPStoreModel._purchase_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StubIAPStoreModel._purchase_d__1>.NativeClassPtr, 100663766);
			}

			// Token: 0x06000449 RID: 1097 RVA: 0x000123EC File Offset: 0x000105EC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _purchase_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StubIAPStoreModel._purchase_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StubIAPStoreModel._purchase_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600044A RID: 1098 RVA: 0x00012434 File Offset: 0x00010634
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StubIAPStoreModel._purchase_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600044B RID: 1099 RVA: 0x00012468 File Offset: 0x00010668
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StubIAPStoreModel._purchase_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700016C RID: 364
			// (get) Token: 0x0600044C RID: 1100 RVA: 0x000124A4 File Offset: 0x000106A4
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StubIAPStoreModel._purchase_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600044D RID: 1101 RVA: 0x000124E4 File Offset: 0x000106E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202580, XrefRangeEnd = 1202585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StubIAPStoreModel._purchase_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700016D RID: 365
			// (get) Token: 0x0600044E RID: 1102 RVA: 0x00012518 File Offset: 0x00010718
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StubIAPStoreModel._purchase_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600044F RID: 1103 RVA: 0x00003E3C File Offset: 0x0000203C
			public _purchase_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700016A RID: 362
			// (get) Token: 0x06000450 RID: 1104 RVA: 0x00012558 File Offset: 0x00010758
			// (set) Token: 0x06000451 RID: 1105 RVA: 0x00003E45 File Offset: 0x00002045
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StubIAPStoreModel._purchase_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StubIAPStoreModel._purchase_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700016B RID: 363
			// (get) Token: 0x06000452 RID: 1106 RVA: 0x00012580 File Offset: 0x00010780
			// (set) Token: 0x06000453 RID: 1107 RVA: 0x00003E60 File Offset: 0x00002060
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StubIAPStoreModel._purchase_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StubIAPStoreModel._purchase_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040002D3 RID: 723
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040002D4 RID: 724
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040002D5 RID: 725
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040002D6 RID: 726
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002D7 RID: 727
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040002D8 RID: 728
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040002D9 RID: 729
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002DA RID: 730
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
