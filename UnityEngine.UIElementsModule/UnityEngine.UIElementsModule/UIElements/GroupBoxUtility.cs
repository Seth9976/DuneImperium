using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine.UIElements
{
	// Token: 0x0200013A RID: 314
	public static class GroupBoxUtility : Object
	{
		// Token: 0x06001799 RID: 6041 RVA: 0x00070940 File Offset: 0x0006EB40
		// Note: this type is marked as 'beforefieldinit'.
		static GroupBoxUtility()
		{
			Il2CppClassPointerStore<GroupBoxUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "GroupBoxUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GroupBoxUtility>.NativeClassPtr);
			GroupBoxUtility.NativeFieldInfoPtr_s_GroupManagers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupBoxUtility>.NativeClassPtr, "s_GroupManagers");
			GroupBoxUtility.NativeFieldInfoPtr_s_GroupOptionManagerCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupBoxUtility>.NativeClassPtr, "s_GroupOptionManagerCache");
			GroupBoxUtility.NativeFieldInfoPtr_k_GenericGroupBoxType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupBoxUtility>.NativeClassPtr, "k_GenericGroupBoxType");
			GroupBoxUtility.NativeMethodInfoPtr_RegisterGroupBoxOption_Public_Static_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupBoxUtility>.NativeClassPtr, 100666815);
			GroupBoxUtility.NativeMethodInfoPtr_UnregisterGroupBoxOption_Public_Static_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupBoxUtility>.NativeClassPtr, 100666816);
			GroupBoxUtility.NativeMethodInfoPtr_OnOptionSelected_Public_Static_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupBoxUtility>.NativeClassPtr, 100666817);
			GroupBoxUtility.NativeMethodInfoPtr_FindOrCreateGroupManager_Private_Static_IGroupManager_IGroupBox_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupBoxUtility>.NativeClassPtr, 100666818);
			GroupBoxUtility.NativeMethodInfoPtr_OnGroupBoxDetachedFromPanel_Private_Static_Void_DetachFromPanelEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupBoxUtility>.NativeClassPtr, 100666819);
			GroupBoxUtility.NativeMethodInfoPtr_OnPanelDestroyed_Private_Static_Void_BaseVisualElementPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupBoxUtility>.NativeClassPtr, 100666820);
		}

		// Token: 0x0600179A RID: 6042 RVA: 0x00070A24 File Offset: 0x0006EC24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 319157, RefRangeEnd = 319158, XrefRangeStart = 319141, XrefRangeEnd = 319157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterGroupBoxOption<T>(this T option) where T : VisualElement
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = option;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref option;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(GroupBoxUtility.MethodInfoStoreGeneric_RegisterGroupBoxOption_Public_Static_Void_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x0600179B RID: 6043 RVA: 0x00070A90 File Offset: 0x0006EC90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 319178, RefRangeEnd = 319179, XrefRangeStart = 319158, XrefRangeEnd = 319178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnregisterGroupBoxOption<T>(this T option) where T : VisualElement
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = option;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref option;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(GroupBoxUtility.MethodInfoStoreGeneric_UnregisterGroupBoxOption_Public_Static_Void_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x0600179C RID: 6044 RVA: 0x00070AFC File Offset: 0x0006ECFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 319195, RefRangeEnd = 319196, XrefRangeStart = 319179, XrefRangeEnd = 319195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnOptionSelected<T>(this T selectedOption) where T : VisualElement
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = selectedOption;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref selectedOption;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(GroupBoxUtility.MethodInfoStoreGeneric_OnOptionSelected_Public_Static_Void_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x0600179D RID: 6045 RVA: 0x00070B68 File Offset: 0x0006ED68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 319269, RefRangeEnd = 319270, XrefRangeStart = 319196, XrefRangeEnd = 319269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IGroupManager FindOrCreateGroupManager(IGroupBox groupBox)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(groupBox);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupBoxUtility.NativeMethodInfoPtr_FindOrCreateGroupManager_Private_Static_IGroupManager_IGroupBox_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IGroupManager>(intPtr3) : null;
			}
		}

		// Token: 0x0600179E RID: 6046 RVA: 0x00070BAC File Offset: 0x0006EDAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319270, XrefRangeEnd = 319281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnGroupBoxDetachedFromPanel(DetachFromPanelEvent evt)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupBoxUtility.NativeMethodInfoPtr_OnGroupBoxDetachedFromPanel_Private_Static_Void_DetachFromPanelEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600179F RID: 6047 RVA: 0x00070BE4 File Offset: 0x0006EDE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319281, XrefRangeEnd = 319299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnPanelDestroyed(BaseVisualElementPanel panel)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupBoxUtility.NativeMethodInfoPtr_OnPanelDestroyed_Private_Static_Void_BaseVisualElementPanel_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017A0 RID: 6048 RVA: 0x0000AE11 File Offset: 0x00009011
		public GroupBoxUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x060017A1 RID: 6049 RVA: 0x00070C1C File Offset: 0x0006EE1C
		// (set) Token: 0x060017A2 RID: 6050 RVA: 0x0000AE1A File Offset: 0x0000901A
		public unsafe static Dictionary<IGroupBox, IGroupManager> s_GroupManagers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GroupBoxUtility.NativeFieldInfoPtr_s_GroupManagers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<IGroupBox, IGroupManager>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GroupBoxUtility.NativeFieldInfoPtr_s_GroupManagers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x060017A3 RID: 6051 RVA: 0x00070C44 File Offset: 0x0006EE44
		// (set) Token: 0x060017A4 RID: 6052 RVA: 0x0000AE2C File Offset: 0x0000902C
		public unsafe static Dictionary<IGroupBoxOption, IGroupManager> s_GroupOptionManagerCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GroupBoxUtility.NativeFieldInfoPtr_s_GroupOptionManagerCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<IGroupBoxOption, IGroupManager>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GroupBoxUtility.NativeFieldInfoPtr_s_GroupOptionManagerCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x060017A5 RID: 6053 RVA: 0x00070C6C File Offset: 0x0006EE6C
		// (set) Token: 0x060017A6 RID: 6054 RVA: 0x0000AE3E File Offset: 0x0000903E
		public unsafe static Type k_GenericGroupBoxType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GroupBoxUtility.NativeFieldInfoPtr_k_GenericGroupBoxType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GroupBoxUtility.NativeFieldInfoPtr_k_GenericGroupBoxType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060017A7 RID: 6055 RVA: 0x00070C94 File Offset: 0x0006EE94
		public static IGroupBoxOption GetSelectedOption(IGroupBox groupBox)
		{
			return (!GroupBoxUtility.s_GroupManagers.ContainsKey(groupBox)) ? null : GroupBoxUtility.s_GroupManagers[groupBox].GetSelectedOption();
		}

		// Token: 0x060017A8 RID: 6056 RVA: 0x00070CC8 File Offset: 0x0006EEC8
		public static IGroupManager GetGroupManager(IGroupBox groupBox)
		{
			return GroupBoxUtility.s_GroupManagers.ContainsKey(groupBox) ? GroupBoxUtility.s_GroupManagers[groupBox] : null;
		}

		// Token: 0x04001022 RID: 4130
		private static readonly IntPtr NativeFieldInfoPtr_s_GroupManagers;

		// Token: 0x04001023 RID: 4131
		private static readonly IntPtr NativeFieldInfoPtr_s_GroupOptionManagerCache;

		// Token: 0x04001024 RID: 4132
		private static readonly IntPtr NativeFieldInfoPtr_k_GenericGroupBoxType;

		// Token: 0x04001025 RID: 4133
		private static readonly IntPtr NativeMethodInfoPtr_RegisterGroupBoxOption_Public_Static_Void_T_0;

		// Token: 0x04001026 RID: 4134
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterGroupBoxOption_Public_Static_Void_T_0;

		// Token: 0x04001027 RID: 4135
		private static readonly IntPtr NativeMethodInfoPtr_OnOptionSelected_Public_Static_Void_T_0;

		// Token: 0x04001028 RID: 4136
		private static readonly IntPtr NativeMethodInfoPtr_FindOrCreateGroupManager_Private_Static_IGroupManager_IGroupBox_0;

		// Token: 0x04001029 RID: 4137
		private static readonly IntPtr NativeMethodInfoPtr_OnGroupBoxDetachedFromPanel_Private_Static_Void_DetachFromPanelEvent_0;

		// Token: 0x0400102A RID: 4138
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelDestroyed_Private_Static_Void_BaseVisualElementPanel_0;

		// Token: 0x0200046B RID: 1131
		private sealed class MethodInfoStoreGeneric_RegisterGroupBoxOption_Public_Static_Void_T_0<T>
		{
			// Token: 0x04002A59 RID: 10841
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GroupBoxUtility.NativeMethodInfoPtr_RegisterGroupBoxOption_Public_Static_Void_T_0, Il2CppClassPointerStore<GroupBoxUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200046C RID: 1132
		private sealed class MethodInfoStoreGeneric_UnregisterGroupBoxOption_Public_Static_Void_T_0<T>
		{
			// Token: 0x04002A5A RID: 10842
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GroupBoxUtility.NativeMethodInfoPtr_UnregisterGroupBoxOption_Public_Static_Void_T_0, Il2CppClassPointerStore<GroupBoxUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200046D RID: 1133
		private sealed class MethodInfoStoreGeneric_OnOptionSelected_Public_Static_Void_T_0<T>
		{
			// Token: 0x04002A5B RID: 10843
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GroupBoxUtility.NativeMethodInfoPtr_OnOptionSelected_Public_Static_Void_T_0, Il2CppClassPointerStore<GroupBoxUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
