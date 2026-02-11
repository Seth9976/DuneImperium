using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000160 RID: 352
	[StructLayout(2)]
	public struct MusicPlayerSelectsQueueEntry_t
	{
		// Token: 0x06001276 RID: 4726 RVA: 0x00065308 File Offset: 0x00063508
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerSelectsQueueEntry_t()
		{
			Il2CppClassPointerStore<MusicPlayerSelectsQueueEntry_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "MusicPlayerSelectsQueueEntry_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerSelectsQueueEntry_t>.NativeClassPtr);
			MusicPlayerSelectsQueueEntry_t.NativeFieldInfoPtr_NID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerSelectsQueueEntry_t>.NativeClassPtr, "NID");
			MusicPlayerSelectsQueueEntry_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerSelectsQueueEntry_t>.NativeClassPtr, "_datasize");
			MusicPlayerSelectsQueueEntry_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayerSelectsQueueEntry_t>.NativeClassPtr, 100667127);
			MusicPlayerSelectsQueueEntry_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayerSelectsQueueEntry_t>.NativeClassPtr, 100667128);
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06001277 RID: 4727 RVA: 0x00065388 File Offset: 0x00063588
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950699, XrefRangeEnd = 950703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayerSelectsQueueEntry_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06001278 RID: 4728 RVA: 0x000653B8 File Offset: 0x000635B8
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayerSelectsQueueEntry_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x0000593A File Offset: 0x00003B3A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicPlayerSelectsQueueEntry_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x0600127A RID: 4730 RVA: 0x000653E8 File Offset: 0x000635E8
		// (set) Token: 0x0600127B RID: 4731 RVA: 0x0000594C File Offset: 0x00003B4C
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayerSelectsQueueEntry_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayerSelectsQueueEntry_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x0400187F RID: 6271
		private static readonly IntPtr NativeFieldInfoPtr_NID;

		// Token: 0x04001880 RID: 6272
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001881 RID: 6273
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001882 RID: 6274
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001883 RID: 6275
		[FieldOffset(0)]
		public int NID;
	}
}
