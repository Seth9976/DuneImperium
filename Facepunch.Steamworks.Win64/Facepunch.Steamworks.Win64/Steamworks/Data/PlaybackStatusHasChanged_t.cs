using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000153 RID: 339
	[StructLayout(2)]
	public struct PlaybackStatusHasChanged_t
	{
		// Token: 0x06001228 RID: 4648 RVA: 0x000646F0 File Offset: 0x000628F0
		// Note: this type is marked as 'beforefieldinit'.
		static PlaybackStatusHasChanged_t()
		{
			Il2CppClassPointerStore<PlaybackStatusHasChanged_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "PlaybackStatusHasChanged_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaybackStatusHasChanged_t>.NativeClassPtr);
			PlaybackStatusHasChanged_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaybackStatusHasChanged_t>.NativeClassPtr, "_datasize");
			PlaybackStatusHasChanged_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaybackStatusHasChanged_t>.NativeClassPtr, 100667088);
			PlaybackStatusHasChanged_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaybackStatusHasChanged_t>.NativeClassPtr, 100667089);
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06001229 RID: 4649 RVA: 0x0006475C File Offset: 0x0006295C
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950647, XrefRangeEnd = 950651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaybackStatusHasChanged_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x0600122A RID: 4650 RVA: 0x0006478C File Offset: 0x0006298C
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaybackStatusHasChanged_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x0000579A File Offset: 0x0000399A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlaybackStatusHasChanged_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x0600122C RID: 4652 RVA: 0x000647BC File Offset: 0x000629BC
		// (set) Token: 0x0600122D RID: 4653 RVA: 0x000057AC File Offset: 0x000039AC
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PlaybackStatusHasChanged_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlaybackStatusHasChanged_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001850 RID: 6224
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001851 RID: 6225
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001852 RID: 6226
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}
