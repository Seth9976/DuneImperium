using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020001BC RID: 444
	public class IStylePainter : Il2CppObjectBase
	{
		// Token: 0x060022D0 RID: 8912 RVA: 0x0009C430 File Offset: 0x0009A630
		// Note: this type is marked as 'beforefieldinit'.
		static IStylePainter()
		{
			Il2CppClassPointerStore<IStylePainter>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IStylePainter");
			IStylePainter.NativeMethodInfoPtr_DrawText_Public_Abstract_Virtual_New_Void_TextElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStylePainter>.NativeClassPtr, 100668452);
			IStylePainter.NativeMethodInfoPtr_DrawRectangle_Public_Abstract_Virtual_New_Void_RectangleParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStylePainter>.NativeClassPtr, 100668453);
			IStylePainter.NativeMethodInfoPtr_DrawImmediate_Public_Abstract_Virtual_New_Void_Action_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStylePainter>.NativeClassPtr, 100668454);
		}

		// Token: 0x060022D1 RID: 8913 RVA: 0x0009C494 File Offset: 0x0009A694
		[CallerCount(0)]
		public unsafe virtual void DrawText(TextElement te)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(te);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStylePainter.NativeMethodInfoPtr_DrawText_Public_Abstract_Virtual_New_Void_TextElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022D2 RID: 8914 RVA: 0x0009C4E4 File Offset: 0x0009A6E4
		[CallerCount(0)]
		public unsafe virtual void DrawRectangle(MeshGenerationContextUtils.RectangleParams rectParams)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rectParams));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStylePainter.NativeMethodInfoPtr_DrawRectangle_Public_Abstract_Virtual_New_Void_RectangleParams_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022D3 RID: 8915 RVA: 0x0009C538 File Offset: 0x0009A738
		[CallerCount(0)]
		public unsafe virtual void DrawImmediate(Action callback, bool cullingEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cullingEnabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStylePainter.NativeMethodInfoPtr_DrawImmediate_Public_Abstract_Virtual_New_Void_Action_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022D4 RID: 8916 RVA: 0x0000E4F6 File Offset: 0x0000C6F6
		public IStylePainter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040018EA RID: 6378
		private static readonly IntPtr NativeMethodInfoPtr_DrawText_Public_Abstract_Virtual_New_Void_TextElement_0;

		// Token: 0x040018EB RID: 6379
		private static readonly IntPtr NativeMethodInfoPtr_DrawRectangle_Public_Abstract_Virtual_New_Void_RectangleParams_0;

		// Token: 0x040018EC RID: 6380
		private static readonly IntPtr NativeMethodInfoPtr_DrawImmediate_Public_Abstract_Virtual_New_Void_Action_Boolean_0;
	}
}
