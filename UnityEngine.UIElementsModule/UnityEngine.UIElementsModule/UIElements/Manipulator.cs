using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200014A RID: 330
	public class Manipulator : Object
	{
		// Token: 0x06001859 RID: 6233 RVA: 0x000734B0 File Offset: 0x000716B0
		// Note: this type is marked as 'beforefieldinit'.
		static Manipulator()
		{
			Il2CppClassPointerStore<Manipulator>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "Manipulator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Manipulator>.NativeClassPtr);
			Manipulator.NativeFieldInfoPtr_m_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Manipulator>.NativeClassPtr, "m_Target");
			Manipulator.NativeMethodInfoPtr_RegisterCallbacksOnTarget_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manipulator>.NativeClassPtr, 100666909);
			Manipulator.NativeMethodInfoPtr_UnregisterCallbacksFromTarget_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manipulator>.NativeClassPtr, 100666910);
			Manipulator.NativeMethodInfoPtr_get_target_Public_Virtual_Final_New_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manipulator>.NativeClassPtr, 100666911);
			Manipulator.NativeMethodInfoPtr_set_target_Public_Virtual_Final_New_set_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manipulator>.NativeClassPtr, 100666912);
			Manipulator.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manipulator>.NativeClassPtr, 100666913);
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x00073558 File Offset: 0x00071758
		[CallerCount(0)]
		public unsafe virtual void RegisterCallbacksOnTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Manipulator.NativeMethodInfoPtr_RegisterCallbacksOnTarget_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x00073594 File Offset: 0x00071794
		[CallerCount(0)]
		public unsafe virtual void UnregisterCallbacksFromTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Manipulator.NativeMethodInfoPtr_UnregisterCallbacksFromTarget_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x0600185C RID: 6236 RVA: 0x000735D0 File Offset: 0x000717D0
		// (set) Token: 0x0600185D RID: 6237 RVA: 0x00073610 File Offset: 0x00071810
		public unsafe virtual VisualElement target
		{
			[CallerCount(169)]
			[CachedScanResults(RefRangeStart = 282426, RefRangeEnd = 282595, XrefRangeStart = 282426, XrefRangeEnd = 282595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manipulator.NativeMethodInfoPtr_get_target_Public_Virtual_Final_New_get_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320218, XrefRangeEnd = 320219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manipulator.NativeMethodInfoPtr_set_target_Public_Virtual_Final_New_set_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x00073654 File Offset: 0x00071854
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Manipulator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Manipulator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manipulator.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x0000B2C0 File Offset: 0x000094C0
		public Manipulator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06001860 RID: 6240 RVA: 0x00073690 File Offset: 0x00071890
		// (set) Token: 0x06001861 RID: 6241 RVA: 0x0000B2C9 File Offset: 0x000094C9
		public unsafe VisualElement m_Target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Manipulator.NativeFieldInfoPtr_m_Target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Manipulator.NativeFieldInfoPtr_m_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010B4 RID: 4276
		private static readonly IntPtr NativeFieldInfoPtr_m_Target;

		// Token: 0x040010B5 RID: 4277
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCallbacksOnTarget_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x040010B6 RID: 4278
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterCallbacksFromTarget_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x040010B7 RID: 4279
		private static readonly IntPtr NativeMethodInfoPtr_get_target_Public_Virtual_Final_New_get_VisualElement_0;

		// Token: 0x040010B8 RID: 4280
		private static readonly IntPtr NativeMethodInfoPtr_set_target_Public_Virtual_Final_New_set_Void_VisualElement_0;

		// Token: 0x040010B9 RID: 4281
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
