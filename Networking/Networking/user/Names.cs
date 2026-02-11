using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Networking.user
{
	// Token: 0x0200004B RID: 75
	public static class Names : Object
	{
		// Token: 0x06000276 RID: 630 RVA: 0x0000C2C0 File Offset: 0x0000A4C0
		// Note: this type is marked as 'beforefieldinit'.
		static Names()
		{
			Il2CppClassPointerStore<Names>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.user", "Names");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Names>.NativeClassPtr);
			Names.NativeFieldInfoPtr_FederationGdk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Names>.NativeClassPtr, "FederationGdk");
			Names.NativeFieldInfoPtr_FederationDwd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Names>.NativeClassPtr, "FederationDwd");
			Names.NativeMethodInfoPtr_GetShortName_Public_Static_String_FederatedNameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Names>.NativeClassPtr, 100663419);
			Names.NativeMethodInfoPtr_GetShortName_Public_Static_String_FederatedNameData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Names>.NativeClassPtr, 100663420);
			Names.NativeMethodInfoPtr_GetNameID_Public_Static_String_FederatedNameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Names>.NativeClassPtr, 100663421);
			Names.NativeMethodInfoPtr_GetNameID_Public_Static_String_FederatedNameData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Names>.NativeClassPtr, 100663422);
			Names.NativeMethodInfoPtr_GetNameFull_Public_Static_String_FederatedNameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Names>.NativeClassPtr, 100663423);
			Names.NativeMethodInfoPtr_GetNameFull_Public_Static_String_FederatedNameData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Names>.NativeClassPtr, 100663424);
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0000C390 File Offset: 0x0000A590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193739, XrefRangeEnd = 1193756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetShortName(this FederatedNameData data)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Names.NativeMethodInfoPtr_GetShortName_Public_Static_String_FederatedNameData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000C3CC File Offset: 0x0000A5CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1193765, RefRangeEnd = 1193766, XrefRangeStart = 1193756, XrefRangeEnd = 1193765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetShortName(this FederatedNameData data, string federation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(federation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Names.NativeMethodInfoPtr_GetShortName_Public_Static_String_FederatedNameData_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0000C41C File Offset: 0x0000A61C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193766, XrefRangeEnd = 1193783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetNameID(this FederatedNameData data)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Names.NativeMethodInfoPtr_GetNameID_Public_Static_String_FederatedNameData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0000C458 File Offset: 0x0000A658
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1193792, RefRangeEnd = 1193793, XrefRangeStart = 1193783, XrefRangeEnd = 1193792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetNameID(this FederatedNameData data, string federation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(federation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Names.NativeMethodInfoPtr_GetNameID_Public_Static_String_FederatedNameData_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0000C4A8 File Offset: 0x0000A6A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193793, XrefRangeEnd = 1193802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetNameFull(this FederatedNameData data)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Names.NativeMethodInfoPtr_GetNameFull_Public_Static_String_FederatedNameData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0000C4E4 File Offset: 0x0000A6E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1193831, RefRangeEnd = 1193832, XrefRangeStart = 1193802, XrefRangeEnd = 1193831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetNameFull(this FederatedNameData data, string federation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(federation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Names.NativeMethodInfoPtr_GetNameFull_Public_Static_String_FederatedNameData_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00003A19 File Offset: 0x00001C19
		public Names(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600027E RID: 638 RVA: 0x0000C534 File Offset: 0x0000A734
		// (set) Token: 0x0600027F RID: 639 RVA: 0x00003A22 File Offset: 0x00001C22
		public unsafe static string FederationGdk
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Names.NativeFieldInfoPtr_FederationGdk, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Names.NativeFieldInfoPtr_FederationGdk, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000280 RID: 640 RVA: 0x0000C554 File Offset: 0x0000A754
		// (set) Token: 0x06000281 RID: 641 RVA: 0x00003A34 File Offset: 0x00001C34
		public unsafe static string FederationDwd
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Names.NativeFieldInfoPtr_FederationDwd, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Names.NativeFieldInfoPtr_FederationDwd, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeFieldInfoPtr_FederationGdk;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeFieldInfoPtr_FederationDwd;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeMethodInfoPtr_GetShortName_Public_Static_String_FederatedNameData_0;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeMethodInfoPtr_GetShortName_Public_Static_String_FederatedNameData_String_0;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeMethodInfoPtr_GetNameID_Public_Static_String_FederatedNameData_0;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeMethodInfoPtr_GetNameID_Public_Static_String_FederatedNameData_String_0;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeMethodInfoPtr_GetNameFull_Public_Static_String_FederatedNameData_0;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeMethodInfoPtr_GetNameFull_Public_Static_String_FederatedNameData_String_0;
	}
}
