using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x0200028E RID: 654
	[Serializable]
	public class ChannelInfo : Object
	{
		// Token: 0x06002A12 RID: 10770 RVA: 0x000E03E4 File Offset: 0x000DE5E4
		// Note: this type is marked as 'beforefieldinit'.
		static ChannelInfo()
		{
			Il2CppClassPointerStore<ChannelInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "ChannelInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChannelInfo>.NativeClassPtr);
			ChannelInfo.NativeFieldInfoPtr_channelData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelInfo>.NativeClassPtr, "channelData");
			ChannelInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelInfo>.NativeClassPtr, 100670160);
			ChannelInfo.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelInfo>.NativeClassPtr, 100670161);
			ChannelInfo.NativeMethodInfoPtr_get_ChannelData_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelInfo>.NativeClassPtr, 100670162);
		}

		// Token: 0x06002A13 RID: 10771 RVA: 0x000E0464 File Offset: 0x000DE664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376776, XrefRangeEnd = 1376782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChannelInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChannelInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A14 RID: 10772 RVA: 0x000E04A0 File Offset: 0x000DE6A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1376793, RefRangeEnd = 1376795, XrefRangeStart = 1376782, XrefRangeEnd = 1376793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChannelInfo(Object remoteChannelData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChannelInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(remoteChannelData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelInfo.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06002A15 RID: 10773 RVA: 0x000E04EC File Offset: 0x000DE6EC
		public unsafe virtual Il2CppReferenceArray<Object> ChannelData
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelInfo.NativeMethodInfoPtr_get_ChannelData_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06002A16 RID: 10774 RVA: 0x0000DF4F File Offset: 0x0000C14F
		public ChannelInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06002A17 RID: 10775 RVA: 0x000E052C File Offset: 0x000DE72C
		// (set) Token: 0x06002A18 RID: 10776 RVA: 0x0000DF58 File Offset: 0x0000C158
		public unsafe Il2CppReferenceArray<Object> channelData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelInfo.NativeFieldInfoPtr_channelData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelInfo.NativeFieldInfoPtr_channelData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040023D8 RID: 9176
		private static readonly IntPtr NativeFieldInfoPtr_channelData;

		// Token: 0x040023D9 RID: 9177
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040023DA RID: 9178
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

		// Token: 0x040023DB RID: 9179
		private static readonly IntPtr NativeMethodInfoPtr_get_ChannelData_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0;
	}
}
