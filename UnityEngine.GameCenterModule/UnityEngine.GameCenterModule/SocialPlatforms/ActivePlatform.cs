using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.SocialPlatforms
{
	// Token: 0x02000004 RID: 4
	public static class ActivePlatform : Object
	{
		// Token: 0x06000034 RID: 52 RVA: 0x00003098 File Offset: 0x00001298
		// Note: this type is marked as 'beforefieldinit'.
		static ActivePlatform()
		{
			Il2CppClassPointerStore<ActivePlatform>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.GameCenterModule.dll", "UnityEngine.SocialPlatforms", "ActivePlatform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivePlatform>.NativeClassPtr);
			ActivePlatform.NativeFieldInfoPtr__active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivePlatform>.NativeClassPtr, "_active");
			ActivePlatform.NativeMethodInfoPtr_get_Instance_Internal_Static_get_ISocialPlatform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivePlatform>.NativeClassPtr, 100663306);
			ActivePlatform.NativeMethodInfoPtr_SelectSocialPlatform_Private_Static_ISocialPlatform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivePlatform>.NativeClassPtr, 100663307);
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00003104 File Offset: 0x00001304
		// (set) Token: 0x0600003A RID: 58 RVA: 0x000021ED File Offset: 0x000003ED
		public unsafe static ISocialPlatform Instance
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1270477, RefRangeEnd = 1270481, XrefRangeStart = 1270477, XrefRangeEnd = 1270481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivePlatform.NativeMethodInfoPtr_get_Instance_Internal_Static_get_ISocialPlatform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISocialPlatform>(intPtr3) : null;
			}
			set
			{
				ActivePlatform._active = value;
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00003138 File Offset: 0x00001338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270662, XrefRangeEnd = 1270699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ISocialPlatform SelectSocialPlatform()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivePlatform.NativeMethodInfoPtr_SelectSocialPlatform_Private_Static_ISocialPlatform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISocialPlatform>(intPtr3) : null;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000021D2 File Offset: 0x000003D2
		public ActivePlatform(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000038 RID: 56 RVA: 0x0000316C File Offset: 0x0000136C
		// (set) Token: 0x06000039 RID: 57 RVA: 0x000021DB File Offset: 0x000003DB
		public unsafe static ISocialPlatform _active
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ActivePlatform.NativeFieldInfoPtr__active, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISocialPlatform>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ActivePlatform.NativeFieldInfoPtr__active, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeFieldInfoPtr__active;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Internal_Static_get_ISocialPlatform_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_SelectSocialPlatform_Private_Static_ISocialPlatform_0;
	}
}
