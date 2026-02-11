using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000102 RID: 258
	public sealed class OverlayBrowserProtocolNavigation_t : ValueType
	{
		// Token: 0x06000F8C RID: 3980 RVA: 0x0005D814 File Offset: 0x0005BA14
		// Note: this type is marked as 'beforefieldinit'.
		static OverlayBrowserProtocolNavigation_t()
		{
			Il2CppClassPointerStore<OverlayBrowserProtocolNavigation_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "OverlayBrowserProtocolNavigation_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OverlayBrowserProtocolNavigation_t>.NativeClassPtr);
			OverlayBrowserProtocolNavigation_t.NativeFieldInfoPtr_RgchURI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlayBrowserProtocolNavigation_t>.NativeClassPtr, "RgchURI");
			OverlayBrowserProtocolNavigation_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlayBrowserProtocolNavigation_t>.NativeClassPtr, "_datasize");
			OverlayBrowserProtocolNavigation_t.NativeMethodInfoPtr_RgchURIUTF8_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayBrowserProtocolNavigation_t>.NativeClassPtr, 100666833);
			OverlayBrowserProtocolNavigation_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayBrowserProtocolNavigation_t>.NativeClassPtr, 100666834);
			OverlayBrowserProtocolNavigation_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayBrowserProtocolNavigation_t>.NativeClassPtr, 100666835);
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x0005D8A8 File Offset: 0x0005BAA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 950274, RefRangeEnd = 950275, XrefRangeStart = 950270, XrefRangeEnd = 950274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string RgchURIUTF8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayBrowserProtocolNavigation_t.NativeMethodInfoPtr_RgchURIUTF8_Internal_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000F8E RID: 3982 RVA: 0x0005D8E4 File Offset: 0x0005BAE4
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950275, XrefRangeEnd = 950279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayBrowserProtocolNavigation_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000F8F RID: 3983 RVA: 0x0005D928 File Offset: 0x0005BB28
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayBrowserProtocolNavigation_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x0000446E File Offset: 0x0000266E
		public OverlayBrowserProtocolNavigation_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x00004477 File Offset: 0x00002677
		public OverlayBrowserProtocolNavigation_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverlayBrowserProtocolNavigation_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000F92 RID: 3986 RVA: 0x0005D96C File Offset: 0x0005BB6C
		// (set) Token: 0x06000F93 RID: 3987 RVA: 0x00004489 File Offset: 0x00002689
		public unsafe Il2CppStructArray<byte> RgchURI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayBrowserProtocolNavigation_t.NativeFieldInfoPtr_RgchURI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayBrowserProtocolNavigation_t.NativeFieldInfoPtr_RgchURI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000F94 RID: 3988 RVA: 0x0005D99C File Offset: 0x0005BB9C
		// (set) Token: 0x06000F95 RID: 3989 RVA: 0x000044A8 File Offset: 0x000026A8
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(OverlayBrowserProtocolNavigation_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OverlayBrowserProtocolNavigation_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040015C1 RID: 5569
		private static readonly IntPtr NativeFieldInfoPtr_RgchURI;

		// Token: 0x040015C2 RID: 5570
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040015C3 RID: 5571
		private static readonly IntPtr NativeMethodInfoPtr_RgchURIUTF8_Internal_String_0;

		// Token: 0x040015C4 RID: 5572
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040015C5 RID: 5573
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}
