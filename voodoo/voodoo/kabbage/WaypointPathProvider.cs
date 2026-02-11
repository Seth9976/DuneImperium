using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine;

namespace voodoo.kabbage
{
	// Token: 0x0200002D RID: 45
	public class WaypointPathProvider : MonoBehaviour
	{
		// Token: 0x060001CC RID: 460 RVA: 0x0000EA30 File Offset: 0x0000CC30
		// Note: this type is marked as 'beforefieldinit'.
		static WaypointPathProvider()
		{
			Il2CppClassPointerStore<WaypointPathProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "voodoo.kabbage", "WaypointPathProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaypointPathProvider>.NativeClassPtr);
			WaypointPathProvider.NativeFieldInfoPtr_paths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaypointPathProvider>.NativeClassPtr, "paths");
			WaypointPathProvider.NativeMethodInfoPtr_GetPathForContext_Public_List_1_Transform_EntityView_EntityView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaypointPathProvider>.NativeClassPtr, 100663495);
			WaypointPathProvider.NativeMethodInfoPtr_Register_Public_Void_WaypointPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaypointPathProvider>.NativeClassPtr, 100663496);
			WaypointPathProvider.NativeMethodInfoPtr_Unregister_Public_Void_WaypointPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaypointPathProvider>.NativeClassPtr, 100663497);
			WaypointPathProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaypointPathProvider>.NativeClassPtr, 100663498);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0000EAC4 File Offset: 0x0000CCC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1107666, RefRangeEnd = 1107667, XrefRangeStart = 1107638, XrefRangeEnd = 1107666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Transform> GetPathForContext(EntityView start, EntityView end)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(start);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(end);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaypointPathProvider.NativeMethodInfoPtr_GetPathForContext_Public_List_1_Transform_EntityView_EntityView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr3) : null;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0000EB28 File Offset: 0x0000CD28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107667, XrefRangeEnd = 1107671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Register(WaypointPath path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaypointPathProvider.NativeMethodInfoPtr_Register_Public_Void_WaypointPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0000EB6C File Offset: 0x0000CD6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107671, XrefRangeEnd = 1107675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unregister(WaypointPath path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaypointPathProvider.NativeMethodInfoPtr_Unregister_Public_Void_WaypointPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0000EBB0 File Offset: 0x0000CDB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107675, XrefRangeEnd = 1107683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaypointPathProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaypointPathProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaypointPathProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00003002 File Offset: 0x00001202
		public WaypointPathProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x0000EBEC File Offset: 0x0000CDEC
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x0000300B File Offset: 0x0000120B
		public unsafe HashSet<WaypointPath> paths
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaypointPathProvider.NativeFieldInfoPtr_paths);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<WaypointPath>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaypointPathProvider.NativeFieldInfoPtr_paths), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeFieldInfoPtr_paths;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeMethodInfoPtr_GetPathForContext_Public_List_1_Transform_EntityView_EntityView_0;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeMethodInfoPtr_Register_Public_Void_WaypointPath_0;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeMethodInfoPtr_Unregister_Public_Void_WaypointPath_0;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
