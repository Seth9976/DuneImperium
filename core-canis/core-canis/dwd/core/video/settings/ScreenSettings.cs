using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace dwd.core.video.settings
{
	// Token: 0x02000088 RID: 136
	[StructLayout(2)]
	public struct ScreenSettings
	{
		// Token: 0x060009F1 RID: 2545 RVA: 0x000399A8 File Offset: 0x00037BA8
		// Note: this type is marked as 'beforefieldinit'.
		static ScreenSettings()
		{
			Il2CppClassPointerStore<ScreenSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.video.settings", "ScreenSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenSettings>.NativeClassPtr);
			ScreenSettings.NativeFieldInfoPtr_Resolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSettings>.NativeClassPtr, "Resolution");
			ScreenSettings.NativeFieldInfoPtr_IsWindowed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSettings>.NativeClassPtr, "IsWindowed");
			ScreenSettings.NativeMethodInfoPtr__ctor_Public_Void_ScreenResolution_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSettings>.NativeClassPtr, 100664683);
			ScreenSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSettings>.NativeClassPtr, 100664684);
			ScreenSettings.NativeMethodInfoPtr_Equals_Public_Boolean_ScreenSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSettings>.NativeClassPtr, 100664685);
			ScreenSettings.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSettings>.NativeClassPtr, 100664686);
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x00039A50 File Offset: 0x00037C50
		[CallerCount(0)]
		public unsafe ScreenSettings(ScreenResolution resolution, bool isWindowed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resolution;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isWindowed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSettings.NativeMethodInfoPtr__ctor_Public_Void_ScreenResolution_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x00039A90 File Offset: 0x00037C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862417, XrefRangeEnd = 862421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x00039AD4 File Offset: 0x00037CD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 862425, RefRangeEnd = 862426, XrefRangeStart = 862421, XrefRangeEnd = 862425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(ScreenSettings other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSettings.NativeMethodInfoPtr_Equals_Public_Boolean_ScreenSettings_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x00039B14 File Offset: 0x00037D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862426, XrefRangeEnd = 862432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSettings.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x000057BD File Offset: 0x000039BD
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScreenSettings>.NativeClassPtr, ref this));
		}

		// Token: 0x04000753 RID: 1875
		private static readonly IntPtr NativeFieldInfoPtr_Resolution;

		// Token: 0x04000754 RID: 1876
		private static readonly IntPtr NativeFieldInfoPtr_IsWindowed;

		// Token: 0x04000755 RID: 1877
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScreenResolution_Boolean_0;

		// Token: 0x04000756 RID: 1878
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000757 RID: 1879
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_ScreenSettings_0;

		// Token: 0x04000758 RID: 1880
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000759 RID: 1881
		[FieldOffset(0)]
		public ScreenResolution Resolution;

		// Token: 0x0400075A RID: 1882
		[FieldOffset(12)]
		[MarshalAs(4)]
		public bool IsWindowed;
	}
}
