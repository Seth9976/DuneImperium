using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000154 RID: 340
	[StructLayout(2)]
	public struct VolumeHasChanged_t
	{
		// Token: 0x0600122E RID: 4654 RVA: 0x000647D8 File Offset: 0x000629D8
		// Note: this type is marked as 'beforefieldinit'.
		static VolumeHasChanged_t()
		{
			Il2CppClassPointerStore<VolumeHasChanged_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "VolumeHasChanged_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeHasChanged_t>.NativeClassPtr);
			VolumeHasChanged_t.NativeFieldInfoPtr_NewVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeHasChanged_t>.NativeClassPtr, "NewVolume");
			VolumeHasChanged_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeHasChanged_t>.NativeClassPtr, "_datasize");
			VolumeHasChanged_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeHasChanged_t>.NativeClassPtr, 100667091);
			VolumeHasChanged_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeHasChanged_t>.NativeClassPtr, 100667092);
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x0600122F RID: 4655 RVA: 0x00064858 File Offset: 0x00062A58
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950651, XrefRangeEnd = 950655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeHasChanged_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06001230 RID: 4656 RVA: 0x00064888 File Offset: 0x00062A88
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeHasChanged_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x000057BA File Offset: 0x000039BA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VolumeHasChanged_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06001232 RID: 4658 RVA: 0x000648B8 File Offset: 0x00062AB8
		// (set) Token: 0x06001233 RID: 4659 RVA: 0x000057CC File Offset: 0x000039CC
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(VolumeHasChanged_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VolumeHasChanged_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001853 RID: 6227
		private static readonly IntPtr NativeFieldInfoPtr_NewVolume;

		// Token: 0x04001854 RID: 6228
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001855 RID: 6229
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001856 RID: 6230
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001857 RID: 6231
		[FieldOffset(0)]
		public float NewVolume;
	}
}
