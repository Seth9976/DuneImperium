using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001A6 RID: 422
	public sealed class GSClientDeny_t : ValueType
	{
		// Token: 0x060014E0 RID: 5344 RVA: 0x0006B4BC File Offset: 0x000696BC
		// Note: this type is marked as 'beforefieldinit'.
		static GSClientDeny_t()
		{
			Il2CppClassPointerStore<GSClientDeny_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "GSClientDeny_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GSClientDeny_t>.NativeClassPtr);
			GSClientDeny_t.NativeFieldInfoPtr_SteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientDeny_t>.NativeClassPtr, "SteamID");
			GSClientDeny_t.NativeFieldInfoPtr_DenyReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientDeny_t>.NativeClassPtr, "DenyReason");
			GSClientDeny_t.NativeFieldInfoPtr_OptionalText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientDeny_t>.NativeClassPtr, "OptionalText");
			GSClientDeny_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientDeny_t>.NativeClassPtr, "_datasize");
			GSClientDeny_t.NativeMethodInfoPtr_OptionalTextUTF8_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GSClientDeny_t>.NativeClassPtr, 100667342);
			GSClientDeny_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GSClientDeny_t>.NativeClassPtr, 100667343);
			GSClientDeny_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GSClientDeny_t>.NativeClassPtr, 100667344);
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x0006B578 File Offset: 0x00069778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951004, XrefRangeEnd = 951008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string OptionalTextUTF8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GSClientDeny_t.NativeMethodInfoPtr_OptionalTextUTF8_Internal_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x060014E2 RID: 5346 RVA: 0x0006B5B4 File Offset: 0x000697B4
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951008, XrefRangeEnd = 951012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GSClientDeny_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x060014E3 RID: 5347 RVA: 0x0006B5F8 File Offset: 0x000697F8
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GSClientDeny_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x00006C61 File Offset: 0x00004E61
		public GSClientDeny_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x00006C6A File Offset: 0x00004E6A
		public GSClientDeny_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GSClientDeny_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x060014E6 RID: 5350 RVA: 0x0006B63C File Offset: 0x0006983C
		// (set) Token: 0x060014E7 RID: 5351 RVA: 0x00006C7C File Offset: 0x00004E7C
		public unsafe ulong SteamID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GSClientDeny_t.NativeFieldInfoPtr_SteamID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GSClientDeny_t.NativeFieldInfoPtr_SteamID)) = value;
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x060014E8 RID: 5352 RVA: 0x0006B664 File Offset: 0x00069864
		// (set) Token: 0x060014E9 RID: 5353 RVA: 0x00006C97 File Offset: 0x00004E97
		public unsafe DenyReason DenyReason
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GSClientDeny_t.NativeFieldInfoPtr_DenyReason);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GSClientDeny_t.NativeFieldInfoPtr_DenyReason)) = value;
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x060014EA RID: 5354 RVA: 0x0006B68C File Offset: 0x0006988C
		// (set) Token: 0x060014EB RID: 5355 RVA: 0x00006CB2 File Offset: 0x00004EB2
		public unsafe Il2CppStructArray<byte> OptionalText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GSClientDeny_t.NativeFieldInfoPtr_OptionalText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GSClientDeny_t.NativeFieldInfoPtr_OptionalText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x060014EC RID: 5356 RVA: 0x0006B6BC File Offset: 0x000698BC
		// (set) Token: 0x060014ED RID: 5357 RVA: 0x00006CD1 File Offset: 0x00004ED1
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GSClientDeny_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GSClientDeny_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001A8F RID: 6799
		private static readonly IntPtr NativeFieldInfoPtr_SteamID;

		// Token: 0x04001A90 RID: 6800
		private static readonly IntPtr NativeFieldInfoPtr_DenyReason;

		// Token: 0x04001A91 RID: 6801
		private static readonly IntPtr NativeFieldInfoPtr_OptionalText;

		// Token: 0x04001A92 RID: 6802
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001A93 RID: 6803
		private static readonly IntPtr NativeMethodInfoPtr_OptionalTextUTF8_Internal_String_0;

		// Token: 0x04001A94 RID: 6804
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001A95 RID: 6805
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}
