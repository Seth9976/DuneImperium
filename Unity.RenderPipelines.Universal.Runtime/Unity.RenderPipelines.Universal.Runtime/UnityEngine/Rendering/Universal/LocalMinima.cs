using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200001B RID: 27
	public class LocalMinima : Object
	{
		// Token: 0x06000110 RID: 272 RVA: 0x00018D90 File Offset: 0x00016F90
		// Note: this type is marked as 'beforefieldinit'.
		static LocalMinima()
		{
			Il2CppClassPointerStore<LocalMinima>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "LocalMinima");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalMinima>.NativeClassPtr);
			LocalMinima.NativeFieldInfoPtr_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalMinima>.NativeClassPtr, "Y");
			LocalMinima.NativeFieldInfoPtr_LeftBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalMinima>.NativeClassPtr, "LeftBound");
			LocalMinima.NativeFieldInfoPtr_RightBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalMinima>.NativeClassPtr, "RightBound");
			LocalMinima.NativeFieldInfoPtr_Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalMinima>.NativeClassPtr, "Next");
			LocalMinima.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalMinima>.NativeClassPtr, 100663431);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00018E24 File Offset: 0x00017024
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalMinima()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalMinima>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalMinima.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00002837 File Offset: 0x00000A37
		public LocalMinima(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00018E60 File Offset: 0x00017060
		// (set) Token: 0x06000114 RID: 276 RVA: 0x00002840 File Offset: 0x00000A40
		public unsafe long Y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalMinima.NativeFieldInfoPtr_Y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalMinima.NativeFieldInfoPtr_Y)) = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000115 RID: 277 RVA: 0x00018E88 File Offset: 0x00017088
		// (set) Token: 0x06000116 RID: 278 RVA: 0x0000285B File Offset: 0x00000A5B
		public unsafe TEdge LeftBound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalMinima.NativeFieldInfoPtr_LeftBound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TEdge>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalMinima.NativeFieldInfoPtr_LeftBound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000117 RID: 279 RVA: 0x00018EB8 File Offset: 0x000170B8
		// (set) Token: 0x06000118 RID: 280 RVA: 0x0000287A File Offset: 0x00000A7A
		public unsafe TEdge RightBound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalMinima.NativeFieldInfoPtr_RightBound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TEdge>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalMinima.NativeFieldInfoPtr_RightBound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000119 RID: 281 RVA: 0x00018EE8 File Offset: 0x000170E8
		// (set) Token: 0x0600011A RID: 282 RVA: 0x00002899 File Offset: 0x00000A99
		public unsafe LocalMinima Next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalMinima.NativeFieldInfoPtr_Next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalMinima>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalMinima.NativeFieldInfoPtr_Next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeFieldInfoPtr_Y;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeFieldInfoPtr_LeftBound;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeFieldInfoPtr_RightBound;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeFieldInfoPtr_Next;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
