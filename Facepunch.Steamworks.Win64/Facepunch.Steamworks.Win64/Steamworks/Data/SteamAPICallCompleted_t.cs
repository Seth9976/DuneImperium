using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000105 RID: 261
	[StructLayout(2)]
	public struct SteamAPICallCompleted_t
	{
		// Token: 0x06000FA2 RID: 4002 RVA: 0x0005DB9C File Offset: 0x0005BD9C
		// Note: this type is marked as 'beforefieldinit'.
		static SteamAPICallCompleted_t()
		{
			Il2CppClassPointerStore<SteamAPICallCompleted_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SteamAPICallCompleted_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamAPICallCompleted_t>.NativeClassPtr);
			SteamAPICallCompleted_t.NativeFieldInfoPtr_AsyncCall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamAPICallCompleted_t>.NativeClassPtr, "AsyncCall");
			SteamAPICallCompleted_t.NativeFieldInfoPtr_Callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamAPICallCompleted_t>.NativeClassPtr, "Callback");
			SteamAPICallCompleted_t.NativeFieldInfoPtr_ParamCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamAPICallCompleted_t>.NativeClassPtr, "ParamCount");
			SteamAPICallCompleted_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamAPICallCompleted_t>.NativeClassPtr, "_datasize");
			SteamAPICallCompleted_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPICallCompleted_t>.NativeClassPtr, 100666843);
			SteamAPICallCompleted_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPICallCompleted_t>.NativeClassPtr, 100666844);
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000FA3 RID: 4003 RVA: 0x0005DC44 File Offset: 0x0005BE44
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950287, XrefRangeEnd = 950291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPICallCompleted_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000FA4 RID: 4004 RVA: 0x0005DC74 File Offset: 0x0005BE74
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPICallCompleted_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x000044F6 File Offset: 0x000026F6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamAPICallCompleted_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000FA6 RID: 4006 RVA: 0x0005DCA4 File Offset: 0x0005BEA4
		// (set) Token: 0x06000FA7 RID: 4007 RVA: 0x00004508 File Offset: 0x00002708
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamAPICallCompleted_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamAPICallCompleted_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040015CE RID: 5582
		private static readonly IntPtr NativeFieldInfoPtr_AsyncCall;

		// Token: 0x040015CF RID: 5583
		private static readonly IntPtr NativeFieldInfoPtr_Callback;

		// Token: 0x040015D0 RID: 5584
		private static readonly IntPtr NativeFieldInfoPtr_ParamCount;

		// Token: 0x040015D1 RID: 5585
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040015D2 RID: 5586
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040015D3 RID: 5587
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040015D4 RID: 5588
		[FieldOffset(0)]
		public ulong AsyncCall;

		// Token: 0x040015D5 RID: 5589
		[FieldOffset(8)]
		public int Callback;

		// Token: 0x040015D6 RID: 5590
		[FieldOffset(12)]
		public uint ParamCount;
	}
}
