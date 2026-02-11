using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000101 RID: 257
	[StructLayout(2)]
	public struct UnreadChatMessagesChanged_t
	{
		// Token: 0x06000F86 RID: 3974 RVA: 0x0005D72C File Offset: 0x0005B92C
		// Note: this type is marked as 'beforefieldinit'.
		static UnreadChatMessagesChanged_t()
		{
			Il2CppClassPointerStore<UnreadChatMessagesChanged_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "UnreadChatMessagesChanged_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnreadChatMessagesChanged_t>.NativeClassPtr);
			UnreadChatMessagesChanged_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnreadChatMessagesChanged_t>.NativeClassPtr, "_datasize");
			UnreadChatMessagesChanged_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnreadChatMessagesChanged_t>.NativeClassPtr, 100666830);
			UnreadChatMessagesChanged_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnreadChatMessagesChanged_t>.NativeClassPtr, 100666831);
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000F87 RID: 3975 RVA: 0x0005D798 File Offset: 0x0005B998
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950266, XrefRangeEnd = 950270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnreadChatMessagesChanged_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000F88 RID: 3976 RVA: 0x0005D7C8 File Offset: 0x0005B9C8
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnreadChatMessagesChanged_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x0000444E File Offset: 0x0000264E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnreadChatMessagesChanged_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000F8A RID: 3978 RVA: 0x0005D7F8 File Offset: 0x0005B9F8
		// (set) Token: 0x06000F8B RID: 3979 RVA: 0x00004460 File Offset: 0x00002660
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UnreadChatMessagesChanged_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnreadChatMessagesChanged_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040015BE RID: 5566
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040015BF RID: 5567
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040015C0 RID: 5568
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}
