using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200012C RID: 300
	public sealed class RemoteStorageDownloadUGCResult_t : ValueType
	{
		// Token: 0x060010B2 RID: 4274 RVA: 0x00060B60 File Offset: 0x0005ED60
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageDownloadUGCResult_t()
		{
			Il2CppClassPointerStore<RemoteStorageDownloadUGCResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "RemoteStorageDownloadUGCResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageDownloadUGCResult_t>.NativeClassPtr);
			RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageDownloadUGCResult_t>.NativeClassPtr, "Result");
			RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_File = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageDownloadUGCResult_t>.NativeClassPtr, "File");
			RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_AppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageDownloadUGCResult_t>.NativeClassPtr, "AppID");
			RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_SizeInBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageDownloadUGCResult_t>.NativeClassPtr, "SizeInBytes");
			RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_PchFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageDownloadUGCResult_t>.NativeClassPtr, "PchFileName");
			RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_SteamIDOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageDownloadUGCResult_t>.NativeClassPtr, "SteamIDOwner");
			RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageDownloadUGCResult_t>.NativeClassPtr, "_datasize");
			RemoteStorageDownloadUGCResult_t.NativeMethodInfoPtr_PchFileNameUTF8_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageDownloadUGCResult_t>.NativeClassPtr, 100666962);
			RemoteStorageDownloadUGCResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageDownloadUGCResult_t>.NativeClassPtr, 100666963);
			RemoteStorageDownloadUGCResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageDownloadUGCResult_t>.NativeClassPtr, 100666964);
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x00060C58 File Offset: 0x0005EE58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950453, XrefRangeEnd = 950457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string PchFileNameUTF8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageDownloadUGCResult_t.NativeMethodInfoPtr_PchFileNameUTF8_Internal_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x060010B4 RID: 4276 RVA: 0x00060C94 File Offset: 0x0005EE94
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950457, XrefRangeEnd = 950461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageDownloadUGCResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x060010B5 RID: 4277 RVA: 0x00060CD8 File Offset: 0x0005EED8
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageDownloadUGCResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x00004BBE File Offset: 0x00002DBE
		public RemoteStorageDownloadUGCResult_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x00004BC7 File Offset: 0x00002DC7
		public RemoteStorageDownloadUGCResult_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoteStorageDownloadUGCResult_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x060010B8 RID: 4280 RVA: 0x00060D1C File Offset: 0x0005EF1C
		// (set) Token: 0x060010B9 RID: 4281 RVA: 0x00004BD9 File Offset: 0x00002DD9
		public unsafe Result Result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_Result);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_Result)) = value;
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x060010BA RID: 4282 RVA: 0x00060D44 File Offset: 0x0005EF44
		// (set) Token: 0x060010BB RID: 4283 RVA: 0x00004BF4 File Offset: 0x00002DF4
		public unsafe ulong File
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_File);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_File)) = value;
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x060010BC RID: 4284 RVA: 0x00060D6C File Offset: 0x0005EF6C
		// (set) Token: 0x060010BD RID: 4285 RVA: 0x00004C0F File Offset: 0x00002E0F
		public unsafe AppId AppID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_AppID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_AppID)) = value;
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x060010BE RID: 4286 RVA: 0x00060D94 File Offset: 0x0005EF94
		// (set) Token: 0x060010BF RID: 4287 RVA: 0x00004C2A File Offset: 0x00002E2A
		public unsafe int SizeInBytes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_SizeInBytes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_SizeInBytes)) = value;
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x060010C0 RID: 4288 RVA: 0x00060DBC File Offset: 0x0005EFBC
		// (set) Token: 0x060010C1 RID: 4289 RVA: 0x00004C45 File Offset: 0x00002E45
		public unsafe Il2CppStructArray<byte> PchFileName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_PchFileName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_PchFileName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x060010C2 RID: 4290 RVA: 0x00060DEC File Offset: 0x0005EFEC
		// (set) Token: 0x060010C3 RID: 4291 RVA: 0x00004C64 File Offset: 0x00002E64
		public unsafe ulong SteamIDOwner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_SteamIDOwner);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_SteamIDOwner)) = value;
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x060010C4 RID: 4292 RVA: 0x00060E14 File Offset: 0x0005F014
		// (set) Token: 0x060010C5 RID: 4293 RVA: 0x00004C7F File Offset: 0x00002E7F
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x0400170F RID: 5903
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x04001710 RID: 5904
		private static readonly IntPtr NativeFieldInfoPtr_File;

		// Token: 0x04001711 RID: 5905
		private static readonly IntPtr NativeFieldInfoPtr_AppID;

		// Token: 0x04001712 RID: 5906
		private static readonly IntPtr NativeFieldInfoPtr_SizeInBytes;

		// Token: 0x04001713 RID: 5907
		private static readonly IntPtr NativeFieldInfoPtr_PchFileName;

		// Token: 0x04001714 RID: 5908
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDOwner;

		// Token: 0x04001715 RID: 5909
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001716 RID: 5910
		private static readonly IntPtr NativeMethodInfoPtr_PchFileNameUTF8_Internal_String_0;

		// Token: 0x04001717 RID: 5911
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001718 RID: 5912
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}
