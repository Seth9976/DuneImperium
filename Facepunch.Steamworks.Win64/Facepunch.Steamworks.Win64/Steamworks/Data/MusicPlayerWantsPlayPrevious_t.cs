using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200015B RID: 347
	[StructLayout(2)]
	public struct MusicPlayerWantsPlayPrevious_t
	{
		// Token: 0x06001258 RID: 4696 RVA: 0x00064E44 File Offset: 0x00063044
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerWantsPlayPrevious_t()
		{
			Il2CppClassPointerStore<MusicPlayerWantsPlayPrevious_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "MusicPlayerWantsPlayPrevious_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerWantsPlayPrevious_t>.NativeClassPtr);
			MusicPlayerWantsPlayPrevious_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerWantsPlayPrevious_t>.NativeClassPtr, "_datasize");
			MusicPlayerWantsPlayPrevious_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayerWantsPlayPrevious_t>.NativeClassPtr, 100667112);
			MusicPlayerWantsPlayPrevious_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayerWantsPlayPrevious_t>.NativeClassPtr, 100667113);
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06001259 RID: 4697 RVA: 0x00064EB0 File Offset: 0x000630B0
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950679, XrefRangeEnd = 950683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayerWantsPlayPrevious_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x0600125A RID: 4698 RVA: 0x00064EE0 File Offset: 0x000630E0
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayerWantsPlayPrevious_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x0000589A File Offset: 0x00003A9A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicPlayerWantsPlayPrevious_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x0600125C RID: 4700 RVA: 0x00064F10 File Offset: 0x00063110
		// (set) Token: 0x0600125D RID: 4701 RVA: 0x000058AC File Offset: 0x00003AAC
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayerWantsPlayPrevious_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayerWantsPlayPrevious_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x0400186A RID: 6250
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x0400186B RID: 6251
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400186C RID: 6252
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}
