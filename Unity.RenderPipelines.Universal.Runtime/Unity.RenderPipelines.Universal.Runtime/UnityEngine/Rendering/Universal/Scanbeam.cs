using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200001C RID: 28
	public class Scanbeam : Object
	{
		// Token: 0x0600011B RID: 283 RVA: 0x00018F18 File Offset: 0x00017118
		// Note: this type is marked as 'beforefieldinit'.
		static Scanbeam()
		{
			Il2CppClassPointerStore<Scanbeam>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "Scanbeam");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Scanbeam>.NativeClassPtr);
			Scanbeam.NativeFieldInfoPtr_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scanbeam>.NativeClassPtr, "Y");
			Scanbeam.NativeFieldInfoPtr_Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scanbeam>.NativeClassPtr, "Next");
			Scanbeam.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scanbeam>.NativeClassPtr, 100663432);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00018F84 File Offset: 0x00017184
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Scanbeam()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Scanbeam>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scanbeam.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000028B8 File Offset: 0x00000AB8
		public Scanbeam(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00018FC0 File Offset: 0x000171C0
		// (set) Token: 0x0600011F RID: 287 RVA: 0x000028C1 File Offset: 0x00000AC1
		public unsafe long Y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scanbeam.NativeFieldInfoPtr_Y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scanbeam.NativeFieldInfoPtr_Y)) = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000120 RID: 288 RVA: 0x00018FE8 File Offset: 0x000171E8
		// (set) Token: 0x06000121 RID: 289 RVA: 0x000028DC File Offset: 0x00000ADC
		public unsafe Scanbeam Next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scanbeam.NativeFieldInfoPtr_Next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scanbeam>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scanbeam.NativeFieldInfoPtr_Next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeFieldInfoPtr_Y;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeFieldInfoPtr_Next;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
