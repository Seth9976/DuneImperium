using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200015E RID: 350
	[StructLayout(2)]
	public struct MusicPlayerWantsLooped_t
	{
		// Token: 0x0600126A RID: 4714 RVA: 0x00065110 File Offset: 0x00063310
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerWantsLooped_t()
		{
			Il2CppClassPointerStore<MusicPlayerWantsLooped_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "MusicPlayerWantsLooped_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerWantsLooped_t>.NativeClassPtr);
			MusicPlayerWantsLooped_t.NativeFieldInfoPtr_Looped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerWantsLooped_t>.NativeClassPtr, "Looped");
			MusicPlayerWantsLooped_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerWantsLooped_t>.NativeClassPtr, "_datasize");
			MusicPlayerWantsLooped_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayerWantsLooped_t>.NativeClassPtr, 100667121);
			MusicPlayerWantsLooped_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayerWantsLooped_t>.NativeClassPtr, 100667122);
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x0600126B RID: 4715 RVA: 0x00065190 File Offset: 0x00063390
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950691, XrefRangeEnd = 950695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayerWantsLooped_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x0600126C RID: 4716 RVA: 0x000651C0 File Offset: 0x000633C0
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayerWantsLooped_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x000058FA File Offset: 0x00003AFA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicPlayerWantsLooped_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x0600126E RID: 4718 RVA: 0x000651F0 File Offset: 0x000633F0
		// (set) Token: 0x0600126F RID: 4719 RVA: 0x0000590C File Offset: 0x00003B0C
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayerWantsLooped_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayerWantsLooped_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001875 RID: 6261
		private static readonly IntPtr NativeFieldInfoPtr_Looped;

		// Token: 0x04001876 RID: 6262
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001877 RID: 6263
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001878 RID: 6264
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001879 RID: 6265
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool Looped;
	}
}
