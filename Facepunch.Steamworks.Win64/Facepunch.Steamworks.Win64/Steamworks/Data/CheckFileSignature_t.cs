using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000107 RID: 263
	[StructLayout(2)]
	public struct CheckFileSignature_t
	{
		// Token: 0x06000FAE RID: 4014 RVA: 0x0005DDA8 File Offset: 0x0005BFA8
		// Note: this type is marked as 'beforefieldinit'.
		static CheckFileSignature_t()
		{
			Il2CppClassPointerStore<CheckFileSignature_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "CheckFileSignature_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CheckFileSignature_t>.NativeClassPtr);
			CheckFileSignature_t.NativeFieldInfoPtr_CheckFileSignature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckFileSignature_t>.NativeClassPtr, "CheckFileSignature");
			CheckFileSignature_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckFileSignature_t>.NativeClassPtr, "_datasize");
			CheckFileSignature_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckFileSignature_t>.NativeClassPtr, 100666849);
			CheckFileSignature_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckFileSignature_t>.NativeClassPtr, 100666850);
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000FAF RID: 4015 RVA: 0x0005DE28 File Offset: 0x0005C028
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950295, XrefRangeEnd = 950299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckFileSignature_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000FB0 RID: 4016 RVA: 0x0005DE58 File Offset: 0x0005C058
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckFileSignature_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x00004536 File Offset: 0x00002736
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CheckFileSignature_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000FB2 RID: 4018 RVA: 0x0005DE88 File Offset: 0x0005C088
		// (set) Token: 0x06000FB3 RID: 4019 RVA: 0x00004548 File Offset: 0x00002748
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CheckFileSignature_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CheckFileSignature_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040015DA RID: 5594
		private static readonly IntPtr NativeFieldInfoPtr_CheckFileSignature;

		// Token: 0x040015DB RID: 5595
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040015DC RID: 5596
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040015DD RID: 5597
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040015DE RID: 5598
		[FieldOffset(0)]
		public CheckFileSignature CheckFileSignature;
	}
}
