using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;

namespace boardgames
{
	// Token: 0x02000103 RID: 259
	public class SafeAreaManager : DirtyBehaviour
	{
		// Token: 0x06000C84 RID: 3204 RVA: 0x00038C54 File Offset: 0x00036E54
		// Note: this type is marked as 'beforefieldinit'.
		static SafeAreaManager()
		{
			Il2CppClassPointerStore<SafeAreaManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames", "SafeAreaManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeAreaManager>.NativeClassPtr);
			SafeAreaManager.NativeFieldInfoPtr_lastResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeAreaManager>.NativeClassPtr, "lastResolution");
			SafeAreaManager.NativeFieldInfoPtr_lastSafeArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeAreaManager>.NativeClassPtr, "lastSafeArea");
			SafeAreaManager.NativeFieldInfoPtr_um = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeAreaManager>.NativeClassPtr, "um");
			SafeAreaManager.NativeFieldInfoPtr_useOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeAreaManager>.NativeClassPtr, "useOverride");
			SafeAreaManager.NativeFieldInfoPtr_safeAreaOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeAreaManager>.NativeClassPtr, "safeAreaOverride");
			SafeAreaManager.NativeFieldInfoPtr_screenSizeOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeAreaManager>.NativeClassPtr, "screenSizeOverride");
			SafeAreaManager.NativeMethodInfoPtr_get_SafeArea_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAreaManager>.NativeClassPtr, 100665276);
			SafeAreaManager.NativeMethodInfoPtr_get_ScreenSize_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAreaManager>.NativeClassPtr, 100665277);
			SafeAreaManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAreaManager>.NativeClassPtr, 100665278);
			SafeAreaManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAreaManager>.NativeClassPtr, 100665279);
			SafeAreaManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAreaManager>.NativeClassPtr, 100665280);
			SafeAreaManager.NativeMethodInfoPtr_ResolutionChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAreaManager>.NativeClassPtr, 100665281);
			SafeAreaManager.NativeMethodInfoPtr_SafeAreaChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAreaManager>.NativeClassPtr, 100665282);
			SafeAreaManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAreaManager>.NativeClassPtr, 100665283);
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000C85 RID: 3205 RVA: 0x00038D9C File Offset: 0x00036F9C
		public unsafe Rect SafeArea
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAreaManager.NativeMethodInfoPtr_get_SafeArea_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000C86 RID: 3206 RVA: 0x00038DD8 File Offset: 0x00036FD8
		public unsafe Rect ScreenSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995676, XrefRangeEnd = 995678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAreaManager.NativeMethodInfoPtr_get_ScreenSize_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x00038E14 File Offset: 0x00037014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995678, XrefRangeEnd = 995681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAreaManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x00038E48 File Offset: 0x00037048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995681, XrefRangeEnd = 995685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAreaManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x00038E7C File Offset: 0x0003707C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995685, XrefRangeEnd = 995692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAreaManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x00038EB0 File Offset: 0x000370B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995692, XrefRangeEnd = 995697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResolutionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAreaManager.NativeMethodInfoPtr_ResolutionChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x00038EE4 File Offset: 0x000370E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995697, XrefRangeEnd = 995700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SafeAreaChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAreaManager.NativeMethodInfoPtr_SafeAreaChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x00038F18 File Offset: 0x00037118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995700, XrefRangeEnd = 995706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeAreaManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeAreaManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAreaManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x00007C23 File Offset: 0x00005E23
		public SafeAreaManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000C8E RID: 3214 RVA: 0x00038F54 File Offset: 0x00037154
		// (set) Token: 0x06000C8F RID: 3215 RVA: 0x00007C2C File Offset: 0x00005E2C
		public unsafe Vector2 lastResolution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeAreaManager.NativeFieldInfoPtr_lastResolution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeAreaManager.NativeFieldInfoPtr_lastResolution)) = value;
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000C90 RID: 3216 RVA: 0x00038F7C File Offset: 0x0003717C
		// (set) Token: 0x06000C91 RID: 3217 RVA: 0x00007C47 File Offset: 0x00005E47
		public unsafe Rect lastSafeArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeAreaManager.NativeFieldInfoPtr_lastSafeArea);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeAreaManager.NativeFieldInfoPtr_lastSafeArea)) = value;
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000C92 RID: 3218 RVA: 0x00038FA4 File Offset: 0x000371A4
		// (set) Token: 0x06000C93 RID: 3219 RVA: 0x00007C62 File Offset: 0x00005E62
		public unsafe UpdateManager um
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeAreaManager.NativeFieldInfoPtr_um);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpdateManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeAreaManager.NativeFieldInfoPtr_um), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000C94 RID: 3220 RVA: 0x00038FD4 File Offset: 0x000371D4
		// (set) Token: 0x06000C95 RID: 3221 RVA: 0x00007C81 File Offset: 0x00005E81
		public unsafe bool useOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeAreaManager.NativeFieldInfoPtr_useOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeAreaManager.NativeFieldInfoPtr_useOverride)) = value;
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000C96 RID: 3222 RVA: 0x00038FFC File Offset: 0x000371FC
		// (set) Token: 0x06000C97 RID: 3223 RVA: 0x00007C9C File Offset: 0x00005E9C
		public unsafe Rect safeAreaOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeAreaManager.NativeFieldInfoPtr_safeAreaOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeAreaManager.NativeFieldInfoPtr_safeAreaOverride)) = value;
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000C98 RID: 3224 RVA: 0x00039024 File Offset: 0x00037224
		// (set) Token: 0x06000C99 RID: 3225 RVA: 0x00007CB7 File Offset: 0x00005EB7
		public unsafe Rect screenSizeOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeAreaManager.NativeFieldInfoPtr_screenSizeOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeAreaManager.NativeFieldInfoPtr_screenSizeOverride)) = value;
			}
		}

		// Token: 0x040007B3 RID: 1971
		private static readonly IntPtr NativeFieldInfoPtr_lastResolution;

		// Token: 0x040007B4 RID: 1972
		private static readonly IntPtr NativeFieldInfoPtr_lastSafeArea;

		// Token: 0x040007B5 RID: 1973
		private static readonly IntPtr NativeFieldInfoPtr_um;

		// Token: 0x040007B6 RID: 1974
		private static readonly IntPtr NativeFieldInfoPtr_useOverride;

		// Token: 0x040007B7 RID: 1975
		private static readonly IntPtr NativeFieldInfoPtr_safeAreaOverride;

		// Token: 0x040007B8 RID: 1976
		private static readonly IntPtr NativeFieldInfoPtr_screenSizeOverride;

		// Token: 0x040007B9 RID: 1977
		private static readonly IntPtr NativeMethodInfoPtr_get_SafeArea_Public_get_Rect_0;

		// Token: 0x040007BA RID: 1978
		private static readonly IntPtr NativeMethodInfoPtr_get_ScreenSize_Public_get_Rect_0;

		// Token: 0x040007BB RID: 1979
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040007BC RID: 1980
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040007BD RID: 1981
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040007BE RID: 1982
		private static readonly IntPtr NativeMethodInfoPtr_ResolutionChanged_Private_Void_0;

		// Token: 0x040007BF RID: 1983
		private static readonly IntPtr NativeMethodInfoPtr_SafeAreaChanged_Private_Void_0;

		// Token: 0x040007C0 RID: 1984
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
