using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading.Tasks;
using Steamworks;

namespace dwd.iap.store
{
	// Token: 0x02000003 RID: 3
	public class GetSteamProductOwnershipCommand : GetProductOwnershipCommand
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002984 File Offset: 0x00000B84
		// Note: this type is marked as 'beforefieldinit'.
		static GetSteamProductOwnershipCommand()
		{
			Il2CppClassPointerStore<GetSteamProductOwnershipCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("InAppPurchasing-Steam.dll", "dwd.iap.store", "GetSteamProductOwnershipCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetSteamProductOwnershipCommand>.NativeClassPtr);
			GetSteamProductOwnershipCommand.NativeFieldInfoPtr_authSessionTicket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetSteamProductOwnershipCommand>.NativeClassPtr, "authSessionTicket");
			GetSteamProductOwnershipCommand.NativeMethodInfoPtr__ctor_Public_Void_IAPStoreModel_Action_1_HashSet_1_IAPProduct_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSteamProductOwnershipCommand>.NativeClassPtr, 100663299);
			GetSteamProductOwnershipCommand.NativeMethodInfoPtr_initMetadata_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSteamProductOwnershipCommand>.NativeClassPtr, 100663300);
			GetSteamProductOwnershipCommand.NativeMethodInfoPtr_checkLocalOwnershipDiscrepancies_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSteamProductOwnershipCommand>.NativeClassPtr, 100663301);
			GetSteamProductOwnershipCommand.NativeMethodInfoPtr_getStoreOwnership_Private_Il2CppStringArray_IAPProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSteamProductOwnershipCommand>.NativeClassPtr, 100663302);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002A18 File Offset: 0x00000C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257315, XrefRangeEnd = 1257316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetSteamProductOwnershipCommand(IAPStoreModel storeModel, Action<HashSet<IAPProduct>> onOwnedProducts, Action<string> onFailed)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetSteamProductOwnershipCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(storeModel);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onOwnedProducts);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFailed);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetSteamProductOwnershipCommand.NativeMethodInfoPtr__ctor_Public_Void_IAPStoreModel_Action_1_HashSet_1_IAPProduct_Action_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002A88 File Offset: 0x00000C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257316, XrefRangeEnd = 1257321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator initMetadata()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GetSteamProductOwnershipCommand.NativeMethodInfoPtr_initMetadata_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002AD4 File Offset: 0x00000CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257321, XrefRangeEnd = 1257326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator checkLocalOwnershipDiscrepancies()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GetSteamProductOwnershipCommand.NativeMethodInfoPtr_checkLocalOwnershipDiscrepancies_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002B20 File Offset: 0x00000D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257326, XrefRangeEnd = 1257333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray getStoreOwnership(IAPProduct product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetSteamProductOwnershipCommand.NativeMethodInfoPtr_getStoreOwnership_Private_Il2CppStringArray_IAPProduct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002059 File Offset: 0x00000259
		public GetSteamProductOwnershipCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002B70 File Offset: 0x00000D70
		// (set) Token: 0x0600000C RID: 12 RVA: 0x00002062 File Offset: 0x00000262
		public unsafe string authSessionTicket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSteamProductOwnershipCommand.NativeFieldInfoPtr_authSessionTicket);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSteamProductOwnershipCommand.NativeFieldInfoPtr_authSessionTicket), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeFieldInfoPtr_authSessionTicket;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IAPStoreModel_Action_1_HashSet_1_IAPProduct_Action_1_String_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_initMetadata_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_checkLocalOwnershipDiscrepancies_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_getStoreOwnership_Private_Il2CppStringArray_IAPProduct_0;

		// Token: 0x0200000D RID: 13
		[ObfuscatedName("dwd.iap.store.GetSteamProductOwnershipCommand+<checkLocalOwnershipDiscrepancies>d__3")]
		public sealed class _checkLocalOwnershipDiscrepancies_d__3 : Object
		{
			// Token: 0x06000070 RID: 112 RVA: 0x00003CAC File Offset: 0x00001EAC
			// Note: this type is marked as 'beforefieldinit'.
			static _checkLocalOwnershipDiscrepancies_d__3()
			{
				Il2CppClassPointerStore<GetSteamProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetSteamProductOwnershipCommand>.NativeClassPtr, "<checkLocalOwnershipDiscrepancies>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetSteamProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__3>.NativeClassPtr);
				GetSteamProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetSteamProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__3>.NativeClassPtr, "<>1__state");
				GetSteamProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetSteamProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__3>.NativeClassPtr, "<>2__current");
				GetSteamProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetSteamProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__3>.NativeClassPtr, "<>4__this");
				GetSteamProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSteamProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__3>.NativeClassPtr, 100663303);
				GetSteamProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSteamProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__3>.NativeClassPtr, 100663304);
				GetSteamProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSteamProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__3>.NativeClassPtr, 100663305);
				GetSteamProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSteamProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__3>.NativeClassPtr, 100663306);
				GetSteamProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSteamProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__3>.NativeClassPtr, 100663307);
				GetSteamProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSteamProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__3>.NativeClassPtr, 100663308);
			}

			// Token: 0x06000071 RID: 113 RVA: 0x00003D8C File Offset: 0x00001F8C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _checkLocalOwnershipDiscrepancies_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetSteamProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetSteamProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000072 RID: 114 RVA: 0x00003DD4 File Offset: 0x00001FD4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetSteamProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000073 RID: 115 RVA: 0x00003E08 File Offset: 0x00002008
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257260, XrefRangeEnd = 1257295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetSteamProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x06000074 RID: 116 RVA: 0x00003E44 File Offset: 0x00002044
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetSteamProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000075 RID: 117 RVA: 0x00003E84 File Offset: 0x00002084
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257295, XrefRangeEnd = 1257300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetSteamProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x06000076 RID: 118 RVA: 0x00003EB8 File Offset: 0x000020B8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetSteamProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000077 RID: 119 RVA: 0x000023ED File Offset: 0x000005ED
			public _checkLocalOwnershipDiscrepancies_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x06000078 RID: 120 RVA: 0x00003EF8 File Offset: 0x000020F8
			// (set) Token: 0x06000079 RID: 121 RVA: 0x000023F6 File Offset: 0x000005F6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSteamProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSteamProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x0600007A RID: 122 RVA: 0x00003F20 File Offset: 0x00002120
			// (set) Token: 0x0600007B RID: 123 RVA: 0x00002411 File Offset: 0x00000611
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSteamProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSteamProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x0600007C RID: 124 RVA: 0x00003F50 File Offset: 0x00002150
			// (set) Token: 0x0600007D RID: 125 RVA: 0x00002430 File Offset: 0x00000630
			public unsafe GetSteamProductOwnershipCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSteamProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GetSteamProductOwnershipCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSteamProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400003C RID: 60
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400003D RID: 61
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400003E RID: 62
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400003F RID: 63
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000040 RID: 64
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000041 RID: 65
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000042 RID: 66
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000043 RID: 67
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000044 RID: 68
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200000E RID: 14
		[ObfuscatedName("dwd.iap.store.GetSteamProductOwnershipCommand+<initMetadata>d__2")]
		public sealed class _initMetadata_d__2 : Object
		{
			// Token: 0x0600007E RID: 126 RVA: 0x00003F80 File Offset: 0x00002180
			// Note: this type is marked as 'beforefieldinit'.
			static _initMetadata_d__2()
			{
				Il2CppClassPointerStore<GetSteamProductOwnershipCommand._initMetadata_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetSteamProductOwnershipCommand>.NativeClassPtr, "<initMetadata>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetSteamProductOwnershipCommand._initMetadata_d__2>.NativeClassPtr);
				GetSteamProductOwnershipCommand._initMetadata_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetSteamProductOwnershipCommand._initMetadata_d__2>.NativeClassPtr, "<>1__state");
				GetSteamProductOwnershipCommand._initMetadata_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetSteamProductOwnershipCommand._initMetadata_d__2>.NativeClassPtr, "<>2__current");
				GetSteamProductOwnershipCommand._initMetadata_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetSteamProductOwnershipCommand._initMetadata_d__2>.NativeClassPtr, "<>4__this");
				GetSteamProductOwnershipCommand._initMetadata_d__2.NativeFieldInfoPtr__authTicket_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetSteamProductOwnershipCommand._initMetadata_d__2>.NativeClassPtr, "<authTicket>5__2");
				GetSteamProductOwnershipCommand._initMetadata_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSteamProductOwnershipCommand._initMetadata_d__2>.NativeClassPtr, 100663309);
				GetSteamProductOwnershipCommand._initMetadata_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSteamProductOwnershipCommand._initMetadata_d__2>.NativeClassPtr, 100663310);
				GetSteamProductOwnershipCommand._initMetadata_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSteamProductOwnershipCommand._initMetadata_d__2>.NativeClassPtr, 100663311);
				GetSteamProductOwnershipCommand._initMetadata_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSteamProductOwnershipCommand._initMetadata_d__2>.NativeClassPtr, 100663312);
				GetSteamProductOwnershipCommand._initMetadata_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSteamProductOwnershipCommand._initMetadata_d__2>.NativeClassPtr, 100663313);
				GetSteamProductOwnershipCommand._initMetadata_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSteamProductOwnershipCommand._initMetadata_d__2>.NativeClassPtr, 100663314);
			}

			// Token: 0x0600007F RID: 127 RVA: 0x00004074 File Offset: 0x00002274
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _initMetadata_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetSteamProductOwnershipCommand._initMetadata_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetSteamProductOwnershipCommand._initMetadata_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000080 RID: 128 RVA: 0x000040BC File Offset: 0x000022BC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetSteamProductOwnershipCommand._initMetadata_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000081 RID: 129 RVA: 0x000040F0 File Offset: 0x000022F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257300, XrefRangeEnd = 1257310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetSteamProductOwnershipCommand._initMetadata_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000028 RID: 40
			// (get) Token: 0x06000082 RID: 130 RVA: 0x0000412C File Offset: 0x0000232C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetSteamProductOwnershipCommand._initMetadata_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000083 RID: 131 RVA: 0x0000416C File Offset: 0x0000236C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257310, XrefRangeEnd = 1257315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetSteamProductOwnershipCommand._initMetadata_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000029 RID: 41
			// (get) Token: 0x06000084 RID: 132 RVA: 0x000041A0 File Offset: 0x000023A0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetSteamProductOwnershipCommand._initMetadata_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000085 RID: 133 RVA: 0x0000244F File Offset: 0x0000064F
			public _initMetadata_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x06000086 RID: 134 RVA: 0x000041E0 File Offset: 0x000023E0
			// (set) Token: 0x06000087 RID: 135 RVA: 0x00002458 File Offset: 0x00000658
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSteamProductOwnershipCommand._initMetadata_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSteamProductOwnershipCommand._initMetadata_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000025 RID: 37
			// (get) Token: 0x06000088 RID: 136 RVA: 0x00004208 File Offset: 0x00002408
			// (set) Token: 0x06000089 RID: 137 RVA: 0x00002473 File Offset: 0x00000673
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSteamProductOwnershipCommand._initMetadata_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSteamProductOwnershipCommand._initMetadata_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000026 RID: 38
			// (get) Token: 0x0600008A RID: 138 RVA: 0x00004238 File Offset: 0x00002438
			// (set) Token: 0x0600008B RID: 139 RVA: 0x00002492 File Offset: 0x00000692
			public unsafe GetSteamProductOwnershipCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSteamProductOwnershipCommand._initMetadata_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GetSteamProductOwnershipCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSteamProductOwnershipCommand._initMetadata_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x0600008C RID: 140 RVA: 0x00004268 File Offset: 0x00002468
			// (set) Token: 0x0600008D RID: 141 RVA: 0x000024B1 File Offset: 0x000006B1
			public unsafe Task<AuthTicket> _authTicket_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSteamProductOwnershipCommand._initMetadata_d__2.NativeFieldInfoPtr__authTicket_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<AuthTicket>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSteamProductOwnershipCommand._initMetadata_d__2.NativeFieldInfoPtr__authTicket_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000045 RID: 69
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000046 RID: 70
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000047 RID: 71
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000048 RID: 72
			private static readonly IntPtr NativeFieldInfoPtr__authTicket_5__2;

			// Token: 0x04000049 RID: 73
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400004A RID: 74
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400004B RID: 75
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400004C RID: 76
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400004D RID: 77
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400004E RID: 78
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
