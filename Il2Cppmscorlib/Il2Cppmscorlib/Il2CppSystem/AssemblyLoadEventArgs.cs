using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem
{
	// Token: 0x02000077 RID: 119
	public class AssemblyLoadEventArgs : EventArgs
	{
		// Token: 0x0600069B RID: 1691 RVA: 0x000439D4 File Offset: 0x00041BD4
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyLoadEventArgs()
		{
			Il2CppClassPointerStore<AssemblyLoadEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "AssemblyLoadEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyLoadEventArgs>.NativeClassPtr);
			AssemblyLoadEventArgs.NativeFieldInfoPtr__LoadedAssembly_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyLoadEventArgs>.NativeClassPtr, "<LoadedAssembly>k__BackingField");
			AssemblyLoadEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyLoadEventArgs>.NativeClassPtr, 100664398);
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x00043A2C File Offset: 0x00041C2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1298909, RefRangeEnd = 1298910, XrefRangeStart = 1298897, XrefRangeEnd = 1298909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyLoadEventArgs(Assembly loadedAssembly)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyLoadEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(loadedAssembly);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyLoadEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x0000401B File Offset: 0x0000221B
		public AssemblyLoadEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600069E RID: 1694 RVA: 0x00043A78 File Offset: 0x00041C78
		// (set) Token: 0x0600069F RID: 1695 RVA: 0x00004024 File Offset: 0x00002224
		public unsafe Assembly _LoadedAssembly_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyLoadEventArgs.NativeFieldInfoPtr__LoadedAssembly_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyLoadEventArgs.NativeFieldInfoPtr__LoadedAssembly_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004D2 RID: 1234
		private static readonly IntPtr NativeFieldInfoPtr__LoadedAssembly_k__BackingField;

		// Token: 0x040004D3 RID: 1235
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Assembly_0;
	}
}
