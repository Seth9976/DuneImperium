using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine.EventSystems;

namespace dwd.core.input.context
{
	// Token: 0x0200007F RID: 127
	public sealed class TerminateHeirarchicalContextTree : UIBehaviour
	{
		// Token: 0x06000557 RID: 1367 RVA: 0x00017C78 File Offset: 0x00015E78
		// Note: this type is marked as 'beforefieldinit'.
		static TerminateHeirarchicalContextTree()
		{
			Il2CppClassPointerStore<TerminateHeirarchicalContextTree>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.context", "TerminateHeirarchicalContextTree");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerminateHeirarchicalContextTree>.NativeClassPtr);
			TerminateHeirarchicalContextTree.NativeFieldInfoPtr_ignoreForContextIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerminateHeirarchicalContextTree>.NativeClassPtr, "ignoreForContextIds");
			TerminateHeirarchicalContextTree.NativeMethodInfoPtr_get_IgnoreForContextIds_Public_get_IReadOnlyList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerminateHeirarchicalContextTree>.NativeClassPtr, 100663958);
			TerminateHeirarchicalContextTree.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerminateHeirarchicalContextTree>.NativeClassPtr, 100663959);
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000558 RID: 1368 RVA: 0x00017CE4 File Offset: 0x00015EE4
		public unsafe IReadOnlyList<string> IgnoreForContextIds
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerminateHeirarchicalContextTree.NativeMethodInfoPtr_get_IgnoreForContextIds_Public_get_IReadOnlyList_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<string>>(intPtr3) : null;
			}
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00017D24 File Offset: 0x00015F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124256, XrefRangeEnd = 1124261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TerminateHeirarchicalContextTree()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TerminateHeirarchicalContextTree>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerminateHeirarchicalContextTree.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00004F2F File Offset: 0x0000312F
		public TerminateHeirarchicalContextTree(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x0600055B RID: 1371 RVA: 0x00017D60 File Offset: 0x00015F60
		// (set) Token: 0x0600055C RID: 1372 RVA: 0x00004F38 File Offset: 0x00003138
		public unsafe Il2CppStringArray ignoreForContextIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerminateHeirarchicalContextTree.NativeFieldInfoPtr_ignoreForContextIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerminateHeirarchicalContextTree.NativeFieldInfoPtr_ignoreForContextIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000339 RID: 825
		private static readonly IntPtr NativeFieldInfoPtr_ignoreForContextIds;

		// Token: 0x0400033A RID: 826
		private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreForContextIds_Public_get_IReadOnlyList_1_String_0;

		// Token: 0x0400033B RID: 827
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
