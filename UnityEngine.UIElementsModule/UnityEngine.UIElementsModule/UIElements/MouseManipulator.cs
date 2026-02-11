using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x0200014D RID: 333
	public class MouseManipulator : Manipulator
	{
		// Token: 0x06001869 RID: 6249 RVA: 0x000737E0 File Offset: 0x000719E0
		// Note: this type is marked as 'beforefieldinit'.
		static MouseManipulator()
		{
			Il2CppClassPointerStore<MouseManipulator>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "MouseManipulator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseManipulator>.NativeClassPtr);
			MouseManipulator.NativeFieldInfoPtr__activators_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseManipulator>.NativeClassPtr, "<activators>k__BackingField");
			MouseManipulator.NativeFieldInfoPtr_m_currentActivator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseManipulator>.NativeClassPtr, "m_currentActivator");
			MouseManipulator.NativeMethodInfoPtr_get_activators_Public_get_List_1_ManipulatorActivationFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseManipulator>.NativeClassPtr, 100666917);
			MouseManipulator.NativeMethodInfoPtr_set_activators_Private_set_Void_List_1_ManipulatorActivationFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseManipulator>.NativeClassPtr, 100666918);
			MouseManipulator.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseManipulator>.NativeClassPtr, 100666919);
			MouseManipulator.NativeMethodInfoPtr_CanStartManipulation_Protected_Boolean_IMouseEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseManipulator>.NativeClassPtr, 100666920);
			MouseManipulator.NativeMethodInfoPtr_CanStopManipulation_Protected_Boolean_IMouseEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseManipulator>.NativeClassPtr, 100666921);
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x0600186A RID: 6250 RVA: 0x0007389C File Offset: 0x00071A9C
		// (set) Token: 0x0600186B RID: 6251 RVA: 0x000738DC File Offset: 0x00071ADC
		public unsafe List<ManipulatorActivationFilter> activators
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseManipulator.NativeMethodInfoPtr_get_activators_Public_get_List_1_ManipulatorActivationFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ManipulatorActivationFilter>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseManipulator.NativeMethodInfoPtr_set_activators_Private_set_Void_List_1_ManipulatorActivationFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x00073920 File Offset: 0x00071B20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 320277, RefRangeEnd = 320279, XrefRangeStart = 320253, XrefRangeEnd = 320277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseManipulator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseManipulator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseManipulator.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600186D RID: 6253 RVA: 0x0007395C File Offset: 0x00071B5C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 320303, RefRangeEnd = 320308, XrefRangeStart = 320279, XrefRangeEnd = 320303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanStartManipulation(IMouseEvent e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseManipulator.NativeMethodInfoPtr_CanStartManipulation_Protected_Boolean_IMouseEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600186E RID: 6254 RVA: 0x000739AC File Offset: 0x00071BAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 320311, RefRangeEnd = 320313, XrefRangeStart = 320308, XrefRangeEnd = 320311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanStopManipulation(IMouseEvent e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseManipulator.NativeMethodInfoPtr_CanStopManipulation_Protected_Boolean_IMouseEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600186F RID: 6255 RVA: 0x0000B30B File Offset: 0x0000950B
		public MouseManipulator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06001870 RID: 6256 RVA: 0x000739FC File Offset: 0x00071BFC
		// (set) Token: 0x06001871 RID: 6257 RVA: 0x0000B314 File Offset: 0x00009514
		public unsafe List<ManipulatorActivationFilter> _activators_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseManipulator.NativeFieldInfoPtr__activators_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ManipulatorActivationFilter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseManipulator.NativeFieldInfoPtr__activators_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06001872 RID: 6258 RVA: 0x00073A2C File Offset: 0x00071C2C
		// (set) Token: 0x06001873 RID: 6259 RVA: 0x0000B333 File Offset: 0x00009533
		public unsafe ManipulatorActivationFilter m_currentActivator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseManipulator.NativeFieldInfoPtr_m_currentActivator);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseManipulator.NativeFieldInfoPtr_m_currentActivator)) = value;
			}
		}

		// Token: 0x040010C1 RID: 4289
		private static readonly IntPtr NativeFieldInfoPtr__activators_k__BackingField;

		// Token: 0x040010C2 RID: 4290
		private static readonly IntPtr NativeFieldInfoPtr_m_currentActivator;

		// Token: 0x040010C3 RID: 4291
		private static readonly IntPtr NativeMethodInfoPtr_get_activators_Public_get_List_1_ManipulatorActivationFilter_0;

		// Token: 0x040010C4 RID: 4292
		private static readonly IntPtr NativeMethodInfoPtr_set_activators_Private_set_Void_List_1_ManipulatorActivationFilter_0;

		// Token: 0x040010C5 RID: 4293
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040010C6 RID: 4294
		private static readonly IntPtr NativeMethodInfoPtr_CanStartManipulation_Protected_Boolean_IMouseEvent_0;

		// Token: 0x040010C7 RID: 4295
		private static readonly IntPtr NativeMethodInfoPtr_CanStopManipulation_Protected_Boolean_IMouseEvent_0;
	}
}
