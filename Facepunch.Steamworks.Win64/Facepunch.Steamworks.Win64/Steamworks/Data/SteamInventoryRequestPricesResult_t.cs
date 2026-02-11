using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200019A RID: 410
	public sealed class SteamInventoryRequestPricesResult_t : ValueType
	{
		// Token: 0x0600146E RID: 5230 RVA: 0x0006A330 File Offset: 0x00068530
		// Note: this type is marked as 'beforefieldinit'.
		static SteamInventoryRequestPricesResult_t()
		{
			Il2CppClassPointerStore<SteamInventoryRequestPricesResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SteamInventoryRequestPricesResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInventoryRequestPricesResult_t>.NativeClassPtr);
			SteamInventoryRequestPricesResult_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryRequestPricesResult_t>.NativeClassPtr, "Result");
			SteamInventoryRequestPricesResult_t.NativeFieldInfoPtr_Currency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryRequestPricesResult_t>.NativeClassPtr, "Currency");
			SteamInventoryRequestPricesResult_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryRequestPricesResult_t>.NativeClassPtr, "_datasize");
			SteamInventoryRequestPricesResult_t.NativeMethodInfoPtr_CurrencyUTF8_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryRequestPricesResult_t>.NativeClassPtr, 100667302);
			SteamInventoryRequestPricesResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryRequestPricesResult_t>.NativeClassPtr, 100667303);
			SteamInventoryRequestPricesResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryRequestPricesResult_t>.NativeClassPtr, 100667304);
		}

		// Token: 0x0600146F RID: 5231 RVA: 0x0006A3D8 File Offset: 0x000685D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 950943, RefRangeEnd = 950944, XrefRangeStart = 950939, XrefRangeEnd = 950943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CurrencyUTF8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryRequestPricesResult_t.NativeMethodInfoPtr_CurrencyUTF8_Internal_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06001470 RID: 5232 RVA: 0x0006A414 File Offset: 0x00068614
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950944, XrefRangeEnd = 950948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryRequestPricesResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06001471 RID: 5233 RVA: 0x0006A458 File Offset: 0x00068658
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryRequestPricesResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x000068C5 File Offset: 0x00004AC5
		public SteamInventoryRequestPricesResult_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x000068CE File Offset: 0x00004ACE
		public SteamInventoryRequestPricesResult_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamInventoryRequestPricesResult_t>.NativeClassPtr))
		{
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06001474 RID: 5236 RVA: 0x0006A49C File Offset: 0x0006869C
		// (set) Token: 0x06001475 RID: 5237 RVA: 0x000068E0 File Offset: 0x00004AE0
		public unsafe Result Result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventoryRequestPricesResult_t.NativeFieldInfoPtr_Result);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventoryRequestPricesResult_t.NativeFieldInfoPtr_Result)) = value;
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06001476 RID: 5238 RVA: 0x0006A4C4 File Offset: 0x000686C4
		// (set) Token: 0x06001477 RID: 5239 RVA: 0x000068FB File Offset: 0x00004AFB
		public unsafe Il2CppStructArray<byte> Currency
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventoryRequestPricesResult_t.NativeFieldInfoPtr_Currency);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventoryRequestPricesResult_t.NativeFieldInfoPtr_Currency), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06001478 RID: 5240 RVA: 0x0006A4F4 File Offset: 0x000686F4
		// (set) Token: 0x06001479 RID: 5241 RVA: 0x0000691A File Offset: 0x00004B1A
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamInventoryRequestPricesResult_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamInventoryRequestPricesResult_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001A49 RID: 6729
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x04001A4A RID: 6730
		private static readonly IntPtr NativeFieldInfoPtr_Currency;

		// Token: 0x04001A4B RID: 6731
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001A4C RID: 6732
		private static readonly IntPtr NativeMethodInfoPtr_CurrencyUTF8_Internal_String_0;

		// Token: 0x04001A4D RID: 6733
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001A4E RID: 6734
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}
