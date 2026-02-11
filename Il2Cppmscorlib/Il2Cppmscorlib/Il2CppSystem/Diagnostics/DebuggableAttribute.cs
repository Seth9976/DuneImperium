using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x0200049F RID: 1183
	public sealed class DebuggableAttribute : Attribute
	{
		// Token: 0x0600497C RID: 18812 RVA: 0x00154BEC File Offset: 0x00152DEC
		// Note: this type is marked as 'beforefieldinit'.
		static DebuggableAttribute()
		{
			Il2CppClassPointerStore<DebuggableAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics", "DebuggableAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebuggableAttribute>.NativeClassPtr);
			DebuggableAttribute.NativeFieldInfoPtr_m_debuggingModes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebuggableAttribute>.NativeClassPtr, "m_debuggingModes");
			DebuggableAttribute.NativeMethodInfoPtr__ctor_Public_Void_DebuggingModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggableAttribute>.NativeClassPtr, 100674005);
		}

		// Token: 0x0600497D RID: 18813 RVA: 0x00154C44 File Offset: 0x00152E44
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 346333, RefRangeEnd = 346361, XrefRangeStart = 346333, XrefRangeEnd = 346361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebuggableAttribute(DebuggableAttribute.DebuggingModes modes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebuggableAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref modes;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggableAttribute.NativeMethodInfoPtr__ctor_Public_Void_DebuggingModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600497E RID: 18814 RVA: 0x0001AE20 File Offset: 0x00019020
		public DebuggableAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170012C9 RID: 4809
		// (get) Token: 0x0600497F RID: 18815 RVA: 0x00154C8C File Offset: 0x00152E8C
		// (set) Token: 0x06004980 RID: 18816 RVA: 0x0001AE29 File Offset: 0x00019029
		public unsafe DebuggableAttribute.DebuggingModes m_debuggingModes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggableAttribute.NativeFieldInfoPtr_m_debuggingModes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggableAttribute.NativeFieldInfoPtr_m_debuggingModes)) = value;
			}
		}

		// Token: 0x04003C43 RID: 15427
		private static readonly IntPtr NativeFieldInfoPtr_m_debuggingModes;

		// Token: 0x04003C44 RID: 15428
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DebuggingModes_0;

		// Token: 0x020006DC RID: 1756
		[Flags]
		public enum DebuggingModes
		{
			// Token: 0x04004C23 RID: 19491
			None = 0,
			// Token: 0x04004C24 RID: 19492
			Default = 1,
			// Token: 0x04004C25 RID: 19493
			DisableOptimizations = 256,
			// Token: 0x04004C26 RID: 19494
			IgnoreSymbolStoreSequencePoints = 2,
			// Token: 0x04004C27 RID: 19495
			EnableEditAndContinue = 4
		}
	}
}
