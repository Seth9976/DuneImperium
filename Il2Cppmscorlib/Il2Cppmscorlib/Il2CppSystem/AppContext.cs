using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem
{
	// Token: 0x02000124 RID: 292
	public static class AppContext : Object
	{
		// Token: 0x06001384 RID: 4996 RVA: 0x000848A4 File Offset: 0x00082AA4
		// Note: this type is marked as 'beforefieldinit'.
		static AppContext()
		{
			Il2CppClassPointerStore<AppContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "AppContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppContext>.NativeClassPtr);
			AppContext.NativeFieldInfoPtr_s_switchMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppContext>.NativeClassPtr, "s_switchMap");
			AppContext.NativeFieldInfoPtr_s_defaultsInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppContext>.NativeClassPtr, "s_defaultsInitialized");
			AppContext.NativeMethodInfoPtr_InitializeDefaultSwitchValues_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppContext>.NativeClassPtr, 100666774);
			AppContext.NativeMethodInfoPtr_TryGetSwitch_Public_Static_Boolean_String_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppContext>.NativeClassPtr, 100666775);
		}

		// Token: 0x06001385 RID: 4997 RVA: 0x00084924 File Offset: 0x00082B24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1338010, RefRangeEnd = 1338011, XrefRangeStart = 1337990, XrefRangeEnd = 1338010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeDefaultSwitchValues()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppContext.NativeMethodInfoPtr_InitializeDefaultSwitchValues_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x0008494C File Offset: 0x00082B4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1338061, RefRangeEnd = 1338063, XrefRangeStart = 1338011, XrefRangeEnd = 1338061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetSwitch(string switchName, out bool isEnabled)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(switchName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isEnabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppContext.NativeMethodInfoPtr_TryGetSwitch_Public_Static_Boolean_String_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001387 RID: 4999 RVA: 0x00006395 File Offset: 0x00004595
		public AppContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06001388 RID: 5000 RVA: 0x0008499C File Offset: 0x00082B9C
		// (set) Token: 0x06001389 RID: 5001 RVA: 0x0000639E File Offset: 0x0000459E
		public unsafe static Dictionary<string, AppContext.SwitchValueState> s_switchMap
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AppContext.NativeFieldInfoPtr_s_switchMap, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, AppContext.SwitchValueState>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AppContext.NativeFieldInfoPtr_s_switchMap, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x0600138A RID: 5002 RVA: 0x000849C4 File Offset: 0x00082BC4
		// (set) Token: 0x0600138B RID: 5003 RVA: 0x000063B0 File Offset: 0x000045B0
		public unsafe static bool s_defaultsInitialized
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(AppContext.NativeFieldInfoPtr_s_defaultsInitialized, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AppContext.NativeFieldInfoPtr_s_defaultsInitialized, (void*)(&value));
			}
		}

		// Token: 0x040010A7 RID: 4263
		private static readonly IntPtr NativeFieldInfoPtr_s_switchMap;

		// Token: 0x040010A8 RID: 4264
		private static readonly IntPtr NativeFieldInfoPtr_s_defaultsInitialized;

		// Token: 0x040010A9 RID: 4265
		private static readonly IntPtr NativeMethodInfoPtr_InitializeDefaultSwitchValues_Private_Static_Void_0;

		// Token: 0x040010AA RID: 4266
		private static readonly IntPtr NativeMethodInfoPtr_TryGetSwitch_Public_Static_Boolean_String_byref_Boolean_0;

		// Token: 0x020005E3 RID: 1507
		[Flags]
		public enum SwitchValueState
		{
			// Token: 0x0400479E RID: 18334
			HasFalseValue = 1,
			// Token: 0x0400479F RID: 18335
			HasTrueValue = 2,
			// Token: 0x040047A0 RID: 18336
			HasLookedForOverride = 4,
			// Token: 0x040047A1 RID: 18337
			UnknownValue = 8
		}
	}
}
