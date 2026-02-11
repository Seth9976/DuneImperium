using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.input
{
	// Token: 0x02000053 RID: 83
	public sealed class MutableTouchPress : MutablePress
	{
		// Token: 0x060002CF RID: 719 RVA: 0x0000FBF8 File Offset: 0x0000DDF8
		// Note: this type is marked as 'beforefieldinit'.
		static MutableTouchPress()
		{
			Il2CppClassPointerStore<MutableTouchPress>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input", "MutableTouchPress");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MutableTouchPress>.NativeClassPtr);
			MutableTouchPress.NativeFieldInfoPtr_fingerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MutableTouchPress>.NativeClassPtr, "fingerID");
			MutableTouchPress.NativeFieldInfoPtr_asReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MutableTouchPress>.NativeClassPtr, "asReadOnly");
			MutableTouchPress.NativeMethodInfoPtr_get_FingerID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableTouchPress>.NativeClassPtr, 100663638);
			MutableTouchPress.NativeMethodInfoPtr__ctor_Public_Void_Action_InputSample_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableTouchPress>.NativeClassPtr, 100663639);
			MutableTouchPress.NativeMethodInfoPtr_get_AsReadOnly_Public_get_TouchPress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableTouchPress>.NativeClassPtr, 100663640);
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x0000FC8C File Offset: 0x0000DE8C
		public unsafe int FingerID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableTouchPress.NativeMethodInfoPtr_get_FingerID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0000FCC8 File Offset: 0x0000DEC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MutableTouchPress(Action updatePressesCallback, InputSample down, int fingerID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MutableTouchPress>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(updatePressesCallback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(down));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fingerID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableTouchPress.NativeMethodInfoPtr__ctor_Public_Void_Action_InputSample_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x0000FD38 File Offset: 0x0000DF38
		public unsafe TouchPress AsReadOnly
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1121123, RefRangeEnd = 1121126, XrefRangeStart = 1121116, XrefRangeEnd = 1121123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableTouchPress.NativeMethodInfoPtr_get_AsReadOnly_Public_get_TouchPress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TouchPress>(intPtr3) : null;
			}
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x000039F0 File Offset: 0x00001BF0
		public MutableTouchPress(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x0000FD78 File Offset: 0x0000DF78
		// (set) Token: 0x060002D5 RID: 725 RVA: 0x000039F9 File Offset: 0x00001BF9
		public unsafe int fingerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableTouchPress.NativeFieldInfoPtr_fingerID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableTouchPress.NativeFieldInfoPtr_fingerID)) = value;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x0000FDA0 File Offset: 0x0000DFA0
		// (set) Token: 0x060002D7 RID: 727 RVA: 0x00003A14 File Offset: 0x00001C14
		public unsafe TouchPress asReadOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableTouchPress.NativeFieldInfoPtr_asReadOnly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchPress>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableTouchPress.NativeFieldInfoPtr_asReadOnly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeFieldInfoPtr_fingerID;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeFieldInfoPtr_asReadOnly;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeMethodInfoPtr_get_FingerID_Public_get_Int32_0;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Action_InputSample_Int32_0;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeMethodInfoPtr_get_AsReadOnly_Public_get_TouchPress_0;
	}
}
