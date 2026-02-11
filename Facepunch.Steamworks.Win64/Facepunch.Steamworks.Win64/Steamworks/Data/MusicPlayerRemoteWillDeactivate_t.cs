using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000156 RID: 342
	[StructLayout(2)]
	public struct MusicPlayerRemoteWillDeactivate_t
	{
		// Token: 0x0600123A RID: 4666 RVA: 0x000649BC File Offset: 0x00062BBC
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerRemoteWillDeactivate_t()
		{
			Il2CppClassPointerStore<MusicPlayerRemoteWillDeactivate_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "MusicPlayerRemoteWillDeactivate_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerRemoteWillDeactivate_t>.NativeClassPtr);
			MusicPlayerRemoteWillDeactivate_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerRemoteWillDeactivate_t>.NativeClassPtr, "_datasize");
			MusicPlayerRemoteWillDeactivate_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayerRemoteWillDeactivate_t>.NativeClassPtr, 100667097);
			MusicPlayerRemoteWillDeactivate_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayerRemoteWillDeactivate_t>.NativeClassPtr, 100667098);
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x0600123B RID: 4667 RVA: 0x00064A28 File Offset: 0x00062C28
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950659, XrefRangeEnd = 950663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayerRemoteWillDeactivate_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x0600123C RID: 4668 RVA: 0x00064A58 File Offset: 0x00062C58
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayerRemoteWillDeactivate_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x000057FA File Offset: 0x000039FA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicPlayerRemoteWillDeactivate_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x0600123E RID: 4670 RVA: 0x00064A88 File Offset: 0x00062C88
		// (set) Token: 0x0600123F RID: 4671 RVA: 0x0000580C File Offset: 0x00003A0C
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayerRemoteWillDeactivate_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayerRemoteWillDeactivate_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x0400185B RID: 6235
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x0400185C RID: 6236
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400185D RID: 6237
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}
