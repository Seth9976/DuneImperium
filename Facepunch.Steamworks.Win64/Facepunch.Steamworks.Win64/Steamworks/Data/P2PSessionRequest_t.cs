using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200014F RID: 335
	[StructLayout(2)]
	public struct P2PSessionRequest_t
	{
		// Token: 0x06001210 RID: 4624 RVA: 0x000642EC File Offset: 0x000624EC
		// Note: this type is marked as 'beforefieldinit'.
		static P2PSessionRequest_t()
		{
			Il2CppClassPointerStore<P2PSessionRequest_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "P2PSessionRequest_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<P2PSessionRequest_t>.NativeClassPtr);
			P2PSessionRequest_t.NativeFieldInfoPtr_SteamIDRemote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PSessionRequest_t>.NativeClassPtr, "SteamIDRemote");
			P2PSessionRequest_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PSessionRequest_t>.NativeClassPtr, "_datasize");
			P2PSessionRequest_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PSessionRequest_t>.NativeClassPtr, 100667076);
			P2PSessionRequest_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PSessionRequest_t>.NativeClassPtr, 100667077);
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06001211 RID: 4625 RVA: 0x0006436C File Offset: 0x0006256C
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950631, XrefRangeEnd = 950635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(P2PSessionRequest_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06001212 RID: 4626 RVA: 0x0006439C File Offset: 0x0006259C
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(P2PSessionRequest_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x0000571A File Offset: 0x0000391A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<P2PSessionRequest_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06001214 RID: 4628 RVA: 0x000643CC File Offset: 0x000625CC
		// (set) Token: 0x06001215 RID: 4629 RVA: 0x0000572C File Offset: 0x0000392C
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(P2PSessionRequest_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(P2PSessionRequest_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x0400183A RID: 6202
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDRemote;

		// Token: 0x0400183B RID: 6203
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x0400183C RID: 6204
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400183D RID: 6205
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x0400183E RID: 6206
		[FieldOffset(0)]
		public ulong SteamIDRemote;
	}
}
