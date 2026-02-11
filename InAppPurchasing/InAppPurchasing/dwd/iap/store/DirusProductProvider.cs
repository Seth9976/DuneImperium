using System;
using boardgames.src.broadcast.motd;
using Canis.attributes;
using Canis.utils.ids;
using dwd.core.archetypes;
using dwd.core.networking.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace dwd.iap.store
{
	// Token: 0x0200000C RID: 12
	public class DirusProductProvider : MonoBehaviour
	{
		// Token: 0x06000040 RID: 64 RVA: 0x00004B08 File Offset: 0x00002D08
		// Note: this type is marked as 'beforefieldinit'.
		static DirusProductProvider()
		{
			Il2CppClassPointerStore<DirusProductProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("InAppPurchasing.dll", "dwd.iap.store", "DirusProductProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirusProductProvider>.NativeClassPtr);
			DirusProductProvider.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirusProductProvider>.NativeClassPtr, "initialized");
			DirusProductProvider.NativeFieldInfoPtr_anonClaimToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirusProductProvider>.NativeClassPtr, "anonClaimToken");
			DirusProductProvider.NativeFieldInfoPtr_commerceURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirusProductProvider>.NativeClassPtr, "commerceURL");
			DirusProductProvider.NativeFieldInfoPtr_client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirusProductProvider>.NativeClassPtr, "client");
			DirusProductProvider.NativeFieldInfoPtr__Lookup_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirusProductProvider>.NativeClassPtr, "<Lookup>k__BackingField");
			DirusProductProvider.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirusProductProvider>.NativeClassPtr, "version");
			DirusProductProvider.NativeMethodInfoPtr_get_AnonymousClaimToken_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirusProductProvider>.NativeClassPtr, 100663347);
			DirusProductProvider.NativeMethodInfoPtr_get_Initialized_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirusProductProvider>.NativeClassPtr, 100663348);
			DirusProductProvider.NativeMethodInfoPtr_get_CommerceURL_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirusProductProvider>.NativeClassPtr, 100663349);
			DirusProductProvider.NativeMethodInfoPtr_get_Lookup_Public_get_ReadOnlyDictionary_2_ArchetypeID_ArchetypeComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirusProductProvider>.NativeClassPtr, 100663350);
			DirusProductProvider.NativeMethodInfoPtr_set_Lookup_Private_set_Void_ReadOnlyDictionary_2_ArchetypeID_ArchetypeComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirusProductProvider>.NativeClassPtr, 100663351);
			DirusProductProvider.NativeMethodInfoPtr_parseIAPProductIDs_Private_Static_ReadOnlyDictionary_2_String_String_ReadOnlyAttributes_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirusProductProvider>.NativeClassPtr, 100663352);
			DirusProductProvider.NativeMethodInfoPtr_CreateIAPProduct_Public_IAPProduct_String_ArchetypeComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirusProductProvider>.NativeClassPtr, 100663353);
			DirusProductProvider.NativeMethodInfoPtr_GetProductsForInitialization_Public_Virtual_Final_New_IEnumerable_1_IAPProduct_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirusProductProvider>.NativeClassPtr, 100663354);
			DirusProductProvider.NativeMethodInfoPtr_Request_Public_Virtual_Final_New_Void_IIAPStoreBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirusProductProvider>.NativeClassPtr, 100663355);
			DirusProductProvider.NativeMethodInfoPtr_Request_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirusProductProvider>.NativeClassPtr, 100663356);
			DirusProductProvider.NativeMethodInfoPtr_RetrieveIAPProducts_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirusProductProvider>.NativeClassPtr, 100663357);
			DirusProductProvider.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirusProductProvider>.NativeClassPtr, 100663358);
			DirusProductProvider.NativeMethodInfoPtr_GetStaticCatalog_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirusProductProvider>.NativeClassPtr, 100663359);
			DirusProductProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirusProductProvider>.NativeClassPtr, 100663360);
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00004CC8 File Offset: 0x00002EC8
		public unsafe virtual string AnonymousClaimToken
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirusProductProvider.NativeMethodInfoPtr_get_AnonymousClaimToken_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00004D00 File Offset: 0x00002F00
		public unsafe virtual bool Initialized
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirusProductProvider.NativeMethodInfoPtr_get_Initialized_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00004D3C File Offset: 0x00002F3C
		public unsafe virtual string CommerceURL
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirusProductProvider.NativeMethodInfoPtr_get_CommerceURL_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00004D74 File Offset: 0x00002F74
		// (set) Token: 0x06000045 RID: 69 RVA: 0x00004DB4 File Offset: 0x00002FB4
		public unsafe ReadOnlyDictionary<ArchetypeID, ArchetypeComponent> Lookup
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirusProductProvider.NativeMethodInfoPtr_get_Lookup_Public_get_ReadOnlyDictionary_2_ArchetypeID_ArchetypeComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyDictionary<ArchetypeID, ArchetypeComponent>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirusProductProvider.NativeMethodInfoPtr_set_Lookup_Private_set_Void_ReadOnlyDictionary_2_ArchetypeID_ArchetypeComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00004DF8 File Offset: 0x00002FF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1200022, RefRangeEnd = 1200024, XrefRangeStart = 1199991, XrefRangeEnd = 1200022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReadOnlyDictionary<string, string> parseIAPProductIDs(ReadOnlyAttributes attributes, ArchetypeID archID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(archID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirusProductProvider.NativeMethodInfoPtr_parseIAPProductIDs_Private_Static_ReadOnlyDictionary_2_String_String_ReadOnlyAttributes_ArchetypeID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyDictionary<string, string>>(intPtr3) : null;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00004E50 File Offset: 0x00003050
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1200101, RefRangeEnd = 1200102, XrefRangeStart = 1200024, XrefRangeEnd = 1200101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAPProduct CreateIAPProduct(string storeName, ArchetypeComponent product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(storeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirusProductProvider.NativeMethodInfoPtr_CreateIAPProduct_Public_IAPProduct_String_ArchetypeComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAPProduct>(intPtr3) : null;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00004EB4 File Offset: 0x000030B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200102, XrefRangeEnd = 1200109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<IAPProduct> GetProductsForInitialization(string storeName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(storeName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirusProductProvider.NativeMethodInfoPtr_GetProductsForInitialization_Public_Virtual_Final_New_IEnumerable_1_IAPProduct_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAPProduct>>(intPtr3) : null;
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00004F04 File Offset: 0x00003104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200109, XrefRangeEnd = 1200126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Request(IIAPStoreBehaviour storeBehaviour)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(storeBehaviour);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirusProductProvider.NativeMethodInfoPtr_Request_Public_Virtual_Final_New_Void_IIAPStoreBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00004F48 File Offset: 0x00003148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200126, XrefRangeEnd = 1200132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Request()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirusProductProvider.NativeMethodInfoPtr_Request_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00004F7C File Offset: 0x0000317C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200132, XrefRangeEnd = 1200137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator RetrieveIAPProducts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirusProductProvider.NativeMethodInfoPtr_RetrieveIAPProducts_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00004FBC File Offset: 0x000031BC
		public unsafe virtual ulong Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirusProductProvider.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00004FF8 File Offset: 0x000031F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200137, XrefRangeEnd = 1200147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetStaticCatalog()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirusProductProvider.NativeMethodInfoPtr_GetStaticCatalog_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00005030 File Offset: 0x00003230
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DirusProductProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DirusProductProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirusProductProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002211 File Offset: 0x00000411
		public DirusProductProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000050 RID: 80 RVA: 0x0000506C File Offset: 0x0000326C
		// (set) Token: 0x06000051 RID: 81 RVA: 0x0000221A File Offset: 0x0000041A
		public unsafe bool initialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirusProductProvider.NativeFieldInfoPtr_initialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirusProductProvider.NativeFieldInfoPtr_initialized)) = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00005094 File Offset: 0x00003294
		// (set) Token: 0x06000053 RID: 83 RVA: 0x00002235 File Offset: 0x00000435
		public unsafe string anonClaimToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirusProductProvider.NativeFieldInfoPtr_anonClaimToken);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirusProductProvider.NativeFieldInfoPtr_anonClaimToken), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000054 RID: 84 RVA: 0x000050BC File Offset: 0x000032BC
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00002254 File Offset: 0x00000454
		public unsafe string commerceURL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirusProductProvider.NativeFieldInfoPtr_commerceURL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirusProductProvider.NativeFieldInfoPtr_commerceURL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000056 RID: 86 RVA: 0x000050E4 File Offset: 0x000032E4
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00002273 File Offset: 0x00000473
		public unsafe string client
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirusProductProvider.NativeFieldInfoPtr_client);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirusProductProvider.NativeFieldInfoPtr_client), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000058 RID: 88 RVA: 0x0000510C File Offset: 0x0000330C
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00002292 File Offset: 0x00000492
		public unsafe ReadOnlyDictionary<ArchetypeID, ArchetypeComponent> _Lookup_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirusProductProvider.NativeFieldInfoPtr__Lookup_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyDictionary<ArchetypeID, ArchetypeComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirusProductProvider.NativeFieldInfoPtr__Lookup_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600005A RID: 90 RVA: 0x0000513C File Offset: 0x0000333C
		// (set) Token: 0x0600005B RID: 91 RVA: 0x000022B1 File Offset: 0x000004B1
		public unsafe ulong version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirusProductProvider.NativeFieldInfoPtr_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirusProductProvider.NativeFieldInfoPtr_version)) = value;
			}
		}

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeFieldInfoPtr_initialized;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeFieldInfoPtr_anonClaimToken;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeFieldInfoPtr_commerceURL;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeFieldInfoPtr_client;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeFieldInfoPtr__Lookup_k__BackingField;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_get_AnonymousClaimToken_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_get_CommerceURL_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_get_Lookup_Public_get_ReadOnlyDictionary_2_ArchetypeID_ArchetypeComponent_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_set_Lookup_Private_set_Void_ReadOnlyDictionary_2_ArchetypeID_ArchetypeComponent_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_parseIAPProductIDs_Private_Static_ReadOnlyDictionary_2_String_String_ReadOnlyAttributes_ArchetypeID_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_CreateIAPProduct_Public_IAPProduct_String_ArchetypeComponent_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_GetProductsForInitialization_Public_Virtual_Final_New_IEnumerable_1_IAPProduct_String_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_Request_Public_Virtual_Final_New_Void_IIAPStoreBehaviour_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_Request_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_RetrieveIAPProducts_Private_IEnumerator_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_GetStaticCatalog_Private_String_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200002F RID: 47
		[ObfuscatedName("dwd.iap.store.DirusProductProvider+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06000299 RID: 665 RVA: 0x0000CE24 File Offset: 0x0000B024
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DirusProductProvider.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DirusProductProvider>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirusProductProvider.__c>.NativeClassPtr);
				DirusProductProvider.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirusProductProvider.__c>.NativeClassPtr, "<>9");
				DirusProductProvider.__c.NativeFieldInfoPtr___9__19_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirusProductProvider.__c>.NativeClassPtr, "<>9__19_0");
				DirusProductProvider.__c.NativeFieldInfoPtr___9__19_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirusProductProvider.__c>.NativeClassPtr, "<>9__19_1");
				DirusProductProvider.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirusProductProvider.__c>.NativeClassPtr, 100663362);
				DirusProductProvider.__c.NativeMethodInfoPtr__RetrieveIAPProducts_b__19_0_Internal_ArchetypeID_ArchetypeComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirusProductProvider.__c>.NativeClassPtr, 100663363);
				DirusProductProvider.__c.NativeMethodInfoPtr__RetrieveIAPProducts_b__19_1_Internal_ArchetypeComponent_ArchetypeComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirusProductProvider.__c>.NativeClassPtr, 100663364);
			}

			// Token: 0x0600029A RID: 666 RVA: 0x0000CEC8 File Offset: 0x0000B0C8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DirusProductProvider.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirusProductProvider.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600029B RID: 667 RVA: 0x0000CF04 File Offset: 0x0000B104
			[CallerCount(0)]
			public unsafe ArchetypeID _RetrieveIAPProducts_b__19_0(ArchetypeComponent _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirusProductProvider.__c.NativeMethodInfoPtr__RetrieveIAPProducts_b__19_0_Internal_ArchetypeID_ArchetypeComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
				}
			}

			// Token: 0x0600029C RID: 668 RVA: 0x0000CF54 File Offset: 0x0000B154
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 75263, RefRangeEnd = 75264, XrefRangeStart = 75263, XrefRangeEnd = 75264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ArchetypeComponent _RetrieveIAPProducts_b__19_1(ArchetypeComponent _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirusProductProvider.__c.NativeMethodInfoPtr__RetrieveIAPProducts_b__19_1_Internal_ArchetypeComponent_ArchetypeComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeComponent>(intPtr3) : null;
				}
			}

			// Token: 0x0600029D RID: 669 RVA: 0x000031D0 File Offset: 0x000013D0
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000DB RID: 219
			// (get) Token: 0x0600029E RID: 670 RVA: 0x0000CFA4 File Offset: 0x0000B1A4
			// (set) Token: 0x0600029F RID: 671 RVA: 0x000031D9 File Offset: 0x000013D9
			public unsafe static DirusProductProvider.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DirusProductProvider.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DirusProductProvider.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DirusProductProvider.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000DC RID: 220
			// (get) Token: 0x060002A0 RID: 672 RVA: 0x0000CFCC File Offset: 0x0000B1CC
			// (set) Token: 0x060002A1 RID: 673 RVA: 0x000031EB File Offset: 0x000013EB
			public unsafe static Func<ArchetypeComponent, ArchetypeID> __9__19_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DirusProductProvider.__c.NativeFieldInfoPtr___9__19_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ArchetypeComponent, ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DirusProductProvider.__c.NativeFieldInfoPtr___9__19_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000DD RID: 221
			// (get) Token: 0x060002A2 RID: 674 RVA: 0x0000CFF4 File Offset: 0x0000B1F4
			// (set) Token: 0x060002A3 RID: 675 RVA: 0x000031FD File Offset: 0x000013FD
			public unsafe static Func<ArchetypeComponent, ArchetypeComponent> __9__19_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DirusProductProvider.__c.NativeFieldInfoPtr___9__19_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ArchetypeComponent, ArchetypeComponent>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DirusProductProvider.__c.NativeFieldInfoPtr___9__19_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001CB RID: 459
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040001CC RID: 460
			private static readonly IntPtr NativeFieldInfoPtr___9__19_0;

			// Token: 0x040001CD RID: 461
			private static readonly IntPtr NativeFieldInfoPtr___9__19_1;

			// Token: 0x040001CE RID: 462
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040001CF RID: 463
			private static readonly IntPtr NativeMethodInfoPtr__RetrieveIAPProducts_b__19_0_Internal_ArchetypeID_ArchetypeComponent_0;

			// Token: 0x040001D0 RID: 464
			private static readonly IntPtr NativeMethodInfoPtr__RetrieveIAPProducts_b__19_1_Internal_ArchetypeComponent_ArchetypeComponent_0;
		}

		// Token: 0x02000030 RID: 48
		[ObfuscatedName("dwd.iap.store.DirusProductProvider+<>c__DisplayClass16_0")]
		public sealed class __c__DisplayClass16_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060002A4 RID: 676 RVA: 0x0000D01C File Offset: 0x0000B21C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_0()
			{
				Il2CppClassPointerStore<DirusProductProvider.__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DirusProductProvider>.NativeClassPtr, "<>c__DisplayClass16_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirusProductProvider.__c__DisplayClass16_0>.NativeClassPtr);
				DirusProductProvider.__c__DisplayClass16_0.NativeFieldInfoPtr_storeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirusProductProvider.__c__DisplayClass16_0>.NativeClassPtr, "storeName");
				DirusProductProvider.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirusProductProvider.__c__DisplayClass16_0>.NativeClassPtr, "<>4__this");
				DirusProductProvider.__c__DisplayClass16_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirusProductProvider.__c__DisplayClass16_0>.NativeClassPtr, "<>9__0");
				DirusProductProvider.__c__DisplayClass16_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirusProductProvider.__c__DisplayClass16_0>.NativeClassPtr, "<>9__1");
				DirusProductProvider.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirusProductProvider.__c__DisplayClass16_0>.NativeClassPtr, 100663365);
				DirusProductProvider.__c__DisplayClass16_0.NativeMethodInfoPtr__GetProductsForInitialization_b__0_Internal_Boolean_ArchetypeComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirusProductProvider.__c__DisplayClass16_0>.NativeClassPtr, 100663366);
				DirusProductProvider.__c__DisplayClass16_0.NativeMethodInfoPtr__GetProductsForInitialization_b__1_Internal_IAPProduct_ArchetypeComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirusProductProvider.__c__DisplayClass16_0>.NativeClassPtr, 100663367);
			}

			// Token: 0x060002A5 RID: 677 RVA: 0x0000D0D4 File Offset: 0x0000B2D4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DirusProductProvider.__c__DisplayClass16_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirusProductProvider.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002A6 RID: 678 RVA: 0x0000D110 File Offset: 0x0000B310
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199869, XrefRangeEnd = 1199875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetProductsForInitialization_b__0(ArchetypeComponent x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirusProductProvider.__c__DisplayClass16_0.NativeMethodInfoPtr__GetProductsForInitialization_b__0_Internal_Boolean_ArchetypeComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060002A7 RID: 679 RVA: 0x0000D160 File Offset: 0x0000B360
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199875, XrefRangeEnd = 1199877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAPProduct _GetProductsForInitialization_b__1(ArchetypeComponent x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirusProductProvider.__c__DisplayClass16_0.NativeMethodInfoPtr__GetProductsForInitialization_b__1_Internal_IAPProduct_ArchetypeComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAPProduct>(intPtr3) : null;
				}
			}

			// Token: 0x060002A8 RID: 680 RVA: 0x0000320F File Offset: 0x0000140F
			public __c__DisplayClass16_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000DE RID: 222
			// (get) Token: 0x060002A9 RID: 681 RVA: 0x0000D1B0 File Offset: 0x0000B3B0
			// (set) Token: 0x060002AA RID: 682 RVA: 0x00003218 File Offset: 0x00001418
			public unsafe string storeName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirusProductProvider.__c__DisplayClass16_0.NativeFieldInfoPtr_storeName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirusProductProvider.__c__DisplayClass16_0.NativeFieldInfoPtr_storeName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170000DF RID: 223
			// (get) Token: 0x060002AB RID: 683 RVA: 0x0000D1D8 File Offset: 0x0000B3D8
			// (set) Token: 0x060002AC RID: 684 RVA: 0x00003237 File Offset: 0x00001437
			public unsafe DirusProductProvider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirusProductProvider.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DirusProductProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirusProductProvider.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000E0 RID: 224
			// (get) Token: 0x060002AD RID: 685 RVA: 0x0000D208 File Offset: 0x0000B408
			// (set) Token: 0x060002AE RID: 686 RVA: 0x00003256 File Offset: 0x00001456
			public unsafe Func<ArchetypeComponent, bool> __9__0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirusProductProvider.__c__DisplayClass16_0.NativeFieldInfoPtr___9__0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ArchetypeComponent, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirusProductProvider.__c__DisplayClass16_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000E1 RID: 225
			// (get) Token: 0x060002AF RID: 687 RVA: 0x0000D238 File Offset: 0x0000B438
			// (set) Token: 0x060002B0 RID: 688 RVA: 0x00003275 File Offset: 0x00001475
			public unsafe Func<ArchetypeComponent, IAPProduct> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirusProductProvider.__c__DisplayClass16_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ArchetypeComponent, IAPProduct>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirusProductProvider.__c__DisplayClass16_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001D1 RID: 465
			private static readonly IntPtr NativeFieldInfoPtr_storeName;

			// Token: 0x040001D2 RID: 466
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040001D3 RID: 467
			private static readonly IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x040001D4 RID: 468
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x040001D5 RID: 469
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040001D6 RID: 470
			private static readonly IntPtr NativeMethodInfoPtr__GetProductsForInitialization_b__0_Internal_Boolean_ArchetypeComponent_0;

			// Token: 0x040001D7 RID: 471
			private static readonly IntPtr NativeMethodInfoPtr__GetProductsForInitialization_b__1_Internal_IAPProduct_ArchetypeComponent_0;
		}

		// Token: 0x02000031 RID: 49
		[ObfuscatedName("dwd.iap.store.DirusProductProvider+<GetProductsForInitialization>d__16")]
		public sealed class _GetProductsForInitialization_d__16 : global::Il2CppSystem.Object
		{
			// Token: 0x060002B1 RID: 689 RVA: 0x0000D268 File Offset: 0x0000B468
			// Note: this type is marked as 'beforefieldinit'.
			static _GetProductsForInitialization_d__16()
			{
				Il2CppClassPointerStore<DirusProductProvider._GetProductsForInitialization_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DirusProductProvider>.NativeClassPtr, "<GetProductsForInitialization>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirusProductProvider._GetProductsForInitialization_d__16>.NativeClassPtr);
				DirusProductProvider._GetProductsForInitialization_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirusProductProvider._GetProductsForInitialization_d__16>.NativeClassPtr, "<>1__state");
				DirusProductProvider._GetProductsForInitialization_d__16.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirusProductProvider._GetProductsForInitialization_d__16>.NativeClassPtr, "<>2__current");
				DirusProductProvider._GetProductsForInitialization_d__16.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirusProductProvider._GetProductsForInitialization_d__16>.NativeClassPtr, "<>l__initialThreadId");
				DirusProductProvider._GetProductsForInitialization_d__16.NativeFieldInfoPtr_storeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirusProductProvider._GetProductsForInitialization_d__16>.NativeClassPtr, "storeName");
				DirusProductProvider._GetProductsForInitialization_d__16.NativeFieldInfoPtr___3__storeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirusProductProvider._GetProductsForInitialization_d__16>.NativeClassPtr, "<>3__storeName");
				DirusProductProvider._GetProductsForInitialization_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirusProductProvider._GetProductsForInitialization_d__16>.NativeClassPtr, "<>4__this");
				DirusProductProvider._GetProductsForInitialization_d__16.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirusProductProvider._GetProductsForInitialization_d__16>.NativeClassPtr, "<>7__wrap1");
				DirusProductProvider._GetProductsForInitialization_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirusProductProvider._GetProductsForInitialization_d__16>.NativeClassPtr, 100663368);
				DirusProductProvider._GetProductsForInitialization_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirusProductProvider._GetProductsForInitialization_d__16>.NativeClassPtr, 100663369);
				DirusProductProvider._GetProductsForInitialization_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirusProductProvider._GetProductsForInitialization_d__16>.NativeClassPtr, 100663370);
				DirusProductProvider._GetProductsForInitialization_d__16.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirusProductProvider._GetProductsForInitialization_d__16>.NativeClassPtr, 100663371);
				DirusProductProvider._GetProductsForInitialization_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_dwd_iap_store_IAPProduct__get_Current_Private_Virtual_Final_New_get_IAPProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirusProductProvider._GetProductsForInitialization_d__16>.NativeClassPtr, 100663372);
				DirusProductProvider._GetProductsForInitialization_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirusProductProvider._GetProductsForInitialization_d__16>.NativeClassPtr, 100663373);
				DirusProductProvider._GetProductsForInitialization_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirusProductProvider._GetProductsForInitialization_d__16>.NativeClassPtr, 100663374);
				DirusProductProvider._GetProductsForInitialization_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_dwd_iap_store_IAPProduct__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IAPProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirusProductProvider._GetProductsForInitialization_d__16>.NativeClassPtr, 100663375);
				DirusProductProvider._GetProductsForInitialization_d__16.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirusProductProvider._GetProductsForInitialization_d__16>.NativeClassPtr, 100663376);
			}

			// Token: 0x060002B2 RID: 690 RVA: 0x0000D3D4 File Offset: 0x0000B5D4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetProductsForInitialization_d__16(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DirusProductProvider._GetProductsForInitialization_d__16>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirusProductProvider._GetProductsForInitialization_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060002B3 RID: 691 RVA: 0x0000D41C File Offset: 0x0000B61C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199877, XrefRangeEnd = 1199882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirusProductProvider._GetProductsForInitialization_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002B4 RID: 692 RVA: 0x0000D450 File Offset: 0x0000B650
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199882, XrefRangeEnd = 1199935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirusProductProvider._GetProductsForInitialization_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060002B5 RID: 693 RVA: 0x0000D48C File Offset: 0x0000B68C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199935, XrefRangeEnd = 1199938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirusProductProvider._GetProductsForInitialization_d__16.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000E9 RID: 233
			// (get) Token: 0x060002B6 RID: 694 RVA: 0x0000D4C0 File Offset: 0x0000B6C0
			public unsafe IAPProduct System.Collections.Generic.IEnumerator<dwd.iap.store.IAPProduct>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirusProductProvider._GetProductsForInitialization_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_dwd_iap_store_IAPProduct__get_Current_Private_Virtual_Final_New_get_IAPProduct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAPProduct>(intPtr3) : null;
				}
			}

			// Token: 0x060002B7 RID: 695 RVA: 0x0000D500 File Offset: 0x0000B700
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199938, XrefRangeEnd = 1199943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirusProductProvider._GetProductsForInitialization_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000EA RID: 234
			// (get) Token: 0x060002B8 RID: 696 RVA: 0x0000D534 File Offset: 0x0000B734
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirusProductProvider._GetProductsForInitialization_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060002B9 RID: 697 RVA: 0x0000D574 File Offset: 0x0000B774
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199943, XrefRangeEnd = 1199952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<IAPProduct> System_Collections_Generic_IEnumerable_dwd_iap_store_IAPProduct__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirusProductProvider._GetProductsForInitialization_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_dwd_iap_store_IAPProduct__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IAPProduct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<IAPProduct>>(intPtr3) : null;
			}

			// Token: 0x060002BA RID: 698 RVA: 0x0000D5B4 File Offset: 0x0000B7B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirusProductProvider._GetProductsForInitialization_d__16.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060002BB RID: 699 RVA: 0x00003294 File Offset: 0x00001494
			public _GetProductsForInitialization_d__16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000E2 RID: 226
			// (get) Token: 0x060002BC RID: 700 RVA: 0x0000D5F4 File Offset: 0x0000B7F4
			// (set) Token: 0x060002BD RID: 701 RVA: 0x0000329D File Offset: 0x0000149D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirusProductProvider._GetProductsForInitialization_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirusProductProvider._GetProductsForInitialization_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000E3 RID: 227
			// (get) Token: 0x060002BE RID: 702 RVA: 0x0000D61C File Offset: 0x0000B81C
			// (set) Token: 0x060002BF RID: 703 RVA: 0x000032B8 File Offset: 0x000014B8
			public unsafe IAPProduct __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirusProductProvider._GetProductsForInitialization_d__16.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAPProduct>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirusProductProvider._GetProductsForInitialization_d__16.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000E4 RID: 228
			// (get) Token: 0x060002C0 RID: 704 RVA: 0x0000D64C File Offset: 0x0000B84C
			// (set) Token: 0x060002C1 RID: 705 RVA: 0x000032D7 File Offset: 0x000014D7
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirusProductProvider._GetProductsForInitialization_d__16.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirusProductProvider._GetProductsForInitialization_d__16.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170000E5 RID: 229
			// (get) Token: 0x060002C2 RID: 706 RVA: 0x0000D674 File Offset: 0x0000B874
			// (set) Token: 0x060002C3 RID: 707 RVA: 0x000032F2 File Offset: 0x000014F2
			public unsafe string storeName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirusProductProvider._GetProductsForInitialization_d__16.NativeFieldInfoPtr_storeName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirusProductProvider._GetProductsForInitialization_d__16.NativeFieldInfoPtr_storeName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170000E6 RID: 230
			// (get) Token: 0x060002C4 RID: 708 RVA: 0x0000D69C File Offset: 0x0000B89C
			// (set) Token: 0x060002C5 RID: 709 RVA: 0x00003311 File Offset: 0x00001511
			public unsafe string __3__storeName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirusProductProvider._GetProductsForInitialization_d__16.NativeFieldInfoPtr___3__storeName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirusProductProvider._GetProductsForInitialization_d__16.NativeFieldInfoPtr___3__storeName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170000E7 RID: 231
			// (get) Token: 0x060002C6 RID: 710 RVA: 0x0000D6C4 File Offset: 0x0000B8C4
			// (set) Token: 0x060002C7 RID: 711 RVA: 0x00003330 File Offset: 0x00001530
			public unsafe DirusProductProvider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirusProductProvider._GetProductsForInitialization_d__16.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DirusProductProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirusProductProvider._GetProductsForInitialization_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000E8 RID: 232
			// (get) Token: 0x060002C8 RID: 712 RVA: 0x0000D6F4 File Offset: 0x0000B8F4
			// (set) Token: 0x060002C9 RID: 713 RVA: 0x0000334F File Offset: 0x0000154F
			public unsafe IEnumerator<IAPProduct> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirusProductProvider._GetProductsForInitialization_d__16.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<IAPProduct>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirusProductProvider._GetProductsForInitialization_d__16.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001D8 RID: 472
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040001D9 RID: 473
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040001DA RID: 474
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040001DB RID: 475
			private static readonly IntPtr NativeFieldInfoPtr_storeName;

			// Token: 0x040001DC RID: 476
			private static readonly IntPtr NativeFieldInfoPtr___3__storeName;

			// Token: 0x040001DD RID: 477
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040001DE RID: 478
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040001DF RID: 479
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040001E0 RID: 480
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001E1 RID: 481
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040001E2 RID: 482
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040001E3 RID: 483
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_dwd_iap_store_IAPProduct__get_Current_Private_Virtual_Final_New_get_IAPProduct_0;

			// Token: 0x040001E4 RID: 484
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001E5 RID: 485
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040001E6 RID: 486
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_dwd_iap_store_IAPProduct__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IAPProduct_0;

			// Token: 0x040001E7 RID: 487
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000032 RID: 50
		[ObfuscatedName("dwd.iap.store.DirusProductProvider+<RetrieveIAPProducts>d__19")]
		public sealed class _RetrieveIAPProducts_d__19 : global::Il2CppSystem.Object
		{
			// Token: 0x060002CA RID: 714 RVA: 0x0000D724 File Offset: 0x0000B924
			// Note: this type is marked as 'beforefieldinit'.
			static _RetrieveIAPProducts_d__19()
			{
				Il2CppClassPointerStore<DirusProductProvider._RetrieveIAPProducts_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DirusProductProvider>.NativeClassPtr, "<RetrieveIAPProducts>d__19");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirusProductProvider._RetrieveIAPProducts_d__19>.NativeClassPtr);
				DirusProductProvider._RetrieveIAPProducts_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirusProductProvider._RetrieveIAPProducts_d__19>.NativeClassPtr, "<>1__state");
				DirusProductProvider._RetrieveIAPProducts_d__19.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirusProductProvider._RetrieveIAPProducts_d__19>.NativeClassPtr, "<>2__current");
				DirusProductProvider._RetrieveIAPProducts_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirusProductProvider._RetrieveIAPProducts_d__19>.NativeClassPtr, "<>4__this");
				DirusProductProvider._RetrieveIAPProducts_d__19.NativeFieldInfoPtr__contentProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirusProductProvider._RetrieveIAPProducts_d__19>.NativeClassPtr, "<contentProvider>5__2");
				DirusProductProvider._RetrieveIAPProducts_d__19.NativeFieldInfoPtr__catalogRequest_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirusProductProvider._RetrieveIAPProducts_d__19>.NativeClassPtr, "<catalogRequest>5__3");
				DirusProductProvider._RetrieveIAPProducts_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirusProductProvider._RetrieveIAPProducts_d__19>.NativeClassPtr, 100663377);
				DirusProductProvider._RetrieveIAPProducts_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirusProductProvider._RetrieveIAPProducts_d__19>.NativeClassPtr, 100663378);
				DirusProductProvider._RetrieveIAPProducts_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirusProductProvider._RetrieveIAPProducts_d__19>.NativeClassPtr, 100663379);
				DirusProductProvider._RetrieveIAPProducts_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirusProductProvider._RetrieveIAPProducts_d__19>.NativeClassPtr, 100663380);
				DirusProductProvider._RetrieveIAPProducts_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirusProductProvider._RetrieveIAPProducts_d__19>.NativeClassPtr, 100663381);
				DirusProductProvider._RetrieveIAPProducts_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirusProductProvider._RetrieveIAPProducts_d__19>.NativeClassPtr, 100663382);
			}

			// Token: 0x060002CB RID: 715 RVA: 0x0000D82C File Offset: 0x0000BA2C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RetrieveIAPProducts_d__19(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DirusProductProvider._RetrieveIAPProducts_d__19>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirusProductProvider._RetrieveIAPProducts_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060002CC RID: 716 RVA: 0x0000D874 File Offset: 0x0000BA74
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirusProductProvider._RetrieveIAPProducts_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002CD RID: 717 RVA: 0x0000D8A8 File Offset: 0x0000BAA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199952, XrefRangeEnd = 1199986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirusProductProvider._RetrieveIAPProducts_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170000F0 RID: 240
			// (get) Token: 0x060002CE RID: 718 RVA: 0x0000D8E4 File Offset: 0x0000BAE4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirusProductProvider._RetrieveIAPProducts_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060002CF RID: 719 RVA: 0x0000D924 File Offset: 0x0000BB24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199986, XrefRangeEnd = 1199991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirusProductProvider._RetrieveIAPProducts_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000F1 RID: 241
			// (get) Token: 0x060002D0 RID: 720 RVA: 0x0000D958 File Offset: 0x0000BB58
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirusProductProvider._RetrieveIAPProducts_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060002D1 RID: 721 RVA: 0x0000336E File Offset: 0x0000156E
			public _RetrieveIAPProducts_d__19(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000EB RID: 235
			// (get) Token: 0x060002D2 RID: 722 RVA: 0x0000D998 File Offset: 0x0000BB98
			// (set) Token: 0x060002D3 RID: 723 RVA: 0x00003377 File Offset: 0x00001577
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirusProductProvider._RetrieveIAPProducts_d__19.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirusProductProvider._RetrieveIAPProducts_d__19.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000EC RID: 236
			// (get) Token: 0x060002D4 RID: 724 RVA: 0x0000D9C0 File Offset: 0x0000BBC0
			// (set) Token: 0x060002D5 RID: 725 RVA: 0x00003392 File Offset: 0x00001592
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirusProductProvider._RetrieveIAPProducts_d__19.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirusProductProvider._RetrieveIAPProducts_d__19.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000ED RID: 237
			// (get) Token: 0x060002D6 RID: 726 RVA: 0x0000D9F0 File Offset: 0x0000BBF0
			// (set) Token: 0x060002D7 RID: 727 RVA: 0x000033B1 File Offset: 0x000015B1
			public unsafe DirusProductProvider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirusProductProvider._RetrieveIAPProducts_d__19.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DirusProductProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirusProductProvider._RetrieveIAPProducts_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000EE RID: 238
			// (get) Token: 0x060002D8 RID: 728 RVA: 0x0000DA20 File Offset: 0x0000BC20
			// (set) Token: 0x060002D9 RID: 729 RVA: 0x000033D0 File Offset: 0x000015D0
			public unsafe BroadcastContentProvider _contentProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirusProductProvider._RetrieveIAPProducts_d__19.NativeFieldInfoPtr__contentProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BroadcastContentProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirusProductProvider._RetrieveIAPProducts_d__19.NativeFieldInfoPtr__contentProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000EF RID: 239
			// (get) Token: 0x060002DA RID: 730 RVA: 0x0000DA50 File Offset: 0x0000BC50
			// (set) Token: 0x060002DB RID: 731 RVA: 0x000033EF File Offset: 0x000015EF
			public unsafe DwdWebRequestCommand _catalogRequest_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirusProductProvider._RetrieveIAPProducts_d__19.NativeFieldInfoPtr__catalogRequest_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DwdWebRequestCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirusProductProvider._RetrieveIAPProducts_d__19.NativeFieldInfoPtr__catalogRequest_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001E8 RID: 488
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040001E9 RID: 489
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040001EA RID: 490
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040001EB RID: 491
			private static readonly IntPtr NativeFieldInfoPtr__contentProvider_5__2;

			// Token: 0x040001EC RID: 492
			private static readonly IntPtr NativeFieldInfoPtr__catalogRequest_5__3;

			// Token: 0x040001ED RID: 493
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040001EE RID: 494
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001EF RID: 495
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040001F0 RID: 496
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040001F1 RID: 497
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001F2 RID: 498
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
