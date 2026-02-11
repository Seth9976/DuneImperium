using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.IO
{
	// Token: 0x02000537 RID: 1335
	[Serializable]
	public sealed class FileInfo : FileSystemInfo
	{
		// Token: 0x060051E1 RID: 20961 RVA: 0x0017D1AC File Offset: 0x0017B3AC
		// Note: this type is marked as 'beforefieldinit'.
		static FileInfo()
		{
			Il2CppClassPointerStore<FileInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "FileInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileInfo>.NativeClassPtr);
			FileInfo.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileInfo>.NativeClassPtr, 100675766);
			FileInfo.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileInfo>.NativeClassPtr, 100675767);
			FileInfo.NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileInfo>.NativeClassPtr, 100675768);
			FileInfo.NativeMethodInfoPtr_get_Length_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileInfo>.NativeClassPtr, 100675769);
			FileInfo.NativeMethodInfoPtr_OpenText_Public_StreamReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileInfo>.NativeClassPtr, 100675770);
			FileInfo.NativeMethodInfoPtr_CreateText_Public_StreamWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileInfo>.NativeClassPtr, 100675771);
			FileInfo.NativeMethodInfoPtr_AppendText_Public_StreamWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileInfo>.NativeClassPtr, 100675772);
			FileInfo.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileInfo>.NativeClassPtr, 100675773);
			FileInfo.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileInfo>.NativeClassPtr, 100675774);
		}

		// Token: 0x060051E2 RID: 20962 RVA: 0x0017D290 File Offset: 0x0017B490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1430812, XrefRangeEnd = 1430813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileInfo.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060051E3 RID: 20963 RVA: 0x0017D2CC File Offset: 0x0017B4CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1430830, RefRangeEnd = 1430833, XrefRangeStart = 1430813, XrefRangeEnd = 1430830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileInfo(string fileName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileInfo.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060051E4 RID: 20964 RVA: 0x0017D318 File Offset: 0x0017B518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1430833, XrefRangeEnd = 1430851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileInfo(string originalPath, string fullPath = null, string fileName = null, bool isNormalized = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileInfo>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileInfo.NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170014D4 RID: 5332
		// (get) Token: 0x060051E5 RID: 20965 RVA: 0x0017D398 File Offset: 0x0017B598
		public unsafe long Length
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1430852, RefRangeEnd = 1430853, XrefRangeStart = 1430851, XrefRangeEnd = 1430852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileInfo.NativeMethodInfoPtr_get_Length_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060051E6 RID: 20966 RVA: 0x0017D3D4 File Offset: 0x0017B5D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1430859, RefRangeEnd = 1430860, XrefRangeStart = 1430853, XrefRangeEnd = 1430859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamReader OpenText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileInfo.NativeMethodInfoPtr_OpenText_Public_StreamReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StreamReader>(intPtr3) : null;
		}

		// Token: 0x060051E7 RID: 20967 RVA: 0x0017D414 File Offset: 0x0017B614
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1430865, RefRangeEnd = 1430866, XrefRangeStart = 1430860, XrefRangeEnd = 1430865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamWriter CreateText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileInfo.NativeMethodInfoPtr_CreateText_Public_StreamWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StreamWriter>(intPtr3) : null;
		}

		// Token: 0x060051E8 RID: 20968 RVA: 0x0017D454 File Offset: 0x0017B654
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1430871, RefRangeEnd = 1430872, XrefRangeStart = 1430866, XrefRangeEnd = 1430871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamWriter AppendText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileInfo.NativeMethodInfoPtr_AppendText_Public_StreamWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StreamWriter>(intPtr3) : null;
		}

		// Token: 0x060051E9 RID: 20969 RVA: 0x0017D494 File Offset: 0x0017B694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileInfo(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileInfo.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170014D5 RID: 5333
		// (get) Token: 0x060051EA RID: 20970 RVA: 0x0017D4F8 File Offset: 0x0017B6F8
		public unsafe override string Name
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileInfo.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060051EB RID: 20971 RVA: 0x0001D266 File Offset: 0x0001B466
		public FileInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040042C5 RID: 17093
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x040042C6 RID: 17094
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040042C7 RID: 17095
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_Boolean_0;

		// Token: 0x040042C8 RID: 17096
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int64_0;

		// Token: 0x040042C9 RID: 17097
		private static readonly IntPtr NativeMethodInfoPtr_OpenText_Public_StreamReader_0;

		// Token: 0x040042CA RID: 17098
		private static readonly IntPtr NativeMethodInfoPtr_CreateText_Public_StreamWriter_0;

		// Token: 0x040042CB RID: 17099
		private static readonly IntPtr NativeMethodInfoPtr_AppendText_Public_StreamWriter_0;

		// Token: 0x040042CC RID: 17100
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040042CD RID: 17101
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
	}
}
