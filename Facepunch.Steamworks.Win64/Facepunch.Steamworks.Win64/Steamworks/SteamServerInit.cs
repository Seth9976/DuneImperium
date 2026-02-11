using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Net;

namespace Steamworks
{
	// Token: 0x020000C0 RID: 192
	public sealed class SteamServerInit : ValueType
	{
		// Token: 0x06000C6E RID: 3182 RVA: 0x00052CA0 File Offset: 0x00050EA0
		// Note: this type is marked as 'beforefieldinit'.
		static SteamServerInit()
		{
			Il2CppClassPointerStore<SteamServerInit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "SteamServerInit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamServerInit>.NativeClassPtr);
			SteamServerInit.NativeFieldInfoPtr_IpAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServerInit>.NativeClassPtr, "IpAddress");
			SteamServerInit.NativeFieldInfoPtr_GamePort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServerInit>.NativeClassPtr, "GamePort");
			SteamServerInit.NativeFieldInfoPtr_QueryPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServerInit>.NativeClassPtr, "QueryPort");
			SteamServerInit.NativeFieldInfoPtr_Secure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServerInit>.NativeClassPtr, "Secure");
			SteamServerInit.NativeFieldInfoPtr_VersionString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServerInit>.NativeClassPtr, "VersionString");
			SteamServerInit.NativeFieldInfoPtr_ModDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServerInit>.NativeClassPtr, "ModDir");
			SteamServerInit.NativeFieldInfoPtr_GameDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServerInit>.NativeClassPtr, "GameDescription");
			SteamServerInit.NativeFieldInfoPtr_DedicatedServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServerInit>.NativeClassPtr, "DedicatedServer");
			SteamServerInit.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServerInit>.NativeClassPtr, 100666376);
			SteamServerInit.NativeMethodInfoPtr_WithQueryShareGamePort_Public_SteamServerInit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServerInit>.NativeClassPtr, 100666377);
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x00052D98 File Offset: 0x00050F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947261, XrefRangeEnd = 947268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamServerInit(string modDir, string gameDesc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamServerInit>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(modDir);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(gameDesc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServerInit.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x00052DFC File Offset: 0x00050FFC
		[CallerCount(0)]
		public unsafe SteamServerInit WithQueryShareGamePort()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServerInit.NativeMethodInfoPtr_WithQueryShareGamePort_Public_SteamServerInit_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new SteamServerInit(intPtr);
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x000030A9 File Offset: 0x000012A9
		public SteamServerInit(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x000030B2 File Offset: 0x000012B2
		public SteamServerInit()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamServerInit>.NativeClassPtr))
		{
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000C73 RID: 3187 RVA: 0x00052E38 File Offset: 0x00051038
		// (set) Token: 0x06000C74 RID: 3188 RVA: 0x000030C4 File Offset: 0x000012C4
		public unsafe IPAddress IpAddress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamServerInit.NativeFieldInfoPtr_IpAddress);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamServerInit.NativeFieldInfoPtr_IpAddress), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000C75 RID: 3189 RVA: 0x00052E68 File Offset: 0x00051068
		// (set) Token: 0x06000C76 RID: 3190 RVA: 0x000030E3 File Offset: 0x000012E3
		public unsafe ushort GamePort
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamServerInit.NativeFieldInfoPtr_GamePort);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamServerInit.NativeFieldInfoPtr_GamePort)) = value;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000C77 RID: 3191 RVA: 0x00052E90 File Offset: 0x00051090
		// (set) Token: 0x06000C78 RID: 3192 RVA: 0x000030FE File Offset: 0x000012FE
		public unsafe ushort QueryPort
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamServerInit.NativeFieldInfoPtr_QueryPort);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamServerInit.NativeFieldInfoPtr_QueryPort)) = value;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000C79 RID: 3193 RVA: 0x00052EB8 File Offset: 0x000510B8
		// (set) Token: 0x06000C7A RID: 3194 RVA: 0x00003119 File Offset: 0x00001319
		public unsafe bool Secure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamServerInit.NativeFieldInfoPtr_Secure);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamServerInit.NativeFieldInfoPtr_Secure)) = value;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000C7B RID: 3195 RVA: 0x00052EE0 File Offset: 0x000510E0
		// (set) Token: 0x06000C7C RID: 3196 RVA: 0x00003134 File Offset: 0x00001334
		public unsafe string VersionString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamServerInit.NativeFieldInfoPtr_VersionString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamServerInit.NativeFieldInfoPtr_VersionString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000C7D RID: 3197 RVA: 0x00052F08 File Offset: 0x00051108
		// (set) Token: 0x06000C7E RID: 3198 RVA: 0x00003153 File Offset: 0x00001353
		public unsafe string ModDir
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamServerInit.NativeFieldInfoPtr_ModDir);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamServerInit.NativeFieldInfoPtr_ModDir), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000C7F RID: 3199 RVA: 0x00052F30 File Offset: 0x00051130
		// (set) Token: 0x06000C80 RID: 3200 RVA: 0x00003172 File Offset: 0x00001372
		public unsafe string GameDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamServerInit.NativeFieldInfoPtr_GameDescription);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamServerInit.NativeFieldInfoPtr_GameDescription), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000C81 RID: 3201 RVA: 0x00052F58 File Offset: 0x00051158
		// (set) Token: 0x06000C82 RID: 3202 RVA: 0x00003191 File Offset: 0x00001391
		public unsafe bool DedicatedServer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamServerInit.NativeFieldInfoPtr_DedicatedServer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamServerInit.NativeFieldInfoPtr_DedicatedServer)) = value;
			}
		}

		// Token: 0x0400130C RID: 4876
		private static readonly IntPtr NativeFieldInfoPtr_IpAddress;

		// Token: 0x0400130D RID: 4877
		private static readonly IntPtr NativeFieldInfoPtr_GamePort;

		// Token: 0x0400130E RID: 4878
		private static readonly IntPtr NativeFieldInfoPtr_QueryPort;

		// Token: 0x0400130F RID: 4879
		private static readonly IntPtr NativeFieldInfoPtr_Secure;

		// Token: 0x04001310 RID: 4880
		private static readonly IntPtr NativeFieldInfoPtr_VersionString;

		// Token: 0x04001311 RID: 4881
		private static readonly IntPtr NativeFieldInfoPtr_ModDir;

		// Token: 0x04001312 RID: 4882
		private static readonly IntPtr NativeFieldInfoPtr_GameDescription;

		// Token: 0x04001313 RID: 4883
		private static readonly IntPtr NativeFieldInfoPtr_DedicatedServer;

		// Token: 0x04001314 RID: 4884
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x04001315 RID: 4885
		private static readonly IntPtr NativeMethodInfoPtr_WithQueryShareGamePort_Public_SteamServerInit_0;
	}
}
