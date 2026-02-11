using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200012B RID: 299
	public class BaseFieldMouseDragger : Object
	{
		// Token: 0x06001625 RID: 5669 RVA: 0x0006B458 File Offset: 0x00069658
		// Note: this type is marked as 'beforefieldinit'.
		static BaseFieldMouseDragger()
		{
			Il2CppClassPointerStore<BaseFieldMouseDragger>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "BaseFieldMouseDragger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseFieldMouseDragger>.NativeClassPtr);
			BaseFieldMouseDragger.NativeMethodInfoPtr_SetDragZone_Public_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseFieldMouseDragger>.NativeClassPtr, 100666609);
			BaseFieldMouseDragger.NativeMethodInfoPtr_SetDragZone_Public_Abstract_Virtual_New_Void_VisualElement_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseFieldMouseDragger>.NativeClassPtr, 100666610);
			BaseFieldMouseDragger.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseFieldMouseDragger>.NativeClassPtr, 100666611);
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x0006B4C4 File Offset: 0x000696C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 317368, RefRangeEnd = 317371, XrefRangeStart = 317368, XrefRangeEnd = 317368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDragZone(VisualElement dragElement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dragElement);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseFieldMouseDragger.NativeMethodInfoPtr_SetDragZone_Public_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x0006B508 File Offset: 0x00069708
		[CallerCount(0)]
		public unsafe virtual void SetDragZone(VisualElement dragElement, Rect hotZone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dragElement);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hotZone;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseFieldMouseDragger.NativeMethodInfoPtr_SetDragZone_Public_Abstract_Virtual_New_Void_VisualElement_Rect_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x0006B564 File Offset: 0x00069764
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseFieldMouseDragger()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseFieldMouseDragger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseFieldMouseDragger.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x0000A518 File Offset: 0x00008718
		public BaseFieldMouseDragger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F13 RID: 3859
		private static readonly IntPtr NativeMethodInfoPtr_SetDragZone_Public_Void_VisualElement_0;

		// Token: 0x04000F14 RID: 3860
		private static readonly IntPtr NativeMethodInfoPtr_SetDragZone_Public_Abstract_Virtual_New_Void_VisualElement_Rect_0;

		// Token: 0x04000F15 RID: 3861
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
