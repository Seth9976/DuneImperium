using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.input
{
	// Token: 0x02000055 RID: 85
	public sealed class PressAction : ValueType
	{
		// Token: 0x060002E1 RID: 737 RVA: 0x0000FFEC File Offset: 0x0000E1EC
		// Note: this type is marked as 'beforefieldinit'.
		static PressAction()
		{
			Il2CppClassPointerStore<PressAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input", "PressAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PressAction>.NativeClassPtr);
			PressAction.NativeFieldInfoPtr_Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PressAction>.NativeClassPtr, "Down");
			PressAction.NativeFieldInfoPtr_Press = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PressAction>.NativeClassPtr, "Press");
			PressAction.NativeMethodInfoPtr__ctor_Public_Void_Press_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressAction>.NativeClassPtr, 100663646);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00010058 File Offset: 0x0000E258
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 441991, RefRangeEnd = 441993, XrefRangeStart = 441991, XrefRangeEnd = 441993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PressAction(Press press, bool down)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PressAction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(press);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref down;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PressAction.NativeMethodInfoPtr__ctor_Public_Void_Press_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00003A5B File Offset: 0x00001C5B
		public PressAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00003A64 File Offset: 0x00001C64
		public PressAction()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PressAction>.NativeClassPtr))
		{
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x000100B8 File Offset: 0x0000E2B8
		// (set) Token: 0x060002E6 RID: 742 RVA: 0x00003A76 File Offset: 0x00001C76
		public unsafe bool Down
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressAction.NativeFieldInfoPtr_Down);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressAction.NativeFieldInfoPtr_Down)) = value;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x000100E0 File Offset: 0x0000E2E0
		// (set) Token: 0x060002E8 RID: 744 RVA: 0x00003A91 File Offset: 0x00001C91
		public unsafe Press Press
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressAction.NativeFieldInfoPtr_Press);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Press>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressAction.NativeFieldInfoPtr_Press), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeFieldInfoPtr_Down;

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeFieldInfoPtr_Press;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Press_Boolean_0;
	}
}
