using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000009 RID: 9
	public class Subsystem : Object
	{
		// Token: 0x0600002B RID: 43 RVA: 0x0000218D File Offset: 0x0000038D
		// Note: this type is marked as 'beforefieldinit'.
		static Subsystem()
		{
			Il2CppClassPointerStore<Subsystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SubsystemsModule.dll", "UnityEngine", "Subsystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Subsystem>.NativeClassPtr);
			Subsystem.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Subsystem>.NativeClassPtr, 100663308);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002C78 File Offset: 0x00000E78
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Subsystem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Subsystem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Subsystem.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000021C6 File Offset: 0x000003C6
		public Subsystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002CB4 File Offset: 0x00000EB4
		public void Destroy()
		{
			bool flag = SubsystemManager.RemoveDeprecatedSubsystem(this);
			if (flag)
			{
				this.OnDestroy();
			}
		}

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
