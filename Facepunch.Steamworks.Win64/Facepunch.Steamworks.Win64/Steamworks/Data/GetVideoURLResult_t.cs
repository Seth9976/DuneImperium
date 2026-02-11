using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200019B RID: 411
	public sealed class GetVideoURLResult_t : ValueType
	{
		// Token: 0x0600147A RID: 5242 RVA: 0x0006A510 File Offset: 0x00068710
		// Note: this type is marked as 'beforefieldinit'.
		static GetVideoURLResult_t()
		{
			Il2CppClassPointerStore<GetVideoURLResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "GetVideoURLResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetVideoURLResult_t>.NativeClassPtr);
			GetVideoURLResult_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetVideoURLResult_t>.NativeClassPtr, "Result");
			GetVideoURLResult_t.NativeFieldInfoPtr_VideoAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetVideoURLResult_t>.NativeClassPtr, "VideoAppID");
			GetVideoURLResult_t.NativeFieldInfoPtr_URL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetVideoURLResult_t>.NativeClassPtr, "URL");
			GetVideoURLResult_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetVideoURLResult_t>.NativeClassPtr, "_datasize");
			GetVideoURLResult_t.NativeMethodInfoPtr_URLUTF8_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetVideoURLResult_t>.NativeClassPtr, 100667306);
			GetVideoURLResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetVideoURLResult_t>.NativeClassPtr, 100667307);
			GetVideoURLResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetVideoURLResult_t>.NativeClassPtr, 100667308);
		}

		// Token: 0x0600147B RID: 5243 RVA: 0x0006A5CC File Offset: 0x000687CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950948, XrefRangeEnd = 950952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string URLUTF8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetVideoURLResult_t.NativeMethodInfoPtr_URLUTF8_Internal_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x0600147C RID: 5244 RVA: 0x0006A608 File Offset: 0x00068808
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950952, XrefRangeEnd = 950956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetVideoURLResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x0600147D RID: 5245 RVA: 0x0006A64C File Offset: 0x0006884C
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetVideoURLResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600147E RID: 5246 RVA: 0x00006928 File Offset: 0x00004B28
		public GetVideoURLResult_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600147F RID: 5247 RVA: 0x00006931 File Offset: 0x00004B31
		public GetVideoURLResult_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetVideoURLResult_t>.NativeClassPtr))
		{
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06001480 RID: 5248 RVA: 0x0006A690 File Offset: 0x00068890
		// (set) Token: 0x06001481 RID: 5249 RVA: 0x00006943 File Offset: 0x00004B43
		public unsafe Result Result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetVideoURLResult_t.NativeFieldInfoPtr_Result);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetVideoURLResult_t.NativeFieldInfoPtr_Result)) = value;
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06001482 RID: 5250 RVA: 0x0006A6B8 File Offset: 0x000688B8
		// (set) Token: 0x06001483 RID: 5251 RVA: 0x0000695E File Offset: 0x00004B5E
		public unsafe AppId VideoAppID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetVideoURLResult_t.NativeFieldInfoPtr_VideoAppID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetVideoURLResult_t.NativeFieldInfoPtr_VideoAppID)) = value;
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06001484 RID: 5252 RVA: 0x0006A6E0 File Offset: 0x000688E0
		// (set) Token: 0x06001485 RID: 5253 RVA: 0x00006979 File Offset: 0x00004B79
		public unsafe Il2CppStructArray<byte> URL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetVideoURLResult_t.NativeFieldInfoPtr_URL);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetVideoURLResult_t.NativeFieldInfoPtr_URL), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06001486 RID: 5254 RVA: 0x0006A710 File Offset: 0x00068910
		// (set) Token: 0x06001487 RID: 5255 RVA: 0x00006998 File Offset: 0x00004B98
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GetVideoURLResult_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GetVideoURLResult_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001A4F RID: 6735
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x04001A50 RID: 6736
		private static readonly IntPtr NativeFieldInfoPtr_VideoAppID;

		// Token: 0x04001A51 RID: 6737
		private static readonly IntPtr NativeFieldInfoPtr_URL;

		// Token: 0x04001A52 RID: 6738
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001A53 RID: 6739
		private static readonly IntPtr NativeMethodInfoPtr_URLUTF8_Internal_String_0;

		// Token: 0x04001A54 RID: 6740
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001A55 RID: 6741
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}
