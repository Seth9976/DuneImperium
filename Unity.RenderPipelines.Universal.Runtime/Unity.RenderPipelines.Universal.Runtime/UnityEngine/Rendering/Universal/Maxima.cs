using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200001D RID: 29
	public class Maxima : Object
	{
		// Token: 0x06000122 RID: 290 RVA: 0x00019018 File Offset: 0x00017218
		// Note: this type is marked as 'beforefieldinit'.
		static Maxima()
		{
			Il2CppClassPointerStore<Maxima>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "Maxima");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Maxima>.NativeClassPtr);
			Maxima.NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Maxima>.NativeClassPtr, "X");
			Maxima.NativeFieldInfoPtr_Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Maxima>.NativeClassPtr, "Next");
			Maxima.NativeFieldInfoPtr_Prev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Maxima>.NativeClassPtr, "Prev");
			Maxima.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Maxima>.NativeClassPtr, 100663433);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00019098 File Offset: 0x00017298
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Maxima()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Maxima>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Maxima.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000028FB File Offset: 0x00000AFB
		public Maxima(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000125 RID: 293 RVA: 0x000190D4 File Offset: 0x000172D4
		// (set) Token: 0x06000126 RID: 294 RVA: 0x00002904 File Offset: 0x00000B04
		public unsafe long X
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Maxima.NativeFieldInfoPtr_X);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Maxima.NativeFieldInfoPtr_X)) = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000127 RID: 295 RVA: 0x000190FC File Offset: 0x000172FC
		// (set) Token: 0x06000128 RID: 296 RVA: 0x0000291F File Offset: 0x00000B1F
		public unsafe Maxima Next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Maxima.NativeFieldInfoPtr_Next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Maxima>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Maxima.NativeFieldInfoPtr_Next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000129 RID: 297 RVA: 0x0001912C File Offset: 0x0001732C
		// (set) Token: 0x0600012A RID: 298 RVA: 0x0000293E File Offset: 0x00000B3E
		public unsafe Maxima Prev
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Maxima.NativeFieldInfoPtr_Prev);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Maxima>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Maxima.NativeFieldInfoPtr_Prev), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeFieldInfoPtr_X;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeFieldInfoPtr_Next;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeFieldInfoPtr_Prev;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
