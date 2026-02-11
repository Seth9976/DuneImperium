using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace dwd.core.settings.scriptableConfig
{
	// Token: 0x020000C7 RID: 199
	public class PlatformIDScriptableConfig : ScriptableObject
	{
		// Token: 0x06000C69 RID: 3177 RVA: 0x000432C4 File Offset: 0x000414C4
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformIDScriptableConfig()
		{
			Il2CppClassPointerStore<PlatformIDScriptableConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.scriptableConfig", "PlatformIDScriptableConfig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformIDScriptableConfig>.NativeClassPtr);
			PlatformIDScriptableConfig.NativeFieldInfoPtr_STEAM_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformIDScriptableConfig>.NativeClassPtr, "STEAM_ID");
			PlatformIDScriptableConfig.NativeFieldInfoPtr_ANDROID_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformIDScriptableConfig>.NativeClassPtr, "ANDROID_ID");
			PlatformIDScriptableConfig.NativeFieldInfoPtr_Nintendo_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformIDScriptableConfig>.NativeClassPtr, "Nintendo_ID");
			PlatformIDScriptableConfig.NativeFieldInfoPtr_steamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformIDScriptableConfig>.NativeClassPtr, "steamID");
			PlatformIDScriptableConfig.NativeFieldInfoPtr_androidID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformIDScriptableConfig>.NativeClassPtr, "androidID");
			PlatformIDScriptableConfig.NativeFieldInfoPtr_nintendoID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformIDScriptableConfig>.NativeClassPtr, "nintendoID");
			PlatformIDScriptableConfig.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformIDScriptableConfig>.NativeClassPtr, 100665048);
			PlatformIDScriptableConfig.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformIDScriptableConfig>.NativeClassPtr, 100665049);
			PlatformIDScriptableConfig.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformIDScriptableConfig>.NativeClassPtr, 100665050);
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000C6A RID: 3178 RVA: 0x000433A8 File Offset: 0x000415A8
		public unsafe virtual ulong Version
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformIDScriptableConfig.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x000433E4 File Offset: 0x000415E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864479, XrefRangeEnd = 864485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Get(string key, out string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PlatformIDScriptableConfig.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Boolean_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			value = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x0004344C File Offset: 0x0004164C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 338035, RefRangeEnd = 338045, XrefRangeStart = 338035, XrefRangeEnd = 338045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformIDScriptableConfig()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformIDScriptableConfig>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformIDScriptableConfig.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x00006614 File Offset: 0x00004814
		public PlatformIDScriptableConfig(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000C6E RID: 3182 RVA: 0x00043488 File Offset: 0x00041688
		// (set) Token: 0x06000C6F RID: 3183 RVA: 0x0000661D File Offset: 0x0000481D
		public unsafe static string STEAM_ID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlatformIDScriptableConfig.NativeFieldInfoPtr_STEAM_ID, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlatformIDScriptableConfig.NativeFieldInfoPtr_STEAM_ID, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000C70 RID: 3184 RVA: 0x000434A8 File Offset: 0x000416A8
		// (set) Token: 0x06000C71 RID: 3185 RVA: 0x0000662F File Offset: 0x0000482F
		public unsafe static string ANDROID_ID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlatformIDScriptableConfig.NativeFieldInfoPtr_ANDROID_ID, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlatformIDScriptableConfig.NativeFieldInfoPtr_ANDROID_ID, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000C72 RID: 3186 RVA: 0x000434C8 File Offset: 0x000416C8
		// (set) Token: 0x06000C73 RID: 3187 RVA: 0x00006641 File Offset: 0x00004841
		public unsafe static string Nintendo_ID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlatformIDScriptableConfig.NativeFieldInfoPtr_Nintendo_ID, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlatformIDScriptableConfig.NativeFieldInfoPtr_Nintendo_ID, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000C74 RID: 3188 RVA: 0x000434E8 File Offset: 0x000416E8
		// (set) Token: 0x06000C75 RID: 3189 RVA: 0x00006653 File Offset: 0x00004853
		public unsafe string steamID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformIDScriptableConfig.NativeFieldInfoPtr_steamID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformIDScriptableConfig.NativeFieldInfoPtr_steamID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000C76 RID: 3190 RVA: 0x00043510 File Offset: 0x00041710
		// (set) Token: 0x06000C77 RID: 3191 RVA: 0x00006672 File Offset: 0x00004872
		public unsafe string androidID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformIDScriptableConfig.NativeFieldInfoPtr_androidID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformIDScriptableConfig.NativeFieldInfoPtr_androidID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000C78 RID: 3192 RVA: 0x00043538 File Offset: 0x00041738
		// (set) Token: 0x06000C79 RID: 3193 RVA: 0x00006691 File Offset: 0x00004891
		public unsafe string nintendoID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformIDScriptableConfig.NativeFieldInfoPtr_nintendoID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformIDScriptableConfig.NativeFieldInfoPtr_nintendoID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040008F2 RID: 2290
		private static readonly IntPtr NativeFieldInfoPtr_STEAM_ID;

		// Token: 0x040008F3 RID: 2291
		private static readonly IntPtr NativeFieldInfoPtr_ANDROID_ID;

		// Token: 0x040008F4 RID: 2292
		private static readonly IntPtr NativeFieldInfoPtr_Nintendo_ID;

		// Token: 0x040008F5 RID: 2293
		private static readonly IntPtr NativeFieldInfoPtr_steamID;

		// Token: 0x040008F6 RID: 2294
		private static readonly IntPtr NativeFieldInfoPtr_androidID;

		// Token: 0x040008F7 RID: 2295
		private static readonly IntPtr NativeFieldInfoPtr_nintendoID;

		// Token: 0x040008F8 RID: 2296
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

		// Token: 0x040008F9 RID: 2297
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Boolean_String_byref_String_0;

		// Token: 0x040008FA RID: 2298
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
