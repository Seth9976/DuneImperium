using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000162 RID: 354
	[StructLayout(2)]
	public struct MusicPlayerWantsPlayingRepeatStatus_t
	{
		// Token: 0x06001282 RID: 4738 RVA: 0x00065500 File Offset: 0x00063700
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerWantsPlayingRepeatStatus_t()
		{
			Il2CppClassPointerStore<MusicPlayerWantsPlayingRepeatStatus_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "MusicPlayerWantsPlayingRepeatStatus_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerWantsPlayingRepeatStatus_t>.NativeClassPtr);
			MusicPlayerWantsPlayingRepeatStatus_t.NativeFieldInfoPtr_PlayingRepeatStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerWantsPlayingRepeatStatus_t>.NativeClassPtr, "PlayingRepeatStatus");
			MusicPlayerWantsPlayingRepeatStatus_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerWantsPlayingRepeatStatus_t>.NativeClassPtr, "_datasize");
			MusicPlayerWantsPlayingRepeatStatus_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayerWantsPlayingRepeatStatus_t>.NativeClassPtr, 100667133);
			MusicPlayerWantsPlayingRepeatStatus_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayerWantsPlayingRepeatStatus_t>.NativeClassPtr, 100667134);
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06001283 RID: 4739 RVA: 0x00065580 File Offset: 0x00063780
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950707, XrefRangeEnd = 950711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayerWantsPlayingRepeatStatus_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06001284 RID: 4740 RVA: 0x000655B0 File Offset: 0x000637B0
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayerWantsPlayingRepeatStatus_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x0000597A File Offset: 0x00003B7A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicPlayerWantsPlayingRepeatStatus_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06001286 RID: 4742 RVA: 0x000655E0 File Offset: 0x000637E0
		// (set) Token: 0x06001287 RID: 4743 RVA: 0x0000598C File Offset: 0x00003B8C
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayerWantsPlayingRepeatStatus_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayerWantsPlayingRepeatStatus_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001889 RID: 6281
		private static readonly IntPtr NativeFieldInfoPtr_PlayingRepeatStatus;

		// Token: 0x0400188A RID: 6282
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x0400188B RID: 6283
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400188C RID: 6284
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x0400188D RID: 6285
		[FieldOffset(0)]
		public int PlayingRepeatStatus;
	}
}
