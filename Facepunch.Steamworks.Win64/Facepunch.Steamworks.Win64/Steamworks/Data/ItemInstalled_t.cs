using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200016D RID: 365
	[StructLayout(2)]
	public struct ItemInstalled_t
	{
		// Token: 0x060012D7 RID: 4823 RVA: 0x000663A4 File Offset: 0x000645A4
		// Note: this type is marked as 'beforefieldinit'.
		static ItemInstalled_t()
		{
			Il2CppClassPointerStore<ItemInstalled_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "ItemInstalled_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemInstalled_t>.NativeClassPtr);
			ItemInstalled_t.NativeFieldInfoPtr_AppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInstalled_t>.NativeClassPtr, "AppID");
			ItemInstalled_t.NativeFieldInfoPtr_PublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInstalled_t>.NativeClassPtr, "PublishedFileId");
			ItemInstalled_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInstalled_t>.NativeClassPtr, "_datasize");
			ItemInstalled_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstalled_t>.NativeClassPtr, 100667167);
			ItemInstalled_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstalled_t>.NativeClassPtr, 100667168);
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x060012D8 RID: 4824 RVA: 0x00066438 File Offset: 0x00064638
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950755, XrefRangeEnd = 950759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInstalled_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x060012D9 RID: 4825 RVA: 0x00066468 File Offset: 0x00064668
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInstalled_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x00005BDB File Offset: 0x00003DDB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ItemInstalled_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x060012DB RID: 4827 RVA: 0x00066498 File Offset: 0x00064698
		// (set) Token: 0x060012DC RID: 4828 RVA: 0x00005BED File Offset: 0x00003DED
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ItemInstalled_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemInstalled_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040018E9 RID: 6377
		private static readonly IntPtr NativeFieldInfoPtr_AppID;

		// Token: 0x040018EA RID: 6378
		private static readonly IntPtr NativeFieldInfoPtr_PublishedFileId;

		// Token: 0x040018EB RID: 6379
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040018EC RID: 6380
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040018ED RID: 6381
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040018EE RID: 6382
		[FieldOffset(0)]
		public AppId AppID;

		// Token: 0x040018EF RID: 6383
		[FieldOffset(8)]
		public PublishedFileId PublishedFileId;
	}
}
