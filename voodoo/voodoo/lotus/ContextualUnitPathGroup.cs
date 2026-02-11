using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace lotus
{
	// Token: 0x02000046 RID: 70
	public class ContextualUnitPathGroup : UnitPathGroup
	{
		// Token: 0x06000465 RID: 1125 RVA: 0x000175EC File Offset: 0x000157EC
		// Note: this type is marked as 'beforefieldinit'.
		static ContextualUnitPathGroup()
		{
			Il2CppClassPointerStore<ContextualUnitPathGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "ContextualUnitPathGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContextualUnitPathGroup>.NativeClassPtr);
			ContextualUnitPathGroup.NativeFieldInfoPtr_overrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextualUnitPathGroup>.NativeClassPtr, "overrides");
			ContextualUnitPathGroup.NativeMethodInfoPtr_setPath_Protected_Virtual_Boolean_String_MoveContext_LocalDataManager_2_String_UnitPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextualUnitPathGroup>.NativeClassPtr, 100663814);
			ContextualUnitPathGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextualUnitPathGroup>.NativeClassPtr, 100663815);
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00017658 File Offset: 0x00015858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110278, XrefRangeEnd = 1110301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool setPath(string key, MoveContext context, LocalDataManager<string, UnitPath> paths)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paths);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContextualUnitPathGroup.NativeMethodInfoPtr_setPath_Protected_Virtual_Boolean_String_MoveContext_LocalDataManager_2_String_UnitPath_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x000176D4 File Offset: 0x000158D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110301, XrefRangeEnd = 1110312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContextualUnitPathGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextualUnitPathGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextualUnitPathGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x0000444A File Offset: 0x0000264A
		public ContextualUnitPathGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x00017710 File Offset: 0x00015910
		// (set) Token: 0x0600046A RID: 1130 RVA: 0x00004453 File Offset: 0x00002653
		public unsafe List<UnitPathGroupOverride> overrides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextualUnitPathGroup.NativeFieldInfoPtr_overrides);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UnitPathGroupOverride>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextualUnitPathGroup.NativeFieldInfoPtr_overrides), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeFieldInfoPtr_overrides;

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeMethodInfoPtr_setPath_Protected_Virtual_Boolean_String_MoveContext_LocalDataManager_2_String_UnitPath_0;

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
