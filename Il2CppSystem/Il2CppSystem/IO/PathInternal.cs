using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.IO
{
	// Token: 0x02000176 RID: 374
	public static class PathInternal : Object
	{
		// Token: 0x060016F8 RID: 5880 RVA: 0x0007670C File Offset: 0x0007490C
		// Note: this type is marked as 'beforefieldinit'.
		static PathInternal()
		{
			Il2CppClassPointerStore<PathInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.IO", "PathInternal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathInternal>.NativeClassPtr);
			PathInternal.NativeFieldInfoPtr_s_isCaseSensitive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathInternal>.NativeClassPtr, "s_isCaseSensitive");
			PathInternal.NativeMethodInfoPtr_get_StringComparison_Internal_Static_get_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathInternal>.NativeClassPtr, 100666957);
			PathInternal.NativeMethodInfoPtr_GetIsCaseSensitive_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathInternal>.NativeClassPtr, 100666958);
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x060016F9 RID: 5881 RVA: 0x00076778 File Offset: 0x00074978
		public unsafe static StringComparison StringComparison
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 469300, XrefRangeEnd = 469304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathInternal.NativeMethodInfoPtr_get_StringComparison_Internal_Static_get_StringComparison_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060016FA RID: 5882 RVA: 0x000767A8 File Offset: 0x000749A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 469304, XrefRangeEnd = 469328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetIsCaseSensitive()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathInternal.NativeMethodInfoPtr_GetIsCaseSensitive_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060016FB RID: 5883 RVA: 0x00009E59 File Offset: 0x00008059
		public PathInternal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x060016FC RID: 5884 RVA: 0x000767D8 File Offset: 0x000749D8
		// (set) Token: 0x060016FD RID: 5885 RVA: 0x00009E62 File Offset: 0x00008062
		public unsafe static bool s_isCaseSensitive
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(PathInternal.NativeFieldInfoPtr_s_isCaseSensitive, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PathInternal.NativeFieldInfoPtr_s_isCaseSensitive, (void*)(&value));
			}
		}

		// Token: 0x040011F4 RID: 4596
		private static readonly IntPtr NativeFieldInfoPtr_s_isCaseSensitive;

		// Token: 0x040011F5 RID: 4597
		private static readonly IntPtr NativeMethodInfoPtr_get_StringComparison_Internal_Static_get_StringComparison_0;

		// Token: 0x040011F6 RID: 4598
		private static readonly IntPtr NativeMethodInfoPtr_GetIsCaseSensitive_Private_Static_Boolean_0;
	}
}
