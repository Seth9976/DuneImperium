using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000199 RID: 409
	[StructLayout(2)]
	public struct SteamInventoryStartPurchaseResult_t
	{
		// Token: 0x06001468 RID: 5224 RVA: 0x0006A20C File Offset: 0x0006840C
		// Note: this type is marked as 'beforefieldinit'.
		static SteamInventoryStartPurchaseResult_t()
		{
			Il2CppClassPointerStore<SteamInventoryStartPurchaseResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SteamInventoryStartPurchaseResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInventoryStartPurchaseResult_t>.NativeClassPtr);
			SteamInventoryStartPurchaseResult_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryStartPurchaseResult_t>.NativeClassPtr, "Result");
			SteamInventoryStartPurchaseResult_t.NativeFieldInfoPtr_OrderID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryStartPurchaseResult_t>.NativeClassPtr, "OrderID");
			SteamInventoryStartPurchaseResult_t.NativeFieldInfoPtr_TransID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryStartPurchaseResult_t>.NativeClassPtr, "TransID");
			SteamInventoryStartPurchaseResult_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryStartPurchaseResult_t>.NativeClassPtr, "_datasize");
			SteamInventoryStartPurchaseResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryStartPurchaseResult_t>.NativeClassPtr, 100667299);
			SteamInventoryStartPurchaseResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryStartPurchaseResult_t>.NativeClassPtr, 100667300);
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06001469 RID: 5225 RVA: 0x0006A2B4 File Offset: 0x000684B4
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950935, XrefRangeEnd = 950939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryStartPurchaseResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x0600146A RID: 5226 RVA: 0x0006A2E4 File Offset: 0x000684E4
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryStartPurchaseResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600146B RID: 5227 RVA: 0x000068A5 File Offset: 0x00004AA5
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamInventoryStartPurchaseResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x0600146C RID: 5228 RVA: 0x0006A314 File Offset: 0x00068514
		// (set) Token: 0x0600146D RID: 5229 RVA: 0x000068B7 File Offset: 0x00004AB7
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamInventoryStartPurchaseResult_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamInventoryStartPurchaseResult_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001A40 RID: 6720
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x04001A41 RID: 6721
		private static readonly IntPtr NativeFieldInfoPtr_OrderID;

		// Token: 0x04001A42 RID: 6722
		private static readonly IntPtr NativeFieldInfoPtr_TransID;

		// Token: 0x04001A43 RID: 6723
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001A44 RID: 6724
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001A45 RID: 6725
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001A46 RID: 6726
		[FieldOffset(0)]
		public Result Result;

		// Token: 0x04001A47 RID: 6727
		[FieldOffset(8)]
		public ulong OrderID;

		// Token: 0x04001A48 RID: 6728
		[FieldOffset(16)]
		public ulong TransID;
	}
}
