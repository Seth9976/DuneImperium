using System;
using Google.Apis.Discovery;
using Google.Apis.Services;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Sheets.v4
{
	// Token: 0x02000002 RID: 2
	public class SheetsService : BaseClientService
	{
		// Token: 0x06000001 RID: 1 RVA: 0x0000B04C File Offset: 0x0000924C
		// Note: this type is marked as 'beforefieldinit'.
		static SheetsService()
		{
			Il2CppClassPointerStore<SheetsService>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4", "SheetsService");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SheetsService>.NativeClassPtr);
			SheetsService.NativeFieldInfoPtr_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SheetsService>.NativeClassPtr, "Version");
			SheetsService.NativeFieldInfoPtr_DiscoveryVersionUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SheetsService>.NativeClassPtr, "DiscoveryVersionUsed");
			SheetsService.NativeFieldInfoPtr_spreadsheets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SheetsService>.NativeClassPtr, "spreadsheets");
			SheetsService.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetsService>.NativeClassPtr, 100663297);
			SheetsService.NativeMethodInfoPtr__ctor_Public_Void_Initializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetsService>.NativeClassPtr, 100663298);
			SheetsService.NativeMethodInfoPtr_get_Features_Public_Virtual_get_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetsService>.NativeClassPtr, 100663299);
			SheetsService.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetsService>.NativeClassPtr, 100663300);
			SheetsService.NativeMethodInfoPtr_get_BaseUri_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetsService>.NativeClassPtr, 100663301);
			SheetsService.NativeMethodInfoPtr_get_BasePath_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetsService>.NativeClassPtr, 100663302);
			SheetsService.NativeMethodInfoPtr_get_BatchUri_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetsService>.NativeClassPtr, 100663303);
			SheetsService.NativeMethodInfoPtr_get_BatchPath_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetsService>.NativeClassPtr, 100663304);
			SheetsService.NativeMethodInfoPtr_get_Spreadsheets_Public_Virtual_New_get_SpreadsheetsResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetsService>.NativeClassPtr, 100663305);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000B16C File Offset: 0x0000936C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117661, XrefRangeEnd = 1117693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SheetsService()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SheetsService>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SheetsService.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000B1A8 File Offset: 0x000093A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1117721, RefRangeEnd = 1117722, XrefRangeStart = 1117693, XrefRangeEnd = 1117721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SheetsService(BaseClientService.Initializer initializer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SheetsService>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(initializer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SheetsService.NativeMethodInfoPtr__ctor_Public_Void_Initializer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000004 RID: 4 RVA: 0x0000B1F4 File Offset: 0x000093F4
		public unsafe override IList<string> Features
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117722, XrefRangeEnd = 1117725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SheetsService.NativeMethodInfoPtr_get_Features_Public_Virtual_get_IList_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<string>>(intPtr3) : null;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000005 RID: 5 RVA: 0x0000B240 File Offset: 0x00009440
		public unsafe override string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117725, XrefRangeEnd = 1117727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SheetsService.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000006 RID: 6 RVA: 0x0000B284 File Offset: 0x00009484
		public unsafe override string BaseUri
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117727, XrefRangeEnd = 1117729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SheetsService.NativeMethodInfoPtr_get_BaseUri_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000007 RID: 7 RVA: 0x0000B2C8 File Offset: 0x000094C8
		public unsafe override string BasePath
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117729, XrefRangeEnd = 1117731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SheetsService.NativeMethodInfoPtr_get_BasePath_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000008 RID: 8 RVA: 0x0000B30C File Offset: 0x0000950C
		public unsafe override string BatchUri
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117731, XrefRangeEnd = 1117733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SheetsService.NativeMethodInfoPtr_get_BatchUri_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000009 RID: 9 RVA: 0x0000B350 File Offset: 0x00009550
		public unsafe override string BatchPath
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117733, XrefRangeEnd = 1117735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SheetsService.NativeMethodInfoPtr_get_BatchPath_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600000A RID: 10 RVA: 0x0000B394 File Offset: 0x00009594
		public unsafe virtual SpreadsheetsResource Spreadsheets
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SheetsService.NativeMethodInfoPtr_get_Spreadsheets_Public_Virtual_New_get_SpreadsheetsResource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpreadsheetsResource>(intPtr3) : null;
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
		public SheetsService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000C RID: 12 RVA: 0x0000B3E0 File Offset: 0x000095E0
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00002059 File Offset: 0x00000259
		public unsafe static string Version
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SheetsService.NativeFieldInfoPtr_Version, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SheetsService.NativeFieldInfoPtr_Version, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000E RID: 14 RVA: 0x0000B400 File Offset: 0x00009600
		// (set) Token: 0x0600000F RID: 15 RVA: 0x0000206B File Offset: 0x0000026B
		public unsafe static DiscoveryVersion DiscoveryVersionUsed
		{
			get
			{
				DiscoveryVersion discoveryVersion;
				IL2CPP.il2cpp_field_static_get_value(SheetsService.NativeFieldInfoPtr_DiscoveryVersionUsed, (void*)(&discoveryVersion));
				return discoveryVersion;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SheetsService.NativeFieldInfoPtr_DiscoveryVersionUsed, (void*)(&value));
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000010 RID: 16 RVA: 0x0000B41C File Offset: 0x0000961C
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002079 File Offset: 0x00000279
		public unsafe SpreadsheetsResource spreadsheets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetsService.NativeFieldInfoPtr_spreadsheets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpreadsheetsResource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetsService.NativeFieldInfoPtr_spreadsheets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeFieldInfoPtr_Version;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeFieldInfoPtr_DiscoveryVersionUsed;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeFieldInfoPtr_spreadsheets;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Initializer_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_get_Features_Public_Virtual_get_IList_1_String_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseUri_Public_Virtual_get_String_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_get_BasePath_Public_Virtual_get_String_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_get_BatchUri_Public_Virtual_get_String_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_get_BatchPath_Public_Virtual_get_String_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_get_Spreadsheets_Public_Virtual_New_get_SpreadsheetsResource_0;

		// Token: 0x020000D0 RID: 208
		public class Scope : Object
		{
			// Token: 0x0600118B RID: 4491 RVA: 0x0004E574 File Offset: 0x0004C774
			// Note: this type is marked as 'beforefieldinit'.
			static Scope()
			{
				Il2CppClassPointerStore<SheetsService.Scope>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SheetsService>.NativeClassPtr, "Scope");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SheetsService.Scope>.NativeClassPtr);
				SheetsService.Scope.NativeFieldInfoPtr_Drive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SheetsService.Scope>.NativeClassPtr, "Drive");
				SheetsService.Scope.NativeFieldInfoPtr_DriveFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SheetsService.Scope>.NativeClassPtr, "DriveFile");
				SheetsService.Scope.NativeFieldInfoPtr_DriveReadonly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SheetsService.Scope>.NativeClassPtr, "DriveReadonly");
				SheetsService.Scope.NativeFieldInfoPtr_Spreadsheets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SheetsService.Scope>.NativeClassPtr, "Spreadsheets");
				SheetsService.Scope.NativeFieldInfoPtr_SpreadsheetsReadonly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SheetsService.Scope>.NativeClassPtr, "SpreadsheetsReadonly");
				SheetsService.Scope.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetsService.Scope>.NativeClassPtr, 100663307);
			}

			// Token: 0x0600118C RID: 4492 RVA: 0x0004E618 File Offset: 0x0004C818
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Scope()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SheetsService.Scope>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SheetsService.Scope.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600118D RID: 4493 RVA: 0x0000A6EB File Offset: 0x000088EB
			public Scope(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000793 RID: 1939
			// (get) Token: 0x0600118E RID: 4494 RVA: 0x0004E654 File Offset: 0x0004C854
			// (set) Token: 0x0600118F RID: 4495 RVA: 0x0000A6F4 File Offset: 0x000088F4
			public unsafe static string Drive
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SheetsService.Scope.NativeFieldInfoPtr_Drive, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SheetsService.Scope.NativeFieldInfoPtr_Drive, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000794 RID: 1940
			// (get) Token: 0x06001190 RID: 4496 RVA: 0x0004E674 File Offset: 0x0004C874
			// (set) Token: 0x06001191 RID: 4497 RVA: 0x0000A706 File Offset: 0x00008906
			public unsafe static string DriveFile
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SheetsService.Scope.NativeFieldInfoPtr_DriveFile, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SheetsService.Scope.NativeFieldInfoPtr_DriveFile, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000795 RID: 1941
			// (get) Token: 0x06001192 RID: 4498 RVA: 0x0004E694 File Offset: 0x0004C894
			// (set) Token: 0x06001193 RID: 4499 RVA: 0x0000A718 File Offset: 0x00008918
			public unsafe static string DriveReadonly
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SheetsService.Scope.NativeFieldInfoPtr_DriveReadonly, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SheetsService.Scope.NativeFieldInfoPtr_DriveReadonly, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000796 RID: 1942
			// (get) Token: 0x06001194 RID: 4500 RVA: 0x0004E6B4 File Offset: 0x0004C8B4
			// (set) Token: 0x06001195 RID: 4501 RVA: 0x0000A72A File Offset: 0x0000892A
			public unsafe static string Spreadsheets
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SheetsService.Scope.NativeFieldInfoPtr_Spreadsheets, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SheetsService.Scope.NativeFieldInfoPtr_Spreadsheets, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000797 RID: 1943
			// (get) Token: 0x06001196 RID: 4502 RVA: 0x0004E6D4 File Offset: 0x0004C8D4
			// (set) Token: 0x06001197 RID: 4503 RVA: 0x0000A73C File Offset: 0x0000893C
			public unsafe static string SpreadsheetsReadonly
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SheetsService.Scope.NativeFieldInfoPtr_SpreadsheetsReadonly, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SheetsService.Scope.NativeFieldInfoPtr_SpreadsheetsReadonly, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04000C27 RID: 3111
			private static readonly IntPtr NativeFieldInfoPtr_Drive;

			// Token: 0x04000C28 RID: 3112
			private static readonly IntPtr NativeFieldInfoPtr_DriveFile;

			// Token: 0x04000C29 RID: 3113
			private static readonly IntPtr NativeFieldInfoPtr_DriveReadonly;

			// Token: 0x04000C2A RID: 3114
			private static readonly IntPtr NativeFieldInfoPtr_Spreadsheets;

			// Token: 0x04000C2B RID: 3115
			private static readonly IntPtr NativeFieldInfoPtr_SpreadsheetsReadonly;

			// Token: 0x04000C2C RID: 3116
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020000D1 RID: 209
		public static class ScopeConstants : Object
		{
			// Token: 0x06001198 RID: 4504 RVA: 0x0004E6F4 File Offset: 0x0004C8F4
			// Note: this type is marked as 'beforefieldinit'.
			static ScopeConstants()
			{
				Il2CppClassPointerStore<SheetsService.ScopeConstants>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SheetsService>.NativeClassPtr, "ScopeConstants");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SheetsService.ScopeConstants>.NativeClassPtr);
				SheetsService.ScopeConstants.NativeFieldInfoPtr_Drive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SheetsService.ScopeConstants>.NativeClassPtr, "Drive");
				SheetsService.ScopeConstants.NativeFieldInfoPtr_DriveFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SheetsService.ScopeConstants>.NativeClassPtr, "DriveFile");
				SheetsService.ScopeConstants.NativeFieldInfoPtr_DriveReadonly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SheetsService.ScopeConstants>.NativeClassPtr, "DriveReadonly");
				SheetsService.ScopeConstants.NativeFieldInfoPtr_Spreadsheets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SheetsService.ScopeConstants>.NativeClassPtr, "Spreadsheets");
				SheetsService.ScopeConstants.NativeFieldInfoPtr_SpreadsheetsReadonly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SheetsService.ScopeConstants>.NativeClassPtr, "SpreadsheetsReadonly");
			}

			// Token: 0x06001199 RID: 4505 RVA: 0x0000A74E File Offset: 0x0000894E
			public ScopeConstants(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000798 RID: 1944
			// (get) Token: 0x0600119A RID: 4506 RVA: 0x0004E784 File Offset: 0x0004C984
			// (set) Token: 0x0600119B RID: 4507 RVA: 0x0000A757 File Offset: 0x00008957
			public unsafe static string Drive
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SheetsService.ScopeConstants.NativeFieldInfoPtr_Drive, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SheetsService.ScopeConstants.NativeFieldInfoPtr_Drive, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000799 RID: 1945
			// (get) Token: 0x0600119C RID: 4508 RVA: 0x0004E7A4 File Offset: 0x0004C9A4
			// (set) Token: 0x0600119D RID: 4509 RVA: 0x0000A769 File Offset: 0x00008969
			public unsafe static string DriveFile
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SheetsService.ScopeConstants.NativeFieldInfoPtr_DriveFile, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SheetsService.ScopeConstants.NativeFieldInfoPtr_DriveFile, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700079A RID: 1946
			// (get) Token: 0x0600119E RID: 4510 RVA: 0x0004E7C4 File Offset: 0x0004C9C4
			// (set) Token: 0x0600119F RID: 4511 RVA: 0x0000A77B File Offset: 0x0000897B
			public unsafe static string DriveReadonly
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SheetsService.ScopeConstants.NativeFieldInfoPtr_DriveReadonly, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SheetsService.ScopeConstants.NativeFieldInfoPtr_DriveReadonly, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700079B RID: 1947
			// (get) Token: 0x060011A0 RID: 4512 RVA: 0x0004E7E4 File Offset: 0x0004C9E4
			// (set) Token: 0x060011A1 RID: 4513 RVA: 0x0000A78D File Offset: 0x0000898D
			public unsafe static string Spreadsheets
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SheetsService.ScopeConstants.NativeFieldInfoPtr_Spreadsheets, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SheetsService.ScopeConstants.NativeFieldInfoPtr_Spreadsheets, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700079C RID: 1948
			// (get) Token: 0x060011A2 RID: 4514 RVA: 0x0004E804 File Offset: 0x0004CA04
			// (set) Token: 0x060011A3 RID: 4515 RVA: 0x0000A79F File Offset: 0x0000899F
			public unsafe static string SpreadsheetsReadonly
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SheetsService.ScopeConstants.NativeFieldInfoPtr_SpreadsheetsReadonly, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SheetsService.ScopeConstants.NativeFieldInfoPtr_SpreadsheetsReadonly, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04000C2D RID: 3117
			private static readonly IntPtr NativeFieldInfoPtr_Drive;

			// Token: 0x04000C2E RID: 3118
			private static readonly IntPtr NativeFieldInfoPtr_DriveFile;

			// Token: 0x04000C2F RID: 3119
			private static readonly IntPtr NativeFieldInfoPtr_DriveReadonly;

			// Token: 0x04000C30 RID: 3120
			private static readonly IntPtr NativeFieldInfoPtr_Spreadsheets;

			// Token: 0x04000C31 RID: 3121
			private static readonly IntPtr NativeFieldInfoPtr_SpreadsheetsReadonly;
		}
	}
}
