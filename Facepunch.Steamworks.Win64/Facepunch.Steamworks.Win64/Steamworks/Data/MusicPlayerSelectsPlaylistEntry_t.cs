using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000161 RID: 353
	[StructLayout(2)]
	public struct MusicPlayerSelectsPlaylistEntry_t
	{
		// Token: 0x0600127C RID: 4732 RVA: 0x00065404 File Offset: 0x00063604
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerSelectsPlaylistEntry_t()
		{
			Il2CppClassPointerStore<MusicPlayerSelectsPlaylistEntry_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "MusicPlayerSelectsPlaylistEntry_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerSelectsPlaylistEntry_t>.NativeClassPtr);
			MusicPlayerSelectsPlaylistEntry_t.NativeFieldInfoPtr_NID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerSelectsPlaylistEntry_t>.NativeClassPtr, "NID");
			MusicPlayerSelectsPlaylistEntry_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerSelectsPlaylistEntry_t>.NativeClassPtr, "_datasize");
			MusicPlayerSelectsPlaylistEntry_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayerSelectsPlaylistEntry_t>.NativeClassPtr, 100667130);
			MusicPlayerSelectsPlaylistEntry_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayerSelectsPlaylistEntry_t>.NativeClassPtr, 100667131);
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x0600127D RID: 4733 RVA: 0x00065484 File Offset: 0x00063684
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950703, XrefRangeEnd = 950707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayerSelectsPlaylistEntry_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x0600127E RID: 4734 RVA: 0x000654B4 File Offset: 0x000636B4
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayerSelectsPlaylistEntry_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x0000595A File Offset: 0x00003B5A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicPlayerSelectsPlaylistEntry_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06001280 RID: 4736 RVA: 0x000654E4 File Offset: 0x000636E4
		// (set) Token: 0x06001281 RID: 4737 RVA: 0x0000596C File Offset: 0x00003B6C
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayerSelectsPlaylistEntry_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayerSelectsPlaylistEntry_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001884 RID: 6276
		private static readonly IntPtr NativeFieldInfoPtr_NID;

		// Token: 0x04001885 RID: 6277
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001886 RID: 6278
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001887 RID: 6279
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001888 RID: 6280
		[FieldOffset(0)]
		public int NID;
	}
}
