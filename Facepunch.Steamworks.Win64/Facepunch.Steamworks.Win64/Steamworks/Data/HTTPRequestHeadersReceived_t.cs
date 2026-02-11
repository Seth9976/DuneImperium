using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000164 RID: 356
	[StructLayout(2)]
	public struct HTTPRequestHeadersReceived_t
	{
		// Token: 0x0600128E RID: 4750 RVA: 0x00065748 File Offset: 0x00063948
		// Note: this type is marked as 'beforefieldinit'.
		static HTTPRequestHeadersReceived_t()
		{
			Il2CppClassPointerStore<HTTPRequestHeadersReceived_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "HTTPRequestHeadersReceived_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTTPRequestHeadersReceived_t>.NativeClassPtr);
			HTTPRequestHeadersReceived_t.NativeFieldInfoPtr_Request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestHeadersReceived_t>.NativeClassPtr, "Request");
			HTTPRequestHeadersReceived_t.NativeFieldInfoPtr_ContextValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestHeadersReceived_t>.NativeClassPtr, "ContextValue");
			HTTPRequestHeadersReceived_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestHeadersReceived_t>.NativeClassPtr, "_datasize");
			HTTPRequestHeadersReceived_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPRequestHeadersReceived_t>.NativeClassPtr, 100667139);
			HTTPRequestHeadersReceived_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPRequestHeadersReceived_t>.NativeClassPtr, 100667140);
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x0600128F RID: 4751 RVA: 0x000657DC File Offset: 0x000639DC
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950715, XrefRangeEnd = 950719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPRequestHeadersReceived_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06001290 RID: 4752 RVA: 0x0006580C File Offset: 0x00063A0C
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPRequestHeadersReceived_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x000059BA File Offset: 0x00003BBA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HTTPRequestHeadersReceived_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06001292 RID: 4754 RVA: 0x0006583C File Offset: 0x00063A3C
		// (set) Token: 0x06001293 RID: 4755 RVA: 0x000059CC File Offset: 0x00003BCC
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTTPRequestHeadersReceived_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTTPRequestHeadersReceived_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x0400189B RID: 6299
		private static readonly IntPtr NativeFieldInfoPtr_Request;

		// Token: 0x0400189C RID: 6300
		private static readonly IntPtr NativeFieldInfoPtr_ContextValue;

		// Token: 0x0400189D RID: 6301
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x0400189E RID: 6302
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400189F RID: 6303
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040018A0 RID: 6304
		[FieldOffset(0)]
		public uint Request;

		// Token: 0x040018A1 RID: 6305
		[FieldOffset(8)]
		public ulong ContextValue;
	}
}
