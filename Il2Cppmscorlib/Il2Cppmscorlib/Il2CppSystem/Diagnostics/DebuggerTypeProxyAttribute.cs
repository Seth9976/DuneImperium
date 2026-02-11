using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x020004A2 RID: 1186
	public sealed class DebuggerTypeProxyAttribute : Attribute
	{
		// Token: 0x06004986 RID: 18822 RVA: 0x00154D7C File Offset: 0x00152F7C
		// Note: this type is marked as 'beforefieldinit'.
		static DebuggerTypeProxyAttribute()
		{
			Il2CppClassPointerStore<DebuggerTypeProxyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics", "DebuggerTypeProxyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebuggerTypeProxyAttribute>.NativeClassPtr);
			DebuggerTypeProxyAttribute.NativeFieldInfoPtr_typeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebuggerTypeProxyAttribute>.NativeClassPtr, "typeName");
			DebuggerTypeProxyAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerTypeProxyAttribute>.NativeClassPtr, 100674007);
		}

		// Token: 0x06004987 RID: 18823 RVA: 0x00154DD4 File Offset: 0x00152FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414237, XrefRangeEnd = 1414250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebuggerTypeProxyAttribute(Type type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebuggerTypeProxyAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggerTypeProxyAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004988 RID: 18824 RVA: 0x0001AE68 File Offset: 0x00019068
		public DebuggerTypeProxyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170012CB RID: 4811
		// (get) Token: 0x06004989 RID: 18825 RVA: 0x00154E20 File Offset: 0x00153020
		// (set) Token: 0x0600498A RID: 18826 RVA: 0x0001AE71 File Offset: 0x00019071
		public unsafe string typeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggerTypeProxyAttribute.NativeFieldInfoPtr_typeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggerTypeProxyAttribute.NativeFieldInfoPtr_typeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003C4B RID: 15435
		private static readonly IntPtr NativeFieldInfoPtr_typeName;

		// Token: 0x04003C4C RID: 15436
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;
	}
}
