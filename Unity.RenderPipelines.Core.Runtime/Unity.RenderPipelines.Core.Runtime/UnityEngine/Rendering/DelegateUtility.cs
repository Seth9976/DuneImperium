using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x020000D5 RID: 213
	public static class DelegateUtility : Object
	{
		// Token: 0x06000FD3 RID: 4051 RVA: 0x000086D8 File Offset: 0x000068D8
		// Note: this type is marked as 'beforefieldinit'.
		static DelegateUtility()
		{
			Il2CppClassPointerStore<DelegateUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "DelegateUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelegateUtility>.NativeClassPtr);
			DelegateUtility.NativeMethodInfoPtr_Cast_Public_Static_Delegate_Delegate_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateUtility>.NativeClassPtr, 100665641);
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x0004996C File Offset: 0x00047B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977216, XrefRangeEnd = 977225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate Cast(Delegate source, Type type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateUtility.NativeMethodInfoPtr_Cast_Public_Static_Delegate_Delegate_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x00008711 File Offset: 0x00006911
		public DelegateUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C19 RID: 3097
		private static readonly IntPtr NativeMethodInfoPtr_Cast_Public_Static_Delegate_Delegate_Type_0;
	}
}
