using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Networking.eventtriggers.clientactions;

namespace lotus
{
	// Token: 0x020000C4 RID: 196
	public class SetPrompt : ClientAction
	{
		// Token: 0x060009C0 RID: 2496 RVA: 0x00030410 File Offset: 0x0002E610
		// Note: this type is marked as 'beforefieldinit'.
		static SetPrompt()
		{
			Il2CppClassPointerStore<SetPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus", "SetPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetPrompt>.NativeClassPtr);
			SetPrompt.NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPrompt>.NativeClassPtr, "Enabled");
			SetPrompt.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPrompt>.NativeClassPtr, 100664890);
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x00030468 File Offset: 0x0002E668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993240, XrefRangeEnd = 993241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetPrompt(bool enabled)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetPrompt>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetPrompt.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x000066C1 File Offset: 0x000048C1
		public SetPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x060009C3 RID: 2499 RVA: 0x000304B0 File Offset: 0x0002E6B0
		// (set) Token: 0x060009C4 RID: 2500 RVA: 0x000066CA File Offset: 0x000048CA
		public unsafe bool Enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetPrompt.NativeFieldInfoPtr_Enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetPrompt.NativeFieldInfoPtr_Enabled)) = value;
			}
		}

		// Token: 0x04000604 RID: 1540
		private static readonly IntPtr NativeFieldInfoPtr_Enabled;

		// Token: 0x04000605 RID: 1541
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;
	}
}
