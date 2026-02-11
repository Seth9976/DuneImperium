using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.IO
{
	// Token: 0x02000534 RID: 1332
	[Serializable]
	public sealed class DirectoryInfo : FileSystemInfo
	{
		// Token: 0x0600519B RID: 20891 RVA: 0x0017BEC4 File Offset: 0x0017A0C4
		// Note: this type is marked as 'beforefieldinit'.
		static DirectoryInfo()
		{
			Il2CppClassPointerStore<DirectoryInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "DirectoryInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirectoryInfo>.NativeClassPtr);
			DirectoryInfo.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectoryInfo>.NativeClassPtr, 100675721);
			DirectoryInfo.NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectoryInfo>.NativeClassPtr, 100675722);
			DirectoryInfo.NativeMethodInfoPtr_Init_Private_Void_String_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectoryInfo>.NativeClassPtr, 100675723);
			DirectoryInfo.NativeMethodInfoPtr_get_Parent_Public_get_DirectoryInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectoryInfo>.NativeClassPtr, 100675724);
			DirectoryInfo.NativeMethodInfoPtr_Create_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectoryInfo>.NativeClassPtr, 100675725);
			DirectoryInfo.NativeMethodInfoPtr_EnumerateFiles_Public_IEnumerable_1_FileInfo_String_SearchOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectoryInfo>.NativeClassPtr, 100675726);
			DirectoryInfo.NativeMethodInfoPtr_EnumerateFiles_Public_IEnumerable_1_FileInfo_String_EnumerationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectoryInfo>.NativeClassPtr, 100675727);
			DirectoryInfo.NativeMethodInfoPtr_InternalEnumerateInfos_Internal_Static_IEnumerable_1_FileSystemInfo_String_String_SearchTarget_EnumerationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectoryInfo>.NativeClassPtr, 100675728);
			DirectoryInfo.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectoryInfo>.NativeClassPtr, 100675729);
		}

		// Token: 0x0600519C RID: 20892 RVA: 0x0017BFA8 File Offset: 0x0017A1A8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1430344, RefRangeEnd = 1430348, XrefRangeStart = 1430338, XrefRangeEnd = 1430344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DirectoryInfo(string path)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DirectoryInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirectoryInfo.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600519D RID: 20893 RVA: 0x0017BFF4 File Offset: 0x0017A1F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1430379, RefRangeEnd = 1430381, XrefRangeStart = 1430348, XrefRangeEnd = 1430379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DirectoryInfo(string originalPath, string fullPath = null, string fileName = null, bool isNormalized = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DirectoryInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(originalPath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fullPath);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fileName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNormalized;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirectoryInfo.NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600519E RID: 20894 RVA: 0x0017C074 File Offset: 0x0017A274
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1430411, RefRangeEnd = 1430413, XrefRangeStart = 1430381, XrefRangeEnd = 1430411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(string originalPath, string fullPath = null, string fileName = null, bool isNormalized = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(originalPath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fullPath);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fileName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNormalized;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirectoryInfo.NativeMethodInfoPtr_Init_Private_Void_String_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170014BF RID: 5311
		// (get) Token: 0x0600519F RID: 20895 RVA: 0x0017C0E8 File Offset: 0x0017A2E8
		public unsafe DirectoryInfo Parent
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1430431, RefRangeEnd = 1430433, XrefRangeStart = 1430413, XrefRangeEnd = 1430431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirectoryInfo.NativeMethodInfoPtr_get_Parent_Public_get_DirectoryInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DirectoryInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060051A0 RID: 20896 RVA: 0x0017C128 File Offset: 0x0017A328
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1430434, RefRangeEnd = 1430435, XrefRangeStart = 1430433, XrefRangeEnd = 1430434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Create()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirectoryInfo.NativeMethodInfoPtr_Create_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060051A1 RID: 20897 RVA: 0x0017C15C File Offset: 0x0017A35C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1430448, RefRangeEnd = 1430449, XrefRangeStart = 1430435, XrefRangeEnd = 1430448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<FileInfo> EnumerateFiles(string searchPattern, SearchOption searchOption)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(searchPattern);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchOption;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirectoryInfo.NativeMethodInfoPtr_EnumerateFiles_Public_IEnumerable_1_FileInfo_String_SearchOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<FileInfo>>(intPtr3) : null;
		}

		// Token: 0x060051A2 RID: 20898 RVA: 0x0017C1BC File Offset: 0x0017A3BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1430449, XrefRangeEnd = 1430458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<FileInfo> EnumerateFiles(string searchPattern, EnumerationOptions enumerationOptions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(searchPattern);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enumerationOptions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirectoryInfo.NativeMethodInfoPtr_EnumerateFiles_Public_IEnumerable_1_FileInfo_String_EnumerationOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<FileInfo>>(intPtr3) : null;
		}

		// Token: 0x060051A3 RID: 20899 RVA: 0x0017C220 File Offset: 0x0017A420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1430458, XrefRangeEnd = 1430465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<FileSystemInfo> InternalEnumerateInfos(string path, string searchPattern, SearchTarget searchTarget, EnumerationOptions options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(searchPattern);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchTarget;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirectoryInfo.NativeMethodInfoPtr_InternalEnumerateInfos_Internal_Static_IEnumerable_1_FileSystemInfo_String_String_SearchTarget_EnumerationOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<FileSystemInfo>>(intPtr3) : null;
		}

		// Token: 0x060051A4 RID: 20900 RVA: 0x0017C298 File Offset: 0x0017A498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1430465, XrefRangeEnd = 1430466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DirectoryInfo(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DirectoryInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirectoryInfo.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060051A5 RID: 20901 RVA: 0x0001D158 File Offset: 0x0001B358
		public DirectoryInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400428F RID: 17039
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04004290 RID: 17040
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_Boolean_0;

		// Token: 0x04004291 RID: 17041
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_String_String_String_Boolean_0;

		// Token: 0x04004292 RID: 17042
		private static readonly IntPtr NativeMethodInfoPtr_get_Parent_Public_get_DirectoryInfo_0;

		// Token: 0x04004293 RID: 17043
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Void_0;

		// Token: 0x04004294 RID: 17044
		private static readonly IntPtr NativeMethodInfoPtr_EnumerateFiles_Public_IEnumerable_1_FileInfo_String_SearchOption_0;

		// Token: 0x04004295 RID: 17045
		private static readonly IntPtr NativeMethodInfoPtr_EnumerateFiles_Public_IEnumerable_1_FileInfo_String_EnumerationOptions_0;

		// Token: 0x04004296 RID: 17046
		private static readonly IntPtr NativeMethodInfoPtr_InternalEnumerateInfos_Internal_Static_IEnumerable_1_FileSystemInfo_String_String_SearchTarget_EnumerationOptions_0;

		// Token: 0x04004297 RID: 17047
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;
	}
}
