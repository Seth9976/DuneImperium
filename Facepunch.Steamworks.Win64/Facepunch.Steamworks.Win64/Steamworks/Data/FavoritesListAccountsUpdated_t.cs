using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000116 RID: 278
	[StructLayout(2)]
	public struct FavoritesListAccountsUpdated_t
	{
		// Token: 0x06001008 RID: 4104 RVA: 0x0005EE60 File Offset: 0x0005D060
		// Note: this type is marked as 'beforefieldinit'.
		static FavoritesListAccountsUpdated_t()
		{
			Il2CppClassPointerStore<FavoritesListAccountsUpdated_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "FavoritesListAccountsUpdated_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FavoritesListAccountsUpdated_t>.NativeClassPtr);
			FavoritesListAccountsUpdated_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FavoritesListAccountsUpdated_t>.NativeClassPtr, "Result");
			FavoritesListAccountsUpdated_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FavoritesListAccountsUpdated_t>.NativeClassPtr, "_datasize");
			FavoritesListAccountsUpdated_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FavoritesListAccountsUpdated_t>.NativeClassPtr, 100666894);
			FavoritesListAccountsUpdated_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FavoritesListAccountsUpdated_t>.NativeClassPtr, 100666895);
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06001009 RID: 4105 RVA: 0x0005EEE0 File Offset: 0x0005D0E0
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950355, XrefRangeEnd = 950359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FavoritesListAccountsUpdated_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x0600100A RID: 4106 RVA: 0x0005EF10 File Offset: 0x0005D110
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FavoritesListAccountsUpdated_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x00004716 File Offset: 0x00002916
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FavoritesListAccountsUpdated_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x0600100C RID: 4108 RVA: 0x0005EF40 File Offset: 0x0005D140
		// (set) Token: 0x0600100D RID: 4109 RVA: 0x00004728 File Offset: 0x00002928
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FavoritesListAccountsUpdated_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FavoritesListAccountsUpdated_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001657 RID: 5719
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x04001658 RID: 5720
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001659 RID: 5721
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400165A RID: 5722
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x0400165B RID: 5723
		[FieldOffset(0)]
		public Result Result;
	}
}
