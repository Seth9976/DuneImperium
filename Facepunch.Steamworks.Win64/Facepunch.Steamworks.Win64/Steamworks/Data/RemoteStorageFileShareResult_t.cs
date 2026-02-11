using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000124 RID: 292
	public sealed class RemoteStorageFileShareResult_t : ValueType
	{
		// Token: 0x06001066 RID: 4198 RVA: 0x0005FF78 File Offset: 0x0005E178
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageFileShareResult_t()
		{
			Il2CppClassPointerStore<RemoteStorageFileShareResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "RemoteStorageFileShareResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageFileShareResult_t>.NativeClassPtr);
			RemoteStorageFileShareResult_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageFileShareResult_t>.NativeClassPtr, "Result");
			RemoteStorageFileShareResult_t.NativeFieldInfoPtr_File = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageFileShareResult_t>.NativeClassPtr, "File");
			RemoteStorageFileShareResult_t.NativeFieldInfoPtr_Filename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageFileShareResult_t>.NativeClassPtr, "Filename");
			RemoteStorageFileShareResult_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageFileShareResult_t>.NativeClassPtr, "_datasize");
			RemoteStorageFileShareResult_t.NativeMethodInfoPtr_FilenameUTF8_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageFileShareResult_t>.NativeClassPtr, 100666937);
			RemoteStorageFileShareResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageFileShareResult_t>.NativeClassPtr, 100666938);
			RemoteStorageFileShareResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageFileShareResult_t>.NativeClassPtr, 100666939);
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x00060034 File Offset: 0x0005E234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950417, XrefRangeEnd = 950421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FilenameUTF8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageFileShareResult_t.NativeMethodInfoPtr_FilenameUTF8_Internal_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06001068 RID: 4200 RVA: 0x00060070 File Offset: 0x0005E270
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950421, XrefRangeEnd = 950425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageFileShareResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06001069 RID: 4201 RVA: 0x000600B4 File Offset: 0x0005E2B4
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageFileShareResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x0000494F File Offset: 0x00002B4F
		public RemoteStorageFileShareResult_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x00004958 File Offset: 0x00002B58
		public RemoteStorageFileShareResult_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoteStorageFileShareResult_t>.NativeClassPtr))
		{
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x0600106C RID: 4204 RVA: 0x000600F8 File Offset: 0x0005E2F8
		// (set) Token: 0x0600106D RID: 4205 RVA: 0x0000496A File Offset: 0x00002B6A
		public unsafe Result Result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageFileShareResult_t.NativeFieldInfoPtr_Result);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageFileShareResult_t.NativeFieldInfoPtr_Result)) = value;
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x0600106E RID: 4206 RVA: 0x00060120 File Offset: 0x0005E320
		// (set) Token: 0x0600106F RID: 4207 RVA: 0x00004985 File Offset: 0x00002B85
		public unsafe ulong File
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageFileShareResult_t.NativeFieldInfoPtr_File);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageFileShareResult_t.NativeFieldInfoPtr_File)) = value;
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06001070 RID: 4208 RVA: 0x00060148 File Offset: 0x0005E348
		// (set) Token: 0x06001071 RID: 4209 RVA: 0x000049A0 File Offset: 0x00002BA0
		public unsafe Il2CppStructArray<byte> Filename
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageFileShareResult_t.NativeFieldInfoPtr_Filename);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageFileShareResult_t.NativeFieldInfoPtr_Filename), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06001072 RID: 4210 RVA: 0x00060178 File Offset: 0x0005E378
		// (set) Token: 0x06001073 RID: 4211 RVA: 0x000049BF File Offset: 0x00002BBF
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageFileShareResult_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageFileShareResult_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040016D2 RID: 5842
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x040016D3 RID: 5843
		private static readonly IntPtr NativeFieldInfoPtr_File;

		// Token: 0x040016D4 RID: 5844
		private static readonly IntPtr NativeFieldInfoPtr_Filename;

		// Token: 0x040016D5 RID: 5845
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040016D6 RID: 5846
		private static readonly IntPtr NativeMethodInfoPtr_FilenameUTF8_Internal_String_0;

		// Token: 0x040016D7 RID: 5847
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040016D8 RID: 5848
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}
