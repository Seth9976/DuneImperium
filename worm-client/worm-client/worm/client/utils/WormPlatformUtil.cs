using System;
using dwd.core.platformdependent;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace worm.client.utils
{
	// Token: 0x02000294 RID: 660
	public class WormPlatformUtil : ZenPlatformUtil
	{
		// Token: 0x06001AB4 RID: 6836 RVA: 0x0006A5E0 File Offset: 0x000687E0
		// Note: this type is marked as 'beforefieldinit'.
		static WormPlatformUtil()
		{
			Il2CppClassPointerStore<WormPlatformUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.client.utils", "WormPlatformUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlatformUtil>.NativeClassPtr);
			WormPlatformUtil.NativeFieldInfoPtr_NonTabletDeviceOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlatformUtil>.NativeClassPtr, "NonTabletDeviceOverrides");
			WormPlatformUtil.NativeMethodInfoPtr_setCurrentPlatform_Protected_Virtual_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlatformUtil>.NativeClassPtr, 100667213);
			WormPlatformUtil.NativeMethodInfoPtr_IsTabletOverride_Public_Virtual_Final_New_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlatformUtil>.NativeClassPtr, 100667214);
			WormPlatformUtil.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlatformUtil>.NativeClassPtr, 100667215);
		}

		// Token: 0x06001AB5 RID: 6837 RVA: 0x0006A660 File Offset: 0x00068860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723964, XrefRangeEnd = 723966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void setCurrentPlatform(uint value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPlatformUtil.NativeMethodInfoPtr_setCurrentPlatform_Protected_Virtual_Void_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AB6 RID: 6838 RVA: 0x0006A6AC File Offset: 0x000688AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723966, XrefRangeEnd = 723978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Nullable<bool> IsTabletOverride()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlatformUtil.NativeMethodInfoPtr_IsTabletOverride_Public_Virtual_Final_New_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<bool>(intPtr);
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x0006A6E4 File Offset: 0x000688E4
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlatformUtil()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlatformUtil>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlatformUtil.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AB8 RID: 6840 RVA: 0x0000F84A File Offset: 0x0000DA4A
		public WormPlatformUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x06001AB9 RID: 6841 RVA: 0x0006A720 File Offset: 0x00068920
		// (set) Token: 0x06001ABA RID: 6842 RVA: 0x0000F853 File Offset: 0x0000DA53
		public unsafe static IReadOnlyList<string> NonTabletDeviceOverrides
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormPlatformUtil.NativeFieldInfoPtr_NonTabletDeviceOverrides, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormPlatformUtil.NativeFieldInfoPtr_NonTabletDeviceOverrides, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F6E RID: 3950
		private static readonly IntPtr NativeFieldInfoPtr_NonTabletDeviceOverrides;

		// Token: 0x04000F6F RID: 3951
		private static readonly IntPtr NativeMethodInfoPtr_setCurrentPlatform_Protected_Virtual_Void_UInt32_0;

		// Token: 0x04000F70 RID: 3952
		private static readonly IntPtr NativeMethodInfoPtr_IsTabletOverride_Public_Virtual_Final_New_Nullable_1_Boolean_0;

		// Token: 0x04000F71 RID: 3953
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
