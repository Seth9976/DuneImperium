using System;
using dwd.core.input.compositeModule.inputDetection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine.UI;

namespace dwd.core.input.compositeModule.navigation
{
	// Token: 0x02000095 RID: 149
	public sealed class NoNavigationNavigator : SelectionNavigator
	{
		// Token: 0x06000677 RID: 1655 RVA: 0x0001B7C4 File Offset: 0x000199C4
		// Note: this type is marked as 'beforefieldinit'.
		static NoNavigationNavigator()
		{
			Il2CppClassPointerStore<NoNavigationNavigator>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.compositeModule.navigation", "NoNavigationNavigator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoNavigationNavigator>.NativeClassPtr);
			NoNavigationNavigator.NativeMethodInfoPtr_GetSelectionNavigation_Public_Virtual_Boolean_InputDetector_Selectable_ICollection_1_Selectable_byref_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoNavigationNavigator>.NativeClassPtr, 100664091);
			NoNavigationNavigator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoNavigationNavigator>.NativeClassPtr, 100664092);
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x0001B81C File Offset: 0x00019A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125576, XrefRangeEnd = 1125577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool GetSelectionNavigation(InputDetector inputDetector, Selectable currentSelection, ICollection<Selectable> preferredSelectables, out Selectable newSelection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDetector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentSelection);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(preferredSelectables);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NoNavigationNavigator.NativeMethodInfoPtr_GetSelectionNavigation_Public_Virtual_Boolean_InputDetector_Selectable_ICollection_1_Selectable_byref_Selectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			newSelection = ((intPtr4 == 0) ? null : new Selectable(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x0001B8B4 File Offset: 0x00019AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125577, XrefRangeEnd = 1125582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoNavigationNavigator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoNavigationNavigator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoNavigationNavigator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x00005848 File Offset: 0x00003A48
		public NoNavigationNavigator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003EC RID: 1004
		private static readonly IntPtr NativeMethodInfoPtr_GetSelectionNavigation_Public_Virtual_Boolean_InputDetector_Selectable_ICollection_1_Selectable_byref_Selectable_0;

		// Token: 0x040003ED RID: 1005
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
