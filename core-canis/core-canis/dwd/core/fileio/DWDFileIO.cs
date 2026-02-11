using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;

namespace dwd.core.fileio
{
	// Token: 0x020001A6 RID: 422
	public static class DWDFileIO : Object
	{
		// Token: 0x06001809 RID: 6153 RVA: 0x0000A8B7 File Offset: 0x00008AB7
		// Note: this type is marked as 'beforefieldinit'.
		static DWDFileIO()
		{
			Il2CppClassPointerStore<DWDFileIO>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.fileio", "DWDFileIO");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DWDFileIO>.NativeClassPtr);
			DWDFileIO.NativeMethodInfoPtr_fixPath_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDFileIO>.NativeClassPtr, 100667117);
		}

		// Token: 0x0600180A RID: 6154 RVA: 0x000741A8 File Offset: 0x000723A8
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string fixPath(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDFileIO.NativeMethodInfoPtr_fixPath_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600180B RID: 6155 RVA: 0x0000A8F0 File Offset: 0x00008AF0
		public DWDFileIO(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400110A RID: 4362
		private static readonly IntPtr NativeMethodInfoPtr_fixPath_Private_Static_String_String_0;

		// Token: 0x0200034E RID: 846
		public static class File : Object
		{
			// Token: 0x060026F2 RID: 9970 RVA: 0x000A59C4 File Offset: 0x000A3BC4
			// Note: this type is marked as 'beforefieldinit'.
			static File()
			{
				Il2CppClassPointerStore<DWDFileIO.File>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DWDFileIO>.NativeClassPtr, "File");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DWDFileIO.File>.NativeClassPtr);
				DWDFileIO.File.NativeMethodInfoPtr_Exists_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDFileIO.File>.NativeClassPtr, 100667118);
				DWDFileIO.File.NativeMethodInfoPtr_FileSize_Public_Static_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDFileIO.File>.NativeClassPtr, 100667119);
				DWDFileIO.File.NativeMethodInfoPtr_ReadAllBytes_Public_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDFileIO.File>.NativeClassPtr, 100667120);
				DWDFileIO.File.NativeMethodInfoPtr_ReadAllText_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDFileIO.File>.NativeClassPtr, 100667121);
				DWDFileIO.File.NativeMethodInfoPtr_WriteAllBytes_Public_Static_Void_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDFileIO.File>.NativeClassPtr, 100667122);
				DWDFileIO.File.NativeMethodInfoPtr_WriteAllText_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDFileIO.File>.NativeClassPtr, 100667123);
				DWDFileIO.File.NativeMethodInfoPtr_Delete_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDFileIO.File>.NativeClassPtr, 100667124);
				DWDFileIO.File.NativeMethodInfoPtr_Copy_Public_Static_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDFileIO.File>.NativeClassPtr, 100667125);
				DWDFileIO.File.NativeMethodInfoPtr_AppendAllText_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDFileIO.File>.NativeClassPtr, 100667126);
			}

			// Token: 0x060026F3 RID: 9971 RVA: 0x000A5AA4 File Offset: 0x000A3CA4
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 879745, RefRangeEnd = 879763, XrefRangeStart = 879736, XrefRangeEnd = 879745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool Exists(string path)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDFileIO.File.NativeMethodInfoPtr_Exists_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060026F4 RID: 9972 RVA: 0x000A5AE8 File Offset: 0x000A3CE8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 879778, RefRangeEnd = 879780, XrefRangeStart = 879763, XrefRangeEnd = 879778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static long FileSize(string path)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDFileIO.File.NativeMethodInfoPtr_FileSize_Public_Static_Int64_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060026F5 RID: 9973 RVA: 0x000A5B2C File Offset: 0x000A3D2C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 879803, RefRangeEnd = 879804, XrefRangeStart = 879780, XrefRangeEnd = 879803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Il2CppStructArray<byte> ReadAllBytes(string path)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDFileIO.File.NativeMethodInfoPtr_ReadAllBytes_Public_Static_Il2CppStructArray_1_Byte_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
				}
			}

			// Token: 0x060026F6 RID: 9974 RVA: 0x000A5B70 File Offset: 0x000A3D70
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 879844, RefRangeEnd = 879848, XrefRangeStart = 879804, XrefRangeEnd = 879844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static string ReadAllText(string path)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDFileIO.File.NativeMethodInfoPtr_ReadAllText_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060026F7 RID: 9975 RVA: 0x000A5BAC File Offset: 0x000A3DAC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 879857, RefRangeEnd = 879858, XrefRangeStart = 879848, XrefRangeEnd = 879857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDFileIO.File.NativeMethodInfoPtr_WriteAllBytes_Public_Static_Void_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060026F8 RID: 9976 RVA: 0x000A5BF4 File Offset: 0x000A3DF4
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 879885, RefRangeEnd = 879891, XrefRangeStart = 879858, XrefRangeEnd = 879885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDFileIO.File.NativeMethodInfoPtr_WriteAllText_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060026F9 RID: 9977 RVA: 0x000A5C3C File Offset: 0x000A3E3C
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 879900, RefRangeEnd = 879908, XrefRangeStart = 879891, XrefRangeEnd = 879900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Delete(string path)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDFileIO.File.NativeMethodInfoPtr_Delete_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060026FA RID: 9978 RVA: 0x000A5C74 File Offset: 0x000A3E74
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 879967, RefRangeEnd = 879968, XrefRangeStart = 879908, XrefRangeEnd = 879967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Copy(string sourceFileName, string destFileName, bool overwrite = false)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDFileIO.File.NativeMethodInfoPtr_Copy_Public_Static_Void_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060026FB RID: 9979 RVA: 0x000A5CCC File Offset: 0x000A3ECC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 879969, RefRangeEnd = 879971, XrefRangeStart = 879968, XrefRangeEnd = 879969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDFileIO.File.NativeMethodInfoPtr_AppendAllText_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060026FC RID: 9980 RVA: 0x00011B9F File Offset: 0x0000FD9F
			public File(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001A76 RID: 6774
			private static readonly IntPtr NativeMethodInfoPtr_Exists_Public_Static_Boolean_String_0;

			// Token: 0x04001A77 RID: 6775
			private static readonly IntPtr NativeMethodInfoPtr_FileSize_Public_Static_Int64_String_0;

			// Token: 0x04001A78 RID: 6776
			private static readonly IntPtr NativeMethodInfoPtr_ReadAllBytes_Public_Static_Il2CppStructArray_1_Byte_String_0;

			// Token: 0x04001A79 RID: 6777
			private static readonly IntPtr NativeMethodInfoPtr_ReadAllText_Public_Static_String_String_0;

			// Token: 0x04001A7A RID: 6778
			private static readonly IntPtr NativeMethodInfoPtr_WriteAllBytes_Public_Static_Void_String_Il2CppStructArray_1_Byte_0;

			// Token: 0x04001A7B RID: 6779
			private static readonly IntPtr NativeMethodInfoPtr_WriteAllText_Public_Static_Void_String_String_0;

			// Token: 0x04001A7C RID: 6780
			private static readonly IntPtr NativeMethodInfoPtr_Delete_Public_Static_Void_String_0;

			// Token: 0x04001A7D RID: 6781
			private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_String_String_Boolean_0;

			// Token: 0x04001A7E RID: 6782
			private static readonly IntPtr NativeMethodInfoPtr_AppendAllText_Public_Static_Void_String_String_0;
		}

		// Token: 0x0200034F RID: 847
		public static class Directory : Object
		{
			// Token: 0x060026FD RID: 9981 RVA: 0x000A5D14 File Offset: 0x000A3F14
			// Note: this type is marked as 'beforefieldinit'.
			static Directory()
			{
				Il2CppClassPointerStore<DWDFileIO.Directory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DWDFileIO>.NativeClassPtr, "Directory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DWDFileIO.Directory>.NativeClassPtr);
				DWDFileIO.Directory.NativeMethodInfoPtr_CreateDirectory_Public_Static_DirectoryInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDFileIO.Directory>.NativeClassPtr, 100667127);
				DWDFileIO.Directory.NativeMethodInfoPtr_Exists_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDFileIO.Directory>.NativeClassPtr, 100667128);
				DWDFileIO.Directory.NativeMethodInfoPtr_Delete_Public_Static_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDFileIO.Directory>.NativeClassPtr, 100667129);
				DWDFileIO.Directory.NativeMethodInfoPtr_Delete_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDFileIO.Directory>.NativeClassPtr, 100667130);
				DWDFileIO.Directory.NativeMethodInfoPtr_GetParent_Public_Static_DirectoryInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDFileIO.Directory>.NativeClassPtr, 100667131);
				DWDFileIO.Directory.NativeMethodInfoPtr_EnumerateDirectories_Public_Static_IEnumerable_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDFileIO.Directory>.NativeClassPtr, 100667132);
				DWDFileIO.Directory.NativeMethodInfoPtr_EnumerateFiles_Public_Static_IEnumerable_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDFileIO.Directory>.NativeClassPtr, 100667133);
				DWDFileIO.Directory.NativeMethodInfoPtr_GetFiles_Public_Static_Il2CppStringArray_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDFileIO.Directory>.NativeClassPtr, 100667134);
			}

			// Token: 0x060026FE RID: 9982 RVA: 0x000A5DE0 File Offset: 0x000A3FE0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 879980, RefRangeEnd = 879981, XrefRangeStart = 879971, XrefRangeEnd = 879980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static DirectoryInfo CreateDirectory(string path)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDFileIO.Directory.NativeMethodInfoPtr_CreateDirectory_Public_Static_DirectoryInfo_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DirectoryInfo>(intPtr3) : null;
				}
			}

			// Token: 0x060026FF RID: 9983 RVA: 0x000A5E24 File Offset: 0x000A4024
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 879990, RefRangeEnd = 879991, XrefRangeStart = 879981, XrefRangeEnd = 879990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool Exists(string path)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDFileIO.Directory.NativeMethodInfoPtr_Exists_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002700 RID: 9984 RVA: 0x000A5E68 File Offset: 0x000A4068
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879991, XrefRangeEnd = 880000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Delete(string path, bool recursive)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recursive;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDFileIO.Directory.NativeMethodInfoPtr_Delete_Public_Static_Void_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002701 RID: 9985 RVA: 0x000A5EAC File Offset: 0x000A40AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880000, XrefRangeEnd = 880009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Delete(string path)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDFileIO.Directory.NativeMethodInfoPtr_Delete_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002702 RID: 9986 RVA: 0x000A5EE4 File Offset: 0x000A40E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880009, XrefRangeEnd = 880010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static DirectoryInfo GetParent(string path)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDFileIO.Directory.NativeMethodInfoPtr_GetParent_Public_Static_DirectoryInfo_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DirectoryInfo>(intPtr3) : null;
				}
			}

			// Token: 0x06002703 RID: 9987 RVA: 0x000A5F28 File Offset: 0x000A4128
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880010, XrefRangeEnd = 880011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static IEnumerable<string> EnumerateDirectories(string path)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDFileIO.Directory.NativeMethodInfoPtr_EnumerateDirectories_Public_Static_IEnumerable_1_String_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
				}
			}

			// Token: 0x06002704 RID: 9988 RVA: 0x000A5F6C File Offset: 0x000A416C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880011, XrefRangeEnd = 880012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static IEnumerable<string> EnumerateFiles(string path)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDFileIO.Directory.NativeMethodInfoPtr_EnumerateFiles_Public_Static_IEnumerable_1_String_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
				}
			}

			// Token: 0x06002705 RID: 9989 RVA: 0x000A5FB0 File Offset: 0x000A41B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880012, XrefRangeEnd = 880013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Il2CppStringArray GetFiles(string path, string searchPattern)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(searchPattern);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDFileIO.Directory.NativeMethodInfoPtr_GetFiles_Public_Static_Il2CppStringArray_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}

			// Token: 0x06002706 RID: 9990 RVA: 0x00011BA8 File Offset: 0x0000FDA8
			public Directory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001A7F RID: 6783
			private static readonly IntPtr NativeMethodInfoPtr_CreateDirectory_Public_Static_DirectoryInfo_String_0;

			// Token: 0x04001A80 RID: 6784
			private static readonly IntPtr NativeMethodInfoPtr_Exists_Public_Static_Boolean_String_0;

			// Token: 0x04001A81 RID: 6785
			private static readonly IntPtr NativeMethodInfoPtr_Delete_Public_Static_Void_String_Boolean_0;

			// Token: 0x04001A82 RID: 6786
			private static readonly IntPtr NativeMethodInfoPtr_Delete_Public_Static_Void_String_0;

			// Token: 0x04001A83 RID: 6787
			private static readonly IntPtr NativeMethodInfoPtr_GetParent_Public_Static_DirectoryInfo_String_0;

			// Token: 0x04001A84 RID: 6788
			private static readonly IntPtr NativeMethodInfoPtr_EnumerateDirectories_Public_Static_IEnumerable_1_String_String_0;

			// Token: 0x04001A85 RID: 6789
			private static readonly IntPtr NativeMethodInfoPtr_EnumerateFiles_Public_Static_IEnumerable_1_String_String_0;

			// Token: 0x04001A86 RID: 6790
			private static readonly IntPtr NativeMethodInfoPtr_GetFiles_Public_Static_Il2CppStringArray_String_String_0;
		}

		// Token: 0x02000350 RID: 848
		public static class Path : Object
		{
			// Token: 0x06002707 RID: 9991 RVA: 0x000A6008 File Offset: 0x000A4208
			// Note: this type is marked as 'beforefieldinit'.
			static Path()
			{
				Il2CppClassPointerStore<DWDFileIO.Path>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DWDFileIO>.NativeClassPtr, "Path");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DWDFileIO.Path>.NativeClassPtr);
				DWDFileIO.Path.NativeMethodInfoPtr_get_DirectorySeparatorChar_Public_Static_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDFileIO.Path>.NativeClassPtr, 100667135);
				DWDFileIO.Path.NativeMethodInfoPtr_Combine_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDFileIO.Path>.NativeClassPtr, 100667136);
				DWDFileIO.Path.NativeMethodInfoPtr_Combine_Public_Static_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDFileIO.Path>.NativeClassPtr, 100667137);
				DWDFileIO.Path.NativeMethodInfoPtr_GetFullPath_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDFileIO.Path>.NativeClassPtr, 100667138);
				DWDFileIO.Path.NativeMethodInfoPtr_GetFileName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDFileIO.Path>.NativeClassPtr, 100667139);
				DWDFileIO.Path.NativeMethodInfoPtr_GetExtension_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDFileIO.Path>.NativeClassPtr, 100667140);
			}

			// Token: 0x17000B07 RID: 2823
			// (get) Token: 0x06002708 RID: 9992 RVA: 0x000A60AC File Offset: 0x000A42AC
			public unsafe static char DirectorySeparatorChar
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880013, XrefRangeEnd = 880017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDFileIO.Path.NativeMethodInfoPtr_get_DirectorySeparatorChar_Public_Static_get_Char_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002709 RID: 9993 RVA: 0x000A60DC File Offset: 0x000A42DC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 880021, RefRangeEnd = 880023, XrefRangeStart = 880017, XrefRangeEnd = 880021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static string Combine(string left, string right)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(left);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(right);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDFileIO.Path.NativeMethodInfoPtr_Combine_Public_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600270A RID: 9994 RVA: 0x000A612C File Offset: 0x000A432C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 880028, RefRangeEnd = 880031, XrefRangeStart = 880023, XrefRangeEnd = 880028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static string Combine([Optional] Il2CppStringArray paths)
			{
				if (paths == null)
				{
					paths = new Il2CppStringArray(0L);
				}
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(paths);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDFileIO.Path.NativeMethodInfoPtr_Combine_Public_Static_String_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600270B RID: 9995 RVA: 0x000A6178 File Offset: 0x000A4378
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 880035, RefRangeEnd = 880036, XrefRangeStart = 880031, XrefRangeEnd = 880035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static string GetFullPath(string path)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDFileIO.Path.NativeMethodInfoPtr_GetFullPath_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600270C RID: 9996 RVA: 0x000A61B4 File Offset: 0x000A43B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880036, XrefRangeEnd = 880040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static string GetFileName(string path)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDFileIO.Path.NativeMethodInfoPtr_GetFileName_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600270D RID: 9997 RVA: 0x000A61F0 File Offset: 0x000A43F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880040, XrefRangeEnd = 880044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static string GetExtension(string path)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDFileIO.Path.NativeMethodInfoPtr_GetExtension_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600270E RID: 9998 RVA: 0x00011BB1 File Offset: 0x0000FDB1
			public static string Combine(params string[] paths)
			{
				return DWDFileIO.Path.Combine(new Il2CppStringArray(paths));
			}

			// Token: 0x0600270F RID: 9999 RVA: 0x00011BBE File Offset: 0x0000FDBE
			public Path(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001A87 RID: 6791
			private static readonly IntPtr NativeMethodInfoPtr_get_DirectorySeparatorChar_Public_Static_get_Char_0;

			// Token: 0x04001A88 RID: 6792
			private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Static_String_String_String_0;

			// Token: 0x04001A89 RID: 6793
			private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Static_String_Il2CppStringArray_0;

			// Token: 0x04001A8A RID: 6794
			private static readonly IntPtr NativeMethodInfoPtr_GetFullPath_Public_Static_String_String_0;

			// Token: 0x04001A8B RID: 6795
			private static readonly IntPtr NativeMethodInfoPtr_GetFileName_Public_Static_String_String_0;

			// Token: 0x04001A8C RID: 6796
			private static readonly IntPtr NativeMethodInfoPtr_GetExtension_Public_Static_String_String_0;
		}
	}
}
