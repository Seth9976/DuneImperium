using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200011C RID: 284
	[StructLayout(2)]
	public struct SubmitPlayerResultResultCallback_t
	{
		// Token: 0x0600102C RID: 4140 RVA: 0x0005F600 File Offset: 0x0005D800
		// Note: this type is marked as 'beforefieldinit'.
		static SubmitPlayerResultResultCallback_t()
		{
			Il2CppClassPointerStore<SubmitPlayerResultResultCallback_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SubmitPlayerResultResultCallback_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubmitPlayerResultResultCallback_t>.NativeClassPtr);
			SubmitPlayerResultResultCallback_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitPlayerResultResultCallback_t>.NativeClassPtr, "Result");
			SubmitPlayerResultResultCallback_t.NativeFieldInfoPtr_UllUniqueGameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitPlayerResultResultCallback_t>.NativeClassPtr, "UllUniqueGameID");
			SubmitPlayerResultResultCallback_t.NativeFieldInfoPtr_SteamIDPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitPlayerResultResultCallback_t>.NativeClassPtr, "SteamIDPlayer");
			SubmitPlayerResultResultCallback_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitPlayerResultResultCallback_t>.NativeClassPtr, "_datasize");
			SubmitPlayerResultResultCallback_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmitPlayerResultResultCallback_t>.NativeClassPtr, 100666912);
			SubmitPlayerResultResultCallback_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmitPlayerResultResultCallback_t>.NativeClassPtr, 100666913);
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x0600102D RID: 4141 RVA: 0x0005F6A8 File Offset: 0x0005D8A8
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950379, XrefRangeEnd = 950383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmitPlayerResultResultCallback_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x0600102E RID: 4142 RVA: 0x0005F6D8 File Offset: 0x0005D8D8
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmitPlayerResultResultCallback_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x000047D6 File Offset: 0x000029D6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SubmitPlayerResultResultCallback_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06001030 RID: 4144 RVA: 0x0005F708 File Offset: 0x0005D908
		// (set) Token: 0x06001031 RID: 4145 RVA: 0x000047E8 File Offset: 0x000029E8
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SubmitPlayerResultResultCallback_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubmitPlayerResultResultCallback_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040016A1 RID: 5793
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x040016A2 RID: 5794
		private static readonly IntPtr NativeFieldInfoPtr_UllUniqueGameID;

		// Token: 0x040016A3 RID: 5795
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDPlayer;

		// Token: 0x040016A4 RID: 5796
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040016A5 RID: 5797
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040016A6 RID: 5798
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040016A7 RID: 5799
		[FieldOffset(0)]
		public Result Result;

		// Token: 0x040016A8 RID: 5800
		[FieldOffset(4)]
		public ulong UllUniqueGameID;

		// Token: 0x040016A9 RID: 5801
		[FieldOffset(12)]
		public ulong SteamIDPlayer;
	}
}
