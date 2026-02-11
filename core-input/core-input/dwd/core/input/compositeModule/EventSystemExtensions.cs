using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace dwd.core.input.compositeModule
{
	// Token: 0x0200008B RID: 139
	public static class EventSystemExtensions : global::Il2CppSystem.Object
	{
		// Token: 0x0600060F RID: 1551 RVA: 0x0001A0B4 File Offset: 0x000182B4
		// Note: this type is marked as 'beforefieldinit'.
		static EventSystemExtensions()
		{
			Il2CppClassPointerStore<EventSystemExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.compositeModule", "EventSystemExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventSystemExtensions>.NativeClassPtr);
			EventSystemExtensions.NativeMethodInfoPtr_IsSelectionAllowed_Public_Static_Boolean_EventSystem_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystemExtensions>.NativeClassPtr, 100664045);
			EventSystemExtensions.NativeMethodInfoPtr_IsSelectionAllowed_Public_Static_Boolean_EventSystem_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystemExtensions>.NativeClassPtr, 100664046);
			EventSystemExtensions.NativeMethodInfoPtr_isSelectionAllowed_Private_Static_Boolean_EventSystem_GameObject_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystemExtensions>.NativeClassPtr, 100664047);
			EventSystemExtensions.NativeMethodInfoPtr_SelectIfAllowed_Public_Static_Boolean_EventSystem_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystemExtensions>.NativeClassPtr, 100664048);
			EventSystemExtensions.NativeMethodInfoPtr_SelectIfAllowed_Public_Static_Boolean_EventSystem_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystemExtensions>.NativeClassPtr, 100664049);
			EventSystemExtensions.NativeMethodInfoPtr_GetCurrentModuleType_Public_Static_String_EventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystemExtensions>.NativeClassPtr, 100664050);
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x0001A15C File Offset: 0x0001835C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125059, XrefRangeEnd = 1125064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSelectionAllowed(this EventSystem eventSystem, GameObject go)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventSystem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(go);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystemExtensions.NativeMethodInfoPtr_IsSelectionAllowed_Public_Static_Boolean_EventSystem_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x0001A1B0 File Offset: 0x000183B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125064, XrefRangeEnd = 1125068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSelectionAllowed(this EventSystem eventSystem, Selectable selectable)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventSystem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystemExtensions.NativeMethodInfoPtr_IsSelectionAllowed_Public_Static_Boolean_EventSystem_Selectable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x0001A204 File Offset: 0x00018404
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1125094, RefRangeEnd = 1125096, XrefRangeStart = 1125068, XrefRangeEnd = 1125094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool isSelectionAllowed(this EventSystem eventSystem, GameObject go, Selectable selectableOnGO)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventSystem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(go);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectableOnGO);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystemExtensions.NativeMethodInfoPtr_isSelectionAllowed_Private_Static_Boolean_EventSystem_GameObject_Selectable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x0001A26C File Offset: 0x0001846C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1125104, RefRangeEnd = 1125105, XrefRangeStart = 1125096, XrefRangeEnd = 1125104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SelectIfAllowed(this EventSystem eventSystem, GameObject go)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventSystem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(go);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystemExtensions.NativeMethodInfoPtr_SelectIfAllowed_Public_Static_Boolean_EventSystem_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x0001A2C0 File Offset: 0x000184C0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1125112, RefRangeEnd = 1125122, XrefRangeStart = 1125105, XrefRangeEnd = 1125112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SelectIfAllowed(this EventSystem eventSystem, Selectable selectable)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventSystem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystemExtensions.NativeMethodInfoPtr_SelectIfAllowed_Public_Static_Boolean_EventSystem_Selectable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x0001A314 File Offset: 0x00018514
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1125129, RefRangeEnd = 1125130, XrefRangeStart = 1125122, XrefRangeEnd = 1125129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetCurrentModuleType(this EventSystem eventSystem)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventSystem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystemExtensions.NativeMethodInfoPtr_GetCurrentModuleType_Public_Static_String_EventSystem_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x0000550B File Offset: 0x0000370B
		public EventSystemExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003AB RID: 939
		private static readonly IntPtr NativeMethodInfoPtr_IsSelectionAllowed_Public_Static_Boolean_EventSystem_GameObject_0;

		// Token: 0x040003AC RID: 940
		private static readonly IntPtr NativeMethodInfoPtr_IsSelectionAllowed_Public_Static_Boolean_EventSystem_Selectable_0;

		// Token: 0x040003AD RID: 941
		private static readonly IntPtr NativeMethodInfoPtr_isSelectionAllowed_Private_Static_Boolean_EventSystem_GameObject_Selectable_0;

		// Token: 0x040003AE RID: 942
		private static readonly IntPtr NativeMethodInfoPtr_SelectIfAllowed_Public_Static_Boolean_EventSystem_GameObject_0;

		// Token: 0x040003AF RID: 943
		private static readonly IntPtr NativeMethodInfoPtr_SelectIfAllowed_Public_Static_Boolean_EventSystem_Selectable_0;

		// Token: 0x040003B0 RID: 944
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentModuleType_Public_Static_String_EventSystem_0;
	}
}
