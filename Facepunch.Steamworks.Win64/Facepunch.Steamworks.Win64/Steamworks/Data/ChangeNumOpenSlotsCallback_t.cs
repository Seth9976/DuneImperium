using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000121 RID: 289
	[StructLayout(2)]
	public struct ChangeNumOpenSlotsCallback_t
	{
		// Token: 0x06001054 RID: 4180 RVA: 0x0005FCAC File Offset: 0x0005DEAC
		// Note: this type is marked as 'beforefieldinit'.
		static ChangeNumOpenSlotsCallback_t()
		{
			Il2CppClassPointerStore<ChangeNumOpenSlotsCallback_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "ChangeNumOpenSlotsCallback_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChangeNumOpenSlotsCallback_t>.NativeClassPtr);
			ChangeNumOpenSlotsCallback_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeNumOpenSlotsCallback_t>.NativeClassPtr, "Result");
			ChangeNumOpenSlotsCallback_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeNumOpenSlotsCallback_t>.NativeClassPtr, "_datasize");
			ChangeNumOpenSlotsCallback_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeNumOpenSlotsCallback_t>.NativeClassPtr, 100666928);
			ChangeNumOpenSlotsCallback_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeNumOpenSlotsCallback_t>.NativeClassPtr, 100666929);
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06001055 RID: 4181 RVA: 0x0005FD2C File Offset: 0x0005DF2C
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950404, XrefRangeEnd = 950408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangeNumOpenSlotsCallback_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06001056 RID: 4182 RVA: 0x0005FD5C File Offset: 0x0005DF5C
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangeNumOpenSlotsCallback_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x000048EF File Offset: 0x00002AEF
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChangeNumOpenSlotsCallback_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06001058 RID: 4184 RVA: 0x0005FD8C File Offset: 0x0005DF8C
		// (set) Token: 0x06001059 RID: 4185 RVA: 0x00004901 File Offset: 0x00002B01
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ChangeNumOpenSlotsCallback_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ChangeNumOpenSlotsCallback_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040016C7 RID: 5831
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x040016C8 RID: 5832
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040016C9 RID: 5833
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040016CA RID: 5834
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040016CB RID: 5835
		[FieldOffset(0)]
		public Result Result;
	}
}
