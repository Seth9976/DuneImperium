using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200015A RID: 346
	[StructLayout(2)]
	public struct MusicPlayerWantsPause_t
	{
		// Token: 0x06001252 RID: 4690 RVA: 0x00064D5C File Offset: 0x00062F5C
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerWantsPause_t()
		{
			Il2CppClassPointerStore<MusicPlayerWantsPause_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "MusicPlayerWantsPause_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerWantsPause_t>.NativeClassPtr);
			MusicPlayerWantsPause_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerWantsPause_t>.NativeClassPtr, "_datasize");
			MusicPlayerWantsPause_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayerWantsPause_t>.NativeClassPtr, 100667109);
			MusicPlayerWantsPause_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayerWantsPause_t>.NativeClassPtr, 100667110);
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06001253 RID: 4691 RVA: 0x00064DC8 File Offset: 0x00062FC8
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950675, XrefRangeEnd = 950679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayerWantsPause_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06001254 RID: 4692 RVA: 0x00064DF8 File Offset: 0x00062FF8
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayerWantsPause_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x0000587A File Offset: 0x00003A7A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicPlayerWantsPause_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06001256 RID: 4694 RVA: 0x00064E28 File Offset: 0x00063028
		// (set) Token: 0x06001257 RID: 4695 RVA: 0x0000588C File Offset: 0x00003A8C
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayerWantsPause_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayerWantsPause_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001867 RID: 6247
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001868 RID: 6248
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001869 RID: 6249
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}
