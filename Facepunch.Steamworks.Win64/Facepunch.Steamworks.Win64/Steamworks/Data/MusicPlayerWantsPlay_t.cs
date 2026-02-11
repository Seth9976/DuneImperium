using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000159 RID: 345
	[StructLayout(2)]
	public struct MusicPlayerWantsPlay_t
	{
		// Token: 0x0600124C RID: 4684 RVA: 0x00064C74 File Offset: 0x00062E74
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerWantsPlay_t()
		{
			Il2CppClassPointerStore<MusicPlayerWantsPlay_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "MusicPlayerWantsPlay_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerWantsPlay_t>.NativeClassPtr);
			MusicPlayerWantsPlay_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerWantsPlay_t>.NativeClassPtr, "_datasize");
			MusicPlayerWantsPlay_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayerWantsPlay_t>.NativeClassPtr, 100667106);
			MusicPlayerWantsPlay_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayerWantsPlay_t>.NativeClassPtr, 100667107);
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x0600124D RID: 4685 RVA: 0x00064CE0 File Offset: 0x00062EE0
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950671, XrefRangeEnd = 950675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayerWantsPlay_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x0600124E RID: 4686 RVA: 0x00064D10 File Offset: 0x00062F10
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayerWantsPlay_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x0000585A File Offset: 0x00003A5A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicPlayerWantsPlay_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06001250 RID: 4688 RVA: 0x00064D40 File Offset: 0x00062F40
		// (set) Token: 0x06001251 RID: 4689 RVA: 0x0000586C File Offset: 0x00003A6C
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayerWantsPlay_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayerWantsPlay_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001864 RID: 6244
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001865 RID: 6245
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001866 RID: 6246
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}
