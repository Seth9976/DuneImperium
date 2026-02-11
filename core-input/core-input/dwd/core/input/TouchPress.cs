using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.input
{
	// Token: 0x02000057 RID: 87
	public sealed class TouchPress : Press
	{
		// Token: 0x060002EC RID: 748 RVA: 0x0001014C File Offset: 0x0000E34C
		// Note: this type is marked as 'beforefieldinit'.
		static TouchPress()
		{
			Il2CppClassPointerStore<TouchPress>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input", "TouchPress");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchPress>.NativeClassPtr);
			TouchPress.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPress>.NativeClassPtr, "source");
			TouchPress.NativeMethodInfoPtr_get_FingerID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPress>.NativeClassPtr, 100663648);
			TouchPress.NativeMethodInfoPtr__ctor_Internal_Void_MutableTouchPress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPress>.NativeClassPtr, 100663649);
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060002ED RID: 749 RVA: 0x000101B8 File Offset: 0x0000E3B8
		public unsafe int FingerID
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1120848, RefRangeEnd = 1120851, XrefRangeStart = 1120848, XrefRangeEnd = 1120851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPress.NativeMethodInfoPtr_get_FingerID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002EE RID: 750 RVA: 0x000101F4 File Offset: 0x0000E3F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 765266, RefRangeEnd = 765267, XrefRangeStart = 765266, XrefRangeEnd = 765267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TouchPress(MutableTouchPress source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchPress>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPress.NativeMethodInfoPtr__ctor_Internal_Void_MutableTouchPress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00003AF2 File Offset: 0x00001CF2
		public TouchPress(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x00010240 File Offset: 0x0000E440
		// (set) Token: 0x060002F1 RID: 753 RVA: 0x00003AFB File Offset: 0x00001CFB
		public new unsafe MutableTouchPress source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPress.NativeFieldInfoPtr_source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MutableTouchPress>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPress.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeMethodInfoPtr_get_FingerID_Public_get_Int32_0;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_MutableTouchPress_0;
	}
}
