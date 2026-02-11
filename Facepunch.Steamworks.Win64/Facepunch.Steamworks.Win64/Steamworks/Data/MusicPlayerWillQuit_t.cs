using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000158 RID: 344
	[StructLayout(2)]
	public struct MusicPlayerWillQuit_t
	{
		// Token: 0x06001246 RID: 4678 RVA: 0x00064B8C File Offset: 0x00062D8C
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerWillQuit_t()
		{
			Il2CppClassPointerStore<MusicPlayerWillQuit_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "MusicPlayerWillQuit_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerWillQuit_t>.NativeClassPtr);
			MusicPlayerWillQuit_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerWillQuit_t>.NativeClassPtr, "_datasize");
			MusicPlayerWillQuit_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayerWillQuit_t>.NativeClassPtr, 100667103);
			MusicPlayerWillQuit_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayerWillQuit_t>.NativeClassPtr, 100667104);
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06001247 RID: 4679 RVA: 0x00064BF8 File Offset: 0x00062DF8
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950667, XrefRangeEnd = 950671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayerWillQuit_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06001248 RID: 4680 RVA: 0x00064C28 File Offset: 0x00062E28
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayerWillQuit_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x0000583A File Offset: 0x00003A3A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicPlayerWillQuit_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x0600124A RID: 4682 RVA: 0x00064C58 File Offset: 0x00062E58
		// (set) Token: 0x0600124B RID: 4683 RVA: 0x0000584C File Offset: 0x00003A4C
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayerWillQuit_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayerWillQuit_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001861 RID: 6241
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001862 RID: 6242
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001863 RID: 6243
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}
