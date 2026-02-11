using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000155 RID: 341
	[StructLayout(2)]
	public struct MusicPlayerRemoteWillActivate_t
	{
		// Token: 0x06001234 RID: 4660 RVA: 0x000648D4 File Offset: 0x00062AD4
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerRemoteWillActivate_t()
		{
			Il2CppClassPointerStore<MusicPlayerRemoteWillActivate_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "MusicPlayerRemoteWillActivate_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerRemoteWillActivate_t>.NativeClassPtr);
			MusicPlayerRemoteWillActivate_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerRemoteWillActivate_t>.NativeClassPtr, "_datasize");
			MusicPlayerRemoteWillActivate_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayerRemoteWillActivate_t>.NativeClassPtr, 100667094);
			MusicPlayerRemoteWillActivate_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayerRemoteWillActivate_t>.NativeClassPtr, 100667095);
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06001235 RID: 4661 RVA: 0x00064940 File Offset: 0x00062B40
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950655, XrefRangeEnd = 950659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayerRemoteWillActivate_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06001236 RID: 4662 RVA: 0x00064970 File Offset: 0x00062B70
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayerRemoteWillActivate_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x000057DA File Offset: 0x000039DA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicPlayerRemoteWillActivate_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06001238 RID: 4664 RVA: 0x000649A0 File Offset: 0x00062BA0
		// (set) Token: 0x06001239 RID: 4665 RVA: 0x000057EC File Offset: 0x000039EC
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayerRemoteWillActivate_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayerRemoteWillActivate_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001858 RID: 6232
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001859 RID: 6233
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400185A RID: 6234
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}
