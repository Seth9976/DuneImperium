using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.IO
{
	// Token: 0x02000536 RID: 1334
	public static class File : Object
	{
		// Token: 0x060051CC RID: 20940 RVA: 0x0017CA80 File Offset: 0x0017AC80
		// Note: this type is marked as 'beforefieldinit'.
		static File()
		{
			Il2CppClassPointerStore<File>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "File");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<File>.NativeClassPtr);
			File.NativeMethodInfoPtr_OpenText_Public_Static_StreamReader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100675747);
			File.NativeMethodInfoPtr_Copy_Public_Static_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100675748);
			File.NativeMethodInfoPtr_Delete_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100675749);
			File.NativeMethodInfoPtr_Exists_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100675750);
			File.NativeMethodInfoPtr_Open_Public_Static_FileStream_String_FileMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100675751);
			File.NativeMethodInfoPtr_Open_Public_Static_FileStream_String_FileMode_FileAccess_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100675752);
			File.NativeMethodInfoPtr_Open_Public_Static_FileStream_String_FileMode_FileAccess_FileShare_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100675753);
			File.NativeMethodInfoPtr_GetCreationTime_Public_Static_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100675754);
			File.NativeMethodInfoPtr_GetLastWriteTime_Public_Static_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100675755);
			File.NativeMethodInfoPtr_GetAttributes_Public_Static_FileAttributes_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100675756);
			File.NativeMethodInfoPtr_OpenRead_Public_Static_FileStream_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100675757);
			File.NativeMethodInfoPtr_ReadAllText_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100675758);
			File.NativeMethodInfoPtr_InternalReadAllText_Private_Static_String_String_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100675759);
			File.NativeMethodInfoPtr_WriteAllText_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100675760);
			File.NativeMethodInfoPtr_ReadAllBytes_Public_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100675761);
			File.NativeMethodInfoPtr_ReadAllBytesUnknownLength_Private_Static_Il2CppStructArray_1_Byte_FileStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100675762);
			File.NativeMethodInfoPtr_WriteAllBytes_Public_Static_Void_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100675763);
			File.NativeMethodInfoPtr_InternalWriteAllBytes_Private_Static_Void_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100675764);
			File.NativeMethodInfoPtr_AppendAllText_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100675765);
		}

		// Token: 0x060051CD RID: 20941 RVA: 0x0017CC2C File Offset: 0x0017AE2C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1430492, RefRangeEnd = 1430495, XrefRangeStart = 1430488, XrefRangeEnd = 1430492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StreamReader OpenText(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_OpenText_Public_Static_StreamReader_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StreamReader>(intPtr3) : null;
			}
		}

		// Token: 0x060051CE RID: 20942 RVA: 0x0017CC70 File Offset: 0x0017AE70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1430529, RefRangeEnd = 1430531, XrefRangeStart = 1430495, XrefRangeEnd = 1430529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(string sourceFileName, string destFileName, bool overwrite)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceFileName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(destFileName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overwrite;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_Copy_Public_Static_Void_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060051CF RID: 20943 RVA: 0x0017CCC8 File Offset: 0x0017AEC8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1430542, RefRangeEnd = 1430549, XrefRangeStart = 1430531, XrefRangeEnd = 1430542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Delete(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_Delete_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060051D0 RID: 20944 RVA: 0x0017CD00 File Offset: 0x0017AF00
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 1430561, RefRangeEnd = 1430595, XrefRangeStart = 1430549, XrefRangeEnd = 1430561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Exists(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_Exists_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060051D1 RID: 20945 RVA: 0x0017CD44 File Offset: 0x0017AF44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1430596, RefRangeEnd = 1430597, XrefRangeStart = 1430595, XrefRangeEnd = 1430596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FileStream Open(string path, FileMode mode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_Open_Public_Static_FileStream_String_FileMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FileStream>(intPtr3) : null;
		}

		// Token: 0x060051D2 RID: 20946 RVA: 0x0017CD98 File Offset: 0x0017AF98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1430598, RefRangeEnd = 1430599, XrefRangeStart = 1430597, XrefRangeEnd = 1430598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FileStream Open(string path, FileMode mode, FileAccess access)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref access;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_Open_Public_Static_FileStream_String_FileMode_FileAccess_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FileStream>(intPtr3) : null;
		}

		// Token: 0x060051D3 RID: 20947 RVA: 0x0017CDF8 File Offset: 0x0017AFF8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1430603, RefRangeEnd = 1430606, XrefRangeStart = 1430599, XrefRangeEnd = 1430603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FileStream Open(string path, FileMode mode, FileAccess access, FileShare share)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref access;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref share;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_Open_Public_Static_FileStream_String_FileMode_FileAccess_FileShare_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FileStream>(intPtr3) : null;
		}

		// Token: 0x060051D4 RID: 20948 RVA: 0x0017CE68 File Offset: 0x0017B068
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1430615, RefRangeEnd = 1430617, XrefRangeStart = 1430606, XrefRangeEnd = 1430615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime GetCreationTime(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_GetCreationTime_Public_Static_DateTime_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060051D5 RID: 20949 RVA: 0x0017CEAC File Offset: 0x0017B0AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1430626, RefRangeEnd = 1430628, XrefRangeStart = 1430617, XrefRangeEnd = 1430626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime GetLastWriteTime(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_GetLastWriteTime_Public_Static_DateTime_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060051D6 RID: 20950 RVA: 0x0017CEF0 File Offset: 0x0017B0F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1430633, RefRangeEnd = 1430635, XrefRangeStart = 1430628, XrefRangeEnd = 1430633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FileAttributes GetAttributes(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_GetAttributes_Public_Static_FileAttributes_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060051D7 RID: 20951 RVA: 0x0017CF34 File Offset: 0x0017B134
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1430639, RefRangeEnd = 1430642, XrefRangeStart = 1430635, XrefRangeEnd = 1430639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FileStream OpenRead(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_OpenRead_Public_Static_FileStream_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FileStream>(intPtr3) : null;
			}
		}

		// Token: 0x060051D8 RID: 20952 RVA: 0x0017CF78 File Offset: 0x0017B178
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1430657, RefRangeEnd = 1430664, XrefRangeStart = 1430642, XrefRangeEnd = 1430657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ReadAllText(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_ReadAllText_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060051D9 RID: 20953 RVA: 0x0017CFB4 File Offset: 0x0017B1B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1430674, RefRangeEnd = 1430675, XrefRangeStart = 1430664, XrefRangeEnd = 1430674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string InternalReadAllText(string path, Encoding encoding)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_InternalReadAllText_Private_Static_String_String_Encoding_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060051DA RID: 20954 RVA: 0x0017D004 File Offset: 0x0017B204
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1430685, RefRangeEnd = 1430697, XrefRangeStart = 1430675, XrefRangeEnd = 1430685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteAllText(string path, string contents)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(contents);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_WriteAllText_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060051DB RID: 20955 RVA: 0x0017D04C File Offset: 0x0017B24C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1430715, RefRangeEnd = 1430718, XrefRangeStart = 1430697, XrefRangeEnd = 1430715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> ReadAllBytes(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_ReadAllBytes_Public_Static_Il2CppStructArray_1_Byte_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060051DC RID: 20956 RVA: 0x0017D090 File Offset: 0x0017B290
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1430766, RefRangeEnd = 1430767, XrefRangeStart = 1430718, XrefRangeEnd = 1430766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> ReadAllBytesUnknownLength(FileStream fs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_ReadAllBytesUnknownLength_Private_Static_Il2CppStructArray_1_Byte_FileStream_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060051DD RID: 20957 RVA: 0x0017D0D4 File Offset: 0x0017B2D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1430788, RefRangeEnd = 1430790, XrefRangeStart = 1430767, XrefRangeEnd = 1430788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteAllBytes(string path, Il2CppStructArray<byte> bytes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_WriteAllBytes_Public_Static_Void_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060051DE RID: 20958 RVA: 0x0017D11C File Offset: 0x0017B31C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1430800, RefRangeEnd = 1430801, XrefRangeStart = 1430790, XrefRangeEnd = 1430800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalWriteAllBytes(string path, Il2CppStructArray<byte> bytes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_InternalWriteAllBytes_Private_Static_Void_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060051DF RID: 20959 RVA: 0x0017D164 File Offset: 0x0017B364
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1430811, RefRangeEnd = 1430812, XrefRangeStart = 1430801, XrefRangeEnd = 1430811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AppendAllText(string path, string contents)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(contents);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_AppendAllText_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060051E0 RID: 20960 RVA: 0x0001D25D File Offset: 0x0001B45D
		public File(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040042B2 RID: 17074
		private static readonly IntPtr NativeMethodInfoPtr_OpenText_Public_Static_StreamReader_String_0;

		// Token: 0x040042B3 RID: 17075
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_String_String_Boolean_0;

		// Token: 0x040042B4 RID: 17076
		private static readonly IntPtr NativeMethodInfoPtr_Delete_Public_Static_Void_String_0;

		// Token: 0x040042B5 RID: 17077
		private static readonly IntPtr NativeMethodInfoPtr_Exists_Public_Static_Boolean_String_0;

		// Token: 0x040042B6 RID: 17078
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Static_FileStream_String_FileMode_0;

		// Token: 0x040042B7 RID: 17079
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Static_FileStream_String_FileMode_FileAccess_0;

		// Token: 0x040042B8 RID: 17080
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Static_FileStream_String_FileMode_FileAccess_FileShare_0;

		// Token: 0x040042B9 RID: 17081
		private static readonly IntPtr NativeMethodInfoPtr_GetCreationTime_Public_Static_DateTime_String_0;

		// Token: 0x040042BA RID: 17082
		private static readonly IntPtr NativeMethodInfoPtr_GetLastWriteTime_Public_Static_DateTime_String_0;

		// Token: 0x040042BB RID: 17083
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributes_Public_Static_FileAttributes_String_0;

		// Token: 0x040042BC RID: 17084
		private static readonly IntPtr NativeMethodInfoPtr_OpenRead_Public_Static_FileStream_String_0;

		// Token: 0x040042BD RID: 17085
		private static readonly IntPtr NativeMethodInfoPtr_ReadAllText_Public_Static_String_String_0;

		// Token: 0x040042BE RID: 17086
		private static readonly IntPtr NativeMethodInfoPtr_InternalReadAllText_Private_Static_String_String_Encoding_0;

		// Token: 0x040042BF RID: 17087
		private static readonly IntPtr NativeMethodInfoPtr_WriteAllText_Public_Static_Void_String_String_0;

		// Token: 0x040042C0 RID: 17088
		private static readonly IntPtr NativeMethodInfoPtr_ReadAllBytes_Public_Static_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x040042C1 RID: 17089
		private static readonly IntPtr NativeMethodInfoPtr_ReadAllBytesUnknownLength_Private_Static_Il2CppStructArray_1_Byte_FileStream_0;

		// Token: 0x040042C2 RID: 17090
		private static readonly IntPtr NativeMethodInfoPtr_WriteAllBytes_Public_Static_Void_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x040042C3 RID: 17091
		private static readonly IntPtr NativeMethodInfoPtr_InternalWriteAllBytes_Private_Static_Void_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x040042C4 RID: 17092
		private static readonly IntPtr NativeMethodInfoPtr_AppendAllText_Public_Static_Void_String_String_0;
	}
}
