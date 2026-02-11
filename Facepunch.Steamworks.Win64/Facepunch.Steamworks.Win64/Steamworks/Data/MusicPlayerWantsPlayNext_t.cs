using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200015C RID: 348
	[StructLayout(2)]
	public struct MusicPlayerWantsPlayNext_t
	{
		// Token: 0x0600125E RID: 4702 RVA: 0x00064F2C File Offset: 0x0006312C
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerWantsPlayNext_t()
		{
			Il2CppClassPointerStore<MusicPlayerWantsPlayNext_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "MusicPlayerWantsPlayNext_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerWantsPlayNext_t>.NativeClassPtr);
			MusicPlayerWantsPlayNext_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerWantsPlayNext_t>.NativeClassPtr, "_datasize");
			MusicPlayerWantsPlayNext_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayerWantsPlayNext_t>.NativeClassPtr, 100667115);
			MusicPlayerWantsPlayNext_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayerWantsPlayNext_t>.NativeClassPtr, 100667116);
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x0600125F RID: 4703 RVA: 0x00064F98 File Offset: 0x00063198
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950683, XrefRangeEnd = 950687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayerWantsPlayNext_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06001260 RID: 4704 RVA: 0x00064FC8 File Offset: 0x000631C8
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayerWantsPlayNext_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x000058BA File Offset: 0x00003ABA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicPlayerWantsPlayNext_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06001262 RID: 4706 RVA: 0x00064FF8 File Offset: 0x000631F8
		// (set) Token: 0x06001263 RID: 4707 RVA: 0x000058CC File Offset: 0x00003ACC
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayerWantsPlayNext_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayerWantsPlayNext_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x0400186D RID: 6253
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x0400186E RID: 6254
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400186F RID: 6255
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}
