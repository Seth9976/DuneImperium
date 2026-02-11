using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000165 RID: 357
	[StructLayout(2)]
	public struct HTTPRequestDataReceived_t
	{
		// Token: 0x06001294 RID: 4756 RVA: 0x00065858 File Offset: 0x00063A58
		// Note: this type is marked as 'beforefieldinit'.
		static HTTPRequestDataReceived_t()
		{
			Il2CppClassPointerStore<HTTPRequestDataReceived_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "HTTPRequestDataReceived_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTTPRequestDataReceived_t>.NativeClassPtr);
			HTTPRequestDataReceived_t.NativeFieldInfoPtr_Request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestDataReceived_t>.NativeClassPtr, "Request");
			HTTPRequestDataReceived_t.NativeFieldInfoPtr_ContextValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestDataReceived_t>.NativeClassPtr, "ContextValue");
			HTTPRequestDataReceived_t.NativeFieldInfoPtr_COffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestDataReceived_t>.NativeClassPtr, "COffset");
			HTTPRequestDataReceived_t.NativeFieldInfoPtr_CBytesReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestDataReceived_t>.NativeClassPtr, "CBytesReceived");
			HTTPRequestDataReceived_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestDataReceived_t>.NativeClassPtr, "_datasize");
			HTTPRequestDataReceived_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPRequestDataReceived_t>.NativeClassPtr, 100667142);
			HTTPRequestDataReceived_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPRequestDataReceived_t>.NativeClassPtr, 100667143);
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06001295 RID: 4757 RVA: 0x00065914 File Offset: 0x00063B14
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950719, XrefRangeEnd = 950723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPRequestDataReceived_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06001296 RID: 4758 RVA: 0x00065944 File Offset: 0x00063B44
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPRequestDataReceived_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x000059DA File Offset: 0x00003BDA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HTTPRequestDataReceived_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06001298 RID: 4760 RVA: 0x00065974 File Offset: 0x00063B74
		// (set) Token: 0x06001299 RID: 4761 RVA: 0x000059EC File Offset: 0x00003BEC
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTTPRequestDataReceived_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTTPRequestDataReceived_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040018A2 RID: 6306
		private static readonly IntPtr NativeFieldInfoPtr_Request;

		// Token: 0x040018A3 RID: 6307
		private static readonly IntPtr NativeFieldInfoPtr_ContextValue;

		// Token: 0x040018A4 RID: 6308
		private static readonly IntPtr NativeFieldInfoPtr_COffset;

		// Token: 0x040018A5 RID: 6309
		private static readonly IntPtr NativeFieldInfoPtr_CBytesReceived;

		// Token: 0x040018A6 RID: 6310
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040018A7 RID: 6311
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040018A8 RID: 6312
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040018A9 RID: 6313
		[FieldOffset(0)]
		public uint Request;

		// Token: 0x040018AA RID: 6314
		[FieldOffset(8)]
		public ulong ContextValue;

		// Token: 0x040018AB RID: 6315
		[FieldOffset(16)]
		public uint COffset;

		// Token: 0x040018AC RID: 6316
		[FieldOffset(20)]
		public uint CBytesReceived;
	}
}
