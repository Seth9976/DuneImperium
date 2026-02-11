using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000163 RID: 355
	[StructLayout(2)]
	public struct HTTPRequestCompleted_t
	{
		// Token: 0x06001288 RID: 4744 RVA: 0x000655FC File Offset: 0x000637FC
		// Note: this type is marked as 'beforefieldinit'.
		static HTTPRequestCompleted_t()
		{
			Il2CppClassPointerStore<HTTPRequestCompleted_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "HTTPRequestCompleted_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTTPRequestCompleted_t>.NativeClassPtr);
			HTTPRequestCompleted_t.NativeFieldInfoPtr_Request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestCompleted_t>.NativeClassPtr, "Request");
			HTTPRequestCompleted_t.NativeFieldInfoPtr_ContextValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestCompleted_t>.NativeClassPtr, "ContextValue");
			HTTPRequestCompleted_t.NativeFieldInfoPtr_RequestSuccessful = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestCompleted_t>.NativeClassPtr, "RequestSuccessful");
			HTTPRequestCompleted_t.NativeFieldInfoPtr_StatusCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestCompleted_t>.NativeClassPtr, "StatusCode");
			HTTPRequestCompleted_t.NativeFieldInfoPtr_BodySize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestCompleted_t>.NativeClassPtr, "BodySize");
			HTTPRequestCompleted_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestCompleted_t>.NativeClassPtr, "_datasize");
			HTTPRequestCompleted_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPRequestCompleted_t>.NativeClassPtr, 100667136);
			HTTPRequestCompleted_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPRequestCompleted_t>.NativeClassPtr, 100667137);
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06001289 RID: 4745 RVA: 0x000656CC File Offset: 0x000638CC
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950711, XrefRangeEnd = 950715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPRequestCompleted_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x0600128A RID: 4746 RVA: 0x000656FC File Offset: 0x000638FC
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPRequestCompleted_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x0000599A File Offset: 0x00003B9A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HTTPRequestCompleted_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x0600128C RID: 4748 RVA: 0x0006572C File Offset: 0x0006392C
		// (set) Token: 0x0600128D RID: 4749 RVA: 0x000059AC File Offset: 0x00003BAC
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTTPRequestCompleted_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTTPRequestCompleted_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x0400188E RID: 6286
		private static readonly IntPtr NativeFieldInfoPtr_Request;

		// Token: 0x0400188F RID: 6287
		private static readonly IntPtr NativeFieldInfoPtr_ContextValue;

		// Token: 0x04001890 RID: 6288
		private static readonly IntPtr NativeFieldInfoPtr_RequestSuccessful;

		// Token: 0x04001891 RID: 6289
		private static readonly IntPtr NativeFieldInfoPtr_StatusCode;

		// Token: 0x04001892 RID: 6290
		private static readonly IntPtr NativeFieldInfoPtr_BodySize;

		// Token: 0x04001893 RID: 6291
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001894 RID: 6292
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001895 RID: 6293
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001896 RID: 6294
		[FieldOffset(0)]
		public uint Request;

		// Token: 0x04001897 RID: 6295
		[FieldOffset(8)]
		public ulong ContextValue;

		// Token: 0x04001898 RID: 6296
		[FieldOffset(16)]
		[MarshalAs(4)]
		public bool RequestSuccessful;

		// Token: 0x04001899 RID: 6297
		[FieldOffset(20)]
		public HTTPStatusCode StatusCode;

		// Token: 0x0400189A RID: 6298
		[FieldOffset(24)]
		public uint BodySize;
	}
}
