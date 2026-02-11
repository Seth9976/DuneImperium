using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	public static class SpriteMaskUtility : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002188 File Offset: 0x00000388
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteMaskUtility()
		{
			Il2CppClassPointerStore<SpriteMaskUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SpriteMaskModule.dll", "UnityEngine", "SpriteMaskUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteMaskUtility>.NativeClassPtr);
			SpriteMaskUtility.NativeMethodInfoPtr_HasSpriteMaskInLayerRange_Public_Static_Boolean_SortingLayerRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteMaskUtility>.NativeClassPtr, 100663297);
			SpriteMaskUtility.NativeMethodInfoPtr_HasSpriteMaskInLayerRange_Injected_Private_Static_Boolean_byref_SortingLayerRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteMaskUtility>.NativeClassPtr, 100663298);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000021E0 File Offset: 0x000003E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1273099, RefRangeEnd = 1273100, XrefRangeStart = 1273097, XrefRangeEnd = 1273099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasSpriteMaskInLayerRange(SortingLayerRange range)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref range;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteMaskUtility.NativeMethodInfoPtr_HasSpriteMaskInLayerRange_Public_Static_Boolean_SortingLayerRange_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002220 File Offset: 0x00000420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273100, XrefRangeEnd = 1273102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasSpriteMaskInLayerRange_Injected(ref SortingLayerRange range)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &range;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteMaskUtility.NativeMethodInfoPtr_HasSpriteMaskInLayerRange_Injected_Private_Static_Boolean_byref_SortingLayerRange_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
		public SpriteMaskUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeMethodInfoPtr_HasSpriteMaskInLayerRange_Public_Static_Boolean_SortingLayerRange_0;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr_HasSpriteMaskInLayerRange_Injected_Private_Static_Boolean_byref_SortingLayerRange_0;
	}
}
