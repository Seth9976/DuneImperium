using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000157 RID: 343
	[StructLayout(2)]
	public struct MusicPlayerRemoteToFront_t
	{
		// Token: 0x06001240 RID: 4672 RVA: 0x00064AA4 File Offset: 0x00062CA4
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerRemoteToFront_t()
		{
			Il2CppClassPointerStore<MusicPlayerRemoteToFront_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "MusicPlayerRemoteToFront_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerRemoteToFront_t>.NativeClassPtr);
			MusicPlayerRemoteToFront_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerRemoteToFront_t>.NativeClassPtr, "_datasize");
			MusicPlayerRemoteToFront_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayerRemoteToFront_t>.NativeClassPtr, 100667100);
			MusicPlayerRemoteToFront_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayerRemoteToFront_t>.NativeClassPtr, 100667101);
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06001241 RID: 4673 RVA: 0x00064B10 File Offset: 0x00062D10
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950663, XrefRangeEnd = 950667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayerRemoteToFront_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06001242 RID: 4674 RVA: 0x00064B40 File Offset: 0x00062D40
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayerRemoteToFront_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x0000581A File Offset: 0x00003A1A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicPlayerRemoteToFront_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06001244 RID: 4676 RVA: 0x00064B70 File Offset: 0x00062D70
		// (set) Token: 0x06001245 RID: 4677 RVA: 0x0000582C File Offset: 0x00003A2C
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayerRemoteToFront_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayerRemoteToFront_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x0400185E RID: 6238
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x0400185F RID: 6239
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001860 RID: 6240
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}
