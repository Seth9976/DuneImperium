using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.input
{
	// Token: 0x02000052 RID: 82
	public class MutablePress : Object
	{
		// Token: 0x060002BF RID: 703 RVA: 0x0000F8A4 File Offset: 0x0000DAA4
		// Note: this type is marked as 'beforefieldinit'.
		static MutablePress()
		{
			Il2CppClassPointerStore<MutablePress>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input", "MutablePress");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MutablePress>.NativeClassPtr);
			MutablePress.NativeFieldInfoPtr_updatePresses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MutablePress>.NativeClassPtr, "updatePresses");
			MutablePress.NativeFieldInfoPtr_down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MutablePress>.NativeClassPtr, "down");
			MutablePress.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MutablePress>.NativeClassPtr, "current");
			MutablePress.NativeFieldInfoPtr_up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MutablePress>.NativeClassPtr, "up");
			MutablePress.NativeMethodInfoPtr_get_Down_Public_get_InputSample_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutablePress>.NativeClassPtr, 100663632);
			MutablePress.NativeMethodInfoPtr_get_Current_Public_get_InputSample_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutablePress>.NativeClassPtr, 100663633);
			MutablePress.NativeMethodInfoPtr_set_Current_Public_set_Void_InputSample_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutablePress>.NativeClassPtr, 100663634);
			MutablePress.NativeMethodInfoPtr_get_Up_Public_get_Nullable_1_InputSample_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutablePress>.NativeClassPtr, 100663635);
			MutablePress.NativeMethodInfoPtr_set_Up_Public_set_Void_Nullable_1_InputSample_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutablePress>.NativeClassPtr, 100663636);
			MutablePress.NativeMethodInfoPtr__ctor_Protected_Void_Action_InputSample_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutablePress>.NativeClassPtr, 100663637);
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x0000F99C File Offset: 0x0000DB9C
		public unsafe InputSample Down
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutablePress.NativeMethodInfoPtr_get_Down_Public_get_InputSample_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new InputSample(intPtr);
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x0000F9D4 File Offset: 0x0000DBD4
		// (set) Token: 0x060002C2 RID: 706 RVA: 0x0000FA0C File Offset: 0x0000DC0C
		public unsafe InputSample Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1121077, RefRangeEnd = 1121084, XrefRangeStart = 1121074, XrefRangeEnd = 1121077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutablePress.NativeMethodInfoPtr_get_Current_Public_get_InputSample_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new InputSample(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1121092, RefRangeEnd = 1121094, XrefRangeStart = 1121084, XrefRangeEnd = 1121092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutablePress.NativeMethodInfoPtr_set_Current_Public_set_Void_InputSample_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x0000FA54 File Offset: 0x0000DC54
		// (set) Token: 0x060002C4 RID: 708 RVA: 0x0000FA8C File Offset: 0x0000DC8C
		public unsafe Nullable<InputSample> Up
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1121095, RefRangeEnd = 1121096, XrefRangeStart = 1121094, XrefRangeEnd = 1121095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutablePress.NativeMethodInfoPtr_get_Up_Public_get_Nullable_1_InputSample_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<InputSample>(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1121104, RefRangeEnd = 1121107, XrefRangeStart = 1121096, XrefRangeEnd = 1121104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutablePress.NativeMethodInfoPtr_set_Up_Public_set_Void_Nullable_1_InputSample_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0000FAD4 File Offset: 0x0000DCD4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1121112, RefRangeEnd = 1121116, XrefRangeStart = 1121107, XrefRangeEnd = 1121112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MutablePress(Action updatePressesCallback, InputSample down)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MutablePress>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(updatePressesCallback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(down));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutablePress.NativeMethodInfoPtr__ctor_Protected_Void_Action_InputSample_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0000393E File Offset: 0x00001B3E
		public MutablePress(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x0000FB38 File Offset: 0x0000DD38
		// (set) Token: 0x060002C8 RID: 712 RVA: 0x00003947 File Offset: 0x00001B47
		public unsafe Action updatePresses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutablePress.NativeFieldInfoPtr_updatePresses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutablePress.NativeFieldInfoPtr_updatePresses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x0000FB68 File Offset: 0x0000DD68
		// (set) Token: 0x060002CA RID: 714 RVA: 0x00003966 File Offset: 0x00001B66
		public InputSample down
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutablePress.NativeFieldInfoPtr_down);
				return new InputSample(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputSample>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutablePress.NativeFieldInfoPtr_down), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InputSample>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060002CB RID: 715 RVA: 0x0000FB98 File Offset: 0x0000DD98
		// (set) Token: 0x060002CC RID: 716 RVA: 0x00003994 File Offset: 0x00001B94
		public InputSample current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutablePress.NativeFieldInfoPtr_current);
				return new InputSample(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputSample>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutablePress.NativeFieldInfoPtr_current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InputSample>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060002CD RID: 717 RVA: 0x0000FBC8 File Offset: 0x0000DDC8
		// (set) Token: 0x060002CE RID: 718 RVA: 0x000039C2 File Offset: 0x00001BC2
		public Nullable<InputSample> up
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutablePress.NativeFieldInfoPtr_up);
				return new Nullable<InputSample>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<InputSample>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutablePress.NativeFieldInfoPtr_up), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<InputSample>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeFieldInfoPtr_updatePresses;

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeFieldInfoPtr_down;

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeFieldInfoPtr_current;

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeFieldInfoPtr_up;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeMethodInfoPtr_get_Down_Public_get_InputSample_0;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_get_InputSample_0;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeMethodInfoPtr_set_Current_Public_set_Void_InputSample_0;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeMethodInfoPtr_get_Up_Public_get_Nullable_1_InputSample_0;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeMethodInfoPtr_set_Up_Public_set_Void_Nullable_1_InputSample_0;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Action_InputSample_0;
	}
}
