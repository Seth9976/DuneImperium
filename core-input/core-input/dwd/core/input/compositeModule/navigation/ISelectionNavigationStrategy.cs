using System;
using dwd.core.input.compositeModule.inputDetection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using UnityEngine.UI;

namespace dwd.core.input.compositeModule.navigation
{
	// Token: 0x02000094 RID: 148
	public class ISelectionNavigationStrategy : Il2CppObjectBase
	{
		// Token: 0x06000674 RID: 1652 RVA: 0x00005810 File Offset: 0x00003A10
		// Note: this type is marked as 'beforefieldinit'.
		static ISelectionNavigationStrategy()
		{
			Il2CppClassPointerStore<ISelectionNavigationStrategy>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.compositeModule.navigation", "ISelectionNavigationStrategy");
			ISelectionNavigationStrategy.NativeMethodInfoPtr_GetSelectionNavigation_Public_Abstract_Virtual_New_Boolean_InputDetector_Selectable_ICollection_1_Selectable_byref_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectionNavigationStrategy>.NativeClassPtr, 100664090);
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x0001B724 File Offset: 0x00019924
		[CallerCount(0)]
		public unsafe virtual bool GetSelectionNavigation(InputDetector inputDetector, Selectable currentSelection, ICollection<Selectable> validSelectables, out Selectable newSelection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDetector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentSelection);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(validSelectables);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISelectionNavigationStrategy.NativeMethodInfoPtr_GetSelectionNavigation_Public_Abstract_Virtual_New_Boolean_InputDetector_Selectable_ICollection_1_Selectable_byref_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			newSelection = ((intPtr4 == 0) ? null : new Selectable(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x0000583F File Offset: 0x00003A3F
		public ISelectionNavigationStrategy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003EB RID: 1003
		private static readonly IntPtr NativeMethodInfoPtr_GetSelectionNavigation_Public_Abstract_Virtual_New_Boolean_InputDetector_Selectable_ICollection_1_Selectable_byref_Selectable_0;
	}
}
