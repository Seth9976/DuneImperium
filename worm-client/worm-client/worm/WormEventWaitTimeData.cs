using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm
{
	// Token: 0x0200004F RID: 79
	public class WormEventWaitTimeData : VersionedDataComponent
	{
		// Token: 0x06000345 RID: 837 RVA: 0x00022F20 File Offset: 0x00021120
		// Note: this type is marked as 'beforefieldinit'.
		static WormEventWaitTimeData()
		{
			Il2CppClassPointerStore<WormEventWaitTimeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm", "WormEventWaitTimeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventWaitTimeData>.NativeClassPtr);
			WormEventWaitTimeData.NativeFieldInfoPtr_waitTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventWaitTimeData>.NativeClassPtr, "waitTime");
			WormEventWaitTimeData.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventWaitTimeData>.NativeClassPtr, 100663817);
			WormEventWaitTimeData.NativeMethodInfoPtr_get_WaitTime_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventWaitTimeData>.NativeClassPtr, 100663818);
			WormEventWaitTimeData.NativeMethodInfoPtr_set_WaitTime_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventWaitTimeData>.NativeClassPtr, 100663819);
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00022FA0 File Offset: 0x000211A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 514331, RefRangeEnd = 514333, XrefRangeStart = 514331, XrefRangeEnd = 514333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEventWaitTimeData(int waitTime)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventWaitTimeData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref waitTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventWaitTimeData.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000347 RID: 839 RVA: 0x00022FE8 File Offset: 0x000211E8
		// (set) Token: 0x06000348 RID: 840 RVA: 0x00023024 File Offset: 0x00021224
		public unsafe int WaitTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventWaitTimeData.NativeMethodInfoPtr_get_WaitTime_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 515133, RefRangeEnd = 515146, XrefRangeStart = 515133, XrefRangeEnd = 515146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventWaitTimeData.NativeMethodInfoPtr_set_WaitTime_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00003819 File Offset: 0x00001A19
		public WormEventWaitTimeData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600034A RID: 842 RVA: 0x00023064 File Offset: 0x00021264
		// (set) Token: 0x0600034B RID: 843 RVA: 0x00003822 File Offset: 0x00001A22
		public unsafe int waitTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventWaitTimeData.NativeFieldInfoPtr_waitTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventWaitTimeData.NativeFieldInfoPtr_waitTime)) = value;
			}
		}

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeFieldInfoPtr_waitTime;

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeMethodInfoPtr_get_WaitTime_Public_get_Int32_0;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeMethodInfoPtr_set_WaitTime_Public_set_Void_Int32_0;
	}
}
