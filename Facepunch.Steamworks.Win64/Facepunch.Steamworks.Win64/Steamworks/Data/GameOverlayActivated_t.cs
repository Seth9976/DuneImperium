using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020000F0 RID: 240
	[StructLayout(2)]
	public struct GameOverlayActivated_t
	{
		// Token: 0x06000F0A RID: 3850 RVA: 0x0005C1A0 File Offset: 0x0005A3A0
		// Note: this type is marked as 'beforefieldinit'.
		static GameOverlayActivated_t()
		{
			Il2CppClassPointerStore<GameOverlayActivated_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "GameOverlayActivated_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameOverlayActivated_t>.NativeClassPtr);
			GameOverlayActivated_t.NativeFieldInfoPtr_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameOverlayActivated_t>.NativeClassPtr, "Active");
			GameOverlayActivated_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameOverlayActivated_t>.NativeClassPtr, "_datasize");
			GameOverlayActivated_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOverlayActivated_t>.NativeClassPtr, 100666776);
			GameOverlayActivated_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOverlayActivated_t>.NativeClassPtr, 100666777);
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000F0B RID: 3851 RVA: 0x0005C220 File Offset: 0x0005A420
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950183, XrefRangeEnd = 950187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOverlayActivated_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000F0C RID: 3852 RVA: 0x0005C250 File Offset: 0x0005A450
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOverlayActivated_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x0000412B File Offset: 0x0000232B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameOverlayActivated_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000F0E RID: 3854 RVA: 0x0005C280 File Offset: 0x0005A480
		// (set) Token: 0x06000F0F RID: 3855 RVA: 0x0000413D File Offset: 0x0000233D
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GameOverlayActivated_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameOverlayActivated_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x0400153A RID: 5434
		private static readonly IntPtr NativeFieldInfoPtr_Active;

		// Token: 0x0400153B RID: 5435
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x0400153C RID: 5436
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400153D RID: 5437
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x0400153E RID: 5438
		[FieldOffset(0)]
		public byte Active;
	}
}
