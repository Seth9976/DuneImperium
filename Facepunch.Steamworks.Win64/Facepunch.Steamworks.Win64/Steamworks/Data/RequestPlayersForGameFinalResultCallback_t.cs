using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200011B RID: 283
	[StructLayout(2)]
	public struct RequestPlayersForGameFinalResultCallback_t
	{
		// Token: 0x06001026 RID: 4134 RVA: 0x0005F4DC File Offset: 0x0005D6DC
		// Note: this type is marked as 'beforefieldinit'.
		static RequestPlayersForGameFinalResultCallback_t()
		{
			Il2CppClassPointerStore<RequestPlayersForGameFinalResultCallback_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "RequestPlayersForGameFinalResultCallback_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestPlayersForGameFinalResultCallback_t>.NativeClassPtr);
			RequestPlayersForGameFinalResultCallback_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPlayersForGameFinalResultCallback_t>.NativeClassPtr, "Result");
			RequestPlayersForGameFinalResultCallback_t.NativeFieldInfoPtr_LSearchID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPlayersForGameFinalResultCallback_t>.NativeClassPtr, "LSearchID");
			RequestPlayersForGameFinalResultCallback_t.NativeFieldInfoPtr_LUniqueGameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPlayersForGameFinalResultCallback_t>.NativeClassPtr, "LUniqueGameID");
			RequestPlayersForGameFinalResultCallback_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPlayersForGameFinalResultCallback_t>.NativeClassPtr, "_datasize");
			RequestPlayersForGameFinalResultCallback_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestPlayersForGameFinalResultCallback_t>.NativeClassPtr, 100666909);
			RequestPlayersForGameFinalResultCallback_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestPlayersForGameFinalResultCallback_t>.NativeClassPtr, 100666910);
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06001027 RID: 4135 RVA: 0x0005F584 File Offset: 0x0005D784
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950375, XrefRangeEnd = 950379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestPlayersForGameFinalResultCallback_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06001028 RID: 4136 RVA: 0x0005F5B4 File Offset: 0x0005D7B4
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestPlayersForGameFinalResultCallback_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x000047B6 File Offset: 0x000029B6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RequestPlayersForGameFinalResultCallback_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x0600102A RID: 4138 RVA: 0x0005F5E4 File Offset: 0x0005D7E4
		// (set) Token: 0x0600102B RID: 4139 RVA: 0x000047C8 File Offset: 0x000029C8
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RequestPlayersForGameFinalResultCallback_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RequestPlayersForGameFinalResultCallback_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001698 RID: 5784
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x04001699 RID: 5785
		private static readonly IntPtr NativeFieldInfoPtr_LSearchID;

		// Token: 0x0400169A RID: 5786
		private static readonly IntPtr NativeFieldInfoPtr_LUniqueGameID;

		// Token: 0x0400169B RID: 5787
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x0400169C RID: 5788
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400169D RID: 5789
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x0400169E RID: 5790
		[FieldOffset(0)]
		public Result Result;

		// Token: 0x0400169F RID: 5791
		[FieldOffset(8)]
		public ulong LSearchID;

		// Token: 0x040016A0 RID: 5792
		[FieldOffset(16)]
		public ulong LUniqueGameID;
	}
}
