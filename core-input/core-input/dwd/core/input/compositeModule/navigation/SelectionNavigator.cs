using System;
using dwd.core.input.compositeModule.inputDetection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace dwd.core.input.compositeModule.navigation
{
	// Token: 0x02000096 RID: 150
	public class SelectionNavigator : UIBehaviour
	{
		// Token: 0x0600067B RID: 1659 RVA: 0x0001B8F0 File Offset: 0x00019AF0
		// Note: this type is marked as 'beforefieldinit'.
		static SelectionNavigator()
		{
			Il2CppClassPointerStore<SelectionNavigator>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.compositeModule.navigation", "SelectionNavigator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionNavigator>.NativeClassPtr);
			SelectionNavigator.NativeFieldInfoPtr_navigationStrategy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionNavigator>.NativeClassPtr, "navigationStrategy");
			SelectionNavigator.NativeMethodInfoPtr_get_StrategyName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNavigator>.NativeClassPtr, 100664093);
			SelectionNavigator.NativeMethodInfoPtr_GetSelectionNavigation_Public_Abstract_Virtual_New_Boolean_InputDetector_Selectable_ICollection_1_Selectable_byref_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNavigator>.NativeClassPtr, 100664094);
			SelectionNavigator.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNavigator>.NativeClassPtr, 100664095);
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x0600067C RID: 1660 RVA: 0x0001B970 File Offset: 0x00019B70
		public unsafe virtual string StrategyName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionNavigator.NativeMethodInfoPtr_get_StrategyName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x0001B9A8 File Offset: 0x00019BA8
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionNavigator.NativeMethodInfoPtr_GetSelectionNavigation_Public_Abstract_Virtual_New_Boolean_InputDetector_Selectable_ICollection_1_Selectable_byref_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			newSelection = ((intPtr4 == 0) ? null : new Selectable(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x0001BA48 File Offset: 0x00019C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionNavigator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionNavigator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionNavigator.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x00005851 File Offset: 0x00003A51
		public SelectionNavigator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000680 RID: 1664 RVA: 0x0001BA84 File Offset: 0x00019C84
		// (set) Token: 0x06000681 RID: 1665 RVA: 0x0000585A File Offset: 0x00003A5A
		public unsafe string navigationStrategy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionNavigator.NativeFieldInfoPtr_navigationStrategy);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionNavigator.NativeFieldInfoPtr_navigationStrategy), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040003EE RID: 1006
		private static readonly IntPtr NativeFieldInfoPtr_navigationStrategy;

		// Token: 0x040003EF RID: 1007
		private static readonly IntPtr NativeMethodInfoPtr_get_StrategyName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040003F0 RID: 1008
		private static readonly IntPtr NativeMethodInfoPtr_GetSelectionNavigation_Public_Abstract_Virtual_New_Boolean_InputDetector_Selectable_ICollection_1_Selectable_byref_Selectable_0;

		// Token: 0x040003F1 RID: 1009
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
