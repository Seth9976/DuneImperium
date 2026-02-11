using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200014D RID: 333
	public sealed class FileDetailsResult_t : ValueType
	{
		// Token: 0x060011FB RID: 4603 RVA: 0x00063FAC File Offset: 0x000621AC
		// Note: this type is marked as 'beforefieldinit'.
		static FileDetailsResult_t()
		{
			Il2CppClassPointerStore<FileDetailsResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "FileDetailsResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileDetailsResult_t>.NativeClassPtr);
			FileDetailsResult_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileDetailsResult_t>.NativeClassPtr, "Result");
			FileDetailsResult_t.NativeFieldInfoPtr_FileSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileDetailsResult_t>.NativeClassPtr, "FileSize");
			FileDetailsResult_t.NativeFieldInfoPtr_FileSHA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileDetailsResult_t>.NativeClassPtr, "FileSHA");
			FileDetailsResult_t.NativeFieldInfoPtr_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileDetailsResult_t>.NativeClassPtr, "Flags");
			FileDetailsResult_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileDetailsResult_t>.NativeClassPtr, "_datasize");
			FileDetailsResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileDetailsResult_t>.NativeClassPtr, 100667070);
			FileDetailsResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileDetailsResult_t>.NativeClassPtr, 100667071);
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x060011FC RID: 4604 RVA: 0x00064068 File Offset: 0x00062268
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950623, XrefRangeEnd = 950627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileDetailsResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x060011FD RID: 4605 RVA: 0x000640AC File Offset: 0x000622AC
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileDetailsResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011FE RID: 4606 RVA: 0x00005661 File Offset: 0x00003861
		public FileDetailsResult_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x0000566A File Offset: 0x0000386A
		public FileDetailsResult_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileDetailsResult_t>.NativeClassPtr))
		{
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06001200 RID: 4608 RVA: 0x000640F0 File Offset: 0x000622F0
		// (set) Token: 0x06001201 RID: 4609 RVA: 0x0000567C File Offset: 0x0000387C
		public unsafe Result Result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileDetailsResult_t.NativeFieldInfoPtr_Result);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileDetailsResult_t.NativeFieldInfoPtr_Result)) = value;
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06001202 RID: 4610 RVA: 0x00064118 File Offset: 0x00062318
		// (set) Token: 0x06001203 RID: 4611 RVA: 0x00005697 File Offset: 0x00003897
		public unsafe ulong FileSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileDetailsResult_t.NativeFieldInfoPtr_FileSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileDetailsResult_t.NativeFieldInfoPtr_FileSize)) = value;
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06001204 RID: 4612 RVA: 0x00064140 File Offset: 0x00062340
		// (set) Token: 0x06001205 RID: 4613 RVA: 0x000056B2 File Offset: 0x000038B2
		public unsafe Il2CppStructArray<byte> FileSHA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileDetailsResult_t.NativeFieldInfoPtr_FileSHA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileDetailsResult_t.NativeFieldInfoPtr_FileSHA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06001206 RID: 4614 RVA: 0x00064170 File Offset: 0x00062370
		// (set) Token: 0x06001207 RID: 4615 RVA: 0x000056D1 File Offset: 0x000038D1
		public unsafe uint Flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileDetailsResult_t.NativeFieldInfoPtr_Flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileDetailsResult_t.NativeFieldInfoPtr_Flags)) = value;
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06001208 RID: 4616 RVA: 0x00064198 File Offset: 0x00062398
		// (set) Token: 0x06001209 RID: 4617 RVA: 0x000056EC File Offset: 0x000038EC
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FileDetailsResult_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FileDetailsResult_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001828 RID: 6184
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x04001829 RID: 6185
		private static readonly IntPtr NativeFieldInfoPtr_FileSize;

		// Token: 0x0400182A RID: 6186
		private static readonly IntPtr NativeFieldInfoPtr_FileSHA;

		// Token: 0x0400182B RID: 6187
		private static readonly IntPtr NativeFieldInfoPtr_Flags;

		// Token: 0x0400182C RID: 6188
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x0400182D RID: 6189
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400182E RID: 6190
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}
