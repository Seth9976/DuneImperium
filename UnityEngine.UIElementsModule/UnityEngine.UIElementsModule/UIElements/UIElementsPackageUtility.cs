using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020001E1 RID: 481
	public static class UIElementsPackageUtility : Object
	{
		// Token: 0x060025FD RID: 9725 RVA: 0x000A9808 File Offset: 0x000A7A08
		// Note: this type is marked as 'beforefieldinit'.
		static UIElementsPackageUtility()
		{
			Il2CppClassPointerStore<UIElementsPackageUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UIElementsPackageUtility");
			UIElementsPackageUtility.NativeFieldInfoPtr__IsUIEPackageLoaded_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsPackageUtility>.NativeClassPtr, "<IsUIEPackageLoaded>k__BackingField");
			UIElementsPackageUtility.NativeFieldInfoPtr__EditorResourcesBasePath_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsPackageUtility>.NativeClassPtr, "<EditorResourcesBasePath>k__BackingField");
			UIElementsPackageUtility.NativeMethodInfoPtr_get_IsUIEPackageLoaded_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsPackageUtility>.NativeClassPtr, 100669052);
			UIElementsPackageUtility.NativeMethodInfoPtr_set_IsUIEPackageLoaded_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsPackageUtility>.NativeClassPtr, 100669053);
			UIElementsPackageUtility.NativeMethodInfoPtr_get_EditorResourcesBasePath_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsPackageUtility>.NativeClassPtr, 100669054);
			UIElementsPackageUtility.NativeMethodInfoPtr_set_EditorResourcesBasePath_Private_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsPackageUtility>.NativeClassPtr, 100669055);
			UIElementsPackageUtility.NativeMethodInfoPtr_Refresh_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsPackageUtility>.NativeClassPtr, 100669057);
		}

		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x060025FE RID: 9726 RVA: 0x000A98BC File Offset: 0x000A7ABC
		// (set) Token: 0x060025FF RID: 9727 RVA: 0x000A98EC File Offset: 0x000A7AEC
		public unsafe static bool IsUIEPackageLoaded
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340080, XrefRangeEnd = 340084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsPackageUtility.NativeMethodInfoPtr_get_IsUIEPackageLoaded_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340084, XrefRangeEnd = 340088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsPackageUtility.NativeMethodInfoPtr_set_IsUIEPackageLoaded_Private_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x06002600 RID: 9728 RVA: 0x000A9920 File Offset: 0x000A7B20
		// (set) Token: 0x06002601 RID: 9729 RVA: 0x000A994C File Offset: 0x000A7B4C
		public unsafe static string EditorResourcesBasePath
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340088, XrefRangeEnd = 340092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsPackageUtility.NativeMethodInfoPtr_get_EditorResourcesBasePath_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340092, XrefRangeEnd = 340098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsPackageUtility.NativeMethodInfoPtr_set_EditorResourcesBasePath_Private_Static_set_Void_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002602 RID: 9730 RVA: 0x000A9984 File Offset: 0x000A7B84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340098, XrefRangeEnd = 340113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Refresh()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsPackageUtility.NativeMethodInfoPtr_Refresh_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002603 RID: 9731 RVA: 0x0000F7BD File Offset: 0x0000D9BD
		public UIElementsPackageUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x06002604 RID: 9732 RVA: 0x000A99AC File Offset: 0x000A7BAC
		// (set) Token: 0x06002605 RID: 9733 RVA: 0x0000F7C6 File Offset: 0x0000D9C6
		public unsafe static bool _IsUIEPackageLoaded_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(UIElementsPackageUtility.NativeFieldInfoPtr__IsUIEPackageLoaded_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsPackageUtility.NativeFieldInfoPtr__IsUIEPackageLoaded_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x06002606 RID: 9734 RVA: 0x000A99C8 File Offset: 0x000A7BC8
		// (set) Token: 0x06002607 RID: 9735 RVA: 0x0000F7D4 File Offset: 0x0000D9D4
		public unsafe static string _EditorResourcesBasePath_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIElementsPackageUtility.NativeFieldInfoPtr__EditorResourcesBasePath_k__BackingField, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsPackageUtility.NativeFieldInfoPtr__EditorResourcesBasePath_k__BackingField, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001B5F RID: 7007
		private static readonly IntPtr NativeFieldInfoPtr__IsUIEPackageLoaded_k__BackingField;

		// Token: 0x04001B60 RID: 7008
		private static readonly IntPtr NativeFieldInfoPtr__EditorResourcesBasePath_k__BackingField;

		// Token: 0x04001B61 RID: 7009
		private static readonly IntPtr NativeMethodInfoPtr_get_IsUIEPackageLoaded_Internal_Static_get_Boolean_0;

		// Token: 0x04001B62 RID: 7010
		private static readonly IntPtr NativeMethodInfoPtr_set_IsUIEPackageLoaded_Private_Static_set_Void_Boolean_0;

		// Token: 0x04001B63 RID: 7011
		private static readonly IntPtr NativeMethodInfoPtr_get_EditorResourcesBasePath_Internal_Static_get_String_0;

		// Token: 0x04001B64 RID: 7012
		private static readonly IntPtr NativeMethodInfoPtr_set_EditorResourcesBasePath_Private_Static_set_Void_String_0;

		// Token: 0x04001B65 RID: 7013
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Internal_Static_Void_0;
	}
}
