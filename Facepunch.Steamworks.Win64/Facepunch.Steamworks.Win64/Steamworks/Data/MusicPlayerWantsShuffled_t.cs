using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200015D RID: 349
	[StructLayout(2)]
	public struct MusicPlayerWantsShuffled_t
	{
		// Token: 0x06001264 RID: 4708 RVA: 0x00065014 File Offset: 0x00063214
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerWantsShuffled_t()
		{
			Il2CppClassPointerStore<MusicPlayerWantsShuffled_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "MusicPlayerWantsShuffled_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerWantsShuffled_t>.NativeClassPtr);
			MusicPlayerWantsShuffled_t.NativeFieldInfoPtr_Shuffled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerWantsShuffled_t>.NativeClassPtr, "Shuffled");
			MusicPlayerWantsShuffled_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerWantsShuffled_t>.NativeClassPtr, "_datasize");
			MusicPlayerWantsShuffled_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayerWantsShuffled_t>.NativeClassPtr, 100667118);
			MusicPlayerWantsShuffled_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayerWantsShuffled_t>.NativeClassPtr, 100667119);
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06001265 RID: 4709 RVA: 0x00065094 File Offset: 0x00063294
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950687, XrefRangeEnd = 950691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayerWantsShuffled_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06001266 RID: 4710 RVA: 0x000650C4 File Offset: 0x000632C4
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayerWantsShuffled_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x000058DA File Offset: 0x00003ADA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicPlayerWantsShuffled_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06001268 RID: 4712 RVA: 0x000650F4 File Offset: 0x000632F4
		// (set) Token: 0x06001269 RID: 4713 RVA: 0x000058EC File Offset: 0x00003AEC
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayerWantsShuffled_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayerWantsShuffled_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001870 RID: 6256
		private static readonly IntPtr NativeFieldInfoPtr_Shuffled;

		// Token: 0x04001871 RID: 6257
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001872 RID: 6258
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001873 RID: 6259
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001874 RID: 6260
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool Shuffled;
	}
}
