using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Util
{
	// Token: 0x02000008 RID: 8
	public class SystemClock : Object
	{
		// Token: 0x06000037 RID: 55 RVA: 0x00004E14 File Offset: 0x00003014
		// Note: this type is marked as 'beforefieldinit'.
		static SystemClock()
		{
			Il2CppClassPointerStore<SystemClock>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Util", "SystemClock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemClock>.NativeClassPtr);
			SystemClock.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemClock>.NativeClassPtr, "Default");
			SystemClock.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemClock>.NativeClassPtr, 100663323);
			SystemClock.NativeMethodInfoPtr_get_Now_Public_Virtual_Final_New_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemClock>.NativeClassPtr, 100663324);
			SystemClock.NativeMethodInfoPtr_get_UtcNow_Public_Virtual_Final_New_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemClock>.NativeClassPtr, 100663325);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00004E94 File Offset: 0x00003094
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SystemClock()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SystemClock>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemClock.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00004ED0 File Offset: 0x000030D0
		public unsafe virtual DateTime Now
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209923, XrefRangeEnd = 1209927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemClock.NativeMethodInfoPtr_get_Now_Public_Virtual_Final_New_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00004F0C File Offset: 0x0000310C
		public unsafe virtual DateTime UtcNow
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209927, XrefRangeEnd = 1209931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemClock.NativeMethodInfoPtr_get_UtcNow_Public_Virtual_Final_New_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002154 File Offset: 0x00000354
		public SystemClock(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00004F48 File Offset: 0x00003148
		// (set) Token: 0x0600003D RID: 61 RVA: 0x0000215D File Offset: 0x0000035D
		public unsafe static IClock Default
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SystemClock.NativeFieldInfoPtr_Default, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IClock>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SystemClock.NativeFieldInfoPtr_Default, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeFieldInfoPtr_Default;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_get_Now_Public_Virtual_Final_New_get_DateTime_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_get_UtcNow_Public_Virtual_Final_New_get_DateTime_0;
	}
}
