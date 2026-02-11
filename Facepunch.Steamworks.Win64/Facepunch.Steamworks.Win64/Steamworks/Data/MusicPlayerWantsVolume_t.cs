using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200015F RID: 351
	[StructLayout(2)]
	public struct MusicPlayerWantsVolume_t
	{
		// Token: 0x06001270 RID: 4720 RVA: 0x0006520C File Offset: 0x0006340C
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerWantsVolume_t()
		{
			Il2CppClassPointerStore<MusicPlayerWantsVolume_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "MusicPlayerWantsVolume_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerWantsVolume_t>.NativeClassPtr);
			MusicPlayerWantsVolume_t.NativeFieldInfoPtr_NewVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerWantsVolume_t>.NativeClassPtr, "NewVolume");
			MusicPlayerWantsVolume_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerWantsVolume_t>.NativeClassPtr, "_datasize");
			MusicPlayerWantsVolume_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayerWantsVolume_t>.NativeClassPtr, 100667124);
			MusicPlayerWantsVolume_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayerWantsVolume_t>.NativeClassPtr, 100667125);
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06001271 RID: 4721 RVA: 0x0006528C File Offset: 0x0006348C
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950695, XrefRangeEnd = 950699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayerWantsVolume_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06001272 RID: 4722 RVA: 0x000652BC File Offset: 0x000634BC
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayerWantsVolume_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x0000591A File Offset: 0x00003B1A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicPlayerWantsVolume_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06001274 RID: 4724 RVA: 0x000652EC File Offset: 0x000634EC
		// (set) Token: 0x06001275 RID: 4725 RVA: 0x0000592C File Offset: 0x00003B2C
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayerWantsVolume_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayerWantsVolume_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x0400187A RID: 6266
		private static readonly IntPtr NativeFieldInfoPtr_NewVolume;

		// Token: 0x0400187B RID: 6267
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x0400187C RID: 6268
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400187D RID: 6269
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x0400187E RID: 6270
		[FieldOffset(0)]
		public float NewVolume;
	}
}
