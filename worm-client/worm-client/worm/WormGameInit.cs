using System;
using canis.archetypes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using localization;
using lotus;

namespace worm
{
	// Token: 0x0200005B RID: 91
	public class WormGameInit : GameInit
	{
		// Token: 0x060003A0 RID: 928 RVA: 0x00024598 File Offset: 0x00022798
		// Note: this type is marked as 'beforefieldinit'.
		static WormGameInit()
		{
			Il2CppClassPointerStore<WormGameInit>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm", "WormGameInit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormGameInit>.NativeClassPtr);
			WormGameInit.NativeMethodInfoPtr_initClientVersion_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameInit>.NativeClassPtr, 100663901);
			WormGameInit.NativeMethodInfoPtr_configureSharedPrefs_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameInit>.NativeClassPtr, 100663902);
			WormGameInit.NativeMethodInfoPtr_getArchetypes_Protected_Virtual_Archetypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameInit>.NativeClassPtr, 100663903);
			WormGameInit.NativeMethodInfoPtr_initPlatformScenes_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameInit>.NativeClassPtr, 100663904);
			WormGameInit.NativeMethodInfoPtr_InitPlatformScenes_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameInit>.NativeClassPtr, 100663905);
			WormGameInit.NativeMethodInfoPtr_getSupportedLocales_Protected_Virtual_Dictionary_2_String_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameInit>.NativeClassPtr, 100663906);
			WormGameInit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameInit>.NativeClassPtr, 100663907);
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00024654 File Offset: 0x00022854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692946, XrefRangeEnd = 692956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initClientVersion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormGameInit.NativeMethodInfoPtr_initClientVersion_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00024690 File Offset: 0x00022890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692956, XrefRangeEnd = 693020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void configureSharedPrefs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormGameInit.NativeMethodInfoPtr_configureSharedPrefs_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x000246CC File Offset: 0x000228CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 693020, XrefRangeEnd = 693024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Archetypes getArchetypes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormGameInit.NativeMethodInfoPtr_getArchetypes_Protected_Virtual_Archetypes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Archetypes>(intPtr3) : null;
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00024718 File Offset: 0x00022918
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 693046, RefRangeEnd = 693047, XrefRangeStart = 693024, XrefRangeEnd = 693046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initPlatformScenes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormGameInit.NativeMethodInfoPtr_initPlatformScenes_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00024754 File Offset: 0x00022954
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 693046, RefRangeEnd = 693047, XrefRangeStart = 693046, XrefRangeEnd = 693047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitPlatformScenes()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameInit.NativeMethodInfoPtr_InitPlatformScenes_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0002477C File Offset: 0x0002297C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 693047, XrefRangeEnd = 693103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Dictionary<string, TextLocalization.Locale> getSupportedLocales()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormGameInit.NativeMethodInfoPtr_getSupportedLocales_Protected_Virtual_Dictionary_2_String_Locale_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, TextLocalization.Locale>>(intPtr3) : null;
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x000247C8 File Offset: 0x000229C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 693103, XrefRangeEnd = 693104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormGameInit()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormGameInit>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameInit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x000039C4 File Offset: 0x00001BC4
		public WormGameInit(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeMethodInfoPtr_initClientVersion_Protected_Virtual_Void_0;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeMethodInfoPtr_configureSharedPrefs_Protected_Virtual_Void_0;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeMethodInfoPtr_getArchetypes_Protected_Virtual_Archetypes_0;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeMethodInfoPtr_initPlatformScenes_Protected_Virtual_Void_0;

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeMethodInfoPtr_InitPlatformScenes_Public_Static_Void_0;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeMethodInfoPtr_getSupportedLocales_Protected_Virtual_Dictionary_2_String_Locale_0;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
