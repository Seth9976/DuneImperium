using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.UI
{
	// Token: 0x0200011F RID: 287
	[Serializable]
	public class DebugUIPrefabBundle : Object
	{
		// Token: 0x06001296 RID: 4758 RVA: 0x00054170 File Offset: 0x00052370
		// Note: this type is marked as 'beforefieldinit'.
		static DebugUIPrefabBundle()
		{
			Il2CppClassPointerStore<DebugUIPrefabBundle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.UI", "DebugUIPrefabBundle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUIPrefabBundle>.NativeClassPtr);
			DebugUIPrefabBundle.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIPrefabBundle>.NativeClassPtr, "type");
			DebugUIPrefabBundle.NativeFieldInfoPtr_prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIPrefabBundle>.NativeClassPtr, "prefab");
			DebugUIPrefabBundle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIPrefabBundle>.NativeClassPtr, 100666011);
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x000541DC File Offset: 0x000523DC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugUIPrefabBundle()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUIPrefabBundle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIPrefabBundle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x00009821 File Offset: 0x00007A21
		public DebugUIPrefabBundle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06001299 RID: 4761 RVA: 0x00054218 File Offset: 0x00052418
		// (set) Token: 0x0600129A RID: 4762 RVA: 0x0000982A File Offset: 0x00007A2A
		public unsafe string type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIPrefabBundle.NativeFieldInfoPtr_type);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIPrefabBundle.NativeFieldInfoPtr_type), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x0600129B RID: 4763 RVA: 0x00054240 File Offset: 0x00052440
		// (set) Token: 0x0600129C RID: 4764 RVA: 0x00009849 File Offset: 0x00007A49
		public unsafe RectTransform prefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIPrefabBundle.NativeFieldInfoPtr_prefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIPrefabBundle.NativeFieldInfoPtr_prefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DDE RID: 3550
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04000DDF RID: 3551
		private static readonly IntPtr NativeFieldInfoPtr_prefab;

		// Token: 0x04000DE0 RID: 3552
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
