using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;

namespace ImaginationOverflow.UniversalDeepLinking.Providers
{
	// Token: 0x02000016 RID: 22
	public class WindowsLinkProvider : Object
	{
		// Token: 0x0600010B RID: 267 RVA: 0x0000638C File Offset: 0x0000458C
		// Note: this type is marked as 'beforefieldinit'.
		static WindowsLinkProvider()
		{
			Il2CppClassPointerStore<WindowsLinkProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("UniversalDeepLinking.dll", "ImaginationOverflow.UniversalDeepLinking.Providers", "WindowsLinkProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowsLinkProvider>.NativeClassPtr);
			WindowsLinkProvider.NativeFieldInfoPtr__steamBuild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsLinkProvider>.NativeClassPtr, "_steamBuild");
			WindowsLinkProvider.NativeFieldInfoPtr__schemes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsLinkProvider>.NativeClassPtr, "_schemes");
			WindowsLinkProvider.NativeFieldInfoPtr__linkReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsLinkProvider>.NativeClassPtr, "_linkReceived");
			WindowsLinkProvider.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsLinkProvider>.NativeClassPtr, 100663473);
			WindowsLinkProvider.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsLinkProvider>.NativeClassPtr, 100663474);
			WindowsLinkProvider.NativeMethodInfoPtr_Initialize_Public_Boolean_AppLinkingConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsLinkProvider>.NativeClassPtr, 100663475);
			WindowsLinkProvider.NativeMethodInfoPtr_GetExe_Private_String_Boolean_String_byref_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsLinkProvider>.NativeClassPtr, 100663476);
			WindowsLinkProvider.NativeMethodInfoPtr_SetAndGetAutoLauncher_Private_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsLinkProvider>.NativeClassPtr, 100663477);
			WindowsLinkProvider.NativeMethodInfoPtr_add__linkReceived_Private_add_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsLinkProvider>.NativeClassPtr, 100663478);
			WindowsLinkProvider.NativeMethodInfoPtr_remove__linkReceived_Private_rem_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsLinkProvider>.NativeClassPtr, 100663479);
			WindowsLinkProvider.NativeMethodInfoPtr_add_LinkReceived_Public_Virtual_Final_New_add_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsLinkProvider>.NativeClassPtr, 100663480);
			WindowsLinkProvider.NativeMethodInfoPtr_remove_LinkReceived_Public_Virtual_Final_New_rem_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsLinkProvider>.NativeClassPtr, 100663481);
			WindowsLinkProvider.NativeMethodInfoPtr_CheckArguments_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsLinkProvider>.NativeClassPtr, 100663482);
			WindowsLinkProvider.NativeMethodInfoPtr_PollInfoAfterPause_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsLinkProvider>.NativeClassPtr, 100663483);
			WindowsLinkProvider.NativeMethodInfoPtr_OnLinkReceived_Protected_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsLinkProvider>.NativeClassPtr, 100663484);
			WindowsLinkProvider.NativeMethodInfoPtr__CheckArguments_b__13_0_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsLinkProvider>.NativeClassPtr, 100663485);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000064FC File Offset: 0x000046FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241263, XrefRangeEnd = 1241271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WindowsLinkProvider(bool steamBuild)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WindowsLinkProvider>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamBuild;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsLinkProvider.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00006544 File Offset: 0x00004744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241271, XrefRangeEnd = 1241276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsLinkProvider.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00006580 File Offset: 0x00004780
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1241336, RefRangeEnd = 1241337, XrefRangeStart = 1241276, XrefRangeEnd = 1241336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Initialize(AppLinkingConfiguration config)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(config);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsLinkProvider.NativeMethodInfoPtr_Initialize_Public_Boolean_AppLinkingConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000065D0 File Offset: 0x000047D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1241356, RefRangeEnd = 1241357, XrefRangeStart = 1241337, XrefRangeEnd = 1241356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetExe(bool fromSteam, string steamAppId, out string args, bool autoDeferral)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fromSteam;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(steamAppId);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoDeferral;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(WindowsLinkProvider.NativeMethodInfoPtr_GetExe_Private_String_Boolean_String_byref_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			args = IL2CPP.Il2CppStringToManaged(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00006650 File Offset: 0x00004850
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1241449, RefRangeEnd = 1241450, XrefRangeStart = 1241357, XrefRangeEnd = 1241449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string SetAndGetAutoLauncher(bool fromSteam, string steamAppId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fromSteam;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(steamAppId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsLinkProvider.NativeMethodInfoPtr_SetAndGetAutoLauncher_Private_String_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000066A8 File Offset: 0x000048A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241450, XrefRangeEnd = 1241455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add__linkReceived(Action<string> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsLinkProvider.NativeMethodInfoPtr_add__linkReceived_Private_add_Void_Action_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000066EC File Offset: 0x000048EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241455, XrefRangeEnd = 1241460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove__linkReceived(Action<string> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsLinkProvider.NativeMethodInfoPtr_remove__linkReceived_Private_rem_Void_Action_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00006730 File Offset: 0x00004930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241460, XrefRangeEnd = 1241477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_LinkReceived(Action<string> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsLinkProvider.NativeMethodInfoPtr_add_LinkReceived_Public_Virtual_Final_New_add_Void_Action_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00006774 File Offset: 0x00004974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_LinkReceived(Action<string> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsLinkProvider.NativeMethodInfoPtr_remove_LinkReceived_Public_Virtual_Final_New_rem_Void_Action_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000067B8 File Offset: 0x000049B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241477, XrefRangeEnd = 1241489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckArguments()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsLinkProvider.NativeMethodInfoPtr_CheckArguments_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000067EC File Offset: 0x000049EC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PollInfoAfterPause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsLinkProvider.NativeMethodInfoPtr_PollInfoAfterPause_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00006820 File Offset: 0x00004A20
		[CallerCount(0)]
		public unsafe virtual void OnLinkReceived(string obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WindowsLinkProvider.NativeMethodInfoPtr_OnLinkReceived_Protected_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00006870 File Offset: 0x00004A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241489, XrefRangeEnd = 1241498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _CheckArguments_b__13_0(string a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsLinkProvider.NativeMethodInfoPtr__CheckArguments_b__13_0_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x000025DC File Offset: 0x000007DC
		public WindowsLinkProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600011A RID: 282 RVA: 0x000068C0 File Offset: 0x00004AC0
		// (set) Token: 0x0600011B RID: 283 RVA: 0x000025E5 File Offset: 0x000007E5
		public unsafe bool _steamBuild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsLinkProvider.NativeFieldInfoPtr__steamBuild);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsLinkProvider.NativeFieldInfoPtr__steamBuild)) = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600011C RID: 284 RVA: 0x000068E8 File Offset: 0x00004AE8
		// (set) Token: 0x0600011D RID: 285 RVA: 0x00002600 File Offset: 0x00000800
		public unsafe List<string> _schemes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsLinkProvider.NativeFieldInfoPtr__schemes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsLinkProvider.NativeFieldInfoPtr__schemes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00006918 File Offset: 0x00004B18
		// (set) Token: 0x0600011F RID: 287 RVA: 0x0000261F File Offset: 0x0000081F
		public unsafe Action<string> _linkReceived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsLinkProvider.NativeFieldInfoPtr__linkReceived);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsLinkProvider.NativeFieldInfoPtr__linkReceived), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeFieldInfoPtr__steamBuild;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeFieldInfoPtr__schemes;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeFieldInfoPtr__linkReceived;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Boolean_AppLinkingConfiguration_0;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr_GetExe_Private_String_Boolean_String_byref_String_Boolean_0;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr_SetAndGetAutoLauncher_Private_String_Boolean_String_0;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeMethodInfoPtr_add__linkReceived_Private_add_Void_Action_1_String_0;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr_remove__linkReceived_Private_rem_Void_Action_1_String_0;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeMethodInfoPtr_add_LinkReceived_Public_Virtual_Final_New_add_Void_Action_1_String_0;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr_remove_LinkReceived_Public_Virtual_Final_New_rem_Void_Action_1_String_0;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr_CheckArguments_Private_Void_0;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeMethodInfoPtr_PollInfoAfterPause_Public_Virtual_Final_New_Void_0;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeMethodInfoPtr_OnLinkReceived_Protected_Virtual_New_Void_String_0;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeMethodInfoPtr__CheckArguments_b__13_0_Private_Boolean_String_0;

		// Token: 0x02000020 RID: 32
		[ObfuscatedName("ImaginationOverflow.UniversalDeepLinking.Providers.WindowsLinkProvider+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x06000186 RID: 390 RVA: 0x00007DB0 File Offset: 0x00005FB0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<WindowsLinkProvider.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WindowsLinkProvider>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowsLinkProvider.__c__DisplayClass6_0>.NativeClassPtr);
				WindowsLinkProvider.__c__DisplayClass6_0.NativeFieldInfoPtr_sharedFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsLinkProvider.__c__DisplayClass6_0>.NativeClassPtr, "sharedFileName");
				WindowsLinkProvider.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsLinkProvider.__c__DisplayClass6_0>.NativeClassPtr, "<>4__this");
				WindowsLinkProvider.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsLinkProvider.__c__DisplayClass6_0>.NativeClassPtr, 100663486);
				WindowsLinkProvider.__c__DisplayClass6_0.NativeMethodInfoPtr__SetAndGetAutoLauncher_b__0_Internal_Void_Object_FileSystemEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsLinkProvider.__c__DisplayClass6_0>.NativeClassPtr, 100663487);
			}

			// Token: 0x06000187 RID: 391 RVA: 0x00007E2C File Offset: 0x0000602C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WindowsLinkProvider.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsLinkProvider.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000188 RID: 392 RVA: 0x00007E68 File Offset: 0x00006068
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241235, XrefRangeEnd = 1241255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetAndGetAutoLauncher_b__0(Object s, FileSystemEventArgs f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(f);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsLinkProvider.__c__DisplayClass6_0.NativeMethodInfoPtr__SetAndGetAutoLauncher_b__0_Internal_Void_Object_FileSystemEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000189 RID: 393 RVA: 0x000028C1 File Offset: 0x00000AC1
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000060 RID: 96
			// (get) Token: 0x0600018A RID: 394 RVA: 0x00007EBC File Offset: 0x000060BC
			// (set) Token: 0x0600018B RID: 395 RVA: 0x000028CA File Offset: 0x00000ACA
			public unsafe string sharedFileName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsLinkProvider.__c__DisplayClass6_0.NativeFieldInfoPtr_sharedFileName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsLinkProvider.__c__DisplayClass6_0.NativeFieldInfoPtr_sharedFileName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000061 RID: 97
			// (get) Token: 0x0600018C RID: 396 RVA: 0x00007EE4 File Offset: 0x000060E4
			// (set) Token: 0x0600018D RID: 397 RVA: 0x000028E9 File Offset: 0x00000AE9
			public unsafe WindowsLinkProvider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsLinkProvider.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WindowsLinkProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsLinkProvider.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000109 RID: 265
			private static readonly IntPtr NativeFieldInfoPtr_sharedFileName;

			// Token: 0x0400010A RID: 266
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400010B RID: 267
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400010C RID: 268
			private static readonly IntPtr NativeMethodInfoPtr__SetAndGetAutoLauncher_b__0_Internal_Void_Object_FileSystemEventArgs_0;
		}

		// Token: 0x02000021 RID: 33
		[ObfuscatedName("ImaginationOverflow.UniversalDeepLinking.Providers.WindowsLinkProvider+<>c__DisplayClass6_1")]
		public sealed class __c__DisplayClass6_1 : Object
		{
			// Token: 0x0600018E RID: 398 RVA: 0x00007F14 File Offset: 0x00006114
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_1()
			{
				Il2CppClassPointerStore<WindowsLinkProvider.__c__DisplayClass6_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WindowsLinkProvider>.NativeClassPtr, "<>c__DisplayClass6_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowsLinkProvider.__c__DisplayClass6_1>.NativeClassPtr);
				WindowsLinkProvider.__c__DisplayClass6_1.NativeFieldInfoPtr_dp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsLinkProvider.__c__DisplayClass6_1>.NativeClassPtr, "dp");
				WindowsLinkProvider.__c__DisplayClass6_1.NativeFieldInfoPtr_field_Public___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsLinkProvider.__c__DisplayClass6_1>.NativeClassPtr, "CS$<>8__locals1");
				WindowsLinkProvider.__c__DisplayClass6_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsLinkProvider.__c__DisplayClass6_1>.NativeClassPtr, 100663488);
				WindowsLinkProvider.__c__DisplayClass6_1.NativeMethodInfoPtr__SetAndGetAutoLauncher_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsLinkProvider.__c__DisplayClass6_1>.NativeClassPtr, 100663489);
			}

			// Token: 0x0600018F RID: 399 RVA: 0x00007F90 File Offset: 0x00006190
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WindowsLinkProvider.__c__DisplayClass6_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsLinkProvider.__c__DisplayClass6_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000190 RID: 400 RVA: 0x00007FCC File Offset: 0x000061CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241255, XrefRangeEnd = 1241263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetAndGetAutoLauncher_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsLinkProvider.__c__DisplayClass6_1.NativeMethodInfoPtr__SetAndGetAutoLauncher_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000191 RID: 401 RVA: 0x00002908 File Offset: 0x00000B08
			public __c__DisplayClass6_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000062 RID: 98
			// (get) Token: 0x06000192 RID: 402 RVA: 0x00008000 File Offset: 0x00006200
			// (set) Token: 0x06000193 RID: 403 RVA: 0x00002911 File Offset: 0x00000B11
			public unsafe string dp
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsLinkProvider.__c__DisplayClass6_1.NativeFieldInfoPtr_dp);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsLinkProvider.__c__DisplayClass6_1.NativeFieldInfoPtr_dp), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000063 RID: 99
			// (get) Token: 0x06000194 RID: 404 RVA: 0x00008028 File Offset: 0x00006228
			// (set) Token: 0x06000195 RID: 405 RVA: 0x00002930 File Offset: 0x00000B30
			public unsafe WindowsLinkProvider.__c__DisplayClass6_0 field_Public___c__DisplayClass6_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsLinkProvider.__c__DisplayClass6_1.NativeFieldInfoPtr_field_Public___c__DisplayClass6_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WindowsLinkProvider.__c__DisplayClass6_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsLinkProvider.__c__DisplayClass6_1.NativeFieldInfoPtr_field_Public___c__DisplayClass6_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400010D RID: 269
			private static readonly IntPtr NativeFieldInfoPtr_dp;

			// Token: 0x0400010E RID: 270
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass6_0_0;

			// Token: 0x0400010F RID: 271
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000110 RID: 272
			private static readonly IntPtr NativeMethodInfoPtr__SetAndGetAutoLauncher_b__1_Internal_Void_0;
		}
	}
}
