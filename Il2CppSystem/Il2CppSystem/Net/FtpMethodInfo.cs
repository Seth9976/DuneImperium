using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020001A0 RID: 416
	public class FtpMethodInfo : Object
	{
		// Token: 0x060019B9 RID: 6585 RVA: 0x00081514 File Offset: 0x0007F714
		// Note: this type is marked as 'beforefieldinit'.
		static FtpMethodInfo()
		{
			Il2CppClassPointerStore<FtpMethodInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "FtpMethodInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FtpMethodInfo>.NativeClassPtr);
			FtpMethodInfo.NativeFieldInfoPtr_Method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpMethodInfo>.NativeClassPtr, "Method");
			FtpMethodInfo.NativeFieldInfoPtr_Operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpMethodInfo>.NativeClassPtr, "Operation");
			FtpMethodInfo.NativeFieldInfoPtr_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpMethodInfo>.NativeClassPtr, "Flags");
			FtpMethodInfo.NativeFieldInfoPtr_HttpCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpMethodInfo>.NativeClassPtr, "HttpCommand");
			FtpMethodInfo.NativeFieldInfoPtr_s_knownMethodInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpMethodInfo>.NativeClassPtr, "s_knownMethodInfo");
			FtpMethodInfo.NativeMethodInfoPtr__ctor_Internal_Void_String_FtpOperation_FtpMethodFlags_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpMethodInfo>.NativeClassPtr, 100667329);
			FtpMethodInfo.NativeMethodInfoPtr_HasFlag_Internal_Boolean_FtpMethodFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpMethodInfo>.NativeClassPtr, 100667330);
			FtpMethodInfo.NativeMethodInfoPtr_get_IsCommandOnly_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpMethodInfo>.NativeClassPtr, 100667331);
			FtpMethodInfo.NativeMethodInfoPtr_get_IsUpload_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpMethodInfo>.NativeClassPtr, 100667332);
			FtpMethodInfo.NativeMethodInfoPtr_get_IsDownload_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpMethodInfo>.NativeClassPtr, 100667333);
			FtpMethodInfo.NativeMethodInfoPtr_get_ShouldParseForResponseUri_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpMethodInfo>.NativeClassPtr, 100667334);
			FtpMethodInfo.NativeMethodInfoPtr_GetMethodInfo_Internal_Static_FtpMethodInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpMethodInfo>.NativeClassPtr, 100667335);
		}

		// Token: 0x060019BA RID: 6586 RVA: 0x00081634 File Offset: 0x0007F834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472913, XrefRangeEnd = 472916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FtpMethodInfo(string method, FtpOperation operation, FtpMethodFlags flags, string httpCommand)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FtpMethodInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(method);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref operation;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(httpCommand);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpMethodInfo.NativeMethodInfoPtr__ctor_Internal_Void_String_FtpOperation_FtpMethodFlags_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019BB RID: 6587 RVA: 0x000816B0 File Offset: 0x0007F8B0
		[CallerCount(0)]
		public unsafe bool HasFlag(FtpMethodFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpMethodInfo.NativeMethodInfoPtr_HasFlag_Internal_Boolean_FtpMethodFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x060019BC RID: 6588 RVA: 0x000816FC File Offset: 0x0007F8FC
		public unsafe bool IsCommandOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpMethodInfo.NativeMethodInfoPtr_get_IsCommandOnly_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x060019BD RID: 6589 RVA: 0x00081738 File Offset: 0x0007F938
		public unsafe bool IsUpload
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpMethodInfo.NativeMethodInfoPtr_get_IsUpload_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x060019BE RID: 6590 RVA: 0x00081774 File Offset: 0x0007F974
		public unsafe bool IsDownload
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 364117, RefRangeEnd = 364125, XrefRangeStart = 364117, XrefRangeEnd = 364125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpMethodInfo.NativeMethodInfoPtr_get_IsDownload_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x060019BF RID: 6591 RVA: 0x000817B0 File Offset: 0x0007F9B0
		public unsafe bool ShouldParseForResponseUri
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpMethodInfo.NativeMethodInfoPtr_get_ShouldParseForResponseUri_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019C0 RID: 6592 RVA: 0x000817EC File Offset: 0x0007F9EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 472927, RefRangeEnd = 472929, XrefRangeStart = 472916, XrefRangeEnd = 472927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FtpMethodInfo GetMethodInfo(string method)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(method);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpMethodInfo.NativeMethodInfoPtr_GetMethodInfo_Internal_Static_FtpMethodInfo_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FtpMethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060019C1 RID: 6593 RVA: 0x0000B008 File Offset: 0x00009208
		public FtpMethodInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x060019C2 RID: 6594 RVA: 0x00081830 File Offset: 0x0007FA30
		// (set) Token: 0x060019C3 RID: 6595 RVA: 0x0000B011 File Offset: 0x00009211
		public unsafe string Method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpMethodInfo.NativeFieldInfoPtr_Method);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpMethodInfo.NativeFieldInfoPtr_Method), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x060019C4 RID: 6596 RVA: 0x00081858 File Offset: 0x0007FA58
		// (set) Token: 0x060019C5 RID: 6597 RVA: 0x0000B030 File Offset: 0x00009230
		public unsafe FtpOperation Operation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpMethodInfo.NativeFieldInfoPtr_Operation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpMethodInfo.NativeFieldInfoPtr_Operation)) = value;
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x060019C6 RID: 6598 RVA: 0x00081880 File Offset: 0x0007FA80
		// (set) Token: 0x060019C7 RID: 6599 RVA: 0x0000B04B File Offset: 0x0000924B
		public unsafe FtpMethodFlags Flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpMethodInfo.NativeFieldInfoPtr_Flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpMethodInfo.NativeFieldInfoPtr_Flags)) = value;
			}
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x060019C8 RID: 6600 RVA: 0x000818A8 File Offset: 0x0007FAA8
		// (set) Token: 0x060019C9 RID: 6601 RVA: 0x0000B066 File Offset: 0x00009266
		public unsafe string HttpCommand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpMethodInfo.NativeFieldInfoPtr_HttpCommand);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpMethodInfo.NativeFieldInfoPtr_HttpCommand), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x060019CA RID: 6602 RVA: 0x000818D0 File Offset: 0x0007FAD0
		// (set) Token: 0x060019CB RID: 6603 RVA: 0x0000B085 File Offset: 0x00009285
		public unsafe static Il2CppReferenceArray<FtpMethodInfo> s_knownMethodInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FtpMethodInfo.NativeFieldInfoPtr_s_knownMethodInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FtpMethodInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FtpMethodInfo.NativeFieldInfoPtr_s_knownMethodInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400144D RID: 5197
		private static readonly IntPtr NativeFieldInfoPtr_Method;

		// Token: 0x0400144E RID: 5198
		private static readonly IntPtr NativeFieldInfoPtr_Operation;

		// Token: 0x0400144F RID: 5199
		private static readonly IntPtr NativeFieldInfoPtr_Flags;

		// Token: 0x04001450 RID: 5200
		private static readonly IntPtr NativeFieldInfoPtr_HttpCommand;

		// Token: 0x04001451 RID: 5201
		private static readonly IntPtr NativeFieldInfoPtr_s_knownMethodInfo;

		// Token: 0x04001452 RID: 5202
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_FtpOperation_FtpMethodFlags_String_0;

		// Token: 0x04001453 RID: 5203
		private static readonly IntPtr NativeMethodInfoPtr_HasFlag_Internal_Boolean_FtpMethodFlags_0;

		// Token: 0x04001454 RID: 5204
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCommandOnly_Internal_get_Boolean_0;

		// Token: 0x04001455 RID: 5205
		private static readonly IntPtr NativeMethodInfoPtr_get_IsUpload_Internal_get_Boolean_0;

		// Token: 0x04001456 RID: 5206
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDownload_Internal_get_Boolean_0;

		// Token: 0x04001457 RID: 5207
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldParseForResponseUri_Internal_get_Boolean_0;

		// Token: 0x04001458 RID: 5208
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodInfo_Internal_Static_FtpMethodInfo_String_0;
	}
}
