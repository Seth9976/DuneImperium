using System;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.input
{
	// Token: 0x02000051 RID: 81
	public sealed class MutableMousePress : MutablePress
	{
		// Token: 0x060002B6 RID: 694 RVA: 0x0000F6CC File Offset: 0x0000D8CC
		// Note: this type is marked as 'beforefieldinit'.
		static MutableMousePress()
		{
			Il2CppClassPointerStore<MutableMousePress>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input", "MutableMousePress");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MutableMousePress>.NativeClassPtr);
			MutableMousePress.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MutableMousePress>.NativeClassPtr, "button");
			MutableMousePress.NativeFieldInfoPtr_asReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MutableMousePress>.NativeClassPtr, "asReadOnly");
			MutableMousePress.NativeMethodInfoPtr_get_Button_Public_get_MouseButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableMousePress>.NativeClassPtr, 100663629);
			MutableMousePress.NativeMethodInfoPtr__ctor_Public_Void_Action_InputSample_MouseButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableMousePress>.NativeClassPtr, 100663630);
			MutableMousePress.NativeMethodInfoPtr_get_AsReadOnly_Public_get_MousePress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableMousePress>.NativeClassPtr, 100663631);
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x0000F760 File Offset: 0x0000D960
		public unsafe MouseButton Button
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableMousePress.NativeMethodInfoPtr_get_Button_Public_get_MouseButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0000F79C File Offset: 0x0000D99C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121063, XrefRangeEnd = 1121064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MutableMousePress(Action updatePressesCallback, InputSample down, MouseButton button)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MutableMousePress>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(updatePressesCallback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(down));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref button;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableMousePress.NativeMethodInfoPtr__ctor_Public_Void_Action_InputSample_MouseButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x0000F80C File Offset: 0x0000DA0C
		public unsafe MousePress AsReadOnly
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1121071, RefRangeEnd = 1121074, XrefRangeStart = 1121064, XrefRangeEnd = 1121071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableMousePress.NativeMethodInfoPtr_get_AsReadOnly_Public_get_MousePress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MousePress>(intPtr3) : null;
			}
		}

		// Token: 0x060002BA RID: 698 RVA: 0x000038FB File Offset: 0x00001AFB
		public MutableMousePress(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060002BB RID: 699 RVA: 0x0000F84C File Offset: 0x0000DA4C
		// (set) Token: 0x060002BC RID: 700 RVA: 0x00003904 File Offset: 0x00001B04
		public unsafe MouseButton button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableMousePress.NativeFieldInfoPtr_button);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableMousePress.NativeFieldInfoPtr_button)) = value;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060002BD RID: 701 RVA: 0x0000F874 File Offset: 0x0000DA74
		// (set) Token: 0x060002BE RID: 702 RVA: 0x0000391F File Offset: 0x00001B1F
		public unsafe MousePress asReadOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableMousePress.NativeFieldInfoPtr_asReadOnly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MousePress>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableMousePress.NativeFieldInfoPtr_asReadOnly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeFieldInfoPtr_button;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeFieldInfoPtr_asReadOnly;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeMethodInfoPtr_get_Button_Public_get_MouseButton_0;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Action_InputSample_MouseButton_0;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeMethodInfoPtr_get_AsReadOnly_Public_get_MousePress_0;
	}
}
