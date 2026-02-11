using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace lotus
{
	// Token: 0x020000CF RID: 207
	public class RemoveOnPlatform : MonoBehaviour
	{
		// Token: 0x06000A03 RID: 2563 RVA: 0x00031074 File Offset: 0x0002F274
		// Note: this type is marked as 'beforefieldinit'.
		static RemoveOnPlatform()
		{
			Il2CppClassPointerStore<RemoveOnPlatform>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus", "RemoveOnPlatform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoveOnPlatform>.NativeClassPtr);
			RemoveOnPlatform.NativeFieldInfoPtr_platforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveOnPlatform>.NativeClassPtr, "platforms");
			RemoveOnPlatform.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveOnPlatform>.NativeClassPtr, 100664923);
			RemoveOnPlatform.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveOnPlatform>.NativeClassPtr, 100664924);
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x000310E0 File Offset: 0x0002F2E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993468, XrefRangeEnd = 993478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoveOnPlatform.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x00031114 File Offset: 0x0002F314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993478, XrefRangeEnd = 993486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RemoveOnPlatform()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoveOnPlatform>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoveOnPlatform.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x000068A1 File Offset: 0x00004AA1
		public RemoveOnPlatform(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000A07 RID: 2567 RVA: 0x00031150 File Offset: 0x0002F350
		// (set) Token: 0x06000A08 RID: 2568 RVA: 0x000068AA File Offset: 0x00004AAA
		public unsafe Il2CppStructArray<RuntimePlatform> platforms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoveOnPlatform.NativeFieldInfoPtr_platforms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RuntimePlatform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoveOnPlatform.NativeFieldInfoPtr_platforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000628 RID: 1576
		private static readonly IntPtr NativeFieldInfoPtr_platforms;

		// Token: 0x04000629 RID: 1577
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400062A RID: 1578
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
