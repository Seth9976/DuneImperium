using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000126 RID: 294
	public class RefreshEventArgs : EventArgs
	{
		// Token: 0x06001225 RID: 4645 RVA: 0x00061BE4 File Offset: 0x0005FDE4
		// Note: this type is marked as 'beforefieldinit'.
		static RefreshEventArgs()
		{
			Il2CppClassPointerStore<RefreshEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "RefreshEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RefreshEventArgs>.NativeClassPtr);
			RefreshEventArgs.NativeFieldInfoPtr__TypeChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefreshEventArgs>.NativeClassPtr, "<TypeChanged>k__BackingField");
			RefreshEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefreshEventArgs>.NativeClassPtr, 100665944);
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x00061C3C File Offset: 0x0005FE3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 460374, RefRangeEnd = 460376, XrefRangeStart = 460369, XrefRangeEnd = 460374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RefreshEventArgs(Type typeChanged)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RefreshEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeChanged);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RefreshEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001227 RID: 4647 RVA: 0x00008656 File Offset: 0x00006856
		public RefreshEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06001228 RID: 4648 RVA: 0x00061C88 File Offset: 0x0005FE88
		// (set) Token: 0x06001229 RID: 4649 RVA: 0x0000865F File Offset: 0x0000685F
		public unsafe Type _TypeChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RefreshEventArgs.NativeFieldInfoPtr__TypeChanged_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RefreshEventArgs.NativeFieldInfoPtr__TypeChanged_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E7D RID: 3709
		private static readonly IntPtr NativeFieldInfoPtr__TypeChanged_k__BackingField;

		// Token: 0x04000E7E RID: 3710
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;
	}
}
