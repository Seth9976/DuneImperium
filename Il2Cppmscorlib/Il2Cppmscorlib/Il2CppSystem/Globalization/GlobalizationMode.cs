using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200047E RID: 1150
	public static class GlobalizationMode : Object
	{
		// Token: 0x06004542 RID: 17730 RVA: 0x001453D0 File Offset: 0x001435D0
		// Note: this type is marked as 'beforefieldinit'.
		static GlobalizationMode()
		{
			Il2CppClassPointerStore<GlobalizationMode>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "GlobalizationMode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalizationMode>.NativeClassPtr);
			GlobalizationMode.NativeFieldInfoPtr__Invariant_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalizationMode>.NativeClassPtr, "<Invariant>k__BackingField");
			GlobalizationMode.NativeMethodInfoPtr_get_Invariant_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalizationMode>.NativeClassPtr, 100673522);
			GlobalizationMode.NativeMethodInfoPtr_GetGlobalizationInvariantMode_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalizationMode>.NativeClassPtr, 100673523);
		}

		// Token: 0x17001132 RID: 4402
		// (get) Token: 0x06004543 RID: 17731 RVA: 0x0014543C File Offset: 0x0014363C
		public unsafe static bool Invariant
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409768, XrefRangeEnd = 1409772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalizationMode.NativeMethodInfoPtr_get_Invariant_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004544 RID: 17732 RVA: 0x0014546C File Offset: 0x0014366C
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetGlobalizationInvariantMode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalizationMode.NativeMethodInfoPtr_GetGlobalizationInvariantMode_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004545 RID: 17733 RVA: 0x000191C4 File Offset: 0x000173C4
		public GlobalizationMode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001131 RID: 4401
		// (get) Token: 0x06004546 RID: 17734 RVA: 0x0014549C File Offset: 0x0014369C
		// (set) Token: 0x06004547 RID: 17735 RVA: 0x000191CD File Offset: 0x000173CD
		public unsafe static bool _Invariant_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(GlobalizationMode.NativeFieldInfoPtr__Invariant_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GlobalizationMode.NativeFieldInfoPtr__Invariant_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x04003957 RID: 14679
		private static readonly IntPtr NativeFieldInfoPtr__Invariant_k__BackingField;

		// Token: 0x04003958 RID: 14680
		private static readonly IntPtr NativeMethodInfoPtr_get_Invariant_Internal_Static_get_Boolean_0;

		// Token: 0x04003959 RID: 14681
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalizationInvariantMode_Private_Static_Boolean_0;
	}
}
