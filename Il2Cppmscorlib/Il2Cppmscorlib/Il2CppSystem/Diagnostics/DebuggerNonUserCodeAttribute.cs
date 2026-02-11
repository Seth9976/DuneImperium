using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x0200049E RID: 1182
	[Serializable]
	public sealed class DebuggerNonUserCodeAttribute : Attribute
	{
		// Token: 0x06004979 RID: 18809 RVA: 0x0001ADDE File Offset: 0x00018FDE
		// Note: this type is marked as 'beforefieldinit'.
		static DebuggerNonUserCodeAttribute()
		{
			Il2CppClassPointerStore<DebuggerNonUserCodeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics", "DebuggerNonUserCodeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebuggerNonUserCodeAttribute>.NativeClassPtr);
			DebuggerNonUserCodeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerNonUserCodeAttribute>.NativeClassPtr, 100674004);
		}

		// Token: 0x0600497A RID: 18810 RVA: 0x00154BB0 File Offset: 0x00152DB0
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebuggerNonUserCodeAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebuggerNonUserCodeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggerNonUserCodeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600497B RID: 18811 RVA: 0x0001AE17 File Offset: 0x00019017
		public DebuggerNonUserCodeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003C42 RID: 15426
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
