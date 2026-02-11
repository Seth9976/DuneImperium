using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000B7 RID: 183
	public class DropdownMenuItem : Object
	{
		// Token: 0x0600111B RID: 4379 RVA: 0x00008935 File Offset: 0x00006B35
		// Note: this type is marked as 'beforefieldinit'.
		static DropdownMenuItem()
		{
			Il2CppClassPointerStore<DropdownMenuItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "DropdownMenuItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropdownMenuItem>.NativeClassPtr);
			DropdownMenuItem.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropdownMenuItem>.NativeClassPtr, 100665728);
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x00059104 File Offset: 0x00057304
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DropdownMenuItem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DropdownMenuItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DropdownMenuItem.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x0000896E File Offset: 0x00006B6E
		public DropdownMenuItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BCC RID: 3020
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
