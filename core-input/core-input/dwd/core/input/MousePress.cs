using System;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.input
{
	// Token: 0x0200004F RID: 79
	public sealed class MousePress : Press
	{
		// Token: 0x06000291 RID: 657 RVA: 0x0000EF0C File Offset: 0x0000D10C
		// Note: this type is marked as 'beforefieldinit'.
		static MousePress()
		{
			Il2CppClassPointerStore<MousePress>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input", "MousePress");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MousePress>.NativeClassPtr);
			MousePress.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MousePress>.NativeClassPtr, "source");
			MousePress.NativeMethodInfoPtr_get_Button_Public_get_MouseButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MousePress>.NativeClassPtr, 100663614);
			MousePress.NativeMethodInfoPtr__ctor_Internal_Void_MutableMousePress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MousePress>.NativeClassPtr, 100663615);
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000292 RID: 658 RVA: 0x0000EF78 File Offset: 0x0000D178
		public unsafe MouseButton Button
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1120848, RefRangeEnd = 1120851, XrefRangeStart = 1120848, XrefRangeEnd = 1120848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MousePress.NativeMethodInfoPtr_get_Button_Public_get_MouseButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0000EFB4 File Offset: 0x0000D1B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 765266, RefRangeEnd = 765267, XrefRangeStart = 765266, XrefRangeEnd = 765267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MousePress(MutableMousePress source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MousePress>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MousePress.NativeMethodInfoPtr__ctor_Internal_Void_MutableMousePress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00003789 File Offset: 0x00001989
		public MousePress(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000295 RID: 661 RVA: 0x0000F000 File Offset: 0x0000D200
		// (set) Token: 0x06000296 RID: 662 RVA: 0x00003792 File Offset: 0x00001992
		public new unsafe MutableMousePress source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MousePress.NativeFieldInfoPtr_source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MutableMousePress>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MousePress.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeMethodInfoPtr_get_Button_Public_get_MouseButton_0;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_MutableMousePress_0;
	}
}
