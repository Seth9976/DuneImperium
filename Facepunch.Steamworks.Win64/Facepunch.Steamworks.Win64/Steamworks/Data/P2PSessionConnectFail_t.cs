using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000150 RID: 336
	[StructLayout(2)]
	public struct P2PSessionConnectFail_t
	{
		// Token: 0x06001216 RID: 4630 RVA: 0x000643E8 File Offset: 0x000625E8
		// Note: this type is marked as 'beforefieldinit'.
		static P2PSessionConnectFail_t()
		{
			Il2CppClassPointerStore<P2PSessionConnectFail_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "P2PSessionConnectFail_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<P2PSessionConnectFail_t>.NativeClassPtr);
			P2PSessionConnectFail_t.NativeFieldInfoPtr_SteamIDRemote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PSessionConnectFail_t>.NativeClassPtr, "SteamIDRemote");
			P2PSessionConnectFail_t.NativeFieldInfoPtr_P2PSessionError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PSessionConnectFail_t>.NativeClassPtr, "P2PSessionError");
			P2PSessionConnectFail_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PSessionConnectFail_t>.NativeClassPtr, "_datasize");
			P2PSessionConnectFail_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PSessionConnectFail_t>.NativeClassPtr, 100667079);
			P2PSessionConnectFail_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PSessionConnectFail_t>.NativeClassPtr, 100667080);
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06001217 RID: 4631 RVA: 0x0006447C File Offset: 0x0006267C
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950635, XrefRangeEnd = 950639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(P2PSessionConnectFail_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06001218 RID: 4632 RVA: 0x000644AC File Offset: 0x000626AC
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(P2PSessionConnectFail_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x0000573A File Offset: 0x0000393A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<P2PSessionConnectFail_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x0600121A RID: 4634 RVA: 0x000644DC File Offset: 0x000626DC
		// (set) Token: 0x0600121B RID: 4635 RVA: 0x0000574C File Offset: 0x0000394C
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(P2PSessionConnectFail_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(P2PSessionConnectFail_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x0400183F RID: 6207
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDRemote;

		// Token: 0x04001840 RID: 6208
		private static readonly IntPtr NativeFieldInfoPtr_P2PSessionError;

		// Token: 0x04001841 RID: 6209
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001842 RID: 6210
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001843 RID: 6211
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001844 RID: 6212
		[FieldOffset(0)]
		public ulong SteamIDRemote;

		// Token: 0x04001845 RID: 6213
		[FieldOffset(8)]
		public byte P2PSessionError;
	}
}
