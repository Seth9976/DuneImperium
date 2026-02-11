using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000119 RID: 281
	[StructLayout(2)]
	public struct RequestPlayersForGameProgressCallback_t
	{
		// Token: 0x0600101A RID: 4122 RVA: 0x0005F21C File Offset: 0x0005D41C
		// Note: this type is marked as 'beforefieldinit'.
		static RequestPlayersForGameProgressCallback_t()
		{
			Il2CppClassPointerStore<RequestPlayersForGameProgressCallback_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "RequestPlayersForGameProgressCallback_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestPlayersForGameProgressCallback_t>.NativeClassPtr);
			RequestPlayersForGameProgressCallback_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPlayersForGameProgressCallback_t>.NativeClassPtr, "Result");
			RequestPlayersForGameProgressCallback_t.NativeFieldInfoPtr_LSearchID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPlayersForGameProgressCallback_t>.NativeClassPtr, "LSearchID");
			RequestPlayersForGameProgressCallback_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPlayersForGameProgressCallback_t>.NativeClassPtr, "_datasize");
			RequestPlayersForGameProgressCallback_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestPlayersForGameProgressCallback_t>.NativeClassPtr, 100666903);
			RequestPlayersForGameProgressCallback_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestPlayersForGameProgressCallback_t>.NativeClassPtr, 100666904);
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x0600101B RID: 4123 RVA: 0x0005F2B0 File Offset: 0x0005D4B0
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950367, XrefRangeEnd = 950371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestPlayersForGameProgressCallback_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x0600101C RID: 4124 RVA: 0x0005F2E0 File Offset: 0x0005D4E0
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestPlayersForGameProgressCallback_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x00004776 File Offset: 0x00002976
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RequestPlayersForGameProgressCallback_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x0600101E RID: 4126 RVA: 0x0005F310 File Offset: 0x0005D510
		// (set) Token: 0x0600101F RID: 4127 RVA: 0x00004788 File Offset: 0x00002988
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RequestPlayersForGameProgressCallback_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RequestPlayersForGameProgressCallback_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x0400167A RID: 5754
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x0400167B RID: 5755
		private static readonly IntPtr NativeFieldInfoPtr_LSearchID;

		// Token: 0x0400167C RID: 5756
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x0400167D RID: 5757
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400167E RID: 5758
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x0400167F RID: 5759
		[FieldOffset(0)]
		public Result Result;

		// Token: 0x04001680 RID: 5760
		[FieldOffset(8)]
		public ulong LSearchID;
	}
}
