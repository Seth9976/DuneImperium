using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x020004A1 RID: 1185
	public sealed class DebuggerBrowsableAttribute : Attribute
	{
		// Token: 0x06004981 RID: 18817 RVA: 0x00154CB4 File Offset: 0x00152EB4
		// Note: this type is marked as 'beforefieldinit'.
		static DebuggerBrowsableAttribute()
		{
			Il2CppClassPointerStore<DebuggerBrowsableAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics", "DebuggerBrowsableAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebuggerBrowsableAttribute>.NativeClassPtr);
			DebuggerBrowsableAttribute.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebuggerBrowsableAttribute>.NativeClassPtr, "state");
			DebuggerBrowsableAttribute.NativeMethodInfoPtr__ctor_Public_Void_DebuggerBrowsableState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerBrowsableAttribute>.NativeClassPtr, 100674006);
		}

		// Token: 0x06004982 RID: 18818 RVA: 0x00154D0C File Offset: 0x00152F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414236, XrefRangeEnd = 1414237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebuggerBrowsableAttribute(DebuggerBrowsableState state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebuggerBrowsableAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggerBrowsableAttribute.NativeMethodInfoPtr__ctor_Public_Void_DebuggerBrowsableState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004983 RID: 18819 RVA: 0x0001AE44 File Offset: 0x00019044
		public DebuggerBrowsableAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170012CA RID: 4810
		// (get) Token: 0x06004984 RID: 18820 RVA: 0x00154D54 File Offset: 0x00152F54
		// (set) Token: 0x06004985 RID: 18821 RVA: 0x0001AE4D File Offset: 0x0001904D
		public unsafe DebuggerBrowsableState state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggerBrowsableAttribute.NativeFieldInfoPtr_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggerBrowsableAttribute.NativeFieldInfoPtr_state)) = value;
			}
		}

		// Token: 0x04003C49 RID: 15433
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04003C4A RID: 15434
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DebuggerBrowsableState_0;
	}
}
